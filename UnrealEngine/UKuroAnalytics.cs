using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015E5 RID: 5605
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KRDataAnalyticsPlugin.KuroAnalytics")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroAnalytics : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601434E RID: 82766 RVA: 0x001DAE30 File Offset: 0x001D9030
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAnalytics._ClassPtr;
		}

		// Token: 0x0601434F RID: 82767 RVA: 0x001DAE3C File Offset: 0x001D903C
		public UKuroAnalytics() : this(BuiltinUtils.AllocNativeUObject(UKuroAnalytics.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014350 RID: 82768 RVA: 0x001DAE64 File Offset: 0x001D9064
		public UKuroAnalytics(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAnalytics.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06014351 RID: 82769 RVA: 0x001DAE98 File Offset: 0x001D9098
		public unsafe static void UserUnset(string Property, int Index = 0)
		{
			FString fstring = FString.AllocTemp(Property);
			UKuroAnalytics.__UserUnset_Internal(fstring, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06014352 RID: 82770 RVA: 0x001DAEC0 File Offset: 0x001D90C0
		public unsafe static void UserUniqueAppend(string Properties, int Index = 0)
		{
			FString fstring = FString.AllocTemp(Properties);
			UKuroAnalytics.__UserUniqueAppend_Internal(fstring, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06014353 RID: 82771 RVA: 0x001DAEE8 File Offset: 0x001D90E8
		public unsafe static void UserSetOnce(string Properties, int Index = 0)
		{
			FString fstring = FString.AllocTemp(Properties);
			UKuroAnalytics.__UserSetOnce_Internal(fstring, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06014354 RID: 82772 RVA: 0x001DAF10 File Offset: 0x001D9110
		public unsafe static void UserSet(string Properties, int Index = 0)
		{
			FString fstring = FString.AllocTemp(Properties);
			UKuroAnalytics.__UserSet_Internal(fstring, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06014355 RID: 82773
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UserDelete(int Index = 0);

		// Token: 0x06014356 RID: 82774 RVA: 0x001DAF38 File Offset: 0x001D9138
		public unsafe static void UserAppend(string Properties, int Index = 0)
		{
			FString fstring = FString.AllocTemp(Properties);
			UKuroAnalytics.__UserAppend_Internal(fstring, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06014357 RID: 82775 RVA: 0x001DAF60 File Offset: 0x001D9160
		public unsafe static void UserAdd(string Property, float Value, int Index = 0)
		{
			FString fstring = FString.AllocTemp(Property);
			UKuroAnalytics.__UserAdd_Internal(fstring, Value, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06014358 RID: 82776 RVA: 0x001DAF88 File Offset: 0x001D9188
		public unsafe static bool TrackUpdate(string EventName, string Properties, string EventId, int Index = 0)
		{
			FString fstring = FString.AllocTemp(EventName);
			FString fstring2 = FString.AllocTemp(Properties);
			FString fstring3 = FString.AllocTemp(EventId);
			bool result = UKuroAnalytics.__TrackUpdate_Internal(fstring, fstring2, fstring3, Index);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			FString.NativeDestruct(&fstring3, 1);
			return result;
		}

		// Token: 0x06014359 RID: 82777 RVA: 0x001DAFD4 File Offset: 0x001D91D4
		public unsafe static bool TrackOverwrite(string EventName, string Properties, string EventId, int Index = 0)
		{
			FString fstring = FString.AllocTemp(EventName);
			FString fstring2 = FString.AllocTemp(Properties);
			FString fstring3 = FString.AllocTemp(EventId);
			bool result = UKuroAnalytics.__TrackOverwrite_Internal(fstring, fstring2, fstring3, Index);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			FString.NativeDestruct(&fstring3, 1);
			return result;
		}

		// Token: 0x0601435A RID: 82778 RVA: 0x001DB020 File Offset: 0x001D9220
		public unsafe static bool TrackFirstWithId(string EventName, string Properties, string FirstCheckId, int Index = 0)
		{
			FString fstring = FString.AllocTemp(EventName);
			FString fstring2 = FString.AllocTemp(Properties);
			FString fstring3 = FString.AllocTemp(FirstCheckId);
			bool result = UKuroAnalytics.__TrackFirstWithId_Internal(fstring, fstring2, fstring3, Index);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			FString.NativeDestruct(&fstring3, 1);
			return result;
		}

		// Token: 0x0601435B RID: 82779 RVA: 0x001DB06C File Offset: 0x001D926C
		public unsafe static bool TrackFirst(string EventName, string Properties, int Index = 0)
		{
			FString fstring = FString.AllocTemp(EventName);
			FString fstring2 = FString.AllocTemp(Properties);
			bool result = UKuroAnalytics.__TrackFirst_Internal(fstring, fstring2, Index);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0601435C RID: 82780 RVA: 0x001DB0A4 File Offset: 0x001D92A4
		public unsafe static bool Track(string EventName, string Properties, int Index = 0)
		{
			FString fstring = FString.AllocTemp(EventName);
			FString fstring2 = FString.AllocTemp(Properties);
			bool result = UKuroAnalytics.__Track_Internal(fstring, fstring2, Index);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0601435D RID: 82781
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ToggleSampleCPUFrequency(bool bActive, float SampleInterval);

		// Token: 0x0601435E RID: 82782 RVA: 0x001DB0DC File Offset: 0x001D92DC
		public unsafe static void TimeEvent(string EventName, int Index = 0)
		{
			FString fstring = FString.AllocTemp(EventName);
			UKuroAnalytics.__TimeEvent_Internal(fstring, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601435F RID: 82783
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetTrackStatus(int Status = 1, int Index = 0);

		// Token: 0x06014360 RID: 82784
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void OptOutTracking(int Index = 0);

		// Token: 0x06014361 RID: 82785
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void OptInTracking(int Index = 0);

		// Token: 0x06014362 RID: 82786
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Logout(int Index = 0);

		// Token: 0x06014363 RID: 82787 RVA: 0x001DB104 File Offset: 0x001D9304
		public unsafe static void Login(string AccountId, int Index = 0)
		{
			FString fstring = FString.AllocTemp(AccountId);
			UKuroAnalytics.__Login_Internal(fstring, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06014364 RID: 82788 RVA: 0x001DB12C File Offset: 0x001D932C
		public unsafe static void InitializeEncryptInstance(string appid, string serverurl, KAMode mode, bool bEnableLog, string timeZone, bool bEnableEncrypt, string EncryptPublicKey, int EncryptVersion, string SymmetricEncryption, string AsymmetricEncryption)
		{
			FString fstring = FString.AllocTemp(appid);
			FString fstring2 = FString.AllocTemp(serverurl);
			FString fstring3 = FString.AllocTemp(timeZone);
			FString fstring4 = FString.AllocTemp(EncryptPublicKey);
			FString fstring5 = FString.AllocTemp(SymmetricEncryption);
			FString fstring6 = FString.AllocTemp(AsymmetricEncryption);
			UKuroAnalytics.__InitializeEncryptInstance_Internal(fstring, fstring2, mode, bEnableLog, fstring3, bEnableEncrypt, fstring4, EncryptVersion, fstring5, fstring6);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			FString.NativeDestruct(&fstring3, 1);
			FString.NativeDestruct(&fstring4, 1);
			FString.NativeDestruct(&fstring5, 1);
			FString.NativeDestruct(&fstring6, 1);
		}

		// Token: 0x06014365 RID: 82789 RVA: 0x001DB1B8 File Offset: 0x001D93B8
		public unsafe static bool InitializeDefaultInsWithURL_Appid(string ServerURL, string Appid, float ExitWaitTime, int MaxPendingLog, float SendHttpTimeout, bool bExitFlush, float CalibrateIntervalTime, bool bCalibratedStopTimer)
		{
			FString fstring = FString.AllocTemp(ServerURL);
			FString fstring2 = FString.AllocTemp(Appid);
			bool result = UKuroAnalytics.__InitializeDefaultInsWithURL_Appid_Internal(fstring, fstring2, ExitWaitTime, MaxPendingLog, SendHttpTimeout, bExitFlush, CalibrateIntervalTime, bCalibratedStopTimer);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06014366 RID: 82790
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Initialize();

		// Token: 0x06014367 RID: 82791 RVA: 0x001DB1F8 File Offset: 0x001D93F8
		public unsafe static void Identify(string DistinctId, int Index = 0)
		{
			FString fstring = FString.AllocTemp(DistinctId);
			UKuroAnalytics.__Identify_Internal(fstring, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06014368 RID: 82792
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasInstanceTimeCalibrated(int Index);

		// Token: 0x06014369 RID: 82793
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasInstanceInitialized(int Index);

		// Token: 0x0601436A RID: 82794
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasDefaultInstanceInitialized();

		// Token: 0x0601436B RID: 82795 RVA: 0x001DB21D File Offset: 0x001D941D
		public static string GetSuperProperties(int Index = 0)
		{
			return FString.ToStringAndDeleteNativePtr(UKuroAnalytics.__GetSuperProperties_Internal(Index));
		}

		// Token: 0x0601436C RID: 82796 RVA: 0x001DB22A File Offset: 0x001D942A
		public static string GetServerUrl(int Index = 0)
		{
			return FString.ToStringAndDeleteNativePtr(UKuroAnalytics.__GetServerUrl_Internal(Index));
		}

		// Token: 0x0601436D RID: 82797 RVA: 0x001DB237 File Offset: 0x001D9437
		public static string GetPresetProperties(int Index = 0)
		{
			return FString.ToStringAndDeleteNativePtr(UKuroAnalytics.__GetPresetProperties_Internal(Index));
		}

		// Token: 0x0601436E RID: 82798 RVA: 0x001DB244 File Offset: 0x001D9444
		public static string GetMachineID()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroAnalytics.__GetMachineID_Internal());
		}

		// Token: 0x0601436F RID: 82799 RVA: 0x001DB250 File Offset: 0x001D9450
		public static string GetDistinctId(int Index = 0)
		{
			return FString.ToStringAndDeleteNativePtr(UKuroAnalytics.__GetDistinctId_Internal(Index));
		}

		// Token: 0x06014370 RID: 82800 RVA: 0x001DB25D File Offset: 0x001D945D
		public static string GetDeviceId(int Index = 0)
		{
			return FString.ToStringAndDeleteNativePtr(UKuroAnalytics.__GetDeviceId_Internal(Index));
		}

		// Token: 0x06014371 RID: 82801
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetCurrentCPUSampledMaxFrequency();

		// Token: 0x06014372 RID: 82802
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetCurrentCPUSampledAvgFrequency();

		// Token: 0x06014373 RID: 82803 RVA: 0x001DB26A File Offset: 0x001D946A
		public static string GetAppId(int Index = 0)
		{
			return FString.ToStringAndDeleteNativePtr(UKuroAnalytics.__GetAppId_Internal(Index));
		}

		// Token: 0x06014374 RID: 82804
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Flush(int Index = 0);

		// Token: 0x06014375 RID: 82805
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void EnableTracking(bool bIsEnable, int Index = 0);

		// Token: 0x06014376 RID: 82806 RVA: 0x001DB277 File Offset: 0x001D9477
		public static void EnableThirdPartySharing([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> EventTypeList, int Index = 0)
		{
			UKuroAnalytics.__EnableThirdPartySharing_Internal((EventTypeList ?? new TArray<string>()).NativePtr, Index);
		}

		// Token: 0x06014377 RID: 82807 RVA: 0x001DB290 File Offset: 0x001D9490
		public unsafe static void EnableAutoTrackWithTypeAndProperties([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> EventTypeList, string Properties, int Index = 0)
		{
			FString fstring = FString.AllocTemp(Properties);
			UKuroAnalytics.__EnableAutoTrackWithTypeAndProperties_Internal((EventTypeList ?? new TArray<string>()).NativePtr, fstring, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06014378 RID: 82808 RVA: 0x001DB2C5 File Offset: 0x001D94C5
		public static void EnableAutoTrackWithType([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> EventTypeList, int Index = 0)
		{
			UKuroAnalytics.__EnableAutoTrackWithType_Internal((EventTypeList ?? new TArray<string>()).NativePtr, Index);
		}

		// Token: 0x06014379 RID: 82809
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void EnableAutoTrack(int Index = 0);

		// Token: 0x0601437A RID: 82810
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DestroyInstance(int Index, bool Flush = true);

		// Token: 0x0601437B RID: 82811
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DestroyAllInstance(bool Flush);

		// Token: 0x0601437C RID: 82812 RVA: 0x001DB2DD File Offset: 0x001D94DD
		[NullableContext(2)]
		public static bool CreateSimpleInstance(in FKACreateInstanceParam Param)
		{
			return UKuroAnalytics.__CreateSimpleInstance_Internal((Param ?? new FKACreateInstanceParam()).NativePtr);
		}

		// Token: 0x0601437D RID: 82813 RVA: 0x001DB2F4 File Offset: 0x001D94F4
		[NullableContext(2)]
		public static void CalibrateTime(in FKAOnTimeCalibrated OnTimeCalibrated, int Index = 0)
		{
			FKAOnTimeCalibrated fkaonTimeCalibrated = OnTimeCalibrated;
			UKuroAnalytics.__CalibrateTime_Internal((fkaonTimeCalibrated != null) ? fkaonTimeCalibrated.NativePtr : ((IntPtr)0), Index);
		}

		// Token: 0x0601437E RID: 82814
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UserUnset_Internal(in FString Property, int Index);

		// Token: 0x0601437F RID: 82815
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UserUniqueAppend_Internal(in FString Properties, int Index);

		// Token: 0x06014380 RID: 82816
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UserSetOnce_Internal(in FString Properties, int Index);

		// Token: 0x06014381 RID: 82817
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UserSet_Internal(in FString Properties, int Index);

		// Token: 0x06014382 RID: 82818
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UserAppend_Internal(in FString Properties, int Index);

		// Token: 0x06014383 RID: 82819
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UserAdd_Internal(in FString Property, float Value, int Index);

		// Token: 0x06014384 RID: 82820
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __TrackUpdate_Internal(in FString EventName, in FString Properties, in FString EventId, int Index);

		// Token: 0x06014385 RID: 82821
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __TrackOverwrite_Internal(in FString EventName, in FString Properties, in FString EventId, int Index);

		// Token: 0x06014386 RID: 82822
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __TrackFirstWithId_Internal(in FString EventName, in FString Properties, in FString FirstCheckId, int Index);

		// Token: 0x06014387 RID: 82823
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __TrackFirst_Internal(in FString EventName, in FString Properties, int Index);

		// Token: 0x06014388 RID: 82824
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Track_Internal(in FString EventName, in FString Properties, int Index);

		// Token: 0x06014389 RID: 82825
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TimeEvent_Internal(in FString EventName, int Index);

		// Token: 0x0601438A RID: 82826
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Login_Internal(in FString AccountId, int Index);

		// Token: 0x0601438B RID: 82827
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitializeEncryptInstance_Internal(in FString appid, in FString serverurl, KAMode mode, bool bEnableLog, in FString timeZone, bool bEnableEncrypt, in FString EncryptPublicKey, int EncryptVersion, in FString SymmetricEncryption, in FString AsymmetricEncryption);

		// Token: 0x0601438C RID: 82828
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __InitializeDefaultInsWithURL_Appid_Internal(in FString ServerURL, in FString Appid, float ExitWaitTime, int MaxPendingLog, float SendHttpTimeout, bool bExitFlush, float CalibrateIntervalTime, bool bCalibratedStopTimer);

		// Token: 0x0601438D RID: 82829
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Identify_Internal(in FString DistinctId, int Index);

		// Token: 0x0601438E RID: 82830
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetSuperProperties_Internal(int Index);

		// Token: 0x0601438F RID: 82831
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetServerUrl_Internal(int Index);

		// Token: 0x06014390 RID: 82832
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetPresetProperties_Internal(int Index);

		// Token: 0x06014391 RID: 82833
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetMachineID_Internal();

		// Token: 0x06014392 RID: 82834
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetDistinctId_Internal(int Index);

		// Token: 0x06014393 RID: 82835
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetDeviceId_Internal(int Index);

		// Token: 0x06014394 RID: 82836
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetAppId_Internal(int Index);

		// Token: 0x06014395 RID: 82837
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EnableThirdPartySharing_Internal(IntPtr EventTypeList, int Index);

		// Token: 0x06014396 RID: 82838
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EnableAutoTrackWithTypeAndProperties_Internal(IntPtr EventTypeList, in FString Properties, int Index);

		// Token: 0x06014397 RID: 82839
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EnableAutoTrackWithType_Internal(IntPtr EventTypeList, int Index);

		// Token: 0x06014398 RID: 82840
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CreateSimpleInstance_Internal(IntPtr Param);

		// Token: 0x06014399 RID: 82841
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CalibrateTime_Internal(IntPtr OnTimeCalibrated, int Index);

		// Token: 0x0601439A RID: 82842 RVA: 0x001DB30B File Offset: 0x001D950B
		static UKuroAnalytics()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KRDataAnalyticsPlugin.KuroAnalytics");
		}

		// Token: 0x0601439B RID: 82843 RVA: 0x001DB319 File Offset: 0x001D9519
		protected UKuroAnalytics(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AFD9 RID: 45017
		public new const string __ObjectPath = "/Script/KRDataAnalyticsPlugin.KuroAnalytics";

		// Token: 0x0400AFDA RID: 45018
		private static IntPtr _ClassPtr;

		// Token: 0x0400AFDB RID: 45019
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
