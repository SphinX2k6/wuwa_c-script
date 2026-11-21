using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x02000093 RID: 147
	public struct FUFunctionParamsLayout5 : IUFunctionParamsLayout
	{
		// Token: 0x040001F2 RID: 498
		public ushort Size;

		// Token: 0x040001F3 RID: 499
		[FixedBuffer(typeof(ushort), 5)]
		public FUFunctionParamsLayout5.<Offset>e__FixedBuffer Offset;

		// Token: 0x020008DB RID: 2267
		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(LayoutKind.Sequential, Size = 10)]
		public struct <Offset>e__FixedBuffer
		{
			// Token: 0x0400579B RID: 22427
			public ushort FixedElementField;
		}
	}
}
