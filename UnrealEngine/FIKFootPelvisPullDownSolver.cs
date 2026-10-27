using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000332 RID: 818
	[UnrealObjectPath("/Script/AnimGraphRuntime.IKFootPelvisPullDownSolver")]
	[UnrealStructLayout(76, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 76)]
	public class FIKFootPelvisPullDownSolver : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002D7A RID: 11642 RVA: 0x00045BC1 File Offset: 0x00043DC1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FIKFootPelvisPullDownSolver._ScriptStructPtr != 0) ? FIKFootPelvisPullDownSolver._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.IKFootPelvisPullDownSolver", ref FIKFootPelvisPullDownSolver._ScriptStructPtr);
		}

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x06002D7B RID: 11643 RVA: 0x00045BE5 File Offset: 0x00043DE5
		// (set) Token: 0x06002D7C RID: 11644 RVA: 0x00045BF9 File Offset: 0x00043DF9
		public unsafe FVectorRK4SpringInterpolator PelvisAdjustmentInterp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIKFootPelvisPullDownSolver.__PropertyOffset_PelvisAdjustmentInterp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIKFootPelvisPullDownSolver.__PropertyOffset_PelvisAdjustmentInterp) = value;
			}
		}

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x06002D7D RID: 11645 RVA: 0x00045C0E File Offset: 0x00043E0E
		// (set) Token: 0x06002D7E RID: 11646 RVA: 0x00045C1E File Offset: 0x00043E1E
		public unsafe float PelvisAdjustmentInterpAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIKFootPelvisPullDownSolver.__PropertyOffset_PelvisAdjustmentInterpAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIKFootPelvisPullDownSolver.__PropertyOffset_PelvisAdjustmentInterpAlpha) = value;
			}
		}

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x06002D7F RID: 11647 RVA: 0x00045C2F File Offset: 0x00043E2F
		// (set) Token: 0x06002D80 RID: 11648 RVA: 0x00045C3F File Offset: 0x00043E3F
		public unsafe float PelvisAdjustmentMaxDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIKFootPelvisPullDownSolver.__PropertyOffset_PelvisAdjustmentMaxDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIKFootPelvisPullDownSolver.__PropertyOffset_PelvisAdjustmentMaxDistance) = value;
			}
		}

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x06002D81 RID: 11649 RVA: 0x00045C50 File Offset: 0x00043E50
		// (set) Token: 0x06002D82 RID: 11650 RVA: 0x00045C60 File Offset: 0x00043E60
		public unsafe float PelvisAdjustmentErrorTolerance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIKFootPelvisPullDownSolver.__PropertyOffset_PelvisAdjustmentErrorTolerance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIKFootPelvisPullDownSolver.__PropertyOffset_PelvisAdjustmentErrorTolerance) = value;
			}
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x06002D83 RID: 11651 RVA: 0x00045C71 File Offset: 0x00043E71
		// (set) Token: 0x06002D84 RID: 11652 RVA: 0x00045C81 File Offset: 0x00043E81
		public unsafe int PelvisAdjustmentMaxIter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIKFootPelvisPullDownSolver.__PropertyOffset_PelvisAdjustmentMaxIter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIKFootPelvisPullDownSolver.__PropertyOffset_PelvisAdjustmentMaxIter) = value;
			}
		}

		// Token: 0x06002D85 RID: 11653 RVA: 0x00045C92 File Offset: 0x00043E92
		public FIKFootPelvisPullDownSolver()
		{
		}

		// Token: 0x06002D86 RID: 11654 RVA: 0x00045C9A File Offset: 0x00043E9A
		public FIKFootPelvisPullDownSolver(FVectorRK4SpringInterpolator PelvisAdjustmentInterp, float PelvisAdjustmentInterpAlpha, float PelvisAdjustmentMaxDistance, float PelvisAdjustmentErrorTolerance, int PelvisAdjustmentMaxIter)
		{
			this.PelvisAdjustmentInterp = PelvisAdjustmentInterp;
			this.PelvisAdjustmentInterpAlpha = PelvisAdjustmentInterpAlpha;
			this.PelvisAdjustmentMaxDistance = PelvisAdjustmentMaxDistance;
			this.PelvisAdjustmentErrorTolerance = PelvisAdjustmentErrorTolerance;
			this.PelvisAdjustmentMaxIter = PelvisAdjustmentMaxIter;
		}

		// Token: 0x06002D87 RID: 11655 RVA: 0x00045CC7 File Offset: 0x00043EC7
		protected override IntPtr GetUStructPtr()
		{
			return FIKFootPelvisPullDownSolver.StaticStruct();
		}

		// Token: 0x06002D88 RID: 11656 RVA: 0x00045CD3 File Offset: 0x00043ED3
		[NullableContext(2)]
		public FIKFootPelvisPullDownSolver(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002D89 RID: 11657 RVA: 0x00045CDD File Offset: 0x00043EDD
		public FIKFootPelvisPullDownSolver(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002D8A RID: 11658 RVA: 0x00045CE8 File Offset: 0x00043EE8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FIKFootPelvisPullDownSolver(Pointer, false, true);
		}

		// Token: 0x06002D8B RID: 11659 RVA: 0x00045CF2 File Offset: 0x00043EF2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FIKFootPelvisPullDownSolver(Pointer, MemoryOwner);
		}

		// Token: 0x0400137A RID: 4986
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AnimGraphRuntime.IKFootPelvisPullDownSolver";

		// Token: 0x0400137B RID: 4987
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400137C RID: 4988
		internal static int __PropertyOffset_PelvisAdjustmentInterp;

		// Token: 0x0400137D RID: 4989
		internal static int __PropertyOffset_PelvisAdjustmentInterpAlpha;

		// Token: 0x0400137E RID: 4990
		internal static int __PropertyOffset_PelvisAdjustmentMaxDistance;

		// Token: 0x0400137F RID: 4991
		internal static int __PropertyOffset_PelvisAdjustmentErrorTolerance;

		// Token: 0x04001380 RID: 4992
		internal static int __PropertyOffset_PelvisAdjustmentMaxIter;
	}
}
