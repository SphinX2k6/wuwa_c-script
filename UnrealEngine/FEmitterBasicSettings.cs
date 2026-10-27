using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020016E8 RID: 5864
	[UnrealObjectPath("/Script/KuroBulletCore.EmitterBasicSettings")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FEmitterBasicSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060152AD RID: 86701 RVA: 0x001F1D46 File Offset: 0x001EFF46
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEmitterBasicSettings._ScriptStructPtr != 0) ? FEmitterBasicSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroBulletCore.EmitterBasicSettings", ref FEmitterBasicSettings._ScriptStructPtr);
		}

		// Token: 0x170053A7 RID: 21415
		// (get) Token: 0x060152AE RID: 86702 RVA: 0x001F1D6A File Offset: 0x001EFF6A
		// (set) Token: 0x060152AF RID: 86703 RVA: 0x001F1D7A File Offset: 0x001EFF7A
		public unsafe EEmitterSpawnPositionBase SpawnPositionBase
		{
			get
			{
				return (EEmitterSpawnPositionBase)(*(base.NativePtr + (IntPtr)FEmitterBasicSettings.__PropertyOffset_SpawnPositionBase));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEmitterBasicSettings.__PropertyOffset_SpawnPositionBase) = (byte)value;
			}
		}

		// Token: 0x170053A8 RID: 21416
		// (get) Token: 0x060152B0 RID: 86704 RVA: 0x001F1D8B File Offset: 0x001EFF8B
		// (set) Token: 0x060152B1 RID: 86705 RVA: 0x001F1D9F File Offset: 0x001EFF9F
		public unsafe FVector SpawnPositionOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEmitterBasicSettings.__PropertyOffset_SpawnPositionOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEmitterBasicSettings.__PropertyOffset_SpawnPositionOffset) = value;
			}
		}

		// Token: 0x170053A9 RID: 21417
		// (get) Token: 0x060152B2 RID: 86706 RVA: 0x001F1DB4 File Offset: 0x001EFFB4
		// (set) Token: 0x060152B3 RID: 86707 RVA: 0x001F1DC4 File Offset: 0x001EFFC4
		public unsafe EEmitterInitialRotationBase InitialRotationBase
		{
			get
			{
				return (EEmitterInitialRotationBase)(*(base.NativePtr + (IntPtr)FEmitterBasicSettings.__PropertyOffset_InitialRotationBase));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEmitterBasicSettings.__PropertyOffset_InitialRotationBase) = (byte)value;
			}
		}

		// Token: 0x170053AA RID: 21418
		// (get) Token: 0x060152B4 RID: 86708 RVA: 0x001F1DD5 File Offset: 0x001EFFD5
		// (set) Token: 0x060152B5 RID: 86709 RVA: 0x001F1DE9 File Offset: 0x001EFFE9
		public unsafe FRotator InitialRotationOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEmitterBasicSettings.__PropertyOffset_InitialRotationOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEmitterBasicSettings.__PropertyOffset_InitialRotationOffset) = value;
			}
		}

		// Token: 0x170053AB RID: 21419
		// (get) Token: 0x060152B6 RID: 86710 RVA: 0x001F1DFE File Offset: 0x001EFFFE
		// (set) Token: 0x060152B7 RID: 86711 RVA: 0x001F1E0E File Offset: 0x001F000E
		public unsafe float StartDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEmitterBasicSettings.__PropertyOffset_StartDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEmitterBasicSettings.__PropertyOffset_StartDelay) = value;
			}
		}

		// Token: 0x170053AC RID: 21420
		// (get) Token: 0x060152B8 RID: 86712 RVA: 0x001F1E1F File Offset: 0x001F001F
		// (set) Token: 0x060152B9 RID: 86713 RVA: 0x001F1E2F File Offset: 0x001F002F
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEmitterBasicSettings.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEmitterBasicSettings.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x170053AD RID: 21421
		// (get) Token: 0x060152BA RID: 86714 RVA: 0x001F1E40 File Offset: 0x001F0040
		// (set) Token: 0x060152BB RID: 86715 RVA: 0x001F1E50 File Offset: 0x001F0050
		public unsafe float FireInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEmitterBasicSettings.__PropertyOffset_FireInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEmitterBasicSettings.__PropertyOffset_FireInterval) = value;
			}
		}

		// Token: 0x170053AE RID: 21422
		// (get) Token: 0x060152BC RID: 86716 RVA: 0x001F1E61 File Offset: 0x001F0061
		// (set) Token: 0x060152BD RID: 86717 RVA: 0x001F1E71 File Offset: 0x001F0071
		public unsafe int MaxFireCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEmitterBasicSettings.__PropertyOffset_MaxFireCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEmitterBasicSettings.__PropertyOffset_MaxFireCount) = value;
			}
		}

		// Token: 0x170053AF RID: 21423
		// (get) Token: 0x060152BE RID: 86718 RVA: 0x001F1E82 File Offset: 0x001F0082
		// (set) Token: 0x060152BF RID: 86719 RVA: 0x001F1E92 File Offset: 0x001F0092
		public unsafe long BulletId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEmitterBasicSettings.__PropertyOffset_BulletId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEmitterBasicSettings.__PropertyOffset_BulletId) = value;
			}
		}

		// Token: 0x170053B0 RID: 21424
		// (get) Token: 0x060152C0 RID: 86720 RVA: 0x001F1EA3 File Offset: 0x001F00A3
		// (set) Token: 0x060152C1 RID: 86721 RVA: 0x001F1EB3 File Offset: 0x001F00B3
		public unsafe int NumPerShot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEmitterBasicSettings.__PropertyOffset_NumPerShot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEmitterBasicSettings.__PropertyOffset_NumPerShot) = value;
			}
		}

		// Token: 0x170053B1 RID: 21425
		// (get) Token: 0x060152C2 RID: 86722 RVA: 0x001F1EC4 File Offset: 0x001F00C4
		// (set) Token: 0x060152C3 RID: 86723 RVA: 0x001F1ED4 File Offset: 0x001F00D4
		public unsafe bool bKeepFormation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEmitterBasicSettings.__PropertyOffset_bKeepFormation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEmitterBasicSettings.__PropertyOffset_bKeepFormation) = (value ? 1 : 0);
			}
		}

		// Token: 0x170053B2 RID: 21426
		// (get) Token: 0x060152C4 RID: 86724 RVA: 0x001F1EE5 File Offset: 0x001F00E5
		// (set) Token: 0x060152C5 RID: 86725 RVA: 0x001F1EF5 File Offset: 0x001F00F5
		public unsafe EInheritedVelocityMode InheritedVelocityMode
		{
			get
			{
				return (EInheritedVelocityMode)(*(base.NativePtr + (IntPtr)FEmitterBasicSettings.__PropertyOffset_InheritedVelocityMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEmitterBasicSettings.__PropertyOffset_InheritedVelocityMode) = (byte)value;
			}
		}

		// Token: 0x170053B3 RID: 21427
		// (get) Token: 0x060152C6 RID: 86726 RVA: 0x001F1F06 File Offset: 0x001F0106
		// (set) Token: 0x060152C7 RID: 86727 RVA: 0x001F1F16 File Offset: 0x001F0116
		public unsafe float InheritVelocityFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEmitterBasicSettings.__PropertyOffset_InheritVelocityFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEmitterBasicSettings.__PropertyOffset_InheritVelocityFactor) = value;
			}
		}

		// Token: 0x060152C8 RID: 86728 RVA: 0x001F1F27 File Offset: 0x001F0127
		public FEmitterBasicSettings()
		{
		}

		// Token: 0x060152C9 RID: 86729 RVA: 0x001F1F30 File Offset: 0x001F0130
		public FEmitterBasicSettings(EEmitterSpawnPositionBase SpawnPositionBase, FVector SpawnPositionOffset, EEmitterInitialRotationBase InitialRotationBase, FRotator InitialRotationOffset, float StartDelay, float Duration, float FireInterval, int MaxFireCount, long BulletId, int NumPerShot, bool bKeepFormation, EInheritedVelocityMode InheritedVelocityMode, float InheritVelocityFactor)
		{
			this.SpawnPositionBase = SpawnPositionBase;
			this.SpawnPositionOffset = SpawnPositionOffset;
			this.InitialRotationBase = InitialRotationBase;
			this.InitialRotationOffset = InitialRotationOffset;
			this.StartDelay = StartDelay;
			this.Duration = Duration;
			this.FireInterval = FireInterval;
			this.MaxFireCount = MaxFireCount;
			this.BulletId = BulletId;
			this.NumPerShot = NumPerShot;
			this.bKeepFormation = bKeepFormation;
			this.InheritedVelocityMode = InheritedVelocityMode;
			this.InheritVelocityFactor = InheritVelocityFactor;
		}

		// Token: 0x060152CA RID: 86730 RVA: 0x001F1FA8 File Offset: 0x001F01A8
		protected override IntPtr GetUStructPtr()
		{
			return FEmitterBasicSettings.StaticStruct();
		}

		// Token: 0x060152CB RID: 86731 RVA: 0x001F1FB4 File Offset: 0x001F01B4
		[NullableContext(2)]
		public FEmitterBasicSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060152CC RID: 86732 RVA: 0x001F1FBE File Offset: 0x001F01BE
		public FEmitterBasicSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060152CD RID: 86733 RVA: 0x001F1FC9 File Offset: 0x001F01C9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEmitterBasicSettings(Pointer, false, true);
		}

		// Token: 0x060152CE RID: 86734 RVA: 0x001F1FD3 File Offset: 0x001F01D3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEmitterBasicSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0400B8B3 RID: 47283
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroBulletCore.EmitterBasicSettings";

		// Token: 0x0400B8B4 RID: 47284
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B8B5 RID: 47285
		internal static int __PropertyOffset_SpawnPositionBase;

		// Token: 0x0400B8B6 RID: 47286
		internal static int __PropertyOffset_SpawnPositionOffset;

		// Token: 0x0400B8B7 RID: 47287
		internal static int __PropertyOffset_InitialRotationBase;

		// Token: 0x0400B8B8 RID: 47288
		internal static int __PropertyOffset_InitialRotationOffset;

		// Token: 0x0400B8B9 RID: 47289
		internal static int __PropertyOffset_StartDelay;

		// Token: 0x0400B8BA RID: 47290
		internal static int __PropertyOffset_Duration;

		// Token: 0x0400B8BB RID: 47291
		internal static int __PropertyOffset_FireInterval;

		// Token: 0x0400B8BC RID: 47292
		internal static int __PropertyOffset_MaxFireCount;

		// Token: 0x0400B8BD RID: 47293
		internal static int __PropertyOffset_BulletId;

		// Token: 0x0400B8BE RID: 47294
		internal static int __PropertyOffset_NumPerShot;

		// Token: 0x0400B8BF RID: 47295
		internal static int __PropertyOffset_bKeepFormation;

		// Token: 0x0400B8C0 RID: 47296
		internal static int __PropertyOffset_InheritedVelocityMode;

		// Token: 0x0400B8C1 RID: 47297
		internal static int __PropertyOffset_InheritVelocityFactor;
	}
}
