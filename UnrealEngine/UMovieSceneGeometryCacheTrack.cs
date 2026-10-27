using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200140B RID: 5131
	[UnrealObjectPath("/Script/GeometryCacheTracks.MovieSceneGeometryCacheTrack")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UMovieSceneGeometryCacheTrack : UMovieSceneNameableTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06012BB0 RID: 76720 RVA: 0x001B92A4 File Offset: 0x001B74A4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneGeometryCacheTrack._ClassPtr;
		}

		// Token: 0x06012BB1 RID: 76721 RVA: 0x001B92B0 File Offset: 0x001B74B0
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneGeometryCacheTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x06012BB2 RID: 76722 RVA: 0x001B92B8 File Offset: 0x001B74B8
		public UMovieSceneGeometryCacheTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneGeometryCacheTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012BB3 RID: 76723 RVA: 0x001B92E0 File Offset: 0x001B74E0
		[NullableContext(1)]
		public UMovieSceneGeometryCacheTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneGeometryCacheTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700489C RID: 18588
		// (get) Token: 0x06012BB4 RID: 76724 RVA: 0x001B9314 File Offset: 0x001B7514
		// (set) Token: 0x06012BB5 RID: 76725 RVA: 0x001B934D File Offset: 0x001B754D
		[Nullable(1)]
		public TArray<UMovieSceneSection> AnimationSections
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMovieSceneSection> result;
				if ((result = this._AnimationSections) == null)
				{
					result = (this._AnimationSections = new TArray<UMovieSceneSection>(base.NativePtr + (IntPtr)UMovieSceneGeometryCacheTrack.__PropertyOffset_AnimationSections, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.AnimationSections.CopyAssign(value);
			}
		}

		// Token: 0x06012BB6 RID: 76726 RVA: 0x001B935B File Offset: 0x001B755B
		static UMovieSceneGeometryCacheTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GeometryCacheTracks.MovieSceneGeometryCacheTrack");
		}

		// Token: 0x06012BB7 RID: 76727 RVA: 0x001B9369 File Offset: 0x001B7569
		protected UMovieSceneGeometryCacheTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A037 RID: 41015
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x0400A038 RID: 41016
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GeometryCacheTracks.MovieSceneGeometryCacheTrack";

		// Token: 0x0400A039 RID: 41017
		private static IntPtr _ClassPtr;

		// Token: 0x0400A03A RID: 41018
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A03B RID: 41019
		internal static int __PropertyOffset_AnimationSections;

		// Token: 0x0400A03C RID: 41020
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _AnimationSections;
	}
}
