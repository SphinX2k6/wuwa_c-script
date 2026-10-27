using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FE6 RID: 4070
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PhysicsSettings")]
	[UnrealStructLayout(456, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 456)]
	public class UPhysicsSettings : UPhysicsSettingsCore, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600DC45 RID: 56389 RVA: 0x001444AB File Offset: 0x001426AB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPhysicsSettings._ClassPtr;
		}

		// Token: 0x0600DC46 RID: 56390 RVA: 0x001444B8 File Offset: 0x001426B8
		public UPhysicsSettings() : this(BuiltinUtils.AllocNativeUObject(UPhysicsSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600DC47 RID: 56391 RVA: 0x001444E0 File Offset: 0x001426E0
		public UPhysicsSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPhysicsSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170033E0 RID: 13280
		// (get) Token: 0x0600DC48 RID: 56392 RVA: 0x00144514 File Offset: 0x00142714
		// (set) Token: 0x0600DC49 RID: 56393 RVA: 0x0014454D File Offset: 0x0014274D
		public FRigidBodyErrorCorrection PhysicErrorCorrection
		{
			get
			{
				base.FastCheckIsValid();
				FRigidBodyErrorCorrection result;
				if ((result = this._PhysicErrorCorrection) == null)
				{
					result = (this._PhysicErrorCorrection = new FRigidBodyErrorCorrection(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_PhysicErrorCorrection, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigidBodyErrorCorrection.StaticStruct(), base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_PhysicErrorCorrection, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170033E1 RID: 13281
		// (get) Token: 0x0600DC4A RID: 56394 RVA: 0x0014456E File Offset: 0x0014276E
		// (set) Token: 0x0600DC4B RID: 56395 RVA: 0x00144582 File Offset: 0x00142782
		[Nullable(0)]
		public unsafe TEnumAsByte<ESettingsLockedAxis> LockedAxis_DEPRECATED
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_LockedAxis_DEPRECATED);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_LockedAxis_DEPRECATED) = value;
			}
		}

		// Token: 0x170033E2 RID: 13282
		// (get) Token: 0x0600DC4C RID: 56396 RVA: 0x00144597 File Offset: 0x00142797
		// (set) Token: 0x0600DC4D RID: 56397 RVA: 0x001445AB File Offset: 0x001427AB
		[Nullable(0)]
		public unsafe TEnumAsByte<ESettingsDOF> DefaultDegreesOfFreedom
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_DefaultDegreesOfFreedom);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_DefaultDegreesOfFreedom) = value;
			}
		}

		// Token: 0x170033E3 RID: 13283
		// (get) Token: 0x0600DC4E RID: 56398 RVA: 0x001445C0 File Offset: 0x001427C0
		// (set) Token: 0x0600DC4F RID: 56399 RVA: 0x001445D0 File Offset: 0x001427D0
		public unsafe bool bSuppressFaceRemapTable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_bSuppressFaceRemapTable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_bSuppressFaceRemapTable) = (value ? 1 : 0);
			}
		}

		// Token: 0x170033E4 RID: 13284
		// (get) Token: 0x0600DC50 RID: 56400 RVA: 0x001445E1 File Offset: 0x001427E1
		// (set) Token: 0x0600DC51 RID: 56401 RVA: 0x001445F1 File Offset: 0x001427F1
		public unsafe bool bSupportUVFromHitResults
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_bSupportUVFromHitResults) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_bSupportUVFromHitResults) = (value ? 1 : 0);
			}
		}

		// Token: 0x170033E5 RID: 13285
		// (get) Token: 0x0600DC52 RID: 56402 RVA: 0x00144602 File Offset: 0x00142802
		// (set) Token: 0x0600DC53 RID: 56403 RVA: 0x00144612 File Offset: 0x00142812
		public unsafe bool bDisableActiveActors
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_bDisableActiveActors) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_bDisableActiveActors) = (value ? 1 : 0);
			}
		}

		// Token: 0x170033E6 RID: 13286
		// (get) Token: 0x0600DC54 RID: 56404 RVA: 0x00144623 File Offset: 0x00142823
		// (set) Token: 0x0600DC55 RID: 56405 RVA: 0x00144633 File Offset: 0x00142833
		public unsafe bool bDisableKinematicStaticPairs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_bDisableKinematicStaticPairs) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_bDisableKinematicStaticPairs) = (value ? 1 : 0);
			}
		}

		// Token: 0x170033E7 RID: 13287
		// (get) Token: 0x0600DC56 RID: 56406 RVA: 0x00144644 File Offset: 0x00142844
		// (set) Token: 0x0600DC57 RID: 56407 RVA: 0x00144654 File Offset: 0x00142854
		public unsafe bool bDisableKinematicKinematicPairs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_bDisableKinematicKinematicPairs) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_bDisableKinematicKinematicPairs) = (value ? 1 : 0);
			}
		}

		// Token: 0x170033E8 RID: 13288
		// (get) Token: 0x0600DC58 RID: 56408 RVA: 0x00144665 File Offset: 0x00142865
		// (set) Token: 0x0600DC59 RID: 56409 RVA: 0x00144675 File Offset: 0x00142875
		public unsafe bool bDisableCCD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_bDisableCCD) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_bDisableCCD) = (value ? 1 : 0);
			}
		}

		// Token: 0x170033E9 RID: 13289
		// (get) Token: 0x0600DC5A RID: 56410 RVA: 0x00144686 File Offset: 0x00142886
		// (set) Token: 0x0600DC5B RID: 56411 RVA: 0x00144696 File Offset: 0x00142896
		public unsafe bool bEnableEnhancedDeterminism
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_bEnableEnhancedDeterminism) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_bEnableEnhancedDeterminism) = (value ? 1 : 0);
			}
		}

		// Token: 0x170033EA RID: 13290
		// (get) Token: 0x0600DC5C RID: 56412 RVA: 0x001446A7 File Offset: 0x001428A7
		// (set) Token: 0x0600DC5D RID: 56413 RVA: 0x001446B7 File Offset: 0x001428B7
		public unsafe float AnimPhysicsMinDeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_AnimPhysicsMinDeltaTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_AnimPhysicsMinDeltaTime) = value;
			}
		}

		// Token: 0x170033EB RID: 13291
		// (get) Token: 0x0600DC5E RID: 56414 RVA: 0x001446C8 File Offset: 0x001428C8
		// (set) Token: 0x0600DC5F RID: 56415 RVA: 0x001446D8 File Offset: 0x001428D8
		public unsafe bool bSimulateAnimPhysicsAfterReset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_bSimulateAnimPhysicsAfterReset) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_bSimulateAnimPhysicsAfterReset) = (value ? 1 : 0);
			}
		}

		// Token: 0x170033EC RID: 13292
		// (get) Token: 0x0600DC60 RID: 56416 RVA: 0x001446E9 File Offset: 0x001428E9
		// (set) Token: 0x0600DC61 RID: 56417 RVA: 0x001446F9 File Offset: 0x001428F9
		public unsafe float MaxPhysicsDeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_MaxPhysicsDeltaTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_MaxPhysicsDeltaTime) = value;
			}
		}

		// Token: 0x170033ED RID: 13293
		// (get) Token: 0x0600DC62 RID: 56418 RVA: 0x0014470A File Offset: 0x0014290A
		// (set) Token: 0x0600DC63 RID: 56419 RVA: 0x0014471A File Offset: 0x0014291A
		public unsafe bool bSubstepping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_bSubstepping) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_bSubstepping) = (value ? 1 : 0);
			}
		}

		// Token: 0x170033EE RID: 13294
		// (get) Token: 0x0600DC64 RID: 56420 RVA: 0x0014472B File Offset: 0x0014292B
		// (set) Token: 0x0600DC65 RID: 56421 RVA: 0x0014473B File Offset: 0x0014293B
		public unsafe bool bSubsteppingAsync
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_bSubsteppingAsync) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_bSubsteppingAsync) = (value ? 1 : 0);
			}
		}

		// Token: 0x170033EF RID: 13295
		// (get) Token: 0x0600DC66 RID: 56422 RVA: 0x0014474C File Offset: 0x0014294C
		// (set) Token: 0x0600DC67 RID: 56423 RVA: 0x0014475C File Offset: 0x0014295C
		public unsafe float MaxSubstepDeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_MaxSubstepDeltaTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_MaxSubstepDeltaTime) = value;
			}
		}

		// Token: 0x170033F0 RID: 13296
		// (get) Token: 0x0600DC68 RID: 56424 RVA: 0x0014476D File Offset: 0x0014296D
		// (set) Token: 0x0600DC69 RID: 56425 RVA: 0x0014477D File Offset: 0x0014297D
		public unsafe int MaxSubsteps
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_MaxSubsteps);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_MaxSubsteps) = value;
			}
		}

		// Token: 0x170033F1 RID: 13297
		// (get) Token: 0x0600DC6A RID: 56426 RVA: 0x0014478E File Offset: 0x0014298E
		// (set) Token: 0x0600DC6B RID: 56427 RVA: 0x0014479E File Offset: 0x0014299E
		public unsafe float SyncSceneSmoothingFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_SyncSceneSmoothingFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_SyncSceneSmoothingFactor) = value;
			}
		}

		// Token: 0x170033F2 RID: 13298
		// (get) Token: 0x0600DC6C RID: 56428 RVA: 0x001447AF File Offset: 0x001429AF
		// (set) Token: 0x0600DC6D RID: 56429 RVA: 0x001447BF File Offset: 0x001429BF
		public unsafe float InitialAverageFrameRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_InitialAverageFrameRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_InitialAverageFrameRate) = value;
			}
		}

		// Token: 0x170033F3 RID: 13299
		// (get) Token: 0x0600DC6E RID: 56430 RVA: 0x001447D0 File Offset: 0x001429D0
		// (set) Token: 0x0600DC6F RID: 56431 RVA: 0x001447E0 File Offset: 0x001429E0
		public unsafe int PhysXTreeRebuildRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_PhysXTreeRebuildRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_PhysXTreeRebuildRate) = value;
			}
		}

		// Token: 0x170033F4 RID: 13300
		// (get) Token: 0x0600DC70 RID: 56432 RVA: 0x001447F4 File Offset: 0x001429F4
		// (set) Token: 0x0600DC71 RID: 56433 RVA: 0x0014482D File Offset: 0x00142A2D
		public TArray<FPhysicalSurfaceName> PhysicalSurfaces
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPhysicalSurfaceName> result;
				if ((result = this._PhysicalSurfaces) == null)
				{
					result = (this._PhysicalSurfaces = new TArray<FPhysicalSurfaceName>(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_PhysicalSurfaces, this));
				}
				return result;
			}
			set
			{
				this.PhysicalSurfaces.CopyAssign(value);
			}
		}

		// Token: 0x170033F5 RID: 13301
		// (get) Token: 0x0600DC72 RID: 56434 RVA: 0x0014483C File Offset: 0x00142A3C
		// (set) Token: 0x0600DC73 RID: 56435 RVA: 0x00144875 File Offset: 0x00142A75
		public FBroadphaseSettings DefaultBroadphaseSettings
		{
			get
			{
				base.FastCheckIsValid();
				FBroadphaseSettings result;
				if ((result = this._DefaultBroadphaseSettings) == null)
				{
					result = (this._DefaultBroadphaseSettings = new FBroadphaseSettings(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_DefaultBroadphaseSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBroadphaseSettings.StaticStruct(), base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_DefaultBroadphaseSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170033F6 RID: 13302
		// (get) Token: 0x0600DC74 RID: 56436 RVA: 0x00144896 File Offset: 0x00142A96
		// (set) Token: 0x0600DC75 RID: 56437 RVA: 0x001448A6 File Offset: 0x00142AA6
		public unsafe float MinDeltaVelocityForHitEvents
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_MinDeltaVelocityForHitEvents);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_MinDeltaVelocityForHitEvents) = value;
			}
		}

		// Token: 0x170033F7 RID: 13303
		// (get) Token: 0x0600DC76 RID: 56438 RVA: 0x001448B8 File Offset: 0x00142AB8
		// (set) Token: 0x0600DC77 RID: 56439 RVA: 0x001448F1 File Offset: 0x00142AF1
		public FChaosPhysicsSettings ChaosSettings
		{
			get
			{
				base.FastCheckIsValid();
				FChaosPhysicsSettings result;
				if ((result = this._ChaosSettings) == null)
				{
					result = (this._ChaosSettings = new FChaosPhysicsSettings(base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_ChaosSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FChaosPhysicsSettings.StaticStruct(), base.NativePtr + (IntPtr)UPhysicsSettings.__PropertyOffset_ChaosSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600DC78 RID: 56440 RVA: 0x00144912 File Offset: 0x00142B12
		static UPhysicsSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PhysicsSettings");
		}

		// Token: 0x0600DC79 RID: 56441 RVA: 0x00144920 File Offset: 0x00142B20
		protected UPhysicsSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007703 RID: 30467
		public new const string __ObjectPath = "/Script/Engine.PhysicsSettings";

		// Token: 0x04007704 RID: 30468
		private static IntPtr _ClassPtr;

		// Token: 0x04007705 RID: 30469
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007706 RID: 30470
		internal static int __PropertyOffset_PhysicErrorCorrection;

		// Token: 0x04007707 RID: 30471
		[Nullable(2)]
		private FRigidBodyErrorCorrection _PhysicErrorCorrection;

		// Token: 0x04007708 RID: 30472
		internal static int __PropertyOffset_LockedAxis_DEPRECATED;

		// Token: 0x04007709 RID: 30473
		internal static int __PropertyOffset_DefaultDegreesOfFreedom;

		// Token: 0x0400770A RID: 30474
		internal static int __PropertyOffset_bSuppressFaceRemapTable;

		// Token: 0x0400770B RID: 30475
		internal static int __PropertyOffset_bSupportUVFromHitResults;

		// Token: 0x0400770C RID: 30476
		internal static int __PropertyOffset_bDisableActiveActors;

		// Token: 0x0400770D RID: 30477
		internal static int __PropertyOffset_bDisableKinematicStaticPairs;

		// Token: 0x0400770E RID: 30478
		internal static int __PropertyOffset_bDisableKinematicKinematicPairs;

		// Token: 0x0400770F RID: 30479
		internal static int __PropertyOffset_bDisableCCD;

		// Token: 0x04007710 RID: 30480
		internal static int __PropertyOffset_bEnableEnhancedDeterminism;

		// Token: 0x04007711 RID: 30481
		internal static int __PropertyOffset_AnimPhysicsMinDeltaTime;

		// Token: 0x04007712 RID: 30482
		internal static int __PropertyOffset_bSimulateAnimPhysicsAfterReset;

		// Token: 0x04007713 RID: 30483
		internal static int __PropertyOffset_MaxPhysicsDeltaTime;

		// Token: 0x04007714 RID: 30484
		internal static int __PropertyOffset_bSubstepping;

		// Token: 0x04007715 RID: 30485
		internal static int __PropertyOffset_bSubsteppingAsync;

		// Token: 0x04007716 RID: 30486
		internal static int __PropertyOffset_MaxSubstepDeltaTime;

		// Token: 0x04007717 RID: 30487
		internal static int __PropertyOffset_MaxSubsteps;

		// Token: 0x04007718 RID: 30488
		internal static int __PropertyOffset_SyncSceneSmoothingFactor;

		// Token: 0x04007719 RID: 30489
		internal static int __PropertyOffset_InitialAverageFrameRate;

		// Token: 0x0400771A RID: 30490
		internal static int __PropertyOffset_PhysXTreeRebuildRate;

		// Token: 0x0400771B RID: 30491
		internal static int __PropertyOffset_PhysicalSurfaces;

		// Token: 0x0400771C RID: 30492
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPhysicalSurfaceName> _PhysicalSurfaces;

		// Token: 0x0400771D RID: 30493
		internal static int __PropertyOffset_DefaultBroadphaseSettings;

		// Token: 0x0400771E RID: 30494
		[Nullable(2)]
		private FBroadphaseSettings _DefaultBroadphaseSettings;

		// Token: 0x0400771F RID: 30495
		internal static int __PropertyOffset_MinDeltaVelocityForHitEvents;

		// Token: 0x04007720 RID: 30496
		internal static int __PropertyOffset_ChaosSettings;

		// Token: 0x04007721 RID: 30497
		[Nullable(2)]
		private FChaosPhysicsSettings _ChaosSettings;
	}
}
