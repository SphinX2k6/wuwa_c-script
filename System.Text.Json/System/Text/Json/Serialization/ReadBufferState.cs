using System;
using System.Buffers;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Text.Json.Serialization
{
	// Token: 0x020000AD RID: 173
	[StructLayout(LayoutKind.Auto)]
	internal struct ReadBufferState : IDisposable
	{
		// Token: 0x060009D9 RID: 2521 RVA: 0x0002A548 File Offset: 0x00028748
		public ReadBufferState(int initialBufferSize)
		{
			this._unsuccessfulReadCount = 0;
			this._buffer = ArrayPool<byte>.Shared.Rent(Math.Max(initialBufferSize, JsonConstants.Utf8Bom.Length));
			this._maxCount = (this._count = (int)(this._offset = 0));
			this._isFirstBlock = true;
			this._isFinalBlock = false;
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060009DA RID: 2522 RVA: 0x0002A5A6 File Offset: 0x000287A6
		public readonly bool IsFinalBlock
		{
			get
			{
				return this._isFinalBlock;
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060009DB RID: 2523 RVA: 0x0002A5AE File Offset: 0x000287AE
		public readonly ReadOnlySpan<byte> Bytes
		{
			get
			{
				return this._buffer.AsSpan((int)this._offset, this._count);
			}
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x0002A5CC File Offset: 0x000287CC
		public readonly ValueTask<ReadBufferState> ReadFromStreamAsync(Stream utf8Json, CancellationToken cancellationToken, bool fillBuffer = true)
		{
			ReadBufferState.<ReadFromStreamAsync>d__13 <ReadFromStreamAsync>d__;
			<ReadFromStreamAsync>d__.<>t__builder = AsyncValueTaskMethodBuilder<ReadBufferState>.Create();
			<ReadFromStreamAsync>d__.<>4__this = this;
			<ReadFromStreamAsync>d__.utf8Json = utf8Json;
			<ReadFromStreamAsync>d__.cancellationToken = cancellationToken;
			<ReadFromStreamAsync>d__.fillBuffer = fillBuffer;
			<ReadFromStreamAsync>d__.<>1__state = -1;
			<ReadFromStreamAsync>d__.<>t__builder.Start<ReadBufferState.<ReadFromStreamAsync>d__13>(ref <ReadFromStreamAsync>d__);
			return <ReadFromStreamAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x0002A62C File Offset: 0x0002882C
		public void ReadFromStream(Stream utf8Json)
		{
			for (;;)
			{
				int num = utf8Json.Read(this._buffer.AsSpan(this._count));
				if (num == 0)
				{
					break;
				}
				this._count += num;
				if (this._count >= this._buffer.Length)
				{
					goto IL_42;
				}
			}
			this._isFinalBlock = true;
			IL_42:
			this.ProcessReadBytes();
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x0002A684 File Offset: 0x00028884
		public void AdvanceBuffer(int bytesConsumed)
		{
			this._unsuccessfulReadCount = ((bytesConsumed == 0) ? (this._unsuccessfulReadCount + 1) : 0);
			this._count -= bytesConsumed;
			if (!this._isFinalBlock)
			{
				if (this._count > this._buffer.Length / 2)
				{
					byte[] buffer = this._buffer;
					int maxCount = this._maxCount;
					byte[] array = ArrayPool<byte>.Shared.Rent((this._buffer.Length < 1073741823) ? (this._buffer.Length * 2) : int.MaxValue);
					Buffer.BlockCopy(buffer, (int)this._offset + bytesConsumed, array, 0, this._count);
					this._buffer = array;
					this._maxCount = this._count;
					new Span<byte>(buffer, 0, maxCount).Clear();
					ArrayPool<byte>.Shared.Return(buffer, false);
				}
				else if (this._count != 0)
				{
					Buffer.BlockCopy(this._buffer, (int)this._offset + bytesConsumed, this._buffer, 0, this._count);
				}
			}
			this._offset = 0;
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x0002A784 File Offset: 0x00028984
		private void ProcessReadBytes()
		{
			if (this._count > this._maxCount)
			{
				this._maxCount = this._count;
			}
			if (this._isFirstBlock)
			{
				this._isFirstBlock = false;
				if (this._buffer.AsSpan(0, this._count).StartsWith(JsonConstants.Utf8Bom))
				{
					this._offset = (byte)JsonConstants.Utf8Bom.Length;
					this._count -= JsonConstants.Utf8Bom.Length;
				}
			}
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x0002A808 File Offset: 0x00028A08
		public void Dispose()
		{
			new Span<byte>(this._buffer, 0, this._maxCount).Clear();
			byte[] buffer = this._buffer;
			this._buffer = null;
			ArrayPool<byte>.Shared.Return(buffer, false);
		}

		// Token: 0x040002B8 RID: 696
		private byte[] _buffer;

		// Token: 0x040002B9 RID: 697
		private byte _offset;

		// Token: 0x040002BA RID: 698
		private int _count;

		// Token: 0x040002BB RID: 699
		private int _maxCount;

		// Token: 0x040002BC RID: 700
		private bool _isFirstBlock;

		// Token: 0x040002BD RID: 701
		private bool _isFinalBlock;

		// Token: 0x040002BE RID: 702
		private int _unsuccessfulReadCount;
	}
}
