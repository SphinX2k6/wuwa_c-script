using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023A5 RID: 9125
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneSkeletalAnimationSection")]
	[UnrealStructLayout(752, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 752)]
	public class UMovieSceneSkeletalAnimationSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060225D8 RID: 140760 RVA: 0x0032D344 File Offset: 0x0032B544
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneSkeletalAnimationSection._ClassPtr;
		}

		// Token: 0x060225D9 RID: 140761 RVA: 0x0032D350 File Offset: 0x0032B550
		public UMovieSceneSkeletalAnimationSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSkeletalAnimationSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060225DA RID: 140762 RVA: 0x0032D378 File Offset: 0x0032B578
		[NullableContext(1)]
		public UMovieSceneSkeletalAnimationSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSkeletalAnimationSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008470 RID: 33904
		// (get) Token: 0x060225DB RID: 140763 RVA: 0x0032D3AC File Offset: 0x0032B5AC
		// (set) Token: 0x060225DC RID: 140764 RVA: 0x0032D3E5 File Offset: 0x0032B5E5
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

		// Token: 0x17008471 RID: 33905
		// (get) Token: 0x060225DD RID: 140765 RVA: 0x0032D406 File Offset: 0x0032B606
		// (set) Token: 0x060225DE RID: 140766 RVA: 0x0032D41A File Offset: 0x0032B61A
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

		// Token: 0x17008472 RID: 33906
		// (get) Token: 0x060225DF RID: 140767 RVA: 0x0032D42F File Offset: 0x0032B62F
		// (set) Token: 0x060225E0 RID: 140768 RVA: 0x0032D443 File Offset: 0x0032B643
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

		// Token: 0x17008473 RID: 33907
		// (get) Token: 0x060225E1 RID: 140769 RVA: 0x0032D458 File Offset: 0x0032B658
		// (set) Token: 0x060225E2 RID: 140770 RVA: 0x0032D468 File Offset: 0x0032B668
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

		// Token: 0x17008474 RID: 33908
		// (get) Token: 0x060225E3 RID: 140771 RVA: 0x0032D479 File Offset: 0x0032B679
		// (set) Token: 0x060225E4 RID: 140772 RVA: 0x0032D489 File Offset: 0x0032B689
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

		// Token: 0x17008475 RID: 33909
		// (get) Token: 0x060225E5 RID: 140773 RVA: 0x0032D49A File Offset: 0x0032B69A
		// (set) Token: 0x060225E6 RID: 140774 RVA: 0x0032D4AA File Offset: 0x0032B6AA
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

		// Token: 0x17008476 RID: 33910
		// (get) Token: 0x060225E7 RID: 140775 RVA: 0x0032D4BB File Offset: 0x0032B6BB
		// (set) Token: 0x060225E8 RID: 140776 RVA: 0x0032D4D4 File Offset: 0x0032B6D4
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

		// Token: 0x17008477 RID: 33911
		// (get) Token: 0x060225E9 RID: 140777 RVA: 0x0032D504 File Offset: 0x0032B704
		// (set) Token: 0x060225EA RID: 140778 RVA: 0x0032D518 File Offset: 0x0032B718
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

		// Token: 0x17008478 RID: 33912
		// (get) Token: 0x060225EB RID: 140779 RVA: 0x0032D52D File Offset: 0x0032B72D
		// (set) Token: 0x060225EC RID: 140780 RVA: 0x0032D541 File Offset: 0x0032B741
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

		// Token: 0x17008479 RID: 33913
		// (get) Token: 0x060225ED RID: 140781 RVA: 0x0032D556 File Offset: 0x0032B756
		// (set) Token: 0x060225EE RID: 140782 RVA: 0x0032D56A File Offset: 0x0032B76A
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

		// Token: 0x1700847A RID: 33914
		// (get) Token: 0x060225EF RID: 140783 RVA: 0x0032D57F File Offset: 0x0032B77F
		// (set) Token: 0x060225F0 RID: 140784 RVA: 0x0032D58F File Offset: 0x0032B78F
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

		// Token: 0x1700847B RID: 33915
		// (get) Token: 0x060225F1 RID: 140785 RVA: 0x0032D5A0 File Offset: 0x0032B7A0
		// (set) Token: 0x060225F2 RID: 140786 RVA: 0x0032D5B4 File Offset: 0x0032B7B4
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

		// Token: 0x1700847C RID: 33916
		// (get) Token: 0x060225F3 RID: 140787 RVA: 0x0032D5C9 File Offset: 0x0032B7C9
		// (set) Token: 0x060225F4 RID: 140788 RVA: 0x0032D5DD File Offset: 0x0032B7DD
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

		// Token: 0x1700847D RID: 33917
		// (get) Token: 0x060225F5 RID: 140789 RVA: 0x0032D5F2 File Offset: 0x0032B7F2
		// (set) Token: 0x060225F6 RID: 140790 RVA: 0x0032D606 File Offset: 0x0032B806
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

		// Token: 0x1700847E RID: 33918
		// (get) Token: 0x060225F7 RID: 140791 RVA: 0x0032D61B File Offset: 0x0032B81B
		// (set) Token: 0x060225F8 RID: 140792 RVA: 0x0032D62B File Offset: 0x0032B82B
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

		// Token: 0x1700847F RID: 33919
		// (get) Token: 0x060225F9 RID: 140793 RVA: 0x0032D63C File Offset: 0x0032B83C
		// (set) Token: 0x060225FA RID: 140794 RVA: 0x0032D64C File Offset: 0x0032B84C
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

		// Token: 0x17008480 RID: 33920
		// (get) Token: 0x060225FB RID: 140795 RVA: 0x0032D65D File Offset: 0x0032B85D
		// (set) Token: 0x060225FC RID: 140796 RVA: 0x0032D66D File Offset: 0x0032B86D
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

		// Token: 0x17008481 RID: 33921
		// (get) Token: 0x060225FD RID: 140797 RVA: 0x0032D67E File Offset: 0x0032B87E
		// (set) Token: 0x060225FE RID: 140798 RVA: 0x0032D68E File Offset: 0x0032B88E
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

		// Token: 0x17008482 RID: 33922
		// (get) Token: 0x060225FF RID: 140799 RVA: 0x0032D69F File Offset: 0x0032B89F
		// (set) Token: 0x06022600 RID: 140800 RVA: 0x0032D6AF File Offset: 0x0032B8AF
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

		// Token: 0x17008483 RID: 33923
		// (get) Token: 0x06022601 RID: 140801 RVA: 0x0032D6C0 File Offset: 0x0032B8C0
		// (set) Token: 0x06022602 RID: 140802 RVA: 0x0032D6D0 File Offset: 0x0032B8D0
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

		// Token: 0x06022603 RID: 140803 RVA: 0x0032D6E1 File Offset: 0x0032B8E1
		static UMovieSceneSkeletalAnimationSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneSkeletalAnimationSection");
		}

		// Token: 0x06022604 RID: 140804 RVA: 0x0032D6EF File Offset: 0x0032B8EF
		protected UMovieSceneSkeletalAnimationSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401258A RID: 75146
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneSkeletalAnimationSection";

		// Token: 0x0401258B RID: 75147
		private static IntPtr _ClassPtr;

		// Token: 0x0401258C RID: 75148
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401258D RID: 75149
		internal static int __PropertyOffset_Params;

		// Token: 0x0401258E RID: 75150
		private FMovieSceneSkeletalAnimationParams _Params;

		// Token: 0x0401258F RID: 75151
		internal static int __PropertyOffset_AnimSequence_DEPRECATED;

		// Token: 0x04012590 RID: 75152
		internal static int __PropertyOffset_Animation_DEPRECATED;

		// Token: 0x04012591 RID: 75153
		internal static int __PropertyOffset_StartOffset_DEPRECATED;

		// Token: 0x04012592 RID: 75154
		internal static int __PropertyOffset_EndOffset_DEPRECATED;

		// Token: 0x04012593 RID: 75155
		internal static int __PropertyOffset_PlayRate_DEPRECATED;

		// Token: 0x04012594 RID: 75156
		internal static int __PropertyOffset_bReverse_DEPRECATED;

		// Token: 0x04012595 RID: 75157
		internal static byte __PropertyMask_bReverse_DEPRECATED;

		// Token: 0x04012596 RID: 75158
		internal static int __PropertyOffset_SlotName_DEPRECATED;

		// Token: 0x04012597 RID: 75159
		internal static int __PropertyOffset_StartLocationOffset;

		// Token: 0x04012598 RID: 75160
		internal static int __PropertyOffset_StartRotationOffset;

		// Token: 0x04012599 RID: 75161
		internal static int __PropertyOffset_bMatchWithPrevious;

		// Token: 0x0401259A RID: 75162
		internal static int __PropertyOffset_MatchedBoneName;

		// Token: 0x0401259B RID: 75163
		internal static int __PropertyOffset_MatchedLocationOffset;

		// Token: 0x0401259C RID: 75164
		internal static int __PropertyOffset_MatchedRotationOffset;

		// Token: 0x0401259D RID: 75165
		internal static int __PropertyOffset_bMatchTranslation;

		// Token: 0x0401259E RID: 75166
		internal static int __PropertyOffset_bMatchIncludeZHeight;

		// Token: 0x0401259F RID: 75167
		internal static int __PropertyOffset_bMatchRotationYaw;

		// Token: 0x040125A0 RID: 75168
		internal static int __PropertyOffset_bMatchRotationPitch;

		// Token: 0x040125A1 RID: 75169
		internal static int __PropertyOffset_bMatchRotationRoll;

		// Token: 0x040125A2 RID: 75170
		internal static int __PropertyOffset_bMatchConnectedFrame;
	}
}
