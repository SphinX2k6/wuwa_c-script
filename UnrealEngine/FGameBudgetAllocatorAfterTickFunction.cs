using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200185F RID: 6239
	[UnrealObjectPath("/Script/KuroGameBudget.GameBudgetAllocatorAfterTickFunction")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FGameBudgetAllocatorAfterTickFunction : FTickFunction, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016F48 RID: 94024 RVA: 0x00217DA5 File Offset: 0x00215FA5
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameBudgetAllocatorAfterTickFunction._ScriptStructPtr != 0) ? FGameBudgetAllocatorAfterTickFunction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameBudget.GameBudgetAllocatorAfterTickFunction", ref FGameBudgetAllocatorAfterTickFunction._ScriptStructPtr);
		}

		// Token: 0x06016F49 RID: 94025 RVA: 0x00217DC9 File Offset: 0x00215FC9
		public FGameBudgetAllocatorAfterTickFunction()
		{
		}

		// Token: 0x06016F4A RID: 94026 RVA: 0x00217DD1 File Offset: 0x00215FD1
		public FGameBudgetAllocatorAfterTickFunction(TEnumAsByte<ETickingGroup> TickGroup, TEnumAsByte<ETickingGroup> EndTickGroup, bool bTickEvenWhenPaused, bool bCanEverTick, bool bStartWithTickEnabled, bool bAllowTickOnDedicatedServer, float TickInterval)
		{
			base.TickGroup = TickGroup;
			base.EndTickGroup = EndTickGroup;
			base.bTickEvenWhenPaused = bTickEvenWhenPaused;
			base.bCanEverTick = bCanEverTick;
			base.bStartWithTickEnabled = bStartWithTickEnabled;
			base.bAllowTickOnDedicatedServer = bAllowTickOnDedicatedServer;
			base.TickInterval = TickInterval;
		}

		// Token: 0x06016F4B RID: 94027 RVA: 0x00217E0E File Offset: 0x0021600E
		protected override IntPtr GetUStructPtr()
		{
			return FGameBudgetAllocatorAfterTickFunction.StaticStruct();
		}

		// Token: 0x06016F4C RID: 94028 RVA: 0x00217E1A File Offset: 0x0021601A
		[NullableContext(2)]
		public FGameBudgetAllocatorAfterTickFunction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016F4D RID: 94029 RVA: 0x00217E24 File Offset: 0x00216024
		public FGameBudgetAllocatorAfterTickFunction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016F4E RID: 94030 RVA: 0x00217E2F File Offset: 0x0021602F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameBudgetAllocatorAfterTickFunction(Pointer, false, true);
		}

		// Token: 0x06016F4F RID: 94031 RVA: 0x00217E39 File Offset: 0x00216039
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameBudgetAllocatorAfterTickFunction(Pointer, MemoryOwner);
		}

		// Token: 0x0400C7A3 RID: 51107
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameBudget.GameBudgetAllocatorAfterTickFunction";

		// Token: 0x0400C7A4 RID: 51108
		private static IntPtr _ScriptStructPtr;
	}
}
