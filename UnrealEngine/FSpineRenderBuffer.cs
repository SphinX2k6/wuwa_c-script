using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002109 RID: 8457
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.SpineRenderBuffer")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 216)]
	public class FSpineRenderBuffer : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FD2A RID: 130346 RVA: 0x002F541E File Offset: 0x002F361E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSpineRenderBuffer._ScriptStructPtr != 0) ? FSpineRenderBuffer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.SpineRenderBuffer", ref FSpineRenderBuffer._ScriptStructPtr);
		}

		// Token: 0x17007D2B RID: 32043
		// (get) Token: 0x0601FD2B RID: 130347 RVA: 0x002F5444 File Offset: 0x002F3644
		// (set) Token: 0x0601FD2C RID: 130348 RVA: 0x002F5487 File Offset: 0x002F3687
		public TArray<UMaterialInstanceDynamic> AtlasNormalBlendMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._AtlasNormalBlendMaterials) == null)
				{
					result = (this._AtlasNormalBlendMaterials = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)FSpineRenderBuffer.__PropertyOffset_AtlasNormalBlendMaterials, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AtlasNormalBlendMaterials.CopyAssign(value);
			}
		}

		// Token: 0x17007D2C RID: 32044
		// (get) Token: 0x0601FD2D RID: 130349 RVA: 0x002F5498 File Offset: 0x002F3698
		// (set) Token: 0x0601FD2E RID: 130350 RVA: 0x002F54DB File Offset: 0x002F36DB
		public TArray<UMaterialInstanceDynamic> AtlasAdditiveBlendMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._AtlasAdditiveBlendMaterials) == null)
				{
					result = (this._AtlasAdditiveBlendMaterials = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)FSpineRenderBuffer.__PropertyOffset_AtlasAdditiveBlendMaterials, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AtlasAdditiveBlendMaterials.CopyAssign(value);
			}
		}

		// Token: 0x17007D2D RID: 32045
		// (get) Token: 0x0601FD2F RID: 130351 RVA: 0x002F54EC File Offset: 0x002F36EC
		// (set) Token: 0x0601FD30 RID: 130352 RVA: 0x002F552F File Offset: 0x002F372F
		public TArray<UMaterialInstanceDynamic> AtlasMultiplyBlendMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._AtlasMultiplyBlendMaterials) == null)
				{
					result = (this._AtlasMultiplyBlendMaterials = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)FSpineRenderBuffer.__PropertyOffset_AtlasMultiplyBlendMaterials, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AtlasMultiplyBlendMaterials.CopyAssign(value);
			}
		}

		// Token: 0x17007D2E RID: 32046
		// (get) Token: 0x0601FD31 RID: 130353 RVA: 0x002F5540 File Offset: 0x002F3740
		// (set) Token: 0x0601FD32 RID: 130354 RVA: 0x002F5583 File Offset: 0x002F3783
		public TArray<UMaterialInstanceDynamic> AtlasScreenBlendMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._AtlasScreenBlendMaterials) == null)
				{
					result = (this._AtlasScreenBlendMaterials = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)FSpineRenderBuffer.__PropertyOffset_AtlasScreenBlendMaterials, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AtlasScreenBlendMaterials.CopyAssign(value);
			}
		}

		// Token: 0x17007D2F RID: 32047
		// (get) Token: 0x0601FD33 RID: 130355 RVA: 0x002F5594 File Offset: 0x002F3794
		// (set) Token: 0x0601FD34 RID: 130356 RVA: 0x002F55D7 File Offset: 0x002F37D7
		public TArray<UMaterialInterface> SpineMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._SpineMaterials) == null)
				{
					result = (this._SpineMaterials = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)FSpineRenderBuffer.__PropertyOffset_SpineMaterials, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SpineMaterials.CopyAssign(value);
			}
		}

		// Token: 0x17007D30 RID: 32048
		// (get) Token: 0x0601FD35 RID: 130357 RVA: 0x002F55E8 File Offset: 0x002F37E8
		// (set) Token: 0x0601FD36 RID: 130358 RVA: 0x002F562B File Offset: 0x002F382B
		public TMap<int, FLinearColor> MeshColorMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, FLinearColor> result;
				if ((result = this._MeshColorMap) == null)
				{
					result = (this._MeshColorMap = new TMap<int, FLinearColor>(base.NativePtr + (IntPtr)FSpineRenderBuffer.__PropertyOffset_MeshColorMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MeshColorMap.CopyAssign(value);
			}
		}

		// Token: 0x0601FD37 RID: 130359 RVA: 0x002F5639 File Offset: 0x002F3839
		public FSpineRenderBuffer()
		{
		}

		// Token: 0x0601FD38 RID: 130360 RVA: 0x002F5641 File Offset: 0x002F3841
		public FSpineRenderBuffer(TArray<UMaterialInstanceDynamic> AtlasNormalBlendMaterials, TArray<UMaterialInstanceDynamic> AtlasAdditiveBlendMaterials, TArray<UMaterialInstanceDynamic> AtlasMultiplyBlendMaterials, TArray<UMaterialInstanceDynamic> AtlasScreenBlendMaterials, TArray<UMaterialInterface> SpineMaterials, TMap<int, FLinearColor> MeshColorMap)
		{
			this.AtlasNormalBlendMaterials = AtlasNormalBlendMaterials;
			this.AtlasAdditiveBlendMaterials = AtlasAdditiveBlendMaterials;
			this.AtlasMultiplyBlendMaterials = AtlasMultiplyBlendMaterials;
			this.AtlasScreenBlendMaterials = AtlasScreenBlendMaterials;
			this.SpineMaterials = SpineMaterials;
			this.MeshColorMap = MeshColorMap;
		}

		// Token: 0x0601FD39 RID: 130361 RVA: 0x002F5676 File Offset: 0x002F3876
		protected override IntPtr GetUStructPtr()
		{
			return FSpineRenderBuffer.StaticStruct();
		}

		// Token: 0x0601FD3A RID: 130362 RVA: 0x002F5682 File Offset: 0x002F3882
		[NullableContext(2)]
		public FSpineRenderBuffer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FD3B RID: 130363 RVA: 0x002F568C File Offset: 0x002F388C
		public FSpineRenderBuffer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FD3C RID: 130364 RVA: 0x002F5697 File Offset: 0x002F3897
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSpineRenderBuffer(Pointer, false, true);
		}

		// Token: 0x0601FD3D RID: 130365 RVA: 0x002F56A1 File Offset: 0x002F38A1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSpineRenderBuffer(Pointer, MemoryOwner);
		}

		// Token: 0x0401125F RID: 70239
		public const string __ObjectPath = "/Script/LGUI.SpineRenderBuffer";

		// Token: 0x04011260 RID: 70240
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011261 RID: 70241
		internal static int __PropertyOffset_AtlasNormalBlendMaterials;

		// Token: 0x04011262 RID: 70242
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _AtlasNormalBlendMaterials;

		// Token: 0x04011263 RID: 70243
		internal static int __PropertyOffset_AtlasAdditiveBlendMaterials;

		// Token: 0x04011264 RID: 70244
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _AtlasAdditiveBlendMaterials;

		// Token: 0x04011265 RID: 70245
		internal static int __PropertyOffset_AtlasMultiplyBlendMaterials;

		// Token: 0x04011266 RID: 70246
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _AtlasMultiplyBlendMaterials;

		// Token: 0x04011267 RID: 70247
		internal static int __PropertyOffset_AtlasScreenBlendMaterials;

		// Token: 0x04011268 RID: 70248
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _AtlasScreenBlendMaterials;

		// Token: 0x04011269 RID: 70249
		internal static int __PropertyOffset_SpineMaterials;

		// Token: 0x0401126A RID: 70250
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _SpineMaterials;

		// Token: 0x0401126B RID: 70251
		internal static int __PropertyOffset_MeshColorMap;

		// Token: 0x0401126C RID: 70252
		[Nullable(2)]
		private TMap<int, FLinearColor> _MeshColorMap;
	}
}
