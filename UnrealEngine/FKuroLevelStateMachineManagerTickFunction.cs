using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020019B6 RID: 6582
	[UnrealObjectPath("/Script/KuroLevelStateMachine.KuroLevelStateMachineManagerTickFunction")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FKuroLevelStateMachineManagerTickFunction : FTickFunction, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060187C1 RID: 100289 RVA: 0x002413DB File Offset: 0x0023F5DB
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroLevelStateMachineManagerTickFunction._ScriptStructPtr != 0) ? FKuroLevelStateMachineManagerTickFunction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroLevelStateMachine.KuroLevelStateMachineManagerTickFunction", ref FKuroLevelStateMachineManagerTickFunction._ScriptStructPtr);
		}

		// Token: 0x060187C2 RID: 100290 RVA: 0x002413FF File Offset: 0x0023F5FF
		public FKuroLevelStateMachineManagerTickFunction()
		{
		}

		// Token: 0x060187C3 RID: 100291 RVA: 0x00241407 File Offset: 0x0023F607
		public FKuroLevelStateMachineManagerTickFunction(TEnumAsByte<ETickingGroup> TickGroup, TEnumAsByte<ETickingGroup> EndTickGroup, bool bTickEvenWhenPaused, bool bCanEverTick, bool bStartWithTickEnabled, bool bAllowTickOnDedicatedServer, float TickInterval)
		{
			base.TickGroup = TickGroup;
			base.EndTickGroup = EndTickGroup;
			base.bTickEvenWhenPaused = bTickEvenWhenPaused;
			base.bCanEverTick = bCanEverTick;
			base.bStartWithTickEnabled = bStartWithTickEnabled;
			base.bAllowTickOnDedicatedServer = bAllowTickOnDedicatedServer;
			base.TickInterval = TickInterval;
		}

		// Token: 0x060187C4 RID: 100292 RVA: 0x00241444 File Offset: 0x0023F644
		protected override IntPtr GetUStructPtr()
		{
			return FKuroLevelStateMachineManagerTickFunction.StaticStruct();
		}

		// Token: 0x060187C5 RID: 100293 RVA: 0x00241450 File Offset: 0x0023F650
		[NullableContext(2)]
		public FKuroLevelStateMachineManagerTickFunction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060187C6 RID: 100294 RVA: 0x0024145A File Offset: 0x0023F65A
		public FKuroLevelStateMachineManagerTickFunction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060187C7 RID: 100295 RVA: 0x00241465 File Offset: 0x0023F665
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroLevelStateMachineManagerTickFunction(Pointer, false, true);
		}

		// Token: 0x060187C8 RID: 100296 RVA: 0x0024146F File Offset: 0x0023F66F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroLevelStateMachineManagerTickFunction(Pointer, MemoryOwner);
		}

		// Token: 0x0400D39E RID: 54174
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroLevelStateMachine.KuroLevelStateMachineManagerTickFunction";

		// Token: 0x0400D39F RID: 54175
		private static IntPtr _ScriptStructPtr;
	}
}
