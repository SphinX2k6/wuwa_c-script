using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016F8 RID: 5880
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBulletCore.KuroBulletDataTimeScale")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FKuroBulletDataTimeScale : FTableRowBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060153E5 RID: 87013 RVA: 0x001F3968 File Offset: 0x001F1B68
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroBulletDataTimeScale._ScriptStructPtr != 0) ? FKuroBulletDataTimeScale._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroBulletCore.KuroBulletDataTimeScale", ref FKuroBulletDataTimeScale._ScriptStructPtr);
		}

		// Token: 0x17005409 RID: 21513
		// (get) Token: 0x060153E6 RID: 87014 RVA: 0x001F398C File Offset: 0x001F1B8C
		// (set) Token: 0x060153E7 RID: 87015 RVA: 0x001F399C File Offset: 0x001F1B9C
		public unsafe bool FollowAttackTimeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBulletDataTimeScale.__PropertyOffset_FollowAttackTimeScale) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataTimeScale.__PropertyOffset_FollowAttackTimeScale) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700540A RID: 21514
		// (get) Token: 0x060153E8 RID: 87016 RVA: 0x001F39B0 File Offset: 0x001F1BB0
		// (set) Token: 0x060153E9 RID: 87017 RVA: 0x001F39F3 File Offset: 0x001F1BF3
		public FKuroBulletTimeScaleParam TimeScaleAttackerOnHit
		{
			get
			{
				base.FastCheckIsValid();
				FKuroBulletTimeScaleParam result;
				if ((result = this._TimeScaleAttackerOnHit) == null)
				{
					result = (this._TimeScaleAttackerOnHit = new FKuroBulletTimeScaleParam(base.NativePtr + (IntPtr)FKuroBulletDataTimeScale.__PropertyOffset_TimeScaleAttackerOnHit, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroBulletTimeScaleParam.StaticStruct(), base.NativePtr + (IntPtr)FKuroBulletDataTimeScale.__PropertyOffset_TimeScaleAttackerOnHit, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700540B RID: 21515
		// (get) Token: 0x060153EA RID: 87018 RVA: 0x001F3A14 File Offset: 0x001F1C14
		// (set) Token: 0x060153EB RID: 87019 RVA: 0x001F3A24 File Offset: 0x001F1C24
		public unsafe bool TimeScaleOnAttackIgnoreAttacker
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBulletDataTimeScale.__PropertyOffset_TimeScaleOnAttackIgnoreAttacker) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataTimeScale.__PropertyOffset_TimeScaleOnAttackIgnoreAttacker) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700540C RID: 21516
		// (get) Token: 0x060153EC RID: 87020 RVA: 0x001F3A38 File Offset: 0x001F1C38
		// (set) Token: 0x060153ED RID: 87021 RVA: 0x001F3A7B File Offset: 0x001F1C7B
		public FKuroBulletTimeScaleParam TimeScaleTargetOnHit
		{
			get
			{
				base.FastCheckIsValid();
				FKuroBulletTimeScaleParam result;
				if ((result = this._TimeScaleTargetOnHit) == null)
				{
					result = (this._TimeScaleTargetOnHit = new FKuroBulletTimeScaleParam(base.NativePtr + (IntPtr)FKuroBulletDataTimeScale.__PropertyOffset_TimeScaleTargetOnHit, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroBulletTimeScaleParam.StaticStruct(), base.NativePtr + (IntPtr)FKuroBulletDataTimeScale.__PropertyOffset_TimeScaleTargetOnHit, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700540D RID: 21517
		// (get) Token: 0x060153EE RID: 87022 RVA: 0x001F3A9C File Offset: 0x001F1C9C
		// (set) Token: 0x060153EF RID: 87023 RVA: 0x001F3AAC File Offset: 0x001F1CAC
		public unsafe bool RangeTimeScaleToEntity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBulletDataTimeScale.__PropertyOffset_RangeTimeScaleToEntity) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataTimeScale.__PropertyOffset_RangeTimeScaleToEntity) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700540E RID: 21518
		// (get) Token: 0x060153F0 RID: 87024 RVA: 0x001F3ABD File Offset: 0x001F1CBD
		// (set) Token: 0x060153F1 RID: 87025 RVA: 0x001F3ACD File Offset: 0x001F1CCD
		public unsafe bool RangeTimeScaleToBullet
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBulletDataTimeScale.__PropertyOffset_RangeTimeScaleToBullet) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletDataTimeScale.__PropertyOffset_RangeTimeScaleToBullet) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700540F RID: 21519
		// (get) Token: 0x060153F2 RID: 87026 RVA: 0x001F3AE0 File Offset: 0x001F1CE0
		// (set) Token: 0x060153F3 RID: 87027 RVA: 0x001F3B23 File Offset: 0x001F1D23
		public FKuroBulletTimeScaleParam RangeTimeScale
		{
			get
			{
				base.FastCheckIsValid();
				FKuroBulletTimeScaleParam result;
				if ((result = this._RangeTimeScale) == null)
				{
					result = (this._RangeTimeScale = new FKuroBulletTimeScaleParam(base.NativePtr + (IntPtr)FKuroBulletDataTimeScale.__PropertyOffset_RangeTimeScale, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroBulletTimeScaleParam.StaticStruct(), base.NativePtr + (IntPtr)FKuroBulletDataTimeScale.__PropertyOffset_RangeTimeScale, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060153F4 RID: 87028 RVA: 0x001F3B44 File Offset: 0x001F1D44
		public FKuroBulletDataTimeScale()
		{
		}

		// Token: 0x060153F5 RID: 87029 RVA: 0x001F3B4C File Offset: 0x001F1D4C
		public FKuroBulletDataTimeScale(bool FollowAttackTimeScale, FKuroBulletTimeScaleParam TimeScaleAttackerOnHit, bool TimeScaleOnAttackIgnoreAttacker, FKuroBulletTimeScaleParam TimeScaleTargetOnHit, bool RangeTimeScaleToEntity, bool RangeTimeScaleToBullet, FKuroBulletTimeScaleParam RangeTimeScale)
		{
			this.FollowAttackTimeScale = FollowAttackTimeScale;
			this.TimeScaleAttackerOnHit = TimeScaleAttackerOnHit;
			this.TimeScaleOnAttackIgnoreAttacker = TimeScaleOnAttackIgnoreAttacker;
			this.TimeScaleTargetOnHit = TimeScaleTargetOnHit;
			this.RangeTimeScaleToEntity = RangeTimeScaleToEntity;
			this.RangeTimeScaleToBullet = RangeTimeScaleToBullet;
			this.RangeTimeScale = RangeTimeScale;
		}

		// Token: 0x060153F6 RID: 87030 RVA: 0x001F3B89 File Offset: 0x001F1D89
		protected override IntPtr GetUStructPtr()
		{
			return FKuroBulletDataTimeScale.StaticStruct();
		}

		// Token: 0x060153F7 RID: 87031 RVA: 0x001F3B95 File Offset: 0x001F1D95
		[NullableContext(2)]
		public FKuroBulletDataTimeScale(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060153F8 RID: 87032 RVA: 0x001F3B9F File Offset: 0x001F1D9F
		public FKuroBulletDataTimeScale(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060153F9 RID: 87033 RVA: 0x001F3BAA File Offset: 0x001F1DAA
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroBulletDataTimeScale(Pointer, false, true);
		}

		// Token: 0x060153FA RID: 87034 RVA: 0x001F3BB4 File Offset: 0x001F1DB4
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroBulletDataTimeScale(Pointer, MemoryOwner);
		}

		// Token: 0x0400B955 RID: 47445
		public new const string __ObjectPath = "/Script/KuroBulletCore.KuroBulletDataTimeScale";

		// Token: 0x0400B956 RID: 47446
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B957 RID: 47447
		internal static int __PropertyOffset_FollowAttackTimeScale;

		// Token: 0x0400B958 RID: 47448
		internal static int __PropertyOffset_TimeScaleAttackerOnHit;

		// Token: 0x0400B959 RID: 47449
		[Nullable(2)]
		private FKuroBulletTimeScaleParam _TimeScaleAttackerOnHit;

		// Token: 0x0400B95A RID: 47450
		internal static int __PropertyOffset_TimeScaleOnAttackIgnoreAttacker;

		// Token: 0x0400B95B RID: 47451
		internal static int __PropertyOffset_TimeScaleTargetOnHit;

		// Token: 0x0400B95C RID: 47452
		[Nullable(2)]
		private FKuroBulletTimeScaleParam _TimeScaleTargetOnHit;

		// Token: 0x0400B95D RID: 47453
		internal static int __PropertyOffset_RangeTimeScaleToEntity;

		// Token: 0x0400B95E RID: 47454
		internal static int __PropertyOffset_RangeTimeScaleToBullet;

		// Token: 0x0400B95F RID: 47455
		internal static int __PropertyOffset_RangeTimeScale;

		// Token: 0x0400B960 RID: 47456
		[Nullable(2)]
		private FKuroBulletTimeScaleParam _RangeTimeScale;
	}
}
