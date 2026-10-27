using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B0C RID: 6924
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroGISystem")]
	[UnrealStructLayout(1504, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1504)]
	public class UKuroGISystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019F21 RID: 106273 RVA: 0x00265463 File Offset: 0x00263663
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroGISystem._ClassPtr;
		}

		// Token: 0x06019F22 RID: 106274 RVA: 0x00265470 File Offset: 0x00263670
		public UKuroGISystem() : this(BuiltinUtils.AllocNativeUObject(UKuroGISystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019F23 RID: 106275 RVA: 0x00265498 File Offset: 0x00263698
		[NullableContext(1)]
		public UKuroGISystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroGISystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700680A RID: 26634
		// (get) Token: 0x06019F24 RID: 106276 RVA: 0x002654CB File Offset: 0x002636CB
		// (set) Token: 0x06019F25 RID: 106277 RVA: 0x002654DF File Offset: 0x002636DF
		public unsafe UKuroScreenFilterDataAsset KuroScreenFilterDataAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroScreenFilterDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroGISystem.__PropertyOffset_KuroScreenFilterDataAsset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroGISystem.__PropertyOffset_KuroScreenFilterDataAsset, value);
			}
		}

		// Token: 0x1700680B RID: 26635
		// (get) Token: 0x06019F26 RID: 106278 RVA: 0x002654F4 File Offset: 0x002636F4
		// (set) Token: 0x06019F27 RID: 106279 RVA: 0x00265508 File Offset: 0x00263708
		public unsafe UKuroScreenBlueLightFilterDataAsset KuroScreenBlueLightFilterDataAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroScreenBlueLightFilterDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroGISystem.__PropertyOffset_KuroScreenBlueLightFilterDataAsset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroGISystem.__PropertyOffset_KuroScreenBlueLightFilterDataAsset, value);
			}
		}

		// Token: 0x1700680C RID: 26636
		// (get) Token: 0x06019F28 RID: 106280 RVA: 0x00265520 File Offset: 0x00263720
		// (set) Token: 0x06019F29 RID: 106281 RVA: 0x00265559 File Offset: 0x00263759
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

		// Token: 0x1700680D RID: 26637
		// (get) Token: 0x06019F2A RID: 106282 RVA: 0x00265567 File Offset: 0x00263767
		// (set) Token: 0x06019F2B RID: 106283 RVA: 0x0026557B File Offset: 0x0026377B
		public unsafe UKuroScreenBlueLightFilterDataAsset FilterSystemData
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroScreenBlueLightFilterDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroGISystem.__PropertyOffset_FilterSystemData);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroGISystem.__PropertyOffset_FilterSystemData, value);
			}
		}

		// Token: 0x1700680E RID: 26638
		// (get) Token: 0x06019F2C RID: 106284 RVA: 0x00265590 File Offset: 0x00263790
		// (set) Token: 0x06019F2D RID: 106285 RVA: 0x002655A4 File Offset: 0x002637A4
		public unsafe UKuroWorldPartitionPreviewManager WorldPartitionPreviewManager
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroWorldPartitionPreviewManager>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroGISystem.__PropertyOffset_WorldPartitionPreviewManager);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroGISystem.__PropertyOffset_WorldPartitionPreviewManager, value);
			}
		}

		// Token: 0x1700680F RID: 26639
		// (get) Token: 0x06019F2E RID: 106286 RVA: 0x002655BC File Offset: 0x002637BC
		// (set) Token: 0x06019F2F RID: 106287 RVA: 0x002655F5 File Offset: 0x002637F5
		[Nullable(1)]
		public FKuroPostprocessMaterialManager PostprocessMaterialManager
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroPostprocessMaterialManager result;
				if ((result = this._PostprocessMaterialManager) == null)
				{
					result = (this._PostprocessMaterialManager = new FKuroPostprocessMaterialManager(base.NativePtr + (IntPtr)UKuroGISystem.__PropertyOffset_PostprocessMaterialManager, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroPostprocessMaterialManager.StaticStruct(), base.NativePtr + (IntPtr)UKuroGISystem.__PropertyOffset_PostprocessMaterialManager, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006810 RID: 26640
		// (get) Token: 0x06019F30 RID: 106288 RVA: 0x00265618 File Offset: 0x00263818
		// (set) Token: 0x06019F31 RID: 106289 RVA: 0x00265651 File Offset: 0x00263851
		[Nullable(1)]
		public FKuroSceneEffectActorManager SceneEffectActorManager
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroSceneEffectActorManager result;
				if ((result = this._SceneEffectActorManager) == null)
				{
					result = (this._SceneEffectActorManager = new FKuroSceneEffectActorManager(base.NativePtr + (IntPtr)UKuroGISystem.__PropertyOffset_SceneEffectActorManager, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroSceneEffectActorManager.StaticStruct(), base.NativePtr + (IntPtr)UKuroGISystem.__PropertyOffset_SceneEffectActorManager, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006811 RID: 26641
		// (get) Token: 0x06019F32 RID: 106290 RVA: 0x00265672 File Offset: 0x00263872
		// (set) Token: 0x06019F33 RID: 106291 RVA: 0x00265686 File Offset: 0x00263886
		public unsafe UKuroRenderingPropertyDebugger PropertyDebugger
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroRenderingPropertyDebugger>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroGISystem.__PropertyOffset_PropertyDebugger);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroGISystem.__PropertyOffset_PropertyDebugger, value);
			}
		}

		// Token: 0x17006812 RID: 26642
		// (get) Token: 0x06019F34 RID: 106292 RVA: 0x0026569B File Offset: 0x0026389B
		// (set) Token: 0x06019F35 RID: 106293 RVA: 0x002656AF File Offset: 0x002638AF
		public unsafe UKuroRainManager RainManager
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroRainManager>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroGISystem.__PropertyOffset_RainManager);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroGISystem.__PropertyOffset_RainManager, value);
			}
		}

		// Token: 0x06019F36 RID: 106294 RVA: 0x002656C4 File Offset: 0x002638C4
		[NullableContext(1)]
		public unsafe bool Start3DUISceneRendering(string InLevelName)
		{
			FString fstring = FString.AllocTemp(InLevelName);
			bool result = UKuroGISystem.__Start3DUISceneRendering_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06019F37 RID: 106295 RVA: 0x002656EE File Offset: 0x002638EE
		public static void SetKuroScreenFilterInterpolation(UWorld InWorld, int ScreenFilterIndex, float X, float Y, float Intensity)
		{
			UKuroGISystem.__SetKuroScreenFilterInterpolation_Internal((InWorld != null) ? InWorld.NativePtr : IntPtr.Zero, ScreenFilterIndex, X, Y, Intensity);
		}

		// Token: 0x06019F38 RID: 106296 RVA: 0x0026570C File Offset: 0x0026390C
		public static void SetKuroAdvancedModeScreenFilter(UWorld InWorld, int ScreenFilterIndex, float X, float Y, float Intensity, float KuroSharpenIntensity, float AdModeBrightness, float AdModeScreenFilterContrast, float AdModeScreenFilteColorTemperature, float AdModeScreenFilterSaturation, float AdModeBloom, float AdModeNoiseIntensity, float AdModeShadowIntensity, float AdModeGamma, float AdModeHalation)
		{
			UKuroGISystem.__SetKuroAdvancedModeScreenFilter_Internal((InWorld != null) ? InWorld.NativePtr : IntPtr.Zero, ScreenFilterIndex, X, Y, Intensity, KuroSharpenIntensity, AdModeBrightness, AdModeScreenFilterContrast, AdModeScreenFilteColorTemperature, AdModeScreenFilterSaturation, AdModeBloom, AdModeNoiseIntensity, AdModeShadowIntensity, AdModeGamma, AdModeHalation);
		}

		// Token: 0x06019F39 RID: 106297 RVA: 0x00265747 File Offset: 0x00263947
		public bool IsUISceneRendering()
		{
			return UKuroGISystem.__IsUISceneRendering_Internal(base.NativePtr);
		}

		// Token: 0x06019F3A RID: 106298 RVA: 0x00265754 File Offset: 0x00263954
		public bool IsLastTickGIActor(AKuroGlobalGI Actor)
		{
			return UKuroGISystem.__IsLastTickGIActor_Internal(base.NativePtr, (Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06019F3B RID: 106299 RVA: 0x00265771 File Offset: 0x00263971
		public EKuroUI3DState GetUISceneRenderingState()
		{
			return UKuroGISystem.__GetUISceneRenderingState_Internal(base.NativePtr);
		}

		// Token: 0x06019F3C RID: 106300 RVA: 0x0026577E File Offset: 0x0026397E
		public AKuroGlobalGI GetKuroGlobalGIActor()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AKuroGlobalGI>(UKuroGISystem.__GetKuroGlobalGIActor_Internal(base.NativePtr));
		}

		// Token: 0x06019F3D RID: 106301 RVA: 0x00265790 File Offset: 0x00263990
		public static UKuroGISystem GetKuroGISystem(UWorld InWorld)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroGISystem>(UKuroGISystem.__GetKuroGISystem_Internal((InWorld != null) ? InWorld.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06019F3E RID: 106302 RVA: 0x002657AC File Offset: 0x002639AC
		public bool End3DUISceneRendering()
		{
			return UKuroGISystem.__End3DUISceneRendering_Internal(base.NativePtr);
		}

		// Token: 0x06019F3F RID: 106303 RVA: 0x002657B9 File Offset: 0x002639B9
		public void DoTransition(FName CollectionName, int TransitionState, float TransitionTime)
		{
			UKuroGISystem.__DoTransition_Internal(base.NativePtr, CollectionName, TransitionState, TransitionTime);
		}

		// Token: 0x06019F40 RID: 106304
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool CheckWindowsSupportHDR();

		// Token: 0x06019F41 RID: 106305
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool CheckWindowsEnableHDR();

		// Token: 0x06019F42 RID: 106306 RVA: 0x002657C9 File Offset: 0x002639C9
		public static void ApplyHDRMetaData(UWorld InWorld, float UINit, float GlobalNit)
		{
			UKuroGISystem.__ApplyHDRMetaData_Internal((InWorld != null) ? InWorld.NativePtr : IntPtr.Zero, UINit, GlobalNit);
		}

		// Token: 0x06019F43 RID: 106307 RVA: 0x002657E2 File Offset: 0x002639E2
		public static void ApplyEyeProtectionTexture(UWorld InWorld, float TextureIntensityID, float EnvironmentID)
		{
			UKuroGISystem.__ApplyEyeProtectionTexture_Internal((InWorld != null) ? InWorld.NativePtr : IntPtr.Zero, TextureIntensityID, EnvironmentID);
		}

		// Token: 0x06019F44 RID: 106308 RVA: 0x002657FB File Offset: 0x002639FB
		public static void ApplyEyeProtectionTemperature(UWorld InWorld, float Temperature, float EnvironmentID)
		{
			UKuroGISystem.__ApplyEyeProtectionTemperature_Internal((InWorld != null) ? InWorld.NativePtr : IntPtr.Zero, Temperature, EnvironmentID);
		}

		// Token: 0x06019F45 RID: 106309 RVA: 0x00265814 File Offset: 0x00263A14
		public static void ApplyEyeProtectionStrength(UWorld InWorld, float EyeProtectIntensity, float EnvironmentID)
		{
			UKuroGISystem.__ApplyEyeProtectionStrength_Internal((InWorld != null) ? InWorld.NativePtr : IntPtr.Zero, EyeProtectIntensity, EnvironmentID);
		}

		// Token: 0x06019F46 RID: 106310 RVA: 0x0026582D File Offset: 0x00263A2D
		public static void ApplyEyeProtectionEnvironment(UWorld InWorld, float EnvironmentID)
		{
			UKuroGISystem.__ApplyEyeProtectionEnvironment_Internal((InWorld != null) ? InWorld.NativePtr : IntPtr.Zero, EnvironmentID);
		}

		// Token: 0x06019F47 RID: 106311 RVA: 0x00265845 File Offset: 0x00263A45
		public static void ApplyEyeProtectionBrightness(UWorld InWorld, float Brightness, float EnvironmentID)
		{
			UKuroGISystem.__ApplyEyeProtectionBrightness_Internal((InWorld != null) ? InWorld.NativePtr : IntPtr.Zero, Brightness, EnvironmentID);
		}

		// Token: 0x06019F48 RID: 106312
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Start3DUISceneRendering_Internal(IntPtr @this, in FString InLevelName);

		// Token: 0x06019F49 RID: 106313
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroScreenFilterInterpolation_Internal(IntPtr InWorld, int ScreenFilterIndex, float X, float Y, float Intensity);

		// Token: 0x06019F4A RID: 106314
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroAdvancedModeScreenFilter_Internal(IntPtr InWorld, int ScreenFilterIndex, float X, float Y, float Intensity, float KuroSharpenIntensity, float AdModeBrightness, float AdModeScreenFilterContrast, float AdModeScreenFilteColorTemperature, float AdModeScreenFilterSaturation, float AdModeBloom, float AdModeNoiseIntensity, float AdModeShadowIntensity, float AdModeGamma, float AdModeHalation);

		// Token: 0x06019F4B RID: 106315
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsUISceneRendering_Internal(IntPtr @this);

		// Token: 0x06019F4C RID: 106316
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsLastTickGIActor_Internal(IntPtr @this, IntPtr Actor);

		// Token: 0x06019F4D RID: 106317
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EKuroUI3DState __GetUISceneRenderingState_Internal(IntPtr @this);

		// Token: 0x06019F4E RID: 106318
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetKuroGlobalGIActor_Internal(IntPtr @this);

		// Token: 0x06019F4F RID: 106319
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetKuroGISystem_Internal(IntPtr InWorld);

		// Token: 0x06019F50 RID: 106320
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __End3DUISceneRendering_Internal(IntPtr @this);

		// Token: 0x06019F51 RID: 106321
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DoTransition_Internal(IntPtr @this, FName CollectionName, int TransitionState, float TransitionTime);

		// Token: 0x06019F52 RID: 106322
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyHDRMetaData_Internal(IntPtr InWorld, float UINit, float GlobalNit);

		// Token: 0x06019F53 RID: 106323
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyEyeProtectionTexture_Internal(IntPtr InWorld, float TextureIntensityID, float EnvironmentID);

		// Token: 0x06019F54 RID: 106324
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyEyeProtectionTemperature_Internal(IntPtr InWorld, float Temperature, float EnvironmentID);

		// Token: 0x06019F55 RID: 106325
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyEyeProtectionStrength_Internal(IntPtr InWorld, float EyeProtectIntensity, float EnvironmentID);

		// Token: 0x06019F56 RID: 106326
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyEyeProtectionEnvironment_Internal(IntPtr InWorld, float EnvironmentID);

		// Token: 0x06019F57 RID: 106327
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyEyeProtectionBrightness_Internal(IntPtr InWorld, float Brightness, float EnvironmentID);

		// Token: 0x06019F58 RID: 106328 RVA: 0x0026585E File Offset: 0x00263A5E
		static UKuroGISystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroGISystem");
		}

		// Token: 0x06019F59 RID: 106329 RVA: 0x0026586C File Offset: 0x00263A6C
		protected UKuroGISystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E1C3 RID: 57795
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroGISystem";

		// Token: 0x0400E1C4 RID: 57796
		private static IntPtr _ClassPtr;

		// Token: 0x0400E1C5 RID: 57797
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E1C6 RID: 57798
		internal static int __PropertyOffset_KuroScreenFilterDataAsset;

		// Token: 0x0400E1C7 RID: 57799
		internal static int __PropertyOffset_KuroScreenBlueLightFilterDataAsset;

		// Token: 0x0400E1C8 RID: 57800
		internal static int __PropertyOffset_WeatherData;

		// Token: 0x0400E1C9 RID: 57801
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UObject> _WeatherData;

		// Token: 0x0400E1CA RID: 57802
		internal static int __PropertyOffset_FilterSystemData;

		// Token: 0x0400E1CB RID: 57803
		internal static int __PropertyOffset_WorldPartitionPreviewManager;

		// Token: 0x0400E1CC RID: 57804
		internal static int __PropertyOffset_PostprocessMaterialManager;

		// Token: 0x0400E1CD RID: 57805
		private FKuroPostprocessMaterialManager _PostprocessMaterialManager;

		// Token: 0x0400E1CE RID: 57806
		internal static int __PropertyOffset_SceneEffectActorManager;

		// Token: 0x0400E1CF RID: 57807
		private FKuroSceneEffectActorManager _SceneEffectActorManager;

		// Token: 0x0400E1D0 RID: 57808
		internal static int __PropertyOffset_PropertyDebugger;

		// Token: 0x0400E1D1 RID: 57809
		internal static int __PropertyOffset_RainManager;
	}
}
