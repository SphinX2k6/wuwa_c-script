using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002351 RID: 9041
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneCameraShakeSourceShakeTrack")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UMovieSceneCameraShakeSourceShakeTrack : UMovieSceneNameableTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060222B4 RID: 139956 RVA: 0x0032868D File Offset: 0x0032688D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneCameraShakeSourceShakeTrack._ClassPtr;
		}

		// Token: 0x060222B5 RID: 139957 RVA: 0x00328699 File Offset: 0x00326899
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneCameraShakeSourceShakeTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x060222B6 RID: 139958 RVA: 0x003286A0 File Offset: 0x003268A0
		public UMovieSceneCameraShakeSourceShakeTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneCameraShakeSourceShakeTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060222B7 RID: 139959 RVA: 0x003286C8 File Offset: 0x003268C8
		[NullableContext(1)]
		public UMovieSceneCameraShakeSourceShakeTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneCameraShakeSourceShakeTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170083F8 RID: 33784
		// (get) Token: 0x060222B8 RID: 139960 RVA: 0x003286FC File Offset: 0x003268FC
		// (set) Token: 0x060222B9 RID: 139961 RVA: 0x00328735 File Offset: 0x00326935
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
					result = (this._CameraShakeSections = new TArray<UMovieSceneSection>(base.NativePtr + (IntPtr)UMovieSceneCameraShakeSourceShakeTrack.__PropertyOffset_CameraShakeSections, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CameraShakeSections.CopyAssign(value);
			}
		}

		// Token: 0x060222BA RID: 139962 RVA: 0x00328743 File Offset: 0x00326943
		static UMovieSceneCameraShakeSourceShakeTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneCameraShakeSourceShakeTrack");
		}

		// Token: 0x060222BB RID: 139963 RVA: 0x00328751 File Offset: 0x00326951
		protected UMovieSceneCameraShakeSourceShakeTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040123CF RID: 74703
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x040123D0 RID: 74704
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneCameraShakeSourceShakeTrack";

		// Token: 0x040123D1 RID: 74705
		private static IntPtr _ClassPtr;

		// Token: 0x040123D2 RID: 74706
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040123D3 RID: 74707
		internal static int __PropertyOffset_CameraShakeSections;

		// Token: 0x040123D4 RID: 74708
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _CameraShakeSections;
	}
}
