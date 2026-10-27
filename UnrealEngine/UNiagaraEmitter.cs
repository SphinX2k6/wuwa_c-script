using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200259A RID: 9626
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraEmitter")]
	[UnrealStructLayout(1304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1304)]
	public class UNiagaraEmitter : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023BC6 RID: 146374 RVA: 0x0034D691 File Offset: 0x0034B891
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraEmitter._ClassPtr;
		}

		// Token: 0x06023BC7 RID: 146375 RVA: 0x0034D6A0 File Offset: 0x0034B8A0
		public UNiagaraEmitter() : this(BuiltinUtils.AllocNativeUObject(UNiagaraEmitter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023BC8 RID: 146376 RVA: 0x0034D6C8 File Offset: 0x0034B8C8
		public UNiagaraEmitter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraEmitter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008946 RID: 35142
		// (get) Token: 0x06023BC9 RID: 146377 RVA: 0x0034D6FB File Offset: 0x0034B8FB
		// (set) Token: 0x06023BCA RID: 146378 RVA: 0x0034D70B File Offset: 0x0034B90B
		public unsafe bool bVisibleInRaytracing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_bVisibleInRaytracing) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_bVisibleInRaytracing) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008947 RID: 35143
		// (get) Token: 0x06023BCB RID: 146379 RVA: 0x0034D71C File Offset: 0x0034B91C
		// (set) Token: 0x06023BCC RID: 146380 RVA: 0x0034D72C File Offset: 0x0034B92C
		public unsafe bool bLocalSpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_bLocalSpace) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_bLocalSpace) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008948 RID: 35144
		// (get) Token: 0x06023BCD RID: 146381 RVA: 0x0034D73D File Offset: 0x0034B93D
		// (set) Token: 0x06023BCE RID: 146382 RVA: 0x0034D74D File Offset: 0x0034B94D
		public unsafe bool bDeterminism
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_bDeterminism) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_bDeterminism) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008949 RID: 35145
		// (get) Token: 0x06023BCF RID: 146383 RVA: 0x0034D75E File Offset: 0x0034B95E
		// (set) Token: 0x06023BD0 RID: 146384 RVA: 0x0034D76E File Offset: 0x0034B96E
		public unsafe int RandomSeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_RandomSeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_RandomSeed) = value;
			}
		}

		// Token: 0x1700894A RID: 35146
		// (get) Token: 0x06023BD1 RID: 146385 RVA: 0x0034D77F File Offset: 0x0034B97F
		// (set) Token: 0x06023BD2 RID: 146386 RVA: 0x0034D78F File Offset: 0x0034B98F
		public unsafe EParticleAllocationMode AllocationMode
		{
			get
			{
				return (EParticleAllocationMode)(*(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_AllocationMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_AllocationMode) = (byte)value;
			}
		}

		// Token: 0x1700894B RID: 35147
		// (get) Token: 0x06023BD3 RID: 146387 RVA: 0x0034D7A0 File Offset: 0x0034B9A0
		// (set) Token: 0x06023BD4 RID: 146388 RVA: 0x0034D7B0 File Offset: 0x0034B9B0
		public unsafe int PreAllocationCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_PreAllocationCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_PreAllocationCount) = value;
			}
		}

		// Token: 0x1700894C RID: 35148
		// (get) Token: 0x06023BD5 RID: 146389 RVA: 0x0034D7C4 File Offset: 0x0034B9C4
		// (set) Token: 0x06023BD6 RID: 146390 RVA: 0x0034D7FD File Offset: 0x0034B9FD
		public FNiagaraEmitterScriptProperties UpdateScriptProps
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraEmitterScriptProperties result;
				if ((result = this._UpdateScriptProps) == null)
				{
					result = (this._UpdateScriptProps = new FNiagaraEmitterScriptProperties(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_UpdateScriptProps, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraEmitterScriptProperties.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_UpdateScriptProps, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700894D RID: 35149
		// (get) Token: 0x06023BD7 RID: 146391 RVA: 0x0034D820 File Offset: 0x0034BA20
		// (set) Token: 0x06023BD8 RID: 146392 RVA: 0x0034D859 File Offset: 0x0034BA59
		public FNiagaraEmitterScriptProperties SpawnScriptProps
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraEmitterScriptProperties result;
				if ((result = this._SpawnScriptProps) == null)
				{
					result = (this._SpawnScriptProps = new FNiagaraEmitterScriptProperties(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_SpawnScriptProps, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraEmitterScriptProperties.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_SpawnScriptProps, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700894E RID: 35150
		// (get) Token: 0x06023BD9 RID: 146393 RVA: 0x0034D87A File Offset: 0x0034BA7A
		// (set) Token: 0x06023BDA RID: 146394 RVA: 0x0034D88A File Offset: 0x0034BA8A
		public unsafe ENiagaraSimTarget SimTarget
		{
			get
			{
				return (ENiagaraSimTarget)(*(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_SimTarget));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_SimTarget) = (byte)value;
			}
		}

		// Token: 0x1700894F RID: 35151
		// (get) Token: 0x06023BDB RID: 146395 RVA: 0x0034D89B File Offset: 0x0034BA9B
		// (set) Token: 0x06023BDC RID: 146396 RVA: 0x0034D8AB File Offset: 0x0034BAAB
		public unsafe bool KuroNoGPUOnly
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_KuroNoGPUOnly) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_KuroNoGPUOnly) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008950 RID: 35152
		// (get) Token: 0x06023BDD RID: 146397 RVA: 0x0034D8BC File Offset: 0x0034BABC
		// (set) Token: 0x06023BDE RID: 146398 RVA: 0x0034D8D5 File Offset: 0x0034BAD5
		public unsafe bool bOverrideKuroImportance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_bOverrideKuroImportance) & UNiagaraEmitter.__PropertyMask_bOverrideKuroImportance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_bOverrideKuroImportance) = ((*(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_bOverrideKuroImportance) & ~UNiagaraEmitter.__PropertyMask_bOverrideKuroImportance) | (value ? UNiagaraEmitter.__PropertyMask_bOverrideKuroImportance : 0));
			}
		}

		// Token: 0x17008951 RID: 35153
		// (get) Token: 0x06023BDF RID: 146399 RVA: 0x0034D905 File Offset: 0x0034BB05
		// (set) Token: 0x06023BE0 RID: 146400 RVA: 0x0034D915 File Offset: 0x0034BB15
		public unsafe ENiagaraKuroImportance KuroImportance
		{
			get
			{
				return (ENiagaraKuroImportance)(*(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_KuroImportance));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_KuroImportance) = (byte)value;
			}
		}

		// Token: 0x17008952 RID: 35154
		// (get) Token: 0x06023BE1 RID: 146401 RVA: 0x0034D926 File Offset: 0x0034BB26
		// (set) Token: 0x06023BE2 RID: 146402 RVA: 0x0034D93A File Offset: 0x0034BB3A
		public unsafe FBox FixedBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_FixedBounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_FixedBounds) = value;
			}
		}

		// Token: 0x17008953 RID: 35155
		// (get) Token: 0x06023BE3 RID: 146403 RVA: 0x0034D94F File Offset: 0x0034BB4F
		// (set) Token: 0x06023BE4 RID: 146404 RVA: 0x0034D95F File Offset: 0x0034BB5F
		public unsafe int MinDetailLevel_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_MinDetailLevel_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_MinDetailLevel_DEPRECATED) = value;
			}
		}

		// Token: 0x17008954 RID: 35156
		// (get) Token: 0x06023BE5 RID: 146405 RVA: 0x0034D970 File Offset: 0x0034BB70
		// (set) Token: 0x06023BE6 RID: 146406 RVA: 0x0034D980 File Offset: 0x0034BB80
		public unsafe int MaxDetailLevel_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_MaxDetailLevel_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_MaxDetailLevel_DEPRECATED) = value;
			}
		}

		// Token: 0x17008955 RID: 35157
		// (get) Token: 0x06023BE7 RID: 146407 RVA: 0x0034D994 File Offset: 0x0034BB94
		// (set) Token: 0x06023BE8 RID: 146408 RVA: 0x0034D9CD File Offset: 0x0034BBCD
		public FNiagaraDetailsLevelScaleOverrides GlobalSpawnCountScaleOverrides_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraDetailsLevelScaleOverrides result;
				if ((result = this._GlobalSpawnCountScaleOverrides_DEPRECATED) == null)
				{
					result = (this._GlobalSpawnCountScaleOverrides_DEPRECATED = new FNiagaraDetailsLevelScaleOverrides(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_GlobalSpawnCountScaleOverrides_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraDetailsLevelScaleOverrides.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_GlobalSpawnCountScaleOverrides_DEPRECATED, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008956 RID: 35158
		// (get) Token: 0x06023BE9 RID: 146409 RVA: 0x0034D9F0 File Offset: 0x0034BBF0
		// (set) Token: 0x06023BEA RID: 146410 RVA: 0x0034DA29 File Offset: 0x0034BC29
		public FNiagaraPlatformSet Platforms
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraPlatformSet result;
				if ((result = this._Platforms) == null)
				{
					result = (this._Platforms = new FNiagaraPlatformSet(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_Platforms, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraPlatformSet.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_Platforms, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008957 RID: 35159
		// (get) Token: 0x06023BEB RID: 146411 RVA: 0x0034DA4C File Offset: 0x0034BC4C
		// (set) Token: 0x06023BEC RID: 146412 RVA: 0x0034DA85 File Offset: 0x0034BC85
		public FNiagaraEmitterScalabilityOverrides ScalabilityOverrides
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraEmitterScalabilityOverrides result;
				if ((result = this._ScalabilityOverrides) == null)
				{
					result = (this._ScalabilityOverrides = new FNiagaraEmitterScalabilityOverrides(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_ScalabilityOverrides, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraEmitterScalabilityOverrides.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_ScalabilityOverrides, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008958 RID: 35160
		// (get) Token: 0x06023BED RID: 146413 RVA: 0x0034DAA6 File Offset: 0x0034BCA6
		// (set) Token: 0x06023BEE RID: 146414 RVA: 0x0034DABF File Offset: 0x0034BCBF
		public unsafe bool bUnloadAfterSystemLoad
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_bUnloadAfterSystemLoad) & UNiagaraEmitter.__PropertyMask_bUnloadAfterSystemLoad) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_bUnloadAfterSystemLoad) = ((*(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_bUnloadAfterSystemLoad) & ~UNiagaraEmitter.__PropertyMask_bUnloadAfterSystemLoad) | (value ? UNiagaraEmitter.__PropertyMask_bUnloadAfterSystemLoad : 0));
			}
		}

		// Token: 0x17008959 RID: 35161
		// (get) Token: 0x06023BEF RID: 146415 RVA: 0x0034DAEF File Offset: 0x0034BCEF
		// (set) Token: 0x06023BF0 RID: 146416 RVA: 0x0034DB08 File Offset: 0x0034BD08
		public unsafe bool bInterpolatedSpawning
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_bInterpolatedSpawning) & UNiagaraEmitter.__PropertyMask_bInterpolatedSpawning) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_bInterpolatedSpawning) = ((*(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_bInterpolatedSpawning) & ~UNiagaraEmitter.__PropertyMask_bInterpolatedSpawning) | (value ? UNiagaraEmitter.__PropertyMask_bInterpolatedSpawning : 0));
			}
		}

		// Token: 0x1700895A RID: 35162
		// (get) Token: 0x06023BF1 RID: 146417 RVA: 0x0034DB38 File Offset: 0x0034BD38
		// (set) Token: 0x06023BF2 RID: 146418 RVA: 0x0034DB51 File Offset: 0x0034BD51
		public unsafe bool bFixedBounds
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_bFixedBounds) & UNiagaraEmitter.__PropertyMask_bFixedBounds) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_bFixedBounds) = ((*(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_bFixedBounds) & ~UNiagaraEmitter.__PropertyMask_bFixedBounds) | (value ? UNiagaraEmitter.__PropertyMask_bFixedBounds : 0));
			}
		}

		// Token: 0x1700895B RID: 35163
		// (get) Token: 0x06023BF3 RID: 146419 RVA: 0x0034DB81 File Offset: 0x0034BD81
		// (set) Token: 0x06023BF4 RID: 146420 RVA: 0x0034DB9A File Offset: 0x0034BD9A
		public unsafe bool bUseMinDetailLevel_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_bUseMinDetailLevel_DEPRECATED) & UNiagaraEmitter.__PropertyMask_bUseMinDetailLevel_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_bUseMinDetailLevel_DEPRECATED) = ((*(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_bUseMinDetailLevel_DEPRECATED) & ~UNiagaraEmitter.__PropertyMask_bUseMinDetailLevel_DEPRECATED) | (value ? UNiagaraEmitter.__PropertyMask_bUseMinDetailLevel_DEPRECATED : 0));
			}
		}

		// Token: 0x1700895C RID: 35164
		// (get) Token: 0x06023BF5 RID: 146421 RVA: 0x0034DBCA File Offset: 0x0034BDCA
		// (set) Token: 0x06023BF6 RID: 146422 RVA: 0x0034DBE3 File Offset: 0x0034BDE3
		public unsafe bool bUseMaxDetailLevel_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_bUseMaxDetailLevel_DEPRECATED) & UNiagaraEmitter.__PropertyMask_bUseMaxDetailLevel_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_bUseMaxDetailLevel_DEPRECATED) = ((*(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_bUseMaxDetailLevel_DEPRECATED) & ~UNiagaraEmitter.__PropertyMask_bUseMaxDetailLevel_DEPRECATED) | (value ? UNiagaraEmitter.__PropertyMask_bUseMaxDetailLevel_DEPRECATED : 0));
			}
		}

		// Token: 0x1700895D RID: 35165
		// (get) Token: 0x06023BF7 RID: 146423 RVA: 0x0034DC13 File Offset: 0x0034BE13
		// (set) Token: 0x06023BF8 RID: 146424 RVA: 0x0034DC2C File Offset: 0x0034BE2C
		public unsafe bool bOverrideGlobalSpawnCountScale_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_bOverrideGlobalSpawnCountScale_DEPRECATED) & UNiagaraEmitter.__PropertyMask_bOverrideGlobalSpawnCountScale_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_bOverrideGlobalSpawnCountScale_DEPRECATED) = ((*(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_bOverrideGlobalSpawnCountScale_DEPRECATED) & ~UNiagaraEmitter.__PropertyMask_bOverrideGlobalSpawnCountScale_DEPRECATED) | (value ? UNiagaraEmitter.__PropertyMask_bOverrideGlobalSpawnCountScale_DEPRECATED : 0));
			}
		}

		// Token: 0x1700895E RID: 35166
		// (get) Token: 0x06023BF9 RID: 146425 RVA: 0x0034DC5C File Offset: 0x0034BE5C
		// (set) Token: 0x06023BFA RID: 146426 RVA: 0x0034DC75 File Offset: 0x0034BE75
		public unsafe bool bRequiresPersistentIDs
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_bRequiresPersistentIDs) & UNiagaraEmitter.__PropertyMask_bRequiresPersistentIDs) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_bRequiresPersistentIDs) = ((*(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_bRequiresPersistentIDs) & ~UNiagaraEmitter.__PropertyMask_bRequiresPersistentIDs) | (value ? UNiagaraEmitter.__PropertyMask_bRequiresPersistentIDs : 0));
			}
		}

		// Token: 0x1700895F RID: 35167
		// (get) Token: 0x06023BFB RID: 146427 RVA: 0x0034DCA5 File Offset: 0x0034BEA5
		// (set) Token: 0x06023BFC RID: 146428 RVA: 0x0034DCBE File Offset: 0x0034BEBE
		public unsafe bool bCombineEventSpawn
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_bCombineEventSpawn) & UNiagaraEmitter.__PropertyMask_bCombineEventSpawn) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_bCombineEventSpawn) = ((*(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_bCombineEventSpawn) & ~UNiagaraEmitter.__PropertyMask_bCombineEventSpawn) | (value ? UNiagaraEmitter.__PropertyMask_bCombineEventSpawn : 0));
			}
		}

		// Token: 0x17008960 RID: 35168
		// (get) Token: 0x06023BFD RID: 146429 RVA: 0x0034DCEE File Offset: 0x0034BEEE
		// (set) Token: 0x06023BFE RID: 146430 RVA: 0x0034DCFE File Offset: 0x0034BEFE
		public unsafe int EmitterPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_EmitterPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_EmitterPriority) = value;
			}
		}

		// Token: 0x17008961 RID: 35169
		// (get) Token: 0x06023BFF RID: 146431 RVA: 0x0034DD0F File Offset: 0x0034BF0F
		// (set) Token: 0x06023C00 RID: 146432 RVA: 0x0034DD1F File Offset: 0x0034BF1F
		public unsafe float MaxDeltaTimePerTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_MaxDeltaTimePerTick);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_MaxDeltaTimePerTick) = value;
			}
		}

		// Token: 0x17008962 RID: 35170
		// (get) Token: 0x06023C01 RID: 146433 RVA: 0x0034DD30 File Offset: 0x0034BF30
		// (set) Token: 0x06023C02 RID: 146434 RVA: 0x0034DD40 File Offset: 0x0034BF40
		public unsafe uint DefaultShaderStageIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_DefaultShaderStageIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_DefaultShaderStageIndex) = (int)value;
			}
		}

		// Token: 0x17008963 RID: 35171
		// (get) Token: 0x06023C03 RID: 146435 RVA: 0x0034DD51 File Offset: 0x0034BF51
		// (set) Token: 0x06023C04 RID: 146436 RVA: 0x0034DD61 File Offset: 0x0034BF61
		public unsafe uint MaxUpdateIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_MaxUpdateIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_MaxUpdateIterations) = (int)value;
			}
		}

		// Token: 0x17008964 RID: 35172
		// (get) Token: 0x06023C05 RID: 146437 RVA: 0x0034DD74 File Offset: 0x0034BF74
		// (set) Token: 0x06023C06 RID: 146438 RVA: 0x0034DDAD File Offset: 0x0034BFAD
		public TSet<uint> SpawnStages
		{
			get
			{
				base.FastCheckIsValid();
				TSet<uint> result;
				if ((result = this._SpawnStages) == null)
				{
					result = (this._SpawnStages = new TSet<uint>(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_SpawnStages, this));
				}
				return result;
			}
			set
			{
				this.SpawnStages.CopyAssign(value);
			}
		}

		// Token: 0x17008965 RID: 35173
		// (get) Token: 0x06023C07 RID: 146439 RVA: 0x0034DDBB File Offset: 0x0034BFBB
		// (set) Token: 0x06023C08 RID: 146440 RVA: 0x0034DDD4 File Offset: 0x0034BFD4
		public unsafe bool bSimulationStagesEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_bSimulationStagesEnabled) & UNiagaraEmitter.__PropertyMask_bSimulationStagesEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_bSimulationStagesEnabled) = ((*(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_bSimulationStagesEnabled) & ~UNiagaraEmitter.__PropertyMask_bSimulationStagesEnabled) | (value ? UNiagaraEmitter.__PropertyMask_bSimulationStagesEnabled : 0));
			}
		}

		// Token: 0x17008966 RID: 35174
		// (get) Token: 0x06023C09 RID: 146441 RVA: 0x0034DE04 File Offset: 0x0034C004
		// (set) Token: 0x06023C0A RID: 146442 RVA: 0x0034DE1D File Offset: 0x0034C01D
		public unsafe bool bDeprecatedShaderStagesEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_bDeprecatedShaderStagesEnabled) & UNiagaraEmitter.__PropertyMask_bDeprecatedShaderStagesEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_bDeprecatedShaderStagesEnabled) = ((*(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_bDeprecatedShaderStagesEnabled) & ~UNiagaraEmitter.__PropertyMask_bDeprecatedShaderStagesEnabled) | (value ? UNiagaraEmitter.__PropertyMask_bDeprecatedShaderStagesEnabled : 0));
			}
		}

		// Token: 0x17008967 RID: 35175
		// (get) Token: 0x06023C0B RID: 146443 RVA: 0x0034DE4D File Offset: 0x0034C04D
		// (set) Token: 0x06023C0C RID: 146444 RVA: 0x0034DE66 File Offset: 0x0034C066
		public unsafe bool bLimitDeltaTime
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_bLimitDeltaTime) & UNiagaraEmitter.__PropertyMask_bLimitDeltaTime) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_bLimitDeltaTime) = ((*(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_bLimitDeltaTime) & ~UNiagaraEmitter.__PropertyMask_bLimitDeltaTime) | (value ? UNiagaraEmitter.__PropertyMask_bLimitDeltaTime : 0));
			}
		}

		// Token: 0x17008968 RID: 35176
		// (get) Token: 0x06023C0D RID: 146445 RVA: 0x0034DE96 File Offset: 0x0034C096
		// (set) Token: 0x06023C0E RID: 146446 RVA: 0x0034DEAA File Offset: 0x0034C0AA
		public unsafe string UniqueEmitterName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UNiagaraEmitter.__PropertyOffset_UniqueEmitterName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UNiagaraEmitter.__PropertyOffset_UniqueEmitterName)), value);
			}
		}

		// Token: 0x17008969 RID: 35177
		// (get) Token: 0x06023C0F RID: 146447 RVA: 0x0034DEC0 File Offset: 0x0034C0C0
		// (set) Token: 0x06023C10 RID: 146448 RVA: 0x0034DEF9 File Offset: 0x0034C0F9
		public TArray<UNiagaraRendererProperties> RendererProperties
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UNiagaraRendererProperties> result;
				if ((result = this._RendererProperties) == null)
				{
					result = (this._RendererProperties = new TArray<UNiagaraRendererProperties>(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_RendererProperties, this));
				}
				return result;
			}
			set
			{
				this.RendererProperties.CopyAssign(value);
			}
		}

		// Token: 0x1700896A RID: 35178
		// (get) Token: 0x06023C11 RID: 146449 RVA: 0x0034DF08 File Offset: 0x0034C108
		// (set) Token: 0x06023C12 RID: 146450 RVA: 0x0034DF41 File Offset: 0x0034C141
		public TArray<FNiagaraEventScriptProperties> EventHandlerScriptProps
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraEventScriptProperties> result;
				if ((result = this._EventHandlerScriptProps) == null)
				{
					result = (this._EventHandlerScriptProps = new TArray<FNiagaraEventScriptProperties>(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_EventHandlerScriptProps, this));
				}
				return result;
			}
			set
			{
				this.EventHandlerScriptProps.CopyAssign(value);
			}
		}

		// Token: 0x1700896B RID: 35179
		// (get) Token: 0x06023C13 RID: 146451 RVA: 0x0034DF50 File Offset: 0x0034C150
		// (set) Token: 0x06023C14 RID: 146452 RVA: 0x0034DF89 File Offset: 0x0034C189
		public TArray<UNiagaraSimulationStageBase> SimulationStages
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UNiagaraSimulationStageBase> result;
				if ((result = this._SimulationStages) == null)
				{
					result = (this._SimulationStages = new TArray<UNiagaraSimulationStageBase>(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_SimulationStages, this));
				}
				return result;
			}
			set
			{
				this.SimulationStages.CopyAssign(value);
			}
		}

		// Token: 0x1700896C RID: 35180
		// (get) Token: 0x06023C15 RID: 146453 RVA: 0x0034DF97 File Offset: 0x0034C197
		// (set) Token: 0x06023C16 RID: 146454 RVA: 0x0034DFAB File Offset: 0x0034C1AB
		[Nullable(2)]
		public unsafe UNiagaraScript GPUComputeScript
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraScript>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraEmitter.__PropertyOffset_GPUComputeScript);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraEmitter.__PropertyOffset_GPUComputeScript, value);
			}
		}

		// Token: 0x1700896D RID: 35181
		// (get) Token: 0x06023C17 RID: 146455 RVA: 0x0034DFC0 File Offset: 0x0034C1C0
		// (set) Token: 0x06023C18 RID: 146456 RVA: 0x0034DFF9 File Offset: 0x0034C1F9
		public TArray<FName> SharedEventGeneratorIds
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._SharedEventGeneratorIds) == null)
				{
					result = (this._SharedEventGeneratorIds = new TArray<FName>(base.NativePtr + (IntPtr)UNiagaraEmitter.__PropertyOffset_SharedEventGeneratorIds, this));
				}
				return result;
			}
			set
			{
				this.SharedEventGeneratorIds.CopyAssign(value);
			}
		}

		// Token: 0x06023C19 RID: 146457 RVA: 0x0034E007 File Offset: 0x0034C207
		static UNiagaraEmitter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraEmitter");
		}

		// Token: 0x06023C1A RID: 146458 RVA: 0x0034E015 File Offset: 0x0034C215
		protected UNiagaraEmitter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401329A RID: 78490
		public new const string __ObjectPath = "/Script/Niagara.NiagaraEmitter";

		// Token: 0x0401329B RID: 78491
		private static IntPtr _ClassPtr;

		// Token: 0x0401329C RID: 78492
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401329D RID: 78493
		internal static int __PropertyOffset_bVisibleInRaytracing;

		// Token: 0x0401329E RID: 78494
		internal static int __PropertyOffset_bLocalSpace;

		// Token: 0x0401329F RID: 78495
		internal static int __PropertyOffset_bDeterminism;

		// Token: 0x040132A0 RID: 78496
		internal static int __PropertyOffset_RandomSeed;

		// Token: 0x040132A1 RID: 78497
		internal static int __PropertyOffset_AllocationMode;

		// Token: 0x040132A2 RID: 78498
		internal static int __PropertyOffset_PreAllocationCount;

		// Token: 0x040132A3 RID: 78499
		internal static int __PropertyOffset_UpdateScriptProps;

		// Token: 0x040132A4 RID: 78500
		[Nullable(2)]
		private FNiagaraEmitterScriptProperties _UpdateScriptProps;

		// Token: 0x040132A5 RID: 78501
		internal static int __PropertyOffset_SpawnScriptProps;

		// Token: 0x040132A6 RID: 78502
		[Nullable(2)]
		private FNiagaraEmitterScriptProperties _SpawnScriptProps;

		// Token: 0x040132A7 RID: 78503
		internal static int __PropertyOffset_SimTarget;

		// Token: 0x040132A8 RID: 78504
		internal static int __PropertyOffset_KuroNoGPUOnly;

		// Token: 0x040132A9 RID: 78505
		internal static int __PropertyOffset_bOverrideKuroImportance;

		// Token: 0x040132AA RID: 78506
		internal static byte __PropertyMask_bOverrideKuroImportance;

		// Token: 0x040132AB RID: 78507
		internal static int __PropertyOffset_KuroImportance;

		// Token: 0x040132AC RID: 78508
		internal static int __PropertyOffset_FixedBounds;

		// Token: 0x040132AD RID: 78509
		internal static int __PropertyOffset_MinDetailLevel_DEPRECATED;

		// Token: 0x040132AE RID: 78510
		internal static int __PropertyOffset_MaxDetailLevel_DEPRECATED;

		// Token: 0x040132AF RID: 78511
		internal static int __PropertyOffset_GlobalSpawnCountScaleOverrides_DEPRECATED;

		// Token: 0x040132B0 RID: 78512
		[Nullable(2)]
		private FNiagaraDetailsLevelScaleOverrides _GlobalSpawnCountScaleOverrides_DEPRECATED;

		// Token: 0x040132B1 RID: 78513
		internal static int __PropertyOffset_Platforms;

		// Token: 0x040132B2 RID: 78514
		[Nullable(2)]
		private FNiagaraPlatformSet _Platforms;

		// Token: 0x040132B3 RID: 78515
		internal static int __PropertyOffset_ScalabilityOverrides;

		// Token: 0x040132B4 RID: 78516
		[Nullable(2)]
		private FNiagaraEmitterScalabilityOverrides _ScalabilityOverrides;

		// Token: 0x040132B5 RID: 78517
		internal static int __PropertyOffset_bUnloadAfterSystemLoad;

		// Token: 0x040132B6 RID: 78518
		internal static byte __PropertyMask_bUnloadAfterSystemLoad;

		// Token: 0x040132B7 RID: 78519
		internal static int __PropertyOffset_bInterpolatedSpawning;

		// Token: 0x040132B8 RID: 78520
		internal static byte __PropertyMask_bInterpolatedSpawning;

		// Token: 0x040132B9 RID: 78521
		internal static int __PropertyOffset_bFixedBounds;

		// Token: 0x040132BA RID: 78522
		internal static byte __PropertyMask_bFixedBounds;

		// Token: 0x040132BB RID: 78523
		internal static int __PropertyOffset_bUseMinDetailLevel_DEPRECATED;

		// Token: 0x040132BC RID: 78524
		internal static byte __PropertyMask_bUseMinDetailLevel_DEPRECATED;

		// Token: 0x040132BD RID: 78525
		internal static int __PropertyOffset_bUseMaxDetailLevel_DEPRECATED;

		// Token: 0x040132BE RID: 78526
		internal static byte __PropertyMask_bUseMaxDetailLevel_DEPRECATED;

		// Token: 0x040132BF RID: 78527
		internal static int __PropertyOffset_bOverrideGlobalSpawnCountScale_DEPRECATED;

		// Token: 0x040132C0 RID: 78528
		internal static byte __PropertyMask_bOverrideGlobalSpawnCountScale_DEPRECATED;

		// Token: 0x040132C1 RID: 78529
		internal static int __PropertyOffset_bRequiresPersistentIDs;

		// Token: 0x040132C2 RID: 78530
		internal static byte __PropertyMask_bRequiresPersistentIDs;

		// Token: 0x040132C3 RID: 78531
		internal static int __PropertyOffset_bCombineEventSpawn;

		// Token: 0x040132C4 RID: 78532
		internal static byte __PropertyMask_bCombineEventSpawn;

		// Token: 0x040132C5 RID: 78533
		internal static int __PropertyOffset_EmitterPriority;

		// Token: 0x040132C6 RID: 78534
		internal static int __PropertyOffset_MaxDeltaTimePerTick;

		// Token: 0x040132C7 RID: 78535
		internal static int __PropertyOffset_DefaultShaderStageIndex;

		// Token: 0x040132C8 RID: 78536
		internal static int __PropertyOffset_MaxUpdateIterations;

		// Token: 0x040132C9 RID: 78537
		internal static int __PropertyOffset_SpawnStages;

		// Token: 0x040132CA RID: 78538
		[Nullable(2)]
		private TSet<uint> _SpawnStages;

		// Token: 0x040132CB RID: 78539
		internal static int __PropertyOffset_bSimulationStagesEnabled;

		// Token: 0x040132CC RID: 78540
		internal static byte __PropertyMask_bSimulationStagesEnabled;

		// Token: 0x040132CD RID: 78541
		internal static int __PropertyOffset_bDeprecatedShaderStagesEnabled;

		// Token: 0x040132CE RID: 78542
		internal static byte __PropertyMask_bDeprecatedShaderStagesEnabled;

		// Token: 0x040132CF RID: 78543
		internal static int __PropertyOffset_bLimitDeltaTime;

		// Token: 0x040132D0 RID: 78544
		internal static byte __PropertyMask_bLimitDeltaTime;

		// Token: 0x040132D1 RID: 78545
		internal static int __PropertyOffset_UniqueEmitterName;

		// Token: 0x040132D2 RID: 78546
		internal static int __PropertyOffset_RendererProperties;

		// Token: 0x040132D3 RID: 78547
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UNiagaraRendererProperties> _RendererProperties;

		// Token: 0x040132D4 RID: 78548
		internal static int __PropertyOffset_EventHandlerScriptProps;

		// Token: 0x040132D5 RID: 78549
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraEventScriptProperties> _EventHandlerScriptProps;

		// Token: 0x040132D6 RID: 78550
		internal static int __PropertyOffset_SimulationStages;

		// Token: 0x040132D7 RID: 78551
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UNiagaraSimulationStageBase> _SimulationStages;

		// Token: 0x040132D8 RID: 78552
		internal static int __PropertyOffset_GPUComputeScript;

		// Token: 0x040132D9 RID: 78553
		internal static int __PropertyOffset_SharedEventGeneratorIds;

		// Token: 0x040132DA RID: 78554
		[Nullable(2)]
		private TArray<FName> _SharedEventGeneratorIds;
	}
}
