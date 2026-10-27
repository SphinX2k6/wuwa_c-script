using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000150 RID: 336
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.BTService_BlueprintBase")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public abstract class UBTService_BlueprintBase : UBTService, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600173C RID: 5948 RVA: 0x00022311 File Offset: 0x00020511
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTService_BlueprintBase._ClassPtr;
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x0600173D RID: 5949 RVA: 0x0002231D File Offset: 0x0002051D
		// (set) Token: 0x0600173E RID: 5950 RVA: 0x00022331 File Offset: 0x00020531
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

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x0600173F RID: 5951 RVA: 0x00022346 File Offset: 0x00020546
		// (set) Token: 0x06001740 RID: 5952 RVA: 0x0002235A File Offset: 0x0002055A
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

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06001741 RID: 5953 RVA: 0x0002236F File Offset: 0x0002056F
		// (set) Token: 0x06001742 RID: 5954 RVA: 0x00022388 File Offset: 0x00020588
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

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06001743 RID: 5955 RVA: 0x000223B8 File Offset: 0x000205B8
		// (set) Token: 0x06001744 RID: 5956 RVA: 0x000223D1 File Offset: 0x000205D1
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

		// Token: 0x06001745 RID: 5957 RVA: 0x00022401 File Offset: 0x00020601
		public virtual void ReceiveTickAI(AAIController OwnerController, APawn ControlledPawn, float DeltaSeconds)
		{
			UBTService_BlueprintBase.__ReceiveTickAI_Internal(base.NativePtr, (OwnerController != null) ? OwnerController.NativePtr : IntPtr.Zero, (ControlledPawn != null) ? ControlledPawn.NativePtr : IntPtr.Zero, DeltaSeconds);
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x0002242F File Offset: 0x0002062F
		public virtual void ReceiveTick(AActor OwnerActor, float DeltaSeconds)
		{
			UBTService_BlueprintBase.__ReceiveTick_Internal(base.NativePtr, (OwnerActor != null) ? OwnerActor.NativePtr : IntPtr.Zero, DeltaSeconds);
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x0002244D File Offset: 0x0002064D
		public virtual void ReceiveSearchStartAI(AAIController OwnerController, APawn ControlledPawn)
		{
			UBTService_BlueprintBase.__ReceiveSearchStartAI_Internal(base.NativePtr, (OwnerController != null) ? OwnerController.NativePtr : IntPtr.Zero, (ControlledPawn != null) ? ControlledPawn.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x0002247A File Offset: 0x0002067A
		public virtual void ReceiveSearchStart(AActor OwnerActor)
		{
			UBTService_BlueprintBase.__ReceiveSearchStart_Internal(base.NativePtr, (OwnerActor != null) ? OwnerActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001749 RID: 5961 RVA: 0x00022497 File Offset: 0x00020697
		public virtual void ReceiveDeactivationAI(AAIController OwnerController, APawn ControlledPawn)
		{
			UBTService_BlueprintBase.__ReceiveDeactivationAI_Internal(base.NativePtr, (OwnerController != null) ? OwnerController.NativePtr : IntPtr.Zero, (ControlledPawn != null) ? ControlledPawn.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600174A RID: 5962 RVA: 0x000224C4 File Offset: 0x000206C4
		public virtual void ReceiveDeactivation(AActor OwnerActor)
		{
			UBTService_BlueprintBase.__ReceiveDeactivation_Internal(base.NativePtr, (OwnerActor != null) ? OwnerActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600174B RID: 5963 RVA: 0x000224E1 File Offset: 0x000206E1
		public virtual void ReceiveActivationAI(AAIController OwnerController, APawn ControlledPawn)
		{
			UBTService_BlueprintBase.__ReceiveActivationAI_Internal(base.NativePtr, (OwnerController != null) ? OwnerController.NativePtr : IntPtr.Zero, (ControlledPawn != null) ? ControlledPawn.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600174C RID: 5964 RVA: 0x0002250E File Offset: 0x0002070E
		public virtual void ReceiveActivation(AActor OwnerActor)
		{
			UBTService_BlueprintBase.__ReceiveActivation_Internal(base.NativePtr, (OwnerActor != null) ? OwnerActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600174D RID: 5965 RVA: 0x0002252B File Offset: 0x0002072B
		public bool IsServiceActive()
		{
			return UBTService_BlueprintBase.__IsServiceActive_Internal(base.NativePtr);
		}

		// Token: 0x0600174E RID: 5966
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveTickAI_Internal(IntPtr @this, IntPtr OwnerController, IntPtr ControlledPawn, float DeltaSeconds);

		// Token: 0x0600174F RID: 5967
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveTick_Internal(IntPtr @this, IntPtr OwnerActor, float DeltaSeconds);

		// Token: 0x06001750 RID: 5968
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveSearchStartAI_Internal(IntPtr @this, IntPtr OwnerController, IntPtr ControlledPawn);

		// Token: 0x06001751 RID: 5969
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveSearchStart_Internal(IntPtr @this, IntPtr OwnerActor);

		// Token: 0x06001752 RID: 5970
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveDeactivationAI_Internal(IntPtr @this, IntPtr OwnerController, IntPtr ControlledPawn);

		// Token: 0x06001753 RID: 5971
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveDeactivation_Internal(IntPtr @this, IntPtr OwnerActor);

		// Token: 0x06001754 RID: 5972
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveActivationAI_Internal(IntPtr @this, IntPtr OwnerController, IntPtr ControlledPawn);

		// Token: 0x06001755 RID: 5973
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveActivation_Internal(IntPtr @this, IntPtr OwnerActor);

		// Token: 0x06001756 RID: 5974
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsServiceActive_Internal(IntPtr @this);

		// Token: 0x06001757 RID: 5975 RVA: 0x00022538 File Offset: 0x00020738
		static UBTService_BlueprintBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTService_BlueprintBase");
		}

		// Token: 0x06001758 RID: 5976 RVA: 0x00022548 File Offset: 0x00020748
		protected UBTService_BlueprintBase() : this(BuiltinUtils.AllocNativeUObject(UBTService_BlueprintBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001759 RID: 5977 RVA: 0x00022570 File Offset: 0x00020770
		protected UBTService_BlueprintBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000578 RID: 1400
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BTService_BlueprintBase";

		// Token: 0x04000579 RID: 1401
		private static IntPtr _ClassPtr;

		// Token: 0x0400057A RID: 1402
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400057B RID: 1403
		internal static int __PropertyOffset_AIOwner;

		// Token: 0x0400057C RID: 1404
		internal static int __PropertyOffset_ActorOwner;

		// Token: 0x0400057D RID: 1405
		internal static int __PropertyOffset_bShowPropertyDetails;

		// Token: 0x0400057E RID: 1406
		internal static byte __PropertyMask_bShowPropertyDetails;

		// Token: 0x0400057F RID: 1407
		internal static int __PropertyOffset_bShowEventDetails;

		// Token: 0x04000580 RID: 1408
		internal static byte __PropertyMask_bShowEventDetails;

		// Token: 0x02002B55 RID: 11093
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __ReceiveTickAI_FunctionParams
		{
			// Token: 0x040163C6 RID: 91078
			[FieldOffset(0)]
			public IntPtr OwnerController;

			// Token: 0x040163C7 RID: 91079
			[FieldOffset(8)]
			public IntPtr ControlledPawn;

			// Token: 0x040163C8 RID: 91080
			[FieldOffset(16)]
			public float DeltaSeconds;
		}

		// Token: 0x02002B56 RID: 11094
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040163C9 RID: 91081
			[FieldOffset(0)]
			public IntPtr OwnerActor;

			// Token: 0x040163CA RID: 91082
			[FieldOffset(8)]
			public float DeltaSeconds;
		}

		// Token: 0x02002B57 RID: 11095
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ReceiveSearchStartAI_FunctionParams
		{
			// Token: 0x040163CB RID: 91083
			[FieldOffset(0)]
			public IntPtr OwnerController;

			// Token: 0x040163CC RID: 91084
			[FieldOffset(8)]
			public IntPtr ControlledPawn;
		}

		// Token: 0x02002B58 RID: 11096
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ReceiveSearchStart_FunctionParams
		{
			// Token: 0x040163CD RID: 91085
			[FieldOffset(0)]
			public IntPtr OwnerActor;
		}

		// Token: 0x02002B59 RID: 11097
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ReceiveDeactivationAI_FunctionParams
		{
			// Token: 0x040163CE RID: 91086
			[FieldOffset(0)]
			public IntPtr OwnerController;

			// Token: 0x040163CF RID: 91087
			[FieldOffset(8)]
			public IntPtr ControlledPawn;
		}

		// Token: 0x02002B5A RID: 11098
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ReceiveDeactivation_FunctionParams
		{
			// Token: 0x040163D0 RID: 91088
			[FieldOffset(0)]
			public IntPtr OwnerActor;
		}

		// Token: 0x02002B5B RID: 11099
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ReceiveActivationAI_FunctionParams
		{
			// Token: 0x040163D1 RID: 91089
			[FieldOffset(0)]
			public IntPtr OwnerController;

			// Token: 0x040163D2 RID: 91090
			[FieldOffset(8)]
			public IntPtr ControlledPawn;
		}

		// Token: 0x02002B5C RID: 11100
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ReceiveActivation_FunctionParams
		{
			// Token: 0x040163D3 RID: 91091
			[FieldOffset(0)]
			public IntPtr OwnerActor;
		}
	}
}
