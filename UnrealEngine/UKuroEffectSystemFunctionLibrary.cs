using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003EB RID: 1003
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroEffectSystemFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroEffectSystemFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006216 RID: 25110 RVA: 0x0008C3A5 File Offset: 0x0008A5A5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroEffectSystemFunctionLibrary._ClassPtr;
		}

		// Token: 0x06006217 RID: 25111 RVA: 0x0008C3B4 File Offset: 0x0008A5B4
		public UKuroEffectSystemFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroEffectSystemFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006218 RID: 25112 RVA: 0x0008C3DC File Offset: 0x0008A5DC
		[NullableContext(1)]
		public UKuroEffectSystemFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroEffectSystemFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006219 RID: 25113
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UpdateIsGameRunning(bool bIsGameRunning);

		// Token: 0x0600621A RID: 25114
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UpdateBodyEffect(int Id, float Opacity, bool bVisible, bool bCastShadow);

		// Token: 0x0600621B RID: 25115
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void TickHandleInEditor(int Id, float Delta);

		// Token: 0x0600621C RID: 25116
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void StopLimitedEffectFromEntityImmediately(int EntityId, bool RootOnly);

		// Token: 0x0600621D RID: 25117
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void StopEffectFromEntity(int EntityId, FName FilterName, bool Immediately);

		// Token: 0x0600621E RID: 25118 RVA: 0x0008C410 File Offset: 0x0008A610
		[NullableContext(1)]
		public unsafe static bool StopEffectById(int Handle, string Reason, bool Immediately, bool bDestroyActor = false)
		{
			FString fstring = FString.AllocTemp(Reason);
			bool result = UKuroEffectSystemFunctionLibrary.__StopEffectById_Internal(Handle, fstring, Immediately, bDestroyActor);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600621F RID: 25119 RVA: 0x0008C438 File Offset: 0x0008A638
		public unsafe static int SpawnUnloopedEffectFromSkeletalContext(UObject WorldContext, in FTransformDouble Transform, [Nullable(1)] string Path, [Nullable(1)] string Reason, in FKuroSkeletalMeshEffectContext Context, in FKuroEffectBeforeInitCallback BeforeInitCallback, in FKuroEffectInitCallback Callback, in FKuroEffectBeforePlayCallback BeforePlayCallback, in FKuroEffectOnClearCallback OnClearCallback, byte EffectType = 3, bool bPrepare = false, bool bForceCreateActor = false)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = Transform;
			FString fstring = FString.AllocTemp(Path);
			FString fstring2 = FString.AllocTemp(Reason);
			IntPtr worldContext = (WorldContext != null) ? WorldContext.NativePtr : IntPtr.Zero;
			ref FTransformDouble transform = ref ptr;
			IntPtr nativePtr = (Context ?? new FKuroSkeletalMeshEffectContext()).NativePtr;
			FKuroEffectBeforeInitCallback fkuroEffectBeforeInitCallback = BeforeInitCallback;
			IntPtr beforeInitCallback = (fkuroEffectBeforeInitCallback != null) ? fkuroEffectBeforeInitCallback.NativePtr : ((IntPtr)0);
			FKuroEffectInitCallback fkuroEffectInitCallback = Callback;
			IntPtr callback = (fkuroEffectInitCallback != null) ? fkuroEffectInitCallback.NativePtr : ((IntPtr)0);
			FKuroEffectBeforePlayCallback fkuroEffectBeforePlayCallback = BeforePlayCallback;
			IntPtr beforePlayCallback = (fkuroEffectBeforePlayCallback != null) ? fkuroEffectBeforePlayCallback.NativePtr : ((IntPtr)0);
			FKuroEffectOnClearCallback fkuroEffectOnClearCallback = OnClearCallback;
			int result = UKuroEffectSystemFunctionLibrary.__SpawnUnloopedEffectFromSkeletalContext_Internal(worldContext, transform, fstring, fstring2, nativePtr, beforeInitCallback, callback, beforePlayCallback, (fkuroEffectOnClearCallback != null) ? fkuroEffectOnClearCallback.NativePtr : ((IntPtr)0), EffectType, bPrepare, bForceCreateActor);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06006220 RID: 25120 RVA: 0x0008C4F4 File Offset: 0x0008A6F4
		public unsafe static int SpawnUnloopedEffectFromGhostContext(UObject WorldContext, in FTransformDouble Transform, [Nullable(1)] string Path, [Nullable(1)] string Reason, in FKuroEffectRuntimeGhostEffectContext Context, in FKuroEffectBeforeInitCallback BeforeInitCallback, in FKuroEffectInitCallback Callback, in FKuroEffectBeforePlayCallback BeforePlayCallback, in FKuroEffectOnClearCallback OnClearCallback, byte EffectType = 3, bool bPrepare = false, bool bForceCreateActor = false)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = Transform;
			FString fstring = FString.AllocTemp(Path);
			FString fstring2 = FString.AllocTemp(Reason);
			IntPtr worldContext = (WorldContext != null) ? WorldContext.NativePtr : IntPtr.Zero;
			ref FTransformDouble transform = ref ptr;
			IntPtr nativePtr = (Context ?? new FKuroEffectRuntimeGhostEffectContext()).NativePtr;
			FKuroEffectBeforeInitCallback fkuroEffectBeforeInitCallback = BeforeInitCallback;
			IntPtr beforeInitCallback = (fkuroEffectBeforeInitCallback != null) ? fkuroEffectBeforeInitCallback.NativePtr : ((IntPtr)0);
			FKuroEffectInitCallback fkuroEffectInitCallback = Callback;
			IntPtr callback = (fkuroEffectInitCallback != null) ? fkuroEffectInitCallback.NativePtr : ((IntPtr)0);
			FKuroEffectBeforePlayCallback fkuroEffectBeforePlayCallback = BeforePlayCallback;
			IntPtr beforePlayCallback = (fkuroEffectBeforePlayCallback != null) ? fkuroEffectBeforePlayCallback.NativePtr : ((IntPtr)0);
			FKuroEffectOnClearCallback fkuroEffectOnClearCallback = OnClearCallback;
			int result = UKuroEffectSystemFunctionLibrary.__SpawnUnloopedEffectFromGhostContext_Internal(worldContext, transform, fstring, fstring2, nativePtr, beforeInitCallback, callback, beforePlayCallback, (fkuroEffectOnClearCallback != null) ? fkuroEffectOnClearCallback.NativePtr : ((IntPtr)0), EffectType, bPrepare, bForceCreateActor);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06006221 RID: 25121 RVA: 0x0008C5B0 File Offset: 0x0008A7B0
		public unsafe static int SpawnUnloopedEffectFromAudioContext(UObject WorldContext, in FTransformDouble Transform, [Nullable(1)] string Path, [Nullable(1)] string Reason, in FKuroEffectAudioContext Context, in FKuroEffectBeforeInitCallback BeforeInitCallback, in FKuroEffectInitCallback Callback, in FKuroEffectBeforePlayCallback BeforePlayCallback, in FKuroEffectOnClearCallback OnClearCallback, byte EffectType = 3, bool bPrepare = false, bool bForceCreateActor = false)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = Transform;
			FString fstring = FString.AllocTemp(Path);
			FString fstring2 = FString.AllocTemp(Reason);
			IntPtr worldContext = (WorldContext != null) ? WorldContext.NativePtr : IntPtr.Zero;
			ref FTransformDouble transform = ref ptr;
			IntPtr nativePtr = (Context ?? new FKuroEffectAudioContext()).NativePtr;
			FKuroEffectBeforeInitCallback fkuroEffectBeforeInitCallback = BeforeInitCallback;
			IntPtr beforeInitCallback = (fkuroEffectBeforeInitCallback != null) ? fkuroEffectBeforeInitCallback.NativePtr : ((IntPtr)0);
			FKuroEffectInitCallback fkuroEffectInitCallback = Callback;
			IntPtr callback = (fkuroEffectInitCallback != null) ? fkuroEffectInitCallback.NativePtr : ((IntPtr)0);
			FKuroEffectBeforePlayCallback fkuroEffectBeforePlayCallback = BeforePlayCallback;
			IntPtr beforePlayCallback = (fkuroEffectBeforePlayCallback != null) ? fkuroEffectBeforePlayCallback.NativePtr : ((IntPtr)0);
			FKuroEffectOnClearCallback fkuroEffectOnClearCallback = OnClearCallback;
			int result = UKuroEffectSystemFunctionLibrary.__SpawnUnloopedEffectFromAudioContext_Internal(worldContext, transform, fstring, fstring2, nativePtr, beforeInitCallback, callback, beforePlayCallback, (fkuroEffectOnClearCallback != null) ? fkuroEffectOnClearCallback.NativePtr : ((IntPtr)0), EffectType, bPrepare, bForceCreateActor);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06006222 RID: 25122 RVA: 0x0008C66C File Offset: 0x0008A86C
		public unsafe static int SpawnUnloopedEffect(UObject WorldContext, in FTransformDouble Transform, [Nullable(1)] string Path, [Nullable(1)] string Reason, in FKuroEffectContext Context, in FKuroEffectBeforeInitCallback BeforeInitCallback, in FKuroEffectInitCallback Callback, in FKuroEffectBeforePlayCallback BeforePlayCallback, in FKuroEffectOnClearCallback OnClearCallback, byte EffectType = 3, bool bPrepare = false, bool bForceCreateActor = false)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = Transform;
			FString fstring = FString.AllocTemp(Path);
			FString fstring2 = FString.AllocTemp(Reason);
			IntPtr worldContext = (WorldContext != null) ? WorldContext.NativePtr : IntPtr.Zero;
			ref FTransformDouble transform = ref ptr;
			IntPtr nativePtr = (Context ?? new FKuroEffectContext()).NativePtr;
			FKuroEffectBeforeInitCallback fkuroEffectBeforeInitCallback = BeforeInitCallback;
			IntPtr beforeInitCallback = (fkuroEffectBeforeInitCallback != null) ? fkuroEffectBeforeInitCallback.NativePtr : ((IntPtr)0);
			FKuroEffectInitCallback fkuroEffectInitCallback = Callback;
			IntPtr callback = (fkuroEffectInitCallback != null) ? fkuroEffectInitCallback.NativePtr : ((IntPtr)0);
			FKuroEffectBeforePlayCallback fkuroEffectBeforePlayCallback = BeforePlayCallback;
			IntPtr beforePlayCallback = (fkuroEffectBeforePlayCallback != null) ? fkuroEffectBeforePlayCallback.NativePtr : ((IntPtr)0);
			FKuroEffectOnClearCallback fkuroEffectOnClearCallback = OnClearCallback;
			int result = UKuroEffectSystemFunctionLibrary.__SpawnUnloopedEffect_Internal(worldContext, transform, fstring, fstring2, nativePtr, beforeInitCallback, callback, beforePlayCallback, (fkuroEffectOnClearCallback != null) ? fkuroEffectOnClearCallback.NativePtr : ((IntPtr)0), EffectType, bPrepare, bForceCreateActor);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06006223 RID: 25123 RVA: 0x0008C728 File Offset: 0x0008A928
		public unsafe static int SpawnEffectWithActorFromSkeletalContext(UObject WorldContext, AActor Actor, [Nullable(1)] string Path, [Nullable(1)] string Reason, in FKuroSkeletalMeshEffectContext Context, bool bAutoPlay = true, bool bIsExternalActor = true, byte EffectType = 3)
		{
			FString fstring = FString.AllocTemp(Path);
			FString fstring2 = FString.AllocTemp(Reason);
			int result = UKuroEffectSystemFunctionLibrary.__SpawnEffectWithActorFromSkeletalContext_Internal((WorldContext != null) ? WorldContext.NativePtr : IntPtr.Zero, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, fstring, fstring2, (Context ?? new FKuroSkeletalMeshEffectContext()).NativePtr, bAutoPlay, bIsExternalActor, EffectType);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06006224 RID: 25124 RVA: 0x0008C798 File Offset: 0x0008A998
		public unsafe static int SpawnEffectWithActorFromGhostContext(UObject WorldContext, AActor Actor, [Nullable(1)] string Path, [Nullable(1)] string Reason, in FKuroEffectRuntimeGhostEffectContext Context, bool bAutoPlay = true, bool bIsExternalActor = true, byte EffectType = 3)
		{
			FString fstring = FString.AllocTemp(Path);
			FString fstring2 = FString.AllocTemp(Reason);
			int result = UKuroEffectSystemFunctionLibrary.__SpawnEffectWithActorFromGhostContext_Internal((WorldContext != null) ? WorldContext.NativePtr : IntPtr.Zero, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, fstring, fstring2, (Context ?? new FKuroEffectRuntimeGhostEffectContext()).NativePtr, bAutoPlay, bIsExternalActor, EffectType);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06006225 RID: 25125 RVA: 0x0008C808 File Offset: 0x0008AA08
		public unsafe static int SpawnEffectWithActorFromAudioContext(UObject WorldContext, AActor Actor, [Nullable(1)] string Path, [Nullable(1)] string Reason, in FKuroEffectAudioContext Context, bool bAutoPlay = true, bool bIsExternalActor = true, byte EffectType = 3)
		{
			FString fstring = FString.AllocTemp(Path);
			FString fstring2 = FString.AllocTemp(Reason);
			int result = UKuroEffectSystemFunctionLibrary.__SpawnEffectWithActorFromAudioContext_Internal((WorldContext != null) ? WorldContext.NativePtr : IntPtr.Zero, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, fstring, fstring2, (Context ?? new FKuroEffectAudioContext()).NativePtr, bAutoPlay, bIsExternalActor, EffectType);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06006226 RID: 25126 RVA: 0x0008C878 File Offset: 0x0008AA78
		public unsafe static int SpawnEffectWithActor(UObject WorldContext, AActor Actor, [Nullable(1)] string Path, [Nullable(1)] string Reason, in FKuroEffectContext Context, bool bAutoPlay = true, bool bIsExternalActor = true, byte EffectType = 3)
		{
			FString fstring = FString.AllocTemp(Path);
			FString fstring2 = FString.AllocTemp(Reason);
			int result = UKuroEffectSystemFunctionLibrary.__SpawnEffectWithActor_Internal((WorldContext != null) ? WorldContext.NativePtr : IntPtr.Zero, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, fstring, fstring2, (Context ?? new FKuroEffectContext()).NativePtr, bAutoPlay, bIsExternalActor, EffectType);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06006227 RID: 25127 RVA: 0x0008C8E8 File Offset: 0x0008AAE8
		public unsafe static int SpawnEffectFromSkeletalContext(UObject WorldContext, in FTransformDouble Transform, [Nullable(1)] string Path, [Nullable(1)] string Reason, in FKuroSkeletalMeshEffectContext Context, in FKuroEffectBeforeInitCallback BeforeInitCallback, in FKuroEffectInitCallback Callback, in FKuroEffectBeforePlayCallback BeforePlayCallback, in FKuroEffectOnClearCallback OnClearCallback, byte EffectType = 3, bool bPrepare = false, bool bForceCreateActor = false)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = Transform;
			FString fstring = FString.AllocTemp(Path);
			FString fstring2 = FString.AllocTemp(Reason);
			IntPtr worldContext = (WorldContext != null) ? WorldContext.NativePtr : IntPtr.Zero;
			ref FTransformDouble transform = ref ptr;
			IntPtr nativePtr = (Context ?? new FKuroSkeletalMeshEffectContext()).NativePtr;
			FKuroEffectBeforeInitCallback fkuroEffectBeforeInitCallback = BeforeInitCallback;
			IntPtr beforeInitCallback = (fkuroEffectBeforeInitCallback != null) ? fkuroEffectBeforeInitCallback.NativePtr : ((IntPtr)0);
			FKuroEffectInitCallback fkuroEffectInitCallback = Callback;
			IntPtr callback = (fkuroEffectInitCallback != null) ? fkuroEffectInitCallback.NativePtr : ((IntPtr)0);
			FKuroEffectBeforePlayCallback fkuroEffectBeforePlayCallback = BeforePlayCallback;
			IntPtr beforePlayCallback = (fkuroEffectBeforePlayCallback != null) ? fkuroEffectBeforePlayCallback.NativePtr : ((IntPtr)0);
			FKuroEffectOnClearCallback fkuroEffectOnClearCallback = OnClearCallback;
			int result = UKuroEffectSystemFunctionLibrary.__SpawnEffectFromSkeletalContext_Internal(worldContext, transform, fstring, fstring2, nativePtr, beforeInitCallback, callback, beforePlayCallback, (fkuroEffectOnClearCallback != null) ? fkuroEffectOnClearCallback.NativePtr : ((IntPtr)0), EffectType, bPrepare, bForceCreateActor);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06006228 RID: 25128 RVA: 0x0008C9A4 File Offset: 0x0008ABA4
		public unsafe static int SpawnEffectFromGhostContext(UObject WorldContext, in FTransformDouble Transform, [Nullable(1)] string Path, [Nullable(1)] string Reason, in FKuroEffectRuntimeGhostEffectContext Context, in FKuroEffectBeforeInitCallback BeforeInitCallback, in FKuroEffectInitCallback Callback, in FKuroEffectBeforePlayCallback BeforePlayCallback, in FKuroEffectOnClearCallback OnClearCallback, byte EffectType = 3, bool bPrepare = false, bool bForceCreateActor = false)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = Transform;
			FString fstring = FString.AllocTemp(Path);
			FString fstring2 = FString.AllocTemp(Reason);
			IntPtr worldContext = (WorldContext != null) ? WorldContext.NativePtr : IntPtr.Zero;
			ref FTransformDouble transform = ref ptr;
			IntPtr nativePtr = (Context ?? new FKuroEffectRuntimeGhostEffectContext()).NativePtr;
			FKuroEffectBeforeInitCallback fkuroEffectBeforeInitCallback = BeforeInitCallback;
			IntPtr beforeInitCallback = (fkuroEffectBeforeInitCallback != null) ? fkuroEffectBeforeInitCallback.NativePtr : ((IntPtr)0);
			FKuroEffectInitCallback fkuroEffectInitCallback = Callback;
			IntPtr callback = (fkuroEffectInitCallback != null) ? fkuroEffectInitCallback.NativePtr : ((IntPtr)0);
			FKuroEffectBeforePlayCallback fkuroEffectBeforePlayCallback = BeforePlayCallback;
			IntPtr beforePlayCallback = (fkuroEffectBeforePlayCallback != null) ? fkuroEffectBeforePlayCallback.NativePtr : ((IntPtr)0);
			FKuroEffectOnClearCallback fkuroEffectOnClearCallback = OnClearCallback;
			int result = UKuroEffectSystemFunctionLibrary.__SpawnEffectFromGhostContext_Internal(worldContext, transform, fstring, fstring2, nativePtr, beforeInitCallback, callback, beforePlayCallback, (fkuroEffectOnClearCallback != null) ? fkuroEffectOnClearCallback.NativePtr : ((IntPtr)0), EffectType, bPrepare, bForceCreateActor);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06006229 RID: 25129 RVA: 0x0008CA60 File Offset: 0x0008AC60
		public unsafe static int SpawnEffectFromAudioContext(UObject WorldContext, in FTransformDouble Transform, [Nullable(1)] string Path, [Nullable(1)] string Reason, in FKuroEffectAudioContext Context, in FKuroEffectBeforeInitCallback BeforeInitCallback, in FKuroEffectInitCallback Callback, in FKuroEffectBeforePlayCallback BeforePlayCallback, in FKuroEffectOnClearCallback OnClearCallback, byte EffectType = 3, bool bPrepare = false, bool bForceCreateActor = false)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = Transform;
			FString fstring = FString.AllocTemp(Path);
			FString fstring2 = FString.AllocTemp(Reason);
			IntPtr worldContext = (WorldContext != null) ? WorldContext.NativePtr : IntPtr.Zero;
			ref FTransformDouble transform = ref ptr;
			IntPtr nativePtr = (Context ?? new FKuroEffectAudioContext()).NativePtr;
			FKuroEffectBeforeInitCallback fkuroEffectBeforeInitCallback = BeforeInitCallback;
			IntPtr beforeInitCallback = (fkuroEffectBeforeInitCallback != null) ? fkuroEffectBeforeInitCallback.NativePtr : ((IntPtr)0);
			FKuroEffectInitCallback fkuroEffectInitCallback = Callback;
			IntPtr callback = (fkuroEffectInitCallback != null) ? fkuroEffectInitCallback.NativePtr : ((IntPtr)0);
			FKuroEffectBeforePlayCallback fkuroEffectBeforePlayCallback = BeforePlayCallback;
			IntPtr beforePlayCallback = (fkuroEffectBeforePlayCallback != null) ? fkuroEffectBeforePlayCallback.NativePtr : ((IntPtr)0);
			FKuroEffectOnClearCallback fkuroEffectOnClearCallback = OnClearCallback;
			int result = UKuroEffectSystemFunctionLibrary.__SpawnEffectFromAudioContext_Internal(worldContext, transform, fstring, fstring2, nativePtr, beforeInitCallback, callback, beforePlayCallback, (fkuroEffectOnClearCallback != null) ? fkuroEffectOnClearCallback.NativePtr : ((IntPtr)0), EffectType, bPrepare, bForceCreateActor);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0600622A RID: 25130 RVA: 0x0008CB1C File Offset: 0x0008AD1C
		public unsafe static int SpawnEffect(UObject WorldContext, in FTransformDouble Transform, [Nullable(1)] string Path, [Nullable(1)] string Reason, in FKuroEffectContext Context, in FKuroEffectBeforeInitCallback BeforeInitCallback, in FKuroEffectInitCallback Callback, in FKuroEffectBeforePlayCallback BeforePlayCallback, in FKuroEffectOnClearCallback OnClearCallback, byte EffectType = 3, bool bPrepare = false, bool bForceCreateActor = false)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = Transform;
			FString fstring = FString.AllocTemp(Path);
			FString fstring2 = FString.AllocTemp(Reason);
			IntPtr worldContext = (WorldContext != null) ? WorldContext.NativePtr : IntPtr.Zero;
			ref FTransformDouble transform = ref ptr;
			IntPtr nativePtr = (Context ?? new FKuroEffectContext()).NativePtr;
			FKuroEffectBeforeInitCallback fkuroEffectBeforeInitCallback = BeforeInitCallback;
			IntPtr beforeInitCallback = (fkuroEffectBeforeInitCallback != null) ? fkuroEffectBeforeInitCallback.NativePtr : ((IntPtr)0);
			FKuroEffectInitCallback fkuroEffectInitCallback = Callback;
			IntPtr callback = (fkuroEffectInitCallback != null) ? fkuroEffectInitCallback.NativePtr : ((IntPtr)0);
			FKuroEffectBeforePlayCallback fkuroEffectBeforePlayCallback = BeforePlayCallback;
			IntPtr beforePlayCallback = (fkuroEffectBeforePlayCallback != null) ? fkuroEffectBeforePlayCallback.NativePtr : ((IntPtr)0);
			FKuroEffectOnClearCallback fkuroEffectOnClearCallback = OnClearCallback;
			int result = UKuroEffectSystemFunctionLibrary.__SpawnEffect_Internal(worldContext, transform, fstring, fstring2, nativePtr, beforeInitCallback, callback, beforePlayCallback, (fkuroEffectOnClearCallback != null) ? fkuroEffectOnClearCallback.NativePtr : ((IntPtr)0), EffectType, bPrepare, bForceCreateActor);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0600622B RID: 25131
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetUseDebugDrawNew(bool bUseDebugDrawNew);

		// Token: 0x0600622C RID: 25132
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetTimeScale(int Id, float TimeScale, bool bIgnoreGlobalTimeScale = false);

		// Token: 0x0600622D RID: 25133
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetThreeStageTime(int Id, float StartTime, float LoopTime, float EndTime, bool bResetPassTime);

		// Token: 0x0600622E RID: 25134
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetHandleLifeCycle(int Id, float Time);

		// Token: 0x0600622F RID: 25135
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetGlobalTimeScale(float InGlobalTimeScale);

		// Token: 0x06006230 RID: 25136
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetGlobalStoppingTime(bool bStoppingTime, float PlayTime, int Source = 1);

		// Token: 0x06006231 RID: 25137
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetEntityUltraSkillState(int EntityId, bool InUltraSkill);

		// Token: 0x06006232 RID: 25138
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetEffectStoppingTimeFromEntity(int EntityId, bool bStoppingTime, int Source = 1);

		// Token: 0x06006233 RID: 25139
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetEffectStoppingTime(int EffectId, bool bStoppingTime, int Source = 1);

		// Token: 0x06006234 RID: 25140
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetEffectQualityLevel(int Id, int QualityLevel);

		// Token: 0x06006235 RID: 25141 RVA: 0x0008CBD6 File Offset: 0x0008ADD6
		public static void SetEffectParameterNiagara(int Id, in FKuroEffectNiagaraParametersStruct Parameter)
		{
			UKuroEffectSystemFunctionLibrary.__SetEffectParameterNiagara_Internal(Id, (Parameter ?? new FKuroEffectNiagaraParametersStruct()).NativePtr);
		}

		// Token: 0x06006236 RID: 25142
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetEffectLruCapacity(int Capacity);

		// Token: 0x06006237 RID: 25143
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetEffectIgnoreVisibilityOptimize(int EffectId, bool bIgnore);

		// Token: 0x06006238 RID: 25144 RVA: 0x0008CBF0 File Offset: 0x0008ADF0
		[NullableContext(1)]
		public unsafe static void SetEffectHidden(int Handle, bool bHidden, string Reason, bool bIsLogic = false)
		{
			FString fstring = FString.AllocTemp(Reason);
			UKuroEffectSystemFunctionLibrary.__SetEffectHidden_Internal(Handle, bHidden, fstring, bIsLogic);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06006239 RID: 25145
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetEffectExtraState(int EffectId, int ExtraState);

		// Token: 0x0600623A RID: 25146
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetEffectDataFloatConstParam(int Id, FName ParamName, float Value);

		// Token: 0x0600623B RID: 25147
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetAdditionTimeScaleEnable(int SourceType, bool Enable);

		// Token: 0x0600623C RID: 25148
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetAdditionTimeScale(int SourceType, int Id, float TimeScale);

		// Token: 0x0600623D RID: 25149 RVA: 0x0008CC18 File Offset: 0x0008AE18
		[NullableContext(1)]
		public unsafe static void ReplayEffect(int Id, string Reason, in FTransformDouble Transform, bool bResetTransform = false)
		{
			FString fstring = FString.AllocTemp(Reason);
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = Transform;
			UKuroEffectSystemFunctionLibrary.__ReplayEffect_Internal(Id, fstring, ptr, bResetTransform);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600623E RID: 25150
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RemoveFinishCallback(int Id);

		// Token: 0x0600623F RID: 25151 RVA: 0x0008CC5C File Offset: 0x0008AE5C
		public static void RegisterJsFunction(in FSkeletalMeshSpecOnBodyEffectChangeRetVal InSkeletalMeshSpec_OnBodyEffectChange, in FSkeletalMeshSpecCreateRenderCompRetVal InSkeletalMeshSpec_CreateRenderingComponent, in FSkeletalMeshSpecDestroyRenderingComponent InSkeletalMeshSpec_DestroyRenderingComponent, in FEffectHandleGetEntityOwnerActorRetVal InEffectHandle_GetEntityOwnerActor, in FEffectHandleGetEntityModelConfigIdRetVal InEffectHandle_GetEntityModelConfigId, in FEffectHandleGetOrAddEffectDynamicGroupRetVal InEffectHandle_GetOrAddEffectDynamicGroup, in FAudioSystemGetAkComponentRetVal InAudioSystem_GetAkComponent, in FAudioSystemExecuteActionStop InAudioSystem_ExecuteActionStop, in FAudioSystemPostEventTransformRetVal InAudioSystem_PostEventTransform, in FAudioSystemPostEventAkComponentRetVal InAudioSystem_PostEventAkComponent, in FNiagaraSpecIsNeedQualityBiasRetVal InNiagaraSpec_IsNeedQualityBias, in FPostProcessSpecIsNeedPostEffectRetVal InPostProcessSpec_IsNeedPostEffect, in FPostProcessSpecIsDisableInUltraSkillRetVal InPostProcessSpec_IsDisableInUltraSkill, in FActorSystemGetRetVal InActorSystem_Get, in FActorSystemPutRetVal InActorSystem_Put, in FEffectSystemSetEffectView InEffectSystem_SetEffectView, in FEffectSystemCheckIsNetPlayerRetVal InEffectSystem_CheckIsNetPlayer, in FEffectSystemCheckMobileBlackEffectRetVal InEffectSystem_CheckMobileBlackEffect, in FEffectSpecRegisterBodyEffect InEffectSpec_RegisterBodyEffect, in FEffectSpecUnregisterBodyEffect InEffectSpec_UnregisterBodyEffect, in FMaterialSpecGetRenderingComponentByContextRetVal InMaterialSpec_GetRenderingComponentByContext, in FMaterialSpecGetRenderingComponentBySkeletalRetVal InMaterialSpec_GetRenderingComponentBySkeletal, in FMaterialSpecSpawnRenderActorRetVal InMaterialSpec_SpawnRenderActor, in FMaterialSpecGetRenderingComponentByRenderActorRetVal InMaterialSpec_GetRenderingComponentByRenderActor, in FMaterialSpecAddMaterialControllerDataRetVal InMaterialSpec_AddMaterialControllerData, in FMaterialSpecRemoveMaterialControllerData InMaterialSpec_RemoveMaterialControllerData, in FMaterialSpecDestroyRenderingComponent InMaterialSpec_DestroyRenderingComponent, in FEffectAudioControllerAddPlayEffectAudioRetVal InEffectAudioController_AddPlayEffectAudio, in FEffectAudioControllerAddPlayEffectAudioPriorityRetVal InEffectAudioController_AddPlayEffectAudioPriority, in FEffectAudioControllerOnStopEffectAudio InEffectAudioController_OnStopEffectAudio)
		{
			FSkeletalMeshSpecOnBodyEffectChangeRetVal fskeletalMeshSpecOnBodyEffectChangeRetVal = InSkeletalMeshSpec_OnBodyEffectChange;
			IntPtr inSkeletalMeshSpec_OnBodyEffectChange = (fskeletalMeshSpecOnBodyEffectChangeRetVal != null) ? fskeletalMeshSpecOnBodyEffectChangeRetVal.NativePtr : ((IntPtr)0);
			FSkeletalMeshSpecCreateRenderCompRetVal fskeletalMeshSpecCreateRenderCompRetVal = InSkeletalMeshSpec_CreateRenderingComponent;
			IntPtr inSkeletalMeshSpec_CreateRenderingComponent = (fskeletalMeshSpecCreateRenderCompRetVal != null) ? fskeletalMeshSpecCreateRenderCompRetVal.NativePtr : ((IntPtr)0);
			FSkeletalMeshSpecDestroyRenderingComponent fskeletalMeshSpecDestroyRenderingComponent = InSkeletalMeshSpec_DestroyRenderingComponent;
			IntPtr inSkeletalMeshSpec_DestroyRenderingComponent = (fskeletalMeshSpecDestroyRenderingComponent != null) ? fskeletalMeshSpecDestroyRenderingComponent.NativePtr : ((IntPtr)0);
			FEffectHandleGetEntityOwnerActorRetVal feffectHandleGetEntityOwnerActorRetVal = InEffectHandle_GetEntityOwnerActor;
			IntPtr inEffectHandle_GetEntityOwnerActor = (feffectHandleGetEntityOwnerActorRetVal != null) ? feffectHandleGetEntityOwnerActorRetVal.NativePtr : ((IntPtr)0);
			FEffectHandleGetEntityModelConfigIdRetVal feffectHandleGetEntityModelConfigIdRetVal = InEffectHandle_GetEntityModelConfigId;
			IntPtr inEffectHandle_GetEntityModelConfigId = (feffectHandleGetEntityModelConfigIdRetVal != null) ? feffectHandleGetEntityModelConfigIdRetVal.NativePtr : ((IntPtr)0);
			FEffectHandleGetOrAddEffectDynamicGroupRetVal feffectHandleGetOrAddEffectDynamicGroupRetVal = InEffectHandle_GetOrAddEffectDynamicGroup;
			IntPtr inEffectHandle_GetOrAddEffectDynamicGroup = (feffectHandleGetOrAddEffectDynamicGroupRetVal != null) ? feffectHandleGetOrAddEffectDynamicGroupRetVal.NativePtr : ((IntPtr)0);
			FAudioSystemGetAkComponentRetVal faudioSystemGetAkComponentRetVal = InAudioSystem_GetAkComponent;
			IntPtr inAudioSystem_GetAkComponent = (faudioSystemGetAkComponentRetVal != null) ? faudioSystemGetAkComponentRetVal.NativePtr : ((IntPtr)0);
			FAudioSystemExecuteActionStop faudioSystemExecuteActionStop = InAudioSystem_ExecuteActionStop;
			IntPtr inAudioSystem_ExecuteActionStop = (faudioSystemExecuteActionStop != null) ? faudioSystemExecuteActionStop.NativePtr : ((IntPtr)0);
			FAudioSystemPostEventTransformRetVal faudioSystemPostEventTransformRetVal = InAudioSystem_PostEventTransform;
			IntPtr inAudioSystem_PostEventTransform = (faudioSystemPostEventTransformRetVal != null) ? faudioSystemPostEventTransformRetVal.NativePtr : ((IntPtr)0);
			FAudioSystemPostEventAkComponentRetVal faudioSystemPostEventAkComponentRetVal = InAudioSystem_PostEventAkComponent;
			IntPtr inAudioSystem_PostEventAkComponent = (faudioSystemPostEventAkComponentRetVal != null) ? faudioSystemPostEventAkComponentRetVal.NativePtr : ((IntPtr)0);
			FNiagaraSpecIsNeedQualityBiasRetVal fniagaraSpecIsNeedQualityBiasRetVal = InNiagaraSpec_IsNeedQualityBias;
			IntPtr inNiagaraSpec_IsNeedQualityBias = (fniagaraSpecIsNeedQualityBiasRetVal != null) ? fniagaraSpecIsNeedQualityBiasRetVal.NativePtr : ((IntPtr)0);
			FPostProcessSpecIsNeedPostEffectRetVal fpostProcessSpecIsNeedPostEffectRetVal = InPostProcessSpec_IsNeedPostEffect;
			IntPtr inPostProcessSpec_IsNeedPostEffect = (fpostProcessSpecIsNeedPostEffectRetVal != null) ? fpostProcessSpecIsNeedPostEffectRetVal.NativePtr : ((IntPtr)0);
			FPostProcessSpecIsDisableInUltraSkillRetVal fpostProcessSpecIsDisableInUltraSkillRetVal = InPostProcessSpec_IsDisableInUltraSkill;
			IntPtr inPostProcessSpec_IsDisableInUltraSkill = (fpostProcessSpecIsDisableInUltraSkillRetVal != null) ? fpostProcessSpecIsDisableInUltraSkillRetVal.NativePtr : ((IntPtr)0);
			FActorSystemGetRetVal factorSystemGetRetVal = InActorSystem_Get;
			IntPtr inActorSystem_Get = (factorSystemGetRetVal != null) ? factorSystemGetRetVal.NativePtr : ((IntPtr)0);
			FActorSystemPutRetVal factorSystemPutRetVal = InActorSystem_Put;
			IntPtr inActorSystem_Put = (factorSystemPutRetVal != null) ? factorSystemPutRetVal.NativePtr : ((IntPtr)0);
			FEffectSystemSetEffectView feffectSystemSetEffectView = InEffectSystem_SetEffectView;
			IntPtr inEffectSystem_SetEffectView = (feffectSystemSetEffectView != null) ? feffectSystemSetEffectView.NativePtr : ((IntPtr)0);
			FEffectSystemCheckIsNetPlayerRetVal feffectSystemCheckIsNetPlayerRetVal = InEffectSystem_CheckIsNetPlayer;
			IntPtr inEffectSystem_CheckIsNetPlayer = (feffectSystemCheckIsNetPlayerRetVal != null) ? feffectSystemCheckIsNetPlayerRetVal.NativePtr : ((IntPtr)0);
			FEffectSystemCheckMobileBlackEffectRetVal feffectSystemCheckMobileBlackEffectRetVal = InEffectSystem_CheckMobileBlackEffect;
			IntPtr inEffectSystem_CheckMobileBlackEffect = (feffectSystemCheckMobileBlackEffectRetVal != null) ? feffectSystemCheckMobileBlackEffectRetVal.NativePtr : ((IntPtr)0);
			FEffectSpecRegisterBodyEffect feffectSpecRegisterBodyEffect = InEffectSpec_RegisterBodyEffect;
			IntPtr inEffectSpec_RegisterBodyEffect = (feffectSpecRegisterBodyEffect != null) ? feffectSpecRegisterBodyEffect.NativePtr : ((IntPtr)0);
			FEffectSpecUnregisterBodyEffect feffectSpecUnregisterBodyEffect = InEffectSpec_UnregisterBodyEffect;
			IntPtr inEffectSpec_UnregisterBodyEffect = (feffectSpecUnregisterBodyEffect != null) ? feffectSpecUnregisterBodyEffect.NativePtr : ((IntPtr)0);
			FMaterialSpecGetRenderingComponentByContextRetVal fmaterialSpecGetRenderingComponentByContextRetVal = InMaterialSpec_GetRenderingComponentByContext;
			IntPtr inMaterialSpec_GetRenderingComponentByContext = (fmaterialSpecGetRenderingComponentByContextRetVal != null) ? fmaterialSpecGetRenderingComponentByContextRetVal.NativePtr : ((IntPtr)0);
			FMaterialSpecGetRenderingComponentBySkeletalRetVal fmaterialSpecGetRenderingComponentBySkeletalRetVal = InMaterialSpec_GetRenderingComponentBySkeletal;
			IntPtr inMaterialSpec_GetRenderingComponentBySkeletal = (fmaterialSpecGetRenderingComponentBySkeletalRetVal != null) ? fmaterialSpecGetRenderingComponentBySkeletalRetVal.NativePtr : ((IntPtr)0);
			FMaterialSpecSpawnRenderActorRetVal fmaterialSpecSpawnRenderActorRetVal = InMaterialSpec_SpawnRenderActor;
			IntPtr inMaterialSpec_SpawnRenderActor = (fmaterialSpecSpawnRenderActorRetVal != null) ? fmaterialSpecSpawnRenderActorRetVal.NativePtr : ((IntPtr)0);
			FMaterialSpecGetRenderingComponentByRenderActorRetVal fmaterialSpecGetRenderingComponentByRenderActorRetVal = InMaterialSpec_GetRenderingComponentByRenderActor;
			IntPtr inMaterialSpec_GetRenderingComponentByRenderActor = (fmaterialSpecGetRenderingComponentByRenderActorRetVal != null) ? fmaterialSpecGetRenderingComponentByRenderActorRetVal.NativePtr : ((IntPtr)0);
			FMaterialSpecAddMaterialControllerDataRetVal fmaterialSpecAddMaterialControllerDataRetVal = InMaterialSpec_AddMaterialControllerData;
			IntPtr inMaterialSpec_AddMaterialControllerData = (fmaterialSpecAddMaterialControllerDataRetVal != null) ? fmaterialSpecAddMaterialControllerDataRetVal.NativePtr : ((IntPtr)0);
			FMaterialSpecRemoveMaterialControllerData fmaterialSpecRemoveMaterialControllerData = InMaterialSpec_RemoveMaterialControllerData;
			IntPtr inMaterialSpec_RemoveMaterialControllerData = (fmaterialSpecRemoveMaterialControllerData != null) ? fmaterialSpecRemoveMaterialControllerData.NativePtr : ((IntPtr)0);
			FMaterialSpecDestroyRenderingComponent fmaterialSpecDestroyRenderingComponent = InMaterialSpec_DestroyRenderingComponent;
			IntPtr inMaterialSpec_DestroyRenderingComponent = (fmaterialSpecDestroyRenderingComponent != null) ? fmaterialSpecDestroyRenderingComponent.NativePtr : ((IntPtr)0);
			FEffectAudioControllerAddPlayEffectAudioRetVal feffectAudioControllerAddPlayEffectAudioRetVal = InEffectAudioController_AddPlayEffectAudio;
			IntPtr inEffectAudioController_AddPlayEffectAudio = (feffectAudioControllerAddPlayEffectAudioRetVal != null) ? feffectAudioControllerAddPlayEffectAudioRetVal.NativePtr : ((IntPtr)0);
			FEffectAudioControllerAddPlayEffectAudioPriorityRetVal feffectAudioControllerAddPlayEffectAudioPriorityRetVal = InEffectAudioController_AddPlayEffectAudioPriority;
			IntPtr inEffectAudioController_AddPlayEffectAudioPriority = (feffectAudioControllerAddPlayEffectAudioPriorityRetVal != null) ? feffectAudioControllerAddPlayEffectAudioPriorityRetVal.NativePtr : ((IntPtr)0);
			FEffectAudioControllerOnStopEffectAudio feffectAudioControllerOnStopEffectAudio = InEffectAudioController_OnStopEffectAudio;
			UKuroEffectSystemFunctionLibrary.__RegisterJsFunction_Internal(inSkeletalMeshSpec_OnBodyEffectChange, inSkeletalMeshSpec_CreateRenderingComponent, inSkeletalMeshSpec_DestroyRenderingComponent, inEffectHandle_GetEntityOwnerActor, inEffectHandle_GetEntityModelConfigId, inEffectHandle_GetOrAddEffectDynamicGroup, inAudioSystem_GetAkComponent, inAudioSystem_ExecuteActionStop, inAudioSystem_PostEventTransform, inAudioSystem_PostEventAkComponent, inNiagaraSpec_IsNeedQualityBias, inPostProcessSpec_IsNeedPostEffect, inPostProcessSpec_IsDisableInUltraSkill, inActorSystem_Get, inActorSystem_Put, inEffectSystem_SetEffectView, inEffectSystem_CheckIsNetPlayer, inEffectSystem_CheckMobileBlackEffect, inEffectSpec_RegisterBodyEffect, inEffectSpec_UnregisterBodyEffect, inMaterialSpec_GetRenderingComponentByContext, inMaterialSpec_GetRenderingComponentBySkeletal, inMaterialSpec_SpawnRenderActor, inMaterialSpec_GetRenderingComponentByRenderActor, inMaterialSpec_AddMaterialControllerData, inMaterialSpec_RemoveMaterialControllerData, inMaterialSpec_DestroyRenderingComponent, inEffectAudioController_AddPlayEffectAudio, inEffectAudioController_AddPlayEffectAudioPriority, (feffectAudioControllerOnStopEffectAudio != null) ? feffectAudioControllerOnStopEffectAudio.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06006240 RID: 25152 RVA: 0x0008CE4A File Offset: 0x0008B04A
		public static void RefreshEffectForSpecData([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FKuroEffectSpecData> SpecDataArray, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FKuroEffectSpecChildData> SpecChildDataArray, bool IsRefresh)
		{
			UKuroEffectSystemFunctionLibrary.__RefreshEffectForSpecData_Internal((SpecDataArray ?? new TArray<FKuroEffectSpecData>()).NativePtr, (SpecChildDataArray ?? new TArray<FKuroEffectSpecChildData>()).NativePtr, IsRefresh);
		}

		// Token: 0x06006241 RID: 25153
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void OnUiSceneStateChange(EKuroUI3DState UiSceneState);

		// Token: 0x06006242 RID: 25154
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void OnTickSystemPausedChange(bool bIsPaused);

		// Token: 0x06006243 RID: 25155 RVA: 0x0008CE72 File Offset: 0x0008B072
		public static void OnPlayerEffectContainerFormationLoaded(in TArray<FKuroSceneTeamItem> SceneTeamItems)
		{
			UKuroEffectSystemFunctionLibrary.__OnPlayerEffectContainerFormationLoaded_Internal((SceneTeamItems ?? new TArray<FKuroSceneTeamItem>()).NativePtr);
		}

		// Token: 0x06006244 RID: 25156
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void OnIsInEditorTickChange(bool bIsInEditorTick);

		// Token: 0x06006245 RID: 25157
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void OnGlobalTimeScaleChange();

		// Token: 0x06006246 RID: 25158
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void OnEffectQualityBiasRemoteChange(float EffectQualityBiasRemote);

		// Token: 0x06006247 RID: 25159
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void OnDisableOtherEffectChange(bool bDisableOtherEffect);

		// Token: 0x06006248 RID: 25160
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsPlaying(int Id);

		// Token: 0x06006249 RID: 25161
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsHandleFreeze(int Id);

		// Token: 0x0600624A RID: 25162
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsEntityInUltraSkill(int EntityId);

		// Token: 0x0600624B RID: 25163
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsEffectValid(int Id);

		// Token: 0x0600624C RID: 25164
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsEffectSpecDataContainsType(in FName EffectPath, byte Type);

		// Token: 0x0600624D RID: 25165
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsEffectActorValid(int Id);

		// Token: 0x0600624E RID: 25166
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void InitStaticGlobalData(bool bUseLog, bool bIsInEditorTick, bool bUseDbConfig);

		// Token: 0x0600624F RID: 25167 RVA: 0x0008CE8C File Offset: 0x0008B08C
		public static bool Initialize(UGameInstance GameInstance, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FKuroEffectSpecData> SpecDataArray, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FKuroEffectSpecChildData> SpecChildDataArray, bool InIsGameRunning, float InBoundsVisibleThreshold, float InMaxVisibleCullDeltaTime, float InWasRecentlyRenderInterval, bool InUseVisibilityTestPass, UClassStackOnlyPtr EffectViewClass, bool IsResetSpecData)
		{
			return UKuroEffectSystemFunctionLibrary.__Initialize_Internal((GameInstance != null) ? GameInstance.NativePtr : IntPtr.Zero, (SpecDataArray ?? new TArray<FKuroEffectSpecData>()).NativePtr, (SpecChildDataArray ?? new TArray<FKuroEffectSpecChildData>()).NativePtr, InIsGameRunning, InBoundsVisibleThreshold, InMaxVisibleCullDeltaTime, InWasRecentlyRenderInterval, InUseVisibilityTestPass, EffectViewClass._NativePtr, IsResetSpecData);
		}

		// Token: 0x06006250 RID: 25168
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasNiagaraComponentHandle(int Id);

		// Token: 0x06006251 RID: 25169
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasInitialize();

		// Token: 0x06006252 RID: 25170
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasEffectForSpecData();

		// Token: 0x06006253 RID: 25171
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void HandleSeekToTimeWithProcess(int Id, float Time, bool bSeekContinue = false, float Delta = -1f);

		// Token: 0x06006254 RID: 25172
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HandleSeekToTime(int Id, float Time, bool bAutoLoop, bool bForce = false);

		// Token: 0x06006255 RID: 25173
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GlobalStoppingTime(int Source = 1);

		// Token: 0x06006256 RID: 25174
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GlobalStoppingPlayTime(int Source = 1);

		// Token: 0x06006257 RID: 25175
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetTotalPassTime(int Id);

		// Token: 0x06006258 RID: 25176 RVA: 0x0008CEE0 File Offset: 0x0008B0E0
		public static UNiagaraComponent GetSureNiagaraComponent(int Id)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UNiagaraComponent>(UKuroEffectSystemFunctionLibrary.__GetSureNiagaraComponent_Internal(Id));
		}

		// Token: 0x06006259 RID: 25177 RVA: 0x0008CEED File Offset: 0x0008B0ED
		public static AActor GetSureEffectActor(int Id)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UKuroEffectSystemFunctionLibrary.__GetSureEffectActor_Internal(Id));
		}

		// Token: 0x0600625A RID: 25178
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetSeekToTargetTime(int Id);

		// Token: 0x0600625B RID: 25179
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetPlayerEffectLruSize(int Pos);

		// Token: 0x0600625C RID: 25180 RVA: 0x0008CEFA File Offset: 0x0008B0FA
		[NullableContext(1)]
		public static string GetPath(int Id)
		{
			return FString.ToStringAndDeleteNativePtr(UKuroEffectSystemFunctionLibrary.__GetPath_Internal(Id));
		}

		// Token: 0x0600625D RID: 25181
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetPassTime(int Id);

		// Token: 0x0600625E RID: 25182
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetLastStopTime(int Id);

		// Token: 0x0600625F RID: 25183
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetLastPlayTime(int Id);

		// Token: 0x06006260 RID: 25184
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern byte GetEffectSpecDataType(in FName EffectPath);

		// Token: 0x06006261 RID: 25185 RVA: 0x0008CF07 File Offset: 0x0008B107
		public static UEffectModelBase GetEffectModel(int Id)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UEffectModelBase>(UKuroEffectSystemFunctionLibrary.__GetEffectModel_Internal(Id));
		}

		// Token: 0x06006262 RID: 25186
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetEffectLruSize();

		// Token: 0x06006263 RID: 25187 RVA: 0x0008CF14 File Offset: 0x0008B114
		[NullableContext(1)]
		public unsafe static int GetEffectLruCount(string Path)
		{
			FString fstring = FString.AllocTemp(Path);
			int result = UKuroEffectSystemFunctionLibrary.__GetEffectLruCount_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06006264 RID: 25188
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetEffectLruCapacity();

		// Token: 0x06006265 RID: 25189
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetEffectCount();

		// Token: 0x06006266 RID: 25190
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetAdditionTimeScaleEnable(int SourceType);

		// Token: 0x06006267 RID: 25191
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetActiveEffectCount();

		// Token: 0x06006268 RID: 25192
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FreezeHandle(int Id, bool bFreeze, bool bForce = false);

		// Token: 0x06006269 RID: 25193
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ForceCheckPendingInit(int Handle);

		// Token: 0x0600626A RID: 25194
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool EffectIsLoop(int Id);

		// Token: 0x0600626B RID: 25195 RVA: 0x0008CF38 File Offset: 0x0008B138
		public static void DynamicRegisterSpawnCallback(int EffectId, in FKuroEffectInitCallback Callback, in FKuroEffectOnClearCallback OnClearCallback)
		{
			FKuroEffectInitCallback fkuroEffectInitCallback = Callback;
			IntPtr callback = (fkuroEffectInitCallback != null) ? fkuroEffectInitCallback.NativePtr : ((IntPtr)0);
			FKuroEffectOnClearCallback fkuroEffectOnClearCallback = OnClearCallback;
			UKuroEffectSystemFunctionLibrary.__DynamicRegisterSpawnCallback_Internal(EffectId, callback, (fkuroEffectOnClearCallback != null) ? fkuroEffectOnClearCallback.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0600626C RID: 25196
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DebugUpdate(int Id, bool bDebugUpdate);

		// Token: 0x0600626D RID: 25197
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DebugPrintEffect();

		// Token: 0x0600626E RID: 25198
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DebugPrintCurrentImportanceEffects();

		// Token: 0x0600626F RID: 25199
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DebugPrintAllErrorEffects();

		// Token: 0x06006270 RID: 25200 RVA: 0x0008CF5E File Offset: 0x0008B15E
		public static void CollectMaterialVectorCurve(int Id, FName Key, in FKuroCurveVector Value)
		{
			UKuroEffectSystemFunctionLibrary.__CollectMaterialVectorCurve_Internal(Id, Key, (Value ?? new FKuroCurveVector()).NativePtr);
		}

		// Token: 0x06006271 RID: 25201 RVA: 0x0008CF77 File Offset: 0x0008B177
		public static void CollectMaterialLinearColorCurve(int Id, FName Key, in FKuroCurveLinearColor Value)
		{
			UKuroEffectSystemFunctionLibrary.__CollectMaterialLinearColorCurve_Internal(Id, Key, (Value ?? new FKuroCurveLinearColor()).NativePtr);
		}

		// Token: 0x06006272 RID: 25202 RVA: 0x0008CF90 File Offset: 0x0008B190
		public static void CollectMaterialFloatCurve(int Id, FName Key, in FKuroCurveFloat Value)
		{
			UKuroEffectSystemFunctionLibrary.__CollectMaterialFloatCurve_Internal(Id, Key, (Value ?? new FKuroCurveFloat()).NativePtr);
		}

		// Token: 0x06006273 RID: 25203
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ClearUltraSkillState();

		// Token: 0x06006274 RID: 25204
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ClearPool(bool IsInternal);

		// Token: 0x06006275 RID: 25205
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Clear();

		// Token: 0x06006276 RID: 25206 RVA: 0x0008CFA9 File Offset: 0x0008B1A9
		public static void AttachToEffectSkeletalMesh(int Id, AActor AttachActor, FName SocketName = default(FName), EAttachmentRule TransformRule = EAttachmentRule.KeepRelative)
		{
			UKuroEffectSystemFunctionLibrary.__AttachToEffectSkeletalMesh_Internal(Id, (AttachActor != null) ? AttachActor.NativePtr : IntPtr.Zero, SocketName, TransformRule);
		}

		// Token: 0x06006277 RID: 25207 RVA: 0x0008CFC3 File Offset: 0x0008B1C3
		public static void AttachSkeletalMesh(int Id, in FKuroSkeletalMeshEffectContext Context)
		{
			UKuroEffectSystemFunctionLibrary.__AttachSkeletalMesh_Internal(Id, (Context ?? new FKuroSkeletalMeshEffectContext()).NativePtr);
		}

		// Token: 0x06006278 RID: 25208 RVA: 0x0008CFDB File Offset: 0x0008B1DB
		public static void AddFinishCallback(int Id, in FKuroEffectFinishCallback Callback, in FKuroEffectOnClearCallback OnClearCallback)
		{
			FKuroEffectFinishCallback fkuroEffectFinishCallback = Callback;
			IntPtr callback = (fkuroEffectFinishCallback != null) ? fkuroEffectFinishCallback.NativePtr : ((IntPtr)0);
			FKuroEffectOnClearCallback fkuroEffectOnClearCallback = OnClearCallback;
			UKuroEffectSystemFunctionLibrary.__AddFinishCallback_Internal(Id, callback, (fkuroEffectOnClearCallback != null) ? fkuroEffectOnClearCallback.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06006279 RID: 25209
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __StopEffectById_Internal(int Handle, in FString Reason, bool Immediately, bool bDestroyActor);

		// Token: 0x0600627A RID: 25210
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __SpawnUnloopedEffectFromSkeletalContext_Internal(IntPtr WorldContext, in FTransformDouble Transform, in FString Path, in FString Reason, IntPtr Context, IntPtr BeforeInitCallback, IntPtr Callback, IntPtr BeforePlayCallback, IntPtr OnClearCallback, byte EffectType, bool bPrepare, bool bForceCreateActor);

		// Token: 0x0600627B RID: 25211
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __SpawnUnloopedEffectFromGhostContext_Internal(IntPtr WorldContext, in FTransformDouble Transform, in FString Path, in FString Reason, IntPtr Context, IntPtr BeforeInitCallback, IntPtr Callback, IntPtr BeforePlayCallback, IntPtr OnClearCallback, byte EffectType, bool bPrepare, bool bForceCreateActor);

		// Token: 0x0600627C RID: 25212
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __SpawnUnloopedEffectFromAudioContext_Internal(IntPtr WorldContext, in FTransformDouble Transform, in FString Path, in FString Reason, IntPtr Context, IntPtr BeforeInitCallback, IntPtr Callback, IntPtr BeforePlayCallback, IntPtr OnClearCallback, byte EffectType, bool bPrepare, bool bForceCreateActor);

		// Token: 0x0600627D RID: 25213
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __SpawnUnloopedEffect_Internal(IntPtr WorldContext, in FTransformDouble Transform, in FString Path, in FString Reason, IntPtr Context, IntPtr BeforeInitCallback, IntPtr Callback, IntPtr BeforePlayCallback, IntPtr OnClearCallback, byte EffectType, bool bPrepare, bool bForceCreateActor);

		// Token: 0x0600627E RID: 25214
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __SpawnEffectWithActorFromSkeletalContext_Internal(IntPtr WorldContext, IntPtr Actor, in FString Path, in FString Reason, IntPtr Context, bool bAutoPlay, bool bIsExternalActor, byte EffectType);

		// Token: 0x0600627F RID: 25215
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __SpawnEffectWithActorFromGhostContext_Internal(IntPtr WorldContext, IntPtr Actor, in FString Path, in FString Reason, IntPtr Context, bool bAutoPlay, bool bIsExternalActor, byte EffectType);

		// Token: 0x06006280 RID: 25216
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __SpawnEffectWithActorFromAudioContext_Internal(IntPtr WorldContext, IntPtr Actor, in FString Path, in FString Reason, IntPtr Context, bool bAutoPlay, bool bIsExternalActor, byte EffectType);

		// Token: 0x06006281 RID: 25217
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __SpawnEffectWithActor_Internal(IntPtr WorldContext, IntPtr Actor, in FString Path, in FString Reason, IntPtr Context, bool bAutoPlay, bool bIsExternalActor, byte EffectType);

		// Token: 0x06006282 RID: 25218
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __SpawnEffectFromSkeletalContext_Internal(IntPtr WorldContext, in FTransformDouble Transform, in FString Path, in FString Reason, IntPtr Context, IntPtr BeforeInitCallback, IntPtr Callback, IntPtr BeforePlayCallback, IntPtr OnClearCallback, byte EffectType, bool bPrepare, bool bForceCreateActor);

		// Token: 0x06006283 RID: 25219
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __SpawnEffectFromGhostContext_Internal(IntPtr WorldContext, in FTransformDouble Transform, in FString Path, in FString Reason, IntPtr Context, IntPtr BeforeInitCallback, IntPtr Callback, IntPtr BeforePlayCallback, IntPtr OnClearCallback, byte EffectType, bool bPrepare, bool bForceCreateActor);

		// Token: 0x06006284 RID: 25220
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __SpawnEffectFromAudioContext_Internal(IntPtr WorldContext, in FTransformDouble Transform, in FString Path, in FString Reason, IntPtr Context, IntPtr BeforeInitCallback, IntPtr Callback, IntPtr BeforePlayCallback, IntPtr OnClearCallback, byte EffectType, bool bPrepare, bool bForceCreateActor);

		// Token: 0x06006285 RID: 25221
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __SpawnEffect_Internal(IntPtr WorldContext, in FTransformDouble Transform, in FString Path, in FString Reason, IntPtr Context, IntPtr BeforeInitCallback, IntPtr Callback, IntPtr BeforePlayCallback, IntPtr OnClearCallback, byte EffectType, bool bPrepare, bool bForceCreateActor);

		// Token: 0x06006286 RID: 25222
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEffectParameterNiagara_Internal(int Id, IntPtr Parameter);

		// Token: 0x06006287 RID: 25223
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEffectHidden_Internal(int Handle, bool bHidden, in FString Reason, bool bIsLogic);

		// Token: 0x06006288 RID: 25224
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReplayEffect_Internal(int Id, in FString Reason, in FTransformDouble Transform, bool bResetTransform);

		// Token: 0x06006289 RID: 25225
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterJsFunction_Internal(IntPtr InSkeletalMeshSpec_OnBodyEffectChange, IntPtr InSkeletalMeshSpec_CreateRenderingComponent, IntPtr InSkeletalMeshSpec_DestroyRenderingComponent, IntPtr InEffectHandle_GetEntityOwnerActor, IntPtr InEffectHandle_GetEntityModelConfigId, IntPtr InEffectHandle_GetOrAddEffectDynamicGroup, IntPtr InAudioSystem_GetAkComponent, IntPtr InAudioSystem_ExecuteActionStop, IntPtr InAudioSystem_PostEventTransform, IntPtr InAudioSystem_PostEventAkComponent, IntPtr InNiagaraSpec_IsNeedQualityBias, IntPtr InPostProcessSpec_IsNeedPostEffect, IntPtr InPostProcessSpec_IsDisableInUltraSkill, IntPtr InActorSystem_Get, IntPtr InActorSystem_Put, IntPtr InEffectSystem_SetEffectView, IntPtr InEffectSystem_CheckIsNetPlayer, IntPtr InEffectSystem_CheckMobileBlackEffect, IntPtr InEffectSpec_RegisterBodyEffect, IntPtr InEffectSpec_UnregisterBodyEffect, IntPtr InMaterialSpec_GetRenderingComponentByContext, IntPtr InMaterialSpec_GetRenderingComponentBySkeletal, IntPtr InMaterialSpec_SpawnRenderActor, IntPtr InMaterialSpec_GetRenderingComponentByRenderActor, IntPtr InMaterialSpec_AddMaterialControllerData, IntPtr InMaterialSpec_RemoveMaterialControllerData, IntPtr InMaterialSpec_DestroyRenderingComponent, IntPtr InEffectAudioController_AddPlayEffectAudio, IntPtr InEffectAudioController_AddPlayEffectAudioPriority, IntPtr InEffectAudioController_OnStopEffectAudio);

		// Token: 0x0600628A RID: 25226
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RefreshEffectForSpecData_Internal(IntPtr SpecDataArray, IntPtr SpecChildDataArray, bool IsRefresh);

		// Token: 0x0600628B RID: 25227
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPlayerEffectContainerFormationLoaded_Internal(IntPtr SceneTeamItems);

		// Token: 0x0600628C RID: 25228
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Initialize_Internal(IntPtr GameInstance, IntPtr SpecDataArray, IntPtr SpecChildDataArray, bool InIsGameRunning, float InBoundsVisibleThreshold, float InMaxVisibleCullDeltaTime, float InWasRecentlyRenderInterval, bool InUseVisibilityTestPass, IntPtr EffectViewClass, bool IsResetSpecData);

		// Token: 0x0600628D RID: 25229
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSureNiagaraComponent_Internal(int Id);

		// Token: 0x0600628E RID: 25230
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSureEffectActor_Internal(int Id);

		// Token: 0x0600628F RID: 25231
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetPath_Internal(int Id);

		// Token: 0x06006290 RID: 25232
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetEffectModel_Internal(int Id);

		// Token: 0x06006291 RID: 25233
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetEffectLruCount_Internal(in FString Path);

		// Token: 0x06006292 RID: 25234
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DynamicRegisterSpawnCallback_Internal(int EffectId, IntPtr Callback, IntPtr OnClearCallback);

		// Token: 0x06006293 RID: 25235
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CollectMaterialVectorCurve_Internal(int Id, FName Key, IntPtr Value);

		// Token: 0x06006294 RID: 25236
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CollectMaterialLinearColorCurve_Internal(int Id, FName Key, IntPtr Value);

		// Token: 0x06006295 RID: 25237
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CollectMaterialFloatCurve_Internal(int Id, FName Key, IntPtr Value);

		// Token: 0x06006296 RID: 25238
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AttachToEffectSkeletalMesh_Internal(int Id, IntPtr AttachActor, FName SocketName, EAttachmentRule TransformRule);

		// Token: 0x06006297 RID: 25239
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AttachSkeletalMesh_Internal(int Id, IntPtr Context);

		// Token: 0x06006298 RID: 25240
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddFinishCallback_Internal(int Id, IntPtr Callback, IntPtr OnClearCallback);

		// Token: 0x06006299 RID: 25241 RVA: 0x0008D001 File Offset: 0x0008B201
		static UKuroEffectSystemFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroEffectSystemFunctionLibrary");
		}

		// Token: 0x0600629A RID: 25242 RVA: 0x0008D00F File Offset: 0x0008B20F
		protected UKuroEffectSystemFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040029C5 RID: 10693
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroEffectSystemFunctionLibrary";

		// Token: 0x040029C6 RID: 10694
		private static IntPtr _ClassPtr;

		// Token: 0x040029C7 RID: 10695
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
