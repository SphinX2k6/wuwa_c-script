using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000199 RID: 409
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.EnvQueryGenerator_OnCircle")]
	[UnrealStructLayout(576, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 576)]
	public class UEnvQueryGenerator_OnCircle : UEnvQueryGenerator_ProjectedPoints, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001953 RID: 6483 RVA: 0x000257FC File Offset: 0x000239FC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEnvQueryGenerator_OnCircle._ClassPtr;
		}

		// Token: 0x06001954 RID: 6484 RVA: 0x00025808 File Offset: 0x00023A08
		public UEnvQueryGenerator_OnCircle() : this(BuiltinUtils.AllocNativeUObject(UEnvQueryGenerator_OnCircle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001955 RID: 6485 RVA: 0x00025830 File Offset: 0x00023A30
		public UEnvQueryGenerator_OnCircle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEnvQueryGenerator_OnCircle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06001956 RID: 6486 RVA: 0x00025864 File Offset: 0x00023A64
		// (set) Token: 0x06001957 RID: 6487 RVA: 0x0002589D File Offset: 0x00023A9D
		public FAIDataProviderFloatValue CircleRadius
		{
			get
			{
				base.FastCheckIsValid();
				FAIDataProviderFloatValue result;
				if ((result = this._CircleRadius) == null)
				{
					result = (this._CircleRadius = new FAIDataProviderFloatValue(base.NativePtr + (IntPtr)UEnvQueryGenerator_OnCircle.__PropertyOffset_CircleRadius, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAIDataProviderFloatValue.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryGenerator_OnCircle.__PropertyOffset_CircleRadius, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06001958 RID: 6488 RVA: 0x000258C0 File Offset: 0x00023AC0
		// (set) Token: 0x06001959 RID: 6489 RVA: 0x000258F9 File Offset: 0x00023AF9
		public FAIDataProviderFloatValue SpaceBetween
		{
			get
			{
				base.FastCheckIsValid();
				FAIDataProviderFloatValue result;
				if ((result = this._SpaceBetween) == null)
				{
					result = (this._SpaceBetween = new FAIDataProviderFloatValue(base.NativePtr + (IntPtr)UEnvQueryGenerator_OnCircle.__PropertyOffset_SpaceBetween, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAIDataProviderFloatValue.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryGenerator_OnCircle.__PropertyOffset_SpaceBetween, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x0600195A RID: 6490 RVA: 0x0002591C File Offset: 0x00023B1C
		// (set) Token: 0x0600195B RID: 6491 RVA: 0x00025955 File Offset: 0x00023B55
		public FAIDataProviderIntValue NumberOfPoints
		{
			get
			{
				base.FastCheckIsValid();
				FAIDataProviderIntValue result;
				if ((result = this._NumberOfPoints) == null)
				{
					result = (this._NumberOfPoints = new FAIDataProviderIntValue(base.NativePtr + (IntPtr)UEnvQueryGenerator_OnCircle.__PropertyOffset_NumberOfPoints, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAIDataProviderIntValue.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryGenerator_OnCircle.__PropertyOffset_NumberOfPoints, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x0600195C RID: 6492 RVA: 0x00025976 File Offset: 0x00023B76
		// (set) Token: 0x0600195D RID: 6493 RVA: 0x00025986 File Offset: 0x00023B86
		public unsafe EPointOnCircleSpacingMethod PointOnCircleSpacingMethod
		{
			get
			{
				return (EPointOnCircleSpacingMethod)(*(base.NativePtr + (IntPtr)UEnvQueryGenerator_OnCircle.__PropertyOffset_PointOnCircleSpacingMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryGenerator_OnCircle.__PropertyOffset_PointOnCircleSpacingMethod) = (byte)value;
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x0600195E RID: 6494 RVA: 0x00025998 File Offset: 0x00023B98
		// (set) Token: 0x0600195F RID: 6495 RVA: 0x000259D1 File Offset: 0x00023BD1
		public FEnvDirection ArcDirection
		{
			get
			{
				base.FastCheckIsValid();
				FEnvDirection result;
				if ((result = this._ArcDirection) == null)
				{
					result = (this._ArcDirection = new FEnvDirection(base.NativePtr + (IntPtr)UEnvQueryGenerator_OnCircle.__PropertyOffset_ArcDirection, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEnvDirection.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryGenerator_OnCircle.__PropertyOffset_ArcDirection, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06001960 RID: 6496 RVA: 0x000259F4 File Offset: 0x00023BF4
		// (set) Token: 0x06001961 RID: 6497 RVA: 0x00025A2D File Offset: 0x00023C2D
		public FAIDataProviderFloatValue ArcAngle
		{
			get
			{
				base.FastCheckIsValid();
				FAIDataProviderFloatValue result;
				if ((result = this._ArcAngle) == null)
				{
					result = (this._ArcAngle = new FAIDataProviderFloatValue(base.NativePtr + (IntPtr)UEnvQueryGenerator_OnCircle.__PropertyOffset_ArcAngle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAIDataProviderFloatValue.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryGenerator_OnCircle.__PropertyOffset_ArcAngle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06001962 RID: 6498 RVA: 0x00025A4E File Offset: 0x00023C4E
		// (set) Token: 0x06001963 RID: 6499 RVA: 0x00025A5E File Offset: 0x00023C5E
		public unsafe float AngleRadians
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEnvQueryGenerator_OnCircle.__PropertyOffset_AngleRadians);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryGenerator_OnCircle.__PropertyOffset_AngleRadians) = value;
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06001964 RID: 6500 RVA: 0x00025A6F File Offset: 0x00023C6F
		// (set) Token: 0x06001965 RID: 6501 RVA: 0x00025A83 File Offset: 0x00023C83
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UEnvQueryContext> CircleCenter
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UEnvQueryGenerator_OnCircle.__PropertyOffset_CircleCenter);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryGenerator_OnCircle.__PropertyOffset_CircleCenter) = value;
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06001966 RID: 6502 RVA: 0x00025A98 File Offset: 0x00023C98
		// (set) Token: 0x06001967 RID: 6503 RVA: 0x00025AA8 File Offset: 0x00023CA8
		public unsafe bool bIgnoreAnyContextActorsWhenGeneratingCircle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEnvQueryGenerator_OnCircle.__PropertyOffset_bIgnoreAnyContextActorsWhenGeneratingCircle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryGenerator_OnCircle.__PropertyOffset_bIgnoreAnyContextActorsWhenGeneratingCircle) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06001968 RID: 6504 RVA: 0x00025ABC File Offset: 0x00023CBC
		// (set) Token: 0x06001969 RID: 6505 RVA: 0x00025AF5 File Offset: 0x00023CF5
		public FAIDataProviderFloatValue CircleCenterZOffset
		{
			get
			{
				base.FastCheckIsValid();
				FAIDataProviderFloatValue result;
				if ((result = this._CircleCenterZOffset) == null)
				{
					result = (this._CircleCenterZOffset = new FAIDataProviderFloatValue(base.NativePtr + (IntPtr)UEnvQueryGenerator_OnCircle.__PropertyOffset_CircleCenterZOffset, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAIDataProviderFloatValue.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryGenerator_OnCircle.__PropertyOffset_CircleCenterZOffset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x0600196A RID: 6506 RVA: 0x00025B18 File Offset: 0x00023D18
		// (set) Token: 0x0600196B RID: 6507 RVA: 0x00025B51 File Offset: 0x00023D51
		public FEnvTraceData TraceData
		{
			get
			{
				base.FastCheckIsValid();
				FEnvTraceData result;
				if ((result = this._TraceData) == null)
				{
					result = (this._TraceData = new FEnvTraceData(base.NativePtr + (IntPtr)UEnvQueryGenerator_OnCircle.__PropertyOffset_TraceData, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEnvTraceData.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryGenerator_OnCircle.__PropertyOffset_TraceData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x0600196C RID: 6508 RVA: 0x00025B72 File Offset: 0x00023D72
		// (set) Token: 0x0600196D RID: 6509 RVA: 0x00025B8B File Offset: 0x00023D8B
		public unsafe bool bDefineArc
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UEnvQueryGenerator_OnCircle.__PropertyOffset_bDefineArc) & UEnvQueryGenerator_OnCircle.__PropertyMask_bDefineArc) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UEnvQueryGenerator_OnCircle.__PropertyOffset_bDefineArc) = ((*(base.NativePtr + (IntPtr)UEnvQueryGenerator_OnCircle.__PropertyOffset_bDefineArc) & ~UEnvQueryGenerator_OnCircle.__PropertyMask_bDefineArc) | (value ? UEnvQueryGenerator_OnCircle.__PropertyMask_bDefineArc : 0));
			}
		}

		// Token: 0x0600196E RID: 6510 RVA: 0x00025BBB File Offset: 0x00023DBB
		static UEnvQueryGenerator_OnCircle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.EnvQueryGenerator_OnCircle");
		}

		// Token: 0x0600196F RID: 6511 RVA: 0x00025BC9 File Offset: 0x00023DC9
		protected UEnvQueryGenerator_OnCircle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400074F RID: 1871
		public new const string __ObjectPath = "/Script/AIModule.EnvQueryGenerator_OnCircle";

		// Token: 0x04000750 RID: 1872
		private static IntPtr _ClassPtr;

		// Token: 0x04000751 RID: 1873
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000752 RID: 1874
		internal static int __PropertyOffset_CircleRadius;

		// Token: 0x04000753 RID: 1875
		[Nullable(2)]
		private FAIDataProviderFloatValue _CircleRadius;

		// Token: 0x04000754 RID: 1876
		internal static int __PropertyOffset_SpaceBetween;

		// Token: 0x04000755 RID: 1877
		[Nullable(2)]
		private FAIDataProviderFloatValue _SpaceBetween;

		// Token: 0x04000756 RID: 1878
		internal static int __PropertyOffset_NumberOfPoints;

		// Token: 0x04000757 RID: 1879
		[Nullable(2)]
		private FAIDataProviderIntValue _NumberOfPoints;

		// Token: 0x04000758 RID: 1880
		internal static int __PropertyOffset_PointOnCircleSpacingMethod;

		// Token: 0x04000759 RID: 1881
		internal static int __PropertyOffset_ArcDirection;

		// Token: 0x0400075A RID: 1882
		[Nullable(2)]
		private FEnvDirection _ArcDirection;

		// Token: 0x0400075B RID: 1883
		internal static int __PropertyOffset_ArcAngle;

		// Token: 0x0400075C RID: 1884
		[Nullable(2)]
		private FAIDataProviderFloatValue _ArcAngle;

		// Token: 0x0400075D RID: 1885
		internal static int __PropertyOffset_AngleRadians;

		// Token: 0x0400075E RID: 1886
		internal static int __PropertyOffset_CircleCenter;

		// Token: 0x0400075F RID: 1887
		internal static int __PropertyOffset_bIgnoreAnyContextActorsWhenGeneratingCircle;

		// Token: 0x04000760 RID: 1888
		internal static int __PropertyOffset_CircleCenterZOffset;

		// Token: 0x04000761 RID: 1889
		[Nullable(2)]
		private FAIDataProviderFloatValue _CircleCenterZOffset;

		// Token: 0x04000762 RID: 1890
		internal static int __PropertyOffset_TraceData;

		// Token: 0x04000763 RID: 1891
		[Nullable(2)]
		private FEnvTraceData _TraceData;

		// Token: 0x04000764 RID: 1892
		internal static int __PropertyOffset_bDefineArc;

		// Token: 0x04000765 RID: 1893
		internal static byte __PropertyMask_bDefineArc;
	}
}
