using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200195C RID: 6492
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGAS.BaseCharacter")]
	[UnrealStructLayout(2016, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2016)]
	public class ABaseCharacter : ACharacter, IUnrealUObject, IUnrealObject, IAbilitySystemInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06018208 RID: 98824 RVA: 0x002391D2 File Offset: 0x002373D2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ABaseCharacter._ClassPtr;
		}

		// Token: 0x06018209 RID: 98825 RVA: 0x002391DE File Offset: 0x002373DE
		int IAbilitySystemInterface.InterfaceOffset()
		{
			return ABaseCharacter.__InterfaceOffset_IAbilitySystemInterface;
		}

		// Token: 0x0601820A RID: 98826 RVA: 0x002391E8 File Offset: 0x002373E8
		public ABaseCharacter() : this(BuiltinUtils.AllocNativeUObject(ABaseCharacter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601820B RID: 98827 RVA: 0x00239210 File Offset: 0x00237410
		[NullableContext(1)]
		public ABaseCharacter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABaseCharacter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170060D0 RID: 24784
		// (get) Token: 0x0601820C RID: 98828 RVA: 0x00239243 File Offset: 0x00237443
		// (set) Token: 0x0601820D RID: 98829 RVA: 0x00239257 File Offset: 0x00237457
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

		// Token: 0x170060D1 RID: 24785
		// (get) Token: 0x0601820E RID: 98830 RVA: 0x0023926C File Offset: 0x0023746C
		// (set) Token: 0x0601820F RID: 98831 RVA: 0x00239280 File Offset: 0x00237480
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

		// Token: 0x170060D2 RID: 24786
		// (get) Token: 0x06018210 RID: 98832 RVA: 0x00239295 File Offset: 0x00237495
		// (set) Token: 0x06018211 RID: 98833 RVA: 0x002392A9 File Offset: 0x002374A9
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

		// Token: 0x170060D3 RID: 24787
		// (get) Token: 0x06018212 RID: 98834 RVA: 0x002392BE File Offset: 0x002374BE
		// (set) Token: 0x06018213 RID: 98835 RVA: 0x002392D2 File Offset: 0x002374D2
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

		// Token: 0x170060D4 RID: 24788
		// (get) Token: 0x06018214 RID: 98836 RVA: 0x002392E7 File Offset: 0x002374E7
		// (set) Token: 0x06018215 RID: 98837 RVA: 0x002392FB File Offset: 0x002374FB
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

		// Token: 0x170060D5 RID: 24789
		// (get) Token: 0x06018216 RID: 98838 RVA: 0x00239310 File Offset: 0x00237510
		// (set) Token: 0x06018217 RID: 98839 RVA: 0x00239324 File Offset: 0x00237524
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

		// Token: 0x170060D6 RID: 24790
		// (get) Token: 0x06018218 RID: 98840 RVA: 0x00239339 File Offset: 0x00237539
		// (set) Token: 0x06018219 RID: 98841 RVA: 0x0023934D File Offset: 0x0023754D
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

		// Token: 0x170060D7 RID: 24791
		// (get) Token: 0x0601821A RID: 98842 RVA: 0x00239362 File Offset: 0x00237562
		// (set) Token: 0x0601821B RID: 98843 RVA: 0x00239376 File Offset: 0x00237576
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

		// Token: 0x170060D8 RID: 24792
		// (get) Token: 0x0601821C RID: 98844 RVA: 0x0023938B File Offset: 0x0023758B
		// (set) Token: 0x0601821D RID: 98845 RVA: 0x0023939B File Offset: 0x0023759B
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

		// Token: 0x170060D9 RID: 24793
		// (get) Token: 0x0601821E RID: 98846 RVA: 0x002393AC File Offset: 0x002375AC
		// (set) Token: 0x0601821F RID: 98847 RVA: 0x002393BC File Offset: 0x002375BC
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

		// Token: 0x170060DA RID: 24794
		// (get) Token: 0x06018220 RID: 98848 RVA: 0x002393CD File Offset: 0x002375CD
		// (set) Token: 0x06018221 RID: 98849 RVA: 0x002393E1 File Offset: 0x002375E1
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

		// Token: 0x170060DB RID: 24795
		// (get) Token: 0x06018222 RID: 98850 RVA: 0x002393F6 File Offset: 0x002375F6
		// (set) Token: 0x06018223 RID: 98851 RVA: 0x0023940A File Offset: 0x0023760A
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

		// Token: 0x06018224 RID: 98852 RVA: 0x00239420 File Offset: 0x00237620
		public unsafe bool SetActorTransformExceptSkelMesh(in FTransformDouble NewTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport, bool bIgnoreOverlap)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = NewTransform;
			return ABaseCharacter.__SetActorTransformExceptSkelMesh_Internal(base.NativePtr, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport, bIgnoreOverlap);
		}

		// Token: 0x06018225 RID: 98853 RVA: 0x0023946A File Offset: 0x0023766A
		public bool SetActorLocationAndRotationExceptSkelMesh(in FVectorDouble NewLocation, in FRotator NewRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport, bool bIgnoreOverlap)
		{
			return ABaseCharacter.__SetActorLocationAndRotationExceptSkelMesh_Internal(base.NativePtr, NewLocation, NewRotation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport, bIgnoreOverlap);
		}

		// Token: 0x06018226 RID: 98854 RVA: 0x0023948F File Offset: 0x0023768F
		public void RefreshCachedVelocity()
		{
			ABaseCharacter.__RefreshCachedVelocity_Internal(base.NativePtr);
		}

		// Token: 0x06018227 RID: 98855 RVA: 0x0023949C File Offset: 0x0023769C
		public void RefreshCachedTransform()
		{
			ABaseCharacter.__RefreshCachedTransform_Internal(base.NativePtr);
		}

		// Token: 0x06018228 RID: 98856 RVA: 0x002394A9 File Offset: 0x002376A9
		public void PreInit()
		{
			ABaseCharacter.__PreInit_Internal(base.NativePtr);
		}

		// Token: 0x06018229 RID: 98857 RVA: 0x002394B6 File Offset: 0x002376B6
		public void InitializeAttributeSet()
		{
			ABaseCharacter.__InitializeAttributeSet_Internal(base.NativePtr);
		}

		// Token: 0x0601822A RID: 98858 RVA: 0x002394C3 File Offset: 0x002376C3
		public void CreateAttribute()
		{
			ABaseCharacter.__CreateAttribute_Internal(base.NativePtr);
		}

		// Token: 0x0601822B RID: 98859 RVA: 0x002394D0 File Offset: 0x002376D0
		public bool ContainsTag(FGameplayTag TagToCheck)
		{
			return ABaseCharacter.__ContainsTag_Internal(base.NativePtr, TagToCheck);
		}

		// Token: 0x0601822C RID: 98860 RVA: 0x002394DE File Offset: 0x002376DE
		public bool ContainsAnyTag(FGameplayTagContainer TagToCheck)
		{
			return ABaseCharacter.__ContainsAnyTag_Internal(base.NativePtr, (TagToCheck ?? new FGameplayTagContainer()).NativePtr);
		}

		// Token: 0x0601822D RID: 98861 RVA: 0x002394FA File Offset: 0x002376FA
		public bool ContainsAllTag(FGameplayTagContainer TagToCheck)
		{
			return ABaseCharacter.__ContainsAllTag_Internal(base.NativePtr, (TagToCheck ?? new FGameplayTagContainer()).NativePtr);
		}

		// Token: 0x0601822E RID: 98862
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetActorTransformExceptSkelMesh_Internal(IntPtr @this, in FTransformDouble NewTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport, bool bIgnoreOverlap);

		// Token: 0x0601822F RID: 98863
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetActorLocationAndRotationExceptSkelMesh_Internal(IntPtr @this, in FVectorDouble NewLocation, in FRotator NewRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport, bool bIgnoreOverlap);

		// Token: 0x06018230 RID: 98864
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RefreshCachedVelocity_Internal(IntPtr @this);

		// Token: 0x06018231 RID: 98865
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RefreshCachedTransform_Internal(IntPtr @this);

		// Token: 0x06018232 RID: 98866
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PreInit_Internal(IntPtr @this);

		// Token: 0x06018233 RID: 98867
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitializeAttributeSet_Internal(IntPtr @this);

		// Token: 0x06018234 RID: 98868
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CreateAttribute_Internal(IntPtr @this);

		// Token: 0x06018235 RID: 98869
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ContainsTag_Internal(IntPtr @this, FGameplayTag TagToCheck);

		// Token: 0x06018236 RID: 98870
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ContainsAnyTag_Internal(IntPtr @this, IntPtr TagToCheck);

		// Token: 0x06018237 RID: 98871
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ContainsAllTag_Internal(IntPtr @this, IntPtr TagToCheck);

		// Token: 0x06018238 RID: 98872 RVA: 0x00239516 File Offset: 0x00237716
		static ABaseCharacter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGAS.BaseCharacter");
		}

		// Token: 0x06018239 RID: 98873 RVA: 0x00239524 File Offset: 0x00237724
		protected ABaseCharacter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D170 RID: 53616
		internal static int __InterfaceOffset_IAbilitySystemInterface;

		// Token: 0x0400D171 RID: 53617
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGAS.BaseCharacter";

		// Token: 0x0400D172 RID: 53618
		private static IntPtr _ClassPtr;

		// Token: 0x0400D173 RID: 53619
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D174 RID: 53620
		internal static int __PropertyOffset_CachedActorLocation;

		// Token: 0x0400D175 RID: 53621
		internal static int __PropertyOffset_CachedActorRotation;

		// Token: 0x0400D176 RID: 53622
		internal static int __PropertyOffset_CachedActorQuat;

		// Token: 0x0400D177 RID: 53623
		internal static int __PropertyOffset_CachedActorScale;

		// Token: 0x0400D178 RID: 53624
		internal static int __PropertyOffset_CachedActorTransform;

		// Token: 0x0400D179 RID: 53625
		internal static int __PropertyOffset_CachedActorUp;

		// Token: 0x0400D17A RID: 53626
		internal static int __PropertyOffset_CachedActorForward;

		// Token: 0x0400D17B RID: 53627
		internal static int __PropertyOffset_CachedActorVelocity;

		// Token: 0x0400D17C RID: 53628
		internal static int __PropertyOffset_EntityIdInternal;

		// Token: 0x0400D17D RID: 53629
		internal static int __PropertyOffset_bInitializeAttributes;

		// Token: 0x0400D17E RID: 53630
		internal static int __PropertyOffset_AttributeSet;

		// Token: 0x0400D17F RID: 53631
		internal static int __PropertyOffset_AbilitySystemComponent;
	}
}
