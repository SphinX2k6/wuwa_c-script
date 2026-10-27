using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016B6 RID: 5814
	[UnrealObjectPath("/Script/KuroBuildingGridSystem.KuroBuildingGridPlaceholderInterface")]
	public interface IKuroBuildingGridPlaceholderInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06015147 RID: 86343
		int InterfaceOffset();

		// Token: 0x06015148 RID: 86344 RVA: 0x001EFB2B File Offset: 0x001EDD2B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void Unoccupied()
		{
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKuroBuildingGridPlaceholderInterface_ReflectionImplementationFields.__Unoccupied_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06015149 RID: 86345 RVA: 0x001EFB40 File Offset: 0x001EDD40
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void Occupied(AKuroBuildingGrid InGrid, in FKuroBuildingGridCellVector InCoords, in float InDegree)
		{
			IKuroBuildingGridPlaceholderInterface.__Occupied_FunctionParams* ptr = stackalloc IKuroBuildingGridPlaceholderInterface.__Occupied_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(IKuroBuildingGridPlaceholderInterface.__Occupied_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKuroBuildingGridPlaceholderInterface_ReflectionImplementationFields.__Occupied_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InGrid = ((InGrid != null) ? InGrid.NativePtr : IntPtr.Zero);
			ptr->InCoords = InCoords;
			ptr->InDegree = InDegree;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKuroBuildingGridPlaceholderInterface_ReflectionImplementationFields.__Occupied_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601514A RID: 86346 RVA: 0x001EFBAC File Offset: 0x001EDDAC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe FKuroBuildingGridCellVector GetSizeByDegree(ref float Degree)
		{
			IKuroBuildingGridPlaceholderInterface.__GetSizeByDegree_FunctionParams* ptr = stackalloc IKuroBuildingGridPlaceholderInterface.__GetSizeByDegree_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(IKuroBuildingGridPlaceholderInterface.__GetSizeByDegree_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKuroBuildingGridPlaceholderInterface_ReflectionImplementationFields.__GetSizeByDegree_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Degree = Degree;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKuroBuildingGridPlaceholderInterface_ReflectionImplementationFields.__GetSizeByDegree_NativeFunctionPtr, (void*)ptr, 0);
			Degree = ptr->Degree;
			return ptr->__Result;
		}

		// Token: 0x0601514B RID: 86347 RVA: 0x001EFC04 File Offset: 0x001EDE04
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe FKuroBuildingGridCellVector GetSize()
		{
			IKuroBuildingGridPlaceholderInterface.__GetSize_FunctionParams* ptr = stackalloc IKuroBuildingGridPlaceholderInterface.__GetSize_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IKuroBuildingGridPlaceholderInterface.__GetSize_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKuroBuildingGridPlaceholderInterface_ReflectionImplementationFields.__GetSize_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKuroBuildingGridPlaceholderInterface_ReflectionImplementationFields.__GetSize_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601514C RID: 86348 RVA: 0x001EFC4C File Offset: 0x001EDE4C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool CanBeRemoved()
		{
			IKuroBuildingGridPlaceholderInterface.__CanBeRemoved_FunctionParams* ptr = stackalloc IKuroBuildingGridPlaceholderInterface.__CanBeRemoved_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(IKuroBuildingGridPlaceholderInterface.__CanBeRemoved_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IKuroBuildingGridPlaceholderInterface_ReflectionImplementationFields.__CanBeRemoved_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, IKuroBuildingGridPlaceholderInterface_ReflectionImplementationFields.__CanBeRemoved_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0400B78F RID: 46991
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroBuildingGridSystem.KuroBuildingGridPlaceholderInterface";

		// Token: 0x02002EE9 RID: 12009
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Occupied_FunctionParams
		{
			// Token: 0x04016A0C RID: 92684
			[FieldOffset(0)]
			public IntPtr InGrid;

			// Token: 0x04016A0D RID: 92685
			[FieldOffset(8)]
			public FKuroBuildingGridCellVector InCoords;

			// Token: 0x04016A0E RID: 92686
			[FieldOffset(16)]
			public float InDegree;
		}

		// Token: 0x02002EEA RID: 12010
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetSizeByDegree_FunctionParams
		{
			// Token: 0x04016A0F RID: 92687
			[FieldOffset(0)]
			public float Degree;

			// Token: 0x04016A10 RID: 92688
			[FieldOffset(4)]
			public FKuroBuildingGridCellVector __Result;
		}

		// Token: 0x02002EEB RID: 12011
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetSize_FunctionParams
		{
			// Token: 0x04016A11 RID: 92689
			[FieldOffset(0)]
			public FKuroBuildingGridCellVector __Result;
		}

		// Token: 0x02002EEC RID: 12012
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __CanBeRemoved_FunctionParams
		{
			// Token: 0x04016A12 RID: 92690
			[FieldOffset(0)]
			public bool __Result;
		}
	}
}
