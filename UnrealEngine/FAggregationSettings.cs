using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002776 RID: 10102
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.AggregationSettings")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FAggregationSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025C29 RID: 154665 RVA: 0x00393E58 File Offset: 0x00392058
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAggregationSettings._ScriptStructPtr != 0) ? FAggregationSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SimplygonUObjects.AggregationSettings", ref FAggregationSettings._ScriptStructPtr);
		}

		// Token: 0x1700915D RID: 37213
		// (get) Token: 0x06025C2A RID: 154666 RVA: 0x00393E7C File Offset: 0x0039207C
		// (set) Token: 0x06025C2B RID: 154667 RVA: 0x00393E95 File Offset: 0x00392095
		public unsafe bool MergeGeometries
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAggregationSettings.__PropertyOffset_MergeGeometries) & FAggregationSettings.__PropertyMask_MergeGeometries) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAggregationSettings.__PropertyOffset_MergeGeometries) = ((*(base.NativePtr + (IntPtr)FAggregationSettings.__PropertyOffset_MergeGeometries) & ~FAggregationSettings.__PropertyMask_MergeGeometries) | (value ? FAggregationSettings.__PropertyMask_MergeGeometries : 0));
			}
		}

		// Token: 0x1700915E RID: 37214
		// (get) Token: 0x06025C2C RID: 154668 RVA: 0x00393EC5 File Offset: 0x003920C5
		// (set) Token: 0x06025C2D RID: 154669 RVA: 0x00393EDE File Offset: 0x003920DE
		public unsafe bool EnableGeometryCulling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAggregationSettings.__PropertyOffset_EnableGeometryCulling) & FAggregationSettings.__PropertyMask_EnableGeometryCulling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAggregationSettings.__PropertyOffset_EnableGeometryCulling) = ((*(base.NativePtr + (IntPtr)FAggregationSettings.__PropertyOffset_EnableGeometryCulling) & ~FAggregationSettings.__PropertyMask_EnableGeometryCulling) | (value ? FAggregationSettings.__PropertyMask_EnableGeometryCulling : 0));
			}
		}

		// Token: 0x1700915F RID: 37215
		// (get) Token: 0x06025C2E RID: 154670 RVA: 0x00393F0E File Offset: 0x0039210E
		// (set) Token: 0x06025C2F RID: 154671 RVA: 0x00393F1E File Offset: 0x0039211E
		public unsafe float GeometryCullingPrecision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAggregationSettings.__PropertyOffset_GeometryCullingPrecision);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAggregationSettings.__PropertyOffset_GeometryCullingPrecision) = value;
			}
		}

		// Token: 0x17009160 RID: 37216
		// (get) Token: 0x06025C30 RID: 154672 RVA: 0x00393F2F File Offset: 0x0039212F
		// (set) Token: 0x06025C31 RID: 154673 RVA: 0x00393F48 File Offset: 0x00392148
		public unsafe bool SubdivideGeometryBasedOnUVTiles
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAggregationSettings.__PropertyOffset_SubdivideGeometryBasedOnUVTiles) & FAggregationSettings.__PropertyMask_SubdivideGeometryBasedOnUVTiles) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAggregationSettings.__PropertyOffset_SubdivideGeometryBasedOnUVTiles) = ((*(base.NativePtr + (IntPtr)FAggregationSettings.__PropertyOffset_SubdivideGeometryBasedOnUVTiles) & ~FAggregationSettings.__PropertyMask_SubdivideGeometryBasedOnUVTiles) | (value ? FAggregationSettings.__PropertyMask_SubdivideGeometryBasedOnUVTiles : 0));
			}
		}

		// Token: 0x17009161 RID: 37217
		// (get) Token: 0x06025C32 RID: 154674 RVA: 0x00393F78 File Offset: 0x00392178
		// (set) Token: 0x06025C33 RID: 154675 RVA: 0x00393F88 File Offset: 0x00392188
		public unsafe int SubdivisionTileSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAggregationSettings.__PropertyOffset_SubdivisionTileSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAggregationSettings.__PropertyOffset_SubdivisionTileSize) = value;
			}
		}

		// Token: 0x17009162 RID: 37218
		// (get) Token: 0x06025C34 RID: 154676 RVA: 0x00393F99 File Offset: 0x00392199
		// (set) Token: 0x06025C35 RID: 154677 RVA: 0x00393FA9 File Offset: 0x003921A9
		public unsafe int ProcessSelectionSetID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAggregationSettings.__PropertyOffset_ProcessSelectionSetID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAggregationSettings.__PropertyOffset_ProcessSelectionSetID) = value;
			}
		}

		// Token: 0x17009163 RID: 37219
		// (get) Token: 0x06025C36 RID: 154678 RVA: 0x00393FBA File Offset: 0x003921BA
		// (set) Token: 0x06025C37 RID: 154679 RVA: 0x00393FCE File Offset: 0x003921CE
		public unsafe string ProcessSelectionSetName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAggregationSettings.__PropertyOffset_ProcessSelectionSetName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAggregationSettings.__PropertyOffset_ProcessSelectionSetName)), value);
			}
		}

		// Token: 0x17009164 RID: 37220
		// (get) Token: 0x06025C38 RID: 154680 RVA: 0x00393FE3 File Offset: 0x003921E3
		// (set) Token: 0x06025C39 RID: 154681 RVA: 0x00393FFC File Offset: 0x003921FC
		public unsafe bool KeepUnprocessedSceneMeshes
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAggregationSettings.__PropertyOffset_KeepUnprocessedSceneMeshes) & FAggregationSettings.__PropertyMask_KeepUnprocessedSceneMeshes) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAggregationSettings.__PropertyOffset_KeepUnprocessedSceneMeshes) = ((*(base.NativePtr + (IntPtr)FAggregationSettings.__PropertyOffset_KeepUnprocessedSceneMeshes) & ~FAggregationSettings.__PropertyMask_KeepUnprocessedSceneMeshes) | (value ? FAggregationSettings.__PropertyMask_KeepUnprocessedSceneMeshes : 0));
			}
		}

		// Token: 0x06025C3A RID: 154682 RVA: 0x0039402C File Offset: 0x0039222C
		public FAggregationSettings()
		{
		}

		// Token: 0x06025C3B RID: 154683 RVA: 0x00394034 File Offset: 0x00392234
		public FAggregationSettings(bool MergeGeometries, bool EnableGeometryCulling, float GeometryCullingPrecision, bool SubdivideGeometryBasedOnUVTiles, int SubdivisionTileSize, int ProcessSelectionSetID, string ProcessSelectionSetName, bool KeepUnprocessedSceneMeshes)
		{
			this.MergeGeometries = MergeGeometries;
			this.EnableGeometryCulling = EnableGeometryCulling;
			this.GeometryCullingPrecision = GeometryCullingPrecision;
			this.SubdivideGeometryBasedOnUVTiles = SubdivideGeometryBasedOnUVTiles;
			this.SubdivisionTileSize = SubdivisionTileSize;
			this.ProcessSelectionSetID = ProcessSelectionSetID;
			this.ProcessSelectionSetName = ProcessSelectionSetName;
			this.KeepUnprocessedSceneMeshes = KeepUnprocessedSceneMeshes;
		}

		// Token: 0x06025C3C RID: 154684 RVA: 0x00394084 File Offset: 0x00392284
		protected override IntPtr GetUStructPtr()
		{
			return FAggregationSettings.StaticStruct();
		}

		// Token: 0x06025C3D RID: 154685 RVA: 0x00394090 File Offset: 0x00392290
		[NullableContext(2)]
		public FAggregationSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025C3E RID: 154686 RVA: 0x0039409A File Offset: 0x0039229A
		public FAggregationSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025C3F RID: 154687 RVA: 0x003940A5 File Offset: 0x003922A5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAggregationSettings(Pointer, false, true);
		}

		// Token: 0x06025C40 RID: 154688 RVA: 0x003940AF File Offset: 0x003922AF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAggregationSettings(Pointer, MemoryOwner);
		}

		// Token: 0x040148E6 RID: 84198
		public const string __ObjectPath = "/Script/SimplygonUObjects.AggregationSettings";

		// Token: 0x040148E7 RID: 84199
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040148E8 RID: 84200
		internal static int __PropertyOffset_MergeGeometries;

		// Token: 0x040148E9 RID: 84201
		internal static byte __PropertyMask_MergeGeometries;

		// Token: 0x040148EA RID: 84202
		internal static int __PropertyOffset_EnableGeometryCulling;

		// Token: 0x040148EB RID: 84203
		internal static byte __PropertyMask_EnableGeometryCulling;

		// Token: 0x040148EC RID: 84204
		internal static int __PropertyOffset_GeometryCullingPrecision;

		// Token: 0x040148ED RID: 84205
		internal static int __PropertyOffset_SubdivideGeometryBasedOnUVTiles;

		// Token: 0x040148EE RID: 84206
		internal static byte __PropertyMask_SubdivideGeometryBasedOnUVTiles;

		// Token: 0x040148EF RID: 84207
		internal static int __PropertyOffset_SubdivisionTileSize;

		// Token: 0x040148F0 RID: 84208
		internal static int __PropertyOffset_ProcessSelectionSetID;

		// Token: 0x040148F1 RID: 84209
		internal static int __PropertyOffset_ProcessSelectionSetName;

		// Token: 0x040148F2 RID: 84210
		internal static int __PropertyOffset_KeepUnprocessedSceneMeshes;

		// Token: 0x040148F3 RID: 84211
		internal static byte __PropertyMask_KeepUnprocessedSceneMeshes;
	}
}
