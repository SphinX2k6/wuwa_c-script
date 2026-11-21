using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000500 RID: 1280
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRhythmGame.KuroRhythmGameJudgement")]
	[UnrealStructLayout(496, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 496)]
	public class UKuroRhythmGameJudgement : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060077E7 RID: 30695 RVA: 0x000AF0D1 File Offset: 0x000AD2D1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRhythmGameJudgement._ClassPtr;
		}

		// Token: 0x060077E8 RID: 30696 RVA: 0x000AF0E0 File Offset: 0x000AD2E0
		public UKuroRhythmGameJudgement() : this(BuiltinUtils.AllocNativeUObject(UKuroRhythmGameJudgement.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060077E9 RID: 30697 RVA: 0x000AF108 File Offset: 0x000AD308
		public UKuroRhythmGameJudgement(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRhythmGameJudgement.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001732 RID: 5938
		// (get) Token: 0x060077EA RID: 30698 RVA: 0x000AF13C File Offset: 0x000AD33C
		// (set) Token: 0x060077EB RID: 30699 RVA: 0x000AF175 File Offset: 0x000AD375
		public FOnTunnelFlickSwitch OnTunnelFlickSwitch
		{
			get
			{
				base.FastCheckIsValid();
				FOnTunnelFlickSwitch result;
				if ((result = this._OnTunnelFlickSwitch) == null)
				{
					result = (this._OnTunnelFlickSwitch = new FOnTunnelFlickSwitch(base.NativePtr + (IntPtr)UKuroRhythmGameJudgement.__PropertyOffset_OnTunnelFlickSwitch, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroRhythmGameJudgement.__PropertyOffset_OnTunnelFlickSwitch, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001733 RID: 5939
		// (get) Token: 0x060077EC RID: 30700 RVA: 0x000AF198 File Offset: 0x000AD398
		// (set) Token: 0x060077ED RID: 30701 RVA: 0x000AF1D1 File Offset: 0x000AD3D1
		public FOnLineHitTrigger OnLineHitTrigger
		{
			get
			{
				base.FastCheckIsValid();
				FOnLineHitTrigger result;
				if ((result = this._OnLineHitTrigger) == null)
				{
					result = (this._OnLineHitTrigger = new FOnLineHitTrigger(base.NativePtr + (IntPtr)UKuroRhythmGameJudgement.__PropertyOffset_OnLineHitTrigger, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroRhythmGameJudgement.__PropertyOffset_OnLineHitTrigger, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001734 RID: 5940
		// (get) Token: 0x060077EE RID: 30702 RVA: 0x000AF1F4 File Offset: 0x000AD3F4
		// (set) Token: 0x060077EF RID: 30703 RVA: 0x000AF22D File Offset: 0x000AD42D
		public FOnHoldScoreUpdate OnHoldScoreUpdate
		{
			get
			{
				base.FastCheckIsValid();
				FOnHoldScoreUpdate result;
				if ((result = this._OnHoldScoreUpdate) == null)
				{
					result = (this._OnHoldScoreUpdate = new FOnHoldScoreUpdate(base.NativePtr + (IntPtr)UKuroRhythmGameJudgement.__PropertyOffset_OnHoldScoreUpdate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroRhythmGameJudgement.__PropertyOffset_OnHoldScoreUpdate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001735 RID: 5941
		// (get) Token: 0x060077F0 RID: 30704 RVA: 0x000AF250 File Offset: 0x000AD450
		// (set) Token: 0x060077F1 RID: 30705 RVA: 0x000AF289 File Offset: 0x000AD489
		public FOnAutoJudgeCountChange OnAutoJudgeCountChange
		{
			get
			{
				base.FastCheckIsValid();
				FOnAutoJudgeCountChange result;
				if ((result = this._OnAutoJudgeCountChange) == null)
				{
					result = (this._OnAutoJudgeCountChange = new FOnAutoJudgeCountChange(base.NativePtr + (IntPtr)UKuroRhythmGameJudgement.__PropertyOffset_OnAutoJudgeCountChange, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroRhythmGameJudgement.__PropertyOffset_OnAutoJudgeCountChange, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001736 RID: 5942
		// (get) Token: 0x060077F2 RID: 30706 RVA: 0x000AF2AC File Offset: 0x000AD4AC
		// (set) Token: 0x060077F3 RID: 30707 RVA: 0x000AF2E5 File Offset: 0x000AD4E5
		public FOnHoldNoteTimeout OnHoldNoteTimeout
		{
			get
			{
				base.FastCheckIsValid();
				FOnHoldNoteTimeout result;
				if ((result = this._OnHoldNoteTimeout) == null)
				{
					result = (this._OnHoldNoteTimeout = new FOnHoldNoteTimeout(base.NativePtr + (IntPtr)UKuroRhythmGameJudgement.__PropertyOffset_OnHoldNoteTimeout, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroRhythmGameJudgement.__PropertyOffset_OnHoldNoteTimeout, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001737 RID: 5943
		// (get) Token: 0x060077F4 RID: 30708 RVA: 0x000AF308 File Offset: 0x000AD508
		// (set) Token: 0x060077F5 RID: 30709 RVA: 0x000AF341 File Offset: 0x000AD541
		public FOnHoldNoteInputReleased OnHoldNoteInputReleased
		{
			get
			{
				base.FastCheckIsValid();
				FOnHoldNoteInputReleased result;
				if ((result = this._OnHoldNoteInputReleased) == null)
				{
					result = (this._OnHoldNoteInputReleased = new FOnHoldNoteInputReleased(base.NativePtr + (IntPtr)UKuroRhythmGameJudgement.__PropertyOffset_OnHoldNoteInputReleased, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroRhythmGameJudgement.__PropertyOffset_OnHoldNoteInputReleased, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x060077F6 RID: 30710 RVA: 0x000AF364 File Offset: 0x000AD564
		[SkipLocalsInit]
		public unsafe bool IsDisableRecordUpLoad()
		{
			UKuroRhythmGameJudgement.__IsDisableRecordUpLoad_FunctionParams* ptr = stackalloc UKuroRhythmGameJudgement.__IsDisableRecordUpLoad_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroRhythmGameJudgement.__IsDisableRecordUpLoad_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameJudgement.__IsDisableRecordUpLoad_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameJudgement.__IsDisableRecordUpLoad_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060077F7 RID: 30711 RVA: 0x000AF3AC File Offset: 0x000AD5AC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Initialize(in FKuroRhythmGameConfig InGameConfig)
		{
			UKuroRhythmGameJudgement.__Initialize_FunctionParams* ptr = stackalloc UKuroRhythmGameJudgement.__Initialize_FunctionParams[(UIntPtr)287] + 15L / (long)sizeof(UKuroRhythmGameJudgement.__Initialize_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameJudgement.__Initialize_NativeFunctionPtr, (void*)ptr, 1);
			if (InGameConfig != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroRhythmGameConfig.StaticStruct(), &ptr->InGameConfig, InGameConfig.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameJudgement.__Initialize_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060077F8 RID: 30712 RVA: 0x000AF414 File Offset: 0x000AD614
		[SkipLocalsInit]
		public unsafe int GetScorePerfect()
		{
			UKuroRhythmGameJudgement.__GetScorePerfect_FunctionParams* ptr = stackalloc UKuroRhythmGameJudgement.__GetScorePerfect_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroRhythmGameJudgement.__GetScorePerfect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameJudgement.__GetScorePerfect_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameJudgement.__GetScorePerfect_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060077F9 RID: 30713 RVA: 0x000AF45C File Offset: 0x000AD65C
		[SkipLocalsInit]
		public unsafe int GetScoreMiss()
		{
			UKuroRhythmGameJudgement.__GetScoreMiss_FunctionParams* ptr = stackalloc UKuroRhythmGameJudgement.__GetScoreMiss_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroRhythmGameJudgement.__GetScoreMiss_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameJudgement.__GetScoreMiss_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameJudgement.__GetScoreMiss_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060077FA RID: 30714 RVA: 0x000AF4A4 File Offset: 0x000AD6A4
		[SkipLocalsInit]
		public unsafe int GetScoreGreat()
		{
			UKuroRhythmGameJudgement.__GetScoreGreat_FunctionParams* ptr = stackalloc UKuroRhythmGameJudgement.__GetScoreGreat_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroRhythmGameJudgement.__GetScoreGreat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameJudgement.__GetScoreGreat_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameJudgement.__GetScoreGreat_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060077FB RID: 30715 RVA: 0x000AF4EC File Offset: 0x000AD6EC
		[SkipLocalsInit]
		public unsafe int GetScoreGood()
		{
			UKuroRhythmGameJudgement.__GetScoreGood_FunctionParams* ptr = stackalloc UKuroRhythmGameJudgement.__GetScoreGood_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroRhythmGameJudgement.__GetScoreGood_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameJudgement.__GetScoreGood_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameJudgement.__GetScoreGood_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060077FC RID: 30716 RVA: 0x000AF534 File Offset: 0x000AD734
		[SkipLocalsInit]
		public unsafe int GetScoreBad()
		{
			UKuroRhythmGameJudgement.__GetScoreBad_FunctionParams* ptr = stackalloc UKuroRhythmGameJudgement.__GetScoreBad_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroRhythmGameJudgement.__GetScoreBad_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameJudgement.__GetScoreBad_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameJudgement.__GetScoreBad_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060077FD RID: 30717 RVA: 0x000AF57C File Offset: 0x000AD77C
		[SkipLocalsInit]
		public unsafe int GetRemainUpgradeRatingCount()
		{
			UKuroRhythmGameJudgement.__GetRemainUpgradeRatingCount_FunctionParams* ptr = stackalloc UKuroRhythmGameJudgement.__GetRemainUpgradeRatingCount_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroRhythmGameJudgement.__GetRemainUpgradeRatingCount_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameJudgement.__GetRemainUpgradeRatingCount_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameJudgement.__GetRemainUpgradeRatingCount_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060077FE RID: 30718 RVA: 0x000AF5C4 File Offset: 0x000AD7C4
		[SkipLocalsInit]
		public unsafe int GetHoldingNoteIndex()
		{
			UKuroRhythmGameJudgement.__GetHoldingNoteIndex_FunctionParams* ptr = stackalloc UKuroRhythmGameJudgement.__GetHoldingNoteIndex_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroRhythmGameJudgement.__GetHoldingNoteIndex_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameJudgement.__GetHoldingNoteIndex_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameJudgement.__GetHoldingNoteIndex_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060077FF RID: 30719 RVA: 0x000AF609 File Offset: 0x000AD809
		static UKuroRhythmGameJudgement()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRhythmGame.KuroRhythmGameJudgement");
		}

		// Token: 0x06007800 RID: 30720 RVA: 0x000AF617 File Offset: 0x000AD817
		protected UKuroRhythmGameJudgement(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040032BF RID: 12991
		public new const string __ObjectPath = "/Script/KuroRhythmGame.KuroRhythmGameJudgement";

		// Token: 0x040032C0 RID: 12992
		private static IntPtr _ClassPtr;

		// Token: 0x040032C1 RID: 12993
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040032C2 RID: 12994
		internal static int __PropertyOffset_OnTunnelFlickSwitch;

		// Token: 0x040032C3 RID: 12995
		[Nullable(2)]
		private FOnTunnelFlickSwitch _OnTunnelFlickSwitch;

		// Token: 0x040032C4 RID: 12996
		internal static int __PropertyOffset_OnLineHitTrigger;

		// Token: 0x040032C5 RID: 12997
		[Nullable(2)]
		private FOnLineHitTrigger _OnLineHitTrigger;

		// Token: 0x040032C6 RID: 12998
		internal static int __PropertyOffset_OnHoldScoreUpdate;

		// Token: 0x040032C7 RID: 12999
		[Nullable(2)]
		private FOnHoldScoreUpdate _OnHoldScoreUpdate;

		// Token: 0x040032C8 RID: 13000
		internal static int __PropertyOffset_OnAutoJudgeCountChange;

		// Token: 0x040032C9 RID: 13001
		[Nullable(2)]
		private FOnAutoJudgeCountChange _OnAutoJudgeCountChange;

		// Token: 0x040032CA RID: 13002
		internal static int __PropertyOffset_OnHoldNoteTimeout;

		// Token: 0x040032CB RID: 13003
		[Nullable(2)]
		private FOnHoldNoteTimeout _OnHoldNoteTimeout;

		// Token: 0x040032CC RID: 13004
		internal static int __PropertyOffset_OnHoldNoteInputReleased;

		// Token: 0x040032CD RID: 13005
		[Nullable(2)]
		private FOnHoldNoteInputReleased _OnHoldNoteInputReleased;

		// Token: 0x040032CE RID: 13006
		private static IntPtr __IsDisableRecordUpLoad_NativeFunctionPtr;

		// Token: 0x040032CF RID: 13007
		private static IntPtr __Initialize_NativeFunctionPtr;

		// Token: 0x040032D0 RID: 13008
		private static IntPtr __GetScorePerfect_NativeFunctionPtr;

		// Token: 0x040032D1 RID: 13009
		private static IntPtr __GetScoreMiss_NativeFunctionPtr;

		// Token: 0x040032D2 RID: 13010
		private static IntPtr __GetScoreGreat_NativeFunctionPtr;

		// Token: 0x040032D3 RID: 13011
		private static IntPtr __GetScoreGood_NativeFunctionPtr;

		// Token: 0x040032D4 RID: 13012
		private static IntPtr __GetScoreBad_NativeFunctionPtr;

		// Token: 0x040032D5 RID: 13013
		private static IntPtr __GetRemainUpgradeRatingCount_NativeFunctionPtr;

		// Token: 0x040032D6 RID: 13014
		private static IntPtr __GetHoldingNoteIndex_NativeFunctionPtr;

		// Token: 0x02000C37 RID: 3127
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsDisableRecordUpLoad_FunctionParams
		{
			// Token: 0x04005E84 RID: 24196
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000C38 RID: 3128
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 272)]
		protected ref struct __Initialize_FunctionParams
		{
			// Token: 0x04005E85 RID: 24197
			[FieldOffset(0)]
			public byte InGameConfig;
		}

		// Token: 0x02000C39 RID: 3129
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetScorePerfect_FunctionParams
		{
			// Token: 0x04005E86 RID: 24198
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02000C3A RID: 3130
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetScoreMiss_FunctionParams
		{
			// Token: 0x04005E87 RID: 24199
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02000C3B RID: 3131
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetScoreGreat_FunctionParams
		{
			// Token: 0x04005E88 RID: 24200
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02000C3C RID: 3132
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetScoreGood_FunctionParams
		{
			// Token: 0x04005E89 RID: 24201
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02000C3D RID: 3133
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetScoreBad_FunctionParams
		{
			// Token: 0x04005E8A RID: 24202
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02000C3E RID: 3134
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetRemainUpgradeRatingCount_FunctionParams
		{
			// Token: 0x04005E8B RID: 24203
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02000C3F RID: 3135
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetHoldingNoteIndex_FunctionParams
		{
			// Token: 0x04005E8C RID: 24204
			[FieldOffset(0)]
			public int __Result;
		}
	}
}
