using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x0200009B RID: 155
	public struct FUFunctionParamsLayout13 : IUFunctionParamsLayout
	{
		// Token: 0x04000202 RID: 514
		public ushort Size;

		// Token: 0x04000203 RID: 515
		[FixedBuffer(typeof(ushort), 13)]
		public FUFunctionParamsLayout13.<Offset>e__FixedBuffer Offset;

		// Token: 0x020008E3 RID: 2275
		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(LayoutKind.Sequential, Size = 26)]
		public struct <Offset>e__FixedBuffer
		{
			// Token: 0x040057A3 RID: 22435
			public ushort FixedElementField;
		}
	}
}
