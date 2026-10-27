using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025E5 RID: 9701
	[UnrealObjectPath("/Script/Niagara.NiagaraScriptVariableBinding")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FNiagaraScriptVariableBinding : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060240EC RID: 147692 RVA: 0x00355906 File Offset: 0x00353B06
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraScriptVariableBinding._ScriptStructPtr != 0) ? FNiagaraScriptVariableBinding._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraScriptVariableBinding", ref FNiagaraScriptVariableBinding._ScriptStructPtr);
		}

		// Token: 0x17008AB8 RID: 35512
		// (get) Token: 0x060240ED RID: 147693 RVA: 0x0035592A File Offset: 0x00353B2A
		// (set) Token: 0x060240EE RID: 147694 RVA: 0x0035593E File Offset: 0x00353B3E
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraScriptVariableBinding.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraScriptVariableBinding.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x060240EF RID: 147695 RVA: 0x00355953 File Offset: 0x00353B53
		public FNiagaraScriptVariableBinding()
		{
		}

		// Token: 0x060240F0 RID: 147696 RVA: 0x0035595B File Offset: 0x00353B5B
		public FNiagaraScriptVariableBinding(FName Name)
		{
			this.Name = Name;
		}

		// Token: 0x060240F1 RID: 147697 RVA: 0x0035596A File Offset: 0x00353B6A
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraScriptVariableBinding.StaticStruct();
		}

		// Token: 0x060240F2 RID: 147698 RVA: 0x00355976 File Offset: 0x00353B76
		[NullableContext(2)]
		public FNiagaraScriptVariableBinding(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060240F3 RID: 147699 RVA: 0x00355980 File Offset: 0x00353B80
		public FNiagaraScriptVariableBinding(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060240F4 RID: 147700 RVA: 0x0035598B File Offset: 0x00353B8B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraScriptVariableBinding(Pointer, false, true);
		}

		// Token: 0x060240F5 RID: 147701 RVA: 0x00355995 File Offset: 0x00353B95
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraScriptVariableBinding(Pointer, MemoryOwner);
		}

		// Token: 0x04013562 RID: 79202
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.NiagaraScriptVariableBinding";

		// Token: 0x04013563 RID: 79203
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013564 RID: 79204
		internal static int __PropertyOffset_Name;
	}
}
