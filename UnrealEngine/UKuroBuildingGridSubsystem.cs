using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000321 RID: 801
	[UnrealObjectPath("/Script/KuroBuildingGridSystem.KuroBuildingGridSubsystem")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UKuroBuildingGridSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005448 RID: 21576 RVA: 0x00075EA2 File Offset: 0x000740A2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroBuildingGridSubsystem._ClassPtr;
		}

		// Token: 0x06005449 RID: 21577 RVA: 0x00075EB0 File Offset: 0x000740B0
		public UKuroBuildingGridSubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroBuildingGridSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600544A RID: 21578 RVA: 0x00075ED8 File Offset: 0x000740D8
		[NullableContext(1)]
		public UKuroBuildingGridSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroBuildingGridSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600544B RID: 21579 RVA: 0x00075F0C File Offset: 0x0007410C
		[NullableContext(2)]
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(UKuroBuildingGridSubsystem._ClassDefaultObjectPtr, UKuroBuildingGridSubsystem.__K2_RaycastGrid_NativeFunctionPtr, (void*)ptr);
			if (OutResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroBuildingGridRaycastResult.StaticStruct(), OutResult.NativePtr, &ptr->OutResult, 1, false);
			}
			return ptr->__Result;
		}

		// Token: 0x0600544C RID: 21580 RVA: 0x00075FCC File Offset: 0x000741CC
		[NullableContext(2)]
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(UKuroBuildingGridSubsystem._ClassDefaultObjectPtr, UKuroBuildingGridSubsystem.__K2_ProjectPointToGrid_NativeFunctionPtr, (void*)ptr);
			if (OutResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroBuildingGridRaycastResult.StaticStruct(), OutResult.NativePtr, &ptr->OutResult, 1, false);
			}
			return ptr->__Result;
		}

		// Token: 0x0600544D RID: 21581 RVA: 0x0007608C File Offset: 0x0007428C
		[NullableContext(2)]
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(UKuroBuildingGridSubsystem._ClassDefaultObjectPtr, UKuroBuildingGridSubsystem.__K2_ForEachIntersectingCell_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroBuildingGridSubsystem.__K2_ForEachIntersectingCell_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600544E RID: 21582 RVA: 0x00076130 File Offset: 0x00074330
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static AKuroBuildingGrid K2_FindBuildingGrid(UObject WorldContextObject, [Nullable(1)] string InGuidString)
		{
			UKuroBuildingGridSubsystem.__K2_FindBuildingGrid_FunctionParams* ptr = stackalloc UKuroBuildingGridSubsystem.__K2_FindBuildingGrid_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroBuildingGridSubsystem.__K2_FindBuildingGrid_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroBuildingGridSubsystem.__K2_FindBuildingGrid_NativeFunctionPtr, (void*)ptr, 1);
			ptr->WorldContextObject = ((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
			FString.CopyFrom((void*)(&ptr->InGuidString), InGuidString);
			UnrealReflectionUtils.CallUFunction(UKuroBuildingGridSubsystem._ClassDefaultObjectPtr, UKuroBuildingGridSubsystem.__K2_FindBuildingGrid_NativeFunctionPtr, (void*)ptr);
			AKuroBuildingGrid orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AKuroBuildingGrid>(ptr->__Result);
			UnrealReflectionUtils.DestroyStruct(UKuroBuildingGridSubsystem.__K2_FindBuildingGrid_NativeFunctionPtr, (void*)ptr, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x0600544F RID: 21583 RVA: 0x000761B0 File Offset: 0x000743B0
		[SkipLocalsInit]
		public unsafe static float GetGridCellSize()
		{
			UKuroBuildingGridSubsystem.__GetGridCellSize_FunctionParams* ptr = stackalloc UKuroBuildingGridSubsystem.__GetGridCellSize_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroBuildingGridSubsystem.__GetGridCellSize_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroBuildingGridSubsystem.__GetGridCellSize_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroBuildingGridSubsystem._ClassDefaultObjectPtr, UKuroBuildingGridSubsystem.__GetGridCellSize_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06005450 RID: 21584 RVA: 0x000761F4 File Offset: 0x000743F4
		static UKuroBuildingGridSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBuildingGridSystem.KuroBuildingGridSubsystem");
		}

		// Token: 0x06005451 RID: 21585 RVA: 0x00076202 File Offset: 0x00074402
		protected UKuroBuildingGridSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400226C RID: 8812
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBuildingGridSystem.KuroBuildingGridSubsystem";

		// Token: 0x0400226D RID: 8813
		private static IntPtr _ClassPtr;

		// Token: 0x0400226E RID: 8814
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400226F RID: 8815
		private static IntPtr __K2_RaycastGrid_NativeFunctionPtr;

		// Token: 0x04002270 RID: 8816
		private static IntPtr __K2_ProjectPointToGrid_NativeFunctionPtr;

		// Token: 0x04002271 RID: 8817
		private static IntPtr __K2_ForEachIntersectingCell_NativeFunctionPtr;

		// Token: 0x04002272 RID: 8818
		private static IntPtr __K2_FindBuildingGrid_NativeFunctionPtr;

		// Token: 0x04002273 RID: 8819
		private static IntPtr __GetGridCellSize_NativeFunctionPtr;

		// Token: 0x02000A22 RID: 2594
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 176)]
		protected ref struct __K2_RaycastGrid_FunctionParams
		{
			// Token: 0x040059E7 RID: 23015
			[FieldOffset(0)]
			public IntPtr WorldContextObject;

			// Token: 0x040059E8 RID: 23016
			[FieldOffset(8)]
			public FVectorDouble Start;

			// Token: 0x040059E9 RID: 23017
			[FieldOffset(32)]
			public FVectorDouble End;

			// Token: 0x040059EA RID: 23018
			[FieldOffset(64)]
			public byte OutResult;

			// Token: 0x040059EB RID: 23019
			[FieldOffset(160)]
			public bool __Result;
		}

		// Token: 0x02000A23 RID: 2595
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 160)]
		protected ref struct __K2_ProjectPointToGrid_FunctionParams
		{
			// Token: 0x040059EC RID: 23020
			[FieldOffset(0)]
			public IntPtr WorldContextObject;

			// Token: 0x040059ED RID: 23021
			[FieldOffset(8)]
			public FVectorDouble InPoint;

			// Token: 0x040059EE RID: 23022
			[FieldOffset(32)]
			public FVector InNormal;

			// Token: 0x040059EF RID: 23023
			[FieldOffset(48)]
			public byte OutResult;

			// Token: 0x040059F0 RID: 23024
			[FieldOffset(144)]
			public bool __Result;
		}

		// Token: 0x02000A24 RID: 2596
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __K2_ForEachIntersectingCell_FunctionParams
		{
			// Token: 0x040059F1 RID: 23025
			[FieldOffset(0)]
			public IntPtr WorldContextObject;

			// Token: 0x040059F2 RID: 23026
			[FieldOffset(8)]
			public FVectorDouble InPoint;

			// Token: 0x040059F3 RID: 23027
			[FieldOffset(32)]
			public double InRadius;

			// Token: 0x040059F4 RID: 23028
			[FieldOffset(40)]
			public bool UseDirMask;

			// Token: 0x040059F5 RID: 23029
			[FieldOffset(44)]
			public int DirMask;

			// Token: 0x040059F6 RID: 23030
			[FieldOffset(48)]
			public byte Func;
		}

		// Token: 0x02000A25 RID: 2597
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __K2_FindBuildingGrid_FunctionParams
		{
			// Token: 0x040059F7 RID: 23031
			[FieldOffset(0)]
			public IntPtr WorldContextObject;

			// Token: 0x040059F8 RID: 23032
			[FieldOffset(8)]
			public FString InGuidString;

			// Token: 0x040059F9 RID: 23033
			[FieldOffset(24)]
			public IntPtr __Result;
		}

		// Token: 0x02000A26 RID: 2598
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetGridCellSize_FunctionParams
		{
			// Token: 0x040059FA RID: 23034
			[FieldOffset(0)]
			public float __Result;
		}
	}
}
