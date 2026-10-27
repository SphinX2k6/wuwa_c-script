using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013E8 RID: 5096
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayTags.GameplayTagsSettings")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UGameplayTagsSettings : UGameplayTagsList, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012A00 RID: 76288 RVA: 0x001B6807 File Offset: 0x001B4A07
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameplayTagsSettings._ClassPtr;
		}

		// Token: 0x06012A01 RID: 76289 RVA: 0x001B6814 File Offset: 0x001B4A14
		public UGameplayTagsSettings() : this(BuiltinUtils.AllocNativeUObject(UGameplayTagsSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012A02 RID: 76290 RVA: 0x001B683C File Offset: 0x001B4A3C
		public UGameplayTagsSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGameplayTagsSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700482F RID: 18479
		// (get) Token: 0x06012A03 RID: 76291 RVA: 0x001B686F File Offset: 0x001B4A6F
		// (set) Token: 0x06012A04 RID: 76292 RVA: 0x001B687F File Offset: 0x001B4A7F
		public unsafe bool ImportTagsFromConfig
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameplayTagsSettings.__PropertyOffset_ImportTagsFromConfig) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayTagsSettings.__PropertyOffset_ImportTagsFromConfig) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004830 RID: 18480
		// (get) Token: 0x06012A05 RID: 76293 RVA: 0x001B6890 File Offset: 0x001B4A90
		// (set) Token: 0x06012A06 RID: 76294 RVA: 0x001B68A0 File Offset: 0x001B4AA0
		public unsafe bool WarnOnInvalidTags
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameplayTagsSettings.__PropertyOffset_WarnOnInvalidTags) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayTagsSettings.__PropertyOffset_WarnOnInvalidTags) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004831 RID: 18481
		// (get) Token: 0x06012A07 RID: 76295 RVA: 0x001B68B1 File Offset: 0x001B4AB1
		// (set) Token: 0x06012A08 RID: 76296 RVA: 0x001B68C1 File Offset: 0x001B4AC1
		public unsafe bool FastReplication
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameplayTagsSettings.__PropertyOffset_FastReplication) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayTagsSettings.__PropertyOffset_FastReplication) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004832 RID: 18482
		// (get) Token: 0x06012A09 RID: 76297 RVA: 0x001B68D2 File Offset: 0x001B4AD2
		// (set) Token: 0x06012A0A RID: 76298 RVA: 0x001B68E6 File Offset: 0x001B4AE6
		public unsafe string InvalidTagCharacters
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UGameplayTagsSettings.__PropertyOffset_InvalidTagCharacters)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UGameplayTagsSettings.__PropertyOffset_InvalidTagCharacters)), value);
			}
		}

		// Token: 0x17004833 RID: 18483
		// (get) Token: 0x06012A0B RID: 76299 RVA: 0x001B68FC File Offset: 0x001B4AFC
		// (set) Token: 0x06012A0C RID: 76300 RVA: 0x001B6935 File Offset: 0x001B4B35
		public TArray<FGameplayTagCategoryRemap> CategoryRemapping
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTagCategoryRemap> result;
				if ((result = this._CategoryRemapping) == null)
				{
					result = (this._CategoryRemapping = new TArray<FGameplayTagCategoryRemap>(base.NativePtr + (IntPtr)UGameplayTagsSettings.__PropertyOffset_CategoryRemapping, this));
				}
				return result;
			}
			set
			{
				this.CategoryRemapping.CopyAssign(value);
			}
		}

		// Token: 0x17004834 RID: 18484
		// (get) Token: 0x06012A0D RID: 76301 RVA: 0x001B6944 File Offset: 0x001B4B44
		// (set) Token: 0x06012A0E RID: 76302 RVA: 0x001B697D File Offset: 0x001B4B7D
		public TArray<FSoftObjectPath> GameplayTagTableList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSoftObjectPath> result;
				if ((result = this._GameplayTagTableList) == null)
				{
					result = (this._GameplayTagTableList = new TArray<FSoftObjectPath>(base.NativePtr + (IntPtr)UGameplayTagsSettings.__PropertyOffset_GameplayTagTableList, this));
				}
				return result;
			}
			set
			{
				this.GameplayTagTableList.CopyAssign(value);
			}
		}

		// Token: 0x17004835 RID: 18485
		// (get) Token: 0x06012A0F RID: 76303 RVA: 0x001B698C File Offset: 0x001B4B8C
		// (set) Token: 0x06012A10 RID: 76304 RVA: 0x001B69C5 File Offset: 0x001B4BC5
		public TArray<FGameplayTagRedirect> GameplayTagRedirects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTagRedirect> result;
				if ((result = this._GameplayTagRedirects) == null)
				{
					result = (this._GameplayTagRedirects = new TArray<FGameplayTagRedirect>(base.NativePtr + (IntPtr)UGameplayTagsSettings.__PropertyOffset_GameplayTagRedirects, this));
				}
				return result;
			}
			set
			{
				this.GameplayTagRedirects.CopyAssign(value);
			}
		}

		// Token: 0x17004836 RID: 18486
		// (get) Token: 0x06012A11 RID: 76305 RVA: 0x001B69D4 File Offset: 0x001B4BD4
		// (set) Token: 0x06012A12 RID: 76306 RVA: 0x001B6A0D File Offset: 0x001B4C0D
		public TArray<FName> CommonlyReplicatedTags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._CommonlyReplicatedTags) == null)
				{
					result = (this._CommonlyReplicatedTags = new TArray<FName>(base.NativePtr + (IntPtr)UGameplayTagsSettings.__PropertyOffset_CommonlyReplicatedTags, this));
				}
				return result;
			}
			set
			{
				this.CommonlyReplicatedTags.CopyAssign(value);
			}
		}

		// Token: 0x17004837 RID: 18487
		// (get) Token: 0x06012A13 RID: 76307 RVA: 0x001B6A1B File Offset: 0x001B4C1B
		// (set) Token: 0x06012A14 RID: 76308 RVA: 0x001B6A2B File Offset: 0x001B4C2B
		public unsafe int NumBitsForContainerSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameplayTagsSettings.__PropertyOffset_NumBitsForContainerSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayTagsSettings.__PropertyOffset_NumBitsForContainerSize) = value;
			}
		}

		// Token: 0x17004838 RID: 18488
		// (get) Token: 0x06012A15 RID: 76309 RVA: 0x001B6A3C File Offset: 0x001B4C3C
		// (set) Token: 0x06012A16 RID: 76310 RVA: 0x001B6A4C File Offset: 0x001B4C4C
		public unsafe int NetIndexFirstBitSegment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameplayTagsSettings.__PropertyOffset_NetIndexFirstBitSegment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayTagsSettings.__PropertyOffset_NetIndexFirstBitSegment) = value;
			}
		}

		// Token: 0x17004839 RID: 18489
		// (get) Token: 0x06012A17 RID: 76311 RVA: 0x001B6A60 File Offset: 0x001B4C60
		// (set) Token: 0x06012A18 RID: 76312 RVA: 0x001B6A99 File Offset: 0x001B4C99
		public TArray<FRestrictedConfigInfo> RestrictedConfigFiles
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRestrictedConfigInfo> result;
				if ((result = this._RestrictedConfigFiles) == null)
				{
					result = (this._RestrictedConfigFiles = new TArray<FRestrictedConfigInfo>(base.NativePtr + (IntPtr)UGameplayTagsSettings.__PropertyOffset_RestrictedConfigFiles, this));
				}
				return result;
			}
			set
			{
				this.RestrictedConfigFiles.CopyAssign(value);
			}
		}

		// Token: 0x06012A19 RID: 76313 RVA: 0x001B6AA7 File Offset: 0x001B4CA7
		static UGameplayTagsSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayTags.GameplayTagsSettings");
		}

		// Token: 0x06012A1A RID: 76314 RVA: 0x001B6AB5 File Offset: 0x001B4CB5
		protected UGameplayTagsSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009F35 RID: 40757
		public new const string __ObjectPath = "/Script/GameplayTags.GameplayTagsSettings";

		// Token: 0x04009F36 RID: 40758
		private static IntPtr _ClassPtr;

		// Token: 0x04009F37 RID: 40759
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009F38 RID: 40760
		internal static int __PropertyOffset_ImportTagsFromConfig;

		// Token: 0x04009F39 RID: 40761
		internal static int __PropertyOffset_WarnOnInvalidTags;

		// Token: 0x04009F3A RID: 40762
		internal static int __PropertyOffset_FastReplication;

		// Token: 0x04009F3B RID: 40763
		internal static int __PropertyOffset_InvalidTagCharacters;

		// Token: 0x04009F3C RID: 40764
		internal static int __PropertyOffset_CategoryRemapping;

		// Token: 0x04009F3D RID: 40765
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FGameplayTagCategoryRemap> _CategoryRemapping;

		// Token: 0x04009F3E RID: 40766
		internal static int __PropertyOffset_GameplayTagTableList;

		// Token: 0x04009F3F RID: 40767
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoftObjectPath> _GameplayTagTableList;

		// Token: 0x04009F40 RID: 40768
		internal static int __PropertyOffset_GameplayTagRedirects;

		// Token: 0x04009F41 RID: 40769
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FGameplayTagRedirect> _GameplayTagRedirects;

		// Token: 0x04009F42 RID: 40770
		internal static int __PropertyOffset_CommonlyReplicatedTags;

		// Token: 0x04009F43 RID: 40771
		[Nullable(2)]
		private TArray<FName> _CommonlyReplicatedTags;

		// Token: 0x04009F44 RID: 40772
		internal static int __PropertyOffset_NumBitsForContainerSize;

		// Token: 0x04009F45 RID: 40773
		internal static int __PropertyOffset_NetIndexFirstBitSegment;

		// Token: 0x04009F46 RID: 40774
		internal static int __PropertyOffset_RestrictedConfigFiles;

		// Token: 0x04009F47 RID: 40775
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRestrictedConfigInfo> _RestrictedConfigFiles;
	}
}
