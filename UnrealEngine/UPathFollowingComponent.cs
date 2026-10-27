using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001D2 RID: 466
	[UnrealObjectPath("/Script/AIModule.PathFollowingComponent")]
	[UnrealStructLayout(648, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 648)]
	public class UPathFollowingComponent : UActorComponent, IUnrealUObject, IUnrealObject, IAIResourceInterface, IUnrealNativeInterface, IUnrealInterface, IPathFollowingAgentInterface
	{
		// Token: 0x06001B7E RID: 7038 RVA: 0x0002909A File Offset: 0x0002729A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPathFollowingComponent._ClassPtr;
		}

		// Token: 0x06001B7F RID: 7039 RVA: 0x000290A6 File Offset: 0x000272A6
		int IAIResourceInterface.InterfaceOffset()
		{
			return UPathFollowingComponent.__InterfaceOffset_IAIResourceInterface;
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x000290AD File Offset: 0x000272AD
		int IPathFollowingAgentInterface.InterfaceOffset()
		{
			return UPathFollowingComponent.__InterfaceOffset_IPathFollowingAgentInterface;
		}

		// Token: 0x06001B81 RID: 7041 RVA: 0x000290B4 File Offset: 0x000272B4
		public UPathFollowingComponent() : this(BuiltinUtils.AllocNativeUObject(UPathFollowingComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x000290DC File Offset: 0x000272DC
		[NullableContext(1)]
		public UPathFollowingComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPathFollowingComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06001B83 RID: 7043 RVA: 0x0002910F File Offset: 0x0002730F
		// (set) Token: 0x06001B84 RID: 7044 RVA: 0x00029123 File Offset: 0x00027323
		[Nullable(2)]
		public unsafe UNavMovementComponent MovementComp
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNavMovementComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UPathFollowingComponent.__PropertyOffset_MovementComp);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UPathFollowingComponent.__PropertyOffset_MovementComp, value);
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06001B85 RID: 7045 RVA: 0x00029138 File Offset: 0x00027338
		// (set) Token: 0x06001B86 RID: 7046 RVA: 0x0002914C File Offset: 0x0002734C
		[Nullable(2)]
		public unsafe ANavigationData MyNavData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ANavigationData>(base.NativePtr / (IntPtr)sizeof(void*) + UPathFollowingComponent.__PropertyOffset_MyNavData);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UPathFollowingComponent.__PropertyOffset_MyNavData, value);
			}
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x00029161 File Offset: 0x00027361
		[NullableContext(2)]
		public void OnNavDataRegistered(ANavigationData NavData)
		{
			UPathFollowingComponent.__OnNavDataRegistered_Internal(base.NativePtr, (NavData != null) ? NavData.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x0002917E File Offset: 0x0002737E
		[NullableContext(2)]
		public void OnActorBump(AActor SelfActor, AActor OtherActor, FVector NormalImpulse, in FHitResult Hit)
		{
			UPathFollowingComponent.__OnActorBump_Internal(base.NativePtr, (SelfActor != null) ? SelfActor.NativePtr : IntPtr.Zero, (OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero, NormalImpulse, (Hit ?? new FHitResult()).NativePtr);
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x000291BD File Offset: 0x000273BD
		public FVector GetPathDestination()
		{
			return UPathFollowingComponent.__GetPathDestination_Internal(base.NativePtr);
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x000291CA File Offset: 0x000273CA
		public TEnumAsByte<EPathFollowingAction> GetPathActionType()
		{
			return UPathFollowingComponent.__GetPathActionType_Internal(base.NativePtr);
		}

		// Token: 0x06001B8B RID: 7051
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnNavDataRegistered_Internal(IntPtr @this, IntPtr NavData);

		// Token: 0x06001B8C RID: 7052
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnActorBump_Internal(IntPtr @this, IntPtr SelfActor, IntPtr OtherActor, FVector NormalImpulse, IntPtr Hit);

		// Token: 0x06001B8D RID: 7053
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetPathDestination_Internal(IntPtr @this);

		// Token: 0x06001B8E RID: 7054
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<EPathFollowingAction> __GetPathActionType_Internal(IntPtr @this);

		// Token: 0x06001B8F RID: 7055 RVA: 0x000291D7 File Offset: 0x000273D7
		static UPathFollowingComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.PathFollowingComponent");
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x000291E5 File Offset: 0x000273E5
		protected UPathFollowingComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040008CE RID: 2254
		internal static int __InterfaceOffset_IAIResourceInterface;

		// Token: 0x040008CF RID: 2255
		internal static int __InterfaceOffset_IPathFollowingAgentInterface;

		// Token: 0x040008D0 RID: 2256
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.PathFollowingComponent";

		// Token: 0x040008D1 RID: 2257
		private static IntPtr _ClassPtr;

		// Token: 0x040008D2 RID: 2258
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040008D3 RID: 2259
		internal static int __PropertyOffset_MovementComp;

		// Token: 0x040008D4 RID: 2260
		internal static int __PropertyOffset_MyNavData;
	}
}
