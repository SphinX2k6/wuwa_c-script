using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001ED9 RID: 7897
	[UnrealObjectPath("/Script/KuroUtility.KuroTickManager")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UKuroTickManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E07D RID: 123005 RVA: 0x002C9191 File Offset: 0x002C7391
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroTickManager._ClassPtr;
		}

		// Token: 0x0601E07E RID: 123006 RVA: 0x002C91A0 File Offset: 0x002C73A0
		public UKuroTickManager() : this(BuiltinUtils.AllocNativeUObject(UKuroTickManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E07F RID: 123007 RVA: 0x002C91C8 File Offset: 0x002C73C8
		[NullableContext(1)]
		public UKuroTickManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroTickManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601E080 RID: 123008 RVA: 0x002C91FB File Offset: 0x002C73FB
		public void SetTickFunctionCompletionCallbackInMainThread(ETickingGroup TickingGroup, int Priority)
		{
			UKuroTickManager.__SetTickFunctionCompletionCallbackInMainThread_Internal(base.NativePtr, TickingGroup, Priority);
		}

		// Token: 0x0601E081 RID: 123009 RVA: 0x002C920F File Offset: 0x002C740F
		[NullableContext(2)]
		public void SetSkeletalMeshProxyTickFunction(ETickingGroup TickingGroup, USkeletalMeshComponent SkeletalComp, int Priority = 0)
		{
			UKuroTickManager.__SetSkeletalMeshProxyTickFunction_Internal(base.NativePtr, TickingGroup, (SkeletalComp != null) ? SkeletalComp.NativePtr : IntPtr.Zero, Priority);
		}

		// Token: 0x0601E082 RID: 123010 RVA: 0x002C9233 File Offset: 0x002C7433
		[NullableContext(2)]
		public void SetSkeletalMeshComponentPrerequisite(ETickingGroup TickingGroup, int Priority, USkeletalMeshComponent SkeletalComp)
		{
			UKuroTickManager.__SetSkeletalMeshComponentPrerequisite_Internal(base.NativePtr, TickingGroup, Priority, (SkeletalComp != null) ? SkeletalComp.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601E083 RID: 123011 RVA: 0x002C9257 File Offset: 0x002C7457
		public void SetGamePrerequisiteTickFunction(ETickingGroup TickingGroup, int Priority)
		{
			UKuroTickManager.__SetGamePrerequisiteTickFunction_Internal(base.NativePtr, TickingGroup, Priority);
		}

		// Token: 0x0601E084 RID: 123012 RVA: 0x002C926B File Offset: 0x002C746B
		[NullableContext(2)]
		public void SetCharacterMovementProxyTickFunction(ETickingGroup TickingGroup, UCharacterMovementComponent MoveComp, int Priority = 0)
		{
			UKuroTickManager.__SetCharacterMovementProxyTickFunction_Internal(base.NativePtr, TickingGroup, (MoveComp != null) ? MoveComp.NativePtr : IntPtr.Zero, Priority);
		}

		// Token: 0x0601E085 RID: 123013 RVA: 0x002C928F File Offset: 0x002C748F
		public bool RemoveTick(ETickingGroup TickingGroup)
		{
			return UKuroTickManager.__RemoveTick_Internal(base.NativePtr, TickingGroup);
		}

		// Token: 0x0601E086 RID: 123014 RVA: 0x002C92A2 File Offset: 0x002C74A2
		[NullableContext(2)]
		public void RemovePrerequisiteActorComponent(ETickingGroup TickingGroup, UActorComponent ActorComp, int Priority = 0)
		{
			UKuroTickManager.__RemovePrerequisiteActorComponent_Internal(base.NativePtr, TickingGroup, (ActorComp != null) ? ActorComp.NativePtr : IntPtr.Zero, Priority);
		}

		// Token: 0x0601E087 RID: 123015 RVA: 0x002C92C6 File Offset: 0x002C74C6
		[NullableContext(2)]
		public void RemovePrerequisiteActor(ETickingGroup TickingGroup, AActor Actor, int Priority = 0)
		{
			UKuroTickManager.__RemovePrerequisiteActor_Internal(base.NativePtr, TickingGroup, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, Priority);
		}

		// Token: 0x0601E088 RID: 123016 RVA: 0x002C92EA File Offset: 0x002C74EA
		public void ClearTick()
		{
			UKuroTickManager.__ClearTick_Internal(base.NativePtr);
		}

		// Token: 0x0601E089 RID: 123017 RVA: 0x002C92F7 File Offset: 0x002C74F7
		[NullableContext(2)]
		public void CleanSkeletalMeshProxyTickFunction(USkeletalMeshComponent SkeletalComp)
		{
			UKuroTickManager.__CleanSkeletalMeshProxyTickFunction_Internal(base.NativePtr, (SkeletalComp != null) ? SkeletalComp.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601E08A RID: 123018 RVA: 0x002C9314 File Offset: 0x002C7514
		[NullableContext(2)]
		public void CleanCharacterMovementProxyTickFunction(UCharacterMovementComponent MoveComp)
		{
			UKuroTickManager.__CleanCharacterMovementProxyTickFunction_Internal(base.NativePtr, (MoveComp != null) ? MoveComp.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601E08B RID: 123019 RVA: 0x002C9331 File Offset: 0x002C7531
		[NullableContext(2)]
		public bool AddTick(ETickingGroup TickingGroup, FTickHandler TickHandler, int Priority = 0)
		{
			return UKuroTickManager.__AddTick_Internal(base.NativePtr, TickingGroup, (TickHandler != null) ? TickHandler.NativePtr : ((IntPtr)0), Priority);
		}

		// Token: 0x0601E08C RID: 123020 RVA: 0x002C9352 File Offset: 0x002C7552
		[NullableContext(2)]
		public void AddPrerequisiteActorComponent(ETickingGroup TickingGroup, UActorComponent ActorComp, int Priority = 0)
		{
			UKuroTickManager.__AddPrerequisiteActorComponent_Internal(base.NativePtr, TickingGroup, (ActorComp != null) ? ActorComp.NativePtr : IntPtr.Zero, Priority);
		}

		// Token: 0x0601E08D RID: 123021 RVA: 0x002C9376 File Offset: 0x002C7576
		[NullableContext(2)]
		public void AddPrerequisiteActor(ETickingGroup TickingGroup, AActor Actor, int Priority = 0)
		{
			UKuroTickManager.__AddPrerequisiteActor_Internal(base.NativePtr, TickingGroup, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, Priority);
		}

		// Token: 0x0601E08E RID: 123022
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTickFunctionCompletionCallbackInMainThread_Internal(IntPtr @this, TEnumAsByte<ETickingGroup> TickingGroup, int Priority);

		// Token: 0x0601E08F RID: 123023
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSkeletalMeshProxyTickFunction_Internal(IntPtr @this, TEnumAsByte<ETickingGroup> TickingGroup, IntPtr SkeletalComp, int Priority);

		// Token: 0x0601E090 RID: 123024
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSkeletalMeshComponentPrerequisite_Internal(IntPtr @this, TEnumAsByte<ETickingGroup> TickingGroup, int Priority, IntPtr SkeletalComp);

		// Token: 0x0601E091 RID: 123025
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGamePrerequisiteTickFunction_Internal(IntPtr @this, TEnumAsByte<ETickingGroup> TickingGroup, int Priority);

		// Token: 0x0601E092 RID: 123026
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCharacterMovementProxyTickFunction_Internal(IntPtr @this, TEnumAsByte<ETickingGroup> TickingGroup, IntPtr MoveComp, int Priority);

		// Token: 0x0601E093 RID: 123027
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveTick_Internal(IntPtr @this, TEnumAsByte<ETickingGroup> TickingGroup);

		// Token: 0x0601E094 RID: 123028
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemovePrerequisiteActorComponent_Internal(IntPtr @this, TEnumAsByte<ETickingGroup> TickingGroup, IntPtr ActorComp, int Priority);

		// Token: 0x0601E095 RID: 123029
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemovePrerequisiteActor_Internal(IntPtr @this, TEnumAsByte<ETickingGroup> TickingGroup, IntPtr Actor, int Priority);

		// Token: 0x0601E096 RID: 123030
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearTick_Internal(IntPtr @this);

		// Token: 0x0601E097 RID: 123031
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CleanSkeletalMeshProxyTickFunction_Internal(IntPtr @this, IntPtr SkeletalComp);

		// Token: 0x0601E098 RID: 123032
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CleanCharacterMovementProxyTickFunction_Internal(IntPtr @this, IntPtr MoveComp);

		// Token: 0x0601E099 RID: 123033
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __AddTick_Internal(IntPtr @this, TEnumAsByte<ETickingGroup> TickingGroup, IntPtr TickHandler, int Priority);

		// Token: 0x0601E09A RID: 123034
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddPrerequisiteActorComponent_Internal(IntPtr @this, TEnumAsByte<ETickingGroup> TickingGroup, IntPtr ActorComp, int Priority);

		// Token: 0x0601E09B RID: 123035
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddPrerequisiteActor_Internal(IntPtr @this, TEnumAsByte<ETickingGroup> TickingGroup, IntPtr Actor, int Priority);

		// Token: 0x0601E09C RID: 123036 RVA: 0x002C939A File Offset: 0x002C759A
		static UKuroTickManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroTickManager");
		}

		// Token: 0x0601E09D RID: 123037 RVA: 0x002C93A8 File Offset: 0x002C75A8
		protected UKuroTickManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040103DE RID: 66526
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroTickManager";

		// Token: 0x040103DF RID: 66527
		private static IntPtr _ClassPtr;

		// Token: 0x040103E0 RID: 66528
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
