using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200062A RID: 1578
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathIntSign")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_MathIntSign : FRigUnit_MathIntUnaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005457 RID: 21591 RVA: 0x0007AB91 File Offset: 0x00078D91
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathIntSign._ScriptStructPtr != 0) ? FRigUnit_MathIntSign._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathIntSign", ref FRigUnit_MathIntSign._ScriptStructPtr);
		}

		// Token: 0x06005458 RID: 21592 RVA: 0x0007ABB5 File Offset: 0x00078DB5
		public FRigUnit_MathIntSign()
		{
		}

		// Token: 0x06005459 RID: 21593 RVA: 0x0007ABBD File Offset: 0x00078DBD
		public FRigUnit_MathIntSign(int Value, int Result)
		{
			base.Value = Value;
			base.Result = Result;
		}

		// Token: 0x0600545A RID: 21594 RVA: 0x0007ABD3 File Offset: 0x00078DD3
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathIntSign.StaticStruct();
		}

		// Token: 0x0600545B RID: 21595 RVA: 0x0007ABDF File Offset: 0x00078DDF
		[NullableContext(2)]
		public FRigUnit_MathIntSign(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600545C RID: 21596 RVA: 0x0007ABE9 File Offset: 0x00078DE9
		public FRigUnit_MathIntSign(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600545D RID: 21597 RVA: 0x0007ABF4 File Offset: 0x00078DF4
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathIntSign(Pointer, false, true);
		}

		// Token: 0x0600545E RID: 21598 RVA: 0x0007ABFE File Offset: 0x00078DFE
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathIntSign(Pointer, MemoryOwner);
		}

		// Token: 0x04002819 RID: 10265
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathIntSign";

		// Token: 0x0400281A RID: 10266
		private static IntPtr _ScriptStructPtr;
	}
}
