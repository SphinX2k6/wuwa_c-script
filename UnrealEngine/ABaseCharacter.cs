using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000431 RID: 1073
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGAS.BaseCharacter")]
	[UnrealStructLayout(2016, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2016)]
	public class ABaseCharacter : ACharacter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006809 RID: 26633 RVA: 0x00097FE4 File Offset: 0x000961E4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ABaseCharacter._ClassPtr;
		}

		// Token: 0x0600680A RID: 26634 RVA: 0x00097FF0 File Offset: 0x000961F0
		public ABaseCharacter() : this(BuiltinUtils.AllocNativeUObject(ABaseCharacter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600680B RID: 26635 RVA: 0x00098018 File Offset: 0x00096218
		[NullableContext(1)]
		public ABaseCharacter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABaseCharacter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170014EF RID: 5359
		// (get) Token: 0x0600680C RID: 26636 RVA: 0x0009804B File Offset: 0x0009624B
		// (set) Token: 0x0600680D RID: 26637 RVA: 0x0009805F File Offset: 0x0009625F
		public unsafe FVectorDouble CachedActorLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABaseCharacter.__PropertyOffset_CachedActorLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABaseCharacter.__PropertyOffset_CachedActorLocation) = value;
			}
		}

		// Token: 0x170014F0 RID: 5360
		// (get) Token: 0x0600680E RID: 26638 RVA: 0x00098074 File Offset: 0x00096274
		// (set) Token: 0x0600680F RID: 26639 RVA: 0x00098088 File Offset: 0x00096288
		public unsafe FRotator CachedActorRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABaseCharacter.__PropertyOffset_CachedActorRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABaseCharacter.__PropertyOffset_CachedActorRotation) = value;
			}
		}

		// Token: 0x170014F1 RID: 5361
		// (get) Token: 0x06006810 RID: 26640 RVA: 0x0009809D File Offset: 0x0009629D
		// (set) Token: 0x06006811 RID: 26641 RVA: 0x000980B1 File Offset: 0x000962B1
		public unsafe FQuat CachedActorQuat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABaseCharacter.__PropertyOffset_CachedActorQuat);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABaseCharacter.__PropertyOffset_CachedActorQuat) = value;
			}
		}

		// Token: 0x170014F2 RID: 5362
		// (get) Token: 0x06006812 RID: 26642 RVA: 0x000980C6 File Offset: 0x000962C6
		// (set) Token: 0x06006813 RID: 26643 RVA: 0x000980DA File Offset: 0x000962DA
		public unsafe FVector CachedActorScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABaseCharacter.__PropertyOffset_CachedActorScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABaseCharacter.__PropertyOffset_CachedActorScale) = value;
			}
		}

		// Token: 0x170014F3 RID: 5363
		// (get) Token: 0x06006814 RID: 26644 RVA: 0x000980EF File Offset: 0x000962EF
		// (set) Token: 0x06006815 RID: 26645 RVA: 0x00098103 File Offset: 0x00096303
		public unsafe FTransformDouble CachedActorTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABaseCharacter.__PropertyOffset_CachedActorTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABaseCharacter.__PropertyOffset_CachedActorTransform) = value;
			}
		}

		// Token: 0x170014F4 RID: 5364
		// (get) Token: 0x06006816 RID: 26646 RVA: 0x00098118 File Offset: 0x00096318
		// (set) Token: 0x06006817 RID: 26647 RVA: 0x0009812C File Offset: 0x0009632C
		public unsafe FVector CachedActorUp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABaseCharacter.__PropertyOffset_CachedActorUp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABaseCharacter.__PropertyOffset_CachedActorUp) = value;
			}
		}

		// Token: 0x170014F5 RID: 5365
		// (get) Token: 0x06006818 RID: 26648 RVA: 0x00098141 File Offset: 0x00096341
		// (set) Token: 0x06006819 RID: 26649 RVA: 0x00098155 File Offset: 0x00096355
		public unsafe FVector CachedActorForward
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABaseCharacter.__PropertyOffset_CachedActorForward);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABaseCharacter.__PropertyOffset_CachedActorForward) = value;
			}
		}

		// Token: 0x170014F6 RID: 5366
		// (get) Token: 0x0600681A RID: 26650 RVA: 0x0009816A File Offset: 0x0009636A
		// (set) Token: 0x0600681B RID: 26651 RVA: 0x0009817E File Offset: 0x0009637E
		public unsafe FVector CachedActorVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABaseCharacter.__PropertyOffset_CachedActorVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABaseCharacter.__PropertyOffset_CachedActorVelocity) = value;
			}
		}

		// Token: 0x170014F7 RID: 5367
		// (get) Token: 0x0600681C RID: 26652 RVA: 0x00098193 File Offset: 0x00096393
		// (set) Token: 0x0600681D RID: 26653 RVA: 0x000981A3 File Offset: 0x000963A3
		public unsafe int EntityIdInternal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABaseCharacter.__PropertyOffset_EntityIdInternal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABaseCharacter.__PropertyOffset_EntityIdInternal) = value;
			}
		}

		// Token: 0x170014F8 RID: 5368
		// (get) Token: 0x0600681E RID: 26654 RVA: 0x000981B4 File Offset: 0x000963B4
		// (set) Token: 0x0600681F RID: 26655 RVA: 0x000981C4 File Offset: 0x000963C4
		public unsafe bool bInitializeAttributes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABaseCharacter.__PropertyOffset_bInitializeAttributes) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABaseCharacter.__PropertyOffset_bInitializeAttributes) = (value ? 1 : 0);
			}
		}

		// Token: 0x170014F9 RID: 5369
		// (get) Token: 0x06006820 RID: 26656 RVA: 0x000981D5 File Offset: 0x000963D5
		// (set) Token: 0x06006821 RID: 26657 RVA: 0x000981E9 File Offset: 0x000963E9
		public unsafe UBaseAttributeSet AttributeSet
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBaseAttributeSet>(base.NativePtr / (IntPtr)sizeof(void*) + ABaseCharacter.__PropertyOffset_AttributeSet);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABaseCharacter.__PropertyOffset_AttributeSet, value);
			}
		}

		// Token: 0x170014FA RID: 5370
		// (get) Token: 0x06006822 RID: 26658 RVA: 0x000981FE File Offset: 0x000963FE
		// (set) Token: 0x06006823 RID: 26659 RVA: 0x00098212 File Offset: 0x00096412
		public unsafe UBaseAbilitySystemComponent AbilitySystemComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBaseAbilitySystemComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ABaseCharacter.__PropertyOffset_AbilitySystemComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABaseCharacter.__PropertyOffset_AbilitySystemComponent, value);
			}
		}

		// Token: 0x06006824 RID: 26660 RVA: 0x00098228 File Offset: 0x00096428
		public unsafe bool SetActorTransformExceptSkelMesh(in FTransformDouble NewTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport, bool bIgnoreOverlap)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = NewTransform;
			return ABaseCharacter.__SetActorTransformExceptSkelMesh_Internal(base.NativePtr, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport, bIgnoreOverlap);
		}

		// Token: 0x06006825 RID: 26661 RVA: 0x00098272 File Offset: 0x00096472
		public bool SetActorLocationAndRotationExceptSkelMesh(in FVectorDouble NewLocation, in FRotator NewRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport, bool bIgnoreOverlap)
		{
			return ABaseCharacter.__SetActorLocationAndRotationExceptSkelMesh_Internal(base.NativePtr, NewLocation, NewRotation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport, bIgnoreOverlap);
		}

		// Token: 0x06006826 RID: 26662 RVA: 0x00098297 File Offset: 0x00096497
		public void RefreshCachedVelocity()
		{
			ABaseCharacter.__RefreshCachedVelocity_Internal(base.NativePtr);
		}

		// Token: 0x06006827 RID: 26663 RVA: 0x000982A4 File Offset: 0x000964A4
		public void RefreshCachedTransform()
		{
			ABaseCharacter.__RefreshCachedTransform_Internal(base.NativePtr);
		}

		// Token: 0x06006828 RID: 26664 RVA: 0x000982B1 File Offset: 0x000964B1
		public void PreInit()
		{
			ABaseCharacter.__PreInit_Internal(base.NativePtr);
		}

		// Token: 0x06006829 RID: 26665 RVA: 0x000982BE File Offset: 0x000964BE
		public void InitializeAttributeSet()
		{
			ABaseCharacter.__InitializeAttributeSet_Internal(base.NativePtr);
		}

		// Token: 0x0600682A RID: 26666 RVA: 0x000982CB File Offset: 0x000964CB
		public void CreateAttribute()
		{
			ABaseCharacter.__CreateAttribute_Internal(base.NativePtr);
		}

		// Token: 0x0600682B RID: 26667 RVA: 0x000982D8 File Offset: 0x000964D8
		public bool ContainsTag(FGameplayTag TagToCheck)
		{
			return ABaseCharacter.__ContainsTag_Internal(base.NativePtr, TagToCheck);
		}

		// Token: 0x0600682C RID: 26668 RVA: 0x000982E6 File Offset: 0x000964E6
		public bool ContainsAnyTag(FGameplayTagContainer TagToCheck)
		{
			return ABaseCharacter.__ContainsAnyTag_Internal(base.NativePtr, (TagToCheck ?? new FGameplayTagContainer()).NativePtr);
		}

		// Token: 0x0600682D RID: 26669 RVA: 0x00098302 File Offset: 0x00096502
		public bool ContainsAllTag(FGameplayTagContainer TagToCheck)
		{
			return ABaseCharacter.__ContainsAllTag_Internal(base.NativePtr, (TagToCheck ?? new FGameplayTagContainer()).NativePtr);
		}

		// Token: 0x0600682E RID: 26670
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetActorTransformExceptSkelMesh_Internal(IntPtr @this, in FTransformDouble NewTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport, bool bIgnoreOverlap);

		// Token: 0x0600682F RID: 26671
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetActorLocationAndRotationExceptSkelMesh_Internal(IntPtr @this, in FVectorDouble NewLocation, in FRotator NewRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport, bool bIgnoreOverlap);

		// Token: 0x06006830 RID: 26672
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RefreshCachedVelocity_Internal(IntPtr @this);

		// Token: 0x06006831 RID: 26673
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RefreshCachedTransform_Internal(IntPtr @this);

		// Token: 0x06006832 RID: 26674
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PreInit_Internal(IntPtr @this);

		// Token: 0x06006833 RID: 26675
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitializeAttributeSet_Internal(IntPtr @this);

		// Token: 0x06006834 RID: 26676
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CreateAttribute_Internal(IntPtr @this);

		// Token: 0x06006835 RID: 26677
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ContainsTag_Internal(IntPtr @this, FGameplayTag TagToCheck);

		// Token: 0x06006836 RID: 26678
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ContainsAnyTag_Internal(IntPtr @this, IntPtr TagToCheck);

		// Token: 0x06006837 RID: 26679
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ContainsAllTag_Internal(IntPtr @this, IntPtr TagToCheck);

		// Token: 0x06006838 RID: 26680 RVA: 0x0009831E File Offset: 0x0009651E
		static ABaseCharacter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGAS.BaseCharacter");
		}

		// Token: 0x06006839 RID: 26681 RVA: 0x0009832C File Offset: 0x0009652C
		protected ABaseCharacter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002C82 RID: 11394
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGAS.BaseCharacter";

		// Token: 0x04002C83 RID: 11395
		private static IntPtr _ClassPtr;

		// Token: 0x04002C84 RID: 11396
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002C85 RID: 11397
		internal static int __PropertyOffset_CachedActorLocation;

		// Token: 0x04002C86 RID: 11398
		internal static int __PropertyOffset_CachedActorRotation;

		// Token: 0x04002C87 RID: 11399
		internal static int __PropertyOffset_CachedActorQuat;

		// Token: 0x04002C88 RID: 11400
		internal static int __PropertyOffset_CachedActorScale;

		// Token: 0x04002C89 RID: 11401
		internal static int __PropertyOffset_CachedActorTransform;

		// Token: 0x04002C8A RID: 11402
		internal static int __PropertyOffset_CachedActorUp;

		// Token: 0x04002C8B RID: 11403
		internal static int __PropertyOffset_CachedActorForward;

		// Token: 0x04002C8C RID: 11404
		internal static int __PropertyOffset_CachedActorVelocity;

		// Token: 0x04002C8D RID: 11405
		internal static int __PropertyOffset_EntityIdInternal;

		// Token: 0x04002C8E RID: 11406
		internal static int __PropertyOffset_bInitializeAttributes;

		// Token: 0x04002C8F RID: 11407
		internal static int __PropertyOffset_AttributeSet;

		// Token: 0x04002C90 RID: 11408
		internal static int __PropertyOffset_AbilitySystemComponent;
	}
}
