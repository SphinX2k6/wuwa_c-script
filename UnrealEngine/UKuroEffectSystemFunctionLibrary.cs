using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018D1 RID: 6353
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroEffectSystemFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroEffectSystemFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017811 RID: 96273 RVA: 0x00226941 File Offset: 0x00224B41
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroEffectSystemFunctionLibrary._ClassPtr;
		}

		// Token: 0x06017812 RID: 96274 RVA: 0x00226950 File Offset: 0x00224B50
		public UKuroEffectSystemFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroEffectSystemFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017813 RID: 96275 RVA: 0x00226978 File Offset: 0x00224B78
		[NullableContext(1)]
		public UKuroEffectSystemFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroEffectSystemFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06017814 RID: 96276
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UpdateIsGameRunning(bool bIsGameRunning);

		// Token: 0x06017815 RID: 96277
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UpdateBodyEffect(int Id, float Opacity, bool bVisible, bool bCastShadow);

		// Token: 0x06017816 RID: 96278
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void TickHandleInEditor(int Id, float Delta);

		// Token: 0x06017817 RID: 96279
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void StopLimitedEffectFromEntityImmediately(int EntityId, bool RootOnly);

		// Token: 0x06017818 RID: 96280
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void StopEffectFromEntity(int EntityId, FName FilterName, bool Immediately);

		// Token: 0x06017819 RID: 96281 RVA: 0x002269AC File Offset: 0x00224BAC
		[NullableContext(1)]
		public unsafe static bool StopEffectById(int Handle, string Reason, bool Immediately, bool bDestroyActor = false)
		{
			FString fstring = FString.AllocTemp(Reason);
			bool result = UKuroEffectSystemFunctionLibrary.__StopEffectById_Internal(Handle, fstring, Immediately, bDestroyActor);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601781A RID: 96282 RVA: 0x002269D4 File Offset: 0x00224BD4
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

		// Token: 0x0601781B RID: 96283 RVA: 0x00226A90 File Offset: 0x00224C90
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

		// Token: 0x0601781C RID: 96284 RVA: 0x00226B4C File Offset: 0x00224D4C
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

		// Token: 0x0601781D RID: 96285 RVA: 0x00226C08 File Offset: 0x00224E08
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

		// Token: 0x0601781E RID: 96286 RVA: 0x00226CC4 File Offset: 0x00224EC4
		public unsafe static int SpawnEffectWithActorFromSkeletalContext(UObject WorldContext, AActor Actor, [Nullable(1)] string Path, [Nullable(1)] string Reason, in FKuroSkeletalMeshEffectContext Context, bool bAutoPlay = true, bool bIsExternalActor = true, byte EffectType = 3)
		{
			FString fstring = FString.AllocTemp(Path);
			FString fstring2 = FString.AllocTemp(Reason);
			int result = UKuroEffectSystemFunctionLibrary.__SpawnEffectWithActorFromSkeletalContext_Internal((WorldContext != null) ? WorldContext.NativePtr : IntPtr.Zero, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, fstring, fstring2, (Context ?? new FKuroSkeletalMeshEffectContext()).NativePtr, bAutoPlay, bIsExternalActor, EffectType);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0601781F RID: 96287 RVA: 0x00226D34 File Offset: 0x00224F34
		public unsafe static int SpawnEffectWithActorFromGhostContext(UObject WorldContext, AActor Actor, [Nullable(1)] string Path, [Nullable(1)] string Reason, in FKuroEffectRuntimeGhostEffectContext Context, bool bAutoPlay = true, bool bIsExternalActor = true, byte EffectType = 3)
		{
			FString fstring = FString.AllocTemp(Path);
			FString fstring2 = FString.AllocTemp(Reason);
			int result = UKuroEffectSystemFunctionLibrary.__SpawnEffectWithActorFromGhostContext_Internal((WorldContext != null) ? WorldContext.NativePtr : IntPtr.Zero, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, fstring, fstring2, (Context ?? new FKuroEffectRuntimeGhostEffectContext()).NativePtr, bAutoPlay, bIsExternalActor, EffectType);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06017820 RID: 96288 RVA: 0x00226DA4 File Offset: 0x00224FA4
		public unsafe static int SpawnEffectWithActorFromAudioContext(UObject WorldContext, AActor Actor, [Nullable(1)] string Path, [Nullable(1)] string Reason, in FKuroEffectAudioContext Context, bool bAutoPlay = true, bool bIsExternalActor = true, byte EffectType = 3)
		{
			FString fstring = FString.AllocTemp(Path);
			FString fstring2 = FString.AllocTemp(Reason);
			int result = UKuroEffectSystemFunctionLibrary.__SpawnEffectWithActorFromAudioContext_Internal((WorldContext != null) ? WorldContext.NativePtr : IntPtr.Zero, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, fstring, fstring2, (Context ?? new FKuroEffectAudioContext()).NativePtr, bAutoPlay, bIsExternalActor, EffectType);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06017821 RID: 96289 RVA: 0x00226E14 File Offset: 0x00225014
		public unsafe static int SpawnEffectWithActor(UObject WorldContext, AActor Actor, [Nullable(1)] string Path, [Nullable(1)] string Reason, in FKuroEffectContext Context, bool bAutoPlay = true, bool bIsExternalActor = true, byte EffectType = 3)
		{
			FString fstring = FString.AllocTemp(Path);
			FString fstring2 = FString.AllocTemp(Reason);
			int result = UKuroEffectSystemFunctionLibrary.__SpawnEffectWithActor_Internal((WorldContext != null) ? WorldContext.NativePtr : IntPtr.Zero, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, fstring, fstring2, (Context ?? new FKuroEffectContext()).NativePtr, bAutoPlay, bIsExternalActor, EffectType);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06017822 RID: 96290 RVA: 0x00226E84 File Offset: 0x00225084
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

		// Token: 0x06017823 RID: 96291 RVA: 0x00226F40 File Offset: 0x00225140
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

		// Token: 0x06017824 RID: 96292 RVA: 0x00226FFC File Offset: 0x002251FC
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

		// Token: 0x06017825 RID: 96293 RVA: 0x002270B8 File Offset: 0x002252B8
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

		// Token: 0x06017826 RID: 96294
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetUseDebugDrawNew(bool bUseDebugDrawNew);

		// Token: 0x06017827 RID: 96295
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetTimeScale(int Id, float TimeScale, bool bIgnoreGlobalTimeScale = false);

		// Token: 0x06017828 RID: 96296
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetThreeStageTime(int Id, float StartTime, float LoopTime, float EndTime, bool bResetPassTime);

		// Token: 0x06017829 RID: 96297
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetHandleLifeCycle(int Id, float Time);

		// Token: 0x0601782A RID: 96298
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetGlobalTimeScale(float InGlobalTimeScale);

		// Token: 0x0601782B RID: 96299
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetGlobalStoppingTime(bool bStoppingTime, float PlayTime, int Source = 1);

		// Token: 0x0601782C RID: 96300
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetEffectStoppingTimeFromEntity(int EntityId, bool bStoppingTime, int Source = 1);

		// Token: 0x0601782D RID: 96301
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetEffectStoppingTime(int EffectId, bool bStoppingTime, int Source = 1);

		// Token: 0x0601782E RID: 96302
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetEffectQualityLevel(int Id, int QualityLevel);

		// Token: 0x0601782F RID: 96303 RVA: 0x00227172 File Offset: 0x00225372
		public static void SetEffectParameterNiagara(int Id, in FKuroEffectNiagaraParametersStruct Parameter)
		{
			UKuroEffectSystemFunctionLibrary.__SetEffectParameterNiagara_Internal(Id, (Parameter ?? new FKuroEffectNiagaraParametersStruct()).NativePtr);
		}

		// Token: 0x06017830 RID: 96304
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetEffectLruCapacity(int Capacity);

		// Token: 0x06017831 RID: 96305
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetEffectIgnoreVisibilityOptimize(int EffectId, bool bIgnore);

		// Token: 0x06017832 RID: 96306 RVA: 0x0022718C File Offset: 0x0022538C
		[NullableContext(1)]
		public unsafe static void SetEffectHidden(int Handle, bool bHidden, string Reason, bool bIsLogic = false)
		{
			FString fstring = FString.AllocTemp(Reason);
			UKuroEffectSystemFunctionLibrary.__SetEffectHidden_Internal(Handle, bHidden, fstring, bIsLogic);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06017833 RID: 96307
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetEffectExtraState(int EffectId, int ExtraState);

		// Token: 0x06017834 RID: 96308
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetEffectDataFloatConstParam(int Id, FName ParamName, float Value);

		// Token: 0x06017835 RID: 96309
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetAdditionTimeScaleEnable(int SourceType, bool Enable);

		// Token: 0x06017836 RID: 96310
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetAdditionTimeScale(int SourceType, int Id, float TimeScale);

		// Token: 0x06017837 RID: 96311 RVA: 0x002271B4 File Offset: 0x002253B4
		[NullableContext(1)]
		public unsafe static void ReplayEffect(int Id, string Reason, in FTransformDouble Transform, bool bResetTransform = false)
		{
			FString fstring = FString.AllocTemp(Reason);
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = Transform;
			UKuroEffectSystemFunctionLibrary.__ReplayEffect_Internal(Id, fstring, ptr, bResetTransform);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06017838 RID: 96312
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RemoveFinishCallback(int Id);

		// Token: 0x06017839 RID: 96313 RVA: 0x002271F8 File Offset: 0x002253F8
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

		// Token: 0x0601783A RID: 96314 RVA: 0x002273E6 File Offset: 0x002255E6
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

		// Token: 0x0601783B RID: 96315
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void OnUiSceneStateChange(EKuroUI3DState UiSceneState);

		// Token: 0x0601783C RID: 96316
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void OnTickSystemPausedChange(bool bIsPaused);

		// Token: 0x0601783D RID: 96317 RVA: 0x0022740E File Offset: 0x0022560E
		public static void OnPlayerEffectContainerFormationLoaded(in TArray<FKuroSceneTeamItem> SceneTeamItems)
		{
			UKuroEffectSystemFunctionLibrary.__OnPlayerEffectContainerFormationLoaded_Internal((SceneTeamItems ?? new TArray<FKuroSceneTeamItem>()).NativePtr);
		}

		// Token: 0x0601783E RID: 96318
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void OnIsInEditorTickChange(bool bIsInEditorTick);

		// Token: 0x0601783F RID: 96319
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void OnGlobalTimeScaleChange();

		// Token: 0x06017840 RID: 96320
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void OnEffectQualityBiasRemoteChange(float EffectQualityBiasRemote);

		// Token: 0x06017841 RID: 96321
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void OnDisableOtherEffectChange(bool bDisableOtherEffect);

		// Token: 0x06017842 RID: 96322
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsPlaying(int Id);

		// Token: 0x06017843 RID: 96323
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsHandleFreeze(int Id);

		// Token: 0x06017844 RID: 96324
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsEffectValid(int Id);

		// Token: 0x06017845 RID: 96325
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsEffectSpecDataContainsType(in FName EffectPath, byte Type);

		// Token: 0x06017846 RID: 96326
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsEffectActorValid(int Id);

		// Token: 0x06017847 RID: 96327
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void InitStaticGlobalData(bool bUseLog, bool bIsInEditorTick, bool bUseDbConfig);

		// Token: 0x06017848 RID: 96328 RVA: 0x00227428 File Offset: 0x00225628
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

		// Token: 0x06017849 RID: 96329
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasNiagaraComponentHandle(int Id);

		// Token: 0x0601784A RID: 96330
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasInitialize();

		// Token: 0x0601784B RID: 96331
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasEffectForSpecData();

		// Token: 0x0601784C RID: 96332
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void HandleSeekToTimeWithProcess(int Id, float Time, bool bSeekContinue = false, float Delta = -1f);

		// Token: 0x0601784D RID: 96333
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HandleSeekToTime(int Id, float Time, bool bAutoLoop, bool bForce = false);

		// Token: 0x0601784E RID: 96334
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GlobalStoppingTime(int Source = 1);

		// Token: 0x0601784F RID: 96335
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GlobalStoppingPlayTime(int Source = 1);

		// Token: 0x06017850 RID: 96336
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetTotalPassTime(int Id);

		// Token: 0x06017851 RID: 96337 RVA: 0x0022747C File Offset: 0x0022567C
		public static UNiagaraComponent GetSureNiagaraComponent(int Id)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UNiagaraComponent>(UKuroEffectSystemFunctionLibrary.__GetSureNiagaraComponent_Internal(Id));
		}

		// Token: 0x06017852 RID: 96338 RVA: 0x00227489 File Offset: 0x00225689
		public static AActor GetSureEffectActor(int Id)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UKuroEffectSystemFunctionLibrary.__GetSureEffectActor_Internal(Id));
		}

		// Token: 0x06017853 RID: 96339
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetSeekToTargetTime(int Id);

		// Token: 0x06017854 RID: 96340
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetPlayerEffectLruSize(int Pos);

		// Token: 0x06017855 RID: 96341 RVA: 0x00227496 File Offset: 0x00225696
		[NullableContext(1)]
		public static string GetPath(int Id)
		{
			return FString.ToStringAndDeleteNativePtr(UKuroEffectSystemFunctionLibrary.__GetPath_Internal(Id));
		}

		// Token: 0x06017856 RID: 96342
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetPassTime(int Id);

		// Token: 0x06017857 RID: 96343
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetLastStopTime(int Id);

		// Token: 0x06017858 RID: 96344
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetLastPlayTime(int Id);

		// Token: 0x06017859 RID: 96345
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern byte GetEffectSpecDataType(in FName EffectPath);

		// Token: 0x0601785A RID: 96346 RVA: 0x002274A3 File Offset: 0x002256A3
		public static UEffectModelBase GetEffectModel(int Id)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UEffectModelBase>(UKuroEffectSystemFunctionLibrary.__GetEffectModel_Internal(Id));
		}

		// Token: 0x0601785B RID: 96347
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetEffectLruSize();

		// Token: 0x0601785C RID: 96348 RVA: 0x002274B0 File Offset: 0x002256B0
		[NullableContext(1)]
		public unsafe static int GetEffectLruCount(string Path)
		{
			FString fstring = FString.AllocTemp(Path);
			int result = UKuroEffectSystemFunctionLibrary.__GetEffectLruCount_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601785D RID: 96349
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetEffectLruCapacity();

		// Token: 0x0601785E RID: 96350
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetEffectCount();

		// Token: 0x0601785F RID: 96351
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetAdditionTimeScaleEnable(int SourceType);

		// Token: 0x06017860 RID: 96352
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetActiveEffectCount();

		// Token: 0x06017861 RID: 96353
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FreezeHandle(int Id, bool bFreeze, bool bForce = false);

		// Token: 0x06017862 RID: 96354
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ForceCheckPendingInit(int Handle);

		// Token: 0x06017863 RID: 96355
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool EffectIsLoop(int Id);

		// Token: 0x06017864 RID: 96356 RVA: 0x002274D4 File Offset: 0x002256D4
		public static void DynamicRegisterSpawnCallback(int EffectId, in FKuroEffectInitCallback Callback, in FKuroEffectOnClearCallback OnClearCallback)
		{
			FKuroEffectInitCallback fkuroEffectInitCallback = Callback;
			IntPtr callback = (fkuroEffectInitCallback != null) ? fkuroEffectInitCallback.NativePtr : ((IntPtr)0);
			FKuroEffectOnClearCallback fkuroEffectOnClearCallback = OnClearCallback;
			UKuroEffectSystemFunctionLibrary.__DynamicRegisterSpawnCallback_Internal(EffectId, callback, (fkuroEffectOnClearCallback != null) ? fkuroEffectOnClearCallback.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06017865 RID: 96357
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DebugUpdate(int Id, bool bDebugUpdate);

		// Token: 0x06017866 RID: 96358
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DebugPrintEffect();

		// Token: 0x06017867 RID: 96359
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DebugPrintCurrentImportanceEffects();

		// Token: 0x06017868 RID: 96360
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DebugPrintAllErrorEffects();

		// Token: 0x06017869 RID: 96361 RVA: 0x002274FA File Offset: 0x002256FA
		public static void CollectMaterialVectorCurve(int Id, FName Key, in FKuroCurveVector Value)
		{
			UKuroEffectSystemFunctionLibrary.__CollectMaterialVectorCurve_Internal(Id, Key, (Value ?? new FKuroCurveVector()).NativePtr);
		}

		// Token: 0x0601786A RID: 96362 RVA: 0x00227513 File Offset: 0x00225713
		public static void CollectMaterialLinearColorCurve(int Id, FName Key, in FKuroCurveLinearColor Value)
		{
			UKuroEffectSystemFunctionLibrary.__CollectMaterialLinearColorCurve_Internal(Id, Key, (Value ?? new FKuroCurveLinearColor()).NativePtr);
		}

		// Token: 0x0601786B RID: 96363 RVA: 0x0022752C File Offset: 0x0022572C
		public static void CollectMaterialFloatCurve(int Id, FName Key, in FKuroCurveFloat Value)
		{
			UKuroEffectSystemFunctionLibrary.__CollectMaterialFloatCurve_Internal(Id, Key, (Value ?? new FKuroCurveFloat()).NativePtr);
		}

		// Token: 0x0601786C RID: 96364
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ClearPool(bool IsInternal);

		// Token: 0x0601786D RID: 96365
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Clear();

		// Token: 0x0601786E RID: 96366 RVA: 0x00227545 File Offset: 0x00225745
		public static void AttachToEffectSkeletalMesh(int Id, AActor AttachActor, FName SocketName = default(FName), EAttachmentRule TransformRule = EAttachmentRule.KeepRelative)
		{
			UKuroEffectSystemFunctionLibrary.__AttachToEffectSkeletalMesh_Internal(Id, (AttachActor != null) ? AttachActor.NativePtr : IntPtr.Zero, SocketName, TransformRule);
		}

		// Token: 0x0601786F RID: 96367 RVA: 0x0022755F File Offset: 0x0022575F
		public static void AttachSkeletalMesh(int Id, in FKuroSkeletalMeshEffectContext Context)
		{
			UKuroEffectSystemFunctionLibrary.__AttachSkeletalMesh_Internal(Id, (Context ?? new FKuroSkeletalMeshEffectContext()).NativePtr);
		}

		// Token: 0x06017870 RID: 96368 RVA: 0x00227577 File Offset: 0x00225777
		public static void AddFinishCallback(int Id, in FKuroEffectFinishCallback Callback, in FKuroEffectOnClearCallback OnClearCallback)
		{
			FKuroEffectFinishCallback fkuroEffectFinishCallback = Callback;
			IntPtr callback = (fkuroEffectFinishCallback != null) ? fkuroEffectFinishCallback.NativePtr : ((IntPtr)0);
			FKuroEffectOnClearCallback fkuroEffectOnClearCallback = OnClearCallback;
			UKuroEffectSystemFunctionLibrary.__AddFinishCallback_Internal(Id, callback, (fkuroEffectOnClearCallback != null) ? fkuroEffectOnClearCallback.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06017871 RID: 96369
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __StopEffectById_Internal(int Handle, in FString Reason, bool Immediately, bool bDestroyActor);

		// Token: 0x06017872 RID: 96370
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __SpawnUnloopedEffectFromSkeletalContext_Internal(IntPtr WorldContext, in FTransformDouble Transform, in FString Path, in FString Reason, IntPtr Context, IntPtr BeforeInitCallback, IntPtr Callback, IntPtr BeforePlayCallback, IntPtr OnClearCallback, byte EffectType, bool bPrepare, bool bForceCreateActor);

		// Token: 0x06017873 RID: 96371
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __SpawnUnloopedEffectFromGhostContext_Internal(IntPtr WorldContext, in FTransformDouble Transform, in FString Path, in FString Reason, IntPtr Context, IntPtr BeforeInitCallback, IntPtr Callback, IntPtr BeforePlayCallback, IntPtr OnClearCallback, byte EffectType, bool bPrepare, bool bForceCreateActor);

		// Token: 0x06017874 RID: 96372
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __SpawnUnloopedEffectFromAudioContext_Internal(IntPtr WorldContext, in FTransformDouble Transform, in FString Path, in FString Reason, IntPtr Context, IntPtr BeforeInitCallback, IntPtr Callback, IntPtr BeforePlayCallback, IntPtr OnClearCallback, byte EffectType, bool bPrepare, bool bForceCreateActor);

		// Token: 0x06017875 RID: 96373
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __SpawnUnloopedEffect_Internal(IntPtr WorldContext, in FTransformDouble Transform, in FString Path, in FString Reason, IntPtr Context, IntPtr BeforeInitCallback, IntPtr Callback, IntPtr BeforePlayCallback, IntPtr OnClearCallback, byte EffectType, bool bPrepare, bool bForceCreateActor);

		// Token: 0x06017876 RID: 96374
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __SpawnEffectWithActorFromSkeletalContext_Internal(IntPtr WorldContext, IntPtr Actor, in FString Path, in FString Reason, IntPtr Context, bool bAutoPlay, bool bIsExternalActor, byte EffectType);

		// Token: 0x06017877 RID: 96375
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __SpawnEffectWithActorFromGhostContext_Internal(IntPtr WorldContext, IntPtr Actor, in FString Path, in FString Reason, IntPtr Context, bool bAutoPlay, bool bIsExternalActor, byte EffectType);

		// Token: 0x06017878 RID: 96376
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __SpawnEffectWithActorFromAudioContext_Internal(IntPtr WorldContext, IntPtr Actor, in FString Path, in FString Reason, IntPtr Context, bool bAutoPlay, bool bIsExternalActor, byte EffectType);

		// Token: 0x06017879 RID: 96377
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __SpawnEffectWithActor_Internal(IntPtr WorldContext, IntPtr Actor, in FString Path, in FString Reason, IntPtr Context, bool bAutoPlay, bool bIsExternalActor, byte EffectType);

		// Token: 0x0601787A RID: 96378
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __SpawnEffectFromSkeletalContext_Internal(IntPtr WorldContext, in FTransformDouble Transform, in FString Path, in FString Reason, IntPtr Context, IntPtr BeforeInitCallback, IntPtr Callback, IntPtr BeforePlayCallback, IntPtr OnClearCallback, byte EffectType, bool bPrepare, bool bForceCreateActor);

		// Token: 0x0601787B RID: 96379
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __SpawnEffectFromGhostContext_Internal(IntPtr WorldContext, in FTransformDouble Transform, in FString Path, in FString Reason, IntPtr Context, IntPtr BeforeInitCallback, IntPtr Callback, IntPtr BeforePlayCallback, IntPtr OnClearCallback, byte EffectType, bool bPrepare, bool bForceCreateActor);

		// Token: 0x0601787C RID: 96380
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __SpawnEffectFromAudioContext_Internal(IntPtr WorldContext, in FTransformDouble Transform, in FString Path, in FString Reason, IntPtr Context, IntPtr BeforeInitCallback, IntPtr Callback, IntPtr BeforePlayCallback, IntPtr OnClearCallback, byte EffectType, bool bPrepare, bool bForceCreateActor);

		// Token: 0x0601787D RID: 96381
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __SpawnEffect_Internal(IntPtr WorldContext, in FTransformDouble Transform, in FString Path, in FString Reason, IntPtr Context, IntPtr BeforeInitCallback, IntPtr Callback, IntPtr BeforePlayCallback, IntPtr OnClearCallback, byte EffectType, bool bPrepare, bool bForceCreateActor);

		// Token: 0x0601787E RID: 96382
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEffectParameterNiagara_Internal(int Id, IntPtr Parameter);

		// Token: 0x0601787F RID: 96383
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEffectHidden_Internal(int Handle, bool bHidden, in FString Reason, bool bIsLogic);

		// Token: 0x06017880 RID: 96384
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReplayEffect_Internal(int Id, in FString Reason, in FTransformDouble Transform, bool bResetTransform);

		// Token: 0x06017881 RID: 96385
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterJsFunction_Internal(IntPtr InSkeletalMeshSpec_OnBodyEffectChange, IntPtr InSkeletalMeshSpec_CreateRenderingComponent, IntPtr InSkeletalMeshSpec_DestroyRenderingComponent, IntPtr InEffectHandle_GetEntityOwnerActor, IntPtr InEffectHandle_GetEntityModelConfigId, IntPtr InEffectHandle_GetOrAddEffectDynamicGroup, IntPtr InAudioSystem_GetAkComponent, IntPtr InAudioSystem_ExecuteActionStop, IntPtr InAudioSystem_PostEventTransform, IntPtr InAudioSystem_PostEventAkComponent, IntPtr InNiagaraSpec_IsNeedQualityBias, IntPtr InPostProcessSpec_IsNeedPostEffect, IntPtr InPostProcessSpec_IsDisableInUltraSkill, IntPtr InActorSystem_Get, IntPtr InActorSystem_Put, IntPtr InEffectSystem_SetEffectView, IntPtr InEffectSystem_CheckIsNetPlayer, IntPtr InEffectSystem_CheckMobileBlackEffect, IntPtr InEffectSpec_RegisterBodyEffect, IntPtr InEffectSpec_UnregisterBodyEffect, IntPtr InMaterialSpec_GetRenderingComponentByContext, IntPtr InMaterialSpec_GetRenderingComponentBySkeletal, IntPtr InMaterialSpec_SpawnRenderActor, IntPtr InMaterialSpec_GetRenderingComponentByRenderActor, IntPtr InMaterialSpec_AddMaterialControllerData, IntPtr InMaterialSpec_RemoveMaterialControllerData, IntPtr InMaterialSpec_DestroyRenderingComponent, IntPtr InEffectAudioController_AddPlayEffectAudio, IntPtr InEffectAudioController_AddPlayEffectAudioPriority, IntPtr InEffectAudioController_OnStopEffectAudio);

		// Token: 0x06017882 RID: 96386
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RefreshEffectForSpecData_Internal(IntPtr SpecDataArray, IntPtr SpecChildDataArray, bool IsRefresh);

		// Token: 0x06017883 RID: 96387
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPlayerEffectContainerFormationLoaded_Internal(IntPtr SceneTeamItems);

		// Token: 0x06017884 RID: 96388
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Initialize_Internal(IntPtr GameInstance, IntPtr SpecDataArray, IntPtr SpecChildDataArray, bool InIsGameRunning, float InBoundsVisibleThreshold, float InMaxVisibleCullDeltaTime, float InWasRecentlyRenderInterval, bool InUseVisibilityTestPass, IntPtr EffectViewClass, bool IsResetSpecData);

		// Token: 0x06017885 RID: 96389
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSureNiagaraComponent_Internal(int Id);

		// Token: 0x06017886 RID: 96390
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSureEffectActor_Internal(int Id);

		// Token: 0x06017887 RID: 96391
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetPath_Internal(int Id);

		// Token: 0x06017888 RID: 96392
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetEffectModel_Internal(int Id);

		// Token: 0x06017889 RID: 96393
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetEffectLruCount_Internal(in FString Path);

		// Token: 0x0601788A RID: 96394
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DynamicRegisterSpawnCallback_Internal(int EffectId, IntPtr Callback, IntPtr OnClearCallback);

		// Token: 0x0601788B RID: 96395
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CollectMaterialVectorCurve_Internal(int Id, FName Key, IntPtr Value);

		// Token: 0x0601788C RID: 96396
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CollectMaterialLinearColorCurve_Internal(int Id, FName Key, IntPtr Value);

		// Token: 0x0601788D RID: 96397
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CollectMaterialFloatCurve_Internal(int Id, FName Key, IntPtr Value);

		// Token: 0x0601788E RID: 96398
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AttachToEffectSkeletalMesh_Internal(int Id, IntPtr AttachActor, FName SocketName, EAttachmentRule TransformRule);

		// Token: 0x0601788F RID: 96399
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AttachSkeletalMesh_Internal(int Id, IntPtr Context);

		// Token: 0x06017890 RID: 96400
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddFinishCallback_Internal(int Id, IntPtr Callback, IntPtr OnClearCallback);

		// Token: 0x06017891 RID: 96401 RVA: 0x0022759D File Offset: 0x0022579D
		static UKuroEffectSystemFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroEffectSystemFunctionLibrary");
		}

		// Token: 0x06017892 RID: 96402 RVA: 0x002275AB File Offset: 0x002257AB
		protected UKuroEffectSystemFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CC8C RID: 52364
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroEffectSystemFunctionLibrary";

		// Token: 0x0400CC8D RID: 52365
		private static IntPtr _ClassPtr;

		// Token: 0x0400CC8E RID: 52366
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
