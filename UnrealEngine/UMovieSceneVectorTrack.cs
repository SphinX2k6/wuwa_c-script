using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023BB RID: 9147
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneVectorTrack")]
	[UnrealStructLayout(328, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 328)]
	public class UMovieSceneVectorTrack : UMovieScenePropertyTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060226C3 RID: 140995 RVA: 0x0032E830 File Offset: 0x0032CA30
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneVectorTrack._ClassPtr;
		}

		// Token: 0x060226C4 RID: 140996 RVA: 0x0032E83C File Offset: 0x0032CA3C
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneVectorTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x060226C5 RID: 140997 RVA: 0x0032E844 File Offset: 0x0032CA44
		public UMovieSceneVectorTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneVectorTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060226C6 RID: 140998 RVA: 0x0032E86C File Offset: 0x0032CA6C
		[NullableContext(1)]
		public UMovieSceneVectorTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneVectorTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700849D RID: 33949
		// (get) Token: 0x060226C7 RID: 140999 RVA: 0x0032E89F File Offset: 0x0032CA9F
		// (set) Token: 0x060226C8 RID: 141000 RVA: 0x0032E8AF File Offset: 0x0032CAAF
		public unsafe int NumChannelsUsed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneVectorTrack.__PropertyOffset_NumChannelsUsed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneVectorTrack.__PropertyOffset_NumChannelsUsed) = value;
			}
		}

		// Token: 0x060226C9 RID: 141001 RVA: 0x0032E8C0 File Offset: 0x0032CAC0
		static UMovieSceneVectorTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneVectorTrack");
		}

		// Token: 0x060226CA RID: 141002 RVA: 0x0032E8CE File Offset: 0x0032CACE
		protected UMovieSceneVectorTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040125FE RID: 75262
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x040125FF RID: 75263
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneVectorTrack";

		// Token: 0x04012600 RID: 75264
		private static IntPtr _ClassPtr;

		// Token: 0x04012601 RID: 75265
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012602 RID: 75266
		internal static int __PropertyOffset_NumChannelsUsed;
	}
}
