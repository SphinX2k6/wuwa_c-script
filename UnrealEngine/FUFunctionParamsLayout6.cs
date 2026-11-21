using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x02000094 RID: 148
	public struct FUFunctionParamsLayout6 : IUFunctionParamsLayout
	{
		// Token: 0x040001F4 RID: 500
		public ushort Size;

		// Token: 0x040001F5 RID: 501
		[FixedBuffer(typeof(ushort), 6)]
		public FUFunctionParamsLayout6.<Offset>e__FixedBuffer Offset;

		// Token: 0x020008DC RID: 2268
		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(LayoutKind.Sequential, Size = 12)]
		public struct <Offset>e__FixedBuffer
		{
			// Token: 0x0400579C RID: 22428
			public ushort FixedElementField;
		}
	}
}
