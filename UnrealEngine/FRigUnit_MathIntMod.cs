using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000625 RID: 1573
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathIntMod")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_MathIntMod : FRigUnit_MathIntBinaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005429 RID: 21545 RVA: 0x0007A8C4 File Offset: 0x00078AC4
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathIntMod._ScriptStructPtr != 0) ? FRigUnit_MathIntMod._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathIntMod", ref FRigUnit_MathIntMod._ScriptStructPtr);
		}

		// Token: 0x0600542A RID: 21546 RVA: 0x0007A8E8 File Offset: 0x00078AE8
		public FRigUnit_MathIntMod()
		{
		}

		// Token: 0x0600542B RID: 21547 RVA: 0x0007A8F0 File Offset: 0x00078AF0
		public FRigUnit_MathIntMod(int A, int B, int Result)
		{
			base.A = A;
			base.B = B;
			base.Result = Result;
		}

		// Token: 0x0600542C RID: 21548 RVA: 0x0007A90D File Offset: 0x00078B0D
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathIntMod.StaticStruct();
		}

		// Token: 0x0600542D RID: 21549 RVA: 0x0007A919 File Offset: 0x00078B19
		[NullableContext(2)]
		public FRigUnit_MathIntMod(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600542E RID: 21550 RVA: 0x0007A923 File Offset: 0x00078B23
		public FRigUnit_MathIntMod(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600542F RID: 21551 RVA: 0x0007A92E File Offset: 0x00078B2E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathIntMod(Pointer, false, true);
		}

		// Token: 0x06005430 RID: 21552 RVA: 0x0007A938 File Offset: 0x00078B38
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathIntMod(Pointer, MemoryOwner);
		}

		// Token: 0x0400280C RID: 10252
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathIntMod";

		// Token: 0x0400280D RID: 10253
		private static IntPtr _ScriptStructPtr;
	}
}
