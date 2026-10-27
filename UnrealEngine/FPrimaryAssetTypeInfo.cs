using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200103B RID: 4155
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PrimaryAssetTypeInfo")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 152)]
	public class FPrimaryAssetTypeInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600E9B5 RID: 59829 RVA: 0x0015B35A File Offset: 0x0015955A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPrimaryAssetTypeInfo._ScriptStructPtr != 0) ? FPrimaryAssetTypeInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PrimaryAssetTypeInfo", ref FPrimaryAssetTypeInfo._ScriptStructPtr);
		}

		// Token: 0x17003897 RID: 14487
		// (get) Token: 0x0600E9B6 RID: 59830 RVA: 0x0015B37E File Offset: 0x0015957E
		// (set) Token: 0x0600E9B7 RID: 59831 RVA: 0x0015B392 File Offset: 0x00159592
		public unsafe FName PrimaryAssetType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPrimaryAssetTypeInfo.__PropertyOffset_PrimaryAssetType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPrimaryAssetTypeInfo.__PropertyOffset_PrimaryAssetType) = value;
			}
		}

		// Token: 0x17003898 RID: 14488
		// (get) Token: 0x0600E9B8 RID: 59832 RVA: 0x0015B3A7 File Offset: 0x001595A7
		// (set) Token: 0x0600E9B9 RID: 59833 RVA: 0x0015B3C6 File Offset: 0x001595C6
		public TSoftClassPtr<UObject> AssetBaseClass
		{
			get
			{
				return new TSoftClassPtr<UObject>(base.NativePtr + (IntPtr)FPrimaryAssetTypeInfo.__PropertyOffset_AssetBaseClass, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FPrimaryAssetTypeInfo.__PropertyOffset_AssetBaseClass, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003899 RID: 14489
		// (get) Token: 0x0600E9BA RID: 59834 RVA: 0x0015B3EB File Offset: 0x001595EB
		// (set) Token: 0x0600E9BB RID: 59835 RVA: 0x0015B3FF File Offset: 0x001595FF
		public unsafe UClassStackOnlyPtr AssetBaseClassLoaded
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPrimaryAssetTypeInfo.__PropertyOffset_AssetBaseClassLoaded);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPrimaryAssetTypeInfo.__PropertyOffset_AssetBaseClassLoaded) = value;
			}
		}

		// Token: 0x1700389A RID: 14490
		// (get) Token: 0x0600E9BC RID: 59836 RVA: 0x0015B414 File Offset: 0x00159614
		// (set) Token: 0x0600E9BD RID: 59837 RVA: 0x0015B424 File Offset: 0x00159624
		public unsafe bool bHasBlueprintClasses
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPrimaryAssetTypeInfo.__PropertyOffset_bHasBlueprintClasses) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPrimaryAssetTypeInfo.__PropertyOffset_bHasBlueprintClasses) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700389B RID: 14491
		// (get) Token: 0x0600E9BE RID: 59838 RVA: 0x0015B435 File Offset: 0x00159635
		// (set) Token: 0x0600E9BF RID: 59839 RVA: 0x0015B445 File Offset: 0x00159645
		public unsafe bool bIsEditorOnly
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPrimaryAssetTypeInfo.__PropertyOffset_bIsEditorOnly) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPrimaryAssetTypeInfo.__PropertyOffset_bIsEditorOnly) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700389C RID: 14492
		// (get) Token: 0x0600E9C0 RID: 59840 RVA: 0x0015B458 File Offset: 0x00159658
		// (set) Token: 0x0600E9C1 RID: 59841 RVA: 0x0015B49B File Offset: 0x0015969B
		public TArray<FDirectoryPath> Directories
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FDirectoryPath> result;
				if ((result = this._Directories) == null)
				{
					result = (this._Directories = new TArray<FDirectoryPath>(base.NativePtr + (IntPtr)FPrimaryAssetTypeInfo.__PropertyOffset_Directories, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Directories.CopyAssign(value);
			}
		}

		// Token: 0x1700389D RID: 14493
		// (get) Token: 0x0600E9C2 RID: 59842 RVA: 0x0015B4AC File Offset: 0x001596AC
		// (set) Token: 0x0600E9C3 RID: 59843 RVA: 0x0015B4EF File Offset: 0x001596EF
		public TArray<FSoftObjectPath> SpecificAssets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSoftObjectPath> result;
				if ((result = this._SpecificAssets) == null)
				{
					result = (this._SpecificAssets = new TArray<FSoftObjectPath>(base.NativePtr + (IntPtr)FPrimaryAssetTypeInfo.__PropertyOffset_SpecificAssets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SpecificAssets.CopyAssign(value);
			}
		}

		// Token: 0x1700389E RID: 14494
		// (get) Token: 0x0600E9C4 RID: 59844 RVA: 0x0015B500 File Offset: 0x00159700
		// (set) Token: 0x0600E9C5 RID: 59845 RVA: 0x0015B543 File Offset: 0x00159743
		public FPrimaryAssetRules Rules
		{
			get
			{
				base.FastCheckIsValid();
				FPrimaryAssetRules result;
				if ((result = this._Rules) == null)
				{
					result = (this._Rules = new FPrimaryAssetRules(base.NativePtr + (IntPtr)FPrimaryAssetTypeInfo.__PropertyOffset_Rules, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPrimaryAssetRules.StaticStruct(), base.NativePtr + (IntPtr)FPrimaryAssetTypeInfo.__PropertyOffset_Rules, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700389F RID: 14495
		// (get) Token: 0x0600E9C6 RID: 59846 RVA: 0x0015B564 File Offset: 0x00159764
		// (set) Token: 0x0600E9C7 RID: 59847 RVA: 0x0015B5A7 File Offset: 0x001597A7
		public TArray<string> AssetScanPaths
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._AssetScanPaths) == null)
				{
					result = (this._AssetScanPaths = new TArray<string>(base.NativePtr + (IntPtr)FPrimaryAssetTypeInfo.__PropertyOffset_AssetScanPaths, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AssetScanPaths.CopyAssign(value);
			}
		}

		// Token: 0x170038A0 RID: 14496
		// (get) Token: 0x0600E9C8 RID: 59848 RVA: 0x0015B5B5 File Offset: 0x001597B5
		// (set) Token: 0x0600E9C9 RID: 59849 RVA: 0x0015B5C5 File Offset: 0x001597C5
		public unsafe bool bIsDynamicAsset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPrimaryAssetTypeInfo.__PropertyOffset_bIsDynamicAsset) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPrimaryAssetTypeInfo.__PropertyOffset_bIsDynamicAsset) = (value ? 1 : 0);
			}
		}

		// Token: 0x170038A1 RID: 14497
		// (get) Token: 0x0600E9CA RID: 59850 RVA: 0x0015B5D6 File Offset: 0x001597D6
		// (set) Token: 0x0600E9CB RID: 59851 RVA: 0x0015B5E6 File Offset: 0x001597E6
		public unsafe int NumberOfAssets
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPrimaryAssetTypeInfo.__PropertyOffset_NumberOfAssets);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPrimaryAssetTypeInfo.__PropertyOffset_NumberOfAssets) = value;
			}
		}

		// Token: 0x0600E9CC RID: 59852 RVA: 0x0015B5F7 File Offset: 0x001597F7
		public FPrimaryAssetTypeInfo()
		{
		}

		// Token: 0x0600E9CD RID: 59853 RVA: 0x0015B600 File Offset: 0x00159800
		public FPrimaryAssetTypeInfo(FName PrimaryAssetType, TSoftClassPtr<UObject> AssetBaseClass, UClassStackOnlyPtr AssetBaseClassLoaded, bool bHasBlueprintClasses, bool bIsEditorOnly, TArray<FDirectoryPath> Directories, TArray<FSoftObjectPath> SpecificAssets, FPrimaryAssetRules Rules, TArray<string> AssetScanPaths, bool bIsDynamicAsset, int NumberOfAssets)
		{
			this.PrimaryAssetType = PrimaryAssetType;
			this.AssetBaseClass = AssetBaseClass;
			this.AssetBaseClassLoaded = AssetBaseClassLoaded;
			this.bHasBlueprintClasses = bHasBlueprintClasses;
			this.bIsEditorOnly = bIsEditorOnly;
			this.Directories = Directories;
			this.SpecificAssets = SpecificAssets;
			this.Rules = Rules;
			this.AssetScanPaths = AssetScanPaths;
			this.bIsDynamicAsset = bIsDynamicAsset;
			this.NumberOfAssets = NumberOfAssets;
		}

		// Token: 0x0600E9CE RID: 59854 RVA: 0x0015B668 File Offset: 0x00159868
		protected override IntPtr GetUStructPtr()
		{
			return FPrimaryAssetTypeInfo.StaticStruct();
		}

		// Token: 0x0600E9CF RID: 59855 RVA: 0x0015B674 File Offset: 0x00159874
		[NullableContext(2)]
		public FPrimaryAssetTypeInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600E9D0 RID: 59856 RVA: 0x0015B67E File Offset: 0x0015987E
		public FPrimaryAssetTypeInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600E9D1 RID: 59857 RVA: 0x0015B689 File Offset: 0x00159889
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPrimaryAssetTypeInfo(Pointer, false, true);
		}

		// Token: 0x0600E9D2 RID: 59858 RVA: 0x0015B693 File Offset: 0x00159893
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPrimaryAssetTypeInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04007EDE RID: 32478
		public const string __ObjectPath = "/Script/Engine.PrimaryAssetTypeInfo";

		// Token: 0x04007EDF RID: 32479
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04007EE0 RID: 32480
		internal static int __PropertyOffset_PrimaryAssetType;

		// Token: 0x04007EE1 RID: 32481
		internal static int __PropertyOffset_AssetBaseClass;

		// Token: 0x04007EE2 RID: 32482
		internal static int __PropertyOffset_AssetBaseClassLoaded;

		// Token: 0x04007EE3 RID: 32483
		internal static int __PropertyOffset_bHasBlueprintClasses;

		// Token: 0x04007EE4 RID: 32484
		internal static int __PropertyOffset_bIsEditorOnly;

		// Token: 0x04007EE5 RID: 32485
		internal static int __PropertyOffset_Directories;

		// Token: 0x04007EE6 RID: 32486
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FDirectoryPath> _Directories;

		// Token: 0x04007EE7 RID: 32487
		internal static int __PropertyOffset_SpecificAssets;

		// Token: 0x04007EE8 RID: 32488
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoftObjectPath> _SpecificAssets;

		// Token: 0x04007EE9 RID: 32489
		internal static int __PropertyOffset_Rules;

		// Token: 0x04007EEA RID: 32490
		[Nullable(2)]
		private FPrimaryAssetRules _Rules;

		// Token: 0x04007EEB RID: 32491
		internal static int __PropertyOffset_AssetScanPaths;

		// Token: 0x04007EEC RID: 32492
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _AssetScanPaths;

		// Token: 0x04007EED RID: 32493
		internal static int __PropertyOffset_bIsDynamicAsset;

		// Token: 0x04007EEE RID: 32494
		internal static int __PropertyOffset_NumberOfAssets;
	}
}
