using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F94 RID: 3988
	[UnrealObjectPath("/Script/Engine.ParticleModuleRequired")]
	[UnrealStructLayout(328, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 328)]
	public class UParticleModuleRequired : UParticleModule, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D69C RID: 54940 RVA: 0x0013C20F File Offset: 0x0013A40F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleRequired._ClassPtr;
		}

		// Token: 0x0600D69D RID: 54941 RVA: 0x0013C21C File Offset: 0x0013A41C
		public UParticleModuleRequired() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleRequired.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D69E RID: 54942 RVA: 0x0013C244 File Offset: 0x0013A444
		[NullableContext(1)]
		public UParticleModuleRequired(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleRequired.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003262 RID: 12898
		// (get) Token: 0x0600D69F RID: 54943 RVA: 0x0013C277 File Offset: 0x0013A477
		// (set) Token: 0x0600D6A0 RID: 54944 RVA: 0x0013C28B File Offset: 0x0013A48B
		[Nullable(2)]
		public unsafe UMaterialInterface Material
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UParticleModuleRequired.__PropertyOffset_Material);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UParticleModuleRequired.__PropertyOffset_Material, value);
			}
		}

		// Token: 0x17003263 RID: 12899
		// (get) Token: 0x0600D6A1 RID: 54945 RVA: 0x0013C2A0 File Offset: 0x0013A4A0
		// (set) Token: 0x0600D6A2 RID: 54946 RVA: 0x0013C2B0 File Offset: 0x0013A4B0
		public unsafe float MinFacingCameraBlendDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_MinFacingCameraBlendDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_MinFacingCameraBlendDistance) = value;
			}
		}

		// Token: 0x17003264 RID: 12900
		// (get) Token: 0x0600D6A3 RID: 54947 RVA: 0x0013C2C1 File Offset: 0x0013A4C1
		// (set) Token: 0x0600D6A4 RID: 54948 RVA: 0x0013C2D1 File Offset: 0x0013A4D1
		public unsafe float MaxFacingCameraBlendDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_MaxFacingCameraBlendDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_MaxFacingCameraBlendDistance) = value;
			}
		}

		// Token: 0x17003265 RID: 12901
		// (get) Token: 0x0600D6A5 RID: 54949 RVA: 0x0013C2E2 File Offset: 0x0013A4E2
		// (set) Token: 0x0600D6A6 RID: 54950 RVA: 0x0013C2F6 File Offset: 0x0013A4F6
		public unsafe FVector EmitterOrigin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_EmitterOrigin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_EmitterOrigin) = value;
			}
		}

		// Token: 0x17003266 RID: 12902
		// (get) Token: 0x0600D6A7 RID: 54951 RVA: 0x0013C30B File Offset: 0x0013A50B
		// (set) Token: 0x0600D6A8 RID: 54952 RVA: 0x0013C31F File Offset: 0x0013A51F
		public unsafe FRotator EmitterRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_EmitterRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_EmitterRotation) = value;
			}
		}

		// Token: 0x17003267 RID: 12903
		// (get) Token: 0x0600D6A9 RID: 54953 RVA: 0x0013C334 File Offset: 0x0013A534
		// (set) Token: 0x0600D6AA RID: 54954 RVA: 0x0013C348 File Offset: 0x0013A548
		public unsafe TEnumAsByte<EParticleScreenAlignment> ScreenAlignment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_ScreenAlignment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_ScreenAlignment) = value;
			}
		}

		// Token: 0x17003268 RID: 12904
		// (get) Token: 0x0600D6AB RID: 54955 RVA: 0x0013C35D File Offset: 0x0013A55D
		// (set) Token: 0x0600D6AC RID: 54956 RVA: 0x0013C376 File Offset: 0x0013A576
		public unsafe bool bUseLocalSpace
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_bUseLocalSpace) & UParticleModuleRequired.__PropertyMask_bUseLocalSpace) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_bUseLocalSpace) = ((*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_bUseLocalSpace) & ~UParticleModuleRequired.__PropertyMask_bUseLocalSpace) | (value ? UParticleModuleRequired.__PropertyMask_bUseLocalSpace : 0));
			}
		}

		// Token: 0x17003269 RID: 12905
		// (get) Token: 0x0600D6AD RID: 54957 RVA: 0x0013C3A6 File Offset: 0x0013A5A6
		// (set) Token: 0x0600D6AE RID: 54958 RVA: 0x0013C3BF File Offset: 0x0013A5BF
		public unsafe bool bKillOnDeactivate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_bKillOnDeactivate) & UParticleModuleRequired.__PropertyMask_bKillOnDeactivate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_bKillOnDeactivate) = ((*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_bKillOnDeactivate) & ~UParticleModuleRequired.__PropertyMask_bKillOnDeactivate) | (value ? UParticleModuleRequired.__PropertyMask_bKillOnDeactivate : 0));
			}
		}

		// Token: 0x1700326A RID: 12906
		// (get) Token: 0x0600D6AF RID: 54959 RVA: 0x0013C3EF File Offset: 0x0013A5EF
		// (set) Token: 0x0600D6B0 RID: 54960 RVA: 0x0013C408 File Offset: 0x0013A608
		public unsafe bool bKillOnCompleted
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_bKillOnCompleted) & UParticleModuleRequired.__PropertyMask_bKillOnCompleted) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_bKillOnCompleted) = ((*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_bKillOnCompleted) & ~UParticleModuleRequired.__PropertyMask_bKillOnCompleted) | (value ? UParticleModuleRequired.__PropertyMask_bKillOnCompleted : 0));
			}
		}

		// Token: 0x1700326B RID: 12907
		// (get) Token: 0x0600D6B1 RID: 54961 RVA: 0x0013C438 File Offset: 0x0013A638
		// (set) Token: 0x0600D6B2 RID: 54962 RVA: 0x0013C44C File Offset: 0x0013A64C
		public unsafe TEnumAsByte<EParticleSortMode> SortMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_SortMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_SortMode) = value;
			}
		}

		// Token: 0x1700326C RID: 12908
		// (get) Token: 0x0600D6B3 RID: 54963 RVA: 0x0013C461 File Offset: 0x0013A661
		// (set) Token: 0x0600D6B4 RID: 54964 RVA: 0x0013C47A File Offset: 0x0013A67A
		public unsafe bool bUseLegacyEmitterTime
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_bUseLegacyEmitterTime) & UParticleModuleRequired.__PropertyMask_bUseLegacyEmitterTime) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_bUseLegacyEmitterTime) = ((*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_bUseLegacyEmitterTime) & ~UParticleModuleRequired.__PropertyMask_bUseLegacyEmitterTime) | (value ? UParticleModuleRequired.__PropertyMask_bUseLegacyEmitterTime : 0));
			}
		}

		// Token: 0x1700326D RID: 12909
		// (get) Token: 0x0600D6B5 RID: 54965 RVA: 0x0013C4AA File Offset: 0x0013A6AA
		// (set) Token: 0x0600D6B6 RID: 54966 RVA: 0x0013C4C3 File Offset: 0x0013A6C3
		public unsafe bool bRemoveHMDRoll
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_bRemoveHMDRoll) & UParticleModuleRequired.__PropertyMask_bRemoveHMDRoll) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_bRemoveHMDRoll) = ((*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_bRemoveHMDRoll) & ~UParticleModuleRequired.__PropertyMask_bRemoveHMDRoll) | (value ? UParticleModuleRequired.__PropertyMask_bRemoveHMDRoll : 0));
			}
		}

		// Token: 0x1700326E RID: 12910
		// (get) Token: 0x0600D6B7 RID: 54967 RVA: 0x0013C4F3 File Offset: 0x0013A6F3
		// (set) Token: 0x0600D6B8 RID: 54968 RVA: 0x0013C50C File Offset: 0x0013A70C
		public unsafe bool bEmitterDurationUseRange
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_bEmitterDurationUseRange) & UParticleModuleRequired.__PropertyMask_bEmitterDurationUseRange) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_bEmitterDurationUseRange) = ((*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_bEmitterDurationUseRange) & ~UParticleModuleRequired.__PropertyMask_bEmitterDurationUseRange) | (value ? UParticleModuleRequired.__PropertyMask_bEmitterDurationUseRange : 0));
			}
		}

		// Token: 0x1700326F RID: 12911
		// (get) Token: 0x0600D6B9 RID: 54969 RVA: 0x0013C53C File Offset: 0x0013A73C
		// (set) Token: 0x0600D6BA RID: 54970 RVA: 0x0013C54C File Offset: 0x0013A74C
		public unsafe float EmitterDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_EmitterDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_EmitterDuration) = value;
			}
		}

		// Token: 0x17003270 RID: 12912
		// (get) Token: 0x0600D6BB RID: 54971 RVA: 0x0013C560 File Offset: 0x0013A760
		// (set) Token: 0x0600D6BC RID: 54972 RVA: 0x0013C599 File Offset: 0x0013A799
		[Nullable(1)]
		public FRawDistributionFloat SpawnRate
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._SpawnRate) == null)
				{
					result = (this._SpawnRate = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_SpawnRate, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_SpawnRate, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003271 RID: 12913
		// (get) Token: 0x0600D6BD RID: 54973 RVA: 0x0013C5BC File Offset: 0x0013A7BC
		// (set) Token: 0x0600D6BE RID: 54974 RVA: 0x0013C5F5 File Offset: 0x0013A7F5
		[Nullable(1)]
		public TArray<FParticleBurst> BurstList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FParticleBurst> result;
				if ((result = this._BurstList) == null)
				{
					result = (this._BurstList = new TArray<FParticleBurst>(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_BurstList, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BurstList.CopyAssign(value);
			}
		}

		// Token: 0x17003272 RID: 12914
		// (get) Token: 0x0600D6BF RID: 54975 RVA: 0x0013C603 File Offset: 0x0013A803
		// (set) Token: 0x0600D6C0 RID: 54976 RVA: 0x0013C613 File Offset: 0x0013A813
		public unsafe float EmitterDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_EmitterDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_EmitterDelay) = value;
			}
		}

		// Token: 0x17003273 RID: 12915
		// (get) Token: 0x0600D6C1 RID: 54977 RVA: 0x0013C624 File Offset: 0x0013A824
		// (set) Token: 0x0600D6C2 RID: 54978 RVA: 0x0013C634 File Offset: 0x0013A834
		public unsafe float EmitterDelayLow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_EmitterDelayLow);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_EmitterDelayLow) = value;
			}
		}

		// Token: 0x17003274 RID: 12916
		// (get) Token: 0x0600D6C3 RID: 54979 RVA: 0x0013C645 File Offset: 0x0013A845
		// (set) Token: 0x0600D6C4 RID: 54980 RVA: 0x0013C65E File Offset: 0x0013A85E
		public unsafe bool bDelayFirstLoopOnly
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_bDelayFirstLoopOnly) & UParticleModuleRequired.__PropertyMask_bDelayFirstLoopOnly) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_bDelayFirstLoopOnly) = ((*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_bDelayFirstLoopOnly) & ~UParticleModuleRequired.__PropertyMask_bDelayFirstLoopOnly) | (value ? UParticleModuleRequired.__PropertyMask_bDelayFirstLoopOnly : 0));
			}
		}

		// Token: 0x17003275 RID: 12917
		// (get) Token: 0x0600D6C5 RID: 54981 RVA: 0x0013C68E File Offset: 0x0013A88E
		// (set) Token: 0x0600D6C6 RID: 54982 RVA: 0x0013C6A2 File Offset: 0x0013A8A2
		public unsafe TEnumAsByte<EParticleSubUVInterpMethod> InterpolationMethod
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_InterpolationMethod);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_InterpolationMethod) = value;
			}
		}

		// Token: 0x17003276 RID: 12918
		// (get) Token: 0x0600D6C7 RID: 54983 RVA: 0x0013C6B7 File Offset: 0x0013A8B7
		// (set) Token: 0x0600D6C8 RID: 54984 RVA: 0x0013C6D0 File Offset: 0x0013A8D0
		public unsafe bool bScaleUV
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_bScaleUV) & UParticleModuleRequired.__PropertyMask_bScaleUV) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_bScaleUV) = ((*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_bScaleUV) & ~UParticleModuleRequired.__PropertyMask_bScaleUV) | (value ? UParticleModuleRequired.__PropertyMask_bScaleUV : 0));
			}
		}

		// Token: 0x17003277 RID: 12919
		// (get) Token: 0x0600D6C9 RID: 54985 RVA: 0x0013C700 File Offset: 0x0013A900
		// (set) Token: 0x0600D6CA RID: 54986 RVA: 0x0013C719 File Offset: 0x0013A919
		public unsafe bool bEmitterDelayUseRange
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_bEmitterDelayUseRange) & UParticleModuleRequired.__PropertyMask_bEmitterDelayUseRange) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_bEmitterDelayUseRange) = ((*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_bEmitterDelayUseRange) & ~UParticleModuleRequired.__PropertyMask_bEmitterDelayUseRange) | (value ? UParticleModuleRequired.__PropertyMask_bEmitterDelayUseRange : 0));
			}
		}

		// Token: 0x17003278 RID: 12920
		// (get) Token: 0x0600D6CB RID: 54987 RVA: 0x0013C749 File Offset: 0x0013A949
		// (set) Token: 0x0600D6CC RID: 54988 RVA: 0x0013C75D File Offset: 0x0013A95D
		public unsafe TEnumAsByte<EParticleBurstMethod> ParticleBurstMethod
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_ParticleBurstMethod);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_ParticleBurstMethod) = value;
			}
		}

		// Token: 0x17003279 RID: 12921
		// (get) Token: 0x0600D6CD RID: 54989 RVA: 0x0013C772 File Offset: 0x0013A972
		// (set) Token: 0x0600D6CE RID: 54990 RVA: 0x0013C78B File Offset: 0x0013A98B
		public unsafe bool bOverrideSystemMacroUV
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_bOverrideSystemMacroUV) & UParticleModuleRequired.__PropertyMask_bOverrideSystemMacroUV) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_bOverrideSystemMacroUV) = ((*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_bOverrideSystemMacroUV) & ~UParticleModuleRequired.__PropertyMask_bOverrideSystemMacroUV) | (value ? UParticleModuleRequired.__PropertyMask_bOverrideSystemMacroUV : 0));
			}
		}

		// Token: 0x1700327A RID: 12922
		// (get) Token: 0x0600D6CF RID: 54991 RVA: 0x0013C7BB File Offset: 0x0013A9BB
		// (set) Token: 0x0600D6D0 RID: 54992 RVA: 0x0013C7D4 File Offset: 0x0013A9D4
		public unsafe bool bUseMaxDrawCount
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_bUseMaxDrawCount) & UParticleModuleRequired.__PropertyMask_bUseMaxDrawCount) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_bUseMaxDrawCount) = ((*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_bUseMaxDrawCount) & ~UParticleModuleRequired.__PropertyMask_bUseMaxDrawCount) | (value ? UParticleModuleRequired.__PropertyMask_bUseMaxDrawCount : 0));
			}
		}

		// Token: 0x1700327B RID: 12923
		// (get) Token: 0x0600D6D1 RID: 54993 RVA: 0x0013C804 File Offset: 0x0013AA04
		// (set) Token: 0x0600D6D2 RID: 54994 RVA: 0x0013C818 File Offset: 0x0013AA18
		public unsafe TEnumAsByte<EOpacitySourceMode> OpacitySourceMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_OpacitySourceMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_OpacitySourceMode) = value;
			}
		}

		// Token: 0x1700327C RID: 12924
		// (get) Token: 0x0600D6D3 RID: 54995 RVA: 0x0013C82D File Offset: 0x0013AA2D
		// (set) Token: 0x0600D6D4 RID: 54996 RVA: 0x0013C841 File Offset: 0x0013AA41
		public unsafe TEnumAsByte<EEmitterNormalsMode> EmitterNormalsMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_EmitterNormalsMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_EmitterNormalsMode) = value;
			}
		}

		// Token: 0x1700327D RID: 12925
		// (get) Token: 0x0600D6D5 RID: 54997 RVA: 0x0013C856 File Offset: 0x0013AA56
		// (set) Token: 0x0600D6D6 RID: 54998 RVA: 0x0013C86F File Offset: 0x0013AA6F
		public unsafe bool bOrbitModuleAffectsVelocityAlignment
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_bOrbitModuleAffectsVelocityAlignment) & UParticleModuleRequired.__PropertyMask_bOrbitModuleAffectsVelocityAlignment) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_bOrbitModuleAffectsVelocityAlignment) = ((*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_bOrbitModuleAffectsVelocityAlignment) & ~UParticleModuleRequired.__PropertyMask_bOrbitModuleAffectsVelocityAlignment) | (value ? UParticleModuleRequired.__PropertyMask_bOrbitModuleAffectsVelocityAlignment : 0));
			}
		}

		// Token: 0x1700327E RID: 12926
		// (get) Token: 0x0600D6D7 RID: 54999 RVA: 0x0013C89F File Offset: 0x0013AA9F
		// (set) Token: 0x0600D6D8 RID: 55000 RVA: 0x0013C8AF File Offset: 0x0013AAAF
		public unsafe int SubImages_Horizontal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_SubImages_Horizontal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_SubImages_Horizontal) = value;
			}
		}

		// Token: 0x1700327F RID: 12927
		// (get) Token: 0x0600D6D9 RID: 55001 RVA: 0x0013C8C0 File Offset: 0x0013AAC0
		// (set) Token: 0x0600D6DA RID: 55002 RVA: 0x0013C8D0 File Offset: 0x0013AAD0
		public unsafe int SubImages_Vertical
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_SubImages_Vertical);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_SubImages_Vertical) = value;
			}
		}

		// Token: 0x17003280 RID: 12928
		// (get) Token: 0x0600D6DB RID: 55003 RVA: 0x0013C8E1 File Offset: 0x0013AAE1
		// (set) Token: 0x0600D6DC RID: 55004 RVA: 0x0013C8F1 File Offset: 0x0013AAF1
		public unsafe float RandomImageTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_RandomImageTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_RandomImageTime) = value;
			}
		}

		// Token: 0x17003281 RID: 12929
		// (get) Token: 0x0600D6DD RID: 55005 RVA: 0x0013C902 File Offset: 0x0013AB02
		// (set) Token: 0x0600D6DE RID: 55006 RVA: 0x0013C912 File Offset: 0x0013AB12
		public unsafe int RandomImageChanges
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_RandomImageChanges);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_RandomImageChanges) = value;
			}
		}

		// Token: 0x17003282 RID: 12930
		// (get) Token: 0x0600D6DF RID: 55007 RVA: 0x0013C923 File Offset: 0x0013AB23
		// (set) Token: 0x0600D6E0 RID: 55008 RVA: 0x0013C937 File Offset: 0x0013AB37
		public unsafe FVector MacroUVPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_MacroUVPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_MacroUVPosition) = value;
			}
		}

		// Token: 0x17003283 RID: 12931
		// (get) Token: 0x0600D6E1 RID: 55009 RVA: 0x0013C94C File Offset: 0x0013AB4C
		// (set) Token: 0x0600D6E2 RID: 55010 RVA: 0x0013C95C File Offset: 0x0013AB5C
		public unsafe float MacroUVRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_MacroUVRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_MacroUVRadius) = value;
			}
		}

		// Token: 0x17003284 RID: 12932
		// (get) Token: 0x0600D6E3 RID: 55011 RVA: 0x0013C96D File Offset: 0x0013AB6D
		// (set) Token: 0x0600D6E4 RID: 55012 RVA: 0x0013C97D File Offset: 0x0013AB7D
		public unsafe EParticleUVFlipMode UVFlippingMode
		{
			get
			{
				return (EParticleUVFlipMode)(*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_UVFlippingMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_UVFlippingMode) = (byte)value;
			}
		}

		// Token: 0x17003285 RID: 12933
		// (get) Token: 0x0600D6E5 RID: 55013 RVA: 0x0013C98E File Offset: 0x0013AB8E
		// (set) Token: 0x0600D6E6 RID: 55014 RVA: 0x0013C9A2 File Offset: 0x0013ABA2
		public unsafe TEnumAsByte<ESubUVBoundingVertexCount> BoundingMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_BoundingMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_BoundingMode) = value;
			}
		}

		// Token: 0x17003286 RID: 12934
		// (get) Token: 0x0600D6E7 RID: 55015 RVA: 0x0013C9B7 File Offset: 0x0013ABB7
		// (set) Token: 0x0600D6E8 RID: 55016 RVA: 0x0013C9D0 File Offset: 0x0013ABD0
		public unsafe bool bDurationRecalcEachLoop
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_bDurationRecalcEachLoop) & UParticleModuleRequired.__PropertyMask_bDurationRecalcEachLoop) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_bDurationRecalcEachLoop) = ((*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_bDurationRecalcEachLoop) & ~UParticleModuleRequired.__PropertyMask_bDurationRecalcEachLoop) | (value ? UParticleModuleRequired.__PropertyMask_bDurationRecalcEachLoop : 0));
			}
		}

		// Token: 0x17003287 RID: 12935
		// (get) Token: 0x0600D6E9 RID: 55017 RVA: 0x0013CA00 File Offset: 0x0013AC00
		// (set) Token: 0x0600D6EA RID: 55018 RVA: 0x0013CA14 File Offset: 0x0013AC14
		public unsafe FVector NormalsSphereCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_NormalsSphereCenter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_NormalsSphereCenter) = value;
			}
		}

		// Token: 0x17003288 RID: 12936
		// (get) Token: 0x0600D6EB RID: 55019 RVA: 0x0013CA29 File Offset: 0x0013AC29
		// (set) Token: 0x0600D6EC RID: 55020 RVA: 0x0013CA39 File Offset: 0x0013AC39
		public unsafe float AlphaThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_AlphaThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_AlphaThreshold) = value;
			}
		}

		// Token: 0x17003289 RID: 12937
		// (get) Token: 0x0600D6ED RID: 55021 RVA: 0x0013CA4A File Offset: 0x0013AC4A
		// (set) Token: 0x0600D6EE RID: 55022 RVA: 0x0013CA5A File Offset: 0x0013AC5A
		public unsafe int EmitterLoops
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_EmitterLoops);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_EmitterLoops) = value;
			}
		}

		// Token: 0x1700328A RID: 12938
		// (get) Token: 0x0600D6EF RID: 55023 RVA: 0x0013CA6B File Offset: 0x0013AC6B
		// (set) Token: 0x0600D6F0 RID: 55024 RVA: 0x0013CA7F File Offset: 0x0013AC7F
		[Nullable(2)]
		public unsafe UTexture2D CutoutTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UParticleModuleRequired.__PropertyOffset_CutoutTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UParticleModuleRequired.__PropertyOffset_CutoutTexture, value);
			}
		}

		// Token: 0x1700328B RID: 12939
		// (get) Token: 0x0600D6F1 RID: 55025 RVA: 0x0013CA94 File Offset: 0x0013AC94
		// (set) Token: 0x0600D6F2 RID: 55026 RVA: 0x0013CAA4 File Offset: 0x0013ACA4
		public unsafe int MaxDrawCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_MaxDrawCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_MaxDrawCount) = value;
			}
		}

		// Token: 0x1700328C RID: 12940
		// (get) Token: 0x0600D6F3 RID: 55027 RVA: 0x0013CAB5 File Offset: 0x0013ACB5
		// (set) Token: 0x0600D6F4 RID: 55028 RVA: 0x0013CAC5 File Offset: 0x0013ACC5
		public unsafe float EmitterDurationLow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_EmitterDurationLow);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_EmitterDurationLow) = value;
			}
		}

		// Token: 0x1700328D RID: 12941
		// (get) Token: 0x0600D6F5 RID: 55029 RVA: 0x0013CAD6 File Offset: 0x0013ACD6
		// (set) Token: 0x0600D6F6 RID: 55030 RVA: 0x0013CAEA File Offset: 0x0013ACEA
		public unsafe FVector NormalsCylinderDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_NormalsCylinderDirection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_NormalsCylinderDirection) = value;
			}
		}

		// Token: 0x1700328E RID: 12942
		// (get) Token: 0x0600D6F7 RID: 55031 RVA: 0x0013CB00 File Offset: 0x0013AD00
		// (set) Token: 0x0600D6F8 RID: 55032 RVA: 0x0013CB39 File Offset: 0x0013AD39
		[Nullable(1)]
		public TArray<FName> NamedMaterialOverrides
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._NamedMaterialOverrides) == null)
				{
					result = (this._NamedMaterialOverrides = new TArray<FName>(base.NativePtr + (IntPtr)UParticleModuleRequired.__PropertyOffset_NamedMaterialOverrides, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.NamedMaterialOverrides.CopyAssign(value);
			}
		}

		// Token: 0x0600D6F9 RID: 55033 RVA: 0x0013CB47 File Offset: 0x0013AD47
		static UParticleModuleRequired()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleRequired");
		}

		// Token: 0x0600D6FA RID: 55034 RVA: 0x0013CB55 File Offset: 0x0013AD55
		protected UParticleModuleRequired(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040073F3 RID: 29683
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleRequired";

		// Token: 0x040073F4 RID: 29684
		private static IntPtr _ClassPtr;

		// Token: 0x040073F5 RID: 29685
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040073F6 RID: 29686
		internal static int __PropertyOffset_Material;

		// Token: 0x040073F7 RID: 29687
		internal static int __PropertyOffset_MinFacingCameraBlendDistance;

		// Token: 0x040073F8 RID: 29688
		internal static int __PropertyOffset_MaxFacingCameraBlendDistance;

		// Token: 0x040073F9 RID: 29689
		internal static int __PropertyOffset_EmitterOrigin;

		// Token: 0x040073FA RID: 29690
		internal static int __PropertyOffset_EmitterRotation;

		// Token: 0x040073FB RID: 29691
		internal static int __PropertyOffset_ScreenAlignment;

		// Token: 0x040073FC RID: 29692
		internal static int __PropertyOffset_bUseLocalSpace;

		// Token: 0x040073FD RID: 29693
		internal static byte __PropertyMask_bUseLocalSpace;

		// Token: 0x040073FE RID: 29694
		internal static int __PropertyOffset_bKillOnDeactivate;

		// Token: 0x040073FF RID: 29695
		internal static byte __PropertyMask_bKillOnDeactivate;

		// Token: 0x04007400 RID: 29696
		internal static int __PropertyOffset_bKillOnCompleted;

		// Token: 0x04007401 RID: 29697
		internal static byte __PropertyMask_bKillOnCompleted;

		// Token: 0x04007402 RID: 29698
		internal static int __PropertyOffset_SortMode;

		// Token: 0x04007403 RID: 29699
		internal static int __PropertyOffset_bUseLegacyEmitterTime;

		// Token: 0x04007404 RID: 29700
		internal static byte __PropertyMask_bUseLegacyEmitterTime;

		// Token: 0x04007405 RID: 29701
		internal static int __PropertyOffset_bRemoveHMDRoll;

		// Token: 0x04007406 RID: 29702
		internal static byte __PropertyMask_bRemoveHMDRoll;

		// Token: 0x04007407 RID: 29703
		internal static int __PropertyOffset_bEmitterDurationUseRange;

		// Token: 0x04007408 RID: 29704
		internal static byte __PropertyMask_bEmitterDurationUseRange;

		// Token: 0x04007409 RID: 29705
		internal static int __PropertyOffset_EmitterDuration;

		// Token: 0x0400740A RID: 29706
		internal static int __PropertyOffset_SpawnRate;

		// Token: 0x0400740B RID: 29707
		[Nullable(2)]
		private FRawDistributionFloat _SpawnRate;

		// Token: 0x0400740C RID: 29708
		internal static int __PropertyOffset_BurstList;

		// Token: 0x0400740D RID: 29709
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FParticleBurst> _BurstList;

		// Token: 0x0400740E RID: 29710
		internal static int __PropertyOffset_EmitterDelay;

		// Token: 0x0400740F RID: 29711
		internal static int __PropertyOffset_EmitterDelayLow;

		// Token: 0x04007410 RID: 29712
		internal static int __PropertyOffset_bDelayFirstLoopOnly;

		// Token: 0x04007411 RID: 29713
		internal static byte __PropertyMask_bDelayFirstLoopOnly;

		// Token: 0x04007412 RID: 29714
		internal static int __PropertyOffset_InterpolationMethod;

		// Token: 0x04007413 RID: 29715
		internal static int __PropertyOffset_bScaleUV;

		// Token: 0x04007414 RID: 29716
		internal static byte __PropertyMask_bScaleUV;

		// Token: 0x04007415 RID: 29717
		internal static int __PropertyOffset_bEmitterDelayUseRange;

		// Token: 0x04007416 RID: 29718
		internal static byte __PropertyMask_bEmitterDelayUseRange;

		// Token: 0x04007417 RID: 29719
		internal static int __PropertyOffset_ParticleBurstMethod;

		// Token: 0x04007418 RID: 29720
		internal static int __PropertyOffset_bOverrideSystemMacroUV;

		// Token: 0x04007419 RID: 29721
		internal static byte __PropertyMask_bOverrideSystemMacroUV;

		// Token: 0x0400741A RID: 29722
		internal static int __PropertyOffset_bUseMaxDrawCount;

		// Token: 0x0400741B RID: 29723
		internal static byte __PropertyMask_bUseMaxDrawCount;

		// Token: 0x0400741C RID: 29724
		internal static int __PropertyOffset_OpacitySourceMode;

		// Token: 0x0400741D RID: 29725
		internal static int __PropertyOffset_EmitterNormalsMode;

		// Token: 0x0400741E RID: 29726
		internal static int __PropertyOffset_bOrbitModuleAffectsVelocityAlignment;

		// Token: 0x0400741F RID: 29727
		internal static byte __PropertyMask_bOrbitModuleAffectsVelocityAlignment;

		// Token: 0x04007420 RID: 29728
		internal static int __PropertyOffset_SubImages_Horizontal;

		// Token: 0x04007421 RID: 29729
		internal static int __PropertyOffset_SubImages_Vertical;

		// Token: 0x04007422 RID: 29730
		internal static int __PropertyOffset_RandomImageTime;

		// Token: 0x04007423 RID: 29731
		internal static int __PropertyOffset_RandomImageChanges;

		// Token: 0x04007424 RID: 29732
		internal static int __PropertyOffset_MacroUVPosition;

		// Token: 0x04007425 RID: 29733
		internal static int __PropertyOffset_MacroUVRadius;

		// Token: 0x04007426 RID: 29734
		internal static int __PropertyOffset_UVFlippingMode;

		// Token: 0x04007427 RID: 29735
		internal static int __PropertyOffset_BoundingMode;

		// Token: 0x04007428 RID: 29736
		internal static int __PropertyOffset_bDurationRecalcEachLoop;

		// Token: 0x04007429 RID: 29737
		internal static byte __PropertyMask_bDurationRecalcEachLoop;

		// Token: 0x0400742A RID: 29738
		internal static int __PropertyOffset_NormalsSphereCenter;

		// Token: 0x0400742B RID: 29739
		internal static int __PropertyOffset_AlphaThreshold;

		// Token: 0x0400742C RID: 29740
		internal static int __PropertyOffset_EmitterLoops;

		// Token: 0x0400742D RID: 29741
		internal static int __PropertyOffset_CutoutTexture;

		// Token: 0x0400742E RID: 29742
		internal static int __PropertyOffset_MaxDrawCount;

		// Token: 0x0400742F RID: 29743
		internal static int __PropertyOffset_EmitterDurationLow;

		// Token: 0x04007430 RID: 29744
		internal static int __PropertyOffset_NormalsCylinderDirection;

		// Token: 0x04007431 RID: 29745
		internal static int __PropertyOffset_NamedMaterialOverrides;

		// Token: 0x04007432 RID: 29746
		[Nullable(2)]
		private TArray<FName> _NamedMaterialOverrides;
	}
}
