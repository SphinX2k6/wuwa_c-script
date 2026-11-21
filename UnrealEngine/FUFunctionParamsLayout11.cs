using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x02000099 RID: 153
	public struct FUFunctionParamsLayout11 : IUFunctionParamsLayout
	{
		// Token: 0x040001FE RID: 510
		public ushort Size;

		// Token: 0x040001FF RID: 511
		[FixedBuffer(typeof(ushort), 11)]
		public FUFunctionParamsLayout11.<Offset>e__FixedBuffer Offset;

		// Token: 0x020008E1 RID: 2273
		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(LayoutKind.Sequential, Size = 22)]
		public struct <Offset>e__FixedBuffer
		{
			// Token: 0x040057A1 RID: 22433
			public ushort FixedElementField;
		}
	}
}
