using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200013C RID: 316
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.BTDecorator_BlueprintBase")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public abstract class UBTDecorator_BlueprintBase : UBTDecorator, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600161B RID: 5659 RVA: 0x00020765 File Offset: 0x0001E965
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTDecorator_BlueprintBase._ClassPtr;
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x0600161C RID: 5660 RVA: 0x00020771 File Offset: 0x0001E971
		// (set) Token: 0x0600161D RID: 5661 RVA: 0x00020785 File Offset: 0x0001E985
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

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x0600161E RID: 5662 RVA: 0x0002079A File Offset: 0x0001E99A
		// (set) Token: 0x0600161F RID: 5663 RVA: 0x000207AE File Offset: 0x0001E9AE
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

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06001620 RID: 5664 RVA: 0x000207C4 File Offset: 0x0001E9C4
		// (set) Token: 0x06001621 RID: 5665 RVA: 0x000207FD File Offset: 0x0001E9FD
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

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06001622 RID: 5666 RVA: 0x0002080B File Offset: 0x0001EA0B
		// (set) Token: 0x06001623 RID: 5667 RVA: 0x00020824 File Offset: 0x0001EA24
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

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06001624 RID: 5668 RVA: 0x00020854 File Offset: 0x0001EA54
		// (set) Token: 0x06001625 RID: 5669 RVA: 0x0002086D File Offset: 0x0001EA6D
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

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06001626 RID: 5670 RVA: 0x0002089D File Offset: 0x0001EA9D
		// (set) Token: 0x06001627 RID: 5671 RVA: 0x000208B6 File Offset: 0x0001EAB6
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

		// Token: 0x06001628 RID: 5672 RVA: 0x000208E6 File Offset: 0x0001EAE6
		public virtual void ReceiveTickAI(AAIController OwnerController, APawn ControlledPawn, float DeltaSeconds)
		{
			UBTDecorator_BlueprintBase.__ReceiveTickAI_Internal(base.NativePtr, (OwnerController != null) ? OwnerController.NativePtr : IntPtr.Zero, (ControlledPawn != null) ? ControlledPawn.NativePtr : IntPtr.Zero, DeltaSeconds);
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x00020914 File Offset: 0x0001EB14
		public virtual void ReceiveTick(AActor OwnerActor, float DeltaSeconds)
		{
			UBTDecorator_BlueprintBase.__ReceiveTick_Internal(base.NativePtr, (OwnerActor != null) ? OwnerActor.NativePtr : IntPtr.Zero, DeltaSeconds);
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x00020932 File Offset: 0x0001EB32
		public virtual void ReceiveObserverDeactivatedAI(AAIController OwnerController, APawn ControlledPawn)
		{
			UBTDecorator_BlueprintBase.__ReceiveObserverDeactivatedAI_Internal(base.NativePtr, (OwnerController != null) ? OwnerController.NativePtr : IntPtr.Zero, (ControlledPawn != null) ? ControlledPawn.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x0002095F File Offset: 0x0001EB5F
		public virtual void ReceiveObserverDeactivated(AActor OwnerActor)
		{
			UBTDecorator_BlueprintBase.__ReceiveObserverDeactivated_Internal(base.NativePtr, (OwnerActor != null) ? OwnerActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x0002097C File Offset: 0x0001EB7C
		public virtual void ReceiveObserverActivatedAI(AAIController OwnerController, APawn ControlledPawn)
		{
			UBTDecorator_BlueprintBase.__ReceiveObserverActivatedAI_Internal(base.NativePtr, (OwnerController != null) ? OwnerController.NativePtr : IntPtr.Zero, (ControlledPawn != null) ? ControlledPawn.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x000209A9 File Offset: 0x0001EBA9
		public virtual void ReceiveObserverActivated(AActor OwnerActor)
		{
			UBTDecorator_BlueprintBase.__ReceiveObserverActivated_Internal(base.NativePtr, (OwnerActor != null) ? OwnerActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x000209C6 File Offset: 0x0001EBC6
		public virtual void ReceiveExecutionStartAI(AAIController OwnerController, APawn ControlledPawn)
		{
			UBTDecorator_BlueprintBase.__ReceiveExecutionStartAI_Internal(base.NativePtr, (OwnerController != null) ? OwnerController.NativePtr : IntPtr.Zero, (ControlledPawn != null) ? ControlledPawn.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x000209F3 File Offset: 0x0001EBF3
		public virtual void ReceiveExecutionStart(AActor OwnerActor)
		{
			UBTDecorator_BlueprintBase.__ReceiveExecutionStart_Internal(base.NativePtr, (OwnerActor != null) ? OwnerActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x00020A10 File Offset: 0x0001EC10
		public virtual void ReceiveExecutionFinishAI(AAIController OwnerController, APawn ControlledPawn, EBTNodeResult NodeResult)
		{
			UBTDecorator_BlueprintBase.__ReceiveExecutionFinishAI_Internal(base.NativePtr, (OwnerController != null) ? OwnerController.NativePtr : IntPtr.Zero, (ControlledPawn != null) ? ControlledPawn.NativePtr : IntPtr.Zero, NodeResult);
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x00020A43 File Offset: 0x0001EC43
		public virtual void ReceiveExecutionFinish(AActor OwnerActor, EBTNodeResult NodeResult)
		{
			UBTDecorator_BlueprintBase.__ReceiveExecutionFinish_Internal(base.NativePtr, (OwnerActor != null) ? OwnerActor.NativePtr : IntPtr.Zero, NodeResult);
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x00020A66 File Offset: 0x0001EC66
		public virtual bool PerformConditionCheckAI(AAIController OwnerController, APawn ControlledPawn)
		{
			return UBTDecorator_BlueprintBase.__PerformConditionCheckAI_Internal(base.NativePtr, (OwnerController != null) ? OwnerController.NativePtr : IntPtr.Zero, (ControlledPawn != null) ? ControlledPawn.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001633 RID: 5683 RVA: 0x00020A93 File Offset: 0x0001EC93
		public virtual bool PerformConditionCheck(AActor OwnerActor)
		{
			return UBTDecorator_BlueprintBase.__PerformConditionCheck_Internal(base.NativePtr, (OwnerActor != null) ? OwnerActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001634 RID: 5684 RVA: 0x00020AB0 File Offset: 0x0001ECB0
		public bool IsDecoratorObserverActive()
		{
			return UBTDecorator_BlueprintBase.__IsDecoratorObserverActive_Internal(base.NativePtr);
		}

		// Token: 0x06001635 RID: 5685 RVA: 0x00020ABD File Offset: 0x0001ECBD
		public bool IsDecoratorExecutionActive()
		{
			return UBTDecorator_BlueprintBase.__IsDecoratorExecutionActive_Internal(base.NativePtr);
		}

		// Token: 0x06001636 RID: 5686
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveTickAI_Internal(IntPtr @this, IntPtr OwnerController, IntPtr ControlledPawn, float DeltaSeconds);

		// Token: 0x06001637 RID: 5687
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveTick_Internal(IntPtr @this, IntPtr OwnerActor, float DeltaSeconds);

		// Token: 0x06001638 RID: 5688
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveObserverDeactivatedAI_Internal(IntPtr @this, IntPtr OwnerController, IntPtr ControlledPawn);

		// Token: 0x06001639 RID: 5689
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveObserverDeactivated_Internal(IntPtr @this, IntPtr OwnerActor);

		// Token: 0x0600163A RID: 5690
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveObserverActivatedAI_Internal(IntPtr @this, IntPtr OwnerController, IntPtr ControlledPawn);

		// Token: 0x0600163B RID: 5691
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveObserverActivated_Internal(IntPtr @this, IntPtr OwnerActor);

		// Token: 0x0600163C RID: 5692
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveExecutionStartAI_Internal(IntPtr @this, IntPtr OwnerController, IntPtr ControlledPawn);

		// Token: 0x0600163D RID: 5693
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveExecutionStart_Internal(IntPtr @this, IntPtr OwnerActor);

		// Token: 0x0600163E RID: 5694
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveExecutionFinishAI_Internal(IntPtr @this, IntPtr OwnerController, IntPtr ControlledPawn, TEnumAsByte<EBTNodeResult> NodeResult);

		// Token: 0x0600163F RID: 5695
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveExecutionFinish_Internal(IntPtr @this, IntPtr OwnerActor, TEnumAsByte<EBTNodeResult> NodeResult);

		// Token: 0x06001640 RID: 5696
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __PerformConditionCheckAI_Internal(IntPtr @this, IntPtr OwnerController, IntPtr ControlledPawn);

		// Token: 0x06001641 RID: 5697
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __PerformConditionCheck_Internal(IntPtr @this, IntPtr OwnerActor);

		// Token: 0x06001642 RID: 5698
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsDecoratorObserverActive_Internal(IntPtr @this);

		// Token: 0x06001643 RID: 5699
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsDecoratorExecutionActive_Internal(IntPtr @this);

		// Token: 0x06001644 RID: 5700 RVA: 0x00020ACA File Offset: 0x0001ECCA
		static UBTDecorator_BlueprintBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTDecorator_BlueprintBase");
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x00020AD8 File Offset: 0x0001ECD8
		protected UBTDecorator_BlueprintBase() : this(BuiltinUtils.AllocNativeUObject(UBTDecorator_BlueprintBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x00020B00 File Offset: 0x0001ED00
		protected UBTDecorator_BlueprintBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040004EB RID: 1259
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BTDecorator_BlueprintBase";

		// Token: 0x040004EC RID: 1260
		private static IntPtr _ClassPtr;

		// Token: 0x040004ED RID: 1261
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040004EE RID: 1262
		internal static int __PropertyOffset_AIOwner;

		// Token: 0x040004EF RID: 1263
		internal static int __PropertyOffset_ActorOwner;

		// Token: 0x040004F0 RID: 1264
		internal static int __PropertyOffset_ObservedKeyNames;

		// Token: 0x040004F1 RID: 1265
		private TArray<FName> _ObservedKeyNames;

		// Token: 0x040004F2 RID: 1266
		internal static int __PropertyOffset_bShowPropertyDetails;

		// Token: 0x040004F3 RID: 1267
		internal static byte __PropertyMask_bShowPropertyDetails;

		// Token: 0x040004F4 RID: 1268
		internal static int __PropertyOffset_bCheckConditionOnlyBlackBoardChanges;

		// Token: 0x040004F5 RID: 1269
		internal static byte __PropertyMask_bCheckConditionOnlyBlackBoardChanges;

		// Token: 0x040004F6 RID: 1270
		internal static int __PropertyOffset_bIsObservingBB;

		// Token: 0x040004F7 RID: 1271
		internal static byte __PropertyMask_bIsObservingBB;

		// Token: 0x02002B49 RID: 11081
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __ReceiveTickAI_FunctionParams
		{
			// Token: 0x040163AE RID: 91054
			[FieldOffset(0)]
			public IntPtr OwnerController;

			// Token: 0x040163AF RID: 91055
			[FieldOffset(8)]
			public IntPtr ControlledPawn;

			// Token: 0x040163B0 RID: 91056
			[FieldOffset(16)]
			public float DeltaSeconds;
		}

		// Token: 0x02002B4A RID: 11082
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040163B1 RID: 91057
			[FieldOffset(0)]
			public IntPtr OwnerActor;

			// Token: 0x040163B2 RID: 91058
			[FieldOffset(8)]
			public float DeltaSeconds;
		}

		// Token: 0x02002B4B RID: 11083
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ReceiveObserverDeactivatedAI_FunctionParams
		{
			// Token: 0x040163B3 RID: 91059
			[FieldOffset(0)]
			public IntPtr OwnerController;

			// Token: 0x040163B4 RID: 91060
			[FieldOffset(8)]
			public IntPtr ControlledPawn;
		}

		// Token: 0x02002B4C RID: 11084
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ReceiveObserverDeactivated_FunctionParams
		{
			// Token: 0x040163B5 RID: 91061
			[FieldOffset(0)]
			public IntPtr OwnerActor;
		}

		// Token: 0x02002B4D RID: 11085
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ReceiveObserverActivatedAI_FunctionParams
		{
			// Token: 0x040163B6 RID: 91062
			[FieldOffset(0)]
			public IntPtr OwnerController;

			// Token: 0x040163B7 RID: 91063
			[FieldOffset(8)]
			public IntPtr ControlledPawn;
		}

		// Token: 0x02002B4E RID: 11086
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ReceiveObserverActivated_FunctionParams
		{
			// Token: 0x040163B8 RID: 91064
			[FieldOffset(0)]
			public IntPtr OwnerActor;
		}

		// Token: 0x02002B4F RID: 11087
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ReceiveExecutionStartAI_FunctionParams
		{
			// Token: 0x040163B9 RID: 91065
			[FieldOffset(0)]
			public IntPtr OwnerController;

			// Token: 0x040163BA RID: 91066
			[FieldOffset(8)]
			public IntPtr ControlledPawn;
		}

		// Token: 0x02002B50 RID: 11088
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ReceiveExecutionStart_FunctionParams
		{
			// Token: 0x040163BB RID: 91067
			[FieldOffset(0)]
			public IntPtr OwnerActor;
		}

		// Token: 0x02002B51 RID: 11089
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __ReceiveExecutionFinishAI_FunctionParams
		{
			// Token: 0x040163BC RID: 91068
			[FieldOffset(0)]
			public IntPtr OwnerController;

			// Token: 0x040163BD RID: 91069
			[FieldOffset(8)]
			public IntPtr ControlledPawn;

			// Token: 0x040163BE RID: 91070
			[FieldOffset(16)]
			public TEnumAsByte<EBTNodeResult> NodeResult;
		}

		// Token: 0x02002B52 RID: 11090
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ReceiveExecutionFinish_FunctionParams
		{
			// Token: 0x040163BF RID: 91071
			[FieldOffset(0)]
			public IntPtr OwnerActor;

			// Token: 0x040163C0 RID: 91072
			[FieldOffset(8)]
			public TEnumAsByte<EBTNodeResult> NodeResult;
		}

		// Token: 0x02002B53 RID: 11091
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __PerformConditionCheckAI_FunctionParams
		{
			// Token: 0x040163C1 RID: 91073
			[FieldOffset(0)]
			public IntPtr OwnerController;

			// Token: 0x040163C2 RID: 91074
			[FieldOffset(8)]
			public IntPtr ControlledPawn;

			// Token: 0x040163C3 RID: 91075
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02002B54 RID: 11092
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __PerformConditionCheck_FunctionParams
		{
			// Token: 0x040163C4 RID: 91076
			[FieldOffset(0)]
			public IntPtr OwnerActor;

			// Token: 0x040163C5 RID: 91077
			[FieldOffset(8)]
			public bool __Result;
		}
	}
}
