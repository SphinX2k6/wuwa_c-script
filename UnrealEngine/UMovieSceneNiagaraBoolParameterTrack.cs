using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200251F RID: 9503
	[UnrealObjectPath("/Script/Niagara.MovieSceneNiagaraBoolParameterTrack")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UMovieSceneNiagaraBoolParameterTrack : UMovieSceneNiagaraParameterTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060234E3 RID: 144611 RVA: 0x0034373D File Offset: 0x0034193D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneNiagaraBoolParameterTrack._ClassPtr;
		}

		// Token: 0x060234E4 RID: 144612 RVA: 0x00343749 File Offset: 0x00341949
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneNiagaraBoolParameterTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x060234E5 RID: 144613 RVA: 0x00343750 File Offset: 0x00341950
		public UMovieSceneNiagaraBoolParameterTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneNiagaraBoolParameterTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060234E6 RID: 144614 RVA: 0x00343778 File Offset: 0x00341978
		[NullableContext(1)]
		public UMovieSceneNiagaraBoolParameterTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneNiagaraBoolParameterTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060234E7 RID: 144615 RVA: 0x003437AB File Offset: 0x003419AB
		static UMovieSceneNiagaraBoolParameterTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.MovieSceneNiagaraBoolParameterTrack");
		}

		// Token: 0x060234E8 RID: 144616 RVA: 0x003437B9 File Offset: 0x003419B9
		protected UMovieSceneNiagaraBoolParameterTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012F3D RID: 77629
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x04012F3E RID: 77630
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.MovieSceneNiagaraBoolParameterTrack";

		// Token: 0x04012F3F RID: 77631
		private static IntPtr _ClassPtr;

		// Token: 0x04012F40 RID: 77632
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
