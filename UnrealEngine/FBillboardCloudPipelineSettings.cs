using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200277D RID: 10109
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.BillboardCloudPipelineSettings")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 304)]
	public class FBillboardCloudPipelineSettings : FSimplygonPipelineSettings, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025C99 RID: 154777 RVA: 0x003948CA File Offset: 0x00392ACA
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBillboardCloudPipelineSettings._ScriptStructPtr != 0) ? FBillboardCloudPipelineSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SimplygonUObjects.BillboardCloudPipelineSettings", ref FBillboardCloudPipelineSettings._ScriptStructPtr);
		}

		// Token: 0x1700917F RID: 37247
		// (get) Token: 0x06025C9A RID: 154778 RVA: 0x003948F0 File Offset: 0x00392AF0
		// (set) Token: 0x06025C9B RID: 154779 RVA: 0x00394933 File Offset: 0x00392B33
		public FBillboardCloudSettings BillboardCloudSettings
		{
			get
			{
				base.FastCheckIsValid();
				FBillboardCloudSettings result;
				if ((result = this._BillboardCloudSettings) == null)
				{
					result = (this._BillboardCloudSettings = new FBillboardCloudSettings(base.NativePtr + (IntPtr)FBillboardCloudPipelineSettings.__PropertyOffset_BillboardCloudSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBillboardCloudSettings.StaticStruct(), base.NativePtr + (IntPtr)FBillboardCloudPipelineSettings.__PropertyOffset_BillboardCloudSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009180 RID: 37248
		// (get) Token: 0x06025C9C RID: 154780 RVA: 0x00394954 File Offset: 0x00392B54
		// (set) Token: 0x06025C9D RID: 154781 RVA: 0x00394997 File Offset: 0x00392B97
		public FAttributeTessellationSettings AttributeTessellationSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAttributeTessellationSettings result;
				if ((result = this._AttributeTessellationSettings) == null)
				{
					result = (this._AttributeTessellationSettings = new FAttributeTessellationSettings(base.NativePtr + (IntPtr)FBillboardCloudPipelineSettings.__PropertyOffset_AttributeTessellationSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAttributeTessellationSettings.StaticStruct(), base.NativePtr + (IntPtr)FBillboardCloudPipelineSettings.__PropertyOffset_AttributeTessellationSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009181 RID: 37249
		// (get) Token: 0x06025C9E RID: 154782 RVA: 0x003949B8 File Offset: 0x00392BB8
		// (set) Token: 0x06025C9F RID: 154783 RVA: 0x003949FB File Offset: 0x00392BFB
		public FMappingImageSettings MappingImageSettings
		{
			get
			{
				base.FastCheckIsValid();
				FMappingImageSettings result;
				if ((result = this._MappingImageSettings) == null)
				{
					result = (this._MappingImageSettings = new FMappingImageSettings(base.NativePtr + (IntPtr)FBillboardCloudPipelineSettings.__PropertyOffset_MappingImageSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMappingImageSettings.StaticStruct(), base.NativePtr + (IntPtr)FBillboardCloudPipelineSettings.__PropertyOffset_MappingImageSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009182 RID: 37250
		// (get) Token: 0x06025CA0 RID: 154784 RVA: 0x00394A1C File Offset: 0x00392C1C
		// (set) Token: 0x06025CA1 RID: 154785 RVA: 0x00394A5F File Offset: 0x00392C5F
		public TArray<USimplygonMaterialCaster> MaterialPropertyCasters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<USimplygonMaterialCaster> result;
				if ((result = this._MaterialPropertyCasters) == null)
				{
					result = (this._MaterialPropertyCasters = new TArray<USimplygonMaterialCaster>(base.NativePtr + (IntPtr)FBillboardCloudPipelineSettings.__PropertyOffset_MaterialPropertyCasters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MaterialPropertyCasters.CopyAssign(value);
			}
		}

		// Token: 0x06025CA2 RID: 154786 RVA: 0x00394A6D File Offset: 0x00392C6D
		public FBillboardCloudPipelineSettings()
		{
		}

		// Token: 0x06025CA3 RID: 154787 RVA: 0x00394A75 File Offset: 0x00392C75
		public FBillboardCloudPipelineSettings(FBillboardCloudSettings BillboardCloudSettings, FAttributeTessellationSettings AttributeTessellationSettings, FMappingImageSettings MappingImageSettings, TArray<USimplygonMaterialCaster> MaterialPropertyCasters)
		{
			this.BillboardCloudSettings = BillboardCloudSettings;
			this.AttributeTessellationSettings = AttributeTessellationSettings;
			this.MappingImageSettings = MappingImageSettings;
			this.MaterialPropertyCasters = MaterialPropertyCasters;
		}

		// Token: 0x06025CA4 RID: 154788 RVA: 0x00394A9A File Offset: 0x00392C9A
		protected override IntPtr GetUStructPtr()
		{
			return FBillboardCloudPipelineSettings.StaticStruct();
		}

		// Token: 0x06025CA5 RID: 154789 RVA: 0x00394AA6 File Offset: 0x00392CA6
		[NullableContext(2)]
		public FBillboardCloudPipelineSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025CA6 RID: 154790 RVA: 0x00394AB0 File Offset: 0x00392CB0
		public FBillboardCloudPipelineSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025CA7 RID: 154791 RVA: 0x00394ABB File Offset: 0x00392CBB
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBillboardCloudPipelineSettings(Pointer, false, true);
		}

		// Token: 0x06025CA8 RID: 154792 RVA: 0x00394AC5 File Offset: 0x00392CC5
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBillboardCloudPipelineSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04014924 RID: 84260
		public new const string __ObjectPath = "/Script/SimplygonUObjects.BillboardCloudPipelineSettings";

		// Token: 0x04014925 RID: 84261
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014926 RID: 84262
		internal static int __PropertyOffset_BillboardCloudSettings;

		// Token: 0x04014927 RID: 84263
		[Nullable(2)]
		private FBillboardCloudSettings _BillboardCloudSettings;

		// Token: 0x04014928 RID: 84264
		internal static int __PropertyOffset_AttributeTessellationSettings;

		// Token: 0x04014929 RID: 84265
		[Nullable(2)]
		private FAttributeTessellationSettings _AttributeTessellationSettings;

		// Token: 0x0401492A RID: 84266
		internal static int __PropertyOffset_MappingImageSettings;

		// Token: 0x0401492B RID: 84267
		[Nullable(2)]
		private FMappingImageSettings _MappingImageSettings;

		// Token: 0x0401492C RID: 84268
		internal static int __PropertyOffset_MaterialPropertyCasters;

		// Token: 0x0401492D RID: 84269
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USimplygonMaterialCaster> _MaterialPropertyCasters;
	}
}
