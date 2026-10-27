using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001862 RID: 6242
	[UnrealObjectPath("/Script/KuroGameBudget.GameBudgetAllocatorTickFunction")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FGameBudgetAllocatorTickFunction : FTickFunction, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016F72 RID: 94066 RVA: 0x002180C9 File Offset: 0x002162C9
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameBudgetAllocatorTickFunction._ScriptStructPtr != 0) ? FGameBudgetAllocatorTickFunction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameBudget.GameBudgetAllocatorTickFunction", ref FGameBudgetAllocatorTickFunction._ScriptStructPtr);
		}

		// Token: 0x06016F73 RID: 94067 RVA: 0x002180ED File Offset: 0x002162ED
		public FGameBudgetAllocatorTickFunction()
		{
		}

		// Token: 0x06016F74 RID: 94068 RVA: 0x002180F5 File Offset: 0x002162F5
		public FGameBudgetAllocatorTickFunction(TEnumAsByte<ETickingGroup> TickGroup, TEnumAsByte<ETickingGroup> EndTickGroup, bool bTickEvenWhenPaused, bool bCanEverTick, bool bStartWithTickEnabled, bool bAllowTickOnDedicatedServer, float TickInterval)
		{
			base.TickGroup = TickGroup;
			base.EndTickGroup = EndTickGroup;
			base.bTickEvenWhenPaused = bTickEvenWhenPaused;
			base.bCanEverTick = bCanEverTick;
			base.bStartWithTickEnabled = bStartWithTickEnabled;
			base.bAllowTickOnDedicatedServer = bAllowTickOnDedicatedServer;
			base.TickInterval = TickInterval;
		}

		// Token: 0x06016F75 RID: 94069 RVA: 0x00218132 File Offset: 0x00216332
		protected override IntPtr GetUStructPtr()
		{
			return FGameBudgetAllocatorTickFunction.StaticStruct();
		}

		// Token: 0x06016F76 RID: 94070 RVA: 0x0021813E File Offset: 0x0021633E
		[NullableContext(2)]
		public FGameBudgetAllocatorTickFunction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016F77 RID: 94071 RVA: 0x00218148 File Offset: 0x00216348
		public FGameBudgetAllocatorTickFunction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016F78 RID: 94072 RVA: 0x00218153 File Offset: 0x00216353
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameBudgetAllocatorTickFunction(Pointer, false, true);
		}

		// Token: 0x06016F79 RID: 94073 RVA: 0x0021815D File Offset: 0x0021635D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameBudgetAllocatorTickFunction(Pointer, MemoryOwner);
		}

		// Token: 0x0400C7B3 RID: 51123
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameBudget.GameBudgetAllocatorTickFunction";

		// Token: 0x0400C7B4 RID: 51124
		private static IntPtr _ScriptStructPtr;
	}
}
