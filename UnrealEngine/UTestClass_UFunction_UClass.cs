using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000806 RID: 2054
	[UnrealObjectPath("/Script/SharpherealTest.TestClass_UFunction_UClass")]
	[UnrealStructLayout(848, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 848)]
	public class UTestClass_UFunction_UClass : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B42D RID: 46125 RVA: 0x0011B63C File Offset: 0x0011983C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTestClass_UFunction_UClass._ClassPtr;
		}

		// Token: 0x0600B42E RID: 46126 RVA: 0x0011B648 File Offset: 0x00119848
		public UTestClass_UFunction_UClass() : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_UClass.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B42F RID: 46127 RVA: 0x0011B670 File Offset: 0x00119870
		[NullableContext(1)]
		public UTestClass_UFunction_UClass(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_UClass.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170021CA RID: 8650
		// (get) Token: 0x0600B430 RID: 46128 RVA: 0x0011B6A3 File Offset: 0x001198A3
		// (set) Token: 0x0600B431 RID: 46129 RVA: 0x0011B6B7 File Offset: 0x001198B7
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

		// Token: 0x170021CB RID: 8651
		// (get) Token: 0x0600B432 RID: 46130 RVA: 0x0011B6CC File Offset: 0x001198CC
		// (set) Token: 0x0600B433 RID: 46131 RVA: 0x0011B705 File Offset: 0x00119905
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

		// Token: 0x170021CC RID: 8652
		// (get) Token: 0x0600B434 RID: 46132 RVA: 0x0011B714 File Offset: 0x00119914
		// (set) Token: 0x0600B435 RID: 46133 RVA: 0x0011B74D File Offset: 0x0011994D
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

		// Token: 0x170021CD RID: 8653
		// (get) Token: 0x0600B436 RID: 46134 RVA: 0x0011B75C File Offset: 0x0011995C
		// (set) Token: 0x0600B437 RID: 46135 RVA: 0x0011B795 File Offset: 0x00119995
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

		// Token: 0x170021CE RID: 8654
		// (get) Token: 0x0600B438 RID: 46136 RVA: 0x0011B7A3 File Offset: 0x001199A3
		// (set) Token: 0x0600B439 RID: 46137 RVA: 0x0011B7B8 File Offset: 0x001199B8
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

		// Token: 0x170021CF RID: 8655
		// (get) Token: 0x0600B43A RID: 46138 RVA: 0x0011B7E0 File Offset: 0x001199E0
		// (set) Token: 0x0600B43B RID: 46139 RVA: 0x0011B819 File Offset: 0x00119A19
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

		// Token: 0x170021D0 RID: 8656
		// (get) Token: 0x0600B43C RID: 46140 RVA: 0x0011B828 File Offset: 0x00119A28
		// (set) Token: 0x0600B43D RID: 46141 RVA: 0x0011B861 File Offset: 0x00119A61
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

		// Token: 0x170021D1 RID: 8657
		// (get) Token: 0x0600B43E RID: 46142 RVA: 0x0011B870 File Offset: 0x00119A70
		// (set) Token: 0x0600B43F RID: 46143 RVA: 0x0011B8A9 File Offset: 0x00119AA9
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

		// Token: 0x170021D2 RID: 8658
		// (get) Token: 0x0600B440 RID: 46144 RVA: 0x0011B8B7 File Offset: 0x00119AB7
		// (set) Token: 0x0600B441 RID: 46145 RVA: 0x0011B8CB File Offset: 0x00119ACB
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

		// Token: 0x170021D3 RID: 8659
		// (get) Token: 0x0600B442 RID: 46146 RVA: 0x0011B8E0 File Offset: 0x00119AE0
		// (set) Token: 0x0600B443 RID: 46147 RVA: 0x0011B919 File Offset: 0x00119B19
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

		// Token: 0x170021D4 RID: 8660
		// (get) Token: 0x0600B444 RID: 46148 RVA: 0x0011B928 File Offset: 0x00119B28
		// (set) Token: 0x0600B445 RID: 46149 RVA: 0x0011B961 File Offset: 0x00119B61
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

		// Token: 0x170021D5 RID: 8661
		// (get) Token: 0x0600B446 RID: 46150 RVA: 0x0011B970 File Offset: 0x00119B70
		// (set) Token: 0x0600B447 RID: 46151 RVA: 0x0011B9A9 File Offset: 0x00119BA9
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

		// Token: 0x170021D6 RID: 8662
		// (get) Token: 0x0600B448 RID: 46152 RVA: 0x0011B9B8 File Offset: 0x00119BB8
		// (set) Token: 0x0600B449 RID: 46153 RVA: 0x0011B9F1 File Offset: 0x00119BF1
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

		// Token: 0x170021D7 RID: 8663
		// (get) Token: 0x0600B44A RID: 46154 RVA: 0x0011BA14 File Offset: 0x00119C14
		// (set) Token: 0x0600B44B RID: 46155 RVA: 0x0011BA4D File Offset: 0x00119C4D
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

		// Token: 0x170021D8 RID: 8664
		// (get) Token: 0x0600B44C RID: 46156 RVA: 0x0011BA5C File Offset: 0x00119C5C
		// (set) Token: 0x0600B44D RID: 46157 RVA: 0x0011BA95 File Offset: 0x00119C95
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

		// Token: 0x170021D9 RID: 8665
		// (get) Token: 0x0600B44E RID: 46158 RVA: 0x0011BAA4 File Offset: 0x00119CA4
		// (set) Token: 0x0600B44F RID: 46159 RVA: 0x0011BADD File Offset: 0x00119CDD
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

		// Token: 0x0600B450 RID: 46160 RVA: 0x0011BAEC File Offset: 0x00119CEC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void SetSubPathString(ref TSoftClassPtr<USharpherealTestSimpleClass> ObjectPtr, string SubPathString)
		{
			UTestClass_UFunction_UClass.__SetSubPathString_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__SetSubPathString_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__SetSubPathString_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__SetSubPathString_NativeFunctionPtr, (void*)ptr, 1);
			if (ObjectPtr != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->ObjectPtr, ObjectPtr.NativePtr, 1);
			}
			FString.CopyFrom((void*)(&ptr->SubPathString), SubPathString);
			UnrealReflectionUtils.CallUFunction(UTestClass_UFunction_UClass._ClassDefaultObjectPtr, UTestClass_UFunction_UClass.__SetSubPathString_NativeFunctionPtr, (void*)ptr);
			if (ObjectPtr != null)
			{
				FSoftObjectPtr.NativeCopy(ObjectPtr.NativePtr, &ptr->ObjectPtr, 1);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__SetSubPathString_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B451 RID: 46161 RVA: 0x0011BB84 File Offset: 0x00119D84
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__SetSubClassSet_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__SetSubClassSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B452 RID: 46162 RVA: 0x0011BBF0 File Offset: 0x00119DF0
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__SetSubClassMap_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__SetSubClassMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B453 RID: 46163 RVA: 0x0011BC5C File Offset: 0x00119E5C
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__SetSubClassArray_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__SetSubClassArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B454 RID: 46164 RVA: 0x0011BCC8 File Offset: 0x00119EC8
		[SkipLocalsInit]
		public unsafe void SetSubClass([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<USharpherealTestSimpleClass> InSubClass)
		{
			UTestClass_UFunction_UClass.__SetSubClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__SetSubClass_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__SetSubClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__SetSubClass_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InSubClass = InSubClass;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__SetSubClass_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B455 RID: 46165 RVA: 0x0011BD10 File Offset: 0x00119F10
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__SetStClassSet_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__SetStClassSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B456 RID: 46166 RVA: 0x0011BD7C File Offset: 0x00119F7C
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__SetStClassMap_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__SetStClassMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B457 RID: 46167 RVA: 0x0011BDE8 File Offset: 0x00119FE8
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__SetStClassArray_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__SetStClassArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B458 RID: 46168 RVA: 0x0011BE54 File Offset: 0x0011A054
		[SkipLocalsInit]
		public unsafe void SetStClass(UClassStackOnlyPtr InStClass)
		{
			UTestClass_UFunction_UClass.__SetStClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__SetStClass_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__SetStClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__SetStClass_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InStClass = InStClass;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__SetStClass_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B459 RID: 46169 RVA: 0x0011BE9C File Offset: 0x0011A09C
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__SetSoftClassSet_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__SetSoftClassSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B45A RID: 46170 RVA: 0x0011BF08 File Offset: 0x0011A108
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__SetSoftClassMap_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__SetSoftClassMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B45B RID: 46171 RVA: 0x0011BF74 File Offset: 0x0011A174
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__SetSoftClassArray_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__SetSoftClassArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B45C RID: 46172 RVA: 0x0011BFE0 File Offset: 0x0011A1E0
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void SetSoftClass(TSoftClassPtr<USharpherealTestSimpleClass> InSoftClass)
		{
			UTestClass_UFunction_UClass.__SetSoftClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__SetSoftClass_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__SetSoftClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__SetSoftClass_NativeFunctionPtr, (void*)ptr, 1);
			if (InSoftClass != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->InSoftClass, InSoftClass.NativePtr, 1);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__SetSoftClass_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__SetSoftClass_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B45D RID: 46173 RVA: 0x0011C04C File Offset: 0x0011A24C
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__SetClassPathSet_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__SetClassPathSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B45E RID: 46174 RVA: 0x0011C0B8 File Offset: 0x0011A2B8
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__SetClassPathMap_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__SetClassPathMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B45F RID: 46175 RVA: 0x0011C124 File Offset: 0x0011A324
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__SetClassPathArray_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__SetClassPathArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B460 RID: 46176 RVA: 0x0011C190 File Offset: 0x0011A390
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetClassPath(FSoftClassPath InClassPath)
		{
			UTestClass_UFunction_UClass.__SetClassPath_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__SetClassPath_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__SetClassPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__SetClassPath_NativeFunctionPtr, (void*)ptr, 1);
			if (InClassPath != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), &ptr->InClassPath, InClassPath.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__SetClassPath_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__SetClassPath_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B461 RID: 46177 RVA: 0x0011C204 File Offset: 0x0011A404
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__OutSubClassSet_NativeFunctionPtr, (void*)ptr);
			TSet<TSubclassOf<USharpherealTestSimpleClass>> tset2 = OutSubClassSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutSubClassSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__OutSubClassSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B462 RID: 46178 RVA: 0x0011C27C File Offset: 0x0011A47C
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__OutSubClassMap_NativeFunctionPtr, (void*)ptr);
			TMap<TSubclassOf<USharpherealTestSimpleClass>, int> tmap2 = OutSubClassMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutSubClassMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__OutSubClassMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B463 RID: 46179 RVA: 0x0011C2F4 File Offset: 0x0011A4F4
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__OutSubClassArray_NativeFunctionPtr, (void*)ptr);
			TArray<TSubclassOf<USharpherealTestSimpleClass>> tarray2 = OutSubClassArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutSubClassArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__OutSubClassArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B464 RID: 46180 RVA: 0x0011C36C File Offset: 0x0011A56C
		[SkipLocalsInit]
		public unsafe void OutSubClass([Nullable(new byte[]
		{
			0,
			1
		})] ref TSubclassOf<USharpherealTestSimpleClass> OutSubClass)
		{
			UTestClass_UFunction_UClass.__OutSubClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__OutSubClass_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__OutSubClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__OutSubClass_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutSubClass = OutSubClass;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__OutSubClass_NativeFunctionPtr, (void*)ptr);
			OutSubClass = ptr->OutSubClass;
		}

		// Token: 0x0600B465 RID: 46181 RVA: 0x0011C3C4 File Offset: 0x0011A5C4
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__OutStClassSet_NativeFunctionPtr, (void*)ptr);
			TSet<UClass> tset2 = OutStClassSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutStClassSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__OutStClassSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B466 RID: 46182 RVA: 0x0011C43C File Offset: 0x0011A63C
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__OutStClassMap_NativeFunctionPtr, (void*)ptr);
			TMap<UClass, int> tmap2 = OutStClassMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutStClassMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__OutStClassMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B467 RID: 46183 RVA: 0x0011C4B4 File Offset: 0x0011A6B4
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__OutStClassArray_NativeFunctionPtr, (void*)ptr);
			TArray<UClass> tarray2 = OutStClassArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutStClassArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__OutStClassArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B468 RID: 46184 RVA: 0x0011C52C File Offset: 0x0011A72C
		[SkipLocalsInit]
		public unsafe void OutStClass(ref UClassStackOnlyPtr OutStClass)
		{
			UTestClass_UFunction_UClass.__OutStClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__OutStClass_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__OutStClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__OutStClass_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutStClass = OutStClass;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__OutStClass_NativeFunctionPtr, (void*)ptr);
			OutStClass = ptr->OutStClass;
		}

		// Token: 0x0600B469 RID: 46185 RVA: 0x0011C584 File Offset: 0x0011A784
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__OutSoftClassSet_NativeFunctionPtr, (void*)ptr);
			TSet<TSoftClassPtr<USharpherealTestSimpleClass>> tset2 = OutSoftClassSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutSoftClassSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__OutSoftClassSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B46A RID: 46186 RVA: 0x0011C5FC File Offset: 0x0011A7FC
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__OutSoftClassMap_NativeFunctionPtr, (void*)ptr);
			TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int> tmap2 = OutSoftClassMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutSoftClassMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__OutSoftClassMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B46B RID: 46187 RVA: 0x0011C674 File Offset: 0x0011A874
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__OutSoftClassArray_NativeFunctionPtr, (void*)ptr);
			TArray<TSoftClassPtr<USharpherealTestSimpleClass>> tarray2 = OutSoftClassArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutSoftClassArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__OutSoftClassArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B46C RID: 46188 RVA: 0x0011C6EC File Offset: 0x0011A8EC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void OutSoftClass(ref TSoftClassPtr<USharpherealTestSimpleClass> OutSoftClass)
		{
			UTestClass_UFunction_UClass.__OutSoftClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__OutSoftClass_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__OutSoftClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__OutSoftClass_NativeFunctionPtr, (void*)ptr, 1);
			if (OutSoftClass != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->OutSoftClass, OutSoftClass.NativePtr, 1);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__OutSoftClass_NativeFunctionPtr, (void*)ptr);
			if (OutSoftClass != null)
			{
				FSoftObjectPtr.NativeCopy(OutSoftClass.NativePtr, &ptr->OutSoftClass, 1);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__OutSoftClass_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B46D RID: 46189 RVA: 0x0011C778 File Offset: 0x0011A978
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__OutClassPathSet_NativeFunctionPtr, (void*)ptr);
			TSet<FSoftClassPath> tset2 = OutClassPathSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutClassPathSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__OutClassPathSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B46E RID: 46190 RVA: 0x0011C7F0 File Offset: 0x0011A9F0
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__OutClassPathMap_NativeFunctionPtr, (void*)ptr);
			TMap<FSoftClassPath, int> tmap2 = OutClassPathMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutClassPathMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__OutClassPathMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B46F RID: 46191 RVA: 0x0011C868 File Offset: 0x0011AA68
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__OutClassPathArray_NativeFunctionPtr, (void*)ptr);
			TArray<FSoftClassPath> tarray2 = OutClassPathArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutClassPathArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__OutClassPathArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B470 RID: 46192 RVA: 0x0011C8E0 File Offset: 0x0011AAE0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutClassPath(ref FSoftClassPath OutClassPath)
		{
			UTestClass_UFunction_UClass.__OutClassPath_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__OutClassPath_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__OutClassPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__OutClassPath_NativeFunctionPtr, (void*)ptr, 1);
			if (OutClassPath != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), &ptr->OutClassPath, OutClassPath.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__OutClassPath_NativeFunctionPtr, (void*)ptr);
			if (OutClassPath != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), OutClassPath.NativePtr, &ptr->OutClassPath, 1, false);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__OutClassPath_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B471 RID: 46193 RVA: 0x0011C978 File Offset: 0x0011AB78
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__InSubClassSet_NativeFunctionPtr, (void*)ptr);
			TSet<TSubclassOf<USharpherealTestSimpleClass>> tset2 = InSubClassSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InSubClassSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__InSubClassSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B472 RID: 46194 RVA: 0x0011C9F0 File Offset: 0x0011ABF0
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__InSubClassMap_NativeFunctionPtr, (void*)ptr);
			TMap<TSubclassOf<USharpherealTestSimpleClass>, int> tmap2 = InSubClassMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InSubClassMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__InSubClassMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B473 RID: 46195 RVA: 0x0011CA68 File Offset: 0x0011AC68
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__InSubClassArray_NativeFunctionPtr, (void*)ptr);
			TArray<TSubclassOf<USharpherealTestSimpleClass>> tarray2 = InSubClassArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InSubClassArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__InSubClassArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B474 RID: 46196 RVA: 0x0011CAE0 File Offset: 0x0011ACE0
		[SkipLocalsInit]
		public unsafe void InSubClass([Nullable(new byte[]
		{
			0,
			1
		})] in TSubclassOf<USharpherealTestSimpleClass> InSubClass)
		{
			UTestClass_UFunction_UClass.__InSubClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__InSubClass_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__InSubClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__InSubClass_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InSubClass = InSubClass;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__InSubClass_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B475 RID: 46197 RVA: 0x0011CB2C File Offset: 0x0011AD2C
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__InStClassSet_NativeFunctionPtr, (void*)ptr);
			TSet<UClass> tset2 = InStClassSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InStClassSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__InStClassSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B476 RID: 46198 RVA: 0x0011CBA4 File Offset: 0x0011ADA4
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__InStClassMap_NativeFunctionPtr, (void*)ptr);
			TMap<UClass, int> tmap2 = InStClassMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InStClassMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__InStClassMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B477 RID: 46199 RVA: 0x0011CC1C File Offset: 0x0011AE1C
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__InStClassArray_NativeFunctionPtr, (void*)ptr);
			TArray<UClass> tarray2 = InStClassArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InStClassArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__InStClassArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B478 RID: 46200 RVA: 0x0011CC94 File Offset: 0x0011AE94
		[SkipLocalsInit]
		public unsafe void InStClass(in UClassStackOnlyPtr InStClass)
		{
			UTestClass_UFunction_UClass.__InStClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__InStClass_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__InStClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__InStClass_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InStClass = InStClass;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__InStClass_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B479 RID: 46201 RVA: 0x0011CCE0 File Offset: 0x0011AEE0
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__InSoftClassSet_NativeFunctionPtr, (void*)ptr);
			TSet<TSoftClassPtr<USharpherealTestSimpleClass>> tset2 = InSoftClassSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InSoftClassSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__InSoftClassSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B47A RID: 46202 RVA: 0x0011CD58 File Offset: 0x0011AF58
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__InSoftClassMap_NativeFunctionPtr, (void*)ptr);
			TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int> tmap2 = InSoftClassMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InSoftClassMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__InSoftClassMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B47B RID: 46203 RVA: 0x0011CDD0 File Offset: 0x0011AFD0
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__InSoftClassArray_NativeFunctionPtr, (void*)ptr);
			TArray<TSoftClassPtr<USharpherealTestSimpleClass>> tarray2 = InSoftClassArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InSoftClassArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__InSoftClassArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B47C RID: 46204 RVA: 0x0011CE48 File Offset: 0x0011B048
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void InSoftClass(in TSoftClassPtr<USharpherealTestSimpleClass> InSoftClass)
		{
			UTestClass_UFunction_UClass.__InSoftClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__InSoftClass_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__InSoftClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__InSoftClass_NativeFunctionPtr, (void*)ptr, 1);
			if (InSoftClass != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->InSoftClass, InSoftClass.NativePtr, 1);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__InSoftClass_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__InSoftClass_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B47D RID: 46205 RVA: 0x0011CEB8 File Offset: 0x0011B0B8
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__InClassPathSet_NativeFunctionPtr, (void*)ptr);
			TSet<FSoftClassPath> tset2 = InClassPathSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InClassPathSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__InClassPathSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B47E RID: 46206 RVA: 0x0011CF30 File Offset: 0x0011B130
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__InClassPathMap_NativeFunctionPtr, (void*)ptr);
			TMap<FSoftClassPath, int> tmap2 = InClassPathMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InClassPathMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__InClassPathMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B47F RID: 46207 RVA: 0x0011CFA8 File Offset: 0x0011B1A8
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__InClassPathArray_NativeFunctionPtr, (void*)ptr);
			TArray<FSoftClassPath> tarray2 = InClassPathArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InClassPathArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__InClassPathArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B480 RID: 46208 RVA: 0x0011D020 File Offset: 0x0011B220
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InClassPath(in FSoftClassPath InClassPath)
		{
			UTestClass_UFunction_UClass.__InClassPath_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__InClassPath_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__InClassPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__InClassPath_NativeFunctionPtr, (void*)ptr, 1);
			if (InClassPath != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), &ptr->InClassPath, InClassPath.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__InClassPath_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__InClassPath_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B481 RID: 46209 RVA: 0x0011D094 File Offset: 0x0011B294
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__GetSubClassSet_NativeFunctionPtr, (void*)ptr);
			TSet<TSubclassOf<USharpherealTestSimpleClass>> result = new TSet<TSubclassOf<USharpherealTestSimpleClass>>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__GetSubClassSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B482 RID: 46210 RVA: 0x0011D0F4 File Offset: 0x0011B2F4
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__GetSubClassMap_NativeFunctionPtr, (void*)ptr);
			TMap<TSubclassOf<USharpherealTestSimpleClass>, int> result = new TMap<TSubclassOf<USharpherealTestSimpleClass>, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__GetSubClassMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B483 RID: 46211 RVA: 0x0011D154 File Offset: 0x0011B354
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__GetSubClassArray_NativeFunctionPtr, (void*)ptr);
			TArray<TSubclassOf<USharpherealTestSimpleClass>> result = new TArray<TSubclassOf<USharpherealTestSimpleClass>>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__GetSubClassArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B484 RID: 46212 RVA: 0x0011D1B4 File Offset: 0x0011B3B4
		[SkipLocalsInit]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<USharpherealTestSimpleClass> GetSubClass()
		{
			UTestClass_UFunction_UClass.__GetSubClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__GetSubClass_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__GetSubClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__GetSubClass_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__GetSubClass_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B485 RID: 46213 RVA: 0x0011D1FC File Offset: 0x0011B3FC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSet<UClass> GetStClassSet()
		{
			UTestClass_UFunction_UClass.__GetStClassSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__GetStClassSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__GetStClassSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__GetStClassSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__GetStClassSet_NativeFunctionPtr, (void*)ptr);
			TSet<UClass> result = new TSet<UClass>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__GetStClassSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B486 RID: 46214 RVA: 0x0011D25C File Offset: 0x0011B45C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TMap<UClass, int> GetStClassMap()
		{
			UTestClass_UFunction_UClass.__GetStClassMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__GetStClassMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__GetStClassMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__GetStClassMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__GetStClassMap_NativeFunctionPtr, (void*)ptr);
			TMap<UClass, int> result = new TMap<UClass, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__GetStClassMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B487 RID: 46215 RVA: 0x0011D2BC File Offset: 0x0011B4BC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<UClass> GetStClassArray()
		{
			UTestClass_UFunction_UClass.__GetStClassArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__GetStClassArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__GetStClassArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__GetStClassArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__GetStClassArray_NativeFunctionPtr, (void*)ptr);
			TArray<UClass> result = new TArray<UClass>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__GetStClassArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B488 RID: 46216 RVA: 0x0011D31C File Offset: 0x0011B51C
		[SkipLocalsInit]
		public unsafe UClassStackOnlyPtr GetStClass()
		{
			UTestClass_UFunction_UClass.__GetStClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__GetStClass_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__GetStClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__GetStClass_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__GetStClass_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B489 RID: 46217 RVA: 0x0011D364 File Offset: 0x0011B564
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSet<TSoftClassPtr<USharpherealTestSimpleClass>> GetSoftClassSet()
		{
			UTestClass_UFunction_UClass.__GetSoftClassSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__GetSoftClassSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__GetSoftClassSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__GetSoftClassSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__GetSoftClassSet_NativeFunctionPtr, (void*)ptr);
			TSet<TSoftClassPtr<USharpherealTestSimpleClass>> result = new TSet<TSoftClassPtr<USharpherealTestSimpleClass>>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__GetSoftClassSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B48A RID: 46218 RVA: 0x0011D3C4 File Offset: 0x0011B5C4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int> GetSoftClassMap()
		{
			UTestClass_UFunction_UClass.__GetSoftClassMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__GetSoftClassMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__GetSoftClassMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__GetSoftClassMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__GetSoftClassMap_NativeFunctionPtr, (void*)ptr);
			TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int> result = new TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__GetSoftClassMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B48B RID: 46219 RVA: 0x0011D424 File Offset: 0x0011B624
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<TSoftClassPtr<USharpherealTestSimpleClass>> GetSoftClassArray()
		{
			UTestClass_UFunction_UClass.__GetSoftClassArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__GetSoftClassArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__GetSoftClassArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__GetSoftClassArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__GetSoftClassArray_NativeFunctionPtr, (void*)ptr);
			TArray<TSoftClassPtr<USharpherealTestSimpleClass>> result = new TArray<TSoftClassPtr<USharpherealTestSimpleClass>>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__GetSoftClassArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B48C RID: 46220 RVA: 0x0011D484 File Offset: 0x0011B684
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSoftClassPtr<USharpherealTestSimpleClass> GetSoftClass()
		{
			UTestClass_UFunction_UClass.__GetSoftClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__GetSoftClass_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__GetSoftClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__GetSoftClass_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__GetSoftClass_NativeFunctionPtr, (void*)ptr);
			TSoftClassPtr<USharpherealTestSimpleClass> result = new TSoftClassPtr<USharpherealTestSimpleClass>(&ptr->__Result, false, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__GetSoftClass_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B48D RID: 46221 RVA: 0x0011D4E4 File Offset: 0x0011B6E4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSet<FSoftClassPath> GetClassPathSet()
		{
			UTestClass_UFunction_UClass.__GetClassPathSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__GetClassPathSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__GetClassPathSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__GetClassPathSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__GetClassPathSet_NativeFunctionPtr, (void*)ptr);
			TSet<FSoftClassPath> result = new TSet<FSoftClassPath>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__GetClassPathSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B48E RID: 46222 RVA: 0x0011D544 File Offset: 0x0011B744
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TMap<FSoftClassPath, int> GetClassPathMap()
		{
			UTestClass_UFunction_UClass.__GetClassPathMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__GetClassPathMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__GetClassPathMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__GetClassPathMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__GetClassPathMap_NativeFunctionPtr, (void*)ptr);
			TMap<FSoftClassPath, int> result = new TMap<FSoftClassPath, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__GetClassPathMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B48F RID: 46223 RVA: 0x0011D5A4 File Offset: 0x0011B7A4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<FSoftClassPath> GetClassPathArray()
		{
			UTestClass_UFunction_UClass.__GetClassPathArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__GetClassPathArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__GetClassPathArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__GetClassPathArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__GetClassPathArray_NativeFunctionPtr, (void*)ptr);
			TArray<FSoftClassPath> result = new TArray<FSoftClassPath>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__GetClassPathArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B490 RID: 46224 RVA: 0x0011D604 File Offset: 0x0011B804
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe FSoftClassPath GetClassPath()
		{
			UTestClass_UFunction_UClass.__GetClassPath_FunctionParams* ptr = stackalloc UTestClass_UFunction_UClass.__GetClassPath_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_UClass.__GetClassPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_UClass.__GetClassPath_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_UClass.__GetClassPath_NativeFunctionPtr, (void*)ptr);
			FSoftClassPath result = new FSoftClassPath(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_UClass.__GetClassPath_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B491 RID: 46225 RVA: 0x0011D662 File Offset: 0x0011B862
		static UTestClass_UFunction_UClass()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SharpherealTest.TestClass_UFunction_UClass");
		}

		// Token: 0x0600B492 RID: 46226 RVA: 0x0011D670 File Offset: 0x0011B870
		protected UTestClass_UFunction_UClass(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040050BE RID: 20670
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SharpherealTest.TestClass_UFunction_UClass";

		// Token: 0x040050BF RID: 20671
		private static IntPtr _ClassPtr;

		// Token: 0x040050C0 RID: 20672
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040050C1 RID: 20673
		internal static int __PropertyOffset_StClass;

		// Token: 0x040050C2 RID: 20674
		internal static int __PropertyOffset_StClassArray;

		// Token: 0x040050C3 RID: 20675
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UClass> _StClassArray;

		// Token: 0x040050C4 RID: 20676
		internal static int __PropertyOffset_StClassSet;

		// Token: 0x040050C5 RID: 20677
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UClass> _StClassSet;

		// Token: 0x040050C6 RID: 20678
		internal static int __PropertyOffset_StClassMap;

		// Token: 0x040050C7 RID: 20679
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<UClass, int> _StClassMap;

		// Token: 0x040050C8 RID: 20680
		internal static int __PropertyOffset_SoftClass;

		// Token: 0x040050C9 RID: 20681
		internal static int __PropertyOffset_SoftClassArray;

		// Token: 0x040050CA RID: 20682
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TArray<TSoftClassPtr<USharpherealTestSimpleClass>> _SoftClassArray;

		// Token: 0x040050CB RID: 20683
		internal static int __PropertyOffset_SoftClassSet;

		// Token: 0x040050CC RID: 20684
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TSet<TSoftClassPtr<USharpherealTestSimpleClass>> _SoftClassSet;

		// Token: 0x040050CD RID: 20685
		internal static int __PropertyOffset_SoftClassMap;

		// Token: 0x040050CE RID: 20686
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int> _SoftClassMap;

		// Token: 0x040050CF RID: 20687
		internal static int __PropertyOffset_SubClass;

		// Token: 0x040050D0 RID: 20688
		internal static int __PropertyOffset_SubClassArray;

		// Token: 0x040050D1 RID: 20689
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TSubclassOf<USharpherealTestSimpleClass>> _SubClassArray;

		// Token: 0x040050D2 RID: 20690
		internal static int __PropertyOffset_SubClassSet;

		// Token: 0x040050D3 RID: 20691
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TSet<TSubclassOf<USharpherealTestSimpleClass>> _SubClassSet;

		// Token: 0x040050D4 RID: 20692
		internal static int __PropertyOffset_SubClassMap;

		// Token: 0x040050D5 RID: 20693
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TSubclassOf<USharpherealTestSimpleClass>, int> _SubClassMap;

		// Token: 0x040050D6 RID: 20694
		internal static int __PropertyOffset_ClassPath;

		// Token: 0x040050D7 RID: 20695
		[Nullable(2)]
		private FSoftClassPath _ClassPath;

		// Token: 0x040050D8 RID: 20696
		internal static int __PropertyOffset_ClassPathArray;

		// Token: 0x040050D9 RID: 20697
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoftClassPath> _ClassPathArray;

		// Token: 0x040050DA RID: 20698
		internal static int __PropertyOffset_ClassPathSet;

		// Token: 0x040050DB RID: 20699
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<FSoftClassPath> _ClassPathSet;

		// Token: 0x040050DC RID: 20700
		internal static int __PropertyOffset_ClassPathMap;

		// Token: 0x040050DD RID: 20701
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FSoftClassPath, int> _ClassPathMap;

		// Token: 0x040050DE RID: 20702
		private static IntPtr __SetSubPathString_NativeFunctionPtr;

		// Token: 0x040050DF RID: 20703
		private static IntPtr __SetSubClassSet_NativeFunctionPtr;

		// Token: 0x040050E0 RID: 20704
		private static IntPtr __SetSubClassMap_NativeFunctionPtr;

		// Token: 0x040050E1 RID: 20705
		private static IntPtr __SetSubClassArray_NativeFunctionPtr;

		// Token: 0x040050E2 RID: 20706
		private static IntPtr __SetSubClass_NativeFunctionPtr;

		// Token: 0x040050E3 RID: 20707
		private static IntPtr __SetStClassSet_NativeFunctionPtr;

		// Token: 0x040050E4 RID: 20708
		private static IntPtr __SetStClassMap_NativeFunctionPtr;

		// Token: 0x040050E5 RID: 20709
		private static IntPtr __SetStClassArray_NativeFunctionPtr;

		// Token: 0x040050E6 RID: 20710
		private static IntPtr __SetStClass_NativeFunctionPtr;

		// Token: 0x040050E7 RID: 20711
		private static IntPtr __SetSoftClassSet_NativeFunctionPtr;

		// Token: 0x040050E8 RID: 20712
		private static IntPtr __SetSoftClassMap_NativeFunctionPtr;

		// Token: 0x040050E9 RID: 20713
		private static IntPtr __SetSoftClassArray_NativeFunctionPtr;

		// Token: 0x040050EA RID: 20714
		private static IntPtr __SetSoftClass_NativeFunctionPtr;

		// Token: 0x040050EB RID: 20715
		private static IntPtr __SetClassPathSet_NativeFunctionPtr;

		// Token: 0x040050EC RID: 20716
		private static IntPtr __SetClassPathMap_NativeFunctionPtr;

		// Token: 0x040050ED RID: 20717
		private static IntPtr __SetClassPathArray_NativeFunctionPtr;

		// Token: 0x040050EE RID: 20718
		private static IntPtr __SetClassPath_NativeFunctionPtr;

		// Token: 0x040050EF RID: 20719
		private static IntPtr __OutSubClassSet_NativeFunctionPtr;

		// Token: 0x040050F0 RID: 20720
		private static IntPtr __OutSubClassMap_NativeFunctionPtr;

		// Token: 0x040050F1 RID: 20721
		private static IntPtr __OutSubClassArray_NativeFunctionPtr;

		// Token: 0x040050F2 RID: 20722
		private static IntPtr __OutSubClass_NativeFunctionPtr;

		// Token: 0x040050F3 RID: 20723
		private static IntPtr __OutStClassSet_NativeFunctionPtr;

		// Token: 0x040050F4 RID: 20724
		private static IntPtr __OutStClassMap_NativeFunctionPtr;

		// Token: 0x040050F5 RID: 20725
		private static IntPtr __OutStClassArray_NativeFunctionPtr;

		// Token: 0x040050F6 RID: 20726
		private static IntPtr __OutStClass_NativeFunctionPtr;

		// Token: 0x040050F7 RID: 20727
		private static IntPtr __OutSoftClassSet_NativeFunctionPtr;

		// Token: 0x040050F8 RID: 20728
		private static IntPtr __OutSoftClassMap_NativeFunctionPtr;

		// Token: 0x040050F9 RID: 20729
		private static IntPtr __OutSoftClassArray_NativeFunctionPtr;

		// Token: 0x040050FA RID: 20730
		private static IntPtr __OutSoftClass_NativeFunctionPtr;

		// Token: 0x040050FB RID: 20731
		private static IntPtr __OutClassPathSet_NativeFunctionPtr;

		// Token: 0x040050FC RID: 20732
		private static IntPtr __OutClassPathMap_NativeFunctionPtr;

		// Token: 0x040050FD RID: 20733
		private static IntPtr __OutClassPathArray_NativeFunctionPtr;

		// Token: 0x040050FE RID: 20734
		private static IntPtr __OutClassPath_NativeFunctionPtr;

		// Token: 0x040050FF RID: 20735
		private static IntPtr __InSubClassSet_NativeFunctionPtr;

		// Token: 0x04005100 RID: 20736
		private static IntPtr __InSubClassMap_NativeFunctionPtr;

		// Token: 0x04005101 RID: 20737
		private static IntPtr __InSubClassArray_NativeFunctionPtr;

		// Token: 0x04005102 RID: 20738
		private static IntPtr __InSubClass_NativeFunctionPtr;

		// Token: 0x04005103 RID: 20739
		private static IntPtr __InStClassSet_NativeFunctionPtr;

		// Token: 0x04005104 RID: 20740
		private static IntPtr __InStClassMap_NativeFunctionPtr;

		// Token: 0x04005105 RID: 20741
		private static IntPtr __InStClassArray_NativeFunctionPtr;

		// Token: 0x04005106 RID: 20742
		private static IntPtr __InStClass_NativeFunctionPtr;

		// Token: 0x04005107 RID: 20743
		private static IntPtr __InSoftClassSet_NativeFunctionPtr;

		// Token: 0x04005108 RID: 20744
		private static IntPtr __InSoftClassMap_NativeFunctionPtr;

		// Token: 0x04005109 RID: 20745
		private static IntPtr __InSoftClassArray_NativeFunctionPtr;

		// Token: 0x0400510A RID: 20746
		private static IntPtr __InSoftClass_NativeFunctionPtr;

		// Token: 0x0400510B RID: 20747
		private static IntPtr __InClassPathSet_NativeFunctionPtr;

		// Token: 0x0400510C RID: 20748
		private static IntPtr __InClassPathMap_NativeFunctionPtr;

		// Token: 0x0400510D RID: 20749
		private static IntPtr __InClassPathArray_NativeFunctionPtr;

		// Token: 0x0400510E RID: 20750
		private static IntPtr __InClassPath_NativeFunctionPtr;

		// Token: 0x0400510F RID: 20751
		private static IntPtr __GetSubClassSet_NativeFunctionPtr;

		// Token: 0x04005110 RID: 20752
		private static IntPtr __GetSubClassMap_NativeFunctionPtr;

		// Token: 0x04005111 RID: 20753
		private static IntPtr __GetSubClassArray_NativeFunctionPtr;

		// Token: 0x04005112 RID: 20754
		private static IntPtr __GetSubClass_NativeFunctionPtr;

		// Token: 0x04005113 RID: 20755
		private static IntPtr __GetStClassSet_NativeFunctionPtr;

		// Token: 0x04005114 RID: 20756
		private static IntPtr __GetStClassMap_NativeFunctionPtr;

		// Token: 0x04005115 RID: 20757
		private static IntPtr __GetStClassArray_NativeFunctionPtr;

		// Token: 0x04005116 RID: 20758
		private static IntPtr __GetStClass_NativeFunctionPtr;

		// Token: 0x04005117 RID: 20759
		private static IntPtr __GetSoftClassSet_NativeFunctionPtr;

		// Token: 0x04005118 RID: 20760
		private static IntPtr __GetSoftClassMap_NativeFunctionPtr;

		// Token: 0x04005119 RID: 20761
		private static IntPtr __GetSoftClassArray_NativeFunctionPtr;

		// Token: 0x0400511A RID: 20762
		private static IntPtr __GetSoftClass_NativeFunctionPtr;

		// Token: 0x0400511B RID: 20763
		private static IntPtr __GetClassPathSet_NativeFunctionPtr;

		// Token: 0x0400511C RID: 20764
		private static IntPtr __GetClassPathMap_NativeFunctionPtr;

		// Token: 0x0400511D RID: 20765
		private static IntPtr __GetClassPathArray_NativeFunctionPtr;

		// Token: 0x0400511E RID: 20766
		private static IntPtr __GetClassPath_NativeFunctionPtr;

		// Token: 0x02001297 RID: 4759
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __SetSubPathString_FunctionParams
		{
			// Token: 0x040066A1 RID: 26273
			[FieldOffset(0)]
			public byte ObjectPtr;

			// Token: 0x040066A2 RID: 26274
			[FieldOffset(48)]
			public FString SubPathString;
		}

		// Token: 0x02001298 RID: 4760
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetSubClassSet_FunctionParams
		{
			// Token: 0x040066A3 RID: 26275
			[FieldOffset(0)]
			public byte InSubClassSet;
		}

		// Token: 0x02001299 RID: 4761
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetSubClassMap_FunctionParams
		{
			// Token: 0x040066A4 RID: 26276
			[FieldOffset(0)]
			public byte InSubClassMap;
		}

		// Token: 0x0200129A RID: 4762
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetSubClassArray_FunctionParams
		{
			// Token: 0x040066A5 RID: 26277
			[FieldOffset(0)]
			public byte InSubClassArray;
		}

		// Token: 0x0200129B RID: 4763
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetSubClass_FunctionParams
		{
			// Token: 0x040066A6 RID: 26278
			[Nullable(new byte[]
			{
				0,
				1
			})]
			[FieldOffset(0)]
			public TSubclassOf<USharpherealTestSimpleClass> InSubClass;
		}

		// Token: 0x0200129C RID: 4764
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetStClassSet_FunctionParams
		{
			// Token: 0x040066A7 RID: 26279
			[FieldOffset(0)]
			public byte InStClassSet;
		}

		// Token: 0x0200129D RID: 4765
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetStClassMap_FunctionParams
		{
			// Token: 0x040066A8 RID: 26280
			[FieldOffset(0)]
			public byte InStClassMap;
		}

		// Token: 0x0200129E RID: 4766
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetStClassArray_FunctionParams
		{
			// Token: 0x040066A9 RID: 26281
			[FieldOffset(0)]
			public byte InStClassArray;
		}

		// Token: 0x0200129F RID: 4767
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetStClass_FunctionParams
		{
			// Token: 0x040066AA RID: 26282
			[FieldOffset(0)]
			public UClassStackOnlyPtr InStClass;
		}

		// Token: 0x020012A0 RID: 4768
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetSoftClassSet_FunctionParams
		{
			// Token: 0x040066AB RID: 26283
			[FieldOffset(0)]
			public byte InSoftClassSet;
		}

		// Token: 0x020012A1 RID: 4769
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetSoftClassMap_FunctionParams
		{
			// Token: 0x040066AC RID: 26284
			[FieldOffset(0)]
			public byte InSoftClassMap;
		}

		// Token: 0x020012A2 RID: 4770
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetSoftClassArray_FunctionParams
		{
			// Token: 0x040066AD RID: 26285
			[FieldOffset(0)]
			public byte InSoftClassArray;
		}

		// Token: 0x020012A3 RID: 4771
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __SetSoftClass_FunctionParams
		{
			// Token: 0x040066AE RID: 26286
			[FieldOffset(0)]
			public byte InSoftClass;
		}

		// Token: 0x020012A4 RID: 4772
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetClassPathSet_FunctionParams
		{
			// Token: 0x040066AF RID: 26287
			[FieldOffset(0)]
			public byte InClassPathSet;
		}

		// Token: 0x020012A5 RID: 4773
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetClassPathMap_FunctionParams
		{
			// Token: 0x040066B0 RID: 26288
			[FieldOffset(0)]
			public byte InClassPathMap;
		}

		// Token: 0x020012A6 RID: 4774
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetClassPathArray_FunctionParams
		{
			// Token: 0x040066B1 RID: 26289
			[FieldOffset(0)]
			public byte InClassPathArray;
		}

		// Token: 0x020012A7 RID: 4775
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetClassPath_FunctionParams
		{
			// Token: 0x040066B2 RID: 26290
			[FieldOffset(0)]
			public byte InClassPath;
		}

		// Token: 0x020012A8 RID: 4776
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutSubClassSet_FunctionParams
		{
			// Token: 0x040066B3 RID: 26291
			[FieldOffset(0)]
			public byte OutSubClassSet;
		}

		// Token: 0x020012A9 RID: 4777
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutSubClassMap_FunctionParams
		{
			// Token: 0x040066B4 RID: 26292
			[FieldOffset(0)]
			public byte OutSubClassMap;
		}

		// Token: 0x020012AA RID: 4778
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutSubClassArray_FunctionParams
		{
			// Token: 0x040066B5 RID: 26293
			[FieldOffset(0)]
			public byte OutSubClassArray;
		}

		// Token: 0x020012AB RID: 4779
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OutSubClass_FunctionParams
		{
			// Token: 0x040066B6 RID: 26294
			[Nullable(new byte[]
			{
				0,
				1
			})]
			[FieldOffset(0)]
			public TSubclassOf<USharpherealTestSimpleClass> OutSubClass;
		}

		// Token: 0x020012AC RID: 4780
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutStClassSet_FunctionParams
		{
			// Token: 0x040066B7 RID: 26295
			[FieldOffset(0)]
			public byte OutStClassSet;
		}

		// Token: 0x020012AD RID: 4781
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutStClassMap_FunctionParams
		{
			// Token: 0x040066B8 RID: 26296
			[FieldOffset(0)]
			public byte OutStClassMap;
		}

		// Token: 0x020012AE RID: 4782
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutStClassArray_FunctionParams
		{
			// Token: 0x040066B9 RID: 26297
			[FieldOffset(0)]
			public byte OutStClassArray;
		}

		// Token: 0x020012AF RID: 4783
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OutStClass_FunctionParams
		{
			// Token: 0x040066BA RID: 26298
			[FieldOffset(0)]
			public UClassStackOnlyPtr OutStClass;
		}

		// Token: 0x020012B0 RID: 4784
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutSoftClassSet_FunctionParams
		{
			// Token: 0x040066BB RID: 26299
			[FieldOffset(0)]
			public byte OutSoftClassSet;
		}

		// Token: 0x020012B1 RID: 4785
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutSoftClassMap_FunctionParams
		{
			// Token: 0x040066BC RID: 26300
			[FieldOffset(0)]
			public byte OutSoftClassMap;
		}

		// Token: 0x020012B2 RID: 4786
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutSoftClassArray_FunctionParams
		{
			// Token: 0x040066BD RID: 26301
			[FieldOffset(0)]
			public byte OutSoftClassArray;
		}

		// Token: 0x020012B3 RID: 4787
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __OutSoftClass_FunctionParams
		{
			// Token: 0x040066BE RID: 26302
			[FieldOffset(0)]
			public byte OutSoftClass;
		}

		// Token: 0x020012B4 RID: 4788
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutClassPathSet_FunctionParams
		{
			// Token: 0x040066BF RID: 26303
			[FieldOffset(0)]
			public byte OutClassPathSet;
		}

		// Token: 0x020012B5 RID: 4789
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutClassPathMap_FunctionParams
		{
			// Token: 0x040066C0 RID: 26304
			[FieldOffset(0)]
			public byte OutClassPathMap;
		}

		// Token: 0x020012B6 RID: 4790
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutClassPathArray_FunctionParams
		{
			// Token: 0x040066C1 RID: 26305
			[FieldOffset(0)]
			public byte OutClassPathArray;
		}

		// Token: 0x020012B7 RID: 4791
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __OutClassPath_FunctionParams
		{
			// Token: 0x040066C2 RID: 26306
			[FieldOffset(0)]
			public byte OutClassPath;
		}

		// Token: 0x020012B8 RID: 4792
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InSubClassSet_FunctionParams
		{
			// Token: 0x040066C3 RID: 26307
			[FieldOffset(0)]
			public byte InSubClassSet;
		}

		// Token: 0x020012B9 RID: 4793
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InSubClassMap_FunctionParams
		{
			// Token: 0x040066C4 RID: 26308
			[FieldOffset(0)]
			public byte InSubClassMap;
		}

		// Token: 0x020012BA RID: 4794
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InSubClassArray_FunctionParams
		{
			// Token: 0x040066C5 RID: 26309
			[FieldOffset(0)]
			public byte InSubClassArray;
		}

		// Token: 0x020012BB RID: 4795
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __InSubClass_FunctionParams
		{
			// Token: 0x040066C6 RID: 26310
			[Nullable(new byte[]
			{
				0,
				1
			})]
			[FieldOffset(0)]
			public TSubclassOf<USharpherealTestSimpleClass> InSubClass;
		}

		// Token: 0x020012BC RID: 4796
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InStClassSet_FunctionParams
		{
			// Token: 0x040066C7 RID: 26311
			[FieldOffset(0)]
			public byte InStClassSet;
		}

		// Token: 0x020012BD RID: 4797
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InStClassMap_FunctionParams
		{
			// Token: 0x040066C8 RID: 26312
			[FieldOffset(0)]
			public byte InStClassMap;
		}

		// Token: 0x020012BE RID: 4798
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InStClassArray_FunctionParams
		{
			// Token: 0x040066C9 RID: 26313
			[FieldOffset(0)]
			public byte InStClassArray;
		}

		// Token: 0x020012BF RID: 4799
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __InStClass_FunctionParams
		{
			// Token: 0x040066CA RID: 26314
			[FieldOffset(0)]
			public UClassStackOnlyPtr InStClass;
		}

		// Token: 0x020012C0 RID: 4800
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InSoftClassSet_FunctionParams
		{
			// Token: 0x040066CB RID: 26315
			[FieldOffset(0)]
			public byte InSoftClassSet;
		}

		// Token: 0x020012C1 RID: 4801
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InSoftClassMap_FunctionParams
		{
			// Token: 0x040066CC RID: 26316
			[FieldOffset(0)]
			public byte InSoftClassMap;
		}

		// Token: 0x020012C2 RID: 4802
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InSoftClassArray_FunctionParams
		{
			// Token: 0x040066CD RID: 26317
			[FieldOffset(0)]
			public byte InSoftClassArray;
		}

		// Token: 0x020012C3 RID: 4803
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __InSoftClass_FunctionParams
		{
			// Token: 0x040066CE RID: 26318
			[FieldOffset(0)]
			public byte InSoftClass;
		}

		// Token: 0x020012C4 RID: 4804
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InClassPathSet_FunctionParams
		{
			// Token: 0x040066CF RID: 26319
			[FieldOffset(0)]
			public byte InClassPathSet;
		}

		// Token: 0x020012C5 RID: 4805
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InClassPathMap_FunctionParams
		{
			// Token: 0x040066D0 RID: 26320
			[FieldOffset(0)]
			public byte InClassPathMap;
		}

		// Token: 0x020012C6 RID: 4806
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InClassPathArray_FunctionParams
		{
			// Token: 0x040066D1 RID: 26321
			[FieldOffset(0)]
			public byte InClassPathArray;
		}

		// Token: 0x020012C7 RID: 4807
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InClassPath_FunctionParams
		{
			// Token: 0x040066D2 RID: 26322
			[FieldOffset(0)]
			public byte InClassPath;
		}

		// Token: 0x020012C8 RID: 4808
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetSubClassSet_FunctionParams
		{
			// Token: 0x040066D3 RID: 26323
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020012C9 RID: 4809
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetSubClassMap_FunctionParams
		{
			// Token: 0x040066D4 RID: 26324
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020012CA RID: 4810
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSubClassArray_FunctionParams
		{
			// Token: 0x040066D5 RID: 26325
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020012CB RID: 4811
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetSubClass_FunctionParams
		{
			// Token: 0x040066D6 RID: 26326
			[Nullable(new byte[]
			{
				0,
				1
			})]
			[FieldOffset(0)]
			public TSubclassOf<USharpherealTestSimpleClass> __Result;
		}

		// Token: 0x020012CC RID: 4812
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetStClassSet_FunctionParams
		{
			// Token: 0x040066D7 RID: 26327
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020012CD RID: 4813
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetStClassMap_FunctionParams
		{
			// Token: 0x040066D8 RID: 26328
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020012CE RID: 4814
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetStClassArray_FunctionParams
		{
			// Token: 0x040066D9 RID: 26329
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020012CF RID: 4815
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetStClass_FunctionParams
		{
			// Token: 0x040066DA RID: 26330
			[FieldOffset(0)]
			public UClassStackOnlyPtr __Result;
		}

		// Token: 0x020012D0 RID: 4816
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetSoftClassSet_FunctionParams
		{
			// Token: 0x040066DB RID: 26331
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020012D1 RID: 4817
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetSoftClassMap_FunctionParams
		{
			// Token: 0x040066DC RID: 26332
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020012D2 RID: 4818
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSoftClassArray_FunctionParams
		{
			// Token: 0x040066DD RID: 26333
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020012D3 RID: 4819
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __GetSoftClass_FunctionParams
		{
			// Token: 0x040066DE RID: 26334
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020012D4 RID: 4820
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetClassPathSet_FunctionParams
		{
			// Token: 0x040066DF RID: 26335
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020012D5 RID: 4821
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetClassPathMap_FunctionParams
		{
			// Token: 0x040066E0 RID: 26336
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020012D6 RID: 4822
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetClassPathArray_FunctionParams
		{
			// Token: 0x040066E1 RID: 26337
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020012D7 RID: 4823
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetClassPath_FunctionParams
		{
			// Token: 0x040066E2 RID: 26338
			[FieldOffset(0)]
			public byte __Result;
		}
	}
}
