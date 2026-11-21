using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200039B RID: 923
	[UnrealObjectPath("/Script/KuroGameBudget.KuroGameBudgetBlueprintDefine")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroGameBudgetBlueprintDefine : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005BB8 RID: 23480 RVA: 0x0008124E File Offset: 0x0007F44E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroGameBudgetBlueprintDefine._ClassPtr;
		}

		// Token: 0x06005BB9 RID: 23481 RVA: 0x0008125C File Offset: 0x0007F45C
		public UKuroGameBudgetBlueprintDefine() : this(BuiltinUtils.AllocNativeUObject(UKuroGameBudgetBlueprintDefine.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005BBA RID: 23482 RVA: 0x00081284 File Offset: 0x0007F484
		[NullableContext(1)]
		public UKuroGameBudgetBlueprintDefine(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroGameBudgetBlueprintDefine.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06005BBB RID: 23483 RVA: 0x000812B8 File Offset: 0x0007F4B8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void SetGameBudgetGroupTickEnabled(UObject WorldContextObject, EGameBudgetBlueprintGroup Group, bool bEnabled)
		{
			UKuroGameBudgetBlueprintDefine.__SetGameBudgetGroupTickEnabled_FunctionParams* ptr = stackalloc UKuroGameBudgetBlueprintDefine.__SetGameBudgetGroupTickEnabled_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroGameBudgetBlueprintDefine.__SetGameBudgetGroupTickEnabled_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroGameBudgetBlueprintDefine.__SetGameBudgetGroupTickEnabled_NativeFunctionPtr, (void*)ptr, 1);
			ptr->WorldContextObject = ((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
			ptr->Group = Group;
			ptr->bEnabled = bEnabled;
			UnrealReflectionUtils.CallUFunction(UKuroGameBudgetBlueprintDefine._ClassDefaultObjectPtr, UKuroGameBudgetBlueprintDefine.__SetGameBudgetGroupTickEnabled_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06005BBC RID: 23484 RVA: 0x0008131C File Offset: 0x0007F51C
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(UKuroGameBudgetBlueprintDefine._ClassDefaultObjectPtr, UKuroGameBudgetBlueprintDefine.__Initialize_NativeFunctionPtr, (void*)ptr);
			TArray<FGameBudgetBlueprintGroupConfig> tarray2 = GroupConfigs;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->GroupConfigs);
			}
			UnrealReflectionUtils.DestroyStruct(UKuroGameBudgetBlueprintDefine.__Initialize_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06005BBD RID: 23485 RVA: 0x00081393 File Offset: 0x0007F593
		[SkipLocalsInit]
		public static void Clear()
		{
			UnrealReflectionUtils.CallUFunction(UKuroGameBudgetBlueprintDefine._ClassDefaultObjectPtr, UKuroGameBudgetBlueprintDefine.__Clear_NativeFunctionPtr, null);
		}

		// Token: 0x06005BBE RID: 23486 RVA: 0x000813A6 File Offset: 0x0007F5A6
		static UKuroGameBudgetBlueprintDefine()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameBudget.KuroGameBudgetBlueprintDefine");
		}

		// Token: 0x06005BBF RID: 23487 RVA: 0x000813B4 File Offset: 0x0007F5B4
		protected UKuroGameBudgetBlueprintDefine(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002621 RID: 9761
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameBudget.KuroGameBudgetBlueprintDefine";

		// Token: 0x04002622 RID: 9762
		private static IntPtr _ClassPtr;

		// Token: 0x04002623 RID: 9763
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002624 RID: 9764
		private static IntPtr __SetGameBudgetGroupTickEnabled_NativeFunctionPtr;

		// Token: 0x04002625 RID: 9765
		private static IntPtr __Initialize_NativeFunctionPtr;

		// Token: 0x04002626 RID: 9766
		private static IntPtr __Clear_NativeFunctionPtr;

		// Token: 0x02000A9F RID: 2719
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetGameBudgetGroupTickEnabled_FunctionParams
		{
			// Token: 0x04005AF4 RID: 23284
			[FieldOffset(0)]
			public IntPtr WorldContextObject;

			// Token: 0x04005AF5 RID: 23285
			[FieldOffset(8)]
			public EGameBudgetBlueprintGroup Group;

			// Token: 0x04005AF6 RID: 23286
			[FieldOffset(9)]
			public bool bEnabled;
		}

		// Token: 0x02000AA0 RID: 2720
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __Initialize_FunctionParams
		{
			// Token: 0x04005AF7 RID: 23287
			[FieldOffset(0)]
			public byte GroupConfigs;
		}
	}
}
