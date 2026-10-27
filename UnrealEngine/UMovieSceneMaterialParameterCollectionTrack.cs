using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002389 RID: 9097
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneMaterialParameterCollectionTrack")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMovieSceneMaterialParameterCollectionTrack : UMovieSceneMaterialTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060224A3 RID: 140451 RVA: 0x0032B5B4 File Offset: 0x003297B4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneMaterialParameterCollectionTrack._ClassPtr;
		}

		// Token: 0x060224A4 RID: 140452 RVA: 0x0032B5C0 File Offset: 0x003297C0
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneMaterialParameterCollectionTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x060224A5 RID: 140453 RVA: 0x0032B5C8 File Offset: 0x003297C8
		public UMovieSceneMaterialParameterCollectionTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneMaterialParameterCollectionTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060224A6 RID: 140454 RVA: 0x0032B5F0 File Offset: 0x003297F0
		[NullableContext(1)]
		public UMovieSceneMaterialParameterCollectionTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneMaterialParameterCollectionTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008439 RID: 33849
		// (get) Token: 0x060224A7 RID: 140455 RVA: 0x0032B623 File Offset: 0x00329823
		// (set) Token: 0x060224A8 RID: 140456 RVA: 0x0032B637 File Offset: 0x00329837
		[Nullable(2)]
		public unsafe UMaterialParameterCollection MPC
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneMaterialParameterCollectionTrack.__PropertyOffset_MPC);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneMaterialParameterCollectionTrack.__PropertyOffset_MPC, value);
			}
		}

		// Token: 0x060224A9 RID: 140457 RVA: 0x0032B64C File Offset: 0x0032984C
		static UMovieSceneMaterialParameterCollectionTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneMaterialParameterCollectionTrack");
		}

		// Token: 0x060224AA RID: 140458 RVA: 0x0032B65A File Offset: 0x0032985A
		protected UMovieSceneMaterialParameterCollectionTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040124E2 RID: 74978
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x040124E3 RID: 74979
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneMaterialParameterCollectionTrack";

		// Token: 0x040124E4 RID: 74980
		private static IntPtr _ClassPtr;

		// Token: 0x040124E5 RID: 74981
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040124E6 RID: 74982
		internal static int __PropertyOffset_MPC;
	}
}
