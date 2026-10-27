using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004AF RID: 1199
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.AnimNode_ControlRigBase")]
	[UnrealStructLayout(384, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 384)]
	public class FAnimNode_ControlRigBase : FAnimNode_CustomProperty, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003FCE RID: 16334 RVA: 0x0005FEB0 File Offset: 0x0005E0B0
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_ControlRigBase._ScriptStructPtr != 0) ? FAnimNode_ControlRigBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.AnimNode_ControlRigBase", ref FAnimNode_ControlRigBase._ScriptStructPtr);
		}

		// Token: 0x17000F9C RID: 3996
		// (get) Token: 0x06003FCF RID: 16335 RVA: 0x0005FED4 File Offset: 0x0005E0D4
		// (set) Token: 0x06003FD0 RID: 16336 RVA: 0x0005FF17 File Offset: 0x0005E117
		public FPoseLink Source
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._Source) == null)
				{
					result = (this._Source = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_ControlRigBase.__PropertyOffset_Source, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_ControlRigBase.__PropertyOffset_Source, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000F9D RID: 3997
		// (get) Token: 0x06003FD1 RID: 16337 RVA: 0x0005FF38 File Offset: 0x0005E138
		// (set) Token: 0x06003FD2 RID: 16338 RVA: 0x0005FF7B File Offset: 0x0005E17B
		public TMap<FName, ushort> ControlRigBoneMapping
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, ushort> result;
				if ((result = this._ControlRigBoneMapping) == null)
				{
					result = (this._ControlRigBoneMapping = new TMap<FName, ushort>(base.NativePtr + (IntPtr)FAnimNode_ControlRigBase.__PropertyOffset_ControlRigBoneMapping, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ControlRigBoneMapping.CopyAssign(value);
			}
		}

		// Token: 0x17000F9E RID: 3998
		// (get) Token: 0x06003FD3 RID: 16339 RVA: 0x0005FF8C File Offset: 0x0005E18C
		// (set) Token: 0x06003FD4 RID: 16340 RVA: 0x0005FFCF File Offset: 0x0005E1CF
		public TMap<FName, ushort> ControlRigCurveMapping
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, ushort> result;
				if ((result = this._ControlRigCurveMapping) == null)
				{
					result = (this._ControlRigCurveMapping = new TMap<FName, ushort>(base.NativePtr + (IntPtr)FAnimNode_ControlRigBase.__PropertyOffset_ControlRigCurveMapping, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ControlRigCurveMapping.CopyAssign(value);
			}
		}

		// Token: 0x17000F9F RID: 3999
		// (get) Token: 0x06003FD5 RID: 16341 RVA: 0x0005FFE0 File Offset: 0x0005E1E0
		// (set) Token: 0x06003FD6 RID: 16342 RVA: 0x00060023 File Offset: 0x0005E223
		public TMap<FName, ushort> InputToCurveMappingUIDs
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, ushort> result;
				if ((result = this._InputToCurveMappingUIDs) == null)
				{
					result = (this._InputToCurveMappingUIDs = new TMap<FName, ushort>(base.NativePtr + (IntPtr)FAnimNode_ControlRigBase.__PropertyOffset_InputToCurveMappingUIDs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.InputToCurveMappingUIDs.CopyAssign(value);
			}
		}

		// Token: 0x17000FA0 RID: 4000
		// (get) Token: 0x06003FD7 RID: 16343 RVA: 0x00060031 File Offset: 0x0005E231
		// (set) Token: 0x06003FD8 RID: 16344 RVA: 0x00060045 File Offset: 0x0005E245
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UNodeMappingContainer> NodeMappingContainer
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_ControlRigBase.__PropertyOffset_NodeMappingContainer);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_ControlRigBase.__PropertyOffset_NodeMappingContainer) = value;
			}
		}

		// Token: 0x17000FA1 RID: 4001
		// (get) Token: 0x06003FD9 RID: 16345 RVA: 0x0006005C File Offset: 0x0005E25C
		// (set) Token: 0x06003FDA RID: 16346 RVA: 0x0006009F File Offset: 0x0005E29F
		public FControlRigIOSettings InputSettings
		{
			get
			{
				base.FastCheckIsValid();
				FControlRigIOSettings result;
				if ((result = this._InputSettings) == null)
				{
					result = (this._InputSettings = new FControlRigIOSettings(base.NativePtr + (IntPtr)FAnimNode_ControlRigBase.__PropertyOffset_InputSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FControlRigIOSettings.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_ControlRigBase.__PropertyOffset_InputSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000FA2 RID: 4002
		// (get) Token: 0x06003FDB RID: 16347 RVA: 0x000600C0 File Offset: 0x0005E2C0
		// (set) Token: 0x06003FDC RID: 16348 RVA: 0x00060103 File Offset: 0x0005E303
		public FControlRigIOSettings OutputSettings
		{
			get
			{
				base.FastCheckIsValid();
				FControlRigIOSettings result;
				if ((result = this._OutputSettings) == null)
				{
					result = (this._OutputSettings = new FControlRigIOSettings(base.NativePtr + (IntPtr)FAnimNode_ControlRigBase.__PropertyOffset_OutputSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FControlRigIOSettings.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_ControlRigBase.__PropertyOffset_OutputSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000FA3 RID: 4003
		// (get) Token: 0x06003FDD RID: 16349 RVA: 0x00060124 File Offset: 0x0005E324
		// (set) Token: 0x06003FDE RID: 16350 RVA: 0x00060134 File Offset: 0x0005E334
		public unsafe bool bExecute
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_ControlRigBase.__PropertyOffset_bExecute) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_ControlRigBase.__PropertyOffset_bExecute) = (value ? 1 : 0);
			}
		}

		// Token: 0x06003FDF RID: 16351 RVA: 0x00060145 File Offset: 0x0005E345
		public FAnimNode_ControlRigBase()
		{
		}

		// Token: 0x06003FE0 RID: 16352 RVA: 0x00060150 File Offset: 0x0005E350
		public FAnimNode_ControlRigBase(FPoseLink Source, TMap<FName, ushort> ControlRigBoneMapping, TMap<FName, ushort> ControlRigCurveMapping, TMap<FName, ushort> InputToCurveMappingUIDs, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UNodeMappingContainer> NodeMappingContainer, FControlRigIOSettings InputSettings, FControlRigIOSettings OutputSettings, bool bExecute, TArray<FName> SourcePropertyNames, TArray<FName> DestPropertyNames, UObject TargetInstance)
		{
			this.Source = Source;
			this.ControlRigBoneMapping = ControlRigBoneMapping;
			this.ControlRigCurveMapping = ControlRigCurveMapping;
			this.InputToCurveMappingUIDs = InputToCurveMappingUIDs;
			this.NodeMappingContainer = NodeMappingContainer;
			this.InputSettings = InputSettings;
			this.OutputSettings = OutputSettings;
			this.bExecute = bExecute;
			base.SourcePropertyNames = SourcePropertyNames;
			base.DestPropertyNames = DestPropertyNames;
			base.TargetInstance = TargetInstance;
		}

		// Token: 0x06003FE1 RID: 16353 RVA: 0x000601B8 File Offset: 0x0005E3B8
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_ControlRigBase.StaticStruct();
		}

		// Token: 0x06003FE2 RID: 16354 RVA: 0x000601C4 File Offset: 0x0005E3C4
		[NullableContext(2)]
		public FAnimNode_ControlRigBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003FE3 RID: 16355 RVA: 0x000601CE File Offset: 0x0005E3CE
		public FAnimNode_ControlRigBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003FE4 RID: 16356 RVA: 0x000601D9 File Offset: 0x0005E3D9
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_ControlRigBase(Pointer, false, true);
		}

		// Token: 0x06003FE5 RID: 16357 RVA: 0x000601E3 File Offset: 0x0005E3E3
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_ControlRigBase(Pointer, MemoryOwner);
		}

		// Token: 0x04001E84 RID: 7812
		public new const string __ObjectPath = "/Script/ControlRig.AnimNode_ControlRigBase";

		// Token: 0x04001E85 RID: 7813
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001E86 RID: 7814
		internal static int __PropertyOffset_Source;

		// Token: 0x04001E87 RID: 7815
		[Nullable(2)]
		private FPoseLink _Source;

		// Token: 0x04001E88 RID: 7816
		internal static int __PropertyOffset_ControlRigBoneMapping;

		// Token: 0x04001E89 RID: 7817
		[Nullable(2)]
		private TMap<FName, ushort> _ControlRigBoneMapping;

		// Token: 0x04001E8A RID: 7818
		internal static int __PropertyOffset_ControlRigCurveMapping;

		// Token: 0x04001E8B RID: 7819
		[Nullable(2)]
		private TMap<FName, ushort> _ControlRigCurveMapping;

		// Token: 0x04001E8C RID: 7820
		internal static int __PropertyOffset_InputToCurveMappingUIDs;

		// Token: 0x04001E8D RID: 7821
		[Nullable(2)]
		private TMap<FName, ushort> _InputToCurveMappingUIDs;

		// Token: 0x04001E8E RID: 7822
		internal static int __PropertyOffset_NodeMappingContainer;

		// Token: 0x04001E8F RID: 7823
		internal static int __PropertyOffset_InputSettings;

		// Token: 0x04001E90 RID: 7824
		[Nullable(2)]
		private FControlRigIOSettings _InputSettings;

		// Token: 0x04001E91 RID: 7825
		internal static int __PropertyOffset_OutputSettings;

		// Token: 0x04001E92 RID: 7826
		[Nullable(2)]
		private FControlRigIOSettings _OutputSettings;

		// Token: 0x04001E93 RID: 7827
		internal static int __PropertyOffset_bExecute;
	}
}
