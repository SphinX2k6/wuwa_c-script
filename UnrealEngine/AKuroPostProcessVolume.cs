using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004DA RID: 1242
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroPostProcessVolume")]
	[UnrealStructLayout(9104, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 9104)]
	public class AKuroPostProcessVolume : APostProcessVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060073E1 RID: 29665 RVA: 0x000A9D3A File Offset: 0x000A7F3A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroPostProcessVolume._ClassPtr;
		}

		// Token: 0x060073E2 RID: 29666 RVA: 0x000A9D48 File Offset: 0x000A7F48
		public AKuroPostProcessVolume() : this(BuiltinUtils.AllocNativeUObject(AKuroPostProcessVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060073E3 RID: 29667 RVA: 0x000A9D70 File Offset: 0x000A7F70
		[NullableContext(1)]
		public AKuroPostProcessVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroPostProcessVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170016B1 RID: 5809
		// (get) Token: 0x060073E4 RID: 29668 RVA: 0x000A9DA3 File Offset: 0x000A7FA3
		// (set) Token: 0x060073E5 RID: 29669 RVA: 0x000A9DB7 File Offset: 0x000A7FB7
		public unsafe UKuroWeatherDataAsset WeatherDataAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroWeatherDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroPostProcessVolume.__PropertyOffset_WeatherDataAsset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroPostProcessVolume.__PropertyOffset_WeatherDataAsset, value);
			}
		}

		// Token: 0x170016B2 RID: 5810
		// (get) Token: 0x060073E6 RID: 29670 RVA: 0x000A9DCC File Offset: 0x000A7FCC
		// (set) Token: 0x060073E7 RID: 29671 RVA: 0x000A9DE0 File Offset: 0x000A7FE0
		public unsafe UKuroTODData PPTODDataAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroTODData>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroPostProcessVolume.__PropertyOffset_PPTODDataAsset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroPostProcessVolume.__PropertyOffset_PPTODDataAsset, value);
			}
		}

		// Token: 0x170016B3 RID: 5811
		// (get) Token: 0x060073E8 RID: 29672 RVA: 0x000A9DF5 File Offset: 0x000A7FF5
		// (set) Token: 0x060073E9 RID: 29673 RVA: 0x000A9E05 File Offset: 0x000A8005
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

		// Token: 0x170016B4 RID: 5812
		// (get) Token: 0x060073EA RID: 29674 RVA: 0x000A9E18 File Offset: 0x000A8018
		// (set) Token: 0x060073EB RID: 29675 RVA: 0x000A9E51 File Offset: 0x000A8051
		[Nullable(1)]
		public TArray<FName> DatalayerLabel
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				this.DatalayerLabel.CopyAssign(value);
			}
		}

		// Token: 0x060073EC RID: 29676 RVA: 0x000A9E5F File Offset: 0x000A805F
		public void SetWeatherDataAsset(UKuroWeatherDataAsset InWeatherDataAsset)
		{
			AKuroPostProcessVolume.__SetWeatherDataAsset_Internal(base.NativePtr, (InWeatherDataAsset != null) ? InWeatherDataAsset.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060073ED RID: 29677 RVA: 0x000A9E7C File Offset: 0x000A807C
		public void SetPPTODDataAsset(UKuroTODData InPPTODDataAsset)
		{
			AKuroPostProcessVolume.__SetPPTODDataAsset_Internal(base.NativePtr, (InPPTODDataAsset != null) ? InPPTODDataAsset.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060073EE RID: 29678 RVA: 0x000A9E99 File Offset: 0x000A8099
		public void PostModify()
		{
			AKuroPostProcessVolume.__PostModify_Internal(base.NativePtr);
		}

		// Token: 0x060073EF RID: 29679
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWeatherDataAsset_Internal(IntPtr @this, IntPtr InWeatherDataAsset);

		// Token: 0x060073F0 RID: 29680
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPPTODDataAsset_Internal(IntPtr @this, IntPtr InPPTODDataAsset);

		// Token: 0x060073F1 RID: 29681
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostModify_Internal(IntPtr @this);

		// Token: 0x060073F2 RID: 29682 RVA: 0x000A9EA6 File Offset: 0x000A80A6
		static AKuroPostProcessVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroPostProcessVolume");
		}

		// Token: 0x060073F3 RID: 29683 RVA: 0x000A9EB4 File Offset: 0x000A80B4
		protected AKuroPostProcessVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400319D RID: 12701
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroPostProcessVolume";

		// Token: 0x0400319E RID: 12702
		private static IntPtr _ClassPtr;

		// Token: 0x0400319F RID: 12703
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040031A0 RID: 12704
		internal static int __PropertyOffset_WeatherDataAsset;

		// Token: 0x040031A1 RID: 12705
		internal static int __PropertyOffset_PPTODDataAsset;

		// Token: 0x040031A2 RID: 12706
		internal static int __PropertyOffset_bUpdateOverrideWithTOD;

		// Token: 0x040031A3 RID: 12707
		internal static int __PropertyOffset_DatalayerLabel;

		// Token: 0x040031A4 RID: 12708
		private TArray<FName> _DatalayerLabel;
	}
}
