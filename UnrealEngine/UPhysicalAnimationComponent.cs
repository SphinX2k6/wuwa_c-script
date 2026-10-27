using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FDA RID: 4058
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PhysicalAnimationComponent")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 264)]
	public class UPhysicalAnimationComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600DB26 RID: 56102 RVA: 0x00142F37 File Offset: 0x00141137
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPhysicalAnimationComponent._ClassPtr;
		}

		// Token: 0x0600DB27 RID: 56103 RVA: 0x00142F44 File Offset: 0x00141144
		public UPhysicalAnimationComponent() : this(BuiltinUtils.AllocNativeUObject(UPhysicalAnimationComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600DB28 RID: 56104 RVA: 0x00142F6C File Offset: 0x0014116C
		[NullableContext(1)]
		public UPhysicalAnimationComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPhysicalAnimationComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170033AB RID: 13227
		// (get) Token: 0x0600DB29 RID: 56105 RVA: 0x00142F9F File Offset: 0x0014119F
		// (set) Token: 0x0600DB2A RID: 56106 RVA: 0x00142FAF File Offset: 0x001411AF
		public unsafe float StrengthMultiplyer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicalAnimationComponent.__PropertyOffset_StrengthMultiplyer);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicalAnimationComponent.__PropertyOffset_StrengthMultiplyer) = value;
			}
		}

		// Token: 0x170033AC RID: 13228
		// (get) Token: 0x0600DB2B RID: 56107 RVA: 0x00142FC0 File Offset: 0x001411C0
		// (set) Token: 0x0600DB2C RID: 56108 RVA: 0x00142FD4 File Offset: 0x001411D4
		public unsafe USkeletalMeshComponent SkeletalMeshComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UPhysicalAnimationComponent.__PropertyOffset_SkeletalMeshComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UPhysicalAnimationComponent.__PropertyOffset_SkeletalMeshComponent, value);
			}
		}

		// Token: 0x0600DB2D RID: 56109 RVA: 0x00142FE9 File Offset: 0x001411E9
		public void SetStrengthMultiplyer(float InStrengthMultiplyer)
		{
			UPhysicalAnimationComponent.__SetStrengthMultiplyer_Internal(base.NativePtr, InStrengthMultiplyer);
		}

		// Token: 0x0600DB2E RID: 56110 RVA: 0x00142FF7 File Offset: 0x001411F7
		public void SetSkeletalMeshComponent(USkeletalMeshComponent InSkeletalMeshComponent)
		{
			UPhysicalAnimationComponent.__SetSkeletalMeshComponent_Internal(base.NativePtr, (InSkeletalMeshComponent != null) ? InSkeletalMeshComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600DB2F RID: 56111 RVA: 0x00143014 File Offset: 0x00141214
		public FTransform GetBodyTargetTransform(FName BodyName)
		{
			return UPhysicalAnimationComponent.__GetBodyTargetTransform_Internal(base.NativePtr, BodyName);
		}

		// Token: 0x0600DB30 RID: 56112 RVA: 0x00143022 File Offset: 0x00141222
		public void ApplyPhysicalAnimationSettingsBelow(FName BodyName, in FPhysicalAnimationData PhysicalAnimationData, bool bIncludeSelf = true)
		{
			UPhysicalAnimationComponent.__ApplyPhysicalAnimationSettingsBelow_Internal(base.NativePtr, BodyName, (PhysicalAnimationData ?? new FPhysicalAnimationData()).NativePtr, bIncludeSelf);
		}

		// Token: 0x0600DB31 RID: 56113 RVA: 0x00143041 File Offset: 0x00141241
		public void ApplyPhysicalAnimationSettings(FName BodyName, in FPhysicalAnimationData PhysicalAnimationData)
		{
			UPhysicalAnimationComponent.__ApplyPhysicalAnimationSettings_Internal(base.NativePtr, BodyName, (PhysicalAnimationData ?? new FPhysicalAnimationData()).NativePtr);
		}

		// Token: 0x0600DB32 RID: 56114 RVA: 0x0014305F File Offset: 0x0014125F
		public void ApplyPhysicalAnimationProfileBelow(FName BodyName, FName ProfileName, bool bIncludeSelf = true, bool bClearNotFound = false)
		{
			UPhysicalAnimationComponent.__ApplyPhysicalAnimationProfileBelow_Internal(base.NativePtr, BodyName, ProfileName, bIncludeSelf, bClearNotFound);
		}

		// Token: 0x0600DB33 RID: 56115
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStrengthMultiplyer_Internal(IntPtr @this, float InStrengthMultiplyer);

		// Token: 0x0600DB34 RID: 56116
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSkeletalMeshComponent_Internal(IntPtr @this, IntPtr InSkeletalMeshComponent);

		// Token: 0x0600DB35 RID: 56117
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetBodyTargetTransform_Internal(IntPtr @this, FName BodyName);

		// Token: 0x0600DB36 RID: 56118
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyPhysicalAnimationSettingsBelow_Internal(IntPtr @this, FName BodyName, IntPtr PhysicalAnimationData, bool bIncludeSelf);

		// Token: 0x0600DB37 RID: 56119
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyPhysicalAnimationSettings_Internal(IntPtr @this, FName BodyName, IntPtr PhysicalAnimationData);

		// Token: 0x0600DB38 RID: 56120
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyPhysicalAnimationProfileBelow_Internal(IntPtr @this, FName BodyName, FName ProfileName, bool bIncludeSelf, bool bClearNotFound);

		// Token: 0x0600DB39 RID: 56121 RVA: 0x00143071 File Offset: 0x00141271
		static UPhysicalAnimationComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PhysicalAnimationComponent");
		}

		// Token: 0x0600DB3A RID: 56122 RVA: 0x0014307F File Offset: 0x0014127F
		protected UPhysicalAnimationComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007699 RID: 30361
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PhysicalAnimationComponent";

		// Token: 0x0400769A RID: 30362
		private static IntPtr _ClassPtr;

		// Token: 0x0400769B RID: 30363
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400769C RID: 30364
		internal static int __PropertyOffset_StrengthMultiplyer;

		// Token: 0x0400769D RID: 30365
		internal static int __PropertyOffset_SkeletalMeshComponent;
	}
}
