using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EC8 RID: 7880
	[UnrealObjectPath("/Script/KuroUtility.KuroPolypartition")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroPolypartition : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DE68 RID: 122472 RVA: 0x002C3A22 File Offset: 0x002C1C22
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPolypartition._ClassPtr;
		}

		// Token: 0x0601DE69 RID: 122473 RVA: 0x002C3A30 File Offset: 0x002C1C30
		public UKuroPolypartition() : this(BuiltinUtils.AllocNativeUObject(UKuroPolypartition.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DE6A RID: 122474 RVA: 0x002C3A58 File Offset: 0x002C1C58
		[NullableContext(1)]
		public UKuroPolypartition(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPolypartition.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601DE6B RID: 122475 RVA: 0x002C3A8C File Offset: 0x002C1C8C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static TArray<int> BuildTriangleByVertex2D([Nullable(2)] TArray<FVector2D> points)
		{
			UKuroPolypartition.__BuildTriangleByVertex2D_FunctionParams* ptr = stackalloc UKuroPolypartition.__BuildTriangleByVertex2D_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroPolypartition.__BuildTriangleByVertex2D_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroPolypartition.__BuildTriangleByVertex2D_NativeFunctionPtr, (void*)ptr, 1);
			if (points != null)
			{
				points.CopyTo(&ptr->points, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(UKuroPolypartition._ClassDefaultObjectPtr, UKuroPolypartition.__BuildTriangleByVertex2D_NativeFunctionPtr, (void*)ptr, 0);
			TArray<int> result = new TArray<int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UKuroPolypartition.__BuildTriangleByVertex2D_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601DE6C RID: 122476 RVA: 0x002C3B03 File Offset: 0x002C1D03
		static UKuroPolypartition()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroPolypartition");
		}

		// Token: 0x0601DE6D RID: 122477 RVA: 0x002C3B11 File Offset: 0x002C1D11
		protected UKuroPolypartition(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401030B RID: 66315
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroPolypartition";

		// Token: 0x0401030C RID: 66316
		private static IntPtr _ClassPtr;

		// Token: 0x0401030D RID: 66317
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401030E RID: 66318
		private static IntPtr __BuildTriangleByVertex2D_NativeFunctionPtr;

		// Token: 0x0200331A RID: 13082
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BuildTriangleByVertex2D_FunctionParams
		{
			// Token: 0x040171F4 RID: 94708
			[FieldOffset(0)]
			public byte points;

			// Token: 0x040171F5 RID: 94709
			[FieldOffset(16)]
			public byte __Result;
		}
	}
}
