using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019AC RID: 6572
	[UnrealObjectPath("/Script/KuroiOSDelegate.KuroiOSDelegateStaticLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroiOSDelegateStaticLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018747 RID: 100167 RVA: 0x002409BC File Offset: 0x0023EBBC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroiOSDelegateStaticLibrary._ClassPtr;
		}

		// Token: 0x06018748 RID: 100168 RVA: 0x002409C8 File Offset: 0x0023EBC8
		public UKuroiOSDelegateStaticLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroiOSDelegateStaticLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018749 RID: 100169 RVA: 0x002409F0 File Offset: 0x0023EBF0
		[NullableContext(1)]
		public UKuroiOSDelegateStaticLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroiOSDelegateStaticLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601874A RID: 100170 RVA: 0x00240A23 File Offset: 0x0023EC23
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void DispatchCacheMessage()
		{
			UnrealReflectionUtils.CallUFunction(UKuroiOSDelegateStaticLibrary._ClassDefaultObjectPtr, UKuroiOSDelegateStaticLibrary.__DispatchCacheMessage_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601874B RID: 100171 RVA: 0x00240A37 File Offset: 0x0023EC37
		static UKuroiOSDelegateStaticLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroiOSDelegate.KuroiOSDelegateStaticLibrary");
		}

		// Token: 0x0601874C RID: 100172 RVA: 0x00240A45 File Offset: 0x0023EC45
		protected UKuroiOSDelegateStaticLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D360 RID: 54112
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroiOSDelegate.KuroiOSDelegateStaticLibrary";

		// Token: 0x0400D361 RID: 54113
		private static IntPtr _ClassPtr;

		// Token: 0x0400D362 RID: 54114
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D363 RID: 54115
		private static IntPtr __DispatchCacheMessage_NativeFunctionPtr;
	}
}
