using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000887 RID: 2183
	[UnrealObjectPath("/Script/Engine.BakedBonePrefabBlueprintLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UBakedBonePrefabBlueprintLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600776D RID: 30573 RVA: 0x000AB036 File Offset: 0x000A9236
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBakedBonePrefabBlueprintLibrary._ClassPtr;
		}

		// Token: 0x0600776E RID: 30574 RVA: 0x000AB044 File Offset: 0x000A9244
		public UBakedBonePrefabBlueprintLibrary() : this(BuiltinUtils.AllocNativeUObject(UBakedBonePrefabBlueprintLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600776F RID: 30575 RVA: 0x000AB06C File Offset: 0x000A926C
		[NullableContext(1)]
		public UBakedBonePrefabBlueprintLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBakedBonePrefabBlueprintLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06007770 RID: 30576 RVA: 0x000AB0A0 File Offset: 0x000A92A0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SpawnActorsFromPrefabAsset(UObject InWorldContextObject, UBakedBonePrefabAsset InPrefabAsset)
		{
			UBakedBonePrefabBlueprintLibrary.__SpawnActorsFromPrefabAsset_FunctionParams* ptr = stackalloc UBakedBonePrefabBlueprintLibrary.__SpawnActorsFromPrefabAsset_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UBakedBonePrefabBlueprintLibrary.__SpawnActorsFromPrefabAsset_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBakedBonePrefabBlueprintLibrary.__SpawnActorsFromPrefabAsset_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InWorldContextObject = ((InWorldContextObject != null) ? InWorldContextObject.NativePtr : IntPtr.Zero);
			ptr->InPrefabAsset = ((InPrefabAsset != null) ? InPrefabAsset.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UBakedBonePrefabBlueprintLibrary._ClassDefaultObjectPtr, UBakedBonePrefabBlueprintLibrary.__SpawnActorsFromPrefabAsset_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06007771 RID: 30577 RVA: 0x000AB10C File Offset: 0x000A930C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void ExportActorToPrefabAsset([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> InSourceActors, string InAssetDir, string InAssetName)
		{
			UBakedBonePrefabBlueprintLibrary.__ExportActorToPrefabAsset_FunctionParams* ptr = stackalloc UBakedBonePrefabBlueprintLibrary.__ExportActorToPrefabAsset_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UBakedBonePrefabBlueprintLibrary.__ExportActorToPrefabAsset_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBakedBonePrefabBlueprintLibrary.__ExportActorToPrefabAsset_NativeFunctionPtr, (void*)ptr, 1);
			TArray<AActor> tarray = InSourceActors;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InSourceActors);
			}
			FString.CopyFrom((void*)(&ptr->InAssetDir), InAssetDir);
			FString.CopyFrom((void*)(&ptr->InAssetName), InAssetName);
			UnrealReflectionUtils.CallUFunction(UBakedBonePrefabBlueprintLibrary._ClassDefaultObjectPtr, UBakedBonePrefabBlueprintLibrary.__ExportActorToPrefabAsset_NativeFunctionPtr, (void*)ptr, 0);
			TArray<AActor> tarray2 = InSourceActors;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InSourceActors);
			}
			UnrealReflectionUtils.DestroyStruct(UBakedBonePrefabBlueprintLibrary.__ExportActorToPrefabAsset_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007772 RID: 30578 RVA: 0x000AB19E File Offset: 0x000A939E
		static UBakedBonePrefabBlueprintLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BakedBonePrefabBlueprintLibrary");
		}

		// Token: 0x06007773 RID: 30579 RVA: 0x000AB1AC File Offset: 0x000A93AC
		protected UBakedBonePrefabBlueprintLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003958 RID: 14680
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.BakedBonePrefabBlueprintLibrary";

		// Token: 0x04003959 RID: 14681
		private static IntPtr _ClassPtr;

		// Token: 0x0400395A RID: 14682
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400395B RID: 14683
		private static IntPtr __SpawnActorsFromPrefabAsset_NativeFunctionPtr;

		// Token: 0x0400395C RID: 14684
		private static IntPtr __ExportActorToPrefabAsset_NativeFunctionPtr;

		// Token: 0x02002C97 RID: 11415
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SpawnActorsFromPrefabAsset_FunctionParams
		{
			// Token: 0x040165EF RID: 91631
			[FieldOffset(0)]
			public IntPtr InWorldContextObject;

			// Token: 0x040165F0 RID: 91632
			[FieldOffset(8)]
			public IntPtr InPrefabAsset;
		}

		// Token: 0x02002C98 RID: 11416
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __ExportActorToPrefabAsset_FunctionParams
		{
			// Token: 0x040165F1 RID: 91633
			[FieldOffset(0)]
			public byte InSourceActors;

			// Token: 0x040165F2 RID: 91634
			[FieldOffset(16)]
			public FString InAssetDir;

			// Token: 0x040165F3 RID: 91635
			[FieldOffset(32)]
			public FString InAssetName;
		}
	}
}
