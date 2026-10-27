using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002600 RID: 9728
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraVariableAttributeBinding")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 264)]
	public class FNiagaraVariableAttributeBinding : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060242DC RID: 148188 RVA: 0x00358D2A File Offset: 0x00356F2A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraVariableAttributeBinding._ScriptStructPtr != 0) ? FNiagaraVariableAttributeBinding._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraVariableAttributeBinding", ref FNiagaraVariableAttributeBinding._ScriptStructPtr);
		}

		// Token: 0x17008B51 RID: 35665
		// (get) Token: 0x060242DD RID: 148189 RVA: 0x00358D50 File Offset: 0x00356F50
		// (set) Token: 0x060242DE RID: 148190 RVA: 0x00358D93 File Offset: 0x00356F93
		public FNiagaraVariableBase ParamMapVariable
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableBase result;
				if ((result = this._ParamMapVariable) == null)
				{
					result = (this._ParamMapVariable = new FNiagaraVariableBase(base.NativePtr + (IntPtr)FNiagaraVariableAttributeBinding.__PropertyOffset_ParamMapVariable, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableBase.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraVariableAttributeBinding.__PropertyOffset_ParamMapVariable, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008B52 RID: 35666
		// (get) Token: 0x060242DF RID: 148191 RVA: 0x00358DB4 File Offset: 0x00356FB4
		// (set) Token: 0x060242E0 RID: 148192 RVA: 0x00358DF7 File Offset: 0x00356FF7
		public FNiagaraVariable DataSetVariable
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariable result;
				if ((result = this._DataSetVariable) == null)
				{
					result = (this._DataSetVariable = new FNiagaraVariable(base.NativePtr + (IntPtr)FNiagaraVariableAttributeBinding.__PropertyOffset_DataSetVariable, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariable.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraVariableAttributeBinding.__PropertyOffset_DataSetVariable, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008B53 RID: 35667
		// (get) Token: 0x060242E1 RID: 148193 RVA: 0x00358E18 File Offset: 0x00357018
		// (set) Token: 0x060242E2 RID: 148194 RVA: 0x00358E5B File Offset: 0x0035705B
		public FNiagaraVariable RootVariable
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariable result;
				if ((result = this._RootVariable) == null)
				{
					result = (this._RootVariable = new FNiagaraVariable(base.NativePtr + (IntPtr)FNiagaraVariableAttributeBinding.__PropertyOffset_RootVariable, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariable.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraVariableAttributeBinding.__PropertyOffset_RootVariable, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008B54 RID: 35668
		// (get) Token: 0x060242E3 RID: 148195 RVA: 0x00358E7C File Offset: 0x0035707C
		// (set) Token: 0x060242E4 RID: 148196 RVA: 0x00358E90 File Offset: 0x00357090
		[Nullable(0)]
		public unsafe TEnumAsByte<ENiagaraBindingSource> BindingSourceMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraVariableAttributeBinding.__PropertyOffset_BindingSourceMode);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraVariableAttributeBinding.__PropertyOffset_BindingSourceMode) = value;
			}
		}

		// Token: 0x17008B55 RID: 35669
		// (get) Token: 0x060242E5 RID: 148197 RVA: 0x00358EA5 File Offset: 0x003570A5
		// (set) Token: 0x060242E6 RID: 148198 RVA: 0x00358EBE File Offset: 0x003570BE
		public unsafe bool bBindingExistsOnSource
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNiagaraVariableAttributeBinding.__PropertyOffset_bBindingExistsOnSource) & FNiagaraVariableAttributeBinding.__PropertyMask_bBindingExistsOnSource) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNiagaraVariableAttributeBinding.__PropertyOffset_bBindingExistsOnSource) = ((*(base.NativePtr + (IntPtr)FNiagaraVariableAttributeBinding.__PropertyOffset_bBindingExistsOnSource) & ~FNiagaraVariableAttributeBinding.__PropertyMask_bBindingExistsOnSource) | (value ? FNiagaraVariableAttributeBinding.__PropertyMask_bBindingExistsOnSource : 0));
			}
		}

		// Token: 0x17008B56 RID: 35670
		// (get) Token: 0x060242E7 RID: 148199 RVA: 0x00358EEE File Offset: 0x003570EE
		// (set) Token: 0x060242E8 RID: 148200 RVA: 0x00358F07 File Offset: 0x00357107
		public unsafe bool bIsCachedParticleValue
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNiagaraVariableAttributeBinding.__PropertyOffset_bIsCachedParticleValue) & FNiagaraVariableAttributeBinding.__PropertyMask_bIsCachedParticleValue) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNiagaraVariableAttributeBinding.__PropertyOffset_bIsCachedParticleValue) = ((*(base.NativePtr + (IntPtr)FNiagaraVariableAttributeBinding.__PropertyOffset_bIsCachedParticleValue) & ~FNiagaraVariableAttributeBinding.__PropertyMask_bIsCachedParticleValue) | (value ? FNiagaraVariableAttributeBinding.__PropertyMask_bIsCachedParticleValue : 0));
			}
		}

		// Token: 0x060242E9 RID: 148201 RVA: 0x00358F37 File Offset: 0x00357137
		public FNiagaraVariableAttributeBinding()
		{
		}

		// Token: 0x060242EA RID: 148202 RVA: 0x00358F3F File Offset: 0x0035713F
		public FNiagaraVariableAttributeBinding(FNiagaraVariableBase ParamMapVariable, FNiagaraVariable DataSetVariable, FNiagaraVariable RootVariable, FNiagaraVariable BoundVariable, FName CachedDisplayName, [Nullable(0)] TEnumAsByte<ENiagaraBindingSource> BindingSourceMode, bool bBindingExistsOnSource, bool bIsCachedParticleValue)
		{
			this.ParamMapVariable = ParamMapVariable;
			this.DataSetVariable = DataSetVariable;
			this.RootVariable = RootVariable;
			this.BindingSourceMode = BindingSourceMode;
			this.bBindingExistsOnSource = bBindingExistsOnSource;
			this.bIsCachedParticleValue = bIsCachedParticleValue;
		}

		// Token: 0x060242EB RID: 148203 RVA: 0x00358F74 File Offset: 0x00357174
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraVariableAttributeBinding.StaticStruct();
		}

		// Token: 0x060242EC RID: 148204 RVA: 0x00358F80 File Offset: 0x00357180
		[NullableContext(2)]
		public FNiagaraVariableAttributeBinding(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060242ED RID: 148205 RVA: 0x00358F8A File Offset: 0x0035718A
		public FNiagaraVariableAttributeBinding(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060242EE RID: 148206 RVA: 0x00358F95 File Offset: 0x00357195
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraVariableAttributeBinding(Pointer, false, true);
		}

		// Token: 0x060242EF RID: 148207 RVA: 0x00358F9F File Offset: 0x0035719F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraVariableAttributeBinding(Pointer, MemoryOwner);
		}

		// Token: 0x04013695 RID: 79509
		public const string __ObjectPath = "/Script/Niagara.NiagaraVariableAttributeBinding";

		// Token: 0x04013696 RID: 79510
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013697 RID: 79511
		internal static int __PropertyOffset_ParamMapVariable;

		// Token: 0x04013698 RID: 79512
		[Nullable(2)]
		private FNiagaraVariableBase _ParamMapVariable;

		// Token: 0x04013699 RID: 79513
		internal static int __PropertyOffset_DataSetVariable;

		// Token: 0x0401369A RID: 79514
		[Nullable(2)]
		private FNiagaraVariable _DataSetVariable;

		// Token: 0x0401369B RID: 79515
		internal static int __PropertyOffset_RootVariable;

		// Token: 0x0401369C RID: 79516
		[Nullable(2)]
		private FNiagaraVariable _RootVariable;

		// Token: 0x0401369D RID: 79517
		internal static int __PropertyOffset_BindingSourceMode;

		// Token: 0x0401369E RID: 79518
		internal static int __PropertyOffset_bBindingExistsOnSource;

		// Token: 0x0401369F RID: 79519
		internal static byte __PropertyMask_bBindingExistsOnSource;

		// Token: 0x040136A0 RID: 79520
		internal static int __PropertyOffset_bIsCachedParticleValue;

		// Token: 0x040136A1 RID: 79521
		internal static byte __PropertyMask_bIsCachedParticleValue;
	}
}
