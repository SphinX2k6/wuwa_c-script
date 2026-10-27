using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C05 RID: 7173
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.MovieSceneKuroMaterialParameterCustomTrack")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UMovieSceneKuroMaterialParameterCustomTrack : UMovieSceneMaterialTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0601BAEF RID: 113391 RVA: 0x0028BEC0 File Offset: 0x0028A0C0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneKuroMaterialParameterCustomTrack._ClassPtr;
		}

		// Token: 0x0601BAF0 RID: 113392 RVA: 0x0028BECC File Offset: 0x0028A0CC
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneKuroMaterialParameterCustomTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x0601BAF1 RID: 113393 RVA: 0x0028BED4 File Offset: 0x0028A0D4
		public UMovieSceneKuroMaterialParameterCustomTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneKuroMaterialParameterCustomTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601BAF2 RID: 113394 RVA: 0x0028BEFC File Offset: 0x0028A0FC
		[NullableContext(1)]
		public UMovieSceneKuroMaterialParameterCustomTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneKuroMaterialParameterCustomTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601BAF3 RID: 113395 RVA: 0x0028BF2F File Offset: 0x0028A12F
		static UMovieSceneKuroMaterialParameterCustomTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.MovieSceneKuroMaterialParameterCustomTrack");
		}

		// Token: 0x0601BAF4 RID: 113396 RVA: 0x0028BF3D File Offset: 0x0028A13D
		protected UMovieSceneKuroMaterialParameterCustomTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EE38 RID: 60984
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x0400EE39 RID: 60985
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.MovieSceneKuroMaterialParameterCustomTrack";

		// Token: 0x0400EE3A RID: 60986
		private static IntPtr _ClassPtr;

		// Token: 0x0400EE3B RID: 60987
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
