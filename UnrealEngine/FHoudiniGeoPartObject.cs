using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020014C4 RID: 5316
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniGeoPartObject")]
	[UnrealStructLayout(560, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 560)]
	public class FHoudiniGeoPartObject : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060133C5 RID: 78789 RVA: 0x001C49AC File Offset: 0x001C2BAC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHoudiniGeoPartObject._ScriptStructPtr != 0) ? FHoudiniGeoPartObject._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/HoudiniEngineRuntime.HoudiniGeoPartObject", ref FHoudiniGeoPartObject._ScriptStructPtr);
		}

		// Token: 0x17004ACC RID: 19148
		// (get) Token: 0x060133C6 RID: 78790 RVA: 0x001C49D0 File Offset: 0x001C2BD0
		// (set) Token: 0x060133C7 RID: 78791 RVA: 0x001C49E0 File Offset: 0x001C2BE0
		public unsafe int AssetId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniGeoPartObject.__PropertyOffset_AssetId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniGeoPartObject.__PropertyOffset_AssetId) = value;
			}
		}

		// Token: 0x17004ACD RID: 19149
		// (get) Token: 0x060133C8 RID: 78792 RVA: 0x001C49F1 File Offset: 0x001C2BF1
		// (set) Token: 0x060133C9 RID: 78793 RVA: 0x001C4A05 File Offset: 0x001C2C05
		public unsafe string AssetName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FHoudiniGeoPartObject.__PropertyOffset_AssetName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FHoudiniGeoPartObject.__PropertyOffset_AssetName)), value);
			}
		}

		// Token: 0x17004ACE RID: 19150
		// (get) Token: 0x060133CA RID: 78794 RVA: 0x001C4A1A File Offset: 0x001C2C1A
		// (set) Token: 0x060133CB RID: 78795 RVA: 0x001C4A2A File Offset: 0x001C2C2A
		public unsafe int ObjectId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniGeoPartObject.__PropertyOffset_ObjectId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniGeoPartObject.__PropertyOffset_ObjectId) = value;
			}
		}

		// Token: 0x17004ACF RID: 19151
		// (get) Token: 0x060133CC RID: 78796 RVA: 0x001C4A3B File Offset: 0x001C2C3B
		// (set) Token: 0x060133CD RID: 78797 RVA: 0x001C4A4F File Offset: 0x001C2C4F
		public unsafe string ObjectName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FHoudiniGeoPartObject.__PropertyOffset_ObjectName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FHoudiniGeoPartObject.__PropertyOffset_ObjectName)), value);
			}
		}

		// Token: 0x17004AD0 RID: 19152
		// (get) Token: 0x060133CE RID: 78798 RVA: 0x001C4A64 File Offset: 0x001C2C64
		// (set) Token: 0x060133CF RID: 78799 RVA: 0x001C4A74 File Offset: 0x001C2C74
		public unsafe int GeoId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniGeoPartObject.__PropertyOffset_GeoId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniGeoPartObject.__PropertyOffset_GeoId) = value;
			}
		}

		// Token: 0x17004AD1 RID: 19153
		// (get) Token: 0x060133D0 RID: 78800 RVA: 0x001C4A85 File Offset: 0x001C2C85
		// (set) Token: 0x060133D1 RID: 78801 RVA: 0x001C4A95 File Offset: 0x001C2C95
		public unsafe int PartId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniGeoPartObject.__PropertyOffset_PartId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniGeoPartObject.__PropertyOffset_PartId) = value;
			}
		}

		// Token: 0x17004AD2 RID: 19154
		// (get) Token: 0x060133D2 RID: 78802 RVA: 0x001C4AA6 File Offset: 0x001C2CA6
		// (set) Token: 0x060133D3 RID: 78803 RVA: 0x001C4ABA File Offset: 0x001C2CBA
		public unsafe string PartName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FHoudiniGeoPartObject.__PropertyOffset_PartName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FHoudiniGeoPartObject.__PropertyOffset_PartName)), value);
			}
		}

		// Token: 0x17004AD3 RID: 19155
		// (get) Token: 0x060133D4 RID: 78804 RVA: 0x001C4ACF File Offset: 0x001C2CCF
		// (set) Token: 0x060133D5 RID: 78805 RVA: 0x001C4ADF File Offset: 0x001C2CDF
		public unsafe bool bHasCustomPartName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniGeoPartObject.__PropertyOffset_bHasCustomPartName) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniGeoPartObject.__PropertyOffset_bHasCustomPartName) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004AD4 RID: 19156
		// (get) Token: 0x060133D6 RID: 78806 RVA: 0x001C4AF0 File Offset: 0x001C2CF0
		// (set) Token: 0x060133D7 RID: 78807 RVA: 0x001C4B33 File Offset: 0x001C2D33
		public TArray<string> SplitGroups
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._SplitGroups) == null)
				{
					result = (this._SplitGroups = new TArray<string>(base.NativePtr + (IntPtr)FHoudiniGeoPartObject.__PropertyOffset_SplitGroups, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SplitGroups.CopyAssign(value);
			}
		}

		// Token: 0x17004AD5 RID: 19157
		// (get) Token: 0x060133D8 RID: 78808 RVA: 0x001C4B41 File Offset: 0x001C2D41
		// (set) Token: 0x060133D9 RID: 78809 RVA: 0x001C4B55 File Offset: 0x001C2D55
		public unsafe FTransform TransformMatrix
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniGeoPartObject.__PropertyOffset_TransformMatrix);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniGeoPartObject.__PropertyOffset_TransformMatrix) = value;
			}
		}

		// Token: 0x17004AD6 RID: 19158
		// (get) Token: 0x060133DA RID: 78810 RVA: 0x001C4B6A File Offset: 0x001C2D6A
		// (set) Token: 0x060133DB RID: 78811 RVA: 0x001C4B7E File Offset: 0x001C2D7E
		public unsafe string NodePath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FHoudiniGeoPartObject.__PropertyOffset_NodePath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FHoudiniGeoPartObject.__PropertyOffset_NodePath)), value);
			}
		}

		// Token: 0x17004AD7 RID: 19159
		// (get) Token: 0x060133DC RID: 78812 RVA: 0x001C4B93 File Offset: 0x001C2D93
		// (set) Token: 0x060133DD RID: 78813 RVA: 0x001C4BA3 File Offset: 0x001C2DA3
		public unsafe EHoudiniPartType Type
		{
			get
			{
				return (EHoudiniPartType)(*(base.NativePtr + (IntPtr)FHoudiniGeoPartObject.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniGeoPartObject.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x17004AD8 RID: 19160
		// (get) Token: 0x060133DE RID: 78814 RVA: 0x001C4BB4 File Offset: 0x001C2DB4
		// (set) Token: 0x060133DF RID: 78815 RVA: 0x001C4BC4 File Offset: 0x001C2DC4
		public unsafe EHoudiniInstancerType InstancerType
		{
			get
			{
				return (EHoudiniInstancerType)(*(base.NativePtr + (IntPtr)FHoudiniGeoPartObject.__PropertyOffset_InstancerType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniGeoPartObject.__PropertyOffset_InstancerType) = (byte)value;
			}
		}

		// Token: 0x17004AD9 RID: 19161
		// (get) Token: 0x060133E0 RID: 78816 RVA: 0x001C4BD5 File Offset: 0x001C2DD5
		// (set) Token: 0x060133E1 RID: 78817 RVA: 0x001C4BE9 File Offset: 0x001C2DE9
		public unsafe string VolumeName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FHoudiniGeoPartObject.__PropertyOffset_VolumeName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FHoudiniGeoPartObject.__PropertyOffset_VolumeName)), value);
			}
		}

		// Token: 0x17004ADA RID: 19162
		// (get) Token: 0x060133E2 RID: 78818 RVA: 0x001C4BFE File Offset: 0x001C2DFE
		// (set) Token: 0x060133E3 RID: 78819 RVA: 0x001C4C0E File Offset: 0x001C2E0E
		public unsafe bool bHasEditLayers
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniGeoPartObject.__PropertyOffset_bHasEditLayers) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniGeoPartObject.__PropertyOffset_bHasEditLayers) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004ADB RID: 19163
		// (get) Token: 0x060133E4 RID: 78820 RVA: 0x001C4C1F File Offset: 0x001C2E1F
		// (set) Token: 0x060133E5 RID: 78821 RVA: 0x001C4C33 File Offset: 0x001C2E33
		public unsafe string VolumeLayerName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FHoudiniGeoPartObject.__PropertyOffset_VolumeLayerName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FHoudiniGeoPartObject.__PropertyOffset_VolumeLayerName)), value);
			}
		}

		// Token: 0x17004ADC RID: 19164
		// (get) Token: 0x060133E6 RID: 78822 RVA: 0x001C4C48 File Offset: 0x001C2E48
		// (set) Token: 0x060133E7 RID: 78823 RVA: 0x001C4C58 File Offset: 0x001C2E58
		public unsafe int VolumeTileIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniGeoPartObject.__PropertyOffset_VolumeTileIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniGeoPartObject.__PropertyOffset_VolumeTileIndex) = value;
			}
		}

		// Token: 0x17004ADD RID: 19165
		// (get) Token: 0x060133E8 RID: 78824 RVA: 0x001C4C69 File Offset: 0x001C2E69
		// (set) Token: 0x060133E9 RID: 78825 RVA: 0x001C4C79 File Offset: 0x001C2E79
		public unsafe bool bIsVisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniGeoPartObject.__PropertyOffset_bIsVisible) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniGeoPartObject.__PropertyOffset_bIsVisible) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004ADE RID: 19166
		// (get) Token: 0x060133EA RID: 78826 RVA: 0x001C4C8A File Offset: 0x001C2E8A
		// (set) Token: 0x060133EB RID: 78827 RVA: 0x001C4C9A File Offset: 0x001C2E9A
		public unsafe bool bIsEditable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniGeoPartObject.__PropertyOffset_bIsEditable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniGeoPartObject.__PropertyOffset_bIsEditable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004ADF RID: 19167
		// (get) Token: 0x060133EC RID: 78828 RVA: 0x001C4CAB File Offset: 0x001C2EAB
		// (set) Token: 0x060133ED RID: 78829 RVA: 0x001C4CBB File Offset: 0x001C2EBB
		public unsafe bool bIsTemplated
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniGeoPartObject.__PropertyOffset_bIsTemplated) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniGeoPartObject.__PropertyOffset_bIsTemplated) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004AE0 RID: 19168
		// (get) Token: 0x060133EE RID: 78830 RVA: 0x001C4CCC File Offset: 0x001C2ECC
		// (set) Token: 0x060133EF RID: 78831 RVA: 0x001C4CDC File Offset: 0x001C2EDC
		public unsafe bool bIsInstanced
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniGeoPartObject.__PropertyOffset_bIsInstanced) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniGeoPartObject.__PropertyOffset_bIsInstanced) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004AE1 RID: 19169
		// (get) Token: 0x060133F0 RID: 78832 RVA: 0x001C4CED File Offset: 0x001C2EED
		// (set) Token: 0x060133F1 RID: 78833 RVA: 0x001C4CFD File Offset: 0x001C2EFD
		public unsafe bool bHasGeoChanged
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniGeoPartObject.__PropertyOffset_bHasGeoChanged) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniGeoPartObject.__PropertyOffset_bHasGeoChanged) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004AE2 RID: 19170
		// (get) Token: 0x060133F2 RID: 78834 RVA: 0x001C4D0E File Offset: 0x001C2F0E
		// (set) Token: 0x060133F3 RID: 78835 RVA: 0x001C4D1E File Offset: 0x001C2F1E
		public unsafe bool bHasPartChanged
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniGeoPartObject.__PropertyOffset_bHasPartChanged) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniGeoPartObject.__PropertyOffset_bHasPartChanged) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004AE3 RID: 19171
		// (get) Token: 0x060133F4 RID: 78836 RVA: 0x001C4D2F File Offset: 0x001C2F2F
		// (set) Token: 0x060133F5 RID: 78837 RVA: 0x001C4D3F File Offset: 0x001C2F3F
		public unsafe bool bHasTransformChanged
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniGeoPartObject.__PropertyOffset_bHasTransformChanged) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniGeoPartObject.__PropertyOffset_bHasTransformChanged) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004AE4 RID: 19172
		// (get) Token: 0x060133F6 RID: 78838 RVA: 0x001C4D50 File Offset: 0x001C2F50
		// (set) Token: 0x060133F7 RID: 78839 RVA: 0x001C4D60 File Offset: 0x001C2F60
		public unsafe bool bHasMaterialsChanged
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniGeoPartObject.__PropertyOffset_bHasMaterialsChanged) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniGeoPartObject.__PropertyOffset_bHasMaterialsChanged) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004AE5 RID: 19173
		// (get) Token: 0x060133F8 RID: 78840 RVA: 0x001C4D74 File Offset: 0x001C2F74
		// (set) Token: 0x060133F9 RID: 78841 RVA: 0x001C4DB7 File Offset: 0x001C2FB7
		public TArray<FHoudiniMeshSocket> AllMeshSockets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FHoudiniMeshSocket> result;
				if ((result = this._AllMeshSockets) == null)
				{
					result = (this._AllMeshSockets = new TArray<FHoudiniMeshSocket>(base.NativePtr + (IntPtr)FHoudiniGeoPartObject.__PropertyOffset_AllMeshSockets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AllMeshSockets.CopyAssign(value);
			}
		}

		// Token: 0x060133FA RID: 78842 RVA: 0x001C4DC5 File Offset: 0x001C2FC5
		public FHoudiniGeoPartObject()
		{
		}

		// Token: 0x060133FB RID: 78843 RVA: 0x001C4DD0 File Offset: 0x001C2FD0
		public FHoudiniGeoPartObject(int AssetId, string AssetName, int ObjectId, string ObjectName, int GeoId, int PartId, string PartName, bool bHasCustomPartName, TArray<string> SplitGroups, FTransform TransformMatrix, string NodePath, EHoudiniPartType Type, EHoudiniInstancerType InstancerType, string VolumeName, bool bHasEditLayers, string VolumeLayerName, int VolumeTileIndex, bool bIsVisible, bool bIsEditable, bool bIsTemplated, bool bIsInstanced, bool bHasGeoChanged, bool bHasPartChanged, bool bHasTransformChanged, bool bHasMaterialsChanged, TArray<FHoudiniMeshSocket> AllMeshSockets)
		{
			this.AssetId = AssetId;
			this.AssetName = AssetName;
			this.ObjectId = ObjectId;
			this.ObjectName = ObjectName;
			this.GeoId = GeoId;
			this.PartId = PartId;
			this.PartName = PartName;
			this.bHasCustomPartName = bHasCustomPartName;
			this.SplitGroups = SplitGroups;
			this.TransformMatrix = TransformMatrix;
			this.NodePath = NodePath;
			this.Type = Type;
			this.InstancerType = InstancerType;
			this.VolumeName = VolumeName;
			this.bHasEditLayers = bHasEditLayers;
			this.VolumeLayerName = VolumeLayerName;
			this.VolumeTileIndex = VolumeTileIndex;
			this.bIsVisible = bIsVisible;
			this.bIsEditable = bIsEditable;
			this.bIsTemplated = bIsTemplated;
			this.bIsInstanced = bIsInstanced;
			this.bHasGeoChanged = bHasGeoChanged;
			this.bHasPartChanged = bHasPartChanged;
			this.bHasTransformChanged = bHasTransformChanged;
			this.bHasMaterialsChanged = bHasMaterialsChanged;
			this.AllMeshSockets = AllMeshSockets;
		}

		// Token: 0x060133FC RID: 78844 RVA: 0x001C4EB0 File Offset: 0x001C30B0
		protected override IntPtr GetUStructPtr()
		{
			return FHoudiniGeoPartObject.StaticStruct();
		}

		// Token: 0x060133FD RID: 78845 RVA: 0x001C4EBC File Offset: 0x001C30BC
		[NullableContext(2)]
		public FHoudiniGeoPartObject(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060133FE RID: 78846 RVA: 0x001C4EC6 File Offset: 0x001C30C6
		public FHoudiniGeoPartObject(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060133FF RID: 78847 RVA: 0x001C4ED1 File Offset: 0x001C30D1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHoudiniGeoPartObject(Pointer, false, true);
		}

		// Token: 0x06013400 RID: 78848 RVA: 0x001C4EDB File Offset: 0x001C30DB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHoudiniGeoPartObject(Pointer, MemoryOwner);
		}

		// Token: 0x0400A62C RID: 42540
		public const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniGeoPartObject";

		// Token: 0x0400A62D RID: 42541
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A62E RID: 42542
		internal static int __PropertyOffset_AssetId;

		// Token: 0x0400A62F RID: 42543
		internal static int __PropertyOffset_AssetName;

		// Token: 0x0400A630 RID: 42544
		internal static int __PropertyOffset_ObjectId;

		// Token: 0x0400A631 RID: 42545
		internal static int __PropertyOffset_ObjectName;

		// Token: 0x0400A632 RID: 42546
		internal static int __PropertyOffset_GeoId;

		// Token: 0x0400A633 RID: 42547
		internal static int __PropertyOffset_PartId;

		// Token: 0x0400A634 RID: 42548
		internal static int __PropertyOffset_PartName;

		// Token: 0x0400A635 RID: 42549
		internal static int __PropertyOffset_bHasCustomPartName;

		// Token: 0x0400A636 RID: 42550
		internal static int __PropertyOffset_SplitGroups;

		// Token: 0x0400A637 RID: 42551
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _SplitGroups;

		// Token: 0x0400A638 RID: 42552
		internal static int __PropertyOffset_TransformMatrix;

		// Token: 0x0400A639 RID: 42553
		internal static int __PropertyOffset_NodePath;

		// Token: 0x0400A63A RID: 42554
		internal static int __PropertyOffset_Type;

		// Token: 0x0400A63B RID: 42555
		internal static int __PropertyOffset_InstancerType;

		// Token: 0x0400A63C RID: 42556
		internal static int __PropertyOffset_VolumeName;

		// Token: 0x0400A63D RID: 42557
		internal static int __PropertyOffset_bHasEditLayers;

		// Token: 0x0400A63E RID: 42558
		internal static int __PropertyOffset_VolumeLayerName;

		// Token: 0x0400A63F RID: 42559
		internal static int __PropertyOffset_VolumeTileIndex;

		// Token: 0x0400A640 RID: 42560
		internal static int __PropertyOffset_bIsVisible;

		// Token: 0x0400A641 RID: 42561
		internal static int __PropertyOffset_bIsEditable;

		// Token: 0x0400A642 RID: 42562
		internal static int __PropertyOffset_bIsTemplated;

		// Token: 0x0400A643 RID: 42563
		internal static int __PropertyOffset_bIsInstanced;

		// Token: 0x0400A644 RID: 42564
		internal static int __PropertyOffset_bHasGeoChanged;

		// Token: 0x0400A645 RID: 42565
		internal static int __PropertyOffset_bHasPartChanged;

		// Token: 0x0400A646 RID: 42566
		internal static int __PropertyOffset_bHasTransformChanged;

		// Token: 0x0400A647 RID: 42567
		internal static int __PropertyOffset_bHasMaterialsChanged;

		// Token: 0x0400A648 RID: 42568
		internal static int __PropertyOffset_AllMeshSockets;

		// Token: 0x0400A649 RID: 42569
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FHoudiniMeshSocket> _AllMeshSockets;
	}
}
