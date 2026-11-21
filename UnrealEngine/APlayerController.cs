using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000262 RID: 610
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PlayerController")]
	[UnrealStructLayout(2032, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2032)]
	public class APlayerController : AController, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600350B RID: 13579 RVA: 0x0004B58F File Offset: 0x0004978F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return APlayerController._ClassPtr;
		}

		// Token: 0x0600350C RID: 13580 RVA: 0x0004B59C File Offset: 0x0004979C
		public APlayerController() : this(BuiltinUtils.AllocNativeUObject(APlayerController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600350D RID: 13581 RVA: 0x0004B5C4 File Offset: 0x000497C4
		[NullableContext(1)]
		public APlayerController(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(APlayerController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x0600350E RID: 13582 RVA: 0x0004B5F7 File Offset: 0x000497F7
		// (set) Token: 0x0600350F RID: 13583 RVA: 0x0004B60B File Offset: 0x0004980B
		public unsafe APawn AcknowledgedPawn
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<APawn>(base.NativePtr / (IntPtr)sizeof(void*) + APlayerController.__PropertyOffset_AcknowledgedPawn);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + APlayerController.__PropertyOffset_AcknowledgedPawn, value);
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06003510 RID: 13584 RVA: 0x0004B620 File Offset: 0x00049820
		// (set) Token: 0x06003511 RID: 13585 RVA: 0x0004B639 File Offset: 0x00049839
		public unsafe bool ChangeRotationOnPossess
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_ChangeRotationOnPossess) & APlayerController.__PropertyMask_ChangeRotationOnPossess) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APlayerController.__PropertyOffset_ChangeRotationOnPossess) = ((*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_ChangeRotationOnPossess) & ~APlayerController.__PropertyMask_ChangeRotationOnPossess) | (value ? APlayerController.__PropertyMask_ChangeRotationOnPossess : 0));
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06003512 RID: 13586 RVA: 0x0004B669 File Offset: 0x00049869
		// (set) Token: 0x06003513 RID: 13587 RVA: 0x0004B67D File Offset: 0x0004987D
		public unsafe APlayerCameraManager PlayerCameraManager
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<APlayerCameraManager>(base.NativePtr / (IntPtr)sizeof(void*) + APlayerController.__PropertyOffset_PlayerCameraManager);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + APlayerController.__PropertyOffset_PlayerCameraManager, value);
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06003514 RID: 13588 RVA: 0x0004B694 File Offset: 0x00049894
		// (set) Token: 0x06003515 RID: 13589 RVA: 0x0004B6CD File Offset: 0x000498CD
		[Nullable(1)]
		public TArray<APlayerCameraManager> AdditionalPlayerCameraManagers
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<APlayerCameraManager> result;
				if ((result = this._AdditionalPlayerCameraManagers) == null)
				{
					result = (this._AdditionalPlayerCameraManagers = new TArray<APlayerCameraManager>(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_AdditionalPlayerCameraManagers, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.AdditionalPlayerCameraManagers.CopyAssign(value);
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06003516 RID: 13590 RVA: 0x0004B6DB File Offset: 0x000498DB
		// (set) Token: 0x06003517 RID: 13591 RVA: 0x0004B6EF File Offset: 0x000498EF
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<APlayerCameraManager> PlayerCameraManagerClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_PlayerCameraManagerClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_PlayerCameraManagerClass) = value;
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x06003518 RID: 13592 RVA: 0x0004B704 File Offset: 0x00049904
		// (set) Token: 0x06003519 RID: 13593 RVA: 0x0004B714 File Offset: 0x00049914
		public unsafe bool bAutoManageActiveCameraTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bAutoManageActiveCameraTarget) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bAutoManageActiveCameraTarget) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x0600351A RID: 13594 RVA: 0x0004B725 File Offset: 0x00049925
		// (set) Token: 0x0600351B RID: 13595 RVA: 0x0004B739 File Offset: 0x00049939
		public unsafe FRotator TargetViewRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_TargetViewRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_TargetViewRotation) = value;
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x0600351C RID: 13596 RVA: 0x0004B74E File Offset: 0x0004994E
		// (set) Token: 0x0600351D RID: 13597 RVA: 0x0004B75E File Offset: 0x0004995E
		public unsafe float SmoothTargetViewRotationSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_SmoothTargetViewRotationSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_SmoothTargetViewRotationSpeed) = value;
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x0600351E RID: 13598 RVA: 0x0004B770 File Offset: 0x00049970
		// (set) Token: 0x0600351F RID: 13599 RVA: 0x0004B7A9 File Offset: 0x000499A9
		[Nullable(1)]
		public TArray<AActor> HiddenActors
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._HiddenActors) == null)
				{
					result = (this._HiddenActors = new TArray<AActor>(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_HiddenActors, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.HiddenActors.CopyAssign(value);
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x06003520 RID: 13600 RVA: 0x0004B7B8 File Offset: 0x000499B8
		// (set) Token: 0x06003521 RID: 13601 RVA: 0x0004B7F1 File Offset: 0x000499F1
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TWeakObjectPtr<UPrimitiveComponent>> HiddenPrimitiveComponents
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TWeakObjectPtr<UPrimitiveComponent>> result;
				if ((result = this._HiddenPrimitiveComponents) == null)
				{
					result = (this._HiddenPrimitiveComponents = new TArray<TWeakObjectPtr<UPrimitiveComponent>>(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_HiddenPrimitiveComponents, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.HiddenPrimitiveComponents.CopyAssign(value);
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x06003522 RID: 13602 RVA: 0x0004B7FF File Offset: 0x000499FF
		// (set) Token: 0x06003523 RID: 13603 RVA: 0x0004B80F File Offset: 0x00049A0F
		public unsafe float LastSpectatorStateSynchTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_LastSpectatorStateSynchTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_LastSpectatorStateSynchTime) = value;
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x06003524 RID: 13604 RVA: 0x0004B820 File Offset: 0x00049A20
		// (set) Token: 0x06003525 RID: 13605 RVA: 0x0004B834 File Offset: 0x00049A34
		public unsafe FVector LastSpectatorSyncLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_LastSpectatorSyncLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_LastSpectatorSyncLocation) = value;
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x06003526 RID: 13606 RVA: 0x0004B849 File Offset: 0x00049A49
		// (set) Token: 0x06003527 RID: 13607 RVA: 0x0004B85D File Offset: 0x00049A5D
		public unsafe FRotator LastSpectatorSyncRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_LastSpectatorSyncRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_LastSpectatorSyncRotation) = value;
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x06003528 RID: 13608 RVA: 0x0004B872 File Offset: 0x00049A72
		// (set) Token: 0x06003529 RID: 13609 RVA: 0x0004B882 File Offset: 0x00049A82
		public unsafe int ClientCap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_ClientCap);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_ClientCap) = value;
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x0600352A RID: 13610 RVA: 0x0004B893 File Offset: 0x00049A93
		// (set) Token: 0x0600352B RID: 13611 RVA: 0x0004B8A7 File Offset: 0x00049AA7
		public unsafe UCheatManager CheatManager
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCheatManager>(base.NativePtr / (IntPtr)sizeof(void*) + APlayerController.__PropertyOffset_CheatManager);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + APlayerController.__PropertyOffset_CheatManager, value);
			}
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x0600352C RID: 13612 RVA: 0x0004B8BC File Offset: 0x00049ABC
		// (set) Token: 0x0600352D RID: 13613 RVA: 0x0004B8D0 File Offset: 0x00049AD0
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UCheatManager> CheatClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_CheatClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_CheatClass) = value;
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x0600352E RID: 13614 RVA: 0x0004B8E5 File Offset: 0x00049AE5
		// (set) Token: 0x0600352F RID: 13615 RVA: 0x0004B8FE File Offset: 0x00049AFE
		public unsafe bool bPlayerIsWaiting
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bPlayerIsWaiting) & APlayerController.__PropertyMask_bPlayerIsWaiting) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APlayerController.__PropertyOffset_bPlayerIsWaiting) = ((*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bPlayerIsWaiting) & ~APlayerController.__PropertyMask_bPlayerIsWaiting) | (value ? APlayerController.__PropertyMask_bPlayerIsWaiting : 0));
			}
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x06003530 RID: 13616 RVA: 0x0004B92E File Offset: 0x00049B2E
		// (set) Token: 0x06003531 RID: 13617 RVA: 0x0004B93E File Offset: 0x00049B3E
		public unsafe byte NetPlayerIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_NetPlayerIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_NetPlayerIndex) = value;
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x06003532 RID: 13618 RVA: 0x0004B94F File Offset: 0x00049B4F
		// (set) Token: 0x06003533 RID: 13619 RVA: 0x0004B95F File Offset: 0x00049B5F
		public unsafe float InputYawScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_InputYawScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_InputYawScale) = value;
			}
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x06003534 RID: 13620 RVA: 0x0004B970 File Offset: 0x00049B70
		// (set) Token: 0x06003535 RID: 13621 RVA: 0x0004B980 File Offset: 0x00049B80
		public unsafe float InputPitchScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_InputPitchScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_InputPitchScale) = value;
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x06003536 RID: 13622 RVA: 0x0004B991 File Offset: 0x00049B91
		// (set) Token: 0x06003537 RID: 13623 RVA: 0x0004B9A1 File Offset: 0x00049BA1
		public unsafe float InputRollScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_InputRollScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_InputRollScale) = value;
			}
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06003538 RID: 13624 RVA: 0x0004B9B2 File Offset: 0x00049BB2
		// (set) Token: 0x06003539 RID: 13625 RVA: 0x0004B9CB File Offset: 0x00049BCB
		public unsafe bool bShowMouseCursor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bShowMouseCursor) & APlayerController.__PropertyMask_bShowMouseCursor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APlayerController.__PropertyOffset_bShowMouseCursor) = ((*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bShowMouseCursor) & ~APlayerController.__PropertyMask_bShowMouseCursor) | (value ? APlayerController.__PropertyMask_bShowMouseCursor : 0));
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x0600353A RID: 13626 RVA: 0x0004B9FB File Offset: 0x00049BFB
		// (set) Token: 0x0600353B RID: 13627 RVA: 0x0004BA14 File Offset: 0x00049C14
		public unsafe bool bEnableClickEvents
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bEnableClickEvents) & APlayerController.__PropertyMask_bEnableClickEvents) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APlayerController.__PropertyOffset_bEnableClickEvents) = ((*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bEnableClickEvents) & ~APlayerController.__PropertyMask_bEnableClickEvents) | (value ? APlayerController.__PropertyMask_bEnableClickEvents : 0));
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x0600353C RID: 13628 RVA: 0x0004BA44 File Offset: 0x00049C44
		// (set) Token: 0x0600353D RID: 13629 RVA: 0x0004BA5D File Offset: 0x00049C5D
		public unsafe bool bEnableTouchEvents
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bEnableTouchEvents) & APlayerController.__PropertyMask_bEnableTouchEvents) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APlayerController.__PropertyOffset_bEnableTouchEvents) = ((*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bEnableTouchEvents) & ~APlayerController.__PropertyMask_bEnableTouchEvents) | (value ? APlayerController.__PropertyMask_bEnableTouchEvents : 0));
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x0600353E RID: 13630 RVA: 0x0004BA8D File Offset: 0x00049C8D
		// (set) Token: 0x0600353F RID: 13631 RVA: 0x0004BAA6 File Offset: 0x00049CA6
		public unsafe bool bEnableMouseOverEvents
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bEnableMouseOverEvents) & APlayerController.__PropertyMask_bEnableMouseOverEvents) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APlayerController.__PropertyOffset_bEnableMouseOverEvents) = ((*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bEnableMouseOverEvents) & ~APlayerController.__PropertyMask_bEnableMouseOverEvents) | (value ? APlayerController.__PropertyMask_bEnableMouseOverEvents : 0));
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06003540 RID: 13632 RVA: 0x0004BAD6 File Offset: 0x00049CD6
		// (set) Token: 0x06003541 RID: 13633 RVA: 0x0004BAEF File Offset: 0x00049CEF
		public unsafe bool bEnableTouchOverEvents
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bEnableTouchOverEvents) & APlayerController.__PropertyMask_bEnableTouchOverEvents) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APlayerController.__PropertyOffset_bEnableTouchOverEvents) = ((*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bEnableTouchOverEvents) & ~APlayerController.__PropertyMask_bEnableTouchOverEvents) | (value ? APlayerController.__PropertyMask_bEnableTouchOverEvents : 0));
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06003542 RID: 13634 RVA: 0x0004BB1F File Offset: 0x00049D1F
		// (set) Token: 0x06003543 RID: 13635 RVA: 0x0004BB38 File Offset: 0x00049D38
		public unsafe bool bForceFeedbackEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bForceFeedbackEnabled) & APlayerController.__PropertyMask_bForceFeedbackEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APlayerController.__PropertyOffset_bForceFeedbackEnabled) = ((*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bForceFeedbackEnabled) & ~APlayerController.__PropertyMask_bForceFeedbackEnabled) | (value ? APlayerController.__PropertyMask_bForceFeedbackEnabled : 0));
			}
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x06003544 RID: 13636 RVA: 0x0004BB68 File Offset: 0x00049D68
		// (set) Token: 0x06003545 RID: 13637 RVA: 0x0004BB81 File Offset: 0x00049D81
		public unsafe bool bEnableStreamingSource
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bEnableStreamingSource) & APlayerController.__PropertyMask_bEnableStreamingSource) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APlayerController.__PropertyOffset_bEnableStreamingSource) = ((*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bEnableStreamingSource) & ~APlayerController.__PropertyMask_bEnableStreamingSource) | (value ? APlayerController.__PropertyMask_bEnableStreamingSource : 0));
			}
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x06003546 RID: 13638 RVA: 0x0004BBB1 File Offset: 0x00049DB1
		// (set) Token: 0x06003547 RID: 13639 RVA: 0x0004BBCA File Offset: 0x00049DCA
		public unsafe bool bStreamingSourceShouldActivate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bStreamingSourceShouldActivate) & APlayerController.__PropertyMask_bStreamingSourceShouldActivate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APlayerController.__PropertyOffset_bStreamingSourceShouldActivate) = ((*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bStreamingSourceShouldActivate) & ~APlayerController.__PropertyMask_bStreamingSourceShouldActivate) | (value ? APlayerController.__PropertyMask_bStreamingSourceShouldActivate : 0));
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06003548 RID: 13640 RVA: 0x0004BBFA File Offset: 0x00049DFA
		// (set) Token: 0x06003549 RID: 13641 RVA: 0x0004BC0A File Offset: 0x00049E0A
		public unsafe EStreamingSourceTargetBehavior TargetBehavior
		{
			get
			{
				return (EStreamingSourceTargetBehavior)(*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_TargetBehavior));
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_TargetBehavior) = (byte)value;
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x0600354A RID: 13642 RVA: 0x0004BC1C File Offset: 0x00049E1C
		// (set) Token: 0x0600354B RID: 13643 RVA: 0x0004BC55 File Offset: 0x00049E55
		[Nullable(1)]
		public TArray<FName> TargetGrids
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TargetGrids) == null)
				{
					result = (this._TargetGrids = new TArray<FName>(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_TargetGrids, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.TargetGrids.CopyAssign(value);
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x0600354C RID: 13644 RVA: 0x0004BC63 File Offset: 0x00049E63
		// (set) Token: 0x0600354D RID: 13645 RVA: 0x0004BC7C File Offset: 0x00049E7C
		public unsafe bool bStreamingSourceShouldBlockOnSlowStreaming
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bStreamingSourceShouldBlockOnSlowStreaming) & APlayerController.__PropertyMask_bStreamingSourceShouldBlockOnSlowStreaming) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APlayerController.__PropertyOffset_bStreamingSourceShouldBlockOnSlowStreaming) = ((*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bStreamingSourceShouldBlockOnSlowStreaming) & ~APlayerController.__PropertyMask_bStreamingSourceShouldBlockOnSlowStreaming) | (value ? APlayerController.__PropertyMask_bStreamingSourceShouldBlockOnSlowStreaming : 0));
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x0600354E RID: 13646 RVA: 0x0004BCAC File Offset: 0x00049EAC
		// (set) Token: 0x0600354F RID: 13647 RVA: 0x0004BCBC File Offset: 0x00049EBC
		public unsafe EStreamingSourcePriority StreamingSourcePriority
		{
			get
			{
				return (EStreamingSourcePriority)(*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_StreamingSourcePriority));
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_StreamingSourcePriority) = (byte)value;
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06003550 RID: 13648 RVA: 0x0004BCCD File Offset: 0x00049ECD
		// (set) Token: 0x06003551 RID: 13649 RVA: 0x0004BCE1 File Offset: 0x00049EE1
		public unsafe FColor StreamingSourceDebugColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_StreamingSourceDebugColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_StreamingSourceDebugColor) = value;
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06003552 RID: 13650 RVA: 0x0004BCF8 File Offset: 0x00049EF8
		// (set) Token: 0x06003553 RID: 13651 RVA: 0x0004BD31 File Offset: 0x00049F31
		[Nullable(1)]
		public TArray<FStreamingSourceShape> StreamingSourceShapes
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FStreamingSourceShape> result;
				if ((result = this._StreamingSourceShapes) == null)
				{
					result = (this._StreamingSourceShapes = new TArray<FStreamingSourceShape>(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_StreamingSourceShapes, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.StreamingSourceShapes.CopyAssign(value);
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x06003554 RID: 13652 RVA: 0x0004BD3F File Offset: 0x00049F3F
		// (set) Token: 0x06003555 RID: 13653 RVA: 0x0004BD4F File Offset: 0x00049F4F
		public unsafe float ForceFeedbackScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_ForceFeedbackScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_ForceFeedbackScale) = value;
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06003556 RID: 13654 RVA: 0x0004BD60 File Offset: 0x00049F60
		// (set) Token: 0x06003557 RID: 13655 RVA: 0x0004BD99 File Offset: 0x00049F99
		[Nullable(1)]
		public TArray<FKey> ClickEventKeys
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FKey> result;
				if ((result = this._ClickEventKeys) == null)
				{
					result = (this._ClickEventKeys = new TArray<FKey>(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_ClickEventKeys, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ClickEventKeys.CopyAssign(value);
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06003558 RID: 13656 RVA: 0x0004BDA7 File Offset: 0x00049FA7
		// (set) Token: 0x06003559 RID: 13657 RVA: 0x0004BDBB File Offset: 0x00049FBB
		[Nullable(0)]
		public unsafe TEnumAsByte<EMouseCursor> DefaultMouseCursor
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_DefaultMouseCursor);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_DefaultMouseCursor) = value;
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x0600355A RID: 13658 RVA: 0x0004BDD0 File Offset: 0x00049FD0
		// (set) Token: 0x0600355B RID: 13659 RVA: 0x0004BDE4 File Offset: 0x00049FE4
		[Nullable(0)]
		public unsafe TEnumAsByte<EMouseCursor> CurrentMouseCursor
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_CurrentMouseCursor);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_CurrentMouseCursor) = value;
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x0600355C RID: 13660 RVA: 0x0004BDF9 File Offset: 0x00049FF9
		// (set) Token: 0x0600355D RID: 13661 RVA: 0x0004BE0D File Offset: 0x0004A00D
		[Nullable(0)]
		public unsafe TEnumAsByte<ECollisionChannel> DefaultClickTraceChannel
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_DefaultClickTraceChannel);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_DefaultClickTraceChannel) = value;
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x0600355E RID: 13662 RVA: 0x0004BE22 File Offset: 0x0004A022
		// (set) Token: 0x0600355F RID: 13663 RVA: 0x0004BE36 File Offset: 0x0004A036
		[Nullable(0)]
		public unsafe TEnumAsByte<ECollisionChannel> CurrentClickTraceChannel
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_CurrentClickTraceChannel);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_CurrentClickTraceChannel) = value;
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06003560 RID: 13664 RVA: 0x0004BE4B File Offset: 0x0004A04B
		// (set) Token: 0x06003561 RID: 13665 RVA: 0x0004BE5B File Offset: 0x0004A05B
		public unsafe float HitResultTraceDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_HitResultTraceDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_HitResultTraceDistance) = value;
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06003562 RID: 13666 RVA: 0x0004BE6C File Offset: 0x0004A06C
		// (set) Token: 0x06003563 RID: 13667 RVA: 0x0004BE7C File Offset: 0x0004A07C
		public unsafe ushort SeamlessTravelCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_SeamlessTravelCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_SeamlessTravelCount) = (short)value;
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06003564 RID: 13668 RVA: 0x0004BE8D File Offset: 0x0004A08D
		// (set) Token: 0x06003565 RID: 13669 RVA: 0x0004BE9D File Offset: 0x0004A09D
		public unsafe ushort LastCompletedSeamlessTravelCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_LastCompletedSeamlessTravelCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_LastCompletedSeamlessTravelCount) = (short)value;
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06003566 RID: 13670 RVA: 0x0004BEAE File Offset: 0x0004A0AE
		// (set) Token: 0x06003567 RID: 13671 RVA: 0x0004BEC2 File Offset: 0x0004A0C2
		public unsafe AActor SeamlessCameraActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + APlayerController.__PropertyOffset_SeamlessCameraActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + APlayerController.__PropertyOffset_SeamlessCameraActor, value);
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x06003568 RID: 13672 RVA: 0x0004BED7 File Offset: 0x0004A0D7
		// (set) Token: 0x06003569 RID: 13673 RVA: 0x0004BEF0 File Offset: 0x0004A0F0
		public unsafe bool bUseSeamlessCameraActor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bUseSeamlessCameraActor) & APlayerController.__PropertyMask_bUseSeamlessCameraActor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APlayerController.__PropertyOffset_bUseSeamlessCameraActor) = ((*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bUseSeamlessCameraActor) & ~APlayerController.__PropertyMask_bUseSeamlessCameraActor) | (value ? APlayerController.__PropertyMask_bUseSeamlessCameraActor : 0));
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x0600356A RID: 13674 RVA: 0x0004BF20 File Offset: 0x0004A120
		// (set) Token: 0x0600356B RID: 13675 RVA: 0x0004BF39 File Offset: 0x0004A139
		public unsafe bool bShouldPerformFullTickWhenPaused
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bShouldPerformFullTickWhenPaused) & APlayerController.__PropertyMask_bShouldPerformFullTickWhenPaused) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APlayerController.__PropertyOffset_bShouldPerformFullTickWhenPaused) = ((*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bShouldPerformFullTickWhenPaused) & ~APlayerController.__PropertyMask_bShouldPerformFullTickWhenPaused) | (value ? APlayerController.__PropertyMask_bShouldPerformFullTickWhenPaused : 0));
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x0600356C RID: 13676 RVA: 0x0004BF69 File Offset: 0x0004A169
		// (set) Token: 0x0600356D RID: 13677 RVA: 0x0004BF79 File Offset: 0x0004A179
		public unsafe bool bIsLocalPlayerController
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bIsLocalPlayerController) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_bIsLocalPlayerController) = (value ? 1 : 0);
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x0600356E RID: 13678 RVA: 0x0004BF8A File Offset: 0x0004A18A
		// (set) Token: 0x0600356F RID: 13679 RVA: 0x0004BF9E File Offset: 0x0004A19E
		public unsafe FVector SpawnLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_SpawnLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerController.__PropertyOffset_SpawnLocation) = value;
			}
		}

		// Token: 0x06003570 RID: 13680 RVA: 0x0004BFB3 File Offset: 0x0004A1B3
		public bool WasInputKeyJustReleased(FKey Key)
		{
			return APlayerController.__WasInputKeyJustReleased_Internal(base.NativePtr, (Key ?? new FKey()).NativePtr);
		}

		// Token: 0x06003571 RID: 13681 RVA: 0x0004BFCF File Offset: 0x0004A1CF
		public bool WasInputKeyJustPressed(FKey Key)
		{
			return APlayerController.__WasInputKeyJustPressed_Internal(base.NativePtr, (Key ?? new FKey()).NativePtr);
		}

		// Token: 0x06003572 RID: 13682 RVA: 0x0004BFEB File Offset: 0x0004A1EB
		public void ToggleSpeaking(bool bInSpeaking)
		{
			APlayerController.__ToggleSpeaking_Internal(base.NativePtr, bInSpeaking);
		}

		// Token: 0x06003573 RID: 13683 RVA: 0x0004BFF9 File Offset: 0x0004A1F9
		public void TestServerLevelVisibilityChange(FName PackageName, FName FileName)
		{
			APlayerController.__TestServerLevelVisibilityChange_Internal(base.NativePtr, PackageName, FileName);
		}

		// Token: 0x06003574 RID: 13684 RVA: 0x0004C008 File Offset: 0x0004A208
		[NullableContext(1)]
		public unsafe void SwitchLevel(string URL)
		{
			FString fstring = FString.AllocTemp(URL);
			APlayerController.__SwitchLevel_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06003575 RID: 13685 RVA: 0x0004C032 File Offset: 0x0004A232
		public bool StreamingSourceShouldBlockOnSlowStreaming()
		{
			return APlayerController.__StreamingSourceShouldBlockOnSlowStreaming_Internal(base.NativePtr);
		}

		// Token: 0x06003576 RID: 13686 RVA: 0x0004C03F File Offset: 0x0004A23F
		public bool StreamingSourceShouldActivate()
		{
			return APlayerController.__StreamingSourceShouldActivate_Internal(base.NativePtr);
		}

		// Token: 0x06003577 RID: 13687 RVA: 0x0004C04C File Offset: 0x0004A24C
		public void StartFire(byte FireModeNum = 0)
		{
			APlayerController.__StartFire_Internal(base.NativePtr, FireModeNum);
		}

		// Token: 0x06003578 RID: 13688 RVA: 0x0004C05A File Offset: 0x0004A25A
		public APlayerCameraManager SpawnPlayerCameraManager()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APlayerCameraManager>(APlayerController.__SpawnPlayerCameraManager_Internal(base.NativePtr));
		}

		// Token: 0x06003579 RID: 13689 RVA: 0x0004C06C File Offset: 0x0004A26C
		public void SetVirtualJoystickVisibility(bool bVisible)
		{
			APlayerController.__SetVirtualJoystickVisibility_Internal(base.NativePtr, bVisible);
		}

		// Token: 0x0600357A RID: 13690 RVA: 0x0004C07A File Offset: 0x0004A27A
		public void SetViewTargetWithBlendCurve(AActor NewViewTarget, float BlendTime = 0f, EViewTargetBlendFunction BlendFunc = EViewTargetBlendFunction.VTBlend_Linear, float BlendExp = 0f, bool bLockOutgoing = false, bool bKuroEnableBlend = false, UCurveFloat BlendCurve = null)
		{
			APlayerController.__SetViewTargetWithBlendCurve_Internal(base.NativePtr, (NewViewTarget != null) ? NewViewTarget.NativePtr : IntPtr.Zero, BlendTime, BlendFunc, BlendExp, bLockOutgoing, bKuroEnableBlend, (BlendCurve != null) ? BlendCurve.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600357B RID: 13691 RVA: 0x0004C0B6 File Offset: 0x0004A2B6
		public void SetViewTargetWithBlend(AActor NewViewTarget, float BlendTime = 0f, EViewTargetBlendFunction BlendFunc = EViewTargetBlendFunction.VTBlend_Linear, float BlendExp = 0f, bool bLockOutgoing = false, bool bKuroEnableBlend = false)
		{
			APlayerController.__SetViewTargetWithBlend_Internal(base.NativePtr, (NewViewTarget != null) ? NewViewTarget.NativePtr : IntPtr.Zero, BlendTime, BlendFunc, BlendExp, bLockOutgoing, bKuroEnableBlend);
		}

		// Token: 0x0600357C RID: 13692 RVA: 0x0004C0E0 File Offset: 0x0004A2E0
		[NullableContext(1)]
		public unsafe void SetName(string S)
		{
			FString fstring = FString.AllocTemp(S);
			APlayerController.__SetName_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600357D RID: 13693 RVA: 0x0004C10A File Offset: 0x0004A30A
		public void SetMouseLocation(int X, int Y)
		{
			APlayerController.__SetMouseLocation_Internal(base.NativePtr, X, Y);
		}

		// Token: 0x0600357E RID: 13694 RVA: 0x0004C119 File Offset: 0x0004A319
		public void SetMouseCursorWidget(EMouseCursor Cursor, UUserWidget CursorWidget)
		{
			APlayerController.__SetMouseCursorWidget_Internal(base.NativePtr, Cursor, (CursorWidget != null) ? CursorWidget.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600357F RID: 13695 RVA: 0x0004C13C File Offset: 0x0004A33C
		public void SetDisableHaptics(bool bNewDisabled)
		{
			APlayerController.__SetDisableHaptics_Internal(base.NativePtr, bNewDisabled);
		}

		// Token: 0x06003580 RID: 13696 RVA: 0x0004C14A File Offset: 0x0004A34A
		public void SetControllerLightColor(FColor Color)
		{
			APlayerController.__SetControllerLightColor_Internal(base.NativePtr, Color);
		}

		// Token: 0x06003581 RID: 13697 RVA: 0x0004C158 File Offset: 0x0004A358
		public void SetCinematicMode(bool bInCinematicMode, bool bHidePlayer, bool bAffectsHUD, bool bAffectsMovement, bool bAffectsTurning)
		{
			APlayerController.__SetCinematicMode_Internal(base.NativePtr, bInCinematicMode, bHidePlayer, bAffectsHUD, bAffectsMovement, bAffectsTurning);
		}

		// Token: 0x06003582 RID: 13698 RVA: 0x0004C16C File Offset: 0x0004A36C
		public void SetAudioListenerOverride(USceneComponent AttachToComponent, FVector Location, FRotator Rotation)
		{
			APlayerController.__SetAudioListenerOverride_Internal(base.NativePtr, (AttachToComponent != null) ? AttachToComponent.NativePtr : IntPtr.Zero, Location, Rotation);
		}

		// Token: 0x06003583 RID: 13699 RVA: 0x0004C18B File Offset: 0x0004A38B
		public void SetAudioListenerAttenuationOverride(USceneComponent AttachToComponent, FVector AttenuationLocationOVerride)
		{
			APlayerController.__SetAudioListenerAttenuationOverride_Internal(base.NativePtr, (AttachToComponent != null) ? AttachToComponent.NativePtr : IntPtr.Zero, AttenuationLocationOVerride);
		}

		// Token: 0x06003584 RID: 13700 RVA: 0x0004C1A9 File Offset: 0x0004A3A9
		public void ServerViewSelf(FViewTargetTransitionParams TransitionParams)
		{
			APlayerController.__ServerViewSelf_Internal(base.NativePtr, (TransitionParams ?? new FViewTargetTransitionParams()).NativePtr);
		}

		// Token: 0x06003585 RID: 13701 RVA: 0x0004C1C5 File Offset: 0x0004A3C5
		public void ServerViewPrevPlayer()
		{
			APlayerController.__ServerViewPrevPlayer_Internal(base.NativePtr);
		}

		// Token: 0x06003586 RID: 13702 RVA: 0x0004C1D2 File Offset: 0x0004A3D2
		public void ServerViewNextPlayer()
		{
			APlayerController.__ServerViewNextPlayer_Internal(base.NativePtr);
		}

		// Token: 0x06003587 RID: 13703 RVA: 0x0004C1DF File Offset: 0x0004A3DF
		public void ServerVerifyViewTarget()
		{
			APlayerController.__ServerVerifyViewTarget_Internal(base.NativePtr);
		}

		// Token: 0x06003588 RID: 13704 RVA: 0x0004C1EC File Offset: 0x0004A3EC
		public void ServerUpdateCamera(FVector_NetQuantize CamLoc, int CamPitchAndYaw)
		{
			APlayerController.__ServerUpdateCamera_Internal(base.NativePtr, CamLoc, CamPitchAndYaw);
		}

		// Token: 0x06003589 RID: 13705 RVA: 0x0004C1FB File Offset: 0x0004A3FB
		public void ServerToggleAILogging()
		{
			APlayerController.__ServerToggleAILogging_Internal(base.NativePtr);
		}

		// Token: 0x0600358A RID: 13706 RVA: 0x0004C208 File Offset: 0x0004A408
		public void ServerShortTimeout()
		{
			APlayerController.__ServerShortTimeout_Internal(base.NativePtr);
		}

		// Token: 0x0600358B RID: 13707 RVA: 0x0004C215 File Offset: 0x0004A415
		public void ServerSetSpectatorWaiting(bool bWaiting)
		{
			APlayerController.__ServerSetSpectatorWaiting_Internal(base.NativePtr, bWaiting);
		}

		// Token: 0x0600358C RID: 13708 RVA: 0x0004C223 File Offset: 0x0004A423
		public void ServerSetSpectatorLocation(FVector NewLoc, FRotator NewRot)
		{
			APlayerController.__ServerSetSpectatorLocation_Internal(base.NativePtr, NewLoc, NewRot);
		}

		// Token: 0x0600358D RID: 13709 RVA: 0x0004C232 File Offset: 0x0004A432
		public void ServerRestartPlayer()
		{
			APlayerController.__ServerRestartPlayer_Internal(base.NativePtr);
		}

		// Token: 0x0600358E RID: 13710 RVA: 0x0004C23F File Offset: 0x0004A43F
		public void ServerPause()
		{
			APlayerController.__ServerPause_Internal(base.NativePtr);
		}

		// Token: 0x0600358F RID: 13711 RVA: 0x0004C24C File Offset: 0x0004A44C
		public void ServerNotifyLoadedWorld(FName WorldPackageName)
		{
			APlayerController.__ServerNotifyLoadedWorld_Internal(base.NativePtr, WorldPackageName);
		}

		// Token: 0x06003590 RID: 13712 RVA: 0x0004C25C File Offset: 0x0004A45C
		[NullableContext(1)]
		public unsafe void ServerExecRPC(string Msg)
		{
			FString fstring = FString.AllocTemp(Msg);
			APlayerController.__ServerExecRPC_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06003591 RID: 13713 RVA: 0x0004C288 File Offset: 0x0004A488
		[NullableContext(1)]
		public unsafe void ServerExec(string Msg)
		{
			FString fstring = FString.AllocTemp(Msg);
			APlayerController.__ServerExec_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06003592 RID: 13714 RVA: 0x0004C2B2 File Offset: 0x0004A4B2
		public void ServerCheckClientPossessionReliable()
		{
			APlayerController.__ServerCheckClientPossessionReliable_Internal(base.NativePtr);
		}

		// Token: 0x06003593 RID: 13715 RVA: 0x0004C2BF File Offset: 0x0004A4BF
		public void ServerCheckClientPossession()
		{
			APlayerController.__ServerCheckClientPossession_Internal(base.NativePtr);
		}

		// Token: 0x06003594 RID: 13716 RVA: 0x0004C2CC File Offset: 0x0004A4CC
		[NullableContext(1)]
		public unsafe void ServerChangeName(string S)
		{
			FString fstring = FString.AllocTemp(S);
			APlayerController.__ServerChangeName_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06003595 RID: 13717 RVA: 0x0004C2F6 File Offset: 0x0004A4F6
		public void ServerCamera(FName NewMode)
		{
			APlayerController.__ServerCamera_Internal(base.NativePtr, NewMode);
		}

		// Token: 0x06003596 RID: 13718 RVA: 0x0004C304 File Offset: 0x0004A504
		public void ServerAcknowledgePossession(APawn P)
		{
			APlayerController.__ServerAcknowledgePossession_Internal(base.NativePtr, (P != null) ? P.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06003597 RID: 13719 RVA: 0x0004C324 File Offset: 0x0004A524
		[NullableContext(1)]
		public unsafe void SendToConsole(string Command)
		{
			FString fstring = FString.AllocTemp(Command);
			APlayerController.__SendToConsole_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06003598 RID: 13720 RVA: 0x0004C34E File Offset: 0x0004A54E
		public void RestartLevel()
		{
			APlayerController.__RestartLevel_Internal(base.NativePtr);
		}

		// Token: 0x06003599 RID: 13721 RVA: 0x0004C35B File Offset: 0x0004A55B
		public void ResetControllerLightColor()
		{
			APlayerController.__ResetControllerLightColor_Internal(base.NativePtr);
		}

		// Token: 0x0600359A RID: 13722 RVA: 0x0004C368 File Offset: 0x0004A568
		public void RemoveAdditionalPlayerCameraManagers()
		{
			APlayerController.__RemoveAdditionalPlayerCameraManagers_Internal(base.NativePtr);
		}

		// Token: 0x0600359B RID: 13723 RVA: 0x0004C378 File Offset: 0x0004A578
		public unsafe bool ProjectWorldLocationToScreen(FVector WorldLocation, ref FVector2D ScreenLocation, bool bPlayerViewportRelative = false)
		{
			fixed (FVector2D* ptr = &ScreenLocation)
			{
				void* ptr2 = (void*)ptr;
				return APlayerController.__ProjectWorldLocationToScreen_Internal(base.NativePtr, WorldLocation, ref ScreenLocation, bPlayerViewportRelative);
			}
		}

		// Token: 0x0600359C RID: 13724 RVA: 0x0004C398 File Offset: 0x0004A598
		public void Pause()
		{
			APlayerController.__Pause_Internal(base.NativePtr);
		}

		// Token: 0x0600359D RID: 13725 RVA: 0x0004C3A5 File Offset: 0x0004A5A5
		public void OnServerStartedVisualLogger(bool bIsLogging)
		{
			APlayerController.__OnServerStartedVisualLogger_Internal(base.NativePtr, bIsLogging);
		}

		// Token: 0x0600359E RID: 13726 RVA: 0x0004C3B4 File Offset: 0x0004A5B4
		[NullableContext(1)]
		public unsafe void LocalTravel(string URL)
		{
			FString fstring = FString.AllocTemp(URL);
			APlayerController.__LocalTravel_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600359F RID: 13727 RVA: 0x0004C3E0 File Offset: 0x0004A5E0
		[NullableContext(1)]
		public unsafe void K2_ClientTravel(string URL, ETravelType TravelType, bool bSeamless = false)
		{
			FString fstring = FString.AllocTemp(URL);
			APlayerController.__K2_ClientTravel_Internal(base.NativePtr, fstring, TravelType, bSeamless);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060035A0 RID: 13728 RVA: 0x0004C411 File Offset: 0x0004A611
		public void K2_ClientPlayForceFeedback(UForceFeedbackEffect ForceFeedbackEffect, FName Tag, bool bLooping, bool bIgnoreTimeDilation, bool bPlayWhilePaused)
		{
			APlayerController.__K2_ClientPlayForceFeedback_Internal(base.NativePtr, (ForceFeedbackEffect != null) ? ForceFeedbackEffect.NativePtr : IntPtr.Zero, Tag, bLooping, bIgnoreTimeDilation, bPlayWhilePaused);
		}

		// Token: 0x060035A1 RID: 13729 RVA: 0x0004C434 File Offset: 0x0004A634
		public bool IsStreamingSourceEnabled()
		{
			return APlayerController.__IsStreamingSourceEnabled_Internal(base.NativePtr);
		}

		// Token: 0x060035A2 RID: 13730 RVA: 0x0004C441 File Offset: 0x0004A641
		public bool IsInputKeyDown(FKey Key)
		{
			return APlayerController.__IsInputKeyDown_Internal(base.NativePtr, (Key ?? new FKey()).NativePtr);
		}

		// Token: 0x060035A3 RID: 13731 RVA: 0x0004C460 File Offset: 0x0004A660
		public unsafe void GetViewportSize(ref int SizeX, ref int SizeY)
		{
			fixed (int* ptr = &SizeX)
			{
				void* ptr2 = (void*)ptr;
				fixed (int* ptr3 = &SizeY)
				{
					void* ptr4 = (void*)ptr3;
					APlayerController.__GetViewportSize_Internal(base.NativePtr, ref SizeX, ref SizeY);
					ptr = null;
				}
			}
		}

		// Token: 0x060035A4 RID: 13732 RVA: 0x0004C48A File Offset: 0x0004A68A
		public void GetStreamingSourceShapes([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FStreamingSourceShape> OutShapes)
		{
			APlayerController.__GetStreamingSourceShapes_Internal(base.NativePtr, (OutShapes ?? new TArray<FStreamingSourceShape>()).NativePtr);
		}

		// Token: 0x060035A5 RID: 13733 RVA: 0x0004C4A7 File Offset: 0x0004A6A7
		public EStreamingSourcePriority GetStreamingSourcePriority()
		{
			return APlayerController.__GetStreamingSourcePriority_Internal(base.NativePtr);
		}

		// Token: 0x060035A6 RID: 13734 RVA: 0x0004C4B4 File Offset: 0x0004A6B4
		public unsafe void GetStreamingSourceLocationAndRotation(ref FVector OutLocation, ref FRotator OutRotation)
		{
			fixed (FVector* ptr = &OutLocation)
			{
				void* ptr2 = (void*)ptr;
				fixed (FRotator* ptr3 = &OutRotation)
				{
					void* ptr4 = (void*)ptr3;
					APlayerController.__GetStreamingSourceLocationAndRotation_Internal(base.NativePtr, ref OutLocation, ref OutRotation);
					ptr = null;
				}
			}
		}

		// Token: 0x060035A7 RID: 13735 RVA: 0x0004C4DE File Offset: 0x0004A6DE
		public int GetPlayerCameraManagerCount()
		{
			return APlayerController.__GetPlayerCameraManagerCount_Internal(base.NativePtr);
		}

		// Token: 0x060035A8 RID: 13736 RVA: 0x0004C4EB File Offset: 0x0004A6EB
		public APlayerCameraManager GetPlayerCameraManager(int CameraIndex = 0)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APlayerCameraManager>(APlayerController.__GetPlayerCameraManager_Internal(base.NativePtr, CameraIndex));
		}

		// Token: 0x060035A9 RID: 13737 RVA: 0x0004C500 File Offset: 0x0004A700
		public unsafe bool GetMousePosition(ref float LocationX, ref float LocationY)
		{
			fixed (float* ptr = &LocationX)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &LocationY)
				{
					void* ptr4 = (void*)ptr3;
					return APlayerController.__GetMousePosition_Internal(base.NativePtr, ref LocationX, ref LocationY);
				}
			}
		}

		// Token: 0x060035AA RID: 13738 RVA: 0x0004C524 File Offset: 0x0004A724
		public FVector GetInputVectorKeyState(FKey Key)
		{
			return APlayerController.__GetInputVectorKeyState_Internal(base.NativePtr, (Key ?? new FKey()).NativePtr);
		}

		// Token: 0x060035AB RID: 13739 RVA: 0x0004C540 File Offset: 0x0004A740
		public unsafe void GetInputTouchState(ETouchIndex FingerIndex, ref float LocationX, ref float LocationY, ref bool bIsCurrentlyPressed)
		{
			fixed (float* ptr = &LocationX)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &LocationY)
				{
					void* ptr4 = (void*)ptr3;
					fixed (bool* ptr5 = &bIsCurrentlyPressed)
					{
						void* ptr6 = (void*)ptr5;
						APlayerController.__GetInputTouchState_Internal(base.NativePtr, FingerIndex, ref LocationX, ref LocationY, ref bIsCurrentlyPressed);
						ptr = null;
						ptr3 = null;
					}
				}
			}
		}

		// Token: 0x060035AC RID: 13740 RVA: 0x0004C584 File Offset: 0x0004A784
		public unsafe void GetInputMouseDelta(ref float DeltaX, ref float DeltaY)
		{
			fixed (float* ptr = &DeltaX)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &DeltaY)
				{
					void* ptr4 = (void*)ptr3;
					APlayerController.__GetInputMouseDelta_Internal(base.NativePtr, ref DeltaX, ref DeltaY);
					ptr = null;
				}
			}
		}

		// Token: 0x060035AD RID: 13741 RVA: 0x0004C5B0 File Offset: 0x0004A7B0
		public unsafe void GetInputMotionState(ref FVector Tilt, ref FVector RotationRate, ref FVector Gravity, ref FVector Acceleration)
		{
			fixed (FVector* ptr = &Tilt)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &RotationRate)
				{
					void* ptr4 = (void*)ptr3;
					fixed (FVector* ptr5 = &Gravity)
					{
						void* ptr6 = (void*)ptr5;
						fixed (FVector* ptr7 = &Acceleration)
						{
							void* ptr8 = (void*)ptr7;
							APlayerController.__GetInputMotionState_Internal(base.NativePtr, ref Tilt, ref RotationRate, ref Gravity, ref Acceleration);
							ptr = null;
							ptr3 = null;
							ptr5 = null;
						}
					}
				}
			}
		}

		// Token: 0x060035AE RID: 13742 RVA: 0x0004C5FA File Offset: 0x0004A7FA
		public float GetInputKeyTimeDown(FKey Key)
		{
			return APlayerController.__GetInputKeyTimeDown_Internal(base.NativePtr, (Key ?? new FKey()).NativePtr);
		}

		// Token: 0x060035AF RID: 13743 RVA: 0x0004C616 File Offset: 0x0004A816
		public float GetInputAnalogKeyState(FKey Key)
		{
			return APlayerController.__GetInputAnalogKeyState_Internal(base.NativePtr, (Key ?? new FKey()).NativePtr);
		}

		// Token: 0x060035B0 RID: 13744 RVA: 0x0004C632 File Offset: 0x0004A832
		public bool GetHitResultUnderFingerForObjects(ETouchIndex FingerIndex, [Nullable(new byte[]
		{
			2,
			0
		})] in TArray<TEnumAsByte<EObjectTypeQuery>> ObjectTypes, bool bTraceComplex, ref FHitResult HitResult)
		{
			return APlayerController.__GetHitResultUnderFingerForObjects_Internal(base.NativePtr, FingerIndex, (ObjectTypes ?? new TArray<TEnumAsByte<EObjectTypeQuery>>()).NativePtr, bTraceComplex, (HitResult ?? new FHitResult()).NativePtr);
		}

		// Token: 0x060035B1 RID: 13745 RVA: 0x0004C667 File Offset: 0x0004A867
		public bool GetHitResultUnderFingerByChannel(ETouchIndex FingerIndex, ETraceTypeQuery TraceChannel, bool bTraceComplex, ref FHitResult HitResult)
		{
			return APlayerController.__GetHitResultUnderFingerByChannel_Internal(base.NativePtr, FingerIndex, TraceChannel, bTraceComplex, (HitResult ?? new FHitResult()).NativePtr);
		}

		// Token: 0x060035B2 RID: 13746 RVA: 0x0004C692 File Offset: 0x0004A892
		public bool GetHitResultUnderFinger(ETouchIndex FingerIndex, ECollisionChannel TraceChannel, bool bTraceComplex, ref FHitResult HitResult)
		{
			return APlayerController.__GetHitResultUnderFinger_Internal(base.NativePtr, FingerIndex, TraceChannel, bTraceComplex, (HitResult ?? new FHitResult()).NativePtr);
		}

		// Token: 0x060035B3 RID: 13747 RVA: 0x0004C6BD File Offset: 0x0004A8BD
		public bool GetHitResultUnderCursorForObjects([Nullable(new byte[]
		{
			2,
			0
		})] in TArray<TEnumAsByte<EObjectTypeQuery>> ObjectTypes, bool bTraceComplex, ref FHitResult HitResult)
		{
			return APlayerController.__GetHitResultUnderCursorForObjects_Internal(base.NativePtr, (ObjectTypes ?? new TArray<TEnumAsByte<EObjectTypeQuery>>()).NativePtr, bTraceComplex, (HitResult ?? new FHitResult()).NativePtr);
		}

		// Token: 0x060035B4 RID: 13748 RVA: 0x0004C6EB File Offset: 0x0004A8EB
		public bool GetHitResultUnderCursorByChannel(ETraceTypeQuery TraceChannel, bool bTraceComplex, ref FHitResult HitResult)
		{
			return APlayerController.__GetHitResultUnderCursorByChannel_Internal(base.NativePtr, TraceChannel, bTraceComplex, (HitResult ?? new FHitResult()).NativePtr);
		}

		// Token: 0x060035B5 RID: 13749 RVA: 0x0004C70F File Offset: 0x0004A90F
		public bool GetHitResultUnderCursor(ECollisionChannel TraceChannel, bool bTraceComplex, ref FHitResult HitResult)
		{
			return APlayerController.__GetHitResultUnderCursor_Internal(base.NativePtr, TraceChannel, bTraceComplex, (HitResult ?? new FHitResult()).NativePtr);
		}

		// Token: 0x060035B6 RID: 13750 RVA: 0x0004C733 File Offset: 0x0004A933
		public FVector GetFocalLocation()
		{
			return APlayerController.__GetFocalLocation_Internal(base.NativePtr);
		}

		// Token: 0x060035B7 RID: 13751 RVA: 0x0004C740 File Offset: 0x0004A940
		public void FOV(float NewFOV)
		{
			APlayerController.__FOV_Internal(base.NativePtr, NewFOV);
		}

		// Token: 0x060035B8 RID: 13752 RVA: 0x0004C74E File Offset: 0x0004A94E
		public void EnableCheats()
		{
			APlayerController.__EnableCheats_Internal(base.NativePtr);
		}

		// Token: 0x060035B9 RID: 13753 RVA: 0x0004C75C File Offset: 0x0004A95C
		public unsafe bool DeprojectScreenPositionToWorld(float ScreenX, float ScreenY, ref FVector WorldLocation, ref FVector WorldDirection)
		{
			fixed (FVector* ptr = &WorldLocation)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &WorldDirection)
				{
					void* ptr4 = (void*)ptr3;
					return APlayerController.__DeprojectScreenPositionToWorld_Internal(base.NativePtr, ScreenX, ScreenY, ref WorldLocation, ref WorldDirection);
				}
			}
		}

		// Token: 0x060035BA RID: 13754 RVA: 0x0004C784 File Offset: 0x0004A984
		public unsafe bool DeprojectMousePositionToWorld(ref FVector WorldLocation, ref FVector WorldDirection)
		{
			fixed (FVector* ptr = &WorldLocation)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &WorldDirection)
				{
					void* ptr4 = (void*)ptr3;
					return APlayerController.__DeprojectMousePositionToWorld_Internal(base.NativePtr, ref WorldLocation, ref WorldDirection);
				}
			}
		}

		// Token: 0x060035BB RID: 13755 RVA: 0x0004C7A8 File Offset: 0x0004A9A8
		public void ConsoleKey(FKey Key)
		{
			APlayerController.__ConsoleKey_Internal(base.NativePtr, (Key ?? new FKey()).NativePtr);
		}

		// Token: 0x060035BC RID: 13756 RVA: 0x0004C7C4 File Offset: 0x0004A9C4
		[NullableContext(1)]
		public void ClientWasKicked(in FText KickReason)
		{
			IntPtr nativePtr = base.NativePtr;
			FText ftext = KickReason;
			APlayerController.__ClientWasKicked_Internal(nativePtr, (ftext != null) ? ftext.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060035BD RID: 13757 RVA: 0x0004C7E3 File Offset: 0x0004A9E3
		public void ClientVoiceHandshakeComplete()
		{
			APlayerController.__ClientVoiceHandshakeComplete_Internal(base.NativePtr);
		}

		// Token: 0x060035BE RID: 13758 RVA: 0x0004C7F0 File Offset: 0x0004A9F0
		public void ClientUpdateLevelStreamingStatus(FName PackageName, bool bNewShouldBeLoaded, bool bNewShouldBeVisible, bool bNewShouldBlockOnLoad, int LODIndex)
		{
			APlayerController.__ClientUpdateLevelStreamingStatus_Internal(base.NativePtr, PackageName, bNewShouldBeLoaded, bNewShouldBeVisible, bNewShouldBlockOnLoad, LODIndex);
		}

		// Token: 0x060035BF RID: 13759 RVA: 0x0004C804 File Offset: 0x0004AA04
		[NullableContext(1)]
		public unsafe void ClientTravelInternal(string URL, ETravelType TravelType, bool bSeamless, FGuid MapPackageGuid)
		{
			FString fstring = FString.AllocTemp(URL);
			APlayerController.__ClientTravelInternal_Internal(base.NativePtr, fstring, TravelType, bSeamless, MapPackageGuid);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060035C0 RID: 13760 RVA: 0x0004C838 File Offset: 0x0004AA38
		[NullableContext(1)]
		public unsafe void ClientTravel(string URL, ETravelType TravelType, bool bSeamless, FGuid MapPackageGuid)
		{
			FString fstring = FString.AllocTemp(URL);
			APlayerController.__ClientTravel_Internal(base.NativePtr, fstring, TravelType, bSeamless, MapPackageGuid);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060035C1 RID: 13761 RVA: 0x0004C86B File Offset: 0x0004AA6B
		public void ClientStopForceFeedback(UForceFeedbackEffect ForceFeedbackEffect, FName Tag)
		{
			APlayerController.__ClientStopForceFeedback_Internal(base.NativePtr, (ForceFeedbackEffect != null) ? ForceFeedbackEffect.NativePtr : IntPtr.Zero, Tag);
		}

		// Token: 0x060035C2 RID: 13762 RVA: 0x0004C889 File Offset: 0x0004AA89
		public void ClientStopCameraShake([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase> Shake, bool bImmediately = true)
		{
			APlayerController.__ClientStopCameraShake_Internal(base.NativePtr, Shake._NativePtr, bImmediately);
		}

		// Token: 0x060035C3 RID: 13763 RVA: 0x0004C89D File Offset: 0x0004AA9D
		public void ClientStartOnlineSession()
		{
			APlayerController.__ClientStartOnlineSession_Internal(base.NativePtr);
		}

		// Token: 0x060035C4 RID: 13764 RVA: 0x0004C8AA File Offset: 0x0004AAAA
		public void ClientStartCameraShake([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase> Shake, float Scale = 1f, ECameraShakePlaySpace PlaySpace = ECameraShakePlaySpace.CameraLocal, FRotator UserPlaySpaceRot = default(FRotator), float TimeDilation = 1f)
		{
			APlayerController.__ClientStartCameraShake_Internal(base.NativePtr, Shake._NativePtr, Scale, PlaySpace, UserPlaySpaceRot, TimeDilation);
		}

		// Token: 0x060035C5 RID: 13765 RVA: 0x0004C8C3 File Offset: 0x0004AAC3
		public void ClientSetViewTarget(AActor A, FViewTargetTransitionParams TransitionParams)
		{
			APlayerController.__ClientSetViewTarget_Internal(base.NativePtr, (A != null) ? A.NativePtr : IntPtr.Zero, (TransitionParams ?? new FViewTargetTransitionParams()).NativePtr);
		}

		// Token: 0x060035C6 RID: 13766 RVA: 0x0004C8EF File Offset: 0x0004AAEF
		public void ClientSetSpectatorWaiting(bool bWaiting)
		{
			APlayerController.__ClientSetSpectatorWaiting_Internal(base.NativePtr, bWaiting);
		}

		// Token: 0x060035C7 RID: 13767 RVA: 0x0004C8FD File Offset: 0x0004AAFD
		public void ClientSetForceMipLevelsToBeResident(UMaterialInterface Material, float ForceDuration, int CinematicTextureGroups)
		{
			APlayerController.__ClientSetForceMipLevelsToBeResident_Internal(base.NativePtr, (Material != null) ? Material.NativePtr : IntPtr.Zero, ForceDuration, CinematicTextureGroups);
		}

		// Token: 0x060035C8 RID: 13768 RVA: 0x0004C91C File Offset: 0x0004AB1C
		public void ClientSetCinematicMode(bool bInCinematicMode, bool bAffectsMovement, bool bAffectsTurning, bool bAffectsHUD)
		{
			APlayerController.__ClientSetCinematicMode_Internal(base.NativePtr, bInCinematicMode, bAffectsMovement, bAffectsTurning, bAffectsHUD);
		}

		// Token: 0x060035C9 RID: 13769 RVA: 0x0004C92E File Offset: 0x0004AB2E
		public void ClientSetCameraMode(FName NewCamMode)
		{
			APlayerController.__ClientSetCameraMode_Internal(base.NativePtr, NewCamMode);
		}

		// Token: 0x060035CA RID: 13770 RVA: 0x0004C93C File Offset: 0x0004AB3C
		public void ClientSetCameraFade(bool bEnableFading, FColor FadeColor, FVector2D FadeAlpha, float FadeTime, bool bFadeAudio, bool bHoldWhenFinished)
		{
			APlayerController.__ClientSetCameraFade_Internal(base.NativePtr, bEnableFading, FadeColor, FadeAlpha, FadeTime, bFadeAudio, bHoldWhenFinished);
		}

		// Token: 0x060035CB RID: 13771 RVA: 0x0004C952 File Offset: 0x0004AB52
		public void ClientSetBlockOnAsyncLoading()
		{
			APlayerController.__ClientSetBlockOnAsyncLoading_Internal(base.NativePtr);
		}

		// Token: 0x060035CC RID: 13772 RVA: 0x0004C95F File Offset: 0x0004AB5F
		[NullableContext(1)]
		public void ClientReturnToMainMenuWithTextReason(in FText ReturnReason)
		{
			IntPtr nativePtr = base.NativePtr;
			FText ftext = ReturnReason;
			APlayerController.__ClientReturnToMainMenuWithTextReason_Internal(nativePtr, (ftext != null) ? ftext.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060035CD RID: 13773 RVA: 0x0004C980 File Offset: 0x0004AB80
		[NullableContext(1)]
		public unsafe void ClientReturnToMainMenu(string ReturnReason)
		{
			FString fstring = FString.AllocTemp(ReturnReason);
			APlayerController.__ClientReturnToMainMenu_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060035CE RID: 13774 RVA: 0x0004C9AA File Offset: 0x0004ABAA
		public void ClientRetryClientRestart(APawn NewPawn)
		{
			APlayerController.__ClientRetryClientRestart_Internal(base.NativePtr, (NewPawn != null) ? NewPawn.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060035CF RID: 13775 RVA: 0x0004C9C7 File Offset: 0x0004ABC7
		public void ClientRestart(APawn NewPawn)
		{
			APlayerController.__ClientRestart_Internal(base.NativePtr, (NewPawn != null) ? NewPawn.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060035D0 RID: 13776 RVA: 0x0004C9E4 File Offset: 0x0004ABE4
		public void ClientReset()
		{
			APlayerController.__ClientReset_Internal(base.NativePtr);
		}

		// Token: 0x060035D1 RID: 13777 RVA: 0x0004C9F1 File Offset: 0x0004ABF1
		public void ClientRepObjRef(UObject Object)
		{
			APlayerController.__ClientRepObjRef_Internal(base.NativePtr, (Object != null) ? Object.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060035D2 RID: 13778 RVA: 0x0004CA0E File Offset: 0x0004AC0E
		public void ClientPrestreamTextures(AActor ForcedActor, float ForceDuration, bool bEnableStreaming, int CinematicTextureGroups)
		{
			APlayerController.__ClientPrestreamTextures_Internal(base.NativePtr, (ForcedActor != null) ? ForcedActor.NativePtr : IntPtr.Zero, ForceDuration, bEnableStreaming, CinematicTextureGroups);
		}

		// Token: 0x060035D3 RID: 13779 RVA: 0x0004CA2F File Offset: 0x0004AC2F
		public void ClientPrepareMapChange(FName LevelName, bool bFirst, bool bLast)
		{
			APlayerController.__ClientPrepareMapChange_Internal(base.NativePtr, LevelName, bFirst, bLast);
		}

		// Token: 0x060035D4 RID: 13780 RVA: 0x0004CA40 File Offset: 0x0004AC40
		[NullableContext(1)]
		public unsafe void ClientMessage(string S, FName Type, float MsgLifeTime)
		{
			FString fstring = FString.AllocTemp(S);
			APlayerController.__ClientMessage_Internal(base.NativePtr, fstring, Type, MsgLifeTime);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060035D5 RID: 13781 RVA: 0x0004CA6C File Offset: 0x0004AC6C
		public void ClientIgnoreMoveInput(bool bIgnore)
		{
			APlayerController.__ClientIgnoreMoveInput_Internal(base.NativePtr, bIgnore);
		}

		// Token: 0x060035D6 RID: 13782 RVA: 0x0004CA7A File Offset: 0x0004AC7A
		public void ClientIgnoreLookInput(bool bIgnore)
		{
			APlayerController.__ClientIgnoreLookInput_Internal(base.NativePtr, bIgnore);
		}

		// Token: 0x060035D7 RID: 13783 RVA: 0x0004CA88 File Offset: 0x0004AC88
		public void ClientGotoState(FName NewState)
		{
			APlayerController.__ClientGotoState_Internal(base.NativePtr, NewState);
		}

		// Token: 0x060035D8 RID: 13784 RVA: 0x0004CA96 File Offset: 0x0004AC96
		public void ClientGameEnded(AActor EndGameFocus, bool bIsWinner)
		{
			APlayerController.__ClientGameEnded_Internal(base.NativePtr, (EndGameFocus != null) ? EndGameFocus.NativePtr : IntPtr.Zero, bIsWinner);
		}

		// Token: 0x060035D9 RID: 13785 RVA: 0x0004CAB4 File Offset: 0x0004ACB4
		public void ClientForceGarbageCollection()
		{
			APlayerController.__ClientForceGarbageCollection_Internal(base.NativePtr);
		}

		// Token: 0x060035DA RID: 13786 RVA: 0x0004CAC1 File Offset: 0x0004ACC1
		public void ClientFlushLevelStreaming()
		{
			APlayerController.__ClientFlushLevelStreaming_Internal(base.NativePtr);
		}

		// Token: 0x060035DB RID: 13787 RVA: 0x0004CACE File Offset: 0x0004ACCE
		public void ClientEndOnlineSession()
		{
			APlayerController.__ClientEndOnlineSession_Internal(base.NativePtr);
		}

		// Token: 0x060035DC RID: 13788 RVA: 0x0004CADB File Offset: 0x0004ACDB
		public void ClientEnableNetworkVoice(bool bEnable)
		{
			APlayerController.__ClientEnableNetworkVoice_Internal(base.NativePtr, bEnable);
		}

		// Token: 0x060035DD RID: 13789 RVA: 0x0004CAE9 File Offset: 0x0004ACE9
		public void ClientCommitMapChange()
		{
			APlayerController.__ClientCommitMapChange_Internal(base.NativePtr);
		}

		// Token: 0x060035DE RID: 13790 RVA: 0x0004CAF6 File Offset: 0x0004ACF6
		public void ClientClearCameraLensEffects()
		{
			APlayerController.__ClientClearCameraLensEffects_Internal(base.NativePtr);
		}

		// Token: 0x060035DF RID: 13791 RVA: 0x0004CB03 File Offset: 0x0004AD03
		public void ClientCapBandwidth(int Cap)
		{
			APlayerController.__ClientCapBandwidth_Internal(base.NativePtr, Cap);
		}

		// Token: 0x060035E0 RID: 13792 RVA: 0x0004CB11 File Offset: 0x0004AD11
		public void ClientCancelPendingMapChange()
		{
			APlayerController.__ClientCancelPendingMapChange_Internal(base.NativePtr);
		}

		// Token: 0x060035E1 RID: 13793 RVA: 0x0004CB1E File Offset: 0x0004AD1E
		public void ClientAddTextureStreamingLoc(FVector InLoc, float Duration, bool bOverrideLocation)
		{
			APlayerController.__ClientAddTextureStreamingLoc_Internal(base.NativePtr, InLoc, Duration, bOverrideLocation);
		}

		// Token: 0x060035E2 RID: 13794 RVA: 0x0004CB2E File Offset: 0x0004AD2E
		public void ClearAudioListenerOverride()
		{
			APlayerController.__ClearAudioListenerOverride_Internal(base.NativePtr);
		}

		// Token: 0x060035E3 RID: 13795 RVA: 0x0004CB3B File Offset: 0x0004AD3B
		public void ClearAudioListenerAttenuationOverride()
		{
			APlayerController.__ClearAudioListenerAttenuationOverride_Internal(base.NativePtr);
		}

		// Token: 0x060035E4 RID: 13796 RVA: 0x0004CB48 File Offset: 0x0004AD48
		public bool CanRestartPlayer()
		{
			return APlayerController.__CanRestartPlayer_Internal(base.NativePtr);
		}

		// Token: 0x060035E5 RID: 13797 RVA: 0x0004CB55 File Offset: 0x0004AD55
		public void Camera(FName NewMode)
		{
			APlayerController.__Camera_Internal(base.NativePtr, NewMode);
		}

		// Token: 0x060035E6 RID: 13798 RVA: 0x0004CB63 File Offset: 0x0004AD63
		public void AddYawInput(float Val)
		{
			APlayerController.__AddYawInput_Internal(base.NativePtr, Val);
		}

		// Token: 0x060035E7 RID: 13799 RVA: 0x0004CB71 File Offset: 0x0004AD71
		public void AddRollInput(float Val)
		{
			APlayerController.__AddRollInput_Internal(base.NativePtr, Val);
		}

		// Token: 0x060035E8 RID: 13800 RVA: 0x0004CB7F File Offset: 0x0004AD7F
		public void AddPitchInput(float Val)
		{
			APlayerController.__AddPitchInput_Internal(base.NativePtr, Val);
		}

		// Token: 0x060035E9 RID: 13801
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __WasInputKeyJustReleased_Internal(IntPtr @this, IntPtr Key);

		// Token: 0x060035EA RID: 13802
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __WasInputKeyJustPressed_Internal(IntPtr @this, IntPtr Key);

		// Token: 0x060035EB RID: 13803
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ToggleSpeaking_Internal(IntPtr @this, bool bInSpeaking);

		// Token: 0x060035EC RID: 13804
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TestServerLevelVisibilityChange_Internal(IntPtr @this, FName PackageName, FName FileName);

		// Token: 0x060035ED RID: 13805
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SwitchLevel_Internal(IntPtr @this, in FString URL);

		// Token: 0x060035EE RID: 13806
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __StreamingSourceShouldBlockOnSlowStreaming_Internal(IntPtr @this);

		// Token: 0x060035EF RID: 13807
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __StreamingSourceShouldActivate_Internal(IntPtr @this);

		// Token: 0x060035F0 RID: 13808
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartFire_Internal(IntPtr @this, byte FireModeNum);

		// Token: 0x060035F1 RID: 13809
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnPlayerCameraManager_Internal(IntPtr @this);

		// Token: 0x060035F2 RID: 13810
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVirtualJoystickVisibility_Internal(IntPtr @this, bool bVisible);

		// Token: 0x060035F3 RID: 13811
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetViewTargetWithBlendCurve_Internal(IntPtr @this, IntPtr NewViewTarget, float BlendTime, TEnumAsByte<EViewTargetBlendFunction> BlendFunc, float BlendExp, bool bLockOutgoing, bool bKuroEnableBlend, IntPtr BlendCurve);

		// Token: 0x060035F4 RID: 13812
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetViewTargetWithBlend_Internal(IntPtr @this, IntPtr NewViewTarget, float BlendTime, TEnumAsByte<EViewTargetBlendFunction> BlendFunc, float BlendExp, bool bLockOutgoing, bool bKuroEnableBlend);

		// Token: 0x060035F5 RID: 13813
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetName_Internal(IntPtr @this, in FString S);

		// Token: 0x060035F6 RID: 13814
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMouseLocation_Internal(IntPtr @this, int X, int Y);

		// Token: 0x060035F7 RID: 13815
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMouseCursorWidget_Internal(IntPtr @this, TEnumAsByte<EMouseCursor> Cursor, IntPtr CursorWidget);

		// Token: 0x060035F8 RID: 13816
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDisableHaptics_Internal(IntPtr @this, bool bNewDisabled);

		// Token: 0x060035F9 RID: 13817
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetControllerLightColor_Internal(IntPtr @this, FColor Color);

		// Token: 0x060035FA RID: 13818
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCinematicMode_Internal(IntPtr @this, bool bInCinematicMode, bool bHidePlayer, bool bAffectsHUD, bool bAffectsMovement, bool bAffectsTurning);

		// Token: 0x060035FB RID: 13819
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAudioListenerOverride_Internal(IntPtr @this, IntPtr AttachToComponent, FVector Location, FRotator Rotation);

		// Token: 0x060035FC RID: 13820
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAudioListenerAttenuationOverride_Internal(IntPtr @this, IntPtr AttachToComponent, FVector AttenuationLocationOVerride);

		// Token: 0x060035FD RID: 13821
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerViewSelf_Internal(IntPtr @this, IntPtr TransitionParams);

		// Token: 0x060035FE RID: 13822
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerViewPrevPlayer_Internal(IntPtr @this);

		// Token: 0x060035FF RID: 13823
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerViewNextPlayer_Internal(IntPtr @this);

		// Token: 0x06003600 RID: 13824
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerVerifyViewTarget_Internal(IntPtr @this);

		// Token: 0x06003601 RID: 13825
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerUpdateCamera_Internal(IntPtr @this, FVector_NetQuantize CamLoc, int CamPitchAndYaw);

		// Token: 0x06003602 RID: 13826
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerToggleAILogging_Internal(IntPtr @this);

		// Token: 0x06003603 RID: 13827
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerShortTimeout_Internal(IntPtr @this);

		// Token: 0x06003604 RID: 13828
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerSetSpectatorWaiting_Internal(IntPtr @this, bool bWaiting);

		// Token: 0x06003605 RID: 13829
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerSetSpectatorLocation_Internal(IntPtr @this, FVector NewLoc, FRotator NewRot);

		// Token: 0x06003606 RID: 13830
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerRestartPlayer_Internal(IntPtr @this);

		// Token: 0x06003607 RID: 13831
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerPause_Internal(IntPtr @this);

		// Token: 0x06003608 RID: 13832
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerNotifyLoadedWorld_Internal(IntPtr @this, FName WorldPackageName);

		// Token: 0x06003609 RID: 13833
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerExecRPC_Internal(IntPtr @this, in FString Msg);

		// Token: 0x0600360A RID: 13834
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerExec_Internal(IntPtr @this, in FString Msg);

		// Token: 0x0600360B RID: 13835
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerCheckClientPossessionReliable_Internal(IntPtr @this);

		// Token: 0x0600360C RID: 13836
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerCheckClientPossession_Internal(IntPtr @this);

		// Token: 0x0600360D RID: 13837
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerChangeName_Internal(IntPtr @this, in FString S);

		// Token: 0x0600360E RID: 13838
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerCamera_Internal(IntPtr @this, FName NewMode);

		// Token: 0x0600360F RID: 13839
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerAcknowledgePossession_Internal(IntPtr @this, IntPtr P);

		// Token: 0x06003610 RID: 13840
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SendToConsole_Internal(IntPtr @this, in FString Command);

		// Token: 0x06003611 RID: 13841
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RestartLevel_Internal(IntPtr @this);

		// Token: 0x06003612 RID: 13842
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetControllerLightColor_Internal(IntPtr @this);

		// Token: 0x06003613 RID: 13843
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveAdditionalPlayerCameraManagers_Internal(IntPtr @this);

		// Token: 0x06003614 RID: 13844
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ProjectWorldLocationToScreen_Internal(IntPtr @this, FVector WorldLocation, ref FVector2D ScreenLocation, bool bPlayerViewportRelative);

		// Token: 0x06003615 RID: 13845
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Pause_Internal(IntPtr @this);

		// Token: 0x06003616 RID: 13846
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnServerStartedVisualLogger_Internal(IntPtr @this, bool bIsLogging);

		// Token: 0x06003617 RID: 13847
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LocalTravel_Internal(IntPtr @this, in FString URL);

		// Token: 0x06003618 RID: 13848
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_ClientTravel_Internal(IntPtr @this, in FString URL, TEnumAsByte<ETravelType> TravelType, bool bSeamless);

		// Token: 0x06003619 RID: 13849
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_ClientPlayForceFeedback_Internal(IntPtr @this, IntPtr ForceFeedbackEffect, FName Tag, bool bLooping, bool bIgnoreTimeDilation, bool bPlayWhilePaused);

		// Token: 0x0600361A RID: 13850
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsStreamingSourceEnabled_Internal(IntPtr @this);

		// Token: 0x0600361B RID: 13851
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsInputKeyDown_Internal(IntPtr @this, IntPtr Key);

		// Token: 0x0600361C RID: 13852
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetViewportSize_Internal(IntPtr @this, ref int SizeX, ref int SizeY);

		// Token: 0x0600361D RID: 13853
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetStreamingSourceShapes_Internal(IntPtr @this, IntPtr OutShapes);

		// Token: 0x0600361E RID: 13854
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EStreamingSourcePriority __GetStreamingSourcePriority_Internal(IntPtr @this);

		// Token: 0x0600361F RID: 13855
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetStreamingSourceLocationAndRotation_Internal(IntPtr @this, ref FVector OutLocation, ref FRotator OutRotation);

		// Token: 0x06003620 RID: 13856
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetPlayerCameraManagerCount_Internal(IntPtr @this);

		// Token: 0x06003621 RID: 13857
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPlayerCameraManager_Internal(IntPtr @this, int CameraIndex);

		// Token: 0x06003622 RID: 13858
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetMousePosition_Internal(IntPtr @this, ref float LocationX, ref float LocationY);

		// Token: 0x06003623 RID: 13859
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetInputVectorKeyState_Internal(IntPtr @this, IntPtr Key);

		// Token: 0x06003624 RID: 13860
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetInputTouchState_Internal(IntPtr @this, TEnumAsByte<ETouchIndex> FingerIndex, ref float LocationX, ref float LocationY, ref bool bIsCurrentlyPressed);

		// Token: 0x06003625 RID: 13861
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetInputMouseDelta_Internal(IntPtr @this, ref float DeltaX, ref float DeltaY);

		// Token: 0x06003626 RID: 13862
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetInputMotionState_Internal(IntPtr @this, ref FVector Tilt, ref FVector RotationRate, ref FVector Gravity, ref FVector Acceleration);

		// Token: 0x06003627 RID: 13863
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetInputKeyTimeDown_Internal(IntPtr @this, IntPtr Key);

		// Token: 0x06003628 RID: 13864
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetInputAnalogKeyState_Internal(IntPtr @this, IntPtr Key);

		// Token: 0x06003629 RID: 13865
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetHitResultUnderFingerForObjects_Internal(IntPtr @this, TEnumAsByte<ETouchIndex> FingerIndex, IntPtr ObjectTypes, bool bTraceComplex, IntPtr HitResult);

		// Token: 0x0600362A RID: 13866
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetHitResultUnderFingerByChannel_Internal(IntPtr @this, TEnumAsByte<ETouchIndex> FingerIndex, TEnumAsByte<ETraceTypeQuery> TraceChannel, bool bTraceComplex, IntPtr HitResult);

		// Token: 0x0600362B RID: 13867
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetHitResultUnderFinger_Internal(IntPtr @this, TEnumAsByte<ETouchIndex> FingerIndex, TEnumAsByte<ECollisionChannel> TraceChannel, bool bTraceComplex, IntPtr HitResult);

		// Token: 0x0600362C RID: 13868
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetHitResultUnderCursorForObjects_Internal(IntPtr @this, IntPtr ObjectTypes, bool bTraceComplex, IntPtr HitResult);

		// Token: 0x0600362D RID: 13869
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetHitResultUnderCursorByChannel_Internal(IntPtr @this, TEnumAsByte<ETraceTypeQuery> TraceChannel, bool bTraceComplex, IntPtr HitResult);

		// Token: 0x0600362E RID: 13870
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetHitResultUnderCursor_Internal(IntPtr @this, TEnumAsByte<ECollisionChannel> TraceChannel, bool bTraceComplex, IntPtr HitResult);

		// Token: 0x0600362F RID: 13871
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetFocalLocation_Internal(IntPtr @this);

		// Token: 0x06003630 RID: 13872
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FOV_Internal(IntPtr @this, float NewFOV);

		// Token: 0x06003631 RID: 13873
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EnableCheats_Internal(IntPtr @this);

		// Token: 0x06003632 RID: 13874
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DeprojectScreenPositionToWorld_Internal(IntPtr @this, float ScreenX, float ScreenY, ref FVector WorldLocation, ref FVector WorldDirection);

		// Token: 0x06003633 RID: 13875
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DeprojectMousePositionToWorld_Internal(IntPtr @this, ref FVector WorldLocation, ref FVector WorldDirection);

		// Token: 0x06003634 RID: 13876
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ConsoleKey_Internal(IntPtr @this, IntPtr Key);

		// Token: 0x06003635 RID: 13877
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientWasKicked_Internal(IntPtr @this, IntPtr KickReason);

		// Token: 0x06003636 RID: 13878
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientVoiceHandshakeComplete_Internal(IntPtr @this);

		// Token: 0x06003637 RID: 13879
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientUpdateLevelStreamingStatus_Internal(IntPtr @this, FName PackageName, bool bNewShouldBeLoaded, bool bNewShouldBeVisible, bool bNewShouldBlockOnLoad, int LODIndex);

		// Token: 0x06003638 RID: 13880
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientTravelInternal_Internal(IntPtr @this, in FString URL, TEnumAsByte<ETravelType> TravelType, bool bSeamless, FGuid MapPackageGuid);

		// Token: 0x06003639 RID: 13881
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientTravel_Internal(IntPtr @this, in FString URL, TEnumAsByte<ETravelType> TravelType, bool bSeamless, FGuid MapPackageGuid);

		// Token: 0x0600363A RID: 13882
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientStopForceFeedback_Internal(IntPtr @this, IntPtr ForceFeedbackEffect, FName Tag);

		// Token: 0x0600363B RID: 13883
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientStopCameraShake_Internal(IntPtr @this, IntPtr Shake, bool bImmediately);

		// Token: 0x0600363C RID: 13884
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientStartOnlineSession_Internal(IntPtr @this);

		// Token: 0x0600363D RID: 13885
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientStartCameraShake_Internal(IntPtr @this, IntPtr Shake, float Scale, ECameraShakePlaySpace PlaySpace, FRotator UserPlaySpaceRot, float TimeDilation);

		// Token: 0x0600363E RID: 13886
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientSetViewTarget_Internal(IntPtr @this, IntPtr A, IntPtr TransitionParams);

		// Token: 0x0600363F RID: 13887
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientSetSpectatorWaiting_Internal(IntPtr @this, bool bWaiting);

		// Token: 0x06003640 RID: 13888
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientSetForceMipLevelsToBeResident_Internal(IntPtr @this, IntPtr Material, float ForceDuration, int CinematicTextureGroups);

		// Token: 0x06003641 RID: 13889
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientSetCinematicMode_Internal(IntPtr @this, bool bInCinematicMode, bool bAffectsMovement, bool bAffectsTurning, bool bAffectsHUD);

		// Token: 0x06003642 RID: 13890
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientSetCameraMode_Internal(IntPtr @this, FName NewCamMode);

		// Token: 0x06003643 RID: 13891
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientSetCameraFade_Internal(IntPtr @this, bool bEnableFading, FColor FadeColor, FVector2D FadeAlpha, float FadeTime, bool bFadeAudio, bool bHoldWhenFinished);

		// Token: 0x06003644 RID: 13892
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientSetBlockOnAsyncLoading_Internal(IntPtr @this);

		// Token: 0x06003645 RID: 13893
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientReturnToMainMenuWithTextReason_Internal(IntPtr @this, IntPtr ReturnReason);

		// Token: 0x06003646 RID: 13894
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientReturnToMainMenu_Internal(IntPtr @this, in FString ReturnReason);

		// Token: 0x06003647 RID: 13895
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientRetryClientRestart_Internal(IntPtr @this, IntPtr NewPawn);

		// Token: 0x06003648 RID: 13896
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientRestart_Internal(IntPtr @this, IntPtr NewPawn);

		// Token: 0x06003649 RID: 13897
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientReset_Internal(IntPtr @this);

		// Token: 0x0600364A RID: 13898
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientRepObjRef_Internal(IntPtr @this, IntPtr Object);

		// Token: 0x0600364B RID: 13899
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientPrestreamTextures_Internal(IntPtr @this, IntPtr ForcedActor, float ForceDuration, bool bEnableStreaming, int CinematicTextureGroups);

		// Token: 0x0600364C RID: 13900
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientPrepareMapChange_Internal(IntPtr @this, FName LevelName, bool bFirst, bool bLast);

		// Token: 0x0600364D RID: 13901
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientMessage_Internal(IntPtr @this, in FString S, FName Type, float MsgLifeTime);

		// Token: 0x0600364E RID: 13902
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientIgnoreMoveInput_Internal(IntPtr @this, bool bIgnore);

		// Token: 0x0600364F RID: 13903
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientIgnoreLookInput_Internal(IntPtr @this, bool bIgnore);

		// Token: 0x06003650 RID: 13904
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientGotoState_Internal(IntPtr @this, FName NewState);

		// Token: 0x06003651 RID: 13905
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientGameEnded_Internal(IntPtr @this, IntPtr EndGameFocus, bool bIsWinner);

		// Token: 0x06003652 RID: 13906
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientForceGarbageCollection_Internal(IntPtr @this);

		// Token: 0x06003653 RID: 13907
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientFlushLevelStreaming_Internal(IntPtr @this);

		// Token: 0x06003654 RID: 13908
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientEndOnlineSession_Internal(IntPtr @this);

		// Token: 0x06003655 RID: 13909
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientEnableNetworkVoice_Internal(IntPtr @this, bool bEnable);

		// Token: 0x06003656 RID: 13910
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientCommitMapChange_Internal(IntPtr @this);

		// Token: 0x06003657 RID: 13911
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientClearCameraLensEffects_Internal(IntPtr @this);

		// Token: 0x06003658 RID: 13912
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientCapBandwidth_Internal(IntPtr @this, int Cap);

		// Token: 0x06003659 RID: 13913
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientCancelPendingMapChange_Internal(IntPtr @this);

		// Token: 0x0600365A RID: 13914
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientAddTextureStreamingLoc_Internal(IntPtr @this, FVector InLoc, float Duration, bool bOverrideLocation);

		// Token: 0x0600365B RID: 13915
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearAudioListenerOverride_Internal(IntPtr @this);

		// Token: 0x0600365C RID: 13916
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearAudioListenerAttenuationOverride_Internal(IntPtr @this);

		// Token: 0x0600365D RID: 13917
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CanRestartPlayer_Internal(IntPtr @this);

		// Token: 0x0600365E RID: 13918
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Camera_Internal(IntPtr @this, FName NewMode);

		// Token: 0x0600365F RID: 13919
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddYawInput_Internal(IntPtr @this, float Val);

		// Token: 0x06003660 RID: 13920
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddRollInput_Internal(IntPtr @this, float Val);

		// Token: 0x06003661 RID: 13921
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddPitchInput_Internal(IntPtr @this, float Val);

		// Token: 0x06003662 RID: 13922 RVA: 0x0004CB8D File Offset: 0x0004AD8D
		static APlayerController()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PlayerController");
		}

		// Token: 0x06003663 RID: 13923 RVA: 0x0004CB9B File Offset: 0x0004AD9B
		protected APlayerController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001270 RID: 4720
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PlayerController";

		// Token: 0x04001271 RID: 4721
		private static IntPtr _ClassPtr;

		// Token: 0x04001272 RID: 4722
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001273 RID: 4723
		internal static int __PropertyOffset_AcknowledgedPawn;

		// Token: 0x04001274 RID: 4724
		internal static int __PropertyOffset_ChangeRotationOnPossess;

		// Token: 0x04001275 RID: 4725
		internal static byte __PropertyMask_ChangeRotationOnPossess;

		// Token: 0x04001276 RID: 4726
		internal static int __PropertyOffset_PlayerCameraManager;

		// Token: 0x04001277 RID: 4727
		internal static int __PropertyOffset_AdditionalPlayerCameraManagers;

		// Token: 0x04001278 RID: 4728
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<APlayerCameraManager> _AdditionalPlayerCameraManagers;

		// Token: 0x04001279 RID: 4729
		internal static int __PropertyOffset_PlayerCameraManagerClass;

		// Token: 0x0400127A RID: 4730
		internal static int __PropertyOffset_bAutoManageActiveCameraTarget;

		// Token: 0x0400127B RID: 4731
		internal static int __PropertyOffset_TargetViewRotation;

		// Token: 0x0400127C RID: 4732
		internal static int __PropertyOffset_SmoothTargetViewRotationSpeed;

		// Token: 0x0400127D RID: 4733
		internal static int __PropertyOffset_HiddenActors;

		// Token: 0x0400127E RID: 4734
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _HiddenActors;

		// Token: 0x0400127F RID: 4735
		internal static int __PropertyOffset_HiddenPrimitiveComponents;

		// Token: 0x04001280 RID: 4736
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<UPrimitiveComponent>> _HiddenPrimitiveComponents;

		// Token: 0x04001281 RID: 4737
		internal static int __PropertyOffset_LastSpectatorStateSynchTime;

		// Token: 0x04001282 RID: 4738
		internal static int __PropertyOffset_LastSpectatorSyncLocation;

		// Token: 0x04001283 RID: 4739
		internal static int __PropertyOffset_LastSpectatorSyncRotation;

		// Token: 0x04001284 RID: 4740
		internal static int __PropertyOffset_ClientCap;

		// Token: 0x04001285 RID: 4741
		internal static int __PropertyOffset_CheatManager;

		// Token: 0x04001286 RID: 4742
		internal static int __PropertyOffset_CheatClass;

		// Token: 0x04001287 RID: 4743
		internal static int __PropertyOffset_bPlayerIsWaiting;

		// Token: 0x04001288 RID: 4744
		internal static byte __PropertyMask_bPlayerIsWaiting;

		// Token: 0x04001289 RID: 4745
		internal static int __PropertyOffset_NetPlayerIndex;

		// Token: 0x0400128A RID: 4746
		internal static int __PropertyOffset_InputYawScale;

		// Token: 0x0400128B RID: 4747
		internal static int __PropertyOffset_InputPitchScale;

		// Token: 0x0400128C RID: 4748
		internal static int __PropertyOffset_InputRollScale;

		// Token: 0x0400128D RID: 4749
		internal static int __PropertyOffset_bShowMouseCursor;

		// Token: 0x0400128E RID: 4750
		internal static byte __PropertyMask_bShowMouseCursor;

		// Token: 0x0400128F RID: 4751
		internal static int __PropertyOffset_bEnableClickEvents;

		// Token: 0x04001290 RID: 4752
		internal static byte __PropertyMask_bEnableClickEvents;

		// Token: 0x04001291 RID: 4753
		internal static int __PropertyOffset_bEnableTouchEvents;

		// Token: 0x04001292 RID: 4754
		internal static byte __PropertyMask_bEnableTouchEvents;

		// Token: 0x04001293 RID: 4755
		internal static int __PropertyOffset_bEnableMouseOverEvents;

		// Token: 0x04001294 RID: 4756
		internal static byte __PropertyMask_bEnableMouseOverEvents;

		// Token: 0x04001295 RID: 4757
		internal static int __PropertyOffset_bEnableTouchOverEvents;

		// Token: 0x04001296 RID: 4758
		internal static byte __PropertyMask_bEnableTouchOverEvents;

		// Token: 0x04001297 RID: 4759
		internal static int __PropertyOffset_bForceFeedbackEnabled;

		// Token: 0x04001298 RID: 4760
		internal static byte __PropertyMask_bForceFeedbackEnabled;

		// Token: 0x04001299 RID: 4761
		internal static int __PropertyOffset_bEnableStreamingSource;

		// Token: 0x0400129A RID: 4762
		internal static byte __PropertyMask_bEnableStreamingSource;

		// Token: 0x0400129B RID: 4763
		internal static int __PropertyOffset_bStreamingSourceShouldActivate;

		// Token: 0x0400129C RID: 4764
		internal static byte __PropertyMask_bStreamingSourceShouldActivate;

		// Token: 0x0400129D RID: 4765
		internal static int __PropertyOffset_TargetBehavior;

		// Token: 0x0400129E RID: 4766
		internal static int __PropertyOffset_TargetGrids;

		// Token: 0x0400129F RID: 4767
		private TArray<FName> _TargetGrids;

		// Token: 0x040012A0 RID: 4768
		internal static int __PropertyOffset_bStreamingSourceShouldBlockOnSlowStreaming;

		// Token: 0x040012A1 RID: 4769
		internal static byte __PropertyMask_bStreamingSourceShouldBlockOnSlowStreaming;

		// Token: 0x040012A2 RID: 4770
		internal static int __PropertyOffset_StreamingSourcePriority;

		// Token: 0x040012A3 RID: 4771
		internal static int __PropertyOffset_StreamingSourceDebugColor;

		// Token: 0x040012A4 RID: 4772
		internal static int __PropertyOffset_StreamingSourceShapes;

		// Token: 0x040012A5 RID: 4773
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FStreamingSourceShape> _StreamingSourceShapes;

		// Token: 0x040012A6 RID: 4774
		internal static int __PropertyOffset_ForceFeedbackScale;

		// Token: 0x040012A7 RID: 4775
		internal static int __PropertyOffset_ClickEventKeys;

		// Token: 0x040012A8 RID: 4776
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKey> _ClickEventKeys;

		// Token: 0x040012A9 RID: 4777
		internal static int __PropertyOffset_DefaultMouseCursor;

		// Token: 0x040012AA RID: 4778
		internal static int __PropertyOffset_CurrentMouseCursor;

		// Token: 0x040012AB RID: 4779
		internal static int __PropertyOffset_DefaultClickTraceChannel;

		// Token: 0x040012AC RID: 4780
		internal static int __PropertyOffset_CurrentClickTraceChannel;

		// Token: 0x040012AD RID: 4781
		internal static int __PropertyOffset_HitResultTraceDistance;

		// Token: 0x040012AE RID: 4782
		internal static int __PropertyOffset_SeamlessTravelCount;

		// Token: 0x040012AF RID: 4783
		internal static int __PropertyOffset_LastCompletedSeamlessTravelCount;

		// Token: 0x040012B0 RID: 4784
		internal static int __PropertyOffset_SeamlessCameraActor;

		// Token: 0x040012B1 RID: 4785
		internal static int __PropertyOffset_bUseSeamlessCameraActor;

		// Token: 0x040012B2 RID: 4786
		internal static byte __PropertyMask_bUseSeamlessCameraActor;

		// Token: 0x040012B3 RID: 4787
		internal static int __PropertyOffset_bShouldPerformFullTickWhenPaused;

		// Token: 0x040012B4 RID: 4788
		internal static byte __PropertyMask_bShouldPerformFullTickWhenPaused;

		// Token: 0x040012B5 RID: 4789
		internal static int __PropertyOffset_bIsLocalPlayerController;

		// Token: 0x040012B6 RID: 4790
		internal static int __PropertyOffset_SpawnLocation;
	}
}
