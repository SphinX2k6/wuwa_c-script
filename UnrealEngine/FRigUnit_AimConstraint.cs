using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000543 RID: 1347
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_AimConstraint")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 200)]
	public class FRigUnit_AimConstraint : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060046EA RID: 18154 RVA: 0x0006940A File Offset: 0x0006760A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_AimConstraint._ScriptStructPtr != 0) ? FRigUnit_AimConstraint._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_AimConstraint", ref FRigUnit_AimConstraint._ScriptStructPtr);
		}

		// Token: 0x1700113D RID: 4413
		// (get) Token: 0x060046EB RID: 18155 RVA: 0x0006942E File Offset: 0x0006762E
		// (set) Token: 0x060046EC RID: 18156 RVA: 0x00069442 File Offset: 0x00067642
		public unsafe FName Joint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AimConstraint.__PropertyOffset_Joint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AimConstraint.__PropertyOffset_Joint) = value;
			}
		}

		// Token: 0x1700113E RID: 4414
		// (get) Token: 0x060046ED RID: 18157 RVA: 0x00069457 File Offset: 0x00067657
		// (set) Token: 0x060046EE RID: 18158 RVA: 0x00069467 File Offset: 0x00067667
		public unsafe EAimMode AimMode
		{
			get
			{
				return (EAimMode)(*(base.NativePtr + (IntPtr)FRigUnit_AimConstraint.__PropertyOffset_AimMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AimConstraint.__PropertyOffset_AimMode) = (byte)value;
			}
		}

		// Token: 0x1700113F RID: 4415
		// (get) Token: 0x060046EF RID: 18159 RVA: 0x00069478 File Offset: 0x00067678
		// (set) Token: 0x060046F0 RID: 18160 RVA: 0x00069488 File Offset: 0x00067688
		public unsafe EAimMode UpMode
		{
			get
			{
				return (EAimMode)(*(base.NativePtr + (IntPtr)FRigUnit_AimConstraint.__PropertyOffset_UpMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AimConstraint.__PropertyOffset_UpMode) = (byte)value;
			}
		}

		// Token: 0x17001140 RID: 4416
		// (get) Token: 0x060046F1 RID: 18161 RVA: 0x00069499 File Offset: 0x00067699
		// (set) Token: 0x060046F2 RID: 18162 RVA: 0x000694AD File Offset: 0x000676AD
		public unsafe FVector AimVector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AimConstraint.__PropertyOffset_AimVector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AimConstraint.__PropertyOffset_AimVector) = value;
			}
		}

		// Token: 0x17001141 RID: 4417
		// (get) Token: 0x060046F3 RID: 18163 RVA: 0x000694C2 File Offset: 0x000676C2
		// (set) Token: 0x060046F4 RID: 18164 RVA: 0x000694D6 File Offset: 0x000676D6
		public unsafe FVector UpVector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AimConstraint.__PropertyOffset_UpVector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AimConstraint.__PropertyOffset_UpVector) = value;
			}
		}

		// Token: 0x17001142 RID: 4418
		// (get) Token: 0x060046F5 RID: 18165 RVA: 0x000694EC File Offset: 0x000676EC
		// (set) Token: 0x060046F6 RID: 18166 RVA: 0x0006952F File Offset: 0x0006772F
		public TArray<FAimTarget> AimTargets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAimTarget> result;
				if ((result = this._AimTargets) == null)
				{
					result = (this._AimTargets = new TArray<FAimTarget>(base.NativePtr + (IntPtr)FRigUnit_AimConstraint.__PropertyOffset_AimTargets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AimTargets.CopyAssign(value);
			}
		}

		// Token: 0x17001143 RID: 4419
		// (get) Token: 0x060046F7 RID: 18167 RVA: 0x00069540 File Offset: 0x00067740
		// (set) Token: 0x060046F8 RID: 18168 RVA: 0x00069583 File Offset: 0x00067783
		public TArray<FAimTarget> UpTargets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAimTarget> result;
				if ((result = this._UpTargets) == null)
				{
					result = (this._UpTargets = new TArray<FAimTarget>(base.NativePtr + (IntPtr)FRigUnit_AimConstraint.__PropertyOffset_UpTargets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.UpTargets.CopyAssign(value);
			}
		}

		// Token: 0x17001144 RID: 4420
		// (get) Token: 0x060046F9 RID: 18169 RVA: 0x00069594 File Offset: 0x00067794
		// (set) Token: 0x060046FA RID: 18170 RVA: 0x000695D7 File Offset: 0x000677D7
		public FRigUnit_AimConstraint_WorkData WorkData
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_AimConstraint_WorkData result;
				if ((result = this._WorkData) == null)
				{
					result = (this._WorkData = new FRigUnit_AimConstraint_WorkData(base.NativePtr + (IntPtr)FRigUnit_AimConstraint.__PropertyOffset_WorkData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_AimConstraint_WorkData.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_AimConstraint.__PropertyOffset_WorkData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060046FB RID: 18171 RVA: 0x000695F8 File Offset: 0x000677F8
		public FRigUnit_AimConstraint()
		{
		}

		// Token: 0x060046FC RID: 18172 RVA: 0x00069600 File Offset: 0x00067800
		public FRigUnit_AimConstraint(FName Joint, EAimMode AimMode, EAimMode UpMode, FVector AimVector, FVector UpVector, TArray<FAimTarget> AimTargets, TArray<FAimTarget> UpTargets, FRigUnit_AimConstraint_WorkData WorkData, FControlRigExecuteContext ExecuteContext)
		{
			this.Joint = Joint;
			this.AimMode = AimMode;
			this.UpMode = UpMode;
			this.AimVector = AimVector;
			this.UpVector = UpVector;
			this.AimTargets = AimTargets;
			this.UpTargets = UpTargets;
			this.WorkData = WorkData;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x060046FD RID: 18173 RVA: 0x00069658 File Offset: 0x00067858
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_AimConstraint.StaticStruct();
		}

		// Token: 0x060046FE RID: 18174 RVA: 0x00069664 File Offset: 0x00067864
		[NullableContext(2)]
		public FRigUnit_AimConstraint(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060046FF RID: 18175 RVA: 0x0006966E File Offset: 0x0006786E
		public FRigUnit_AimConstraint(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004700 RID: 18176 RVA: 0x00069679 File Offset: 0x00067879
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_AimConstraint(Pointer, false, true);
		}

		// Token: 0x06004701 RID: 18177 RVA: 0x00069683 File Offset: 0x00067883
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_AimConstraint(Pointer, MemoryOwner);
		}

		// Token: 0x04002270 RID: 8816
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_AimConstraint";

		// Token: 0x04002271 RID: 8817
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002272 RID: 8818
		internal static int __PropertyOffset_Joint;

		// Token: 0x04002273 RID: 8819
		internal static int __PropertyOffset_AimMode;

		// Token: 0x04002274 RID: 8820
		internal static int __PropertyOffset_UpMode;

		// Token: 0x04002275 RID: 8821
		internal static int __PropertyOffset_AimVector;

		// Token: 0x04002276 RID: 8822
		internal static int __PropertyOffset_UpVector;

		// Token: 0x04002277 RID: 8823
		internal static int __PropertyOffset_AimTargets;

		// Token: 0x04002278 RID: 8824
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAimTarget> _AimTargets;

		// Token: 0x04002279 RID: 8825
		internal static int __PropertyOffset_UpTargets;

		// Token: 0x0400227A RID: 8826
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAimTarget> _UpTargets;

		// Token: 0x0400227B RID: 8827
		internal static int __PropertyOffset_WorkData;

		// Token: 0x0400227C RID: 8828
		[Nullable(2)]
		private FRigUnit_AimConstraint_WorkData _WorkData;
	}
}
