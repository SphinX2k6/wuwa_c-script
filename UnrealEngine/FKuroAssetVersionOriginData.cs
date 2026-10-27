using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000CE1 RID: 3297
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KuroAssetVersionOriginData")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FKuroAssetVersionOriginData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600AED1 RID: 44753 RVA: 0x000F7FC5 File Offset: 0x000F61C5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroAssetVersionOriginData._ScriptStructPtr != 0) ? FKuroAssetVersionOriginData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroAssetVersionOriginData", ref FKuroAssetVersionOriginData._ScriptStructPtr);
		}

		// Token: 0x17002779 RID: 10105
		// (get) Token: 0x0600AED2 RID: 44754 RVA: 0x000F7FE9 File Offset: 0x000F61E9
		// (set) Token: 0x0600AED3 RID: 44755 RVA: 0x000F7FF9 File Offset: 0x000F61F9
		public unsafe float Version
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroAssetVersionOriginData.__PropertyOffset_Version);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroAssetVersionOriginData.__PropertyOffset_Version) = value;
			}
		}

		// Token: 0x1700277A RID: 10106
		// (get) Token: 0x0600AED4 RID: 44756 RVA: 0x000F800C File Offset: 0x000F620C
		// (set) Token: 0x0600AED5 RID: 44757 RVA: 0x000F804F File Offset: 0x000F624F
		public TArray<string> AssetFolderPath
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._AssetFolderPath) == null)
				{
					result = (this._AssetFolderPath = new TArray<string>(base.NativePtr + (IntPtr)FKuroAssetVersionOriginData.__PropertyOffset_AssetFolderPath, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AssetFolderPath.CopyAssign(value);
			}
		}

		// Token: 0x1700277B RID: 10107
		// (get) Token: 0x0600AED6 RID: 44758 RVA: 0x000F8060 File Offset: 0x000F6260
		// (set) Token: 0x0600AED7 RID: 44759 RVA: 0x000F80A3 File Offset: 0x000F62A3
		public TArray<string> AssetDevoteFolder
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._AssetDevoteFolder) == null)
				{
					result = (this._AssetDevoteFolder = new TArray<string>(base.NativePtr + (IntPtr)FKuroAssetVersionOriginData.__PropertyOffset_AssetDevoteFolder, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AssetDevoteFolder.CopyAssign(value);
			}
		}

		// Token: 0x1700277C RID: 10108
		// (get) Token: 0x0600AED8 RID: 44760 RVA: 0x000F80B4 File Offset: 0x000F62B4
		// (set) Token: 0x0600AED9 RID: 44761 RVA: 0x000F80F7 File Offset: 0x000F62F7
		public TArray<string> LevelVersionTag
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._LevelVersionTag) == null)
				{
					result = (this._LevelVersionTag = new TArray<string>(base.NativePtr + (IntPtr)FKuroAssetVersionOriginData.__PropertyOffset_LevelVersionTag, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LevelVersionTag.CopyAssign(value);
			}
		}

		// Token: 0x1700277D RID: 10109
		// (get) Token: 0x0600AEDA RID: 44762 RVA: 0x000F8105 File Offset: 0x000F6305
		// (set) Token: 0x0600AEDB RID: 44763 RVA: 0x000F811E File Offset: 0x000F631E
		public unsafe bool ActorMeshOverrideMatCheck
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroAssetVersionOriginData.__PropertyOffset_ActorMeshOverrideMatCheck) & FKuroAssetVersionOriginData.__PropertyMask_ActorMeshOverrideMatCheck) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroAssetVersionOriginData.__PropertyOffset_ActorMeshOverrideMatCheck) = ((*(base.NativePtr + (IntPtr)FKuroAssetVersionOriginData.__PropertyOffset_ActorMeshOverrideMatCheck) & ~FKuroAssetVersionOriginData.__PropertyMask_ActorMeshOverrideMatCheck) | (value ? FKuroAssetVersionOriginData.__PropertyMask_ActorMeshOverrideMatCheck : 0));
			}
		}

		// Token: 0x1700277E RID: 10110
		// (get) Token: 0x0600AEDC RID: 44764 RVA: 0x000F814E File Offset: 0x000F634E
		// (set) Token: 0x0600AEDD RID: 44765 RVA: 0x000F8167 File Offset: 0x000F6367
		public unsafe bool PlatformCorrectCheck
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroAssetVersionOriginData.__PropertyOffset_PlatformCorrectCheck) & FKuroAssetVersionOriginData.__PropertyMask_PlatformCorrectCheck) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroAssetVersionOriginData.__PropertyOffset_PlatformCorrectCheck) = ((*(base.NativePtr + (IntPtr)FKuroAssetVersionOriginData.__PropertyOffset_PlatformCorrectCheck) & ~FKuroAssetVersionOriginData.__PropertyMask_PlatformCorrectCheck) | (value ? FKuroAssetVersionOriginData.__PropertyMask_PlatformCorrectCheck : 0));
			}
		}

		// Token: 0x0600AEDE RID: 44766 RVA: 0x000F8197 File Offset: 0x000F6397
		public FKuroAssetVersionOriginData()
		{
		}

		// Token: 0x0600AEDF RID: 44767 RVA: 0x000F819F File Offset: 0x000F639F
		public FKuroAssetVersionOriginData(float Version, TArray<string> AssetFolderPath, TArray<string> AssetDevoteFolder, TArray<string> LevelVersionTag, bool ActorMeshOverrideMatCheck, bool PlatformCorrectCheck)
		{
			this.Version = Version;
			this.AssetFolderPath = AssetFolderPath;
			this.AssetDevoteFolder = AssetDevoteFolder;
			this.LevelVersionTag = LevelVersionTag;
			this.ActorMeshOverrideMatCheck = ActorMeshOverrideMatCheck;
			this.PlatformCorrectCheck = PlatformCorrectCheck;
		}

		// Token: 0x0600AEE0 RID: 44768 RVA: 0x000F81D4 File Offset: 0x000F63D4
		protected override IntPtr GetUStructPtr()
		{
			return FKuroAssetVersionOriginData.StaticStruct();
		}

		// Token: 0x0600AEE1 RID: 44769 RVA: 0x000F81E0 File Offset: 0x000F63E0
		[NullableContext(2)]
		public FKuroAssetVersionOriginData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AEE2 RID: 44770 RVA: 0x000F81EA File Offset: 0x000F63EA
		public FKuroAssetVersionOriginData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AEE3 RID: 44771 RVA: 0x000F81F5 File Offset: 0x000F63F5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroAssetVersionOriginData(Pointer, false, true);
		}

		// Token: 0x0600AEE4 RID: 44772 RVA: 0x000F81FF File Offset: 0x000F63FF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroAssetVersionOriginData(Pointer, MemoryOwner);
		}

		// Token: 0x04005B90 RID: 23440
		public const string __ObjectPath = "/Script/Engine.KuroAssetVersionOriginData";

		// Token: 0x04005B91 RID: 23441
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005B92 RID: 23442
		internal static int __PropertyOffset_Version;

		// Token: 0x04005B93 RID: 23443
		internal static int __PropertyOffset_AssetFolderPath;

		// Token: 0x04005B94 RID: 23444
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _AssetFolderPath;

		// Token: 0x04005B95 RID: 23445
		internal static int __PropertyOffset_AssetDevoteFolder;

		// Token: 0x04005B96 RID: 23446
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _AssetDevoteFolder;

		// Token: 0x04005B97 RID: 23447
		internal static int __PropertyOffset_LevelVersionTag;

		// Token: 0x04005B98 RID: 23448
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _LevelVersionTag;

		// Token: 0x04005B99 RID: 23449
		internal static int __PropertyOffset_ActorMeshOverrideMatCheck;

		// Token: 0x04005B9A RID: 23450
		internal static byte __PropertyMask_ActorMeshOverrideMatCheck;

		// Token: 0x04005B9B RID: 23451
		internal static int __PropertyOffset_PlatformCorrectCheck;

		// Token: 0x04005B9C RID: 23452
		internal static byte __PropertyMask_PlatformCorrectCheck;
	}
}
