using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200104F RID: 4175
	[UnrealObjectPath("/Script/Engine.PSOGeneratorConfigRenderTarget")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FPSOGeneratorConfigRenderTarget : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600ED83 RID: 60803 RVA: 0x00160804 File Offset: 0x0015EA04
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPSOGeneratorConfigRenderTarget._ScriptStructPtr != 0) ? FPSOGeneratorConfigRenderTarget._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PSOGeneratorConfigRenderTarget", ref FPSOGeneratorConfigRenderTarget._ScriptStructPtr);
		}

		// Token: 0x1700397F RID: 14719
		// (get) Token: 0x0600ED84 RID: 60804 RVA: 0x00160828 File Offset: 0x0015EA28
		// (set) Token: 0x0600ED85 RID: 60805 RVA: 0x0016086B File Offset: 0x0015EA6B
		[Nullable(1)]
		public TArray<FPSOGeneratorConfigSingleRenderTarget> ColorTargets
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FPSOGeneratorConfigSingleRenderTarget> result;
				if ((result = this._ColorTargets) == null)
				{
					result = (this._ColorTargets = new TArray<FPSOGeneratorConfigSingleRenderTarget>(base.NativePtr + (IntPtr)FPSOGeneratorConfigRenderTarget.__PropertyOffset_ColorTargets, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ColorTargets.CopyAssign(value);
			}
		}

		// Token: 0x17003980 RID: 14720
		// (get) Token: 0x0600ED86 RID: 60806 RVA: 0x00160879 File Offset: 0x0015EA79
		// (set) Token: 0x0600ED87 RID: 60807 RVA: 0x0016088D File Offset: 0x0015EA8D
		public unsafe FPSOGeneratorConfigSingleRenderTarget DepthStencilTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPSOGeneratorConfigRenderTarget.__PropertyOffset_DepthStencilTarget);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPSOGeneratorConfigRenderTarget.__PropertyOffset_DepthStencilTarget) = value;
			}
		}

		// Token: 0x17003981 RID: 14721
		// (get) Token: 0x0600ED88 RID: 60808 RVA: 0x001608A2 File Offset: 0x0015EAA2
		// (set) Token: 0x0600ED89 RID: 60809 RVA: 0x001608B6 File Offset: 0x0015EAB6
		public unsafe TEnumAsByte<EPSOGeneratorRenderTargetLoadAction> DepthLoad
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPSOGeneratorConfigRenderTarget.__PropertyOffset_DepthLoad);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPSOGeneratorConfigRenderTarget.__PropertyOffset_DepthLoad) = value;
			}
		}

		// Token: 0x17003982 RID: 14722
		// (get) Token: 0x0600ED8A RID: 60810 RVA: 0x001608CB File Offset: 0x0015EACB
		// (set) Token: 0x0600ED8B RID: 60811 RVA: 0x001608DF File Offset: 0x0015EADF
		public unsafe TEnumAsByte<EPSOGeneratorRenderTargetLoadAction> StencilLoad
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPSOGeneratorConfigRenderTarget.__PropertyOffset_StencilLoad);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPSOGeneratorConfigRenderTarget.__PropertyOffset_StencilLoad) = value;
			}
		}

		// Token: 0x17003983 RID: 14723
		// (get) Token: 0x0600ED8C RID: 60812 RVA: 0x001608F4 File Offset: 0x0015EAF4
		// (set) Token: 0x0600ED8D RID: 60813 RVA: 0x00160908 File Offset: 0x0015EB08
		public unsafe TEnumAsByte<EPSOGeneratorRenderTargetStoreAction> DepthStore
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPSOGeneratorConfigRenderTarget.__PropertyOffset_DepthStore);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPSOGeneratorConfigRenderTarget.__PropertyOffset_DepthStore) = value;
			}
		}

		// Token: 0x17003984 RID: 14724
		// (get) Token: 0x0600ED8E RID: 60814 RVA: 0x0016091D File Offset: 0x0015EB1D
		// (set) Token: 0x0600ED8F RID: 60815 RVA: 0x00160931 File Offset: 0x0015EB31
		public unsafe TEnumAsByte<EPSOGeneratorRenderTargetStoreAction> StencilStore
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPSOGeneratorConfigRenderTarget.__PropertyOffset_StencilStore);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPSOGeneratorConfigRenderTarget.__PropertyOffset_StencilStore) = value;
			}
		}

		// Token: 0x17003985 RID: 14725
		// (get) Token: 0x0600ED90 RID: 60816 RVA: 0x00160946 File Offset: 0x0015EB46
		// (set) Token: 0x0600ED91 RID: 60817 RVA: 0x00160956 File Offset: 0x0015EB56
		public unsafe int MSAASamples
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPSOGeneratorConfigRenderTarget.__PropertyOffset_MSAASamples);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPSOGeneratorConfigRenderTarget.__PropertyOffset_MSAASamples) = value;
			}
		}

		// Token: 0x0600ED92 RID: 60818 RVA: 0x00160967 File Offset: 0x0015EB67
		public FPSOGeneratorConfigRenderTarget()
		{
		}

		// Token: 0x0600ED93 RID: 60819 RVA: 0x0016096F File Offset: 0x0015EB6F
		public FPSOGeneratorConfigRenderTarget([Nullable(1)] TArray<FPSOGeneratorConfigSingleRenderTarget> ColorTargets, FPSOGeneratorConfigSingleRenderTarget DepthStencilTarget, TEnumAsByte<EPSOGeneratorRenderTargetLoadAction> DepthLoad, TEnumAsByte<EPSOGeneratorRenderTargetLoadAction> StencilLoad, TEnumAsByte<EPSOGeneratorRenderTargetStoreAction> DepthStore, TEnumAsByte<EPSOGeneratorRenderTargetStoreAction> StencilStore, int MSAASamples)
		{
			this.ColorTargets = ColorTargets;
			this.DepthStencilTarget = DepthStencilTarget;
			this.DepthLoad = DepthLoad;
			this.StencilLoad = StencilLoad;
			this.DepthStore = DepthStore;
			this.StencilStore = StencilStore;
			this.MSAASamples = MSAASamples;
		}

		// Token: 0x0600ED94 RID: 60820 RVA: 0x001609AC File Offset: 0x0015EBAC
		protected override IntPtr GetUStructPtr()
		{
			return FPSOGeneratorConfigRenderTarget.StaticStruct();
		}

		// Token: 0x0600ED95 RID: 60821 RVA: 0x001609B8 File Offset: 0x0015EBB8
		[NullableContext(2)]
		public FPSOGeneratorConfigRenderTarget(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600ED96 RID: 60822 RVA: 0x001609C2 File Offset: 0x0015EBC2
		public FPSOGeneratorConfigRenderTarget(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600ED97 RID: 60823 RVA: 0x001609CD File Offset: 0x0015EBCD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPSOGeneratorConfigRenderTarget(Pointer, false, true);
		}

		// Token: 0x0600ED98 RID: 60824 RVA: 0x001609D7 File Offset: 0x0015EBD7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPSOGeneratorConfigRenderTarget(Pointer, MemoryOwner);
		}

		// Token: 0x040080A7 RID: 32935
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.PSOGeneratorConfigRenderTarget";

		// Token: 0x040080A8 RID: 32936
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040080A9 RID: 32937
		internal static int __PropertyOffset_ColorTargets;

		// Token: 0x040080AA RID: 32938
		[Nullable(2)]
		private TArray<FPSOGeneratorConfigSingleRenderTarget> _ColorTargets;

		// Token: 0x040080AB RID: 32939
		internal static int __PropertyOffset_DepthStencilTarget;

		// Token: 0x040080AC RID: 32940
		internal static int __PropertyOffset_DepthLoad;

		// Token: 0x040080AD RID: 32941
		internal static int __PropertyOffset_StencilLoad;

		// Token: 0x040080AE RID: 32942
		internal static int __PropertyOffset_DepthStore;

		// Token: 0x040080AF RID: 32943
		internal static int __PropertyOffset_StencilStore;

		// Token: 0x040080B0 RID: 32944
		internal static int __PropertyOffset_MSAASamples;
	}
}
