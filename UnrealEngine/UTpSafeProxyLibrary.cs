using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F0C RID: 7948
	[UnrealObjectPath("/Script/KuroUtility.TpSafeProxyLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UTpSafeProxyLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E293 RID: 123539 RVA: 0x002CD8AA File Offset: 0x002CBAAA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTpSafeProxyLibrary._ClassPtr;
		}

		// Token: 0x0601E294 RID: 123540 RVA: 0x002CD8B8 File Offset: 0x002CBAB8
		public UTpSafeProxyLibrary() : this(BuiltinUtils.AllocNativeUObject(UTpSafeProxyLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E295 RID: 123541 RVA: 0x002CD8E0 File Offset: 0x002CBAE0
		[NullableContext(1)]
		public UTpSafeProxyLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTpSafeProxyLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601E296 RID: 123542 RVA: 0x002CD914 File Offset: 0x002CBB14
		[NullableContext(1)]
		public unsafe static void SetUserInfo(int AccountType, int WorldId, string OpenId, int PlayerId)
		{
			FString fstring = FString.AllocTemp(OpenId);
			UTpSafeProxyLibrary.__SetUserInfo_Internal(AccountType, WorldId, fstring, PlayerId);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601E297 RID: 123543
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RecvAntiData(in FArrayBuffer Data);

		// Token: 0x0601E298 RID: 123544
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Logout();

		// Token: 0x0601E299 RID: 123545
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FArrayBuffer GetAntiData2();

		// Token: 0x0601E29A RID: 123546
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FArrayBuffer GetAntiData();

		// Token: 0x0601E29B RID: 123547
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUserInfo_Internal(int AccountType, int WorldId, in FString OpenId, int PlayerId);

		// Token: 0x0601E29C RID: 123548 RVA: 0x002CD93B File Offset: 0x002CBB3B
		static UTpSafeProxyLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.TpSafeProxyLibrary");
		}

		// Token: 0x0601E29D RID: 123549 RVA: 0x002CD949 File Offset: 0x002CBB49
		protected UTpSafeProxyLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010492 RID: 66706
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.TpSafeProxyLibrary";

		// Token: 0x04010493 RID: 66707
		private static IntPtr _ClassPtr;

		// Token: 0x04010494 RID: 66708
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
