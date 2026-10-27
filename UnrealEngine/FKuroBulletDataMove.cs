using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016F6 RID: 5878
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBulletCore.KuroBulletDataMove")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FKuroBulletDataMove : FTableRowBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060153AF RID: 86959 RVA: 0x001F34AA File Offset: 0x001F16AA
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroBulletDataMove._ScriptStructPtr != 0) ? FKuroBulletDataMove._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroBulletCore.KuroBulletDataMove", ref FKuroBulletDataMove._ScriptStructPtr);
		}

		// Token: 0x170053F6 RID: 21494
		// (get) Token: 0x060153B0 RID: 86960 RVA: 0x001F34CE File Offset: 0x001F16CE
		// (set) Token: 0x060153B1 RID: 86961 RVA: 0x001F34DE File Offset: 0x001F16DE
		public unsafe EKuroBulletFollowType FollowType
		{
			get
			{
				return (EKuroBulletFollowType)(*(base.NativePtr + (IntPtr)FKuroBulletDataMove.__PropertyOffset_FollowType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataMove.__PropertyOffset_FollowType) = (byte)value;
			}
		}

		// Token: 0x170053F7 RID: 21495
		// (get) Token: 0x060153B2 RID: 86962 RVA: 0x001F34EF File Offset: 0x001F16EF
		// (set) Token: 0x060153B3 RID: 86963 RVA: 0x001F34FF File Offset: 0x001F16FF
		public unsafe EKuroBulletInitVelocityDirection InitVelocityDirStandard
		{
			get
			{
				return (EKuroBulletInitVelocityDirection)(*(base.NativePtr + (IntPtr)FKuroBulletDataMove.__PropertyOffset_InitVelocityDirStandard));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataMove.__PropertyOffset_InitVelocityDirStandard) = (byte)value;
			}
		}

		// Token: 0x170053F8 RID: 21496
		// (get) Token: 0x060153B4 RID: 86964 RVA: 0x001F3510 File Offset: 0x001F1710
		// (set) Token: 0x060153B5 RID: 86965 RVA: 0x001F3524 File Offset: 0x001F1724
		public unsafe FRotator InitVelocityRot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBulletDataMove.__PropertyOffset_InitVelocityRot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataMove.__PropertyOffset_InitVelocityRot) = value;
			}
		}

		// Token: 0x170053F9 RID: 21497
		// (get) Token: 0x060153B6 RID: 86966 RVA: 0x001F3539 File Offset: 0x001F1739
		// (set) Token: 0x060153B7 RID: 86967 RVA: 0x001F354D File Offset: 0x001F174D
		public unsafe FVector InitVelocityDirRandom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBulletDataMove.__PropertyOffset_InitVelocityDirRandom);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataMove.__PropertyOffset_InitVelocityDirRandom) = value;
			}
		}

		// Token: 0x170053FA RID: 21498
		// (get) Token: 0x060153B8 RID: 86968 RVA: 0x001F3562 File Offset: 0x001F1762
		// (set) Token: 0x060153B9 RID: 86969 RVA: 0x001F3572 File Offset: 0x001F1772
		public unsafe float Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBulletDataMove.__PropertyOffset_Speed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataMove.__PropertyOffset_Speed) = value;
			}
		}

		// Token: 0x170053FB RID: 21499
		// (get) Token: 0x060153BA RID: 86970 RVA: 0x001F3583 File Offset: 0x001F1783
		// (set) Token: 0x060153BB RID: 86971 RVA: 0x001F3597 File Offset: 0x001F1797
		[Nullable(2)]
		public unsafe UCurveFloat SpeedCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroBulletDataMove.__PropertyOffset_SpeedCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroBulletDataMove.__PropertyOffset_SpeedCurve, value);
			}
		}

		// Token: 0x170053FC RID: 21500
		// (get) Token: 0x060153BC RID: 86972 RVA: 0x001F35AC File Offset: 0x001F17AC
		// (set) Token: 0x060153BD RID: 86973 RVA: 0x001F35BC File Offset: 0x001F17BC
		public unsafe EKuroBulletTarget TrackTarget
		{
			get
			{
				return (EKuroBulletTarget)(*(base.NativePtr + (IntPtr)FKuroBulletDataMove.__PropertyOffset_TrackTarget));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataMove.__PropertyOffset_TrackTarget) = (byte)value;
			}
		}

		// Token: 0x170053FD RID: 21501
		// (get) Token: 0x060153BE RID: 86974 RVA: 0x001F35CD File Offset: 0x001F17CD
		// (set) Token: 0x060153BF RID: 86975 RVA: 0x001F35DD File Offset: 0x001F17DD
		public unsafe EKuroBulletMoveTrajectory Trajectory
		{
			get
			{
				return (EKuroBulletMoveTrajectory)(*(base.NativePtr + (IntPtr)FKuroBulletDataMove.__PropertyOffset_Trajectory));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataMove.__PropertyOffset_Trajectory) = (byte)value;
			}
		}

		// Token: 0x170053FE RID: 21502
		// (get) Token: 0x060153C0 RID: 86976 RVA: 0x001F35F0 File Offset: 0x001F17F0
		// (set) Token: 0x060153C1 RID: 86977 RVA: 0x001F3633 File Offset: 0x001F1833
		public TArray<FVector> TrackParams
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._TrackParams) == null)
				{
					result = (this._TrackParams = new TArray<FVector>(base.NativePtr + (IntPtr)FKuroBulletDataMove.__PropertyOffset_TrackParams, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TrackParams.CopyAssign(value);
			}
		}

		// Token: 0x170053FF RID: 21503
		// (get) Token: 0x060153C2 RID: 86978 RVA: 0x001F3641 File Offset: 0x001F1841
		// (set) Token: 0x060153C3 RID: 86979 RVA: 0x001F3651 File Offset: 0x001F1851
		public unsafe bool InitVelocityKeepUp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBulletDataMove.__PropertyOffset_InitVelocityKeepUp) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataMove.__PropertyOffset_InitVelocityKeepUp) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005400 RID: 21504
		// (get) Token: 0x060153C4 RID: 86980 RVA: 0x001F3662 File Offset: 0x001F1862
		// (set) Token: 0x060153C5 RID: 86981 RVA: 0x001F3672 File Offset: 0x001F1872
		public unsafe bool IsFollowSceneMove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBulletDataMove.__PropertyOffset_IsFollowSceneMove) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataMove.__PropertyOffset_IsFollowSceneMove) = (value ? 1 : 0);
			}
		}

		// Token: 0x060153C6 RID: 86982 RVA: 0x001F3683 File Offset: 0x001F1883
		public FKuroBulletDataMove()
		{
		}

		// Token: 0x060153C7 RID: 86983 RVA: 0x001F368C File Offset: 0x001F188C
		public FKuroBulletDataMove(EKuroBulletFollowType FollowType, EKuroBulletInitVelocityDirection InitVelocityDirStandard, FRotator InitVelocityRot, FVector InitVelocityDirRandom, float Speed, UCurveFloat SpeedCurve, EKuroBulletTarget TrackTarget, EKuroBulletMoveTrajectory Trajectory, TArray<FVector> TrackParams, bool InitVelocityKeepUp, bool IsFollowSceneMove)
		{
			this.FollowType = FollowType;
			this.InitVelocityDirStandard = InitVelocityDirStandard;
			this.InitVelocityRot = InitVelocityRot;
			this.InitVelocityDirRandom = InitVelocityDirRandom;
			this.Speed = Speed;
			this.SpeedCurve = SpeedCurve;
			this.TrackTarget = TrackTarget;
			this.Trajectory = Trajectory;
			this.TrackParams = TrackParams;
			this.InitVelocityKeepUp = InitVelocityKeepUp;
			this.IsFollowSceneMove = IsFollowSceneMove;
		}

		// Token: 0x060153C8 RID: 86984 RVA: 0x001F36F4 File Offset: 0x001F18F4
		protected override IntPtr GetUStructPtr()
		{
			return FKuroBulletDataMove.StaticStruct();
		}

		// Token: 0x060153C9 RID: 86985 RVA: 0x001F3700 File Offset: 0x001F1900
		[NullableContext(2)]
		public FKuroBulletDataMove(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060153CA RID: 86986 RVA: 0x001F370A File Offset: 0x001F190A
		public FKuroBulletDataMove(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060153CB RID: 86987 RVA: 0x001F3715 File Offset: 0x001F1915
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroBulletDataMove(Pointer, false, true);
		}

		// Token: 0x060153CC RID: 86988 RVA: 0x001F371F File Offset: 0x001F191F
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroBulletDataMove(Pointer, MemoryOwner);
		}

		// Token: 0x0400B93B RID: 47419
		public new const string __ObjectPath = "/Script/KuroBulletCore.KuroBulletDataMove";

		// Token: 0x0400B93C RID: 47420
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B93D RID: 47421
		internal static int __PropertyOffset_FollowType;

		// Token: 0x0400B93E RID: 47422
		internal static int __PropertyOffset_InitVelocityDirStandard;

		// Token: 0x0400B93F RID: 47423
		internal static int __PropertyOffset_InitVelocityRot;

		// Token: 0x0400B940 RID: 47424
		internal static int __PropertyOffset_InitVelocityDirRandom;

		// Token: 0x0400B941 RID: 47425
		internal static int __PropertyOffset_Speed;

		// Token: 0x0400B942 RID: 47426
		internal static int __PropertyOffset_SpeedCurve;

		// Token: 0x0400B943 RID: 47427
		internal static int __PropertyOffset_TrackTarget;

		// Token: 0x0400B944 RID: 47428
		internal static int __PropertyOffset_Trajectory;

		// Token: 0x0400B945 RID: 47429
		internal static int __PropertyOffset_TrackParams;

		// Token: 0x0400B946 RID: 47430
		[Nullable(2)]
		private TArray<FVector> _TrackParams;

		// Token: 0x0400B947 RID: 47431
		internal static int __PropertyOffset_InitVelocityKeepUp;

		// Token: 0x0400B948 RID: 47432
		internal static int __PropertyOffset_IsFollowSceneMove;
	}
}
