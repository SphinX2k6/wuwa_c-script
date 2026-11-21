using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200055C RID: 1372
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSCSceneSegmentTableRow")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FKSCSceneSegmentTableRow : FKSCTableRowBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007D4D RID: 32077 RVA: 0x000B9EC7 File Offset: 0x000B80C7
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSCSceneSegmentTableRow._ScriptStructPtr != 0) ? FKSCSceneSegmentTableRow._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSCSceneSegmentTableRow", ref FKSCSceneSegmentTableRow._ScriptStructPtr);
		}

		// Token: 0x06007D4E RID: 32078 RVA: 0x000B9EEB File Offset: 0x000B80EB
		public FKSCSceneSegmentTableRow()
		{
		}

		// Token: 0x06007D4F RID: 32079 RVA: 0x000B9EF3 File Offset: 0x000B80F3
		protected override IntPtr GetUStructPtr()
		{
			return FKSCSceneSegmentTableRow.StaticStruct();
		}

		// Token: 0x06007D50 RID: 32080 RVA: 0x000B9EFF File Offset: 0x000B80FF
		[NullableContext(2)]
		public FKSCSceneSegmentTableRow(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007D51 RID: 32081 RVA: 0x000B9F09 File Offset: 0x000B8109
		public FKSCSceneSegmentTableRow(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007D52 RID: 32082 RVA: 0x000B9F14 File Offset: 0x000B8114
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSCSceneSegmentTableRow(Pointer, false, true);
		}

		// Token: 0x06007D53 RID: 32083 RVA: 0x000B9F1E File Offset: 0x000B811E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSCSceneSegmentTableRow(Pointer, MemoryOwner);
		}

		// Token: 0x0400369E RID: 13982
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSCSceneSegmentTableRow";

		// Token: 0x0400369F RID: 13983
		private static IntPtr _ScriptStructPtr;
	}
}
