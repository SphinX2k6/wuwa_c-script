using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200238F RID: 9103
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneObjectPropertyTrack")]
	[UnrealStructLayout(328, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 328)]
	public class UMovieSceneObjectPropertyTrack : UMovieScenePropertyTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060224DF RID: 140511 RVA: 0x0032BB2D File Offset: 0x00329D2D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneObjectPropertyTrack._ClassPtr;
		}

		// Token: 0x060224E0 RID: 140512 RVA: 0x0032BB39 File Offset: 0x00329D39
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneObjectPropertyTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x060224E1 RID: 140513 RVA: 0x0032BB40 File Offset: 0x00329D40
		public UMovieSceneObjectPropertyTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneObjectPropertyTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060224E2 RID: 140514 RVA: 0x0032BB68 File Offset: 0x00329D68
		[NullableContext(1)]
		public UMovieSceneObjectPropertyTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneObjectPropertyTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008443 RID: 33859
		// (get) Token: 0x060224E3 RID: 140515 RVA: 0x0032BB9B File Offset: 0x00329D9B
		// (set) Token: 0x060224E4 RID: 140516 RVA: 0x0032BBAF File Offset: 0x00329DAF
		public unsafe UClassStackOnlyPtr PropertyClass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneObjectPropertyTrack.__PropertyOffset_PropertyClass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneObjectPropertyTrack.__PropertyOffset_PropertyClass) = value;
			}
		}

		// Token: 0x060224E5 RID: 140517 RVA: 0x0032BBC4 File Offset: 0x00329DC4
		static UMovieSceneObjectPropertyTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneObjectPropertyTrack");
		}

		// Token: 0x060224E6 RID: 140518 RVA: 0x0032BBD2 File Offset: 0x00329DD2
		protected UMovieSceneObjectPropertyTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012501 RID: 75009
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x04012502 RID: 75010
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneObjectPropertyTrack";

		// Token: 0x04012503 RID: 75011
		private static IntPtr _ClassPtr;

		// Token: 0x04012504 RID: 75012
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012505 RID: 75013
		internal static int __PropertyOffset_PropertyClass;
	}
}
