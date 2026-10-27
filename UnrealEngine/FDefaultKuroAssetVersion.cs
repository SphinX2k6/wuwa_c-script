using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009AD RID: 2477
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.DefaultKuroAssetVersion")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 192)]
	public class FDefaultKuroAssetVersion : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008C1A RID: 35866 RVA: 0x000C887C File Offset: 0x000C6A7C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDefaultKuroAssetVersion._ScriptStructPtr != 0) ? FDefaultKuroAssetVersion._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.DefaultKuroAssetVersion", ref FDefaultKuroAssetVersion._ScriptStructPtr);
		}

		// Token: 0x170020F8 RID: 8440
		// (get) Token: 0x06008C1B RID: 35867 RVA: 0x000C88A0 File Offset: 0x000C6AA0
		// (set) Token: 0x06008C1C RID: 35868 RVA: 0x000C88E3 File Offset: 0x000C6AE3
		public FKuroAssetVersionOriginData DefaultAssetFolderPathVersion
		{
			get
			{
				base.FastCheckIsValid();
				FKuroAssetVersionOriginData result;
				if ((result = this._DefaultAssetFolderPathVersion) == null)
				{
					result = (this._DefaultAssetFolderPathVersion = new FKuroAssetVersionOriginData(base.NativePtr + (IntPtr)FDefaultKuroAssetVersion.__PropertyOffset_DefaultAssetFolderPathVersion, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroAssetVersionOriginData.StaticStruct(), base.NativePtr + (IntPtr)FDefaultKuroAssetVersion.__PropertyOffset_DefaultAssetFolderPathVersion, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170020F9 RID: 8441
		// (get) Token: 0x06008C1D RID: 35869 RVA: 0x000C8904 File Offset: 0x000C6B04
		// (set) Token: 0x06008C1E RID: 35870 RVA: 0x000C8947 File Offset: 0x000C6B47
		public FKuroAssetVersionOriginData DefaultAssetDevoteFolderVersion
		{
			get
			{
				base.FastCheckIsValid();
				FKuroAssetVersionOriginData result;
				if ((result = this._DefaultAssetDevoteFolderVersion) == null)
				{
					result = (this._DefaultAssetDevoteFolderVersion = new FKuroAssetVersionOriginData(base.NativePtr + (IntPtr)FDefaultKuroAssetVersion.__PropertyOffset_DefaultAssetDevoteFolderVersion, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroAssetVersionOriginData.StaticStruct(), base.NativePtr + (IntPtr)FDefaultKuroAssetVersion.__PropertyOffset_DefaultAssetDevoteFolderVersion, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170020FA RID: 8442
		// (get) Token: 0x06008C1F RID: 35871 RVA: 0x000C8968 File Offset: 0x000C6B68
		// (set) Token: 0x06008C20 RID: 35872 RVA: 0x000C89AB File Offset: 0x000C6BAB
		public FKuroAssetVersionOriginData DefaultLevelVersionTagVersion
		{
			get
			{
				base.FastCheckIsValid();
				FKuroAssetVersionOriginData result;
				if ((result = this._DefaultLevelVersionTagVersion) == null)
				{
					result = (this._DefaultLevelVersionTagVersion = new FKuroAssetVersionOriginData(base.NativePtr + (IntPtr)FDefaultKuroAssetVersion.__PropertyOffset_DefaultLevelVersionTagVersion, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroAssetVersionOriginData.StaticStruct(), base.NativePtr + (IntPtr)FDefaultKuroAssetVersion.__PropertyOffset_DefaultLevelVersionTagVersion, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06008C21 RID: 35873 RVA: 0x000C89CC File Offset: 0x000C6BCC
		public FDefaultKuroAssetVersion()
		{
		}

		// Token: 0x06008C22 RID: 35874 RVA: 0x000C89D4 File Offset: 0x000C6BD4
		public FDefaultKuroAssetVersion(FKuroAssetVersionOriginData DefaultAssetFolderPathVersion, FKuroAssetVersionOriginData DefaultAssetDevoteFolderVersion, FKuroAssetVersionOriginData DefaultLevelVersionTagVersion)
		{
			this.DefaultAssetFolderPathVersion = DefaultAssetFolderPathVersion;
			this.DefaultAssetDevoteFolderVersion = DefaultAssetDevoteFolderVersion;
			this.DefaultLevelVersionTagVersion = DefaultLevelVersionTagVersion;
		}

		// Token: 0x06008C23 RID: 35875 RVA: 0x000C89F1 File Offset: 0x000C6BF1
		protected override IntPtr GetUStructPtr()
		{
			return FDefaultKuroAssetVersion.StaticStruct();
		}

		// Token: 0x06008C24 RID: 35876 RVA: 0x000C89FD File Offset: 0x000C6BFD
		[NullableContext(2)]
		public FDefaultKuroAssetVersion(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008C25 RID: 35877 RVA: 0x000C8A07 File Offset: 0x000C6C07
		public FDefaultKuroAssetVersion(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008C26 RID: 35878 RVA: 0x000C8A12 File Offset: 0x000C6C12
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDefaultKuroAssetVersion(Pointer, false, true);
		}

		// Token: 0x06008C27 RID: 35879 RVA: 0x000C8A1C File Offset: 0x000C6C1C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDefaultKuroAssetVersion(Pointer, MemoryOwner);
		}

		// Token: 0x04004280 RID: 17024
		public const string __ObjectPath = "/Script/Engine.DefaultKuroAssetVersion";

		// Token: 0x04004281 RID: 17025
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004282 RID: 17026
		internal static int __PropertyOffset_DefaultAssetFolderPathVersion;

		// Token: 0x04004283 RID: 17027
		[Nullable(2)]
		private FKuroAssetVersionOriginData _DefaultAssetFolderPathVersion;

		// Token: 0x04004284 RID: 17028
		internal static int __PropertyOffset_DefaultAssetDevoteFolderVersion;

		// Token: 0x04004285 RID: 17029
		[Nullable(2)]
		private FKuroAssetVersionOriginData _DefaultAssetDevoteFolderVersion;

		// Token: 0x04004286 RID: 17030
		internal static int __PropertyOffset_DefaultLevelVersionTagVersion;

		// Token: 0x04004287 RID: 17031
		[Nullable(2)]
		private FKuroAssetVersionOriginData _DefaultLevelVersionTagVersion;
	}
}
