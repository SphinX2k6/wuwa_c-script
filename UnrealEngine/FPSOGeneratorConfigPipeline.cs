using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200104D RID: 4173
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PSOGeneratorConfigPipeline")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 208)]
	public class FPSOGeneratorConfigPipeline : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600ED5C RID: 60764 RVA: 0x00160306 File Offset: 0x0015E506
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPSOGeneratorConfigPipeline._ScriptStructPtr != 0) ? FPSOGeneratorConfigPipeline._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PSOGeneratorConfigPipeline", ref FPSOGeneratorConfigPipeline._ScriptStructPtr);
		}

		// Token: 0x17003973 RID: 14707
		// (get) Token: 0x0600ED5D RID: 60765 RVA: 0x0016032C File Offset: 0x0015E52C
		// (set) Token: 0x0600ED5E RID: 60766 RVA: 0x0016036F File Offset: 0x0015E56F
		public TMap<string, FPSOGeneratorConfigVariable> Variables
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FPSOGeneratorConfigVariable> result;
				if ((result = this._Variables) == null)
				{
					result = (this._Variables = new TMap<string, FPSOGeneratorConfigVariable>(base.NativePtr + (IntPtr)FPSOGeneratorConfigPipeline.__PropertyOffset_Variables, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Variables.CopyAssign(value);
			}
		}

		// Token: 0x17003974 RID: 14708
		// (get) Token: 0x0600ED5F RID: 60767 RVA: 0x00160380 File Offset: 0x0015E580
		// (set) Token: 0x0600ED60 RID: 60768 RVA: 0x001603C3 File Offset: 0x0015E5C3
		public TArray<string> Shaders
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Shaders) == null)
				{
					result = (this._Shaders = new TArray<string>(base.NativePtr + (IntPtr)FPSOGeneratorConfigPipeline.__PropertyOffset_Shaders, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Shaders.CopyAssign(value);
			}
		}

		// Token: 0x17003975 RID: 14709
		// (get) Token: 0x0600ED61 RID: 60769 RVA: 0x001603D4 File Offset: 0x0015E5D4
		// (set) Token: 0x0600ED62 RID: 60770 RVA: 0x00160417 File Offset: 0x0015E617
		public TArray<string> VertexInputs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._VertexInputs) == null)
				{
					result = (this._VertexInputs = new TArray<string>(base.NativePtr + (IntPtr)FPSOGeneratorConfigPipeline.__PropertyOffset_VertexInputs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.VertexInputs.CopyAssign(value);
			}
		}

		// Token: 0x17003976 RID: 14710
		// (get) Token: 0x0600ED63 RID: 60771 RVA: 0x00160428 File Offset: 0x0015E628
		// (set) Token: 0x0600ED64 RID: 60772 RVA: 0x0016046B File Offset: 0x0015E66B
		public TArray<string> BlendStates
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._BlendStates) == null)
				{
					result = (this._BlendStates = new TArray<string>(base.NativePtr + (IntPtr)FPSOGeneratorConfigPipeline.__PropertyOffset_BlendStates, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BlendStates.CopyAssign(value);
			}
		}

		// Token: 0x17003977 RID: 14711
		// (get) Token: 0x0600ED65 RID: 60773 RVA: 0x0016047C File Offset: 0x0015E67C
		// (set) Token: 0x0600ED66 RID: 60774 RVA: 0x001604BF File Offset: 0x0015E6BF
		public TArray<string> RasterizerStates
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._RasterizerStates) == null)
				{
					result = (this._RasterizerStates = new TArray<string>(base.NativePtr + (IntPtr)FPSOGeneratorConfigPipeline.__PropertyOffset_RasterizerStates, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RasterizerStates.CopyAssign(value);
			}
		}

		// Token: 0x17003978 RID: 14712
		// (get) Token: 0x0600ED67 RID: 60775 RVA: 0x001604D0 File Offset: 0x0015E6D0
		// (set) Token: 0x0600ED68 RID: 60776 RVA: 0x00160513 File Offset: 0x0015E713
		public TArray<string> DepthStencilStates
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._DepthStencilStates) == null)
				{
					result = (this._DepthStencilStates = new TArray<string>(base.NativePtr + (IntPtr)FPSOGeneratorConfigPipeline.__PropertyOffset_DepthStencilStates, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DepthStencilStates.CopyAssign(value);
			}
		}

		// Token: 0x17003979 RID: 14713
		// (get) Token: 0x0600ED69 RID: 60777 RVA: 0x00160524 File Offset: 0x0015E724
		// (set) Token: 0x0600ED6A RID: 60778 RVA: 0x00160567 File Offset: 0x0015E767
		public TArray<string> RenderTargets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._RenderTargets) == null)
				{
					result = (this._RenderTargets = new TArray<string>(base.NativePtr + (IntPtr)FPSOGeneratorConfigPipeline.__PropertyOffset_RenderTargets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RenderTargets.CopyAssign(value);
			}
		}

		// Token: 0x1700397A RID: 14714
		// (get) Token: 0x0600ED6B RID: 60779 RVA: 0x00160575 File Offset: 0x0015E775
		// (set) Token: 0x0600ED6C RID: 60780 RVA: 0x00160585 File Offset: 0x0015E785
		public unsafe byte SubpassHint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPSOGeneratorConfigPipeline.__PropertyOffset_SubpassHint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPSOGeneratorConfigPipeline.__PropertyOffset_SubpassHint) = value;
			}
		}

		// Token: 0x1700397B RID: 14715
		// (get) Token: 0x0600ED6D RID: 60781 RVA: 0x00160596 File Offset: 0x0015E796
		// (set) Token: 0x0600ED6E RID: 60782 RVA: 0x001605A6 File Offset: 0x0015E7A6
		public unsafe byte SubpassIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPSOGeneratorConfigPipeline.__PropertyOffset_SubpassIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPSOGeneratorConfigPipeline.__PropertyOffset_SubpassIndex) = value;
			}
		}

		// Token: 0x1700397C RID: 14716
		// (get) Token: 0x0600ED6F RID: 60783 RVA: 0x001605B7 File Offset: 0x0015E7B7
		// (set) Token: 0x0600ED70 RID: 60784 RVA: 0x001605CB File Offset: 0x0015E7CB
		public unsafe string SubpassLayout
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPSOGeneratorConfigPipeline.__PropertyOffset_SubpassLayout)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPSOGeneratorConfigPipeline.__PropertyOffset_SubpassLayout)), value);
			}
		}

		// Token: 0x1700397D RID: 14717
		// (get) Token: 0x0600ED71 RID: 60785 RVA: 0x001605E0 File Offset: 0x0015E7E0
		// (set) Token: 0x0600ED72 RID: 60786 RVA: 0x001605F0 File Offset: 0x0015E7F0
		public unsafe byte SubpassConfigurationKey
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPSOGeneratorConfigPipeline.__PropertyOffset_SubpassConfigurationKey);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPSOGeneratorConfigPipeline.__PropertyOffset_SubpassConfigurationKey) = value;
			}
		}

		// Token: 0x1700397E RID: 14718
		// (get) Token: 0x0600ED73 RID: 60787 RVA: 0x00160601 File Offset: 0x0015E801
		// (set) Token: 0x0600ED74 RID: 60788 RVA: 0x00160615 File Offset: 0x0015E815
		[Nullable(0)]
		public unsafe TEnumAsByte<EPSOGeneratorPrimitiveType> PrimitiveType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FPSOGeneratorConfigPipeline.__PropertyOffset_PrimitiveType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FPSOGeneratorConfigPipeline.__PropertyOffset_PrimitiveType) = value;
			}
		}

		// Token: 0x0600ED75 RID: 60789 RVA: 0x0016062A File Offset: 0x0015E82A
		public FPSOGeneratorConfigPipeline()
		{
		}

		// Token: 0x0600ED76 RID: 60790 RVA: 0x00160634 File Offset: 0x0015E834
		public FPSOGeneratorConfigPipeline(TMap<string, FPSOGeneratorConfigVariable> Variables, TArray<string> Shaders, TArray<string> VertexInputs, TArray<string> BlendStates, TArray<string> RasterizerStates, TArray<string> DepthStencilStates, TArray<string> RenderTargets, byte SubpassHint, byte SubpassIndex, string SubpassLayout, byte SubpassConfigurationKey, [Nullable(0)] TEnumAsByte<EPSOGeneratorPrimitiveType> PrimitiveType)
		{
			this.Variables = Variables;
			this.Shaders = Shaders;
			this.VertexInputs = VertexInputs;
			this.BlendStates = BlendStates;
			this.RasterizerStates = RasterizerStates;
			this.DepthStencilStates = DepthStencilStates;
			this.RenderTargets = RenderTargets;
			this.SubpassHint = SubpassHint;
			this.SubpassIndex = SubpassIndex;
			this.SubpassLayout = SubpassLayout;
			this.SubpassConfigurationKey = SubpassConfigurationKey;
			this.PrimitiveType = PrimitiveType;
		}

		// Token: 0x0600ED77 RID: 60791 RVA: 0x001606A4 File Offset: 0x0015E8A4
		protected override IntPtr GetUStructPtr()
		{
			return FPSOGeneratorConfigPipeline.StaticStruct();
		}

		// Token: 0x0600ED78 RID: 60792 RVA: 0x001606B0 File Offset: 0x0015E8B0
		[NullableContext(2)]
		public FPSOGeneratorConfigPipeline(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600ED79 RID: 60793 RVA: 0x001606BA File Offset: 0x0015E8BA
		public FPSOGeneratorConfigPipeline(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600ED7A RID: 60794 RVA: 0x001606C5 File Offset: 0x0015E8C5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPSOGeneratorConfigPipeline(Pointer, false, true);
		}

		// Token: 0x0600ED7B RID: 60795 RVA: 0x001606CF File Offset: 0x0015E8CF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPSOGeneratorConfigPipeline(Pointer, MemoryOwner);
		}

		// Token: 0x0400808A RID: 32906
		public const string __ObjectPath = "/Script/Engine.PSOGeneratorConfigPipeline";

		// Token: 0x0400808B RID: 32907
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400808C RID: 32908
		internal static int __PropertyOffset_Variables;

		// Token: 0x0400808D RID: 32909
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, FPSOGeneratorConfigVariable> _Variables;

		// Token: 0x0400808E RID: 32910
		internal static int __PropertyOffset_Shaders;

		// Token: 0x0400808F RID: 32911
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Shaders;

		// Token: 0x04008090 RID: 32912
		internal static int __PropertyOffset_VertexInputs;

		// Token: 0x04008091 RID: 32913
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _VertexInputs;

		// Token: 0x04008092 RID: 32914
		internal static int __PropertyOffset_BlendStates;

		// Token: 0x04008093 RID: 32915
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _BlendStates;

		// Token: 0x04008094 RID: 32916
		internal static int __PropertyOffset_RasterizerStates;

		// Token: 0x04008095 RID: 32917
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _RasterizerStates;

		// Token: 0x04008096 RID: 32918
		internal static int __PropertyOffset_DepthStencilStates;

		// Token: 0x04008097 RID: 32919
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _DepthStencilStates;

		// Token: 0x04008098 RID: 32920
		internal static int __PropertyOffset_RenderTargets;

		// Token: 0x04008099 RID: 32921
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _RenderTargets;

		// Token: 0x0400809A RID: 32922
		internal static int __PropertyOffset_SubpassHint;

		// Token: 0x0400809B RID: 32923
		internal static int __PropertyOffset_SubpassIndex;

		// Token: 0x0400809C RID: 32924
		internal static int __PropertyOffset_SubpassLayout;

		// Token: 0x0400809D RID: 32925
		internal static int __PropertyOffset_SubpassConfigurationKey;

		// Token: 0x0400809E RID: 32926
		internal static int __PropertyOffset_PrimitiveType;
	}
}
