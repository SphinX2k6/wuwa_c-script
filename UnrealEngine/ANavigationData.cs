using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200248A RID: 9354
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/NavigationSystem.NavigationData")]
	[UnrealStructLayout(1632, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1632)]
	public abstract class ANavigationData : AActor, IUnrealUObject, IUnrealObject, INavigationDataInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06022FAD RID: 143277 RVA: 0x0033B6AD File Offset: 0x003398AD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ANavigationData._ClassPtr;
		}

		// Token: 0x06022FAE RID: 143278 RVA: 0x0033B6B9 File Offset: 0x003398B9
		int INavigationDataInterface.InterfaceOffset()
		{
			return ANavigationData.__InterfaceOffset_INavigationDataInterface;
		}

		// Token: 0x17008659 RID: 34393
		// (get) Token: 0x06022FAF RID: 143279 RVA: 0x0033B6C0 File Offset: 0x003398C0
		// (set) Token: 0x06022FB0 RID: 143280 RVA: 0x0033B6D4 File Offset: 0x003398D4
		[Nullable(2)]
		public unsafe UPrimitiveComponent RenderingComp
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ANavigationData.__PropertyOffset_RenderingComp);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ANavigationData.__PropertyOffset_RenderingComp, value);
			}
		}

		// Token: 0x1700865A RID: 34394
		// (get) Token: 0x06022FB1 RID: 143281 RVA: 0x0033B6EC File Offset: 0x003398EC
		// (set) Token: 0x06022FB2 RID: 143282 RVA: 0x0033B725 File Offset: 0x00339925
		public FNavDataConfig NavDataConfig
		{
			get
			{
				base.FastCheckIsValid();
				FNavDataConfig result;
				if ((result = this._NavDataConfig) == null)
				{
					result = (this._NavDataConfig = new FNavDataConfig(base.NativePtr + (IntPtr)ANavigationData.__PropertyOffset_NavDataConfig, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNavDataConfig.StaticStruct(), base.NativePtr + (IntPtr)ANavigationData.__PropertyOffset_NavDataConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700865B RID: 34395
		// (get) Token: 0x06022FB3 RID: 143283 RVA: 0x0033B746 File Offset: 0x00339946
		// (set) Token: 0x06022FB4 RID: 143284 RVA: 0x0033B75F File Offset: 0x0033995F
		public unsafe bool bEnableDrawing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ANavigationData.__PropertyOffset_bEnableDrawing) & ANavigationData.__PropertyMask_bEnableDrawing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ANavigationData.__PropertyOffset_bEnableDrawing) = ((*(base.NativePtr + (IntPtr)ANavigationData.__PropertyOffset_bEnableDrawing) & ~ANavigationData.__PropertyMask_bEnableDrawing) | (value ? ANavigationData.__PropertyMask_bEnableDrawing : 0));
			}
		}

		// Token: 0x1700865C RID: 34396
		// (get) Token: 0x06022FB5 RID: 143285 RVA: 0x0033B78F File Offset: 0x0033998F
		// (set) Token: 0x06022FB6 RID: 143286 RVA: 0x0033B7A8 File Offset: 0x003399A8
		public unsafe bool bForceRebuildOnLoad
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ANavigationData.__PropertyOffset_bForceRebuildOnLoad) & ANavigationData.__PropertyMask_bForceRebuildOnLoad) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ANavigationData.__PropertyOffset_bForceRebuildOnLoad) = ((*(base.NativePtr + (IntPtr)ANavigationData.__PropertyOffset_bForceRebuildOnLoad) & ~ANavigationData.__PropertyMask_bForceRebuildOnLoad) | (value ? ANavigationData.__PropertyMask_bForceRebuildOnLoad : 0));
			}
		}

		// Token: 0x1700865D RID: 34397
		// (get) Token: 0x06022FB7 RID: 143287 RVA: 0x0033B7D8 File Offset: 0x003399D8
		// (set) Token: 0x06022FB8 RID: 143288 RVA: 0x0033B7F1 File Offset: 0x003399F1
		public unsafe bool bAutoDestroyWhenNoNavigation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ANavigationData.__PropertyOffset_bAutoDestroyWhenNoNavigation) & ANavigationData.__PropertyMask_bAutoDestroyWhenNoNavigation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ANavigationData.__PropertyOffset_bAutoDestroyWhenNoNavigation) = ((*(base.NativePtr + (IntPtr)ANavigationData.__PropertyOffset_bAutoDestroyWhenNoNavigation) & ~ANavigationData.__PropertyMask_bAutoDestroyWhenNoNavigation) | (value ? ANavigationData.__PropertyMask_bAutoDestroyWhenNoNavigation : 0));
			}
		}

		// Token: 0x1700865E RID: 34398
		// (get) Token: 0x06022FB9 RID: 143289 RVA: 0x0033B821 File Offset: 0x00339A21
		// (set) Token: 0x06022FBA RID: 143290 RVA: 0x0033B83A File Offset: 0x00339A3A
		public unsafe bool bCanBeMainNavData
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ANavigationData.__PropertyOffset_bCanBeMainNavData) & ANavigationData.__PropertyMask_bCanBeMainNavData) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ANavigationData.__PropertyOffset_bCanBeMainNavData) = ((*(base.NativePtr + (IntPtr)ANavigationData.__PropertyOffset_bCanBeMainNavData) & ~ANavigationData.__PropertyMask_bCanBeMainNavData) | (value ? ANavigationData.__PropertyMask_bCanBeMainNavData : 0));
			}
		}

		// Token: 0x1700865F RID: 34399
		// (get) Token: 0x06022FBB RID: 143291 RVA: 0x0033B86A File Offset: 0x00339A6A
		// (set) Token: 0x06022FBC RID: 143292 RVA: 0x0033B883 File Offset: 0x00339A83
		public unsafe bool bCanSpawnOnRebuild
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ANavigationData.__PropertyOffset_bCanSpawnOnRebuild) & ANavigationData.__PropertyMask_bCanSpawnOnRebuild) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ANavigationData.__PropertyOffset_bCanSpawnOnRebuild) = ((*(base.NativePtr + (IntPtr)ANavigationData.__PropertyOffset_bCanSpawnOnRebuild) & ~ANavigationData.__PropertyMask_bCanSpawnOnRebuild) | (value ? ANavigationData.__PropertyMask_bCanSpawnOnRebuild : 0));
			}
		}

		// Token: 0x17008660 RID: 34400
		// (get) Token: 0x06022FBD RID: 143293 RVA: 0x0033B8B3 File Offset: 0x00339AB3
		// (set) Token: 0x06022FBE RID: 143294 RVA: 0x0033B8CC File Offset: 0x00339ACC
		public unsafe bool bRebuildAtRuntime_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ANavigationData.__PropertyOffset_bRebuildAtRuntime_DEPRECATED) & ANavigationData.__PropertyMask_bRebuildAtRuntime_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ANavigationData.__PropertyOffset_bRebuildAtRuntime_DEPRECATED) = ((*(base.NativePtr + (IntPtr)ANavigationData.__PropertyOffset_bRebuildAtRuntime_DEPRECATED) & ~ANavigationData.__PropertyMask_bRebuildAtRuntime_DEPRECATED) | (value ? ANavigationData.__PropertyMask_bRebuildAtRuntime_DEPRECATED : 0));
			}
		}

		// Token: 0x17008661 RID: 34401
		// (get) Token: 0x06022FBF RID: 143295 RVA: 0x0033B8FC File Offset: 0x00339AFC
		// (set) Token: 0x06022FC0 RID: 143296 RVA: 0x0033B90C File Offset: 0x00339B0C
		public unsafe ERuntimeGenerationType RuntimeGeneration
		{
			get
			{
				return (ERuntimeGenerationType)(*(base.NativePtr + (IntPtr)ANavigationData.__PropertyOffset_RuntimeGeneration));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ANavigationData.__PropertyOffset_RuntimeGeneration) = (byte)value;
			}
		}

		// Token: 0x17008662 RID: 34402
		// (get) Token: 0x06022FC1 RID: 143297 RVA: 0x0033B91D File Offset: 0x00339B1D
		// (set) Token: 0x06022FC2 RID: 143298 RVA: 0x0033B92D File Offset: 0x00339B2D
		public unsafe float ObservedPathsTickInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ANavigationData.__PropertyOffset_ObservedPathsTickInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ANavigationData.__PropertyOffset_ObservedPathsTickInterval) = value;
			}
		}

		// Token: 0x17008663 RID: 34403
		// (get) Token: 0x06022FC3 RID: 143299 RVA: 0x0033B93E File Offset: 0x00339B3E
		// (set) Token: 0x06022FC4 RID: 143300 RVA: 0x0033B94E File Offset: 0x00339B4E
		public unsafe uint DataVersion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ANavigationData.__PropertyOffset_DataVersion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ANavigationData.__PropertyOffset_DataVersion) = (int)value;
			}
		}

		// Token: 0x17008664 RID: 34404
		// (get) Token: 0x06022FC5 RID: 143301 RVA: 0x0033B960 File Offset: 0x00339B60
		// (set) Token: 0x06022FC6 RID: 143302 RVA: 0x0033B999 File Offset: 0x00339B99
		public TArray<FSupportedAreaData> SupportedAreas
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSupportedAreaData> result;
				if ((result = this._SupportedAreas) == null)
				{
					result = (this._SupportedAreas = new TArray<FSupportedAreaData>(base.NativePtr + (IntPtr)ANavigationData.__PropertyOffset_SupportedAreas, this));
				}
				return result;
			}
			set
			{
				this.SupportedAreas.CopyAssign(value);
			}
		}

		// Token: 0x06022FC7 RID: 143303 RVA: 0x0033B9A7 File Offset: 0x00339BA7
		static ANavigationData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavigationData");
		}

		// Token: 0x06022FC8 RID: 143304 RVA: 0x0033B9B8 File Offset: 0x00339BB8
		protected ANavigationData() : this(BuiltinUtils.AllocNativeUObject(ANavigationData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022FC9 RID: 143305 RVA: 0x0033B9E0 File Offset: 0x00339BE0
		protected ANavigationData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012AD9 RID: 76505
		internal static int __InterfaceOffset_INavigationDataInterface;

		// Token: 0x04012ADA RID: 76506
		public new const string __ObjectPath = "/Script/NavigationSystem.NavigationData";

		// Token: 0x04012ADB RID: 76507
		private static IntPtr _ClassPtr;

		// Token: 0x04012ADC RID: 76508
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012ADD RID: 76509
		internal static int __PropertyOffset_RenderingComp;

		// Token: 0x04012ADE RID: 76510
		internal static int __PropertyOffset_NavDataConfig;

		// Token: 0x04012ADF RID: 76511
		[Nullable(2)]
		private FNavDataConfig _NavDataConfig;

		// Token: 0x04012AE0 RID: 76512
		internal static int __PropertyOffset_bEnableDrawing;

		// Token: 0x04012AE1 RID: 76513
		internal static byte __PropertyMask_bEnableDrawing;

		// Token: 0x04012AE2 RID: 76514
		internal static int __PropertyOffset_bForceRebuildOnLoad;

		// Token: 0x04012AE3 RID: 76515
		internal static byte __PropertyMask_bForceRebuildOnLoad;

		// Token: 0x04012AE4 RID: 76516
		internal static int __PropertyOffset_bAutoDestroyWhenNoNavigation;

		// Token: 0x04012AE5 RID: 76517
		internal static byte __PropertyMask_bAutoDestroyWhenNoNavigation;

		// Token: 0x04012AE6 RID: 76518
		internal static int __PropertyOffset_bCanBeMainNavData;

		// Token: 0x04012AE7 RID: 76519
		internal static byte __PropertyMask_bCanBeMainNavData;

		// Token: 0x04012AE8 RID: 76520
		internal static int __PropertyOffset_bCanSpawnOnRebuild;

		// Token: 0x04012AE9 RID: 76521
		internal static byte __PropertyMask_bCanSpawnOnRebuild;

		// Token: 0x04012AEA RID: 76522
		internal static int __PropertyOffset_bRebuildAtRuntime_DEPRECATED;

		// Token: 0x04012AEB RID: 76523
		internal static byte __PropertyMask_bRebuildAtRuntime_DEPRECATED;

		// Token: 0x04012AEC RID: 76524
		internal static int __PropertyOffset_RuntimeGeneration;

		// Token: 0x04012AED RID: 76525
		internal static int __PropertyOffset_ObservedPathsTickInterval;

		// Token: 0x04012AEE RID: 76526
		internal static int __PropertyOffset_DataVersion;

		// Token: 0x04012AEF RID: 76527
		internal static int __PropertyOffset_SupportedAreas;

		// Token: 0x04012AF0 RID: 76528
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSupportedAreaData> _SupportedAreas;
	}
}
