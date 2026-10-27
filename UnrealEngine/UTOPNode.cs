using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200150B RID: 5387
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.TOPNode")]
	[UnrealStructLayout(1072, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class UTOPNode : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013994 RID: 80276 RVA: 0x001CC8F2 File Offset: 0x001CAAF2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTOPNode._ClassPtr;
		}

		// Token: 0x06013995 RID: 80277 RVA: 0x001CC900 File Offset: 0x001CAB00
		public UTOPNode() : this(BuiltinUtils.AllocNativeUObject(UTOPNode.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013996 RID: 80278 RVA: 0x001CC928 File Offset: 0x001CAB28
		public UTOPNode(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTOPNode.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004CC1 RID: 19649
		// (get) Token: 0x06013997 RID: 80279 RVA: 0x001CC95B File Offset: 0x001CAB5B
		// (set) Token: 0x06013998 RID: 80280 RVA: 0x001CC96B File Offset: 0x001CAB6B
		public unsafe int NodeId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTOPNode.__PropertyOffset_NodeId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTOPNode.__PropertyOffset_NodeId) = value;
			}
		}

		// Token: 0x17004CC2 RID: 19650
		// (get) Token: 0x06013999 RID: 80281 RVA: 0x001CC97C File Offset: 0x001CAB7C
		// (set) Token: 0x0601399A RID: 80282 RVA: 0x001CC990 File Offset: 0x001CAB90
		public unsafe string NodeName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UTOPNode.__PropertyOffset_NodeName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UTOPNode.__PropertyOffset_NodeName)), value);
			}
		}

		// Token: 0x17004CC3 RID: 19651
		// (get) Token: 0x0601399B RID: 80283 RVA: 0x001CC9A5 File Offset: 0x001CABA5
		// (set) Token: 0x0601399C RID: 80284 RVA: 0x001CC9B9 File Offset: 0x001CABB9
		public unsafe string NodePath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UTOPNode.__PropertyOffset_NodePath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UTOPNode.__PropertyOffset_NodePath)), value);
			}
		}

		// Token: 0x17004CC4 RID: 19652
		// (get) Token: 0x0601399D RID: 80285 RVA: 0x001CC9CE File Offset: 0x001CABCE
		// (set) Token: 0x0601399E RID: 80286 RVA: 0x001CC9E2 File Offset: 0x001CABE2
		public unsafe string ParentName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UTOPNode.__PropertyOffset_ParentName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UTOPNode.__PropertyOffset_ParentName)), value);
			}
		}

		// Token: 0x17004CC5 RID: 19653
		// (get) Token: 0x0601399F RID: 80287 RVA: 0x001CC9F7 File Offset: 0x001CABF7
		// (set) Token: 0x060139A0 RID: 80288 RVA: 0x001CCA0B File Offset: 0x001CAC0B
		[Nullable(2)]
		public unsafe UObject WorkResultParent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + UTOPNode.__PropertyOffset_WorkResultParent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTOPNode.__PropertyOffset_WorkResultParent, value);
			}
		}

		// Token: 0x17004CC6 RID: 19654
		// (get) Token: 0x060139A1 RID: 80289 RVA: 0x001CCA20 File Offset: 0x001CAC20
		// (set) Token: 0x060139A2 RID: 80290 RVA: 0x001CCA59 File Offset: 0x001CAC59
		public TArray<FTOPWorkResult> WorkResult
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTOPWorkResult> result;
				if ((result = this._WorkResult) == null)
				{
					result = (this._WorkResult = new TArray<FTOPWorkResult>(base.NativePtr + (IntPtr)UTOPNode.__PropertyOffset_WorkResult, this));
				}
				return result;
			}
			set
			{
				this.WorkResult.CopyAssign(value);
			}
		}

		// Token: 0x17004CC7 RID: 19655
		// (get) Token: 0x060139A3 RID: 80291 RVA: 0x001CCA67 File Offset: 0x001CAC67
		// (set) Token: 0x060139A4 RID: 80292 RVA: 0x001CCA77 File Offset: 0x001CAC77
		public unsafe bool bHidden
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTOPNode.__PropertyOffset_bHidden) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTOPNode.__PropertyOffset_bHidden) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004CC8 RID: 19656
		// (get) Token: 0x060139A5 RID: 80293 RVA: 0x001CCA88 File Offset: 0x001CAC88
		// (set) Token: 0x060139A6 RID: 80294 RVA: 0x001CCA98 File Offset: 0x001CAC98
		public unsafe bool bAutoLoad
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTOPNode.__PropertyOffset_bAutoLoad) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTOPNode.__PropertyOffset_bAutoLoad) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004CC9 RID: 19657
		// (get) Token: 0x060139A7 RID: 80295 RVA: 0x001CCAA9 File Offset: 0x001CACA9
		// (set) Token: 0x060139A8 RID: 80296 RVA: 0x001CCAB9 File Offset: 0x001CACB9
		public unsafe EPDGNodeState NodeState
		{
			get
			{
				return (EPDGNodeState)(*(base.NativePtr + (IntPtr)UTOPNode.__PropertyOffset_NodeState));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTOPNode.__PropertyOffset_NodeState) = (byte)value;
			}
		}

		// Token: 0x17004CCA RID: 19658
		// (get) Token: 0x060139A9 RID: 80297 RVA: 0x001CCACA File Offset: 0x001CACCA
		// (set) Token: 0x060139AA RID: 80298 RVA: 0x001CCADA File Offset: 0x001CACDA
		public unsafe bool bCachedHaveNotLoadedWorkResults
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTOPNode.__PropertyOffset_bCachedHaveNotLoadedWorkResults) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTOPNode.__PropertyOffset_bCachedHaveNotLoadedWorkResults) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004CCB RID: 19659
		// (get) Token: 0x060139AB RID: 80299 RVA: 0x001CCAEB File Offset: 0x001CACEB
		// (set) Token: 0x060139AC RID: 80300 RVA: 0x001CCAFB File Offset: 0x001CACFB
		public unsafe bool bCachedHaveLoadedWorkResults
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTOPNode.__PropertyOffset_bCachedHaveLoadedWorkResults) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTOPNode.__PropertyOffset_bCachedHaveLoadedWorkResults) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004CCC RID: 19660
		// (get) Token: 0x060139AD RID: 80301 RVA: 0x001CCB0C File Offset: 0x001CAD0C
		// (set) Token: 0x060139AE RID: 80302 RVA: 0x001CCB1C File Offset: 0x001CAD1C
		public unsafe bool bHasChildNodes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTOPNode.__PropertyOffset_bHasChildNodes) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTOPNode.__PropertyOffset_bHasChildNodes) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004CCD RID: 19661
		// (get) Token: 0x060139AF RID: 80303 RVA: 0x001CCB30 File Offset: 0x001CAD30
		// (set) Token: 0x060139B0 RID: 80304 RVA: 0x001CCB69 File Offset: 0x001CAD69
		public TSet<string> ClearedLandscapeLayers
		{
			get
			{
				base.FastCheckIsValid();
				TSet<string> result;
				if ((result = this._ClearedLandscapeLayers) == null)
				{
					result = (this._ClearedLandscapeLayers = new TSet<string>(base.NativePtr + (IntPtr)UTOPNode.__PropertyOffset_ClearedLandscapeLayers, this));
				}
				return result;
			}
			set
			{
				this.ClearedLandscapeLayers.CopyAssign(value);
			}
		}

		// Token: 0x17004CCE RID: 19662
		// (get) Token: 0x060139B1 RID: 80305 RVA: 0x001CCB77 File Offset: 0x001CAD77
		// (set) Token: 0x060139B2 RID: 80306 RVA: 0x001CCB87 File Offset: 0x001CAD87
		public unsafe bool bShow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTOPNode.__PropertyOffset_bShow) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTOPNode.__PropertyOffset_bShow) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004CCF RID: 19663
		// (get) Token: 0x060139B3 RID: 80307 RVA: 0x001CCB98 File Offset: 0x001CAD98
		// (set) Token: 0x060139B4 RID: 80308 RVA: 0x001CCBD1 File Offset: 0x001CADD1
		public TMap<string, FHoudiniPDGWorkResultObjectBakedOutput> BakedWorkResultObjectOutputs
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FHoudiniPDGWorkResultObjectBakedOutput> result;
				if ((result = this._BakedWorkResultObjectOutputs) == null)
				{
					result = (this._BakedWorkResultObjectOutputs = new TMap<string, FHoudiniPDGWorkResultObjectBakedOutput>(base.NativePtr + (IntPtr)UTOPNode.__PropertyOffset_BakedWorkResultObjectOutputs, this));
				}
				return result;
			}
			set
			{
				this.BakedWorkResultObjectOutputs.CopyAssign(value);
			}
		}

		// Token: 0x17004CD0 RID: 19664
		// (get) Token: 0x060139B5 RID: 80309 RVA: 0x001CCBE0 File Offset: 0x001CADE0
		// (set) Token: 0x060139B6 RID: 80310 RVA: 0x001CCC19 File Offset: 0x001CAE19
		public FWorkItemTally WorkItemTally
		{
			get
			{
				base.FastCheckIsValid();
				FWorkItemTally result;
				if ((result = this._WorkItemTally) == null)
				{
					result = (this._WorkItemTally = new FWorkItemTally(base.NativePtr + (IntPtr)UTOPNode.__PropertyOffset_WorkItemTally, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FWorkItemTally.StaticStruct(), base.NativePtr + (IntPtr)UTOPNode.__PropertyOffset_WorkItemTally, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004CD1 RID: 19665
		// (get) Token: 0x060139B7 RID: 80311 RVA: 0x001CCC3C File Offset: 0x001CAE3C
		// (set) Token: 0x060139B8 RID: 80312 RVA: 0x001CCC75 File Offset: 0x001CAE75
		public FAggregatedWorkItemTally AggregatedWorkItemTally
		{
			get
			{
				base.FastCheckIsValid();
				FAggregatedWorkItemTally result;
				if ((result = this._AggregatedWorkItemTally) == null)
				{
					result = (this._AggregatedWorkItemTally = new FAggregatedWorkItemTally(base.NativePtr + (IntPtr)UTOPNode.__PropertyOffset_AggregatedWorkItemTally, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAggregatedWorkItemTally.StaticStruct(), base.NativePtr + (IntPtr)UTOPNode.__PropertyOffset_AggregatedWorkItemTally, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004CD2 RID: 19666
		// (get) Token: 0x060139B9 RID: 80313 RVA: 0x001CCC96 File Offset: 0x001CAE96
		// (set) Token: 0x060139BA RID: 80314 RVA: 0x001CCCA6 File Offset: 0x001CAEA6
		public unsafe bool bHasReceivedCookCompleteEvent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTOPNode.__PropertyOffset_bHasReceivedCookCompleteEvent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTOPNode.__PropertyOffset_bHasReceivedCookCompleteEvent) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004CD3 RID: 19667
		// (get) Token: 0x060139BB RID: 80315 RVA: 0x001CCCB8 File Offset: 0x001CAEB8
		// (set) Token: 0x060139BC RID: 80316 RVA: 0x001CCCF1 File Offset: 0x001CAEF1
		public FOutputActorOwner OutputActorOwner
		{
			get
			{
				base.FastCheckIsValid();
				FOutputActorOwner result;
				if ((result = this._OutputActorOwner) == null)
				{
					result = (this._OutputActorOwner = new FOutputActorOwner(base.NativePtr + (IntPtr)UTOPNode.__PropertyOffset_OutputActorOwner, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FOutputActorOwner.StaticStruct(), base.NativePtr + (IntPtr)UTOPNode.__PropertyOffset_OutputActorOwner, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060139BD RID: 80317 RVA: 0x001CCD12 File Offset: 0x001CAF12
		static UTOPNode()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.TOPNode");
		}

		// Token: 0x060139BE RID: 80318 RVA: 0x001CCD20 File Offset: 0x001CAF20
		protected UTOPNode(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A95E RID: 43358
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.TOPNode";

		// Token: 0x0400A95F RID: 43359
		private static IntPtr _ClassPtr;

		// Token: 0x0400A960 RID: 43360
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A961 RID: 43361
		internal static int __PropertyOffset_NodeId;

		// Token: 0x0400A962 RID: 43362
		internal static int __PropertyOffset_NodeName;

		// Token: 0x0400A963 RID: 43363
		internal static int __PropertyOffset_NodePath;

		// Token: 0x0400A964 RID: 43364
		internal static int __PropertyOffset_ParentName;

		// Token: 0x0400A965 RID: 43365
		internal static int __PropertyOffset_WorkResultParent;

		// Token: 0x0400A966 RID: 43366
		internal static int __PropertyOffset_WorkResult;

		// Token: 0x0400A967 RID: 43367
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FTOPWorkResult> _WorkResult;

		// Token: 0x0400A968 RID: 43368
		internal static int __PropertyOffset_bHidden;

		// Token: 0x0400A969 RID: 43369
		internal static int __PropertyOffset_bAutoLoad;

		// Token: 0x0400A96A RID: 43370
		internal static int __PropertyOffset_NodeState;

		// Token: 0x0400A96B RID: 43371
		internal static int __PropertyOffset_bCachedHaveNotLoadedWorkResults;

		// Token: 0x0400A96C RID: 43372
		internal static int __PropertyOffset_bCachedHaveLoadedWorkResults;

		// Token: 0x0400A96D RID: 43373
		internal static int __PropertyOffset_bHasChildNodes;

		// Token: 0x0400A96E RID: 43374
		internal static int __PropertyOffset_ClearedLandscapeLayers;

		// Token: 0x0400A96F RID: 43375
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<string> _ClearedLandscapeLayers;

		// Token: 0x0400A970 RID: 43376
		internal static int __PropertyOffset_bShow;

		// Token: 0x0400A971 RID: 43377
		internal static int __PropertyOffset_BakedWorkResultObjectOutputs;

		// Token: 0x0400A972 RID: 43378
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, FHoudiniPDGWorkResultObjectBakedOutput> _BakedWorkResultObjectOutputs;

		// Token: 0x0400A973 RID: 43379
		internal static int __PropertyOffset_WorkItemTally;

		// Token: 0x0400A974 RID: 43380
		[Nullable(2)]
		private FWorkItemTally _WorkItemTally;

		// Token: 0x0400A975 RID: 43381
		internal static int __PropertyOffset_AggregatedWorkItemTally;

		// Token: 0x0400A976 RID: 43382
		[Nullable(2)]
		private FAggregatedWorkItemTally _AggregatedWorkItemTally;

		// Token: 0x0400A977 RID: 43383
		internal static int __PropertyOffset_bHasReceivedCookCompleteEvent;

		// Token: 0x0400A978 RID: 43384
		internal static int __PropertyOffset_OutputActorOwner;

		// Token: 0x0400A979 RID: 43385
		[Nullable(2)]
		private FOutputActorOwner _OutputActorOwner;
	}
}
