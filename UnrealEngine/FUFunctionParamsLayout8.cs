using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x02000096 RID: 150
	public struct FUFunctionParamsLayout8 : IUFunctionParamsLayout
	{
		// Token: 0x040001F8 RID: 504
		public ushort Size;

		// Token: 0x040001F9 RID: 505
		[FixedBuffer(typeof(ushort), 8)]
		public FUFunctionParamsLayout8.<Offset>e__FixedBuffer Offset;

		// Token: 0x020008DE RID: 2270
		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(LayoutKind.Sequential, Size = 16)]
		public struct <Offset>e__FixedBuffer
		{
			// Token: 0x0400579E RID: 22430
			public ushort FixedElementField;
		}
	}
}
