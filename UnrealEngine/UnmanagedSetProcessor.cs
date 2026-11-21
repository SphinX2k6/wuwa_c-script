using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x02000052 RID: 82
	public class UnmanagedSetProcessor<[IsUnmanaged] T> : NativeSetProcessor<T> where T : struct, ValueType
	{
		// Token: 0x06000946 RID: 2374 RVA: 0x0000E8BE File Offset: 0x0000CABE
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe override T Get(IntPtr data, int index)
		{
			return *(data + (IntPtr)index);
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x0000E8C9 File Offset: 0x0000CAC9
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe override void Set(IntPtr data, int index, T value)
		{
			*(data + (IntPtr)(index * UnmanagedSetProcessor<T>.s_Size)) = value;
		}

		// Token: 0x04000130 RID: 304
		private static readonly int s_Size = sizeof(T);
	}
}
