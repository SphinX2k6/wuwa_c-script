using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200223B RID: 8763
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LTween.LTweenBPLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class ULTweenBPLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021571 RID: 136561 RVA: 0x003120E0 File Offset: 0x003102E0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULTweenBPLibrary._ClassPtr;
		}

		// Token: 0x06021572 RID: 136562 RVA: 0x003120EC File Offset: 0x003102EC
		public ULTweenBPLibrary() : this(BuiltinUtils.AllocNativeUObject(ULTweenBPLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021573 RID: 136563 RVA: 0x00312114 File Offset: 0x00310314
		[NullableContext(1)]
		public ULTweenBPLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULTweenBPLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021574 RID: 136564 RVA: 0x00312148 File Offset: 0x00310348
		public static ULTweener WorldRotatorTo_Sweep(USceneComponent target, FRotator endValue, bool shortestPath, ref FHitResult sweepHitResult, bool sweep, bool teleport, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__WorldRotatorTo_Sweep_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, shortestPath, (sweepHitResult ?? new FHitResult()).NativePtr, sweep, teleport, duration, delay, ease));
		}

		// Token: 0x06021575 RID: 136565 RVA: 0x0031218B File Offset: 0x0031038B
		public static ULTweener WorldRotatorTo(USceneComponent target, FRotator endValue, bool shortestPath, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__WorldRotatorTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, shortestPath, duration, delay, ease));
		}

		// Token: 0x06021576 RID: 136566 RVA: 0x003121B0 File Offset: 0x003103B0
		public unsafe static ULTweener WorldRotationQuaternionTo_Sweep(USceneComponent target, in FQuat endValue, ref FHitResult sweepHitResult, bool sweep, bool teleport, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = endValue;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__WorldRotationQuaternionTo_Sweep_Internal((target != null) ? target.NativePtr : IntPtr.Zero, ptr, (sweepHitResult ?? new FHitResult()).NativePtr, sweep, teleport, duration, delay, ease));
		}

		// Token: 0x06021577 RID: 136567 RVA: 0x00312210 File Offset: 0x00310410
		public unsafe static ULTweener WorldRotationQuaternionTo(USceneComponent target, in FQuat endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = endValue;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__WorldRotationQuaternionTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, ptr, duration, delay, ease));
		}

		// Token: 0x06021578 RID: 136568 RVA: 0x00312258 File Offset: 0x00310458
		public static ULTweener WorldRotateEulerAngleTo_Sweep(USceneComponent target, FVector eulerAngle, ref FHitResult sweepHitResult, bool sweep, bool teleport, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__WorldRotateEulerAngleTo_Sweep_Internal((target != null) ? target.NativePtr : IntPtr.Zero, eulerAngle, (sweepHitResult ?? new FHitResult()).NativePtr, sweep, teleport, duration, delay, ease));
		}

		// Token: 0x06021579 RID: 136569 RVA: 0x0031228E File Offset: 0x0031048E
		public static ULTweener WorldRotateEulerAngleTo(USceneComponent target, FVector eulerAngle, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__WorldRotateEulerAngleTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, eulerAngle, duration, delay, ease));
		}

		// Token: 0x0602157A RID: 136570 RVA: 0x003122AF File Offset: 0x003104AF
		public static ULTweener WorldPositionZTo_Sweep(USceneComponent target, float endValue, ref FHitResult sweepHitResult, bool sweep, bool teleport, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__WorldPositionZTo_Sweep_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, (sweepHitResult ?? new FHitResult()).NativePtr, sweep, teleport, duration, delay, ease));
		}

		// Token: 0x0602157B RID: 136571 RVA: 0x003122E5 File Offset: 0x003104E5
		public static ULTweener WorldPositionZTo(USceneComponent target, float endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__WorldPositionZTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, duration, delay, ease));
		}

		// Token: 0x0602157C RID: 136572 RVA: 0x00312306 File Offset: 0x00310506
		public static ULTweener WorldPositionYTo_Sweep(USceneComponent target, float endValue, ref FHitResult sweepHitResult, bool sweep, bool teleport, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__WorldPositionYTo_Sweep_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, (sweepHitResult ?? new FHitResult()).NativePtr, sweep, teleport, duration, delay, ease));
		}

		// Token: 0x0602157D RID: 136573 RVA: 0x0031233C File Offset: 0x0031053C
		public static ULTweener WorldPositionYTo(USceneComponent target, float endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__WorldPositionYTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, duration, delay, ease));
		}

		// Token: 0x0602157E RID: 136574 RVA: 0x0031235D File Offset: 0x0031055D
		public static ULTweener WorldPositionXTo_Sweep(USceneComponent target, float endValue, ref FHitResult sweepHitResult, bool sweep, bool teleport, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__WorldPositionXTo_Sweep_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, (sweepHitResult ?? new FHitResult()).NativePtr, sweep, teleport, duration, delay, ease));
		}

		// Token: 0x0602157F RID: 136575 RVA: 0x00312393 File Offset: 0x00310593
		public static ULTweener WorldPositionXTo(USceneComponent target, float endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__WorldPositionXTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, duration, delay, ease));
		}

		// Token: 0x06021580 RID: 136576 RVA: 0x003123B4 File Offset: 0x003105B4
		public static ULTweener WorldPositionTo_Sweep(USceneComponent target, FVector endValue, ref FHitResult sweepHitResult, bool sweep, bool teleport, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__WorldPositionTo_Sweep_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, (sweepHitResult ?? new FHitResult()).NativePtr, sweep, teleport, duration, delay, ease));
		}

		// Token: 0x06021581 RID: 136577 RVA: 0x003123EA File Offset: 0x003105EA
		public static ULTweener WorldPositionTo(USceneComponent target, FVector endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__WorldPositionTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, duration, delay, ease));
		}

		// Token: 0x06021582 RID: 136578 RVA: 0x0031240C File Offset: 0x0031060C
		public static ULTweener VirtualCall(UObject WorldContextObject, float duration, float delay, FTweenerSimpleDynamicDelegate start, FTweenerFloatDynamicDelegate update, FTweenerSimpleDynamicDelegate complete)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__VirtualCall_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, duration, delay, (start != null) ? start.NativePtr : ((IntPtr)0), (update != null) ? update.NativePtr : ((IntPtr)0), (complete != null) ? complete.NativePtr : ((IntPtr)0)));
		}

		// Token: 0x06021583 RID: 136579 RVA: 0x00312460 File Offset: 0x00310660
		public unsafe static ULTweener Vector4To(UObject WorldContextObject, FLTweenVector4SetterDynamic setter, FVector4 startValue, FVector4 endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = startValue;
			ref FVector4 ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = endValue;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__Vector4To_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (setter != null) ? setter.NativePtr : ((IntPtr)0), ptr, ptr2, duration, delay, ease));
		}

		// Token: 0x06021584 RID: 136580 RVA: 0x003124CA File Offset: 0x003106CA
		public static ULTweener Vector3To(UObject WorldContextObject, FLTweenVector3SetterDynamic setter, FVector startValue, FVector endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__Vector3To_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (setter != null) ? setter.NativePtr : ((IntPtr)0), startValue, endValue, duration, delay, ease));
		}

		// Token: 0x06021585 RID: 136581 RVA: 0x003124FB File Offset: 0x003106FB
		public static ULTweener Vector2To(UObject WorldContextObject, FLTweenVector2SetterDynamic setter, FVector2D startValue, FVector2D endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__Vector2To_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (setter != null) ? setter.NativePtr : ((IntPtr)0), startValue, endValue, duration, delay, ease));
		}

		// Token: 0x06021586 RID: 136582 RVA: 0x0031252C File Offset: 0x0031072C
		public static void UnregisterUpdateEvent(UObject WorldContextObject, in FLTweenDelegateHandleWrapper delegateHandle)
		{
			ULTweenBPLibrary.__UnregisterUpdateEvent_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (delegateHandle ?? new FLTweenDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x06021587 RID: 136583 RVA: 0x00312553 File Offset: 0x00310753
		public static ULTweener RotatorTo(UObject WorldContextObject, FLTweenRotatorSetterDynamic setter, FRotator startValue, FRotator endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__RotatorTo_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (setter != null) ? setter.NativePtr : ((IntPtr)0), startValue, endValue, duration, delay, ease));
		}

		// Token: 0x06021588 RID: 136584 RVA: 0x00312584 File Offset: 0x00310784
		[return: Nullable(1)]
		public static FLTweenDelegateHandleWrapper RegisterUpdateEvent(UObject WorldContextObject, in FTweenerFloatDynamicDelegate update)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			FTweenerFloatDynamicDelegate ftweenerFloatDynamicDelegate = update;
			return new FLTweenDelegateHandleWrapper(ULTweenBPLibrary.__RegisterUpdateEvent_Internal(worldContextObject, (ftweenerFloatDynamicDelegate != null) ? ftweenerFloatDynamicDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x06021589 RID: 136585 RVA: 0x003125B0 File Offset: 0x003107B0
		public unsafe static ULTweener QuaternionTo(UObject WorldContextObject, FLTweenQuaternionSetterDynamic setter, FQuat startValue, FQuat endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = startValue;
			ref FQuat ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = endValue;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__QuaternionTo_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (setter != null) ? setter.NativePtr : ((IntPtr)0), ptr, ptr2, duration, delay, ease));
		}

		// Token: 0x0602158A RID: 136586 RVA: 0x0031261A File Offset: 0x0031081A
		public static ULTweener MeshMaterialVectorParameterTo(UMeshComponent target, int materialIndex, FName parameterName, FLinearColor endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__MeshMaterialVectorParameterTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, materialIndex, parameterName, endValue, duration, delay, ease));
		}

		// Token: 0x0602158B RID: 136587 RVA: 0x0031263F File Offset: 0x0031083F
		public static ULTweener MeshMaterialScalarParameterTo(UMeshComponent target, int materialIndex, FName parameterName, float endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__MeshMaterialScalarParameterTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, materialIndex, parameterName, endValue, duration, delay, ease));
		}

		// Token: 0x0602158C RID: 136588 RVA: 0x00312664 File Offset: 0x00310864
		public static ULTweener MaterialVectorParameterTo(UMaterialInstanceDynamic target, FName parameterName, FLinearColor endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__MaterialVectorParameterTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, parameterName, endValue, duration, delay, ease));
		}

		// Token: 0x0602158D RID: 136589 RVA: 0x00312687 File Offset: 0x00310887
		public static ULTweener MaterialScalarParameterTo(UMaterialInstanceDynamic target, FName parameterName, float endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__MaterialScalarParameterTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, parameterName, endValue, duration, delay, ease));
		}

		// Token: 0x0602158E RID: 136590 RVA: 0x003126AC File Offset: 0x003108AC
		public static ULTweener LocalScaleTo(USceneComponent target, FVector? endValue = null, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__LocalScaleTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue ?? new FVector(1f, 1f, 1f), duration, delay, ease));
		}

		// Token: 0x0602158F RID: 136591 RVA: 0x00312700 File Offset: 0x00310900
		public static ULTweener LocalRotatorTo_Sweep(USceneComponent target, FRotator endValue, bool shortestPath, ref FHitResult sweepHitResult, bool sweep, bool teleport, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__LocalRotatorTo_Sweep_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, shortestPath, (sweepHitResult ?? new FHitResult()).NativePtr, sweep, teleport, duration, delay, ease));
		}

		// Token: 0x06021590 RID: 136592 RVA: 0x00312743 File Offset: 0x00310943
		public static ULTweener LocalRotatorTo(USceneComponent target, FRotator endValue, bool shortestPath, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__LocalRotatorTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, shortestPath, duration, delay, ease));
		}

		// Token: 0x06021591 RID: 136593 RVA: 0x00312768 File Offset: 0x00310968
		public unsafe static ULTweener LocalRotationQuaternionTo_Sweep(USceneComponent target, in FQuat endValue, ref FHitResult sweepHitResult, bool sweep, bool teleport, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = endValue;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__LocalRotationQuaternionTo_Sweep_Internal((target != null) ? target.NativePtr : IntPtr.Zero, ptr, (sweepHitResult ?? new FHitResult()).NativePtr, sweep, teleport, duration, delay, ease));
		}

		// Token: 0x06021592 RID: 136594 RVA: 0x003127C8 File Offset: 0x003109C8
		public unsafe static ULTweener LocalRotationQuaternionTo(USceneComponent target, in FQuat endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = endValue;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__LocalRotationQuaternionTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, ptr, duration, delay, ease));
		}

		// Token: 0x06021593 RID: 136595 RVA: 0x00312810 File Offset: 0x00310A10
		public static ULTweener LocalRotateEulerAngleTo_Sweep(USceneComponent target, FVector eulerAngle, ref FHitResult sweepHitResult, bool sweep, bool teleport, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__LocalRotateEulerAngleTo_Sweep_Internal((target != null) ? target.NativePtr : IntPtr.Zero, eulerAngle, (sweepHitResult ?? new FHitResult()).NativePtr, sweep, teleport, duration, delay, ease));
		}

		// Token: 0x06021594 RID: 136596 RVA: 0x00312846 File Offset: 0x00310A46
		public static ULTweener LocalRotateEulerAngleTo(USceneComponent target, FVector eulerAngle, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__LocalRotateEulerAngleTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, eulerAngle, duration, delay, ease));
		}

		// Token: 0x06021595 RID: 136597 RVA: 0x00312867 File Offset: 0x00310A67
		public static ULTweener LocalPositionZTo_Sweep(USceneComponent target, float endValue, ref FHitResult sweepHitResult, bool sweep, bool teleport, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__LocalPositionZTo_Sweep_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, (sweepHitResult ?? new FHitResult()).NativePtr, sweep, teleport, duration, delay, ease));
		}

		// Token: 0x06021596 RID: 136598 RVA: 0x0031289D File Offset: 0x00310A9D
		public static ULTweener LocalPositionZTo(USceneComponent target, float endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__LocalPositionZTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, duration, delay, ease));
		}

		// Token: 0x06021597 RID: 136599 RVA: 0x003128BE File Offset: 0x00310ABE
		public static ULTweener LocalPositionYTo_Sweep(USceneComponent target, float endValue, ref FHitResult sweepHitResult, bool sweep, bool teleport, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__LocalPositionYTo_Sweep_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, (sweepHitResult ?? new FHitResult()).NativePtr, sweep, teleport, duration, delay, ease));
		}

		// Token: 0x06021598 RID: 136600 RVA: 0x003128F4 File Offset: 0x00310AF4
		public static ULTweener LocalPositionYTo(USceneComponent target, float endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__LocalPositionYTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, duration, delay, ease));
		}

		// Token: 0x06021599 RID: 136601 RVA: 0x00312915 File Offset: 0x00310B15
		public static ULTweener LocalPositionXTo_Sweep(USceneComponent target, float endValue, ref FHitResult sweepHitResult, bool sweep, bool teleport, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__LocalPositionXTo_Sweep_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, (sweepHitResult ?? new FHitResult()).NativePtr, sweep, teleport, duration, delay, ease));
		}

		// Token: 0x0602159A RID: 136602 RVA: 0x0031294B File Offset: 0x00310B4B
		public static ULTweener LocalPositionXTo(USceneComponent target, float endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__LocalPositionXTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, duration, delay, ease));
		}

		// Token: 0x0602159B RID: 136603 RVA: 0x0031296C File Offset: 0x00310B6C
		public static ULTweener LocalPositionTo_Sweep(USceneComponent target, FVector endValue, ref FHitResult sweepHitResult, bool sweep, bool teleport, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__LocalPositionTo_Sweep_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, (sweepHitResult ?? new FHitResult()).NativePtr, sweep, teleport, duration, delay, ease));
		}

		// Token: 0x0602159C RID: 136604 RVA: 0x003129A2 File Offset: 0x00310BA2
		public static ULTweener LocalPositionTo(USceneComponent target, FVector endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__LocalPositionTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, duration, delay, ease));
		}

		// Token: 0x0602159D RID: 136605 RVA: 0x003129C3 File Offset: 0x00310BC3
		public static ULTweener LinearColorTo(UObject WorldContextObject, FLTweenLinearColorSetterDynamic setter, FLinearColor startValue, FLinearColor endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__LinearColorTo_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (setter != null) ? setter.NativePtr : ((IntPtr)0), startValue, endValue, duration, delay, ease));
		}

		// Token: 0x0602159E RID: 136606 RVA: 0x003129F4 File Offset: 0x00310BF4
		public static void KillIfIsTweening(UObject WorldContextObject, ULTweener inTweener, bool callComplete = false)
		{
			ULTweenBPLibrary.__KillIfIsTweening_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (inTweener != null) ? inTweener.NativePtr : IntPtr.Zero, callComplete);
		}

		// Token: 0x0602159F RID: 136607 RVA: 0x00312A1C File Offset: 0x00310C1C
		public static bool IsTweening(UObject WorldContextObject, ULTweener inTweener)
		{
			return ULTweenBPLibrary.__IsTweening_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (inTweener != null) ? inTweener.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060215A0 RID: 136608 RVA: 0x00312A43 File Offset: 0x00310C43
		public static ULTweener IntTo(UObject WorldContextObject, FLTweenIntSetterDynamic setter, int startValue, int endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__IntTo_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (setter != null) ? setter.NativePtr : ((IntPtr)0), startValue, endValue, duration, delay, ease));
		}

		// Token: 0x060215A1 RID: 136609 RVA: 0x00312A74 File Offset: 0x00310C74
		public static ULTweener FloatTo(UObject WorldContextObject, FLTweenFloatSetterDynamic setter, float startValue = 0f, float endValue = 1f, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__FloatTo_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (setter != null) ? setter.NativePtr : ((IntPtr)0), startValue, endValue, duration, delay, ease));
		}

		// Token: 0x060215A2 RID: 136610 RVA: 0x00312AA5 File Offset: 0x00310CA5
		public static ULTweener DelayFrameCall(UObject WorldContextObject, int frameCount, FTweenerSimpleDynamicDelegate delayComplete)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__DelayFrameCall_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, frameCount, (delayComplete != null) ? delayComplete.NativePtr : ((IntPtr)0)));
		}

		// Token: 0x060215A3 RID: 136611 RVA: 0x00312ACF File Offset: 0x00310CCF
		public static ULTweener DelayCall(UObject WorldContextObject, float delayTime, FTweenerSimpleDynamicDelegate delayComplete)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__DelayCall_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, delayTime, (delayComplete != null) ? delayComplete.NativePtr : ((IntPtr)0)));
		}

		// Token: 0x060215A4 RID: 136612 RVA: 0x00312AF9 File Offset: 0x00310CF9
		public static ULTweener ColorTo(UObject WorldContextObject, FLTweenColorSetterDynamic setter, FColor startValue, FColor endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__ColorTo_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (setter != null) ? setter.NativePtr : ((IntPtr)0), startValue, endValue, duration, delay, ease));
		}

		// Token: 0x060215A5 RID: 136613 RVA: 0x00312B2A File Offset: 0x00310D2A
		public static void ArrayKillIfIsTweening(UObject WorldContextObject, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<ULTweener> inTweenerArray, bool callComplete = false)
		{
			ULTweenBPLibrary.__ArrayKillIfIsTweening_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (inTweenerArray ?? new TArray<ULTweener>()).NativePtr, callComplete);
		}

		// Token: 0x060215A6 RID: 136614
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WorldRotatorTo_Sweep_Internal(IntPtr target, FRotator endValue, bool shortestPath, IntPtr sweepHitResult, bool sweep, bool teleport, float duration, float delay, LTweenEase ease);

		// Token: 0x060215A7 RID: 136615
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WorldRotatorTo_Internal(IntPtr target, FRotator endValue, bool shortestPath, float duration, float delay, LTweenEase ease);

		// Token: 0x060215A8 RID: 136616
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WorldRotationQuaternionTo_Sweep_Internal(IntPtr target, in FQuat endValue, IntPtr sweepHitResult, bool sweep, bool teleport, float duration, float delay, LTweenEase ease);

		// Token: 0x060215A9 RID: 136617
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WorldRotationQuaternionTo_Internal(IntPtr target, in FQuat endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x060215AA RID: 136618
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WorldRotateEulerAngleTo_Sweep_Internal(IntPtr target, FVector eulerAngle, IntPtr sweepHitResult, bool sweep, bool teleport, float duration, float delay, LTweenEase ease);

		// Token: 0x060215AB RID: 136619
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WorldRotateEulerAngleTo_Internal(IntPtr target, FVector eulerAngle, float duration, float delay, LTweenEase ease);

		// Token: 0x060215AC RID: 136620
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WorldPositionZTo_Sweep_Internal(IntPtr target, float endValue, IntPtr sweepHitResult, bool sweep, bool teleport, float duration, float delay, LTweenEase ease);

		// Token: 0x060215AD RID: 136621
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WorldPositionZTo_Internal(IntPtr target, float endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x060215AE RID: 136622
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WorldPositionYTo_Sweep_Internal(IntPtr target, float endValue, IntPtr sweepHitResult, bool sweep, bool teleport, float duration, float delay, LTweenEase ease);

		// Token: 0x060215AF RID: 136623
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WorldPositionYTo_Internal(IntPtr target, float endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x060215B0 RID: 136624
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WorldPositionXTo_Sweep_Internal(IntPtr target, float endValue, IntPtr sweepHitResult, bool sweep, bool teleport, float duration, float delay, LTweenEase ease);

		// Token: 0x060215B1 RID: 136625
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WorldPositionXTo_Internal(IntPtr target, float endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x060215B2 RID: 136626
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WorldPositionTo_Sweep_Internal(IntPtr target, FVector endValue, IntPtr sweepHitResult, bool sweep, bool teleport, float duration, float delay, LTweenEase ease);

		// Token: 0x060215B3 RID: 136627
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WorldPositionTo_Internal(IntPtr target, FVector endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x060215B4 RID: 136628
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __VirtualCall_Internal(IntPtr WorldContextObject, float duration, float delay, IntPtr start, IntPtr update, IntPtr complete);

		// Token: 0x060215B5 RID: 136629
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Vector4To_Internal(IntPtr WorldContextObject, IntPtr setter, in FVector4 startValue, in FVector4 endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x060215B6 RID: 136630
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Vector3To_Internal(IntPtr WorldContextObject, IntPtr setter, FVector startValue, FVector endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x060215B7 RID: 136631
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Vector2To_Internal(IntPtr WorldContextObject, IntPtr setter, FVector2D startValue, FVector2D endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x060215B8 RID: 136632
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterUpdateEvent_Internal(IntPtr WorldContextObject, IntPtr delegateHandle);

		// Token: 0x060215B9 RID: 136633
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RotatorTo_Internal(IntPtr WorldContextObject, IntPtr setter, FRotator startValue, FRotator endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x060215BA RID: 136634
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RegisterUpdateEvent_Internal(IntPtr WorldContextObject, IntPtr update);

		// Token: 0x060215BB RID: 136635
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __QuaternionTo_Internal(IntPtr WorldContextObject, IntPtr setter, in FQuat startValue, in FQuat endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x060215BC RID: 136636
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MeshMaterialVectorParameterTo_Internal(IntPtr target, int materialIndex, FName parameterName, FLinearColor endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x060215BD RID: 136637
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MeshMaterialScalarParameterTo_Internal(IntPtr target, int materialIndex, FName parameterName, float endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x060215BE RID: 136638
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MaterialVectorParameterTo_Internal(IntPtr target, FName parameterName, FLinearColor endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x060215BF RID: 136639
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MaterialScalarParameterTo_Internal(IntPtr target, FName parameterName, float endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x060215C0 RID: 136640
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LocalScaleTo_Internal(IntPtr target, FVector endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x060215C1 RID: 136641
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LocalRotatorTo_Sweep_Internal(IntPtr target, FRotator endValue, bool shortestPath, IntPtr sweepHitResult, bool sweep, bool teleport, float duration, float delay, LTweenEase ease);

		// Token: 0x060215C2 RID: 136642
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LocalRotatorTo_Internal(IntPtr target, FRotator endValue, bool shortestPath, float duration, float delay, LTweenEase ease);

		// Token: 0x060215C3 RID: 136643
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LocalRotationQuaternionTo_Sweep_Internal(IntPtr target, in FQuat endValue, IntPtr sweepHitResult, bool sweep, bool teleport, float duration, float delay, LTweenEase ease);

		// Token: 0x060215C4 RID: 136644
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LocalRotationQuaternionTo_Internal(IntPtr target, in FQuat endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x060215C5 RID: 136645
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LocalRotateEulerAngleTo_Sweep_Internal(IntPtr target, FVector eulerAngle, IntPtr sweepHitResult, bool sweep, bool teleport, float duration, float delay, LTweenEase ease);

		// Token: 0x060215C6 RID: 136646
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LocalRotateEulerAngleTo_Internal(IntPtr target, FVector eulerAngle, float duration, float delay, LTweenEase ease);

		// Token: 0x060215C7 RID: 136647
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LocalPositionZTo_Sweep_Internal(IntPtr target, float endValue, IntPtr sweepHitResult, bool sweep, bool teleport, float duration, float delay, LTweenEase ease);

		// Token: 0x060215C8 RID: 136648
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LocalPositionZTo_Internal(IntPtr target, float endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x060215C9 RID: 136649
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LocalPositionYTo_Sweep_Internal(IntPtr target, float endValue, IntPtr sweepHitResult, bool sweep, bool teleport, float duration, float delay, LTweenEase ease);

		// Token: 0x060215CA RID: 136650
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LocalPositionYTo_Internal(IntPtr target, float endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x060215CB RID: 136651
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LocalPositionXTo_Sweep_Internal(IntPtr target, float endValue, IntPtr sweepHitResult, bool sweep, bool teleport, float duration, float delay, LTweenEase ease);

		// Token: 0x060215CC RID: 136652
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LocalPositionXTo_Internal(IntPtr target, float endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x060215CD RID: 136653
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LocalPositionTo_Sweep_Internal(IntPtr target, FVector endValue, IntPtr sweepHitResult, bool sweep, bool teleport, float duration, float delay, LTweenEase ease);

		// Token: 0x060215CE RID: 136654
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LocalPositionTo_Internal(IntPtr target, FVector endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x060215CF RID: 136655
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LinearColorTo_Internal(IntPtr WorldContextObject, IntPtr setter, FLinearColor startValue, FLinearColor endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x060215D0 RID: 136656
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KillIfIsTweening_Internal(IntPtr WorldContextObject, IntPtr inTweener, bool callComplete);

		// Token: 0x060215D1 RID: 136657
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsTweening_Internal(IntPtr WorldContextObject, IntPtr inTweener);

		// Token: 0x060215D2 RID: 136658
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __IntTo_Internal(IntPtr WorldContextObject, IntPtr setter, int startValue, int endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x060215D3 RID: 136659
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FloatTo_Internal(IntPtr WorldContextObject, IntPtr setter, float startValue, float endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x060215D4 RID: 136660
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __DelayFrameCall_Internal(IntPtr WorldContextObject, int frameCount, IntPtr delayComplete);

		// Token: 0x060215D5 RID: 136661
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __DelayCall_Internal(IntPtr WorldContextObject, float delayTime, IntPtr delayComplete);

		// Token: 0x060215D6 RID: 136662
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __ColorTo_Internal(IntPtr WorldContextObject, IntPtr setter, FColor startValue, FColor endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x060215D7 RID: 136663
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ArrayKillIfIsTweening_Internal(IntPtr WorldContextObject, IntPtr inTweenerArray, bool callComplete);

		// Token: 0x060215D8 RID: 136664 RVA: 0x00312B52 File Offset: 0x00310D52
		static ULTweenBPLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LTween.LTweenBPLibrary");
		}

		// Token: 0x060215D9 RID: 136665 RVA: 0x00312B60 File Offset: 0x00310D60
		protected ULTweenBPLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011C75 RID: 72821
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LTween.LTweenBPLibrary";

		// Token: 0x04011C76 RID: 72822
		private static IntPtr _ClassPtr;

		// Token: 0x04011C77 RID: 72823
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
