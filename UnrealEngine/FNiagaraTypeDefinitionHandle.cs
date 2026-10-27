using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025FB RID: 9723
	[UnrealObjectPath("/Script/Niagara.NiagaraTypeDefinitionHandle")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FNiagaraTypeDefinitionHandle : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060242A0 RID: 148128 RVA: 0x00358782 File Offset: 0x00356982
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraTypeDefinitionHandle._ScriptStructPtr != 0) ? FNiagaraTypeDefinitionHandle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraTypeDefinitionHandle", ref FNiagaraTypeDefinitionHandle._ScriptStructPtr);
		}

		// Token: 0x17008B47 RID: 35655
		// (get) Token: 0x060242A1 RID: 148129 RVA: 0x003587A6 File Offset: 0x003569A6
		// (set) Token: 0x060242A2 RID: 148130 RVA: 0x003587B6 File Offset: 0x003569B6
		public unsafe int RegisteredTypeIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraTypeDefinitionHandle.__PropertyOffset_RegisteredTypeIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraTypeDefinitionHandle.__PropertyOffset_RegisteredTypeIndex) = value;
			}
		}

		// Token: 0x060242A3 RID: 148131 RVA: 0x003587C7 File Offset: 0x003569C7
		public FNiagaraTypeDefinitionHandle()
		{
		}

		// Token: 0x060242A4 RID: 148132 RVA: 0x003587CF File Offset: 0x003569CF
		public FNiagaraTypeDefinitionHandle(int RegisteredTypeIndex)
		{
			this.RegisteredTypeIndex = RegisteredTypeIndex;
		}

		// Token: 0x060242A5 RID: 148133 RVA: 0x003587DE File Offset: 0x003569DE
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraTypeDefinitionHandle.StaticStruct();
		}

		// Token: 0x060242A6 RID: 148134 RVA: 0x003587EA File Offset: 0x003569EA
		[NullableContext(2)]
		public FNiagaraTypeDefinitionHandle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060242A7 RID: 148135 RVA: 0x003587F4 File Offset: 0x003569F4
		public FNiagaraTypeDefinitionHandle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060242A8 RID: 148136 RVA: 0x003587FF File Offset: 0x003569FF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraTypeDefinitionHandle(Pointer, false, true);
		}

		// Token: 0x060242A9 RID: 148137 RVA: 0x00358809 File Offset: 0x00356A09
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraTypeDefinitionHandle(Pointer, MemoryOwner);
		}

		// Token: 0x04013678 RID: 79480
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.NiagaraTypeDefinitionHandle";

		// Token: 0x04013679 RID: 79481
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401367A RID: 79482
		internal static int __PropertyOffset_RegisteredTypeIndex;
	}
}
