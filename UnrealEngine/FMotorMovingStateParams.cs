using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001F35 RID: 7989
	[UnrealObjectPath("/Script/KuroVehicle.MotorMovingStateParams")]
	[UnrealStructLayout(60, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 60)]
	public class FMotorMovingStateParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E663 RID: 124515 RVA: 0x002D2E53 File Offset: 0x002D1053
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMotorMovingStateParams._ScriptStructPtr != 0) ? FMotorMovingStateParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroVehicle.MotorMovingStateParams", ref FMotorMovingStateParams._ScriptStructPtr);
		}

		// Token: 0x170078E6 RID: 30950
		// (get) Token: 0x0601E664 RID: 124516 RVA: 0x002D2E77 File Offset: 0x002D1077
		// (set) Token: 0x0601E665 RID: 124517 RVA: 0x002D2E87 File Offset: 0x002D1087
		public unsafe bool bLockRotateAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorMovingStateParams.__PropertyOffset_bLockRotateAxis) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorMovingStateParams.__PropertyOffset_bLockRotateAxis) = (value ? 1 : 0);
			}
		}

		// Token: 0x170078E7 RID: 30951
		// (get) Token: 0x0601E666 RID: 124518 RVA: 0x002D2E98 File Offset: 0x002D1098
		// (set) Token: 0x0601E667 RID: 124519 RVA: 0x002D2EAC File Offset: 0x002D10AC
		public unsafe FVector Velocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorMovingStateParams.__PropertyOffset_Velocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorMovingStateParams.__PropertyOffset_Velocity) = value;
			}
		}

		// Token: 0x170078E8 RID: 30952
		// (get) Token: 0x0601E668 RID: 124520 RVA: 0x002D2EC1 File Offset: 0x002D10C1
		// (set) Token: 0x0601E669 RID: 124521 RVA: 0x002D2ED5 File Offset: 0x002D10D5
		public unsafe FVector RotateAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorMovingStateParams.__PropertyOffset_RotateAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorMovingStateParams.__PropertyOffset_RotateAxis) = value;
			}
		}

		// Token: 0x170078E9 RID: 30953
		// (get) Token: 0x0601E66A RID: 124522 RVA: 0x002D2EEA File Offset: 0x002D10EA
		// (set) Token: 0x0601E66B RID: 124523 RVA: 0x002D2EFA File Offset: 0x002D10FA
		public unsafe float RotateSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorMovingStateParams.__PropertyOffset_RotateSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorMovingStateParams.__PropertyOffset_RotateSpeed) = value;
			}
		}

		// Token: 0x170078EA RID: 30954
		// (get) Token: 0x0601E66C RID: 124524 RVA: 0x002D2F0B File Offset: 0x002D110B
		// (set) Token: 0x0601E66D RID: 124525 RVA: 0x002D2F1F File Offset: 0x002D111F
		public unsafe FVector NextRotateAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorMovingStateParams.__PropertyOffset_NextRotateAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorMovingStateParams.__PropertyOffset_NextRotateAxis) = value;
			}
		}

		// Token: 0x170078EB RID: 30955
		// (get) Token: 0x0601E66E RID: 124526 RVA: 0x002D2F34 File Offset: 0x002D1134
		// (set) Token: 0x0601E66F RID: 124527 RVA: 0x002D2F44 File Offset: 0x002D1144
		public unsafe float NextRotateSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorMovingStateParams.__PropertyOffset_NextRotateSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorMovingStateParams.__PropertyOffset_NextRotateSpeed) = value;
			}
		}

		// Token: 0x0601E670 RID: 124528 RVA: 0x002D2F55 File Offset: 0x002D1155
		public FMotorMovingStateParams()
		{
		}

		// Token: 0x0601E671 RID: 124529 RVA: 0x002D2F5D File Offset: 0x002D115D
		public FMotorMovingStateParams(bool bLockRotateAxis, FVector Velocity, FVector RotateAxis, float RotateSpeed, FVector NextRotateAxis, float NextRotateSpeed)
		{
			this.bLockRotateAxis = bLockRotateAxis;
			this.Velocity = Velocity;
			this.RotateAxis = RotateAxis;
			this.RotateSpeed = RotateSpeed;
			this.NextRotateAxis = NextRotateAxis;
			this.NextRotateSpeed = NextRotateSpeed;
		}

		// Token: 0x0601E672 RID: 124530 RVA: 0x002D2F92 File Offset: 0x002D1192
		protected override IntPtr GetUStructPtr()
		{
			return FMotorMovingStateParams.StaticStruct();
		}

		// Token: 0x0601E673 RID: 124531 RVA: 0x002D2F9E File Offset: 0x002D119E
		[NullableContext(2)]
		public FMotorMovingStateParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E674 RID: 124532 RVA: 0x002D2FA8 File Offset: 0x002D11A8
		public FMotorMovingStateParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E675 RID: 124533 RVA: 0x002D2FB3 File Offset: 0x002D11B3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMotorMovingStateParams(Pointer, false, true);
		}

		// Token: 0x0601E676 RID: 124534 RVA: 0x002D2FBD File Offset: 0x002D11BD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMotorMovingStateParams(Pointer, MemoryOwner);
		}

		// Token: 0x0401065A RID: 67162
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroVehicle.MotorMovingStateParams";

		// Token: 0x0401065B RID: 67163
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401065C RID: 67164
		internal static int __PropertyOffset_bLockRotateAxis;

		// Token: 0x0401065D RID: 67165
		internal static int __PropertyOffset_Velocity;

		// Token: 0x0401065E RID: 67166
		internal static int __PropertyOffset_RotateAxis;

		// Token: 0x0401065F RID: 67167
		internal static int __PropertyOffset_RotateSpeed;

		// Token: 0x04010660 RID: 67168
		internal static int __PropertyOffset_NextRotateAxis;

		// Token: 0x04010661 RID: 67169
		internal static int __PropertyOffset_NextRotateSpeed;
	}
}
