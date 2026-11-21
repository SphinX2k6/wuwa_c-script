using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x02000097 RID: 151
	public struct FUFunctionParamsLayout9 : IUFunctionParamsLayout
	{
		// Token: 0x040001FA RID: 506
		public ushort Size;

		// Token: 0x040001FB RID: 507
		[FixedBuffer(typeof(ushort), 9)]
		public FUFunctionParamsLayout9.<Offset>e__FixedBuffer Offset;

		// Token: 0x020008DF RID: 2271
		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(LayoutKind.Sequential, Size = 18)]
		public struct <Offset>e__FixedBuffer
		{
			// Token: 0x0400579F RID: 22431
			public ushort FixedElementField;
		}
	}
}
