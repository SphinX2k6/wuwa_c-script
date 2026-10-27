using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C07 RID: 7175
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.MovieSceneKuroMaterialParameterTrack")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UMovieSceneKuroMaterialParameterTrack : UMovieSceneMaterialTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0601BB01 RID: 113409 RVA: 0x0028C050 File Offset: 0x0028A250
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneKuroMaterialParameterTrack._ClassPtr;
		}

		// Token: 0x0601BB02 RID: 113410 RVA: 0x0028C05C File Offset: 0x0028A25C
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneKuroMaterialParameterTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x0601BB03 RID: 113411 RVA: 0x0028C064 File Offset: 0x0028A264
		public UMovieSceneKuroMaterialParameterTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneKuroMaterialParameterTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601BB04 RID: 113412 RVA: 0x0028C08C File Offset: 0x0028A28C
		[NullableContext(1)]
		public UMovieSceneKuroMaterialParameterTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneKuroMaterialParameterTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006FAD RID: 28589
		// (get) Token: 0x0601BB05 RID: 113413 RVA: 0x0028C0BF File Offset: 0x0028A2BF
		// (set) Token: 0x0601BB06 RID: 113414 RVA: 0x0028C0CF File Offset: 0x0028A2CF
		public unsafe int MaterialIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneKuroMaterialParameterTrack.__PropertyOffset_MaterialIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneKuroMaterialParameterTrack.__PropertyOffset_MaterialIndex) = value;
			}
		}

		// Token: 0x17006FAE RID: 28590
		// (get) Token: 0x0601BB07 RID: 113415 RVA: 0x0028C0E0 File Offset: 0x0028A2E0
		// (set) Token: 0x0601BB08 RID: 113416 RVA: 0x0028C0F4 File Offset: 0x0028A2F4
		public unsafe FName BodyName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneKuroMaterialParameterTrack.__PropertyOffset_BodyName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneKuroMaterialParameterTrack.__PropertyOffset_BodyName) = value;
			}
		}

		// Token: 0x0601BB09 RID: 113417 RVA: 0x0028C109 File Offset: 0x0028A309
		static UMovieSceneKuroMaterialParameterTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.MovieSceneKuroMaterialParameterTrack");
		}

		// Token: 0x0601BB0A RID: 113418 RVA: 0x0028C117 File Offset: 0x0028A317
		protected UMovieSceneKuroMaterialParameterTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EE40 RID: 60992
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x0400EE41 RID: 60993
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.MovieSceneKuroMaterialParameterTrack";

		// Token: 0x0400EE42 RID: 60994
		private static IntPtr _ClassPtr;

		// Token: 0x0400EE43 RID: 60995
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EE44 RID: 60996
		internal static int __PropertyOffset_MaterialIndex;

		// Token: 0x0400EE45 RID: 60997
		internal static int __PropertyOffset_BodyName;
	}
}
