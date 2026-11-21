using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004AE RID: 1198
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.FSRayCastingActor")]
	[UnrealStructLayout(1544, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1544)]
	public class AFSRayCastingActor : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006EB4 RID: 28340 RVA: 0x000A33E7 File Offset: 0x000A15E7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AFSRayCastingActor._ClassPtr;
		}

		// Token: 0x06006EB5 RID: 28341 RVA: 0x000A33F4 File Offset: 0x000A15F4
		public AFSRayCastingActor() : this(BuiltinUtils.AllocNativeUObject(AFSRayCastingActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006EB6 RID: 28342 RVA: 0x000A341C File Offset: 0x000A161C
		[NullableContext(1)]
		public AFSRayCastingActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AFSRayCastingActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700159E RID: 5534
		// (get) Token: 0x06006EB7 RID: 28343 RVA: 0x000A344F File Offset: 0x000A164F
		// (set) Token: 0x06006EB8 RID: 28344 RVA: 0x000A345F File Offset: 0x000A165F
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

		// Token: 0x1700159F RID: 5535
		// (get) Token: 0x06006EB9 RID: 28345 RVA: 0x000A3470 File Offset: 0x000A1670
		// (set) Token: 0x06006EBA RID: 28346 RVA: 0x000A3480 File Offset: 0x000A1680
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

		// Token: 0x06006EBB RID: 28347 RVA: 0x000A3494 File Offset: 0x000A1694
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static double P_FS_PointToIndex_Local_Double(USceneComponent PlaneComponent, int N)
		{
			AFSRayCastingActor.__P_FS_PointToIndex_Local_Double_FunctionParams* ptr = stackalloc AFSRayCastingActor.__P_FS_PointToIndex_Local_Double_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(AFSRayCastingActor.__P_FS_PointToIndex_Local_Double_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AFSRayCastingActor.__P_FS_PointToIndex_Local_Double_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlaneComponent = ((PlaneComponent != null) ? PlaneComponent.NativePtr : IntPtr.Zero);
			ptr->N = N;
			UnrealReflectionUtils.CallUFunction(AFSRayCastingActor._ClassDefaultObjectPtr, AFSRayCastingActor.__P_FS_PointToIndex_Local_Double_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06006EBC RID: 28348 RVA: 0x000A34F8 File Offset: 0x000A16F8
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AFSRayCastingActor.__P_FS_IsPointInTriangle_ZProjection_With_EPS_NativeFunctionPtr, (void*)ptr);
			OutDistance = ptr->OutDistance;
			return ptr->__Result;
		}

		// Token: 0x06006EBD RID: 28349 RVA: 0x000A3590 File Offset: 0x000A1790
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AFSRayCastingActor.__P_FS_IsPointInTriangle_ZProjection_NativeFunctionPtr, (void*)ptr);
			OutDistance = ptr->OutDistance;
			return ptr->__Result;
		}

		// Token: 0x06006EBE RID: 28350 RVA: 0x000A3620 File Offset: 0x000A1820
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static bool P_FS_IsPlayerOutOfRayCastingRange2D(USceneComponent PlaneComponent, float InRayCastingDetectDis, bool UseDetectOutofRange)
		{
			AFSRayCastingActor.__P_FS_IsPlayerOutOfRayCastingRange2D_FunctionParams* ptr = stackalloc AFSRayCastingActor.__P_FS_IsPlayerOutOfRayCastingRange2D_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(AFSRayCastingActor.__P_FS_IsPlayerOutOfRayCastingRange2D_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AFSRayCastingActor.__P_FS_IsPlayerOutOfRayCastingRange2D_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlaneComponent = ((PlaneComponent != null) ? PlaneComponent.NativePtr : IntPtr.Zero);
			ptr->InRayCastingDetectDis = InRayCastingDetectDis;
			ptr->UseDetectOutofRange = UseDetectOutofRange;
			UnrealReflectionUtils.CallUFunction(AFSRayCastingActor._ClassDefaultObjectPtr, AFSRayCastingActor.__P_FS_IsPlayerOutOfRayCastingRange2D_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06006EBF RID: 28351 RVA: 0x000A3688 File Offset: 0x000A1888
		[NullableContext(2)]
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AFSRayCastingActor.__P_FS_InitializeArrays_NativeFunctionPtr, (void*)ptr);
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

		// Token: 0x06006EC0 RID: 28352 RVA: 0x000A377C File Offset: 0x000A197C
		[NullableContext(2)]
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AFSRayCastingActor.__P_FS_DetectPlayer_Two_With_EPS_NativeFunctionPtr, (void*)ptr);
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

		// Token: 0x06006EC1 RID: 28353 RVA: 0x000A3864 File Offset: 0x000A1A64
		[NullableContext(2)]
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AFSRayCastingActor.__P_FS_DetectPlayer_Two_NativeFunctionPtr, (void*)ptr);
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

		// Token: 0x06006EC2 RID: 28354 RVA: 0x000A3944 File Offset: 0x000A1B44
		[NullableContext(2)]
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(AFSRayCastingActor._ClassDefaultObjectPtr, AFSRayCastingActor.__P_FS_ComputeTilt_ByHeightH2_NativeFunctionPtr, (void*)ptr);
			LastFrameNormal = ptr->LastFrameNormal;
			OutDebugBlockReturn = ptr->OutDebugBlockReturn;
			return ptr->__Result;
		}

		// Token: 0x06006EC3 RID: 28355 RVA: 0x000A3A18 File Offset: 0x000A1C18
		[NullableContext(2)]
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AFSRayCastingActor.__P_FS_CheckFrontObstacle2_VertexBuffer_NativeFunctionPtr, (void*)ptr);
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

		// Token: 0x06006EC4 RID: 28356 RVA: 0x000A3C10 File Offset: 0x000A1E10
		[NullableContext(2)]
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(AFSRayCastingActor._ClassDefaultObjectPtr, AFSRayCastingActor.__P_FS_CheckFrontObstacle2_Shuffled_NativeFunctionPtr, (void*)ptr);
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

		// Token: 0x06006EC5 RID: 28357 RVA: 0x000A3E1C File Offset: 0x000A201C
		[NullableContext(2)]
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AFSRayCastingActor.__P_FS_CheckFrontObstacle2_NativeFunctionPtr, (void*)ptr);
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

		// Token: 0x06006EC6 RID: 28358 RVA: 0x000A3FDD File Offset: 0x000A21DD
		static AFSRayCastingActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.FSRayCastingActor");
		}

		// Token: 0x06006EC7 RID: 28359 RVA: 0x000A3FEB File Offset: 0x000A21EB
		protected AFSRayCastingActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002FDD RID: 12253
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.FSRayCastingActor";

		// Token: 0x04002FDE RID: 12254
		private static IntPtr _ClassPtr;

		// Token: 0x04002FDF RID: 12255
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002FE0 RID: 12256
		internal static int __PropertyOffset_bUseAsyncTrace;

		// Token: 0x04002FE1 RID: 12257
		internal static int __PropertyOffset_bDebugAsyncStats;

		// Token: 0x04002FE2 RID: 12258
		private static IntPtr __P_FS_PointToIndex_Local_Double_NativeFunctionPtr;

		// Token: 0x04002FE3 RID: 12259
		private static IntPtr __P_FS_IsPointInTriangle_ZProjection_With_EPS_NativeFunctionPtr;

		// Token: 0x04002FE4 RID: 12260
		private static IntPtr __P_FS_IsPointInTriangle_ZProjection_NativeFunctionPtr;

		// Token: 0x04002FE5 RID: 12261
		private static IntPtr __P_FS_IsPlayerOutOfRayCastingRange2D_NativeFunctionPtr;

		// Token: 0x04002FE6 RID: 12262
		private static IntPtr __P_FS_InitializeArrays_NativeFunctionPtr;

		// Token: 0x04002FE7 RID: 12263
		private static IntPtr __P_FS_DetectPlayer_Two_With_EPS_NativeFunctionPtr;

		// Token: 0x04002FE8 RID: 12264
		private static IntPtr __P_FS_DetectPlayer_Two_NativeFunctionPtr;

		// Token: 0x04002FE9 RID: 12265
		private static IntPtr __P_FS_ComputeTilt_ByHeightH2_NativeFunctionPtr;

		// Token: 0x04002FEA RID: 12266
		private static IntPtr __P_FS_CheckFrontObstacle2_VertexBuffer_NativeFunctionPtr;

		// Token: 0x04002FEB RID: 12267
		private static IntPtr __P_FS_CheckFrontObstacle2_Shuffled_NativeFunctionPtr;

		// Token: 0x04002FEC RID: 12268
		private static IntPtr __P_FS_CheckFrontObstacle2_NativeFunctionPtr;

		// Token: 0x02000BEE RID: 3054
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __P_FS_PointToIndex_Local_Double_FunctionParams
		{
			// Token: 0x04005DA9 RID: 23977
			[FieldOffset(0)]
			public IntPtr PlaneComponent;

			// Token: 0x04005DAA RID: 23978
			[FieldOffset(8)]
			public int N;

			// Token: 0x04005DAB RID: 23979
			[FieldOffset(16)]
			public double __Result;
		}

		// Token: 0x02000BEF RID: 3055
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __P_FS_IsPointInTriangle_ZProjection_With_EPS_FunctionParams
		{
			// Token: 0x04005DAC RID: 23980
			[FieldOffset(0)]
			public FVector P;

			// Token: 0x04005DAD RID: 23981
			[FieldOffset(12)]
			public FVector A;

			// Token: 0x04005DAE RID: 23982
			[FieldOffset(24)]
			public FVector B;

			// Token: 0x04005DAF RID: 23983
			[FieldOffset(36)]
			public FVector C;

			// Token: 0x04005DB0 RID: 23984
			[FieldOffset(48)]
			public float EPS;

			// Token: 0x04005DB1 RID: 23985
			[FieldOffset(52)]
			public float OutDistance;

			// Token: 0x04005DB2 RID: 23986
			[FieldOffset(56)]
			public float Epsilon;

			// Token: 0x04005DB3 RID: 23987
			[FieldOffset(60)]
			public bool __Result;
		}

		// Token: 0x02000BF0 RID: 3056
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 60)]
		protected ref struct __P_FS_IsPointInTriangle_ZProjection_FunctionParams
		{
			// Token: 0x04005DB4 RID: 23988
			[FieldOffset(0)]
			public FVector P;

			// Token: 0x04005DB5 RID: 23989
			[FieldOffset(12)]
			public FVector A;

			// Token: 0x04005DB6 RID: 23990
			[FieldOffset(24)]
			public FVector B;

			// Token: 0x04005DB7 RID: 23991
			[FieldOffset(36)]
			public FVector C;

			// Token: 0x04005DB8 RID: 23992
			[FieldOffset(48)]
			public float OutDistance;

			// Token: 0x04005DB9 RID: 23993
			[FieldOffset(52)]
			public float Epsilon;

			// Token: 0x04005DBA RID: 23994
			[FieldOffset(56)]
			public bool __Result;
		}

		// Token: 0x02000BF1 RID: 3057
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __P_FS_IsPlayerOutOfRayCastingRange2D_FunctionParams
		{
			// Token: 0x04005DBB RID: 23995
			[FieldOffset(0)]
			public IntPtr PlaneComponent;

			// Token: 0x04005DBC RID: 23996
			[FieldOffset(8)]
			public float InRayCastingDetectDis;

			// Token: 0x04005DBD RID: 23997
			[FieldOffset(12)]
			public bool UseDetectOutofRange;

			// Token: 0x04005DBE RID: 23998
			[FieldOffset(13)]
			public bool __Result;
		}

		// Token: 0x02000BF2 RID: 3058
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __P_FS_InitializeArrays_FunctionParams
		{
			// Token: 0x04005DBF RID: 23999
			[FieldOffset(0)]
			public IntPtr PlaneComponent;

			// Token: 0x04005DC0 RID: 24000
			[FieldOffset(8)]
			public float RayCastingDetectDis;

			// Token: 0x04005DC1 RID: 24001
			[FieldOffset(16)]
			public byte Dir;

			// Token: 0x04005DC2 RID: 24002
			[FieldOffset(32)]
			public byte EndPos;

			// Token: 0x04005DC3 RID: 24003
			[FieldOffset(48)]
			public byte Dis;

			// Token: 0x04005DC4 RID: 24004
			[FieldOffset(64)]
			public int ParticleCount;
		}

		// Token: 0x02000BF3 RID: 3059
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __P_FS_DetectPlayer_Two_With_EPS_FunctionParams
		{
			// Token: 0x04005DC5 RID: 24005
			[FieldOffset(0)]
			public IntPtr PlaneComponent;

			// Token: 0x04005DC6 RID: 24006
			[FieldOffset(8)]
			public double Index;

			// Token: 0x04005DC7 RID: 24007
			[FieldOffset(16)]
			public int ParticleCount;

			// Token: 0x04005DC8 RID: 24008
			[FieldOffset(24)]
			public byte Dis;

			// Token: 0x04005DC9 RID: 24009
			[FieldOffset(40)]
			public byte Dirs;

			// Token: 0x04005DCA RID: 24010
			[FieldOffset(56)]
			public float eps;

			// Token: 0x04005DCB RID: 24011
			[FieldOffset(60)]
			public float OutDistance;

			// Token: 0x04005DCC RID: 24012
			[FieldOffset(64)]
			public bool __Result;
		}

		// Token: 0x02000BF4 RID: 3060
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __P_FS_DetectPlayer_Two_FunctionParams
		{
			// Token: 0x04005DCD RID: 24013
			[FieldOffset(0)]
			public IntPtr PlaneComponent;

			// Token: 0x04005DCE RID: 24014
			[FieldOffset(8)]
			public double Index;

			// Token: 0x04005DCF RID: 24015
			[FieldOffset(16)]
			public int ParticleCount;

			// Token: 0x04005DD0 RID: 24016
			[FieldOffset(24)]
			public byte Dis;

			// Token: 0x04005DD1 RID: 24017
			[FieldOffset(40)]
			public byte Dirs;

			// Token: 0x04005DD2 RID: 24018
			[FieldOffset(56)]
			public float OutDistance;

			// Token: 0x04005DD3 RID: 24019
			[FieldOffset(60)]
			public bool __Result;
		}

		// Token: 0x02000BF5 RID: 3061
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __P_FS_ComputeTilt_ByHeightH2_FunctionParams
		{
			// Token: 0x04005DD4 RID: 24020
			[FieldOffset(0)]
			public FVectorDouble LastFrameNormal;

			// Token: 0x04005DD5 RID: 24021
			[FieldOffset(24)]
			public IntPtr PlaneComponent;

			// Token: 0x04005DD6 RID: 24022
			[FieldOffset(32)]
			public float RayCastingDetectRange;

			// Token: 0x04005DD7 RID: 24023
			[FieldOffset(40)]
			public double MaxDegreeAngle;

			// Token: 0x04005DD8 RID: 24024
			[FieldOffset(48)]
			public float MinActiveRadius;

			// Token: 0x04005DD9 RID: 24025
			[FieldOffset(52)]
			public float MaxActiveRadius;

			// Token: 0x04005DDA RID: 24026
			[FieldOffset(56)]
			public double FollowSpeedRate;

			// Token: 0x04005DDB RID: 24027
			[FieldOffset(64)]
			public double ReturnSpeedRate;

			// Token: 0x04005DDC RID: 24028
			[FieldOffset(72)]
			public bool bPlayerColliding;

			// Token: 0x04005DDD RID: 24029
			[FieldOffset(73)]
			public bool bLinear;

			// Token: 0x04005DDE RID: 24030
			[FieldOffset(74)]
			public bool OutDebugBlockReturn;

			// Token: 0x04005DDF RID: 24031
			[FieldOffset(76)]
			public float ReturnBlockVerticalLimit;

			// Token: 0x04005DE0 RID: 24032
			[FieldOffset(80)]
			public float ReturnBlockSwitchThreshold;

			// Token: 0x04005DE1 RID: 24033
			[FieldOffset(84)]
			public FRotator __Result;
		}

		// Token: 0x02000BF6 RID: 3062
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 168)]
		protected ref struct __P_FS_CheckFrontObstacle2_VertexBuffer_FunctionParams
		{
			// Token: 0x04005DE2 RID: 24034
			[FieldOffset(0)]
			public IntPtr PlaneComponent;

			// Token: 0x04005DE3 RID: 24035
			[FieldOffset(8)]
			public float RayCastingDetectDis;

			// Token: 0x04005DE4 RID: 24036
			[FieldOffset(16)]
			public IntPtr WorldContextObject;

			// Token: 0x04005DE5 RID: 24037
			[FieldOffset(24)]
			public TEnumAsByte<ETraceTypeQuery> TraceChannel;

			// Token: 0x04005DE6 RID: 24038
			[FieldOffset(28)]
			public float OutDistance;

			// Token: 0x04005DE7 RID: 24039
			[FieldOffset(32)]
			public byte Dir;

			// Token: 0x04005DE8 RID: 24040
			[FieldOffset(48)]
			public byte EndPos;

			// Token: 0x04005DE9 RID: 24041
			[FieldOffset(64)]
			public byte Dis;

			// Token: 0x04005DEA RID: 24042
			[FieldOffset(80)]
			public bool debugLine;

			// Token: 0x04005DEB RID: 24043
			[FieldOffset(84)]
			public int CountIndex;

			// Token: 0x04005DEC RID: 24044
			[FieldOffset(88)]
			public int BatchSize;

			// Token: 0x04005DED RID: 24045
			[FieldOffset(92)]
			public int ParticleCount;

			// Token: 0x04005DEE RID: 24046
			[FieldOffset(96)]
			public int OutNewCountIndex;

			// Token: 0x04005DEF RID: 24047
			[FieldOffset(104)]
			public byte ActorsToIgnore;

			// Token: 0x04005DF0 RID: 24048
			[FieldOffset(120)]
			public bool doNotNeedRayCasting;

			// Token: 0x04005DF1 RID: 24049
			[FieldOffset(121)]
			public bool isBeginPlayOrNot;

			// Token: 0x04005DF2 RID: 24050
			[FieldOffset(128)]
			public byte SkipTraceBoxOrigins;

			// Token: 0x04005DF3 RID: 24051
			[FieldOffset(144)]
			public byte SkipTraceBoxExtents;

			// Token: 0x04005DF4 RID: 24052
			[FieldOffset(160)]
			public int OutAsyncReadBack;
		}

		// Token: 0x02000BF7 RID: 3063
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 176)]
		protected ref struct __P_FS_CheckFrontObstacle2_Shuffled_FunctionParams
		{
			// Token: 0x04005DF5 RID: 24053
			[FieldOffset(0)]
			public IntPtr PlaneComponent;

			// Token: 0x04005DF6 RID: 24054
			[FieldOffset(8)]
			public float RayCastingDetectDis;

			// Token: 0x04005DF7 RID: 24055
			[FieldOffset(16)]
			public IntPtr WorldContextObject;

			// Token: 0x04005DF8 RID: 24056
			[FieldOffset(24)]
			public TEnumAsByte<ETraceTypeQuery> TraceChannel;

			// Token: 0x04005DF9 RID: 24057
			[FieldOffset(28)]
			public float OutDistance;

			// Token: 0x04005DFA RID: 24058
			[FieldOffset(32)]
			public byte Dir;

			// Token: 0x04005DFB RID: 24059
			[FieldOffset(48)]
			public byte EndPos;

			// Token: 0x04005DFC RID: 24060
			[FieldOffset(64)]
			public byte Dis;

			// Token: 0x04005DFD RID: 24061
			[FieldOffset(80)]
			public byte ParamNames;

			// Token: 0x04005DFE RID: 24062
			[FieldOffset(96)]
			public IntPtr MID;

			// Token: 0x04005DFF RID: 24063
			[FieldOffset(104)]
			public bool debugLine;

			// Token: 0x04005E00 RID: 24064
			[FieldOffset(108)]
			public int CountIndex;

			// Token: 0x04005E01 RID: 24065
			[FieldOffset(112)]
			public int BatchSize;

			// Token: 0x04005E02 RID: 24066
			[FieldOffset(116)]
			public int ParticleCount;

			// Token: 0x04005E03 RID: 24067
			[FieldOffset(120)]
			public int OutNewCountIndex;

			// Token: 0x04005E04 RID: 24068
			[FieldOffset(128)]
			public byte ActorsToIgnore;

			// Token: 0x04005E05 RID: 24069
			[FieldOffset(144)]
			public byte ShuffleOrder;

			// Token: 0x04005E06 RID: 24070
			[FieldOffset(160)]
			public FRandomStream Rng;

			// Token: 0x04005E07 RID: 24071
			[FieldOffset(168)]
			public bool bReshuffleWhenWrap;
		}

		// Token: 0x02000BF8 RID: 3064
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 144)]
		protected ref struct __P_FS_CheckFrontObstacle2_FunctionParams
		{
			// Token: 0x04005E08 RID: 24072
			[FieldOffset(0)]
			public IntPtr PlaneComponent;

			// Token: 0x04005E09 RID: 24073
			[FieldOffset(8)]
			public float RayCastingDetectDis;

			// Token: 0x04005E0A RID: 24074
			[FieldOffset(16)]
			public IntPtr WorldContextObject;

			// Token: 0x04005E0B RID: 24075
			[FieldOffset(24)]
			public TEnumAsByte<ETraceTypeQuery> TraceChannel;

			// Token: 0x04005E0C RID: 24076
			[FieldOffset(28)]
			public float OutDistance;

			// Token: 0x04005E0D RID: 24077
			[FieldOffset(32)]
			public byte Dir;

			// Token: 0x04005E0E RID: 24078
			[FieldOffset(48)]
			public byte EndPos;

			// Token: 0x04005E0F RID: 24079
			[FieldOffset(64)]
			public byte Dis;

			// Token: 0x04005E10 RID: 24080
			[FieldOffset(80)]
			public byte ParamNames;

			// Token: 0x04005E11 RID: 24081
			[FieldOffset(96)]
			public IntPtr MID;

			// Token: 0x04005E12 RID: 24082
			[FieldOffset(104)]
			public bool debugLine;

			// Token: 0x04005E13 RID: 24083
			[FieldOffset(108)]
			public int CountIndex;

			// Token: 0x04005E14 RID: 24084
			[FieldOffset(112)]
			public int BatchSize;

			// Token: 0x04005E15 RID: 24085
			[FieldOffset(116)]
			public int ParticleCount;

			// Token: 0x04005E16 RID: 24086
			[FieldOffset(120)]
			public int OutNewCountIndex;

			// Token: 0x04005E17 RID: 24087
			[FieldOffset(128)]
			public byte ActorsToIgnore;
		}
	}
}
