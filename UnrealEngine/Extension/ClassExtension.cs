using System;
using System.Runtime.CompilerServices;
using System.Security;
using UnrealEngine.Utils;

namespace UnrealEngine.Extension
{
	// Token: 0x0200088A RID: 2186
	[NullableContext(1)]
	[Nullable(0)]
	public static class ClassExtension
	{
		// Token: 0x0600BD88 RID: 48520 RVA: 0x0012E706 File Offset: 0x0012C906
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static TWeakObjectPtr<UClass> ToWeakClass(this UClassStackOnlyPtr Ptr)
		{
			return new TWeakObjectPtr<UClass>(Ptr);
		}

		// Token: 0x0600BD89 RID: 48521 RVA: 0x0012E70E File Offset: 0x0012C90E
		[SecurityCritical]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static UClass ToClass(this UClassStackOnlyPtr Ptr)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UClass>(Ptr.NativePtr);
		}

		// Token: 0x0600BD8A RID: 48522 RVA: 0x0012E71C File Offset: 0x0012C91C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static UClassStackOnlyPtr ToClassStackOnlyPtr(this UClass UClass)
		{
			return new UClassStackOnlyPtr(UClass._NativePtr);
		}
	}
}
