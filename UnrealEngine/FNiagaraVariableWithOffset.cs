using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002606 RID: 9734
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/Niagara.NiagaraVariableWithOffset")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FNiagaraVariableWithOffset : FNiagaraVariableBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024350 RID: 148304 RVA: 0x003598DC File Offset: 0x00357ADC
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraVariableWithOffset._ScriptStructPtr != 0) ? FNiagaraVariableWithOffset._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraVariableWithOffset", ref FNiagaraVariableWithOffset._ScriptStructPtr);
		}

		// Token: 0x17008B73 RID: 35699
		// (get) Token: 0x06024351 RID: 148305 RVA: 0x00359900 File Offset: 0x00357B00
		// (set) Token: 0x06024352 RID: 148306 RVA: 0x00359910 File Offset: 0x00357B10
		public unsafe int Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraVariableWithOffset.__PropertyOffset_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraVariableWithOffset.__PropertyOffset_Offset) = value;
			}
		}

		// Token: 0x06024353 RID: 148307 RVA: 0x00359921 File Offset: 0x00357B21
		public FNiagaraVariableWithOffset()
		{
		}

		// Token: 0x06024354 RID: 148308 RVA: 0x00359929 File Offset: 0x00357B29
		[NullableContext(1)]
		public FNiagaraVariableWithOffset(int Offset, FName Name, FNiagaraTypeDefinitionHandle TypeDefHandle, FNiagaraTypeDefinition TypeDef_DEPRECATED)
		{
			this.Offset = Offset;
			base.Name = Name;
			base.TypeDefHandle = TypeDefHandle;
		}

		// Token: 0x06024355 RID: 148309 RVA: 0x00359946 File Offset: 0x00357B46
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraVariableWithOffset.StaticStruct();
		}

		// Token: 0x06024356 RID: 148310 RVA: 0x00359952 File Offset: 0x00357B52
		[NullableContext(2)]
		public FNiagaraVariableWithOffset(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024357 RID: 148311 RVA: 0x0035995C File Offset: 0x00357B5C
		public FNiagaraVariableWithOffset(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024358 RID: 148312 RVA: 0x00359967 File Offset: 0x00357B67
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraVariableWithOffset(Pointer, false, true);
		}

		// Token: 0x06024359 RID: 148313 RVA: 0x00359971 File Offset: 0x00357B71
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraVariableWithOffset(Pointer, MemoryOwner);
		}

		// Token: 0x040136D2 RID: 79570
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraVariableWithOffset";

		// Token: 0x040136D3 RID: 79571
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040136D4 RID: 79572
		internal static int __PropertyOffset_Offset;
	}
}
