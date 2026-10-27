using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000664 RID: 1636
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathVectorAdd")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_MathVectorAdd : FRigUnit_MathVectorBinaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005732 RID: 22322 RVA: 0x0007E164 File Offset: 0x0007C364
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathVectorAdd._ScriptStructPtr != 0) ? FRigUnit_MathVectorAdd._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathVectorAdd", ref FRigUnit_MathVectorAdd._ScriptStructPtr);
		}

		// Token: 0x06005733 RID: 22323 RVA: 0x0007E188 File Offset: 0x0007C388
		public FRigUnit_MathVectorAdd()
		{
		}

		// Token: 0x06005734 RID: 22324 RVA: 0x0007E190 File Offset: 0x0007C390
		public FRigUnit_MathVectorAdd(FVector A, FVector B, FVector Result)
		{
			base.A = A;
			base.B = B;
			base.Result = Result;
		}

		// Token: 0x06005735 RID: 22325 RVA: 0x0007E1AD File Offset: 0x0007C3AD
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathVectorAdd.StaticStruct();
		}

		// Token: 0x06005736 RID: 22326 RVA: 0x0007E1B9 File Offset: 0x0007C3B9
		[NullableContext(2)]
		public FRigUnit_MathVectorAdd(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005737 RID: 22327 RVA: 0x0007E1C3 File Offset: 0x0007C3C3
		public FRigUnit_MathVectorAdd(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005738 RID: 22328 RVA: 0x0007E1CE File Offset: 0x0007C3CE
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathVectorAdd(Pointer, false, true);
		}

		// Token: 0x06005739 RID: 22329 RVA: 0x0007E1D8 File Offset: 0x0007C3D8
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathVectorAdd(Pointer, MemoryOwner);
		}

		// Token: 0x04002924 RID: 10532
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathVectorAdd";

		// Token: 0x04002925 RID: 10533
		private static IntPtr _ScriptStructPtr;
	}
}
