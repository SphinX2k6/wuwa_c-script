using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002637 RID: 9783
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/PerfSight.PerfSightHelper")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UPerfSightHelper : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024600 RID: 148992 RVA: 0x0035DBBE File Offset: 0x0035BDBE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPerfSightHelper._ClassPtr;
		}

		// Token: 0x06024601 RID: 148993 RVA: 0x0035DBCC File Offset: 0x0035BDCC
		public UPerfSightHelper() : this(BuiltinUtils.AllocNativeUObject(UPerfSightHelper.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024602 RID: 148994 RVA: 0x0035DBF4 File Offset: 0x0035BDF4
		public UPerfSightHelper(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPerfSightHelper.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06024603 RID: 148995 RVA: 0x0035DC28 File Offset: 0x0035BE28
		public unsafe static void UpdateNetLatency(int latency, string customInfo = "", string ipAddress = "")
		{
			FString fstring = FString.AllocTemp(customInfo);
			FString fstring2 = FString.AllocTemp(ipAddress);
			UPerfSightHelper.__UpdateNetLatency_Internal(latency, fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06024604 RID: 148996 RVA: 0x0035DC60 File Offset: 0x0035BE60
		public unsafe static void SetVersionIden(string versionName)
		{
			FString fstring = FString.AllocTemp(versionName);
			UPerfSightHelper.__SetVersionIden_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06024605 RID: 148997 RVA: 0x0035DC84 File Offset: 0x0035BE84
		public unsafe static void SetUserId(string UserId)
		{
			FString fstring = FString.AllocTemp(UserId);
			UPerfSightHelper.__SetUserId_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06024606 RID: 148998 RVA: 0x0035DCA8 File Offset: 0x0035BEA8
		public unsafe static void SetUploadServerURL(string url)
		{
			FString fstring = FString.AllocTemp(url);
			UPerfSightHelper.__SetUploadServerURL_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06024607 RID: 148999
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetTargetFrameRate(int target);

		// Token: 0x06024608 RID: 149000
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetQuality(int quality);

		// Token: 0x06024609 RID: 149001
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetPostValueStrMaxLen(int length);

		// Token: 0x0602460A RID: 149002 RVA: 0x0035DCCC File Offset: 0x0035BECC
		public unsafe static void SetPCServerURL(string url)
		{
			FString fstring = FString.AllocTemp(url);
			UPerfSightHelper.__SetPCServerURL_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0602460B RID: 149003 RVA: 0x0035DCF0 File Offset: 0x0035BEF0
		public unsafe static void SetPCAppVersion(string appVer)
		{
			FString fstring = FString.AllocTemp(appVer);
			UPerfSightHelper.__SetPCAppVersion_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0602460C RID: 149004 RVA: 0x0035DD14 File Offset: 0x0035BF14
		public unsafe static void SetMatchId(string matchId)
		{
			FString fstring = FString.AllocTemp(matchId);
			UPerfSightHelper.__SetMatchId_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0602460D RID: 149005
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetCustomizedDeviceClass(int deviceLevel);

		// Token: 0x0602460E RID: 149006 RVA: 0x0035DD38 File Offset: 0x0035BF38
		public unsafe static void PostValueS(string catgory, string key, string value)
		{
			FString fstring = FString.AllocTemp(catgory);
			FString fstring2 = FString.AllocTemp(key);
			FString fstring3 = FString.AllocTemp(value);
			UPerfSightHelper.__PostValueS_Internal(fstring, fstring2, fstring3);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			FString.NativeDestruct(&fstring3, 1);
		}

		// Token: 0x0602460F RID: 149007 RVA: 0x0035DD80 File Offset: 0x0035BF80
		public unsafe static void PostValueI3(string catgory, string key, int a, int b, int c)
		{
			FString fstring = FString.AllocTemp(catgory);
			FString fstring2 = FString.AllocTemp(key);
			UPerfSightHelper.__PostValueI3_Internal(fstring, fstring2, a, b, c);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06024610 RID: 149008 RVA: 0x0035DDBC File Offset: 0x0035BFBC
		public unsafe static void PostValueI2(string catgory, string key, int a, int b)
		{
			FString fstring = FString.AllocTemp(catgory);
			FString fstring2 = FString.AllocTemp(key);
			UPerfSightHelper.__PostValueI2_Internal(fstring, fstring2, a, b);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06024611 RID: 149009 RVA: 0x0035DDF4 File Offset: 0x0035BFF4
		public unsafe static void PostValueI1(string catgory, string key, int a)
		{
			FString fstring = FString.AllocTemp(catgory);
			FString fstring2 = FString.AllocTemp(key);
			UPerfSightHelper.__PostValueI1_Internal(fstring, fstring2, a);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06024612 RID: 149010 RVA: 0x0035DE2C File Offset: 0x0035C02C
		public unsafe static void PostValueF3(string catgory, string key, float a, float b, float c)
		{
			FString fstring = FString.AllocTemp(catgory);
			FString fstring2 = FString.AllocTemp(key);
			UPerfSightHelper.__PostValueF3_Internal(fstring, fstring2, a, b, c);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06024613 RID: 149011 RVA: 0x0035DE68 File Offset: 0x0035C068
		public unsafe static void PostValueF2(string catgory, string key, float a, float b)
		{
			FString fstring = FString.AllocTemp(catgory);
			FString fstring2 = FString.AllocTemp(key);
			UPerfSightHelper.__PostValueF2_Internal(fstring, fstring2, a, b);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06024614 RID: 149012 RVA: 0x0035DEA0 File Offset: 0x0035C0A0
		public unsafe static void PostValueF1(string catgory, string key, float a)
		{
			FString fstring = FString.AllocTemp(catgory);
			FString fstring2 = FString.AllocTemp(key);
			UPerfSightHelper.__PostValueF1_Internal(fstring, fstring2, a);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06024615 RID: 149013 RVA: 0x0035DED8 File Offset: 0x0035C0D8
		public unsafe static void PostNetworkLatency(int latency, string customInfo = "", string ipAddress = "")
		{
			FString fstring = FString.AllocTemp(customInfo);
			FString fstring2 = FString.AllocTemp(ipAddress);
			UPerfSightHelper.__PostNetworkLatency_Internal(latency, fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06024616 RID: 149014
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void PostFrame(float deltatime);

		// Token: 0x06024617 RID: 149015 RVA: 0x0035DF10 File Offset: 0x0035C110
		public unsafe static void PostEvent(int key, string info = "NA")
		{
			FString fstring = FString.AllocTemp(info);
			UPerfSightHelper.__PostEvent_Internal(key, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06024618 RID: 149016
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void MarkLevelLoadCompleted();

		// Token: 0x06024619 RID: 149017 RVA: 0x0035DF38 File Offset: 0x0035C138
		public unsafe static void MarkLevelLoad(string SceneName, int quality = 0)
		{
			FString fstring = FString.AllocTemp(SceneName);
			UPerfSightHelper.__MarkLevelLoad_Internal(fstring, quality);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0602461A RID: 149018
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void MarkLevelFin();

		// Token: 0x0602461B RID: 149019 RVA: 0x0035DF60 File Offset: 0x0035C160
		public unsafe static void InitContext(string AppID)
		{
			FString fstring = FString.AllocTemp(AppID);
			UPerfSightHelper.__InitContext_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0602461C RID: 149020 RVA: 0x0035DF84 File Offset: 0x0035C184
		public unsafe static int GetDeviceLevelByQcc(string configName, string gpuFamily)
		{
			FString fstring = FString.AllocTemp(configName);
			FString fstring2 = FString.AllocTemp(gpuFamily);
			int result = UPerfSightHelper.__GetDeviceLevelByQcc_Internal(fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0602461D RID: 149021
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void EndTupleWrap();

		// Token: 0x0602461E RID: 149022
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void EndTag();

		// Token: 0x0602461F RID: 149023 RVA: 0x0035DFBC File Offset: 0x0035C1BC
		public unsafe static void EndExtTag(string TagName)
		{
			FString fstring = FString.AllocTemp(TagName);
			UPerfSightHelper.__EndExtTag_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06024620 RID: 149024
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void EndExclude();

		// Token: 0x06024621 RID: 149025
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void EnableDebugMode();

		// Token: 0x06024622 RID: 149026 RVA: 0x0035DFE0 File Offset: 0x0035C1E0
		public unsafe static void BeginTupleWrap(string key)
		{
			FString fstring = FString.AllocTemp(key);
			UPerfSightHelper.__BeginTupleWrap_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06024623 RID: 149027 RVA: 0x0035E004 File Offset: 0x0035C204
		public unsafe static void BeginTag(string TagName)
		{
			FString fstring = FString.AllocTemp(TagName);
			UPerfSightHelper.__BeginTag_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06024624 RID: 149028 RVA: 0x0035E028 File Offset: 0x0035C228
		public unsafe static void BeginExtTag(string TagName)
		{
			FString fstring = FString.AllocTemp(TagName);
			UPerfSightHelper.__BeginExtTag_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06024625 RID: 149029
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void BeginExclude();

		// Token: 0x06024626 RID: 149030
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateNetLatency_Internal(int latency, in FString customInfo, in FString ipAddress);

		// Token: 0x06024627 RID: 149031
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVersionIden_Internal(in FString versionName);

		// Token: 0x06024628 RID: 149032
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUserId_Internal(in FString UserId);

		// Token: 0x06024629 RID: 149033
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUploadServerURL_Internal(in FString url);

		// Token: 0x0602462A RID: 149034
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPCServerURL_Internal(in FString url);

		// Token: 0x0602462B RID: 149035
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPCAppVersion_Internal(in FString appVer);

		// Token: 0x0602462C RID: 149036
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMatchId_Internal(in FString matchId);

		// Token: 0x0602462D RID: 149037
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostValueS_Internal(in FString catgory, in FString key, in FString value);

		// Token: 0x0602462E RID: 149038
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostValueI3_Internal(in FString catgory, in FString key, int a, int b, int c);

		// Token: 0x0602462F RID: 149039
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostValueI2_Internal(in FString catgory, in FString key, int a, int b);

		// Token: 0x06024630 RID: 149040
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostValueI1_Internal(in FString catgory, in FString key, int a);

		// Token: 0x06024631 RID: 149041
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostValueF3_Internal(in FString catgory, in FString key, float a, float b, float c);

		// Token: 0x06024632 RID: 149042
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostValueF2_Internal(in FString catgory, in FString key, float a, float b);

		// Token: 0x06024633 RID: 149043
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostValueF1_Internal(in FString catgory, in FString key, float a);

		// Token: 0x06024634 RID: 149044
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostNetworkLatency_Internal(int latency, in FString customInfo, in FString ipAddress);

		// Token: 0x06024635 RID: 149045
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostEvent_Internal(int key, in FString info);

		// Token: 0x06024636 RID: 149046
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MarkLevelLoad_Internal(in FString SceneName, int quality);

		// Token: 0x06024637 RID: 149047
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitContext_Internal(in FString AppID);

		// Token: 0x06024638 RID: 149048
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetDeviceLevelByQcc_Internal(in FString configName, in FString gpuFamily);

		// Token: 0x06024639 RID: 149049
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EndExtTag_Internal(in FString TagName);

		// Token: 0x0602463A RID: 149050
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BeginTupleWrap_Internal(in FString key);

		// Token: 0x0602463B RID: 149051
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BeginTag_Internal(in FString TagName);

		// Token: 0x0602463C RID: 149052
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BeginExtTag_Internal(in FString TagName);

		// Token: 0x0602463D RID: 149053 RVA: 0x0035E04C File Offset: 0x0035C24C
		static UPerfSightHelper()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/PerfSight.PerfSightHelper");
		}

		// Token: 0x0602463E RID: 149054 RVA: 0x0035E05A File Offset: 0x0035C25A
		protected UPerfSightHelper(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401384B RID: 79947
		public new const string __ObjectPath = "/Script/PerfSight.PerfSightHelper";

		// Token: 0x0401384C RID: 79948
		private static IntPtr _ClassPtr;

		// Token: 0x0401384D RID: 79949
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
