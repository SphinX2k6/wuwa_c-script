using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000643 RID: 1603
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LevelSequence.LevelSequencePlayer")]
	[UnrealStructLayout(2128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2128)]
	public class ULevelSequencePlayer : UMovieSceneSequencePlayer, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008D21 RID: 36129 RVA: 0x000D4428 File Offset: 0x000D2628
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULevelSequencePlayer._ClassPtr;
		}

		// Token: 0x06008D22 RID: 36130 RVA: 0x000D4434 File Offset: 0x000D2634
		public ULevelSequencePlayer() : this(BuiltinUtils.AllocNativeUObject(ULevelSequencePlayer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008D23 RID: 36131 RVA: 0x000D445C File Offset: 0x000D265C
		public ULevelSequencePlayer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULevelSequencePlayer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001ABB RID: 6843
		// (get) Token: 0x06008D24 RID: 36132 RVA: 0x000D4490 File Offset: 0x000D2690
		// (set) Token: 0x06008D25 RID: 36133 RVA: 0x000D44C9 File Offset: 0x000D26C9
		public FOnLevelSequencePlayerCameraCutEvent OnCameraCut
		{
			get
			{
				base.FastCheckIsValid();
				FOnLevelSequencePlayerCameraCutEvent result;
				if ((result = this._OnCameraCut) == null)
				{
					result = (this._OnCameraCut = new FOnLevelSequencePlayerCameraCutEvent(base.NativePtr + (IntPtr)ULevelSequencePlayer.__PropertyOffset_OnCameraCut, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)ULevelSequencePlayer.__PropertyOffset_OnCameraCut, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001ABC RID: 6844
		// (get) Token: 0x06008D26 RID: 36134 RVA: 0x000D44EC File Offset: 0x000D26EC
		// (set) Token: 0x06008D27 RID: 36135 RVA: 0x000D4525 File Offset: 0x000D2725
		public FOnSequenceObjectSpawned OnSequenceObjectSpawned
		{
			get
			{
				base.FastCheckIsValid();
				FOnSequenceObjectSpawned result;
				if ((result = this._OnSequenceObjectSpawned) == null)
				{
					result = (this._OnSequenceObjectSpawned = new FOnSequenceObjectSpawned(base.NativePtr + (IntPtr)ULevelSequencePlayer.__PropertyOffset_OnSequenceObjectSpawned, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)ULevelSequencePlayer.__PropertyOffset_OnSequenceObjectSpawned, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06008D28 RID: 36136 RVA: 0x000D4546 File Offset: 0x000D2746
		[NullableContext(2)]
		public AActor GetSpawnedActorByGuid(FGuid Guid, bool bIncludeSubSequence = false)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ULevelSequencePlayer.__GetSpawnedActorByGuid_Internal(base.NativePtr, Guid, bIncludeSubSequence));
		}

		// Token: 0x06008D29 RID: 36137 RVA: 0x000D455A File Offset: 0x000D275A
		public TArray<UObject> GetAllSpawnedObjects()
		{
			return new TArray<UObject>(ULevelSequencePlayer.__GetAllSpawnedObjects_Internal(base.NativePtr), null);
		}

		// Token: 0x06008D2A RID: 36138 RVA: 0x000D456D File Offset: 0x000D276D
		[NullableContext(2)]
		public UCameraComponent GetActiveCameraComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UCameraComponent>(ULevelSequencePlayer.__GetActiveCameraComponent_Internal(base.NativePtr));
		}

		// Token: 0x06008D2B RID: 36139 RVA: 0x000D4580 File Offset: 0x000D2780
		[NullableContext(2)]
		public static ULevelSequencePlayer CreateLevelSequencePlayer(UObject WorldContextObject, ULevelSequence LevelSequence, FMovieSceneSequencePlaybackSettings Settings, ref ALevelSequenceActor OutActor)
		{
			ALevelSequenceActor alevelSequenceActor = OutActor;
			IntPtr nativeObjectPtr = (alevelSequenceActor != null) ? alevelSequenceActor.NativePtr : IntPtr.Zero;
			ULevelSequencePlayer orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelSequencePlayer>(ULevelSequencePlayer.__CreateLevelSequencePlayer_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (LevelSequence != null) ? LevelSequence.NativePtr : IntPtr.Zero, (Settings ?? new FMovieSceneSequencePlaybackSettings()).NativePtr, ref nativeObjectPtr));
			OutActor = BuiltinUtils.GetOrCreateUObjectByNativePointer<ALevelSequenceActor>(nativeObjectPtr);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x06008D2C RID: 36140 RVA: 0x000D45E3 File Offset: 0x000D27E3
		public void CleanUnboundSpawnable()
		{
			ULevelSequencePlayer.__CleanUnboundSpawnable_Internal(base.NativePtr);
		}

		// Token: 0x06008D2D RID: 36141
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSpawnedActorByGuid_Internal(IntPtr @this, FGuid Guid, bool bIncludeSubSequence);

		// Token: 0x06008D2E RID: 36142
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAllSpawnedObjects_Internal(IntPtr @this);

		// Token: 0x06008D2F RID: 36143
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActiveCameraComponent_Internal(IntPtr @this);

		// Token: 0x06008D30 RID: 36144
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateLevelSequencePlayer_Internal(IntPtr WorldContextObject, IntPtr LevelSequence, IntPtr Settings, ref IntPtr OutActor);

		// Token: 0x06008D31 RID: 36145
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CleanUnboundSpawnable_Internal(IntPtr @this);

		// Token: 0x06008D32 RID: 36146 RVA: 0x000D45F0 File Offset: 0x000D27F0
		static ULevelSequencePlayer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LevelSequence.LevelSequencePlayer");
		}

		// Token: 0x06008D33 RID: 36147 RVA: 0x000D45FE File Offset: 0x000D27FE
		protected ULevelSequencePlayer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003D70 RID: 15728
		public new const string __ObjectPath = "/Script/LevelSequence.LevelSequencePlayer";

		// Token: 0x04003D71 RID: 15729
		private static IntPtr _ClassPtr;

		// Token: 0x04003D72 RID: 15730
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003D73 RID: 15731
		internal static int __PropertyOffset_OnCameraCut;

		// Token: 0x04003D74 RID: 15732
		[Nullable(2)]
		private FOnLevelSequencePlayerCameraCutEvent _OnCameraCut;

		// Token: 0x04003D75 RID: 15733
		internal static int __PropertyOffset_OnSequenceObjectSpawned;

		// Token: 0x04003D76 RID: 15734
		[Nullable(2)]
		private FOnSequenceObjectSpawned _OnSequenceObjectSpawned;
	}
}
