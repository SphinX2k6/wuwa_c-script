using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001746 RID: 5958
	[UnrealObjectPath("/Script/KuroCollision.KuroBodySetupLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroBodySetupLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060156F8 RID: 87800 RVA: 0x001F800B File Offset: 0x001F620B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroBodySetupLibrary._ClassPtr;
		}

		// Token: 0x060156F9 RID: 87801 RVA: 0x001F8018 File Offset: 0x001F6218
		public UKuroBodySetupLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroBodySetupLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060156FA RID: 87802 RVA: 0x001F8040 File Offset: 0x001F6240
		[NullableContext(1)]
		public UKuroBodySetupLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroBodySetupLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060156FB RID: 87803 RVA: 0x001F8074 File Offset: 0x001F6274
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RemoveClearWpBodySetupBlackList(in FName StaticMeshName)
		{
			UKuroBodySetupLibrary.__RemoveClearWpBodySetupBlackList_FunctionParams* ptr = stackalloc UKuroBodySetupLibrary.__RemoveClearWpBodySetupBlackList_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroBodySetupLibrary.__RemoveClearWpBodySetupBlackList_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroBodySetupLibrary.__RemoveClearWpBodySetupBlackList_NativeFunctionPtr, (void*)ptr, 1);
			ptr->StaticMeshName = StaticMeshName;
			UnrealReflectionUtils.CallUFunction(UKuroBodySetupLibrary._ClassDefaultObjectPtr, UKuroBodySetupLibrary.__RemoveClearWpBodySetupBlackList_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060156FC RID: 87804 RVA: 0x001F80BF File Offset: 0x001F62BF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void LoadClearWpBodySetupBlackList()
		{
			UnrealReflectionUtils.CallUFunction(UKuroBodySetupLibrary._ClassDefaultObjectPtr, UKuroBodySetupLibrary.__LoadClearWpBodySetupBlackList_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060156FD RID: 87805 RVA: 0x001F80D4 File Offset: 0x001F62D4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void InitClearWpBodySetupBlackList(in TSet<FName> InClearWpBodySetupBlackList)
		{
			UKuroBodySetupLibrary.__InitClearWpBodySetupBlackList_FunctionParams* ptr = stackalloc UKuroBodySetupLibrary.__InitClearWpBodySetupBlackList_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UKuroBodySetupLibrary.__InitClearWpBodySetupBlackList_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroBodySetupLibrary.__InitClearWpBodySetupBlackList_NativeFunctionPtr, (void*)ptr, 1);
			TSet<FName> tset = InClearWpBodySetupBlackList;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InClearWpBodySetupBlackList);
			}
			UnrealReflectionUtils.CallUFunction(UKuroBodySetupLibrary._ClassDefaultObjectPtr, UKuroBodySetupLibrary.__InitClearWpBodySetupBlackList_NativeFunctionPtr, (void*)ptr, 0);
			TSet<FName> tset2 = InClearWpBodySetupBlackList;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InClearWpBodySetupBlackList);
			}
			UnrealReflectionUtils.DestroyStruct(UKuroBodySetupLibrary.__InitClearWpBodySetupBlackList_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060156FE RID: 87806 RVA: 0x001F814C File Offset: 0x001F634C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void EmptyClearWpBodySetupBlackList()
		{
			UnrealReflectionUtils.CallUFunction(UKuroBodySetupLibrary._ClassDefaultObjectPtr, UKuroBodySetupLibrary.__EmptyClearWpBodySetupBlackList_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060156FF RID: 87807 RVA: 0x001F8160 File Offset: 0x001F6360
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void AddClearWpBodySetupBlackList(in FName StaticMeshName)
		{
			UKuroBodySetupLibrary.__AddClearWpBodySetupBlackList_FunctionParams* ptr = stackalloc UKuroBodySetupLibrary.__AddClearWpBodySetupBlackList_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroBodySetupLibrary.__AddClearWpBodySetupBlackList_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroBodySetupLibrary.__AddClearWpBodySetupBlackList_NativeFunctionPtr, (void*)ptr, 1);
			ptr->StaticMeshName = StaticMeshName;
			UnrealReflectionUtils.CallUFunction(UKuroBodySetupLibrary._ClassDefaultObjectPtr, UKuroBodySetupLibrary.__AddClearWpBodySetupBlackList_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06015700 RID: 87808 RVA: 0x001F81AB File Offset: 0x001F63AB
		static UKuroBodySetupLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroCollision.KuroBodySetupLibrary");
		}

		// Token: 0x06015701 RID: 87809 RVA: 0x001F81B9 File Offset: 0x001F63B9
		protected UKuroBodySetupLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BAFC RID: 47868
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroCollision.KuroBodySetupLibrary";

		// Token: 0x0400BAFD RID: 47869
		private static IntPtr _ClassPtr;

		// Token: 0x0400BAFE RID: 47870
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BAFF RID: 47871
		private static IntPtr __RemoveClearWpBodySetupBlackList_NativeFunctionPtr;

		// Token: 0x0400BB00 RID: 47872
		private static IntPtr __LoadClearWpBodySetupBlackList_NativeFunctionPtr;

		// Token: 0x0400BB01 RID: 47873
		private static IntPtr __InitClearWpBodySetupBlackList_NativeFunctionPtr;

		// Token: 0x0400BB02 RID: 47874
		private static IntPtr __EmptyClearWpBodySetupBlackList_NativeFunctionPtr;

		// Token: 0x0400BB03 RID: 47875
		private static IntPtr __AddClearWpBodySetupBlackList_NativeFunctionPtr;

		// Token: 0x02002F02 RID: 12034
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __RemoveClearWpBodySetupBlackList_FunctionParams
		{
			// Token: 0x04016A41 RID: 92737
			[FieldOffset(0)]
			public FName StaticMeshName;
		}

		// Token: 0x02002F03 RID: 12035
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InitClearWpBodySetupBlackList_FunctionParams
		{
			// Token: 0x04016A42 RID: 92738
			[FieldOffset(0)]
			public byte InClearWpBodySetupBlackList;
		}

		// Token: 0x02002F04 RID: 12036
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __AddClearWpBodySetupBlackList_FunctionParams
		{
			// Token: 0x04016A43 RID: 92739
			[FieldOffset(0)]
			public FName StaticMeshName;
		}
	}
}
