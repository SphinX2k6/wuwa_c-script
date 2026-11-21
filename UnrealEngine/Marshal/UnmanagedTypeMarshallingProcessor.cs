using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Marshal
{
	// Token: 0x020008BD RID: 2237
	internal class UnmanagedTypeMarshallingProcessor<[Nullable(2)] T> : IPropertyMarshallingProcessor<T>
	{
		// Token: 0x1700232A RID: 9002
		// (get) Token: 0x0600BE7C RID: 48764 RVA: 0x00130530 File Offset: 0x0012E730
		public static int Size { get; } = sizeof(T);

		// Token: 0x0600BE7D RID: 48765 RVA: 0x00130537 File Offset: 0x0012E737
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void Write(byte* buffer, ref int offset, [Nullable(1)] in T value)
		{
			*(T*)(buffer + offset) = value;
			offset += UnmanagedTypeMarshallingProcessor<T>.Size;
		}

		// Token: 0x0600BE7E RID: 48766 RVA: 0x00130552 File Offset: 0x0012E752
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		[return: Nullable(2)]
		public unsafe static T Read(byte* buffer, ref int offset)
		{
			T result = *(T*)(buffer + offset);
			offset += UnmanagedTypeMarshallingProcessor<T>.Size;
			return result;
		}

		// Token: 0x0600BE81 RID: 48769 RVA: 0x0013057C File Offset: 0x0012E77C
		unsafe void IPropertyMarshallingProcessor<!0>.Write(byte* buffer, ref int offset, [Nullable(1)] in T value)
		{
			UnmanagedTypeMarshallingProcessor<T>.Write(buffer, ref offset, value);
		}
	}
}
