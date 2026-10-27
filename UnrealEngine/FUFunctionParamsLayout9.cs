using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x020000B2 RID: 178
	public struct FUFunctionParamsLayout9 : IUFunctionParamsLayout
	{
		// Token: 0x04000241 RID: 577
		public ushort Size;

		// Token: 0x04000242 RID: 578
		[FixedBuffer(typeof(ushort), 9)]
		public FUFunctionParamsLayout9.<Offset>e__FixedBuffer Offset;

		// Token: 0x02002B31 RID: 11057
		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(LayoutKind.Sequential, Size = 18)]
		public struct <Offset>e__FixedBuffer
		{
			// Token: 0x04016389 RID: 91017
			public ushort FixedElementField;
		}
	}
}
