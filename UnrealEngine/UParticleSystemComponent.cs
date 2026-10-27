using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FC5 RID: 4037
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleSystemComponent")]
	[UnrealStructLayout(2192, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2192)]
	public class UParticleSystemComponent : UFXSystemComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D985 RID: 55685 RVA: 0x0014124C File Offset: 0x0013F44C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleSystemComponent._ClassPtr;
		}

		// Token: 0x0600D986 RID: 55686 RVA: 0x00141258 File Offset: 0x0013F458
		public UParticleSystemComponent() : this(BuiltinUtils.AllocNativeUObject(UParticleSystemComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D987 RID: 55687 RVA: 0x00141280 File Offset: 0x0013F480
		public UParticleSystemComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleSystemComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003359 RID: 13145
		// (get) Token: 0x0600D988 RID: 55688 RVA: 0x001412B3 File Offset: 0x0013F4B3
		// (set) Token: 0x0600D989 RID: 55689 RVA: 0x001412C7 File Offset: 0x0013F4C7
		[Nullable(2)]
		public unsafe UParticleSystem Template
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UParticleSystem>(base.NativePtr / (IntPtr)sizeof(void*) + UParticleSystemComponent.__PropertyOffset_Template);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UParticleSystemComponent.__PropertyOffset_Template, value);
			}
		}

		// Token: 0x1700335A RID: 13146
		// (get) Token: 0x0600D98A RID: 55690 RVA: 0x001412DC File Offset: 0x0013F4DC
		// (set) Token: 0x0600D98B RID: 55691 RVA: 0x00141315 File Offset: 0x0013F515
		public TArray<UMaterialInterface> EmitterMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._EmitterMaterials) == null)
				{
					result = (this._EmitterMaterials = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_EmitterMaterials, this));
				}
				return result;
			}
			set
			{
				this.EmitterMaterials.CopyAssign(value);
			}
		}

		// Token: 0x1700335B RID: 13147
		// (get) Token: 0x0600D98C RID: 55692 RVA: 0x00141324 File Offset: 0x0013F524
		// (set) Token: 0x0600D98D RID: 55693 RVA: 0x0014135D File Offset: 0x0013F55D
		public TArray<USkeletalMeshComponent> SkelMeshComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<USkeletalMeshComponent> result;
				if ((result = this._SkelMeshComponents) == null)
				{
					result = (this._SkelMeshComponents = new TArray<USkeletalMeshComponent>(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_SkelMeshComponents, this));
				}
				return result;
			}
			set
			{
				this.SkelMeshComponents.CopyAssign(value);
			}
		}

		// Token: 0x1700335C RID: 13148
		// (get) Token: 0x0600D98E RID: 55694 RVA: 0x0014136B File Offset: 0x0013F56B
		// (set) Token: 0x0600D98F RID: 55695 RVA: 0x00141384 File Offset: 0x0013F584
		public unsafe bool bResetOnDetach
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_bResetOnDetach) & UParticleSystemComponent.__PropertyMask_bResetOnDetach) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_bResetOnDetach) = ((*(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_bResetOnDetach) & ~UParticleSystemComponent.__PropertyMask_bResetOnDetach) | (value ? UParticleSystemComponent.__PropertyMask_bResetOnDetach : 0));
			}
		}

		// Token: 0x1700335D RID: 13149
		// (get) Token: 0x0600D990 RID: 55696 RVA: 0x001413B4 File Offset: 0x0013F5B4
		// (set) Token: 0x0600D991 RID: 55697 RVA: 0x001413CD File Offset: 0x0013F5CD
		public unsafe bool bUpdateOnDedicatedServer
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_bUpdateOnDedicatedServer) & UParticleSystemComponent.__PropertyMask_bUpdateOnDedicatedServer) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_bUpdateOnDedicatedServer) = ((*(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_bUpdateOnDedicatedServer) & ~UParticleSystemComponent.__PropertyMask_bUpdateOnDedicatedServer) | (value ? UParticleSystemComponent.__PropertyMask_bUpdateOnDedicatedServer : 0));
			}
		}

		// Token: 0x1700335E RID: 13150
		// (get) Token: 0x0600D992 RID: 55698 RVA: 0x001413FD File Offset: 0x0013F5FD
		// (set) Token: 0x0600D993 RID: 55699 RVA: 0x00141416 File Offset: 0x0013F616
		public unsafe bool bAllowRecycling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_bAllowRecycling) & UParticleSystemComponent.__PropertyMask_bAllowRecycling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_bAllowRecycling) = ((*(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_bAllowRecycling) & ~UParticleSystemComponent.__PropertyMask_bAllowRecycling) | (value ? UParticleSystemComponent.__PropertyMask_bAllowRecycling : 0));
			}
		}

		// Token: 0x1700335F RID: 13151
		// (get) Token: 0x0600D994 RID: 55700 RVA: 0x00141446 File Offset: 0x0013F646
		// (set) Token: 0x0600D995 RID: 55701 RVA: 0x0014145F File Offset: 0x0013F65F
		public unsafe bool bAutoManageAttachment
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_bAutoManageAttachment) & UParticleSystemComponent.__PropertyMask_bAutoManageAttachment) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_bAutoManageAttachment) = ((*(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_bAutoManageAttachment) & ~UParticleSystemComponent.__PropertyMask_bAutoManageAttachment) | (value ? UParticleSystemComponent.__PropertyMask_bAutoManageAttachment : 0));
			}
		}

		// Token: 0x17003360 RID: 13152
		// (get) Token: 0x0600D996 RID: 55702 RVA: 0x0014148F File Offset: 0x0013F68F
		// (set) Token: 0x0600D997 RID: 55703 RVA: 0x001414A8 File Offset: 0x0013F6A8
		public unsafe bool bAutoAttachWeldSimulatedBodies
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_bAutoAttachWeldSimulatedBodies) & UParticleSystemComponent.__PropertyMask_bAutoAttachWeldSimulatedBodies) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_bAutoAttachWeldSimulatedBodies) = ((*(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_bAutoAttachWeldSimulatedBodies) & ~UParticleSystemComponent.__PropertyMask_bAutoAttachWeldSimulatedBodies) | (value ? UParticleSystemComponent.__PropertyMask_bAutoAttachWeldSimulatedBodies : 0));
			}
		}

		// Token: 0x17003361 RID: 13153
		// (get) Token: 0x0600D998 RID: 55704 RVA: 0x001414D8 File Offset: 0x0013F6D8
		// (set) Token: 0x0600D999 RID: 55705 RVA: 0x001414F1 File Offset: 0x0013F6F1
		public unsafe bool bWarmingUp
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_bWarmingUp) & UParticleSystemComponent.__PropertyMask_bWarmingUp) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_bWarmingUp) = ((*(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_bWarmingUp) & ~UParticleSystemComponent.__PropertyMask_bWarmingUp) | (value ? UParticleSystemComponent.__PropertyMask_bWarmingUp : 0));
			}
		}

		// Token: 0x17003362 RID: 13154
		// (get) Token: 0x0600D99A RID: 55706 RVA: 0x00141521 File Offset: 0x0013F721
		// (set) Token: 0x0600D99B RID: 55707 RVA: 0x0014153A File Offset: 0x0013F73A
		public unsafe bool bOverrideLODMethod
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_bOverrideLODMethod) & UParticleSystemComponent.__PropertyMask_bOverrideLODMethod) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_bOverrideLODMethod) = ((*(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_bOverrideLODMethod) & ~UParticleSystemComponent.__PropertyMask_bOverrideLODMethod) | (value ? UParticleSystemComponent.__PropertyMask_bOverrideLODMethod : 0));
			}
		}

		// Token: 0x17003363 RID: 13155
		// (get) Token: 0x0600D99C RID: 55708 RVA: 0x0014156A File Offset: 0x0013F76A
		// (set) Token: 0x0600D99D RID: 55709 RVA: 0x00141583 File Offset: 0x0013F783
		public unsafe bool bSkipUpdateDynamicDataDuringTick
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_bSkipUpdateDynamicDataDuringTick) & UParticleSystemComponent.__PropertyMask_bSkipUpdateDynamicDataDuringTick) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_bSkipUpdateDynamicDataDuringTick) = ((*(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_bSkipUpdateDynamicDataDuringTick) & ~UParticleSystemComponent.__PropertyMask_bSkipUpdateDynamicDataDuringTick) | (value ? UParticleSystemComponent.__PropertyMask_bSkipUpdateDynamicDataDuringTick : 0));
			}
		}

		// Token: 0x17003364 RID: 13156
		// (get) Token: 0x0600D99E RID: 55710 RVA: 0x001415B3 File Offset: 0x0013F7B3
		// (set) Token: 0x0600D99F RID: 55711 RVA: 0x001415C7 File Offset: 0x0013F7C7
		[Nullable(0)]
		public unsafe TEnumAsByte<ParticleSystemLODMethod> LODMethod
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_LODMethod);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_LODMethod) = value;
			}
		}

		// Token: 0x17003365 RID: 13157
		// (get) Token: 0x0600D9A0 RID: 55712 RVA: 0x001415DC File Offset: 0x0013F7DC
		// (set) Token: 0x0600D9A1 RID: 55713 RVA: 0x001415EC File Offset: 0x0013F7EC
		public unsafe EParticleSignificanceLevel RequiredSignificance
		{
			get
			{
				return (EParticleSignificanceLevel)(*(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_RequiredSignificance));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_RequiredSignificance) = (byte)value;
			}
		}

		// Token: 0x17003366 RID: 13158
		// (get) Token: 0x0600D9A2 RID: 55714 RVA: 0x00141600 File Offset: 0x0013F800
		// (set) Token: 0x0600D9A3 RID: 55715 RVA: 0x00141639 File Offset: 0x0013F839
		public TArray<FParticleSysParam> InstanceParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FParticleSysParam> result;
				if ((result = this._InstanceParameters) == null)
				{
					result = (this._InstanceParameters = new TArray<FParticleSysParam>(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_InstanceParameters, this));
				}
				return result;
			}
			set
			{
				this.InstanceParameters.CopyAssign(value);
			}
		}

		// Token: 0x17003367 RID: 13159
		// (get) Token: 0x0600D9A4 RID: 55716 RVA: 0x00141648 File Offset: 0x0013F848
		// (set) Token: 0x0600D9A5 RID: 55717 RVA: 0x00141681 File Offset: 0x0013F881
		public FParticleSpawnSignature OnParticleSpawn
		{
			get
			{
				base.FastCheckIsValid();
				FParticleSpawnSignature result;
				if ((result = this._OnParticleSpawn) == null)
				{
					result = (this._OnParticleSpawn = new FParticleSpawnSignature(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_OnParticleSpawn, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_OnParticleSpawn, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17003368 RID: 13160
		// (get) Token: 0x0600D9A6 RID: 55718 RVA: 0x001416A4 File Offset: 0x0013F8A4
		// (set) Token: 0x0600D9A7 RID: 55719 RVA: 0x001416DD File Offset: 0x0013F8DD
		public FParticleBurstSignature OnParticleBurst
		{
			get
			{
				base.FastCheckIsValid();
				FParticleBurstSignature result;
				if ((result = this._OnParticleBurst) == null)
				{
					result = (this._OnParticleBurst = new FParticleBurstSignature(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_OnParticleBurst, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_OnParticleBurst, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17003369 RID: 13161
		// (get) Token: 0x0600D9A8 RID: 55720 RVA: 0x00141700 File Offset: 0x0013F900
		// (set) Token: 0x0600D9A9 RID: 55721 RVA: 0x00141739 File Offset: 0x0013F939
		public FParticleDeathSignature OnParticleDeath
		{
			get
			{
				base.FastCheckIsValid();
				FParticleDeathSignature result;
				if ((result = this._OnParticleDeath) == null)
				{
					result = (this._OnParticleDeath = new FParticleDeathSignature(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_OnParticleDeath, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_OnParticleDeath, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700336A RID: 13162
		// (get) Token: 0x0600D9AA RID: 55722 RVA: 0x0014175C File Offset: 0x0013F95C
		// (set) Token: 0x0600D9AB RID: 55723 RVA: 0x00141795 File Offset: 0x0013F995
		public FParticleCollisionSignature OnParticleCollide
		{
			get
			{
				base.FastCheckIsValid();
				FParticleCollisionSignature result;
				if ((result = this._OnParticleCollide) == null)
				{
					result = (this._OnParticleCollide = new FParticleCollisionSignature(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_OnParticleCollide, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_OnParticleCollide, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700336B RID: 13163
		// (get) Token: 0x0600D9AC RID: 55724 RVA: 0x001417B6 File Offset: 0x0013F9B6
		// (set) Token: 0x0600D9AD RID: 55725 RVA: 0x001417C6 File Offset: 0x0013F9C6
		public unsafe bool bOldPositionValid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_bOldPositionValid) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_bOldPositionValid) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700336C RID: 13164
		// (get) Token: 0x0600D9AE RID: 55726 RVA: 0x001417D7 File Offset: 0x0013F9D7
		// (set) Token: 0x0600D9AF RID: 55727 RVA: 0x001417EB File Offset: 0x0013F9EB
		public unsafe FVector OldPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_OldPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_OldPosition) = value;
			}
		}

		// Token: 0x1700336D RID: 13165
		// (get) Token: 0x0600D9B0 RID: 55728 RVA: 0x00141800 File Offset: 0x0013FA00
		// (set) Token: 0x0600D9B1 RID: 55729 RVA: 0x00141814 File Offset: 0x0013FA14
		public unsafe FVector PartSysVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_PartSysVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_PartSysVelocity) = value;
			}
		}

		// Token: 0x1700336E RID: 13166
		// (get) Token: 0x0600D9B2 RID: 55730 RVA: 0x00141829 File Offset: 0x0013FA29
		// (set) Token: 0x0600D9B3 RID: 55731 RVA: 0x00141839 File Offset: 0x0013FA39
		public unsafe float WarmupTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_WarmupTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_WarmupTime) = value;
			}
		}

		// Token: 0x1700336F RID: 13167
		// (get) Token: 0x0600D9B4 RID: 55732 RVA: 0x0014184A File Offset: 0x0013FA4A
		// (set) Token: 0x0600D9B5 RID: 55733 RVA: 0x0014185A File Offset: 0x0013FA5A
		public unsafe float WarmupTickRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_WarmupTickRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_WarmupTickRate) = value;
			}
		}

		// Token: 0x17003370 RID: 13168
		// (get) Token: 0x0600D9B6 RID: 55734 RVA: 0x0014186B File Offset: 0x0013FA6B
		// (set) Token: 0x0600D9B7 RID: 55735 RVA: 0x0014187B File Offset: 0x0013FA7B
		public unsafe float SecondsBeforeInactive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_SecondsBeforeInactive);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_SecondsBeforeInactive) = value;
			}
		}

		// Token: 0x17003371 RID: 13169
		// (get) Token: 0x0600D9B8 RID: 55736 RVA: 0x0014188C File Offset: 0x0013FA8C
		// (set) Token: 0x0600D9B9 RID: 55737 RVA: 0x0014189C File Offset: 0x0013FA9C
		public unsafe float MaxTimeBeforeForceUpdateTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_MaxTimeBeforeForceUpdateTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_MaxTimeBeforeForceUpdateTransform) = value;
			}
		}

		// Token: 0x17003372 RID: 13170
		// (get) Token: 0x0600D9BA RID: 55738 RVA: 0x001418B0 File Offset: 0x0013FAB0
		// (set) Token: 0x0600D9BB RID: 55739 RVA: 0x001418E9 File Offset: 0x0013FAE9
		public TArray<UParticleSystemReplay> ReplayClips
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UParticleSystemReplay> result;
				if ((result = this._ReplayClips) == null)
				{
					result = (this._ReplayClips = new TArray<UParticleSystemReplay>(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_ReplayClips, this));
				}
				return result;
			}
			set
			{
				this.ReplayClips.CopyAssign(value);
			}
		}

		// Token: 0x17003373 RID: 13171
		// (get) Token: 0x0600D9BC RID: 55740 RVA: 0x001418F7 File Offset: 0x0013FAF7
		// (set) Token: 0x0600D9BD RID: 55741 RVA: 0x00141907 File Offset: 0x0013FB07
		public unsafe float CustomTimeDilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_CustomTimeDilation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_CustomTimeDilation) = value;
			}
		}

		// Token: 0x17003374 RID: 13172
		// (get) Token: 0x0600D9BE RID: 55742 RVA: 0x00141918 File Offset: 0x0013FB18
		// (set) Token: 0x0600D9BF RID: 55743 RVA: 0x0014192C File Offset: 0x0013FB2C
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<USceneComponent> AutoAttachParent
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_AutoAttachParent);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_AutoAttachParent) = value;
			}
		}

		// Token: 0x17003375 RID: 13173
		// (get) Token: 0x0600D9C0 RID: 55744 RVA: 0x00141941 File Offset: 0x0013FB41
		// (set) Token: 0x0600D9C1 RID: 55745 RVA: 0x00141955 File Offset: 0x0013FB55
		public unsafe FName AutoAttachSocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_AutoAttachSocketName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_AutoAttachSocketName) = value;
			}
		}

		// Token: 0x17003376 RID: 13174
		// (get) Token: 0x0600D9C2 RID: 55746 RVA: 0x0014196A File Offset: 0x0013FB6A
		// (set) Token: 0x0600D9C3 RID: 55747 RVA: 0x0014197A File Offset: 0x0013FB7A
		public unsafe EAttachmentRule AutoAttachLocationRule
		{
			get
			{
				return (EAttachmentRule)(*(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_AutoAttachLocationRule));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_AutoAttachLocationRule) = (byte)value;
			}
		}

		// Token: 0x17003377 RID: 13175
		// (get) Token: 0x0600D9C4 RID: 55748 RVA: 0x0014198B File Offset: 0x0013FB8B
		// (set) Token: 0x0600D9C5 RID: 55749 RVA: 0x0014199B File Offset: 0x0013FB9B
		public unsafe EAttachmentRule AutoAttachRotationRule
		{
			get
			{
				return (EAttachmentRule)(*(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_AutoAttachRotationRule));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_AutoAttachRotationRule) = (byte)value;
			}
		}

		// Token: 0x17003378 RID: 13176
		// (get) Token: 0x0600D9C6 RID: 55750 RVA: 0x001419AC File Offset: 0x0013FBAC
		// (set) Token: 0x0600D9C7 RID: 55751 RVA: 0x001419BC File Offset: 0x0013FBBC
		public unsafe EAttachmentRule AutoAttachScaleRule
		{
			get
			{
				return (EAttachmentRule)(*(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_AutoAttachScaleRule));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_AutoAttachScaleRule) = (byte)value;
			}
		}

		// Token: 0x17003379 RID: 13177
		// (get) Token: 0x0600D9C8 RID: 55752 RVA: 0x001419D0 File Offset: 0x0013FBD0
		// (set) Token: 0x0600D9C9 RID: 55753 RVA: 0x00141A09 File Offset: 0x0013FC09
		public FOnSystemFinished OnSystemFinished
		{
			get
			{
				base.FastCheckIsValid();
				FOnSystemFinished result;
				if ((result = this._OnSystemFinished) == null)
				{
					result = (this._OnSystemFinished = new FOnSystemFinished(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_OnSystemFinished, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UParticleSystemComponent.__PropertyOffset_OnSystemFinished, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0600D9CA RID: 55754 RVA: 0x00141A2A File Offset: 0x0013FC2A
		public void SetTrailSourceData(FName InFirstSocketName, FName InSecondSocketName, ETrailWidthMode InWidthMode, float InWidth)
		{
			UParticleSystemComponent.__SetTrailSourceData_Internal(base.NativePtr, InFirstSocketName, InSecondSocketName, InWidthMode, InWidth);
		}

		// Token: 0x0600D9CB RID: 55755 RVA: 0x00141A41 File Offset: 0x0013FC41
		[NullableContext(2)]
		public void SetTemplate(UParticleSystem NewTemplate)
		{
			UParticleSystemComponent.__SetTemplate_Internal(base.NativePtr, (NewTemplate != null) ? NewTemplate.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600D9CC RID: 55756 RVA: 0x00141A5E File Offset: 0x0013FC5E
		[NullableContext(2)]
		public void SetMaterialParameter(FName ParameterName, UMaterialInterface Param)
		{
			UParticleSystemComponent.__SetMaterialParameter_Internal(base.NativePtr, ParameterName, (Param != null) ? Param.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600D9CD RID: 55757 RVA: 0x00141A7C File Offset: 0x0013FC7C
		public void SetBeamTargetTangent(int EmitterIndex, FVector NewTangentPoint, int TargetIndex)
		{
			UParticleSystemComponent.__SetBeamTargetTangent_Internal(base.NativePtr, EmitterIndex, NewTangentPoint, TargetIndex);
		}

		// Token: 0x0600D9CE RID: 55758 RVA: 0x00141A8C File Offset: 0x0013FC8C
		public void SetBeamTargetStrength(int EmitterIndex, float NewTargetStrength, int TargetIndex)
		{
			UParticleSystemComponent.__SetBeamTargetStrength_Internal(base.NativePtr, EmitterIndex, NewTargetStrength, TargetIndex);
		}

		// Token: 0x0600D9CF RID: 55759 RVA: 0x00141A9C File Offset: 0x0013FC9C
		public void SetBeamTargetPoint(int EmitterIndex, FVector NewTargetPoint, int TargetIndex)
		{
			UParticleSystemComponent.__SetBeamTargetPoint_Internal(base.NativePtr, EmitterIndex, NewTargetPoint, TargetIndex);
		}

		// Token: 0x0600D9D0 RID: 55760 RVA: 0x00141AAC File Offset: 0x0013FCAC
		public void SetBeamSourceTangent(int EmitterIndex, FVector NewTangentPoint, int SourceIndex)
		{
			UParticleSystemComponent.__SetBeamSourceTangent_Internal(base.NativePtr, EmitterIndex, NewTangentPoint, SourceIndex);
		}

		// Token: 0x0600D9D1 RID: 55761 RVA: 0x00141ABC File Offset: 0x0013FCBC
		public void SetBeamSourceStrength(int EmitterIndex, float NewSourceStrength, int SourceIndex)
		{
			UParticleSystemComponent.__SetBeamSourceStrength_Internal(base.NativePtr, EmitterIndex, NewSourceStrength, SourceIndex);
		}

		// Token: 0x0600D9D2 RID: 55762 RVA: 0x00141ACC File Offset: 0x0013FCCC
		public void SetBeamSourcePoint(int EmitterIndex, FVector NewSourcePoint, int SourceIndex)
		{
			UParticleSystemComponent.__SetBeamSourcePoint_Internal(base.NativePtr, EmitterIndex, NewSourcePoint, SourceIndex);
		}

		// Token: 0x0600D9D3 RID: 55763 RVA: 0x00141ADC File Offset: 0x0013FCDC
		public void SetBeamEndPoint(int EmitterIndex, FVector NewEndPoint)
		{
			UParticleSystemComponent.__SetBeamEndPoint_Internal(base.NativePtr, EmitterIndex, NewEndPoint);
		}

		// Token: 0x0600D9D4 RID: 55764 RVA: 0x00141AEB File Offset: 0x0013FCEB
		[NullableContext(2)]
		public void SetAutoAttachParams(USceneComponent Parent, FName SocketName = default(FName), EAttachLocation LocationType = EAttachLocation.KeepRelativeOffset)
		{
			UParticleSystemComponent.__SetAutoAttachParams_Internal(base.NativePtr, (Parent != null) ? Parent.NativePtr : IntPtr.Zero, SocketName, LocationType);
		}

		// Token: 0x0600D9D5 RID: 55765 RVA: 0x00141B0F File Offset: 0x0013FD0F
		public int GetNumActiveParticles()
		{
			return UParticleSystemComponent.__GetNumActiveParticles_Internal(base.NativePtr);
		}

		// Token: 0x0600D9D6 RID: 55766 RVA: 0x00141B1C File Offset: 0x0013FD1C
		[NullableContext(2)]
		public UMaterialInterface GetNamedMaterial(FName InName)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInterface>(UParticleSystemComponent.__GetNamedMaterial_Internal(base.NativePtr, InName));
		}

		// Token: 0x0600D9D7 RID: 55767 RVA: 0x00141B30 File Offset: 0x0013FD30
		public unsafe bool GetBeamTargetTangent(int EmitterIndex, int TargetIndex, ref FVector OutTangentPoint)
		{
			fixed (FVector* ptr = &OutTangentPoint)
			{
				void* ptr2 = (void*)ptr;
				return UParticleSystemComponent.__GetBeamTargetTangent_Internal(base.NativePtr, EmitterIndex, TargetIndex, ref OutTangentPoint);
			}
		}

		// Token: 0x0600D9D8 RID: 55768 RVA: 0x00141B50 File Offset: 0x0013FD50
		public unsafe bool GetBeamTargetStrength(int EmitterIndex, int TargetIndex, ref float OutTargetStrength)
		{
			fixed (float* ptr = &OutTargetStrength)
			{
				void* ptr2 = (void*)ptr;
				return UParticleSystemComponent.__GetBeamTargetStrength_Internal(base.NativePtr, EmitterIndex, TargetIndex, ref OutTargetStrength);
			}
		}

		// Token: 0x0600D9D9 RID: 55769 RVA: 0x00141B70 File Offset: 0x0013FD70
		public unsafe bool GetBeamTargetPoint(int EmitterIndex, int TargetIndex, ref FVector OutTargetPoint)
		{
			fixed (FVector* ptr = &OutTargetPoint)
			{
				void* ptr2 = (void*)ptr;
				return UParticleSystemComponent.__GetBeamTargetPoint_Internal(base.NativePtr, EmitterIndex, TargetIndex, ref OutTargetPoint);
			}
		}

		// Token: 0x0600D9DA RID: 55770 RVA: 0x00141B90 File Offset: 0x0013FD90
		public unsafe bool GetBeamSourceTangent(int EmitterIndex, int SourceIndex, ref FVector OutTangentPoint)
		{
			fixed (FVector* ptr = &OutTangentPoint)
			{
				void* ptr2 = (void*)ptr;
				return UParticleSystemComponent.__GetBeamSourceTangent_Internal(base.NativePtr, EmitterIndex, SourceIndex, ref OutTangentPoint);
			}
		}

		// Token: 0x0600D9DB RID: 55771 RVA: 0x00141BB0 File Offset: 0x0013FDB0
		public unsafe bool GetBeamSourceStrength(int EmitterIndex, int SourceIndex, ref float OutSourceStrength)
		{
			fixed (float* ptr = &OutSourceStrength)
			{
				void* ptr2 = (void*)ptr;
				return UParticleSystemComponent.__GetBeamSourceStrength_Internal(base.NativePtr, EmitterIndex, SourceIndex, ref OutSourceStrength);
			}
		}

		// Token: 0x0600D9DC RID: 55772 RVA: 0x00141BD0 File Offset: 0x0013FDD0
		public unsafe bool GetBeamSourcePoint(int EmitterIndex, int SourceIndex, ref FVector OutSourcePoint)
		{
			fixed (FVector* ptr = &OutSourcePoint)
			{
				void* ptr2 = (void*)ptr;
				return UParticleSystemComponent.__GetBeamSourcePoint_Internal(base.NativePtr, EmitterIndex, SourceIndex, ref OutSourcePoint);
			}
		}

		// Token: 0x0600D9DD RID: 55773 RVA: 0x00141BF0 File Offset: 0x0013FDF0
		public unsafe bool GetBeamEndPoint(int EmitterIndex, ref FVector OutEndPoint)
		{
			fixed (FVector* ptr = &OutEndPoint)
			{
				void* ptr2 = (void*)ptr;
				return UParticleSystemComponent.__GetBeamEndPoint_Internal(base.NativePtr, EmitterIndex, ref OutEndPoint);
			}
		}

		// Token: 0x0600D9DE RID: 55774 RVA: 0x00141C0F File Offset: 0x0013FE0F
		public void GenerateParticleEvent(FName InEventName, float InEmitterTime, FVector InLocation, FVector InDirection, FVector InVelocity)
		{
			UParticleSystemComponent.__GenerateParticleEvent_Internal(base.NativePtr, InEventName, InEmitterTime, InLocation, InDirection, InVelocity);
		}

		// Token: 0x0600D9DF RID: 55775 RVA: 0x00141C23 File Offset: 0x0013FE23
		public void EndTrails()
		{
			UParticleSystemComponent.__EndTrails_Internal(base.NativePtr);
		}

		// Token: 0x0600D9E0 RID: 55776 RVA: 0x00141C30 File Offset: 0x0013FE30
		[NullableContext(2)]
		public UMaterialInstanceDynamic CreateNamedDynamicMaterialInstance(FName InName, UMaterialInterface SourceMaterial = null)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(UParticleSystemComponent.__CreateNamedDynamicMaterialInstance_Internal(base.NativePtr, InName, (SourceMaterial != null) ? SourceMaterial.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0600D9E1 RID: 55777 RVA: 0x00141C53 File Offset: 0x0013FE53
		public void BeginTrails(FName InFirstSocketName, FName InSecondSocketName, ETrailWidthMode InWidthMode, float InWidth)
		{
			UParticleSystemComponent.__BeginTrails_Internal(base.NativePtr, InFirstSocketName, InSecondSocketName, InWidthMode, InWidth);
		}

		// Token: 0x0600D9E2 RID: 55778
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTrailSourceData_Internal(IntPtr @this, FName InFirstSocketName, FName InSecondSocketName, TEnumAsByte<ETrailWidthMode> InWidthMode, float InWidth);

		// Token: 0x0600D9E3 RID: 55779
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTemplate_Internal(IntPtr @this, IntPtr NewTemplate);

		// Token: 0x0600D9E4 RID: 55780
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaterialParameter_Internal(IntPtr @this, FName ParameterName, IntPtr Param);

		// Token: 0x0600D9E5 RID: 55781
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBeamTargetTangent_Internal(IntPtr @this, int EmitterIndex, FVector NewTangentPoint, int TargetIndex);

		// Token: 0x0600D9E6 RID: 55782
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBeamTargetStrength_Internal(IntPtr @this, int EmitterIndex, float NewTargetStrength, int TargetIndex);

		// Token: 0x0600D9E7 RID: 55783
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBeamTargetPoint_Internal(IntPtr @this, int EmitterIndex, FVector NewTargetPoint, int TargetIndex);

		// Token: 0x0600D9E8 RID: 55784
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBeamSourceTangent_Internal(IntPtr @this, int EmitterIndex, FVector NewTangentPoint, int SourceIndex);

		// Token: 0x0600D9E9 RID: 55785
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBeamSourceStrength_Internal(IntPtr @this, int EmitterIndex, float NewSourceStrength, int SourceIndex);

		// Token: 0x0600D9EA RID: 55786
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBeamSourcePoint_Internal(IntPtr @this, int EmitterIndex, FVector NewSourcePoint, int SourceIndex);

		// Token: 0x0600D9EB RID: 55787
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBeamEndPoint_Internal(IntPtr @this, int EmitterIndex, FVector NewEndPoint);

		// Token: 0x0600D9EC RID: 55788
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAutoAttachParams_Internal(IntPtr @this, IntPtr Parent, FName SocketName, TEnumAsByte<EAttachLocation> LocationType);

		// Token: 0x0600D9ED RID: 55789
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumActiveParticles_Internal(IntPtr @this);

		// Token: 0x0600D9EE RID: 55790
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNamedMaterial_Internal(IntPtr @this, FName InName);

		// Token: 0x0600D9EF RID: 55791
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetBeamTargetTangent_Internal(IntPtr @this, int EmitterIndex, int TargetIndex, ref FVector OutTangentPoint);

		// Token: 0x0600D9F0 RID: 55792
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetBeamTargetStrength_Internal(IntPtr @this, int EmitterIndex, int TargetIndex, ref float OutTargetStrength);

		// Token: 0x0600D9F1 RID: 55793
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetBeamTargetPoint_Internal(IntPtr @this, int EmitterIndex, int TargetIndex, ref FVector OutTargetPoint);

		// Token: 0x0600D9F2 RID: 55794
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetBeamSourceTangent_Internal(IntPtr @this, int EmitterIndex, int SourceIndex, ref FVector OutTangentPoint);

		// Token: 0x0600D9F3 RID: 55795
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetBeamSourceStrength_Internal(IntPtr @this, int EmitterIndex, int SourceIndex, ref float OutSourceStrength);

		// Token: 0x0600D9F4 RID: 55796
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetBeamSourcePoint_Internal(IntPtr @this, int EmitterIndex, int SourceIndex, ref FVector OutSourcePoint);

		// Token: 0x0600D9F5 RID: 55797
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetBeamEndPoint_Internal(IntPtr @this, int EmitterIndex, ref FVector OutEndPoint);

		// Token: 0x0600D9F6 RID: 55798
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GenerateParticleEvent_Internal(IntPtr @this, FName InEventName, float InEmitterTime, FVector InLocation, FVector InDirection, FVector InVelocity);

		// Token: 0x0600D9F7 RID: 55799
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EndTrails_Internal(IntPtr @this);

		// Token: 0x0600D9F8 RID: 55800
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateNamedDynamicMaterialInstance_Internal(IntPtr @this, FName InName, IntPtr SourceMaterial);

		// Token: 0x0600D9F9 RID: 55801
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BeginTrails_Internal(IntPtr @this, FName InFirstSocketName, FName InSecondSocketName, TEnumAsByte<ETrailWidthMode> InWidthMode, float InWidth);

		// Token: 0x0600D9FA RID: 55802 RVA: 0x00141C6A File Offset: 0x0013FE6A
		static UParticleSystemComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleSystemComponent");
		}

		// Token: 0x0600D9FB RID: 55803 RVA: 0x00141C78 File Offset: 0x0013FE78
		protected UParticleSystemComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040075FB RID: 30203
		public new const string __ObjectPath = "/Script/Engine.ParticleSystemComponent";

		// Token: 0x040075FC RID: 30204
		private static IntPtr _ClassPtr;

		// Token: 0x040075FD RID: 30205
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040075FE RID: 30206
		internal static int __PropertyOffset_Template;

		// Token: 0x040075FF RID: 30207
		internal static int __PropertyOffset_EmitterMaterials;

		// Token: 0x04007600 RID: 30208
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _EmitterMaterials;

		// Token: 0x04007601 RID: 30209
		internal static int __PropertyOffset_SkelMeshComponents;

		// Token: 0x04007602 RID: 30210
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USkeletalMeshComponent> _SkelMeshComponents;

		// Token: 0x04007603 RID: 30211
		internal static int __PropertyOffset_bResetOnDetach;

		// Token: 0x04007604 RID: 30212
		internal static byte __PropertyMask_bResetOnDetach;

		// Token: 0x04007605 RID: 30213
		internal static int __PropertyOffset_bUpdateOnDedicatedServer;

		// Token: 0x04007606 RID: 30214
		internal static byte __PropertyMask_bUpdateOnDedicatedServer;

		// Token: 0x04007607 RID: 30215
		internal static int __PropertyOffset_bAllowRecycling;

		// Token: 0x04007608 RID: 30216
		internal static byte __PropertyMask_bAllowRecycling;

		// Token: 0x04007609 RID: 30217
		internal static int __PropertyOffset_bAutoManageAttachment;

		// Token: 0x0400760A RID: 30218
		internal static byte __PropertyMask_bAutoManageAttachment;

		// Token: 0x0400760B RID: 30219
		internal static int __PropertyOffset_bAutoAttachWeldSimulatedBodies;

		// Token: 0x0400760C RID: 30220
		internal static byte __PropertyMask_bAutoAttachWeldSimulatedBodies;

		// Token: 0x0400760D RID: 30221
		internal static int __PropertyOffset_bWarmingUp;

		// Token: 0x0400760E RID: 30222
		internal static byte __PropertyMask_bWarmingUp;

		// Token: 0x0400760F RID: 30223
		internal static int __PropertyOffset_bOverrideLODMethod;

		// Token: 0x04007610 RID: 30224
		internal static byte __PropertyMask_bOverrideLODMethod;

		// Token: 0x04007611 RID: 30225
		internal static int __PropertyOffset_bSkipUpdateDynamicDataDuringTick;

		// Token: 0x04007612 RID: 30226
		internal static byte __PropertyMask_bSkipUpdateDynamicDataDuringTick;

		// Token: 0x04007613 RID: 30227
		internal static int __PropertyOffset_LODMethod;

		// Token: 0x04007614 RID: 30228
		internal static int __PropertyOffset_RequiredSignificance;

		// Token: 0x04007615 RID: 30229
		internal static int __PropertyOffset_InstanceParameters;

		// Token: 0x04007616 RID: 30230
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FParticleSysParam> _InstanceParameters;

		// Token: 0x04007617 RID: 30231
		internal static int __PropertyOffset_OnParticleSpawn;

		// Token: 0x04007618 RID: 30232
		[Nullable(2)]
		private FParticleSpawnSignature _OnParticleSpawn;

		// Token: 0x04007619 RID: 30233
		internal static int __PropertyOffset_OnParticleBurst;

		// Token: 0x0400761A RID: 30234
		[Nullable(2)]
		private FParticleBurstSignature _OnParticleBurst;

		// Token: 0x0400761B RID: 30235
		internal static int __PropertyOffset_OnParticleDeath;

		// Token: 0x0400761C RID: 30236
		[Nullable(2)]
		private FParticleDeathSignature _OnParticleDeath;

		// Token: 0x0400761D RID: 30237
		internal static int __PropertyOffset_OnParticleCollide;

		// Token: 0x0400761E RID: 30238
		[Nullable(2)]
		private FParticleCollisionSignature _OnParticleCollide;

		// Token: 0x0400761F RID: 30239
		internal static int __PropertyOffset_bOldPositionValid;

		// Token: 0x04007620 RID: 30240
		internal static int __PropertyOffset_OldPosition;

		// Token: 0x04007621 RID: 30241
		internal static int __PropertyOffset_PartSysVelocity;

		// Token: 0x04007622 RID: 30242
		internal static int __PropertyOffset_WarmupTime;

		// Token: 0x04007623 RID: 30243
		internal static int __PropertyOffset_WarmupTickRate;

		// Token: 0x04007624 RID: 30244
		internal static int __PropertyOffset_SecondsBeforeInactive;

		// Token: 0x04007625 RID: 30245
		internal static int __PropertyOffset_MaxTimeBeforeForceUpdateTransform;

		// Token: 0x04007626 RID: 30246
		internal static int __PropertyOffset_ReplayClips;

		// Token: 0x04007627 RID: 30247
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UParticleSystemReplay> _ReplayClips;

		// Token: 0x04007628 RID: 30248
		internal static int __PropertyOffset_CustomTimeDilation;

		// Token: 0x04007629 RID: 30249
		internal static int __PropertyOffset_AutoAttachParent;

		// Token: 0x0400762A RID: 30250
		internal static int __PropertyOffset_AutoAttachSocketName;

		// Token: 0x0400762B RID: 30251
		internal static int __PropertyOffset_AutoAttachLocationRule;

		// Token: 0x0400762C RID: 30252
		internal static int __PropertyOffset_AutoAttachRotationRule;

		// Token: 0x0400762D RID: 30253
		internal static int __PropertyOffset_AutoAttachScaleRule;

		// Token: 0x0400762E RID: 30254
		internal static int __PropertyOffset_OnSystemFinished;

		// Token: 0x0400762F RID: 30255
		[Nullable(2)]
		private FOnSystemFinished _OnSystemFinished;
	}
}
