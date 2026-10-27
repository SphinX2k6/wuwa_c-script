using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002950 RID: 10576
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.DynamicEntryBoxBase")]
	[UnrealStructLayout(864, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 864)]
	public abstract class UDynamicEntryBoxBase : UWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027295 RID: 160405 RVA: 0x003BB4D8 File Offset: 0x003B96D8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDynamicEntryBoxBase._ClassPtr;
		}

		// Token: 0x1700969D RID: 38557
		// (get) Token: 0x06027296 RID: 160406 RVA: 0x003BB4E4 File Offset: 0x003B96E4
		// (set) Token: 0x06027297 RID: 160407 RVA: 0x003BB4F4 File Offset: 0x003B96F4
		public unsafe EDynamicBoxType EntryBoxType
		{
			get
			{
				return (EDynamicBoxType)(*(base.NativePtr + (IntPtr)UDynamicEntryBoxBase.__PropertyOffset_EntryBoxType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDynamicEntryBoxBase.__PropertyOffset_EntryBoxType) = (byte)value;
			}
		}

		// Token: 0x1700969E RID: 38558
		// (get) Token: 0x06027298 RID: 160408 RVA: 0x003BB505 File Offset: 0x003B9705
		// (set) Token: 0x06027299 RID: 160409 RVA: 0x003BB519 File Offset: 0x003B9719
		public unsafe FVector2D EntrySpacing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDynamicEntryBoxBase.__PropertyOffset_EntrySpacing);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDynamicEntryBoxBase.__PropertyOffset_EntrySpacing) = value;
			}
		}

		// Token: 0x1700969F RID: 38559
		// (get) Token: 0x0602729A RID: 160410 RVA: 0x003BB530 File Offset: 0x003B9730
		// (set) Token: 0x0602729B RID: 160411 RVA: 0x003BB569 File Offset: 0x003B9769
		public TArray<FVector2D> SpacingPattern
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector2D> result;
				if ((result = this._SpacingPattern) == null)
				{
					result = (this._SpacingPattern = new TArray<FVector2D>(base.NativePtr + (IntPtr)UDynamicEntryBoxBase.__PropertyOffset_SpacingPattern, this));
				}
				return result;
			}
			set
			{
				this.SpacingPattern.CopyAssign(value);
			}
		}

		// Token: 0x170096A0 RID: 38560
		// (get) Token: 0x0602729C RID: 160412 RVA: 0x003BB578 File Offset: 0x003B9778
		// (set) Token: 0x0602729D RID: 160413 RVA: 0x003BB5B1 File Offset: 0x003B97B1
		public FSlateChildSize EntrySizeRule
		{
			get
			{
				base.FastCheckIsValid();
				FSlateChildSize result;
				if ((result = this._EntrySizeRule) == null)
				{
					result = (this._EntrySizeRule = new FSlateChildSize(base.NativePtr + (IntPtr)UDynamicEntryBoxBase.__PropertyOffset_EntrySizeRule, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateChildSize.StaticStruct(), base.NativePtr + (IntPtr)UDynamicEntryBoxBase.__PropertyOffset_EntrySizeRule, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170096A1 RID: 38561
		// (get) Token: 0x0602729E RID: 160414 RVA: 0x003BB5D2 File Offset: 0x003B97D2
		// (set) Token: 0x0602729F RID: 160415 RVA: 0x003BB5E6 File Offset: 0x003B97E6
		[Nullable(0)]
		public unsafe TEnumAsByte<EHorizontalAlignment> EntryHorizontalAlignment
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UDynamicEntryBoxBase.__PropertyOffset_EntryHorizontalAlignment);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UDynamicEntryBoxBase.__PropertyOffset_EntryHorizontalAlignment) = value;
			}
		}

		// Token: 0x170096A2 RID: 38562
		// (get) Token: 0x060272A0 RID: 160416 RVA: 0x003BB5FB File Offset: 0x003B97FB
		// (set) Token: 0x060272A1 RID: 160417 RVA: 0x003BB60F File Offset: 0x003B980F
		[Nullable(0)]
		public unsafe TEnumAsByte<EVerticalAlignment> EntryVerticalAlignment
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UDynamicEntryBoxBase.__PropertyOffset_EntryVerticalAlignment);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UDynamicEntryBoxBase.__PropertyOffset_EntryVerticalAlignment) = value;
			}
		}

		// Token: 0x170096A3 RID: 38563
		// (get) Token: 0x060272A2 RID: 160418 RVA: 0x003BB624 File Offset: 0x003B9824
		// (set) Token: 0x060272A3 RID: 160419 RVA: 0x003BB634 File Offset: 0x003B9834
		public unsafe int MaxElementSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDynamicEntryBoxBase.__PropertyOffset_MaxElementSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDynamicEntryBoxBase.__PropertyOffset_MaxElementSize) = value;
			}
		}

		// Token: 0x170096A4 RID: 38564
		// (get) Token: 0x060272A4 RID: 160420 RVA: 0x003BB648 File Offset: 0x003B9848
		// (set) Token: 0x060272A5 RID: 160421 RVA: 0x003BB681 File Offset: 0x003B9881
		public FRadialBoxSettings RadialBoxSettings
		{
			get
			{
				base.FastCheckIsValid();
				FRadialBoxSettings result;
				if ((result = this._RadialBoxSettings) == null)
				{
					result = (this._RadialBoxSettings = new FRadialBoxSettings(base.NativePtr + (IntPtr)UDynamicEntryBoxBase.__PropertyOffset_RadialBoxSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRadialBoxSettings.StaticStruct(), base.NativePtr + (IntPtr)UDynamicEntryBoxBase.__PropertyOffset_RadialBoxSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170096A5 RID: 38565
		// (get) Token: 0x060272A6 RID: 160422 RVA: 0x003BB6A4 File Offset: 0x003B98A4
		// (set) Token: 0x060272A7 RID: 160423 RVA: 0x003BB6DD File Offset: 0x003B98DD
		public FUserWidgetPool EntryWidgetPool
		{
			get
			{
				base.FastCheckIsValid();
				FUserWidgetPool result;
				if ((result = this._EntryWidgetPool) == null)
				{
					result = (this._EntryWidgetPool = new FUserWidgetPool(base.NativePtr + (IntPtr)UDynamicEntryBoxBase.__PropertyOffset_EntryWidgetPool, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FUserWidgetPool.StaticStruct(), base.NativePtr + (IntPtr)UDynamicEntryBoxBase.__PropertyOffset_EntryWidgetPool, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060272A8 RID: 160424 RVA: 0x003BB6FE File Offset: 0x003B98FE
		[NullableContext(2)]
		public void SetRadialSettings(in FRadialBoxSettings InSettings)
		{
			UDynamicEntryBoxBase.__SetRadialSettings_Internal(base.NativePtr, (InSettings ?? new FRadialBoxSettings()).NativePtr);
		}

		// Token: 0x060272A9 RID: 160425 RVA: 0x003BB71B File Offset: 0x003B991B
		public void SetEntrySpacing(in FVector2D InEntrySpacing)
		{
			UDynamicEntryBoxBase.__SetEntrySpacing_Internal(base.NativePtr, InEntrySpacing);
		}

		// Token: 0x060272AA RID: 160426 RVA: 0x003BB729 File Offset: 0x003B9929
		public int GetNumEntries()
		{
			return UDynamicEntryBoxBase.__GetNumEntries_Internal(base.NativePtr);
		}

		// Token: 0x060272AB RID: 160427 RVA: 0x003BB736 File Offset: 0x003B9936
		public TArray<UUserWidget> GetAllEntries()
		{
			return new TArray<UUserWidget>(UDynamicEntryBoxBase.__GetAllEntries_Internal(base.NativePtr), null);
		}

		// Token: 0x060272AC RID: 160428
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRadialSettings_Internal(IntPtr @this, IntPtr InSettings);

		// Token: 0x060272AD RID: 160429
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEntrySpacing_Internal(IntPtr @this, in FVector2D InEntrySpacing);

		// Token: 0x060272AE RID: 160430
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumEntries_Internal(IntPtr @this);

		// Token: 0x060272AF RID: 160431
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAllEntries_Internal(IntPtr @this);

		// Token: 0x060272B0 RID: 160432 RVA: 0x003BB749 File Offset: 0x003B9949
		static UDynamicEntryBoxBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.DynamicEntryBoxBase");
		}

		// Token: 0x060272B1 RID: 160433 RVA: 0x003BB758 File Offset: 0x003B9958
		protected UDynamicEntryBoxBase() : this(BuiltinUtils.AllocNativeUObject(UDynamicEntryBoxBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060272B2 RID: 160434 RVA: 0x003BB780 File Offset: 0x003B9980
		protected UDynamicEntryBoxBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015807 RID: 88071
		public new const string __ObjectPath = "/Script/UMG.DynamicEntryBoxBase";

		// Token: 0x04015808 RID: 88072
		private static IntPtr _ClassPtr;

		// Token: 0x04015809 RID: 88073
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401580A RID: 88074
		internal static int __PropertyOffset_EntryBoxType;

		// Token: 0x0401580B RID: 88075
		internal static int __PropertyOffset_EntrySpacing;

		// Token: 0x0401580C RID: 88076
		internal static int __PropertyOffset_SpacingPattern;

		// Token: 0x0401580D RID: 88077
		[Nullable(2)]
		private TArray<FVector2D> _SpacingPattern;

		// Token: 0x0401580E RID: 88078
		internal static int __PropertyOffset_EntrySizeRule;

		// Token: 0x0401580F RID: 88079
		[Nullable(2)]
		private FSlateChildSize _EntrySizeRule;

		// Token: 0x04015810 RID: 88080
		internal static int __PropertyOffset_EntryHorizontalAlignment;

		// Token: 0x04015811 RID: 88081
		internal static int __PropertyOffset_EntryVerticalAlignment;

		// Token: 0x04015812 RID: 88082
		internal static int __PropertyOffset_MaxElementSize;

		// Token: 0x04015813 RID: 88083
		internal static int __PropertyOffset_RadialBoxSettings;

		// Token: 0x04015814 RID: 88084
		[Nullable(2)]
		private FRadialBoxSettings _RadialBoxSettings;

		// Token: 0x04015815 RID: 88085
		internal static int __PropertyOffset_EntryWidgetPool;

		// Token: 0x04015816 RID: 88086
		[Nullable(2)]
		private FUserWidgetPool _EntryWidgetPool;
	}
}
