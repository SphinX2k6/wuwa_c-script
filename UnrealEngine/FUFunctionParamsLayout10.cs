using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x02000098 RID: 152
	public struct FUFunctionParamsLayout10 : IUFunctionParamsLayout
	{
		// Token: 0x040001FC RID: 508
		public ushort Size;

		// Token: 0x040001FD RID: 509
		[FixedBuffer(typeof(ushort), 10)]
		public FUFunctionParamsLayout10.<Offset>e__FixedBuffer Offset;

		// Token: 0x020008E0 RID: 2272
		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(LayoutKind.Sequential, Size = 20)]
		public struct <Offset>e__FixedBuffer
		{
			// Token: 0x040057A0 RID: 22432
			public ushort FixedElementField;
		}
	}
}
