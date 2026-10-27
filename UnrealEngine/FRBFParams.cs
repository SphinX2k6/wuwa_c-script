using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200033C RID: 828
	[UnrealObjectPath("/Script/AnimGraphRuntime.RBFParams")]
	[UnrealStructLayout(44, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 44)]
	public class FRBFParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002E1D RID: 11805 RVA: 0x00046BF0 File Offset: 0x00044DF0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRBFParams._ScriptStructPtr != 0) ? FRBFParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.RBFParams", ref FRBFParams._ScriptStructPtr);
		}

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x06002E1E RID: 11806 RVA: 0x00046C14 File Offset: 0x00044E14
		// (set) Token: 0x06002E1F RID: 11807 RVA: 0x00046C24 File Offset: 0x00044E24
		public unsafe int TargetDimensions
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRBFParams.__PropertyOffset_TargetDimensions);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRBFParams.__PropertyOffset_TargetDimensions) = value;
			}
		}

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x06002E20 RID: 11808 RVA: 0x00046C35 File Offset: 0x00044E35
		// (set) Token: 0x06002E21 RID: 11809 RVA: 0x00046C45 File Offset: 0x00044E45
		public unsafe ERBFSolverType SolverType
		{
			get
			{
				return (ERBFSolverType)(*(base.NativePtr + (IntPtr)FRBFParams.__PropertyOffset_SolverType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRBFParams.__PropertyOffset_SolverType) = (byte)value;
			}
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x06002E22 RID: 11810 RVA: 0x00046C56 File Offset: 0x00044E56
		// (set) Token: 0x06002E23 RID: 11811 RVA: 0x00046C66 File Offset: 0x00044E66
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRBFParams.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRBFParams.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x06002E24 RID: 11812 RVA: 0x00046C77 File Offset: 0x00044E77
		// (set) Token: 0x06002E25 RID: 11813 RVA: 0x00046C87 File Offset: 0x00044E87
		public unsafe bool bAutomaticRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRBFParams.__PropertyOffset_bAutomaticRadius) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRBFParams.__PropertyOffset_bAutomaticRadius) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x06002E26 RID: 11814 RVA: 0x00046C98 File Offset: 0x00044E98
		// (set) Token: 0x06002E27 RID: 11815 RVA: 0x00046CA8 File Offset: 0x00044EA8
		public unsafe ERBFFunctionType Function
		{
			get
			{
				return (ERBFFunctionType)(*(base.NativePtr + (IntPtr)FRBFParams.__PropertyOffset_Function));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRBFParams.__PropertyOffset_Function) = (byte)value;
			}
		}

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x06002E28 RID: 11816 RVA: 0x00046CB9 File Offset: 0x00044EB9
		// (set) Token: 0x06002E29 RID: 11817 RVA: 0x00046CC9 File Offset: 0x00044EC9
		public unsafe ERBFDistanceMethod DistanceMethod
		{
			get
			{
				return (ERBFDistanceMethod)(*(base.NativePtr + (IntPtr)FRBFParams.__PropertyOffset_DistanceMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRBFParams.__PropertyOffset_DistanceMethod) = (byte)value;
			}
		}

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x06002E2A RID: 11818 RVA: 0x00046CDA File Offset: 0x00044EDA
		// (set) Token: 0x06002E2B RID: 11819 RVA: 0x00046CEE File Offset: 0x00044EEE
		public unsafe TEnumAsByte<EBoneAxis> TwistAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRBFParams.__PropertyOffset_TwistAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRBFParams.__PropertyOffset_TwistAxis) = value;
			}
		}

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x06002E2C RID: 11820 RVA: 0x00046D03 File Offset: 0x00044F03
		// (set) Token: 0x06002E2D RID: 11821 RVA: 0x00046D13 File Offset: 0x00044F13
		public unsafe float WeightThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRBFParams.__PropertyOffset_WeightThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRBFParams.__PropertyOffset_WeightThreshold) = value;
			}
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x06002E2E RID: 11822 RVA: 0x00046D24 File Offset: 0x00044F24
		// (set) Token: 0x06002E2F RID: 11823 RVA: 0x00046D34 File Offset: 0x00044F34
		public unsafe ERBFNormalizeMethod NormalizeMethod
		{
			get
			{
				return (ERBFNormalizeMethod)(*(base.NativePtr + (IntPtr)FRBFParams.__PropertyOffset_NormalizeMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRBFParams.__PropertyOffset_NormalizeMethod) = (byte)value;
			}
		}

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x06002E30 RID: 11824 RVA: 0x00046D45 File Offset: 0x00044F45
		// (set) Token: 0x06002E31 RID: 11825 RVA: 0x00046D59 File Offset: 0x00044F59
		public unsafe FVector MedianReference
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRBFParams.__PropertyOffset_MedianReference);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRBFParams.__PropertyOffset_MedianReference) = value;
			}
		}

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x06002E32 RID: 11826 RVA: 0x00046D6E File Offset: 0x00044F6E
		// (set) Token: 0x06002E33 RID: 11827 RVA: 0x00046D7E File Offset: 0x00044F7E
		public unsafe float MedianMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRBFParams.__PropertyOffset_MedianMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRBFParams.__PropertyOffset_MedianMin) = value;
			}
		}

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x06002E34 RID: 11828 RVA: 0x00046D8F File Offset: 0x00044F8F
		// (set) Token: 0x06002E35 RID: 11829 RVA: 0x00046D9F File Offset: 0x00044F9F
		public unsafe float MedianMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRBFParams.__PropertyOffset_MedianMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRBFParams.__PropertyOffset_MedianMax) = value;
			}
		}

		// Token: 0x06002E36 RID: 11830 RVA: 0x00046DB0 File Offset: 0x00044FB0
		public FRBFParams()
		{
		}

		// Token: 0x06002E37 RID: 11831 RVA: 0x00046DB8 File Offset: 0x00044FB8
		public FRBFParams(int TargetDimensions, ERBFSolverType SolverType, float Radius, bool bAutomaticRadius, ERBFFunctionType Function, ERBFDistanceMethod DistanceMethod, TEnumAsByte<EBoneAxis> TwistAxis, float WeightThreshold, ERBFNormalizeMethod NormalizeMethod, FVector MedianReference, float MedianMin, float MedianMax)
		{
			this.TargetDimensions = TargetDimensions;
			this.SolverType = SolverType;
			this.Radius = Radius;
			this.bAutomaticRadius = bAutomaticRadius;
			this.Function = Function;
			this.DistanceMethod = DistanceMethod;
			this.TwistAxis = TwistAxis;
			this.WeightThreshold = WeightThreshold;
			this.NormalizeMethod = NormalizeMethod;
			this.MedianReference = MedianReference;
			this.MedianMin = MedianMin;
			this.MedianMax = MedianMax;
		}

		// Token: 0x06002E38 RID: 11832 RVA: 0x00046E28 File Offset: 0x00045028
		protected override IntPtr GetUStructPtr()
		{
			return FRBFParams.StaticStruct();
		}

		// Token: 0x06002E39 RID: 11833 RVA: 0x00046E34 File Offset: 0x00045034
		[NullableContext(2)]
		public FRBFParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002E3A RID: 11834 RVA: 0x00046E3E File Offset: 0x0004503E
		public FRBFParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002E3B RID: 11835 RVA: 0x00046E49 File Offset: 0x00045049
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRBFParams(Pointer, false, true);
		}

		// Token: 0x06002E3C RID: 11836 RVA: 0x00046E53 File Offset: 0x00045053
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRBFParams(Pointer, MemoryOwner);
		}

		// Token: 0x040013C2 RID: 5058
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AnimGraphRuntime.RBFParams";

		// Token: 0x040013C3 RID: 5059
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040013C4 RID: 5060
		internal static int __PropertyOffset_TargetDimensions;

		// Token: 0x040013C5 RID: 5061
		internal static int __PropertyOffset_SolverType;

		// Token: 0x040013C6 RID: 5062
		internal static int __PropertyOffset_Radius;

		// Token: 0x040013C7 RID: 5063
		internal static int __PropertyOffset_bAutomaticRadius;

		// Token: 0x040013C8 RID: 5064
		internal static int __PropertyOffset_Function;

		// Token: 0x040013C9 RID: 5065
		internal static int __PropertyOffset_DistanceMethod;

		// Token: 0x040013CA RID: 5066
		internal static int __PropertyOffset_TwistAxis;

		// Token: 0x040013CB RID: 5067
		internal static int __PropertyOffset_WeightThreshold;

		// Token: 0x040013CC RID: 5068
		internal static int __PropertyOffset_NormalizeMethod;

		// Token: 0x040013CD RID: 5069
		internal static int __PropertyOffset_MedianReference;

		// Token: 0x040013CE RID: 5070
		internal static int __PropertyOffset_MedianMin;

		// Token: 0x040013CF RID: 5071
		internal static int __PropertyOffset_MedianMax;
	}
}
