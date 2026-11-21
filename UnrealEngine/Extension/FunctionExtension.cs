using System;
using System.Runtime.CompilerServices;
using System.Security;
using UnrealEngine.Utils;

namespace UnrealEngine.Extension
{
	// Token: 0x0200088C RID: 2188
	public static class FunctionExtension
	{
		// Token: 0x0600BD8D RID: 48525 RVA: 0x0012E748 File Offset: 0x0012C948
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

		// Token: 0x0600BD8E RID: 48526 RVA: 0x0012E75B File Offset: 0x0012C95B
		[NullableContext(1)]
		[SecurityCritical]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static UFunction ToFunction(UFunctionStackOnlyPtr Ptr)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UFunction>(Ptr.FunctionPtr);
		}
	}
}
