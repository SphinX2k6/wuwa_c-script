using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x020000B7 RID: 183
	public struct FUFunctionParamsLayout14 : IUFunctionParamsLayout
	{
		// Token: 0x0400024B RID: 587
		public ushort Size;

		// Token: 0x0400024C RID: 588
		[FixedBuffer(typeof(ushort), 14)]
		public FUFunctionParamsLayout14.<Offset>e__FixedBuffer Offset;

		// Token: 0x02002B36 RID: 11062
		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(LayoutKind.Sequential, Size = 28)]
		public struct <Offset>e__FixedBuffer
		{
			// Token: 0x0401638E RID: 91022
			public ushort FixedElementField;
		}
	}
}
