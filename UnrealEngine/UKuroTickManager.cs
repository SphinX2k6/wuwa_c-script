using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005EC RID: 1516
	[UnrealObjectPath("/Script/KuroUtility.KuroTickManager")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UKuroTickManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060086F9 RID: 34553 RVA: 0x000CA827 File Offset: 0x000C8A27
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroTickManager._ClassPtr;
		}

		// Token: 0x060086FA RID: 34554 RVA: 0x000CA834 File Offset: 0x000C8A34
		public UKuroTickManager() : this(BuiltinUtils.AllocNativeUObject(UKuroTickManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060086FB RID: 34555 RVA: 0x000CA85C File Offset: 0x000C8A5C
		[NullableContext(1)]
		public UKuroTickManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroTickManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060086FC RID: 34556 RVA: 0x000CA88F File Offset: 0x000C8A8F
		public void SetTickFunctionCompletionCallbackInMainThread(ETickingGroup TickingGroup, int Priority)
		{
			UKuroTickManager.__SetTickFunctionCompletionCallbackInMainThread_Internal(base.NativePtr, TickingGroup, Priority);
		}

		// Token: 0x060086FD RID: 34557 RVA: 0x000CA8A3 File Offset: 0x000C8AA3
		[NullableContext(2)]
		public void SetSkeletalMeshProxyTickFunction(ETickingGroup TickingGroup, USkeletalMeshComponent SkeletalComp, int Priority = 0)
		{
			UKuroTickManager.__SetSkeletalMeshProxyTickFunction_Internal(base.NativePtr, TickingGroup, (SkeletalComp != null) ? SkeletalComp.NativePtr : IntPtr.Zero, Priority);
		}

		// Token: 0x060086FE RID: 34558 RVA: 0x000CA8C7 File Offset: 0x000C8AC7
		[NullableContext(2)]
		public void SetSkeletalMeshComponentPrerequisite(ETickingGroup TickingGroup, int Priority, USkeletalMeshComponent SkeletalComp)
		{
			UKuroTickManager.__SetSkeletalMeshComponentPrerequisite_Internal(base.NativePtr, TickingGroup, Priority, (SkeletalComp != null) ? SkeletalComp.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060086FF RID: 34559 RVA: 0x000CA8EB File Offset: 0x000C8AEB
		public void SetGamePrerequisiteTickFunction(ETickingGroup TickingGroup, int Priority)
		{
			UKuroTickManager.__SetGamePrerequisiteTickFunction_Internal(base.NativePtr, TickingGroup, Priority);
		}

		// Token: 0x06008700 RID: 34560 RVA: 0x000CA8FF File Offset: 0x000C8AFF
		[NullableContext(2)]
		public void SetCharacterMovementProxyTickFunction(ETickingGroup TickingGroup, UCharacterMovementComponent MoveComp, int Priority = 0)
		{
			UKuroTickManager.__SetCharacterMovementProxyTickFunction_Internal(base.NativePtr, TickingGroup, (MoveComp != null) ? MoveComp.NativePtr : IntPtr.Zero, Priority);
		}

		// Token: 0x06008701 RID: 34561 RVA: 0x000CA923 File Offset: 0x000C8B23
		public bool RemoveTick(ETickingGroup TickingGroup)
		{
			return UKuroTickManager.__RemoveTick_Internal(base.NativePtr, TickingGroup);
		}

		// Token: 0x06008702 RID: 34562 RVA: 0x000CA936 File Offset: 0x000C8B36
		[NullableContext(2)]
		public void RemovePrerequisiteActorComponent(ETickingGroup TickingGroup, UActorComponent ActorComp, int Priority = 0)
		{
			UKuroTickManager.__RemovePrerequisiteActorComponent_Internal(base.NativePtr, TickingGroup, (ActorComp != null) ? ActorComp.NativePtr : IntPtr.Zero, Priority);
		}

		// Token: 0x06008703 RID: 34563 RVA: 0x000CA95A File Offset: 0x000C8B5A
		[NullableContext(2)]
		public void RemovePrerequisiteActor(ETickingGroup TickingGroup, AActor Actor, int Priority = 0)
		{
			UKuroTickManager.__RemovePrerequisiteActor_Internal(base.NativePtr, TickingGroup, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, Priority);
		}

		// Token: 0x06008704 RID: 34564 RVA: 0x000CA97E File Offset: 0x000C8B7E
		public void ClearTick()
		{
			UKuroTickManager.__ClearTick_Internal(base.NativePtr);
		}

		// Token: 0x06008705 RID: 34565 RVA: 0x000CA98B File Offset: 0x000C8B8B
		[NullableContext(2)]
		public void CleanSkeletalMeshProxyTickFunction(USkeletalMeshComponent SkeletalComp)
		{
			UKuroTickManager.__CleanSkeletalMeshProxyTickFunction_Internal(base.NativePtr, (SkeletalComp != null) ? SkeletalComp.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06008706 RID: 34566 RVA: 0x000CA9A8 File Offset: 0x000C8BA8
		[NullableContext(2)]
		public void CleanCharacterMovementProxyTickFunction(UCharacterMovementComponent MoveComp)
		{
			UKuroTickManager.__CleanCharacterMovementProxyTickFunction_Internal(base.NativePtr, (MoveComp != null) ? MoveComp.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06008707 RID: 34567 RVA: 0x000CA9C5 File Offset: 0x000C8BC5
		[NullableContext(2)]
		public bool AddTick(ETickingGroup TickingGroup, FTickHandler TickHandler, int Priority = 0)
		{
			return UKuroTickManager.__AddTick_Internal(base.NativePtr, TickingGroup, (TickHandler != null) ? TickHandler.NativePtr : ((IntPtr)0), Priority);
		}

		// Token: 0x06008708 RID: 34568 RVA: 0x000CA9E6 File Offset: 0x000C8BE6
		[NullableContext(2)]
		public void AddPrerequisiteActorComponent(ETickingGroup TickingGroup, UActorComponent ActorComp, int Priority = 0)
		{
			UKuroTickManager.__AddPrerequisiteActorComponent_Internal(base.NativePtr, TickingGroup, (ActorComp != null) ? ActorComp.NativePtr : IntPtr.Zero, Priority);
		}

		// Token: 0x06008709 RID: 34569 RVA: 0x000CAA0A File Offset: 0x000C8C0A
		[NullableContext(2)]
		public void AddPrerequisiteActor(ETickingGroup TickingGroup, AActor Actor, int Priority = 0)
		{
			UKuroTickManager.__AddPrerequisiteActor_Internal(base.NativePtr, TickingGroup, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, Priority);
		}

		// Token: 0x0600870A RID: 34570
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTickFunctionCompletionCallbackInMainThread_Internal(IntPtr @this, TEnumAsByte<ETickingGroup> TickingGroup, int Priority);

		// Token: 0x0600870B RID: 34571
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSkeletalMeshProxyTickFunction_Internal(IntPtr @this, TEnumAsByte<ETickingGroup> TickingGroup, IntPtr SkeletalComp, int Priority);

		// Token: 0x0600870C RID: 34572
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSkeletalMeshComponentPrerequisite_Internal(IntPtr @this, TEnumAsByte<ETickingGroup> TickingGroup, int Priority, IntPtr SkeletalComp);

		// Token: 0x0600870D RID: 34573
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGamePrerequisiteTickFunction_Internal(IntPtr @this, TEnumAsByte<ETickingGroup> TickingGroup, int Priority);

		// Token: 0x0600870E RID: 34574
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCharacterMovementProxyTickFunction_Internal(IntPtr @this, TEnumAsByte<ETickingGroup> TickingGroup, IntPtr MoveComp, int Priority);

		// Token: 0x0600870F RID: 34575
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveTick_Internal(IntPtr @this, TEnumAsByte<ETickingGroup> TickingGroup);

		// Token: 0x06008710 RID: 34576
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemovePrerequisiteActorComponent_Internal(IntPtr @this, TEnumAsByte<ETickingGroup> TickingGroup, IntPtr ActorComp, int Priority);

		// Token: 0x06008711 RID: 34577
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemovePrerequisiteActor_Internal(IntPtr @this, TEnumAsByte<ETickingGroup> TickingGroup, IntPtr Actor, int Priority);

		// Token: 0x06008712 RID: 34578
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearTick_Internal(IntPtr @this);

		// Token: 0x06008713 RID: 34579
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CleanSkeletalMeshProxyTickFunction_Internal(IntPtr @this, IntPtr SkeletalComp);

		// Token: 0x06008714 RID: 34580
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CleanCharacterMovementProxyTickFunction_Internal(IntPtr @this, IntPtr MoveComp);

		// Token: 0x06008715 RID: 34581
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __AddTick_Internal(IntPtr @this, TEnumAsByte<ETickingGroup> TickingGroup, IntPtr TickHandler, int Priority);

		// Token: 0x06008716 RID: 34582
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddPrerequisiteActorComponent_Internal(IntPtr @this, TEnumAsByte<ETickingGroup> TickingGroup, IntPtr ActorComp, int Priority);

		// Token: 0x06008717 RID: 34583
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddPrerequisiteActor_Internal(IntPtr @this, TEnumAsByte<ETickingGroup> TickingGroup, IntPtr Actor, int Priority);

		// Token: 0x06008718 RID: 34584 RVA: 0x000CAA2E File Offset: 0x000C8C2E
		static UKuroTickManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroTickManager");
		}

		// Token: 0x06008719 RID: 34585 RVA: 0x000CAA3C File Offset: 0x000C8C3C
		protected UKuroTickManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003AC9 RID: 15049
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroTickManager";

		// Token: 0x04003ACA RID: 15050
		private static IntPtr _ClassPtr;

		// Token: 0x04003ACB RID: 15051
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
