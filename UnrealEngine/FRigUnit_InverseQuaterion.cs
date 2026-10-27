using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005CB RID: 1483
	[UnrealObjectPath("/Script/ControlRig.RigUnit_InverseQuaterion")]
	[UnrealStructLayout(48, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_InverseQuaterion : FRigUnit_UnaryQuaternionOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005023 RID: 20515 RVA: 0x000765EB File Offset: 0x000747EB
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_InverseQuaterion._ScriptStructPtr != 0) ? FRigUnit_InverseQuaterion._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_InverseQuaterion", ref FRigUnit_InverseQuaterion._ScriptStructPtr);
		}

		// Token: 0x06005024 RID: 20516 RVA: 0x0007660F File Offset: 0x0007480F
		public FRigUnit_InverseQuaterion()
		{
		}

		// Token: 0x06005025 RID: 20517 RVA: 0x00076617 File Offset: 0x00074817
		public FRigUnit_InverseQuaterion(FQuat Argument, FQuat Result)
		{
			base.Argument = Argument;
			base.Result = Result;
		}

		// Token: 0x06005026 RID: 20518 RVA: 0x0007662D File Offset: 0x0007482D
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_InverseQuaterion.StaticStruct();
		}

		// Token: 0x06005027 RID: 20519 RVA: 0x00076639 File Offset: 0x00074839
		[NullableContext(2)]
		public FRigUnit_InverseQuaterion(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005028 RID: 20520 RVA: 0x00076643 File Offset: 0x00074843
		public FRigUnit_InverseQuaterion(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005029 RID: 20521 RVA: 0x0007664E File Offset: 0x0007484E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_InverseQuaterion(Pointer, false, true);
		}

		// Token: 0x0600502A RID: 20522 RVA: 0x00076658 File Offset: 0x00074858
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_InverseQuaterion(Pointer, MemoryOwner);
		}

		// Token: 0x040026B0 RID: 9904
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_InverseQuaterion";

		// Token: 0x040026B1 RID: 9905
		private static IntPtr _ScriptStructPtr;
	}
}
