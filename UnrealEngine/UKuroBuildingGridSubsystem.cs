using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016BA RID: 5818
	[UnrealObjectPath("/Script/KuroBuildingGridSystem.KuroBuildingGridSubsystem")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UKuroBuildingGridSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015173 RID: 86387 RVA: 0x001EFFC4 File Offset: 0x001EE1C4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroBuildingGridSubsystem._ClassPtr;
		}

		// Token: 0x06015174 RID: 86388 RVA: 0x001EFFD0 File Offset: 0x001EE1D0
		public UKuroBuildingGridSubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroBuildingGridSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015175 RID: 86389 RVA: 0x001EFFF8 File Offset: 0x001EE1F8
		[NullableContext(1)]
		public UKuroBuildingGridSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroBuildingGridSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700536F RID: 21359
		// (get) Token: 0x06015176 RID: 86390 RVA: 0x001F002B File Offset: 0x001EE22B
		// (set) Token: 0x06015177 RID: 86391 RVA: 0x001F003F File Offset: 0x001EE23F
		[Nullable(2)]
		public unsafe UKuroBuildingGridPersistentPlaceholder PersistentPlaceholder
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroBuildingGridPersistentPlaceholder>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroBuildingGridSubsystem.__PropertyOffset_PersistentPlaceholder);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroBuildingGridSubsystem.__PropertyOffset_PersistentPlaceholder, value);
			}
		}

		// Token: 0x06015178 RID: 86392 RVA: 0x001F0054 File Offset: 0x001EE254
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool K2_RaycastGrid(UObject WorldContextObject, in FVectorDouble Start, in FVectorDouble End, ref FKuroBuildingGridRaycastResult OutResult)
		{
			UKuroBuildingGridSubsystem.__K2_RaycastGrid_FunctionParams* ptr = stackalloc UKuroBuildingGridSubsystem.__K2_RaycastGrid_FunctionParams[(UIntPtr)191] + 15L / (long)sizeof(UKuroBuildingGridSubsystem.__K2_RaycastGrid_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroBuildingGridSubsystem.__K2_RaycastGrid_NativeFunctionPtr, (void*)ptr, 1);
			ptr->WorldContextObject = ((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
			ptr->Start = Start;
			ptr->End = End;
			if (OutResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroBuildingGridRaycastResult.StaticStruct(), &ptr->OutResult, OutResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(UKuroBuildingGridSubsystem._ClassDefaultObjectPtr, UKuroBuildingGridSubsystem.__K2_RaycastGrid_NativeFunctionPtr, (void*)ptr, 0);
			if (OutResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroBuildingGridRaycastResult.StaticStruct(), OutResult.NativePtr, &ptr->OutResult, 1, false);
			}
			return ptr->__Result;
		}

		// Token: 0x06015179 RID: 86393 RVA: 0x001F0114 File Offset: 0x001EE314
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool K2_ProjectPointToGrid(UObject WorldContextObject, in FVectorDouble InPoint, in FVector InNormal, ref FKuroBuildingGridRaycastResult OutResult)
		{
			UKuroBuildingGridSubsystem.__K2_ProjectPointToGrid_FunctionParams* ptr = stackalloc UKuroBuildingGridSubsystem.__K2_ProjectPointToGrid_FunctionParams[(UIntPtr)175] + 15L / (long)sizeof(UKuroBuildingGridSubsystem.__K2_ProjectPointToGrid_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroBuildingGridSubsystem.__K2_ProjectPointToGrid_NativeFunctionPtr, (void*)ptr, 1);
			ptr->WorldContextObject = ((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
			ptr->InPoint = InPoint;
			ptr->InNormal = InNormal;
			if (OutResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroBuildingGridRaycastResult.StaticStruct(), &ptr->OutResult, OutResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(UKuroBuildingGridSubsystem._ClassDefaultObjectPtr, UKuroBuildingGridSubsystem.__K2_ProjectPointToGrid_NativeFunctionPtr, (void*)ptr, 0);
			if (OutResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroBuildingGridRaycastResult.StaticStruct(), OutResult.NativePtr, &ptr->OutResult, 1, false);
			}
			return ptr->__Result;
		}

		// Token: 0x0601517A RID: 86394 RVA: 0x001F01D4 File Offset: 0x001EE3D4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void K2_ForEachIntersectingCell(UObject WorldContextObject, in FVectorDouble InPoint, in double InRadius, bool UseDirMask, int DirMask, FKuroBuildingGridIntersectingCellDelegate Func)
		{
			UKuroBuildingGridSubsystem.__K2_ForEachIntersectingCell_FunctionParams* ptr = stackalloc UKuroBuildingGridSubsystem.__K2_ForEachIntersectingCell_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(UKuroBuildingGridSubsystem.__K2_ForEachIntersectingCell_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroBuildingGridSubsystem.__K2_ForEachIntersectingCell_NativeFunctionPtr, (void*)ptr, 1);
			ptr->WorldContextObject = ((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
			ptr->InPoint = InPoint;
			ptr->InRadius = InRadius;
			ptr->UseDirMask = UseDirMask;
			ptr->DirMask = DirMask;
			FScriptDelegate.NativeCopy(&ptr->Func, (Func != null) ? Func.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroBuildingGridSubsystem._ClassDefaultObjectPtr, UKuroBuildingGridSubsystem.__K2_ForEachIntersectingCell_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroBuildingGridSubsystem.__K2_ForEachIntersectingCell_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601517B RID: 86395 RVA: 0x001F0278 File Offset: 0x001EE478
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static AKuroBuildingGrid K2_FindBuildingGrid(UObject WorldContextObject, [Nullable(1)] string InGuidString)
		{
			UKuroBuildingGridSubsystem.__K2_FindBuildingGrid_FunctionParams* ptr = stackalloc UKuroBuildingGridSubsystem.__K2_FindBuildingGrid_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroBuildingGridSubsystem.__K2_FindBuildingGrid_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroBuildingGridSubsystem.__K2_FindBuildingGrid_NativeFunctionPtr, (void*)ptr, 1);
			ptr->WorldContextObject = ((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
			FString.CopyFrom((void*)(&ptr->InGuidString), InGuidString);
			UnrealReflectionUtils.CallUFunction(UKuroBuildingGridSubsystem._ClassDefaultObjectPtr, UKuroBuildingGridSubsystem.__K2_FindBuildingGrid_NativeFunctionPtr, (void*)ptr, 0);
			AKuroBuildingGrid orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AKuroBuildingGrid>(ptr->__Result);
			UnrealReflectionUtils.DestroyStruct(UKuroBuildingGridSubsystem.__K2_FindBuildingGrid_NativeFunctionPtr, (void*)ptr, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x0601517C RID: 86396 RVA: 0x001F02F8 File Offset: 0x001EE4F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static float GetGridCellSize()
		{
			UKuroBuildingGridSubsystem.__GetGridCellSize_FunctionParams* ptr = stackalloc UKuroBuildingGridSubsystem.__GetGridCellSize_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroBuildingGridSubsystem.__GetGridCellSize_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroBuildingGridSubsystem.__GetGridCellSize_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroBuildingGridSubsystem._ClassDefaultObjectPtr, UKuroBuildingGridSubsystem.__GetGridCellSize_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601517D RID: 86397 RVA: 0x001F033D File Offset: 0x001EE53D
		static UKuroBuildingGridSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBuildingGridSystem.KuroBuildingGridSubsystem");
		}

		// Token: 0x0601517E RID: 86398 RVA: 0x001F034B File Offset: 0x001EE54B
		protected UKuroBuildingGridSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B7A2 RID: 47010
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBuildingGridSystem.KuroBuildingGridSubsystem";

		// Token: 0x0400B7A3 RID: 47011
		private static IntPtr _ClassPtr;

		// Token: 0x0400B7A4 RID: 47012
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B7A5 RID: 47013
		internal static int __PropertyOffset_PersistentPlaceholder;

		// Token: 0x0400B7A6 RID: 47014
		private static IntPtr __K2_RaycastGrid_NativeFunctionPtr;

		// Token: 0x0400B7A7 RID: 47015
		private static IntPtr __K2_ProjectPointToGrid_NativeFunctionPtr;

		// Token: 0x0400B7A8 RID: 47016
		private static IntPtr __K2_ForEachIntersectingCell_NativeFunctionPtr;

		// Token: 0x0400B7A9 RID: 47017
		private static IntPtr __K2_FindBuildingGrid_NativeFunctionPtr;

		// Token: 0x0400B7AA RID: 47018
		private static IntPtr __GetGridCellSize_NativeFunctionPtr;

		// Token: 0x02002EED RID: 12013
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 176)]
		protected ref struct __K2_RaycastGrid_FunctionParams
		{
			// Token: 0x04016A13 RID: 92691
			[FieldOffset(0)]
			public IntPtr WorldContextObject;

			// Token: 0x04016A14 RID: 92692
			[FieldOffset(8)]
			public FVectorDouble Start;

			// Token: 0x04016A15 RID: 92693
			[FieldOffset(32)]
			public FVectorDouble End;

			// Token: 0x04016A16 RID: 92694
			[FieldOffset(64)]
			public byte OutResult;

			// Token: 0x04016A17 RID: 92695
			[FieldOffset(160)]
			public bool __Result;
		}

		// Token: 0x02002EEE RID: 12014
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 160)]
		protected ref struct __K2_ProjectPointToGrid_FunctionParams
		{
			// Token: 0x04016A18 RID: 92696
			[FieldOffset(0)]
			public IntPtr WorldContextObject;

			// Token: 0x04016A19 RID: 92697
			[FieldOffset(8)]
			public FVectorDouble InPoint;

			// Token: 0x04016A1A RID: 92698
			[FieldOffset(32)]
			public FVector InNormal;

			// Token: 0x04016A1B RID: 92699
			[FieldOffset(48)]
			public byte OutResult;

			// Token: 0x04016A1C RID: 92700
			[FieldOffset(144)]
			public bool __Result;
		}

		// Token: 0x02002EEF RID: 12015
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __K2_ForEachIntersectingCell_FunctionParams
		{
			// Token: 0x04016A1D RID: 92701
			[FieldOffset(0)]
			public IntPtr WorldContextObject;

			// Token: 0x04016A1E RID: 92702
			[FieldOffset(8)]
			public FVectorDouble InPoint;

			// Token: 0x04016A1F RID: 92703
			[FieldOffset(32)]
			public double InRadius;

			// Token: 0x04016A20 RID: 92704
			[FieldOffset(40)]
			public bool UseDirMask;

			// Token: 0x04016A21 RID: 92705
			[FieldOffset(44)]
			public int DirMask;

			// Token: 0x04016A22 RID: 92706
			[FieldOffset(48)]
			public byte Func;
		}

		// Token: 0x02002EF0 RID: 12016
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __K2_FindBuildingGrid_FunctionParams
		{
			// Token: 0x04016A23 RID: 92707
			[FieldOffset(0)]
			public IntPtr WorldContextObject;

			// Token: 0x04016A24 RID: 92708
			[FieldOffset(8)]
			public FString InGuidString;

			// Token: 0x04016A25 RID: 92709
			[FieldOffset(24)]
			public IntPtr __Result;
		}

		// Token: 0x02002EF1 RID: 12017
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetGridCellSize_FunctionParams
		{
			// Token: 0x04016A26 RID: 92710
			[FieldOffset(0)]
			public float __Result;
		}
	}
}
