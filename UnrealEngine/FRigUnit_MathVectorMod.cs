using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200067E RID: 1662
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathVectorMod")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_MathVectorMod : FRigUnit_MathVectorBinaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005875 RID: 22645 RVA: 0x0007F759 File Offset: 0x0007D959
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathVectorMod._ScriptStructPtr != 0) ? FRigUnit_MathVectorMod._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathVectorMod", ref FRigUnit_MathVectorMod._ScriptStructPtr);
		}

		// Token: 0x06005876 RID: 22646 RVA: 0x0007F77D File Offset: 0x0007D97D
		public FRigUnit_MathVectorMod()
		{
		}

		// Token: 0x06005877 RID: 22647 RVA: 0x0007F785 File Offset: 0x0007D985
		public FRigUnit_MathVectorMod(FVector A, FVector B, FVector Result)
		{
			base.A = A;
			base.B = B;
			base.Result = Result;
		}

		// Token: 0x06005878 RID: 22648 RVA: 0x0007F7A2 File Offset: 0x0007D9A2
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathVectorMod.StaticStruct();
		}

		// Token: 0x06005879 RID: 22649 RVA: 0x0007F7AE File Offset: 0x0007D9AE
		[NullableContext(2)]
		public FRigUnit_MathVectorMod(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600587A RID: 22650 RVA: 0x0007F7B8 File Offset: 0x0007D9B8
		public FRigUnit_MathVectorMod(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600587B RID: 22651 RVA: 0x0007F7C3 File Offset: 0x0007D9C3
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathVectorMod(Pointer, false, true);
		}

		// Token: 0x0600587C RID: 22652 RVA: 0x0007F7CD File Offset: 0x0007D9CD
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathVectorMod(Pointer, MemoryOwner);
		}

		// Token: 0x04002994 RID: 10644
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathVectorMod";

		// Token: 0x04002995 RID: 10645
		private static IntPtr _ScriptStructPtr;
	}
}
