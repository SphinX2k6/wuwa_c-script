using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x020000AD RID: 173
	public struct FUFunctionParamsLayout4 : IUFunctionParamsLayout
	{
		// Token: 0x04000237 RID: 567
		public ushort Size;

		// Token: 0x04000238 RID: 568
		[FixedBuffer(typeof(ushort), 4)]
		public FUFunctionParamsLayout4.<Offset>e__FixedBuffer Offset;

		// Token: 0x02002B2C RID: 11052
		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(LayoutKind.Sequential, Size = 8)]
		public struct <Offset>e__FixedBuffer
		{
			// Token: 0x04016384 RID: 91012
			public ushort FixedElementField;
		}
	}
}
