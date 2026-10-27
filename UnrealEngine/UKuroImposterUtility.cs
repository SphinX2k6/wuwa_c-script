using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001991 RID: 6545
	[UnrealObjectPath("/Script/KuroImposter.KuroImposterUtility")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroImposterUtility : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018510 RID: 99600 RVA: 0x0023DC6B File Offset: 0x0023BE6B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroImposterUtility._ClassPtr;
		}

		// Token: 0x06018511 RID: 99601 RVA: 0x0023DC78 File Offset: 0x0023BE78
		public UKuroImposterUtility() : this(BuiltinUtils.AllocNativeUObject(UKuroImposterUtility.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018512 RID: 99602 RVA: 0x0023DCA0 File Offset: 0x0023BEA0
		[NullableContext(1)]
		public UKuroImposterUtility(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroImposterUtility.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06018513 RID: 99603 RVA: 0x0023DCD4 File Offset: 0x0023BED4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RemoveAll(UWorld EditorWorld, bool bClear)
		{
			UKuroImposterUtility.__RemoveAll_FunctionParams* ptr = stackalloc UKuroImposterUtility.__RemoveAll_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroImposterUtility.__RemoveAll_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroImposterUtility.__RemoveAll_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EditorWorld = ((EditorWorld != null) ? EditorWorld.NativePtr : IntPtr.Zero);
			ptr->bClear = bClear;
			UnrealReflectionUtils.CallUFunction(UKuroImposterUtility._ClassDefaultObjectPtr, UKuroImposterUtility.__RemoveAll_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06018514 RID: 99604 RVA: 0x0023DD30 File Offset: 0x0023BF30
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void GenerateAll(UWorld EditorWorld, bool bBake, bool bClear)
		{
			UKuroImposterUtility.__GenerateAll_FunctionParams* ptr = stackalloc UKuroImposterUtility.__GenerateAll_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroImposterUtility.__GenerateAll_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroImposterUtility.__GenerateAll_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EditorWorld = ((EditorWorld != null) ? EditorWorld.NativePtr : IntPtr.Zero);
			ptr->bBake = bBake;
			ptr->bClear = bClear;
			UnrealReflectionUtils.CallUFunction(UKuroImposterUtility._ClassDefaultObjectPtr, UKuroImposterUtility.__GenerateAll_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06018515 RID: 99605 RVA: 0x0023DD93 File Offset: 0x0023BF93
		static UKuroImposterUtility()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroImposter.KuroImposterUtility");
		}

		// Token: 0x06018516 RID: 99606 RVA: 0x0023DDA1 File Offset: 0x0023BFA1
		protected UKuroImposterUtility(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D278 RID: 53880
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroImposter.KuroImposterUtility";

		// Token: 0x0400D279 RID: 53881
		private static IntPtr _ClassPtr;

		// Token: 0x0400D27A RID: 53882
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D27B RID: 53883
		private static IntPtr __RemoveAll_NativeFunctionPtr;

		// Token: 0x0400D27C RID: 53884
		private static IntPtr __GenerateAll_NativeFunctionPtr;

		// Token: 0x02003084 RID: 12420
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __RemoveAll_FunctionParams
		{
			// Token: 0x04016D63 RID: 93539
			[FieldOffset(0)]
			public IntPtr EditorWorld;

			// Token: 0x04016D64 RID: 93540
			[FieldOffset(8)]
			public bool bClear;
		}

		// Token: 0x02003085 RID: 12421
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GenerateAll_FunctionParams
		{
			// Token: 0x04016D65 RID: 93541
			[FieldOffset(0)]
			public IntPtr EditorWorld;

			// Token: 0x04016D66 RID: 93542
			[FieldOffset(8)]
			public bool bBake;

			// Token: 0x04016D67 RID: 93543
			[FieldOffset(9)]
			public bool bClear;
		}
	}
}
