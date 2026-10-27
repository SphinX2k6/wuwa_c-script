using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200252C RID: 9516
	[UnrealObjectPath("/Script/Niagara.MovieSceneNiagaraTimeTrack")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UMovieSceneNiagaraTimeTrack : UMovieSceneNiagaraTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0602355F RID: 144735 RVA: 0x003442FB File Offset: 0x003424FB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneNiagaraTimeTrack._ClassPtr;
		}

		// Token: 0x06023560 RID: 144736 RVA: 0x00344307 File Offset: 0x00342507
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneNiagaraTimeTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x06023561 RID: 144737 RVA: 0x00344310 File Offset: 0x00342510
		public UMovieSceneNiagaraTimeTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneNiagaraTimeTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023562 RID: 144738 RVA: 0x00344338 File Offset: 0x00342538
		[NullableContext(1)]
		public UMovieSceneNiagaraTimeTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneNiagaraTimeTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06023563 RID: 144739 RVA: 0x0034436B File Offset: 0x0034256B
		static UMovieSceneNiagaraTimeTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.MovieSceneNiagaraTimeTrack");
		}

		// Token: 0x06023564 RID: 144740 RVA: 0x00344379 File Offset: 0x00342579
		protected UMovieSceneNiagaraTimeTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012F7F RID: 77695
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x04012F80 RID: 77696
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.MovieSceneNiagaraTimeTrack";

		// Token: 0x04012F81 RID: 77697
		private static IntPtr _ClassPtr;

		// Token: 0x04012F82 RID: 77698
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
