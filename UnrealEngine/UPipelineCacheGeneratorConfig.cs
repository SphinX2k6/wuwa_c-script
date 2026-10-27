using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FED RID: 4077
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PipelineCacheGeneratorConfig")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1104)]
	public class UPipelineCacheGeneratorConfig : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600DCCC RID: 56524 RVA: 0x0014513B File Offset: 0x0014333B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPipelineCacheGeneratorConfig._ClassPtr;
		}

		// Token: 0x0600DCCD RID: 56525 RVA: 0x00145148 File Offset: 0x00143348
		public UPipelineCacheGeneratorConfig() : this(BuiltinUtils.AllocNativeUObject(UPipelineCacheGeneratorConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600DCCE RID: 56526 RVA: 0x00145170 File Offset: 0x00143370
		public UPipelineCacheGeneratorConfig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPipelineCacheGeneratorConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700340D RID: 13325
		// (get) Token: 0x0600DCCF RID: 56527 RVA: 0x001451A4 File Offset: 0x001433A4
		// (set) Token: 0x0600DCD0 RID: 56528 RVA: 0x001451DD File Offset: 0x001433DD
		public TMap<string, FPSOGeneratorConfigShader> Shaders
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FPSOGeneratorConfigShader> result;
				if ((result = this._Shaders) == null)
				{
					result = (this._Shaders = new TMap<string, FPSOGeneratorConfigShader>(base.NativePtr + (IntPtr)UPipelineCacheGeneratorConfig.__PropertyOffset_Shaders, this));
				}
				return result;
			}
			set
			{
				this.Shaders.CopyAssign(value);
			}
		}

		// Token: 0x1700340E RID: 13326
		// (get) Token: 0x0600DCD1 RID: 56529 RVA: 0x001451EC File Offset: 0x001433EC
		// (set) Token: 0x0600DCD2 RID: 56530 RVA: 0x00145225 File Offset: 0x00143425
		public TMap<string, FPSOGeneratorConfigVertexInput> VertexInputs
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FPSOGeneratorConfigVertexInput> result;
				if ((result = this._VertexInputs) == null)
				{
					result = (this._VertexInputs = new TMap<string, FPSOGeneratorConfigVertexInput>(base.NativePtr + (IntPtr)UPipelineCacheGeneratorConfig.__PropertyOffset_VertexInputs, this));
				}
				return result;
			}
			set
			{
				this.VertexInputs.CopyAssign(value);
			}
		}

		// Token: 0x1700340F RID: 13327
		// (get) Token: 0x0600DCD3 RID: 56531 RVA: 0x00145234 File Offset: 0x00143434
		// (set) Token: 0x0600DCD4 RID: 56532 RVA: 0x0014526D File Offset: 0x0014346D
		public TMap<string, FPSOGeneratorConfigBlendState> BlendStates
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FPSOGeneratorConfigBlendState> result;
				if ((result = this._BlendStates) == null)
				{
					result = (this._BlendStates = new TMap<string, FPSOGeneratorConfigBlendState>(base.NativePtr + (IntPtr)UPipelineCacheGeneratorConfig.__PropertyOffset_BlendStates, this));
				}
				return result;
			}
			set
			{
				this.BlendStates.CopyAssign(value);
			}
		}

		// Token: 0x17003410 RID: 13328
		// (get) Token: 0x0600DCD5 RID: 56533 RVA: 0x0014527C File Offset: 0x0014347C
		// (set) Token: 0x0600DCD6 RID: 56534 RVA: 0x001452B5 File Offset: 0x001434B5
		public TMap<string, FPSOGeneratorConfigRasterizerState> RasterizerStates
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FPSOGeneratorConfigRasterizerState> result;
				if ((result = this._RasterizerStates) == null)
				{
					result = (this._RasterizerStates = new TMap<string, FPSOGeneratorConfigRasterizerState>(base.NativePtr + (IntPtr)UPipelineCacheGeneratorConfig.__PropertyOffset_RasterizerStates, this));
				}
				return result;
			}
			set
			{
				this.RasterizerStates.CopyAssign(value);
			}
		}

		// Token: 0x17003411 RID: 13329
		// (get) Token: 0x0600DCD7 RID: 56535 RVA: 0x001452C4 File Offset: 0x001434C4
		// (set) Token: 0x0600DCD8 RID: 56536 RVA: 0x001452FD File Offset: 0x001434FD
		public TMap<string, FPSOGeneratorConfigDepthStencilState> DepthStencilStates
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FPSOGeneratorConfigDepthStencilState> result;
				if ((result = this._DepthStencilStates) == null)
				{
					result = (this._DepthStencilStates = new TMap<string, FPSOGeneratorConfigDepthStencilState>(base.NativePtr + (IntPtr)UPipelineCacheGeneratorConfig.__PropertyOffset_DepthStencilStates, this));
				}
				return result;
			}
			set
			{
				this.DepthStencilStates.CopyAssign(value);
			}
		}

		// Token: 0x17003412 RID: 13330
		// (get) Token: 0x0600DCD9 RID: 56537 RVA: 0x0014530C File Offset: 0x0014350C
		// (set) Token: 0x0600DCDA RID: 56538 RVA: 0x00145345 File Offset: 0x00143545
		public TMap<string, FPSOGeneratorConfigRenderTarget> RenderTargets
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FPSOGeneratorConfigRenderTarget> result;
				if ((result = this._RenderTargets) == null)
				{
					result = (this._RenderTargets = new TMap<string, FPSOGeneratorConfigRenderTarget>(base.NativePtr + (IntPtr)UPipelineCacheGeneratorConfig.__PropertyOffset_RenderTargets, this));
				}
				return result;
			}
			set
			{
				this.RenderTargets.CopyAssign(value);
			}
		}

		// Token: 0x17003413 RID: 13331
		// (get) Token: 0x0600DCDB RID: 56539 RVA: 0x00145354 File Offset: 0x00143554
		// (set) Token: 0x0600DCDC RID: 56540 RVA: 0x0014538D File Offset: 0x0014358D
		public TMap<string, FPSOGeneratorConfigPipeline> Pipelines
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FPSOGeneratorConfigPipeline> result;
				if ((result = this._Pipelines) == null)
				{
					result = (this._Pipelines = new TMap<string, FPSOGeneratorConfigPipeline>(base.NativePtr + (IntPtr)UPipelineCacheGeneratorConfig.__PropertyOffset_Pipelines, this));
				}
				return result;
			}
			set
			{
				this.Pipelines.CopyAssign(value);
			}
		}

		// Token: 0x17003414 RID: 13332
		// (get) Token: 0x0600DCDD RID: 56541 RVA: 0x0014539C File Offset: 0x0014359C
		// (set) Token: 0x0600DCDE RID: 56542 RVA: 0x001453D5 File Offset: 0x001435D5
		public TMap<string, FPSOGeneratorConfigCollector> Collectors
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FPSOGeneratorConfigCollector> result;
				if ((result = this._Collectors) == null)
				{
					result = (this._Collectors = new TMap<string, FPSOGeneratorConfigCollector>(base.NativePtr + (IntPtr)UPipelineCacheGeneratorConfig.__PropertyOffset_Collectors, this));
				}
				return result;
			}
			set
			{
				this.Collectors.CopyAssign(value);
			}
		}

		// Token: 0x17003415 RID: 13333
		// (get) Token: 0x0600DCDF RID: 56543 RVA: 0x001453E4 File Offset: 0x001435E4
		// (set) Token: 0x0600DCE0 RID: 56544 RVA: 0x0014541D File Offset: 0x0014361D
		public FPSOGeneratorConfigUsageMask UsageMasks
		{
			get
			{
				base.FastCheckIsValid();
				FPSOGeneratorConfigUsageMask result;
				if ((result = this._UsageMasks) == null)
				{
					result = (this._UsageMasks = new FPSOGeneratorConfigUsageMask(base.NativePtr + (IntPtr)UPipelineCacheGeneratorConfig.__PropertyOffset_UsageMasks, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPSOGeneratorConfigUsageMask.StaticStruct(), base.NativePtr + (IntPtr)UPipelineCacheGeneratorConfig.__PropertyOffset_UsageMasks, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003416 RID: 13334
		// (get) Token: 0x0600DCE1 RID: 56545 RVA: 0x00145440 File Offset: 0x00143640
		// (set) Token: 0x0600DCE2 RID: 56546 RVA: 0x00145479 File Offset: 0x00143679
		public TMap<string, string> AdditionalBaseMaterialMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, string> result;
				if ((result = this._AdditionalBaseMaterialMap) == null)
				{
					result = (this._AdditionalBaseMaterialMap = new TMap<string, string>(base.NativePtr + (IntPtr)UPipelineCacheGeneratorConfig.__PropertyOffset_AdditionalBaseMaterialMap, this));
				}
				return result;
			}
			set
			{
				this.AdditionalBaseMaterialMap.CopyAssign(value);
			}
		}

		// Token: 0x0600DCE3 RID: 56547 RVA: 0x00145487 File Offset: 0x00143687
		static UPipelineCacheGeneratorConfig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PipelineCacheGeneratorConfig");
		}

		// Token: 0x0600DCE4 RID: 56548 RVA: 0x00145495 File Offset: 0x00143695
		protected UPipelineCacheGeneratorConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400774F RID: 30543
		public new const string __ObjectPath = "/Script/Engine.PipelineCacheGeneratorConfig";

		// Token: 0x04007750 RID: 30544
		private static IntPtr _ClassPtr;

		// Token: 0x04007751 RID: 30545
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007752 RID: 30546
		internal static int __PropertyOffset_Shaders;

		// Token: 0x04007753 RID: 30547
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, FPSOGeneratorConfigShader> _Shaders;

		// Token: 0x04007754 RID: 30548
		internal static int __PropertyOffset_VertexInputs;

		// Token: 0x04007755 RID: 30549
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, FPSOGeneratorConfigVertexInput> _VertexInputs;

		// Token: 0x04007756 RID: 30550
		internal static int __PropertyOffset_BlendStates;

		// Token: 0x04007757 RID: 30551
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, FPSOGeneratorConfigBlendState> _BlendStates;

		// Token: 0x04007758 RID: 30552
		internal static int __PropertyOffset_RasterizerStates;

		// Token: 0x04007759 RID: 30553
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, FPSOGeneratorConfigRasterizerState> _RasterizerStates;

		// Token: 0x0400775A RID: 30554
		internal static int __PropertyOffset_DepthStencilStates;

		// Token: 0x0400775B RID: 30555
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, FPSOGeneratorConfigDepthStencilState> _DepthStencilStates;

		// Token: 0x0400775C RID: 30556
		internal static int __PropertyOffset_RenderTargets;

		// Token: 0x0400775D RID: 30557
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, FPSOGeneratorConfigRenderTarget> _RenderTargets;

		// Token: 0x0400775E RID: 30558
		internal static int __PropertyOffset_Pipelines;

		// Token: 0x0400775F RID: 30559
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, FPSOGeneratorConfigPipeline> _Pipelines;

		// Token: 0x04007760 RID: 30560
		internal static int __PropertyOffset_Collectors;

		// Token: 0x04007761 RID: 30561
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, FPSOGeneratorConfigCollector> _Collectors;

		// Token: 0x04007762 RID: 30562
		internal static int __PropertyOffset_UsageMasks;

		// Token: 0x04007763 RID: 30563
		[Nullable(2)]
		private FPSOGeneratorConfigUsageMask _UsageMasks;

		// Token: 0x04007764 RID: 30564
		internal static int __PropertyOffset_AdditionalBaseMaterialMap;

		// Token: 0x04007765 RID: 30565
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, string> _AdditionalBaseMaterialMap;
	}
}
