using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023A4 RID: 9124
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneSkeletalAnimationParams")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 248)]
	public class FMovieSceneSkeletalAnimationParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060225A8 RID: 140712 RVA: 0x0032CE52 File Offset: 0x0032B052
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneSkeletalAnimationParams._ScriptStructPtr != 0) ? FMovieSceneSkeletalAnimationParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneSkeletalAnimationParams", ref FMovieSceneSkeletalAnimationParams._ScriptStructPtr);
		}

		// Token: 0x1700845C RID: 33884
		// (get) Token: 0x060225A9 RID: 140713 RVA: 0x0032CE76 File Offset: 0x0032B076
		// (set) Token: 0x060225AA RID: 140714 RVA: 0x0032CE8A File Offset: 0x0032B08A
		[Nullable(2)]
		public unsafe UAnimSequenceBase Animation
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimSequenceBase>(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneSkeletalAnimationParams.__PropertyOffset_Animation);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneSkeletalAnimationParams.__PropertyOffset_Animation, value);
			}
		}

		// Token: 0x1700845D RID: 33885
		// (get) Token: 0x060225AB RID: 140715 RVA: 0x0032CEA0 File Offset: 0x0032B0A0
		// (set) Token: 0x060225AC RID: 140716 RVA: 0x0032CEE3 File Offset: 0x0032B0E3
		public FFrameNumber FirstLoopStartFrameOffset
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._FirstLoopStartFrameOffset) == null)
				{
					result = (this._FirstLoopStartFrameOffset = new FFrameNumber(base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationParams.__PropertyOffset_FirstLoopStartFrameOffset, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationParams.__PropertyOffset_FirstLoopStartFrameOffset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700845E RID: 33886
		// (get) Token: 0x060225AD RID: 140717 RVA: 0x0032CF04 File Offset: 0x0032B104
		// (set) Token: 0x060225AE RID: 140718 RVA: 0x0032CF47 File Offset: 0x0032B147
		public FFrameNumber StartFrameOffset
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._StartFrameOffset) == null)
				{
					result = (this._StartFrameOffset = new FFrameNumber(base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationParams.__PropertyOffset_StartFrameOffset, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationParams.__PropertyOffset_StartFrameOffset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700845F RID: 33887
		// (get) Token: 0x060225AF RID: 140719 RVA: 0x0032CF68 File Offset: 0x0032B168
		// (set) Token: 0x060225B0 RID: 140720 RVA: 0x0032CFAB File Offset: 0x0032B1AB
		public FFrameNumber EndFrameOffset
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._EndFrameOffset) == null)
				{
					result = (this._EndFrameOffset = new FFrameNumber(base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationParams.__PropertyOffset_EndFrameOffset, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationParams.__PropertyOffset_EndFrameOffset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008460 RID: 33888
		// (get) Token: 0x060225B1 RID: 140721 RVA: 0x0032CFCC File Offset: 0x0032B1CC
		// (set) Token: 0x060225B2 RID: 140722 RVA: 0x0032CFDC File Offset: 0x0032B1DC
		public unsafe float PlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationParams.__PropertyOffset_PlayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationParams.__PropertyOffset_PlayRate) = value;
			}
		}

		// Token: 0x17008461 RID: 33889
		// (get) Token: 0x060225B3 RID: 140723 RVA: 0x0032CFED File Offset: 0x0032B1ED
		// (set) Token: 0x060225B4 RID: 140724 RVA: 0x0032D006 File Offset: 0x0032B206
		public unsafe bool bReverse
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationParams.__PropertyOffset_bReverse) & FMovieSceneSkeletalAnimationParams.__PropertyMask_bReverse) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMovieSceneSkeletalAnimationParams.__PropertyOffset_bReverse) = ((*(base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationParams.__PropertyOffset_bReverse) & ~FMovieSceneSkeletalAnimationParams.__PropertyMask_bReverse) | (value ? FMovieSceneSkeletalAnimationParams.__PropertyMask_bReverse : 0));
			}
		}

		// Token: 0x17008462 RID: 33890
		// (get) Token: 0x060225B5 RID: 140725 RVA: 0x0032D036 File Offset: 0x0032B236
		// (set) Token: 0x060225B6 RID: 140726 RVA: 0x0032D04A File Offset: 0x0032B24A
		public unsafe FName SlotName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationParams.__PropertyOffset_SlotName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationParams.__PropertyOffset_SlotName) = value;
			}
		}

		// Token: 0x17008463 RID: 33891
		// (get) Token: 0x060225B7 RID: 140727 RVA: 0x0032D060 File Offset: 0x0032B260
		// (set) Token: 0x060225B8 RID: 140728 RVA: 0x0032D0A3 File Offset: 0x0032B2A3
		public FMovieSceneFloatChannel Weight
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._Weight) == null)
				{
					result = (this._Weight = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationParams.__PropertyOffset_Weight, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationParams.__PropertyOffset_Weight, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008464 RID: 33892
		// (get) Token: 0x060225B9 RID: 140729 RVA: 0x0032D0C4 File Offset: 0x0032B2C4
		// (set) Token: 0x060225BA RID: 140730 RVA: 0x0032D0D4 File Offset: 0x0032B2D4
		public unsafe bool bSkipAnimNotifiers
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationParams.__PropertyOffset_bSkipAnimNotifiers) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationParams.__PropertyOffset_bSkipAnimNotifiers) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008465 RID: 33893
		// (get) Token: 0x060225BB RID: 140731 RVA: 0x0032D0E5 File Offset: 0x0032B2E5
		// (set) Token: 0x060225BC RID: 140732 RVA: 0x0032D0F5 File Offset: 0x0032B2F5
		public unsafe bool bForceCustomMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationParams.__PropertyOffset_bForceCustomMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationParams.__PropertyOffset_bForceCustomMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008466 RID: 33894
		// (get) Token: 0x060225BD RID: 140733 RVA: 0x0032D106 File Offset: 0x0032B306
		// (set) Token: 0x060225BE RID: 140734 RVA: 0x0032D116 File Offset: 0x0032B316
		public unsafe float StartOffset_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationParams.__PropertyOffset_StartOffset_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationParams.__PropertyOffset_StartOffset_DEPRECATED) = value;
			}
		}

		// Token: 0x17008467 RID: 33895
		// (get) Token: 0x060225BF RID: 140735 RVA: 0x0032D127 File Offset: 0x0032B327
		// (set) Token: 0x060225C0 RID: 140736 RVA: 0x0032D137 File Offset: 0x0032B337
		public unsafe float EndOffset_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationParams.__PropertyOffset_EndOffset_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationParams.__PropertyOffset_EndOffset_DEPRECATED) = value;
			}
		}

		// Token: 0x17008468 RID: 33896
		// (get) Token: 0x060225C1 RID: 140737 RVA: 0x0032D148 File Offset: 0x0032B348
		// (set) Token: 0x060225C2 RID: 140738 RVA: 0x0032D15C File Offset: 0x0032B35C
		public unsafe FName KuroAnimLinkTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationParams.__PropertyOffset_KuroAnimLinkTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationParams.__PropertyOffset_KuroAnimLinkTag) = value;
			}
		}

		// Token: 0x17008469 RID: 33897
		// (get) Token: 0x060225C3 RID: 140739 RVA: 0x0032D171 File Offset: 0x0032B371
		// (set) Token: 0x060225C4 RID: 140740 RVA: 0x0032D181 File Offset: 0x0032B381
		public unsafe bool bAnimLoop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationParams.__PropertyOffset_bAnimLoop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationParams.__PropertyOffset_bAnimLoop) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700846A RID: 33898
		// (get) Token: 0x060225C5 RID: 140741 RVA: 0x0032D192 File Offset: 0x0032B392
		// (set) Token: 0x060225C6 RID: 140742 RVA: 0x0032D1A2 File Offset: 0x0032B3A2
		public unsafe bool bAnimMatch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationParams.__PropertyOffset_bAnimMatch) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationParams.__PropertyOffset_bAnimMatch) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700846B RID: 33899
		// (get) Token: 0x060225C7 RID: 140743 RVA: 0x0032D1B3 File Offset: 0x0032B3B3
		// (set) Token: 0x060225C8 RID: 140744 RVA: 0x0032D1C3 File Offset: 0x0032B3C3
		public unsafe float AnimMatchAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationParams.__PropertyOffset_AnimMatchAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationParams.__PropertyOffset_AnimMatchAngle) = value;
			}
		}

		// Token: 0x1700846C RID: 33900
		// (get) Token: 0x060225C9 RID: 140745 RVA: 0x0032D1D4 File Offset: 0x0032B3D4
		// (set) Token: 0x060225CA RID: 140746 RVA: 0x0032D1E4 File Offset: 0x0032B3E4
		public unsafe bool bForceResetWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationParams.__PropertyOffset_bForceResetWeight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationParams.__PropertyOffset_bForceResetWeight) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700846D RID: 33901
		// (get) Token: 0x060225CB RID: 140747 RVA: 0x0032D1F5 File Offset: 0x0032B3F5
		// (set) Token: 0x060225CC RID: 140748 RVA: 0x0032D205 File Offset: 0x0032B405
		public unsafe bool bLockAnimFrameRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationParams.__PropertyOffset_bLockAnimFrameRate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationParams.__PropertyOffset_bLockAnimFrameRate) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700846E RID: 33902
		// (get) Token: 0x060225CD RID: 140749 RVA: 0x0032D216 File Offset: 0x0032B416
		// (set) Token: 0x060225CE RID: 140750 RVA: 0x0032D226 File Offset: 0x0032B426
		public unsafe float LockedAnimFrameRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationParams.__PropertyOffset_LockedAnimFrameRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationParams.__PropertyOffset_LockedAnimFrameRate) = value;
			}
		}

		// Token: 0x1700846F RID: 33903
		// (get) Token: 0x060225CF RID: 140751 RVA: 0x0032D237 File Offset: 0x0032B437
		// (set) Token: 0x060225D0 RID: 140752 RVA: 0x0032D247 File Offset: 0x0032B447
		public unsafe bool bLockRootMotionFrameRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationParams.__PropertyOffset_bLockRootMotionFrameRate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationParams.__PropertyOffset_bLockRootMotionFrameRate) = (value ? 1 : 0);
			}
		}

		// Token: 0x060225D1 RID: 140753 RVA: 0x0032D258 File Offset: 0x0032B458
		public FMovieSceneSkeletalAnimationParams()
		{
		}

		// Token: 0x060225D2 RID: 140754 RVA: 0x0032D260 File Offset: 0x0032B460
		public FMovieSceneSkeletalAnimationParams(UAnimSequenceBase Animation, FFrameNumber FirstLoopStartFrameOffset, FFrameNumber StartFrameOffset, FFrameNumber EndFrameOffset, float PlayRate, bool bReverse, FName SlotName, FMovieSceneFloatChannel Weight, bool bSkipAnimNotifiers, bool bForceCustomMode, float StartOffset_DEPRECATED, float EndOffset_DEPRECATED, FName KuroAnimLinkTag, bool bAnimLoop, bool bAnimMatch, float AnimMatchAngle, bool bForceResetWeight, bool bLockAnimFrameRate, float LockedAnimFrameRate, bool bLockRootMotionFrameRate)
		{
			this.Animation = Animation;
			this.FirstLoopStartFrameOffset = FirstLoopStartFrameOffset;
			this.StartFrameOffset = StartFrameOffset;
			this.EndFrameOffset = EndFrameOffset;
			this.PlayRate = PlayRate;
			this.bReverse = bReverse;
			this.SlotName = SlotName;
			this.Weight = Weight;
			this.bSkipAnimNotifiers = bSkipAnimNotifiers;
			this.bForceCustomMode = bForceCustomMode;
			this.StartOffset_DEPRECATED = StartOffset_DEPRECATED;
			this.EndOffset_DEPRECATED = EndOffset_DEPRECATED;
			this.KuroAnimLinkTag = KuroAnimLinkTag;
			this.bAnimLoop = bAnimLoop;
			this.bAnimMatch = bAnimMatch;
			this.AnimMatchAngle = AnimMatchAngle;
			this.bForceResetWeight = bForceResetWeight;
			this.bLockAnimFrameRate = bLockAnimFrameRate;
			this.LockedAnimFrameRate = LockedAnimFrameRate;
			this.bLockRootMotionFrameRate = bLockRootMotionFrameRate;
		}

		// Token: 0x060225D3 RID: 140755 RVA: 0x0032D310 File Offset: 0x0032B510
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneSkeletalAnimationParams.StaticStruct();
		}

		// Token: 0x060225D4 RID: 140756 RVA: 0x0032D31C File Offset: 0x0032B51C
		[NullableContext(2)]
		public FMovieSceneSkeletalAnimationParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060225D5 RID: 140757 RVA: 0x0032D326 File Offset: 0x0032B526
		public FMovieSceneSkeletalAnimationParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060225D6 RID: 140758 RVA: 0x0032D331 File Offset: 0x0032B531
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneSkeletalAnimationParams(Pointer, false, true);
		}

		// Token: 0x060225D7 RID: 140759 RVA: 0x0032D33B File Offset: 0x0032B53B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneSkeletalAnimationParams(Pointer, MemoryOwner);
		}

		// Token: 0x0401256F RID: 75119
		public const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneSkeletalAnimationParams";

		// Token: 0x04012570 RID: 75120
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012571 RID: 75121
		internal static int __PropertyOffset_Animation;

		// Token: 0x04012572 RID: 75122
		internal static int __PropertyOffset_FirstLoopStartFrameOffset;

		// Token: 0x04012573 RID: 75123
		[Nullable(2)]
		private FFrameNumber _FirstLoopStartFrameOffset;

		// Token: 0x04012574 RID: 75124
		internal static int __PropertyOffset_StartFrameOffset;

		// Token: 0x04012575 RID: 75125
		[Nullable(2)]
		private FFrameNumber _StartFrameOffset;

		// Token: 0x04012576 RID: 75126
		internal static int __PropertyOffset_EndFrameOffset;

		// Token: 0x04012577 RID: 75127
		[Nullable(2)]
		private FFrameNumber _EndFrameOffset;

		// Token: 0x04012578 RID: 75128
		internal static int __PropertyOffset_PlayRate;

		// Token: 0x04012579 RID: 75129
		internal static int __PropertyOffset_bReverse;

		// Token: 0x0401257A RID: 75130
		internal static byte __PropertyMask_bReverse;

		// Token: 0x0401257B RID: 75131
		internal static int __PropertyOffset_SlotName;

		// Token: 0x0401257C RID: 75132
		internal static int __PropertyOffset_Weight;

		// Token: 0x0401257D RID: 75133
		[Nullable(2)]
		private FMovieSceneFloatChannel _Weight;

		// Token: 0x0401257E RID: 75134
		internal static int __PropertyOffset_bSkipAnimNotifiers;

		// Token: 0x0401257F RID: 75135
		internal static int __PropertyOffset_bForceCustomMode;

		// Token: 0x04012580 RID: 75136
		internal static int __PropertyOffset_StartOffset_DEPRECATED;

		// Token: 0x04012581 RID: 75137
		internal static int __PropertyOffset_EndOffset_DEPRECATED;

		// Token: 0x04012582 RID: 75138
		internal static int __PropertyOffset_KuroAnimLinkTag;

		// Token: 0x04012583 RID: 75139
		internal static int __PropertyOffset_bAnimLoop;

		// Token: 0x04012584 RID: 75140
		internal static int __PropertyOffset_bAnimMatch;

		// Token: 0x04012585 RID: 75141
		internal static int __PropertyOffset_AnimMatchAngle;

		// Token: 0x04012586 RID: 75142
		internal static int __PropertyOffset_bForceResetWeight;

		// Token: 0x04012587 RID: 75143
		internal static int __PropertyOffset_bLockAnimFrameRate;

		// Token: 0x04012588 RID: 75144
		internal static int __PropertyOffset_LockedAnimFrameRate;

		// Token: 0x04012589 RID: 75145
		internal static int __PropertyOffset_bLockRootMotionFrameRate;
	}
}
