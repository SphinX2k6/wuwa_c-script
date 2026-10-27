using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020027E5 RID: 10213
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.VisibilitySettings")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FVisibilitySettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026131 RID: 155953 RVA: 0x0039BFB0 File Offset: 0x0039A1B0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVisibilitySettings._ScriptStructPtr != 0) ? FVisibilitySettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SimplygonUObjects.VisibilitySettings", ref FVisibilitySettings._ScriptStructPtr);
		}

		// Token: 0x170092EF RID: 37615
		// (get) Token: 0x06026132 RID: 155954 RVA: 0x0039BFD4 File Offset: 0x0039A1D4
		// (set) Token: 0x06026133 RID: 155955 RVA: 0x0039BFE4 File Offset: 0x0039A1E4
		public unsafe EVisibilityCameraMode VisibilityCameraMode
		{
			get
			{
				return (EVisibilityCameraMode)(*(base.NativePtr + (IntPtr)FVisibilitySettings.__PropertyOffset_VisibilityCameraMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVisibilitySettings.__PropertyOffset_VisibilityCameraMode) = (byte)value;
			}
		}

		// Token: 0x170092F0 RID: 37616
		// (get) Token: 0x06026134 RID: 155956 RVA: 0x0039BFF5 File Offset: 0x0039A1F5
		// (set) Token: 0x06026135 RID: 155957 RVA: 0x0039C005 File Offset: 0x0039A205
		public unsafe EHemisphereUpVector HemisphereUpVector
		{
			get
			{
				return (EHemisphereUpVector)(*(base.NativePtr + (IntPtr)FVisibilitySettings.__PropertyOffset_HemisphereUpVector));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVisibilitySettings.__PropertyOffset_HemisphereUpVector) = (byte)value;
			}
		}

		// Token: 0x170092F1 RID: 37617
		// (get) Token: 0x06026136 RID: 155958 RVA: 0x0039C016 File Offset: 0x0039A216
		// (set) Token: 0x06026137 RID: 155959 RVA: 0x0039C026 File Offset: 0x0039A226
		public unsafe float HemisphereCoverageAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVisibilitySettings.__PropertyOffset_HemisphereCoverageAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVisibilitySettings.__PropertyOffset_HemisphereCoverageAngle) = value;
			}
		}

		// Token: 0x170092F2 RID: 37618
		// (get) Token: 0x06026138 RID: 155960 RVA: 0x0039C037 File Offset: 0x0039A237
		// (set) Token: 0x06026139 RID: 155961 RVA: 0x0039C047 File Offset: 0x0039A247
		public unsafe int HemisphereFidelity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVisibilitySettings.__PropertyOffset_HemisphereFidelity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVisibilitySettings.__PropertyOffset_HemisphereFidelity) = value;
			}
		}

		// Token: 0x170092F3 RID: 37619
		// (get) Token: 0x0602613A RID: 155962 RVA: 0x0039C058 File Offset: 0x0039A258
		// (set) Token: 0x0602613B RID: 155963 RVA: 0x0039C068 File Offset: 0x0039A268
		public unsafe int SphereFidelity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVisibilitySettings.__PropertyOffset_SphereFidelity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVisibilitySettings.__PropertyOffset_SphereFidelity) = value;
			}
		}

		// Token: 0x170092F4 RID: 37620
		// (get) Token: 0x0602613C RID: 155964 RVA: 0x0039C079 File Offset: 0x0039A279
		// (set) Token: 0x0602613D RID: 155965 RVA: 0x0039C089 File Offset: 0x0039A289
		public unsafe int CameraSelectionSetID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVisibilitySettings.__PropertyOffset_CameraSelectionSetID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVisibilitySettings.__PropertyOffset_CameraSelectionSetID) = value;
			}
		}

		// Token: 0x170092F5 RID: 37621
		// (get) Token: 0x0602613E RID: 155966 RVA: 0x0039C09A File Offset: 0x0039A29A
		// (set) Token: 0x0602613F RID: 155967 RVA: 0x0039C0AE File Offset: 0x0039A2AE
		public unsafe string CameraSelectionSetName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FVisibilitySettings.__PropertyOffset_CameraSelectionSetName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FVisibilitySettings.__PropertyOffset_CameraSelectionSetName)), value);
			}
		}

		// Token: 0x170092F6 RID: 37622
		// (get) Token: 0x06026140 RID: 155968 RVA: 0x0039C0C3 File Offset: 0x0039A2C3
		// (set) Token: 0x06026141 RID: 155969 RVA: 0x0039C0D3 File Offset: 0x0039A2D3
		public unsafe int OccluderSelectionSetID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVisibilitySettings.__PropertyOffset_OccluderSelectionSetID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVisibilitySettings.__PropertyOffset_OccluderSelectionSetID) = value;
			}
		}

		// Token: 0x170092F7 RID: 37623
		// (get) Token: 0x06026142 RID: 155970 RVA: 0x0039C0E4 File Offset: 0x0039A2E4
		// (set) Token: 0x06026143 RID: 155971 RVA: 0x0039C0F8 File Offset: 0x0039A2F8
		public unsafe string OccluderSelectionSetName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FVisibilitySettings.__PropertyOffset_OccluderSelectionSetName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FVisibilitySettings.__PropertyOffset_OccluderSelectionSetName)), value);
			}
		}

		// Token: 0x170092F8 RID: 37624
		// (get) Token: 0x06026144 RID: 155972 RVA: 0x0039C10D File Offset: 0x0039A30D
		// (set) Token: 0x06026145 RID: 155973 RVA: 0x0039C126 File Offset: 0x0039A326
		public unsafe bool RemoveTrianglesNotOccludingOtherTriangles
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FVisibilitySettings.__PropertyOffset_RemoveTrianglesNotOccludingOtherTriangles) & FVisibilitySettings.__PropertyMask_RemoveTrianglesNotOccludingOtherTriangles) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FVisibilitySettings.__PropertyOffset_RemoveTrianglesNotOccludingOtherTriangles) = ((*(base.NativePtr + (IntPtr)FVisibilitySettings.__PropertyOffset_RemoveTrianglesNotOccludingOtherTriangles) & ~FVisibilitySettings.__PropertyMask_RemoveTrianglesNotOccludingOtherTriangles) | (value ? FVisibilitySettings.__PropertyMask_RemoveTrianglesNotOccludingOtherTriangles : 0));
			}
		}

		// Token: 0x170092F9 RID: 37625
		// (get) Token: 0x06026146 RID: 155974 RVA: 0x0039C156 File Offset: 0x0039A356
		// (set) Token: 0x06026147 RID: 155975 RVA: 0x0039C166 File Offset: 0x0039A366
		public unsafe float FillNonVisibleAreaThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVisibilitySettings.__PropertyOffset_FillNonVisibleAreaThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVisibilitySettings.__PropertyOffset_FillNonVisibleAreaThreshold) = value;
			}
		}

		// Token: 0x170092FA RID: 37626
		// (get) Token: 0x06026148 RID: 155976 RVA: 0x0039C177 File Offset: 0x0039A377
		// (set) Token: 0x06026149 RID: 155977 RVA: 0x0039C190 File Offset: 0x0039A390
		public unsafe bool ForceVisibilityCalculation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FVisibilitySettings.__PropertyOffset_ForceVisibilityCalculation) & FVisibilitySettings.__PropertyMask_ForceVisibilityCalculation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FVisibilitySettings.__PropertyOffset_ForceVisibilityCalculation) = ((*(base.NativePtr + (IntPtr)FVisibilitySettings.__PropertyOffset_ForceVisibilityCalculation) & ~FVisibilitySettings.__PropertyMask_ForceVisibilityCalculation) | (value ? FVisibilitySettings.__PropertyMask_ForceVisibilityCalculation : 0));
			}
		}

		// Token: 0x170092FB RID: 37627
		// (get) Token: 0x0602614A RID: 155978 RVA: 0x0039C1C0 File Offset: 0x0039A3C0
		// (set) Token: 0x0602614B RID: 155979 RVA: 0x0039C1D9 File Offset: 0x0039A3D9
		public unsafe bool ConservativeMode
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FVisibilitySettings.__PropertyOffset_ConservativeMode) & FVisibilitySettings.__PropertyMask_ConservativeMode) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FVisibilitySettings.__PropertyOffset_ConservativeMode) = ((*(base.NativePtr + (IntPtr)FVisibilitySettings.__PropertyOffset_ConservativeMode) & ~FVisibilitySettings.__PropertyMask_ConservativeMode) | (value ? FVisibilitySettings.__PropertyMask_ConservativeMode : 0));
			}
		}

		// Token: 0x170092FC RID: 37628
		// (get) Token: 0x0602614C RID: 155980 RVA: 0x0039C209 File Offset: 0x0039A409
		// (set) Token: 0x0602614D RID: 155981 RVA: 0x0039C222 File Offset: 0x0039A422
		public unsafe bool CullOccludedGeometry
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FVisibilitySettings.__PropertyOffset_CullOccludedGeometry) & FVisibilitySettings.__PropertyMask_CullOccludedGeometry) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FVisibilitySettings.__PropertyOffset_CullOccludedGeometry) = ((*(base.NativePtr + (IntPtr)FVisibilitySettings.__PropertyOffset_CullOccludedGeometry) & ~FVisibilitySettings.__PropertyMask_CullOccludedGeometry) | (value ? FVisibilitySettings.__PropertyMask_CullOccludedGeometry : 0));
			}
		}

		// Token: 0x170092FD RID: 37629
		// (get) Token: 0x0602614E RID: 155982 RVA: 0x0039C252 File Offset: 0x0039A452
		// (set) Token: 0x0602614F RID: 155983 RVA: 0x0039C262 File Offset: 0x0039A462
		public unsafe float VisibilityWeightsPower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVisibilitySettings.__PropertyOffset_VisibilityWeightsPower);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVisibilitySettings.__PropertyOffset_VisibilityWeightsPower) = value;
			}
		}

		// Token: 0x170092FE RID: 37630
		// (get) Token: 0x06026150 RID: 155984 RVA: 0x0039C273 File Offset: 0x0039A473
		// (set) Token: 0x06026151 RID: 155985 RVA: 0x0039C28C File Offset: 0x0039A48C
		public unsafe bool UseVisibilityWeightsInTexcoordGenerator
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FVisibilitySettings.__PropertyOffset_UseVisibilityWeightsInTexcoordGenerator) & FVisibilitySettings.__PropertyMask_UseVisibilityWeightsInTexcoordGenerator) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FVisibilitySettings.__PropertyOffset_UseVisibilityWeightsInTexcoordGenerator) = ((*(base.NativePtr + (IntPtr)FVisibilitySettings.__PropertyOffset_UseVisibilityWeightsInTexcoordGenerator) & ~FVisibilitySettings.__PropertyMask_UseVisibilityWeightsInTexcoordGenerator) | (value ? FVisibilitySettings.__PropertyMask_UseVisibilityWeightsInTexcoordGenerator : 0));
			}
		}

		// Token: 0x170092FF RID: 37631
		// (get) Token: 0x06026152 RID: 155986 RVA: 0x0039C2BC File Offset: 0x0039A4BC
		// (set) Token: 0x06026153 RID: 155987 RVA: 0x0039C2D5 File Offset: 0x0039A4D5
		public unsafe bool UseVisibilityWeightsInReducer
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FVisibilitySettings.__PropertyOffset_UseVisibilityWeightsInReducer) & FVisibilitySettings.__PropertyMask_UseVisibilityWeightsInReducer) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FVisibilitySettings.__PropertyOffset_UseVisibilityWeightsInReducer) = ((*(base.NativePtr + (IntPtr)FVisibilitySettings.__PropertyOffset_UseVisibilityWeightsInReducer) & ~FVisibilitySettings.__PropertyMask_UseVisibilityWeightsInReducer) | (value ? FVisibilitySettings.__PropertyMask_UseVisibilityWeightsInReducer : 0));
			}
		}

		// Token: 0x17009300 RID: 37632
		// (get) Token: 0x06026154 RID: 155988 RVA: 0x0039C305 File Offset: 0x0039A505
		// (set) Token: 0x06026155 RID: 155989 RVA: 0x0039C31E File Offset: 0x0039A51E
		public unsafe bool UseBackfaceCulling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FVisibilitySettings.__PropertyOffset_UseBackfaceCulling) & FVisibilitySettings.__PropertyMask_UseBackfaceCulling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FVisibilitySettings.__PropertyOffset_UseBackfaceCulling) = ((*(base.NativePtr + (IntPtr)FVisibilitySettings.__PropertyOffset_UseBackfaceCulling) & ~FVisibilitySettings.__PropertyMask_UseBackfaceCulling) | (value ? FVisibilitySettings.__PropertyMask_UseBackfaceCulling : 0));
			}
		}

		// Token: 0x17009301 RID: 37633
		// (get) Token: 0x06026156 RID: 155990 RVA: 0x0039C34E File Offset: 0x0039A54E
		// (set) Token: 0x06026157 RID: 155991 RVA: 0x0039C35E File Offset: 0x0039A55E
		public unsafe EComputeVisibilityMode ComputeVisibilityMode
		{
			get
			{
				return (EComputeVisibilityMode)(*(base.NativePtr + (IntPtr)FVisibilitySettings.__PropertyOffset_ComputeVisibilityMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVisibilitySettings.__PropertyOffset_ComputeVisibilityMode) = (byte)value;
			}
		}

		// Token: 0x06026158 RID: 155992 RVA: 0x0039C36F File Offset: 0x0039A56F
		public FVisibilitySettings()
		{
		}

		// Token: 0x06026159 RID: 155993 RVA: 0x0039C378 File Offset: 0x0039A578
		public FVisibilitySettings(EVisibilityCameraMode VisibilityCameraMode, EHemisphereUpVector HemisphereUpVector, float HemisphereCoverageAngle, int HemisphereFidelity, int SphereFidelity, int CameraSelectionSetID, string CameraSelectionSetName, int OccluderSelectionSetID, string OccluderSelectionSetName, bool RemoveTrianglesNotOccludingOtherTriangles, float FillNonVisibleAreaThreshold, bool ForceVisibilityCalculation, bool ConservativeMode, bool CullOccludedGeometry, float VisibilityWeightsPower, bool UseVisibilityWeightsInTexcoordGenerator, bool UseVisibilityWeightsInReducer, bool UseBackfaceCulling, EComputeVisibilityMode ComputeVisibilityMode)
		{
			this.VisibilityCameraMode = VisibilityCameraMode;
			this.HemisphereUpVector = HemisphereUpVector;
			this.HemisphereCoverageAngle = HemisphereCoverageAngle;
			this.HemisphereFidelity = HemisphereFidelity;
			this.SphereFidelity = SphereFidelity;
			this.CameraSelectionSetID = CameraSelectionSetID;
			this.CameraSelectionSetName = CameraSelectionSetName;
			this.OccluderSelectionSetID = OccluderSelectionSetID;
			this.OccluderSelectionSetName = OccluderSelectionSetName;
			this.RemoveTrianglesNotOccludingOtherTriangles = RemoveTrianglesNotOccludingOtherTriangles;
			this.FillNonVisibleAreaThreshold = FillNonVisibleAreaThreshold;
			this.ForceVisibilityCalculation = ForceVisibilityCalculation;
			this.ConservativeMode = ConservativeMode;
			this.CullOccludedGeometry = CullOccludedGeometry;
			this.VisibilityWeightsPower = VisibilityWeightsPower;
			this.UseVisibilityWeightsInTexcoordGenerator = UseVisibilityWeightsInTexcoordGenerator;
			this.UseVisibilityWeightsInReducer = UseVisibilityWeightsInReducer;
			this.UseBackfaceCulling = UseBackfaceCulling;
			this.ComputeVisibilityMode = ComputeVisibilityMode;
		}

		// Token: 0x0602615A RID: 155994 RVA: 0x0039C420 File Offset: 0x0039A620
		protected override IntPtr GetUStructPtr()
		{
			return FVisibilitySettings.StaticStruct();
		}

		// Token: 0x0602615B RID: 155995 RVA: 0x0039C42C File Offset: 0x0039A62C
		[NullableContext(2)]
		public FVisibilitySettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602615C RID: 155996 RVA: 0x0039C436 File Offset: 0x0039A636
		public FVisibilitySettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602615D RID: 155997 RVA: 0x0039C441 File Offset: 0x0039A641
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FVisibilitySettings(Pointer, false, true);
		}

		// Token: 0x0602615E RID: 155998 RVA: 0x0039C44B File Offset: 0x0039A64B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FVisibilitySettings(Pointer, MemoryOwner);
		}

		// Token: 0x04014CA7 RID: 85159
		public const string __ObjectPath = "/Script/SimplygonUObjects.VisibilitySettings";

		// Token: 0x04014CA8 RID: 85160
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014CA9 RID: 85161
		internal static int __PropertyOffset_VisibilityCameraMode;

		// Token: 0x04014CAA RID: 85162
		internal static int __PropertyOffset_HemisphereUpVector;

		// Token: 0x04014CAB RID: 85163
		internal static int __PropertyOffset_HemisphereCoverageAngle;

		// Token: 0x04014CAC RID: 85164
		internal static int __PropertyOffset_HemisphereFidelity;

		// Token: 0x04014CAD RID: 85165
		internal static int __PropertyOffset_SphereFidelity;

		// Token: 0x04014CAE RID: 85166
		internal static int __PropertyOffset_CameraSelectionSetID;

		// Token: 0x04014CAF RID: 85167
		internal static int __PropertyOffset_CameraSelectionSetName;

		// Token: 0x04014CB0 RID: 85168
		internal static int __PropertyOffset_OccluderSelectionSetID;

		// Token: 0x04014CB1 RID: 85169
		internal static int __PropertyOffset_OccluderSelectionSetName;

		// Token: 0x04014CB2 RID: 85170
		internal static int __PropertyOffset_RemoveTrianglesNotOccludingOtherTriangles;

		// Token: 0x04014CB3 RID: 85171
		internal static byte __PropertyMask_RemoveTrianglesNotOccludingOtherTriangles;

		// Token: 0x04014CB4 RID: 85172
		internal static int __PropertyOffset_FillNonVisibleAreaThreshold;

		// Token: 0x04014CB5 RID: 85173
		internal static int __PropertyOffset_ForceVisibilityCalculation;

		// Token: 0x04014CB6 RID: 85174
		internal static byte __PropertyMask_ForceVisibilityCalculation;

		// Token: 0x04014CB7 RID: 85175
		internal static int __PropertyOffset_ConservativeMode;

		// Token: 0x04014CB8 RID: 85176
		internal static byte __PropertyMask_ConservativeMode;

		// Token: 0x04014CB9 RID: 85177
		internal static int __PropertyOffset_CullOccludedGeometry;

		// Token: 0x04014CBA RID: 85178
		internal static byte __PropertyMask_CullOccludedGeometry;

		// Token: 0x04014CBB RID: 85179
		internal static int __PropertyOffset_VisibilityWeightsPower;

		// Token: 0x04014CBC RID: 85180
		internal static int __PropertyOffset_UseVisibilityWeightsInTexcoordGenerator;

		// Token: 0x04014CBD RID: 85181
		internal static byte __PropertyMask_UseVisibilityWeightsInTexcoordGenerator;

		// Token: 0x04014CBE RID: 85182
		internal static int __PropertyOffset_UseVisibilityWeightsInReducer;

		// Token: 0x04014CBF RID: 85183
		internal static byte __PropertyMask_UseVisibilityWeightsInReducer;

		// Token: 0x04014CC0 RID: 85184
		internal static int __PropertyOffset_UseBackfaceCulling;

		// Token: 0x04014CC1 RID: 85185
		internal static byte __PropertyMask_UseBackfaceCulling;

		// Token: 0x04014CC2 RID: 85186
		internal static int __PropertyOffset_ComputeVisibilityMode;
	}
}
