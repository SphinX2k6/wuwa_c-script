using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003EF RID: 1007
	[UnrealObjectPath("/Script/KuroGameplay.KuroJsModelFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroJsModelFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006312 RID: 25362 RVA: 0x0008D798 File Offset: 0x0008B998
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroJsModelFunctionLibrary._ClassPtr;
		}

		// Token: 0x06006313 RID: 25363 RVA: 0x0008D7A4 File Offset: 0x0008B9A4
		public UKuroJsModelFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroJsModelFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006314 RID: 25364 RVA: 0x0008D7CC File Offset: 0x0008B9CC
		[NullableContext(1)]
		public UKuroJsModelFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroJsModelFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006315 RID: 25365 RVA: 0x0008D800 File Offset: 0x0008BA00
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void UpdateEntityActor(int EntityId, AActor Actor)
		{
			UKuroJsModelFunctionLibrary.__UpdateEntityActor_FunctionParams* ptr = stackalloc UKuroJsModelFunctionLibrary.__UpdateEntityActor_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroJsModelFunctionLibrary.__UpdateEntityActor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroJsModelFunctionLibrary.__UpdateEntityActor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UKuroJsModelFunctionLibrary._ClassDefaultObjectPtr, UKuroJsModelFunctionLibrary.__UpdateEntityActor_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06006316 RID: 25366 RVA: 0x0008D85C File Offset: 0x0008BA5C
		[SkipLocalsInit]
		public unsafe static void SetCreatureDataComponentPbDataId(int EntityId, uint PbDataId)
		{
			UKuroJsModelFunctionLibrary.__SetCreatureDataComponentPbDataId_FunctionParams* ptr = stackalloc UKuroJsModelFunctionLibrary.__SetCreatureDataComponentPbDataId_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroJsModelFunctionLibrary.__SetCreatureDataComponentPbDataId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroJsModelFunctionLibrary.__SetCreatureDataComponentPbDataId_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			ptr->PbDataId = PbDataId;
			UnrealReflectionUtils.CallUFunction(UKuroJsModelFunctionLibrary._ClassDefaultObjectPtr, UKuroJsModelFunctionLibrary.__SetCreatureDataComponentPbDataId_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06006317 RID: 25367 RVA: 0x0008D8A8 File Offset: 0x0008BAA8
		[SkipLocalsInit]
		public unsafe static void SetCreatureDataComponentEntityType(int EntityId, byte EntityType)
		{
			UKuroJsModelFunctionLibrary.__SetCreatureDataComponentEntityType_FunctionParams* ptr = stackalloc UKuroJsModelFunctionLibrary.__SetCreatureDataComponentEntityType_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroJsModelFunctionLibrary.__SetCreatureDataComponentEntityType_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroJsModelFunctionLibrary.__SetCreatureDataComponentEntityType_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			ptr->EntityType = EntityType;
			UnrealReflectionUtils.CallUFunction(UKuroJsModelFunctionLibrary._ClassDefaultObjectPtr, UKuroJsModelFunctionLibrary.__SetCreatureDataComponentEntityType_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06006318 RID: 25368 RVA: 0x0008D8F4 File Offset: 0x0008BAF4
		[SkipLocalsInit]
		public unsafe static void SetCharacterUnifiedStateComponentPositionState(int EntityId, byte PositionState)
		{
			UKuroJsModelFunctionLibrary.__SetCharacterUnifiedStateComponentPositionState_FunctionParams* ptr = stackalloc UKuroJsModelFunctionLibrary.__SetCharacterUnifiedStateComponentPositionState_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroJsModelFunctionLibrary.__SetCharacterUnifiedStateComponentPositionState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroJsModelFunctionLibrary.__SetCharacterUnifiedStateComponentPositionState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			ptr->PositionState = PositionState;
			UnrealReflectionUtils.CallUFunction(UKuroJsModelFunctionLibrary._ClassDefaultObjectPtr, UKuroJsModelFunctionLibrary.__SetCharacterUnifiedStateComponentPositionState_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06006319 RID: 25369 RVA: 0x0008D940 File Offset: 0x0008BB40
		[SkipLocalsInit]
		public unsafe static void SetCharacterUnifiedStateComponentMoveState(int EntityId, byte MoveState)
		{
			UKuroJsModelFunctionLibrary.__SetCharacterUnifiedStateComponentMoveState_FunctionParams* ptr = stackalloc UKuroJsModelFunctionLibrary.__SetCharacterUnifiedStateComponentMoveState_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroJsModelFunctionLibrary.__SetCharacterUnifiedStateComponentMoveState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroJsModelFunctionLibrary.__SetCharacterUnifiedStateComponentMoveState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			ptr->MoveState = MoveState;
			UnrealReflectionUtils.CallUFunction(UKuroJsModelFunctionLibrary._ClassDefaultObjectPtr, UKuroJsModelFunctionLibrary.__SetCharacterUnifiedStateComponentMoveState_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600631A RID: 25370 RVA: 0x0008D98C File Offset: 0x0008BB8C
		[SkipLocalsInit]
		public unsafe static void SetAiPerceptionDataAiSenseGroupLoseDelayRange(int AiPerceptionDataHandle, in FVector2D InValue)
		{
			UKuroJsModelFunctionLibrary.__SetAiPerceptionDataAiSenseGroupLoseDelayRange_FunctionParams* ptr = stackalloc UKuroJsModelFunctionLibrary.__SetAiPerceptionDataAiSenseGroupLoseDelayRange_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroJsModelFunctionLibrary.__SetAiPerceptionDataAiSenseGroupLoseDelayRange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroJsModelFunctionLibrary.__SetAiPerceptionDataAiSenseGroupLoseDelayRange_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AiPerceptionDataHandle = AiPerceptionDataHandle;
			ptr->InValue = InValue;
			UnrealReflectionUtils.CallUFunction(UKuroJsModelFunctionLibrary._ClassDefaultObjectPtr, UKuroJsModelFunctionLibrary.__SetAiPerceptionDataAiSenseGroupLoseDelayRange_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600631B RID: 25371 RVA: 0x0008D9E0 File Offset: 0x0008BBE0
		[SkipLocalsInit]
		public unsafe static void RemoveEntity(int EntityId)
		{
			UKuroJsModelFunctionLibrary.__RemoveEntity_FunctionParams* ptr = stackalloc UKuroJsModelFunctionLibrary.__RemoveEntity_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroJsModelFunctionLibrary.__RemoveEntity_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroJsModelFunctionLibrary.__RemoveEntity_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			UnrealReflectionUtils.CallUFunction(UKuroJsModelFunctionLibrary._ClassDefaultObjectPtr, UKuroJsModelFunctionLibrary.__RemoveEntity_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600631C RID: 25372 RVA: 0x0008DA28 File Offset: 0x0008BC28
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void InitializeEnvironment(UWorld World)
		{
			UKuroJsModelFunctionLibrary.__InitializeEnvironment_FunctionParams* ptr = stackalloc UKuroJsModelFunctionLibrary.__InitializeEnvironment_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroJsModelFunctionLibrary.__InitializeEnvironment_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroJsModelFunctionLibrary.__InitializeEnvironment_NativeFunctionPtr, (void*)ptr, 1);
			ptr->World = ((World != null) ? World.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UKuroJsModelFunctionLibrary._ClassDefaultObjectPtr, UKuroJsModelFunctionLibrary.__InitializeEnvironment_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600631D RID: 25373 RVA: 0x0008DA7C File Offset: 0x0008BC7C
		[SkipLocalsInit]
		public unsafe static void IncrementAiPerceptionDataWithAngleVerticalCount(int AiPerceptionDataHandle)
		{
			UKuroJsModelFunctionLibrary.__IncrementAiPerceptionDataWithAngleVerticalCount_FunctionParams* ptr = stackalloc UKuroJsModelFunctionLibrary.__IncrementAiPerceptionDataWithAngleVerticalCount_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroJsModelFunctionLibrary.__IncrementAiPerceptionDataWithAngleVerticalCount_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroJsModelFunctionLibrary.__IncrementAiPerceptionDataWithAngleVerticalCount_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AiPerceptionDataHandle = AiPerceptionDataHandle;
			UnrealReflectionUtils.CallUFunction(UKuroJsModelFunctionLibrary._ClassDefaultObjectPtr, UKuroJsModelFunctionLibrary.__IncrementAiPerceptionDataWithAngleVerticalCount_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600631E RID: 25374 RVA: 0x0008DAC4 File Offset: 0x0008BCC4
		[SkipLocalsInit]
		public unsafe static void IncrementAiPerceptionDataWithAngleHorizontalCount(int AiPerceptionDataHandle)
		{
			UKuroJsModelFunctionLibrary.__IncrementAiPerceptionDataWithAngleHorizontalCount_FunctionParams* ptr = stackalloc UKuroJsModelFunctionLibrary.__IncrementAiPerceptionDataWithAngleHorizontalCount_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroJsModelFunctionLibrary.__IncrementAiPerceptionDataWithAngleHorizontalCount_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroJsModelFunctionLibrary.__IncrementAiPerceptionDataWithAngleHorizontalCount_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AiPerceptionDataHandle = AiPerceptionDataHandle;
			UnrealReflectionUtils.CallUFunction(UKuroJsModelFunctionLibrary._ClassDefaultObjectPtr, UKuroJsModelFunctionLibrary.__IncrementAiPerceptionDataWithAngleHorizontalCount_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600631F RID: 25375 RVA: 0x0008DB0C File Offset: 0x0008BD0C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static AActor GetEntityActor(int EntityId)
		{
			UKuroJsModelFunctionLibrary.__GetEntityActor_FunctionParams* ptr = stackalloc UKuroJsModelFunctionLibrary.__GetEntityActor_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroJsModelFunctionLibrary.__GetEntityActor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroJsModelFunctionLibrary.__GetEntityActor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			UnrealReflectionUtils.CallUFunction(UKuroJsModelFunctionLibrary._ClassDefaultObjectPtr, UKuroJsModelFunctionLibrary.__GetEntityActor_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ptr->__Result);
		}

		// Token: 0x06006320 RID: 25376 RVA: 0x0008DB5C File Offset: 0x0008BD5C
		[SkipLocalsInit]
		public static void DestroyEnvironment()
		{
			UnrealReflectionUtils.CallUFunction(UKuroJsModelFunctionLibrary._ClassDefaultObjectPtr, UKuroJsModelFunctionLibrary.__DestroyEnvironment_NativeFunctionPtr, null);
		}

		// Token: 0x06006321 RID: 25377 RVA: 0x0008DB70 File Offset: 0x0008BD70
		[SkipLocalsInit]
		public unsafe static void DestroyAiPerceptionData(int AiPerceptionDataHandle)
		{
			UKuroJsModelFunctionLibrary.__DestroyAiPerceptionData_FunctionParams* ptr = stackalloc UKuroJsModelFunctionLibrary.__DestroyAiPerceptionData_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroJsModelFunctionLibrary.__DestroyAiPerceptionData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroJsModelFunctionLibrary.__DestroyAiPerceptionData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AiPerceptionDataHandle = AiPerceptionDataHandle;
			UnrealReflectionUtils.CallUFunction(UKuroJsModelFunctionLibrary._ClassDefaultObjectPtr, UKuroJsModelFunctionLibrary.__DestroyAiPerceptionData_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06006322 RID: 25378 RVA: 0x0008DBB8 File Offset: 0x0008BDB8
		[SkipLocalsInit]
		public unsafe static void DecrementAiPerceptionDataWithAngleVerticalCount(int AiPerceptionDataHandle)
		{
			UKuroJsModelFunctionLibrary.__DecrementAiPerceptionDataWithAngleVerticalCount_FunctionParams* ptr = stackalloc UKuroJsModelFunctionLibrary.__DecrementAiPerceptionDataWithAngleVerticalCount_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroJsModelFunctionLibrary.__DecrementAiPerceptionDataWithAngleVerticalCount_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroJsModelFunctionLibrary.__DecrementAiPerceptionDataWithAngleVerticalCount_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AiPerceptionDataHandle = AiPerceptionDataHandle;
			UnrealReflectionUtils.CallUFunction(UKuroJsModelFunctionLibrary._ClassDefaultObjectPtr, UKuroJsModelFunctionLibrary.__DecrementAiPerceptionDataWithAngleVerticalCount_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06006323 RID: 25379 RVA: 0x0008DC00 File Offset: 0x0008BE00
		[SkipLocalsInit]
		public unsafe static void DecrementAiPerceptionDataWithAngleHorizontalCount(int AiPerceptionDataHandle)
		{
			UKuroJsModelFunctionLibrary.__DecrementAiPerceptionDataWithAngleHorizontalCount_FunctionParams* ptr = stackalloc UKuroJsModelFunctionLibrary.__DecrementAiPerceptionDataWithAngleHorizontalCount_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroJsModelFunctionLibrary.__DecrementAiPerceptionDataWithAngleHorizontalCount_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroJsModelFunctionLibrary.__DecrementAiPerceptionDataWithAngleHorizontalCount_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AiPerceptionDataHandle = AiPerceptionDataHandle;
			UnrealReflectionUtils.CallUFunction(UKuroJsModelFunctionLibrary._ClassDefaultObjectPtr, UKuroJsModelFunctionLibrary.__DecrementAiPerceptionDataWithAngleHorizontalCount_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06006324 RID: 25380 RVA: 0x0008DC48 File Offset: 0x0008BE48
		[SkipLocalsInit]
		public unsafe static int CreateAiPerceptionData(int EntityId)
		{
			UKuroJsModelFunctionLibrary.__CreateAiPerceptionData_FunctionParams* ptr = stackalloc UKuroJsModelFunctionLibrary.__CreateAiPerceptionData_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroJsModelFunctionLibrary.__CreateAiPerceptionData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroJsModelFunctionLibrary.__CreateAiPerceptionData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			UnrealReflectionUtils.CallUFunction(UKuroJsModelFunctionLibrary._ClassDefaultObjectPtr, UKuroJsModelFunctionLibrary.__CreateAiPerceptionData_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06006325 RID: 25381 RVA: 0x0008DC94 File Offset: 0x0008BE94
		[SkipLocalsInit]
		public unsafe static void AddEntity(int EntityId)
		{
			UKuroJsModelFunctionLibrary.__AddEntity_FunctionParams* ptr = stackalloc UKuroJsModelFunctionLibrary.__AddEntity_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroJsModelFunctionLibrary.__AddEntity_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroJsModelFunctionLibrary.__AddEntity_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			UnrealReflectionUtils.CallUFunction(UKuroJsModelFunctionLibrary._ClassDefaultObjectPtr, UKuroJsModelFunctionLibrary.__AddEntity_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06006326 RID: 25382 RVA: 0x0008DCD9 File Offset: 0x0008BED9
		static UKuroJsModelFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroJsModelFunctionLibrary");
		}

		// Token: 0x06006327 RID: 25383 RVA: 0x0008DCE7 File Offset: 0x0008BEE7
		protected UKuroJsModelFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040029D6 RID: 10710
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroJsModelFunctionLibrary";

		// Token: 0x040029D7 RID: 10711
		private static IntPtr _ClassPtr;

		// Token: 0x040029D8 RID: 10712
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040029D9 RID: 10713
		private static IntPtr __UpdateEntityActor_NativeFunctionPtr;

		// Token: 0x040029DA RID: 10714
		private static IntPtr __SetCreatureDataComponentPbDataId_NativeFunctionPtr;

		// Token: 0x040029DB RID: 10715
		private static IntPtr __SetCreatureDataComponentEntityType_NativeFunctionPtr;

		// Token: 0x040029DC RID: 10716
		private static IntPtr __SetCharacterUnifiedStateComponentPositionState_NativeFunctionPtr;

		// Token: 0x040029DD RID: 10717
		private static IntPtr __SetCharacterUnifiedStateComponentMoveState_NativeFunctionPtr;

		// Token: 0x040029DE RID: 10718
		private static IntPtr __SetAiPerceptionDataAiSenseGroupLoseDelayRange_NativeFunctionPtr;

		// Token: 0x040029DF RID: 10719
		private static IntPtr __RemoveEntity_NativeFunctionPtr;

		// Token: 0x040029E0 RID: 10720
		private static IntPtr __InitializeEnvironment_NativeFunctionPtr;

		// Token: 0x040029E1 RID: 10721
		private static IntPtr __IncrementAiPerceptionDataWithAngleVerticalCount_NativeFunctionPtr;

		// Token: 0x040029E2 RID: 10722
		private static IntPtr __IncrementAiPerceptionDataWithAngleHorizontalCount_NativeFunctionPtr;

		// Token: 0x040029E3 RID: 10723
		private static IntPtr __GetEntityActor_NativeFunctionPtr;

		// Token: 0x040029E4 RID: 10724
		private static IntPtr __DestroyEnvironment_NativeFunctionPtr;

		// Token: 0x040029E5 RID: 10725
		private static IntPtr __DestroyAiPerceptionData_NativeFunctionPtr;

		// Token: 0x040029E6 RID: 10726
		private static IntPtr __DecrementAiPerceptionDataWithAngleVerticalCount_NativeFunctionPtr;

		// Token: 0x040029E7 RID: 10727
		private static IntPtr __DecrementAiPerceptionDataWithAngleHorizontalCount_NativeFunctionPtr;

		// Token: 0x040029E8 RID: 10728
		private static IntPtr __CreateAiPerceptionData_NativeFunctionPtr;

		// Token: 0x040029E9 RID: 10729
		private static IntPtr __AddEntity_NativeFunctionPtr;

		// Token: 0x02000ADC RID: 2780
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __UpdateEntityActor_FunctionParams
		{
			// Token: 0x04005B5A RID: 23386
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x04005B5B RID: 23387
			[FieldOffset(8)]
			public IntPtr Actor;
		}

		// Token: 0x02000ADD RID: 2781
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetCreatureDataComponentPbDataId_FunctionParams
		{
			// Token: 0x04005B5C RID: 23388
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x04005B5D RID: 23389
			[FieldOffset(4)]
			public uint PbDataId;
		}

		// Token: 0x02000ADE RID: 2782
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetCreatureDataComponentEntityType_FunctionParams
		{
			// Token: 0x04005B5E RID: 23390
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x04005B5F RID: 23391
			[FieldOffset(4)]
			public byte EntityType;
		}

		// Token: 0x02000ADF RID: 2783
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetCharacterUnifiedStateComponentPositionState_FunctionParams
		{
			// Token: 0x04005B60 RID: 23392
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x04005B61 RID: 23393
			[FieldOffset(4)]
			public byte PositionState;
		}

		// Token: 0x02000AE0 RID: 2784
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetCharacterUnifiedStateComponentMoveState_FunctionParams
		{
			// Token: 0x04005B62 RID: 23394
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x04005B63 RID: 23395
			[FieldOffset(4)]
			public byte MoveState;
		}

		// Token: 0x02000AE1 RID: 2785
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __SetAiPerceptionDataAiSenseGroupLoseDelayRange_FunctionParams
		{
			// Token: 0x04005B64 RID: 23396
			[FieldOffset(0)]
			public int AiPerceptionDataHandle;

			// Token: 0x04005B65 RID: 23397
			[FieldOffset(4)]
			public FVector2D InValue;
		}

		// Token: 0x02000AE2 RID: 2786
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __RemoveEntity_FunctionParams
		{
			// Token: 0x04005B66 RID: 23398
			[FieldOffset(0)]
			public int EntityId;
		}

		// Token: 0x02000AE3 RID: 2787
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __InitializeEnvironment_FunctionParams
		{
			// Token: 0x04005B67 RID: 23399
			[FieldOffset(0)]
			public IntPtr World;
		}

		// Token: 0x02000AE4 RID: 2788
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __IncrementAiPerceptionDataWithAngleVerticalCount_FunctionParams
		{
			// Token: 0x04005B68 RID: 23400
			[FieldOffset(0)]
			public int AiPerceptionDataHandle;
		}

		// Token: 0x02000AE5 RID: 2789
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __IncrementAiPerceptionDataWithAngleHorizontalCount_FunctionParams
		{
			// Token: 0x04005B69 RID: 23401
			[FieldOffset(0)]
			public int AiPerceptionDataHandle;
		}

		// Token: 0x02000AE6 RID: 2790
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetEntityActor_FunctionParams
		{
			// Token: 0x04005B6A RID: 23402
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x04005B6B RID: 23403
			[FieldOffset(8)]
			public IntPtr __Result;
		}

		// Token: 0x02000AE7 RID: 2791
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __DestroyAiPerceptionData_FunctionParams
		{
			// Token: 0x04005B6C RID: 23404
			[FieldOffset(0)]
			public int AiPerceptionDataHandle;
		}

		// Token: 0x02000AE8 RID: 2792
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __DecrementAiPerceptionDataWithAngleVerticalCount_FunctionParams
		{
			// Token: 0x04005B6D RID: 23405
			[FieldOffset(0)]
			public int AiPerceptionDataHandle;
		}

		// Token: 0x02000AE9 RID: 2793
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __DecrementAiPerceptionDataWithAngleHorizontalCount_FunctionParams
		{
			// Token: 0x04005B6E RID: 23406
			[FieldOffset(0)]
			public int AiPerceptionDataHandle;
		}

		// Token: 0x02000AEA RID: 2794
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __CreateAiPerceptionData_FunctionParams
		{
			// Token: 0x04005B6F RID: 23407
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x04005B70 RID: 23408
			[FieldOffset(4)]
			public int __Result;
		}

		// Token: 0x02000AEB RID: 2795
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __AddEntity_FunctionParams
		{
			// Token: 0x04005B71 RID: 23409
			[FieldOffset(0)]
			public int EntityId;
		}
	}
}
