using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019A1 RID: 6561
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroInteractionEffect.KuroEnviInteractionComponent")]
	[UnrealStructLayout(568, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 568)]
	public class UKuroEnviInteractionComponent : UActorComponent, IUnrealUObject, IUnrealObject, IKuroWaterDetectedInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06018647 RID: 99911 RVA: 0x0023F524 File Offset: 0x0023D724
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroEnviInteractionComponent._ClassPtr;
		}

		// Token: 0x06018648 RID: 99912 RVA: 0x0023F530 File Offset: 0x0023D730
		int IKuroWaterDetectedInterface.InterfaceOffset()
		{
			return UKuroEnviInteractionComponent.__InterfaceOffset_IKuroWaterDetectedInterface;
		}

		// Token: 0x06018649 RID: 99913 RVA: 0x0023F538 File Offset: 0x0023D738
		public UKuroEnviInteractionComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroEnviInteractionComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601864A RID: 99914 RVA: 0x0023F560 File Offset: 0x0023D760
		public UKuroEnviInteractionComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroEnviInteractionComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006163 RID: 24931
		// (get) Token: 0x0601864B RID: 99915 RVA: 0x0023F593 File Offset: 0x0023D793
		// (set) Token: 0x0601864C RID: 99916 RVA: 0x0023F5A3 File Offset: 0x0023D7A3
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

		// Token: 0x17006164 RID: 24932
		// (get) Token: 0x0601864D RID: 99917 RVA: 0x0023F5B4 File Offset: 0x0023D7B4
		// (set) Token: 0x0601864E RID: 99918 RVA: 0x0023F5C8 File Offset: 0x0023D7C8
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

		// Token: 0x17006165 RID: 24933
		// (get) Token: 0x0601864F RID: 99919 RVA: 0x0023F5DD File Offset: 0x0023D7DD
		// (set) Token: 0x06018650 RID: 99920 RVA: 0x0023F5F1 File Offset: 0x0023D7F1
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

		// Token: 0x17006166 RID: 24934
		// (get) Token: 0x06018651 RID: 99921 RVA: 0x0023F606 File Offset: 0x0023D806
		// (set) Token: 0x06018652 RID: 99922 RVA: 0x0023F616 File Offset: 0x0023D816
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

		// Token: 0x17006167 RID: 24935
		// (get) Token: 0x06018653 RID: 99923 RVA: 0x0023F627 File Offset: 0x0023D827
		// (set) Token: 0x06018654 RID: 99924 RVA: 0x0023F637 File Offset: 0x0023D837
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

		// Token: 0x17006168 RID: 24936
		// (get) Token: 0x06018655 RID: 99925 RVA: 0x0023F648 File Offset: 0x0023D848
		// (set) Token: 0x06018656 RID: 99926 RVA: 0x0023F658 File Offset: 0x0023D858
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

		// Token: 0x17006169 RID: 24937
		// (get) Token: 0x06018657 RID: 99927 RVA: 0x0023F669 File Offset: 0x0023D869
		// (set) Token: 0x06018658 RID: 99928 RVA: 0x0023F679 File Offset: 0x0023D879
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

		// Token: 0x1700616A RID: 24938
		// (get) Token: 0x06018659 RID: 99929 RVA: 0x0023F68A File Offset: 0x0023D88A
		// (set) Token: 0x0601865A RID: 99930 RVA: 0x0023F69A File Offset: 0x0023D89A
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

		// Token: 0x1700616B RID: 24939
		// (get) Token: 0x0601865B RID: 99931 RVA: 0x0023F6AB File Offset: 0x0023D8AB
		// (set) Token: 0x0601865C RID: 99932 RVA: 0x0023F6BB File Offset: 0x0023D8BB
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

		// Token: 0x1700616C RID: 24940
		// (get) Token: 0x0601865D RID: 99933 RVA: 0x0023F6CC File Offset: 0x0023D8CC
		// (set) Token: 0x0601865E RID: 99934 RVA: 0x0023F6DC File Offset: 0x0023D8DC
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

		// Token: 0x1700616D RID: 24941
		// (get) Token: 0x0601865F RID: 99935 RVA: 0x0023F6F0 File Offset: 0x0023D8F0
		// (set) Token: 0x06018660 RID: 99936 RVA: 0x0023F729 File Offset: 0x0023D929
		public TMap<int, UMaterialParameterCollection> SPModelMPCMap
		{
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
			set
			{
				this.SPModelMPCMap.CopyAssign(value);
			}
		}

		// Token: 0x1700616E RID: 24942
		// (get) Token: 0x06018661 RID: 99937 RVA: 0x0023F737 File Offset: 0x0023D937
		// (set) Token: 0x06018662 RID: 99938 RVA: 0x0023F747 File Offset: 0x0023D947
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

		// Token: 0x1700616F RID: 24943
		// (get) Token: 0x06018663 RID: 99939 RVA: 0x0023F758 File Offset: 0x0023D958
		// (set) Token: 0x06018664 RID: 99940 RVA: 0x0023F791 File Offset: 0x0023D991
		public TMap<int, FSPModelSCPMap> SPModelColorMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, FSPModelSCPMap> result;
				if ((result = this._SPModelColorMap) == null)
				{
					result = (this._SPModelColorMap = new TMap<int, FSPModelSCPMap>(base.NativePtr + (IntPtr)UKuroEnviInteractionComponent.__PropertyOffset_SPModelColorMap, this));
				}
				return result;
			}
			set
			{
				this.SPModelColorMap.CopyAssign(value);
			}
		}

		// Token: 0x17006170 RID: 24944
		// (get) Token: 0x06018665 RID: 99941 RVA: 0x0023F79F File Offset: 0x0023D99F
		// (set) Token: 0x06018666 RID: 99942 RVA: 0x0023F7B3 File Offset: 0x0023D9B3
		[Nullable(2)]
		public unsafe UTraceSphereElement RainOcclusionTraceElement
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTraceSphereElement>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroEnviInteractionComponent.__PropertyOffset_RainOcclusionTraceElement);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroEnviInteractionComponent.__PropertyOffset_RainOcclusionTraceElement, value);
			}
		}

		// Token: 0x06018667 RID: 99943 RVA: 0x0023F7C8 File Offset: 0x0023D9C8
		[NullableContext(2)]
		public void UpdateRainOcclusion(bool Result, UTraceBaseElement Element, double Frame, double Index)
		{
			UKuroEnviInteractionComponent.__UpdateRainOcclusion_Internal(base.NativePtr, Result, (Element != null) ? Element.NativePtr : IntPtr.Zero, Frame, Index);
		}

		// Token: 0x06018668 RID: 99944 RVA: 0x0023F7E9 File Offset: 0x0023D9E9
		[NullableContext(2)]
		public void SetNiagaraCompShiftColor(UNiagaraComponent NiagaraComponent)
		{
			UKuroEnviInteractionComponent.__SetNiagaraCompShiftColor_Internal(base.NativePtr, (NiagaraComponent != null) ? NiagaraComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06018669 RID: 99945 RVA: 0x0023F806 File Offset: 0x0023DA06
		[NullableContext(2)]
		public void SetDecalCompShiftColor(UDecalComponent DecalComponent)
		{
			UKuroEnviInteractionComponent.__SetDecalCompShiftColor_Internal(base.NativePtr, (DecalComponent != null) ? DecalComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601866A RID: 99946 RVA: 0x0023F823 File Offset: 0x0023DA23
		public void RegisterComponentToSystem()
		{
			UKuroEnviInteractionComponent.__RegisterComponentToSystem_Internal(base.NativePtr);
		}

		// Token: 0x0601866B RID: 99947 RVA: 0x0023F830 File Offset: 0x0023DA30
		public bool IsOccludedInRain()
		{
			return UKuroEnviInteractionComponent.__IsOccludedInRain_Internal(base.NativePtr);
		}

		// Token: 0x0601866C RID: 99948 RVA: 0x0023F83D File Offset: 0x0023DA3D
		public float GetRainWalkOcclusionParam()
		{
			return UKuroEnviInteractionComponent.__GetRainWalkOcclusionParam_Internal(base.NativePtr);
		}

		// Token: 0x0601866D RID: 99949 RVA: 0x0023F84A File Offset: 0x0023DA4A
		public FKuroEnviInteractionData GetEnviInteractionData()
		{
			return new FKuroEnviInteractionData(UKuroEnviInteractionComponent.__GetEnviInteractionData_Internal(base.NativePtr), null);
		}

		// Token: 0x0601866E RID: 99950
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateRainOcclusion_Internal(IntPtr @this, bool Result, IntPtr Element, double Frame, double Index);

		// Token: 0x0601866F RID: 99951
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraCompShiftColor_Internal(IntPtr @this, IntPtr NiagaraComponent);

		// Token: 0x06018670 RID: 99952
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDecalCompShiftColor_Internal(IntPtr @this, IntPtr DecalComponent);

		// Token: 0x06018671 RID: 99953
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterComponentToSystem_Internal(IntPtr @this);

		// Token: 0x06018672 RID: 99954
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsOccludedInRain_Internal(IntPtr @this);

		// Token: 0x06018673 RID: 99955
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRainWalkOcclusionParam_Internal(IntPtr @this);

		// Token: 0x06018674 RID: 99956
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetEnviInteractionData_Internal(IntPtr @this);

		// Token: 0x06018675 RID: 99957 RVA: 0x0023F85D File Offset: 0x0023DA5D
		static UKuroEnviInteractionComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroInteractionEffect.KuroEnviInteractionComponent");
		}

		// Token: 0x06018676 RID: 99958 RVA: 0x0023F86B File Offset: 0x0023DA6B
		protected UKuroEnviInteractionComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D2F6 RID: 54006
		internal static int __InterfaceOffset_IKuroWaterDetectedInterface;

		// Token: 0x0400D2F7 RID: 54007
		public new const string __ObjectPath = "/Script/KuroInteractionEffect.KuroEnviInteractionComponent";

		// Token: 0x0400D2F8 RID: 54008
		private static IntPtr _ClassPtr;

		// Token: 0x0400D2F9 RID: 54009
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D2FA RID: 54010
		internal static int __PropertyOffset_bCalEnviInteractionData;

		// Token: 0x0400D2FB RID: 54011
		internal static int __PropertyOffset_RayFromOffset;

		// Token: 0x0400D2FC RID: 54012
		internal static int __PropertyOffset_RayToOffset;

		// Token: 0x0400D2FD RID: 54013
		internal static int __PropertyOffset_FrameCountToWaterTrace;

		// Token: 0x0400D2FE RID: 54014
		internal static int __PropertyOffset_bUpdateWaterEID;

		// Token: 0x0400D2FF RID: 54015
		internal static int __PropertyOffset_bUpdateRainOcclusion;

		// Token: 0x0400D300 RID: 54016
		internal static int __PropertyOffset_bUseSPModelCharacterData;

		// Token: 0x0400D301 RID: 54017
		internal static int __PropertyOffset_ModelConfigId;

		// Token: 0x0400D302 RID: 54018
		internal static int __PropertyOffset_ModelStateId;

		// Token: 0x0400D303 RID: 54019
		internal static int __PropertyOffset_LinkNiagaraModeId;

		// Token: 0x0400D304 RID: 54020
		internal static int __PropertyOffset_SPModelMPCMap;

		// Token: 0x0400D305 RID: 54021
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, UMaterialParameterCollection> _SPModelMPCMap;

		// Token: 0x0400D306 RID: 54022
		internal static int __PropertyOffset_bUseSPModelShiftColor;

		// Token: 0x0400D307 RID: 54023
		internal static int __PropertyOffset_SPModelColorMap;

		// Token: 0x0400D308 RID: 54024
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, FSPModelSCPMap> _SPModelColorMap;

		// Token: 0x0400D309 RID: 54025
		internal static int __PropertyOffset_RainOcclusionTraceElement;
	}
}
