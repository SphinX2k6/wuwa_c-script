using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C33 RID: 3123
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/Engine.HLODISMComponentDescriptor")]
	[UnrealStructLayout(544, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 544)]
	public class FHLODISMComponentDescriptor : FISMComponentDescriptor, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009E52 RID: 40530 RVA: 0x000E102A File Offset: 0x000DF22A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHLODISMComponentDescriptor._ScriptStructPtr != 0) ? FHLODISMComponentDescriptor._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.HLODISMComponentDescriptor", ref FHLODISMComponentDescriptor._ScriptStructPtr);
		}

		// Token: 0x06009E53 RID: 40531 RVA: 0x000E104E File Offset: 0x000DF24E
		public FHLODISMComponentDescriptor()
		{
		}

		// Token: 0x06009E54 RID: 40532 RVA: 0x000E1056 File Offset: 0x000DF256
		[NullableContext(1)]
		public FHLODISMComponentDescriptor(uint Hash, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UInstancedStaticMeshComponent> ComponentClass, UStaticMesh StaticMesh, TArray<UMaterialInterface> OverrideMaterials, TArray<URuntimeVirtualTexture> RuntimeVirtualTextures, [Nullable(0)] TEnumAsByte<EComponentMobility> Mobility, ERuntimeVirtualTextureMainPassType VirtualTextureRenderPassType, ELightmapType LightmapType, FLightingChannels LightingChannels, [Nullable(0)] TEnumAsByte<EHasCustomNavigableGeometry> bHasCustomNavigableGeometry, ERendererStencilMask CustomDepthStencilWriteMask, FBodyInstance BodyInstance, int InstanceStartCullDistance, int InstanceEndCullDistance, EKuroISMCullingType KuroCullType, int KuroFoliageSplitFactor, int KuroMinVertsToSplitNode, int KuroFoliageForceShadowLOD, int VirtualTextureCullMips, int TranslucencySortPriority, int OverriddenLightMapRes, int CustomDepthStencilValue, bool bCastShadow, bool bCastDynamicShadow, bool bCastStaticShadow, bool bCastContactShadow, bool bCastShadowAsTwoSided, bool bCastShadowInCinematicQuality, bool bOriginalCastShadow, bool bAffectDynamicIndirectLighting, bool bAffectDistanceFieldLighting, bool bReceivesDecals, bool bOverrideLightMapRes, bool bUseAsOccluder, bool bEnableDensityScaling, bool bEnableDiscardOnLoad, bool bRenderCustomDepth, bool bIncludeInHLOD, bool bVisibleInRayTracing, bool bHiddenInGame, bool bIsEditorOnly, bool bVisible, bool bConsiderForActorPlacementWhenHidden)
		{
		}

		// Token: 0x06009E55 RID: 40533 RVA: 0x000E105E File Offset: 0x000DF25E
		protected override IntPtr GetUStructPtr()
		{
			return FHLODISMComponentDescriptor.StaticStruct();
		}

		// Token: 0x06009E56 RID: 40534 RVA: 0x000E106A File Offset: 0x000DF26A
		[NullableContext(2)]
		public FHLODISMComponentDescriptor(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009E57 RID: 40535 RVA: 0x000E1074 File Offset: 0x000DF274
		public FHLODISMComponentDescriptor(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009E58 RID: 40536 RVA: 0x000E107F File Offset: 0x000DF27F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHLODISMComponentDescriptor(Pointer, false, true);
		}

		// Token: 0x06009E59 RID: 40537 RVA: 0x000E1089 File Offset: 0x000DF289
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHLODISMComponentDescriptor(Pointer, MemoryOwner);
		}

		// Token: 0x04005744 RID: 22340
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.HLODISMComponentDescriptor";

		// Token: 0x04005745 RID: 22341
		private static IntPtr _ScriptStructPtr;
	}
}
