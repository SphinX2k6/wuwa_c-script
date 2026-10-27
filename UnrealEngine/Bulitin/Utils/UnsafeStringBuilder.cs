using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UnrealEngine.Utils;

namespace UnrealEngine.Bulitin.Utils
{
	// Token: 0x02002AE9 RID: 10985
	[NullableContext(1)]
	[Nullable(0)]
	public class UnsafeStringBuilder : IDisposable
	{
		// Token: 0x1700999E RID: 39326
		// (get) Token: 0x0602841B RID: 164891 RVA: 0x003D3C95 File Offset: 0x003D1E95
		public int Length
		{
			get
			{
				return this._length;
			}
		}

		// Token: 0x1700999F RID: 39327
		// (get) Token: 0x0602841C RID: 164892 RVA: 0x003D3C9D File Offset: 0x003D1E9D
		public int Capacity
		{
			get
			{
				return this._capacity;
			}
		}

		// Token: 0x0602841D RID: 164893 RVA: 0x003D3CA5 File Offset: 0x003D1EA5
		[NullableContext(0)]
		public unsafe char* GetBuffer()
		{
			return this._buffer;
		}

		// Token: 0x0602841E RID: 164894 RVA: 0x003D3CAD File Offset: 0x003D1EAD
		public UnsafeStringBuilder(int capacity)
		{
			if (capacity < 0)
			{
				throw new ArgumentOutOfRangeException("capacity");
			}
			if (capacity > 0)
			{
				this.EnsureCapacity(capacity);
			}
		}

		// Token: 0x0602841F RID: 164895 RVA: 0x003D3CD0 File Offset: 0x003D1ED0
		public unsafe void EnsureCapacity(int capacity)
		{
			if (this._capacity < capacity)
			{
				UIntPtr uintPtr = Math.Max((UIntPtr)((IntPtr)this._capacity * (IntPtr)2), (UIntPtr)((IntPtr)capacity));
				if (uintPtr > (UIntPtr)((IntPtr)2147483646))
				{
					uintPtr = (UIntPtr)((IntPtr)2147483646);
				}
				this._buffer = (char*)BuiltinUtils.Realloc((void*)this._buffer, (uintPtr + (UIntPtr)((IntPtr)1)) * (UIntPtr)((IntPtr)2), 0U);
				this._capacity = (int)uintPtr;
				this._buffer[this._length] = '\0';
			}
		}

		// Token: 0x06028420 RID: 164896 RVA: 0x003D3D3B File Offset: 0x003D1F3B
		public unsafe void Clear()
		{
			this._length = 0;
			if (this._buffer != null)
			{
				*this._buffer = '\0';
			}
		}

		// Token: 0x06028421 RID: 164897 RVA: 0x003D3D58 File Offset: 0x003D1F58
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe UnsafeStringBuilder Append(char c)
		{
			this.EnsureCapacity(this._length + 1);
			if (this._length < this._capacity)
			{
				ref short buffer = ref *(short*)this._buffer;
				int length = this._length;
				this._length = length + 1;
				*(ref buffer + (IntPtr)length * 2) = (short)c;
				this._buffer[this._length] = '\0';
			}
			return this;
		}

		// Token: 0x06028422 RID: 164898 RVA: 0x003D3DB1 File Offset: 0x003D1FB1
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public UnsafeStringBuilder AppendLine()
		{
			return this.Append('\n');
		}

		// Token: 0x06028423 RID: 164899 RVA: 0x003D3DBB File Offset: 0x003D1FBB
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public UnsafeStringBuilder AppendLine([Nullable(2)] string s)
		{
			this.Append(s);
			return this.Append('\n');
		}

		// Token: 0x06028424 RID: 164900 RVA: 0x003D3DCD File Offset: 0x003D1FCD
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public UnsafeStringBuilder Append([Nullable(2)] string s)
		{
			if (s == null || s.Length == 0)
			{
				return this;
			}
			return this.Append(s.AsSpan());
		}

		// Token: 0x06028425 RID: 164901 RVA: 0x003D3DE8 File Offset: 0x003D1FE8
		[NullableContext(0)]
		[return: Nullable(1)]
		public unsafe UnsafeStringBuilder Append(ReadOnlySpan<char> value)
		{
			if (value.Length == 0)
			{
				return this;
			}
			int num = value.Length;
			this.EnsureCapacity(this._length + num);
			num = Math.Min(num, this._capacity - this._length);
			fixed (char* pinnableReference = value.GetPinnableReference())
			{
				char* src = pinnableReference;
				BuiltinUtils.Memcpy((void*)(this._buffer + this._length), (void*)src, (UIntPtr)((IntPtr)num * (IntPtr)2));
			}
			this._length += num;
			this._buffer[this._length] = '\0';
			return this;
		}

