using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001037 RID: 4151
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PrimaryAssetLabel")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UPrimaryAssetLabel : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600E978 RID: 59768 RVA: 0x0015ACD9 File Offset: 0x00158ED9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPrimaryAssetLabel._ClassPtr;
		}

		// Token: 0x0600E979 RID: 59769 RVA: 0x0015ACE8 File Offset: 0x00158EE8
		public UPrimaryAssetLabel() : this(BuiltinUtils.AllocNativeUObject(UPrimaryAssetLabel.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600E97A RID: 59770 RVA: 0x0015AD10 File Offset: 0x00158F10
		public UPrimaryAssetLabel(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPrimaryAssetLabel.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003887 RID: 14471
		// (get) Token: 0x0600E97B RID: 59771 RVA: 0x0015AD44 File Offset: 0x00158F44
		// (set) Token: 0x0600E97C RID: 59772 RVA: 0x0015AD7D File Offset: 0x00158F7D
		public FPrimaryAssetRules Rules
		{
			get
			{
				base.FastCheckIsValid();
				FPrimaryAssetRules result;
				if ((result = this._Rules) == null)
				{
					result = (this._Rules = new FPrimaryAssetRules(base.NativePtr + (IntPtr)UPrimaryAssetLabel.__PropertyOffset_Rules, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPrimaryAssetRules.StaticStruct(), base.NativePtr + (IntPtr)UPrimaryAssetLabel.__PropertyOffset_Rules, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003888 RID: 14472
		// (get) Token: 0x0600E97D RID: 59773 RVA: 0x0015AD9E File Offset: 0x00158F9E
		// (set) Token: 0x0600E97E RID: 59774 RVA: 0x0015ADB7 File Offset: 0x00158FB7
		public unsafe bool bLabelAssetsInMyDirectory
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimaryAssetLabel.__PropertyOffset_bLabelAssetsInMyDirectory) & UPrimaryAssetLabel.__PropertyMask_bLabelAssetsInMyDirectory) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimaryAssetLabel.__PropertyOffset_bLabelAssetsInMyDirectory) = ((*(base.NativePtr + (IntPtr)UPrimaryAssetLabel.__PropertyOffset_bLabelAssetsInMyDirectory) & ~UPrimaryAssetLabel.__PropertyMask_bLabelAssetsInMyDirectory) | (value ? UPrimaryAssetLabel.__PropertyMask_bLabelAssetsInMyDirectory : 0));
			}
		}

		// Token: 0x17003889 RID: 14473
		// (get) Token: 0x0600E97F RID: 59775 RVA: 0x0015ADE7 File Offset: 0x00158FE7
		// (set) Token: 0x0600E980 RID: 59776 RVA: 0x0015AE00 File Offset: 0x00159000
		public unsafe bool bIsRuntimeLabel
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPrimaryAssetLabel.__PropertyOffset_bIsRuntimeLabel) & UPrimaryAssetLabel.__PropertyMask_bIsRuntimeLabel) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPrimaryAssetLabel.__PropertyOffset_bIsRuntimeLabel) = ((*(base.NativePtr + (IntPtr)UPrimaryAssetLabel.__PropertyOffset_bIsRuntimeLabel) & ~UPrimaryAssetLabel.__PropertyMask_bIsRuntimeLabel) | (value ? UPrimaryAssetLabel.__PropertyMask_bIsRuntimeLabel : 0));
			}
		}

		// Token: 0x1700388A RID: 14474
		// (get) Token: 0x0600E981 RID: 59777 RVA: 0x0015AE30 File Offset: 0x00159030
		// (set) Token: 0x0600E982 RID: 59778 RVA: 0x0015AE69 File Offset: 0x00159069
		public TArray<TSoftObjectPtr<UObject>> ExplicitAssets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<TSoftObjectPtr<UObject>> result;
				if ((result = this._ExplicitAssets) == null)
				{
					result = (this._ExplicitAssets = new TArray<TSoftObjectPtr<UObject>>(base.NativePtr + (IntPtr)UPrimaryAssetLabel.__PropertyOffset_ExplicitAssets, this));
				}
				return result;
			}
			set
			{
				this.ExplicitAssets.CopyAssign(value);
			}
		}

		// Token: 0x1700388B RID: 14475
		// (get) Token: 0x0600E983 RID: 59779 RVA: 0x0015AE78 File Offset: 0x00159078
		// (set) Token: 0x0600E984 RID: 59780 RVA: 0x0015AEB1 File Offset: 0x001590B1
		public TArray<TSoftClassPtr<UObject>> ExplicitBlueprints
		{
			get
			{
				base.FastCheckIsValid();
				TArray<TSoftClassPtr<UObject>> result;
				if ((result = this._ExplicitBlueprints) == null)
				{
					result = (this._ExplicitBlueprints = new TArray<TSoftClassPtr<UObject>>(base.NativePtr + (IntPtr)UPrimaryAssetLabel.__PropertyOffset_ExplicitBlueprints, this));
				}
				return result;
			}
			set
			{
				this.ExplicitBlueprints.CopyAssign(value);
			}
		}

		// Token: 0x1700388C RID: 14476
		// (get) Token: 0x0600E985 RID: 59781 RVA: 0x0015AEC0 File Offset: 0x001590C0
		// (set) Token: 0x0600E986 RID: 59782 RVA: 0x0015AEF9 File Offset: 0x001590F9
		public FCollectionReference AssetCollection
		{
			get
			{
				base.FastCheckIsValid();
				FCollectionReference result;
				if ((result = this._AssetCollection) == null)
				{
					result = (this._AssetCollection = new FCollectionReference(base.NativePtr + (IntPtr)UPrimaryAssetLabel.__PropertyOffset_AssetCollection, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCollectionReference.StaticStruct(), base.NativePtr + (IntPtr)UPrimaryAssetLabel.__PropertyOffset_AssetCollection, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600E987 RID: 59783 RVA: 0x0015AF1A File Offset: 0x0015911A
		static UPrimaryAssetLabel()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PrimaryAssetLabel");
		}

		// Token: 0x0600E988 RID: 59784 RVA: 0x0015AF28 File Offset: 0x00159128
		protected UPrimaryAssetLabel(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007EBA RID: 32442
		public new const string __ObjectPath = "/Script/Engine.PrimaryAssetLabel";

		// Token: 0x04007EBB RID: 32443
		private static IntPtr _ClassPtr;

		// Token: 0x04007EBC RID: 32444
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007EBD RID: 32445
		internal static int __PropertyOffset_Rules;

		// Token: 0x04007EBE RID: 32446
		[Nullable(2)]
		private FPrimaryAssetRules _Rules;

		// Token: 0x04007EBF RID: 32447
		internal static int __PropertyOffset_bLabelAssetsInMyDirectory;

		// Token: 0x04007EC0 RID: 32448
		internal static byte __PropertyMask_bLabelAssetsInMyDirectory;

		// Token: 0x04007EC1 RID: 32449
		internal static int __PropertyOffset_bIsRuntimeLabel;

		// Token: 0x04007EC2 RID: 32450
		internal static byte __PropertyMask_bIsRuntimeLabel;

		// Token: 0x04007EC3 RID: 32451
		internal static int __PropertyOffset_ExplicitAssets;

		// Token: 0x04007EC4 RID: 32452
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TArray<TSoftObjectPtr<UObject>> _ExplicitAssets;

		// Token: 0x04007EC5 RID: 32453
		internal static int __PropertyOffset_ExplicitBlueprints;

		// Token: 0x04007EC6 RID: 32454
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TArray<TSoftClassPtr<UObject>> _ExplicitBlueprints;

		// Token: 0x04007EC7 RID: 32455
		internal static int __PropertyOffset_AssetCollection;

		// Token: 0x04007EC8 RID: 32456
		[Nullable(2)]
		private FCollectionReference _AssetCollection;
	}
}
