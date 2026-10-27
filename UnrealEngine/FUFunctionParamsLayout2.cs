using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x020000AB RID: 171
	public struct FUFunctionParamsLayout2 : IUFunctionParamsLayout
	{
		// Token: 0x04000233 RID: 563
		public ushort Size;

		// Token: 0x04000234 RID: 564
		[FixedBuffer(typeof(ushort), 2)]
		public FUFunctionParamsLayout2.<Offset>e__FixedBuffer Offset;

		// Token: 0x02002B2A RID: 11050
		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(LayoutKind.Sequential, Size = 4)]
		public struct <Offset>e__FixedBuffer
		{
			// Token: 0x04016382 RID: 91010
			public ushort FixedElementField;
		}
	}
}
