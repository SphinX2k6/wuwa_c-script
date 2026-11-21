using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x0200009D RID: 157
	public struct FUFunctionParamsLayout15 : IUFunctionParamsLayout
	{
		// Token: 0x04000206 RID: 518
		public ushort Size;

		// Token: 0x04000207 RID: 519
		[FixedBuffer(typeof(ushort), 15)]
		public FUFunctionParamsLayout15.<Offset>e__FixedBuffer Offset;

		// Token: 0x020008E5 RID: 2277
		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(LayoutKind.Sequential, Size = 30)]
		public struct <Offset>e__FixedBuffer
		{
			// Token: 0x040057A5 RID: 22437
			public ushort FixedElementField;
		}
	}
}
