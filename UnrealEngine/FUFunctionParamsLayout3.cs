using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x02000091 RID: 145
	public struct FUFunctionParamsLayout3 : IUFunctionParamsLayout
	{
		// Token: 0x040001EE RID: 494
		public ushort Size;

		// Token: 0x040001EF RID: 495
		[FixedBuffer(typeof(ushort), 3)]
		public FUFunctionParamsLayout3.<Offset>e__FixedBuffer Offset;

		// Token: 0x020008D9 RID: 2265
		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(LayoutKind.Sequential, Size = 6)]
		public struct <Offset>e__FixedBuffer
		{
			// Token: 0x04005799 RID: 22425
			public ushort FixedElementField;
		}
	}
}
