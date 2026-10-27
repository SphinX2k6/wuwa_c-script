using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Marshal
{
	// Token: 0x02002B0C RID: 11020
	internal interface IPropertyMarshallingProcessor<[Nullable(2)] T>
	{
		// Token: 0x170099A0 RID: 39328
		// (get) Token: 0x060284BF RID: 165055
		int Size { get; }

		// Token: 0x060284C0 RID: 165056
		public unsafe abstract static void Write(byte* buffer, ref int offset, [Nullable(1)] in T value);

		// Token: 0x060284C1 RID: 165057
		[return: Nullable(2)]
		public unsafe abstract static T Read(byte* buffer, ref int offset);
	}
}
