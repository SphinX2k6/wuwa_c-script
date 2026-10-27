using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005A8 RID: 1448
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_FitChainToCurve")]
	[UnrealStructLayout(528, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 528)]
	public class FRigUnit_FitChainToCurve : FRigUnit_HighlevelBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004DC1 RID: 19905 RVA: 0x00072D29 File Offset: 0x00070F29
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_FitChainToCurve._ScriptStructPtr != 0) ? FRigUnit_FitChainToCurve._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_FitChainToCurve", ref FRigUnit_FitChainToCurve._ScriptStructPtr);
		}

		// Token: 0x17001316 RID: 4886
		// (get) Token: 0x06004DC2 RID: 19906 RVA: 0x00072D4D File Offset: 0x00070F4D
		// (set) Token: 0x06004DC3 RID: 19907 RVA: 0x00072D61 File Offset: 0x00070F61
		public unsafe FName StartBone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve.__PropertyOffset_StartBone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve.__PropertyOffset_StartBone) = value;
			}
		}

		// Token: 0x17001317 RID: 4887
		// (get) Token: 0x06004DC4 RID: 19908 RVA: 0x00072D76 File Offset: 0x00070F76
		// (set) Token: 0x06004DC5 RID: 19909 RVA: 0x00072D8A File Offset: 0x00070F8A
		public unsafe FName EndBone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve.__PropertyOffset_EndBone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve.__PropertyOffset_EndBone) = value;
			}
		}

		// Token: 0x17001318 RID: 4888
		// (get) Token: 0x06004DC6 RID: 19910 RVA: 0x00072DA0 File Offset: 0x00070FA0
		// (set) Token: 0x06004DC7 RID: 19911 RVA: 0x00072DE3 File Offset: 0x00070FE3
		public FCRFourPointBezier Bezier
		{
			get
			{
				base.FastCheckIsValid();
				FCRFourPointBezier result;
				if ((result = this._Bezier) == null)
				{
					result = (this._Bezier = new FCRFourPointBezier(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve.__PropertyOffset_Bezier, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCRFourPointBezier.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve.__PropertyOffset_Bezier, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001319 RID: 4889
		// (get) Token: 0x06004DC8 RID: 19912 RVA: 0x00072E04 File Offset: 0x00071004
		// (set) Token: 0x06004DC9 RID: 19913 RVA: 0x00072E14 File Offset: 0x00071014
		public unsafe EControlRigCurveAlignment Alignment
		{
			get
			{
				return (EControlRigCurveAlignment)(*(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve.__PropertyOffset_Alignment));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve.__PropertyOffset_Alignment) = (byte)value;
			}
		}

		// Token: 0x1700131A RID: 4890
		// (get) Token: 0x06004DCA RID: 19914 RVA: 0x00072E25 File Offset: 0x00071025
		// (set) Token: 0x06004DCB RID: 19915 RVA: 0x00072E35 File Offset: 0x00071035
		public unsafe float Minimum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve.__PropertyOffset_Minimum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve.__PropertyOffset_Minimum) = value;
			}
		}

		// Token: 0x1700131B RID: 4891
		// (get) Token: 0x06004DCC RID: 19916 RVA: 0x00072E46 File Offset: 0x00071046
		// (set) Token: 0x06004DCD RID: 19917 RVA: 0x00072E56 File Offset: 0x00071056
		public unsafe float Maximum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve.__PropertyOffset_Maximum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve.__PropertyOffset_Maximum) = value;
			}
		}

		// Token: 0x1700131C RID: 4892
		// (get) Token: 0x06004DCE RID: 19918 RVA: 0x00072E67 File Offset: 0x00071067
		// (set) Token: 0x06004DCF RID: 19919 RVA: 0x00072E77 File Offset: 0x00071077
		public unsafe int SamplingPrecision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve.__PropertyOffset_SamplingPrecision);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve.__PropertyOffset_SamplingPrecision) = value;
			}
		}

		// Token: 0x1700131D RID: 4893
		// (get) Token: 0x06004DD0 RID: 19920 RVA: 0x00072E88 File Offset: 0x00071088
		// (set) Token: 0x06004DD1 RID: 19921 RVA: 0x00072E9C File Offset: 0x0007109C
		public unsafe FVector PrimaryAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve.__PropertyOffset_PrimaryAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve.__PropertyOffset_PrimaryAxis) = value;
			}
		}

		// Token: 0x1700131E RID: 4894
		// (get) Token: 0x06004DD2 RID: 19922 RVA: 0x00072EB1 File Offset: 0x000710B1
		// (set) Token: 0x06004DD3 RID: 19923 RVA: 0x00072EC5 File Offset: 0x000710C5
		public unsafe FVector SecondaryAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve.__PropertyOffset_SecondaryAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve.__PropertyOffset_SecondaryAxis) = value;
			}
		}

		// Token: 0x1700131F RID: 4895
		// (get) Token: 0x06004DD4 RID: 19924 RVA: 0x00072EDA File Offset: 0x000710DA
		// (set) Token: 0x06004DD5 RID: 19925 RVA: 0x00072EEE File Offset: 0x000710EE
		public unsafe FVector PoleVectorPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve.__PropertyOffset_PoleVectorPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve.__PropertyOffset_PoleVectorPosition) = value;
			}
		}

		// Token: 0x17001320 RID: 4896
		// (get) Token: 0x06004DD6 RID: 19926 RVA: 0x00072F04 File Offset: 0x00071104
		// (set) Token: 0x06004DD7 RID: 19927 RVA: 0x00072F47 File Offset: 0x00071147
		public TArray<FRigUnit_FitChainToCurve_Rotation> Rotations
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRigUnit_FitChainToCurve_Rotation> result;
				if ((result = this._Rotations) == null)
				{
					result = (this._Rotations = new TArray<FRigUnit_FitChainToCurve_Rotation>(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve.__PropertyOffset_Rotations, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Rotations.CopyAssign(value);
			}
		}

		// Token: 0x17001321 RID: 4897
		// (get) Token: 0x06004DD8 RID: 19928 RVA: 0x00072F55 File Offset: 0x00071155
		// (set) Token: 0x06004DD9 RID: 19929 RVA: 0x00072F65 File Offset: 0x00071165
		public unsafe EControlRigAnimEasingType RotationEaseType
		{
			get
			{
				return (EControlRigAnimEasingType)(*(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve.__PropertyOffset_RotationEaseType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve.__PropertyOffset_RotationEaseType) = (byte)value;
			}
		}

		// Token: 0x17001322 RID: 4898
		// (get) Token: 0x06004DDA RID: 19930 RVA: 0x00072F76 File Offset: 0x00071176
		// (set) Token: 0x06004DDB RID: 19931 RVA: 0x00072F86 File Offset: 0x00071186
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x17001323 RID: 4899
		// (get) Token: 0x06004DDC RID: 19932 RVA: 0x00072F97 File Offset: 0x00071197
		// (set) Token: 0x06004DDD RID: 19933 RVA: 0x00072FA7 File Offset: 0x000711A7
		public unsafe bool bPropagateToChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve.__PropertyOffset_bPropagateToChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve.__PropertyOffset_bPropagateToChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001324 RID: 4900
		// (get) Token: 0x06004DDE RID: 19934 RVA: 0x00072FB8 File Offset: 0x000711B8
		// (set) Token: 0x06004DDF RID: 19935 RVA: 0x00072FFB File Offset: 0x000711FB
		public FRigUnit_FitChainToCurve_DebugSettings DebugSettings
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_FitChainToCurve_DebugSettings result;
				if ((result = this._DebugSettings) == null)
				{
					result = (this._DebugSettings = new FRigUnit_FitChainToCurve_DebugSettings(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve.__PropertyOffset_DebugSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_FitChainToCurve_DebugSettings.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve.__PropertyOffset_DebugSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001325 RID: 4901
		// (get) Token: 0x06004DE0 RID: 19936 RVA: 0x0007301C File Offset: 0x0007121C
		// (set) Token: 0x06004DE1 RID: 19937 RVA: 0x0007305F File Offset: 0x0007125F
		public FRigUnit_FitChainToCurve_WorkData WorkData
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_FitChainToCurve_WorkData result;
				if ((result = this._WorkData) == null)
				{
					result = (this._WorkData = new FRigUnit_FitChainToCurve_WorkData(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve.__PropertyOffset_WorkData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_FitChainToCurve_WorkData.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_FitChainToCurve.__PropertyOffset_WorkData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06004DE2 RID: 19938 RVA: 0x00073080 File Offset: 0x00071280
		public FRigUnit_FitChainToCurve()
		{
		}

		// Token: 0x06004DE3 RID: 19939 RVA: 0x00073088 File Offset: 0x00071288
		public FRigUnit_FitChainToCurve(FName StartBone, FName EndBone, FCRFourPointBezier Bezier, EControlRigCurveAlignment Alignment, float Minimum, float Maximum, int SamplingPrecision, FVector PrimaryAxis, FVector SecondaryAxis, FVector PoleVectorPosition, TArray<FRigUnit_FitChainToCurve_Rotation> Rotations, EControlRigAnimEasingType RotationEaseType, float Weight, bool bPropagateToChildren, FRigUnit_FitChainToCurve_DebugSettings DebugSettings, FRigUnit_FitChainToCurve_WorkData WorkData, FControlRigExecuteContext ExecuteContext)
		{
			this.StartBone = StartBone;
			this.EndBone = EndBone;
			this.Bezier = Bezier;
			this.Alignment = Alignment;
			this.Minimum = Minimum;
			this.Maximum = Maximum;
			this.SamplingPrecision = SamplingPrecision;
			this.PrimaryAxis = PrimaryAxis;
			this.SecondaryAxis = SecondaryAxis;
			this.PoleVectorPosition = PoleVectorPosition;
			this.Rotations = Rotations;
			this.RotationEaseType = RotationEaseType;
			this.Weight = Weight;
			this.bPropagateToChildren = bPropagateToChildren;
			this.DebugSettings = DebugSettings;
			this.WorkData = WorkData;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06004DE4 RID: 19940 RVA: 0x00073120 File Offset: 0x00071320
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_FitChainToCurve.StaticStruct();
		}

		// Token: 0x06004DE5 RID: 19941 RVA: 0x0007312C File Offset: 0x0007132C
		[NullableContext(2)]
		public FRigUnit_FitChainToCurve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004DE6 RID: 19942 RVA: 0x00073136 File Offset: 0x00071336
		public FRigUnit_FitChainToCurve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004DE7 RID: 19943 RVA: 0x00073141 File Offset: 0x00071341
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_FitChainToCurve(Pointer, false, true);
		}

		// Token: 0x06004DE8 RID: 19944 RVA: 0x0007314B File Offset: 0x0007134B
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_FitChainToCurve(Pointer, MemoryOwner);
		}

		// Token: 0x0400258B RID: 9611
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_FitChainToCurve";

		// Token: 0x0400258C RID: 9612
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400258D RID: 9613
		internal static int __PropertyOffset_StartBone;

		// Token: 0x0400258E RID: 9614
		internal static int __PropertyOffset_EndBone;

		// Token: 0x0400258F RID: 9615
		internal static int __PropertyOffset_Bezier;

		// Token: 0x04002590 RID: 9616
		[Nullable(2)]
		private FCRFourPointBezier _Bezier;

		// Token: 0x04002591 RID: 9617
		internal static int __PropertyOffset_Alignment;

		// Token: 0x04002592 RID: 9618
		internal static int __PropertyOffset_Minimum;

		// Token: 0x04002593 RID: 9619
		internal static int __PropertyOffset_Maximum;

		// Token: 0x04002594 RID: 9620
		internal static int __PropertyOffset_SamplingPrecision;

		// Token: 0x04002595 RID: 9621
		internal static int __PropertyOffset_PrimaryAxis;

		// Token: 0x04002596 RID: 9622
		internal static int __PropertyOffset_SecondaryAxis;

		// Token: 0x04002597 RID: 9623
		internal static int __PropertyOffset_PoleVectorPosition;

		// Token: 0x04002598 RID: 9624
		internal static int __PropertyOffset_Rotations;

		// Token: 0x04002599 RID: 9625
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRigUnit_FitChainToCurve_Rotation> _Rotations;

		// Token: 0x0400259A RID: 9626
		internal static int __PropertyOffset_RotationEaseType;

		// Token: 0x0400259B RID: 9627
		internal static int __PropertyOffset_Weight;

		// Token: 0x0400259C RID: 9628
		internal static int __PropertyOffset_bPropagateToChildren;

		// Token: 0x0400259D RID: 9629
		internal static int __PropertyOffset_DebugSettings;

		// Token: 0x0400259E RID: 9630
		[Nullable(2)]
		private FRigUnit_FitChainToCurve_DebugSettings _DebugSettings;

		// Token: 0x0400259F RID: 9631
		internal static int __PropertyOffset_WorkData;

		// Token: 0x040025A0 RID: 9632
		[Nullable(2)]
		private FRigUnit_FitChainToCurve_WorkData _WorkData;
	}
}
