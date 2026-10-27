using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002356 RID: 9046
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneCameraShakeSourceTriggerTrack")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UMovieSceneCameraShakeSourceTriggerTrack : UMovieSceneTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060222EB RID: 140011 RVA: 0x00328B96 File Offset: 0x00326D96
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneCameraShakeSourceTriggerTrack._ClassPtr;
		}

		// Token: 0x060222EC RID: 140012 RVA: 0x00328BA2 File Offset: 0x00326DA2
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneCameraShakeSourceTriggerTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x060222ED RID: 140013 RVA: 0x00328BAC File Offset: 0x00326DAC
		public UMovieSceneCameraShakeSourceTriggerTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneCameraShakeSourceTriggerTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060222EE RID: 140014 RVA: 0x00328BD4 File Offset: 0x00326DD4
		[NullableContext(1)]
		public UMovieSceneCameraShakeSourceTriggerTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneCameraShakeSourceTriggerTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008402 RID: 33794
		// (get) Token: 0x060222EF RID: 140015 RVA: 0x00328C08 File Offset: 0x00326E08
		// (set) Token: 0x060222F0 RID: 140016 RVA: 0x00328C41 File Offset: 0x00326E41
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
					result = (this._Sections = new TArray<UMovieSceneSection>(base.NativePtr + (IntPtr)UMovieSceneCameraShakeSourceTriggerTrack.__PropertyOffset_Sections, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Sections.CopyAssign(value);
			}
		}

		// Token: 0x060222F1 RID: 140017 RVA: 0x00328C4F File Offset: 0x00326E4F
		static UMovieSceneCameraShakeSourceTriggerTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneCameraShakeSourceTriggerTrack");
		}

		// Token: 0x060222F2 RID: 140018 RVA: 0x00328C5D File Offset: 0x00326E5D
		protected UMovieSceneCameraShakeSourceTriggerTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040123EC RID: 74732
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x040123ED RID: 74733
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneCameraShakeSourceTriggerTrack";

		// Token: 0x040123EE RID: 74734
		private static IntPtr _ClassPtr;

		// Token: 0x040123EF RID: 74735
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040123F0 RID: 74736
		internal static int __PropertyOffset_Sections;

		// Token: 0x040123F1 RID: 74737
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _Sections;
	}
}
