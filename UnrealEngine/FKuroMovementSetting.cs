using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200022C RID: 556
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KuroMovementSetting")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FKuroMovementSetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002CE0 RID: 11488 RVA: 0x0003F70C File Offset: 0x0003D90C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMovementSetting._ScriptStructPtr != 0) ? FKuroMovementSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroMovementSetting", ref FKuroMovementSetting._ScriptStructPtr);
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06002CE1 RID: 11489 RVA: 0x0003F730 File Offset: 0x0003D930
		// (set) Token: 0x06002CE2 RID: 11490 RVA: 0x0003F740 File Offset: 0x0003D940
		public unsafe float Acceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMovementSetting.__PropertyOffset_Acceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMovementSetting.__PropertyOffset_Acceleration) = value;
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06002CE3 RID: 11491 RVA: 0x0003F751 File Offset: 0x0003D951
		// (set) Token: 0x06002CE4 RID: 11492 RVA: 0x0003F761 File Offset: 0x0003D961
		public unsafe float ControllerRotationSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMovementSetting.__PropertyOffset_ControllerRotationSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMovementSetting.__PropertyOffset_ControllerRotationSpeed) = value;
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06002CE5 RID: 11493 RVA: 0x0003F772 File Offset: 0x0003D972
		// (set) Token: 0x06002CE6 RID: 11494 RVA: 0x0003F786 File Offset: 0x0003D986
		public unsafe FKuroMovementRotationSetting ControllerRotationSpeedSetting
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMovementSetting.__PropertyOffset_ControllerRotationSpeedSetting);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMovementSetting.__PropertyOffset_ControllerRotationSpeedSetting) = value;
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06002CE7 RID: 11495 RVA: 0x0003F79B File Offset: 0x0003D99B
		// (set) Token: 0x06002CE8 RID: 11496 RVA: 0x0003F7AB File Offset: 0x0003D9AB
		public unsafe float FastSwimSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMovementSetting.__PropertyOffset_FastSwimSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMovementSetting.__PropertyOffset_FastSwimSpeed) = value;
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06002CE9 RID: 11497 RVA: 0x0003F7BC File Offset: 0x0003D9BC
		// (set) Token: 0x06002CEA RID: 11498 RVA: 0x0003F7CC File Offset: 0x0003D9CC
		public unsafe float GroundFriction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMovementSetting.__PropertyOffset_GroundFriction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMovementSetting.__PropertyOffset_GroundFriction) = value;
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06002CEB RID: 11499 RVA: 0x0003F7DD File Offset: 0x0003D9DD
		// (set) Token: 0x06002CEC RID: 11500 RVA: 0x0003F7F1 File Offset: 0x0003D9F1
		public unsafe UCurveVector MovementCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveVector>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMovementSetting.__PropertyOffset_MovementCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMovementSetting.__PropertyOffset_MovementCurve, value);
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06002CED RID: 11501 RVA: 0x0003F806 File Offset: 0x0003DA06
		// (set) Token: 0x06002CEE RID: 11502 RVA: 0x0003F816 File Offset: 0x0003DA16
		public unsafe float NormalSwimSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMovementSetting.__PropertyOffset_NormalSwimSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMovementSetting.__PropertyOffset_NormalSwimSpeed) = value;
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06002CEF RID: 11503 RVA: 0x0003F827 File Offset: 0x0003DA27
		// (set) Token: 0x06002CF0 RID: 11504 RVA: 0x0003F83B File Offset: 0x0003DA3B
		public unsafe UCurveFloat RotationRateCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMovementSetting.__PropertyOffset_RotationRateCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroMovementSetting.__PropertyOffset_RotationRateCurve, value);
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06002CF1 RID: 11505 RVA: 0x0003F850 File Offset: 0x0003DA50
		// (set) Token: 0x06002CF2 RID: 11506 RVA: 0x0003F860 File Offset: 0x0003DA60
		public unsafe float RunSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMovementSetting.__PropertyOffset_RunSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMovementSetting.__PropertyOffset_RunSpeed) = value;
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06002CF3 RID: 11507 RVA: 0x0003F871 File Offset: 0x0003DA71
		// (set) Token: 0x06002CF4 RID: 11508 RVA: 0x0003F881 File Offset: 0x0003DA81
		public unsafe float SprintSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMovementSetting.__PropertyOffset_SprintSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMovementSetting.__PropertyOffset_SprintSpeed) = value;
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06002CF5 RID: 11509 RVA: 0x0003F892 File Offset: 0x0003DA92
		// (set) Token: 0x06002CF6 RID: 11510 RVA: 0x0003F8A2 File Offset: 0x0003DAA2
		public unsafe float SwingAcceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMovementSetting.__PropertyOffset_SwingAcceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMovementSetting.__PropertyOffset_SwingAcceleration) = value;
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06002CF7 RID: 11511 RVA: 0x0003F8B3 File Offset: 0x0003DAB3
		// (set) Token: 0x06002CF8 RID: 11512 RVA: 0x0003F8C3 File Offset: 0x0003DAC3
		public unsafe float SwingSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMovementSetting.__PropertyOffset_SwingSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMovementSetting.__PropertyOffset_SwingSpeed) = value;
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06002CF9 RID: 11513 RVA: 0x0003F8D4 File Offset: 0x0003DAD4
		// (set) Token: 0x06002CFA RID: 11514 RVA: 0x0003F8E4 File Offset: 0x0003DAE4
		public unsafe float WalkSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMovementSetting.__PropertyOffset_WalkSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMovementSetting.__PropertyOffset_WalkSpeed) = value;
			}
		}

		// Token: 0x06002CFB RID: 11515 RVA: 0x0003F8F5 File Offset: 0x0003DAF5
		public FKuroMovementSetting()
		{
		}

		// Token: 0x06002CFC RID: 11516 RVA: 0x0003F8FD File Offset: 0x0003DAFD
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMovementSetting.StaticStruct();
		}

		// Token: 0x06002CFD RID: 11517 RVA: 0x0003F909 File Offset: 0x0003DB09
		public FKuroMovementSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002CFE RID: 11518 RVA: 0x0003F913 File Offset: 0x0003DB13
		public FKuroMovementSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002CFF RID: 11519 RVA: 0x0003F91E File Offset: 0x0003DB1E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMovementSetting(Pointer, false, true);
		}

		// Token: 0x06002D00 RID: 11520 RVA: 0x0003F928 File Offset: 0x0003DB28
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMovementSetting(Pointer, MemoryOwner);
		}

		// Token: 0x04000E3D RID: 3645
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.KuroMovementSetting";

		// Token: 0x04000E3E RID: 3646
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000E3F RID: 3647
		internal static int __PropertyOffset_Acceleration;

		// Token: 0x04000E40 RID: 3648
		internal static int __PropertyOffset_ControllerRotationSpeed;

		// Token: 0x04000E41 RID: 3649
		internal static int __PropertyOffset_ControllerRotationSpeedSetting;

		// Token: 0x04000E42 RID: 3650
		internal static int __PropertyOffset_FastSwimSpeed;

		// Token: 0x04000E43 RID: 3651
		internal static int __PropertyOffset_GroundFriction;

		// Token: 0x04000E44 RID: 3652
		internal static int __PropertyOffset_MovementCurve;

		// Token: 0x04000E45 RID: 3653
		internal static int __PropertyOffset_NormalSwimSpeed;

		// Token: 0x04000E46 RID: 3654
		internal static int __PropertyOffset_RotationRateCurve;

		// Token: 0x04000E47 RID: 3655
		internal static int __PropertyOffset_RunSpeed;

		// Token: 0x04000E48 RID: 3656
		internal static int __PropertyOffset_SprintSpeed;

		// Token: 0x04000E49 RID: 3657
		internal static int __PropertyOffset_SwingAcceleration;

		// Token: 0x04000E4A RID: 3658
		internal static int __PropertyOffset_SwingSpeed;

		// Token: 0x04000E4B RID: 3659
		internal static int __PropertyOffset_WalkSpeed;
	}
}
