using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002361 RID: 9057
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneComponentMaterialTrack")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMovieSceneComponentMaterialTrack : UMovieSceneMaterialTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0602234F RID: 140111 RVA: 0x0032956C File Offset: 0x0032776C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneComponentMaterialTrack._ClassPtr;
		}

		// Token: 0x06022350 RID: 140112 RVA: 0x00329578 File Offset: 0x00327778
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneComponentMaterialTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x06022351 RID: 140113 RVA: 0x00329580 File Offset: 0x00327780
		public UMovieSceneComponentMaterialTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneComponentMaterialTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022352 RID: 140114 RVA: 0x003295A8 File Offset: 0x003277A8
		[NullableContext(1)]
		public UMovieSceneComponentMaterialTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneComponentMaterialTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008410 RID: 33808
		// (get) Token: 0x06022353 RID: 140115 RVA: 0x003295DB File Offset: 0x003277DB
		// (set) Token: 0x06022354 RID: 140116 RVA: 0x003295EB File Offset: 0x003277EB
		public unsafe int MaterialIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneComponentMaterialTrack.__PropertyOffset_MaterialIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneComponentMaterialTrack.__PropertyOffset_MaterialIndex) = value;
			}
		}

		// Token: 0x06022355 RID: 140117 RVA: 0x003295FC File Offset: 0x003277FC
		static UMovieSceneComponentMaterialTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneComponentMaterialTrack");
		}

		// Token: 0x06022356 RID: 140118 RVA: 0x0032960A File Offset: 0x0032780A
		protected UMovieSceneComponentMaterialTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012425 RID: 74789
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x04012426 RID: 74790
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneComponentMaterialTrack";

		// Token: 0x04012427 RID: 74791
		private static IntPtr _ClassPtr;

		// Token: 0x04012428 RID: 74792
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012429 RID: 74793
		internal static int __PropertyOffset_MaterialIndex;
	}
}
