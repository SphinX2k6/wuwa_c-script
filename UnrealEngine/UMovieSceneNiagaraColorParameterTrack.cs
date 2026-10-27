using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002521 RID: 9505
	[UnrealObjectPath("/Script/Niagara.MovieSceneNiagaraColorParameterTrack")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UMovieSceneNiagaraColorParameterTrack : UMovieSceneNiagaraParameterTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060234F9 RID: 144633 RVA: 0x003439F1 File Offset: 0x00341BF1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneNiagaraColorParameterTrack._ClassPtr;
		}

		// Token: 0x060234FA RID: 144634 RVA: 0x003439FD File Offset: 0x00341BFD
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneNiagaraColorParameterTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x060234FB RID: 144635 RVA: 0x00343A04 File Offset: 0x00341C04
		public UMovieSceneNiagaraColorParameterTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneNiagaraColorParameterTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060234FC RID: 144636 RVA: 0x00343A2C File Offset: 0x00341C2C
		[NullableContext(1)]
		public UMovieSceneNiagaraColorParameterTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneNiagaraColorParameterTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060234FD RID: 144637 RVA: 0x00343A5F File Offset: 0x00341C5F
		static UMovieSceneNiagaraColorParameterTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.MovieSceneNiagaraColorParameterTrack");
		}

		// Token: 0x060234FE RID: 144638 RVA: 0x00343A6D File Offset: 0x00341C6D
		protected UMovieSceneNiagaraColorParameterTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012F4B RID: 77643
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x04012F4C RID: 77644
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.MovieSceneNiagaraColorParameterTrack";

		// Token: 0x04012F4D RID: 77645
		private static IntPtr _ClassPtr;

		// Token: 0x04012F4E RID: 77646
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
