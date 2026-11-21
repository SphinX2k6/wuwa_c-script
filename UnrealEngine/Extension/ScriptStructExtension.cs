using System;
using System.Runtime.CompilerServices;
using System.Security;
using UnrealEngine.Utils;

namespace UnrealEngine.Extension
{
	// Token: 0x0200088B RID: 2187
	public static class ScriptStructExtension
	{
		// Token: 0x0600BD8B RID: 48523 RVA: 0x0012E729 File Offset: 0x0012C929
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static TWeakObjectPtr<UScriptStruct> ToWeakScriptStruct(UScriptStructStackOnlyPtr Ptr)
		{
			return new TWeakObjectPtr<UScriptStruct>(BuiltinUtils.GetOrCreateUObjectByNativePointer<UScriptStruct>(Ptr.ScriptStructPtr));
		}

		// Token: 0x0600BD8C RID: 48524 RVA: 0x0012E73B File Offset: 0x0012C93B
		[NullableContext(1)]
		[SecurityCritical]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static UScriptStruct ToScriptStruct(UScriptStructStackOnlyPtr Ptr)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UScriptStruct>(Ptr.ScriptStructPtr);
		}
	}
}
