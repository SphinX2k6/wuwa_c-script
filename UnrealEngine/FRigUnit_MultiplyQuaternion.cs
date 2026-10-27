using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000697 RID: 1687
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MultiplyQuaternion")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FRigUnit_MultiplyQuaternion : FRigUnit_BinaryQuaternionOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060059A6 RID: 22950 RVA: 0x00080D25 File Offset: 0x0007EF25
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MultiplyQuaternion._ScriptStructPtr != 0) ? FRigUnit_MultiplyQuaternion._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MultiplyQuaternion", ref FRigUnit_MultiplyQuaternion._ScriptStructPtr);
		}

		// Token: 0x060059A7 RID: 22951 RVA: 0x00080D49 File Offset: 0x0007EF49
		public FRigUnit_MultiplyQuaternion()
		{
		}

		// Token: 0x060059A8 RID: 22952 RVA: 0x00080D51 File Offset: 0x0007EF51
		public FRigUnit_MultiplyQuaternion(FQuat Argument0, FQuat Argument1, FQuat Result)
		{
			base.Argument0 = Argument0;
			base.Argument1 = Argument1;
			base.Result = Result;
		}

		// Token: 0x060059A9 RID: 22953 RVA: 0x00080D6E File Offset: 0x0007EF6E
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MultiplyQuaternion.StaticStruct();
		}

		// Token: 0x060059AA RID: 22954 RVA: 0x00080D7A File Offset: 0x0007EF7A
		[NullableContext(2)]
		public FRigUnit_MultiplyQuaternion(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060059AB RID: 22955 RVA: 0x00080D84 File Offset: 0x0007EF84
		public FRigUnit_MultiplyQuaternion(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060059AC RID: 22956 RVA: 0x00080D8F File Offset: 0x0007EF8F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MultiplyQuaternion(Pointer, false, true);
		}

		// Token: 0x060059AD RID: 22957 RVA: 0x00080D99 File Offset: 0x0007EF99
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MultiplyQuaternion(Pointer, MemoryOwner);
		}

		// Token: 0x04002A03 RID: 10755
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MultiplyQuaternion";

		// Token: 0x04002A04 RID: 10756
		private static IntPtr _ScriptStructPtr;
	}
}
