using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002523 RID: 9507
	[UnrealObjectPath("/Script/Niagara.MovieSceneNiagaraFloatParameterTrack")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UMovieSceneNiagaraFloatParameterTrack : UMovieSceneNiagaraParameterTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06023509 RID: 144649 RVA: 0x00343B61 File Offset: 0x00341D61
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneNiagaraFloatParameterTrack._ClassPtr;
		}

		// Token: 0x0602350A RID: 144650 RVA: 0x00343B6D File Offset: 0x00341D6D
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneNiagaraFloatParameterTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x0602350B RID: 144651 RVA: 0x00343B74 File Offset: 0x00341D74
		public UMovieSceneNiagaraFloatParameterTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneNiagaraFloatParameterTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602350C RID: 144652 RVA: 0x00343B9C File Offset: 0x00341D9C
		[NullableContext(1)]
		public UMovieSceneNiagaraFloatParameterTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneNiagaraFloatParameterTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602350D RID: 144653 RVA: 0x00343BCF File Offset: 0x00341DCF
		static UMovieSceneNiagaraFloatParameterTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.MovieSceneNiagaraFloatParameterTrack");
		}

		// Token: 0x0602350E RID: 144654 RVA: 0x00343BDD File Offset: 0x00341DDD
		protected UMovieSceneNiagaraFloatParameterTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012F53 RID: 77651
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x04012F54 RID: 77652
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.MovieSceneNiagaraFloatParameterTrack";

		// Token: 0x04012F55 RID: 77653
		private static IntPtr _ClassPtr;

		// Token: 0x04012F56 RID: 77654
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
