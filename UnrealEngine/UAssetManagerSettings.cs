using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000857 RID: 2135
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AssetManagerSettings")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class UAssetManagerSettings : UDeveloperSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007337 RID: 29495 RVA: 0x000A507F File Offset: 0x000A327F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAssetManagerSettings._ClassPtr;
		}

		// Token: 0x06007338 RID: 29496 RVA: 0x000A508C File Offset: 0x000A328C
		public UAssetManagerSettings() : this(BuiltinUtils.AllocNativeUObject(UAssetManagerSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007339 RID: 29497 RVA: 0x000A50B4 File Offset: 0x000A32B4
		public UAssetManagerSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAssetManagerSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001B2A RID: 6954
		// (get) Token: 0x0600733A RID: 29498 RVA: 0x000A50E8 File Offset: 0x000A32E8
		// (set) Token: 0x0600733B RID: 29499 RVA: 0x000A5121 File Offset: 0x000A3321
		public TArray<FPrimaryAssetTypeInfo> PrimaryAssetTypesToScan
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPrimaryAssetTypeInfo> result;
				if ((result = this._PrimaryAssetTypesToScan) == null)
				{
					result = (this._PrimaryAssetTypesToScan = new TArray<FPrimaryAssetTypeInfo>(base.NativePtr + (IntPtr)UAssetManagerSettings.__PropertyOffset_PrimaryAssetTypesToScan, this));
				}
				return result;
			}
			set
			{
				this.PrimaryAssetTypesToScan.CopyAssign(value);
			}
		}

		// Token: 0x17001B2B RID: 6955
		// (get) Token: 0x0600733C RID: 29500 RVA: 0x000A5130 File Offset: 0x000A3330
		// (set) Token: 0x0600733D RID: 29501 RVA: 0x000A5169 File Offset: 0x000A3369
		public TArray<FDirectoryPath> DirectoriesToExclude
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FDirectoryPath> result;
				if ((result = this._DirectoriesToExclude) == null)
				{
					result = (this._DirectoriesToExclude = new TArray<FDirectoryPath>(base.NativePtr + (IntPtr)UAssetManagerSettings.__PropertyOffset_DirectoriesToExclude, this));
				}
				return result;
			}
			set
			{
				this.DirectoriesToExclude.CopyAssign(value);
			}
		}

		// Token: 0x17001B2C RID: 6956
		// (get) Token: 0x0600733E RID: 29502 RVA: 0x000A5178 File Offset: 0x000A3378
		// (set) Token: 0x0600733F RID: 29503 RVA: 0x000A51B1 File Offset: 0x000A33B1
		public TArray<FPrimaryAssetRulesOverride> PrimaryAssetRules
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPrimaryAssetRulesOverride> result;
				if ((result = this._PrimaryAssetRules) == null)
				{
					result = (this._PrimaryAssetRules = new TArray<FPrimaryAssetRulesOverride>(base.NativePtr + (IntPtr)UAssetManagerSettings.__PropertyOffset_PrimaryAssetRules, this));
				}
				return result;
			}
			set
			{
				this.PrimaryAssetRules.CopyAssign(value);
			}
		}

		// Token: 0x17001B2D RID: 6957
		// (get) Token: 0x06007340 RID: 29504 RVA: 0x000A51C0 File Offset: 0x000A33C0
		// (set) Token: 0x06007341 RID: 29505 RVA: 0x000A51F9 File Offset: 0x000A33F9
		public TArray<FPrimaryAssetRulesCustomOverride> CustomPrimaryAssetRules
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPrimaryAssetRulesCustomOverride> result;
				if ((result = this._CustomPrimaryAssetRules) == null)
				{
					result = (this._CustomPrimaryAssetRules = new TArray<FPrimaryAssetRulesCustomOverride>(base.NativePtr + (IntPtr)UAssetManagerSettings.__PropertyOffset_CustomPrimaryAssetRules, this));
				}
				return result;
			}
			set
			{
				this.CustomPrimaryAssetRules.CopyAssign(value);
			}
		}

		// Token: 0x17001B2E RID: 6958
		// (get) Token: 0x06007342 RID: 29506 RVA: 0x000A5207 File Offset: 0x000A3407
		// (set) Token: 0x06007343 RID: 29507 RVA: 0x000A5217 File Offset: 0x000A3417
		public unsafe bool bOnlyCookProductionAssets
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAssetManagerSettings.__PropertyOffset_bOnlyCookProductionAssets) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAssetManagerSettings.__PropertyOffset_bOnlyCookProductionAssets) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001B2F RID: 6959
		// (get) Token: 0x06007344 RID: 29508 RVA: 0x000A5228 File Offset: 0x000A3428
		// (set) Token: 0x06007345 RID: 29509 RVA: 0x000A5238 File Offset: 0x000A3438
		public unsafe bool bShouldManagerDetermineTypeAndName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAssetManagerSettings.__PropertyOffset_bShouldManagerDetermineTypeAndName) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAssetManagerSettings.__PropertyOffset_bShouldManagerDetermineTypeAndName) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001B30 RID: 6960
		// (get) Token: 0x06007346 RID: 29510 RVA: 0x000A5249 File Offset: 0x000A3449
		// (set) Token: 0x06007347 RID: 29511 RVA: 0x000A5259 File Offset: 0x000A3459
		public unsafe bool bShouldGuessTypeAndNameInEditor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAssetManagerSettings.__PropertyOffset_bShouldGuessTypeAndNameInEditor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAssetManagerSettings.__PropertyOffset_bShouldGuessTypeAndNameInEditor) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001B31 RID: 6961
		// (get) Token: 0x06007348 RID: 29512 RVA: 0x000A526A File Offset: 0x000A346A
		// (set) Token: 0x06007349 RID: 29513 RVA: 0x000A527A File Offset: 0x000A347A
		public unsafe bool bShouldAcquireMissingChunksOnLoad
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAssetManagerSettings.__PropertyOffset_bShouldAcquireMissingChunksOnLoad) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAssetManagerSettings.__PropertyOffset_bShouldAcquireMissingChunksOnLoad) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001B32 RID: 6962
		// (get) Token: 0x0600734A RID: 29514 RVA: 0x000A528C File Offset: 0x000A348C
		// (set) Token: 0x0600734B RID: 29515 RVA: 0x000A52C5 File Offset: 0x000A34C5
		public TArray<FAssetManagerRedirect> PrimaryAssetIdRedirects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAssetManagerRedirect> result;
				if ((result = this._PrimaryAssetIdRedirects) == null)
				{
					result = (this._PrimaryAssetIdRedirects = new TArray<FAssetManagerRedirect>(base.NativePtr + (IntPtr)UAssetManagerSettings.__PropertyOffset_PrimaryAssetIdRedirects, this));
				}
				return result;
			}
			set
			{
				this.PrimaryAssetIdRedirects.CopyAssign(value);
			}
		}

		// Token: 0x17001B33 RID: 6963
		// (get) Token: 0x0600734C RID: 29516 RVA: 0x000A52D4 File Offset: 0x000A34D4
		// (set) Token: 0x0600734D RID: 29517 RVA: 0x000A530D File Offset: 0x000A350D
		public TArray<FAssetManagerRedirect> PrimaryAssetTypeRedirects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAssetManagerRedirect> result;
				if ((result = this._PrimaryAssetTypeRedirects) == null)
				{
					result = (this._PrimaryAssetTypeRedirects = new TArray<FAssetManagerRedirect>(base.NativePtr + (IntPtr)UAssetManagerSettings.__PropertyOffset_PrimaryAssetTypeRedirects, this));
				}
				return result;
			}
			set
			{
				this.PrimaryAssetTypeRedirects.CopyAssign(value);
			}
		}

		// Token: 0x17001B34 RID: 6964
		// (get) Token: 0x0600734E RID: 29518 RVA: 0x000A531C File Offset: 0x000A351C
		// (set) Token: 0x0600734F RID: 29519 RVA: 0x000A5355 File Offset: 0x000A3555
		public TArray<FAssetManagerRedirect> AssetPathRedirects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAssetManagerRedirect> result;
				if ((result = this._AssetPathRedirects) == null)
				{
					result = (this._AssetPathRedirects = new TArray<FAssetManagerRedirect>(base.NativePtr + (IntPtr)UAssetManagerSettings.__PropertyOffset_AssetPathRedirects, this));
				}
				return result;
			}
			set
			{
				this.AssetPathRedirects.CopyAssign(value);
			}
		}

		// Token: 0x17001B35 RID: 6965
		// (get) Token: 0x06007350 RID: 29520 RVA: 0x000A5364 File Offset: 0x000A3564
		// (set) Token: 0x06007351 RID: 29521 RVA: 0x000A539D File Offset: 0x000A359D
		public TSet<FName> MetaDataTagsForAssetRegistry
		{
			get
			{
				base.FastCheckIsValid();
				TSet<FName> result;
				if ((result = this._MetaDataTagsForAssetRegistry) == null)
				{
					result = (this._MetaDataTagsForAssetRegistry = new TSet<FName>(base.NativePtr + (IntPtr)UAssetManagerSettings.__PropertyOffset_MetaDataTagsForAssetRegistry, this));
				}
				return result;
			}
			set
			{
				this.MetaDataTagsForAssetRegistry.CopyAssign(value);
			}
		}

		// Token: 0x06007352 RID: 29522 RVA: 0x000A53AB File Offset: 0x000A35AB
		static UAssetManagerSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AssetManagerSettings");
		}

		// Token: 0x06007353 RID: 29523 RVA: 0x000A53B9 File Offset: 0x000A35B9
		protected UAssetManagerSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003761 RID: 14177
		public new const string __ObjectPath = "/Script/Engine.AssetManagerSettings";

		// Token: 0x04003762 RID: 14178
		private static IntPtr _ClassPtr;

		// Token: 0x04003763 RID: 14179
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003764 RID: 14180
		internal static int __PropertyOffset_PrimaryAssetTypesToScan;

		// Token: 0x04003765 RID: 14181
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPrimaryAssetTypeInfo> _PrimaryAssetTypesToScan;

		// Token: 0x04003766 RID: 14182
		internal static int __PropertyOffset_DirectoriesToExclude;

		// Token: 0x04003767 RID: 14183
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FDirectoryPath> _DirectoriesToExclude;

		// Token: 0x04003768 RID: 14184
		internal static int __PropertyOffset_PrimaryAssetRules;

		// Token: 0x04003769 RID: 14185
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPrimaryAssetRulesOverride> _PrimaryAssetRules;

		// Token: 0x0400376A RID: 14186
		internal static int __PropertyOffset_CustomPrimaryAssetRules;

		// Token: 0x0400376B RID: 14187
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPrimaryAssetRulesCustomOverride> _CustomPrimaryAssetRules;

		// Token: 0x0400376C RID: 14188
		internal static int __PropertyOffset_bOnlyCookProductionAssets;

		// Token: 0x0400376D RID: 14189
		internal static int __PropertyOffset_bShouldManagerDetermineTypeAndName;

		// Token: 0x0400376E RID: 14190
		internal static int __PropertyOffset_bShouldGuessTypeAndNameInEditor;

		// Token: 0x0400376F RID: 14191
		internal static int __PropertyOffset_bShouldAcquireMissingChunksOnLoad;

		// Token: 0x04003770 RID: 14192
		internal static int __PropertyOffset_PrimaryAssetIdRedirects;

		// Token: 0x04003771 RID: 14193
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAssetManagerRedirect> _PrimaryAssetIdRedirects;

		// Token: 0x04003772 RID: 14194
		internal static int __PropertyOffset_PrimaryAssetTypeRedirects;

		// Token: 0x04003773 RID: 14195
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAssetManagerRedirect> _PrimaryAssetTypeRedirects;

		// Token: 0x04003774 RID: 14196
		internal static int __PropertyOffset_AssetPathRedirects;

		// Token: 0x04003775 RID: 14197
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAssetManagerRedirect> _AssetPathRedirects;

		// Token: 0x04003776 RID: 14198
		internal static int __PropertyOffset_MetaDataTagsForAssetRegistry;

		// Token: 0x04003777 RID: 14199
		[Nullable(2)]
		private TSet<FName> _MetaDataTagsForAssetRegistry;
	}
}
