using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200033E RID: 830
	[UnrealObjectPath("/Script/KuroCollision.KuroBodySetupLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroBodySetupLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060055DA RID: 21978 RVA: 0x00078443 File Offset: 0x00076643
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroBodySetupLibrary._ClassPtr;
		}

		// Token: 0x060055DB RID: 21979 RVA: 0x00078450 File Offset: 0x00076650
		public UKuroBodySetupLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroBodySetupLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060055DC RID: 21980 RVA: 0x00078478 File Offset: 0x00076678
		[NullableContext(1)]
		public UKuroBodySetupLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroBodySetupLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060055DD RID: 21981 RVA: 0x000784AC File Offset: 0x000766AC
		[SkipLocalsInit]
		public unsafe static void RemoveClearWpBodySetupBlackList(in FName StaticMeshName)
		{
			UKuroBodySetupLibrary.__RemoveClearWpBodySetupBlackList_FunctionParams* ptr = stackalloc UKuroBodySetupLibrary.__RemoveClearWpBodySetupBlackList_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroBodySetupLibrary.__RemoveClearWpBodySetupBlackList_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroBodySetupLibrary.__RemoveClearWpBodySetupBlackList_NativeFunctionPtr, (void*)ptr, 1);
			ptr->StaticMeshName = StaticMeshName;
			UnrealReflectionUtils.CallUFunction(UKuroBodySetupLibrary._ClassDefaultObjectPtr, UKuroBodySetupLibrary.__RemoveClearWpBodySetupBlackList_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060055DE RID: 21982 RVA: 0x000784F6 File Offset: 0x000766F6
		[SkipLocalsInit]
		public static void LoadClearWpBodySetupBlackList()
		{
			UnrealReflectionUtils.CallUFunction(UKuroBodySetupLibrary._ClassDefaultObjectPtr, UKuroBodySetupLibrary.__LoadClearWpBodySetupBlackList_NativeFunctionPtr, null);
		}

		// Token: 0x060055DF RID: 21983 RVA: 0x0007850C File Offset: 0x0007670C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void InitClearWpBodySetupBlackList(in TSet<FName> InClearWpBodySetupBlackList)
		{
			UKuroBodySetupLibrary.__InitClearWpBodySetupBlackList_FunctionParams* ptr = stackalloc UKuroBodySetupLibrary.__InitClearWpBodySetupBlackList_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UKuroBodySetupLibrary.__InitClearWpBodySetupBlackList_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroBodySetupLibrary.__InitClearWpBodySetupBlackList_NativeFunctionPtr, (void*)ptr, 1);
			TSet<FName> tset = InClearWpBodySetupBlackList;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InClearWpBodySetupBlackList);
			}
			UnrealReflectionUtils.CallUFunction(UKuroBodySetupLibrary._ClassDefaultObjectPtr, UKuroBodySetupLibrary.__InitClearWpBodySetupBlackList_NativeFunctionPtr, (void*)ptr);
			TSet<FName> tset2 = InClearWpBodySetupBlackList;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InClearWpBodySetupBlackList);
			}
			UnrealReflectionUtils.DestroyStruct(UKuroBodySetupLibrary.__InitClearWpBodySetupBlackList_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060055E0 RID: 21984 RVA: 0x00078583 File Offset: 0x00076783
		[SkipLocalsInit]
		public static void EmptyClearWpBodySetupBlackList()
		{
			UnrealReflectionUtils.CallUFunction(UKuroBodySetupLibrary._ClassDefaultObjectPtr, UKuroBodySetupLibrary.__EmptyClearWpBodySetupBlackList_NativeFunctionPtr, null);
		}

		// Token: 0x060055E1 RID: 21985 RVA: 0x00078598 File Offset: 0x00076798
		[SkipLocalsInit]
		public unsafe static void AddClearWpBodySetupBlackList(in FName StaticMeshName)
		{
			UKuroBodySetupLibrary.__AddClearWpBodySetupBlackList_FunctionParams* ptr = stackalloc UKuroBodySetupLibrary.__AddClearWpBodySetupBlackList_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroBodySetupLibrary.__AddClearWpBodySetupBlackList_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroBodySetupLibrary.__AddClearWpBodySetupBlackList_NativeFunctionPtr, (void*)ptr, 1);
			ptr->StaticMeshName = StaticMeshName;
			UnrealReflectionUtils.CallUFunction(UKuroBodySetupLibrary._ClassDefaultObjectPtr, UKuroBodySetupLibrary.__AddClearWpBodySetupBlackList_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060055E2 RID: 21986 RVA: 0x000785E2 File Offset: 0x000767E2
		static UKuroBodySetupLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroCollision.KuroBodySetupLibrary");
		}

		// Token: 0x060055E3 RID: 21987 RVA: 0x000785F0 File Offset: 0x000767F0
		protected UKuroBodySetupLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002323 RID: 8995
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroCollision.KuroBodySetupLibrary";

		// Token: 0x04002324 RID: 8996
		private static IntPtr _ClassPtr;

		// Token: 0x04002325 RID: 8997
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002326 RID: 8998
		private static IntPtr __RemoveClearWpBodySetupBlackList_NativeFunctionPtr;

		// Token: 0x04002327 RID: 8999
		private static IntPtr __LoadClearWpBodySetupBlackList_NativeFunctionPtr;

		// Token: 0x04002328 RID: 9000
		private static IntPtr __InitClearWpBodySetupBlackList_NativeFunctionPtr;

		// Token: 0x04002329 RID: 9001
		private static IntPtr __EmptyClearWpBodySetupBlackList_NativeFunctionPtr;

		// Token: 0x0400232A RID: 9002
		private static IntPtr __AddClearWpBodySetupBlackList_NativeFunctionPtr;

		// Token: 0x02000A37 RID: 2615
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __RemoveClearWpBodySetupBlackList_FunctionParams
		{
			// Token: 0x04005A15 RID: 23061
			[FieldOffset(0)]
			public FName StaticMeshName;
		}

		// Token: 0x02000A38 RID: 2616
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InitClearWpBodySetupBlackList_FunctionParams
		{
			// Token: 0x04005A16 RID: 23062
			[FieldOffset(0)]
			public byte InClearWpBodySetupBlackList;
		}

		// Token: 0x02000A39 RID: 2617
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __AddClearWpBodySetupBlackList_FunctionParams
		{
			// Token: 0x04005A17 RID: 23063
			[FieldOffset(0)]
			public FName StaticMeshName;
		}
	}
}
