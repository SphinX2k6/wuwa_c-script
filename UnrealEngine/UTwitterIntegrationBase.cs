using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001212 RID: 4626
	[UnrealObjectPath("/Script/Engine.TwitterIntegrationBase")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UTwitterIntegrationBase : UPlatformInterfaceBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011086 RID: 69766 RVA: 0x0018FCD9 File Offset: 0x0018DED9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTwitterIntegrationBase._ClassPtr;
		}

		// Token: 0x06011087 RID: 69767 RVA: 0x0018FCE8 File Offset: 0x0018DEE8
		public UTwitterIntegrationBase() : this(BuiltinUtils.AllocNativeUObject(UTwitterIntegrationBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011088 RID: 69768 RVA: 0x0018FD10 File Offset: 0x0018DF10
		[NullableContext(1)]
		public UTwitterIntegrationBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTwitterIntegrationBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06011089 RID: 69769 RVA: 0x0018FD44 File Offset: 0x0018DF44
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool TwitterRequest(string URL, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> ParamKeysAndValues, ETwitterRequestMethod RequestMethod, int AccountIndex)
		{
			UTwitterIntegrationBase.__TwitterRequest_FunctionParams* ptr = stackalloc UTwitterIntegrationBase.__TwitterRequest_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTwitterIntegrationBase.__TwitterRequest_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTwitterIntegrationBase.__TwitterRequest_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->URL), URL);
			TArray<string> tarray = ParamKeysAndValues;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->ParamKeysAndValues);
			}
			ptr->RequestMethod = RequestMethod;
			ptr->AccountIndex = AccountIndex;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTwitterIntegrationBase.__TwitterRequest_NativeFunctionPtr, (void*)ptr, 0);
			TArray<string> tarray2 = ParamKeysAndValues;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->ParamKeysAndValues);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UTwitterIntegrationBase.__TwitterRequest_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601108A RID: 69770 RVA: 0x0018FDE4 File Offset: 0x0018DFE4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool ShowTweetUI(string InitialMessage, string URL, string Picture)
		{
			UTwitterIntegrationBase.__ShowTweetUI_FunctionParams* ptr = stackalloc UTwitterIntegrationBase.__ShowTweetUI_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(UTwitterIntegrationBase.__ShowTweetUI_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTwitterIntegrationBase.__ShowTweetUI_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->InitialMessage), InitialMessage);
			FString.CopyFrom((void*)(&ptr->URL), URL);
			FString.CopyFrom((void*)(&ptr->Picture), Picture);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTwitterIntegrationBase.__ShowTweetUI_NativeFunctionPtr, (void*)ptr, 0);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UTwitterIntegrationBase.__ShowTweetUI_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601108B RID: 69771 RVA: 0x0018FE62 File Offset: 0x0018E062
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Init()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTwitterIntegrationBase.__Init_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601108C RID: 69772 RVA: 0x0018FE78 File Offset: 0x0018E078
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetNumAccounts()
		{
			UTwitterIntegrationBase.__GetNumAccounts_FunctionParams* ptr = stackalloc UTwitterIntegrationBase.__GetNumAccounts_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UTwitterIntegrationBase.__GetNumAccounts_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTwitterIntegrationBase.__GetNumAccounts_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTwitterIntegrationBase.__GetNumAccounts_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601108D RID: 69773 RVA: 0x0018FEC0 File Offset: 0x0018E0C0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe string GetAccountName(int AccountIndex)
		{
			UTwitterIntegrationBase.__GetAccountName_FunctionParams* ptr = stackalloc UTwitterIntegrationBase.__GetAccountName_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UTwitterIntegrationBase.__GetAccountName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTwitterIntegrationBase.__GetAccountName_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AccountIndex = AccountIndex;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTwitterIntegrationBase.__GetAccountName_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UTwitterIntegrationBase.__GetAccountName_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601108E RID: 69774 RVA: 0x0018FF24 File Offset: 0x0018E124
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool CanShowTweetUI()
		{
			UTwitterIntegrationBase.__CanShowTweetUI_FunctionParams* ptr = stackalloc UTwitterIntegrationBase.__CanShowTweetUI_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTwitterIntegrationBase.__CanShowTweetUI_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTwitterIntegrationBase.__CanShowTweetUI_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTwitterIntegrationBase.__CanShowTweetUI_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601108F RID: 69775 RVA: 0x0018FF6C File Offset: 0x0018E16C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool AuthorizeAccounts()
		{
			UTwitterIntegrationBase.__AuthorizeAccounts_FunctionParams* ptr = stackalloc UTwitterIntegrationBase.__AuthorizeAccounts_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTwitterIntegrationBase.__AuthorizeAccounts_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTwitterIntegrationBase.__AuthorizeAccounts_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTwitterIntegrationBase.__AuthorizeAccounts_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06011090 RID: 69776 RVA: 0x0018FFB2 File Offset: 0x0018E1B2
		static UTwitterIntegrationBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.TwitterIntegrationBase");
		}

		// Token: 0x06011091 RID: 69777 RVA: 0x0018FFC0 File Offset: 0x0018E1C0
		protected UTwitterIntegrationBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040091DC RID: 37340
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.TwitterIntegrationBase";

		// Token: 0x040091DD RID: 37341
		private static IntPtr _ClassPtr;

		// Token: 0x040091DE RID: 37342
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040091DF RID: 37343
		private static IntPtr __TwitterRequest_NativeFunctionPtr;

		// Token: 0x040091E0 RID: 37344
		private static IntPtr __ShowTweetUI_NativeFunctionPtr;

		// Token: 0x040091E1 RID: 37345
		private static IntPtr __Init_NativeFunctionPtr;

		// Token: 0x040091E2 RID: 37346
		private static IntPtr __GetNumAccounts_NativeFunctionPtr;

		// Token: 0x040091E3 RID: 37347
		private static IntPtr __GetAccountName_NativeFunctionPtr;

		// Token: 0x040091E4 RID: 37348
		private static IntPtr __CanShowTweetUI_NativeFunctionPtr;

		// Token: 0x040091E5 RID: 37349
		private static IntPtr __AuthorizeAccounts_NativeFunctionPtr;

		// Token: 0x02002DFC RID: 11772
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __TwitterRequest_FunctionParams
		{
			// Token: 0x0401685D RID: 92253
			[FieldOffset(0)]
			public FString URL;

			// Token: 0x0401685E RID: 92254
			[FieldOffset(16)]
			public byte ParamKeysAndValues;

			// Token: 0x0401685F RID: 92255
			[FieldOffset(32)]
			public TEnumAsByte<ETwitterRequestMethod> RequestMethod;

			// Token: 0x04016860 RID: 92256
			[FieldOffset(36)]
			public int AccountIndex;

			// Token: 0x04016861 RID: 92257
			[FieldOffset(40)]
			public bool __Result;
		}

		// Token: 0x02002DFD RID: 11773
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __ShowTweetUI_FunctionParams
		{
			// Token: 0x04016862 RID: 92258
			[FieldOffset(0)]
			public FString InitialMessage;

			// Token: 0x04016863 RID: 92259
			[FieldOffset(16)]
			public FString URL;

			// Token: 0x04016864 RID: 92260
			[FieldOffset(32)]
			public FString Picture;

			// Token: 0x04016865 RID: 92261
			[FieldOffset(48)]
			public bool __Result;
		}

		// Token: 0x02002DFE RID: 11774
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetNumAccounts_FunctionParams
		{
			// Token: 0x04016866 RID: 92262
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02002DFF RID: 11775
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetAccountName_FunctionParams
		{
			// Token: 0x04016867 RID: 92263
			[FieldOffset(0)]
			public int AccountIndex;

			// Token: 0x04016868 RID: 92264
			[FieldOffset(8)]
			public FString __Result;
		}

		// Token: 0x02002E00 RID: 11776
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __CanShowTweetUI_FunctionParams
		{
			// Token: 0x04016869 RID: 92265
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02002E01 RID: 11777
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __AuthorizeAccounts_FunctionParams
		{
			// Token: 0x0401686A RID: 92266
			[FieldOffset(0)]
			public bool __Result;
		}
	}
}
