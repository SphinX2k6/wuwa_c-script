using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BAB RID: 7083
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroSceneInteractionMatConManager")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UKuroSceneInteractionMatConManager : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B171 RID: 110961 RVA: 0x0027EA81 File Offset: 0x0027CC81
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSceneInteractionMatConManager._ClassPtr;
		}

		// Token: 0x0601B172 RID: 110962 RVA: 0x0027EA90 File Offset: 0x0027CC90
		public UKuroSceneInteractionMatConManager() : this(BuiltinUtils.AllocNativeUObject(UKuroSceneInteractionMatConManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B173 RID: 110963 RVA: 0x0027EAB8 File Offset: 0x0027CCB8
		[NullableContext(1)]
		public UKuroSceneInteractionMatConManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSceneInteractionMatConManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601B174 RID: 110964 RVA: 0x0027EAEC File Offset: 0x0027CCEC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetMatConData(AActor Actor, UKuroSceneInteractionMatConDataCache DataCache)
		{
			UKuroSceneInteractionMatConManager.__SetMatConData_FunctionParams* ptr = stackalloc UKuroSceneInteractionMatConManager.__SetMatConData_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroSceneInteractionMatConManager.__SetMatConData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneInteractionMatConManager.__SetMatConData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			ptr->DataCache = ((DataCache != null) ? DataCache.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UKuroSceneInteractionMatConManager._ClassDefaultObjectPtr, UKuroSceneInteractionMatConManager.__SetMatConData_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601B175 RID: 110965 RVA: 0x0027EB58 File Offset: 0x0027CD58
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RemoveMatConDataWithStaticMesh(UStaticMeshComponent StaticMeshComponent)
		{
			UKuroSceneInteractionMatConManager.__RemoveMatConDataWithStaticMesh_FunctionParams* ptr = stackalloc UKuroSceneInteractionMatConManager.__RemoveMatConDataWithStaticMesh_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroSceneInteractionMatConManager.__RemoveMatConDataWithStaticMesh_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneInteractionMatConManager.__RemoveMatConDataWithStaticMesh_NativeFunctionPtr, (void*)ptr, 1);
			ptr->StaticMeshComponent = ((StaticMeshComponent != null) ? StaticMeshComponent.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UKuroSceneInteractionMatConManager._ClassDefaultObjectPtr, UKuroSceneInteractionMatConManager.__RemoveMatConDataWithStaticMesh_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601B176 RID: 110966 RVA: 0x0027EBB0 File Offset: 0x0027CDB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RemoveMatConData(int Uid)
		{
			UKuroSceneInteractionMatConManager.__RemoveMatConData_FunctionParams* ptr = stackalloc UKuroSceneInteractionMatConManager.__RemoveMatConData_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroSceneInteractionMatConManager.__RemoveMatConData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneInteractionMatConManager.__RemoveMatConData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Uid = Uid;
			UnrealReflectionUtils.CallUFunction(UKuroSceneInteractionMatConManager._ClassDefaultObjectPtr, UKuroSceneInteractionMatConManager.__RemoveMatConData_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601B177 RID: 110967 RVA: 0x0027EBF6 File Offset: 0x0027CDF6
		static UKuroSceneInteractionMatConManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroSceneInteractionMatConManager");
		}

		// Token: 0x0601B178 RID: 110968 RVA: 0x0027EC04 File Offset: 0x0027CE04
		protected UKuroSceneInteractionMatConManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E95E RID: 59742
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroSceneInteractionMatConManager";

		// Token: 0x0400E95F RID: 59743
		private static IntPtr _ClassPtr;

		// Token: 0x0400E960 RID: 59744
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E961 RID: 59745
		private static IntPtr __SetMatConData_NativeFunctionPtr;

		// Token: 0x0400E962 RID: 59746
		private static IntPtr __RemoveMatConDataWithStaticMesh_NativeFunctionPtr;

		// Token: 0x0400E963 RID: 59747
		private static IntPtr __RemoveMatConData_NativeFunctionPtr;

		// Token: 0x02003173 RID: 12659
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetMatConData_FunctionParams
		{
			// Token: 0x04016FA3 RID: 94115
			[FieldOffset(0)]
			public IntPtr Actor;

			// Token: 0x04016FA4 RID: 94116
			[FieldOffset(8)]
			public IntPtr DataCache;
		}

		// Token: 0x02003174 RID: 12660
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __RemoveMatConDataWithStaticMesh_FunctionParams
		{
			// Token: 0x04016FA5 RID: 94117
			[FieldOffset(0)]
			public IntPtr StaticMeshComponent;
		}

		// Token: 0x02003175 RID: 12661
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __RemoveMatConData_FunctionParams
		{
			// Token: 0x04016FA6 RID: 94118
			[FieldOffset(0)]
			public int Uid;
		}
	}
}
