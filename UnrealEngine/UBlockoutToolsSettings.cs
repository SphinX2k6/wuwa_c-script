using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200042B RID: 1067
	[UnrealObjectPath("/Script/BlockoutToolsPlugin.BlockoutToolsSettings")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UBlockoutToolsSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003973 RID: 14707 RVA: 0x0005728C File Offset: 0x0005548C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBlockoutToolsSettings._ClassPtr;
		}

		// Token: 0x06003974 RID: 14708 RVA: 0x00057298 File Offset: 0x00055498
		public UBlockoutToolsSettings() : this(BuiltinUtils.AllocNativeUObject(UBlockoutToolsSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003975 RID: 14709 RVA: 0x000572C0 File Offset: 0x000554C0
		[NullableContext(1)]
		public UBlockoutToolsSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBlockoutToolsSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000DA1 RID: 3489
		// (get) Token: 0x06003976 RID: 14710 RVA: 0x000572F3 File Offset: 0x000554F3
		// (set) Token: 0x06003977 RID: 14711 RVA: 0x00057307 File Offset: 0x00055507
		public unsafe TEnumAsByte<EBlockoutMaterialType> BlockoutMaterialType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBlockoutToolsSettings.__PropertyOffset_BlockoutMaterialType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBlockoutToolsSettings.__PropertyOffset_BlockoutMaterialType) = value;
			}
		}

		// Token: 0x17000DA2 RID: 3490
		// (get) Token: 0x06003978 RID: 14712 RVA: 0x0005731C File Offset: 0x0005551C
		// (set) Token: 0x06003979 RID: 14713 RVA: 0x00057330 File Offset: 0x00055530
		public unsafe FLinearColor BlockoutMaterialColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBlockoutToolsSettings.__PropertyOffset_BlockoutMaterialColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBlockoutToolsSettings.__PropertyOffset_BlockoutMaterialColor) = value;
			}
		}

		// Token: 0x17000DA3 RID: 3491
		// (get) Token: 0x0600397A RID: 14714 RVA: 0x00057345 File Offset: 0x00055545
		// (set) Token: 0x0600397B RID: 14715 RVA: 0x00057355 File Offset: 0x00055555
		public unsafe bool bBlockoutMaterialUseGrid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBlockoutToolsSettings.__PropertyOffset_bBlockoutMaterialUseGrid) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBlockoutToolsSettings.__PropertyOffset_bBlockoutMaterialUseGrid) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000DA4 RID: 3492
		// (get) Token: 0x0600397C RID: 14716 RVA: 0x00057366 File Offset: 0x00055566
		// (set) Token: 0x0600397D RID: 14717 RVA: 0x00057376 File Offset: 0x00055576
		public unsafe bool bBlockoutWorldAligned
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBlockoutToolsSettings.__PropertyOffset_bBlockoutWorldAligned) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBlockoutToolsSettings.__PropertyOffset_bBlockoutWorldAligned) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000DA5 RID: 3493
		// (get) Token: 0x0600397E RID: 14718 RVA: 0x00057387 File Offset: 0x00055587
		// (set) Token: 0x0600397F RID: 14719 RVA: 0x00057397 File Offset: 0x00055597
		public unsafe float BlockoutMaterialGridSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBlockoutToolsSettings.__PropertyOffset_BlockoutMaterialGridSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBlockoutToolsSettings.__PropertyOffset_BlockoutMaterialGridSize) = value;
			}
		}

		// Token: 0x17000DA6 RID: 3494
		// (get) Token: 0x06003980 RID: 14720 RVA: 0x000573A8 File Offset: 0x000555A8
		// (set) Token: 0x06003981 RID: 14721 RVA: 0x000573B8 File Offset: 0x000555B8
		public unsafe float BlockoutMaterialCheckerLuminance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBlockoutToolsSettings.__PropertyOffset_BlockoutMaterialCheckerLuminance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBlockoutToolsSettings.__PropertyOffset_BlockoutMaterialCheckerLuminance) = value;
			}
		}

		// Token: 0x17000DA7 RID: 3495
		// (get) Token: 0x06003982 RID: 14722 RVA: 0x000573C9 File Offset: 0x000555C9
		// (set) Token: 0x06003983 RID: 14723 RVA: 0x000573D9 File Offset: 0x000555D9
		public unsafe float BlockoutMaterialRoughness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBlockoutToolsSettings.__PropertyOffset_BlockoutMaterialRoughness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBlockoutToolsSettings.__PropertyOffset_BlockoutMaterialRoughness) = value;
			}
		}

		// Token: 0x17000DA8 RID: 3496
		// (get) Token: 0x06003984 RID: 14724 RVA: 0x000573EA File Offset: 0x000555EA
		// (set) Token: 0x06003985 RID: 14725 RVA: 0x000573FA File Offset: 0x000555FA
		public unsafe bool bBlockoutMaterialUseTopColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBlockoutToolsSettings.__PropertyOffset_bBlockoutMaterialUseTopColor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBlockoutToolsSettings.__PropertyOffset_bBlockoutMaterialUseTopColor) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000DA9 RID: 3497
		// (get) Token: 0x06003986 RID: 14726 RVA: 0x0005740B File Offset: 0x0005560B
		// (set) Token: 0x06003987 RID: 14727 RVA: 0x0005741F File Offset: 0x0005561F
		public unsafe FLinearColor BlockoutMaterialTopColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBlockoutToolsSettings.__PropertyOffset_BlockoutMaterialTopColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBlockoutToolsSettings.__PropertyOffset_BlockoutMaterialTopColor) = value;
			}
		}

		// Token: 0x06003988 RID: 14728 RVA: 0x00057434 File Offset: 0x00055634
		static UBlockoutToolsSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/BlockoutToolsPlugin.BlockoutToolsSettings");
		}

		// Token: 0x06003989 RID: 14729 RVA: 0x00057442 File Offset: 0x00055642
		protected UBlockoutToolsSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001A16 RID: 6678
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/BlockoutToolsPlugin.BlockoutToolsSettings";

		// Token: 0x04001A17 RID: 6679
		private static IntPtr _ClassPtr;

		// Token: 0x04001A18 RID: 6680
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001A19 RID: 6681
		internal static int __PropertyOffset_BlockoutMaterialType;

		// Token: 0x04001A1A RID: 6682
		internal static int __PropertyOffset_BlockoutMaterialColor;

		// Token: 0x04001A1B RID: 6683
		internal static int __PropertyOffset_bBlockoutMaterialUseGrid;

		// Token: 0x04001A1C RID: 6684
		internal static int __PropertyOffset_bBlockoutWorldAligned;

		// Token: 0x04001A1D RID: 6685
		internal static int __PropertyOffset_BlockoutMaterialGridSize;

		// Token: 0x04001A1E RID: 6686
		internal static int __PropertyOffset_BlockoutMaterialCheckerLuminance;

		// Token: 0x04001A1F RID: 6687
		internal static int __PropertyOffset_BlockoutMaterialRoughness;

		// Token: 0x04001A20 RID: 6688
		internal static int __PropertyOffset_bBlockoutMaterialUseTopColor;

		// Token: 0x04001A21 RID: 6689
		internal static int __PropertyOffset_BlockoutMaterialTopColor;
	}
}
