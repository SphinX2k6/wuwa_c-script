using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002397 RID: 9111
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneParticleTrack")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UMovieSceneParticleTrack : UMovieSceneNameableTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0602254F RID: 140623 RVA: 0x0032C5CD File Offset: 0x0032A7CD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneParticleTrack._ClassPtr;
		}

		// Token: 0x06022550 RID: 140624 RVA: 0x0032C5D9 File Offset: 0x0032A7D9
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneParticleTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x06022551 RID: 140625 RVA: 0x0032C5E0 File Offset: 0x0032A7E0
		public UMovieSceneParticleTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneParticleTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022552 RID: 140626 RVA: 0x0032C608 File Offset: 0x0032A808
		[NullableContext(1)]
		public UMovieSceneParticleTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneParticleTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008453 RID: 33875
		// (get) Token: 0x06022553 RID: 140627 RVA: 0x0032C63C File Offset: 0x0032A83C
		// (set) Token: 0x06022554 RID: 140628 RVA: 0x0032C675 File Offset: 0x0032A875
		[Nullable(1)]
		public TArray<UMovieSceneSection> ParticleSections
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMovieSceneSection> result;
				if ((result = this._ParticleSections) == null)
				{
					result = (this._ParticleSections = new TArray<UMovieSceneSection>(base.NativePtr + (IntPtr)UMovieSceneParticleTrack.__PropertyOffset_ParticleSections, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ParticleSections.CopyAssign(value);
			}
		}

		// Token: 0x06022555 RID: 140629 RVA: 0x0032C683 File Offset: 0x0032A883
		static UMovieSceneParticleTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneParticleTrack");
		}

		// Token: 0x06022556 RID: 140630 RVA: 0x0032C691 File Offset: 0x0032A891
		protected UMovieSceneParticleTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012536 RID: 75062
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x04012537 RID: 75063
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneParticleTrack";

		// Token: 0x04012538 RID: 75064
		private static IntPtr _ClassPtr;

		// Token: 0x04012539 RID: 75065
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401253A RID: 75066
		internal static int __PropertyOffset_ParticleSections;

		// Token: 0x0401253B RID: 75067
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _ParticleSections;
	}
}
