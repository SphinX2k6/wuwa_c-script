using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200261D RID: 9757
	[UnrealObjectPath("/Script/OpacityMicroMap.OMMBlueprintLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UOMMBlueprintLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024477 RID: 148599 RVA: 0x0035B662 File Offset: 0x00359862
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UOMMBlueprintLibrary._ClassPtr;
		}

		// Token: 0x06024478 RID: 148600 RVA: 0x0035B670 File Offset: 0x00359870
		public UOMMBlueprintLibrary() : this(BuiltinUtils.AllocNativeUObject(UOMMBlueprintLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024479 RID: 148601 RVA: 0x0035B698 File Offset: 0x00359898
		[NullableContext(1)]
		public UOMMBlueprintLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UOMMBlueprintLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602447A RID: 148602 RVA: 0x0035B6CC File Offset: 0x003598CC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RecreateStaticRaytracedMeshes(UObject WorldContextObject, bool ForceDisableOpacityMicromapsInput)
		{
			UOMMBlueprintLibrary.__RecreateStaticRaytracedMeshes_FunctionParams* ptr = stackalloc UOMMBlueprintLibrary.__RecreateStaticRaytracedMeshes_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UOMMBlueprintLibrary.__RecreateStaticRaytracedMeshes_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UOMMBlueprintLibrary.__RecreateStaticRaytracedMeshes_NativeFunctionPtr, (void*)ptr, 1);
			ptr->WorldContextObject = ((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
			ptr->ForceDisableOpacityMicromapsInput = ForceDisableOpacityMicromapsInput;
			UnrealReflectionUtils.CallUFunction(UOMMBlueprintLibrary._ClassDefaultObjectPtr, UOMMBlueprintLibrary.__RecreateStaticRaytracedMeshes_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602447B RID: 148603 RVA: 0x0035B728 File Offset: 0x00359928
		static UOMMBlueprintLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/OpacityMicroMap.OMMBlueprintLibrary");
		}

		// Token: 0x0602447C RID: 148604 RVA: 0x0035B736 File Offset: 0x00359936
		protected UOMMBlueprintLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013761 RID: 79713
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/OpacityMicroMap.OMMBlueprintLibrary";

		// Token: 0x04013762 RID: 79714
		private static IntPtr _ClassPtr;

		// Token: 0x04013763 RID: 79715
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013764 RID: 79716
		private static IntPtr __RecreateStaticRaytracedMeshes_NativeFunctionPtr;

		// Token: 0x02003680 RID: 13952
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __RecreateStaticRaytracedMeshes_FunctionParams
		{
			// Token: 0x04017759 RID: 96089
			[FieldOffset(0)]
			public IntPtr WorldContextObject;

			// Token: 0x0401775A RID: 96090
			[FieldOffset(8)]
			public bool ForceDisableOpacityMicromapsInput;
		}
	}
}
