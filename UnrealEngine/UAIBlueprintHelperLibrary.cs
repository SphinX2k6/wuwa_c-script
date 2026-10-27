using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000E1 RID: 225
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.AIBlueprintHelperLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UAIBlueprintHelperLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060011D6 RID: 4566 RVA: 0x0001AB35 File Offset: 0x00018D35
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAIBlueprintHelperLibrary._ClassPtr;
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x0001AB44 File Offset: 0x00018D44
		public UAIBlueprintHelperLibrary() : this(BuiltinUtils.AllocNativeUObject(UAIBlueprintHelperLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x0001AB6C File Offset: 0x00018D6C
		[NullableContext(1)]
		public UAIBlueprintHelperLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAIBlueprintHelperLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x0001AB9F File Offset: 0x00018D9F
		public static void UnlockAIResourcesWithAnimation(UAnimInstance AnimInstance, bool bUnlockMovement, bool UnlockAILogic)
		{
			UAIBlueprintHelperLibrary.__UnlockAIResourcesWithAnimation_Internal((AnimInstance != null) ? AnimInstance.NativePtr : IntPtr.Zero, bUnlockMovement, UnlockAILogic);
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x0001ABB8 File Offset: 0x00018DB8
		public static APawn SpawnAIFromClass(UObject WorldContextObject, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<APawn> PawnClass, UBehaviorTree BehaviorTree, FVector Location, FRotator Rotation = default(FRotator), bool bNoCollisionFail = false, AActor Owner = null)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(UAIBlueprintHelperLibrary.__SpawnAIFromClass_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, PawnClass._NativePtr, (BehaviorTree != null) ? BehaviorTree.NativePtr : IntPtr.Zero, Location, Rotation, bNoCollisionFail, (Owner != null) ? Owner.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x0001AC0C File Offset: 0x00018E0C
		public static void SimpleMoveToLocation(AController Controller, in FVector Goal)
		{
			UAIBlueprintHelperLibrary.__SimpleMoveToLocation_Internal((Controller != null) ? Controller.NativePtr : IntPtr.Zero, Goal);
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x0001AC24 File Offset: 0x00018E24
		public static void SimpleMoveToActor(AController Controller, AActor Goal)
		{
			UAIBlueprintHelperLibrary.__SimpleMoveToActor_Internal((Controller != null) ? Controller.NativePtr : IntPtr.Zero, (Goal != null) ? Goal.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x0001AC4B File Offset: 0x00018E4B
		public static void SendAIMessage(APawn Target, FName Message, UObject MessageSource, bool bSuccess = true)
		{
			UAIBlueprintHelperLibrary.__SendAIMessage_Internal((Target != null) ? Target.NativePtr : IntPtr.Zero, Message, (MessageSource != null) ? MessageSource.NativePtr : IntPtr.Zero, bSuccess);
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x0001AC74 File Offset: 0x00018E74
		public static void LockAIResourcesWithAnimation(UAnimInstance AnimInstance, bool bLockMovement, bool LockAILogic)
		{
			UAIBlueprintHelperLibrary.__LockAIResourcesWithAnimation_Internal((AnimInstance != null) ? AnimInstance.NativePtr : IntPtr.Zero, bLockMovement, LockAILogic);
		}

		// Token: 0x060011DF RID: 4575
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsValidAIRotation(FRotator Rotation);

		// Token: 0x060011E0 RID: 4576
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsValidAILocation(FVector Location);

		// Token: 0x060011E1 RID: 4577
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsValidAIDirection(FVector DirectionVector);

		// Token: 0x060011E2 RID: 4578 RVA: 0x0001AC8D File Offset: 0x00018E8D
		public static int GetNextNavLinkIndex(AController Controller)
		{
			return UAIBlueprintHelperLibrary.__GetNextNavLinkIndex_Internal((Controller != null) ? Controller.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x0001ACA4 File Offset: 0x00018EA4
		[NullableContext(1)]
		public static TArray<FVector> GetCurrentPathPoints([Nullable(2)] AController Controller)
		{
			return new TArray<FVector>(UAIBlueprintHelperLibrary.__GetCurrentPathPoints_Internal((Controller != null) ? Controller.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x0001ACC1 File Offset: 0x00018EC1
		public static int GetCurrentPathIndex(AController Controller)
		{
			return UAIBlueprintHelperLibrary.__GetCurrentPathIndex_Internal((Controller != null) ? Controller.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x0001ACD8 File Offset: 0x00018ED8
		public static UNavigationPath GetCurrentPath(AController Controller)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UNavigationPath>(UAIBlueprintHelperLibrary.__GetCurrentPath_Internal((Controller != null) ? Controller.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x0001ACF4 File Offset: 0x00018EF4
		public static UBlackboardComponent GetBlackboard(AActor Target)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UBlackboardComponent>(UAIBlueprintHelperLibrary.__GetBlackboard_Internal((Target != null) ? Target.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060011E7 RID: 4583 RVA: 0x0001AD10 File Offset: 0x00018F10
		public static AAIController GetAIController(AActor ControlledActor)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(UAIBlueprintHelperLibrary.__GetAIController_Internal((ControlledActor != null) ? ControlledActor.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x0001AD2C File Offset: 0x00018F2C
		public static void D_SimpleMoveToLocation(AController Controller, in FVectorDouble Goal)
		{
			UAIBlueprintHelperLibrary.__D_SimpleMoveToLocation_Internal((Controller != null) ? Controller.NativePtr : IntPtr.Zero, Goal);
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x0001AD44 File Offset: 0x00018F44
		public static UAIAsyncTaskBlueprintProxy CreateMoveToProxyObject(UObject WorldContextObject, APawn Pawn, FVector Destination, AActor TargetActor = null, float AcceptanceRadius = 5f, bool bStopOnOverlap = false)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAIAsyncTaskBlueprintProxy>(UAIBlueprintHelperLibrary.__CreateMoveToProxyObject_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Pawn != null) ? Pawn.NativePtr : IntPtr.Zero, Destination, (TargetActor != null) ? TargetActor.NativePtr : IntPtr.Zero, AcceptanceRadius, bStopOnOverlap));
		}

		// Token: 0x060011EA RID: 4586
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnlockAIResourcesWithAnimation_Internal(IntPtr AnimInstance, bool bUnlockMovement, bool UnlockAILogic);

		// Token: 0x060011EB RID: 4587
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnAIFromClass_Internal(IntPtr WorldContextObject, IntPtr PawnClass, IntPtr BehaviorTree, FVector Location, FRotator Rotation, bool bNoCollisionFail, IntPtr Owner);

		// Token: 0x060011EC RID: 4588
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SimpleMoveToLocation_Internal(IntPtr Controller, in FVector Goal);

		// Token: 0x060011ED RID: 4589
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SimpleMoveToActor_Internal(IntPtr Controller, IntPtr Goal);

		// Token: 0x060011EE RID: 4590
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SendAIMessage_Internal(IntPtr Target, FName Message, IntPtr MessageSource, bool bSuccess);

		// Token: 0x060011EF RID: 4591
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LockAIResourcesWithAnimation_Internal(IntPtr AnimInstance, bool bLockMovement, bool LockAILogic);

		// Token: 0x060011F0 RID: 4592
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNextNavLinkIndex_Internal(IntPtr Controller);

		// Token: 0x060011F1 RID: 4593
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCurrentPathPoints_Internal(IntPtr Controller);

		// Token: 0x060011F2 RID: 4594
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetCurrentPathIndex_Internal(IntPtr Controller);

		// Token: 0x060011F3 RID: 4595
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCurrentPath_Internal(IntPtr Controller);

		// Token: 0x060011F4 RID: 4596
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetBlackboard_Internal(IntPtr Target);

		// Token: 0x060011F5 RID: 4597
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAIController_Internal(IntPtr ControlledActor);

		// Token: 0x060011F6 RID: 4598
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_SimpleMoveToLocation_Internal(IntPtr Controller, in FVectorDouble Goal);

		// Token: 0x060011F7 RID: 4599
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateMoveToProxyObject_Internal(IntPtr WorldContextObject, IntPtr Pawn, FVector Destination, IntPtr TargetActor, float AcceptanceRadius, bool bStopOnOverlap);

		// Token: 0x060011F8 RID: 4600 RVA: 0x0001AD90 File Offset: 0x00018F90
		static UAIBlueprintHelperLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.AIBlueprintHelperLibrary");
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x0001AD9E File Offset: 0x00018F9E
		protected UAIBlueprintHelperLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040002F8 RID: 760
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.AIBlueprintHelperLibrary";

		// Token: 0x040002F9 RID: 761
		private static IntPtr _ClassPtr;

		// Token: 0x040002FA RID: 762
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
