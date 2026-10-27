using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x020000B4 RID: 180
	public struct FUFunctionParamsLayout11 : IUFunctionParamsLayout
	{
		// Token: 0x04000245 RID: 581
		public ushort Size;

		// Token: 0x04000246 RID: 582
		[FixedBuffer(typeof(ushort), 11)]
		public FUFunctionParamsLayout11.<Offset>e__FixedBuffer Offset;

		// Token: 0x02002B33 RID: 11059
		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(LayoutKind.Sequential, Size = 22)]
		public struct <Offset>e__FixedBuffer
		{
			// Token: 0x0401638B RID: 91019
			public ushort FixedElementField;
		}
	}
}
