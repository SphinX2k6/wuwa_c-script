using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200084F RID: 2127
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/TASdkPlugin.ThinkingAnalytics")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UThinkingAnalytics : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B936 RID: 47414 RVA: 0x00128852 File Offset: 0x00126A52
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UThinkingAnalytics._ClassPtr;
		}

		// Token: 0x0600B937 RID: 47415 RVA: 0x00128860 File Offset: 0x00126A60
		public UThinkingAnalytics() : this(BuiltinUtils.AllocNativeUObject(UThinkingAnalytics.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B938 RID: 47416 RVA: 0x00128888 File Offset: 0x00126A88
		public UThinkingAnalytics(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UThinkingAnalytics.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600B939 RID: 47417 RVA: 0x001288BC File Offset: 0x00126ABC
		public unsafe static void UserUnset(string Property, int Index = 0)
		{
			FString fstring = FString.AllocTemp(Property);
			UThinkingAnalytics.__UserUnset_Internal(fstring, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600B93A RID: 47418 RVA: 0x001288E4 File Offset: 0x00126AE4
		public unsafe static void UserUniqueAppend(string Properties, int Index = 0)
		{
			FString fstring = FString.AllocTemp(Properties);
			UThinkingAnalytics.__UserUniqueAppend_Internal(fstring, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600B93B RID: 47419 RVA: 0x0012890C File Offset: 0x00126B0C
		public unsafe static void UserSetOnce(string Properties, int Index = 0)
		{
			FString fstring = FString.AllocTemp(Properties);
			UThinkingAnalytics.__UserSetOnce_Internal(fstring, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600B93C RID: 47420 RVA: 0x00128934 File Offset: 0x00126B34
		public unsafe static void UserSet(string Properties, int Index = 0)
		{
			FString fstring = FString.AllocTemp(Properties);
			UThinkingAnalytics.__UserSet_Internal(fstring, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600B93D RID: 47421
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UserDelete(int Index = 0);

		// Token: 0x0600B93E RID: 47422 RVA: 0x0012895C File Offset: 0x00126B5C
		public unsafe static void UserAppend(string Properties, int Index = 0)
		{
			FString fstring = FString.AllocTemp(Properties);
			UThinkingAnalytics.__UserAppend_Internal(fstring, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600B93F RID: 47423 RVA: 0x00128984 File Offset: 0x00126B84
		public unsafe static void UserAdd(string Property, float Value, int Index = 0)
		{
			FString fstring = FString.AllocTemp(Property);
			UThinkingAnalytics.__UserAdd_Internal(fstring, Value, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600B940 RID: 47424 RVA: 0x001289AC File Offset: 0x00126BAC
		public unsafe static bool TrackUpdate(string EventName, string Properties, string EventId, int Index = 0)
		{
			FString fstring = FString.AllocTemp(EventName);
			FString fstring2 = FString.AllocTemp(Properties);
			FString fstring3 = FString.AllocTemp(EventId);
			bool result = UThinkingAnalytics.__TrackUpdate_Internal(fstring, fstring2, fstring3, Index);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			FString.NativeDestruct(&fstring3, 1);
			return result;
		}

		// Token: 0x0600B941 RID: 47425 RVA: 0x001289F8 File Offset: 0x00126BF8
		public unsafe static bool TrackOverwrite(string EventName, string Properties, string EventId, int Index = 0)
		{
			FString fstring = FString.AllocTemp(EventName);
			FString fstring2 = FString.AllocTemp(Properties);
			FString fstring3 = FString.AllocTemp(EventId);
			bool result = UThinkingAnalytics.__TrackOverwrite_Internal(fstring, fstring2, fstring3, Index);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			FString.NativeDestruct(&fstring3, 1);
			return result;
		}

		// Token: 0x0600B942 RID: 47426 RVA: 0x00128A44 File Offset: 0x00126C44
		public unsafe static bool TrackFirstWithId(string EventName, string Properties, string FirstCheckId, int Index = 0)
		{
			FString fstring = FString.AllocTemp(EventName);
			FString fstring2 = FString.AllocTemp(Properties);
			FString fstring3 = FString.AllocTemp(FirstCheckId);
			bool result = UThinkingAnalytics.__TrackFirstWithId_Internal(fstring, fstring2, fstring3, Index);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			FString.NativeDestruct(&fstring3, 1);
			return result;
		}

		// Token: 0x0600B943 RID: 47427 RVA: 0x00128A90 File Offset: 0x00126C90
		public unsafe static bool TrackFirst(string EventName, string Properties, int Index = 0)
		{
			FString fstring = FString.AllocTemp(EventName);
			FString fstring2 = FString.AllocTemp(Properties);
			bool result = UThinkingAnalytics.__TrackFirst_Internal(fstring, fstring2, Index);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0600B944 RID: 47428 RVA: 0x00128AC8 File Offset: 0x00126CC8
		public unsafe static bool Track(string EventName, string Properties, int Index = 0)
		{
			FString fstring = FString.AllocTemp(EventName);
			FString fstring2 = FString.AllocTemp(Properties);
			bool result = UThinkingAnalytics.__Track_Internal(fstring, fstring2, Index);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0600B945 RID: 47429
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ToggleSampleCPUFrequency(bool bActive, float SampleInterval);

		// Token: 0x0600B946 RID: 47430 RVA: 0x00128B00 File Offset: 0x00126D00
		public unsafe static void TimeEvent(string EventName, int Index = 0)
		{
			FString fstring = FString.AllocTemp(EventName);
			UThinkingAnalytics.__TimeEvent_Internal(fstring, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600B947 RID: 47431
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetTrackStatus(int Status = 1, int Index = 0);

		// Token: 0x0600B948 RID: 47432
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void OptOutTracking(int Index = 0);

		// Token: 0x0600B949 RID: 47433
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void OptInTracking(int Index = 0);

		// Token: 0x0600B94A RID: 47434
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Logout(int Index = 0);

		// Token: 0x0600B94B RID: 47435 RVA: 0x00128B28 File Offset: 0x00126D28
		public unsafe static void Login(string AccountId, int Index = 0)
		{
			FString fstring = FString.AllocTemp(AccountId);
			UThinkingAnalytics.__Login_Internal(fstring, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600B94C RID: 47436 RVA: 0x00128B50 File Offset: 0x00126D50
		public unsafe static void InitializeEncryptInstance(string appid, string serverurl, TAMode mode, bool bEnableLog, string timeZone, bool bEnableEncrypt, string EncryptPublicKey, int EncryptVersion, string SymmetricEncryption, string AsymmetricEncryption)
		{
			FString fstring = FString.AllocTemp(appid);
			FString fstring2 = FString.AllocTemp(serverurl);
			FString fstring3 = FString.AllocTemp(timeZone);
			FString fstring4 = FString.AllocTemp(EncryptPublicKey);
			FString fstring5 = FString.AllocTemp(SymmetricEncryption);
			FString fstring6 = FString.AllocTemp(AsymmetricEncryption);
			UThinkingAnalytics.__InitializeEncryptInstance_Internal(fstring, fstring2, mode, bEnableLog, fstring3, bEnableEncrypt, fstring4, EncryptVersion, fstring5, fstring6);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			FString.NativeDestruct(&fstring3, 1);
			FString.NativeDestruct(&fstring4, 1);
			FString.NativeDestruct(&fstring5, 1);
			FString.NativeDestruct(&fstring6, 1);
		}

		// Token: 0x0600B94D RID: 47437 RVA: 0x00128BDC File Offset: 0x00126DDC
		public unsafe static bool InitializeDefaultInsWithURL_Appid(string ServerURL, string Appid, float ExitWaitTime, int MaxPendingLog, float SendHttpTimeout, bool bExitFlush, float CalibrateIntervalTime, bool bCalibratedStopTimer)
		{
			FString fstring = FString.AllocTemp(ServerURL);
			FString fstring2 = FString.AllocTemp(Appid);
			bool result = UThinkingAnalytics.__InitializeDefaultInsWithURL_Appid_Internal(fstring, fstring2, ExitWaitTime, MaxPendingLog, SendHttpTimeout, bExitFlush, CalibrateIntervalTime, bCalibratedStopTimer);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0600B94E RID: 47438
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Initialize();

		// Token: 0x0600B94F RID: 47439 RVA: 0x00128C1C File Offset: 0x00126E1C
		public unsafe static void Identify(string DistinctId, int Index = 0)
		{
			FString fstring = FString.AllocTemp(DistinctId);
			UThinkingAnalytics.__Identify_Internal(fstring, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600B950 RID: 47440
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasInstanceTimeCalibrated(int Index);

		// Token: 0x0600B951 RID: 47441
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasInstanceInitialized(int Index);

		// Token: 0x0600B952 RID: 47442
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasDefaultInstanceInitialized();

		// Token: 0x0600B953 RID: 47443 RVA: 0x00128C41 File Offset: 0x00126E41
		public static string GetSuperProperties(int Index = 0)
		{
			return FString.ToStringAndDeleteNativePtr(UThinkingAnalytics.__GetSuperProperties_Internal(Index));
		}

		// Token: 0x0600B954 RID: 47444 RVA: 0x00128C4E File Offset: 0x00126E4E
		public static string GetServerUrl(int Index = 0)
		{
			return FString.ToStringAndDeleteNativePtr(UThinkingAnalytics.__GetServerUrl_Internal(Index));
		}

		// Token: 0x0600B955 RID: 47445 RVA: 0x00128C5B File Offset: 0x00126E5B
		public static string GetPresetProperties(int Index = 0)
		{
			return FString.ToStringAndDeleteNativePtr(UThinkingAnalytics.__GetPresetProperties_Internal(Index));
		}

		// Token: 0x0600B956 RID: 47446 RVA: 0x00128C68 File Offset: 0x00126E68
		public static string GetMachineID()
		{
			return FString.ToStringAndDeleteNativePtr(UThinkingAnalytics.__GetMachineID_Internal());
		}

		// Token: 0x0600B957 RID: 47447 RVA: 0x00128C74 File Offset: 0x00126E74
		public static string GetDistinctId(int Index = 0)
		{
			return FString.ToStringAndDeleteNativePtr(UThinkingAnalytics.__GetDistinctId_Internal(Index));
		}

		// Token: 0x0600B958 RID: 47448 RVA: 0x00128C81 File Offset: 0x00126E81
		public static string GetDeviceId(int Index = 0)
		{
			return FString.ToStringAndDeleteNativePtr(UThinkingAnalytics.__GetDeviceId_Internal(Index));
		}

		// Token: 0x0600B959 RID: 47449
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetCurrentCPUSampledMaxFrequency();

		// Token: 0x0600B95A RID: 47450
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetCurrentCPUSampledAvgFrequency();

		// Token: 0x0600B95B RID: 47451 RVA: 0x00128C8E File Offset: 0x00126E8E
		public static string GetAppId(int Index = 0)
		{
			return FString.ToStringAndDeleteNativePtr(UThinkingAnalytics.__GetAppId_Internal(Index));
		}

		// Token: 0x0600B95C RID: 47452
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Flush(int Index = 0);

		// Token: 0x0600B95D RID: 47453
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void EnableTracking(bool bIsEnable, int Index = 0);

		// Token: 0x0600B95E RID: 47454 RVA: 0x00128C9B File Offset: 0x00126E9B
		public static void EnableThirdPartySharing([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> EventTypeList, int Index = 0)
		{
			UThinkingAnalytics.__EnableThirdPartySharing_Internal((EventTypeList ?? new TArray<string>()).NativePtr, Index);
		}

		// Token: 0x0600B95F RID: 47455 RVA: 0x00128CB4 File Offset: 0x00126EB4
		public unsafe static void EnableAutoTrackWithTypeAndProperties([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> EventTypeList, string Properties, int Index = 0)
		{
			FString fstring = FString.AllocTemp(Properties);
			UThinkingAnalytics.__EnableAutoTrackWithTypeAndProperties_Internal((EventTypeList ?? new TArray<string>()).NativePtr, fstring, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600B960 RID: 47456 RVA: 0x00128CE9 File Offset: 0x00126EE9
		public static void EnableAutoTrackWithType([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> EventTypeList, int Index = 0)
		{
			UThinkingAnalytics.__EnableAutoTrackWithType_Internal((EventTypeList ?? new TArray<string>()).NativePtr, Index);
		}

		// Token: 0x0600B961 RID: 47457
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void EnableAutoTrack(int Index = 0);

		// Token: 0x0600B962 RID: 47458
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DestroyInstance(int Index, bool Flush = true);

		// Token: 0x0600B963 RID: 47459 RVA: 0x00128D01 File Offset: 0x00126F01
		[NullableContext(2)]
		public static bool CreateSimpleInstance(in FCreateInstanceParam Param)
		{
			return UThinkingAnalytics.__CreateSimpleInstance_Internal((Param ?? new FCreateInstanceParam()).NativePtr);
		}

		// Token: 0x0600B964 RID: 47460 RVA: 0x00128D18 File Offset: 0x00126F18
		[NullableContext(2)]
		public static void CalibrateTime(in FOnTimeCalibrated OnTimeCalibrated, int Index = 0)
		{
			FOnTimeCalibrated fonTimeCalibrated = OnTimeCalibrated;
			UThinkingAnalytics.__CalibrateTime_Internal((fonTimeCalibrated != null) ? fonTimeCalibrated.NativePtr : ((IntPtr)0), Index);
		}

		// Token: 0x0600B965 RID: 47461
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UserUnset_Internal(in FString Property, int Index);

		// Token: 0x0600B966 RID: 47462
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UserUniqueAppend_Internal(in FString Properties, int Index);

		// Token: 0x0600B967 RID: 47463
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UserSetOnce_Internal(in FString Properties, int Index);

		// Token: 0x0600B968 RID: 47464
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UserSet_Internal(in FString Properties, int Index);

		// Token: 0x0600B969 RID: 47465
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UserAppend_Internal(in FString Properties, int Index);

		// Token: 0x0600B96A RID: 47466
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UserAdd_Internal(in FString Property, float Value, int Index);

		// Token: 0x0600B96B RID: 47467
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __TrackUpdate_Internal(in FString EventName, in FString Properties, in FString EventId, int Index);

		// Token: 0x0600B96C RID: 47468
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __TrackOverwrite_Internal(in FString EventName, in FString Properties, in FString EventId, int Index);

		// Token: 0x0600B96D RID: 47469
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __TrackFirstWithId_Internal(in FString EventName, in FString Properties, in FString FirstCheckId, int Index);

		// Token: 0x0600B96E RID: 47470
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __TrackFirst_Internal(in FString EventName, in FString Properties, int Index);

		// Token: 0x0600B96F RID: 47471
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Track_Internal(in FString EventName, in FString Properties, int Index);

		// Token: 0x0600B970 RID: 47472
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TimeEvent_Internal(in FString EventName, int Index);

		// Token: 0x0600B971 RID: 47473
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Login_Internal(in FString AccountId, int Index);

		// Token: 0x0600B972 RID: 47474
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitializeEncryptInstance_Internal(in FString appid, in FString serverurl, TAMode mode, bool bEnableLog, in FString timeZone, bool bEnableEncrypt, in FString EncryptPublicKey, int EncryptVersion, in FString SymmetricEncryption, in FString AsymmetricEncryption);

		// Token: 0x0600B973 RID: 47475
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __InitializeDefaultInsWithURL_Appid_Internal(in FString ServerURL, in FString Appid, float ExitWaitTime, int MaxPendingLog, float SendHttpTimeout, bool bExitFlush, float CalibrateIntervalTime, bool bCalibratedStopTimer);

		// Token: 0x0600B974 RID: 47476
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Identify_Internal(in FString DistinctId, int Index);

		// Token: 0x0600B975 RID: 47477
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetSuperProperties_Internal(int Index);

		// Token: 0x0600B976 RID: 47478
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetServerUrl_Internal(int Index);

		// Token: 0x0600B977 RID: 47479
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetPresetProperties_Internal(int Index);

		// Token: 0x0600B978 RID: 47480
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetMachineID_Internal();

		// Token: 0x0600B979 RID: 47481
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetDistinctId_Internal(int Index);

		// Token: 0x0600B97A RID: 47482
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetDeviceId_Internal(int Index);

		// Token: 0x0600B97B RID: 47483
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetAppId_Internal(int Index);

		// Token: 0x0600B97C RID: 47484
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EnableThirdPartySharing_Internal(IntPtr EventTypeList, int Index);

		// Token: 0x0600B97D RID: 47485
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EnableAutoTrackWithTypeAndProperties_Internal(IntPtr EventTypeList, in FString Properties, int Index);

		// Token: 0x0600B97E RID: 47486
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EnableAutoTrackWithType_Internal(IntPtr EventTypeList, int Index);

		// Token: 0x0600B97F RID: 47487
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CreateSimpleInstance_Internal(IntPtr Param);

		// Token: 0x0600B980 RID: 47488
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CalibrateTime_Internal(IntPtr OnTimeCalibrated, int Index);

		// Token: 0x0600B981 RID: 47489 RVA: 0x00128D2F File Offset: 0x00126F2F
		static UThinkingAnalytics()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/TASdkPlugin.ThinkingAnalytics");
		}

		// Token: 0x0600B982 RID: 47490 RVA: 0x00128D3D File Offset: 0x00126F3D
		protected UThinkingAnalytics(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005430 RID: 21552
		public new const string __ObjectPath = "/Script/TASdkPlugin.ThinkingAnalytics";

		// Token: 0x04005431 RID: 21553
		private static IntPtr _ClassPtr;

		// Token: 0x04005432 RID: 21554
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
