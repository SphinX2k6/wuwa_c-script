using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200160A RID: 5642
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.AnimNode_FeedbackAnim")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 240)]
	public class FAnimNode_FeedbackAnim : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601459E RID: 83358 RVA: 0x001DE770 File Offset: 0x001DC970
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_FeedbackAnim._ScriptStructPtr != 0) ? FAnimNode_FeedbackAnim._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.AnimNode_FeedbackAnim", ref FAnimNode_FeedbackAnim._ScriptStructPtr);
		}

		// Token: 0x17004FE9 RID: 20457
		// (get) Token: 0x0601459F RID: 83359 RVA: 0x001DE794 File Offset: 0x001DC994
		// (set) Token: 0x060145A0 RID: 83360 RVA: 0x001DE7D7 File Offset: 0x001DC9D7
		public FBoneFeedbackAnimConfigGroup FeedbackConfigGroup
		{
			get
			{
				base.FastCheckIsValid();
				FBoneFeedbackAnimConfigGroup result;
				if ((result = this._FeedbackConfigGroup) == null)
				{
					result = (this._FeedbackConfigGroup = new FBoneFeedbackAnimConfigGroup(base.NativePtr + (IntPtr)FAnimNode_FeedbackAnim.__PropertyOffset_FeedbackConfigGroup, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneFeedbackAnimConfigGroup.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_FeedbackAnim.__PropertyOffset_FeedbackConfigGroup, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004FEA RID: 20458
		// (get) Token: 0x060145A1 RID: 83361 RVA: 0x001DE7F8 File Offset: 0x001DC9F8
		// (set) Token: 0x060145A2 RID: 83362 RVA: 0x001DE83B File Offset: 0x001DCA3B
		public FPoseLink BasePose
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._BasePose) == null)
				{
					result = (this._BasePose = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_FeedbackAnim.__PropertyOffset_BasePose, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_FeedbackAnim.__PropertyOffset_BasePose, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004FEB RID: 20459
		// (get) Token: 0x060145A3 RID: 83363 RVA: 0x001DE85C File Offset: 0x001DCA5C
		// (set) Token: 0x060145A4 RID: 83364 RVA: 0x001DE86C File Offset: 0x001DCA6C
		public unsafe bool NewHit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_FeedbackAnim.__PropertyOffset_NewHit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_FeedbackAnim.__PropertyOffset_NewHit) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004FEC RID: 20460
		// (get) Token: 0x060145A5 RID: 83365 RVA: 0x001DE880 File Offset: 0x001DCA80
		// (set) Token: 0x060145A6 RID: 83366 RVA: 0x001DE8C3 File Offset: 0x001DCAC3
		public FBoneFeedbackAnimHitInfo HitInfo
		{
			get
			{
				base.FastCheckIsValid();
				FBoneFeedbackAnimHitInfo result;
				if ((result = this._HitInfo) == null)
				{
					result = (this._HitInfo = new FBoneFeedbackAnimHitInfo(base.NativePtr + (IntPtr)FAnimNode_FeedbackAnim.__PropertyOffset_HitInfo, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneFeedbackAnimHitInfo.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_FeedbackAnim.__PropertyOffset_HitInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060145A7 RID: 83367 RVA: 0x001DE8E4 File Offset: 0x001DCAE4
		public FAnimNode_FeedbackAnim()
		{
		}

		// Token: 0x060145A8 RID: 83368 RVA: 0x001DE8EC File Offset: 0x001DCAEC
		public FAnimNode_FeedbackAnim(FBoneFeedbackAnimConfigGroup FeedbackConfigGroup, FPoseLink BasePose, bool NewHit, FBoneFeedbackAnimHitInfo HitInfo)
		{
			this.FeedbackConfigGroup = FeedbackConfigGroup;
			this.BasePose = BasePose;
			this.NewHit = NewHit;
			this.HitInfo = HitInfo;
		}

		// Token: 0x060145A9 RID: 83369 RVA: 0x001DE911 File Offset: 0x001DCB11
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_FeedbackAnim.StaticStruct();
		}

		// Token: 0x060145AA RID: 83370 RVA: 0x001DE91D File Offset: 0x001DCB1D
		[NullableContext(2)]
		public FAnimNode_FeedbackAnim(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060145AB RID: 83371 RVA: 0x001DE927 File Offset: 0x001DCB27
		public FAnimNode_FeedbackAnim(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060145AC RID: 83372 RVA: 0x001DE932 File Offset: 0x001DCB32
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_FeedbackAnim(Pointer, false, true);
		}

		// Token: 0x060145AD RID: 83373 RVA: 0x001DE93C File Offset: 0x001DCB3C
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_FeedbackAnim(Pointer, MemoryOwner);
		}

		// Token: 0x0400B130 RID: 45360
		public new const string __ObjectPath = "/Script/KuroAnim.AnimNode_FeedbackAnim";

		// Token: 0x0400B131 RID: 45361
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B132 RID: 45362
		internal static int __PropertyOffset_FeedbackConfigGroup;

		// Token: 0x0400B133 RID: 45363
		[Nullable(2)]
		private FBoneFeedbackAnimConfigGroup _FeedbackConfigGroup;

		// Token: 0x0400B134 RID: 45364
		internal static int __PropertyOffset_BasePose;

		// Token: 0x0400B135 RID: 45365
		[Nullable(2)]
		private FPoseLink _BasePose;

		// Token: 0x0400B136 RID: 45366
		internal static int __PropertyOffset_NewHit;

		// Token: 0x0400B137 RID: 45367
		internal static int __PropertyOffset_HitInfo;

		// Token: 0x0400B138 RID: 45368
		[Nullable(2)]
		private FBoneFeedbackAnimHitInfo _HitInfo;
	}
}
