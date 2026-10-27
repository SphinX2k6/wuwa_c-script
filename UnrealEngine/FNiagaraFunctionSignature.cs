using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025AB RID: 9643
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraFunctionSignature")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 216)]
	public class FNiagaraFunctionSignature : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023D11 RID: 146705 RVA: 0x0034F7C3 File Offset: 0x0034D9C3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraFunctionSignature._ScriptStructPtr != 0) ? FNiagaraFunctionSignature._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraFunctionSignature", ref FNiagaraFunctionSignature._ScriptStructPtr);
		}

		// Token: 0x170089A0 RID: 35232
		// (get) Token: 0x06023D12 RID: 146706 RVA: 0x0034F7E7 File Offset: 0x0034D9E7
		// (set) Token: 0x06023D13 RID: 146707 RVA: 0x0034F7FB File Offset: 0x0034D9FB
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraFunctionSignature.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraFunctionSignature.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x170089A1 RID: 35233
		// (get) Token: 0x06023D14 RID: 146708 RVA: 0x0034F810 File Offset: 0x0034DA10
		// (set) Token: 0x06023D15 RID: 146709 RVA: 0x0034F853 File Offset: 0x0034DA53
		public TArray<FNiagaraVariable> Inputs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraVariable> result;
				if ((result = this._Inputs) == null)
				{
					result = (this._Inputs = new TArray<FNiagaraVariable>(base.NativePtr + (IntPtr)FNiagaraFunctionSignature.__PropertyOffset_Inputs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Inputs.CopyAssign(value);
			}
		}

		// Token: 0x170089A2 RID: 35234
		// (get) Token: 0x06023D16 RID: 146710 RVA: 0x0034F864 File Offset: 0x0034DA64
		// (set) Token: 0x06023D17 RID: 146711 RVA: 0x0034F8A7 File Offset: 0x0034DAA7
		public TArray<FNiagaraVariable> Outputs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraVariable> result;
				if ((result = this._Outputs) == null)
				{
					result = (this._Outputs = new TArray<FNiagaraVariable>(base.NativePtr + (IntPtr)FNiagaraFunctionSignature.__PropertyOffset_Outputs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Outputs.CopyAssign(value);
			}
		}

		// Token: 0x170089A3 RID: 35235
		// (get) Token: 0x06023D18 RID: 146712 RVA: 0x0034F8B5 File Offset: 0x0034DAB5
		// (set) Token: 0x06023D19 RID: 146713 RVA: 0x0034F8C9 File Offset: 0x0034DAC9
		public unsafe FName OwnerName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraFunctionSignature.__PropertyOffset_OwnerName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraFunctionSignature.__PropertyOffset_OwnerName) = value;
			}
		}

		// Token: 0x170089A4 RID: 35236
		// (get) Token: 0x06023D1A RID: 146714 RVA: 0x0034F8DE File Offset: 0x0034DADE
		// (set) Token: 0x06023D1B RID: 146715 RVA: 0x0034F8F7 File Offset: 0x0034DAF7
		public unsafe bool bRequiresContext
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNiagaraFunctionSignature.__PropertyOffset_bRequiresContext) & FNiagaraFunctionSignature.__PropertyMask_bRequiresContext) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNiagaraFunctionSignature.__PropertyOffset_bRequiresContext) = ((*(base.NativePtr + (IntPtr)FNiagaraFunctionSignature.__PropertyOffset_bRequiresContext) & ~FNiagaraFunctionSignature.__PropertyMask_bRequiresContext) | (value ? FNiagaraFunctionSignature.__PropertyMask_bRequiresContext : 0));
			}
		}

		// Token: 0x170089A5 RID: 35237
		// (get) Token: 0x06023D1C RID: 146716 RVA: 0x0034F927 File Offset: 0x0034DB27
		// (set) Token: 0x06023D1D RID: 146717 RVA: 0x0034F940 File Offset: 0x0034DB40
		public unsafe bool bRequiresExecPin
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNiagaraFunctionSignature.__PropertyOffset_bRequiresExecPin) & FNiagaraFunctionSignature.__PropertyMask_bRequiresExecPin) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNiagaraFunctionSignature.__PropertyOffset_bRequiresExecPin) = ((*(base.NativePtr + (IntPtr)FNiagaraFunctionSignature.__PropertyOffset_bRequiresExecPin) & ~FNiagaraFunctionSignature.__PropertyMask_bRequiresExecPin) | (value ? FNiagaraFunctionSignature.__PropertyMask_bRequiresExecPin : 0));
			}
		}

		// Token: 0x170089A6 RID: 35238
		// (get) Token: 0x06023D1E RID: 146718 RVA: 0x0034F970 File Offset: 0x0034DB70
		// (set) Token: 0x06023D1F RID: 146719 RVA: 0x0034F989 File Offset: 0x0034DB89
		public unsafe bool bMemberFunction
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNiagaraFunctionSignature.__PropertyOffset_bMemberFunction) & FNiagaraFunctionSignature.__PropertyMask_bMemberFunction) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNiagaraFunctionSignature.__PropertyOffset_bMemberFunction) = ((*(base.NativePtr + (IntPtr)FNiagaraFunctionSignature.__PropertyOffset_bMemberFunction) & ~FNiagaraFunctionSignature.__PropertyMask_bMemberFunction) | (value ? FNiagaraFunctionSignature.__PropertyMask_bMemberFunction : 0));
			}
		}

		// Token: 0x170089A7 RID: 35239
		// (get) Token: 0x06023D20 RID: 146720 RVA: 0x0034F9B9 File Offset: 0x0034DBB9
		// (set) Token: 0x06023D21 RID: 146721 RVA: 0x0034F9D2 File Offset: 0x0034DBD2
		public unsafe bool bExperimental
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNiagaraFunctionSignature.__PropertyOffset_bExperimental) & FNiagaraFunctionSignature.__PropertyMask_bExperimental) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNiagaraFunctionSignature.__PropertyOffset_bExperimental) = ((*(base.NativePtr + (IntPtr)FNiagaraFunctionSignature.__PropertyOffset_bExperimental) & ~FNiagaraFunctionSignature.__PropertyMask_bExperimental) | (value ? FNiagaraFunctionSignature.__PropertyMask_bExperimental : 0));
			}
		}

		// Token: 0x170089A8 RID: 35240
		// (get) Token: 0x06023D22 RID: 146722 RVA: 0x0034FA02 File Offset: 0x0034DC02
		// (set) Token: 0x06023D23 RID: 146723 RVA: 0x0034FA1B File Offset: 0x0034DC1B
		public unsafe bool bSupportsCPU
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNiagaraFunctionSignature.__PropertyOffset_bSupportsCPU) & FNiagaraFunctionSignature.__PropertyMask_bSupportsCPU) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNiagaraFunctionSignature.__PropertyOffset_bSupportsCPU) = ((*(base.NativePtr + (IntPtr)FNiagaraFunctionSignature.__PropertyOffset_bSupportsCPU) & ~FNiagaraFunctionSignature.__PropertyMask_bSupportsCPU) | (value ? FNiagaraFunctionSignature.__PropertyMask_bSupportsCPU : 0));
			}
		}

		// Token: 0x170089A9 RID: 35241
		// (get) Token: 0x06023D24 RID: 146724 RVA: 0x0034FA4B File Offset: 0x0034DC4B
		// (set) Token: 0x06023D25 RID: 146725 RVA: 0x0034FA64 File Offset: 0x0034DC64
		public unsafe bool bSupportsGPU
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNiagaraFunctionSignature.__PropertyOffset_bSupportsGPU) & FNiagaraFunctionSignature.__PropertyMask_bSupportsGPU) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNiagaraFunctionSignature.__PropertyOffset_bSupportsGPU) = ((*(base.NativePtr + (IntPtr)FNiagaraFunctionSignature.__PropertyOffset_bSupportsGPU) & ~FNiagaraFunctionSignature.__PropertyMask_bSupportsGPU) | (value ? FNiagaraFunctionSignature.__PropertyMask_bSupportsGPU : 0));
			}
		}

		// Token: 0x170089AA RID: 35242
		// (get) Token: 0x06023D26 RID: 146726 RVA: 0x0034FA94 File Offset: 0x0034DC94
		// (set) Token: 0x06023D27 RID: 146727 RVA: 0x0034FAAD File Offset: 0x0034DCAD
		public unsafe bool bWriteFunction
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNiagaraFunctionSignature.__PropertyOffset_bWriteFunction) & FNiagaraFunctionSignature.__PropertyMask_bWriteFunction) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNiagaraFunctionSignature.__PropertyOffset_bWriteFunction) = ((*(base.NativePtr + (IntPtr)FNiagaraFunctionSignature.__PropertyOffset_bWriteFunction) & ~FNiagaraFunctionSignature.__PropertyMask_bWriteFunction) | (value ? FNiagaraFunctionSignature.__PropertyMask_bWriteFunction : 0));
			}
		}

		// Token: 0x170089AB RID: 35243
		// (get) Token: 0x06023D28 RID: 146728 RVA: 0x0034FADD File Offset: 0x0034DCDD
		// (set) Token: 0x06023D29 RID: 146729 RVA: 0x0034FAF6 File Offset: 0x0034DCF6
		public unsafe bool bSoftDeprecatedFunction
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNiagaraFunctionSignature.__PropertyOffset_bSoftDeprecatedFunction) & FNiagaraFunctionSignature.__PropertyMask_bSoftDeprecatedFunction) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNiagaraFunctionSignature.__PropertyOffset_bSoftDeprecatedFunction) = ((*(base.NativePtr + (IntPtr)FNiagaraFunctionSignature.__PropertyOffset_bSoftDeprecatedFunction) & ~FNiagaraFunctionSignature.__PropertyMask_bSoftDeprecatedFunction) | (value ? FNiagaraFunctionSignature.__PropertyMask_bSoftDeprecatedFunction : 0));
			}
		}

		// Token: 0x170089AC RID: 35244
		// (get) Token: 0x06023D2A RID: 146730 RVA: 0x0034FB26 File Offset: 0x0034DD26
		// (set) Token: 0x06023D2B RID: 146731 RVA: 0x0034FB36 File Offset: 0x0034DD36
		public unsafe int ModuleUsageBitmask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraFunctionSignature.__PropertyOffset_ModuleUsageBitmask);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraFunctionSignature.__PropertyOffset_ModuleUsageBitmask) = value;
			}
		}

		// Token: 0x170089AD RID: 35245
		// (get) Token: 0x06023D2C RID: 146732 RVA: 0x0034FB47 File Offset: 0x0034DD47
		// (set) Token: 0x06023D2D RID: 146733 RVA: 0x0034FB57 File Offset: 0x0034DD57
		public unsafe int ContextStageMinIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraFunctionSignature.__PropertyOffset_ContextStageMinIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraFunctionSignature.__PropertyOffset_ContextStageMinIndex) = value;
			}
		}

		// Token: 0x170089AE RID: 35246
		// (get) Token: 0x06023D2E RID: 146734 RVA: 0x0034FB68 File Offset: 0x0034DD68
		// (set) Token: 0x06023D2F RID: 146735 RVA: 0x0034FB78 File Offset: 0x0034DD78
		public unsafe int ContextStageMaxIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraFunctionSignature.__PropertyOffset_ContextStageMaxIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraFunctionSignature.__PropertyOffset_ContextStageMaxIndex) = value;
			}
		}

		// Token: 0x170089AF RID: 35247
		// (get) Token: 0x06023D30 RID: 146736 RVA: 0x0034FB8C File Offset: 0x0034DD8C
		// (set) Token: 0x06023D31 RID: 146737 RVA: 0x0034FBCF File Offset: 0x0034DDCF
		public TMap<FName, FName> FunctionSpecifiers
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FName> result;
				if ((result = this._FunctionSpecifiers) == null)
				{
					result = (this._FunctionSpecifiers = new TMap<FName, FName>(base.NativePtr + (IntPtr)FNiagaraFunctionSignature.__PropertyOffset_FunctionSpecifiers, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FunctionSpecifiers.CopyAssign(value);
			}
		}

		// Token: 0x06023D32 RID: 146738 RVA: 0x0034FBDD File Offset: 0x0034DDDD
		public FNiagaraFunctionSignature()
		{
		}

		// Token: 0x06023D33 RID: 146739 RVA: 0x0034FBE8 File Offset: 0x0034DDE8
		public FNiagaraFunctionSignature(FName Name, TArray<FNiagaraVariable> Inputs, TArray<FNiagaraVariable> Outputs, FName OwnerName, bool bRequiresContext, bool bRequiresExecPin, bool bMemberFunction, bool bExperimental, FText ExperimentalMessage, uint FunctionVersion, bool bSupportsCPU, bool bSupportsGPU, bool bWriteFunction, bool bSoftDeprecatedFunction, int ModuleUsageBitmask, int ContextStageMinIndex, int ContextStageMaxIndex, TMap<FName, FName> FunctionSpecifiers, FText Description)
		{
			this.Name = Name;
			this.Inputs = Inputs;
			this.Outputs = Outputs;
			this.OwnerName = OwnerName;
			this.bRequiresContext = bRequiresContext;
			this.bRequiresExecPin = bRequiresExecPin;
			this.bMemberFunction = bMemberFunction;
			this.bExperimental = bExperimental;
			this.bSupportsCPU = bSupportsCPU;
			this.bSupportsGPU = bSupportsGPU;
			this.bWriteFunction = bWriteFunction;
			this.bSoftDeprecatedFunction = bSoftDeprecatedFunction;
			this.ModuleUsageBitmask = ModuleUsageBitmask;
			this.ContextStageMinIndex = ContextStageMinIndex;
			this.ContextStageMaxIndex = ContextStageMaxIndex;
			this.FunctionSpecifiers = FunctionSpecifiers;
		}

		// Token: 0x06023D34 RID: 146740 RVA: 0x0034FC78 File Offset: 0x0034DE78
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraFunctionSignature.StaticStruct();
		}

		// Token: 0x06023D35 RID: 146741 RVA: 0x0034FC84 File Offset: 0x0034DE84
		[NullableContext(2)]
		public FNiagaraFunctionSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023D36 RID: 146742 RVA: 0x0034FC8E File Offset: 0x0034DE8E
		public FNiagaraFunctionSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023D37 RID: 146743 RVA: 0x0034FC99 File Offset: 0x0034DE99
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraFunctionSignature(Pointer, false, true);
		}

		// Token: 0x06023D38 RID: 146744 RVA: 0x0034FCA3 File Offset: 0x0034DEA3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraFunctionSignature(Pointer, MemoryOwner);
		}

		// Token: 0x04013346 RID: 78662
		public const string __ObjectPath = "/Script/Niagara.NiagaraFunctionSignature";

		// Token: 0x04013347 RID: 78663
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013348 RID: 78664
		internal static int __PropertyOffset_Name;

		// Token: 0x04013349 RID: 78665
		internal static int __PropertyOffset_Inputs;

		// Token: 0x0401334A RID: 78666
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraVariable> _Inputs;

		// Token: 0x0401334B RID: 78667
		internal static int __PropertyOffset_Outputs;

		// Token: 0x0401334C RID: 78668
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraVariable> _Outputs;

		// Token: 0x0401334D RID: 78669
		internal static int __PropertyOffset_OwnerName;

		// Token: 0x0401334E RID: 78670
		internal static int __PropertyOffset_bRequiresContext;

		// Token: 0x0401334F RID: 78671
		internal static byte __PropertyMask_bRequiresContext;

		// Token: 0x04013350 RID: 78672
		internal static int __PropertyOffset_bRequiresExecPin;

		// Token: 0x04013351 RID: 78673
		internal static byte __PropertyMask_bRequiresExecPin;

		// Token: 0x04013352 RID: 78674
		internal static int __PropertyOffset_bMemberFunction;

		// Token: 0x04013353 RID: 78675
		internal static byte __PropertyMask_bMemberFunction;

		// Token: 0x04013354 RID: 78676
		internal static int __PropertyOffset_bExperimental;

		// Token: 0x04013355 RID: 78677
		internal static byte __PropertyMask_bExperimental;

		// Token: 0x04013356 RID: 78678
		internal static int __PropertyOffset_bSupportsCPU;

		// Token: 0x04013357 RID: 78679
		internal static byte __PropertyMask_bSupportsCPU;

		// Token: 0x04013358 RID: 78680
		internal static int __PropertyOffset_bSupportsGPU;

		// Token: 0x04013359 RID: 78681
		internal static byte __PropertyMask_bSupportsGPU;

		// Token: 0x0401335A RID: 78682
		internal static int __PropertyOffset_bWriteFunction;

		// Token: 0x0401335B RID: 78683
		internal static byte __PropertyMask_bWriteFunction;

		// Token: 0x0401335C RID: 78684
		internal static int __PropertyOffset_bSoftDeprecatedFunction;

		// Token: 0x0401335D RID: 78685
		internal static byte __PropertyMask_bSoftDeprecatedFunction;

		// Token: 0x0401335E RID: 78686
		internal static int __PropertyOffset_ModuleUsageBitmask;

		// Token: 0x0401335F RID: 78687
		internal static int __PropertyOffset_ContextStageMinIndex;

		// Token: 0x04013360 RID: 78688
		internal static int __PropertyOffset_ContextStageMaxIndex;

		// Token: 0x04013361 RID: 78689
		internal static int __PropertyOffset_FunctionSpecifiers;

		// Token: 0x04013362 RID: 78690
		[Nullable(2)]
		private TMap<FName, FName> _FunctionSpecifiers;
	}
}
