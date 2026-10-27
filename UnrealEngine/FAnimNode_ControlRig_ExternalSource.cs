using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020004B1 RID: 1201
	[UnrealObjectPath("/Script/ControlRig.AnimNode_ControlRig_ExternalSource")]
	[UnrealStructLayout(392, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 392)]
	public class FAnimNode_ControlRig_ExternalSource : FAnimNode_ControlRigBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003FF0 RID: 16368 RVA: 0x000602BF File Offset: 0x0005E4BF
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_ControlRig_ExternalSource._ScriptStructPtr != 0) ? FAnimNode_ControlRig_ExternalSource._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.AnimNode_ControlRig_ExternalSource", ref FAnimNode_ControlRig_ExternalSource._ScriptStructPtr);
		}

		// Token: 0x17000FA5 RID: 4005
		// (get) Token: 0x06003FF1 RID: 16369 RVA: 0x000602E3 File Offset: 0x0005E4E3
		// (set) Token: 0x06003FF2 RID: 16370 RVA: 0x000602F7 File Offset: 0x0005E4F7
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UControlRig> ControlRig
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_ControlRig_ExternalSource.__PropertyOffset_ControlRig);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_ControlRig_ExternalSource.__PropertyOffset_ControlRig) = value;
			}
		}

		// Token: 0x06003FF3 RID: 16371 RVA: 0x0006030C File Offset: 0x0005E50C
		public FAnimNode_ControlRig_ExternalSource()
		{
		}

		// Token: 0x06003FF4 RID: 16372 RVA: 0x00060314 File Offset: 0x0005E514
		[NullableContext(1)]
		public FAnimNode_ControlRig_ExternalSource([Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UControlRig> ControlRig, FPoseLink Source, TMap<FName, ushort> ControlRigBoneMapping, TMap<FName, ushort> ControlRigCurveMapping, TMap<FName, ushort> InputToCurveMappingUIDs, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UNodeMappingContainer> NodeMappingContainer, FControlRigIOSettings InputSettings, FControlRigIOSettings OutputSettings, bool bExecute, TArray<FName> SourcePropertyNames, TArray<FName> DestPropertyNames, UObject TargetInstance)
		{
			this.ControlRig = ControlRig;
			base.Source = Source;
			base.ControlRigBoneMapping = ControlRigBoneMapping;
			base.ControlRigCurveMapping = ControlRigCurveMapping;
			base.InputToCurveMappingUIDs = InputToCurveMappingUIDs;
			base.NodeMappingContainer = NodeMappingContainer;
			base.InputSettings = InputSettings;
			base.OutputSettings = OutputSettings;
			base.bExecute = bExecute;
			base.SourcePropertyNames = SourcePropertyNames;
			base.DestPropertyNames = DestPropertyNames;
			base.TargetInstance = TargetInstance;
		}

		// Token: 0x06003FF5 RID: 16373 RVA: 0x00060384 File Offset: 0x0005E584
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_ControlRig_ExternalSource.StaticStruct();
		}

		// Token: 0x06003FF6 RID: 16374 RVA: 0x00060390 File Offset: 0x0005E590
		[NullableContext(2)]
		public FAnimNode_ControlRig_ExternalSource(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003FF7 RID: 16375 RVA: 0x0006039A File Offset: 0x0005E59A
		public FAnimNode_ControlRig_ExternalSource(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003FF8 RID: 16376 RVA: 0x000603A5 File Offset: 0x0005E5A5
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_ControlRig_ExternalSource(Pointer, false, true);
		}

		// Token: 0x06003FF9 RID: 16377 RVA: 0x000603AF File Offset: 0x0005E5AF
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_ControlRig_ExternalSource(Pointer, MemoryOwner);
		}

		// Token: 0x04001E98 RID: 7832
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.AnimNode_ControlRig_ExternalSource";

		// Token: 0x04001E99 RID: 7833
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001E9A RID: 7834
		internal static int __PropertyOffset_ControlRig;
	}
}
