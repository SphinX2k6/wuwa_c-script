using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000627 RID: 1575
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathIntNegate")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_MathIntNegate : FRigUnit_MathIntUnaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005439 RID: 21561 RVA: 0x0007A9BE File Offset: 0x00078BBE
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathIntNegate._ScriptStructPtr != 0) ? FRigUnit_MathIntNegate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathIntNegate", ref FRigUnit_MathIntNegate._ScriptStructPtr);
		}

		// Token: 0x0600543A RID: 21562 RVA: 0x0007A9E2 File Offset: 0x00078BE2
		public FRigUnit_MathIntNegate()
		{
		}

		// Token: 0x0600543B RID: 21563 RVA: 0x0007A9EA File Offset: 0x00078BEA
		public FRigUnit_MathIntNegate(int Value, int Result)
		{
			base.Value = Value;
			base.Result = Result;
		}

		// Token: 0x0600543C RID: 21564 RVA: 0x0007AA00 File Offset: 0x00078C00
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathIntNegate.StaticStruct();
		}

		// Token: 0x0600543D RID: 21565 RVA: 0x0007AA0C File Offset: 0x00078C0C
		[NullableContext(2)]
		public FRigUnit_MathIntNegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600543E RID: 21566 RVA: 0x0007AA16 File Offset: 0x00078C16
		public FRigUnit_MathIntNegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600543F RID: 21567 RVA: 0x0007AA21 File Offset: 0x00078C21
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathIntNegate(Pointer, false, true);
		}

		// Token: 0x06005440 RID: 21568 RVA: 0x0007AA2B File Offset: 0x00078C2B
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathIntNegate(Pointer, MemoryOwner);
		}

		// Token: 0x04002810 RID: 10256
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathIntNegate";

		// Token: 0x04002811 RID: 10257
		private static IntPtr _ScriptStructPtr;
	}
}
