using System;

namespace UnrealEngine
{
	// Token: 0x0200008B RID: 139
	public readonly struct UScriptStructStackOnlyPtr
	{
		// Token: 0x06000C5D RID: 3165 RVA: 0x00014082 File Offset: 0x00012282
		public UScriptStructStackOnlyPtr(IntPtr nativePtr)
		{
			this.ScriptStructPtr = new IntPtr((long)nativePtr);
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x00014091 File Offset: 0x00012291
		public bool IsValid()
		{
			return this.ScriptStructPtr != IntPtr.Zero;
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x000140A3 File Offset: 0x000122A3
		public static implicit operator UScriptStructStackOnlyPtr(IntPtr ptr)
		{
			return new UScriptStructStackOnlyPtr(ptr);
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x000140AB File Offset: 0x000122AB
		public static implicit operator IntPtr(UScriptStructStackOnlyPtr ptr)
		{
			return ptr.ScriptStructPtr;
		}

		// Token: 0x040001E8 RID: 488
		public readonly IntPtr ScriptStructPtr;
	}
}
