using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F80 RID: 8064
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Landscape.LandscapeMaterialInstanceConstant")]
	[UnrealStructLayout(1912, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1912)]
	public class ULandscapeMaterialInstanceConstant : UMaterialInstanceConstant, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E973 RID: 125299 RVA: 0x002D760E File Offset: 0x002D580E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULandscapeMaterialInstanceConstant._ClassPtr;
		}

		// Token: 0x0601E974 RID: 125300 RVA: 0x002D761C File Offset: 0x002D581C
		public ULandscapeMaterialInstanceConstant() : this(BuiltinUtils.AllocNativeUObject(ULandscapeMaterialInstanceConstant.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E975 RID: 125301 RVA: 0x002D7644 File Offset: 0x002D5844
		public ULandscapeMaterialInstanceConstant(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULandscapeMaterialInstanceConstant.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170079B5 RID: 31157
		// (get) Token: 0x0601E976 RID: 125302 RVA: 0x002D7678 File Offset: 0x002D5878
		// (set) Token: 0x0601E977 RID: 125303 RVA: 0x002D76B1 File Offset: 0x002D58B1
		public TArray<FLandscapeMaterialTextureStreamingInfo> TextureStreamingInfo
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLandscapeMaterialTextureStreamingInfo> result;
				if ((result = this._TextureStreamingInfo) == null)
				{
					result = (this._TextureStreamingInfo = new TArray<FLandscapeMaterialTextureStreamingInfo>(base.NativePtr + (IntPtr)ULandscapeMaterialInstanceConstant.__PropertyOffset_TextureStreamingInfo, this));
				}
				return result;
			}
			set
			{
				this.TextureStreamingInfo.CopyAssign(value);
			}
		}

		// Token: 0x170079B6 RID: 31158
		// (get) Token: 0x0601E978 RID: 125304 RVA: 0x002D76BF File Offset: 0x002D58BF
		// (set) Token: 0x0601E979 RID: 125305 RVA: 0x002D76D8 File Offset: 0x002D58D8
		public unsafe bool bIsLayerThumbnail
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULandscapeMaterialInstanceConstant.__PropertyOffset_bIsLayerThumbnail) & ULandscapeMaterialInstanceConstant.__PropertyMask_bIsLayerThumbnail) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULandscapeMaterialInstanceConstant.__PropertyOffset_bIsLayerThumbnail) = ((*(base.NativePtr + (IntPtr)ULandscapeMaterialInstanceConstant.__PropertyOffset_bIsLayerThumbnail) & ~ULandscapeMaterialInstanceConstant.__PropertyMask_bIsLayerThumbnail) | (value ? ULandscapeMaterialInstanceConstant.__PropertyMask_bIsLayerThumbnail : 0));
			}
		}

		// Token: 0x170079B7 RID: 31159
		// (get) Token: 0x0601E97A RID: 125306 RVA: 0x002D7708 File Offset: 0x002D5908
		// (set) Token: 0x0601E97B RID: 125307 RVA: 0x002D7721 File Offset: 0x002D5921
		public unsafe bool bDisableTessellation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULandscapeMaterialInstanceConstant.__PropertyOffset_bDisableTessellation) & ULandscapeMaterialInstanceConstant.__PropertyMask_bDisableTessellation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULandscapeMaterialInstanceConstant.__PropertyOffset_bDisableTessellation) = ((*(base.NativePtr + (IntPtr)ULandscapeMaterialInstanceConstant.__PropertyOffset_bDisableTessellation) & ~ULandscapeMaterialInstanceConstant.__PropertyMask_bDisableTessellation) | (value ? ULandscapeMaterialInstanceConstant.__PropertyMask_bDisableTessellation : 0));
			}
		}

		// Token: 0x170079B8 RID: 31160
		// (get) Token: 0x0601E97C RID: 125308 RVA: 0x002D7751 File Offset: 0x002D5951
		// (set) Token: 0x0601E97D RID: 125309 RVA: 0x002D776A File Offset: 0x002D596A
		public unsafe bool bMobile
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULandscapeMaterialInstanceConstant.__PropertyOffset_bMobile) & ULandscapeMaterialInstanceConstant.__PropertyMask_bMobile) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULandscapeMaterialInstanceConstant.__PropertyOffset_bMobile) = ((*(base.NativePtr + (IntPtr)ULandscapeMaterialInstanceConstant.__PropertyOffset_bMobile) & ~ULandscapeMaterialInstanceConstant.__PropertyMask_bMobile) | (value ? ULandscapeMaterialInstanceConstant.__PropertyMask_bMobile : 0));
			}
		}

		// Token: 0x170079B9 RID: 31161
		// (get) Token: 0x0601E97E RID: 125310 RVA: 0x002D779A File Offset: 0x002D599A
		// (set) Token: 0x0601E97F RID: 125311 RVA: 0x002D77B3 File Offset: 0x002D59B3
		public unsafe bool bEditorToolUsage
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULandscapeMaterialInstanceConstant.__PropertyOffset_bEditorToolUsage) & ULandscapeMaterialInstanceConstant.__PropertyMask_bEditorToolUsage) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULandscapeMaterialInstanceConstant.__PropertyOffset_bEditorToolUsage) = ((*(base.NativePtr + (IntPtr)ULandscapeMaterialInstanceConstant.__PropertyOffset_bEditorToolUsage) & ~ULandscapeMaterialInstanceConstant.__PropertyMask_bEditorToolUsage) | (value ? ULandscapeMaterialInstanceConstant.__PropertyMask_bEditorToolUsage : 0));
			}
		}

		// Token: 0x0601E980 RID: 125312 RVA: 0x002D77E3 File Offset: 0x002D59E3
		static ULandscapeMaterialInstanceConstant()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Landscape.LandscapeMaterialInstanceConstant");
		}

		// Token: 0x0601E981 RID: 125313 RVA: 0x002D77F1 File Offset: 0x002D59F1
		protected ULandscapeMaterialInstanceConstant(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401087C RID: 67708
		public new const string __ObjectPath = "/Script/Landscape.LandscapeMaterialInstanceConstant";

		// Token: 0x0401087D RID: 67709
		private static IntPtr _ClassPtr;

		// Token: 0x0401087E RID: 67710
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401087F RID: 67711
		internal static int __PropertyOffset_TextureStreamingInfo;

		// Token: 0x04010880 RID: 67712
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FLandscapeMaterialTextureStreamingInfo> _TextureStreamingInfo;

		// Token: 0x04010881 RID: 67713
		internal static int __PropertyOffset_bIsLayerThumbnail;

		// Token: 0x04010882 RID: 67714
		internal static byte __PropertyMask_bIsLayerThumbnail;

		// Token: 0x04010883 RID: 67715
		internal static int __PropertyOffset_bDisableTessellation;

		// Token: 0x04010884 RID: 67716
		internal static byte __PropertyMask_bDisableTessellation;

		// Token: 0x04010885 RID: 67717
		internal static int __PropertyOffset_bMobile;

		// Token: 0x04010886 RID: 67718
		internal static byte __PropertyMask_bMobile;

		// Token: 0x04010887 RID: 67719
		internal static int __PropertyOffset_bEditorToolUsage;

		// Token: 0x04010888 RID: 67720
		internal static byte __PropertyMask_bEditorToolUsage;
	}
}
