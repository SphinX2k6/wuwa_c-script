using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001CF0 RID: 7408
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSCBuffTableRow")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FKSCBuffTableRow : FKSCTableRowBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601C7F0 RID: 116720 RVA: 0x002A2461 File Offset: 0x002A0661
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSCBuffTableRow._ScriptStructPtr != 0) ? FKSCBuffTableRow._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSCBuffTableRow", ref FKSCBuffTableRow._ScriptStructPtr);
		}

		// Token: 0x0601C7F1 RID: 116721 RVA: 0x002A2485 File Offset: 0x002A0685
		public FKSCBuffTableRow()
		{
		}

		// Token: 0x0601C7F2 RID: 116722 RVA: 0x002A248D File Offset: 0x002A068D
		[NullableContext(1)]
		public FKSCBuffTableRow(int Id, TSoftObjectPtr<UDataAsset> RuntimeDA)
		{
			base.Id = Id;
			base.RuntimeDA = RuntimeDA;
		}

		// Token: 0x0601C7F3 RID: 116723 RVA: 0x002A24A3 File Offset: 0x002A06A3
		protected override IntPtr GetUStructPtr()
		{
			return FKSCBuffTableRow.StaticStruct();
		}

		// Token: 0x0601C7F4 RID: 116724 RVA: 0x002A24AF File Offset: 0x002A06AF
		[NullableContext(2)]
		public FKSCBuffTableRow(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C7F5 RID: 116725 RVA: 0x002A24B9 File Offset: 0x002A06B9
		public FKSCBuffTableRow(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C7F6 RID: 116726 RVA: 0x002A24C4 File Offset: 0x002A06C4
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSCBuffTableRow(Pointer, false, true);
		}

		// Token: 0x0601C7F7 RID: 116727 RVA: 0x002A24CE File Offset: 0x002A06CE
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSCBuffTableRow(Pointer, MemoryOwner);
		}

		// Token: 0x0400F742 RID: 63298
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSCBuffTableRow";

		// Token: 0x0400F743 RID: 63299
		private static IntPtr _ScriptStructPtr;
	}
}
