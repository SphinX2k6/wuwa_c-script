using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D12 RID: 3346
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KuroStreamingGroupConfig")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 136)]
	public class FKuroStreamingGroupConfig : FKuroBaseFolderCheckConfig, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B2F9 RID: 45817 RVA: 0x000FEEB0 File Offset: 0x000FD0B0
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroStreamingGroupConfig._ScriptStructPtr != 0) ? FKuroStreamingGroupConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroStreamingGroupConfig", ref FKuroStreamingGroupConfig._ScriptStructPtr);
		}

		// Token: 0x170028CC RID: 10444
		// (get) Token: 0x0600B2FA RID: 45818 RVA: 0x000FEED4 File Offset: 0x000FD0D4
		// (set) Token: 0x0600B2FB RID: 45819 RVA: 0x000FEF17 File Offset: 0x000FD117
		public TArray<string> TextureStreamingGroups
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._TextureStreamingGroups) == null)
				{
					result = (this._TextureStreamingGroups = new TArray<string>(base.NativePtr + (IntPtr)FKuroStreamingGroupConfig.__PropertyOffset_TextureStreamingGroups, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TextureStreamingGroups.CopyAssign(value);
			}
		}

		// Token: 0x170028CD RID: 10445
		// (get) Token: 0x0600B2FC RID: 45820 RVA: 0x000FEF28 File Offset: 0x000FD128
		// (set) Token: 0x0600B2FD RID: 45821 RVA: 0x000FEF6B File Offset: 0x000FD16B
		public TArray<int> TextureMinSizes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._TextureMinSizes) == null)
				{
					result = (this._TextureMinSizes = new TArray<int>(base.NativePtr + (IntPtr)FKuroStreamingGroupConfig.__PropertyOffset_TextureMinSizes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TextureMinSizes.CopyAssign(value);
			}
		}

		// Token: 0x170028CE RID: 10446
		// (get) Token: 0x0600B2FE RID: 45822 RVA: 0x000FEF7C File Offset: 0x000FD17C
		// (set) Token: 0x0600B2FF RID: 45823 RVA: 0x000FEFBF File Offset: 0x000FD1BF
		public TArray<int> TextureMobileMinSizes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._TextureMobileMinSizes) == null)
				{
					result = (this._TextureMobileMinSizes = new TArray<int>(base.NativePtr + (IntPtr)FKuroStreamingGroupConfig.__PropertyOffset_TextureMobileMinSizes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TextureMobileMinSizes.CopyAssign(value);
			}
		}

		// Token: 0x170028CF RID: 10447
		// (get) Token: 0x0600B300 RID: 45824 RVA: 0x000FEFD0 File Offset: 0x000FD1D0
		// (set) Token: 0x0600B301 RID: 45825 RVA: 0x000FF013 File Offset: 0x000FD213
		public TArray<string> SkeletalMeshStreamingGroups
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._SkeletalMeshStreamingGroups) == null)
				{
					result = (this._SkeletalMeshStreamingGroups = new TArray<string>(base.NativePtr + (IntPtr)FKuroStreamingGroupConfig.__PropertyOffset_SkeletalMeshStreamingGroups, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SkeletalMeshStreamingGroups.CopyAssign(value);
			}
		}

		// Token: 0x170028D0 RID: 10448
		// (get) Token: 0x0600B302 RID: 45826 RVA: 0x000FF024 File Offset: 0x000FD224
		// (set) Token: 0x0600B303 RID: 45827 RVA: 0x000FF067 File Offset: 0x000FD267
		public TArray<int> SkeletalMeshBoundMinSizes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._SkeletalMeshBoundMinSizes) == null)
				{
					result = (this._SkeletalMeshBoundMinSizes = new TArray<int>(base.NativePtr + (IntPtr)FKuroStreamingGroupConfig.__PropertyOffset_SkeletalMeshBoundMinSizes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SkeletalMeshBoundMinSizes.CopyAssign(value);
			}
		}

		// Token: 0x170028D1 RID: 10449
		// (get) Token: 0x0600B304 RID: 45828 RVA: 0x000FF078 File Offset: 0x000FD278
		// (set) Token: 0x0600B305 RID: 45829 RVA: 0x000FF0BB File Offset: 0x000FD2BB
		public TArray<string> StaticMeshStreamingGroups
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._StaticMeshStreamingGroups) == null)
				{
					result = (this._StaticMeshStreamingGroups = new TArray<string>(base.NativePtr + (IntPtr)FKuroStreamingGroupConfig.__PropertyOffset_StaticMeshStreamingGroups, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StaticMeshStreamingGroups.CopyAssign(value);
			}
		}

		// Token: 0x170028D2 RID: 10450
		// (get) Token: 0x0600B306 RID: 45830 RVA: 0x000FF0CC File Offset: 0x000FD2CC
		// (set) Token: 0x0600B307 RID: 45831 RVA: 0x000FF10F File Offset: 0x000FD30F
		public TArray<int> StaticMeshBoundMinSizes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._StaticMeshBoundMinSizes) == null)
				{
					result = (this._StaticMeshBoundMinSizes = new TArray<int>(base.NativePtr + (IntPtr)FKuroStreamingGroupConfig.__PropertyOffset_StaticMeshBoundMinSizes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StaticMeshBoundMinSizes.CopyAssign(value);
			}
		}

		// Token: 0x0600B308 RID: 45832 RVA: 0x000FF11D File Offset: 0x000FD31D
		public FKuroStreamingGroupConfig()
		{
		}

		// Token: 0x0600B309 RID: 45833 RVA: 0x000FF128 File Offset: 0x000FD328
		public FKuroStreamingGroupConfig(TArray<string> TextureStreamingGroups, TArray<int> TextureMinSizes, TArray<int> TextureMobileMinSizes, TArray<string> SkeletalMeshStreamingGroups, TArray<int> SkeletalMeshBoundMinSizes, TArray<string> StaticMeshStreamingGroups, TArray<int> StaticMeshBoundMinSizes, string Regex, int MatchingPriority)
		{
			this.TextureStreamingGroups = TextureStreamingGroups;
			this.TextureMinSizes = TextureMinSizes;
			this.TextureMobileMinSizes = TextureMobileMinSizes;
			this.SkeletalMeshStreamingGroups = SkeletalMeshStreamingGroups;
			this.SkeletalMeshBoundMinSizes = SkeletalMeshBoundMinSizes;
			this.StaticMeshStreamingGroups = StaticMeshStreamingGroups;
			this.StaticMeshBoundMinSizes = StaticMeshBoundMinSizes;
			base.Regex = Regex;
			base.MatchingPriority = MatchingPriority;
		}

		// Token: 0x0600B30A RID: 45834 RVA: 0x000FF180 File Offset: 0x000FD380
		protected override IntPtr GetUStructPtr()
		{
			return FKuroStreamingGroupConfig.StaticStruct();
		}

		// Token: 0x0600B30B RID: 45835 RVA: 0x000FF18C File Offset: 0x000FD38C
		[NullableContext(2)]
		public FKuroStreamingGroupConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B30C RID: 45836 RVA: 0x000FF196 File Offset: 0x000FD396
		public FKuroStreamingGroupConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B30D RID: 45837 RVA: 0x000FF1A1 File Offset: 0x000FD3A1
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroStreamingGroupConfig(Pointer, false, true);
		}

		// Token: 0x0600B30E RID: 45838 RVA: 0x000FF1AB File Offset: 0x000FD3AB
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroStreamingGroupConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04005DF7 RID: 24055
		public new const string __ObjectPath = "/Script/Engine.KuroStreamingGroupConfig";

		// Token: 0x04005DF8 RID: 24056
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005DF9 RID: 24057
		internal static int __PropertyOffset_TextureStreamingGroups;

		// Token: 0x04005DFA RID: 24058
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _TextureStreamingGroups;

		// Token: 0x04005DFB RID: 24059
		internal static int __PropertyOffset_TextureMinSizes;

		// Token: 0x04005DFC RID: 24060
		[Nullable(2)]
		private TArray<int> _TextureMinSizes;

		// Token: 0x04005DFD RID: 24061
		internal static int __PropertyOffset_TextureMobileMinSizes;

		// Token: 0x04005DFE RID: 24062
		[Nullable(2)]
		private TArray<int> _TextureMobileMinSizes;

		// Token: 0x04005DFF RID: 24063
		internal static int __PropertyOffset_SkeletalMeshStreamingGroups;

		// Token: 0x04005E00 RID: 24064
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _SkeletalMeshStreamingGroups;

		// Token: 0x04005E01 RID: 24065
		internal static int __PropertyOffset_SkeletalMeshBoundMinSizes;

		// Token: 0x04005E02 RID: 24066
		[Nullable(2)]
		private TArray<int> _SkeletalMeshBoundMinSizes;

		// Token: 0x04005E03 RID: 24067
		internal static int __PropertyOffset_StaticMeshStreamingGroups;

		// Token: 0x04005E04 RID: 24068
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _StaticMeshStreamingGroups;

		// Token: 0x04005E05 RID: 24069
		internal static int __PropertyOffset_StaticMeshBoundMinSizes;

		// Token: 0x04005E06 RID: 24070
		[Nullable(2)]
		private TArray<int> _StaticMeshBoundMinSizes;
	}
}
