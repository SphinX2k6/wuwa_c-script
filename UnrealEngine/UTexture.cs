using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000298 RID: 664
	[UnrealObjectPath("/Script/Engine.Texture")]
	[UnrealStructLayout(4112, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4112)]
	public abstract class UTexture : UStreamableRenderAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004946 RID: 18758 RVA: 0x00066B23 File Offset: 0x00064D23
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTexture._ClassPtr;
		}

		// Token: 0x17000DB6 RID: 3510
		// (get) Token: 0x06004947 RID: 18759 RVA: 0x00066B2F File Offset: 0x00064D2F
		// (set) Token: 0x06004948 RID: 18760 RVA: 0x00066B43 File Offset: 0x00064D43
		public unsafe FGuid LightingGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_LightingGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_LightingGuid) = value;
			}
		}

		// Token: 0x17000DB7 RID: 3511
		// (get) Token: 0x06004949 RID: 18761 RVA: 0x00066B58 File Offset: 0x00064D58
		// (set) Token: 0x0600494A RID: 18762 RVA: 0x00066B68 File Offset: 0x00064D68
		public unsafe int LODBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_LODBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_LODBias) = value;
			}
		}

		// Token: 0x17000DB8 RID: 3512
		// (get) Token: 0x0600494B RID: 18763 RVA: 0x00066B79 File Offset: 0x00064D79
		// (set) Token: 0x0600494C RID: 18764 RVA: 0x00066B89 File Offset: 0x00064D89
		public unsafe bool IsCreateAsync
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_IsCreateAsync) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_IsCreateAsync) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000DB9 RID: 3513
		// (get) Token: 0x0600494D RID: 18765 RVA: 0x00066B9A File Offset: 0x00064D9A
		// (set) Token: 0x0600494E RID: 18766 RVA: 0x00066BAA File Offset: 0x00064DAA
		public unsafe bool IsForceKeepMipsData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_IsForceKeepMipsData) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_IsForceKeepMipsData) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000DBA RID: 3514
		// (get) Token: 0x0600494F RID: 18767 RVA: 0x00066BBB File Offset: 0x00064DBB
		// (set) Token: 0x06004950 RID: 18768 RVA: 0x00066BCF File Offset: 0x00064DCF
		public unsafe TEnumAsByte<TextureGroup> LODGroup
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_LODGroup);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_LODGroup) = value;
			}
		}

		// Token: 0x17000DBB RID: 3515
		// (get) Token: 0x06004951 RID: 18769 RVA: 0x00066BE4 File Offset: 0x00064DE4
		// (set) Token: 0x06004952 RID: 18770 RVA: 0x00066BF4 File Offset: 0x00064DF4
		public unsafe bool bKuroScaleSizeFitForCompression
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_bKuroScaleSizeFitForCompression) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_bKuroScaleSizeFitForCompression) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000DBC RID: 3516
		// (get) Token: 0x06004953 RID: 18771 RVA: 0x00066C05 File Offset: 0x00064E05
		// (set) Token: 0x06004954 RID: 18772 RVA: 0x00066C1E File Offset: 0x00064E1E
		public unsafe bool SRGB
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_SRGB) & UTexture.__PropertyMask_SRGB) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UTexture.__PropertyOffset_SRGB) = ((*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_SRGB) & ~UTexture.__PropertyMask_SRGB) | (value ? UTexture.__PropertyMask_SRGB : 0));
			}
		}

		// Token: 0x17000DBD RID: 3517
		// (get) Token: 0x06004955 RID: 18773 RVA: 0x00066C4E File Offset: 0x00064E4E
		// (set) Token: 0x06004956 RID: 18774 RVA: 0x00066C67 File Offset: 0x00064E67
		public unsafe bool bNoTiling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_bNoTiling) & UTexture.__PropertyMask_bNoTiling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UTexture.__PropertyOffset_bNoTiling) = ((*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_bNoTiling) & ~UTexture.__PropertyMask_bNoTiling) | (value ? UTexture.__PropertyMask_bNoTiling : 0));
			}
		}

		// Token: 0x17000DBE RID: 3518
		// (get) Token: 0x06004957 RID: 18775 RVA: 0x00066C97 File Offset: 0x00064E97
		// (set) Token: 0x06004958 RID: 18776 RVA: 0x00066CB0 File Offset: 0x00064EB0
		public unsafe bool VirtualTextureStreaming
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_VirtualTextureStreaming) & UTexture.__PropertyMask_VirtualTextureStreaming) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UTexture.__PropertyOffset_VirtualTextureStreaming) = ((*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_VirtualTextureStreaming) & ~UTexture.__PropertyMask_VirtualTextureStreaming) | (value ? UTexture.__PropertyMask_VirtualTextureStreaming : 0));
			}
		}

		// Token: 0x17000DBF RID: 3519
		// (get) Token: 0x06004959 RID: 18777 RVA: 0x00066CE0 File Offset: 0x00064EE0
		// (set) Token: 0x0600495A RID: 18778 RVA: 0x00066CF9 File Offset: 0x00064EF9
		public unsafe bool CompressionYCoCg
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_CompressionYCoCg) & UTexture.__PropertyMask_CompressionYCoCg) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UTexture.__PropertyOffset_CompressionYCoCg) = ((*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_CompressionYCoCg) & ~UTexture.__PropertyMask_CompressionYCoCg) | (value ? UTexture.__PropertyMask_CompressionYCoCg : 0));
			}
		}

		// Token: 0x17000DC0 RID: 3520
		// (get) Token: 0x0600495B RID: 18779 RVA: 0x00066D29 File Offset: 0x00064F29
		// (set) Token: 0x0600495C RID: 18780 RVA: 0x00066D42 File Offset: 0x00064F42
		public unsafe bool bNotCreateResource
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_bNotCreateResource) & UTexture.__PropertyMask_bNotCreateResource) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UTexture.__PropertyOffset_bNotCreateResource) = ((*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_bNotCreateResource) & ~UTexture.__PropertyMask_bNotCreateResource) | (value ? UTexture.__PropertyMask_bNotCreateResource : 0));
			}
		}

		// Token: 0x17000DC1 RID: 3521
		// (get) Token: 0x0600495D RID: 18781 RVA: 0x00066D72 File Offset: 0x00064F72
		// (set) Token: 0x0600495E RID: 18782 RVA: 0x00066D8B File Offset: 0x00064F8B
		public unsafe bool bNotOfflineProcessed
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_bNotOfflineProcessed) & UTexture.__PropertyMask_bNotOfflineProcessed) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UTexture.__PropertyOffset_bNotOfflineProcessed) = ((*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_bNotOfflineProcessed) & ~UTexture.__PropertyMask_bNotOfflineProcessed) | (value ? UTexture.__PropertyMask_bNotOfflineProcessed : 0));
			}
		}

		// Token: 0x17000DC2 RID: 3522
		// (get) Token: 0x0600495F RID: 18783 RVA: 0x00066DBB File Offset: 0x00064FBB
		// (set) Token: 0x06004960 RID: 18784 RVA: 0x00066DD4 File Offset: 0x00064FD4
		public unsafe bool bAsyncResourceReleaseHasBeenStarted
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_bAsyncResourceReleaseHasBeenStarted) & UTexture.__PropertyMask_bAsyncResourceReleaseHasBeenStarted) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UTexture.__PropertyOffset_bAsyncResourceReleaseHasBeenStarted) = ((*(base.NativePtr + (IntPtr)UTexture.__PropertyOffset_bAsyncResourceReleaseHasBeenStarted) & ~UTexture.__PropertyMask_bAsyncResourceReleaseHasBeenStarted) | (value ? UTexture.__PropertyMask_bAsyncResourceReleaseHasBeenStarted : 0));
			}
		}

		// Token: 0x06004961 RID: 18785 RVA: 0x00066E04 File Offset: 0x00065004
		static UTexture()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Texture");
		}

		// Token: 0x06004962 RID: 18786 RVA: 0x00066E14 File Offset: 0x00065014
		protected UTexture() : this(BuiltinUtils.AllocNativeUObject(UTexture.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004963 RID: 18787 RVA: 0x00066E3C File Offset: 0x0006503C
		protected UTexture(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001C77 RID: 7287
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.Texture";

		// Token: 0x04001C78 RID: 7288
		private static IntPtr _ClassPtr;

		// Token: 0x04001C79 RID: 7289
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001C7A RID: 7290
		internal static int __PropertyOffset_LightingGuid;

		// Token: 0x04001C7B RID: 7291
		internal static int __PropertyOffset_LODBias;

		// Token: 0x04001C7C RID: 7292
		internal static int __PropertyOffset_IsCreateAsync;

		// Token: 0x04001C7D RID: 7293
		internal static int __PropertyOffset_IsForceKeepMipsData;

		// Token: 0x04001C7E RID: 7294
		internal static int __PropertyOffset_LODGroup;

		// Token: 0x04001C7F RID: 7295
		internal static int __PropertyOffset_bKuroScaleSizeFitForCompression;

		// Token: 0x04001C80 RID: 7296
		internal static int __PropertyOffset_SRGB;

		// Token: 0x04001C81 RID: 7297
		internal static byte __PropertyMask_SRGB;

		// Token: 0x04001C82 RID: 7298
		internal static int __PropertyOffset_bNoTiling;

		// Token: 0x04001C83 RID: 7299
		internal static byte __PropertyMask_bNoTiling;

		// Token: 0x04001C84 RID: 7300
		internal static int __PropertyOffset_VirtualTextureStreaming;

		// Token: 0x04001C85 RID: 7301
		internal static byte __PropertyMask_VirtualTextureStreaming;

		// Token: 0x04001C86 RID: 7302
		internal static int __PropertyOffset_CompressionYCoCg;

		// Token: 0x04001C87 RID: 7303
		internal static byte __PropertyMask_CompressionYCoCg;

		// Token: 0x04001C88 RID: 7304
		internal static int __PropertyOffset_bNotCreateResource;

		// Token: 0x04001C89 RID: 7305
		internal static byte __PropertyMask_bNotCreateResource;

		// Token: 0x04001C8A RID: 7306
		internal static int __PropertyOffset_bNotOfflineProcessed;

		// Token: 0x04001C8B RID: 7307
		internal static byte __PropertyMask_bNotOfflineProcessed;

		// Token: 0x04001C8C RID: 7308
		internal static int __PropertyOffset_bAsyncResourceReleaseHasBeenStarted;

		// Token: 0x04001C8D RID: 7309
		internal static byte __PropertyMask_bAsyncResourceReleaseHasBeenStarted;
	}
}
