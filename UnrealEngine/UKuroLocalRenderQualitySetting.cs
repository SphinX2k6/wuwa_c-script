using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B36 RID: 6966
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroLocalRenderQualitySetting")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UKuroLocalRenderQualitySetting : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601A4EA RID: 107754 RVA: 0x0026CFA0 File Offset: 0x0026B1A0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroLocalRenderQualitySetting._ClassPtr;
		}

		// Token: 0x0601A4EB RID: 107755 RVA: 0x0026CFAC File Offset: 0x0026B1AC
		public UKuroLocalRenderQualitySetting() : this(BuiltinUtils.AllocNativeUObject(UKuroLocalRenderQualitySetting.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601A4EC RID: 107756 RVA: 0x0026CFD4 File Offset: 0x0026B1D4
		public UKuroLocalRenderQualitySetting(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroLocalRenderQualitySetting.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170069D2 RID: 27090
		// (get) Token: 0x0601A4ED RID: 107757 RVA: 0x0026D007 File Offset: 0x0026B207
		// (set) Token: 0x0601A4EE RID: 107758 RVA: 0x0026D017 File Offset: 0x0026B217
		public unsafe int LocalRenderSettingIndexPC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLocalRenderQualitySetting.__PropertyOffset_LocalRenderSettingIndexPC);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLocalRenderQualitySetting.__PropertyOffset_LocalRenderSettingIndexPC) = value;
			}
		}

		// Token: 0x170069D3 RID: 27091
		// (get) Token: 0x0601A4EF RID: 107759 RVA: 0x0026D028 File Offset: 0x0026B228
		// (set) Token: 0x0601A4F0 RID: 107760 RVA: 0x0026D038 File Offset: 0x0026B238
		public unsafe int LowMemoryLocalRenderSettingIndexPC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLocalRenderQualitySetting.__PropertyOffset_LowMemoryLocalRenderSettingIndexPC);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLocalRenderQualitySetting.__PropertyOffset_LowMemoryLocalRenderSettingIndexPC) = value;
			}
		}

		// Token: 0x170069D4 RID: 27092
		// (get) Token: 0x0601A4F1 RID: 107761 RVA: 0x0026D049 File Offset: 0x0026B249
		// (set) Token: 0x0601A4F2 RID: 107762 RVA: 0x0026D059 File Offset: 0x0026B259
		public unsafe int LocalRenderSettingIndexMobile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLocalRenderQualitySetting.__PropertyOffset_LocalRenderSettingIndexMobile);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLocalRenderQualitySetting.__PropertyOffset_LocalRenderSettingIndexMobile) = value;
			}
		}

		// Token: 0x170069D5 RID: 27093
		// (get) Token: 0x0601A4F3 RID: 107763 RVA: 0x0026D06A File Offset: 0x0026B26A
		// (set) Token: 0x0601A4F4 RID: 107764 RVA: 0x0026D07A File Offset: 0x0026B27A
		public unsafe int LowMemoryLocalRenderSettingIndexMobile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLocalRenderQualitySetting.__PropertyOffset_LowMemoryLocalRenderSettingIndexMobile);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLocalRenderQualitySetting.__PropertyOffset_LowMemoryLocalRenderSettingIndexMobile) = value;
			}
		}

		// Token: 0x170069D6 RID: 27094
		// (get) Token: 0x0601A4F5 RID: 107765 RVA: 0x0026D08B File Offset: 0x0026B28B
		// (set) Token: 0x0601A4F6 RID: 107766 RVA: 0x0026D09B File Offset: 0x0026B29B
		public unsafe int LocalRenderSettingIndexPS5
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLocalRenderQualitySetting.__PropertyOffset_LocalRenderSettingIndexPS5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLocalRenderQualitySetting.__PropertyOffset_LocalRenderSettingIndexPS5) = value;
			}
		}

		// Token: 0x170069D7 RID: 27095
		// (get) Token: 0x0601A4F7 RID: 107767 RVA: 0x0026D0AC File Offset: 0x0026B2AC
		// (set) Token: 0x0601A4F8 RID: 107768 RVA: 0x0026D0C0 File Offset: 0x0026B2C0
		public unsafe string CmdPresetVersion
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKuroLocalRenderQualitySetting.__PropertyOffset_CmdPresetVersion)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKuroLocalRenderQualitySetting.__PropertyOffset_CmdPresetVersion)), value);
			}
		}

		// Token: 0x170069D8 RID: 27096
		// (get) Token: 0x0601A4F9 RID: 107769 RVA: 0x0026D0D5 File Offset: 0x0026B2D5
		// (set) Token: 0x0601A4FA RID: 107770 RVA: 0x0026D0E9 File Offset: 0x0026B2E9
		public unsafe string CmdPresetLocation
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKuroLocalRenderQualitySetting.__PropertyOffset_CmdPresetLocation)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKuroLocalRenderQualitySetting.__PropertyOffset_CmdPresetLocation)), value);
			}
		}

		// Token: 0x170069D9 RID: 27097
		// (get) Token: 0x0601A4FB RID: 107771 RVA: 0x0026D0FE File Offset: 0x0026B2FE
		// (set) Token: 0x0601A4FC RID: 107772 RVA: 0x0026D112 File Offset: 0x0026B312
		public unsafe string UsedCmdPresetName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKuroLocalRenderQualitySetting.__PropertyOffset_UsedCmdPresetName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKuroLocalRenderQualitySetting.__PropertyOffset_UsedCmdPresetName)), value);
			}
		}

		// Token: 0x170069DA RID: 27098
		// (get) Token: 0x0601A4FD RID: 107773 RVA: 0x0026D128 File Offset: 0x0026B328
		// (set) Token: 0x0601A4FE RID: 107774 RVA: 0x0026D161 File Offset: 0x0026B361
		public TArray<FConditionalCMD> BoundLocalCmd
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FConditionalCMD> result;
				if ((result = this._BoundLocalCmd) == null)
				{
					result = (this._BoundLocalCmd = new TArray<FConditionalCMD>(base.NativePtr + (IntPtr)UKuroLocalRenderQualitySetting.__PropertyOffset_BoundLocalCmd, this));
				}
				return result;
			}
			set
			{
				this.BoundLocalCmd.CopyAssign(value);
			}
		}

		// Token: 0x0601A4FF RID: 107775 RVA: 0x0026D16F File Offset: 0x0026B36F
		static UKuroLocalRenderQualitySetting()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroLocalRenderQualitySetting");
		}

		// Token: 0x0601A500 RID: 107776 RVA: 0x0026D17D File Offset: 0x0026B37D
		protected UKuroLocalRenderQualitySetting(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E463 RID: 58467
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroLocalRenderQualitySetting";

		// Token: 0x0400E464 RID: 58468
		private static IntPtr _ClassPtr;

		// Token: 0x0400E465 RID: 58469
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E466 RID: 58470
		internal static int __PropertyOffset_LocalRenderSettingIndexPC;

		// Token: 0x0400E467 RID: 58471
		internal static int __PropertyOffset_LowMemoryLocalRenderSettingIndexPC;

		// Token: 0x0400E468 RID: 58472
		internal static int __PropertyOffset_LocalRenderSettingIndexMobile;

		// Token: 0x0400E469 RID: 58473
		internal static int __PropertyOffset_LowMemoryLocalRenderSettingIndexMobile;

		// Token: 0x0400E46A RID: 58474
		internal static int __PropertyOffset_LocalRenderSettingIndexPS5;

		// Token: 0x0400E46B RID: 58475
		internal static int __PropertyOffset_CmdPresetVersion;

		// Token: 0x0400E46C RID: 58476
		internal static int __PropertyOffset_CmdPresetLocation;

		// Token: 0x0400E46D RID: 58477
		internal static int __PropertyOffset_UsedCmdPresetName;

		// Token: 0x0400E46E RID: 58478
		internal static int __PropertyOffset_BoundLocalCmd;

		// Token: 0x0400E46F RID: 58479
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FConditionalCMD> _BoundLocalCmd;
	}
}
