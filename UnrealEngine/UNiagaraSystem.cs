using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025EF RID: 9711
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraSystem")]
	[UnrealStructLayout(2216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2216)]
	public class UNiagaraSystem : UFXSystemAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060241B4 RID: 147892 RVA: 0x00356F2A File Offset: 0x0035512A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraSystem._ClassPtr;
		}

		// Token: 0x060241B5 RID: 147893 RVA: 0x00356F38 File Offset: 0x00355138
		public UNiagaraSystem() : this(BuiltinUtils.AllocNativeUObject(UNiagaraSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060241B6 RID: 147894 RVA: 0x00356F60 File Offset: 0x00355160
		public UNiagaraSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008AFF RID: 35583
		// (get) Token: 0x060241B7 RID: 147895 RVA: 0x00356F93 File Offset: 0x00355193
		// (set) Token: 0x060241B8 RID: 147896 RVA: 0x00356FA3 File Offset: 0x003551A3
		public unsafe bool bDumpDebugSystemInfo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bDumpDebugSystemInfo) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bDumpDebugSystemInfo) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008B00 RID: 35584
		// (get) Token: 0x060241B9 RID: 147897 RVA: 0x00356FB4 File Offset: 0x003551B4
		// (set) Token: 0x060241BA RID: 147898 RVA: 0x00356FC4 File Offset: 0x003551C4
		public unsafe bool bDumpDebugEmitterInfo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bDumpDebugEmitterInfo) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bDumpDebugEmitterInfo) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008B01 RID: 35585
		// (get) Token: 0x060241BB RID: 147899 RVA: 0x00356FD5 File Offset: 0x003551D5
		// (set) Token: 0x060241BC RID: 147900 RVA: 0x00356FE5 File Offset: 0x003551E5
		public unsafe bool bRequireCurrentFrameData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bRequireCurrentFrameData) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bRequireCurrentFrameData) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008B02 RID: 35586
		// (get) Token: 0x060241BD RID: 147901 RVA: 0x00356FF6 File Offset: 0x003551F6
		// (set) Token: 0x060241BE RID: 147902 RVA: 0x0035700F File Offset: 0x0035520F
		public unsafe bool bEvenTickWhenPaused
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bEvenTickWhenPaused) & UNiagaraSystem.__PropertyMask_bEvenTickWhenPaused) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bEvenTickWhenPaused) = ((*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bEvenTickWhenPaused) & ~UNiagaraSystem.__PropertyMask_bEvenTickWhenPaused) | (value ? UNiagaraSystem.__PropertyMask_bEvenTickWhenPaused : 0));
			}
		}

		// Token: 0x17008B03 RID: 35587
		// (get) Token: 0x060241BF RID: 147903 RVA: 0x0035703F File Offset: 0x0035523F
		// (set) Token: 0x060241C0 RID: 147904 RVA: 0x00357058 File Offset: 0x00355258
		public unsafe bool bFixedBounds
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bFixedBounds) & UNiagaraSystem.__PropertyMask_bFixedBounds) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bFixedBounds) = ((*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bFixedBounds) & ~UNiagaraSystem.__PropertyMask_bFixedBounds) | (value ? UNiagaraSystem.__PropertyMask_bFixedBounds : 0));
			}
		}

		// Token: 0x17008B04 RID: 35588
		// (get) Token: 0x060241C1 RID: 147905 RVA: 0x00357088 File Offset: 0x00355288
		// (set) Token: 0x060241C2 RID: 147906 RVA: 0x003570A1 File Offset: 0x003552A1
		public unsafe bool bDisableExperimentalVM
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bDisableExperimentalVM) & UNiagaraSystem.__PropertyMask_bDisableExperimentalVM) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bDisableExperimentalVM) = ((*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bDisableExperimentalVM) & ~UNiagaraSystem.__PropertyMask_bDisableExperimentalVM) | (value ? UNiagaraSystem.__PropertyMask_bDisableExperimentalVM : 0));
			}
		}

		// Token: 0x17008B05 RID: 35589
		// (get) Token: 0x060241C3 RID: 147907 RVA: 0x003570D1 File Offset: 0x003552D1
		// (set) Token: 0x060241C4 RID: 147908 RVA: 0x003570E1 File Offset: 0x003552E1
		public unsafe EKuroNiagaraEffectRegularType EffectRegularType
		{
			get
			{
				return (EKuroNiagaraEffectRegularType)(*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_EffectRegularType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_EffectRegularType) = (byte)value;
			}
		}

		// Token: 0x17008B06 RID: 35590
		// (get) Token: 0x060241C5 RID: 147909 RVA: 0x003570F2 File Offset: 0x003552F2
		// (set) Token: 0x060241C6 RID: 147910 RVA: 0x00357106 File Offset: 0x00355306
		[Nullable(2)]
		public unsafe UNiagaraEffectType EffectType
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraEffectType>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraSystem.__PropertyOffset_EffectType);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraSystem.__PropertyOffset_EffectType, value);
			}
		}

		// Token: 0x17008B07 RID: 35591
		// (get) Token: 0x060241C7 RID: 147911 RVA: 0x0035711B File Offset: 0x0035531B
		// (set) Token: 0x060241C8 RID: 147912 RVA: 0x0035712B File Offset: 0x0035532B
		public unsafe EKuroNiagaraEffectTypePresets EffectTypePreset
		{
			get
			{
				return (EKuroNiagaraEffectTypePresets)(*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_EffectTypePreset));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_EffectTypePreset) = (byte)value;
			}
		}

		// Token: 0x17008B08 RID: 35592
		// (get) Token: 0x060241C9 RID: 147913 RVA: 0x0035713C File Offset: 0x0035533C
		// (set) Token: 0x060241CA RID: 147914 RVA: 0x00357150 File Offset: 0x00355350
		[Nullable(2)]
		public unsafe UNiagaraEffectType EffectType_Override
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraEffectType>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraSystem.__PropertyOffset_EffectType_Override);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraSystem.__PropertyOffset_EffectType_Override, value);
			}
		}

		// Token: 0x17008B09 RID: 35593
		// (get) Token: 0x060241CB RID: 147915 RVA: 0x00357165 File Offset: 0x00355365
		// (set) Token: 0x060241CC RID: 147916 RVA: 0x00357175 File Offset: 0x00355375
		public unsafe EKuroNiagaraTickTypePresets TickTypePreset
		{
			get
			{
				return (EKuroNiagaraTickTypePresets)(*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_TickTypePreset));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_TickTypePreset) = (byte)value;
			}
		}

		// Token: 0x17008B0A RID: 35594
		// (get) Token: 0x060241CD RID: 147917 RVA: 0x00357186 File Offset: 0x00355386
		// (set) Token: 0x060241CE RID: 147918 RVA: 0x0035719A File Offset: 0x0035539A
		[Nullable(2)]
		public unsafe UKuroNiagaraTickType TickType_Override
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroNiagaraTickType>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraSystem.__PropertyOffset_TickType_Override);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraSystem.__PropertyOffset_TickType_Override, value);
			}
		}

		// Token: 0x17008B0B RID: 35595
		// (get) Token: 0x060241CF RID: 147919 RVA: 0x003571AF File Offset: 0x003553AF
		// (set) Token: 0x060241D0 RID: 147920 RVA: 0x003571BF File Offset: 0x003553BF
		public unsafe bool bOverrideScreenSizeCullRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bOverrideScreenSizeCullRatio) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bOverrideScreenSizeCullRatio) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008B0C RID: 35596
		// (get) Token: 0x060241D1 RID: 147921 RVA: 0x003571D0 File Offset: 0x003553D0
		// (set) Token: 0x060241D2 RID: 147922 RVA: 0x003571E0 File Offset: 0x003553E0
		public unsafe float ScreenSizeCullRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_ScreenSizeCullRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_ScreenSizeCullRatio) = value;
			}
		}

		// Token: 0x17008B0D RID: 35597
		// (get) Token: 0x060241D3 RID: 147923 RVA: 0x003571F1 File Offset: 0x003553F1
		// (set) Token: 0x060241D4 RID: 147924 RVA: 0x00357201 File Offset: 0x00355401
		public unsafe bool bUseNDCBatch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bUseNDCBatch) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bUseNDCBatch) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008B0E RID: 35598
		// (get) Token: 0x060241D5 RID: 147925 RVA: 0x00357212 File Offset: 0x00355412
		// (set) Token: 0x060241D6 RID: 147926 RVA: 0x00357226 File Offset: 0x00355426
		[Nullable(2)]
		public unsafe UNiagaraDataChannelAsset DataChannel
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraDataChannelAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraSystem.__PropertyOffset_DataChannel);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraSystem.__PropertyOffset_DataChannel, value);
			}
		}

		// Token: 0x17008B0F RID: 35599
		// (get) Token: 0x060241D7 RID: 147927 RVA: 0x0035723B File Offset: 0x0035543B
		// (set) Token: 0x060241D8 RID: 147928 RVA: 0x0035724B File Offset: 0x0035544B
		public unsafe int BatchLimitNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_BatchLimitNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_BatchLimitNum) = value;
			}
		}

		// Token: 0x17008B10 RID: 35600
		// (get) Token: 0x060241D9 RID: 147929 RVA: 0x0035725C File Offset: 0x0035545C
		// (set) Token: 0x060241DA RID: 147930 RVA: 0x0035726C File Offset: 0x0035546C
		public unsafe bool bOverrideMaxVisibleCullDeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bOverrideMaxVisibleCullDeltaTime) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bOverrideMaxVisibleCullDeltaTime) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008B11 RID: 35601
		// (get) Token: 0x060241DB RID: 147931 RVA: 0x0035727D File Offset: 0x0035547D
		// (set) Token: 0x060241DC RID: 147932 RVA: 0x0035728D File Offset: 0x0035548D
		public unsafe float MaxVisibleCullDeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_MaxVisibleCullDeltaTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_MaxVisibleCullDeltaTime) = value;
			}
		}

		// Token: 0x17008B12 RID: 35602
		// (get) Token: 0x060241DD RID: 147933 RVA: 0x0035729E File Offset: 0x0035549E
		// (set) Token: 0x060241DE RID: 147934 RVA: 0x003572AE File Offset: 0x003554AE
		public unsafe bool bOverrideScalabilitySettings
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bOverrideScalabilitySettings) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bOverrideScalabilitySettings) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008B13 RID: 35603
		// (get) Token: 0x060241DF RID: 147935 RVA: 0x003572C0 File Offset: 0x003554C0
		// (set) Token: 0x060241E0 RID: 147936 RVA: 0x003572F9 File Offset: 0x003554F9
		public TArray<FNiagaraSystemScalabilityOverride> ScalabilityOverrides_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraSystemScalabilityOverride> result;
				if ((result = this._ScalabilityOverrides_DEPRECATED) == null)
				{
					result = (this._ScalabilityOverrides_DEPRECATED = new TArray<FNiagaraSystemScalabilityOverride>(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_ScalabilityOverrides_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				this.ScalabilityOverrides_DEPRECATED.CopyAssign(value);
			}
		}

		// Token: 0x17008B14 RID: 35604
		// (get) Token: 0x060241E1 RID: 147937 RVA: 0x00357308 File Offset: 0x00355508
		// (set) Token: 0x060241E2 RID: 147938 RVA: 0x00357341 File Offset: 0x00355541
		public FNiagaraSystemScalabilityOverrides SystemScalabilityOverrides
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraSystemScalabilityOverrides result;
				if ((result = this._SystemScalabilityOverrides) == null)
				{
					result = (this._SystemScalabilityOverrides = new FNiagaraSystemScalabilityOverrides(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_SystemScalabilityOverrides, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraSystemScalabilityOverrides.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_SystemScalabilityOverrides, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008B15 RID: 35605
		// (get) Token: 0x060241E3 RID: 147939 RVA: 0x00357364 File Offset: 0x00355564
		// (set) Token: 0x060241E4 RID: 147940 RVA: 0x0035739D File Offset: 0x0035559D
		public TArray<FNiagaraEmitterHandle> EmitterHandles
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNiagaraEmitterHandle> result;
				if ((result = this._EmitterHandles) == null)
				{
					result = (this._EmitterHandles = new TArray<FNiagaraEmitterHandle>(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_EmitterHandles, this));
				}
				return result;
			}
			set
			{
				this.EmitterHandles.CopyAssign(value);
			}
		}

		// Token: 0x17008B16 RID: 35606
		// (get) Token: 0x060241E5 RID: 147941 RVA: 0x003573AC File Offset: 0x003555AC
		// (set) Token: 0x060241E6 RID: 147942 RVA: 0x003573E5 File Offset: 0x003555E5
		public TArray<UNiagaraParameterCollectionInstance> ParameterCollectionOverrides
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UNiagaraParameterCollectionInstance> result;
				if ((result = this._ParameterCollectionOverrides) == null)
				{
					result = (this._ParameterCollectionOverrides = new TArray<UNiagaraParameterCollectionInstance>(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_ParameterCollectionOverrides, this));
				}
				return result;
			}
			set
			{
				this.ParameterCollectionOverrides.CopyAssign(value);
			}
		}

		// Token: 0x17008B17 RID: 35607
		// (get) Token: 0x060241E7 RID: 147943 RVA: 0x003573F3 File Offset: 0x003555F3
		// (set) Token: 0x060241E8 RID: 147944 RVA: 0x00357407 File Offset: 0x00355607
		[Nullable(2)]
		public unsafe UNiagaraScript SystemSpawnScript
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraScript>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraSystem.__PropertyOffset_SystemSpawnScript);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraSystem.__PropertyOffset_SystemSpawnScript, value);
			}
		}

		// Token: 0x17008B18 RID: 35608
		// (get) Token: 0x060241E9 RID: 147945 RVA: 0x0035741C File Offset: 0x0035561C
		// (set) Token: 0x060241EA RID: 147946 RVA: 0x00357430 File Offset: 0x00355630
		[Nullable(2)]
		public unsafe UNiagaraScript SystemUpdateScript
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraScript>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraSystem.__PropertyOffset_SystemUpdateScript);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraSystem.__PropertyOffset_SystemUpdateScript, value);
			}
		}

		// Token: 0x17008B19 RID: 35609
		// (get) Token: 0x060241EB RID: 147947 RVA: 0x00357448 File Offset: 0x00355648
		// (set) Token: 0x060241EC RID: 147948 RVA: 0x00357481 File Offset: 0x00355681
		public FNiagaraSystemCompiledData SystemCompiledData
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraSystemCompiledData result;
				if ((result = this._SystemCompiledData) == null)
				{
					result = (this._SystemCompiledData = new FNiagaraSystemCompiledData(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_SystemCompiledData, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraSystemCompiledData.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_SystemCompiledData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008B1A RID: 35610
		// (get) Token: 0x060241ED RID: 147949 RVA: 0x003574A4 File Offset: 0x003556A4
		// (set) Token: 0x060241EE RID: 147950 RVA: 0x003574DD File Offset: 0x003556DD
		public FNiagaraUserRedirectionParameterStore ExposedParameters
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraUserRedirectionParameterStore result;
				if ((result = this._ExposedParameters) == null)
				{
					result = (this._ExposedParameters = new FNiagaraUserRedirectionParameterStore(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_ExposedParameters, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraUserRedirectionParameterStore.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_ExposedParameters, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008B1B RID: 35611
		// (get) Token: 0x060241EF RID: 147951 RVA: 0x003574FE File Offset: 0x003556FE
		// (set) Token: 0x060241F0 RID: 147952 RVA: 0x00357512 File Offset: 0x00355712
		public unsafe FBox FixedBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_FixedBounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_FixedBounds) = value;
			}
		}

		// Token: 0x17008B1C RID: 35612
		// (get) Token: 0x060241F1 RID: 147953 RVA: 0x00357527 File Offset: 0x00355727
		// (set) Token: 0x060241F2 RID: 147954 RVA: 0x00357537 File Offset: 0x00355737
		public unsafe bool bAutoDeactivate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bAutoDeactivate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bAutoDeactivate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008B1D RID: 35613
		// (get) Token: 0x060241F3 RID: 147955 RVA: 0x00357548 File Offset: 0x00355748
		// (set) Token: 0x060241F4 RID: 147956 RVA: 0x00357558 File Offset: 0x00355758
		public unsafe float WarmupTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_WarmupTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_WarmupTime) = value;
			}
		}

		// Token: 0x17008B1E RID: 35614
		// (get) Token: 0x060241F5 RID: 147957 RVA: 0x00357569 File Offset: 0x00355769
		// (set) Token: 0x060241F6 RID: 147958 RVA: 0x00357579 File Offset: 0x00355779
		public unsafe int WarmupTickCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_WarmupTickCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_WarmupTickCount) = value;
			}
		}

		// Token: 0x17008B1F RID: 35615
		// (get) Token: 0x060241F7 RID: 147959 RVA: 0x0035758A File Offset: 0x0035578A
		// (set) Token: 0x060241F8 RID: 147960 RVA: 0x0035759A File Offset: 0x0035579A
		public unsafe float WarmupTickDelta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_WarmupTickDelta);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_WarmupTickDelta) = value;
			}
		}

		// Token: 0x17008B20 RID: 35616
		// (get) Token: 0x060241F9 RID: 147961 RVA: 0x003575AB File Offset: 0x003557AB
		// (set) Token: 0x060241FA RID: 147962 RVA: 0x003575BB File Offset: 0x003557BB
		public unsafe bool bHasSystemScriptDIsWithPerInstanceData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bHasSystemScriptDIsWithPerInstanceData) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bHasSystemScriptDIsWithPerInstanceData) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008B21 RID: 35617
		// (get) Token: 0x060241FB RID: 147963 RVA: 0x003575CC File Offset: 0x003557CC
		// (set) Token: 0x060241FC RID: 147964 RVA: 0x00357605 File Offset: 0x00355805
		public TArray<FName> UserDINamesReadInSystemScripts
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._UserDINamesReadInSystemScripts) == null)
				{
					result = (this._UserDINamesReadInSystemScripts = new TArray<FName>(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_UserDINamesReadInSystemScripts, this));
				}
				return result;
			}
			set
			{
				this.UserDINamesReadInSystemScripts.CopyAssign(value);
			}
		}

		// Token: 0x060241FD RID: 147965 RVA: 0x00357613 File Offset: 0x00355813
		static UNiagaraSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraSystem");
		}

		// Token: 0x060241FE RID: 147966 RVA: 0x00357621 File Offset: 0x00355821
		protected UNiagaraSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040135ED RID: 79341
		public new const string __ObjectPath = "/Script/Niagara.NiagaraSystem";

		// Token: 0x040135EE RID: 79342
		private static IntPtr _ClassPtr;

		// Token: 0x040135EF RID: 79343
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040135F0 RID: 79344
		internal static int __PropertyOffset_bDumpDebugSystemInfo;

		// Token: 0x040135F1 RID: 79345
		internal static int __PropertyOffset_bDumpDebugEmitterInfo;

		// Token: 0x040135F2 RID: 79346
		internal static int __PropertyOffset_bRequireCurrentFrameData;

		// Token: 0x040135F3 RID: 79347
		internal static int __PropertyOffset_bEvenTickWhenPaused;

		// Token: 0x040135F4 RID: 79348
		internal static byte __PropertyMask_bEvenTickWhenPaused;

		// Token: 0x040135F5 RID: 79349
		internal static int __PropertyOffset_bFixedBounds;

		// Token: 0x040135F6 RID: 79350
		internal static byte __PropertyMask_bFixedBounds;

		// Token: 0x040135F7 RID: 79351
		internal static int __PropertyOffset_bDisableExperimentalVM;

		// Token: 0x040135F8 RID: 79352
		internal static byte __PropertyMask_bDisableExperimentalVM;

		// Token: 0x040135F9 RID: 79353
		internal static int __PropertyOffset_EffectRegularType;

		// Token: 0x040135FA RID: 79354
		internal static int __PropertyOffset_EffectType;

		// Token: 0x040135FB RID: 79355
		internal static int __PropertyOffset_EffectTypePreset;

		// Token: 0x040135FC RID: 79356
		internal static int __PropertyOffset_EffectType_Override;

		// Token: 0x040135FD RID: 79357
		internal static int __PropertyOffset_TickTypePreset;

		// Token: 0x040135FE RID: 79358
		internal static int __PropertyOffset_TickType_Override;

		// Token: 0x040135FF RID: 79359
		internal static int __PropertyOffset_bOverrideScreenSizeCullRatio;

		// Token: 0x04013600 RID: 79360
		internal static int __PropertyOffset_ScreenSizeCullRatio;

		// Token: 0x04013601 RID: 79361
		internal static int __PropertyOffset_bUseNDCBatch;

		// Token: 0x04013602 RID: 79362
		internal static int __PropertyOffset_DataChannel;

		// Token: 0x04013603 RID: 79363
		internal static int __PropertyOffset_BatchLimitNum;

		// Token: 0x04013604 RID: 79364
		internal static int __PropertyOffset_bOverrideMaxVisibleCullDeltaTime;

		// Token: 0x04013605 RID: 79365
		internal static int __PropertyOffset_MaxVisibleCullDeltaTime;

		// Token: 0x04013606 RID: 79366
		internal static int __PropertyOffset_bOverrideScalabilitySettings;

		// Token: 0x04013607 RID: 79367
		internal static int __PropertyOffset_ScalabilityOverrides_DEPRECATED;

		// Token: 0x04013608 RID: 79368
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraSystemScalabilityOverride> _ScalabilityOverrides_DEPRECATED;

		// Token: 0x04013609 RID: 79369
		internal static int __PropertyOffset_SystemScalabilityOverrides;

		// Token: 0x0401360A RID: 79370
		[Nullable(2)]
		private FNiagaraSystemScalabilityOverrides _SystemScalabilityOverrides;

		// Token: 0x0401360B RID: 79371
		internal static int __PropertyOffset_EmitterHandles;

		// Token: 0x0401360C RID: 79372
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNiagaraEmitterHandle> _EmitterHandles;

		// Token: 0x0401360D RID: 79373
		internal static int __PropertyOffset_ParameterCollectionOverrides;

		// Token: 0x0401360E RID: 79374
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UNiagaraParameterCollectionInstance> _ParameterCollectionOverrides;

		// Token: 0x0401360F RID: 79375
		internal static int __PropertyOffset_SystemSpawnScript;

		// Token: 0x04013610 RID: 79376
		internal static int __PropertyOffset_SystemUpdateScript;

		// Token: 0x04013611 RID: 79377
		internal static int __PropertyOffset_SystemCompiledData;

		// Token: 0x04013612 RID: 79378
		[Nullable(2)]
		private FNiagaraSystemCompiledData _SystemCompiledData;

		// Token: 0x04013613 RID: 79379
		internal static int __PropertyOffset_ExposedParameters;

		// Token: 0x04013614 RID: 79380
		[Nullable(2)]
		private FNiagaraUserRedirectionParameterStore _ExposedParameters;

		// Token: 0x04013615 RID: 79381
		internal static int __PropertyOffset_FixedBounds;

		// Token: 0x04013616 RID: 79382
		internal static int __PropertyOffset_bAutoDeactivate;

		// Token: 0x04013617 RID: 79383
		internal static int __PropertyOffset_WarmupTime;

		// Token: 0x04013618 RID: 79384
		internal static int __PropertyOffset_WarmupTickCount;

		// Token: 0x04013619 RID: 79385
		internal static int __PropertyOffset_WarmupTickDelta;

		// Token: 0x0401361A RID: 79386
		internal static int __PropertyOffset_bHasSystemScriptDIsWithPerInstanceData;

		// Token: 0x0401361B RID: 79387
		internal static int __PropertyOffset_UserDINamesReadInSystemScripts;

		// Token: 0x0401361C RID: 79388
		[Nullable(2)]
		private TArray<FName> _UserDINamesReadInSystemScripts;
	}
}
