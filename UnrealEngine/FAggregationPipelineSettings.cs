using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002775 RID: 10101
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.AggregationPipelineSettings")]
	[UnrealStructLayout(496, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 496)]
	public class FAggregationPipelineSettings : FSimplygonPipelineSettings, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025C11 RID: 154641 RVA: 0x00393A95 File Offset: 0x00391C95
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAggregationPipelineSettings._ScriptStructPtr != 0) ? FAggregationPipelineSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SimplygonUObjects.AggregationPipelineSettings", ref FAggregationPipelineSettings._ScriptStructPtr);
		}

		// Token: 0x17009155 RID: 37205
		// (get) Token: 0x06025C12 RID: 154642 RVA: 0x00393ABC File Offset: 0x00391CBC
		// (set) Token: 0x06025C13 RID: 154643 RVA: 0x00393AFF File Offset: 0x00391CFF
		public FAggregationSettings AggregationSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAggregationSettings result;
				if ((result = this._AggregationSettings) == null)
				{
					result = (this._AggregationSettings = new FAggregationSettings(base.NativePtr + (IntPtr)FAggregationPipelineSettings.__PropertyOffset_AggregationSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAggregationSettings.StaticStruct(), base.NativePtr + (IntPtr)FAggregationPipelineSettings.__PropertyOffset_AggregationSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009156 RID: 37206
		// (get) Token: 0x06025C14 RID: 154644 RVA: 0x00393B20 File Offset: 0x00391D20
		// (set) Token: 0x06025C15 RID: 154645 RVA: 0x00393B63 File Offset: 0x00391D63
		public FVisibilitySettings VisibilitySettings
		{
			get
			{
				base.FastCheckIsValid();
				FVisibilitySettings result;
				if ((result = this._VisibilitySettings) == null)
				{
					result = (this._VisibilitySettings = new FVisibilitySettings(base.NativePtr + (IntPtr)FAggregationPipelineSettings.__PropertyOffset_VisibilitySettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FVisibilitySettings.StaticStruct(), base.NativePtr + (IntPtr)FAggregationPipelineSettings.__PropertyOffset_VisibilitySettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009157 RID: 37207
		// (get) Token: 0x06025C16 RID: 154646 RVA: 0x00393B84 File Offset: 0x00391D84
		// (set) Token: 0x06025C17 RID: 154647 RVA: 0x00393BC7 File Offset: 0x00391DC7
		public FGeometryCullingSettings GeometryCullingSettings
		{
			get
			{
				base.FastCheckIsValid();
				FGeometryCullingSettings result;
				if ((result = this._GeometryCullingSettings) == null)
				{
					result = (this._GeometryCullingSettings = new FGeometryCullingSettings(base.NativePtr + (IntPtr)FAggregationPipelineSettings.__PropertyOffset_GeometryCullingSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGeometryCullingSettings.StaticStruct(), base.NativePtr + (IntPtr)FAggregationPipelineSettings.__PropertyOffset_GeometryCullingSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009158 RID: 37208
		// (get) Token: 0x06025C18 RID: 154648 RVA: 0x00393BE8 File Offset: 0x00391DE8
		// (set) Token: 0x06025C19 RID: 154649 RVA: 0x00393C2B File Offset: 0x00391E2B
		public FVertexWeightSettings VertexWeightSettings
		{
			get
			{
				base.FastCheckIsValid();
				FVertexWeightSettings result;
				if ((result = this._VertexWeightSettings) == null)
				{
					result = (this._VertexWeightSettings = new FVertexWeightSettings(base.NativePtr + (IntPtr)FAggregationPipelineSettings.__PropertyOffset_VertexWeightSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FVertexWeightSettings.StaticStruct(), base.NativePtr + (IntPtr)FAggregationPipelineSettings.__PropertyOffset_VertexWeightSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009159 RID: 37209
		// (get) Token: 0x06025C1A RID: 154650 RVA: 0x00393C4C File Offset: 0x00391E4C
		// (set) Token: 0x06025C1B RID: 154651 RVA: 0x00393C8F File Offset: 0x00391E8F
		public FAttributeTessellationSettings AttributeTessellationSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAttributeTessellationSettings result;
				if ((result = this._AttributeTessellationSettings) == null)
				{
					result = (this._AttributeTessellationSettings = new FAttributeTessellationSettings(base.NativePtr + (IntPtr)FAggregationPipelineSettings.__PropertyOffset_AttributeTessellationSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAttributeTessellationSettings.StaticStruct(), base.NativePtr + (IntPtr)FAggregationPipelineSettings.__PropertyOffset_AttributeTessellationSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700915A RID: 37210
		// (get) Token: 0x06025C1C RID: 154652 RVA: 0x00393CB0 File Offset: 0x00391EB0
		// (set) Token: 0x06025C1D RID: 154653 RVA: 0x00393CF3 File Offset: 0x00391EF3
		public FMappingImageSettings MappingImageSettings
		{
			get
			{
				base.FastCheckIsValid();
				FMappingImageSettings result;
				if ((result = this._MappingImageSettings) == null)
				{
					result = (this._MappingImageSettings = new FMappingImageSettings(base.NativePtr + (IntPtr)FAggregationPipelineSettings.__PropertyOffset_MappingImageSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMappingImageSettings.StaticStruct(), base.NativePtr + (IntPtr)FAggregationPipelineSettings.__PropertyOffset_MappingImageSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700915B RID: 37211
		// (get) Token: 0x06025C1E RID: 154654 RVA: 0x00393D14 File Offset: 0x00391F14
		// (set) Token: 0x06025C1F RID: 154655 RVA: 0x00393D57 File Offset: 0x00391F57
		public FGenerateLightmapTexCoordSettings GenerateLightmapTexCoordSettings
		{
			get
			{
				base.FastCheckIsValid();
				FGenerateLightmapTexCoordSettings result;
				if ((result = this._GenerateLightmapTexCoordSettings) == null)
				{
					result = (this._GenerateLightmapTexCoordSettings = new FGenerateLightmapTexCoordSettings(base.NativePtr + (IntPtr)FAggregationPipelineSettings.__PropertyOffset_GenerateLightmapTexCoordSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGenerateLightmapTexCoordSettings.StaticStruct(), base.NativePtr + (IntPtr)FAggregationPipelineSettings.__PropertyOffset_GenerateLightmapTexCoordSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700915C RID: 37212
		// (get) Token: 0x06025C20 RID: 154656 RVA: 0x00393D78 File Offset: 0x00391F78
		// (set) Token: 0x06025C21 RID: 154657 RVA: 0x00393DBB File Offset: 0x00391FBB
		public TArray<USimplygonMaterialCaster> MaterialPropertyCasters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<USimplygonMaterialCaster> result;
				if ((result = this._MaterialPropertyCasters) == null)
				{
					result = (this._MaterialPropertyCasters = new TArray<USimplygonMaterialCaster>(base.NativePtr + (IntPtr)FAggregationPipelineSettings.__PropertyOffset_MaterialPropertyCasters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MaterialPropertyCasters.CopyAssign(value);
			}
		}

		// Token: 0x06025C22 RID: 154658 RVA: 0x00393DC9 File Offset: 0x00391FC9
		public FAggregationPipelineSettings()
		{
		}

		// Token: 0x06025C23 RID: 154659 RVA: 0x00393DD4 File Offset: 0x00391FD4
		public FAggregationPipelineSettings(FAggregationSettings AggregationSettings, FVisibilitySettings VisibilitySettings, FGeometryCullingSettings GeometryCullingSettings, FVertexWeightSettings VertexWeightSettings, FAttributeTessellationSettings AttributeTessellationSettings, FMappingImageSettings MappingImageSettings, FGenerateLightmapTexCoordSettings GenerateLightmapTexCoordSettings, TArray<USimplygonMaterialCaster> MaterialPropertyCasters)
		{
			this.AggregationSettings = AggregationSettings;
			this.VisibilitySettings = VisibilitySettings;
			this.GeometryCullingSettings = GeometryCullingSettings;
			this.VertexWeightSettings = VertexWeightSettings;
			this.AttributeTessellationSettings = AttributeTessellationSettings;
			this.MappingImageSettings = MappingImageSettings;
			this.GenerateLightmapTexCoordSettings = GenerateLightmapTexCoordSettings;
			this.MaterialPropertyCasters = MaterialPropertyCasters;
		}

		// Token: 0x06025C24 RID: 154660 RVA: 0x00393E24 File Offset: 0x00392024
		protected override IntPtr GetUStructPtr()
		{
			return FAggregationPipelineSettings.StaticStruct();
		}

		// Token: 0x06025C25 RID: 154661 RVA: 0x00393E30 File Offset: 0x00392030
		[NullableContext(2)]
		public FAggregationPipelineSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025C26 RID: 154662 RVA: 0x00393E3A File Offset: 0x0039203A
		public FAggregationPipelineSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025C27 RID: 154663 RVA: 0x00393E45 File Offset: 0x00392045
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAggregationPipelineSettings(Pointer, false, true);
		}

		// Token: 0x06025C28 RID: 154664 RVA: 0x00393E4F File Offset: 0x0039204F
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAggregationPipelineSettings(Pointer, MemoryOwner);
		}

		// Token: 0x040148D4 RID: 84180
		public new const string __ObjectPath = "/Script/SimplygonUObjects.AggregationPipelineSettings";

		// Token: 0x040148D5 RID: 84181
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040148D6 RID: 84182
		internal static int __PropertyOffset_AggregationSettings;

		// Token: 0x040148D7 RID: 84183
		[Nullable(2)]
		private FAggregationSettings _AggregationSettings;

		// Token: 0x040148D8 RID: 84184
		internal static int __PropertyOffset_VisibilitySettings;

		// Token: 0x040148D9 RID: 84185
		[Nullable(2)]
		private FVisibilitySettings _VisibilitySettings;

		// Token: 0x040148DA RID: 84186
		internal static int __PropertyOffset_GeometryCullingSettings;

		// Token: 0x040148DB RID: 84187
		[Nullable(2)]
		private FGeometryCullingSettings _GeometryCullingSettings;

		// Token: 0x040148DC RID: 84188
		internal static int __PropertyOffset_VertexWeightSettings;

		// Token: 0x040148DD RID: 84189
		[Nullable(2)]
		private FVertexWeightSettings _VertexWeightSettings;

		// Token: 0x040148DE RID: 84190
		internal static int __PropertyOffset_AttributeTessellationSettings;

		// Token: 0x040148DF RID: 84191
		[Nullable(2)]
		private FAttributeTessellationSettings _AttributeTessellationSettings;

		// Token: 0x040148E0 RID: 84192
		internal static int __PropertyOffset_MappingImageSettings;

		// Token: 0x040148E1 RID: 84193
		[Nullable(2)]
		private FMappingImageSettings _MappingImageSettings;

		// Token: 0x040148E2 RID: 84194
		internal static int __PropertyOffset_GenerateLightmapTexCoordSettings;

		// Token: 0x040148E3 RID: 84195
		[Nullable(2)]
		private FGenerateLightmapTexCoordSettings _GenerateLightmapTexCoordSettings;

		// Token: 0x040148E4 RID: 84196
		internal static int __PropertyOffset_MaterialPropertyCasters;

		// Token: 0x040148E5 RID: 84197
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USimplygonMaterialCaster> _MaterialPropertyCasters;
	}
}
