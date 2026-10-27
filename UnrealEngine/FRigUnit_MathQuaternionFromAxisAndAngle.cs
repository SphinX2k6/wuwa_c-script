using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000632 RID: 1586
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathQuaternionFromAxisAndAngle")]
	[UnrealStructLayout(48, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_MathQuaternionFromAxisAndAngle : FRigUnit_MathQuaternionBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060054B0 RID: 21680 RVA: 0x0007B12C File Offset: 0x0007932C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathQuaternionFromAxisAndAngle._ScriptStructPtr != 0) ? FRigUnit_MathQuaternionFromAxisAndAngle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathQuaternionFromAxisAndAngle", ref FRigUnit_MathQuaternionFromAxisAndAngle._ScriptStructPtr);
		}

		// Token: 0x1700146A RID: 5226
		// (get) Token: 0x060054B1 RID: 21681 RVA: 0x0007B150 File Offset: 0x00079350
		// (set) Token: 0x060054B2 RID: 21682 RVA: 0x0007B164 File Offset: 0x00079364
		public unsafe FVector Axis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionFromAxisAndAngle.__PropertyOffset_Axis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionFromAxisAndAngle.__PropertyOffset_Axis) = value;
			}
		}

		// Token: 0x1700146B RID: 5227
		// (get) Token: 0x060054B3 RID: 21683 RVA: 0x0007B179 File Offset: 0x00079379
		// (set) Token: 0x060054B4 RID: 21684 RVA: 0x0007B189 File Offset: 0x00079389
		public unsafe float Angle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionFromAxisAndAngle.__PropertyOffset_Angle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionFromAxisAndAngle.__PropertyOffset_Angle) = value;
			}
		}

		// Token: 0x1700146C RID: 5228
		// (get) Token: 0x060054B5 RID: 21685 RVA: 0x0007B19A File Offset: 0x0007939A
		// (set) Token: 0x060054B6 RID: 21686 RVA: 0x0007B1AE File Offset: 0x000793AE
		public unsafe FQuat Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionFromAxisAndAngle.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionFromAxisAndAngle.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x060054B7 RID: 21687 RVA: 0x0007B1C3 File Offset: 0x000793C3
		public FRigUnit_MathQuaternionFromAxisAndAngle()
		{
		}

		// Token: 0x060054B8 RID: 21688 RVA: 0x0007B1CB File Offset: 0x000793CB
		public FRigUnit_MathQuaternionFromAxisAndAngle(FVector Axis, float Angle, FQuat Result)
		{
			this.Axis = Axis;
			this.Angle = Angle;
			this.Result = Result;
		}

		// Token: 0x060054B9 RID: 21689 RVA: 0x0007B1E8 File Offset: 0x000793E8
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathQuaternionFromAxisAndAngle.StaticStruct();
		}

		// Token: 0x060054BA RID: 21690 RVA: 0x0007B1F4 File Offset: 0x000793F4
		[NullableContext(2)]
		public FRigUnit_MathQuaternionFromAxisAndAngle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060054BB RID: 21691 RVA: 0x0007B1FE File Offset: 0x000793FE
		public FRigUnit_MathQuaternionFromAxisAndAngle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060054BC RID: 21692 RVA: 0x0007B209 File Offset: 0x00079409
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathQuaternionFromAxisAndAngle(Pointer, false, true);
		}

		// Token: 0x060054BD RID: 21693 RVA: 0x0007B213 File Offset: 0x00079413
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathQuaternionFromAxisAndAngle(Pointer, MemoryOwner);
		}

		// Token: 0x04002836 RID: 10294
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathQuaternionFromAxisAndAngle";

		// Token: 0x04002837 RID: 10295
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002838 RID: 10296
		internal static int __PropertyOffset_Axis;

		// Token: 0x04002839 RID: 10297
		internal static int __PropertyOffset_Angle;

		// Token: 0x0400283A RID: 10298
		internal static int __PropertyOffset_Result;
	}
}
