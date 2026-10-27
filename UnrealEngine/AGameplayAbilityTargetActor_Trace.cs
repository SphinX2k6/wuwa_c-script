using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200135D RID: 4957
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayAbilityTargetActor_Trace")]
	[UnrealStructLayout(1376, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1376)]
	public abstract class AGameplayAbilityTargetActor_Trace : AGameplayAbilityTargetActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060122F7 RID: 74487 RVA: 0x001AB36A File Offset: 0x001A956A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AGameplayAbilityTargetActor_Trace._ClassPtr;
		}

		// Token: 0x170046D8 RID: 18136
		// (get) Token: 0x060122F8 RID: 74488 RVA: 0x001AB376 File Offset: 0x001A9576
		// (set) Token: 0x060122F9 RID: 74489 RVA: 0x001AB386 File Offset: 0x001A9586
		public unsafe float MaxRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameplayAbilityTargetActor_Trace.__PropertyOffset_MaxRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameplayAbilityTargetActor_Trace.__PropertyOffset_MaxRange) = value;
			}
		}

		// Token: 0x170046D9 RID: 18137
		// (get) Token: 0x060122FA RID: 74490 RVA: 0x001AB398 File Offset: 0x001A9598
		// (set) Token: 0x060122FB RID: 74491 RVA: 0x001AB3D1 File Offset: 0x001A95D1
		public FCollisionProfileName TraceProfile
		{
			get
			{
				base.FastCheckIsValid();
				FCollisionProfileName result;
				if ((result = this._TraceProfile) == null)
				{
					result = (this._TraceProfile = new FCollisionProfileName(base.NativePtr + (IntPtr)AGameplayAbilityTargetActor_Trace.__PropertyOffset_TraceProfile, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCollisionProfileName.StaticStruct(), base.NativePtr + (IntPtr)AGameplayAbilityTargetActor_Trace.__PropertyOffset_TraceProfile, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170046DA RID: 18138
		// (get) Token: 0x060122FC RID: 74492 RVA: 0x001AB3F2 File Offset: 0x001A95F2
		// (set) Token: 0x060122FD RID: 74493 RVA: 0x001AB402 File Offset: 0x001A9602
		public unsafe bool bTraceAffectsAimPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameplayAbilityTargetActor_Trace.__PropertyOffset_bTraceAffectsAimPitch) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameplayAbilityTargetActor_Trace.__PropertyOffset_bTraceAffectsAimPitch) = (value ? 1 : 0);
			}
		}

		// Token: 0x060122FE RID: 74494 RVA: 0x001AB413 File Offset: 0x001A9613
		static AGameplayAbilityTargetActor_Trace()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.GameplayAbilityTargetActor_Trace");
		}

		// Token: 0x060122FF RID: 74495 RVA: 0x001AB424 File Offset: 0x001A9624
		protected AGameplayAbilityTargetActor_Trace() : this(BuiltinUtils.AllocNativeUObject(AGameplayAbilityTargetActor_Trace.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012300 RID: 74496 RVA: 0x001AB44C File Offset: 0x001A964C
		protected AGameplayAbilityTargetActor_Trace(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009BDF RID: 39903
		public new const string __ObjectPath = "/Script/GameplayAbilities.GameplayAbilityTargetActor_Trace";

		// Token: 0x04009BE0 RID: 39904
		private static IntPtr _ClassPtr;

		// Token: 0x04009BE1 RID: 39905
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009BE2 RID: 39906
		internal static int __PropertyOffset_MaxRange;

		// Token: 0x04009BE3 RID: 39907
		internal static int __PropertyOffset_TraceProfile;

		// Token: 0x04009BE4 RID: 39908
		[Nullable(2)]
		private FCollisionProfileName _TraceProfile;

		// Token: 0x04009BE5 RID: 39909
		internal static int __PropertyOffset_bTraceAffectsAimPitch;
	}
}
