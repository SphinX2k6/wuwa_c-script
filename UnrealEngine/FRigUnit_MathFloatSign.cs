using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000610 RID: 1552
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatSign")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_MathFloatSign : FRigUnit_MathFloatUnaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005342 RID: 21314 RVA: 0x00079A69 File Offset: 0x00077C69
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatSign._ScriptStructPtr != 0) ? FRigUnit_MathFloatSign._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatSign", ref FRigUnit_MathFloatSign._ScriptStructPtr);
		}

		// Token: 0x06005343 RID: 21315 RVA: 0x00079A8D File Offset: 0x00077C8D
		public FRigUnit_MathFloatSign()
		{
		}

		// Token: 0x06005344 RID: 21316 RVA: 0x00079A95 File Offset: 0x00077C95
		public FRigUnit_MathFloatSign(float Value, float Result)
		{
			base.Value = Value;
			base.Result = Result;
		}

		// Token: 0x06005345 RID: 21317 RVA: 0x00079AAB File Offset: 0x00077CAB
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatSign.StaticStruct();
		}

		// Token: 0x06005346 RID: 21318 RVA: 0x00079AB7 File Offset: 0x00077CB7
		[NullableContext(2)]
		public FRigUnit_MathFloatSign(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005347 RID: 21319 RVA: 0x00079AC1 File Offset: 0x00077CC1
		public FRigUnit_MathFloatSign(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005348 RID: 21320 RVA: 0x00079ACC File Offset: 0x00077CCC
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatSign(Pointer, false, true);
		}

		// Token: 0x06005349 RID: 21321 RVA: 0x00079AD6 File Offset: 0x00077CD6
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatSign(Pointer, MemoryOwner);
		}

		// Token: 0x040027C2 RID: 10178
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatSign";

		// Token: 0x040027C3 RID: 10179
		private static IntPtr _ScriptStructPtr;
	}
}
