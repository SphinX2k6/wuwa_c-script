using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001177 RID: 4471
	[UnrealObjectPath("/Script/Engine.SplineComponent")]
	[UnrealStructLayout(1872, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1872)]
	public class USplineComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010542 RID: 66882 RVA: 0x00180CF3 File Offset: 0x0017EEF3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USplineComponent._ClassPtr;
		}

		// Token: 0x06010543 RID: 66883 RVA: 0x00180D00 File Offset: 0x0017EF00
		public USplineComponent() : this(BuiltinUtils.AllocNativeUObject(USplineComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010544 RID: 66884 RVA: 0x00180D28 File Offset: 0x0017EF28
		[NullableContext(1)]
		public USplineComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USplineComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003FF3 RID: 16371
		// (get) Token: 0x06010545 RID: 66885 RVA: 0x00180D5C File Offset: 0x0017EF5C
		// (set) Token: 0x06010546 RID: 66886 RVA: 0x00180D95 File Offset: 0x0017EF95
		[Nullable(1)]
		public FSplineCurves SplineCurves
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FSplineCurves result;
				if ((result = this._SplineCurves) == null)
				{
					result = (this._SplineCurves = new FSplineCurves(base.NativePtr + (IntPtr)USplineComponent.__PropertyOffset_SplineCurves, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSplineCurves.StaticStruct(), base.NativePtr + (IntPtr)USplineComponent.__PropertyOffset_SplineCurves, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003FF4 RID: 16372
		// (get) Token: 0x06010547 RID: 66887 RVA: 0x00180DB8 File Offset: 0x0017EFB8
		// (set) Token: 0x06010548 RID: 66888 RVA: 0x00180DF1 File Offset: 0x0017EFF1
		[Nullable(1)]
		public FInterpCurveVector SplineInfo_DEPRECATED
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FInterpCurveVector result;
				if ((result = this._SplineInfo_DEPRECATED) == null)
				{
					result = (this._SplineInfo_DEPRECATED = new FInterpCurveVector(base.NativePtr + (IntPtr)USplineComponent.__PropertyOffset_SplineInfo_DEPRECATED, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInterpCurveVector.StaticStruct(), base.NativePtr + (IntPtr)USplineComponent.__PropertyOffset_SplineInfo_DEPRECATED, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003FF5 RID: 16373
		// (get) Token: 0x06010549 RID: 66889 RVA: 0x00180E14 File Offset: 0x0017F014
		// (set) Token: 0x0601054A RID: 66890 RVA: 0x00180E4D File Offset: 0x0017F04D
		[Nullable(1)]
		public FInterpCurveQuat SplineRotInfo_DEPRECATED
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FInterpCurveQuat result;
				if ((result = this._SplineRotInfo_DEPRECATED) == null)
				{
					result = (this._SplineRotInfo_DEPRECATED = new FInterpCurveQuat(base.NativePtr + (IntPtr)USplineComponent.__PropertyOffset_SplineRotInfo_DEPRECATED, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInterpCurveQuat.StaticStruct(), base.NativePtr + (IntPtr)USplineComponent.__PropertyOffset_SplineRotInfo_DEPRECATED, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003FF6 RID: 16374
		// (get) Token: 0x0601054B RID: 66891 RVA: 0x00180E70 File Offset: 0x0017F070
		// (set) Token: 0x0601054C RID: 66892 RVA: 0x00180EA9 File Offset: 0x0017F0A9
		[Nullable(1)]
		public FInterpCurveVector SplineScaleInfo_DEPRECATED
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FInterpCurveVector result;
				if ((result = this._SplineScaleInfo_DEPRECATED) == null)
				{
					result = (this._SplineScaleInfo_DEPRECATED = new FInterpCurveVector(base.NativePtr + (IntPtr)USplineComponent.__PropertyOffset_SplineScaleInfo_DEPRECATED, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInterpCurveVector.StaticStruct(), base.NativePtr + (IntPtr)USplineComponent.__PropertyOffset_SplineScaleInfo_DEPRECATED, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003FF7 RID: 16375
		// (get) Token: 0x0601054D RID: 66893 RVA: 0x00180ECC File Offset: 0x0017F0CC
		// (set) Token: 0x0601054E RID: 66894 RVA: 0x00180F05 File Offset: 0x0017F105
		[Nullable(1)]
		public FInterpCurveFloat SplineReparamTable_DEPRECATED
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FInterpCurveFloat result;
				if ((result = this._SplineReparamTable_DEPRECATED) == null)
				{
					result = (this._SplineReparamTable_DEPRECATED = new FInterpCurveFloat(base.NativePtr + (IntPtr)USplineComponent.__PropertyOffset_SplineReparamTable_DEPRECATED, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInterpCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)USplineComponent.__PropertyOffset_SplineReparamTable_DEPRECATED, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003FF8 RID: 16376
		// (get) Token: 0x0601054F RID: 66895 RVA: 0x00180F26 File Offset: 0x0017F126
		// (set) Token: 0x06010550 RID: 66896 RVA: 0x00180F36 File Offset: 0x0017F136
		public unsafe bool bAllowSplineEditingPerInstance_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USplineComponent.__PropertyOffset_bAllowSplineEditingPerInstance_DEPRECATED) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USplineComponent.__PropertyOffset_bAllowSplineEditingPerInstance_DEPRECATED) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003FF9 RID: 16377
		// (get) Token: 0x06010551 RID: 66897 RVA: 0x00180F47 File Offset: 0x0017F147
		// (set) Token: 0x06010552 RID: 66898 RVA: 0x00180F57 File Offset: 0x0017F157
		public unsafe int ReparamStepsPerSegment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USplineComponent.__PropertyOffset_ReparamStepsPerSegment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USplineComponent.__PropertyOffset_ReparamStepsPerSegment) = value;
			}
		}

		// Token: 0x17003FFA RID: 16378
		// (get) Token: 0x06010553 RID: 66899 RVA: 0x00180F68 File Offset: 0x0017F168
		// (set) Token: 0x06010554 RID: 66900 RVA: 0x00180F78 File Offset: 0x0017F178
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USplineComponent.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USplineComponent.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x17003FFB RID: 16379
		// (get) Token: 0x06010555 RID: 66901 RVA: 0x00180F89 File Offset: 0x0017F189
		// (set) Token: 0x06010556 RID: 66902 RVA: 0x00180F99 File Offset: 0x0017F199
		public unsafe bool bStationaryEndpoints
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USplineComponent.__PropertyOffset_bStationaryEndpoints) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USplineComponent.__PropertyOffset_bStationaryEndpoints) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003FFC RID: 16380
		// (get) Token: 0x06010557 RID: 66903 RVA: 0x00180FAA File Offset: 0x0017F1AA
		// (set) Token: 0x06010558 RID: 66904 RVA: 0x00180FBA File Offset: 0x0017F1BA
		public unsafe bool bSplineHasBeenEdited
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USplineComponent.__PropertyOffset_bSplineHasBeenEdited) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USplineComponent.__PropertyOffset_bSplineHasBeenEdited) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003FFD RID: 16381
		// (get) Token: 0x06010559 RID: 66905 RVA: 0x00180FCB File Offset: 0x0017F1CB
		// (set) Token: 0x0601055A RID: 66906 RVA: 0x00180FDB File Offset: 0x0017F1DB
		public unsafe bool bModifiedByConstructionScript
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USplineComponent.__PropertyOffset_bModifiedByConstructionScript) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USplineComponent.__PropertyOffset_bModifiedByConstructionScript) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003FFE RID: 16382
		// (get) Token: 0x0601055B RID: 66907 RVA: 0x00180FEC File Offset: 0x0017F1EC
		// (set) Token: 0x0601055C RID: 66908 RVA: 0x00180FFC File Offset: 0x0017F1FC
		public unsafe bool bInputSplinePointsToConstructionScript
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USplineComponent.__PropertyOffset_bInputSplinePointsToConstructionScript) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USplineComponent.__PropertyOffset_bInputSplinePointsToConstructionScript) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003FFF RID: 16383
		// (get) Token: 0x0601055D RID: 66909 RVA: 0x0018100D File Offset: 0x0017F20D
		// (set) Token: 0x0601055E RID: 66910 RVA: 0x0018101D File Offset: 0x0017F21D
		public unsafe bool bDrawDebug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USplineComponent.__PropertyOffset_bDrawDebug) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USplineComponent.__PropertyOffset_bDrawDebug) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004000 RID: 16384
		// (get) Token: 0x0601055F RID: 66911 RVA: 0x0018102E File Offset: 0x0017F22E
		// (set) Token: 0x06010560 RID: 66912 RVA: 0x0018103E File Offset: 0x0017F23E
		public unsafe bool bClosedLoop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USplineComponent.__PropertyOffset_bClosedLoop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USplineComponent.__PropertyOffset_bClosedLoop) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004001 RID: 16385
		// (get) Token: 0x06010561 RID: 66913 RVA: 0x0018104F File Offset: 0x0017F24F
		// (set) Token: 0x06010562 RID: 66914 RVA: 0x0018105F File Offset: 0x0017F25F
		public unsafe bool bLoopPositionOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USplineComponent.__PropertyOffset_bLoopPositionOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USplineComponent.__PropertyOffset_bLoopPositionOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004002 RID: 16386
		// (get) Token: 0x06010563 RID: 66915 RVA: 0x00181070 File Offset: 0x0017F270
		// (set) Token: 0x06010564 RID: 66916 RVA: 0x00181080 File Offset: 0x0017F280
		public unsafe float LoopPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USplineComponent.__PropertyOffset_LoopPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USplineComponent.__PropertyOffset_LoopPosition) = value;
			}
		}

		// Token: 0x17004003 RID: 16387
		// (get) Token: 0x06010565 RID: 66917 RVA: 0x00181091 File Offset: 0x0017F291
		// (set) Token: 0x06010566 RID: 66918 RVA: 0x001810A5 File Offset: 0x0017F2A5
		public unsafe FVector DefaultUpVector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USplineComponent.__PropertyOffset_DefaultUpVector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USplineComponent.__PropertyOffset_DefaultUpVector) = value;
			}
		}

		// Token: 0x06010567 RID: 66919 RVA: 0x001810BA File Offset: 0x0017F2BA
		public void UpdateSpline()
		{
			USplineComponent.__UpdateSpline_Internal(base.NativePtr);
		}

		// Token: 0x06010568 RID: 66920 RVA: 0x001810C7 File Offset: 0x0017F2C7
		public void SetWorldLocationAtSplinePoint(int PointIndex, in FVector InLocation)
		{
			USplineComponent.__SetWorldLocationAtSplinePoint_Internal(base.NativePtr, PointIndex, InLocation);
		}

		// Token: 0x06010569 RID: 66921 RVA: 0x001810D6 File Offset: 0x0017F2D6
		public void SetUpVectorAtSplinePoint(int PointIndex, in FVector InUpVector, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
		{
			USplineComponent.__SetUpVectorAtSplinePoint_Internal(base.NativePtr, PointIndex, InUpVector, CoordinateSpace, bUpdateSpline);
		}

		// Token: 0x0601056A RID: 66922 RVA: 0x001810ED File Offset: 0x0017F2ED
		public void SetUnselectedSplineSegmentColor(in FLinearColor SegmentColor)
		{
			USplineComponent.__SetUnselectedSplineSegmentColor_Internal(base.NativePtr, SegmentColor);
		}

		// Token: 0x0601056B RID: 66923 RVA: 0x001810FB File Offset: 0x0017F2FB
		public void SetTangentsAtSplinePoint(int PointIndex, in FVector InArriveTangent, in FVector InLeaveTangent, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
		{
			USplineComponent.__SetTangentsAtSplinePoint_Internal(base.NativePtr, PointIndex, InArriveTangent, InLeaveTangent, CoordinateSpace, bUpdateSpline);
		}

		// Token: 0x0601056C RID: 66924 RVA: 0x00181114 File Offset: 0x0017F314
		public void SetTangentColor(in FLinearColor TangentColor)
		{
			USplineComponent.__SetTangentColor_Internal(base.NativePtr, TangentColor);
		}

		// Token: 0x0601056D RID: 66925 RVA: 0x00181122 File Offset: 0x0017F322
		public void SetTangentAtSplinePoint(int PointIndex, in FVector InTangent, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
		{
			USplineComponent.__SetTangentAtSplinePoint_Internal(base.NativePtr, PointIndex, InTangent, CoordinateSpace, bUpdateSpline);
		}

		// Token: 0x0601056E RID: 66926 RVA: 0x00181139 File Offset: 0x0017F339
		[NullableContext(2)]
		public void SetSplineWorldPoints(in TArray<FVector> Points)
		{
			USplineComponent.__SetSplineWorldPoints_Internal(base.NativePtr, (Points ?? new TArray<FVector>()).NativePtr);
		}

		// Token: 0x0601056F RID: 66927 RVA: 0x00181156 File Offset: 0x0017F356
		public void SetSplinePointType(int PointIndex, ESplinePointType Type, bool bUpdateSpline = true)
		{
			USplineComponent.__SetSplinePointType_Internal(base.NativePtr, PointIndex, Type, bUpdateSpline);
		}

		// Token: 0x06010570 RID: 66928 RVA: 0x0018116B File Offset: 0x0017F36B
		[NullableContext(2)]
		public void SetSplinePoints(in TArray<FVector> Points, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
		{
			USplineComponent.__SetSplinePoints_Internal(base.NativePtr, (Points ?? new TArray<FVector>()).NativePtr, CoordinateSpace, bUpdateSpline);
		}

		// Token: 0x06010571 RID: 66929 RVA: 0x0018118F File Offset: 0x0017F38F
		[NullableContext(2)]
		public void SetSplineLocalPoints(in TArray<FVector> Points)
		{
			USplineComponent.__SetSplineLocalPoints_Internal(base.NativePtr, (Points ?? new TArray<FVector>()).NativePtr);
		}

		// Token: 0x06010572 RID: 66930 RVA: 0x001811AC File Offset: 0x0017F3AC
		public void SetSelectedSplineSegmentColor(in FLinearColor SegmentColor)
		{
			USplineComponent.__SetSelectedSplineSegmentColor_Internal(base.NativePtr, SegmentColor);
		}

		// Token: 0x06010573 RID: 66931 RVA: 0x001811BA File Offset: 0x0017F3BA
		public void SetScaleAtSplinePoint(int PointIndex, in FVector InScaleVector, bool bUpdateSpline = true)
		{
			USplineComponent.__SetScaleAtSplinePoint_Internal(base.NativePtr, PointIndex, InScaleVector, bUpdateSpline);
		}

		// Token: 0x06010574 RID: 66932 RVA: 0x001811CA File Offset: 0x0017F3CA
		public void SetRotationAtSplinePoint(int PointIndex, in FRotator InRotation, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
		{
			USplineComponent.__SetRotationAtSplinePoint_Internal(base.NativePtr, PointIndex, InRotation, CoordinateSpace, bUpdateSpline);
		}

		// Token: 0x06010575 RID: 66933 RVA: 0x001811E1 File Offset: 0x0017F3E1
		public void SetLocationAtSplinePoint(int PointIndex, in FVector InLocation, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
		{
			USplineComponent.__SetLocationAtSplinePoint_Internal(base.NativePtr, PointIndex, InLocation, CoordinateSpace, bUpdateSpline);
		}

		// Token: 0x06010576 RID: 66934 RVA: 0x001811F8 File Offset: 0x0017F3F8
		public void SetDrawDebug(bool bShow)
		{
			USplineComponent.__SetDrawDebug_Internal(base.NativePtr, bShow);
		}

		// Token: 0x06010577 RID: 66935 RVA: 0x00181206 File Offset: 0x0017F406
		public void SetDefaultUpVector(in FVector UpVector, ESplineCoordinateSpace CoordinateSpace)
		{
			USplineComponent.__SetDefaultUpVector_Internal(base.NativePtr, UpVector, CoordinateSpace);
		}

		// Token: 0x06010578 RID: 66936 RVA: 0x0018121A File Offset: 0x0017F41A
		public void SetClosedLoopAtPosition(bool bInClosedLoop, float Key, bool bUpdateSpline = true)
		{
			USplineComponent.__SetClosedLoopAtPosition_Internal(base.NativePtr, bInClosedLoop, Key, bUpdateSpline);
		}

		// Token: 0x06010579 RID: 66937 RVA: 0x0018122A File Offset: 0x0017F42A
		public void SetClosedLoop(bool bInClosedLoop, bool bUpdateSpline = true)
		{
			USplineComponent.__SetClosedLoop_Internal(base.NativePtr, bInClosedLoop, bUpdateSpline);
		}

		// Token: 0x0601057A RID: 66938 RVA: 0x00181239 File Offset: 0x0017F439
		public void RemoveSplinePoint(int Index, bool bUpdateSpline = true)
		{
			USplineComponent.__RemoveSplinePoint_Internal(base.NativePtr, Index, bUpdateSpline);
		}

		// Token: 0x0601057B RID: 66939 RVA: 0x00181248 File Offset: 0x0017F448
		public bool IsClosedLoop()
		{
			return USplineComponent.__IsClosedLoop_Internal(base.NativePtr);
		}

		// Token: 0x0601057C RID: 66940 RVA: 0x00181255 File Offset: 0x0017F455
		public FVector GetWorldTangentAtDistanceAlongSpline(float Distance)
		{
			return USplineComponent.__GetWorldTangentAtDistanceAlongSpline_Internal(base.NativePtr, Distance);
		}

		// Token: 0x0601057D RID: 66941 RVA: 0x00181263 File Offset: 0x0017F463
		public FRotator GetWorldRotationAtTime(float Time, bool bUseConstantVelocity = false)
		{
			return USplineComponent.__GetWorldRotationAtTime_Internal(base.NativePtr, Time, bUseConstantVelocity);
		}

		// Token: 0x0601057E RID: 66942 RVA: 0x00181272 File Offset: 0x0017F472
		public FRotator GetWorldRotationAtDistanceAlongSpline(float Distance)
		{
			return USplineComponent.__GetWorldRotationAtDistanceAlongSpline_Internal(base.NativePtr, Distance);
		}

		// Token: 0x0601057F RID: 66943 RVA: 0x00181280 File Offset: 0x0017F480
		public FVector GetWorldLocationAtTime(float Time, bool bUseConstantVelocity = false)
		{
			return USplineComponent.__GetWorldLocationAtTime_Internal(base.NativePtr, Time, bUseConstantVelocity);
		}

		// Token: 0x06010580 RID: 66944 RVA: 0x0018128F File Offset: 0x0017F48F
		public FVector GetWorldLocationAtSplinePoint(int PointIndex)
		{
			return USplineComponent.__GetWorldLocationAtSplinePoint_Internal(base.NativePtr, PointIndex);
		}

		// Token: 0x06010581 RID: 66945 RVA: 0x0018129D File Offset: 0x0017F49D
		public FVector GetWorldLocationAtDistanceAlongSpline(float Distance)
		{
			return USplineComponent.__GetWorldLocationAtDistanceAlongSpline_Internal(base.NativePtr, Distance);
		}

		// Token: 0x06010582 RID: 66946 RVA: 0x001812AB File Offset: 0x0017F4AB
		public FVector GetWorldDirectionAtTime(float Time, bool bUseConstantVelocity = false)
		{
			return USplineComponent.__GetWorldDirectionAtTime_Internal(base.NativePtr, Time, bUseConstantVelocity);
		}

		// Token: 0x06010583 RID: 66947 RVA: 0x001812BA File Offset: 0x0017F4BA
		public FVector GetWorldDirectionAtDistanceAlongSpline(float Distance)
		{
			return USplineComponent.__GetWorldDirectionAtDistanceAlongSpline_Internal(base.NativePtr, Distance);
		}

		// Token: 0x06010584 RID: 66948 RVA: 0x001812C8 File Offset: 0x0017F4C8
		public FVector GetVectorPropertyAtSplinePoint(int Index, FName PropertyName)
		{
			return USplineComponent.__GetVectorPropertyAtSplinePoint_Internal(base.NativePtr, Index, PropertyName);
		}

		// Token: 0x06010585 RID: 66949 RVA: 0x001812D7 File Offset: 0x0017F4D7
		public FVector GetVectorPropertyAtSplineInputKey(float InKey, FName PropertyName)
		{
			return USplineComponent.__GetVectorPropertyAtSplineInputKey_Internal(base.NativePtr, InKey, PropertyName);
		}

		// Token: 0x06010586 RID: 66950 RVA: 0x001812E6 File Offset: 0x0017F4E6
		public FVector GetUpVectorAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false)
		{
			return USplineComponent.__GetUpVectorAtTime_Internal(base.NativePtr, Time, CoordinateSpace, bUseConstantVelocity);
		}

		// Token: 0x06010587 RID: 66951 RVA: 0x001812FB File Offset: 0x0017F4FB
		public FVector GetUpVectorAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetUpVectorAtSplinePoint_Internal(base.NativePtr, PointIndex, CoordinateSpace);
		}

		// Token: 0x06010588 RID: 66952 RVA: 0x0018130F File Offset: 0x0017F50F
		public FVector GetUpVectorAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetUpVectorAtSplineInputKey_Internal(base.NativePtr, InKey, CoordinateSpace);
		}

		// Token: 0x06010589 RID: 66953 RVA: 0x00181323 File Offset: 0x0017F523
		public FVector GetUpVectorAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetUpVectorAtDistanceAlongSpline_Internal(base.NativePtr, Distance, CoordinateSpace);
		}

		// Token: 0x0601058A RID: 66954 RVA: 0x00181337 File Offset: 0x0017F537
		public FTransform GetTransformAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false, bool bUseScale = false)
		{
			return USplineComponent.__GetTransformAtTime_Internal(base.NativePtr, Time, CoordinateSpace, bUseConstantVelocity, bUseScale);
		}

		// Token: 0x0601058B RID: 66955 RVA: 0x0018134E File Offset: 0x0017F54E
		public FTransform GetTransformAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace, bool bUseScale = false)
		{
			return USplineComponent.__GetTransformAtSplinePoint_Internal(base.NativePtr, PointIndex, CoordinateSpace, bUseScale);
		}

		// Token: 0x0601058C RID: 66956 RVA: 0x00181363 File Offset: 0x0017F563
		public FTransform GetTransformAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace, bool bUseScale = false)
		{
			return USplineComponent.__GetTransformAtSplineInputKey_Internal(base.NativePtr, InKey, CoordinateSpace, bUseScale);
		}

		// Token: 0x0601058D RID: 66957 RVA: 0x00181378 File Offset: 0x0017F578
		public FTransform GetTransformAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace, bool bUseScale = false)
		{
			return USplineComponent.__GetTransformAtDistanceAlongSpline_Internal(base.NativePtr, Distance, CoordinateSpace, bUseScale);
		}

		// Token: 0x0601058E RID: 66958 RVA: 0x0018138D File Offset: 0x0017F58D
		public FVector GetTangentAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false)
		{
			return USplineComponent.__GetTangentAtTime_Internal(base.NativePtr, Time, CoordinateSpace, bUseConstantVelocity);
		}

		// Token: 0x0601058F RID: 66959 RVA: 0x001813A2 File Offset: 0x0017F5A2
		public FVector GetTangentAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetTangentAtSplinePoint_Internal(base.NativePtr, PointIndex, CoordinateSpace);
		}

		// Token: 0x06010590 RID: 66960 RVA: 0x001813B6 File Offset: 0x0017F5B6
		public FVector GetTangentAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetTangentAtSplineInputKey_Internal(base.NativePtr, InKey, CoordinateSpace);
		}

		// Token: 0x06010591 RID: 66961 RVA: 0x001813CA File Offset: 0x0017F5CA
		public FVector GetTangentAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetTangentAtDistanceAlongSpline_Internal(base.NativePtr, Distance, CoordinateSpace);
		}

		// Token: 0x06010592 RID: 66962 RVA: 0x001813DE File Offset: 0x0017F5DE
		public TEnumAsByte<ESplinePointType> GetSplinePointType(int PointIndex)
		{
			return USplineComponent.__GetSplinePointType_Internal(base.NativePtr, PointIndex);
		}

		// Token: 0x06010593 RID: 66963 RVA: 0x001813EC File Offset: 0x0017F5EC
		public float GetSplineLength()
		{
			return USplineComponent.__GetSplineLength_Internal(base.NativePtr);
		}

		// Token: 0x06010594 RID: 66964 RVA: 0x001813F9 File Offset: 0x0017F5F9
		public FVector GetScaleAtTime(float Time, bool bUseConstantVelocity = false)
		{
			return USplineComponent.__GetScaleAtTime_Internal(base.NativePtr, Time, bUseConstantVelocity);
		}

		// Token: 0x06010595 RID: 66965 RVA: 0x00181408 File Offset: 0x0017F608
		public FVector GetScaleAtSplinePoint(int PointIndex)
		{
			return USplineComponent.__GetScaleAtSplinePoint_Internal(base.NativePtr, PointIndex);
		}

		// Token: 0x06010596 RID: 66966 RVA: 0x00181416 File Offset: 0x0017F616
		public FVector GetScaleAtSplineInputKey(float InKey)
		{
			return USplineComponent.__GetScaleAtSplineInputKey_Internal(base.NativePtr, InKey);
		}

		// Token: 0x06010597 RID: 66967 RVA: 0x00181424 File Offset: 0x0017F624
		public FVector GetScaleAtDistanceAlongSpline(float Distance)
		{
			return USplineComponent.__GetScaleAtDistanceAlongSpline_Internal(base.NativePtr, Distance);
		}

		// Token: 0x06010598 RID: 66968 RVA: 0x00181432 File Offset: 0x0017F632
		public FRotator GetRotationAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false)
		{
			return USplineComponent.__GetRotationAtTime_Internal(base.NativePtr, Time, CoordinateSpace, bUseConstantVelocity);
		}

		// Token: 0x06010599 RID: 66969 RVA: 0x00181447 File Offset: 0x0017F647
		public FRotator GetRotationAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetRotationAtSplinePoint_Internal(base.NativePtr, PointIndex, CoordinateSpace);
		}

		// Token: 0x0601059A RID: 66970 RVA: 0x0018145B File Offset: 0x0017F65B
		public FRotator GetRotationAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetRotationAtSplineInputKey_Internal(base.NativePtr, InKey, CoordinateSpace);
		}

		// Token: 0x0601059B RID: 66971 RVA: 0x0018146F File Offset: 0x0017F66F
		public FRotator GetRotationAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetRotationAtDistanceAlongSpline_Internal(base.NativePtr, Distance, CoordinateSpace);
		}

		// Token: 0x0601059C RID: 66972 RVA: 0x00181483 File Offset: 0x0017F683
		public float GetRollAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false)
		{
			return USplineComponent.__GetRollAtTime_Internal(base.NativePtr, Time, CoordinateSpace, bUseConstantVelocity);
		}

		// Token: 0x0601059D RID: 66973 RVA: 0x00181498 File Offset: 0x0017F698
		public float GetRollAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetRollAtSplinePoint_Internal(base.NativePtr, PointIndex, CoordinateSpace);
		}

		// Token: 0x0601059E RID: 66974 RVA: 0x001814AC File Offset: 0x0017F6AC
		public float GetRollAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetRollAtSplineInputKey_Internal(base.NativePtr, InKey, CoordinateSpace);
		}

		// Token: 0x0601059F RID: 66975 RVA: 0x001814C0 File Offset: 0x0017F6C0
		public float GetRollAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetRollAtDistanceAlongSpline_Internal(base.NativePtr, Distance, CoordinateSpace);
		}

		// Token: 0x060105A0 RID: 66976 RVA: 0x001814D4 File Offset: 0x0017F6D4
		public FVector GetRightVectorAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false)
		{
			return USplineComponent.__GetRightVectorAtTime_Internal(base.NativePtr, Time, CoordinateSpace, bUseConstantVelocity);
		}

		// Token: 0x060105A1 RID: 66977 RVA: 0x001814E9 File Offset: 0x0017F6E9
		public FVector GetRightVectorAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetRightVectorAtSplinePoint_Internal(base.NativePtr, PointIndex, CoordinateSpace);
		}

		// Token: 0x060105A2 RID: 66978 RVA: 0x001814FD File Offset: 0x0017F6FD
		public FVector GetRightVectorAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetRightVectorAtSplineInputKey_Internal(base.NativePtr, InKey, CoordinateSpace);
		}

		// Token: 0x060105A3 RID: 66979 RVA: 0x00181511 File Offset: 0x0017F711
		public FVector GetRightVectorAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetRightVectorAtDistanceAlongSpline_Internal(base.NativePtr, Distance, CoordinateSpace);
		}

		// Token: 0x060105A4 RID: 66980 RVA: 0x00181525 File Offset: 0x0017F725
		[NullableContext(1)]
		public TArray<FSplinePoint> GetPoints()
		{
			return new TArray<FSplinePoint>(USplineComponent.__GetPoints_Internal(base.NativePtr), null);
		}

		// Token: 0x060105A5 RID: 66981 RVA: 0x00181538 File Offset: 0x0017F738
		public int GetNumberOfSplineSegments()
		{
			return USplineComponent.__GetNumberOfSplineSegments_Internal(base.NativePtr);
		}

		// Token: 0x060105A6 RID: 66982 RVA: 0x00181545 File Offset: 0x0017F745
		public int GetNumberOfSplinePoints()
		{
			return USplineComponent.__GetNumberOfSplinePoints_Internal(base.NativePtr);
		}

		// Token: 0x060105A7 RID: 66983 RVA: 0x00181552 File Offset: 0x0017F752
		public FVector GetLocationAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false)
		{
			return USplineComponent.__GetLocationAtTime_Internal(base.NativePtr, Time, CoordinateSpace, bUseConstantVelocity);
		}

		// Token: 0x060105A8 RID: 66984 RVA: 0x00181567 File Offset: 0x0017F767
		public FVector GetLocationAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetLocationAtSplinePoint_Internal(base.NativePtr, PointIndex, CoordinateSpace);
		}

		// Token: 0x060105A9 RID: 66985 RVA: 0x0018157B File Offset: 0x0017F77B
		public FVector GetLocationAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetLocationAtSplineInputKey_Internal(base.NativePtr, InKey, CoordinateSpace);
		}

		// Token: 0x060105AA RID: 66986 RVA: 0x0018158F File Offset: 0x0017F78F
		public FVector GetLocationAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetLocationAtDistanceAlongSpline_Internal(base.NativePtr, Distance, CoordinateSpace);
		}

		// Token: 0x060105AB RID: 66987 RVA: 0x001815A4 File Offset: 0x0017F7A4
		public unsafe void GetLocationAndTangentAtSplinePoint(int PointIndex, ref FVector Location, ref FVector Tangent, ESplineCoordinateSpace CoordinateSpace)
		{
			fixed (FVector* ptr = &Location)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &Tangent)
				{
					void* ptr4 = (void*)ptr3;
					USplineComponent.__GetLocationAndTangentAtSplinePoint_Internal(base.NativePtr, PointIndex, ref Location, ref Tangent, CoordinateSpace);
					ptr = null;
				}
			}
		}

		// Token: 0x060105AC RID: 66988 RVA: 0x001815D8 File Offset: 0x0017F7D8
		public unsafe FVector GetLocationAndKeyAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace, ref float Key)
		{
			fixed (float* ptr = &Key)
			{
				void* ptr2 = (void*)ptr;
				return USplineComponent.__GetLocationAndKeyAtDistanceAlongSpline_Internal(base.NativePtr, Distance, CoordinateSpace, ref Key);
			}
		}

		// Token: 0x060105AD RID: 66989 RVA: 0x00181600 File Offset: 0x0017F800
		public unsafe void GetLocalLocationAndTangentAtSplinePoint(int PointIndex, ref FVector LocalLocation, ref FVector LocalTangent)
		{
			fixed (FVector* ptr = &LocalLocation)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &LocalTangent)
				{
					void* ptr4 = (void*)ptr3;
					USplineComponent.__GetLocalLocationAndTangentAtSplinePoint_Internal(base.NativePtr, PointIndex, ref LocalLocation, ref LocalTangent);
					ptr = null;
				}
			}
		}

		// Token: 0x060105AE RID: 66990 RVA: 0x0018162B File Offset: 0x0017F82B
		public FVector GetLeaveTangentAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetLeaveTangentAtSplinePoint_Internal(base.NativePtr, PointIndex, CoordinateSpace);
		}

		// Token: 0x060105AF RID: 66991 RVA: 0x0018163F File Offset: 0x0017F83F
		public float GetInputKeyAtDistanceAlongSpline(float Distance)
		{
			return USplineComponent.__GetInputKeyAtDistanceAlongSpline_Internal(base.NativePtr, Distance);
		}

		// Token: 0x060105B0 RID: 66992 RVA: 0x0018164D File Offset: 0x0017F84D
		public float GetFloatPropertyAtSplinePoint(int Index, FName PropertyName)
		{
			return USplineComponent.__GetFloatPropertyAtSplinePoint_Internal(base.NativePtr, Index, PropertyName);
		}

		// Token: 0x060105B1 RID: 66993 RVA: 0x0018165C File Offset: 0x0017F85C
		public float GetFloatPropertyAtSplineInputKey(float InKey, FName PropertyName)
		{
			return USplineComponent.__GetFloatPropertyAtSplineInputKey_Internal(base.NativePtr, InKey, PropertyName);
		}

		// Token: 0x060105B2 RID: 66994 RVA: 0x0018166B File Offset: 0x0017F86B
		public float GetDistanceAlongSplineAtSplinePoint(int PointIndex)
		{
			return USplineComponent.__GetDistanceAlongSplineAtSplinePoint_Internal(base.NativePtr, PointIndex);
		}

		// Token: 0x060105B3 RID: 66995 RVA: 0x00181679 File Offset: 0x0017F879
		public float GetDistanceAlongSplineAtSplineInputKey(float InKey)
		{
			return USplineComponent.__GetDistanceAlongSplineAtSplineInputKey_Internal(base.NativePtr, InKey);
		}

		// Token: 0x060105B4 RID: 66996 RVA: 0x00181687 File Offset: 0x0017F887
		public FVector GetDirectionAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false)
		{
			return USplineComponent.__GetDirectionAtTime_Internal(base.NativePtr, Time, CoordinateSpace, bUseConstantVelocity);
		}

		// Token: 0x060105B5 RID: 66997 RVA: 0x0018169C File Offset: 0x0017F89C
		public FVector GetDirectionAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetDirectionAtSplinePoint_Internal(base.NativePtr, PointIndex, CoordinateSpace);
		}

		// Token: 0x060105B6 RID: 66998 RVA: 0x001816B0 File Offset: 0x0017F8B0
		public FVector GetDirectionAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetDirectionAtSplineInputKey_Internal(base.NativePtr, InKey, CoordinateSpace);
		}

		// Token: 0x060105B7 RID: 66999 RVA: 0x001816C4 File Offset: 0x0017F8C4
		public FVector GetDirectionAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetDirectionAtDistanceAlongSpline_Internal(base.NativePtr, Distance, CoordinateSpace);
		}

		// Token: 0x060105B8 RID: 67000 RVA: 0x001816D8 File Offset: 0x0017F8D8
		public FVector GetDefaultUpVector(ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetDefaultUpVector_Internal(base.NativePtr, CoordinateSpace);
		}

		// Token: 0x060105B9 RID: 67001 RVA: 0x001816EB File Offset: 0x0017F8EB
		public FVector GetArriveTangentAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetArriveTangentAtSplinePoint_Internal(base.NativePtr, PointIndex, CoordinateSpace);
		}

		// Token: 0x060105BA RID: 67002 RVA: 0x001816FF File Offset: 0x0017F8FF
		public FVector FindUpVectorClosestToWorldLocation(in FVector WorldLocation, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__FindUpVectorClosestToWorldLocation_Internal(base.NativePtr, WorldLocation, CoordinateSpace);
		}

		// Token: 0x060105BB RID: 67003 RVA: 0x00181713 File Offset: 0x0017F913
		public FTransform FindTransformClosestToWorldLocation(in FVector WorldLocation, ESplineCoordinateSpace CoordinateSpace, bool bUseScale = false)
		{
			return USplineComponent.__FindTransformClosestToWorldLocation_Internal(base.NativePtr, WorldLocation, CoordinateSpace, bUseScale);
		}

		// Token: 0x060105BC RID: 67004 RVA: 0x00181728 File Offset: 0x0017F928
		public FVector FindTangentClosestToWorldLocation(in FVector WorldLocation, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__FindTangentClosestToWorldLocation_Internal(base.NativePtr, WorldLocation, CoordinateSpace);
		}

		// Token: 0x060105BD RID: 67005 RVA: 0x0018173C File Offset: 0x0017F93C
		public FVector FindScaleClosestToWorldLocation(in FVector WorldLocation)
		{
			return USplineComponent.__FindScaleClosestToWorldLocation_Internal(base.NativePtr, WorldLocation);
		}

		// Token: 0x060105BE RID: 67006 RVA: 0x0018174A File Offset: 0x0017F94A
		public FRotator FindRotationClosestToWorldLocation(in FVector WorldLocation, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__FindRotationClosestToWorldLocation_Internal(base.NativePtr, WorldLocation, CoordinateSpace);
		}

		// Token: 0x060105BF RID: 67007 RVA: 0x0018175E File Offset: 0x0017F95E
		public float FindRollClosestToWorldLocation(in FVector WorldLocation, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__FindRollClosestToWorldLocation_Internal(base.NativePtr, WorldLocation, CoordinateSpace);
		}

		// Token: 0x060105C0 RID: 67008 RVA: 0x00181772 File Offset: 0x0017F972
		public FVector FindRightVectorClosestToWorldLocation(in FVector WorldLocation, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__FindRightVectorClosestToWorldLocation_Internal(base.NativePtr, WorldLocation, CoordinateSpace);
		}

		// Token: 0x060105C1 RID: 67009 RVA: 0x00181786 File Offset: 0x0017F986
		public FVector FindLocationClosestToWorldLocation(in FVector WorldLocation, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__FindLocationClosestToWorldLocation_Internal(base.NativePtr, WorldLocation, CoordinateSpace);
		}

		// Token: 0x060105C2 RID: 67010 RVA: 0x0018179A File Offset: 0x0017F99A
		public float FindInputKeyClosestToWorldLocationInRange(in FVector WorldLocation, int StartKey, int EndKey)
		{
			return USplineComponent.__FindInputKeyClosestToWorldLocationInRange_Internal(base.NativePtr, WorldLocation, StartKey, EndKey);
		}

		// Token: 0x060105C3 RID: 67011 RVA: 0x001817AA File Offset: 0x0017F9AA
		public float FindInputKeyClosestToWorldLocationByPartitionInGravity(in FVector WorldLocation, FVector GravityDirect, float SearchRadius, float HeightLimit)
		{
			return USplineComponent.__FindInputKeyClosestToWorldLocationByPartitionInGravity_Internal(base.NativePtr, WorldLocation, GravityDirect, SearchRadius, HeightLimit);
		}

		// Token: 0x060105C4 RID: 67012 RVA: 0x001817BC File Offset: 0x0017F9BC
		public float FindInputKeyClosestToWorldLocationByPartition(in FVector WorldLocation, float SearchRadius)
		{
			return USplineComponent.__FindInputKeyClosestToWorldLocationByPartition_Internal(base.NativePtr, WorldLocation, SearchRadius);
		}

		// Token: 0x060105C5 RID: 67013 RVA: 0x001817CB File Offset: 0x0017F9CB
		public float FindInputKeyClosestToWorldLocation(in FVector WorldLocation)
		{
			return USplineComponent.__FindInputKeyClosestToWorldLocation_Internal(base.NativePtr, WorldLocation);
		}

		// Token: 0x060105C6 RID: 67014 RVA: 0x001817D9 File Offset: 0x0017F9D9
		public FVector FindDirectionClosestToWorldLocation(in FVector WorldLocation, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__FindDirectionClosestToWorldLocation_Internal(base.NativePtr, WorldLocation, CoordinateSpace);
		}

		// Token: 0x060105C7 RID: 67015 RVA: 0x001817ED File Offset: 0x0017F9ED
		public void D_SetUpVectorAtSplinePoint(int PointIndex, in FVectorDouble InUpVector, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
		{
			USplineComponent.__D_SetUpVectorAtSplinePoint_Internal(base.NativePtr, PointIndex, InUpVector, CoordinateSpace, bUpdateSpline);
		}

		// Token: 0x060105C8 RID: 67016 RVA: 0x00181804 File Offset: 0x0017FA04
		public void D_SetTangentsAtSplinePoint(int PointIndex, in FVectorDouble InArriveTangent, in FVectorDouble InLeaveTangent, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
		{
			USplineComponent.__D_SetTangentsAtSplinePoint_Internal(base.NativePtr, PointIndex, InArriveTangent, InLeaveTangent, CoordinateSpace, bUpdateSpline);
		}

		// Token: 0x060105C9 RID: 67017 RVA: 0x0018181D File Offset: 0x0017FA1D
		public void D_SetTangentAtSplinePoint(int PointIndex, in FVectorDouble InTangent, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
		{
			USplineComponent.__D_SetTangentAtSplinePoint_Internal(base.NativePtr, PointIndex, InTangent, CoordinateSpace, bUpdateSpline);
		}

		// Token: 0x060105CA RID: 67018 RVA: 0x00181834 File Offset: 0x0017FA34
		[NullableContext(2)]
		public void D_SetSplinePoints(in TArray<FVectorDouble> Points, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
		{
			USplineComponent.__D_SetSplinePoints_Internal(base.NativePtr, (Points ?? new TArray<FVectorDouble>()).NativePtr, CoordinateSpace, bUpdateSpline);
		}

		// Token: 0x060105CB RID: 67019 RVA: 0x00181858 File Offset: 0x0017FA58
		public void D_SetLocationAtSplinePoint(int PointIndex, in FVectorDouble InLocation, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
		{
			USplineComponent.__D_SetLocationAtSplinePoint_Internal(base.NativePtr, PointIndex, InLocation, CoordinateSpace, bUpdateSpline);
		}

		// Token: 0x060105CC RID: 67020 RVA: 0x0018186F File Offset: 0x0017FA6F
		public void D_SetDefaultUpVector(in FVectorDouble UpVector, ESplineCoordinateSpace CoordinateSpace)
		{
			USplineComponent.__D_SetDefaultUpVector_Internal(base.NativePtr, UpVector, CoordinateSpace);
		}

		// Token: 0x060105CD RID: 67021 RVA: 0x00181883 File Offset: 0x0017FA83
		public FVectorDouble D_GetVectorPropertyAtSplinePoint(int Index, FName PropertyName)
		{
			return USplineComponent.__D_GetVectorPropertyAtSplinePoint_Internal(base.NativePtr, Index, PropertyName);
		}

		// Token: 0x060105CE RID: 67022 RVA: 0x00181892 File Offset: 0x0017FA92
		public FVectorDouble D_GetVectorPropertyAtSplineInputKey(float InKey, FName PropertyName)
		{
			return USplineComponent.__D_GetVectorPropertyAtSplineInputKey_Internal(base.NativePtr, InKey, PropertyName);
		}

		// Token: 0x060105CF RID: 67023 RVA: 0x001818A1 File Offset: 0x0017FAA1
		public FVectorDouble D_GetUpVectorAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false)
		{
			return USplineComponent.__D_GetUpVectorAtTime_Internal(base.NativePtr, Time, CoordinateSpace, bUseConstantVelocity);
		}

		// Token: 0x060105D0 RID: 67024 RVA: 0x001818B6 File Offset: 0x0017FAB6
		public FVectorDouble D_GetUpVectorAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_GetUpVectorAtSplinePoint_Internal(base.NativePtr, PointIndex, CoordinateSpace);
		}

		// Token: 0x060105D1 RID: 67025 RVA: 0x001818CA File Offset: 0x0017FACA
		public FVectorDouble D_GetUpVectorAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_GetUpVectorAtSplineInputKey_Internal(base.NativePtr, InKey, CoordinateSpace);
		}

		// Token: 0x060105D2 RID: 67026 RVA: 0x001818DE File Offset: 0x0017FADE
		public FVectorDouble D_GetUpVectorAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_GetUpVectorAtDistanceAlongSpline_Internal(base.NativePtr, Distance, CoordinateSpace);
		}

		// Token: 0x060105D3 RID: 67027 RVA: 0x001818F2 File Offset: 0x0017FAF2
		public FTransformDouble D_GetTransformAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false, bool bUseScale = false)
		{
			return USplineComponent.__D_GetTransformAtTime_Internal(base.NativePtr, Time, CoordinateSpace, bUseConstantVelocity, bUseScale);
		}

		// Token: 0x060105D4 RID: 67028 RVA: 0x00181909 File Offset: 0x0017FB09
		public FTransformDouble D_GetTransformAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace, bool bUseScale = false)
		{
			return USplineComponent.__D_GetTransformAtSplinePoint_Internal(base.NativePtr, PointIndex, CoordinateSpace, bUseScale);
		}

		// Token: 0x060105D5 RID: 67029 RVA: 0x0018191E File Offset: 0x0017FB1E
		public FTransformDouble D_GetTransformAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace, bool bUseScale = false)
		{
			return USplineComponent.__D_GetTransformAtSplineInputKey_Internal(base.NativePtr, InKey, CoordinateSpace, bUseScale);
		}

		// Token: 0x060105D6 RID: 67030 RVA: 0x00181933 File Offset: 0x0017FB33
		public FTransformDouble D_GetTransformAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace, bool bUseScale = false)
		{
			return USplineComponent.__D_GetTransformAtDistanceAlongSpline_Internal(base.NativePtr, Distance, CoordinateSpace, bUseScale);
		}

		// Token: 0x060105D7 RID: 67031 RVA: 0x00181948 File Offset: 0x0017FB48
		public FVectorDouble D_GetTangentAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false)
		{
			return USplineComponent.__D_GetTangentAtTime_Internal(base.NativePtr, Time, CoordinateSpace, bUseConstantVelocity);
		}

		// Token: 0x060105D8 RID: 67032 RVA: 0x0018195D File Offset: 0x0017FB5D
		public FVectorDouble D_GetTangentAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_GetTangentAtSplinePoint_Internal(base.NativePtr, PointIndex, CoordinateSpace);
		}

		// Token: 0x060105D9 RID: 67033 RVA: 0x00181971 File Offset: 0x0017FB71
		public FVectorDouble D_GetTangentAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_GetTangentAtSplineInputKey_Internal(base.NativePtr, InKey, CoordinateSpace);
		}

		// Token: 0x060105DA RID: 67034 RVA: 0x00181985 File Offset: 0x0017FB85
		public FVectorDouble D_GetTangentAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_GetTangentAtDistanceAlongSpline_Internal(base.NativePtr, Distance, CoordinateSpace);
		}

		// Token: 0x060105DB RID: 67035 RVA: 0x00181999 File Offset: 0x0017FB99
		public FVectorDouble D_GetScaleAtDistanceAlongSpline(float Distance)
		{
			return USplineComponent.__D_GetScaleAtDistanceAlongSpline_Internal(base.NativePtr, Distance);
		}

		// Token: 0x060105DC RID: 67036 RVA: 0x001819A7 File Offset: 0x0017FBA7
		public FVectorDouble D_GetRightVectorAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false)
		{
			return USplineComponent.__D_GetRightVectorAtTime_Internal(base.NativePtr, Time, CoordinateSpace, bUseConstantVelocity);
		}

		// Token: 0x060105DD RID: 67037 RVA: 0x001819BC File Offset: 0x0017FBBC
		public FVectorDouble D_GetRightVectorAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_GetRightVectorAtSplinePoint_Internal(base.NativePtr, PointIndex, CoordinateSpace);
		}

		// Token: 0x060105DE RID: 67038 RVA: 0x001819D0 File Offset: 0x0017FBD0
		public FVectorDouble D_GetRightVectorAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_GetRightVectorAtSplineInputKey_Internal(base.NativePtr, InKey, CoordinateSpace);
		}

		// Token: 0x060105DF RID: 67039 RVA: 0x001819E4 File Offset: 0x0017FBE4
		public FVectorDouble D_GetRightVectorAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_GetRightVectorAtDistanceAlongSpline_Internal(base.NativePtr, Distance, CoordinateSpace);
		}

		// Token: 0x060105E0 RID: 67040 RVA: 0x001819F8 File Offset: 0x0017FBF8
		public FVectorDouble D_GetLocationAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false)
		{
			return USplineComponent.__D_GetLocationAtTime_Internal(base.NativePtr, Time, CoordinateSpace, bUseConstantVelocity);
		}

		// Token: 0x060105E1 RID: 67041 RVA: 0x00181A0D File Offset: 0x0017FC0D
		public FVectorDouble D_GetLocationAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_GetLocationAtSplinePoint_Internal(base.NativePtr, PointIndex, CoordinateSpace);
		}

		// Token: 0x060105E2 RID: 67042 RVA: 0x00181A21 File Offset: 0x0017FC21
		public FVectorDouble D_GetLocationAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_GetLocationAtSplineInputKey_Internal(base.NativePtr, InKey, CoordinateSpace);
		}

		// Token: 0x060105E3 RID: 67043 RVA: 0x00181A35 File Offset: 0x0017FC35
		public FVectorDouble D_GetLocationAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_GetLocationAtDistanceAlongSpline_Internal(base.NativePtr, Distance, CoordinateSpace);
		}

		// Token: 0x060105E4 RID: 67044 RVA: 0x00181A4C File Offset: 0x0017FC4C
		public unsafe void D_GetLocationAndTangentAtSplinePoint(int PointIndex, ref FVectorDouble Location, ref FVectorDouble Tangent, ESplineCoordinateSpace CoordinateSpace)
		{
			fixed (FVectorDouble* ptr = &Location)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVectorDouble* ptr3 = &Tangent)
				{
					void* ptr4 = (void*)ptr3;
					USplineComponent.__D_GetLocationAndTangentAtSplinePoint_Internal(base.NativePtr, PointIndex, ref Location, ref Tangent, CoordinateSpace);
					ptr = null;
				}
			}
		}

		// Token: 0x060105E5 RID: 67045 RVA: 0x00181A80 File Offset: 0x0017FC80
		public unsafe FVectorDouble D_GetLocationAndKeyAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace, ref float Key)
		{
			fixed (float* ptr = &Key)
			{
				void* ptr2 = (void*)ptr;
				return USplineComponent.__D_GetLocationAndKeyAtDistanceAlongSpline_Internal(base.NativePtr, Distance, CoordinateSpace, ref Key);
			}
		}

		// Token: 0x060105E6 RID: 67046 RVA: 0x00181AA5 File Offset: 0x0017FCA5
		public FVectorDouble D_GetLeaveTangentAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_GetLeaveTangentAtSplinePoint_Internal(base.NativePtr, PointIndex, CoordinateSpace);
		}

		// Token: 0x060105E7 RID: 67047 RVA: 0x00181AB9 File Offset: 0x0017FCB9
		public FVectorDouble D_GetDirectionAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false)
		{
			return USplineComponent.__D_GetDirectionAtTime_Internal(base.NativePtr, Time, CoordinateSpace, bUseConstantVelocity);
		}

		// Token: 0x060105E8 RID: 67048 RVA: 0x00181ACE File Offset: 0x0017FCCE
		public FVectorDouble D_GetDirectionAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_GetDirectionAtSplinePoint_Internal(base.NativePtr, PointIndex, CoordinateSpace);
		}

		// Token: 0x060105E9 RID: 67049 RVA: 0x00181AE2 File Offset: 0x0017FCE2
		public FVectorDouble D_GetDirectionAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_GetDirectionAtSplineInputKey_Internal(base.NativePtr, InKey, CoordinateSpace);
		}

		// Token: 0x060105EA RID: 67050 RVA: 0x00181AF6 File Offset: 0x0017FCF6
		public FVectorDouble D_GetDirectionAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_GetDirectionAtDistanceAlongSpline_Internal(base.NativePtr, Distance, CoordinateSpace);
		}

		// Token: 0x060105EB RID: 67051 RVA: 0x00181B0A File Offset: 0x0017FD0A
		public FVectorDouble D_GetDefaultUpVector(ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_GetDefaultUpVector_Internal(base.NativePtr, CoordinateSpace);
		}

		// Token: 0x060105EC RID: 67052 RVA: 0x00181B1D File Offset: 0x0017FD1D
		public FVectorDouble D_GetArriveTangentAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_GetArriveTangentAtSplinePoint_Internal(base.NativePtr, PointIndex, CoordinateSpace);
		}

		// Token: 0x060105ED RID: 67053 RVA: 0x00181B31 File Offset: 0x0017FD31
		public FVectorDouble D_FindUpVectorClosestToWorldLocation(in FVectorDouble WorldLocation, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_FindUpVectorClosestToWorldLocation_Internal(base.NativePtr, WorldLocation, CoordinateSpace);
		}

		// Token: 0x060105EE RID: 67054 RVA: 0x00181B45 File Offset: 0x0017FD45
		public FTransformDouble D_FindTransformClosestToWorldLocation(in FVectorDouble WorldLocation, ESplineCoordinateSpace CoordinateSpace, bool bUseScale = false)
		{
			return USplineComponent.__D_FindTransformClosestToWorldLocation_Internal(base.NativePtr, WorldLocation, CoordinateSpace, bUseScale);
		}

		// Token: 0x060105EF RID: 67055 RVA: 0x00181B5A File Offset: 0x0017FD5A
		public FVectorDouble D_FindTangentClosestToWorldLocation(in FVectorDouble WorldLocation, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_FindTangentClosestToWorldLocation_Internal(base.NativePtr, WorldLocation, CoordinateSpace);
		}

		// Token: 0x060105F0 RID: 67056 RVA: 0x00181B6E File Offset: 0x0017FD6E
		public FVectorDouble D_FindRightVectorClosestToWorldLocation(in FVectorDouble WorldLocation, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_FindRightVectorClosestToWorldLocation_Internal(base.NativePtr, WorldLocation, CoordinateSpace);
		}

		// Token: 0x060105F1 RID: 67057 RVA: 0x00181B82 File Offset: 0x0017FD82
		public FVectorDouble D_FindLocationClosestToWorldLocation(in FVectorDouble WorldLocation, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_FindLocationClosestToWorldLocation_Internal(base.NativePtr, WorldLocation, CoordinateSpace);
		}

		// Token: 0x060105F2 RID: 67058 RVA: 0x00181B96 File Offset: 0x0017FD96
		public float D_FindInputKeyClosestToWorldLocationInRange(in FVectorDouble WorldLocation, int StartKey, int EndKey)
		{
			return USplineComponent.__D_FindInputKeyClosestToWorldLocationInRange_Internal(base.NativePtr, WorldLocation, StartKey, EndKey);
		}

		// Token: 0x060105F3 RID: 67059 RVA: 0x00181BA6 File Offset: 0x0017FDA6
		public float D_FindInputKeyClosestToWorldLocationInGravity(in FVectorDouble WorldLocation, FVector GravityDirect, float HeightLimit)
		{
			return USplineComponent.__D_FindInputKeyClosestToWorldLocationInGravity_Internal(base.NativePtr, WorldLocation, GravityDirect, HeightLimit);
		}

		// Token: 0x060105F4 RID: 67060 RVA: 0x00181BB6 File Offset: 0x0017FDB6
		public float D_FindInputKeyClosestToWorldLocationByPartitionInGravity(in FVectorDouble WorldLocation, FVector GravityDirect, float SearchRadius, float HeightLimit)
		{
			return USplineComponent.__D_FindInputKeyClosestToWorldLocationByPartitionInGravity_Internal(base.NativePtr, WorldLocation, GravityDirect, SearchRadius, HeightLimit);
		}

		// Token: 0x060105F5 RID: 67061 RVA: 0x00181BC8 File Offset: 0x0017FDC8
		public float D_FindInputKeyClosestToWorldLocationByPartition(in FVectorDouble WorldLocation, float SearchRadius)
		{
			return USplineComponent.__D_FindInputKeyClosestToWorldLocationByPartition_Internal(base.NativePtr, WorldLocation, SearchRadius);
		}

		// Token: 0x060105F6 RID: 67062 RVA: 0x00181BD7 File Offset: 0x0017FDD7
		public float D_FindInputKeyClosestToWorldLocation(in FVectorDouble WorldLocation)
		{
			return USplineComponent.__D_FindInputKeyClosestToWorldLocation_Internal(base.NativePtr, WorldLocation);
		}

		// Token: 0x060105F7 RID: 67063 RVA: 0x00181BE5 File Offset: 0x0017FDE5
		public FVectorDouble D_FindDirectionClosestToWorldLocation(in FVectorDouble WorldLocation, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_FindDirectionClosestToWorldLocation_Internal(base.NativePtr, WorldLocation, CoordinateSpace);
		}

		// Token: 0x060105F8 RID: 67064 RVA: 0x00181BF9 File Offset: 0x0017FDF9
		public void D_AddSplinePointAtIndex(in FVectorDouble Position, int Index, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
		{
			USplineComponent.__D_AddSplinePointAtIndex_Internal(base.NativePtr, Position, Index, CoordinateSpace, bUpdateSpline);
		}

		// Token: 0x060105F9 RID: 67065 RVA: 0x00181C10 File Offset: 0x0017FE10
		public void D_AddSplinePoint(in FVectorDouble Position, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
		{
			USplineComponent.__D_AddSplinePoint_Internal(base.NativePtr, Position, CoordinateSpace, bUpdateSpline);
		}

		// Token: 0x060105FA RID: 67066 RVA: 0x00181C25 File Offset: 0x0017FE25
		public void ClearSplinePoints(bool bUpdateSpline = true)
		{
			USplineComponent.__ClearSplinePoints_Internal(base.NativePtr, bUpdateSpline);
		}

		// Token: 0x060105FB RID: 67067 RVA: 0x00181C33 File Offset: 0x0017FE33
		public void AddSplineWorldPoint(in FVector Position)
		{
			USplineComponent.__AddSplineWorldPoint_Internal(base.NativePtr, Position);
		}

		// Token: 0x060105FC RID: 67068 RVA: 0x00181C41 File Offset: 0x0017FE41
		public void AddSplinePointAtIndex(in FVector Position, int Index, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
		{
			USplineComponent.__AddSplinePointAtIndex_Internal(base.NativePtr, Position, Index, CoordinateSpace, bUpdateSpline);
		}

		// Token: 0x060105FD RID: 67069 RVA: 0x00181C58 File Offset: 0x0017FE58
		public void AddSplinePoint(in FVector Position, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
		{
			USplineComponent.__AddSplinePoint_Internal(base.NativePtr, Position, CoordinateSpace, bUpdateSpline);
		}

		// Token: 0x060105FE RID: 67070 RVA: 0x00181C6D File Offset: 0x0017FE6D
		public void AddSplineLocalPoint(in FVector Position)
		{
			USplineComponent.__AddSplineLocalPoint_Internal(base.NativePtr, Position);
		}

		// Token: 0x060105FF RID: 67071 RVA: 0x00181C7B File Offset: 0x0017FE7B
		public void AddPoints([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FSplinePoint> Points, bool bUpdateSpline = true)
		{
			USplineComponent.__AddPoints_Internal(base.NativePtr, (Points ?? new TArray<FSplinePoint>()).NativePtr, bUpdateSpline);
		}

		// Token: 0x06010600 RID: 67072 RVA: 0x00181C99 File Offset: 0x0017FE99
		[NullableContext(2)]
		public void AddPoint(in FSplinePoint Point, bool bUpdateSpline = true)
		{
			USplineComponent.__AddPoint_Internal(base.NativePtr, (Point ?? new FSplinePoint()).NativePtr, bUpdateSpline);
		}

		// Token: 0x06010601 RID: 67073
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateSpline_Internal(IntPtr @this);

		// Token: 0x06010602 RID: 67074
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWorldLocationAtSplinePoint_Internal(IntPtr @this, int PointIndex, in FVector InLocation);

		// Token: 0x06010603 RID: 67075
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUpVectorAtSplinePoint_Internal(IntPtr @this, int PointIndex, in FVector InUpVector, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUpdateSpline);

		// Token: 0x06010604 RID: 67076
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUnselectedSplineSegmentColor_Internal(IntPtr @this, in FLinearColor SegmentColor);

		// Token: 0x06010605 RID: 67077
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTangentsAtSplinePoint_Internal(IntPtr @this, int PointIndex, in FVector InArriveTangent, in FVector InLeaveTangent, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUpdateSpline);

		// Token: 0x06010606 RID: 67078
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTangentColor_Internal(IntPtr @this, in FLinearColor TangentColor);

		// Token: 0x06010607 RID: 67079
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTangentAtSplinePoint_Internal(IntPtr @this, int PointIndex, in FVector InTangent, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUpdateSpline);

		// Token: 0x06010608 RID: 67080
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSplineWorldPoints_Internal(IntPtr @this, IntPtr Points);

		// Token: 0x06010609 RID: 67081
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSplinePointType_Internal(IntPtr @this, int PointIndex, TEnumAsByte<ESplinePointType> Type, bool bUpdateSpline);

		// Token: 0x0601060A RID: 67082
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSplinePoints_Internal(IntPtr @this, IntPtr Points, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUpdateSpline);

		// Token: 0x0601060B RID: 67083
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSplineLocalPoints_Internal(IntPtr @this, IntPtr Points);

		// Token: 0x0601060C RID: 67084
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSelectedSplineSegmentColor_Internal(IntPtr @this, in FLinearColor SegmentColor);

		// Token: 0x0601060D RID: 67085
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetScaleAtSplinePoint_Internal(IntPtr @this, int PointIndex, in FVector InScaleVector, bool bUpdateSpline);

		// Token: 0x0601060E RID: 67086
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRotationAtSplinePoint_Internal(IntPtr @this, int PointIndex, in FRotator InRotation, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUpdateSpline);

		// Token: 0x0601060F RID: 67087
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLocationAtSplinePoint_Internal(IntPtr @this, int PointIndex, in FVector InLocation, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUpdateSpline);

		// Token: 0x06010610 RID: 67088
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDrawDebug_Internal(IntPtr @this, bool bShow);

		// Token: 0x06010611 RID: 67089
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDefaultUpVector_Internal(IntPtr @this, in FVector UpVector, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x06010612 RID: 67090
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetClosedLoopAtPosition_Internal(IntPtr @this, bool bInClosedLoop, float Key, bool bUpdateSpline);

		// Token: 0x06010613 RID: 67091
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetClosedLoop_Internal(IntPtr @this, bool bInClosedLoop, bool bUpdateSpline);

		// Token: 0x06010614 RID: 67092
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveSplinePoint_Internal(IntPtr @this, int Index, bool bUpdateSpline);

		// Token: 0x06010615 RID: 67093
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsClosedLoop_Internal(IntPtr @this);

		// Token: 0x06010616 RID: 67094
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetWorldTangentAtDistanceAlongSpline_Internal(IntPtr @this, float Distance);

		// Token: 0x06010617 RID: 67095
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __GetWorldRotationAtTime_Internal(IntPtr @this, float Time, bool bUseConstantVelocity);

		// Token: 0x06010618 RID: 67096
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __GetWorldRotationAtDistanceAlongSpline_Internal(IntPtr @this, float Distance);

		// Token: 0x06010619 RID: 67097
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetWorldLocationAtTime_Internal(IntPtr @this, float Time, bool bUseConstantVelocity);

		// Token: 0x0601061A RID: 67098
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetWorldLocationAtSplinePoint_Internal(IntPtr @this, int PointIndex);

		// Token: 0x0601061B RID: 67099
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetWorldLocationAtDistanceAlongSpline_Internal(IntPtr @this, float Distance);

		// Token: 0x0601061C RID: 67100
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetWorldDirectionAtTime_Internal(IntPtr @this, float Time, bool bUseConstantVelocity);

		// Token: 0x0601061D RID: 67101
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetWorldDirectionAtDistanceAlongSpline_Internal(IntPtr @this, float Distance);

		// Token: 0x0601061E RID: 67102
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetVectorPropertyAtSplinePoint_Internal(IntPtr @this, int Index, FName PropertyName);

		// Token: 0x0601061F RID: 67103
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetVectorPropertyAtSplineInputKey_Internal(IntPtr @this, float InKey, FName PropertyName);

		// Token: 0x06010620 RID: 67104
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetUpVectorAtTime_Internal(IntPtr @this, float Time, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseConstantVelocity);

		// Token: 0x06010621 RID: 67105
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetUpVectorAtSplinePoint_Internal(IntPtr @this, int PointIndex, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x06010622 RID: 67106
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetUpVectorAtSplineInputKey_Internal(IntPtr @this, float InKey, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x06010623 RID: 67107
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetUpVectorAtDistanceAlongSpline_Internal(IntPtr @this, float Distance, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x06010624 RID: 67108
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetTransformAtTime_Internal(IntPtr @this, float Time, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseConstantVelocity, bool bUseScale);

		// Token: 0x06010625 RID: 67109
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetTransformAtSplinePoint_Internal(IntPtr @this, int PointIndex, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseScale);

		// Token: 0x06010626 RID: 67110
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetTransformAtSplineInputKey_Internal(IntPtr @this, float InKey, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseScale);

		// Token: 0x06010627 RID: 67111
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetTransformAtDistanceAlongSpline_Internal(IntPtr @this, float Distance, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseScale);

		// Token: 0x06010628 RID: 67112
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetTangentAtTime_Internal(IntPtr @this, float Time, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseConstantVelocity);

		// Token: 0x06010629 RID: 67113
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetTangentAtSplinePoint_Internal(IntPtr @this, int PointIndex, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x0601062A RID: 67114
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetTangentAtSplineInputKey_Internal(IntPtr @this, float InKey, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x0601062B RID: 67115
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetTangentAtDistanceAlongSpline_Internal(IntPtr @this, float Distance, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x0601062C RID: 67116
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<ESplinePointType> __GetSplinePointType_Internal(IntPtr @this, int PointIndex);

		// Token: 0x0601062D RID: 67117
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetSplineLength_Internal(IntPtr @this);

		// Token: 0x0601062E RID: 67118
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetScaleAtTime_Internal(IntPtr @this, float Time, bool bUseConstantVelocity);

		// Token: 0x0601062F RID: 67119
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetScaleAtSplinePoint_Internal(IntPtr @this, int PointIndex);

		// Token: 0x06010630 RID: 67120
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetScaleAtSplineInputKey_Internal(IntPtr @this, float InKey);

		// Token: 0x06010631 RID: 67121
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetScaleAtDistanceAlongSpline_Internal(IntPtr @this, float Distance);

		// Token: 0x06010632 RID: 67122
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __GetRotationAtTime_Internal(IntPtr @this, float Time, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseConstantVelocity);

		// Token: 0x06010633 RID: 67123
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __GetRotationAtSplinePoint_Internal(IntPtr @this, int PointIndex, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x06010634 RID: 67124
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __GetRotationAtSplineInputKey_Internal(IntPtr @this, float InKey, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x06010635 RID: 67125
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __GetRotationAtDistanceAlongSpline_Internal(IntPtr @this, float Distance, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x06010636 RID: 67126
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRollAtTime_Internal(IntPtr @this, float Time, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseConstantVelocity);

		// Token: 0x06010637 RID: 67127
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRollAtSplinePoint_Internal(IntPtr @this, int PointIndex, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x06010638 RID: 67128
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRollAtSplineInputKey_Internal(IntPtr @this, float InKey, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x06010639 RID: 67129
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRollAtDistanceAlongSpline_Internal(IntPtr @this, float Distance, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x0601063A RID: 67130
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetRightVectorAtTime_Internal(IntPtr @this, float Time, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseConstantVelocity);

		// Token: 0x0601063B RID: 67131
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetRightVectorAtSplinePoint_Internal(IntPtr @this, int PointIndex, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x0601063C RID: 67132
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetRightVectorAtSplineInputKey_Internal(IntPtr @this, float InKey, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x0601063D RID: 67133
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetRightVectorAtDistanceAlongSpline_Internal(IntPtr @this, float Distance, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x0601063E RID: 67134
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPoints_Internal(IntPtr @this);

		// Token: 0x0601063F RID: 67135
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumberOfSplineSegments_Internal(IntPtr @this);

		// Token: 0x06010640 RID: 67136
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumberOfSplinePoints_Internal(IntPtr @this);

		// Token: 0x06010641 RID: 67137
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetLocationAtTime_Internal(IntPtr @this, float Time, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseConstantVelocity);

		// Token: 0x06010642 RID: 67138
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetLocationAtSplinePoint_Internal(IntPtr @this, int PointIndex, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x06010643 RID: 67139
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetLocationAtSplineInputKey_Internal(IntPtr @this, float InKey, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x06010644 RID: 67140
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetLocationAtDistanceAlongSpline_Internal(IntPtr @this, float Distance, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x06010645 RID: 67141
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetLocationAndTangentAtSplinePoint_Internal(IntPtr @this, int PointIndex, ref FVector Location, ref FVector Tangent, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x06010646 RID: 67142
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetLocationAndKeyAtDistanceAlongSpline_Internal(IntPtr @this, float Distance, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, ref float Key);

		// Token: 0x06010647 RID: 67143
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetLocalLocationAndTangentAtSplinePoint_Internal(IntPtr @this, int PointIndex, ref FVector LocalLocation, ref FVector LocalTangent);

		// Token: 0x06010648 RID: 67144
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetLeaveTangentAtSplinePoint_Internal(IntPtr @this, int PointIndex, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x06010649 RID: 67145
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetInputKeyAtDistanceAlongSpline_Internal(IntPtr @this, float Distance);

		// Token: 0x0601064A RID: 67146
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetFloatPropertyAtSplinePoint_Internal(IntPtr @this, int Index, FName PropertyName);

		// Token: 0x0601064B RID: 67147
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetFloatPropertyAtSplineInputKey_Internal(IntPtr @this, float InKey, FName PropertyName);

		// Token: 0x0601064C RID: 67148
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetDistanceAlongSplineAtSplinePoint_Internal(IntPtr @this, int PointIndex);

		// Token: 0x0601064D RID: 67149
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetDistanceAlongSplineAtSplineInputKey_Internal(IntPtr @this, float InKey);

		// Token: 0x0601064E RID: 67150
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetDirectionAtTime_Internal(IntPtr @this, float Time, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseConstantVelocity);

		// Token: 0x0601064F RID: 67151
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetDirectionAtSplinePoint_Internal(IntPtr @this, int PointIndex, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x06010650 RID: 67152
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetDirectionAtSplineInputKey_Internal(IntPtr @this, float InKey, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x06010651 RID: 67153
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetDirectionAtDistanceAlongSpline_Internal(IntPtr @this, float Distance, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x06010652 RID: 67154
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetDefaultUpVector_Internal(IntPtr @this, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x06010653 RID: 67155
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetArriveTangentAtSplinePoint_Internal(IntPtr @this, int PointIndex, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x06010654 RID: 67156
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __FindUpVectorClosestToWorldLocation_Internal(IntPtr @this, in FVector WorldLocation, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x06010655 RID: 67157
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __FindTransformClosestToWorldLocation_Internal(IntPtr @this, in FVector WorldLocation, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseScale);

		// Token: 0x06010656 RID: 67158
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __FindTangentClosestToWorldLocation_Internal(IntPtr @this, in FVector WorldLocation, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x06010657 RID: 67159
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __FindScaleClosestToWorldLocation_Internal(IntPtr @this, in FVector WorldLocation);

		// Token: 0x06010658 RID: 67160
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __FindRotationClosestToWorldLocation_Internal(IntPtr @this, in FVector WorldLocation, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x06010659 RID: 67161
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __FindRollClosestToWorldLocation_Internal(IntPtr @this, in FVector WorldLocation, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x0601065A RID: 67162
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __FindRightVectorClosestToWorldLocation_Internal(IntPtr @this, in FVector WorldLocation, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x0601065B RID: 67163
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __FindLocationClosestToWorldLocation_Internal(IntPtr @this, in FVector WorldLocation, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x0601065C RID: 67164
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __FindInputKeyClosestToWorldLocationInRange_Internal(IntPtr @this, in FVector WorldLocation, int StartKey, int EndKey);

		// Token: 0x0601065D RID: 67165
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __FindInputKeyClosestToWorldLocationByPartitionInGravity_Internal(IntPtr @this, in FVector WorldLocation, FVector GravityDirect, float SearchRadius, float HeightLimit);

		// Token: 0x0601065E RID: 67166
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __FindInputKeyClosestToWorldLocationByPartition_Internal(IntPtr @this, in FVector WorldLocation, float SearchRadius);

		// Token: 0x0601065F RID: 67167
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __FindInputKeyClosestToWorldLocation_Internal(IntPtr @this, in FVector WorldLocation);

		// Token: 0x06010660 RID: 67168
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __FindDirectionClosestToWorldLocation_Internal(IntPtr @this, in FVector WorldLocation, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x06010661 RID: 67169
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_SetUpVectorAtSplinePoint_Internal(IntPtr @this, int PointIndex, in FVectorDouble InUpVector, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUpdateSpline);

		// Token: 0x06010662 RID: 67170
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_SetTangentsAtSplinePoint_Internal(IntPtr @this, int PointIndex, in FVectorDouble InArriveTangent, in FVectorDouble InLeaveTangent, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUpdateSpline);

		// Token: 0x06010663 RID: 67171
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_SetTangentAtSplinePoint_Internal(IntPtr @this, int PointIndex, in FVectorDouble InTangent, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUpdateSpline);

		// Token: 0x06010664 RID: 67172
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_SetSplinePoints_Internal(IntPtr @this, IntPtr Points, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUpdateSpline);

		// Token: 0x06010665 RID: 67173
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_SetLocationAtSplinePoint_Internal(IntPtr @this, int PointIndex, in FVectorDouble InLocation, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUpdateSpline);

		// Token: 0x06010666 RID: 67174
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_SetDefaultUpVector_Internal(IntPtr @this, in FVectorDouble UpVector, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x06010667 RID: 67175
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetVectorPropertyAtSplinePoint_Internal(IntPtr @this, int Index, FName PropertyName);

		// Token: 0x06010668 RID: 67176
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetVectorPropertyAtSplineInputKey_Internal(IntPtr @this, float InKey, FName PropertyName);

		// Token: 0x06010669 RID: 67177
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetUpVectorAtTime_Internal(IntPtr @this, float Time, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseConstantVelocity);

		// Token: 0x0601066A RID: 67178
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetUpVectorAtSplinePoint_Internal(IntPtr @this, int PointIndex, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x0601066B RID: 67179
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetUpVectorAtSplineInputKey_Internal(IntPtr @this, float InKey, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x0601066C RID: 67180
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetUpVectorAtDistanceAlongSpline_Internal(IntPtr @this, float Distance, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x0601066D RID: 67181
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble __D_GetTransformAtTime_Internal(IntPtr @this, float Time, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseConstantVelocity, bool bUseScale);

		// Token: 0x0601066E RID: 67182
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble __D_GetTransformAtSplinePoint_Internal(IntPtr @this, int PointIndex, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseScale);

		// Token: 0x0601066F RID: 67183
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble __D_GetTransformAtSplineInputKey_Internal(IntPtr @this, float InKey, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseScale);

		// Token: 0x06010670 RID: 67184
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble __D_GetTransformAtDistanceAlongSpline_Internal(IntPtr @this, float Distance, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseScale);

		// Token: 0x06010671 RID: 67185
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetTangentAtTime_Internal(IntPtr @this, float Time, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseConstantVelocity);

		// Token: 0x06010672 RID: 67186
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetTangentAtSplinePoint_Internal(IntPtr @this, int PointIndex, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x06010673 RID: 67187
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetTangentAtSplineInputKey_Internal(IntPtr @this, float InKey, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x06010674 RID: 67188
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetTangentAtDistanceAlongSpline_Internal(IntPtr @this, float Distance, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x06010675 RID: 67189
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetScaleAtDistanceAlongSpline_Internal(IntPtr @this, float Distance);

		// Token: 0x06010676 RID: 67190
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetRightVectorAtTime_Internal(IntPtr @this, float Time, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseConstantVelocity);

		// Token: 0x06010677 RID: 67191
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetRightVectorAtSplinePoint_Internal(IntPtr @this, int PointIndex, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x06010678 RID: 67192
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetRightVectorAtSplineInputKey_Internal(IntPtr @this, float InKey, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x06010679 RID: 67193
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetRightVectorAtDistanceAlongSpline_Internal(IntPtr @this, float Distance, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x0601067A RID: 67194
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetLocationAtTime_Internal(IntPtr @this, float Time, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseConstantVelocity);

		// Token: 0x0601067B RID: 67195
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetLocationAtSplinePoint_Internal(IntPtr @this, int PointIndex, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x0601067C RID: 67196
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetLocationAtSplineInputKey_Internal(IntPtr @this, float InKey, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x0601067D RID: 67197
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetLocationAtDistanceAlongSpline_Internal(IntPtr @this, float Distance, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x0601067E RID: 67198
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_GetLocationAndTangentAtSplinePoint_Internal(IntPtr @this, int PointIndex, ref FVectorDouble Location, ref FVectorDouble Tangent, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x0601067F RID: 67199
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetLocationAndKeyAtDistanceAlongSpline_Internal(IntPtr @this, float Distance, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, ref float Key);

		// Token: 0x06010680 RID: 67200
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetLeaveTangentAtSplinePoint_Internal(IntPtr @this, int PointIndex, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x06010681 RID: 67201
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetDirectionAtTime_Internal(IntPtr @this, float Time, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseConstantVelocity);

		// Token: 0x06010682 RID: 67202
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetDirectionAtSplinePoint_Internal(IntPtr @this, int PointIndex, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x06010683 RID: 67203
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetDirectionAtSplineInputKey_Internal(IntPtr @this, float InKey, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x06010684 RID: 67204
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetDirectionAtDistanceAlongSpline_Internal(IntPtr @this, float Distance, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x06010685 RID: 67205
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetDefaultUpVector_Internal(IntPtr @this, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x06010686 RID: 67206
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetArriveTangentAtSplinePoint_Internal(IntPtr @this, int PointIndex, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x06010687 RID: 67207
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_FindUpVectorClosestToWorldLocation_Internal(IntPtr @this, in FVectorDouble WorldLocation, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x06010688 RID: 67208
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble __D_FindTransformClosestToWorldLocation_Internal(IntPtr @this, in FVectorDouble WorldLocation, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseScale);

		// Token: 0x06010689 RID: 67209
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_FindTangentClosestToWorldLocation_Internal(IntPtr @this, in FVectorDouble WorldLocation, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x0601068A RID: 67210
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_FindRightVectorClosestToWorldLocation_Internal(IntPtr @this, in FVectorDouble WorldLocation, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x0601068B RID: 67211
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_FindLocationClosestToWorldLocation_Internal(IntPtr @this, in FVectorDouble WorldLocation, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x0601068C RID: 67212
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __D_FindInputKeyClosestToWorldLocationInRange_Internal(IntPtr @this, in FVectorDouble WorldLocation, int StartKey, int EndKey);

		// Token: 0x0601068D RID: 67213
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __D_FindInputKeyClosestToWorldLocationInGravity_Internal(IntPtr @this, in FVectorDouble WorldLocation, FVector GravityDirect, float HeightLimit);

		// Token: 0x0601068E RID: 67214
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __D_FindInputKeyClosestToWorldLocationByPartitionInGravity_Internal(IntPtr @this, in FVectorDouble WorldLocation, FVector GravityDirect, float SearchRadius, float HeightLimit);

		// Token: 0x0601068F RID: 67215
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __D_FindInputKeyClosestToWorldLocationByPartition_Internal(IntPtr @this, in FVectorDouble WorldLocation, float SearchRadius);

		// Token: 0x06010690 RID: 67216
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __D_FindInputKeyClosestToWorldLocation_Internal(IntPtr @this, in FVectorDouble WorldLocation);

		// Token: 0x06010691 RID: 67217
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_FindDirectionClosestToWorldLocation_Internal(IntPtr @this, in FVectorDouble WorldLocation, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x06010692 RID: 67218
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_AddSplinePointAtIndex_Internal(IntPtr @this, in FVectorDouble Position, int Index, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUpdateSpline);

		// Token: 0x06010693 RID: 67219
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_AddSplinePoint_Internal(IntPtr @this, in FVectorDouble Position, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUpdateSpline);

		// Token: 0x06010694 RID: 67220
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearSplinePoints_Internal(IntPtr @this, bool bUpdateSpline);

		// Token: 0x06010695 RID: 67221
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddSplineWorldPoint_Internal(IntPtr @this, in FVector Position);

		// Token: 0x06010696 RID: 67222
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddSplinePointAtIndex_Internal(IntPtr @this, in FVector Position, int Index, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUpdateSpline);

		// Token: 0x06010697 RID: 67223
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddSplinePoint_Internal(IntPtr @this, in FVector Position, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUpdateSpline);

		// Token: 0x06010698 RID: 67224
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddSplineLocalPoint_Internal(IntPtr @this, in FVector Position);

		// Token: 0x06010699 RID: 67225
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddPoints_Internal(IntPtr @this, IntPtr Points, bool bUpdateSpline);

		// Token: 0x0601069A RID: 67226
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddPoint_Internal(IntPtr @this, IntPtr Point, bool bUpdateSpline);

		// Token: 0x0601069B RID: 67227 RVA: 0x00181CB7 File Offset: 0x0017FEB7
		static USplineComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SplineComponent");
		}

		// Token: 0x0601069C RID: 67228 RVA: 0x00181CC5 File Offset: 0x0017FEC5
		protected USplineComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008C7E RID: 35966
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SplineComponent";

		// Token: 0x04008C7F RID: 35967
		private static IntPtr _ClassPtr;

		// Token: 0x04008C80 RID: 35968
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008C81 RID: 35969
		internal static int __PropertyOffset_SplineCurves;

		// Token: 0x04008C82 RID: 35970
		[Nullable(2)]
		private FSplineCurves _SplineCurves;

		// Token: 0x04008C83 RID: 35971
		internal static int __PropertyOffset_SplineInfo_DEPRECATED;

		// Token: 0x04008C84 RID: 35972
		[Nullable(2)]
		private FInterpCurveVector _SplineInfo_DEPRECATED;

		// Token: 0x04008C85 RID: 35973
		internal static int __PropertyOffset_SplineRotInfo_DEPRECATED;

		// Token: 0x04008C86 RID: 35974
		[Nullable(2)]
		private FInterpCurveQuat _SplineRotInfo_DEPRECATED;

		// Token: 0x04008C87 RID: 35975
		internal static int __PropertyOffset_SplineScaleInfo_DEPRECATED;

		// Token: 0x04008C88 RID: 35976
		[Nullable(2)]
		private FInterpCurveVector _SplineScaleInfo_DEPRECATED;

		// Token: 0x04008C89 RID: 35977
		internal static int __PropertyOffset_SplineReparamTable_DEPRECATED;

		// Token: 0x04008C8A RID: 35978
		[Nullable(2)]
		private FInterpCurveFloat _SplineReparamTable_DEPRECATED;

		// Token: 0x04008C8B RID: 35979
		internal static int __PropertyOffset_bAllowSplineEditingPerInstance_DEPRECATED;

		// Token: 0x04008C8C RID: 35980
		internal static int __PropertyOffset_ReparamStepsPerSegment;

		// Token: 0x04008C8D RID: 35981
		internal static int __PropertyOffset_Duration;

		// Token: 0x04008C8E RID: 35982
		internal static int __PropertyOffset_bStationaryEndpoints;

		// Token: 0x04008C8F RID: 35983
		internal static int __PropertyOffset_bSplineHasBeenEdited;

		// Token: 0x04008C90 RID: 35984
		internal static int __PropertyOffset_bModifiedByConstructionScript;

		// Token: 0x04008C91 RID: 35985
		internal static int __PropertyOffset_bInputSplinePointsToConstructionScript;

		// Token: 0x04008C92 RID: 35986
		internal static int __PropertyOffset_bDrawDebug;

		// Token: 0x04008C93 RID: 35987
		internal static int __PropertyOffset_bClosedLoop;

		// Token: 0x04008C94 RID: 35988
		internal static int __PropertyOffset_bLoopPositionOverride;

		// Token: 0x04008C95 RID: 35989
		internal static int __PropertyOffset_LoopPosition;

		// Token: 0x04008C96 RID: 35990
		internal static int __PropertyOffset_DefaultUpVector;
	}
}
