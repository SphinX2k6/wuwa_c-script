using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002752 RID: 10066
	[UnrealObjectPath("/Script/SharpherealTest.TestClass_UFunction_UClass")]
	[UnrealStructLayout(848, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 848)]
	public class UTestClass_UFunction_UClass : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025950 RID: 153936 RVA: 0x0038C169 File Offset: 0x0038A369
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTestClass_UFunction_UClass._ClassPtr;
		}

		// Token: 0x06025951 RID: 153937 RVA: 0x0038C178 File Offset: 0x0038A378
		public UTestClass_UFunction_UClass() : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_UClass.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025952 RID: 153938 RVA: 0x0038C1A0 File Offset: 0x0038A3A0
		[NullableContext(1)]
		public UTestClass_UFunction_UClass(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_UClass.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170090E2 RID: 37090
		// (get) Token: 0x06025953 RID: 153939 RVA: 0x0038C1D3 File Offset: 0x0038A3D3
		// (set) Token: 0x06025954 RID: 153940 RVA: 0x0038C1E7 File Offset: 0x0038A3E7
		public unsafe UClassStackOnlyPtr StClass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_UClass.__PropertyOffset_StClass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_UClass.__PropertyOffset_StClass) = value;
			}
		}

		// Token: 0x170090E3 RID: 37091
		// (get) Token: 0x06025955 RID: 153941 RVA: 0x0038C1FC File Offset: 0x0038A3FC
		// (set) Token: 0x06025956 RID: 153942 RVA: 0x0038C235 File Offset: 0x0038A435
		[Nullable(1)]
		public TArray<UClass> StClassArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UClass> result;
				if ((result = this._StClassArray) == null)
				{
					result = (this._StClassArray = new TArray<UClass>(base.NativePtr + (IntPtr)UTestClass_UFunction_UClass.__PropertyOffset_StClassArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.StClassArray.CopyAssign(value);
			}
		}

		// Token: 0x170090E4 RID: 37092
		// (get) Token: 0x06025957 RID: 153943 RVA: 0x0038C244 File Offset: 0x0038A444
		// (set) Token: 0x06025958 RID: 153944 RVA: 0x0038C27D File Offset: 0x0038A47D
		[Nullable(1)]
		public TSet<UClass> StClassSet
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TSet<UClass> result;
				if ((result = this._StClassSet) == null)
				{
					result = (this._StClassSet = new TSet<UClass>(base.NativePtr + (IntPtr)UTestClass_UFunction_UClass.__PropertyOffset_StClassSet, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.StClassSet.CopyAssign(value);
			}
		}

		// Token: 0x170090E5 RID: 37093
		// (get) Token: 0x06025959 RID: 153945 RVA: 0x0038C28C File Offset: 0x0038A48C
		// (set) Token: 0x0602595A RID: 153946 RVA: 0x0038C2C5 File Offset: 0x0038A4C5
		[Nullable(1)]
		public TMap<UClass, int> StClassMap
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<UClass, int> result;
				if ((result = this._StClassMap) == null)
				{
					result = (this._StClassMap = new TMap<UClass, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_UClass.__PropertyOffset_StClassMap, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.StClassMap.CopyAssign(value);
			}
		}

		// Token: 0x170090E6 RID: 37094
		// (get) Token: 0x0602595B RID: 153947 RVA: 0x0038C2D3 File Offset: 0x0038A4D3
		// (set) Token: 0x0602595C RID: 153948 RVA: 0x0038C2E8 File Offset: 0x0038A4E8
		[Nullable(1)]
		public TSoftClassPtr<USharpherealTestSimpleClass> SoftClass
		{
			[NullableContext(1)]
			get
			{
				return new TSoftClassPtr<USharpherealTestSimpleClass>(base.NativePtr + (IntPtr)UTestClass_UFunction_UClass.__PropertyOffset_SoftClass, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UTestClass_UFunction_UClass.__PropertyOffset_SoftClass, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170090E7 RID: 37095
		// (get) Token: 0x0602595D RID: 153949 RVA: 0x0038C310 File Offset: 0x0038A510
		// (set) Token: 0x0602595E RID: 153950 RVA: 0x0038C349 File Offset: 0x0038A549
		[Nullable(1)]
		public TArray<TSoftClassPtr<USharpherealTestSimpleClass>> SoftClassArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<TSoftClassPtr<USharpherealTestSimpleClass>> result;
				if ((result = this._SoftClassArray) == null)
				{
					result = (this._SoftClassArray = new TArray<TSoftClassPtr<USharpherealTestSimpleClass>>(base.NativePtr + (IntPtr)UTestClass_UFunction_UClass.__PropertyOffset_SoftClassArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SoftClassArray.CopyAssign(value);
			}
		}

		// Token: 0x170090E8 RID: 37096
		// (get) Token: 0x0602595F RID: 153951 RVA: 0x0038C358 File Offset: 0x0038A558
		// (set) Token: 0x06025960 RID: 153952 RVA: 0x0038C391 File Offset: 0x0038A591
		[Nullable(1)]
		public TSet<TSoftClassPtr<USharpherealTestSimpleClass>> SoftClassSet
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TSet<TSoftClassPtr<USharpherealTestSimpleClass>> result;
				if ((result = this._SoftClassSet) == null)
				{
					result = (this._SoftClassSet = new TSet<TSoftClassPtr<USharpherealTestSimpleClass>>(base.NativePtr + (IntPtr)UTestClass_UFunction_UClass.__PropertyOffset_SoftClassSet, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SoftClassSet.CopyAssign(value);
			}
		}

		// Token: 0x170090E9 RID: 37097
		// (get) Token: 0x06025961 RID: 153953 RVA: 0x0038C3A0 File Offset: 0x0038A5A0
		// (set) Token: 0x06025962 RID: 153954 RVA: 0x0038C3D9 File Offset: 0x0038A5D9
		[Nullable(1)]
		public TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int> SoftClassMap
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int> result;
				if ((result = this._SoftClassMap) == null)
				{
					result = (this._SoftClassMap = new TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_UClass.__PropertyOffset_SoftClassMap, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SoftClassMap.CopyAssign(value);
			}
		}

		// Token: 0x170090EA RID: 37098
		// (get) Token: 0x06025963 RID: 153955 RVA: 0x0038C3E7 File Offset: 0x0038A5E7
		// (set) Token: 0x06025964 RID: 153956 RVA: 0x0038C3FB File Offset: 0x0038A5FB
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<USharpherealTestSimpleClass> SubClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_UClass.__PropertyOffset_SubClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_UClass.__PropertyOffset_SubClass) = value;
			}
		}

		// Token: 0x170090EB RID: 37099
		// (get) Token: 0x06025965 RID: 153957 RVA: 0x0038C410 File Offset: 0x0038A610
		// (set) Token: 0x06025966 RID: 153958 RVA: 0x0038C449 File Offset: 0x0038A649
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TSubclassOf<USharpherealTestSimpleClass>> SubClassArray
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TSubclassOf<USharpherealTestSimpleClass>> result;
				if ((result = this._SubClassArray) == null)
				{
					result = (this._SubClassArray = new TArray<TSubclassOf<USharpherealTestSimpleClass>>(base.NativePtr + (IntPtr)UTestClass_UFunction_UClass.__PropertyOffset_SubClassArray, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.SubClassArray.CopyAssign(value);
			}
		}

		// Token: 0x170090EC RID: 37100
		// (get) Token: 0x06025967 RID: 153959 RVA: 0x0038C458 File Offset: 0x0038A658
		// (set) Token: 0x06025968 RID: 153960 RVA: 0x0038C491 File Offset: 0x0038A691
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TSet<TSubclassOf<USharpherealTestSimpleClass>> SubClassSet
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TSet<TSubclassOf<USharpherealTestSimpleClass>> result;
				if ((result = this._SubClassSet) == null)
				{
					result = (this._SubClassSet = new TSet<TSubclassOf<USharpherealTestSimpleClass>>(base.NativePtr + (IntPtr)UTestClass_UFunction_UClass.__PropertyOffset_SubClassSet, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.SubClassSet.CopyAssign(value);
			}
		}

		// Token: 0x170090ED RID: 37101
		// (get) Token: 0x06025969 RID: 153961 RVA: 0x0038C4A0 File Offset: 0x0038A6A0
		// (set) Token: 0x0602596A RID: 153962 RVA: 0x0038C4D9 File Offset: 0x0038A6D9
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TSubclassOf<USharpherealTestSimpleClass>, int> SubClassMap
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TSubclassOf<USharpherealTestSimpleClass>, int> result;
				if ((result = this._SubClassMap) == null)
				{
					result = (this._SubClassMap = new TMap<TSubclassOf<USharpherealTestSimpleClass>, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_UClass.__PropertyOffset_SubClassMap, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.SubClassMap.CopyAssign(value);
			}
		}

		// Token: 0x170090EE RID: 37102
		// (get) Token: 0x0602596B RID: 153963 RVA: 0x0038C4E8 File Offset: 0x0038A6E8
		// (set) Token: 0x0602596C RID: 153964 RVA: 0x0038C521 File Offset: 0x0038A721
		[Nullable(1)]
		public FSoftClassPath ClassPath
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._ClassPath) == null)
				{
					result = (this._ClassPath = new FSoftClassPath(base.NativePtr + (IntPtr)UTestClass_UFunction_UClass.__PropertyOffset_ClassPath, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)UTestClass_UFunction_UClass.__PropertyOffset_ClassPath, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170090EF RID: 37103
		// (get) Token: 0x0602596D RID: 153965 RVA: 0x0038C544 File Offset: 0x0038A744
		// (set) Token: 0x0602596E RID: 153966 RVA: 0x0038C57D File Offset: 0x0038A77D
		[Nullable(1)]
		public TArray<FSoftClassPath> ClassPathArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FSoftClassPath> result;
				if ((result = this._ClassPathArray) == null)
				{
					result = (this._ClassPathArray = new TArray<FSoftClassPath>(base.NativePtr + (IntPtr)UTestClass_UFunction_UClass.__PropertyOffset_ClassPathArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ClassPathArray.CopyAssign(value);
			}
		}

		// Token: 0x170090F0 RID: 37104
		// (get) Token: 0x0602596F RID: 153967 RVA: 0x0038C58C File Offset: 0x0038A78C
		// (set) Token: 0x06025970 RID: 153968 RVA: 0x0038C5C5 File Offset: 0x0038A7C5
		[Nullable(1)]
		public TSet<FSoftClassPath> ClassPathSet
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TSet<FSoftClassPath> result;
				if ((result = this._ClassPathSet) == null)
				{
					result = (this._ClassPathSet = new TSet<FSoftClassPath>(base.NativePtr + (IntPtr)UTestClass_UFunction_UClass.__PropertyOffset_ClassPathSet, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ClassPathSet.CopyAssign(value);
			}
		}

		// Token: 0x170090F1 RID: 37105
		// (get) Token: 0x06025971 RID: 153969 RVA: 0x0038C5D4 File Offset: 0x0038A7D4
		// (set) Token: 0x06025972 RID: 153970 RVA: 0x0038C60D File Offset: 0x0038A80D
		[Nullable(1)]
		public TMap<FSoftClassPath, int> ClassPathMap
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FSoftClassPath, int> result;
				if ((result = this._ClassPathMap) == null)
				{
					result = (this._ClassPathMap = new TMap<FSoftClassPath, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_UClass.__PropertyOffset_ClassPathMap, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ClassPathMap.CopyAssign(value);
			}
		}

		// Token: 0x06025973 RID: 153971 RVA: 0x0038C61C File Offset: 0x0038A81C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetSubPathString(ref TSoftClassPtr<USharpherealTestSimpleClass> ObjectPtr, string SubPathString)
		{
			UTestClass_UFunction_UClass.__SetSubPathString_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__SetSubPathString_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__SetSubPathString_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__SetSubPathString_NativeFunctionPtr, (void*)ptr, 1);
			if (ObjectPtr != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->ObjectPtr, ObjectPtr.NativePtr, 1);
			}
			FString.CopyFrom((void*)(&ptr->SubPathString), SubPathString);
			UnrealReflectionUtils.CallUFunction(UTestClass_UFunction_UClass._ClassDefaultObjectPtr, UTestClass_UFunction_UClass.__SetSubPathString_NativeFunctionPtr, (void*)ptr, 0);
			if (ObjectPtr != null)
			{
				FSoftObjectPtr.NativeCopy(ObjectPtr.NativePtr, &ptr->ObjectPtr, 1);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__SetSubPathString_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025974 RID: 153972 RVA: 0x0038C6B8 File Offset: 0x0038A8B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetSubClassSet([Nullable(new byte[]
		{
			2,
			0,
			1
		})] TSet<TSubclassOf<USharpherealTestSimpleClass>> InSubClassSet)
		{
			UTestClass_UFunction_UClass.__SetSubClassSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__SetSubClassSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__SetSubClassSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__SetSubClassSet_NativeFunctionPtr, (void*)ptr, 1);
			if (InSubClassSet != null)
			{
				InSubClassSet.CopyTo(&ptr->InSubClassSet, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__SetSubClassSet_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__SetSubClassSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025975 RID: 153973 RVA: 0x0038C724 File Offset: 0x0038A924
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetSubClassMap([Nullable(new byte[]
		{
			2,
			0,
			1
		})] TMap<TSubclassOf<USharpherealTestSimpleClass>, int> InSubClassMap)
		{
			UTestClass_UFunction_UClass.__SetSubClassMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__SetSubClassMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__SetSubClassMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__SetSubClassMap_NativeFunctionPtr, (void*)ptr, 1);
			if (InSubClassMap != null)
			{
				InSubClassMap.CopyTo(&ptr->InSubClassMap, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__SetSubClassMap_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__SetSubClassMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025976 RID: 153974 RVA: 0x0038C790 File Offset: 0x0038A990
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetSubClassArray([Nullable(new byte[]
		{
			2,
			0,
			1
		})] TArray<TSubclassOf<USharpherealTestSimpleClass>> InSubClassArray)
		{
			UTestClass_UFunction_UClass.__SetSubClassArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__SetSubClassArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__SetSubClassArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__SetSubClassArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InSubClassArray != null)
			{
				InSubClassArray.CopyTo(&ptr->InSubClassArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__SetSubClassArray_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__SetSubClassArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025977 RID: 153975 RVA: 0x0038C7FC File Offset: 0x0038A9FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetSubClass([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<USharpherealTestSimpleClass> InSubClass)
		{
			UTestClass_UFunction_UClass.__SetSubClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__SetSubClass_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__SetSubClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__SetSubClass_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InSubClass = InSubClass;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__SetSubClass_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025978 RID: 153976 RVA: 0x0038C844 File Offset: 0x0038AA44
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetStClassSet([Nullable(new byte[]
		{
			2,
			1
		})] TSet<UClass> InStClassSet)
		{
			UTestClass_UFunction_UClass.__SetStClassSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__SetStClassSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__SetStClassSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__SetStClassSet_NativeFunctionPtr, (void*)ptr, 1);
			if (InStClassSet != null)
			{
				InStClassSet.CopyTo(&ptr->InStClassSet, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__SetStClassSet_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__SetStClassSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025979 RID: 153977 RVA: 0x0038C8B0 File Offset: 0x0038AAB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetStClassMap([Nullable(new byte[]
		{
			2,
			1
		})] TMap<UClass, int> InStClassMap)
		{
			UTestClass_UFunction_UClass.__SetStClassMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__SetStClassMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__SetStClassMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__SetStClassMap_NativeFunctionPtr, (void*)ptr, 1);
			if (InStClassMap != null)
			{
				InStClassMap.CopyTo(&ptr->InStClassMap, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__SetStClassMap_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__SetStClassMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602597A RID: 153978 RVA: 0x0038C91C File Offset: 0x0038AB1C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetStClassArray([Nullable(new byte[]
		{
			2,
			1
		})] TArray<UClass> InStClassArray)
		{
			UTestClass_UFunction_UClass.__SetStClassArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__SetStClassArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__SetStClassArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__SetStClassArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InStClassArray != null)
			{
				InStClassArray.CopyTo(&ptr->InStClassArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__SetStClassArray_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__SetStClassArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602597B RID: 153979 RVA: 0x0038C988 File Offset: 0x0038AB88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetStClass(UClassStackOnlyPtr InStClass)
		{
			UTestClass_UFunction_UClass.__SetStClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__SetStClass_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__SetStClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__SetStClass_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InStClass = InStClass;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__SetStClass_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602597C RID: 153980 RVA: 0x0038C9D0 File Offset: 0x0038ABD0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetSoftClassSet([Nullable(new byte[]
		{
			2,
			1,
			1
		})] TSet<TSoftClassPtr<USharpherealTestSimpleClass>> InSoftClassSet)
		{
			UTestClass_UFunction_UClass.__SetSoftClassSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__SetSoftClassSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__SetSoftClassSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__SetSoftClassSet_NativeFunctionPtr, (void*)ptr, 1);
			if (InSoftClassSet != null)
			{
				InSoftClassSet.CopyTo(&ptr->InSoftClassSet, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__SetSoftClassSet_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__SetSoftClassSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602597D RID: 153981 RVA: 0x0038CA3C File Offset: 0x0038AC3C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetSoftClassMap([Nullable(new byte[]
		{
			2,
			1,
			1
		})] TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int> InSoftClassMap)
		{
			UTestClass_UFunction_UClass.__SetSoftClassMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__SetSoftClassMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__SetSoftClassMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__SetSoftClassMap_NativeFunctionPtr, (void*)ptr, 1);
			if (InSoftClassMap != null)
			{
				InSoftClassMap.CopyTo(&ptr->InSoftClassMap, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__SetSoftClassMap_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__SetSoftClassMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602597E RID: 153982 RVA: 0x0038CAA8 File Offset: 0x0038ACA8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetSoftClassArray([Nullable(new byte[]
		{
			2,
			1,
			1
		})] TArray<TSoftClassPtr<USharpherealTestSimpleClass>> InSoftClassArray)
		{
			UTestClass_UFunction_UClass.__SetSoftClassArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__SetSoftClassArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__SetSoftClassArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__SetSoftClassArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InSoftClassArray != null)
			{
				InSoftClassArray.CopyTo(&ptr->InSoftClassArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__SetSoftClassArray_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__SetSoftClassArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602597F RID: 153983 RVA: 0x0038CB14 File Offset: 0x0038AD14
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetSoftClass(TSoftClassPtr<USharpherealTestSimpleClass> InSoftClass)
		{
			UTestClass_UFunction_UClass.__SetSoftClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__SetSoftClass_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__SetSoftClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__SetSoftClass_NativeFunctionPtr, (void*)ptr, 1);
			if (InSoftClass != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->InSoftClass, InSoftClass.NativePtr, 1);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__SetSoftClass_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__SetSoftClass_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025980 RID: 153984 RVA: 0x0038CB84 File Offset: 0x0038AD84
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetClassPathSet([Nullable(new byte[]
		{
			2,
			1
		})] TSet<FSoftClassPath> InClassPathSet)
		{
			UTestClass_UFunction_UClass.__SetClassPathSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__SetClassPathSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__SetClassPathSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__SetClassPathSet_NativeFunctionPtr, (void*)ptr, 1);
			if (InClassPathSet != null)
			{
				InClassPathSet.CopyTo(&ptr->InClassPathSet, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__SetClassPathSet_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__SetClassPathSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025981 RID: 153985 RVA: 0x0038CBF0 File Offset: 0x0038ADF0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetClassPathMap([Nullable(new byte[]
		{
			2,
			1
		})] TMap<FSoftClassPath, int> InClassPathMap)
		{
			UTestClass_UFunction_UClass.__SetClassPathMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__SetClassPathMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__SetClassPathMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__SetClassPathMap_NativeFunctionPtr, (void*)ptr, 1);
			if (InClassPathMap != null)
			{
				InClassPathMap.CopyTo(&ptr->InClassPathMap, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__SetClassPathMap_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__SetClassPathMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025982 RID: 153986 RVA: 0x0038CC5C File Offset: 0x0038AE5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetClassPathArray([Nullable(new byte[]
		{
			2,
			1
		})] TArray<FSoftClassPath> InClassPathArray)
		{
			UTestClass_UFunction_UClass.__SetClassPathArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__SetClassPathArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__SetClassPathArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__SetClassPathArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InClassPathArray != null)
			{
				InClassPathArray.CopyTo(&ptr->InClassPathArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__SetClassPathArray_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__SetClassPathArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025983 RID: 153987 RVA: 0x0038CCC8 File Offset: 0x0038AEC8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetClassPath(FSoftClassPath InClassPath)
		{
			UTestClass_UFunction_UClass.__SetClassPath_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__SetClassPath_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__SetClassPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__SetClassPath_NativeFunctionPtr, (void*)ptr, 1);
			if (InClassPath != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), &ptr->InClassPath, InClassPath.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__SetClassPath_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__SetClassPath_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025984 RID: 153988 RVA: 0x0038CD3C File Offset: 0x0038AF3C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutSubClassSet([Nullable(new byte[]
		{
			2,
			0,
			1
		})] ref TSet<TSubclassOf<USharpherealTestSimpleClass>> OutSubClassSet)
		{
			UTestClass_UFunction_UClass.__OutSubClassSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__OutSubClassSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__OutSubClassSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__OutSubClassSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<TSubclassOf<USharpherealTestSimpleClass>> tset = OutSubClassSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutSubClassSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__OutSubClassSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<TSubclassOf<USharpherealTestSimpleClass>> tset2 = OutSubClassSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutSubClassSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__OutSubClassSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025985 RID: 153989 RVA: 0x0038CDB8 File Offset: 0x0038AFB8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutSubClassMap([Nullable(new byte[]
		{
			2,
			0,
			1
		})] ref TMap<TSubclassOf<USharpherealTestSimpleClass>, int> OutSubClassMap)
		{
			UTestClass_UFunction_UClass.__OutSubClassMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__OutSubClassMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__OutSubClassMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__OutSubClassMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<TSubclassOf<USharpherealTestSimpleClass>, int> tmap = OutSubClassMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutSubClassMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__OutSubClassMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<TSubclassOf<USharpherealTestSimpleClass>, int> tmap2 = OutSubClassMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutSubClassMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__OutSubClassMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025986 RID: 153990 RVA: 0x0038CE34 File Offset: 0x0038B034
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutSubClassArray([Nullable(new byte[]
		{
			2,
			0,
			1
		})] ref TArray<TSubclassOf<USharpherealTestSimpleClass>> OutSubClassArray)
		{
			UTestClass_UFunction_UClass.__OutSubClassArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__OutSubClassArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__OutSubClassArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__OutSubClassArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<TSubclassOf<USharpherealTestSimpleClass>> tarray = OutSubClassArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutSubClassArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__OutSubClassArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<TSubclassOf<USharpherealTestSimpleClass>> tarray2 = OutSubClassArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutSubClassArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__OutSubClassArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025987 RID: 153991 RVA: 0x0038CEB0 File Offset: 0x0038B0B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutSubClass([Nullable(new byte[]
		{
			0,
			1
		})] ref TSubclassOf<USharpherealTestSimpleClass> OutSubClass)
		{
			UTestClass_UFunction_UClass.__OutSubClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__OutSubClass_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__OutSubClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__OutSubClass_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutSubClass = OutSubClass;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__OutSubClass_NativeFunctionPtr, (void*)ptr, 0);
			OutSubClass = ptr->OutSubClass;
		}

		// Token: 0x06025988 RID: 153992 RVA: 0x0038CF08 File Offset: 0x0038B108
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutStClassSet([Nullable(new byte[]
		{
			2,
			1
		})] ref TSet<UClass> OutStClassSet)
		{
			UTestClass_UFunction_UClass.__OutStClassSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__OutStClassSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__OutStClassSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__OutStClassSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<UClass> tset = OutStClassSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutStClassSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__OutStClassSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<UClass> tset2 = OutStClassSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutStClassSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__OutStClassSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025989 RID: 153993 RVA: 0x0038CF84 File Offset: 0x0038B184
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutStClassMap([Nullable(new byte[]
		{
			2,
			1
		})] ref TMap<UClass, int> OutStClassMap)
		{
			UTestClass_UFunction_UClass.__OutStClassMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__OutStClassMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__OutStClassMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__OutStClassMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<UClass, int> tmap = OutStClassMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutStClassMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__OutStClassMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<UClass, int> tmap2 = OutStClassMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutStClassMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__OutStClassMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602598A RID: 153994 RVA: 0x0038D000 File Offset: 0x0038B200
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutStClassArray([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UClass> OutStClassArray)
		{
			UTestClass_UFunction_UClass.__OutStClassArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__OutStClassArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__OutStClassArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__OutStClassArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<UClass> tarray = OutStClassArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutStClassArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__OutStClassArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<UClass> tarray2 = OutStClassArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutStClassArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__OutStClassArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602598B RID: 153995 RVA: 0x0038D07C File Offset: 0x0038B27C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutStClass(ref UClassStackOnlyPtr OutStClass)
		{
			UTestClass_UFunction_UClass.__OutStClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__OutStClass_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__OutStClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__OutStClass_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutStClass = OutStClass;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__OutStClass_NativeFunctionPtr, (void*)ptr, 0);
			OutStClass = ptr->OutStClass;
		}

		// Token: 0x0602598C RID: 153996 RVA: 0x0038D0D4 File Offset: 0x0038B2D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutSoftClassSet([Nullable(new byte[]
		{
			2,
			1,
			1
		})] ref TSet<TSoftClassPtr<USharpherealTestSimpleClass>> OutSoftClassSet)
		{
			UTestClass_UFunction_UClass.__OutSoftClassSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__OutSoftClassSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__OutSoftClassSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__OutSoftClassSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<TSoftClassPtr<USharpherealTestSimpleClass>> tset = OutSoftClassSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutSoftClassSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__OutSoftClassSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<TSoftClassPtr<USharpherealTestSimpleClass>> tset2 = OutSoftClassSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutSoftClassSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__OutSoftClassSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602598D RID: 153997 RVA: 0x0038D150 File Offset: 0x0038B350
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutSoftClassMap([Nullable(new byte[]
		{
			2,
			1,
			1
		})] ref TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int> OutSoftClassMap)
		{
			UTestClass_UFunction_UClass.__OutSoftClassMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__OutSoftClassMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__OutSoftClassMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__OutSoftClassMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int> tmap = OutSoftClassMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutSoftClassMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__OutSoftClassMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int> tmap2 = OutSoftClassMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutSoftClassMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__OutSoftClassMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602598E RID: 153998 RVA: 0x0038D1CC File Offset: 0x0038B3CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutSoftClassArray([Nullable(new byte[]
		{
			2,
			1,
			1
		})] ref TArray<TSoftClassPtr<USharpherealTestSimpleClass>> OutSoftClassArray)
		{
			UTestClass_UFunction_UClass.__OutSoftClassArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__OutSoftClassArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__OutSoftClassArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__OutSoftClassArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<TSoftClassPtr<USharpherealTestSimpleClass>> tarray = OutSoftClassArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutSoftClassArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__OutSoftClassArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<TSoftClassPtr<USharpherealTestSimpleClass>> tarray2 = OutSoftClassArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutSoftClassArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__OutSoftClassArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602598F RID: 153999 RVA: 0x0038D248 File Offset: 0x0038B448
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutSoftClass(ref TSoftClassPtr<USharpherealTestSimpleClass> OutSoftClass)
		{
			UTestClass_UFunction_UClass.__OutSoftClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__OutSoftClass_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__OutSoftClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__OutSoftClass_NativeFunctionPtr, (void*)ptr, 1);
			if (OutSoftClass != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->OutSoftClass, OutSoftClass.NativePtr, 1);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__OutSoftClass_NativeFunctionPtr, (void*)ptr, 0);
			if (OutSoftClass != null)
			{
				FSoftObjectPtr.NativeCopy(OutSoftClass.NativePtr, &ptr->OutSoftClass, 1);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__OutSoftClass_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025990 RID: 154000 RVA: 0x0038D2D8 File Offset: 0x0038B4D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutClassPathSet([Nullable(new byte[]
		{
			2,
			1
		})] ref TSet<FSoftClassPath> OutClassPathSet)
		{
			UTestClass_UFunction_UClass.__OutClassPathSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__OutClassPathSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__OutClassPathSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__OutClassPathSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<FSoftClassPath> tset = OutClassPathSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutClassPathSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__OutClassPathSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<FSoftClassPath> tset2 = OutClassPathSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutClassPathSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__OutClassPathSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025991 RID: 154001 RVA: 0x0038D354 File Offset: 0x0038B554
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutClassPathMap([Nullable(new byte[]
		{
			2,
			1
		})] ref TMap<FSoftClassPath, int> OutClassPathMap)
		{
			UTestClass_UFunction_UClass.__OutClassPathMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__OutClassPathMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__OutClassPathMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__OutClassPathMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FSoftClassPath, int> tmap = OutClassPathMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutClassPathMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__OutClassPathMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FSoftClassPath, int> tmap2 = OutClassPathMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutClassPathMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__OutClassPathMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025992 RID: 154002 RVA: 0x0038D3D0 File Offset: 0x0038B5D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutClassPathArray([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FSoftClassPath> OutClassPathArray)
		{
			UTestClass_UFunction_UClass.__OutClassPathArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__OutClassPathArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__OutClassPathArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__OutClassPathArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FSoftClassPath> tarray = OutClassPathArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutClassPathArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__OutClassPathArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FSoftClassPath> tarray2 = OutClassPathArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutClassPathArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__OutClassPathArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025993 RID: 154003 RVA: 0x0038D44C File Offset: 0x0038B64C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutClassPath(ref FSoftClassPath OutClassPath)
		{
			UTestClass_UFunction_UClass.__OutClassPath_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__OutClassPath_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__OutClassPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__OutClassPath_NativeFunctionPtr, (void*)ptr, 1);
			if (OutClassPath != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), &ptr->OutClassPath, OutClassPath.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__OutClassPath_NativeFunctionPtr, (void*)ptr, 0);
			if (OutClassPath != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), OutClassPath.NativePtr, &ptr->OutClassPath, 1, false);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__OutClassPath_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025994 RID: 154004 RVA: 0x0038D4E8 File Offset: 0x0038B6E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InSubClassSet([Nullable(new byte[]
		{
			2,
			0,
			1
		})] in TSet<TSubclassOf<USharpherealTestSimpleClass>> InSubClassSet)
		{
			UTestClass_UFunction_UClass.__InSubClassSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__InSubClassSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__InSubClassSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__InSubClassSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<TSubclassOf<USharpherealTestSimpleClass>> tset = InSubClassSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InSubClassSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__InSubClassSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<TSubclassOf<USharpherealTestSimpleClass>> tset2 = InSubClassSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InSubClassSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__InSubClassSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025995 RID: 154005 RVA: 0x0038D564 File Offset: 0x0038B764
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InSubClassMap([Nullable(new byte[]
		{
			2,
			0,
			1
		})] in TMap<TSubclassOf<USharpherealTestSimpleClass>, int> InSubClassMap)
		{
			UTestClass_UFunction_UClass.__InSubClassMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__InSubClassMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__InSubClassMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__InSubClassMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<TSubclassOf<USharpherealTestSimpleClass>, int> tmap = InSubClassMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InSubClassMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__InSubClassMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<TSubclassOf<USharpherealTestSimpleClass>, int> tmap2 = InSubClassMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InSubClassMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__InSubClassMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025996 RID: 154006 RVA: 0x0038D5E0 File Offset: 0x0038B7E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InSubClassArray([Nullable(new byte[]
		{
			2,
			0,
			1
		})] in TArray<TSubclassOf<USharpherealTestSimpleClass>> InSubClassArray)
		{
			UTestClass_UFunction_UClass.__InSubClassArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__InSubClassArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__InSubClassArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__InSubClassArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<TSubclassOf<USharpherealTestSimpleClass>> tarray = InSubClassArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InSubClassArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__InSubClassArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<TSubclassOf<USharpherealTestSimpleClass>> tarray2 = InSubClassArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InSubClassArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__InSubClassArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025997 RID: 154007 RVA: 0x0038D65C File Offset: 0x0038B85C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InSubClass([Nullable(new byte[]
		{
			0,
			1
		})] in TSubclassOf<USharpherealTestSimpleClass> InSubClass)
		{
			UTestClass_UFunction_UClass.__InSubClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__InSubClass_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__InSubClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__InSubClass_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InSubClass = InSubClass;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__InSubClass_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025998 RID: 154008 RVA: 0x0038D6A8 File Offset: 0x0038B8A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InStClassSet([Nullable(new byte[]
		{
			2,
			1
		})] in TSet<UClass> InStClassSet)
		{
			UTestClass_UFunction_UClass.__InStClassSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__InStClassSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__InStClassSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__InStClassSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<UClass> tset = InStClassSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InStClassSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__InStClassSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<UClass> tset2 = InStClassSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InStClassSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__InStClassSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025999 RID: 154009 RVA: 0x0038D724 File Offset: 0x0038B924
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InStClassMap([Nullable(new byte[]
		{
			2,
			1
		})] in TMap<UClass, int> InStClassMap)
		{
			UTestClass_UFunction_UClass.__InStClassMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__InStClassMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__InStClassMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__InStClassMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<UClass, int> tmap = InStClassMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InStClassMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__InStClassMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<UClass, int> tmap2 = InStClassMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InStClassMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__InStClassMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602599A RID: 154010 RVA: 0x0038D7A0 File Offset: 0x0038B9A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InStClassArray([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<UClass> InStClassArray)
		{
			UTestClass_UFunction_UClass.__InStClassArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__InStClassArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__InStClassArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__InStClassArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<UClass> tarray = InStClassArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InStClassArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__InStClassArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<UClass> tarray2 = InStClassArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InStClassArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__InStClassArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602599B RID: 154011 RVA: 0x0038D81C File Offset: 0x0038BA1C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InStClass(in UClassStackOnlyPtr InStClass)
		{
			UTestClass_UFunction_UClass.__InStClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__InStClass_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__InStClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__InStClass_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InStClass = InStClass;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__InStClass_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602599C RID: 154012 RVA: 0x0038D868 File Offset: 0x0038BA68
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InSoftClassSet([Nullable(new byte[]
		{
			2,
			1,
			1
		})] in TSet<TSoftClassPtr<USharpherealTestSimpleClass>> InSoftClassSet)
		{
			UTestClass_UFunction_UClass.__InSoftClassSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__InSoftClassSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__InSoftClassSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__InSoftClassSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<TSoftClassPtr<USharpherealTestSimpleClass>> tset = InSoftClassSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InSoftClassSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__InSoftClassSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<TSoftClassPtr<USharpherealTestSimpleClass>> tset2 = InSoftClassSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InSoftClassSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__InSoftClassSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602599D RID: 154013 RVA: 0x0038D8E4 File Offset: 0x0038BAE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InSoftClassMap([Nullable(new byte[]
		{
			2,
			1,
			1
		})] in TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int> InSoftClassMap)
		{
			UTestClass_UFunction_UClass.__InSoftClassMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__InSoftClassMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__InSoftClassMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__InSoftClassMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int> tmap = InSoftClassMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InSoftClassMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__InSoftClassMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int> tmap2 = InSoftClassMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InSoftClassMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__InSoftClassMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602599E RID: 154014 RVA: 0x0038D960 File Offset: 0x0038BB60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InSoftClassArray([Nullable(new byte[]
		{
			2,
			1,
			1
		})] in TArray<TSoftClassPtr<USharpherealTestSimpleClass>> InSoftClassArray)
		{
			UTestClass_UFunction_UClass.__InSoftClassArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__InSoftClassArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__InSoftClassArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__InSoftClassArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<TSoftClassPtr<USharpherealTestSimpleClass>> tarray = InSoftClassArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InSoftClassArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__InSoftClassArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<TSoftClassPtr<USharpherealTestSimpleClass>> tarray2 = InSoftClassArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InSoftClassArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__InSoftClassArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602599F RID: 154015 RVA: 0x0038D9DC File Offset: 0x0038BBDC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InSoftClass(in TSoftClassPtr<USharpherealTestSimpleClass> InSoftClass)
		{
			UTestClass_UFunction_UClass.__InSoftClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__InSoftClass_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__InSoftClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__InSoftClass_NativeFunctionPtr, (void*)ptr, 1);
			if (InSoftClass != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->InSoftClass, InSoftClass.NativePtr, 1);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__InSoftClass_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__InSoftClass_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060259A0 RID: 154016 RVA: 0x0038DA4C File Offset: 0x0038BC4C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InClassPathSet([Nullable(new byte[]
		{
			2,
			1
		})] in TSet<FSoftClassPath> InClassPathSet)
		{
			UTestClass_UFunction_UClass.__InClassPathSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__InClassPathSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__InClassPathSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__InClassPathSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<FSoftClassPath> tset = InClassPathSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InClassPathSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__InClassPathSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<FSoftClassPath> tset2 = InClassPathSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InClassPathSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__InClassPathSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060259A1 RID: 154017 RVA: 0x0038DAC8 File Offset: 0x0038BCC8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InClassPathMap([Nullable(new byte[]
		{
			2,
			1
		})] in TMap<FSoftClassPath, int> InClassPathMap)
		{
			UTestClass_UFunction_UClass.__InClassPathMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__InClassPathMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__InClassPathMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__InClassPathMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FSoftClassPath, int> tmap = InClassPathMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InClassPathMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__InClassPathMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FSoftClassPath, int> tmap2 = InClassPathMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InClassPathMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__InClassPathMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060259A2 RID: 154018 RVA: 0x0038DB44 File Offset: 0x0038BD44
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InClassPathArray([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FSoftClassPath> InClassPathArray)
		{
			UTestClass_UFunction_UClass.__InClassPathArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__InClassPathArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__InClassPathArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__InClassPathArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FSoftClassPath> tarray = InClassPathArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InClassPathArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__InClassPathArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FSoftClassPath> tarray2 = InClassPathArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InClassPathArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__InClassPathArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060259A3 RID: 154019 RVA: 0x0038DBC0 File Offset: 0x0038BDC0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InClassPath(in FSoftClassPath InClassPath)
		{
			UTestClass_UFunction_UClass.__InClassPath_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__InClassPath_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__InClassPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__InClassPath_NativeFunctionPtr, (void*)ptr, 1);
			if (InClassPath != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), &ptr->InClassPath, InClassPath.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__InClassPath_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__InClassPath_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060259A4 RID: 154020 RVA: 0x0038DC38 File Offset: 0x0038BE38
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		[return: Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public unsafe TSet<TSubclassOf<USharpherealTestSimpleClass>> GetSubClassSet()
		{
			UTestClass_UFunction_UClass.__GetSubClassSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__GetSubClassSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__GetSubClassSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__GetSubClassSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__GetSubClassSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<TSubclassOf<USharpherealTestSimpleClass>> result = new TSet<TSubclassOf<USharpherealTestSimpleClass>>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__GetSubClassSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060259A5 RID: 154021 RVA: 0x0038DC98 File Offset: 0x0038BE98
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		[return: Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public unsafe TMap<TSubclassOf<USharpherealTestSimpleClass>, int> GetSubClassMap()
		{
			UTestClass_UFunction_UClass.__GetSubClassMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__GetSubClassMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__GetSubClassMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__GetSubClassMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__GetSubClassMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<TSubclassOf<USharpherealTestSimpleClass>, int> result = new TMap<TSubclassOf<USharpherealTestSimpleClass>, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__GetSubClassMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060259A6 RID: 154022 RVA: 0x0038DCF8 File Offset: 0x0038BEF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		[return: Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public unsafe TArray<TSubclassOf<USharpherealTestSimpleClass>> GetSubClassArray()
		{
			UTestClass_UFunction_UClass.__GetSubClassArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__GetSubClassArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__GetSubClassArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__GetSubClassArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__GetSubClassArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<TSubclassOf<USharpherealTestSimpleClass>> result = new TArray<TSubclassOf<USharpherealTestSimpleClass>>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__GetSubClassArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060259A7 RID: 154023 RVA: 0x0038DD58 File Offset: 0x0038BF58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<USharpherealTestSimpleClass> GetSubClass()
		{
			UTestClass_UFunction_UClass.__GetSubClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__GetSubClass_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__GetSubClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__GetSubClass_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__GetSubClass_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060259A8 RID: 154024 RVA: 0x0038DDA0 File Offset: 0x0038BFA0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<UClass> GetStClassSet()
		{
			UTestClass_UFunction_UClass.__GetStClassSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__GetStClassSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__GetStClassSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__GetStClassSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__GetStClassSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<UClass> result = new TSet<UClass>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__GetStClassSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060259A9 RID: 154025 RVA: 0x0038DE00 File Offset: 0x0038C000
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<UClass, int> GetStClassMap()
		{
			UTestClass_UFunction_UClass.__GetStClassMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__GetStClassMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__GetStClassMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__GetStClassMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__GetStClassMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<UClass, int> result = new TMap<UClass, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__GetStClassMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060259AA RID: 154026 RVA: 0x0038DE60 File Offset: 0x0038C060
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<UClass> GetStClassArray()
		{
			UTestClass_UFunction_UClass.__GetStClassArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__GetStClassArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__GetStClassArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__GetStClassArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__GetStClassArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<UClass> result = new TArray<UClass>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__GetStClassArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060259AB RID: 154027 RVA: 0x0038DEC0 File Offset: 0x0038C0C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe UClassStackOnlyPtr GetStClass()
		{
			UTestClass_UFunction_UClass.__GetStClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__GetStClass_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__GetStClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__GetStClass_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__GetStClass_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060259AC RID: 154028 RVA: 0x0038DF08 File Offset: 0x0038C108
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<TSoftClassPtr<USharpherealTestSimpleClass>> GetSoftClassSet()
		{
			UTestClass_UFunction_UClass.__GetSoftClassSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__GetSoftClassSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__GetSoftClassSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__GetSoftClassSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__GetSoftClassSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<TSoftClassPtr<USharpherealTestSimpleClass>> result = new TSet<TSoftClassPtr<USharpherealTestSimpleClass>>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__GetSoftClassSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060259AD RID: 154029 RVA: 0x0038DF68 File Offset: 0x0038C168
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int> GetSoftClassMap()
		{
			UTestClass_UFunction_UClass.__GetSoftClassMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__GetSoftClassMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__GetSoftClassMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__GetSoftClassMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__GetSoftClassMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int> result = new TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__GetSoftClassMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060259AE RID: 154030 RVA: 0x0038DFC8 File Offset: 0x0038C1C8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<TSoftClassPtr<USharpherealTestSimpleClass>> GetSoftClassArray()
		{
			UTestClass_UFunction_UClass.__GetSoftClassArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__GetSoftClassArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__GetSoftClassArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__GetSoftClassArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__GetSoftClassArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<TSoftClassPtr<USharpherealTestSimpleClass>> result = new TArray<TSoftClassPtr<USharpherealTestSimpleClass>>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__GetSoftClassArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060259AF RID: 154031 RVA: 0x0038E028 File Offset: 0x0038C228
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSoftClassPtr<USharpherealTestSimpleClass> GetSoftClass()
		{
			UTestClass_UFunction_UClass.__GetSoftClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__GetSoftClass_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__GetSoftClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__GetSoftClass_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__GetSoftClass_NativeFunctionPtr, (void*)ptr, 0);
			TSoftClassPtr<USharpherealTestSimpleClass> result = new TSoftClassPtr<USharpherealTestSimpleClass>(&ptr->__Result, false, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__GetSoftClass_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060259B0 RID: 154032 RVA: 0x0038E088 File Offset: 0x0038C288
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<FSoftClassPath> GetClassPathSet()
		{
			UTestClass_UFunction_UClass.__GetClassPathSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__GetClassPathSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__GetClassPathSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__GetClassPathSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__GetClassPathSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<FSoftClassPath> result = new TSet<FSoftClassPath>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__GetClassPathSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060259B1 RID: 154033 RVA: 0x0038E0E8 File Offset: 0x0038C2E8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<FSoftClassPath, int> GetClassPathMap()
		{
			UTestClass_UFunction_UClass.__GetClassPathMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__GetClassPathMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__GetClassPathMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__GetClassPathMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__GetClassPathMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FSoftClassPath, int> result = new TMap<FSoftClassPath, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__GetClassPathMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060259B2 RID: 154034 RVA: 0x0038E148 File Offset: 0x0038C348
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<FSoftClassPath> GetClassPathArray()
		{
			UTestClass_UFunction_UClass.__GetClassPathArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__GetClassPathArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__GetClassPathArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__GetClassPathArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__GetClassPathArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FSoftClassPath> result = new TArray<FSoftClassPath>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__GetClassPathArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060259B3 RID: 154035 RVA: 0x0038E1A8 File Offset: 0x0038C3A8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FSoftClassPath GetClassPath()
		{
			UTestClass_UFunction_UClass.__GetClassPath_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__GetClassPath_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__GetClassPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__GetClassPath_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__GetClassPath_NativeFunctionPtr, (void*)ptr, 0);
			FSoftClassPath result = new FSoftClassPath(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__GetClassPath_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060259B4 RID: 154036 RVA: 0x0038E207 File Offset: 0x0038C407
		static UTestClass_UFunction_UClass()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SharpherealTest.TestClass_UFunction_UClass");
		}

		// Token: 0x060259B5 RID: 154037 RVA: 0x0038E215 File Offset: 0x0038C415
		protected UTestClass_UFunction_UClass(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401465F RID: 83551
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SharpherealTest.TestClass_UFunction_UClass";

		// Token: 0x04014660 RID: 83552
		private static IntPtr _ClassPtr;

		// Token: 0x04014661 RID: 83553
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014662 RID: 83554
		internal static int __PropertyOffset_StClass;

		// Token: 0x04014663 RID: 83555
		internal static int __PropertyOffset_StClassArray;

		// Token: 0x04014664 RID: 83556
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UClass> _StClassArray;

		// Token: 0x04014665 RID: 83557
		internal static int __PropertyOffset_StClassSet;

		// Token: 0x04014666 RID: 83558
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UClass> _StClassSet;

		// Token: 0x04014667 RID: 83559
		internal static int __PropertyOffset_StClassMap;

		// Token: 0x04014668 RID: 83560
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<UClass, int> _StClassMap;

		// Token: 0x04014669 RID: 83561
		internal static int __PropertyOffset_SoftClass;

		// Token: 0x0401466A RID: 83562
		internal static int __PropertyOffset_SoftClassArray;

		// Token: 0x0401466B RID: 83563
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TArray<TSoftClassPtr<USharpherealTestSimpleClass>> _SoftClassArray;

		// Token: 0x0401466C RID: 83564
		internal static int __PropertyOffset_SoftClassSet;

		// Token: 0x0401466D RID: 83565
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TSet<TSoftClassPtr<USharpherealTestSimpleClass>> _SoftClassSet;

		// Token: 0x0401466E RID: 83566
		internal static int __PropertyOffset_SoftClassMap;

		// Token: 0x0401466F RID: 83567
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int> _SoftClassMap;

		// Token: 0x04014670 RID: 83568
		internal static int __PropertyOffset_SubClass;

		// Token: 0x04014671 RID: 83569
		internal static int __PropertyOffset_SubClassArray;

		// Token: 0x04014672 RID: 83570
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TSubclassOf<USharpherealTestSimpleClass>> _SubClassArray;

		// Token: 0x04014673 RID: 83571
		internal static int __PropertyOffset_SubClassSet;

		// Token: 0x04014674 RID: 83572
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TSet<TSubclassOf<USharpherealTestSimpleClass>> _SubClassSet;

		// Token: 0x04014675 RID: 83573
		internal static int __PropertyOffset_SubClassMap;

		// Token: 0x04014676 RID: 83574
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TSubclassOf<USharpherealTestSimpleClass>, int> _SubClassMap;

		// Token: 0x04014677 RID: 83575
		internal static int __PropertyOffset_ClassPath;

		// Token: 0x04014678 RID: 83576
		[Nullable(2)]
		private FSoftClassPath _ClassPath;

		// Token: 0x04014679 RID: 83577
		internal static int __PropertyOffset_ClassPathArray;

		// Token: 0x0401467A RID: 83578
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoftClassPath> _ClassPathArray;

		// Token: 0x0401467B RID: 83579
		internal static int __PropertyOffset_ClassPathSet;

		// Token: 0x0401467C RID: 83580
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<FSoftClassPath> _ClassPathSet;

		// Token: 0x0401467D RID: 83581
		internal static int __PropertyOffset_ClassPathMap;

		// Token: 0x0401467E RID: 83582
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FSoftClassPath, int> _ClassPathMap;

		// Token: 0x0401467F RID: 83583
		private static IntPtr __SetSubPathString_NativeFunctionPtr;

		// Token: 0x04014680 RID: 83584
		private static IntPtr __SetSubClassSet_NativeFunctionPtr;

		// Token: 0x04014681 RID: 83585
		private static IntPtr __SetSubClassMap_NativeFunctionPtr;

		// Token: 0x04014682 RID: 83586
		private static IntPtr __SetSubClassArray_NativeFunctionPtr;

		// Token: 0x04014683 RID: 83587
		private static IntPtr __SetSubClass_NativeFunctionPtr;

		// Token: 0x04014684 RID: 83588
		private static IntPtr __SetStClassSet_NativeFunctionPtr;

		// Token: 0x04014685 RID: 83589
		private static IntPtr __SetStClassMap_NativeFunctionPtr;

		// Token: 0x04014686 RID: 83590
		private static IntPtr __SetStClassArray_NativeFunctionPtr;

		// Token: 0x04014687 RID: 83591
		private static IntPtr __SetStClass_NativeFunctionPtr;

		// Token: 0x04014688 RID: 83592
		private static IntPtr __SetSoftClassSet_NativeFunctionPtr;

		// Token: 0x04014689 RID: 83593
		private static IntPtr __SetSoftClassMap_NativeFunctionPtr;

		// Token: 0x0401468A RID: 83594
		private static IntPtr __SetSoftClassArray_NativeFunctionPtr;

		// Token: 0x0401468B RID: 83595
		private static IntPtr __SetSoftClass_NativeFunctionPtr;

		// Token: 0x0401468C RID: 83596
		private static IntPtr __SetClassPathSet_NativeFunctionPtr;

		// Token: 0x0401468D RID: 83597
		private static IntPtr __SetClassPathMap_NativeFunctionPtr;

		// Token: 0x0401468E RID: 83598
		private static IntPtr __SetClassPathArray_NativeFunctionPtr;

		// Token: 0x0401468F RID: 83599
		private static IntPtr __SetClassPath_NativeFunctionPtr;

		// Token: 0x04014690 RID: 83600
		private static IntPtr __OutSubClassSet_NativeFunctionPtr;

		// Token: 0x04014691 RID: 83601
		private static IntPtr __OutSubClassMap_NativeFunctionPtr;

		// Token: 0x04014692 RID: 83602
		private static IntPtr __OutSubClassArray_NativeFunctionPtr;

		// Token: 0x04014693 RID: 83603
		private static IntPtr __OutSubClass_NativeFunctionPtr;

		// Token: 0x04014694 RID: 83604
		private static IntPtr __OutStClassSet_NativeFunctionPtr;

		// Token: 0x04014695 RID: 83605
		private static IntPtr __OutStClassMap_NativeFunctionPtr;

		// Token: 0x04014696 RID: 83606
		private static IntPtr __OutStClassArray_NativeFunctionPtr;

		// Token: 0x04014697 RID: 83607
		private static IntPtr __OutStClass_NativeFunctionPtr;

		// Token: 0x04014698 RID: 83608
		private static IntPtr __OutSoftClassSet_NativeFunctionPtr;

		// Token: 0x04014699 RID: 83609
		private static IntPtr __OutSoftClassMap_NativeFunctionPtr;

		// Token: 0x0401469A RID: 83610
		private static IntPtr __OutSoftClassArray_NativeFunctionPtr;

		// Token: 0x0401469B RID: 83611
		private static IntPtr __OutSoftClass_NativeFunctionPtr;

		// Token: 0x0401469C RID: 83612
		private static IntPtr __OutClassPathSet_NativeFunctionPtr;

		// Token: 0x0401469D RID: 83613
		private static IntPtr __OutClassPathMap_NativeFunctionPtr;

		// Token: 0x0401469E RID: 83614
		private static IntPtr __OutClassPathArray_NativeFunctionPtr;

		// Token: 0x0401469F RID: 83615
		private static IntPtr __OutClassPath_NativeFunctionPtr;

		// Token: 0x040146A0 RID: 83616
		private static IntPtr __InSubClassSet_NativeFunctionPtr;

		// Token: 0x040146A1 RID: 83617
		private static IntPtr __InSubClassMap_NativeFunctionPtr;

		// Token: 0x040146A2 RID: 83618
		private static IntPtr __InSubClassArray_NativeFunctionPtr;

		// Token: 0x040146A3 RID: 83619
		private static IntPtr __InSubClass_NativeFunctionPtr;

		// Token: 0x040146A4 RID: 83620
		private static IntPtr __InStClassSet_NativeFunctionPtr;

		// Token: 0x040146A5 RID: 83621
		private static IntPtr __InStClassMap_NativeFunctionPtr;

		// Token: 0x040146A6 RID: 83622
		private static IntPtr __InStClassArray_NativeFunctionPtr;

		// Token: 0x040146A7 RID: 83623
		private static IntPtr __InStClass_NativeFunctionPtr;

		// Token: 0x040146A8 RID: 83624
		private static IntPtr __InSoftClassSet_NativeFunctionPtr;

		// Token: 0x040146A9 RID: 83625
		private static IntPtr __InSoftClassMap_NativeFunctionPtr;

		// Token: 0x040146AA RID: 83626
		private static IntPtr __InSoftClassArray_NativeFunctionPtr;

		// Token: 0x040146AB RID: 83627
		private static IntPtr __InSoftClass_NativeFunctionPtr;

		// Token: 0x040146AC RID: 83628
		private static IntPtr __InClassPathSet_NativeFunctionPtr;

		// Token: 0x040146AD RID: 83629
		private static IntPtr __InClassPathMap_NativeFunctionPtr;

		// Token: 0x040146AE RID: 83630
		private static IntPtr __InClassPathArray_NativeFunctionPtr;

		// Token: 0x040146AF RID: 83631
		private static IntPtr __InClassPath_NativeFunctionPtr;

		// Token: 0x040146B0 RID: 83632
		private static IntPtr __GetSubClassSet_NativeFunctionPtr;

		// Token: 0x040146B1 RID: 83633
		private static IntPtr __GetSubClassMap_NativeFunctionPtr;

		// Token: 0x040146B2 RID: 83634
		private static IntPtr __GetSubClassArray_NativeFunctionPtr;

		// Token: 0x040146B3 RID: 83635
		private static IntPtr __GetSubClass_NativeFunctionPtr;

		// Token: 0x040146B4 RID: 83636
		private static IntPtr __GetStClassSet_NativeFunctionPtr;

		// Token: 0x040146B5 RID: 83637
		private static IntPtr __GetStClassMap_NativeFunctionPtr;

		// Token: 0x040146B6 RID: 83638
		private static IntPtr __GetStClassArray_NativeFunctionPtr;

		// Token: 0x040146B7 RID: 83639
		private static IntPtr __GetStClass_NativeFunctionPtr;

		// Token: 0x040146B8 RID: 83640
		private static IntPtr __GetSoftClassSet_NativeFunctionPtr;

		// Token: 0x040146B9 RID: 83641
		private static IntPtr __GetSoftClassMap_NativeFunctionPtr;

		// Token: 0x040146BA RID: 83642
		private static IntPtr __GetSoftClassArray_NativeFunctionPtr;

		// Token: 0x040146BB RID: 83643
		private static IntPtr __GetSoftClass_NativeFunctionPtr;

		// Token: 0x040146BC RID: 83644
		private static IntPtr __GetClassPathSet_NativeFunctionPtr;

		// Token: 0x040146BD RID: 83645
		private static IntPtr __GetClassPathMap_NativeFunctionPtr;

		// Token: 0x040146BE RID: 83646
		private static IntPtr __GetClassPathArray_NativeFunctionPtr;

		// Token: 0x040146BF RID: 83647
		private static IntPtr __GetClassPath_NativeFunctionPtr;

		// Token: 0x020039C5 RID: 14789
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __SetSubPathString_FunctionParams
		{
			// Token: 0x04017AEE RID: 97006
			[FieldOffset(0)]
			public byte ObjectPtr;

			// Token: 0x04017AEF RID: 97007
			[FieldOffset(48)]
			public FString SubPathString;
		}

		// Token: 0x020039C6 RID: 14790
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetSubClassSet_FunctionParams
		{
			// Token: 0x04017AF0 RID: 97008
			[FieldOffset(0)]
			public byte InSubClassSet;
		}

		// Token: 0x020039C7 RID: 14791
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetSubClassMap_FunctionParams
		{
			// Token: 0x04017AF1 RID: 97009
			[FieldOffset(0)]
			public byte InSubClassMap;
		}

		// Token: 0x020039C8 RID: 14792
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetSubClassArray_FunctionParams
		{
			// Token: 0x04017AF2 RID: 97010
			[FieldOffset(0)]
			public byte InSubClassArray;
		}

		// Token: 0x020039C9 RID: 14793
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetSubClass_FunctionParams
		{
			// Token: 0x04017AF3 RID: 97011
			[Nullable(new byte[]
			{
				0,
				1
			})]
			[FieldOffset(0)]
			public TSubclassOf<USharpherealTestSimpleClass> InSubClass;
		}

		// Token: 0x020039CA RID: 14794
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetStClassSet_FunctionParams
		{
			// Token: 0x04017AF4 RID: 97012
			[FieldOffset(0)]
			public byte InStClassSet;
		}

		// Token: 0x020039CB RID: 14795
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetStClassMap_FunctionParams
		{
			// Token: 0x04017AF5 RID: 97013
			[FieldOffset(0)]
			public byte InStClassMap;
		}

		// Token: 0x020039CC RID: 14796
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetStClassArray_FunctionParams
		{
			// Token: 0x04017AF6 RID: 97014
			[FieldOffset(0)]
			public byte InStClassArray;
		}

		// Token: 0x020039CD RID: 14797
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetStClass_FunctionParams
		{
			// Token: 0x04017AF7 RID: 97015
			[FieldOffset(0)]
			public UClassStackOnlyPtr InStClass;
		}

		// Token: 0x020039CE RID: 14798
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetSoftClassSet_FunctionParams
		{
			// Token: 0x04017AF8 RID: 97016
			[FieldOffset(0)]
			public byte InSoftClassSet;
		}

		// Token: 0x020039CF RID: 14799
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetSoftClassMap_FunctionParams
		{
			// Token: 0x04017AF9 RID: 97017
			[FieldOffset(0)]
			public byte InSoftClassMap;
		}

		// Token: 0x020039D0 RID: 14800
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetSoftClassArray_FunctionParams
		{
			// Token: 0x04017AFA RID: 97018
			[FieldOffset(0)]
			public byte InSoftClassArray;
		}

		// Token: 0x020039D1 RID: 14801
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __SetSoftClass_FunctionParams
		{
			// Token: 0x04017AFB RID: 97019
			[FieldOffset(0)]
			public byte InSoftClass;
		}

		// Token: 0x020039D2 RID: 14802
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetClassPathSet_FunctionParams
		{
			// Token: 0x04017AFC RID: 97020
			[FieldOffset(0)]
			public byte InClassPathSet;
		}

		// Token: 0x020039D3 RID: 14803
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetClassPathMap_FunctionParams
		{
			// Token: 0x04017AFD RID: 97021
			[FieldOffset(0)]
			public byte InClassPathMap;
		}

		// Token: 0x020039D4 RID: 14804
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetClassPathArray_FunctionParams
		{
			// Token: 0x04017AFE RID: 97022
			[FieldOffset(0)]
			public byte InClassPathArray;
		}

		// Token: 0x020039D5 RID: 14805
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetClassPath_FunctionParams
		{
			// Token: 0x04017AFF RID: 97023
			[FieldOffset(0)]
			public byte InClassPath;
		}

		// Token: 0x020039D6 RID: 14806
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutSubClassSet_FunctionParams
		{
			// Token: 0x04017B00 RID: 97024
			[FieldOffset(0)]
			public byte OutSubClassSet;
		}

		// Token: 0x020039D7 RID: 14807
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutSubClassMap_FunctionParams
		{
			// Token: 0x04017B01 RID: 97025
			[FieldOffset(0)]
			public byte OutSubClassMap;
		}

		// Token: 0x020039D8 RID: 14808
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutSubClassArray_FunctionParams
		{
			// Token: 0x04017B02 RID: 97026
			[FieldOffset(0)]
			public byte OutSubClassArray;
		}

		// Token: 0x020039D9 RID: 14809
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OutSubClass_FunctionParams
		{
			// Token: 0x04017B03 RID: 97027
			[Nullable(new byte[]
			{
				0,
				1
			})]
			[FieldOffset(0)]
			public TSubclassOf<USharpherealTestSimpleClass> OutSubClass;
		}

		// Token: 0x020039DA RID: 14810
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutStClassSet_FunctionParams
		{
			// Token: 0x04017B04 RID: 97028
			[FieldOffset(0)]
			public byte OutStClassSet;
		}

		// Token: 0x020039DB RID: 14811
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutStClassMap_FunctionParams
		{
			// Token: 0x04017B05 RID: 97029
			[FieldOffset(0)]
			public byte OutStClassMap;
		}

		// Token: 0x020039DC RID: 14812
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutStClassArray_FunctionParams
		{
			// Token: 0x04017B06 RID: 97030
			[FieldOffset(0)]
			public byte OutStClassArray;
		}

		// Token: 0x020039DD RID: 14813
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OutStClass_FunctionParams
		{
			// Token: 0x04017B07 RID: 97031
			[FieldOffset(0)]
			public UClassStackOnlyPtr OutStClass;
		}

		// Token: 0x020039DE RID: 14814
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutSoftClassSet_FunctionParams
		{
			// Token: 0x04017B08 RID: 97032
			[FieldOffset(0)]
			public byte OutSoftClassSet;
		}

		// Token: 0x020039DF RID: 14815
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutSoftClassMap_FunctionParams
		{
			// Token: 0x04017B09 RID: 97033
			[FieldOffset(0)]
			public byte OutSoftClassMap;
		}

		// Token: 0x020039E0 RID: 14816
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutSoftClassArray_FunctionParams
		{
			// Token: 0x04017B0A RID: 97034
			[FieldOffset(0)]
			public byte OutSoftClassArray;
		}

		// Token: 0x020039E1 RID: 14817
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __OutSoftClass_FunctionParams
		{
			// Token: 0x04017B0B RID: 97035
			[FieldOffset(0)]
			public byte OutSoftClass;
		}

		// Token: 0x020039E2 RID: 14818
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutClassPathSet_FunctionParams
		{
			// Token: 0x04017B0C RID: 97036
			[FieldOffset(0)]
			public byte OutClassPathSet;
		}

		// Token: 0x020039E3 RID: 14819
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutClassPathMap_FunctionParams
		{
			// Token: 0x04017B0D RID: 97037
			[FieldOffset(0)]
			public byte OutClassPathMap;
		}

		// Token: 0x020039E4 RID: 14820
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutClassPathArray_FunctionParams
		{
			// Token: 0x04017B0E RID: 97038
			[FieldOffset(0)]
			public byte OutClassPathArray;
		}

		// Token: 0x020039E5 RID: 14821
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __OutClassPath_FunctionParams
		{
			// Token: 0x04017B0F RID: 97039
			[FieldOffset(0)]
			public byte OutClassPath;
		}

		// Token: 0x020039E6 RID: 14822
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InSubClassSet_FunctionParams
		{
			// Token: 0x04017B10 RID: 97040
			[FieldOffset(0)]
			public byte InSubClassSet;
		}

		// Token: 0x020039E7 RID: 14823
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InSubClassMap_FunctionParams
		{
			// Token: 0x04017B11 RID: 97041
			[FieldOffset(0)]
			public byte InSubClassMap;
		}

		// Token: 0x020039E8 RID: 14824
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InSubClassArray_FunctionParams
		{
			// Token: 0x04017B12 RID: 97042
			[FieldOffset(0)]
			public byte InSubClassArray;
		}

		// Token: 0x020039E9 RID: 14825
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __InSubClass_FunctionParams
		{
			// Token: 0x04017B13 RID: 97043
			[Nullable(new byte[]
			{
				0,
				1
			})]
			[FieldOffset(0)]
			public TSubclassOf<USharpherealTestSimpleClass> InSubClass;
		}

		// Token: 0x020039EA RID: 14826
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InStClassSet_FunctionParams
		{
			// Token: 0x04017B14 RID: 97044
			[FieldOffset(0)]
			public byte InStClassSet;
		}

		// Token: 0x020039EB RID: 14827
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InStClassMap_FunctionParams
		{
			// Token: 0x04017B15 RID: 97045
			[FieldOffset(0)]
			public byte InStClassMap;
		}

		// Token: 0x020039EC RID: 14828
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InStClassArray_FunctionParams
		{
			// Token: 0x04017B16 RID: 97046
			[FieldOffset(0)]
			public byte InStClassArray;
		}

		// Token: 0x020039ED RID: 14829
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __InStClass_FunctionParams
		{
			// Token: 0x04017B17 RID: 97047
			[FieldOffset(0)]
			public UClassStackOnlyPtr InStClass;
		}

		// Token: 0x020039EE RID: 14830
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InSoftClassSet_FunctionParams
		{
			// Token: 0x04017B18 RID: 97048
			[FieldOffset(0)]
			public byte InSoftClassSet;
		}

		// Token: 0x020039EF RID: 14831
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InSoftClassMap_FunctionParams
		{
			// Token: 0x04017B19 RID: 97049
			[FieldOffset(0)]
			public byte InSoftClassMap;
		}

		// Token: 0x020039F0 RID: 14832
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InSoftClassArray_FunctionParams
		{
			// Token: 0x04017B1A RID: 97050
			[FieldOffset(0)]
			public byte InSoftClassArray;
		}

		// Token: 0x020039F1 RID: 14833
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __InSoftClass_FunctionParams
		{
			// Token: 0x04017B1B RID: 97051
			[FieldOffset(0)]
			public byte InSoftClass;
		}

		// Token: 0x020039F2 RID: 14834
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InClassPathSet_FunctionParams
		{
			// Token: 0x04017B1C RID: 97052
			[FieldOffset(0)]
			public byte InClassPathSet;
		}

		// Token: 0x020039F3 RID: 14835
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InClassPathMap_FunctionParams
		{
			// Token: 0x04017B1D RID: 97053
			[FieldOffset(0)]
			public byte InClassPathMap;
		}

		// Token: 0x020039F4 RID: 14836
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InClassPathArray_FunctionParams
		{
			// Token: 0x04017B1E RID: 97054
			[FieldOffset(0)]
			public byte InClassPathArray;
		}

		// Token: 0x020039F5 RID: 14837
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InClassPath_FunctionParams
		{
			// Token: 0x04017B1F RID: 97055
			[FieldOffset(0)]
			public byte InClassPath;
		}

		// Token: 0x020039F6 RID: 14838
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetSubClassSet_FunctionParams
		{
			// Token: 0x04017B20 RID: 97056
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020039F7 RID: 14839
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetSubClassMap_FunctionParams
		{
			// Token: 0x04017B21 RID: 97057
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020039F8 RID: 14840
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSubClassArray_FunctionParams
		{
			// Token: 0x04017B22 RID: 97058
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020039F9 RID: 14841
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetSubClass_FunctionParams
		{
			// Token: 0x04017B23 RID: 97059
			[Nullable(new byte[]
			{
				0,
				1
			})]
			[FieldOffset(0)]
			public TSubclassOf<USharpherealTestSimpleClass> __Result;
		}

		// Token: 0x020039FA RID: 14842
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetStClassSet_FunctionParams
		{
			// Token: 0x04017B24 RID: 97060
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020039FB RID: 14843
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetStClassMap_FunctionParams
		{
			// Token: 0x04017B25 RID: 97061
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020039FC RID: 14844
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetStClassArray_FunctionParams
		{
			// Token: 0x04017B26 RID: 97062
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020039FD RID: 14845
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetStClass_FunctionParams
		{
			// Token: 0x04017B27 RID: 97063
			[FieldOffset(0)]
			public UClassStackOnlyPtr __Result;
		}

		// Token: 0x020039FE RID: 14846
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetSoftClassSet_FunctionParams
		{
			// Token: 0x04017B28 RID: 97064
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020039FF RID: 14847
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetSoftClassMap_FunctionParams
		{
			// Token: 0x04017B29 RID: 97065
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003A00 RID: 14848
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSoftClassArray_FunctionParams
		{
			// Token: 0x04017B2A RID: 97066
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003A01 RID: 14849
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __GetSoftClass_FunctionParams
		{
			// Token: 0x04017B2B RID: 97067
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003A02 RID: 14850
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetClassPathSet_FunctionParams
		{
			// Token: 0x04017B2C RID: 97068
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003A03 RID: 14851
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetClassPathMap_FunctionParams
		{
			// Token: 0x04017B2D RID: 97069
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003A04 RID: 14852
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetClassPathArray_FunctionParams
		{
			// Token: 0x04017B2E RID: 97070
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003A05 RID: 14853
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetClassPath_FunctionParams
		{
			// Token: 0x04017B2F RID: 97071
			[FieldOffset(0)]
			public byte __Result;
		}
	}
}
