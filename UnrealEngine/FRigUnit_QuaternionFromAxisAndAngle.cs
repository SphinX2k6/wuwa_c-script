using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006AA RID: 1706
	[UnrealObjectPath("/Script/ControlRig.RigUnit_QuaternionFromAxisAndAngle")]
	[UnrealStructLayout(48, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_QuaternionFromAxisAndAngle : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005AE5 RID: 23269 RVA: 0x000829B9 File Offset: 0x00080BB9
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_QuaternionFromAxisAndAngle._ScriptStructPtr != 0) ? FRigUnit_QuaternionFromAxisAndAngle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_QuaternionFromAxisAndAngle", ref FRigUnit_QuaternionFromAxisAndAngle._ScriptStructPtr);
		}

		// Token: 0x170015A8 RID: 5544
		// (get) Token: 0x06005AE6 RID: 23270 RVA: 0x000829DD File Offset: 0x00080BDD
		// (set) Token: 0x06005AE7 RID: 23271 RVA: 0x000829F1 File Offset: 0x00080BF1
		public unsafe FVector Axis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_QuaternionFromAxisAndAngle.__PropertyOffset_Axis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_QuaternionFromAxisAndAngle.__PropertyOffset_Axis) = value;
			}
		}

		// Token: 0x170015A9 RID: 5545
		// (get) Token: 0x06005AE8 RID: 23272 RVA: 0x00082A06 File Offset: 0x00080C06
		// (set) Token: 0x06005AE9 RID: 23273 RVA: 0x00082A16 File Offset: 0x00080C16
		public unsafe float Angle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_QuaternionFromAxisAndAngle.__PropertyOffset_Angle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_QuaternionFromAxisAndAngle.__PropertyOffset_Angle) = value;
			}
		}

		// Token: 0x170015AA RID: 5546
		// (get) Token: 0x06005AEA RID: 23274 RVA: 0x00082A27 File Offset: 0x00080C27
		// (set) Token: 0x06005AEB RID: 23275 RVA: 0x00082A3B File Offset: 0x00080C3B
		public unsafe FQuat Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_QuaternionFromAxisAndAngle.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_QuaternionFromAxisAndAngle.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x06005AEC RID: 23276 RVA: 0x00082A50 File Offset: 0x00080C50
		public FRigUnit_QuaternionFromAxisAndAngle()
		{
		}

		// Token: 0x06005AED RID: 23277 RVA: 0x00082A58 File Offset: 0x00080C58
		public FRigUnit_QuaternionFromAxisAndAngle(FVector Axis, float Angle, FQuat Result)
		{
			this.Axis = Axis;
			this.Angle = Angle;
			this.Result = Result;
		}

		// Token: 0x06005AEE RID: 23278 RVA: 0x00082A75 File Offset: 0x00080C75
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_QuaternionFromAxisAndAngle.StaticStruct();
		}

		// Token: 0x06005AEF RID: 23279 RVA: 0x00082A81 File Offset: 0x00080C81
		[NullableContext(2)]
		public FRigUnit_QuaternionFromAxisAndAngle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005AF0 RID: 23280 RVA: 0x00082A8B File Offset: 0x00080C8B
		public FRigUnit_QuaternionFromAxisAndAngle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005AF1 RID: 23281 RVA: 0x00082A96 File Offset: 0x00080C96
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_QuaternionFromAxisAndAngle(Pointer, false, true);
		}

		// Token: 0x06005AF2 RID: 23282 RVA: 0x00082AA0 File Offset: 0x00080CA0
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_QuaternionFromAxisAndAngle(Pointer, MemoryOwner);
		}

		// Token: 0x04002A96 RID: 10902
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_QuaternionFromAxisAndAngle";

		// Token: 0x04002A97 RID: 10903
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002A98 RID: 10904
		internal static int __PropertyOffset_Axis;

		// Token: 0x04002A99 RID: 10905
		internal static int __PropertyOffset_Angle;

		// Token: 0x04002A9A RID: 10906
		internal static int __PropertyOffset_Result;
	}
}
