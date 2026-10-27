using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000663 RID: 1635
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathVectorAbs")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FRigUnit_MathVectorAbs : FRigUnit_MathVectorUnaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600572A RID: 22314 RVA: 0x0007E0EE File Offset: 0x0007C2EE
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathVectorAbs._ScriptStructPtr != 0) ? FRigUnit_MathVectorAbs._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathVectorAbs", ref FRigUnit_MathVectorAbs._ScriptStructPtr);
		}

		// Token: 0x0600572B RID: 22315 RVA: 0x0007E112 File Offset: 0x0007C312
		public FRigUnit_MathVectorAbs()
		{
		}

		// Token: 0x0600572C RID: 22316 RVA: 0x0007E11A File Offset: 0x0007C31A
		public FRigUnit_MathVectorAbs(FVector Value, FVector Result)
		{
			base.Value = Value;
			base.Result = Result;
		}

		// Token: 0x0600572D RID: 22317 RVA: 0x0007E130 File Offset: 0x0007C330
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathVectorAbs.StaticStruct();
		}

		// Token: 0x0600572E RID: 22318 RVA: 0x0007E13C File Offset: 0x0007C33C
		[NullableContext(2)]
		public FRigUnit_MathVectorAbs(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600572F RID: 22319 RVA: 0x0007E146 File Offset: 0x0007C346
		public FRigUnit_MathVectorAbs(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005730 RID: 22320 RVA: 0x0007E151 File Offset: 0x0007C351
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathVectorAbs(Pointer, false, true);
		}

		// Token: 0x06005731 RID: 22321 RVA: 0x0007E15B File Offset: 0x0007C35B
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathVectorAbs(Pointer, MemoryOwner);
		}

		// Token: 0x04002922 RID: 10530
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathVectorAbs";

		// Token: 0x04002923 RID: 10531
		private static IntPtr _ScriptStructPtr;
	}
}
