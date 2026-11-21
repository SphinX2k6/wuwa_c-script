using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000758 RID: 1880
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MobilePatchingUtils.MobilePatchingLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UMobilePatchingLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A40D RID: 41997 RVA: 0x000F2333 File Offset: 0x000F0533
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMobilePatchingLibrary._ClassPtr;
		}

		// Token: 0x0600A40E RID: 41998 RVA: 0x000F2340 File Offset: 0x000F0540
		public UMobilePatchingLibrary() : this(BuiltinUtils.AllocNativeUObject(UMobilePatchingLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A40F RID: 41999 RVA: 0x000F2368 File Offset: 0x000F0568
		public UMobilePatchingLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMobilePatchingLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600A410 RID: 42000 RVA: 0x000F239C File Offset: 0x000F059C
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

		// Token: 0x0600A411 RID: 42001
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasActiveWiFiConnection();

		// Token: 0x0600A412 RID: 42002 RVA: 0x000F2400 File Offset: 0x000F0600
		public static TArray<string> GetSupportedPlatformNames()
		{
			return new TArray<string>(UMobilePatchingLibrary.__GetSupportedPlatformNames_Internal(), null);
		}

		// Token: 0x0600A413 RID: 42003 RVA: 0x000F2410 File Offset: 0x000F0610
		[return: Nullable(2)]
		public unsafe static UMobileInstalledContent GetInstalledContent(string InstallDirectory)
		{
			FString fstring = FString.AllocTemp(InstallDirectory);
			UMobileInstalledContent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMobileInstalledContent>(UMobilePatchingLibrary.__GetInstalledContent_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x0600A414 RID: 42004 RVA: 0x000F2439 File Offset: 0x000F0639
		public static string GetActiveDeviceProfileName()
		{
			return FString.ToStringAndDeleteNativePtr(UMobilePatchingLibrary.__GetActiveDeviceProfileName_Internal());
		}

		// Token: 0x0600A415 RID: 42005
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RequestContent_Internal(in FString RemoteManifestURL, in FString CloudURL, in FString InstallDirectory, IntPtr OnSucceeded, IntPtr OnFailed);

		// Token: 0x0600A416 RID: 42006
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSupportedPlatformNames_Internal();

		// Token: 0x0600A417 RID: 42007
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetInstalledContent_Internal(in FString InstallDirectory);

		// Token: 0x0600A418 RID: 42008
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetActiveDeviceProfileName_Internal();

		// Token: 0x0600A419 RID: 42009 RVA: 0x000F2445 File Offset: 0x000F0645
		static UMobilePatchingLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MobilePatchingUtils.MobilePatchingLibrary");
		}

		// Token: 0x0600A41A RID: 42010 RVA: 0x000F2453 File Offset: 0x000F0653
		protected UMobilePatchingLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040045F9 RID: 17913
		public new const string __ObjectPath = "/Script/MobilePatchingUtils.MobilePatchingLibrary";

		// Token: 0x040045FA RID: 17914
		private static IntPtr _ClassPtr;

		// Token: 0x040045FB RID: 17915
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
