using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004CA RID: 1226
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroGISystem")]
	[UnrealStructLayout(1504, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1504)]
	public class UKuroGISystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600712D RID: 28973 RVA: 0x000A6EBA File Offset: 0x000A50BA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroGISystem._ClassPtr;
		}

		// Token: 0x0600712E RID: 28974 RVA: 0x000A6EC8 File Offset: 0x000A50C8
		public UKuroGISystem() : this(BuiltinUtils.AllocNativeUObject(UKuroGISystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600712F RID: 28975 RVA: 0x000A6EF0 File Offset: 0x000A50F0
		[NullableContext(1)]
		public UKuroGISystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroGISystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001632 RID: 5682
		// (get) Token: 0x06007130 RID: 28976 RVA: 0x000A6F24 File Offset: 0x000A5124
		// (set) Token: 0x06007131 RID: 28977 RVA: 0x000A6F5D File Offset: 0x000A515D
		[Nullable(1)]
		public TMap<FName, UObject> WeatherData
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UObject> result;
				if ((result = this._WeatherData) == null)
				{
					result = (this._WeatherData = new TMap<FName, UObject>(base.NativePtr + (IntPtr)UKuroGISystem.__PropertyOffset_WeatherData, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.WeatherData.CopyAssign(value);
			}
		}

		// Token: 0x06007132 RID: 28978 RVA: 0x000A6F6C File Offset: 0x000A516C
		[NullableContext(1)]
		public unsafe bool Start3DUISceneRendering(string InLevelName)
		{
			FString fstring = FString.AllocTemp(InLevelName);
			bool result = UKuroGISystem.__Start3DUISceneRendering_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06007133 RID: 28979 RVA: 0x000A6F96 File Offset: 0x000A5196
		public static void SetKuroSeqPost(UWorld InWorld, UKuroSeqPostParameter SeqPostDA)
		{
			UKuroGISystem.__SetKuroSeqPost_Internal((InWorld != null) ? InWorld.NativePtr : IntPtr.Zero, (SeqPostDA != null) ? SeqPostDA.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06007134 RID: 28980 RVA: 0x000A6FBD File Offset: 0x000A51BD
		public static void SetKuroScreenFilterInterpolation(UWorld InWorld, int ScreenFilterIndex, float X, float Y, float Intensity)
		{
			UKuroGISystem.__SetKuroScreenFilterInterpolation_Internal((InWorld != null) ? InWorld.NativePtr : IntPtr.Zero, ScreenFilterIndex, X, Y, Intensity);
		}

		// Token: 0x06007135 RID: 28981 RVA: 0x000A6FDC File Offset: 0x000A51DC
		public static void SetKuroAdvancedModeScreenFilter(UWorld InWorld, int ScreenFilterIndex, float X, float Y, float Intensity, float KuroSharpenIntensity, float AdModeBrightness, float AdModeScreenFilterContrast, float AdModeScreenFilteColorTemperature, float AdModeScreenFilterSaturation, float AdModeBloom, float AdModeNoiseIntensity, float AdModeShadowIntensity, float AdModeGamma, float AdModeHalation)
		{
			UKuroGISystem.__SetKuroAdvancedModeScreenFilter_Internal((InWorld != null) ? InWorld.NativePtr : IntPtr.Zero, ScreenFilterIndex, X, Y, Intensity, KuroSharpenIntensity, AdModeBrightness, AdModeScreenFilterContrast, AdModeScreenFilteColorTemperature, AdModeScreenFilterSaturation, AdModeBloom, AdModeNoiseIntensity, AdModeShadowIntensity, AdModeGamma, AdModeHalation);
		}

		// Token: 0x06007136 RID: 28982 RVA: 0x000A7017 File Offset: 0x000A5217
		public bool IsUISceneRendering()
		{
			return UKuroGISystem.__IsUISceneRendering_Internal(base.NativePtr);
		}

		// Token: 0x06007137 RID: 28983 RVA: 0x000A7024 File Offset: 0x000A5224
		public bool IsLastTickGIActor(AKuroGlobalGI Actor)
		{
			return UKuroGISystem.__IsLastTickGIActor_Internal(base.NativePtr, (Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06007138 RID: 28984 RVA: 0x000A7041 File Offset: 0x000A5241
		public EKuroUI3DState GetUISceneRenderingState()
		{
			return UKuroGISystem.__GetUISceneRenderingState_Internal(base.NativePtr);
		}

		// Token: 0x06007139 RID: 28985 RVA: 0x000A704E File Offset: 0x000A524E
		public AKuroGlobalGI GetKuroGlobalGIActor()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AKuroGlobalGI>(UKuroGISystem.__GetKuroGlobalGIActor_Internal(base.NativePtr));
		}

		// Token: 0x0600713A RID: 28986 RVA: 0x000A7060 File Offset: 0x000A5260
		public static UKuroGISystem GetKuroGISystem(UWorld InWorld)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroGISystem>(UKuroGISystem.__GetKuroGISystem_Internal((InWorld != null) ? InWorld.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0600713B RID: 28987 RVA: 0x000A707C File Offset: 0x000A527C
		public bool End3DUISceneRendering()
		{
			return UKuroGISystem.__End3DUISceneRendering_Internal(base.NativePtr);
		}

		// Token: 0x0600713C RID: 28988 RVA: 0x000A7089 File Offset: 0x000A5289
		public void DoTransition(FName CollectionName, int TransitionState, float TransitionTime)
		{
			UKuroGISystem.__DoTransition_Internal(base.NativePtr, CollectionName, TransitionState, TransitionTime);
		}

		// Token: 0x0600713D RID: 28989
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool CheckWindowsSupportHDR();

		// Token: 0x0600713E RID: 28990
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool CheckWindowsEnableHDR();

		// Token: 0x0600713F RID: 28991 RVA: 0x000A7099 File Offset: 0x000A5299
		public static void ApplyHDRMetaData(UWorld InWorld, float UINit, float GlobalNit)
		{
			UKuroGISystem.__ApplyHDRMetaData_Internal((InWorld != null) ? InWorld.NativePtr : IntPtr.Zero, UINit, GlobalNit);
		}

		// Token: 0x06007140 RID: 28992 RVA: 0x000A70B2 File Offset: 0x000A52B2
		public static void ApplyEyeProtectionTexture(UWorld InWorld, float TextureIntensityID, float EnvironmentID)
		{
			UKuroGISystem.__ApplyEyeProtectionTexture_Internal((InWorld != null) ? InWorld.NativePtr : IntPtr.Zero, TextureIntensityID, EnvironmentID);
		}

		// Token: 0x06007141 RID: 28993 RVA: 0x000A70CB File Offset: 0x000A52CB
		public static void ApplyEyeProtectionTemperature(UWorld InWorld, float Temperature, float EnvironmentID)
		{
			UKuroGISystem.__ApplyEyeProtectionTemperature_Internal((InWorld != null) ? InWorld.NativePtr : IntPtr.Zero, Temperature, EnvironmentID);
		}

		// Token: 0x06007142 RID: 28994 RVA: 0x000A70E4 File Offset: 0x000A52E4
		public static void ApplyEyeProtectionStrength(UWorld InWorld, float EyeProtectIntensity, float EnvironmentID)
		{
			UKuroGISystem.__ApplyEyeProtectionStrength_Internal((InWorld != null) ? InWorld.NativePtr : IntPtr.Zero, EyeProtectIntensity, EnvironmentID);
		}

		// Token: 0x06007143 RID: 28995 RVA: 0x000A70FD File Offset: 0x000A52FD
		public static void ApplyEyeProtectionEnvironment(UWorld InWorld, float EnvironmentID)
		{
			UKuroGISystem.__ApplyEyeProtectionEnvironment_Internal((InWorld != null) ? InWorld.NativePtr : IntPtr.Zero, EnvironmentID);
		}

		// Token: 0x06007144 RID: 28996 RVA: 0x000A7115 File Offset: 0x000A5315
		public static void ApplyEyeProtectionBrightness(UWorld InWorld, float Brightness, float EnvironmentID)
		{
			UKuroGISystem.__ApplyEyeProtectionBrightness_Internal((InWorld != null) ? InWorld.NativePtr : IntPtr.Zero, Brightness, EnvironmentID);
		}

		// Token: 0x06007145 RID: 28997
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Start3DUISceneRendering_Internal(IntPtr @this, in FString InLevelName);

		// Token: 0x06007146 RID: 28998
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroSeqPost_Internal(IntPtr InWorld, IntPtr SeqPostDA);

		// Token: 0x06007147 RID: 28999
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroScreenFilterInterpolation_Internal(IntPtr InWorld, int ScreenFilterIndex, float X, float Y, float Intensity);

		// Token: 0x06007148 RID: 29000
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroAdvancedModeScreenFilter_Internal(IntPtr InWorld, int ScreenFilterIndex, float X, float Y, float Intensity, float KuroSharpenIntensity, float AdModeBrightness, float AdModeScreenFilterContrast, float AdModeScreenFilteColorTemperature, float AdModeScreenFilterSaturation, float AdModeBloom, float AdModeNoiseIntensity, float AdModeShadowIntensity, float AdModeGamma, float AdModeHalation);

		// Token: 0x06007149 RID: 29001
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsUISceneRendering_Internal(IntPtr @this);

		// Token: 0x0600714A RID: 29002
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsLastTickGIActor_Internal(IntPtr @this, IntPtr Actor);

		// Token: 0x0600714B RID: 29003
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EKuroUI3DState __GetUISceneRenderingState_Internal(IntPtr @this);

		// Token: 0x0600714C RID: 29004
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetKuroGlobalGIActor_Internal(IntPtr @this);

		// Token: 0x0600714D RID: 29005
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetKuroGISystem_Internal(IntPtr InWorld);

		// Token: 0x0600714E RID: 29006
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __End3DUISceneRendering_Internal(IntPtr @this);

		// Token: 0x0600714F RID: 29007
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DoTransition_Internal(IntPtr @this, FName CollectionName, int TransitionState, float TransitionTime);

		// Token: 0x06007150 RID: 29008
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyHDRMetaData_Internal(IntPtr InWorld, float UINit, float GlobalNit);

		// Token: 0x06007151 RID: 29009
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyEyeProtectionTexture_Internal(IntPtr InWorld, float TextureIntensityID, float EnvironmentID);

		// Token: 0x06007152 RID: 29010
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyEyeProtectionTemperature_Internal(IntPtr InWorld, float Temperature, float EnvironmentID);

		// Token: 0x06007153 RID: 29011
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyEyeProtectionStrength_Internal(IntPtr InWorld, float EyeProtectIntensity, float EnvironmentID);

		// Token: 0x06007154 RID: 29012
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyEyeProtectionEnvironment_Internal(IntPtr InWorld, float EnvironmentID);

		// Token: 0x06007155 RID: 29013
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyEyeProtectionBrightness_Internal(IntPtr InWorld, float Brightness, float EnvironmentID);

		// Token: 0x06007156 RID: 29014 RVA: 0x000A712E File Offset: 0x000A532E
		static UKuroGISystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroGISystem");
		}

		// Token: 0x06007157 RID: 29015 RVA: 0x000A713C File Offset: 0x000A533C
		protected UKuroGISystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040030E5 RID: 12517
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroGISystem";

		// Token: 0x040030E6 RID: 12518
		private static IntPtr _ClassPtr;

		// Token: 0x040030E7 RID: 12519
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040030E8 RID: 12520
		internal static int __PropertyOffset_WeatherData;

		// Token: 0x040030E9 RID: 12521
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UObject> _WeatherData;
	}
}
