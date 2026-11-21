using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000773 RID: 1907
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneSkeletalAnimationTrack")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UMovieSceneSkeletalAnimationTrack : UMovieSceneNameableTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A550 RID: 42320 RVA: 0x000F4284 File Offset: 0x000F2484
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneSkeletalAnimationTrack._ClassPtr;
		}

		// Token: 0x0600A551 RID: 42321 RVA: 0x000F4290 File Offset: 0x000F2490
		public UMovieSceneSkeletalAnimationTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSkeletalAnimationTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A552 RID: 42322 RVA: 0x000F42B8 File Offset: 0x000F24B8
		public UMovieSceneSkeletalAnimationTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSkeletalAnimationTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001EA5 RID: 7845
		// (get) Token: 0x0600A553 RID: 42323 RVA: 0x000F42EC File Offset: 0x000F24EC
		// (set) Token: 0x0600A554 RID: 42324 RVA: 0x000F4325 File Offset: 0x000F2525
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

		// Token: 0x17001EA6 RID: 7846
		// (get) Token: 0x0600A555 RID: 42325 RVA: 0x000F4333 File Offset: 0x000F2533
		// (set) Token: 0x0600A556 RID: 42326 RVA: 0x000F4343 File Offset: 0x000F2543
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

		// Token: 0x17001EA7 RID: 7847
		// (get) Token: 0x0600A557 RID: 42327 RVA: 0x000F4354 File Offset: 0x000F2554
		// (set) Token: 0x0600A558 RID: 42328 RVA: 0x000F4364 File Offset: 0x000F2564
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

		// Token: 0x0600A559 RID: 42329 RVA: 0x000F4375 File Offset: 0x000F2575
		static UMovieSceneSkeletalAnimationTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneSkeletalAnimationTrack");
		}

		// Token: 0x0600A55A RID: 42330 RVA: 0x000F4383 File Offset: 0x000F2583
		protected UMovieSceneSkeletalAnimationTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040046A0 RID: 18080
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneSkeletalAnimationTrack";

		// Token: 0x040046A1 RID: 18081
		private static IntPtr _ClassPtr;

		// Token: 0x040046A2 RID: 18082
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040046A3 RID: 18083
		internal static int __PropertyOffset_AnimationSections;

		// Token: 0x040046A4 RID: 18084
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _AnimationSections;

		// Token: 0x040046A5 RID: 18085
		internal static int __PropertyOffset_bUseLegacySectionIndexBlend;

		// Token: 0x040046A6 RID: 18086
		internal static int __PropertyOffset_bBlendFirstChildOfRoot;
	}
}
