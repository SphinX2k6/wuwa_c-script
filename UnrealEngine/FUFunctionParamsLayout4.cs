using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x02000092 RID: 146
	public struct FUFunctionParamsLayout4 : IUFunctionParamsLayout
	{
		// Token: 0x040001F0 RID: 496
		public ushort Size;

		// Token: 0x040001F1 RID: 497
		[FixedBuffer(typeof(ushort), 4)]
		public FUFunctionParamsLayout4.<Offset>e__FixedBuffer Offset;

		// Token: 0x020008DA RID: 2266
		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(LayoutKind.Sequential, Size = 8)]
		public struct <Offset>e__FixedBuffer
		{
			// Token: 0x0400579A RID: 22426
			public ushort FixedElementField;
		}
	}
}
