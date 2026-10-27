using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B92 RID: 7058
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroPostProcessVolume")]
	[UnrealStructLayout(9040, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 9040)]
	public class AKuroPostProcessVolume : APostProcessVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601AD92 RID: 109970 RVA: 0x00279788 File Offset: 0x00277988
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroPostProcessVolume._ClassPtr;
		}

		// Token: 0x0601AD93 RID: 109971 RVA: 0x00279794 File Offset: 0x00277994
		public AKuroPostProcessVolume() : this(BuiltinUtils.AllocNativeUObject(AKuroPostProcessVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601AD94 RID: 109972 RVA: 0x002797BC File Offset: 0x002779BC
		public AKuroPostProcessVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroPostProcessVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006C38 RID: 27704
		// (get) Token: 0x0601AD95 RID: 109973 RVA: 0x002797EF File Offset: 0x002779EF
		// (set) Token: 0x0601AD96 RID: 109974 RVA: 0x00279803 File Offset: 0x00277A03
		[Nullable(2)]
		public unsafe UKuroWeatherDataAsset WeatherDataAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroWeatherDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroPostProcessVolume.__PropertyOffset_WeatherDataAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroPostProcessVolume.__PropertyOffset_WeatherDataAsset, value);
			}
		}

		// Token: 0x17006C39 RID: 27705
		// (get) Token: 0x0601AD97 RID: 109975 RVA: 0x00279818 File Offset: 0x00277A18
		// (set) Token: 0x0601AD98 RID: 109976 RVA: 0x0027982C File Offset: 0x00277A2C
		[Nullable(2)]
		public unsafe UKuroTODData PPTODDataAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroTODData>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroPostProcessVolume.__PropertyOffset_PPTODDataAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroPostProcessVolume.__PropertyOffset_PPTODDataAsset, value);
			}
		}

		// Token: 0x17006C3A RID: 27706
		// (get) Token: 0x0601AD99 RID: 109977 RVA: 0x00279844 File Offset: 0x00277A44
		// (set) Token: 0x0601AD9A RID: 109978 RVA: 0x0027987D File Offset: 0x00277A7D
		public FKuroGISetting GISetting
		{
			get
			{
				base.FastCheckIsValid();
				FKuroGISetting result;
				if ((result = this._GISetting) == null)
				{
					result = (this._GISetting = new FKuroGISetting(base.NativePtr + (IntPtr)AKuroPostProcessVolume.__PropertyOffset_GISetting, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroGISetting.StaticStruct(), base.NativePtr + (IntPtr)AKuroPostProcessVolume.__PropertyOffset_GISetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006C3B RID: 27707
		// (get) Token: 0x0601AD9B RID: 109979 RVA: 0x002798A0 File Offset: 0x00277AA0
		// (set) Token: 0x0601AD9C RID: 109980 RVA: 0x002798D9 File Offset: 0x00277AD9
		public FKuroGIPostProcessCustomData CustomData
		{
			get
			{
				base.FastCheckIsValid();
				FKuroGIPostProcessCustomData result;
				if ((result = this._CustomData) == null)
				{
					result = (this._CustomData = new FKuroGIPostProcessCustomData(base.NativePtr + (IntPtr)AKuroPostProcessVolume.__PropertyOffset_CustomData, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroGIPostProcessCustomData.StaticStruct(), base.NativePtr + (IntPtr)AKuroPostProcessVolume.__PropertyOffset_CustomData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006C3C RID: 27708
		// (get) Token: 0x0601AD9D RID: 109981 RVA: 0x002798FA File Offset: 0x00277AFA
		// (set) Token: 0x0601AD9E RID: 109982 RVA: 0x0027990A File Offset: 0x00277B0A
		public unsafe bool bUpdateOverrideWithTOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroPostProcessVolume.__PropertyOffset_bUpdateOverrideWithTOD) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroPostProcessVolume.__PropertyOffset_bUpdateOverrideWithTOD) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C3D RID: 27709
		// (get) Token: 0x0601AD9F RID: 109983 RVA: 0x0027991C File Offset: 0x00277B1C
		// (set) Token: 0x0601ADA0 RID: 109984 RVA: 0x00279955 File Offset: 0x00277B55
		public TArray<FName> DatalayerLabel
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._DatalayerLabel) == null)
				{
					result = (this._DatalayerLabel = new TArray<FName>(base.NativePtr + (IntPtr)AKuroPostProcessVolume.__PropertyOffset_DatalayerLabel, this));
				}
				return result;
			}
			set
			{
				this.DatalayerLabel.CopyAssign(value);
			}
		}

		// Token: 0x0601ADA1 RID: 109985 RVA: 0x00279963 File Offset: 0x00277B63
		[NullableContext(2)]
		public void SetWeatherDataAsset(UKuroWeatherDataAsset InWeatherDataAsset)
		{
			AKuroPostProcessVolume.__SetWeatherDataAsset_Internal(base.NativePtr, (InWeatherDataAsset != null) ? InWeatherDataAsset.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601ADA2 RID: 109986 RVA: 0x00279980 File Offset: 0x00277B80
		[NullableContext(2)]
		public void SetPPTODDataAsset(UKuroTODData InPPTODDataAsset)
		{
			AKuroPostProcessVolume.__SetPPTODDataAsset_Internal(base.NativePtr, (InPPTODDataAsset != null) ? InPPTODDataAsset.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601ADA3 RID: 109987 RVA: 0x0027999D File Offset: 0x00277B9D
		public void PostModify()
		{
			AKuroPostProcessVolume.__PostModify_Internal(base.NativePtr);
		}

		// Token: 0x0601ADA4 RID: 109988
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWeatherDataAsset_Internal(IntPtr @this, IntPtr InWeatherDataAsset);

		// Token: 0x0601ADA5 RID: 109989
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPPTODDataAsset_Internal(IntPtr @this, IntPtr InPPTODDataAsset);

		// Token: 0x0601ADA6 RID: 109990
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostModify_Internal(IntPtr @this);

		// Token: 0x0601ADA7 RID: 109991 RVA: 0x002799AA File Offset: 0x00277BAA
		static AKuroPostProcessVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroPostProcessVolume");
		}

		// Token: 0x0601ADA8 RID: 109992 RVA: 0x002799B8 File Offset: 0x00277BB8
		protected AKuroPostProcessVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E88F RID: 59535
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroPostProcessVolume";

		// Token: 0x0400E890 RID: 59536
		private static IntPtr _ClassPtr;

		// Token: 0x0400E891 RID: 59537
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E892 RID: 59538
		internal static int __PropertyOffset_WeatherDataAsset;

		// Token: 0x0400E893 RID: 59539
		internal static int __PropertyOffset_PPTODDataAsset;

		// Token: 0x0400E894 RID: 59540
		internal static int __PropertyOffset_GISetting;

		// Token: 0x0400E895 RID: 59541
		[Nullable(2)]
		private FKuroGISetting _GISetting;

		// Token: 0x0400E896 RID: 59542
		internal static int __PropertyOffset_CustomData;

		// Token: 0x0400E897 RID: 59543
		[Nullable(2)]
		private FKuroGIPostProcessCustomData _CustomData;

		// Token: 0x0400E898 RID: 59544
		internal static int __PropertyOffset_bUpdateOverrideWithTOD;

		// Token: 0x0400E899 RID: 59545
		internal static int __PropertyOffset_DatalayerLabel;

		// Token: 0x0400E89A RID: 59546
		[Nullable(2)]
		private TArray<FName> _DatalayerLabel;
	}
}
