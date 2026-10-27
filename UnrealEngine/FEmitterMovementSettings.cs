using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016EA RID: 5866
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBulletCore.EmitterMovementSettings")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 168)]
	public class FEmitterMovementSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060152DB RID: 86747 RVA: 0x001F211A File Offset: 0x001F031A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEmitterMovementSettings._ScriptStructPtr != 0) ? FEmitterMovementSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroBulletCore.EmitterMovementSettings", ref FEmitterMovementSettings._ScriptStructPtr);
		}

		// Token: 0x170053B6 RID: 21430
		// (get) Token: 0x060152DC RID: 86748 RVA: 0x001F213E File Offset: 0x001F033E
		// (set) Token: 0x060152DD RID: 86749 RVA: 0x001F214E File Offset: 0x001F034E
		public unsafe EKuroBulletFollowType FollowType
		{
			get
			{
				return (EKuroBulletFollowType)(*(base.NativePtr + (IntPtr)FEmitterMovementSettings.__PropertyOffset_FollowType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEmitterMovementSettings.__PropertyOffset_FollowType) = (byte)value;
			}
		}

		// Token: 0x170053B7 RID: 21431
		// (get) Token: 0x060152DE RID: 86750 RVA: 0x001F215F File Offset: 0x001F035F
		// (set) Token: 0x060152DF RID: 86751 RVA: 0x001F2173 File Offset: 0x001F0373
		public unsafe FName SocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEmitterMovementSettings.__PropertyOffset_SocketName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEmitterMovementSettings.__PropertyOffset_SocketName) = value;
			}
		}

		// Token: 0x170053B8 RID: 21432
		// (get) Token: 0x060152E0 RID: 86752 RVA: 0x001F2188 File Offset: 0x001F0388
		// (set) Token: 0x060152E1 RID: 86753 RVA: 0x001F2198 File Offset: 0x001F0398
		public unsafe EKuroBulletInitVelocityDirection MoveDirectionBase
		{
			get
			{
				return (EKuroBulletInitVelocityDirection)(*(base.NativePtr + (IntPtr)FEmitterMovementSettings.__PropertyOffset_MoveDirectionBase));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEmitterMovementSettings.__PropertyOffset_MoveDirectionBase) = (byte)value;
			}
		}

		// Token: 0x170053B9 RID: 21433
		// (get) Token: 0x060152E2 RID: 86754 RVA: 0x001F21A9 File Offset: 0x001F03A9
		// (set) Token: 0x060152E3 RID: 86755 RVA: 0x001F21BD File Offset: 0x001F03BD
		public unsafe FRotator MoveDirectionOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEmitterMovementSettings.__PropertyOffset_MoveDirectionOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEmitterMovementSettings.__PropertyOffset_MoveDirectionOffset) = value;
			}
		}

		// Token: 0x170053BA RID: 21434
		// (get) Token: 0x060152E4 RID: 86756 RVA: 0x001F21D2 File Offset: 0x001F03D2
		// (set) Token: 0x060152E5 RID: 86757 RVA: 0x001F21E2 File Offset: 0x001F03E2
		public unsafe float Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEmitterMovementSettings.__PropertyOffset_Speed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEmitterMovementSettings.__PropertyOffset_Speed) = value;
			}
		}

		// Token: 0x170053BB RID: 21435
		// (get) Token: 0x060152E6 RID: 86758 RVA: 0x001F21F3 File Offset: 0x001F03F3
		// (set) Token: 0x060152E7 RID: 86759 RVA: 0x001F2207 File Offset: 0x001F0407
		[Nullable(2)]
		public unsafe UCurveFloat SpeedCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FEmitterMovementSettings.__PropertyOffset_SpeedCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FEmitterMovementSettings.__PropertyOffset_SpeedCurve, value);
			}
		}

		// Token: 0x170053BC RID: 21436
		// (get) Token: 0x060152E8 RID: 86760 RVA: 0x001F221C File Offset: 0x001F041C
		// (set) Token: 0x060152E9 RID: 86761 RVA: 0x001F222C File Offset: 0x001F042C
		public unsafe EKuroBulletMoveTrajectory Trajectory
		{
			get
			{
				return (EKuroBulletMoveTrajectory)(*(base.NativePtr + (IntPtr)FEmitterMovementSettings.__PropertyOffset_Trajectory));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEmitterMovementSettings.__PropertyOffset_Trajectory) = (byte)value;
			}
		}

		// Token: 0x170053BD RID: 21437
		// (get) Token: 0x060152EA RID: 86762 RVA: 0x001F223D File Offset: 0x001F043D
		// (set) Token: 0x060152EB RID: 86763 RVA: 0x001F224D File Offset: 0x001F044D
		public unsafe EKuroBulletTarget TrackTarget
		{
			get
			{
				return (EKuroBulletTarget)(*(base.NativePtr + (IntPtr)FEmitterMovementSettings.__PropertyOffset_TrackTarget));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEmitterMovementSettings.__PropertyOffset_TrackTarget) = (byte)value;
			}
		}

		// Token: 0x170053BE RID: 21438
		// (get) Token: 0x060152EC RID: 86764 RVA: 0x001F2260 File Offset: 0x001F0460
		// (set) Token: 0x060152ED RID: 86765 RVA: 0x001F22A3 File Offset: 0x001F04A3
		public TArray<FVector> TrackParams
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._TrackParams) == null)
				{
					result = (this._TrackParams = new TArray<FVector>(base.NativePtr + (IntPtr)FEmitterMovementSettings.__PropertyOffset_TrackParams, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TrackParams.CopyAssign(value);
			}
		}

		// Token: 0x170053BF RID: 21439
		// (get) Token: 0x060152EE RID: 86766 RVA: 0x001F22B4 File Offset: 0x001F04B4
		// (set) Token: 0x060152EF RID: 86767 RVA: 0x001F22F7 File Offset: 0x001F04F7
		public TMap<int, UCurveFloat> TrackParamCurves
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, UCurveFloat> result;
				if ((result = this._TrackParamCurves) == null)
				{
					result = (this._TrackParamCurves = new TMap<int, UCurveFloat>(base.NativePtr + (IntPtr)FEmitterMovementSettings.__PropertyOffset_TrackParamCurves, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TrackParamCurves.CopyAssign(value);
			}
		}

		// Token: 0x170053C0 RID: 21440
		// (get) Token: 0x060152F0 RID: 86768 RVA: 0x001F2305 File Offset: 0x001F0505
		// (set) Token: 0x060152F1 RID: 86769 RVA: 0x001F2319 File Offset: 0x001F0519
		public unsafe FRotator SelfRotationRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEmitterMovementSettings.__PropertyOffset_SelfRotationRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEmitterMovementSettings.__PropertyOffset_SelfRotationRate) = value;
			}
		}

		// Token: 0x060152F2 RID: 86770 RVA: 0x001F232E File Offset: 0x001F052E
		public FEmitterMovementSettings()
		{
		}

		// Token: 0x060152F3 RID: 86771 RVA: 0x001F2338 File Offset: 0x001F0538
		public FEmitterMovementSettings(EKuroBulletFollowType FollowType, FName SocketName, EKuroBulletInitVelocityDirection MoveDirectionBase, FRotator MoveDirectionOffset, float Speed, UCurveFloat SpeedCurve, EKuroBulletMoveTrajectory Trajectory, EKuroBulletTarget TrackTarget, TArray<FVector> TrackParams, TMap<int, UCurveFloat> TrackParamCurves, FRotator SelfRotationRate)
		{
			this.FollowType = FollowType;
			this.SocketName = SocketName;
			this.MoveDirectionBase = MoveDirectionBase;
			this.MoveDirectionOffset = MoveDirectionOffset;
			this.Speed = Speed;
			this.SpeedCurve = SpeedCurve;
			this.Trajectory = Trajectory;
			this.TrackTarget = TrackTarget;
			this.TrackParams = TrackParams;
			this.TrackParamCurves = TrackParamCurves;
			this.SelfRotationRate = SelfRotationRate;
		}

		// Token: 0x060152F4 RID: 86772 RVA: 0x001F23A0 File Offset: 0x001F05A0
		protected override IntPtr GetUStructPtr()
		{
			return FEmitterMovementSettings.StaticStruct();
		}

		// Token: 0x060152F5 RID: 86773 RVA: 0x001F23AC File Offset: 0x001F05AC
		[NullableContext(2)]
		public FEmitterMovementSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060152F6 RID: 86774 RVA: 0x001F23B6 File Offset: 0x001F05B6
		public FEmitterMovementSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060152F7 RID: 86775 RVA: 0x001F23C1 File Offset: 0x001F05C1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEmitterMovementSettings(Pointer, false, true);
		}

		// Token: 0x060152F8 RID: 86776 RVA: 0x001F23CB File Offset: 0x001F05CB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEmitterMovementSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0400B8C8 RID: 47304
		public const string __ObjectPath = "/Script/KuroBulletCore.EmitterMovementSettings";

		// Token: 0x0400B8C9 RID: 47305
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B8CA RID: 47306
		internal static int __PropertyOffset_FollowType;

		// Token: 0x0400B8CB RID: 47307
		internal static int __PropertyOffset_SocketName;

		// Token: 0x0400B8CC RID: 47308
		internal static int __PropertyOffset_MoveDirectionBase;

		// Token: 0x0400B8CD RID: 47309
		internal static int __PropertyOffset_MoveDirectionOffset;

		// Token: 0x0400B8CE RID: 47310
		internal static int __PropertyOffset_Speed;

		// Token: 0x0400B8CF RID: 47311
		internal static int __PropertyOffset_SpeedCurve;

		// Token: 0x0400B8D0 RID: 47312
		internal static int __PropertyOffset_Trajectory;

		// Token: 0x0400B8D1 RID: 47313
		internal static int __PropertyOffset_TrackTarget;

		// Token: 0x0400B8D2 RID: 47314
		internal static int __PropertyOffset_TrackParams;

		// Token: 0x0400B8D3 RID: 47315
		[Nullable(2)]
		private TArray<FVector> _TrackParams;

		// Token: 0x0400B8D4 RID: 47316
		internal static int __PropertyOffset_TrackParamCurves;

		// Token: 0x0400B8D5 RID: 47317
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, UCurveFloat> _TrackParamCurves;

		// Token: 0x0400B8D6 RID: 47318
		internal static int __PropertyOffset_SelfRotationRate;
	}
}
