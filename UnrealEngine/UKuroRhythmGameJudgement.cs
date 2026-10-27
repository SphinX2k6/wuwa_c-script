using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C52 RID: 7250
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRhythmGame.KuroRhythmGameJudgement")]
	[UnrealStructLayout(496, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 496)]
	public class UKuroRhythmGameJudgement : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C18E RID: 115086 RVA: 0x00295B4A File Offset: 0x00293D4A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRhythmGameJudgement._ClassPtr;
		}

		// Token: 0x0601C18F RID: 115087 RVA: 0x00295B58 File Offset: 0x00293D58
		public UKuroRhythmGameJudgement() : this(BuiltinUtils.AllocNativeUObject(UKuroRhythmGameJudgement.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C190 RID: 115088 RVA: 0x00295B80 File Offset: 0x00293D80
		public UKuroRhythmGameJudgement(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRhythmGameJudgement.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170071A1 RID: 29089
		// (get) Token: 0x0601C191 RID: 115089 RVA: 0x00295BB4 File Offset: 0x00293DB4
		// (set) Token: 0x0601C192 RID: 115090 RVA: 0x00295BED File Offset: 0x00293DED
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

		// Token: 0x170071A2 RID: 29090
		// (get) Token: 0x0601C193 RID: 115091 RVA: 0x00295C10 File Offset: 0x00293E10
		// (set) Token: 0x0601C194 RID: 115092 RVA: 0x00295C49 File Offset: 0x00293E49
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

		// Token: 0x170071A3 RID: 29091
		// (get) Token: 0x0601C195 RID: 115093 RVA: 0x00295C6C File Offset: 0x00293E6C
		// (set) Token: 0x0601C196 RID: 115094 RVA: 0x00295CA5 File Offset: 0x00293EA5
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

		// Token: 0x170071A4 RID: 29092
		// (get) Token: 0x0601C197 RID: 115095 RVA: 0x00295CC8 File Offset: 0x00293EC8
		// (set) Token: 0x0601C198 RID: 115096 RVA: 0x00295D01 File Offset: 0x00293F01
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

		// Token: 0x170071A5 RID: 29093
		// (get) Token: 0x0601C199 RID: 115097 RVA: 0x00295D24 File Offset: 0x00293F24
		// (set) Token: 0x0601C19A RID: 115098 RVA: 0x00295D5D File Offset: 0x00293F5D
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

		// Token: 0x170071A6 RID: 29094
		// (get) Token: 0x0601C19B RID: 115099 RVA: 0x00295D80 File Offset: 0x00293F80
		// (set) Token: 0x0601C19C RID: 115100 RVA: 0x00295DB9 File Offset: 0x00293FB9
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

		// Token: 0x0601C19D RID: 115101 RVA: 0x00295DDC File Offset: 0x00293FDC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FKuroRhythmGameHitResult JudgeHit(float TimingError)
		{
			UKuroRhythmGameJudgement.__JudgeHit_FunctionParams* ptr = stackalloc UKuroRhythmGameJudgement.__JudgeHit_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroRhythmGameJudgement.__JudgeHit_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameJudgement.__JudgeHit_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TimingError = TimingError;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameJudgement.__JudgeHit_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C19E RID: 115102 RVA: 0x00295E2C File Offset: 0x0029402C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsDisableRecordUpLoad()
		{
			UKuroRhythmGameJudgement.__IsDisableRecordUpLoad_FunctionParams* ptr = stackalloc UKuroRhythmGameJudgement.__IsDisableRecordUpLoad_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroRhythmGameJudgement.__IsDisableRecordUpLoad_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameJudgement.__IsDisableRecordUpLoad_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameJudgement.__IsDisableRecordUpLoad_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C19F RID: 115103 RVA: 0x00295E74 File Offset: 0x00294074
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Initialize(in FKuroRhythmGameConfig InGameConfig)
		{
			UKuroRhythmGameJudgement.__Initialize_FunctionParams* ptr = stackalloc UKuroRhythmGameJudgement.__Initialize_FunctionParams[(UIntPtr)287] + 15L / (long)sizeof(UKuroRhythmGameJudgement.__Initialize_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameJudgement.__Initialize_NativeFunctionPtr, (void*)ptr, 1);
			if (InGameConfig != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroRhythmGameConfig.StaticStruct(), &ptr->InGameConfig, InGameConfig.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameJudgement.__Initialize_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601C1A0 RID: 115104 RVA: 0x00295EDC File Offset: 0x002940DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetScorePerfect()
		{
			UKuroRhythmGameJudgement.__GetScorePerfect_FunctionParams* ptr = stackalloc UKuroRhythmGameJudgement.__GetScorePerfect_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroRhythmGameJudgement.__GetScorePerfect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameJudgement.__GetScorePerfect_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameJudgement.__GetScorePerfect_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C1A1 RID: 115105 RVA: 0x00295F24 File Offset: 0x00294124
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetScoreMiss()
		{
			UKuroRhythmGameJudgement.__GetScoreMiss_FunctionParams* ptr = stackalloc UKuroRhythmGameJudgement.__GetScoreMiss_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroRhythmGameJudgement.__GetScoreMiss_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameJudgement.__GetScoreMiss_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameJudgement.__GetScoreMiss_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C1A2 RID: 115106 RVA: 0x00295F6C File Offset: 0x0029416C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetScoreGreat()
		{
			UKuroRhythmGameJudgement.__GetScoreGreat_FunctionParams* ptr = stackalloc UKuroRhythmGameJudgement.__GetScoreGreat_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroRhythmGameJudgement.__GetScoreGreat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameJudgement.__GetScoreGreat_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameJudgement.__GetScoreGreat_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C1A3 RID: 115107 RVA: 0x00295FB4 File Offset: 0x002941B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetScoreGood()
		{
			UKuroRhythmGameJudgement.__GetScoreGood_FunctionParams* ptr = stackalloc UKuroRhythmGameJudgement.__GetScoreGood_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroRhythmGameJudgement.__GetScoreGood_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameJudgement.__GetScoreGood_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameJudgement.__GetScoreGood_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C1A4 RID: 115108 RVA: 0x00295FFC File Offset: 0x002941FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetScoreBad()
		{
			UKuroRhythmGameJudgement.__GetScoreBad_FunctionParams* ptr = stackalloc UKuroRhythmGameJudgement.__GetScoreBad_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroRhythmGameJudgement.__GetScoreBad_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameJudgement.__GetScoreBad_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameJudgement.__GetScoreBad_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C1A5 RID: 115109 RVA: 0x00296044 File Offset: 0x00294244
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetRemainUpgradeRatingCount()
		{
			UKuroRhythmGameJudgement.__GetRemainUpgradeRatingCount_FunctionParams* ptr = stackalloc UKuroRhythmGameJudgement.__GetRemainUpgradeRatingCount_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroRhythmGameJudgement.__GetRemainUpgradeRatingCount_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameJudgement.__GetRemainUpgradeRatingCount_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameJudgement.__GetRemainUpgradeRatingCount_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C1A6 RID: 115110 RVA: 0x0029608C File Offset: 0x0029428C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetHoldingNoteIndex()
		{
			UKuroRhythmGameJudgement.__GetHoldingNoteIndex_FunctionParams* ptr = stackalloc UKuroRhythmGameJudgement.__GetHoldingNoteIndex_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroRhythmGameJudgement.__GetHoldingNoteIndex_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameJudgement.__GetHoldingNoteIndex_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameJudgement.__GetHoldingNoteIndex_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C1A7 RID: 115111 RVA: 0x002960D2 File Offset: 0x002942D2
		static UKuroRhythmGameJudgement()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRhythmGame.KuroRhythmGameJudgement");
		}

		// Token: 0x0601C1A8 RID: 115112 RVA: 0x002960E0 File Offset: 0x002942E0
		protected UKuroRhythmGameJudgement(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F1BD RID: 61885
		public new const string __ObjectPath = "/Script/KuroRhythmGame.KuroRhythmGameJudgement";

		// Token: 0x0400F1BE RID: 61886
		private static IntPtr _ClassPtr;

		// Token: 0x0400F1BF RID: 61887
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F1C0 RID: 61888
		internal static int __PropertyOffset_OnTunnelFlickSwitch;

		// Token: 0x0400F1C1 RID: 61889
		[Nullable(2)]
		private FOnTunnelFlickSwitch _OnTunnelFlickSwitch;

		// Token: 0x0400F1C2 RID: 61890
		internal static int __PropertyOffset_OnLineHitTrigger;

		// Token: 0x0400F1C3 RID: 61891
		[Nullable(2)]
		private FOnLineHitTrigger _OnLineHitTrigger;

		// Token: 0x0400F1C4 RID: 61892
		internal static int __PropertyOffset_OnHoldScoreUpdate;

		// Token: 0x0400F1C5 RID: 61893
		[Nullable(2)]
		private FOnHoldScoreUpdate _OnHoldScoreUpdate;

		// Token: 0x0400F1C6 RID: 61894
		internal static int __PropertyOffset_OnAutoJudgeCountChange;

		// Token: 0x0400F1C7 RID: 61895
		[Nullable(2)]
		private FOnAutoJudgeCountChange _OnAutoJudgeCountChange;

		// Token: 0x0400F1C8 RID: 61896
		internal static int __PropertyOffset_OnHoldNoteTimeout;

		// Token: 0x0400F1C9 RID: 61897
		[Nullable(2)]
		private FOnHoldNoteTimeout _OnHoldNoteTimeout;

		// Token: 0x0400F1CA RID: 61898
		internal static int __PropertyOffset_OnHoldNoteInputReleased;

		// Token: 0x0400F1CB RID: 61899
		[Nullable(2)]
		private FOnHoldNoteInputReleased _OnHoldNoteInputReleased;

		// Token: 0x0400F1CC RID: 61900
		private static IntPtr __JudgeHit_NativeFunctionPtr;

		// Token: 0x0400F1CD RID: 61901
		private static IntPtr __IsDisableRecordUpLoad_NativeFunctionPtr;

		// Token: 0x0400F1CE RID: 61902
		private static IntPtr __Initialize_NativeFunctionPtr;

		// Token: 0x0400F1CF RID: 61903
		private static IntPtr __GetScorePerfect_NativeFunctionPtr;

		// Token: 0x0400F1D0 RID: 61904
		private static IntPtr __GetScoreMiss_NativeFunctionPtr;

		// Token: 0x0400F1D1 RID: 61905
		private static IntPtr __GetScoreGreat_NativeFunctionPtr;

		// Token: 0x0400F1D2 RID: 61906
		private static IntPtr __GetScoreGood_NativeFunctionPtr;

		// Token: 0x0400F1D3 RID: 61907
		private static IntPtr __GetScoreBad_NativeFunctionPtr;

		// Token: 0x0400F1D4 RID: 61908
		private static IntPtr __GetRemainUpgradeRatingCount_NativeFunctionPtr;

		// Token: 0x0400F1D5 RID: 61909
		private static IntPtr __GetHoldingNoteIndex_NativeFunctionPtr;

		// Token: 0x020031B9 RID: 12729
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __JudgeHit_FunctionParams
		{
			// Token: 0x04017002 RID: 94210
			[FieldOffset(0)]
			public float TimingError;

			// Token: 0x04017003 RID: 94211
			[FieldOffset(4)]
			public FKuroRhythmGameHitResult __Result;
		}

		// Token: 0x020031BA RID: 12730
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsDisableRecordUpLoad_FunctionParams
		{
			// Token: 0x04017004 RID: 94212
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x020031BB RID: 12731
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 272)]
		protected ref struct __Initialize_FunctionParams
		{
			// Token: 0x04017005 RID: 94213
			[FieldOffset(0)]
			public byte InGameConfig;
		}

		// Token: 0x020031BC RID: 12732
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetScorePerfect_FunctionParams
		{
			// Token: 0x04017006 RID: 94214
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020031BD RID: 12733
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetScoreMiss_FunctionParams
		{
			// Token: 0x04017007 RID: 94215
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020031BE RID: 12734
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetScoreGreat_FunctionParams
		{
			// Token: 0x04017008 RID: 94216
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020031BF RID: 12735
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetScoreGood_FunctionParams
		{
			// Token: 0x04017009 RID: 94217
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020031C0 RID: 12736
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetScoreBad_FunctionParams
		{
			// Token: 0x0401700A RID: 94218
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020031C1 RID: 12737
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetRemainUpgradeRatingCount_FunctionParams
		{
			// Token: 0x0401700B RID: 94219
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020031C2 RID: 12738
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetHoldingNoteIndex_FunctionParams
		{
			// Token: 0x0401700C RID: 94220
			[FieldOffset(0)]
			public int __Result;
		}
	}
}
