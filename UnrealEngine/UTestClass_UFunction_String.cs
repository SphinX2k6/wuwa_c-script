using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000805 RID: 2053
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SharpherealTest.TestClass_UFunction_String")]
	[UnrealStructLayout(472, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class UTestClass_UFunction_String : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B3EC RID: 46060 RVA: 0x0011A2A3 File Offset: 0x001184A3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTestClass_UFunction_String._ClassPtr;
		}

		// Token: 0x0600B3ED RID: 46061 RVA: 0x0011A2B0 File Offset: 0x001184B0
		public UTestClass_UFunction_String() : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_String.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B3EE RID: 46062 RVA: 0x0011A2D8 File Offset: 0x001184D8
		public UTestClass_UFunction_String(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_String.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170021C0 RID: 8640
		// (get) Token: 0x0600B3EF RID: 46063 RVA: 0x0011A30B File Offset: 0x0011850B
		// (set) Token: 0x0600B3F0 RID: 46064 RVA: 0x0011A31F File Offset: 0x0011851F
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

		// Token: 0x170021C1 RID: 8641
		// (get) Token: 0x0600B3F1 RID: 46065 RVA: 0x0011A334 File Offset: 0x00118534
		// (set) Token: 0x0600B3F2 RID: 46066 RVA: 0x0011A36D File Offset: 0x0011856D
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

		// Token: 0x170021C2 RID: 8642
		// (get) Token: 0x0600B3F3 RID: 46067 RVA: 0x0011A37C File Offset: 0x0011857C
		// (set) Token: 0x0600B3F4 RID: 46068 RVA: 0x0011A3B5 File Offset: 0x001185B5
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

		// Token: 0x170021C3 RID: 8643
		// (get) Token: 0x0600B3F5 RID: 46069 RVA: 0x0011A3C4 File Offset: 0x001185C4
		// (set) Token: 0x0600B3F6 RID: 46070 RVA: 0x0011A3FD File Offset: 0x001185FD
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

		// Token: 0x170021C4 RID: 8644
		// (get) Token: 0x0600B3F7 RID: 46071 RVA: 0x0011A40B File Offset: 0x0011860B
		// (set) Token: 0x0600B3F8 RID: 46072 RVA: 0x0011A41F File Offset: 0x0011861F
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

		// Token: 0x170021C5 RID: 8645
		// (get) Token: 0x0600B3F9 RID: 46073 RVA: 0x0011A434 File Offset: 0x00118634
		// (set) Token: 0x0600B3FA RID: 46074 RVA: 0x0011A46D File Offset: 0x0011866D
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

		// Token: 0x170021C6 RID: 8646
		// (get) Token: 0x0600B3FB RID: 46075 RVA: 0x0011A47C File Offset: 0x0011867C
		// (set) Token: 0x0600B3FC RID: 46076 RVA: 0x0011A4B5 File Offset: 0x001186B5
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

		// Token: 0x170021C7 RID: 8647
		// (get) Token: 0x0600B3FD RID: 46077 RVA: 0x0011A4C4 File Offset: 0x001186C4
		// (set) Token: 0x0600B3FE RID: 46078 RVA: 0x0011A4FD File Offset: 0x001186FD
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

		// Token: 0x170021C8 RID: 8648
		// (get) Token: 0x0600B3FF RID: 46079 RVA: 0x0011A50C File Offset: 0x0011870C
		// (set) Token: 0x0600B400 RID: 46080 RVA: 0x0011A545 File Offset: 0x00118745
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

		// Token: 0x170021C9 RID: 8649
		// (get) Token: 0x0600B401 RID: 46081 RVA: 0x0011A560 File Offset: 0x00118760
		// (set) Token: 0x0600B402 RID: 46082 RVA: 0x0011A599 File Offset: 0x00118799
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

		// Token: 0x0600B403 RID: 46083 RVA: 0x0011A5A8 File Offset: 0x001187A8
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__SetTextArray_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__SetTextArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B404 RID: 46084 RVA: 0x0011A614 File Offset: 0x00118814
		[SkipLocalsInit]
		public unsafe void SetText(FText InText)
		{
			UTestClass_UFunction_String.__SetText_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__SetText_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UTestClass_UFunction_String.__SetText_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__SetText_NativeFunctionPtr, (void*)ptr, 1);
			FText.NativeCopy((void*)(&ptr->InText), InText.NativePtr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__SetText_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__SetText_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B405 RID: 46085 RVA: 0x0011A678 File Offset: 0x00118878
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__SetStringSet_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__SetStringSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B406 RID: 46086 RVA: 0x0011A6E4 File Offset: 0x001188E4
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__SetStringMap_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__SetStringMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B407 RID: 46087 RVA: 0x0011A750 File Offset: 0x00118950
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__SetStringArray_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__SetStringArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B408 RID: 46088 RVA: 0x0011A7BC File Offset: 0x001189BC
		[SkipLocalsInit]
		public unsafe void SetString(string InString)
		{
			UTestClass_UFunction_String.__SetString_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__SetString_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_String.__SetString_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__SetString_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->InString), InString);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__SetString_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__SetString_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B409 RID: 46089 RVA: 0x0011A81C File Offset: 0x00118A1C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetNameSet(TSet<FName> InNameSet)
		{
			UTestClass_UFunction_String.__SetNameSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__SetNameSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_String.__SetNameSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__SetNameSet_NativeFunctionPtr, (void*)ptr, 1);
			if (InNameSet != null)
			{
				InNameSet.CopyTo(&ptr->InNameSet, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__SetNameSet_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__SetNameSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B40A RID: 46090 RVA: 0x0011A888 File Offset: 0x00118A88
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetNameMap(TMap<FName, int> InNameMap)
		{
			UTestClass_UFunction_String.__SetNameMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__SetNameMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_String.__SetNameMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__SetNameMap_NativeFunctionPtr, (void*)ptr, 1);
			if (InNameMap != null)
			{
				InNameMap.CopyTo(&ptr->InNameMap, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__SetNameMap_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__SetNameMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B40B RID: 46091 RVA: 0x0011A8F4 File Offset: 0x00118AF4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetNameArray(TArray<FName> InNameArray)
		{
			UTestClass_UFunction_String.__SetNameArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__SetNameArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_String.__SetNameArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__SetNameArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InNameArray != null)
			{
				InNameArray.CopyTo(&ptr->InNameArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__SetNameArray_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__SetNameArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B40C RID: 46092 RVA: 0x0011A960 File Offset: 0x00118B60
		[SkipLocalsInit]
		public unsafe void SetName(FName InName)
		{
			UTestClass_UFunction_String.__SetName_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__SetName_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UTestClass_UFunction_String.__SetName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__SetName_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InName = InName;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__SetName_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B40D RID: 46093 RVA: 0x0011A9A8 File Offset: 0x00118BA8
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__OutTextArray_NativeFunctionPtr, (void*)ptr);
			TArray<FText> tarray2 = OutTextArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutTextArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__OutTextArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B40E RID: 46094 RVA: 0x0011AA20 File Offset: 0x00118C20
		[SkipLocalsInit]
		public unsafe void OutText(ref FText OutText)
		{
			UTestClass_UFunction_String.__OutText_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__OutText_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UTestClass_UFunction_String.__OutText_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__OutText_NativeFunctionPtr, (void*)ptr, 1);
			FText.NativeMove((void*)(&ptr->OutText), OutText.NativePtr);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__OutText_NativeFunctionPtr, (void*)ptr);
			FText.NativeMove(OutText.NativePtr, (void*)(&ptr->OutText));
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__OutText_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B40F RID: 46095 RVA: 0x0011AA98 File Offset: 0x00118C98
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__OutStringSet_NativeFunctionPtr, (void*)ptr);
			TSet<string> tset2 = OutStringSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutStringSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__OutStringSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B410 RID: 46096 RVA: 0x0011AB10 File Offset: 0x00118D10
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__OutStringMap_NativeFunctionPtr, (void*)ptr);
			TMap<string, int> tmap2 = OutStringMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutStringMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__OutStringMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B411 RID: 46097 RVA: 0x0011AB88 File Offset: 0x00118D88
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__OutStringArray_NativeFunctionPtr, (void*)ptr);
			TArray<string> tarray2 = OutStringArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutStringArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__OutStringArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B412 RID: 46098 RVA: 0x0011AC00 File Offset: 0x00118E00
		[SkipLocalsInit]
		public unsafe void OutString(ref string OutString)
		{
			UTestClass_UFunction_String.__OutString_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__OutString_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_String.__OutString_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__OutString_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->OutString), OutString);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__OutString_NativeFunctionPtr, (void*)ptr);
			OutString = FString.ToString((void*)(&ptr->OutString));
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__OutString_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B413 RID: 46099 RVA: 0x0011AC6C File Offset: 0x00118E6C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutNameSet(ref TSet<FName> OutNameSet)
		{
			UTestClass_UFunction_String.__OutNameSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__OutNameSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_String.__OutNameSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__OutNameSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<FName> tset = OutNameSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutNameSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__OutNameSet_NativeFunctionPtr, (void*)ptr);
			TSet<FName> tset2 = OutNameSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutNameSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__OutNameSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B414 RID: 46100 RVA: 0x0011ACE4 File Offset: 0x00118EE4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutNameMap(ref TMap<FName, int> OutNameMap)
		{
			UTestClass_UFunction_String.__OutNameMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__OutNameMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_String.__OutNameMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__OutNameMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, int> tmap = OutNameMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutNameMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__OutNameMap_NativeFunctionPtr, (void*)ptr);
			TMap<FName, int> tmap2 = OutNameMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutNameMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__OutNameMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B415 RID: 46101 RVA: 0x0011AD5C File Offset: 0x00118F5C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutNameArray(ref TArray<FName> OutNameArray)
		{
			UTestClass_UFunction_String.__OutNameArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__OutNameArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_String.__OutNameArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__OutNameArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FName> tarray = OutNameArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutNameArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__OutNameArray_NativeFunctionPtr, (void*)ptr);
			TArray<FName> tarray2 = OutNameArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutNameArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__OutNameArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B416 RID: 46102 RVA: 0x0011ADD4 File Offset: 0x00118FD4
		[SkipLocalsInit]
		public unsafe void OutName(ref FName OutName)
		{
			UTestClass_UFunction_String.__OutName_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__OutName_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UTestClass_UFunction_String.__OutName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__OutName_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutName = OutName;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__OutName_NativeFunctionPtr, (void*)ptr);
			OutName = ptr->OutName;
		}

		// Token: 0x0600B417 RID: 46103 RVA: 0x0011AE2C File Offset: 0x0011902C
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__InTextArray_NativeFunctionPtr, (void*)ptr);
			TArray<FText> tarray2 = InTextArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InTextArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__InTextArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B418 RID: 46104 RVA: 0x0011AEA4 File Offset: 0x001190A4
		[SkipLocalsInit]
		public unsafe void InText(in FText InText)
		{
			UTestClass_UFunction_String.__InText_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__InText_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UTestClass_UFunction_String.__InText_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__InText_NativeFunctionPtr, (void*)ptr, 1);
			FText.NativeMove((void*)(&ptr->InText), InText.NativePtr);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__InText_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__InText_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B419 RID: 46105 RVA: 0x0011AF08 File Offset: 0x00119108
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__InStringSet_NativeFunctionPtr, (void*)ptr);
			TSet<string> tset2 = InStringSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InStringSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__InStringSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B41A RID: 46106 RVA: 0x0011AF80 File Offset: 0x00119180
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__InStringMap_NativeFunctionPtr, (void*)ptr);
			TMap<string, int> tmap2 = InStringMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InStringMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__InStringMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B41B RID: 46107 RVA: 0x0011AFF8 File Offset: 0x001191F8
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__InStringArray_NativeFunctionPtr, (void*)ptr);
			TArray<string> tarray2 = InStringArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InStringArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__InStringArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B41C RID: 46108 RVA: 0x0011B070 File Offset: 0x00119270
		[SkipLocalsInit]
		public unsafe void InString(in string InString)
		{
			UTestClass_UFunction_String.__InString_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__InString_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_String.__InString_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__InString_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->InString), InString);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__InString_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__InString_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B41D RID: 46109 RVA: 0x0011B0D0 File Offset: 0x001192D0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InNameSet(in TSet<FName> InNameSet)
		{
			UTestClass_UFunction_String.__InNameSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__InNameSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_String.__InNameSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__InNameSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<FName> tset = InNameSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InNameSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__InNameSet_NativeFunctionPtr, (void*)ptr);
			TSet<FName> tset2 = InNameSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InNameSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__InNameSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B41E RID: 46110 RVA: 0x0011B148 File Offset: 0x00119348
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InNameMap(in TMap<FName, int> InNameMap)
		{
			UTestClass_UFunction_String.__InNameMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__InNameMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_String.__InNameMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__InNameMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, int> tmap = InNameMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InNameMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__InNameMap_NativeFunctionPtr, (void*)ptr);
			TMap<FName, int> tmap2 = InNameMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InNameMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__InNameMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B41F RID: 46111 RVA: 0x0011B1C0 File Offset: 0x001193C0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InNameArray(in TArray<FName> InNameArray)
		{
			UTestClass_UFunction_String.__InNameArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__InNameArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_String.__InNameArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__InNameArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FName> tarray = InNameArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InNameArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__InNameArray_NativeFunctionPtr, (void*)ptr);
			TArray<FName> tarray2 = InNameArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InNameArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__InNameArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B420 RID: 46112 RVA: 0x0011B238 File Offset: 0x00119438
		[SkipLocalsInit]
		public unsafe void InName(in FName InName)
		{
			UTestClass_UFunction_String.__InName_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__InName_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UTestClass_UFunction_String.__InName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__InName_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InName = InName;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__InName_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B421 RID: 46113 RVA: 0x0011B284 File Offset: 0x00119484
		[SkipLocalsInit]
		public unsafe TArray<FText> GetTextArray()
		{
			UTestClass_UFunction_String.__GetTextArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__GetTextArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_String.__GetTextArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__GetTextArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__GetTextArray_NativeFunctionPtr, (void*)ptr);
			TArray<FText> result = new TArray<FText>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__GetTextArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B422 RID: 46114 RVA: 0x0011B2E4 File Offset: 0x001194E4
		[SkipLocalsInit]
		public unsafe FText GetText()
		{
			UTestClass_UFunction_String.__GetText_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__GetText_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UTestClass_UFunction_String.__GetText_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__GetText_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__GetText_NativeFunctionPtr, (void*)ptr);
			FText result = new FText(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__GetText_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B423 RID: 46115 RVA: 0x0011B344 File Offset: 0x00119544
		[SkipLocalsInit]
		public unsafe TSet<string> GetStringSet()
		{
			UTestClass_UFunction_String.__GetStringSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__GetStringSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_String.__GetStringSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__GetStringSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__GetStringSet_NativeFunctionPtr, (void*)ptr);
			TSet<string> result = new TSet<string>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__GetStringSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B424 RID: 46116 RVA: 0x0011B3A4 File Offset: 0x001195A4
		[SkipLocalsInit]
		public unsafe TMap<string, int> GetStringMap()
		{
			UTestClass_UFunction_String.__GetStringMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__GetStringMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_String.__GetStringMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__GetStringMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__GetStringMap_NativeFunctionPtr, (void*)ptr);
			TMap<string, int> result = new TMap<string, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__GetStringMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B425 RID: 46117 RVA: 0x0011B404 File Offset: 0x00119604
		[SkipLocalsInit]
		public unsafe TArray<string> GetStringArray()
		{
			UTestClass_UFunction_String.__GetStringArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__GetStringArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_String.__GetStringArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__GetStringArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__GetStringArray_NativeFunctionPtr, (void*)ptr);
			TArray<string> result = new TArray<string>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__GetStringArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B426 RID: 46118 RVA: 0x0011B464 File Offset: 0x00119664
		[SkipLocalsInit]
		public unsafe string GetString()
		{
			UTestClass_UFunction_String.__GetString_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__GetString_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_String.__GetString_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__GetString_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__GetString_NativeFunctionPtr, (void*)ptr);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__GetString_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B427 RID: 46119 RVA: 0x0011B4C0 File Offset: 0x001196C0
		[SkipLocalsInit]
		public unsafe TSet<FName> GetNameSet()
		{
			UTestClass_UFunction_String.__GetNameSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__GetNameSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_String.__GetNameSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__GetNameSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__GetNameSet_NativeFunctionPtr, (void*)ptr);
			TSet<FName> result = new TSet<FName>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__GetNameSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B428 RID: 46120 RVA: 0x0011B520 File Offset: 0x00119720
		[SkipLocalsInit]
		public unsafe TMap<FName, int> GetNameMap()
		{
			UTestClass_UFunction_String.__GetNameMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__GetNameMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_String.__GetNameMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__GetNameMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__GetNameMap_NativeFunctionPtr, (void*)ptr);
			TMap<FName, int> result = new TMap<FName, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__GetNameMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B429 RID: 46121 RVA: 0x0011B580 File Offset: 0x00119780
		[SkipLocalsInit]
		public unsafe TArray<FName> GetNameArray()
		{
			UTestClass_UFunction_String.__GetNameArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__GetNameArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_String.__GetNameArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__GetNameArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__GetNameArray_NativeFunctionPtr, (void*)ptr);
			TArray<FName> result = new TArray<FName>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_String.__GetNameArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B42A RID: 46122 RVA: 0x0011B5E0 File Offset: 0x001197E0
		[SkipLocalsInit]
		public new unsafe FName GetName()
		{
			UTestClass_UFunction_String.__GetName_FunctionParams* ptr = stackalloc UTestClass_UFunction_String.__GetName_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UTestClass_UFunction_String.__GetName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_String.__GetName_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_String.__GetName_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B42B RID: 46123 RVA: 0x0011B625 File Offset: 0x00119825
		static UTestClass_UFunction_String()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SharpherealTest.TestClass_UFunction_String");
		}

		// Token: 0x0600B42C RID: 46124 RVA: 0x0011B633 File Offset: 0x00119833
		protected UTestClass_UFunction_String(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005081 RID: 20609
		public new const string __ObjectPath = "/Script/SharpherealTest.TestClass_UFunction_String";

		// Token: 0x04005082 RID: 20610
		private static IntPtr _ClassPtr;

		// Token: 0x04005083 RID: 20611
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005084 RID: 20612
		internal static int __PropertyOffset_String;

		// Token: 0x04005085 RID: 20613
		internal static int __PropertyOffset_StringArray;

		// Token: 0x04005086 RID: 20614
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _StringArray;

		// Token: 0x04005087 RID: 20615
		internal static int __PropertyOffset_StringSet;

		// Token: 0x04005088 RID: 20616
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<string> _StringSet;

		// Token: 0x04005089 RID: 20617
		internal static int __PropertyOffset_StringMap;

		// Token: 0x0400508A RID: 20618
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, int> _StringMap;

		// Token: 0x0400508B RID: 20619
		internal static int __PropertyOffset_Name;

		// Token: 0x0400508C RID: 20620
		internal static int __PropertyOffset_NameArray;

		// Token: 0x0400508D RID: 20621
		[Nullable(2)]
		private TArray<FName> _NameArray;

		// Token: 0x0400508E RID: 20622
		internal static int __PropertyOffset_NameSet;

		// Token: 0x0400508F RID: 20623
		[Nullable(2)]
		private TSet<FName> _NameSet;

		// Token: 0x04005090 RID: 20624
		internal static int __PropertyOffset_NameMap;

		// Token: 0x04005091 RID: 20625
		[Nullable(2)]
		private TMap<FName, int> _NameMap;

		// Token: 0x04005092 RID: 20626
		internal static int __PropertyOffset_Text;

		// Token: 0x04005093 RID: 20627
		[Nullable(2)]
		private FText _Text;

		// Token: 0x04005094 RID: 20628
		internal static int __PropertyOffset_TextArray;

		// Token: 0x04005095 RID: 20629
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FText> _TextArray;

		// Token: 0x04005096 RID: 20630
		private static IntPtr __SetTextArray_NativeFunctionPtr;

		// Token: 0x04005097 RID: 20631
		private static IntPtr __SetText_NativeFunctionPtr;

		// Token: 0x04005098 RID: 20632
		private static IntPtr __SetStringSet_NativeFunctionPtr;

		// Token: 0x04005099 RID: 20633
		private static IntPtr __SetStringMap_NativeFunctionPtr;

		// Token: 0x0400509A RID: 20634
		private static IntPtr __SetStringArray_NativeFunctionPtr;

		// Token: 0x0400509B RID: 20635
		private static IntPtr __SetString_NativeFunctionPtr;

		// Token: 0x0400509C RID: 20636
		private static IntPtr __SetNameSet_NativeFunctionPtr;

		// Token: 0x0400509D RID: 20637
		private static IntPtr __SetNameMap_NativeFunctionPtr;

		// Token: 0x0400509E RID: 20638
		private static IntPtr __SetNameArray_NativeFunctionPtr;

		// Token: 0x0400509F RID: 20639
		private static IntPtr __SetName_NativeFunctionPtr;

		// Token: 0x040050A0 RID: 20640
		private static IntPtr __OutTextArray_NativeFunctionPtr;

		// Token: 0x040050A1 RID: 20641
		private static IntPtr __OutText_NativeFunctionPtr;

		// Token: 0x040050A2 RID: 20642
		private static IntPtr __OutStringSet_NativeFunctionPtr;

		// Token: 0x040050A3 RID: 20643
		private static IntPtr __OutStringMap_NativeFunctionPtr;

		// Token: 0x040050A4 RID: 20644
		private static IntPtr __OutStringArray_NativeFunctionPtr;

		// Token: 0x040050A5 RID: 20645
		private static IntPtr __OutString_NativeFunctionPtr;

		// Token: 0x040050A6 RID: 20646
		private static IntPtr __OutNameSet_NativeFunctionPtr;

		// Token: 0x040050A7 RID: 20647
		private static IntPtr __OutNameMap_NativeFunctionPtr;

		// Token: 0x040050A8 RID: 20648
		private static IntPtr __OutNameArray_NativeFunctionPtr;

		// Token: 0x040050A9 RID: 20649
		private static IntPtr __OutName_NativeFunctionPtr;

		// Token: 0x040050AA RID: 20650
		private static IntPtr __InTextArray_NativeFunctionPtr;

		// Token: 0x040050AB RID: 20651
		private static IntPtr __InText_NativeFunctionPtr;

		// Token: 0x040050AC RID: 20652
		private static IntPtr __InStringSet_NativeFunctionPtr;

		// Token: 0x040050AD RID: 20653
		private static IntPtr __InStringMap_NativeFunctionPtr;

		// Token: 0x040050AE RID: 20654
		private static IntPtr __InStringArray_NativeFunctionPtr;

		// Token: 0x040050AF RID: 20655
		private static IntPtr __InString_NativeFunctionPtr;

		// Token: 0x040050B0 RID: 20656
		private static IntPtr __InNameSet_NativeFunctionPtr;

		// Token: 0x040050B1 RID: 20657
		private static IntPtr __InNameMap_NativeFunctionPtr;

		// Token: 0x040050B2 RID: 20658
		private static IntPtr __InNameArray_NativeFunctionPtr;

		// Token: 0x040050B3 RID: 20659
		private static IntPtr __InName_NativeFunctionPtr;

		// Token: 0x040050B4 RID: 20660
		private static IntPtr __GetTextArray_NativeFunctionPtr;

		// Token: 0x040050B5 RID: 20661
		private static IntPtr __GetText_NativeFunctionPtr;

		// Token: 0x040050B6 RID: 20662
		private static IntPtr __GetStringSet_NativeFunctionPtr;

		// Token: 0x040050B7 RID: 20663
		private static IntPtr __GetStringMap_NativeFunctionPtr;

		// Token: 0x040050B8 RID: 20664
		private static IntPtr __GetStringArray_NativeFunctionPtr;

		// Token: 0x040050B9 RID: 20665
		private static IntPtr __GetString_NativeFunctionPtr;

		// Token: 0x040050BA RID: 20666
		private static IntPtr __GetNameSet_NativeFunctionPtr;

		// Token: 0x040050BB RID: 20667
		private static IntPtr __GetNameMap_NativeFunctionPtr;

		// Token: 0x040050BC RID: 20668
		private static IntPtr __GetNameArray_NativeFunctionPtr;

		// Token: 0x040050BD RID: 20669
		private static IntPtr __GetName_NativeFunctionPtr;

		// Token: 0x0200126F RID: 4719
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetTextArray_FunctionParams
		{
			// Token: 0x04006679 RID: 26233
			[FieldOffset(0)]
			public byte InTextArray;
		}

		// Token: 0x02001270 RID: 4720
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SetText_FunctionParams
		{
			// Token: 0x0400667A RID: 26234
			[FieldOffset(0)]
			public byte InText;
		}

		// Token: 0x02001271 RID: 4721
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetStringSet_FunctionParams
		{
			// Token: 0x0400667B RID: 26235
			[FieldOffset(0)]
			public byte InStringSet;
		}

		// Token: 0x02001272 RID: 4722
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetStringMap_FunctionParams
		{
			// Token: 0x0400667C RID: 26236
			[FieldOffset(0)]
			public byte InStringMap;
		}

		// Token: 0x02001273 RID: 4723
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetStringArray_FunctionParams
		{
			// Token: 0x0400667D RID: 26237
			[FieldOffset(0)]
			public byte InStringArray;
		}

		// Token: 0x02001274 RID: 4724
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetString_FunctionParams
		{
			// Token: 0x0400667E RID: 26238
			[FieldOffset(0)]
			public FString InString;
		}

		// Token: 0x02001275 RID: 4725
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetNameSet_FunctionParams
		{
			// Token: 0x0400667F RID: 26239
			[FieldOffset(0)]
			public byte InNameSet;
		}

		// Token: 0x02001276 RID: 4726
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetNameMap_FunctionParams
		{
			// Token: 0x04006680 RID: 26240
			[FieldOffset(0)]
			public byte InNameMap;
		}

		// Token: 0x02001277 RID: 4727
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetNameArray_FunctionParams
		{
			// Token: 0x04006681 RID: 26241
			[FieldOffset(0)]
			public byte InNameArray;
		}

		// Token: 0x02001278 RID: 4728
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __SetName_FunctionParams
		{
			// Token: 0x04006682 RID: 26242
			[FieldOffset(0)]
			public FName InName;
		}

		// Token: 0x02001279 RID: 4729
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutTextArray_FunctionParams
		{
			// Token: 0x04006683 RID: 26243
			[FieldOffset(0)]
			public byte OutTextArray;
		}

		// Token: 0x0200127A RID: 4730
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __OutText_FunctionParams
		{
			// Token: 0x04006684 RID: 26244
			[FieldOffset(0)]
			public byte OutText;
		}

		// Token: 0x0200127B RID: 4731
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutStringSet_FunctionParams
		{
			// Token: 0x04006685 RID: 26245
			[FieldOffset(0)]
			public byte OutStringSet;
		}

		// Token: 0x0200127C RID: 4732
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutStringMap_FunctionParams
		{
			// Token: 0x04006686 RID: 26246
			[FieldOffset(0)]
			public byte OutStringMap;
		}

		// Token: 0x0200127D RID: 4733
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutStringArray_FunctionParams
		{
			// Token: 0x04006687 RID: 26247
			[FieldOffset(0)]
			public byte OutStringArray;
		}

		// Token: 0x0200127E RID: 4734
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutString_FunctionParams
		{
			// Token: 0x04006688 RID: 26248
			[FieldOffset(0)]
			public FString OutString;
		}

		// Token: 0x0200127F RID: 4735
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutNameSet_FunctionParams
		{
			// Token: 0x04006689 RID: 26249
			[FieldOffset(0)]
			public byte OutNameSet;
		}

		// Token: 0x02001280 RID: 4736
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutNameMap_FunctionParams
		{
			// Token: 0x0400668A RID: 26250
			[FieldOffset(0)]
			public byte OutNameMap;
		}

		// Token: 0x02001281 RID: 4737
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutNameArray_FunctionParams
		{
			// Token: 0x0400668B RID: 26251
			[FieldOffset(0)]
			public byte OutNameArray;
		}

		// Token: 0x02001282 RID: 4738
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __OutName_FunctionParams
		{
			// Token: 0x0400668C RID: 26252
			[FieldOffset(0)]
			public FName OutName;
		}

		// Token: 0x02001283 RID: 4739
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InTextArray_FunctionParams
		{
			// Token: 0x0400668D RID: 26253
			[FieldOffset(0)]
			public byte InTextArray;
		}

		// Token: 0x02001284 RID: 4740
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __InText_FunctionParams
		{
			// Token: 0x0400668E RID: 26254
			[FieldOffset(0)]
			public byte InText;
		}

		// Token: 0x02001285 RID: 4741
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InStringSet_FunctionParams
		{
			// Token: 0x0400668F RID: 26255
			[FieldOffset(0)]
			public byte InStringSet;
		}

		// Token: 0x02001286 RID: 4742
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InStringMap_FunctionParams
		{
			// Token: 0x04006690 RID: 26256
			[FieldOffset(0)]
			public byte InStringMap;
		}

		// Token: 0x02001287 RID: 4743
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InStringArray_FunctionParams
		{
			// Token: 0x04006691 RID: 26257
			[FieldOffset(0)]
			public byte InStringArray;
		}

		// Token: 0x02001288 RID: 4744
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InString_FunctionParams
		{
			// Token: 0x04006692 RID: 26258
			[FieldOffset(0)]
			public FString InString;
		}

		// Token: 0x02001289 RID: 4745
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InNameSet_FunctionParams
		{
			// Token: 0x04006693 RID: 26259
			[FieldOffset(0)]
			public byte InNameSet;
		}

		// Token: 0x0200128A RID: 4746
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InNameMap_FunctionParams
		{
			// Token: 0x04006694 RID: 26260
			[FieldOffset(0)]
			public byte InNameMap;
		}

		// Token: 0x0200128B RID: 4747
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InNameArray_FunctionParams
		{
			// Token: 0x04006695 RID: 26261
			[FieldOffset(0)]
			public byte InNameArray;
		}

		// Token: 0x0200128C RID: 4748
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InName_FunctionParams
		{
			// Token: 0x04006696 RID: 26262
			[FieldOffset(0)]
			public FName InName;
		}

		// Token: 0x0200128D RID: 4749
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetTextArray_FunctionParams
		{
			// Token: 0x04006697 RID: 26263
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200128E RID: 4750
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetText_FunctionParams
		{
			// Token: 0x04006698 RID: 26264
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200128F RID: 4751
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetStringSet_FunctionParams
		{
			// Token: 0x04006699 RID: 26265
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001290 RID: 4752
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetStringMap_FunctionParams
		{
			// Token: 0x0400669A RID: 26266
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001291 RID: 4753
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetStringArray_FunctionParams
		{
			// Token: 0x0400669B RID: 26267
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001292 RID: 4754
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetString_FunctionParams
		{
			// Token: 0x0400669C RID: 26268
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02001293 RID: 4755
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetNameSet_FunctionParams
		{
			// Token: 0x0400669D RID: 26269
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001294 RID: 4756
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetNameMap_FunctionParams
		{
			// Token: 0x0400669E RID: 26270
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001295 RID: 4757
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetNameArray_FunctionParams
		{
			// Token: 0x0400669F RID: 26271
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001296 RID: 4758
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetName_FunctionParams
		{
			// Token: 0x040066A0 RID: 26272
			[FieldOffset(0)]
			public FName __Result;
		}
	}
}
