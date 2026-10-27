using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000617 RID: 1559
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathIntAbs")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_MathIntAbs : FRigUnit_MathIntUnaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005382 RID: 21378 RVA: 0x00079E2E File Offset: 0x0007802E
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathIntAbs._ScriptStructPtr != 0) ? FRigUnit_MathIntAbs._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathIntAbs", ref FRigUnit_MathIntAbs._ScriptStructPtr);
		}

		// Token: 0x06005383 RID: 21379 RVA: 0x00079E52 File Offset: 0x00078052
		public FRigUnit_MathIntAbs()
		{
		}

		// Token: 0x06005384 RID: 21380 RVA: 0x00079E5A File Offset: 0x0007805A
		public FRigUnit_MathIntAbs(int Value, int Result)
		{
			base.Value = Value;
			base.Result = Result;
		}

		// Token: 0x06005385 RID: 21381 RVA: 0x00079E70 File Offset: 0x00078070
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathIntAbs.StaticStruct();
		}

		// Token: 0x06005386 RID: 21382 RVA: 0x00079E7C File Offset: 0x0007807C
		[NullableContext(2)]
		public FRigUnit_MathIntAbs(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005387 RID: 21383 RVA: 0x00079E86 File Offset: 0x00078086
		public FRigUnit_MathIntAbs(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005388 RID: 21384 RVA: 0x00079E91 File Offset: 0x00078091
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathIntAbs(Pointer, false, true);
		}

		// Token: 0x06005389 RID: 21385 RVA: 0x00079E9B File Offset: 0x0007809B
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathIntAbs(Pointer, MemoryOwner);
		}

		// Token: 0x040027D4 RID: 10196
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathIntAbs";

		// Token: 0x040027D5 RID: 10197
		private static IntPtr _ScriptStructPtr;
	}
}
