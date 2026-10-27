using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000626 RID: 1574
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathIntMul")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_MathIntMul : FRigUnit_MathIntBinaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005431 RID: 21553 RVA: 0x0007A941 File Offset: 0x00078B41
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathIntMul._ScriptStructPtr != 0) ? FRigUnit_MathIntMul._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathIntMul", ref FRigUnit_MathIntMul._ScriptStructPtr);
		}

		// Token: 0x06005432 RID: 21554 RVA: 0x0007A965 File Offset: 0x00078B65
		public FRigUnit_MathIntMul()
		{
		}

		// Token: 0x06005433 RID: 21555 RVA: 0x0007A96D File Offset: 0x00078B6D
		public FRigUnit_MathIntMul(int A, int B, int Result)
		{
			base.A = A;
			base.B = B;
			base.Result = Result;
		}

		// Token: 0x06005434 RID: 21556 RVA: 0x0007A98A File Offset: 0x00078B8A
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathIntMul.StaticStruct();
		}

		// Token: 0x06005435 RID: 21557 RVA: 0x0007A996 File Offset: 0x00078B96
		[NullableContext(2)]
		public FRigUnit_MathIntMul(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005436 RID: 21558 RVA: 0x0007A9A0 File Offset: 0x00078BA0
		public FRigUnit_MathIntMul(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005437 RID: 21559 RVA: 0x0007A9AB File Offset: 0x00078BAB
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathIntMul(Pointer, false, true);
		}

		// Token: 0x06005438 RID: 21560 RVA: 0x0007A9B5 File Offset: 0x00078BB5
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathIntMul(Pointer, MemoryOwner);
		}

		// Token: 0x0400280E RID: 10254
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathIntMul";

		// Token: 0x0400280F RID: 10255
		private static IntPtr _ScriptStructPtr;
	}
}
