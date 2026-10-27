using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002271 RID: 8817
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MagtModule.MagtCallbackManager")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UMagtCallbackManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021830 RID: 137264 RVA: 0x00318089 File Offset: 0x00316289
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMagtCallbackManager._ClassPtr;
		}

		// Token: 0x06021831 RID: 137265 RVA: 0x00318098 File Offset: 0x00316298
		public UMagtCallbackManager() : this(BuiltinUtils.AllocNativeUObject(UMagtCallbackManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021832 RID: 137266 RVA: 0x003180C0 File Offset: 0x003162C0
		public UMagtCallbackManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMagtCallbackManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700824F RID: 33359
		// (get) Token: 0x06021833 RID: 137267 RVA: 0x003180F4 File Offset: 0x003162F4
		// (set) Token: 0x06021834 RID: 137268 RVA: 0x0031812D File Offset: 0x0031632D
		public FOnMagtThrottleStateChanged OnThrottleStateChanged
		{
			get
			{
				base.FastCheckIsValid();
				FOnMagtThrottleStateChanged result;
				if ((result = this._OnThrottleStateChanged) == null)
				{
					result = (this._OnThrottleStateChanged = new FOnMagtThrottleStateChanged(base.NativePtr + (IntPtr)UMagtCallbackManager.__PropertyOffset_OnThrottleStateChanged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMagtCallbackManager.__PropertyOffset_OnThrottleStateChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17008250 RID: 33360
		// (get) Token: 0x06021835 RID: 137269 RVA: 0x00318150 File Offset: 0x00316350
		// (set) Token: 0x06021836 RID: 137270 RVA: 0x00318189 File Offset: 0x00316389
		public FOnMagtCpuGearChanged OnCpuGearChanged
		{
			get
			{
				base.FastCheckIsValid();
				FOnMagtCpuGearChanged result;
				if ((result = this._OnCpuGearChanged) == null)
				{
					result = (this._OnCpuGearChanged = new FOnMagtCpuGearChanged(base.NativePtr + (IntPtr)UMagtCallbackManager.__PropertyOffset_OnCpuGearChanged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMagtCallbackManager.__PropertyOffset_OnCpuGearChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06021837 RID: 137271 RVA: 0x003181AA File Offset: 0x003163AA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void UnregisterPerformanceCallbacks()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtCallbackManager.__UnregisterPerformanceCallbacks_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021838 RID: 137272 RVA: 0x003181C0 File Offset: 0x003163C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool RegisterPerformanceCallbacks()
		{
			UMagtCallbackManager.__RegisterPerformanceCallbacks_FunctionParams* ptr = stackalloc UMagtCallbackManager.__RegisterPerformanceCallbacks_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtCallbackManager.__RegisterPerformanceCallbacks_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtCallbackManager.__RegisterPerformanceCallbacks_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtCallbackManager.__RegisterPerformanceCallbacks_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021839 RID: 137273 RVA: 0x00318208 File Offset: 0x00316408
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsRegistered()
		{
			UMagtCallbackManager.__IsRegistered_FunctionParams* ptr = stackalloc UMagtCallbackManager.__IsRegistered_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtCallbackManager.__IsRegistered_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtCallbackManager.__IsRegistered_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtCallbackManager.__IsRegistered_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602183A RID: 137274 RVA: 0x00318250 File Offset: 0x00316450
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UMagtCallbackManager GetMagtCallbackManager()
		{
			UMagtCallbackManager.__GetMagtCallbackManager_FunctionParams* ptr = stackalloc UMagtCallbackManager.__GetMagtCallbackManager_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UMagtCallbackManager.__GetMagtCallbackManager_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtCallbackManager.__GetMagtCallbackManager_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UMagtCallbackManager._ClassDefaultObjectPtr, UMagtCallbackManager.__GetMagtCallbackManager_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMagtCallbackManager>(ptr->__Result);
		}

		// Token: 0x0602183B RID: 137275 RVA: 0x0031829A File Offset: 0x0031649A
		static UMagtCallbackManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MagtModule.MagtCallbackManager");
		}

		// Token: 0x0602183C RID: 137276 RVA: 0x003182A8 File Offset: 0x003164A8
		protected UMagtCallbackManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011E3D RID: 73277
		public new const string __ObjectPath = "/Script/MagtModule.MagtCallbackManager";

		// Token: 0x04011E3E RID: 73278
		private static IntPtr _ClassPtr;

		// Token: 0x04011E3F RID: 73279
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011E40 RID: 73280
		internal static int __PropertyOffset_OnThrottleStateChanged;

		// Token: 0x04011E41 RID: 73281
		[Nullable(2)]
		private FOnMagtThrottleStateChanged _OnThrottleStateChanged;

		// Token: 0x04011E42 RID: 73282
		internal static int __PropertyOffset_OnCpuGearChanged;

		// Token: 0x04011E43 RID: 73283
		[Nullable(2)]
		private FOnMagtCpuGearChanged _OnCpuGearChanged;

		// Token: 0x04011E44 RID: 73284
		private static IntPtr __UnregisterPerformanceCallbacks_NativeFunctionPtr;

		// Token: 0x04011E45 RID: 73285
		private static IntPtr __RegisterPerformanceCallbacks_NativeFunctionPtr;

		// Token: 0x04011E46 RID: 73286
		private static IntPtr __IsRegistered_NativeFunctionPtr;

		// Token: 0x04011E47 RID: 73287
		private static IntPtr __GetMagtCallbackManager_NativeFunctionPtr;

		// Token: 0x020035B2 RID: 13746
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __RegisterPerformanceCallbacks_FunctionParams
		{
			// Token: 0x040175F3 RID: 95731
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x020035B3 RID: 13747
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsRegistered_FunctionParams
		{
			// Token: 0x040175F4 RID: 95732
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x020035B4 RID: 13748
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetMagtCallbackManager_FunctionParams
		{
			// Token: 0x040175F5 RID: 95733
			[FieldOffset(0)]
			public IntPtr __Result;
		}
	}
}
