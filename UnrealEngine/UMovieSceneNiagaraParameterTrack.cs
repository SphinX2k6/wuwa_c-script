using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002527 RID: 9511
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.MovieSceneNiagaraParameterTrack")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class UMovieSceneNiagaraParameterTrack : UMovieSceneNiagaraTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023529 RID: 144681 RVA: 0x00343E39 File Offset: 0x00342039
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneNiagaraParameterTrack._ClassPtr;
		}

		// Token: 0x0602352A RID: 144682 RVA: 0x00343E48 File Offset: 0x00342048
		public UMovieSceneNiagaraParameterTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneNiagaraParameterTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602352B RID: 144683 RVA: 0x00343E70 File Offset: 0x00342070
		public UMovieSceneNiagaraParameterTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneNiagaraParameterTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170087D3 RID: 34771
		// (get) Token: 0x0602352C RID: 144684 RVA: 0x00343EA4 File Offset: 0x003420A4
		// (set) Token: 0x0602352D RID: 144685 RVA: 0x00343EDD File Offset: 0x003420DD
		public FNiagaraVariable Parameter
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariable result;
				if ((result = this._Parameter) == null)
				{
					result = (this._Parameter = new FNiagaraVariable(base.NativePtr + (IntPtr)UMovieSceneNiagaraParameterTrack.__PropertyOffset_Parameter, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariable.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneNiagaraParameterTrack.__PropertyOffset_Parameter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602352E RID: 144686 RVA: 0x00343EFE File Offset: 0x003420FE
		static UMovieSceneNiagaraParameterTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.MovieSceneNiagaraParameterTrack");
		}

		// Token: 0x0602352F RID: 144687 RVA: 0x00343F0C File Offset: 0x0034210C
		protected UMovieSceneNiagaraParameterTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012F63 RID: 77667
		public new const string __ObjectPath = "/Script/Niagara.MovieSceneNiagaraParameterTrack";

		// Token: 0x04012F64 RID: 77668
		private static IntPtr _ClassPtr;

		// Token: 0x04012F65 RID: 77669
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012F66 RID: 77670
		internal static int __PropertyOffset_Parameter;

		// Token: 0x04012F67 RID: 77671
		[Nullable(2)]
		private FNiagaraVariable _Parameter;
	}
}
