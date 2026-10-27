using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000370 RID: 880
	[UnrealObjectPath("/Script/AudioMaterialPlugin.AudioMaterialBlueprint")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UAudioMaterialBlueprint : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003054 RID: 12372 RVA: 0x0004AD73 File Offset: 0x00048F73
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAudioMaterialBlueprint._ClassPtr;
		}

		// Token: 0x06003055 RID: 12373 RVA: 0x0004AD80 File Offset: 0x00048F80
		public UAudioMaterialBlueprint() : this(BuiltinUtils.AllocNativeUObject(UAudioMaterialBlueprint.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003056 RID: 12374 RVA: 0x0004ADA8 File Offset: 0x00048FA8
		[NullableContext(1)]
		public UAudioMaterialBlueprint(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAudioMaterialBlueprint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06003057 RID: 12375 RVA: 0x0004ADDC File Offset: 0x00048FDC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static byte GetMaterialID(in FVector Position)
		{
			UAudioMaterialBlueprint.__GetMaterialID_FunctionParams* ptr = stackalloc UAudioMaterialBlueprint.__GetMaterialID_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UAudioMaterialBlueprint.__GetMaterialID_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAudioMaterialBlueprint.__GetMaterialID_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Position = Position;
			UnrealReflectionUtils.CallUFunction(UAudioMaterialBlueprint._ClassDefaultObjectPtr, UAudioMaterialBlueprint.__GetMaterialID_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06003058 RID: 12376 RVA: 0x0004AE2D File Offset: 0x0004902D
		static UAudioMaterialBlueprint()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AudioMaterialPlugin.AudioMaterialBlueprint");
		}

		// Token: 0x06003059 RID: 12377 RVA: 0x0004AE3B File Offset: 0x0004903B
		protected UAudioMaterialBlueprint(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001510 RID: 5392
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AudioMaterialPlugin.AudioMaterialBlueprint";

		// Token: 0x04001511 RID: 5393
		private static IntPtr _ClassPtr;

		// Token: 0x04001512 RID: 5394
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001513 RID: 5395
		private static IntPtr __GetMaterialID_NativeFunctionPtr;

		// Token: 0x02002BFE RID: 11262
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetMaterialID_FunctionParams
		{
			// Token: 0x040164FD RID: 91389
			[FieldOffset(0)]
			public FVector Position;

			// Token: 0x040164FE RID: 91390
			[FieldOffset(12)]
			public byte __Result;
		}
	}
}