		// Token: 0x06028426 RID: 164902 RVA: 0x003D3E74 File Offset: 0x003D2074
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe UnsafeStringBuilder Append([Nullable(2)] UnsafeStringBuilder value)
		{
			if (value != null && value.Length != 0)
			{
				return this.Append(new ReadOnlySpan<char>((void*)value.GetBuffer(), value.Length));
			}
			return this;
		}

		// Token: 0x06028427 RID: 164903 RVA: 0x003D3E9A File Offset: 0x003D209A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public UnsafeStringBuilder Append<[Nullable(2)] T>(T value)
		{
			if (value == null)
			{
				return this;
			}
			return this.Append(value.ToString());
		}

		// Token: 0x06028428 RID: 164904 RVA: 0x003D3EBC File Offset: 0x003D20BC
		public unsafe UnsafeStringBuilder RemoveLast(int length = 1)
		{
			if (this._length == 0)
			{
				return this;
			}
			ArgumentOutOfRangeException.ThrowIfNegative<int>(length, "length");
			if (length > this._length)
			{
				throw new ArgumentOutOfRangeException("length");
			}
			this._buffer[this._length - length] = '\0';
			this._length -= length;
			return this;
		}

		// Token: 0x06028429 RID: 164905 RVA: 0x003D3F15 File Offset: 0x003D2115
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public UnsafeStringBuilder Append([InterpolatedStringHandlerArgument("")] ref UnsafeStringBuilder.AppendInterpolatedStringHandler handler)
		{
			return this;
		}

		// Token: 0x0602842A RID: 164906 RVA: 0x003D3F18 File Offset: 0x003D2118
		public override string ToString()
		{
			if (this._buffer == null || this._length <= 0)
			{
				return string.Empty;
			}
			return new string(this._buffer, 0, this._length);
		}

		// Token: 0x0602842B RID: 164907 RVA: 0x003D3F45 File Offset: 0x003D2145
		public void Dispose()
		{
			this.OnDispose();
			GC.SuppressFinalize(this);
		}

		// Token: 0x0602842C RID: 164908 RVA: 0x003D3F54 File Offset: 0x003D2154
		~UnsafeStringBuilder()
		{
			this.OnDispose();
		}

		// Token: 0x0602842D RID: 164909 RVA: 0x003D3F80 File Offset: 0x003D2180
		private unsafe void OnDispose()
		{
			if (this._buffer != null)
			{
				BuiltinUtils.Free((void*)this._buffer);
				this._buffer = null;
				this._length = 0;
				this._capacity = 0;
			}
		}

		// Token: 0x04016290 RID: 90768
		private const int SIZE = 2;

		// Token: 0x04016291 RID: 90769
		[Nullable(0)]
		private unsafe char* _buffer;

		// Token: 0x04016292 RID: 90770
		private int _length;

		// Token: 0x04016293 RID: 90771
		private int _capacity;

		// Token: 0x02003C0E RID: 15374
		[Nullable(0)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[InterpolatedStringHandler]
		public struct AppendInterpolatedStringHandler
		{
			// Token: 0x060285D9 RID: 165337 RVA: 0x003D58FC File Offset: 0x003D3AFC
			public AppendInterpolatedStringHandler(int literalLength, int formattedCount, UnsafeStringBuilder stringBuilder)
			{
				this.StringBuilder = stringBuilder;
				stringBuilder.EnsureCapacity(Math.Max(256, literalLength + formattedCount * 11));
			}

			// Token: 0x060285DA RID: 165338 RVA: 0x003D591B File Offset: 0x003D3B1B
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public void AppendLiteral(string value)
			{
				this.StringBuilder.Append(value);
			}

			// Token: 0x060285DB RID: 165339 RVA: 0x003D592A File Offset: 0x003D3B2A
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public void AppendFormatted<[Nullable(2)] T>(T value)
			{
				this.StringBuilder.Append<T>(value);
			}

			// Token: 0x060285DC RID: 165340 RVA: 0x003D5939 File Offset: 0x003D3B39
			[NullableContext(0)]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public void AppendFormatted(ReadOnlySpan<char> value)
			{
				this.StringBuilder.Append(value);
			}

			// Token: 0x060285DD RID: 165341 RVA: 0x003D5948 File Offset: 0x003D3B48
			[NullableContext(2)]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public void AppendFormatted(UnsafeStringBuilder value)
			{
				this.StringBuilder.Append(value);
			}

			// Token: 0x060285DE RID: 165342 RVA: 0x003D5957 File Offset: 0x003D3B57
			[NullableContext(2)]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public void AppendFormatted(string value)
			{
				this.StringBuilder.Append(value);
			}

			// Token: 0x04017E46 RID: 97862
			internal readonly UnsafeStringBuilder StringBuilder;
		}
	}
}
