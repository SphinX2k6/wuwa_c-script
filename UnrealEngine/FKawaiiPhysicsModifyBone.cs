using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015D7 RID: 5591
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KawaiiPhysics.KawaiiPhysicsModifyBone")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 480)]
	public class FKawaiiPhysicsModifyBone : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014278 RID: 82552 RVA: 0x001D9A6A File Offset: 0x001D7C6A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKawaiiPhysicsModifyBone._ScriptStructPtr != 0) ? FKawaiiPhysicsModifyBone._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KawaiiPhysics.KawaiiPhysicsModifyBone", ref FKawaiiPhysicsModifyBone._ScriptStructPtr);
		}

		// Token: 0x17004F04 RID: 20228
		// (get) Token: 0x06014279 RID: 82553 RVA: 0x001D9A90 File Offset: 0x001D7C90
		// (set) Token: 0x0601427A RID: 82554 RVA: 0x001D9AD3 File Offset: 0x001D7CD3
		public FBoneReference BoneRef
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._BoneRef) == null)
				{
					result = (this._BoneRef = new FBoneReference(base.NativePtr + (IntPtr)FKawaiiPhysicsModifyBone.__PropertyOffset_BoneRef, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FKawaiiPhysicsModifyBone.__PropertyOffset_BoneRef, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004F05 RID: 20229
		// (get) Token: 0x0601427B RID: 82555 RVA: 0x001D9AF4 File Offset: 0x001D7CF4
		// (set) Token: 0x0601427C RID: 82556 RVA: 0x001D9B04 File Offset: 0x001D7D04
		public unsafe int ParentIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKawaiiPhysicsModifyBone.__PropertyOffset_ParentIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKawaiiPhysicsModifyBone.__PropertyOffset_ParentIndex) = value;
			}
		}

		// Token: 0x17004F06 RID: 20230
		// (get) Token: 0x0601427D RID: 82557 RVA: 0x001D9B18 File Offset: 0x001D7D18
		// (set) Token: 0x0601427E RID: 82558 RVA: 0x001D9B5B File Offset: 0x001D7D5B
		public TArray<int> ChildIndexs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._ChildIndexs) == null)
				{
					result = (this._ChildIndexs = new TArray<int>(base.NativePtr + (IntPtr)FKawaiiPhysicsModifyBone.__PropertyOffset_ChildIndexs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ChildIndexs.CopyAssign(value);
			}
		}

		// Token: 0x17004F07 RID: 20231
		// (get) Token: 0x0601427F RID: 82559 RVA: 0x001D9B6C File Offset: 0x001D7D6C
		// (set) Token: 0x06014280 RID: 82560 RVA: 0x001D9BAF File Offset: 0x001D7DAF
		public FKawaiiPhysicsSettings PhysicsSettings
		{
			get
			{
				base.FastCheckIsValid();
				FKawaiiPhysicsSettings result;
				if ((result = this._PhysicsSettings) == null)
				{
					result = (this._PhysicsSettings = new FKawaiiPhysicsSettings(base.NativePtr + (IntPtr)FKawaiiPhysicsModifyBone.__PropertyOffset_PhysicsSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKawaiiPhysicsSettings.StaticStruct(), base.NativePtr + (IntPtr)FKawaiiPhysicsModifyBone.__PropertyOffset_PhysicsSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004F08 RID: 20232
		// (get) Token: 0x06014281 RID: 82561 RVA: 0x001D9BD0 File Offset: 0x001D7DD0
		// (set) Token: 0x06014282 RID: 82562 RVA: 0x001D9BE4 File Offset: 0x001D7DE4
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKawaiiPhysicsModifyBone.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKawaiiPhysicsModifyBone.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x17004F09 RID: 20233
		// (get) Token: 0x06014283 RID: 82563 RVA: 0x001D9BF9 File Offset: 0x001D7DF9
		// (set) Token: 0x06014284 RID: 82564 RVA: 0x001D9C0D File Offset: 0x001D7E0D
		public unsafe FVector PrevLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKawaiiPhysicsModifyBone.__PropertyOffset_PrevLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKawaiiPhysicsModifyBone.__PropertyOffset_PrevLocation) = value;
			}
		}

		// Token: 0x17004F0A RID: 20234
		// (get) Token: 0x06014285 RID: 82565 RVA: 0x001D9C22 File Offset: 0x001D7E22
		// (set) Token: 0x06014286 RID: 82566 RVA: 0x001D9C36 File Offset: 0x001D7E36
		public unsafe FQuat PrevRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKawaiiPhysicsModifyBone.__PropertyOffset_PrevRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKawaiiPhysicsModifyBone.__PropertyOffset_PrevRotation) = value;
			}
		}

		// Token: 0x17004F0B RID: 20235
		// (get) Token: 0x06014287 RID: 82567 RVA: 0x001D9C4B File Offset: 0x001D7E4B
		// (set) Token: 0x06014288 RID: 82568 RVA: 0x001D9C5F File Offset: 0x001D7E5F
		public unsafe FVector PoseLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKawaiiPhysicsModifyBone.__PropertyOffset_PoseLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKawaiiPhysicsModifyBone.__PropertyOffset_PoseLocation) = value;
			}
		}

		// Token: 0x17004F0C RID: 20236
		// (get) Token: 0x06014289 RID: 82569 RVA: 0x001D9C74 File Offset: 0x001D7E74
		// (set) Token: 0x0601428A RID: 82570 RVA: 0x001D9C88 File Offset: 0x001D7E88
		public unsafe FQuat PoseRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKawaiiPhysicsModifyBone.__PropertyOffset_PoseRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKawaiiPhysicsModifyBone.__PropertyOffset_PoseRotation) = value;
			}
		}

		// Token: 0x17004F0D RID: 20237
		// (get) Token: 0x0601428B RID: 82571 RVA: 0x001D9C9D File Offset: 0x001D7E9D
		// (set) Token: 0x0601428C RID: 82572 RVA: 0x001D9CB1 File Offset: 0x001D7EB1
		public unsafe FVector PoseScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKawaiiPhysicsModifyBone.__PropertyOffset_PoseScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKawaiiPhysicsModifyBone.__PropertyOffset_PoseScale) = value;
			}
		}

		// Token: 0x17004F0E RID: 20238
		// (get) Token: 0x0601428D RID: 82573 RVA: 0x001D9CC6 File Offset: 0x001D7EC6
		// (set) Token: 0x0601428E RID: 82574 RVA: 0x001D9CD6 File Offset: 0x001D7ED6
		public unsafe float LengthFromRoot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKawaiiPhysicsModifyBone.__PropertyOffset_LengthFromRoot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKawaiiPhysicsModifyBone.__PropertyOffset_LengthFromRoot) = value;
			}
		}

		// Token: 0x17004F0F RID: 20239
		// (get) Token: 0x0601428F RID: 82575 RVA: 0x001D9CE7 File Offset: 0x001D7EE7
		// (set) Token: 0x06014290 RID: 82576 RVA: 0x001D9CF7 File Offset: 0x001D7EF7
		public unsafe bool bDummy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKawaiiPhysicsModifyBone.__PropertyOffset_bDummy) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKawaiiPhysicsModifyBone.__PropertyOffset_bDummy) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F10 RID: 20240
		// (get) Token: 0x06014291 RID: 82577 RVA: 0x001D9D08 File Offset: 0x001D7F08
		// (set) Token: 0x06014292 RID: 82578 RVA: 0x001D9D1C File Offset: 0x001D7F1C
		public unsafe FVector PrevBasePosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKawaiiPhysicsModifyBone.__PropertyOffset_PrevBasePosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKawaiiPhysicsModifyBone.__PropertyOffset_PrevBasePosition) = value;
			}
		}

		// Token: 0x17004F11 RID: 20241
		// (get) Token: 0x06014293 RID: 82579 RVA: 0x001D9D31 File Offset: 0x001D7F31
		// (set) Token: 0x06014294 RID: 82580 RVA: 0x001D9D41 File Offset: 0x001D7F41
		public unsafe float WindCurveRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKawaiiPhysicsModifyBone.__PropertyOffset_WindCurveRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKawaiiPhysicsModifyBone.__PropertyOffset_WindCurveRate) = value;
			}
		}

		// Token: 0x17004F12 RID: 20242
		// (get) Token: 0x06014295 RID: 82581 RVA: 0x001D9D54 File Offset: 0x001D7F54
		// (set) Token: 0x06014296 RID: 82582 RVA: 0x001D9D97 File Offset: 0x001D7F97
		public TMap<int, float> WeightsMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, float> result;
				if ((result = this._WeightsMap) == null)
				{
					result = (this._WeightsMap = new TMap<int, float>(base.NativePtr + (IntPtr)FKawaiiPhysicsModifyBone.__PropertyOffset_WeightsMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.WeightsMap.CopyAssign(value);
			}
		}

		// Token: 0x17004F13 RID: 20243
		// (get) Token: 0x06014297 RID: 82583 RVA: 0x001D9DA5 File Offset: 0x001D7FA5
		// (set) Token: 0x06014298 RID: 82584 RVA: 0x001D9DB5 File Offset: 0x001D7FB5
		public unsafe float SumWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKawaiiPhysicsModifyBone.__PropertyOffset_SumWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKawaiiPhysicsModifyBone.__PropertyOffset_SumWeight) = value;
			}
		}

		// Token: 0x17004F14 RID: 20244
		// (get) Token: 0x06014299 RID: 82585 RVA: 0x001D9DC8 File Offset: 0x001D7FC8
		// (set) Token: 0x0601429A RID: 82586 RVA: 0x001D9E0B File Offset: 0x001D800B
		public TMap<int, float> PoseLocationLengthsMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, float> result;
				if ((result = this._PoseLocationLengthsMap) == null)
				{
					result = (this._PoseLocationLengthsMap = new TMap<int, float>(base.NativePtr + (IntPtr)FKawaiiPhysicsModifyBone.__PropertyOffset_PoseLocationLengthsMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PoseLocationLengthsMap.CopyAssign(value);
			}
		}

		// Token: 0x17004F15 RID: 20245
		// (get) Token: 0x0601429B RID: 82587 RVA: 0x001D9E19 File Offset: 0x001D8019
		// (set) Token: 0x0601429C RID: 82588 RVA: 0x001D9E29 File Offset: 0x001D8029
		public unsafe int LevelIdx
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKawaiiPhysicsModifyBone.__PropertyOffset_LevelIdx);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKawaiiPhysicsModifyBone.__PropertyOffset_LevelIdx) = value;
			}
		}

		// Token: 0x0601429D RID: 82589 RVA: 0x001D9E3A File Offset: 0x001D803A
		public FKawaiiPhysicsModifyBone()
		{
		}

		// Token: 0x0601429E RID: 82590 RVA: 0x001D9E44 File Offset: 0x001D8044
		public FKawaiiPhysicsModifyBone(FBoneReference BoneRef, int ParentIndex, TArray<int> ChildIndexs, FKawaiiPhysicsSettings PhysicsSettings, FVector Location, FVector PrevLocation, FQuat PrevRotation, FVector PoseLocation, FQuat PoseRotation, FVector PoseScale, float LengthFromRoot, bool bDummy, FVector PrevBasePosition, float WindCurveRate, TMap<int, float> WeightsMap, float SumWeight, TMap<int, float> PoseLocationLengthsMap, int LevelIdx, bool bDebugCollided, TArray<FKawaiiDebugDrawSphere> DebugDrawSpheres, TArray<FKawaiiDebugDrawLine> DebugDrawLines)
		{
			this.BoneRef = BoneRef;
			this.ParentIndex = ParentIndex;
			this.ChildIndexs = ChildIndexs;
			this.PhysicsSettings = PhysicsSettings;
			this.Location = Location;
			this.PrevLocation = PrevLocation;
			this.PrevRotation = PrevRotation;
			this.PoseLocation = PoseLocation;
			this.PoseRotation = PoseRotation;
			this.PoseScale = PoseScale;
			this.LengthFromRoot = LengthFromRoot;
			this.bDummy = bDummy;
			this.PrevBasePosition = PrevBasePosition;
			this.WindCurveRate = WindCurveRate;
			this.WeightsMap = WeightsMap;
			this.SumWeight = SumWeight;
			this.PoseLocationLengthsMap = PoseLocationLengthsMap;
			this.LevelIdx = LevelIdx;
		}

		// Token: 0x0601429F RID: 82591 RVA: 0x001D9EE4 File Offset: 0x001D80E4
		protected override IntPtr GetUStructPtr()
		{
			return FKawaiiPhysicsModifyBone.StaticStruct();
		}

		// Token: 0x060142A0 RID: 82592 RVA: 0x001D9EF0 File Offset: 0x001D80F0
		[NullableContext(2)]
		public FKawaiiPhysicsModifyBone(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060142A1 RID: 82593 RVA: 0x001D9EFA File Offset: 0x001D80FA
		public FKawaiiPhysicsModifyBone(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060142A2 RID: 82594 RVA: 0x001D9F05 File Offset: 0x001D8105
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKawaiiPhysicsModifyBone(Pointer, false, true);
		}

		// Token: 0x060142A3 RID: 82595 RVA: 0x001D9F0F File Offset: 0x001D810F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKawaiiPhysicsModifyBone(Pointer, MemoryOwner);
		}

		// Token: 0x0400AF66 RID: 44902
		public const string __ObjectPath = "/Script/KawaiiPhysics.KawaiiPhysicsModifyBone";

		// Token: 0x0400AF67 RID: 44903
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400AF68 RID: 44904
		internal static int __PropertyOffset_BoneRef;

		// Token: 0x0400AF69 RID: 44905
		[Nullable(2)]
		private FBoneReference _BoneRef;

		// Token: 0x0400AF6A RID: 44906
		internal static int __PropertyOffset_ParentIndex;

		// Token: 0x0400AF6B RID: 44907
		internal static int __PropertyOffset_ChildIndexs;

		// Token: 0x0400AF6C RID: 44908
		[Nullable(2)]
		private TArray<int> _ChildIndexs;

		// Token: 0x0400AF6D RID: 44909
		internal static int __PropertyOffset_PhysicsSettings;

		// Token: 0x0400AF6E RID: 44910
		[Nullable(2)]
		private FKawaiiPhysicsSettings _PhysicsSettings;

		// Token: 0x0400AF6F RID: 44911
		internal static int __PropertyOffset_Location;

		// Token: 0x0400AF70 RID: 44912
		internal static int __PropertyOffset_PrevLocation;

		// Token: 0x0400AF71 RID: 44913
		internal static int __PropertyOffset_PrevRotation;

		// Token: 0x0400AF72 RID: 44914
		internal static int __PropertyOffset_PoseLocation;

		// Token: 0x0400AF73 RID: 44915
		internal static int __PropertyOffset_PoseRotation;

		// Token: 0x0400AF74 RID: 44916
		internal static int __PropertyOffset_PoseScale;

		// Token: 0x0400AF75 RID: 44917
		internal static int __PropertyOffset_LengthFromRoot;

		// Token: 0x0400AF76 RID: 44918
		internal static int __PropertyOffset_bDummy;

		// Token: 0x0400AF77 RID: 44919
		internal static int __PropertyOffset_PrevBasePosition;

		// Token: 0x0400AF78 RID: 44920
		internal static int __PropertyOffset_WindCurveRate;

		// Token: 0x0400AF79 RID: 44921
		internal static int __PropertyOffset_WeightsMap;

		// Token: 0x0400AF7A RID: 44922
		[Nullable(2)]
		private TMap<int, float> _WeightsMap;

		// Token: 0x0400AF7B RID: 44923
		internal static int __PropertyOffset_SumWeight;

		// Token: 0x0400AF7C RID: 44924
		internal static int __PropertyOffset_PoseLocationLengthsMap;

		// Token: 0x0400AF7D RID: 44925
		[Nullable(2)]
		private TMap<int, float> _PoseLocationLengthsMap;

		// Token: 0x0400AF7E RID: 44926
		internal static int __PropertyOffset_LevelIdx;
	}
}
