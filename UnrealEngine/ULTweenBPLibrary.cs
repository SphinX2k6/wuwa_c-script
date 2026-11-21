using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000741 RID: 1857
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LTween.LTweenBPLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class ULTweenBPLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A20C RID: 41484 RVA: 0x000EF4A4 File Offset: 0x000ED6A4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULTweenBPLibrary._ClassPtr;
		}

		// Token: 0x0600A20D RID: 41485 RVA: 0x000EF4B0 File Offset: 0x000ED6B0
		public ULTweenBPLibrary() : this(BuiltinUtils.AllocNativeUObject(ULTweenBPLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A20E RID: 41486 RVA: 0x000EF4D8 File Offset: 0x000ED6D8
		[NullableContext(1)]
		public ULTweenBPLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULTweenBPLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600A20F RID: 41487 RVA: 0x000EF50C File Offset: 0x000ED70C
		public static ULTweener WorldRotatorTo_Sweep(USceneComponent target, FRotator endValue, bool shortestPath, ref FHitResult sweepHitResult, bool sweep, bool teleport, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__WorldRotatorTo_Sweep_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, shortestPath, (sweepHitResult ?? new FHitResult()).NativePtr, sweep, teleport, duration, delay, ease));
		}

		// Token: 0x0600A210 RID: 41488 RVA: 0x000EF54F File Offset: 0x000ED74F
		public static ULTweener WorldRotatorTo(USceneComponent target, FRotator endValue, bool shortestPath, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__WorldRotatorTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, shortestPath, duration, delay, ease));
		}

		// Token: 0x0600A211 RID: 41489 RVA: 0x000EF574 File Offset: 0x000ED774
		public unsafe static ULTweener WorldRotationQuaternionTo_Sweep(USceneComponent target, in FQuat endValue, ref FHitResult sweepHitResult, bool sweep, bool teleport, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = endValue;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__WorldRotationQuaternionTo_Sweep_Internal((target != null) ? target.NativePtr : IntPtr.Zero, ptr, (sweepHitResult ?? new FHitResult()).NativePtr, sweep, teleport, duration, delay, ease));
		}

		// Token: 0x0600A212 RID: 41490 RVA: 0x000EF5D4 File Offset: 0x000ED7D4
		public unsafe static ULTweener WorldRotationQuaternionTo(USceneComponent target, in FQuat endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = endValue;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__WorldRotationQuaternionTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, ptr, duration, delay, ease));
		}

		// Token: 0x0600A213 RID: 41491 RVA: 0x000EF61C File Offset: 0x000ED81C
		public static ULTweener WorldRotateEulerAngleTo_Sweep(USceneComponent target, FVector eulerAngle, ref FHitResult sweepHitResult, bool sweep, bool teleport, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__WorldRotateEulerAngleTo_Sweep_Internal((target != null) ? target.NativePtr : IntPtr.Zero, eulerAngle, (sweepHitResult ?? new FHitResult()).NativePtr, sweep, teleport, duration, delay, ease));
		}

		// Token: 0x0600A214 RID: 41492 RVA: 0x000EF652 File Offset: 0x000ED852
		public static ULTweener WorldRotateEulerAngleTo(USceneComponent target, FVector eulerAngle, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__WorldRotateEulerAngleTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, eulerAngle, duration, delay, ease));
		}

		// Token: 0x0600A215 RID: 41493 RVA: 0x000EF673 File Offset: 0x000ED873
		public static ULTweener WorldPositionZTo_Sweep(USceneComponent target, float endValue, ref FHitResult sweepHitResult, bool sweep, bool teleport, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__WorldPositionZTo_Sweep_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, (sweepHitResult ?? new FHitResult()).NativePtr, sweep, teleport, duration, delay, ease));
		}

		// Token: 0x0600A216 RID: 41494 RVA: 0x000EF6A9 File Offset: 0x000ED8A9
		public static ULTweener WorldPositionZTo(USceneComponent target, float endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__WorldPositionZTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, duration, delay, ease));
		}

		// Token: 0x0600A217 RID: 41495 RVA: 0x000EF6CA File Offset: 0x000ED8CA
		public static ULTweener WorldPositionYTo_Sweep(USceneComponent target, float endValue, ref FHitResult sweepHitResult, bool sweep, bool teleport, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__WorldPositionYTo_Sweep_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, (sweepHitResult ?? new FHitResult()).NativePtr, sweep, teleport, duration, delay, ease));
		}

		// Token: 0x0600A218 RID: 41496 RVA: 0x000EF700 File Offset: 0x000ED900
		public static ULTweener WorldPositionYTo(USceneComponent target, float endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__WorldPositionYTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, duration, delay, ease));
		}

		// Token: 0x0600A219 RID: 41497 RVA: 0x000EF721 File Offset: 0x000ED921
		public static ULTweener WorldPositionXTo_Sweep(USceneComponent target, float endValue, ref FHitResult sweepHitResult, bool sweep, bool teleport, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__WorldPositionXTo_Sweep_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, (sweepHitResult ?? new FHitResult()).NativePtr, sweep, teleport, duration, delay, ease));
		}

		// Token: 0x0600A21A RID: 41498 RVA: 0x000EF757 File Offset: 0x000ED957
		public static ULTweener WorldPositionXTo(USceneComponent target, float endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__WorldPositionXTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, duration, delay, ease));
		}

		// Token: 0x0600A21B RID: 41499 RVA: 0x000EF778 File Offset: 0x000ED978
		public static ULTweener WorldPositionTo_Sweep(USceneComponent target, FVector endValue, ref FHitResult sweepHitResult, bool sweep, bool teleport, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__WorldPositionTo_Sweep_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, (sweepHitResult ?? new FHitResult()).NativePtr, sweep, teleport, duration, delay, ease));
		}

		// Token: 0x0600A21C RID: 41500 RVA: 0x000EF7AE File Offset: 0x000ED9AE
		public static ULTweener WorldPositionTo(USceneComponent target, FVector endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__WorldPositionTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, duration, delay, ease));
		}

		// Token: 0x0600A21D RID: 41501 RVA: 0x000EF7D0 File Offset: 0x000ED9D0
		public static ULTweener VirtualCall(UObject WorldContextObject, float duration, float delay, FTweenerSimpleDynamicDelegate start, FTweenerFloatDynamicDelegate update, FTweenerSimpleDynamicDelegate complete)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__VirtualCall_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, duration, delay, (start != null) ? start.NativePtr : ((IntPtr)0), (update != null) ? update.NativePtr : ((IntPtr)0), (complete != null) ? complete.NativePtr : ((IntPtr)0)));
		}

		// Token: 0x0600A21E RID: 41502 RVA: 0x000EF824 File Offset: 0x000EDA24
		public unsafe static ULTweener Vector4To(UObject WorldContextObject, FLTweenVector4SetterDynamic setter, FVector4 startValue, FVector4 endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = startValue;
			ref FVector4 ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = endValue;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__Vector4To_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (setter != null) ? setter.NativePtr : ((IntPtr)0), ptr, ptr2, duration, delay, ease));
		}

		// Token: 0x0600A21F RID: 41503 RVA: 0x000EF88E File Offset: 0x000EDA8E
		public static ULTweener Vector3To(UObject WorldContextObject, FLTweenVector3SetterDynamic setter, FVector startValue, FVector endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__Vector3To_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (setter != null) ? setter.NativePtr : ((IntPtr)0), startValue, endValue, duration, delay, ease));
		}

		// Token: 0x0600A220 RID: 41504 RVA: 0x000EF8BF File Offset: 0x000EDABF
		public static ULTweener Vector2To(UObject WorldContextObject, FLTweenVector2SetterDynamic setter, FVector2D startValue, FVector2D endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__Vector2To_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (setter != null) ? setter.NativePtr : ((IntPtr)0), startValue, endValue, duration, delay, ease));
		}

		// Token: 0x0600A221 RID: 41505 RVA: 0x000EF8F0 File Offset: 0x000EDAF0
		public static ULTweener RotatorTo(UObject WorldContextObject, FLTweenRotatorSetterDynamic setter, FRotator startValue, FRotator endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__RotatorTo_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (setter != null) ? setter.NativePtr : ((IntPtr)0), startValue, endValue, duration, delay, ease));
		}

		// Token: 0x0600A222 RID: 41506 RVA: 0x000EF924 File Offset: 0x000EDB24
		public unsafe static ULTweener QuaternionTo(UObject WorldContextObject, FLTweenQuaternionSetterDynamic setter, FQuat startValue, FQuat endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = startValue;
			ref FQuat ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = endValue;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__QuaternionTo_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (setter != null) ? setter.NativePtr : ((IntPtr)0), ptr, ptr2, duration, delay, ease));
		}

		// Token: 0x0600A223 RID: 41507 RVA: 0x000EF98E File Offset: 0x000EDB8E
		public static ULTweener MeshMaterialVectorParameterTo(UMeshComponent target, int materialIndex, FName parameterName, FLinearColor endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__MeshMaterialVectorParameterTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, materialIndex, parameterName, endValue, duration, delay, ease));
		}

		// Token: 0x0600A224 RID: 41508 RVA: 0x000EF9B3 File Offset: 0x000EDBB3
		public static ULTweener MeshMaterialScalarParameterTo(UMeshComponent target, int materialIndex, FName parameterName, float endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__MeshMaterialScalarParameterTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, materialIndex, parameterName, endValue, duration, delay, ease));
		}

		// Token: 0x0600A225 RID: 41509 RVA: 0x000EF9D8 File Offset: 0x000EDBD8
		public static ULTweener MaterialVectorParameterTo(UMaterialInstanceDynamic target, FName parameterName, FLinearColor endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__MaterialVectorParameterTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, parameterName, endValue, duration, delay, ease));
		}

		// Token: 0x0600A226 RID: 41510 RVA: 0x000EF9FB File Offset: 0x000EDBFB
		public static ULTweener MaterialScalarParameterTo(UMaterialInstanceDynamic target, FName parameterName, float endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__MaterialScalarParameterTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, parameterName, endValue, duration, delay, ease));
		}

		// Token: 0x0600A227 RID: 41511 RVA: 0x000EFA20 File Offset: 0x000EDC20
		public static ULTweener LocalScaleTo(USceneComponent target, FVector? endValue = null, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__LocalScaleTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue ?? new FVector(1f, 1f, 1f), duration, delay, ease));
		}

		// Token: 0x0600A228 RID: 41512 RVA: 0x000EFA74 File Offset: 0x000EDC74
		public static ULTweener LocalRotatorTo_Sweep(USceneComponent target, FRotator endValue, bool shortestPath, ref FHitResult sweepHitResult, bool sweep, bool teleport, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__LocalRotatorTo_Sweep_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, shortestPath, (sweepHitResult ?? new FHitResult()).NativePtr, sweep, teleport, duration, delay, ease));
		}

		// Token: 0x0600A229 RID: 41513 RVA: 0x000EFAB7 File Offset: 0x000EDCB7
		public static ULTweener LocalRotatorTo(USceneComponent target, FRotator endValue, bool shortestPath, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__LocalRotatorTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, shortestPath, duration, delay, ease));
		}

		// Token: 0x0600A22A RID: 41514 RVA: 0x000EFADC File Offset: 0x000EDCDC
		public unsafe static ULTweener LocalRotationQuaternionTo_Sweep(USceneComponent target, in FQuat endValue, ref FHitResult sweepHitResult, bool sweep, bool teleport, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = endValue;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__LocalRotationQuaternionTo_Sweep_Internal((target != null) ? target.NativePtr : IntPtr.Zero, ptr, (sweepHitResult ?? new FHitResult()).NativePtr, sweep, teleport, duration, delay, ease));
		}

		// Token: 0x0600A22B RID: 41515 RVA: 0x000EFB3C File Offset: 0x000EDD3C
		public unsafe static ULTweener LocalRotationQuaternionTo(USceneComponent target, in FQuat endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = endValue;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__LocalRotationQuaternionTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, ptr, duration, delay, ease));
		}

		// Token: 0x0600A22C RID: 41516 RVA: 0x000EFB84 File Offset: 0x000EDD84
		public static ULTweener LocalRotateEulerAngleTo_Sweep(USceneComponent target, FVector eulerAngle, ref FHitResult sweepHitResult, bool sweep, bool teleport, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__LocalRotateEulerAngleTo_Sweep_Internal((target != null) ? target.NativePtr : IntPtr.Zero, eulerAngle, (sweepHitResult ?? new FHitResult()).NativePtr, sweep, teleport, duration, delay, ease));
		}

		// Token: 0x0600A22D RID: 41517 RVA: 0x000EFBBA File Offset: 0x000EDDBA
		public static ULTweener LocalRotateEulerAngleTo(USceneComponent target, FVector eulerAngle, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__LocalRotateEulerAngleTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, eulerAngle, duration, delay, ease));
		}

		// Token: 0x0600A22E RID: 41518 RVA: 0x000EFBDB File Offset: 0x000EDDDB
		public static ULTweener LocalPositionZTo_Sweep(USceneComponent target, float endValue, ref FHitResult sweepHitResult, bool sweep, bool teleport, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__LocalPositionZTo_Sweep_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, (sweepHitResult ?? new FHitResult()).NativePtr, sweep, teleport, duration, delay, ease));
		}

		// Token: 0x0600A22F RID: 41519 RVA: 0x000EFC11 File Offset: 0x000EDE11
		public static ULTweener LocalPositionZTo(USceneComponent target, float endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__LocalPositionZTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, duration, delay, ease));
		}

		// Token: 0x0600A230 RID: 41520 RVA: 0x000EFC32 File Offset: 0x000EDE32
		public static ULTweener LocalPositionYTo_Sweep(USceneComponent target, float endValue, ref FHitResult sweepHitResult, bool sweep, bool teleport, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__LocalPositionYTo_Sweep_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, (sweepHitResult ?? new FHitResult()).NativePtr, sweep, teleport, duration, delay, ease));
		}

		// Token: 0x0600A231 RID: 41521 RVA: 0x000EFC68 File Offset: 0x000EDE68
		public static ULTweener LocalPositionYTo(USceneComponent target, float endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__LocalPositionYTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, duration, delay, ease));
		}

		// Token: 0x0600A232 RID: 41522 RVA: 0x000EFC89 File Offset: 0x000EDE89
		public static ULTweener LocalPositionXTo_Sweep(USceneComponent target, float endValue, ref FHitResult sweepHitResult, bool sweep, bool teleport, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__LocalPositionXTo_Sweep_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, (sweepHitResult ?? new FHitResult()).NativePtr, sweep, teleport, duration, delay, ease));
		}

		// Token: 0x0600A233 RID: 41523 RVA: 0x000EFCBF File Offset: 0x000EDEBF
		public static ULTweener LocalPositionXTo(USceneComponent target, float endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__LocalPositionXTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, duration, delay, ease));
		}

		// Token: 0x0600A234 RID: 41524 RVA: 0x000EFCE0 File Offset: 0x000EDEE0
		public static ULTweener LocalPositionTo_Sweep(USceneComponent target, FVector endValue, ref FHitResult sweepHitResult, bool sweep, bool teleport, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__LocalPositionTo_Sweep_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, (sweepHitResult ?? new FHitResult()).NativePtr, sweep, teleport, duration, delay, ease));
		}

		// Token: 0x0600A235 RID: 41525 RVA: 0x000EFD16 File Offset: 0x000EDF16
		public static ULTweener LocalPositionTo(USceneComponent target, FVector endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__LocalPositionTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, duration, delay, ease));
		}

		// Token: 0x0600A236 RID: 41526 RVA: 0x000EFD37 File Offset: 0x000EDF37
		public static ULTweener LinearColorTo(UObject WorldContextObject, FLTweenLinearColorSetterDynamic setter, FLinearColor startValue, FLinearColor endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__LinearColorTo_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (setter != null) ? setter.NativePtr : ((IntPtr)0), startValue, endValue, duration, delay, ease));
		}

		// Token: 0x0600A237 RID: 41527 RVA: 0x000EFD68 File Offset: 0x000EDF68
		public static void KillIfIsTweening(UObject WorldContextObject, ULTweener inTweener, bool callComplete = false)
		{
			ULTweenBPLibrary.__KillIfIsTweening_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (inTweener != null) ? inTweener.NativePtr : IntPtr.Zero, callComplete);
		}

		// Token: 0x0600A238 RID: 41528 RVA: 0x000EFD90 File Offset: 0x000EDF90
		public static bool IsTweening(UObject WorldContextObject, ULTweener inTweener)
		{
			return ULTweenBPLibrary.__IsTweening_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (inTweener != null) ? inTweener.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600A239 RID: 41529 RVA: 0x000EFDB7 File Offset: 0x000EDFB7
		public static ULTweener IntTo(UObject WorldContextObject, FLTweenIntSetterDynamic setter, int startValue, int endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__IntTo_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (setter != null) ? setter.NativePtr : ((IntPtr)0), startValue, endValue, duration, delay, ease));
		}

		// Token: 0x0600A23A RID: 41530 RVA: 0x000EFDE8 File Offset: 0x000EDFE8
		public static ULTweener FloatTo(UObject WorldContextObject, FLTweenFloatSetterDynamic setter, float startValue = 0f, float endValue = 1f, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__FloatTo_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (setter != null) ? setter.NativePtr : ((IntPtr)0), startValue, endValue, duration, delay, ease));
		}

		// Token: 0x0600A23B RID: 41531 RVA: 0x000EFE19 File Offset: 0x000EE019
		public static ULTweener DelayFrameCall(UObject WorldContextObject, int frameCount, FTweenerSimpleDynamicDelegate delayComplete)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__DelayFrameCall_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, frameCount, (delayComplete != null) ? delayComplete.NativePtr : ((IntPtr)0)));
		}

		// Token: 0x0600A23C RID: 41532 RVA: 0x000EFE43 File Offset: 0x000EE043
		public static ULTweener DelayCall(UObject WorldContextObject, float delayTime, FTweenerSimpleDynamicDelegate delayComplete)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__DelayCall_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, delayTime, (delayComplete != null) ? delayComplete.NativePtr : ((IntPtr)0)));
		}

		// Token: 0x0600A23D RID: 41533 RVA: 0x000EFE6D File Offset: 0x000EE06D
		public static ULTweener ColorTo(UObject WorldContextObject, FLTweenColorSetterDynamic setter, FColor startValue, FColor endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULTweenBPLibrary.__ColorTo_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (setter != null) ? setter.NativePtr : ((IntPtr)0), startValue, endValue, duration, delay, ease));
		}

		// Token: 0x0600A23E RID: 41534 RVA: 0x000EFE9E File Offset: 0x000EE09E
		public static void ArrayKillIfIsTweening(UObject WorldContextObject, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<ULTweener> inTweenerArray, bool callComplete = false)
		{
			ULTweenBPLibrary.__ArrayKillIfIsTweening_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (inTweenerArray ?? new TArray<ULTweener>()).NativePtr, callComplete);
		}

		// Token: 0x0600A23F RID: 41535
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WorldRotatorTo_Sweep_Internal(IntPtr target, FRotator endValue, bool shortestPath, IntPtr sweepHitResult, bool sweep, bool teleport, float duration, float delay, LTweenEase ease);

		// Token: 0x0600A240 RID: 41536
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WorldRotatorTo_Internal(IntPtr target, FRotator endValue, bool shortestPath, float duration, float delay, LTweenEase ease);

		// Token: 0x0600A241 RID: 41537
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WorldRotationQuaternionTo_Sweep_Internal(IntPtr target, in FQuat endValue, IntPtr sweepHitResult, bool sweep, bool teleport, float duration, float delay, LTweenEase ease);

		// Token: 0x0600A242 RID: 41538
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WorldRotationQuaternionTo_Internal(IntPtr target, in FQuat endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x0600A243 RID: 41539
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WorldRotateEulerAngleTo_Sweep_Internal(IntPtr target, FVector eulerAngle, IntPtr sweepHitResult, bool sweep, bool teleport, float duration, float delay, LTweenEase ease);

		// Token: 0x0600A244 RID: 41540
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WorldRotateEulerAngleTo_Internal(IntPtr target, FVector eulerAngle, float duration, float delay, LTweenEase ease);

		// Token: 0x0600A245 RID: 41541
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WorldPositionZTo_Sweep_Internal(IntPtr target, float endValue, IntPtr sweepHitResult, bool sweep, bool teleport, float duration, float delay, LTweenEase ease);

		// Token: 0x0600A246 RID: 41542
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WorldPositionZTo_Internal(IntPtr target, float endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x0600A247 RID: 41543
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WorldPositionYTo_Sweep_Internal(IntPtr target, float endValue, IntPtr sweepHitResult, bool sweep, bool teleport, float duration, float delay, LTweenEase ease);

		// Token: 0x0600A248 RID: 41544
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WorldPositionYTo_Internal(IntPtr target, float endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x0600A249 RID: 41545
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WorldPositionXTo_Sweep_Internal(IntPtr target, float endValue, IntPtr sweepHitResult, bool sweep, bool teleport, float duration, float delay, LTweenEase ease);

		// Token: 0x0600A24A RID: 41546
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WorldPositionXTo_Internal(IntPtr target, float endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x0600A24B RID: 41547
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WorldPositionTo_Sweep_Internal(IntPtr target, FVector endValue, IntPtr sweepHitResult, bool sweep, bool teleport, float duration, float delay, LTweenEase ease);

		// Token: 0x0600A24C RID: 41548
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WorldPositionTo_Internal(IntPtr target, FVector endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x0600A24D RID: 41549
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __VirtualCall_Internal(IntPtr WorldContextObject, float duration, float delay, IntPtr start, IntPtr update, IntPtr complete);

		// Token: 0x0600A24E RID: 41550
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Vector4To_Internal(IntPtr WorldContextObject, IntPtr setter, in FVector4 startValue, in FVector4 endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x0600A24F RID: 41551
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Vector3To_Internal(IntPtr WorldContextObject, IntPtr setter, FVector startValue, FVector endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x0600A250 RID: 41552
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Vector2To_Internal(IntPtr WorldContextObject, IntPtr setter, FVector2D startValue, FVector2D endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x0600A251 RID: 41553
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RotatorTo_Internal(IntPtr WorldContextObject, IntPtr setter, FRotator startValue, FRotator endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x0600A252 RID: 41554
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __QuaternionTo_Internal(IntPtr WorldContextObject, IntPtr setter, in FQuat startValue, in FQuat endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x0600A253 RID: 41555
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MeshMaterialVectorParameterTo_Internal(IntPtr target, int materialIndex, FName parameterName, FLinearColor endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x0600A254 RID: 41556
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MeshMaterialScalarParameterTo_Internal(IntPtr target, int materialIndex, FName parameterName, float endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x0600A255 RID: 41557
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MaterialVectorParameterTo_Internal(IntPtr target, FName parameterName, FLinearColor endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x0600A256 RID: 41558
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MaterialScalarParameterTo_Internal(IntPtr target, FName parameterName, float endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x0600A257 RID: 41559
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LocalScaleTo_Internal(IntPtr target, FVector endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x0600A258 RID: 41560
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LocalRotatorTo_Sweep_Internal(IntPtr target, FRotator endValue, bool shortestPath, IntPtr sweepHitResult, bool sweep, bool teleport, float duration, float delay, LTweenEase ease);

		// Token: 0x0600A259 RID: 41561
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LocalRotatorTo_Internal(IntPtr target, FRotator endValue, bool shortestPath, float duration, float delay, LTweenEase ease);

		// Token: 0x0600A25A RID: 41562
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LocalRotationQuaternionTo_Sweep_Internal(IntPtr target, in FQuat endValue, IntPtr sweepHitResult, bool sweep, bool teleport, float duration, float delay, LTweenEase ease);

		// Token: 0x0600A25B RID: 41563
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LocalRotationQuaternionTo_Internal(IntPtr target, in FQuat endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x0600A25C RID: 41564
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LocalRotateEulerAngleTo_Sweep_Internal(IntPtr target, FVector eulerAngle, IntPtr sweepHitResult, bool sweep, bool teleport, float duration, float delay, LTweenEase ease);

		// Token: 0x0600A25D RID: 41565
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LocalRotateEulerAngleTo_Internal(IntPtr target, FVector eulerAngle, float duration, float delay, LTweenEase ease);

		// Token: 0x0600A25E RID: 41566
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LocalPositionZTo_Sweep_Internal(IntPtr target, float endValue, IntPtr sweepHitResult, bool sweep, bool teleport, float duration, float delay, LTweenEase ease);

		// Token: 0x0600A25F RID: 41567
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LocalPositionZTo_Internal(IntPtr target, float endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x0600A260 RID: 41568
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LocalPositionYTo_Sweep_Internal(IntPtr target, float endValue, IntPtr sweepHitResult, bool sweep, bool teleport, float duration, float delay, LTweenEase ease);

		// Token: 0x0600A261 RID: 41569
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LocalPositionYTo_Internal(IntPtr target, float endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x0600A262 RID: 41570
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LocalPositionXTo_Sweep_Internal(IntPtr target, float endValue, IntPtr sweepHitResult, bool sweep, bool teleport, float duration, float delay, LTweenEase ease);

		// Token: 0x0600A263 RID: 41571
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LocalPositionXTo_Internal(IntPtr target, float endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x0600A264 RID: 41572
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LocalPositionTo_Sweep_Internal(IntPtr target, FVector endValue, IntPtr sweepHitResult, bool sweep, bool teleport, float duration, float delay, LTweenEase ease);

		// Token: 0x0600A265 RID: 41573
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LocalPositionTo_Internal(IntPtr target, FVector endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x0600A266 RID: 41574
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LinearColorTo_Internal(IntPtr WorldContextObject, IntPtr setter, FLinearColor startValue, FLinearColor endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x0600A267 RID: 41575
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KillIfIsTweening_Internal(IntPtr WorldContextObject, IntPtr inTweener, bool callComplete);

		// Token: 0x0600A268 RID: 41576
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsTweening_Internal(IntPtr WorldContextObject, IntPtr inTweener);

		// Token: 0x0600A269 RID: 41577
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __IntTo_Internal(IntPtr WorldContextObject, IntPtr setter, int startValue, int endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x0600A26A RID: 41578
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FloatTo_Internal(IntPtr WorldContextObject, IntPtr setter, float startValue, float endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x0600A26B RID: 41579
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __DelayFrameCall_Internal(IntPtr WorldContextObject, int frameCount, IntPtr delayComplete);

		// Token: 0x0600A26C RID: 41580
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __DelayCall_Internal(IntPtr WorldContextObject, float delayTime, IntPtr delayComplete);

		// Token: 0x0600A26D RID: 41581
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __ColorTo_Internal(IntPtr WorldContextObject, IntPtr setter, FColor startValue, FColor endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x0600A26E RID: 41582
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ArrayKillIfIsTweening_Internal(IntPtr WorldContextObject, IntPtr inTweenerArray, bool callComplete);

		// Token: 0x0600A26F RID: 41583 RVA: 0x000EFEC6 File Offset: 0x000EE0C6
		static ULTweenBPLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LTween.LTweenBPLibrary");
		}

		// Token: 0x0600A270 RID: 41584 RVA: 0x000EFED4 File Offset: 0x000EE0D4
		protected ULTweenBPLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004566 RID: 17766
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LTween.LTweenBPLibrary";

		// Token: 0x04004567 RID: 17767
		private static IntPtr _ClassPtr;

		// Token: 0x04004568 RID: 17768
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
