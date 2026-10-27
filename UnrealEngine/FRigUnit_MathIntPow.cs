using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000629 RID: 1577
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathIntPow")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_MathIntPow : FRigUnit_MathIntBinaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600544F RID: 21583 RVA: 0x0007AB14 File Offset: 0x00078D14
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathIntPow._ScriptStructPtr != 0) ? FRigUnit_MathIntPow._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathIntPow", ref FRigUnit_MathIntPow._ScriptStructPtr);
		}

		// Token: 0x06005450 RID: 21584 RVA: 0x0007AB38 File Offset: 0x00078D38
		public FRigUnit_MathIntPow()
		{
		}

		// Token: 0x06005451 RID: 21585 RVA: 0x0007AB40 File Offset: 0x00078D40
		public FRigUnit_MathIntPow(int A, int B, int Result)
		{
			base.A = A;
			base.B = B;
			base.Result = Result;
		}

		// Token: 0x06005452 RID: 21586 RVA: 0x0007AB5D File Offset: 0x00078D5D
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathIntPow.StaticStruct();
		}

		// Token: 0x06005453 RID: 21587 RVA: 0x0007AB69 File Offset: 0x00078D69
		[NullableContext(2)]
		public FRigUnit_MathIntPow(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005454 RID: 21588 RVA: 0x0007AB73 File Offset: 0x00078D73
		public FRigUnit_MathIntPow(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005455 RID: 21589 RVA: 0x0007AB7E File Offset: 0x00078D7E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathIntPow(Pointer, false, true);
		}

		// Token: 0x06005456 RID: 21590 RVA: 0x0007AB88 File Offset: 0x00078D88
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathIntPow(Pointer, MemoryOwner);
		}

		// Token: 0x04002817 RID: 10263
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathIntPow";

		// Token: 0x04002818 RID: 10264
		private static IntPtr _ScriptStructPtr;
	}
}
