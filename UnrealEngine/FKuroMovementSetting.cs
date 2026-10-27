using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CFB RID: 3323
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KuroMovementSetting")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FKuroMovementSetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B0E9 RID: 45289 RVA: 0x000FB464 File Offset: 0x000F9664
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMovementSetting._ScriptStructPtr != 0) ? FKuroMovementSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroMovementSetting", ref FKuroMovementSetting._ScriptStructPtr);
		}

		// Token: 0x17002824 RID: 10276
		// (get) Token: 0x0600B0EA RID: 45290 RVA: 0x000FB488 File Offset: 0x000F9688
		// (set) Token: 0x0600B0EB RID: 45291 RVA: 0x000FB498 File Offset: 0x000F9698
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

		// Token: 0x17002825 RID: 10277
		// (get) Token: 0x0600B0EC RID: 45292 RVA: 0x000FB4A9 File Offset: 0x000F96A9
		// (set) Token: 0x0600B0ED RID: 45293 RVA: 0x000FB4B9 File Offset: 0x000F96B9
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

		// Token: 0x17002826 RID: 10278
		// (get) Token: 0x0600B0EE RID: 45294 RVA: 0x000FB4CA File Offset: 0x000F96CA
		// (set) Token: 0x0600B0EF RID: 45295 RVA: 0x000FB4DE File Offset: 0x000F96DE
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

		// Token: 0x17002827 RID: 10279
		// (get) Token: 0x0600B0F0 RID: 45296 RVA: 0x000FB4F3 File Offset: 0x000F96F3
		// (set) Token: 0x0600B0F1 RID: 45297 RVA: 0x000FB503 File Offset: 0x000F9703
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

		// Token: 0x17002828 RID: 10280
		// (get) Token: 0x0600B0F2 RID: 45298 RVA: 0x000FB514 File Offset: 0x000F9714
		// (set) Token: 0x0600B0F3 RID: 45299 RVA: 0x000FB524 File Offset: 0x000F9724
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

		// Token: 0x17002829 RID: 10281
		// (get) Token: 0x0600B0F4 RID: 45300 RVA: 0x000FB535 File Offset: 0x000F9735
		// (set) Token: 0x0600B0F5 RID: 45301 RVA: 0x000FB549 File Offset: 0x000F9749
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

		// Token: 0x1700282A RID: 10282
		// (get) Token: 0x0600B0F6 RID: 45302 RVA: 0x000FB55E File Offset: 0x000F975E
		// (set) Token: 0x0600B0F7 RID: 45303 RVA: 0x000FB56E File Offset: 0x000F976E
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

		// Token: 0x1700282B RID: 10283
		// (get) Token: 0x0600B0F8 RID: 45304 RVA: 0x000FB57F File Offset: 0x000F977F
		// (set) Token: 0x0600B0F9 RID: 45305 RVA: 0x000FB593 File Offset: 0x000F9793
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

		// Token: 0x1700282C RID: 10284
		// (get) Token: 0x0600B0FA RID: 45306 RVA: 0x000FB5A8 File Offset: 0x000F97A8
		// (set) Token: 0x0600B0FB RID: 45307 RVA: 0x000FB5B8 File Offset: 0x000F97B8
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

		// Token: 0x1700282D RID: 10285
		// (get) Token: 0x0600B0FC RID: 45308 RVA: 0x000FB5C9 File Offset: 0x000F97C9
		// (set) Token: 0x0600B0FD RID: 45309 RVA: 0x000FB5D9 File Offset: 0x000F97D9
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

		// Token: 0x1700282E RID: 10286
		// (get) Token: 0x0600B0FE RID: 45310 RVA: 0x000FB5EA File Offset: 0x000F97EA
		// (set) Token: 0x0600B0FF RID: 45311 RVA: 0x000FB5FA File Offset: 0x000F97FA
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

		// Token: 0x1700282F RID: 10287
		// (get) Token: 0x0600B100 RID: 45312 RVA: 0x000FB60B File Offset: 0x000F980B
		// (set) Token: 0x0600B101 RID: 45313 RVA: 0x000FB61B File Offset: 0x000F981B
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

		// Token: 0x17002830 RID: 10288
		// (get) Token: 0x0600B102 RID: 45314 RVA: 0x000FB62C File Offset: 0x000F982C
		// (set) Token: 0x0600B103 RID: 45315 RVA: 0x000FB63C File Offset: 0x000F983C
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

		// Token: 0x0600B104 RID: 45316 RVA: 0x000FB64D File Offset: 0x000F984D
		public FKuroMovementSetting()
		{
		}

		// Token: 0x0600B105 RID: 45317 RVA: 0x000FB658 File Offset: 0x000F9858
		[NullableContext(1)]
		public FKuroMovementSetting(float Acceleration, float ControllerRotationSpeed, FKuroMovementRotationSetting ControllerRotationSpeedSetting, float FastSwimSpeed, float GroundFriction, UCurveVector MovementCurve, float NormalSwimSpeed, UCurveFloat RotationRateCurve, float RunSpeed, float SprintSpeed, float SwingAcceleration, float SwingSpeed, float WalkSpeed)
		{
			this.Acceleration = Acceleration;
			this.ControllerRotationSpeed = ControllerRotationSpeed;
			this.ControllerRotationSpeedSetting = ControllerRotationSpeedSetting;
			this.FastSwimSpeed = FastSwimSpeed;
			this.GroundFriction = GroundFriction;
			this.MovementCurve = MovementCurve;
			this.NormalSwimSpeed = NormalSwimSpeed;
			this.RotationRateCurve = RotationRateCurve;
			this.RunSpeed = RunSpeed;
			this.SprintSpeed = SprintSpeed;
			this.SwingAcceleration = SwingAcceleration;
			this.SwingSpeed = SwingSpeed;
			this.WalkSpeed = WalkSpeed;
		}

		// Token: 0x0600B106 RID: 45318 RVA: 0x000FB6D0 File Offset: 0x000F98D0
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMovementSetting.StaticStruct();
		}

		// Token: 0x0600B107 RID: 45319 RVA: 0x000FB6DC File Offset: 0x000F98DC
		public FKuroMovementSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B108 RID: 45320 RVA: 0x000FB6E6 File Offset: 0x000F98E6
		public FKuroMovementSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B109 RID: 45321 RVA: 0x000FB6F1 File Offset: 0x000F98F1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMovementSetting(Pointer, false, true);
		}

		// Token: 0x0600B10A RID: 45322 RVA: 0x000FB6FB File Offset: 0x000F98FB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMovementSetting(Pointer, MemoryOwner);
		}

		// Token: 0x04005CBA RID: 23738
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.KuroMovementSetting";

		// Token: 0x04005CBB RID: 23739
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005CBC RID: 23740
		internal static int __PropertyOffset_Acceleration;

		// Token: 0x04005CBD RID: 23741
		internal static int __PropertyOffset_ControllerRotationSpeed;

		// Token: 0x04005CBE RID: 23742
		internal static int __PropertyOffset_ControllerRotationSpeedSetting;

		// Token: 0x04005CBF RID: 23743
		internal static int __PropertyOffset_FastSwimSpeed;

		// Token: 0x04005CC0 RID: 23744
		internal static int __PropertyOffset_GroundFriction;

		// Token: 0x04005CC1 RID: 23745
		internal static int __PropertyOffset_MovementCurve;

		// Token: 0x04005CC2 RID: 23746
		internal static int __PropertyOffset_NormalSwimSpeed;

		// Token: 0x04005CC3 RID: 23747
		internal static int __PropertyOffset_RotationRateCurve;

		// Token: 0x04005CC4 RID: 23748
		internal static int __PropertyOffset_RunSpeed;

		// Token: 0x04005CC5 RID: 23749
		internal static int __PropertyOffset_SprintSpeed;

		// Token: 0x04005CC6 RID: 23750
		internal static int __PropertyOffset_SwingAcceleration;

		// Token: 0x04005CC7 RID: 23751
		internal static int __PropertyOffset_SwingSpeed;

		// Token: 0x04005CC8 RID: 23752
		internal static int __PropertyOffset_WalkSpeed;
	}
}
