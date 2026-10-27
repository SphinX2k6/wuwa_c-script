using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000155 RID: 341
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.BTTask_BlueprintBase")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public abstract class UBTTask_BlueprintBase : UBTTaskNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001776 RID: 6006 RVA: 0x0002287D File Offset: 0x00020A7D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTTask_BlueprintBase._ClassPtr;
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06001777 RID: 6007 RVA: 0x00022889 File Offset: 0x00020A89
		// (set) Token: 0x06001778 RID: 6008 RVA: 0x0002289D File Offset: 0x00020A9D
		public unsafe AAIController AIOwner
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AAIController>(base.NativePtr / (IntPtr)sizeof(void*) + UBTTask_BlueprintBase.__PropertyOffset_AIOwner);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBTTask_BlueprintBase.__PropertyOffset_AIOwner, value);
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06001779 RID: 6009 RVA: 0x000228B2 File Offset: 0x00020AB2
		// (set) Token: 0x0600177A RID: 6010 RVA: 0x000228C6 File Offset: 0x00020AC6
		public unsafe AActor ActorOwner
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UBTTask_BlueprintBase.__PropertyOffset_ActorOwner);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBTTask_BlueprintBase.__PropertyOffset_ActorOwner, value);
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x0600177B RID: 6011 RVA: 0x000228DC File Offset: 0x00020ADC
		// (set) Token: 0x0600177C RID: 6012 RVA: 0x00022915 File Offset: 0x00020B15
		[Nullable(1)]
		public FIntervalCountdown TickInterval
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FIntervalCountdown result;
				if ((result = this._TickInterval) == null)
				{
					result = (this._TickInterval = new FIntervalCountdown(base.NativePtr + (IntPtr)UBTTask_BlueprintBase.__PropertyOffset_TickInterval, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FIntervalCountdown.StaticStruct(), base.NativePtr + (IntPtr)UBTTask_BlueprintBase.__PropertyOffset_TickInterval, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x0600177D RID: 6013 RVA: 0x00022936 File Offset: 0x00020B36
		// (set) Token: 0x0600177E RID: 6014 RVA: 0x0002294F File Offset: 0x00020B4F
		public unsafe bool bShowPropertyDetails
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBTTask_BlueprintBase.__PropertyOffset_bShowPropertyDetails) & UBTTask_BlueprintBase.__PropertyMask_bShowPropertyDetails) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBTTask_BlueprintBase.__PropertyOffset_bShowPropertyDetails) = ((*(base.NativePtr + (IntPtr)UBTTask_BlueprintBase.__PropertyOffset_bShowPropertyDetails) & ~UBTTask_BlueprintBase.__PropertyMask_bShowPropertyDetails) | (value ? UBTTask_BlueprintBase.__PropertyMask_bShowPropertyDetails : 0));
			}
		}

		// Token: 0x0600177F RID: 6015 RVA: 0x0002297F File Offset: 0x00020B7F
		public void SetFinishOnMessageWithId(FName MessageName, int RequestID = -1)
		{
			UBTTask_BlueprintBase.__SetFinishOnMessageWithId_Internal(base.NativePtr, MessageName, RequestID);
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x0002298E File Offset: 0x00020B8E
		public void SetFinishOnMessage(FName MessageName)
		{
			UBTTask_BlueprintBase.__SetFinishOnMessage_Internal(base.NativePtr, MessageName);
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x0002299C File Offset: 0x00020B9C
		public virtual void ReceiveTickAI(AAIController OwnerController, APawn ControlledPawn, float DeltaSeconds)
		{
			UBTTask_BlueprintBase.__ReceiveTickAI_Internal(base.NativePtr, (OwnerController != null) ? OwnerController.NativePtr : IntPtr.Zero, (ControlledPawn != null) ? ControlledPawn.NativePtr : IntPtr.Zero, DeltaSeconds);
		}

		// Token: 0x06001782 RID: 6018 RVA: 0x000229CA File Offset: 0x00020BCA
		public virtual void ReceiveTick(AActor OwnerActor, float DeltaSeconds)
		{
			UBTTask_BlueprintBase.__ReceiveTick_Internal(base.NativePtr, (OwnerActor != null) ? OwnerActor.NativePtr : IntPtr.Zero, DeltaSeconds);
		}

		// Token: 0x06001783 RID: 6019 RVA: 0x000229E8 File Offset: 0x00020BE8
		public virtual void ReceiveExecuteAI(AAIController OwnerController, APawn ControlledPawn)
		{
			UBTTask_BlueprintBase.__ReceiveExecuteAI_Internal(base.NativePtr, (OwnerController != null) ? OwnerController.NativePtr : IntPtr.Zero, (ControlledPawn != null) ? ControlledPawn.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001784 RID: 6020 RVA: 0x00022A15 File Offset: 0x00020C15
		public virtual void ReceiveExecute(AActor OwnerActor)
		{
			UBTTask_BlueprintBase.__ReceiveExecute_Internal(base.NativePtr, (OwnerActor != null) ? OwnerActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001785 RID: 6021 RVA: 0x00022A32 File Offset: 0x00020C32
		public virtual void ReceiveAbortAI(AAIController OwnerController, APawn ControlledPawn)
		{
			UBTTask_BlueprintBase.__ReceiveAbortAI_Internal(base.NativePtr, (OwnerController != null) ? OwnerController.NativePtr : IntPtr.Zero, (ControlledPawn != null) ? ControlledPawn.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001786 RID: 6022 RVA: 0x00022A5F File Offset: 0x00020C5F
		public virtual void ReceiveAbort(AActor OwnerActor)
		{
			UBTTask_BlueprintBase.__ReceiveAbort_Internal(base.NativePtr, (OwnerActor != null) ? OwnerActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001787 RID: 6023 RVA: 0x00022A7C File Offset: 0x00020C7C
		public bool IsTaskExecuting()
		{
			return UBTTask_BlueprintBase.__IsTaskExecuting_Internal(base.NativePtr);
		}

		// Token: 0x06001788 RID: 6024 RVA: 0x00022A89 File Offset: 0x00020C89
		public bool IsTaskAborting()
		{
			return UBTTask_BlueprintBase.__IsTaskAborting_Internal(base.NativePtr);
		}

		// Token: 0x06001789 RID: 6025 RVA: 0x00022A96 File Offset: 0x00020C96
		public void FinishExecute(bool bSuccess)
		{
			UBTTask_BlueprintBase.__FinishExecute_Internal(base.NativePtr, bSuccess);
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x00022AA4 File Offset: 0x00020CA4
		public void FinishAbort()
		{
			UBTTask_BlueprintBase.__FinishAbort_Internal(base.NativePtr);
		}

		// Token: 0x0600178B RID: 6027
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFinishOnMessageWithId_Internal(IntPtr @this, FName MessageName, int RequestID);

		// Token: 0x0600178C RID: 6028
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFinishOnMessage_Internal(IntPtr @this, FName MessageName);

		// Token: 0x0600178D RID: 6029
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveTickAI_Internal(IntPtr @this, IntPtr OwnerController, IntPtr ControlledPawn, float DeltaSeconds);

		// Token: 0x0600178E RID: 6030
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveTick_Internal(IntPtr @this, IntPtr OwnerActor, float DeltaSeconds);

		// Token: 0x0600178F RID: 6031
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveExecuteAI_Internal(IntPtr @this, IntPtr OwnerController, IntPtr ControlledPawn);

		// Token: 0x06001790 RID: 6032
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveExecute_Internal(IntPtr @this, IntPtr OwnerActor);

		// Token: 0x06001791 RID: 6033
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveAbortAI_Internal(IntPtr @this, IntPtr OwnerController, IntPtr ControlledPawn);

		// Token: 0x06001792 RID: 6034
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveAbort_Internal(IntPtr @this, IntPtr OwnerActor);

		// Token: 0x06001793 RID: 6035
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsTaskExecuting_Internal(IntPtr @this);

		// Token: 0x06001794 RID: 6036
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsTaskAborting_Internal(IntPtr @this);

		// Token: 0x06001795 RID: 6037
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FinishExecute_Internal(IntPtr @this, bool bSuccess);

		// Token: 0x06001796 RID: 6038
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FinishAbort_Internal(IntPtr @this);

		// Token: 0x06001797 RID: 6039 RVA: 0x00022AB1 File Offset: 0x00020CB1
		static UBTTask_BlueprintBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTTask_BlueprintBase");
		}

		// Token: 0x06001798 RID: 6040 RVA: 0x00022AC0 File Offset: 0x00020CC0
		protected UBTTask_BlueprintBase() : this(BuiltinUtils.AllocNativeUObject(UBTTask_BlueprintBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001799 RID: 6041 RVA: 0x00022AE8 File Offset: 0x00020CE8
		protected UBTTask_BlueprintBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000596 RID: 1430
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BTTask_BlueprintBase";

		// Token: 0x04000597 RID: 1431
		private static IntPtr _ClassPtr;

		// Token: 0x04000598 RID: 1432
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000599 RID: 1433
		internal static int __PropertyOffset_AIOwner;

		// Token: 0x0400059A RID: 1434
		internal static int __PropertyOffset_ActorOwner;

		// Token: 0x0400059B RID: 1435
		internal static int __PropertyOffset_TickInterval;

		// Token: 0x0400059C RID: 1436
		private FIntervalCountdown _TickInterval;

		// Token: 0x0400059D RID: 1437
		internal static int __PropertyOffset_bShowPropertyDetails;

		// Token: 0x0400059E RID: 1438
		internal static byte __PropertyMask_bShowPropertyDetails;

		// Token: 0x02002B5D RID: 11101
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __ReceiveTickAI_FunctionParams
		{
			// Token: 0x040163D4 RID: 91092
			[FieldOffset(0)]
			public IntPtr OwnerController;

			// Token: 0x040163D5 RID: 91093
			[FieldOffset(8)]
			public IntPtr ControlledPawn;

			// Token: 0x040163D6 RID: 91094
			[FieldOffset(16)]
			public float DeltaSeconds;
		}

		// Token: 0x02002B5E RID: 11102
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040163D7 RID: 91095
			[FieldOffset(0)]
			public IntPtr OwnerActor;

			// Token: 0x040163D8 RID: 91096
			[FieldOffset(8)]
			public float DeltaSeconds;
		}

		// Token: 0x02002B5F RID: 11103
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ReceiveExecuteAI_FunctionParams
		{
			// Token: 0x040163D9 RID: 91097
			[FieldOffset(0)]
			public IntPtr OwnerController;

			// Token: 0x040163DA RID: 91098
			[FieldOffset(8)]
			public IntPtr ControlledPawn;
		}

		// Token: 0x02002B60 RID: 11104
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ReceiveExecute_FunctionParams
		{
			// Token: 0x040163DB RID: 91099
			[FieldOffset(0)]
			public IntPtr OwnerActor;
		}

		// Token: 0x02002B61 RID: 11105
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ReceiveAbortAI_FunctionParams
		{
			// Token: 0x040163DC RID: 91100
			[FieldOffset(0)]
			public IntPtr OwnerController;

			// Token: 0x040163DD RID: 91101
			[FieldOffset(8)]
			public IntPtr ControlledPawn;
		}

		// Token: 0x02002B62 RID: 11106
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ReceiveAbort_FunctionParams
		{
			// Token: 0x040163DE RID: 91102
			[FieldOffset(0)]
			public IntPtr OwnerActor;
		}
	}
}
