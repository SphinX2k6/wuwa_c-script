using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B6E RID: 7022
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialParameterCollectionManager")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UKuroMaterialParameterCollectionManager : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601A932 RID: 108850 RVA: 0x00272DD2 File Offset: 0x00270FD2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroMaterialParameterCollectionManager._ClassPtr;
		}

		// Token: 0x0601A933 RID: 108851 RVA: 0x00272DE0 File Offset: 0x00270FE0
		public UKuroMaterialParameterCollectionManager() : this(BuiltinUtils.AllocNativeUObject(UKuroMaterialParameterCollectionManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601A934 RID: 108852 RVA: 0x00272E08 File Offset: 0x00271008
		[NullableContext(1)]
		public UKuroMaterialParameterCollectionManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroMaterialParameterCollectionManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601A935 RID: 108853 RVA: 0x00272E3C File Offset: 0x0027103C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetVectorParameterValueTimeCurve(UObject WorldContextObject, UMaterialParameterCollection Collection, FName ParameterName, FLinearColor ParameterValueTarget, FLinearColor ParameterValueStart, float Duration, UWorld World, bool UseStartVal)
		{
			UKuroMaterialParameterCollectionManager.__SetVectorParameterValueTimeCurve_FunctionParams* ptr = stackalloc UKuroMaterialParameterCollectionManager.__SetVectorParameterValueTimeCurve_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UKuroMaterialParameterCollectionManager.__SetVectorParameterValueTimeCurve_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroMaterialParameterCollectionManager.__SetVectorParameterValueTimeCurve_NativeFunctionPtr, (void*)ptr, 1);
			ptr->WorldContextObject = ((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
			ptr->Collection = ((Collection != null) ? Collection.NativePtr : IntPtr.Zero);
			ptr->ParameterName = ParameterName;
			ptr->ParameterValueTarget = ParameterValueTarget;
			ptr->ParameterValueStart = ParameterValueStart;
			ptr->Duration = Duration;
			ptr->World = ((World != null) ? World.NativePtr : IntPtr.Zero);
			ptr->UseStartVal = UseStartVal;
			UnrealReflectionUtils.CallUFunction(UKuroMaterialParameterCollectionManager._ClassDefaultObjectPtr, UKuroMaterialParameterCollectionManager.__SetVectorParameterValueTimeCurve_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601A936 RID: 108854 RVA: 0x00272EE8 File Offset: 0x002710E8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetScalarParameterValueTimeCurve(UObject WorldContextObject, UMaterialParameterCollection Collection, FName ParameterName, float ParameterValueTarget, float ParameterValueStart, float Duration, UWorld World, bool UseStartVal)
		{
			UKuroMaterialParameterCollectionManager.__SetScalarParameterValueTimeCurve_FunctionParams* ptr = stackalloc UKuroMaterialParameterCollectionManager.__SetScalarParameterValueTimeCurve_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(UKuroMaterialParameterCollectionManager.__SetScalarParameterValueTimeCurve_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroMaterialParameterCollectionManager.__SetScalarParameterValueTimeCurve_NativeFunctionPtr, (void*)ptr, 1);
			ptr->WorldContextObject = ((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
			ptr->Collection = ((Collection != null) ? Collection.NativePtr : IntPtr.Zero);
			ptr->ParameterName = ParameterName;
			ptr->ParameterValueTarget = ParameterValueTarget;
			ptr->ParameterValueStart = ParameterValueStart;
			ptr->Duration = Duration;
			ptr->World = ((World != null) ? World.NativePtr : IntPtr.Zero);
			ptr->UseStartVal = UseStartVal;
			UnrealReflectionUtils.CallUFunction(UKuroMaterialParameterCollectionManager._ClassDefaultObjectPtr, UKuroMaterialParameterCollectionManager.__SetScalarParameterValueTimeCurve_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601A937 RID: 108855 RVA: 0x00272F91 File Offset: 0x00271191
		static UKuroMaterialParameterCollectionManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialParameterCollectionManager");
		}

		// Token: 0x0601A938 RID: 108856 RVA: 0x00272F9F File Offset: 0x0027119F
		protected UKuroMaterialParameterCollectionManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E633 RID: 58931
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialParameterCollectionManager";

		// Token: 0x0400E634 RID: 58932
		private static IntPtr _ClassPtr;

		// Token: 0x0400E635 RID: 58933
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E636 RID: 58934
		private static IntPtr __SetVectorParameterValueTimeCurve_NativeFunctionPtr;

		// Token: 0x0400E637 RID: 58935
		private static IntPtr __SetScalarParameterValueTimeCurve_NativeFunctionPtr;

		// Token: 0x02003159 RID: 12633
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetVectorParameterValueTimeCurve_FunctionParams
		{
			// Token: 0x04016F70 RID: 94064
			[FieldOffset(0)]
			public IntPtr WorldContextObject;

			// Token: 0x04016F71 RID: 94065
			[FieldOffset(8)]
			public IntPtr Collection;

			// Token: 0x04016F72 RID: 94066
			[FieldOffset(16)]
			public FName ParameterName;

			// Token: 0x04016F73 RID: 94067
			[FieldOffset(28)]
			public FLinearColor ParameterValueTarget;

			// Token: 0x04016F74 RID: 94068
			[FieldOffset(44)]
			public FLinearColor ParameterValueStart;

			// Token: 0x04016F75 RID: 94069
			[FieldOffset(60)]
			public float Duration;

			// Token: 0x04016F76 RID: 94070
			[FieldOffset(64)]
			public IntPtr World;

			// Token: 0x04016F77 RID: 94071
			[FieldOffset(72)]
			public bool UseStartVal;
		}

		// Token: 0x0200315A RID: 12634
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __SetScalarParameterValueTimeCurve_FunctionParams
		{
			// Token: 0x04016F78 RID: 94072
			[FieldOffset(0)]
			public IntPtr WorldContextObject;

			// Token: 0x04016F79 RID: 94073
			[FieldOffset(8)]
			public IntPtr Collection;

			// Token: 0x04016F7A RID: 94074
			[FieldOffset(16)]
			public FName ParameterName;

			// Token: 0x04016F7B RID: 94075
			[FieldOffset(28)]
			public float ParameterValueTarget;

			// Token: 0x04016F7C RID: 94076
			[FieldOffset(32)]
			public float ParameterValueStart;

			// Token: 0x04016F7D RID: 94077
			[FieldOffset(36)]
			public float Duration;

			// Token: 0x04016F7E RID: 94078
			[FieldOffset(40)]
			public IntPtr World;

			// Token: 0x04016F7F RID: 94079
			[FieldOffset(48)]
			public bool UseStartVal;
		}
	}
}
