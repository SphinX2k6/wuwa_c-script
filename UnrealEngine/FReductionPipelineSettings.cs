using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020027CC RID: 10188
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.ReductionPipelineSettings")]
	[UnrealStructLayout(648, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 648)]
	public class FReductionPipelineSettings : FSimplygonPipelineSettings, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025FB1 RID: 155569 RVA: 0x00399619 File Offset: 0x00397819
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FReductionPipelineSettings._ScriptStructPtr != 0) ? FReductionPipelineSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SimplygonUObjects.ReductionPipelineSettings", ref FReductionPipelineSettings._ScriptStructPtr);
		}

		// Token: 0x17009278 RID: 37496
		// (get) Token: 0x06025FB2 RID: 155570 RVA: 0x00399640 File Offset: 0x00397840
		// (set) Token: 0x06025FB3 RID: 155571 RVA: 0x00399683 File Offset: 0x00397883
		public FReductionSettings ReductionSettings
		{
			get
			{
				base.FastCheckIsValid();
				FReductionSettings result;
				if ((result = this._ReductionSettings) == null)
				{
					result = (this._ReductionSettings = new FReductionSettings(base.NativePtr + (IntPtr)FReductionPipelineSettings.__PropertyOffset_ReductionSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FReductionSettings.StaticStruct(), base.NativePtr + (IntPtr)FReductionPipelineSettings.__PropertyOffset_ReductionSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009279 RID: 37497
		// (get) Token: 0x06025FB4 RID: 155572 RVA: 0x003996A4 File Offset: 0x003978A4
		// (set) Token: 0x06025FB5 RID: 155573 RVA: 0x003996E7 File Offset: 0x003978E7
		public FRepairSettings RepairSettings
		{
			get
			{
				base.FastCheckIsValid();
				FRepairSettings result;
				if ((result = this._RepairSettings) == null)
				{
					result = (this._RepairSettings = new FRepairSettings(base.NativePtr + (IntPtr)FReductionPipelineSettings.__PropertyOffset_RepairSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRepairSettings.StaticStruct(), base.NativePtr + (IntPtr)FReductionPipelineSettings.__PropertyOffset_RepairSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700927A RID: 37498
		// (get) Token: 0x06025FB6 RID: 155574 RVA: 0x00399708 File Offset: 0x00397908
		// (set) Token: 0x06025FB7 RID: 155575 RVA: 0x0039974B File Offset: 0x0039794B
		public FNormalCalculationSettings NormalCalculationSettings
		{
			get
			{
				base.FastCheckIsValid();
				FNormalCalculationSettings result;
				if ((result = this._NormalCalculationSettings) == null)
				{
					result = (this._NormalCalculationSettings = new FNormalCalculationSettings(base.NativePtr + (IntPtr)FReductionPipelineSettings.__PropertyOffset_NormalCalculationSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNormalCalculationSettings.StaticStruct(), base.NativePtr + (IntPtr)FReductionPipelineSettings.__PropertyOffset_NormalCalculationSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700927B RID: 37499
		// (get) Token: 0x06025FB8 RID: 155576 RVA: 0x0039976C File Offset: 0x0039796C
		// (set) Token: 0x06025FB9 RID: 155577 RVA: 0x003997AF File Offset: 0x003979AF
		public FVisibilitySettings VisibilitySettings
		{
			get
			{
				base.FastCheckIsValid();
				FVisibilitySettings result;
				if ((result = this._VisibilitySettings) == null)
				{
					result = (this._VisibilitySettings = new FVisibilitySettings(base.NativePtr + (IntPtr)FReductionPipelineSettings.__PropertyOffset_VisibilitySettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FVisibilitySettings.StaticStruct(), base.NativePtr + (IntPtr)FReductionPipelineSettings.__PropertyOffset_VisibilitySettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700927C RID: 37500
		// (get) Token: 0x06025FBA RID: 155578 RVA: 0x003997D0 File Offset: 0x003979D0
		// (set) Token: 0x06025FBB RID: 155579 RVA: 0x00399813 File Offset: 0x00397A13
		public FBoneSettings BoneSettings
		{
			get
			{
				base.FastCheckIsValid();
				FBoneSettings result;
				if ((result = this._BoneSettings) == null)
				{
					result = (this._BoneSettings = new FBoneSettings(base.NativePtr + (IntPtr)FReductionPipelineSettings.__PropertyOffset_BoneSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneSettings.StaticStruct(), base.NativePtr + (IntPtr)FReductionPipelineSettings.__PropertyOffset_BoneSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700927D RID: 37501
		// (get) Token: 0x06025FBC RID: 155580 RVA: 0x00399834 File Offset: 0x00397A34
		// (set) Token: 0x06025FBD RID: 155581 RVA: 0x00399877 File Offset: 0x00397A77
		public FVertexWeightSettings VertexWeightSettings
		{
			get
			{
				base.FastCheckIsValid();
				FVertexWeightSettings result;
				if ((result = this._VertexWeightSettings) == null)
				{
					result = (this._VertexWeightSettings = new FVertexWeightSettings(base.NativePtr + (IntPtr)FReductionPipelineSettings.__PropertyOffset_VertexWeightSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FVertexWeightSettings.StaticStruct(), base.NativePtr + (IntPtr)FReductionPipelineSettings.__PropertyOffset_VertexWeightSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700927E RID: 37502
		// (get) Token: 0x06025FBE RID: 155582 RVA: 0x00399898 File Offset: 0x00397A98
		// (set) Token: 0x06025FBF RID: 155583 RVA: 0x003998DB File Offset: 0x00397ADB
		public FPartRemoverSettings PartRemoverSettings
		{
			get
			{
				base.FastCheckIsValid();
				FPartRemoverSettings result;
				if ((result = this._PartRemoverSettings) == null)
				{
					result = (this._PartRemoverSettings = new FPartRemoverSettings(base.NativePtr + (IntPtr)FReductionPipelineSettings.__PropertyOffset_PartRemoverSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPartRemoverSettings.StaticStruct(), base.NativePtr + (IntPtr)FReductionPipelineSettings.__PropertyOffset_PartRemoverSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700927F RID: 37503
		// (get) Token: 0x06025FC0 RID: 155584 RVA: 0x003998FC File Offset: 0x00397AFC
		// (set) Token: 0x06025FC1 RID: 155585 RVA: 0x0039993F File Offset: 0x00397B3F
		public FAttributeTessellationSettings AttributeTessellationSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAttributeTessellationSettings result;
				if ((result = this._AttributeTessellationSettings) == null)
				{
					result = (this._AttributeTessellationSettings = new FAttributeTessellationSettings(base.NativePtr + (IntPtr)FReductionPipelineSettings.__PropertyOffset_AttributeTessellationSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAttributeTessellationSettings.StaticStruct(), base.NativePtr + (IntPtr)FReductionPipelineSettings.__PropertyOffset_AttributeTessellationSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009280 RID: 37504
		// (get) Token: 0x06025FC2 RID: 155586 RVA: 0x00399960 File Offset: 0x00397B60
		// (set) Token: 0x06025FC3 RID: 155587 RVA: 0x003999A3 File Offset: 0x00397BA3
		public FMappingImageSettings MappingImageSettings
		{
			get
			{
				base.FastCheckIsValid();
				FMappingImageSettings result;
				if ((result = this._MappingImageSettings) == null)
				{
					result = (this._MappingImageSettings = new FMappingImageSettings(base.NativePtr + (IntPtr)FReductionPipelineSettings.__PropertyOffset_MappingImageSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMappingImageSettings.StaticStruct(), base.NativePtr + (IntPtr)FReductionPipelineSettings.__PropertyOffset_MappingImageSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009281 RID: 37505
		// (get) Token: 0x06025FC4 RID: 155588 RVA: 0x003999C4 File Offset: 0x00397BC4
		// (set) Token: 0x06025FC5 RID: 155589 RVA: 0x00399A07 File Offset: 0x00397C07
		public TArray<USimplygonMaterialCaster> MaterialPropertyCasters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<USimplygonMaterialCaster> result;
				if ((result = this._MaterialPropertyCasters) == null)
				{
					result = (this._MaterialPropertyCasters = new TArray<USimplygonMaterialCaster>(base.NativePtr + (IntPtr)FReductionPipelineSettings.__PropertyOffset_MaterialPropertyCasters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MaterialPropertyCasters.CopyAssign(value);
			}
		}

		// Token: 0x06025FC6 RID: 155590 RVA: 0x00399A15 File Offset: 0x00397C15
		public FReductionPipelineSettings()
		{
		}

		// Token: 0x06025FC7 RID: 155591 RVA: 0x00399A20 File Offset: 0x00397C20
		public FReductionPipelineSettings(FReductionSettings ReductionSettings, FRepairSettings RepairSettings, FNormalCalculationSettings NormalCalculationSettings, FVisibilitySettings VisibilitySettings, FBoneSettings BoneSettings, FVertexWeightSettings VertexWeightSettings, FPartRemoverSettings PartRemoverSettings, FAttributeTessellationSettings AttributeTessellationSettings, FMappingImageSettings MappingImageSettings, TArray<USimplygonMaterialCaster> MaterialPropertyCasters)
		{
			this.ReductionSettings = ReductionSettings;
			this.RepairSettings = RepairSettings;
			this.NormalCalculationSettings = NormalCalculationSettings;
			this.VisibilitySettings = VisibilitySettings;
			this.BoneSettings = BoneSettings;
			this.VertexWeightSettings = VertexWeightSettings;
			this.PartRemoverSettings = PartRemoverSettings;
			this.AttributeTessellationSettings = AttributeTessellationSettings;
			this.MappingImageSettings = MappingImageSettings;
			this.MaterialPropertyCasters = MaterialPropertyCasters;
		}

		// Token: 0x06025FC8 RID: 155592 RVA: 0x00399A80 File Offset: 0x00397C80
		protected override IntPtr GetUStructPtr()
		{
			return FReductionPipelineSettings.StaticStruct();
		}

		// Token: 0x06025FC9 RID: 155593 RVA: 0x00399A8C File Offset: 0x00397C8C
		[NullableContext(2)]
		public FReductionPipelineSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025FCA RID: 155594 RVA: 0x00399A96 File Offset: 0x00397C96
		public FReductionPipelineSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025FCB RID: 155595 RVA: 0x00399AA1 File Offset: 0x00397CA1
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FReductionPipelineSettings(Pointer, false, true);
		}

		// Token: 0x06025FCC RID: 155596 RVA: 0x00399AAB File Offset: 0x00397CAB
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FReductionPipelineSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04014BB4 RID: 84916
		public new const string __ObjectPath = "/Script/SimplygonUObjects.ReductionPipelineSettings";

		// Token: 0x04014BB5 RID: 84917
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014BB6 RID: 84918
		internal static int __PropertyOffset_ReductionSettings;

		// Token: 0x04014BB7 RID: 84919
		[Nullable(2)]
		private FReductionSettings _ReductionSettings;

		// Token: 0x04014BB8 RID: 84920
		internal static int __PropertyOffset_RepairSettings;

		// Token: 0x04014BB9 RID: 84921
		[Nullable(2)]
		private FRepairSettings _RepairSettings;

		// Token: 0x04014BBA RID: 84922
		internal static int __PropertyOffset_NormalCalculationSettings;

		// Token: 0x04014BBB RID: 84923
		[Nullable(2)]
		private FNormalCalculationSettings _NormalCalculationSettings;

		// Token: 0x04014BBC RID: 84924
		internal static int __PropertyOffset_VisibilitySettings;

		// Token: 0x04014BBD RID: 84925
		[Nullable(2)]
		private FVisibilitySettings _VisibilitySettings;

		// Token: 0x04014BBE RID: 84926
		internal static int __PropertyOffset_BoneSettings;

		// Token: 0x04014BBF RID: 84927
		[Nullable(2)]
		private FBoneSettings _BoneSettings;

		// Token: 0x04014BC0 RID: 84928
		internal static int __PropertyOffset_VertexWeightSettings;

		// Token: 0x04014BC1 RID: 84929
		[Nullable(2)]
		private FVertexWeightSettings _VertexWeightSettings;

		// Token: 0x04014BC2 RID: 84930
		internal static int __PropertyOffset_PartRemoverSettings;

		// Token: 0x04014BC3 RID: 84931
		[Nullable(2)]
		private FPartRemoverSettings _PartRemoverSettings;

		// Token: 0x04014BC4 RID: 84932
		internal static int __PropertyOffset_AttributeTessellationSettings;

		// Token: 0x04014BC5 RID: 84933
		[Nullable(2)]
		private FAttributeTessellationSettings _AttributeTessellationSettings;

		// Token: 0x04014BC6 RID: 84934
		internal static int __PropertyOffset_MappingImageSettings;

		// Token: 0x04014BC7 RID: 84935
		[Nullable(2)]
		private FMappingImageSettings _MappingImageSettings;

		// Token: 0x04014BC8 RID: 84936
		internal static int __PropertyOffset_MaterialPropertyCasters;

		// Token: 0x04014BC9 RID: 84937
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USimplygonMaterialCaster> _MaterialPropertyCasters;
	}
}
