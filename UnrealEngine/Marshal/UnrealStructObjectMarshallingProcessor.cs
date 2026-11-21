using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Marshal
{
	// Token: 0x020008BF RID: 2239
	internal class UnrealStructObjectMarshallingProcessor<[Nullable(2)] T> : IPropertyMarshallingProcessor<!0>
	{
		// Token: 0x1700232C RID: 9004
		// (get) Token: 0x0600BE88 RID: 48776 RVA: 0x001305F5 File Offset: 0x0012E7F5
		public static int Size { get; } = sizeof(void*);

		// Token: 0x0600BE89 RID: 48777 RVA: 0x001305FC File Offset: 0x0012E7FC
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void Write(byte* buffer, ref int offset, [Nullable(1)] in T value)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600BE8A RID: 48778 RVA: 0x00130603 File Offset: 0x0012E803
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		[return: Nullable(2)]
		public unsafe static T Read(byte* buffer, ref int offset)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600BE8D RID: 48781 RVA: 0x0013061F File Offset: 0x0012E81F
		unsafe void IPropertyMarshallingProcessor<!0>.Write(byte* buffer, ref int offset, [Nullable(1)] in T value)
		{
			UnrealStructObjectMarshallingProcessor<T>.Write(buffer, ref offset, value);
		}
	}
}
