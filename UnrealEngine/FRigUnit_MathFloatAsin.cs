using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005EE RID: 1518
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatAsin")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_MathFloatAsin : FRigUnit_MathFloatUnaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060051B3 RID: 20915 RVA: 0x000781AE File Offset: 0x000763AE
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatAsin._ScriptStructPtr != 0) ? FRigUnit_MathFloatAsin._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatAsin", ref FRigUnit_MathFloatAsin._ScriptStructPtr);
		}

		// Token: 0x060051B4 RID: 20916 RVA: 0x000781D2 File Offset: 0x000763D2
		public FRigUnit_MathFloatAsin()
		{
		}

		// Token: 0x060051B5 RID: 20917 RVA: 0x000781DA File Offset: 0x000763DA
		public FRigUnit_MathFloatAsin(float Value, float Result)
		{
			base.Value = Value;
			base.Result = Result;
		}

		// Token: 0x060051B6 RID: 20918 RVA: 0x000781F0 File Offset: 0x000763F0
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatAsin.StaticStruct();
		}

		// Token: 0x060051B7 RID: 20919 RVA: 0x000781FC File Offset: 0x000763FC
		[NullableContext(2)]
		public FRigUnit_MathFloatAsin(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060051B8 RID: 20920 RVA: 0x00078206 File Offset: 0x00076406
		public FRigUnit_MathFloatAsin(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060051B9 RID: 20921 RVA: 0x00078211 File Offset: 0x00076411
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatAsin(Pointer, false, true);
		}

		// Token: 0x060051BA RID: 20922 RVA: 0x0007821B File Offset: 0x0007641B
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatAsin(Pointer, MemoryOwner);
		}

		// Token: 0x0400273E RID: 10046
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatAsin";

		// Token: 0x0400273F RID: 10047
		private static IntPtr _ScriptStructPtr;
	}
}
