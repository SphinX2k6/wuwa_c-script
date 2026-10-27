using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200146E RID: 5230
	[UnrealObjectPath("/Script/HeadMountedDisplay.XRAssetFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UXRAssetFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013141 RID: 78145 RVA: 0x001C0EAA File Offset: 0x001BF0AA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UXRAssetFunctionLibrary._ClassPtr;
		}

		// Token: 0x06013142 RID: 78146 RVA: 0x001C0EB8 File Offset: 0x001BF0B8
		public UXRAssetFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UXRAssetFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013143 RID: 78147 RVA: 0x001C0EE0 File Offset: 0x001BF0E0
		[NullableContext(1)]
		public UXRAssetFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UXRAssetFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013144 RID: 78148 RVA: 0x001C0F14 File Offset: 0x001BF114
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UPrimitiveComponent AddNamedDeviceVisualizationComponentBlocking(AActor Target, FName SystemName, FName DeviceName, bool bManualAttachment, in FTransform RelativeTransform, ref FXRDeviceId XRDeviceId)
		{
			UXRAssetFunctionLibrary.__AddNamedDeviceVisualizationComponentBlocking_FunctionParams* ptr = stackalloc UXRAssetFunctionLibrary.__AddNamedDeviceVisualizationComponentBlocking_FunctionParams[(UIntPtr)143] + 15L / (long)sizeof(UXRAssetFunctionLibrary.__AddNamedDeviceVisualizationComponentBlocking_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UXRAssetFunctionLibrary.__AddNamedDeviceVisualizationComponentBlocking_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Target = ((Target != null) ? Target.NativePtr : IntPtr.Zero);
			ptr->SystemName = SystemName;
			ptr->DeviceName = DeviceName;
			ptr->bManualAttachment = bManualAttachment;
			ptr->RelativeTransform = RelativeTransform;
			if (XRDeviceId != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FXRDeviceId.StaticStruct(), &ptr->XRDeviceId, XRDeviceId.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(UXRAssetFunctionLibrary._ClassDefaultObjectPtr, UXRAssetFunctionLibrary.__AddNamedDeviceVisualizationComponentBlocking_NativeFunctionPtr, (void*)ptr, 0);
			if (XRDeviceId != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FXRDeviceId.StaticStruct(), XRDeviceId.NativePtr, &ptr->XRDeviceId, 1, false);
			}
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(ptr->__Result);
		}

		// Token: 0x06013145 RID: 78149 RVA: 0x001C0FE8 File Offset: 0x001BF1E8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UPrimitiveComponent AddDeviceVisualizationComponentBlocking(AActor Target, in FXRDeviceId XRDeviceId, bool bManualAttachment, in FTransform RelativeTransform)
		{
			UXRAssetFunctionLibrary.__AddDeviceVisualizationComponentBlocking_FunctionParams* ptr = stackalloc UXRAssetFunctionLibrary.__AddDeviceVisualizationComponentBlocking_FunctionParams[(UIntPtr)111] + 15L / (long)sizeof(UXRAssetFunctionLibrary.__AddDeviceVisualizationComponentBlocking_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UXRAssetFunctionLibrary.__AddDeviceVisualizationComponentBlocking_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Target = ((Target != null) ? Target.NativePtr : IntPtr.Zero);
			if (XRDeviceId != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FXRDeviceId.StaticStruct(), &ptr->XRDeviceId, XRDeviceId.NativePtr, 1, false);
			}
			ptr->bManualAttachment = bManualAttachment;
			ptr->RelativeTransform = RelativeTransform;
			UnrealReflectionUtils.CallUFunction(UXRAssetFunctionLibrary._ClassDefaultObjectPtr, UXRAssetFunctionLibrary.__AddDeviceVisualizationComponentBlocking_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(ptr->__Result);
		}

		// Token: 0x06013146 RID: 78150 RVA: 0x001C107F File Offset: 0x001BF27F
		static UXRAssetFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HeadMountedDisplay.XRAssetFunctionLibrary");
		}

		// Token: 0x06013147 RID: 78151 RVA: 0x001C108D File Offset: 0x001BF28D
		protected UXRAssetFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A3AA RID: 41898
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HeadMountedDisplay.XRAssetFunctionLibrary";

		// Token: 0x0400A3AB RID: 41899
		private static IntPtr _ClassPtr;

		// Token: 0x0400A3AC RID: 41900
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A3AD RID: 41901
		private static IntPtr __AddNamedDeviceVisualizationComponentBlocking_NativeFunctionPtr;

		// Token: 0x0400A3AE RID: 41902
		private static IntPtr __AddDeviceVisualizationComponentBlocking_NativeFunctionPtr;

		// Token: 0x02002EAC RID: 11948
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __AddNamedDeviceVisualizationComponentBlocking_FunctionParams
		{
			// Token: 0x0401699D RID: 92573
			[FieldOffset(0)]
			public IntPtr Target;

			// Token: 0x0401699E RID: 92574
			[FieldOffset(8)]
			public FName SystemName;

			// Token: 0x0401699F RID: 92575
			[FieldOffset(20)]
			public FName DeviceName;

			// Token: 0x040169A0 RID: 92576
			[FieldOffset(32)]
			public bool bManualAttachment;

			// Token: 0x040169A1 RID: 92577
			[FieldOffset(48)]
			public FTransform RelativeTransform;

			// Token: 0x040169A2 RID: 92578
			[FieldOffset(96)]
			public byte XRDeviceId;

			// Token: 0x040169A3 RID: 92579
			[FieldOffset(112)]
			public IntPtr __Result;
		}

		// Token: 0x02002EAD RID: 11949
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __AddDeviceVisualizationComponentBlocking_FunctionParams
		{
			// Token: 0x040169A4 RID: 92580
			[FieldOffset(0)]
			public IntPtr Target;

			// Token: 0x040169A5 RID: 92581
			[FieldOffset(8)]
			public byte XRDeviceId;

			// Token: 0x040169A6 RID: 92582
			[FieldOffset(24)]
			public bool bManualAttachment;

			// Token: 0x040169A7 RID: 92583
			[FieldOffset(32)]
			public FTransform RelativeTransform;

			// Token: 0x040169A8 RID: 92584
			[FieldOffset(80)]
			public IntPtr __Result;
		}
	}
}
