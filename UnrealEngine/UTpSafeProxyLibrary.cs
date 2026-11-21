using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000617 RID: 1559
	[UnrealObjectPath("/Script/KuroUtility.TpSafeProxyLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UTpSafeProxyLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060088BC RID: 35004 RVA: 0x000CE5D2 File Offset: 0x000CC7D2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTpSafeProxyLibrary._ClassPtr;
		}

		// Token: 0x060088BD RID: 35005 RVA: 0x000CE5E0 File Offset: 0x000CC7E0
		public UTpSafeProxyLibrary() : this(BuiltinUtils.AllocNativeUObject(UTpSafeProxyLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060088BE RID: 35006 RVA: 0x000CE608 File Offset: 0x000CC808
		[NullableContext(1)]
		public UTpSafeProxyLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTpSafeProxyLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060088BF RID: 35007 RVA: 0x000CE63C File Offset: 0x000CC83C
		[NullableContext(1)]
		public unsafe static void SetUserInfo(int AccountType, int WorldId, string OpenId, int PlayerId)
		{
			FString fstring = FString.AllocTemp(OpenId);
			UTpSafeProxyLibrary.__SetUserInfo_Internal(AccountType, WorldId, fstring, PlayerId);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060088C0 RID: 35008
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RecvAntiData(in FArrayBuffer Data);

		// Token: 0x060088C1 RID: 35009
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Logout();

		// Token: 0x060088C2 RID: 35010
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FArrayBuffer GetAntiData2();

		// Token: 0x060088C3 RID: 35011
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FArrayBuffer GetAntiData();

		// Token: 0x060088C4 RID: 35012
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUserInfo_Internal(int AccountType, int WorldId, in FString OpenId, int PlayerId);

		// Token: 0x060088C5 RID: 35013 RVA: 0x000CE663 File Offset: 0x000CC863
		static UTpSafeProxyLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.TpSafeProxyLibrary");
		}

		// Token: 0x060088C6 RID: 35014 RVA: 0x000CE671 File Offset: 0x000CC871
		protected UTpSafeProxyLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003B5D RID: 15197
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.TpSafeProxyLibrary";

		// Token: 0x04003B5E RID: 15198
		private static IntPtr _ClassPtr;

		// Token: 0x04003B5F RID: 15199
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
