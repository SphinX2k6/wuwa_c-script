using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020027D1 RID: 10193
	[UnrealObjectPath("/Script/SimplygonUObjects.RepairSettings")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FRepairSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026076 RID: 155766 RVA: 0x0039AD24 File Offset: 0x00398F24
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRepairSettings._ScriptStructPtr != 0) ? FRepairSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SimplygonUObjects.RepairSettings", ref FRepairSettings._ScriptStructPtr);
		}

		// Token: 0x170092C8 RID: 37576
		// (get) Token: 0x06026077 RID: 155767 RVA: 0x0039AD48 File Offset: 0x00398F48
		// (set) Token: 0x06026078 RID: 155768 RVA: 0x0039AD61 File Offset: 0x00398F61
		public unsafe bool UseTJunctionRemover
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FRepairSettings.__PropertyOffset_UseTJunctionRemover) & FRepairSettings.__PropertyMask_UseTJunctionRemover) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FRepairSettings.__PropertyOffset_UseTJunctionRemover) = ((*(base.NativePtr + (IntPtr)FRepairSettings.__PropertyOffset_UseTJunctionRemover) & ~FRepairSettings.__PropertyMask_UseTJunctionRemover) | (value ? FRepairSettings.__PropertyMask_UseTJunctionRemover : 0));
			}
		}

		// Token: 0x170092C9 RID: 37577
		// (get) Token: 0x06026079 RID: 155769 RVA: 0x0039AD91 File Offset: 0x00398F91
		// (set) Token: 0x0602607A RID: 155770 RVA: 0x0039ADA1 File Offset: 0x00398FA1
		public unsafe float TJuncDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRepairSettings.__PropertyOffset_TJuncDist);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRepairSettings.__PropertyOffset_TJuncDist) = value;
			}
		}

		// Token: 0x170092CA RID: 37578
		// (get) Token: 0x0602607B RID: 155771 RVA: 0x0039ADB2 File Offset: 0x00398FB2
		// (set) Token: 0x0602607C RID: 155772 RVA: 0x0039ADCB File Offset: 0x00398FCB
		public unsafe bool UseWelding
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FRepairSettings.__PropertyOffset_UseWelding) & FRepairSettings.__PropertyMask_UseWelding) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FRepairSettings.__PropertyOffset_UseWelding) = ((*(base.NativePtr + (IntPtr)FRepairSettings.__PropertyOffset_UseWelding) & ~FRepairSettings.__PropertyMask_UseWelding) | (value ? FRepairSettings.__PropertyMask_UseWelding : 0));
			}
		}

		// Token: 0x170092CB RID: 37579
		// (get) Token: 0x0602607D RID: 155773 RVA: 0x0039ADFB File Offset: 0x00398FFB
		// (set) Token: 0x0602607E RID: 155774 RVA: 0x0039AE14 File Offset: 0x00399014
		public unsafe bool WeldOnlyBorderVertices
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FRepairSettings.__PropertyOffset_WeldOnlyBorderVertices) & FRepairSettings.__PropertyMask_WeldOnlyBorderVertices) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FRepairSettings.__PropertyOffset_WeldOnlyBorderVertices) = ((*(base.NativePtr + (IntPtr)FRepairSettings.__PropertyOffset_WeldOnlyBorderVertices) & ~FRepairSettings.__PropertyMask_WeldOnlyBorderVertices) | (value ? FRepairSettings.__PropertyMask_WeldOnlyBorderVertices : 0));
			}
		}

		// Token: 0x170092CC RID: 37580
		// (get) Token: 0x0602607F RID: 155775 RVA: 0x0039AE44 File Offset: 0x00399044
		// (set) Token: 0x06026080 RID: 155776 RVA: 0x0039AE5D File Offset: 0x0039905D
		public unsafe bool WeldOnlyWithinMaterial
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FRepairSettings.__PropertyOffset_WeldOnlyWithinMaterial) & FRepairSettings.__PropertyMask_WeldOnlyWithinMaterial) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FRepairSettings.__PropertyOffset_WeldOnlyWithinMaterial) = ((*(base.NativePtr + (IntPtr)FRepairSettings.__PropertyOffset_WeldOnlyWithinMaterial) & ~FRepairSettings.__PropertyMask_WeldOnlyWithinMaterial) | (value ? FRepairSettings.__PropertyMask_WeldOnlyWithinMaterial : 0));
			}
		}

		// Token: 0x170092CD RID: 37581
		// (get) Token: 0x06026081 RID: 155777 RVA: 0x0039AE8D File Offset: 0x0039908D
		// (set) Token: 0x06026082 RID: 155778 RVA: 0x0039AEA6 File Offset: 0x003990A6
		public unsafe bool WeldOnlyWithinSceneNode
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FRepairSettings.__PropertyOffset_WeldOnlyWithinSceneNode) & FRepairSettings.__PropertyMask_WeldOnlyWithinSceneNode) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FRepairSettings.__PropertyOffset_WeldOnlyWithinSceneNode) = ((*(base.NativePtr + (IntPtr)FRepairSettings.__PropertyOffset_WeldOnlyWithinSceneNode) & ~FRepairSettings.__PropertyMask_WeldOnlyWithinSceneNode) | (value ? FRepairSettings.__PropertyMask_WeldOnlyWithinSceneNode : 0));
			}
		}

		// Token: 0x170092CE RID: 37582
		// (get) Token: 0x06026083 RID: 155779 RVA: 0x0039AED6 File Offset: 0x003990D6
		// (set) Token: 0x06026084 RID: 155780 RVA: 0x0039AEEF File Offset: 0x003990EF
		public unsafe bool WeldOnlyBetweenSceneNodes
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FRepairSettings.__PropertyOffset_WeldOnlyBetweenSceneNodes) & FRepairSettings.__PropertyMask_WeldOnlyBetweenSceneNodes) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FRepairSettings.__PropertyOffset_WeldOnlyBetweenSceneNodes) = ((*(base.NativePtr + (IntPtr)FRepairSettings.__PropertyOffset_WeldOnlyBetweenSceneNodes) & ~FRepairSettings.__PropertyMask_WeldOnlyBetweenSceneNodes) | (value ? FRepairSettings.__PropertyMask_WeldOnlyBetweenSceneNodes : 0));
			}
		}

		// Token: 0x170092CF RID: 37583
		// (get) Token: 0x06026085 RID: 155781 RVA: 0x0039AF1F File Offset: 0x0039911F
		// (set) Token: 0x06026086 RID: 155782 RVA: 0x0039AF2F File Offset: 0x0039912F
		public unsafe float WeldDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRepairSettings.__PropertyOffset_WeldDist);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRepairSettings.__PropertyOffset_WeldDist) = value;
			}
		}

		// Token: 0x170092D0 RID: 37584
		// (get) Token: 0x06026087 RID: 155783 RVA: 0x0039AF40 File Offset: 0x00399140
		// (set) Token: 0x06026088 RID: 155784 RVA: 0x0039AF50 File Offset: 0x00399150
		public unsafe int ProgressivePasses
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRepairSettings.__PropertyOffset_ProgressivePasses);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRepairSettings.__PropertyOffset_ProgressivePasses) = value;
			}
		}

		// Token: 0x06026089 RID: 155785 RVA: 0x0039AF61 File Offset: 0x00399161
		public FRepairSettings()
		{
		}

		// Token: 0x0602608A RID: 155786 RVA: 0x0039AF6C File Offset: 0x0039916C
		public FRepairSettings(bool UseTJunctionRemover, float TJuncDist, bool UseWelding, bool WeldOnlyBorderVertices, bool WeldOnlyWithinMaterial, bool WeldOnlyWithinSceneNode, bool WeldOnlyBetweenSceneNodes, float WeldDist, int ProgressivePasses)
		{
			this.UseTJunctionRemover = UseTJunctionRemover;
			this.TJuncDist = TJuncDist;
			this.UseWelding = UseWelding;
			this.WeldOnlyBorderVertices = WeldOnlyBorderVertices;
			this.WeldOnlyWithinMaterial = WeldOnlyWithinMaterial;
			this.WeldOnlyWithinSceneNode = WeldOnlyWithinSceneNode;
			this.WeldOnlyBetweenSceneNodes = WeldOnlyBetweenSceneNodes;
			this.WeldDist = WeldDist;
			this.ProgressivePasses = ProgressivePasses;
		}

		// Token: 0x0602608B RID: 155787 RVA: 0x0039AFC4 File Offset: 0x003991C4
		protected override IntPtr GetUStructPtr()
		{
			return FRepairSettings.StaticStruct();
		}

		// Token: 0x0602608C RID: 155788 RVA: 0x0039AFD0 File Offset: 0x003991D0
		[NullableContext(2)]
		public FRepairSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602608D RID: 155789 RVA: 0x0039AFDA File Offset: 0x003991DA
		public FRepairSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602608E RID: 155790 RVA: 0x0039AFE5 File Offset: 0x003991E5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRepairSettings(Pointer, false, true);
		}

		// Token: 0x0602608F RID: 155791 RVA: 0x0039AFEF File Offset: 0x003991EF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRepairSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04014C37 RID: 85047
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SimplygonUObjects.RepairSettings";

		// Token: 0x04014C38 RID: 85048
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014C39 RID: 85049
		internal static int __PropertyOffset_UseTJunctionRemover;

		// Token: 0x04014C3A RID: 85050
		internal static byte __PropertyMask_UseTJunctionRemover;

		// Token: 0x04014C3B RID: 85051
		internal static int __PropertyOffset_TJuncDist;

		// Token: 0x04014C3C RID: 85052
		internal static int __PropertyOffset_UseWelding;

		// Token: 0x04014C3D RID: 85053
		internal static byte __PropertyMask_UseWelding;

		// Token: 0x04014C3E RID: 85054
		internal static int __PropertyOffset_WeldOnlyBorderVertices;

		// Token: 0x04014C3F RID: 85055
		internal static byte __PropertyMask_WeldOnlyBorderVertices;

		// Token: 0x04014C40 RID: 85056
		internal static int __PropertyOffset_WeldOnlyWithinMaterial;

		// Token: 0x04014C41 RID: 85057
		internal static byte __PropertyMask_WeldOnlyWithinMaterial;

		// Token: 0x04014C42 RID: 85058
		internal static int __PropertyOffset_WeldOnlyWithinSceneNode;

		// Token: 0x04014C43 RID: 85059
		internal static byte __PropertyMask_WeldOnlyWithinSceneNode;

		// Token: 0x04014C44 RID: 85060
		internal static int __PropertyOffset_WeldOnlyBetweenSceneNodes;

		// Token: 0x04014C45 RID: 85061
		internal static byte __PropertyMask_WeldOnlyBetweenSceneNodes;

		// Token: 0x04014C46 RID: 85062
		internal static int __PropertyOffset_WeldDist;

		// Token: 0x04014C47 RID: 85063
		internal static int __PropertyOffset_ProgressivePasses;
	}
}
