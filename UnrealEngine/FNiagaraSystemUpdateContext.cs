using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025F9 RID: 9721
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraSystemUpdateContext")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FNiagaraSystemUpdateContext : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024284 RID: 148100 RVA: 0x003584F0 File Offset: 0x003566F0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraSystemUpdateContext._ScriptStructPtr != 0) ? FNiagaraSystemUpdateContext._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraSystemUpdateContext", ref FNiagaraSystemUpdateContext._ScriptStructPtr);
		}

		// Token: 0x17008B41 RID: 35649
		// (get) Token: 0x06024285 RID: 148101 RVA: 0x00358514 File Offset: 0x00356714
		// (set) Token: 0x06024286 RID: 148102 RVA: 0x00358557 File Offset: 0x00356757
		public TArray<UNiagaraComponent> ComponentsToReset
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UNiagaraComponent> result;
				if ((result = this._ComponentsToReset) == null)
				{
					result = (this._ComponentsToReset = new TArray<UNiagaraComponent>(base.NativePtr + (IntPtr)FNiagaraSystemUpdateContext.__PropertyOffset_ComponentsToReset, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ComponentsToReset.CopyAssign(value);
			}
		}

		// Token: 0x17008B42 RID: 35650
		// (get) Token: 0x06024287 RID: 148103 RVA: 0x00358568 File Offset: 0x00356768
		// (set) Token: 0x06024288 RID: 148104 RVA: 0x003585AB File Offset: 0x003567AB
		public TArray<UNiagaraComponent> ComponentsToReInit
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UNiagaraComponent> result;
				if ((result = this._ComponentsToReInit) == null)
				{
					result = (this._ComponentsToReInit = new TArray<UNiagaraComponent>(base.NativePtr + (IntPtr)FNiagaraSystemUpdateContext.__PropertyOffset_ComponentsToReInit, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ComponentsToReInit.CopyAssign(value);
			}
		}

		// Token: 0x17008B43 RID: 35651
		// (get) Token: 0x06024289 RID: 148105 RVA: 0x003585BC File Offset: 0x003567BC
		// (set) Token: 0x0602428A RID: 148106 RVA: 0x003585FF File Offset: 0x003567FF
		public TArray<UNiagaraComponent> ComponentsToNotifySimDestroy
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UNiagaraComponent> result;
				if ((result = this._ComponentsToNotifySimDestroy) == null)
				{
					result = (this._ComponentsToNotifySimDestroy = new TArray<UNiagaraComponent>(base.NativePtr + (IntPtr)FNiagaraSystemUpdateContext.__PropertyOffset_ComponentsToNotifySimDestroy, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ComponentsToNotifySimDestroy.CopyAssign(value);
			}
		}

		// Token: 0x17008B44 RID: 35652
		// (get) Token: 0x0602428B RID: 148107 RVA: 0x00358610 File Offset: 0x00356810
		// (set) Token: 0x0602428C RID: 148108 RVA: 0x00358653 File Offset: 0x00356853
		public TArray<UNiagaraSystem> SystemSimsToDestroy
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UNiagaraSystem> result;
				if ((result = this._SystemSimsToDestroy) == null)
				{
					result = (this._SystemSimsToDestroy = new TArray<UNiagaraSystem>(base.NativePtr + (IntPtr)FNiagaraSystemUpdateContext.__PropertyOffset_SystemSimsToDestroy, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SystemSimsToDestroy.CopyAssign(value);
			}
		}

		// Token: 0x0602428D RID: 148109 RVA: 0x00358661 File Offset: 0x00356861
		public FNiagaraSystemUpdateContext()
		{
		}

		// Token: 0x0602428E RID: 148110 RVA: 0x00358669 File Offset: 0x00356869
		public FNiagaraSystemUpdateContext(TArray<UNiagaraComponent> ComponentsToReset, TArray<UNiagaraComponent> ComponentsToReInit, TArray<UNiagaraComponent> ComponentsToNotifySimDestroy, TArray<UNiagaraSystem> SystemSimsToDestroy)
		{
			this.ComponentsToReset = ComponentsToReset;
			this.ComponentsToReInit = ComponentsToReInit;
			this.ComponentsToNotifySimDestroy = ComponentsToNotifySimDestroy;
			this.SystemSimsToDestroy = SystemSimsToDestroy;
		}

		// Token: 0x0602428F RID: 148111 RVA: 0x0035868E File Offset: 0x0035688E
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraSystemUpdateContext.StaticStruct();
		}

		// Token: 0x06024290 RID: 148112 RVA: 0x0035869A File Offset: 0x0035689A
		[NullableContext(2)]
		public FNiagaraSystemUpdateContext(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024291 RID: 148113 RVA: 0x003586A4 File Offset: 0x003568A4
		public FNiagaraSystemUpdateContext(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024292 RID: 148114 RVA: 0x003586AF File Offset: 0x003568AF
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraSystemUpdateContext(Pointer, false, true);
		}

		// Token: 0x06024293 RID: 148115 RVA: 0x003586B9 File Offset: 0x003568B9
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraSystemUpdateContext(Pointer, MemoryOwner);
		}

		// Token: 0x0401366A RID: 79466
		public const string __ObjectPath = "/Script/Niagara.NiagaraSystemUpdateContext";

		// Token: 0x0401366B RID: 79467
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401366C RID: 79468
		internal static int __PropertyOffset_ComponentsToReset;

		// Token: 0x0401366D RID: 79469
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UNiagaraComponent> _ComponentsToReset;

		// Token: 0x0401366E RID: 79470
		internal static int __PropertyOffset_ComponentsToReInit;

		// Token: 0x0401366F RID: 79471
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UNiagaraComponent> _ComponentsToReInit;

		// Token: 0x04013670 RID: 79472
		internal static int __PropertyOffset_ComponentsToNotifySimDestroy;

		// Token: 0x04013671 RID: 79473
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UNiagaraComponent> _ComponentsToNotifySimDestroy;

		// Token: 0x04013672 RID: 79474
		internal static int __PropertyOffset_SystemSimsToDestroy;

		// Token: 0x04013673 RID: 79475
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UNiagaraSystem> _SystemSimsToDestroy;
	}
}
