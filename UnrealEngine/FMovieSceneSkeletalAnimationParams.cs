using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000771 RID: 1905
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneSkeletalAnimationParams")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 264)]
	public class FMovieSceneSkeletalAnimationParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A4F4 RID: 42228 RVA: 0x000F3A8D File Offset: 0x000F1C8D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneSkeletalAnimationParams._ScriptStructPtr != 0) ? FMovieSceneSkeletalAnimationParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneSkeletalAnimationParams", ref FMovieSceneSkeletalAnimationParams._ScriptStructPtr);
		}

		// Token: 0x17001E7D RID: 7805
		// (get) Token: 0x0600A4F5 RID: 42229 RVA: 0x000F3AB1 File Offset: 0x000F1CB1
		// (set) Token: 0x0600A4F6 RID: 42230 RVA: 0x000F3AC5 File Offset: 0x000F1CC5
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

		// Token: 0x17001E7E RID: 7806
		// (get) Token: 0x0600A4F7 RID: 42231 RVA: 0x000F3ADC File Offset: 0x000F1CDC
		// (set) Token: 0x0600A4F8 RID: 42232 RVA: 0x000F3B1F File Offset: 0x000F1D1F
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

		// Token: 0x17001E7F RID: 7807
		// (get) Token: 0x0600A4F9 RID: 42233 RVA: 0x000F3B40 File Offset: 0x000F1D40
		// (set) Token: 0x0600A4FA RID: 42234 RVA: 0x000F3B83 File Offset: 0x000F1D83
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

		// Token: 0x17001E80 RID: 7808
		// (get) Token: 0x0600A4FB RID: 42235 RVA: 0x000F3BA4 File Offset: 0x000F1DA4
		// (set) Token: 0x0600A4FC RID: 42236 RVA: 0x000F3BE7 File Offset: 0x000F1DE7
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

		// Token: 0x17001E81 RID: 7809
		// (get) Token: 0x0600A4FD RID: 42237 RVA: 0x000F3C08 File Offset: 0x000F1E08
		// (set) Token: 0x0600A4FE RID: 42238 RVA: 0x000F3C18 File Offset: 0x000F1E18
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

		// Token: 0x17001E82 RID: 7810
		// (get) Token: 0x0600A4FF RID: 42239 RVA: 0x000F3C29 File Offset: 0x000F1E29
		// (set) Token: 0x0600A500 RID: 42240 RVA: 0x000F3C42 File Offset: 0x000F1E42
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

		// Token: 0x17001E83 RID: 7811
		// (get) Token: 0x0600A501 RID: 42241 RVA: 0x000F3C72 File Offset: 0x000F1E72
		// (set) Token: 0x0600A502 RID: 42242 RVA: 0x000F3C86 File Offset: 0x000F1E86
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

		// Token: 0x17001E84 RID: 7812
		// (get) Token: 0x0600A503 RID: 42243 RVA: 0x000F3C9C File Offset: 0x000F1E9C
		// (set) Token: 0x0600A504 RID: 42244 RVA: 0x000F3CDF File Offset: 0x000F1EDF
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

		// Token: 0x17001E85 RID: 7813
		// (get) Token: 0x0600A505 RID: 42245 RVA: 0x000F3D00 File Offset: 0x000F1F00
		// (set) Token: 0x0600A506 RID: 42246 RVA: 0x000F3D10 File Offset: 0x000F1F10
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

		// Token: 0x17001E86 RID: 7814
		// (get) Token: 0x0600A507 RID: 42247 RVA: 0x000F3D21 File Offset: 0x000F1F21
		// (set) Token: 0x0600A508 RID: 42248 RVA: 0x000F3D31 File Offset: 0x000F1F31
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

		// Token: 0x17001E87 RID: 7815
		// (get) Token: 0x0600A509 RID: 42249 RVA: 0x000F3D42 File Offset: 0x000F1F42
		// (set) Token: 0x0600A50A RID: 42250 RVA: 0x000F3D52 File Offset: 0x000F1F52
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

		// Token: 0x17001E88 RID: 7816
		// (get) Token: 0x0600A50B RID: 42251 RVA: 0x000F3D63 File Offset: 0x000F1F63
		// (set) Token: 0x0600A50C RID: 42252 RVA: 0x000F3D73 File Offset: 0x000F1F73
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

		// Token: 0x17001E89 RID: 7817
		// (get) Token: 0x0600A50D RID: 42253 RVA: 0x000F3D84 File Offset: 0x000F1F84
		// (set) Token: 0x0600A50E RID: 42254 RVA: 0x000F3D98 File Offset: 0x000F1F98
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

		// Token: 0x17001E8A RID: 7818
		// (get) Token: 0x0600A50F RID: 42255 RVA: 0x000F3DAD File Offset: 0x000F1FAD
		// (set) Token: 0x0600A510 RID: 42256 RVA: 0x000F3DBD File Offset: 0x000F1FBD
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

		// Token: 0x17001E8B RID: 7819
		// (get) Token: 0x0600A511 RID: 42257 RVA: 0x000F3DCE File Offset: 0x000F1FCE
		// (set) Token: 0x0600A512 RID: 42258 RVA: 0x000F3DDE File Offset: 0x000F1FDE
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

		// Token: 0x17001E8C RID: 7820
		// (get) Token: 0x0600A513 RID: 42259 RVA: 0x000F3DEF File Offset: 0x000F1FEF
		// (set) Token: 0x0600A514 RID: 42260 RVA: 0x000F3DFF File Offset: 0x000F1FFF
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

		// Token: 0x17001E8D RID: 7821
		// (get) Token: 0x0600A515 RID: 42261 RVA: 0x000F3E10 File Offset: 0x000F2010
		// (set) Token: 0x0600A516 RID: 42262 RVA: 0x000F3E20 File Offset: 0x000F2020
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

		// Token: 0x17001E8E RID: 7822
		// (get) Token: 0x0600A517 RID: 42263 RVA: 0x000F3E31 File Offset: 0x000F2031
		// (set) Token: 0x0600A518 RID: 42264 RVA: 0x000F3E41 File Offset: 0x000F2041
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

		// Token: 0x17001E8F RID: 7823
		// (get) Token: 0x0600A519 RID: 42265 RVA: 0x000F3E52 File Offset: 0x000F2052
		// (set) Token: 0x0600A51A RID: 42266 RVA: 0x000F3E62 File Offset: 0x000F2062
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

		// Token: 0x17001E90 RID: 7824
		// (get) Token: 0x0600A51B RID: 42267 RVA: 0x000F3E73 File Offset: 0x000F2073
		// (set) Token: 0x0600A51C RID: 42268 RVA: 0x000F3E83 File Offset: 0x000F2083
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

		// Token: 0x0600A51D RID: 42269 RVA: 0x000F3E94 File Offset: 0x000F2094
		public FMovieSceneSkeletalAnimationParams()
		{
		}

		// Token: 0x0600A51E RID: 42270 RVA: 0x000F3E9C File Offset: 0x000F209C
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneSkeletalAnimationParams.StaticStruct();
		}

		// Token: 0x0600A51F RID: 42271 RVA: 0x000F3EA8 File Offset: 0x000F20A8
		[NullableContext(2)]
		public FMovieSceneSkeletalAnimationParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A520 RID: 42272 RVA: 0x000F3EB2 File Offset: 0x000F20B2
		public FMovieSceneSkeletalAnimationParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A521 RID: 42273 RVA: 0x000F3EBD File Offset: 0x000F20BD
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneSkeletalAnimationParams(Pointer, false, true);
		}

		// Token: 0x0600A522 RID: 42274 RVA: 0x000F3EC7 File Offset: 0x000F20C7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneSkeletalAnimationParams(Pointer, MemoryOwner);
		}

		// Token: 0x0400466C RID: 18028
		public const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneSkeletalAnimationParams";

		// Token: 0x0400466D RID: 18029
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400466E RID: 18030
		internal static int __PropertyOffset_Animation;

		// Token: 0x0400466F RID: 18031
		internal static int __PropertyOffset_FirstLoopStartFrameOffset;

		// Token: 0x04004670 RID: 18032
		[Nullable(2)]
		private FFrameNumber _FirstLoopStartFrameOffset;

		// Token: 0x04004671 RID: 18033
		internal static int __PropertyOffset_StartFrameOffset;

		// Token: 0x04004672 RID: 18034
		[Nullable(2)]
		private FFrameNumber _StartFrameOffset;

		// Token: 0x04004673 RID: 18035
		internal static int __PropertyOffset_EndFrameOffset;

		// Token: 0x04004674 RID: 18036
		[Nullable(2)]
		private FFrameNumber _EndFrameOffset;

		// Token: 0x04004675 RID: 18037
		internal static int __PropertyOffset_PlayRate;

		// Token: 0x04004676 RID: 18038
		internal static int __PropertyOffset_bReverse;

		// Token: 0x04004677 RID: 18039
		internal static byte __PropertyMask_bReverse;

		// Token: 0x04004678 RID: 18040
		internal static int __PropertyOffset_SlotName;

		// Token: 0x04004679 RID: 18041
		internal static int __PropertyOffset_Weight;

		// Token: 0x0400467A RID: 18042
		[Nullable(2)]
		private FMovieSceneFloatChannel _Weight;

		// Token: 0x0400467B RID: 18043
		internal static int __PropertyOffset_bSkipAnimNotifiers;

		// Token: 0x0400467C RID: 18044
		internal static int __PropertyOffset_bForceCustomMode;

		// Token: 0x0400467D RID: 18045
		internal static int __PropertyOffset_StartOffset_DEPRECATED;

		// Token: 0x0400467E RID: 18046
		internal static int __PropertyOffset_EndOffset_DEPRECATED;

		// Token: 0x0400467F RID: 18047
		internal static int __PropertyOffset_KuroAnimLinkTag;

		// Token: 0x04004680 RID: 18048
		internal static int __PropertyOffset_bAnimLoop;

		// Token: 0x04004681 RID: 18049
		internal static int __PropertyOffset_bAnimMatch;

		// Token: 0x04004682 RID: 18050
		internal static int __PropertyOffset_AnimMatchAngle;

		// Token: 0x04004683 RID: 18051
		internal static int __PropertyOffset_bForceResetWeight;

		// Token: 0x04004684 RID: 18052
		internal static int __PropertyOffset_bLockAnimFrameRate;

		// Token: 0x04004685 RID: 18053
		internal static int __PropertyOffset_LockedAnimFrameRate;

		// Token: 0x04004686 RID: 18054
		internal static int __PropertyOffset_bLockRootMotionFrameRate;
	}
}
