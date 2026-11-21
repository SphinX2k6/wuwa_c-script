using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007B1 RID: 1969
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/PerfSight.PerfSightHelper")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UPerfSightHelper : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600AAF2 RID: 43762 RVA: 0x000FC2B2 File Offset: 0x000FA4B2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPerfSightHelper._ClassPtr;
		}

		// Token: 0x0600AAF3 RID: 43763 RVA: 0x000FC2C0 File Offset: 0x000FA4C0
		public UPerfSightHelper() : this(BuiltinUtils.AllocNativeUObject(UPerfSightHelper.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600AAF4 RID: 43764 RVA: 0x000FC2E8 File Offset: 0x000FA4E8
		public UPerfSightHelper(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPerfSightHelper.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600AAF5 RID: 43765 RVA: 0x000FC31C File Offset: 0x000FA51C
		public unsafe static void UpdateNetLatency(int latency, string customInfo = "", string ipAddress = "")
		{
			FString fstring = FString.AllocTemp(customInfo);
			FString fstring2 = FString.AllocTemp(ipAddress);
			UPerfSightHelper.__UpdateNetLatency_Internal(latency, fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x0600AAF6 RID: 43766 RVA: 0x000FC354 File Offset: 0x000FA554
		public unsafe static void SetVersionIden(string versionName)
		{
			FString fstring = FString.AllocTemp(versionName);
			UPerfSightHelper.__SetVersionIden_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600AAF7 RID: 43767 RVA: 0x000FC378 File Offset: 0x000FA578
		public unsafe static void SetUserId(string UserId)
		{
			FString fstring = FString.AllocTemp(UserId);
			UPerfSightHelper.__SetUserId_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600AAF8 RID: 43768 RVA: 0x000FC39C File Offset: 0x000FA59C
		public unsafe static void SetUploadServerURL(string url)
		{
			FString fstring = FString.AllocTemp(url);
			UPerfSightHelper.__SetUploadServerURL_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600AAF9 RID: 43769
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetTargetFrameRate(int target);

		// Token: 0x0600AAFA RID: 43770
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetQuality(int quality);

		// Token: 0x0600AAFB RID: 43771
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetPostValueStrMaxLen(int length);

		// Token: 0x0600AAFC RID: 43772 RVA: 0x000FC3C0 File Offset: 0x000FA5C0
		public unsafe static void SetPCServerURL(string url)
		{
			FString fstring = FString.AllocTemp(url);
			UPerfSightHelper.__SetPCServerURL_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600AAFD RID: 43773 RVA: 0x000FC3E4 File Offset: 0x000FA5E4
		public unsafe static void SetPCAppVersion(string appVer)
		{
			FString fstring = FString.AllocTemp(appVer);
			UPerfSightHelper.__SetPCAppVersion_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600AAFE RID: 43774 RVA: 0x000FC408 File Offset: 0x000FA608
		public unsafe static void SetMatchId(string matchId)
		{
			FString fstring = FString.AllocTemp(matchId);
			UPerfSightHelper.__SetMatchId_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600AAFF RID: 43775
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetCustomizedDeviceClass(int deviceLevel);

		// Token: 0x0600AB00 RID: 43776 RVA: 0x000FC42C File Offset: 0x000FA62C
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

		// Token: 0x0600AB01 RID: 43777 RVA: 0x000FC474 File Offset: 0x000FA674
		public unsafe static void PostValueI3(string catgory, string key, int a, int b, int c)
		{
			FString fstring = FString.AllocTemp(catgory);
			FString fstring2 = FString.AllocTemp(key);
			UPerfSightHelper.__PostValueI3_Internal(fstring, fstring2, a, b, c);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x0600AB02 RID: 43778 RVA: 0x000FC4B0 File Offset: 0x000FA6B0
		public unsafe static void PostValueI2(string catgory, string key, int a, int b)
		{
			FString fstring = FString.AllocTemp(catgory);
			FString fstring2 = FString.AllocTemp(key);
			UPerfSightHelper.__PostValueI2_Internal(fstring, fstring2, a, b);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x0600AB03 RID: 43779 RVA: 0x000FC4E8 File Offset: 0x000FA6E8
		public unsafe static void PostValueI1(string catgory, string key, int a)
		{
			FString fstring = FString.AllocTemp(catgory);
			FString fstring2 = FString.AllocTemp(key);
			UPerfSightHelper.__PostValueI1_Internal(fstring, fstring2, a);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x0600AB04 RID: 43780 RVA: 0x000FC520 File Offset: 0x000FA720
		public unsafe static void PostValueF3(string catgory, string key, float a, float b, float c)
		{
			FString fstring = FString.AllocTemp(catgory);
			FString fstring2 = FString.AllocTemp(key);
			UPerfSightHelper.__PostValueF3_Internal(fstring, fstring2, a, b, c);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x0600AB05 RID: 43781 RVA: 0x000FC55C File Offset: 0x000FA75C
		public unsafe static void PostValueF2(string catgory, string key, float a, float b)
		{
			FString fstring = FString.AllocTemp(catgory);
			FString fstring2 = FString.AllocTemp(key);
			UPerfSightHelper.__PostValueF2_Internal(fstring, fstring2, a, b);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x0600AB06 RID: 43782 RVA: 0x000FC594 File Offset: 0x000FA794
		public unsafe static void PostValueF1(string catgory, string key, float a)
		{
			FString fstring = FString.AllocTemp(catgory);
			FString fstring2 = FString.AllocTemp(key);
			UPerfSightHelper.__PostValueF1_Internal(fstring, fstring2, a);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x0600AB07 RID: 43783 RVA: 0x000FC5CC File Offset: 0x000FA7CC
		public unsafe static void PostNetworkLatency(int latency, string customInfo = "", string ipAddress = "")
		{
			FString fstring = FString.AllocTemp(customInfo);
			FString fstring2 = FString.AllocTemp(ipAddress);
			UPerfSightHelper.__PostNetworkLatency_Internal(latency, fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x0600AB08 RID: 43784
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void PostFrame(float deltatime);

		// Token: 0x0600AB09 RID: 43785 RVA: 0x000FC604 File Offset: 0x000FA804
		public unsafe static void PostEvent(int key, string info = "NA")
		{
			FString fstring = FString.AllocTemp(info);
			UPerfSightHelper.__PostEvent_Internal(key, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600AB0A RID: 43786
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void MarkLevelLoadCompleted();

		// Token: 0x0600AB0B RID: 43787 RVA: 0x000FC62C File Offset: 0x000FA82C
		public unsafe static void MarkLevelLoad(string SceneName, int quality = 0)
		{
			FString fstring = FString.AllocTemp(SceneName);
			UPerfSightHelper.__MarkLevelLoad_Internal(fstring, quality);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600AB0C RID: 43788
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void MarkLevelFin();

		// Token: 0x0600AB0D RID: 43789 RVA: 0x000FC654 File Offset: 0x000FA854
		public unsafe static void InitContext(string AppID)
		{
			FString fstring = FString.AllocTemp(AppID);
			UPerfSightHelper.__InitContext_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600AB0E RID: 43790 RVA: 0x000FC678 File Offset: 0x000FA878
		public unsafe static int GetDeviceLevelByQcc(string configName, string gpuFamily)
		{
			FString fstring = FString.AllocTemp(configName);
			FString fstring2 = FString.AllocTemp(gpuFamily);
			int result = UPerfSightHelper.__GetDeviceLevelByQcc_Internal(fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0600AB0F RID: 43791
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void EndTupleWrap();

		// Token: 0x0600AB10 RID: 43792
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void EndTag();

		// Token: 0x0600AB11 RID: 43793 RVA: 0x000FC6B0 File Offset: 0x000FA8B0
		public unsafe static void EndExtTag(string TagName)
		{
			FString fstring = FString.AllocTemp(TagName);
			UPerfSightHelper.__EndExtTag_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600AB12 RID: 43794
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void EndExclude();

		// Token: 0x0600AB13 RID: 43795
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void EnableDebugMode();

		// Token: 0x0600AB14 RID: 43796 RVA: 0x000FC6D4 File Offset: 0x000FA8D4
		public unsafe static void BeginTupleWrap(string key)
		{
			FString fstring = FString.AllocTemp(key);
			UPerfSightHelper.__BeginTupleWrap_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600AB15 RID: 43797 RVA: 0x000FC6F8 File Offset: 0x000FA8F8
		public unsafe static void BeginTag(string TagName)
		{
			FString fstring = FString.AllocTemp(TagName);
			UPerfSightHelper.__BeginTag_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600AB16 RID: 43798 RVA: 0x000FC71C File Offset: 0x000FA91C
		public unsafe static void BeginExtTag(string TagName)
		{
			FString fstring = FString.AllocTemp(TagName);
			UPerfSightHelper.__BeginExtTag_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600AB17 RID: 43799
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void BeginExclude();

		// Token: 0x0600AB18 RID: 43800
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateNetLatency_Internal(int latency, in FString customInfo, in FString ipAddress);

		// Token: 0x0600AB19 RID: 43801
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVersionIden_Internal(in FString versionName);

		// Token: 0x0600AB1A RID: 43802
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUserId_Internal(in FString UserId);

		// Token: 0x0600AB1B RID: 43803
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUploadServerURL_Internal(in FString url);

		// Token: 0x0600AB1C RID: 43804
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPCServerURL_Internal(in FString url);

		// Token: 0x0600AB1D RID: 43805
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPCAppVersion_Internal(in FString appVer);

		// Token: 0x0600AB1E RID: 43806
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMatchId_Internal(in FString matchId);

		// Token: 0x0600AB1F RID: 43807
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostValueS_Internal(in FString catgory, in FString key, in FString value);

		// Token: 0x0600AB20 RID: 43808
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostValueI3_Internal(in FString catgory, in FString key, int a, int b, int c);

		// Token: 0x0600AB21 RID: 43809
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostValueI2_Internal(in FString catgory, in FString key, int a, int b);

		// Token: 0x0600AB22 RID: 43810
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostValueI1_Internal(in FString catgory, in FString key, int a);

		// Token: 0x0600AB23 RID: 43811
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostValueF3_Internal(in FString catgory, in FString key, float a, float b, float c);

		// Token: 0x0600AB24 RID: 43812
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostValueF2_Internal(in FString catgory, in FString key, float a, float b);

		// Token: 0x0600AB25 RID: 43813
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostValueF1_Internal(in FString catgory, in FString key, float a);

		// Token: 0x0600AB26 RID: 43814
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostNetworkLatency_Internal(int latency, in FString customInfo, in FString ipAddress);

		// Token: 0x0600AB27 RID: 43815
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostEvent_Internal(int key, in FString info);

		// Token: 0x0600AB28 RID: 43816
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MarkLevelLoad_Internal(in FString SceneName, int quality);

		// Token: 0x0600AB29 RID: 43817
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitContext_Internal(in FString AppID);

		// Token: 0x0600AB2A RID: 43818
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetDeviceLevelByQcc_Internal(in FString configName, in FString gpuFamily);

		// Token: 0x0600AB2B RID: 43819
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EndExtTag_Internal(in FString TagName);

		// Token: 0x0600AB2C RID: 43820
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BeginTupleWrap_Internal(in FString key);

		// Token: 0x0600AB2D RID: 43821
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BeginTag_Internal(in FString TagName);

		// Token: 0x0600AB2E RID: 43822
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BeginExtTag_Internal(in FString TagName);

		// Token: 0x0600AB2F RID: 43823 RVA: 0x000FC740 File Offset: 0x000FA940
		static UPerfSightHelper()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/PerfSight.PerfSightHelper");
		}

		// Token: 0x0600AB30 RID: 43824 RVA: 0x000FC74E File Offset: 0x000FA94E
		protected UPerfSightHelper(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004930 RID: 18736
		public new const string __ObjectPath = "/Script/PerfSight.PerfSightHelper";

		// Token: 0x04004931 RID: 18737
		private static IntPtr _ClassPtr;

		// Token: 0x04004932 RID: 18738
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
