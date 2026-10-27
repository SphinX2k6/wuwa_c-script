using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002394 RID: 9108
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneParticleParameterTrack")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UMovieSceneParticleParameterTrack : UMovieSceneNameableTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06022536 RID: 140598 RVA: 0x0032C340 File Offset: 0x0032A540
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneParticleParameterTrack._ClassPtr;
		}

		// Token: 0x06022537 RID: 140599 RVA: 0x0032C34C File Offset: 0x0032A54C
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneParticleParameterTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x06022538 RID: 140600 RVA: 0x0032C354 File Offset: 0x0032A554
		public UMovieSceneParticleParameterTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneParticleParameterTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022539 RID: 140601 RVA: 0x0032C37C File Offset: 0x0032A57C
		[NullableContext(1)]
		public UMovieSceneParticleParameterTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneParticleParameterTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008450 RID: 33872
		// (get) Token: 0x0602253A RID: 140602 RVA: 0x0032C3B0 File Offset: 0x0032A5B0
		// (set) Token: 0x0602253B RID: 140603 RVA: 0x0032C3E9 File Offset: 0x0032A5E9
		[Nullable(1)]
		public TArray<UMovieSceneSection> Sections
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMovieSceneSection> result;
				if ((result = this._Sections) == null)
				{
					result = (this._Sections = new TArray<UMovieSceneSection>(base.NativePtr + (IntPtr)UMovieSceneParticleParameterTrack.__PropertyOffset_Sections, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Sections.CopyAssign(value);
			}
		}

		// Token: 0x0602253C RID: 140604 RVA: 0x0032C3F7 File Offset: 0x0032A5F7
		static UMovieSceneParticleParameterTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneParticleParameterTrack");
		}

		// Token: 0x0602253D RID: 140605 RVA: 0x0032C405 File Offset: 0x0032A605
		protected UMovieSceneParticleParameterTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012527 RID: 75047
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x04012528 RID: 75048
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneParticleParameterTrack";

		// Token: 0x04012529 RID: 75049
		private static IntPtr _ClassPtr;

		// Token: 0x0401252A RID: 75050
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401252B RID: 75051
		internal static int __PropertyOffset_Sections;

		// Token: 0x0401252C RID: 75052
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _Sections;
	}
}
