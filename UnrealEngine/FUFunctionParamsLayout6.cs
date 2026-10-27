using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x020000AF RID: 175
	public struct FUFunctionParamsLayout6 : IUFunctionParamsLayout
	{
		// Token: 0x0400023B RID: 571
		public ushort Size;

		// Token: 0x0400023C RID: 572
		[FixedBuffer(typeof(ushort), 6)]
		public FUFunctionParamsLayout6.<Offset>e__FixedBuffer Offset;

		// Token: 0x02002B2E RID: 11054
		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(LayoutKind.Sequential, Size = 12)]
		public struct <Offset>e__FixedBuffer
		{
			// Token: 0x04016386 RID: 91014
			public ushort FixedElementField;
		}
	}
}
