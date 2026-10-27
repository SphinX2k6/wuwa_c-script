using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005D8 RID: 1496
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathBoolAnd")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_MathBoolAnd : FRigUnit_MathBoolBinaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060050DB RID: 20699 RVA: 0x00077482 File Offset: 0x00075682
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathBoolAnd._ScriptStructPtr != 0) ? FRigUnit_MathBoolAnd._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathBoolAnd", ref FRigUnit_MathBoolAnd._ScriptStructPtr);
		}

		// Token: 0x060050DC RID: 20700 RVA: 0x000774A6 File Offset: 0x000756A6
		public FRigUnit_MathBoolAnd()
		{
		}

		// Token: 0x060050DD RID: 20701 RVA: 0x000774AE File Offset: 0x000756AE
		public FRigUnit_MathBoolAnd(bool A, bool B, bool Result)
		{
			base.A = A;
			base.B = B;
			base.Result = Result;
		}

		// Token: 0x060050DE RID: 20702 RVA: 0x000774CB File Offset: 0x000756CB
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathBoolAnd.StaticStruct();
		}

		// Token: 0x060050DF RID: 20703 RVA: 0x000774D7 File Offset: 0x000756D7
		[NullableContext(2)]
		public FRigUnit_MathBoolAnd(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060050E0 RID: 20704 RVA: 0x000774E1 File Offset: 0x000756E1
		public FRigUnit_MathBoolAnd(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060050E1 RID: 20705 RVA: 0x000774EC File Offset: 0x000756EC
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathBoolAnd(Pointer, false, true);
		}

		// Token: 0x060050E2 RID: 20706 RVA: 0x000774F6 File Offset: 0x000756F6
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathBoolAnd(Pointer, MemoryOwner);
		}

		// Token: 0x040026FD RID: 9981
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathBoolAnd";

		// Token: 0x040026FE RID: 9982
		private static IntPtr _ScriptStructPtr;
	}
}
