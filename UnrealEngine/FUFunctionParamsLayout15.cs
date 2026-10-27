using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x020000B8 RID: 184
	public struct FUFunctionParamsLayout15 : IUFunctionParamsLayout
	{
		// Token: 0x0400024D RID: 589
		public ushort Size;

		// Token: 0x0400024E RID: 590
		[FixedBuffer(typeof(ushort), 15)]
		public FUFunctionParamsLayout15.<Offset>e__FixedBuffer Offset;

		// Token: 0x02002B37 RID: 11063
		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(LayoutKind.Sequential, Size = 30)]
		public struct <Offset>e__FixedBuffer
		{
			// Token: 0x0401638F RID: 91023
			public ushort FixedElementField;
		}
	}
}
