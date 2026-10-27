using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000434 RID: 1076
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/BuildPatchServices.FileManifestData")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FFileManifestData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060039D7 RID: 14807 RVA: 0x00057A9B File Offset: 0x00055C9B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFileManifestData._ScriptStructPtr != 0) ? FFileManifestData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/BuildPatchServices.FileManifestData", ref FFileManifestData._ScriptStructPtr);
		}

		// Token: 0x17000DC2 RID: 3522
		// (get) Token: 0x060039D8 RID: 14808 RVA: 0x00057ABF File Offset: 0x00055CBF
		// (set) Token: 0x060039D9 RID: 14809 RVA: 0x00057AD3 File Offset: 0x00055CD3
		public unsafe string Filename
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FFileManifestData.__PropertyOffset_Filename)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FFileManifestData.__PropertyOffset_Filename)), value);
			}
		}

		// Token: 0x17000DC3 RID: 3523
		// (get) Token: 0x060039DA RID: 14810 RVA: 0x00057AE8 File Offset: 0x00055CE8
		// (set) Token: 0x060039DB RID: 14811 RVA: 0x00057B2B File Offset: 0x00055D2B
		public FSHAHashData FileHash
		{
			get
			{
				base.FastCheckIsValid();
				FSHAHashData result;
				if ((result = this._FileHash) == null)
				{
					result = (this._FileHash = new FSHAHashData(base.NativePtr + (IntPtr)FFileManifestData.__PropertyOffset_FileHash, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSHAHashData.StaticStruct(), base.NativePtr + (IntPtr)FFileManifestData.__PropertyOffset_FileHash, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000DC4 RID: 3524
		// (get) Token: 0x060039DC RID: 14812 RVA: 0x00057B4C File Offset: 0x00055D4C
		// (set) Token: 0x060039DD RID: 14813 RVA: 0x00057B8F File Offset: 0x00055D8F
		public TArray<FChunkPartData> FileChunkParts
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FChunkPartData> result;
				if ((result = this._FileChunkParts) == null)
				{
					result = (this._FileChunkParts = new TArray<FChunkPartData>(base.NativePtr + (IntPtr)FFileManifestData.__PropertyOffset_FileChunkParts, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FileChunkParts.CopyAssign(value);
			}
		}

		// Token: 0x17000DC5 RID: 3525
		// (get) Token: 0x060039DE RID: 14814 RVA: 0x00057BA0 File Offset: 0x00055DA0
		// (set) Token: 0x060039DF RID: 14815 RVA: 0x00057BE3 File Offset: 0x00055DE3
		public TArray<string> InstallTags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._InstallTags) == null)
				{
					result = (this._InstallTags = new TArray<string>(base.NativePtr + (IntPtr)FFileManifestData.__PropertyOffset_InstallTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.InstallTags.CopyAssign(value);
			}
		}

		// Token: 0x17000DC6 RID: 3526
		// (get) Token: 0x060039E0 RID: 14816 RVA: 0x00057BF1 File Offset: 0x00055DF1
		// (set) Token: 0x060039E1 RID: 14817 RVA: 0x00057C01 File Offset: 0x00055E01
		public unsafe bool bIsUnixExecutable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFileManifestData.__PropertyOffset_bIsUnixExecutable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFileManifestData.__PropertyOffset_bIsUnixExecutable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000DC7 RID: 3527
		// (get) Token: 0x060039E2 RID: 14818 RVA: 0x00057C12 File Offset: 0x00055E12
		// (set) Token: 0x060039E3 RID: 14819 RVA: 0x00057C26 File Offset: 0x00055E26
		public unsafe string SymlinkTarget
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FFileManifestData.__PropertyOffset_SymlinkTarget)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FFileManifestData.__PropertyOffset_SymlinkTarget)), value);
			}
		}

		// Token: 0x17000DC8 RID: 3528
		// (get) Token: 0x060039E4 RID: 14820 RVA: 0x00057C3B File Offset: 0x00055E3B
		// (set) Token: 0x060039E5 RID: 14821 RVA: 0x00057C4B File Offset: 0x00055E4B
		public unsafe bool bIsReadOnly
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFileManifestData.__PropertyOffset_bIsReadOnly) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFileManifestData.__PropertyOffset_bIsReadOnly) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000DC9 RID: 3529
		// (get) Token: 0x060039E6 RID: 14822 RVA: 0x00057C5C File Offset: 0x00055E5C
		// (set) Token: 0x060039E7 RID: 14823 RVA: 0x00057C6C File Offset: 0x00055E6C
		public unsafe bool bIsCompressed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFileManifestData.__PropertyOffset_bIsCompressed) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFileManifestData.__PropertyOffset_bIsCompressed) = (value ? 1 : 0);
			}
		}

		// Token: 0x060039E8 RID: 14824 RVA: 0x00057C7D File Offset: 0x00055E7D
		public FFileManifestData()
		{
		}

		// Token: 0x060039E9 RID: 14825 RVA: 0x00057C88 File Offset: 0x00055E88
		public FFileManifestData(string Filename, FSHAHashData FileHash, TArray<FChunkPartData> FileChunkParts, TArray<string> InstallTags, bool bIsUnixExecutable, string SymlinkTarget, bool bIsReadOnly, bool bIsCompressed)
		{
			this.Filename = Filename;
			this.FileHash = FileHash;
			this.FileChunkParts = FileChunkParts;
			this.InstallTags = InstallTags;
			this.bIsUnixExecutable = bIsUnixExecutable;
			this.SymlinkTarget = SymlinkTarget;
			this.bIsReadOnly = bIsReadOnly;
			this.bIsCompressed = bIsCompressed;
		}

		// Token: 0x060039EA RID: 14826 RVA: 0x00057CD8 File Offset: 0x00055ED8
		protected override IntPtr GetUStructPtr()
		{
			return FFileManifestData.StaticStruct();
		}

		// Token: 0x060039EB RID: 14827 RVA: 0x00057CE4 File Offset: 0x00055EE4
		[NullableContext(2)]
		public FFileManifestData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060039EC RID: 14828 RVA: 0x00057CEE File Offset: 0x00055EEE
		public FFileManifestData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060039ED RID: 14829 RVA: 0x00057CF9 File Offset: 0x00055EF9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFileManifestData(Pointer, false, true);
		}

		// Token: 0x060039EE RID: 14830 RVA: 0x00057D03 File Offset: 0x00055F03
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFileManifestData(Pointer, MemoryOwner);
		}

		// Token: 0x04001A5B RID: 6747
		public const string __ObjectPath = "/Script/BuildPatchServices.FileManifestData";

		// Token: 0x04001A5C RID: 6748
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001A5D RID: 6749
		internal static int __PropertyOffset_Filename;

		// Token: 0x04001A5E RID: 6750
		internal static int __PropertyOffset_FileHash;

		// Token: 0x04001A5F RID: 6751
		[Nullable(2)]
		private FSHAHashData _FileHash;

		// Token: 0x04001A60 RID: 6752
		internal static int __PropertyOffset_FileChunkParts;

		// Token: 0x04001A61 RID: 6753
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FChunkPartData> _FileChunkParts;

		// Token: 0x04001A62 RID: 6754
		internal static int __PropertyOffset_InstallTags;

		// Token: 0x04001A63 RID: 6755
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _InstallTags;

		// Token: 0x04001A64 RID: 6756
		internal static int __PropertyOffset_bIsUnixExecutable;

		// Token: 0x04001A65 RID: 6757
		internal static int __PropertyOffset_SymlinkTarget;

		// Token: 0x04001A66 RID: 6758
		internal static int __PropertyOffset_bIsReadOnly;

		// Token: 0x04001A67 RID: 6759
		internal static int __PropertyOffset_bIsCompressed;
	}
}
