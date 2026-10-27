using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EAD RID: 3757
	[UnrealObjectPath("/Script/Engine.MeshVertexPainterKismetLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UMeshVertexPainterKismetLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600CB57 RID: 52055 RVA: 0x001285AF File Offset: 0x001267AF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMeshVertexPainterKismetLibrary._ClassPtr;
		}

		// Token: 0x0600CB58 RID: 52056 RVA: 0x001285BC File Offset: 0x001267BC
		public UMeshVertexPainterKismetLibrary() : this(BuiltinUtils.AllocNativeUObject(UMeshVertexPainterKismetLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600CB59 RID: 52057 RVA: 0x001285E4 File Offset: 0x001267E4
		[NullableContext(1)]
		public UMeshVertexPainterKismetLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMeshVertexPainterKismetLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600CB5A RID: 52058 RVA: 0x00128618 File Offset: 0x00126818
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RemovePaintedVertices(UStaticMeshComponent StaticMeshComponent)
		{
			UMeshVertexPainterKismetLibrary.__RemovePaintedVertices_FunctionParams* ptr = stackalloc UMeshVertexPainterKismetLibrary.__RemovePaintedVertices_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UMeshVertexPainterKismetLibrary.__RemovePaintedVertices_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMeshVertexPainterKismetLibrary.__RemovePaintedVertices_NativeFunctionPtr, (void*)ptr, 1);
			ptr->StaticMeshComponent = ((StaticMeshComponent != null) ? StaticMeshComponent.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UMeshVertexPainterKismetLibrary._ClassDefaultObjectPtr, UMeshVertexPainterKismetLibrary.__RemovePaintedVertices_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0600CB5B RID: 52059 RVA: 0x00128670 File Offset: 0x00126870
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void PaintVerticesSingleColor(UStaticMeshComponent StaticMeshComponent, in FLinearColor FillColor, bool bConvertToSRGB = true)
		{
			UMeshVertexPainterKismetLibrary.__PaintVerticesSingleColor_FunctionParams* ptr = stackalloc UMeshVertexPainterKismetLibrary.__PaintVerticesSingleColor_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UMeshVertexPainterKismetLibrary.__PaintVerticesSingleColor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMeshVertexPainterKismetLibrary.__PaintVerticesSingleColor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->StaticMeshComponent = ((StaticMeshComponent != null) ? StaticMeshComponent.NativePtr : IntPtr.Zero);
			ptr->FillColor = FillColor;
			ptr->bConvertToSRGB = bConvertToSRGB;
			UnrealReflectionUtils.CallUFunction(UMeshVertexPainterKismetLibrary._ClassDefaultObjectPtr, UMeshVertexPainterKismetLibrary.__PaintVerticesSingleColor_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0600CB5C RID: 52060 RVA: 0x001286D8 File Offset: 0x001268D8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void PaintVerticesLerpAlongAxis(UStaticMeshComponent StaticMeshComponent, in FLinearColor StartColor, in FLinearColor EndColor, EVertexPaintAxis Axis, bool bConvertToSRGB = true)
		{
			UMeshVertexPainterKismetLibrary.__PaintVerticesLerpAlongAxis_FunctionParams* ptr = stackalloc UMeshVertexPainterKismetLibrary.__PaintVerticesLerpAlongAxis_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UMeshVertexPainterKismetLibrary.__PaintVerticesLerpAlongAxis_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMeshVertexPainterKismetLibrary.__PaintVerticesLerpAlongAxis_NativeFunctionPtr, (void*)ptr, 1);
			ptr->StaticMeshComponent = ((StaticMeshComponent != null) ? StaticMeshComponent.NativePtr : IntPtr.Zero);
			ptr->StartColor = StartColor;
			ptr->EndColor = EndColor;
			ptr->Axis = Axis;
			ptr->bConvertToSRGB = bConvertToSRGB;
			UnrealReflectionUtils.CallUFunction(UMeshVertexPainterKismetLibrary._ClassDefaultObjectPtr, UMeshVertexPainterKismetLibrary.__PaintVerticesLerpAlongAxis_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0600CB5D RID: 52061 RVA: 0x00128754 File Offset: 0x00126954
		static UMeshVertexPainterKismetLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MeshVertexPainterKismetLibrary");
		}

		// Token: 0x0600CB5E RID: 52062 RVA: 0x00128762 File Offset: 0x00126962
		protected UMeshVertexPainterKismetLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006D8F RID: 28047
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MeshVertexPainterKismetLibrary";

		// Token: 0x04006D90 RID: 28048
		private static IntPtr _ClassPtr;

		// Token: 0x04006D91 RID: 28049
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006D92 RID: 28050
		private static IntPtr __RemovePaintedVertices_NativeFunctionPtr;

		// Token: 0x04006D93 RID: 28051
		private static IntPtr __PaintVerticesSingleColor_NativeFunctionPtr;

		// Token: 0x04006D94 RID: 28052
		private static IntPtr __PaintVerticesLerpAlongAxis_NativeFunctionPtr;

		// Token: 0x02002D4A RID: 11594
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __RemovePaintedVertices_FunctionParams
		{
			// Token: 0x04016755 RID: 91989
			[FieldOffset(0)]
			public IntPtr StaticMeshComponent;
		}

		// Token: 0x02002D4B RID: 11595
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __PaintVerticesSingleColor_FunctionParams
		{
			// Token: 0x04016756 RID: 91990
			[FieldOffset(0)]
			public IntPtr StaticMeshComponent;

			// Token: 0x04016757 RID: 91991
			[FieldOffset(8)]
			public FLinearColor FillColor;

			// Token: 0x04016758 RID: 91992
			[FieldOffset(24)]
			public bool bConvertToSRGB;
		}

		// Token: 0x02002D4C RID: 11596
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __PaintVerticesLerpAlongAxis_FunctionParams
		{
			// Token: 0x04016759 RID: 91993
			[FieldOffset(0)]
			public IntPtr StaticMeshComponent;

			// Token: 0x0401675A RID: 91994
			[FieldOffset(8)]
			public FLinearColor StartColor;

			// Token: 0x0401675B RID: 91995
			[FieldOffset(24)]
			public FLinearColor EndColor;

			// Token: 0x0401675C RID: 91996
			[FieldOffset(40)]
			public EVertexPaintAxis Axis;

			// Token: 0x0401675D RID: 91997
			[FieldOffset(41)]
			public bool bConvertToSRGB;
		}
	}
}
