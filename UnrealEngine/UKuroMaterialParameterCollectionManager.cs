using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004D3 RID: 1235
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialParameterCollectionManager")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UKuroMaterialParameterCollectionManager : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600737E RID: 29566 RVA: 0x000A9486 File Offset: 0x000A7686
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroMaterialParameterCollectionManager._ClassPtr;
		}

		// Token: 0x0600737F RID: 29567 RVA: 0x000A9494 File Offset: 0x000A7694
		public UKuroMaterialParameterCollectionManager() : this(BuiltinUtils.AllocNativeUObject(UKuroMaterialParameterCollectionManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007380 RID: 29568 RVA: 0x000A94BC File Offset: 0x000A76BC
		[NullableContext(1)]
		public UKuroMaterialParameterCollectionManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroMaterialParameterCollectionManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06007381 RID: 29569 RVA: 0x000A94F0 File Offset: 0x000A76F0
		[NullableContext(2)]
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(UKuroMaterialParameterCollectionManager._ClassDefaultObjectPtr, UKuroMaterialParameterCollectionManager.__SetVectorParameterValueTimeCurve_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06007382 RID: 29570 RVA: 0x000A9598 File Offset: 0x000A7798
		[NullableContext(2)]
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(UKuroMaterialParameterCollectionManager._ClassDefaultObjectPtr, UKuroMaterialParameterCollectionManager.__SetScalarParameterValueTimeCurve_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06007383 RID: 29571 RVA: 0x000A9640 File Offset: 0x000A7840
		static UKuroMaterialParameterCollectionManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialParameterCollectionManager");
		}

		// Token: 0x06007384 RID: 29572 RVA: 0x000A964E File Offset: 0x000A784E
		protected UKuroMaterialParameterCollectionManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400317B RID: 12667
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialParameterCollectionManager";

		// Token: 0x0400317C RID: 12668
		private static IntPtr _ClassPtr;

		// Token: 0x0400317D RID: 12669
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400317E RID: 12670
		private static IntPtr __SetVectorParameterValueTimeCurve_NativeFunctionPtr;

		// Token: 0x0400317F RID: 12671
		private static IntPtr __SetScalarParameterValueTimeCurve_NativeFunctionPtr;

		// Token: 0x02000C17 RID: 3095
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetVectorParameterValueTimeCurve_FunctionParams
		{
			// Token: 0x04005E4E RID: 24142
			[FieldOffset(0)]
			public IntPtr WorldContextObject;

			// Token: 0x04005E4F RID: 24143
			[FieldOffset(8)]
			public IntPtr Collection;

			// Token: 0x04005E50 RID: 24144
			[FieldOffset(16)]
			public FName ParameterName;

			// Token: 0x04005E51 RID: 24145
			[FieldOffset(28)]
			public FLinearColor ParameterValueTarget;

			// Token: 0x04005E52 RID: 24146
			[FieldOffset(44)]
			public FLinearColor ParameterValueStart;

			// Token: 0x04005E53 RID: 24147
			[FieldOffset(60)]
			public float Duration;

			// Token: 0x04005E54 RID: 24148
			[FieldOffset(64)]
			public IntPtr World;

			// Token: 0x04005E55 RID: 24149
			[FieldOffset(72)]
			public bool UseStartVal;
		}

		// Token: 0x02000C18 RID: 3096
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __SetScalarParameterValueTimeCurve_FunctionParams
		{
			// Token: 0x04005E56 RID: 24150
			[FieldOffset(0)]
			public IntPtr WorldContextObject;

			// Token: 0x04005E57 RID: 24151
			[FieldOffset(8)]
			public IntPtr Collection;

			// Token: 0x04005E58 RID: 24152
			[FieldOffset(16)]
			public FName ParameterName;

			// Token: 0x04005E59 RID: 24153
			[FieldOffset(28)]
			public float ParameterValueTarget;

			// Token: 0x04005E5A RID: 24154
			[FieldOffset(32)]
			public float ParameterValueStart;

			// Token: 0x04005E5B RID: 24155
			[FieldOffset(36)]
			public float Duration;

			// Token: 0x04005E5C RID: 24156
			[FieldOffset(40)]
			public IntPtr World;

			// Token: 0x04005E5D RID: 24157
			[FieldOffset(48)]
			public bool UseStartVal;
		}
	}
}
