using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x020000B5 RID: 181
	public struct FUFunctionParamsLayout12 : IUFunctionParamsLayout
	{
		// Token: 0x04000247 RID: 583
		public ushort Size;

		// Token: 0x04000248 RID: 584
		[FixedBuffer(typeof(ushort), 12)]
		public FUFunctionParamsLayout12.<Offset>e__FixedBuffer Offset;

		// Token: 0x02002B34 RID: 11060
		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(LayoutKind.Sequential, Size = 24)]
		public struct <Offset>e__FixedBuffer
		{
			// Token: 0x0401638C RID: 91020
			public ushort FixedElementField;
		}
	}
}
