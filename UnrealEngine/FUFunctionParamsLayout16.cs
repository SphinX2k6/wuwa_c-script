using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x0200009E RID: 158
	public struct FUFunctionParamsLayout16 : IUFunctionParamsLayout
	{
		// Token: 0x04000208 RID: 520
		public ushort Size;

		// Token: 0x04000209 RID: 521
		[FixedBuffer(typeof(ushort), 16)]
		public FUFunctionParamsLayout16.<Offset>e__FixedBuffer Offset;

		// Token: 0x020008E6 RID: 2278
		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(LayoutKind.Sequential, Size = 32)]
		public struct <Offset>e__FixedBuffer
		{
			// Token: 0x040057A6 RID: 22438
			public ushort FixedElementField;
		}
	}
}
