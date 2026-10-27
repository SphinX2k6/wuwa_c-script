using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002529 RID: 9513
	[UnrealObjectPath("/Script/Niagara.MovieSceneNiagaraSystemTrack")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UMovieSceneNiagaraSystemTrack : UMovieSceneNiagaraTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0602353D RID: 144701 RVA: 0x0034401A File Offset: 0x0034221A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneNiagaraSystemTrack._ClassPtr;
		}

		// Token: 0x0602353E RID: 144702 RVA: 0x00344026 File Offset: 0x00342226
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneNiagaraSystemTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x0602353F RID: 144703 RVA: 0x00344030 File Offset: 0x00342230
		public UMovieSceneNiagaraSystemTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneNiagaraSystemTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023540 RID: 144704 RVA: 0x00344058 File Offset: 0x00342258
		[NullableContext(1)]
		public UMovieSceneNiagaraSystemTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneNiagaraSystemTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06023541 RID: 144705 RVA: 0x0034408B File Offset: 0x0034228B
		static UMovieSceneNiagaraSystemTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.MovieSceneNiagaraSystemTrack");
		}

		// Token: 0x06023542 RID: 144706 RVA: 0x00344099 File Offset: 0x00342299
		protected UMovieSceneNiagaraSystemTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012F6F RID: 77679
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x04012F70 RID: 77680
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.MovieSceneNiagaraSystemTrack";

		// Token: 0x04012F71 RID: 77681
		private static IntPtr _ClassPtr;

		// Token: 0x04012F72 RID: 77682
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
