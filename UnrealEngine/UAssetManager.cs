using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000855 RID: 2133
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AssetManager")]
	[UnrealStructLayout(1288, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1288)]
	public class UAssetManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600730A RID: 29450 RVA: 0x000A4D42 File Offset: 0x000A2F42
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAssetManager._ClassPtr;
		}

		// Token: 0x0600730B RID: 29451 RVA: 0x000A4D50 File Offset: 0x000A2F50
		public UAssetManager() : this(BuiltinUtils.AllocNativeUObject(UAssetManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600730C RID: 29452 RVA: 0x000A4D78 File Offset: 0x000A2F78
		public UAssetManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAssetManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001B1A RID: 6938
		// (get) Token: 0x0600730D RID: 29453 RVA: 0x000A4DAC File Offset: 0x000A2FAC
		// (set) Token: 0x0600730E RID: 29454 RVA: 0x000A4DE5 File Offset: 0x000A2FE5
		public TArray<UObject> ObjectReferenceList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._ObjectReferenceList) == null)
				{
					result = (this._ObjectReferenceList = new TArray<UObject>(base.NativePtr + (IntPtr)UAssetManager.__PropertyOffset_ObjectReferenceList, this));
				}
				return result;
			}
			set
			{
				this.ObjectReferenceList.CopyAssign(value);
			}
		}

		// Token: 0x17001B1B RID: 6939
		// (get) Token: 0x0600730F RID: 29455 RVA: 0x000A4DF3 File Offset: 0x000A2FF3
		// (set) Token: 0x06007310 RID: 29456 RVA: 0x000A4E03 File Offset: 0x000A3003
		public unsafe bool bIsGlobalAsyncScanEnvironment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAssetManager.__PropertyOffset_bIsGlobalAsyncScanEnvironment) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAssetManager.__PropertyOffset_bIsGlobalAsyncScanEnvironment) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001B1C RID: 6940
		// (get) Token: 0x06007311 RID: 29457 RVA: 0x000A4E14 File Offset: 0x000A3014
		// (set) Token: 0x06007312 RID: 29458 RVA: 0x000A4E24 File Offset: 0x000A3024
		public unsafe bool bShouldGuessTypeAndName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAssetManager.__PropertyOffset_bShouldGuessTypeAndName) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAssetManager.__PropertyOffset_bShouldGuessTypeAndName) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001B1D RID: 6941
		// (get) Token: 0x06007313 RID: 29459 RVA: 0x000A4E35 File Offset: 0x000A3035
		// (set) Token: 0x06007314 RID: 29460 RVA: 0x000A4E45 File Offset: 0x000A3045
		public unsafe bool bShouldUseSynchronousLoad
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAssetManager.__PropertyOffset_bShouldUseSynchronousLoad) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAssetManager.__PropertyOffset_bShouldUseSynchronousLoad) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001B1E RID: 6942
		// (get) Token: 0x06007315 RID: 29461 RVA: 0x000A4E56 File Offset: 0x000A3056
		// (set) Token: 0x06007316 RID: 29462 RVA: 0x000A4E66 File Offset: 0x000A3066
		public unsafe bool bIsLoadingFromPakFiles
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAssetManager.__PropertyOffset_bIsLoadingFromPakFiles) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAssetManager.__PropertyOffset_bIsLoadingFromPakFiles) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001B1F RID: 6943
		// (get) Token: 0x06007317 RID: 29463 RVA: 0x000A4E77 File Offset: 0x000A3077
		// (set) Token: 0x06007318 RID: 29464 RVA: 0x000A4E87 File Offset: 0x000A3087
		public unsafe bool bShouldAcquireMissingChunksOnLoad
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAssetManager.__PropertyOffset_bShouldAcquireMissingChunksOnLoad) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAssetManager.__PropertyOffset_bShouldAcquireMissingChunksOnLoad) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001B20 RID: 6944
		// (get) Token: 0x06007319 RID: 29465 RVA: 0x000A4E98 File Offset: 0x000A3098
		// (set) Token: 0x0600731A RID: 29466 RVA: 0x000A4EA8 File Offset: 0x000A30A8
		public unsafe bool bOnlyCookProductionAssets
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAssetManager.__PropertyOffset_bOnlyCookProductionAssets) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAssetManager.__PropertyOffset_bOnlyCookProductionAssets) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001B21 RID: 6945
		// (get) Token: 0x0600731B RID: 29467 RVA: 0x000A4EB9 File Offset: 0x000A30B9
		// (set) Token: 0x0600731C RID: 29468 RVA: 0x000A4EC9 File Offset: 0x000A30C9
		public unsafe bool bIsBulkScanning
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAssetManager.__PropertyOffset_bIsBulkScanning) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAssetManager.__PropertyOffset_bIsBulkScanning) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001B22 RID: 6946
		// (get) Token: 0x0600731D RID: 29469 RVA: 0x000A4EDA File Offset: 0x000A30DA
		// (set) Token: 0x0600731E RID: 29470 RVA: 0x000A4EEA File Offset: 0x000A30EA
		public unsafe bool bIsPrimaryAssetDirectoryCurrent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAssetManager.__PropertyOffset_bIsPrimaryAssetDirectoryCurrent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAssetManager.__PropertyOffset_bIsPrimaryAssetDirectoryCurrent) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001B23 RID: 6947
		// (get) Token: 0x0600731F RID: 29471 RVA: 0x000A4EFB File Offset: 0x000A30FB
		// (set) Token: 0x06007320 RID: 29472 RVA: 0x000A4F0B File Offset: 0x000A310B
		public unsafe bool bIsManagementDatabaseCurrent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAssetManager.__PropertyOffset_bIsManagementDatabaseCurrent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAssetManager.__PropertyOffset_bIsManagementDatabaseCurrent) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001B24 RID: 6948
		// (get) Token: 0x06007321 RID: 29473 RVA: 0x000A4F1C File Offset: 0x000A311C
		// (set) Token: 0x06007322 RID: 29474 RVA: 0x000A4F2C File Offset: 0x000A312C
		public unsafe bool bUpdateManagementDatabaseAfterScan
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAssetManager.__PropertyOffset_bUpdateManagementDatabaseAfterScan) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAssetManager.__PropertyOffset_bUpdateManagementDatabaseAfterScan) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001B25 RID: 6949
		// (get) Token: 0x06007323 RID: 29475 RVA: 0x000A4F3D File Offset: 0x000A313D
		// (set) Token: 0x06007324 RID: 29476 RVA: 0x000A4F4D File Offset: 0x000A314D
		public unsafe bool bIncludeOnlyOnDiskAssets
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAssetManager.__PropertyOffset_bIncludeOnlyOnDiskAssets) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAssetManager.__PropertyOffset_bIncludeOnlyOnDiskAssets) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001B26 RID: 6950
		// (get) Token: 0x06007325 RID: 29477 RVA: 0x000A4F5E File Offset: 0x000A315E
		// (set) Token: 0x06007326 RID: 29478 RVA: 0x000A4F6E File Offset: 0x000A316E
		public unsafe bool bHasCompletedInitialScan
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAssetManager.__PropertyOffset_bHasCompletedInitialScan) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAssetManager.__PropertyOffset_bHasCompletedInitialScan) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001B27 RID: 6951
		// (get) Token: 0x06007327 RID: 29479 RVA: 0x000A4F7F File Offset: 0x000A317F
		// (set) Token: 0x06007328 RID: 29480 RVA: 0x000A4F8F File Offset: 0x000A318F
		public unsafe int NumberOfSpawnedNotifications
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAssetManager.__PropertyOffset_NumberOfSpawnedNotifications);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAssetManager.__PropertyOffset_NumberOfSpawnedNotifications) = value;
			}
		}

		// Token: 0x06007329 RID: 29481 RVA: 0x000A4FA0 File Offset: 0x000A31A0
		static UAssetManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AssetManager");
		}

		// Token: 0x0600732A RID: 29482 RVA: 0x000A4FAE File Offset: 0x000A31AE
		protected UAssetManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400374B RID: 14155
		public new const string __ObjectPath = "/Script/Engine.AssetManager";

		// Token: 0x0400374C RID: 14156
		private static IntPtr _ClassPtr;

		// Token: 0x0400374D RID: 14157
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400374E RID: 14158
		internal static int __PropertyOffset_ObjectReferenceList;

		// Token: 0x0400374F RID: 14159
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _ObjectReferenceList;

		// Token: 0x04003750 RID: 14160
		internal static int __PropertyOffset_bIsGlobalAsyncScanEnvironment;

		// Token: 0x04003751 RID: 14161
		internal static int __PropertyOffset_bShouldGuessTypeAndName;

		// Token: 0x04003752 RID: 14162
		internal static int __PropertyOffset_bShouldUseSynchronousLoad;

		// Token: 0x04003753 RID: 14163
		internal static int __PropertyOffset_bIsLoadingFromPakFiles;

		// Token: 0x04003754 RID: 14164
		internal static int __PropertyOffset_bShouldAcquireMissingChunksOnLoad;

		// Token: 0x04003755 RID: 14165
		internal static int __PropertyOffset_bOnlyCookProductionAssets;

		// Token: 0x04003756 RID: 14166
		internal static int __PropertyOffset_bIsBulkScanning;

		// Token: 0x04003757 RID: 14167
		internal static int __PropertyOffset_bIsPrimaryAssetDirectoryCurrent;

		// Token: 0x04003758 RID: 14168
		internal static int __PropertyOffset_bIsManagementDatabaseCurrent;

		// Token: 0x04003759 RID: 14169
		internal static int __PropertyOffset_bUpdateManagementDatabaseAfterScan;

		// Token: 0x0400375A RID: 14170
		internal static int __PropertyOffset_bIncludeOnlyOnDiskAssets;

		// Token: 0x0400375B RID: 14171
		internal static int __PropertyOffset_bHasCompletedInitialScan;

		// Token: 0x0400375C RID: 14172
		internal static int __PropertyOffset_NumberOfSpawnedNotifications;
	}
}
