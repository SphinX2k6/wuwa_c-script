using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002751 RID: 10065
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SharpherealTest.TestClass_UFunction_String")]
	[UnrealStructLayout(472, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class UTestClass_UFunction_String : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602590F RID: 153871 RVA: 0x0038AD90 File Offset: 0x00388F90
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTestClass_UFunction_String._ClassPtr;
		}

		// Token: 0x06025910 RID: 153872 RVA: 0x0038AD9C File Offset: 0x00388F9C
		public UTestClass_UFunction_String() : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_String.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025911 RID: 153873 RVA: 0x0038ADC4 File Offset: 0x00388FC4
		public UTestClass_UFunction_String(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_String.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170090D8 RID: 37080
		// (get) Token: 0x06025912 RID: 153874 RVA: 0x0038ADF7 File Offset: 0x00388FF7
		// (set) Token: 0x06025913 RID: 153875 RVA: 0x0038AE0B File Offset: 0x0038900B
		public unsafe string String
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UTestClass_UFunction_String.__PropertyOffset_String)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UTestClass_UFunction_String.__PropertyOffset_String)), value);
			}
		}

		// Token: 0x170090D9 RID: 37081
		// (get) Token: 0x06025914 RID: 153876 RVA: 0x0038AE20 File Offset: 0x00389020
		// (set) Token: 0x06025915 RID: 153877 RVA: 0x0038AE59 File Offset: 0x00389059
		public TArray<string> StringArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._StringArray) == null)
				{
					result = (this._StringArray = new TArray<string>(base.NativePtr + (IntPtr)UTestClass_UFunction_String.__PropertyOffset_StringArray, this));
				}
				return result;
			}
			set
			{
				this.StringArray.CopyAssign(value);
			}
		}

		// Token: 0x170090DA RID: 37082
		// (get) Token: 0x06025916 RID: 153878 RVA: 0x0038AE68 File Offset: 0x00389068
		// (set) Token: 0x06025917 RID: 153879 RVA: 0x0038AEA1 File Offset: 0x003890A1
		public TSet<string> StringSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<string> result;
				if ((result = this._StringSet) == null)
				{
					result = (this._StringSet = new TSet<string>(base.NativePtr + (IntPtr)UTestClass_UFunction_String.__PropertyOffset_StringSet, this));
				}
				return result;
			}
			set
			{
				this.StringSet.CopyAssign(value);
			}
		}

		// Token: 0x170090DB RID: 37083
		// (get) Token: 0x06025918 RID: 153880 RVA: 0x0038AEB0 File Offset: 0x003890B0
		// (set) Token: 0x06025919 RID: 153881 RVA: 0x0038AEE9 File Offset: 0x003890E9
		public TMap<string, int> StringMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, int> result;
				if ((result = this._StringMap) == null)
				{
					result = (this._StringMap = new TMap<string, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_String.__PropertyOffset_StringMap, this));
				}
				return result;
			}
			set
			{
				this.StringMap.CopyAssign(value);
			}
		}

		// Token: 0x170090DC RID: 37084
		// (get) Token: 0x0602591A RID: 153882 RVA: 0x0038AEF7 File Offset: 0x003890F7
		// (set) Token: 0x0602591B RID: 153883 RVA: 0x0038AF0B File Offset: 0x0038910B
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_String.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_String.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x170090DD RID: 37085
		// (get) Token: 0x0602591C RID: 153884 RVA: 0x0038AF20 File Offset: 0x00389120
		// (set) Token: 0x0602591D RID: 153885 RVA: 0x0038AF59 File Offset: 0x00389159
		public TArray<FName> NameArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._NameArray) == null)
				{
					result = (this._NameArray = new TArray<FName>(base.NativePtr + (IntPtr)UTestClass_UFunction_String.__PropertyOffset_NameArray, this));
				}
				return result;
			}
			set
			{
				this.NameArray.CopyAssign(value);
			}
		}

		// Token: 0x170090DE RID: 37086
		// (get) Token: 0x0602591E RID: 153886 RVA: 0x0038AF68 File Offset: 0x00389168
		// (set) Token: 0x0602591F RID: 153887 RVA: 0x0038AFA1 File Offset: 0x003891A1
		public TSet<FName> NameSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<FName> result;
				if ((result = this._NameSet) == null)
				{
					result = (this._NameSet = new TSet<FName>(base.NativePtr + (IntPtr)UTestClass_UFunction_String.__PropertyOffset_NameSet, this));
				}
				return result;
			}
			set
			{
				this.NameSet.CopyAssign(value);
			}
		}

		// Token: 0x170090DF RID: 37087
		// (get) Token: 0x06025920 RID: 153888 RVA: 0x0038AFB0 File Offset: 0x003891B0
		// (set) Token: 0x06025921 RID: 153889 RVA: 0x0038AFE9 File Offset: 0x003891E9
		public TMap<FName, int> NameMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, int> result;
				if ((result = this._NameMap) == null)
				{
					result = (this._NameMap = new TMap<FName, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_String.__PropertyOffset_NameMap, this));
				}
				return result;
			}
			set
			{
				this.NameMap.CopyAssign(value);
			}
		}

		// Token: 0x170090E0 RID: 37088
		// (get) Token: 0x06025922 RID: 153890 RVA: 0x0038AFF8 File Offset: 0x003891F8
		// (set) Token: 0x06025923 RID: 153891 RVA: 0x0038B031 File Offset: 0x00389231
		public unsafe FText Text
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._Text) == null)
				{
					result = (this._Text = new FText(base.NativePtr + (IntPtr)UTestClass_UFunction_String.__PropertyOffset_Text, this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)UTestClass_UFunction_String.__PropertyOffset_Text)), value.NativePtr, 1);
			}
		}

		// Token: 0x170090E1 RID: 37089
		// (get) Token: 0x06025924 RID: 153892 RVA: 0x0038B04C File Offset: 0x0038924C
		// (set) Token: 0x06025925 RID: 153893 RVA: 0x0038B085 File Offset: 0x00389285
		public TArray<FText> TextArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FText> result;
				if ((result = this._TextArray) == null)
				{
					result = (this._TextArray = new TArray<FText>(base.NativePtr + (IntPtr)UTestClass_UFunction_String.__PropertyOffset_TextArray, this));
				}
				return result;
			}
			set
			{
				this.TextArray.CopyAssign(value);
			}
		}

		// Token: 0x06025926 RID: 153894 RVA: 0x0038B094 File Offset: 0x00389294
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetTextArray([Nullable(new byte[]
		{
			2,
			1
		})] TArray<FText> InTextArray)
		{
			UTestClass_UFunction_String.__SetTextArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__SetTextArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_String.__SetTextArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__SetTextArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InTextArray != null)
			{
				InTextArray.CopyTo(&ptr->InTextArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__SetTextArray_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__SetTextArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025927 RID: 153895 RVA: 0x0038B100 File Offset: 0x00389300
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetText(FText InText)
		{
			UTestClass_UFunction_String.__SetText_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__SetText_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UTestClass_UFunction_String.__SetText_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__SetText_NativeFunctionPtr, (void*)ptr, 1);
			FText.NativeCopy((void*)(&ptr->InText), InText.NativePtr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__SetText_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__SetText_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025928 RID: 153896 RVA: 0x0038B164 File Offset: 0x00389364
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetStringSet([Nullable(new byte[]
		{
			2,
			1
		})] TSet<string> InStringSet)
		{
			UTestClass_UFunction_String.__SetStringSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__SetStringSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_String.__SetStringSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__SetStringSet_NativeFunctionPtr, (void*)ptr, 1);
			if (InStringSet != null)
			{
				InStringSet.CopyTo(&ptr->InStringSet, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__SetStringSet_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__SetStringSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025929 RID: 153897 RVA: 0x0038B1D0 File Offset: 0x003893D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetStringMap([Nullable(new byte[]
		{
			2,
			1
		})] TMap<string, int> InStringMap)
		{
			UTestClass_UFunction_String.__SetStringMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__SetStringMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_String.__SetStringMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__SetStringMap_NativeFunctionPtr, (void*)ptr, 1);
			if (InStringMap != null)
			{
				InStringMap.CopyTo(&ptr->InStringMap, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__SetStringMap_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__SetStringMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602592A RID: 153898 RVA: 0x0038B23C File Offset: 0x0038943C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetStringArray([Nullable(new byte[]
		{
			2,
			1
		})] TArray<string> InStringArray)
		{
			UTestClass_UFunction_String.__SetStringArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__SetStringArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_String.__SetStringArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__SetStringArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InStringArray != null)
			{
				InStringArray.CopyTo(&ptr->InStringArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__SetStringArray_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__SetStringArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602592B RID: 153899 RVA: 0x0038B2A8 File Offset: 0x003894A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetString(string InString)
		{
			UTestClass_UFunction_String.__SetString_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__SetString_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_String.__SetString_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__SetString_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->InString), InString);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__SetString_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__SetString_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602592C RID: 153900 RVA: 0x0038B308 File Offset: 0x00389508
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetNameSet(TSet<FName> InNameSet)
		{
			UTestClass_UFunction_String.__SetNameSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__SetNameSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_String.__SetNameSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__SetNameSet_NativeFunctionPtr, (void*)ptr, 1);
			if (InNameSet != null)
			{
				InNameSet.CopyTo(&ptr->InNameSet, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__SetNameSet_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__SetNameSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602592D RID: 153901 RVA: 0x0038B374 File Offset: 0x00389574
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetNameMap(TMap<FName, int> InNameMap)
		{
			UTestClass_UFunction_String.__SetNameMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__SetNameMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_String.__SetNameMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__SetNameMap_NativeFunctionPtr, (void*)ptr, 1);
			if (InNameMap != null)
			{
				InNameMap.CopyTo(&ptr->InNameMap, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__SetNameMap_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__SetNameMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602592E RID: 153902 RVA: 0x0038B3E0 File Offset: 0x003895E0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetNameArray(TArray<FName> InNameArray)
		{
			UTestClass_UFunction_String.__SetNameArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__SetNameArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_String.__SetNameArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__SetNameArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InNameArray != null)
			{
				InNameArray.CopyTo(&ptr->InNameArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__SetNameArray_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__SetNameArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602592F RID: 153903 RVA: 0x0038B44C File Offset: 0x0038964C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetName(FName InName)
		{
			UTestClass_UFunction_String.__SetName_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__SetName_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UTestClass_UFunction_String.__SetName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__SetName_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InName = InName;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__SetName_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025930 RID: 153904 RVA: 0x0038B494 File Offset: 0x00389694
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutTextArray([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FText> OutTextArray)
		{
			UTestClass_UFunction_String.__OutTextArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__OutTextArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_String.__OutTextArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__OutTextArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FText> tarray = OutTextArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutTextArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__OutTextArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FText> tarray2 = OutTextArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutTextArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__OutTextArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025931 RID: 153905 RVA: 0x0038B510 File Offset: 0x00389710
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutText(ref FText OutText)
		{
			UTestClass_UFunction_String.__OutText_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__OutText_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UTestClass_UFunction_String.__OutText_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__OutText_NativeFunctionPtr, (void*)ptr, 1);
			FText.NativeMove((void*)(&ptr->OutText), OutText.NativePtr);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__OutText_NativeFunctionPtr, (void*)ptr, 0);
			FText.NativeMove(OutText.NativePtr, (void*)(&ptr->OutText));
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__OutText_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025932 RID: 153906 RVA: 0x0038B588 File Offset: 0x00389788
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutStringSet([Nullable(new byte[]
		{
			2,
			1
		})] ref TSet<string> OutStringSet)
		{
			UTestClass_UFunction_String.__OutStringSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__OutStringSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_String.__OutStringSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__OutStringSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<string> tset = OutStringSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutStringSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__OutStringSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<string> tset2 = OutStringSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutStringSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__OutStringSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025933 RID: 153907 RVA: 0x0038B604 File Offset: 0x00389804
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutStringMap([Nullable(new byte[]
		{
			2,
			1
		})] ref TMap<string, int> OutStringMap)
		{
			UTestClass_UFunction_String.__OutStringMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__OutStringMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_String.__OutStringMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__OutStringMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<string, int> tmap = OutStringMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutStringMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__OutStringMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<string, int> tmap2 = OutStringMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutStringMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__OutStringMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025934 RID: 153908 RVA: 0x0038B680 File Offset: 0x00389880
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutStringArray([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<string> OutStringArray)
		{
			UTestClass_UFunction_String.__OutStringArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__OutStringArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_String.__OutStringArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__OutStringArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<string> tarray = OutStringArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutStringArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__OutStringArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<string> tarray2 = OutStringArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutStringArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__OutStringArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025935 RID: 153909 RVA: 0x0038B6FC File Offset: 0x003898FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutString(ref string OutString)
		{
			UTestClass_UFunction_String.__OutString_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__OutString_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_String.__OutString_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__OutString_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->OutString), OutString);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__OutString_NativeFunctionPtr, (void*)ptr, 0);
			OutString = FString.ToString((void*)(&ptr->OutString));
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__OutString_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025936 RID: 153910 RVA: 0x0038B76C File Offset: 0x0038996C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutNameSet(ref TSet<FName> OutNameSet)
		{
			UTestClass_UFunction_String.__OutNameSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__OutNameSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_String.__OutNameSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__OutNameSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<FName> tset = OutNameSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutNameSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__OutNameSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<FName> tset2 = OutNameSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutNameSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__OutNameSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025937 RID: 153911 RVA: 0x0038B7E8 File Offset: 0x003899E8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutNameMap(ref TMap<FName, int> OutNameMap)
		{
			UTestClass_UFunction_String.__OutNameMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__OutNameMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_String.__OutNameMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__OutNameMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, int> tmap = OutNameMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutNameMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__OutNameMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FName, int> tmap2 = OutNameMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutNameMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__OutNameMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025938 RID: 153912 RVA: 0x0038B864 File Offset: 0x00389A64
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutNameArray(ref TArray<FName> OutNameArray)
		{
			UTestClass_UFunction_String.__OutNameArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__OutNameArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_String.__OutNameArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__OutNameArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FName> tarray = OutNameArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutNameArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__OutNameArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FName> tarray2 = OutNameArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutNameArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__OutNameArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025939 RID: 153913 RVA: 0x0038B8E0 File Offset: 0x00389AE0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutName(ref FName OutName)
		{
			UTestClass_UFunction_String.__OutName_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__OutName_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UTestClass_UFunction_String.__OutName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__OutName_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutName = OutName;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__OutName_NativeFunctionPtr, (void*)ptr, 0);
			OutName = ptr->OutName;
		}

		// Token: 0x0602593A RID: 153914 RVA: 0x0038B938 File Offset: 0x00389B38
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InTextArray([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FText> InTextArray)
		{
			UTestClass_UFunction_String.__InTextArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__InTextArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_String.__InTextArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__InTextArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FText> tarray = InTextArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InTextArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__InTextArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FText> tarray2 = InTextArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InTextArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__InTextArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602593B RID: 153915 RVA: 0x0038B9B4 File Offset: 0x00389BB4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InText(in FText InText)
		{
			UTestClass_UFunction_String.__InText_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__InText_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UTestClass_UFunction_String.__InText_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__InText_NativeFunctionPtr, (void*)ptr, 1);
			FText.NativeMove((void*)(&ptr->InText), InText.NativePtr);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__InText_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__InText_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602593C RID: 153916 RVA: 0x0038BA18 File Offset: 0x00389C18
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InStringSet([Nullable(new byte[]
		{
			2,
			1
		})] in TSet<string> InStringSet)
		{
			UTestClass_UFunction_String.__InStringSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__InStringSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_String.__InStringSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__InStringSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<string> tset = InStringSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InStringSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__InStringSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<string> tset2 = InStringSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InStringSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__InStringSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602593D RID: 153917 RVA: 0x0038BA94 File Offset: 0x00389C94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InStringMap([Nullable(new byte[]
		{
			2,
			1
		})] in TMap<string, int> InStringMap)
		{
			UTestClass_UFunction_String.__InStringMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__InStringMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_String.__InStringMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__InStringMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<string, int> tmap = InStringMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InStringMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__InStringMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<string, int> tmap2 = InStringMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InStringMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__InStringMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602593E RID: 153918 RVA: 0x0038BB10 File Offset: 0x00389D10
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InStringArray([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> InStringArray)
		{
			UTestClass_UFunction_String.__InStringArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__InStringArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_String.__InStringArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__InStringArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<string> tarray = InStringArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InStringArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__InStringArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<string> tarray2 = InStringArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InStringArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__InStringArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602593F RID: 153919 RVA: 0x0038BB8C File Offset: 0x00389D8C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InString(in string InString)
		{
			UTestClass_UFunction_String.__InString_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__InString_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_String.__InString_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__InString_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->InString), InString);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__InString_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__InString_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025940 RID: 153920 RVA: 0x0038BBEC File Offset: 0x00389DEC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InNameSet(in TSet<FName> InNameSet)
		{
			UTestClass_UFunction_String.__InNameSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__InNameSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_String.__InNameSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__InNameSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<FName> tset = InNameSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InNameSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__InNameSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<FName> tset2 = InNameSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InNameSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__InNameSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025941 RID: 153921 RVA: 0x0038BC68 File Offset: 0x00389E68
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InNameMap(in TMap<FName, int> InNameMap)
		{
			UTestClass_UFunction_String.__InNameMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__InNameMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_String.__InNameMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__InNameMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, int> tmap = InNameMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InNameMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__InNameMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FName, int> tmap2 = InNameMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InNameMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__InNameMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025942 RID: 153922 RVA: 0x0038BCE4 File Offset: 0x00389EE4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InNameArray(in TArray<FName> InNameArray)
		{
			UTestClass_UFunction_String.__InNameArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__InNameArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_String.__InNameArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__InNameArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FName> tarray = InNameArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InNameArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__InNameArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FName> tarray2 = InNameArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InNameArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__InNameArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025943 RID: 153923 RVA: 0x0038BD60 File Offset: 0x00389F60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InName(in FName InName)
		{
			UTestClass_UFunction_String.__InName_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__InName_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UTestClass_UFunction_String.__InName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__InName_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InName = InName;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__InName_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025944 RID: 153924 RVA: 0x0038BDAC File Offset: 0x00389FAC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<FText> GetTextArray()
		{
			UTestClass_UFunction_String.__GetTextArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__GetTextArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_String.__GetTextArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__GetTextArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__GetTextArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FText> result = new TArray<FText>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__GetTextArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025945 RID: 153925 RVA: 0x0038BE0C File Offset: 0x0038A00C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FText GetText()
		{
			UTestClass_UFunction_String.__GetText_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__GetText_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UTestClass_UFunction_String.__GetText_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__GetText_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__GetText_NativeFunctionPtr, (void*)ptr, 0);
			FText result = new FText(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__GetText_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025946 RID: 153926 RVA: 0x0038BE6C File Offset: 0x0038A06C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<string> GetStringSet()
		{
			UTestClass_UFunction_String.__GetStringSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__GetStringSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_String.__GetStringSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__GetStringSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__GetStringSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<string> result = new TSet<string>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__GetStringSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025947 RID: 153927 RVA: 0x0038BECC File Offset: 0x0038A0CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<string, int> GetStringMap()
		{
			UTestClass_UFunction_String.__GetStringMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__GetStringMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_String.__GetStringMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__GetStringMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__GetStringMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<string, int> result = new TMap<string, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__GetStringMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025948 RID: 153928 RVA: 0x0038BF2C File Offset: 0x0038A12C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<string> GetStringArray()
		{
			UTestClass_UFunction_String.__GetStringArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__GetStringArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_String.__GetStringArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__GetStringArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__GetStringArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<string> result = new TArray<string>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__GetStringArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025949 RID: 153929 RVA: 0x0038BF8C File Offset: 0x0038A18C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe string GetString()
		{
			UTestClass_UFunction_String.__GetString_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__GetString_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_String.__GetString_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__GetString_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__GetString_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__GetString_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602594A RID: 153930 RVA: 0x0038BFEC File Offset: 0x0038A1EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<FName> GetNameSet()
		{
			UTestClass_UFunction_String.__GetNameSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__GetNameSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_String.__GetNameSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__GetNameSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__GetNameSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<FName> result = new TSet<FName>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__GetNameSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602594B RID: 153931 RVA: 0x0038C04C File Offset: 0x0038A24C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<FName, int> GetNameMap()
		{
			UTestClass_UFunction_String.__GetNameMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__GetNameMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_String.__GetNameMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__GetNameMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__GetNameMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FName, int> result = new TMap<FName, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__GetNameMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602594C RID: 153932 RVA: 0x0038C0AC File Offset: 0x0038A2AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<FName> GetNameArray()
		{
			UTestClass_UFunction_String.__GetNameArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__GetNameArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_String.__GetNameArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__GetNameArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__GetNameArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FName> result = new TArray<FName>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__GetNameArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602594D RID: 153933 RVA: 0x0038C10C File Offset: 0x0038A30C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public new unsafe FName GetName()
		{
			UTestClass_UFunction_String.__GetName_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__GetName_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UTestClass_UFunction_String.__GetName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__GetName_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__GetName_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602594E RID: 153934 RVA: 0x0038C152 File Offset: 0x0038A352
		static UTestClass_UFunction_String()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SharpherealTest.TestClass_UFunction_String");
		}

		// Token: 0x0602594F RID: 153935 RVA: 0x0038C160 File Offset: 0x0038A360
		protected UTestClass_UFunction_String(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014622 RID: 83490
		public new const string __ObjectPath = "/Script/SharpherealTest.TestClass_UFunction_String";

		// Token: 0x04014623 RID: 83491
		private static IntPtr _ClassPtr;

		// Token: 0x04014624 RID: 83492
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014625 RID: 83493
		internal static int __PropertyOffset_String;

		// Token: 0x04014626 RID: 83494
		internal static int __PropertyOffset_StringArray;

		// Token: 0x04014627 RID: 83495
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _StringArray;

		// Token: 0x04014628 RID: 83496
		internal static int __PropertyOffset_StringSet;

		// Token: 0x04014629 RID: 83497
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<string> _StringSet;

		// Token: 0x0401462A RID: 83498
		internal static int __PropertyOffset_StringMap;

		// Token: 0x0401462B RID: 83499
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, int> _StringMap;

		// Token: 0x0401462C RID: 83500
		internal static int __PropertyOffset_Name;

		// Token: 0x0401462D RID: 83501
		internal static int __PropertyOffset_NameArray;

		// Token: 0x0401462E RID: 83502
		[Nullable(2)]
		private TArray<FName> _NameArray;

		// Token: 0x0401462F RID: 83503
		internal static int __PropertyOffset_NameSet;

		// Token: 0x04014630 RID: 83504
		[Nullable(2)]
		private TSet<FName> _NameSet;

		// Token: 0x04014631 RID: 83505
		internal static int __PropertyOffset_NameMap;

		// Token: 0x04014632 RID: 83506
		[Nullable(2)]
		private TMap<FName, int> _NameMap;

		// Token: 0x04014633 RID: 83507
		internal static int __PropertyOffset_Text;

		// Token: 0x04014634 RID: 83508
		[Nullable(2)]
		private FText _Text;

		// Token: 0x04014635 RID: 83509
		internal static int __PropertyOffset_TextArray;

		// Token: 0x04014636 RID: 83510
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FText> _TextArray;

		// Token: 0x04014637 RID: 83511
		private static IntPtr __SetTextArray_NativeFunctionPtr;

		// Token: 0x04014638 RID: 83512
		private static IntPtr __SetText_NativeFunctionPtr;

		// Token: 0x04014639 RID: 83513
		private static IntPtr __SetStringSet_NativeFunctionPtr;

		// Token: 0x0401463A RID: 83514
		private static IntPtr __SetStringMap_NativeFunctionPtr;

		// Token: 0x0401463B RID: 83515
		private static IntPtr __SetStringArray_NativeFunctionPtr;

		// Token: 0x0401463C RID: 83516
		private static IntPtr __SetString_NativeFunctionPtr;

		// Token: 0x0401463D RID: 83517
		private static IntPtr __SetNameSet_NativeFunctionPtr;

		// Token: 0x0401463E RID: 83518
		private static IntPtr __SetNameMap_NativeFunctionPtr;

		// Token: 0x0401463F RID: 83519
		private static IntPtr __SetNameArray_NativeFunctionPtr;

		// Token: 0x04014640 RID: 83520
		private static IntPtr __SetName_NativeFunctionPtr;

		// Token: 0x04014641 RID: 83521
		private static IntPtr __OutTextArray_NativeFunctionPtr;

		// Token: 0x04014642 RID: 83522
		private static IntPtr __OutText_NativeFunctionPtr;

		// Token: 0x04014643 RID: 83523
		private static IntPtr __OutStringSet_NativeFunctionPtr;

		// Token: 0x04014644 RID: 83524
		private static IntPtr __OutStringMap_NativeFunctionPtr;

		// Token: 0x04014645 RID: 83525
		private static IntPtr __OutStringArray_NativeFunctionPtr;

		// Token: 0x04014646 RID: 83526
		private static IntPtr __OutString_NativeFunctionPtr;

		// Token: 0x04014647 RID: 83527
		private static IntPtr __OutNameSet_NativeFunctionPtr;

		// Token: 0x04014648 RID: 83528
		private static IntPtr __OutNameMap_NativeFunctionPtr;

		// Token: 0x04014649 RID: 83529
		private static IntPtr __OutNameArray_NativeFunctionPtr;

		// Token: 0x0401464A RID: 83530
		private static IntPtr __OutName_NativeFunctionPtr;

		// Token: 0x0401464B RID: 83531
		private static IntPtr __InTextArray_NativeFunctionPtr;

		// Token: 0x0401464C RID: 83532
		private static IntPtr __InText_NativeFunctionPtr;

		// Token: 0x0401464D RID: 83533
		private static IntPtr __InStringSet_NativeFunctionPtr;

		// Token: 0x0401464E RID: 83534
		private static IntPtr __InStringMap_NativeFunctionPtr;

		// Token: 0x0401464F RID: 83535
		private static IntPtr __InStringArray_NativeFunctionPtr;

		// Token: 0x04014650 RID: 83536
		private static IntPtr __InString_NativeFunctionPtr;

		// Token: 0x04014651 RID: 83537
		private static IntPtr __InNameSet_NativeFunctionPtr;

		// Token: 0x04014652 RID: 83538
		private static IntPtr __InNameMap_NativeFunctionPtr;

		// Token: 0x04014653 RID: 83539
		private static IntPtr __InNameArray_NativeFunctionPtr;

		// Token: 0x04014654 RID: 83540
		private static IntPtr __InName_NativeFunctionPtr;

		// Token: 0x04014655 RID: 83541
		private static IntPtr __GetTextArray_NativeFunctionPtr;

		// Token: 0x04014656 RID: 83542
		private static IntPtr __GetText_NativeFunctionPtr;

		// Token: 0x04014657 RID: 83543
		private static IntPtr __GetStringSet_NativeFunctionPtr;

		// Token: 0x04014658 RID: 83544
		private static IntPtr __GetStringMap_NativeFunctionPtr;

		// Token: 0x04014659 RID: 83545
		private static IntPtr __GetStringArray_NativeFunctionPtr;

		// Token: 0x0401465A RID: 83546
		private static IntPtr __GetString_NativeFunctionPtr;

		// Token: 0x0401465B RID: 83547
		private static IntPtr __GetNameSet_NativeFunctionPtr;

		// Token: 0x0401465C RID: 83548
		private static IntPtr __GetNameMap_NativeFunctionPtr;

		// Token: 0x0401465D RID: 83549
		private static IntPtr __GetNameArray_NativeFunctionPtr;

		// Token: 0x0401465E RID: 83550
		private static IntPtr __GetName_NativeFunctionPtr;

		// Token: 0x0200399D RID: 14749
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetTextArray_FunctionParams
		{
			// Token: 0x04017AC6 RID: 96966
			[FieldOffset(0)]
			public byte InTextArray;
		}

		// Token: 0x0200399E RID: 14750
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SetText_FunctionParams
		{
			// Token: 0x04017AC7 RID: 96967
			[FieldOffset(0)]
			public byte InText;
		}

		// Token: 0x0200399F RID: 14751
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetStringSet_FunctionParams
		{
			// Token: 0x04017AC8 RID: 96968
			[FieldOffset(0)]
			public byte InStringSet;
		}

		// Token: 0x020039A0 RID: 14752
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetStringMap_FunctionParams
		{
			// Token: 0x04017AC9 RID: 96969
			[FieldOffset(0)]
			public byte InStringMap;
		}

		// Token: 0x020039A1 RID: 14753
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetStringArray_FunctionParams
		{
			// Token: 0x04017ACA RID: 96970
			[FieldOffset(0)]
			public byte InStringArray;
		}

		// Token: 0x020039A2 RID: 14754
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetString_FunctionParams
		{
			// Token: 0x04017ACB RID: 96971
			[FieldOffset(0)]
			public FString InString;
		}

		// Token: 0x020039A3 RID: 14755
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetNameSet_FunctionParams
		{
			// Token: 0x04017ACC RID: 96972
			[FieldOffset(0)]
			public byte InNameSet;
		}

		// Token: 0x020039A4 RID: 14756
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetNameMap_FunctionParams
		{
			// Token: 0x04017ACD RID: 96973
			[FieldOffset(0)]
			public byte InNameMap;
		}

		// Token: 0x020039A5 RID: 14757
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetNameArray_FunctionParams
		{
			// Token: 0x04017ACE RID: 96974
			[FieldOffset(0)]
			public byte InNameArray;
		}

		// Token: 0x020039A6 RID: 14758
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __SetName_FunctionParams
		{
			// Token: 0x04017ACF RID: 96975
			[FieldOffset(0)]
			public FName InName;
		}

		// Token: 0x020039A7 RID: 14759
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutTextArray_FunctionParams
		{
			// Token: 0x04017AD0 RID: 96976
			[FieldOffset(0)]
			public byte OutTextArray;
		}

		// Token: 0x020039A8 RID: 14760
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __OutText_FunctionParams
		{
			// Token: 0x04017AD1 RID: 96977
			[FieldOffset(0)]
			public byte OutText;
		}

		// Token: 0x020039A9 RID: 14761
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutStringSet_FunctionParams
		{
			// Token: 0x04017AD2 RID: 96978
			[FieldOffset(0)]
			public byte OutStringSet;
		}

		// Token: 0x020039AA RID: 14762
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutStringMap_FunctionParams
		{
			// Token: 0x04017AD3 RID: 96979
			[FieldOffset(0)]
			public byte OutStringMap;
		}

		// Token: 0x020039AB RID: 14763
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutStringArray_FunctionParams
		{
			// Token: 0x04017AD4 RID: 96980
			[FieldOffset(0)]
			public byte OutStringArray;
		}

		// Token: 0x020039AC RID: 14764
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutString_FunctionParams
		{
			// Token: 0x04017AD5 RID: 96981
			[FieldOffset(0)]
			public FString OutString;
		}

		// Token: 0x020039AD RID: 14765
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutNameSet_FunctionParams
		{
			// Token: 0x04017AD6 RID: 96982
			[FieldOffset(0)]
			public byte OutNameSet;
		}

		// Token: 0x020039AE RID: 14766
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutNameMap_FunctionParams
		{
			// Token: 0x04017AD7 RID: 96983
			[FieldOffset(0)]
			public byte OutNameMap;
		}

		// Token: 0x020039AF RID: 14767
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutNameArray_FunctionParams
		{
			// Token: 0x04017AD8 RID: 96984
			[FieldOffset(0)]
			public byte OutNameArray;
		}

		// Token: 0x020039B0 RID: 14768
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __OutName_FunctionParams
		{
			// Token: 0x04017AD9 RID: 96985
			[FieldOffset(0)]
			public FName OutName;
		}

		// Token: 0x020039B1 RID: 14769
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InTextArray_FunctionParams
		{
			// Token: 0x04017ADA RID: 96986
			[FieldOffset(0)]
			public byte InTextArray;
		}

		// Token: 0x020039B2 RID: 14770
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __InText_FunctionParams
		{
			// Token: 0x04017ADB RID: 96987
			[FieldOffset(0)]
			public byte InText;
		}

		// Token: 0x020039B3 RID: 14771
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InStringSet_FunctionParams
		{
			// Token: 0x04017ADC RID: 96988
			[FieldOffset(0)]
			public byte InStringSet;
		}

		// Token: 0x020039B4 RID: 14772
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InStringMap_FunctionParams
		{
			// Token: 0x04017ADD RID: 96989
			[FieldOffset(0)]
			public byte InStringMap;
		}

		// Token: 0x020039B5 RID: 14773
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InStringArray_FunctionParams
		{
			// Token: 0x04017ADE RID: 96990
			[FieldOffset(0)]
			public byte InStringArray;
		}

		// Token: 0x020039B6 RID: 14774
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InString_FunctionParams
		{
			// Token: 0x04017ADF RID: 96991
			[FieldOffset(0)]
			public FString InString;
		}

		// Token: 0x020039B7 RID: 14775
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InNameSet_FunctionParams
		{
			// Token: 0x04017AE0 RID: 96992
			[FieldOffset(0)]
			public byte InNameSet;
		}

		// Token: 0x020039B8 RID: 14776
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InNameMap_FunctionParams
		{
			// Token: 0x04017AE1 RID: 96993
			[FieldOffset(0)]
			public byte InNameMap;
		}

		// Token: 0x020039B9 RID: 14777
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InNameArray_FunctionParams
		{
			// Token: 0x04017AE2 RID: 96994
			[FieldOffset(0)]
			public byte InNameArray;
		}

		// Token: 0x020039BA RID: 14778
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InName_FunctionParams
		{
			// Token: 0x04017AE3 RID: 96995
			[FieldOffset(0)]
			public FName InName;
		}

		// Token: 0x020039BB RID: 14779
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetTextArray_FunctionParams
		{
			// Token: 0x04017AE4 RID: 96996
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020039BC RID: 14780
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetText_FunctionParams
		{
			// Token: 0x04017AE5 RID: 96997
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020039BD RID: 14781
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetStringSet_FunctionParams
		{
			// Token: 0x04017AE6 RID: 96998
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020039BE RID: 14782
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetStringMap_FunctionParams
		{
			// Token: 0x04017AE7 RID: 96999
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020039BF RID: 14783
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetStringArray_FunctionParams
		{
			// Token: 0x04017AE8 RID: 97000
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020039C0 RID: 14784
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetString_FunctionParams
		{
			// Token: 0x04017AE9 RID: 97001
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x020039C1 RID: 14785
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetNameSet_FunctionParams
		{
			// Token: 0x04017AEA RID: 97002
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020039C2 RID: 14786
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetNameMap_FunctionParams
		{
			// Token: 0x04017AEB RID: 97003
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020039C3 RID: 14787
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetNameArray_FunctionParams
		{
			// Token: 0x04017AEC RID: 97004
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020039C4 RID: 14788
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetName_FunctionParams
		{
			// Token: 0x04017AED RID: 97005
			[FieldOffset(0)]
			public FName __Result;
		}
	}
}
