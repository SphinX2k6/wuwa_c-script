using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Marshal
{
	// Token: 0x02002B0D RID: 11021
	internal class UnmanagedTypeMarshallingProcessor<[Nullable(2)] T> : IPropertyMarshallingProcessor<T>
	{
		// Token: 0x170099A1 RID: 39329
		// (get) Token: 0x060284C2 RID: 165058 RVA: 0x003D51D4 File Offset: 0x003D33D4
		public static int Size { get; } = sizeof(T);

		// Token: 0x060284C3 RID: 165059 RVA: 0x003D51DB File Offset: 0x003D33DB
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void Write(byte* buffer, ref int offset, [Nullable(1)] in T value)
		{
			*(T*)(buffer + offset) = value;
			offset += UnmanagedTypeMarshallingProcessor<T>.Size;
		}

		// Token: 0x060284C4 RID: 165060 RVA: 0x003D51F6 File Offset: 0x003D33F6
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		[return: Nullable(2)]
		public unsafe static T Read(byte* buffer, ref int offset)
		{
			T result = *(T*)(buffer + offset);
			offset += UnmanagedTypeMarshallingProcessor<T>.Size;
			return result;
		}

		// Token: 0x060284C7 RID: 165063 RVA: 0x003D5220 File Offset: 0x003D3420
		unsafe void IPropertyMarshallingProcessor<!0>.Write(byte* buffer, ref int offset, [Nullable(1)] in T value)
		{
			UnmanagedTypeMarshallingProcessor<T>.Write(buffer, ref offset, value);
		}
	}
}
