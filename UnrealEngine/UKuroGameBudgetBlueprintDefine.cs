using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001869 RID: 6249
	[UnrealObjectPath("/Script/KuroGameBudget.KuroGameBudgetBlueprintDefine")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroGameBudgetBlueprintDefine : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601703E RID: 94270 RVA: 0x00218BEA File Offset: 0x00216DEA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroGameBudgetBlueprintDefine._ClassPtr;
		}

		// Token: 0x0601703F RID: 94271 RVA: 0x00218BF8 File Offset: 0x00216DF8
		public UKuroGameBudgetBlueprintDefine() : this(BuiltinUtils.AllocNativeUObject(UKuroGameBudgetBlueprintDefine.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017040 RID: 94272 RVA: 0x00218C20 File Offset: 0x00216E20
		[NullableContext(1)]
		public UKuroGameBudgetBlueprintDefine(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroGameBudgetBlueprintDefine.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06017041 RID: 94273 RVA: 0x00218C54 File Offset: 0x00216E54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void Initialize([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FGameBudgetBlueprintGroupConfig> GroupConfigs)
		{
			UKuroGameBudgetBlueprintDefine.__Initialize_FunctionParams* ptr = stackalloc UKuroGameBudgetBlueprintDefine.__Initialize_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroGameBudgetBlueprintDefine.__Initialize_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroGameBudgetBlueprintDefine.__Initialize_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FGameBudgetBlueprintGroupConfig> tarray = GroupConfigs;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->GroupConfigs);
			}
			UnrealReflectionUtils.CallUFunction(UKuroGameBudgetBlueprintDefine._ClassDefaultObjectPtr, UKuroGameBudgetBlueprintDefine.__Initialize_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FGameBudgetBlueprintGroupConfig> tarray2 = GroupConfigs;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->GroupConfigs);
			}
			UnrealReflectionUtils.DestroyStruct(UKuroGameBudgetBlueprintDefine.__Initialize_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06017042 RID: 94274 RVA: 0x00218CCC File Offset: 0x00216ECC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void Clear()
		{
			UnrealReflectionUtils.CallUFunction(UKuroGameBudgetBlueprintDefine._ClassDefaultObjectPtr, UKuroGameBudgetBlueprintDefine.__Clear_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06017043 RID: 94275 RVA: 0x00218CE0 File Offset: 0x00216EE0
		static UKuroGameBudgetBlueprintDefine()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameBudget.KuroGameBudgetBlueprintDefine");
		}

		// Token: 0x06017044 RID: 94276 RVA: 0x00218CEE File Offset: 0x00216EEE
		protected UKuroGameBudgetBlueprintDefine(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C7E3 RID: 51171
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameBudget.KuroGameBudgetBlueprintDefine";

		// Token: 0x0400C7E4 RID: 51172
		private static IntPtr _ClassPtr;

		// Token: 0x0400C7E5 RID: 51173
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C7E6 RID: 51174
		private static IntPtr __Initialize_NativeFunctionPtr;

		// Token: 0x0400C7E7 RID: 51175
		private static IntPtr __Clear_NativeFunctionPtr;

		// Token: 0x02002F76 RID: 12150
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __Initialize_FunctionParams
		{
			// Token: 0x04016B32 RID: 92978
			[FieldOffset(0)]
			public byte GroupConfigs;
		}
	}
}
