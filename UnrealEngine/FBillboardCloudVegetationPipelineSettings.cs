using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002780 RID: 10112
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.BillboardCloudVegetationPipelineSettings")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 304)]
	public class FBillboardCloudVegetationPipelineSettings : FSimplygonPipelineSettings, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025CD0 RID: 154832 RVA: 0x00394ED1 File Offset: 0x003930D1
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBillboardCloudVegetationPipelineSettings._ScriptStructPtr != 0) ? FBillboardCloudVegetationPipelineSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SimplygonUObjects.BillboardCloudVegetationPipelineSettings", ref FBillboardCloudVegetationPipelineSettings._ScriptStructPtr);
		}

		// Token: 0x17009190 RID: 37264
		// (get) Token: 0x06025CD1 RID: 154833 RVA: 0x00394EF8 File Offset: 0x003930F8
		// (set) Token: 0x06025CD2 RID: 154834 RVA: 0x00394F3B File Offset: 0x0039313B
		public FBillboardCloudSettings BillboardCloudSettings
		{
			get
			{
				base.FastCheckIsValid();
				FBillboardCloudSettings result;
				if ((result = this._BillboardCloudSettings) == null)
				{
					result = (this._BillboardCloudSettings = new FBillboardCloudSettings(base.NativePtr + (IntPtr)FBillboardCloudVegetationPipelineSettings.__PropertyOffset_BillboardCloudSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBillboardCloudSettings.StaticStruct(), base.NativePtr + (IntPtr)FBillboardCloudVegetationPipelineSettings.__PropertyOffset_BillboardCloudSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009191 RID: 37265
		// (get) Token: 0x06025CD3 RID: 154835 RVA: 0x00394F5C File Offset: 0x0039315C
		// (set) Token: 0x06025CD4 RID: 154836 RVA: 0x00394F9F File Offset: 0x0039319F
		public FAttributeTessellationSettings AttributeTessellationSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAttributeTessellationSettings result;
				if ((result = this._AttributeTessellationSettings) == null)
				{
					result = (this._AttributeTessellationSettings = new FAttributeTessellationSettings(base.NativePtr + (IntPtr)FBillboardCloudVegetationPipelineSettings.__PropertyOffset_AttributeTessellationSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAttributeTessellationSettings.StaticStruct(), base.NativePtr + (IntPtr)FBillboardCloudVegetationPipelineSettings.__PropertyOffset_AttributeTessellationSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009192 RID: 37266
		// (get) Token: 0x06025CD5 RID: 154837 RVA: 0x00394FC0 File Offset: 0x003931C0
		// (set) Token: 0x06025CD6 RID: 154838 RVA: 0x00395003 File Offset: 0x00393203
		public FMappingImageSettings MappingImageSettings
		{
			get
			{
				base.FastCheckIsValid();
				FMappingImageSettings result;
				if ((result = this._MappingImageSettings) == null)
				{
					result = (this._MappingImageSettings = new FMappingImageSettings(base.NativePtr + (IntPtr)FBillboardCloudVegetationPipelineSettings.__PropertyOffset_MappingImageSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMappingImageSettings.StaticStruct(), base.NativePtr + (IntPtr)FBillboardCloudVegetationPipelineSettings.__PropertyOffset_MappingImageSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009193 RID: 37267
		// (get) Token: 0x06025CD7 RID: 154839 RVA: 0x00395024 File Offset: 0x00393224
		// (set) Token: 0x06025CD8 RID: 154840 RVA: 0x00395067 File Offset: 0x00393267
		public TArray<USimplygonMaterialCaster> MaterialPropertyCasters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<USimplygonMaterialCaster> result;
				if ((result = this._MaterialPropertyCasters) == null)
				{
					result = (this._MaterialPropertyCasters = new TArray<USimplygonMaterialCaster>(base.NativePtr + (IntPtr)FBillboardCloudVegetationPipelineSettings.__PropertyOffset_MaterialPropertyCasters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MaterialPropertyCasters.CopyAssign(value);
			}
		}

		// Token: 0x06025CD9 RID: 154841 RVA: 0x00395075 File Offset: 0x00393275
		public FBillboardCloudVegetationPipelineSettings()
		{
		}

		// Token: 0x06025CDA RID: 154842 RVA: 0x0039507D File Offset: 0x0039327D
		public FBillboardCloudVegetationPipelineSettings(FBillboardCloudSettings BillboardCloudSettings, FAttributeTessellationSettings AttributeTessellationSettings, FMappingImageSettings MappingImageSettings, TArray<USimplygonMaterialCaster> MaterialPropertyCasters)
		{
			this.BillboardCloudSettings = BillboardCloudSettings;
			this.AttributeTessellationSettings = AttributeTessellationSettings;
			this.MappingImageSettings = MappingImageSettings;
			this.MaterialPropertyCasters = MaterialPropertyCasters;
		}

		// Token: 0x06025CDB RID: 154843 RVA: 0x003950A2 File Offset: 0x003932A2
		protected override IntPtr GetUStructPtr()
		{
			return FBillboardCloudVegetationPipelineSettings.StaticStruct();
		}

		// Token: 0x06025CDC RID: 154844 RVA: 0x003950AE File Offset: 0x003932AE
		[NullableContext(2)]
		public FBillboardCloudVegetationPipelineSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025CDD RID: 154845 RVA: 0x003950B8 File Offset: 0x003932B8
		public FBillboardCloudVegetationPipelineSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025CDE RID: 154846 RVA: 0x003950C3 File Offset: 0x003932C3
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBillboardCloudVegetationPipelineSettings(Pointer, false, true);
		}

		// Token: 0x06025CDF RID: 154847 RVA: 0x003950CD File Offset: 0x003932CD
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBillboardCloudVegetationPipelineSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04014945 RID: 84293
		public new const string __ObjectPath = "/Script/SimplygonUObjects.BillboardCloudVegetationPipelineSettings";

		// Token: 0x04014946 RID: 84294
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014947 RID: 84295
		internal static int __PropertyOffset_BillboardCloudSettings;

		// Token: 0x04014948 RID: 84296
		[Nullable(2)]
		private FBillboardCloudSettings _BillboardCloudSettings;

		// Token: 0x04014949 RID: 84297
		internal static int __PropertyOffset_AttributeTessellationSettings;

		// Token: 0x0401494A RID: 84298
		[Nullable(2)]
		private FAttributeTessellationSettings _AttributeTessellationSettings;

		// Token: 0x0401494B RID: 84299
		internal static int __PropertyOffset_MappingImageSettings;

		// Token: 0x0401494C RID: 84300
		[Nullable(2)]
		private FMappingImageSettings _MappingImageSettings;

		// Token: 0x0401494D RID: 84301
		internal static int __PropertyOffset_MaterialPropertyCasters;

		// Token: 0x0401494E RID: 84302
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USimplygonMaterialCaster> _MaterialPropertyCasters;
	}
}
