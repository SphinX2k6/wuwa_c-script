using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020019CA RID: 6602
	[UnrealObjectPath("/Script/KuroMath.KuroSplineSamplingOptions")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FKuroSplineSamplingOptions : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06018883 RID: 100483 RVA: 0x0024215E File Offset: 0x0024035E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroSplineSamplingOptions._ScriptStructPtr != 0) ? FKuroSplineSamplingOptions._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroMath.KuroSplineSamplingOptions", ref FKuroSplineSamplingOptions._ScriptStructPtr);
		}

		// Token: 0x170061D1 RID: 25041
		// (get) Token: 0x06018884 RID: 100484 RVA: 0x00242182 File Offset: 0x00240382
		// (set) Token: 0x06018885 RID: 100485 RVA: 0x00242192 File Offset: 0x00240392
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

		// Token: 0x170061D2 RID: 25042
		// (get) Token: 0x06018886 RID: 100486 RVA: 0x002421A3 File Offset: 0x002403A3
		// (set) Token: 0x06018887 RID: 100487 RVA: 0x002421B3 File Offset: 0x002403B3
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

		// Token: 0x170061D3 RID: 25043
		// (get) Token: 0x06018888 RID: 100488 RVA: 0x002421C4 File Offset: 0x002403C4
		// (set) Token: 0x06018889 RID: 100489 RVA: 0x002421D4 File Offset: 0x002403D4
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

		// Token: 0x170061D4 RID: 25044
		// (get) Token: 0x0601888A RID: 100490 RVA: 0x002421E5 File Offset: 0x002403E5
		// (set) Token: 0x0601888B RID: 100491 RVA: 0x002421F9 File Offset: 0x002403F9
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

		// Token: 0x0601888C RID: 100492 RVA: 0x0024220E File Offset: 0x0024040E
		public FKuroSplineSamplingOptions()
		{
		}

		// Token: 0x0601888D RID: 100493 RVA: 0x00242216 File Offset: 0x00240416
		public FKuroSplineSamplingOptions(int NumSamples, float ErrorTolerance, EKuroMathSampleSpacing SampleSpacing, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace)
		{
			this.NumSamples = NumSamples;
			this.ErrorTolerance = ErrorTolerance;
			this.SampleSpacing = SampleSpacing;
			this.CoordinateSpace = CoordinateSpace;
		}

		// Token: 0x0601888E RID: 100494 RVA: 0x0024223B File Offset: 0x0024043B
		protected override IntPtr GetUStructPtr()
		{
			return FKuroSplineSamplingOptions.StaticStruct();
		}

		// Token: 0x0601888F RID: 100495 RVA: 0x00242247 File Offset: 0x00240447
		[NullableContext(2)]
		public FKuroSplineSamplingOptions(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018890 RID: 100496 RVA: 0x00242251 File Offset: 0x00240451
		public FKuroSplineSamplingOptions(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018891 RID: 100497 RVA: 0x0024225C File Offset: 0x0024045C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroSplineSamplingOptions(Pointer, false, true);
		}

		// Token: 0x06018892 RID: 100498 RVA: 0x00242266 File Offset: 0x00240466
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroSplineSamplingOptions(Pointer, MemoryOwner);
		}

		// Token: 0x0400D413 RID: 54291
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroMath.KuroSplineSamplingOptions";

		// Token: 0x0400D414 RID: 54292
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D415 RID: 54293
		internal static int __PropertyOffset_NumSamples;

		// Token: 0x0400D416 RID: 54294
		internal static int __PropertyOffset_ErrorTolerance;

		// Token: 0x0400D417 RID: 54295
		internal static int __PropertyOffset_SampleSpacing;

		// Token: 0x0400D418 RID: 54296
		internal static int __PropertyOffset_CoordinateSpace;
	}
}
