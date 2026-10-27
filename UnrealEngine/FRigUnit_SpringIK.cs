using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006DA RID: 1754
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SpringIK")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 480)]
	public class FRigUnit_SpringIK : FRigUnit_HighlevelBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005DFA RID: 24058 RVA: 0x00086E06 File Offset: 0x00085006
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SpringIK._ScriptStructPtr != 0) ? FRigUnit_SpringIK._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SpringIK", ref FRigUnit_SpringIK._ScriptStructPtr);
		}

		// Token: 0x17001673 RID: 5747
		// (get) Token: 0x06005DFB RID: 24059 RVA: 0x00086E2A File Offset: 0x0008502A
		// (set) Token: 0x06005DFC RID: 24060 RVA: 0x00086E3E File Offset: 0x0008503E
		public unsafe FName StartBone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SpringIK.__PropertyOffset_StartBone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SpringIK.__PropertyOffset_StartBone) = value;
			}
		}

		// Token: 0x17001674 RID: 5748
		// (get) Token: 0x06005DFD RID: 24061 RVA: 0x00086E53 File Offset: 0x00085053
		// (set) Token: 0x06005DFE RID: 24062 RVA: 0x00086E67 File Offset: 0x00085067
		public unsafe FName EndBone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SpringIK.__PropertyOffset_EndBone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SpringIK.__PropertyOffset_EndBone) = value;
			}
		}

		// Token: 0x17001675 RID: 5749
		// (get) Token: 0x06005DFF RID: 24063 RVA: 0x00086E7C File Offset: 0x0008507C
		// (set) Token: 0x06005E00 RID: 24064 RVA: 0x00086E8C File Offset: 0x0008508C
		public unsafe float HierarchyStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SpringIK.__PropertyOffset_HierarchyStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SpringIK.__PropertyOffset_HierarchyStrength) = value;
			}
		}

		// Token: 0x17001676 RID: 5750
		// (get) Token: 0x06005E01 RID: 24065 RVA: 0x00086E9D File Offset: 0x0008509D
		// (set) Token: 0x06005E02 RID: 24066 RVA: 0x00086EAD File Offset: 0x000850AD
		public unsafe float EffectorStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SpringIK.__PropertyOffset_EffectorStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SpringIK.__PropertyOffset_EffectorStrength) = value;
			}
		}

		// Token: 0x17001677 RID: 5751
		// (get) Token: 0x06005E03 RID: 24067 RVA: 0x00086EBE File Offset: 0x000850BE
		// (set) Token: 0x06005E04 RID: 24068 RVA: 0x00086ECE File Offset: 0x000850CE
		public unsafe float EffectorRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SpringIK.__PropertyOffset_EffectorRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SpringIK.__PropertyOffset_EffectorRatio) = value;
			}
		}

		// Token: 0x17001678 RID: 5752
		// (get) Token: 0x06005E05 RID: 24069 RVA: 0x00086EDF File Offset: 0x000850DF
		// (set) Token: 0x06005E06 RID: 24070 RVA: 0x00086EEF File Offset: 0x000850EF
		public unsafe float RootStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SpringIK.__PropertyOffset_RootStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SpringIK.__PropertyOffset_RootStrength) = value;
			}
		}

		// Token: 0x17001679 RID: 5753
		// (get) Token: 0x06005E07 RID: 24071 RVA: 0x00086F00 File Offset: 0x00085100
		// (set) Token: 0x06005E08 RID: 24072 RVA: 0x00086F10 File Offset: 0x00085110
		public unsafe float RootRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SpringIK.__PropertyOffset_RootRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SpringIK.__PropertyOffset_RootRatio) = value;
			}
		}

		// Token: 0x1700167A RID: 5754
		// (get) Token: 0x06005E09 RID: 24073 RVA: 0x00086F21 File Offset: 0x00085121
		// (set) Token: 0x06005E0A RID: 24074 RVA: 0x00086F31 File Offset: 0x00085131
		public unsafe float Damping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SpringIK.__PropertyOffset_Damping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SpringIK.__PropertyOffset_Damping) = value;
			}
		}

		// Token: 0x1700167B RID: 5755
		// (get) Token: 0x06005E0B RID: 24075 RVA: 0x00086F42 File Offset: 0x00085142
		// (set) Token: 0x06005E0C RID: 24076 RVA: 0x00086F56 File Offset: 0x00085156
		public unsafe FVector PoleVector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SpringIK.__PropertyOffset_PoleVector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SpringIK.__PropertyOffset_PoleVector) = value;
			}
		}

		// Token: 0x1700167C RID: 5756
		// (get) Token: 0x06005E0D RID: 24077 RVA: 0x00086F6B File Offset: 0x0008516B
		// (set) Token: 0x06005E0E RID: 24078 RVA: 0x00086F7B File Offset: 0x0008517B
		public unsafe bool bFlipPolePlane
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SpringIK.__PropertyOffset_bFlipPolePlane) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SpringIK.__PropertyOffset_bFlipPolePlane) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700167D RID: 5757
		// (get) Token: 0x06005E0F RID: 24079 RVA: 0x00086F8C File Offset: 0x0008518C
		// (set) Token: 0x06005E10 RID: 24080 RVA: 0x00086F9C File Offset: 0x0008519C
		public unsafe EControlRigVectorKind PoleVectorKind
		{
			get
			{
				return (EControlRigVectorKind)(*(base.NativePtr + (IntPtr)FRigUnit_SpringIK.__PropertyOffset_PoleVectorKind));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SpringIK.__PropertyOffset_PoleVectorKind) = (byte)value;
			}
		}

		// Token: 0x1700167E RID: 5758
		// (get) Token: 0x06005E11 RID: 24081 RVA: 0x00086FAD File Offset: 0x000851AD
		// (set) Token: 0x06005E12 RID: 24082 RVA: 0x00086FC1 File Offset: 0x000851C1
		public unsafe FName PoleVectorSpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SpringIK.__PropertyOffset_PoleVectorSpace);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SpringIK.__PropertyOffset_PoleVectorSpace) = value;
			}
		}

		// Token: 0x1700167F RID: 5759
		// (get) Token: 0x06005E13 RID: 24083 RVA: 0x00086FD6 File Offset: 0x000851D6
		// (set) Token: 0x06005E14 RID: 24084 RVA: 0x00086FEA File Offset: 0x000851EA
		public unsafe FVector PrimaryAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SpringIK.__PropertyOffset_PrimaryAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SpringIK.__PropertyOffset_PrimaryAxis) = value;
			}
		}

		// Token: 0x17001680 RID: 5760
		// (get) Token: 0x06005E15 RID: 24085 RVA: 0x00086FFF File Offset: 0x000851FF
		// (set) Token: 0x06005E16 RID: 24086 RVA: 0x00087013 File Offset: 0x00085213
		public unsafe FVector SecondaryAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SpringIK.__PropertyOffset_SecondaryAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SpringIK.__PropertyOffset_SecondaryAxis) = value;
			}
		}

		// Token: 0x17001681 RID: 5761
		// (get) Token: 0x06005E17 RID: 24087 RVA: 0x00087028 File Offset: 0x00085228
		// (set) Token: 0x06005E18 RID: 24088 RVA: 0x00087038 File Offset: 0x00085238
		public unsafe bool bLiveSimulation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SpringIK.__PropertyOffset_bLiveSimulation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SpringIK.__PropertyOffset_bLiveSimulation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001682 RID: 5762
		// (get) Token: 0x06005E19 RID: 24089 RVA: 0x00087049 File Offset: 0x00085249
		// (set) Token: 0x06005E1A RID: 24090 RVA: 0x00087059 File Offset: 0x00085259
		public unsafe int Iterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SpringIK.__PropertyOffset_Iterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SpringIK.__PropertyOffset_Iterations) = value;
			}
		}

		// Token: 0x17001683 RID: 5763
		// (get) Token: 0x06005E1B RID: 24091 RVA: 0x0008706A File Offset: 0x0008526A
		// (set) Token: 0x06005E1C RID: 24092 RVA: 0x0008707A File Offset: 0x0008527A
		public unsafe bool bLimitLocalPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SpringIK.__PropertyOffset_bLimitLocalPosition) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SpringIK.__PropertyOffset_bLimitLocalPosition) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001684 RID: 5764
		// (get) Token: 0x06005E1D RID: 24093 RVA: 0x0008708B File Offset: 0x0008528B
		// (set) Token: 0x06005E1E RID: 24094 RVA: 0x0008709B File Offset: 0x0008529B
		public unsafe bool bPropagateToChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SpringIK.__PropertyOffset_bPropagateToChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SpringIK.__PropertyOffset_bPropagateToChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001685 RID: 5765
		// (get) Token: 0x06005E1F RID: 24095 RVA: 0x000870AC File Offset: 0x000852AC
		// (set) Token: 0x06005E20 RID: 24096 RVA: 0x000870EF File Offset: 0x000852EF
		public FRigUnit_SpringIK_DebugSettings DebugSettings
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_SpringIK_DebugSettings result;
				if ((result = this._DebugSettings) == null)
				{
					result = (this._DebugSettings = new FRigUnit_SpringIK_DebugSettings(base.NativePtr + (IntPtr)FRigUnit_SpringIK.__PropertyOffset_DebugSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_SpringIK_DebugSettings.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SpringIK.__PropertyOffset_DebugSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001686 RID: 5766
		// (get) Token: 0x06005E21 RID: 24097 RVA: 0x00087110 File Offset: 0x00085310
		// (set) Token: 0x06005E22 RID: 24098 RVA: 0x00087153 File Offset: 0x00085353
		public FRigUnit_SpringIK_WorkData WorkData
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_SpringIK_WorkData result;
				if ((result = this._WorkData) == null)
				{
					result = (this._WorkData = new FRigUnit_SpringIK_WorkData(base.NativePtr + (IntPtr)FRigUnit_SpringIK.__PropertyOffset_WorkData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_SpringIK_WorkData.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SpringIK.__PropertyOffset_WorkData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005E23 RID: 24099 RVA: 0x00087174 File Offset: 0x00085374
		public FRigUnit_SpringIK()
		{
		}

		// Token: 0x06005E24 RID: 24100 RVA: 0x0008717C File Offset: 0x0008537C
		public FRigUnit_SpringIK(FName StartBone, FName EndBone, float HierarchyStrength, float EffectorStrength, float EffectorRatio, float RootStrength, float RootRatio, float Damping, FVector PoleVector, bool bFlipPolePlane, EControlRigVectorKind PoleVectorKind, FName PoleVectorSpace, FVector PrimaryAxis, FVector SecondaryAxis, bool bLiveSimulation, int Iterations, bool bLimitLocalPosition, bool bPropagateToChildren, FRigUnit_SpringIK_DebugSettings DebugSettings, FRigUnit_SpringIK_WorkData WorkData, FControlRigExecuteContext ExecuteContext)
		{
			this.StartBone = StartBone;
			this.EndBone = EndBone;
			this.HierarchyStrength = HierarchyStrength;
			this.EffectorStrength = EffectorStrength;
			this.EffectorRatio = EffectorRatio;
			this.RootStrength = RootStrength;
			this.RootRatio = RootRatio;
			this.Damping = Damping;
			this.PoleVector = PoleVector;
			this.bFlipPolePlane = bFlipPolePlane;
			this.PoleVectorKind = PoleVectorKind;
			this.PoleVectorSpace = PoleVectorSpace;
			this.PrimaryAxis = PrimaryAxis;
			this.SecondaryAxis = SecondaryAxis;
			this.bLiveSimulation = bLiveSimulation;
			this.Iterations = Iterations;
			this.bLimitLocalPosition = bLimitLocalPosition;
			this.bPropagateToChildren = bPropagateToChildren;
			this.DebugSettings = DebugSettings;
			this.WorkData = WorkData;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005E25 RID: 24101 RVA: 0x00087234 File Offset: 0x00085434
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SpringIK.StaticStruct();
		}

		// Token: 0x06005E26 RID: 24102 RVA: 0x00087240 File Offset: 0x00085440
		[NullableContext(2)]
		public FRigUnit_SpringIK(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005E27 RID: 24103 RVA: 0x0008724A File Offset: 0x0008544A
		public FRigUnit_SpringIK(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005E28 RID: 24104 RVA: 0x00087255 File Offset: 0x00085455
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SpringIK(Pointer, false, true);
		}

		// Token: 0x06005E29 RID: 24105 RVA: 0x0008725F File Offset: 0x0008545F
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SpringIK(Pointer, MemoryOwner);
		}

		// Token: 0x04002BF8 RID: 11256
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_SpringIK";

		// Token: 0x04002BF9 RID: 11257
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002BFA RID: 11258
		internal static int __PropertyOffset_StartBone;

		// Token: 0x04002BFB RID: 11259
		internal static int __PropertyOffset_EndBone;

		// Token: 0x04002BFC RID: 11260
		internal static int __PropertyOffset_HierarchyStrength;

		// Token: 0x04002BFD RID: 11261
		internal static int __PropertyOffset_EffectorStrength;

		// Token: 0x04002BFE RID: 11262
		internal static int __PropertyOffset_EffectorRatio;

		// Token: 0x04002BFF RID: 11263
		internal static int __PropertyOffset_RootStrength;

		// Token: 0x04002C00 RID: 11264
		internal static int __PropertyOffset_RootRatio;

		// Token: 0x04002C01 RID: 11265
		internal static int __PropertyOffset_Damping;

		// Token: 0x04002C02 RID: 11266
		internal static int __PropertyOffset_PoleVector;

		// Token: 0x04002C03 RID: 11267
		internal static int __PropertyOffset_bFlipPolePlane;

		// Token: 0x04002C04 RID: 11268
		internal static int __PropertyOffset_PoleVectorKind;

		// Token: 0x04002C05 RID: 11269
		internal static int __PropertyOffset_PoleVectorSpace;

		// Token: 0x04002C06 RID: 11270
		internal static int __PropertyOffset_PrimaryAxis;

		// Token: 0x04002C07 RID: 11271
		internal static int __PropertyOffset_SecondaryAxis;

		// Token: 0x04002C08 RID: 11272
		internal static int __PropertyOffset_bLiveSimulation;

		// Token: 0x04002C09 RID: 11273
		internal static int __PropertyOffset_Iterations;

		// Token: 0x04002C0A RID: 11274
		internal static int __PropertyOffset_bLimitLocalPosition;

		// Token: 0x04002C0B RID: 11275
		internal static int __PropertyOffset_bPropagateToChildren;

		// Token: 0x04002C0C RID: 11276
		internal static int __PropertyOffset_DebugSettings;

		// Token: 0x04002C0D RID: 11277
		[Nullable(2)]
		private FRigUnit_SpringIK_DebugSettings _DebugSettings;

		// Token: 0x04002C0E RID: 11278
		internal static int __PropertyOffset_WorkData;

		// Token: 0x04002C0F RID: 11279
		[Nullable(2)]
		private FRigUnit_SpringIK_WorkData _WorkData;
	}
}
