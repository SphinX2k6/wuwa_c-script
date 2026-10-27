using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001609 RID: 5641
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.AnimNode_Feedback")]
	[UnrealStructLayout(736, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 736)]
	public class FAnimNode_Feedback : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014584 RID: 83332 RVA: 0x001DE491 File Offset: 0x001DC691
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_Feedback._ScriptStructPtr != 0) ? FAnimNode_Feedback._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.AnimNode_Feedback", ref FAnimNode_Feedback._ScriptStructPtr);
		}

		// Token: 0x17004FE0 RID: 20448
		// (get) Token: 0x06014585 RID: 83333 RVA: 0x001DE4B8 File Offset: 0x001DC6B8
		// (set) Token: 0x06014586 RID: 83334 RVA: 0x001DE4FB File Offset: 0x001DC6FB
		public FSkeletonGroup SkeletonBlockInfo
		{
			get
			{
				base.FastCheckIsValid();
				FSkeletonGroup result;
				if ((result = this._SkeletonBlockInfo) == null)
				{
					result = (this._SkeletonBlockInfo = new FSkeletonGroup(base.NativePtr + (IntPtr)FAnimNode_Feedback.__PropertyOffset_SkeletonBlockInfo, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSkeletonGroup.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_Feedback.__PropertyOffset_SkeletonBlockInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004FE1 RID: 20449
		// (get) Token: 0x06014587 RID: 83335 RVA: 0x001DE51C File Offset: 0x001DC71C
		// (set) Token: 0x06014588 RID: 83336 RVA: 0x001DE52C File Offset: 0x001DC72C
		public unsafe float DeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_Feedback.__PropertyOffset_DeltaTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_Feedback.__PropertyOffset_DeltaTime) = value;
			}
		}

		// Token: 0x17004FE2 RID: 20450
		// (get) Token: 0x06014589 RID: 83337 RVA: 0x001DE53D File Offset: 0x001DC73D
		// (set) Token: 0x0601458A RID: 83338 RVA: 0x001DE54D File Offset: 0x001DC74D
		public unsafe float UnitTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_Feedback.__PropertyOffset_UnitTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_Feedback.__PropertyOffset_UnitTime) = value;
			}
		}

		// Token: 0x17004FE3 RID: 20451
		// (get) Token: 0x0601458B RID: 83339 RVA: 0x001DE55E File Offset: 0x001DC75E
		// (set) Token: 0x0601458C RID: 83340 RVA: 0x001DE56E File Offset: 0x001DC76E
		public unsafe bool Hit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_Feedback.__PropertyOffset_Hit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_Feedback.__PropertyOffset_Hit) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004FE4 RID: 20452
		// (get) Token: 0x0601458D RID: 83341 RVA: 0x001DE57F File Offset: 0x001DC77F
		// (set) Token: 0x0601458E RID: 83342 RVA: 0x001DE58F File Offset: 0x001DC78F
		public unsafe bool NotEffectToChild
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_Feedback.__PropertyOffset_NotEffectToChild) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_Feedback.__PropertyOffset_NotEffectToChild) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004FE5 RID: 20453
		// (get) Token: 0x0601458F RID: 83343 RVA: 0x001DE5A0 File Offset: 0x001DC7A0
		// (set) Token: 0x06014590 RID: 83344 RVA: 0x001DE5B0 File Offset: 0x001DC7B0
		public unsafe float ShakeRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_Feedback.__PropertyOffset_ShakeRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_Feedback.__PropertyOffset_ShakeRate) = value;
			}
		}

		// Token: 0x17004FE6 RID: 20454
		// (get) Token: 0x06014591 RID: 83345 RVA: 0x001DE5C4 File Offset: 0x001DC7C4
		// (set) Token: 0x06014592 RID: 83346 RVA: 0x001DE607 File Offset: 0x001DC807
		public FHitBones HitBoneNames
		{
			get
			{
				base.FastCheckIsValid();
				FHitBones result;
				if ((result = this._HitBoneNames) == null)
				{
					result = (this._HitBoneNames = new FHitBones(base.NativePtr + (IntPtr)FAnimNode_Feedback.__PropertyOffset_HitBoneNames, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitBones.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_Feedback.__PropertyOffset_HitBoneNames, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004FE7 RID: 20455
		// (get) Token: 0x06014593 RID: 83347 RVA: 0x001DE628 File Offset: 0x001DC828
		// (set) Token: 0x06014594 RID: 83348 RVA: 0x001DE63C File Offset: 0x001DC83C
		[Nullable(2)]
		public unsafe UCurveFloat Curve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_Feedback.__PropertyOffset_Curve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_Feedback.__PropertyOffset_Curve, value);
			}
		}

		// Token: 0x17004FE8 RID: 20456
		// (get) Token: 0x06014595 RID: 83349 RVA: 0x001DE651 File Offset: 0x001DC851
		// (set) Token: 0x06014596 RID: 83350 RVA: 0x001DE661 File Offset: 0x001DC861
		public unsafe bool bDebug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_Feedback.__PropertyOffset_bDebug) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_Feedback.__PropertyOffset_bDebug) = (value ? 1 : 0);
			}
		}

		// Token: 0x06014597 RID: 83351 RVA: 0x001DE672 File Offset: 0x001DC872
		public FAnimNode_Feedback()
		{
		}

		// Token: 0x06014598 RID: 83352 RVA: 0x001DE67C File Offset: 0x001DC87C
		public FAnimNode_Feedback(FSkeletonGroup SkeletonBlockInfo, float DeltaTime, float UnitTime, bool Hit, bool NotEffectToChild, float ShakeRate, FHitBones HitBoneNames, UCurveFloat Curve, bool bDebug, FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.SkeletonBlockInfo = SkeletonBlockInfo;
			this.DeltaTime = DeltaTime;
			this.UnitTime = UnitTime;
			this.Hit = Hit;
			this.NotEffectToChild = NotEffectToChild;
			this.ShakeRate = ShakeRate;
			this.HitBoneNames = HitBoneNames;
			this.Curve = Curve;
			this.bDebug = bDebug;
			base.ComponentPose = ComponentPose;
			base.LODThreshold = LODThreshold;
			base.KuroLODMask = KuroLODMask;
			base.ActualAlpha = ActualAlpha;
			base.AlphaInputType = AlphaInputType;
			base.bAlphaBoolEnabled = bAlphaBoolEnabled;
			base.bParallelEvalEnabled = bParallelEvalEnabled;
			base.bEnableOnMobile = bEnableOnMobile;
			base.Alpha = Alpha;
			base.AlphaScaleBias = AlphaScaleBias;
			base.AlphaBoolBlend = AlphaBoolBlend;
			base.AlphaCurveName = AlphaCurveName;
			base.AlphaScaleBiasClamp = AlphaScaleBiasClamp;
		}

		// Token: 0x06014599 RID: 83353 RVA: 0x001DE73C File Offset: 0x001DC93C
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_Feedback.StaticStruct();
		}

		// Token: 0x0601459A RID: 83354 RVA: 0x001DE748 File Offset: 0x001DC948
		[NullableContext(2)]
		public FAnimNode_Feedback(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601459B RID: 83355 RVA: 0x001DE752 File Offset: 0x001DC952
		public FAnimNode_Feedback(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601459C RID: 83356 RVA: 0x001DE75D File Offset: 0x001DC95D
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_Feedback(Pointer, false, true);
		}

		// Token: 0x0601459D RID: 83357 RVA: 0x001DE767 File Offset: 0x001DC967
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_Feedback(Pointer, MemoryOwner);
		}

		// Token: 0x0400B123 RID: 45347
		public new const string __ObjectPath = "/Script/KuroAnim.AnimNode_Feedback";

		// Token: 0x0400B124 RID: 45348
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B125 RID: 45349
		internal static int __PropertyOffset_SkeletonBlockInfo;

		// Token: 0x0400B126 RID: 45350
		[Nullable(2)]
		private FSkeletonGroup _SkeletonBlockInfo;

		// Token: 0x0400B127 RID: 45351
		internal static int __PropertyOffset_DeltaTime;

		// Token: 0x0400B128 RID: 45352
		internal static int __PropertyOffset_UnitTime;

		// Token: 0x0400B129 RID: 45353
		internal static int __PropertyOffset_Hit;

		// Token: 0x0400B12A RID: 45354
		internal static int __PropertyOffset_NotEffectToChild;

		// Token: 0x0400B12B RID: 45355
		internal static int __PropertyOffset_ShakeRate;

		// Token: 0x0400B12C RID: 45356
		internal static int __PropertyOffset_HitBoneNames;

		// Token: 0x0400B12D RID: 45357
		[Nullable(2)]
		private FHitBones _HitBoneNames;

		// Token: 0x0400B12E RID: 45358
		internal static int __PropertyOffset_Curve;

		// Token: 0x0400B12F RID: 45359
		internal static int __PropertyOffset_bDebug;
	}
}
