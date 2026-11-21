using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000AA RID: 170
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.AIController")]
	[UnrealStructLayout(1312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1312)]
	public class AAIController : AController, IUnrealUObject, IUnrealObject, IGameplayTaskOwnerInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06000CDA RID: 3290 RVA: 0x0001477F File Offset: 0x0001297F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AAIController._ClassPtr;
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x0001478B File Offset: 0x0001298B
		int IGameplayTaskOwnerInterface.InterfaceOffset()
		{
			return AAIController.__InterfaceOffset_IGameplayTaskOwnerInterface;
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x00014794 File Offset: 0x00012994
		public AAIController() : this(BuiltinUtils.AllocNativeUObject(AAIController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x000147BC File Offset: 0x000129BC
		[NullableContext(1)]
		public AAIController(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AAIController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000CDE RID: 3294 RVA: 0x000147EF File Offset: 0x000129EF
		// (set) Token: 0x06000CDF RID: 3295 RVA: 0x00014808 File Offset: 0x00012A08
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

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000CE0 RID: 3296 RVA: 0x00014838 File Offset: 0x00012A38
		// (set) Token: 0x06000CE1 RID: 3297 RVA: 0x00014851 File Offset: 0x00012A51
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

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000CE2 RID: 3298 RVA: 0x00014881 File Offset: 0x00012A81
		// (set) Token: 0x06000CE3 RID: 3299 RVA: 0x0001489A File Offset: 0x00012A9A
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

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000CE4 RID: 3300 RVA: 0x000148CA File Offset: 0x00012ACA
		// (set) Token: 0x06000CE5 RID: 3301 RVA: 0x000148E3 File Offset: 0x00012AE3
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

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000CE6 RID: 3302 RVA: 0x00014913 File Offset: 0x00012B13
		// (set) Token: 0x06000CE7 RID: 3303 RVA: 0x0001492C File Offset: 0x00012B2C
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

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000CE8 RID: 3304 RVA: 0x0001495C File Offset: 0x00012B5C
		// (set) Token: 0x06000CE9 RID: 3305 RVA: 0x00014975 File Offset: 0x00012B75
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

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000CEA RID: 3306 RVA: 0x000149A5 File Offset: 0x00012BA5
		// (set) Token: 0x06000CEB RID: 3307 RVA: 0x000149BE File Offset: 0x00012BBE
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

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000CEC RID: 3308 RVA: 0x000149EE File Offset: 0x00012BEE
		// (set) Token: 0x06000CED RID: 3309 RVA: 0x00014A02 File Offset: 0x00012C02
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

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000CEE RID: 3310 RVA: 0x00014A17 File Offset: 0x00012C17
		// (set) Token: 0x06000CEF RID: 3311 RVA: 0x00014A2B File Offset: 0x00012C2B
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

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000CF0 RID: 3312 RVA: 0x00014A40 File Offset: 0x00012C40
		// (set) Token: 0x06000CF1 RID: 3313 RVA: 0x00014A54 File Offset: 0x00012C54
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

		// Token: 0x06000CF2 RID: 3314 RVA: 0x00014A69 File Offset: 0x00012C69
		public void SetMoveBlockDetection(bool bEnable)
		{
			AAIController.__SetMoveBlockDetection_Internal(base.NativePtr, bEnable);
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x00014A77 File Offset: 0x00012C77
		public bool RunBehaviorTree(UBehaviorTree BTAsset)
		{
			return AAIController.__RunBehaviorTree_Internal(base.NativePtr, (BTAsset != null) ? BTAsset.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x00014A94 File Offset: 0x00012C94
		public void K2_SetFocus(AActor NewFocus)
		{
			AAIController.__K2_SetFocus_Internal(base.NativePtr, (NewFocus != null) ? NewFocus.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x00014AB1 File Offset: 0x00012CB1
		public void K2_SetFocalPoint(FVector FP)
		{
			AAIController.__K2_SetFocalPoint_Internal(base.NativePtr, FP);
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x00014ABF File Offset: 0x00012CBF
		public void K2_ClearFocus()
		{
			AAIController.__K2_ClearFocus_Internal(base.NativePtr);
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x00014ACC File Offset: 0x00012CCC
		public bool HasPartialPath()
		{
			return AAIController.__HasPartialPath_Internal(base.NativePtr);
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x00014AD9 File Offset: 0x00012CD9
		public FVector GetImmediateMoveDestination()
		{
			return AAIController.__GetImmediateMoveDestination_Internal(base.NativePtr);
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x00014AE6 File Offset: 0x00012CE6
		public AActor GetFocusActor()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(AAIController.__GetFocusActor_Internal(base.NativePtr));
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x00014AF8 File Offset: 0x00012CF8
		public FVector GetFocalPointOnActor(AActor Actor)
		{
			return AAIController.__GetFocalPointOnActor_Internal(base.NativePtr, (Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x00014B15 File Offset: 0x00012D15
		public FVector GetFocalPoint()
		{
			return AAIController.__GetFocalPoint_Internal(base.NativePtr);
		}

		// Token: 0x06000CFC RID: 3324
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMoveBlockDetection_Internal(IntPtr @this, bool bEnable);

		// Token: 0x06000CFD RID: 3325
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RunBehaviorTree_Internal(IntPtr @this, IntPtr BTAsset);

		// Token: 0x06000CFE RID: 3326
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_SetFocus_Internal(IntPtr @this, IntPtr NewFocus);

		// Token: 0x06000CFF RID: 3327
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_SetFocalPoint_Internal(IntPtr @this, FVector FP);

		// Token: 0x06000D00 RID: 3328
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_ClearFocus_Internal(IntPtr @this);

		// Token: 0x06000D01 RID: 3329
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasPartialPath_Internal(IntPtr @this);

		// Token: 0x06000D02 RID: 3330
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetImmediateMoveDestination_Internal(IntPtr @this);

		// Token: 0x06000D03 RID: 3331
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetFocusActor_Internal(IntPtr @this);

		// Token: 0x06000D04 RID: 3332
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetFocalPointOnActor_Internal(IntPtr @this, IntPtr Actor);

		// Token: 0x06000D05 RID: 3333
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetFocalPoint_Internal(IntPtr @this);

		// Token: 0x06000D06 RID: 3334 RVA: 0x00014B22 File Offset: 0x00012D22
		static AAIController()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.AIController");
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x00014B30 File Offset: 0x00012D30
		protected AAIController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000221 RID: 545
		internal static int __InterfaceOffset_IGameplayTaskOwnerInterface;

		// Token: 0x04000222 RID: 546
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.AIController";

		// Token: 0x04000223 RID: 547
		private static IntPtr _ClassPtr;

		// Token: 0x04000224 RID: 548
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000225 RID: 549
		internal static int __PropertyOffset_bStartAILogicOnPossess;

		// Token: 0x04000226 RID: 550
		internal static byte __PropertyMask_bStartAILogicOnPossess;

		// Token: 0x04000227 RID: 551
		internal static int __PropertyOffset_bStopAILogicOnUnposses;

		// Token: 0x04000228 RID: 552
		internal static byte __PropertyMask_bStopAILogicOnUnposses;

		// Token: 0x04000229 RID: 553
		internal static int __PropertyOffset_bLOSflag;

		// Token: 0x0400022A RID: 554
		internal static byte __PropertyMask_bLOSflag;

		// Token: 0x0400022B RID: 555
		internal static int __PropertyOffset_bSkipExtraLOSChecks;

		// Token: 0x0400022C RID: 556
		internal static byte __PropertyMask_bSkipExtraLOSChecks;

		// Token: 0x0400022D RID: 557
		internal static int __PropertyOffset_bAllowStrafe;

		// Token: 0x0400022E RID: 558
		internal static byte __PropertyMask_bAllowStrafe;

		// Token: 0x0400022F RID: 559
		internal static int __PropertyOffset_bWantsPlayerState;

		// Token: 0x04000230 RID: 560
		internal static byte __PropertyMask_bWantsPlayerState;

		// Token: 0x04000231 RID: 561
		internal static int __PropertyOffset_bSetControlRotationFromPawnOrientation;

		// Token: 0x04000232 RID: 562
		internal static byte __PropertyMask_bSetControlRotationFromPawnOrientation;

		// Token: 0x04000233 RID: 563
		internal static int __PropertyOffset_BrainComponent;

		// Token: 0x04000234 RID: 564
		internal static int __PropertyOffset_CachedGameplayTasksComponent;

		// Token: 0x04000235 RID: 565
		internal static int __PropertyOffset_DefaultNavigationFilterClass;
	}
}
