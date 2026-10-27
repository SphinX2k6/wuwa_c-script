using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002528 RID: 9512
	[UnrealObjectPath("/Script/Niagara.MovieSceneNiagaraSystemSpawnSection")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UMovieSceneNiagaraSystemSpawnSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023530 RID: 144688 RVA: 0x00343F15 File Offset: 0x00342115
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneNiagaraSystemSpawnSection._ClassPtr;
		}

		// Token: 0x06023531 RID: 144689 RVA: 0x00343F24 File Offset: 0x00342124
		public UMovieSceneNiagaraSystemSpawnSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneNiagaraSystemSpawnSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023532 RID: 144690 RVA: 0x00343F4C File Offset: 0x0034214C
		[NullableContext(1)]
		public UMovieSceneNiagaraSystemSpawnSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneNiagaraSystemSpawnSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170087D4 RID: 34772
		// (get) Token: 0x06023533 RID: 144691 RVA: 0x00343F7F File Offset: 0x0034217F
		// (set) Token: 0x06023534 RID: 144692 RVA: 0x00343F8F File Offset: 0x0034218F
		public unsafe ENiagaraSystemSpawnSectionStartBehavior SectionStartBehavior
		{
			get
			{
				return (ENiagaraSystemSpawnSectionStartBehavior)(*(base.NativePtr + (IntPtr)UMovieSceneNiagaraSystemSpawnSection.__PropertyOffset_SectionStartBehavior));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneNiagaraSystemSpawnSection.__PropertyOffset_SectionStartBehavior) = (int)value;
			}
		}

		// Token: 0x170087D5 RID: 34773
		// (get) Token: 0x06023535 RID: 144693 RVA: 0x00343FA0 File Offset: 0x003421A0
		// (set) Token: 0x06023536 RID: 144694 RVA: 0x00343FB0 File Offset: 0x003421B0
		public unsafe ENiagaraSystemSpawnSectionEvaluateBehavior SectionEvaluateBehavior
		{
			get
			{
				return (ENiagaraSystemSpawnSectionEvaluateBehavior)(*(base.NativePtr + (IntPtr)UMovieSceneNiagaraSystemSpawnSection.__PropertyOffset_SectionEvaluateBehavior));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneNiagaraSystemSpawnSection.__PropertyOffset_SectionEvaluateBehavior) = (int)value;
			}
		}

		// Token: 0x170087D6 RID: 34774
		// (get) Token: 0x06023537 RID: 144695 RVA: 0x00343FC1 File Offset: 0x003421C1
		// (set) Token: 0x06023538 RID: 144696 RVA: 0x00343FD1 File Offset: 0x003421D1
		public unsafe ENiagaraSystemSpawnSectionEndBehavior SectionEndBehavior
		{
			get
			{
				return (ENiagaraSystemSpawnSectionEndBehavior)(*(base.NativePtr + (IntPtr)UMovieSceneNiagaraSystemSpawnSection.__PropertyOffset_SectionEndBehavior));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneNiagaraSystemSpawnSection.__PropertyOffset_SectionEndBehavior) = (int)value;
			}
		}

		// Token: 0x170087D7 RID: 34775
		// (get) Token: 0x06023539 RID: 144697 RVA: 0x00343FE2 File Offset: 0x003421E2
		// (set) Token: 0x0602353A RID: 144698 RVA: 0x00343FF2 File Offset: 0x003421F2
		public unsafe ENiagaraAgeUpdateMode AgeUpdateMode
		{
			get
			{
				return (ENiagaraAgeUpdateMode)(*(base.NativePtr + (IntPtr)UMovieSceneNiagaraSystemSpawnSection.__PropertyOffset_AgeUpdateMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneNiagaraSystemSpawnSection.__PropertyOffset_AgeUpdateMode) = (byte)value;
			}
		}

		// Token: 0x0602353B RID: 144699 RVA: 0x00344003 File Offset: 0x00342203
		static UMovieSceneNiagaraSystemSpawnSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.MovieSceneNiagaraSystemSpawnSection");
		}

		// Token: 0x0602353C RID: 144700 RVA: 0x00344011 File Offset: 0x00342211
		protected UMovieSceneNiagaraSystemSpawnSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012F68 RID: 77672
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.MovieSceneNiagaraSystemSpawnSection";

		// Token: 0x04012F69 RID: 77673
		private static IntPtr _ClassPtr;

		// Token: 0x04012F6A RID: 77674
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012F6B RID: 77675
		internal static int __PropertyOffset_SectionStartBehavior;

		// Token: 0x04012F6C RID: 77676
		internal static int __PropertyOffset_SectionEvaluateBehavior;

		// Token: 0x04012F6D RID: 77677
		internal static int __PropertyOffset_SectionEndBehavior;

		// Token: 0x04012F6E RID: 77678
		internal static int __PropertyOffset_AgeUpdateMode;
	}
}
