using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200274C RID: 10060
	[UnrealObjectPath("/Script/SharpherealTest.TestClass_UFunction_Direct_UClass")]
	[UnrealStructLayout(848, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 848)]
	public class UTestClass_UFunction_Direct_UClass : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602578C RID: 153484 RVA: 0x00383B11 File Offset: 0x00381D11
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTestClass_UFunction_Direct_UClass._ClassPtr;
		}

		// Token: 0x0602578D RID: 153485 RVA: 0x00383B20 File Offset: 0x00381D20
		public UTestClass_UFunction_Direct_UClass() : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_Direct_UClass.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602578E RID: 153486 RVA: 0x00383B48 File Offset: 0x00381D48
		[NullableContext(1)]
		public UTestClass_UFunction_Direct_UClass(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_Direct_UClass.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009094 RID: 37012
		// (get) Token: 0x0602578F RID: 153487 RVA: 0x00383B7B File Offset: 0x00381D7B
		// (set) Token: 0x06025790 RID: 153488 RVA: 0x00383B8F File Offset: 0x00381D8F
		public unsafe UClassStackOnlyPtr StClass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UClass.__PropertyOffset_StClass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UClass.__PropertyOffset_StClass) = value;
			}
		}

		// Token: 0x17009095 RID: 37013
		// (get) Token: 0x06025791 RID: 153489 RVA: 0x00383BA4 File Offset: 0x00381DA4
		// (set) Token: 0x06025792 RID: 153490 RVA: 0x00383BDD File Offset: 0x00381DDD
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
					result = (this._StClassArray = new TArray<UClass>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UClass.__PropertyOffset_StClassArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.StClassArray.CopyAssign(value);
			}
		}

		// Token: 0x17009096 RID: 37014
		// (get) Token: 0x06025793 RID: 153491 RVA: 0x00383BEC File Offset: 0x00381DEC
		// (set) Token: 0x06025794 RID: 153492 RVA: 0x00383C25 File Offset: 0x00381E25
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
					result = (this._StClassSet = new TSet<UClass>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UClass.__PropertyOffset_StClassSet, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.StClassSet.CopyAssign(value);
			}
		}

		// Token: 0x17009097 RID: 37015
		// (get) Token: 0x06025795 RID: 153493 RVA: 0x00383C34 File Offset: 0x00381E34
		// (set) Token: 0x06025796 RID: 153494 RVA: 0x00383C6D File Offset: 0x00381E6D
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
					result = (this._StClassMap = new TMap<UClass, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UClass.__PropertyOffset_StClassMap, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.StClassMap.CopyAssign(value);
			}
		}

		// Token: 0x17009098 RID: 37016
		// (get) Token: 0x06025797 RID: 153495 RVA: 0x00383C7B File Offset: 0x00381E7B
		// (set) Token: 0x06025798 RID: 153496 RVA: 0x00383C90 File Offset: 0x00381E90
		[Nullable(1)]
		public TSoftClassPtr<USharpherealTestSimpleClass> SoftClass
		{
			[NullableContext(1)]
			get
			{
				return new TSoftClassPtr<USharpherealTestSimpleClass>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UClass.__PropertyOffset_SoftClass, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UClass.__PropertyOffset_SoftClass, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17009099 RID: 37017
		// (get) Token: 0x06025799 RID: 153497 RVA: 0x00383CB8 File Offset: 0x00381EB8
		// (set) Token: 0x0602579A RID: 153498 RVA: 0x00383CF1 File Offset: 0x00381EF1
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
					result = (this._SoftClassArray = new TArray<TSoftClassPtr<USharpherealTestSimpleClass>>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UClass.__PropertyOffset_SoftClassArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SoftClassArray.CopyAssign(value);
			}
		}

		// Token: 0x1700909A RID: 37018
		// (get) Token: 0x0602579B RID: 153499 RVA: 0x00383D00 File Offset: 0x00381F00
		// (set) Token: 0x0602579C RID: 153500 RVA: 0x00383D39 File Offset: 0x00381F39
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
					result = (this._SoftClassSet = new TSet<TSoftClassPtr<USharpherealTestSimpleClass>>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UClass.__PropertyOffset_SoftClassSet, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SoftClassSet.CopyAssign(value);
			}
		}

		// Token: 0x1700909B RID: 37019
		// (get) Token: 0x0602579D RID: 153501 RVA: 0x00383D48 File Offset: 0x00381F48
		// (set) Token: 0x0602579E RID: 153502 RVA: 0x00383D81 File Offset: 0x00381F81
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
					result = (this._SoftClassMap = new TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UClass.__PropertyOffset_SoftClassMap, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SoftClassMap.CopyAssign(value);
			}
		}

		// Token: 0x1700909C RID: 37020
		// (get) Token: 0x0602579F RID: 153503 RVA: 0x00383D8F File Offset: 0x00381F8F
		// (set) Token: 0x060257A0 RID: 153504 RVA: 0x00383DA3 File Offset: 0x00381FA3
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
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UClass.__PropertyOffset_SubClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UClass.__PropertyOffset_SubClass) = value;
			}
		}

		// Token: 0x1700909D RID: 37021
		// (get) Token: 0x060257A1 RID: 153505 RVA: 0x00383DB8 File Offset: 0x00381FB8
		// (set) Token: 0x060257A2 RID: 153506 RVA: 0x00383DF1 File Offset: 0x00381FF1
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
					result = (this._SubClassArray = new TArray<TSubclassOf<USharpherealTestSimpleClass>>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UClass.__PropertyOffset_SubClassArray, this));
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

		// Token: 0x1700909E RID: 37022
		// (get) Token: 0x060257A3 RID: 153507 RVA: 0x00383E00 File Offset: 0x00382000
		// (set) Token: 0x060257A4 RID: 153508 RVA: 0x00383E39 File Offset: 0x00382039
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
					result = (this._SubClassSet = new TSet<TSubclassOf<USharpherealTestSimpleClass>>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UClass.__PropertyOffset_SubClassSet, this));
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

		// Token: 0x1700909F RID: 37023
		// (get) Token: 0x060257A5 RID: 153509 RVA: 0x00383E48 File Offset: 0x00382048
		// (set) Token: 0x060257A6 RID: 153510 RVA: 0x00383E81 File Offset: 0x00382081
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
					result = (this._SubClassMap = new TMap<TSubclassOf<USharpherealTestSimpleClass>, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UClass.__PropertyOffset_SubClassMap, this));
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

		// Token: 0x170090A0 RID: 37024
		// (get) Token: 0x060257A7 RID: 153511 RVA: 0x00383E90 File Offset: 0x00382090
		// (set) Token: 0x060257A8 RID: 153512 RVA: 0x00383EC9 File Offset: 0x003820C9
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
					result = (this._ClassPath = new FSoftClassPath(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UClass.__PropertyOffset_ClassPath, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UClass.__PropertyOffset_ClassPath, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170090A1 RID: 37025
		// (get) Token: 0x060257A9 RID: 153513 RVA: 0x00383EEC File Offset: 0x003820EC
		// (set) Token: 0x060257AA RID: 153514 RVA: 0x00383F25 File Offset: 0x00382125
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
					result = (this._ClassPathArray = new TArray<FSoftClassPath>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UClass.__PropertyOffset_ClassPathArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ClassPathArray.CopyAssign(value);
			}
		}

		// Token: 0x170090A2 RID: 37026
		// (get) Token: 0x060257AB RID: 153515 RVA: 0x00383F34 File Offset: 0x00382134
		// (set) Token: 0x060257AC RID: 153516 RVA: 0x00383F6D File Offset: 0x0038216D
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
					result = (this._ClassPathSet = new TSet<FSoftClassPath>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UClass.__PropertyOffset_ClassPathSet, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ClassPathSet.CopyAssign(value);
			}
		}

		// Token: 0x170090A3 RID: 37027
		// (get) Token: 0x060257AD RID: 153517 RVA: 0x00383F7C File Offset: 0x0038217C
		// (set) Token: 0x060257AE RID: 153518 RVA: 0x00383FB5 File Offset: 0x003821B5
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
					result = (this._ClassPathMap = new TMap<FSoftClassPath, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_UClass.__PropertyOffset_ClassPathMap, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ClassPathMap.CopyAssign(value);
			}
		}

		// Token: 0x060257AF RID: 153519 RVA: 0x00383FC4 File Offset: 0x003821C4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetSubPathString(ref TSoftClassPtr<USharpherealTestSimpleClass> ObjectPtr, string SubPathString)
		{
			UTestClass_UFunction_Direct_UClass.__SetSubPathString_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__SetSubPathString_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__SetSubPathString_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__SetSubPathString_NativeFunctionPtr, (void*)ptr, 1);
			if (ObjectPtr != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->ObjectPtr, ObjectPtr.NativePtr, 1);
			}
			FString.CopyFrom((void*)(&ptr->SubPathString), SubPathString);
			UnrealReflectionUtils.CallUFunction(UTestClass_UFunction_Direct_UClass._ClassDefaultObjectPtr, UTestClass_UFunction_Direct_UClass.__SetSubPathString_NativeFunctionPtr, (void*)ptr, 0);
			if (ObjectPtr != null)
			{
				FSoftObjectPtr.NativeCopy(ObjectPtr.NativePtr, &ptr->ObjectPtr, 1);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__SetSubPathString_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060257B0 RID: 153520 RVA: 0x00384060 File Offset: 0x00382260
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetSubClassSet([Nullable(new byte[]
		{
			2,
			0,
			1
		})] TSet<TSubclassOf<USharpherealTestSimpleClass>> InSubClassSet)
		{
			UTestClass_UFunction_Direct_UClass.__SetSubClassSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__SetSubClassSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__SetSubClassSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__SetSubClassSet_NativeFunctionPtr, (void*)ptr, 1);
			if (InSubClassSet != null)
			{
				InSubClassSet.CopyTo(&ptr->InSubClassSet, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__SetSubClassSet_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__SetSubClassSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060257B1 RID: 153521 RVA: 0x003840CC File Offset: 0x003822CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetSubClassMap([Nullable(new byte[]
		{
			2,
			0,
			1
		})] TMap<TSubclassOf<USharpherealTestSimpleClass>, int> InSubClassMap)
		{
			UTestClass_UFunction_Direct_UClass.__SetSubClassMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__SetSubClassMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__SetSubClassMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__SetSubClassMap_NativeFunctionPtr, (void*)ptr, 1);
			if (InSubClassMap != null)
			{
				InSubClassMap.CopyTo(&ptr->InSubClassMap, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__SetSubClassMap_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__SetSubClassMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060257B2 RID: 153522 RVA: 0x00384138 File Offset: 0x00382338
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetSubClassArray([Nullable(new byte[]
		{
			2,
			0,
			1
		})] TArray<TSubclassOf<USharpherealTestSimpleClass>> InSubClassArray)
		{
			UTestClass_UFunction_Direct_UClass.__SetSubClassArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__SetSubClassArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__SetSubClassArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__SetSubClassArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InSubClassArray != null)
			{
				InSubClassArray.CopyTo(&ptr->InSubClassArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__SetSubClassArray_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__SetSubClassArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060257B3 RID: 153523 RVA: 0x003841A4 File Offset: 0x003823A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetSubClass([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<USharpherealTestSimpleClass> InSubClass)
		{
			UTestClass_UFunction_Direct_UClass.__SetSubClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__SetSubClass_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__SetSubClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__SetSubClass_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InSubClass = InSubClass;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__SetSubClass_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060257B4 RID: 153524 RVA: 0x003841EC File Offset: 0x003823EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetStClassSet([Nullable(new byte[]
		{
			2,
			1
		})] TSet<UClass> InStClassSet)
		{
			UTestClass_UFunction_Direct_UClass.__SetStClassSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__SetStClassSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__SetStClassSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__SetStClassSet_NativeFunctionPtr, (void*)ptr, 1);
			if (InStClassSet != null)
			{
				InStClassSet.CopyTo(&ptr->InStClassSet, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__SetStClassSet_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__SetStClassSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060257B5 RID: 153525 RVA: 0x00384258 File Offset: 0x00382458
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetStClassMap([Nullable(new byte[]
		{
			2,
			1
		})] TMap<UClass, int> InStClassMap)
		{
			UTestClass_UFunction_Direct_UClass.__SetStClassMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__SetStClassMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__SetStClassMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__SetStClassMap_NativeFunctionPtr, (void*)ptr, 1);
			if (InStClassMap != null)
			{
				InStClassMap.CopyTo(&ptr->InStClassMap, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__SetStClassMap_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__SetStClassMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060257B6 RID: 153526 RVA: 0x003842C4 File Offset: 0x003824C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetStClassArray([Nullable(new byte[]
		{
			2,
			1
		})] TArray<UClass> InStClassArray)
		{
			UTestClass_UFunction_Direct_UClass.__SetStClassArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__SetStClassArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__SetStClassArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__SetStClassArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InStClassArray != null)
			{
				InStClassArray.CopyTo(&ptr->InStClassArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__SetStClassArray_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__SetStClassArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060257B7 RID: 153527 RVA: 0x00384330 File Offset: 0x00382530
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetStClass(UClassStackOnlyPtr InStClass)
		{
			UTestClass_UFunction_Direct_UClass.__SetStClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__SetStClass_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__SetStClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__SetStClass_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InStClass = InStClass;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__SetStClass_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060257B8 RID: 153528 RVA: 0x00384378 File Offset: 0x00382578
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetSoftClassSet([Nullable(new byte[]
		{
			2,
			1,
			1
		})] TSet<TSoftClassPtr<USharpherealTestSimpleClass>> InSoftClassSet)
		{
			UTestClass_UFunction_Direct_UClass.__SetSoftClassSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__SetSoftClassSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__SetSoftClassSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__SetSoftClassSet_NativeFunctionPtr, (void*)ptr, 1);
			if (InSoftClassSet != null)
			{
				InSoftClassSet.CopyTo(&ptr->InSoftClassSet, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__SetSoftClassSet_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__SetSoftClassSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060257B9 RID: 153529 RVA: 0x003843E4 File Offset: 0x003825E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetSoftClassMap([Nullable(new byte[]
		{
			2,
			1,
			1
		})] TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int> InSoftClassMap)
		{
			UTestClass_UFunction_Direct_UClass.__SetSoftClassMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__SetSoftClassMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__SetSoftClassMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__SetSoftClassMap_NativeFunctionPtr, (void*)ptr, 1);
			if (InSoftClassMap != null)
			{
				InSoftClassMap.CopyTo(&ptr->InSoftClassMap, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__SetSoftClassMap_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__SetSoftClassMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060257BA RID: 153530 RVA: 0x00384450 File Offset: 0x00382650
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetSoftClassArray([Nullable(new byte[]
		{
			2,
			1,
			1
		})] TArray<TSoftClassPtr<USharpherealTestSimpleClass>> InSoftClassArray)
		{
			UTestClass_UFunction_Direct_UClass.__SetSoftClassArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__SetSoftClassArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__SetSoftClassArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__SetSoftClassArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InSoftClassArray != null)
			{
				InSoftClassArray.CopyTo(&ptr->InSoftClassArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__SetSoftClassArray_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__SetSoftClassArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060257BB RID: 153531 RVA: 0x003844BC File Offset: 0x003826BC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetSoftClass(TSoftClassPtr<USharpherealTestSimpleClass> InSoftClass)
		{
			UTestClass_UFunction_Direct_UClass.__SetSoftClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__SetSoftClass_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__SetSoftClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__SetSoftClass_NativeFunctionPtr, (void*)ptr, 1);
			if (InSoftClass != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->InSoftClass, InSoftClass.NativePtr, 1);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__SetSoftClass_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__SetSoftClass_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060257BC RID: 153532 RVA: 0x0038452C File Offset: 0x0038272C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetClassPathSet([Nullable(new byte[]
		{
			2,
			1
		})] TSet<FSoftClassPath> InClassPathSet)
		{
			UTestClass_UFunction_Direct_UClass.__SetClassPathSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__SetClassPathSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__SetClassPathSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__SetClassPathSet_NativeFunctionPtr, (void*)ptr, 1);
			if (InClassPathSet != null)
			{
				InClassPathSet.CopyTo(&ptr->InClassPathSet, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__SetClassPathSet_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__SetClassPathSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060257BD RID: 153533 RVA: 0x00384598 File Offset: 0x00382798
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetClassPathMap([Nullable(new byte[]
		{
			2,
			1
		})] TMap<FSoftClassPath, int> InClassPathMap)
		{
			UTestClass_UFunction_Direct_UClass.__SetClassPathMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__SetClassPathMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__SetClassPathMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__SetClassPathMap_NativeFunctionPtr, (void*)ptr, 1);
			if (InClassPathMap != null)
			{
				InClassPathMap.CopyTo(&ptr->InClassPathMap, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__SetClassPathMap_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__SetClassPathMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060257BE RID: 153534 RVA: 0x00384604 File Offset: 0x00382804
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetClassPathArray([Nullable(new byte[]
		{
			2,
			1
		})] TArray<FSoftClassPath> InClassPathArray)
		{
			UTestClass_UFunction_Direct_UClass.__SetClassPathArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__SetClassPathArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__SetClassPathArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__SetClassPathArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InClassPathArray != null)
			{
				InClassPathArray.CopyTo(&ptr->InClassPathArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__SetClassPathArray_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__SetClassPathArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060257BF RID: 153535 RVA: 0x00384670 File Offset: 0x00382870
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetClassPath(FSoftClassPath InClassPath)
		{
			UTestClass_UFunction_Direct_UClass.__SetClassPath_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__SetClassPath_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__SetClassPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__SetClassPath_NativeFunctionPtr, (void*)ptr, 1);
			if (InClassPath != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), &ptr->InClassPath, InClassPath.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__SetClassPath_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__SetClassPath_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060257C0 RID: 153536 RVA: 0x003846E4 File Offset: 0x003828E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutSubClassSet([Nullable(new byte[]
		{
			2,
			0,
			1
		})] ref TSet<TSubclassOf<USharpherealTestSimpleClass>> OutSubClassSet)
		{
			UTestClass_UFunction_Direct_UClass.__OutSubClassSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__OutSubClassSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__OutSubClassSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__OutSubClassSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<TSubclassOf<USharpherealTestSimpleClass>> tset = OutSubClassSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutSubClassSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__OutSubClassSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<TSubclassOf<USharpherealTestSimpleClass>> tset2 = OutSubClassSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutSubClassSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__OutSubClassSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060257C1 RID: 153537 RVA: 0x00384760 File Offset: 0x00382960
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutSubClassMap([Nullable(new byte[]
		{
			2,
			0,
			1
		})] ref TMap<TSubclassOf<USharpherealTestSimpleClass>, int> OutSubClassMap)
		{
			UTestClass_UFunction_Direct_UClass.__OutSubClassMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__OutSubClassMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__OutSubClassMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__OutSubClassMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<TSubclassOf<USharpherealTestSimpleClass>, int> tmap = OutSubClassMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutSubClassMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__OutSubClassMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<TSubclassOf<USharpherealTestSimpleClass>, int> tmap2 = OutSubClassMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutSubClassMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__OutSubClassMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060257C2 RID: 153538 RVA: 0x003847DC File Offset: 0x003829DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutSubClassArray([Nullable(new byte[]
		{
			2,
			0,
			1
		})] ref TArray<TSubclassOf<USharpherealTestSimpleClass>> OutSubClassArray)
		{
			UTestClass_UFunction_Direct_UClass.__OutSubClassArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__OutSubClassArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__OutSubClassArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__OutSubClassArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<TSubclassOf<USharpherealTestSimpleClass>> tarray = OutSubClassArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutSubClassArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__OutSubClassArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<TSubclassOf<USharpherealTestSimpleClass>> tarray2 = OutSubClassArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutSubClassArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__OutSubClassArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060257C3 RID: 153539 RVA: 0x00384858 File Offset: 0x00382A58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutSubClass([Nullable(new byte[]
		{
			0,
			1
		})] ref TSubclassOf<USharpherealTestSimpleClass> OutSubClass)
		{
			UTestClass_UFunction_Direct_UClass.__OutSubClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__OutSubClass_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__OutSubClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__OutSubClass_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutSubClass = OutSubClass;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__OutSubClass_NativeFunctionPtr, (void*)ptr, 0);
			OutSubClass = ptr->OutSubClass;
		}

		// Token: 0x060257C4 RID: 153540 RVA: 0x003848B0 File Offset: 0x00382AB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutStClassSet([Nullable(new byte[]
		{
			2,
			1
		})] ref TSet<UClass> OutStClassSet)
		{
			UTestClass_UFunction_Direct_UClass.__OutStClassSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__OutStClassSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__OutStClassSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__OutStClassSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<UClass> tset = OutStClassSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutStClassSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__OutStClassSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<UClass> tset2 = OutStClassSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutStClassSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__OutStClassSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060257C5 RID: 153541 RVA: 0x0038492C File Offset: 0x00382B2C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutStClassMap([Nullable(new byte[]
		{
			2,
			1
		})] ref TMap<UClass, int> OutStClassMap)
		{
			UTestClass_UFunction_Direct_UClass.__OutStClassMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__OutStClassMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__OutStClassMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__OutStClassMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<UClass, int> tmap = OutStClassMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutStClassMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__OutStClassMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<UClass, int> tmap2 = OutStClassMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutStClassMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__OutStClassMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060257C6 RID: 153542 RVA: 0x003849A8 File Offset: 0x00382BA8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutStClassArray([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UClass> OutStClassArray)
		{
			UTestClass_UFunction_Direct_UClass.__OutStClassArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__OutStClassArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__OutStClassArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__OutStClassArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<UClass> tarray = OutStClassArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutStClassArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__OutStClassArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<UClass> tarray2 = OutStClassArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutStClassArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__OutStClassArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060257C7 RID: 153543 RVA: 0x00384A24 File Offset: 0x00382C24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutStClass(ref UClassStackOnlyPtr OutStClass)
		{
			UTestClass_UFunction_Direct_UClass.__OutStClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__OutStClass_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__OutStClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__OutStClass_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutStClass = OutStClass;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__OutStClass_NativeFunctionPtr, (void*)ptr, 0);
			OutStClass = ptr->OutStClass;
		}

		// Token: 0x060257C8 RID: 153544 RVA: 0x00384A7C File Offset: 0x00382C7C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutSoftClassSet([Nullable(new byte[]
		{
			2,
			1,
			1
		})] ref TSet<TSoftClassPtr<USharpherealTestSimpleClass>> OutSoftClassSet)
		{
			UTestClass_UFunction_Direct_UClass.__OutSoftClassSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__OutSoftClassSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__OutSoftClassSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__OutSoftClassSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<TSoftClassPtr<USharpherealTestSimpleClass>> tset = OutSoftClassSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutSoftClassSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__OutSoftClassSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<TSoftClassPtr<USharpherealTestSimpleClass>> tset2 = OutSoftClassSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutSoftClassSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__OutSoftClassSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060257C9 RID: 153545 RVA: 0x00384AF8 File Offset: 0x00382CF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutSoftClassMap([Nullable(new byte[]
		{
			2,
			1,
			1
		})] ref TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int> OutSoftClassMap)
		{
			UTestClass_UFunction_Direct_UClass.__OutSoftClassMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__OutSoftClassMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__OutSoftClassMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__OutSoftClassMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int> tmap = OutSoftClassMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutSoftClassMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__OutSoftClassMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int> tmap2 = OutSoftClassMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutSoftClassMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__OutSoftClassMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060257CA RID: 153546 RVA: 0x00384B74 File Offset: 0x00382D74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutSoftClassArray([Nullable(new byte[]
		{
			2,
			1,
			1
		})] ref TArray<TSoftClassPtr<USharpherealTestSimpleClass>> OutSoftClassArray)
		{
			UTestClass_UFunction_Direct_UClass.__OutSoftClassArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__OutSoftClassArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__OutSoftClassArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__OutSoftClassArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<TSoftClassPtr<USharpherealTestSimpleClass>> tarray = OutSoftClassArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutSoftClassArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__OutSoftClassArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<TSoftClassPtr<USharpherealTestSimpleClass>> tarray2 = OutSoftClassArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutSoftClassArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__OutSoftClassArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060257CB RID: 153547 RVA: 0x00384BF0 File Offset: 0x00382DF0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutSoftClass(ref TSoftClassPtr<USharpherealTestSimpleClass> OutSoftClass)
		{
			UTestClass_UFunction_Direct_UClass.__OutSoftClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__OutSoftClass_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__OutSoftClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__OutSoftClass_NativeFunctionPtr, (void*)ptr, 1);
			if (OutSoftClass != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->OutSoftClass, OutSoftClass.NativePtr, 1);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__OutSoftClass_NativeFunctionPtr, (void*)ptr, 0);
			if (OutSoftClass != null)
			{
				FSoftObjectPtr.NativeCopy(OutSoftClass.NativePtr, &ptr->OutSoftClass, 1);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__OutSoftClass_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060257CC RID: 153548 RVA: 0x00384C80 File Offset: 0x00382E80
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutClassPathSet([Nullable(new byte[]
		{
			2,
			1
		})] ref TSet<FSoftClassPath> OutClassPathSet)
		{
			UTestClass_UFunction_Direct_UClass.__OutClassPathSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__OutClassPathSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__OutClassPathSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__OutClassPathSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<FSoftClassPath> tset = OutClassPathSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutClassPathSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__OutClassPathSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<FSoftClassPath> tset2 = OutClassPathSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutClassPathSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__OutClassPathSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060257CD RID: 153549 RVA: 0x00384CFC File Offset: 0x00382EFC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutClassPathMap([Nullable(new byte[]
		{
			2,
			1
		})] ref TMap<FSoftClassPath, int> OutClassPathMap)
		{
			UTestClass_UFunction_Direct_UClass.__OutClassPathMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__OutClassPathMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__OutClassPathMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__OutClassPathMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FSoftClassPath, int> tmap = OutClassPathMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutClassPathMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__OutClassPathMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FSoftClassPath, int> tmap2 = OutClassPathMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutClassPathMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__OutClassPathMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060257CE RID: 153550 RVA: 0x00384D78 File Offset: 0x00382F78
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutClassPathArray([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FSoftClassPath> OutClassPathArray)
		{
			UTestClass_UFunction_Direct_UClass.__OutClassPathArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__OutClassPathArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__OutClassPathArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__OutClassPathArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FSoftClassPath> tarray = OutClassPathArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutClassPathArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__OutClassPathArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FSoftClassPath> tarray2 = OutClassPathArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutClassPathArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__OutClassPathArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060257CF RID: 153551 RVA: 0x00384DF4 File Offset: 0x00382FF4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutClassPath(ref FSoftClassPath OutClassPath)
		{
			UTestClass_UFunction_Direct_UClass.__OutClassPath_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__OutClassPath_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__OutClassPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__OutClassPath_NativeFunctionPtr, (void*)ptr, 1);
			if (OutClassPath != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), &ptr->OutClassPath, OutClassPath.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__OutClassPath_NativeFunctionPtr, (void*)ptr, 0);
			if (OutClassPath != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), OutClassPath.NativePtr, &ptr->OutClassPath, 1, false);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__OutClassPath_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060257D0 RID: 153552 RVA: 0x00384E90 File Offset: 0x00383090
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InSubClassSet([Nullable(new byte[]
		{
			2,
			0,
			1
		})] in TSet<TSubclassOf<USharpherealTestSimpleClass>> InSubClassSet)
		{
			UTestClass_UFunction_Direct_UClass.__InSubClassSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__InSubClassSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__InSubClassSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__InSubClassSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<TSubclassOf<USharpherealTestSimpleClass>> tset = InSubClassSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InSubClassSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__InSubClassSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<TSubclassOf<USharpherealTestSimpleClass>> tset2 = InSubClassSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InSubClassSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__InSubClassSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060257D1 RID: 153553 RVA: 0x00384F0C File Offset: 0x0038310C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InSubClassMap([Nullable(new byte[]
		{
			2,
			0,
			1
		})] in TMap<TSubclassOf<USharpherealTestSimpleClass>, int> InSubClassMap)
		{
			UTestClass_UFunction_Direct_UClass.__InSubClassMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__InSubClassMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__InSubClassMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__InSubClassMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<TSubclassOf<USharpherealTestSimpleClass>, int> tmap = InSubClassMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InSubClassMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__InSubClassMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<TSubclassOf<USharpherealTestSimpleClass>, int> tmap2 = InSubClassMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InSubClassMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__InSubClassMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060257D2 RID: 153554 RVA: 0x00384F88 File Offset: 0x00383188
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InSubClassArray([Nullable(new byte[]
		{
			2,
			0,
			1
		})] in TArray<TSubclassOf<USharpherealTestSimpleClass>> InSubClassArray)
		{
			UTestClass_UFunction_Direct_UClass.__InSubClassArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__InSubClassArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__InSubClassArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__InSubClassArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<TSubclassOf<USharpherealTestSimpleClass>> tarray = InSubClassArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InSubClassArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__InSubClassArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<TSubclassOf<USharpherealTestSimpleClass>> tarray2 = InSubClassArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InSubClassArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__InSubClassArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060257D3 RID: 153555 RVA: 0x00385004 File Offset: 0x00383204
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InSubClass([Nullable(new byte[]
		{
			0,
			1
		})] in TSubclassOf<USharpherealTestSimpleClass> InSubClass)
		{
			UTestClass_UFunction_Direct_UClass.__InSubClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__InSubClass_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__InSubClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__InSubClass_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InSubClass = InSubClass;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__InSubClass_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060257D4 RID: 153556 RVA: 0x00385050 File Offset: 0x00383250
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InStClassSet([Nullable(new byte[]
		{
			2,
			1
		})] in TSet<UClass> InStClassSet)
		{
			UTestClass_UFunction_Direct_UClass.__InStClassSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__InStClassSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__InStClassSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__InStClassSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<UClass> tset = InStClassSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InStClassSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__InStClassSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<UClass> tset2 = InStClassSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InStClassSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__InStClassSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060257D5 RID: 153557 RVA: 0x003850CC File Offset: 0x003832CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InStClassMap([Nullable(new byte[]
		{
			2,
			1
		})] in TMap<UClass, int> InStClassMap)
		{
			UTestClass_UFunction_Direct_UClass.__InStClassMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__InStClassMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__InStClassMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__InStClassMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<UClass, int> tmap = InStClassMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InStClassMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__InStClassMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<UClass, int> tmap2 = InStClassMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InStClassMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__InStClassMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060257D6 RID: 153558 RVA: 0x00385148 File Offset: 0x00383348
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InStClassArray([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<UClass> InStClassArray)
		{
			UTestClass_UFunction_Direct_UClass.__InStClassArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__InStClassArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__InStClassArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__InStClassArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<UClass> tarray = InStClassArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InStClassArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__InStClassArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<UClass> tarray2 = InStClassArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InStClassArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__InStClassArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060257D7 RID: 153559 RVA: 0x003851C4 File Offset: 0x003833C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InStClass(in UClassStackOnlyPtr InStClass)
		{
			UTestClass_UFunction_Direct_UClass.__InStClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__InStClass_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__InStClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__InStClass_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InStClass = InStClass;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__InStClass_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060257D8 RID: 153560 RVA: 0x00385210 File Offset: 0x00383410
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InSoftClassSet([Nullable(new byte[]
		{
			2,
			1,
			1
		})] in TSet<TSoftClassPtr<USharpherealTestSimpleClass>> InSoftClassSet)
		{
			UTestClass_UFunction_Direct_UClass.__InSoftClassSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__InSoftClassSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__InSoftClassSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__InSoftClassSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<TSoftClassPtr<USharpherealTestSimpleClass>> tset = InSoftClassSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InSoftClassSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__InSoftClassSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<TSoftClassPtr<USharpherealTestSimpleClass>> tset2 = InSoftClassSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InSoftClassSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__InSoftClassSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060257D9 RID: 153561 RVA: 0x0038528C File Offset: 0x0038348C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InSoftClassMap([Nullable(new byte[]
		{
			2,
			1,
			1
		})] in TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int> InSoftClassMap)
		{
			UTestClass_UFunction_Direct_UClass.__InSoftClassMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__InSoftClassMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__InSoftClassMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__InSoftClassMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int> tmap = InSoftClassMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InSoftClassMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__InSoftClassMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int> tmap2 = InSoftClassMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InSoftClassMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__InSoftClassMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060257DA RID: 153562 RVA: 0x00385308 File Offset: 0x00383508
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InSoftClassArray([Nullable(new byte[]
		{
			2,
			1,
			1
		})] in TArray<TSoftClassPtr<USharpherealTestSimpleClass>> InSoftClassArray)
		{
			UTestClass_UFunction_Direct_UClass.__InSoftClassArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__InSoftClassArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__InSoftClassArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__InSoftClassArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<TSoftClassPtr<USharpherealTestSimpleClass>> tarray = InSoftClassArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InSoftClassArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__InSoftClassArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<TSoftClassPtr<USharpherealTestSimpleClass>> tarray2 = InSoftClassArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InSoftClassArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__InSoftClassArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060257DB RID: 153563 RVA: 0x00385384 File Offset: 0x00383584
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InSoftClass(in TSoftClassPtr<USharpherealTestSimpleClass> InSoftClass)
		{
			UTestClass_UFunction_Direct_UClass.__InSoftClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__InSoftClass_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__InSoftClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__InSoftClass_NativeFunctionPtr, (void*)ptr, 1);
			if (InSoftClass != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->InSoftClass, InSoftClass.NativePtr, 1);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__InSoftClass_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__InSoftClass_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060257DC RID: 153564 RVA: 0x003853F4 File Offset: 0x003835F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InClassPathSet([Nullable(new byte[]
		{
			2,
			1
		})] in TSet<FSoftClassPath> InClassPathSet)
		{
			UTestClass_UFunction_Direct_UClass.__InClassPathSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__InClassPathSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__InClassPathSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__InClassPathSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<FSoftClassPath> tset = InClassPathSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InClassPathSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__InClassPathSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<FSoftClassPath> tset2 = InClassPathSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InClassPathSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__InClassPathSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060257DD RID: 153565 RVA: 0x00385470 File Offset: 0x00383670
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InClassPathMap([Nullable(new byte[]
		{
			2,
			1
		})] in TMap<FSoftClassPath, int> InClassPathMap)
		{
			UTestClass_UFunction_Direct_UClass.__InClassPathMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__InClassPathMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__InClassPathMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__InClassPathMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FSoftClassPath, int> tmap = InClassPathMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InClassPathMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__InClassPathMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FSoftClassPath, int> tmap2 = InClassPathMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InClassPathMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__InClassPathMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060257DE RID: 153566 RVA: 0x003854EC File Offset: 0x003836EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InClassPathArray([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FSoftClassPath> InClassPathArray)
		{
			UTestClass_UFunction_Direct_UClass.__InClassPathArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__InClassPathArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__InClassPathArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__InClassPathArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FSoftClassPath> tarray = InClassPathArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InClassPathArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__InClassPathArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FSoftClassPath> tarray2 = InClassPathArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InClassPathArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__InClassPathArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060257DF RID: 153567 RVA: 0x00385568 File Offset: 0x00383768
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InClassPath(in FSoftClassPath InClassPath)
		{
			UTestClass_UFunction_Direct_UClass.__InClassPath_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__InClassPath_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__InClassPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__InClassPath_NativeFunctionPtr, (void*)ptr, 1);
			if (InClassPath != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), &ptr->InClassPath, InClassPath.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__InClassPath_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__InClassPath_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060257E0 RID: 153568 RVA: 0x003855E0 File Offset: 0x003837E0
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
			UTestClass_UFunction_Direct_UClass.__GetSubClassSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__GetSubClassSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__GetSubClassSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__GetSubClassSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__GetSubClassSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<TSubclassOf<USharpherealTestSimpleClass>> result = new TSet<TSubclassOf<USharpherealTestSimpleClass>>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__GetSubClassSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060257E1 RID: 153569 RVA: 0x00385640 File Offset: 0x00383840
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
			UTestClass_UFunction_Direct_UClass.__GetSubClassMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__GetSubClassMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__GetSubClassMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__GetSubClassMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__GetSubClassMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<TSubclassOf<USharpherealTestSimpleClass>, int> result = new TMap<TSubclassOf<USharpherealTestSimpleClass>, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__GetSubClassMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060257E2 RID: 153570 RVA: 0x003856A0 File Offset: 0x003838A0
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
			UTestClass_UFunction_Direct_UClass.__GetSubClassArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__GetSubClassArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__GetSubClassArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__GetSubClassArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__GetSubClassArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<TSubclassOf<USharpherealTestSimpleClass>> result = new TArray<TSubclassOf<USharpherealTestSimpleClass>>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__GetSubClassArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060257E3 RID: 153571 RVA: 0x00385700 File Offset: 0x00383900
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<USharpherealTestSimpleClass> GetSubClass()
		{
			UTestClass_UFunction_Direct_UClass.__GetSubClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__GetSubClass_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__GetSubClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__GetSubClass_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__GetSubClass_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060257E4 RID: 153572 RVA: 0x00385748 File Offset: 0x00383948
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<UClass> GetStClassSet()
		{
			UTestClass_UFunction_Direct_UClass.__GetStClassSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__GetStClassSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__GetStClassSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__GetStClassSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__GetStClassSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<UClass> result = new TSet<UClass>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__GetStClassSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060257E5 RID: 153573 RVA: 0x003857A8 File Offset: 0x003839A8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<UClass, int> GetStClassMap()
		{
			UTestClass_UFunction_Direct_UClass.__GetStClassMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__GetStClassMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__GetStClassMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__GetStClassMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__GetStClassMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<UClass, int> result = new TMap<UClass, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__GetStClassMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060257E6 RID: 153574 RVA: 0x00385808 File Offset: 0x00383A08
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<UClass> GetStClassArray()
		{
			UTestClass_UFunction_Direct_UClass.__GetStClassArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__GetStClassArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__GetStClassArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__GetStClassArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__GetStClassArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<UClass> result = new TArray<UClass>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__GetStClassArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060257E7 RID: 153575 RVA: 0x00385868 File Offset: 0x00383A68
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe UClassStackOnlyPtr GetStClass()
		{
			UTestClass_UFunction_Direct_UClass.__GetStClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__GetStClass_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__GetStClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__GetStClass_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__GetStClass_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060257E8 RID: 153576 RVA: 0x003858B0 File Offset: 0x00383AB0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<TSoftClassPtr<USharpherealTestSimpleClass>> GetSoftClassSet()
		{
			UTestClass_UFunction_Direct_UClass.__GetSoftClassSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__GetSoftClassSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__GetSoftClassSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__GetSoftClassSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__GetSoftClassSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<TSoftClassPtr<USharpherealTestSimpleClass>> result = new TSet<TSoftClassPtr<USharpherealTestSimpleClass>>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__GetSoftClassSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060257E9 RID: 153577 RVA: 0x00385910 File Offset: 0x00383B10
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int> GetSoftClassMap()
		{
			UTestClass_UFunction_Direct_UClass.__GetSoftClassMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__GetSoftClassMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__GetSoftClassMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__GetSoftClassMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__GetSoftClassMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int> result = new TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__GetSoftClassMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060257EA RID: 153578 RVA: 0x00385970 File Offset: 0x00383B70
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<TSoftClassPtr<USharpherealTestSimpleClass>> GetSoftClassArray()
		{
			UTestClass_UFunction_Direct_UClass.__GetSoftClassArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__GetSoftClassArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__GetSoftClassArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__GetSoftClassArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__GetSoftClassArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<TSoftClassPtr<USharpherealTestSimpleClass>> result = new TArray<TSoftClassPtr<USharpherealTestSimpleClass>>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__GetSoftClassArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060257EB RID: 153579 RVA: 0x003859D0 File Offset: 0x00383BD0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSoftClassPtr<USharpherealTestSimpleClass> GetSoftClass()
		{
			UTestClass_UFunction_Direct_UClass.__GetSoftClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__GetSoftClass_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__GetSoftClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__GetSoftClass_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__GetSoftClass_NativeFunctionPtr, (void*)ptr, 0);
			TSoftClassPtr<USharpherealTestSimpleClass> result = new TSoftClassPtr<USharpherealTestSimpleClass>(&ptr->__Result, false, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__GetSoftClass_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060257EC RID: 153580 RVA: 0x00385A30 File Offset: 0x00383C30
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<FSoftClassPath> GetClassPathSet()
		{
			UTestClass_UFunction_Direct_UClass.__GetClassPathSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__GetClassPathSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__GetClassPathSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__GetClassPathSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__GetClassPathSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<FSoftClassPath> result = new TSet<FSoftClassPath>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__GetClassPathSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060257ED RID: 153581 RVA: 0x00385A90 File Offset: 0x00383C90
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<FSoftClassPath, int> GetClassPathMap()
		{
			UTestClass_UFunction_Direct_UClass.__GetClassPathMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__GetClassPathMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__GetClassPathMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__GetClassPathMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__GetClassPathMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FSoftClassPath, int> result = new TMap<FSoftClassPath, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__GetClassPathMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060257EE RID: 153582 RVA: 0x00385AF0 File Offset: 0x00383CF0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<FSoftClassPath> GetClassPathArray()
		{
			UTestClass_UFunction_Direct_UClass.__GetClassPathArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__GetClassPathArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__GetClassPathArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__GetClassPathArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__GetClassPathArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FSoftClassPath> result = new TArray<FSoftClassPath>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__GetClassPathArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060257EF RID: 153583 RVA: 0x00385B50 File Offset: 0x00383D50
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FSoftClassPath GetClassPath()
		{
			UTestClass_UFunction_Direct_UClass.__GetClassPath_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__GetClassPath_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__GetClassPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__GetClassPath_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__GetClassPath_NativeFunctionPtr, (void*)ptr, 0);
			FSoftClassPath result = new FSoftClassPath(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__GetClassPath_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060257F0 RID: 153584 RVA: 0x00385BAF File Offset: 0x00383DAF
		static UTestClass_UFunction_Direct_UClass()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SharpherealTest.TestClass_UFunction_Direct_UClass");
		}

		// Token: 0x060257F1 RID: 153585 RVA: 0x00385BBD File Offset: 0x00383DBD
		protected UTestClass_UFunction_Direct_UClass(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040144C2 RID: 83138
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SharpherealTest.TestClass_UFunction_Direct_UClass";

		// Token: 0x040144C3 RID: 83139
		private static IntPtr _ClassPtr;

		// Token: 0x040144C4 RID: 83140
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040144C5 RID: 83141
		internal static int __PropertyOffset_StClass;

		// Token: 0x040144C6 RID: 83142
		internal static int __PropertyOffset_StClassArray;

		// Token: 0x040144C7 RID: 83143
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UClass> _StClassArray;

		// Token: 0x040144C8 RID: 83144
		internal static int __PropertyOffset_StClassSet;

		// Token: 0x040144C9 RID: 83145
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UClass> _StClassSet;

		// Token: 0x040144CA RID: 83146
		internal static int __PropertyOffset_StClassMap;

		// Token: 0x040144CB RID: 83147
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<UClass, int> _StClassMap;

		// Token: 0x040144CC RID: 83148
		internal static int __PropertyOffset_SoftClass;

		// Token: 0x040144CD RID: 83149
		internal static int __PropertyOffset_SoftClassArray;

		// Token: 0x040144CE RID: 83150
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TArray<TSoftClassPtr<USharpherealTestSimpleClass>> _SoftClassArray;

		// Token: 0x040144CF RID: 83151
		internal static int __PropertyOffset_SoftClassSet;

		// Token: 0x040144D0 RID: 83152
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TSet<TSoftClassPtr<USharpherealTestSimpleClass>> _SoftClassSet;

		// Token: 0x040144D1 RID: 83153
		internal static int __PropertyOffset_SoftClassMap;

		// Token: 0x040144D2 RID: 83154
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int> _SoftClassMap;

		// Token: 0x040144D3 RID: 83155
		internal static int __PropertyOffset_SubClass;

		// Token: 0x040144D4 RID: 83156
		internal static int __PropertyOffset_SubClassArray;

		// Token: 0x040144D5 RID: 83157
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TSubclassOf<USharpherealTestSimpleClass>> _SubClassArray;

		// Token: 0x040144D6 RID: 83158
		internal static int __PropertyOffset_SubClassSet;

		// Token: 0x040144D7 RID: 83159
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TSet<TSubclassOf<USharpherealTestSimpleClass>> _SubClassSet;

		// Token: 0x040144D8 RID: 83160
		internal static int __PropertyOffset_SubClassMap;

		// Token: 0x040144D9 RID: 83161
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TSubclassOf<USharpherealTestSimpleClass>, int> _SubClassMap;

		// Token: 0x040144DA RID: 83162
		internal static int __PropertyOffset_ClassPath;

		// Token: 0x040144DB RID: 83163
		[Nullable(2)]
		private FSoftClassPath _ClassPath;

		// Token: 0x040144DC RID: 83164
		internal static int __PropertyOffset_ClassPathArray;

		// Token: 0x040144DD RID: 83165
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoftClassPath> _ClassPathArray;

		// Token: 0x040144DE RID: 83166
		internal static int __PropertyOffset_ClassPathSet;

		// Token: 0x040144DF RID: 83167
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<FSoftClassPath> _ClassPathSet;

		// Token: 0x040144E0 RID: 83168
		internal static int __PropertyOffset_ClassPathMap;

		// Token: 0x040144E1 RID: 83169
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FSoftClassPath, int> _ClassPathMap;

		// Token: 0x040144E2 RID: 83170
		private static IntPtr __SetSubPathString_NativeFunctionPtr;

		// Token: 0x040144E3 RID: 83171
		private static IntPtr __SetSubClassSet_NativeFunctionPtr;

		// Token: 0x040144E4 RID: 83172
		private static IntPtr __SetSubClassMap_NativeFunctionPtr;

		// Token: 0x040144E5 RID: 83173
		private static IntPtr __SetSubClassArray_NativeFunctionPtr;

		// Token: 0x040144E6 RID: 83174
		private static IntPtr __SetSubClass_NativeFunctionPtr;

		// Token: 0x040144E7 RID: 83175
		private static IntPtr __SetStClassSet_NativeFunctionPtr;

		// Token: 0x040144E8 RID: 83176
		private static IntPtr __SetStClassMap_NativeFunctionPtr;

		// Token: 0x040144E9 RID: 83177
		private static IntPtr __SetStClassArray_NativeFunctionPtr;

		// Token: 0x040144EA RID: 83178
		private static IntPtr __SetStClass_NativeFunctionPtr;

		// Token: 0x040144EB RID: 83179
		private static IntPtr __SetSoftClassSet_NativeFunctionPtr;

		// Token: 0x040144EC RID: 83180
		private static IntPtr __SetSoftClassMap_NativeFunctionPtr;

		// Token: 0x040144ED RID: 83181
		private static IntPtr __SetSoftClassArray_NativeFunctionPtr;

		// Token: 0x040144EE RID: 83182
		private static IntPtr __SetSoftClass_NativeFunctionPtr;

		// Token: 0x040144EF RID: 83183
		private static IntPtr __SetClassPathSet_NativeFunctionPtr;

		// Token: 0x040144F0 RID: 83184
		private static IntPtr __SetClassPathMap_NativeFunctionPtr;

		// Token: 0x040144F1 RID: 83185
		private static IntPtr __SetClassPathArray_NativeFunctionPtr;

		// Token: 0x040144F2 RID: 83186
		private static IntPtr __SetClassPath_NativeFunctionPtr;

		// Token: 0x040144F3 RID: 83187
		private static IntPtr __OutSubClassSet_NativeFunctionPtr;

		// Token: 0x040144F4 RID: 83188
		private static IntPtr __OutSubClassMap_NativeFunctionPtr;

		// Token: 0x040144F5 RID: 83189
		private static IntPtr __OutSubClassArray_NativeFunctionPtr;

		// Token: 0x040144F6 RID: 83190
		private static IntPtr __OutSubClass_NativeFunctionPtr;

		// Token: 0x040144F7 RID: 83191
		private static IntPtr __OutStClassSet_NativeFunctionPtr;

		// Token: 0x040144F8 RID: 83192
		private static IntPtr __OutStClassMap_NativeFunctionPtr;

		// Token: 0x040144F9 RID: 83193
		private static IntPtr __OutStClassArray_NativeFunctionPtr;

		// Token: 0x040144FA RID: 83194
		private static IntPtr __OutStClass_NativeFunctionPtr;

		// Token: 0x040144FB RID: 83195
		private static IntPtr __OutSoftClassSet_NativeFunctionPtr;

		// Token: 0x040144FC RID: 83196
		private static IntPtr __OutSoftClassMap_NativeFunctionPtr;

		// Token: 0x040144FD RID: 83197
		private static IntPtr __OutSoftClassArray_NativeFunctionPtr;

		// Token: 0x040144FE RID: 83198
		private static IntPtr __OutSoftClass_NativeFunctionPtr;

		// Token: 0x040144FF RID: 83199
		private static IntPtr __OutClassPathSet_NativeFunctionPtr;

		// Token: 0x04014500 RID: 83200
		private static IntPtr __OutClassPathMap_NativeFunctionPtr;

		// Token: 0x04014501 RID: 83201
		private static IntPtr __OutClassPathArray_NativeFunctionPtr;

		// Token: 0x04014502 RID: 83202
		private static IntPtr __OutClassPath_NativeFunctionPtr;

		// Token: 0x04014503 RID: 83203
		private static IntPtr __InSubClassSet_NativeFunctionPtr;

		// Token: 0x04014504 RID: 83204
		private static IntPtr __InSubClassMap_NativeFunctionPtr;

		// Token: 0x04014505 RID: 83205
		private static IntPtr __InSubClassArray_NativeFunctionPtr;

		// Token: 0x04014506 RID: 83206
		private static IntPtr __InSubClass_NativeFunctionPtr;

		// Token: 0x04014507 RID: 83207
		private static IntPtr __InStClassSet_NativeFunctionPtr;

		// Token: 0x04014508 RID: 83208
		private static IntPtr __InStClassMap_NativeFunctionPtr;

		// Token: 0x04014509 RID: 83209
		private static IntPtr __InStClassArray_NativeFunctionPtr;

		// Token: 0x0401450A RID: 83210
		private static IntPtr __InStClass_NativeFunctionPtr;

		// Token: 0x0401450B RID: 83211
		private static IntPtr __InSoftClassSet_NativeFunctionPtr;

		// Token: 0x0401450C RID: 83212
		private static IntPtr __InSoftClassMap_NativeFunctionPtr;

		// Token: 0x0401450D RID: 83213
		private static IntPtr __InSoftClassArray_NativeFunctionPtr;

		// Token: 0x0401450E RID: 83214
		private static IntPtr __InSoftClass_NativeFunctionPtr;

		// Token: 0x0401450F RID: 83215
		private static IntPtr __InClassPathSet_NativeFunctionPtr;

		// Token: 0x04014510 RID: 83216
		private static IntPtr __InClassPathMap_NativeFunctionPtr;

		// Token: 0x04014511 RID: 83217
		private static IntPtr __InClassPathArray_NativeFunctionPtr;

		// Token: 0x04014512 RID: 83218
		private static IntPtr __InClassPath_NativeFunctionPtr;

		// Token: 0x04014513 RID: 83219
		private static IntPtr __GetSubClassSet_NativeFunctionPtr;

		// Token: 0x04014514 RID: 83220
		private static IntPtr __GetSubClassMap_NativeFunctionPtr;

		// Token: 0x04014515 RID: 83221
		private static IntPtr __GetSubClassArray_NativeFunctionPtr;

		// Token: 0x04014516 RID: 83222
		private static IntPtr __GetSubClass_NativeFunctionPtr;

		// Token: 0x04014517 RID: 83223
		private static IntPtr __GetStClassSet_NativeFunctionPtr;

		// Token: 0x04014518 RID: 83224
		private static IntPtr __GetStClassMap_NativeFunctionPtr;

		// Token: 0x04014519 RID: 83225
		private static IntPtr __GetStClassArray_NativeFunctionPtr;

		// Token: 0x0401451A RID: 83226
		private static IntPtr __GetStClass_NativeFunctionPtr;

		// Token: 0x0401451B RID: 83227
		private static IntPtr __GetSoftClassSet_NativeFunctionPtr;

		// Token: 0x0401451C RID: 83228
		private static IntPtr __GetSoftClassMap_NativeFunctionPtr;

		// Token: 0x0401451D RID: 83229
		private static IntPtr __GetSoftClassArray_NativeFunctionPtr;

		// Token: 0x0401451E RID: 83230
		private static IntPtr __GetSoftClass_NativeFunctionPtr;

		// Token: 0x0401451F RID: 83231
		private static IntPtr __GetClassPathSet_NativeFunctionPtr;

		// Token: 0x04014520 RID: 83232
		private static IntPtr __GetClassPathMap_NativeFunctionPtr;

		// Token: 0x04014521 RID: 83233
		private static IntPtr __GetClassPathArray_NativeFunctionPtr;

		// Token: 0x04014522 RID: 83234
		private static IntPtr __GetClassPath_NativeFunctionPtr;

		// Token: 0x020038BB RID: 14523
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __SetSubPathString_FunctionParams
		{
			// Token: 0x040179E2 RID: 96738
			[FieldOffset(0)]
			public byte ObjectPtr;

			// Token: 0x040179E3 RID: 96739
			[FieldOffset(48)]
			public FString SubPathString;
		}

		// Token: 0x020038BC RID: 14524
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetSubClassSet_FunctionParams
		{
			// Token: 0x040179E4 RID: 96740
			[FieldOffset(0)]
			public byte InSubClassSet;
		}

		// Token: 0x020038BD RID: 14525
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetSubClassMap_FunctionParams
		{
			// Token: 0x040179E5 RID: 96741
			[FieldOffset(0)]
			public byte InSubClassMap;
		}

		// Token: 0x020038BE RID: 14526
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetSubClassArray_FunctionParams
		{
			// Token: 0x040179E6 RID: 96742
			[FieldOffset(0)]
			public byte InSubClassArray;
		}

		// Token: 0x020038BF RID: 14527
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetSubClass_FunctionParams
		{
			// Token: 0x040179E7 RID: 96743
			[Nullable(new byte[]
			{
				0,
				1
			})]
			[FieldOffset(0)]
			public TSubclassOf<USharpherealTestSimpleClass> InSubClass;
		}

		// Token: 0x020038C0 RID: 14528
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetStClassSet_FunctionParams
		{
			// Token: 0x040179E8 RID: 96744
			[FieldOffset(0)]
			public byte InStClassSet;
		}

		// Token: 0x020038C1 RID: 14529
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetStClassMap_FunctionParams
		{
			// Token: 0x040179E9 RID: 96745
			[FieldOffset(0)]
			public byte InStClassMap;
		}

		// Token: 0x020038C2 RID: 14530
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetStClassArray_FunctionParams
		{
			// Token: 0x040179EA RID: 96746
			[FieldOffset(0)]
			public byte InStClassArray;
		}

		// Token: 0x020038C3 RID: 14531
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetStClass_FunctionParams
		{
			// Token: 0x040179EB RID: 96747
			[FieldOffset(0)]
			public UClassStackOnlyPtr InStClass;
		}

		// Token: 0x020038C4 RID: 14532
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetSoftClassSet_FunctionParams
		{
			// Token: 0x040179EC RID: 96748
			[FieldOffset(0)]
			public byte InSoftClassSet;
		}

		// Token: 0x020038C5 RID: 14533
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetSoftClassMap_FunctionParams
		{
			// Token: 0x040179ED RID: 96749
			[FieldOffset(0)]
			public byte InSoftClassMap;
		}

		// Token: 0x020038C6 RID: 14534
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetSoftClassArray_FunctionParams
		{
			// Token: 0x040179EE RID: 96750
			[FieldOffset(0)]
			public byte InSoftClassArray;
		}

		// Token: 0x020038C7 RID: 14535
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __SetSoftClass_FunctionParams
		{
			// Token: 0x040179EF RID: 96751
			[FieldOffset(0)]
			public byte InSoftClass;
		}

		// Token: 0x020038C8 RID: 14536
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetClassPathSet_FunctionParams
		{
			// Token: 0x040179F0 RID: 96752
			[FieldOffset(0)]
			public byte InClassPathSet;
		}

		// Token: 0x020038C9 RID: 14537
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetClassPathMap_FunctionParams
		{
			// Token: 0x040179F1 RID: 96753
			[FieldOffset(0)]
			public byte InClassPathMap;
		}

		// Token: 0x020038CA RID: 14538
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetClassPathArray_FunctionParams
		{
			// Token: 0x040179F2 RID: 96754
			[FieldOffset(0)]
			public byte InClassPathArray;
		}

		// Token: 0x020038CB RID: 14539
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetClassPath_FunctionParams
		{
			// Token: 0x040179F3 RID: 96755
			[FieldOffset(0)]
			public byte InClassPath;
		}

		// Token: 0x020038CC RID: 14540
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutSubClassSet_FunctionParams
		{
			// Token: 0x040179F4 RID: 96756
			[FieldOffset(0)]
			public byte OutSubClassSet;
		}

		// Token: 0x020038CD RID: 14541
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutSubClassMap_FunctionParams
		{
			// Token: 0x040179F5 RID: 96757
			[FieldOffset(0)]
			public byte OutSubClassMap;
		}

		// Token: 0x020038CE RID: 14542
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutSubClassArray_FunctionParams
		{
			// Token: 0x040179F6 RID: 96758
			[FieldOffset(0)]
			public byte OutSubClassArray;
		}

		// Token: 0x020038CF RID: 14543
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OutSubClass_FunctionParams
		{
			// Token: 0x040179F7 RID: 96759
			[Nullable(new byte[]
			{
				0,
				1
			})]
			[FieldOffset(0)]
			public TSubclassOf<USharpherealTestSimpleClass> OutSubClass;
		}

		// Token: 0x020038D0 RID: 14544
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutStClassSet_FunctionParams
		{
			// Token: 0x040179F8 RID: 96760
			[FieldOffset(0)]
			public byte OutStClassSet;
		}

		// Token: 0x020038D1 RID: 14545
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutStClassMap_FunctionParams
		{
			// Token: 0x040179F9 RID: 96761
			[FieldOffset(0)]
			public byte OutStClassMap;
		}

		// Token: 0x020038D2 RID: 14546
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutStClassArray_FunctionParams
		{
			// Token: 0x040179FA RID: 96762
			[FieldOffset(0)]
			public byte OutStClassArray;
		}

		// Token: 0x020038D3 RID: 14547
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OutStClass_FunctionParams
		{
			// Token: 0x040179FB RID: 96763
			[FieldOffset(0)]
			public UClassStackOnlyPtr OutStClass;
		}

		// Token: 0x020038D4 RID: 14548
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutSoftClassSet_FunctionParams
		{
			// Token: 0x040179FC RID: 96764
			[FieldOffset(0)]
			public byte OutSoftClassSet;
		}

		// Token: 0x020038D5 RID: 14549
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutSoftClassMap_FunctionParams
		{
			// Token: 0x040179FD RID: 96765
			[FieldOffset(0)]
			public byte OutSoftClassMap;
		}

		// Token: 0x020038D6 RID: 14550
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutSoftClassArray_FunctionParams
		{
			// Token: 0x040179FE RID: 96766
			[FieldOffset(0)]
			public byte OutSoftClassArray;
		}

		// Token: 0x020038D7 RID: 14551
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __OutSoftClass_FunctionParams
		{
			// Token: 0x040179FF RID: 96767
			[FieldOffset(0)]
			public byte OutSoftClass;
		}

		// Token: 0x020038D8 RID: 14552
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutClassPathSet_FunctionParams
		{
			// Token: 0x04017A00 RID: 96768
			[FieldOffset(0)]
			public byte OutClassPathSet;
		}

		// Token: 0x020038D9 RID: 14553
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutClassPathMap_FunctionParams
		{
			// Token: 0x04017A01 RID: 96769
			[FieldOffset(0)]
			public byte OutClassPathMap;
		}

		// Token: 0x020038DA RID: 14554
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutClassPathArray_FunctionParams
		{
			// Token: 0x04017A02 RID: 96770
			[FieldOffset(0)]
			public byte OutClassPathArray;
		}

		// Token: 0x020038DB RID: 14555
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __OutClassPath_FunctionParams
		{
			// Token: 0x04017A03 RID: 96771
			[FieldOffset(0)]
			public byte OutClassPath;
		}

		// Token: 0x020038DC RID: 14556
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InSubClassSet_FunctionParams
		{
			// Token: 0x04017A04 RID: 96772
			[FieldOffset(0)]
			public byte InSubClassSet;
		}

		// Token: 0x020038DD RID: 14557
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InSubClassMap_FunctionParams
		{
			// Token: 0x04017A05 RID: 96773
			[FieldOffset(0)]
			public byte InSubClassMap;
		}

		// Token: 0x020038DE RID: 14558
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InSubClassArray_FunctionParams
		{
			// Token: 0x04017A06 RID: 96774
			[FieldOffset(0)]
			public byte InSubClassArray;
		}

		// Token: 0x020038DF RID: 14559
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __InSubClass_FunctionParams
		{
			// Token: 0x04017A07 RID: 96775
			[Nullable(new byte[]
			{
				0,
				1
			})]
			[FieldOffset(0)]
			public TSubclassOf<USharpherealTestSimpleClass> InSubClass;
		}

		// Token: 0x020038E0 RID: 14560
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InStClassSet_FunctionParams
		{
			// Token: 0x04017A08 RID: 96776
			[FieldOffset(0)]
			public byte InStClassSet;
		}

		// Token: 0x020038E1 RID: 14561
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InStClassMap_FunctionParams
		{
			// Token: 0x04017A09 RID: 96777
			[FieldOffset(0)]
			public byte InStClassMap;
		}

		// Token: 0x020038E2 RID: 14562
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InStClassArray_FunctionParams
		{
			// Token: 0x04017A0A RID: 96778
			[FieldOffset(0)]
			public byte InStClassArray;
		}

		// Token: 0x020038E3 RID: 14563
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __InStClass_FunctionParams
		{
			// Token: 0x04017A0B RID: 96779
			[FieldOffset(0)]
			public UClassStackOnlyPtr InStClass;
		}

		// Token: 0x020038E4 RID: 14564
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InSoftClassSet_FunctionParams
		{
			// Token: 0x04017A0C RID: 96780
			[FieldOffset(0)]
			public byte InSoftClassSet;
		}

		// Token: 0x020038E5 RID: 14565
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InSoftClassMap_FunctionParams
		{
			// Token: 0x04017A0D RID: 96781
			[FieldOffset(0)]
			public byte InSoftClassMap;
		}

		// Token: 0x020038E6 RID: 14566
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InSoftClassArray_FunctionParams
		{
			// Token: 0x04017A0E RID: 96782
			[FieldOffset(0)]
			public byte InSoftClassArray;
		}

		// Token: 0x020038E7 RID: 14567
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __InSoftClass_FunctionParams
		{
			// Token: 0x04017A0F RID: 96783
			[FieldOffset(0)]
			public byte InSoftClass;
		}

		// Token: 0x020038E8 RID: 14568
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InClassPathSet_FunctionParams
		{
			// Token: 0x04017A10 RID: 96784
			[FieldOffset(0)]
			public byte InClassPathSet;
		}

		// Token: 0x020038E9 RID: 14569
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InClassPathMap_FunctionParams
		{
			// Token: 0x04017A11 RID: 96785
			[FieldOffset(0)]
			public byte InClassPathMap;
		}

		// Token: 0x020038EA RID: 14570
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InClassPathArray_FunctionParams
		{
			// Token: 0x04017A12 RID: 96786
			[FieldOffset(0)]
			public byte InClassPathArray;
		}

		// Token: 0x020038EB RID: 14571
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InClassPath_FunctionParams
		{
			// Token: 0x04017A13 RID: 96787
			[FieldOffset(0)]
			public byte InClassPath;
		}

		// Token: 0x020038EC RID: 14572
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetSubClassSet_FunctionParams
		{
			// Token: 0x04017A14 RID: 96788
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020038ED RID: 14573
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetSubClassMap_FunctionParams
		{
			// Token: 0x04017A15 RID: 96789
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020038EE RID: 14574
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSubClassArray_FunctionParams
		{
			// Token: 0x04017A16 RID: 96790
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020038EF RID: 14575
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetSubClass_FunctionParams
		{
			// Token: 0x04017A17 RID: 96791
			[Nullable(new byte[]
			{
				0,
				1
			})]
			[FieldOffset(0)]
			public TSubclassOf<USharpherealTestSimpleClass> __Result;
		}

		// Token: 0x020038F0 RID: 14576
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetStClassSet_FunctionParams
		{
			// Token: 0x04017A18 RID: 96792
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020038F1 RID: 14577
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetStClassMap_FunctionParams
		{
			// Token: 0x04017A19 RID: 96793
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020038F2 RID: 14578
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetStClassArray_FunctionParams
		{
			// Token: 0x04017A1A RID: 96794
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020038F3 RID: 14579
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetStClass_FunctionParams
		{
			// Token: 0x04017A1B RID: 96795
			[FieldOffset(0)]
			public UClassStackOnlyPtr __Result;
		}

		// Token: 0x020038F4 RID: 14580
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetSoftClassSet_FunctionParams
		{
			// Token: 0x04017A1C RID: 96796
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020038F5 RID: 14581
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetSoftClassMap_FunctionParams
		{
			// Token: 0x04017A1D RID: 96797
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020038F6 RID: 14582
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSoftClassArray_FunctionParams
		{
			// Token: 0x04017A1E RID: 96798
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020038F7 RID: 14583
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __GetSoftClass_FunctionParams
		{
			// Token: 0x04017A1F RID: 96799
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020038F8 RID: 14584
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetClassPathSet_FunctionParams
		{
			// Token: 0x04017A20 RID: 96800
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020038F9 RID: 14585
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetClassPathMap_FunctionParams
		{
			// Token: 0x04017A21 RID: 96801
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020038FA RID: 14586
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetClassPathArray_FunctionParams
		{
			// Token: 0x04017A22 RID: 96802
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020038FB RID: 14587
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetClassPath_FunctionParams
		{
			// Token: 0x04017A23 RID: 96803
			[FieldOffset(0)]
			public byte __Result;
		}
	}
}
