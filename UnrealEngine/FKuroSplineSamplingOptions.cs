using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200045F RID: 1119
	[UnrealObjectPath("/Script/KuroMath.KuroSplineSamplingOptions")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FKuroSplineSamplingOptions : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006B5A RID: 27482 RVA: 0x0009C4B2 File Offset: 0x0009A6B2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroSplineSamplingOptions._ScriptStructPtr != 0) ? FKuroSplineSamplingOptions._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroMath.KuroSplineSamplingOptions", ref FKuroSplineSamplingOptions._ScriptStructPtr);
		}

		// Token: 0x17001554 RID: 5460
		// (get) Token: 0x06006B5B RID: 27483 RVA: 0x0009C4D6 File Offset: 0x0009A6D6
		// (set) Token: 0x06006B5C RID: 27484 RVA: 0x0009C4E6 File Offset: 0x0009A6E6
		public unsafe int NumSamples
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSplineSamplingOptions.__PropertyOffset_NumSamples);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSplineSamplingOptions.__PropertyOffset_NumSamples) = value;
			}
		}

		// Token: 0x17001555 RID: 5461
		// (get) Token: 0x06006B5D RID: 27485 RVA: 0x0009C4F7 File Offset: 0x0009A6F7
		// (set) Token: 0x06006B5E RID: 27486 RVA: 0x0009C507 File Offset: 0x0009A707
		public unsafe float ErrorTolerance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSplineSamplingOptions.__PropertyOffset_ErrorTolerance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSplineSamplingOptions.__PropertyOffset_ErrorTolerance) = value;
			}
		}

		// Token: 0x17001556 RID: 5462
		// (get) Token: 0x06006B5F RID: 27487 RVA: 0x0009C518 File Offset: 0x0009A718
		// (set) Token: 0x06006B60 RID: 27488 RVA: 0x0009C528 File Offset: 0x0009A728
		public unsafe EKuroMathSampleSpacing SampleSpacing
		{
			get
			{
				return (EKuroMathSampleSpacing)(*(base.NativePtr + (IntPtr)FKuroSplineSamplingOptions.__PropertyOffset_SampleSpacing));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSplineSamplingOptions.__PropertyOffset_SampleSpacing) = (byte)value;
			}
		}

		// Token: 0x17001557 RID: 5463
		// (get) Token: 0x06006B61 RID: 27489 RVA: 0x0009C539 File Offset: 0x0009A739
		// (set) Token: 0x06006B62 RID: 27490 RVA: 0x0009C54D File Offset: 0x0009A74D
		public unsafe TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSplineSamplingOptions.__PropertyOffset_CoordinateSpace);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSplineSamplingOptions.__PropertyOffset_CoordinateSpace) = value;
			}
		}

		// Token: 0x06006B63 RID: 27491 RVA: 0x0009C562 File Offset: 0x0009A762
		public FKuroSplineSamplingOptions()
		{
		}

		// Token: 0x06006B64 RID: 27492 RVA: 0x0009C56A File Offset: 0x0009A76A
		protected override IntPtr GetUStructPtr()
		{
			return FKuroSplineSamplingOptions.StaticStruct();
		}

		// Token: 0x06006B65 RID: 27493 RVA: 0x0009C576 File Offset: 0x0009A776
		[NullableContext(2)]
		public FKuroSplineSamplingOptions(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006B66 RID: 27494 RVA: 0x0009C580 File Offset: 0x0009A780
		public FKuroSplineSamplingOptions(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006B67 RID: 27495 RVA: 0x0009C58B File Offset: 0x0009A78B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroSplineSamplingOptions(Pointer, false, true);
		}

		// Token: 0x06006B68 RID: 27496 RVA: 0x0009C595 File Offset: 0x0009A795
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroSplineSamplingOptions(Pointer, MemoryOwner);
		}

		// Token: 0x04002DAC RID: 11692
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroMath.KuroSplineSamplingOptions";

		// Token: 0x04002DAD RID: 11693
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002DAE RID: 11694
		internal static int __PropertyOffset_NumSamples;

		// Token: 0x04002DAF RID: 11695
		internal static int __PropertyOffset_ErrorTolerance;

		// Token: 0x04002DB0 RID: 11696
		internal static int __PropertyOffset_SampleSpacing;

		// Token: 0x04002DB1 RID: 11697
		internal static int __PropertyOffset_CoordinateSpace;
	}
}
