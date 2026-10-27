using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200067B RID: 1659
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathVectorMax")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_MathVectorMax : FRigUnit_MathVectorBinaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005857 RID: 22615 RVA: 0x0007F567 File Offset: 0x0007D767
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathVectorMax._ScriptStructPtr != 0) ? FRigUnit_MathVectorMax._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathVectorMax", ref FRigUnit_MathVectorMax._ScriptStructPtr);
		}

		// Token: 0x06005858 RID: 22616 RVA: 0x0007F58B File Offset: 0x0007D78B
		public FRigUnit_MathVectorMax()
		{
		}

		// Token: 0x06005859 RID: 22617 RVA: 0x0007F593 File Offset: 0x0007D793
		public FRigUnit_MathVectorMax(FVector A, FVector B, FVector Result)
		{
			base.A = A;
			base.B = B;
			base.Result = Result;
		}

		// Token: 0x0600585A RID: 22618 RVA: 0x0007F5B0 File Offset: 0x0007D7B0
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathVectorMax.StaticStruct();
		}

		// Token: 0x0600585B RID: 22619 RVA: 0x0007F5BC File Offset: 0x0007D7BC
		[NullableContext(2)]
		public FRigUnit_MathVectorMax(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600585C RID: 22620 RVA: 0x0007F5C6 File Offset: 0x0007D7C6
		public FRigUnit_MathVectorMax(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600585D RID: 22621 RVA: 0x0007F5D1 File Offset: 0x0007D7D1
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathVectorMax(Pointer, false, true);
		}

		// Token: 0x0600585E RID: 22622 RVA: 0x0007F5DB File Offset: 0x0007D7DB
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathVectorMax(Pointer, MemoryOwner);
		}

		// Token: 0x0400298B RID: 10635
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathVectorMax";

		// Token: 0x0400298C RID: 10636
		private static IntPtr _ScriptStructPtr;
	}
}
