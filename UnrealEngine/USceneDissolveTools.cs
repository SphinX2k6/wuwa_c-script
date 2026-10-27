using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001937 RID: 6455
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.SceneDissolveTools")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class USceneDissolveTools : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017EEA RID: 98026 RVA: 0x00231183 File Offset: 0x0022F383
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USceneDissolveTools._ClassPtr;
		}

		// Token: 0x06017EEB RID: 98027 RVA: 0x00231190 File Offset: 0x0022F390
		public USceneDissolveTools() : this(BuiltinUtils.AllocNativeUObject(USceneDissolveTools.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017EEC RID: 98028 RVA: 0x002311B8 File Offset: 0x0022F3B8
		public USceneDissolveTools(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USceneDissolveTools.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06017EED RID: 98029 RVA: 0x002311EC File Offset: 0x0022F3EC
		public unsafe static int RecompileSceneDissolveShaders([Nullable(2)] UObject WorldContextObject, string RecompileShadersArguments = "")
		{
			FString fstring = FString.AllocTemp(RecompileShadersArguments);
			int result = USceneDissolveTools.__RecompileSceneDissolveShaders_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06017EEE RID: 98030 RVA: 0x00231220 File Offset: 0x0022F420
		public static TArray<FAssetData> MaterialInterfacesToAssetData([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<UMaterialInterface> MaterialInstances)
		{
			return new TArray<FAssetData>(USceneDissolveTools.__MaterialInterfacesToAssetData_Internal((MaterialInstances ?? new TArray<UMaterialInterface>()).NativePtr), null);
		}

		// Token: 0x06017EEF RID: 98031 RVA: 0x0023123D File Offset: 0x0022F43D
		[NullableContext(2)]
		public static int EnableSceneDissolveOnAllStaticMeshMICs(UObject WorldContextObject, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UMaterialInterface> OutProcessedMICs, bool bSaveModifiedPackages = true)
		{
			return USceneDissolveTools.__EnableSceneDissolveOnAllStaticMeshMICs_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (OutProcessedMICs ?? new TArray<UMaterialInterface>()).NativePtr, bSaveModifiedPackages);
		}

		// Token: 0x06017EF0 RID: 98032 RVA: 0x00231265 File Offset: 0x0022F465
		public static int EnableSceneDissolveOnActorsStaticMeshMICs([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> Actors, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UMaterialInterface> OutProcessedMICs, bool bSaveModifiedPackages = true)
		{
			return USceneDissolveTools.__EnableSceneDissolveOnActorsStaticMeshMICs_Internal((Actors ?? new TArray<AActor>()).NativePtr, (OutProcessedMICs ?? new TArray<UMaterialInterface>()).NativePtr, bSaveModifiedPackages);
		}

		// Token: 0x06017EF1 RID: 98033 RVA: 0x0023128D File Offset: 0x0022F48D
		public static int DisableSceneDissolveOnMICs([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<UMaterialInterface> MaterialInstances, bool bSaveModifiedPackages = true)
		{
			return USceneDissolveTools.__DisableSceneDissolveOnMICs_Internal((MaterialInstances ?? new TArray<UMaterialInterface>()).NativePtr, bSaveModifiedPackages);
		}

		// Token: 0x06017EF2 RID: 98034 RVA: 0x002312A5 File Offset: 0x0022F4A5
		[NullableContext(2)]
		public static int DisableSceneDissolveOnAllStaticMeshMICs(UObject WorldContextObject, bool bSaveModifiedPackages = true)
		{
			return USceneDissolveTools.__DisableSceneDissolveOnAllStaticMeshMICs_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, bSaveModifiedPackages);
		}

		// Token: 0x06017EF3 RID: 98035 RVA: 0x002312BD File Offset: 0x0022F4BD
		public static TArray<FSceneDissolveMaterialMapEntry> BuildParentMaterialMap([Nullable(2)] UObject WorldContextObject)
		{
			return new TArray<FSceneDissolveMaterialMapEntry>(USceneDissolveTools.__BuildParentMaterialMap_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x06017EF4 RID: 98036 RVA: 0x002312DA File Offset: 0x0022F4DA
		public static TArray<UMaterialInterface> AssetDataToMaterialInterfaces([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FAssetData> AssetDataArray)
		{
			return new TArray<UMaterialInterface>(USceneDissolveTools.__AssetDataToMaterialInterfaces_Internal((AssetDataArray ?? new TArray<FAssetData>()).NativePtr), null);
		}

		// Token: 0x06017EF5 RID: 98037 RVA: 0x002312F7 File Offset: 0x0022F4F7
		public static FSceneDissolveBatchResult ApplySceneDissolveWithHistoryOnActors([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> Actors, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<UMaterialInterface> PreviousProcessedMICs, bool bSaveModifiedPackages = true)
		{
			return new FSceneDissolveBatchResult(USceneDissolveTools.__ApplySceneDissolveWithHistoryOnActors_Internal((Actors ?? new TArray<AActor>()).NativePtr, (PreviousProcessedMICs ?? new TArray<UMaterialInterface>()).NativePtr, bSaveModifiedPackages), null);
		}

		// Token: 0x06017EF6 RID: 98038 RVA: 0x00231325 File Offset: 0x0022F525
		public static FSceneDissolveBatchResult ApplySceneDissolveWithHistoryInWorld([Nullable(2)] UObject WorldContextObject, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<UMaterialInterface> PreviousProcessedMICs, bool bSaveModifiedPackages = true)
		{
			return new FSceneDissolveBatchResult(USceneDissolveTools.__ApplySceneDissolveWithHistoryInWorld_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (PreviousProcessedMICs ?? new TArray<UMaterialInterface>()).NativePtr, bSaveModifiedPackages), null);
		}

		// Token: 0x06017EF7 RID: 98039 RVA: 0x00231353 File Offset: 0x0022F553
		public static FSceneDissolveVariantAnalysisResult AnalyzeSceneDissolveVariantsForMICs([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<UMaterialInterface> MaterialInstances)
		{
			return new FSceneDissolveVariantAnalysisResult(USceneDissolveTools.__AnalyzeSceneDissolveVariantsForMICs_Internal((MaterialInstances ?? new TArray<UMaterialInterface>()).NativePtr), null);
		}

		// Token: 0x06017EF8 RID: 98040
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __RecompileSceneDissolveShaders_Internal(IntPtr WorldContextObject, in FString RecompileShadersArguments);

		// Token: 0x06017EF9 RID: 98041
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MaterialInterfacesToAssetData_Internal(IntPtr MaterialInstances);

		// Token: 0x06017EFA RID: 98042
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __EnableSceneDissolveOnAllStaticMeshMICs_Internal(IntPtr WorldContextObject, IntPtr OutProcessedMICs, bool bSaveModifiedPackages);

		// Token: 0x06017EFB RID: 98043
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __EnableSceneDissolveOnActorsStaticMeshMICs_Internal(IntPtr Actors, IntPtr OutProcessedMICs, bool bSaveModifiedPackages);

		// Token: 0x06017EFC RID: 98044
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __DisableSceneDissolveOnMICs_Internal(IntPtr MaterialInstances, bool bSaveModifiedPackages);

		// Token: 0x06017EFD RID: 98045
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __DisableSceneDissolveOnAllStaticMeshMICs_Internal(IntPtr WorldContextObject, bool bSaveModifiedPackages);

		// Token: 0x06017EFE RID: 98046
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __BuildParentMaterialMap_Internal(IntPtr WorldContextObject);

		// Token: 0x06017EFF RID: 98047
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AssetDataToMaterialInterfaces_Internal(IntPtr AssetDataArray);

		// Token: 0x06017F00 RID: 98048
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __ApplySceneDissolveWithHistoryOnActors_Internal(IntPtr Actors, IntPtr PreviousProcessedMICs, bool bSaveModifiedPackages);

		// Token: 0x06017F01 RID: 98049
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __ApplySceneDissolveWithHistoryInWorld_Internal(IntPtr WorldContextObject, IntPtr PreviousProcessedMICs, bool bSaveModifiedPackages);

		// Token: 0x06017F02 RID: 98050
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AnalyzeSceneDissolveVariantsForMICs_Internal(IntPtr MaterialInstances);

		// Token: 0x06017F03 RID: 98051 RVA: 0x00231370 File Offset: 0x0022F570
		static USceneDissolveTools()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.SceneDissolveTools");
		}

		// Token: 0x06017F04 RID: 98052 RVA: 0x0023137E File Offset: 0x0022F57E
		protected USceneDissolveTools(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CF49 RID: 53065
		public new const string __ObjectPath = "/Script/KuroGameplay.SceneDissolveTools";

		// Token: 0x0400CF4A RID: 53066
		private static IntPtr _ClassPtr;

		// Token: 0x0400CF4B RID: 53067
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
