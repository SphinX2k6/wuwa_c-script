using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025B7 RID: 9655
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraMaterialAttributeBinding")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FNiagaraMaterialAttributeBinding : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023E15 RID: 146965 RVA: 0x00350E55 File Offset: 0x0034F055
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraMaterialAttributeBinding._ScriptStructPtr != 0) ? FNiagaraMaterialAttributeBinding._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraMaterialAttributeBinding", ref FNiagaraMaterialAttributeBinding._ScriptStructPtr);
		}

		// Token: 0x170089F5 RID: 35317
		// (get) Token: 0x06023E16 RID: 146966 RVA: 0x00350E79 File Offset: 0x0034F079
		// (set) Token: 0x06023E17 RID: 146967 RVA: 0x00350E8D File Offset: 0x0034F08D
		public unsafe FName MaterialParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraMaterialAttributeBinding.__PropertyOffset_MaterialParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraMaterialAttributeBinding.__PropertyOffset_MaterialParameterName) = value;
			}
		}

		// Token: 0x170089F6 RID: 35318
		// (get) Token: 0x06023E18 RID: 146968 RVA: 0x00350EA4 File Offset: 0x0034F0A4
		// (set) Token: 0x06023E19 RID: 146969 RVA: 0x00350EE7 File Offset: 0x0034F0E7
		public FNiagaraVariableBase NiagaraVariable
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableBase result;
				if ((result = this._NiagaraVariable) == null)
				{
					result = (this._NiagaraVariable = new FNiagaraVariableBase(base.NativePtr + (IntPtr)FNiagaraMaterialAttributeBinding.__PropertyOffset_NiagaraVariable, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableBase.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraMaterialAttributeBinding.__PropertyOffset_NiagaraVariable, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170089F7 RID: 35319
		// (get) Token: 0x06023E1A RID: 146970 RVA: 0x00350F08 File Offset: 0x0034F108
		// (set) Token: 0x06023E1B RID: 146971 RVA: 0x00350F4B File Offset: 0x0034F14B
		public FNiagaraVariableBase ResolvedNiagaraVariable
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableBase result;
				if ((result = this._ResolvedNiagaraVariable) == null)
				{
					result = (this._ResolvedNiagaraVariable = new FNiagaraVariableBase(base.NativePtr + (IntPtr)FNiagaraMaterialAttributeBinding.__PropertyOffset_ResolvedNiagaraVariable, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableBase.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraMaterialAttributeBinding.__PropertyOffset_ResolvedNiagaraVariable, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170089F8 RID: 35320
		// (get) Token: 0x06023E1C RID: 146972 RVA: 0x00350F6C File Offset: 0x0034F16C
		// (set) Token: 0x06023E1D RID: 146973 RVA: 0x00350FAF File Offset: 0x0034F1AF
		public FNiagaraVariableBase NiagaraChildVariable
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariableBase result;
				if ((result = this._NiagaraChildVariable) == null)
				{
					result = (this._NiagaraChildVariable = new FNiagaraVariableBase(base.NativePtr + (IntPtr)FNiagaraMaterialAttributeBinding.__PropertyOffset_NiagaraChildVariable, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariableBase.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraMaterialAttributeBinding.__PropertyOffset_NiagaraChildVariable, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06023E1E RID: 146974 RVA: 0x00350FD0 File Offset: 0x0034F1D0
		public FNiagaraMaterialAttributeBinding()
		{
		}

		// Token: 0x06023E1F RID: 146975 RVA: 0x00350FD8 File Offset: 0x0034F1D8
		public FNiagaraMaterialAttributeBinding(FName MaterialParameterName, FNiagaraVariableBase NiagaraVariable, FNiagaraVariableBase ResolvedNiagaraVariable, FNiagaraVariableBase NiagaraChildVariable)
		{
			this.MaterialParameterName = MaterialParameterName;
			this.NiagaraVariable = NiagaraVariable;
			this.ResolvedNiagaraVariable = ResolvedNiagaraVariable;
			this.NiagaraChildVariable = NiagaraChildVariable;
		}

		// Token: 0x06023E20 RID: 146976 RVA: 0x00350FFD File Offset: 0x0034F1FD
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraMaterialAttributeBinding.StaticStruct();
		}

		// Token: 0x06023E21 RID: 146977 RVA: 0x00351009 File Offset: 0x0034F209
		[NullableContext(2)]
		public FNiagaraMaterialAttributeBinding(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023E22 RID: 146978 RVA: 0x00351013 File Offset: 0x0034F213
		public FNiagaraMaterialAttributeBinding(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023E23 RID: 146979 RVA: 0x0035101E File Offset: 0x0034F21E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraMaterialAttributeBinding(Pointer, false, true);
		}

		// Token: 0x06023E24 RID: 146980 RVA: 0x00351028 File Offset: 0x0034F228
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraMaterialAttributeBinding(Pointer, MemoryOwner);
		}

		// Token: 0x040133D0 RID: 78800
		public const string __ObjectPath = "/Script/Niagara.NiagaraMaterialAttributeBinding";

		// Token: 0x040133D1 RID: 78801
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040133D2 RID: 78802
		internal static int __PropertyOffset_MaterialParameterName;

		// Token: 0x040133D3 RID: 78803
		internal static int __PropertyOffset_NiagaraVariable;

		// Token: 0x040133D4 RID: 78804
		[Nullable(2)]
		private FNiagaraVariableBase _NiagaraVariable;

		// Token: 0x040133D5 RID: 78805
		internal static int __PropertyOffset_ResolvedNiagaraVariable;

		// Token: 0x040133D6 RID: 78806
		[Nullable(2)]
		private FNiagaraVariableBase _ResolvedNiagaraVariable;

		// Token: 0x040133D7 RID: 78807
		internal static int __PropertyOffset_NiagaraChildVariable;

		// Token: 0x040133D8 RID: 78808
		[Nullable(2)]
		private FNiagaraVariableBase _NiagaraChildVariable;
	}
}
