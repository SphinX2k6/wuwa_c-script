using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x0200008F RID: 143
	public struct FUFunctionParamsLayout1 : IUFunctionParamsLayout
	{
		// Token: 0x040001EA RID: 490
		public ushort Size;

		// Token: 0x040001EB RID: 491
		[FixedBuffer(typeof(ushort), 1)]
		public FUFunctionParamsLayout1.<Offset>e__FixedBuffer Offset;

		// Token: 0x020008D7 RID: 2263
		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(LayoutKind.Sequential, Size = 2)]
		public struct <Offset>e__FixedBuffer
		{
			// Token: 0x04005797 RID: 22423
			public ushort FixedElementField;
		}
	}
}
