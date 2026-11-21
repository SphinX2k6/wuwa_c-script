using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000800 RID: 2048
	[UnrealObjectPath("/Script/SharpherealTest.TestClass_UFunction_Direct_UClass")]
	[UnrealStructLayout(848, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 848)]
	public class UTestClass_UFunction_Direct_UClass : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B269 RID: 45673 RVA: 0x001131B0 File Offset: 0x001113B0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTestClass_UFunction_Direct_UClass._ClassPtr;
		}

		// Token: 0x0600B26A RID: 45674 RVA: 0x001131BC File Offset: 0x001113BC
		public UTestClass_UFunction_Direct_UClass() : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_Direct_UClass.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B26B RID: 45675 RVA: 0x001131E4 File Offset: 0x001113E4
		[NullableContext(1)]
		public UTestClass_UFunction_Direct_UClass(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_Direct_UClass.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700217C RID: 8572
		// (get) Token: 0x0600B26C RID: 45676 RVA: 0x00113217 File Offset: 0x00111417
		// (set) Token: 0x0600B26D RID: 45677 RVA: 0x0011322B File Offset: 0x0011142B
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

		// Token: 0x1700217D RID: 8573
		// (get) Token: 0x0600B26E RID: 45678 RVA: 0x00113240 File Offset: 0x00111440
		// (set) Token: 0x0600B26F RID: 45679 RVA: 0x00113279 File Offset: 0x00111479
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

		// Token: 0x1700217E RID: 8574
		// (get) Token: 0x0600B270 RID: 45680 RVA: 0x00113288 File Offset: 0x00111488
		// (set) Token: 0x0600B271 RID: 45681 RVA: 0x001132C1 File Offset: 0x001114C1
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

		// Token: 0x1700217F RID: 8575
		// (get) Token: 0x0600B272 RID: 45682 RVA: 0x001132D0 File Offset: 0x001114D0
		// (set) Token: 0x0600B273 RID: 45683 RVA: 0x00113309 File Offset: 0x00111509
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

		// Token: 0x17002180 RID: 8576
		// (get) Token: 0x0600B274 RID: 45684 RVA: 0x00113317 File Offset: 0x00111517
		// (set) Token: 0x0600B275 RID: 45685 RVA: 0x0011332C File Offset: 0x0011152C
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

		// Token: 0x17002181 RID: 8577
		// (get) Token: 0x0600B276 RID: 45686 RVA: 0x00113354 File Offset: 0x00111554
		// (set) Token: 0x0600B277 RID: 45687 RVA: 0x0011338D File Offset: 0x0011158D
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

		// Token: 0x17002182 RID: 8578
		// (get) Token: 0x0600B278 RID: 45688 RVA: 0x0011339C File Offset: 0x0011159C
		// (set) Token: 0x0600B279 RID: 45689 RVA: 0x001133D5 File Offset: 0x001115D5
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

		// Token: 0x17002183 RID: 8579
		// (get) Token: 0x0600B27A RID: 45690 RVA: 0x001133E4 File Offset: 0x001115E4
		// (set) Token: 0x0600B27B RID: 45691 RVA: 0x0011341D File Offset: 0x0011161D
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

		// Token: 0x17002184 RID: 8580
		// (get) Token: 0x0600B27C RID: 45692 RVA: 0x0011342B File Offset: 0x0011162B
		// (set) Token: 0x0600B27D RID: 45693 RVA: 0x0011343F File Offset: 0x0011163F
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

		// Token: 0x17002185 RID: 8581
		// (get) Token: 0x0600B27E RID: 45694 RVA: 0x00113454 File Offset: 0x00111654
		// (set) Token: 0x0600B27F RID: 45695 RVA: 0x0011348D File Offset: 0x0011168D
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

		// Token: 0x17002186 RID: 8582
		// (get) Token: 0x0600B280 RID: 45696 RVA: 0x0011349C File Offset: 0x0011169C
		// (set) Token: 0x0600B281 RID: 45697 RVA: 0x001134D5 File Offset: 0x001116D5
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

		// Token: 0x17002187 RID: 8583
		// (get) Token: 0x0600B282 RID: 45698 RVA: 0x001134E4 File Offset: 0x001116E4
		// (set) Token: 0x0600B283 RID: 45699 RVA: 0x0011351D File Offset: 0x0011171D
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

		// Token: 0x17002188 RID: 8584
		// (get) Token: 0x0600B284 RID: 45700 RVA: 0x0011352C File Offset: 0x0011172C
		// (set) Token: 0x0600B285 RID: 45701 RVA: 0x00113565 File Offset: 0x00111765
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

		// Token: 0x17002189 RID: 8585
		// (get) Token: 0x0600B286 RID: 45702 RVA: 0x00113588 File Offset: 0x00111788
		// (set) Token: 0x0600B287 RID: 45703 RVA: 0x001135C1 File Offset: 0x001117C1
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

		// Token: 0x1700218A RID: 8586
		// (get) Token: 0x0600B288 RID: 45704 RVA: 0x001135D0 File Offset: 0x001117D0
		// (set) Token: 0x0600B289 RID: 45705 RVA: 0x00113609 File Offset: 0x00111809
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

		// Token: 0x1700218B RID: 8587
		// (get) Token: 0x0600B28A RID: 45706 RVA: 0x00113618 File Offset: 0x00111818
		// (set) Token: 0x0600B28B RID: 45707 RVA: 0x00113651 File Offset: 0x00111851
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

		// Token: 0x0600B28C RID: 45708 RVA: 0x00113660 File Offset: 0x00111860
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void SetSubPathString(ref TSoftClassPtr<USharpherealTestSimpleClass> ObjectPtr, string SubPathString)
		{
			UTestClass_UFunction_Direct_UClass.__SetSubPathString_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__SetSubPathString_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__SetSubPathString_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__SetSubPathString_NativeFunctionPtr, (void*)ptr, 1);
			if (ObjectPtr != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->ObjectPtr, ObjectPtr.NativePtr, 1);
			}
			FString.CopyFrom((void*)(&ptr->SubPathString), SubPathString);
			UnrealReflectionUtils.CallUFunction(UTestClass_UFunction_Direct_UClass._ClassDefaultObjectPtr, UTestClass_UFunction_Direct_UClass.__SetSubPathString_NativeFunctionPtr, (void*)ptr);
			if (ObjectPtr != null)
			{
				FSoftObjectPtr.NativeCopy(ObjectPtr.NativePtr, &ptr->ObjectPtr, 1);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__SetSubPathString_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B28D RID: 45709 RVA: 0x001136F8 File Offset: 0x001118F8
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__SetSubClassSet_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__SetSubClassSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B28E RID: 45710 RVA: 0x00113764 File Offset: 0x00111964
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__SetSubClassMap_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__SetSubClassMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B28F RID: 45711 RVA: 0x001137D0 File Offset: 0x001119D0
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__SetSubClassArray_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__SetSubClassArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B290 RID: 45712 RVA: 0x0011383C File Offset: 0x00111A3C
		[SkipLocalsInit]
		public unsafe void SetSubClass([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<USharpherealTestSimpleClass> InSubClass)
		{
			UTestClass_UFunction_Direct_UClass.__SetSubClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__SetSubClass_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__SetSubClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__SetSubClass_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InSubClass = InSubClass;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__SetSubClass_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B291 RID: 45713 RVA: 0x00113884 File Offset: 0x00111A84
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__SetStClassSet_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__SetStClassSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B292 RID: 45714 RVA: 0x001138F0 File Offset: 0x00111AF0
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__SetStClassMap_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__SetStClassMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B293 RID: 45715 RVA: 0x0011395C File Offset: 0x00111B5C
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__SetStClassArray_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__SetStClassArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B294 RID: 45716 RVA: 0x001139C8 File Offset: 0x00111BC8
		[SkipLocalsInit]
		public unsafe void SetStClass(UClassStackOnlyPtr InStClass)
		{
			UTestClass_UFunction_Direct_UClass.__SetStClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__SetStClass_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__SetStClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__SetStClass_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InStClass = InStClass;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__SetStClass_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B295 RID: 45717 RVA: 0x00113A10 File Offset: 0x00111C10
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__SetSoftClassSet_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__SetSoftClassSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B296 RID: 45718 RVA: 0x00113A7C File Offset: 0x00111C7C
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__SetSoftClassMap_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__SetSoftClassMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B297 RID: 45719 RVA: 0x00113AE8 File Offset: 0x00111CE8
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__SetSoftClassArray_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__SetSoftClassArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B298 RID: 45720 RVA: 0x00113B54 File Offset: 0x00111D54
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void SetSoftClass(TSoftClassPtr<USharpherealTestSimpleClass> InSoftClass)
		{
			UTestClass_UFunction_Direct_UClass.__SetSoftClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__SetSoftClass_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__SetSoftClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__SetSoftClass_NativeFunctionPtr, (void*)ptr, 1);
			if (InSoftClass != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->InSoftClass, InSoftClass.NativePtr, 1);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__SetSoftClass_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__SetSoftClass_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B299 RID: 45721 RVA: 0x00113BC0 File Offset: 0x00111DC0
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__SetClassPathSet_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__SetClassPathSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B29A RID: 45722 RVA: 0x00113C2C File Offset: 0x00111E2C
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__SetClassPathMap_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__SetClassPathMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B29B RID: 45723 RVA: 0x00113C98 File Offset: 0x00111E98
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__SetClassPathArray_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__SetClassPathArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B29C RID: 45724 RVA: 0x00113D04 File Offset: 0x00111F04
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetClassPath(FSoftClassPath InClassPath)
		{
			UTestClass_UFunction_Direct_UClass.__SetClassPath_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__SetClassPath_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__SetClassPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__SetClassPath_NativeFunctionPtr, (void*)ptr, 1);
			if (InClassPath != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), &ptr->InClassPath, InClassPath.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__SetClassPath_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__SetClassPath_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B29D RID: 45725 RVA: 0x00113D78 File Offset: 0x00111F78
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__OutSubClassSet_NativeFunctionPtr, (void*)ptr);
			TSet<TSubclassOf<USharpherealTestSimpleClass>> tset2 = OutSubClassSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutSubClassSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__OutSubClassSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B29E RID: 45726 RVA: 0x00113DF0 File Offset: 0x00111FF0
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__OutSubClassMap_NativeFunctionPtr, (void*)ptr);
			TMap<TSubclassOf<USharpherealTestSimpleClass>, int> tmap2 = OutSubClassMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutSubClassMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__OutSubClassMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B29F RID: 45727 RVA: 0x00113E68 File Offset: 0x00112068
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__OutSubClassArray_NativeFunctionPtr, (void*)ptr);
			TArray<TSubclassOf<USharpherealTestSimpleClass>> tarray2 = OutSubClassArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutSubClassArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__OutSubClassArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B2A0 RID: 45728 RVA: 0x00113EE0 File Offset: 0x001120E0
		[SkipLocalsInit]
		public unsafe void OutSubClass([Nullable(new byte[]
		{
			0,
			1
		})] ref TSubclassOf<USharpherealTestSimpleClass> OutSubClass)
		{
			UTestClass_UFunction_Direct_UClass.__OutSubClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__OutSubClass_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__OutSubClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__OutSubClass_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutSubClass = OutSubClass;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__OutSubClass_NativeFunctionPtr, (void*)ptr);
			OutSubClass = ptr->OutSubClass;
		}

		// Token: 0x0600B2A1 RID: 45729 RVA: 0x00113F38 File Offset: 0x00112138
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__OutStClassSet_NativeFunctionPtr, (void*)ptr);
			TSet<UClass> tset2 = OutStClassSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutStClassSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__OutStClassSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B2A2 RID: 45730 RVA: 0x00113FB0 File Offset: 0x001121B0
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__OutStClassMap_NativeFunctionPtr, (void*)ptr);
			TMap<UClass, int> tmap2 = OutStClassMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutStClassMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__OutStClassMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B2A3 RID: 45731 RVA: 0x00114028 File Offset: 0x00112228
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__OutStClassArray_NativeFunctionPtr, (void*)ptr);
			TArray<UClass> tarray2 = OutStClassArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutStClassArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__OutStClassArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B2A4 RID: 45732 RVA: 0x001140A0 File Offset: 0x001122A0
		[SkipLocalsInit]
		public unsafe void OutStClass(ref UClassStackOnlyPtr OutStClass)
		{
			UTestClass_UFunction_Direct_UClass.__OutStClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__OutStClass_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__OutStClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__OutStClass_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutStClass = OutStClass;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__OutStClass_NativeFunctionPtr, (void*)ptr);
			OutStClass = ptr->OutStClass;
		}

		// Token: 0x0600B2A5 RID: 45733 RVA: 0x001140F8 File Offset: 0x001122F8
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__OutSoftClassSet_NativeFunctionPtr, (void*)ptr);
			TSet<TSoftClassPtr<USharpherealTestSimpleClass>> tset2 = OutSoftClassSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutSoftClassSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__OutSoftClassSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B2A6 RID: 45734 RVA: 0x00114170 File Offset: 0x00112370
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__OutSoftClassMap_NativeFunctionPtr, (void*)ptr);
			TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int> tmap2 = OutSoftClassMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutSoftClassMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__OutSoftClassMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B2A7 RID: 45735 RVA: 0x001141E8 File Offset: 0x001123E8
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__OutSoftClassArray_NativeFunctionPtr, (void*)ptr);
			TArray<TSoftClassPtr<USharpherealTestSimpleClass>> tarray2 = OutSoftClassArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutSoftClassArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__OutSoftClassArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B2A8 RID: 45736 RVA: 0x00114260 File Offset: 0x00112460
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void OutSoftClass(ref TSoftClassPtr<USharpherealTestSimpleClass> OutSoftClass)
		{
			UTestClass_UFunction_Direct_UClass.__OutSoftClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__OutSoftClass_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__OutSoftClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__OutSoftClass_NativeFunctionPtr, (void*)ptr, 1);
			if (OutSoftClass != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->OutSoftClass, OutSoftClass.NativePtr, 1);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__OutSoftClass_NativeFunctionPtr, (void*)ptr);
			if (OutSoftClass != null)
			{
				FSoftObjectPtr.NativeCopy(OutSoftClass.NativePtr, &ptr->OutSoftClass, 1);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__OutSoftClass_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B2A9 RID: 45737 RVA: 0x001142EC File Offset: 0x001124EC
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__OutClassPathSet_NativeFunctionPtr, (void*)ptr);
			TSet<FSoftClassPath> tset2 = OutClassPathSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutClassPathSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__OutClassPathSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B2AA RID: 45738 RVA: 0x00114364 File Offset: 0x00112564
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__OutClassPathMap_NativeFunctionPtr, (void*)ptr);
			TMap<FSoftClassPath, int> tmap2 = OutClassPathMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutClassPathMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__OutClassPathMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B2AB RID: 45739 RVA: 0x001143DC File Offset: 0x001125DC
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__OutClassPathArray_NativeFunctionPtr, (void*)ptr);
			TArray<FSoftClassPath> tarray2 = OutClassPathArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutClassPathArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__OutClassPathArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B2AC RID: 45740 RVA: 0x00114454 File Offset: 0x00112654
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutClassPath(ref FSoftClassPath OutClassPath)
		{
			UTestClass_UFunction_Direct_UClass.__OutClassPath_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__OutClassPath_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__OutClassPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__OutClassPath_NativeFunctionPtr, (void*)ptr, 1);
			if (OutClassPath != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), &ptr->OutClassPath, OutClassPath.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__OutClassPath_NativeFunctionPtr, (void*)ptr);
			if (OutClassPath != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), OutClassPath.NativePtr, &ptr->OutClassPath, 1, false);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__OutClassPath_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B2AD RID: 45741 RVA: 0x001144EC File Offset: 0x001126EC
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__InSubClassSet_NativeFunctionPtr, (void*)ptr);
			TSet<TSubclassOf<USharpherealTestSimpleClass>> tset2 = InSubClassSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InSubClassSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__InSubClassSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B2AE RID: 45742 RVA: 0x00114564 File Offset: 0x00112764
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__InSubClassMap_NativeFunctionPtr, (void*)ptr);
			TMap<TSubclassOf<USharpherealTestSimpleClass>, int> tmap2 = InSubClassMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InSubClassMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__InSubClassMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B2AF RID: 45743 RVA: 0x001145DC File Offset: 0x001127DC
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__InSubClassArray_NativeFunctionPtr, (void*)ptr);
			TArray<TSubclassOf<USharpherealTestSimpleClass>> tarray2 = InSubClassArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InSubClassArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__InSubClassArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B2B0 RID: 45744 RVA: 0x00114654 File Offset: 0x00112854
		[SkipLocalsInit]
		public unsafe void InSubClass([Nullable(new byte[]
		{
			0,
			1
		})] in TSubclassOf<USharpherealTestSimpleClass> InSubClass)
		{
			UTestClass_UFunction_Direct_UClass.__InSubClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__InSubClass_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__InSubClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__InSubClass_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InSubClass = InSubClass;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__InSubClass_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B2B1 RID: 45745 RVA: 0x001146A0 File Offset: 0x001128A0
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__InStClassSet_NativeFunctionPtr, (void*)ptr);
			TSet<UClass> tset2 = InStClassSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InStClassSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__InStClassSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B2B2 RID: 45746 RVA: 0x00114718 File Offset: 0x00112918
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__InStClassMap_NativeFunctionPtr, (void*)ptr);
			TMap<UClass, int> tmap2 = InStClassMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InStClassMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__InStClassMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B2B3 RID: 45747 RVA: 0x00114790 File Offset: 0x00112990
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__InStClassArray_NativeFunctionPtr, (void*)ptr);
			TArray<UClass> tarray2 = InStClassArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InStClassArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__InStClassArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B2B4 RID: 45748 RVA: 0x00114808 File Offset: 0x00112A08
		[SkipLocalsInit]
		public unsafe void InStClass(in UClassStackOnlyPtr InStClass)
		{
			UTestClass_UFunction_Direct_UClass.__InStClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__InStClass_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__InStClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__InStClass_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InStClass = InStClass;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__InStClass_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B2B5 RID: 45749 RVA: 0x00114854 File Offset: 0x00112A54
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__InSoftClassSet_NativeFunctionPtr, (void*)ptr);
			TSet<TSoftClassPtr<USharpherealTestSimpleClass>> tset2 = InSoftClassSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InSoftClassSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__InSoftClassSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B2B6 RID: 45750 RVA: 0x001148CC File Offset: 0x00112ACC
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__InSoftClassMap_NativeFunctionPtr, (void*)ptr);
			TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int> tmap2 = InSoftClassMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InSoftClassMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__InSoftClassMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B2B7 RID: 45751 RVA: 0x00114944 File Offset: 0x00112B44
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__InSoftClassArray_NativeFunctionPtr, (void*)ptr);
			TArray<TSoftClassPtr<USharpherealTestSimpleClass>> tarray2 = InSoftClassArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InSoftClassArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__InSoftClassArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B2B8 RID: 45752 RVA: 0x001149BC File Offset: 0x00112BBC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void InSoftClass(in TSoftClassPtr<USharpherealTestSimpleClass> InSoftClass)
		{
			UTestClass_UFunction_Direct_UClass.__InSoftClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__InSoftClass_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__InSoftClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__InSoftClass_NativeFunctionPtr, (void*)ptr, 1);
			if (InSoftClass != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->InSoftClass, InSoftClass.NativePtr, 1);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__InSoftClass_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__InSoftClass_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B2B9 RID: 45753 RVA: 0x00114A2C File Offset: 0x00112C2C
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__InClassPathSet_NativeFunctionPtr, (void*)ptr);
			TSet<FSoftClassPath> tset2 = InClassPathSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InClassPathSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__InClassPathSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B2BA RID: 45754 RVA: 0x00114AA4 File Offset: 0x00112CA4
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__InClassPathMap_NativeFunctionPtr, (void*)ptr);
			TMap<FSoftClassPath, int> tmap2 = InClassPathMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InClassPathMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__InClassPathMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B2BB RID: 45755 RVA: 0x00114B1C File Offset: 0x00112D1C
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__InClassPathArray_NativeFunctionPtr, (void*)ptr);
			TArray<FSoftClassPath> tarray2 = InClassPathArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InClassPathArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__InClassPathArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B2BC RID: 45756 RVA: 0x00114B94 File Offset: 0x00112D94
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InClassPath(in FSoftClassPath InClassPath)
		{
			UTestClass_UFunction_Direct_UClass.__InClassPath_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__InClassPath_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__InClassPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__InClassPath_NativeFunctionPtr, (void*)ptr, 1);
			if (InClassPath != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), &ptr->InClassPath, InClassPath.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__InClassPath_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__InClassPath_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B2BD RID: 45757 RVA: 0x00114C08 File Offset: 0x00112E08
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__GetSubClassSet_NativeFunctionPtr, (void*)ptr);
			TSet<TSubclassOf<USharpherealTestSimpleClass>> result = new TSet<TSubclassOf<USharpherealTestSimpleClass>>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__GetSubClassSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B2BE RID: 45758 RVA: 0x00114C68 File Offset: 0x00112E68
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__GetSubClassMap_NativeFunctionPtr, (void*)ptr);
			TMap<TSubclassOf<USharpherealTestSimpleClass>, int> result = new TMap<TSubclassOf<USharpherealTestSimpleClass>, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__GetSubClassMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B2BF RID: 45759 RVA: 0x00114CC8 File Offset: 0x00112EC8
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__GetSubClassArray_NativeFunctionPtr, (void*)ptr);
			TArray<TSubclassOf<USharpherealTestSimpleClass>> result = new TArray<TSubclassOf<USharpherealTestSimpleClass>>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__GetSubClassArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B2C0 RID: 45760 RVA: 0x00114D28 File Offset: 0x00112F28
		[SkipLocalsInit]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<USharpherealTestSimpleClass> GetSubClass()
		{
			UTestClass_UFunction_Direct_UClass.__GetSubClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__GetSubClass_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__GetSubClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__GetSubClass_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__GetSubClass_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B2C1 RID: 45761 RVA: 0x00114D70 File Offset: 0x00112F70
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSet<UClass> GetStClassSet()
		{
			UTestClass_UFunction_Direct_UClass.__GetStClassSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__GetStClassSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__GetStClassSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__GetStClassSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__GetStClassSet_NativeFunctionPtr, (void*)ptr);
			TSet<UClass> result = new TSet<UClass>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__GetStClassSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B2C2 RID: 45762 RVA: 0x00114DD0 File Offset: 0x00112FD0
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TMap<UClass, int> GetStClassMap()
		{
			UTestClass_UFunction_Direct_UClass.__GetStClassMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__GetStClassMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__GetStClassMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__GetStClassMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__GetStClassMap_NativeFunctionPtr, (void*)ptr);
			TMap<UClass, int> result = new TMap<UClass, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__GetStClassMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B2C3 RID: 45763 RVA: 0x00114E30 File Offset: 0x00113030
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<UClass> GetStClassArray()
		{
			UTestClass_UFunction_Direct_UClass.__GetStClassArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__GetStClassArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__GetStClassArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__GetStClassArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__GetStClassArray_NativeFunctionPtr, (void*)ptr);
			TArray<UClass> result = new TArray<UClass>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__GetStClassArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B2C4 RID: 45764 RVA: 0x00114E90 File Offset: 0x00113090
		[SkipLocalsInit]
		public unsafe UClassStackOnlyPtr GetStClass()
		{
			UTestClass_UFunction_Direct_UClass.__GetStClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__GetStClass_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__GetStClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__GetStClass_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__GetStClass_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B2C5 RID: 45765 RVA: 0x00114ED8 File Offset: 0x001130D8
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSet<TSoftClassPtr<USharpherealTestSimpleClass>> GetSoftClassSet()
		{
			UTestClass_UFunction_Direct_UClass.__GetSoftClassSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__GetSoftClassSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__GetSoftClassSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__GetSoftClassSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__GetSoftClassSet_NativeFunctionPtr, (void*)ptr);
			TSet<TSoftClassPtr<USharpherealTestSimpleClass>> result = new TSet<TSoftClassPtr<USharpherealTestSimpleClass>>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__GetSoftClassSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B2C6 RID: 45766 RVA: 0x00114F38 File Offset: 0x00113138
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int> GetSoftClassMap()
		{
			UTestClass_UFunction_Direct_UClass.__GetSoftClassMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__GetSoftClassMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__GetSoftClassMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__GetSoftClassMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__GetSoftClassMap_NativeFunctionPtr, (void*)ptr);
			TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int> result = new TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__GetSoftClassMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B2C7 RID: 45767 RVA: 0x00114F98 File Offset: 0x00113198
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<TSoftClassPtr<USharpherealTestSimpleClass>> GetSoftClassArray()
		{
			UTestClass_UFunction_Direct_UClass.__GetSoftClassArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__GetSoftClassArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__GetSoftClassArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__GetSoftClassArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__GetSoftClassArray_NativeFunctionPtr, (void*)ptr);
			TArray<TSoftClassPtr<USharpherealTestSimpleClass>> result = new TArray<TSoftClassPtr<USharpherealTestSimpleClass>>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__GetSoftClassArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B2C8 RID: 45768 RVA: 0x00114FF8 File Offset: 0x001131F8
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSoftClassPtr<USharpherealTestSimpleClass> GetSoftClass()
		{
			UTestClass_UFunction_Direct_UClass.__GetSoftClass_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__GetSoftClass_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__GetSoftClass_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__GetSoftClass_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__GetSoftClass_NativeFunctionPtr, (void*)ptr);
			TSoftClassPtr<USharpherealTestSimpleClass> result = new TSoftClassPtr<USharpherealTestSimpleClass>(&ptr->__Result, false, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__GetSoftClass_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B2C9 RID: 45769 RVA: 0x00115058 File Offset: 0x00113258
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSet<FSoftClassPath> GetClassPathSet()
		{
			UTestClass_UFunction_Direct_UClass.__GetClassPathSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__GetClassPathSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__GetClassPathSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__GetClassPathSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__GetClassPathSet_NativeFunctionPtr, (void*)ptr);
			TSet<FSoftClassPath> result = new TSet<FSoftClassPath>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__GetClassPathSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B2CA RID: 45770 RVA: 0x001150B8 File Offset: 0x001132B8
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TMap<FSoftClassPath, int> GetClassPathMap()
		{
			UTestClass_UFunction_Direct_UClass.__GetClassPathMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__GetClassPathMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__GetClassPathMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__GetClassPathMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__GetClassPathMap_NativeFunctionPtr, (void*)ptr);
			TMap<FSoftClassPath, int> result = new TMap<FSoftClassPath, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__GetClassPathMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B2CB RID: 45771 RVA: 0x00115118 File Offset: 0x00113318
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<FSoftClassPath> GetClassPathArray()
		{
			UTestClass_UFunction_Direct_UClass.__GetClassPathArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__GetClassPathArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__GetClassPathArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__GetClassPathArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__GetClassPathArray_NativeFunctionPtr, (void*)ptr);
			TArray<FSoftClassPath> result = new TArray<FSoftClassPath>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__GetClassPathArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B2CC RID: 45772 RVA: 0x00115178 File Offset: 0x00113378
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe FSoftClassPath GetClassPath()
		{
			UTestClass_UFunction_Direct_UClass.__GetClassPath_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_UClass.__GetClassPath_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_Direct_UClass.__GetClassPath_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_UClass.__GetClassPath_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_UClass.__GetClassPath_NativeFunctionPtr, (void*)ptr);
			FSoftClassPath result = new FSoftClassPath(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_UClass.__GetClassPath_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B2CD RID: 45773 RVA: 0x001151D6 File Offset: 0x001133D6
		static UTestClass_UFunction_Direct_UClass()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SharpherealTest.TestClass_UFunction_Direct_UClass");
		}

		// Token: 0x0600B2CE RID: 45774 RVA: 0x001151E4 File Offset: 0x001133E4
		protected UTestClass_UFunction_Direct_UClass(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004F21 RID: 20257
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SharpherealTest.TestClass_UFunction_Direct_UClass";

		// Token: 0x04004F22 RID: 20258
		private static IntPtr _ClassPtr;

		// Token: 0x04004F23 RID: 20259
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004F24 RID: 20260
		internal static int __PropertyOffset_StClass;

		// Token: 0x04004F25 RID: 20261
		internal static int __PropertyOffset_StClassArray;

		// Token: 0x04004F26 RID: 20262
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UClass> _StClassArray;

		// Token: 0x04004F27 RID: 20263
		internal static int __PropertyOffset_StClassSet;

		// Token: 0x04004F28 RID: 20264
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UClass> _StClassSet;

		// Token: 0x04004F29 RID: 20265
		internal static int __PropertyOffset_StClassMap;

		// Token: 0x04004F2A RID: 20266
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<UClass, int> _StClassMap;

		// Token: 0x04004F2B RID: 20267
		internal static int __PropertyOffset_SoftClass;

		// Token: 0x04004F2C RID: 20268
		internal static int __PropertyOffset_SoftClassArray;

		// Token: 0x04004F2D RID: 20269
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TArray<TSoftClassPtr<USharpherealTestSimpleClass>> _SoftClassArray;

		// Token: 0x04004F2E RID: 20270
		internal static int __PropertyOffset_SoftClassSet;

		// Token: 0x04004F2F RID: 20271
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TSet<TSoftClassPtr<USharpherealTestSimpleClass>> _SoftClassSet;

		// Token: 0x04004F30 RID: 20272
		internal static int __PropertyOffset_SoftClassMap;

		// Token: 0x04004F31 RID: 20273
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<TSoftClassPtr<USharpherealTestSimpleClass>, int> _SoftClassMap;

		// Token: 0x04004F32 RID: 20274
		internal static int __PropertyOffset_SubClass;

		// Token: 0x04004F33 RID: 20275
		internal static int __PropertyOffset_SubClassArray;

		// Token: 0x04004F34 RID: 20276
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TSubclassOf<USharpherealTestSimpleClass>> _SubClassArray;

		// Token: 0x04004F35 RID: 20277
		internal static int __PropertyOffset_SubClassSet;

		// Token: 0x04004F36 RID: 20278
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TSet<TSubclassOf<USharpherealTestSimpleClass>> _SubClassSet;

		// Token: 0x04004F37 RID: 20279
		internal static int __PropertyOffset_SubClassMap;

		// Token: 0x04004F38 RID: 20280
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TSubclassOf<USharpherealTestSimpleClass>, int> _SubClassMap;

		// Token: 0x04004F39 RID: 20281
		internal static int __PropertyOffset_ClassPath;

		// Token: 0x04004F3A RID: 20282
		[Nullable(2)]
		private FSoftClassPath _ClassPath;

		// Token: 0x04004F3B RID: 20283
		internal static int __PropertyOffset_ClassPathArray;

		// Token: 0x04004F3C RID: 20284
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoftClassPath> _ClassPathArray;

		// Token: 0x04004F3D RID: 20285
		internal static int __PropertyOffset_ClassPathSet;

		// Token: 0x04004F3E RID: 20286
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<FSoftClassPath> _ClassPathSet;

		// Token: 0x04004F3F RID: 20287
		internal static int __PropertyOffset_ClassPathMap;

		// Token: 0x04004F40 RID: 20288
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FSoftClassPath, int> _ClassPathMap;

		// Token: 0x04004F41 RID: 20289
		private static IntPtr __SetSubPathString_NativeFunctionPtr;

		// Token: 0x04004F42 RID: 20290
		private static IntPtr __SetSubClassSet_NativeFunctionPtr;

		// Token: 0x04004F43 RID: 20291
		private static IntPtr __SetSubClassMap_NativeFunctionPtr;

		// Token: 0x04004F44 RID: 20292
		private static IntPtr __SetSubClassArray_NativeFunctionPtr;

		// Token: 0x04004F45 RID: 20293
		private static IntPtr __SetSubClass_NativeFunctionPtr;

		// Token: 0x04004F46 RID: 20294
		private static IntPtr __SetStClassSet_NativeFunctionPtr;

		// Token: 0x04004F47 RID: 20295
		private static IntPtr __SetStClassMap_NativeFunctionPtr;

		// Token: 0x04004F48 RID: 20296
		private static IntPtr __SetStClassArray_NativeFunctionPtr;

		// Token: 0x04004F49 RID: 20297
		private static IntPtr __SetStClass_NativeFunctionPtr;

		// Token: 0x04004F4A RID: 20298
		private static IntPtr __SetSoftClassSet_NativeFunctionPtr;

		// Token: 0x04004F4B RID: 20299
		private static IntPtr __SetSoftClassMap_NativeFunctionPtr;

		// Token: 0x04004F4C RID: 20300
		private static IntPtr __SetSoftClassArray_NativeFunctionPtr;

		// Token: 0x04004F4D RID: 20301
		private static IntPtr __SetSoftClass_NativeFunctionPtr;

		// Token: 0x04004F4E RID: 20302
		private static IntPtr __SetClassPathSet_NativeFunctionPtr;

		// Token: 0x04004F4F RID: 20303
		private static IntPtr __SetClassPathMap_NativeFunctionPtr;

		// Token: 0x04004F50 RID: 20304
		private static IntPtr __SetClassPathArray_NativeFunctionPtr;

		// Token: 0x04004F51 RID: 20305
		private static IntPtr __SetClassPath_NativeFunctionPtr;

		// Token: 0x04004F52 RID: 20306
		private static IntPtr __OutSubClassSet_NativeFunctionPtr;

		// Token: 0x04004F53 RID: 20307
		private static IntPtr __OutSubClassMap_NativeFunctionPtr;

		// Token: 0x04004F54 RID: 20308
		private static IntPtr __OutSubClassArray_NativeFunctionPtr;

		// Token: 0x04004F55 RID: 20309
		private static IntPtr __OutSubClass_NativeFunctionPtr;

		// Token: 0x04004F56 RID: 20310
		private static IntPtr __OutStClassSet_NativeFunctionPtr;

		// Token: 0x04004F57 RID: 20311
		private static IntPtr __OutStClassMap_NativeFunctionPtr;

		// Token: 0x04004F58 RID: 20312
		private static IntPtr __OutStClassArray_NativeFunctionPtr;

		// Token: 0x04004F59 RID: 20313
		private static IntPtr __OutStClass_NativeFunctionPtr;

		// Token: 0x04004F5A RID: 20314
		private static IntPtr __OutSoftClassSet_NativeFunctionPtr;

		// Token: 0x04004F5B RID: 20315
		private static IntPtr __OutSoftClassMap_NativeFunctionPtr;

		// Token: 0x04004F5C RID: 20316
		private static IntPtr __OutSoftClassArray_NativeFunctionPtr;

		// Token: 0x04004F5D RID: 20317
		private static IntPtr __OutSoftClass_NativeFunctionPtr;

		// Token: 0x04004F5E RID: 20318
		private static IntPtr __OutClassPathSet_NativeFunctionPtr;

		// Token: 0x04004F5F RID: 20319
		private static IntPtr __OutClassPathMap_NativeFunctionPtr;

		// Token: 0x04004F60 RID: 20320
		private static IntPtr __OutClassPathArray_NativeFunctionPtr;

		// Token: 0x04004F61 RID: 20321
		private static IntPtr __OutClassPath_NativeFunctionPtr;

		// Token: 0x04004F62 RID: 20322
		private static IntPtr __InSubClassSet_NativeFunctionPtr;

		// Token: 0x04004F63 RID: 20323
		private static IntPtr __InSubClassMap_NativeFunctionPtr;

		// Token: 0x04004F64 RID: 20324
		private static IntPtr __InSubClassArray_NativeFunctionPtr;

		// Token: 0x04004F65 RID: 20325
		private static IntPtr __InSubClass_NativeFunctionPtr;

		// Token: 0x04004F66 RID: 20326
		private static IntPtr __InStClassSet_NativeFunctionPtr;

		// Token: 0x04004F67 RID: 20327
		private static IntPtr __InStClassMap_NativeFunctionPtr;

		// Token: 0x04004F68 RID: 20328
		private static IntPtr __InStClassArray_NativeFunctionPtr;

		// Token: 0x04004F69 RID: 20329
		private static IntPtr __InStClass_NativeFunctionPtr;

		// Token: 0x04004F6A RID: 20330
		private static IntPtr __InSoftClassSet_NativeFunctionPtr;

		// Token: 0x04004F6B RID: 20331
		private static IntPtr __InSoftClassMap_NativeFunctionPtr;

		// Token: 0x04004F6C RID: 20332
		private static IntPtr __InSoftClassArray_NativeFunctionPtr;

		// Token: 0x04004F6D RID: 20333
		private static IntPtr __InSoftClass_NativeFunctionPtr;

		// Token: 0x04004F6E RID: 20334
		private static IntPtr __InClassPathSet_NativeFunctionPtr;

		// Token: 0x04004F6F RID: 20335
		private static IntPtr __InClassPathMap_NativeFunctionPtr;

		// Token: 0x04004F70 RID: 20336
		private static IntPtr __InClassPathArray_NativeFunctionPtr;

		// Token: 0x04004F71 RID: 20337
		private static IntPtr __InClassPath_NativeFunctionPtr;

		// Token: 0x04004F72 RID: 20338
		private static IntPtr __GetSubClassSet_NativeFunctionPtr;

		// Token: 0x04004F73 RID: 20339
		private static IntPtr __GetSubClassMap_NativeFunctionPtr;

		// Token: 0x04004F74 RID: 20340
		private static IntPtr __GetSubClassArray_NativeFunctionPtr;

		// Token: 0x04004F75 RID: 20341
		private static IntPtr __GetSubClass_NativeFunctionPtr;

		// Token: 0x04004F76 RID: 20342
		private static IntPtr __GetStClassSet_NativeFunctionPtr;

		// Token: 0x04004F77 RID: 20343
		private static IntPtr __GetStClassMap_NativeFunctionPtr;

		// Token: 0x04004F78 RID: 20344
		private static IntPtr __GetStClassArray_NativeFunctionPtr;

		// Token: 0x04004F79 RID: 20345
		private static IntPtr __GetStClass_NativeFunctionPtr;

		// Token: 0x04004F7A RID: 20346
		private static IntPtr __GetSoftClassSet_NativeFunctionPtr;

		// Token: 0x04004F7B RID: 20347
		private static IntPtr __GetSoftClassMap_NativeFunctionPtr;

		// Token: 0x04004F7C RID: 20348
		private static IntPtr __GetSoftClassArray_NativeFunctionPtr;

		// Token: 0x04004F7D RID: 20349
		private static IntPtr __GetSoftClass_NativeFunctionPtr;

		// Token: 0x04004F7E RID: 20350
		private static IntPtr __GetClassPathSet_NativeFunctionPtr;

		// Token: 0x04004F7F RID: 20351
		private static IntPtr __GetClassPathMap_NativeFunctionPtr;

		// Token: 0x04004F80 RID: 20352
		private static IntPtr __GetClassPathArray_NativeFunctionPtr;

		// Token: 0x04004F81 RID: 20353
		private static IntPtr __GetClassPath_NativeFunctionPtr;

		// Token: 0x0200118D RID: 4493
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __SetSubPathString_FunctionParams
		{
			// Token: 0x04006595 RID: 26005
			[FieldOffset(0)]
			public byte ObjectPtr;

			// Token: 0x04006596 RID: 26006
			[FieldOffset(48)]
			public FString SubPathString;
		}

		// Token: 0x0200118E RID: 4494
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetSubClassSet_FunctionParams
		{
			// Token: 0x04006597 RID: 26007
			[FieldOffset(0)]
			public byte InSubClassSet;
		}

		// Token: 0x0200118F RID: 4495
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetSubClassMap_FunctionParams
		{
			// Token: 0x04006598 RID: 26008
			[FieldOffset(0)]
			public byte InSubClassMap;
		}

		// Token: 0x02001190 RID: 4496
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetSubClassArray_FunctionParams
		{
			// Token: 0x04006599 RID: 26009
			[FieldOffset(0)]
			public byte InSubClassArray;
		}

		// Token: 0x02001191 RID: 4497
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetSubClass_FunctionParams
		{
			// Token: 0x0400659A RID: 26010
			[Nullable(new byte[]
			{
				0,
				1
			})]
			[FieldOffset(0)]
			public TSubclassOf<USharpherealTestSimpleClass> InSubClass;
		}

		// Token: 0x02001192 RID: 4498
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetStClassSet_FunctionParams
		{
			// Token: 0x0400659B RID: 26011
			[FieldOffset(0)]
			public byte InStClassSet;
		}

		// Token: 0x02001193 RID: 4499
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetStClassMap_FunctionParams
		{
			// Token: 0x0400659C RID: 26012
			[FieldOffset(0)]
			public byte InStClassMap;
		}

		// Token: 0x02001194 RID: 4500
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetStClassArray_FunctionParams
		{
			// Token: 0x0400659D RID: 26013
			[FieldOffset(0)]
			public byte InStClassArray;
		}

		// Token: 0x02001195 RID: 4501
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetStClass_FunctionParams
		{
			// Token: 0x0400659E RID: 26014
			[FieldOffset(0)]
			public UClassStackOnlyPtr InStClass;
		}

		// Token: 0x02001196 RID: 4502
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetSoftClassSet_FunctionParams
		{
			// Token: 0x0400659F RID: 26015
			[FieldOffset(0)]
			public byte InSoftClassSet;
		}

		// Token: 0x02001197 RID: 4503
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetSoftClassMap_FunctionParams
		{
			// Token: 0x040065A0 RID: 26016
			[FieldOffset(0)]
			public byte InSoftClassMap;
		}

		// Token: 0x02001198 RID: 4504
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetSoftClassArray_FunctionParams
		{
			// Token: 0x040065A1 RID: 26017
			[FieldOffset(0)]
			public byte InSoftClassArray;
		}

		// Token: 0x02001199 RID: 4505
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __SetSoftClass_FunctionParams
		{
			// Token: 0x040065A2 RID: 26018
			[FieldOffset(0)]
			public byte InSoftClass;
		}

		// Token: 0x0200119A RID: 4506
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetClassPathSet_FunctionParams
		{
			// Token: 0x040065A3 RID: 26019
			[FieldOffset(0)]
			public byte InClassPathSet;
		}

		// Token: 0x0200119B RID: 4507
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetClassPathMap_FunctionParams
		{
			// Token: 0x040065A4 RID: 26020
			[FieldOffset(0)]
			public byte InClassPathMap;
		}

		// Token: 0x0200119C RID: 4508
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetClassPathArray_FunctionParams
		{
			// Token: 0x040065A5 RID: 26021
			[FieldOffset(0)]
			public byte InClassPathArray;
		}

		// Token: 0x0200119D RID: 4509
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetClassPath_FunctionParams
		{
			// Token: 0x040065A6 RID: 26022
			[FieldOffset(0)]
			public byte InClassPath;
		}

		// Token: 0x0200119E RID: 4510
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutSubClassSet_FunctionParams
		{
			// Token: 0x040065A7 RID: 26023
			[FieldOffset(0)]
			public byte OutSubClassSet;
		}

		// Token: 0x0200119F RID: 4511
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutSubClassMap_FunctionParams
		{
			// Token: 0x040065A8 RID: 26024
			[FieldOffset(0)]
			public byte OutSubClassMap;
		}

		// Token: 0x020011A0 RID: 4512
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutSubClassArray_FunctionParams
		{
			// Token: 0x040065A9 RID: 26025
			[FieldOffset(0)]
			public byte OutSubClassArray;
		}

		// Token: 0x020011A1 RID: 4513
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OutSubClass_FunctionParams
		{
			// Token: 0x040065AA RID: 26026
			[Nullable(new byte[]
			{
				0,
				1
			})]
			[FieldOffset(0)]
			public TSubclassOf<USharpherealTestSimpleClass> OutSubClass;
		}

		// Token: 0x020011A2 RID: 4514
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutStClassSet_FunctionParams
		{
			// Token: 0x040065AB RID: 26027
			[FieldOffset(0)]
			public byte OutStClassSet;
		}

		// Token: 0x020011A3 RID: 4515
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutStClassMap_FunctionParams
		{
			// Token: 0x040065AC RID: 26028
			[FieldOffset(0)]
			public byte OutStClassMap;
		}

		// Token: 0x020011A4 RID: 4516
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutStClassArray_FunctionParams
		{
			// Token: 0x040065AD RID: 26029
			[FieldOffset(0)]
			public byte OutStClassArray;
		}

		// Token: 0x020011A5 RID: 4517
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OutStClass_FunctionParams
		{
			// Token: 0x040065AE RID: 26030
			[FieldOffset(0)]
			public UClassStackOnlyPtr OutStClass;
		}

		// Token: 0x020011A6 RID: 4518
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutSoftClassSet_FunctionParams
		{
			// Token: 0x040065AF RID: 26031
			[FieldOffset(0)]
			public byte OutSoftClassSet;
		}

		// Token: 0x020011A7 RID: 4519
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutSoftClassMap_FunctionParams
		{
			// Token: 0x040065B0 RID: 26032
			[FieldOffset(0)]
			public byte OutSoftClassMap;
		}

		// Token: 0x020011A8 RID: 4520
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutSoftClassArray_FunctionParams
		{
			// Token: 0x040065B1 RID: 26033
			[FieldOffset(0)]
			public byte OutSoftClassArray;
		}

		// Token: 0x020011A9 RID: 4521
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __OutSoftClass_FunctionParams
		{
			// Token: 0x040065B2 RID: 26034
			[FieldOffset(0)]
			public byte OutSoftClass;
		}

		// Token: 0x020011AA RID: 4522
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutClassPathSet_FunctionParams
		{
			// Token: 0x040065B3 RID: 26035
			[FieldOffset(0)]
			public byte OutClassPathSet;
		}

		// Token: 0x020011AB RID: 4523
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutClassPathMap_FunctionParams
		{
			// Token: 0x040065B4 RID: 26036
			[FieldOffset(0)]
			public byte OutClassPathMap;
		}

		// Token: 0x020011AC RID: 4524
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutClassPathArray_FunctionParams
		{
			// Token: 0x040065B5 RID: 26037
			[FieldOffset(0)]
			public byte OutClassPathArray;
		}

		// Token: 0x020011AD RID: 4525
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __OutClassPath_FunctionParams
		{
			// Token: 0x040065B6 RID: 26038
			[FieldOffset(0)]
			public byte OutClassPath;
		}

		// Token: 0x020011AE RID: 4526
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InSubClassSet_FunctionParams
		{
			// Token: 0x040065B7 RID: 26039
			[FieldOffset(0)]
			public byte InSubClassSet;
		}

		// Token: 0x020011AF RID: 4527
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InSubClassMap_FunctionParams
		{
			// Token: 0x040065B8 RID: 26040
			[FieldOffset(0)]
			public byte InSubClassMap;
		}

		// Token: 0x020011B0 RID: 4528
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InSubClassArray_FunctionParams
		{
			// Token: 0x040065B9 RID: 26041
			[FieldOffset(0)]
			public byte InSubClassArray;
		}

		// Token: 0x020011B1 RID: 4529
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __InSubClass_FunctionParams
		{
			// Token: 0x040065BA RID: 26042
			[Nullable(new byte[]
			{
				0,
				1
			})]
			[FieldOffset(0)]
			public TSubclassOf<USharpherealTestSimpleClass> InSubClass;
		}

		// Token: 0x020011B2 RID: 4530
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InStClassSet_FunctionParams
		{
			// Token: 0x040065BB RID: 26043
			[FieldOffset(0)]
			public byte InStClassSet;
		}

		// Token: 0x020011B3 RID: 4531
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InStClassMap_FunctionParams
		{
			// Token: 0x040065BC RID: 26044
			[FieldOffset(0)]
			public byte InStClassMap;
		}

		// Token: 0x020011B4 RID: 4532
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InStClassArray_FunctionParams
		{
			// Token: 0x040065BD RID: 26045
			[FieldOffset(0)]
			public byte InStClassArray;
		}

		// Token: 0x020011B5 RID: 4533
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __InStClass_FunctionParams
		{
			// Token: 0x040065BE RID: 26046
			[FieldOffset(0)]
			public UClassStackOnlyPtr InStClass;
		}

		// Token: 0x020011B6 RID: 4534
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InSoftClassSet_FunctionParams
		{
			// Token: 0x040065BF RID: 26047
			[FieldOffset(0)]
			public byte InSoftClassSet;
		}

		// Token: 0x020011B7 RID: 4535
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InSoftClassMap_FunctionParams
		{
			// Token: 0x040065C0 RID: 26048
			[FieldOffset(0)]
			public byte InSoftClassMap;
		}

		// Token: 0x020011B8 RID: 4536
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InSoftClassArray_FunctionParams
		{
			// Token: 0x040065C1 RID: 26049
			[FieldOffset(0)]
			public byte InSoftClassArray;
		}

		// Token: 0x020011B9 RID: 4537
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __InSoftClass_FunctionParams
		{
			// Token: 0x040065C2 RID: 26050
			[FieldOffset(0)]
			public byte InSoftClass;
		}

		// Token: 0x020011BA RID: 4538
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InClassPathSet_FunctionParams
		{
			// Token: 0x040065C3 RID: 26051
			[FieldOffset(0)]
			public byte InClassPathSet;
		}

		// Token: 0x020011BB RID: 4539
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InClassPathMap_FunctionParams
		{
			// Token: 0x040065C4 RID: 26052
			[FieldOffset(0)]
			public byte InClassPathMap;
		}

		// Token: 0x020011BC RID: 4540
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InClassPathArray_FunctionParams
		{
			// Token: 0x040065C5 RID: 26053
			[FieldOffset(0)]
			public byte InClassPathArray;
		}

		// Token: 0x020011BD RID: 4541
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InClassPath_FunctionParams
		{
			// Token: 0x040065C6 RID: 26054
			[FieldOffset(0)]
			public byte InClassPath;
		}

		// Token: 0x020011BE RID: 4542
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetSubClassSet_FunctionParams
		{
			// Token: 0x040065C7 RID: 26055
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020011BF RID: 4543
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetSubClassMap_FunctionParams
		{
			// Token: 0x040065C8 RID: 26056
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020011C0 RID: 4544
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSubClassArray_FunctionParams
		{
			// Token: 0x040065C9 RID: 26057
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020011C1 RID: 4545
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetSubClass_FunctionParams
		{
			// Token: 0x040065CA RID: 26058
			[Nullable(new byte[]
			{
				0,
				1
			})]
			[FieldOffset(0)]
			public TSubclassOf<USharpherealTestSimpleClass> __Result;
		}

		// Token: 0x020011C2 RID: 4546
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetStClassSet_FunctionParams
		{
			// Token: 0x040065CB RID: 26059
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020011C3 RID: 4547
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetStClassMap_FunctionParams
		{
			// Token: 0x040065CC RID: 26060
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020011C4 RID: 4548
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetStClassArray_FunctionParams
		{
			// Token: 0x040065CD RID: 26061
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020011C5 RID: 4549
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetStClass_FunctionParams
		{
			// Token: 0x040065CE RID: 26062
			[FieldOffset(0)]
			public UClassStackOnlyPtr __Result;
		}

		// Token: 0x020011C6 RID: 4550
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetSoftClassSet_FunctionParams
		{
			// Token: 0x040065CF RID: 26063
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020011C7 RID: 4551
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetSoftClassMap_FunctionParams
		{
			// Token: 0x040065D0 RID: 26064
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020011C8 RID: 4552
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSoftClassArray_FunctionParams
		{
			// Token: 0x040065D1 RID: 26065
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020011C9 RID: 4553
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __GetSoftClass_FunctionParams
		{
			// Token: 0x040065D2 RID: 26066
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020011CA RID: 4554
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetClassPathSet_FunctionParams
		{
			// Token: 0x040065D3 RID: 26067
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020011CB RID: 4555
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetClassPathMap_FunctionParams
		{
			// Token: 0x040065D4 RID: 26068
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020011CC RID: 4556
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetClassPathArray_FunctionParams
		{
			// Token: 0x040065D5 RID: 26069
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020011CD RID: 4557
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetClassPath_FunctionParams
		{
			// Token: 0x040065D6 RID: 26070
			[FieldOffset(0)]
			public byte __Result;
		}
	}
}
