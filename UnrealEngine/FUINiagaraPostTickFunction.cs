using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002191 RID: 8593
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UINiagaraPostTickFunction")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FUINiagaraPostTickFunction : FTickFunction, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06020960 RID: 133472 RVA: 0x00303E44 File Offset: 0x00302044
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FUINiagaraPostTickFunction._ScriptStructPtr != 0) ? FUINiagaraPostTickFunction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.UINiagaraPostTickFunction", ref FUINiagaraPostTickFunction._ScriptStructPtr);
		}

		// Token: 0x17007F6D RID: 32621
		// (get) Token: 0x06020961 RID: 133473 RVA: 0x00303E68 File Offset: 0x00302068
		// (set) Token: 0x06020962 RID: 133474 RVA: 0x00303EAB File Offset: 0x003020AB
		public TArray<UUINiagara> UINiagaras
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UUINiagara> result;
				if ((result = this._UINiagaras) == null)
				{
					result = (this._UINiagaras = new TArray<UUINiagara>(base.NativePtr + (IntPtr)FUINiagaraPostTickFunction.__PropertyOffset_UINiagaras, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.UINiagaras.CopyAssign(value);
			}
		}

		// Token: 0x06020963 RID: 133475 RVA: 0x00303EB9 File Offset: 0x003020B9
		public FUINiagaraPostTickFunction()
		{
		}

		// Token: 0x06020964 RID: 133476 RVA: 0x00303EC4 File Offset: 0x003020C4
		[NullableContext(0)]
		public FUINiagaraPostTickFunction([Nullable(1)] TArray<UUINiagara> UINiagaras, TEnumAsByte<ETickingGroup> TickGroup, TEnumAsByte<ETickingGroup> EndTickGroup, bool bTickEvenWhenPaused, bool bCanEverTick, bool bStartWithTickEnabled, bool bAllowTickOnDedicatedServer, float TickInterval)
		{
			this.UINiagaras = UINiagaras;
			base.TickGroup = TickGroup;
			base.EndTickGroup = EndTickGroup;
			base.bTickEvenWhenPaused = bTickEvenWhenPaused;
			base.bCanEverTick = bCanEverTick;
			base.bStartWithTickEnabled = bStartWithTickEnabled;
			base.bAllowTickOnDedicatedServer = bAllowTickOnDedicatedServer;
			base.TickInterval = TickInterval;
		}

		// Token: 0x06020965 RID: 133477 RVA: 0x00303F14 File Offset: 0x00302114
		protected override IntPtr GetUStructPtr()
		{
			return FUINiagaraPostTickFunction.StaticStruct();
		}

		// Token: 0x06020966 RID: 133478 RVA: 0x00303F20 File Offset: 0x00302120
		[NullableContext(2)]
		public FUINiagaraPostTickFunction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06020967 RID: 133479 RVA: 0x00303F2A File Offset: 0x0030212A
		public FUINiagaraPostTickFunction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06020968 RID: 133480 RVA: 0x00303F35 File Offset: 0x00302135
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FUINiagaraPostTickFunction(Pointer, false, true);
		}

		// Token: 0x06020969 RID: 133481 RVA: 0x00303F3F File Offset: 0x0030213F
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FUINiagaraPostTickFunction(Pointer, MemoryOwner);
		}

		// Token: 0x0401171C RID: 71452
		public new const string __ObjectPath = "/Script/LGUI.UINiagaraPostTickFunction";

		// Token: 0x0401171D RID: 71453
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401171E RID: 71454
		internal static int __PropertyOffset_UINiagaras;

		// Token: 0x0401171F RID: 71455
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UUINiagara> _UINiagaras;
	}
}
