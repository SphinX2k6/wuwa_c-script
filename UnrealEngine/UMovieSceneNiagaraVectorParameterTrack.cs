using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002530 RID: 9520
	[UnrealObjectPath("/Script/Niagara.MovieSceneNiagaraVectorParameterTrack")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UMovieSceneNiagaraVectorParameterTrack : UMovieSceneNiagaraParameterTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06023582 RID: 144770 RVA: 0x00344630 File Offset: 0x00342830
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneNiagaraVectorParameterTrack._ClassPtr;
		}

		// Token: 0x06023583 RID: 144771 RVA: 0x0034463C File Offset: 0x0034283C
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneNiagaraVectorParameterTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x06023584 RID: 144772 RVA: 0x00344644 File Offset: 0x00342844
		public UMovieSceneNiagaraVectorParameterTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneNiagaraVectorParameterTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023585 RID: 144773 RVA: 0x0034466C File Offset: 0x0034286C
		[NullableContext(1)]
		public UMovieSceneNiagaraVectorParameterTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneNiagaraVectorParameterTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170087E2 RID: 34786
		// (get) Token: 0x06023586 RID: 144774 RVA: 0x0034469F File Offset: 0x0034289F
		// (set) Token: 0x06023587 RID: 144775 RVA: 0x003446AF File Offset: 0x003428AF
		public unsafe int ChannelsUsed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneNiagaraVectorParameterTrack.__PropertyOffset_ChannelsUsed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneNiagaraVectorParameterTrack.__PropertyOffset_ChannelsUsed) = value;
			}
		}

		// Token: 0x06023588 RID: 144776 RVA: 0x003446C0 File Offset: 0x003428C0
		static UMovieSceneNiagaraVectorParameterTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.MovieSceneNiagaraVectorParameterTrack");
		}

		// Token: 0x06023589 RID: 144777 RVA: 0x003446CE File Offset: 0x003428CE
		protected UMovieSceneNiagaraVectorParameterTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012F91 RID: 77713
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x04012F92 RID: 77714
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.MovieSceneNiagaraVectorParameterTrack";

		// Token: 0x04012F93 RID: 77715
		private static IntPtr _ClassPtr;

		// Token: 0x04012F94 RID: 77716
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012F95 RID: 77717
		internal static int __PropertyOffset_ChannelsUsed;
	}
}
