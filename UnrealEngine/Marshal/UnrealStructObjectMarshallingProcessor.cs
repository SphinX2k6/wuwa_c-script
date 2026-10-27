using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Marshal
{
	// Token: 0x02002B0F RID: 11023
	internal class UnrealStructObjectMarshallingProcessor<[Nullable(2)] T> : IPropertyMarshallingProcessor<!0>
	{
		// Token: 0x170099A3 RID: 39331
		// (get) Token: 0x060284CE RID: 165070 RVA: 0x003D5299 File Offset: 0x003D3499
		public static int Size { get; } = sizeof(void*);

		// Token: 0x060284CF RID: 165071 RVA: 0x003D52A0 File Offset: 0x003D34A0
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void Write(byte* buffer, ref int offset, [Nullable(1)] in T value)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060284D0 RID: 165072 RVA: 0x003D52A7 File Offset: 0x003D34A7
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		[return: Nullable(2)]
		public unsafe static T Read(byte* buffer, ref int offset)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060284D3 RID: 165075 RVA: 0x003D52C3 File Offset: 0x003D34C3
		unsafe void IPropertyMarshallingProcessor<!0>.Write(byte* buffer, ref int offset, [Nullable(1)] in T value)
		{
			UnrealStructObjectMarshallingProcessor<T>.Write(buffer, ref offset, value);
		}
	}
}
