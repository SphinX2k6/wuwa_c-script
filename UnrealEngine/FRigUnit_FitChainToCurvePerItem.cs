using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005A9 RID: 1449
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_FitChainToCurvePerItem")]
	[UnrealStructLayout(528, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 528)]
	public class FRigUnit_FitChainToCurvePerItem : FRigUnit_HighlevelBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004DE9 RID: 19945 RVA: 0x00073154 File Offset: 0x00071354
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_FitChainToCurvePerItem._ScriptStructPtr != 0) ? FRigUnit_FitChainToCurvePerItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_FitChainToCurvePerItem", ref FRigUnit_FitChainToCurvePerItem._ScriptStructPtr);
		}

		// Token: 0x17001326 RID: 4902
		// (get) Token: 0x06004DEA RID: 19946 RVA: 0x00073178 File Offset: 0x00071378
		// (set) Token: 0x06004DEB RID: 19947 RVA: 0x000731BB File Offset: 0x000713BB
		public FRigElementKeyCollection Items
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKeyCollection result;
				if ((result = this._Items) == null)
				{
					result = (this._Items = new FRigElementKeyCollection(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurvePerItem.__PropertyOffset_Items, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKeyCollection.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_FitChainToCurvePerItem.__PropertyOffset_Items, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001327 RID: 4903
		// (get) Token: 0x06004DEC RID: 19948 RVA: 0x000731DC File Offset: 0x000713DC
		// (set) Token: 0x06004DED RID: 19949 RVA: 0x0007321F File Offset: 0x0007141F
		public FCRFourPointBezier Bezier
		{
			get
			{
				base.FastCheckIsValid();
				FCRFourPointBezier result;
				if ((result = this._Bezier) == null)
				{
					result = (this._Bezier = new FCRFourPointBezier(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurvePerItem.__PropertyOffset_Bezier, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCRFourPointBezier.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_FitChainToCurvePerItem.__PropertyOffset_Bezier, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001328 RID: 4904
		// (get) Token: 0x06004DEE RID: 19950 RVA: 0x00073240 File Offset: 0x00071440
		// (set) Token: 0x06004DEF RID: 19951 RVA: 0x00073250 File Offset: 0x00071450
		public unsafe EControlRigCurveAlignment Alignment
		{
			get
			{
				return (EControlRigCurveAlignment)(*(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurvePerItem.__PropertyOffset_Alignment));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurvePerItem.__PropertyOffset_Alignment) = (byte)value;
			}
		}

		// Token: 0x17001329 RID: 4905
		// (get) Token: 0x06004DF0 RID: 19952 RVA: 0x00073261 File Offset: 0x00071461
		// (set) Token: 0x06004DF1 RID: 19953 RVA: 0x00073271 File Offset: 0x00071471
		public unsafe float Minimum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurvePerItem.__PropertyOffset_Minimum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurvePerItem.__PropertyOffset_Minimum) = value;
			}
		}

		// Token: 0x1700132A RID: 4906
		// (get) Token: 0x06004DF2 RID: 19954 RVA: 0x00073282 File Offset: 0x00071482
		// (set) Token: 0x06004DF3 RID: 19955 RVA: 0x00073292 File Offset: 0x00071492
		public unsafe float Maximum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurvePerItem.__PropertyOffset_Maximum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurvePerItem.__PropertyOffset_Maximum) = value;
			}
		}

		// Token: 0x1700132B RID: 4907
		// (get) Token: 0x06004DF4 RID: 19956 RVA: 0x000732A3 File Offset: 0x000714A3
		// (set) Token: 0x06004DF5 RID: 19957 RVA: 0x000732B3 File Offset: 0x000714B3
		public unsafe int SamplingPrecision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurvePerItem.__PropertyOffset_SamplingPrecision);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurvePerItem.__PropertyOffset_SamplingPrecision) = value;
			}
		}

		// Token: 0x1700132C RID: 4908
		// (get) Token: 0x06004DF6 RID: 19958 RVA: 0x000732C4 File Offset: 0x000714C4
		// (set) Token: 0x06004DF7 RID: 19959 RVA: 0x000732D8 File Offset: 0x000714D8
		public unsafe FVector PrimaryAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurvePerItem.__PropertyOffset_PrimaryAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurvePerItem.__PropertyOffset_PrimaryAxis) = value;
			}
		}

		// Token: 0x1700132D RID: 4909
		// (get) Token: 0x06004DF8 RID: 19960 RVA: 0x000732ED File Offset: 0x000714ED
		// (set) Token: 0x06004DF9 RID: 19961 RVA: 0x00073301 File Offset: 0x00071501
		public unsafe FVector SecondaryAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurvePerItem.__PropertyOffset_SecondaryAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurvePerItem.__PropertyOffset_SecondaryAxis) = value;
			}
		}

		// Token: 0x1700132E RID: 4910
		// (get) Token: 0x06004DFA RID: 19962 RVA: 0x00073316 File Offset: 0x00071516
		// (set) Token: 0x06004DFB RID: 19963 RVA: 0x0007332A File Offset: 0x0007152A
		public unsafe FVector PoleVectorPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurvePerItem.__PropertyOffset_PoleVectorPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurvePerItem.__PropertyOffset_PoleVectorPosition) = value;
			}
		}

		// Token: 0x1700132F RID: 4911
		// (get) Token: 0x06004DFC RID: 19964 RVA: 0x00073340 File Offset: 0x00071540
		// (set) Token: 0x06004DFD RID: 19965 RVA: 0x00073383 File Offset: 0x00071583
		public TArray<FRigUnit_FitChainToCurve_Rotation> Rotations
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRigUnit_FitChainToCurve_Rotation> result;
				if ((result = this._Rotations) == null)
				{
					result = (this._Rotations = new TArray<FRigUnit_FitChainToCurve_Rotation>(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurvePerItem.__PropertyOffset_Rotations, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Rotations.CopyAssign(value);
			}
		}

		// Token: 0x17001330 RID: 4912
		// (get) Token: 0x06004DFE RID: 19966 RVA: 0x00073391 File Offset: 0x00071591
		// (set) Token: 0x06004DFF RID: 19967 RVA: 0x000733A1 File Offset: 0x000715A1
		public unsafe EControlRigAnimEasingType RotationEaseType
		{
			get
			{
				return (EControlRigAnimEasingType)(*(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurvePerItem.__PropertyOffset_RotationEaseType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurvePerItem.__PropertyOffset_RotationEaseType) = (byte)value;
			}
		}

		// Token: 0x17001331 RID: 4913
		// (get) Token: 0x06004E00 RID: 19968 RVA: 0x000733B2 File Offset: 0x000715B2
		// (set) Token: 0x06004E01 RID: 19969 RVA: 0x000733C2 File Offset: 0x000715C2
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurvePerItem.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurvePerItem.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x17001332 RID: 4914
		// (get) Token: 0x06004E02 RID: 19970 RVA: 0x000733D3 File Offset: 0x000715D3
		// (set) Token: 0x06004E03 RID: 19971 RVA: 0x000733E3 File Offset: 0x000715E3
		public unsafe bool bPropagateToChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurvePerItem.__PropertyOffset_bPropagateToChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurvePerItem.__PropertyOffset_bPropagateToChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001333 RID: 4915
		// (get) Token: 0x06004E04 RID: 19972 RVA: 0x000733F4 File Offset: 0x000715F4
		// (set) Token: 0x06004E05 RID: 19973 RVA: 0x00073437 File Offset: 0x00071637
		public FRigUnit_FitChainToCurve_DebugSettings DebugSettings
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_FitChainToCurve_DebugSettings result;
				if ((result = this._DebugSettings) == null)
				{
					result = (this._DebugSettings = new FRigUnit_FitChainToCurve_DebugSettings(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurvePerItem.__PropertyOffset_DebugSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_FitChainToCurve_DebugSettings.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_FitChainToCurvePerItem.__PropertyOffset_DebugSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001334 RID: 4916
		// (get) Token: 0x06004E06 RID: 19974 RVA: 0x00073458 File Offset: 0x00071658
		// (set) Token: 0x06004E07 RID: 19975 RVA: 0x0007349B File Offset: 0x0007169B
		public FRigUnit_FitChainToCurve_WorkData WorkData
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_FitChainToCurve_WorkData result;
				if ((result = this._WorkData) == null)
				{
					result = (this._WorkData = new FRigUnit_FitChainToCurve_WorkData(base.NativePtr + (IntPtr)FRigUnit_FitChainToCurvePerItem.__PropertyOffset_WorkData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_FitChainToCurve_WorkData.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_FitChainToCurvePerItem.__PropertyOffset_WorkData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06004E08 RID: 19976 RVA: 0x000734BC File Offset: 0x000716BC
		public FRigUnit_FitChainToCurvePerItem()
		{
		}

		// Token: 0x06004E09 RID: 19977 RVA: 0x000734C4 File Offset: 0x000716C4
		public FRigUnit_FitChainToCurvePerItem(FRigElementKeyCollection Items, FCRFourPointBezier Bezier, EControlRigCurveAlignment Alignment, float Minimum, float Maximum, int SamplingPrecision, FVector PrimaryAxis, FVector SecondaryAxis, FVector PoleVectorPosition, TArray<FRigUnit_FitChainToCurve_Rotation> Rotations, EControlRigAnimEasingType RotationEaseType, float Weight, bool bPropagateToChildren, FRigUnit_FitChainToCurve_DebugSettings DebugSettings, FRigUnit_FitChainToCurve_WorkData WorkData, FControlRigExecuteContext ExecuteContext)
		{
			this.Items = Items;
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

		// Token: 0x06004E0A RID: 19978 RVA: 0x00073554 File Offset: 0x00071754
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_FitChainToCurvePerItem.StaticStruct();
		}

		// Token: 0x06004E0B RID: 19979 RVA: 0x00073560 File Offset: 0x00071760
		[NullableContext(2)]
		public FRigUnit_FitChainToCurvePerItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004E0C RID: 19980 RVA: 0x0007356A File Offset: 0x0007176A
		public FRigUnit_FitChainToCurvePerItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004E0D RID: 19981 RVA: 0x00073575 File Offset: 0x00071775
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_FitChainToCurvePerItem(Pointer, false, true);
		}

		// Token: 0x06004E0E RID: 19982 RVA: 0x0007357F File Offset: 0x0007177F
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_FitChainToCurvePerItem(Pointer, MemoryOwner);
		}

		// Token: 0x040025A1 RID: 9633
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_FitChainToCurvePerItem";

		// Token: 0x040025A2 RID: 9634
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040025A3 RID: 9635
		internal static int __PropertyOffset_Items;

		// Token: 0x040025A4 RID: 9636
		[Nullable(2)]
		private FRigElementKeyCollection _Items;

		// Token: 0x040025A5 RID: 9637
		internal static int __PropertyOffset_Bezier;

		// Token: 0x040025A6 RID: 9638
		[Nullable(2)]
		private FCRFourPointBezier _Bezier;

		// Token: 0x040025A7 RID: 9639
		internal static int __PropertyOffset_Alignment;

		// Token: 0x040025A8 RID: 9640
		internal static int __PropertyOffset_Minimum;

		// Token: 0x040025A9 RID: 9641
		internal static int __PropertyOffset_Maximum;

		// Token: 0x040025AA RID: 9642
		internal static int __PropertyOffset_SamplingPrecision;

		// Token: 0x040025AB RID: 9643
		internal static int __PropertyOffset_PrimaryAxis;

		// Token: 0x040025AC RID: 9644
		internal static int __PropertyOffset_SecondaryAxis;

		// Token: 0x040025AD RID: 9645
		internal static int __PropertyOffset_PoleVectorPosition;

		// Token: 0x040025AE RID: 9646
		internal static int __PropertyOffset_Rotations;

		// Token: 0x040025AF RID: 9647
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRigUnit_FitChainToCurve_Rotation> _Rotations;

		// Token: 0x040025B0 RID: 9648
		internal static int __PropertyOffset_RotationEaseType;

		// Token: 0x040025B1 RID: 9649
		internal static int __PropertyOffset_Weight;

		// Token: 0x040025B2 RID: 9650
		internal static int __PropertyOffset_bPropagateToChildren;

		// Token: 0x040025B3 RID: 9651
		internal static int __PropertyOffset_DebugSettings;

		// Token: 0x040025B4 RID: 9652
		[Nullable(2)]
		private FRigUnit_FitChainToCurve_DebugSettings _DebugSettings;

		// Token: 0x040025B5 RID: 9653
		internal static int __PropertyOffset_WorkData;

		// Token: 0x040025B6 RID: 9654
		[Nullable(2)]
		private FRigUnit_FitChainToCurve_WorkData _WorkData;
	}
}
