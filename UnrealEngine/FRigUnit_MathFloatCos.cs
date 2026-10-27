using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005F8 RID: 1528
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatCos")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_MathFloatCos : FRigUnit_MathFloatUnaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005218 RID: 21016 RVA: 0x000787A0 File Offset: 0x000769A0
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatCos._ScriptStructPtr != 0) ? FRigUnit_MathFloatCos._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatCos", ref FRigUnit_MathFloatCos._ScriptStructPtr);
		}

		// Token: 0x06005219 RID: 21017 RVA: 0x000787C4 File Offset: 0x000769C4
		public FRigUnit_MathFloatCos()
		{
		}

		// Token: 0x0600521A RID: 21018 RVA: 0x000787CC File Offset: 0x000769CC
		public FRigUnit_MathFloatCos(float Value, float Result)
		{
			base.Value = Value;
			base.Result = Result;
		}

		// Token: 0x0600521B RID: 21019 RVA: 0x000787E2 File Offset: 0x000769E2
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatCos.StaticStruct();
		}

		// Token: 0x0600521C RID: 21020 RVA: 0x000787EE File Offset: 0x000769EE
		[NullableContext(2)]
		public FRigUnit_MathFloatCos(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600521D RID: 21021 RVA: 0x000787F8 File Offset: 0x000769F8
		public FRigUnit_MathFloatCos(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600521E RID: 21022 RVA: 0x00078803 File Offset: 0x00076A03
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatCos(Pointer, false, true);
		}

		// Token: 0x0600521F RID: 21023 RVA: 0x0007880D File Offset: 0x00076A0D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatCos(Pointer, MemoryOwner);
		}

		// Token: 0x0400275D RID: 10077
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatCos";

		// Token: 0x0400275E RID: 10078
		private static IntPtr _ScriptStructPtr;
	}
}
