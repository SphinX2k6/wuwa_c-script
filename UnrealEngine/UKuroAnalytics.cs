using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002D5 RID: 725
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KRDataAnalyticsPlugin.KuroAnalytics")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroAnalytics : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004E4F RID: 20047 RVA: 0x0006D862 File Offset: 0x0006BA62
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAnalytics._ClassPtr;
		}

		// Token: 0x06004E50 RID: 20048 RVA: 0x0006D870 File Offset: 0x0006BA70
		public UKuroAnalytics() : this(BuiltinUtils.AllocNativeUObject(UKuroAnalytics.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004E51 RID: 20049 RVA: 0x0006D898 File Offset: 0x0006BA98
		public UKuroAnalytics(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAnalytics.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06004E52 RID: 20050 RVA: 0x0006D8CC File Offset: 0x0006BACC
		public unsafe static void UserUnset(string Property, int Index = 0)
		{
			FString fstring = FString.AllocTemp(Property);
			UKuroAnalytics.__UserUnset_Internal(fstring, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06004E53 RID: 20051 RVA: 0x0006D8F4 File Offset: 0x0006BAF4
		public unsafe static void UserUniqueAppend(string Properties, int Index = 0)
		{
			FString fstring = FString.AllocTemp(Properties);
			UKuroAnalytics.__UserUniqueAppend_Internal(fstring, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06004E54 RID: 20052 RVA: 0x0006D91C File Offset: 0x0006BB1C
		public unsafe static void UserSetOnce(string Properties, int Index = 0)
		{
			FString fstring = FString.AllocTemp(Properties);
			UKuroAnalytics.__UserSetOnce_Internal(fstring, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06004E55 RID: 20053 RVA: 0x0006D944 File Offset: 0x0006BB44
		public unsafe static void UserSet(string Properties, int Index = 0)
		{
			FString fstring = FString.AllocTemp(Properties);
			UKuroAnalytics.__UserSet_Internal(fstring, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06004E56 RID: 20054
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UserDelete(int Index = 0);

		// Token: 0x06004E57 RID: 20055 RVA: 0x0006D96C File Offset: 0x0006BB6C
		public unsafe static void UserAppend(string Properties, int Index = 0)
		{
			FString fstring = FString.AllocTemp(Properties);
			UKuroAnalytics.__UserAppend_Internal(fstring, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06004E58 RID: 20056 RVA: 0x0006D994 File Offset: 0x0006BB94
		public unsafe static void UserAdd(string Property, float Value, int Index = 0)
		{
			FString fstring = FString.AllocTemp(Property);
			UKuroAnalytics.__UserAdd_Internal(fstring, Value, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06004E59 RID: 20057 RVA: 0x0006D9BC File Offset: 0x0006BBBC
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

		// Token: 0x06004E5A RID: 20058 RVA: 0x0006DA08 File Offset: 0x0006BC08
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

		// Token: 0x06004E5B RID: 20059 RVA: 0x0006DA54 File Offset: 0x0006BC54
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

		// Token: 0x06004E5C RID: 20060 RVA: 0x0006DAA0 File Offset: 0x0006BCA0
		public unsafe static bool TrackFirst(string EventName, string Properties, int Index = 0)
		{
			FString fstring = FString.AllocTemp(EventName);
			FString fstring2 = FString.AllocTemp(Properties);
			bool result = UKuroAnalytics.__TrackFirst_Internal(fstring, fstring2, Index);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06004E5D RID: 20061 RVA: 0x0006DAD8 File Offset: 0x0006BCD8
		public unsafe static bool Track(string EventName, string Properties, int Index = 0)
		{
			FString fstring = FString.AllocTemp(EventName);
			FString fstring2 = FString.AllocTemp(Properties);
			bool result = UKuroAnalytics.__Track_Internal(fstring, fstring2, Index);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06004E5E RID: 20062
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ToggleSampleCPUFrequency(bool bActive, float SampleInterval);

		// Token: 0x06004E5F RID: 20063 RVA: 0x0006DB10 File Offset: 0x0006BD10
		public unsafe static void TimeEvent(string EventName, int Index = 0)
		{
			FString fstring = FString.AllocTemp(EventName);
			UKuroAnalytics.__TimeEvent_Internal(fstring, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06004E60 RID: 20064
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetTrackStatus(int Status = 1, int Index = 0);

		// Token: 0x06004E61 RID: 20065
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void OptOutTracking(int Index = 0);

		// Token: 0x06004E62 RID: 20066
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void OptInTracking(int Index = 0);

		// Token: 0x06004E63 RID: 20067
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Logout(int Index = 0);

		// Token: 0x06004E64 RID: 20068 RVA: 0x0006DB38 File Offset: 0x0006BD38
		public unsafe static void Login(string AccountId, int Index = 0)
		{
			FString fstring = FString.AllocTemp(AccountId);
			UKuroAnalytics.__Login_Internal(fstring, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06004E65 RID: 20069 RVA: 0x0006DB60 File Offset: 0x0006BD60
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

		// Token: 0x06004E66 RID: 20070 RVA: 0x0006DBEC File Offset: 0x0006BDEC
		public unsafe static bool InitializeDefaultInsWithURL_Appid(string ServerURL, string Appid, float ExitWaitTime, int MaxPendingLog, float SendHttpTimeout, bool bExitFlush, float CalibrateIntervalTime, bool bCalibratedStopTimer)
		{
			FString fstring = FString.AllocTemp(ServerURL);
			FString fstring2 = FString.AllocTemp(Appid);
			bool result = UKuroAnalytics.__InitializeDefaultInsWithURL_Appid_Internal(fstring, fstring2, ExitWaitTime, MaxPendingLog, SendHttpTimeout, bExitFlush, CalibrateIntervalTime, bCalibratedStopTimer);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06004E67 RID: 20071
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Initialize();

		// Token: 0x06004E68 RID: 20072 RVA: 0x0006DC2C File Offset: 0x0006BE2C
		public unsafe static void Identify(string DistinctId, int Index = 0)
		{
			FString fstring = FString.AllocTemp(DistinctId);
			UKuroAnalytics.__Identify_Internal(fstring, Index);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06004E69 RID: 20073
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasInstanceTimeCalibrated(int Index);

		// Token: 0x06004E6A RID: 20074
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasInstanceInitialized(int Index);

		// Token: 0x06004E6B RID: 20075
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasDefaultInstanceInitialized();

		// Token: 0x06004E6C RID: 20076 RVA: 0x0006DC51 File Offset: 0x0006BE51
		public static string GetSuperProperties(int Index = 0)
		{
			return FString.ToStringAndDeleteNativePtr(UKuroAnalytics.__GetSuperProperties_Internal(Index));
		}

		// Token: 0x06004E6D RID: 20077 RVA: 0x0006DC5E File Offset: 0x0006BE5E
		public static string GetServerUrl(int Index = 0)
		{
			return FString.ToStringAndDeleteNativePtr(UKuroAnalytics.__GetServerUrl_Internal(Index));
		}

		// Token: 0x06004E6E RID: 20078 RVA: 0x0006DC6B File Offset: 0x0006BE6B
		public static string GetPresetProperties(int Index = 0)
		{
			return FString.ToStringAndDeleteNativePtr(UKuroAnalytics.__GetPresetProperties_Internal(Index));
		}

		// Token: 0x06004E6F RID: 20079 RVA: 0x0006DC78 File Offset: 0x0006BE78
		public static string GetMachineID()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroAnalytics.__GetMachineID_Internal());
		}

		// Token: 0x06004E70 RID: 20080 RVA: 0x0006DC84 File Offset: 0x0006BE84
		public static string GetDistinctId(int Index = 0)
		{
			return FString.ToStringAndDeleteNativePtr(UKuroAnalytics.__GetDistinctId_Internal(Index));
		}

		// Token: 0x06004E71 RID: 20081 RVA: 0x0006DC91 File Offset: 0x0006BE91
		public static string GetDeviceId(int Index = 0)
		{
			return FString.ToStringAndDeleteNativePtr(UKuroAnalytics.__GetDeviceId_Internal(Index));
		}

		// Token: 0x06004E72 RID: 20082
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetCurrentCPUSampledMaxFrequency();

		// Token: 0x06004E73 RID: 20083
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetCurrentCPUSampledAvgFrequency();

		// Token: 0x06004E74 RID: 20084 RVA: 0x0006DC9E File Offset: 0x0006BE9E
		public static string GetAppId(int Index = 0)
		{
			return FString.ToStringAndDeleteNativePtr(UKuroAnalytics.__GetAppId_Internal(Index));
		}

		// Token: 0x06004E75 RID: 20085
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Flush(int Index = 0);

		// Token: 0x06004E76 RID: 20086
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void EnableTracking(bool bIsEnable, int Index = 0);

		// Token: 0x06004E77 RID: 20087 RVA: 0x0006DCAB File Offset: 0x0006BEAB
		public static void EnableThirdPartySharing([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> EventTypeList, int Index = 0)
		{
			UKuroAnalytics.__EnableThirdPartySharing_Internal((EventTypeList ?? new TArray<string>()).NativePtr, Index);
		}

		// Token: 0x06004E78 RID: 20088 RVA: 0x0006DCC4 File Offset: 0x0006BEC4
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

		// Token: 0x06004E79 RID: 20089 RVA: 0x0006DCF9 File Offset: 0x0006BEF9
		public static void EnableAutoTrackWithType([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> EventTypeList, int Index = 0)
		{
			UKuroAnalytics.__EnableAutoTrackWithType_Internal((EventTypeList ?? new TArray<string>()).NativePtr, Index);
		}

		// Token: 0x06004E7A RID: 20090
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void EnableAutoTrack(int Index = 0);

		// Token: 0x06004E7B RID: 20091
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DestroyInstance(int Index, bool Flush = true);

		// Token: 0x06004E7C RID: 20092
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DestroyAllInstance(bool Flush);

		// Token: 0x06004E7D RID: 20093 RVA: 0x0006DD11 File Offset: 0x0006BF11
		[NullableContext(2)]
		public static bool CreateSimpleInstance(in FKACreateInstanceParam Param)
		{
			return UKuroAnalytics.__CreateSimpleInstance_Internal((Param ?? new FKACreateInstanceParam()).NativePtr);
		}

		// Token: 0x06004E7E RID: 20094 RVA: 0x0006DD28 File Offset: 0x0006BF28
		[NullableContext(2)]
		public static void CalibrateTime(in FKAOnTimeCalibrated OnTimeCalibrated, int Index = 0)
		{
			FKAOnTimeCalibrated fkaonTimeCalibrated = OnTimeCalibrated;
			UKuroAnalytics.__CalibrateTime_Internal((fkaonTimeCalibrated != null) ? fkaonTimeCalibrated.NativePtr : ((IntPtr)0), Index);
		}

		// Token: 0x06004E7F RID: 20095
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UserUnset_Internal(in FString Property, int Index);

		// Token: 0x06004E80 RID: 20096
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UserUniqueAppend_Internal(in FString Properties, int Index);

		// Token: 0x06004E81 RID: 20097
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UserSetOnce_Internal(in FString Properties, int Index);

		// Token: 0x06004E82 RID: 20098
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UserSet_Internal(in FString Properties, int Index);

		// Token: 0x06004E83 RID: 20099
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UserAppend_Internal(in FString Properties, int Index);

		// Token: 0x06004E84 RID: 20100
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UserAdd_Internal(in FString Property, float Value, int Index);

		// Token: 0x06004E85 RID: 20101
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __TrackUpdate_Internal(in FString EventName, in FString Properties, in FString EventId, int Index);

		// Token: 0x06004E86 RID: 20102
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __TrackOverwrite_Internal(in FString EventName, in FString Properties, in FString EventId, int Index);

		// Token: 0x06004E87 RID: 20103
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __TrackFirstWithId_Internal(in FString EventName, in FString Properties, in FString FirstCheckId, int Index);

		// Token: 0x06004E88 RID: 20104
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __TrackFirst_Internal(in FString EventName, in FString Properties, int Index);

		// Token: 0x06004E89 RID: 20105
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Track_Internal(in FString EventName, in FString Properties, int Index);

		// Token: 0x06004E8A RID: 20106
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TimeEvent_Internal(in FString EventName, int Index);

		// Token: 0x06004E8B RID: 20107
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Login_Internal(in FString AccountId, int Index);

		// Token: 0x06004E8C RID: 20108
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitializeEncryptInstance_Internal(in FString appid, in FString serverurl, KAMode mode, bool bEnableLog, in FString timeZone, bool bEnableEncrypt, in FString EncryptPublicKey, int EncryptVersion, in FString SymmetricEncryption, in FString AsymmetricEncryption);

		// Token: 0x06004E8D RID: 20109
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __InitializeDefaultInsWithURL_Appid_Internal(in FString ServerURL, in FString Appid, float ExitWaitTime, int MaxPendingLog, float SendHttpTimeout, bool bExitFlush, float CalibrateIntervalTime, bool bCalibratedStopTimer);

		// Token: 0x06004E8E RID: 20110
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Identify_Internal(in FString DistinctId, int Index);

		// Token: 0x06004E8F RID: 20111
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetSuperProperties_Internal(int Index);

		// Token: 0x06004E90 RID: 20112
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetServerUrl_Internal(int Index);

		// Token: 0x06004E91 RID: 20113
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetPresetProperties_Internal(int Index);

		// Token: 0x06004E92 RID: 20114
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetMachineID_Internal();

		// Token: 0x06004E93 RID: 20115
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetDistinctId_Internal(int Index);

		// Token: 0x06004E94 RID: 20116
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetDeviceId_Internal(int Index);

		// Token: 0x06004E95 RID: 20117
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetAppId_Internal(int Index);

		// Token: 0x06004E96 RID: 20118
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EnableThirdPartySharing_Internal(IntPtr EventTypeList, int Index);

		// Token: 0x06004E97 RID: 20119
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EnableAutoTrackWithTypeAndProperties_Internal(IntPtr EventTypeList, in FString Properties, int Index);

		// Token: 0x06004E98 RID: 20120
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EnableAutoTrackWithType_Internal(IntPtr EventTypeList, int Index);

		// Token: 0x06004E99 RID: 20121
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CreateSimpleInstance_Internal(IntPtr Param);

		// Token: 0x06004E9A RID: 20122
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CalibrateTime_Internal(IntPtr OnTimeCalibrated, int Index);

		// Token: 0x06004E9B RID: 20123 RVA: 0x0006DD3F File Offset: 0x0006BF3F
		static UKuroAnalytics()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KRDataAnalyticsPlugin.KuroAnalytics");
		}

		// Token: 0x06004E9C RID: 20124 RVA: 0x0006DD4D File Offset: 0x0006BF4D
		protected UKuroAnalytics(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001F6C RID: 8044
		public new const string __ObjectPath = "/Script/KRDataAnalyticsPlugin.KuroAnalytics";

		// Token: 0x04001F6D RID: 8045
		private static IntPtr _ClassPtr;

		// Token: 0x04001F6E RID: 8046
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
