using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020004DE RID: 1246
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.CRSimPointContainer")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 120)]
	public class FCRSimPointContainer : FCRSimContainer, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060042D5 RID: 17109 RVA: 0x00063BBD File Offset: 0x00061DBD
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCRSimPointContainer._ScriptStructPtr != 0) ? FCRSimPointContainer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.CRSimPointContainer", ref FCRSimPointContainer._ScriptStructPtr);
		}

		// Token: 0x17001037 RID: 4151
		// (get) Token: 0x060042D6 RID: 17110 RVA: 0x00063BE4 File Offset: 0x00061DE4
		// (set) Token: 0x060042D7 RID: 17111 RVA: 0x00063C27 File Offset: 0x00061E27
		public TArray<FCRSimPoint> Points
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCRSimPoint> result;
				if ((result = this._Points) == null)
				{
					result = (this._Points = new TArray<FCRSimPoint>(base.NativePtr + (IntPtr)FCRSimPointContainer.__PropertyOffset_Points, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Points.CopyAssign(value);
			}
		}

		// Token: 0x17001038 RID: 4152
		// (get) Token: 0x060042D8 RID: 17112 RVA: 0x00063C38 File Offset: 0x00061E38
		// (set) Token: 0x060042D9 RID: 17113 RVA: 0x00063C7B File Offset: 0x00061E7B
		public TArray<FCRSimLinearSpring> Springs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCRSimLinearSpring> result;
				if ((result = this._Springs) == null)
				{
					result = (this._Springs = new TArray<FCRSimLinearSpring>(base.NativePtr + (IntPtr)FCRSimPointContainer.__PropertyOffset_Springs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Springs.CopyAssign(value);
			}
		}

		// Token: 0x17001039 RID: 4153
		// (get) Token: 0x060042DA RID: 17114 RVA: 0x00063C8C File Offset: 0x00061E8C
		// (set) Token: 0x060042DB RID: 17115 RVA: 0x00063CCF File Offset: 0x00061ECF
		public TArray<FCRSimPointForce> Forces
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCRSimPointForce> result;
				if ((result = this._Forces) == null)
				{
					result = (this._Forces = new TArray<FCRSimPointForce>(base.NativePtr + (IntPtr)FCRSimPointContainer.__PropertyOffset_Forces, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Forces.CopyAssign(value);
			}
		}

		// Token: 0x1700103A RID: 4154
		// (get) Token: 0x060042DC RID: 17116 RVA: 0x00063CE0 File Offset: 0x00061EE0
		// (set) Token: 0x060042DD RID: 17117 RVA: 0x00063D23 File Offset: 0x00061F23
		public TArray<FCRSimSoftCollision> CollisionVolumes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCRSimSoftCollision> result;
				if ((result = this._CollisionVolumes) == null)
				{
					result = (this._CollisionVolumes = new TArray<FCRSimSoftCollision>(base.NativePtr + (IntPtr)FCRSimPointContainer.__PropertyOffset_CollisionVolumes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CollisionVolumes.CopyAssign(value);
			}
		}

		// Token: 0x1700103B RID: 4155
		// (get) Token: 0x060042DE RID: 17118 RVA: 0x00063D34 File Offset: 0x00061F34
		// (set) Token: 0x060042DF RID: 17119 RVA: 0x00063D77 File Offset: 0x00061F77
		public TArray<FCRSimPointConstraint> Constraints
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCRSimPointConstraint> result;
				if ((result = this._Constraints) == null)
				{
					result = (this._Constraints = new TArray<FCRSimPointConstraint>(base.NativePtr + (IntPtr)FCRSimPointContainer.__PropertyOffset_Constraints, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Constraints.CopyAssign(value);
			}
		}

		// Token: 0x1700103C RID: 4156
		// (get) Token: 0x060042E0 RID: 17120 RVA: 0x00063D88 File Offset: 0x00061F88
		// (set) Token: 0x060042E1 RID: 17121 RVA: 0x00063DCB File Offset: 0x00061FCB
		public TArray<FCRSimPoint> PreviousStep
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCRSimPoint> result;
				if ((result = this._PreviousStep) == null)
				{
					result = (this._PreviousStep = new TArray<FCRSimPoint>(base.NativePtr + (IntPtr)FCRSimPointContainer.__PropertyOffset_PreviousStep, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PreviousStep.CopyAssign(value);
			}
		}

		// Token: 0x060042E2 RID: 17122 RVA: 0x00063DD9 File Offset: 0x00061FD9
		public FCRSimPointContainer()
		{
		}

		// Token: 0x060042E3 RID: 17123 RVA: 0x00063DE4 File Offset: 0x00061FE4
		public FCRSimPointContainer(TArray<FCRSimPoint> Points, TArray<FCRSimLinearSpring> Springs, TArray<FCRSimPointForce> Forces, TArray<FCRSimSoftCollision> CollisionVolumes, TArray<FCRSimPointConstraint> Constraints, TArray<FCRSimPoint> PreviousStep, float TimeStep, float AccumulatedTime, float TimeLeftForStep)
		{
			this.Points = Points;
			this.Springs = Springs;
			this.Forces = Forces;
			this.CollisionVolumes = CollisionVolumes;
			this.Constraints = Constraints;
			this.PreviousStep = PreviousStep;
			base.TimeStep = TimeStep;
			base.AccumulatedTime = AccumulatedTime;
			base.TimeLeftForStep = TimeLeftForStep;
		}

		// Token: 0x060042E4 RID: 17124 RVA: 0x00063E3C File Offset: 0x0006203C
		protected override IntPtr GetUStructPtr()
		{
			return FCRSimPointContainer.StaticStruct();
		}

		// Token: 0x060042E5 RID: 17125 RVA: 0x00063E48 File Offset: 0x00062048
		[NullableContext(2)]
		public FCRSimPointContainer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060042E6 RID: 17126 RVA: 0x00063E52 File Offset: 0x00062052
		public FCRSimPointContainer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060042E7 RID: 17127 RVA: 0x00063E5D File Offset: 0x0006205D
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCRSimPointContainer(Pointer, false, true);
		}

		// Token: 0x060042E8 RID: 17128 RVA: 0x00063E67 File Offset: 0x00062067
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCRSimPointContainer(Pointer, MemoryOwner);
		}

		// Token: 0x04001FBC RID: 8124
		public new const string __ObjectPath = "/Script/ControlRig.CRSimPointContainer";

		// Token: 0x04001FBD RID: 8125
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001FBE RID: 8126
		internal static int __PropertyOffset_Points;

		// Token: 0x04001FBF RID: 8127
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCRSimPoint> _Points;

		// Token: 0x04001FC0 RID: 8128
		internal static int __PropertyOffset_Springs;

		// Token: 0x04001FC1 RID: 8129
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCRSimLinearSpring> _Springs;

		// Token: 0x04001FC2 RID: 8130
		internal static int __PropertyOffset_Forces;

		// Token: 0x04001FC3 RID: 8131
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCRSimPointForce> _Forces;

		// Token: 0x04001FC4 RID: 8132
		internal static int __PropertyOffset_CollisionVolumes;

		// Token: 0x04001FC5 RID: 8133
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCRSimSoftCollision> _CollisionVolumes;

		// Token: 0x04001FC6 RID: 8134
		internal static int __PropertyOffset_Constraints;

		// Token: 0x04001FC7 RID: 8135
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCRSimPointConstraint> _Constraints;

		// Token: 0x04001FC8 RID: 8136
		internal static int __PropertyOffset_PreviousStep;

		// Token: 0x04001FC9 RID: 8137
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCRSimPoint> _PreviousStep;
	}
}
