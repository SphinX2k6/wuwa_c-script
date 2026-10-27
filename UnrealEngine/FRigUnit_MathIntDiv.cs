using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200061C RID: 1564
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathIntDiv")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_MathIntDiv : FRigUnit_MathIntBinaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060053B7 RID: 21431 RVA: 0x0007A16A File Offset: 0x0007836A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathIntDiv._ScriptStructPtr != 0) ? FRigUnit_MathIntDiv._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathIntDiv", ref FRigUnit_MathIntDiv._ScriptStructPtr);
		}

		// Token: 0x060053B8 RID: 21432 RVA: 0x0007A18E File Offset: 0x0007838E
		public FRigUnit_MathIntDiv()
		{
		}

		// Token: 0x060053B9 RID: 21433 RVA: 0x0007A196 File Offset: 0x00078396
		public FRigUnit_MathIntDiv(int A, int B, int Result)
		{
			base.A = A;
			base.B = B;
			base.Result = Result;
		}

		// Token: 0x060053BA RID: 21434 RVA: 0x0007A1B3 File Offset: 0x000783B3
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathIntDiv.StaticStruct();
		}

		// Token: 0x060053BB RID: 21435 RVA: 0x0007A1BF File Offset: 0x000783BF
		[NullableContext(2)]
		public FRigUnit_MathIntDiv(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060053BC RID: 21436 RVA: 0x0007A1C9 File Offset: 0x000783C9
		public FRigUnit_MathIntDiv(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060053BD RID: 21437 RVA: 0x0007A1D4 File Offset: 0x000783D4
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathIntDiv(Pointer, false, true);
		}

		// Token: 0x060053BE RID: 21438 RVA: 0x0007A1DE File Offset: 0x000783DE
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathIntDiv(Pointer, MemoryOwner);
		}

		// Token: 0x040027E5 RID: 10213
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathIntDiv";

		// Token: 0x040027E6 RID: 10214
		private static IntPtr _ScriptStructPtr;
	}
}
