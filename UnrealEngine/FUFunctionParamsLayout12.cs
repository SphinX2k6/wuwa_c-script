using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x0200009A RID: 154
	public struct FUFunctionParamsLayout12 : IUFunctionParamsLayout
	{
		// Token: 0x04000200 RID: 512
		public ushort Size;

		// Token: 0x04000201 RID: 513
		[FixedBuffer(typeof(ushort), 12)]
		public FUFunctionParamsLayout12.<Offset>e__FixedBuffer Offset;

		// Token: 0x020008E2 RID: 2274
		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(LayoutKind.Sequential, Size = 24)]
		public struct <Offset>e__FixedBuffer
		{
			// Token: 0x040057A2 RID: 22434
			public ushort FixedElementField;
		}
	}
}
