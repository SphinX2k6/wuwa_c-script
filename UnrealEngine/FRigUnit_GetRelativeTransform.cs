using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005BD RID: 1469
	[UnrealObjectPath("/Script/ControlRig.RigUnit_GetRelativeTransform")]
	[UnrealStructLayout(160, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FRigUnit_GetRelativeTransform : FRigUnit_BinaryTransformOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004F55 RID: 20309 RVA: 0x000751C5 File Offset: 0x000733C5
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_GetRelativeTransform._ScriptStructPtr != 0) ? FRigUnit_GetRelativeTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_GetRelativeTransform", ref FRigUnit_GetRelativeTransform._ScriptStructPtr);
		}

		// Token: 0x06004F56 RID: 20310 RVA: 0x000751E9 File Offset: 0x000733E9
		public FRigUnit_GetRelativeTransform()
		{
		}

		// Token: 0x06004F57 RID: 20311 RVA: 0x000751F1 File Offset: 0x000733F1
		public FRigUnit_GetRelativeTransform(FTransform Argument0, FTransform Argument1, FTransform Result)
		{
			base.Argument0 = Argument0;
			base.Argument1 = Argument1;
			base.Result = Result;
		}

		// Token: 0x06004F58 RID: 20312 RVA: 0x0007520E File Offset: 0x0007340E
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_GetRelativeTransform.StaticStruct();
		}

		// Token: 0x06004F59 RID: 20313 RVA: 0x0007521A File Offset: 0x0007341A
		[NullableContext(2)]
		public FRigUnit_GetRelativeTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004F5A RID: 20314 RVA: 0x00075224 File Offset: 0x00073424
		public FRigUnit_GetRelativeTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004F5B RID: 20315 RVA: 0x0007522F File Offset: 0x0007342F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_GetRelativeTransform(Pointer, false, true);
		}

		// Token: 0x06004F5C RID: 20316 RVA: 0x00075239 File Offset: 0x00073439
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_GetRelativeTransform(Pointer, MemoryOwner);
		}

		// Token: 0x0400264B RID: 9803
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_GetRelativeTransform";

		// Token: 0x0400264C RID: 9804
		private static IntPtr _ScriptStructPtr;
	}
}
