using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200059E RID: 1438
	[UnrealObjectPath("/Script/ControlRig.RigUnit_Divide_VectorVector")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_Divide_VectorVector : FRigUnit_BinaryVectorOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004D2D RID: 19757 RVA: 0x00072177 File Offset: 0x00070377
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_Divide_VectorVector._ScriptStructPtr != 0) ? FRigUnit_Divide_VectorVector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_Divide_VectorVector", ref FRigUnit_Divide_VectorVector._ScriptStructPtr);
		}

		// Token: 0x06004D2E RID: 19758 RVA: 0x0007219B File Offset: 0x0007039B
		public FRigUnit_Divide_VectorVector()
		{
		}

		// Token: 0x06004D2F RID: 19759 RVA: 0x000721A3 File Offset: 0x000703A3
		public FRigUnit_Divide_VectorVector(FVector Argument0, FVector Argument1, FVector Result)
		{
			base.Argument0 = Argument0;
			base.Argument1 = Argument1;
			base.Result = Result;
		}

		// Token: 0x06004D30 RID: 19760 RVA: 0x000721C0 File Offset: 0x000703C0
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_Divide_VectorVector.StaticStruct();
		}

		// Token: 0x06004D31 RID: 19761 RVA: 0x000721CC File Offset: 0x000703CC
		[NullableContext(2)]
		public FRigUnit_Divide_VectorVector(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004D32 RID: 19762 RVA: 0x000721D6 File Offset: 0x000703D6
		public FRigUnit_Divide_VectorVector(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004D33 RID: 19763 RVA: 0x000721E1 File Offset: 0x000703E1
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_Divide_VectorVector(Pointer, false, true);
		}

		// Token: 0x06004D34 RID: 19764 RVA: 0x000721EB File Offset: 0x000703EB
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_Divide_VectorVector(Pointer, MemoryOwner);
		}

		// Token: 0x0400254F RID: 9551
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_Divide_VectorVector";

		// Token: 0x04002550 RID: 9552
		private static IntPtr _ScriptStructPtr;
	}
}
