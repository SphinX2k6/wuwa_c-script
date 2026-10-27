using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001FC0 RID: 8128
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LevelSequence.LevelSequencePlayer")]
	[UnrealStructLayout(2128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2128)]
	public class ULevelSequencePlayer : UMovieSceneSequencePlayer, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601ED75 RID: 126325 RVA: 0x002DD455 File Offset: 0x002DB655
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULevelSequencePlayer._ClassPtr;
		}

		// Token: 0x0601ED76 RID: 126326 RVA: 0x002DD464 File Offset: 0x002DB664
		public ULevelSequencePlayer() : this(BuiltinUtils.AllocNativeUObject(ULevelSequencePlayer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601ED77 RID: 126327 RVA: 0x002DD48C File Offset: 0x002DB68C
		public ULevelSequencePlayer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULevelSequencePlayer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007AC4 RID: 31428
		// (get) Token: 0x0601ED78 RID: 126328 RVA: 0x002DD4C0 File Offset: 0x002DB6C0
		// (set) Token: 0x0601ED79 RID: 126329 RVA: 0x002DD4F9 File Offset: 0x002DB6F9
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

		// Token: 0x17007AC5 RID: 31429
		// (get) Token: 0x0601ED7A RID: 126330 RVA: 0x002DD51C File Offset: 0x002DB71C
		// (set) Token: 0x0601ED7B RID: 126331 RVA: 0x002DD555 File Offset: 0x002DB755
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

		// Token: 0x0601ED7C RID: 126332 RVA: 0x002DD576 File Offset: 0x002DB776
		[NullableContext(2)]
		public AActor GetSpawnedActorByGuid(FGuid Guid, bool bIncludeSubSequence = false)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ULevelSequencePlayer.__GetSpawnedActorByGuid_Internal(base.NativePtr, Guid, bIncludeSubSequence));
		}

		// Token: 0x0601ED7D RID: 126333 RVA: 0x002DD58A File Offset: 0x002DB78A
		public TArray<UObject> GetAllSpawnedObjects()
		{
			return new TArray<UObject>(ULevelSequencePlayer.__GetAllSpawnedObjects_Internal(base.NativePtr), null);
		}

		// Token: 0x0601ED7E RID: 126334 RVA: 0x002DD59D File Offset: 0x002DB79D
		[NullableContext(2)]
		public UCameraComponent GetActiveCameraComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UCameraComponent>(ULevelSequencePlayer.__GetActiveCameraComponent_Internal(base.NativePtr));
		}

		// Token: 0x0601ED7F RID: 126335 RVA: 0x002DD5B0 File Offset: 0x002DB7B0
		[NullableContext(2)]
		public static ULevelSequencePlayer CreateLevelSequencePlayer(UObject WorldContextObject, ULevelSequence LevelSequence, FMovieSceneSequencePlaybackSettings Settings, ref ALevelSequenceActor OutActor)
		{
			ALevelSequenceActor alevelSequenceActor = OutActor;
			IntPtr nativeObjectPtr = (alevelSequenceActor != null) ? alevelSequenceActor.NativePtr : IntPtr.Zero;
			ULevelSequencePlayer orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelSequencePlayer>(ULevelSequencePlayer.__CreateLevelSequencePlayer_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (LevelSequence != null) ? LevelSequence.NativePtr : IntPtr.Zero, (Settings ?? new FMovieSceneSequencePlaybackSettings()).NativePtr, ref nativeObjectPtr));
			OutActor = BuiltinUtils.GetOrCreateUObjectByNativePointer<ALevelSequenceActor>(nativeObjectPtr);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x0601ED80 RID: 126336 RVA: 0x002DD613 File Offset: 0x002DB813
		public void CleanUnboundSpawnable()
		{
			ULevelSequencePlayer.__CleanUnboundSpawnable_Internal(base.NativePtr);
		}

		// Token: 0x0601ED81 RID: 126337
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSpawnedActorByGuid_Internal(IntPtr @this, FGuid Guid, bool bIncludeSubSequence);

		// Token: 0x0601ED82 RID: 126338
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAllSpawnedObjects_Internal(IntPtr @this);

		// Token: 0x0601ED83 RID: 126339
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActiveCameraComponent_Internal(IntPtr @this);

		// Token: 0x0601ED84 RID: 126340
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateLevelSequencePlayer_Internal(IntPtr WorldContextObject, IntPtr LevelSequence, IntPtr Settings, ref IntPtr OutActor);

		// Token: 0x0601ED85 RID: 126341
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CleanUnboundSpawnable_Internal(IntPtr @this);

		// Token: 0x0601ED86 RID: 126342 RVA: 0x002DD620 File Offset: 0x002DB820
		static ULevelSequencePlayer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LevelSequence.LevelSequencePlayer");
		}

		// Token: 0x0601ED87 RID: 126343 RVA: 0x002DD62E File Offset: 0x002DB82E
		protected ULevelSequencePlayer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010AA4 RID: 68260
		public new const string __ObjectPath = "/Script/LevelSequence.LevelSequencePlayer";

		// Token: 0x04010AA5 RID: 68261
		private static IntPtr _ClassPtr;

		// Token: 0x04010AA6 RID: 68262
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010AA7 RID: 68263
		internal static int __PropertyOffset_OnCameraCut;

		// Token: 0x04010AA8 RID: 68264
		[Nullable(2)]
		private FOnLevelSequencePlayerCameraCutEvent _OnCameraCut;

		// Token: 0x04010AA9 RID: 68265
		internal static int __PropertyOffset_OnSequenceObjectSpawned;

		// Token: 0x04010AAA RID: 68266
		[Nullable(2)]
		private FOnSequenceObjectSpawned _OnSequenceObjectSpawned;
	}
}
