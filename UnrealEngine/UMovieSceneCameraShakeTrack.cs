using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002357 RID: 9047
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneCameraShakeTrack")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UMovieSceneCameraShakeTrack : UMovieSceneNameableTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060222F3 RID: 140019 RVA: 0x00328C66 File Offset: 0x00326E66
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneCameraShakeTrack._ClassPtr;
		}

		// Token: 0x060222F4 RID: 140020 RVA: 0x00328C72 File Offset: 0x00326E72
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneCameraShakeTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x060222F5 RID: 140021 RVA: 0x00328C7C File Offset: 0x00326E7C
		public UMovieSceneCameraShakeTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneCameraShakeTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060222F6 RID: 140022 RVA: 0x00328CA4 File Offset: 0x00326EA4
		[NullableContext(1)]
		public UMovieSceneCameraShakeTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneCameraShakeTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008403 RID: 33795
		// (get) Token: 0x060222F7 RID: 140023 RVA: 0x00328CD8 File Offset: 0x00326ED8
		// (set) Token: 0x060222F8 RID: 140024 RVA: 0x00328D11 File Offset: 0x00326F11
		[Nullable(1)]
		public TArray<UMovieSceneSection> CameraShakeSections
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMovieSceneSection> result;
				if ((result = this._CameraShakeSections) == null)
				{
					result = (this._CameraShakeSections = new TArray<UMovieSceneSection>(base.NativePtr + (IntPtr)UMovieSceneCameraShakeTrack.__PropertyOffset_CameraShakeSections, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CameraShakeSections.CopyAssign(value);
			}
		}

		// Token: 0x060222F9 RID: 140025 RVA: 0x00328D1F File Offset: 0x00326F1F
		static UMovieSceneCameraShakeTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneCameraShakeTrack");
		}

		// Token: 0x060222FA RID: 140026 RVA: 0x00328D2D File Offset: 0x00326F2D
		protected UMovieSceneCameraShakeTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040123F2 RID: 74738
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x040123F3 RID: 74739
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneCameraShakeTrack";

		// Token: 0x040123F4 RID: 74740
		private static IntPtr _ClassPtr;

		// Token: 0x040123F5 RID: 74741
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040123F6 RID: 74742
		internal static int __PropertyOffset_CameraShakeSections;

		// Token: 0x040123F7 RID: 74743
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _CameraShakeSections;
	}
}
