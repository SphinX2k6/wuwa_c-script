using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012EE RID: 4846
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AbilitySystemGlobals")]
	[UnrealStructLayout(768, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 768)]
	public class UAbilitySystemGlobals : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011D6F RID: 73071 RVA: 0x001A2B26 File Offset: 0x001A0D26
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilitySystemGlobals._ClassPtr;
		}

		// Token: 0x06011D70 RID: 73072 RVA: 0x001A2B34 File Offset: 0x001A0D34
		public UAbilitySystemGlobals() : this(BuiltinUtils.AllocNativeUObject(UAbilitySystemGlobals.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011D71 RID: 73073 RVA: 0x001A2B5C File Offset: 0x001A0D5C
		public UAbilitySystemGlobals(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilitySystemGlobals.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700459B RID: 17819
		// (get) Token: 0x06011D72 RID: 73074 RVA: 0x001A2B90 File Offset: 0x001A0D90
		// (set) Token: 0x06011D73 RID: 73075 RVA: 0x001A2BC9 File Offset: 0x001A0DC9
		public FSoftClassPath AbilitySystemGlobalsClassName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._AbilitySystemGlobalsClassName) == null)
				{
					result = (this._AbilitySystemGlobalsClassName = new FSoftClassPath(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_AbilitySystemGlobalsClassName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_AbilitySystemGlobalsClassName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700459C RID: 17820
		// (get) Token: 0x06011D74 RID: 73076 RVA: 0x001A2BEA File Offset: 0x001A0DEA
		// (set) Token: 0x06011D75 RID: 73077 RVA: 0x001A2BFE File Offset: 0x001A0DFE
		public unsafe FGameplayTag ActivateFailIsDeadTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_ActivateFailIsDeadTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_ActivateFailIsDeadTag) = value;
			}
		}

		// Token: 0x1700459D RID: 17821
		// (get) Token: 0x06011D76 RID: 73078 RVA: 0x001A2C13 File Offset: 0x001A0E13
		// (set) Token: 0x06011D77 RID: 73079 RVA: 0x001A2C27 File Offset: 0x001A0E27
		public unsafe FName ActivateFailIsDeadName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_ActivateFailIsDeadName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_ActivateFailIsDeadName) = value;
			}
		}

		// Token: 0x1700459E RID: 17822
		// (get) Token: 0x06011D78 RID: 73080 RVA: 0x001A2C3C File Offset: 0x001A0E3C
		// (set) Token: 0x06011D79 RID: 73081 RVA: 0x001A2C50 File Offset: 0x001A0E50
		public unsafe FGameplayTag ActivateFailCooldownTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_ActivateFailCooldownTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_ActivateFailCooldownTag) = value;
			}
		}

		// Token: 0x1700459F RID: 17823
		// (get) Token: 0x06011D7A RID: 73082 RVA: 0x001A2C65 File Offset: 0x001A0E65
		// (set) Token: 0x06011D7B RID: 73083 RVA: 0x001A2C79 File Offset: 0x001A0E79
		public unsafe FName ActivateFailCooldownName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_ActivateFailCooldownName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_ActivateFailCooldownName) = value;
			}
		}

		// Token: 0x170045A0 RID: 17824
		// (get) Token: 0x06011D7C RID: 73084 RVA: 0x001A2C8E File Offset: 0x001A0E8E
		// (set) Token: 0x06011D7D RID: 73085 RVA: 0x001A2CA2 File Offset: 0x001A0EA2
		public unsafe FGameplayTag ActivateFailCostTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_ActivateFailCostTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_ActivateFailCostTag) = value;
			}
		}

		// Token: 0x170045A1 RID: 17825
		// (get) Token: 0x06011D7E RID: 73086 RVA: 0x001A2CB7 File Offset: 0x001A0EB7
		// (set) Token: 0x06011D7F RID: 73087 RVA: 0x001A2CCB File Offset: 0x001A0ECB
		public unsafe FName ActivateFailCostName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_ActivateFailCostName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_ActivateFailCostName) = value;
			}
		}

		// Token: 0x170045A2 RID: 17826
		// (get) Token: 0x06011D80 RID: 73088 RVA: 0x001A2CE0 File Offset: 0x001A0EE0
		// (set) Token: 0x06011D81 RID: 73089 RVA: 0x001A2CF4 File Offset: 0x001A0EF4
		public unsafe FGameplayTag ActivateFailTagsBlockedTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_ActivateFailTagsBlockedTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_ActivateFailTagsBlockedTag) = value;
			}
		}

		// Token: 0x170045A3 RID: 17827
		// (get) Token: 0x06011D82 RID: 73090 RVA: 0x001A2D09 File Offset: 0x001A0F09
		// (set) Token: 0x06011D83 RID: 73091 RVA: 0x001A2D1D File Offset: 0x001A0F1D
		public unsafe FName ActivateFailTagsBlockedName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_ActivateFailTagsBlockedName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_ActivateFailTagsBlockedName) = value;
			}
		}

		// Token: 0x170045A4 RID: 17828
		// (get) Token: 0x06011D84 RID: 73092 RVA: 0x001A2D32 File Offset: 0x001A0F32
		// (set) Token: 0x06011D85 RID: 73093 RVA: 0x001A2D46 File Offset: 0x001A0F46
		public unsafe FGameplayTag ActivateFailTagsMissingTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_ActivateFailTagsMissingTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_ActivateFailTagsMissingTag) = value;
			}
		}

		// Token: 0x170045A5 RID: 17829
		// (get) Token: 0x06011D86 RID: 73094 RVA: 0x001A2D5B File Offset: 0x001A0F5B
		// (set) Token: 0x06011D87 RID: 73095 RVA: 0x001A2D6F File Offset: 0x001A0F6F
		public unsafe FName ActivateFailTagsMissingName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_ActivateFailTagsMissingName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_ActivateFailTagsMissingName) = value;
			}
		}

		// Token: 0x170045A6 RID: 17830
		// (get) Token: 0x06011D88 RID: 73096 RVA: 0x001A2D84 File Offset: 0x001A0F84
		// (set) Token: 0x06011D89 RID: 73097 RVA: 0x001A2D98 File Offset: 0x001A0F98
		public unsafe FGameplayTag ActivateFailNetworkingTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_ActivateFailNetworkingTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_ActivateFailNetworkingTag) = value;
			}
		}

		// Token: 0x170045A7 RID: 17831
		// (get) Token: 0x06011D8A RID: 73098 RVA: 0x001A2DAD File Offset: 0x001A0FAD
		// (set) Token: 0x06011D8B RID: 73099 RVA: 0x001A2DC1 File Offset: 0x001A0FC1
		public unsafe FName ActivateFailNetworkingName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_ActivateFailNetworkingName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_ActivateFailNetworkingName) = value;
			}
		}

		// Token: 0x170045A8 RID: 17832
		// (get) Token: 0x06011D8C RID: 73100 RVA: 0x001A2DD6 File Offset: 0x001A0FD6
		// (set) Token: 0x06011D8D RID: 73101 RVA: 0x001A2DE6 File Offset: 0x001A0FE6
		public unsafe int MinimalReplicationTagCountBits
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_MinimalReplicationTagCountBits);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_MinimalReplicationTagCountBits) = value;
			}
		}

		// Token: 0x170045A9 RID: 17833
		// (get) Token: 0x06011D8E RID: 73102 RVA: 0x001A2DF8 File Offset: 0x001A0FF8
		// (set) Token: 0x06011D8F RID: 73103 RVA: 0x001A2E31 File Offset: 0x001A1031
		public FNetSerializeScriptStructCache TargetDataStructCache
		{
			get
			{
				base.FastCheckIsValid();
				FNetSerializeScriptStructCache result;
				if ((result = this._TargetDataStructCache) == null)
				{
					result = (this._TargetDataStructCache = new FNetSerializeScriptStructCache(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_TargetDataStructCache, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNetSerializeScriptStructCache.StaticStruct(), base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_TargetDataStructCache, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170045AA RID: 17834
		// (get) Token: 0x06011D90 RID: 73104 RVA: 0x001A2E52 File Offset: 0x001A1052
		// (set) Token: 0x06011D91 RID: 73105 RVA: 0x001A2E62 File Offset: 0x001A1062
		public unsafe bool bAllowGameplayModEvaluationChannels
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_bAllowGameplayModEvaluationChannels) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_bAllowGameplayModEvaluationChannels) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045AB RID: 17835
		// (get) Token: 0x06011D92 RID: 73106 RVA: 0x001A2E73 File Offset: 0x001A1073
		// (set) Token: 0x06011D93 RID: 73107 RVA: 0x001A2E83 File Offset: 0x001A1083
		public unsafe EGameplayModEvaluationChannel DefaultGameplayModEvaluationChannel
		{
			get
			{
				return (EGameplayModEvaluationChannel)(*(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_DefaultGameplayModEvaluationChannel));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_DefaultGameplayModEvaluationChannel) = (byte)value;
			}
		}

		// Token: 0x170045AC RID: 17836
		// (get) Token: 0x06011D94 RID: 73108 RVA: 0x001A2E94 File Offset: 0x001A1094
		// (set) Token: 0x06011D95 RID: 73109 RVA: 0x001A2ECF File Offset: 0x001A10CF
		public TFixedArray<FName> GameplayModEvaluationChannelAliases
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FName> result;
				if ((result = this._GameplayModEvaluationChannelAliases) == null)
				{
					result = (this._GameplayModEvaluationChannelAliases = new TFixedArray<FName>(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_GameplayModEvaluationChannelAliases, 10, this));
				}
				return result;
			}
			set
			{
				this.GameplayModEvaluationChannelAliases.CopyAssign(value);
			}
		}

		// Token: 0x170045AD RID: 17837
		// (get) Token: 0x06011D96 RID: 73110 RVA: 0x001A2EE0 File Offset: 0x001A10E0
		// (set) Token: 0x06011D97 RID: 73111 RVA: 0x001A2F19 File Offset: 0x001A1119
		public FSoftObjectPath GlobalCurveTableName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._GlobalCurveTableName) == null)
				{
					result = (this._GlobalCurveTableName = new FSoftObjectPath(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_GlobalCurveTableName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_GlobalCurveTableName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170045AE RID: 17838
		// (get) Token: 0x06011D98 RID: 73112 RVA: 0x001A2F3A File Offset: 0x001A113A
		// (set) Token: 0x06011D99 RID: 73113 RVA: 0x001A2F4E File Offset: 0x001A114E
		[Nullable(2)]
		public unsafe UCurveTable GlobalCurveTable
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveTable>(base.NativePtr / (IntPtr)sizeof(void*) + UAbilitySystemGlobals.__PropertyOffset_GlobalCurveTable);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAbilitySystemGlobals.__PropertyOffset_GlobalCurveTable, value);
			}
		}

		// Token: 0x170045AF RID: 17839
		// (get) Token: 0x06011D9A RID: 73114 RVA: 0x001A2F64 File Offset: 0x001A1164
		// (set) Token: 0x06011D9B RID: 73115 RVA: 0x001A2F9D File Offset: 0x001A119D
		public FSoftObjectPath GlobalAttributeMetaDataTableName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._GlobalAttributeMetaDataTableName) == null)
				{
					result = (this._GlobalAttributeMetaDataTableName = new FSoftObjectPath(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_GlobalAttributeMetaDataTableName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_GlobalAttributeMetaDataTableName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170045B0 RID: 17840
		// (get) Token: 0x06011D9C RID: 73116 RVA: 0x001A2FBE File Offset: 0x001A11BE
		// (set) Token: 0x06011D9D RID: 73117 RVA: 0x001A2FD2 File Offset: 0x001A11D2
		[Nullable(2)]
		public unsafe UDataTable GlobalAttributeMetaDataTable
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + UAbilitySystemGlobals.__PropertyOffset_GlobalAttributeMetaDataTable);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAbilitySystemGlobals.__PropertyOffset_GlobalAttributeMetaDataTable, value);
			}
		}

		// Token: 0x170045B1 RID: 17841
		// (get) Token: 0x06011D9E RID: 73118 RVA: 0x001A2FE8 File Offset: 0x001A11E8
		// (set) Token: 0x06011D9F RID: 73119 RVA: 0x001A3021 File Offset: 0x001A1221
		public FSoftObjectPath GlobalAttributeSetDefaultsTableName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._GlobalAttributeSetDefaultsTableName) == null)
				{
					result = (this._GlobalAttributeSetDefaultsTableName = new FSoftObjectPath(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_GlobalAttributeSetDefaultsTableName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_GlobalAttributeSetDefaultsTableName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170045B2 RID: 17842
		// (get) Token: 0x06011DA0 RID: 73120 RVA: 0x001A3044 File Offset: 0x001A1244
		// (set) Token: 0x06011DA1 RID: 73121 RVA: 0x001A307D File Offset: 0x001A127D
		public TArray<FSoftObjectPath> GlobalAttributeSetDefaultsTableNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSoftObjectPath> result;
				if ((result = this._GlobalAttributeSetDefaultsTableNames) == null)
				{
					result = (this._GlobalAttributeSetDefaultsTableNames = new TArray<FSoftObjectPath>(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_GlobalAttributeSetDefaultsTableNames, this));
				}
				return result;
			}
			set
			{
				this.GlobalAttributeSetDefaultsTableNames.CopyAssign(value);
			}
		}

		// Token: 0x170045B3 RID: 17843
		// (get) Token: 0x06011DA2 RID: 73122 RVA: 0x001A308C File Offset: 0x001A128C
		// (set) Token: 0x06011DA3 RID: 73123 RVA: 0x001A30C5 File Offset: 0x001A12C5
		public TArray<UCurveTable> GlobalAttributeDefaultsTables
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UCurveTable> result;
				if ((result = this._GlobalAttributeDefaultsTables) == null)
				{
					result = (this._GlobalAttributeDefaultsTables = new TArray<UCurveTable>(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_GlobalAttributeDefaultsTables, this));
				}
				return result;
			}
			set
			{
				this.GlobalAttributeDefaultsTables.CopyAssign(value);
			}
		}

		// Token: 0x170045B4 RID: 17844
		// (get) Token: 0x06011DA4 RID: 73124 RVA: 0x001A30D4 File Offset: 0x001A12D4
		// (set) Token: 0x06011DA5 RID: 73125 RVA: 0x001A310D File Offset: 0x001A130D
		public FSoftObjectPath GlobalGameplayCueManagerClass
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._GlobalGameplayCueManagerClass) == null)
				{
					result = (this._GlobalGameplayCueManagerClass = new FSoftObjectPath(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_GlobalGameplayCueManagerClass, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_GlobalGameplayCueManagerClass, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170045B5 RID: 17845
		// (get) Token: 0x06011DA6 RID: 73126 RVA: 0x001A3130 File Offset: 0x001A1330
		// (set) Token: 0x06011DA7 RID: 73127 RVA: 0x001A3169 File Offset: 0x001A1369
		public FSoftObjectPath GlobalGameplayCueManagerName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._GlobalGameplayCueManagerName) == null)
				{
					result = (this._GlobalGameplayCueManagerName = new FSoftObjectPath(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_GlobalGameplayCueManagerName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_GlobalGameplayCueManagerName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170045B6 RID: 17846
		// (get) Token: 0x06011DA8 RID: 73128 RVA: 0x001A318C File Offset: 0x001A138C
		// (set) Token: 0x06011DA9 RID: 73129 RVA: 0x001A31C5 File Offset: 0x001A13C5
		public TArray<string> GameplayCueNotifyPaths
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._GameplayCueNotifyPaths) == null)
				{
					result = (this._GameplayCueNotifyPaths = new TArray<string>(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_GameplayCueNotifyPaths, this));
				}
				return result;
			}
			set
			{
				this.GameplayCueNotifyPaths.CopyAssign(value);
			}
		}

		// Token: 0x170045B7 RID: 17847
		// (get) Token: 0x06011DAA RID: 73130 RVA: 0x001A31D4 File Offset: 0x001A13D4
		// (set) Token: 0x06011DAB RID: 73131 RVA: 0x001A320D File Offset: 0x001A140D
		public FSoftObjectPath GameplayTagResponseTableName
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._GameplayTagResponseTableName) == null)
				{
					result = (this._GameplayTagResponseTableName = new FSoftObjectPath(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_GameplayTagResponseTableName, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_GameplayTagResponseTableName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170045B8 RID: 17848
		// (get) Token: 0x06011DAC RID: 73132 RVA: 0x001A322E File Offset: 0x001A142E
		// (set) Token: 0x06011DAD RID: 73133 RVA: 0x001A3242 File Offset: 0x001A1442
		[Nullable(2)]
		public unsafe UGameplayTagReponseTable GameplayTagResponseTable
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGameplayTagReponseTable>(base.NativePtr / (IntPtr)sizeof(void*) + UAbilitySystemGlobals.__PropertyOffset_GameplayTagResponseTable);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAbilitySystemGlobals.__PropertyOffset_GameplayTagResponseTable, value);
			}
		}

		// Token: 0x170045B9 RID: 17849
		// (get) Token: 0x06011DAE RID: 73134 RVA: 0x001A3257 File Offset: 0x001A1457
		// (set) Token: 0x06011DAF RID: 73135 RVA: 0x001A3267 File Offset: 0x001A1467
		public unsafe bool PredictTargetGameplayEffects
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_PredictTargetGameplayEffects) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilitySystemGlobals.__PropertyOffset_PredictTargetGameplayEffects) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045BA RID: 17850
		// (get) Token: 0x06011DB0 RID: 73136 RVA: 0x001A3278 File Offset: 0x001A1478
		// (set) Token: 0x06011DB1 RID: 73137 RVA: 0x001A328C File Offset: 0x001A148C
		[Nullable(2)]
		public unsafe UGameplayCueManager GlobalGameplayCueManager
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGameplayCueManager>(base.NativePtr / (IntPtr)sizeof(void*) + UAbilitySystemGlobals.__PropertyOffset_GlobalGameplayCueManager);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAbilitySystemGlobals.__PropertyOffset_GlobalGameplayCueManager, value);
			}
		}

		// Token: 0x06011DB2 RID: 73138 RVA: 0x001A32A1 File Offset: 0x001A14A1
		public void ToggleIgnoreAbilitySystemCosts()
		{
			UAbilitySystemGlobals.__ToggleIgnoreAbilitySystemCosts_Internal(base.NativePtr);
		}

		// Token: 0x06011DB3 RID: 73139 RVA: 0x001A32AE File Offset: 0x001A14AE
		public void ToggleIgnoreAbilitySystemCooldowns()
		{
			UAbilitySystemGlobals.__ToggleIgnoreAbilitySystemCooldowns_Internal(base.NativePtr);
		}

		// Token: 0x06011DB4 RID: 73140 RVA: 0x001A32BC File Offset: 0x001A14BC
		public unsafe void ServerEndPlayerAbility(string AbilityNameMatch)
		{
			FString fstring = FString.AllocTemp(AbilityNameMatch);
			UAbilitySystemGlobals.__ServerEndPlayerAbility_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06011DB5 RID: 73141 RVA: 0x001A32E8 File Offset: 0x001A14E8
		public unsafe void ServerCancelPlayerAbility(string AbilityNameMatch)
		{
			FString fstring = FString.AllocTemp(AbilityNameMatch);
			UAbilitySystemGlobals.__ServerCancelPlayerAbility_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06011DB6 RID: 73142 RVA: 0x001A3314 File Offset: 0x001A1514
		public unsafe void ServerActivatePlayerAbility(string AbilityNameMatch)
		{
			FString fstring = FString.AllocTemp(AbilityNameMatch);
			UAbilitySystemGlobals.__ServerActivatePlayerAbility_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06011DB7 RID: 73143 RVA: 0x001A333E File Offset: 0x001A153E
		public void ListPlayerAbilities()
		{
			UAbilitySystemGlobals.__ListPlayerAbilities_Internal(base.NativePtr);
		}

		// Token: 0x06011DB8 RID: 73144
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ToggleIgnoreAbilitySystemCosts_Internal(IntPtr @this);

		// Token: 0x06011DB9 RID: 73145
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ToggleIgnoreAbilitySystemCooldowns_Internal(IntPtr @this);

		// Token: 0x06011DBA RID: 73146
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerEndPlayerAbility_Internal(IntPtr @this, in FString AbilityNameMatch);

		// Token: 0x06011DBB RID: 73147
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerCancelPlayerAbility_Internal(IntPtr @this, in FString AbilityNameMatch);

		// Token: 0x06011DBC RID: 73148
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerActivatePlayerAbility_Internal(IntPtr @this, in FString AbilityNameMatch);

		// Token: 0x06011DBD RID: 73149
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ListPlayerAbilities_Internal(IntPtr @this);

		// Token: 0x06011DBE RID: 73150 RVA: 0x001A334B File Offset: 0x001A154B
		static UAbilitySystemGlobals()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilitySystemGlobals");
		}

		// Token: 0x06011DBF RID: 73151 RVA: 0x001A3359 File Offset: 0x001A1559
		protected UAbilitySystemGlobals(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400989C RID: 39068
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilitySystemGlobals";

		// Token: 0x0400989D RID: 39069
		private static IntPtr _ClassPtr;

		// Token: 0x0400989E RID: 39070
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400989F RID: 39071
		internal static int __PropertyOffset_AbilitySystemGlobalsClassName;

		// Token: 0x040098A0 RID: 39072
		[Nullable(2)]
		private FSoftClassPath _AbilitySystemGlobalsClassName;

		// Token: 0x040098A1 RID: 39073
		internal static int __PropertyOffset_ActivateFailIsDeadTag;

		// Token: 0x040098A2 RID: 39074
		internal static int __PropertyOffset_ActivateFailIsDeadName;

		// Token: 0x040098A3 RID: 39075
		internal static int __PropertyOffset_ActivateFailCooldownTag;

		// Token: 0x040098A4 RID: 39076
		internal static int __PropertyOffset_ActivateFailCooldownName;

		// Token: 0x040098A5 RID: 39077
		internal static int __PropertyOffset_ActivateFailCostTag;

		// Token: 0x040098A6 RID: 39078
		internal static int __PropertyOffset_ActivateFailCostName;

		// Token: 0x040098A7 RID: 39079
		internal static int __PropertyOffset_ActivateFailTagsBlockedTag;

		// Token: 0x040098A8 RID: 39080
		internal static int __PropertyOffset_ActivateFailTagsBlockedName;

		// Token: 0x040098A9 RID: 39081
		internal static int __PropertyOffset_ActivateFailTagsMissingTag;

		// Token: 0x040098AA RID: 39082
		internal static int __PropertyOffset_ActivateFailTagsMissingName;

		// Token: 0x040098AB RID: 39083
		internal static int __PropertyOffset_ActivateFailNetworkingTag;

		// Token: 0x040098AC RID: 39084
		internal static int __PropertyOffset_ActivateFailNetworkingName;

		// Token: 0x040098AD RID: 39085
		internal static int __PropertyOffset_MinimalReplicationTagCountBits;

		// Token: 0x040098AE RID: 39086
		internal static int __PropertyOffset_TargetDataStructCache;

		// Token: 0x040098AF RID: 39087
		[Nullable(2)]
		private FNetSerializeScriptStructCache _TargetDataStructCache;

		// Token: 0x040098B0 RID: 39088
		internal static int __PropertyOffset_bAllowGameplayModEvaluationChannels;

		// Token: 0x040098B1 RID: 39089
		internal static int __PropertyOffset_DefaultGameplayModEvaluationChannel;

		// Token: 0x040098B2 RID: 39090
		internal static int __PropertyOffset_GameplayModEvaluationChannelAliases;

		// Token: 0x040098B3 RID: 39091
		[Nullable(2)]
		private TFixedArray<FName> _GameplayModEvaluationChannelAliases;

		// Token: 0x040098B4 RID: 39092
		internal static int __PropertyOffset_GlobalCurveTableName;

		// Token: 0x040098B5 RID: 39093
		[Nullable(2)]
		private FSoftObjectPath _GlobalCurveTableName;

		// Token: 0x040098B6 RID: 39094
		internal static int __PropertyOffset_GlobalCurveTable;

		// Token: 0x040098B7 RID: 39095
		internal static int __PropertyOffset_GlobalAttributeMetaDataTableName;

		// Token: 0x040098B8 RID: 39096
		[Nullable(2)]
		private FSoftObjectPath _GlobalAttributeMetaDataTableName;

		// Token: 0x040098B9 RID: 39097
		internal static int __PropertyOffset_GlobalAttributeMetaDataTable;

		// Token: 0x040098BA RID: 39098
		internal static int __PropertyOffset_GlobalAttributeSetDefaultsTableName;

		// Token: 0x040098BB RID: 39099
		[Nullable(2)]
		private FSoftObjectPath _GlobalAttributeSetDefaultsTableName;

		// Token: 0x040098BC RID: 39100
		internal static int __PropertyOffset_GlobalAttributeSetDefaultsTableNames;

		// Token: 0x040098BD RID: 39101
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoftObjectPath> _GlobalAttributeSetDefaultsTableNames;

		// Token: 0x040098BE RID: 39102
		internal static int __PropertyOffset_GlobalAttributeDefaultsTables;

		// Token: 0x040098BF RID: 39103
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UCurveTable> _GlobalAttributeDefaultsTables;

		// Token: 0x040098C0 RID: 39104
		internal static int __PropertyOffset_GlobalGameplayCueManagerClass;

		// Token: 0x040098C1 RID: 39105
		[Nullable(2)]
		private FSoftObjectPath _GlobalGameplayCueManagerClass;

		// Token: 0x040098C2 RID: 39106
		internal static int __PropertyOffset_GlobalGameplayCueManagerName;

		// Token: 0x040098C3 RID: 39107
		[Nullable(2)]
		private FSoftObjectPath _GlobalGameplayCueManagerName;

		// Token: 0x040098C4 RID: 39108
		internal static int __PropertyOffset_GameplayCueNotifyPaths;

		// Token: 0x040098C5 RID: 39109
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _GameplayCueNotifyPaths;

		// Token: 0x040098C6 RID: 39110
		internal static int __PropertyOffset_GameplayTagResponseTableName;

		// Token: 0x040098C7 RID: 39111
		[Nullable(2)]
		private FSoftObjectPath _GameplayTagResponseTableName;

		// Token: 0x040098C8 RID: 39112
		internal static int __PropertyOffset_GameplayTagResponseTable;

		// Token: 0x040098C9 RID: 39113
		internal static int __PropertyOffset_PredictTargetGameplayEffects;

		// Token: 0x040098CA RID: 39114
		internal static int __PropertyOffset_GlobalGameplayCueManager;
	}
}
