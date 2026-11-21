using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200055B RID: 1371
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSCEntityTableRow")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FKSCEntityTableRow : FKSCTableRowBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007D46 RID: 32070 RVA: 0x000B9E67 File Offset: 0x000B8067
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSCEntityTableRow._ScriptStructPtr != 0) ? FKSCEntityTableRow._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSCEntityTableRow", ref FKSCEntityTableRow._ScriptStructPtr);
		}

		// Token: 0x06007D47 RID: 32071 RVA: 0x000B9E8B File Offset: 0x000B808B
		public FKSCEntityTableRow()
		{
		}

		// Token: 0x06007D48 RID: 32072 RVA: 0x000B9E93 File Offset: 0x000B8093
		protected override IntPtr GetUStructPtr()
		{
			return FKSCEntityTableRow.StaticStruct();
		}

		// Token: 0x06007D49 RID: 32073 RVA: 0x000B9E9F File Offset: 0x000B809F
		[NullableContext(2)]
		public FKSCEntityTableRow(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007D4A RID: 32074 RVA: 0x000B9EA9 File Offset: 0x000B80A9
		public FKSCEntityTableRow(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007D4B RID: 32075 RVA: 0x000B9EB4 File Offset: 0x000B80B4
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSCEntityTableRow(Pointer, false, true);
		}

		// Token: 0x06007D4C RID: 32076 RVA: 0x000B9EBE File Offset: 0x000B80BE
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSCEntityTableRow(Pointer, MemoryOwner);
		}

		// Token: 0x0400369C RID: 13980
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSCEntityTableRow";

		// Token: 0x0400369D RID: 13981
		private static IntPtr _ScriptStructPtr;
	}
}
