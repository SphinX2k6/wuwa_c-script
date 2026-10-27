using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C62 RID: 3170
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InstancedStaticMeshComponent")]
	[UnrealStructLayout(2288, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2288)]
	public class UInstancedStaticMeshComponent : UStaticMeshComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A103 RID: 41219 RVA: 0x000E4C92 File Offset: 0x000E2E92
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInstancedStaticMeshComponent._ClassPtr;
		}

		// Token: 0x0600A104 RID: 41220 RVA: 0x000E4CA0 File Offset: 0x000E2EA0
		public UInstancedStaticMeshComponent() : this(BuiltinUtils.AllocNativeUObject(UInstancedStaticMeshComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A105 RID: 41221 RVA: 0x000E4CC8 File Offset: 0x000E2EC8
		public UInstancedStaticMeshComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInstancedStaticMeshComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700265A RID: 9818
		// (get) Token: 0x0600A106 RID: 41222 RVA: 0x000E4CFC File Offset: 0x000E2EFC
		// (set) Token: 0x0600A107 RID: 41223 RVA: 0x000E4D35 File Offset: 0x000E2F35
		public TArray<FInstancedStaticMeshInstanceData> PerInstanceSMData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FInstancedStaticMeshInstanceData> result;
				if ((result = this._PerInstanceSMData) == null)
				{
					result = (this._PerInstanceSMData = new TArray<FInstancedStaticMeshInstanceData>(base.NativePtr + (IntPtr)UInstancedStaticMeshComponent.__PropertyOffset_PerInstanceSMData, this));
				}
				return result;
			}
			set
			{
				this.PerInstanceSMData.CopyAssign(value);
			}
		}

		// Token: 0x1700265B RID: 9819
		// (get) Token: 0x0600A108 RID: 41224 RVA: 0x000E4D43 File Offset: 0x000E2F43
		// (set) Token: 0x0600A109 RID: 41225 RVA: 0x000E4D5C File Offset: 0x000E2F5C
		public unsafe bool bUseCustomRandomValue
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInstancedStaticMeshComponent.__PropertyOffset_bUseCustomRandomValue) & UInstancedStaticMeshComponent.__PropertyMask_bUseCustomRandomValue) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInstancedStaticMeshComponent.__PropertyOffset_bUseCustomRandomValue) = ((*(base.NativePtr + (IntPtr)UInstancedStaticMeshComponent.__PropertyOffset_bUseCustomRandomValue) & ~UInstancedStaticMeshComponent.__PropertyMask_bUseCustomRandomValue) | (value ? UInstancedStaticMeshComponent.__PropertyMask_bUseCustomRandomValue : 0));
			}
		}

		// Token: 0x1700265C RID: 9820
		// (get) Token: 0x0600A10A RID: 41226 RVA: 0x000E4D8C File Offset: 0x000E2F8C
		// (set) Token: 0x0600A10B RID: 41227 RVA: 0x000E4D9C File Offset: 0x000E2F9C
		public unsafe float BaseRandomValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInstancedStaticMeshComponent.__PropertyOffset_BaseRandomValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInstancedStaticMeshComponent.__PropertyOffset_BaseRandomValue) = value;
			}
		}

		// Token: 0x1700265D RID: 9821
		// (get) Token: 0x0600A10C RID: 41228 RVA: 0x000E4DAD File Offset: 0x000E2FAD
		// (set) Token: 0x0600A10D RID: 41229 RVA: 0x000E4DBD File Offset: 0x000E2FBD
		public unsafe EKuroISMCullingType KuroCullingType
		{
			get
			{
				return (EKuroISMCullingType)(*(base.NativePtr + (IntPtr)UInstancedStaticMeshComponent.__PropertyOffset_KuroCullingType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInstancedStaticMeshComponent.__PropertyOffset_KuroCullingType) = (byte)value;
			}
		}

		// Token: 0x1700265E RID: 9822
		// (get) Token: 0x0600A10E RID: 41230 RVA: 0x000E4DCE File Offset: 0x000E2FCE
		// (set) Token: 0x0600A10F RID: 41231 RVA: 0x000E4DE7 File Offset: 0x000E2FE7
		public unsafe bool bDisableKuroISMScreenSizePerInstanceLOD
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInstancedStaticMeshComponent.__PropertyOffset_bDisableKuroISMScreenSizePerInstanceLOD) & UInstancedStaticMeshComponent.__PropertyMask_bDisableKuroISMScreenSizePerInstanceLOD) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInstancedStaticMeshComponent.__PropertyOffset_bDisableKuroISMScreenSizePerInstanceLOD) = ((*(base.NativePtr + (IntPtr)UInstancedStaticMeshComponent.__PropertyOffset_bDisableKuroISMScreenSizePerInstanceLOD) & ~UInstancedStaticMeshComponent.__PropertyMask_bDisableKuroISMScreenSizePerInstanceLOD) | (value ? UInstancedStaticMeshComponent.__PropertyMask_bDisableKuroISMScreenSizePerInstanceLOD : 0));
			}
		}

		// Token: 0x1700265F RID: 9823
		// (get) Token: 0x0600A110 RID: 41232 RVA: 0x000E4E17 File Offset: 0x000E3017
		// (set) Token: 0x0600A111 RID: 41233 RVA: 0x000E4E30 File Offset: 0x000E3030
		public unsafe bool bDisableKuroISMOcclusionCulling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInstancedStaticMeshComponent.__PropertyOffset_bDisableKuroISMOcclusionCulling) & UInstancedStaticMeshComponent.__PropertyMask_bDisableKuroISMOcclusionCulling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInstancedStaticMeshComponent.__PropertyOffset_bDisableKuroISMOcclusionCulling) = ((*(base.NativePtr + (IntPtr)UInstancedStaticMeshComponent.__PropertyOffset_bDisableKuroISMOcclusionCulling) & ~UInstancedStaticMeshComponent.__PropertyMask_bDisableKuroISMOcclusionCulling) | (value ? UInstancedStaticMeshComponent.__PropertyMask_bDisableKuroISMOcclusionCulling : 0));
			}
		}

		// Token: 0x17002660 RID: 9824
		// (get) Token: 0x0600A112 RID: 41234 RVA: 0x000E4E60 File Offset: 0x000E3060
		// (set) Token: 0x0600A113 RID: 41235 RVA: 0x000E4E79 File Offset: 0x000E3079
		public unsafe bool bCastShadowInCinematicQuality
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInstancedStaticMeshComponent.__PropertyOffset_bCastShadowInCinematicQuality) & UInstancedStaticMeshComponent.__PropertyMask_bCastShadowInCinematicQuality) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInstancedStaticMeshComponent.__PropertyOffset_bCastShadowInCinematicQuality) = ((*(base.NativePtr + (IntPtr)UInstancedStaticMeshComponent.__PropertyOffset_bCastShadowInCinematicQuality) & ~UInstancedStaticMeshComponent.__PropertyMask_bCastShadowInCinematicQuality) | (value ? UInstancedStaticMeshComponent.__PropertyMask_bCastShadowInCinematicQuality : 0));
			}
		}

		// Token: 0x17002661 RID: 9825
		// (get) Token: 0x0600A114 RID: 41236 RVA: 0x000E4EA9 File Offset: 0x000E30A9
		// (set) Token: 0x0600A115 RID: 41237 RVA: 0x000E4EB9 File Offset: 0x000E30B9
		public unsafe int NumCustomDataFloats
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInstancedStaticMeshComponent.__PropertyOffset_NumCustomDataFloats);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInstancedStaticMeshComponent.__PropertyOffset_NumCustomDataFloats) = value;
			}
		}

		// Token: 0x17002662 RID: 9826
		// (get) Token: 0x0600A116 RID: 41238 RVA: 0x000E4ECC File Offset: 0x000E30CC
		// (set) Token: 0x0600A117 RID: 41239 RVA: 0x000E4F05 File Offset: 0x000E3105
		public TArray<float> PerInstanceSMCustomData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._PerInstanceSMCustomData) == null)
				{
					result = (this._PerInstanceSMCustomData = new TArray<float>(base.NativePtr + (IntPtr)UInstancedStaticMeshComponent.__PropertyOffset_PerInstanceSMCustomData, this));
				}
				return result;
			}
			set
			{
				this.PerInstanceSMCustomData.CopyAssign(value);
			}
		}

		// Token: 0x17002663 RID: 9827
		// (get) Token: 0x0600A118 RID: 41240 RVA: 0x000E4F13 File Offset: 0x000E3113
		// (set) Token: 0x0600A119 RID: 41241 RVA: 0x000E4F23 File Offset: 0x000E3123
		public unsafe int InstancingRandomSeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInstancedStaticMeshComponent.__PropertyOffset_InstancingRandomSeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInstancedStaticMeshComponent.__PropertyOffset_InstancingRandomSeed) = value;
			}
		}

		// Token: 0x17002664 RID: 9828
		// (get) Token: 0x0600A11A RID: 41242 RVA: 0x000E4F34 File Offset: 0x000E3134
		// (set) Token: 0x0600A11B RID: 41243 RVA: 0x000E4F44 File Offset: 0x000E3144
		public unsafe int InstanceStartCullDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInstancedStaticMeshComponent.__PropertyOffset_InstanceStartCullDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInstancedStaticMeshComponent.__PropertyOffset_InstanceStartCullDistance) = value;
			}
		}

		// Token: 0x17002665 RID: 9829
		// (get) Token: 0x0600A11C RID: 41244 RVA: 0x000E4F55 File Offset: 0x000E3155
		// (set) Token: 0x0600A11D RID: 41245 RVA: 0x000E4F65 File Offset: 0x000E3165
		public unsafe int InstanceEndCullDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInstancedStaticMeshComponent.__PropertyOffset_InstanceEndCullDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInstancedStaticMeshComponent.__PropertyOffset_InstanceEndCullDistance) = value;
			}
		}

		// Token: 0x17002666 RID: 9830
		// (get) Token: 0x0600A11E RID: 41246 RVA: 0x000E4F78 File Offset: 0x000E3178
		// (set) Token: 0x0600A11F RID: 41247 RVA: 0x000E4FB1 File Offset: 0x000E31B1
		public TArray<int> InstanceReorderTable
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._InstanceReorderTable) == null)
				{
					result = (this._InstanceReorderTable = new TArray<int>(base.NativePtr + (IntPtr)UInstancedStaticMeshComponent.__PropertyOffset_InstanceReorderTable, this));
				}
				return result;
			}
			set
			{
				this.InstanceReorderTable.CopyAssign(value);
			}
		}

		// Token: 0x17002667 RID: 9831
		// (get) Token: 0x0600A120 RID: 41248 RVA: 0x000E4FC0 File Offset: 0x000E31C0
		// (set) Token: 0x0600A121 RID: 41249 RVA: 0x000E4FF9 File Offset: 0x000E31F9
		public TArray<int> InstanceReorderTableLOD
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._InstanceReorderTableLOD) == null)
				{
					result = (this._InstanceReorderTableLOD = new TArray<int>(base.NativePtr + (IntPtr)UInstancedStaticMeshComponent.__PropertyOffset_InstanceReorderTableLOD, this));
				}
				return result;
			}
			set
			{
				this.InstanceReorderTableLOD.CopyAssign(value);
			}
		}

		// Token: 0x17002668 RID: 9832
		// (get) Token: 0x0600A122 RID: 41250 RVA: 0x000E5007 File Offset: 0x000E3207
		// (set) Token: 0x0600A123 RID: 41251 RVA: 0x000E5017 File Offset: 0x000E3217
		public unsafe int NumPendingLightmaps
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInstancedStaticMeshComponent.__PropertyOffset_NumPendingLightmaps);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInstancedStaticMeshComponent.__PropertyOffset_NumPendingLightmaps) = value;
			}
		}

		// Token: 0x17002669 RID: 9833
		// (get) Token: 0x0600A124 RID: 41252 RVA: 0x000E5028 File Offset: 0x000E3228
		// (set) Token: 0x0600A125 RID: 41253 RVA: 0x000E5061 File Offset: 0x000E3261
		public TArray<FInstancedStaticMeshMappingInfo> CachedMappings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FInstancedStaticMeshMappingInfo> result;
				if ((result = this._CachedMappings) == null)
				{
					result = (this._CachedMappings = new TArray<FInstancedStaticMeshMappingInfo>(base.NativePtr + (IntPtr)UInstancedStaticMeshComponent.__PropertyOffset_CachedMappings, this));
				}
				return result;
			}
			set
			{
				this.CachedMappings.CopyAssign(value);
			}
		}

		// Token: 0x0600A126 RID: 41254 RVA: 0x000E5070 File Offset: 0x000E3270
		public unsafe bool UpdateInstanceTransform(int InstanceIndex, in FTransform NewInstanceTransform, bool bWorldSpace = false, bool bMarkRenderStateDirty = false, bool bTeleport = false)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = NewInstanceTransform;
			return UInstancedStaticMeshComponent.__UpdateInstanceTransform_Internal(base.NativePtr, InstanceIndex, ptr, bWorldSpace, bMarkRenderStateDirty, bTeleport);
		}

		// Token: 0x0600A127 RID: 41255 RVA: 0x000E50AB File Offset: 0x000E32AB
		public void SetKuroCullType(EKuroISMCullingType InCullType)
		{
			UInstancedStaticMeshComponent.__SetKuroCullType_Internal(base.NativePtr, InCullType);
		}

		// Token: 0x0600A128 RID: 41256 RVA: 0x000E50B9 File Offset: 0x000E32B9
		public bool SetCustomDataValueCustomBufferOnly(int InstanceIndex, int CustomDataIndex, float CustomDataValue, bool bMarkRenderStateDirty = false)
		{
			return UInstancedStaticMeshComponent.__SetCustomDataValueCustomBufferOnly_Internal(base.NativePtr, InstanceIndex, CustomDataIndex, CustomDataValue, bMarkRenderStateDirty);
		}

		// Token: 0x0600A129 RID: 41257 RVA: 0x000E50CB File Offset: 0x000E32CB
		public bool SetCustomDataValue(int InstanceIndex, int CustomDataIndex, float CustomDataValue, bool bMarkRenderStateDirty = false)
		{
			return UInstancedStaticMeshComponent.__SetCustomDataValue_Internal(base.NativePtr, InstanceIndex, CustomDataIndex, CustomDataValue, bMarkRenderStateDirty);
		}

		// Token: 0x0600A12A RID: 41258 RVA: 0x000E50DD File Offset: 0x000E32DD
		public void SetCullDistances(int StartCullDistance, int EndCullDistance)
		{
			UInstancedStaticMeshComponent.__SetCullDistances_Internal(base.NativePtr, StartCullDistance, EndCullDistance);
		}

		// Token: 0x0600A12B RID: 41259 RVA: 0x000E50EC File Offset: 0x000E32EC
		public bool RemoveInstance(int InstanceIndex)
		{
			return UInstancedStaticMeshComponent.__RemoveInstance_Internal(base.NativePtr, InstanceIndex);
		}

		// Token: 0x0600A12C RID: 41260 RVA: 0x000E50FA File Offset: 0x000E32FA
		public int GetISMNumCustomDataFloats()
		{
			return UInstancedStaticMeshComponent.__GetISMNumCustomDataFloats_Internal(base.NativePtr);
		}

		// Token: 0x0600A12D RID: 41261 RVA: 0x000E5108 File Offset: 0x000E3308
		public unsafe bool GetInstanceTransform(int InstanceIndex, ref FTransform OutInstanceTransform, bool bWorldSpace = false)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = OutInstanceTransform;
			bool result = UInstancedStaticMeshComponent.__GetInstanceTransform_Internal(base.NativePtr, InstanceIndex, ref ptr, bWorldSpace);
			OutInstanceTransform = ptr;
			return result;
		}

		// Token: 0x0600A12E RID: 41262 RVA: 0x000E514B File Offset: 0x000E334B
		public TArray<int> GetInstancesOverlappingSphere(in FVector Center, float Radius, bool bSphereInWorldSpace = true)
		{
			return new TArray<int>(UInstancedStaticMeshComponent.__GetInstancesOverlappingSphere_Internal(base.NativePtr, Center, Radius, bSphereInWorldSpace), null);
		}

		// Token: 0x0600A12F RID: 41263 RVA: 0x000E5161 File Offset: 0x000E3361
		public TArray<int> GetInstancesOverlappingBox(in FBox Box, bool bBoxInWorldSpace = true)
		{
			return new TArray<int>(UInstancedStaticMeshComponent.__GetInstancesOverlappingBox_Internal(base.NativePtr, Box, bBoxInWorldSpace), null);
		}

		// Token: 0x0600A130 RID: 41264 RVA: 0x000E5176 File Offset: 0x000E3376
		public float GetInstancePerInstanceSMCustomData(int DataIndex)
		{
			return UInstancedStaticMeshComponent.__GetInstancePerInstanceSMCustomData_Internal(base.NativePtr, DataIndex);
		}

		// Token: 0x0600A131 RID: 41265 RVA: 0x000E5184 File Offset: 0x000E3384
		public int GetInstanceCount()
		{
			return UInstancedStaticMeshComponent.__GetInstanceCount_Internal(base.NativePtr);
		}

		// Token: 0x0600A132 RID: 41266 RVA: 0x000E5191 File Offset: 0x000E3391
		public void FillRandomValue(float InBaseRandomValue, float InRandomValue, bool bMarkRenderStateDirty = true)
		{
			UInstancedStaticMeshComponent.__FillRandomValue_Internal(base.NativePtr, InBaseRandomValue, InRandomValue, bMarkRenderStateDirty);
		}

		// Token: 0x0600A133 RID: 41267 RVA: 0x000E51A1 File Offset: 0x000E33A1
		public void ClearInstances()
		{
			UInstancedStaticMeshComponent.__ClearInstances_Internal(base.NativePtr);
		}

		// Token: 0x0600A134 RID: 41268 RVA: 0x000E51AE File Offset: 0x000E33AE
		[NullableContext(2)]
		public bool BatchUpdateInstancesTransforms(int StartInstanceIndex, in TArray<FTransform> NewInstancesTransforms, bool bWorldSpace = false, bool bMarkRenderStateDirty = false, bool bTeleport = false)
		{
			return UInstancedStaticMeshComponent.__BatchUpdateInstancesTransforms_Internal(base.NativePtr, StartInstanceIndex, (NewInstancesTransforms ?? new TArray<FTransform>()).NativePtr, bWorldSpace, bMarkRenderStateDirty, bTeleport);
		}

		// Token: 0x0600A135 RID: 41269 RVA: 0x000E51D4 File Offset: 0x000E33D4
		public unsafe bool BatchUpdateInstancesTransform(int StartInstanceIndex, int NumInstances, in FTransform NewInstancesTransform, bool bWorldSpace = false, bool bMarkRenderStateDirty = false, bool bTeleport = false)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = NewInstancesTransform;
			return UInstancedStaticMeshComponent.__BatchUpdateInstancesTransform_Internal(base.NativePtr, StartInstanceIndex, NumInstances, ptr, bWorldSpace, bMarkRenderStateDirty, bTeleport);
		}

		// Token: 0x0600A136 RID: 41270 RVA: 0x000E5211 File Offset: 0x000E3411
		public void AddZeroToPerInstanceSMCustomData(int CustomDataNum, int Count)
		{
			UInstancedStaticMeshComponent.__AddZeroToPerInstanceSMCustomData_Internal(base.NativePtr, CustomDataNum, Count);
		}

		// Token: 0x0600A137 RID: 41271 RVA: 0x000E5220 File Offset: 0x000E3420
		public unsafe int AddInstanceWorldSpace(in FTransform WorldTransform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = WorldTransform;
			return UInstancedStaticMeshComponent.__AddInstanceWorldSpace_Internal(base.NativePtr, ptr);
		}

		// Token: 0x0600A138 RID: 41272 RVA: 0x000E5255 File Offset: 0x000E3455
		public TArray<int> AddInstances([Nullable(2)] in TArray<FTransform> InstanceTransforms, bool bShouldReturnIndices, bool bWorldSpace = false)
		{
			return new TArray<int>(UInstancedStaticMeshComponent.__AddInstances_Internal(base.NativePtr, (InstanceTransforms ?? new TArray<FTransform>()).NativePtr, bShouldReturnIndices, bWorldSpace), null);
		}

		// Token: 0x0600A139 RID: 41273 RVA: 0x000E527C File Offset: 0x000E347C
		public unsafe int AddInstance(in FTransform InstanceTransform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = InstanceTransform;
			return UInstancedStaticMeshComponent.__AddInstance_Internal(base.NativePtr, ptr);
		}

		// Token: 0x0600A13A RID: 41274
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __UpdateInstanceTransform_Internal(IntPtr @this, int InstanceIndex, in FTransform NewInstanceTransform, bool bWorldSpace, bool bMarkRenderStateDirty, bool bTeleport);

		// Token: 0x0600A13B RID: 41275
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroCullType_Internal(IntPtr @this, EKuroISMCullingType InCullType);

		// Token: 0x0600A13C RID: 41276
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetCustomDataValueCustomBufferOnly_Internal(IntPtr @this, int InstanceIndex, int CustomDataIndex, float CustomDataValue, bool bMarkRenderStateDirty);

		// Token: 0x0600A13D RID: 41277
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetCustomDataValue_Internal(IntPtr @this, int InstanceIndex, int CustomDataIndex, float CustomDataValue, bool bMarkRenderStateDirty);

		// Token: 0x0600A13E RID: 41278
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCullDistances_Internal(IntPtr @this, int StartCullDistance, int EndCullDistance);

		// Token: 0x0600A13F RID: 41279
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveInstance_Internal(IntPtr @this, int InstanceIndex);

		// Token: 0x0600A140 RID: 41280
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetISMNumCustomDataFloats_Internal(IntPtr @this);

		// Token: 0x0600A141 RID: 41281
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetInstanceTransform_Internal(IntPtr @this, int InstanceIndex, ref FTransform OutInstanceTransform, bool bWorldSpace);

		// Token: 0x0600A142 RID: 41282
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetInstancesOverlappingSphere_Internal(IntPtr @this, in FVector Center, float Radius, bool bSphereInWorldSpace);

		// Token: 0x0600A143 RID: 41283
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetInstancesOverlappingBox_Internal(IntPtr @this, in FBox Box, bool bBoxInWorldSpace);

		// Token: 0x0600A144 RID: 41284
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetInstancePerInstanceSMCustomData_Internal(IntPtr @this, int DataIndex);

		// Token: 0x0600A145 RID: 41285
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetInstanceCount_Internal(IntPtr @this);

		// Token: 0x0600A146 RID: 41286
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FillRandomValue_Internal(IntPtr @this, float InBaseRandomValue, float InRandomValue, bool bMarkRenderStateDirty);

		// Token: 0x0600A147 RID: 41287
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearInstances_Internal(IntPtr @this);

		// Token: 0x0600A148 RID: 41288
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BatchUpdateInstancesTransforms_Internal(IntPtr @this, int StartInstanceIndex, IntPtr NewInstancesTransforms, bool bWorldSpace, bool bMarkRenderStateDirty, bool bTeleport);

		// Token: 0x0600A149 RID: 41289
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BatchUpdateInstancesTransform_Internal(IntPtr @this, int StartInstanceIndex, int NumInstances, in FTransform NewInstancesTransform, bool bWorldSpace, bool bMarkRenderStateDirty, bool bTeleport);

		// Token: 0x0600A14A RID: 41290
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddZeroToPerInstanceSMCustomData_Internal(IntPtr @this, int CustomDataNum, int Count);

		// Token: 0x0600A14B RID: 41291
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __AddInstanceWorldSpace_Internal(IntPtr @this, in FTransform WorldTransform);

		// Token: 0x0600A14C RID: 41292
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddInstances_Internal(IntPtr @this, IntPtr InstanceTransforms, bool bShouldReturnIndices, bool bWorldSpace);

		// Token: 0x0600A14D RID: 41293
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __AddInstance_Internal(IntPtr @this, in FTransform InstanceTransform);

		// Token: 0x0600A14E RID: 41294 RVA: 0x000E52B1 File Offset: 0x000E34B1
		static UInstancedStaticMeshComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InstancedStaticMeshComponent");
		}

		// Token: 0x0600A14F RID: 41295 RVA: 0x000E52BF File Offset: 0x000E34BF
		protected UInstancedStaticMeshComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005883 RID: 22659
		public new const string __ObjectPath = "/Script/Engine.InstancedStaticMeshComponent";

		// Token: 0x04005884 RID: 22660
		private static IntPtr _ClassPtr;

		// Token: 0x04005885 RID: 22661
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005886 RID: 22662
		internal static int __PropertyOffset_PerInstanceSMData;

		// Token: 0x04005887 RID: 22663
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FInstancedStaticMeshInstanceData> _PerInstanceSMData;

		// Token: 0x04005888 RID: 22664
		internal static int __PropertyOffset_bUseCustomRandomValue;

		// Token: 0x04005889 RID: 22665
		internal static byte __PropertyMask_bUseCustomRandomValue;

		// Token: 0x0400588A RID: 22666
		internal static int __PropertyOffset_BaseRandomValue;

		// Token: 0x0400588B RID: 22667
		internal static int __PropertyOffset_KuroCullingType;

		// Token: 0x0400588C RID: 22668
		internal static int __PropertyOffset_bDisableKuroISMScreenSizePerInstanceLOD;

		// Token: 0x0400588D RID: 22669
		internal static byte __PropertyMask_bDisableKuroISMScreenSizePerInstanceLOD;

		// Token: 0x0400588E RID: 22670
		internal static int __PropertyOffset_bDisableKuroISMOcclusionCulling;

		// Token: 0x0400588F RID: 22671
		internal static byte __PropertyMask_bDisableKuroISMOcclusionCulling;

		// Token: 0x04005890 RID: 22672
		internal static int __PropertyOffset_bCastShadowInCinematicQuality;

		// Token: 0x04005891 RID: 22673
		internal static byte __PropertyMask_bCastShadowInCinematicQuality;

		// Token: 0x04005892 RID: 22674
		internal static int __PropertyOffset_NumCustomDataFloats;

		// Token: 0x04005893 RID: 22675
		internal static int __PropertyOffset_PerInstanceSMCustomData;

		// Token: 0x04005894 RID: 22676
		[Nullable(2)]
		private TArray<float> _PerInstanceSMCustomData;

		// Token: 0x04005895 RID: 22677
		internal static int __PropertyOffset_InstancingRandomSeed;

		// Token: 0x04005896 RID: 22678
		internal static int __PropertyOffset_InstanceStartCullDistance;

		// Token: 0x04005897 RID: 22679
		internal static int __PropertyOffset_InstanceEndCullDistance;

		// Token: 0x04005898 RID: 22680
		internal static int __PropertyOffset_InstanceReorderTable;

		// Token: 0x04005899 RID: 22681
		[Nullable(2)]
		private TArray<int> _InstanceReorderTable;

		// Token: 0x0400589A RID: 22682
		internal static int __PropertyOffset_InstanceReorderTableLOD;

		// Token: 0x0400589B RID: 22683
		[Nullable(2)]
		private TArray<int> _InstanceReorderTableLOD;

		// Token: 0x0400589C RID: 22684
		internal static int __PropertyOffset_NumPendingLightmaps;

		// Token: 0x0400589D RID: 22685
		internal static int __PropertyOffset_CachedMappings;

		// Token: 0x0400589E RID: 22686
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FInstancedStaticMeshMappingInfo> _CachedMappings;
	}
}
