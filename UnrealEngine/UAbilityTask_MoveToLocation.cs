using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012FB RID: 4859
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AbilityTask_MoveToLocation")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public class UAbilityTask_MoveToLocation : UAbilityTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011EAC RID: 73388 RVA: 0x001A480F File Offset: 0x001A2A0F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilityTask_MoveToLocation._ClassPtr;
		}

		// Token: 0x06011EAD RID: 73389 RVA: 0x001A481C File Offset: 0x001A2A1C
		public UAbilityTask_MoveToLocation() : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_MoveToLocation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011EAE RID: 73390 RVA: 0x001A4844 File Offset: 0x001A2A44
		[NullableContext(1)]
		public UAbilityTask_MoveToLocation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_MoveToLocation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700460B RID: 17931
		// (get) Token: 0x06011EAF RID: 73391 RVA: 0x001A4878 File Offset: 0x001A2A78
		// (set) Token: 0x06011EB0 RID: 73392 RVA: 0x001A48B1 File Offset: 0x001A2AB1
		[Nullable(1)]
		public FMoveToLocationDelegate OnTargetLocationReached
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FMoveToLocationDelegate result;
				if ((result = this._OnTargetLocationReached) == null)
				{
					result = (this._OnTargetLocationReached = new FMoveToLocationDelegate(base.NativePtr + (IntPtr)UAbilityTask_MoveToLocation.__PropertyOffset_OnTargetLocationReached, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_MoveToLocation.__PropertyOffset_OnTargetLocationReached, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700460C RID: 17932
		// (get) Token: 0x06011EB1 RID: 73393 RVA: 0x001A48D2 File Offset: 0x001A2AD2
		// (set) Token: 0x06011EB2 RID: 73394 RVA: 0x001A48E6 File Offset: 0x001A2AE6
		public unsafe FVector StartLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_MoveToLocation.__PropertyOffset_StartLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_MoveToLocation.__PropertyOffset_StartLocation) = value;
			}
		}

		// Token: 0x1700460D RID: 17933
		// (get) Token: 0x06011EB3 RID: 73395 RVA: 0x001A48FB File Offset: 0x001A2AFB
		// (set) Token: 0x06011EB4 RID: 73396 RVA: 0x001A490F File Offset: 0x001A2B0F
		public unsafe FVector TargetLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_MoveToLocation.__PropertyOffset_TargetLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_MoveToLocation.__PropertyOffset_TargetLocation) = value;
			}
		}

		// Token: 0x1700460E RID: 17934
		// (get) Token: 0x06011EB5 RID: 73397 RVA: 0x001A4924 File Offset: 0x001A2B24
		// (set) Token: 0x06011EB6 RID: 73398 RVA: 0x001A4934 File Offset: 0x001A2B34
		public unsafe float DurationOfMovement
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_MoveToLocation.__PropertyOffset_DurationOfMovement);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_MoveToLocation.__PropertyOffset_DurationOfMovement) = value;
			}
		}

		// Token: 0x1700460F RID: 17935
		// (get) Token: 0x06011EB7 RID: 73399 RVA: 0x001A4945 File Offset: 0x001A2B45
		// (set) Token: 0x06011EB8 RID: 73400 RVA: 0x001A4959 File Offset: 0x001A2B59
		public unsafe UCurveFloat LerpCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_MoveToLocation.__PropertyOffset_LerpCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_MoveToLocation.__PropertyOffset_LerpCurve, value);
			}
		}

		// Token: 0x17004610 RID: 17936
		// (get) Token: 0x06011EB9 RID: 73401 RVA: 0x001A496E File Offset: 0x001A2B6E
		// (set) Token: 0x06011EBA RID: 73402 RVA: 0x001A4982 File Offset: 0x001A2B82
		public unsafe UCurveVector LerpCurveVector
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveVector>(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_MoveToLocation.__PropertyOffset_LerpCurveVector);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_MoveToLocation.__PropertyOffset_LerpCurveVector, value);
			}
		}

		// Token: 0x06011EBB RID: 73403 RVA: 0x001A4998 File Offset: 0x001A2B98
		public static UAbilityTask_MoveToLocation MoveToLocation(UGameplayAbility OwningAbility, FName TaskInstanceName, FVector Location, float Duration, UCurveFloat OptionalInterpolationCurve, UCurveVector OptionalVectorInterpolationCurve)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_MoveToLocation>(UAbilityTask_MoveToLocation.__MoveToLocation_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, TaskInstanceName, Location, Duration, (OptionalInterpolationCurve != null) ? OptionalInterpolationCurve.NativePtr : IntPtr.Zero, (OptionalVectorInterpolationCurve != null) ? OptionalVectorInterpolationCurve.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06011EBC RID: 73404
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MoveToLocation_Internal(IntPtr OwningAbility, FName TaskInstanceName, FVector Location, float Duration, IntPtr OptionalInterpolationCurve, IntPtr OptionalVectorInterpolationCurve);

		// Token: 0x06011EBD RID: 73405 RVA: 0x001A49E6 File Offset: 0x001A2BE6
		static UAbilityTask_MoveToLocation()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilityTask_MoveToLocation");
		}

		// Token: 0x06011EBE RID: 73406 RVA: 0x001A49F4 File Offset: 0x001A2BF4
		protected UAbilityTask_MoveToLocation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009943 RID: 39235
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilityTask_MoveToLocation";

		// Token: 0x04009944 RID: 39236
		private static IntPtr _ClassPtr;

		// Token: 0x04009945 RID: 39237
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009946 RID: 39238
		internal static int __PropertyOffset_OnTargetLocationReached;

		// Token: 0x04009947 RID: 39239
		private FMoveToLocationDelegate _OnTargetLocationReached;

		// Token: 0x04009948 RID: 39240
		internal static int __PropertyOffset_StartLocation;

		// Token: 0x04009949 RID: 39241
		internal static int __PropertyOffset_TargetLocation;

		// Token: 0x0400994A RID: 39242
		internal static int __PropertyOffset_DurationOfMovement;

		// Token: 0x0400994B RID: 39243
		internal static int __PropertyOffset_LerpCurve;

		// Token: 0x0400994C RID: 39244
		internal static int __PropertyOffset_LerpCurveVector;
	}
}
