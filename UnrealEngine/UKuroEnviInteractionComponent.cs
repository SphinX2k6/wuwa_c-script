using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200044E RID: 1102
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroInteractionEffect.KuroEnviInteractionComponent")]
	[UnrealStructLayout(672, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 672)]
	public class UKuroEnviInteractionComponent : UActorComponent, IUnrealUObject, IUnrealObject, IKuroWaterDetectedInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06006A57 RID: 27223 RVA: 0x0009B0B3 File Offset: 0x000992B3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroEnviInteractionComponent._ClassPtr;
		}

		// Token: 0x06006A58 RID: 27224 RVA: 0x0009B0BF File Offset: 0x000992BF
		int IKuroWaterDetectedInterface.InterfaceOffset()
		{
			return UKuroEnviInteractionComponent.__InterfaceOffset_IKuroWaterDetectedInterface;
		}

		// Token: 0x06006A59 RID: 27225 RVA: 0x0009B0C8 File Offset: 0x000992C8
		public UKuroEnviInteractionComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroEnviInteractionComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006A5A RID: 27226 RVA: 0x0009B0F0 File Offset: 0x000992F0
		[NullableContext(1)]
		public UKuroEnviInteractionComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroEnviInteractionComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700151E RID: 5406
		// (get) Token: 0x06006A5B RID: 27227 RVA: 0x0009B123 File Offset: 0x00099323
		// (set) Token: 0x06006A5C RID: 27228 RVA: 0x0009B133 File Offset: 0x00099333
		public unsafe bool bCalEnviInteractionData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroEnviInteractionComponent.__PropertyOffset_bCalEnviInteractionData) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroEnviInteractionComponent.__PropertyOffset_bCalEnviInteractionData) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700151F RID: 5407
		// (get) Token: 0x06006A5D RID: 27229 RVA: 0x0009B144 File Offset: 0x00099344
		// (set) Token: 0x06006A5E RID: 27230 RVA: 0x0009B158 File Offset: 0x00099358
		public unsafe FVector RayFromOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroEnviInteractionComponent.__PropertyOffset_RayFromOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroEnviInteractionComponent.__PropertyOffset_RayFromOffset) = value;
			}
		}

		// Token: 0x17001520 RID: 5408
		// (get) Token: 0x06006A5F RID: 27231 RVA: 0x0009B16D File Offset: 0x0009936D
		// (set) Token: 0x06006A60 RID: 27232 RVA: 0x0009B181 File Offset: 0x00099381
		public unsafe FVector RayToOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroEnviInteractionComponent.__PropertyOffset_RayToOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroEnviInteractionComponent.__PropertyOffset_RayToOffset) = value;
			}
		}

		// Token: 0x17001521 RID: 5409
		// (get) Token: 0x06006A61 RID: 27233 RVA: 0x0009B196 File Offset: 0x00099396
		// (set) Token: 0x06006A62 RID: 27234 RVA: 0x0009B1A6 File Offset: 0x000993A6
		public unsafe float FrameCountToWaterTrace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroEnviInteractionComponent.__PropertyOffset_FrameCountToWaterTrace);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroEnviInteractionComponent.__PropertyOffset_FrameCountToWaterTrace) = value;
			}
		}

		// Token: 0x17001522 RID: 5410
		// (get) Token: 0x06006A63 RID: 27235 RVA: 0x0009B1B7 File Offset: 0x000993B7
		// (set) Token: 0x06006A64 RID: 27236 RVA: 0x0009B1C7 File Offset: 0x000993C7
		public unsafe bool bUpdateWaterEID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroEnviInteractionComponent.__PropertyOffset_bUpdateWaterEID) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroEnviInteractionComponent.__PropertyOffset_bUpdateWaterEID) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001523 RID: 5411
		// (get) Token: 0x06006A65 RID: 27237 RVA: 0x0009B1D8 File Offset: 0x000993D8
		// (set) Token: 0x06006A66 RID: 27238 RVA: 0x0009B1E8 File Offset: 0x000993E8
		public unsafe bool bUpdateRainOcclusion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroEnviInteractionComponent.__PropertyOffset_bUpdateRainOcclusion) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroEnviInteractionComponent.__PropertyOffset_bUpdateRainOcclusion) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001524 RID: 5412
		// (get) Token: 0x06006A67 RID: 27239 RVA: 0x0009B1F9 File Offset: 0x000993F9
		// (set) Token: 0x06006A68 RID: 27240 RVA: 0x0009B209 File Offset: 0x00099409
		public unsafe bool bUseSPModelCharacterData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroEnviInteractionComponent.__PropertyOffset_bUseSPModelCharacterData) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroEnviInteractionComponent.__PropertyOffset_bUseSPModelCharacterData) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001525 RID: 5413
		// (get) Token: 0x06006A69 RID: 27241 RVA: 0x0009B21A File Offset: 0x0009941A
		// (set) Token: 0x06006A6A RID: 27242 RVA: 0x0009B22A File Offset: 0x0009942A
		public unsafe int ModelConfigId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroEnviInteractionComponent.__PropertyOffset_ModelConfigId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroEnviInteractionComponent.__PropertyOffset_ModelConfigId) = value;
			}
		}

		// Token: 0x17001526 RID: 5414
		// (get) Token: 0x06006A6B RID: 27243 RVA: 0x0009B23B File Offset: 0x0009943B
		// (set) Token: 0x06006A6C RID: 27244 RVA: 0x0009B24B File Offset: 0x0009944B
		public unsafe int ModelStateId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroEnviInteractionComponent.__PropertyOffset_ModelStateId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroEnviInteractionComponent.__PropertyOffset_ModelStateId) = value;
			}
		}

		// Token: 0x17001527 RID: 5415
		// (get) Token: 0x06006A6D RID: 27245 RVA: 0x0009B25C File Offset: 0x0009945C
		// (set) Token: 0x06006A6E RID: 27246 RVA: 0x0009B26C File Offset: 0x0009946C
		public unsafe int LinkNiagaraModeId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroEnviInteractionComponent.__PropertyOffset_LinkNiagaraModeId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroEnviInteractionComponent.__PropertyOffset_LinkNiagaraModeId) = value;
			}
		}

		// Token: 0x17001528 RID: 5416
		// (get) Token: 0x06006A6F RID: 27247 RVA: 0x0009B280 File Offset: 0x00099480
		// (set) Token: 0x06006A70 RID: 27248 RVA: 0x0009B2B9 File Offset: 0x000994B9
		[Nullable(1)]
		public TMap<int, UMaterialParameterCollection> SPModelMPCMap
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<int, UMaterialParameterCollection> result;
				if ((result = this._SPModelMPCMap) == null)
				{
					result = (this._SPModelMPCMap = new TMap<int, UMaterialParameterCollection>(base.NativePtr + (IntPtr)UKuroEnviInteractionComponent.__PropertyOffset_SPModelMPCMap, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SPModelMPCMap.CopyAssign(value);
			}
		}

		// Token: 0x17001529 RID: 5417
		// (get) Token: 0x06006A71 RID: 27249 RVA: 0x0009B2C7 File Offset: 0x000994C7
		// (set) Token: 0x06006A72 RID: 27250 RVA: 0x0009B2D7 File Offset: 0x000994D7
		public unsafe bool bUseSPModelShiftColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroEnviInteractionComponent.__PropertyOffset_bUseSPModelShiftColor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroEnviInteractionComponent.__PropertyOffset_bUseSPModelShiftColor) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700152A RID: 5418
		// (get) Token: 0x06006A73 RID: 27251 RVA: 0x0009B2E8 File Offset: 0x000994E8
		// (set) Token: 0x06006A74 RID: 27252 RVA: 0x0009B2FC File Offset: 0x000994FC
		public unsafe UNiagaraComponent WaterVoxelSplashInNiagaraComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroEnviInteractionComponent.__PropertyOffset_WaterVoxelSplashInNiagaraComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroEnviInteractionComponent.__PropertyOffset_WaterVoxelSplashInNiagaraComponent, value);
			}
		}

		// Token: 0x1700152B RID: 5419
		// (get) Token: 0x06006A75 RID: 27253 RVA: 0x0009B311 File Offset: 0x00099511
		// (set) Token: 0x06006A76 RID: 27254 RVA: 0x0009B325 File Offset: 0x00099525
		public unsafe UTraceSphereElement RainOcclusionTraceElement
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTraceSphereElement>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroEnviInteractionComponent.__PropertyOffset_RainOcclusionTraceElement);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroEnviInteractionComponent.__PropertyOffset_RainOcclusionTraceElement, value);
			}
		}

		// Token: 0x06006A77 RID: 27255 RVA: 0x0009B33A File Offset: 0x0009953A
		public void UpdateRainOcclusion(bool Result, UTraceBaseElement Element, double Frame, double Index)
		{
			UKuroEnviInteractionComponent.__UpdateRainOcclusion_Internal(base.NativePtr, Result, (Element != null) ? Element.NativePtr : IntPtr.Zero, Frame, Index);
		}

		// Token: 0x06006A78 RID: 27256 RVA: 0x0009B35B File Offset: 0x0009955B
		public void UnBindInteractionVoxelOverlap()
		{
			UKuroEnviInteractionComponent.__UnBindInteractionVoxelOverlap_Internal(base.NativePtr);
		}

		// Token: 0x06006A79 RID: 27257 RVA: 0x0009B368 File Offset: 0x00099568
		public void SetNiagaraCompShiftColor(UNiagaraComponent NiagaraComponent)
		{
			UKuroEnviInteractionComponent.__SetNiagaraCompShiftColor_Internal(base.NativePtr, (NiagaraComponent != null) ? NiagaraComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006A7A RID: 27258 RVA: 0x0009B385 File Offset: 0x00099585
		public void SetDecalCompShiftColor(UDecalComponent DecalComponent)
		{
			UKuroEnviInteractionComponent.__SetDecalCompShiftColor_Internal(base.NativePtr, (DecalComponent != null) ? DecalComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006A7B RID: 27259 RVA: 0x0009B3A2 File Offset: 0x000995A2
		public void RegisterComponentToSystem()
		{
			UKuroEnviInteractionComponent.__RegisterComponentToSystem_Internal(base.NativePtr);
		}

		// Token: 0x06006A7C RID: 27260 RVA: 0x0009B3AF File Offset: 0x000995AF
		public bool IsOccludedInRain()
		{
			return UKuroEnviInteractionComponent.__IsOccludedInRain_Internal(base.NativePtr);
		}

		// Token: 0x06006A7D RID: 27261 RVA: 0x0009B3BC File Offset: 0x000995BC
		public float GetRainWalkOcclusionParam()
		{
			return UKuroEnviInteractionComponent.__GetRainWalkOcclusionParam_Internal(base.NativePtr);
		}

		// Token: 0x06006A7E RID: 27262 RVA: 0x0009B3C9 File Offset: 0x000995C9
		[NullableContext(1)]
		public FKuroEnviInteractionData GetEnviInteractionData()
		{
			return new FKuroEnviInteractionData(UKuroEnviInteractionComponent.__GetEnviInteractionData_Internal(base.NativePtr), null);
		}

		// Token: 0x06006A7F RID: 27263 RVA: 0x0009B3DC File Offset: 0x000995DC
		public void BindInteractionVoxelOverlap()
		{
			UKuroEnviInteractionComponent.__BindInteractionVoxelOverlap_Internal(base.NativePtr);
		}

		// Token: 0x06006A80 RID: 27264
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateRainOcclusion_Internal(IntPtr @this, bool Result, IntPtr Element, double Frame, double Index);

		// Token: 0x06006A81 RID: 27265
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnBindInteractionVoxelOverlap_Internal(IntPtr @this);

		// Token: 0x06006A82 RID: 27266
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraCompShiftColor_Internal(IntPtr @this, IntPtr NiagaraComponent);

		// Token: 0x06006A83 RID: 27267
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDecalCompShiftColor_Internal(IntPtr @this, IntPtr DecalComponent);

		// Token: 0x06006A84 RID: 27268
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterComponentToSystem_Internal(IntPtr @this);

		// Token: 0x06006A85 RID: 27269
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsOccludedInRain_Internal(IntPtr @this);

		// Token: 0x06006A86 RID: 27270
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRainWalkOcclusionParam_Internal(IntPtr @this);

		// Token: 0x06006A87 RID: 27271
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetEnviInteractionData_Internal(IntPtr @this);

		// Token: 0x06006A88 RID: 27272
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindInteractionVoxelOverlap_Internal(IntPtr @this);

		// Token: 0x06006A89 RID: 27273 RVA: 0x0009B3E9 File Offset: 0x000995E9
		static UKuroEnviInteractionComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroInteractionEffect.KuroEnviInteractionComponent");
		}

		// Token: 0x06006A8A RID: 27274 RVA: 0x0009B3F7 File Offset: 0x000995F7
		protected UKuroEnviInteractionComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002D19 RID: 11545
		internal static int __InterfaceOffset_IKuroWaterDetectedInterface;

		// Token: 0x04002D1A RID: 11546
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroInteractionEffect.KuroEnviInteractionComponent";

		// Token: 0x04002D1B RID: 11547
		private static IntPtr _ClassPtr;

		// Token: 0x04002D1C RID: 11548
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002D1D RID: 11549
		internal static int __PropertyOffset_bCalEnviInteractionData;

		// Token: 0x04002D1E RID: 11550
		internal static int __PropertyOffset_RayFromOffset;

		// Token: 0x04002D1F RID: 11551
		internal static int __PropertyOffset_RayToOffset;

		// Token: 0x04002D20 RID: 11552
		internal static int __PropertyOffset_FrameCountToWaterTrace;

		// Token: 0x04002D21 RID: 11553
		internal static int __PropertyOffset_bUpdateWaterEID;

		// Token: 0x04002D22 RID: 11554
		internal static int __PropertyOffset_bUpdateRainOcclusion;

		// Token: 0x04002D23 RID: 11555
		internal static int __PropertyOffset_bUseSPModelCharacterData;

		// Token: 0x04002D24 RID: 11556
		internal static int __PropertyOffset_ModelConfigId;

		// Token: 0x04002D25 RID: 11557
		internal static int __PropertyOffset_ModelStateId;

		// Token: 0x04002D26 RID: 11558
		internal static int __PropertyOffset_LinkNiagaraModeId;

		// Token: 0x04002D27 RID: 11559
		internal static int __PropertyOffset_SPModelMPCMap;

		// Token: 0x04002D28 RID: 11560
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, UMaterialParameterCollection> _SPModelMPCMap;

		// Token: 0x04002D29 RID: 11561
		internal static int __PropertyOffset_bUseSPModelShiftColor;

		// Token: 0x04002D2A RID: 11562
		internal static int __PropertyOffset_WaterVoxelSplashInNiagaraComponent;

		// Token: 0x04002D2B RID: 11563
		internal static int __PropertyOffset_RainOcclusionTraceElement;
	}
}
