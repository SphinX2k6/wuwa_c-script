using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x02000090 RID: 144
	public struct FUFunctionParamsLayout2 : IUFunctionParamsLayout
	{
		// Token: 0x040001EC RID: 492
		public ushort Size;

		// Token: 0x040001ED RID: 493
		[FixedBuffer(typeof(ushort), 2)]
		public FUFunctionParamsLayout2.<Offset>e__FixedBuffer Offset;

		// Token: 0x020008D8 RID: 2264
		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(LayoutKind.Sequential, Size = 4)]
		public struct <Offset>e__FixedBuffer
		{
			// Token: 0x04005798 RID: 22424
			public ushort FixedElementField;
		}
	}
}
