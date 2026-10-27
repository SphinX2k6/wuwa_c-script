using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020011D8 RID: 4568
	[UnrealObjectPath("/Script/Engine.TextureLODGroup")]
	[UnrealStructLayout(112, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FTextureLODGroup : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010D27 RID: 68903 RVA: 0x0018B4A4 File Offset: 0x001896A4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTextureLODGroup._ScriptStructPtr != 0) ? FTextureLODGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.TextureLODGroup", ref FTextureLODGroup._ScriptStructPtr);
		}

		// Token: 0x170041B2 RID: 16818
		// (get) Token: 0x06010D28 RID: 68904 RVA: 0x0018B4C8 File Offset: 0x001896C8
		// (set) Token: 0x06010D29 RID: 68905 RVA: 0x0018B4DC File Offset: 0x001896DC
		public unsafe TEnumAsByte<TextureGroup> Group
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextureLODGroup.__PropertyOffset_Group);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextureLODGroup.__PropertyOffset_Group) = value;
			}
		}

		// Token: 0x170041B3 RID: 16819
		// (get) Token: 0x06010D2A RID: 68906 RVA: 0x0018B4F1 File Offset: 0x001896F1
		// (set) Token: 0x06010D2B RID: 68907 RVA: 0x0018B501 File Offset: 0x00189701
		public unsafe int LODBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextureLODGroup.__PropertyOffset_LODBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextureLODGroup.__PropertyOffset_LODBias) = value;
			}
		}

		// Token: 0x170041B4 RID: 16820
		// (get) Token: 0x06010D2C RID: 68908 RVA: 0x0018B512 File Offset: 0x00189712
		// (set) Token: 0x06010D2D RID: 68909 RVA: 0x0018B522 File Offset: 0x00189722
		public unsafe int LODBias_Smaller
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextureLODGroup.__PropertyOffset_LODBias_Smaller);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextureLODGroup.__PropertyOffset_LODBias_Smaller) = value;
			}
		}

		// Token: 0x170041B5 RID: 16821
		// (get) Token: 0x06010D2E RID: 68910 RVA: 0x0018B533 File Offset: 0x00189733
		// (set) Token: 0x06010D2F RID: 68911 RVA: 0x0018B543 File Offset: 0x00189743
		public unsafe int LODBias_Smallest
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextureLODGroup.__PropertyOffset_LODBias_Smallest);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextureLODGroup.__PropertyOffset_LODBias_Smallest) = value;
			}
		}

		// Token: 0x170041B6 RID: 16822
		// (get) Token: 0x06010D30 RID: 68912 RVA: 0x0018B554 File Offset: 0x00189754
		// (set) Token: 0x06010D31 RID: 68913 RVA: 0x0018B564 File Offset: 0x00189764
		public unsafe int NumStreamedMips
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextureLODGroup.__PropertyOffset_NumStreamedMips);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextureLODGroup.__PropertyOffset_NumStreamedMips) = value;
			}
		}

		// Token: 0x170041B7 RID: 16823
		// (get) Token: 0x06010D32 RID: 68914 RVA: 0x0018B575 File Offset: 0x00189775
		// (set) Token: 0x06010D33 RID: 68915 RVA: 0x0018B589 File Offset: 0x00189789
		public unsafe TEnumAsByte<TextureMipGenSettings> MipGenSettings
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextureLODGroup.__PropertyOffset_MipGenSettings);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextureLODGroup.__PropertyOffset_MipGenSettings) = value;
			}
		}

		// Token: 0x170041B8 RID: 16824
		// (get) Token: 0x06010D34 RID: 68916 RVA: 0x0018B59E File Offset: 0x0018979E
		// (set) Token: 0x06010D35 RID: 68917 RVA: 0x0018B5AE File Offset: 0x001897AE
		public unsafe int MinLODSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextureLODGroup.__PropertyOffset_MinLODSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextureLODGroup.__PropertyOffset_MinLODSize) = value;
			}
		}

		// Token: 0x170041B9 RID: 16825
		// (get) Token: 0x06010D36 RID: 68918 RVA: 0x0018B5BF File Offset: 0x001897BF
		// (set) Token: 0x06010D37 RID: 68919 RVA: 0x0018B5CF File Offset: 0x001897CF
		public unsafe int MaxLODSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextureLODGroup.__PropertyOffset_MaxLODSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextureLODGroup.__PropertyOffset_MaxLODSize) = value;
			}
		}

		// Token: 0x170041BA RID: 16826
		// (get) Token: 0x06010D38 RID: 68920 RVA: 0x0018B5E0 File Offset: 0x001897E0
		// (set) Token: 0x06010D39 RID: 68921 RVA: 0x0018B5F0 File Offset: 0x001897F0
		public unsafe int MaxLODSize_Smaller
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextureLODGroup.__PropertyOffset_MaxLODSize_Smaller);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextureLODGroup.__PropertyOffset_MaxLODSize_Smaller) = value;
			}
		}

		// Token: 0x170041BB RID: 16827
		// (get) Token: 0x06010D3A RID: 68922 RVA: 0x0018B601 File Offset: 0x00189801
		// (set) Token: 0x06010D3B RID: 68923 RVA: 0x0018B611 File Offset: 0x00189811
		public unsafe int MaxLODSize_Smallest
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextureLODGroup.__PropertyOffset_MaxLODSize_Smallest);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextureLODGroup.__PropertyOffset_MaxLODSize_Smallest) = value;
			}
		}

		// Token: 0x170041BC RID: 16828
		// (get) Token: 0x06010D3C RID: 68924 RVA: 0x0018B622 File Offset: 0x00189822
		// (set) Token: 0x06010D3D RID: 68925 RVA: 0x0018B632 File Offset: 0x00189832
		public unsafe int OptionalLODBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextureLODGroup.__PropertyOffset_OptionalLODBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextureLODGroup.__PropertyOffset_OptionalLODBias) = value;
			}
		}

		// Token: 0x170041BD RID: 16829
		// (get) Token: 0x06010D3E RID: 68926 RVA: 0x0018B643 File Offset: 0x00189843
		// (set) Token: 0x06010D3F RID: 68927 RVA: 0x0018B653 File Offset: 0x00189853
		public unsafe int OptionalMaxLODSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextureLODGroup.__PropertyOffset_OptionalMaxLODSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextureLODGroup.__PropertyOffset_OptionalMaxLODSize) = value;
			}
		}

		// Token: 0x170041BE RID: 16830
		// (get) Token: 0x06010D40 RID: 68928 RVA: 0x0018B664 File Offset: 0x00189864
		// (set) Token: 0x06010D41 RID: 68929 RVA: 0x0018B678 File Offset: 0x00189878
		public unsafe FName MinMagFilter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextureLODGroup.__PropertyOffset_MinMagFilter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextureLODGroup.__PropertyOffset_MinMagFilter) = value;
			}
		}

		// Token: 0x170041BF RID: 16831
		// (get) Token: 0x06010D42 RID: 68930 RVA: 0x0018B68D File Offset: 0x0018988D
		// (set) Token: 0x06010D43 RID: 68931 RVA: 0x0018B6A1 File Offset: 0x001898A1
		public unsafe FName MipFilter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextureLODGroup.__PropertyOffset_MipFilter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextureLODGroup.__PropertyOffset_MipFilter) = value;
			}
		}

		// Token: 0x170041C0 RID: 16832
		// (get) Token: 0x06010D44 RID: 68932 RVA: 0x0018B6B6 File Offset: 0x001898B6
		// (set) Token: 0x06010D45 RID: 68933 RVA: 0x0018B6C6 File Offset: 0x001898C6
		public unsafe ETextureMipLoadOptions MipLoadOptions
		{
			get
			{
				return (ETextureMipLoadOptions)(*(base.NativePtr + (IntPtr)FTextureLODGroup.__PropertyOffset_MipLoadOptions));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextureLODGroup.__PropertyOffset_MipLoadOptions) = (byte)value;
			}
		}

		// Token: 0x170041C1 RID: 16833
		// (get) Token: 0x06010D46 RID: 68934 RVA: 0x0018B6D7 File Offset: 0x001898D7
		// (set) Token: 0x06010D47 RID: 68935 RVA: 0x0018B6E7 File Offset: 0x001898E7
		public unsafe bool DuplicateNonOptionalMips
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextureLODGroup.__PropertyOffset_DuplicateNonOptionalMips) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextureLODGroup.__PropertyOffset_DuplicateNonOptionalMips) = (value ? 1 : 0);
			}
		}

		// Token: 0x170041C2 RID: 16834
		// (get) Token: 0x06010D48 RID: 68936 RVA: 0x0018B6F8 File Offset: 0x001898F8
		// (set) Token: 0x06010D49 RID: 68937 RVA: 0x0018B708 File Offset: 0x00189908
		public unsafe float Downscale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextureLODGroup.__PropertyOffset_Downscale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextureLODGroup.__PropertyOffset_Downscale) = value;
			}
		}

		// Token: 0x170041C3 RID: 16835
		// (get) Token: 0x06010D4A RID: 68938 RVA: 0x0018B719 File Offset: 0x00189919
		// (set) Token: 0x06010D4B RID: 68939 RVA: 0x0018B729 File Offset: 0x00189929
		public unsafe ETextureDownscaleOptions DownscaleOptions
		{
			get
			{
				return (ETextureDownscaleOptions)(*(base.NativePtr + (IntPtr)FTextureLODGroup.__PropertyOffset_DownscaleOptions));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextureLODGroup.__PropertyOffset_DownscaleOptions) = (byte)value;
			}
		}

		// Token: 0x170041C4 RID: 16836
		// (get) Token: 0x06010D4C RID: 68940 RVA: 0x0018B73A File Offset: 0x0018993A
		// (set) Token: 0x06010D4D RID: 68941 RVA: 0x0018B74A File Offset: 0x0018994A
		public unsafe int VirtualTextureTileCountBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextureLODGroup.__PropertyOffset_VirtualTextureTileCountBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextureLODGroup.__PropertyOffset_VirtualTextureTileCountBias) = value;
			}
		}

		// Token: 0x170041C5 RID: 16837
		// (get) Token: 0x06010D4E RID: 68942 RVA: 0x0018B75B File Offset: 0x0018995B
		// (set) Token: 0x06010D4F RID: 68943 RVA: 0x0018B76B File Offset: 0x0018996B
		public unsafe int VirtualTextureTileSizeBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextureLODGroup.__PropertyOffset_VirtualTextureTileSizeBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextureLODGroup.__PropertyOffset_VirtualTextureTileSizeBias) = value;
			}
		}

		// Token: 0x170041C6 RID: 16838
		// (get) Token: 0x06010D50 RID: 68944 RVA: 0x0018B77C File Offset: 0x0018997C
		// (set) Token: 0x06010D51 RID: 68945 RVA: 0x0018B790 File Offset: 0x00189990
		public unsafe TEnumAsByte<ETextureLossyCompressionAmount> LossyCompressionAmount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextureLODGroup.__PropertyOffset_LossyCompressionAmount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextureLODGroup.__PropertyOffset_LossyCompressionAmount) = value;
			}
		}

		// Token: 0x06010D52 RID: 68946 RVA: 0x0018B7A5 File Offset: 0x001899A5
		public FTextureLODGroup()
		{
		}

		// Token: 0x06010D53 RID: 68947 RVA: 0x0018B7B0 File Offset: 0x001899B0
		public FTextureLODGroup(TEnumAsByte<TextureGroup> Group, int LODBias, int LODBias_Smaller, int LODBias_Smallest, int NumStreamedMips, TEnumAsByte<TextureMipGenSettings> MipGenSettings, int MinLODSize, int MaxLODSize, int MaxLODSize_Smaller, int MaxLODSize_Smallest, int OptionalLODBias, int OptionalMaxLODSize, FName MinMagFilter, FName MipFilter, ETextureMipLoadOptions MipLoadOptions, bool DuplicateNonOptionalMips, float Downscale, ETextureDownscaleOptions DownscaleOptions, int VirtualTextureTileCountBias, int VirtualTextureTileSizeBias, TEnumAsByte<ETextureLossyCompressionAmount> LossyCompressionAmount)
		{
			this.Group = Group;
			this.LODBias = LODBias;
			this.LODBias_Smaller = LODBias_Smaller;
			this.LODBias_Smallest = LODBias_Smallest;
			this.NumStreamedMips = NumStreamedMips;
			this.MipGenSettings = MipGenSettings;
			this.MinLODSize = MinLODSize;
			this.MaxLODSize = MaxLODSize;
			this.MaxLODSize_Smaller = MaxLODSize_Smaller;
			this.MaxLODSize_Smallest = MaxLODSize_Smallest;
			this.OptionalLODBias = OptionalLODBias;
			this.OptionalMaxLODSize = OptionalMaxLODSize;
			this.MinMagFilter = MinMagFilter;
			this.MipFilter = MipFilter;
			this.MipLoadOptions = MipLoadOptions;
			this.DuplicateNonOptionalMips = DuplicateNonOptionalMips;
			this.Downscale = Downscale;
			this.DownscaleOptions = DownscaleOptions;
			this.VirtualTextureTileCountBias = VirtualTextureTileCountBias;
			this.VirtualTextureTileSizeBias = VirtualTextureTileSizeBias;
			this.LossyCompressionAmount = LossyCompressionAmount;
		}

		// Token: 0x06010D54 RID: 68948 RVA: 0x0018B868 File Offset: 0x00189A68
		protected override IntPtr GetUStructPtr()
		{
			return FTextureLODGroup.StaticStruct();
		}

		// Token: 0x06010D55 RID: 68949 RVA: 0x0018B874 File Offset: 0x00189A74
		[NullableContext(2)]
		public FTextureLODGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010D56 RID: 68950 RVA: 0x0018B87E File Offset: 0x00189A7E
		public FTextureLODGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010D57 RID: 68951 RVA: 0x0018B889 File Offset: 0x00189A89
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTextureLODGroup(Pointer, false, true);
		}

		// Token: 0x06010D58 RID: 68952 RVA: 0x0018B893 File Offset: 0x00189A93
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTextureLODGroup(Pointer, MemoryOwner);
		}

		// Token: 0x04009028 RID: 36904
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.TextureLODGroup";

		// Token: 0x04009029 RID: 36905
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400902A RID: 36906
		internal static int __PropertyOffset_Group;

		// Token: 0x0400902B RID: 36907
		internal static int __PropertyOffset_LODBias;

		// Token: 0x0400902C RID: 36908
		internal static int __PropertyOffset_LODBias_Smaller;

		// Token: 0x0400902D RID: 36909
		internal static int __PropertyOffset_LODBias_Smallest;

		// Token: 0x0400902E RID: 36910
		internal static int __PropertyOffset_NumStreamedMips;

		// Token: 0x0400902F RID: 36911
		internal static int __PropertyOffset_MipGenSettings;

		// Token: 0x04009030 RID: 36912
		internal static int __PropertyOffset_MinLODSize;

		// Token: 0x04009031 RID: 36913
		internal static int __PropertyOffset_MaxLODSize;

		// Token: 0x04009032 RID: 36914
		internal static int __PropertyOffset_MaxLODSize_Smaller;

		// Token: 0x04009033 RID: 36915
		internal static int __PropertyOffset_MaxLODSize_Smallest;

		// Token: 0x04009034 RID: 36916
		internal static int __PropertyOffset_OptionalLODBias;

		// Token: 0x04009035 RID: 36917
		internal static int __PropertyOffset_OptionalMaxLODSize;

		// Token: 0x04009036 RID: 36918
		internal static int __PropertyOffset_MinMagFilter;

		// Token: 0x04009037 RID: 36919
		internal static int __PropertyOffset_MipFilter;

		// Token: 0x04009038 RID: 36920
		internal static int __PropertyOffset_MipLoadOptions;

		// Token: 0x04009039 RID: 36921
		internal static int __PropertyOffset_DuplicateNonOptionalMips;

		// Token: 0x0400903A RID: 36922
		internal static int __PropertyOffset_Downscale;

		// Token: 0x0400903B RID: 36923
		internal static int __PropertyOffset_DownscaleOptions;

		// Token: 0x0400903C RID: 36924
		internal static int __PropertyOffset_VirtualTextureTileCountBias;

		// Token: 0x0400903D RID: 36925
		internal static int __PropertyOffset_VirtualTextureTileSizeBias;

		// Token: 0x0400903E RID: 36926
		internal static int __PropertyOffset_LossyCompressionAmount;
	}
}
