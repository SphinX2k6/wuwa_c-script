using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x020000B0 RID: 176
	public struct FUFunctionParamsLayout7 : IUFunctionParamsLayout
	{
		// Token: 0x0400023D RID: 573
		public ushort Size;

		// Token: 0x0400023E RID: 574
		[FixedBuffer(typeof(ushort), 7)]
		public FUFunctionParamsLayout7.<Offset>e__FixedBuffer Offset;

		// Token: 0x02002B2F RID: 11055
		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(LayoutKind.Sequential, Size = 14)]
		public struct <Offset>e__FixedBuffer
		{
			// Token: 0x04016387 RID: 91015
			public ushort FixedElementField;
		}
	}
}
