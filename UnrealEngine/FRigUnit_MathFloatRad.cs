using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200060C RID: 1548
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatRad")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_MathFloatRad : FRigUnit_MathFloatUnaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005306 RID: 21254 RVA: 0x00079686 File Offset: 0x00077886
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatRad._ScriptStructPtr != 0) ? FRigUnit_MathFloatRad._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatRad", ref FRigUnit_MathFloatRad._ScriptStructPtr);
		}

		// Token: 0x06005307 RID: 21255 RVA: 0x000796AA File Offset: 0x000778AA
		public FRigUnit_MathFloatRad()
		{
		}

		// Token: 0x06005308 RID: 21256 RVA: 0x000796B2 File Offset: 0x000778B2
		public FRigUnit_MathFloatRad(float Value, float Result)
		{
			base.Value = Value;
			base.Result = Result;
		}

		// Token: 0x06005309 RID: 21257 RVA: 0x000796C8 File Offset: 0x000778C8
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatRad.StaticStruct();
		}

		// Token: 0x0600530A RID: 21258 RVA: 0x000796D4 File Offset: 0x000778D4
		[NullableContext(2)]
		public FRigUnit_MathFloatRad(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600530B RID: 21259 RVA: 0x000796DE File Offset: 0x000778DE
		public FRigUnit_MathFloatRad(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600530C RID: 21260 RVA: 0x000796E9 File Offset: 0x000778E9
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatRad(Pointer, false, true);
		}

		// Token: 0x0600530D RID: 21261 RVA: 0x000796F3 File Offset: 0x000778F3
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatRad(Pointer, MemoryOwner);
		}

		// Token: 0x040027AC RID: 10156
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatRad";

		// Token: 0x040027AD RID: 10157
		private static IntPtr _ScriptStructPtr;
	}
}
