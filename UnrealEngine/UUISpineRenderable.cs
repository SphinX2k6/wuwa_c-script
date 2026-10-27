using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021B7 RID: 8631
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UISpineRenderable")]
	[UnrealStructLayout(2768, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2768)]
	public class UUISpineRenderable : UUIBaseRenderable, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020D48 RID: 134472 RVA: 0x00308236 File Offset: 0x00306436
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUISpineRenderable._ClassPtr;
		}

		// Token: 0x06020D49 RID: 134473 RVA: 0x00308244 File Offset: 0x00306444
		public UUISpineRenderable() : this(BuiltinUtils.AllocNativeUObject(UUISpineRenderable.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020D4A RID: 134474 RVA: 0x0030826C File Offset: 0x0030646C
		public UUISpineRenderable(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUISpineRenderable.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008039 RID: 32825
		// (get) Token: 0x06020D4B RID: 134475 RVA: 0x0030829F File Offset: 0x0030649F
		// (set) Token: 0x06020D4C RID: 134476 RVA: 0x003082AF File Offset: 0x003064AF
		public unsafe float DepthOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISpineRenderable.__PropertyOffset_DepthOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISpineRenderable.__PropertyOffset_DepthOffset) = value;
			}
		}

		// Token: 0x1700803A RID: 32826
		// (get) Token: 0x06020D4D RID: 134477 RVA: 0x003082C0 File Offset: 0x003064C0
		// (set) Token: 0x06020D4E RID: 134478 RVA: 0x003082D4 File Offset: 0x003064D4
		public unsafe FName TextureParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISpineRenderable.__PropertyOffset_TextureParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISpineRenderable.__PropertyOffset_TextureParameterName) = value;
			}
		}

		// Token: 0x1700803B RID: 32827
		// (get) Token: 0x06020D4F RID: 134479 RVA: 0x003082E9 File Offset: 0x003064E9
		// (set) Token: 0x06020D50 RID: 134480 RVA: 0x003082F9 File Offset: 0x003064F9
		public unsafe bool bAdjustSizeWithAnimation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISpineRenderable.__PropertyOffset_bAdjustSizeWithAnimation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISpineRenderable.__PropertyOffset_bAdjustSizeWithAnimation) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700803C RID: 32828
		// (get) Token: 0x06020D51 RID: 134481 RVA: 0x0030830A File Offset: 0x0030650A
		// (set) Token: 0x06020D52 RID: 134482 RVA: 0x0030831A File Offset: 0x0030651A
		public unsafe bool bUseOptUpdateMeshSection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISpineRenderable.__PropertyOffset_bUseOptUpdateMeshSection) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISpineRenderable.__PropertyOffset_bUseOptUpdateMeshSection) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700803D RID: 32829
		// (get) Token: 0x06020D53 RID: 134483 RVA: 0x0030832B File Offset: 0x0030652B
		// (set) Token: 0x06020D54 RID: 134484 RVA: 0x0030833B File Offset: 0x0030653B
		public unsafe bool bIgnoreUpdateViewportClipSpine
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISpineRenderable.__PropertyOffset_bIgnoreUpdateViewportClipSpine) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISpineRenderable.__PropertyOffset_bIgnoreUpdateViewportClipSpine) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700803E RID: 32830
		// (get) Token: 0x06020D55 RID: 134485 RVA: 0x0030834C File Offset: 0x0030654C
		// (set) Token: 0x06020D56 RID: 134486 RVA: 0x00308385 File Offset: 0x00306585
		public TMap<string, FSpineAudioControl> AudioMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FSpineAudioControl> result;
				if ((result = this._AudioMap) == null)
				{
					result = (this._AudioMap = new TMap<string, FSpineAudioControl>(base.NativePtr + (IntPtr)UUISpineRenderable.__PropertyOffset_AudioMap, this));
				}
				return result;
			}
			set
			{
				this.AudioMap.CopyAssign(value);
			}
		}

		// Token: 0x1700803F RID: 32831
		// (get) Token: 0x06020D57 RID: 134487 RVA: 0x00308393 File Offset: 0x00306593
		// (set) Token: 0x06020D58 RID: 134488 RVA: 0x003083A7 File Offset: 0x003065A7
		[Nullable(2)]
		public unsafe USpineRenderBufferCache RenderBufferCache
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpineRenderBufferCache>(base.NativePtr / (IntPtr)sizeof(void*) + UUISpineRenderable.__PropertyOffset_RenderBufferCache);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUISpineRenderable.__PropertyOffset_RenderBufferCache, value);
			}
		}

		// Token: 0x17008040 RID: 32832
		// (get) Token: 0x06020D59 RID: 134489 RVA: 0x003083BC File Offset: 0x003065BC
		// (set) Token: 0x06020D5A RID: 134490 RVA: 0x003083CC File Offset: 0x003065CC
		public unsafe bool bNeedParallelUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISpineRenderable.__PropertyOffset_bNeedParallelUpdate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISpineRenderable.__PropertyOffset_bNeedParallelUpdate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008041 RID: 32833
		// (get) Token: 0x06020D5B RID: 134491 RVA: 0x003083E0 File Offset: 0x003065E0
		// (set) Token: 0x06020D5C RID: 134492 RVA: 0x00308419 File Offset: 0x00306619
		public TArray<UUIDrawcallMesh> SpineMeshes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UUIDrawcallMesh> result;
				if ((result = this._SpineMeshes) == null)
				{
					result = (this._SpineMeshes = new TArray<UUIDrawcallMesh>(base.NativePtr + (IntPtr)UUISpineRenderable.__PropertyOffset_SpineMeshes, this));
				}
				return result;
			}
			set
			{
				this.SpineMeshes.CopyAssign(value);
			}
		}

		// Token: 0x17008042 RID: 32834
		// (get) Token: 0x06020D5D RID: 134493 RVA: 0x00308428 File Offset: 0x00306628
		// (set) Token: 0x06020D5E RID: 134494 RVA: 0x00308461 File Offset: 0x00306661
		public TMap<ELGUICanvasClipType, UMaterialInterface> NormalBlendMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TMap<ELGUICanvasClipType, UMaterialInterface> result;
				if ((result = this._NormalBlendMaterials) == null)
				{
					result = (this._NormalBlendMaterials = new TMap<ELGUICanvasClipType, UMaterialInterface>(base.NativePtr + (IntPtr)UUISpineRenderable.__PropertyOffset_NormalBlendMaterials, this));
				}
				return result;
			}
			set
			{
				this.NormalBlendMaterials.CopyAssign(value);
			}
		}

		// Token: 0x17008043 RID: 32835
		// (get) Token: 0x06020D5F RID: 134495 RVA: 0x00308470 File Offset: 0x00306670
		// (set) Token: 0x06020D60 RID: 134496 RVA: 0x003084A9 File Offset: 0x003066A9
		public TMap<ELGUICanvasClipType, UMaterialInterface> AdditiveBlendMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TMap<ELGUICanvasClipType, UMaterialInterface> result;
				if ((result = this._AdditiveBlendMaterials) == null)
				{
					result = (this._AdditiveBlendMaterials = new TMap<ELGUICanvasClipType, UMaterialInterface>(base.NativePtr + (IntPtr)UUISpineRenderable.__PropertyOffset_AdditiveBlendMaterials, this));
				}
				return result;
			}
			set
			{
				this.AdditiveBlendMaterials.CopyAssign(value);
			}
		}

		// Token: 0x17008044 RID: 32836
		// (get) Token: 0x06020D61 RID: 134497 RVA: 0x003084B8 File Offset: 0x003066B8
		// (set) Token: 0x06020D62 RID: 134498 RVA: 0x003084F1 File Offset: 0x003066F1
		public TMap<ELGUICanvasClipType, UMaterialInterface> MultiplyBlendMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TMap<ELGUICanvasClipType, UMaterialInterface> result;
				if ((result = this._MultiplyBlendMaterials) == null)
				{
					result = (this._MultiplyBlendMaterials = new TMap<ELGUICanvasClipType, UMaterialInterface>(base.NativePtr + (IntPtr)UUISpineRenderable.__PropertyOffset_MultiplyBlendMaterials, this));
				}
				return result;
			}
			set
			{
				this.MultiplyBlendMaterials.CopyAssign(value);
			}
		}

		// Token: 0x17008045 RID: 32837
		// (get) Token: 0x06020D63 RID: 134499 RVA: 0x00308500 File Offset: 0x00306700
		// (set) Token: 0x06020D64 RID: 134500 RVA: 0x00308539 File Offset: 0x00306739
		public TMap<ELGUICanvasClipType, UMaterialInterface> ScreenBlendMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TMap<ELGUICanvasClipType, UMaterialInterface> result;
				if ((result = this._ScreenBlendMaterials) == null)
				{
					result = (this._ScreenBlendMaterials = new TMap<ELGUICanvasClipType, UMaterialInterface>(base.NativePtr + (IntPtr)UUISpineRenderable.__PropertyOffset_ScreenBlendMaterials, this));
				}
				return result;
			}
			set
			{
				this.ScreenBlendMaterials.CopyAssign(value);
			}
		}

		// Token: 0x17008046 RID: 32838
		// (get) Token: 0x06020D65 RID: 134501 RVA: 0x00308548 File Offset: 0x00306748
		// (set) Token: 0x06020D66 RID: 134502 RVA: 0x00308581 File Offset: 0x00306781
		public TArray<UMaterialInstanceDynamic> AtlasNormalBlendMaterialArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._AtlasNormalBlendMaterialArray) == null)
				{
					result = (this._AtlasNormalBlendMaterialArray = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)UUISpineRenderable.__PropertyOffset_AtlasNormalBlendMaterialArray, this));
				}
				return result;
			}
			set
			{
				this.AtlasNormalBlendMaterialArray.CopyAssign(value);
			}
		}

		// Token: 0x17008047 RID: 32839
		// (get) Token: 0x06020D67 RID: 134503 RVA: 0x00308590 File Offset: 0x00306790
		// (set) Token: 0x06020D68 RID: 134504 RVA: 0x003085C9 File Offset: 0x003067C9
		public TArray<UMaterialInstanceDynamic> AtlasAdditiveBlendMaterialArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._AtlasAdditiveBlendMaterialArray) == null)
				{
					result = (this._AtlasAdditiveBlendMaterialArray = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)UUISpineRenderable.__PropertyOffset_AtlasAdditiveBlendMaterialArray, this));
				}
				return result;
			}
			set
			{
				this.AtlasAdditiveBlendMaterialArray.CopyAssign(value);
			}
		}

		// Token: 0x17008048 RID: 32840
		// (get) Token: 0x06020D69 RID: 134505 RVA: 0x003085D8 File Offset: 0x003067D8
		// (set) Token: 0x06020D6A RID: 134506 RVA: 0x00308611 File Offset: 0x00306811
		public TArray<UMaterialInstanceDynamic> AtlasMultiplyBlendMaterialArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._AtlasMultiplyBlendMaterialArray) == null)
				{
					result = (this._AtlasMultiplyBlendMaterialArray = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)UUISpineRenderable.__PropertyOffset_AtlasMultiplyBlendMaterialArray, this));
				}
				return result;
			}
			set
			{
				this.AtlasMultiplyBlendMaterialArray.CopyAssign(value);
			}
		}

		// Token: 0x17008049 RID: 32841
		// (get) Token: 0x06020D6B RID: 134507 RVA: 0x00308620 File Offset: 0x00306820
		// (set) Token: 0x06020D6C RID: 134508 RVA: 0x00308659 File Offset: 0x00306859
		public TArray<UMaterialInstanceDynamic> AtlasScreenBlendMaterialArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._AtlasScreenBlendMaterialArray) == null)
				{
					result = (this._AtlasScreenBlendMaterialArray = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)UUISpineRenderable.__PropertyOffset_AtlasScreenBlendMaterialArray, this));
				}
				return result;
			}
			set
			{
				this.AtlasScreenBlendMaterialArray.CopyAssign(value);
			}
		}

		// Token: 0x1700804A RID: 32842
		// (get) Token: 0x06020D6D RID: 134509 RVA: 0x00308667 File Offset: 0x00306867
		// (set) Token: 0x06020D6E RID: 134510 RVA: 0x0030867B File Offset: 0x0030687B
		[Nullable(2)]
		public unsafe USpineSkeletonDataAsset CurrSkeletonData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpineSkeletonDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UUISpineRenderable.__PropertyOffset_CurrSkeletonData);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUISpineRenderable.__PropertyOffset_CurrSkeletonData, value);
			}
		}

		// Token: 0x06020D6F RID: 134511 RVA: 0x00308690 File Offset: 0x00306890
		public void TestPlayPreviewAnimInRuntime()
		{
			UUISpineRenderable.__TestPlayPreviewAnimInRuntime_Internal(base.NativePtr);
		}

		// Token: 0x06020D70 RID: 134512 RVA: 0x0030869D File Offset: 0x0030689D
		[NullableContext(2)]
		public void OnSpineAnimationStart(UTrackEntry entry)
		{
			UUISpineRenderable.__OnSpineAnimationStart_Internal(base.NativePtr, (entry != null) ? entry.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06020D71 RID: 134513 RVA: 0x003086BA File Offset: 0x003068BA
		[NullableContext(2)]
		public void OnSpineAnimationEnd(UTrackEntry entry)
		{
			UUISpineRenderable.__OnSpineAnimationEnd_Internal(base.NativePtr, (entry != null) ? entry.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06020D72 RID: 134514 RVA: 0x003086D7 File Offset: 0x003068D7
		public int GetTotalVerticeNum()
		{
			return UUISpineRenderable.__GetTotalVerticeNum_Internal(base.NativePtr);
		}

		// Token: 0x06020D73 RID: 134515 RVA: 0x003086E4 File Offset: 0x003068E4
		public int GetMeshesNum()
		{
			return UUISpineRenderable.__GetMeshesNum_Internal(base.NativePtr);
		}

		// Token: 0x06020D74 RID: 134516 RVA: 0x003086F1 File Offset: 0x003068F1
		[NullableContext(2)]
		public void AfterSkeletonUpdate(USpineSkeletonComponent SkeletonComponent)
		{
			UUISpineRenderable.__AfterSkeletonUpdate_Internal(base.NativePtr, (SkeletonComponent != null) ? SkeletonComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06020D75 RID: 134517 RVA: 0x0030870E File Offset: 0x0030690E
		public void AdjustSize()
		{
			UUISpineRenderable.__AdjustSize_Internal(base.NativePtr);
		}

		// Token: 0x06020D76 RID: 134518
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TestPlayPreviewAnimInRuntime_Internal(IntPtr @this);

		// Token: 0x06020D77 RID: 134519
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnSpineAnimationStart_Internal(IntPtr @this, IntPtr entry);

		// Token: 0x06020D78 RID: 134520
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnSpineAnimationEnd_Internal(IntPtr @this, IntPtr entry);

		// Token: 0x06020D79 RID: 134521
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetTotalVerticeNum_Internal(IntPtr @this);

		// Token: 0x06020D7A RID: 134522
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMeshesNum_Internal(IntPtr @this);

		// Token: 0x06020D7B RID: 134523
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AfterSkeletonUpdate_Internal(IntPtr @this, IntPtr SkeletonComponent);

		// Token: 0x06020D7C RID: 134524
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AdjustSize_Internal(IntPtr @this);

		// Token: 0x06020D7D RID: 134525 RVA: 0x0030871B File Offset: 0x0030691B
		static UUISpineRenderable()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UISpineRenderable");
		}

		// Token: 0x06020D7E RID: 134526 RVA: 0x00308729 File Offset: 0x00306929
		protected UUISpineRenderable(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011895 RID: 71829
		public new const string __ObjectPath = "/Script/LGUI.UISpineRenderable";

		// Token: 0x04011896 RID: 71830
		private static IntPtr _ClassPtr;

		// Token: 0x04011897 RID: 71831
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011898 RID: 71832
		internal static int __PropertyOffset_DepthOffset;

		// Token: 0x04011899 RID: 71833
		internal static int __PropertyOffset_TextureParameterName;

		// Token: 0x0401189A RID: 71834
		internal static int __PropertyOffset_bAdjustSizeWithAnimation;

		// Token: 0x0401189B RID: 71835
		internal static int __PropertyOffset_bUseOptUpdateMeshSection;

		// Token: 0x0401189C RID: 71836
		internal static int __PropertyOffset_bIgnoreUpdateViewportClipSpine;

		// Token: 0x0401189D RID: 71837
		internal static int __PropertyOffset_AudioMap;

		// Token: 0x0401189E RID: 71838
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, FSpineAudioControl> _AudioMap;

		// Token: 0x0401189F RID: 71839
		internal static int __PropertyOffset_RenderBufferCache;

		// Token: 0x040118A0 RID: 71840
		internal static int __PropertyOffset_bNeedParallelUpdate;

		// Token: 0x040118A1 RID: 71841
		internal static int __PropertyOffset_SpineMeshes;

		// Token: 0x040118A2 RID: 71842
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UUIDrawcallMesh> _SpineMeshes;

		// Token: 0x040118A3 RID: 71843
		internal static int __PropertyOffset_NormalBlendMaterials;

		// Token: 0x040118A4 RID: 71844
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<ELGUICanvasClipType, UMaterialInterface> _NormalBlendMaterials;

		// Token: 0x040118A5 RID: 71845
		internal static int __PropertyOffset_AdditiveBlendMaterials;

		// Token: 0x040118A6 RID: 71846
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<ELGUICanvasClipType, UMaterialInterface> _AdditiveBlendMaterials;

		// Token: 0x040118A7 RID: 71847
		internal static int __PropertyOffset_MultiplyBlendMaterials;

		// Token: 0x040118A8 RID: 71848
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<ELGUICanvasClipType, UMaterialInterface> _MultiplyBlendMaterials;

		// Token: 0x040118A9 RID: 71849
		internal static int __PropertyOffset_ScreenBlendMaterials;

		// Token: 0x040118AA RID: 71850
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<ELGUICanvasClipType, UMaterialInterface> _ScreenBlendMaterials;

		// Token: 0x040118AB RID: 71851
		internal static int __PropertyOffset_AtlasNormalBlendMaterialArray;

		// Token: 0x040118AC RID: 71852
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _AtlasNormalBlendMaterialArray;

		// Token: 0x040118AD RID: 71853
		internal static int __PropertyOffset_AtlasAdditiveBlendMaterialArray;

		// Token: 0x040118AE RID: 71854
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _AtlasAdditiveBlendMaterialArray;

		// Token: 0x040118AF RID: 71855
		internal static int __PropertyOffset_AtlasMultiplyBlendMaterialArray;

		// Token: 0x040118B0 RID: 71856
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _AtlasMultiplyBlendMaterialArray;

		// Token: 0x040118B1 RID: 71857
		internal static int __PropertyOffset_AtlasScreenBlendMaterialArray;

		// Token: 0x040118B2 RID: 71858
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _AtlasScreenBlendMaterialArray;

		// Token: 0x040118B3 RID: 71859
		internal static int __PropertyOffset_CurrSkeletonData;
	}
}
