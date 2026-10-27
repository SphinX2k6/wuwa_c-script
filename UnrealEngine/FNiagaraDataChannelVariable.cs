using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002555 RID: 9557
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataChannelVariable")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FNiagaraDataChannelVariable : FNiagaraVariableBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602381C RID: 145436 RVA: 0x00347D05 File Offset: 0x00345F05
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraDataChannelVariable._ScriptStructPtr != 0) ? FNiagaraDataChannelVariable._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraDataChannelVariable", ref FNiagaraDataChannelVariable._ScriptStructPtr);
		}

		// Token: 0x0602381D RID: 145437 RVA: 0x00347D29 File Offset: 0x00345F29
		public FNiagaraDataChannelVariable()
		{
		}

		// Token: 0x0602381E RID: 145438 RVA: 0x00347D31 File Offset: 0x00345F31
		[NullableContext(1)]
		public FNiagaraDataChannelVariable(FGuid Version, FName Name, FNiagaraTypeDefinitionHandle TypeDefHandle, FNiagaraTypeDefinition TypeDef_DEPRECATED)
		{
			base.Name = Name;
			base.TypeDefHandle = TypeDefHandle;
		}

		// Token: 0x0602381F RID: 145439 RVA: 0x00347D47 File Offset: 0x00345F47
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraDataChannelVariable.StaticStruct();
		}

		// Token: 0x06023820 RID: 145440 RVA: 0x00347D53 File Offset: 0x00345F53
		[NullableContext(2)]
		public FNiagaraDataChannelVariable(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023821 RID: 145441 RVA: 0x00347D5D File Offset: 0x00345F5D
		public FNiagaraDataChannelVariable(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023822 RID: 145442 RVA: 0x00347D68 File Offset: 0x00345F68
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraDataChannelVariable(Pointer, false, true);
		}

		// Token: 0x06023823 RID: 145443 RVA: 0x00347D72 File Offset: 0x00345F72
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraDataChannelVariable(Pointer, MemoryOwner);
		}

		// Token: 0x04013090 RID: 77968
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataChannelVariable";

		// Token: 0x04013091 RID: 77969
		private static IntPtr _ScriptStructPtr;
	}
}
