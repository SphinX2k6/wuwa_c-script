using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005EF RID: 1519
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatAtan")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_MathFloatAtan : FRigUnit_MathFloatUnaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060051BB RID: 20923 RVA: 0x00078224 File Offset: 0x00076424
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatAtan._ScriptStructPtr != 0) ? FRigUnit_MathFloatAtan._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatAtan", ref FRigUnit_MathFloatAtan._ScriptStructPtr);
		}

		// Token: 0x060051BC RID: 20924 RVA: 0x00078248 File Offset: 0x00076448
		public FRigUnit_MathFloatAtan()
		{
		}

		// Token: 0x060051BD RID: 20925 RVA: 0x00078250 File Offset: 0x00076450
		public FRigUnit_MathFloatAtan(float Value, float Result)
		{
			base.Value = Value;
			base.Result = Result;
		}

		// Token: 0x060051BE RID: 20926 RVA: 0x00078266 File Offset: 0x00076466
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatAtan.StaticStruct();
		}

		// Token: 0x060051BF RID: 20927 RVA: 0x00078272 File Offset: 0x00076472
		[NullableContext(2)]
		public FRigUnit_MathFloatAtan(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060051C0 RID: 20928 RVA: 0x0007827C File Offset: 0x0007647C
		public FRigUnit_MathFloatAtan(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060051C1 RID: 20929 RVA: 0x00078287 File Offset: 0x00076487
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatAtan(Pointer, false, true);
		}

		// Token: 0x060051C2 RID: 20930 RVA: 0x00078291 File Offset: 0x00076491
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatAtan(Pointer, MemoryOwner);
		}

		// Token: 0x04002740 RID: 10048
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatAtan";

		// Token: 0x04002741 RID: 10049
		private static IntPtr _ScriptStructPtr;
	}
}
