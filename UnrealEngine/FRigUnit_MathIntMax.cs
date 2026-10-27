using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000623 RID: 1571
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathIntMax")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_MathIntMax : FRigUnit_MathIntBinaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005419 RID: 21529 RVA: 0x0007A7CA File Offset: 0x000789CA
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathIntMax._ScriptStructPtr != 0) ? FRigUnit_MathIntMax._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathIntMax", ref FRigUnit_MathIntMax._ScriptStructPtr);
		}

		// Token: 0x0600541A RID: 21530 RVA: 0x0007A7EE File Offset: 0x000789EE
		public FRigUnit_MathIntMax()
		{
		}

		// Token: 0x0600541B RID: 21531 RVA: 0x0007A7F6 File Offset: 0x000789F6
		public FRigUnit_MathIntMax(int A, int B, int Result)
		{
			base.A = A;
			base.B = B;
			base.Result = Result;
		}

		// Token: 0x0600541C RID: 21532 RVA: 0x0007A813 File Offset: 0x00078A13
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathIntMax.StaticStruct();
		}

		// Token: 0x0600541D RID: 21533 RVA: 0x0007A81F File Offset: 0x00078A1F
		[NullableContext(2)]
		public FRigUnit_MathIntMax(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600541E RID: 21534 RVA: 0x0007A829 File Offset: 0x00078A29
		public FRigUnit_MathIntMax(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600541F RID: 21535 RVA: 0x0007A834 File Offset: 0x00078A34
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathIntMax(Pointer, false, true);
		}

		// Token: 0x06005420 RID: 21536 RVA: 0x0007A83E File Offset: 0x00078A3E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathIntMax(Pointer, MemoryOwner);
		}

		// Token: 0x04002808 RID: 10248
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathIntMax";

		// Token: 0x04002809 RID: 10249
		private static IntPtr _ScriptStructPtr;
	}
}
