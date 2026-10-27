using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000690 RID: 1680
	[UnrealObjectPath("/Script/ControlRig.RigUnit_ModifyBoneTransforms_WorkData")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_ModifyBoneTransforms_WorkData : FRigUnit_ModifyTransforms_WorkData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600594D RID: 22861 RVA: 0x0008060D File Offset: 0x0007E80D
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_ModifyBoneTransforms_WorkData._ScriptStructPtr != 0) ? FRigUnit_ModifyBoneTransforms_WorkData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_ModifyBoneTransforms_WorkData", ref FRigUnit_ModifyBoneTransforms_WorkData._ScriptStructPtr);
		}

		// Token: 0x0600594E RID: 22862 RVA: 0x00080631 File Offset: 0x0007E831
		public FRigUnit_ModifyBoneTransforms_WorkData()
		{
		}

		// Token: 0x0600594F RID: 22863 RVA: 0x00080639 File Offset: 0x0007E839
		[NullableContext(1)]
		public FRigUnit_ModifyBoneTransforms_WorkData(TArray<FCachedRigElement> CachedItems)
		{
			base.CachedItems = CachedItems;
		}

		// Token: 0x06005950 RID: 22864 RVA: 0x00080648 File Offset: 0x0007E848
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_ModifyBoneTransforms_WorkData.StaticStruct();
		}

		// Token: 0x06005951 RID: 22865 RVA: 0x00080654 File Offset: 0x0007E854
		[NullableContext(2)]
		public FRigUnit_ModifyBoneTransforms_WorkData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005952 RID: 22866 RVA: 0x0008065E File Offset: 0x0007E85E
		public FRigUnit_ModifyBoneTransforms_WorkData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005953 RID: 22867 RVA: 0x00080669 File Offset: 0x0007E869
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_ModifyBoneTransforms_WorkData(Pointer, false, true);
		}

		// Token: 0x06005954 RID: 22868 RVA: 0x00080673 File Offset: 0x0007E873
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_ModifyBoneTransforms_WorkData(Pointer, MemoryOwner);
		}

		// Token: 0x040029DE RID: 10718
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_ModifyBoneTransforms_WorkData";

		// Token: 0x040029DF RID: 10719
		private static IntPtr _ScriptStructPtr;
	}
}
