using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020022F7 RID: 8951
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MobilePatchingUtils.MobilePatchingLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UMobilePatchingLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021ED9 RID: 138969 RVA: 0x00322C13 File Offset: 0x00320E13
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMobilePatchingLibrary._ClassPtr;
		}

		// Token: 0x06021EDA RID: 138970 RVA: 0x00322C20 File Offset: 0x00320E20
		public UMobilePatchingLibrary() : this(BuiltinUtils.AllocNativeUObject(UMobilePatchingLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021EDB RID: 138971 RVA: 0x00322C48 File Offset: 0x00320E48
		public UMobilePatchingLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMobilePatchingLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021EDC RID: 138972 RVA: 0x00322C7C File Offset: 0x00320E7C
		public unsafe static void RequestContent(string RemoteManifestURL, string CloudURL, string InstallDirectory, [Nullable(2)] FOnRequestContentSucceeded OnSucceeded, [Nullable(2)] FOnRequestContentFailed OnFailed)
		{
			FString fstring = FString.AllocTemp(RemoteManifestURL);
			FString fstring2 = FString.AllocTemp(CloudURL);
			FString fstring3 = FString.AllocTemp(InstallDirectory);
			UMobilePatchingLibrary.__RequestContent_Internal(fstring, fstring2, fstring3, (OnSucceeded != null) ? OnSucceeded.NativePtr : ((IntPtr)0), (OnFailed != null) ? OnFailed.NativePtr : ((IntPtr)0));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			FString.NativeDestruct(&fstring3, 1);
		}

		// Token: 0x06021EDD RID: 138973
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasActiveWiFiConnection();

		// Token: 0x06021EDE RID: 138974 RVA: 0x00322CE0 File Offset: 0x00320EE0
		public static TArray<string> GetSupportedPlatformNames()
		{
			return new TArray<string>(UMobilePatchingLibrary.__GetSupportedPlatformNames_Internal(), null);
		}

		// Token: 0x06021EDF RID: 138975 RVA: 0x00322CF0 File Offset: 0x00320EF0
		[return: Nullable(2)]
		public unsafe static UMobileInstalledContent GetInstalledContent(string InstallDirectory)
		{
			FString fstring = FString.AllocTemp(InstallDirectory);
			UMobileInstalledContent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMobileInstalledContent>(UMobilePatchingLibrary.__GetInstalledContent_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x06021EE0 RID: 138976 RVA: 0x00322D19 File Offset: 0x00320F19
		public static string GetActiveDeviceProfileName()
		{
			return FString.ToStringAndDeleteNativePtr(UMobilePatchingLibrary.__GetActiveDeviceProfileName_Internal());
		}

		// Token: 0x06021EE1 RID: 138977
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RequestContent_Internal(in FString RemoteManifestURL, in FString CloudURL, in FString InstallDirectory, IntPtr OnSucceeded, IntPtr OnFailed);

		// Token: 0x06021EE2 RID: 138978
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSupportedPlatformNames_Internal();

		// Token: 0x06021EE3 RID: 138979
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetInstalledContent_Internal(in FString InstallDirectory);

		// Token: 0x06021EE4 RID: 138980
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetActiveDeviceProfileName_Internal();

		// Token: 0x06021EE5 RID: 138981 RVA: 0x00322D25 File Offset: 0x00320F25
		static UMobilePatchingLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MobilePatchingUtils.MobilePatchingLibrary");
		}

		// Token: 0x06021EE6 RID: 138982 RVA: 0x00322D33 File Offset: 0x00320F33
		protected UMobilePatchingLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401219E RID: 74142
		public new const string __ObjectPath = "/Script/MobilePatchingUtils.MobilePatchingLibrary";

		// Token: 0x0401219F RID: 74143
		private static IntPtr _ClassPtr;

		// Token: 0x040121A0 RID: 74144
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
