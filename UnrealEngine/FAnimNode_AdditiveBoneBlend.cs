using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001603 RID: 5635
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.AnimNode_AdditiveBoneBlend")]
	[UnrealStructLayout(464, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 464)]
	public class FAnimNode_AdditiveBoneBlend : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060144E4 RID: 83172 RVA: 0x001DD38E File Offset: 0x001DB58E
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_AdditiveBoneBlend._ScriptStructPtr != 0) ? FAnimNode_AdditiveBoneBlend._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.AnimNode_AdditiveBoneBlend", ref FAnimNode_AdditiveBoneBlend._ScriptStructPtr);
		}

		// Token: 0x17004FA8 RID: 20392
		// (get) Token: 0x060144E5 RID: 83173 RVA: 0x001DD3B4 File Offset: 0x001DB5B4
		// (set) Token: 0x060144E6 RID: 83174 RVA: 0x001DD3F7 File Offset: 0x001DB5F7
		public FPoseLink BaseLayer
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._BaseLayer) == null)
				{
					result = (this._BaseLayer = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_AdditiveBoneBlend.__PropertyOffset_BaseLayer, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_AdditiveBoneBlend.__PropertyOffset_BaseLayer, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004FA9 RID: 20393
		// (get) Token: 0x060144E7 RID: 83175 RVA: 0x001DD418 File Offset: 0x001DB618
		// (set) Token: 0x060144E8 RID: 83176 RVA: 0x001DD45B File Offset: 0x001DB65B
		public FPoseLink OverlayLayer
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._OverlayLayer) == null)
				{
					result = (this._OverlayLayer = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_AdditiveBoneBlend.__PropertyOffset_OverlayLayer, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_AdditiveBoneBlend.__PropertyOffset_OverlayLayer, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004FAA RID: 20394
		// (get) Token: 0x060144E9 RID: 83177 RVA: 0x001DD47C File Offset: 0x001DB67C
		// (set) Token: 0x060144EA RID: 83178 RVA: 0x001DD4BF File Offset: 0x001DB6BF
		public FPoseLink AdditiveBasePose
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._AdditiveBasePose) == null)
				{
					result = (this._AdditiveBasePose = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_AdditiveBoneBlend.__PropertyOffset_AdditiveBasePose, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_AdditiveBoneBlend.__PropertyOffset_AdditiveBasePose, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004FAB RID: 20395
		// (get) Token: 0x060144EB RID: 83179 RVA: 0x001DD4E0 File Offset: 0x001DB6E0
		// (set) Token: 0x060144EC RID: 83180 RVA: 0x001DD523 File Offset: 0x001DB723
		public TArray<FAdditiveBlendAlpha> AdditiveBlendAlpha
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAdditiveBlendAlpha> result;
				if ((result = this._AdditiveBlendAlpha) == null)
				{
					result = (this._AdditiveBlendAlpha = new TArray<FAdditiveBlendAlpha>(base.NativePtr + (IntPtr)FAnimNode_AdditiveBoneBlend.__PropertyOffset_AdditiveBlendAlpha, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AdditiveBlendAlpha.CopyAssign(value);
			}
		}

		// Token: 0x17004FAC RID: 20396
		// (get) Token: 0x060144ED RID: 83181 RVA: 0x001DD531 File Offset: 0x001DB731
		// (set) Token: 0x060144EE RID: 83182 RVA: 0x001DD541 File Offset: 0x001DB741
		public unsafe bool bMeshSpaceAdd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_AdditiveBoneBlend.__PropertyOffset_bMeshSpaceAdd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_AdditiveBoneBlend.__PropertyOffset_bMeshSpaceAdd) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004FAD RID: 20397
		// (get) Token: 0x060144EF RID: 83183 RVA: 0x001DD554 File Offset: 0x001DB754
		// (set) Token: 0x060144F0 RID: 83184 RVA: 0x001DD597 File Offset: 0x001DB797
		public TArray<FMaskLayer> LayerSetup
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMaskLayer> result;
				if ((result = this._LayerSetup) == null)
				{
					result = (this._LayerSetup = new TArray<FMaskLayer>(base.NativePtr + (IntPtr)FAnimNode_AdditiveBoneBlend.__PropertyOffset_LayerSetup, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LayerSetup.CopyAssign(value);
			}
		}

		// Token: 0x17004FAE RID: 20398
		// (get) Token: 0x060144F1 RID: 83185 RVA: 0x001DD5A5 File Offset: 0x001DB7A5
		// (set) Token: 0x060144F2 RID: 83186 RVA: 0x001DD5B5 File Offset: 0x001DB7B5
		public unsafe float Alpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_AdditiveBoneBlend.__PropertyOffset_Alpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_AdditiveBoneBlend.__PropertyOffset_Alpha) = value;
			}
		}

		// Token: 0x17004FAF RID: 20399
		// (get) Token: 0x060144F3 RID: 83187 RVA: 0x001DD5C6 File Offset: 0x001DB7C6
		// (set) Token: 0x060144F4 RID: 83188 RVA: 0x001DD5D6 File Offset: 0x001DB7D6
		public unsafe float ChestBlendDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_AdditiveBoneBlend.__PropertyOffset_ChestBlendDepth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_AdditiveBoneBlend.__PropertyOffset_ChestBlendDepth) = value;
			}
		}

		// Token: 0x17004FB0 RID: 20400
		// (get) Token: 0x060144F5 RID: 83189 RVA: 0x001DD5E7 File Offset: 0x001DB7E7
		// (set) Token: 0x060144F6 RID: 83190 RVA: 0x001DD5F7 File Offset: 0x001DB7F7
		public unsafe bool bDebug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_AdditiveBoneBlend.__PropertyOffset_bDebug) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_AdditiveBoneBlend.__PropertyOffset_bDebug) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004FB1 RID: 20401
		// (get) Token: 0x060144F7 RID: 83191 RVA: 0x001DD608 File Offset: 0x001DB808
		// (set) Token: 0x060144F8 RID: 83192 RVA: 0x001DD64B File Offset: 0x001DB84B
		public TArray<FBoneReference> SupperotBoneConfigs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBoneReference> result;
				if ((result = this._SupperotBoneConfigs) == null)
				{
					result = (this._SupperotBoneConfigs = new TArray<FBoneReference>(base.NativePtr + (IntPtr)FAnimNode_AdditiveBoneBlend.__PropertyOffset_SupperotBoneConfigs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SupperotBoneConfigs.CopyAssign(value);
			}
		}

		// Token: 0x17004FB2 RID: 20402
		// (get) Token: 0x060144F9 RID: 83193 RVA: 0x001DD65C File Offset: 0x001DB85C
		// (set) Token: 0x060144FA RID: 83194 RVA: 0x001DD69F File Offset: 0x001DB89F
		public TMap<FName, int> SpecialCurves
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, int> result;
				if ((result = this._SpecialCurves) == null)
				{
					result = (this._SpecialCurves = new TMap<FName, int>(base.NativePtr + (IntPtr)FAnimNode_AdditiveBoneBlend.__PropertyOffset_SpecialCurves, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SpecialCurves.CopyAssign(value);
			}
		}

		// Token: 0x060144FB RID: 83195 RVA: 0x001DD6AD File Offset: 0x001DB8AD
		public FAnimNode_AdditiveBoneBlend()
		{
		}

		// Token: 0x060144FC RID: 83196 RVA: 0x001DD6B8 File Offset: 0x001DB8B8
		public FAnimNode_AdditiveBoneBlend(FPoseLink BaseLayer, FPoseLink OverlayLayer, FPoseLink AdditiveBasePose, TArray<FAdditiveBlendAlpha> AdditiveBlendAlpha, bool bMeshSpaceAdd, TArray<FMaskLayer> LayerSetup, float Alpha, float ChestBlendDepth, bool bDebug, TArray<FBoneReference> SupperotBoneConfigs, TMap<FName, int> SpecialCurves)
		{
			this.BaseLayer = BaseLayer;
			this.OverlayLayer = OverlayLayer;
			this.AdditiveBasePose = AdditiveBasePose;
			this.AdditiveBlendAlpha = AdditiveBlendAlpha;
			this.bMeshSpaceAdd = bMeshSpaceAdd;
			this.LayerSetup = LayerSetup;
			this.Alpha = Alpha;
			this.ChestBlendDepth = ChestBlendDepth;
			this.bDebug = bDebug;
			this.SupperotBoneConfigs = SupperotBoneConfigs;
			this.SpecialCurves = SpecialCurves;
		}

		// Token: 0x060144FD RID: 83197 RVA: 0x001DD720 File Offset: 0x001DB920
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_AdditiveBoneBlend.StaticStruct();
		}

		// Token: 0x060144FE RID: 83198 RVA: 0x001DD72C File Offset: 0x001DB92C
		[NullableContext(2)]
		public FAnimNode_AdditiveBoneBlend(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060144FF RID: 83199 RVA: 0x001DD736 File Offset: 0x001DB936
		public FAnimNode_AdditiveBoneBlend(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014500 RID: 83200 RVA: 0x001DD741 File Offset: 0x001DB941
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_AdditiveBoneBlend(Pointer, false, true);
		}

		// Token: 0x06014501 RID: 83201 RVA: 0x001DD74B File Offset: 0x001DB94B
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_AdditiveBoneBlend(Pointer, MemoryOwner);
		}

		// Token: 0x0400B0CC RID: 45260
		public new const string __ObjectPath = "/Script/KuroAnim.AnimNode_AdditiveBoneBlend";

		// Token: 0x0400B0CD RID: 45261
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B0CE RID: 45262
		internal static int __PropertyOffset_BaseLayer;

		// Token: 0x0400B0CF RID: 45263
		[Nullable(2)]
		private FPoseLink _BaseLayer;

		// Token: 0x0400B0D0 RID: 45264
		internal static int __PropertyOffset_OverlayLayer;

		// Token: 0x0400B0D1 RID: 45265
		[Nullable(2)]
		private FPoseLink _OverlayLayer;

		// Token: 0x0400B0D2 RID: 45266
		internal static int __PropertyOffset_AdditiveBasePose;

		// Token: 0x0400B0D3 RID: 45267
		[Nullable(2)]
		private FPoseLink _AdditiveBasePose;

		// Token: 0x0400B0D4 RID: 45268
		internal static int __PropertyOffset_AdditiveBlendAlpha;

		// Token: 0x0400B0D5 RID: 45269
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAdditiveBlendAlpha> _AdditiveBlendAlpha;

		// Token: 0x0400B0D6 RID: 45270
		internal static int __PropertyOffset_bMeshSpaceAdd;

		// Token: 0x0400B0D7 RID: 45271
		internal static int __PropertyOffset_LayerSetup;

		// Token: 0x0400B0D8 RID: 45272
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMaskLayer> _LayerSetup;

		// Token: 0x0400B0D9 RID: 45273
		internal static int __PropertyOffset_Alpha;

		// Token: 0x0400B0DA RID: 45274
		internal static int __PropertyOffset_ChestBlendDepth;

		// Token: 0x0400B0DB RID: 45275
		internal static int __PropertyOffset_bDebug;

		// Token: 0x0400B0DC RID: 45276
		internal static int __PropertyOffset_SupperotBoneConfigs;

		// Token: 0x0400B0DD RID: 45277
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBoneReference> _SupperotBoneConfigs;

		// Token: 0x0400B0DE RID: 45278
		internal static int __PropertyOffset_SpecialCurves;

		// Token: 0x0400B0DF RID: 45279
		[Nullable(2)]
		private TMap<FName, int> _SpecialCurves;
	}
}
