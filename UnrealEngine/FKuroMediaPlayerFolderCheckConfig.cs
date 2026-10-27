using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000CF7 RID: 3319
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KuroMediaPlayerFolderCheckConfig")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 136)]
	public class FKuroMediaPlayerFolderCheckConfig : FKuroBaseFolderCheckConfig, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B02C RID: 45100 RVA: 0x000F9E8E File Offset: 0x000F808E
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMediaPlayerFolderCheckConfig._ScriptStructPtr != 0) ? FKuroMediaPlayerFolderCheckConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroMediaPlayerFolderCheckConfig", ref FKuroMediaPlayerFolderCheckConfig._ScriptStructPtr);
		}

		// Token: 0x170027D5 RID: 10197
		// (get) Token: 0x0600B02D RID: 45101 RVA: 0x000F9EB2 File Offset: 0x000F80B2
		// (set) Token: 0x0600B02E RID: 45102 RVA: 0x000F9EC6 File Offset: 0x000F80C6
		public unsafe string DAName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroMediaPlayerFolderCheckConfig.__PropertyOffset_DAName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroMediaPlayerFolderCheckConfig.__PropertyOffset_DAName)), value);
			}
		}

		// Token: 0x170027D6 RID: 10198
		// (get) Token: 0x0600B02F RID: 45103 RVA: 0x000F9EDC File Offset: 0x000F80DC
		// (set) Token: 0x0600B030 RID: 45104 RVA: 0x000F9F1F File Offset: 0x000F811F
		public TArray<string> StaticMeshPaths
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._StaticMeshPaths) == null)
				{
					result = (this._StaticMeshPaths = new TArray<string>(base.NativePtr + (IntPtr)FKuroMediaPlayerFolderCheckConfig.__PropertyOffset_StaticMeshPaths, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StaticMeshPaths.CopyAssign(value);
			}
		}

		// Token: 0x170027D7 RID: 10199
		// (get) Token: 0x0600B031 RID: 45105 RVA: 0x000F9F30 File Offset: 0x000F8130
		// (set) Token: 0x0600B032 RID: 45106 RVA: 0x000F9F73 File Offset: 0x000F8173
		public TArray<byte> MaterialIndexRange
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._MaterialIndexRange) == null)
				{
					result = (this._MaterialIndexRange = new TArray<byte>(base.NativePtr + (IntPtr)FKuroMediaPlayerFolderCheckConfig.__PropertyOffset_MaterialIndexRange, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MaterialIndexRange.CopyAssign(value);
			}
		}

		// Token: 0x170027D8 RID: 10200
		// (get) Token: 0x0600B033 RID: 45107 RVA: 0x000F9F81 File Offset: 0x000F8181
		// (set) Token: 0x0600B034 RID: 45108 RVA: 0x000F9F95 File Offset: 0x000F8195
		public unsafe string MediaPlayerPathName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroMediaPlayerFolderCheckConfig.__PropertyOffset_MediaPlayerPathName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroMediaPlayerFolderCheckConfig.__PropertyOffset_MediaPlayerPathName)), value);
			}
		}

		// Token: 0x170027D9 RID: 10201
		// (get) Token: 0x0600B035 RID: 45109 RVA: 0x000F9FAA File Offset: 0x000F81AA
		// (set) Token: 0x0600B036 RID: 45110 RVA: 0x000F9FBE File Offset: 0x000F81BE
		public unsafe string MediaTexturePathName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroMediaPlayerFolderCheckConfig.__PropertyOffset_MediaTexturePathName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroMediaPlayerFolderCheckConfig.__PropertyOffset_MediaTexturePathName)), value);
			}
		}

		// Token: 0x170027DA RID: 10202
		// (get) Token: 0x0600B037 RID: 45111 RVA: 0x000F9FD4 File Offset: 0x000F81D4
		// (set) Token: 0x0600B038 RID: 45112 RVA: 0x000FA017 File Offset: 0x000F8217
		public TArray<string> MediaSourcePaths
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._MediaSourcePaths) == null)
				{
					result = (this._MediaSourcePaths = new TArray<string>(base.NativePtr + (IntPtr)FKuroMediaPlayerFolderCheckConfig.__PropertyOffset_MediaSourcePaths, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MediaSourcePaths.CopyAssign(value);
			}
		}

		// Token: 0x170027DB RID: 10203
		// (get) Token: 0x0600B039 RID: 45113 RVA: 0x000FA025 File Offset: 0x000F8225
		// (set) Token: 0x0600B03A RID: 45114 RVA: 0x000FA039 File Offset: 0x000F8239
		public unsafe string MediaSourceName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroMediaPlayerFolderCheckConfig.__PropertyOffset_MediaSourceName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroMediaPlayerFolderCheckConfig.__PropertyOffset_MediaSourceName)), value);
			}
		}

		// Token: 0x0600B03B RID: 45115 RVA: 0x000FA04E File Offset: 0x000F824E
		public FKuroMediaPlayerFolderCheckConfig()
		{
		}

		// Token: 0x0600B03C RID: 45116 RVA: 0x000FA058 File Offset: 0x000F8258
		public FKuroMediaPlayerFolderCheckConfig(string DAName, TArray<string> StaticMeshPaths, TArray<byte> MaterialIndexRange, string MediaPlayerPathName, string MediaTexturePathName, TArray<string> MediaSourcePaths, string MediaSourceName, string Regex, int MatchingPriority)
		{
			this.DAName = DAName;
			this.StaticMeshPaths = StaticMeshPaths;
			this.MaterialIndexRange = MaterialIndexRange;
			this.MediaPlayerPathName = MediaPlayerPathName;
			this.MediaTexturePathName = MediaTexturePathName;
			this.MediaSourcePaths = MediaSourcePaths;
			this.MediaSourceName = MediaSourceName;
			base.Regex = Regex;
			base.MatchingPriority = MatchingPriority;
		}

		// Token: 0x0600B03D RID: 45117 RVA: 0x000FA0B0 File Offset: 0x000F82B0
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMediaPlayerFolderCheckConfig.StaticStruct();
		}

		// Token: 0x0600B03E RID: 45118 RVA: 0x000FA0BC File Offset: 0x000F82BC
		[NullableContext(2)]
		public FKuroMediaPlayerFolderCheckConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B03F RID: 45119 RVA: 0x000FA0C6 File Offset: 0x000F82C6
		public FKuroMediaPlayerFolderCheckConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B040 RID: 45120 RVA: 0x000FA0D1 File Offset: 0x000F82D1
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMediaPlayerFolderCheckConfig(Pointer, false, true);
		}

		// Token: 0x0600B041 RID: 45121 RVA: 0x000FA0DB File Offset: 0x000F82DB
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMediaPlayerFolderCheckConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04005C3D RID: 23613
		public new const string __ObjectPath = "/Script/Engine.KuroMediaPlayerFolderCheckConfig";

		// Token: 0x04005C3E RID: 23614
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005C3F RID: 23615
		internal static int __PropertyOffset_DAName;

		// Token: 0x04005C40 RID: 23616
		internal static int __PropertyOffset_StaticMeshPaths;

		// Token: 0x04005C41 RID: 23617
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _StaticMeshPaths;

		// Token: 0x04005C42 RID: 23618
		internal static int __PropertyOffset_MaterialIndexRange;

		// Token: 0x04005C43 RID: 23619
		[Nullable(2)]
		private TArray<byte> _MaterialIndexRange;

		// Token: 0x04005C44 RID: 23620
		internal static int __PropertyOffset_MediaPlayerPathName;

		// Token: 0x04005C45 RID: 23621
		internal static int __PropertyOffset_MediaTexturePathName;

		// Token: 0x04005C46 RID: 23622
		internal static int __PropertyOffset_MediaSourcePaths;

		// Token: 0x04005C47 RID: 23623
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _MediaSourcePaths;

		// Token: 0x04005C48 RID: 23624
		internal static int __PropertyOffset_MediaSourceName;
	}
}
