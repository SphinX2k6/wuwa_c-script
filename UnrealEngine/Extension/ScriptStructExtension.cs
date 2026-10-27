using System;
using System.Runtime.CompilerServices;
using System.Security;
using UnrealEngine.Utils;

namespace UnrealEngine.Extension
{
	// Token: 0x02002ADC RID: 10972
	public static class ScriptStructExtension
	{
		// Token: 0x060283D8 RID: 164824 RVA: 0x003D3439 File Offset: 0x003D1639
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

		// Token: 0x060283D9 RID: 164825 RVA: 0x003D344B File Offset: 0x003D164B
		[NullableContext(1)]
		[SecurityCritical]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static UScriptStruct ToScriptStruct(UScriptStructStackOnlyPtr Ptr)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UScriptStruct>(Ptr.ScriptStructPtr);
		}
	}
}
