using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000DC RID: 220
	[UnrealObjectPath("/Script/AndroidPermission.AndroidPermissionFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UAndroidPermissionFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06000F7A RID: 3962 RVA: 0x0001807B File Offset: 0x0001627B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAndroidPermissionFunctionLibrary._ClassPtr;
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x00018088 File Offset: 0x00016288
		public UAndroidPermissionFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UAndroidPermissionFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x000180B0 File Offset: 0x000162B0
		[NullableContext(1)]
		public UAndroidPermissionFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAndroidPermissionFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x000180E4 File Offset: 0x000162E4
		[NullableContext(1)]
		public unsafe static bool CheckPermission(string permission)
		{
			FString fstring = FString.AllocTemp(permission);
			bool result = UAndroidPermissionFunctionLibrary.__CheckPermission_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x00018108 File Offset: 0x00016308
		[NullableContext(2)]
		public static UAndroidPermissionCallbackProxy AcquirePermissions([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> permissions)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAndroidPermissionCallbackProxy>(UAndroidPermissionFunctionLibrary.__AcquirePermissions_Internal((permissions ?? new TArray<string>()).NativePtr));
		}

		// Token: 0x06000F7F RID: 3967
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CheckPermission_Internal(in FString permission);

		// Token: 0x06000F80 RID: 3968
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AcquirePermissions_Internal(IntPtr permissions);

		// Token: 0x06000F81 RID: 3969 RVA: 0x00018124 File Offset: 0x00016324
		static UAndroidPermissionFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AndroidPermission.AndroidPermissionFunctionLibrary");
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x00018132 File Offset: 0x00016332
		protected UAndroidPermissionFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000375 RID: 885
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AndroidPermission.AndroidPermissionFunctionLibrary";

		// Token: 0x04000376 RID: 886
		private static IntPtr _ClassPtr;

		// Token: 0x04000377 RID: 887
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
