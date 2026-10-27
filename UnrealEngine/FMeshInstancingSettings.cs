using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000EA3 RID: 3747
	[UnrealObjectPath("/Script/Engine.MeshInstancingSettings")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FMeshInstancingSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CA59 RID: 51801 RVA: 0x00126A81 File Offset: 0x00124C81
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMeshInstancingSettings._ScriptStructPtr != 0) ? FMeshInstancingSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MeshInstancingSettings", ref FMeshInstancingSettings._ScriptStructPtr);
		}

		// Token: 0x17002F7C RID: 12156
		// (get) Token: 0x0600CA5A RID: 51802 RVA: 0x00126AA5 File Offset: 0x00124CA5
		// (set) Token: 0x0600CA5B RID: 51803 RVA: 0x00126AB9 File Offset: 0x00124CB9
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<AActor> ActorClassToUse
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshInstancingSettings.__PropertyOffset_ActorClassToUse);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FMeshInstancingSettings.__PropertyOffset_ActorClassToUse) = value;
			}
		}

		// Token: 0x17002F7D RID: 12157
		// (get) Token: 0x0600CA5C RID: 51804 RVA: 0x00126ACE File Offset: 0x00124CCE
		// (set) Token: 0x0600CA5D RID: 51805 RVA: 0x00126ADE File Offset: 0x00124CDE
		public unsafe int InstanceReplacementThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshInstancingSettings.__PropertyOffset_InstanceReplacementThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshInstancingSettings.__PropertyOffset_InstanceReplacementThreshold) = value;
			}
		}

		// Token: 0x17002F7E RID: 12158
		// (get) Token: 0x0600CA5E RID: 51806 RVA: 0x00126AEF File Offset: 0x00124CEF
		// (set) Token: 0x0600CA5F RID: 51807 RVA: 0x00126AFF File Offset: 0x00124CFF
		public unsafe EMeshInstancingReplacementMethod MeshReplacementMethod
		{
			get
			{
				return (EMeshInstancingReplacementMethod)(*(base.NativePtr + (IntPtr)FMeshInstancingSettings.__PropertyOffset_MeshReplacementMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshInstancingSettings.__PropertyOffset_MeshReplacementMethod) = (byte)value;
			}
		}

		// Token: 0x17002F7F RID: 12159
		// (get) Token: 0x0600CA60 RID: 51808 RVA: 0x00126B10 File Offset: 0x00124D10
		// (set) Token: 0x0600CA61 RID: 51809 RVA: 0x00126B20 File Offset: 0x00124D20
		public unsafe bool bSkipMeshesWithVertexColors
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshInstancingSettings.__PropertyOffset_bSkipMeshesWithVertexColors) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshInstancingSettings.__PropertyOffset_bSkipMeshesWithVertexColors) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F80 RID: 12160
		// (get) Token: 0x0600CA62 RID: 51810 RVA: 0x00126B31 File Offset: 0x00124D31
		// (set) Token: 0x0600CA63 RID: 51811 RVA: 0x00126B41 File Offset: 0x00124D41
		public unsafe bool bUseHLODVolumes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshInstancingSettings.__PropertyOffset_bUseHLODVolumes) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshInstancingSettings.__PropertyOffset_bUseHLODVolumes) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F81 RID: 12161
		// (get) Token: 0x0600CA64 RID: 51812 RVA: 0x00126B52 File Offset: 0x00124D52
		// (set) Token: 0x0600CA65 RID: 51813 RVA: 0x00126B66 File Offset: 0x00124D66
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UInstancedStaticMeshComponent> ISMComponentToUse
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshInstancingSettings.__PropertyOffset_ISMComponentToUse);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FMeshInstancingSettings.__PropertyOffset_ISMComponentToUse) = value;
			}
		}

		// Token: 0x0600CA66 RID: 51814 RVA: 0x00126B7B File Offset: 0x00124D7B
		public FMeshInstancingSettings()
		{
		}

		// Token: 0x0600CA67 RID: 51815 RVA: 0x00126B83 File Offset: 0x00124D83
		public FMeshInstancingSettings([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> ActorClassToUse, int InstanceReplacementThreshold, EMeshInstancingReplacementMethod MeshReplacementMethod, bool bSkipMeshesWithVertexColors, bool bUseHLODVolumes, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UInstancedStaticMeshComponent> ISMComponentToUse)
		{
			this.ActorClassToUse = ActorClassToUse;
			this.InstanceReplacementThreshold = InstanceReplacementThreshold;
			this.MeshReplacementMethod = MeshReplacementMethod;
			this.bSkipMeshesWithVertexColors = bSkipMeshesWithVertexColors;
			this.bUseHLODVolumes = bUseHLODVolumes;
			this.ISMComponentToUse = ISMComponentToUse;
		}

		// Token: 0x0600CA68 RID: 51816 RVA: 0x00126BB8 File Offset: 0x00124DB8
		protected override IntPtr GetUStructPtr()
		{
			return FMeshInstancingSettings.StaticStruct();
		}

		// Token: 0x0600CA69 RID: 51817 RVA: 0x00126BC4 File Offset: 0x00124DC4
		[NullableContext(2)]
		public FMeshInstancingSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CA6A RID: 51818 RVA: 0x00126BCE File Offset: 0x00124DCE
		public FMeshInstancingSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CA6B RID: 51819 RVA: 0x00126BD9 File Offset: 0x00124DD9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMeshInstancingSettings(Pointer, false, true);
		}

		// Token: 0x0600CA6C RID: 51820 RVA: 0x00126BE3 File Offset: 0x00124DE3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMeshInstancingSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04006CEF RID: 27887
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.MeshInstancingSettings";

		// Token: 0x04006CF0 RID: 27888
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006CF1 RID: 27889
		internal static int __PropertyOffset_ActorClassToUse;

		// Token: 0x04006CF2 RID: 27890
		internal static int __PropertyOffset_InstanceReplacementThreshold;

		// Token: 0x04006CF3 RID: 27891
		internal static int __PropertyOffset_MeshReplacementMethod;

		// Token: 0x04006CF4 RID: 27892
		internal static int __PropertyOffset_bSkipMeshesWithVertexColors;

		// Token: 0x04006CF5 RID: 27893
		internal static int __PropertyOffset_bUseHLODVolumes;

		// Token: 0x04006CF6 RID: 27894
		internal static int __PropertyOffset_ISMComponentToUse;
	}
}
