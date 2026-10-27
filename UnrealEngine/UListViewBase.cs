using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002980 RID: 10624
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.ListViewBase")]
	[UnrealStructLayout(936, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 936)]
	public abstract class UListViewBase : UWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602751E RID: 161054 RVA: 0x003BF29F File Offset: 0x003BD49F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UListViewBase._ClassPtr;
		}

		// Token: 0x17009723 RID: 38691
		// (get) Token: 0x0602751F RID: 161055 RVA: 0x003BF2AB File Offset: 0x003BD4AB
		// (set) Token: 0x06027520 RID: 161056 RVA: 0x003BF2BF File Offset: 0x003BD4BF
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

		// Token: 0x17009724 RID: 38692
		// (get) Token: 0x06027521 RID: 161057 RVA: 0x003BF2D4 File Offset: 0x003BD4D4
		// (set) Token: 0x06027522 RID: 161058 RVA: 0x003BF2E4 File Offset: 0x003BD4E4
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

		// Token: 0x17009725 RID: 38693
		// (get) Token: 0x06027523 RID: 161059 RVA: 0x003BF2F5 File Offset: 0x003BD4F5
		// (set) Token: 0x06027524 RID: 161060 RVA: 0x003BF305 File Offset: 0x003BD505
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

		// Token: 0x17009726 RID: 38694
		// (get) Token: 0x06027525 RID: 161061 RVA: 0x003BF316 File Offset: 0x003BD516
		// (set) Token: 0x06027526 RID: 161062 RVA: 0x003BF326 File Offset: 0x003BD526
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

		// Token: 0x17009727 RID: 38695
		// (get) Token: 0x06027527 RID: 161063 RVA: 0x003BF337 File Offset: 0x003BD537
		// (set) Token: 0x06027528 RID: 161064 RVA: 0x003BF347 File Offset: 0x003BD547
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

		// Token: 0x17009728 RID: 38696
		// (get) Token: 0x06027529 RID: 161065 RVA: 0x003BF358 File Offset: 0x003BD558
		// (set) Token: 0x0602752A RID: 161066 RVA: 0x003BF391 File Offset: 0x003BD591
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

		// Token: 0x17009729 RID: 38697
		// (get) Token: 0x0602752B RID: 161067 RVA: 0x003BF3B4 File Offset: 0x003BD5B4
		// (set) Token: 0x0602752C RID: 161068 RVA: 0x003BF3ED File Offset: 0x003BD5ED
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

		// Token: 0x1700972A RID: 38698
		// (get) Token: 0x0602752D RID: 161069 RVA: 0x003BF410 File Offset: 0x003BD610
		// (set) Token: 0x0602752E RID: 161070 RVA: 0x003BF449 File Offset: 0x003BD649
		public FUserWidgetPool EntryWidgetPool
		{
			get
			{
				base.FastCheckIsValid();
				FUserWidgetPool result;
				if ((result = this._EntryWidgetPool) == null)
				{
					result = (this._EntryWidgetPool = new FUserWidgetPool(base.NativePtr + (IntPtr)UListViewBase.__PropertyOffset_EntryWidgetPool, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FUserWidgetPool.StaticStruct(), base.NativePtr + (IntPtr)UListViewBase.__PropertyOffset_EntryWidgetPool, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602752F RID: 161071 RVA: 0x003BF46A File Offset: 0x003BD66A
		public void SetWheelScrollMultiplier(float NewWheelScrollMultiplier)
		{
			UListViewBase.__SetWheelScrollMultiplier_Internal(base.NativePtr, NewWheelScrollMultiplier);
		}

		// Token: 0x06027530 RID: 161072 RVA: 0x003BF478 File Offset: 0x003BD678
		public void SetScrollOffset(float InScrollOffset)
		{
			UListViewBase.__SetScrollOffset_Internal(base.NativePtr, InScrollOffset);
		}

		// Token: 0x06027531 RID: 161073 RVA: 0x003BF486 File Offset: 0x003BD686
		public void SetScrollbarVisibility(ESlateVisibility InVisibility)
		{
			UListViewBase.__SetScrollbarVisibility_Internal(base.NativePtr, InVisibility);
		}

		// Token: 0x06027532 RID: 161074 RVA: 0x003BF494 File Offset: 0x003BD694
		public void ScrollToTop()
		{
			UListViewBase.__ScrollToTop_Internal(base.NativePtr);
		}

		// Token: 0x06027533 RID: 161075 RVA: 0x003BF4A1 File Offset: 0x003BD6A1
		public void ScrollToBottom()
		{
			UListViewBase.__ScrollToBottom_Internal(base.NativePtr);
		}

		// Token: 0x06027534 RID: 161076 RVA: 0x003BF4AE File Offset: 0x003BD6AE
		public void RequestRefresh()
		{
			UListViewBase.__RequestRefresh_Internal(base.NativePtr);
		}

		// Token: 0x06027535 RID: 161077 RVA: 0x003BF4BB File Offset: 0x003BD6BB
		public void RegenerateAllEntries()
		{
			UListViewBase.__RegenerateAllEntries_Internal(base.NativePtr);
		}

		// Token: 0x06027536 RID: 161078 RVA: 0x003BF4C8 File Offset: 0x003BD6C8
		public TArray<UUserWidget> GetDisplayedEntryWidgets()
		{
			return new TArray<UUserWidget>(UListViewBase.__GetDisplayedEntryWidgets_Internal(base.NativePtr), null);
		}

		// Token: 0x06027537 RID: 161079
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWheelScrollMultiplier_Internal(IntPtr @this, float NewWheelScrollMultiplier);

		// Token: 0x06027538 RID: 161080
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetScrollOffset_Internal(IntPtr @this, float InScrollOffset);

		// Token: 0x06027539 RID: 161081
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetScrollbarVisibility_Internal(IntPtr @this, ESlateVisibility InVisibility);

		// Token: 0x0602753A RID: 161082
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToTop_Internal(IntPtr @this);

		// Token: 0x0602753B RID: 161083
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToBottom_Internal(IntPtr @this);

		// Token: 0x0602753C RID: 161084
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RequestRefresh_Internal(IntPtr @this);

		// Token: 0x0602753D RID: 161085
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegenerateAllEntries_Internal(IntPtr @this);

		// Token: 0x0602753E RID: 161086
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDisplayedEntryWidgets_Internal(IntPtr @this);

		// Token: 0x0602753F RID: 161087 RVA: 0x003BF4DB File Offset: 0x003BD6DB
		static UListViewBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.ListViewBase");
		}

		// Token: 0x06027540 RID: 161088 RVA: 0x003BF4EC File Offset: 0x003BD6EC
		protected UListViewBase() : this(BuiltinUtils.AllocNativeUObject(UListViewBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027541 RID: 161089 RVA: 0x003BF514 File Offset: 0x003BD714
		protected UListViewBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401597A RID: 88442
		public new const string __ObjectPath = "/Script/UMG.ListViewBase";

		// Token: 0x0401597B RID: 88443
		private static IntPtr _ClassPtr;

		// Token: 0x0401597C RID: 88444
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401597D RID: 88445
		internal static int __PropertyOffset_EntryWidgetClass;

		// Token: 0x0401597E RID: 88446
		internal static int __PropertyOffset_WheelScrollMultiplier;

		// Token: 0x0401597F RID: 88447
		internal static int __PropertyOffset_bEnableScrollAnimation;

		// Token: 0x04015980 RID: 88448
		internal static int __PropertyOffset_bEnableFixedLineOffset;

		// Token: 0x04015981 RID: 88449
		internal static int __PropertyOffset_FixedLineScrollOffset;

		// Token: 0x04015982 RID: 88450
		internal static int __PropertyOffset_BP_OnEntryGenerated;

		// Token: 0x04015983 RID: 88451
		[Nullable(2)]
		private FOnListEntryGeneratedDynamic _BP_OnEntryGenerated;

		// Token: 0x04015984 RID: 88452
		internal static int __PropertyOffset_BP_OnEntryReleased;

		// Token: 0x04015985 RID: 88453
		[Nullable(2)]
		private FOnListEntryReleasedDynamic _BP_OnEntryReleased;

		// Token: 0x04015986 RID: 88454
		internal static int __PropertyOffset_EntryWidgetPool;

		// Token: 0x04015987 RID: 88455
		[Nullable(2)]
		private FUserWidgetPool _EntryWidgetPool;
	}
}
