using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000644 RID: 1604
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathQuaternionUnit")]
	[UnrealStructLayout(48, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_MathQuaternionUnit : FRigUnit_MathQuaternionUnaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600559A RID: 21914 RVA: 0x0007C0CA File Offset: 0x0007A2CA
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathQuaternionUnit._ScriptStructPtr != 0) ? FRigUnit_MathQuaternionUnit._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathQuaternionUnit", ref FRigUnit_MathQuaternionUnit._ScriptStructPtr);
		}

		// Token: 0x0600559B RID: 21915 RVA: 0x0007C0EE File Offset: 0x0007A2EE
		public FRigUnit_MathQuaternionUnit()
		{
		}

		// Token: 0x0600559C RID: 21916 RVA: 0x0007C0F6 File Offset: 0x0007A2F6
		public FRigUnit_MathQuaternionUnit(FQuat Value, FQuat Result)
		{
			base.Value = Value;
			base.Result = Result;
		}

		// Token: 0x0600559D RID: 21917 RVA: 0x0007C10C File Offset: 0x0007A30C
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathQuaternionUnit.StaticStruct();
		}

		// Token: 0x0600559E RID: 21918 RVA: 0x0007C118 File Offset: 0x0007A318
		[NullableContext(2)]
		public FRigUnit_MathQuaternionUnit(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600559F RID: 21919 RVA: 0x0007C122 File Offset: 0x0007A322
		public FRigUnit_MathQuaternionUnit(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060055A0 RID: 21920 RVA: 0x0007C12D File Offset: 0x0007A32D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathQuaternionUnit(Pointer, false, true);
		}

		// Token: 0x060055A1 RID: 21921 RVA: 0x0007C137 File Offset: 0x0007A337
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathQuaternionUnit(Pointer, MemoryOwner);
		}

		// Token: 0x04002887 RID: 10375
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathQuaternionUnit";

		// Token: 0x04002888 RID: 10376
		private static IntPtr _ScriptStructPtr;
	}
}
