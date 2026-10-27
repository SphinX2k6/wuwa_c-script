using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200062B RID: 1579
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathIntSub")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_MathIntSub : FRigUnit_MathIntBinaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600545F RID: 21599 RVA: 0x0007AC07 File Offset: 0x00078E07
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathIntSub._ScriptStructPtr != 0) ? FRigUnit_MathIntSub._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathIntSub", ref FRigUnit_MathIntSub._ScriptStructPtr);
		}

		// Token: 0x06005460 RID: 21600 RVA: 0x0007AC2B File Offset: 0x00078E2B
		public FRigUnit_MathIntSub()
		{
		}

		// Token: 0x06005461 RID: 21601 RVA: 0x0007AC33 File Offset: 0x00078E33
		public FRigUnit_MathIntSub(int A, int B, int Result)
		{
			base.A = A;
			base.B = B;
			base.Result = Result;
		}

		// Token: 0x06005462 RID: 21602 RVA: 0x0007AC50 File Offset: 0x00078E50
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathIntSub.StaticStruct();
		}

		// Token: 0x06005463 RID: 21603 RVA: 0x0007AC5C File Offset: 0x00078E5C
		[NullableContext(2)]
		public FRigUnit_MathIntSub(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005464 RID: 21604 RVA: 0x0007AC66 File Offset: 0x00078E66
		public FRigUnit_MathIntSub(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005465 RID: 21605 RVA: 0x0007AC71 File Offset: 0x00078E71
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathIntSub(Pointer, false, true);
		}

		// Token: 0x06005466 RID: 21606 RVA: 0x0007AC7B File Offset: 0x00078E7B
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathIntSub(Pointer, MemoryOwner);
		}

		// Token: 0x0400281B RID: 10267
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathIntSub";

		// Token: 0x0400281C RID: 10268
		private static IntPtr _ScriptStructPtr;
	}
}
