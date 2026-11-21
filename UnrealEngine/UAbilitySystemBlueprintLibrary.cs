using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002BA RID: 698
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AbilitySystemBlueprintLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UAbilitySystemBlueprintLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004C57 RID: 19543 RVA: 0x0006B14A File Offset: 0x0006934A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilitySystemBlueprintLibrary._ClassPtr;
		}

		// Token: 0x06004C58 RID: 19544 RVA: 0x0006B158 File Offset: 0x00069358
		public UAbilitySystemBlueprintLibrary() : this(BuiltinUtils.AllocNativeUObject(UAbilitySystemBlueprintLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004C59 RID: 19545 RVA: 0x0006B180 File Offset: 0x00069380
		[NullableContext(1)]
		public UAbilitySystemBlueprintLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilitySystemBlueprintLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06004C5A RID: 19546 RVA: 0x0006B1B3 File Offset: 0x000693B3
		public static void SendGameplayEventToActor(AActor Actor, FGameplayTag EventTag, FGameplayEventData Payload)
		{
			UAbilitySystemBlueprintLibrary.__SendGameplayEventToActor_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, EventTag, (Payload ?? new FGameplayEventData()).NativePtr);
		}

		// Token: 0x06004C5B RID: 19547 RVA: 0x0006B1DA File Offset: 0x000693DA
		public static float GetActiveGameplayEffectTotalDuration(FActiveGameplayEffectHandle ActiveHandle)
		{
			return UAbilitySystemBlueprintLibrary.__GetActiveGameplayEffectTotalDuration_Internal((ActiveHandle ?? new FActiveGameplayEffectHandle()).NativePtr);
		}

		// Token: 0x06004C5C RID: 19548 RVA: 0x0006B1F0 File Offset: 0x000693F0
		public static float GetActiveGameplayEffectStartTime(FActiveGameplayEffectHandle ActiveHandle)
		{
			return UAbilitySystemBlueprintLibrary.__GetActiveGameplayEffectStartTime_Internal((ActiveHandle ?? new FActiveGameplayEffectHandle()).NativePtr);
		}

		// Token: 0x06004C5D RID: 19549 RVA: 0x0006B206 File Offset: 0x00069406
		public static int GetActiveGameplayEffectStackLimitCount(FActiveGameplayEffectHandle ActiveHandle)
		{
			return UAbilitySystemBlueprintLibrary.__GetActiveGameplayEffectStackLimitCount_Internal((ActiveHandle ?? new FActiveGameplayEffectHandle()).NativePtr);
		}

		// Token: 0x06004C5E RID: 19550 RVA: 0x0006B21C File Offset: 0x0006941C
		public static int GetActiveGameplayEffectStackCount(FActiveGameplayEffectHandle ActiveHandle)
		{
			return UAbilitySystemBlueprintLibrary.__GetActiveGameplayEffectStackCount_Internal((ActiveHandle ?? new FActiveGameplayEffectHandle()).NativePtr);
		}

		// Token: 0x06004C5F RID: 19551 RVA: 0x0006B232 File Offset: 0x00069432
		public static float GetActiveGameplayEffectRemainingDuration(UObject WorldContextObject, FActiveGameplayEffectHandle ActiveHandle)
		{
			return UAbilitySystemBlueprintLibrary.__GetActiveGameplayEffectRemainingDuration_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (ActiveHandle ?? new FActiveGameplayEffectHandle()).NativePtr);
		}

		// Token: 0x06004C60 RID: 19552 RVA: 0x0006B258 File Offset: 0x00069458
		public static float GetActiveGameplayEffectExpectedEndTime(FActiveGameplayEffectHandle ActiveHandle)
		{
			return UAbilitySystemBlueprintLibrary.__GetActiveGameplayEffectExpectedEndTime_Internal((ActiveHandle ?? new FActiveGameplayEffectHandle()).NativePtr);
		}

		// Token: 0x06004C61 RID: 19553 RVA: 0x0006B26E File Offset: 0x0006946E
		[NullableContext(1)]
		public static string GetActiveGameplayEffectDebugString([Nullable(2)] FActiveGameplayEffectHandle ActiveHandle)
		{
			return FString.ToStringAndDeleteNativePtr(UAbilitySystemBlueprintLibrary.__GetActiveGameplayEffectDebugString_Internal((ActiveHandle ?? new FActiveGameplayEffectHandle()).NativePtr));
		}

		// Token: 0x06004C62 RID: 19554 RVA: 0x0006B289 File Offset: 0x00069489
		public static UAbilitySystemComponent GetAbilitySystemComponent(AActor Actor)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilitySystemComponent>(UAbilitySystemBlueprintLibrary.__GetAbilitySystemComponent_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06004C63 RID: 19555
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SendGameplayEventToActor_Internal(IntPtr Actor, FGameplayTag EventTag, IntPtr Payload);

		// Token: 0x06004C64 RID: 19556
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetActiveGameplayEffectTotalDuration_Internal(IntPtr ActiveHandle);

		// Token: 0x06004C65 RID: 19557
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetActiveGameplayEffectStartTime_Internal(IntPtr ActiveHandle);

		// Token: 0x06004C66 RID: 19558
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetActiveGameplayEffectStackLimitCount_Internal(IntPtr ActiveHandle);

		// Token: 0x06004C67 RID: 19559
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetActiveGameplayEffectStackCount_Internal(IntPtr ActiveHandle);

		// Token: 0x06004C68 RID: 19560
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetActiveGameplayEffectRemainingDuration_Internal(IntPtr WorldContextObject, IntPtr ActiveHandle);

		// Token: 0x06004C69 RID: 19561
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetActiveGameplayEffectExpectedEndTime_Internal(IntPtr ActiveHandle);

		// Token: 0x06004C6A RID: 19562
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetActiveGameplayEffectDebugString_Internal(IntPtr ActiveHandle);

		// Token: 0x06004C6B RID: 19563
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAbilitySystemComponent_Internal(IntPtr Actor);

		// Token: 0x06004C6C RID: 19564 RVA: 0x0006B2A5 File Offset: 0x000694A5
		static UAbilitySystemBlueprintLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilitySystemBlueprintLibrary");
		}

		// Token: 0x06004C6D RID: 19565 RVA: 0x0006B2B3 File Offset: 0x000694B3
		protected UAbilitySystemBlueprintLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001E89 RID: 7817
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilitySystemBlueprintLibrary";

		// Token: 0x04001E8A RID: 7818
		private static IntPtr _ClassPtr;

		// Token: 0x04001E8B RID: 7819
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
