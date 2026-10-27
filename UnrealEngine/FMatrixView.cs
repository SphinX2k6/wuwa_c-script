using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x0200002F RID: 47
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Pack = 16, Size = 64)]
	public ref struct FMatrixView
	{
		// Token: 0x040000BE RID: 190
		[FixedBuffer(typeof(float), 16)]
		[FieldOffset(0)]
		public FMatrixView.<Arr>e__FixedBuffer Arr;

		// Token: 0x040000BF RID: 191
		[FieldOffset(0)]
		public FVector V0;

		// Token: 0x040000C0 RID: 192
		[FieldOffset(0)]
		public FVector4 Row0;

		// Token: 0x040000C1 RID: 193
		[FieldOffset(16)]
		public FVector V1;

		// Token: 0x040000C2 RID: 194
		[FieldOffset(16)]
		public FVector4 Row1;

		// Token: 0x040000C3 RID: 195
		[FieldOffset(32)]
		public FVector V2;

		// Token: 0x040000C4 RID: 196
		[FieldOffset(32)]
		public FVector4 Row2;

		// Token: 0x040000C5 RID: 197
		[FieldOffset(48)]
		public FVector V3;

		// Token: 0x040000C6 RID: 198
		[FieldOffset(48)]
		public FVector4 Row3;

		// Token: 0x02002B1E RID: 11038
		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(LayoutKind.Sequential, Size = 64)]
		public struct <Arr>e__FixedBuffer
		{
			// Token: 0x04016366 RID: 90982
			public float FixedElementField;
		}
	}
}
