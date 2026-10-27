using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002348 RID: 9032
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneCameraAnimTrack")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UMovieSceneCameraAnimTrack : UMovieSceneNameableTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0602224C RID: 139852 RVA: 0x00327BBD File Offset: 0x00325DBD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneCameraAnimTrack._ClassPtr;
		}

		// Token: 0x0602224D RID: 139853 RVA: 0x00327BC9 File Offset: 0x00325DC9
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneCameraAnimTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x0602224E RID: 139854 RVA: 0x00327BD0 File Offset: 0x00325DD0
		public UMovieSceneCameraAnimTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneCameraAnimTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602224F RID: 139855 RVA: 0x00327BF8 File Offset: 0x00325DF8
		[NullableContext(1)]
		public UMovieSceneCameraAnimTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneCameraAnimTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170083E1 RID: 33761
		// (get) Token: 0x06022250 RID: 139856 RVA: 0x00327C2C File Offset: 0x00325E2C
		// (set) Token: 0x06022251 RID: 139857 RVA: 0x00327C65 File Offset: 0x00325E65
		[Nullable(1)]
		public TArray<UMovieSceneSection> CameraAnimSections
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMovieSceneSection> result;
				if ((result = this._CameraAnimSections) == null)
				{
					result = (this._CameraAnimSections = new TArray<UMovieSceneSection>(base.NativePtr + (IntPtr)UMovieSceneCameraAnimTrack.__PropertyOffset_CameraAnimSections, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CameraAnimSections.CopyAssign(value);
			}
		}

		// Token: 0x06022252 RID: 139858 RVA: 0x00327C73 File Offset: 0x00325E73
		static UMovieSceneCameraAnimTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneCameraAnimTrack");
		}

		// Token: 0x06022253 RID: 139859 RVA: 0x00327C81 File Offset: 0x00325E81
		protected UMovieSceneCameraAnimTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012392 RID: 74642
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x04012393 RID: 74643
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneCameraAnimTrack";

		// Token: 0x04012394 RID: 74644
		private static IntPtr _ClassPtr;

		// Token: 0x04012395 RID: 74645
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012396 RID: 74646
		internal static int __PropertyOffset_CameraAnimSections;

		// Token: 0x04012397 RID: 74647
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _CameraAnimSections;
	}
}
