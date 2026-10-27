using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028D5 RID: 10453
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/T4MRuntime.T4MLandscapeComponent")]
	[UnrealStructLayout(2304, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2304)]
	public class UT4MLandscapeComponent : UStaticMeshComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026C86 RID: 158854 RVA: 0x003B2637 File Offset: 0x003B0837
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UT4MLandscapeComponent._ClassPtr;
		}

		// Token: 0x06026C87 RID: 158855 RVA: 0x003B2644 File Offset: 0x003B0844
		public UT4MLandscapeComponent() : this(BuiltinUtils.AllocNativeUObject(UT4MLandscapeComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026C88 RID: 158856 RVA: 0x003B266C File Offset: 0x003B086C
		[NullableContext(1)]
		public UT4MLandscapeComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UT4MLandscapeComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009560 RID: 38240
		// (get) Token: 0x06026C89 RID: 158857 RVA: 0x003B269F File Offset: 0x003B089F
		// (set) Token: 0x06026C8A RID: 158858 RVA: 0x003B26B3 File Offset: 0x003B08B3
		public unsafe FGuid MapBuildDataId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UT4MLandscapeComponent.__PropertyOffset_MapBuildDataId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UT4MLandscapeComponent.__PropertyOffset_MapBuildDataId) = value;
			}
		}

		// Token: 0x17009561 RID: 38241
		// (get) Token: 0x06026C8B RID: 158859 RVA: 0x003B26C8 File Offset: 0x003B08C8
		// (set) Token: 0x06026C8C RID: 158860 RVA: 0x003B26D8 File Offset: 0x003B08D8
		public unsafe int SectionBaseX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UT4MLandscapeComponent.__PropertyOffset_SectionBaseX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UT4MLandscapeComponent.__PropertyOffset_SectionBaseX) = value;
			}
		}

		// Token: 0x17009562 RID: 38242
		// (get) Token: 0x06026C8D RID: 158861 RVA: 0x003B26E9 File Offset: 0x003B08E9
		// (set) Token: 0x06026C8E RID: 158862 RVA: 0x003B26F9 File Offset: 0x003B08F9
		public unsafe int SectionBaseY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UT4MLandscapeComponent.__PropertyOffset_SectionBaseY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UT4MLandscapeComponent.__PropertyOffset_SectionBaseY) = value;
			}
		}

		// Token: 0x17009563 RID: 38243
		// (get) Token: 0x06026C8F RID: 158863 RVA: 0x003B270A File Offset: 0x003B090A
		// (set) Token: 0x06026C90 RID: 158864 RVA: 0x003B271A File Offset: 0x003B091A
		public unsafe int ComponentSizeQuads
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UT4MLandscapeComponent.__PropertyOffset_ComponentSizeQuads);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UT4MLandscapeComponent.__PropertyOffset_ComponentSizeQuads) = value;
			}
		}

		// Token: 0x17009564 RID: 38244
		// (get) Token: 0x06026C91 RID: 158865 RVA: 0x003B272B File Offset: 0x003B092B
		// (set) Token: 0x06026C92 RID: 158866 RVA: 0x003B273B File Offset: 0x003B093B
		public unsafe int SubsectionSizeQuads
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UT4MLandscapeComponent.__PropertyOffset_SubsectionSizeQuads);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UT4MLandscapeComponent.__PropertyOffset_SubsectionSizeQuads) = value;
			}
		}

		// Token: 0x17009565 RID: 38245
		// (get) Token: 0x06026C93 RID: 158867 RVA: 0x003B274C File Offset: 0x003B094C
		// (set) Token: 0x06026C94 RID: 158868 RVA: 0x003B275C File Offset: 0x003B095C
		public unsafe int NumSubsections
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UT4MLandscapeComponent.__PropertyOffset_NumSubsections);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UT4MLandscapeComponent.__PropertyOffset_NumSubsections) = value;
			}
		}

		// Token: 0x17009566 RID: 38246
		// (get) Token: 0x06026C95 RID: 158869 RVA: 0x003B276D File Offset: 0x003B096D
		// (set) Token: 0x06026C96 RID: 158870 RVA: 0x003B2781 File Offset: 0x003B0981
		public unsafe FVector4 WeightmapScaleBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UT4MLandscapeComponent.__PropertyOffset_WeightmapScaleBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UT4MLandscapeComponent.__PropertyOffset_WeightmapScaleBias) = value;
			}
		}

		// Token: 0x17009567 RID: 38247
		// (get) Token: 0x06026C97 RID: 158871 RVA: 0x003B2796 File Offset: 0x003B0996
		// (set) Token: 0x06026C98 RID: 158872 RVA: 0x003B27A6 File Offset: 0x003B09A6
		public unsafe float WeightmapSubsectionOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UT4MLandscapeComponent.__PropertyOffset_WeightmapSubsectionOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UT4MLandscapeComponent.__PropertyOffset_WeightmapSubsectionOffset) = value;
			}
		}

		// Token: 0x17009568 RID: 38248
		// (get) Token: 0x06026C99 RID: 158873 RVA: 0x003B27B7 File Offset: 0x003B09B7
		// (set) Token: 0x06026C9A RID: 158874 RVA: 0x003B27C7 File Offset: 0x003B09C7
		public unsafe float HeightmapSubsectionOffsetU
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UT4MLandscapeComponent.__PropertyOffset_HeightmapSubsectionOffsetU);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UT4MLandscapeComponent.__PropertyOffset_HeightmapSubsectionOffsetU) = value;
			}
		}

		// Token: 0x17009569 RID: 38249
		// (get) Token: 0x06026C9B RID: 158875 RVA: 0x003B27D8 File Offset: 0x003B09D8
		// (set) Token: 0x06026C9C RID: 158876 RVA: 0x003B27E8 File Offset: 0x003B09E8
		public unsafe float HeightmapSubsectionOffsetV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UT4MLandscapeComponent.__PropertyOffset_HeightmapSubsectionOffsetV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UT4MLandscapeComponent.__PropertyOffset_HeightmapSubsectionOffsetV) = value;
			}
		}

		// Token: 0x1700956A RID: 38250
		// (get) Token: 0x06026C9D RID: 158877 RVA: 0x003B27F9 File Offset: 0x003B09F9
		// (set) Token: 0x06026C9E RID: 158878 RVA: 0x003B280D File Offset: 0x003B0A0D
		public unsafe FVector4 HeightmapScaleBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UT4MLandscapeComponent.__PropertyOffset_HeightmapScaleBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UT4MLandscapeComponent.__PropertyOffset_HeightmapScaleBias) = value;
			}
		}

		// Token: 0x1700956B RID: 38251
		// (get) Token: 0x06026C9F RID: 158879 RVA: 0x003B2822 File Offset: 0x003B0A22
		// (set) Token: 0x06026CA0 RID: 158880 RVA: 0x003B2832 File Offset: 0x003B0A32
		public unsafe byte BlendableLayerMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UT4MLandscapeComponent.__PropertyOffset_BlendableLayerMask);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UT4MLandscapeComponent.__PropertyOffset_BlendableLayerMask) = value;
			}
		}

		// Token: 0x1700956C RID: 38252
		// (get) Token: 0x06026CA1 RID: 158881 RVA: 0x003B2843 File Offset: 0x003B0A43
		// (set) Token: 0x06026CA2 RID: 158882 RVA: 0x003B2853 File Offset: 0x003B0A53
		public unsafe float StaticLightingLOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UT4MLandscapeComponent.__PropertyOffset_StaticLightingLOD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UT4MLandscapeComponent.__PropertyOffset_StaticLightingLOD) = value;
			}
		}

		// Token: 0x1700956D RID: 38253
		// (get) Token: 0x06026CA3 RID: 158883 RVA: 0x003B2864 File Offset: 0x003B0A64
		// (set) Token: 0x06026CA4 RID: 158884 RVA: 0x003B2874 File Offset: 0x003B0A74
		public unsafe float StaticLightingResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UT4MLandscapeComponent.__PropertyOffset_StaticLightingResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UT4MLandscapeComponent.__PropertyOffset_StaticLightingResolution) = value;
			}
		}

		// Token: 0x1700956E RID: 38254
		// (get) Token: 0x06026CA5 RID: 158885 RVA: 0x003B2885 File Offset: 0x003B0A85
		// (set) Token: 0x06026CA6 RID: 158886 RVA: 0x003B2899 File Offset: 0x003B0A99
		public unsafe UTexture2D NormalmapTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UT4MLandscapeComponent.__PropertyOffset_NormalmapTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UT4MLandscapeComponent.__PropertyOffset_NormalmapTexture, value);
			}
		}

		// Token: 0x1700956F RID: 38255
		// (get) Token: 0x06026CA7 RID: 158887 RVA: 0x003B28B0 File Offset: 0x003B0AB0
		// (set) Token: 0x06026CA8 RID: 158888 RVA: 0x003B28E9 File Offset: 0x003B0AE9
		[Nullable(1)]
		public TArray<UTexture2D> WeightmapTextures
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UTexture2D> result;
				if ((result = this._WeightmapTextures) == null)
				{
					result = (this._WeightmapTextures = new TArray<UTexture2D>(base.NativePtr + (IntPtr)UT4MLandscapeComponent.__PropertyOffset_WeightmapTextures, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.WeightmapTextures.CopyAssign(value);
			}
		}

		// Token: 0x17009570 RID: 38256
		// (get) Token: 0x06026CA9 RID: 158889 RVA: 0x003B28F7 File Offset: 0x003B0AF7
		// (set) Token: 0x06026CAA RID: 158890 RVA: 0x003B290B File Offset: 0x003B0B0B
		public unsafe UTexture2D IndexmapTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UT4MLandscapeComponent.__PropertyOffset_IndexmapTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UT4MLandscapeComponent.__PropertyOffset_IndexmapTexture, value);
			}
		}

		// Token: 0x17009571 RID: 38257
		// (get) Token: 0x06026CAB RID: 158891 RVA: 0x003B2920 File Offset: 0x003B0B20
		// (set) Token: 0x06026CAC RID: 158892 RVA: 0x003B2934 File Offset: 0x003B0B34
		public unsafe UTexture2D BlendmapTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UT4MLandscapeComponent.__PropertyOffset_BlendmapTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UT4MLandscapeComponent.__PropertyOffset_BlendmapTexture, value);
			}
		}

		// Token: 0x17009572 RID: 38258
		// (get) Token: 0x06026CAD RID: 158893 RVA: 0x003B2949 File Offset: 0x003B0B49
		// (set) Token: 0x06026CAE RID: 158894 RVA: 0x003B295D File Offset: 0x003B0B5D
		public unsafe UTexture2D KuroColormapTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UT4MLandscapeComponent.__PropertyOffset_KuroColormapTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UT4MLandscapeComponent.__PropertyOffset_KuroColormapTexture, value);
			}
		}

		// Token: 0x17009573 RID: 38259
		// (get) Token: 0x06026CAF RID: 158895 RVA: 0x003B2974 File Offset: 0x003B0B74
		// (set) Token: 0x06026CB0 RID: 158896 RVA: 0x003B29AD File Offset: 0x003B0BAD
		[Nullable(1)]
		public TArray<FVector4> LandscapeLayerParams
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector4> result;
				if ((result = this._LandscapeLayerParams) == null)
				{
					result = (this._LandscapeLayerParams = new TArray<FVector4>(base.NativePtr + (IntPtr)UT4MLandscapeComponent.__PropertyOffset_LandscapeLayerParams, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LandscapeLayerParams.CopyAssign(value);
			}
		}

		// Token: 0x17009574 RID: 38260
		// (get) Token: 0x06026CB1 RID: 158897 RVA: 0x003B29BC File Offset: 0x003B0BBC
		// (set) Token: 0x06026CB2 RID: 158898 RVA: 0x003B29F5 File Offset: 0x003B0BF5
		[Nullable(1)]
		public TArray<UMaterialInstanceConstant> MaterialInstances
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceConstant> result;
				if ((result = this._MaterialInstances) == null)
				{
					result = (this._MaterialInstances = new TArray<UMaterialInstanceConstant>(base.NativePtr + (IntPtr)UT4MLandscapeComponent.__PropertyOffset_MaterialInstances, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MaterialInstances.CopyAssign(value);
			}
		}

		// Token: 0x06026CB3 RID: 158899 RVA: 0x003B2A03 File Offset: 0x003B0C03
		public void GenerateLandscapeLayerParams(bool bMarkRenderStateDirty = false)
		{
			UT4MLandscapeComponent.__GenerateLandscapeLayerParams_Internal(base.NativePtr, bMarkRenderStateDirty);
		}

		// Token: 0x06026CB4 RID: 158900
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GenerateLandscapeLayerParams_Internal(IntPtr @this, bool bMarkRenderStateDirty);

		// Token: 0x06026CB5 RID: 158901 RVA: 0x003B2A11 File Offset: 0x003B0C11
		static UT4MLandscapeComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/T4MRuntime.T4MLandscapeComponent");
		}

		// Token: 0x06026CB6 RID: 158902 RVA: 0x003B2A1F File Offset: 0x003B0C1F
		protected UT4MLandscapeComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401549C RID: 87196
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/T4MRuntime.T4MLandscapeComponent";

		// Token: 0x0401549D RID: 87197
		private static IntPtr _ClassPtr;

		// Token: 0x0401549E RID: 87198
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401549F RID: 87199
		internal static int __PropertyOffset_MapBuildDataId;

		// Token: 0x040154A0 RID: 87200
		internal static int __PropertyOffset_SectionBaseX;

		// Token: 0x040154A1 RID: 87201
		internal static int __PropertyOffset_SectionBaseY;

		// Token: 0x040154A2 RID: 87202
		internal static int __PropertyOffset_ComponentSizeQuads;

		// Token: 0x040154A3 RID: 87203
		internal static int __PropertyOffset_SubsectionSizeQuads;

		// Token: 0x040154A4 RID: 87204
		internal static int __PropertyOffset_NumSubsections;

		// Token: 0x040154A5 RID: 87205
		internal static int __PropertyOffset_WeightmapScaleBias;

		// Token: 0x040154A6 RID: 87206
		internal static int __PropertyOffset_WeightmapSubsectionOffset;

		// Token: 0x040154A7 RID: 87207
		internal static int __PropertyOffset_HeightmapSubsectionOffsetU;

		// Token: 0x040154A8 RID: 87208
		internal static int __PropertyOffset_HeightmapSubsectionOffsetV;

		// Token: 0x040154A9 RID: 87209
		internal static int __PropertyOffset_HeightmapScaleBias;

		// Token: 0x040154AA RID: 87210
		internal static int __PropertyOffset_BlendableLayerMask;

		// Token: 0x040154AB RID: 87211
		internal static int __PropertyOffset_StaticLightingLOD;

		// Token: 0x040154AC RID: 87212
		internal static int __PropertyOffset_StaticLightingResolution;

		// Token: 0x040154AD RID: 87213
		internal static int __PropertyOffset_NormalmapTexture;

		// Token: 0x040154AE RID: 87214
		internal static int __PropertyOffset_WeightmapTextures;

		// Token: 0x040154AF RID: 87215
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UTexture2D> _WeightmapTextures;

		// Token: 0x040154B0 RID: 87216
		internal static int __PropertyOffset_IndexmapTexture;

		// Token: 0x040154B1 RID: 87217
		internal static int __PropertyOffset_BlendmapTexture;

		// Token: 0x040154B2 RID: 87218
		internal static int __PropertyOffset_KuroColormapTexture;

		// Token: 0x040154B3 RID: 87219
		internal static int __PropertyOffset_LandscapeLayerParams;

		// Token: 0x040154B4 RID: 87220
		private TArray<FVector4> _LandscapeLayerParams;

		// Token: 0x040154B5 RID: 87221
		internal static int __PropertyOffset_MaterialInstances;

		// Token: 0x040154B6 RID: 87222
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceConstant> _MaterialInstances;
	}
}
