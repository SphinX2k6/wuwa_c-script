using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000CF3 RID: 3315
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KuroMaterialInstFolderCheckConfig")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 184)]
	public class FKuroMaterialInstFolderCheckConfig : FKuroBaseFolderCheckConfig, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600AFEE RID: 45038 RVA: 0x000F9785 File Offset: 0x000F7985
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialInstFolderCheckConfig._ScriptStructPtr != 0) ? FKuroMaterialInstFolderCheckConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroMaterialInstFolderCheckConfig", ref FKuroMaterialInstFolderCheckConfig._ScriptStructPtr);
		}

		// Token: 0x170027C3 RID: 10179
		// (get) Token: 0x0600AFEF RID: 45039 RVA: 0x000F97AC File Offset: 0x000F79AC
		// (set) Token: 0x0600AFF0 RID: 45040 RVA: 0x000F97EF File Offset: 0x000F79EF
		public TArray<int> ShaderVariant
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._ShaderVariant) == null)
				{
					result = (this._ShaderVariant = new TArray<int>(base.NativePtr + (IntPtr)FKuroMaterialInstFolderCheckConfig.__PropertyOffset_ShaderVariant, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ShaderVariant.CopyAssign(value);
			}
		}

		// Token: 0x170027C4 RID: 10180
		// (get) Token: 0x0600AFF1 RID: 45041 RVA: 0x000F97FD File Offset: 0x000F79FD
		// (set) Token: 0x0600AFF2 RID: 45042 RVA: 0x000F980D File Offset: 0x000F7A0D
		public unsafe int PixelInstruction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialInstFolderCheckConfig.__PropertyOffset_PixelInstruction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialInstFolderCheckConfig.__PropertyOffset_PixelInstruction) = value;
			}
		}

		// Token: 0x170027C5 RID: 10181
		// (get) Token: 0x0600AFF3 RID: 45043 RVA: 0x000F981E File Offset: 0x000F7A1E
		// (set) Token: 0x0600AFF4 RID: 45044 RVA: 0x000F982E File Offset: 0x000F7A2E
		public unsafe int VertexInstruction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialInstFolderCheckConfig.__PropertyOffset_VertexInstruction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialInstFolderCheckConfig.__PropertyOffset_VertexInstruction) = value;
			}
		}

		// Token: 0x170027C6 RID: 10182
		// (get) Token: 0x0600AFF5 RID: 45045 RVA: 0x000F983F File Offset: 0x000F7A3F
		// (set) Token: 0x0600AFF6 RID: 45046 RVA: 0x000F984F File Offset: 0x000F7A4F
		public unsafe byte TextureSample
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialInstFolderCheckConfig.__PropertyOffset_TextureSample);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialInstFolderCheckConfig.__PropertyOffset_TextureSample) = value;
			}
		}

		// Token: 0x170027C7 RID: 10183
		// (get) Token: 0x0600AFF7 RID: 45047 RVA: 0x000F9860 File Offset: 0x000F7A60
		// (set) Token: 0x0600AFF8 RID: 45048 RVA: 0x000F9870 File Offset: 0x000F7A70
		public unsafe byte TextureNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialInstFolderCheckConfig.__PropertyOffset_TextureNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialInstFolderCheckConfig.__PropertyOffset_TextureNum) = value;
			}
		}

		// Token: 0x170027C8 RID: 10184
		// (get) Token: 0x0600AFF9 RID: 45049 RVA: 0x000F9884 File Offset: 0x000F7A84
		// (set) Token: 0x0600AFFA RID: 45050 RVA: 0x000F98C7 File Offset: 0x000F7AC7
		public TArray<string> TextureRefFolder
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._TextureRefFolder) == null)
				{
					result = (this._TextureRefFolder = new TArray<string>(base.NativePtr + (IntPtr)FKuroMaterialInstFolderCheckConfig.__PropertyOffset_TextureRefFolder, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TextureRefFolder.CopyAssign(value);
			}
		}

		// Token: 0x170027C9 RID: 10185
		// (get) Token: 0x0600AFFB RID: 45051 RVA: 0x000F98D8 File Offset: 0x000F7AD8
		// (set) Token: 0x0600AFFC RID: 45052 RVA: 0x000F991B File Offset: 0x000F7B1B
		public TArray<string> ShaderRefFolder
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._ShaderRefFolder) == null)
				{
					result = (this._ShaderRefFolder = new TArray<string>(base.NativePtr + (IntPtr)FKuroMaterialInstFolderCheckConfig.__PropertyOffset_ShaderRefFolder, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ShaderRefFolder.CopyAssign(value);
			}
		}

		// Token: 0x170027CA RID: 10186
		// (get) Token: 0x0600AFFD RID: 45053 RVA: 0x000F992C File Offset: 0x000F7B2C
		// (set) Token: 0x0600AFFE RID: 45054 RVA: 0x000F996F File Offset: 0x000F7B6F
		public TArray<string> AppointMaterialParent
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._AppointMaterialParent) == null)
				{
					result = (this._AppointMaterialParent = new TArray<string>(base.NativePtr + (IntPtr)FKuroMaterialInstFolderCheckConfig.__PropertyOffset_AppointMaterialParent, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AppointMaterialParent.CopyAssign(value);
			}
		}

		// Token: 0x170027CB RID: 10187
		// (get) Token: 0x0600AFFF RID: 45055 RVA: 0x000F9980 File Offset: 0x000F7B80
		// (set) Token: 0x0600B000 RID: 45056 RVA: 0x000F99C3 File Offset: 0x000F7BC3
		public TArray<string> AppointTexParamName
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._AppointTexParamName) == null)
				{
					result = (this._AppointTexParamName = new TArray<string>(base.NativePtr + (IntPtr)FKuroMaterialInstFolderCheckConfig.__PropertyOffset_AppointTexParamName, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AppointTexParamName.CopyAssign(value);
			}
		}

		// Token: 0x170027CC RID: 10188
		// (get) Token: 0x0600B001 RID: 45057 RVA: 0x000F99D4 File Offset: 0x000F7BD4
		// (set) Token: 0x0600B002 RID: 45058 RVA: 0x000F9A17 File Offset: 0x000F7C17
		public TArray<string> AppointTexPath
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._AppointTexPath) == null)
				{
					result = (this._AppointTexPath = new TArray<string>(base.NativePtr + (IntPtr)FKuroMaterialInstFolderCheckConfig.__PropertyOffset_AppointTexPath, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AppointTexPath.CopyAssign(value);
			}
		}

		// Token: 0x170027CD RID: 10189
		// (get) Token: 0x0600B003 RID: 45059 RVA: 0x000F9A28 File Offset: 0x000F7C28
		// (set) Token: 0x0600B004 RID: 45060 RVA: 0x000F9A6B File Offset: 0x000F7C6B
		public TArray<string> AppointBlendMaterialParent
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._AppointBlendMaterialParent) == null)
				{
					result = (this._AppointBlendMaterialParent = new TArray<string>(base.NativePtr + (IntPtr)FKuroMaterialInstFolderCheckConfig.__PropertyOffset_AppointBlendMaterialParent, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AppointBlendMaterialParent.CopyAssign(value);
			}
		}

		// Token: 0x170027CE RID: 10190
		// (get) Token: 0x0600B005 RID: 45061 RVA: 0x000F9A7C File Offset: 0x000F7C7C
		// (set) Token: 0x0600B006 RID: 45062 RVA: 0x000F9ABF File Offset: 0x000F7CBF
		public TArray<string> AppointBlendMode
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._AppointBlendMode) == null)
				{
					result = (this._AppointBlendMode = new TArray<string>(base.NativePtr + (IntPtr)FKuroMaterialInstFolderCheckConfig.__PropertyOffset_AppointBlendMode, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AppointBlendMode.CopyAssign(value);
			}
		}

		// Token: 0x170027CF RID: 10191
		// (get) Token: 0x0600B007 RID: 45063 RVA: 0x000F9AD0 File Offset: 0x000F7CD0
		// (set) Token: 0x0600B008 RID: 45064 RVA: 0x000F9B13 File Offset: 0x000F7D13
		public TArray<string> AppointMaterialParentEnableCastRasterShadowsInRaytracing
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._AppointMaterialParentEnableCastRasterShadowsInRaytracing) == null)
				{
					result = (this._AppointMaterialParentEnableCastRasterShadowsInRaytracing = new TArray<string>(base.NativePtr + (IntPtr)FKuroMaterialInstFolderCheckConfig.__PropertyOffset_AppointMaterialParentEnableCastRasterShadowsInRaytracing, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AppointMaterialParentEnableCastRasterShadowsInRaytracing.CopyAssign(value);
			}
		}

		// Token: 0x0600B009 RID: 45065 RVA: 0x000F9B21 File Offset: 0x000F7D21
		public FKuroMaterialInstFolderCheckConfig()
		{
		}

		// Token: 0x0600B00A RID: 45066 RVA: 0x000F9B2C File Offset: 0x000F7D2C
		public FKuroMaterialInstFolderCheckConfig(TArray<int> ShaderVariant, int PixelInstruction, int VertexInstruction, byte TextureSample, byte TextureNum, TArray<string> TextureRefFolder, TArray<string> ShaderRefFolder, TArray<string> AppointMaterialParent, TArray<string> AppointTexParamName, TArray<string> AppointTexPath, TArray<string> AppointBlendMaterialParent, TArray<string> AppointBlendMode, TArray<string> AppointMaterialParentEnableCastRasterShadowsInRaytracing, string Regex, int MatchingPriority)
		{
			this.ShaderVariant = ShaderVariant;
			this.PixelInstruction = PixelInstruction;
			this.VertexInstruction = VertexInstruction;
			this.TextureSample = TextureSample;
			this.TextureNum = TextureNum;
			this.TextureRefFolder = TextureRefFolder;
			this.ShaderRefFolder = ShaderRefFolder;
			this.AppointMaterialParent = AppointMaterialParent;
			this.AppointTexParamName = AppointTexParamName;
			this.AppointTexPath = AppointTexPath;
			this.AppointBlendMaterialParent = AppointBlendMaterialParent;
			this.AppointBlendMode = AppointBlendMode;
			this.AppointMaterialParentEnableCastRasterShadowsInRaytracing = AppointMaterialParentEnableCastRasterShadowsInRaytracing;
			base.Regex = Regex;
			base.MatchingPriority = MatchingPriority;
		}

		// Token: 0x0600B00B RID: 45067 RVA: 0x000F9BB4 File Offset: 0x000F7DB4
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialInstFolderCheckConfig.StaticStruct();
		}

		// Token: 0x0600B00C RID: 45068 RVA: 0x000F9BC0 File Offset: 0x000F7DC0
		[NullableContext(2)]
		public FKuroMaterialInstFolderCheckConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B00D RID: 45069 RVA: 0x000F9BCA File Offset: 0x000F7DCA
		public FKuroMaterialInstFolderCheckConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B00E RID: 45070 RVA: 0x000F9BD5 File Offset: 0x000F7DD5
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialInstFolderCheckConfig(Pointer, false, true);
		}

		// Token: 0x0600B00F RID: 45071 RVA: 0x000F9BDF File Offset: 0x000F7DDF
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialInstFolderCheckConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04005C15 RID: 23573
		public new const string __ObjectPath = "/Script/Engine.KuroMaterialInstFolderCheckConfig";

		// Token: 0x04005C16 RID: 23574
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005C17 RID: 23575
		internal static int __PropertyOffset_ShaderVariant;

		// Token: 0x04005C18 RID: 23576
		[Nullable(2)]
		private TArray<int> _ShaderVariant;

		// Token: 0x04005C19 RID: 23577
		internal static int __PropertyOffset_PixelInstruction;

		// Token: 0x04005C1A RID: 23578
		internal static int __PropertyOffset_VertexInstruction;

		// Token: 0x04005C1B RID: 23579
		internal static int __PropertyOffset_TextureSample;

		// Token: 0x04005C1C RID: 23580
		internal static int __PropertyOffset_TextureNum;

		// Token: 0x04005C1D RID: 23581
		internal static int __PropertyOffset_TextureRefFolder;

		// Token: 0x04005C1E RID: 23582
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _TextureRefFolder;

		// Token: 0x04005C1F RID: 23583
		internal static int __PropertyOffset_ShaderRefFolder;

		// Token: 0x04005C20 RID: 23584
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ShaderRefFolder;

		// Token: 0x04005C21 RID: 23585
		internal static int __PropertyOffset_AppointMaterialParent;

		// Token: 0x04005C22 RID: 23586
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _AppointMaterialParent;

		// Token: 0x04005C23 RID: 23587
		internal static int __PropertyOffset_AppointTexParamName;

		// Token: 0x04005C24 RID: 23588
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _AppointTexParamName;

		// Token: 0x04005C25 RID: 23589
		internal static int __PropertyOffset_AppointTexPath;

		// Token: 0x04005C26 RID: 23590
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _AppointTexPath;

		// Token: 0x04005C27 RID: 23591
		internal static int __PropertyOffset_AppointBlendMaterialParent;

		// Token: 0x04005C28 RID: 23592
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _AppointBlendMaterialParent;

		// Token: 0x04005C29 RID: 23593
		internal static int __PropertyOffset_AppointBlendMode;

		// Token: 0x04005C2A RID: 23594
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _AppointBlendMode;

		// Token: 0x04005C2B RID: 23595
		internal static int __PropertyOffset_AppointMaterialParentEnableCastRasterShadowsInRaytracing;

		// Token: 0x04005C2C RID: 23596
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _AppointMaterialParentEnableCastRasterShadowsInRaytracing;
	}
}
