using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000B2 RID: 178
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.BTDecorator_BlueprintBase")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public abstract class UBTDecorator_BlueprintBase : UBTDecorator, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06000D54 RID: 3412 RVA: 0x000151B1 File Offset: 0x000133B1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTDecorator_BlueprintBase._ClassPtr;
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000D55 RID: 3413 RVA: 0x000151BD File Offset: 0x000133BD
		// (set) Token: 0x06000D56 RID: 3414 RVA: 0x000151D1 File Offset: 0x000133D1
		public unsafe AAIController AIOwner
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AAIController>(base.NativePtr / (IntPtr)sizeof(void*) + UBTDecorator_BlueprintBase.__PropertyOffset_AIOwner);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBTDecorator_BlueprintBase.__PropertyOffset_AIOwner, value);
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000D57 RID: 3415 RVA: 0x000151E6 File Offset: 0x000133E6
		// (set) Token: 0x06000D58 RID: 3416 RVA: 0x000151FA File Offset: 0x000133FA
		public unsafe AActor ActorOwner
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UBTDecorator_BlueprintBase.__PropertyOffset_ActorOwner);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBTDecorator_BlueprintBase.__PropertyOffset_ActorOwner, value);
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000D59 RID: 3417 RVA: 0x00015210 File Offset: 0x00013410
		// (set) Token: 0x06000D5A RID: 3418 RVA: 0x00015249 File Offset: 0x00013449
		[Nullable(1)]
		public TArray<FName> ObservedKeyNames
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._ObservedKeyNames) == null)
				{
					result = (this._ObservedKeyNames = new TArray<FName>(base.NativePtr + (IntPtr)UBTDecorator_BlueprintBase.__PropertyOffset_ObservedKeyNames, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ObservedKeyNames.CopyAssign(value);
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000D5B RID: 3419 RVA: 0x00015257 File Offset: 0x00013457
		// (set) Token: 0x06000D5C RID: 3420 RVA: 0x00015270 File Offset: 0x00013470
		public unsafe bool bShowPropertyDetails
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBTDecorator_BlueprintBase.__PropertyOffset_bShowPropertyDetails) & UBTDecorator_BlueprintBase.__PropertyMask_bShowPropertyDetails) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBTDecorator_BlueprintBase.__PropertyOffset_bShowPropertyDetails) = ((*(base.NativePtr + (IntPtr)UBTDecorator_BlueprintBase.__PropertyOffset_bShowPropertyDetails) & ~UBTDecorator_BlueprintBase.__PropertyMask_bShowPropertyDetails) | (value ? UBTDecorator_BlueprintBase.__PropertyMask_bShowPropertyDetails : 0));
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000D5D RID: 3421 RVA: 0x000152A0 File Offset: 0x000134A0
		// (set) Token: 0x06000D5E RID: 3422 RVA: 0x000152B9 File Offset: 0x000134B9
		public unsafe bool bCheckConditionOnlyBlackBoardChanges
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBTDecorator_BlueprintBase.__PropertyOffset_bCheckConditionOnlyBlackBoardChanges) & UBTDecorator_BlueprintBase.__PropertyMask_bCheckConditionOnlyBlackBoardChanges) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBTDecorator_BlueprintBase.__PropertyOffset_bCheckConditionOnlyBlackBoardChanges) = ((*(base.NativePtr + (IntPtr)UBTDecorator_BlueprintBase.__PropertyOffset_bCheckConditionOnlyBlackBoardChanges) & ~UBTDecorator_BlueprintBase.__PropertyMask_bCheckConditionOnlyBlackBoardChanges) | (value ? UBTDecorator_BlueprintBase.__PropertyMask_bCheckConditionOnlyBlackBoardChanges : 0));
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000D5F RID: 3423 RVA: 0x000152E9 File Offset: 0x000134E9
		// (set) Token: 0x06000D60 RID: 3424 RVA: 0x00015302 File Offset: 0x00013502
		public unsafe bool bIsObservingBB
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBTDecorator_BlueprintBase.__PropertyOffset_bIsObservingBB) & UBTDecorator_BlueprintBase.__PropertyMask_bIsObservingBB) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBTDecorator_BlueprintBase.__PropertyOffset_bIsObservingBB) = ((*(base.NativePtr + (IntPtr)UBTDecorator_BlueprintBase.__PropertyOffset_bIsObservingBB) & ~UBTDecorator_BlueprintBase.__PropertyMask_bIsObservingBB) | (value ? UBTDecorator_BlueprintBase.__PropertyMask_bIsObservingBB : 0));
			}
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x00015332 File Offset: 0x00013532
		public virtual void ReceiveTickAI(AAIController OwnerController, APawn ControlledPawn, float DeltaSeconds)
		{
			UBTDecorator_BlueprintBase.__ReceiveTickAI_Internal(base.NativePtr, (OwnerController != null) ? OwnerController.NativePtr : IntPtr.Zero, (ControlledPawn != null) ? ControlledPawn.NativePtr : IntPtr.Zero, DeltaSeconds);
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x00015360 File Offset: 0x00013560
		public virtual void ReceiveTick(AActor OwnerActor, float DeltaSeconds)
		{
			UBTDecorator_BlueprintBase.__ReceiveTick_Internal(base.NativePtr, (OwnerActor != null) ? OwnerActor.NativePtr : IntPtr.Zero, DeltaSeconds);
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x0001537E File Offset: 0x0001357E
		public virtual void ReceiveObserverDeactivatedAI(AAIController OwnerController, APawn ControlledPawn)
		{
			UBTDecorator_BlueprintBase.__ReceiveObserverDeactivatedAI_Internal(base.NativePtr, (OwnerController != null) ? OwnerController.NativePtr : IntPtr.Zero, (ControlledPawn != null) ? ControlledPawn.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x000153AB File Offset: 0x000135AB
		public virtual void ReceiveObserverDeactivated(AActor OwnerActor)
		{
			UBTDecorator_BlueprintBase.__ReceiveObserverDeactivated_Internal(base.NativePtr, (OwnerActor != null) ? OwnerActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x000153C8 File Offset: 0x000135C8
		public virtual void ReceiveObserverActivatedAI(AAIController OwnerController, APawn ControlledPawn)
		{
			UBTDecorator_BlueprintBase.__ReceiveObserverActivatedAI_Internal(base.NativePtr, (OwnerController != null) ? OwnerController.NativePtr : IntPtr.Zero, (ControlledPawn != null) ? ControlledPawn.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x000153F5 File Offset: 0x000135F5
		public virtual void ReceiveObserverActivated(AActor OwnerActor)
		{
			UBTDecorator_BlueprintBase.__ReceiveObserverActivated_Internal(base.NativePtr, (OwnerActor != null) ? OwnerActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x00015412 File Offset: 0x00013612
		public virtual void ReceiveExecutionStartAI(AAIController OwnerController, APawn ControlledPawn)
		{
			UBTDecorator_BlueprintBase.__ReceiveExecutionStartAI_Internal(base.NativePtr, (OwnerController != null) ? OwnerController.NativePtr : IntPtr.Zero, (ControlledPawn != null) ? ControlledPawn.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x0001543F File Offset: 0x0001363F
		public virtual void ReceiveExecutionStart(AActor OwnerActor)
		{
			UBTDecorator_BlueprintBase.__ReceiveExecutionStart_Internal(base.NativePtr, (OwnerActor != null) ? OwnerActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x0001545C File Offset: 0x0001365C
		public virtual void ReceiveExecutionFinishAI(AAIController OwnerController, APawn ControlledPawn, EBTNodeResult NodeResult)
		{
			UBTDecorator_BlueprintBase.__ReceiveExecutionFinishAI_Internal(base.NativePtr, (OwnerController != null) ? OwnerController.NativePtr : IntPtr.Zero, (ControlledPawn != null) ? ControlledPawn.NativePtr : IntPtr.Zero, NodeResult);
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x0001548F File Offset: 0x0001368F
		public virtual void ReceiveExecutionFinish(AActor OwnerActor, EBTNodeResult NodeResult)
		{
			UBTDecorator_BlueprintBase.__ReceiveExecutionFinish_Internal(base.NativePtr, (OwnerActor != null) ? OwnerActor.NativePtr : IntPtr.Zero, NodeResult);
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x000154B2 File Offset: 0x000136B2
		public virtual bool PerformConditionCheckAI(AAIController OwnerController, APawn ControlledPawn)
		{
			return UBTDecorator_BlueprintBase.__PerformConditionCheckAI_Internal(base.NativePtr, (OwnerController != null) ? OwnerController.NativePtr : IntPtr.Zero, (ControlledPawn != null) ? ControlledPawn.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x000154DF File Offset: 0x000136DF
		public virtual bool PerformConditionCheck(AActor OwnerActor)
		{
			return UBTDecorator_BlueprintBase.__PerformConditionCheck_Internal(base.NativePtr, (OwnerActor != null) ? OwnerActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x000154FC File Offset: 0x000136FC
		public bool IsDecoratorObserverActive()
		{
			return UBTDecorator_BlueprintBase.__IsDecoratorObserverActive_Internal(base.NativePtr);
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x00015509 File Offset: 0x00013709
		public bool IsDecoratorExecutionActive()
		{
			return UBTDecorator_BlueprintBase.__IsDecoratorExecutionActive_Internal(base.NativePtr);
		}

		// Token: 0x06000D6F RID: 3439
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveTickAI_Internal(IntPtr @this, IntPtr OwnerController, IntPtr ControlledPawn, float DeltaSeconds);

		// Token: 0x06000D70 RID: 3440
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveTick_Internal(IntPtr @this, IntPtr OwnerActor, float DeltaSeconds);

		// Token: 0x06000D71 RID: 3441
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveObserverDeactivatedAI_Internal(IntPtr @this, IntPtr OwnerController, IntPtr ControlledPawn);

		// Token: 0x06000D72 RID: 3442
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveObserverDeactivated_Internal(IntPtr @this, IntPtr OwnerActor);

		// Token: 0x06000D73 RID: 3443
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveObserverActivatedAI_Internal(IntPtr @this, IntPtr OwnerController, IntPtr ControlledPawn);

		// Token: 0x06000D74 RID: 3444
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveObserverActivated_Internal(IntPtr @this, IntPtr OwnerActor);

		// Token: 0x06000D75 RID: 3445
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveExecutionStartAI_Internal(IntPtr @this, IntPtr OwnerController, IntPtr ControlledPawn);

		// Token: 0x06000D76 RID: 3446
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveExecutionStart_Internal(IntPtr @this, IntPtr OwnerActor);

		// Token: 0x06000D77 RID: 3447
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveExecutionFinishAI_Internal(IntPtr @this, IntPtr OwnerController, IntPtr ControlledPawn, TEnumAsByte<EBTNodeResult> NodeResult);

		// Token: 0x06000D78 RID: 3448
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveExecutionFinish_Internal(IntPtr @this, IntPtr OwnerActor, TEnumAsByte<EBTNodeResult> NodeResult);

		// Token: 0x06000D79 RID: 3449
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __PerformConditionCheckAI_Internal(IntPtr @this, IntPtr OwnerController, IntPtr ControlledPawn);

		// Token: 0x06000D7A RID: 3450
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __PerformConditionCheck_Internal(IntPtr @this, IntPtr OwnerActor);

		// Token: 0x06000D7B RID: 3451
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsDecoratorObserverActive_Internal(IntPtr @this);

		// Token: 0x06000D7C RID: 3452
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsDecoratorExecutionActive_Internal(IntPtr @this);

		// Token: 0x06000D7D RID: 3453 RVA: 0x00015516 File Offset: 0x00013716
		static UBTDecorator_BlueprintBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTDecorator_BlueprintBase");
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x00015524 File Offset: 0x00013724
		protected UBTDecorator_BlueprintBase() : this(BuiltinUtils.AllocNativeUObject(UBTDecorator_BlueprintBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x0001554C File Offset: 0x0001374C
		protected UBTDecorator_BlueprintBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400025F RID: 607
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BTDecorator_BlueprintBase";

		// Token: 0x04000260 RID: 608
		private static IntPtr _ClassPtr;

		// Token: 0x04000261 RID: 609
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000262 RID: 610
		internal static int __PropertyOffset_AIOwner;

		// Token: 0x04000263 RID: 611
		internal static int __PropertyOffset_ActorOwner;

		// Token: 0x04000264 RID: 612
		internal static int __PropertyOffset_ObservedKeyNames;

		// Token: 0x04000265 RID: 613
		private TArray<FName> _ObservedKeyNames;

		// Token: 0x04000266 RID: 614
		internal static int __PropertyOffset_bShowPropertyDetails;

		// Token: 0x04000267 RID: 615
		internal static byte __PropertyMask_bShowPropertyDetails;

		// Token: 0x04000268 RID: 616
		internal static int __PropertyOffset_bCheckConditionOnlyBlackBoardChanges;

		// Token: 0x04000269 RID: 617
		internal static byte __PropertyMask_bCheckConditionOnlyBlackBoardChanges;

		// Token: 0x0400026A RID: 618
		internal static int __PropertyOffset_bIsObservingBB;

		// Token: 0x0400026B RID: 619
		internal static byte __PropertyMask_bIsObservingBB;

		// Token: 0x020008E7 RID: 2279
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __ReceiveTickAI_FunctionParams
		{
			// Token: 0x040057A7 RID: 22439
			[FieldOffset(0)]
			public IntPtr OwnerController;

			// Token: 0x040057A8 RID: 22440
			[FieldOffset(8)]
			public IntPtr ControlledPawn;

			// Token: 0x040057A9 RID: 22441
			[FieldOffset(16)]
			public float DeltaSeconds;
		}

		// Token: 0x020008E8 RID: 2280
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040057AA RID: 22442
			[FieldOffset(0)]
			public IntPtr OwnerActor;

			// Token: 0x040057AB RID: 22443
			[FieldOffset(8)]
			public float DeltaSeconds;
		}

		// Token: 0x020008E9 RID: 2281
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ReceiveObserverDeactivatedAI_FunctionParams
		{
			// Token: 0x040057AC RID: 22444
			[FieldOffset(0)]
			public IntPtr OwnerController;

			// Token: 0x040057AD RID: 22445
			[FieldOffset(8)]
			public IntPtr ControlledPawn;
		}

		// Token: 0x020008EA RID: 2282
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ReceiveObserverDeactivated_FunctionParams
		{
			// Token: 0x040057AE RID: 22446
			[FieldOffset(0)]
			public IntPtr OwnerActor;
		}

		// Token: 0x020008EB RID: 2283
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ReceiveObserverActivatedAI_FunctionParams
		{
			// Token: 0x040057AF RID: 22447
			[FieldOffset(0)]
			public IntPtr OwnerController;

			// Token: 0x040057B0 RID: 22448
			[FieldOffset(8)]
			public IntPtr ControlledPawn;
		}

		// Token: 0x020008EC RID: 2284
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ReceiveObserverActivated_FunctionParams
		{
			// Token: 0x040057B1 RID: 22449
			[FieldOffset(0)]
			public IntPtr OwnerActor;
		}

		// Token: 0x020008ED RID: 2285
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ReceiveExecutionStartAI_FunctionParams
		{
			// Token: 0x040057B2 RID: 22450
			[FieldOffset(0)]
			public IntPtr OwnerController;

			// Token: 0x040057B3 RID: 22451
			[FieldOffset(8)]
			public IntPtr ControlledPawn;
		}

		// Token: 0x020008EE RID: 2286
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ReceiveExecutionStart_FunctionParams
		{
			// Token: 0x040057B4 RID: 22452
			[FieldOffset(0)]
			public IntPtr OwnerActor;
		}

		// Token: 0x020008EF RID: 2287
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __ReceiveExecutionFinishAI_FunctionParams
		{
			// Token: 0x040057B5 RID: 22453
			[FieldOffset(0)]
			public IntPtr OwnerController;

			// Token: 0x040057B6 RID: 22454
			[FieldOffset(8)]
			public IntPtr ControlledPawn;

			// Token: 0x040057B7 RID: 22455
			[FieldOffset(16)]
			public TEnumAsByte<EBTNodeResult> NodeResult;
		}

		// Token: 0x020008F0 RID: 2288
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ReceiveExecutionFinish_FunctionParams
		{
			// Token: 0x040057B8 RID: 22456
			[FieldOffset(0)]
			public IntPtr OwnerActor;

			// Token: 0x040057B9 RID: 22457
			[FieldOffset(8)]
			public TEnumAsByte<EBTNodeResult> NodeResult;
		}

		// Token: 0x020008F1 RID: 2289
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __PerformConditionCheckAI_FunctionParams
		{
			// Token: 0x040057BA RID: 22458
			[FieldOffset(0)]
			public IntPtr OwnerController;

			// Token: 0x040057BB RID: 22459
			[FieldOffset(8)]
			public IntPtr ControlledPawn;

			// Token: 0x040057BC RID: 22460
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x020008F2 RID: 2290
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __PerformConditionCheck_FunctionParams
		{
			// Token: 0x040057BD RID: 22461
			[FieldOffset(0)]
			public IntPtr OwnerActor;

			// Token: 0x040057BE RID: 22462
			[FieldOffset(8)]
			public bool __Result;
		}
	}
}
