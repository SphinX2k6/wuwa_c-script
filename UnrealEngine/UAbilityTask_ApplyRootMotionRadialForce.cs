using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012F9 RID: 4857
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AbilityTask_ApplyRootMotionRadialForce")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UAbilityTask_ApplyRootMotionRadialForce : UAbilityTask_ApplyRootMotion_Base, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011E7C RID: 73340 RVA: 0x001A43D0 File Offset: 0x001A25D0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilityTask_ApplyRootMotionRadialForce._ClassPtr;
		}

		// Token: 0x06011E7D RID: 73341 RVA: 0x001A43DC File Offset: 0x001A25DC
		public UAbilityTask_ApplyRootMotionRadialForce() : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_ApplyRootMotionRadialForce.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011E7E RID: 73342 RVA: 0x001A4404 File Offset: 0x001A2604
		[NullableContext(1)]
		public UAbilityTask_ApplyRootMotionRadialForce(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_ApplyRootMotionRadialForce.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170045F9 RID: 17913
		// (get) Token: 0x06011E7F RID: 73343 RVA: 0x001A4438 File Offset: 0x001A2638
		// (set) Token: 0x06011E80 RID: 73344 RVA: 0x001A4471 File Offset: 0x001A2671
		[Nullable(1)]
		public FApplyRootMotionRadialForceDelegate OnFinish
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FApplyRootMotionRadialForceDelegate result;
				if ((result = this._OnFinish) == null)
				{
					result = (this._OnFinish = new FApplyRootMotionRadialForceDelegate(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionRadialForce.__PropertyOffset_OnFinish, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionRadialForce.__PropertyOffset_OnFinish, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170045FA RID: 17914
		// (get) Token: 0x06011E81 RID: 73345 RVA: 0x001A4492 File Offset: 0x001A2692
		// (set) Token: 0x06011E82 RID: 73346 RVA: 0x001A44A6 File Offset: 0x001A26A6
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionRadialForce.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionRadialForce.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x170045FB RID: 17915
		// (get) Token: 0x06011E83 RID: 73347 RVA: 0x001A44BB File Offset: 0x001A26BB
		// (set) Token: 0x06011E84 RID: 73348 RVA: 0x001A44CF File Offset: 0x001A26CF
		public unsafe AActor LocationActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_ApplyRootMotionRadialForce.__PropertyOffset_LocationActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_ApplyRootMotionRadialForce.__PropertyOffset_LocationActor, value);
			}
		}

		// Token: 0x170045FC RID: 17916
		// (get) Token: 0x06011E85 RID: 73349 RVA: 0x001A44E4 File Offset: 0x001A26E4
		// (set) Token: 0x06011E86 RID: 73350 RVA: 0x001A44F4 File Offset: 0x001A26F4
		public unsafe float Strength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionRadialForce.__PropertyOffset_Strength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionRadialForce.__PropertyOffset_Strength) = value;
			}
		}

		// Token: 0x170045FD RID: 17917
		// (get) Token: 0x06011E87 RID: 73351 RVA: 0x001A4505 File Offset: 0x001A2705
		// (set) Token: 0x06011E88 RID: 73352 RVA: 0x001A4515 File Offset: 0x001A2715
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionRadialForce.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionRadialForce.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x170045FE RID: 17918
		// (get) Token: 0x06011E89 RID: 73353 RVA: 0x001A4526 File Offset: 0x001A2726
		// (set) Token: 0x06011E8A RID: 73354 RVA: 0x001A4536 File Offset: 0x001A2736
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionRadialForce.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionRadialForce.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x170045FF RID: 17919
		// (get) Token: 0x06011E8B RID: 73355 RVA: 0x001A4547 File Offset: 0x001A2747
		// (set) Token: 0x06011E8C RID: 73356 RVA: 0x001A4557 File Offset: 0x001A2757
		public unsafe bool bIsPush
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionRadialForce.__PropertyOffset_bIsPush) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionRadialForce.__PropertyOffset_bIsPush) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004600 RID: 17920
		// (get) Token: 0x06011E8D RID: 73357 RVA: 0x001A4568 File Offset: 0x001A2768
		// (set) Token: 0x06011E8E RID: 73358 RVA: 0x001A4578 File Offset: 0x001A2778
		public unsafe bool bIsAdditive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionRadialForce.__PropertyOffset_bIsAdditive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionRadialForce.__PropertyOffset_bIsAdditive) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004601 RID: 17921
		// (get) Token: 0x06011E8F RID: 73359 RVA: 0x001A4589 File Offset: 0x001A2789
		// (set) Token: 0x06011E90 RID: 73360 RVA: 0x001A4599 File Offset: 0x001A2799
		public unsafe bool bNoZForce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionRadialForce.__PropertyOffset_bNoZForce) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionRadialForce.__PropertyOffset_bNoZForce) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004602 RID: 17922
		// (get) Token: 0x06011E91 RID: 73361 RVA: 0x001A45AA File Offset: 0x001A27AA
		// (set) Token: 0x06011E92 RID: 73362 RVA: 0x001A45BE File Offset: 0x001A27BE
		public unsafe UCurveFloat StrengthDistanceFalloff
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_ApplyRootMotionRadialForce.__PropertyOffset_StrengthDistanceFalloff);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_ApplyRootMotionRadialForce.__PropertyOffset_StrengthDistanceFalloff, value);
			}
		}

		// Token: 0x17004603 RID: 17923
		// (get) Token: 0x06011E93 RID: 73363 RVA: 0x001A45D3 File Offset: 0x001A27D3
		// (set) Token: 0x06011E94 RID: 73364 RVA: 0x001A45E7 File Offset: 0x001A27E7
		public unsafe UCurveFloat StrengthOverTime
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_ApplyRootMotionRadialForce.__PropertyOffset_StrengthOverTime);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_ApplyRootMotionRadialForce.__PropertyOffset_StrengthOverTime, value);
			}
		}

		// Token: 0x17004604 RID: 17924
		// (get) Token: 0x06011E95 RID: 73365 RVA: 0x001A45FC File Offset: 0x001A27FC
		// (set) Token: 0x06011E96 RID: 73366 RVA: 0x001A460C File Offset: 0x001A280C
		public unsafe bool bUseFixedWorldDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionRadialForce.__PropertyOffset_bUseFixedWorldDirection) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionRadialForce.__PropertyOffset_bUseFixedWorldDirection) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004605 RID: 17925
		// (get) Token: 0x06011E97 RID: 73367 RVA: 0x001A461D File Offset: 0x001A281D
		// (set) Token: 0x06011E98 RID: 73368 RVA: 0x001A4631 File Offset: 0x001A2831
		public unsafe FRotator FixedWorldDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionRadialForce.__PropertyOffset_FixedWorldDirection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionRadialForce.__PropertyOffset_FixedWorldDirection) = value;
			}
		}

		// Token: 0x06011E99 RID: 73369 RVA: 0x001A4648 File Offset: 0x001A2848
		public static UAbilityTask_ApplyRootMotionRadialForce ApplyRootMotionRadialForce(UGameplayAbility OwningAbility, FName TaskInstanceName, FVector Location, AActor LocationActor, float Strength, float Duration, float Radius, bool bIsPush, bool bIsAdditive, bool bNoZForce, UCurveFloat StrengthDistanceFalloff, UCurveFloat StrengthOverTime, bool bUseFixedWorldDirection, FRotator FixedWorldDirection, ERootMotionFinishVelocityMode VelocityOnFinishMode, FVector SetVelocityOnFinish, float ClampVelocityOnFinish)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_ApplyRootMotionRadialForce>(UAbilityTask_ApplyRootMotionRadialForce.__ApplyRootMotionRadialForce_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, TaskInstanceName, Location, (LocationActor != null) ? LocationActor.NativePtr : IntPtr.Zero, Strength, Duration, Radius, bIsPush, bIsAdditive, bNoZForce, (StrengthDistanceFalloff != null) ? StrengthDistanceFalloff.NativePtr : IntPtr.Zero, (StrengthOverTime != null) ? StrengthOverTime.NativePtr : IntPtr.Zero, bUseFixedWorldDirection, FixedWorldDirection, VelocityOnFinishMode, SetVelocityOnFinish, ClampVelocityOnFinish));
		}

		// Token: 0x06011E9A RID: 73370
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __ApplyRootMotionRadialForce_Internal(IntPtr OwningAbility, FName TaskInstanceName, FVector Location, IntPtr LocationActor, float Strength, float Duration, float Radius, bool bIsPush, bool bIsAdditive, bool bNoZForce, IntPtr StrengthDistanceFalloff, IntPtr StrengthOverTime, bool bUseFixedWorldDirection, FRotator FixedWorldDirection, ERootMotionFinishVelocityMode VelocityOnFinishMode, FVector SetVelocityOnFinish, float ClampVelocityOnFinish);

		// Token: 0x06011E9B RID: 73371 RVA: 0x001A46BB File Offset: 0x001A28BB
		static UAbilityTask_ApplyRootMotionRadialForce()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilityTask_ApplyRootMotionRadialForce");
		}

		// Token: 0x06011E9C RID: 73372 RVA: 0x001A46C9 File Offset: 0x001A28C9
		protected UAbilityTask_ApplyRootMotionRadialForce(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400992A RID: 39210
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilityTask_ApplyRootMotionRadialForce";

		// Token: 0x0400992B RID: 39211
		private static IntPtr _ClassPtr;

		// Token: 0x0400992C RID: 39212
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400992D RID: 39213
		internal static int __PropertyOffset_OnFinish;

		// Token: 0x0400992E RID: 39214
		private FApplyRootMotionRadialForceDelegate _OnFinish;

		// Token: 0x0400992F RID: 39215
		internal static int __PropertyOffset_Location;

		// Token: 0x04009930 RID: 39216
		internal static int __PropertyOffset_LocationActor;

		// Token: 0x04009931 RID: 39217
		internal static int __PropertyOffset_Strength;

		// Token: 0x04009932 RID: 39218
		internal static int __PropertyOffset_Duration;

		// Token: 0x04009933 RID: 39219
		internal static int __PropertyOffset_Radius;

		// Token: 0x04009934 RID: 39220
		internal static int __PropertyOffset_bIsPush;

		// Token: 0x04009935 RID: 39221
		internal static int __PropertyOffset_bIsAdditive;

		// Token: 0x04009936 RID: 39222
		internal static int __PropertyOffset_bNoZForce;

		// Token: 0x04009937 RID: 39223
		internal static int __PropertyOffset_StrengthDistanceFalloff;

		// Token: 0x04009938 RID: 39224
		internal static int __PropertyOffset_StrengthOverTime;

		// Token: 0x04009939 RID: 39225
		internal static int __PropertyOffset_bUseFixedWorldDirection;

		// Token: 0x0400993A RID: 39226
		internal static int __PropertyOffset_FixedWorldDirection;
	}
}
