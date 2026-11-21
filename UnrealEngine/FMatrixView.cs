using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x02000014 RID: 20
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Pack = 16, Size = 64)]
	public ref struct FMatrixView
	{
		// Token: 0x04000077 RID: 119
		[FixedBuffer(typeof(float), 16)]
		[FieldOffset(0)]
		public FMatrixView.<Arr>e__FixedBuffer Arr;

		// Token: 0x04000078 RID: 120
		[FieldOffset(0)]
		public FVector V0;

		// Token: 0x04000079 RID: 121
		[FieldOffset(0)]
		public FVector4 Row0;

		// Token: 0x0400007A RID: 122
		[FieldOffset(16)]
		public FVector V1;

		// Token: 0x0400007B RID: 123
		[FieldOffset(16)]
		public FVector4 Row1;

		// Token: 0x0400007C RID: 124
		[FieldOffset(32)]
		public FVector V2;

		// Token: 0x0400007D RID: 125
		[FieldOffset(32)]
		public FVector4 Row2;

		// Token: 0x0400007E RID: 126
		[FieldOffset(48)]
		public FVector V3;

		// Token: 0x0400007F RID: 127
		[FieldOffset(48)]
		public FVector4 Row3;

		// Token: 0x020008CC RID: 2252
		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(LayoutKind.Sequential, Size = 64)]
		public struct <Arr>e__FixedBuffer
		{
			// Token: 0x0400577C RID: 22396
			public float FixedElementField;
		}
	}
}
