using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006A3 RID: 1699
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_PointSimulation")]
	[UnrealStructLayout(512, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 512)]
	public class FRigUnit_PointSimulation : FRigUnit_SimBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005A57 RID: 23127 RVA: 0x00081B1C File Offset: 0x0007FD1C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_PointSimulation._ScriptStructPtr != 0) ? FRigUnit_PointSimulation._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_PointSimulation", ref FRigUnit_PointSimulation._ScriptStructPtr);
		}

		// Token: 0x1700157D RID: 5501
		// (get) Token: 0x06005A58 RID: 23128 RVA: 0x00081B40 File Offset: 0x0007FD40
		// (set) Token: 0x06005A59 RID: 23129 RVA: 0x00081B83 File Offset: 0x0007FD83
		public TArray<FCRSimPoint> Points
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCRSimPoint> result;
				if ((result = this._Points) == null)
				{
					result = (this._Points = new TArray<FCRSimPoint>(base.NativePtr + (IntPtr)FRigUnit_PointSimulation.__PropertyOffset_Points, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Points.CopyAssign(value);
			}
		}

		// Token: 0x1700157E RID: 5502
		// (get) Token: 0x06005A5A RID: 23130 RVA: 0x00081B94 File Offset: 0x0007FD94
		// (set) Token: 0x06005A5B RID: 23131 RVA: 0x00081BD7 File Offset: 0x0007FDD7
		public TArray<FCRSimLinearSpring> Links
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCRSimLinearSpring> result;
				if ((result = this._Links) == null)
				{
					result = (this._Links = new TArray<FCRSimLinearSpring>(base.NativePtr + (IntPtr)FRigUnit_PointSimulation.__PropertyOffset_Links, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Links.CopyAssign(value);
			}
		}

		// Token: 0x1700157F RID: 5503
		// (get) Token: 0x06005A5C RID: 23132 RVA: 0x00081BE8 File Offset: 0x0007FDE8
		// (set) Token: 0x06005A5D RID: 23133 RVA: 0x00081C2B File Offset: 0x0007FE2B
		public TArray<FCRSimPointForce> Forces
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCRSimPointForce> result;
				if ((result = this._Forces) == null)
				{
					result = (this._Forces = new TArray<FCRSimPointForce>(base.NativePtr + (IntPtr)FRigUnit_PointSimulation.__PropertyOffset_Forces, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Forces.CopyAssign(value);
			}
		}

		// Token: 0x17001580 RID: 5504
		// (get) Token: 0x06005A5E RID: 23134 RVA: 0x00081C3C File Offset: 0x0007FE3C
		// (set) Token: 0x06005A5F RID: 23135 RVA: 0x00081C7F File Offset: 0x0007FE7F
		public TArray<FCRSimSoftCollision> CollisionVolumes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCRSimSoftCollision> result;
				if ((result = this._CollisionVolumes) == null)
				{
					result = (this._CollisionVolumes = new TArray<FCRSimSoftCollision>(base.NativePtr + (IntPtr)FRigUnit_PointSimulation.__PropertyOffset_CollisionVolumes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CollisionVolumes.CopyAssign(value);
			}
		}

		// Token: 0x17001581 RID: 5505
		// (get) Token: 0x06005A60 RID: 23136 RVA: 0x00081C8D File Offset: 0x0007FE8D
		// (set) Token: 0x06005A61 RID: 23137 RVA: 0x00081C9D File Offset: 0x0007FE9D
		public unsafe float SimulatedStepsPerSecond
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_PointSimulation.__PropertyOffset_SimulatedStepsPerSecond);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_PointSimulation.__PropertyOffset_SimulatedStepsPerSecond) = value;
			}
		}

		// Token: 0x17001582 RID: 5506
		// (get) Token: 0x06005A62 RID: 23138 RVA: 0x00081CAE File Offset: 0x0007FEAE
		// (set) Token: 0x06005A63 RID: 23139 RVA: 0x00081CBE File Offset: 0x0007FEBE
		public unsafe ECRSimPointIntegrateType IntegratorType
		{
			get
			{
				return (ECRSimPointIntegrateType)(*(base.NativePtr + (IntPtr)FRigUnit_PointSimulation.__PropertyOffset_IntegratorType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_PointSimulation.__PropertyOffset_IntegratorType) = (byte)value;
			}
		}

		// Token: 0x17001583 RID: 5507
		// (get) Token: 0x06005A64 RID: 23140 RVA: 0x00081CCF File Offset: 0x0007FECF
		// (set) Token: 0x06005A65 RID: 23141 RVA: 0x00081CDF File Offset: 0x0007FEDF
		public unsafe float VerletBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_PointSimulation.__PropertyOffset_VerletBlend);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_PointSimulation.__PropertyOffset_VerletBlend) = value;
			}
		}

		// Token: 0x17001584 RID: 5508
		// (get) Token: 0x06005A66 RID: 23142 RVA: 0x00081CF0 File Offset: 0x0007FEF0
		// (set) Token: 0x06005A67 RID: 23143 RVA: 0x00081D33 File Offset: 0x0007FF33
		public TArray<FRigUnit_PointSimulation_BoneTarget> BoneTargets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRigUnit_PointSimulation_BoneTarget> result;
				if ((result = this._BoneTargets) == null)
				{
					result = (this._BoneTargets = new TArray<FRigUnit_PointSimulation_BoneTarget>(base.NativePtr + (IntPtr)FRigUnit_PointSimulation.__PropertyOffset_BoneTargets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BoneTargets.CopyAssign(value);
			}
		}

		// Token: 0x17001585 RID: 5509
		// (get) Token: 0x06005A68 RID: 23144 RVA: 0x00081D41 File Offset: 0x0007FF41
		// (set) Token: 0x06005A69 RID: 23145 RVA: 0x00081D51 File Offset: 0x0007FF51
		public unsafe bool bLimitLocalPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_PointSimulation.__PropertyOffset_bLimitLocalPosition) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_PointSimulation.__PropertyOffset_bLimitLocalPosition) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001586 RID: 5510
		// (get) Token: 0x06005A6A RID: 23146 RVA: 0x00081D62 File Offset: 0x0007FF62
		// (set) Token: 0x06005A6B RID: 23147 RVA: 0x00081D72 File Offset: 0x0007FF72
		public unsafe bool bPropagateToChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_PointSimulation.__PropertyOffset_bPropagateToChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_PointSimulation.__PropertyOffset_bPropagateToChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001587 RID: 5511
		// (get) Token: 0x06005A6C RID: 23148 RVA: 0x00081D83 File Offset: 0x0007FF83
		// (set) Token: 0x06005A6D RID: 23149 RVA: 0x00081D97 File Offset: 0x0007FF97
		public unsafe FVector PrimaryAimAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_PointSimulation.__PropertyOffset_PrimaryAimAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_PointSimulation.__PropertyOffset_PrimaryAimAxis) = value;
			}
		}

		// Token: 0x17001588 RID: 5512
		// (get) Token: 0x06005A6E RID: 23150 RVA: 0x00081DAC File Offset: 0x0007FFAC
		// (set) Token: 0x06005A6F RID: 23151 RVA: 0x00081DC0 File Offset: 0x0007FFC0
		public unsafe FVector SecondaryAimAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_PointSimulation.__PropertyOffset_SecondaryAimAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_PointSimulation.__PropertyOffset_SecondaryAimAxis) = value;
			}
		}

		// Token: 0x17001589 RID: 5513
		// (get) Token: 0x06005A70 RID: 23152 RVA: 0x00081DD8 File Offset: 0x0007FFD8
		// (set) Token: 0x06005A71 RID: 23153 RVA: 0x00081E1B File Offset: 0x0008001B
		public FRigUnit_PointSimulation_DebugSettings DebugSettings
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_PointSimulation_DebugSettings result;
				if ((result = this._DebugSettings) == null)
				{
					result = (this._DebugSettings = new FRigUnit_PointSimulation_DebugSettings(base.NativePtr + (IntPtr)FRigUnit_PointSimulation.__PropertyOffset_DebugSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_PointSimulation_DebugSettings.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_PointSimulation.__PropertyOffset_DebugSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700158A RID: 5514
		// (get) Token: 0x06005A72 RID: 23154 RVA: 0x00081E3C File Offset: 0x0008003C
		// (set) Token: 0x06005A73 RID: 23155 RVA: 0x00081E7F File Offset: 0x0008007F
		public FCRFourPointBezier Bezier
		{
			get
			{
				base.FastCheckIsValid();
				FCRFourPointBezier result;
				if ((result = this._Bezier) == null)
				{
					result = (this._Bezier = new FCRFourPointBezier(base.NativePtr + (IntPtr)FRigUnit_PointSimulation.__PropertyOffset_Bezier, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCRFourPointBezier.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_PointSimulation.__PropertyOffset_Bezier, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700158B RID: 5515
		// (get) Token: 0x06005A74 RID: 23156 RVA: 0x00081EA0 File Offset: 0x000800A0
		// (set) Token: 0x06005A75 RID: 23157 RVA: 0x00081EE3 File Offset: 0x000800E3
		public FRigUnit_PointSimulation_WorkData WorkData
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_PointSimulation_WorkData result;
				if ((result = this._WorkData) == null)
				{
					result = (this._WorkData = new FRigUnit_PointSimulation_WorkData(base.NativePtr + (IntPtr)FRigUnit_PointSimulation.__PropertyOffset_WorkData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_PointSimulation_WorkData.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_PointSimulation.__PropertyOffset_WorkData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005A76 RID: 23158 RVA: 0x00081F04 File Offset: 0x00080104
		public FRigUnit_PointSimulation()
		{
		}

		// Token: 0x06005A77 RID: 23159 RVA: 0x00081F0C File Offset: 0x0008010C
		public FRigUnit_PointSimulation(TArray<FCRSimPoint> Points, TArray<FCRSimLinearSpring> Links, TArray<FCRSimPointForce> Forces, TArray<FCRSimSoftCollision> CollisionVolumes, float SimulatedStepsPerSecond, ECRSimPointIntegrateType IntegratorType, float VerletBlend, TArray<FRigUnit_PointSimulation_BoneTarget> BoneTargets, bool bLimitLocalPosition, bool bPropagateToChildren, FVector PrimaryAimAxis, FVector SecondaryAimAxis, FRigUnit_PointSimulation_DebugSettings DebugSettings, FCRFourPointBezier Bezier, FRigUnit_PointSimulation_WorkData WorkData, FControlRigExecuteContext ExecuteContext)
		{
			this.Points = Points;
			this.Links = Links;
			this.Forces = Forces;
			this.CollisionVolumes = CollisionVolumes;
			this.SimulatedStepsPerSecond = SimulatedStepsPerSecond;
			this.IntegratorType = IntegratorType;
			this.VerletBlend = VerletBlend;
			this.BoneTargets = BoneTargets;
			this.bLimitLocalPosition = bLimitLocalPosition;
			this.bPropagateToChildren = bPropagateToChildren;
			this.PrimaryAimAxis = PrimaryAimAxis;
			this.SecondaryAimAxis = SecondaryAimAxis;
			this.DebugSettings = DebugSettings;
			this.Bezier = Bezier;
			this.WorkData = WorkData;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005A78 RID: 23160 RVA: 0x00081F9C File Offset: 0x0008019C
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_PointSimulation.StaticStruct();
		}

		// Token: 0x06005A79 RID: 23161 RVA: 0x00081FA8 File Offset: 0x000801A8
		[NullableContext(2)]
		public FRigUnit_PointSimulation(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005A7A RID: 23162 RVA: 0x00081FB2 File Offset: 0x000801B2
		public FRigUnit_PointSimulation(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005A7B RID: 23163 RVA: 0x00081FBD File Offset: 0x000801BD
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_PointSimulation(Pointer, false, true);
		}

		// Token: 0x06005A7C RID: 23164 RVA: 0x00081FC7 File Offset: 0x000801C7
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_PointSimulation(Pointer, MemoryOwner);
		}

		// Token: 0x04002A4A RID: 10826
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_PointSimulation";

		// Token: 0x04002A4B RID: 10827
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002A4C RID: 10828
		internal static int __PropertyOffset_Points;

		// Token: 0x04002A4D RID: 10829
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCRSimPoint> _Points;

		// Token: 0x04002A4E RID: 10830
		internal static int __PropertyOffset_Links;

		// Token: 0x04002A4F RID: 10831
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCRSimLinearSpring> _Links;

		// Token: 0x04002A50 RID: 10832
		internal static int __PropertyOffset_Forces;

		// Token: 0x04002A51 RID: 10833
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCRSimPointForce> _Forces;

		// Token: 0x04002A52 RID: 10834
		internal static int __PropertyOffset_CollisionVolumes;

		// Token: 0x04002A53 RID: 10835
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCRSimSoftCollision> _CollisionVolumes;

		// Token: 0x04002A54 RID: 10836
		internal static int __PropertyOffset_SimulatedStepsPerSecond;

		// Token: 0x04002A55 RID: 10837
		internal static int __PropertyOffset_IntegratorType;

		// Token: 0x04002A56 RID: 10838
		internal static int __PropertyOffset_VerletBlend;

		// Token: 0x04002A57 RID: 10839
		internal static int __PropertyOffset_BoneTargets;

		// Token: 0x04002A58 RID: 10840
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRigUnit_PointSimulation_BoneTarget> _BoneTargets;

		// Token: 0x04002A59 RID: 10841
		internal static int __PropertyOffset_bLimitLocalPosition;

		// Token: 0x04002A5A RID: 10842
		internal static int __PropertyOffset_bPropagateToChildren;

		// Token: 0x04002A5B RID: 10843
		internal static int __PropertyOffset_PrimaryAimAxis;

		// Token: 0x04002A5C RID: 10844
		internal static int __PropertyOffset_SecondaryAimAxis;

		// Token: 0x04002A5D RID: 10845
		internal static int __PropertyOffset_DebugSettings;

		// Token: 0x04002A5E RID: 10846
		[Nullable(2)]
		private FRigUnit_PointSimulation_DebugSettings _DebugSettings;

		// Token: 0x04002A5F RID: 10847
		internal static int __PropertyOffset_Bezier;

		// Token: 0x04002A60 RID: 10848
		[Nullable(2)]
		private FCRFourPointBezier _Bezier;

		// Token: 0x04002A61 RID: 10849
		internal static int __PropertyOffset_WorkData;

		// Token: 0x04002A62 RID: 10850
		[Nullable(2)]
		private FRigUnit_PointSimulation_WorkData _WorkData;
	}
}
