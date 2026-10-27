using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D0B RID: 3339
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KuroResourceFolderCheckConfigArray")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 224)]
	public class FKuroResourceFolderCheckConfigArray : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B248 RID: 45640 RVA: 0x000FD954 File Offset: 0x000FBB54
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroResourceFolderCheckConfigArray._ScriptStructPtr != 0) ? FKuroResourceFolderCheckConfigArray._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroResourceFolderCheckConfigArray", ref FKuroResourceFolderCheckConfigArray._ScriptStructPtr);
		}

		// Token: 0x1700288F RID: 10383
		// (get) Token: 0x0600B249 RID: 45641 RVA: 0x000FD978 File Offset: 0x000FBB78
		// (set) Token: 0x0600B24A RID: 45642 RVA: 0x000FD9BB File Offset: 0x000FBBBB
		public TArray<FKuroResourceFolderCheckConfig> AllFolderCheckConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroResourceFolderCheckConfig> result;
				if ((result = this._AllFolderCheckConfig) == null)
				{
					result = (this._AllFolderCheckConfig = new TArray<FKuroResourceFolderCheckConfig>(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfigArray.__PropertyOffset_AllFolderCheckConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AllFolderCheckConfig.CopyAssign(value);
			}
		}

		// Token: 0x17002890 RID: 10384
		// (get) Token: 0x0600B24B RID: 45643 RVA: 0x000FD9CC File Offset: 0x000FBBCC
		// (set) Token: 0x0600B24C RID: 45644 RVA: 0x000FDA0F File Offset: 0x000FBC0F
		public TArray<FKuroAssetVersionOriginData> AssetVersionOriginData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroAssetVersionOriginData> result;
				if ((result = this._AssetVersionOriginData) == null)
				{
					result = (this._AssetVersionOriginData = new TArray<FKuroAssetVersionOriginData>(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfigArray.__PropertyOffset_AssetVersionOriginData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AssetVersionOriginData.CopyAssign(value);
			}
		}

		// Token: 0x17002891 RID: 10385
		// (get) Token: 0x0600B24D RID: 45645 RVA: 0x000FDA20 File Offset: 0x000FBC20
		// (set) Token: 0x0600B24E RID: 45646 RVA: 0x000FDA63 File Offset: 0x000FBC63
		public FDefaultKuroAssetVersion DefaultKuroAssetVersion
		{
			get
			{
				base.FastCheckIsValid();
				FDefaultKuroAssetVersion result;
				if ((result = this._DefaultKuroAssetVersion) == null)
				{
					result = (this._DefaultKuroAssetVersion = new FDefaultKuroAssetVersion(base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfigArray.__PropertyOffset_DefaultKuroAssetVersion, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDefaultKuroAssetVersion.StaticStruct(), base.NativePtr + (IntPtr)FKuroResourceFolderCheckConfigArray.__PropertyOffset_DefaultKuroAssetVersion, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600B24F RID: 45647 RVA: 0x000FDA84 File Offset: 0x000FBC84
		public FKuroResourceFolderCheckConfigArray()
		{
		}

		// Token: 0x0600B250 RID: 45648 RVA: 0x000FDA8C File Offset: 0x000FBC8C
		public FKuroResourceFolderCheckConfigArray(TArray<FKuroResourceFolderCheckConfig> AllFolderCheckConfig, TArray<FKuroAssetVersionOriginData> AssetVersionOriginData, FDefaultKuroAssetVersion DefaultKuroAssetVersion)
		{
			this.AllFolderCheckConfig = AllFolderCheckConfig;
			this.AssetVersionOriginData = AssetVersionOriginData;
			this.DefaultKuroAssetVersion = DefaultKuroAssetVersion;
		}

		// Token: 0x0600B251 RID: 45649 RVA: 0x000FDAA9 File Offset: 0x000FBCA9
		protected override IntPtr GetUStructPtr()
		{
			return FKuroResourceFolderCheckConfigArray.StaticStruct();
		}

		// Token: 0x0600B252 RID: 45650 RVA: 0x000FDAB5 File Offset: 0x000FBCB5
		[NullableContext(2)]
		public FKuroResourceFolderCheckConfigArray(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B253 RID: 45651 RVA: 0x000FDABF File Offset: 0x000FBCBF
		public FKuroResourceFolderCheckConfigArray(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B254 RID: 45652 RVA: 0x000FDACA File Offset: 0x000FBCCA
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroResourceFolderCheckConfigArray(Pointer, false, true);
		}

		// Token: 0x0600B255 RID: 45653 RVA: 0x000FDAD4 File Offset: 0x000FBCD4
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroResourceFolderCheckConfigArray(Pointer, MemoryOwner);
		}

		// Token: 0x04005D82 RID: 23938
		public const string __ObjectPath = "/Script/Engine.KuroResourceFolderCheckConfigArray";

		// Token: 0x04005D83 RID: 23939
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005D84 RID: 23940
		internal static int __PropertyOffset_AllFolderCheckConfig;

		// Token: 0x04005D85 RID: 23941
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroResourceFolderCheckConfig> _AllFolderCheckConfig;

		// Token: 0x04005D86 RID: 23942
		internal static int __PropertyOffset_AssetVersionOriginData;

		// Token: 0x04005D87 RID: 23943
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroAssetVersionOriginData> _AssetVersionOriginData;

		// Token: 0x04005D88 RID: 23944
		internal static int __PropertyOffset_DefaultKuroAssetVersion;

		// Token: 0x04005D89 RID: 23945
		[Nullable(2)]
		private FDefaultKuroAssetVersion _DefaultKuroAssetVersion;
	}
}
