using System;

namespace UnrealEngine
{
	// Token: 0x0200004B RID: 75
	public struct FScriptArray_NativeStruct
	{
		// Token: 0x060008B8 RID: 2232 RVA: 0x0001080D File Offset: 0x0000EA0D
		public FScriptArray_NativeStruct()
		{
			this.Data = IntPtr.Zero;
			this.ArrayNum = 0;
			this.ArrayMax = 0;
		}

		// Token: 0x04000158 RID: 344
		public IntPtr Data;

		// Token: 0x04000159 RID: 345
		public int ArrayNum;

		// Token: 0x0400015A RID: 346
		public int ArrayMax;
	}
}
