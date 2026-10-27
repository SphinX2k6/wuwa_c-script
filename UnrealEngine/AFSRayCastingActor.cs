using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A95 RID: 6805
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.FSRayCastingActor")]
	[UnrealStructLayout(1544, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1544)]
	public class AFSRayCastingActor : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601919A RID: 102810 RVA: 0x00250F12 File Offset: 0x0024F112
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AFSRayCastingActor._ClassPtr;
		}

		// Token: 0x0601919B RID: 102811 RVA: 0x00250F20 File Offset: 0x0024F120
		public AFSRayCastingActor() : this(BuiltinUtils.AllocNativeUObject(AFSRayCastingActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601919C RID: 102812 RVA: 0x00250F48 File Offset: 0x0024F148
		[NullableContext(1)]
		public AFSRayCastingActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AFSRayCastingActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170063B5 RID: 25525
		// (get) Token: 0x0601919D RID: 102813 RVA: 0x00250F7B File Offset: 0x0024F17B
		// (set) Token: 0x0601919E RID: 102814 RVA: 0x00250F8B File Offset: 0x0024F18B
		public unsafe bool bUseAsyncTrace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFSRayCastingActor.__PropertyOffset_bUseAsyncTrace) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFSRayCastingActor.__PropertyOffset_bUseAsyncTrace) = (value ? 1 : 0);
			}
		}

		// Token: 0x170063B6 RID: 25526
		// (get) Token: 0x0601919F RID: 102815 RVA: 0x00250F9C File Offset: 0x0024F19C
		// (set) Token: 0x060191A0 RID: 102816 RVA: 0x00250FAC File Offset: 0x0024F1AC
		public unsafe bool bDebugAsyncStats
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFSRayCastingActor.__PropertyOffset_bDebugAsyncStats) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFSRayCastingActor.__PropertyOffset_bDebugAsyncStats) = (value ? 1 : 0);
			}
		}

		// Token: 0x060191A1 RID: 102817 RVA: 0x00250FC0 File Offset: 0x0024F1C0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static double P_FS_PointToIndex_Local_Double(USceneComponent PlaneComponent, int N)
		{
			AFSRayCastingActor.__P_FS_PointToIndex_Local_Double_FunctionParams* ptr = stackalloc AFSRayCastingActor.__P_FS_PointToIndex_Local_Double_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(AFSRayCastingActor.__P_FS_PointToIndex_Local_Double_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AFSRayCastingActor.__P_FS_PointToIndex_Local_Double_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlaneComponent = ((PlaneComponent != null) ? PlaneComponent.NativePtr : IntPtr.Zero);
			ptr->N = N;
			UnrealReflectionUtils.CallUFunction(AFSRayCastingActor._ClassDefaultObjectPtr, AFSRayCastingActor.__P_FS_PointToIndex_Local_Double_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060191A2 RID: 102818 RVA: 0x00251024 File Offset: 0x0024F224
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool P_FS_IsPointInTriangle_ZProjection_With_EPS(in FVector P, in FVector A, in FVector B, in FVector C, float EPS, ref float OutDistance, float Epsilon = 1E-06f)
		{
			AFSRayCastingActor.__P_FS_IsPointInTriangle_ZProjection_With_EPS_FunctionParams* ptr = stackalloc AFSRayCastingActor.__P_FS_IsPointInTriangle_ZProjection_With_EPS_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(AFSRayCastingActor.__P_FS_IsPointInTriangle_ZProjection_With_EPS_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AFSRayCastingActor.__P_FS_IsPointInTriangle_ZProjection_With_EPS_NativeFunctionPtr, (void*)ptr, 1);
			ptr->P = P;
			ptr->A = A;
			ptr->B = B;
			ptr->C = C;
			ptr->EPS = EPS;
			ptr->OutDistance = OutDistance;
			ptr->Epsilon = Epsilon;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AFSRayCastingActor.__P_FS_IsPointInTriangle_ZProjection_With_EPS_NativeFunctionPtr, (void*)ptr, 0);
			OutDistance = ptr->OutDistance;
			return ptr->__Result;
		}

		// Token: 0x060191A3 RID: 102819 RVA: 0x002510C0 File Offset: 0x0024F2C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool P_FS_IsPointInTriangle_ZProjection(in FVector P, in FVector A, in FVector B, in FVector C, ref float OutDistance, float Epsilon = 1E-06f)
		{
			AFSRayCastingActor.__P_FS_IsPointInTriangle_ZProjection_FunctionParams* ptr = stackalloc AFSRayCastingActor.__P_FS_IsPointInTriangle_ZProjection_FunctionParams[(UIntPtr)75] + 15L / (long)sizeof(AFSRayCastingActor.__P_FS_IsPointInTriangle_ZProjection_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AFSRayCastingActor.__P_FS_IsPointInTriangle_ZProjection_NativeFunctionPtr, (void*)ptr, 1);
			ptr->P = P;
			ptr->A = A;
			ptr->B = B;
			ptr->C = C;
			ptr->OutDistance = OutDistance;
			ptr->Epsilon = Epsilon;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AFSRayCastingActor.__P_FS_IsPointInTriangle_ZProjection_NativeFunctionPtr, (void*)ptr, 0);
			OutDistance = ptr->OutDistance;
			return ptr->__Result;
		}

		// Token: 0x060191A4 RID: 102820 RVA: 0x00251154 File Offset: 0x0024F354
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool P_FS_IsPlayerOutOfRayCastingRange2D(USceneComponent PlaneComponent, float InRayCastingDetectDis, bool UseDetectOutofRange)
		{
			AFSRayCastingActor.__P_FS_IsPlayerOutOfRayCastingRange2D_FunctionParams* ptr = stackalloc AFSRayCastingActor.__P_FS_IsPlayerOutOfRayCastingRange2D_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(AFSRayCastingActor.__P_FS_IsPlayerOutOfRayCastingRange2D_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AFSRayCastingActor.__P_FS_IsPlayerOutOfRayCastingRange2D_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlaneComponent = ((PlaneComponent != null) ? PlaneComponent.NativePtr : IntPtr.Zero);
			ptr->InRayCastingDetectDis = InRayCastingDetectDis;
			ptr->UseDetectOutofRange = UseDetectOutofRange;
			UnrealReflectionUtils.CallUFunction(AFSRayCastingActor._ClassDefaultObjectPtr, AFSRayCastingActor.__P_FS_IsPlayerOutOfRayCastingRange2D_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060191A5 RID: 102821 RVA: 0x002511C0 File Offset: 0x0024F3C0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void P_FS_InitializeArrays(USceneComponent PlaneComponent, float RayCastingDetectDis, ref TArray<FVector> Dir, ref TArray<FVector> EndPos, ref TArray<float> Dis, int ParticleCount)
		{
			AFSRayCastingActor.__P_FS_InitializeArrays_FunctionParams* ptr = stackalloc AFSRayCastingActor.__P_FS_InitializeArrays_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(AFSRayCastingActor.__P_FS_InitializeArrays_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AFSRayCastingActor.__P_FS_InitializeArrays_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlaneComponent = ((PlaneComponent != null) ? PlaneComponent.NativePtr : IntPtr.Zero);
			ptr->RayCastingDetectDis = RayCastingDetectDis;
			TArray<FVector> tarray = Dir;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Dir);
			}
			TArray<FVector> tarray2 = EndPos;
			if (tarray2 != null)
			{
				tarray2.MoveTo(&ptr->EndPos);
			}
			TArray<float> tarray3 = Dis;
			if (tarray3 != null)
			{
				tarray3.MoveTo(&ptr->Dis);
			}
			ptr->ParticleCount = ParticleCount;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AFSRayCastingActor.__P_FS_InitializeArrays_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FVector> tarray4 = Dir;
			if (tarray4 != null)
			{
				tarray4.MoveAssign(&ptr->Dir);
			}
			TArray<FVector> tarray5 = EndPos;
			if (tarray5 != null)
			{
				tarray5.MoveAssign(&ptr->EndPos);
			}
			TArray<float> tarray6 = Dis;
			if (tarray6 != null)
			{
				tarray6.MoveAssign(&ptr->Dis);
			}
			UnrealReflectionUtils.DestroyStruct(AFSRayCastingActor.__P_FS_InitializeArrays_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060191A6 RID: 102822 RVA: 0x002512B4 File Offset: 0x0024F4B4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool P_FS_DetectPlayer_Two_With_EPS(USceneComponent PlaneComponent, double Index, int ParticleCount, in TArray<float> Dis, in TArray<FVector> Dirs, float eps, ref float OutDistance)
		{
			AFSRayCastingActor.__P_FS_DetectPlayer_Two_With_EPS_FunctionParams* ptr = stackalloc AFSRayCastingActor.__P_FS_DetectPlayer_Two_With_EPS_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(AFSRayCastingActor.__P_FS_DetectPlayer_Two_With_EPS_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AFSRayCastingActor.__P_FS_DetectPlayer_Two_With_EPS_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlaneComponent = ((PlaneComponent != null) ? PlaneComponent.NativePtr : IntPtr.Zero);
			ptr->Index = Index;
			ptr->ParticleCount = ParticleCount;
			TArray<float> tarray = Dis;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Dis);
			}
			TArray<FVector> tarray2 = Dirs;
			if (tarray2 != null)
			{
				tarray2.MoveTo(&ptr->Dirs);
			}
			ptr->eps = eps;
			ptr->OutDistance = OutDistance;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AFSRayCastingActor.__P_FS_DetectPlayer_Two_With_EPS_NativeFunctionPtr, (void*)ptr, 0);
			TArray<float> tarray3 = Dis;
			if (tarray3 != null)
			{
				tarray3.MoveAssign(&ptr->Dis);
			}
			TArray<FVector> tarray4 = Dirs;
			if (tarray4 != null)
			{
				tarray4.MoveAssign(&ptr->Dirs);
			}
			OutDistance = ptr->OutDistance;
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(AFSRayCastingActor.__P_FS_DetectPlayer_Two_With_EPS_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x060191A7 RID: 102823 RVA: 0x002513A0 File Offset: 0x0024F5A0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool P_FS_DetectPlayer_Two(USceneComponent PlaneComponent, double Index, int ParticleCount, in TArray<float> Dis, in TArray<FVector> Dirs, ref float OutDistance)
		{
			AFSRayCastingActor.__P_FS_DetectPlayer_Two_FunctionParams* ptr = stackalloc AFSRayCastingActor.__P_FS_DetectPlayer_Two_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(AFSRayCastingActor.__P_FS_DetectPlayer_Two_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AFSRayCastingActor.__P_FS_DetectPlayer_Two_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlaneComponent = ((PlaneComponent != null) ? PlaneComponent.NativePtr : IntPtr.Zero);
			ptr->Index = Index;
			ptr->ParticleCount = ParticleCount;
			TArray<float> tarray = Dis;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Dis);
			}
			TArray<FVector> tarray2 = Dirs;
			if (tarray2 != null)
			{
				tarray2.MoveTo(&ptr->Dirs);
			}
			ptr->OutDistance = OutDistance;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AFSRayCastingActor.__P_FS_DetectPlayer_Two_NativeFunctionPtr, (void*)ptr, 0);
			TArray<float> tarray3 = Dis;
			if (tarray3 != null)
			{
				tarray3.MoveAssign(&ptr->Dis);
			}
			TArray<FVector> tarray4 = Dirs;
			if (tarray4 != null)
			{
				tarray4.MoveAssign(&ptr->Dirs);
			}
			OutDistance = ptr->OutDistance;
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(AFSRayCastingActor.__P_FS_DetectPlayer_Two_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x060191A8 RID: 102824 RVA: 0x00251484 File Offset: 0x0024F684
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static FRotator P_FS_ComputeTilt_ByHeightH2(ref FVectorDouble LastFrameNormal, USceneComponent PlaneComponent, float RayCastingDetectRange, double MaxDegreeAngle, float MinActiveRadius, float MaxActiveRadius, double FollowSpeedRate, double ReturnSpeedRate, bool bPlayerColliding, bool bLinear, ref bool OutDebugBlockReturn, float ReturnBlockVerticalLimit = 80f, float ReturnBlockSwitchThreshold = 80f)
		{
			AFSRayCastingActor.__P_FS_ComputeTilt_ByHeightH2_FunctionParams* ptr = stackalloc AFSRayCastingActor.__P_FS_ComputeTilt_ByHeightH2_FunctionParams[(UIntPtr)111] + 15L / (long)sizeof(AFSRayCastingActor.__P_FS_ComputeTilt_ByHeightH2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AFSRayCastingActor.__P_FS_ComputeTilt_ByHeightH2_NativeFunctionPtr, (void*)ptr, 1);
			ptr->LastFrameNormal = LastFrameNormal;
			ptr->PlaneComponent = ((PlaneComponent != null) ? PlaneComponent.NativePtr : IntPtr.Zero);
			ptr->RayCastingDetectRange = RayCastingDetectRange;
			ptr->MaxDegreeAngle = MaxDegreeAngle;
			ptr->MinActiveRadius = MinActiveRadius;
			ptr->MaxActiveRadius = MaxActiveRadius;
			ptr->FollowSpeedRate = FollowSpeedRate;
			ptr->ReturnSpeedRate = ReturnSpeedRate;
			ptr->bPlayerColliding = bPlayerColliding;
			ptr->bLinear = bLinear;
			ptr->OutDebugBlockReturn = OutDebugBlockReturn;
			ptr->ReturnBlockVerticalLimit = ReturnBlockVerticalLimit;
			ptr->ReturnBlockSwitchThreshold = ReturnBlockSwitchThreshold;
			UnrealReflectionUtils.CallUFunction(AFSRayCastingActor._ClassDefaultObjectPtr, AFSRayCastingActor.__P_FS_ComputeTilt_ByHeightH2_NativeFunctionPtr, (void*)ptr, 0);
			LastFrameNormal = ptr->LastFrameNormal;
			OutDebugBlockReturn = ptr->OutDebugBlockReturn;
			return ptr->__Result;
		}

		// Token: 0x060191A9 RID: 102825 RVA: 0x00251558 File Offset: 0x0024F758
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void P_FS_CheckFrontObstacle2_VertexBuffer(USceneComponent PlaneComponent, float RayCastingDetectDis, UObject WorldContextObject, ETraceTypeQuery TraceChannel, ref float OutDistance, ref TArray<FVector> Dir, ref TArray<FVector> EndPos, ref TArray<float> Dis, bool debugLine, int CountIndex, int BatchSize, int ParticleCount, ref int OutNewCountIndex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, bool doNotNeedRayCasting, bool isBeginPlayOrNot, in TArray<FVector> SkipTraceBoxOrigins, in TArray<FVector> SkipTraceBoxExtents, ref int OutAsyncReadBack)
		{
			AFSRayCastingActor.__P_FS_CheckFrontObstacle2_VertexBuffer_FunctionParams* ptr = stackalloc AFSRayCastingActor.__P_FS_CheckFrontObstacle2_VertexBuffer_FunctionParams[(UIntPtr)183] + 15L / (long)sizeof(AFSRayCastingActor.__P_FS_CheckFrontObstacle2_VertexBuffer_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AFSRayCastingActor.__P_FS_CheckFrontObstacle2_VertexBuffer_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlaneComponent = ((PlaneComponent != null) ? PlaneComponent.NativePtr : IntPtr.Zero);
			ptr->RayCastingDetectDis = RayCastingDetectDis;
			ptr->WorldContextObject = ((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
			ptr->TraceChannel = TraceChannel;
			ptr->OutDistance = OutDistance;
			TArray<FVector> tarray = Dir;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Dir);
			}
			TArray<FVector> tarray2 = EndPos;
			if (tarray2 != null)
			{
				tarray2.MoveTo(&ptr->EndPos);
			}
			TArray<float> tarray3 = Dis;
			if (tarray3 != null)
			{
				tarray3.MoveTo(&ptr->Dis);
			}
			ptr->debugLine = debugLine;
			ptr->CountIndex = CountIndex;
			ptr->BatchSize = BatchSize;
			ptr->ParticleCount = ParticleCount;
			ptr->OutNewCountIndex = OutNewCountIndex;
			TArray<AActor> tarray4 = ActorsToIgnore;
			if (tarray4 != null)
			{
				tarray4.MoveTo(&ptr->ActorsToIgnore);
			}
			ptr->doNotNeedRayCasting = doNotNeedRayCasting;
			ptr->isBeginPlayOrNot = isBeginPlayOrNot;
			TArray<FVector> tarray5 = SkipTraceBoxOrigins;
			if (tarray5 != null)
			{
				tarray5.MoveTo(&ptr->SkipTraceBoxOrigins);
			}
			TArray<FVector> tarray6 = SkipTraceBoxExtents;
			if (tarray6 != null)
			{
				tarray6.MoveTo(&ptr->SkipTraceBoxExtents);
			}
			ptr->OutAsyncReadBack = OutAsyncReadBack;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AFSRayCastingActor.__P_FS_CheckFrontObstacle2_VertexBuffer_NativeFunctionPtr, (void*)ptr, 0);
			OutDistance = ptr->OutDistance;
			TArray<FVector> tarray7 = Dir;
			if (tarray7 != null)
			{
				tarray7.MoveAssign(&ptr->Dir);
			}
			TArray<FVector> tarray8 = EndPos;
			if (tarray8 != null)
			{
				tarray8.MoveAssign(&ptr->EndPos);
			}
			TArray<float> tarray9 = Dis;
			if (tarray9 != null)
			{
				tarray9.MoveAssign(&ptr->Dis);
			}
			OutNewCountIndex = ptr->OutNewCountIndex;
			TArray<AActor> tarray10 = ActorsToIgnore;
			if (tarray10 != null)
			{
				tarray10.MoveAssign(&ptr->ActorsToIgnore);
			}
			TArray<FVector> tarray11 = SkipTraceBoxOrigins;
			if (tarray11 != null)
			{
				tarray11.MoveAssign(&ptr->SkipTraceBoxOrigins);
			}
			TArray<FVector> tarray12 = SkipTraceBoxExtents;
			if (tarray12 != null)
			{
				tarray12.MoveAssign(&ptr->SkipTraceBoxExtents);
			}
			OutAsyncReadBack = ptr->OutAsyncReadBack;
			UnrealReflectionUtils.DestroyStruct(AFSRayCastingActor.__P_FS_CheckFrontObstacle2_VertexBuffer_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060191AA RID: 102826 RVA: 0x00251750 File Offset: 0x0024F950
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void P_FS_CheckFrontObstacle2_Shuffled(USceneComponent PlaneComponent, float RayCastingDetectDis, UObject WorldContextObject, ETraceTypeQuery TraceChannel, ref float OutDistance, ref TArray<FVector> Dir, ref TArray<FVector> EndPos, ref TArray<float> Dis, ref TArray<FName> ParamNames, UMaterialInstanceDynamic MID, bool debugLine, int CountIndex, int BatchSize, int ParticleCount, ref int OutNewCountIndex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, ref TArray<int> ShuffleOrder, ref FRandomStream Rng, bool bReshuffleWhenWrap)
		{
			AFSRayCastingActor.__P_FS_CheckFrontObstacle2_Shuffled_FunctionParams* ptr = stackalloc AFSRayCastingActor.__P_FS_CheckFrontObstacle2_Shuffled_FunctionParams[(UIntPtr)191] + 15L / (long)sizeof(AFSRayCastingActor.__P_FS_CheckFrontObstacle2_Shuffled_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AFSRayCastingActor.__P_FS_CheckFrontObstacle2_Shuffled_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlaneComponent = ((PlaneComponent != null) ? PlaneComponent.NativePtr : IntPtr.Zero);
			ptr->RayCastingDetectDis = RayCastingDetectDis;
			ptr->WorldContextObject = ((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
			ptr->TraceChannel = TraceChannel;
			ptr->OutDistance = OutDistance;
			TArray<FVector> tarray = Dir;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Dir);
			}
			TArray<FVector> tarray2 = EndPos;
			if (tarray2 != null)
			{
				tarray2.MoveTo(&ptr->EndPos);
			}
			TArray<float> tarray3 = Dis;
			if (tarray3 != null)
			{
				tarray3.MoveTo(&ptr->Dis);
			}
			TArray<FName> tarray4 = ParamNames;
			if (tarray4 != null)
			{
				tarray4.MoveTo(&ptr->ParamNames);
			}
			ptr->MID = ((MID != null) ? MID.NativePtr : IntPtr.Zero);
			ptr->debugLine = debugLine;
			ptr->CountIndex = CountIndex;
			ptr->BatchSize = BatchSize;
			ptr->ParticleCount = ParticleCount;
			ptr->OutNewCountIndex = OutNewCountIndex;
			TArray<AActor> tarray5 = ActorsToIgnore;
			if (tarray5 != null)
			{
				tarray5.MoveTo(&ptr->ActorsToIgnore);
			}
			TArray<int> tarray6 = ShuffleOrder;
			if (tarray6 != null)
			{
				tarray6.MoveTo(&ptr->ShuffleOrder);
			}
			ptr->Rng = Rng;
			ptr->bReshuffleWhenWrap = bReshuffleWhenWrap;
			UnrealReflectionUtils.CallUFunction(AFSRayCastingActor._ClassDefaultObjectPtr, AFSRayCastingActor.__P_FS_CheckFrontObstacle2_Shuffled_NativeFunctionPtr, (void*)ptr, 0);
			OutDistance = ptr->OutDistance;
			TArray<FVector> tarray7 = Dir;
			if (tarray7 != null)
			{
				tarray7.MoveAssign(&ptr->Dir);
			}
			TArray<FVector> tarray8 = EndPos;
			if (tarray8 != null)
			{
				tarray8.MoveAssign(&ptr->EndPos);
			}
			TArray<float> tarray9 = Dis;
			if (tarray9 != null)
			{
				tarray9.MoveAssign(&ptr->Dis);
			}
			TArray<FName> tarray10 = ParamNames;
			if (tarray10 != null)
			{
				tarray10.MoveAssign(&ptr->ParamNames);
			}
			OutNewCountIndex = ptr->OutNewCountIndex;
			TArray<AActor> tarray11 = ActorsToIgnore;
			if (tarray11 != null)
			{
				tarray11.MoveAssign(&ptr->ActorsToIgnore);
			}
			TArray<int> tarray12 = ShuffleOrder;
			if (tarray12 != null)
			{
				tarray12.MoveAssign(&ptr->ShuffleOrder);
			}
			Rng = ptr->Rng;
			UnrealReflectionUtils.DestroyStruct(AFSRayCastingActor.__P_FS_CheckFrontObstacle2_Shuffled_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060191AB RID: 102827 RVA: 0x0025195C File Offset: 0x0024FB5C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void P_FS_CheckFrontObstacle2(USceneComponent PlaneComponent, float RayCastingDetectDis, UObject WorldContextObject, ETraceTypeQuery TraceChannel, ref float OutDistance, ref TArray<FVector> Dir, ref TArray<FVector> EndPos, ref TArray<float> Dis, ref TArray<FName> ParamNames, UMaterialInstanceDynamic MID, bool debugLine, int CountIndex, int BatchSize, int ParticleCount, ref int OutNewCountIndex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore)
		{
			AFSRayCastingActor.__P_FS_CheckFrontObstacle2_FunctionParams* ptr = stackalloc AFSRayCastingActor.__P_FS_CheckFrontObstacle2_FunctionParams[(UIntPtr)159] + 15L / (long)sizeof(AFSRayCastingActor.__P_FS_CheckFrontObstacle2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AFSRayCastingActor.__P_FS_CheckFrontObstacle2_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlaneComponent = ((PlaneComponent != null) ? PlaneComponent.NativePtr : IntPtr.Zero);
			ptr->RayCastingDetectDis = RayCastingDetectDis;
			ptr->WorldContextObject = ((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
			ptr->TraceChannel = TraceChannel;
			ptr->OutDistance = OutDistance;
			TArray<FVector> tarray = Dir;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Dir);
			}
			TArray<FVector> tarray2 = EndPos;
			if (tarray2 != null)
			{
				tarray2.MoveTo(&ptr->EndPos);
			}
			TArray<float> tarray3 = Dis;
			if (tarray3 != null)
			{
				tarray3.MoveTo(&ptr->Dis);
			}
			TArray<FName> tarray4 = ParamNames;
			if (tarray4 != null)
			{
				tarray4.MoveTo(&ptr->ParamNames);
			}
			ptr->MID = ((MID != null) ? MID.NativePtr : IntPtr.Zero);
			ptr->debugLine = debugLine;
			ptr->CountIndex = CountIndex;
			ptr->BatchSize = BatchSize;
			ptr->ParticleCount = ParticleCount;
			ptr->OutNewCountIndex = OutNewCountIndex;
			TArray<AActor> tarray5 = ActorsToIgnore;
			if (tarray5 != null)
			{
				tarray5.MoveTo(&ptr->ActorsToIgnore);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AFSRayCastingActor.__P_FS_CheckFrontObstacle2_NativeFunctionPtr, (void*)ptr, 0);
			OutDistance = ptr->OutDistance;
			TArray<FVector> tarray6 = Dir;
			if (tarray6 != null)
			{
				tarray6.MoveAssign(&ptr->Dir);
			}
			TArray<FVector> tarray7 = EndPos;
			if (tarray7 != null)
			{
				tarray7.MoveAssign(&ptr->EndPos);
			}
			TArray<float> tarray8 = Dis;
			if (tarray8 != null)
			{
				tarray8.MoveAssign(&ptr->Dis);
			}
			TArray<FName> tarray9 = ParamNames;
			if (tarray9 != null)
			{
				tarray9.MoveAssign(&ptr->ParamNames);
			}
			OutNewCountIndex = ptr->OutNewCountIndex;
			TArray<AActor> tarray10 = ActorsToIgnore;
			if (tarray10 != null)
			{
				tarray10.MoveAssign(&ptr->ActorsToIgnore);
			}
			UnrealReflectionUtils.DestroyStruct(AFSRayCastingActor.__P_FS_CheckFrontObstacle2_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060191AC RID: 102828 RVA: 0x00251B1E File Offset: 0x0024FD1E
		static AFSRayCastingActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.FSRayCastingActor");
		}

		// Token: 0x060191AD RID: 102829 RVA: 0x00251B2C File Offset: 0x0024FD2C
		protected AFSRayCastingActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DAD8 RID: 56024
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.FSRayCastingActor";

		// Token: 0x0400DAD9 RID: 56025
		private static IntPtr _ClassPtr;

		// Token: 0x0400DADA RID: 56026
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400DADB RID: 56027
		internal static int __PropertyOffset_bUseAsyncTrace;

		// Token: 0x0400DADC RID: 56028
		internal static int __PropertyOffset_bDebugAsyncStats;

		// Token: 0x0400DADD RID: 56029
		private static IntPtr __P_FS_PointToIndex_Local_Double_NativeFunctionPtr;

		// Token: 0x0400DADE RID: 56030
		private static IntPtr __P_FS_IsPointInTriangle_ZProjection_With_EPS_NativeFunctionPtr;

		// Token: 0x0400DADF RID: 56031
		private static IntPtr __P_FS_IsPointInTriangle_ZProjection_NativeFunctionPtr;

		// Token: 0x0400DAE0 RID: 56032
		private static IntPtr __P_FS_IsPlayerOutOfRayCastingRange2D_NativeFunctionPtr;

		// Token: 0x0400DAE1 RID: 56033
		private static IntPtr __P_FS_InitializeArrays_NativeFunctionPtr;

		// Token: 0x0400DAE2 RID: 56034
		private static IntPtr __P_FS_DetectPlayer_Two_With_EPS_NativeFunctionPtr;

		// Token: 0x0400DAE3 RID: 56035
		private static IntPtr __P_FS_DetectPlayer_Two_NativeFunctionPtr;

		// Token: 0x0400DAE4 RID: 56036
		private static IntPtr __P_FS_ComputeTilt_ByHeightH2_NativeFunctionPtr;

		// Token: 0x0400DAE5 RID: 56037
		private static IntPtr __P_FS_CheckFrontObstacle2_VertexBuffer_NativeFunctionPtr;

		// Token: 0x0400DAE6 RID: 56038
		private static IntPtr __P_FS_CheckFrontObstacle2_Shuffled_NativeFunctionPtr;

		// Token: 0x0400DAE7 RID: 56039
		private static IntPtr __P_FS_CheckFrontObstacle2_NativeFunctionPtr;

		// Token: 0x02003119 RID: 12569
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __P_FS_PointToIndex_Local_Double_FunctionParams
		{
			// Token: 0x04016EAF RID: 93871
			[FieldOffset(0)]
			public IntPtr PlaneComponent;

			// Token: 0x04016EB0 RID: 93872
			[FieldOffset(8)]
			public int N;

			// Token: 0x04016EB1 RID: 93873
			[FieldOffset(16)]
			public double __Result;
		}

		// Token: 0x0200311A RID: 12570
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __P_FS_IsPointInTriangle_ZProjection_With_EPS_FunctionParams
		{
			// Token: 0x04016EB2 RID: 93874
			[FieldOffset(0)]
			public FVector P;

			// Token: 0x04016EB3 RID: 93875
			[FieldOffset(12)]
			public FVector A;

			// Token: 0x04016EB4 RID: 93876
			[FieldOffset(24)]
			public FVector B;

			// Token: 0x04016EB5 RID: 93877
			[FieldOffset(36)]
			public FVector C;

			// Token: 0x04016EB6 RID: 93878
			[FieldOffset(48)]
			public float EPS;

			// Token: 0x04016EB7 RID: 93879
			[FieldOffset(52)]
			public float OutDistance;

			// Token: 0x04016EB8 RID: 93880
			[FieldOffset(56)]
			public float Epsilon;

			// Token: 0x04016EB9 RID: 93881
			[FieldOffset(60)]
			public bool __Result;
		}

		// Token: 0x0200311B RID: 12571
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 60)]
		protected ref struct __P_FS_IsPointInTriangle_ZProjection_FunctionParams
		{
			// Token: 0x04016EBA RID: 93882
			[FieldOffset(0)]
			public FVector P;

			// Token: 0x04016EBB RID: 93883
			[FieldOffset(12)]
			public FVector A;

			// Token: 0x04016EBC RID: 93884
			[FieldOffset(24)]
			public FVector B;

			// Token: 0x04016EBD RID: 93885
			[FieldOffset(36)]
			public FVector C;

			// Token: 0x04016EBE RID: 93886
			[FieldOffset(48)]
			public float OutDistance;

			// Token: 0x04016EBF RID: 93887
			[FieldOffset(52)]
			public float Epsilon;

			// Token: 0x04016EC0 RID: 93888
			[FieldOffset(56)]
			public bool __Result;
		}

		// Token: 0x0200311C RID: 12572
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __P_FS_IsPlayerOutOfRayCastingRange2D_FunctionParams
		{
			// Token: 0x04016EC1 RID: 93889
			[FieldOffset(0)]
			public IntPtr PlaneComponent;

			// Token: 0x04016EC2 RID: 93890
			[FieldOffset(8)]
			public float InRayCastingDetectDis;

			// Token: 0x04016EC3 RID: 93891
			[FieldOffset(12)]
			public bool UseDetectOutofRange;

			// Token: 0x04016EC4 RID: 93892
			[FieldOffset(13)]
			public bool __Result;
		}

		// Token: 0x0200311D RID: 12573
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __P_FS_InitializeArrays_FunctionParams
		{
			// Token: 0x04016EC5 RID: 93893
			[FieldOffset(0)]
			public IntPtr PlaneComponent;

			// Token: 0x04016EC6 RID: 93894
			[FieldOffset(8)]
			public float RayCastingDetectDis;

			// Token: 0x04016EC7 RID: 93895
			[FieldOffset(16)]
			public byte Dir;

			// Token: 0x04016EC8 RID: 93896
			[FieldOffset(32)]
			public byte EndPos;

			// Token: 0x04016EC9 RID: 93897
			[FieldOffset(48)]
			public byte Dis;

			// Token: 0x04016ECA RID: 93898
			[FieldOffset(64)]
			public int ParticleCount;
		}

		// Token: 0x0200311E RID: 12574
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __P_FS_DetectPlayer_Two_With_EPS_FunctionParams
		{
			// Token: 0x04016ECB RID: 93899
			[FieldOffset(0)]
			public IntPtr PlaneComponent;

			// Token: 0x04016ECC RID: 93900
			[FieldOffset(8)]
			public double Index;

			// Token: 0x04016ECD RID: 93901
			[FieldOffset(16)]
			public int ParticleCount;

			// Token: 0x04016ECE RID: 93902
			[FieldOffset(24)]
			public byte Dis;

			// Token: 0x04016ECF RID: 93903
			[FieldOffset(40)]
			public byte Dirs;

			// Token: 0x04016ED0 RID: 93904
			[FieldOffset(56)]
			public float eps;

			// Token: 0x04016ED1 RID: 93905
			[FieldOffset(60)]
			public float OutDistance;

			// Token: 0x04016ED2 RID: 93906
			[FieldOffset(64)]
			public bool __Result;
		}

		// Token: 0x0200311F RID: 12575
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __P_FS_DetectPlayer_Two_FunctionParams
		{
			// Token: 0x04016ED3 RID: 93907
			[FieldOffset(0)]
			public IntPtr PlaneComponent;

			// Token: 0x04016ED4 RID: 93908
			[FieldOffset(8)]
			public double Index;

			// Token: 0x04016ED5 RID: 93909
			[FieldOffset(16)]
			public int ParticleCount;

			// Token: 0x04016ED6 RID: 93910
			[FieldOffset(24)]
			public byte Dis;

			// Token: 0x04016ED7 RID: 93911
			[FieldOffset(40)]
			public byte Dirs;

			// Token: 0x04016ED8 RID: 93912
			[FieldOffset(56)]
			public float OutDistance;

			// Token: 0x04016ED9 RID: 93913
			[FieldOffset(60)]
			public bool __Result;
		}

		// Token: 0x02003120 RID: 12576
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __P_FS_ComputeTilt_ByHeightH2_FunctionParams
		{
			// Token: 0x04016EDA RID: 93914
			[FieldOffset(0)]
			public FVectorDouble LastFrameNormal;

			// Token: 0x04016EDB RID: 93915
			[FieldOffset(24)]
			public IntPtr PlaneComponent;

			// Token: 0x04016EDC RID: 93916
			[FieldOffset(32)]
			public float RayCastingDetectRange;

			// Token: 0x04016EDD RID: 93917
			[FieldOffset(40)]
			public double MaxDegreeAngle;

			// Token: 0x04016EDE RID: 93918
			[FieldOffset(48)]
			public float MinActiveRadius;

			// Token: 0x04016EDF RID: 93919
			[FieldOffset(52)]
			public float MaxActiveRadius;

			// Token: 0x04016EE0 RID: 93920
			[FieldOffset(56)]
			public double FollowSpeedRate;

			// Token: 0x04016EE1 RID: 93921
			[FieldOffset(64)]
			public double ReturnSpeedRate;

			// Token: 0x04016EE2 RID: 93922
			[FieldOffset(72)]
			public bool bPlayerColliding;

			// Token: 0x04016EE3 RID: 93923
			[FieldOffset(73)]
			public bool bLinear;

			// Token: 0x04016EE4 RID: 93924
			[FieldOffset(74)]
			public bool OutDebugBlockReturn;

			// Token: 0x04016EE5 RID: 93925
			[FieldOffset(76)]
			public float ReturnBlockVerticalLimit;

			// Token: 0x04016EE6 RID: 93926
			[FieldOffset(80)]
			public float ReturnBlockSwitchThreshold;

			// Token: 0x04016EE7 RID: 93927
			[FieldOffset(84)]
			public FRotator __Result;
		}

		// Token: 0x02003121 RID: 12577
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 168)]
		protected ref struct __P_FS_CheckFrontObstacle2_VertexBuffer_FunctionParams
		{
			// Token: 0x04016EE8 RID: 93928
			[FieldOffset(0)]
			public IntPtr PlaneComponent;

			// Token: 0x04016EE9 RID: 93929
			[FieldOffset(8)]
			public float RayCastingDetectDis;

			// Token: 0x04016EEA RID: 93930
			[FieldOffset(16)]
			public IntPtr WorldContextObject;

			// Token: 0x04016EEB RID: 93931
			[FieldOffset(24)]
			public TEnumAsByte<ETraceTypeQuery> TraceChannel;

			// Token: 0x04016EEC RID: 93932
			[FieldOffset(28)]
			public float OutDistance;

			// Token: 0x04016EED RID: 93933
			[FieldOffset(32)]
			public byte Dir;

			// Token: 0x04016EEE RID: 93934
			[FieldOffset(48)]
			public byte EndPos;

			// Token: 0x04016EEF RID: 93935
			[FieldOffset(64)]
			public byte Dis;

			// Token: 0x04016EF0 RID: 93936
			[FieldOffset(80)]
			public bool debugLine;

			// Token: 0x04016EF1 RID: 93937
			[FieldOffset(84)]
			public int CountIndex;

			// Token: 0x04016EF2 RID: 93938
			[FieldOffset(88)]
			public int BatchSize;

			// Token: 0x04016EF3 RID: 93939
			[FieldOffset(92)]
			public int ParticleCount;

			// Token: 0x04016EF4 RID: 93940
			[FieldOffset(96)]
			public int OutNewCountIndex;

			// Token: 0x04016EF5 RID: 93941
			[FieldOffset(104)]
			public byte ActorsToIgnore;

			// Token: 0x04016EF6 RID: 93942
			[FieldOffset(120)]
			public bool doNotNeedRayCasting;

			// Token: 0x04016EF7 RID: 93943
			[FieldOffset(121)]
			public bool isBeginPlayOrNot;

			// Token: 0x04016EF8 RID: 93944
			[FieldOffset(128)]
			public byte SkipTraceBoxOrigins;

			// Token: 0x04016EF9 RID: 93945
			[FieldOffset(144)]
			public byte SkipTraceBoxExtents;

			// Token: 0x04016EFA RID: 93946
			[FieldOffset(160)]
			public int OutAsyncReadBack;
		}

		// Token: 0x02003122 RID: 12578
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 176)]
		protected ref struct __P_FS_CheckFrontObstacle2_Shuffled_FunctionParams
		{
			// Token: 0x04016EFB RID: 93947
			[FieldOffset(0)]
			public IntPtr PlaneComponent;

			// Token: 0x04016EFC RID: 93948
			[FieldOffset(8)]
			public float RayCastingDetectDis;

			// Token: 0x04016EFD RID: 93949
			[FieldOffset(16)]
			public IntPtr WorldContextObject;

			// Token: 0x04016EFE RID: 93950
			[FieldOffset(24)]
			public TEnumAsByte<ETraceTypeQuery> TraceChannel;

			// Token: 0x04016EFF RID: 93951
			[FieldOffset(28)]
			public float OutDistance;

			// Token: 0x04016F00 RID: 93952
			[FieldOffset(32)]
			public byte Dir;

			// Token: 0x04016F01 RID: 93953
			[FieldOffset(48)]
			public byte EndPos;

			// Token: 0x04016F02 RID: 93954
			[FieldOffset(64)]
			public byte Dis;

			// Token: 0x04016F03 RID: 93955
			[FieldOffset(80)]
			public byte ParamNames;

			// Token: 0x04016F04 RID: 93956
			[FieldOffset(96)]
			public IntPtr MID;

			// Token: 0x04016F05 RID: 93957
			[FieldOffset(104)]
			public bool debugLine;

			// Token: 0x04016F06 RID: 93958
			[FieldOffset(108)]
			public int CountIndex;

			// Token: 0x04016F07 RID: 93959
			[FieldOffset(112)]
			public int BatchSize;

			// Token: 0x04016F08 RID: 93960
			[FieldOffset(116)]
			public int ParticleCount;

			// Token: 0x04016F09 RID: 93961
			[FieldOffset(120)]
			public int OutNewCountIndex;

			// Token: 0x04016F0A RID: 93962
			[FieldOffset(128)]
			public byte ActorsToIgnore;

			// Token: 0x04016F0B RID: 93963
			[FieldOffset(144)]
			public byte ShuffleOrder;

			// Token: 0x04016F0C RID: 93964
			[FieldOffset(160)]
			public FRandomStream Rng;

			// Token: 0x04016F0D RID: 93965
			[FieldOffset(168)]
			public bool bReshuffleWhenWrap;
		}

		// Token: 0x02003123 RID: 12579
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 144)]
		protected ref struct __P_FS_CheckFrontObstacle2_FunctionParams
		{
			// Token: 0x04016F0E RID: 93966
			[FieldOffset(0)]
			public IntPtr PlaneComponent;

			// Token: 0x04016F0F RID: 93967
			[FieldOffset(8)]
			public float RayCastingDetectDis;

			// Token: 0x04016F10 RID: 93968
			[FieldOffset(16)]
			public IntPtr WorldContextObject;

			// Token: 0x04016F11 RID: 93969
			[FieldOffset(24)]
			public TEnumAsByte<ETraceTypeQuery> TraceChannel;

			// Token: 0x04016F12 RID: 93970
			[FieldOffset(28)]
			public float OutDistance;

			// Token: 0x04016F13 RID: 93971
			[FieldOffset(32)]
			public byte Dir;

			// Token: 0x04016F14 RID: 93972
			[FieldOffset(48)]
			public byte EndPos;

			// Token: 0x04016F15 RID: 93973
			[FieldOffset(64)]
			public byte Dis;

			// Token: 0x04016F16 RID: 93974
			[FieldOffset(80)]
			public byte ParamNames;

			// Token: 0x04016F17 RID: 93975
			[FieldOffset(96)]
			public IntPtr MID;

			// Token: 0x04016F18 RID: 93976
			[FieldOffset(104)]
			public bool debugLine;

			// Token: 0x04016F19 RID: 93977
			[FieldOffset(108)]
			public int CountIndex;

			// Token: 0x04016F1A RID: 93978
			[FieldOffset(112)]
			public int BatchSize;

			// Token: 0x04016F1B RID: 93979
			[FieldOffset(116)]
			public int ParticleCount;

			// Token: 0x04016F1C RID: 93980
			[FieldOffset(120)]
			public int OutNewCountIndex;

			// Token: 0x04016F1D RID: 93981
			[FieldOffset(128)]
			public byte ActorsToIgnore;
		}
	}
}
