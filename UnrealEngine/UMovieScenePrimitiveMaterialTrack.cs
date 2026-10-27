using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200239F RID: 9119
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieScenePrimitiveMaterialTrack")]
	[UnrealStructLayout(328, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 328)]
	public class UMovieScenePrimitiveMaterialTrack : UMovieScenePropertyTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06022585 RID: 140677 RVA: 0x0032CB11 File Offset: 0x0032AD11
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieScenePrimitiveMaterialTrack._ClassPtr;
		}

		// Token: 0x06022586 RID: 140678 RVA: 0x0032CB1D File Offset: 0x0032AD1D
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieScenePrimitiveMaterialTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x06022587 RID: 140679 RVA: 0x0032CB24 File Offset: 0x0032AD24
		public UMovieScenePrimitiveMaterialTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieScenePrimitiveMaterialTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022588 RID: 140680 RVA: 0x0032CB4C File Offset: 0x0032AD4C
		[NullableContext(1)]
		public UMovieScenePrimitiveMaterialTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieScenePrimitiveMaterialTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008457 RID: 33879
		// (get) Token: 0x06022589 RID: 140681 RVA: 0x0032CB7F File Offset: 0x0032AD7F
		// (set) Token: 0x0602258A RID: 140682 RVA: 0x0032CB8F File Offset: 0x0032AD8F
		public unsafe int MaterialIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieScenePrimitiveMaterialTrack.__PropertyOffset_MaterialIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieScenePrimitiveMaterialTrack.__PropertyOffset_MaterialIndex) = value;
			}
		}

		// Token: 0x0602258B RID: 140683 RVA: 0x0032CBA0 File Offset: 0x0032ADA0
		static UMovieScenePrimitiveMaterialTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieScenePrimitiveMaterialTrack");
		}

		// Token: 0x0602258C RID: 140684 RVA: 0x0032CBAE File Offset: 0x0032ADAE
		protected UMovieScenePrimitiveMaterialTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012557 RID: 75095
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x04012558 RID: 75096
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieScenePrimitiveMaterialTrack";

		// Token: 0x04012559 RID: 75097
		private static IntPtr _ClassPtr;

		// Token: 0x0401255A RID: 75098
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401255B RID: 75099
		internal static int __PropertyOffset_MaterialIndex;
	}
}
