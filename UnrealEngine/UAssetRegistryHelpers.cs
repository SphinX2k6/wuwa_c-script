using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000DF RID: 223
	[UnrealObjectPath("/Script/AssetRegistry.AssetRegistryHelpers")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UAssetRegistryHelpers : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06000FAC RID: 4012 RVA: 0x00018D5E File Offset: 0x00016F5E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAssetRegistryHelpers._ClassPtr;
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x00018D6C File Offset: 0x00016F6C
		public UAssetRegistryHelpers() : this(BuiltinUtils.AllocNativeUObject(UAssetRegistryHelpers.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x00018D94 File Offset: 0x00016F94
		[NullableContext(1)]
		public UAssetRegistryHelpers(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAssetRegistryHelpers.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x00018DC8 File Offset: 0x00016FC8
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static FSoftObjectPath ToSoftObjectPath([Nullable(2)] in FAssetData InAssetData)
		{
			UAssetRegistryHelpers.__ToSoftObjectPath_FunctionParams* ptr = stackalloc UAssetRegistryHelpers.__ToSoftObjectPath_FunctionParams[(UIntPtr)159] + 15L / (long)sizeof(UAssetRegistryHelpers.__ToSoftObjectPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAssetRegistryHelpers.__ToSoftObjectPath_NativeFunctionPtr, (void*)ptr, 1);
			if (InAssetData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAssetData.StaticStruct(), &ptr->InAssetData, InAssetData.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(UAssetRegistryHelpers._ClassDefaultObjectPtr, UAssetRegistryHelpers.__ToSoftObjectPath_NativeFunctionPtr, (void*)ptr);
			FSoftObjectPath result = new FSoftObjectPath(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UAssetRegistryHelpers.__ToSoftObjectPath_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x00018E4C File Offset: 0x0001704C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static FARFilter SetFilterTagsAndValues([Nullable(2)] in FARFilter InFilter, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FTagAndValue> InTagsAndValues)
		{
			UAssetRegistryHelpers.__SetFilterTagsAndValues_FunctionParams* ptr = stackalloc UAssetRegistryHelpers.__SetFilterTagsAndValues_FunctionParams[(UIntPtr)511] + 15L / (long)sizeof(UAssetRegistryHelpers.__SetFilterTagsAndValues_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAssetRegistryHelpers.__SetFilterTagsAndValues_NativeFunctionPtr, (void*)ptr, 1);
			if (InFilter != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FARFilter.StaticStruct(), &ptr->InFilter, InFilter.NativePtr, 1, false);
			}
			TArray<FTagAndValue> tarray = InTagsAndValues;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InTagsAndValues);
			}
			UnrealReflectionUtils.CallUFunction(UAssetRegistryHelpers._ClassDefaultObjectPtr, UAssetRegistryHelpers.__SetFilterTagsAndValues_NativeFunctionPtr, (void*)ptr);
			TArray<FTagAndValue> tarray2 = InTagsAndValues;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InTagsAndValues);
			}
			FARFilter result = new FARFilter(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UAssetRegistryHelpers.__SetFilterTagsAndValues_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x00018EF8 File Offset: 0x000170F8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static bool IsValid(in FAssetData InAssetData)
		{
			UAssetRegistryHelpers.__IsValid_FunctionParams* ptr = stackalloc UAssetRegistryHelpers.__IsValid_FunctionParams[(UIntPtr)135] + 15L / (long)sizeof(UAssetRegistryHelpers.__IsValid_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAssetRegistryHelpers.__IsValid_NativeFunctionPtr, (void*)ptr, 1);
			if (InAssetData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAssetData.StaticStruct(), &ptr->InAssetData, InAssetData.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(UAssetRegistryHelpers._ClassDefaultObjectPtr, UAssetRegistryHelpers.__IsValid_NativeFunctionPtr, (void*)ptr);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UAssetRegistryHelpers.__IsValid_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x00018F74 File Offset: 0x00017174
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static bool IsUAsset(in FAssetData InAssetData)
		{
			UAssetRegistryHelpers.__IsUAsset_FunctionParams* ptr = stackalloc UAssetRegistryHelpers.__IsUAsset_FunctionParams[(UIntPtr)135] + 15L / (long)sizeof(UAssetRegistryHelpers.__IsUAsset_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAssetRegistryHelpers.__IsUAsset_NativeFunctionPtr, (void*)ptr, 1);
			if (InAssetData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAssetData.StaticStruct(), &ptr->InAssetData, InAssetData.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(UAssetRegistryHelpers._ClassDefaultObjectPtr, UAssetRegistryHelpers.__IsUAsset_NativeFunctionPtr, (void*)ptr);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UAssetRegistryHelpers.__IsUAsset_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x00018FF0 File Offset: 0x000171F0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static bool IsRedirector(in FAssetData InAssetData)
		{
			UAssetRegistryHelpers.__IsRedirector_FunctionParams* ptr = stackalloc UAssetRegistryHelpers.__IsRedirector_FunctionParams[(UIntPtr)135] + 15L / (long)sizeof(UAssetRegistryHelpers.__IsRedirector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAssetRegistryHelpers.__IsRedirector_NativeFunctionPtr, (void*)ptr, 1);
			if (InAssetData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAssetData.StaticStruct(), &ptr->InAssetData, InAssetData.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(UAssetRegistryHelpers._ClassDefaultObjectPtr, UAssetRegistryHelpers.__IsRedirector_NativeFunctionPtr, (void*)ptr);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UAssetRegistryHelpers.__IsRedirector_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x0001906C File Offset: 0x0001726C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static bool IsAssetLoaded(in FAssetData InAssetData)
		{
			UAssetRegistryHelpers.__IsAssetLoaded_FunctionParams* ptr = stackalloc UAssetRegistryHelpers.__IsAssetLoaded_FunctionParams[(UIntPtr)135] + 15L / (long)sizeof(UAssetRegistryHelpers.__IsAssetLoaded_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAssetRegistryHelpers.__IsAssetLoaded_NativeFunctionPtr, (void*)ptr, 1);
			if (InAssetData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAssetData.StaticStruct(), &ptr->InAssetData, InAssetData.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(UAssetRegistryHelpers._ClassDefaultObjectPtr, UAssetRegistryHelpers.__IsAssetLoaded_NativeFunctionPtr, (void*)ptr);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UAssetRegistryHelpers.__IsAssetLoaded_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x000190E8 File Offset: 0x000172E8
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static bool GetTagValue([Nullable(2)] in FAssetData InAssetData, in FName InTagName, ref string OutTagValue)
		{
			UAssetRegistryHelpers.__GetTagValue_FunctionParams* ptr = stackalloc UAssetRegistryHelpers.__GetTagValue_FunctionParams[(UIntPtr)167] + 15L / (long)sizeof(UAssetRegistryHelpers.__GetTagValue_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAssetRegistryHelpers.__GetTagValue_NativeFunctionPtr, (void*)ptr, 1);
			if (InAssetData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAssetData.StaticStruct(), &ptr->InAssetData, InAssetData.NativePtr, 1, false);
			}
			ptr->InTagName = InTagName;
			FString.CopyFrom((void*)(&ptr->OutTagValue), OutTagValue);
			UnrealReflectionUtils.CallUFunction(UAssetRegistryHelpers._ClassDefaultObjectPtr, UAssetRegistryHelpers.__GetTagValue_NativeFunctionPtr, (void*)ptr);
			OutTagValue = FString.ToString((void*)(&ptr->OutTagValue));
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UAssetRegistryHelpers.__GetTagValue_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x0001918C File Offset: 0x0001738C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static string GetFullName([Nullable(2)] in FAssetData InAssetData)
		{
			UAssetRegistryHelpers.__GetFullName_FunctionParams* ptr = stackalloc UAssetRegistryHelpers.__GetFullName_FunctionParams[(UIntPtr)143] + 15L / (long)sizeof(UAssetRegistryHelpers.__GetFullName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAssetRegistryHelpers.__GetFullName_NativeFunctionPtr, (void*)ptr, 1);
			if (InAssetData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAssetData.StaticStruct(), &ptr->InAssetData, InAssetData.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(UAssetRegistryHelpers._ClassDefaultObjectPtr, UAssetRegistryHelpers.__GetFullName_NativeFunctionPtr, (void*)ptr);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UAssetRegistryHelpers.__GetFullName_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x00019210 File Offset: 0x00017410
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static string GetExportTextName([Nullable(2)] in FAssetData InAssetData)
		{
			UAssetRegistryHelpers.__GetExportTextName_FunctionParams* ptr = stackalloc UAssetRegistryHelpers.__GetExportTextName_FunctionParams[(UIntPtr)143] + 15L / (long)sizeof(UAssetRegistryHelpers.__GetExportTextName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAssetRegistryHelpers.__GetExportTextName_NativeFunctionPtr, (void*)ptr, 1);
			if (InAssetData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAssetData.StaticStruct(), &ptr->InAssetData, InAssetData.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(UAssetRegistryHelpers._ClassDefaultObjectPtr, UAssetRegistryHelpers.__GetExportTextName_NativeFunctionPtr, (void*)ptr);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UAssetRegistryHelpers.__GetExportTextName_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x00019294 File Offset: 0x00017494
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static UClassStackOnlyPtr GetClass(in FAssetData InAssetData)
		{
			UAssetRegistryHelpers.__GetClass_FunctionParams* ptr = stackalloc UAssetRegistryHelpers.__GetClass_FunctionParams[(UIntPtr)135] + 15L / (long)sizeof(UAssetRegistryHelpers.__GetClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAssetRegistryHelpers.__GetClass_NativeFunctionPtr, (void*)ptr, 1);
			if (InAssetData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAssetData.StaticStruct(), &ptr->InAssetData, InAssetData.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(UAssetRegistryHelpers._ClassDefaultObjectPtr, UAssetRegistryHelpers.__GetClass_NativeFunctionPtr, (void*)ptr);
			UClassStackOnlyPtr _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UAssetRegistryHelpers.__GetClass_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x00019310 File Offset: 0x00017510
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static IAssetRegistry GetAssetRegistry()
		{
			UAssetRegistryHelpers.__GetAssetRegistry_FunctionParams* ptr = stackalloc UAssetRegistryHelpers.__GetAssetRegistry_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UAssetRegistryHelpers.__GetAssetRegistry_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAssetRegistryHelpers.__GetAssetRegistry_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UAssetRegistryHelpers._ClassDefaultObjectPtr, UAssetRegistryHelpers.__GetAssetRegistry_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer(ptr->__Result.ObjectPointer) as IAssetRegistry;
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x00019364 File Offset: 0x00017564
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static UObject GetAsset(in FAssetData InAssetData)
		{
			UAssetRegistryHelpers.__GetAsset_FunctionParams* ptr = stackalloc UAssetRegistryHelpers.__GetAsset_FunctionParams[(UIntPtr)135] + 15L / (long)sizeof(UAssetRegistryHelpers.__GetAsset_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAssetRegistryHelpers.__GetAsset_NativeFunctionPtr, (void*)ptr, 1);
			if (InAssetData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAssetData.StaticStruct(), &ptr->InAssetData, InAssetData.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(UAssetRegistryHelpers._ClassDefaultObjectPtr, UAssetRegistryHelpers.__GetAsset_NativeFunctionPtr, (void*)ptr);
			UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(ptr->__Result);
			UnrealReflectionUtils.DestroyStruct(UAssetRegistryHelpers.__GetAsset_NativeFunctionPtr, (void*)ptr, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x000193E8 File Offset: 0x000175E8
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static FAssetData CreateAssetData([Nullable(2)] UObject InAsset, bool bAllowBlueprintClass = false)
		{
			UAssetRegistryHelpers.__CreateAssetData_FunctionParams* ptr = stackalloc UAssetRegistryHelpers.__CreateAssetData_FunctionParams[(UIntPtr)143] + 15L / (long)sizeof(UAssetRegistryHelpers.__CreateAssetData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAssetRegistryHelpers.__CreateAssetData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InAsset = ((InAsset != null) ? InAsset.NativePtr : IntPtr.Zero);
			ptr->bAllowBlueprintClass = bAllowBlueprintClass;
			UnrealReflectionUtils.CallUFunction(UAssetRegistryHelpers._ClassDefaultObjectPtr, UAssetRegistryHelpers.__CreateAssetData_NativeFunctionPtr, (void*)ptr);
			FAssetData result = new FAssetData(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UAssetRegistryHelpers.__CreateAssetData_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x00019465 File Offset: 0x00017665
		static UAssetRegistryHelpers()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AssetRegistry.AssetRegistryHelpers");
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x00019473 File Offset: 0x00017673
		protected UAssetRegistryHelpers(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000380 RID: 896
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AssetRegistry.AssetRegistryHelpers";

		// Token: 0x04000381 RID: 897
		private static IntPtr _ClassPtr;

		// Token: 0x04000382 RID: 898
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000383 RID: 899
		private static IntPtr __ToSoftObjectPath_NativeFunctionPtr;

		// Token: 0x04000384 RID: 900
		private static IntPtr __SetFilterTagsAndValues_NativeFunctionPtr;

		// Token: 0x04000385 RID: 901
		private static IntPtr __IsValid_NativeFunctionPtr;

		// Token: 0x04000386 RID: 902
		private static IntPtr __IsUAsset_NativeFunctionPtr;

		// Token: 0x04000387 RID: 903
		private static IntPtr __IsRedirector_NativeFunctionPtr;

		// Token: 0x04000388 RID: 904
		private static IntPtr __IsAssetLoaded_NativeFunctionPtr;

		// Token: 0x04000389 RID: 905
		private static IntPtr __GetTagValue_NativeFunctionPtr;

		// Token: 0x0400038A RID: 906
		private static IntPtr __GetFullName_NativeFunctionPtr;

		// Token: 0x0400038B RID: 907
		private static IntPtr __GetExportTextName_NativeFunctionPtr;

		// Token: 0x0400038C RID: 908
		private static IntPtr __GetClass_NativeFunctionPtr;

		// Token: 0x0400038D RID: 909
		private static IntPtr __GetAssetRegistry_NativeFunctionPtr;

		// Token: 0x0400038E RID: 910
		private static IntPtr __GetAsset_NativeFunctionPtr;

		// Token: 0x0400038F RID: 911
		private static IntPtr __CreateAssetData_NativeFunctionPtr;

		// Token: 0x02000922 RID: 2338
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 144)]
		protected ref struct __ToSoftObjectPath_FunctionParams
		{
			// Token: 0x0400581F RID: 22559
			[FieldOffset(0)]
			public byte InAssetData;

			// Token: 0x04005820 RID: 22560
			[FieldOffset(112)]
			public byte __Result;
		}

		// Token: 0x02000923 RID: 2339
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 496)]
		protected ref struct __SetFilterTagsAndValues_FunctionParams
		{
			// Token: 0x04005821 RID: 22561
			[FieldOffset(0)]
			public byte InFilter;

			// Token: 0x04005822 RID: 22562
			[FieldOffset(240)]
			public byte InTagsAndValues;

			// Token: 0x04005823 RID: 22563
			[FieldOffset(256)]
			public byte __Result;
		}

		// Token: 0x02000924 RID: 2340
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 120)]
		protected ref struct __IsValid_FunctionParams
		{
			// Token: 0x04005824 RID: 22564
			[FieldOffset(0)]
			public byte InAssetData;

			// Token: 0x04005825 RID: 22565
			[FieldOffset(112)]
			public bool __Result;
		}

		// Token: 0x02000925 RID: 2341
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 120)]
		protected ref struct __IsUAsset_FunctionParams
		{
			// Token: 0x04005826 RID: 22566
			[FieldOffset(0)]
			public byte InAssetData;

			// Token: 0x04005827 RID: 22567
			[FieldOffset(112)]
			public bool __Result;
		}

		// Token: 0x02000926 RID: 2342
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 120)]
		protected ref struct __IsRedirector_FunctionParams
		{
			// Token: 0x04005828 RID: 22568
			[FieldOffset(0)]
			public byte InAssetData;

			// Token: 0x04005829 RID: 22569
			[FieldOffset(112)]
			public bool __Result;
		}

		// Token: 0x02000927 RID: 2343
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 120)]
		protected ref struct __IsAssetLoaded_FunctionParams
		{
			// Token: 0x0400582A RID: 22570
			[FieldOffset(0)]
			public byte InAssetData;

			// Token: 0x0400582B RID: 22571
			[FieldOffset(112)]
			public bool __Result;
		}

		// Token: 0x02000928 RID: 2344
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 152)]
		protected ref struct __GetTagValue_FunctionParams
		{
			// Token: 0x0400582C RID: 22572
			[FieldOffset(0)]
			public byte InAssetData;

			// Token: 0x0400582D RID: 22573
			[FieldOffset(112)]
			public FName InTagName;

			// Token: 0x0400582E RID: 22574
			[FieldOffset(128)]
			public FString OutTagValue;

			// Token: 0x0400582F RID: 22575
			[FieldOffset(144)]
			public bool __Result;
		}

		// Token: 0x02000929 RID: 2345
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __GetFullName_FunctionParams
		{
			// Token: 0x04005830 RID: 22576
			[FieldOffset(0)]
			public byte InAssetData;

			// Token: 0x04005831 RID: 22577
			[FieldOffset(112)]
			public FString __Result;
		}

		// Token: 0x0200092A RID: 2346
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __GetExportTextName_FunctionParams
		{
			// Token: 0x04005832 RID: 22578
			[FieldOffset(0)]
			public byte InAssetData;

			// Token: 0x04005833 RID: 22579
			[FieldOffset(112)]
			public FString __Result;
		}

		// Token: 0x0200092B RID: 2347
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 120)]
		protected ref struct __GetClass_FunctionParams
		{
			// Token: 0x04005834 RID: 22580
			[FieldOffset(0)]
			public byte InAssetData;

			// Token: 0x04005835 RID: 22581
			[FieldOffset(112)]
			public UClassStackOnlyPtr __Result;
		}

		// Token: 0x0200092C RID: 2348
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetAssetRegistry_FunctionParams
		{
			// Token: 0x04005836 RID: 22582
			[FieldOffset(0)]
			public FScriptInterface __Result;
		}

		// Token: 0x0200092D RID: 2349
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 120)]
		protected ref struct __GetAsset_FunctionParams
		{
			// Token: 0x04005837 RID: 22583
			[FieldOffset(0)]
			public byte InAssetData;

			// Token: 0x04005838 RID: 22584
			[FieldOffset(112)]
			public IntPtr __Result;
		}

		// Token: 0x0200092E RID: 2350
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __CreateAssetData_FunctionParams
		{
			// Token: 0x04005839 RID: 22585
			[FieldOffset(0)]
			public IntPtr InAsset;

			// Token: 0x0400583A RID: 22586
			[FieldOffset(8)]
			public bool bAllowBlueprintClass;

			// Token: 0x0400583B RID: 22587
			[FieldOffset(16)]
			public byte __Result;
		}
	}
}
