using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x020000B9 RID: 185
	public struct FUFunctionParamsLayout16 : IUFunctionParamsLayout
	{
		// Token: 0x0400024F RID: 591
		public ushort Size;

		// Token: 0x04000250 RID: 592
		[FixedBuffer(typeof(ushort), 16)]
		public FUFunctionParamsLayout16.<Offset>e__FixedBuffer Offset;

		// Token: 0x02002B38 RID: 11064
		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(LayoutKind.Sequential, Size = 32)]
		public struct <Offset>e__FixedBuffer
		{
			// Token: 0x04016390 RID: 91024
			public ushort FixedElementField;
		}
	}
}
