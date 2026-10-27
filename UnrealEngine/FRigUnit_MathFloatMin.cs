using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000606 RID: 1542
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatMin")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_MathFloatMin : FRigUnit_MathFloatBinaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060052D0 RID: 21200 RVA: 0x0007933C File Offset: 0x0007753C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatMin._ScriptStructPtr != 0) ? FRigUnit_MathFloatMin._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatMin", ref FRigUnit_MathFloatMin._ScriptStructPtr);
		}

		// Token: 0x060052D1 RID: 21201 RVA: 0x00079360 File Offset: 0x00077560
		public FRigUnit_MathFloatMin()
		{
		}

		// Token: 0x060052D2 RID: 21202 RVA: 0x00079368 File Offset: 0x00077568
		public FRigUnit_MathFloatMin(float A, float B, float Result)
		{
			base.A = A;
			base.B = B;
			base.Result = Result;
		}

		// Token: 0x060052D3 RID: 21203 RVA: 0x00079385 File Offset: 0x00077585
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatMin.StaticStruct();
		}

		// Token: 0x060052D4 RID: 21204 RVA: 0x00079391 File Offset: 0x00077591
		[NullableContext(2)]
		public FRigUnit_MathFloatMin(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060052D5 RID: 21205 RVA: 0x0007939B File Offset: 0x0007759B
		public FRigUnit_MathFloatMin(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060052D6 RID: 21206 RVA: 0x000793A6 File Offset: 0x000775A6
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatMin(Pointer, false, true);
		}

		// Token: 0x060052D7 RID: 21207 RVA: 0x000793B0 File Offset: 0x000775B0
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatMin(Pointer, MemoryOwner);
		}

		// Token: 0x0400279D RID: 10141
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatMin";

		// Token: 0x0400279E RID: 10142
		private static IntPtr _ScriptStructPtr;
	}
}
