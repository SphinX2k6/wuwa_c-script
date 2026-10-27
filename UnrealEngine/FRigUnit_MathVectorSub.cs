using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200068B RID: 1675
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathVectorSub")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_MathVectorSub : FRigUnit_MathVectorBinaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005911 RID: 22801 RVA: 0x000801B0 File Offset: 0x0007E3B0
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathVectorSub._ScriptStructPtr != 0) ? FRigUnit_MathVectorSub._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathVectorSub", ref FRigUnit_MathVectorSub._ScriptStructPtr);
		}

		// Token: 0x06005912 RID: 22802 RVA: 0x000801D4 File Offset: 0x0007E3D4
		public FRigUnit_MathVectorSub()
		{
		}

		// Token: 0x06005913 RID: 22803 RVA: 0x000801DC File Offset: 0x0007E3DC
		public FRigUnit_MathVectorSub(FVector A, FVector B, FVector Result)
		{
			base.A = A;
			base.B = B;
			base.Result = Result;
		}

		// Token: 0x06005914 RID: 22804 RVA: 0x000801F9 File Offset: 0x0007E3F9
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathVectorSub.StaticStruct();
		}

		// Token: 0x06005915 RID: 22805 RVA: 0x00080205 File Offset: 0x0007E405
		[NullableContext(2)]
		public FRigUnit_MathVectorSub(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005916 RID: 22806 RVA: 0x0008020F File Offset: 0x0007E40F
		public FRigUnit_MathVectorSub(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005917 RID: 22807 RVA: 0x0008021A File Offset: 0x0007E41A
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathVectorSub(Pointer, false, true);
		}

		// Token: 0x06005918 RID: 22808 RVA: 0x00080224 File Offset: 0x0007E424
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathVectorSub(Pointer, MemoryOwner);
		}

		// Token: 0x040029C8 RID: 10696
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathVectorSub";

		// Token: 0x040029C9 RID: 10697
		private static IntPtr _ScriptStructPtr;
	}
}
