using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002595 RID: 9621
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDebugHUDVariable")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FNiagaraDebugHUDVariable : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023B82 RID: 146306 RVA: 0x0034D0F1 File Offset: 0x0034B2F1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraDebugHUDVariable._ScriptStructPtr != 0) ? FNiagaraDebugHUDVariable._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraDebugHUDVariable", ref FNiagaraDebugHUDVariable._ScriptStructPtr);
		}

		// Token: 0x17008935 RID: 35125
		// (get) Token: 0x06023B83 RID: 146307 RVA: 0x0034D115 File Offset: 0x0034B315
		// (set) Token: 0x06023B84 RID: 146308 RVA: 0x0034D125 File Offset: 0x0034B325
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDebugHUDVariable.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDebugHUDVariable.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008936 RID: 35126
		// (get) Token: 0x06023B85 RID: 146309 RVA: 0x0034D136 File Offset: 0x0034B336
		// (set) Token: 0x06023B86 RID: 146310 RVA: 0x0034D14A File Offset: 0x0034B34A
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FNiagaraDebugHUDVariable.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FNiagaraDebugHUDVariable.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x06023B87 RID: 146311 RVA: 0x0034D15F File Offset: 0x0034B35F
		public FNiagaraDebugHUDVariable()
		{
		}

		// Token: 0x06023B88 RID: 146312 RVA: 0x0034D167 File Offset: 0x0034B367
		public FNiagaraDebugHUDVariable(bool bEnabled, string Name)
		{
			this.bEnabled = bEnabled;
			this.Name = Name;
		}

		// Token: 0x06023B89 RID: 146313 RVA: 0x0034D17D File Offset: 0x0034B37D
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraDebugHUDVariable.StaticStruct();
		}

		// Token: 0x06023B8A RID: 146314 RVA: 0x0034D189 File Offset: 0x0034B389
		[NullableContext(2)]
		public FNiagaraDebugHUDVariable(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023B8B RID: 146315 RVA: 0x0034D193 File Offset: 0x0034B393
		public FNiagaraDebugHUDVariable(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023B8C RID: 146316 RVA: 0x0034D19E File Offset: 0x0034B39E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraDebugHUDVariable(Pointer, false, true);
		}

		// Token: 0x06023B8D RID: 146317 RVA: 0x0034D1A8 File Offset: 0x0034B3A8
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraDebugHUDVariable(Pointer, MemoryOwner);
		}

		// Token: 0x04013279 RID: 78457
		public const string __ObjectPath = "/Script/Niagara.NiagaraDebugHUDVariable";

		// Token: 0x0401327A RID: 78458
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401327B RID: 78459
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x0401327C RID: 78460
		internal static int __PropertyOffset_Name;
	}
}
