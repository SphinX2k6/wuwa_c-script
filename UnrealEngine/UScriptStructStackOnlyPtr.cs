using System;

namespace UnrealEngine
{
	// Token: 0x020000A6 RID: 166
	public readonly struct UScriptStructStackOnlyPtr
	{
		// Token: 0x060010CA RID: 4298 RVA: 0x0001935E File Offset: 0x0001755E
		public UScriptStructStackOnlyPtr(IntPtr nativePtr)
		{
			this.ScriptStructPtr = new IntPtr((long)nativePtr);
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x0001936D File Offset: 0x0001756D
		public bool IsValid()
		{
			return this.ScriptStructPtr != IntPtr.Zero;
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x0001937F File Offset: 0x0001757F
		public static implicit operator UScriptStructStackOnlyPtr(IntPtr ptr)
		{
			return new UScriptStructStackOnlyPtr(ptr);
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x00019387 File Offset: 0x00017587
		public static implicit operator IntPtr(UScriptStructStackOnlyPtr ptr)
		{
			return ptr.ScriptStructPtr;
		}

		// Token: 0x0400022F RID: 559
		public readonly IntPtr ScriptStructPtr;
	}
}
