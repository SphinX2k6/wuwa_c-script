using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002A9 RID: 681
	[UnrealObjectPath("/Script/AndroidPermission.AndroidPermissionFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UAndroidPermissionFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002592 RID: 9618 RVA: 0x00038CCB File Offset: 0x00036ECB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAndroidPermissionFunctionLibrary._ClassPtr;
		}

		// Token: 0x06002593 RID: 9619 RVA: 0x00038CD8 File Offset: 0x00036ED8
		public UAndroidPermissionFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UAndroidPermissionFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002594 RID: 9620 RVA: 0x00038D00 File Offset: 0x00036F00
		[NullableContext(1)]
		public UAndroidPermissionFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAndroidPermissionFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06002595 RID: 9621 RVA: 0x00038D34 File Offset: 0x00036F34
		[NullableContext(1)]
		public unsafe static bool CheckPermission(string permission)
		{
			FString fstring = FString.AllocTemp(permission);
			bool result = UAndroidPermissionFunctionLibrary.__CheckPermission_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002596 RID: 9622 RVA: 0x00038D58 File Offset: 0x00036F58
		[NullableContext(2)]
		public static UAndroidPermissionCallbackProxy AcquirePermissions([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> permissions)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAndroidPermissionCallbackProxy>(UAndroidPermissionFunctionLibrary.__AcquirePermissions_Internal((permissions ?? new TArray<string>()).NativePtr));
		}

		// Token: 0x06002597 RID: 9623
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CheckPermission_Internal(in FString permission);

		// Token: 0x06002598 RID: 9624
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AcquirePermissions_Internal(IntPtr permissions);

		// Token: 0x06002599 RID: 9625 RVA: 0x00038D74 File Offset: 0x00036F74
		static UAndroidPermissionFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AndroidPermission.AndroidPermissionFunctionLibrary");
		}

		// Token: 0x0600259A RID: 9626 RVA: 0x00038D82 File Offset: 0x00036F82
		protected UAndroidPermissionFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000E75 RID: 3701
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AndroidPermission.AndroidPermissionFunctionLibrary";

		// Token: 0x04000E76 RID: 3702
		private static IntPtr _ClassPtr;

		// Token: 0x04000E77 RID: 3703
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
