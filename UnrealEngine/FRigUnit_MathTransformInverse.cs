using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000659 RID: 1625
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathTransformInverse")]
	[UnrealStructLayout(112, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FRigUnit_MathTransformInverse : FRigUnit_MathTransformUnaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060056AA RID: 22186 RVA: 0x0007D80D File Offset: 0x0007BA0D
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathTransformInverse._ScriptStructPtr != 0) ? FRigUnit_MathTransformInverse._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathTransformInverse", ref FRigUnit_MathTransformInverse._ScriptStructPtr);
		}

		// Token: 0x060056AB RID: 22187 RVA: 0x0007D831 File Offset: 0x0007BA31
		public FRigUnit_MathTransformInverse()
		{
		}

		// Token: 0x060056AC RID: 22188 RVA: 0x0007D839 File Offset: 0x0007BA39
		public FRigUnit_MathTransformInverse(FTransform Value, FTransform Result)
		{
			base.Value = Value;
			base.Result = Result;
		}

		// Token: 0x060056AD RID: 22189 RVA: 0x0007D84F File Offset: 0x0007BA4F
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathTransformInverse.StaticStruct();
		}

		// Token: 0x060056AE RID: 22190 RVA: 0x0007D85B File Offset: 0x0007BA5B
		[NullableContext(2)]
		public FRigUnit_MathTransformInverse(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060056AF RID: 22191 RVA: 0x0007D865 File Offset: 0x0007BA65
		public FRigUnit_MathTransformInverse(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060056B0 RID: 22192 RVA: 0x0007D870 File Offset: 0x0007BA70
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathTransformInverse(Pointer, false, true);
		}

		// Token: 0x060056B1 RID: 22193 RVA: 0x0007D87A File Offset: 0x0007BA7A
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathTransformInverse(Pointer, MemoryOwner);
		}

		// Token: 0x040028F5 RID: 10485
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathTransformInverse";

		// Token: 0x040028F6 RID: 10486
		private static IntPtr _ScriptStructPtr;
	}
}
