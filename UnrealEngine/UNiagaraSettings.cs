using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025E6 RID: 9702
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraSettings")]
	[UnrealStructLayout(808, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 808)]
	public class UNiagaraSettings : UDeveloperSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060240F6 RID: 147702 RVA: 0x0035599E File Offset: 0x00353B9E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraSettings._ClassPtr;
		}

		// Token: 0x060240F7 RID: 147703 RVA: 0x003559AC File Offset: 0x00353BAC
		public UNiagaraSettings() : this(BuiltinUtils.AllocNativeUObject(UNiagaraSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060240F8 RID: 147704 RVA: 0x003559D4 File Offset: 0x00353BD4
		public UNiagaraSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008AB9 RID: 35513
		// (get) Token: 0x060240F9 RID: 147705 RVA: 0x00355A07 File Offset: 0x00353C07
		// (set) Token: 0x060240FA RID: 147706 RVA: 0x00355A17 File Offset: 0x00353C17
		public unsafe bool bExperimentalVMEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSettings.__PropertyOffset_bExperimentalVMEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSettings.__PropertyOffset_bExperimentalVMEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008ABA RID: 35514
		// (get) Token: 0x060240FB RID: 147707 RVA: 0x00355A28 File Offset: 0x00353C28
		// (set) Token: 0x060240FC RID: 147708 RVA: 0x00355A61 File Offset: 0x00353C61
		public FSoftObjectPath DefaultEffectType
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._DefaultEffectType) == null)
				{
					result = (this._DefaultEffectType = new FSoftObjectPath(base.NativePtr + (IntPtr)UNiagaraSettings.__PropertyOffset_DefaultEffectType, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraSettings.__PropertyOffset_DefaultEffectType, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008ABB RID: 35515
		// (get) Token: 0x060240FD RID: 147709 RVA: 0x00355A84 File Offset: 0x00353C84
		// (set) Token: 0x060240FE RID: 147710 RVA: 0x00355ABD File Offset: 0x00353CBD
		public TMap<EKuroNiagaraEffectTypePresets, FSoftObjectPath> EffectTypePresets
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKuroNiagaraEffectTypePresets, FSoftObjectPath> result;
				if ((result = this._EffectTypePresets) == null)
				{
					result = (this._EffectTypePresets = new TMap<EKuroNiagaraEffectTypePresets, FSoftObjectPath>(base.NativePtr + (IntPtr)UNiagaraSettings.__PropertyOffset_EffectTypePresets, this));
				}
				return result;
			}
			set
			{
				this.EffectTypePresets.CopyAssign(value);
			}
		}

		// Token: 0x17008ABC RID: 35516
		// (get) Token: 0x060240FF RID: 147711 RVA: 0x00355ACC File Offset: 0x00353CCC
		// (set) Token: 0x06024100 RID: 147712 RVA: 0x00355B05 File Offset: 0x00353D05
		public TMap<EKuroNiagaraEffectRegularType, FSoftObjectPath> EffectTypePresetsByEffectRegularType
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKuroNiagaraEffectRegularType, FSoftObjectPath> result;
				if ((result = this._EffectTypePresetsByEffectRegularType) == null)
				{
					result = (this._EffectTypePresetsByEffectRegularType = new TMap<EKuroNiagaraEffectRegularType, FSoftObjectPath>(base.NativePtr + (IntPtr)UNiagaraSettings.__PropertyOffset_EffectTypePresetsByEffectRegularType, this));
				}
				return result;
			}
			set
			{
				this.EffectTypePresetsByEffectRegularType.CopyAssign(value);
			}
		}

		// Token: 0x17008ABD RID: 35517
		// (get) Token: 0x06024101 RID: 147713 RVA: 0x00355B14 File Offset: 0x00353D14
		// (set) Token: 0x06024102 RID: 147714 RVA: 0x00355B4D File Offset: 0x00353D4D
		public TMap<EKuroNiagaraEffectRegularType, FSoftObjectPath> TickTypePresetsByEffectRegularType
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKuroNiagaraEffectRegularType, FSoftObjectPath> result;
				if ((result = this._TickTypePresetsByEffectRegularType) == null)
				{
					result = (this._TickTypePresetsByEffectRegularType = new TMap<EKuroNiagaraEffectRegularType, FSoftObjectPath>(base.NativePtr + (IntPtr)UNiagaraSettings.__PropertyOffset_TickTypePresetsByEffectRegularType, this));
				}
				return result;
			}
			set
			{
				this.TickTypePresetsByEffectRegularType.CopyAssign(value);
			}
		}

		// Token: 0x17008ABE RID: 35518
		// (get) Token: 0x06024103 RID: 147715 RVA: 0x00355B5C File Offset: 0x00353D5C
		// (set) Token: 0x06024104 RID: 147716 RVA: 0x00355B95 File Offset: 0x00353D95
		public TMap<EKuroNiagaraTickTypePresets, FSoftObjectPath> TickTypePresets
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKuroNiagaraTickTypePresets, FSoftObjectPath> result;
				if ((result = this._TickTypePresets) == null)
				{
					result = (this._TickTypePresets = new TMap<EKuroNiagaraTickTypePresets, FSoftObjectPath>(base.NativePtr + (IntPtr)UNiagaraSettings.__PropertyOffset_TickTypePresets, this));
				}
				return result;
			}
			set
			{
				this.TickTypePresets.CopyAssign(value);
			}
		}

		// Token: 0x17008ABF RID: 35519
		// (get) Token: 0x06024105 RID: 147717 RVA: 0x00355BA4 File Offset: 0x00353DA4
		// (set) Token: 0x06024106 RID: 147718 RVA: 0x00355BDD File Offset: 0x00353DDD
		public TArray<string> SubStringsForImportantNiagaraSystemNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._SubStringsForImportantNiagaraSystemNames) == null)
				{
					result = (this._SubStringsForImportantNiagaraSystemNames = new TArray<string>(base.NativePtr + (IntPtr)UNiagaraSettings.__PropertyOffset_SubStringsForImportantNiagaraSystemNames, this));
				}
				return result;
			}
			set
			{
				this.SubStringsForImportantNiagaraSystemNames.CopyAssign(value);
			}
		}

		// Token: 0x17008AC0 RID: 35520
		// (get) Token: 0x06024107 RID: 147719 RVA: 0x00355BEC File Offset: 0x00353DEC
		// (set) Token: 0x06024108 RID: 147720 RVA: 0x00355C25 File Offset: 0x00353E25
		public TArray<FText> QualityLevels
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FText> result;
				if ((result = this._QualityLevels) == null)
				{
					result = (this._QualityLevels = new TArray<FText>(base.NativePtr + (IntPtr)UNiagaraSettings.__PropertyOffset_QualityLevels, this));
				}
				return result;
			}
			set
			{
				this.QualityLevels.CopyAssign(value);
			}
		}

		// Token: 0x17008AC1 RID: 35521
		// (get) Token: 0x06024109 RID: 147721 RVA: 0x00355C34 File Offset: 0x00353E34
		// (set) Token: 0x0602410A RID: 147722 RVA: 0x00355C6D File Offset: 0x00353E6D
		public TMap<string, FText> ComponentRendererWarningsPerClass
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FText> result;
				if ((result = this._ComponentRendererWarningsPerClass) == null)
				{
					result = (this._ComponentRendererWarningsPerClass = new TMap<string, FText>(base.NativePtr + (IntPtr)UNiagaraSettings.__PropertyOffset_ComponentRendererWarningsPerClass, this));
				}
				return result;
			}
			set
			{
				this.ComponentRendererWarningsPerClass.CopyAssign(value);
			}
		}

		// Token: 0x17008AC2 RID: 35522
		// (get) Token: 0x0602410B RID: 147723 RVA: 0x00355C7B File Offset: 0x00353E7B
		// (set) Token: 0x0602410C RID: 147724 RVA: 0x00355C8F File Offset: 0x00353E8F
		[Nullable(0)]
		public unsafe TEnumAsByte<ETextureRenderTargetFormat> DefaultRenderTargetFormat
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSettings.__PropertyOffset_DefaultRenderTargetFormat);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSettings.__PropertyOffset_DefaultRenderTargetFormat) = value;
			}
		}

		// Token: 0x17008AC3 RID: 35523
		// (get) Token: 0x0602410D RID: 147725 RVA: 0x00355CA4 File Offset: 0x00353EA4
		// (set) Token: 0x0602410E RID: 147726 RVA: 0x00355CB4 File Offset: 0x00353EB4
		public unsafe ENiagaraGpuBufferFormat DefaultGridFormat
		{
			get
			{
				return (ENiagaraGpuBufferFormat)(*(base.NativePtr + (IntPtr)UNiagaraSettings.__PropertyOffset_DefaultGridFormat));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSettings.__PropertyOffset_DefaultGridFormat) = (byte)value;
			}
		}

		// Token: 0x17008AC4 RID: 35524
		// (get) Token: 0x0602410F RID: 147727 RVA: 0x00355CC5 File Offset: 0x00353EC5
		// (set) Token: 0x06024110 RID: 147728 RVA: 0x00355CD9 File Offset: 0x00353ED9
		[Nullable(2)]
		public unsafe UNiagaraEffectType DefaultEffectTypePtr
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraEffectType>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraSettings.__PropertyOffset_DefaultEffectTypePtr);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraSettings.__PropertyOffset_DefaultEffectTypePtr, value);
			}
		}

		// Token: 0x17008AC5 RID: 35525
		// (get) Token: 0x06024111 RID: 147729 RVA: 0x00355CF0 File Offset: 0x00353EF0
		// (set) Token: 0x06024112 RID: 147730 RVA: 0x00355D29 File Offset: 0x00353F29
		public TMap<EKuroNiagaraEffectRegularType, UNiagaraEffectType> EffectTypePresetsPtr
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKuroNiagaraEffectRegularType, UNiagaraEffectType> result;
				if ((result = this._EffectTypePresetsPtr) == null)
				{
					result = (this._EffectTypePresetsPtr = new TMap<EKuroNiagaraEffectRegularType, UNiagaraEffectType>(base.NativePtr + (IntPtr)UNiagaraSettings.__PropertyOffset_EffectTypePresetsPtr, this));
				}
				return result;
			}
			set
			{
				this.EffectTypePresetsPtr.CopyAssign(value);
			}
		}

		// Token: 0x17008AC6 RID: 35526
		// (get) Token: 0x06024113 RID: 147731 RVA: 0x00355D38 File Offset: 0x00353F38
		// (set) Token: 0x06024114 RID: 147732 RVA: 0x00355D71 File Offset: 0x00353F71
		public TMap<EKuroNiagaraEffectRegularType, UKuroNiagaraTickType> TickTypePresetsPtr
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKuroNiagaraEffectRegularType, UKuroNiagaraTickType> result;
				if ((result = this._TickTypePresetsPtr) == null)
				{
					result = (this._TickTypePresetsPtr = new TMap<EKuroNiagaraEffectRegularType, UKuroNiagaraTickType>(base.NativePtr + (IntPtr)UNiagaraSettings.__PropertyOffset_TickTypePresetsPtr, this));
				}
				return result;
			}
			set
			{
				this.TickTypePresetsPtr.CopyAssign(value);
			}
		}

		// Token: 0x06024115 RID: 147733 RVA: 0x00355D7F File Offset: 0x00353F7F
		static UNiagaraSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraSettings");
		}

		// Token: 0x06024116 RID: 147734 RVA: 0x00355D8D File Offset: 0x00353F8D
		protected UNiagaraSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013565 RID: 79205
		public new const string __ObjectPath = "/Script/Niagara.NiagaraSettings";

		// Token: 0x04013566 RID: 79206
		private static IntPtr _ClassPtr;

		// Token: 0x04013567 RID: 79207
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013568 RID: 79208
		internal static int __PropertyOffset_bExperimentalVMEnabled;

		// Token: 0x04013569 RID: 79209
		internal static int __PropertyOffset_DefaultEffectType;

		// Token: 0x0401356A RID: 79210
		[Nullable(2)]
		private FSoftObjectPath _DefaultEffectType;

		// Token: 0x0401356B RID: 79211
		internal static int __PropertyOffset_EffectTypePresets;

		// Token: 0x0401356C RID: 79212
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<EKuroNiagaraEffectTypePresets, FSoftObjectPath> _EffectTypePresets;

		// Token: 0x0401356D RID: 79213
		internal static int __PropertyOffset_EffectTypePresetsByEffectRegularType;

		// Token: 0x0401356E RID: 79214
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<EKuroNiagaraEffectRegularType, FSoftObjectPath> _EffectTypePresetsByEffectRegularType;

		// Token: 0x0401356F RID: 79215
		internal static int __PropertyOffset_TickTypePresetsByEffectRegularType;

		// Token: 0x04013570 RID: 79216
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<EKuroNiagaraEffectRegularType, FSoftObjectPath> _TickTypePresetsByEffectRegularType;

		// Token: 0x04013571 RID: 79217
		internal static int __PropertyOffset_TickTypePresets;

		// Token: 0x04013572 RID: 79218
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<EKuroNiagaraTickTypePresets, FSoftObjectPath> _TickTypePresets;

		// Token: 0x04013573 RID: 79219
		internal static int __PropertyOffset_SubStringsForImportantNiagaraSystemNames;

		// Token: 0x04013574 RID: 79220
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _SubStringsForImportantNiagaraSystemNames;

		// Token: 0x04013575 RID: 79221
		internal static int __PropertyOffset_QualityLevels;

		// Token: 0x04013576 RID: 79222
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FText> _QualityLevels;

		// Token: 0x04013577 RID: 79223
		internal static int __PropertyOffset_ComponentRendererWarningsPerClass;

		// Token: 0x04013578 RID: 79224
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, FText> _ComponentRendererWarningsPerClass;

		// Token: 0x04013579 RID: 79225
		internal static int __PropertyOffset_DefaultRenderTargetFormat;

		// Token: 0x0401357A RID: 79226
		internal static int __PropertyOffset_DefaultGridFormat;

		// Token: 0x0401357B RID: 79227
		internal static int __PropertyOffset_DefaultEffectTypePtr;

		// Token: 0x0401357C RID: 79228
		internal static int __PropertyOffset_EffectTypePresetsPtr;

		// Token: 0x0401357D RID: 79229
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<EKuroNiagaraEffectRegularType, UNiagaraEffectType> _EffectTypePresetsPtr;

		// Token: 0x0401357E RID: 79230
		internal static int __PropertyOffset_TickTypePresetsPtr;

		// Token: 0x0401357F RID: 79231
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<EKuroNiagaraEffectRegularType, UKuroNiagaraTickType> _TickTypePresetsPtr;
	}
}
