using System;
using System.Buffers;
using System.IO;
using System.IO.Pipelines;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Text.Json
{
	// Token: 0x0200000A RID: 10
	internal sealed class PooledByteBufferWriter : PipeWriter, IDisposable
	{
		// Token: 0x060000EE RID: 238 RVA: 0x000030E1 File Offset: 0x000012E1
		private PooledByteBufferWriter()
		{
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000030E9 File Offset: 0x000012E9
		public PooledByteBufferWriter(int initialCapacity) : this()
		{
			this._rentedBuffer = ArrayPool<byte>.Shared.Rent(initialCapacity);
			this._index = 0;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00003109 File Offset: 0x00001309
		public PooledByteBufferWriter(int initialCapacity, Stream stream) : this(initialCapacity)
		{
			this._stream = stream;
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00003119 File Offset: 0x00001319
		public ReadOnlyMemory<byte> WrittenMemory
		{
			get
			{
				return this._rentedBuffer.AsMemory(0, this._index);
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00003132 File Offset: 0x00001332
		public int Capacity
		{
			get
			{
				return this._rentedBuffer.Length;
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000313C File Offset: 0x0000133C
		public void Clear()
		{
			this.ClearHelper();
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00003144 File Offset: 0x00001344
		public void ClearAndReturnBuffers()
		{
			this.ClearHelper();
			byte[] rentedBuffer = this._rentedBuffer;
			this._rentedBuffer = null;
			ArrayPool<byte>.Shared.Return(rentedBuffer, false);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00003174 File Offset: 0x00001374
		private void ClearHelper()
		{
			this._rentedBuffer.AsSpan(0, this._index).Clear();
			this._index = 0;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000031A4 File Offset: 0x000013A4
		public void Dispose()
		{
			if (this._rentedBuffer == null)
			{
				return;
			}
			this.ClearHelper();
			byte[] rentedBuffer = this._rentedBuffer;
			this._rentedBuffer = null;
			ArrayPool<byte>.Shared.Return(rentedBuffer, false);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x000031DA File Offset: 0x000013DA
		public void InitializeEmptyInstance(int initialCapacity)
		{
			this._rentedBuffer = ArrayPool<byte>.Shared.Rent(initialCapacity);
			this._index = 0;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x000031F4 File Offset: 0x000013F4
		public static PooledByteBufferWriter CreateEmptyInstanceForCaching()
		{
			return new PooledByteBufferWriter();
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x000031FB File Offset: 0x000013FB
		public override void Advance(int count)
		{
			this._index += count;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000320B File Offset: 0x0000140B
		public override Memory<byte> GetMemory(int sizeHint = 256)
		{
			this.CheckAndResizeBuffer(sizeHint);
			return this._rentedBuffer.AsMemory(this._index);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00003225 File Offset: 0x00001425
		public override Span<byte> GetSpan(int sizeHint = 256)
		{
			this.CheckAndResizeBuffer(sizeHint);
			return this._rentedBuffer.AsSpan(this._index);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00003240 File Offset: 0x00001440
		internal void WriteToStream(Stream destination)
		{
			destination.Write(this.WrittenMemory.Span);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00003264 File Offset: 0x00001464
		private void CheckAndResizeBuffer(int sizeHint)
		{
			int num = this._rentedBuffer.Length;
			int num2 = num - this._index;
			if (this._index >= 1073741795)
			{
				sizeHint = Math.Max(sizeHint, 2147483591 - num);
			}
			if (sizeHint > num2)
			{
				int num3 = Math.Max(sizeHint, num);
				int num4 = num + num3;
				if (num4 > 2147483591)
				{
					num4 = num + sizeHint;
					if (num4 > 2147483591)
					{
						ThrowHelper.ThrowOutOfMemoryException_BufferMaximumSizeExceeded((uint)num4);
					}
				}
				byte[] rentedBuffer = this._rentedBuffer;
				this._rentedBuffer = ArrayPool<byte>.Shared.Rent(num4);
				Span<byte> span = rentedBuffer.AsSpan(0, this._index);
				span.CopyTo(this._rentedBuffer);
				span.Clear();
				ArrayPool<byte>.Shared.Return(rentedBuffer, false);
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00003318 File Offset: 0x00001518
		public override ValueTask<FlushResult> FlushAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			PooledByteBufferWriter.<FlushAsync>d__27 <FlushAsync>d__;
			<FlushAsync>d__.<>t__builder = AsyncValueTaskMethodBuilder<FlushResult>.Create();
			<FlushAsync>d__.<>4__this = this;
			<FlushAsync>d__.cancellationToken = cancellationToken;
			<FlushAsync>d__.<>1__state = -1;
			<FlushAsync>d__.<>t__builder.Start<PooledByteBufferWriter.<FlushAsync>d__27>(ref <FlushAsync>d__);
			return <FlushAsync>d__.<>t__builder.Task;
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00003363 File Offset: 0x00001563
		public override bool CanGetUnflushedBytes
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00003366 File Offset: 0x00001566
		public override long UnflushedBytes
		{
			get
			{
				return (long)this._index;
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000336F File Offset: 0x0000156F
		public override void CancelPendingFlush()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000336F File Offset: 0x0000156F
		public override void Complete(Exception exception = null)
		{
			throw new NotImplementedException();
		}

		// Token: 0x04000007 RID: 7
		private byte[] _rentedBuffer;

		// Token: 0x04000008 RID: 8
		private int _index;

		// Token: 0x04000009 RID: 9
		private readonly Stream _stream;
	}
}
