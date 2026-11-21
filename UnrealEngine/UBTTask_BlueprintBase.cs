using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000B7 RID: 183
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.BTTask_BlueprintBase")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public abstract class UBTTask_BlueprintBase : UBTTaskNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06000DBF RID: 3519 RVA: 0x00015AAD File Offset: 0x00013CAD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTTask_BlueprintBase._ClassPtr;
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000DC0 RID: 3520 RVA: 0x00015AB9 File Offset: 0x00013CB9
		// (set) Token: 0x06000DC1 RID: 3521 RVA: 0x00015ACD File Offset: 0x00013CCD
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

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000DC2 RID: 3522 RVA: 0x00015AE2 File Offset: 0x00013CE2
		// (set) Token: 0x06000DC3 RID: 3523 RVA: 0x00015AF6 File Offset: 0x00013CF6
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

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000DC4 RID: 3524 RVA: 0x00015B0B File Offset: 0x00013D0B
		// (set) Token: 0x06000DC5 RID: 3525 RVA: 0x00015B24 File Offset: 0x00013D24
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

		// Token: 0x06000DC6 RID: 3526 RVA: 0x00015B54 File Offset: 0x00013D54
		public void SetFinishOnMessageWithId(FName MessageName, int RequestID = -1)
		{
			UBTTask_BlueprintBase.__SetFinishOnMessageWithId_Internal(base.NativePtr, MessageName, RequestID);
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x00015B63 File Offset: 0x00013D63
		public void SetFinishOnMessage(FName MessageName)
		{
			UBTTask_BlueprintBase.__SetFinishOnMessage_Internal(base.NativePtr, MessageName);
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x00015B71 File Offset: 0x00013D71
		public virtual void ReceiveTickAI(AAIController OwnerController, APawn ControlledPawn, float DeltaSeconds)
		{
			UBTTask_BlueprintBase.__ReceiveTickAI_Internal(base.NativePtr, (OwnerController != null) ? OwnerController.NativePtr : IntPtr.Zero, (ControlledPawn != null) ? ControlledPawn.NativePtr : IntPtr.Zero, DeltaSeconds);
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x00015B9F File Offset: 0x00013D9F
		public virtual void ReceiveTick(AActor OwnerActor, float DeltaSeconds)
		{
			UBTTask_BlueprintBase.__ReceiveTick_Internal(base.NativePtr, (OwnerActor != null) ? OwnerActor.NativePtr : IntPtr.Zero, DeltaSeconds);
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x00015BBD File Offset: 0x00013DBD
		public virtual void ReceiveExecuteAI(AAIController OwnerController, APawn ControlledPawn)
		{
			UBTTask_BlueprintBase.__ReceiveExecuteAI_Internal(base.NativePtr, (OwnerController != null) ? OwnerController.NativePtr : IntPtr.Zero, (ControlledPawn != null) ? ControlledPawn.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x00015BEA File Offset: 0x00013DEA
		public virtual void ReceiveExecute(AActor OwnerActor)
		{
			UBTTask_BlueprintBase.__ReceiveExecute_Internal(base.NativePtr, (OwnerActor != null) ? OwnerActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x00015C07 File Offset: 0x00013E07
		public virtual void ReceiveAbortAI(AAIController OwnerController, APawn ControlledPawn)
		{
			UBTTask_BlueprintBase.__ReceiveAbortAI_Internal(base.NativePtr, (OwnerController != null) ? OwnerController.NativePtr : IntPtr.Zero, (ControlledPawn != null) ? ControlledPawn.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x00015C34 File Offset: 0x00013E34
		public virtual void ReceiveAbort(AActor OwnerActor)
		{
			UBTTask_BlueprintBase.__ReceiveAbort_Internal(base.NativePtr, (OwnerActor != null) ? OwnerActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x00015C51 File Offset: 0x00013E51
		public bool IsTaskExecuting()
		{
			return UBTTask_BlueprintBase.__IsTaskExecuting_Internal(base.NativePtr);
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x00015C5E File Offset: 0x00013E5E
		public bool IsTaskAborting()
		{
			return UBTTask_BlueprintBase.__IsTaskAborting_Internal(base.NativePtr);
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x00015C6B File Offset: 0x00013E6B
		public void FinishExecute(bool bSuccess)
		{
			UBTTask_BlueprintBase.__FinishExecute_Internal(base.NativePtr, bSuccess);
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x00015C79 File Offset: 0x00013E79
		public void FinishAbort()
		{
			UBTTask_BlueprintBase.__FinishAbort_Internal(base.NativePtr);
		}

		// Token: 0x06000DD2 RID: 3538
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFinishOnMessageWithId_Internal(IntPtr @this, FName MessageName, int RequestID);

		// Token: 0x06000DD3 RID: 3539
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFinishOnMessage_Internal(IntPtr @this, FName MessageName);

		// Token: 0x06000DD4 RID: 3540
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveTickAI_Internal(IntPtr @this, IntPtr OwnerController, IntPtr ControlledPawn, float DeltaSeconds);

		// Token: 0x06000DD5 RID: 3541
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveTick_Internal(IntPtr @this, IntPtr OwnerActor, float DeltaSeconds);

		// Token: 0x06000DD6 RID: 3542
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveExecuteAI_Internal(IntPtr @this, IntPtr OwnerController, IntPtr ControlledPawn);

		// Token: 0x06000DD7 RID: 3543
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveExecute_Internal(IntPtr @this, IntPtr OwnerActor);

		// Token: 0x06000DD8 RID: 3544
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveAbortAI_Internal(IntPtr @this, IntPtr OwnerController, IntPtr ControlledPawn);

		// Token: 0x06000DD9 RID: 3545
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveAbort_Internal(IntPtr @this, IntPtr OwnerActor);

		// Token: 0x06000DDA RID: 3546
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsTaskExecuting_Internal(IntPtr @this);

		// Token: 0x06000DDB RID: 3547
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsTaskAborting_Internal(IntPtr @this);

		// Token: 0x06000DDC RID: 3548
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FinishExecute_Internal(IntPtr @this, bool bSuccess);

		// Token: 0x06000DDD RID: 3549
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FinishAbort_Internal(IntPtr @this);

		// Token: 0x06000DDE RID: 3550 RVA: 0x00015C86 File Offset: 0x00013E86
		static UBTTask_BlueprintBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTTask_BlueprintBase");
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x00015C94 File Offset: 0x00013E94
		protected UBTTask_BlueprintBase() : this(BuiltinUtils.AllocNativeUObject(UBTTask_BlueprintBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x00015CBC File Offset: 0x00013EBC
		protected UBTTask_BlueprintBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400028D RID: 653
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BTTask_BlueprintBase";

		// Token: 0x0400028E RID: 654
		private static IntPtr _ClassPtr;

		// Token: 0x0400028F RID: 655
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000290 RID: 656
		internal static int __PropertyOffset_AIOwner;

		// Token: 0x04000291 RID: 657
		internal static int __PropertyOffset_ActorOwner;

		// Token: 0x04000292 RID: 658
		internal static int __PropertyOffset_bShowPropertyDetails;

		// Token: 0x04000293 RID: 659
		internal static byte __PropertyMask_bShowPropertyDetails;

		// Token: 0x020008FB RID: 2299
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __ReceiveTickAI_FunctionParams
		{
			// Token: 0x040057CD RID: 22477
			[FieldOffset(0)]
			public IntPtr OwnerController;

			// Token: 0x040057CE RID: 22478
			[FieldOffset(8)]
			public IntPtr ControlledPawn;

			// Token: 0x040057CF RID: 22479
			[FieldOffset(16)]
			public float DeltaSeconds;
		}

		// Token: 0x020008FC RID: 2300
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040057D0 RID: 22480
			[FieldOffset(0)]
			public IntPtr OwnerActor;

			// Token: 0x040057D1 RID: 22481
			[FieldOffset(8)]
			public float DeltaSeconds;
		}

		// Token: 0x020008FD RID: 2301
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ReceiveExecuteAI_FunctionParams
		{
			// Token: 0x040057D2 RID: 22482
			[FieldOffset(0)]
			public IntPtr OwnerController;

			// Token: 0x040057D3 RID: 22483
			[FieldOffset(8)]
			public IntPtr ControlledPawn;
		}

		// Token: 0x020008FE RID: 2302
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ReceiveExecute_FunctionParams
		{
			// Token: 0x040057D4 RID: 22484
			[FieldOffset(0)]
			public IntPtr OwnerActor;
		}

		// Token: 0x020008FF RID: 2303
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ReceiveAbortAI_FunctionParams
		{
			// Token: 0x040057D5 RID: 22485
			[FieldOffset(0)]
			public IntPtr OwnerController;

			// Token: 0x040057D6 RID: 22486
			[FieldOffset(8)]
			public IntPtr ControlledPawn;
		}

		// Token: 0x02000900 RID: 2304
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ReceiveAbort_FunctionParams
		{
			// Token: 0x040057D7 RID: 22487
			[FieldOffset(0)]
			public IntPtr OwnerActor;
		}
	}
}
