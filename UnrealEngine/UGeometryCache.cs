using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200140C RID: 5132
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GeometryCache.GeometryCache")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UGeometryCache : UObject, IUnrealUObject, IUnrealObject, IInterface_AssetUserData, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06012BB8 RID: 76728 RVA: 0x001B9372 File Offset: 0x001B7572
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGeometryCache._ClassPtr;
		}

		// Token: 0x06012BB9 RID: 76729 RVA: 0x001B937E File Offset: 0x001B757E
		int IInterface_AssetUserData.InterfaceOffset()
		{
			return UGeometryCache.__InterfaceOffset_IInterface_AssetUserData;
		}

		// Token: 0x06012BBA RID: 76730 RVA: 0x001B9388 File Offset: 0x001B7588
		public UGeometryCache() : this(BuiltinUtils.AllocNativeUObject(UGeometryCache.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012BBB RID: 76731 RVA: 0x001B93B0 File Offset: 0x001B75B0
		public UGeometryCache(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGeometryCache.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700489D RID: 18589
		// (get) Token: 0x06012BBC RID: 76732 RVA: 0x001B93E4 File Offset: 0x001B75E4
		// (set) Token: 0x06012BBD RID: 76733 RVA: 0x001B941D File Offset: 0x001B761D
		public TArray<UMaterialInterface> Materials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._Materials) == null)
				{
					result = (this._Materials = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)UGeometryCache.__PropertyOffset_Materials, this));
				}
				return result;
			}
			set
			{
				this.Materials.CopyAssign(value);
			}
		}

		// Token: 0x1700489E RID: 18590
		// (get) Token: 0x06012BBE RID: 76734 RVA: 0x001B942C File Offset: 0x001B762C
		// (set) Token: 0x06012BBF RID: 76735 RVA: 0x001B9465 File Offset: 0x001B7665
		public TArray<FName> MaterialSlotNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._MaterialSlotNames) == null)
				{
					result = (this._MaterialSlotNames = new TArray<FName>(base.NativePtr + (IntPtr)UGeometryCache.__PropertyOffset_MaterialSlotNames, this));
				}
				return result;
			}
			set
			{
				this.MaterialSlotNames.CopyAssign(value);
			}
		}

		// Token: 0x1700489F RID: 18591
		// (get) Token: 0x06012BC0 RID: 76736 RVA: 0x001B9474 File Offset: 0x001B7674
		// (set) Token: 0x06012BC1 RID: 76737 RVA: 0x001B94AD File Offset: 0x001B76AD
		public TArray<UGeometryCacheTrack> Tracks
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UGeometryCacheTrack> result;
				if ((result = this._Tracks) == null)
				{
					result = (this._Tracks = new TArray<UGeometryCacheTrack>(base.NativePtr + (IntPtr)UGeometryCache.__PropertyOffset_Tracks, this));
				}
				return result;
			}
			set
			{
				this.Tracks.CopyAssign(value);
			}
		}

		// Token: 0x170048A0 RID: 18592
		// (get) Token: 0x06012BC2 RID: 76738 RVA: 0x001B94BB File Offset: 0x001B76BB
		// (set) Token: 0x06012BC3 RID: 76739 RVA: 0x001B94CB File Offset: 0x001B76CB
		public unsafe int MaxNumVertices
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCache.__PropertyOffset_MaxNumVertices);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCache.__PropertyOffset_MaxNumVertices) = value;
			}
		}

		// Token: 0x170048A1 RID: 18593
		// (get) Token: 0x06012BC4 RID: 76740 RVA: 0x001B94DC File Offset: 0x001B76DC
		// (set) Token: 0x06012BC5 RID: 76741 RVA: 0x001B94EC File Offset: 0x001B76EC
		public unsafe int StartFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCache.__PropertyOffset_StartFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCache.__PropertyOffset_StartFrame) = value;
			}
		}

		// Token: 0x170048A2 RID: 18594
		// (get) Token: 0x06012BC6 RID: 76742 RVA: 0x001B94FD File Offset: 0x001B76FD
		// (set) Token: 0x06012BC7 RID: 76743 RVA: 0x001B950D File Offset: 0x001B770D
		public unsafe int EndFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCache.__PropertyOffset_EndFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCache.__PropertyOffset_EndFrame) = value;
			}
		}

		// Token: 0x06012BC8 RID: 76744 RVA: 0x001B951E File Offset: 0x001B771E
		static UGeometryCache()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GeometryCache.GeometryCache");
		}

		// Token: 0x06012BC9 RID: 76745 RVA: 0x001B952C File Offset: 0x001B772C
		protected UGeometryCache(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A03D RID: 41021
		internal static int __InterfaceOffset_IInterface_AssetUserData;

		// Token: 0x0400A03E RID: 41022
		public new const string __ObjectPath = "/Script/GeometryCache.GeometryCache";

		// Token: 0x0400A03F RID: 41023
		private static IntPtr _ClassPtr;

		// Token: 0x0400A040 RID: 41024
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A041 RID: 41025
		internal static int __PropertyOffset_Materials;

		// Token: 0x0400A042 RID: 41026
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _Materials;

		// Token: 0x0400A043 RID: 41027
		internal static int __PropertyOffset_MaterialSlotNames;

		// Token: 0x0400A044 RID: 41028
		[Nullable(2)]
		private TArray<FName> _MaterialSlotNames;

		// Token: 0x0400A045 RID: 41029
		internal static int __PropertyOffset_Tracks;

		// Token: 0x0400A046 RID: 41030
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UGeometryCacheTrack> _Tracks;

		// Token: 0x0400A047 RID: 41031
		internal static int __PropertyOffset_MaxNumVertices;

		// Token: 0x0400A048 RID: 41032
		internal static int __PropertyOffset_StartFrame;

		// Token: 0x0400A049 RID: 41033
		internal static int __PropertyOffset_EndFrame;
	}
}
