using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000862 RID: 2146
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.ListViewBase")]
	[UnrealStructLayout(936, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 936)]
	public abstract class UListViewBase : UWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BAB4 RID: 47796 RVA: 0x0012AEE0 File Offset: 0x001290E0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UListViewBase._ClassPtr;
		}

		// Token: 0x170022AB RID: 8875
		// (get) Token: 0x0600BAB5 RID: 47797 RVA: 0x0012AEEC File Offset: 0x001290EC
		// (set) Token: 0x0600BAB6 RID: 47798 RVA: 0x0012AF00 File Offset: 0x00129100
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UUserWidget> EntryWidgetClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UListViewBase.__PropertyOffset_EntryWidgetClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UListViewBase.__PropertyOffset_EntryWidgetClass) = value;
			}
		}

		// Token: 0x170022AC RID: 8876
		// (get) Token: 0x0600BAB7 RID: 47799 RVA: 0x0012AF15 File Offset: 0x00129115
		// (set) Token: 0x0600BAB8 RID: 47800 RVA: 0x0012AF25 File Offset: 0x00129125
		public unsafe float WheelScrollMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UListViewBase.__PropertyOffset_WheelScrollMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UListViewBase.__PropertyOffset_WheelScrollMultiplier) = value;
			}
		}

		// Token: 0x170022AD RID: 8877
		// (get) Token: 0x0600BAB9 RID: 47801 RVA: 0x0012AF36 File Offset: 0x00129136
		// (set) Token: 0x0600BABA RID: 47802 RVA: 0x0012AF46 File Offset: 0x00129146
		public unsafe bool bEnableScrollAnimation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UListViewBase.__PropertyOffset_bEnableScrollAnimation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UListViewBase.__PropertyOffset_bEnableScrollAnimation) = (value ? 1 : 0);
			}
		}

		// Token: 0x170022AE RID: 8878
		// (get) Token: 0x0600BABB RID: 47803 RVA: 0x0012AF57 File Offset: 0x00129157
		// (set) Token: 0x0600BABC RID: 47804 RVA: 0x0012AF67 File Offset: 0x00129167
		public unsafe bool bEnableFixedLineOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UListViewBase.__PropertyOffset_bEnableFixedLineOffset) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UListViewBase.__PropertyOffset_bEnableFixedLineOffset) = (value ? 1 : 0);
			}
		}

		// Token: 0x170022AF RID: 8879
		// (get) Token: 0x0600BABD RID: 47805 RVA: 0x0012AF78 File Offset: 0x00129178
		// (set) Token: 0x0600BABE RID: 47806 RVA: 0x0012AF88 File Offset: 0x00129188
		public unsafe float FixedLineScrollOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UListViewBase.__PropertyOffset_FixedLineScrollOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UListViewBase.__PropertyOffset_FixedLineScrollOffset) = value;
			}
		}

		// Token: 0x170022B0 RID: 8880
		// (get) Token: 0x0600BABF RID: 47807 RVA: 0x0012AF9C File Offset: 0x0012919C
		// (set) Token: 0x0600BAC0 RID: 47808 RVA: 0x0012AFD5 File Offset: 0x001291D5
		public FOnListEntryGeneratedDynamic BP_OnEntryGenerated
		{
			get
			{
				base.FastCheckIsValid();
				FOnListEntryGeneratedDynamic result;
				if ((result = this._BP_OnEntryGenerated) == null)
				{
					result = (this._BP_OnEntryGenerated = new FOnListEntryGeneratedDynamic(base.NativePtr + (IntPtr)UListViewBase.__PropertyOffset_BP_OnEntryGenerated, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UListViewBase.__PropertyOffset_BP_OnEntryGenerated, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170022B1 RID: 8881
		// (get) Token: 0x0600BAC1 RID: 47809 RVA: 0x0012AFF8 File Offset: 0x001291F8
		// (set) Token: 0x0600BAC2 RID: 47810 RVA: 0x0012B031 File Offset: 0x00129231
		public FOnListEntryReleasedDynamic BP_OnEntryReleased
		{
			get
			{
				base.FastCheckIsValid();
				FOnListEntryReleasedDynamic result;
				if ((result = this._BP_OnEntryReleased) == null)
				{
					result = (this._BP_OnEntryReleased = new FOnListEntryReleasedDynamic(base.NativePtr + (IntPtr)UListViewBase.__PropertyOffset_BP_OnEntryReleased, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UListViewBase.__PropertyOffset_BP_OnEntryReleased, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0600BAC3 RID: 47811 RVA: 0x0012B052 File Offset: 0x00129252
		public void SetWheelScrollMultiplier(float NewWheelScrollMultiplier)
		{
			UListViewBase.__SetWheelScrollMultiplier_Internal(base.NativePtr, NewWheelScrollMultiplier);
		}

		// Token: 0x0600BAC4 RID: 47812 RVA: 0x0012B060 File Offset: 0x00129260
		public void SetScrollOffset(float InScrollOffset)
		{
			UListViewBase.__SetScrollOffset_Internal(base.NativePtr, InScrollOffset);
		}

		// Token: 0x0600BAC5 RID: 47813 RVA: 0x0012B06E File Offset: 0x0012926E
		public void SetScrollbarVisibility(ESlateVisibility InVisibility)
		{
			UListViewBase.__SetScrollbarVisibility_Internal(base.NativePtr, InVisibility);
		}

		// Token: 0x0600BAC6 RID: 47814 RVA: 0x0012B07C File Offset: 0x0012927C
		public void ScrollToTop()
		{
			UListViewBase.__ScrollToTop_Internal(base.NativePtr);
		}

		// Token: 0x0600BAC7 RID: 47815 RVA: 0x0012B089 File Offset: 0x00129289
		public void ScrollToBottom()
		{
			UListViewBase.__ScrollToBottom_Internal(base.NativePtr);
		}

		// Token: 0x0600BAC8 RID: 47816 RVA: 0x0012B096 File Offset: 0x00129296
		public void RequestRefresh()
		{
			UListViewBase.__RequestRefresh_Internal(base.NativePtr);
		}

		// Token: 0x0600BAC9 RID: 47817 RVA: 0x0012B0A3 File Offset: 0x001292A3
		public void RegenerateAllEntries()
		{
			UListViewBase.__RegenerateAllEntries_Internal(base.NativePtr);
		}

		// Token: 0x0600BACA RID: 47818 RVA: 0x0012B0B0 File Offset: 0x001292B0
		public TArray<UUserWidget> GetDisplayedEntryWidgets()
		{
			return new TArray<UUserWidget>(UListViewBase.__GetDisplayedEntryWidgets_Internal(base.NativePtr), null);
		}

		// Token: 0x0600BACB RID: 47819
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWheelScrollMultiplier_Internal(IntPtr @this, float NewWheelScrollMultiplier);

		// Token: 0x0600BACC RID: 47820
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetScrollOffset_Internal(IntPtr @this, float InScrollOffset);

		// Token: 0x0600BACD RID: 47821
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetScrollbarVisibility_Internal(IntPtr @this, ESlateVisibility InVisibility);

		// Token: 0x0600BACE RID: 47822
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToTop_Internal(IntPtr @this);

		// Token: 0x0600BACF RID: 47823
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToBottom_Internal(IntPtr @this);

		// Token: 0x0600BAD0 RID: 47824
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RequestRefresh_Internal(IntPtr @this);

		// Token: 0x0600BAD1 RID: 47825
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegenerateAllEntries_Internal(IntPtr @this);

		// Token: 0x0600BAD2 RID: 47826
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDisplayedEntryWidgets_Internal(IntPtr @this);

		// Token: 0x0600BAD3 RID: 47827 RVA: 0x0012B0C3 File Offset: 0x001292C3
		static UListViewBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.ListViewBase");
		}

		// Token: 0x0600BAD4 RID: 47828 RVA: 0x0012B0D4 File Offset: 0x001292D4
		protected UListViewBase() : this(BuiltinUtils.AllocNativeUObject(UListViewBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BAD5 RID: 47829 RVA: 0x0012B0FC File Offset: 0x001292FC
		protected UListViewBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040054A8 RID: 21672
		public new const string __ObjectPath = "/Script/UMG.ListViewBase";

		// Token: 0x040054A9 RID: 21673
		private static IntPtr _ClassPtr;

		// Token: 0x040054AA RID: 21674
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040054AB RID: 21675
		internal static int __PropertyOffset_EntryWidgetClass;

		// Token: 0x040054AC RID: 21676
		internal static int __PropertyOffset_WheelScrollMultiplier;

		// Token: 0x040054AD RID: 21677
		internal static int __PropertyOffset_bEnableScrollAnimation;

		// Token: 0x040054AE RID: 21678
		internal static int __PropertyOffset_bEnableFixedLineOffset;

		// Token: 0x040054AF RID: 21679
		internal static int __PropertyOffset_FixedLineScrollOffset;

		// Token: 0x040054B0 RID: 21680
		internal static int __PropertyOffset_BP_OnEntryGenerated;

		// Token: 0x040054B1 RID: 21681
		[Nullable(2)]
		private FOnListEntryGeneratedDynamic _BP_OnEntryGenerated;

		// Token: 0x040054B2 RID: 21682
		internal static int __PropertyOffset_BP_OnEntryReleased;

		// Token: 0x040054B3 RID: 21683
		[Nullable(2)]
		private FOnListEntryReleasedDynamic _BP_OnEntryReleased;
	}
}
