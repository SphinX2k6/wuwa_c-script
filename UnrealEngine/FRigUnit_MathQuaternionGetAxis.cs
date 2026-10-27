using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000636 RID: 1590
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathQuaternionGetAxis")]
	[UnrealStructLayout(48, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_MathQuaternionGetAxis : FRigUnit_MathQuaternionBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060054E6 RID: 21734 RVA: 0x0007B4CC File Offset: 0x000796CC
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathQuaternionGetAxis._ScriptStructPtr != 0) ? FRigUnit_MathQuaternionGetAxis._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathQuaternionGetAxis", ref FRigUnit_MathQuaternionGetAxis._ScriptStructPtr);
		}

		// Token: 0x17001475 RID: 5237
		// (get) Token: 0x060054E7 RID: 21735 RVA: 0x0007B4F0 File Offset: 0x000796F0
		// (set) Token: 0x060054E8 RID: 21736 RVA: 0x0007B504 File Offset: 0x00079704
		public unsafe FQuat Quaternion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionGetAxis.__PropertyOffset_Quaternion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionGetAxis.__PropertyOffset_Quaternion) = value;
			}
		}

		// Token: 0x17001476 RID: 5238
		// (get) Token: 0x060054E9 RID: 21737 RVA: 0x0007B519 File Offset: 0x00079719
		// (set) Token: 0x060054EA RID: 21738 RVA: 0x0007B52D File Offset: 0x0007972D
		public unsafe TEnumAsByte<EAxis> Axis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionGetAxis.__PropertyOffset_Axis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionGetAxis.__PropertyOffset_Axis) = value;
			}
		}

		// Token: 0x17001477 RID: 5239
		// (get) Token: 0x060054EB RID: 21739 RVA: 0x0007B542 File Offset: 0x00079742
		// (set) Token: 0x060054EC RID: 21740 RVA: 0x0007B556 File Offset: 0x00079756
		public unsafe FVector Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionGetAxis.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionGetAxis.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x060054ED RID: 21741 RVA: 0x0007B56B File Offset: 0x0007976B
		public FRigUnit_MathQuaternionGetAxis()
		{
		}

		// Token: 0x060054EE RID: 21742 RVA: 0x0007B573 File Offset: 0x00079773
		public FRigUnit_MathQuaternionGetAxis(FQuat Quaternion, TEnumAsByte<EAxis> Axis, FVector Result)
		{
			this.Quaternion = Quaternion;
			this.Axis = Axis;
			this.Result = Result;
		}

		// Token: 0x060054EF RID: 21743 RVA: 0x0007B590 File Offset: 0x00079790
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathQuaternionGetAxis.StaticStruct();
		}

		// Token: 0x060054F0 RID: 21744 RVA: 0x0007B59C File Offset: 0x0007979C
		[NullableContext(2)]
		public FRigUnit_MathQuaternionGetAxis(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060054F1 RID: 21745 RVA: 0x0007B5A6 File Offset: 0x000797A6
		public FRigUnit_MathQuaternionGetAxis(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060054F2 RID: 21746 RVA: 0x0007B5B1 File Offset: 0x000797B1
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathQuaternionGetAxis(Pointer, false, true);
		}

		// Token: 0x060054F3 RID: 21747 RVA: 0x0007B5BB File Offset: 0x000797BB
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathQuaternionGetAxis(Pointer, MemoryOwner);
		}

		// Token: 0x04002849 RID: 10313
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathQuaternionGetAxis";

		// Token: 0x0400284A RID: 10314
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400284B RID: 10315
		internal static int __PropertyOffset_Quaternion;

		// Token: 0x0400284C RID: 10316
		internal static int __PropertyOffset_Axis;

		// Token: 0x0400284D RID: 10317
		internal static int __PropertyOffset_Result;
	}
}
