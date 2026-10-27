using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000608 RID: 1544
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatMul")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_MathFloatMul : FRigUnit_MathFloatBinaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060052E0 RID: 21216 RVA: 0x00079436 File Offset: 0x00077636
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatMul._ScriptStructPtr != 0) ? FRigUnit_MathFloatMul._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatMul", ref FRigUnit_MathFloatMul._ScriptStructPtr);
		}

		// Token: 0x060052E1 RID: 21217 RVA: 0x0007945A File Offset: 0x0007765A
		public FRigUnit_MathFloatMul()
		{
		}

		// Token: 0x060052E2 RID: 21218 RVA: 0x00079462 File Offset: 0x00077662
		public FRigUnit_MathFloatMul(float A, float B, float Result)
		{
			base.A = A;
			base.B = B;
			base.Result = Result;
		}

		// Token: 0x060052E3 RID: 21219 RVA: 0x0007947F File Offset: 0x0007767F
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatMul.StaticStruct();
		}

		// Token: 0x060052E4 RID: 21220 RVA: 0x0007948B File Offset: 0x0007768B
		[NullableContext(2)]
		public FRigUnit_MathFloatMul(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060052E5 RID: 21221 RVA: 0x00079495 File Offset: 0x00077695
		public FRigUnit_MathFloatMul(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060052E6 RID: 21222 RVA: 0x000794A0 File Offset: 0x000776A0
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatMul(Pointer, false, true);
		}

		// Token: 0x060052E7 RID: 21223 RVA: 0x000794AA File Offset: 0x000776AA
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatMul(Pointer, MemoryOwner);
		}

		// Token: 0x040027A1 RID: 10145
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatMul";

		// Token: 0x040027A2 RID: 10146
		private static IntPtr _ScriptStructPtr;
	}
}
