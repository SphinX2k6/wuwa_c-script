using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UnrealEngine.Utils;

namespace UnrealEngine.Bulitin.Utils
{
	// Token: 0x02000898 RID: 2200
	[NullableContext(1)]
	[Nullable(0)]
	public class UnsafeStringBuilder : IDisposable
	{
		// Token: 0x17002327 RID: 8999
		// (get) Token: 0x0600BDD0 RID: 48592 RVA: 0x0012EFA5 File Offset: 0x0012D1A5
		public int Length
		{
			get
			{
				return this._length;
			}
		}

		// Token: 0x17002328 RID: 9000
		// (get) Token: 0x0600BDD1 RID: 48593 RVA: 0x0012EFAD File Offset: 0x0012D1AD
		public int Capacity
		{
			get
			{
				return this._capacity;
			}
		}

		// Token: 0x0600BDD2 RID: 48594 RVA: 0x0012EFB5 File Offset: 0x0012D1B5
		[NullableContext(0)]
		public unsafe char* GetBuffer()
		{
			return this._buffer;
		}

		// Token: 0x0600BDD3 RID: 48595 RVA: 0x0012EFBD File Offset: 0x0012D1BD
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

		// Token: 0x0600BDD4 RID: 48596 RVA: 0x0012EFE0 File Offset: 0x0012D1E0
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

		// Token: 0x0600BDD5 RID: 48597 RVA: 0x0012F04B File Offset: 0x0012D24B
		public unsafe void Clear()
		{
			this._length = 0;
			if (this._buffer != null)
			{
				*this._buffer = '\0';
			}
		}

		// Token: 0x0600BDD6 RID: 48598 RVA: 0x0012F068 File Offset: 0x0012D268
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

		// Token: 0x0600BDD7 RID: 48599 RVA: 0x0012F0C1 File Offset: 0x0012D2C1
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public UnsafeStringBuilder AppendLine()
		{
			return this.Append('\n');
		}

		// Token: 0x0600BDD8 RID: 48600 RVA: 0x0012F0CB File Offset: 0x0012D2CB
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public UnsafeStringBuilder AppendLine([Nullable(2)] string s)
		{
			this.Append(s);
			return this.Append('\n');
		}

		// Token: 0x0600BDD9 RID: 48601 RVA: 0x0012F0DD File Offset: 0x0012D2DD
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public UnsafeStringBuilder Append([Nullable(2)] string s)
		{
			if (s == null || s.Length == 0)
			{
				return this;
			}
			return this.Append(s.AsSpan());
		}

		// Token: 0x0600BDDA RID: 48602 RVA: 0x0012F0F8 File Offset: 0x0012D2F8
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

		// Token: 0x0600BDDB RID: 48603 RVA: 0x0012F184 File Offset: 0x0012D384
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe UnsafeStringBuilder Append([Nullable(2)] UnsafeStringBuilder value)
		{
			if (value != null && value.Length != 0)
			{
				return this.Append(new ReadOnlySpan<char>((void*)value.GetBuffer(), value.Length));
			}
			return this;
		}

		// Token: 0x0600BDDC RID: 48604 RVA: 0x0012F1AA File Offset: 0x0012D3AA
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public UnsafeStringBuilder Append<[Nullable(2)] T>(T value)
		{
			if (value == null)
			{
				return this;
			}
			return this.Append(value.ToString());
		}

		// Token: 0x0600BDDD RID: 48605 RVA: 0x0012F1CC File Offset: 0x0012D3CC
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

		// Token: 0x0600BDDE RID: 48606 RVA: 0x0012F225 File Offset: 0x0012D425
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public UnsafeStringBuilder Append([InterpolatedStringHandlerArgument("")] ref UnsafeStringBuilder.AppendInterpolatedStringHandler handler)
		{
			return this;
		}

		// Token: 0x0600BDDF RID: 48607 RVA: 0x0012F228 File Offset: 0x0012D428
		public override string ToString()
		{
			if (this._buffer == null || this._length <= 0)
			{
				return string.Empty;
			}
			return new string(this._buffer, 0, this._length);
		}

		// Token: 0x0600BDE0 RID: 48608 RVA: 0x0012F255 File Offset: 0x0012D455
		public void Dispose()
		{
			this.OnDispose();
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600BDE1 RID: 48609 RVA: 0x0012F264 File Offset: 0x0012D464
		~UnsafeStringBuilder()
		{
			this.OnDispose();
		}

		// Token: 0x0600BDE2 RID: 48610 RVA: 0x0012F290 File Offset: 0x0012D490
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

		// Token: 0x040056A7 RID: 22183
		private const int SIZE = 2;

		// Token: 0x040056A8 RID: 22184
		[Nullable(0)]
		private unsafe char* _buffer;

		// Token: 0x040056A9 RID: 22185
		private int _length;

		// Token: 0x040056AA RID: 22186
		private int _capacity;

		// Token: 0x02001417 RID: 5143
		[Nullable(0)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[InterpolatedStringHandler]
		public struct AppendInterpolatedStringHandler
		{
			// Token: 0x0600BF3A RID: 48954 RVA: 0x00130C68 File Offset: 0x0012EE68
			public AppendInterpolatedStringHandler(int literalLength, int formattedCount, UnsafeStringBuilder stringBuilder)
			{
				this.StringBuilder = stringBuilder;
				stringBuilder.EnsureCapacity(Math.Max(256, literalLength + formattedCount * 11));
			}

			// Token: 0x0600BF3B RID: 48955 RVA: 0x00130C87 File Offset: 0x0012EE87
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public void AppendLiteral(string value)
			{
				this.StringBuilder.Append(value);
			}

			// Token: 0x0600BF3C RID: 48956 RVA: 0x00130C96 File Offset: 0x0012EE96
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public void AppendFormatted<[Nullable(2)] T>(T value)
			{
				this.StringBuilder.Append<T>(value);
			}

			// Token: 0x0600BF3D RID: 48957 RVA: 0x00130CA5 File Offset: 0x0012EEA5
			[NullableContext(0)]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public void AppendFormatted(ReadOnlySpan<char> value)
			{
				this.StringBuilder.Append(value);
			}

			// Token: 0x0600BF3E RID: 48958 RVA: 0x00130CB4 File Offset: 0x0012EEB4
			[NullableContext(2)]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public void AppendFormatted(UnsafeStringBuilder value)
			{
				this.StringBuilder.Append(value);
			}

			// Token: 0x0600BF3F RID: 48959 RVA: 0x00130CC3 File Offset: 0x0012EEC3
			[NullableContext(2)]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public void AppendFormatted(string value)
			{
				this.StringBuilder.Append(value);
			}

			// Token: 0x040068C7 RID: 26823
			internal readonly UnsafeStringBuilder StringBuilder;
		}
	}
}
