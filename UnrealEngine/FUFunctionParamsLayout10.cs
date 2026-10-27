using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x020000B3 RID: 179
	public struct FUFunctionParamsLayout10 : IUFunctionParamsLayout
	{
		// Token: 0x04000243 RID: 579
		public ushort Size;

		// Token: 0x04000244 RID: 580
		[FixedBuffer(typeof(ushort), 10)]
		public FUFunctionParamsLayout10.<Offset>e__FixedBuffer Offset;

		// Token: 0x02002B32 RID: 11058
		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(LayoutKind.Sequential, Size = 20)]
		public struct <Offset>e__FixedBuffer
		{
			// Token: 0x0401638A RID: 91018
			public ushort FixedElementField;
		}
	}
}
