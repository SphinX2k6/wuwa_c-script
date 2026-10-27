using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D7A RID: 3450
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialCachedExpressionData")]
	[UnrealStructLayout(888, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 888)]
	public class FMaterialCachedExpressionData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600BC83 RID: 48259 RVA: 0x0010D2CE File Offset: 0x0010B4CE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMaterialCachedExpressionData._ScriptStructPtr != 0) ? FMaterialCachedExpressionData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MaterialCachedExpressionData", ref FMaterialCachedExpressionData._ScriptStructPtr);
		}

		// Token: 0x17002BB7 RID: 11191
		// (get) Token: 0x0600BC84 RID: 48260 RVA: 0x0010D2F4 File Offset: 0x0010B4F4
		// (set) Token: 0x0600BC85 RID: 48261 RVA: 0x0010D337 File Offset: 0x0010B537
		public FMaterialCachedParameters Parameters
		{
			get
			{
				base.FastCheckIsValid();
				FMaterialCachedParameters result;
				if ((result = this._Parameters) == null)
				{
					result = (this._Parameters = new FMaterialCachedParameters(base.NativePtr + (IntPtr)FMaterialCachedExpressionData.__PropertyOffset_Parameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMaterialCachedParameters.StaticStruct(), base.NativePtr + (IntPtr)FMaterialCachedExpressionData.__PropertyOffset_Parameters, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002BB8 RID: 11192
		// (get) Token: 0x0600BC86 RID: 48262 RVA: 0x0010D358 File Offset: 0x0010B558
		// (set) Token: 0x0600BC87 RID: 48263 RVA: 0x0010D39B File Offset: 0x0010B59B
		public TArray<UObject> ReferencedTextures
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._ReferencedTextures) == null)
				{
					result = (this._ReferencedTextures = new TArray<UObject>(base.NativePtr + (IntPtr)FMaterialCachedExpressionData.__PropertyOffset_ReferencedTextures, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ReferencedTextures.CopyAssign(value);
			}
		}

		// Token: 0x17002BB9 RID: 11193
		// (get) Token: 0x0600BC88 RID: 48264 RVA: 0x0010D3AC File Offset: 0x0010B5AC
		// (set) Token: 0x0600BC89 RID: 48265 RVA: 0x0010D3EF File Offset: 0x0010B5EF
		public TArray<FMaterialFunctionInfo> FunctionInfos
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMaterialFunctionInfo> result;
				if ((result = this._FunctionInfos) == null)
				{
					result = (this._FunctionInfos = new TArray<FMaterialFunctionInfo>(base.NativePtr + (IntPtr)FMaterialCachedExpressionData.__PropertyOffset_FunctionInfos, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FunctionInfos.CopyAssign(value);
			}
		}

		// Token: 0x17002BBA RID: 11194
		// (get) Token: 0x0600BC8A RID: 48266 RVA: 0x0010D400 File Offset: 0x0010B600
		// (set) Token: 0x0600BC8B RID: 48267 RVA: 0x0010D443 File Offset: 0x0010B643
		public TArray<FMaterialParameterCollectionInfo> ParameterCollectionInfos
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMaterialParameterCollectionInfo> result;
				if ((result = this._ParameterCollectionInfos) == null)
				{
					result = (this._ParameterCollectionInfos = new TArray<FMaterialParameterCollectionInfo>(base.NativePtr + (IntPtr)FMaterialCachedExpressionData.__PropertyOffset_ParameterCollectionInfos, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ParameterCollectionInfos.CopyAssign(value);
			}
		}

		// Token: 0x17002BBB RID: 11195
		// (get) Token: 0x0600BC8C RID: 48268 RVA: 0x0010D454 File Offset: 0x0010B654
		// (set) Token: 0x0600BC8D RID: 48269 RVA: 0x0010D497 File Offset: 0x0010B697
		public TArray<UMaterialFunctionInterface> DefaultLayers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialFunctionInterface> result;
				if ((result = this._DefaultLayers) == null)
				{
					result = (this._DefaultLayers = new TArray<UMaterialFunctionInterface>(base.NativePtr + (IntPtr)FMaterialCachedExpressionData.__PropertyOffset_DefaultLayers, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DefaultLayers.CopyAssign(value);
			}
		}

		// Token: 0x17002BBC RID: 11196
		// (get) Token: 0x0600BC8E RID: 48270 RVA: 0x0010D4A8 File Offset: 0x0010B6A8
		// (set) Token: 0x0600BC8F RID: 48271 RVA: 0x0010D4EB File Offset: 0x0010B6EB
		public TArray<UMaterialFunctionInterface> DefaultLayerBlends
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialFunctionInterface> result;
				if ((result = this._DefaultLayerBlends) == null)
				{
					result = (this._DefaultLayerBlends = new TArray<UMaterialFunctionInterface>(base.NativePtr + (IntPtr)FMaterialCachedExpressionData.__PropertyOffset_DefaultLayerBlends, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DefaultLayerBlends.CopyAssign(value);
			}
		}

		// Token: 0x17002BBD RID: 11197
		// (get) Token: 0x0600BC90 RID: 48272 RVA: 0x0010D4FC File Offset: 0x0010B6FC
		// (set) Token: 0x0600BC91 RID: 48273 RVA: 0x0010D53F File Offset: 0x0010B73F
		public TArray<ULandscapeGrassType> GrassTypes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ULandscapeGrassType> result;
				if ((result = this._GrassTypes) == null)
				{
					result = (this._GrassTypes = new TArray<ULandscapeGrassType>(base.NativePtr + (IntPtr)FMaterialCachedExpressionData.__PropertyOffset_GrassTypes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.GrassTypes.CopyAssign(value);
			}
		}

		// Token: 0x17002BBE RID: 11198
		// (get) Token: 0x0600BC92 RID: 48274 RVA: 0x0010D550 File Offset: 0x0010B750
		// (set) Token: 0x0600BC93 RID: 48275 RVA: 0x0010D593 File Offset: 0x0010B793
		public TArray<FName> DynamicParameterNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._DynamicParameterNames) == null)
				{
					result = (this._DynamicParameterNames = new TArray<FName>(base.NativePtr + (IntPtr)FMaterialCachedExpressionData.__PropertyOffset_DynamicParameterNames, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DynamicParameterNames.CopyAssign(value);
			}
		}

		// Token: 0x17002BBF RID: 11199
		// (get) Token: 0x0600BC94 RID: 48276 RVA: 0x0010D5A4 File Offset: 0x0010B7A4
		// (set) Token: 0x0600BC95 RID: 48277 RVA: 0x0010D5E7 File Offset: 0x0010B7E7
		public TArray<bool> QualityLevelsUsed
		{
			get
			{
				base.FastCheckIsValid();
				TArray<bool> result;
				if ((result = this._QualityLevelsUsed) == null)
				{
					result = (this._QualityLevelsUsed = new TArray<bool>(base.NativePtr + (IntPtr)FMaterialCachedExpressionData.__PropertyOffset_QualityLevelsUsed, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.QualityLevelsUsed.CopyAssign(value);
			}
		}

		// Token: 0x17002BC0 RID: 11200
		// (get) Token: 0x0600BC96 RID: 48278 RVA: 0x0010D5F8 File Offset: 0x0010B7F8
		// (set) Token: 0x0600BC97 RID: 48279 RVA: 0x0010D63B File Offset: 0x0010B83B
		public TArray<uint> QualityLevelsUsedFeatureLevelMask
		{
			get
			{
				base.FastCheckIsValid();
				TArray<uint> result;
				if ((result = this._QualityLevelsUsedFeatureLevelMask) == null)
				{
					result = (this._QualityLevelsUsedFeatureLevelMask = new TArray<uint>(base.NativePtr + (IntPtr)FMaterialCachedExpressionData.__PropertyOffset_QualityLevelsUsedFeatureLevelMask, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.QualityLevelsUsedFeatureLevelMask.CopyAssign(value);
			}
		}

		// Token: 0x17002BC1 RID: 11201
		// (get) Token: 0x0600BC98 RID: 48280 RVA: 0x0010D649 File Offset: 0x0010B849
		// (set) Token: 0x0600BC99 RID: 48281 RVA: 0x0010D662 File Offset: 0x0010B862
		public unsafe bool bHasRuntimeVirtualTextureOutput
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialCachedExpressionData.__PropertyOffset_bHasRuntimeVirtualTextureOutput) & FMaterialCachedExpressionData.__PropertyMask_bHasRuntimeVirtualTextureOutput) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialCachedExpressionData.__PropertyOffset_bHasRuntimeVirtualTextureOutput) = ((*(base.NativePtr + (IntPtr)FMaterialCachedExpressionData.__PropertyOffset_bHasRuntimeVirtualTextureOutput) & ~FMaterialCachedExpressionData.__PropertyMask_bHasRuntimeVirtualTextureOutput) | (value ? FMaterialCachedExpressionData.__PropertyMask_bHasRuntimeVirtualTextureOutput : 0));
			}
		}

		// Token: 0x17002BC2 RID: 11202
		// (get) Token: 0x0600BC9A RID: 48282 RVA: 0x0010D692 File Offset: 0x0010B892
		// (set) Token: 0x0600BC9B RID: 48283 RVA: 0x0010D6AB File Offset: 0x0010B8AB
		public unsafe bool bHasSceneColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMaterialCachedExpressionData.__PropertyOffset_bHasSceneColor) & FMaterialCachedExpressionData.__PropertyMask_bHasSceneColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMaterialCachedExpressionData.__PropertyOffset_bHasSceneColor) = ((*(base.NativePtr + (IntPtr)FMaterialCachedExpressionData.__PropertyOffset_bHasSceneColor) & ~FMaterialCachedExpressionData.__PropertyMask_bHasSceneColor) | (value ? FMaterialCachedExpressionData.__PropertyMask_bHasSceneColor : 0));
			}
		}

		// Token: 0x0600BC9C RID: 48284 RVA: 0x0010D6DB File Offset: 0x0010B8DB
		public FMaterialCachedExpressionData()
		{
		}

		// Token: 0x0600BC9D RID: 48285 RVA: 0x0010D6E4 File Offset: 0x0010B8E4
		public FMaterialCachedExpressionData(FMaterialCachedParameters Parameters, TArray<UObject> ReferencedTextures, TArray<FMaterialFunctionInfo> FunctionInfos, TArray<FMaterialParameterCollectionInfo> ParameterCollectionInfos, TArray<UMaterialFunctionInterface> DefaultLayers, TArray<UMaterialFunctionInterface> DefaultLayerBlends, TArray<ULandscapeGrassType> GrassTypes, TArray<FName> DynamicParameterNames, TArray<bool> QualityLevelsUsed, TArray<uint> QualityLevelsUsedFeatureLevelMask, bool bHasRuntimeVirtualTextureOutput, bool bHasSceneColor)
		{
			this.Parameters = Parameters;
			this.ReferencedTextures = ReferencedTextures;
			this.FunctionInfos = FunctionInfos;
			this.ParameterCollectionInfos = ParameterCollectionInfos;
			this.DefaultLayers = DefaultLayers;
			this.DefaultLayerBlends = DefaultLayerBlends;
			this.GrassTypes = GrassTypes;
			this.DynamicParameterNames = DynamicParameterNames;
			this.QualityLevelsUsed = QualityLevelsUsed;
			this.QualityLevelsUsedFeatureLevelMask = QualityLevelsUsedFeatureLevelMask;
			this.bHasRuntimeVirtualTextureOutput = bHasRuntimeVirtualTextureOutput;
			this.bHasSceneColor = bHasSceneColor;
		}

		// Token: 0x0600BC9E RID: 48286 RVA: 0x0010D754 File Offset: 0x0010B954
		protected override IntPtr GetUStructPtr()
		{
			return FMaterialCachedExpressionData.StaticStruct();
		}

		// Token: 0x0600BC9F RID: 48287 RVA: 0x0010D760 File Offset: 0x0010B960
		[NullableContext(2)]
		public FMaterialCachedExpressionData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600BCA0 RID: 48288 RVA: 0x0010D76A File Offset: 0x0010B96A
		public FMaterialCachedExpressionData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600BCA1 RID: 48289 RVA: 0x0010D775 File Offset: 0x0010B975
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMaterialCachedExpressionData(Pointer, false, true);
		}

		// Token: 0x0600BCA2 RID: 48290 RVA: 0x0010D77F File Offset: 0x0010B97F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMaterialCachedExpressionData(Pointer, MemoryOwner);
		}

		// Token: 0x04006355 RID: 25429
		public const string __ObjectPath = "/Script/Engine.MaterialCachedExpressionData";

		// Token: 0x04006356 RID: 25430
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006357 RID: 25431
		internal static int __PropertyOffset_Parameters;

		// Token: 0x04006358 RID: 25432
		[Nullable(2)]
		private FMaterialCachedParameters _Parameters;

		// Token: 0x04006359 RID: 25433
		internal static int __PropertyOffset_ReferencedTextures;

		// Token: 0x0400635A RID: 25434
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _ReferencedTextures;

		// Token: 0x0400635B RID: 25435
		internal static int __PropertyOffset_FunctionInfos;

		// Token: 0x0400635C RID: 25436
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMaterialFunctionInfo> _FunctionInfos;

		// Token: 0x0400635D RID: 25437
		internal static int __PropertyOffset_ParameterCollectionInfos;

		// Token: 0x0400635E RID: 25438
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMaterialParameterCollectionInfo> _ParameterCollectionInfos;

		// Token: 0x0400635F RID: 25439
		internal static int __PropertyOffset_DefaultLayers;

		// Token: 0x04006360 RID: 25440
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialFunctionInterface> _DefaultLayers;

		// Token: 0x04006361 RID: 25441
		internal static int __PropertyOffset_DefaultLayerBlends;

		// Token: 0x04006362 RID: 25442
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialFunctionInterface> _DefaultLayerBlends;

		// Token: 0x04006363 RID: 25443
		internal static int __PropertyOffset_GrassTypes;

		// Token: 0x04006364 RID: 25444
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULandscapeGrassType> _GrassTypes;

		// Token: 0x04006365 RID: 25445
		internal static int __PropertyOffset_DynamicParameterNames;

		// Token: 0x04006366 RID: 25446
		[Nullable(2)]
		private TArray<FName> _DynamicParameterNames;

		// Token: 0x04006367 RID: 25447
		internal static int __PropertyOffset_QualityLevelsUsed;

		// Token: 0x04006368 RID: 25448
		[Nullable(2)]
		private TArray<bool> _QualityLevelsUsed;

		// Token: 0x04006369 RID: 25449
		internal static int __PropertyOffset_QualityLevelsUsedFeatureLevelMask;

		// Token: 0x0400636A RID: 25450
		[Nullable(2)]
		private TArray<uint> _QualityLevelsUsedFeatureLevelMask;

		// Token: 0x0400636B RID: 25451
		internal static int __PropertyOffset_bHasRuntimeVirtualTextureOutput;

		// Token: 0x0400636C RID: 25452
		internal static byte __PropertyMask_bHasRuntimeVirtualTextureOutput;

		// Token: 0x0400636D RID: 25453
		internal static int __PropertyOffset_bHasSceneColor;

		// Token: 0x0400636E RID: 25454
		internal static byte __PropertyMask_bHasSceneColor;
	}
}
