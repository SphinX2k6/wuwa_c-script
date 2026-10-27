using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002275 RID: 8821
	[UnrealObjectPath("/Script/MagtModule.MagtPerformanceBooster")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UMagtPerformanceBooster : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602187E RID: 137342 RVA: 0x00318B4F File Offset: 0x00316D4F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMagtPerformanceBooster._ClassPtr;
		}

		// Token: 0x0602187F RID: 137343 RVA: 0x00318B5C File Offset: 0x00316D5C
		public UMagtPerformanceBooster() : this(BuiltinUtils.AllocNativeUObject(UMagtPerformanceBooster.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021880 RID: 137344 RVA: 0x00318B84 File Offset: 0x00316D84
		[NullableContext(1)]
		public UMagtPerformanceBooster(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMagtPerformanceBooster.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700825E RID: 33374
		// (get) Token: 0x06021881 RID: 137345 RVA: 0x00318BB8 File Offset: 0x00316DB8
		// (set) Token: 0x06021882 RID: 137346 RVA: 0x00318BF1 File Offset: 0x00316DF1
		[Nullable(1)]
		public FOnBoostStateChanged OnBoostStateChanged
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnBoostStateChanged result;
				if ((result = this._OnBoostStateChanged) == null)
				{
					result = (this._OnBoostStateChanged = new FOnBoostStateChanged(base.NativePtr + (IntPtr)UMagtPerformanceBooster.__PropertyOffset_OnBoostStateChanged, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMagtPerformanceBooster.__PropertyOffset_OnBoostStateChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06021883 RID: 137347 RVA: 0x00318C14 File Offset: 0x00316E14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool StopGPUBoost()
		{
			UMagtPerformanceBooster.__StopGPUBoost_FunctionParams* ptr = stackalloc UMagtPerformanceBooster.__StopGPUBoost_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtPerformanceBooster.__StopGPUBoost_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtPerformanceBooster.__StopGPUBoost_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtPerformanceBooster.__StopGPUBoost_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021884 RID: 137348 RVA: 0x00318C5C File Offset: 0x00316E5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool StopCPUBoost()
		{
			UMagtPerformanceBooster.__StopCPUBoost_FunctionParams* ptr = stackalloc UMagtPerformanceBooster.__StopCPUBoost_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMagtPerformanceBooster.__StopCPUBoost_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtPerformanceBooster.__StopCPUBoost_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtPerformanceBooster.__StopCPUBoost_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021885 RID: 137349 RVA: 0x00318CA4 File Offset: 0x00316EA4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool SetThreadTargetFPS(int ThreadID, int TargetFPS)
		{
			UMagtPerformanceBooster.__SetThreadTargetFPS_FunctionParams* ptr = stackalloc UMagtPerformanceBooster.__SetThreadTargetFPS_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UMagtPerformanceBooster.__SetThreadTargetFPS_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtPerformanceBooster.__SetThreadTargetFPS_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ThreadID = ThreadID;
			ptr->TargetFPS = TargetFPS;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtPerformanceBooster.__SetThreadTargetFPS_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021886 RID: 137350 RVA: 0x00318CF8 File Offset: 0x00316EF8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FMagtBoostState QueryGPUBoostState()
		{
			UMagtPerformanceBooster.__QueryGPUBoostState_FunctionParams* ptr = stackalloc UMagtPerformanceBooster.__QueryGPUBoostState_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UMagtPerformanceBooster.__QueryGPUBoostState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtPerformanceBooster.__QueryGPUBoostState_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtPerformanceBooster.__QueryGPUBoostState_NativeFunctionPtr, (void*)ptr, 0);
			return new FMagtBoostState(&ptr->__Result, true, true);
		}

		// Token: 0x06021887 RID: 137351 RVA: 0x00318D48 File Offset: 0x00316F48
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FMagtBoostState QueryCPUBoostState()
		{
			UMagtPerformanceBooster.__QueryCPUBoostState_FunctionParams* ptr = stackalloc UMagtPerformanceBooster.__QueryCPUBoostState_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UMagtPerformanceBooster.__QueryCPUBoostState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtPerformanceBooster.__QueryCPUBoostState_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtPerformanceBooster.__QueryCPUBoostState_NativeFunctionPtr, (void*)ptr, 0);
			return new FMagtBoostState(&ptr->__Result, true, true);
		}

		// Token: 0x06021888 RID: 137352 RVA: 0x00318D98 File Offset: 0x00316F98
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool DynamicBoostGPU(bool bEnable, int RenderThreadID = 0, bool bBoostDRAM = false)
		{
			UMagtPerformanceBooster.__DynamicBoostGPU_FunctionParams* ptr = stackalloc UMagtPerformanceBooster.__DynamicBoostGPU_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UMagtPerformanceBooster.__DynamicBoostGPU_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtPerformanceBooster.__DynamicBoostGPU_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			ptr->RenderThreadID = RenderThreadID;
			ptr->bBoostDRAM = bBoostDRAM;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtPerformanceBooster.__DynamicBoostGPU_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021889 RID: 137353 RVA: 0x00318DF4 File Offset: 0x00316FF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool BoostThreadsByName([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> ThreadNames, bool bEnable, int DurationMs)
		{
			UMagtPerformanceBooster.__BoostThreadsByName_FunctionParams* ptr = stackalloc UMagtPerformanceBooster.__BoostThreadsByName_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UMagtPerformanceBooster.__BoostThreadsByName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtPerformanceBooster.__BoostThreadsByName_NativeFunctionPtr, (void*)ptr, 1);
			TArray<string> tarray = ThreadNames;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->ThreadNames);
			}
			ptr->bEnable = bEnable;
			ptr->DurationMs = DurationMs;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtPerformanceBooster.__BoostThreadsByName_NativeFunctionPtr, (void*)ptr, 0);
			TArray<string> tarray2 = ThreadNames;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->ThreadNames);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UMagtPerformanceBooster.__BoostThreadsByName_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602188A RID: 137354 RVA: 0x00318E84 File Offset: 0x00317084
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool BoostThreadsByID(in TArray<int> ThreadIDs, bool bEnable, int DurationMs)
		{
			UMagtPerformanceBooster.__BoostThreadsByID_FunctionParams* ptr = stackalloc UMagtPerformanceBooster.__BoostThreadsByID_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UMagtPerformanceBooster.__BoostThreadsByID_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtPerformanceBooster.__BoostThreadsByID_NativeFunctionPtr, (void*)ptr, 1);
			TArray<int> tarray = ThreadIDs;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->ThreadIDs);
			}
			ptr->bEnable = bEnable;
			ptr->DurationMs = DurationMs;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtPerformanceBooster.__BoostThreadsByID_NativeFunctionPtr, (void*)ptr, 0);
			TArray<int> tarray2 = ThreadIDs;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->ThreadIDs);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UMagtPerformanceBooster.__BoostThreadsByID_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602188B RID: 137355 RVA: 0x00318F14 File Offset: 0x00317114
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool BoostGPU(int Level, int DurationMs, bool bBoostDRAM = false)
		{
			UMagtPerformanceBooster.__BoostGPU_FunctionParams* ptr = stackalloc UMagtPerformanceBooster.__BoostGPU_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UMagtPerformanceBooster.__BoostGPU_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtPerformanceBooster.__BoostGPU_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Level = Level;
			ptr->DurationMs = DurationMs;
			ptr->bBoostDRAM = bBoostDRAM;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtPerformanceBooster.__BoostGPU_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602188C RID: 137356 RVA: 0x00318F70 File Offset: 0x00317170
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool BoostCPU(int Level, int DurationMs, bool bBoostDRAM = false)
		{
			UMagtPerformanceBooster.__BoostCPU_FunctionParams* ptr = stackalloc UMagtPerformanceBooster.__BoostCPU_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UMagtPerformanceBooster.__BoostCPU_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtPerformanceBooster.__BoostCPU_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Level = Level;
			ptr->DurationMs = DurationMs;
			ptr->bBoostDRAM = bBoostDRAM;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtPerformanceBooster.__BoostCPU_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602188D RID: 137357 RVA: 0x00318FCB File Offset: 0x003171CB
		static UMagtPerformanceBooster()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MagtModule.MagtPerformanceBooster");
		}

		// Token: 0x0602188E RID: 137358 RVA: 0x00318FD9 File Offset: 0x003171D9
		protected UMagtPerformanceBooster(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011E6F RID: 73327
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MagtModule.MagtPerformanceBooster";

		// Token: 0x04011E70 RID: 73328
		private static IntPtr _ClassPtr;

		// Token: 0x04011E71 RID: 73329
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011E72 RID: 73330
		internal static int __PropertyOffset_OnBoostStateChanged;

		// Token: 0x04011E73 RID: 73331
		[Nullable(2)]
		private FOnBoostStateChanged _OnBoostStateChanged;

		// Token: 0x04011E74 RID: 73332
		private static IntPtr __StopGPUBoost_NativeFunctionPtr;

		// Token: 0x04011E75 RID: 73333
		private static IntPtr __StopCPUBoost_NativeFunctionPtr;

		// Token: 0x04011E76 RID: 73334
		private static IntPtr __SetThreadTargetFPS_NativeFunctionPtr;

		// Token: 0x04011E77 RID: 73335
		private static IntPtr __QueryGPUBoostState_NativeFunctionPtr;

		// Token: 0x04011E78 RID: 73336
		private static IntPtr __QueryCPUBoostState_NativeFunctionPtr;

		// Token: 0x04011E79 RID: 73337
		private static IntPtr __DynamicBoostGPU_NativeFunctionPtr;

		// Token: 0x04011E7A RID: 73338
		private static IntPtr __BoostThreadsByName_NativeFunctionPtr;

		// Token: 0x04011E7B RID: 73339
		private static IntPtr __BoostThreadsByID_NativeFunctionPtr;

		// Token: 0x04011E7C RID: 73340
		private static IntPtr __BoostGPU_NativeFunctionPtr;

		// Token: 0x04011E7D RID: 73341
		private static IntPtr __BoostCPU_NativeFunctionPtr;

		// Token: 0x020035C6 RID: 13766
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __StopGPUBoost_FunctionParams
		{
			// Token: 0x0401760B RID: 95755
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x020035C7 RID: 13767
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __StopCPUBoost_FunctionParams
		{
			// Token: 0x0401760C RID: 95756
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x020035C8 RID: 13768
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __SetThreadTargetFPS_FunctionParams
		{
			// Token: 0x0401760D RID: 95757
			[FieldOffset(0)]
			public int ThreadID;

			// Token: 0x0401760E RID: 95758
			[FieldOffset(4)]
			public int TargetFPS;

			// Token: 0x0401760F RID: 95759
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x020035C9 RID: 13769
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __QueryGPUBoostState_FunctionParams
		{
			// Token: 0x04017610 RID: 95760
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020035CA RID: 13770
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __QueryCPUBoostState_FunctionParams
		{
			// Token: 0x04017611 RID: 95761
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020035CB RID: 13771
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __DynamicBoostGPU_FunctionParams
		{
			// Token: 0x04017612 RID: 95762
			[FieldOffset(0)]
			public bool bEnable;

			// Token: 0x04017613 RID: 95763
			[FieldOffset(4)]
			public int RenderThreadID;

			// Token: 0x04017614 RID: 95764
			[FieldOffset(8)]
			public bool bBoostDRAM;

			// Token: 0x04017615 RID: 95765
			[FieldOffset(9)]
			public bool __Result;
		}

		// Token: 0x020035CC RID: 13772
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BoostThreadsByName_FunctionParams
		{
			// Token: 0x04017616 RID: 95766
			[FieldOffset(0)]
			public byte ThreadNames;

			// Token: 0x04017617 RID: 95767
			[FieldOffset(16)]
			public bool bEnable;

			// Token: 0x04017618 RID: 95768
			[FieldOffset(20)]
			public int DurationMs;

			// Token: 0x04017619 RID: 95769
			[FieldOffset(24)]
			public bool __Result;
		}

		// Token: 0x020035CD RID: 13773
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BoostThreadsByID_FunctionParams
		{
			// Token: 0x0401761A RID: 95770
			[FieldOffset(0)]
			public byte ThreadIDs;

			// Token: 0x0401761B RID: 95771
			[FieldOffset(16)]
			public bool bEnable;

			// Token: 0x0401761C RID: 95772
			[FieldOffset(20)]
			public int DurationMs;

			// Token: 0x0401761D RID: 95773
			[FieldOffset(24)]
			public bool __Result;
		}

		// Token: 0x020035CE RID: 13774
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __BoostGPU_FunctionParams
		{
			// Token: 0x0401761E RID: 95774
			[FieldOffset(0)]
			public int Level;

			// Token: 0x0401761F RID: 95775
			[FieldOffset(4)]
			public int DurationMs;

			// Token: 0x04017620 RID: 95776
			[FieldOffset(8)]
			public bool bBoostDRAM;

			// Token: 0x04017621 RID: 95777
			[FieldOffset(9)]
			public bool __Result;
		}

		// Token: 0x020035CF RID: 13775
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __BoostCPU_FunctionParams
		{
			// Token: 0x04017622 RID: 95778
			[FieldOffset(0)]
			public int Level;

			// Token: 0x04017623 RID: 95779
			[FieldOffset(4)]
			public int DurationMs;

			// Token: 0x04017624 RID: 95780
			[FieldOffset(8)]
			public bool bBoostDRAM;

			// Token: 0x04017625 RID: 95781
			[FieldOffset(9)]
			public bool __Result;
		}
	}
}
