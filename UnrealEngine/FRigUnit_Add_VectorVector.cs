using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200053E RID: 1342
	[UnrealObjectPath("/Script/ControlRig.RigUnit_Add_VectorVector")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_Add_VectorVector : FRigUnit_BinaryVectorOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004690 RID: 18064 RVA: 0x00068ABA File Offset: 0x00066CBA
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_Add_VectorVector._ScriptStructPtr != 0) ? FRigUnit_Add_VectorVector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_Add_VectorVector", ref FRigUnit_Add_VectorVector._ScriptStructPtr);
		}

		// Token: 0x06004691 RID: 18065 RVA: 0x00068ADE File Offset: 0x00066CDE
		public FRigUnit_Add_VectorVector()
		{
		}

		// Token: 0x06004692 RID: 18066 RVA: 0x00068AE6 File Offset: 0x00066CE6
		public FRigUnit_Add_VectorVector(FVector Argument0, FVector Argument1, FVector Result)
		{
			base.Argument0 = Argument0;
			base.Argument1 = Argument1;
			base.Result = Result;
		}

		// Token: 0x06004693 RID: 18067 RVA: 0x00068B03 File Offset: 0x00066D03
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_Add_VectorVector.StaticStruct();
		}

		// Token: 0x06004694 RID: 18068 RVA: 0x00068B0F File Offset: 0x00066D0F
		[NullableContext(2)]
		public FRigUnit_Add_VectorVector(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004695 RID: 18069 RVA: 0x00068B19 File Offset: 0x00066D19
		public FRigUnit_Add_VectorVector(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004696 RID: 18070 RVA: 0x00068B24 File Offset: 0x00066D24
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_Add_VectorVector(Pointer, false, true);
		}

		// Token: 0x06004697 RID: 18071 RVA: 0x00068B2E File Offset: 0x00066D2E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_Add_VectorVector(Pointer, MemoryOwner);
		}

		// Token: 0x04002242 RID: 8770
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_Add_VectorVector";

		// Token: 0x04002243 RID: 8771
		private static IntPtr _ScriptStructPtr;
	}
}
