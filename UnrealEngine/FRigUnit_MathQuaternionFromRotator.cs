using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000634 RID: 1588
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathQuaternionFromRotator")]
	[UnrealStructLayout(48, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_MathQuaternionFromRotator : FRigUnit_MathQuaternionBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060054CC RID: 21708 RVA: 0x0007B30C File Offset: 0x0007950C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathQuaternionFromRotator._ScriptStructPtr != 0) ? FRigUnit_MathQuaternionFromRotator._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathQuaternionFromRotator", ref FRigUnit_MathQuaternionFromRotator._ScriptStructPtr);
		}

		// Token: 0x17001470 RID: 5232
		// (get) Token: 0x060054CD RID: 21709 RVA: 0x0007B330 File Offset: 0x00079530
		// (set) Token: 0x060054CE RID: 21710 RVA: 0x0007B344 File Offset: 0x00079544
		public unsafe FRotator Rotator
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionFromRotator.__PropertyOffset_Rotator);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionFromRotator.__PropertyOffset_Rotator) = value;
			}
		}

		// Token: 0x17001471 RID: 5233
		// (get) Token: 0x060054CF RID: 21711 RVA: 0x0007B359 File Offset: 0x00079559
		// (set) Token: 0x060054D0 RID: 21712 RVA: 0x0007B36D File Offset: 0x0007956D
		public unsafe FQuat Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionFromRotator.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionFromRotator.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x060054D1 RID: 21713 RVA: 0x0007B382 File Offset: 0x00079582
		public FRigUnit_MathQuaternionFromRotator()
		{
		}

		// Token: 0x060054D2 RID: 21714 RVA: 0x0007B38A File Offset: 0x0007958A
		public FRigUnit_MathQuaternionFromRotator(FRotator Rotator, FQuat Result)
		{
			this.Rotator = Rotator;
			this.Result = Result;
		}

		// Token: 0x060054D3 RID: 21715 RVA: 0x0007B3A0 File Offset: 0x000795A0
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathQuaternionFromRotator.StaticStruct();
		}

		// Token: 0x060054D4 RID: 21716 RVA: 0x0007B3AC File Offset: 0x000795AC
		[NullableContext(2)]
		public FRigUnit_MathQuaternionFromRotator(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060054D5 RID: 21717 RVA: 0x0007B3B6 File Offset: 0x000795B6
		public FRigUnit_MathQuaternionFromRotator(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060054D6 RID: 21718 RVA: 0x0007B3C1 File Offset: 0x000795C1
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathQuaternionFromRotator(Pointer, false, true);
		}

		// Token: 0x060054D7 RID: 21719 RVA: 0x0007B3CB File Offset: 0x000795CB
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathQuaternionFromRotator(Pointer, MemoryOwner);
		}

		// Token: 0x04002840 RID: 10304
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathQuaternionFromRotator";

		// Token: 0x04002841 RID: 10305
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002842 RID: 10306
		internal static int __PropertyOffset_Rotator;

		// Token: 0x04002843 RID: 10307
		internal static int __PropertyOffset_Result;
	}
}
