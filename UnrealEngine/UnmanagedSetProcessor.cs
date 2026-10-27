using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x0200006D RID: 109
	public class UnmanagedSetProcessor<[IsUnmanaged] T> : NativeSetProcessor<T> where T : struct, ValueType
	{
		// Token: 0x06000DB8 RID: 3512 RVA: 0x00013C16 File Offset: 0x00011E16
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe override T Get(IntPtr data, int index)
		{
			return *(data + (IntPtr)index);
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x00013C21 File Offset: 0x00011E21
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe override void Set(IntPtr data, int index, T value)
		{
			*(data + (IntPtr)(index * UnmanagedSetProcessor<T>.s_Size)) = value;
		}

		// Token: 0x04000177 RID: 375
		private static readonly int s_Size = sizeof(T);
	}
}
