using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010C5 RID: 4293
	[UnrealObjectPath("/Script/Engine.RuntimeVirtualTexture")]
	[UnrealStructLayout(160, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class URuntimeVirtualTexture : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F4F2 RID: 62706 RVA: 0x0016B2DE File Offset: 0x001694DE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URuntimeVirtualTexture._ClassPtr;
		}

		// Token: 0x0600F4F3 RID: 62707 RVA: 0x0016B2EC File Offset: 0x001694EC
		public URuntimeVirtualTexture() : this(BuiltinUtils.AllocNativeUObject(URuntimeVirtualTexture.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F4F4 RID: 62708 RVA: 0x0016B314 File Offset: 0x00169514
		[NullableContext(1)]
		public URuntimeVirtualTexture(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URuntimeVirtualTexture.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003BA2 RID: 15266
		// (get) Token: 0x0600F4F5 RID: 62709 RVA: 0x0016B347 File Offset: 0x00169547
		// (set) Token: 0x0600F4F6 RID: 62710 RVA: 0x0016B357 File Offset: 0x00169557
		public unsafe int TileCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URuntimeVirtualTexture.__PropertyOffset_TileCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URuntimeVirtualTexture.__PropertyOffset_TileCount) = value;
			}
		}

		// Token: 0x17003BA3 RID: 15267
		// (get) Token: 0x0600F4F7 RID: 62711 RVA: 0x0016B368 File Offset: 0x00169568
		// (set) Token: 0x0600F4F8 RID: 62712 RVA: 0x0016B378 File Offset: 0x00169578
		public unsafe int TileSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URuntimeVirtualTexture.__PropertyOffset_TileSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URuntimeVirtualTexture.__PropertyOffset_TileSize) = value;
			}
		}

		// Token: 0x17003BA4 RID: 15268
		// (get) Token: 0x0600F4F9 RID: 62713 RVA: 0x0016B389 File Offset: 0x00169589
		// (set) Token: 0x0600F4FA RID: 62714 RVA: 0x0016B399 File Offset: 0x00169599
		public unsafe int TileBorderSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URuntimeVirtualTexture.__PropertyOffset_TileBorderSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URuntimeVirtualTexture.__PropertyOffset_TileBorderSize) = value;
			}
		}

		// Token: 0x17003BA5 RID: 15269
		// (get) Token: 0x0600F4FB RID: 62715 RVA: 0x0016B3AA File Offset: 0x001695AA
		// (set) Token: 0x0600F4FC RID: 62716 RVA: 0x0016B3BA File Offset: 0x001695BA
		public unsafe ERuntimeVirtualTextureMaterialType MaterialType
		{
			get
			{
				return (ERuntimeVirtualTextureMaterialType)(*(base.NativePtr + (IntPtr)URuntimeVirtualTexture.__PropertyOffset_MaterialType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)URuntimeVirtualTexture.__PropertyOffset_MaterialType) = (byte)value;
			}
		}

		// Token: 0x17003BA6 RID: 15270
		// (get) Token: 0x0600F4FD RID: 62717 RVA: 0x0016B3CB File Offset: 0x001695CB
		// (set) Token: 0x0600F4FE RID: 62718 RVA: 0x0016B3DB File Offset: 0x001695DB
		public unsafe bool bCompressTextures
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URuntimeVirtualTexture.__PropertyOffset_bCompressTextures) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URuntimeVirtualTexture.__PropertyOffset_bCompressTextures) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003BA7 RID: 15271
		// (get) Token: 0x0600F4FF RID: 62719 RVA: 0x0016B3EC File Offset: 0x001695EC
		// (set) Token: 0x0600F500 RID: 62720 RVA: 0x0016B3FC File Offset: 0x001695FC
		public unsafe bool bClearTextures
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URuntimeVirtualTexture.__PropertyOffset_bClearTextures) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URuntimeVirtualTexture.__PropertyOffset_bClearTextures) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003BA8 RID: 15272
		// (get) Token: 0x0600F501 RID: 62721 RVA: 0x0016B40D File Offset: 0x0016960D
		// (set) Token: 0x0600F502 RID: 62722 RVA: 0x0016B41D File Offset: 0x0016961D
		public unsafe bool bSinglePhysicalSpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URuntimeVirtualTexture.__PropertyOffset_bSinglePhysicalSpace) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URuntimeVirtualTexture.__PropertyOffset_bSinglePhysicalSpace) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003BA9 RID: 15273
		// (get) Token: 0x0600F503 RID: 62723 RVA: 0x0016B42E File Offset: 0x0016962E
		// (set) Token: 0x0600F504 RID: 62724 RVA: 0x0016B43E File Offset: 0x0016963E
		public unsafe bool bPrivateSpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URuntimeVirtualTexture.__PropertyOffset_bPrivateSpace) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URuntimeVirtualTexture.__PropertyOffset_bPrivateSpace) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003BAA RID: 15274
		// (get) Token: 0x0600F505 RID: 62725 RVA: 0x0016B44F File Offset: 0x0016964F
		// (set) Token: 0x0600F506 RID: 62726 RVA: 0x0016B45F File Offset: 0x0016965F
		public unsafe bool bSkipRVTWhenBakedSVT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URuntimeVirtualTexture.__PropertyOffset_bSkipRVTWhenBakedSVT) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URuntimeVirtualTexture.__PropertyOffset_bSkipRVTWhenBakedSVT) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003BAB RID: 15275
		// (get) Token: 0x0600F507 RID: 62727 RVA: 0x0016B470 File Offset: 0x00169670
		// (set) Token: 0x0600F508 RID: 62728 RVA: 0x0016B480 File Offset: 0x00169680
		public unsafe bool bAdaptive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URuntimeVirtualTexture.__PropertyOffset_bAdaptive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URuntimeVirtualTexture.__PropertyOffset_bAdaptive) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003BAC RID: 15276
		// (get) Token: 0x0600F509 RID: 62729 RVA: 0x0016B491 File Offset: 0x00169691
		// (set) Token: 0x0600F50A RID: 62730 RVA: 0x0016B4A1 File Offset: 0x001696A1
		public unsafe bool bContinuousUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URuntimeVirtualTexture.__PropertyOffset_bContinuousUpdate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URuntimeVirtualTexture.__PropertyOffset_bContinuousUpdate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003BAD RID: 15277
		// (get) Token: 0x0600F50B RID: 62731 RVA: 0x0016B4B2 File Offset: 0x001696B2
		// (set) Token: 0x0600F50C RID: 62732 RVA: 0x0016B4C2 File Offset: 0x001696C2
		public unsafe int RemoveLowMips
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URuntimeVirtualTexture.__PropertyOffset_RemoveLowMips);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URuntimeVirtualTexture.__PropertyOffset_RemoveLowMips) = value;
			}
		}

		// Token: 0x17003BAE RID: 15278
		// (get) Token: 0x0600F50D RID: 62733 RVA: 0x0016B4D3 File Offset: 0x001696D3
		// (set) Token: 0x0600F50E RID: 62734 RVA: 0x0016B4E7 File Offset: 0x001696E7
		public unsafe TEnumAsByte<TextureGroup> LODGroup
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URuntimeVirtualTexture.__PropertyOffset_LODGroup);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URuntimeVirtualTexture.__PropertyOffset_LODGroup) = value;
			}
		}

		// Token: 0x17003BAF RID: 15279
		// (get) Token: 0x0600F50F RID: 62735 RVA: 0x0016B4FC File Offset: 0x001696FC
		// (set) Token: 0x0600F510 RID: 62736 RVA: 0x0016B50C File Offset: 0x0016970C
		public unsafe int Size_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URuntimeVirtualTexture.__PropertyOffset_Size_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URuntimeVirtualTexture.__PropertyOffset_Size_DEPRECATED) = value;
			}
		}

		// Token: 0x17003BB0 RID: 15280
		// (get) Token: 0x0600F511 RID: 62737 RVA: 0x0016B51D File Offset: 0x0016971D
		// (set) Token: 0x0600F512 RID: 62738 RVA: 0x0016B531 File Offset: 0x00169731
		[Nullable(2)]
		public unsafe URuntimeVirtualTextureStreamingProxy StreamingTexture_DEPRECATED
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<URuntimeVirtualTextureStreamingProxy>(base.NativePtr / (IntPtr)sizeof(void*) + URuntimeVirtualTexture.__PropertyOffset_StreamingTexture_DEPRECATED);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + URuntimeVirtualTexture.__PropertyOffset_StreamingTexture_DEPRECATED, value);
			}
		}

		// Token: 0x0600F513 RID: 62739 RVA: 0x0016B546 File Offset: 0x00169746
		public int GetTileSize()
		{
			return URuntimeVirtualTexture.__GetTileSize_Internal(base.NativePtr);
		}

		// Token: 0x0600F514 RID: 62740 RVA: 0x0016B553 File Offset: 0x00169753
		public int GetTileCount()
		{
			return URuntimeVirtualTexture.__GetTileCount_Internal(base.NativePtr);
		}

		// Token: 0x0600F515 RID: 62741 RVA: 0x0016B560 File Offset: 0x00169760
		public int GetTileBorderSize()
		{
			return URuntimeVirtualTexture.__GetTileBorderSize_Internal(base.NativePtr);
		}

		// Token: 0x0600F516 RID: 62742 RVA: 0x0016B56D File Offset: 0x0016976D
		public int GetSize()
		{
			return URuntimeVirtualTexture.__GetSize_Internal(base.NativePtr);
		}

		// Token: 0x0600F517 RID: 62743 RVA: 0x0016B57A File Offset: 0x0016977A
		public int GetPageTableSize()
		{
			return URuntimeVirtualTexture.__GetPageTableSize_Internal(base.NativePtr);
		}

		// Token: 0x0600F518 RID: 62744
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetTileSize_Internal(IntPtr @this);

		// Token: 0x0600F519 RID: 62745
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetTileCount_Internal(IntPtr @this);

		// Token: 0x0600F51A RID: 62746
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetTileBorderSize_Internal(IntPtr @this);

		// Token: 0x0600F51B RID: 62747
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetSize_Internal(IntPtr @this);

		// Token: 0x0600F51C RID: 62748
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetPageTableSize_Internal(IntPtr @this);

		// Token: 0x0600F51D RID: 62749 RVA: 0x0016B587 File Offset: 0x00169787
		static URuntimeVirtualTexture()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.RuntimeVirtualTexture");
		}

		// Token: 0x0600F51E RID: 62750 RVA: 0x0016B595 File Offset: 0x00169795
		protected URuntimeVirtualTexture(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040084C0 RID: 33984
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.RuntimeVirtualTexture";

		// Token: 0x040084C1 RID: 33985
		private static IntPtr _ClassPtr;

		// Token: 0x040084C2 RID: 33986
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040084C3 RID: 33987
		internal static int __PropertyOffset_TileCount;

		// Token: 0x040084C4 RID: 33988
		internal static int __PropertyOffset_TileSize;

		// Token: 0x040084C5 RID: 33989
		internal static int __PropertyOffset_TileBorderSize;

		// Token: 0x040084C6 RID: 33990
		internal static int __PropertyOffset_MaterialType;

		// Token: 0x040084C7 RID: 33991
		internal static int __PropertyOffset_bCompressTextures;

		// Token: 0x040084C8 RID: 33992
		internal static int __PropertyOffset_bClearTextures;

		// Token: 0x040084C9 RID: 33993
		internal static int __PropertyOffset_bSinglePhysicalSpace;

		// Token: 0x040084CA RID: 33994
		internal static int __PropertyOffset_bPrivateSpace;

		// Token: 0x040084CB RID: 33995
		internal static int __PropertyOffset_bSkipRVTWhenBakedSVT;

		// Token: 0x040084CC RID: 33996
		internal static int __PropertyOffset_bAdaptive;

		// Token: 0x040084CD RID: 33997
		internal static int __PropertyOffset_bContinuousUpdate;

		// Token: 0x040084CE RID: 33998
		internal static int __PropertyOffset_RemoveLowMips;

		// Token: 0x040084CF RID: 33999
		internal static int __PropertyOffset_LODGroup;

		// Token: 0x040084D0 RID: 34000
		internal static int __PropertyOffset_Size_DEPRECATED;

		// Token: 0x040084D1 RID: 34001
		internal static int __PropertyOffset_StreamingTexture_DEPRECATED;
	}
}
