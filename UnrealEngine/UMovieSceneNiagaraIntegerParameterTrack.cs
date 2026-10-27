using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002525 RID: 9509
	[UnrealObjectPath("/Script/Niagara.MovieSceneNiagaraIntegerParameterTrack")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UMovieSceneNiagaraIntegerParameterTrack : UMovieSceneNiagaraParameterTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06023519 RID: 144665 RVA: 0x00343CD1 File Offset: 0x00341ED1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneNiagaraIntegerParameterTrack._ClassPtr;
		}

		// Token: 0x0602351A RID: 144666 RVA: 0x00343CDD File Offset: 0x00341EDD
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneNiagaraIntegerParameterTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x0602351B RID: 144667 RVA: 0x00343CE4 File Offset: 0x00341EE4
		public UMovieSceneNiagaraIntegerParameterTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneNiagaraIntegerParameterTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602351C RID: 144668 RVA: 0x00343D0C File Offset: 0x00341F0C
		[NullableContext(1)]
		public UMovieSceneNiagaraIntegerParameterTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneNiagaraIntegerParameterTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602351D RID: 144669 RVA: 0x00343D3F File Offset: 0x00341F3F
		static UMovieSceneNiagaraIntegerParameterTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.MovieSceneNiagaraIntegerParameterTrack");
		}

		// Token: 0x0602351E RID: 144670 RVA: 0x00343D4D File Offset: 0x00341F4D
		protected UMovieSceneNiagaraIntegerParameterTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012F5B RID: 77659
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x04012F5C RID: 77660
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.MovieSceneNiagaraIntegerParameterTrack";

		// Token: 0x04012F5D RID: 77661
		private static IntPtr _ClassPtr;

		// Token: 0x04012F5E RID: 77662
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
