using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002F4 RID: 756
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_RBF")]
	[UnrealStructLayout(448, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 448)]
	public class FAnimNode_RBF : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002B1B RID: 11035 RVA: 0x0004197C File Offset: 0x0003FB7C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_RBF._ScriptStructPtr != 0) ? FAnimNode_RBF._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_RBF", ref FAnimNode_RBF._ScriptStructPtr);
		}

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x06002B1C RID: 11036 RVA: 0x000419A0 File Offset: 0x0003FBA0
		// (set) Token: 0x06002B1D RID: 11037 RVA: 0x000419E3 File Offset: 0x0003FBE3
		public FComponentSpacePoseLink ComponentPose
		{
			get
			{
				base.FastCheckIsValid();
				FComponentSpacePoseLink result;
				if ((result = this._ComponentPose) == null)
				{
					result = (this._ComponentPose = new FComponentSpacePoseLink(base.NativePtr + (IntPtr)FAnimNode_RBF.__PropertyOffset_ComponentPose, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FComponentSpacePoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_RBF.__PropertyOffset_ComponentPose, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x06002B1E RID: 11038 RVA: 0x00041A04 File Offset: 0x0003FC04
		// (set) Token: 0x06002B1F RID: 11039 RVA: 0x00041A14 File Offset: 0x0003FC14
		public unsafe ERBFNodeSolveMode SolveMode
		{
			get
			{
				return (ERBFNodeSolveMode)(*(base.NativePtr + (IntPtr)FAnimNode_RBF.__PropertyOffset_SolveMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_RBF.__PropertyOffset_SolveMode) = (byte)value;
			}
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x06002B20 RID: 11040 RVA: 0x00041A25 File Offset: 0x0003FC25
		// (set) Token: 0x06002B21 RID: 11041 RVA: 0x00041A35 File Offset: 0x0003FC35
		public unsafe bool bEnableNode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_RBF.__PropertyOffset_bEnableNode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_RBF.__PropertyOffset_bEnableNode) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x06002B22 RID: 11042 RVA: 0x00041A48 File Offset: 0x0003FC48
		// (set) Token: 0x06002B23 RID: 11043 RVA: 0x00041A8B File Offset: 0x0003FC8B
		public FPerPlatformInt MaxLOD
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformInt result;
				if ((result = this._MaxLOD) == null)
				{
					result = (this._MaxLOD = new FPerPlatformInt(base.NativePtr + (IntPtr)FAnimNode_RBF.__PropertyOffset_MaxLOD, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformInt.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_RBF.__PropertyOffset_MaxLOD, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x06002B24 RID: 11044 RVA: 0x00041AAC File Offset: 0x0003FCAC
		// (set) Token: 0x06002B25 RID: 11045 RVA: 0x00041AC0 File Offset: 0x0003FCC0
		[Nullable(2)]
		public unsafe URBFPrecomputations PrecomputationCaches
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<URBFPrecomputations>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_RBF.__PropertyOffset_PrecomputationCaches);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_RBF.__PropertyOffset_PrecomputationCaches, value);
			}
		}

		// Token: 0x06002B26 RID: 11046 RVA: 0x00041AD5 File Offset: 0x0003FCD5
		public FAnimNode_RBF()
		{
		}

		// Token: 0x06002B27 RID: 11047 RVA: 0x00041ADD File Offset: 0x0003FCDD
		public FAnimNode_RBF(FComponentSpacePoseLink ComponentPose, ERBFNodeSolveMode SolveMode, bool bEnableNode, FPerPlatformInt MaxLOD, URBFPrecomputations PrecomputationCaches)
		{
			this.ComponentPose = ComponentPose;
			this.SolveMode = SolveMode;
			this.bEnableNode = bEnableNode;
			this.MaxLOD = MaxLOD;
			this.PrecomputationCaches = PrecomputationCaches;
		}

		// Token: 0x06002B28 RID: 11048 RVA: 0x00041B0A File Offset: 0x0003FD0A
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_RBF.StaticStruct();
		}

		// Token: 0x06002B29 RID: 11049 RVA: 0x00041B16 File Offset: 0x0003FD16
		[NullableContext(2)]
		public FAnimNode_RBF(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002B2A RID: 11050 RVA: 0x00041B20 File Offset: 0x0003FD20
		public FAnimNode_RBF(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002B2B RID: 11051 RVA: 0x00041B2B File Offset: 0x0003FD2B
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_RBF(Pointer, false, true);
		}

		// Token: 0x06002B2C RID: 11052 RVA: 0x00041B35 File Offset: 0x0003FD35
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_RBF(Pointer, MemoryOwner);
		}

		// Token: 0x04001182 RID: 4482
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_RBF";

		// Token: 0x04001183 RID: 4483
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001184 RID: 4484
		internal static int __PropertyOffset_ComponentPose;

		// Token: 0x04001185 RID: 4485
		[Nullable(2)]
		private FComponentSpacePoseLink _ComponentPose;

		// Token: 0x04001186 RID: 4486
		internal static int __PropertyOffset_SolveMode;

		// Token: 0x04001187 RID: 4487
		internal static int __PropertyOffset_bEnableNode;

		// Token: 0x04001188 RID: 4488
		internal static int __PropertyOffset_MaxLOD;

		// Token: 0x04001189 RID: 4489
		[Nullable(2)]
		private FPerPlatformInt _MaxLOD;

		// Token: 0x0400118A RID: 4490
		internal static int __PropertyOffset_PrecomputationCaches;
	}
}
