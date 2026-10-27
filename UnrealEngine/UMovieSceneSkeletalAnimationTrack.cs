using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023A8 RID: 9128
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneSkeletalAnimationTrack")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UMovieSceneSkeletalAnimationTrack : UMovieSceneNameableTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0602261B RID: 140827 RVA: 0x0032D9C4 File Offset: 0x0032BBC4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneSkeletalAnimationTrack._ClassPtr;
		}

		// Token: 0x0602261C RID: 140828 RVA: 0x0032D9D0 File Offset: 0x0032BBD0
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneSkeletalAnimationTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x0602261D RID: 140829 RVA: 0x0032D9D8 File Offset: 0x0032BBD8
		public UMovieSceneSkeletalAnimationTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSkeletalAnimationTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602261E RID: 140830 RVA: 0x0032DA00 File Offset: 0x0032BC00
		public UMovieSceneSkeletalAnimationTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSkeletalAnimationTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008487 RID: 33927
		// (get) Token: 0x0602261F RID: 140831 RVA: 0x0032DA34 File Offset: 0x0032BC34
		// (set) Token: 0x06022620 RID: 140832 RVA: 0x0032DA6D File Offset: 0x0032BC6D
		public TArray<UMovieSceneSection> AnimationSections
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMovieSceneSection> result;
				if ((result = this._AnimationSections) == null)
				{
					result = (this._AnimationSections = new TArray<UMovieSceneSection>(base.NativePtr + (IntPtr)UMovieSceneSkeletalAnimationTrack.__PropertyOffset_AnimationSections, this));
				}
				return result;
			}
			set
			{
				this.AnimationSections.CopyAssign(value);
			}
		}

		// Token: 0x17008488 RID: 33928
		// (get) Token: 0x06022621 RID: 140833 RVA: 0x0032DA7B File Offset: 0x0032BC7B
		// (set) Token: 0x06022622 RID: 140834 RVA: 0x0032DA8B File Offset: 0x0032BC8B
		public unsafe bool bUseLegacySectionIndexBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneSkeletalAnimationTrack.__PropertyOffset_bUseLegacySectionIndexBlend) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneSkeletalAnimationTrack.__PropertyOffset_bUseLegacySectionIndexBlend) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008489 RID: 33929
		// (get) Token: 0x06022623 RID: 140835 RVA: 0x0032DA9C File Offset: 0x0032BC9C
		// (set) Token: 0x06022624 RID: 140836 RVA: 0x0032DAD5 File Offset: 0x0032BCD5
		public FMovieSceneSkeletalAnimRootMotionTrackParams RootMotionParams
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneSkeletalAnimRootMotionTrackParams result;
				if ((result = this._RootMotionParams) == null)
				{
					result = (this._RootMotionParams = new FMovieSceneSkeletalAnimRootMotionTrackParams(base.NativePtr + (IntPtr)UMovieSceneSkeletalAnimationTrack.__PropertyOffset_RootMotionParams, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneSkeletalAnimRootMotionTrackParams.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneSkeletalAnimationTrack.__PropertyOffset_RootMotionParams, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700848A RID: 33930
		// (get) Token: 0x06022625 RID: 140837 RVA: 0x0032DAF6 File Offset: 0x0032BCF6
		// (set) Token: 0x06022626 RID: 140838 RVA: 0x0032DB06 File Offset: 0x0032BD06
		public unsafe bool bBlendFirstChildOfRoot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneSkeletalAnimationTrack.__PropertyOffset_bBlendFirstChildOfRoot) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneSkeletalAnimationTrack.__PropertyOffset_bBlendFirstChildOfRoot) = (value ? 1 : 0);
			}
		}

		// Token: 0x06022627 RID: 140839 RVA: 0x0032DB17 File Offset: 0x0032BD17
		static UMovieSceneSkeletalAnimationTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneSkeletalAnimationTrack");
		}

		// Token: 0x06022628 RID: 140840 RVA: 0x0032DB25 File Offset: 0x0032BD25
		protected UMovieSceneSkeletalAnimationTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040125AD RID: 75181
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x040125AE RID: 75182
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneSkeletalAnimationTrack";

		// Token: 0x040125AF RID: 75183
		private static IntPtr _ClassPtr;

		// Token: 0x040125B0 RID: 75184
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040125B1 RID: 75185
		internal static int __PropertyOffset_AnimationSections;

		// Token: 0x040125B2 RID: 75186
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _AnimationSections;

		// Token: 0x040125B3 RID: 75187
		internal static int __PropertyOffset_bUseLegacySectionIndexBlend;

		// Token: 0x040125B4 RID: 75188
		internal static int __PropertyOffset_RootMotionParams;

		// Token: 0x040125B5 RID: 75189
		[Nullable(2)]
		private FMovieSceneSkeletalAnimRootMotionTrackParams _RootMotionParams;

		// Token: 0x040125B6 RID: 75190
		internal static int __PropertyOffset_bBlendFirstChildOfRoot;
	}
}
