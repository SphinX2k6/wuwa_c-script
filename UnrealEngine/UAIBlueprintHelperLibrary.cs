using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000A9 RID: 169
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.AIBlueprintHelperLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UAIBlueprintHelperLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06000CBA RID: 3258 RVA: 0x00014576 File Offset: 0x00012776
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAIBlueprintHelperLibrary._ClassPtr;
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x00014584 File Offset: 0x00012784
		public UAIBlueprintHelperLibrary() : this(BuiltinUtils.AllocNativeUObject(UAIBlueprintHelperLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x000145AC File Offset: 0x000127AC
		[NullableContext(1)]
		public UAIBlueprintHelperLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAIBlueprintHelperLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06000CBD RID: 3261 RVA: 0x000145DF File Offset: 0x000127DF
		public static void UnlockAIResourcesWithAnimation(UAnimInstance AnimInstance, bool bUnlockMovement, bool UnlockAILogic)
		{
			UAIBlueprintHelperLibrary.__UnlockAIResourcesWithAnimation_Internal((AnimInstance != null) ? AnimInstance.NativePtr : IntPtr.Zero, bUnlockMovement, UnlockAILogic);
		}

		// Token: 0x06000CBE RID: 3262 RVA: 0x000145F8 File Offset: 0x000127F8
		public static APawn SpawnAIFromClass(UObject WorldContextObject, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<APawn> PawnClass, UBehaviorTree BehaviorTree, FVector Location, FRotator Rotation = default(FRotator), bool bNoCollisionFail = false, AActor Owner = null)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(UAIBlueprintHelperLibrary.__SpawnAIFromClass_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, PawnClass._NativePtr, (BehaviorTree != null) ? BehaviorTree.NativePtr : IntPtr.Zero, Location, Rotation, bNoCollisionFail, (Owner != null) ? Owner.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x0001464C File Offset: 0x0001284C
		public static void SimpleMoveToLocation(AController Controller, in FVector Goal)
		{
			UAIBlueprintHelperLibrary.__SimpleMoveToLocation_Internal((Controller != null) ? Controller.NativePtr : IntPtr.Zero, Goal);
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x00014664 File Offset: 0x00012864
		public static void SimpleMoveToActor(AController Controller, AActor Goal)
		{
			UAIBlueprintHelperLibrary.__SimpleMoveToActor_Internal((Controller != null) ? Controller.NativePtr : IntPtr.Zero, (Goal != null) ? Goal.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x0001468B File Offset: 0x0001288B
		public static void SendAIMessage(APawn Target, FName Message, UObject MessageSource, bool bSuccess = true)
		{
			UAIBlueprintHelperLibrary.__SendAIMessage_Internal((Target != null) ? Target.NativePtr : IntPtr.Zero, Message, (MessageSource != null) ? MessageSource.NativePtr : IntPtr.Zero, bSuccess);
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x000146B4 File Offset: 0x000128B4
		public static void LockAIResourcesWithAnimation(UAnimInstance AnimInstance, bool bLockMovement, bool LockAILogic)
		{
			UAIBlueprintHelperLibrary.__LockAIResourcesWithAnimation_Internal((AnimInstance != null) ? AnimInstance.NativePtr : IntPtr.Zero, bLockMovement, LockAILogic);
		}

		// Token: 0x06000CC3 RID: 3267
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsValidAIRotation(FRotator Rotation);

		// Token: 0x06000CC4 RID: 3268
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsValidAILocation(FVector Location);

		// Token: 0x06000CC5 RID: 3269
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsValidAIDirection(FVector DirectionVector);

		// Token: 0x06000CC6 RID: 3270 RVA: 0x000146CD File Offset: 0x000128CD
		public static int GetNextNavLinkIndex(AController Controller)
		{
			return UAIBlueprintHelperLibrary.__GetNextNavLinkIndex_Internal((Controller != null) ? Controller.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x000146E4 File Offset: 0x000128E4
		[NullableContext(1)]
		public static TArray<FVector> GetCurrentPathPoints([Nullable(2)] AController Controller)
		{
			return new TArray<FVector>(UAIBlueprintHelperLibrary.__GetCurrentPathPoints_Internal((Controller != null) ? Controller.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x00014701 File Offset: 0x00012901
		public static int GetCurrentPathIndex(AController Controller)
		{
			return UAIBlueprintHelperLibrary.__GetCurrentPathIndex_Internal((Controller != null) ? Controller.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x00014718 File Offset: 0x00012918
		public static UNavigationPath GetCurrentPath(AController Controller)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UNavigationPath>(UAIBlueprintHelperLibrary.__GetCurrentPath_Internal((Controller != null) ? Controller.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x00014734 File Offset: 0x00012934
		public static AAIController GetAIController(AActor ControlledActor)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(UAIBlueprintHelperLibrary.__GetAIController_Internal((ControlledActor != null) ? ControlledActor.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x00014750 File Offset: 0x00012950
		public static void D_SimpleMoveToLocation(AController Controller, in FVectorDouble Goal)
		{
			UAIBlueprintHelperLibrary.__D_SimpleMoveToLocation_Internal((Controller != null) ? Controller.NativePtr : IntPtr.Zero, Goal);
		}

		// Token: 0x06000CCC RID: 3276
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnlockAIResourcesWithAnimation_Internal(IntPtr AnimInstance, bool bUnlockMovement, bool UnlockAILogic);

		// Token: 0x06000CCD RID: 3277
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnAIFromClass_Internal(IntPtr WorldContextObject, IntPtr PawnClass, IntPtr BehaviorTree, FVector Location, FRotator Rotation, bool bNoCollisionFail, IntPtr Owner);

		// Token: 0x06000CCE RID: 3278
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SimpleMoveToLocation_Internal(IntPtr Controller, in FVector Goal);

		// Token: 0x06000CCF RID: 3279
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SimpleMoveToActor_Internal(IntPtr Controller, IntPtr Goal);

		// Token: 0x06000CD0 RID: 3280
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SendAIMessage_Internal(IntPtr Target, FName Message, IntPtr MessageSource, bool bSuccess);

		// Token: 0x06000CD1 RID: 3281
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LockAIResourcesWithAnimation_Internal(IntPtr AnimInstance, bool bLockMovement, bool LockAILogic);

		// Token: 0x06000CD2 RID: 3282
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNextNavLinkIndex_Internal(IntPtr Controller);

		// Token: 0x06000CD3 RID: 3283
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCurrentPathPoints_Internal(IntPtr Controller);

		// Token: 0x06000CD4 RID: 3284
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetCurrentPathIndex_Internal(IntPtr Controller);

		// Token: 0x06000CD5 RID: 3285
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCurrentPath_Internal(IntPtr Controller);

		// Token: 0x06000CD6 RID: 3286
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAIController_Internal(IntPtr ControlledActor);

		// Token: 0x06000CD7 RID: 3287
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_SimpleMoveToLocation_Internal(IntPtr Controller, in FVectorDouble Goal);

		// Token: 0x06000CD8 RID: 3288 RVA: 0x00014768 File Offset: 0x00012968
		static UAIBlueprintHelperLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.AIBlueprintHelperLibrary");
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x00014776 File Offset: 0x00012976
		protected UAIBlueprintHelperLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400021E RID: 542
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.AIBlueprintHelperLibrary";

		// Token: 0x0400021F RID: 543
		private static IntPtr _ClassPtr;

		// Token: 0x04000220 RID: 544
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
