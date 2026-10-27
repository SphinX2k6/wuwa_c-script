using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000630 RID: 1584
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathQuaternionDot")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FRigUnit_MathQuaternionDot : FRigUnit_MathQuaternionBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005494 RID: 21652 RVA: 0x0007AF4C File Offset: 0x0007914C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathQuaternionDot._ScriptStructPtr != 0) ? FRigUnit_MathQuaternionDot._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathQuaternionDot", ref FRigUnit_MathQuaternionDot._ScriptStructPtr);
		}

		// Token: 0x17001464 RID: 5220
		// (get) Token: 0x06005495 RID: 21653 RVA: 0x0007AF70 File Offset: 0x00079170
		// (set) Token: 0x06005496 RID: 21654 RVA: 0x0007AF84 File Offset: 0x00079184
		public unsafe FQuat A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionDot.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionDot.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x17001465 RID: 5221
		// (get) Token: 0x06005497 RID: 21655 RVA: 0x0007AF99 File Offset: 0x00079199
		// (set) Token: 0x06005498 RID: 21656 RVA: 0x0007AFAD File Offset: 0x000791AD
		public unsafe FQuat B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionDot.__PropertyOffset_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionDot.__PropertyOffset_B) = value;
			}
		}

		// Token: 0x17001466 RID: 5222
		// (get) Token: 0x06005499 RID: 21657 RVA: 0x0007AFC2 File Offset: 0x000791C2
		// (set) Token: 0x0600549A RID: 21658 RVA: 0x0007AFD2 File Offset: 0x000791D2
		public unsafe float Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionDot.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionDot.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x0600549B RID: 21659 RVA: 0x0007AFE3 File Offset: 0x000791E3
		public FRigUnit_MathQuaternionDot()
		{
		}

		// Token: 0x0600549C RID: 21660 RVA: 0x0007AFEB File Offset: 0x000791EB
		public FRigUnit_MathQuaternionDot(FQuat A, FQuat B, float Result)
		{
			this.A = A;
			this.B = B;
			this.Result = Result;
		}

		// Token: 0x0600549D RID: 21661 RVA: 0x0007B008 File Offset: 0x00079208
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathQuaternionDot.StaticStruct();
		}

		// Token: 0x0600549E RID: 21662 RVA: 0x0007B014 File Offset: 0x00079214
		[NullableContext(2)]
		public FRigUnit_MathQuaternionDot(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600549F RID: 21663 RVA: 0x0007B01E File Offset: 0x0007921E
		public FRigUnit_MathQuaternionDot(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060054A0 RID: 21664 RVA: 0x0007B029 File Offset: 0x00079229
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathQuaternionDot(Pointer, false, true);
		}

		// Token: 0x060054A1 RID: 21665 RVA: 0x0007B033 File Offset: 0x00079233
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathQuaternionDot(Pointer, MemoryOwner);
		}

		// Token: 0x0400282C RID: 10284
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathQuaternionDot";

		// Token: 0x0400282D RID: 10285
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400282E RID: 10286
		internal static int __PropertyOffset_A;

		// Token: 0x0400282F RID: 10287
		internal static int __PropertyOffset_B;

		// Token: 0x04002830 RID: 10288
		internal static int __PropertyOffset_Result;
	}
}
