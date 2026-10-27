using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x020000AC RID: 172
	public struct FUFunctionParamsLayout3 : IUFunctionParamsLayout
	{
		// Token: 0x04000235 RID: 565
		public ushort Size;

		// Token: 0x04000236 RID: 566
		[FixedBuffer(typeof(ushort), 3)]
		public FUFunctionParamsLayout3.<Offset>e__FixedBuffer Offset;

		// Token: 0x02002B2B RID: 11051
		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(LayoutKind.Sequential, Size = 6)]
		public struct <Offset>e__FixedBuffer
		{
			// Token: 0x04016383 RID: 91011
			public ushort FixedElementField;
		}
	}
}
