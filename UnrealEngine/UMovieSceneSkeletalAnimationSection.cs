using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000772 RID: 1906
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneSkeletalAnimationSection")]
	[UnrealStructLayout(832, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 832)]
	public class UMovieSceneSkeletalAnimationSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A523 RID: 42275 RVA: 0x000F3ED0 File Offset: 0x000F20D0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneSkeletalAnimationSection._ClassPtr;
		}

		// Token: 0x0600A524 RID: 42276 RVA: 0x000F3EDC File Offset: 0x000F20DC
		public UMovieSceneSkeletalAnimationSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSkeletalAnimationSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A525 RID: 42277 RVA: 0x000F3F04 File Offset: 0x000F2104
		[NullableContext(1)]
		public UMovieSceneSkeletalAnimationSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSkeletalAnimationSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001E91 RID: 7825
		// (get) Token: 0x0600A526 RID: 42278 RVA: 0x000F3F38 File Offset: 0x000F2138
		// (set) Token: 0x0600A527 RID: 42279 RVA: 0x000F3F71 File Offset: 0x000F2171
		[Nullable(1)]
		public FMovieSceneSkeletalAnimationParams Params
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FMovieSceneSkeletalAnimationParams result;
				if ((result = this._Params) == null)
				{
					result = (this._Params = new FMovieSceneSkeletalAnimationParams(base.NativePtr + (IntPtr)UMovieSceneSkeletalAnimationSection.__PropertyOffset_Params, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneSkeletalAnimationParams.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneSkeletalAnimationSection.__PropertyOffset_Params, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001E92 RID: 7826
		// (get) Token: 0x0600A528 RID: 42280 RVA: 0x000F3F92 File Offset: 0x000F2192
		// (set) Token: 0x0600A529 RID: 42281 RVA: 0x000F3FA6 File Offset: 0x000F21A6
		public unsafe UAnimSequence AnimSequence_DEPRECATED
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimSequence>(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneSkeletalAnimationSection.__PropertyOffset_AnimSequence_DEPRECATED);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneSkeletalAnimationSection.__PropertyOffset_AnimSequence_DEPRECATED, value);
			}
		}

		// Token: 0x17001E93 RID: 7827
		// (get) Token: 0x0600A52A RID: 42282 RVA: 0x000F3FBB File Offset: 0x000F21BB
		// (set) Token: 0x0600A52B RID: 42283 RVA: 0x000F3FCF File Offset: 0x000F21CF
		public unsafe UAnimSequenceBase Animation_DEPRECATED
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimSequenceBase>(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneSkeletalAnimationSection.__PropertyOffset_Animation_DEPRECATED);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneSkeletalAnimationSection.__PropertyOffset_Animation_DEPRECATED, value);
			}
		}

		// Token: 0x17001E94 RID: 7828
		// (get) Token: 0x0600A52C RID: 42284 RVA: 0x000F3FE4 File Offset: 0x000F21E4
		// (set) Token: 0x0600A52D RID: 42285 RVA: 0x000F3FF4 File Offset: 0x000F21F4
		public unsafe float StartOffset_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneSkeletalAnimationSection.__PropertyOffset_StartOffset_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneSkeletalAnimationSection.__PropertyOffset_StartOffset_DEPRECATED) = value;
			}
		}

		// Token: 0x17001E95 RID: 7829
		// (get) Token: 0x0600A52E RID: 42286 RVA: 0x000F4005 File Offset: 0x000F2205
		// (set) Token: 0x0600A52F RID: 42287 RVA: 0x000F4015 File Offset: 0x000F2215
		public unsafe float EndOffset_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneSkeletalAnimationSection.__PropertyOffset_EndOffset_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneSkeletalAnimationSection.__PropertyOffset_EndOffset_DEPRECATED) = value;
			}
		}

		// Token: 0x17001E96 RID: 7830
		// (get) Token: 0x0600A530 RID: 42288 RVA: 0x000F4026 File Offset: 0x000F2226
		// (set) Token: 0x0600A531 RID: 42289 RVA: 0x000F4036 File Offset: 0x000F2236
		public unsafe float PlayRate_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneSkeletalAnimationSection.__PropertyOffset_PlayRate_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneSkeletalAnimationSection.__PropertyOffset_PlayRate_DEPRECATED) = value;
			}
		}

		// Token: 0x17001E97 RID: 7831
		// (get) Token: 0x0600A532 RID: 42290 RVA: 0x000F4047 File Offset: 0x000F2247
		// (set) Token: 0x0600A533 RID: 42291 RVA: 0x000F4060 File Offset: 0x000F2260
		public unsafe bool bReverse_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMovieSceneSkeletalAnimationSection.__PropertyOffset_bReverse_DEPRECATED) & UMovieSceneSkeletalAnimationSection.__PropertyMask_bReverse_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMovieSceneSkeletalAnimationSection.__PropertyOffset_bReverse_DEPRECATED) = ((*(base.NativePtr + (IntPtr)UMovieSceneSkeletalAnimationSection.__PropertyOffset_bReverse_DEPRECATED) & ~UMovieSceneSkeletalAnimationSection.__PropertyMask_bReverse_DEPRECATED) | (value ? UMovieSceneSkeletalAnimationSection.__PropertyMask_bReverse_DEPRECATED : 0));
			}
		}

		// Token: 0x17001E98 RID: 7832
		// (get) Token: 0x0600A534 RID: 42292 RVA: 0x000F4090 File Offset: 0x000F2290
		// (set) Token: 0x0600A535 RID: 42293 RVA: 0x000F40A4 File Offset: 0x000F22A4
		public unsafe FName SlotName_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneSkeletalAnimationSection.__PropertyOffset_SlotName_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneSkeletalAnimationSection.__PropertyOffset_SlotName_DEPRECATED) = value;
			}
		}

		// Token: 0x17001E99 RID: 7833
		// (get) Token: 0x0600A536 RID: 42294 RVA: 0x000F40B9 File Offset: 0x000F22B9
		// (set) Token: 0x0600A537 RID: 42295 RVA: 0x000F40CD File Offset: 0x000F22CD
		public unsafe FVector StartLocationOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneSkeletalAnimationSection.__PropertyOffset_StartLocationOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneSkeletalAnimationSection.__PropertyOffset_StartLocationOffset) = value;
			}
		}

		// Token: 0x17001E9A RID: 7834
		// (get) Token: 0x0600A538 RID: 42296 RVA: 0x000F40E2 File Offset: 0x000F22E2
		// (set) Token: 0x0600A539 RID: 42297 RVA: 0x000F40F6 File Offset: 0x000F22F6
		public unsafe FRotator StartRotationOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneSkeletalAnimationSection.__PropertyOffset_StartRotationOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneSkeletalAnimationSection.__PropertyOffset_StartRotationOffset) = value;
			}
		}

		// Token: 0x17001E9B RID: 7835
		// (get) Token: 0x0600A53A RID: 42298 RVA: 0x000F410B File Offset: 0x000F230B
		// (set) Token: 0x0600A53B RID: 42299 RVA: 0x000F411B File Offset: 0x000F231B
		public unsafe bool bMatchWithPrevious
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneSkeletalAnimationSection.__PropertyOffset_bMatchWithPrevious) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneSkeletalAnimationSection.__PropertyOffset_bMatchWithPrevious) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001E9C RID: 7836
		// (get) Token: 0x0600A53C RID: 42300 RVA: 0x000F412C File Offset: 0x000F232C
		// (set) Token: 0x0600A53D RID: 42301 RVA: 0x000F4140 File Offset: 0x000F2340
		public unsafe FName MatchedBoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneSkeletalAnimationSection.__PropertyOffset_MatchedBoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneSkeletalAnimationSection.__PropertyOffset_MatchedBoneName) = value;
			}
		}

		// Token: 0x17001E9D RID: 7837
		// (get) Token: 0x0600A53E RID: 42302 RVA: 0x000F4155 File Offset: 0x000F2355
		// (set) Token: 0x0600A53F RID: 42303 RVA: 0x000F4169 File Offset: 0x000F2369
		public unsafe FVector MatchedLocationOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneSkeletalAnimationSection.__PropertyOffset_MatchedLocationOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneSkeletalAnimationSection.__PropertyOffset_MatchedLocationOffset) = value;
			}
		}

		// Token: 0x17001E9E RID: 7838
		// (get) Token: 0x0600A540 RID: 42304 RVA: 0x000F417E File Offset: 0x000F237E
		// (set) Token: 0x0600A541 RID: 42305 RVA: 0x000F4192 File Offset: 0x000F2392
		public unsafe FRotator MatchedRotationOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneSkeletalAnimationSection.__PropertyOffset_MatchedRotationOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneSkeletalAnimationSection.__PropertyOffset_MatchedRotationOffset) = value;
			}
		}

		// Token: 0x17001E9F RID: 7839
		// (get) Token: 0x0600A542 RID: 42306 RVA: 0x000F41A7 File Offset: 0x000F23A7
		// (set) Token: 0x0600A543 RID: 42307 RVA: 0x000F41B7 File Offset: 0x000F23B7
		public unsafe bool bMatchTranslation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneSkeletalAnimationSection.__PropertyOffset_bMatchTranslation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneSkeletalAnimationSection.__PropertyOffset_bMatchTranslation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001EA0 RID: 7840
		// (get) Token: 0x0600A544 RID: 42308 RVA: 0x000F41C8 File Offset: 0x000F23C8
		// (set) Token: 0x0600A545 RID: 42309 RVA: 0x000F41D8 File Offset: 0x000F23D8
		public unsafe bool bMatchIncludeZHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneSkeletalAnimationSection.__PropertyOffset_bMatchIncludeZHeight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneSkeletalAnimationSection.__PropertyOffset_bMatchIncludeZHeight) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001EA1 RID: 7841
		// (get) Token: 0x0600A546 RID: 42310 RVA: 0x000F41E9 File Offset: 0x000F23E9
		// (set) Token: 0x0600A547 RID: 42311 RVA: 0x000F41F9 File Offset: 0x000F23F9
		public unsafe bool bMatchRotationYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneSkeletalAnimationSection.__PropertyOffset_bMatchRotationYaw) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneSkeletalAnimationSection.__PropertyOffset_bMatchRotationYaw) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001EA2 RID: 7842
		// (get) Token: 0x0600A548 RID: 42312 RVA: 0x000F420A File Offset: 0x000F240A
		// (set) Token: 0x0600A549 RID: 42313 RVA: 0x000F421A File Offset: 0x000F241A
		public unsafe bool bMatchRotationPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneSkeletalAnimationSection.__PropertyOffset_bMatchRotationPitch) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneSkeletalAnimationSection.__PropertyOffset_bMatchRotationPitch) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001EA3 RID: 7843
		// (get) Token: 0x0600A54A RID: 42314 RVA: 0x000F422B File Offset: 0x000F242B
		// (set) Token: 0x0600A54B RID: 42315 RVA: 0x000F423B File Offset: 0x000F243B
		public unsafe bool bMatchRotationRoll
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneSkeletalAnimationSection.__PropertyOffset_bMatchRotationRoll) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneSkeletalAnimationSection.__PropertyOffset_bMatchRotationRoll) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001EA4 RID: 7844
		// (get) Token: 0x0600A54C RID: 42316 RVA: 0x000F424C File Offset: 0x000F244C
		// (set) Token: 0x0600A54D RID: 42317 RVA: 0x000F425C File Offset: 0x000F245C
		public unsafe bool bMatchConnectedFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneSkeletalAnimationSection.__PropertyOffset_bMatchConnectedFrame) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneSkeletalAnimationSection.__PropertyOffset_bMatchConnectedFrame) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600A54E RID: 42318 RVA: 0x000F426D File Offset: 0x000F246D
		static UMovieSceneSkeletalAnimationSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneSkeletalAnimationSection");
		}

		// Token: 0x0600A54F RID: 42319 RVA: 0x000F427B File Offset: 0x000F247B
		protected UMovieSceneSkeletalAnimationSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004687 RID: 18055
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneSkeletalAnimationSection";

		// Token: 0x04004688 RID: 18056
		private static IntPtr _ClassPtr;

		// Token: 0x04004689 RID: 18057
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400468A RID: 18058
		internal static int __PropertyOffset_Params;

		// Token: 0x0400468B RID: 18059
		private FMovieSceneSkeletalAnimationParams _Params;

		// Token: 0x0400468C RID: 18060
		internal static int __PropertyOffset_AnimSequence_DEPRECATED;

		// Token: 0x0400468D RID: 18061
		internal static int __PropertyOffset_Animation_DEPRECATED;

		// Token: 0x0400468E RID: 18062
		internal static int __PropertyOffset_StartOffset_DEPRECATED;

		// Token: 0x0400468F RID: 18063
		internal static int __PropertyOffset_EndOffset_DEPRECATED;

		// Token: 0x04004690 RID: 18064
		internal static int __PropertyOffset_PlayRate_DEPRECATED;

		// Token: 0x04004691 RID: 18065
		internal static int __PropertyOffset_bReverse_DEPRECATED;

		// Token: 0x04004692 RID: 18066
		internal static byte __PropertyMask_bReverse_DEPRECATED;

		// Token: 0x04004693 RID: 18067
		internal static int __PropertyOffset_SlotName_DEPRECATED;

		// Token: 0x04004694 RID: 18068
		internal static int __PropertyOffset_StartLocationOffset;

		// Token: 0x04004695 RID: 18069
		internal static int __PropertyOffset_StartRotationOffset;

		// Token: 0x04004696 RID: 18070
		internal static int __PropertyOffset_bMatchWithPrevious;

		// Token: 0x04004697 RID: 18071
		internal static int __PropertyOffset_MatchedBoneName;

		// Token: 0x04004698 RID: 18072
		internal static int __PropertyOffset_MatchedLocationOffset;

		// Token: 0x04004699 RID: 18073
		internal static int __PropertyOffset_MatchedRotationOffset;

		// Token: 0x0400469A RID: 18074
		internal static int __PropertyOffset_bMatchTranslation;

		// Token: 0x0400469B RID: 18075
		internal static int __PropertyOffset_bMatchIncludeZHeight;

		// Token: 0x0400469C RID: 18076
		internal static int __PropertyOffset_bMatchRotationYaw;

		// Token: 0x0400469D RID: 18077
		internal static int __PropertyOffset_bMatchRotationPitch;

		// Token: 0x0400469E RID: 18078
		internal static int __PropertyOffset_bMatchRotationRoll;

		// Token: 0x0400469F RID: 18079
		internal static int __PropertyOffset_bMatchConnectedFrame;
	}
}
