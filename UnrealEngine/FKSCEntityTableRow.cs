using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001CF3 RID: 7411
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSCEntityTableRow")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FKSCEntityTableRow : FKSCTableRowBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601C822 RID: 116770 RVA: 0x002A27F5 File Offset: 0x002A09F5
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSCEntityTableRow._ScriptStructPtr != 0) ? FKSCEntityTableRow._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSCEntityTableRow", ref FKSCEntityTableRow._ScriptStructPtr);
		}

		// Token: 0x0601C823 RID: 116771 RVA: 0x002A2819 File Offset: 0x002A0A19
		public FKSCEntityTableRow()
		{
		}

		// Token: 0x0601C824 RID: 116772 RVA: 0x002A2821 File Offset: 0x002A0A21
		[NullableContext(1)]
		public FKSCEntityTableRow(int Id, TSoftObjectPtr<UDataAsset> RuntimeDA)
		{
			base.Id = Id;
			base.RuntimeDA = RuntimeDA;
		}

		// Token: 0x0601C825 RID: 116773 RVA: 0x002A2837 File Offset: 0x002A0A37
		protected override IntPtr GetUStructPtr()
		{
			return FKSCEntityTableRow.StaticStruct();
		}

		// Token: 0x0601C826 RID: 116774 RVA: 0x002A2843 File Offset: 0x002A0A43
		[NullableContext(2)]
		public FKSCEntityTableRow(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C827 RID: 116775 RVA: 0x002A284D File Offset: 0x002A0A4D
		public FKSCEntityTableRow(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C828 RID: 116776 RVA: 0x002A2858 File Offset: 0x002A0A58
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSCEntityTableRow(Pointer, false, true);
		}

		// Token: 0x0601C829 RID: 116777 RVA: 0x002A2862 File Offset: 0x002A0A62
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSCEntityTableRow(Pointer, MemoryOwner);
		}

		// Token: 0x0400F756 RID: 63318
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSCEntityTableRow";

		// Token: 0x0400F757 RID: 63319
		private static IntPtr _ScriptStructPtr;
	}
}
