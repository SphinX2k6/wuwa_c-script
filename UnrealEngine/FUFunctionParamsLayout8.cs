using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x020000B1 RID: 177
	public struct FUFunctionParamsLayout8 : IUFunctionParamsLayout
	{
		// Token: 0x0400023F RID: 575
		public ushort Size;

		// Token: 0x04000240 RID: 576
		[FixedBuffer(typeof(ushort), 8)]
		public FUFunctionParamsLayout8.<Offset>e__FixedBuffer Offset;

		// Token: 0x02002B30 RID: 11056
		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(LayoutKind.Sequential, Size = 16)]
		public struct <Offset>e__FixedBuffer
		{
			// Token: 0x04016388 RID: 91016
			public ushort FixedElementField;
		}
	}
}
