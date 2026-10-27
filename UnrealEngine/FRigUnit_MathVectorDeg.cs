using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200066E RID: 1646
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathVectorDeg")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FRigUnit_MathVectorDeg : FRigUnit_MathVectorUnaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060057B9 RID: 22457 RVA: 0x0007EAF9 File Offset: 0x0007CCF9
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathVectorDeg._ScriptStructPtr != 0) ? FRigUnit_MathVectorDeg._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathVectorDeg", ref FRigUnit_MathVectorDeg._ScriptStructPtr);
		}

		// Token: 0x060057BA RID: 22458 RVA: 0x0007EB1D File Offset: 0x0007CD1D
		public FRigUnit_MathVectorDeg()
		{
		}

		// Token: 0x060057BB RID: 22459 RVA: 0x0007EB25 File Offset: 0x0007CD25
		public FRigUnit_MathVectorDeg(FVector Value, FVector Result)
		{
			base.Value = Value;
			base.Result = Result;
		}

		// Token: 0x060057BC RID: 22460 RVA: 0x0007EB3B File Offset: 0x0007CD3B
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathVectorDeg.StaticStruct();
		}

		// Token: 0x060057BD RID: 22461 RVA: 0x0007EB47 File Offset: 0x0007CD47
		[NullableContext(2)]
		public FRigUnit_MathVectorDeg(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060057BE RID: 22462 RVA: 0x0007EB51 File Offset: 0x0007CD51
		public FRigUnit_MathVectorDeg(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060057BF RID: 22463 RVA: 0x0007EB5C File Offset: 0x0007CD5C
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathVectorDeg(Pointer, false, true);
		}

		// Token: 0x060057C0 RID: 22464 RVA: 0x0007EB66 File Offset: 0x0007CD66
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathVectorDeg(Pointer, MemoryOwner);
		}

		// Token: 0x04002955 RID: 10581
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathVectorDeg";

		// Token: 0x04002956 RID: 10582
		private static IntPtr _ScriptStructPtr;
	}
}
