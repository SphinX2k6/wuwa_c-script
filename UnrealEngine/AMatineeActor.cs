using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E9A RID: 3738
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MatineeActor")]
	[UnrealStructLayout(1384, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1384)]
	public class AMatineeActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C952 RID: 51538 RVA: 0x001250CA File Offset: 0x001232CA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AMatineeActor._ClassPtr;
		}

		// Token: 0x0600C953 RID: 51539 RVA: 0x001250D8 File Offset: 0x001232D8
		public AMatineeActor() : this(BuiltinUtils.AllocNativeUObject(AMatineeActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C954 RID: 51540 RVA: 0x00125100 File Offset: 0x00123300
		public AMatineeActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AMatineeActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002F24 RID: 12068
		// (get) Token: 0x0600C955 RID: 51541 RVA: 0x00125133 File Offset: 0x00123333
		// (set) Token: 0x0600C956 RID: 51542 RVA: 0x00125147 File Offset: 0x00123347
		[Nullable(2)]
		public unsafe UInterpData MatineeData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInterpData>(base.NativePtr / (IntPtr)sizeof(void*) + AMatineeActor.__PropertyOffset_MatineeData);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AMatineeActor.__PropertyOffset_MatineeData, value);
			}
		}

		// Token: 0x17002F25 RID: 12069
		// (get) Token: 0x0600C957 RID: 51543 RVA: 0x0012515C File Offset: 0x0012335C
		// (set) Token: 0x0600C958 RID: 51544 RVA: 0x00125170 File Offset: 0x00123370
		public unsafe FName MatineeControllerName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_MatineeControllerName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_MatineeControllerName) = value;
			}
		}

		// Token: 0x17002F26 RID: 12070
		// (get) Token: 0x0600C959 RID: 51545 RVA: 0x00125185 File Offset: 0x00123385
		// (set) Token: 0x0600C95A RID: 51546 RVA: 0x00125195 File Offset: 0x00123395
		public unsafe float PlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_PlayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_PlayRate) = value;
			}
		}

		// Token: 0x17002F27 RID: 12071
		// (get) Token: 0x0600C95B RID: 51547 RVA: 0x001251A6 File Offset: 0x001233A6
		// (set) Token: 0x0600C95C RID: 51548 RVA: 0x001251BF File Offset: 0x001233BF
		public unsafe bool bPlayOnLevelLoad
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bPlayOnLevelLoad) & AMatineeActor.__PropertyMask_bPlayOnLevelLoad) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bPlayOnLevelLoad) = ((*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bPlayOnLevelLoad) & ~AMatineeActor.__PropertyMask_bPlayOnLevelLoad) | (value ? AMatineeActor.__PropertyMask_bPlayOnLevelLoad : 0));
			}
		}

		// Token: 0x17002F28 RID: 12072
		// (get) Token: 0x0600C95D RID: 51549 RVA: 0x001251EF File Offset: 0x001233EF
		// (set) Token: 0x0600C95E RID: 51550 RVA: 0x00125208 File Offset: 0x00123408
		public unsafe bool bForceStartPos
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bForceStartPos) & AMatineeActor.__PropertyMask_bForceStartPos) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bForceStartPos) = ((*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bForceStartPos) & ~AMatineeActor.__PropertyMask_bForceStartPos) | (value ? AMatineeActor.__PropertyMask_bForceStartPos : 0));
			}
		}

		// Token: 0x17002F29 RID: 12073
		// (get) Token: 0x0600C95F RID: 51551 RVA: 0x00125238 File Offset: 0x00123438
		// (set) Token: 0x0600C960 RID: 51552 RVA: 0x00125248 File Offset: 0x00123448
		public unsafe float ForceStartPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_ForceStartPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_ForceStartPosition) = value;
			}
		}

		// Token: 0x17002F2A RID: 12074
		// (get) Token: 0x0600C961 RID: 51553 RVA: 0x00125259 File Offset: 0x00123459
		// (set) Token: 0x0600C962 RID: 51554 RVA: 0x00125272 File Offset: 0x00123472
		public unsafe bool bLooping
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bLooping) & AMatineeActor.__PropertyMask_bLooping) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bLooping) = ((*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bLooping) & ~AMatineeActor.__PropertyMask_bLooping) | (value ? AMatineeActor.__PropertyMask_bLooping : 0));
			}
		}

		// Token: 0x17002F2B RID: 12075
		// (get) Token: 0x0600C963 RID: 51555 RVA: 0x001252A2 File Offset: 0x001234A2
		// (set) Token: 0x0600C964 RID: 51556 RVA: 0x001252BB File Offset: 0x001234BB
		public unsafe bool bRewindOnPlay
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bRewindOnPlay) & AMatineeActor.__PropertyMask_bRewindOnPlay) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bRewindOnPlay) = ((*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bRewindOnPlay) & ~AMatineeActor.__PropertyMask_bRewindOnPlay) | (value ? AMatineeActor.__PropertyMask_bRewindOnPlay : 0));
			}
		}

		// Token: 0x17002F2C RID: 12076
		// (get) Token: 0x0600C965 RID: 51557 RVA: 0x001252EB File Offset: 0x001234EB
		// (set) Token: 0x0600C966 RID: 51558 RVA: 0x00125304 File Offset: 0x00123504
		public unsafe bool bNoResetOnRewind
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bNoResetOnRewind) & AMatineeActor.__PropertyMask_bNoResetOnRewind) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bNoResetOnRewind) = ((*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bNoResetOnRewind) & ~AMatineeActor.__PropertyMask_bNoResetOnRewind) | (value ? AMatineeActor.__PropertyMask_bNoResetOnRewind : 0));
			}
		}

		// Token: 0x17002F2D RID: 12077
		// (get) Token: 0x0600C967 RID: 51559 RVA: 0x00125334 File Offset: 0x00123534
		// (set) Token: 0x0600C968 RID: 51560 RVA: 0x0012534D File Offset: 0x0012354D
		public unsafe bool bRewindIfAlreadyPlaying
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bRewindIfAlreadyPlaying) & AMatineeActor.__PropertyMask_bRewindIfAlreadyPlaying) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bRewindIfAlreadyPlaying) = ((*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bRewindIfAlreadyPlaying) & ~AMatineeActor.__PropertyMask_bRewindIfAlreadyPlaying) | (value ? AMatineeActor.__PropertyMask_bRewindIfAlreadyPlaying : 0));
			}
		}

		// Token: 0x17002F2E RID: 12078
		// (get) Token: 0x0600C969 RID: 51561 RVA: 0x0012537D File Offset: 0x0012357D
		// (set) Token: 0x0600C96A RID: 51562 RVA: 0x00125396 File Offset: 0x00123596
		public unsafe bool bDisableRadioFilter
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bDisableRadioFilter) & AMatineeActor.__PropertyMask_bDisableRadioFilter) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bDisableRadioFilter) = ((*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bDisableRadioFilter) & ~AMatineeActor.__PropertyMask_bDisableRadioFilter) | (value ? AMatineeActor.__PropertyMask_bDisableRadioFilter : 0));
			}
		}

		// Token: 0x17002F2F RID: 12079
		// (get) Token: 0x0600C96B RID: 51563 RVA: 0x001253C6 File Offset: 0x001235C6
		// (set) Token: 0x0600C96C RID: 51564 RVA: 0x001253DF File Offset: 0x001235DF
		public unsafe bool bClientSideOnly
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bClientSideOnly) & AMatineeActor.__PropertyMask_bClientSideOnly) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bClientSideOnly) = ((*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bClientSideOnly) & ~AMatineeActor.__PropertyMask_bClientSideOnly) | (value ? AMatineeActor.__PropertyMask_bClientSideOnly : 0));
			}
		}

		// Token: 0x17002F30 RID: 12080
		// (get) Token: 0x0600C96D RID: 51565 RVA: 0x0012540F File Offset: 0x0012360F
		// (set) Token: 0x0600C96E RID: 51566 RVA: 0x00125428 File Offset: 0x00123628
		public unsafe bool bSkipUpdateIfNotVisible
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bSkipUpdateIfNotVisible) & AMatineeActor.__PropertyMask_bSkipUpdateIfNotVisible) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bSkipUpdateIfNotVisible) = ((*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bSkipUpdateIfNotVisible) & ~AMatineeActor.__PropertyMask_bSkipUpdateIfNotVisible) | (value ? AMatineeActor.__PropertyMask_bSkipUpdateIfNotVisible : 0));
			}
		}

		// Token: 0x17002F31 RID: 12081
		// (get) Token: 0x0600C96F RID: 51567 RVA: 0x00125458 File Offset: 0x00123658
		// (set) Token: 0x0600C970 RID: 51568 RVA: 0x00125471 File Offset: 0x00123671
		public unsafe bool bIsSkippable
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bIsSkippable) & AMatineeActor.__PropertyMask_bIsSkippable) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bIsSkippable) = ((*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bIsSkippable) & ~AMatineeActor.__PropertyMask_bIsSkippable) | (value ? AMatineeActor.__PropertyMask_bIsSkippable : 0));
			}
		}

		// Token: 0x17002F32 RID: 12082
		// (get) Token: 0x0600C971 RID: 51569 RVA: 0x001254A1 File Offset: 0x001236A1
		// (set) Token: 0x0600C972 RID: 51570 RVA: 0x001254B1 File Offset: 0x001236B1
		public unsafe int PreferredSplitScreenNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_PreferredSplitScreenNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_PreferredSplitScreenNum) = value;
			}
		}

		// Token: 0x17002F33 RID: 12083
		// (get) Token: 0x0600C973 RID: 51571 RVA: 0x001254C2 File Offset: 0x001236C2
		// (set) Token: 0x0600C974 RID: 51572 RVA: 0x001254DB File Offset: 0x001236DB
		public unsafe bool bDisableMovementInput
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bDisableMovementInput) & AMatineeActor.__PropertyMask_bDisableMovementInput) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bDisableMovementInput) = ((*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bDisableMovementInput) & ~AMatineeActor.__PropertyMask_bDisableMovementInput) | (value ? AMatineeActor.__PropertyMask_bDisableMovementInput : 0));
			}
		}

		// Token: 0x17002F34 RID: 12084
		// (get) Token: 0x0600C975 RID: 51573 RVA: 0x0012550B File Offset: 0x0012370B
		// (set) Token: 0x0600C976 RID: 51574 RVA: 0x00125524 File Offset: 0x00123724
		public unsafe bool bDisableLookAtInput
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bDisableLookAtInput) & AMatineeActor.__PropertyMask_bDisableLookAtInput) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bDisableLookAtInput) = ((*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bDisableLookAtInput) & ~AMatineeActor.__PropertyMask_bDisableLookAtInput) | (value ? AMatineeActor.__PropertyMask_bDisableLookAtInput : 0));
			}
		}

		// Token: 0x17002F35 RID: 12085
		// (get) Token: 0x0600C977 RID: 51575 RVA: 0x00125554 File Offset: 0x00123754
		// (set) Token: 0x0600C978 RID: 51576 RVA: 0x0012556D File Offset: 0x0012376D
		public unsafe bool bHidePlayer
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bHidePlayer) & AMatineeActor.__PropertyMask_bHidePlayer) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bHidePlayer) = ((*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bHidePlayer) & ~AMatineeActor.__PropertyMask_bHidePlayer) | (value ? AMatineeActor.__PropertyMask_bHidePlayer : 0));
			}
		}

		// Token: 0x17002F36 RID: 12086
		// (get) Token: 0x0600C979 RID: 51577 RVA: 0x0012559D File Offset: 0x0012379D
		// (set) Token: 0x0600C97A RID: 51578 RVA: 0x001255B6 File Offset: 0x001237B6
		public unsafe bool bHideHud
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bHideHud) & AMatineeActor.__PropertyMask_bHideHud) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bHideHud) = ((*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bHideHud) & ~AMatineeActor.__PropertyMask_bHideHud) | (value ? AMatineeActor.__PropertyMask_bHideHud : 0));
			}
		}

		// Token: 0x17002F37 RID: 12087
		// (get) Token: 0x0600C97B RID: 51579 RVA: 0x001255E8 File Offset: 0x001237E8
		// (set) Token: 0x0600C97C RID: 51580 RVA: 0x00125621 File Offset: 0x00123821
		public TArray<FInterpGroupActorInfo> GroupActorInfos
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FInterpGroupActorInfo> result;
				if ((result = this._GroupActorInfos) == null)
				{
					result = (this._GroupActorInfos = new TArray<FInterpGroupActorInfo>(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_GroupActorInfos, this));
				}
				return result;
			}
			set
			{
				this.GroupActorInfos.CopyAssign(value);
			}
		}

		// Token: 0x17002F38 RID: 12088
		// (get) Token: 0x0600C97D RID: 51581 RVA: 0x0012562F File Offset: 0x0012382F
		// (set) Token: 0x0600C97E RID: 51582 RVA: 0x00125648 File Offset: 0x00123848
		public unsafe bool bShouldShowGore
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bShouldShowGore) & AMatineeActor.__PropertyMask_bShouldShowGore) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bShouldShowGore) = ((*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bShouldShowGore) & ~AMatineeActor.__PropertyMask_bShouldShowGore) | (value ? AMatineeActor.__PropertyMask_bShouldShowGore : 0));
			}
		}

		// Token: 0x17002F39 RID: 12089
		// (get) Token: 0x0600C97F RID: 51583 RVA: 0x00125678 File Offset: 0x00123878
		// (set) Token: 0x0600C980 RID: 51584 RVA: 0x001256B1 File Offset: 0x001238B1
		public TArray<UInterpGroupInst> GroupInst
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UInterpGroupInst> result;
				if ((result = this._GroupInst) == null)
				{
					result = (this._GroupInst = new TArray<UInterpGroupInst>(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_GroupInst, this));
				}
				return result;
			}
			set
			{
				this.GroupInst.CopyAssign(value);
			}
		}

		// Token: 0x17002F3A RID: 12090
		// (get) Token: 0x0600C981 RID: 51585 RVA: 0x001256C0 File Offset: 0x001238C0
		// (set) Token: 0x0600C982 RID: 51586 RVA: 0x001256F9 File Offset: 0x001238F9
		public TArray<FCameraCutInfo> CameraCuts
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCameraCutInfo> result;
				if ((result = this._CameraCuts) == null)
				{
					result = (this._CameraCuts = new TArray<FCameraCutInfo>(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_CameraCuts, this));
				}
				return result;
			}
			set
			{
				this.CameraCuts.CopyAssign(value);
			}
		}

		// Token: 0x17002F3B RID: 12091
		// (get) Token: 0x0600C983 RID: 51587 RVA: 0x00125707 File Offset: 0x00123907
		// (set) Token: 0x0600C984 RID: 51588 RVA: 0x00125720 File Offset: 0x00123920
		public unsafe bool bIsPlaying
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bIsPlaying) & AMatineeActor.__PropertyMask_bIsPlaying) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bIsPlaying) = ((*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bIsPlaying) & ~AMatineeActor.__PropertyMask_bIsPlaying) | (value ? AMatineeActor.__PropertyMask_bIsPlaying : 0));
			}
		}

		// Token: 0x17002F3C RID: 12092
		// (get) Token: 0x0600C985 RID: 51589 RVA: 0x00125750 File Offset: 0x00123950
		// (set) Token: 0x0600C986 RID: 51590 RVA: 0x00125769 File Offset: 0x00123969
		public unsafe bool bReversePlayback
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bReversePlayback) & AMatineeActor.__PropertyMask_bReversePlayback) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bReversePlayback) = ((*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bReversePlayback) & ~AMatineeActor.__PropertyMask_bReversePlayback) | (value ? AMatineeActor.__PropertyMask_bReversePlayback : 0));
			}
		}

		// Token: 0x17002F3D RID: 12093
		// (get) Token: 0x0600C987 RID: 51591 RVA: 0x00125799 File Offset: 0x00123999
		// (set) Token: 0x0600C988 RID: 51592 RVA: 0x001257B2 File Offset: 0x001239B2
		public unsafe bool bPaused
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bPaused) & AMatineeActor.__PropertyMask_bPaused) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bPaused) = ((*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bPaused) & ~AMatineeActor.__PropertyMask_bPaused) | (value ? AMatineeActor.__PropertyMask_bPaused : 0));
			}
		}

		// Token: 0x17002F3E RID: 12094
		// (get) Token: 0x0600C989 RID: 51593 RVA: 0x001257E2 File Offset: 0x001239E2
		// (set) Token: 0x0600C98A RID: 51594 RVA: 0x001257FB File Offset: 0x001239FB
		public unsafe bool bPendingStop
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bPendingStop) & AMatineeActor.__PropertyMask_bPendingStop) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bPendingStop) = ((*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_bPendingStop) & ~AMatineeActor.__PropertyMask_bPendingStop) | (value ? AMatineeActor.__PropertyMask_bPendingStop : 0));
			}
		}

		// Token: 0x17002F3F RID: 12095
		// (get) Token: 0x0600C98B RID: 51595 RVA: 0x0012582B File Offset: 0x00123A2B
		// (set) Token: 0x0600C98C RID: 51596 RVA: 0x0012583B File Offset: 0x00123A3B
		public unsafe float InterpPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_InterpPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_InterpPosition) = value;
			}
		}

		// Token: 0x17002F40 RID: 12096
		// (get) Token: 0x0600C98D RID: 51597 RVA: 0x0012584C File Offset: 0x00123A4C
		// (set) Token: 0x0600C98E RID: 51598 RVA: 0x0012585C File Offset: 0x00123A5C
		public unsafe byte ReplicationForceIsPlaying
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_ReplicationForceIsPlaying);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_ReplicationForceIsPlaying) = value;
			}
		}

		// Token: 0x17002F41 RID: 12097
		// (get) Token: 0x0600C98F RID: 51599 RVA: 0x00125870 File Offset: 0x00123A70
		// (set) Token: 0x0600C990 RID: 51600 RVA: 0x001258A9 File Offset: 0x00123AA9
		public FOnMatineeEvent OnPlay
		{
			get
			{
				base.FastCheckIsValid();
				FOnMatineeEvent result;
				if ((result = this._OnPlay) == null)
				{
					result = (this._OnPlay = new FOnMatineeEvent(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_OnPlay, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_OnPlay, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002F42 RID: 12098
		// (get) Token: 0x0600C991 RID: 51601 RVA: 0x001258CC File Offset: 0x00123ACC
		// (set) Token: 0x0600C992 RID: 51602 RVA: 0x00125905 File Offset: 0x00123B05
		public FOnMatineeEvent OnStop
		{
			get
			{
				base.FastCheckIsValid();
				FOnMatineeEvent result;
				if ((result = this._OnStop) == null)
				{
					result = (this._OnStop = new FOnMatineeEvent(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_OnStop, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_OnStop, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002F43 RID: 12099
		// (get) Token: 0x0600C993 RID: 51603 RVA: 0x00125928 File Offset: 0x00123B28
		// (set) Token: 0x0600C994 RID: 51604 RVA: 0x00125961 File Offset: 0x00123B61
		public FOnMatineeEvent OnPause
		{
			get
			{
				base.FastCheckIsValid();
				FOnMatineeEvent result;
				if ((result = this._OnPause) == null)
				{
					result = (this._OnPause = new FOnMatineeEvent(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_OnPause, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AMatineeActor.__PropertyOffset_OnPause, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0600C995 RID: 51605 RVA: 0x00125982 File Offset: 0x00123B82
		public void Stop()
		{
			AMatineeActor.__Stop_Internal(base.NativePtr);
		}

		// Token: 0x0600C996 RID: 51606 RVA: 0x0012598F File Offset: 0x00123B8F
		public void SetPosition(float NewPosition, bool bJump = false)
		{
			AMatineeActor.__SetPosition_Internal(base.NativePtr, NewPosition, bJump);
		}

		// Token: 0x0600C997 RID: 51607 RVA: 0x0012599E File Offset: 0x00123B9E
		public void SetLoopingState(bool bNewLooping)
		{
			AMatineeActor.__SetLoopingState_Internal(base.NativePtr, bNewLooping);
		}

		// Token: 0x0600C998 RID: 51608 RVA: 0x001259AC File Offset: 0x00123BAC
		public void Reverse()
		{
			AMatineeActor.__Reverse_Internal(base.NativePtr);
		}

		// Token: 0x0600C999 RID: 51609 RVA: 0x001259B9 File Offset: 0x00123BB9
		public void Play()
		{
			AMatineeActor.__Play_Internal(base.NativePtr);
		}

		// Token: 0x0600C99A RID: 51610 RVA: 0x001259C6 File Offset: 0x00123BC6
		public void Pause()
		{
			AMatineeActor.__Pause_Internal(base.NativePtr);
		}

		// Token: 0x0600C99B RID: 51611 RVA: 0x001259D4 File Offset: 0x00123BD4
		public unsafe void EnableGroupByName(string GroupName, bool bEnable)
		{
			FString fstring = FString.AllocTemp(GroupName);
			AMatineeActor.__EnableGroupByName_Internal(base.NativePtr, fstring, bEnable);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600C99C RID: 51612 RVA: 0x001259FF File Offset: 0x00123BFF
		public void ChangePlaybackDirection()
		{
			AMatineeActor.__ChangePlaybackDirection_Internal(base.NativePtr);
		}

		// Token: 0x0600C99D RID: 51613
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Stop_Internal(IntPtr @this);

		// Token: 0x0600C99E RID: 51614
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPosition_Internal(IntPtr @this, float NewPosition, bool bJump);

		// Token: 0x0600C99F RID: 51615
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLoopingState_Internal(IntPtr @this, bool bNewLooping);

		// Token: 0x0600C9A0 RID: 51616
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Reverse_Internal(IntPtr @this);

		// Token: 0x0600C9A1 RID: 51617
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Play_Internal(IntPtr @this);

		// Token: 0x0600C9A2 RID: 51618
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Pause_Internal(IntPtr @this);

		// Token: 0x0600C9A3 RID: 51619
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EnableGroupByName_Internal(IntPtr @this, in FString GroupName, bool bEnable);

		// Token: 0x0600C9A4 RID: 51620
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ChangePlaybackDirection_Internal(IntPtr @this);

		// Token: 0x0600C9A5 RID: 51621 RVA: 0x00125A0C File Offset: 0x00123C0C
		static AMatineeActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MatineeActor");
		}

		// Token: 0x0600C9A6 RID: 51622 RVA: 0x00125A1A File Offset: 0x00123C1A
		protected AMatineeActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006C50 RID: 27728
		public new const string __ObjectPath = "/Script/Engine.MatineeActor";

		// Token: 0x04006C51 RID: 27729
		private static IntPtr _ClassPtr;

		// Token: 0x04006C52 RID: 27730
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006C53 RID: 27731
		internal static int __PropertyOffset_MatineeData;

		// Token: 0x04006C54 RID: 27732
		internal static int __PropertyOffset_MatineeControllerName;

		// Token: 0x04006C55 RID: 27733
		internal static int __PropertyOffset_PlayRate;

		// Token: 0x04006C56 RID: 27734
		internal static int __PropertyOffset_bPlayOnLevelLoad;

		// Token: 0x04006C57 RID: 27735
		internal static byte __PropertyMask_bPlayOnLevelLoad;

		// Token: 0x04006C58 RID: 27736
		internal static int __PropertyOffset_bForceStartPos;

		// Token: 0x04006C59 RID: 27737
		internal static byte __PropertyMask_bForceStartPos;

		// Token: 0x04006C5A RID: 27738
		internal static int __PropertyOffset_ForceStartPosition;

		// Token: 0x04006C5B RID: 27739
		internal static int __PropertyOffset_bLooping;

		// Token: 0x04006C5C RID: 27740
		internal static byte __PropertyMask_bLooping;

		// Token: 0x04006C5D RID: 27741
		internal static int __PropertyOffset_bRewindOnPlay;

		// Token: 0x04006C5E RID: 27742
		internal static byte __PropertyMask_bRewindOnPlay;

		// Token: 0x04006C5F RID: 27743
		internal static int __PropertyOffset_bNoResetOnRewind;

		// Token: 0x04006C60 RID: 27744
		internal static byte __PropertyMask_bNoResetOnRewind;

		// Token: 0x04006C61 RID: 27745
		internal static int __PropertyOffset_bRewindIfAlreadyPlaying;

		// Token: 0x04006C62 RID: 27746
		internal static byte __PropertyMask_bRewindIfAlreadyPlaying;

		// Token: 0x04006C63 RID: 27747
		internal static int __PropertyOffset_bDisableRadioFilter;

		// Token: 0x04006C64 RID: 27748
		internal static byte __PropertyMask_bDisableRadioFilter;

		// Token: 0x04006C65 RID: 27749
		internal static int __PropertyOffset_bClientSideOnly;

		// Token: 0x04006C66 RID: 27750
		internal static byte __PropertyMask_bClientSideOnly;

		// Token: 0x04006C67 RID: 27751
		internal static int __PropertyOffset_bSkipUpdateIfNotVisible;

		// Token: 0x04006C68 RID: 27752
		internal static byte __PropertyMask_bSkipUpdateIfNotVisible;

		// Token: 0x04006C69 RID: 27753
		internal static int __PropertyOffset_bIsSkippable;

		// Token: 0x04006C6A RID: 27754
		internal static byte __PropertyMask_bIsSkippable;

		// Token: 0x04006C6B RID: 27755
		internal static int __PropertyOffset_PreferredSplitScreenNum;

		// Token: 0x04006C6C RID: 27756
		internal static int __PropertyOffset_bDisableMovementInput;

		// Token: 0x04006C6D RID: 27757
		internal static byte __PropertyMask_bDisableMovementInput;

		// Token: 0x04006C6E RID: 27758
		internal static int __PropertyOffset_bDisableLookAtInput;

		// Token: 0x04006C6F RID: 27759
		internal static byte __PropertyMask_bDisableLookAtInput;

		// Token: 0x04006C70 RID: 27760
		internal static int __PropertyOffset_bHidePlayer;

		// Token: 0x04006C71 RID: 27761
		internal static byte __PropertyMask_bHidePlayer;

		// Token: 0x04006C72 RID: 27762
		internal static int __PropertyOffset_bHideHud;

		// Token: 0x04006C73 RID: 27763
		internal static byte __PropertyMask_bHideHud;

		// Token: 0x04006C74 RID: 27764
		internal static int __PropertyOffset_GroupActorInfos;

		// Token: 0x04006C75 RID: 27765
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FInterpGroupActorInfo> _GroupActorInfos;

		// Token: 0x04006C76 RID: 27766
		internal static int __PropertyOffset_bShouldShowGore;

		// Token: 0x04006C77 RID: 27767
		internal static byte __PropertyMask_bShouldShowGore;

		// Token: 0x04006C78 RID: 27768
		internal static int __PropertyOffset_GroupInst;

		// Token: 0x04006C79 RID: 27769
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UInterpGroupInst> _GroupInst;

		// Token: 0x04006C7A RID: 27770
		internal static int __PropertyOffset_CameraCuts;

		// Token: 0x04006C7B RID: 27771
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCameraCutInfo> _CameraCuts;

		// Token: 0x04006C7C RID: 27772
		internal static int __PropertyOffset_bIsPlaying;

		// Token: 0x04006C7D RID: 27773
		internal static byte __PropertyMask_bIsPlaying;

		// Token: 0x04006C7E RID: 27774
		internal static int __PropertyOffset_bReversePlayback;

		// Token: 0x04006C7F RID: 27775
		internal static byte __PropertyMask_bReversePlayback;

		// Token: 0x04006C80 RID: 27776
		internal static int __PropertyOffset_bPaused;

		// Token: 0x04006C81 RID: 27777
		internal static byte __PropertyMask_bPaused;

		// Token: 0x04006C82 RID: 27778
		internal static int __PropertyOffset_bPendingStop;

		// Token: 0x04006C83 RID: 27779
		internal static byte __PropertyMask_bPendingStop;

		// Token: 0x04006C84 RID: 27780
		internal static int __PropertyOffset_InterpPosition;

		// Token: 0x04006C85 RID: 27781
		internal static int __PropertyOffset_ReplicationForceIsPlaying;

		// Token: 0x04006C86 RID: 27782
		internal static int __PropertyOffset_OnPlay;

		// Token: 0x04006C87 RID: 27783
		[Nullable(2)]
		private FOnMatineeEvent _OnPlay;

		// Token: 0x04006C88 RID: 27784
		internal static int __PropertyOffset_OnStop;

		// Token: 0x04006C89 RID: 27785
		[Nullable(2)]
		private FOnMatineeEvent _OnStop;

		// Token: 0x04006C8A RID: 27786
		internal static int __PropertyOffset_OnPause;

		// Token: 0x04006C8B RID: 27787
		[Nullable(2)]
		private FOnMatineeEvent _OnPause;
	}
}
