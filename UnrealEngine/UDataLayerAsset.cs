using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000995 RID: 2453
	[UnrealObjectPath("/Script/Engine.DataLayerAsset")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UDataLayerAsset : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008A91 RID: 35473 RVA: 0x000C6563 File Offset: 0x000C4763
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDataLayerAsset._ClassPtr;
		}

		// Token: 0x06008A92 RID: 35474 RVA: 0x000C6570 File Offset: 0x000C4770
		public UDataLayerAsset() : this(BuiltinUtils.AllocNativeUObject(UDataLayerAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008A93 RID: 35475 RVA: 0x000C6598 File Offset: 0x000C4798
		[NullableContext(1)]
		public UDataLayerAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDataLayerAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170020A3 RID: 8355
		// (get) Token: 0x06008A94 RID: 35476 RVA: 0x000C65CB File Offset: 0x000C47CB
		// (set) Token: 0x06008A95 RID: 35477 RVA: 0x000C65DB File Offset: 0x000C47DB
		public unsafe EDataLayerType DataLayerType
		{
			get
			{
				return (EDataLayerType)(*(base.NativePtr + (IntPtr)UDataLayerAsset.__PropertyOffset_DataLayerType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDataLayerAsset.__PropertyOffset_DataLayerType) = (byte)value;
			}
		}

		// Token: 0x170020A4 RID: 8356
		// (get) Token: 0x06008A96 RID: 35478 RVA: 0x000C65EC File Offset: 0x000C47EC
		// (set) Token: 0x06008A97 RID: 35479 RVA: 0x000C65FC File Offset: 0x000C47FC
		public unsafe bool bSupportsActorFilters
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDataLayerAsset.__PropertyOffset_bSupportsActorFilters) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDataLayerAsset.__PropertyOffset_bSupportsActorFilters) = (value ? 1 : 0);
			}
		}

		// Token: 0x170020A5 RID: 8357
		// (get) Token: 0x06008A98 RID: 35480 RVA: 0x000C660D File Offset: 0x000C480D
		// (set) Token: 0x06008A99 RID: 35481 RVA: 0x000C6621 File Offset: 0x000C4821
		public unsafe FColor DebugColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDataLayerAsset.__PropertyOffset_DebugColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDataLayerAsset.__PropertyOffset_DebugColor) = value;
			}
		}

		// Token: 0x170020A6 RID: 8358
		// (get) Token: 0x06008A9A RID: 35482 RVA: 0x000C6636 File Offset: 0x000C4836
		// (set) Token: 0x06008A9B RID: 35483 RVA: 0x000C6646 File Offset: 0x000C4846
		public unsafe EDataLayerLoadFilter LoadFilter
		{
			get
			{
				return (EDataLayerLoadFilter)(*(base.NativePtr + (IntPtr)UDataLayerAsset.__PropertyOffset_LoadFilter));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDataLayerAsset.__PropertyOffset_LoadFilter) = (byte)value;
			}
		}

		// Token: 0x06008A9C RID: 35484 RVA: 0x000C6658 File Offset: 0x000C4858
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsServerOnly()
		{
			UDataLayerAsset.__IsServerOnly_FunctionParams* ptr = stackalloc UDataLayerAsset.__IsServerOnly_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UDataLayerAsset.__IsServerOnly_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UDataLayerAsset.__IsServerOnly_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UDataLayerAsset.__IsServerOnly_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06008A9D RID: 35485 RVA: 0x000C66A0 File Offset: 0x000C48A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRuntime()
		{
			UDataLayerAsset.__IsRuntime_FunctionParams* ptr = stackalloc UDataLayerAsset.__IsRuntime_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UDataLayerAsset.__IsRuntime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UDataLayerAsset.__IsRuntime_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UDataLayerAsset.__IsRuntime_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06008A9E RID: 35486 RVA: 0x000C66E8 File Offset: 0x000C48E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsClientOnly()
		{
			UDataLayerAsset.__IsClientOnly_FunctionParams* ptr = stackalloc UDataLayerAsset.__IsClientOnly_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UDataLayerAsset.__IsClientOnly_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UDataLayerAsset.__IsClientOnly_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UDataLayerAsset.__IsClientOnly_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06008A9F RID: 35487 RVA: 0x000C6730 File Offset: 0x000C4930
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public new unsafe EDataLayerType GetType()
		{
			UDataLayerAsset.__GetType_FunctionParams* ptr = stackalloc UDataLayerAsset.__GetType_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UDataLayerAsset.__GetType_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UDataLayerAsset.__GetType_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UDataLayerAsset.__GetType_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06008AA0 RID: 35488 RVA: 0x000C6778 File Offset: 0x000C4978
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FColor GetDebugColor()
		{
			UDataLayerAsset.__GetDebugColor_FunctionParams* ptr = stackalloc UDataLayerAsset.__GetDebugColor_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UDataLayerAsset.__GetDebugColor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UDataLayerAsset.__GetDebugColor_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UDataLayerAsset.__GetDebugColor_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06008AA1 RID: 35489 RVA: 0x000C67BE File Offset: 0x000C49BE
		static UDataLayerAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DataLayerAsset");
		}

		// Token: 0x06008AA2 RID: 35490 RVA: 0x000C67CC File Offset: 0x000C49CC
		protected UDataLayerAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040041C6 RID: 16838
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DataLayerAsset";

		// Token: 0x040041C7 RID: 16839
		private static IntPtr _ClassPtr;

		// Token: 0x040041C8 RID: 16840
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040041C9 RID: 16841
		internal static int __PropertyOffset_DataLayerType;

		// Token: 0x040041CA RID: 16842
		internal static int __PropertyOffset_bSupportsActorFilters;

		// Token: 0x040041CB RID: 16843
		internal static int __PropertyOffset_DebugColor;

		// Token: 0x040041CC RID: 16844
		internal static int __PropertyOffset_LoadFilter;

		// Token: 0x040041CD RID: 16845
		private static IntPtr __IsServerOnly_NativeFunctionPtr;

		// Token: 0x040041CE RID: 16846
		private static IntPtr __IsRuntime_NativeFunctionPtr;

		// Token: 0x040041CF RID: 16847
		private static IntPtr __IsClientOnly_NativeFunctionPtr;

		// Token: 0x040041D0 RID: 16848
		private static IntPtr __GetType_NativeFunctionPtr;

		// Token: 0x040041D1 RID: 16849
		private static IntPtr __GetDebugColor_NativeFunctionPtr;

		// Token: 0x02002CE9 RID: 11497
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsServerOnly_FunctionParams
		{
			// Token: 0x0401669B RID: 91803
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02002CEA RID: 11498
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRuntime_FunctionParams
		{
			// Token: 0x0401669C RID: 91804
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02002CEB RID: 11499
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsClientOnly_FunctionParams
		{
			// Token: 0x0401669D RID: 91805
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02002CEC RID: 11500
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetType_FunctionParams
		{
			// Token: 0x0401669E RID: 91806
			[FieldOffset(0)]
			public EDataLayerType __Result;
		}

		// Token: 0x02002CED RID: 11501
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetDebugColor_FunctionParams
		{
			// Token: 0x0401669F RID: 91807
			[FieldOffset(0)]
			public FColor __Result;
		}
	}
}
