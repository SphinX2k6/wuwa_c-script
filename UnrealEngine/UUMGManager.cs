using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002683 RID: 9859
	[UnrealObjectPath("/Script/ReactUMG.UMGManager")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UUMGManager : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060249D3 RID: 149971 RVA: 0x00363444 File Offset: 0x00361644
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUMGManager._ClassPtr;
		}

		// Token: 0x060249D4 RID: 149972 RVA: 0x00363450 File Offset: 0x00361650
		public UUMGManager() : this(BuiltinUtils.AllocNativeUObject(UUMGManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060249D5 RID: 149973 RVA: 0x00363478 File Offset: 0x00361678
		[NullableContext(1)]
		public UUMGManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUMGManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060249D6 RID: 149974 RVA: 0x003634AC File Offset: 0x003616AC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SynchronizeWidgetProperties(UWidget Widget)
		{
			UUMGManager.__SynchronizeWidgetProperties_FunctionParams* ptr = stackalloc UUMGManager.__SynchronizeWidgetProperties_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UUMGManager.__SynchronizeWidgetProperties_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UUMGManager.__SynchronizeWidgetProperties_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Widget = ((Widget != null) ? Widget.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UUMGManager._ClassDefaultObjectPtr, UUMGManager.__SynchronizeWidgetProperties_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060249D7 RID: 149975 RVA: 0x00363504 File Offset: 0x00361704
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SynchronizeSlotProperties(UPanelSlot Slot)
		{
			UUMGManager.__SynchronizeSlotProperties_FunctionParams* ptr = stackalloc UUMGManager.__SynchronizeSlotProperties_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UUMGManager.__SynchronizeSlotProperties_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UUMGManager.__SynchronizeSlotProperties_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Slot = ((Slot != null) ? Slot.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UUMGManager._ClassDefaultObjectPtr, UUMGManager.__SynchronizeSlotProperties_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060249D8 RID: 149976 RVA: 0x0036355C File Offset: 0x0036175C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UUserWidget CreateWidget(UWorld World, UClassStackOnlyPtr Class)
		{
			UUMGManager.__CreateWidget_FunctionParams* ptr = stackalloc UUMGManager.__CreateWidget_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UUMGManager.__CreateWidget_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UUMGManager.__CreateWidget_NativeFunctionPtr, (void*)ptr, 1);
			ptr->World = ((World != null) ? World.NativePtr : IntPtr.Zero);
			ptr->Class = Class;
			UnrealReflectionUtils.CallUFunction(UUMGManager._ClassDefaultObjectPtr, UUMGManager.__CreateWidget_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUserWidget>(ptr->__Result);
		}

		// Token: 0x060249D9 RID: 149977 RVA: 0x003635C4 File Offset: 0x003617C4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UReactWidget CreateReactWidget(UWorld World)
		{
			UUMGManager.__CreateReactWidget_FunctionParams* ptr = stackalloc UUMGManager.__CreateReactWidget_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UUMGManager.__CreateReactWidget_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UUMGManager.__CreateReactWidget_NativeFunctionPtr, (void*)ptr, 1);
			ptr->World = ((World != null) ? World.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UUMGManager._ClassDefaultObjectPtr, UUMGManager.__CreateReactWidget_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UReactWidget>(ptr->__Result);
		}

		// Token: 0x060249DA RID: 149978 RVA: 0x00363624 File Offset: 0x00361824
		static UUMGManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ReactUMG.UMGManager");
		}

		// Token: 0x060249DB RID: 149979 RVA: 0x00363632 File Offset: 0x00361832
		protected UUMGManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013ADF RID: 80607
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ReactUMG.UMGManager";

		// Token: 0x04013AE0 RID: 80608
		private static IntPtr _ClassPtr;

		// Token: 0x04013AE1 RID: 80609
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013AE2 RID: 80610
		private static IntPtr __SynchronizeWidgetProperties_NativeFunctionPtr;

		// Token: 0x04013AE3 RID: 80611
		private static IntPtr __SynchronizeSlotProperties_NativeFunctionPtr;

		// Token: 0x04013AE4 RID: 80612
		private static IntPtr __CreateWidget_NativeFunctionPtr;

		// Token: 0x04013AE5 RID: 80613
		private static IntPtr __CreateReactWidget_NativeFunctionPtr;

		// Token: 0x02003690 RID: 13968
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SynchronizeWidgetProperties_FunctionParams
		{
			// Token: 0x04017780 RID: 96128
			[FieldOffset(0)]
			public IntPtr Widget;
		}

		// Token: 0x02003691 RID: 13969
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SynchronizeSlotProperties_FunctionParams
		{
			// Token: 0x04017781 RID: 96129
			[FieldOffset(0)]
			public IntPtr Slot;
		}

		// Token: 0x02003692 RID: 13970
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __CreateWidget_FunctionParams
		{
			// Token: 0x04017782 RID: 96130
			[FieldOffset(0)]
			public IntPtr World;

			// Token: 0x04017783 RID: 96131
			[FieldOffset(8)]
			public UClassStackOnlyPtr Class;

			// Token: 0x04017784 RID: 96132
			[FieldOffset(16)]
			public IntPtr __Result;
		}

		// Token: 0x02003693 RID: 13971
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __CreateReactWidget_FunctionParams
		{
			// Token: 0x04017785 RID: 96133
			[FieldOffset(0)]
			public IntPtr World;

			// Token: 0x04017786 RID: 96134
			[FieldOffset(8)]
			public IntPtr __Result;
		}
	}
}
