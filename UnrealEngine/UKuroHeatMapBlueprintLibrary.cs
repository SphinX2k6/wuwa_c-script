using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B1E RID: 6942
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroHeatMapBlueprintLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroHeatMapBlueprintLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601A1E8 RID: 106984 RVA: 0x00268C56 File Offset: 0x00266E56
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroHeatMapBlueprintLibrary._ClassPtr;
		}

		// Token: 0x0601A1E9 RID: 106985 RVA: 0x00268C64 File Offset: 0x00266E64
		public UKuroHeatMapBlueprintLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroHeatMapBlueprintLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601A1EA RID: 106986 RVA: 0x00268C8C File Offset: 0x00266E8C
		[NullableContext(1)]
		public UKuroHeatMapBlueprintLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroHeatMapBlueprintLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601A1EB RID: 106987 RVA: 0x00268CC0 File Offset: 0x00266EC0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UMaterialInstanceDynamic GetOrCreateTransientDMI(UMaterialInstanceDynamic InDMI, FName InDMIName, UMaterialInterface InMaterialInterface)
		{
			UKuroHeatMapBlueprintLibrary.__GetOrCreateTransientDMI_FunctionParams* ptr = stackalloc UKuroHeatMapBlueprintLibrary.__GetOrCreateTransientDMI_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroHeatMapBlueprintLibrary.__GetOrCreateTransientDMI_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroHeatMapBlueprintLibrary.__GetOrCreateTransientDMI_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InDMI = ((InDMI != null) ? InDMI.NativePtr : IntPtr.Zero);
			ptr->InDMIName = InDMIName;
			ptr->InMaterialInterface = ((InMaterialInterface != null) ? InMaterialInterface.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UKuroHeatMapBlueprintLibrary._ClassDefaultObjectPtr, UKuroHeatMapBlueprintLibrary.__GetOrCreateTransientDMI_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(ptr->__Result);
		}

		// Token: 0x0601A1EC RID: 106988 RVA: 0x00268D3D File Offset: 0x00266F3D
		static UKuroHeatMapBlueprintLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroHeatMapBlueprintLibrary");
		}

		// Token: 0x0601A1ED RID: 106989 RVA: 0x00268D4B File Offset: 0x00266F4B
		protected UKuroHeatMapBlueprintLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E2EC RID: 58092
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroHeatMapBlueprintLibrary";

		// Token: 0x0400E2ED RID: 58093
		private static IntPtr _ClassPtr;

		// Token: 0x0400E2EE RID: 58094
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E2EF RID: 58095
		private static IntPtr __GetOrCreateTransientDMI_NativeFunctionPtr;

		// Token: 0x02003147 RID: 12615
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __GetOrCreateTransientDMI_FunctionParams
		{
			// Token: 0x04016F59 RID: 94041
			[FieldOffset(0)]
			public IntPtr InDMI;

			// Token: 0x04016F5A RID: 94042
			[FieldOffset(8)]
			public FName InDMIName;

			// Token: 0x04016F5B RID: 94043
			[FieldOffset(24)]
			public IntPtr InMaterialInterface;

			// Token: 0x04016F5C RID: 94044
			[FieldOffset(32)]
			public IntPtr __Result;
		}
	}
}
