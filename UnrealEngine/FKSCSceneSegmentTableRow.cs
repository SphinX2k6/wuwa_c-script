using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001CF4 RID: 7412
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSCSceneSegmentTableRow")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FKSCSceneSegmentTableRow : FKSCTableRowBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601C82A RID: 116778 RVA: 0x002A286B File Offset: 0x002A0A6B
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSCSceneSegmentTableRow._ScriptStructPtr != 0) ? FKSCSceneSegmentTableRow._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSCSceneSegmentTableRow", ref FKSCSceneSegmentTableRow._ScriptStructPtr);
		}

		// Token: 0x0601C82B RID: 116779 RVA: 0x002A288F File Offset: 0x002A0A8F
		public FKSCSceneSegmentTableRow()
		{
		}

		// Token: 0x0601C82C RID: 116780 RVA: 0x002A2897 File Offset: 0x002A0A97
		[NullableContext(1)]
		public FKSCSceneSegmentTableRow(int Id, TSoftObjectPtr<UDataAsset> RuntimeDA)
		{
			base.Id = Id;
			base.RuntimeDA = RuntimeDA;
		}

		// Token: 0x0601C82D RID: 116781 RVA: 0x002A28AD File Offset: 0x002A0AAD
		protected override IntPtr GetUStructPtr()
		{
			return FKSCSceneSegmentTableRow.StaticStruct();
		}

		// Token: 0x0601C82E RID: 116782 RVA: 0x002A28B9 File Offset: 0x002A0AB9
		[NullableContext(2)]
		public FKSCSceneSegmentTableRow(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C82F RID: 116783 RVA: 0x002A28C3 File Offset: 0x002A0AC3
		public FKSCSceneSegmentTableRow(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C830 RID: 116784 RVA: 0x002A28CE File Offset: 0x002A0ACE
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSCSceneSegmentTableRow(Pointer, false, true);
		}

		// Token: 0x0601C831 RID: 116785 RVA: 0x002A28D8 File Offset: 0x002A0AD8
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSCSceneSegmentTableRow(Pointer, MemoryOwner);
		}

		// Token: 0x0400F758 RID: 63320
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSCSceneSegmentTableRow";

		// Token: 0x0400F759 RID: 63321
		private static IntPtr _ScriptStructPtr;
	}
}
