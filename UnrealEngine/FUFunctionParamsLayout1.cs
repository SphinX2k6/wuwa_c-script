using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x020000AA RID: 170
	public struct FUFunctionParamsLayout1 : IUFunctionParamsLayout
	{
		// Token: 0x04000231 RID: 561
		public ushort Size;

		// Token: 0x04000232 RID: 562
		[FixedBuffer(typeof(ushort), 1)]
		public FUFunctionParamsLayout1.<Offset>e__FixedBuffer Offset;

		// Token: 0x02002B29 RID: 11049
		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(LayoutKind.Sequential, Size = 2)]
		public struct <Offset>e__FixedBuffer
		{
			// Token: 0x04016381 RID: 91009
			public ushort FixedElementField;
		}
	}
}
