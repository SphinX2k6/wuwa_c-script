using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200035F RID: 863
	[UnrealObjectPath("/Script/AssetRegistry.AssetRegistryHelpers")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UAssetRegistryHelpers : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002FF1 RID: 12273 RVA: 0x00049FFC File Offset: 0x000481FC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAssetRegistryHelpers._ClassPtr;
		}

		// Token: 0x06002FF2 RID: 12274 RVA: 0x0004A008 File Offset: 0x00048208
		public UAssetRegistryHelpers() : this(BuiltinUtils.AllocNativeUObject(UAssetRegistryHelpers.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002FF3 RID: 12275 RVA: 0x0004A030 File Offset: 0x00048230
		[NullableContext(1)]
		public UAssetRegistryHelpers(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAssetRegistryHelpers.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06002FF4 RID: 12276 RVA: 0x0004A064 File Offset: 0x00048264
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static FSoftObjectPath ToSoftObjectPath([Nullable(2)] in FAssetData InAssetData)
		{
			UAssetRegistryHelpers.__ToSoftObjectPath_FunctionParams* ptr = stackalloc UAssetRegistryHelpers.__ToSoftObjectPath_FunctionParams[(UIntPtr)159] + 15L / (long)sizeof(UAssetRegistryHelpers.__ToSoftObjectPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAssetRegistryHelpers.__ToSoftObjectPath_NativeFunctionPtr, (void*)ptr, 1);
			if (InAssetData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAssetData.StaticStruct(), &ptr->InAssetData, InAssetData.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(UAssetRegistryHelpers._ClassDefaultObjectPtr, UAssetRegistryHelpers.__ToSoftObjectPath_NativeFunctionPtr, (void*)ptr, 0);
			FSoftObjectPath result = new FSoftObjectPath(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UAssetRegistryHelpers.__ToSoftObjectPath_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06002FF5 RID: 12277 RVA: 0x0004A0EC File Offset: 0x000482EC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(UAssetRegistryHelpers._ClassDefaultObjectPtr, UAssetRegistryHelpers.__SetFilterTagsAndValues_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FTagAndValue> tarray2 = InTagsAndValues;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InTagsAndValues);
			}
			FARFilter result = new FARFilter(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UAssetRegistryHelpers.__SetFilterTagsAndValues_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06002FF6 RID: 12278 RVA: 0x0004A19C File Offset: 0x0004839C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool IsValid(in FAssetData InAssetData)
		{
			UAssetRegistryHelpers.__IsValid_FunctionParams* ptr = stackalloc UAssetRegistryHelpers.__IsValid_FunctionParams[(UIntPtr)135] + 15L / (long)sizeof(UAssetRegistryHelpers.__IsValid_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAssetRegistryHelpers.__IsValid_NativeFunctionPtr, (void*)ptr, 1);
			if (InAssetData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAssetData.StaticStruct(), &ptr->InAssetData, InAssetData.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(UAssetRegistryHelpers._ClassDefaultObjectPtr, UAssetRegistryHelpers.__IsValid_NativeFunctionPtr, (void*)ptr, 0);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UAssetRegistryHelpers.__IsValid_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06002FF7 RID: 12279 RVA: 0x0004A21C File Offset: 0x0004841C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool IsUAsset(in FAssetData InAssetData)
		{
			UAssetRegistryHelpers.__IsUAsset_FunctionParams* ptr = stackalloc UAssetRegistryHelpers.__IsUAsset_FunctionParams[(UIntPtr)135] + 15L / (long)sizeof(UAssetRegistryHelpers.__IsUAsset_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAssetRegistryHelpers.__IsUAsset_NativeFunctionPtr, (void*)ptr, 1);
			if (InAssetData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAssetData.StaticStruct(), &ptr->InAssetData, InAssetData.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(UAssetRegistryHelpers._ClassDefaultObjectPtr, UAssetRegistryHelpers.__IsUAsset_NativeFunctionPtr, (void*)ptr, 0);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UAssetRegistryHelpers.__IsUAsset_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06002FF8 RID: 12280 RVA: 0x0004A29C File Offset: 0x0004849C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool IsRedirector(in FAssetData InAssetData)
		{
			UAssetRegistryHelpers.__IsRedirector_FunctionParams* ptr = stackalloc UAssetRegistryHelpers.__IsRedirector_FunctionParams[(UIntPtr)135] + 15L / (long)sizeof(UAssetRegistryHelpers.__IsRedirector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAssetRegistryHelpers.__IsRedirector_NativeFunctionPtr, (void*)ptr, 1);
			if (InAssetData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAssetData.StaticStruct(), &ptr->InAssetData, InAssetData.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(UAssetRegistryHelpers._ClassDefaultObjectPtr, UAssetRegistryHelpers.__IsRedirector_NativeFunctionPtr, (void*)ptr, 0);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UAssetRegistryHelpers.__IsRedirector_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06002FF9 RID: 12281 RVA: 0x0004A31C File Offset: 0x0004851C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool IsAssetLoaded(in FAssetData InAssetData)
		{
			UAssetRegistryHelpers.__IsAssetLoaded_FunctionParams* ptr = stackalloc UAssetRegistryHelpers.__IsAssetLoaded_FunctionParams[(UIntPtr)135] + 15L / (long)sizeof(UAssetRegistryHelpers.__IsAssetLoaded_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAssetRegistryHelpers.__IsAssetLoaded_NativeFunctionPtr, (void*)ptr, 1);
			if (InAssetData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAssetData.StaticStruct(), &ptr->InAssetData, InAssetData.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(UAssetRegistryHelpers._ClassDefaultObjectPtr, UAssetRegistryHelpers.__IsAssetLoaded_NativeFunctionPtr, (void*)ptr, 0);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UAssetRegistryHelpers.__IsAssetLoaded_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06002FFA RID: 12282 RVA: 0x0004A39C File Offset: 0x0004859C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(UAssetRegistryHelpers._ClassDefaultObjectPtr, UAssetRegistryHelpers.__GetTagValue_NativeFunctionPtr, (void*)ptr, 0);
			OutTagValue = FString.ToString((void*)(&ptr->OutTagValue));
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UAssetRegistryHelpers.__GetTagValue_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06002FFB RID: 12283 RVA: 0x0004A444 File Offset: 0x00048644
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string GetFullName([Nullable(2)] in FAssetData InAssetData)
		{
			UAssetRegistryHelpers.__GetFullName_FunctionParams* ptr = stackalloc UAssetRegistryHelpers.__GetFullName_FunctionParams[(UIntPtr)143] + 15L / (long)sizeof(UAssetRegistryHelpers.__GetFullName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAssetRegistryHelpers.__GetFullName_NativeFunctionPtr, (void*)ptr, 1);
			if (InAssetData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAssetData.StaticStruct(), &ptr->InAssetData, InAssetData.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(UAssetRegistryHelpers._ClassDefaultObjectPtr, UAssetRegistryHelpers.__GetFullName_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UAssetRegistryHelpers.__GetFullName_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06002FFC RID: 12284 RVA: 0x0004A4C8 File Offset: 0x000486C8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string GetExportTextName([Nullable(2)] in FAssetData InAssetData)
		{
			UAssetRegistryHelpers.__GetExportTextName_FunctionParams* ptr = stackalloc UAssetRegistryHelpers.__GetExportTextName_FunctionParams[(UIntPtr)143] + 15L / (long)sizeof(UAssetRegistryHelpers.__GetExportTextName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAssetRegistryHelpers.__GetExportTextName_NativeFunctionPtr, (void*)ptr, 1);
			if (InAssetData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAssetData.StaticStruct(), &ptr->InAssetData, InAssetData.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(UAssetRegistryHelpers._ClassDefaultObjectPtr, UAssetRegistryHelpers.__GetExportTextName_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UAssetRegistryHelpers.__GetExportTextName_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06002FFD RID: 12285 RVA: 0x0004A54C File Offset: 0x0004874C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UClassStackOnlyPtr GetClass(in FAssetData InAssetData)
		{
			UAssetRegistryHelpers.__GetClass_FunctionParams* ptr = stackalloc UAssetRegistryHelpers.__GetClass_FunctionParams[(UIntPtr)135] + 15L / (long)sizeof(UAssetRegistryHelpers.__GetClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAssetRegistryHelpers.__GetClass_NativeFunctionPtr, (void*)ptr, 1);
			if (InAssetData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAssetData.StaticStruct(), &ptr->InAssetData, InAssetData.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(UAssetRegistryHelpers._ClassDefaultObjectPtr, UAssetRegistryHelpers.__GetClass_NativeFunctionPtr, (void*)ptr, 0);
			UClassStackOnlyPtr _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UAssetRegistryHelpers.__GetClass_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06002FFE RID: 12286 RVA: 0x0004A5CC File Offset: 0x000487CC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static IAssetRegistry GetAssetRegistry()
		{
			UAssetRegistryHelpers.__GetAssetRegistry_FunctionParams* ptr = stackalloc UAssetRegistryHelpers.__GetAssetRegistry_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UAssetRegistryHelpers.__GetAssetRegistry_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAssetRegistryHelpers.__GetAssetRegistry_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UAssetRegistryHelpers._ClassDefaultObjectPtr, UAssetRegistryHelpers.__GetAssetRegistry_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer(ptr->__Result.ObjectPointer) as IAssetRegistry;
		}

		// Token: 0x06002FFF RID: 12287 RVA: 0x0004A620 File Offset: 0x00048820
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UObject GetAsset(in FAssetData InAssetData)
		{
			UAssetRegistryHelpers.__GetAsset_FunctionParams* ptr = stackalloc UAssetRegistryHelpers.__GetAsset_FunctionParams[(UIntPtr)135] + 15L / (long)sizeof(UAssetRegistryHelpers.__GetAsset_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAssetRegistryHelpers.__GetAsset_NativeFunctionPtr, (void*)ptr, 1);
			if (InAssetData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAssetData.StaticStruct(), &ptr->InAssetData, InAssetData.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(UAssetRegistryHelpers._ClassDefaultObjectPtr, UAssetRegistryHelpers.__GetAsset_NativeFunctionPtr, (void*)ptr, 0);
			UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(ptr->__Result);
			UnrealReflectionUtils.DestroyStruct(UAssetRegistryHelpers.__GetAsset_NativeFunctionPtr, (void*)ptr, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x06003000 RID: 12288 RVA: 0x0004A6A4 File Offset: 0x000488A4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static FAssetData CreateAssetData([Nullable(2)] UObject InAsset, bool bAllowBlueprintClass = false)
		{
			UAssetRegistryHelpers.__CreateAssetData_FunctionParams* ptr = stackalloc UAssetRegistryHelpers.__CreateAssetData_FunctionParams[(UIntPtr)143] + 15L / (long)sizeof(UAssetRegistryHelpers.__CreateAssetData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAssetRegistryHelpers.__CreateAssetData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InAsset = ((InAsset != null) ? InAsset.NativePtr : IntPtr.Zero);
			ptr->bAllowBlueprintClass = bAllowBlueprintClass;
			UnrealReflectionUtils.CallUFunction(UAssetRegistryHelpers._ClassDefaultObjectPtr, UAssetRegistryHelpers.__CreateAssetData_NativeFunctionPtr, (void*)ptr, 0);
			FAssetData result = new FAssetData(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UAssetRegistryHelpers.__CreateAssetData_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06003001 RID: 12289 RVA: 0x0004A722 File Offset: 0x00048922
		static UAssetRegistryHelpers()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AssetRegistry.AssetRegistryHelpers");
		}

		// Token: 0x06003002 RID: 12290 RVA: 0x0004A730 File Offset: 0x00048930
		protected UAssetRegistryHelpers(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040014C6 RID: 5318
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AssetRegistry.AssetRegistryHelpers";

		// Token: 0x040014C7 RID: 5319
		private static IntPtr _ClassPtr;

		// Token: 0x040014C8 RID: 5320
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040014C9 RID: 5321
		private static IntPtr __ToSoftObjectPath_NativeFunctionPtr;

		// Token: 0x040014CA RID: 5322
		private static IntPtr __SetFilterTagsAndValues_NativeFunctionPtr;

		// Token: 0x040014CB RID: 5323
		private static IntPtr __IsValid_NativeFunctionPtr;

		// Token: 0x040014CC RID: 5324
		private static IntPtr __IsUAsset_NativeFunctionPtr;

		// Token: 0x040014CD RID: 5325
		private static IntPtr __IsRedirector_NativeFunctionPtr;

		// Token: 0x040014CE RID: 5326
		private static IntPtr __IsAssetLoaded_NativeFunctionPtr;

		// Token: 0x040014CF RID: 5327
		private static IntPtr __GetTagValue_NativeFunctionPtr;

		// Token: 0x040014D0 RID: 5328
		private static IntPtr __GetFullName_NativeFunctionPtr;

		// Token: 0x040014D1 RID: 5329
		private static IntPtr __GetExportTextName_NativeFunctionPtr;

		// Token: 0x040014D2 RID: 5330
		private static IntPtr __GetClass_NativeFunctionPtr;

		// Token: 0x040014D3 RID: 5331
		private static IntPtr __GetAssetRegistry_NativeFunctionPtr;

		// Token: 0x040014D4 RID: 5332
		private static IntPtr __GetAsset_NativeFunctionPtr;

		// Token: 0x040014D5 RID: 5333
		private static IntPtr __CreateAssetData_NativeFunctionPtr;

		// Token: 0x02002BF1 RID: 11249
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 144)]
		protected ref struct __ToSoftObjectPath_FunctionParams
		{
			// Token: 0x040164E0 RID: 91360
			[FieldOffset(0)]
			public byte InAssetData;

			// Token: 0x040164E1 RID: 91361
			[FieldOffset(112)]
			public byte __Result;
		}

		// Token: 0x02002BF2 RID: 11250
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 496)]
		protected ref struct __SetFilterTagsAndValues_FunctionParams
		{
			// Token: 0x040164E2 RID: 91362
			[FieldOffset(0)]
			public byte InFilter;

			// Token: 0x040164E3 RID: 91363
			[FieldOffset(240)]
			public byte InTagsAndValues;

			// Token: 0x040164E4 RID: 91364
			[FieldOffset(256)]
			public byte __Result;
		}

		// Token: 0x02002BF3 RID: 11251
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 120)]
		protected ref struct __IsValid_FunctionParams
		{
			// Token: 0x040164E5 RID: 91365
			[FieldOffset(0)]
			public byte InAssetData;

			// Token: 0x040164E6 RID: 91366
			[FieldOffset(112)]
			public bool __Result;
		}

		// Token: 0x02002BF4 RID: 11252
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 120)]
		protected ref struct __IsUAsset_FunctionParams
		{
			// Token: 0x040164E7 RID: 91367
			[FieldOffset(0)]
			public byte InAssetData;

			// Token: 0x040164E8 RID: 91368
			[FieldOffset(112)]
			public bool __Result;
		}

		// Token: 0x02002BF5 RID: 11253
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 120)]
		protected ref struct __IsRedirector_FunctionParams
		{
			// Token: 0x040164E9 RID: 91369
			[FieldOffset(0)]
			public byte InAssetData;

			// Token: 0x040164EA RID: 91370
			[FieldOffset(112)]
			public bool __Result;
		}

		// Token: 0x02002BF6 RID: 11254
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 120)]
		protected ref struct __IsAssetLoaded_FunctionParams
		{
			// Token: 0x040164EB RID: 91371
			[FieldOffset(0)]
			public byte InAssetData;

			// Token: 0x040164EC RID: 91372
			[FieldOffset(112)]
			public bool __Result;
		}

		// Token: 0x02002BF7 RID: 11255
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 152)]
		protected ref struct __GetTagValue_FunctionParams
		{
			// Token: 0x040164ED RID: 91373
			[FieldOffset(0)]
			public byte InAssetData;

			// Token: 0x040164EE RID: 91374
			[FieldOffset(112)]
			public FName InTagName;

			// Token: 0x040164EF RID: 91375
			[FieldOffset(128)]
			public FString OutTagValue;

			// Token: 0x040164F0 RID: 91376
			[FieldOffset(144)]
			public bool __Result;
		}

		// Token: 0x02002BF8 RID: 11256
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __GetFullName_FunctionParams
		{
			// Token: 0x040164F1 RID: 91377
			[FieldOffset(0)]
			public byte InAssetData;

			// Token: 0x040164F2 RID: 91378
			[FieldOffset(112)]
			public FString __Result;
		}

		// Token: 0x02002BF9 RID: 11257
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __GetExportTextName_FunctionParams
		{
			// Token: 0x040164F3 RID: 91379
			[FieldOffset(0)]
			public byte InAssetData;

			// Token: 0x040164F4 RID: 91380
			[FieldOffset(112)]
			public FString __Result;
		}

		// Token: 0x02002BFA RID: 11258
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 120)]
		protected ref struct __GetClass_FunctionParams
		{
			// Token: 0x040164F5 RID: 91381
			[FieldOffset(0)]
			public byte InAssetData;

			// Token: 0x040164F6 RID: 91382
			[FieldOffset(112)]
			public UClassStackOnlyPtr __Result;
		}

		// Token: 0x02002BFB RID: 11259
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetAssetRegistry_FunctionParams
		{
			// Token: 0x040164F7 RID: 91383
			[FieldOffset(0)]
			public FScriptInterface __Result;
		}

		// Token: 0x02002BFC RID: 11260
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 120)]
		protected ref struct __GetAsset_FunctionParams
		{
			// Token: 0x040164F8 RID: 91384
			[FieldOffset(0)]
			public byte InAssetData;

			// Token: 0x040164F9 RID: 91385
			[FieldOffset(112)]
			public IntPtr __Result;
		}

		// Token: 0x02002BFD RID: 11261
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __CreateAssetData_FunctionParams
		{
			// Token: 0x040164FA RID: 91386
			[FieldOffset(0)]
			public IntPtr InAsset;

			// Token: 0x040164FB RID: 91387
			[FieldOffset(8)]
			public bool bAllowBlueprintClass;

			// Token: 0x040164FC RID: 91388
			[FieldOffset(16)]
			public byte __Result;
		}
	}
}
