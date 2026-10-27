using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000640 RID: 1600
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathQuaternionToAxisAndAngle")]
	[UnrealStructLayout(48, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_MathQuaternionToAxisAndAngle : FRigUnit_MathQuaternionBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005566 RID: 21862 RVA: 0x0007BD5A File Offset: 0x00079F5A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathQuaternionToAxisAndAngle._ScriptStructPtr != 0) ? FRigUnit_MathQuaternionToAxisAndAngle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathQuaternionToAxisAndAngle", ref FRigUnit_MathQuaternionToAxisAndAngle._ScriptStructPtr);
		}

		// Token: 0x1700148D RID: 5261
		// (get) Token: 0x06005567 RID: 21863 RVA: 0x0007BD7E File Offset: 0x00079F7E
		// (set) Token: 0x06005568 RID: 21864 RVA: 0x0007BD92 File Offset: 0x00079F92
		public unsafe FQuat Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionToAxisAndAngle.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionToAxisAndAngle.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x1700148E RID: 5262
		// (get) Token: 0x06005569 RID: 21865 RVA: 0x0007BDA7 File Offset: 0x00079FA7
		// (set) Token: 0x0600556A RID: 21866 RVA: 0x0007BDBB File Offset: 0x00079FBB
		public unsafe FVector Axis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionToAxisAndAngle.__PropertyOffset_Axis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionToAxisAndAngle.__PropertyOffset_Axis) = value;
			}
		}

		// Token: 0x1700148F RID: 5263
		// (get) Token: 0x0600556B RID: 21867 RVA: 0x0007BDD0 File Offset: 0x00079FD0
		// (set) Token: 0x0600556C RID: 21868 RVA: 0x0007BDE0 File Offset: 0x00079FE0
		public unsafe float Angle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionToAxisAndAngle.__PropertyOffset_Angle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionToAxisAndAngle.__PropertyOffset_Angle) = value;
			}
		}

		// Token: 0x0600556D RID: 21869 RVA: 0x0007BDF1 File Offset: 0x00079FF1
		public FRigUnit_MathQuaternionToAxisAndAngle()
		{
		}

		// Token: 0x0600556E RID: 21870 RVA: 0x0007BDF9 File Offset: 0x00079FF9
		public FRigUnit_MathQuaternionToAxisAndAngle(FQuat Value, FVector Axis, float Angle)
		{
			this.Value = Value;
			this.Axis = Axis;
			this.Angle = Angle;
		}

		// Token: 0x0600556F RID: 21871 RVA: 0x0007BE16 File Offset: 0x0007A016
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathQuaternionToAxisAndAngle.StaticStruct();
		}

		// Token: 0x06005570 RID: 21872 RVA: 0x0007BE22 File Offset: 0x0007A022
		[NullableContext(2)]
		public FRigUnit_MathQuaternionToAxisAndAngle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005571 RID: 21873 RVA: 0x0007BE2C File Offset: 0x0007A02C
		public FRigUnit_MathQuaternionToAxisAndAngle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005572 RID: 21874 RVA: 0x0007BE37 File Offset: 0x0007A037
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathQuaternionToAxisAndAngle(Pointer, false, true);
		}

		// Token: 0x06005573 RID: 21875 RVA: 0x0007BE41 File Offset: 0x0007A041
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathQuaternionToAxisAndAngle(Pointer, MemoryOwner);
		}

		// Token: 0x04002875 RID: 10357
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathQuaternionToAxisAndAngle";

		// Token: 0x04002876 RID: 10358
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002877 RID: 10359
		internal static int __PropertyOffset_Value;

		// Token: 0x04002878 RID: 10360
		internal static int __PropertyOffset_Axis;

		// Token: 0x04002879 RID: 10361
		internal static int __PropertyOffset_Angle;
	}
}
