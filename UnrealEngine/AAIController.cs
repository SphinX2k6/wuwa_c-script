using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000E2 RID: 226
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.AIController")]
	[UnrealStructLayout(1312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1312)]
	public class AAIController : AController, IUnrealUObject, IUnrealObject, IAIPerceptionListenerInterface, IUnrealNativeInterface, IUnrealInterface, IGameplayTaskOwnerInterface, IGenericTeamAgentInterface, IVisualLoggerDebugSnapshotInterface
	{
		// Token: 0x060011FA RID: 4602 RVA: 0x0001ADA7 File Offset: 0x00018FA7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AAIController._ClassPtr;
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x0001ADB3 File Offset: 0x00018FB3
		int IAIPerceptionListenerInterface.InterfaceOffset()
		{
			return AAIController.__InterfaceOffset_IAIPerceptionListenerInterface;
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x0001ADBA File Offset: 0x00018FBA
		int IGameplayTaskOwnerInterface.InterfaceOffset()
		{
			return AAIController.__InterfaceOffset_IGameplayTaskOwnerInterface;
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x0001ADC1 File Offset: 0x00018FC1
		int IGenericTeamAgentInterface.InterfaceOffset()
		{
			return AAIController.__InterfaceOffset_IGenericTeamAgentInterface;
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x0001ADC8 File Offset: 0x00018FC8
		int IVisualLoggerDebugSnapshotInterface.InterfaceOffset()
		{
			return AAIController.__InterfaceOffset_IVisualLoggerDebugSnapshotInterface;
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x0001ADD0 File Offset: 0x00018FD0
		public AAIController() : this(BuiltinUtils.AllocNativeUObject(AAIController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x0001ADF8 File Offset: 0x00018FF8
		[NullableContext(1)]
		public AAIController(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AAIController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06001201 RID: 4609 RVA: 0x0001AE2B File Offset: 0x0001902B
		// (set) Token: 0x06001202 RID: 4610 RVA: 0x0001AE44 File Offset: 0x00019044
		public unsafe bool bStartAILogicOnPossess
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AAIController.__PropertyOffset_bStartAILogicOnPossess) & AAIController.__PropertyMask_bStartAILogicOnPossess) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AAIController.__PropertyOffset_bStartAILogicOnPossess) = ((*(base.NativePtr + (IntPtr)AAIController.__PropertyOffset_bStartAILogicOnPossess) & ~AAIController.__PropertyMask_bStartAILogicOnPossess) | (value ? AAIController.__PropertyMask_bStartAILogicOnPossess : 0));
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06001203 RID: 4611 RVA: 0x0001AE74 File Offset: 0x00019074
		// (set) Token: 0x06001204 RID: 4612 RVA: 0x0001AE8D File Offset: 0x0001908D
		public unsafe bool bStopAILogicOnUnposses
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AAIController.__PropertyOffset_bStopAILogicOnUnposses) & AAIController.__PropertyMask_bStopAILogicOnUnposses) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AAIController.__PropertyOffset_bStopAILogicOnUnposses) = ((*(base.NativePtr + (IntPtr)AAIController.__PropertyOffset_bStopAILogicOnUnposses) & ~AAIController.__PropertyMask_bStopAILogicOnUnposses) | (value ? AAIController.__PropertyMask_bStopAILogicOnUnposses : 0));
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06001205 RID: 4613 RVA: 0x0001AEBD File Offset: 0x000190BD
		// (set) Token: 0x06001206 RID: 4614 RVA: 0x0001AED6 File Offset: 0x000190D6
		public unsafe bool bLOSflag
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AAIController.__PropertyOffset_bLOSflag) & AAIController.__PropertyMask_bLOSflag) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AAIController.__PropertyOffset_bLOSflag) = ((*(base.NativePtr + (IntPtr)AAIController.__PropertyOffset_bLOSflag) & ~AAIController.__PropertyMask_bLOSflag) | (value ? AAIController.__PropertyMask_bLOSflag : 0));
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06001207 RID: 4615 RVA: 0x0001AF06 File Offset: 0x00019106
		// (set) Token: 0x06001208 RID: 4616 RVA: 0x0001AF1F File Offset: 0x0001911F
		public unsafe bool bSkipExtraLOSChecks
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AAIController.__PropertyOffset_bSkipExtraLOSChecks) & AAIController.__PropertyMask_bSkipExtraLOSChecks) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AAIController.__PropertyOffset_bSkipExtraLOSChecks) = ((*(base.NativePtr + (IntPtr)AAIController.__PropertyOffset_bSkipExtraLOSChecks) & ~AAIController.__PropertyMask_bSkipExtraLOSChecks) | (value ? AAIController.__PropertyMask_bSkipExtraLOSChecks : 0));
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06001209 RID: 4617 RVA: 0x0001AF4F File Offset: 0x0001914F
		// (set) Token: 0x0600120A RID: 4618 RVA: 0x0001AF68 File Offset: 0x00019168
		public unsafe bool bAllowStrafe
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AAIController.__PropertyOffset_bAllowStrafe) & AAIController.__PropertyMask_bAllowStrafe) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AAIController.__PropertyOffset_bAllowStrafe) = ((*(base.NativePtr + (IntPtr)AAIController.__PropertyOffset_bAllowStrafe) & ~AAIController.__PropertyMask_bAllowStrafe) | (value ? AAIController.__PropertyMask_bAllowStrafe : 0));
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x0600120B RID: 4619 RVA: 0x0001AF98 File Offset: 0x00019198
		// (set) Token: 0x0600120C RID: 4620 RVA: 0x0001AFB1 File Offset: 0x000191B1
		public unsafe bool bWantsPlayerState
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AAIController.__PropertyOffset_bWantsPlayerState) & AAIController.__PropertyMask_bWantsPlayerState) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AAIController.__PropertyOffset_bWantsPlayerState) = ((*(base.NativePtr + (IntPtr)AAIController.__PropertyOffset_bWantsPlayerState) & ~AAIController.__PropertyMask_bWantsPlayerState) | (value ? AAIController.__PropertyMask_bWantsPlayerState : 0));
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x0600120D RID: 4621 RVA: 0x0001AFE1 File Offset: 0x000191E1
		// (set) Token: 0x0600120E RID: 4622 RVA: 0x0001AFFA File Offset: 0x000191FA
		public unsafe bool bSetControlRotationFromPawnOrientation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AAIController.__PropertyOffset_bSetControlRotationFromPawnOrientation) & AAIController.__PropertyMask_bSetControlRotationFromPawnOrientation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AAIController.__PropertyOffset_bSetControlRotationFromPawnOrientation) = ((*(base.NativePtr + (IntPtr)AAIController.__PropertyOffset_bSetControlRotationFromPawnOrientation) & ~AAIController.__PropertyMask_bSetControlRotationFromPawnOrientation) | (value ? AAIController.__PropertyMask_bSetControlRotationFromPawnOrientation : 0));
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x0600120F RID: 4623 RVA: 0x0001B02A File Offset: 0x0001922A
		// (set) Token: 0x06001210 RID: 4624 RVA: 0x0001B03E File Offset: 0x0001923E
		public unsafe UPathFollowingComponent PathFollowingComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPathFollowingComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AAIController.__PropertyOffset_PathFollowingComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AAIController.__PropertyOffset_PathFollowingComponent, value);
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06001211 RID: 4625 RVA: 0x0001B053 File Offset: 0x00019253
		// (set) Token: 0x06001212 RID: 4626 RVA: 0x0001B067 File Offset: 0x00019267
		public unsafe UBrainComponent BrainComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBrainComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AAIController.__PropertyOffset_BrainComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AAIController.__PropertyOffset_BrainComponent, value);
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06001213 RID: 4627 RVA: 0x0001B07C File Offset: 0x0001927C
		// (set) Token: 0x06001214 RID: 4628 RVA: 0x0001B090 File Offset: 0x00019290
		public unsafe UAIPerceptionComponent PerceptionComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAIPerceptionComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AAIController.__PropertyOffset_PerceptionComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AAIController.__PropertyOffset_PerceptionComponent, value);
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06001215 RID: 4629 RVA: 0x0001B0A5 File Offset: 0x000192A5
		// (set) Token: 0x06001216 RID: 4630 RVA: 0x0001B0B9 File Offset: 0x000192B9
		public unsafe UPawnActionsComponent ActionsComp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPawnActionsComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AAIController.__PropertyOffset_ActionsComp);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AAIController.__PropertyOffset_ActionsComp, value);
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06001217 RID: 4631 RVA: 0x0001B0CE File Offset: 0x000192CE
		// (set) Token: 0x06001218 RID: 4632 RVA: 0x0001B0E2 File Offset: 0x000192E2
		public unsafe UBlackboardComponent Blackboard
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBlackboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AAIController.__PropertyOffset_Blackboard);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AAIController.__PropertyOffset_Blackboard, value);
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06001219 RID: 4633 RVA: 0x0001B0F7 File Offset: 0x000192F7
		// (set) Token: 0x0600121A RID: 4634 RVA: 0x0001B10B File Offset: 0x0001930B
		public unsafe UGameplayTasksComponent CachedGameplayTasksComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGameplayTasksComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AAIController.__PropertyOffset_CachedGameplayTasksComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AAIController.__PropertyOffset_CachedGameplayTasksComponent, value);
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x0600121B RID: 4635 RVA: 0x0001B120 File Offset: 0x00019320
		// (set) Token: 0x0600121C RID: 4636 RVA: 0x0001B134 File Offset: 0x00019334
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UNavigationQueryFilter> DefaultNavigationFilterClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)AAIController.__PropertyOffset_DefaultNavigationFilterClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)AAIController.__PropertyOffset_DefaultNavigationFilterClass) = value;
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x0600121D RID: 4637 RVA: 0x0001B14C File Offset: 0x0001934C
		// (set) Token: 0x0600121E RID: 4638 RVA: 0x0001B185 File Offset: 0x00019385
		[Nullable(1)]
		public FAIMoveCompletedSignature ReceiveMoveCompleted
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FAIMoveCompletedSignature result;
				if ((result = this._ReceiveMoveCompleted) == null)
				{
					result = (this._ReceiveMoveCompleted = new FAIMoveCompletedSignature(base.NativePtr + (IntPtr)AAIController.__PropertyOffset_ReceiveMoveCompleted, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AAIController.__PropertyOffset_ReceiveMoveCompleted, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x0001B1A8 File Offset: 0x000193A8
		public bool UseBlackboard(UBlackboardData BlackboardAsset, ref UBlackboardComponent BlackboardComponent)
		{
			UBlackboardComponent ublackboardComponent = BlackboardComponent;
			IntPtr nativeObjectPtr = (ublackboardComponent != null) ? ublackboardComponent.NativePtr : IntPtr.Zero;
			bool result = AAIController.__UseBlackboard_Internal(base.NativePtr, (BlackboardAsset != null) ? BlackboardAsset.NativePtr : IntPtr.Zero, ref nativeObjectPtr);
			BlackboardComponent = BuiltinUtils.GetOrCreateUObjectByNativePointer<UBlackboardComponent>(nativeObjectPtr);
			return result;
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x0001B1ED File Offset: 0x000193ED
		public void UnclaimTaskResource([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UGameplayTaskResource> ResourceClass)
		{
			AAIController.__UnclaimTaskResource_Internal(base.NativePtr, ResourceClass._NativePtr);
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x0001B200 File Offset: 0x00019400
		public void SetPathFollowingComponent(UPathFollowingComponent NewPFComponent)
		{
			AAIController.__SetPathFollowingComponent_Internal(base.NativePtr, (NewPFComponent != null) ? NewPFComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001222 RID: 4642 RVA: 0x0001B21D File Offset: 0x0001941D
		public void SetMoveBlockDetection(bool bEnable)
		{
			AAIController.__SetMoveBlockDetection_Internal(base.NativePtr, bEnable);
		}

		// Token: 0x06001223 RID: 4643 RVA: 0x0001B22B File Offset: 0x0001942B
		public bool RunBehaviorTree(UBehaviorTree BTAsset)
		{
			return AAIController.__RunBehaviorTree_Internal(base.NativePtr, (BTAsset != null) ? BTAsset.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x0001B248 File Offset: 0x00019448
		public virtual void OnUsingBlackBoard(UBlackboardComponent BlackboardComp, UBlackboardData BlackboardAsset)
		{
			AAIController.__OnUsingBlackBoard_Internal(base.NativePtr, (BlackboardComp != null) ? BlackboardComp.NativePtr : IntPtr.Zero, (BlackboardAsset != null) ? BlackboardAsset.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001225 RID: 4645 RVA: 0x0001B275 File Offset: 0x00019475
		public void OnGameplayTaskResourcesClaimed(FGameplayResourceSet NewlyClaimed, FGameplayResourceSet FreshlyReleased)
		{
			AAIController.__OnGameplayTaskResourcesClaimed_Internal(base.NativePtr, (NewlyClaimed ?? new FGameplayResourceSet()).NativePtr, (FreshlyReleased ?? new FGameplayResourceSet()).NativePtr);
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x0001B2A0 File Offset: 0x000194A0
		[NullableContext(0)]
		public TEnumAsByte<EPathFollowingRequestResult> MoveToLocation(in FVector Dest, float AcceptanceRadius = -1f, bool bStopOnOverlap = true, bool bUsePathfinding = true, bool bProjectDestinationToNavigation = false, bool bCanStrafe = true, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavigationQueryFilter> FilterClass = default(TSubclassOf<UNavigationQueryFilter>), bool bAllowPartialPath = true)
		{
			return AAIController.__MoveToLocation_Internal(base.NativePtr, Dest, AcceptanceRadius, bStopOnOverlap, bUsePathfinding, bProjectDestinationToNavigation, bCanStrafe, FilterClass._NativePtr, bAllowPartialPath);
		}

		// Token: 0x06001227 RID: 4647 RVA: 0x0001B2CA File Offset: 0x000194CA
		[NullableContext(0)]
		public TEnumAsByte<EPathFollowingRequestResult> MoveToActor([Nullable(2)] AActor Goal, float AcceptanceRadius = -1f, bool bStopOnOverlap = true, bool bUsePathfinding = true, bool bCanStrafe = true, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavigationQueryFilter> FilterClass = default(TSubclassOf<UNavigationQueryFilter>), bool bAllowPartialPath = true)
		{
			return AAIController.__MoveToActor_Internal(base.NativePtr, (Goal != null) ? Goal.NativePtr : IntPtr.Zero, AcceptanceRadius, bStopOnOverlap, bUsePathfinding, bCanStrafe, FilterClass._NativePtr, bAllowPartialPath);
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x0001B2F6 File Offset: 0x000194F6
		public void K2_SetFocus(AActor NewFocus)
		{
			AAIController.__K2_SetFocus_Internal(base.NativePtr, (NewFocus != null) ? NewFocus.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x0001B313 File Offset: 0x00019513
		public void K2_SetFocalPoint(FVector FP)
		{
			AAIController.__K2_SetFocalPoint_Internal(base.NativePtr, FP);
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x0001B321 File Offset: 0x00019521
		public void K2_ClearFocus()
		{
			AAIController.__K2_ClearFocus_Internal(base.NativePtr);
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x0001B32E File Offset: 0x0001952E
		public bool HasPartialPath()
		{
			return AAIController.__HasPartialPath_Internal(base.NativePtr);
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x0001B33B File Offset: 0x0001953B
		public UPathFollowingComponent GetPathFollowingComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UPathFollowingComponent>(AAIController.__GetPathFollowingComponent_Internal(base.NativePtr));
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x0001B34D File Offset: 0x0001954D
		[NullableContext(0)]
		public TEnumAsByte<EPathFollowingStatus> GetMoveStatus()
		{
			return AAIController.__GetMoveStatus_Internal(base.NativePtr);
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x0001B35A File Offset: 0x0001955A
		public FVector GetImmediateMoveDestination()
		{
			return AAIController.__GetImmediateMoveDestination_Internal(base.NativePtr);
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x0001B367 File Offset: 0x00019567
		public AActor GetFocusActor()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(AAIController.__GetFocusActor_Internal(base.NativePtr));
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x0001B379 File Offset: 0x00019579
		public FVector GetFocalPointOnActor(AActor Actor)
		{
			return AAIController.__GetFocalPointOnActor_Internal(base.NativePtr, (Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x0001B396 File Offset: 0x00019596
		public FVector GetFocalPoint()
		{
			return AAIController.__GetFocalPoint_Internal(base.NativePtr);
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x0001B3A3 File Offset: 0x000195A3
		public UAIPerceptionComponent GetAIPerceptionComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAIPerceptionComponent>(AAIController.__GetAIPerceptionComponent_Internal(base.NativePtr));
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x0001B3B5 File Offset: 0x000195B5
		public void ClaimTaskResource([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UGameplayTaskResource> ResourceClass)
		{
			AAIController.__ClaimTaskResource_Internal(base.NativePtr, ResourceClass._NativePtr);
		}

		// Token: 0x06001234 RID: 4660
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __UseBlackboard_Internal(IntPtr @this, IntPtr BlackboardAsset, ref IntPtr BlackboardComponent);

		// Token: 0x06001235 RID: 4661
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnclaimTaskResource_Internal(IntPtr @this, IntPtr ResourceClass);

		// Token: 0x06001236 RID: 4662
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPathFollowingComponent_Internal(IntPtr @this, IntPtr NewPFComponent);

		// Token: 0x06001237 RID: 4663
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMoveBlockDetection_Internal(IntPtr @this, bool bEnable);

		// Token: 0x06001238 RID: 4664
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RunBehaviorTree_Internal(IntPtr @this, IntPtr BTAsset);

		// Token: 0x06001239 RID: 4665
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnUsingBlackBoard_Internal(IntPtr @this, IntPtr BlackboardComp, IntPtr BlackboardAsset);

		// Token: 0x0600123A RID: 4666
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnGameplayTaskResourcesClaimed_Internal(IntPtr @this, IntPtr NewlyClaimed, IntPtr FreshlyReleased);

		// Token: 0x0600123B RID: 4667
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<EPathFollowingRequestResult> __MoveToLocation_Internal(IntPtr @this, in FVector Dest, float AcceptanceRadius, bool bStopOnOverlap, bool bUsePathfinding, bool bProjectDestinationToNavigation, bool bCanStrafe, IntPtr FilterClass, bool bAllowPartialPath);

		// Token: 0x0600123C RID: 4668
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<EPathFollowingRequestResult> __MoveToActor_Internal(IntPtr @this, IntPtr Goal, float AcceptanceRadius, bool bStopOnOverlap, bool bUsePathfinding, bool bCanStrafe, IntPtr FilterClass, bool bAllowPartialPath);

		// Token: 0x0600123D RID: 4669
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_SetFocus_Internal(IntPtr @this, IntPtr NewFocus);

		// Token: 0x0600123E RID: 4670
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_SetFocalPoint_Internal(IntPtr @this, FVector FP);

		// Token: 0x0600123F RID: 4671
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_ClearFocus_Internal(IntPtr @this);

		// Token: 0x06001240 RID: 4672
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasPartialPath_Internal(IntPtr @this);

		// Token: 0x06001241 RID: 4673
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPathFollowingComponent_Internal(IntPtr @this);

		// Token: 0x06001242 RID: 4674
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<EPathFollowingStatus> __GetMoveStatus_Internal(IntPtr @this);

		// Token: 0x06001243 RID: 4675
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetImmediateMoveDestination_Internal(IntPtr @this);

		// Token: 0x06001244 RID: 4676
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetFocusActor_Internal(IntPtr @this);

		// Token: 0x06001245 RID: 4677
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetFocalPointOnActor_Internal(IntPtr @this, IntPtr Actor);

		// Token: 0x06001246 RID: 4678
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetFocalPoint_Internal(IntPtr @this);

		// Token: 0x06001247 RID: 4679
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAIPerceptionComponent_Internal(IntPtr @this);

		// Token: 0x06001248 RID: 4680
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClaimTaskResource_Internal(IntPtr @this, IntPtr ResourceClass);

		// Token: 0x06001249 RID: 4681 RVA: 0x0001B3C8 File Offset: 0x000195C8
		static AAIController()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.AIController");
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x0001B3D6 File Offset: 0x000195D6
		protected AAIController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040002FB RID: 763
		internal static int __InterfaceOffset_IAIPerceptionListenerInterface;

		// Token: 0x040002FC RID: 764
		internal static int __InterfaceOffset_IGameplayTaskOwnerInterface;

		// Token: 0x040002FD RID: 765
		internal static int __InterfaceOffset_IGenericTeamAgentInterface;

		// Token: 0x040002FE RID: 766
		internal static int __InterfaceOffset_IVisualLoggerDebugSnapshotInterface;

		// Token: 0x040002FF RID: 767
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.AIController";

		// Token: 0x04000300 RID: 768
		private static IntPtr _ClassPtr;

		// Token: 0x04000301 RID: 769
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000302 RID: 770
		internal static int __PropertyOffset_bStartAILogicOnPossess;

		// Token: 0x04000303 RID: 771
		internal static byte __PropertyMask_bStartAILogicOnPossess;

		// Token: 0x04000304 RID: 772
		internal static int __PropertyOffset_bStopAILogicOnUnposses;

		// Token: 0x04000305 RID: 773
		internal static byte __PropertyMask_bStopAILogicOnUnposses;

		// Token: 0x04000306 RID: 774
		internal static int __PropertyOffset_bLOSflag;

		// Token: 0x04000307 RID: 775
		internal static byte __PropertyMask_bLOSflag;

		// Token: 0x04000308 RID: 776
		internal static int __PropertyOffset_bSkipExtraLOSChecks;

		// Token: 0x04000309 RID: 777
		internal static byte __PropertyMask_bSkipExtraLOSChecks;

		// Token: 0x0400030A RID: 778
		internal static int __PropertyOffset_bAllowStrafe;

		// Token: 0x0400030B RID: 779
		internal static byte __PropertyMask_bAllowStrafe;

		// Token: 0x0400030C RID: 780
		internal static int __PropertyOffset_bWantsPlayerState;

		// Token: 0x0400030D RID: 781
		internal static byte __PropertyMask_bWantsPlayerState;

		// Token: 0x0400030E RID: 782
		internal static int __PropertyOffset_bSetControlRotationFromPawnOrientation;

		// Token: 0x0400030F RID: 783
		internal static byte __PropertyMask_bSetControlRotationFromPawnOrientation;

		// Token: 0x04000310 RID: 784
		internal static int __PropertyOffset_PathFollowingComponent;

		// Token: 0x04000311 RID: 785
		internal static int __PropertyOffset_BrainComponent;

		// Token: 0x04000312 RID: 786
		internal static int __PropertyOffset_PerceptionComponent;

		// Token: 0x04000313 RID: 787
		internal static int __PropertyOffset_ActionsComp;

		// Token: 0x04000314 RID: 788
		internal static int __PropertyOffset_Blackboard;

		// Token: 0x04000315 RID: 789
		internal static int __PropertyOffset_CachedGameplayTasksComponent;

		// Token: 0x04000316 RID: 790
		internal static int __PropertyOffset_DefaultNavigationFilterClass;

		// Token: 0x04000317 RID: 791
		internal static int __PropertyOffset_ReceiveMoveCompleted;

		// Token: 0x04000318 RID: 792
		private FAIMoveCompletedSignature _ReceiveMoveCompleted;

		// Token: 0x02002B40 RID: 11072
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnUsingBlackBoard_FunctionParams
		{
			// Token: 0x0401639F RID: 91039
			[FieldOffset(0)]
			public IntPtr BlackboardComp;

			// Token: 0x040163A0 RID: 91040
			[FieldOffset(8)]
			public IntPtr BlackboardAsset;
		}
	}
}
