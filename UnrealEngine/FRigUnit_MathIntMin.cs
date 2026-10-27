using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000624 RID: 1572
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathIntMin")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_MathIntMin : FRigUnit_MathIntBinaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005421 RID: 21537 RVA: 0x0007A847 File Offset: 0x00078A47
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathIntMin._ScriptStructPtr != 0) ? FRigUnit_MathIntMin._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathIntMin", ref FRigUnit_MathIntMin._ScriptStructPtr);
		}

		// Token: 0x06005422 RID: 21538 RVA: 0x0007A86B File Offset: 0x00078A6B
		public FRigUnit_MathIntMin()
		{
		}

		// Token: 0x06005423 RID: 21539 RVA: 0x0007A873 File Offset: 0x00078A73
		public FRigUnit_MathIntMin(int A, int B, int Result)
		{
			base.A = A;
			base.B = B;
			base.Result = Result;
		}

		// Token: 0x06005424 RID: 21540 RVA: 0x0007A890 File Offset: 0x00078A90
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathIntMin.StaticStruct();
		}

		// Token: 0x06005425 RID: 21541 RVA: 0x0007A89C File Offset: 0x00078A9C
		[NullableContext(2)]
		public FRigUnit_MathIntMin(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005426 RID: 21542 RVA: 0x0007A8A6 File Offset: 0x00078AA6
		public FRigUnit_MathIntMin(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005427 RID: 21543 RVA: 0x0007A8B1 File Offset: 0x00078AB1
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathIntMin(Pointer, false, true);
		}

		// Token: 0x06005428 RID: 21544 RVA: 0x0007A8BB File Offset: 0x00078ABB
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathIntMin(Pointer, MemoryOwner);
		}

		// Token: 0x0400280A RID: 10250
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathIntMin";

		// Token: 0x0400280B RID: 10251
		private static IntPtr _ScriptStructPtr;
	}
}
