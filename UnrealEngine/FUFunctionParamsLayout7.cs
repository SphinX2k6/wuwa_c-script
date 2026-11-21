using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x02000095 RID: 149
	public struct FUFunctionParamsLayout7 : IUFunctionParamsLayout
	{
		// Token: 0x040001F6 RID: 502
		public ushort Size;

		// Token: 0x040001F7 RID: 503
		[FixedBuffer(typeof(ushort), 7)]
		public FUFunctionParamsLayout7.<Offset>e__FixedBuffer Offset;

		// Token: 0x020008DD RID: 2269
		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(LayoutKind.Sequential, Size = 14)]
		public struct <Offset>e__FixedBuffer
		{
			// Token: 0x0400579D RID: 22429
			public ushort FixedElementField;
		}
	}
}
