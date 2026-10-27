using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BA8 RID: 7080
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroSceneInteractionActorSystem")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UKuroSceneInteractionActorSystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B127 RID: 110887 RVA: 0x0027E329 File Offset: 0x0027C529
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSceneInteractionActorSystem._ClassPtr;
		}

		// Token: 0x0601B128 RID: 110888 RVA: 0x0027E338 File Offset: 0x0027C538
		public UKuroSceneInteractionActorSystem() : this(BuiltinUtils.AllocNativeUObject(UKuroSceneInteractionActorSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B129 RID: 110889 RVA: 0x0027E360 File Offset: 0x0027C560
		public UKuroSceneInteractionActorSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSceneInteractionActorSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006C7D RID: 27773
		// (get) Token: 0x0601B12A RID: 110890 RVA: 0x0027E394 File Offset: 0x0027C594
		// (set) Token: 0x0601B12B RID: 110891 RVA: 0x0027E3CD File Offset: 0x0027C5CD
		public TMap<int, UKuroSceneInteractionInfo> AllSceneInteractionInfos
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, UKuroSceneInteractionInfo> result;
				if ((result = this._AllSceneInteractionInfos) == null)
				{
					result = (this._AllSceneInteractionInfos = new TMap<int, UKuroSceneInteractionInfo>(base.NativePtr + (IntPtr)UKuroSceneInteractionActorSystem.__PropertyOffset_AllSceneInteractionInfos, this));
				}
				return result;
			}
			set
			{
				this.AllSceneInteractionInfos.CopyAssign(value);
			}
		}

		// Token: 0x0601B12C RID: 110892 RVA: 0x0027E3DB File Offset: 0x0027C5DB
		public bool SwitchToState(int HandleId, EKuroSceneInteractionState TargetState, bool NeedTransition)
		{
			return UKuroSceneInteractionActorSystem.__SwitchToState_Internal(base.NativePtr, HandleId, TargetState, NeedTransition);
		}

		// Token: 0x0601B12D RID: 110893 RVA: 0x0027E3EB File Offset: 0x0027C5EB
		[NullableContext(2)]
		public void SetSequenceWithTargetLevelActor(ALevelSequenceActor LevelSequenceActor, ULevelSequence InSequence, AActor TargetLevelActor)
		{
			UKuroSceneInteractionActorSystem.__SetSequenceWithTargetLevelActor_Internal(base.NativePtr, (LevelSequenceActor != null) ? LevelSequenceActor.NativePtr : IntPtr.Zero, (InSequence != null) ? InSequence.NativePtr : IntPtr.Zero, (TargetLevelActor != null) ? TargetLevelActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601B12E RID: 110894 RVA: 0x0027E428 File Offset: 0x0027C628
		public EKuroSceneInteractionState GetCurrentState(int HandleId)
		{
			return UKuroSceneInteractionActorSystem.__GetCurrentState_Internal(base.NativePtr, HandleId);
		}

		// Token: 0x0601B12F RID: 110895 RVA: 0x0027E436 File Offset: 0x0027C636
		public bool DestroySceneInteractionLevel(int HandleId)
		{
			return UKuroSceneInteractionActorSystem.__DestroySceneInteractionLevel_Internal(base.NativePtr, HandleId);
		}

		// Token: 0x0601B130 RID: 110896 RVA: 0x0027E444 File Offset: 0x0027C644
		public unsafe int CreateSceneInteractionLevel(string InLevelName, EKuroSceneInteractionState InitState, FVector Location, FRotator Rotation)
		{
			FString fstring = FString.AllocTemp(InLevelName);
			int result = UKuroSceneInteractionActorSystem.__CreateSceneInteractionLevel_Internal(base.NativePtr, fstring, InitState, Location, Rotation);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601B131 RID: 110897 RVA: 0x0027E474 File Offset: 0x0027C674
		[NullableContext(2)]
		public unsafe void BindActorToLevelSequenceActor(AActor ActorToBind, ALevelSequenceActor LevelSequenceActor, [Nullable(1)] string BindingName)
		{
			FString fstring = FString.AllocTemp(BindingName);
			UKuroSceneInteractionActorSystem.__BindActorToLevelSequenceActor_Internal(base.NativePtr, (ActorToBind != null) ? ActorToBind.NativePtr : IntPtr.Zero, (LevelSequenceActor != null) ? LevelSequenceActor.NativePtr : IntPtr.Zero, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601B132 RID: 110898
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SwitchToState_Internal(IntPtr @this, int HandleId, EKuroSceneInteractionState TargetState, bool NeedTransition);

		// Token: 0x0601B133 RID: 110899
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSequenceWithTargetLevelActor_Internal(IntPtr @this, IntPtr LevelSequenceActor, IntPtr InSequence, IntPtr TargetLevelActor);

		// Token: 0x0601B134 RID: 110900
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EKuroSceneInteractionState __GetCurrentState_Internal(IntPtr @this, int HandleId);

		// Token: 0x0601B135 RID: 110901
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DestroySceneInteractionLevel_Internal(IntPtr @this, int HandleId);

		// Token: 0x0601B136 RID: 110902
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __CreateSceneInteractionLevel_Internal(IntPtr @this, in FString InLevelName, EKuroSceneInteractionState InitState, FVector Location, FRotator Rotation);

		// Token: 0x0601B137 RID: 110903
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindActorToLevelSequenceActor_Internal(IntPtr @this, IntPtr ActorToBind, IntPtr LevelSequenceActor, in FString BindingName);

		// Token: 0x0601B138 RID: 110904 RVA: 0x0027E4BE File Offset: 0x0027C6BE
		static UKuroSceneInteractionActorSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroSceneInteractionActorSystem");
		}

		// Token: 0x0601B139 RID: 110905 RVA: 0x0027E4CC File Offset: 0x0027C6CC
		protected UKuroSceneInteractionActorSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E935 RID: 59701
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroSceneInteractionActorSystem";

		// Token: 0x0400E936 RID: 59702
		private static IntPtr _ClassPtr;

		// Token: 0x0400E937 RID: 59703
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E938 RID: 59704
		internal static int __PropertyOffset_AllSceneInteractionInfos;

		// Token: 0x0400E939 RID: 59705
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, UKuroSceneInteractionInfo> _AllSceneInteractionInfos;
	}
}
