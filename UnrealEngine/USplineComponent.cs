using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000287 RID: 647
	[UnrealObjectPath("/Script/Engine.SplineComponent")]
	[UnrealStructLayout(1872, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1872)]
	public class USplineComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060045AB RID: 17835 RVA: 0x000629E1 File Offset: 0x00060BE1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USplineComponent._ClassPtr;
		}

		// Token: 0x060045AC RID: 17836 RVA: 0x000629F0 File Offset: 0x00060BF0
		public USplineComponent() : this(BuiltinUtils.AllocNativeUObject(USplineComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060045AD RID: 17837 RVA: 0x00062A18 File Offset: 0x00060C18
		[NullableContext(1)]
		public USplineComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USplineComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x060045AE RID: 17838 RVA: 0x00062A4C File Offset: 0x00060C4C
		// (set) Token: 0x060045AF RID: 17839 RVA: 0x00062A85 File Offset: 0x00060C85
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

		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x060045B0 RID: 17840 RVA: 0x00062AA8 File Offset: 0x00060CA8
		// (set) Token: 0x060045B1 RID: 17841 RVA: 0x00062AE1 File Offset: 0x00060CE1
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

		// Token: 0x17000D05 RID: 3333
		// (get) Token: 0x060045B2 RID: 17842 RVA: 0x00062B04 File Offset: 0x00060D04
		// (set) Token: 0x060045B3 RID: 17843 RVA: 0x00062B3D File Offset: 0x00060D3D
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

		// Token: 0x17000D06 RID: 3334
		// (get) Token: 0x060045B4 RID: 17844 RVA: 0x00062B60 File Offset: 0x00060D60
		// (set) Token: 0x060045B5 RID: 17845 RVA: 0x00062B99 File Offset: 0x00060D99
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

		// Token: 0x17000D07 RID: 3335
		// (get) Token: 0x060045B6 RID: 17846 RVA: 0x00062BBC File Offset: 0x00060DBC
		// (set) Token: 0x060045B7 RID: 17847 RVA: 0x00062BF5 File Offset: 0x00060DF5
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

		// Token: 0x17000D08 RID: 3336
		// (get) Token: 0x060045B8 RID: 17848 RVA: 0x00062C16 File Offset: 0x00060E16
		// (set) Token: 0x060045B9 RID: 17849 RVA: 0x00062C26 File Offset: 0x00060E26
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

		// Token: 0x17000D09 RID: 3337
		// (get) Token: 0x060045BA RID: 17850 RVA: 0x00062C37 File Offset: 0x00060E37
		// (set) Token: 0x060045BB RID: 17851 RVA: 0x00062C47 File Offset: 0x00060E47
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

		// Token: 0x17000D0A RID: 3338
		// (get) Token: 0x060045BC RID: 17852 RVA: 0x00062C58 File Offset: 0x00060E58
		// (set) Token: 0x060045BD RID: 17853 RVA: 0x00062C68 File Offset: 0x00060E68
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

		// Token: 0x17000D0B RID: 3339
		// (get) Token: 0x060045BE RID: 17854 RVA: 0x00062C79 File Offset: 0x00060E79
		// (set) Token: 0x060045BF RID: 17855 RVA: 0x00062C89 File Offset: 0x00060E89
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

		// Token: 0x17000D0C RID: 3340
		// (get) Token: 0x060045C0 RID: 17856 RVA: 0x00062C9A File Offset: 0x00060E9A
		// (set) Token: 0x060045C1 RID: 17857 RVA: 0x00062CAA File Offset: 0x00060EAA
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

		// Token: 0x17000D0D RID: 3341
		// (get) Token: 0x060045C2 RID: 17858 RVA: 0x00062CBB File Offset: 0x00060EBB
		// (set) Token: 0x060045C3 RID: 17859 RVA: 0x00062CCB File Offset: 0x00060ECB
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

		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x060045C4 RID: 17860 RVA: 0x00062CDC File Offset: 0x00060EDC
		// (set) Token: 0x060045C5 RID: 17861 RVA: 0x00062CEC File Offset: 0x00060EEC
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

		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x060045C6 RID: 17862 RVA: 0x00062CFD File Offset: 0x00060EFD
		// (set) Token: 0x060045C7 RID: 17863 RVA: 0x00062D0D File Offset: 0x00060F0D
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

		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x060045C8 RID: 17864 RVA: 0x00062D1E File Offset: 0x00060F1E
		// (set) Token: 0x060045C9 RID: 17865 RVA: 0x00062D2E File Offset: 0x00060F2E
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

		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x060045CA RID: 17866 RVA: 0x00062D3F File Offset: 0x00060F3F
		// (set) Token: 0x060045CB RID: 17867 RVA: 0x00062D4F File Offset: 0x00060F4F
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

		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x060045CC RID: 17868 RVA: 0x00062D60 File Offset: 0x00060F60
		// (set) Token: 0x060045CD RID: 17869 RVA: 0x00062D70 File Offset: 0x00060F70
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

		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x060045CE RID: 17870 RVA: 0x00062D81 File Offset: 0x00060F81
		// (set) Token: 0x060045CF RID: 17871 RVA: 0x00062D95 File Offset: 0x00060F95
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

		// Token: 0x060045D0 RID: 17872 RVA: 0x00062DAA File Offset: 0x00060FAA
		public void UpdateSpline()
		{
			USplineComponent.__UpdateSpline_Internal(base.NativePtr);
		}

		// Token: 0x060045D1 RID: 17873 RVA: 0x00062DB7 File Offset: 0x00060FB7
		public void SetWorldLocationAtSplinePoint(int PointIndex, in FVector InLocation)
		{
			USplineComponent.__SetWorldLocationAtSplinePoint_Internal(base.NativePtr, PointIndex, InLocation);
		}

		// Token: 0x060045D2 RID: 17874 RVA: 0x00062DC6 File Offset: 0x00060FC6
		public void SetUpVectorAtSplinePoint(int PointIndex, in FVector InUpVector, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
		{
			USplineComponent.__SetUpVectorAtSplinePoint_Internal(base.NativePtr, PointIndex, InUpVector, CoordinateSpace, bUpdateSpline);
		}

		// Token: 0x060045D3 RID: 17875 RVA: 0x00062DDD File Offset: 0x00060FDD
		public void SetUnselectedSplineSegmentColor(in FLinearColor SegmentColor)
		{
			USplineComponent.__SetUnselectedSplineSegmentColor_Internal(base.NativePtr, SegmentColor);
		}

		// Token: 0x060045D4 RID: 17876 RVA: 0x00062DEB File Offset: 0x00060FEB
		public void SetTangentsAtSplinePoint(int PointIndex, in FVector InArriveTangent, in FVector InLeaveTangent, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
		{
			USplineComponent.__SetTangentsAtSplinePoint_Internal(base.NativePtr, PointIndex, InArriveTangent, InLeaveTangent, CoordinateSpace, bUpdateSpline);
		}

		// Token: 0x060045D5 RID: 17877 RVA: 0x00062E04 File Offset: 0x00061004
		public void SetTangentColor(in FLinearColor TangentColor)
		{
			USplineComponent.__SetTangentColor_Internal(base.NativePtr, TangentColor);
		}

		// Token: 0x060045D6 RID: 17878 RVA: 0x00062E12 File Offset: 0x00061012
		public void SetTangentAtSplinePoint(int PointIndex, in FVector InTangent, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
		{
			USplineComponent.__SetTangentAtSplinePoint_Internal(base.NativePtr, PointIndex, InTangent, CoordinateSpace, bUpdateSpline);
		}

		// Token: 0x060045D7 RID: 17879 RVA: 0x00062E29 File Offset: 0x00061029
		[NullableContext(2)]
		public void SetSplineWorldPoints(in TArray<FVector> Points)
		{
			USplineComponent.__SetSplineWorldPoints_Internal(base.NativePtr, (Points ?? new TArray<FVector>()).NativePtr);
		}

		// Token: 0x060045D8 RID: 17880 RVA: 0x00062E46 File Offset: 0x00061046
		public void SetSplinePointType(int PointIndex, ESplinePointType Type, bool bUpdateSpline = true)
		{
			USplineComponent.__SetSplinePointType_Internal(base.NativePtr, PointIndex, Type, bUpdateSpline);
		}

		// Token: 0x060045D9 RID: 17881 RVA: 0x00062E5B File Offset: 0x0006105B
		[NullableContext(2)]
		public void SetSplinePoints(in TArray<FVector> Points, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
		{
			USplineComponent.__SetSplinePoints_Internal(base.NativePtr, (Points ?? new TArray<FVector>()).NativePtr, CoordinateSpace, bUpdateSpline);
		}

		// Token: 0x060045DA RID: 17882 RVA: 0x00062E7F File Offset: 0x0006107F
		[NullableContext(2)]
		public void SetSplineLocalPoints(in TArray<FVector> Points)
		{
			USplineComponent.__SetSplineLocalPoints_Internal(base.NativePtr, (Points ?? new TArray<FVector>()).NativePtr);
		}

		// Token: 0x060045DB RID: 17883 RVA: 0x00062E9C File Offset: 0x0006109C
		public void SetSelectedSplineSegmentColor(in FLinearColor SegmentColor)
		{
			USplineComponent.__SetSelectedSplineSegmentColor_Internal(base.NativePtr, SegmentColor);
		}

		// Token: 0x060045DC RID: 17884 RVA: 0x00062EAA File Offset: 0x000610AA
		public void SetScaleAtSplinePoint(int PointIndex, in FVector InScaleVector, bool bUpdateSpline = true)
		{
			USplineComponent.__SetScaleAtSplinePoint_Internal(base.NativePtr, PointIndex, InScaleVector, bUpdateSpline);
		}

		// Token: 0x060045DD RID: 17885 RVA: 0x00062EBA File Offset: 0x000610BA
		public void SetRotationAtSplinePoint(int PointIndex, in FRotator InRotation, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
		{
			USplineComponent.__SetRotationAtSplinePoint_Internal(base.NativePtr, PointIndex, InRotation, CoordinateSpace, bUpdateSpline);
		}

		// Token: 0x060045DE RID: 17886 RVA: 0x00062ED1 File Offset: 0x000610D1
		public void SetLocationAtSplinePoint(int PointIndex, in FVector InLocation, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
		{
			USplineComponent.__SetLocationAtSplinePoint_Internal(base.NativePtr, PointIndex, InLocation, CoordinateSpace, bUpdateSpline);
		}

		// Token: 0x060045DF RID: 17887 RVA: 0x00062EE8 File Offset: 0x000610E8
		public void SetDrawDebug(bool bShow)
		{
			USplineComponent.__SetDrawDebug_Internal(base.NativePtr, bShow);
		}

		// Token: 0x060045E0 RID: 17888 RVA: 0x00062EF6 File Offset: 0x000610F6
		public void SetDefaultUpVector(in FVector UpVector, ESplineCoordinateSpace CoordinateSpace)
		{
			USplineComponent.__SetDefaultUpVector_Internal(base.NativePtr, UpVector, CoordinateSpace);
		}

		// Token: 0x060045E1 RID: 17889 RVA: 0x00062F0A File Offset: 0x0006110A
		public void SetClosedLoopAtPosition(bool bInClosedLoop, float Key, bool bUpdateSpline = true)
		{
			USplineComponent.__SetClosedLoopAtPosition_Internal(base.NativePtr, bInClosedLoop, Key, bUpdateSpline);
		}

		// Token: 0x060045E2 RID: 17890 RVA: 0x00062F1A File Offset: 0x0006111A
		public void SetClosedLoop(bool bInClosedLoop, bool bUpdateSpline = true)
		{
			USplineComponent.__SetClosedLoop_Internal(base.NativePtr, bInClosedLoop, bUpdateSpline);
		}

		// Token: 0x060045E3 RID: 17891 RVA: 0x00062F29 File Offset: 0x00061129
		public void RemoveSplinePoint(int Index, bool bUpdateSpline = true)
		{
			USplineComponent.__RemoveSplinePoint_Internal(base.NativePtr, Index, bUpdateSpline);
		}

		// Token: 0x060045E4 RID: 17892 RVA: 0x00062F38 File Offset: 0x00061138
		public bool IsClosedLoop()
		{
			return USplineComponent.__IsClosedLoop_Internal(base.NativePtr);
		}

		// Token: 0x060045E5 RID: 17893 RVA: 0x00062F45 File Offset: 0x00061145
		public FVector GetWorldTangentAtDistanceAlongSpline(float Distance)
		{
			return USplineComponent.__GetWorldTangentAtDistanceAlongSpline_Internal(base.NativePtr, Distance);
		}

		// Token: 0x060045E6 RID: 17894 RVA: 0x00062F53 File Offset: 0x00061153
		public FRotator GetWorldRotationAtTime(float Time, bool bUseConstantVelocity = false)
		{
			return USplineComponent.__GetWorldRotationAtTime_Internal(base.NativePtr, Time, bUseConstantVelocity);
		}

		// Token: 0x060045E7 RID: 17895 RVA: 0x00062F62 File Offset: 0x00061162
		public FRotator GetWorldRotationAtDistanceAlongSpline(float Distance)
		{
			return USplineComponent.__GetWorldRotationAtDistanceAlongSpline_Internal(base.NativePtr, Distance);
		}

		// Token: 0x060045E8 RID: 17896 RVA: 0x00062F70 File Offset: 0x00061170
		public FVector GetWorldLocationAtTime(float Time, bool bUseConstantVelocity = false)
		{
			return USplineComponent.__GetWorldLocationAtTime_Internal(base.NativePtr, Time, bUseConstantVelocity);
		}

		// Token: 0x060045E9 RID: 17897 RVA: 0x00062F7F File Offset: 0x0006117F
		public FVector GetWorldLocationAtSplinePoint(int PointIndex)
		{
			return USplineComponent.__GetWorldLocationAtSplinePoint_Internal(base.NativePtr, PointIndex);
		}

		// Token: 0x060045EA RID: 17898 RVA: 0x00062F8D File Offset: 0x0006118D
		public FVector GetWorldLocationAtDistanceAlongSpline(float Distance)
		{
			return USplineComponent.__GetWorldLocationAtDistanceAlongSpline_Internal(base.NativePtr, Distance);
		}

		// Token: 0x060045EB RID: 17899 RVA: 0x00062F9B File Offset: 0x0006119B
		public FVector GetWorldDirectionAtTime(float Time, bool bUseConstantVelocity = false)
		{
			return USplineComponent.__GetWorldDirectionAtTime_Internal(base.NativePtr, Time, bUseConstantVelocity);
		}

		// Token: 0x060045EC RID: 17900 RVA: 0x00062FAA File Offset: 0x000611AA
		public FVector GetWorldDirectionAtDistanceAlongSpline(float Distance)
		{
			return USplineComponent.__GetWorldDirectionAtDistanceAlongSpline_Internal(base.NativePtr, Distance);
		}

		// Token: 0x060045ED RID: 17901 RVA: 0x00062FB8 File Offset: 0x000611B8
		public FVector GetVectorPropertyAtSplinePoint(int Index, FName PropertyName)
		{
			return USplineComponent.__GetVectorPropertyAtSplinePoint_Internal(base.NativePtr, Index, PropertyName);
		}

		// Token: 0x060045EE RID: 17902 RVA: 0x00062FC7 File Offset: 0x000611C7
		public FVector GetVectorPropertyAtSplineInputKey(float InKey, FName PropertyName)
		{
			return USplineComponent.__GetVectorPropertyAtSplineInputKey_Internal(base.NativePtr, InKey, PropertyName);
		}

		// Token: 0x060045EF RID: 17903 RVA: 0x00062FD6 File Offset: 0x000611D6
		public FVector GetUpVectorAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false)
		{
			return USplineComponent.__GetUpVectorAtTime_Internal(base.NativePtr, Time, CoordinateSpace, bUseConstantVelocity);
		}

		// Token: 0x060045F0 RID: 17904 RVA: 0x00062FEB File Offset: 0x000611EB
		public FVector GetUpVectorAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetUpVectorAtSplinePoint_Internal(base.NativePtr, PointIndex, CoordinateSpace);
		}

		// Token: 0x060045F1 RID: 17905 RVA: 0x00062FFF File Offset: 0x000611FF
		public FVector GetUpVectorAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetUpVectorAtSplineInputKey_Internal(base.NativePtr, InKey, CoordinateSpace);
		}

		// Token: 0x060045F2 RID: 17906 RVA: 0x00063013 File Offset: 0x00061213
		public FVector GetUpVectorAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetUpVectorAtDistanceAlongSpline_Internal(base.NativePtr, Distance, CoordinateSpace);
		}

		// Token: 0x060045F3 RID: 17907 RVA: 0x00063027 File Offset: 0x00061227
		public FTransform GetTransformAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false, bool bUseScale = false)
		{
			return USplineComponent.__GetTransformAtTime_Internal(base.NativePtr, Time, CoordinateSpace, bUseConstantVelocity, bUseScale);
		}

		// Token: 0x060045F4 RID: 17908 RVA: 0x0006303E File Offset: 0x0006123E
		public FTransform GetTransformAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace, bool bUseScale = false)
		{
			return USplineComponent.__GetTransformAtSplinePoint_Internal(base.NativePtr, PointIndex, CoordinateSpace, bUseScale);
		}

		// Token: 0x060045F5 RID: 17909 RVA: 0x00063053 File Offset: 0x00061253
		public FTransform GetTransformAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace, bool bUseScale = false)
		{
			return USplineComponent.__GetTransformAtSplineInputKey_Internal(base.NativePtr, InKey, CoordinateSpace, bUseScale);
		}

		// Token: 0x060045F6 RID: 17910 RVA: 0x00063068 File Offset: 0x00061268
		public FTransform GetTransformAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace, bool bUseScale = false)
		{
			return USplineComponent.__GetTransformAtDistanceAlongSpline_Internal(base.NativePtr, Distance, CoordinateSpace, bUseScale);
		}

		// Token: 0x060045F7 RID: 17911 RVA: 0x0006307D File Offset: 0x0006127D
		public FVector GetTangentAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false)
		{
			return USplineComponent.__GetTangentAtTime_Internal(base.NativePtr, Time, CoordinateSpace, bUseConstantVelocity);
		}

		// Token: 0x060045F8 RID: 17912 RVA: 0x00063092 File Offset: 0x00061292
		public FVector GetTangentAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetTangentAtSplinePoint_Internal(base.NativePtr, PointIndex, CoordinateSpace);
		}

		// Token: 0x060045F9 RID: 17913 RVA: 0x000630A6 File Offset: 0x000612A6
		public FVector GetTangentAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetTangentAtSplineInputKey_Internal(base.NativePtr, InKey, CoordinateSpace);
		}

		// Token: 0x060045FA RID: 17914 RVA: 0x000630BA File Offset: 0x000612BA
		public FVector GetTangentAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetTangentAtDistanceAlongSpline_Internal(base.NativePtr, Distance, CoordinateSpace);
		}

		// Token: 0x060045FB RID: 17915 RVA: 0x000630CE File Offset: 0x000612CE
		public TEnumAsByte<ESplinePointType> GetSplinePointType(int PointIndex)
		{
			return USplineComponent.__GetSplinePointType_Internal(base.NativePtr, PointIndex);
		}

		// Token: 0x060045FC RID: 17916 RVA: 0x000630DC File Offset: 0x000612DC
		public float GetSplineLength()
		{
			return USplineComponent.__GetSplineLength_Internal(base.NativePtr);
		}

		// Token: 0x060045FD RID: 17917 RVA: 0x000630E9 File Offset: 0x000612E9
		public FVector GetScaleAtTime(float Time, bool bUseConstantVelocity = false)
		{
			return USplineComponent.__GetScaleAtTime_Internal(base.NativePtr, Time, bUseConstantVelocity);
		}

		// Token: 0x060045FE RID: 17918 RVA: 0x000630F8 File Offset: 0x000612F8
		public FVector GetScaleAtSplinePoint(int PointIndex)
		{
			return USplineComponent.__GetScaleAtSplinePoint_Internal(base.NativePtr, PointIndex);
		}

		// Token: 0x060045FF RID: 17919 RVA: 0x00063106 File Offset: 0x00061306
		public FVector GetScaleAtSplineInputKey(float InKey)
		{
			return USplineComponent.__GetScaleAtSplineInputKey_Internal(base.NativePtr, InKey);
		}

		// Token: 0x06004600 RID: 17920 RVA: 0x00063114 File Offset: 0x00061314
		public FVector GetScaleAtDistanceAlongSpline(float Distance)
		{
			return USplineComponent.__GetScaleAtDistanceAlongSpline_Internal(base.NativePtr, Distance);
		}

		// Token: 0x06004601 RID: 17921 RVA: 0x00063122 File Offset: 0x00061322
		public FRotator GetRotationAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false)
		{
			return USplineComponent.__GetRotationAtTime_Internal(base.NativePtr, Time, CoordinateSpace, bUseConstantVelocity);
		}

		// Token: 0x06004602 RID: 17922 RVA: 0x00063137 File Offset: 0x00061337
		public FRotator GetRotationAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetRotationAtSplinePoint_Internal(base.NativePtr, PointIndex, CoordinateSpace);
		}

		// Token: 0x06004603 RID: 17923 RVA: 0x0006314B File Offset: 0x0006134B
		public FRotator GetRotationAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetRotationAtSplineInputKey_Internal(base.NativePtr, InKey, CoordinateSpace);
		}

		// Token: 0x06004604 RID: 17924 RVA: 0x0006315F File Offset: 0x0006135F
		public FRotator GetRotationAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetRotationAtDistanceAlongSpline_Internal(base.NativePtr, Distance, CoordinateSpace);
		}

		// Token: 0x06004605 RID: 17925 RVA: 0x00063173 File Offset: 0x00061373
		public float GetRollAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false)
		{
			return USplineComponent.__GetRollAtTime_Internal(base.NativePtr, Time, CoordinateSpace, bUseConstantVelocity);
		}

		// Token: 0x06004606 RID: 17926 RVA: 0x00063188 File Offset: 0x00061388
		public float GetRollAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetRollAtSplinePoint_Internal(base.NativePtr, PointIndex, CoordinateSpace);
		}

		// Token: 0x06004607 RID: 17927 RVA: 0x0006319C File Offset: 0x0006139C
		public float GetRollAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetRollAtSplineInputKey_Internal(base.NativePtr, InKey, CoordinateSpace);
		}

		// Token: 0x06004608 RID: 17928 RVA: 0x000631B0 File Offset: 0x000613B0
		public float GetRollAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetRollAtDistanceAlongSpline_Internal(base.NativePtr, Distance, CoordinateSpace);
		}

		// Token: 0x06004609 RID: 17929 RVA: 0x000631C4 File Offset: 0x000613C4
		public FVector GetRightVectorAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false)
		{
			return USplineComponent.__GetRightVectorAtTime_Internal(base.NativePtr, Time, CoordinateSpace, bUseConstantVelocity);
		}

		// Token: 0x0600460A RID: 17930 RVA: 0x000631D9 File Offset: 0x000613D9
		public FVector GetRightVectorAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetRightVectorAtSplinePoint_Internal(base.NativePtr, PointIndex, CoordinateSpace);
		}

		// Token: 0x0600460B RID: 17931 RVA: 0x000631ED File Offset: 0x000613ED
		public FVector GetRightVectorAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetRightVectorAtSplineInputKey_Internal(base.NativePtr, InKey, CoordinateSpace);
		}

		// Token: 0x0600460C RID: 17932 RVA: 0x00063201 File Offset: 0x00061401
		public FVector GetRightVectorAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetRightVectorAtDistanceAlongSpline_Internal(base.NativePtr, Distance, CoordinateSpace);
		}

		// Token: 0x0600460D RID: 17933 RVA: 0x00063215 File Offset: 0x00061415
		[NullableContext(1)]
		public TArray<FSplinePoint> GetPoints()
		{
			return new TArray<FSplinePoint>(USplineComponent.__GetPoints_Internal(base.NativePtr), null);
		}

		// Token: 0x0600460E RID: 17934 RVA: 0x00063228 File Offset: 0x00061428
		public int GetNumberOfSplineSegments()
		{
			return USplineComponent.__GetNumberOfSplineSegments_Internal(base.NativePtr);
		}

		// Token: 0x0600460F RID: 17935 RVA: 0x00063235 File Offset: 0x00061435
		public int GetNumberOfSplinePoints()
		{
			return USplineComponent.__GetNumberOfSplinePoints_Internal(base.NativePtr);
		}

		// Token: 0x06004610 RID: 17936 RVA: 0x00063242 File Offset: 0x00061442
		public FVector GetLocationAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false)
		{
			return USplineComponent.__GetLocationAtTime_Internal(base.NativePtr, Time, CoordinateSpace, bUseConstantVelocity);
		}

		// Token: 0x06004611 RID: 17937 RVA: 0x00063257 File Offset: 0x00061457
		public FVector GetLocationAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetLocationAtSplinePoint_Internal(base.NativePtr, PointIndex, CoordinateSpace);
		}

		// Token: 0x06004612 RID: 17938 RVA: 0x0006326B File Offset: 0x0006146B
		public FVector GetLocationAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetLocationAtSplineInputKey_Internal(base.NativePtr, InKey, CoordinateSpace);
		}

		// Token: 0x06004613 RID: 17939 RVA: 0x0006327F File Offset: 0x0006147F
		public FVector GetLocationAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetLocationAtDistanceAlongSpline_Internal(base.NativePtr, Distance, CoordinateSpace);
		}

		// Token: 0x06004614 RID: 17940 RVA: 0x00063294 File Offset: 0x00061494
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

		// Token: 0x06004615 RID: 17941 RVA: 0x000632C8 File Offset: 0x000614C8
		public unsafe FVector GetLocationAndKeyAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace, ref float Key)
		{
			fixed (float* ptr = &Key)
			{
				void* ptr2 = (void*)ptr;
				return USplineComponent.__GetLocationAndKeyAtDistanceAlongSpline_Internal(base.NativePtr, Distance, CoordinateSpace, ref Key);
			}
		}

		// Token: 0x06004616 RID: 17942 RVA: 0x000632F0 File Offset: 0x000614F0
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

		// Token: 0x06004617 RID: 17943 RVA: 0x0006331B File Offset: 0x0006151B
		public FVector GetLeaveTangentAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetLeaveTangentAtSplinePoint_Internal(base.NativePtr, PointIndex, CoordinateSpace);
		}

		// Token: 0x06004618 RID: 17944 RVA: 0x0006332F File Offset: 0x0006152F
		public float GetInputKeyAtDistanceAlongSpline(float Distance)
		{
			return USplineComponent.__GetInputKeyAtDistanceAlongSpline_Internal(base.NativePtr, Distance);
		}

		// Token: 0x06004619 RID: 17945 RVA: 0x0006333D File Offset: 0x0006153D
		public float GetFloatPropertyAtSplinePoint(int Index, FName PropertyName)
		{
			return USplineComponent.__GetFloatPropertyAtSplinePoint_Internal(base.NativePtr, Index, PropertyName);
		}

		// Token: 0x0600461A RID: 17946 RVA: 0x0006334C File Offset: 0x0006154C
		public float GetFloatPropertyAtSplineInputKey(float InKey, FName PropertyName)
		{
			return USplineComponent.__GetFloatPropertyAtSplineInputKey_Internal(base.NativePtr, InKey, PropertyName);
		}

		// Token: 0x0600461B RID: 17947 RVA: 0x0006335B File Offset: 0x0006155B
		public float GetDistanceAlongSplineAtSplinePoint(int PointIndex)
		{
			return USplineComponent.__GetDistanceAlongSplineAtSplinePoint_Internal(base.NativePtr, PointIndex);
		}

		// Token: 0x0600461C RID: 17948 RVA: 0x00063369 File Offset: 0x00061569
		public float GetDistanceAlongSplineAtSplineInputKey(float InKey)
		{
			return USplineComponent.__GetDistanceAlongSplineAtSplineInputKey_Internal(base.NativePtr, InKey);
		}

		// Token: 0x0600461D RID: 17949 RVA: 0x00063377 File Offset: 0x00061577
		public FVector GetDirectionAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false)
		{
			return USplineComponent.__GetDirectionAtTime_Internal(base.NativePtr, Time, CoordinateSpace, bUseConstantVelocity);
		}

		// Token: 0x0600461E RID: 17950 RVA: 0x0006338C File Offset: 0x0006158C
		public FVector GetDirectionAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetDirectionAtSplinePoint_Internal(base.NativePtr, PointIndex, CoordinateSpace);
		}

		// Token: 0x0600461F RID: 17951 RVA: 0x000633A0 File Offset: 0x000615A0
		public FVector GetDirectionAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetDirectionAtSplineInputKey_Internal(base.NativePtr, InKey, CoordinateSpace);
		}

		// Token: 0x06004620 RID: 17952 RVA: 0x000633B4 File Offset: 0x000615B4
		public FVector GetDirectionAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetDirectionAtDistanceAlongSpline_Internal(base.NativePtr, Distance, CoordinateSpace);
		}

		// Token: 0x06004621 RID: 17953 RVA: 0x000633C8 File Offset: 0x000615C8
		public FVector GetDefaultUpVector(ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetDefaultUpVector_Internal(base.NativePtr, CoordinateSpace);
		}

		// Token: 0x06004622 RID: 17954 RVA: 0x000633DB File Offset: 0x000615DB
		public FVector GetArriveTangentAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__GetArriveTangentAtSplinePoint_Internal(base.NativePtr, PointIndex, CoordinateSpace);
		}

		// Token: 0x06004623 RID: 17955 RVA: 0x000633EF File Offset: 0x000615EF
		public FVector FindUpVectorClosestToWorldLocation(in FVector WorldLocation, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__FindUpVectorClosestToWorldLocation_Internal(base.NativePtr, WorldLocation, CoordinateSpace);
		}

		// Token: 0x06004624 RID: 17956 RVA: 0x00063403 File Offset: 0x00061603
		public FTransform FindTransformClosestToWorldLocation(in FVector WorldLocation, ESplineCoordinateSpace CoordinateSpace, bool bUseScale = false)
		{
			return USplineComponent.__FindTransformClosestToWorldLocation_Internal(base.NativePtr, WorldLocation, CoordinateSpace, bUseScale);
		}

		// Token: 0x06004625 RID: 17957 RVA: 0x00063418 File Offset: 0x00061618
		public FVector FindTangentClosestToWorldLocation(in FVector WorldLocation, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__FindTangentClosestToWorldLocation_Internal(base.NativePtr, WorldLocation, CoordinateSpace);
		}

		// Token: 0x06004626 RID: 17958 RVA: 0x0006342C File Offset: 0x0006162C
		public FVector FindScaleClosestToWorldLocation(in FVector WorldLocation)
		{
			return USplineComponent.__FindScaleClosestToWorldLocation_Internal(base.NativePtr, WorldLocation);
		}

		// Token: 0x06004627 RID: 17959 RVA: 0x0006343A File Offset: 0x0006163A
		public FRotator FindRotationClosestToWorldLocation(in FVector WorldLocation, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__FindRotationClosestToWorldLocation_Internal(base.NativePtr, WorldLocation, CoordinateSpace);
		}

		// Token: 0x06004628 RID: 17960 RVA: 0x0006344E File Offset: 0x0006164E
		public float FindRollClosestToWorldLocation(in FVector WorldLocation, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__FindRollClosestToWorldLocation_Internal(base.NativePtr, WorldLocation, CoordinateSpace);
		}

		// Token: 0x06004629 RID: 17961 RVA: 0x00063462 File Offset: 0x00061662
		public FVector FindRightVectorClosestToWorldLocation(in FVector WorldLocation, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__FindRightVectorClosestToWorldLocation_Internal(base.NativePtr, WorldLocation, CoordinateSpace);
		}

		// Token: 0x0600462A RID: 17962 RVA: 0x00063476 File Offset: 0x00061676
		public FVector FindLocationClosestToWorldLocation(in FVector WorldLocation, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__FindLocationClosestToWorldLocation_Internal(base.NativePtr, WorldLocation, CoordinateSpace);
		}

		// Token: 0x0600462B RID: 17963 RVA: 0x0006348A File Offset: 0x0006168A
		public float FindInputKeyClosestToWorldLocationInRange(in FVector WorldLocation, int StartKey, int EndKey)
		{
			return USplineComponent.__FindInputKeyClosestToWorldLocationInRange_Internal(base.NativePtr, WorldLocation, StartKey, EndKey);
		}

		// Token: 0x0600462C RID: 17964 RVA: 0x0006349A File Offset: 0x0006169A
		public float FindInputKeyClosestToWorldLocationByPartitionInGravity(in FVector WorldLocation, FVector GravityDirect, float SearchRadius, float HeightLimit)
		{
			return USplineComponent.__FindInputKeyClosestToWorldLocationByPartitionInGravity_Internal(base.NativePtr, WorldLocation, GravityDirect, SearchRadius, HeightLimit);
		}

		// Token: 0x0600462D RID: 17965 RVA: 0x000634AC File Offset: 0x000616AC
		public float FindInputKeyClosestToWorldLocationByPartition(in FVector WorldLocation, float SearchRadius)
		{
			return USplineComponent.__FindInputKeyClosestToWorldLocationByPartition_Internal(base.NativePtr, WorldLocation, SearchRadius);
		}

		// Token: 0x0600462E RID: 17966 RVA: 0x000634BB File Offset: 0x000616BB
		public float FindInputKeyClosestToWorldLocation(in FVector WorldLocation)
		{
			return USplineComponent.__FindInputKeyClosestToWorldLocation_Internal(base.NativePtr, WorldLocation);
		}

		// Token: 0x0600462F RID: 17967 RVA: 0x000634C9 File Offset: 0x000616C9
		public FVector FindDirectionClosestToWorldLocation(in FVector WorldLocation, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__FindDirectionClosestToWorldLocation_Internal(base.NativePtr, WorldLocation, CoordinateSpace);
		}

		// Token: 0x06004630 RID: 17968 RVA: 0x000634DD File Offset: 0x000616DD
		public void D_SetUpVectorAtSplinePoint(int PointIndex, in FVectorDouble InUpVector, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
		{
			USplineComponent.__D_SetUpVectorAtSplinePoint_Internal(base.NativePtr, PointIndex, InUpVector, CoordinateSpace, bUpdateSpline);
		}

		// Token: 0x06004631 RID: 17969 RVA: 0x000634F4 File Offset: 0x000616F4
		public void D_SetTangentsAtSplinePoint(int PointIndex, in FVectorDouble InArriveTangent, in FVectorDouble InLeaveTangent, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
		{
			USplineComponent.__D_SetTangentsAtSplinePoint_Internal(base.NativePtr, PointIndex, InArriveTangent, InLeaveTangent, CoordinateSpace, bUpdateSpline);
		}

		// Token: 0x06004632 RID: 17970 RVA: 0x0006350D File Offset: 0x0006170D
		public void D_SetTangentAtSplinePoint(int PointIndex, in FVectorDouble InTangent, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
		{
			USplineComponent.__D_SetTangentAtSplinePoint_Internal(base.NativePtr, PointIndex, InTangent, CoordinateSpace, bUpdateSpline);
		}

		// Token: 0x06004633 RID: 17971 RVA: 0x00063524 File Offset: 0x00061724
		[NullableContext(2)]
		public void D_SetSplinePoints(in TArray<FVectorDouble> Points, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
		{
			USplineComponent.__D_SetSplinePoints_Internal(base.NativePtr, (Points ?? new TArray<FVectorDouble>()).NativePtr, CoordinateSpace, bUpdateSpline);
		}

		// Token: 0x06004634 RID: 17972 RVA: 0x00063548 File Offset: 0x00061748
		public void D_SetLocationAtSplinePoint(int PointIndex, in FVectorDouble InLocation, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
		{
			USplineComponent.__D_SetLocationAtSplinePoint_Internal(base.NativePtr, PointIndex, InLocation, CoordinateSpace, bUpdateSpline);
		}

		// Token: 0x06004635 RID: 17973 RVA: 0x0006355F File Offset: 0x0006175F
		public void D_SetDefaultUpVector(in FVectorDouble UpVector, ESplineCoordinateSpace CoordinateSpace)
		{
			USplineComponent.__D_SetDefaultUpVector_Internal(base.NativePtr, UpVector, CoordinateSpace);
		}

		// Token: 0x06004636 RID: 17974 RVA: 0x00063573 File Offset: 0x00061773
		public FVectorDouble D_GetVectorPropertyAtSplinePoint(int Index, FName PropertyName)
		{
			return USplineComponent.__D_GetVectorPropertyAtSplinePoint_Internal(base.NativePtr, Index, PropertyName);
		}

		// Token: 0x06004637 RID: 17975 RVA: 0x00063582 File Offset: 0x00061782
		public FVectorDouble D_GetVectorPropertyAtSplineInputKey(float InKey, FName PropertyName)
		{
			return USplineComponent.__D_GetVectorPropertyAtSplineInputKey_Internal(base.NativePtr, InKey, PropertyName);
		}

		// Token: 0x06004638 RID: 17976 RVA: 0x00063591 File Offset: 0x00061791
		public FVectorDouble D_GetUpVectorAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false)
		{
			return USplineComponent.__D_GetUpVectorAtTime_Internal(base.NativePtr, Time, CoordinateSpace, bUseConstantVelocity);
		}

		// Token: 0x06004639 RID: 17977 RVA: 0x000635A6 File Offset: 0x000617A6
		public FVectorDouble D_GetUpVectorAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_GetUpVectorAtSplinePoint_Internal(base.NativePtr, PointIndex, CoordinateSpace);
		}

		// Token: 0x0600463A RID: 17978 RVA: 0x000635BA File Offset: 0x000617BA
		public FVectorDouble D_GetUpVectorAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_GetUpVectorAtSplineInputKey_Internal(base.NativePtr, InKey, CoordinateSpace);
		}

		// Token: 0x0600463B RID: 17979 RVA: 0x000635CE File Offset: 0x000617CE
		public FVectorDouble D_GetUpVectorAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_GetUpVectorAtDistanceAlongSpline_Internal(base.NativePtr, Distance, CoordinateSpace);
		}

		// Token: 0x0600463C RID: 17980 RVA: 0x000635E2 File Offset: 0x000617E2
		public FTransformDouble D_GetTransformAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false, bool bUseScale = false)
		{
			return USplineComponent.__D_GetTransformAtTime_Internal(base.NativePtr, Time, CoordinateSpace, bUseConstantVelocity, bUseScale);
		}

		// Token: 0x0600463D RID: 17981 RVA: 0x000635F9 File Offset: 0x000617F9
		public FTransformDouble D_GetTransformAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace, bool bUseScale = false)
		{
			return USplineComponent.__D_GetTransformAtSplinePoint_Internal(base.NativePtr, PointIndex, CoordinateSpace, bUseScale);
		}

		// Token: 0x0600463E RID: 17982 RVA: 0x0006360E File Offset: 0x0006180E
		public FTransformDouble D_GetTransformAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace, bool bUseScale = false)
		{
			return USplineComponent.__D_GetTransformAtSplineInputKey_Internal(base.NativePtr, InKey, CoordinateSpace, bUseScale);
		}

		// Token: 0x0600463F RID: 17983 RVA: 0x00063623 File Offset: 0x00061823
		public FTransformDouble D_GetTransformAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace, bool bUseScale = false)
		{
			return USplineComponent.__D_GetTransformAtDistanceAlongSpline_Internal(base.NativePtr, Distance, CoordinateSpace, bUseScale);
		}

		// Token: 0x06004640 RID: 17984 RVA: 0x00063638 File Offset: 0x00061838
		public FVectorDouble D_GetTangentAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false)
		{
			return USplineComponent.__D_GetTangentAtTime_Internal(base.NativePtr, Time, CoordinateSpace, bUseConstantVelocity);
		}

		// Token: 0x06004641 RID: 17985 RVA: 0x0006364D File Offset: 0x0006184D
		public FVectorDouble D_GetTangentAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_GetTangentAtSplinePoint_Internal(base.NativePtr, PointIndex, CoordinateSpace);
		}

		// Token: 0x06004642 RID: 17986 RVA: 0x00063661 File Offset: 0x00061861
		public FVectorDouble D_GetTangentAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_GetTangentAtSplineInputKey_Internal(base.NativePtr, InKey, CoordinateSpace);
		}

		// Token: 0x06004643 RID: 17987 RVA: 0x00063675 File Offset: 0x00061875
		public FVectorDouble D_GetTangentAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_GetTangentAtDistanceAlongSpline_Internal(base.NativePtr, Distance, CoordinateSpace);
		}

		// Token: 0x06004644 RID: 17988 RVA: 0x00063689 File Offset: 0x00061889
		public FVectorDouble D_GetScaleAtDistanceAlongSpline(float Distance)
		{
			return USplineComponent.__D_GetScaleAtDistanceAlongSpline_Internal(base.NativePtr, Distance);
		}

		// Token: 0x06004645 RID: 17989 RVA: 0x00063697 File Offset: 0x00061897
		public FVectorDouble D_GetRightVectorAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false)
		{
			return USplineComponent.__D_GetRightVectorAtTime_Internal(base.NativePtr, Time, CoordinateSpace, bUseConstantVelocity);
		}

		// Token: 0x06004646 RID: 17990 RVA: 0x000636AC File Offset: 0x000618AC
		public FVectorDouble D_GetRightVectorAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_GetRightVectorAtSplinePoint_Internal(base.NativePtr, PointIndex, CoordinateSpace);
		}

		// Token: 0x06004647 RID: 17991 RVA: 0x000636C0 File Offset: 0x000618C0
		public FVectorDouble D_GetRightVectorAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_GetRightVectorAtSplineInputKey_Internal(base.NativePtr, InKey, CoordinateSpace);
		}

		// Token: 0x06004648 RID: 17992 RVA: 0x000636D4 File Offset: 0x000618D4
		public FVectorDouble D_GetRightVectorAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_GetRightVectorAtDistanceAlongSpline_Internal(base.NativePtr, Distance, CoordinateSpace);
		}

		// Token: 0x06004649 RID: 17993 RVA: 0x000636E8 File Offset: 0x000618E8
		public FVectorDouble D_GetLocationAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false)
		{
			return USplineComponent.__D_GetLocationAtTime_Internal(base.NativePtr, Time, CoordinateSpace, bUseConstantVelocity);
		}

		// Token: 0x0600464A RID: 17994 RVA: 0x000636FD File Offset: 0x000618FD
		public FVectorDouble D_GetLocationAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_GetLocationAtSplinePoint_Internal(base.NativePtr, PointIndex, CoordinateSpace);
		}

		// Token: 0x0600464B RID: 17995 RVA: 0x00063711 File Offset: 0x00061911
		public FVectorDouble D_GetLocationAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_GetLocationAtSplineInputKey_Internal(base.NativePtr, InKey, CoordinateSpace);
		}

		// Token: 0x0600464C RID: 17996 RVA: 0x00063725 File Offset: 0x00061925
		public FVectorDouble D_GetLocationAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_GetLocationAtDistanceAlongSpline_Internal(base.NativePtr, Distance, CoordinateSpace);
		}

		// Token: 0x0600464D RID: 17997 RVA: 0x0006373C File Offset: 0x0006193C
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

		// Token: 0x0600464E RID: 17998 RVA: 0x00063770 File Offset: 0x00061970
		public unsafe FVectorDouble D_GetLocationAndKeyAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace, ref float Key)
		{
			fixed (float* ptr = &Key)
			{
				void* ptr2 = (void*)ptr;
				return USplineComponent.__D_GetLocationAndKeyAtDistanceAlongSpline_Internal(base.NativePtr, Distance, CoordinateSpace, ref Key);
			}
		}

		// Token: 0x0600464F RID: 17999 RVA: 0x00063795 File Offset: 0x00061995
		public FVectorDouble D_GetLeaveTangentAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_GetLeaveTangentAtSplinePoint_Internal(base.NativePtr, PointIndex, CoordinateSpace);
		}

		// Token: 0x06004650 RID: 18000 RVA: 0x000637A9 File Offset: 0x000619A9
		public FVectorDouble D_GetDirectionAtTime(float Time, ESplineCoordinateSpace CoordinateSpace, bool bUseConstantVelocity = false)
		{
			return USplineComponent.__D_GetDirectionAtTime_Internal(base.NativePtr, Time, CoordinateSpace, bUseConstantVelocity);
		}

		// Token: 0x06004651 RID: 18001 RVA: 0x000637BE File Offset: 0x000619BE
		public FVectorDouble D_GetDirectionAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_GetDirectionAtSplinePoint_Internal(base.NativePtr, PointIndex, CoordinateSpace);
		}

		// Token: 0x06004652 RID: 18002 RVA: 0x000637D2 File Offset: 0x000619D2
		public FVectorDouble D_GetDirectionAtSplineInputKey(float InKey, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_GetDirectionAtSplineInputKey_Internal(base.NativePtr, InKey, CoordinateSpace);
		}

		// Token: 0x06004653 RID: 18003 RVA: 0x000637E6 File Offset: 0x000619E6
		public FVectorDouble D_GetDirectionAtDistanceAlongSpline(float Distance, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_GetDirectionAtDistanceAlongSpline_Internal(base.NativePtr, Distance, CoordinateSpace);
		}

		// Token: 0x06004654 RID: 18004 RVA: 0x000637FA File Offset: 0x000619FA
		public FVectorDouble D_GetDefaultUpVector(ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_GetDefaultUpVector_Internal(base.NativePtr, CoordinateSpace);
		}

		// Token: 0x06004655 RID: 18005 RVA: 0x0006380D File Offset: 0x00061A0D
		public FVectorDouble D_GetArriveTangentAtSplinePoint(int PointIndex, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_GetArriveTangentAtSplinePoint_Internal(base.NativePtr, PointIndex, CoordinateSpace);
		}

		// Token: 0x06004656 RID: 18006 RVA: 0x00063821 File Offset: 0x00061A21
		public FVectorDouble D_FindUpVectorClosestToWorldLocation(in FVectorDouble WorldLocation, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_FindUpVectorClosestToWorldLocation_Internal(base.NativePtr, WorldLocation, CoordinateSpace);
		}

		// Token: 0x06004657 RID: 18007 RVA: 0x00063835 File Offset: 0x00061A35
		public FTransformDouble D_FindTransformClosestToWorldLocation(in FVectorDouble WorldLocation, ESplineCoordinateSpace CoordinateSpace, bool bUseScale = false)
		{
			return USplineComponent.__D_FindTransformClosestToWorldLocation_Internal(base.NativePtr, WorldLocation, CoordinateSpace, bUseScale);
		}

		// Token: 0x06004658 RID: 18008 RVA: 0x0006384A File Offset: 0x00061A4A
		public FVectorDouble D_FindTangentClosestToWorldLocation(in FVectorDouble WorldLocation, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_FindTangentClosestToWorldLocation_Internal(base.NativePtr, WorldLocation, CoordinateSpace);
		}

		// Token: 0x06004659 RID: 18009 RVA: 0x0006385E File Offset: 0x00061A5E
		public FVectorDouble D_FindRightVectorClosestToWorldLocation(in FVectorDouble WorldLocation, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_FindRightVectorClosestToWorldLocation_Internal(base.NativePtr, WorldLocation, CoordinateSpace);
		}

		// Token: 0x0600465A RID: 18010 RVA: 0x00063872 File Offset: 0x00061A72
		public FVectorDouble D_FindLocationClosestToWorldLocation(in FVectorDouble WorldLocation, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_FindLocationClosestToWorldLocation_Internal(base.NativePtr, WorldLocation, CoordinateSpace);
		}

		// Token: 0x0600465B RID: 18011 RVA: 0x00063886 File Offset: 0x00061A86
		public float D_FindInputKeyClosestToWorldLocationInRange(in FVectorDouble WorldLocation, int StartKey, int EndKey)
		{
			return USplineComponent.__D_FindInputKeyClosestToWorldLocationInRange_Internal(base.NativePtr, WorldLocation, StartKey, EndKey);
		}

		// Token: 0x0600465C RID: 18012 RVA: 0x00063896 File Offset: 0x00061A96
		public float D_FindInputKeyClosestToWorldLocationInGravity(in FVectorDouble WorldLocation, FVector GravityDirect, float HeightLimit)
		{
			return USplineComponent.__D_FindInputKeyClosestToWorldLocationInGravity_Internal(base.NativePtr, WorldLocation, GravityDirect, HeightLimit);
		}

		// Token: 0x0600465D RID: 18013 RVA: 0x000638A6 File Offset: 0x00061AA6
		public float D_FindInputKeyClosestToWorldLocationByPartitionInGravity(in FVectorDouble WorldLocation, FVector GravityDirect, float SearchRadius, float HeightLimit)
		{
			return USplineComponent.__D_FindInputKeyClosestToWorldLocationByPartitionInGravity_Internal(base.NativePtr, WorldLocation, GravityDirect, SearchRadius, HeightLimit);
		}

		// Token: 0x0600465E RID: 18014 RVA: 0x000638B8 File Offset: 0x00061AB8
		public float D_FindInputKeyClosestToWorldLocationByPartition(in FVectorDouble WorldLocation, float SearchRadius)
		{
			return USplineComponent.__D_FindInputKeyClosestToWorldLocationByPartition_Internal(base.NativePtr, WorldLocation, SearchRadius);
		}

		// Token: 0x0600465F RID: 18015 RVA: 0x000638C7 File Offset: 0x00061AC7
		public float D_FindInputKeyClosestToWorldLocation(in FVectorDouble WorldLocation)
		{
			return USplineComponent.__D_FindInputKeyClosestToWorldLocation_Internal(base.NativePtr, WorldLocation);
		}

		// Token: 0x06004660 RID: 18016 RVA: 0x000638D5 File Offset: 0x00061AD5
		public FVectorDouble D_FindDirectionClosestToWorldLocation(in FVectorDouble WorldLocation, ESplineCoordinateSpace CoordinateSpace)
		{
			return USplineComponent.__D_FindDirectionClosestToWorldLocation_Internal(base.NativePtr, WorldLocation, CoordinateSpace);
		}

		// Token: 0x06004661 RID: 18017 RVA: 0x000638E9 File Offset: 0x00061AE9
		public void D_AddSplinePointAtIndex(in FVectorDouble Position, int Index, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
		{
			USplineComponent.__D_AddSplinePointAtIndex_Internal(base.NativePtr, Position, Index, CoordinateSpace, bUpdateSpline);
		}

		// Token: 0x06004662 RID: 18018 RVA: 0x00063900 File Offset: 0x00061B00
		public void D_AddSplinePoint(in FVectorDouble Position, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
		{
			USplineComponent.__D_AddSplinePoint_Internal(base.NativePtr, Position, CoordinateSpace, bUpdateSpline);
		}

		// Token: 0x06004663 RID: 18019 RVA: 0x00063915 File Offset: 0x00061B15
		public void ClearSplinePoints(bool bUpdateSpline = true)
		{
			USplineComponent.__ClearSplinePoints_Internal(base.NativePtr, bUpdateSpline);
		}

		// Token: 0x06004664 RID: 18020 RVA: 0x00063923 File Offset: 0x00061B23
		public void AddSplineWorldPoint(in FVector Position)
		{
			USplineComponent.__AddSplineWorldPoint_Internal(base.NativePtr, Position);
		}

		// Token: 0x06004665 RID: 18021 RVA: 0x00063931 File Offset: 0x00061B31
		public void AddSplinePointAtIndex(in FVector Position, int Index, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
		{
			USplineComponent.__AddSplinePointAtIndex_Internal(base.NativePtr, Position, Index, CoordinateSpace, bUpdateSpline);
		}

		// Token: 0x06004666 RID: 18022 RVA: 0x00063948 File Offset: 0x00061B48
		public void AddSplinePoint(in FVector Position, ESplineCoordinateSpace CoordinateSpace, bool bUpdateSpline = true)
		{
			USplineComponent.__AddSplinePoint_Internal(base.NativePtr, Position, CoordinateSpace, bUpdateSpline);
		}

		// Token: 0x06004667 RID: 18023 RVA: 0x0006395D File Offset: 0x00061B5D
		public void AddSplineLocalPoint(in FVector Position)
		{
			USplineComponent.__AddSplineLocalPoint_Internal(base.NativePtr, Position);
		}

		// Token: 0x06004668 RID: 18024 RVA: 0x0006396B File Offset: 0x00061B6B
		public void AddPoints([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FSplinePoint> Points, bool bUpdateSpline = true)
		{
			USplineComponent.__AddPoints_Internal(base.NativePtr, (Points ?? new TArray<FSplinePoint>()).NativePtr, bUpdateSpline);
		}

		// Token: 0x06004669 RID: 18025 RVA: 0x00063989 File Offset: 0x00061B89
		[NullableContext(2)]
		public void AddPoint(in FSplinePoint Point, bool bUpdateSpline = true)
		{
			USplineComponent.__AddPoint_Internal(base.NativePtr, (Point ?? new FSplinePoint()).NativePtr, bUpdateSpline);
		}

		// Token: 0x0600466A RID: 18026
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateSpline_Internal(IntPtr @this);

		// Token: 0x0600466B RID: 18027
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWorldLocationAtSplinePoint_Internal(IntPtr @this, int PointIndex, in FVector InLocation);

		// Token: 0x0600466C RID: 18028
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUpVectorAtSplinePoint_Internal(IntPtr @this, int PointIndex, in FVector InUpVector, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUpdateSpline);

		// Token: 0x0600466D RID: 18029
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUnselectedSplineSegmentColor_Internal(IntPtr @this, in FLinearColor SegmentColor);

		// Token: 0x0600466E RID: 18030
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTangentsAtSplinePoint_Internal(IntPtr @this, int PointIndex, in FVector InArriveTangent, in FVector InLeaveTangent, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUpdateSpline);

		// Token: 0x0600466F RID: 18031
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTangentColor_Internal(IntPtr @this, in FLinearColor TangentColor);

		// Token: 0x06004670 RID: 18032
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTangentAtSplinePoint_Internal(IntPtr @this, int PointIndex, in FVector InTangent, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUpdateSpline);

		// Token: 0x06004671 RID: 18033
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSplineWorldPoints_Internal(IntPtr @this, IntPtr Points);

		// Token: 0x06004672 RID: 18034
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSplinePointType_Internal(IntPtr @this, int PointIndex, TEnumAsByte<ESplinePointType> Type, bool bUpdateSpline);

		// Token: 0x06004673 RID: 18035
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSplinePoints_Internal(IntPtr @this, IntPtr Points, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUpdateSpline);

		// Token: 0x06004674 RID: 18036
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSplineLocalPoints_Internal(IntPtr @this, IntPtr Points);

		// Token: 0x06004675 RID: 18037
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSelectedSplineSegmentColor_Internal(IntPtr @this, in FLinearColor SegmentColor);

		// Token: 0x06004676 RID: 18038
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetScaleAtSplinePoint_Internal(IntPtr @this, int PointIndex, in FVector InScaleVector, bool bUpdateSpline);

		// Token: 0x06004677 RID: 18039
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRotationAtSplinePoint_Internal(IntPtr @this, int PointIndex, in FRotator InRotation, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUpdateSpline);

		// Token: 0x06004678 RID: 18040
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLocationAtSplinePoint_Internal(IntPtr @this, int PointIndex, in FVector InLocation, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUpdateSpline);

		// Token: 0x06004679 RID: 18041
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDrawDebug_Internal(IntPtr @this, bool bShow);

		// Token: 0x0600467A RID: 18042
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDefaultUpVector_Internal(IntPtr @this, in FVector UpVector, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x0600467B RID: 18043
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetClosedLoopAtPosition_Internal(IntPtr @this, bool bInClosedLoop, float Key, bool bUpdateSpline);

		// Token: 0x0600467C RID: 18044
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetClosedLoop_Internal(IntPtr @this, bool bInClosedLoop, bool bUpdateSpline);

		// Token: 0x0600467D RID: 18045
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveSplinePoint_Internal(IntPtr @this, int Index, bool bUpdateSpline);

		// Token: 0x0600467E RID: 18046
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsClosedLoop_Internal(IntPtr @this);

		// Token: 0x0600467F RID: 18047
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetWorldTangentAtDistanceAlongSpline_Internal(IntPtr @this, float Distance);

		// Token: 0x06004680 RID: 18048
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __GetWorldRotationAtTime_Internal(IntPtr @this, float Time, bool bUseConstantVelocity);

		// Token: 0x06004681 RID: 18049
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __GetWorldRotationAtDistanceAlongSpline_Internal(IntPtr @this, float Distance);

		// Token: 0x06004682 RID: 18050
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetWorldLocationAtTime_Internal(IntPtr @this, float Time, bool bUseConstantVelocity);

		// Token: 0x06004683 RID: 18051
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetWorldLocationAtSplinePoint_Internal(IntPtr @this, int PointIndex);

		// Token: 0x06004684 RID: 18052
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetWorldLocationAtDistanceAlongSpline_Internal(IntPtr @this, float Distance);

		// Token: 0x06004685 RID: 18053
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetWorldDirectionAtTime_Internal(IntPtr @this, float Time, bool bUseConstantVelocity);

		// Token: 0x06004686 RID: 18054
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetWorldDirectionAtDistanceAlongSpline_Internal(IntPtr @this, float Distance);

		// Token: 0x06004687 RID: 18055
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetVectorPropertyAtSplinePoint_Internal(IntPtr @this, int Index, FName PropertyName);

		// Token: 0x06004688 RID: 18056
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetVectorPropertyAtSplineInputKey_Internal(IntPtr @this, float InKey, FName PropertyName);

		// Token: 0x06004689 RID: 18057
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetUpVectorAtTime_Internal(IntPtr @this, float Time, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseConstantVelocity);

		// Token: 0x0600468A RID: 18058
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetUpVectorAtSplinePoint_Internal(IntPtr @this, int PointIndex, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x0600468B RID: 18059
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetUpVectorAtSplineInputKey_Internal(IntPtr @this, float InKey, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x0600468C RID: 18060
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetUpVectorAtDistanceAlongSpline_Internal(IntPtr @this, float Distance, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x0600468D RID: 18061
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetTransformAtTime_Internal(IntPtr @this, float Time, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseConstantVelocity, bool bUseScale);

		// Token: 0x0600468E RID: 18062
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetTransformAtSplinePoint_Internal(IntPtr @this, int PointIndex, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseScale);

		// Token: 0x0600468F RID: 18063
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetTransformAtSplineInputKey_Internal(IntPtr @this, float InKey, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseScale);

		// Token: 0x06004690 RID: 18064
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetTransformAtDistanceAlongSpline_Internal(IntPtr @this, float Distance, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseScale);

		// Token: 0x06004691 RID: 18065
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetTangentAtTime_Internal(IntPtr @this, float Time, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseConstantVelocity);

		// Token: 0x06004692 RID: 18066
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetTangentAtSplinePoint_Internal(IntPtr @this, int PointIndex, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x06004693 RID: 18067
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetTangentAtSplineInputKey_Internal(IntPtr @this, float InKey, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x06004694 RID: 18068
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetTangentAtDistanceAlongSpline_Internal(IntPtr @this, float Distance, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x06004695 RID: 18069
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<ESplinePointType> __GetSplinePointType_Internal(IntPtr @this, int PointIndex);

		// Token: 0x06004696 RID: 18070
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetSplineLength_Internal(IntPtr @this);

		// Token: 0x06004697 RID: 18071
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetScaleAtTime_Internal(IntPtr @this, float Time, bool bUseConstantVelocity);

		// Token: 0x06004698 RID: 18072
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetScaleAtSplinePoint_Internal(IntPtr @this, int PointIndex);

		// Token: 0x06004699 RID: 18073
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetScaleAtSplineInputKey_Internal(IntPtr @this, float InKey);

		// Token: 0x0600469A RID: 18074
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetScaleAtDistanceAlongSpline_Internal(IntPtr @this, float Distance);

		// Token: 0x0600469B RID: 18075
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __GetRotationAtTime_Internal(IntPtr @this, float Time, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseConstantVelocity);

		// Token: 0x0600469C RID: 18076
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __GetRotationAtSplinePoint_Internal(IntPtr @this, int PointIndex, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x0600469D RID: 18077
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __GetRotationAtSplineInputKey_Internal(IntPtr @this, float InKey, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x0600469E RID: 18078
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __GetRotationAtDistanceAlongSpline_Internal(IntPtr @this, float Distance, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x0600469F RID: 18079
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRollAtTime_Internal(IntPtr @this, float Time, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseConstantVelocity);

		// Token: 0x060046A0 RID: 18080
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRollAtSplinePoint_Internal(IntPtr @this, int PointIndex, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046A1 RID: 18081
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRollAtSplineInputKey_Internal(IntPtr @this, float InKey, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046A2 RID: 18082
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRollAtDistanceAlongSpline_Internal(IntPtr @this, float Distance, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046A3 RID: 18083
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetRightVectorAtTime_Internal(IntPtr @this, float Time, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseConstantVelocity);

		// Token: 0x060046A4 RID: 18084
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetRightVectorAtSplinePoint_Internal(IntPtr @this, int PointIndex, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046A5 RID: 18085
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetRightVectorAtSplineInputKey_Internal(IntPtr @this, float InKey, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046A6 RID: 18086
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetRightVectorAtDistanceAlongSpline_Internal(IntPtr @this, float Distance, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046A7 RID: 18087
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPoints_Internal(IntPtr @this);

		// Token: 0x060046A8 RID: 18088
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumberOfSplineSegments_Internal(IntPtr @this);

		// Token: 0x060046A9 RID: 18089
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumberOfSplinePoints_Internal(IntPtr @this);

		// Token: 0x060046AA RID: 18090
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetLocationAtTime_Internal(IntPtr @this, float Time, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseConstantVelocity);

		// Token: 0x060046AB RID: 18091
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetLocationAtSplinePoint_Internal(IntPtr @this, int PointIndex, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046AC RID: 18092
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetLocationAtSplineInputKey_Internal(IntPtr @this, float InKey, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046AD RID: 18093
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetLocationAtDistanceAlongSpline_Internal(IntPtr @this, float Distance, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046AE RID: 18094
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetLocationAndTangentAtSplinePoint_Internal(IntPtr @this, int PointIndex, ref FVector Location, ref FVector Tangent, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046AF RID: 18095
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetLocationAndKeyAtDistanceAlongSpline_Internal(IntPtr @this, float Distance, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, ref float Key);

		// Token: 0x060046B0 RID: 18096
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetLocalLocationAndTangentAtSplinePoint_Internal(IntPtr @this, int PointIndex, ref FVector LocalLocation, ref FVector LocalTangent);

		// Token: 0x060046B1 RID: 18097
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetLeaveTangentAtSplinePoint_Internal(IntPtr @this, int PointIndex, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046B2 RID: 18098
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetInputKeyAtDistanceAlongSpline_Internal(IntPtr @this, float Distance);

		// Token: 0x060046B3 RID: 18099
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetFloatPropertyAtSplinePoint_Internal(IntPtr @this, int Index, FName PropertyName);

		// Token: 0x060046B4 RID: 18100
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetFloatPropertyAtSplineInputKey_Internal(IntPtr @this, float InKey, FName PropertyName);

		// Token: 0x060046B5 RID: 18101
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetDistanceAlongSplineAtSplinePoint_Internal(IntPtr @this, int PointIndex);

		// Token: 0x060046B6 RID: 18102
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetDistanceAlongSplineAtSplineInputKey_Internal(IntPtr @this, float InKey);

		// Token: 0x060046B7 RID: 18103
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetDirectionAtTime_Internal(IntPtr @this, float Time, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseConstantVelocity);

		// Token: 0x060046B8 RID: 18104
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetDirectionAtSplinePoint_Internal(IntPtr @this, int PointIndex, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046B9 RID: 18105
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetDirectionAtSplineInputKey_Internal(IntPtr @this, float InKey, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046BA RID: 18106
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetDirectionAtDistanceAlongSpline_Internal(IntPtr @this, float Distance, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046BB RID: 18107
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetDefaultUpVector_Internal(IntPtr @this, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046BC RID: 18108
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetArriveTangentAtSplinePoint_Internal(IntPtr @this, int PointIndex, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046BD RID: 18109
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __FindUpVectorClosestToWorldLocation_Internal(IntPtr @this, in FVector WorldLocation, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046BE RID: 18110
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __FindTransformClosestToWorldLocation_Internal(IntPtr @this, in FVector WorldLocation, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseScale);

		// Token: 0x060046BF RID: 18111
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __FindTangentClosestToWorldLocation_Internal(IntPtr @this, in FVector WorldLocation, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046C0 RID: 18112
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __FindScaleClosestToWorldLocation_Internal(IntPtr @this, in FVector WorldLocation);

		// Token: 0x060046C1 RID: 18113
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __FindRotationClosestToWorldLocation_Internal(IntPtr @this, in FVector WorldLocation, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046C2 RID: 18114
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __FindRollClosestToWorldLocation_Internal(IntPtr @this, in FVector WorldLocation, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046C3 RID: 18115
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __FindRightVectorClosestToWorldLocation_Internal(IntPtr @this, in FVector WorldLocation, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046C4 RID: 18116
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __FindLocationClosestToWorldLocation_Internal(IntPtr @this, in FVector WorldLocation, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046C5 RID: 18117
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __FindInputKeyClosestToWorldLocationInRange_Internal(IntPtr @this, in FVector WorldLocation, int StartKey, int EndKey);

		// Token: 0x060046C6 RID: 18118
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __FindInputKeyClosestToWorldLocationByPartitionInGravity_Internal(IntPtr @this, in FVector WorldLocation, FVector GravityDirect, float SearchRadius, float HeightLimit);

		// Token: 0x060046C7 RID: 18119
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __FindInputKeyClosestToWorldLocationByPartition_Internal(IntPtr @this, in FVector WorldLocation, float SearchRadius);

		// Token: 0x060046C8 RID: 18120
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __FindInputKeyClosestToWorldLocation_Internal(IntPtr @this, in FVector WorldLocation);

		// Token: 0x060046C9 RID: 18121
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __FindDirectionClosestToWorldLocation_Internal(IntPtr @this, in FVector WorldLocation, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046CA RID: 18122
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_SetUpVectorAtSplinePoint_Internal(IntPtr @this, int PointIndex, in FVectorDouble InUpVector, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUpdateSpline);

		// Token: 0x060046CB RID: 18123
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_SetTangentsAtSplinePoint_Internal(IntPtr @this, int PointIndex, in FVectorDouble InArriveTangent, in FVectorDouble InLeaveTangent, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUpdateSpline);

		// Token: 0x060046CC RID: 18124
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_SetTangentAtSplinePoint_Internal(IntPtr @this, int PointIndex, in FVectorDouble InTangent, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUpdateSpline);

		// Token: 0x060046CD RID: 18125
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_SetSplinePoints_Internal(IntPtr @this, IntPtr Points, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUpdateSpline);

		// Token: 0x060046CE RID: 18126
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_SetLocationAtSplinePoint_Internal(IntPtr @this, int PointIndex, in FVectorDouble InLocation, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUpdateSpline);

		// Token: 0x060046CF RID: 18127
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_SetDefaultUpVector_Internal(IntPtr @this, in FVectorDouble UpVector, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046D0 RID: 18128
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetVectorPropertyAtSplinePoint_Internal(IntPtr @this, int Index, FName PropertyName);

		// Token: 0x060046D1 RID: 18129
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetVectorPropertyAtSplineInputKey_Internal(IntPtr @this, float InKey, FName PropertyName);

		// Token: 0x060046D2 RID: 18130
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetUpVectorAtTime_Internal(IntPtr @this, float Time, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseConstantVelocity);

		// Token: 0x060046D3 RID: 18131
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetUpVectorAtSplinePoint_Internal(IntPtr @this, int PointIndex, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046D4 RID: 18132
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetUpVectorAtSplineInputKey_Internal(IntPtr @this, float InKey, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046D5 RID: 18133
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetUpVectorAtDistanceAlongSpline_Internal(IntPtr @this, float Distance, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046D6 RID: 18134
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble __D_GetTransformAtTime_Internal(IntPtr @this, float Time, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseConstantVelocity, bool bUseScale);

		// Token: 0x060046D7 RID: 18135
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble __D_GetTransformAtSplinePoint_Internal(IntPtr @this, int PointIndex, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseScale);

		// Token: 0x060046D8 RID: 18136
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble __D_GetTransformAtSplineInputKey_Internal(IntPtr @this, float InKey, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseScale);

		// Token: 0x060046D9 RID: 18137
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble __D_GetTransformAtDistanceAlongSpline_Internal(IntPtr @this, float Distance, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseScale);

		// Token: 0x060046DA RID: 18138
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetTangentAtTime_Internal(IntPtr @this, float Time, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseConstantVelocity);

		// Token: 0x060046DB RID: 18139
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetTangentAtSplinePoint_Internal(IntPtr @this, int PointIndex, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046DC RID: 18140
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetTangentAtSplineInputKey_Internal(IntPtr @this, float InKey, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046DD RID: 18141
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetTangentAtDistanceAlongSpline_Internal(IntPtr @this, float Distance, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046DE RID: 18142
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetScaleAtDistanceAlongSpline_Internal(IntPtr @this, float Distance);

		// Token: 0x060046DF RID: 18143
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetRightVectorAtTime_Internal(IntPtr @this, float Time, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseConstantVelocity);

		// Token: 0x060046E0 RID: 18144
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetRightVectorAtSplinePoint_Internal(IntPtr @this, int PointIndex, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046E1 RID: 18145
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetRightVectorAtSplineInputKey_Internal(IntPtr @this, float InKey, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046E2 RID: 18146
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetRightVectorAtDistanceAlongSpline_Internal(IntPtr @this, float Distance, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046E3 RID: 18147
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetLocationAtTime_Internal(IntPtr @this, float Time, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseConstantVelocity);

		// Token: 0x060046E4 RID: 18148
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetLocationAtSplinePoint_Internal(IntPtr @this, int PointIndex, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046E5 RID: 18149
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetLocationAtSplineInputKey_Internal(IntPtr @this, float InKey, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046E6 RID: 18150
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetLocationAtDistanceAlongSpline_Internal(IntPtr @this, float Distance, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046E7 RID: 18151
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_GetLocationAndTangentAtSplinePoint_Internal(IntPtr @this, int PointIndex, ref FVectorDouble Location, ref FVectorDouble Tangent, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046E8 RID: 18152
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetLocationAndKeyAtDistanceAlongSpline_Internal(IntPtr @this, float Distance, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, ref float Key);

		// Token: 0x060046E9 RID: 18153
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetLeaveTangentAtSplinePoint_Internal(IntPtr @this, int PointIndex, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046EA RID: 18154
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetDirectionAtTime_Internal(IntPtr @this, float Time, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseConstantVelocity);

		// Token: 0x060046EB RID: 18155
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetDirectionAtSplinePoint_Internal(IntPtr @this, int PointIndex, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046EC RID: 18156
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetDirectionAtSplineInputKey_Internal(IntPtr @this, float InKey, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046ED RID: 18157
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetDirectionAtDistanceAlongSpline_Internal(IntPtr @this, float Distance, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046EE RID: 18158
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetDefaultUpVector_Internal(IntPtr @this, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046EF RID: 18159
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetArriveTangentAtSplinePoint_Internal(IntPtr @this, int PointIndex, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046F0 RID: 18160
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_FindUpVectorClosestToWorldLocation_Internal(IntPtr @this, in FVectorDouble WorldLocation, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046F1 RID: 18161
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble __D_FindTransformClosestToWorldLocation_Internal(IntPtr @this, in FVectorDouble WorldLocation, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUseScale);

		// Token: 0x060046F2 RID: 18162
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_FindTangentClosestToWorldLocation_Internal(IntPtr @this, in FVectorDouble WorldLocation, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046F3 RID: 18163
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_FindRightVectorClosestToWorldLocation_Internal(IntPtr @this, in FVectorDouble WorldLocation, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046F4 RID: 18164
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_FindLocationClosestToWorldLocation_Internal(IntPtr @this, in FVectorDouble WorldLocation, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046F5 RID: 18165
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __D_FindInputKeyClosestToWorldLocationInRange_Internal(IntPtr @this, in FVectorDouble WorldLocation, int StartKey, int EndKey);

		// Token: 0x060046F6 RID: 18166
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __D_FindInputKeyClosestToWorldLocationInGravity_Internal(IntPtr @this, in FVectorDouble WorldLocation, FVector GravityDirect, float HeightLimit);

		// Token: 0x060046F7 RID: 18167
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __D_FindInputKeyClosestToWorldLocationByPartitionInGravity_Internal(IntPtr @this, in FVectorDouble WorldLocation, FVector GravityDirect, float SearchRadius, float HeightLimit);

		// Token: 0x060046F8 RID: 18168
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __D_FindInputKeyClosestToWorldLocationByPartition_Internal(IntPtr @this, in FVectorDouble WorldLocation, float SearchRadius);

		// Token: 0x060046F9 RID: 18169
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __D_FindInputKeyClosestToWorldLocation_Internal(IntPtr @this, in FVectorDouble WorldLocation);

		// Token: 0x060046FA RID: 18170
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_FindDirectionClosestToWorldLocation_Internal(IntPtr @this, in FVectorDouble WorldLocation, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace);

		// Token: 0x060046FB RID: 18171
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_AddSplinePointAtIndex_Internal(IntPtr @this, in FVectorDouble Position, int Index, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUpdateSpline);

		// Token: 0x060046FC RID: 18172
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_AddSplinePoint_Internal(IntPtr @this, in FVectorDouble Position, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUpdateSpline);

		// Token: 0x060046FD RID: 18173
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearSplinePoints_Internal(IntPtr @this, bool bUpdateSpline);

		// Token: 0x060046FE RID: 18174
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddSplineWorldPoint_Internal(IntPtr @this, in FVector Position);

		// Token: 0x060046FF RID: 18175
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddSplinePointAtIndex_Internal(IntPtr @this, in FVector Position, int Index, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUpdateSpline);

		// Token: 0x06004700 RID: 18176
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddSplinePoint_Internal(IntPtr @this, in FVector Position, TEnumAsByte<ESplineCoordinateSpace> CoordinateSpace, bool bUpdateSpline);

		// Token: 0x06004701 RID: 18177
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddSplineLocalPoint_Internal(IntPtr @this, in FVector Position);

		// Token: 0x06004702 RID: 18178
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddPoints_Internal(IntPtr @this, IntPtr Points, bool bUpdateSpline);

		// Token: 0x06004703 RID: 18179
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddPoint_Internal(IntPtr @this, IntPtr Point, bool bUpdateSpline);

		// Token: 0x06004704 RID: 18180 RVA: 0x000639A7 File Offset: 0x00061BA7
		static USplineComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SplineComponent");
		}

		// Token: 0x06004705 RID: 18181 RVA: 0x000639B5 File Offset: 0x00061BB5
		protected USplineComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001B42 RID: 6978
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SplineComponent";

		// Token: 0x04001B43 RID: 6979
		private static IntPtr _ClassPtr;

		// Token: 0x04001B44 RID: 6980
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001B45 RID: 6981
		internal static int __PropertyOffset_SplineCurves;

		// Token: 0x04001B46 RID: 6982
		[Nullable(2)]
		private FSplineCurves _SplineCurves;

		// Token: 0x04001B47 RID: 6983
		internal static int __PropertyOffset_SplineInfo_DEPRECATED;

		// Token: 0x04001B48 RID: 6984
		[Nullable(2)]
		private FInterpCurveVector _SplineInfo_DEPRECATED;

		// Token: 0x04001B49 RID: 6985
		internal static int __PropertyOffset_SplineRotInfo_DEPRECATED;

		// Token: 0x04001B4A RID: 6986
		[Nullable(2)]
		private FInterpCurveQuat _SplineRotInfo_DEPRECATED;

		// Token: 0x04001B4B RID: 6987
		internal static int __PropertyOffset_SplineScaleInfo_DEPRECATED;

		// Token: 0x04001B4C RID: 6988
		[Nullable(2)]
		private FInterpCurveVector _SplineScaleInfo_DEPRECATED;

		// Token: 0x04001B4D RID: 6989
		internal static int __PropertyOffset_SplineReparamTable_DEPRECATED;

		// Token: 0x04001B4E RID: 6990
		[Nullable(2)]
		private FInterpCurveFloat _SplineReparamTable_DEPRECATED;

		// Token: 0x04001B4F RID: 6991
		internal static int __PropertyOffset_bAllowSplineEditingPerInstance_DEPRECATED;

		// Token: 0x04001B50 RID: 6992
		internal static int __PropertyOffset_ReparamStepsPerSegment;

		// Token: 0x04001B51 RID: 6993
		internal static int __PropertyOffset_Duration;

		// Token: 0x04001B52 RID: 6994
		internal static int __PropertyOffset_bStationaryEndpoints;

		// Token: 0x04001B53 RID: 6995
		internal static int __PropertyOffset_bSplineHasBeenEdited;

		// Token: 0x04001B54 RID: 6996
		internal static int __PropertyOffset_bModifiedByConstructionScript;

		// Token: 0x04001B55 RID: 6997
		internal static int __PropertyOffset_bInputSplinePointsToConstructionScript;

		// Token: 0x04001B56 RID: 6998
		internal static int __PropertyOffset_bDrawDebug;

		// Token: 0x04001B57 RID: 6999
		internal static int __PropertyOffset_bClosedLoop;

		// Token: 0x04001B58 RID: 7000
		internal static int __PropertyOffset_bLoopPositionOverride;

		// Token: 0x04001B59 RID: 7001
		internal static int __PropertyOffset_LoopPosition;

		// Token: 0x04001B5A RID: 7002
		internal static int __PropertyOffset_DefaultUpVector;
	}
}
