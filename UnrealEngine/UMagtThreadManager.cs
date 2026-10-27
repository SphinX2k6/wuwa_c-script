using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002279 RID: 8825
	[UnrealObjectPath("/Script/MagtModule.MagtThreadManager")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UMagtThreadManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060218E2 RID: 137442 RVA: 0x00319DB4 File Offset: 0x00317FB4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMagtThreadManager._ClassPtr;
		}

		// Token: 0x060218E3 RID: 137443 RVA: 0x00319DC0 File Offset: 0x00317FC0
		public UMagtThreadManager() : this(BuiltinUtils.AllocNativeUObject(UMagtThreadManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060218E4 RID: 137444 RVA: 0x00319DE8 File Offset: 0x00317FE8
		[NullableContext(1)]
		public UMagtThreadManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMagtThreadManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060218E5 RID: 137445 RVA: 0x00319E1C File Offset: 0x0031801C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool UnregisterCriticalThreads(in TArray<int> ThreadIDs)
		{
			UMagtThreadManager.__UnregisterCriticalThreads_FunctionParams* ptr = stackalloc UMagtThreadManager.__UnregisterCriticalThreads_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UMagtThreadManager.__UnregisterCriticalThreads_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtThreadManager.__UnregisterCriticalThreads_NativeFunctionPtr, (void*)ptr, 1);
			TArray<int> tarray = ThreadIDs;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->ThreadIDs);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtThreadManager.__UnregisterCriticalThreads_NativeFunctionPtr, (void*)ptr, 0);
			TArray<int> tarray2 = ThreadIDs;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->ThreadIDs);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UMagtThreadManager.__UnregisterCriticalThreads_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x060218E6 RID: 137446 RVA: 0x00319E9C File Offset: 0x0031809C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool UnregisterCriticalThread(int ThreadID)
		{
			UMagtThreadManager.__UnregisterCriticalThread_FunctionParams* ptr = stackalloc UMagtThreadManager.__UnregisterCriticalThread_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UMagtThreadManager.__UnregisterCriticalThread_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtThreadManager.__UnregisterCriticalThread_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ThreadID = ThreadID;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtThreadManager.__UnregisterCriticalThread_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060218E7 RID: 137447 RVA: 0x00319EEC File Offset: 0x003180EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool UnbindThreadFromCPU(int ThreadID)
		{
			UMagtThreadManager.__UnbindThreadFromCPU_FunctionParams* ptr = stackalloc UMagtThreadManager.__UnbindThreadFromCPU_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UMagtThreadManager.__UnbindThreadFromCPU_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtThreadManager.__UnbindThreadFromCPU_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ThreadID = ThreadID;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtThreadManager.__UnbindThreadFromCPU_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060218E8 RID: 137448 RVA: 0x00319F3C File Offset: 0x0031813C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string ThreadPriorityToString(EMagtThreadPriority Priority)
		{
			UMagtThreadManager.__ThreadPriorityToString_FunctionParams* ptr = stackalloc UMagtThreadManager.__ThreadPriorityToString_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UMagtThreadManager.__ThreadPriorityToString_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtThreadManager.__ThreadPriorityToString_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Priority = Priority;
			UnrealReflectionUtils.CallUFunction(UMagtThreadManager._ClassDefaultObjectPtr, UMagtThreadManager.__ThreadPriorityToString_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UMagtThreadManager.__ThreadPriorityToString_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060218E9 RID: 137449 RVA: 0x00319FA0 File Offset: 0x003181A0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string ThreadGroupToString(EMagtThreadGroup Group)
		{
			UMagtThreadManager.__ThreadGroupToString_FunctionParams* ptr = stackalloc UMagtThreadManager.__ThreadGroupToString_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UMagtThreadManager.__ThreadGroupToString_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtThreadManager.__ThreadGroupToString_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Group = Group;
			UnrealReflectionUtils.CallUFunction(UMagtThreadManager._ClassDefaultObjectPtr, UMagtThreadManager.__ThreadGroupToString_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UMagtThreadManager.__ThreadGroupToString_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060218EA RID: 137450 RVA: 0x0031A004 File Offset: 0x00318204
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool SetThreadPriority(int ThreadID, EMagtThreadPriority Priority)
		{
			UMagtThreadManager.__SetThreadPriority_FunctionParams* ptr = stackalloc UMagtThreadManager.__SetThreadPriority_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UMagtThreadManager.__SetThreadPriority_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtThreadManager.__SetThreadPriority_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ThreadID = ThreadID;
			ptr->Priority = Priority;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtThreadManager.__SetThreadPriority_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060218EB RID: 137451 RVA: 0x0031A058 File Offset: 0x00318258
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool SetThreadGroup(int ThreadID, EMagtThreadGroup Group)
		{
			UMagtThreadManager.__SetThreadGroup_FunctionParams* ptr = stackalloc UMagtThreadManager.__SetThreadGroup_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UMagtThreadManager.__SetThreadGroup_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtThreadManager.__SetThreadGroup_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ThreadID = ThreadID;
			ptr->Group = Group;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtThreadManager.__SetThreadGroup_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060218EC RID: 137452 RVA: 0x0031A0AC File Offset: 0x003182AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool SetMainGameThreadInfo(int GameThreadID = 0, int RenderThreadID = 0)
		{
			UMagtThreadManager.__SetMainGameThreadInfo_FunctionParams* ptr = stackalloc UMagtThreadManager.__SetMainGameThreadInfo_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UMagtThreadManager.__SetMainGameThreadInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtThreadManager.__SetMainGameThreadInfo_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GameThreadID = GameThreadID;
			ptr->RenderThreadID = RenderThreadID;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtThreadManager.__SetMainGameThreadInfo_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060218ED RID: 137453 RVA: 0x0031A100 File Offset: 0x00318300
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool RegisterCriticalThreads(in TArray<int> ThreadIDs)
		{
			UMagtThreadManager.__RegisterCriticalThreads_FunctionParams* ptr = stackalloc UMagtThreadManager.__RegisterCriticalThreads_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UMagtThreadManager.__RegisterCriticalThreads_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtThreadManager.__RegisterCriticalThreads_NativeFunctionPtr, (void*)ptr, 1);
			TArray<int> tarray = ThreadIDs;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->ThreadIDs);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtThreadManager.__RegisterCriticalThreads_NativeFunctionPtr, (void*)ptr, 0);
			TArray<int> tarray2 = ThreadIDs;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->ThreadIDs);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UMagtThreadManager.__RegisterCriticalThreads_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x060218EE RID: 137454 RVA: 0x0031A180 File Offset: 0x00318380
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool RegisterCriticalThread(int ThreadID)
		{
			UMagtThreadManager.__RegisterCriticalThread_FunctionParams* ptr = stackalloc UMagtThreadManager.__RegisterCriticalThread_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UMagtThreadManager.__RegisterCriticalThread_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtThreadManager.__RegisterCriticalThread_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ThreadID = ThreadID;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtThreadManager.__RegisterCriticalThread_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060218EF RID: 137455 RVA: 0x0031A1D0 File Offset: 0x003183D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int GetRenderThreadID()
		{
			UMagtThreadManager.__GetRenderThreadID_FunctionParams* ptr = stackalloc UMagtThreadManager.__GetRenderThreadID_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMagtThreadManager.__GetRenderThreadID_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtThreadManager.__GetRenderThreadID_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UMagtThreadManager._ClassDefaultObjectPtr, UMagtThreadManager.__GetRenderThreadID_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060218F0 RID: 137456 RVA: 0x0031A218 File Offset: 0x00318418
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int GetGameThreadID()
		{
			UMagtThreadManager.__GetGameThreadID_FunctionParams* ptr = stackalloc UMagtThreadManager.__GetGameThreadID_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMagtThreadManager.__GetGameThreadID_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtThreadManager.__GetGameThreadID_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UMagtThreadManager._ClassDefaultObjectPtr, UMagtThreadManager.__GetGameThreadID_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060218F1 RID: 137457 RVA: 0x0031A260 File Offset: 0x00318460
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int GetCurrentThreadID()
		{
			UMagtThreadManager.__GetCurrentThreadID_FunctionParams* ptr = stackalloc UMagtThreadManager.__GetCurrentThreadID_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMagtThreadManager.__GetCurrentThreadID_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtThreadManager.__GetCurrentThreadID_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UMagtThreadManager._ClassDefaultObjectPtr, UMagtThreadManager.__GetCurrentThreadID_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060218F2 RID: 137458 RVA: 0x0031A2A8 File Offset: 0x003184A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool BindThreadToCPU(int ThreadID, int CPUCore)
		{
			UMagtThreadManager.__BindThreadToCPU_FunctionParams* ptr = stackalloc UMagtThreadManager.__BindThreadToCPU_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UMagtThreadManager.__BindThreadToCPU_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMagtThreadManager.__BindThreadToCPU_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ThreadID = ThreadID;
			ptr->CPUCore = CPUCore;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMagtThreadManager.__BindThreadToCPU_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060218F3 RID: 137459 RVA: 0x0031A2FC File Offset: 0x003184FC
		static UMagtThreadManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MagtModule.MagtThreadManager");
		}

		// Token: 0x060218F4 RID: 137460 RVA: 0x0031A30A File Offset: 0x0031850A
		protected UMagtThreadManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011EB5 RID: 73397
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MagtModule.MagtThreadManager";

		// Token: 0x04011EB6 RID: 73398
		private static IntPtr _ClassPtr;

		// Token: 0x04011EB7 RID: 73399
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011EB8 RID: 73400
		private static IntPtr __UnregisterCriticalThreads_NativeFunctionPtr;

		// Token: 0x04011EB9 RID: 73401
		private static IntPtr __UnregisterCriticalThread_NativeFunctionPtr;

		// Token: 0x04011EBA RID: 73402
		private static IntPtr __UnbindThreadFromCPU_NativeFunctionPtr;

		// Token: 0x04011EBB RID: 73403
		private static IntPtr __ThreadPriorityToString_NativeFunctionPtr;

		// Token: 0x04011EBC RID: 73404
		private static IntPtr __ThreadGroupToString_NativeFunctionPtr;

		// Token: 0x04011EBD RID: 73405
		private static IntPtr __SetThreadPriority_NativeFunctionPtr;

		// Token: 0x04011EBE RID: 73406
		private static IntPtr __SetThreadGroup_NativeFunctionPtr;

		// Token: 0x04011EBF RID: 73407
		private static IntPtr __SetMainGameThreadInfo_NativeFunctionPtr;

		// Token: 0x04011EC0 RID: 73408
		private static IntPtr __RegisterCriticalThreads_NativeFunctionPtr;

		// Token: 0x04011EC1 RID: 73409
		private static IntPtr __RegisterCriticalThread_NativeFunctionPtr;

		// Token: 0x04011EC2 RID: 73410
		private static IntPtr __GetRenderThreadID_NativeFunctionPtr;

		// Token: 0x04011EC3 RID: 73411
		private static IntPtr __GetGameThreadID_NativeFunctionPtr;

		// Token: 0x04011EC4 RID: 73412
		private static IntPtr __GetCurrentThreadID_NativeFunctionPtr;

		// Token: 0x04011EC5 RID: 73413
		private static IntPtr __BindThreadToCPU_NativeFunctionPtr;

		// Token: 0x020035EB RID: 13803
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __UnregisterCriticalThreads_FunctionParams
		{
			// Token: 0x0401765D RID: 95837
			[FieldOffset(0)]
			public byte ThreadIDs;

			// Token: 0x0401765E RID: 95838
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x020035EC RID: 13804
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __UnregisterCriticalThread_FunctionParams
		{
			// Token: 0x0401765F RID: 95839
			[FieldOffset(0)]
			public int ThreadID;

			// Token: 0x04017660 RID: 95840
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x020035ED RID: 13805
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __UnbindThreadFromCPU_FunctionParams
		{
			// Token: 0x04017661 RID: 95841
			[FieldOffset(0)]
			public int ThreadID;

			// Token: 0x04017662 RID: 95842
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x020035EE RID: 13806
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __ThreadPriorityToString_FunctionParams
		{
			// Token: 0x04017663 RID: 95843
			[FieldOffset(0)]
			public EMagtThreadPriority Priority;

			// Token: 0x04017664 RID: 95844
			[FieldOffset(8)]
			public FString __Result;
		}

		// Token: 0x020035EF RID: 13807
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __ThreadGroupToString_FunctionParams
		{
			// Token: 0x04017665 RID: 95845
			[FieldOffset(0)]
			public EMagtThreadGroup Group;

			// Token: 0x04017666 RID: 95846
			[FieldOffset(8)]
			public FString __Result;
		}

		// Token: 0x020035F0 RID: 13808
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetThreadPriority_FunctionParams
		{
			// Token: 0x04017667 RID: 95847
			[FieldOffset(0)]
			public int ThreadID;

			// Token: 0x04017668 RID: 95848
			[FieldOffset(4)]
			public EMagtThreadPriority Priority;

			// Token: 0x04017669 RID: 95849
			[FieldOffset(5)]
			public bool __Result;
		}

		// Token: 0x020035F1 RID: 13809
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetThreadGroup_FunctionParams
		{
			// Token: 0x0401766A RID: 95850
			[FieldOffset(0)]
			public int ThreadID;

			// Token: 0x0401766B RID: 95851
			[FieldOffset(4)]
			public EMagtThreadGroup Group;

			// Token: 0x0401766C RID: 95852
			[FieldOffset(5)]
			public bool __Result;
		}

		// Token: 0x020035F2 RID: 13810
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __SetMainGameThreadInfo_FunctionParams
		{
			// Token: 0x0401766D RID: 95853
			[FieldOffset(0)]
			public int GameThreadID;

			// Token: 0x0401766E RID: 95854
			[FieldOffset(4)]
			public int RenderThreadID;

			// Token: 0x0401766F RID: 95855
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x020035F3 RID: 13811
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __RegisterCriticalThreads_FunctionParams
		{
			// Token: 0x04017670 RID: 95856
			[FieldOffset(0)]
			public byte ThreadIDs;

			// Token: 0x04017671 RID: 95857
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x020035F4 RID: 13812
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __RegisterCriticalThread_FunctionParams
		{
			// Token: 0x04017672 RID: 95858
			[FieldOffset(0)]
			public int ThreadID;

			// Token: 0x04017673 RID: 95859
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x020035F5 RID: 13813
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetRenderThreadID_FunctionParams
		{
			// Token: 0x04017674 RID: 95860
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020035F6 RID: 13814
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetGameThreadID_FunctionParams
		{
			// Token: 0x04017675 RID: 95861
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020035F7 RID: 13815
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetCurrentThreadID_FunctionParams
		{
			// Token: 0x04017676 RID: 95862
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020035F8 RID: 13816
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __BindThreadToCPU_FunctionParams
		{
			// Token: 0x04017677 RID: 95863
			[FieldOffset(0)]
			public int ThreadID;

			// Token: 0x04017678 RID: 95864
			[FieldOffset(4)]
			public int CPUCore;

			// Token: 0x04017679 RID: 95865
			[FieldOffset(8)]
			public bool __Result;
		}
	}
}
