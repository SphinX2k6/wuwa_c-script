using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025FF RID: 9727
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/Niagara.NiagaraVariable")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FNiagaraVariable : FNiagaraVariableBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060242D2 RID: 148178 RVA: 0x00358C5B File Offset: 0x00356E5B
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraVariable._ScriptStructPtr != 0) ? FNiagaraVariable._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraVariable", ref FNiagaraVariable._ScriptStructPtr);
		}

		// Token: 0x17008B50 RID: 35664
		// (get) Token: 0x060242D3 RID: 148179 RVA: 0x00358C80 File Offset: 0x00356E80
		// (set) Token: 0x060242D4 RID: 148180 RVA: 0x00358CC3 File Offset: 0x00356EC3
		public TArray<byte> VarData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._VarData) == null)
				{
					result = (this._VarData = new TArray<byte>(base.NativePtr + (IntPtr)FNiagaraVariable.__PropertyOffset_VarData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.VarData.CopyAssign(value);
			}
		}

		// Token: 0x060242D5 RID: 148181 RVA: 0x00358CD1 File Offset: 0x00356ED1
		public FNiagaraVariable()
		{
		}

		// Token: 0x060242D6 RID: 148182 RVA: 0x00358CD9 File Offset: 0x00356ED9
		public FNiagaraVariable(TArray<byte> VarData, FName Name, FNiagaraTypeDefinitionHandle TypeDefHandle, FNiagaraTypeDefinition TypeDef_DEPRECATED)
		{
			this.VarData = VarData;
			base.Name = Name;
			base.TypeDefHandle = TypeDefHandle;
		}

		// Token: 0x060242D7 RID: 148183 RVA: 0x00358CF6 File Offset: 0x00356EF6
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraVariable.StaticStruct();
		}

		// Token: 0x060242D8 RID: 148184 RVA: 0x00358D02 File Offset: 0x00356F02
		[NullableContext(2)]
		public FNiagaraVariable(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060242D9 RID: 148185 RVA: 0x00358D0C File Offset: 0x00356F0C
		public FNiagaraVariable(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060242DA RID: 148186 RVA: 0x00358D17 File Offset: 0x00356F17
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraVariable(Pointer, false, true);
		}

		// Token: 0x060242DB RID: 148187 RVA: 0x00358D21 File Offset: 0x00356F21
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraVariable(Pointer, MemoryOwner);
		}

		// Token: 0x04013691 RID: 79505
		public new const string __ObjectPath = "/Script/Niagara.NiagaraVariable";

		// Token: 0x04013692 RID: 79506
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013693 RID: 79507
		internal static int __PropertyOffset_VarData;

		// Token: 0x04013694 RID: 79508
		[Nullable(2)]
		private TArray<byte> _VarData;
	}
}
