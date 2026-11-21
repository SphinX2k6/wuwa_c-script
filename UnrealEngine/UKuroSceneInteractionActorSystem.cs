using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004E0 RID: 1248
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroSceneInteractionActorSystem")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UKuroSceneInteractionActorSystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060075DF RID: 30175 RVA: 0x000AC471 File Offset: 0x000AA671
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSceneInteractionActorSystem._ClassPtr;
		}

		// Token: 0x060075E0 RID: 30176 RVA: 0x000AC480 File Offset: 0x000AA680
		public UKuroSceneInteractionActorSystem() : this(BuiltinUtils.AllocNativeUObject(UKuroSceneInteractionActorSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060075E1 RID: 30177 RVA: 0x000AC4A8 File Offset: 0x000AA6A8
		[NullableContext(1)]
		public UKuroSceneInteractionActorSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSceneInteractionActorSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060075E2 RID: 30178 RVA: 0x000AC4DB File Offset: 0x000AA6DB
		public bool SwitchToState(int HandleId, EKuroSceneInteractionState TargetState, bool NeedTransition)
		{
			return UKuroSceneInteractionActorSystem.__SwitchToState_Internal(base.NativePtr, HandleId, TargetState, NeedTransition);
		}

		// Token: 0x060075E3 RID: 30179 RVA: 0x000AC4EB File Offset: 0x000AA6EB
		[NullableContext(2)]
		public void SetSequenceWithTargetLevelActor(ALevelSequenceActor LevelSequenceActor, ULevelSequence InSequence, AActor TargetLevelActor)
		{
			UKuroSceneInteractionActorSystem.__SetSequenceWithTargetLevelActor_Internal(base.NativePtr, (LevelSequenceActor != null) ? LevelSequenceActor.NativePtr : IntPtr.Zero, (InSequence != null) ? InSequence.NativePtr : IntPtr.Zero, (TargetLevelActor != null) ? TargetLevelActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060075E4 RID: 30180 RVA: 0x000AC528 File Offset: 0x000AA728
		public EKuroSceneInteractionState GetCurrentState(int HandleId)
		{
			return UKuroSceneInteractionActorSystem.__GetCurrentState_Internal(base.NativePtr, HandleId);
		}

		// Token: 0x060075E5 RID: 30181 RVA: 0x000AC536 File Offset: 0x000AA736
		public bool DestroySceneInteractionLevel(int HandleId)
		{
			return UKuroSceneInteractionActorSystem.__DestroySceneInteractionLevel_Internal(base.NativePtr, HandleId);
		}

		// Token: 0x060075E6 RID: 30182 RVA: 0x000AC544 File Offset: 0x000AA744
		[NullableContext(1)]
		public unsafe int CreateSceneInteractionLevel(string InLevelName, EKuroSceneInteractionState InitState, FVector Location, FRotator Rotation)
		{
			FString fstring = FString.AllocTemp(InLevelName);
			int result = UKuroSceneInteractionActorSystem.__CreateSceneInteractionLevel_Internal(base.NativePtr, fstring, InitState, Location, Rotation);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060075E7 RID: 30183 RVA: 0x000AC574 File Offset: 0x000AA774
		[NullableContext(2)]
		public unsafe void BindActorToLevelSequenceActor(AActor ActorToBind, ALevelSequenceActor LevelSequenceActor, [Nullable(1)] string BindingName)
		{
			FString fstring = FString.AllocTemp(BindingName);
			UKuroSceneInteractionActorSystem.__BindActorToLevelSequenceActor_Internal(base.NativePtr, (ActorToBind != null) ? ActorToBind.NativePtr : IntPtr.Zero, (LevelSequenceActor != null) ? LevelSequenceActor.NativePtr : IntPtr.Zero, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060075E8 RID: 30184
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SwitchToState_Internal(IntPtr @this, int HandleId, EKuroSceneInteractionState TargetState, bool NeedTransition);

		// Token: 0x060075E9 RID: 30185
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSequenceWithTargetLevelActor_Internal(IntPtr @this, IntPtr LevelSequenceActor, IntPtr InSequence, IntPtr TargetLevelActor);

		// Token: 0x060075EA RID: 30186
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EKuroSceneInteractionState __GetCurrentState_Internal(IntPtr @this, int HandleId);

		// Token: 0x060075EB RID: 30187
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DestroySceneInteractionLevel_Internal(IntPtr @this, int HandleId);

		// Token: 0x060075EC RID: 30188
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __CreateSceneInteractionLevel_Internal(IntPtr @this, in FString InLevelName, EKuroSceneInteractionState InitState, FVector Location, FRotator Rotation);

		// Token: 0x060075ED RID: 30189
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindActorToLevelSequenceActor_Internal(IntPtr @this, IntPtr ActorToBind, IntPtr LevelSequenceActor, in FString BindingName);

		// Token: 0x060075EE RID: 30190 RVA: 0x000AC5BE File Offset: 0x000AA7BE
		static UKuroSceneInteractionActorSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroSceneInteractionActorSystem");
		}

		// Token: 0x060075EF RID: 30191 RVA: 0x000AC5CC File Offset: 0x000AA7CC
		protected UKuroSceneInteractionActorSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040031B9 RID: 12729
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroSceneInteractionActorSystem";

		// Token: 0x040031BA RID: 12730
		private static IntPtr _ClassPtr;

		// Token: 0x040031BB RID: 12731
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
