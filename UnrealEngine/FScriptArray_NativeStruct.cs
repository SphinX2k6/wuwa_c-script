using System;

namespace UnrealEngine
{
	// Token: 0x02000030 RID: 48
	public struct FScriptArray_NativeStruct
	{
		// Token: 0x0600083D RID: 2109 RVA: 0x0000D079 File Offset: 0x0000B279
		public FScriptArray_NativeStruct()
		{
			this.Data = IntPtr.Zero;
			this.ArrayNum = 0;
			this.ArrayMax = 0;
		}

		// Token: 0x04000111 RID: 273
		public IntPtr Data;

		// Token: 0x04000112 RID: 274
		public int ArrayNum;

		// Token: 0x04000113 RID: 275
		public int ArrayMax;
	}
}
