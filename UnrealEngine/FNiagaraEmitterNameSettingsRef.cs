using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200259E RID: 9630
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/Niagara.NiagaraEmitterNameSettingsRef")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FNiagaraEmitterNameSettingsRef : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023C53 RID: 146515 RVA: 0x0034E657 File Offset: 0x0034C857
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraEmitterNameSettingsRef._ScriptStructPtr != 0) ? FNiagaraEmitterNameSettingsRef._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraEmitterNameSettingsRef", ref FNiagaraEmitterNameSettingsRef._ScriptStructPtr);
		}

		// Token: 0x1700897E RID: 35198
		// (get) Token: 0x06023C54 RID: 146516 RVA: 0x0034E67B File Offset: 0x0034C87B
		// (set) Token: 0x06023C55 RID: 146517 RVA: 0x0034E68F File Offset: 0x0034C88F
		public unsafe FName SystemName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraEmitterNameSettingsRef.__PropertyOffset_SystemName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraEmitterNameSettingsRef.__PropertyOffset_SystemName) = value;
			}
		}

		// Token: 0x1700897F RID: 35199
		// (get) Token: 0x06023C56 RID: 146518 RVA: 0x0034E6A4 File Offset: 0x0034C8A4
		// (set) Token: 0x06023C57 RID: 146519 RVA: 0x0034E6B8 File Offset: 0x0034C8B8
		public unsafe string EmitterName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FNiagaraEmitterNameSettingsRef.__PropertyOffset_EmitterName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FNiagaraEmitterNameSettingsRef.__PropertyOffset_EmitterName)), value);
			}
		}

		// Token: 0x06023C58 RID: 146520 RVA: 0x0034E6CD File Offset: 0x0034C8CD
		public FNiagaraEmitterNameSettingsRef()
		{
		}

		// Token: 0x06023C59 RID: 146521 RVA: 0x0034E6D5 File Offset: 0x0034C8D5
		public FNiagaraEmitterNameSettingsRef(FName SystemName, string EmitterName)
		{
			this.SystemName = SystemName;
			this.EmitterName = EmitterName;
		}

		// Token: 0x06023C5A RID: 146522 RVA: 0x0034E6EB File Offset: 0x0034C8EB
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraEmitterNameSettingsRef.StaticStruct();
		}

		// Token: 0x06023C5B RID: 146523 RVA: 0x0034E6F7 File Offset: 0x0034C8F7
		[NullableContext(2)]
		public FNiagaraEmitterNameSettingsRef(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023C5C RID: 146524 RVA: 0x0034E701 File Offset: 0x0034C901
		public FNiagaraEmitterNameSettingsRef(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023C5D RID: 146525 RVA: 0x0034E70C File Offset: 0x0034C90C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraEmitterNameSettingsRef(Pointer, false, true);
		}

		// Token: 0x06023C5E RID: 146526 RVA: 0x0034E716 File Offset: 0x0034C916
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraEmitterNameSettingsRef(Pointer, MemoryOwner);
		}

		// Token: 0x040132FA RID: 78586
		public const string __ObjectPath = "/Script/Niagara.NiagaraEmitterNameSettingsRef";

		// Token: 0x040132FB RID: 78587
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040132FC RID: 78588
		internal static int __PropertyOffset_SystemName;

		// Token: 0x040132FD RID: 78589
		internal static int __PropertyOffset_EmitterName;
	}
}
