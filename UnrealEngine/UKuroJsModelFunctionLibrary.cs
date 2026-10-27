using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018E2 RID: 6370
	[UnrealObjectPath("/Script/KuroGameplay.KuroJsModelFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroJsModelFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017968 RID: 96616 RVA: 0x002288DE File Offset: 0x00226ADE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroJsModelFunctionLibrary._ClassPtr;
		}

		// Token: 0x06017969 RID: 96617 RVA: 0x002288EC File Offset: 0x00226AEC
		public UKuroJsModelFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroJsModelFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601796A RID: 96618 RVA: 0x00228914 File Offset: 0x00226B14
		[NullableContext(1)]
		public UKuroJsModelFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroJsModelFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601796B RID: 96619 RVA: 0x00228948 File Offset: 0x00226B48
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void UpdateEntityActor(int EntityId, AActor Actor)
		{
			UKuroJsModelFunctionLibrary.__UpdateEntityActor_FunctionParams* ptr = stackalloc UKuroJsModelFunctionLibrary.__UpdateEntityActor_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroJsModelFunctionLibrary.__UpdateEntityActor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroJsModelFunctionLibrary.__UpdateEntityActor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UKuroJsModelFunctionLibrary._ClassDefaultObjectPtr, UKuroJsModelFunctionLibrary.__UpdateEntityActor_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601796C RID: 96620 RVA: 0x002289A4 File Offset: 0x00226BA4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetCreatureDataComponentPbDataId(int EntityId, uint PbDataId)
		{
			UKuroJsModelFunctionLibrary.__SetCreatureDataComponentPbDataId_FunctionParams* ptr = stackalloc UKuroJsModelFunctionLibrary.__SetCreatureDataComponentPbDataId_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroJsModelFunctionLibrary.__SetCreatureDataComponentPbDataId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroJsModelFunctionLibrary.__SetCreatureDataComponentPbDataId_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			ptr->PbDataId = PbDataId;
			UnrealReflectionUtils.CallUFunction(UKuroJsModelFunctionLibrary._ClassDefaultObjectPtr, UKuroJsModelFunctionLibrary.__SetCreatureDataComponentPbDataId_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601796D RID: 96621 RVA: 0x002289F4 File Offset: 0x00226BF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetCreatureDataComponentEntityType(int EntityId, byte EntityType)
		{
			UKuroJsModelFunctionLibrary.__SetCreatureDataComponentEntityType_FunctionParams* ptr = stackalloc UKuroJsModelFunctionLibrary.__SetCreatureDataComponentEntityType_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroJsModelFunctionLibrary.__SetCreatureDataComponentEntityType_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroJsModelFunctionLibrary.__SetCreatureDataComponentEntityType_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			ptr->EntityType = EntityType;
			UnrealReflectionUtils.CallUFunction(UKuroJsModelFunctionLibrary._ClassDefaultObjectPtr, UKuroJsModelFunctionLibrary.__SetCreatureDataComponentEntityType_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601796E RID: 96622 RVA: 0x00228A44 File Offset: 0x00226C44
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetCharacterUnifiedStateComponentPositionState(int EntityId, byte PositionState)
		{
			UKuroJsModelFunctionLibrary.__SetCharacterUnifiedStateComponentPositionState_FunctionParams* ptr = stackalloc UKuroJsModelFunctionLibrary.__SetCharacterUnifiedStateComponentPositionState_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroJsModelFunctionLibrary.__SetCharacterUnifiedStateComponentPositionState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroJsModelFunctionLibrary.__SetCharacterUnifiedStateComponentPositionState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			ptr->PositionState = PositionState;
			UnrealReflectionUtils.CallUFunction(UKuroJsModelFunctionLibrary._ClassDefaultObjectPtr, UKuroJsModelFunctionLibrary.__SetCharacterUnifiedStateComponentPositionState_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601796F RID: 96623 RVA: 0x00228A94 File Offset: 0x00226C94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetCharacterUnifiedStateComponentMoveState(int EntityId, byte MoveState)
		{
			UKuroJsModelFunctionLibrary.__SetCharacterUnifiedStateComponentMoveState_FunctionParams* ptr = stackalloc UKuroJsModelFunctionLibrary.__SetCharacterUnifiedStateComponentMoveState_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroJsModelFunctionLibrary.__SetCharacterUnifiedStateComponentMoveState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroJsModelFunctionLibrary.__SetCharacterUnifiedStateComponentMoveState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			ptr->MoveState = MoveState;
			UnrealReflectionUtils.CallUFunction(UKuroJsModelFunctionLibrary._ClassDefaultObjectPtr, UKuroJsModelFunctionLibrary.__SetCharacterUnifiedStateComponentMoveState_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06017970 RID: 96624 RVA: 0x00228AE4 File Offset: 0x00226CE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetAiPerceptionDataAiSenseGroupLoseDelayRange(int AiPerceptionDataHandle, in FVector2D InValue)
		{
			UKuroJsModelFunctionLibrary.__SetAiPerceptionDataAiSenseGroupLoseDelayRange_FunctionParams* ptr = stackalloc UKuroJsModelFunctionLibrary.__SetAiPerceptionDataAiSenseGroupLoseDelayRange_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroJsModelFunctionLibrary.__SetAiPerceptionDataAiSenseGroupLoseDelayRange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroJsModelFunctionLibrary.__SetAiPerceptionDataAiSenseGroupLoseDelayRange_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AiPerceptionDataHandle = AiPerceptionDataHandle;
			ptr->InValue = InValue;
			UnrealReflectionUtils.CallUFunction(UKuroJsModelFunctionLibrary._ClassDefaultObjectPtr, UKuroJsModelFunctionLibrary.__SetAiPerceptionDataAiSenseGroupLoseDelayRange_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06017971 RID: 96625 RVA: 0x00228B38 File Offset: 0x00226D38
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RemoveEntity(int EntityId)
		{
			UKuroJsModelFunctionLibrary.__RemoveEntity_FunctionParams* ptr = stackalloc UKuroJsModelFunctionLibrary.__RemoveEntity_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroJsModelFunctionLibrary.__RemoveEntity_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroJsModelFunctionLibrary.__RemoveEntity_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			UnrealReflectionUtils.CallUFunction(UKuroJsModelFunctionLibrary._ClassDefaultObjectPtr, UKuroJsModelFunctionLibrary.__RemoveEntity_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06017972 RID: 96626 RVA: 0x00228B80 File Offset: 0x00226D80
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void InitializeEnvironment(UWorld World)
		{
			UKuroJsModelFunctionLibrary.__InitializeEnvironment_FunctionParams* ptr = stackalloc UKuroJsModelFunctionLibrary.__InitializeEnvironment_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroJsModelFunctionLibrary.__InitializeEnvironment_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroJsModelFunctionLibrary.__InitializeEnvironment_NativeFunctionPtr, (void*)ptr, 1);
			ptr->World = ((World != null) ? World.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UKuroJsModelFunctionLibrary._ClassDefaultObjectPtr, UKuroJsModelFunctionLibrary.__InitializeEnvironment_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06017973 RID: 96627 RVA: 0x00228BD8 File Offset: 0x00226DD8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void IncrementAiPerceptionDataWithAngleVerticalCount(int AiPerceptionDataHandle)
		{
			UKuroJsModelFunctionLibrary.__IncrementAiPerceptionDataWithAngleVerticalCount_FunctionParams* ptr = stackalloc UKuroJsModelFunctionLibrary.__IncrementAiPerceptionDataWithAngleVerticalCount_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroJsModelFunctionLibrary.__IncrementAiPerceptionDataWithAngleVerticalCount_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroJsModelFunctionLibrary.__IncrementAiPerceptionDataWithAngleVerticalCount_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AiPerceptionDataHandle = AiPerceptionDataHandle;
			UnrealReflectionUtils.CallUFunction(UKuroJsModelFunctionLibrary._ClassDefaultObjectPtr, UKuroJsModelFunctionLibrary.__IncrementAiPerceptionDataWithAngleVerticalCount_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06017974 RID: 96628 RVA: 0x00228C20 File Offset: 0x00226E20
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void IncrementAiPerceptionDataWithAngleHorizontalCount(int AiPerceptionDataHandle)
		{
			UKuroJsModelFunctionLibrary.__IncrementAiPerceptionDataWithAngleHorizontalCount_FunctionParams* ptr = stackalloc UKuroJsModelFunctionLibrary.__IncrementAiPerceptionDataWithAngleHorizontalCount_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroJsModelFunctionLibrary.__IncrementAiPerceptionDataWithAngleHorizontalCount_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroJsModelFunctionLibrary.__IncrementAiPerceptionDataWithAngleHorizontalCount_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AiPerceptionDataHandle = AiPerceptionDataHandle;
			UnrealReflectionUtils.CallUFunction(UKuroJsModelFunctionLibrary._ClassDefaultObjectPtr, UKuroJsModelFunctionLibrary.__IncrementAiPerceptionDataWithAngleHorizontalCount_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06017975 RID: 96629 RVA: 0x00228C68 File Offset: 0x00226E68
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static AActor GetEntityActor(int EntityId)
		{
			UKuroJsModelFunctionLibrary.__GetEntityActor_FunctionParams* ptr = stackalloc UKuroJsModelFunctionLibrary.__GetEntityActor_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroJsModelFunctionLibrary.__GetEntityActor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroJsModelFunctionLibrary.__GetEntityActor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			UnrealReflectionUtils.CallUFunction(UKuroJsModelFunctionLibrary._ClassDefaultObjectPtr, UKuroJsModelFunctionLibrary.__GetEntityActor_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ptr->__Result);
		}

		// Token: 0x06017976 RID: 96630 RVA: 0x00228CB9 File Offset: 0x00226EB9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void DestroyEnvironment()
		{
			UnrealReflectionUtils.CallUFunction(UKuroJsModelFunctionLibrary._ClassDefaultObjectPtr, UKuroJsModelFunctionLibrary.__DestroyEnvironment_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06017977 RID: 96631 RVA: 0x00228CD0 File Offset: 0x00226ED0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void DestroyAiPerceptionData(int AiPerceptionDataHandle)
		{
			UKuroJsModelFunctionLibrary.__DestroyAiPerceptionData_FunctionParams* ptr = stackalloc UKuroJsModelFunctionLibrary.__DestroyAiPerceptionData_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroJsModelFunctionLibrary.__DestroyAiPerceptionData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroJsModelFunctionLibrary.__DestroyAiPerceptionData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AiPerceptionDataHandle = AiPerceptionDataHandle;
			UnrealReflectionUtils.CallUFunction(UKuroJsModelFunctionLibrary._ClassDefaultObjectPtr, UKuroJsModelFunctionLibrary.__DestroyAiPerceptionData_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06017978 RID: 96632 RVA: 0x00228D18 File Offset: 0x00226F18
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void DecrementAiPerceptionDataWithAngleVerticalCount(int AiPerceptionDataHandle)
		{
			UKuroJsModelFunctionLibrary.__DecrementAiPerceptionDataWithAngleVerticalCount_FunctionParams* ptr = stackalloc UKuroJsModelFunctionLibrary.__DecrementAiPerceptionDataWithAngleVerticalCount_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroJsModelFunctionLibrary.__DecrementAiPerceptionDataWithAngleVerticalCount_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroJsModelFunctionLibrary.__DecrementAiPerceptionDataWithAngleVerticalCount_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AiPerceptionDataHandle = AiPerceptionDataHandle;
			UnrealReflectionUtils.CallUFunction(UKuroJsModelFunctionLibrary._ClassDefaultObjectPtr, UKuroJsModelFunctionLibrary.__DecrementAiPerceptionDataWithAngleVerticalCount_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06017979 RID: 96633 RVA: 0x00228D60 File Offset: 0x00226F60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void DecrementAiPerceptionDataWithAngleHorizontalCount(int AiPerceptionDataHandle)
		{
			UKuroJsModelFunctionLibrary.__DecrementAiPerceptionDataWithAngleHorizontalCount_FunctionParams* ptr = stackalloc UKuroJsModelFunctionLibrary.__DecrementAiPerceptionDataWithAngleHorizontalCount_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroJsModelFunctionLibrary.__DecrementAiPerceptionDataWithAngleHorizontalCount_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroJsModelFunctionLibrary.__DecrementAiPerceptionDataWithAngleHorizontalCount_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AiPerceptionDataHandle = AiPerceptionDataHandle;
			UnrealReflectionUtils.CallUFunction(UKuroJsModelFunctionLibrary._ClassDefaultObjectPtr, UKuroJsModelFunctionLibrary.__DecrementAiPerceptionDataWithAngleHorizontalCount_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601797A RID: 96634 RVA: 0x00228DA8 File Offset: 0x00226FA8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int CreateAiPerceptionData(int EntityId)
		{
			UKuroJsModelFunctionLibrary.__CreateAiPerceptionData_FunctionParams* ptr = stackalloc UKuroJsModelFunctionLibrary.__CreateAiPerceptionData_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroJsModelFunctionLibrary.__CreateAiPerceptionData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroJsModelFunctionLibrary.__CreateAiPerceptionData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			UnrealReflectionUtils.CallUFunction(UKuroJsModelFunctionLibrary._ClassDefaultObjectPtr, UKuroJsModelFunctionLibrary.__CreateAiPerceptionData_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601797B RID: 96635 RVA: 0x00228DF4 File Offset: 0x00226FF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void AddEntity(int EntityId)
		{
			UKuroJsModelFunctionLibrary.__AddEntity_FunctionParams* ptr = stackalloc UKuroJsModelFunctionLibrary.__AddEntity_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroJsModelFunctionLibrary.__AddEntity_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroJsModelFunctionLibrary.__AddEntity_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			UnrealReflectionUtils.CallUFunction(UKuroJsModelFunctionLibrary._ClassDefaultObjectPtr, UKuroJsModelFunctionLibrary.__AddEntity_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601797C RID: 96636 RVA: 0x00228E3A File Offset: 0x0022703A
		static UKuroJsModelFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroJsModelFunctionLibrary");
		}

		// Token: 0x0601797D RID: 96637 RVA: 0x00228E48 File Offset: 0x00227048
		protected UKuroJsModelFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CCD7 RID: 52439
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroJsModelFunctionLibrary";

		// Token: 0x0400CCD8 RID: 52440
		private static IntPtr _ClassPtr;

		// Token: 0x0400CCD9 RID: 52441
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CCDA RID: 52442
		private static IntPtr __UpdateEntityActor_NativeFunctionPtr;

		// Token: 0x0400CCDB RID: 52443
		private static IntPtr __SetCreatureDataComponentPbDataId_NativeFunctionPtr;

		// Token: 0x0400CCDC RID: 52444
		private static IntPtr __SetCreatureDataComponentEntityType_NativeFunctionPtr;

		// Token: 0x0400CCDD RID: 52445
		private static IntPtr __SetCharacterUnifiedStateComponentPositionState_NativeFunctionPtr;

		// Token: 0x0400CCDE RID: 52446
		private static IntPtr __SetCharacterUnifiedStateComponentMoveState_NativeFunctionPtr;

		// Token: 0x0400CCDF RID: 52447
		private static IntPtr __SetAiPerceptionDataAiSenseGroupLoseDelayRange_NativeFunctionPtr;

		// Token: 0x0400CCE0 RID: 52448
		private static IntPtr __RemoveEntity_NativeFunctionPtr;

		// Token: 0x0400CCE1 RID: 52449
		private static IntPtr __InitializeEnvironment_NativeFunctionPtr;

		// Token: 0x0400CCE2 RID: 52450
		private static IntPtr __IncrementAiPerceptionDataWithAngleVerticalCount_NativeFunctionPtr;

		// Token: 0x0400CCE3 RID: 52451
		private static IntPtr __IncrementAiPerceptionDataWithAngleHorizontalCount_NativeFunctionPtr;

		// Token: 0x0400CCE4 RID: 52452
		private static IntPtr __GetEntityActor_NativeFunctionPtr;

		// Token: 0x0400CCE5 RID: 52453
		private static IntPtr __DestroyEnvironment_NativeFunctionPtr;

		// Token: 0x0400CCE6 RID: 52454
		private static IntPtr __DestroyAiPerceptionData_NativeFunctionPtr;

		// Token: 0x0400CCE7 RID: 52455
		private static IntPtr __DecrementAiPerceptionDataWithAngleVerticalCount_NativeFunctionPtr;

		// Token: 0x0400CCE8 RID: 52456
		private static IntPtr __DecrementAiPerceptionDataWithAngleHorizontalCount_NativeFunctionPtr;

		// Token: 0x0400CCE9 RID: 52457
		private static IntPtr __CreateAiPerceptionData_NativeFunctionPtr;

		// Token: 0x0400CCEA RID: 52458
		private static IntPtr __AddEntity_NativeFunctionPtr;

		// Token: 0x02002FC3 RID: 12227
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __UpdateEntityActor_FunctionParams
		{
			// Token: 0x04016BA9 RID: 93097
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x04016BAA RID: 93098
			[FieldOffset(8)]
			public IntPtr Actor;
		}

		// Token: 0x02002FC4 RID: 12228
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetCreatureDataComponentPbDataId_FunctionParams
		{
			// Token: 0x04016BAB RID: 93099
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x04016BAC RID: 93100
			[FieldOffset(4)]
			public uint PbDataId;
		}

		// Token: 0x02002FC5 RID: 12229
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetCreatureDataComponentEntityType_FunctionParams
		{
			// Token: 0x04016BAD RID: 93101
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x04016BAE RID: 93102
			[FieldOffset(4)]
			public byte EntityType;
		}

		// Token: 0x02002FC6 RID: 12230
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetCharacterUnifiedStateComponentPositionState_FunctionParams
		{
			// Token: 0x04016BAF RID: 93103
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x04016BB0 RID: 93104
			[FieldOffset(4)]
			public byte PositionState;
		}

		// Token: 0x02002FC7 RID: 12231
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetCharacterUnifiedStateComponentMoveState_FunctionParams
		{
			// Token: 0x04016BB1 RID: 93105
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x04016BB2 RID: 93106
			[FieldOffset(4)]
			public byte MoveState;
		}

		// Token: 0x02002FC8 RID: 12232
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __SetAiPerceptionDataAiSenseGroupLoseDelayRange_FunctionParams
		{
			// Token: 0x04016BB3 RID: 93107
			[FieldOffset(0)]
			public int AiPerceptionDataHandle;

			// Token: 0x04016BB4 RID: 93108
			[FieldOffset(4)]
			public FVector2D InValue;
		}

		// Token: 0x02002FC9 RID: 12233
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __RemoveEntity_FunctionParams
		{
			// Token: 0x04016BB5 RID: 93109
			[FieldOffset(0)]
			public int EntityId;
		}

		// Token: 0x02002FCA RID: 12234
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __InitializeEnvironment_FunctionParams
		{
			// Token: 0x04016BB6 RID: 93110
			[FieldOffset(0)]
			public IntPtr World;
		}

		// Token: 0x02002FCB RID: 12235
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __IncrementAiPerceptionDataWithAngleVerticalCount_FunctionParams
		{
			// Token: 0x04016BB7 RID: 93111
			[FieldOffset(0)]
			public int AiPerceptionDataHandle;
		}

		// Token: 0x02002FCC RID: 12236
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __IncrementAiPerceptionDataWithAngleHorizontalCount_FunctionParams
		{
			// Token: 0x04016BB8 RID: 93112
			[FieldOffset(0)]
			public int AiPerceptionDataHandle;
		}

		// Token: 0x02002FCD RID: 12237
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetEntityActor_FunctionParams
		{
			// Token: 0x04016BB9 RID: 93113
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x04016BBA RID: 93114
			[FieldOffset(8)]
			public IntPtr __Result;
		}

		// Token: 0x02002FCE RID: 12238
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __DestroyAiPerceptionData_FunctionParams
		{
			// Token: 0x04016BBB RID: 93115
			[FieldOffset(0)]
			public int AiPerceptionDataHandle;
		}

		// Token: 0x02002FCF RID: 12239
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __DecrementAiPerceptionDataWithAngleVerticalCount_FunctionParams
		{
			// Token: 0x04016BBC RID: 93116
			[FieldOffset(0)]
			public int AiPerceptionDataHandle;
		}

		// Token: 0x02002FD0 RID: 12240
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __DecrementAiPerceptionDataWithAngleHorizontalCount_FunctionParams
		{
			// Token: 0x04016BBD RID: 93117
			[FieldOffset(0)]
			public int AiPerceptionDataHandle;
		}

		// Token: 0x02002FD1 RID: 12241
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __CreateAiPerceptionData_FunctionParams
		{
			// Token: 0x04016BBE RID: 93118
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x04016BBF RID: 93119
			[FieldOffset(4)]
			public int __Result;
		}

		// Token: 0x02002FD2 RID: 12242
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __AddEntity_FunctionParams
		{
			// Token: 0x04016BC0 RID: 93120
			[FieldOffset(0)]
			public int EntityId;
		}
	}
}
