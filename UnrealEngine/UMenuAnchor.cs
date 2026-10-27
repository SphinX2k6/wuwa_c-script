using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002982 RID: 10626
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.MenuAnchor")]
	[UnrealStructLayout(808, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 808)]
	public class UMenuAnchor : UContentWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027547 RID: 161095 RVA: 0x003BF59E File Offset: 0x003BD79E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMenuAnchor._ClassPtr;
		}

		// Token: 0x06027548 RID: 161096 RVA: 0x003BF5AC File Offset: 0x003BD7AC
		public UMenuAnchor() : this(BuiltinUtils.AllocNativeUObject(UMenuAnchor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027549 RID: 161097 RVA: 0x003BF5D4 File Offset: 0x003BD7D4
		public UMenuAnchor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMenuAnchor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700972B RID: 38699
		// (get) Token: 0x0602754A RID: 161098 RVA: 0x003BF607 File Offset: 0x003BD807
		// (set) Token: 0x0602754B RID: 161099 RVA: 0x003BF61B File Offset: 0x003BD81B
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UUserWidget> MenuClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UMenuAnchor.__PropertyOffset_MenuClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UMenuAnchor.__PropertyOffset_MenuClass) = value;
			}
		}

		// Token: 0x1700972C RID: 38700
		// (get) Token: 0x0602754C RID: 161100 RVA: 0x003BF630 File Offset: 0x003BD830
		// (set) Token: 0x0602754D RID: 161101 RVA: 0x003BF669 File Offset: 0x003BD869
		public FGetWidget OnGetMenuContentEvent
		{
			get
			{
				base.FastCheckIsValid();
				FGetWidget result;
				if ((result = this._OnGetMenuContentEvent) == null)
				{
					result = (this._OnGetMenuContentEvent = new FGetWidget(base.NativePtr + (IntPtr)UMenuAnchor.__PropertyOffset_OnGetMenuContentEvent, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMenuAnchor.__PropertyOffset_OnGetMenuContentEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700972D RID: 38701
		// (get) Token: 0x0602754E RID: 161102 RVA: 0x003BF68C File Offset: 0x003BD88C
		// (set) Token: 0x0602754F RID: 161103 RVA: 0x003BF6C5 File Offset: 0x003BD8C5
		public FGetUserWidget OnGetUserMenuContentEvent
		{
			get
			{
				base.FastCheckIsValid();
				FGetUserWidget result;
				if ((result = this._OnGetUserMenuContentEvent) == null)
				{
					result = (this._OnGetUserMenuContentEvent = new FGetUserWidget(base.NativePtr + (IntPtr)UMenuAnchor.__PropertyOffset_OnGetUserMenuContentEvent, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMenuAnchor.__PropertyOffset_OnGetUserMenuContentEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700972E RID: 38702
		// (get) Token: 0x06027550 RID: 161104 RVA: 0x003BF6E6 File Offset: 0x003BD8E6
		// (set) Token: 0x06027551 RID: 161105 RVA: 0x003BF6FA File Offset: 0x003BD8FA
		[Nullable(0)]
		public unsafe TEnumAsByte<EMenuPlacement> Placement
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UMenuAnchor.__PropertyOffset_Placement);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UMenuAnchor.__PropertyOffset_Placement) = value;
			}
		}

		// Token: 0x1700972F RID: 38703
		// (get) Token: 0x06027552 RID: 161106 RVA: 0x003BF70F File Offset: 0x003BD90F
		// (set) Token: 0x06027553 RID: 161107 RVA: 0x003BF71F File Offset: 0x003BD91F
		public unsafe bool bFitInWindow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMenuAnchor.__PropertyOffset_bFitInWindow) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMenuAnchor.__PropertyOffset_bFitInWindow) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009730 RID: 38704
		// (get) Token: 0x06027554 RID: 161108 RVA: 0x003BF730 File Offset: 0x003BD930
		// (set) Token: 0x06027555 RID: 161109 RVA: 0x003BF740 File Offset: 0x003BD940
		public unsafe bool ShouldDeferPaintingAfterWindowContent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMenuAnchor.__PropertyOffset_ShouldDeferPaintingAfterWindowContent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMenuAnchor.__PropertyOffset_ShouldDeferPaintingAfterWindowContent) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009731 RID: 38705
		// (get) Token: 0x06027556 RID: 161110 RVA: 0x003BF751 File Offset: 0x003BD951
		// (set) Token: 0x06027557 RID: 161111 RVA: 0x003BF761 File Offset: 0x003BD961
		public unsafe bool UseApplicationMenuStack
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMenuAnchor.__PropertyOffset_UseApplicationMenuStack) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMenuAnchor.__PropertyOffset_UseApplicationMenuStack) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009732 RID: 38706
		// (get) Token: 0x06027558 RID: 161112 RVA: 0x003BF774 File Offset: 0x003BD974
		// (set) Token: 0x06027559 RID: 161113 RVA: 0x003BF7AD File Offset: 0x003BD9AD
		public FOnMenuOpenChangedEvent OnMenuOpenChanged
		{
			get
			{
				base.FastCheckIsValid();
				FOnMenuOpenChangedEvent result;
				if ((result = this._OnMenuOpenChanged) == null)
				{
					result = (this._OnMenuOpenChanged = new FOnMenuOpenChangedEvent(base.NativePtr + (IntPtr)UMenuAnchor.__PropertyOffset_OnMenuOpenChanged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMenuAnchor.__PropertyOffset_OnMenuOpenChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0602755A RID: 161114 RVA: 0x003BF7CE File Offset: 0x003BD9CE
		public void ToggleOpen(bool bFocusOnOpen)
		{
			UMenuAnchor.__ToggleOpen_Internal(base.NativePtr, bFocusOnOpen);
		}

		// Token: 0x0602755B RID: 161115 RVA: 0x003BF7DC File Offset: 0x003BD9DC
		public bool ShouldOpenDueToClick()
		{
			return UMenuAnchor.__ShouldOpenDueToClick_Internal(base.NativePtr);
		}

		// Token: 0x0602755C RID: 161116 RVA: 0x003BF7E9 File Offset: 0x003BD9E9
		public void SetPlacement(EMenuPlacement InPlacement)
		{
			UMenuAnchor.__SetPlacement_Internal(base.NativePtr, InPlacement);
		}

		// Token: 0x0602755D RID: 161117 RVA: 0x003BF7FC File Offset: 0x003BD9FC
		public void Open(bool bFocusMenu)
		{
			UMenuAnchor.__Open_Internal(base.NativePtr, bFocusMenu);
		}

		// Token: 0x0602755E RID: 161118 RVA: 0x003BF80A File Offset: 0x003BDA0A
		public bool IsOpen()
		{
			return UMenuAnchor.__IsOpen_Internal(base.NativePtr);
		}

		// Token: 0x0602755F RID: 161119 RVA: 0x003BF817 File Offset: 0x003BDA17
		public bool HasOpenSubMenus()
		{
			return UMenuAnchor.__HasOpenSubMenus_Internal(base.NativePtr);
		}

		// Token: 0x06027560 RID: 161120 RVA: 0x003BF824 File Offset: 0x003BDA24
		public FVector2D GetMenuPosition()
		{
			return UMenuAnchor.__GetMenuPosition_Internal(base.NativePtr);
		}

		// Token: 0x06027561 RID: 161121 RVA: 0x003BF831 File Offset: 0x003BDA31
		public void FitInWindow(bool bFit)
		{
			UMenuAnchor.__FitInWindow_Internal(base.NativePtr, bFit);
		}

		// Token: 0x06027562 RID: 161122 RVA: 0x003BF83F File Offset: 0x003BDA3F
		public void Close()
		{
			UMenuAnchor.__Close_Internal(base.NativePtr);
		}

		// Token: 0x06027563 RID: 161123
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ToggleOpen_Internal(IntPtr @this, bool bFocusOnOpen);

		// Token: 0x06027564 RID: 161124
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ShouldOpenDueToClick_Internal(IntPtr @this);

		// Token: 0x06027565 RID: 161125
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPlacement_Internal(IntPtr @this, TEnumAsByte<EMenuPlacement> InPlacement);

		// Token: 0x06027566 RID: 161126
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Open_Internal(IntPtr @this, bool bFocusMenu);

		// Token: 0x06027567 RID: 161127
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsOpen_Internal(IntPtr @this);

		// Token: 0x06027568 RID: 161128
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasOpenSubMenus_Internal(IntPtr @this);

		// Token: 0x06027569 RID: 161129
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetMenuPosition_Internal(IntPtr @this);

		// Token: 0x0602756A RID: 161130
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FitInWindow_Internal(IntPtr @this, bool bFit);

		// Token: 0x0602756B RID: 161131
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Close_Internal(IntPtr @this);

		// Token: 0x0602756C RID: 161132 RVA: 0x003BF84C File Offset: 0x003BDA4C
		static UMenuAnchor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.MenuAnchor");
		}

		// Token: 0x0602756D RID: 161133 RVA: 0x003BF85A File Offset: 0x003BDA5A
		protected UMenuAnchor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401598B RID: 88459
		public new const string __ObjectPath = "/Script/UMG.MenuAnchor";

		// Token: 0x0401598C RID: 88460
		private static IntPtr _ClassPtr;

		// Token: 0x0401598D RID: 88461
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401598E RID: 88462
		public static IntPtr __GetUserWidget__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0401598F RID: 88463
		internal static int __PropertyOffset_MenuClass;

		// Token: 0x04015990 RID: 88464
		internal static int __PropertyOffset_OnGetMenuContentEvent;

		// Token: 0x04015991 RID: 88465
		[Nullable(2)]
		private FGetWidget _OnGetMenuContentEvent;

		// Token: 0x04015992 RID: 88466
		internal static int __PropertyOffset_OnGetUserMenuContentEvent;

		// Token: 0x04015993 RID: 88467
		[Nullable(2)]
		private FGetUserWidget _OnGetUserMenuContentEvent;

		// Token: 0x04015994 RID: 88468
		internal static int __PropertyOffset_Placement;

		// Token: 0x04015995 RID: 88469
		internal static int __PropertyOffset_bFitInWindow;

		// Token: 0x04015996 RID: 88470
		internal static int __PropertyOffset_ShouldDeferPaintingAfterWindowContent;

		// Token: 0x04015997 RID: 88471
		internal static int __PropertyOffset_UseApplicationMenuStack;

		// Token: 0x04015998 RID: 88472
		internal static int __PropertyOffset_OnMenuOpenChanged;

		// Token: 0x04015999 RID: 88473
		[Nullable(2)]
		private FOnMenuOpenChangedEvent _OnMenuOpenChanged;
	}
}
