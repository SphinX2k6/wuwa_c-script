using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006AB RID: 1707
	[UnrealObjectPath("/Script/ControlRig.RigUnit_QuaternionToAngle")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FRigUnit_QuaternionToAngle : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005AF3 RID: 23283 RVA: 0x00082AA9 File Offset: 0x00080CA9
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_QuaternionToAngle._ScriptStructPtr != 0) ? FRigUnit_QuaternionToAngle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_QuaternionToAngle", ref FRigUnit_QuaternionToAngle._ScriptStructPtr);
		}

		// Token: 0x170015AB RID: 5547
		// (get) Token: 0x06005AF4 RID: 23284 RVA: 0x00082ACD File Offset: 0x00080CCD
		// (set) Token: 0x06005AF5 RID: 23285 RVA: 0x00082AE1 File Offset: 0x00080CE1
		public unsafe FVector Axis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_QuaternionToAngle.__PropertyOffset_Axis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_QuaternionToAngle.__PropertyOffset_Axis) = value;
			}
		}

		// Token: 0x170015AC RID: 5548
		// (get) Token: 0x06005AF6 RID: 23286 RVA: 0x00082AF6 File Offset: 0x00080CF6
		// (set) Token: 0x06005AF7 RID: 23287 RVA: 0x00082B0A File Offset: 0x00080D0A
		public unsafe FQuat Argument
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_QuaternionToAngle.__PropertyOffset_Argument);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_QuaternionToAngle.__PropertyOffset_Argument) = value;
			}
		}

		// Token: 0x170015AD RID: 5549
		// (get) Token: 0x06005AF8 RID: 23288 RVA: 0x00082B1F File Offset: 0x00080D1F
		// (set) Token: 0x06005AF9 RID: 23289 RVA: 0x00082B2F File Offset: 0x00080D2F
		public unsafe float Angle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_QuaternionToAngle.__PropertyOffset_Angle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_QuaternionToAngle.__PropertyOffset_Angle) = value;
			}
		}

		// Token: 0x06005AFA RID: 23290 RVA: 0x00082B40 File Offset: 0x00080D40
		public FRigUnit_QuaternionToAngle()
		{
		}

		// Token: 0x06005AFB RID: 23291 RVA: 0x00082B48 File Offset: 0x00080D48
		public FRigUnit_QuaternionToAngle(FVector Axis, FQuat Argument, float Angle)
		{
			this.Axis = Axis;
			this.Argument = Argument;
			this.Angle = Angle;
		}

		// Token: 0x06005AFC RID: 23292 RVA: 0x00082B65 File Offset: 0x00080D65
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_QuaternionToAngle.StaticStruct();
		}

		// Token: 0x06005AFD RID: 23293 RVA: 0x00082B71 File Offset: 0x00080D71
		[NullableContext(2)]
		public FRigUnit_QuaternionToAngle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005AFE RID: 23294 RVA: 0x00082B7B File Offset: 0x00080D7B
		public FRigUnit_QuaternionToAngle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005AFF RID: 23295 RVA: 0x00082B86 File Offset: 0x00080D86
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_QuaternionToAngle(Pointer, false, true);
		}

		// Token: 0x06005B00 RID: 23296 RVA: 0x00082B90 File Offset: 0x00080D90
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_QuaternionToAngle(Pointer, MemoryOwner);
		}

		// Token: 0x04002A9B RID: 10907
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_QuaternionToAngle";

		// Token: 0x04002A9C RID: 10908
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002A9D RID: 10909
		internal static int __PropertyOffset_Axis;

		// Token: 0x04002A9E RID: 10910
		internal static int __PropertyOffset_Argument;

		// Token: 0x04002A9F RID: 10911
		internal static int __PropertyOffset_Angle;
	}
}
