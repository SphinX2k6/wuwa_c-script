using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020016F3 RID: 5875
	[UnrealObjectPath("/Script/KuroBulletCore.KuroBulletDataBase")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FKuroBulletDataBase : FTableRowBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015357 RID: 86871 RVA: 0x001F2D84 File Offset: 0x001F0F84
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroBulletDataBase._ScriptStructPtr != 0) ? FKuroBulletDataBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroBulletCore.KuroBulletDataBase", ref FKuroBulletDataBase._ScriptStructPtr);
		}

		// Token: 0x170053D6 RID: 21462
		// (get) Token: 0x06015358 RID: 86872 RVA: 0x001F2DA8 File Offset: 0x001F0FA8
		// (set) Token: 0x06015359 RID: 86873 RVA: 0x001F2DB8 File Offset: 0x001F0FB8
		public unsafe EKuroBulletShape Shape
		{
			get
			{
				return (EKuroBulletShape)(*(base.NativePtr + (IntPtr)FKuroBulletDataBase.__PropertyOffset_Shape));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataBase.__PropertyOffset_Shape) = (byte)value;
			}
		}

		// Token: 0x170053D7 RID: 21463
		// (get) Token: 0x0601535A RID: 86874 RVA: 0x001F2DC9 File Offset: 0x001F0FC9
		// (set) Token: 0x0601535B RID: 86875 RVA: 0x001F2DDD File Offset: 0x001F0FDD
		public unsafe FVector Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBulletDataBase.__PropertyOffset_Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataBase.__PropertyOffset_Size) = value;
			}
		}

		// Token: 0x170053D8 RID: 21464
		// (get) Token: 0x0601535C RID: 86876 RVA: 0x001F2DF2 File Offset: 0x001F0FF2
		// (set) Token: 0x0601535D RID: 86877 RVA: 0x001F2E06 File Offset: 0x001F1006
		public unsafe FRotator Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBulletDataBase.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataBase.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x170053D9 RID: 21465
		// (get) Token: 0x0601535E RID: 86878 RVA: 0x001F2E1B File Offset: 0x001F101B
		// (set) Token: 0x0601535F RID: 86879 RVA: 0x001F2E2B File Offset: 0x001F102B
		public unsafe EKuroBulletPositionStandard BornPositionStandard
		{
			get
			{
				return (EKuroBulletPositionStandard)(*(base.NativePtr + (IntPtr)FKuroBulletDataBase.__PropertyOffset_BornPositionStandard));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataBase.__PropertyOffset_BornPositionStandard) = (byte)value;
			}
		}

		// Token: 0x170053DA RID: 21466
		// (get) Token: 0x06015360 RID: 86880 RVA: 0x001F2E3C File Offset: 0x001F103C
		// (set) Token: 0x06015361 RID: 86881 RVA: 0x001F2E50 File Offset: 0x001F1050
		public unsafe FVector BornPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBulletDataBase.__PropertyOffset_BornPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataBase.__PropertyOffset_BornPosition) = value;
			}
		}

		// Token: 0x170053DB RID: 21467
		// (get) Token: 0x06015362 RID: 86882 RVA: 0x001F2E65 File Offset: 0x001F1065
		// (set) Token: 0x06015363 RID: 86883 RVA: 0x001F2E79 File Offset: 0x001F1079
		public unsafe FVector CenterOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBulletDataBase.__PropertyOffset_CenterOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataBase.__PropertyOffset_CenterOffset) = value;
			}
		}

		// Token: 0x170053DC RID: 21468
		// (get) Token: 0x06015364 RID: 86884 RVA: 0x001F2E8E File Offset: 0x001F108E
		// (set) Token: 0x06015365 RID: 86885 RVA: 0x001F2EA2 File Offset: 0x001F10A2
		public unsafe FVector BornPositionRandom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBulletDataBase.__PropertyOffset_BornPositionRandom);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataBase.__PropertyOffset_BornPositionRandom) = value;
			}
		}

		// Token: 0x170053DD RID: 21469
		// (get) Token: 0x06015366 RID: 86886 RVA: 0x001F2EB7 File Offset: 0x001F10B7
		// (set) Token: 0x06015367 RID: 86887 RVA: 0x001F2EC7 File Offset: 0x001F10C7
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBulletDataBase.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataBase.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x170053DE RID: 21470
		// (get) Token: 0x06015368 RID: 86888 RVA: 0x001F2ED8 File Offset: 0x001F10D8
		// (set) Token: 0x06015369 RID: 86889 RVA: 0x001F2EE8 File Offset: 0x001F10E8
		public unsafe float CollisionActiveDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBulletDataBase.__PropertyOffset_CollisionActiveDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataBase.__PropertyOffset_CollisionActiveDuration) = value;
			}
		}

		// Token: 0x170053DF RID: 21471
		// (get) Token: 0x0601536A RID: 86890 RVA: 0x001F2EF9 File Offset: 0x001F10F9
		// (set) Token: 0x0601536B RID: 86891 RVA: 0x001F2F09 File Offset: 0x001F1109
		public unsafe float CollisionActiveDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBulletDataBase.__PropertyOffset_CollisionActiveDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataBase.__PropertyOffset_CollisionActiveDelay) = value;
			}
		}

		// Token: 0x170053E0 RID: 21472
		// (get) Token: 0x0601536C RID: 86892 RVA: 0x001F2F1A File Offset: 0x001F111A
		// (set) Token: 0x0601536D RID: 86893 RVA: 0x001F2F2A File Offset: 0x001F112A
		public unsafe EKuroBulletHitType HitType
		{
			get
			{
				return (EKuroBulletHitType)(*(base.NativePtr + (IntPtr)FKuroBulletDataBase.__PropertyOffset_HitType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataBase.__PropertyOffset_HitType) = (byte)value;
			}
		}

		// Token: 0x170053E1 RID: 21473
		// (get) Token: 0x0601536E RID: 86894 RVA: 0x001F2F3B File Offset: 0x001F113B
		// (set) Token: 0x0601536F RID: 86895 RVA: 0x001F2F4F File Offset: 0x001F114F
		public unsafe FGameplayTag BanHitTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBulletDataBase.__PropertyOffset_BanHitTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataBase.__PropertyOffset_BanHitTag) = value;
			}
		}

		// Token: 0x170053E2 RID: 21474
		// (get) Token: 0x06015370 RID: 86896 RVA: 0x001F2F64 File Offset: 0x001F1164
		// (set) Token: 0x06015371 RID: 86897 RVA: 0x001F2F74 File Offset: 0x001F1174
		public unsafe int HitCountMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBulletDataBase.__PropertyOffset_HitCountMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataBase.__PropertyOffset_HitCountMax) = value;
			}
		}

		// Token: 0x170053E3 RID: 21475
		// (get) Token: 0x06015372 RID: 86898 RVA: 0x001F2F85 File Offset: 0x001F1185
		// (set) Token: 0x06015373 RID: 86899 RVA: 0x001F2F95 File Offset: 0x001F1195
		public unsafe int HitCountPerVictim
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBulletDataBase.__PropertyOffset_HitCountPerVictim);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataBase.__PropertyOffset_HitCountPerVictim) = value;
			}
		}

		// Token: 0x170053E4 RID: 21476
		// (get) Token: 0x06015374 RID: 86900 RVA: 0x001F2FA6 File Offset: 0x001F11A6
		// (set) Token: 0x06015375 RID: 86901 RVA: 0x001F2FB6 File Offset: 0x001F11B6
		public unsafe float Interval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBulletDataBase.__PropertyOffset_Interval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataBase.__PropertyOffset_Interval) = value;
			}
		}

		// Token: 0x170053E5 RID: 21477
		// (get) Token: 0x06015376 RID: 86902 RVA: 0x001F2FC7 File Offset: 0x001F11C7
		// (set) Token: 0x06015377 RID: 86903 RVA: 0x001F2FD7 File Offset: 0x001F11D7
		public unsafe long DamageId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBulletDataBase.__PropertyOffset_DamageId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataBase.__PropertyOffset_DamageId) = value;
			}
		}

		// Token: 0x170053E6 RID: 21478
		// (get) Token: 0x06015378 RID: 86904 RVA: 0x001F2FE8 File Offset: 0x001F11E8
		// (set) Token: 0x06015379 RID: 86905 RVA: 0x001F2FF8 File Offset: 0x001F11F8
		public unsafe bool ContinuesCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBulletDataBase.__PropertyOffset_ContinuesCollision) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataBase.__PropertyOffset_ContinuesCollision) = (value ? 1 : 0);
			}
		}

		// Token: 0x170053E7 RID: 21479
		// (get) Token: 0x0601537A RID: 86906 RVA: 0x001F3009 File Offset: 0x001F1209
		// (set) Token: 0x0601537B RID: 86907 RVA: 0x001F3019 File Offset: 0x001F1219
		public unsafe bool StickGround
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBulletDataBase.__PropertyOffset_StickGround) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataBase.__PropertyOffset_StickGround) = (value ? 1 : 0);
			}
		}

		// Token: 0x170053E8 RID: 21480
		// (get) Token: 0x0601537C RID: 86908 RVA: 0x001F302A File Offset: 0x001F122A
		// (set) Token: 0x0601537D RID: 86909 RVA: 0x001F303A File Offset: 0x001F123A
		public unsafe int BulletGroupId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBulletDataBase.__PropertyOffset_BulletGroupId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataBase.__PropertyOffset_BulletGroupId) = value;
			}
		}

		// Token: 0x170053E9 RID: 21481
		// (get) Token: 0x0601537E RID: 86910 RVA: 0x001F304B File Offset: 0x001F124B
		// (set) Token: 0x0601537F RID: 86911 RVA: 0x001F305B File Offset: 0x001F125B
		public unsafe bool HitObstacle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBulletDataBase.__PropertyOffset_HitObstacle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataBase.__PropertyOffset_HitObstacle) = (value ? 1 : 0);
			}
		}

		// Token: 0x06015380 RID: 86912 RVA: 0x001F306C File Offset: 0x001F126C
		public FKuroBulletDataBase()
		{
		}

		// Token: 0x06015381 RID: 86913 RVA: 0x001F3074 File Offset: 0x001F1274
		public FKuroBulletDataBase(EKuroBulletShape Shape, FVector Size, FRotator Rotation, EKuroBulletPositionStandard BornPositionStandard, FVector BornPosition, FVector CenterOffset, FVector BornPositionRandom, float Duration, float CollisionActiveDuration, float CollisionActiveDelay, EKuroBulletHitType HitType, FGameplayTag BanHitTag, int HitCountMax, int HitCountPerVictim, float Interval, long DamageId, bool ContinuesCollision, bool StickGround, int BulletGroupId, bool HitObstacle)
		{
			this.Shape = Shape;
			this.Size = Size;
			this.Rotation = Rotation;
			this.BornPositionStandard = BornPositionStandard;
			this.BornPosition = BornPosition;
			this.CenterOffset = CenterOffset;
			this.BornPositionRandom = BornPositionRandom;
			this.Duration = Duration;
			this.CollisionActiveDuration = CollisionActiveDuration;
			this.CollisionActiveDelay = CollisionActiveDelay;
			this.HitType = HitType;
			this.BanHitTag = BanHitTag;
			this.HitCountMax = HitCountMax;
			this.HitCountPerVictim = HitCountPerVictim;
			this.Interval = Interval;
			this.DamageId = DamageId;
			this.ContinuesCollision = ContinuesCollision;
			this.StickGround = StickGround;
			this.BulletGroupId = BulletGroupId;
			this.HitObstacle = HitObstacle;
		}

		// Token: 0x06015382 RID: 86914 RVA: 0x001F3124 File Offset: 0x001F1324
		protected override IntPtr GetUStructPtr()
		{
			return FKuroBulletDataBase.StaticStruct();
		}

		// Token: 0x06015383 RID: 86915 RVA: 0x001F3130 File Offset: 0x001F1330
		[NullableContext(2)]
		public FKuroBulletDataBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015384 RID: 86916 RVA: 0x001F313A File Offset: 0x001F133A
		public FKuroBulletDataBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015385 RID: 86917 RVA: 0x001F3145 File Offset: 0x001F1345
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroBulletDataBase(Pointer, false, true);
		}

		// Token: 0x06015386 RID: 86918 RVA: 0x001F314F File Offset: 0x001F134F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroBulletDataBase(Pointer, MemoryOwner);
		}

		// Token: 0x0400B912 RID: 47378
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBulletCore.KuroBulletDataBase";

		// Token: 0x0400B913 RID: 47379
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B914 RID: 47380
		internal static int __PropertyOffset_Shape;

		// Token: 0x0400B915 RID: 47381
		internal static int __PropertyOffset_Size;

		// Token: 0x0400B916 RID: 47382
		internal static int __PropertyOffset_Rotation;

		// Token: 0x0400B917 RID: 47383
		internal static int __PropertyOffset_BornPositionStandard;

		// Token: 0x0400B918 RID: 47384
		internal static int __PropertyOffset_BornPosition;

		// Token: 0x0400B919 RID: 47385
		internal static int __PropertyOffset_CenterOffset;

		// Token: 0x0400B91A RID: 47386
		internal static int __PropertyOffset_BornPositionRandom;

		// Token: 0x0400B91B RID: 47387
		internal static int __PropertyOffset_Duration;

		// Token: 0x0400B91C RID: 47388
		internal static int __PropertyOffset_CollisionActiveDuration;

		// Token: 0x0400B91D RID: 47389
		internal static int __PropertyOffset_CollisionActiveDelay;

		// Token: 0x0400B91E RID: 47390
		internal static int __PropertyOffset_HitType;

		// Token: 0x0400B91F RID: 47391
		internal static int __PropertyOffset_BanHitTag;

		// Token: 0x0400B920 RID: 47392
		internal static int __PropertyOffset_HitCountMax;

		// Token: 0x0400B921 RID: 47393
		internal static int __PropertyOffset_HitCountPerVictim;

		// Token: 0x0400B922 RID: 47394
		internal static int __PropertyOffset_Interval;

		// Token: 0x0400B923 RID: 47395
		internal static int __PropertyOffset_DamageId;

		// Token: 0x0400B924 RID: 47396
		internal static int __PropertyOffset_ContinuesCollision;

		// Token: 0x0400B925 RID: 47397
		internal static int __PropertyOffset_StickGround;

		// Token: 0x0400B926 RID: 47398
		internal static int __PropertyOffset_BulletGroupId;

		// Token: 0x0400B927 RID: 47399
		internal static int __PropertyOffset_HitObstacle;
	}
}
