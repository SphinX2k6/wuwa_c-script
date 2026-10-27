using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000605 RID: 1541
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatMax")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_MathFloatMax : FRigUnit_MathFloatBinaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060052C8 RID: 21192 RVA: 0x000792BF File Offset: 0x000774BF
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatMax._ScriptStructPtr != 0) ? FRigUnit_MathFloatMax._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatMax", ref FRigUnit_MathFloatMax._ScriptStructPtr);
		}

		// Token: 0x060052C9 RID: 21193 RVA: 0x000792E3 File Offset: 0x000774E3
		public FRigUnit_MathFloatMax()
		{
		}

		// Token: 0x060052CA RID: 21194 RVA: 0x000792EB File Offset: 0x000774EB
		public FRigUnit_MathFloatMax(float A, float B, float Result)
		{
			base.A = A;
			base.B = B;
			base.Result = Result;
		}

		// Token: 0x060052CB RID: 21195 RVA: 0x00079308 File Offset: 0x00077508
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatMax.StaticStruct();
		}

		// Token: 0x060052CC RID: 21196 RVA: 0x00079314 File Offset: 0x00077514
		[NullableContext(2)]
		public FRigUnit_MathFloatMax(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060052CD RID: 21197 RVA: 0x0007931E File Offset: 0x0007751E
		public FRigUnit_MathFloatMax(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060052CE RID: 21198 RVA: 0x00079329 File Offset: 0x00077529
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatMax(Pointer, false, true);
		}

		// Token: 0x060052CF RID: 21199 RVA: 0x00079333 File Offset: 0x00077533
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatMax(Pointer, MemoryOwner);
		}

		// Token: 0x0400279B RID: 10139
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatMax";

		// Token: 0x0400279C RID: 10140
		private static IntPtr _ScriptStructPtr;
	}
}
