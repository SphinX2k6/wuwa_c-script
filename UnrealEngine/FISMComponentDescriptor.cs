using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000CC1 RID: 3265
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/Engine.ISMComponentDescriptor")]
	[UnrealStructLayout(544, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 544)]
	public class FISMComponentDescriptor : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A507 RID: 42247 RVA: 0x000EAC0C File Offset: 0x000E8E0C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FISMComponentDescriptor._ScriptStructPtr != 0) ? FISMComponentDescriptor._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ISMComponentDescriptor", ref FISMComponentDescriptor._ScriptStructPtr);
		}

		// Token: 0x0600A508 RID: 42248 RVA: 0x000EAC30 File Offset: 0x000E8E30
		public FISMComponentDescriptor()
		{
		}

		// Token: 0x0600A509 RID: 42249 RVA: 0x000EAC38 File Offset: 0x000E8E38
		[NullableContext(1)]
		public FISMComponentDescriptor(uint Hash, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UInstancedStaticMeshComponent> ComponentClass, UStaticMesh StaticMesh, TArray<UMaterialInterface> OverrideMaterials, TArray<URuntimeVirtualTexture> RuntimeVirtualTextures, [Nullable(0)] TEnumAsByte<EComponentMobility> Mobility, ERuntimeVirtualTextureMainPassType VirtualTextureRenderPassType, ELightmapType LightmapType, FLightingChannels LightingChannels, [Nullable(0)] TEnumAsByte<EHasCustomNavigableGeometry> bHasCustomNavigableGeometry, ERendererStencilMask CustomDepthStencilWriteMask, FBodyInstance BodyInstance, int InstanceStartCullDistance, int InstanceEndCullDistance, EKuroISMCullingType KuroCullType, int KuroFoliageSplitFactor, int KuroMinVertsToSplitNode, int KuroFoliageForceShadowLOD, int VirtualTextureCullMips, int TranslucencySortPriority, int OverriddenLightMapRes, int CustomDepthStencilValue, bool bCastShadow, bool bCastDynamicShadow, bool bCastStaticShadow, bool bCastContactShadow, bool bCastShadowAsTwoSided, bool bCastShadowInCinematicQuality, bool bOriginalCastShadow, bool bAffectDynamicIndirectLighting, bool bAffectDistanceFieldLighting, bool bReceivesDecals, bool bOverrideLightMapRes, bool bUseAsOccluder, bool bEnableDensityScaling, bool bEnableDiscardOnLoad, bool bRenderCustomDepth, bool bIncludeInHLOD, bool bVisibleInRayTracing, bool bHiddenInGame, bool bIsEditorOnly, bool bVisible, bool bConsiderForActorPlacementWhenHidden)
		{
		}

		// Token: 0x0600A50A RID: 42250 RVA: 0x000EAC40 File Offset: 0x000E8E40
		protected override IntPtr GetUStructPtr()
		{
			return FISMComponentDescriptor.StaticStruct();
		}

		// Token: 0x0600A50B RID: 42251 RVA: 0x000EAC4C File Offset: 0x000E8E4C
		[NullableContext(2)]
		public FISMComponentDescriptor(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A50C RID: 42252 RVA: 0x000EAC56 File Offset: 0x000E8E56
		public FISMComponentDescriptor(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A50D RID: 42253 RVA: 0x000EAC61 File Offset: 0x000E8E61
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FISMComponentDescriptor(Pointer, false, true);
		}

		// Token: 0x0600A50E RID: 42254 RVA: 0x000EAC6B File Offset: 0x000E8E6B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FISMComponentDescriptor(Pointer, MemoryOwner);
		}

		// Token: 0x04005ACB RID: 23243
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ISMComponentDescriptor";

		// Token: 0x04005ACC RID: 23244
		private static IntPtr _ScriptStructPtr;
	}
}
