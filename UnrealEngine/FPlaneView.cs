using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x02000036 RID: 54
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Pack = 16, Size = 16)]
	public ref struct FPlaneView
	{
		// Token: 0x040000D8 RID: 216
		[FieldOffset(0)]
		public FVector V;
	}
}
