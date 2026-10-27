using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002836 RID: 10294
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SlateCore.TableColumnHeaderStyle")]
	[UnrealStructLayout(1448, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1448)]
	public class FTableColumnHeaderStyle : FSlateWidgetStyle, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060263F1 RID: 156657 RVA: 0x003A0E5E File Offset: 0x0039F05E
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTableColumnHeaderStyle._ScriptStructPtr != 0) ? FTableColumnHeaderStyle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.TableColumnHeaderStyle", ref FTableColumnHeaderStyle._ScriptStructPtr);
		}

		// Token: 0x170093A1 RID: 37793
		// (get) Token: 0x060263F2 RID: 156658 RVA: 0x003A0E84 File Offset: 0x0039F084
		// (set) Token: 0x060263F3 RID: 156659 RVA: 0x003A0EC7 File Offset: 0x0039F0C7
		public FSlateBrush SortPrimaryAscendingImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._SortPrimaryAscendingImage) == null)
				{
					result = (this._SortPrimaryAscendingImage = new FSlateBrush(base.NativePtr + (IntPtr)FTableColumnHeaderStyle.__PropertyOffset_SortPrimaryAscendingImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FTableColumnHeaderStyle.__PropertyOffset_SortPrimaryAscendingImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093A2 RID: 37794
		// (get) Token: 0x060263F4 RID: 156660 RVA: 0x003A0EE8 File Offset: 0x0039F0E8
		// (set) Token: 0x060263F5 RID: 156661 RVA: 0x003A0F2B File Offset: 0x0039F12B
		public FSlateBrush SortPrimaryDescendingImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._SortPrimaryDescendingImage) == null)
				{
					result = (this._SortPrimaryDescendingImage = new FSlateBrush(base.NativePtr + (IntPtr)FTableColumnHeaderStyle.__PropertyOffset_SortPrimaryDescendingImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FTableColumnHeaderStyle.__PropertyOffset_SortPrimaryDescendingImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093A3 RID: 37795
		// (get) Token: 0x060263F6 RID: 156662 RVA: 0x003A0F4C File Offset: 0x0039F14C
		// (set) Token: 0x060263F7 RID: 156663 RVA: 0x003A0F8F File Offset: 0x0039F18F
		public FSlateBrush SortSecondaryAscendingImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._SortSecondaryAscendingImage) == null)
				{
					result = (this._SortSecondaryAscendingImage = new FSlateBrush(base.NativePtr + (IntPtr)FTableColumnHeaderStyle.__PropertyOffset_SortSecondaryAscendingImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FTableColumnHeaderStyle.__PropertyOffset_SortSecondaryAscendingImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093A4 RID: 37796
		// (get) Token: 0x060263F8 RID: 156664 RVA: 0x003A0FB0 File Offset: 0x0039F1B0
		// (set) Token: 0x060263F9 RID: 156665 RVA: 0x003A0FF3 File Offset: 0x0039F1F3
		public FSlateBrush SortSecondaryDescendingImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._SortSecondaryDescendingImage) == null)
				{
					result = (this._SortSecondaryDescendingImage = new FSlateBrush(base.NativePtr + (IntPtr)FTableColumnHeaderStyle.__PropertyOffset_SortSecondaryDescendingImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FTableColumnHeaderStyle.__PropertyOffset_SortSecondaryDescendingImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093A5 RID: 37797
		// (get) Token: 0x060263FA RID: 156666 RVA: 0x003A1014 File Offset: 0x0039F214
		// (set) Token: 0x060263FB RID: 156667 RVA: 0x003A1057 File Offset: 0x0039F257
		public FSlateBrush NormalBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._NormalBrush) == null)
				{
					result = (this._NormalBrush = new FSlateBrush(base.NativePtr + (IntPtr)FTableColumnHeaderStyle.__PropertyOffset_NormalBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FTableColumnHeaderStyle.__PropertyOffset_NormalBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093A6 RID: 37798
		// (get) Token: 0x060263FC RID: 156668 RVA: 0x003A1078 File Offset: 0x0039F278
		// (set) Token: 0x060263FD RID: 156669 RVA: 0x003A10BB File Offset: 0x0039F2BB
		public FSlateBrush HoveredBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._HoveredBrush) == null)
				{
					result = (this._HoveredBrush = new FSlateBrush(base.NativePtr + (IntPtr)FTableColumnHeaderStyle.__PropertyOffset_HoveredBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FTableColumnHeaderStyle.__PropertyOffset_HoveredBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093A7 RID: 37799
		// (get) Token: 0x060263FE RID: 156670 RVA: 0x003A10DC File Offset: 0x0039F2DC
		// (set) Token: 0x060263FF RID: 156671 RVA: 0x003A111F File Offset: 0x0039F31F
		public FSlateBrush MenuDropdownImage
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._MenuDropdownImage) == null)
				{
					result = (this._MenuDropdownImage = new FSlateBrush(base.NativePtr + (IntPtr)FTableColumnHeaderStyle.__PropertyOffset_MenuDropdownImage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FTableColumnHeaderStyle.__PropertyOffset_MenuDropdownImage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093A8 RID: 37800
		// (get) Token: 0x06026400 RID: 156672 RVA: 0x003A1140 File Offset: 0x0039F340
		// (set) Token: 0x06026401 RID: 156673 RVA: 0x003A1183 File Offset: 0x0039F383
		public FSlateBrush MenuDropdownNormalBorderBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._MenuDropdownNormalBorderBrush) == null)
				{
					result = (this._MenuDropdownNormalBorderBrush = new FSlateBrush(base.NativePtr + (IntPtr)FTableColumnHeaderStyle.__PropertyOffset_MenuDropdownNormalBorderBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FTableColumnHeaderStyle.__PropertyOffset_MenuDropdownNormalBorderBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170093A9 RID: 37801
		// (get) Token: 0x06026402 RID: 156674 RVA: 0x003A11A4 File Offset: 0x0039F3A4
		// (set) Token: 0x06026403 RID: 156675 RVA: 0x003A11E7 File Offset: 0x0039F3E7
		public FSlateBrush MenuDropdownHoveredBorderBrush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._MenuDropdownHoveredBorderBrush) == null)
				{
					result = (this._MenuDropdownHoveredBorderBrush = new FSlateBrush(base.NativePtr + (IntPtr)FTableColumnHeaderStyle.__PropertyOffset_MenuDropdownHoveredBorderBrush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FTableColumnHeaderStyle.__PropertyOffset_MenuDropdownHoveredBorderBrush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06026404 RID: 156676 RVA: 0x003A1208 File Offset: 0x0039F408
		public FTableColumnHeaderStyle()
		{
		}

		// Token: 0x06026405 RID: 156677 RVA: 0x003A1210 File Offset: 0x0039F410
		public FTableColumnHeaderStyle(FSlateBrush SortPrimaryAscendingImage, FSlateBrush SortPrimaryDescendingImage, FSlateBrush SortSecondaryAscendingImage, FSlateBrush SortSecondaryDescendingImage, FSlateBrush NormalBrush, FSlateBrush HoveredBrush, FSlateBrush MenuDropdownImage, FSlateBrush MenuDropdownNormalBorderBrush, FSlateBrush MenuDropdownHoveredBorderBrush)
		{
			this.SortPrimaryAscendingImage = SortPrimaryAscendingImage;
			this.SortPrimaryDescendingImage = SortPrimaryDescendingImage;
			this.SortSecondaryAscendingImage = SortSecondaryAscendingImage;
			this.SortSecondaryDescendingImage = SortSecondaryDescendingImage;
			this.NormalBrush = NormalBrush;
			this.HoveredBrush = HoveredBrush;
			this.MenuDropdownImage = MenuDropdownImage;
			this.MenuDropdownNormalBorderBrush = MenuDropdownNormalBorderBrush;
			this.MenuDropdownHoveredBorderBrush = MenuDropdownHoveredBorderBrush;
		}

		// Token: 0x06026406 RID: 156678 RVA: 0x003A1268 File Offset: 0x0039F468
		protected override IntPtr GetUStructPtr()
		{
			return FTableColumnHeaderStyle.StaticStruct();
		}

		// Token: 0x06026407 RID: 156679 RVA: 0x003A1274 File Offset: 0x0039F474
		[NullableContext(2)]
		public FTableColumnHeaderStyle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026408 RID: 156680 RVA: 0x003A127E File Offset: 0x0039F47E
		public FTableColumnHeaderStyle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026409 RID: 156681 RVA: 0x003A1289 File Offset: 0x0039F489
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTableColumnHeaderStyle(Pointer, false, true);
		}

		// Token: 0x0602640A RID: 156682 RVA: 0x003A1293 File Offset: 0x0039F493
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTableColumnHeaderStyle(Pointer, MemoryOwner);
		}

		// Token: 0x04014EF3 RID: 85747
		public new const string __ObjectPath = "/Script/SlateCore.TableColumnHeaderStyle";

		// Token: 0x04014EF4 RID: 85748
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014EF5 RID: 85749
		internal static int __PropertyOffset_SortPrimaryAscendingImage;

		// Token: 0x04014EF6 RID: 85750
		[Nullable(2)]
		private FSlateBrush _SortPrimaryAscendingImage;

		// Token: 0x04014EF7 RID: 85751
		internal static int __PropertyOffset_SortPrimaryDescendingImage;

		// Token: 0x04014EF8 RID: 85752
		[Nullable(2)]
		private FSlateBrush _SortPrimaryDescendingImage;

		// Token: 0x04014EF9 RID: 85753
		internal static int __PropertyOffset_SortSecondaryAscendingImage;

		// Token: 0x04014EFA RID: 85754
		[Nullable(2)]
		private FSlateBrush _SortSecondaryAscendingImage;

		// Token: 0x04014EFB RID: 85755
		internal static int __PropertyOffset_SortSecondaryDescendingImage;

		// Token: 0x04014EFC RID: 85756
		[Nullable(2)]
		private FSlateBrush _SortSecondaryDescendingImage;

		// Token: 0x04014EFD RID: 85757
		internal static int __PropertyOffset_NormalBrush;

		// Token: 0x04014EFE RID: 85758
		[Nullable(2)]
		private FSlateBrush _NormalBrush;

		// Token: 0x04014EFF RID: 85759
		internal static int __PropertyOffset_HoveredBrush;

		// Token: 0x04014F00 RID: 85760
		[Nullable(2)]
		private FSlateBrush _HoveredBrush;

		// Token: 0x04014F01 RID: 85761
		internal static int __PropertyOffset_MenuDropdownImage;

		// Token: 0x04014F02 RID: 85762
		[Nullable(2)]
		private FSlateBrush _MenuDropdownImage;

		// Token: 0x04014F03 RID: 85763
		internal static int __PropertyOffset_MenuDropdownNormalBorderBrush;

		// Token: 0x04014F04 RID: 85764
		[Nullable(2)]
		private FSlateBrush _MenuDropdownNormalBorderBrush;

		// Token: 0x04014F05 RID: 85765
		internal static int __PropertyOffset_MenuDropdownHoveredBorderBrush;

		// Token: 0x04014F06 RID: 85766
		[Nullable(2)]
		private FSlateBrush _MenuDropdownHoveredBorderBrush;
	}
}
