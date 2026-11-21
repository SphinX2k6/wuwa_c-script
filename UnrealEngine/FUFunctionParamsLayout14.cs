using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x0200009C RID: 156
	public struct FUFunctionParamsLayout14 : IUFunctionParamsLayout
	{
		// Token: 0x04000204 RID: 516
		public ushort Size;

		// Token: 0x04000205 RID: 517
		[FixedBuffer(typeof(ushort), 14)]
		public FUFunctionParamsLayout14.<Offset>e__FixedBuffer Offset;

		// Token: 0x020008E4 RID: 2276
		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(LayoutKind.Sequential, Size = 28)]
		public struct <Offset>e__FixedBuffer
		{
			// Token: 0x040057A4 RID: 22436
			public ushort FixedElementField;
		}
	}
}
