using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001125 RID: 4389
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SoundBase")]
	[UnrealStructLayout(464, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public abstract class USoundBase : UObject, IUnrealUObject, IUnrealObject, IInterface_AssetUserData, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060100C7 RID: 65735 RVA: 0x0017A354 File Offset: 0x00178554
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundBase._ClassPtr;
		}

		// Token: 0x060100C8 RID: 65736 RVA: 0x0017A360 File Offset: 0x00178560
		int IInterface_AssetUserData.InterfaceOffset()
		{
			return USoundBase.__InterfaceOffset_IInterface_AssetUserData;
		}

		// Token: 0x17003EBC RID: 16060
		// (get) Token: 0x060100C9 RID: 65737 RVA: 0x0017A367 File Offset: 0x00178567
		// (set) Token: 0x060100CA RID: 65738 RVA: 0x0017A37B File Offset: 0x0017857B
		[Nullable(2)]
		public unsafe USoundClass SoundClassObject
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundClass>(base.NativePtr / (IntPtr)sizeof(void*) + USoundBase.__PropertyOffset_SoundClassObject);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USoundBase.__PropertyOffset_SoundClassObject, value);
			}
		}

		// Token: 0x17003EBD RID: 16061
		// (get) Token: 0x060100CB RID: 65739 RVA: 0x0017A390 File Offset: 0x00178590
		// (set) Token: 0x060100CC RID: 65740 RVA: 0x0017A3A9 File Offset: 0x001785A9
		public unsafe bool bDebug
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USoundBase.__PropertyOffset_bDebug) & USoundBase.__PropertyMask_bDebug) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USoundBase.__PropertyOffset_bDebug) = ((*(base.NativePtr + (IntPtr)USoundBase.__PropertyOffset_bDebug) & ~USoundBase.__PropertyMask_bDebug) | (value ? USoundBase.__PropertyMask_bDebug : 0));
			}
		}

		// Token: 0x17003EBE RID: 16062
		// (get) Token: 0x060100CD RID: 65741 RVA: 0x0017A3D9 File Offset: 0x001785D9
		// (set) Token: 0x060100CE RID: 65742 RVA: 0x0017A3F2 File Offset: 0x001785F2
		public unsafe bool bOverrideConcurrency
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USoundBase.__PropertyOffset_bOverrideConcurrency) & USoundBase.__PropertyMask_bOverrideConcurrency) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USoundBase.__PropertyOffset_bOverrideConcurrency) = ((*(base.NativePtr + (IntPtr)USoundBase.__PropertyOffset_bOverrideConcurrency) & ~USoundBase.__PropertyMask_bOverrideConcurrency) | (value ? USoundBase.__PropertyMask_bOverrideConcurrency : 0));
			}
		}

		// Token: 0x17003EBF RID: 16063
		// (get) Token: 0x060100CF RID: 65743 RVA: 0x0017A422 File Offset: 0x00178622
		// (set) Token: 0x060100D0 RID: 65744 RVA: 0x0017A43B File Offset: 0x0017863B
		public unsafe bool bOutputToBusOnly
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USoundBase.__PropertyOffset_bOutputToBusOnly) & USoundBase.__PropertyMask_bOutputToBusOnly) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USoundBase.__PropertyOffset_bOutputToBusOnly) = ((*(base.NativePtr + (IntPtr)USoundBase.__PropertyOffset_bOutputToBusOnly) & ~USoundBase.__PropertyMask_bOutputToBusOnly) | (value ? USoundBase.__PropertyMask_bOutputToBusOnly : 0));
			}
		}

		// Token: 0x17003EC0 RID: 16064
		// (get) Token: 0x060100D1 RID: 65745 RVA: 0x0017A46B File Offset: 0x0017866B
		// (set) Token: 0x060100D2 RID: 65746 RVA: 0x0017A484 File Offset: 0x00178684
		public unsafe bool bHasDelayNode
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USoundBase.__PropertyOffset_bHasDelayNode) & USoundBase.__PropertyMask_bHasDelayNode) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USoundBase.__PropertyOffset_bHasDelayNode) = ((*(base.NativePtr + (IntPtr)USoundBase.__PropertyOffset_bHasDelayNode) & ~USoundBase.__PropertyMask_bHasDelayNode) | (value ? USoundBase.__PropertyMask_bHasDelayNode : 0));
			}
		}

		// Token: 0x17003EC1 RID: 16065
		// (get) Token: 0x060100D3 RID: 65747 RVA: 0x0017A4B4 File Offset: 0x001786B4
		// (set) Token: 0x060100D4 RID: 65748 RVA: 0x0017A4CD File Offset: 0x001786CD
		public unsafe bool bHasConcatenatorNode
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USoundBase.__PropertyOffset_bHasConcatenatorNode) & USoundBase.__PropertyMask_bHasConcatenatorNode) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USoundBase.__PropertyOffset_bHasConcatenatorNode) = ((*(base.NativePtr + (IntPtr)USoundBase.__PropertyOffset_bHasConcatenatorNode) & ~USoundBase.__PropertyMask_bHasConcatenatorNode) | (value ? USoundBase.__PropertyMask_bHasConcatenatorNode : 0));
			}
		}

		// Token: 0x17003EC2 RID: 16066
		// (get) Token: 0x060100D5 RID: 65749 RVA: 0x0017A4FD File Offset: 0x001786FD
		// (set) Token: 0x060100D6 RID: 65750 RVA: 0x0017A516 File Offset: 0x00178716
		public unsafe bool bBypassVolumeScaleForPriority
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USoundBase.__PropertyOffset_bBypassVolumeScaleForPriority) & USoundBase.__PropertyMask_bBypassVolumeScaleForPriority) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USoundBase.__PropertyOffset_bBypassVolumeScaleForPriority) = ((*(base.NativePtr + (IntPtr)USoundBase.__PropertyOffset_bBypassVolumeScaleForPriority) & ~USoundBase.__PropertyMask_bBypassVolumeScaleForPriority) | (value ? USoundBase.__PropertyMask_bBypassVolumeScaleForPriority : 0));
			}
		}

		// Token: 0x17003EC3 RID: 16067
		// (get) Token: 0x060100D7 RID: 65751 RVA: 0x0017A546 File Offset: 0x00178746
		// (set) Token: 0x060100D8 RID: 65752 RVA: 0x0017A556 File Offset: 0x00178756
		public unsafe EVirtualizationMode VirtualizationMode
		{
			get
			{
				return (EVirtualizationMode)(*(base.NativePtr + (IntPtr)USoundBase.__PropertyOffset_VirtualizationMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundBase.__PropertyOffset_VirtualizationMode) = (byte)value;
			}
		}

		// Token: 0x17003EC4 RID: 16068
		// (get) Token: 0x060100D9 RID: 65753 RVA: 0x0017A568 File Offset: 0x00178768
		// (set) Token: 0x060100DA RID: 65754 RVA: 0x0017A5A1 File Offset: 0x001787A1
		public TSet<USoundConcurrency> ConcurrencySet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<USoundConcurrency> result;
				if ((result = this._ConcurrencySet) == null)
				{
					result = (this._ConcurrencySet = new TSet<USoundConcurrency>(base.NativePtr + (IntPtr)USoundBase.__PropertyOffset_ConcurrencySet, this));
				}
				return result;
			}
			set
			{
				this.ConcurrencySet.CopyAssign(value);
			}
		}

		// Token: 0x17003EC5 RID: 16069
		// (get) Token: 0x060100DB RID: 65755 RVA: 0x0017A5B0 File Offset: 0x001787B0
		// (set) Token: 0x060100DC RID: 65756 RVA: 0x0017A5E9 File Offset: 0x001787E9
		public FSoundConcurrencySettings ConcurrencyOverrides
		{
			get
			{
				base.FastCheckIsValid();
				FSoundConcurrencySettings result;
				if ((result = this._ConcurrencyOverrides) == null)
				{
					result = (this._ConcurrencyOverrides = new FSoundConcurrencySettings(base.NativePtr + (IntPtr)USoundBase.__PropertyOffset_ConcurrencyOverrides, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoundConcurrencySettings.StaticStruct(), base.NativePtr + (IntPtr)USoundBase.__PropertyOffset_ConcurrencyOverrides, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003EC6 RID: 16070
		// (get) Token: 0x060100DD RID: 65757 RVA: 0x0017A60A File Offset: 0x0017880A
		// (set) Token: 0x060100DE RID: 65758 RVA: 0x0017A61A File Offset: 0x0017881A
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundBase.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundBase.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x17003EC7 RID: 16071
		// (get) Token: 0x060100DF RID: 65759 RVA: 0x0017A62B File Offset: 0x0017882B
		// (set) Token: 0x060100E0 RID: 65760 RVA: 0x0017A63B File Offset: 0x0017883B
		public unsafe float MaxDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundBase.__PropertyOffset_MaxDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundBase.__PropertyOffset_MaxDistance) = value;
			}
		}

		// Token: 0x17003EC8 RID: 16072
		// (get) Token: 0x060100E1 RID: 65761 RVA: 0x0017A64C File Offset: 0x0017884C
		// (set) Token: 0x060100E2 RID: 65762 RVA: 0x0017A65C File Offset: 0x0017885C
		public unsafe float TotalSamples
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundBase.__PropertyOffset_TotalSamples);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundBase.__PropertyOffset_TotalSamples) = value;
			}
		}

		// Token: 0x17003EC9 RID: 16073
		// (get) Token: 0x060100E3 RID: 65763 RVA: 0x0017A66D File Offset: 0x0017886D
		// (set) Token: 0x060100E4 RID: 65764 RVA: 0x0017A67D File Offset: 0x0017887D
		public unsafe float Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundBase.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundBase.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x17003ECA RID: 16074
		// (get) Token: 0x060100E5 RID: 65765 RVA: 0x0017A68E File Offset: 0x0017888E
		// (set) Token: 0x060100E6 RID: 65766 RVA: 0x0017A6A2 File Offset: 0x001788A2
		[Nullable(2)]
		public unsafe USoundAttenuation AttenuationSettings
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundAttenuation>(base.NativePtr / (IntPtr)sizeof(void*) + USoundBase.__PropertyOffset_AttenuationSettings);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USoundBase.__PropertyOffset_AttenuationSettings, value);
			}
		}

		// Token: 0x17003ECB RID: 16075
		// (get) Token: 0x060100E7 RID: 65767 RVA: 0x0017A6B8 File Offset: 0x001788B8
		// (set) Token: 0x060100E8 RID: 65768 RVA: 0x0017A6F1 File Offset: 0x001788F1
		public FSoundModulationDefaultRoutingSettings ModulationSettings
		{
			get
			{
				base.FastCheckIsValid();
				FSoundModulationDefaultRoutingSettings result;
				if ((result = this._ModulationSettings) == null)
				{
					result = (this._ModulationSettings = new FSoundModulationDefaultRoutingSettings(base.NativePtr + (IntPtr)USoundBase.__PropertyOffset_ModulationSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoundModulationDefaultRoutingSettings.StaticStruct(), base.NativePtr + (IntPtr)USoundBase.__PropertyOffset_ModulationSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003ECC RID: 16076
		// (get) Token: 0x060100E9 RID: 65769 RVA: 0x0017A712 File Offset: 0x00178912
		// (set) Token: 0x060100EA RID: 65770 RVA: 0x0017A726 File Offset: 0x00178926
		[Nullable(2)]
		public unsafe USoundSubmixBase SoundSubmixObject
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundSubmixBase>(base.NativePtr / (IntPtr)sizeof(void*) + USoundBase.__PropertyOffset_SoundSubmixObject);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USoundBase.__PropertyOffset_SoundSubmixObject, value);
			}
		}

		// Token: 0x17003ECD RID: 16077
		// (get) Token: 0x060100EB RID: 65771 RVA: 0x0017A73C File Offset: 0x0017893C
		// (set) Token: 0x060100EC RID: 65772 RVA: 0x0017A775 File Offset: 0x00178975
		public TArray<FSoundSubmixSendInfo> SoundSubmixSends
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSoundSubmixSendInfo> result;
				if ((result = this._SoundSubmixSends) == null)
				{
					result = (this._SoundSubmixSends = new TArray<FSoundSubmixSendInfo>(base.NativePtr + (IntPtr)USoundBase.__PropertyOffset_SoundSubmixSends, this));
				}
				return result;
			}
			set
			{
				this.SoundSubmixSends.CopyAssign(value);
			}
		}

		// Token: 0x17003ECE RID: 16078
		// (get) Token: 0x060100ED RID: 65773 RVA: 0x0017A783 File Offset: 0x00178983
		// (set) Token: 0x060100EE RID: 65774 RVA: 0x0017A797 File Offset: 0x00178997
		[Nullable(2)]
		public unsafe USoundEffectSourcePresetChain SourceEffectChain
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundEffectSourcePresetChain>(base.NativePtr / (IntPtr)sizeof(void*) + USoundBase.__PropertyOffset_SourceEffectChain);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USoundBase.__PropertyOffset_SourceEffectChain, value);
			}
		}

		// Token: 0x17003ECF RID: 16079
		// (get) Token: 0x060100EF RID: 65775 RVA: 0x0017A7AC File Offset: 0x001789AC
		// (set) Token: 0x060100F0 RID: 65776 RVA: 0x0017A7E5 File Offset: 0x001789E5
		public TArray<FSoundSourceBusSendInfo> BusSends
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSoundSourceBusSendInfo> result;
				if ((result = this._BusSends) == null)
				{
					result = (this._BusSends = new TArray<FSoundSourceBusSendInfo>(base.NativePtr + (IntPtr)USoundBase.__PropertyOffset_BusSends, this));
				}
				return result;
			}
			set
			{
				this.BusSends.CopyAssign(value);
			}
		}

		// Token: 0x17003ED0 RID: 16080
		// (get) Token: 0x060100F1 RID: 65777 RVA: 0x0017A7F4 File Offset: 0x001789F4
		// (set) Token: 0x060100F2 RID: 65778 RVA: 0x0017A82D File Offset: 0x00178A2D
		public TArray<FSoundSourceBusSendInfo> PreEffectBusSends
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSoundSourceBusSendInfo> result;
				if ((result = this._PreEffectBusSends) == null)
				{
					result = (this._PreEffectBusSends = new TArray<FSoundSourceBusSendInfo>(base.NativePtr + (IntPtr)USoundBase.__PropertyOffset_PreEffectBusSends, this));
				}
				return result;
			}
			set
			{
				this.PreEffectBusSends.CopyAssign(value);
			}
		}

		// Token: 0x17003ED1 RID: 16081
		// (get) Token: 0x060100F3 RID: 65779 RVA: 0x0017A83C File Offset: 0x00178A3C
		// (set) Token: 0x060100F4 RID: 65780 RVA: 0x0017A875 File Offset: 0x00178A75
		public TArray<UAssetUserData> AssetUserData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UAssetUserData> result;
				if ((result = this._AssetUserData) == null)
				{
					result = (this._AssetUserData = new TArray<UAssetUserData>(base.NativePtr + (IntPtr)USoundBase.__PropertyOffset_AssetUserData, this));
				}
				return result;
			}
			set
			{
				this.AssetUserData.CopyAssign(value);
			}
		}

		// Token: 0x060100F5 RID: 65781 RVA: 0x0017A883 File Offset: 0x00178A83
		static USoundBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SoundBase");
		}

		// Token: 0x060100F6 RID: 65782 RVA: 0x0017A894 File Offset: 0x00178A94
		protected USoundBase() : this(BuiltinUtils.AllocNativeUObject(USoundBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060100F7 RID: 65783 RVA: 0x0017A8BC File Offset: 0x00178ABC
		protected USoundBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040089FC RID: 35324
		internal static int __InterfaceOffset_IInterface_AssetUserData;

		// Token: 0x040089FD RID: 35325
		public new const string __ObjectPath = "/Script/Engine.SoundBase";

		// Token: 0x040089FE RID: 35326
		private static IntPtr _ClassPtr;

		// Token: 0x040089FF RID: 35327
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008A00 RID: 35328
		internal static int __PropertyOffset_SoundClassObject;

		// Token: 0x04008A01 RID: 35329
		internal static int __PropertyOffset_bDebug;

		// Token: 0x04008A02 RID: 35330
		internal static byte __PropertyMask_bDebug;

		// Token: 0x04008A03 RID: 35331
		internal static int __PropertyOffset_bOverrideConcurrency;

		// Token: 0x04008A04 RID: 35332
		internal static byte __PropertyMask_bOverrideConcurrency;

		// Token: 0x04008A05 RID: 35333
		internal static int __PropertyOffset_bOutputToBusOnly;

		// Token: 0x04008A06 RID: 35334
		internal static byte __PropertyMask_bOutputToBusOnly;

		// Token: 0x04008A07 RID: 35335
		internal static int __PropertyOffset_bHasDelayNode;

		// Token: 0x04008A08 RID: 35336
		internal static byte __PropertyMask_bHasDelayNode;

		// Token: 0x04008A09 RID: 35337
		internal static int __PropertyOffset_bHasConcatenatorNode;

		// Token: 0x04008A0A RID: 35338
		internal static byte __PropertyMask_bHasConcatenatorNode;

		// Token: 0x04008A0B RID: 35339
		internal static int __PropertyOffset_bBypassVolumeScaleForPriority;

		// Token: 0x04008A0C RID: 35340
		internal static byte __PropertyMask_bBypassVolumeScaleForPriority;

		// Token: 0x04008A0D RID: 35341
		internal static int __PropertyOffset_VirtualizationMode;

		// Token: 0x04008A0E RID: 35342
		internal static int __PropertyOffset_ConcurrencySet;

		// Token: 0x04008A0F RID: 35343
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<USoundConcurrency> _ConcurrencySet;

		// Token: 0x04008A10 RID: 35344
		internal static int __PropertyOffset_ConcurrencyOverrides;

		// Token: 0x04008A11 RID: 35345
		[Nullable(2)]
		private FSoundConcurrencySettings _ConcurrencyOverrides;

		// Token: 0x04008A12 RID: 35346
		internal static int __PropertyOffset_Duration;

		// Token: 0x04008A13 RID: 35347
		internal static int __PropertyOffset_MaxDistance;

		// Token: 0x04008A14 RID: 35348
		internal static int __PropertyOffset_TotalSamples;

		// Token: 0x04008A15 RID: 35349
		internal static int __PropertyOffset_Priority;

		// Token: 0x04008A16 RID: 35350
		internal static int __PropertyOffset_AttenuationSettings;

		// Token: 0x04008A17 RID: 35351
		internal static int __PropertyOffset_ModulationSettings;

		// Token: 0x04008A18 RID: 35352
		[Nullable(2)]
		private FSoundModulationDefaultRoutingSettings _ModulationSettings;

		// Token: 0x04008A19 RID: 35353
		internal static int __PropertyOffset_SoundSubmixObject;

		// Token: 0x04008A1A RID: 35354
		internal static int __PropertyOffset_SoundSubmixSends;

		// Token: 0x04008A1B RID: 35355
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoundSubmixSendInfo> _SoundSubmixSends;

		// Token: 0x04008A1C RID: 35356
		internal static int __PropertyOffset_SourceEffectChain;

		// Token: 0x04008A1D RID: 35357
		internal static int __PropertyOffset_BusSends;

		// Token: 0x04008A1E RID: 35358
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoundSourceBusSendInfo> _BusSends;

		// Token: 0x04008A1F RID: 35359
		internal static int __PropertyOffset_PreEffectBusSends;

		// Token: 0x04008A20 RID: 35360
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoundSourceBusSendInfo> _PreEffectBusSends;

		// Token: 0x04008A21 RID: 35361
		internal static int __PropertyOffset_AssetUserData;

		// Token: 0x04008A22 RID: 35362
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAssetUserData> _AssetUserData;
	}
}
