using System;
using System.Runtime.CompilerServices;
using System.Security;
using UnrealEngine.Utils;

namespace UnrealEngine.Extension
{
	// Token: 0x02002ADB RID: 10971
	[NullableContext(1)]
	[Nullable(0)]
	public static class ClassExtension
	{
		// Token: 0x060283D5 RID: 164821 RVA: 0x003D3416 File Offset: 0x003D1616
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

		// Token: 0x060283D6 RID: 164822 RVA: 0x003D341E File Offset: 0x003D161E
		[SecurityCritical]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static UClass ToClass(this UClassStackOnlyPtr Ptr)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UClass>(Ptr.NativePtr);
		}

		// Token: 0x060283D7 RID: 164823 RVA: 0x003D342C File Offset: 0x003D162C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static UClassStackOnlyPtr ToClassStackOnlyPtr(this UClass UClass)
		{
			return new UClassStackOnlyPtr(UClass._NativePtr);
		}
	}
}
