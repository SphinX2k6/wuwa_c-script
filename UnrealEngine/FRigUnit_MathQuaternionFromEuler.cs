using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000633 RID: 1587
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathQuaternionFromEuler")]
	[UnrealStructLayout(48, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_MathQuaternionFromEuler : FRigUnit_MathQuaternionBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060054BE RID: 21694 RVA: 0x0007B21C File Offset: 0x0007941C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathQuaternionFromEuler._ScriptStructPtr != 0) ? FRigUnit_MathQuaternionFromEuler._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathQuaternionFromEuler", ref FRigUnit_MathQuaternionFromEuler._ScriptStructPtr);
		}

		// Token: 0x1700146D RID: 5229
		// (get) Token: 0x060054BF RID: 21695 RVA: 0x0007B240 File Offset: 0x00079440
		// (set) Token: 0x060054C0 RID: 21696 RVA: 0x0007B254 File Offset: 0x00079454
		public unsafe FVector Euler
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionFromEuler.__PropertyOffset_Euler);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionFromEuler.__PropertyOffset_Euler) = value;
			}
		}

		// Token: 0x1700146E RID: 5230
		// (get) Token: 0x060054C1 RID: 21697 RVA: 0x0007B269 File Offset: 0x00079469
		// (set) Token: 0x060054C2 RID: 21698 RVA: 0x0007B279 File Offset: 0x00079479
		public unsafe EControlRigRotationOrder RotationOrder
		{
			get
			{
				return (EControlRigRotationOrder)(*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionFromEuler.__PropertyOffset_RotationOrder));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionFromEuler.__PropertyOffset_RotationOrder) = (byte)value;
			}
		}

		// Token: 0x1700146F RID: 5231
		// (get) Token: 0x060054C3 RID: 21699 RVA: 0x0007B28A File Offset: 0x0007948A
		// (set) Token: 0x060054C4 RID: 21700 RVA: 0x0007B29E File Offset: 0x0007949E
		public unsafe FQuat Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionFromEuler.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionFromEuler.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x060054C5 RID: 21701 RVA: 0x0007B2B3 File Offset: 0x000794B3
		public FRigUnit_MathQuaternionFromEuler()
		{
		}

		// Token: 0x060054C6 RID: 21702 RVA: 0x0007B2BB File Offset: 0x000794BB
		public FRigUnit_MathQuaternionFromEuler(FVector Euler, EControlRigRotationOrder RotationOrder, FQuat Result)
		{
			this.Euler = Euler;
			this.RotationOrder = RotationOrder;
			this.Result = Result;
		}

		// Token: 0x060054C7 RID: 21703 RVA: 0x0007B2D8 File Offset: 0x000794D8
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathQuaternionFromEuler.StaticStruct();
		}

		// Token: 0x060054C8 RID: 21704 RVA: 0x0007B2E4 File Offset: 0x000794E4
		[NullableContext(2)]
		public FRigUnit_MathQuaternionFromEuler(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060054C9 RID: 21705 RVA: 0x0007B2EE File Offset: 0x000794EE
		public FRigUnit_MathQuaternionFromEuler(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060054CA RID: 21706 RVA: 0x0007B2F9 File Offset: 0x000794F9
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathQuaternionFromEuler(Pointer, false, true);
		}

		// Token: 0x060054CB RID: 21707 RVA: 0x0007B303 File Offset: 0x00079503
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathQuaternionFromEuler(Pointer, MemoryOwner);
		}

		// Token: 0x0400283B RID: 10299
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathQuaternionFromEuler";

		// Token: 0x0400283C RID: 10300
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400283D RID: 10301
		internal static int __PropertyOffset_Euler;

		// Token: 0x0400283E RID: 10302
		internal static int __PropertyOffset_RotationOrder;

		// Token: 0x0400283F RID: 10303
		internal static int __PropertyOffset_Result;
	}
}
