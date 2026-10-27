using System;
using System.Runtime.CompilerServices;
using System.Security;
using UnrealEngine.Utils;

namespace UnrealEngine.Extension
{
	// Token: 0x02002ADD RID: 10973
	public static class FunctionExtension
	{
		// Token: 0x060283DA RID: 164826 RVA: 0x003D3458 File Offset: 0x003D1658
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static TWeakObjectPtr<UFunction> ToWeakFunction(UFunctionStackOnlyPtr Ptr)
		{
			return new TWeakObjectPtr<UFunction>(BuiltinUtils.GetOrCreateUObjectByNativePointer<UFunction>(Ptr.FunctionPtr));
		}

		// Token: 0x060283DB RID: 164827 RVA: 0x003D346B File Offset: 0x003D166B
		[NullableContext(1)]
		[SecurityCritical]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static UFunction ToFunction(UFunctionStackOnlyPtr Ptr)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UFunction>(Ptr.FunctionPtr);
		}
	}
}
