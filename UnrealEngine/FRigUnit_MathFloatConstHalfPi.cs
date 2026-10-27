using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005F5 RID: 1525
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatConstHalfPi")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_MathFloatConstHalfPi : FRigUnit_MathFloatConstant, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005200 RID: 20992 RVA: 0x00078653 File Offset: 0x00076853
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatConstHalfPi._ScriptStructPtr != 0) ? FRigUnit_MathFloatConstHalfPi._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatConstHalfPi", ref FRigUnit_MathFloatConstHalfPi._ScriptStructPtr);
		}

		// Token: 0x06005201 RID: 20993 RVA: 0x00078677 File Offset: 0x00076877
		public FRigUnit_MathFloatConstHalfPi()
		{
		}

		// Token: 0x06005202 RID: 20994 RVA: 0x0007867F File Offset: 0x0007687F
		public FRigUnit_MathFloatConstHalfPi(float Value)
		{
			base.Value = Value;
		}

		// Token: 0x06005203 RID: 20995 RVA: 0x0007868E File Offset: 0x0007688E
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatConstHalfPi.StaticStruct();
		}

		// Token: 0x06005204 RID: 20996 RVA: 0x0007869A File Offset: 0x0007689A
		[NullableContext(2)]
		public FRigUnit_MathFloatConstHalfPi(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005205 RID: 20997 RVA: 0x000786A4 File Offset: 0x000768A4
		public FRigUnit_MathFloatConstHalfPi(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005206 RID: 20998 RVA: 0x000786AF File Offset: 0x000768AF
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatConstHalfPi(Pointer, false, true);
		}

		// Token: 0x06005207 RID: 20999 RVA: 0x000786B9 File Offset: 0x000768B9
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatConstHalfPi(Pointer, MemoryOwner);
		}

		// Token: 0x04002757 RID: 10071
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatConstHalfPi";

		// Token: 0x04002758 RID: 10072
		private static IntPtr _ScriptStructPtr;
	}
}
