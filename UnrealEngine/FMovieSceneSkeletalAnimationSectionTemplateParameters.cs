using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023A7 RID: 9127
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneSkeletalAnimationSectionTemplateParameters")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 256)]
	public class FMovieSceneSkeletalAnimationSectionTemplateParameters : FMovieSceneSkeletalAnimationParams, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602260F RID: 140815 RVA: 0x0032D7D9 File Offset: 0x0032B9D9
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneSkeletalAnimationSectionTemplateParameters._ScriptStructPtr != 0) ? FMovieSceneSkeletalAnimationSectionTemplateParameters._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneSkeletalAnimationSectionTemplateParameters", ref FMovieSceneSkeletalAnimationSectionTemplateParameters._ScriptStructPtr);
		}

		// Token: 0x17008485 RID: 33925
		// (get) Token: 0x06022610 RID: 140816 RVA: 0x0032D800 File Offset: 0x0032BA00
		// (set) Token: 0x06022611 RID: 140817 RVA: 0x0032D843 File Offset: 0x0032BA43
		public FFrameNumber SectionStartTime
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._SectionStartTime) == null)
				{
					result = (this._SectionStartTime = new FFrameNumber(base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationSectionTemplateParameters.__PropertyOffset_SectionStartTime, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationSectionTemplateParameters.__PropertyOffset_SectionStartTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008486 RID: 33926
		// (get) Token: 0x06022612 RID: 140818 RVA: 0x0032D864 File Offset: 0x0032BA64
		// (set) Token: 0x06022613 RID: 140819 RVA: 0x0032D8A7 File Offset: 0x0032BAA7
		public FFrameNumber SectionEndTime
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._SectionEndTime) == null)
				{
					result = (this._SectionEndTime = new FFrameNumber(base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationSectionTemplateParameters.__PropertyOffset_SectionEndTime, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneSkeletalAnimationSectionTemplateParameters.__PropertyOffset_SectionEndTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06022614 RID: 140820 RVA: 0x0032D8C8 File Offset: 0x0032BAC8
		public FMovieSceneSkeletalAnimationSectionTemplateParameters()
		{
		}

		// Token: 0x06022615 RID: 140821 RVA: 0x0032D8D0 File Offset: 0x0032BAD0
		public FMovieSceneSkeletalAnimationSectionTemplateParameters(FFrameNumber SectionStartTime, FFrameNumber SectionEndTime, UAnimSequenceBase Animation, FFrameNumber FirstLoopStartFrameOffset, FFrameNumber StartFrameOffset, FFrameNumber EndFrameOffset, float PlayRate, bool bReverse, FName SlotName, FMovieSceneFloatChannel Weight, bool bSkipAnimNotifiers, bool bForceCustomMode, float StartOffset_DEPRECATED, float EndOffset_DEPRECATED, FName KuroAnimLinkTag, bool bAnimLoop, bool bAnimMatch, float AnimMatchAngle, bool bForceResetWeight, bool bLockAnimFrameRate, float LockedAnimFrameRate, bool bLockRootMotionFrameRate)
		{
			this.SectionStartTime = SectionStartTime;
			this.SectionEndTime = SectionEndTime;
			base.Animation = Animation;
			base.FirstLoopStartFrameOffset = FirstLoopStartFrameOffset;
			base.StartFrameOffset = StartFrameOffset;
			base.EndFrameOffset = EndFrameOffset;
			base.PlayRate = PlayRate;
			base.bReverse = bReverse;
			base.SlotName = SlotName;
			base.Weight = Weight;
			base.bSkipAnimNotifiers = bSkipAnimNotifiers;
			base.bForceCustomMode = bForceCustomMode;
			base.StartOffset_DEPRECATED = StartOffset_DEPRECATED;
			base.EndOffset_DEPRECATED = EndOffset_DEPRECATED;
			base.KuroAnimLinkTag = KuroAnimLinkTag;
			base.bAnimLoop = bAnimLoop;
			base.bAnimMatch = bAnimMatch;
			base.AnimMatchAngle = AnimMatchAngle;
			base.bForceResetWeight = bForceResetWeight;
			base.bLockAnimFrameRate = bLockAnimFrameRate;
			base.LockedAnimFrameRate = LockedAnimFrameRate;
			base.bLockRootMotionFrameRate = bLockRootMotionFrameRate;
		}

		// Token: 0x06022616 RID: 140822 RVA: 0x0032D990 File Offset: 0x0032BB90
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneSkeletalAnimationSectionTemplateParameters.StaticStruct();
		}

		// Token: 0x06022617 RID: 140823 RVA: 0x0032D99C File Offset: 0x0032BB9C
		[NullableContext(2)]
		public FMovieSceneSkeletalAnimationSectionTemplateParameters(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022618 RID: 140824 RVA: 0x0032D9A6 File Offset: 0x0032BBA6
		public FMovieSceneSkeletalAnimationSectionTemplateParameters(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022619 RID: 140825 RVA: 0x0032D9B1 File Offset: 0x0032BBB1
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneSkeletalAnimationSectionTemplateParameters(Pointer, false, true);
		}

		// Token: 0x0602261A RID: 140826 RVA: 0x0032D9BB File Offset: 0x0032BBBB
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneSkeletalAnimationSectionTemplateParameters(Pointer, MemoryOwner);
		}

		// Token: 0x040125A7 RID: 75175
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneSkeletalAnimationSectionTemplateParameters";

		// Token: 0x040125A8 RID: 75176
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040125A9 RID: 75177
		internal static int __PropertyOffset_SectionStartTime;

		// Token: 0x040125AA RID: 75178
		[Nullable(2)]
		private FFrameNumber _SectionStartTime;

		// Token: 0x040125AB RID: 75179
		internal static int __PropertyOffset_SectionEndTime;

		// Token: 0x040125AC RID: 75180
		[Nullable(2)]
		private FFrameNumber _SectionEndTime;
	}
}
