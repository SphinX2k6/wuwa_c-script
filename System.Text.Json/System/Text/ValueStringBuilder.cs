using System;
using System.Buffers;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Text
{
	// Token: 0x02000006 RID: 6
	[CompilerFeatureRequired("RefStructs")]
	[DefaultMember("Item")]
	internal ref struct ValueStringBuilder
	{
		// Token: 0x060000DB RID: 219 RVA: 0x00002C3C File Offset: 0x00000E3C
		public ValueStringBuilder(Span<char> initialBuffer)
		{
			this._arrayToReturnToPool = null;
			this._chars = initialBuffer;
			this._pos = 0;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002C53 File Offset: 0x00000E53
		public ValueStringBuilder(int initialCapacity)
		{
			this._arrayToReturnToPool = ArrayPool<char>.Shared.Rent(initialCapacity);
			this._chars = this._arrayToReturnToPool;
			this._pos = 0;
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00002C7E File Offset: 0x00000E7E
		public int Length
		{
			get
			{
				return this._pos;
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002C88 File Offset: 0x00000E88
		public override string ToString()
		{
			string result = this._chars.Slice(0, this._pos).ToString();
			this.Dispose();
			return result;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002CBC File Offset: 0x00000EBC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe void Append(char c)
		{
			int pos = this._pos;
			Span<char> chars = this._chars;
			if (pos < chars.Length)
			{
				*chars[pos] = c;
				this._pos = pos + 1;
				return;
			}
			this.GrowAndAppend(c);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002CFC File Offset: 0x00000EFC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe void Append(string s)
		{
			if (s == null)
			{
				return;
			}
			int pos = this._pos;
			if (s.Length == 1 && pos < this._chars.Length)
			{
				*this._chars[pos] = s[0];
				this._pos = pos + 1;
				return;
			}
			this.AppendSlow(s);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002D50 File Offset: 0x00000F50
		private void AppendSlow(string s)
		{
			int pos = this._pos;
			if (pos > this._chars.Length - s.Length)
			{
				this.Grow(s.Length);
			}
			s.CopyTo(this._chars.Slice(pos));
			this._pos += s.Length;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002DAC File Offset: 0x00000FAC
		public void Append([ScopedRef] ReadOnlySpan<char> value)
		{
			if (this._pos > this._chars.Length - value.Length)
			{
				this.Grow(value.Length);
			}
			value.CopyTo(this._chars.Slice(this._pos));
			this._pos += value.Length;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002E0D File Offset: 0x0000100D
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void GrowAndAppend(char c)
		{
			this.Grow(1);
			this.Append(c);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002E20 File Offset: 0x00001020
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Grow(int additionalCapacityBeyondPos)
		{
			int minimumLength = (int)Math.Max((uint)(this._pos + additionalCapacityBeyondPos), Math.Min((uint)(this._chars.Length * 2), 2147483591U));
			char[] array = ArrayPool<char>.Shared.Rent(minimumLength);
			this._chars.Slice(0, this._pos).CopyTo(array);
			char[] arrayToReturnToPool = this._arrayToReturnToPool;
			this._chars = (this._arrayToReturnToPool = array);
			if (arrayToReturnToPool != null)
			{
				ArrayPool<char>.Shared.Return(arrayToReturnToPool, false);
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002EAC File Offset: 0x000010AC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Dispose()
		{
			char[] arrayToReturnToPool = this._arrayToReturnToPool;
			this = default(ValueStringBuilder);
			if (arrayToReturnToPool != null)
			{
				ArrayPool<char>.Shared.Return(arrayToReturnToPool, false);
			}
		}

		// Token: 0x04000003 RID: 3
		private char[] _arrayToReturnToPool;

		// Token: 0x04000004 RID: 4
		private Span<char> _chars;

		// Token: 0x04000005 RID: 5
		private int _pos;
	}
}
