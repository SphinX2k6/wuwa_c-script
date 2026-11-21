using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007BE RID: 1982
	[UnrealObjectPath("/Script/ReactUMG.UMGManager")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UUMGManager : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600ABBF RID: 43967 RVA: 0x000FD3EC File Offset: 0x000FB5EC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUMGManager._ClassPtr;
		}

		// Token: 0x0600ABC0 RID: 43968 RVA: 0x000FD3F8 File Offset: 0x000FB5F8
		public UUMGManager() : this(BuiltinUtils.AllocNativeUObject(UUMGManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600ABC1 RID: 43969 RVA: 0x000FD420 File Offset: 0x000FB620
		[NullableContext(1)]
		public UUMGManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUMGManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600ABC2 RID: 43970 RVA: 0x000FD454 File Offset: 0x000FB654
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void SynchronizeWidgetProperties(UWidget Widget)
		{
			UUMGManager.__SynchronizeWidgetProperties_FunctionParams* ptr = stackalloc UUMGManager.__SynchronizeWidgetProperties_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UUMGManager.__SynchronizeWidgetProperties_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UUMGManager.__SynchronizeWidgetProperties_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Widget = ((Widget != null) ? Widget.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UUMGManager._ClassDefaultObjectPtr, UUMGManager.__SynchronizeWidgetProperties_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600ABC3 RID: 43971 RVA: 0x000FD4A8 File Offset: 0x000FB6A8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void SynchronizeSlotProperties(UPanelSlot Slot)
		{
			UUMGManager.__SynchronizeSlotProperties_FunctionParams* ptr = stackalloc UUMGManager.__SynchronizeSlotProperties_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UUMGManager.__SynchronizeSlotProperties_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UUMGManager.__SynchronizeSlotProperties_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Slot = ((Slot != null) ? Slot.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UUMGManager._ClassDefaultObjectPtr, UUMGManager.__SynchronizeSlotProperties_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600ABC4 RID: 43972 RVA: 0x000FD4FC File Offset: 0x000FB6FC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static UUserWidget CreateWidget(UWorld World, UClassStackOnlyPtr Class)
		{
			UUMGManager.__CreateWidget_FunctionParams* ptr = stackalloc UUMGManager.__CreateWidget_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UUMGManager.__CreateWidget_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UUMGManager.__CreateWidget_NativeFunctionPtr, (void*)ptr, 1);
			ptr->World = ((World != null) ? World.NativePtr : IntPtr.Zero);
			ptr->Class = Class;
			UnrealReflectionUtils.CallUFunction(UUMGManager._ClassDefaultObjectPtr, UUMGManager.__CreateWidget_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUserWidget>(ptr->__Result);
		}

		// Token: 0x0600ABC5 RID: 43973 RVA: 0x000FD562 File Offset: 0x000FB762
		static UUMGManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ReactUMG.UMGManager");
		}

		// Token: 0x0600ABC6 RID: 43974 RVA: 0x000FD570 File Offset: 0x000FB770
		protected UUMGManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040049D1 RID: 18897
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ReactUMG.UMGManager";

		// Token: 0x040049D2 RID: 18898
		private static IntPtr _ClassPtr;

		// Token: 0x040049D3 RID: 18899
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040049D4 RID: 18900
		private static IntPtr __SynchronizeWidgetProperties_NativeFunctionPtr;

		// Token: 0x040049D5 RID: 18901
		private static IntPtr __SynchronizeSlotProperties_NativeFunctionPtr;

		// Token: 0x040049D6 RID: 18902
		private static IntPtr __CreateWidget_NativeFunctionPtr;

		// Token: 0x02000F6B RID: 3947
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SynchronizeWidgetProperties_FunctionParams
		{
			// Token: 0x04006343 RID: 25411
			[FieldOffset(0)]
			public IntPtr Widget;
		}

		// Token: 0x02000F6C RID: 3948
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SynchronizeSlotProperties_FunctionParams
		{
			// Token: 0x04006344 RID: 25412
			[FieldOffset(0)]
			public IntPtr Slot;
		}

		// Token: 0x02000F6D RID: 3949
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __CreateWidget_FunctionParams
		{
			// Token: 0x04006345 RID: 25413
			[FieldOffset(0)]
			public IntPtr World;

			// Token: 0x04006346 RID: 25414
			[FieldOffset(8)]
			public UClassStackOnlyPtr Class;

			// Token: 0x04006347 RID: 25415
			[FieldOffset(16)]
			public IntPtr __Result;
		}
	}
}
