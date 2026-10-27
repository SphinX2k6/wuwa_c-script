using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014A4 RID: 5284
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniAssetComponent")]
	[UnrealStructLayout(2912, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2912)]
	public class UHoudiniAssetComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject, IHoudiniAssetStateEvents, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06013241 RID: 78401 RVA: 0x001C26EA File Offset: 0x001C08EA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniAssetComponent._ClassPtr;
		}

		// Token: 0x06013242 RID: 78402 RVA: 0x001C26F6 File Offset: 0x001C08F6
		int IHoudiniAssetStateEvents.InterfaceOffset()
		{
			return UHoudiniAssetComponent.__InterfaceOffset_IHoudiniAssetStateEvents;
		}

		// Token: 0x06013243 RID: 78403 RVA: 0x001C2700 File Offset: 0x001C0900
		public UHoudiniAssetComponent() : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013244 RID: 78404 RVA: 0x001C2728 File Offset: 0x001C0928
		public UHoudiniAssetComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniAssetComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004A63 RID: 19043
		// (get) Token: 0x06013245 RID: 78405 RVA: 0x001C275B File Offset: 0x001C095B
		// (set) Token: 0x06013246 RID: 78406 RVA: 0x001C276F File Offset: 0x001C096F
		[Nullable(2)]
		public unsafe UHoudiniAsset HoudiniAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UHoudiniAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UHoudiniAssetComponent.__PropertyOffset_HoudiniAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UHoudiniAssetComponent.__PropertyOffset_HoudiniAsset, value);
			}
		}

		// Token: 0x17004A64 RID: 19044
		// (get) Token: 0x06013247 RID: 78407 RVA: 0x001C2784 File Offset: 0x001C0984
		// (set) Token: 0x06013248 RID: 78408 RVA: 0x001C2794 File Offset: 0x001C0994
		public unsafe bool bCookOnParameterChange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bCookOnParameterChange) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bCookOnParameterChange) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A65 RID: 19045
		// (get) Token: 0x06013249 RID: 78409 RVA: 0x001C27A5 File Offset: 0x001C09A5
		// (set) Token: 0x0601324A RID: 78410 RVA: 0x001C27B5 File Offset: 0x001C09B5
		public unsafe bool bUploadTransformsToHoudiniEngine
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bUploadTransformsToHoudiniEngine) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bUploadTransformsToHoudiniEngine) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A66 RID: 19046
		// (get) Token: 0x0601324B RID: 78411 RVA: 0x001C27C6 File Offset: 0x001C09C6
		// (set) Token: 0x0601324C RID: 78412 RVA: 0x001C27D6 File Offset: 0x001C09D6
		public unsafe bool bCookOnTransformChange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bCookOnTransformChange) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bCookOnTransformChange) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A67 RID: 19047
		// (get) Token: 0x0601324D RID: 78413 RVA: 0x001C27E7 File Offset: 0x001C09E7
		// (set) Token: 0x0601324E RID: 78414 RVA: 0x001C27F7 File Offset: 0x001C09F7
		public unsafe bool bCookOnAssetInputCook
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bCookOnAssetInputCook) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bCookOnAssetInputCook) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A68 RID: 19048
		// (get) Token: 0x0601324F RID: 78415 RVA: 0x001C2808 File Offset: 0x001C0A08
		// (set) Token: 0x06013250 RID: 78416 RVA: 0x001C2818 File Offset: 0x001C0A18
		public unsafe bool bOutputless
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bOutputless) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bOutputless) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A69 RID: 19049
		// (get) Token: 0x06013251 RID: 78417 RVA: 0x001C2829 File Offset: 0x001C0A29
		// (set) Token: 0x06013252 RID: 78418 RVA: 0x001C2839 File Offset: 0x001C0A39
		public unsafe bool bOutputTemplateGeos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bOutputTemplateGeos) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bOutputTemplateGeos) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A6A RID: 19050
		// (get) Token: 0x06013253 RID: 78419 RVA: 0x001C284A File Offset: 0x001C0A4A
		// (set) Token: 0x06013254 RID: 78420 RVA: 0x001C285A File Offset: 0x001C0A5A
		public unsafe bool bUseOutputNodes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bUseOutputNodes) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bUseOutputNodes) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A6B RID: 19051
		// (get) Token: 0x06013255 RID: 78421 RVA: 0x001C286C File Offset: 0x001C0A6C
		// (set) Token: 0x06013256 RID: 78422 RVA: 0x001C28A5 File Offset: 0x001C0AA5
		public FDirectoryPath TemporaryCookFolder
		{
			get
			{
				base.FastCheckIsValid();
				FDirectoryPath result;
				if ((result = this._TemporaryCookFolder) == null)
				{
					result = (this._TemporaryCookFolder = new FDirectoryPath(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_TemporaryCookFolder, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDirectoryPath.StaticStruct(), base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_TemporaryCookFolder, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004A6C RID: 19052
		// (get) Token: 0x06013257 RID: 78423 RVA: 0x001C28C8 File Offset: 0x001C0AC8
		// (set) Token: 0x06013258 RID: 78424 RVA: 0x001C2901 File Offset: 0x001C0B01
		public FDirectoryPath BakeFolder
		{
			get
			{
				base.FastCheckIsValid();
				FDirectoryPath result;
				if ((result = this._BakeFolder) == null)
				{
					result = (this._BakeFolder = new FDirectoryPath(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_BakeFolder, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDirectoryPath.StaticStruct(), base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_BakeFolder, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004A6D RID: 19053
		// (get) Token: 0x06013259 RID: 78425 RVA: 0x001C2922 File Offset: 0x001C0B22
		// (set) Token: 0x0601325A RID: 78426 RVA: 0x001C2932 File Offset: 0x001C0B32
		public unsafe EHoudiniStaticMeshMethod StaticMeshMethod
		{
			get
			{
				return (EHoudiniStaticMeshMethod)(*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_StaticMeshMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_StaticMeshMethod) = (byte)value;
			}
		}

		// Token: 0x17004A6E RID: 19054
		// (get) Token: 0x0601325B RID: 78427 RVA: 0x001C2944 File Offset: 0x001C0B44
		// (set) Token: 0x0601325C RID: 78428 RVA: 0x001C297D File Offset: 0x001C0B7D
		public FHoudiniStaticMeshGenerationProperties StaticMeshGenerationProperties
		{
			get
			{
				base.FastCheckIsValid();
				FHoudiniStaticMeshGenerationProperties result;
				if ((result = this._StaticMeshGenerationProperties) == null)
				{
					result = (this._StaticMeshGenerationProperties = new FHoudiniStaticMeshGenerationProperties(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_StaticMeshGenerationProperties, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FHoudiniStaticMeshGenerationProperties.StaticStruct(), base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_StaticMeshGenerationProperties, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004A6F RID: 19055
		// (get) Token: 0x0601325D RID: 78429 RVA: 0x001C29A0 File Offset: 0x001C0BA0
		// (set) Token: 0x0601325E RID: 78430 RVA: 0x001C29D9 File Offset: 0x001C0BD9
		public FMeshBuildSettings StaticMeshBuildSettings
		{
			get
			{
				base.FastCheckIsValid();
				FMeshBuildSettings result;
				if ((result = this._StaticMeshBuildSettings) == null)
				{
					result = (this._StaticMeshBuildSettings = new FMeshBuildSettings(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_StaticMeshBuildSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMeshBuildSettings.StaticStruct(), base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_StaticMeshBuildSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004A70 RID: 19056
		// (get) Token: 0x0601325F RID: 78431 RVA: 0x001C29FA File Offset: 0x001C0BFA
		// (set) Token: 0x06013260 RID: 78432 RVA: 0x001C2A0A File Offset: 0x001C0C0A
		public unsafe bool bOverrideGlobalProxyStaticMeshSettings
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bOverrideGlobalProxyStaticMeshSettings) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bOverrideGlobalProxyStaticMeshSettings) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A71 RID: 19057
		// (get) Token: 0x06013261 RID: 78433 RVA: 0x001C2A1B File Offset: 0x001C0C1B
		// (set) Token: 0x06013262 RID: 78434 RVA: 0x001C2A2B File Offset: 0x001C0C2B
		public unsafe bool bEnableProxyStaticMeshOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bEnableProxyStaticMeshOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bEnableProxyStaticMeshOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A72 RID: 19058
		// (get) Token: 0x06013263 RID: 78435 RVA: 0x001C2A3C File Offset: 0x001C0C3C
		// (set) Token: 0x06013264 RID: 78436 RVA: 0x001C2A4C File Offset: 0x001C0C4C
		public unsafe bool bEnableProxyStaticMeshRefinementByTimerOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bEnableProxyStaticMeshRefinementByTimerOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bEnableProxyStaticMeshRefinementByTimerOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A73 RID: 19059
		// (get) Token: 0x06013265 RID: 78437 RVA: 0x001C2A5D File Offset: 0x001C0C5D
		// (set) Token: 0x06013266 RID: 78438 RVA: 0x001C2A6D File Offset: 0x001C0C6D
		public unsafe float ProxyMeshAutoRefineTimeoutSecondsOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_ProxyMeshAutoRefineTimeoutSecondsOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_ProxyMeshAutoRefineTimeoutSecondsOverride) = value;
			}
		}

		// Token: 0x17004A74 RID: 19060
		// (get) Token: 0x06013267 RID: 78439 RVA: 0x001C2A7E File Offset: 0x001C0C7E
		// (set) Token: 0x06013268 RID: 78440 RVA: 0x001C2A8E File Offset: 0x001C0C8E
		public unsafe bool bEnableProxyStaticMeshRefinementOnPreSaveWorldOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bEnableProxyStaticMeshRefinementOnPreSaveWorldOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bEnableProxyStaticMeshRefinementOnPreSaveWorldOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A75 RID: 19061
		// (get) Token: 0x06013269 RID: 78441 RVA: 0x001C2A9F File Offset: 0x001C0C9F
		// (set) Token: 0x0601326A RID: 78442 RVA: 0x001C2AAF File Offset: 0x001C0CAF
		public unsafe bool bEnableProxyStaticMeshRefinementOnPreBeginPIEOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bEnableProxyStaticMeshRefinementOnPreBeginPIEOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bEnableProxyStaticMeshRefinementOnPreBeginPIEOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A76 RID: 19062
		// (get) Token: 0x0601326B RID: 78443 RVA: 0x001C2AC0 File Offset: 0x001C0CC0
		// (set) Token: 0x0601326C RID: 78444 RVA: 0x001C2AD0 File Offset: 0x001C0CD0
		public unsafe int AssetId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_AssetId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_AssetId) = value;
			}
		}

		// Token: 0x17004A77 RID: 19063
		// (get) Token: 0x0601326D RID: 78445 RVA: 0x001C2AE4 File Offset: 0x001C0CE4
		// (set) Token: 0x0601326E RID: 78446 RVA: 0x001C2B1D File Offset: 0x001C0D1D
		public TArray<int> NodeIdsToCook
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._NodeIdsToCook) == null)
				{
					result = (this._NodeIdsToCook = new TArray<int>(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_NodeIdsToCook, this));
				}
				return result;
			}
			set
			{
				this.NodeIdsToCook.CopyAssign(value);
			}
		}

		// Token: 0x17004A78 RID: 19064
		// (get) Token: 0x0601326F RID: 78447 RVA: 0x001C2B2C File Offset: 0x001C0D2C
		// (set) Token: 0x06013270 RID: 78448 RVA: 0x001C2B65 File Offset: 0x001C0D65
		public TMap<int, int> OutputNodeCookCounts
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, int> result;
				if ((result = this._OutputNodeCookCounts) == null)
				{
					result = (this._OutputNodeCookCounts = new TMap<int, int>(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_OutputNodeCookCounts, this));
				}
				return result;
			}
			set
			{
				this.OutputNodeCookCounts.CopyAssign(value);
			}
		}

		// Token: 0x17004A79 RID: 19065
		// (get) Token: 0x06013271 RID: 78449 RVA: 0x001C2B74 File Offset: 0x001C0D74
		// (set) Token: 0x06013272 RID: 78450 RVA: 0x001C2BAD File Offset: 0x001C0DAD
		public TSet<UHoudiniAssetComponent> DownstreamHoudiniAssets
		{
			get
			{
				base.FastCheckIsValid();
				TSet<UHoudiniAssetComponent> result;
				if ((result = this._DownstreamHoudiniAssets) == null)
				{
					result = (this._DownstreamHoudiniAssets = new TSet<UHoudiniAssetComponent>(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_DownstreamHoudiniAssets, this));
				}
				return result;
			}
			set
			{
				this.DownstreamHoudiniAssets.CopyAssign(value);
			}
		}

		// Token: 0x17004A7A RID: 19066
		// (get) Token: 0x06013273 RID: 78451 RVA: 0x001C2BBB File Offset: 0x001C0DBB
		// (set) Token: 0x06013274 RID: 78452 RVA: 0x001C2BCF File Offset: 0x001C0DCF
		public unsafe FGuid ComponentGUID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_ComponentGUID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_ComponentGUID) = value;
			}
		}

		// Token: 0x17004A7B RID: 19067
		// (get) Token: 0x06013275 RID: 78453 RVA: 0x001C2BE4 File Offset: 0x001C0DE4
		// (set) Token: 0x06013276 RID: 78454 RVA: 0x001C2BF8 File Offset: 0x001C0DF8
		public unsafe FGuid HapiGUID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_HapiGUID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_HapiGUID) = value;
			}
		}

		// Token: 0x17004A7C RID: 19068
		// (get) Token: 0x06013277 RID: 78455 RVA: 0x001C2C0D File Offset: 0x001C0E0D
		// (set) Token: 0x06013278 RID: 78456 RVA: 0x001C2C21 File Offset: 0x001C0E21
		public unsafe string HapiAssetName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniAssetComponent.__PropertyOffset_HapiAssetName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniAssetComponent.__PropertyOffset_HapiAssetName)), value);
			}
		}

		// Token: 0x17004A7D RID: 19069
		// (get) Token: 0x06013279 RID: 78457 RVA: 0x001C2C36 File Offset: 0x001C0E36
		// (set) Token: 0x0601327A RID: 78458 RVA: 0x001C2C46 File Offset: 0x001C0E46
		public unsafe EHoudiniAssetState AssetState
		{
			get
			{
				return (EHoudiniAssetState)(*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_AssetState));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_AssetState) = (byte)value;
			}
		}

		// Token: 0x17004A7E RID: 19070
		// (get) Token: 0x0601327B RID: 78459 RVA: 0x001C2C57 File Offset: 0x001C0E57
		// (set) Token: 0x0601327C RID: 78460 RVA: 0x001C2C67 File Offset: 0x001C0E67
		public unsafe EHoudiniAssetState DebugLastAssetState
		{
			get
			{
				return (EHoudiniAssetState)(*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_DebugLastAssetState));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_DebugLastAssetState) = (byte)value;
			}
		}

		// Token: 0x17004A7F RID: 19071
		// (get) Token: 0x0601327D RID: 78461 RVA: 0x001C2C78 File Offset: 0x001C0E78
		// (set) Token: 0x0601327E RID: 78462 RVA: 0x001C2C88 File Offset: 0x001C0E88
		public unsafe EHoudiniAssetStateResult AssetStateResult
		{
			get
			{
				return (EHoudiniAssetStateResult)(*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_AssetStateResult));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_AssetStateResult) = (byte)value;
			}
		}

		// Token: 0x17004A80 RID: 19072
		// (get) Token: 0x0601327F RID: 78463 RVA: 0x001C2C99 File Offset: 0x001C0E99
		// (set) Token: 0x06013280 RID: 78464 RVA: 0x001C2CAD File Offset: 0x001C0EAD
		public unsafe FTransform LastComponentTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_LastComponentTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_LastComponentTransform) = value;
			}
		}

		// Token: 0x17004A81 RID: 19073
		// (get) Token: 0x06013281 RID: 78465 RVA: 0x001C2CC2 File Offset: 0x001C0EC2
		// (set) Token: 0x06013282 RID: 78466 RVA: 0x001C2CD2 File Offset: 0x001C0ED2
		public unsafe uint SubAssetIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_SubAssetIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_SubAssetIndex) = (int)value;
			}
		}

		// Token: 0x17004A82 RID: 19074
		// (get) Token: 0x06013283 RID: 78467 RVA: 0x001C2CE3 File Offset: 0x001C0EE3
		// (set) Token: 0x06013284 RID: 78468 RVA: 0x001C2CF3 File Offset: 0x001C0EF3
		public unsafe int AssetCookCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_AssetCookCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_AssetCookCount) = value;
			}
		}

		// Token: 0x17004A83 RID: 19075
		// (get) Token: 0x06013285 RID: 78469 RVA: 0x001C2D04 File Offset: 0x001C0F04
		// (set) Token: 0x06013286 RID: 78470 RVA: 0x001C2D14 File Offset: 0x001C0F14
		public unsafe bool bHasBeenLoaded
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bHasBeenLoaded) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bHasBeenLoaded) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A84 RID: 19076
		// (get) Token: 0x06013287 RID: 78471 RVA: 0x001C2D25 File Offset: 0x001C0F25
		// (set) Token: 0x06013288 RID: 78472 RVA: 0x001C2D35 File Offset: 0x001C0F35
		public unsafe bool bHasBeenDuplicated
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bHasBeenDuplicated) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bHasBeenDuplicated) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A85 RID: 19077
		// (get) Token: 0x06013289 RID: 78473 RVA: 0x001C2D46 File Offset: 0x001C0F46
		// (set) Token: 0x0601328A RID: 78474 RVA: 0x001C2D56 File Offset: 0x001C0F56
		public unsafe bool bPendingDelete
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bPendingDelete) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bPendingDelete) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A86 RID: 19078
		// (get) Token: 0x0601328B RID: 78475 RVA: 0x001C2D67 File Offset: 0x001C0F67
		// (set) Token: 0x0601328C RID: 78476 RVA: 0x001C2D77 File Offset: 0x001C0F77
		public unsafe bool bRecookRequested
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bRecookRequested) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bRecookRequested) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A87 RID: 19079
		// (get) Token: 0x0601328D RID: 78477 RVA: 0x001C2D88 File Offset: 0x001C0F88
		// (set) Token: 0x0601328E RID: 78478 RVA: 0x001C2D98 File Offset: 0x001C0F98
		public unsafe bool bRebuildRequested
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bRebuildRequested) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bRebuildRequested) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A88 RID: 19080
		// (get) Token: 0x0601328F RID: 78479 RVA: 0x001C2DA9 File Offset: 0x001C0FA9
		// (set) Token: 0x06013290 RID: 78480 RVA: 0x001C2DB9 File Offset: 0x001C0FB9
		public unsafe bool bEnableCooking
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bEnableCooking) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bEnableCooking) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A89 RID: 19081
		// (get) Token: 0x06013291 RID: 78481 RVA: 0x001C2DCA File Offset: 0x001C0FCA
		// (set) Token: 0x06013292 RID: 78482 RVA: 0x001C2DDA File Offset: 0x001C0FDA
		public unsafe bool bForceNeedUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bForceNeedUpdate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bForceNeedUpdate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A8A RID: 19082
		// (get) Token: 0x06013293 RID: 78483 RVA: 0x001C2DEB File Offset: 0x001C0FEB
		// (set) Token: 0x06013294 RID: 78484 RVA: 0x001C2DFB File Offset: 0x001C0FFB
		public unsafe bool bLastCookSuccess
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bLastCookSuccess) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bLastCookSuccess) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A8B RID: 19083
		// (get) Token: 0x06013295 RID: 78485 RVA: 0x001C2E0C File Offset: 0x001C100C
		// (set) Token: 0x06013296 RID: 78486 RVA: 0x001C2E1C File Offset: 0x001C101C
		public unsafe bool bParameterDefinitionUpdateNeeded
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bParameterDefinitionUpdateNeeded) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bParameterDefinitionUpdateNeeded) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A8C RID: 19084
		// (get) Token: 0x06013297 RID: 78487 RVA: 0x001C2E2D File Offset: 0x001C102D
		// (set) Token: 0x06013298 RID: 78488 RVA: 0x001C2E3D File Offset: 0x001C103D
		public unsafe bool bBlueprintStructureModified
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bBlueprintStructureModified) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bBlueprintStructureModified) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A8D RID: 19085
		// (get) Token: 0x06013299 RID: 78489 RVA: 0x001C2E4E File Offset: 0x001C104E
		// (set) Token: 0x0601329A RID: 78490 RVA: 0x001C2E5E File Offset: 0x001C105E
		public unsafe bool bBlueprintModified
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bBlueprintModified) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bBlueprintModified) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A8E RID: 19086
		// (get) Token: 0x0601329B RID: 78491 RVA: 0x001C2E70 File Offset: 0x001C1070
		// (set) Token: 0x0601329C RID: 78492 RVA: 0x001C2EA9 File Offset: 0x001C10A9
		public TArray<UHoudiniParameter> Parameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UHoudiniParameter> result;
				if ((result = this._Parameters) == null)
				{
					result = (this._Parameters = new TArray<UHoudiniParameter>(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_Parameters, this));
				}
				return result;
			}
			set
			{
				this.Parameters.CopyAssign(value);
			}
		}

		// Token: 0x17004A8F RID: 19087
		// (get) Token: 0x0601329D RID: 78493 RVA: 0x001C2EB8 File Offset: 0x001C10B8
		// (set) Token: 0x0601329E RID: 78494 RVA: 0x001C2EF1 File Offset: 0x001C10F1
		public TArray<UHoudiniInput> Inputs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UHoudiniInput> result;
				if ((result = this._Inputs) == null)
				{
					result = (this._Inputs = new TArray<UHoudiniInput>(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_Inputs, this));
				}
				return result;
			}
			set
			{
				this.Inputs.CopyAssign(value);
			}
		}

		// Token: 0x17004A90 RID: 19088
		// (get) Token: 0x0601329F RID: 78495 RVA: 0x001C2F00 File Offset: 0x001C1100
		// (set) Token: 0x060132A0 RID: 78496 RVA: 0x001C2F39 File Offset: 0x001C1139
		public TArray<UHoudiniOutput> Outputs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UHoudiniOutput> result;
				if ((result = this._Outputs) == null)
				{
					result = (this._Outputs = new TArray<UHoudiniOutput>(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_Outputs, this));
				}
				return result;
			}
			set
			{
				this.Outputs.CopyAssign(value);
			}
		}

		// Token: 0x17004A91 RID: 19089
		// (get) Token: 0x060132A1 RID: 78497 RVA: 0x001C2F48 File Offset: 0x001C1148
		// (set) Token: 0x060132A2 RID: 78498 RVA: 0x001C2F81 File Offset: 0x001C1181
		public TArray<FHoudiniBakedOutput> BakedOutputs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FHoudiniBakedOutput> result;
				if ((result = this._BakedOutputs) == null)
				{
					result = (this._BakedOutputs = new TArray<FHoudiniBakedOutput>(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_BakedOutputs, this));
				}
				return result;
			}
			set
			{
				this.BakedOutputs.CopyAssign(value);
			}
		}

		// Token: 0x17004A92 RID: 19090
		// (get) Token: 0x060132A3 RID: 78499 RVA: 0x001C2F90 File Offset: 0x001C1190
		// (set) Token: 0x060132A4 RID: 78500 RVA: 0x001C2FC9 File Offset: 0x001C11C9
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TWeakObjectPtr<AActor>> UntrackedOutputs
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TWeakObjectPtr<AActor>> result;
				if ((result = this._UntrackedOutputs) == null)
				{
					result = (this._UntrackedOutputs = new TArray<TWeakObjectPtr<AActor>>(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_UntrackedOutputs, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.UntrackedOutputs.CopyAssign(value);
			}
		}

		// Token: 0x17004A93 RID: 19091
		// (get) Token: 0x060132A5 RID: 78501 RVA: 0x001C2FD8 File Offset: 0x001C11D8
		// (set) Token: 0x060132A6 RID: 78502 RVA: 0x001C3011 File Offset: 0x001C1211
		public TArray<UHoudiniHandleComponent> HandleComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UHoudiniHandleComponent> result;
				if ((result = this._HandleComponents) == null)
				{
					result = (this._HandleComponents = new TArray<UHoudiniHandleComponent>(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_HandleComponents, this));
				}
				return result;
			}
			set
			{
				this.HandleComponents.CopyAssign(value);
			}
		}

		// Token: 0x17004A94 RID: 19092
		// (get) Token: 0x060132A7 RID: 78503 RVA: 0x001C301F File Offset: 0x001C121F
		// (set) Token: 0x060132A8 RID: 78504 RVA: 0x001C302F File Offset: 0x001C122F
		public unsafe bool bHasComponentTransformChanged
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bHasComponentTransformChanged) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bHasComponentTransformChanged) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A95 RID: 19093
		// (get) Token: 0x060132A9 RID: 78505 RVA: 0x001C3040 File Offset: 0x001C1240
		// (set) Token: 0x060132AA RID: 78506 RVA: 0x001C3050 File Offset: 0x001C1250
		public unsafe bool bFullyLoaded
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bFullyLoaded) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bFullyLoaded) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A96 RID: 19094
		// (get) Token: 0x060132AB RID: 78507 RVA: 0x001C3061 File Offset: 0x001C1261
		// (set) Token: 0x060132AC RID: 78508 RVA: 0x001C3075 File Offset: 0x001C1275
		[Nullable(2)]
		public unsafe UHoudiniPDGAssetLink PDGAssetLink
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UHoudiniPDGAssetLink>(base.NativePtr / (IntPtr)sizeof(void*) + UHoudiniAssetComponent.__PropertyOffset_PDGAssetLink);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UHoudiniAssetComponent.__PropertyOffset_PDGAssetLink, value);
			}
		}

		// Token: 0x17004A97 RID: 19095
		// (get) Token: 0x060132AD RID: 78509 RVA: 0x001C308C File Offset: 0x001C128C
		// (set) Token: 0x060132AE RID: 78510 RVA: 0x001C30C5 File Offset: 0x001C12C5
		public FTimerHandle RefineMeshesTimer
		{
			get
			{
				base.FastCheckIsValid();
				FTimerHandle result;
				if ((result = this._RefineMeshesTimer) == null)
				{
					result = (this._RefineMeshesTimer = new FTimerHandle(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_RefineMeshesTimer, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTimerHandle.StaticStruct(), base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_RefineMeshesTimer, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004A98 RID: 19096
		// (get) Token: 0x060132AF RID: 78511 RVA: 0x001C30E6 File Offset: 0x001C12E6
		// (set) Token: 0x060132B0 RID: 78512 RVA: 0x001C30F6 File Offset: 0x001C12F6
		public unsafe bool bNoProxyMeshNextCookRequested
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bNoProxyMeshNextCookRequested) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bNoProxyMeshNextCookRequested) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A99 RID: 19097
		// (get) Token: 0x060132B1 RID: 78513 RVA: 0x001C3108 File Offset: 0x001C1308
		// (set) Token: 0x060132B2 RID: 78514 RVA: 0x001C3141 File Offset: 0x001C1341
		public TMap<UObject, int> InputPresets
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UObject, int> result;
				if ((result = this._InputPresets) == null)
				{
					result = (this._InputPresets = new TMap<UObject, int>(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_InputPresets, this));
				}
				return result;
			}
			set
			{
				this.InputPresets.CopyAssign(value);
			}
		}

		// Token: 0x17004A9A RID: 19098
		// (get) Token: 0x060132B3 RID: 78515 RVA: 0x001C314F File Offset: 0x001C134F
		// (set) Token: 0x060132B4 RID: 78516 RVA: 0x001C315F File Offset: 0x001C135F
		public unsafe bool bBakeAfterNextCook
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bBakeAfterNextCook) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bBakeAfterNextCook) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A9B RID: 19099
		// (get) Token: 0x060132B5 RID: 78517 RVA: 0x001C3170 File Offset: 0x001C1370
		// (set) Token: 0x060132B6 RID: 78518 RVA: 0x001C3180 File Offset: 0x001C1380
		public unsafe bool bCachedIsPreview
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bCachedIsPreview) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bCachedIsPreview) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A9C RID: 19100
		// (get) Token: 0x060132B7 RID: 78519 RVA: 0x001C3191 File Offset: 0x001C1391
		// (set) Token: 0x060132B8 RID: 78520 RVA: 0x001C31A1 File Offset: 0x001C13A1
		public unsafe double LastTickTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_LastTickTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_LastTickTime) = value;
			}
		}

		// Token: 0x17004A9D RID: 19101
		// (get) Token: 0x060132B9 RID: 78521 RVA: 0x001C31B2 File Offset: 0x001C13B2
		// (set) Token: 0x060132BA RID: 78522 RVA: 0x001C31C2 File Offset: 0x001C13C2
		public unsafe EHoudiniPCGToolType PCGToolType
		{
			get
			{
				return (EHoudiniPCGToolType)(*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_PCGToolType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_PCGToolType) = (byte)value;
			}
		}

		// Token: 0x17004A9E RID: 19102
		// (get) Token: 0x060132BB RID: 78523 RVA: 0x001C31D3 File Offset: 0x001C13D3
		// (set) Token: 0x060132BC RID: 78524 RVA: 0x001C31E3 File Offset: 0x001C13E3
		public unsafe bool bPCGToolGenerateMenuExpanded
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bPCGToolGenerateMenuExpanded) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniAssetComponent.__PropertyOffset_bPCGToolGenerateMenuExpanded) = (value ? 1 : 0);
			}
		}

		// Token: 0x060132BD RID: 78525 RVA: 0x001C31F4 File Offset: 0x001C13F4
		static UHoudiniAssetComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniAssetComponent");
		}

		// Token: 0x060132BE RID: 78526 RVA: 0x001C3202 File Offset: 0x001C1402
		protected UHoudiniAssetComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A552 RID: 42322
		internal static int __InterfaceOffset_IHoudiniAssetStateEvents;

		// Token: 0x0400A553 RID: 42323
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniAssetComponent";

		// Token: 0x0400A554 RID: 42324
		private static IntPtr _ClassPtr;

		// Token: 0x0400A555 RID: 42325
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A556 RID: 42326
		internal static int __PropertyOffset_HoudiniAsset;

		// Token: 0x0400A557 RID: 42327
		internal static int __PropertyOffset_bCookOnParameterChange;

		// Token: 0x0400A558 RID: 42328
		internal static int __PropertyOffset_bUploadTransformsToHoudiniEngine;

		// Token: 0x0400A559 RID: 42329
		internal static int __PropertyOffset_bCookOnTransformChange;

		// Token: 0x0400A55A RID: 42330
		internal static int __PropertyOffset_bCookOnAssetInputCook;

		// Token: 0x0400A55B RID: 42331
		internal static int __PropertyOffset_bOutputless;

		// Token: 0x0400A55C RID: 42332
		internal static int __PropertyOffset_bOutputTemplateGeos;

		// Token: 0x0400A55D RID: 42333
		internal static int __PropertyOffset_bUseOutputNodes;

		// Token: 0x0400A55E RID: 42334
		internal static int __PropertyOffset_TemporaryCookFolder;

		// Token: 0x0400A55F RID: 42335
		[Nullable(2)]
		private FDirectoryPath _TemporaryCookFolder;

		// Token: 0x0400A560 RID: 42336
		internal static int __PropertyOffset_BakeFolder;

		// Token: 0x0400A561 RID: 42337
		[Nullable(2)]
		private FDirectoryPath _BakeFolder;

		// Token: 0x0400A562 RID: 42338
		internal static int __PropertyOffset_StaticMeshMethod;

		// Token: 0x0400A563 RID: 42339
		internal static int __PropertyOffset_StaticMeshGenerationProperties;

		// Token: 0x0400A564 RID: 42340
		[Nullable(2)]
		private FHoudiniStaticMeshGenerationProperties _StaticMeshGenerationProperties;

		// Token: 0x0400A565 RID: 42341
		internal static int __PropertyOffset_StaticMeshBuildSettings;

		// Token: 0x0400A566 RID: 42342
		[Nullable(2)]
		private FMeshBuildSettings _StaticMeshBuildSettings;

		// Token: 0x0400A567 RID: 42343
		internal static int __PropertyOffset_bOverrideGlobalProxyStaticMeshSettings;

		// Token: 0x0400A568 RID: 42344
		internal static int __PropertyOffset_bEnableProxyStaticMeshOverride;

		// Token: 0x0400A569 RID: 42345
		internal static int __PropertyOffset_bEnableProxyStaticMeshRefinementByTimerOverride;

		// Token: 0x0400A56A RID: 42346
		internal static int __PropertyOffset_ProxyMeshAutoRefineTimeoutSecondsOverride;

		// Token: 0x0400A56B RID: 42347
		internal static int __PropertyOffset_bEnableProxyStaticMeshRefinementOnPreSaveWorldOverride;

		// Token: 0x0400A56C RID: 42348
		internal static int __PropertyOffset_bEnableProxyStaticMeshRefinementOnPreBeginPIEOverride;

		// Token: 0x0400A56D RID: 42349
		internal static int __PropertyOffset_AssetId;

		// Token: 0x0400A56E RID: 42350
		internal static int __PropertyOffset_NodeIdsToCook;

		// Token: 0x0400A56F RID: 42351
		[Nullable(2)]
		private TArray<int> _NodeIdsToCook;

		// Token: 0x0400A570 RID: 42352
		internal static int __PropertyOffset_OutputNodeCookCounts;

		// Token: 0x0400A571 RID: 42353
		[Nullable(2)]
		private TMap<int, int> _OutputNodeCookCounts;

		// Token: 0x0400A572 RID: 42354
		internal static int __PropertyOffset_DownstreamHoudiniAssets;

		// Token: 0x0400A573 RID: 42355
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UHoudiniAssetComponent> _DownstreamHoudiniAssets;

		// Token: 0x0400A574 RID: 42356
		internal static int __PropertyOffset_ComponentGUID;

		// Token: 0x0400A575 RID: 42357
		internal static int __PropertyOffset_HapiGUID;

		// Token: 0x0400A576 RID: 42358
		internal static int __PropertyOffset_HapiAssetName;

		// Token: 0x0400A577 RID: 42359
		internal static int __PropertyOffset_AssetState;

		// Token: 0x0400A578 RID: 42360
		internal static int __PropertyOffset_DebugLastAssetState;

		// Token: 0x0400A579 RID: 42361
		internal static int __PropertyOffset_AssetStateResult;

		// Token: 0x0400A57A RID: 42362
		internal static int __PropertyOffset_LastComponentTransform;

		// Token: 0x0400A57B RID: 42363
		internal static int __PropertyOffset_SubAssetIndex;

		// Token: 0x0400A57C RID: 42364
		internal static int __PropertyOffset_AssetCookCount;

		// Token: 0x0400A57D RID: 42365
		internal static int __PropertyOffset_bHasBeenLoaded;

		// Token: 0x0400A57E RID: 42366
		internal static int __PropertyOffset_bHasBeenDuplicated;

		// Token: 0x0400A57F RID: 42367
		internal static int __PropertyOffset_bPendingDelete;

		// Token: 0x0400A580 RID: 42368
		internal static int __PropertyOffset_bRecookRequested;

		// Token: 0x0400A581 RID: 42369
		internal static int __PropertyOffset_bRebuildRequested;

		// Token: 0x0400A582 RID: 42370
		internal static int __PropertyOffset_bEnableCooking;

		// Token: 0x0400A583 RID: 42371
		internal static int __PropertyOffset_bForceNeedUpdate;

		// Token: 0x0400A584 RID: 42372
		internal static int __PropertyOffset_bLastCookSuccess;

		// Token: 0x0400A585 RID: 42373
		internal static int __PropertyOffset_bParameterDefinitionUpdateNeeded;

		// Token: 0x0400A586 RID: 42374
		internal static int __PropertyOffset_bBlueprintStructureModified;

		// Token: 0x0400A587 RID: 42375
		internal static int __PropertyOffset_bBlueprintModified;

		// Token: 0x0400A588 RID: 42376
		internal static int __PropertyOffset_Parameters;

		// Token: 0x0400A589 RID: 42377
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UHoudiniParameter> _Parameters;

		// Token: 0x0400A58A RID: 42378
		internal static int __PropertyOffset_Inputs;

		// Token: 0x0400A58B RID: 42379
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UHoudiniInput> _Inputs;

		// Token: 0x0400A58C RID: 42380
		internal static int __PropertyOffset_Outputs;

		// Token: 0x0400A58D RID: 42381
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UHoudiniOutput> _Outputs;

		// Token: 0x0400A58E RID: 42382
		internal static int __PropertyOffset_BakedOutputs;

		// Token: 0x0400A58F RID: 42383
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FHoudiniBakedOutput> _BakedOutputs;

		// Token: 0x0400A590 RID: 42384
		internal static int __PropertyOffset_UntrackedOutputs;

		// Token: 0x0400A591 RID: 42385
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<AActor>> _UntrackedOutputs;

		// Token: 0x0400A592 RID: 42386
		internal static int __PropertyOffset_HandleComponents;

		// Token: 0x0400A593 RID: 42387
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UHoudiniHandleComponent> _HandleComponents;

		// Token: 0x0400A594 RID: 42388
		internal static int __PropertyOffset_bHasComponentTransformChanged;

		// Token: 0x0400A595 RID: 42389
		internal static int __PropertyOffset_bFullyLoaded;

		// Token: 0x0400A596 RID: 42390
		internal static int __PropertyOffset_PDGAssetLink;

		// Token: 0x0400A597 RID: 42391
		internal static int __PropertyOffset_RefineMeshesTimer;

		// Token: 0x0400A598 RID: 42392
		[Nullable(2)]
		private FTimerHandle _RefineMeshesTimer;

		// Token: 0x0400A599 RID: 42393
		internal static int __PropertyOffset_bNoProxyMeshNextCookRequested;

		// Token: 0x0400A59A RID: 42394
		internal static int __PropertyOffset_InputPresets;

		// Token: 0x0400A59B RID: 42395
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<UObject, int> _InputPresets;

		// Token: 0x0400A59C RID: 42396
		internal static int __PropertyOffset_bBakeAfterNextCook;

		// Token: 0x0400A59D RID: 42397
		internal static int __PropertyOffset_bCachedIsPreview;

		// Token: 0x0400A59E RID: 42398
		internal static int __PropertyOffset_LastTickTime;

		// Token: 0x0400A59F RID: 42399
		internal static int __PropertyOffset_PCGToolType;

		// Token: 0x0400A5A0 RID: 42400
		internal static int __PropertyOffset_bPCGToolGenerateMenuExpanded;
	}
}
