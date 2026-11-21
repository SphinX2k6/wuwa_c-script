using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000B5 RID: 181
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.BTService_BlueprintBase")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public abstract class UBTService_BlueprintBase : UBTService, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06000D99 RID: 3481 RVA: 0x00015765 File Offset: 0x00013965
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTService_BlueprintBase._ClassPtr;
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000D9A RID: 3482 RVA: 0x00015771 File Offset: 0x00013971
		// (set) Token: 0x06000D9B RID: 3483 RVA: 0x00015785 File Offset: 0x00013985
		public unsafe AAIController AIOwner
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AAIController>(base.NativePtr / (IntPtr)sizeof(void*) + UBTService_BlueprintBase.__PropertyOffset_AIOwner);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBTService_BlueprintBase.__PropertyOffset_AIOwner, value);
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000D9C RID: 3484 RVA: 0x0001579A File Offset: 0x0001399A
		// (set) Token: 0x06000D9D RID: 3485 RVA: 0x000157AE File Offset: 0x000139AE
		public unsafe AActor ActorOwner
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UBTService_BlueprintBase.__PropertyOffset_ActorOwner);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBTService_BlueprintBase.__PropertyOffset_ActorOwner, value);
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000D9E RID: 3486 RVA: 0x000157C3 File Offset: 0x000139C3
		// (set) Token: 0x06000D9F RID: 3487 RVA: 0x000157DC File Offset: 0x000139DC
		public unsafe bool bShowPropertyDetails
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBTService_BlueprintBase.__PropertyOffset_bShowPropertyDetails) & UBTService_BlueprintBase.__PropertyMask_bShowPropertyDetails) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBTService_BlueprintBase.__PropertyOffset_bShowPropertyDetails) = ((*(base.NativePtr + (IntPtr)UBTService_BlueprintBase.__PropertyOffset_bShowPropertyDetails) & ~UBTService_BlueprintBase.__PropertyMask_bShowPropertyDetails) | (value ? UBTService_BlueprintBase.__PropertyMask_bShowPropertyDetails : 0));
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000DA0 RID: 3488 RVA: 0x0001580C File Offset: 0x00013A0C
		// (set) Token: 0x06000DA1 RID: 3489 RVA: 0x00015825 File Offset: 0x00013A25
		public unsafe bool bShowEventDetails
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBTService_BlueprintBase.__PropertyOffset_bShowEventDetails) & UBTService_BlueprintBase.__PropertyMask_bShowEventDetails) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBTService_BlueprintBase.__PropertyOffset_bShowEventDetails) = ((*(base.NativePtr + (IntPtr)UBTService_BlueprintBase.__PropertyOffset_bShowEventDetails) & ~UBTService_BlueprintBase.__PropertyMask_bShowEventDetails) | (value ? UBTService_BlueprintBase.__PropertyMask_bShowEventDetails : 0));
			}
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x00015855 File Offset: 0x00013A55
		public virtual void ReceiveTickAI(AAIController OwnerController, APawn ControlledPawn, float DeltaSeconds)
		{
			UBTService_BlueprintBase.__ReceiveTickAI_Internal(base.NativePtr, (OwnerController != null) ? OwnerController.NativePtr : IntPtr.Zero, (ControlledPawn != null) ? ControlledPawn.NativePtr : IntPtr.Zero, DeltaSeconds);
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x00015883 File Offset: 0x00013A83
		public virtual void ReceiveTick(AActor OwnerActor, float DeltaSeconds)
		{
			UBTService_BlueprintBase.__ReceiveTick_Internal(base.NativePtr, (OwnerActor != null) ? OwnerActor.NativePtr : IntPtr.Zero, DeltaSeconds);
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x000158A1 File Offset: 0x00013AA1
		public virtual void ReceiveSearchStartAI(AAIController OwnerController, APawn ControlledPawn)
		{
			UBTService_BlueprintBase.__ReceiveSearchStartAI_Internal(base.NativePtr, (OwnerController != null) ? OwnerController.NativePtr : IntPtr.Zero, (ControlledPawn != null) ? ControlledPawn.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x000158CE File Offset: 0x00013ACE
		public virtual void ReceiveSearchStart(AActor OwnerActor)
		{
			UBTService_BlueprintBase.__ReceiveSearchStart_Internal(base.NativePtr, (OwnerActor != null) ? OwnerActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x000158EB File Offset: 0x00013AEB
		public virtual void ReceiveDeactivationAI(AAIController OwnerController, APawn ControlledPawn)
		{
			UBTService_BlueprintBase.__ReceiveDeactivationAI_Internal(base.NativePtr, (OwnerController != null) ? OwnerController.NativePtr : IntPtr.Zero, (ControlledPawn != null) ? ControlledPawn.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00015918 File Offset: 0x00013B18
		public virtual void ReceiveDeactivation(AActor OwnerActor)
		{
			UBTService_BlueprintBase.__ReceiveDeactivation_Internal(base.NativePtr, (OwnerActor != null) ? OwnerActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x00015935 File Offset: 0x00013B35
		public virtual void ReceiveActivationAI(AAIController OwnerController, APawn ControlledPawn)
		{
			UBTService_BlueprintBase.__ReceiveActivationAI_Internal(base.NativePtr, (OwnerController != null) ? OwnerController.NativePtr : IntPtr.Zero, (ControlledPawn != null) ? ControlledPawn.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x00015962 File Offset: 0x00013B62
		public virtual void ReceiveActivation(AActor OwnerActor)
		{
			UBTService_BlueprintBase.__ReceiveActivation_Internal(base.NativePtr, (OwnerActor != null) ? OwnerActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x0001597F File Offset: 0x00013B7F
		public bool IsServiceActive()
		{
			return UBTService_BlueprintBase.__IsServiceActive_Internal(base.NativePtr);
		}

		// Token: 0x06000DAB RID: 3499
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveTickAI_Internal(IntPtr @this, IntPtr OwnerController, IntPtr ControlledPawn, float DeltaSeconds);

		// Token: 0x06000DAC RID: 3500
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveTick_Internal(IntPtr @this, IntPtr OwnerActor, float DeltaSeconds);

		// Token: 0x06000DAD RID: 3501
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveSearchStartAI_Internal(IntPtr @this, IntPtr OwnerController, IntPtr ControlledPawn);

		// Token: 0x06000DAE RID: 3502
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveSearchStart_Internal(IntPtr @this, IntPtr OwnerActor);

		// Token: 0x06000DAF RID: 3503
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveDeactivationAI_Internal(IntPtr @this, IntPtr OwnerController, IntPtr ControlledPawn);

		// Token: 0x06000DB0 RID: 3504
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveDeactivation_Internal(IntPtr @this, IntPtr OwnerActor);

		// Token: 0x06000DB1 RID: 3505
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveActivationAI_Internal(IntPtr @this, IntPtr OwnerController, IntPtr ControlledPawn);

		// Token: 0x06000DB2 RID: 3506
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveActivation_Internal(IntPtr @this, IntPtr OwnerActor);

		// Token: 0x06000DB3 RID: 3507
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsServiceActive_Internal(IntPtr @this);

		// Token: 0x06000DB4 RID: 3508 RVA: 0x0001598C File Offset: 0x00013B8C
		static UBTService_BlueprintBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTService_BlueprintBase");
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x0001599C File Offset: 0x00013B9C
		protected UBTService_BlueprintBase() : this(BuiltinUtils.AllocNativeUObject(UBTService_BlueprintBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x000159C4 File Offset: 0x00013BC4
		protected UBTService_BlueprintBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400027D RID: 637
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BTService_BlueprintBase";

		// Token: 0x0400027E RID: 638
		private static IntPtr _ClassPtr;

		// Token: 0x0400027F RID: 639
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000280 RID: 640
		internal static int __PropertyOffset_AIOwner;

		// Token: 0x04000281 RID: 641
		internal static int __PropertyOffset_ActorOwner;

		// Token: 0x04000282 RID: 642
		internal static int __PropertyOffset_bShowPropertyDetails;

		// Token: 0x04000283 RID: 643
		internal static byte __PropertyMask_bShowPropertyDetails;

		// Token: 0x04000284 RID: 644
		internal static int __PropertyOffset_bShowEventDetails;

		// Token: 0x04000285 RID: 645
		internal static byte __PropertyMask_bShowEventDetails;

		// Token: 0x020008F3 RID: 2291
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __ReceiveTickAI_FunctionParams
		{
			// Token: 0x040057BF RID: 22463
			[FieldOffset(0)]
			public IntPtr OwnerController;

			// Token: 0x040057C0 RID: 22464
			[FieldOffset(8)]
			public IntPtr ControlledPawn;

			// Token: 0x040057C1 RID: 22465
			[FieldOffset(16)]
			public float DeltaSeconds;
		}

		// Token: 0x020008F4 RID: 2292
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040057C2 RID: 22466
			[FieldOffset(0)]
			public IntPtr OwnerActor;

			// Token: 0x040057C3 RID: 22467
			[FieldOffset(8)]
			public float DeltaSeconds;
		}

		// Token: 0x020008F5 RID: 2293
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ReceiveSearchStartAI_FunctionParams
		{
			// Token: 0x040057C4 RID: 22468
			[FieldOffset(0)]
			public IntPtr OwnerController;

			// Token: 0x040057C5 RID: 22469
			[FieldOffset(8)]
			public IntPtr ControlledPawn;
		}

		// Token: 0x020008F6 RID: 2294
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ReceiveSearchStart_FunctionParams
		{
			// Token: 0x040057C6 RID: 22470
			[FieldOffset(0)]
			public IntPtr OwnerActor;
		}

		// Token: 0x020008F7 RID: 2295
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ReceiveDeactivationAI_FunctionParams
		{
			// Token: 0x040057C7 RID: 22471
			[FieldOffset(0)]
			public IntPtr OwnerController;

			// Token: 0x040057C8 RID: 22472
			[FieldOffset(8)]
			public IntPtr ControlledPawn;
		}

		// Token: 0x020008F8 RID: 2296
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ReceiveDeactivation_FunctionParams
		{
			// Token: 0x040057C9 RID: 22473
			[FieldOffset(0)]
			public IntPtr OwnerActor;
		}

		// Token: 0x020008F9 RID: 2297
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ReceiveActivationAI_FunctionParams
		{
			// Token: 0x040057CA RID: 22474
			[FieldOffset(0)]
			public IntPtr OwnerController;

			// Token: 0x040057CB RID: 22475
			[FieldOffset(8)]
			public IntPtr ControlledPawn;
		}

		// Token: 0x020008FA RID: 2298
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ReceiveActivation_FunctionParams
		{
			// Token: 0x040057CC RID: 22476
			[FieldOffset(0)]
			public IntPtr OwnerActor;
		}
	}
}
