using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x0200001B RID: 27
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Pack = 16, Size = 16)]
	public ref struct FPlaneView
	{
		// Token: 0x04000091 RID: 145
		[FieldOffset(0)]
		public FVector V;
	}
}
