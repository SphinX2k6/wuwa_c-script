using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006AC RID: 1708
	[UnrealObjectPath("/Script/ControlRig.RigUnit_QuaternionToAxisAndAngle")]
	[UnrealStructLayout(48, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_QuaternionToAxisAndAngle : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005B01 RID: 23297 RVA: 0x00082B99 File Offset: 0x00080D99
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_QuaternionToAxisAndAngle._ScriptStructPtr != 0) ? FRigUnit_QuaternionToAxisAndAngle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_QuaternionToAxisAndAngle", ref FRigUnit_QuaternionToAxisAndAngle._ScriptStructPtr);
		}

		// Token: 0x170015AE RID: 5550
		// (get) Token: 0x06005B02 RID: 23298 RVA: 0x00082BBD File Offset: 0x00080DBD
		// (set) Token: 0x06005B03 RID: 23299 RVA: 0x00082BD1 File Offset: 0x00080DD1
		public unsafe FQuat Argument
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_QuaternionToAxisAndAngle.__PropertyOffset_Argument);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_QuaternionToAxisAndAngle.__PropertyOffset_Argument) = value;
			}
		}

		// Token: 0x170015AF RID: 5551
		// (get) Token: 0x06005B04 RID: 23300 RVA: 0x00082BE6 File Offset: 0x00080DE6
		// (set) Token: 0x06005B05 RID: 23301 RVA: 0x00082BFA File Offset: 0x00080DFA
		public unsafe FVector Axis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_QuaternionToAxisAndAngle.__PropertyOffset_Axis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_QuaternionToAxisAndAngle.__PropertyOffset_Axis) = value;
			}
		}

		// Token: 0x170015B0 RID: 5552
		// (get) Token: 0x06005B06 RID: 23302 RVA: 0x00082C0F File Offset: 0x00080E0F
		// (set) Token: 0x06005B07 RID: 23303 RVA: 0x00082C1F File Offset: 0x00080E1F
		public unsafe float Angle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_QuaternionToAxisAndAngle.__PropertyOffset_Angle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_QuaternionToAxisAndAngle.__PropertyOffset_Angle) = value;
			}
		}

		// Token: 0x06005B08 RID: 23304 RVA: 0x00082C30 File Offset: 0x00080E30
		public FRigUnit_QuaternionToAxisAndAngle()
		{
		}

		// Token: 0x06005B09 RID: 23305 RVA: 0x00082C38 File Offset: 0x00080E38
		public FRigUnit_QuaternionToAxisAndAngle(FQuat Argument, FVector Axis, float Angle)
		{
			this.Argument = Argument;
			this.Axis = Axis;
			this.Angle = Angle;
		}

		// Token: 0x06005B0A RID: 23306 RVA: 0x00082C55 File Offset: 0x00080E55
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_QuaternionToAxisAndAngle.StaticStruct();
		}

		// Token: 0x06005B0B RID: 23307 RVA: 0x00082C61 File Offset: 0x00080E61
		[NullableContext(2)]
		public FRigUnit_QuaternionToAxisAndAngle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005B0C RID: 23308 RVA: 0x00082C6B File Offset: 0x00080E6B
		public FRigUnit_QuaternionToAxisAndAngle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005B0D RID: 23309 RVA: 0x00082C76 File Offset: 0x00080E76
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_QuaternionToAxisAndAngle(Pointer, false, true);
		}

		// Token: 0x06005B0E RID: 23310 RVA: 0x00082C80 File Offset: 0x00080E80
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_QuaternionToAxisAndAngle(Pointer, MemoryOwner);
		}

		// Token: 0x04002AA0 RID: 10912
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_QuaternionToAxisAndAngle";

		// Token: 0x04002AA1 RID: 10913
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002AA2 RID: 10914
		internal static int __PropertyOffset_Argument;

		// Token: 0x04002AA3 RID: 10915
		internal static int __PropertyOffset_Axis;

		// Token: 0x04002AA4 RID: 10916
		internal static int __PropertyOffset_Angle;
	}
}
