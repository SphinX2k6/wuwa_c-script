using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200260D RID: 9741
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.VMExternalFunctionBindingInfo")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 176)]
	public class FVMExternalFunctionBindingInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060243C8 RID: 148424 RVA: 0x0035A6AF File Offset: 0x003588AF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVMExternalFunctionBindingInfo._ScriptStructPtr != 0) ? FVMExternalFunctionBindingInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.VMExternalFunctionBindingInfo", ref FVMExternalFunctionBindingInfo._ScriptStructPtr);
		}

		// Token: 0x17008B91 RID: 35729
		// (get) Token: 0x060243C9 RID: 148425 RVA: 0x0035A6D3 File Offset: 0x003588D3
		// (set) Token: 0x060243CA RID: 148426 RVA: 0x0035A6E7 File Offset: 0x003588E7
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVMExternalFunctionBindingInfo.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVMExternalFunctionBindingInfo.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17008B92 RID: 35730
		// (get) Token: 0x060243CB RID: 148427 RVA: 0x0035A6FC File Offset: 0x003588FC
		// (set) Token: 0x060243CC RID: 148428 RVA: 0x0035A710 File Offset: 0x00358910
		public unsafe FName OwnerName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVMExternalFunctionBindingInfo.__PropertyOffset_OwnerName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVMExternalFunctionBindingInfo.__PropertyOffset_OwnerName) = value;
			}
		}

		// Token: 0x17008B93 RID: 35731
		// (get) Token: 0x060243CD RID: 148429 RVA: 0x0035A728 File Offset: 0x00358928
		// (set) Token: 0x060243CE RID: 148430 RVA: 0x0035A76B File Offset: 0x0035896B
		public TArray<bool> InputParamLocations
		{
			get
			{
				base.FastCheckIsValid();
				TArray<bool> result;
				if ((result = this._InputParamLocations) == null)
				{
					result = (this._InputParamLocations = new TArray<bool>(base.NativePtr + (IntPtr)FVMExternalFunctionBindingInfo.__PropertyOffset_InputParamLocations, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.InputParamLocations.CopyAssign(value);
			}
		}

		// Token: 0x17008B94 RID: 35732
		// (get) Token: 0x060243CF RID: 148431 RVA: 0x0035A779 File Offset: 0x00358979
		// (set) Token: 0x060243D0 RID: 148432 RVA: 0x0035A789 File Offset: 0x00358989
		public unsafe int NumOutputs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVMExternalFunctionBindingInfo.__PropertyOffset_NumOutputs);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVMExternalFunctionBindingInfo.__PropertyOffset_NumOutputs) = value;
			}
		}

		// Token: 0x17008B95 RID: 35733
		// (get) Token: 0x060243D1 RID: 148433 RVA: 0x0035A79C File Offset: 0x0035899C
		// (set) Token: 0x060243D2 RID: 148434 RVA: 0x0035A7DF File Offset: 0x003589DF
		public TArray<FVMFunctionSpecifier> FunctionSpecifiers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVMFunctionSpecifier> result;
				if ((result = this._FunctionSpecifiers) == null)
				{
					result = (this._FunctionSpecifiers = new TArray<FVMFunctionSpecifier>(base.NativePtr + (IntPtr)FVMExternalFunctionBindingInfo.__PropertyOffset_FunctionSpecifiers, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FunctionSpecifiers.CopyAssign(value);
			}
		}

		// Token: 0x17008B96 RID: 35734
		// (get) Token: 0x060243D3 RID: 148435 RVA: 0x0035A7F0 File Offset: 0x003589F0
		// (set) Token: 0x060243D4 RID: 148436 RVA: 0x0035A833 File Offset: 0x00358A33
		public TArray<FNiagaraVariableBase> VariadicInputs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraVariableBase> result;
				if ((result = this._VariadicInputs) == null)
				{
					result = (this._VariadicInputs = new TArray<FNiagaraVariableBase>(base.NativePtr + (IntPtr)FVMExternalFunctionBindingInfo.__PropertyOffset_VariadicInputs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.VariadicInputs.CopyAssign(value);
			}
		}

		// Token: 0x17008B97 RID: 35735
		// (get) Token: 0x060243D5 RID: 148437 RVA: 0x0035A844 File Offset: 0x00358A44
		// (set) Token: 0x060243D6 RID: 148438 RVA: 0x0035A887 File Offset: 0x00358A87
		public TArray<FNiagaraVariableBase> VariadicOutputs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraVariableBase> result;
				if ((result = this._VariadicOutputs) == null)
				{
					result = (this._VariadicOutputs = new TArray<FNiagaraVariableBase>(base.NativePtr + (IntPtr)FVMExternalFunctionBindingInfo.__PropertyOffset_VariadicOutputs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.VariadicOutputs.CopyAssign(value);
			}
		}

		// Token: 0x060243D7 RID: 148439 RVA: 0x0035A895 File Offset: 0x00358A95
		public FVMExternalFunctionBindingInfo()
		{
		}

		// Token: 0x060243D8 RID: 148440 RVA: 0x0035A89D File Offset: 0x00358A9D
		public FVMExternalFunctionBindingInfo(FName Name, FName OwnerName, TArray<bool> InputParamLocations, int NumOutputs, TArray<FVMFunctionSpecifier> FunctionSpecifiers, TArray<FNiagaraVariableBase> VariadicInputs, TArray<FNiagaraVariableBase> VariadicOutputs, TMap<FName, FName> Specifiers_DEPRECATED)
		{
			this.Name = Name;
			this.OwnerName = OwnerName;
			this.InputParamLocations = InputParamLocations;
			this.NumOutputs = NumOutputs;
			this.FunctionSpecifiers = FunctionSpecifiers;
			this.VariadicInputs = VariadicInputs;
			this.VariadicOutputs = VariadicOutputs;
		}

		// Token: 0x060243D9 RID: 148441 RVA: 0x0035A8DA File Offset: 0x00358ADA
		protected override IntPtr GetUStructPtr()
		{
			return FVMExternalFunctionBindingInfo.StaticStruct();
		}

		// Token: 0x060243DA RID: 148442 RVA: 0x0035A8E6 File Offset: 0x00358AE6
		[NullableContext(2)]
		public FVMExternalFunctionBindingInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060243DB RID: 148443 RVA: 0x0035A8F0 File Offset: 0x00358AF0
		public FVMExternalFunctionBindingInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060243DC RID: 148444 RVA: 0x0035A8FB File Offset: 0x00358AFB
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FVMExternalFunctionBindingInfo(Pointer, false, true);
		}

		// Token: 0x060243DD RID: 148445 RVA: 0x0035A905 File Offset: 0x00358B05
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FVMExternalFunctionBindingInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04013713 RID: 79635
		public const string __ObjectPath = "/Script/Niagara.VMExternalFunctionBindingInfo";

		// Token: 0x04013714 RID: 79636
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013715 RID: 79637
		internal static int __PropertyOffset_Name;

		// Token: 0x04013716 RID: 79638
		internal static int __PropertyOffset_OwnerName;

		// Token: 0x04013717 RID: 79639
		internal static int __PropertyOffset_InputParamLocations;

		// Token: 0x04013718 RID: 79640
		[Nullable(2)]
		private TArray<bool> _InputParamLocations;

		// Token: 0x04013719 RID: 79641
		internal static int __PropertyOffset_NumOutputs;

		// Token: 0x0401371A RID: 79642
		internal static int __PropertyOffset_FunctionSpecifiers;

		// Token: 0x0401371B RID: 79643
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FVMFunctionSpecifier> _FunctionSpecifiers;

		// Token: 0x0401371C RID: 79644
		internal static int __PropertyOffset_VariadicInputs;

		// Token: 0x0401371D RID: 79645
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraVariableBase> _VariadicInputs;

		// Token: 0x0401371E RID: 79646
		internal static int __PropertyOffset_VariadicOutputs;

		// Token: 0x0401371F RID: 79647
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraVariableBase> _VariadicOutputs;
	}
}
