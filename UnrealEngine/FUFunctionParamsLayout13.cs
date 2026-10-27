using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x020000B6 RID: 182
	public struct FUFunctionParamsLayout13 : IUFunctionParamsLayout
	{
		// Token: 0x04000249 RID: 585
		public ushort Size;

		// Token: 0x0400024A RID: 586
		[FixedBuffer(typeof(ushort), 13)]
		public FUFunctionParamsLayout13.<Offset>e__FixedBuffer Offset;

		// Token: 0x02002B35 RID: 11061
		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(LayoutKind.Sequential, Size = 26)]
		public struct <Offset>e__FixedBuffer
		{
			// Token: 0x0401638D RID: 91021
			public ushort FixedElementField;
		}
	}
}
