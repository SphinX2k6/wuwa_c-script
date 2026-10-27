using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x020000AE RID: 174
	public struct FUFunctionParamsLayout5 : IUFunctionParamsLayout
	{
		// Token: 0x04000239 RID: 569
		public ushort Size;

		// Token: 0x0400023A RID: 570
		[FixedBuffer(typeof(ushort), 5)]
		public FUFunctionParamsLayout5.<Offset>e__FixedBuffer Offset;

		// Token: 0x02002B2D RID: 11053
		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(LayoutKind.Sequential, Size = 10)]
		public struct <Offset>e__FixedBuffer
		{
			// Token: 0x04016385 RID: 91013
			public ushort FixedElementField;
		}
	}
}
