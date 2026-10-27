using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020026A5 RID: 9893
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Renderer.TransvoxelRenderConfigDataAsset")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public class UTransvoxelRenderConfigDataAsset : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024CB3 RID: 150707 RVA: 0x00367147 File Offset: 0x00365347
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTransvoxelRenderConfigDataAsset._ClassPtr;
		}

		// Token: 0x06024CB4 RID: 150708 RVA: 0x00367154 File Offset: 0x00365354
		public UTransvoxelRenderConfigDataAsset() : this(BuiltinUtils.AllocNativeUObject(UTransvoxelRenderConfigDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024CB5 RID: 150709 RVA: 0x0036717C File Offset: 0x0036537C
		[NullableContext(1)]
		public UTransvoxelRenderConfigDataAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTransvoxelRenderConfigDataAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008E2A RID: 36394
		// (get) Token: 0x06024CB6 RID: 150710 RVA: 0x003671AF File Offset: 0x003653AF
		// (set) Token: 0x06024CB7 RID: 150711 RVA: 0x003671C3 File Offset: 0x003653C3
		public unsafe UMaterialInterface RuntimeChunkMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UTransvoxelRenderConfigDataAsset.__PropertyOffset_RuntimeChunkMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTransvoxelRenderConfigDataAsset.__PropertyOffset_RuntimeChunkMaterial, value);
			}
		}

		// Token: 0x17008E2B RID: 36395
		// (get) Token: 0x06024CB8 RID: 150712 RVA: 0x003671D8 File Offset: 0x003653D8
		// (set) Token: 0x06024CB9 RID: 150713 RVA: 0x003671EC File Offset: 0x003653EC
		public unsafe UTexture2D SourceHeightMapTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UTransvoxelRenderConfigDataAsset.__PropertyOffset_SourceHeightMapTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTransvoxelRenderConfigDataAsset.__PropertyOffset_SourceHeightMapTexture, value);
			}
		}

		// Token: 0x17008E2C RID: 36396
		// (get) Token: 0x06024CBA RID: 150714 RVA: 0x00367201 File Offset: 0x00365401
		// (set) Token: 0x06024CBB RID: 150715 RVA: 0x00367211 File Offset: 0x00365411
		public unsafe bool bEnableTexturedShading
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransvoxelRenderConfigDataAsset.__PropertyOffset_bEnableTexturedShading) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransvoxelRenderConfigDataAsset.__PropertyOffset_bEnableTexturedShading) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008E2D RID: 36397
		// (get) Token: 0x06024CBC RID: 150716 RVA: 0x00367222 File Offset: 0x00365422
		// (set) Token: 0x06024CBD RID: 150717 RVA: 0x00367232 File Offset: 0x00365432
		public unsafe bool bUseDitheredMaterialSampling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransvoxelRenderConfigDataAsset.__PropertyOffset_bUseDitheredMaterialSampling) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransvoxelRenderConfigDataAsset.__PropertyOffset_bUseDitheredMaterialSampling) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008E2E RID: 36398
		// (get) Token: 0x06024CBE RID: 150718 RVA: 0x00367243 File Offset: 0x00365443
		// (set) Token: 0x06024CBF RID: 150719 RVA: 0x00367257 File Offset: 0x00365457
		public unsafe UTexture2D SurfaceWeightTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UTransvoxelRenderConfigDataAsset.__PropertyOffset_SurfaceWeightTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTransvoxelRenderConfigDataAsset.__PropertyOffset_SurfaceWeightTexture, value);
			}
		}

		// Token: 0x17008E2F RID: 36399
		// (get) Token: 0x06024CC0 RID: 150720 RVA: 0x0036726C File Offset: 0x0036546C
		// (set) Token: 0x06024CC1 RID: 150721 RVA: 0x003672A5 File Offset: 0x003654A5
		[Nullable(1)]
		public TArray<UTexture2D> SurfaceDiffuseTextures
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UTexture2D> result;
				if ((result = this._SurfaceDiffuseTextures) == null)
				{
					result = (this._SurfaceDiffuseTextures = new TArray<UTexture2D>(base.NativePtr + (IntPtr)UTransvoxelRenderConfigDataAsset.__PropertyOffset_SurfaceDiffuseTextures, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SurfaceDiffuseTextures.CopyAssign(value);
			}
		}

		// Token: 0x17008E30 RID: 36400
		// (get) Token: 0x06024CC2 RID: 150722 RVA: 0x003672B4 File Offset: 0x003654B4
		// (set) Token: 0x06024CC3 RID: 150723 RVA: 0x003672ED File Offset: 0x003654ED
		[Nullable(1)]
		public TArray<UTexture2D> SurfaceNormalTextures
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UTexture2D> result;
				if ((result = this._SurfaceNormalTextures) == null)
				{
					result = (this._SurfaceNormalTextures = new TArray<UTexture2D>(base.NativePtr + (IntPtr)UTransvoxelRenderConfigDataAsset.__PropertyOffset_SurfaceNormalTextures, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SurfaceNormalTextures.CopyAssign(value);
			}
		}

		// Token: 0x17008E31 RID: 36401
		// (get) Token: 0x06024CC4 RID: 150724 RVA: 0x003672FC File Offset: 0x003654FC
		// (set) Token: 0x06024CC5 RID: 150725 RVA: 0x00367335 File Offset: 0x00365535
		[Nullable(1)]
		public TArray<UTexture2D> InteriorDiffuseTextures
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UTexture2D> result;
				if ((result = this._InteriorDiffuseTextures) == null)
				{
					result = (this._InteriorDiffuseTextures = new TArray<UTexture2D>(base.NativePtr + (IntPtr)UTransvoxelRenderConfigDataAsset.__PropertyOffset_InteriorDiffuseTextures, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.InteriorDiffuseTextures.CopyAssign(value);
			}
		}

		// Token: 0x17008E32 RID: 36402
		// (get) Token: 0x06024CC6 RID: 150726 RVA: 0x00367344 File Offset: 0x00365544
		// (set) Token: 0x06024CC7 RID: 150727 RVA: 0x0036737D File Offset: 0x0036557D
		[Nullable(1)]
		public TArray<UTexture2D> InteriorNormalTextures
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UTexture2D> result;
				if ((result = this._InteriorNormalTextures) == null)
				{
					result = (this._InteriorNormalTextures = new TArray<UTexture2D>(base.NativePtr + (IntPtr)UTransvoxelRenderConfigDataAsset.__PropertyOffset_InteriorNormalTextures, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.InteriorNormalTextures.CopyAssign(value);
			}
		}

		// Token: 0x17008E33 RID: 36403
		// (get) Token: 0x06024CC8 RID: 150728 RVA: 0x0036738B File Offset: 0x0036558B
		// (set) Token: 0x06024CC9 RID: 150729 RVA: 0x0036739F File Offset: 0x0036559F
		public unsafe UTexture2D LockedDiffuseTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UTransvoxelRenderConfigDataAsset.__PropertyOffset_LockedDiffuseTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTransvoxelRenderConfigDataAsset.__PropertyOffset_LockedDiffuseTexture, value);
			}
		}

		// Token: 0x17008E34 RID: 36404
		// (get) Token: 0x06024CCA RID: 150730 RVA: 0x003673B4 File Offset: 0x003655B4
		// (set) Token: 0x06024CCB RID: 150731 RVA: 0x003673C8 File Offset: 0x003655C8
		public unsafe UTexture2D LockedNormalTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UTransvoxelRenderConfigDataAsset.__PropertyOffset_LockedNormalTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTransvoxelRenderConfigDataAsset.__PropertyOffset_LockedNormalTexture, value);
			}
		}

		// Token: 0x17008E35 RID: 36405
		// (get) Token: 0x06024CCC RID: 150732 RVA: 0x003673DD File Offset: 0x003655DD
		// (set) Token: 0x06024CCD RID: 150733 RVA: 0x003673ED File Offset: 0x003655ED
		public unsafe float SurfaceHeightBlendWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransvoxelRenderConfigDataAsset.__PropertyOffset_SurfaceHeightBlendWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransvoxelRenderConfigDataAsset.__PropertyOffset_SurfaceHeightBlendWidth) = value;
			}
		}

		// Token: 0x17008E36 RID: 36406
		// (get) Token: 0x06024CCE RID: 150734 RVA: 0x003673FE File Offset: 0x003655FE
		// (set) Token: 0x06024CCF RID: 150735 RVA: 0x00367412 File Offset: 0x00365612
		public unsafe FVector2D MaterialWorldSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransvoxelRenderConfigDataAsset.__PropertyOffset_MaterialWorldSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransvoxelRenderConfigDataAsset.__PropertyOffset_MaterialWorldSize) = value;
			}
		}

		// Token: 0x17008E37 RID: 36407
		// (get) Token: 0x06024CD0 RID: 150736 RVA: 0x00367427 File Offset: 0x00365627
		// (set) Token: 0x06024CD1 RID: 150737 RVA: 0x00367437 File Offset: 0x00365637
		public unsafe float WorldTextureScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransvoxelRenderConfigDataAsset.__PropertyOffset_WorldTextureScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransvoxelRenderConfigDataAsset.__PropertyOffset_WorldTextureScale) = value;
			}
		}

		// Token: 0x17008E38 RID: 36408
		// (get) Token: 0x06024CD2 RID: 150738 RVA: 0x00367448 File Offset: 0x00365648
		// (set) Token: 0x06024CD3 RID: 150739 RVA: 0x00367458 File Offset: 0x00365658
		public unsafe bool bUseTriplanarMaterialSampling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransvoxelRenderConfigDataAsset.__PropertyOffset_bUseTriplanarMaterialSampling) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransvoxelRenderConfigDataAsset.__PropertyOffset_bUseTriplanarMaterialSampling) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008E39 RID: 36409
		// (get) Token: 0x06024CD4 RID: 150740 RVA: 0x00367469 File Offset: 0x00365669
		// (set) Token: 0x06024CD5 RID: 150741 RVA: 0x00367479 File Offset: 0x00365679
		public unsafe float TriplanarBlendSharpness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransvoxelRenderConfigDataAsset.__PropertyOffset_TriplanarBlendSharpness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransvoxelRenderConfigDataAsset.__PropertyOffset_TriplanarBlendSharpness) = value;
			}
		}

		// Token: 0x17008E3A RID: 36410
		// (get) Token: 0x06024CD6 RID: 150742 RVA: 0x0036748A File Offset: 0x0036568A
		// (set) Token: 0x06024CD7 RID: 150743 RVA: 0x0036749A File Offset: 0x0036569A
		public unsafe float NormalMapStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTransvoxelRenderConfigDataAsset.__PropertyOffset_NormalMapStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTransvoxelRenderConfigDataAsset.__PropertyOffset_NormalMapStrength) = value;
			}
		}

		// Token: 0x17008E3B RID: 36411
		// (get) Token: 0x06024CD8 RID: 150744 RVA: 0x003674AC File Offset: 0x003656AC
		// (set) Token: 0x06024CD9 RID: 150745 RVA: 0x003674E5 File Offset: 0x003656E5
		[Nullable(1)]
		public TArray<FTransvoxelRenderHeightSplatPoint> HeightSplatPoints
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FTransvoxelRenderHeightSplatPoint> result;
				if ((result = this._HeightSplatPoints) == null)
				{
					result = (this._HeightSplatPoints = new TArray<FTransvoxelRenderHeightSplatPoint>(base.NativePtr + (IntPtr)UTransvoxelRenderConfigDataAsset.__PropertyOffset_HeightSplatPoints, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.HeightSplatPoints.CopyAssign(value);
			}
		}

		// Token: 0x17008E3C RID: 36412
		// (get) Token: 0x06024CDA RID: 150746 RVA: 0x003674F3 File Offset: 0x003656F3
		// (set) Token: 0x06024CDB RID: 150747 RVA: 0x00367507 File Offset: 0x00365707
		public unsafe UMaterialInterface GrassRenderMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UTransvoxelRenderConfigDataAsset.__PropertyOffset_GrassRenderMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTransvoxelRenderConfigDataAsset.__PropertyOffset_GrassRenderMaterial, value);
			}
		}

		// Token: 0x06024CDC RID: 150748 RVA: 0x0036751C File Offset: 0x0036571C
		static UTransvoxelRenderConfigDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Renderer.TransvoxelRenderConfigDataAsset");
		}

		// Token: 0x06024CDD RID: 150749 RVA: 0x0036752A File Offset: 0x0036572A
		protected UTransvoxelRenderConfigDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013C6B RID: 81003
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Renderer.TransvoxelRenderConfigDataAsset";

		// Token: 0x04013C6C RID: 81004
		private static IntPtr _ClassPtr;

		// Token: 0x04013C6D RID: 81005
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013C6E RID: 81006
		internal static int __PropertyOffset_RuntimeChunkMaterial;

		// Token: 0x04013C6F RID: 81007
		internal static int __PropertyOffset_SourceHeightMapTexture;

		// Token: 0x04013C70 RID: 81008
		internal static int __PropertyOffset_bEnableTexturedShading;

		// Token: 0x04013C71 RID: 81009
		internal static int __PropertyOffset_bUseDitheredMaterialSampling;

		// Token: 0x04013C72 RID: 81010
		internal static int __PropertyOffset_SurfaceWeightTexture;

		// Token: 0x04013C73 RID: 81011
		internal static int __PropertyOffset_SurfaceDiffuseTextures;

		// Token: 0x04013C74 RID: 81012
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UTexture2D> _SurfaceDiffuseTextures;

		// Token: 0x04013C75 RID: 81013
		internal static int __PropertyOffset_SurfaceNormalTextures;

		// Token: 0x04013C76 RID: 81014
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UTexture2D> _SurfaceNormalTextures;

		// Token: 0x04013C77 RID: 81015
		internal static int __PropertyOffset_InteriorDiffuseTextures;

		// Token: 0x04013C78 RID: 81016
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UTexture2D> _InteriorDiffuseTextures;

		// Token: 0x04013C79 RID: 81017
		internal static int __PropertyOffset_InteriorNormalTextures;

		// Token: 0x04013C7A RID: 81018
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UTexture2D> _InteriorNormalTextures;

		// Token: 0x04013C7B RID: 81019
		internal static int __PropertyOffset_LockedDiffuseTexture;

		// Token: 0x04013C7C RID: 81020
		internal static int __PropertyOffset_LockedNormalTexture;

		// Token: 0x04013C7D RID: 81021
		internal static int __PropertyOffset_SurfaceHeightBlendWidth;

		// Token: 0x04013C7E RID: 81022
		internal static int __PropertyOffset_MaterialWorldSize;

		// Token: 0x04013C7F RID: 81023
		internal static int __PropertyOffset_WorldTextureScale;

		// Token: 0x04013C80 RID: 81024
		internal static int __PropertyOffset_bUseTriplanarMaterialSampling;

		// Token: 0x04013C81 RID: 81025
		internal static int __PropertyOffset_TriplanarBlendSharpness;

		// Token: 0x04013C82 RID: 81026
		internal static int __PropertyOffset_NormalMapStrength;

		// Token: 0x04013C83 RID: 81027
		internal static int __PropertyOffset_HeightSplatPoints;

		// Token: 0x04013C84 RID: 81028
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FTransvoxelRenderHeightSplatPoint> _HeightSplatPoints;

		// Token: 0x04013C85 RID: 81029
		internal static int __PropertyOffset_GrassRenderMaterial;
	}
}
