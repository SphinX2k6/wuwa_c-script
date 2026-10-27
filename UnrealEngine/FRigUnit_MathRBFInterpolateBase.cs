using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000645 RID: 1605
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathRBFInterpolateBase")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FRigUnit_MathRBFInterpolateBase : FRigUnit_MathBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060055A2 RID: 21922 RVA: 0x0007C140 File Offset: 0x0007A340
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathRBFInterpolateBase._ScriptStructPtr != 0) ? FRigUnit_MathRBFInterpolateBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathRBFInterpolateBase", ref FRigUnit_MathRBFInterpolateBase._ScriptStructPtr);
		}

		// Token: 0x060055A3 RID: 21923 RVA: 0x0007C164 File Offset: 0x0007A364
		public FRigUnit_MathRBFInterpolateBase()
		{
		}

		// Token: 0x060055A4 RID: 21924 RVA: 0x0007C16C File Offset: 0x0007A36C
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathRBFInterpolateBase.StaticStruct();
		}

		// Token: 0x060055A5 RID: 21925 RVA: 0x0007C178 File Offset: 0x0007A378
		[NullableContext(2)]
		public FRigUnit_MathRBFInterpolateBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060055A6 RID: 21926 RVA: 0x0007C182 File Offset: 0x0007A382
		public FRigUnit_MathRBFInterpolateBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060055A7 RID: 21927 RVA: 0x0007C18D File Offset: 0x0007A38D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathRBFInterpolateBase(Pointer, false, true);
		}

		// Token: 0x060055A8 RID: 21928 RVA: 0x0007C197 File Offset: 0x0007A397
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathRBFInterpolateBase(Pointer, MemoryOwner);
		}

		// Token: 0x04002889 RID: 10377
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathRBFInterpolateBase";

		// Token: 0x0400288A RID: 10378
		private static IntPtr _ScriptStructPtr;
	}
}
