using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014A2 RID: 5282
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniAssetBlueprintInstanceData")]
	[UnrealStructLayout(288, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 288)]
	public class FHoudiniAssetBlueprintInstanceData : FActorComponentInstanceData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06013207 RID: 78343 RVA: 0x001C21A9 File Offset: 0x001C03A9
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHoudiniAssetBlueprintInstanceData._ScriptStructPtr != 0) ? FHoudiniAssetBlueprintInstanceData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/HoudiniEngineRuntime.HoudiniAssetBlueprintInstanceData", ref FHoudiniAssetBlueprintInstanceData._ScriptStructPtr);
		}

		// Token: 0x17004A4E RID: 19022
		// (get) Token: 0x06013208 RID: 78344 RVA: 0x001C21CD File Offset: 0x001C03CD
		// (set) Token: 0x06013209 RID: 78345 RVA: 0x001C21E1 File Offset: 0x001C03E1
		[Nullable(2)]
		public unsafe UHoudiniAsset HoudiniAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UHoudiniAsset>(base.NativePtr / (IntPtr)sizeof(void*) + FHoudiniAssetBlueprintInstanceData.__PropertyOffset_HoudiniAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FHoudiniAssetBlueprintInstanceData.__PropertyOffset_HoudiniAsset, value);
			}
		}

		// Token: 0x17004A4F RID: 19023
		// (get) Token: 0x0601320A RID: 78346 RVA: 0x001C21F6 File Offset: 0x001C03F6
		// (set) Token: 0x0601320B RID: 78347 RVA: 0x001C2206 File Offset: 0x001C0406
		public unsafe int AssetId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniAssetBlueprintInstanceData.__PropertyOffset_AssetId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniAssetBlueprintInstanceData.__PropertyOffset_AssetId) = value;
			}
		}

		// Token: 0x17004A50 RID: 19024
		// (get) Token: 0x0601320C RID: 78348 RVA: 0x001C2217 File Offset: 0x001C0417
		// (set) Token: 0x0601320D RID: 78349 RVA: 0x001C2227 File Offset: 0x001C0427
		public unsafe EHoudiniAssetState AssetState
		{
			get
			{
				return (EHoudiniAssetState)(*(base.NativePtr + (IntPtr)FHoudiniAssetBlueprintInstanceData.__PropertyOffset_AssetState));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniAssetBlueprintInstanceData.__PropertyOffset_AssetState) = (byte)value;
			}
		}

		// Token: 0x17004A51 RID: 19025
		// (get) Token: 0x0601320E RID: 78350 RVA: 0x001C2238 File Offset: 0x001C0438
		// (set) Token: 0x0601320F RID: 78351 RVA: 0x001C2248 File Offset: 0x001C0448
		public unsafe uint SubAssetIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniAssetBlueprintInstanceData.__PropertyOffset_SubAssetIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniAssetBlueprintInstanceData.__PropertyOffset_SubAssetIndex) = (int)value;
			}
		}

		// Token: 0x17004A52 RID: 19026
		// (get) Token: 0x06013210 RID: 78352 RVA: 0x001C2259 File Offset: 0x001C0459
		// (set) Token: 0x06013211 RID: 78353 RVA: 0x001C2269 File Offset: 0x001C0469
		public unsafe uint AssetCookCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniAssetBlueprintInstanceData.__PropertyOffset_AssetCookCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniAssetBlueprintInstanceData.__PropertyOffset_AssetCookCount) = (int)value;
			}
		}

		// Token: 0x17004A53 RID: 19027
		// (get) Token: 0x06013212 RID: 78354 RVA: 0x001C227A File Offset: 0x001C047A
		// (set) Token: 0x06013213 RID: 78355 RVA: 0x001C228A File Offset: 0x001C048A
		public unsafe bool bHasBeenLoaded
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniAssetBlueprintInstanceData.__PropertyOffset_bHasBeenLoaded) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniAssetBlueprintInstanceData.__PropertyOffset_bHasBeenLoaded) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A54 RID: 19028
		// (get) Token: 0x06013214 RID: 78356 RVA: 0x001C229B File Offset: 0x001C049B
		// (set) Token: 0x06013215 RID: 78357 RVA: 0x001C22AB File Offset: 0x001C04AB
		public unsafe bool bHasBeenDuplicated
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniAssetBlueprintInstanceData.__PropertyOffset_bHasBeenDuplicated) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniAssetBlueprintInstanceData.__PropertyOffset_bHasBeenDuplicated) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A55 RID: 19029
		// (get) Token: 0x06013216 RID: 78358 RVA: 0x001C22BC File Offset: 0x001C04BC
		// (set) Token: 0x06013217 RID: 78359 RVA: 0x001C22CC File Offset: 0x001C04CC
		public unsafe bool bPendingDelete
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniAssetBlueprintInstanceData.__PropertyOffset_bPendingDelete) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniAssetBlueprintInstanceData.__PropertyOffset_bPendingDelete) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A56 RID: 19030
		// (get) Token: 0x06013218 RID: 78360 RVA: 0x001C22DD File Offset: 0x001C04DD
		// (set) Token: 0x06013219 RID: 78361 RVA: 0x001C22ED File Offset: 0x001C04ED
		public unsafe bool bRecookRequested
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniAssetBlueprintInstanceData.__PropertyOffset_bRecookRequested) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniAssetBlueprintInstanceData.__PropertyOffset_bRecookRequested) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A57 RID: 19031
		// (get) Token: 0x0601321A RID: 78362 RVA: 0x001C22FE File Offset: 0x001C04FE
		// (set) Token: 0x0601321B RID: 78363 RVA: 0x001C230E File Offset: 0x001C050E
		public unsafe bool bRebuildRequested
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniAssetBlueprintInstanceData.__PropertyOffset_bRebuildRequested) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniAssetBlueprintInstanceData.__PropertyOffset_bRebuildRequested) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A58 RID: 19032
		// (get) Token: 0x0601321C RID: 78364 RVA: 0x001C231F File Offset: 0x001C051F
		// (set) Token: 0x0601321D RID: 78365 RVA: 0x001C232F File Offset: 0x001C052F
		public unsafe bool bEnableCooking
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniAssetBlueprintInstanceData.__PropertyOffset_bEnableCooking) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniAssetBlueprintInstanceData.__PropertyOffset_bEnableCooking) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A59 RID: 19033
		// (get) Token: 0x0601321E RID: 78366 RVA: 0x001C2340 File Offset: 0x001C0540
		// (set) Token: 0x0601321F RID: 78367 RVA: 0x001C2350 File Offset: 0x001C0550
		public unsafe bool bForceNeedUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniAssetBlueprintInstanceData.__PropertyOffset_bForceNeedUpdate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniAssetBlueprintInstanceData.__PropertyOffset_bForceNeedUpdate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A5A RID: 19034
		// (get) Token: 0x06013220 RID: 78368 RVA: 0x001C2361 File Offset: 0x001C0561
		// (set) Token: 0x06013221 RID: 78369 RVA: 0x001C2371 File Offset: 0x001C0571
		public unsafe bool bLastCookSuccess
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniAssetBlueprintInstanceData.__PropertyOffset_bLastCookSuccess) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniAssetBlueprintInstanceData.__PropertyOffset_bLastCookSuccess) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A5B RID: 19035
		// (get) Token: 0x06013222 RID: 78370 RVA: 0x001C2382 File Offset: 0x001C0582
		// (set) Token: 0x06013223 RID: 78371 RVA: 0x001C2396 File Offset: 0x001C0596
		public unsafe FGuid ComponentGUID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniAssetBlueprintInstanceData.__PropertyOffset_ComponentGUID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniAssetBlueprintInstanceData.__PropertyOffset_ComponentGUID) = value;
			}
		}

		// Token: 0x17004A5C RID: 19036
		// (get) Token: 0x06013224 RID: 78372 RVA: 0x001C23AB File Offset: 0x001C05AB
		// (set) Token: 0x06013225 RID: 78373 RVA: 0x001C23BF File Offset: 0x001C05BF
		public unsafe FGuid HapiGUID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniAssetBlueprintInstanceData.__PropertyOffset_HapiGUID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniAssetBlueprintInstanceData.__PropertyOffset_HapiGUID) = value;
			}
		}

		// Token: 0x17004A5D RID: 19037
		// (get) Token: 0x06013226 RID: 78374 RVA: 0x001C23D4 File Offset: 0x001C05D4
		// (set) Token: 0x06013227 RID: 78375 RVA: 0x001C23E4 File Offset: 0x001C05E4
		public unsafe bool bRegisteredComponentTemplate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniAssetBlueprintInstanceData.__PropertyOffset_bRegisteredComponentTemplate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniAssetBlueprintInstanceData.__PropertyOffset_bRegisteredComponentTemplate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A5E RID: 19038
		// (get) Token: 0x06013228 RID: 78376 RVA: 0x001C23F5 File Offset: 0x001C05F5
		// (set) Token: 0x06013229 RID: 78377 RVA: 0x001C2409 File Offset: 0x001C0609
		public unsafe string SourceName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FHoudiniAssetBlueprintInstanceData.__PropertyOffset_SourceName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FHoudiniAssetBlueprintInstanceData.__PropertyOffset_SourceName)), value);
			}
		}

		// Token: 0x17004A5F RID: 19039
		// (get) Token: 0x0601322A RID: 78378 RVA: 0x001C2420 File Offset: 0x001C0620
		// (set) Token: 0x0601322B RID: 78379 RVA: 0x001C2463 File Offset: 0x001C0663
		public TMap<FHoudiniOutputObjectIdentifier, FHoudiniAssetBlueprintOutput> Outputs
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FHoudiniOutputObjectIdentifier, FHoudiniAssetBlueprintOutput> result;
				if ((result = this._Outputs) == null)
				{
					result = (this._Outputs = new TMap<FHoudiniOutputObjectIdentifier, FHoudiniAssetBlueprintOutput>(base.NativePtr + (IntPtr)FHoudiniAssetBlueprintInstanceData.__PropertyOffset_Outputs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Outputs.CopyAssign(value);
			}
		}

		// Token: 0x17004A60 RID: 19040
		// (get) Token: 0x0601322C RID: 78380 RVA: 0x001C2474 File Offset: 0x001C0674
		// (set) Token: 0x0601322D RID: 78381 RVA: 0x001C24B7 File Offset: 0x001C06B7
		public TArray<UHoudiniInput> Inputs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UHoudiniInput> result;
				if ((result = this._Inputs) == null)
				{
					result = (this._Inputs = new TArray<UHoudiniInput>(base.NativePtr + (IntPtr)FHoudiniAssetBlueprintInstanceData.__PropertyOffset_Inputs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Inputs.CopyAssign(value);
			}
		}

		// Token: 0x0601322E RID: 78382 RVA: 0x001C24C5 File Offset: 0x001C06C5
		public FHoudiniAssetBlueprintInstanceData()
		{
		}

		// Token: 0x0601322F RID: 78383 RVA: 0x001C24D0 File Offset: 0x001C06D0
		public FHoudiniAssetBlueprintInstanceData(UHoudiniAsset HoudiniAsset, int AssetId, EHoudiniAssetState AssetState, uint SubAssetIndex, uint AssetCookCount, bool bHasBeenLoaded, bool bHasBeenDuplicated, bool bPendingDelete, bool bRecookRequested, bool bRebuildRequested, bool bEnableCooking, bool bForceNeedUpdate, bool bLastCookSuccess, FGuid ComponentGUID, FGuid HapiGUID, bool bRegisteredComponentTemplate, string SourceName, TMap<FHoudiniOutputObjectIdentifier, FHoudiniAssetBlueprintOutput> Outputs, TArray<UHoudiniInput> Inputs, UObject SourceComponentTemplate, EComponentCreationMethod SourceComponentCreationMethod, int SourceComponentTypeSerializedIndex, TArray<byte> SavedProperties, FActorComponentDuplicatedObjectData UniqueTransientPackage, TArray<FActorComponentDuplicatedObjectData> DuplicatedObjects, TArray<UObject> ReferencedObjects, TArray<FName> ReferencedNames)
		{
			this.HoudiniAsset = HoudiniAsset;
			this.AssetId = AssetId;
			this.AssetState = AssetState;
			this.SubAssetIndex = SubAssetIndex;
			this.AssetCookCount = AssetCookCount;
			this.bHasBeenLoaded = bHasBeenLoaded;
			this.bHasBeenDuplicated = bHasBeenDuplicated;
			this.bPendingDelete = bPendingDelete;
			this.bRecookRequested = bRecookRequested;
			this.bRebuildRequested = bRebuildRequested;
			this.bEnableCooking = bEnableCooking;
			this.bForceNeedUpdate = bForceNeedUpdate;
			this.bLastCookSuccess = bLastCookSuccess;
			this.ComponentGUID = ComponentGUID;
			this.HapiGUID = HapiGUID;
			this.bRegisteredComponentTemplate = bRegisteredComponentTemplate;
			this.SourceName = SourceName;
			this.Outputs = Outputs;
			this.Inputs = Inputs;
			base.SourceComponentTemplate = SourceComponentTemplate;
			base.SourceComponentCreationMethod = SourceComponentCreationMethod;
			base.SourceComponentTypeSerializedIndex = SourceComponentTypeSerializedIndex;
			base.SavedProperties = SavedProperties;
			base.UniqueTransientPackage = UniqueTransientPackage;
			base.DuplicatedObjects = DuplicatedObjects;
			base.ReferencedObjects = ReferencedObjects;
			base.ReferencedNames = ReferencedNames;
		}

		// Token: 0x06013230 RID: 78384 RVA: 0x001C25B8 File Offset: 0x001C07B8
		protected override IntPtr GetUStructPtr()
		{
			return FHoudiniAssetBlueprintInstanceData.StaticStruct();
		}

		// Token: 0x06013231 RID: 78385 RVA: 0x001C25C4 File Offset: 0x001C07C4
		[NullableContext(2)]
		public FHoudiniAssetBlueprintInstanceData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06013232 RID: 78386 RVA: 0x001C25CE File Offset: 0x001C07CE
		public FHoudiniAssetBlueprintInstanceData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06013233 RID: 78387 RVA: 0x001C25D9 File Offset: 0x001C07D9
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHoudiniAssetBlueprintInstanceData(Pointer, false, true);
		}

		// Token: 0x06013234 RID: 78388 RVA: 0x001C25E3 File Offset: 0x001C07E3
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHoudiniAssetBlueprintInstanceData(Pointer, MemoryOwner);
		}

		// Token: 0x0400A536 RID: 42294
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniAssetBlueprintInstanceData";

		// Token: 0x0400A537 RID: 42295
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A538 RID: 42296
		internal static int __PropertyOffset_HoudiniAsset;

		// Token: 0x0400A539 RID: 42297
		internal static int __PropertyOffset_AssetId;

		// Token: 0x0400A53A RID: 42298
		internal static int __PropertyOffset_AssetState;

		// Token: 0x0400A53B RID: 42299
		internal static int __PropertyOffset_SubAssetIndex;

		// Token: 0x0400A53C RID: 42300
		internal static int __PropertyOffset_AssetCookCount;

		// Token: 0x0400A53D RID: 42301
		internal static int __PropertyOffset_bHasBeenLoaded;

		// Token: 0x0400A53E RID: 42302
		internal static int __PropertyOffset_bHasBeenDuplicated;

		// Token: 0x0400A53F RID: 42303
		internal static int __PropertyOffset_bPendingDelete;

		// Token: 0x0400A540 RID: 42304
		internal static int __PropertyOffset_bRecookRequested;

		// Token: 0x0400A541 RID: 42305
		internal static int __PropertyOffset_bRebuildRequested;

		// Token: 0x0400A542 RID: 42306
		internal static int __PropertyOffset_bEnableCooking;

		// Token: 0x0400A543 RID: 42307
		internal static int __PropertyOffset_bForceNeedUpdate;

		// Token: 0x0400A544 RID: 42308
		internal static int __PropertyOffset_bLastCookSuccess;

		// Token: 0x0400A545 RID: 42309
		internal static int __PropertyOffset_ComponentGUID;

		// Token: 0x0400A546 RID: 42310
		internal static int __PropertyOffset_HapiGUID;

		// Token: 0x0400A547 RID: 42311
		internal static int __PropertyOffset_bRegisteredComponentTemplate;

		// Token: 0x0400A548 RID: 42312
		internal static int __PropertyOffset_SourceName;

		// Token: 0x0400A549 RID: 42313
		internal static int __PropertyOffset_Outputs;

		// Token: 0x0400A54A RID: 42314
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<FHoudiniOutputObjectIdentifier, FHoudiniAssetBlueprintOutput> _Outputs;

		// Token: 0x0400A54B RID: 42315
		internal static int __PropertyOffset_Inputs;

		// Token: 0x0400A54C RID: 42316
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UHoudiniInput> _Inputs;
	}
}
