using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028FF RID: 10495
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/TASdkPlugin.ThinkingAnalytics")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UThinkingAnalytics : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026EA6 RID: 159398 RVA: 0x003B5DB6 File Offset: 0x003B3FB6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UThinkingAnalytics._ClassPtr;
		}

		// Token: 0x06026EA7 RID: 159399 RVA: 0x003B5DC4 File Offset: 0x003B3FC4
		public UThinkingAnalytics() : this(BuiltinUtils.AllocNativeUObject(UThinkingAnalytics.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026EA8 RID: 159400 RVA: 0x003B5DEC File Offset: 0x003B3FEC
		public UThinkingAnalytics(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UThinkingAnalytics.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06026EA9 RID: 159401 RVA: 0x003B5E20 File Offset: 0x003B4020
		public unsafe static void UserUnset(string Property, int Index = 0)
		{
			FString fstring = FString.AllocTemp(Property);
			UThinkingAnalytics.__UserUnset_Internal(fstring, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06026EAA RID: 159402 RVA: 0x003B5E48 File Offset: 0x003B4048
		public unsafe static void UserUniqueAppend(string Properties, int Index = 0)
		{
			FString fstring = FString.AllocTemp(Properties);
			UThinkingAnalytics.__UserUniqueAppend_Internal(fstring, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06026EAB RID: 159403 RVA: 0x003B5E70 File Offset: 0x003B4070
		public unsafe static void UserSetOnce(string Properties, int Index = 0)
		{
			FString fstring = FString.AllocTemp(Properties);
			UThinkingAnalytics.__UserSetOnce_Internal(fstring, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06026EAC RID: 159404 RVA: 0x003B5E98 File Offset: 0x003B4098
		public unsafe static void UserSet(string Properties, int Index = 0)
		{
			FString fstring = FString.AllocTemp(Properties);
			UThinkingAnalytics.__UserSet_Internal(fstring, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06026EAD RID: 159405
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UserDelete(int Index = 0);

		// Token: 0x06026EAE RID: 159406 RVA: 0x003B5EC0 File Offset: 0x003B40C0
		public unsafe static void UserAppend(string Properties, int Index = 0)
		{
			FString fstring = FString.AllocTemp(Properties);
			UThinkingAnalytics.__UserAppend_Internal(fstring, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06026EAF RID: 159407 RVA: 0x003B5EE8 File Offset: 0x003B40E8
		public unsafe static void UserAdd(string Property, float Value, int Index = 0)
		{
			FString fstring = FString.AllocTemp(Property);
			UThinkingAnalytics.__UserAdd_Internal(fstring, Value, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06026EB0 RID: 159408 RVA: 0x003B5F10 File Offset: 0x003B4110
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

		// Token: 0x06026EB1 RID: 159409 RVA: 0x003B5F5C File Offset: 0x003B415C
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

		// Token: 0x06026EB2 RID: 159410 RVA: 0x003B5FA8 File Offset: 0x003B41A8
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

		// Token: 0x06026EB3 RID: 159411 RVA: 0x003B5FF4 File Offset: 0x003B41F4
		public unsafe static bool TrackFirst(string EventName, string Properties, int Index = 0)
		{
			FString fstring = FString.AllocTemp(EventName);
			FString fstring2 = FString.AllocTemp(Properties);
			bool result = UThinkingAnalytics.__TrackFirst_Internal(fstring, fstring2, Index);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06026EB4 RID: 159412 RVA: 0x003B602C File Offset: 0x003B422C
		public unsafe static bool Track(string EventName, string Properties, int Index = 0)
		{
			FString fstring = FString.AllocTemp(EventName);
			FString fstring2 = FString.AllocTemp(Properties);
			bool result = UThinkingAnalytics.__Track_Internal(fstring, fstring2, Index);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06026EB5 RID: 159413
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ToggleSampleCPUFrequency(bool bActive, float SampleInterval);

		// Token: 0x06026EB6 RID: 159414 RVA: 0x003B6064 File Offset: 0x003B4264
		public unsafe static void TimeEvent(string EventName, int Index = 0)
		{
			FString fstring = FString.AllocTemp(EventName);
			UThinkingAnalytics.__TimeEvent_Internal(fstring, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06026EB7 RID: 159415
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetTrackStatus(int Status = 1, int Index = 0);

		// Token: 0x06026EB8 RID: 159416
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void OptOutTracking(int Index = 0);

		// Token: 0x06026EB9 RID: 159417
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void OptInTracking(int Index = 0);

		// Token: 0x06026EBA RID: 159418
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Logout(int Index = 0);

		// Token: 0x06026EBB RID: 159419 RVA: 0x003B608C File Offset: 0x003B428C
		public unsafe static void Login(string AccountId, int Index = 0)
		{
			FString fstring = FString.AllocTemp(AccountId);
			UThinkingAnalytics.__Login_Internal(fstring, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06026EBC RID: 159420 RVA: 0x003B60B4 File Offset: 0x003B42B4
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

		// Token: 0x06026EBD RID: 159421 RVA: 0x003B6140 File Offset: 0x003B4340
		public unsafe static bool InitializeDefaultInsWithURL_Appid(string ServerURL, string Appid, float ExitWaitTime, int MaxPendingLog, float SendHttpTimeout, bool bExitFlush, float CalibrateIntervalTime, bool bCalibratedStopTimer)
		{
			FString fstring = FString.AllocTemp(ServerURL);
			FString fstring2 = FString.AllocTemp(Appid);
			bool result = UThinkingAnalytics.__InitializeDefaultInsWithURL_Appid_Internal(fstring, fstring2, ExitWaitTime, MaxPendingLog, SendHttpTimeout, bExitFlush, CalibrateIntervalTime, bCalibratedStopTimer);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06026EBE RID: 159422
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Initialize();

		// Token: 0x06026EBF RID: 159423 RVA: 0x003B6180 File Offset: 0x003B4380
		public unsafe static void Identify(string DistinctId, int Index = 0)
		{
			FString fstring = FString.AllocTemp(DistinctId);
			UThinkingAnalytics.__Identify_Internal(fstring, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06026EC0 RID: 159424
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasInstanceTimeCalibrated(int Index);

		// Token: 0x06026EC1 RID: 159425
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasInstanceInitialized(int Index);

		// Token: 0x06026EC2 RID: 159426
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasDefaultInstanceInitialized();

		// Token: 0x06026EC3 RID: 159427 RVA: 0x003B61A5 File Offset: 0x003B43A5
		public static string GetSuperProperties(int Index = 0)
		{
			return FString.ToStringAndDeleteNativePtr(UThinkingAnalytics.__GetSuperProperties_Internal(Index));
		}

		// Token: 0x06026EC4 RID: 159428 RVA: 0x003B61B2 File Offset: 0x003B43B2
		public static string GetServerUrl(int Index = 0)
		{
			return FString.ToStringAndDeleteNativePtr(UThinkingAnalytics.__GetServerUrl_Internal(Index));
		}

		// Token: 0x06026EC5 RID: 159429 RVA: 0x003B61BF File Offset: 0x003B43BF
		public static string GetPresetProperties(int Index = 0)
		{
			return FString.ToStringAndDeleteNativePtr(UThinkingAnalytics.__GetPresetProperties_Internal(Index));
		}

		// Token: 0x06026EC6 RID: 159430 RVA: 0x003B61CC File Offset: 0x003B43CC
		public static string GetMachineID()
		{
			return FString.ToStringAndDeleteNativePtr(UThinkingAnalytics.__GetMachineID_Internal());
		}

		// Token: 0x06026EC7 RID: 159431 RVA: 0x003B61D8 File Offset: 0x003B43D8
		public static string GetDistinctId(int Index = 0)
		{
			return FString.ToStringAndDeleteNativePtr(UThinkingAnalytics.__GetDistinctId_Internal(Index));
		}

		// Token: 0x06026EC8 RID: 159432 RVA: 0x003B61E5 File Offset: 0x003B43E5
		public static string GetDeviceId(int Index = 0)
		{
			return FString.ToStringAndDeleteNativePtr(UThinkingAnalytics.__GetDeviceId_Internal(Index));
		}

		// Token: 0x06026EC9 RID: 159433
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetCurrentCPUSampledMaxFrequency();

		// Token: 0x06026ECA RID: 159434
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetCurrentCPUSampledAvgFrequency();

		// Token: 0x06026ECB RID: 159435 RVA: 0x003B61F2 File Offset: 0x003B43F2
		public static string GetAppId(int Index = 0)
		{
			return FString.ToStringAndDeleteNativePtr(UThinkingAnalytics.__GetAppId_Internal(Index));
		}

		// Token: 0x06026ECC RID: 159436
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Flush(int Index = 0);

		// Token: 0x06026ECD RID: 159437
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void EnableTracking(bool bIsEnable, int Index = 0);

		// Token: 0x06026ECE RID: 159438 RVA: 0x003B61FF File Offset: 0x003B43FF
		public static void EnableThirdPartySharing([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> EventTypeList, int Index = 0)
		{
			UThinkingAnalytics.__EnableThirdPartySharing_Internal((EventTypeList ?? new TArray<string>()).NativePtr, Index);
		}

		// Token: 0x06026ECF RID: 159439 RVA: 0x003B6218 File Offset: 0x003B4418
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

		// Token: 0x06026ED0 RID: 159440 RVA: 0x003B624D File Offset: 0x003B444D
		public static void EnableAutoTrackWithType([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> EventTypeList, int Index = 0)
		{
			UThinkingAnalytics.__EnableAutoTrackWithType_Internal((EventTypeList ?? new TArray<string>()).NativePtr, Index);
		}

		// Token: 0x06026ED1 RID: 159441
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void EnableAutoTrack(int Index = 0);

		// Token: 0x06026ED2 RID: 159442
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DestroyInstance(int Index, bool Flush = true);

		// Token: 0x06026ED3 RID: 159443 RVA: 0x003B6265 File Offset: 0x003B4465
		[NullableContext(2)]
		public static bool CreateSimpleInstance(in FCreateInstanceParam Param)
		{
			return UThinkingAnalytics.__CreateSimpleInstance_Internal((Param ?? new FCreateInstanceParam()).NativePtr);
		}

		// Token: 0x06026ED4 RID: 159444 RVA: 0x003B627C File Offset: 0x003B447C
		[NullableContext(2)]
		public static void CalibrateTime(in FOnTimeCalibrated OnTimeCalibrated, int Index = 0)
		{
			FOnTimeCalibrated fonTimeCalibrated = OnTimeCalibrated;
			UThinkingAnalytics.__CalibrateTime_Internal((fonTimeCalibrated != null) ? fonTimeCalibrated.NativePtr : ((IntPtr)0), Index);
		}

		// Token: 0x06026ED5 RID: 159445
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UserUnset_Internal(in FString Property, int Index);

		// Token: 0x06026ED6 RID: 159446
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UserUniqueAppend_Internal(in FString Properties, int Index);

		// Token: 0x06026ED7 RID: 159447
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UserSetOnce_Internal(in FString Properties, int Index);

		// Token: 0x06026ED8 RID: 159448
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UserSet_Internal(in FString Properties, int Index);

		// Token: 0x06026ED9 RID: 159449
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UserAppend_Internal(in FString Properties, int Index);

		// Token: 0x06026EDA RID: 159450
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UserAdd_Internal(in FString Property, float Value, int Index);

		// Token: 0x06026EDB RID: 159451
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __TrackUpdate_Internal(in FString EventName, in FString Properties, in FString EventId, int Index);

		// Token: 0x06026EDC RID: 159452
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __TrackOverwrite_Internal(in FString EventName, in FString Properties, in FString EventId, int Index);

		// Token: 0x06026EDD RID: 159453
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __TrackFirstWithId_Internal(in FString EventName, in FString Properties, in FString FirstCheckId, int Index);

		// Token: 0x06026EDE RID: 159454
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __TrackFirst_Internal(in FString EventName, in FString Properties, int Index);

		// Token: 0x06026EDF RID: 159455
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Track_Internal(in FString EventName, in FString Properties, int Index);

		// Token: 0x06026EE0 RID: 159456
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TimeEvent_Internal(in FString EventName, int Index);

		// Token: 0x06026EE1 RID: 159457
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Login_Internal(in FString AccountId, int Index);

		// Token: 0x06026EE2 RID: 159458
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitializeEncryptInstance_Internal(in FString appid, in FString serverurl, TAMode mode, bool bEnableLog, in FString timeZone, bool bEnableEncrypt, in FString EncryptPublicKey, int EncryptVersion, in FString SymmetricEncryption, in FString AsymmetricEncryption);

		// Token: 0x06026EE3 RID: 159459
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __InitializeDefaultInsWithURL_Appid_Internal(in FString ServerURL, in FString Appid, float ExitWaitTime, int MaxPendingLog, float SendHttpTimeout, bool bExitFlush, float CalibrateIntervalTime, bool bCalibratedStopTimer);

		// Token: 0x06026EE4 RID: 159460
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Identify_Internal(in FString DistinctId, int Index);

		// Token: 0x06026EE5 RID: 159461
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetSuperProperties_Internal(int Index);

		// Token: 0x06026EE6 RID: 159462
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetServerUrl_Internal(int Index);

		// Token: 0x06026EE7 RID: 159463
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetPresetProperties_Internal(int Index);

		// Token: 0x06026EE8 RID: 159464
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetMachineID_Internal();

		// Token: 0x06026EE9 RID: 159465
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetDistinctId_Internal(int Index);

		// Token: 0x06026EEA RID: 159466
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetDeviceId_Internal(int Index);

		// Token: 0x06026EEB RID: 159467
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetAppId_Internal(int Index);

		// Token: 0x06026EEC RID: 159468
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EnableThirdPartySharing_Internal(IntPtr EventTypeList, int Index);

		// Token: 0x06026EED RID: 159469
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EnableAutoTrackWithTypeAndProperties_Internal(IntPtr EventTypeList, in FString Properties, int Index);

		// Token: 0x06026EEE RID: 159470
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EnableAutoTrackWithType_Internal(IntPtr EventTypeList, int Index);

		// Token: 0x06026EEF RID: 159471
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CreateSimpleInstance_Internal(IntPtr Param);

		// Token: 0x06026EF0 RID: 159472
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CalibrateTime_Internal(IntPtr OnTimeCalibrated, int Index);

		// Token: 0x06026EF1 RID: 159473 RVA: 0x003B6293 File Offset: 0x003B4493
		static UThinkingAnalytics()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/TASdkPlugin.ThinkingAnalytics");
		}

		// Token: 0x06026EF2 RID: 159474 RVA: 0x003B62A1 File Offset: 0x003B44A1
		protected UThinkingAnalytics(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040155E2 RID: 87522
		public new const string __ObjectPath = "/Script/TASdkPlugin.ThinkingAnalytics";

		// Token: 0x040155E3 RID: 87523
		private static IntPtr _ClassPtr;

		// Token: 0x040155E4 RID: 87524
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
