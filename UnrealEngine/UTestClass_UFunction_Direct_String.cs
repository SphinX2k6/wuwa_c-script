using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200274B RID: 10059
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SharpherealTest.TestClass_UFunction_Direct_String")]
	[UnrealStructLayout(472, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class UTestClass_UFunction_Direct_String : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602574B RID: 153419 RVA: 0x00382738 File Offset: 0x00380938
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTestClass_UFunction_Direct_String._ClassPtr;
		}

		// Token: 0x0602574C RID: 153420 RVA: 0x00382744 File Offset: 0x00380944
		public UTestClass_UFunction_Direct_String() : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_Direct_String.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602574D RID: 153421 RVA: 0x0038276C File Offset: 0x0038096C
		public UTestClass_UFunction_Direct_String(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_Direct_String.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700908A RID: 37002
		// (get) Token: 0x0602574E RID: 153422 RVA: 0x0038279F File Offset: 0x0038099F
		// (set) Token: 0x0602574F RID: 153423 RVA: 0x003827B3 File Offset: 0x003809B3
		public unsafe string String
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UTestClass_UFunction_Direct_String.__PropertyOffset_String)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UTestClass_UFunction_Direct_String.__PropertyOffset_String)), value);
			}
		}

		// Token: 0x1700908B RID: 37003
		// (get) Token: 0x06025750 RID: 153424 RVA: 0x003827C8 File Offset: 0x003809C8
		// (set) Token: 0x06025751 RID: 153425 RVA: 0x00382801 File Offset: 0x00380A01
		public TArray<string> StringArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._StringArray) == null)
				{
					result = (this._StringArray = new TArray<string>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_String.__PropertyOffset_StringArray, this));
				}
				return result;
			}
			set
			{
				this.StringArray.CopyAssign(value);
			}
		}

		// Token: 0x1700908C RID: 37004
		// (get) Token: 0x06025752 RID: 153426 RVA: 0x00382810 File Offset: 0x00380A10
		// (set) Token: 0x06025753 RID: 153427 RVA: 0x00382849 File Offset: 0x00380A49
		public TSet<string> StringSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<string> result;
				if ((result = this._StringSet) == null)
				{
					result = (this._StringSet = new TSet<string>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_String.__PropertyOffset_StringSet, this));
				}
				return result;
			}
			set
			{
				this.StringSet.CopyAssign(value);
			}
		}

		// Token: 0x1700908D RID: 37005
		// (get) Token: 0x06025754 RID: 153428 RVA: 0x00382858 File Offset: 0x00380A58
		// (set) Token: 0x06025755 RID: 153429 RVA: 0x00382891 File Offset: 0x00380A91
		public TMap<string, int> StringMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, int> result;
				if ((result = this._StringMap) == null)
				{
					result = (this._StringMap = new TMap<string, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_String.__PropertyOffset_StringMap, this));
				}
				return result;
			}
			set
			{
				this.StringMap.CopyAssign(value);
			}
		}

		// Token: 0x1700908E RID: 37006
		// (get) Token: 0x06025756 RID: 153430 RVA: 0x0038289F File Offset: 0x00380A9F
		// (set) Token: 0x06025757 RID: 153431 RVA: 0x003828B3 File Offset: 0x00380AB3
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_String.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_String.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x1700908F RID: 37007
		// (get) Token: 0x06025758 RID: 153432 RVA: 0x003828C8 File Offset: 0x00380AC8
		// (set) Token: 0x06025759 RID: 153433 RVA: 0x00382901 File Offset: 0x00380B01
		public TArray<FName> NameArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._NameArray) == null)
				{
					result = (this._NameArray = new TArray<FName>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_String.__PropertyOffset_NameArray, this));
				}
				return result;
			}
			set
			{
				this.NameArray.CopyAssign(value);
			}
		}

		// Token: 0x17009090 RID: 37008
		// (get) Token: 0x0602575A RID: 153434 RVA: 0x00382910 File Offset: 0x00380B10
		// (set) Token: 0x0602575B RID: 153435 RVA: 0x00382949 File Offset: 0x00380B49
		public TSet<FName> NameSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<FName> result;
				if ((result = this._NameSet) == null)
				{
					result = (this._NameSet = new TSet<FName>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_String.__PropertyOffset_NameSet, this));
				}
				return result;
			}
			set
			{
				this.NameSet.CopyAssign(value);
			}
		}

		// Token: 0x17009091 RID: 37009
		// (get) Token: 0x0602575C RID: 153436 RVA: 0x00382958 File Offset: 0x00380B58
		// (set) Token: 0x0602575D RID: 153437 RVA: 0x00382991 File Offset: 0x00380B91
		public TMap<FName, int> NameMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, int> result;
				if ((result = this._NameMap) == null)
				{
					result = (this._NameMap = new TMap<FName, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_String.__PropertyOffset_NameMap, this));
				}
				return result;
			}
			set
			{
				this.NameMap.CopyAssign(value);
			}
		}

		// Token: 0x17009092 RID: 37010
		// (get) Token: 0x0602575E RID: 153438 RVA: 0x003829A0 File Offset: 0x00380BA0
		// (set) Token: 0x0602575F RID: 153439 RVA: 0x003829D9 File Offset: 0x00380BD9
		public unsafe FText Text
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._Text) == null)
				{
					result = (this._Text = new FText(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_String.__PropertyOffset_Text, this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)UTestClass_UFunction_Direct_String.__PropertyOffset_Text)), value.NativePtr, 1);
			}
		}

		// Token: 0x17009093 RID: 37011
		// (get) Token: 0x06025760 RID: 153440 RVA: 0x003829F4 File Offset: 0x00380BF4
		// (set) Token: 0x06025761 RID: 153441 RVA: 0x00382A2D File Offset: 0x00380C2D
		public TArray<FText> TextArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FText> result;
				if ((result = this._TextArray) == null)
				{
					result = (this._TextArray = new TArray<FText>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_String.__PropertyOffset_TextArray, this));
				}
				return result;
			}
			set
			{
				this.TextArray.CopyAssign(value);
			}
		}

		// Token: 0x06025762 RID: 153442 RVA: 0x00382A3C File Offset: 0x00380C3C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetTextArray([Nullable(new byte[]
		{
			2,
			1
		})] TArray<FText> InTextArray)
		{
			UTestClass_UFunction_Direct_String.__SetTextArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__SetTextArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__SetTextArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__SetTextArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InTextArray != null)
			{
				InTextArray.CopyTo(&ptr->InTextArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__SetTextArray_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__SetTextArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025763 RID: 153443 RVA: 0x00382AA8 File Offset: 0x00380CA8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetText(FText InText)
		{
			UTestClass_UFunction_Direct_String.__SetText_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__SetText_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__SetText_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__SetText_NativeFunctionPtr, (void*)ptr, 1);
			FText.NativeCopy((void*)(&ptr->InText), InText.NativePtr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__SetText_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__SetText_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025764 RID: 153444 RVA: 0x00382B0C File Offset: 0x00380D0C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetStringSet([Nullable(new byte[]
		{
			2,
			1
		})] TSet<string> InStringSet)
		{
			UTestClass_UFunction_Direct_String.__SetStringSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__SetStringSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__SetStringSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__SetStringSet_NativeFunctionPtr, (void*)ptr, 1);
			if (InStringSet != null)
			{
				InStringSet.CopyTo(&ptr->InStringSet, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__SetStringSet_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__SetStringSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025765 RID: 153445 RVA: 0x00382B78 File Offset: 0x00380D78
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetStringMap([Nullable(new byte[]
		{
			2,
			1
		})] TMap<string, int> InStringMap)
		{
			UTestClass_UFunction_Direct_String.__SetStringMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__SetStringMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__SetStringMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__SetStringMap_NativeFunctionPtr, (void*)ptr, 1);
			if (InStringMap != null)
			{
				InStringMap.CopyTo(&ptr->InStringMap, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__SetStringMap_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__SetStringMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025766 RID: 153446 RVA: 0x00382BE4 File Offset: 0x00380DE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetStringArray([Nullable(new byte[]
		{
			2,
			1
		})] TArray<string> InStringArray)
		{
			UTestClass_UFunction_Direct_String.__SetStringArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__SetStringArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__SetStringArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__SetStringArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InStringArray != null)
			{
				InStringArray.CopyTo(&ptr->InStringArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__SetStringArray_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__SetStringArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025767 RID: 153447 RVA: 0x00382C50 File Offset: 0x00380E50
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetString(string InString)
		{
			UTestClass_UFunction_Direct_String.__SetString_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__SetString_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__SetString_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__SetString_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->InString), InString);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__SetString_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__SetString_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025768 RID: 153448 RVA: 0x00382CB0 File Offset: 0x00380EB0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetNameSet(TSet<FName> InNameSet)
		{
			UTestClass_UFunction_Direct_String.__SetNameSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__SetNameSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__SetNameSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__SetNameSet_NativeFunctionPtr, (void*)ptr, 1);
			if (InNameSet != null)
			{
				InNameSet.CopyTo(&ptr->InNameSet, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__SetNameSet_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__SetNameSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025769 RID: 153449 RVA: 0x00382D1C File Offset: 0x00380F1C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetNameMap(TMap<FName, int> InNameMap)
		{
			UTestClass_UFunction_Direct_String.__SetNameMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__SetNameMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__SetNameMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__SetNameMap_NativeFunctionPtr, (void*)ptr, 1);
			if (InNameMap != null)
			{
				InNameMap.CopyTo(&ptr->InNameMap, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__SetNameMap_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__SetNameMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602576A RID: 153450 RVA: 0x00382D88 File Offset: 0x00380F88
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetNameArray(TArray<FName> InNameArray)
		{
			UTestClass_UFunction_Direct_String.__SetNameArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__SetNameArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__SetNameArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__SetNameArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InNameArray != null)
			{
				InNameArray.CopyTo(&ptr->InNameArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__SetNameArray_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__SetNameArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602576B RID: 153451 RVA: 0x00382DF4 File Offset: 0x00380FF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetName(FName InName)
		{
			UTestClass_UFunction_Direct_String.__SetName_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__SetName_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__SetName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__SetName_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InName = InName;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__SetName_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602576C RID: 153452 RVA: 0x00382E3C File Offset: 0x0038103C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutTextArray([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FText> OutTextArray)
		{
			UTestClass_UFunction_Direct_String.__OutTextArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__OutTextArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__OutTextArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__OutTextArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FText> tarray = OutTextArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutTextArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__OutTextArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FText> tarray2 = OutTextArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutTextArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__OutTextArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602576D RID: 153453 RVA: 0x00382EB8 File Offset: 0x003810B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutText(ref FText OutText)
		{
			UTestClass_UFunction_Direct_String.__OutText_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__OutText_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__OutText_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__OutText_NativeFunctionPtr, (void*)ptr, 1);
			FText.NativeMove((void*)(&ptr->OutText), OutText.NativePtr);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__OutText_NativeFunctionPtr, (void*)ptr, 0);
			FText.NativeMove(OutText.NativePtr, (void*)(&ptr->OutText));
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__OutText_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602576E RID: 153454 RVA: 0x00382F30 File Offset: 0x00381130
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutStringSet([Nullable(new byte[]
		{
			2,
			1
		})] ref TSet<string> OutStringSet)
		{
			UTestClass_UFunction_Direct_String.__OutStringSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__OutStringSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__OutStringSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__OutStringSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<string> tset = OutStringSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutStringSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__OutStringSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<string> tset2 = OutStringSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutStringSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__OutStringSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602576F RID: 153455 RVA: 0x00382FAC File Offset: 0x003811AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutStringMap([Nullable(new byte[]
		{
			2,
			1
		})] ref TMap<string, int> OutStringMap)
		{
			UTestClass_UFunction_Direct_String.__OutStringMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__OutStringMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__OutStringMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__OutStringMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<string, int> tmap = OutStringMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutStringMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__OutStringMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<string, int> tmap2 = OutStringMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutStringMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__OutStringMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025770 RID: 153456 RVA: 0x00383028 File Offset: 0x00381228
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutStringArray([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<string> OutStringArray)
		{
			UTestClass_UFunction_Direct_String.__OutStringArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__OutStringArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__OutStringArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__OutStringArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<string> tarray = OutStringArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutStringArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__OutStringArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<string> tarray2 = OutStringArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutStringArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__OutStringArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025771 RID: 153457 RVA: 0x003830A4 File Offset: 0x003812A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutString(ref string OutString)
		{
			UTestClass_UFunction_Direct_String.__OutString_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__OutString_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__OutString_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__OutString_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->OutString), OutString);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__OutString_NativeFunctionPtr, (void*)ptr, 0);
			OutString = FString.ToString((void*)(&ptr->OutString));
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__OutString_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025772 RID: 153458 RVA: 0x00383114 File Offset: 0x00381314
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutNameSet(ref TSet<FName> OutNameSet)
		{
			UTestClass_UFunction_Direct_String.__OutNameSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__OutNameSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__OutNameSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__OutNameSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<FName> tset = OutNameSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutNameSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__OutNameSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<FName> tset2 = OutNameSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutNameSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__OutNameSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025773 RID: 153459 RVA: 0x00383190 File Offset: 0x00381390
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutNameMap(ref TMap<FName, int> OutNameMap)
		{
			UTestClass_UFunction_Direct_String.__OutNameMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__OutNameMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__OutNameMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__OutNameMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, int> tmap = OutNameMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutNameMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__OutNameMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FName, int> tmap2 = OutNameMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutNameMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__OutNameMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025774 RID: 153460 RVA: 0x0038320C File Offset: 0x0038140C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutNameArray(ref TArray<FName> OutNameArray)
		{
			UTestClass_UFunction_Direct_String.__OutNameArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__OutNameArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__OutNameArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__OutNameArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FName> tarray = OutNameArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutNameArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__OutNameArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FName> tarray2 = OutNameArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutNameArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__OutNameArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025775 RID: 153461 RVA: 0x00383288 File Offset: 0x00381488
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutName(ref FName OutName)
		{
			UTestClass_UFunction_Direct_String.__OutName_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__OutName_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__OutName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__OutName_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutName = OutName;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__OutName_NativeFunctionPtr, (void*)ptr, 0);
			OutName = ptr->OutName;
		}

		// Token: 0x06025776 RID: 153462 RVA: 0x003832E0 File Offset: 0x003814E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InTextArray([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FText> InTextArray)
		{
			UTestClass_UFunction_Direct_String.__InTextArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__InTextArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__InTextArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__InTextArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FText> tarray = InTextArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InTextArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__InTextArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FText> tarray2 = InTextArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InTextArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__InTextArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025777 RID: 153463 RVA: 0x0038335C File Offset: 0x0038155C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InText(in FText InText)
		{
			UTestClass_UFunction_Direct_String.__InText_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__InText_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__InText_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__InText_NativeFunctionPtr, (void*)ptr, 1);
			FText.NativeMove((void*)(&ptr->InText), InText.NativePtr);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__InText_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__InText_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025778 RID: 153464 RVA: 0x003833C0 File Offset: 0x003815C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InStringSet([Nullable(new byte[]
		{
			2,
			1
		})] in TSet<string> InStringSet)
		{
			UTestClass_UFunction_Direct_String.__InStringSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__InStringSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__InStringSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__InStringSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<string> tset = InStringSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InStringSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__InStringSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<string> tset2 = InStringSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InStringSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__InStringSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025779 RID: 153465 RVA: 0x0038343C File Offset: 0x0038163C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InStringMap([Nullable(new byte[]
		{
			2,
			1
		})] in TMap<string, int> InStringMap)
		{
			UTestClass_UFunction_Direct_String.__InStringMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__InStringMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__InStringMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__InStringMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<string, int> tmap = InStringMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InStringMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__InStringMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<string, int> tmap2 = InStringMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InStringMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__InStringMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602577A RID: 153466 RVA: 0x003834B8 File Offset: 0x003816B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InStringArray([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> InStringArray)
		{
			UTestClass_UFunction_Direct_String.__InStringArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__InStringArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__InStringArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__InStringArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<string> tarray = InStringArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InStringArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__InStringArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<string> tarray2 = InStringArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InStringArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__InStringArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602577B RID: 153467 RVA: 0x00383534 File Offset: 0x00381734
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InString(in string InString)
		{
			UTestClass_UFunction_Direct_String.__InString_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__InString_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__InString_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__InString_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->InString), InString);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__InString_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__InString_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602577C RID: 153468 RVA: 0x00383594 File Offset: 0x00381794
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InNameSet(in TSet<FName> InNameSet)
		{
			UTestClass_UFunction_Direct_String.__InNameSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__InNameSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__InNameSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__InNameSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<FName> tset = InNameSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InNameSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__InNameSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<FName> tset2 = InNameSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InNameSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__InNameSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602577D RID: 153469 RVA: 0x00383610 File Offset: 0x00381810
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InNameMap(in TMap<FName, int> InNameMap)
		{
			UTestClass_UFunction_Direct_String.__InNameMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__InNameMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__InNameMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__InNameMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, int> tmap = InNameMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InNameMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__InNameMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FName, int> tmap2 = InNameMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InNameMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__InNameMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602577E RID: 153470 RVA: 0x0038368C File Offset: 0x0038188C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InNameArray(in TArray<FName> InNameArray)
		{
			UTestClass_UFunction_Direct_String.__InNameArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__InNameArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__InNameArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__InNameArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FName> tarray = InNameArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InNameArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__InNameArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FName> tarray2 = InNameArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InNameArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__InNameArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602577F RID: 153471 RVA: 0x00383708 File Offset: 0x00381908
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InName(in FName InName)
		{
			UTestClass_UFunction_Direct_String.__InName_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__InName_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__InName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__InName_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InName = InName;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__InName_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025780 RID: 153472 RVA: 0x00383754 File Offset: 0x00381954
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<FText> GetTextArray()
		{
			UTestClass_UFunction_Direct_String.__GetTextArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__GetTextArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__GetTextArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__GetTextArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__GetTextArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FText> result = new TArray<FText>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__GetTextArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025781 RID: 153473 RVA: 0x003837B4 File Offset: 0x003819B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FText GetText()
		{
			UTestClass_UFunction_Direct_String.__GetText_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__GetText_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__GetText_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__GetText_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__GetText_NativeFunctionPtr, (void*)ptr, 0);
			FText result = new FText(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__GetText_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025782 RID: 153474 RVA: 0x00383814 File Offset: 0x00381A14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<string> GetStringSet()
		{
			UTestClass_UFunction_Direct_String.__GetStringSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__GetStringSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__GetStringSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__GetStringSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__GetStringSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<string> result = new TSet<string>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__GetStringSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025783 RID: 153475 RVA: 0x00383874 File Offset: 0x00381A74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<string, int> GetStringMap()
		{
			UTestClass_UFunction_Direct_String.__GetStringMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__GetStringMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__GetStringMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__GetStringMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__GetStringMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<string, int> result = new TMap<string, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__GetStringMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025784 RID: 153476 RVA: 0x003838D4 File Offset: 0x00381AD4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<string> GetStringArray()
		{
			UTestClass_UFunction_Direct_String.__GetStringArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__GetStringArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__GetStringArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__GetStringArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__GetStringArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<string> result = new TArray<string>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__GetStringArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025785 RID: 153477 RVA: 0x00383934 File Offset: 0x00381B34
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe string GetString()
		{
			UTestClass_UFunction_Direct_String.__GetString_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__GetString_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__GetString_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__GetString_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__GetString_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__GetString_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025786 RID: 153478 RVA: 0x00383994 File Offset: 0x00381B94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<FName> GetNameSet()
		{
			UTestClass_UFunction_Direct_String.__GetNameSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__GetNameSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__GetNameSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__GetNameSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__GetNameSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<FName> result = new TSet<FName>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__GetNameSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025787 RID: 153479 RVA: 0x003839F4 File Offset: 0x00381BF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<FName, int> GetNameMap()
		{
			UTestClass_UFunction_Direct_String.__GetNameMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__GetNameMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__GetNameMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__GetNameMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__GetNameMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FName, int> result = new TMap<FName, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__GetNameMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025788 RID: 153480 RVA: 0x00383A54 File Offset: 0x00381C54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<FName> GetNameArray()
		{
			UTestClass_UFunction_Direct_String.__GetNameArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__GetNameArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__GetNameArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__GetNameArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__GetNameArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FName> result = new TArray<FName>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__GetNameArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025789 RID: 153481 RVA: 0x00383AB4 File Offset: 0x00381CB4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public new unsafe FName GetName()
		{
			UTestClass_UFunction_Direct_String.__GetName_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__GetName_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__GetName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__GetName_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__GetName_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602578A RID: 153482 RVA: 0x00383AFA File Offset: 0x00381CFA
		static UTestClass_UFunction_Direct_String()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SharpherealTest.TestClass_UFunction_Direct_String");
		}

		// Token: 0x0602578B RID: 153483 RVA: 0x00383B08 File Offset: 0x00381D08
		protected UTestClass_UFunction_Direct_String(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014485 RID: 83077
		public new const string __ObjectPath = "/Script/SharpherealTest.TestClass_UFunction_Direct_String";

		// Token: 0x04014486 RID: 83078
		private static IntPtr _ClassPtr;

		// Token: 0x04014487 RID: 83079
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014488 RID: 83080
		internal static int __PropertyOffset_String;

		// Token: 0x04014489 RID: 83081
		internal static int __PropertyOffset_StringArray;

		// Token: 0x0401448A RID: 83082
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _StringArray;

		// Token: 0x0401448B RID: 83083
		internal static int __PropertyOffset_StringSet;

		// Token: 0x0401448C RID: 83084
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<string> _StringSet;

		// Token: 0x0401448D RID: 83085
		internal static int __PropertyOffset_StringMap;

		// Token: 0x0401448E RID: 83086
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, int> _StringMap;

		// Token: 0x0401448F RID: 83087
		internal static int __PropertyOffset_Name;

		// Token: 0x04014490 RID: 83088
		internal static int __PropertyOffset_NameArray;

		// Token: 0x04014491 RID: 83089
		[Nullable(2)]
		private TArray<FName> _NameArray;

		// Token: 0x04014492 RID: 83090
		internal static int __PropertyOffset_NameSet;

		// Token: 0x04014493 RID: 83091
		[Nullable(2)]
		private TSet<FName> _NameSet;

		// Token: 0x04014494 RID: 83092
		internal static int __PropertyOffset_NameMap;

		// Token: 0x04014495 RID: 83093
		[Nullable(2)]
		private TMap<FName, int> _NameMap;

		// Token: 0x04014496 RID: 83094
		internal static int __PropertyOffset_Text;

		// Token: 0x04014497 RID: 83095
		[Nullable(2)]
		private FText _Text;

		// Token: 0x04014498 RID: 83096
		internal static int __PropertyOffset_TextArray;

		// Token: 0x04014499 RID: 83097
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FText> _TextArray;

		// Token: 0x0401449A RID: 83098
		private static IntPtr __SetTextArray_NativeFunctionPtr;

		// Token: 0x0401449B RID: 83099
		private static IntPtr __SetText_NativeFunctionPtr;

		// Token: 0x0401449C RID: 83100
		private static IntPtr __SetStringSet_NativeFunctionPtr;

		// Token: 0x0401449D RID: 83101
		private static IntPtr __SetStringMap_NativeFunctionPtr;

		// Token: 0x0401449E RID: 83102
		private static IntPtr __SetStringArray_NativeFunctionPtr;

		// Token: 0x0401449F RID: 83103
		private static IntPtr __SetString_NativeFunctionPtr;

		// Token: 0x040144A0 RID: 83104
		private static IntPtr __SetNameSet_NativeFunctionPtr;

		// Token: 0x040144A1 RID: 83105
		private static IntPtr __SetNameMap_NativeFunctionPtr;

		// Token: 0x040144A2 RID: 83106
		private static IntPtr __SetNameArray_NativeFunctionPtr;

		// Token: 0x040144A3 RID: 83107
		private static IntPtr __SetName_NativeFunctionPtr;

		// Token: 0x040144A4 RID: 83108
		private static IntPtr __OutTextArray_NativeFunctionPtr;

		// Token: 0x040144A5 RID: 83109
		private static IntPtr __OutText_NativeFunctionPtr;

		// Token: 0x040144A6 RID: 83110
		private static IntPtr __OutStringSet_NativeFunctionPtr;

		// Token: 0x040144A7 RID: 83111
		private static IntPtr __OutStringMap_NativeFunctionPtr;

		// Token: 0x040144A8 RID: 83112
		private static IntPtr __OutStringArray_NativeFunctionPtr;

		// Token: 0x040144A9 RID: 83113
		private static IntPtr __OutString_NativeFunctionPtr;

		// Token: 0x040144AA RID: 83114
		private static IntPtr __OutNameSet_NativeFunctionPtr;

		// Token: 0x040144AB RID: 83115
		private static IntPtr __OutNameMap_NativeFunctionPtr;

		// Token: 0x040144AC RID: 83116
		private static IntPtr __OutNameArray_NativeFunctionPtr;

		// Token: 0x040144AD RID: 83117
		private static IntPtr __OutName_NativeFunctionPtr;

		// Token: 0x040144AE RID: 83118
		private static IntPtr __InTextArray_NativeFunctionPtr;

		// Token: 0x040144AF RID: 83119
		private static IntPtr __InText_NativeFunctionPtr;

		// Token: 0x040144B0 RID: 83120
		private static IntPtr __InStringSet_NativeFunctionPtr;

		// Token: 0x040144B1 RID: 83121
		private static IntPtr __InStringMap_NativeFunctionPtr;

		// Token: 0x040144B2 RID: 83122
		private static IntPtr __InStringArray_NativeFunctionPtr;

		// Token: 0x040144B3 RID: 83123
		private static IntPtr __InString_NativeFunctionPtr;

		// Token: 0x040144B4 RID: 83124
		private static IntPtr __InNameSet_NativeFunctionPtr;

		// Token: 0x040144B5 RID: 83125
		private static IntPtr __InNameMap_NativeFunctionPtr;

		// Token: 0x040144B6 RID: 83126
		private static IntPtr __InNameArray_NativeFunctionPtr;

		// Token: 0x040144B7 RID: 83127
		private static IntPtr __InName_NativeFunctionPtr;

		// Token: 0x040144B8 RID: 83128
		private static IntPtr __GetTextArray_NativeFunctionPtr;

		// Token: 0x040144B9 RID: 83129
		private static IntPtr __GetText_NativeFunctionPtr;

		// Token: 0x040144BA RID: 83130
		private static IntPtr __GetStringSet_NativeFunctionPtr;

		// Token: 0x040144BB RID: 83131
		private static IntPtr __GetStringMap_NativeFunctionPtr;

		// Token: 0x040144BC RID: 83132
		private static IntPtr __GetStringArray_NativeFunctionPtr;

		// Token: 0x040144BD RID: 83133
		private static IntPtr __GetString_NativeFunctionPtr;

		// Token: 0x040144BE RID: 83134
		private static IntPtr __GetNameSet_NativeFunctionPtr;

		// Token: 0x040144BF RID: 83135
		private static IntPtr __GetNameMap_NativeFunctionPtr;

		// Token: 0x040144C0 RID: 83136
		private static IntPtr __GetNameArray_NativeFunctionPtr;

		// Token: 0x040144C1 RID: 83137
		private static IntPtr __GetName_NativeFunctionPtr;

		// Token: 0x02003893 RID: 14483
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetTextArray_FunctionParams
		{
			// Token: 0x040179BA RID: 96698
			[FieldOffset(0)]
			public byte InTextArray;
		}

		// Token: 0x02003894 RID: 14484
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SetText_FunctionParams
		{
			// Token: 0x040179BB RID: 96699
			[FieldOffset(0)]
			public byte InText;
		}

		// Token: 0x02003895 RID: 14485
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetStringSet_FunctionParams
		{
			// Token: 0x040179BC RID: 96700
			[FieldOffset(0)]
			public byte InStringSet;
		}

		// Token: 0x02003896 RID: 14486
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetStringMap_FunctionParams
		{
			// Token: 0x040179BD RID: 96701
			[FieldOffset(0)]
			public byte InStringMap;
		}

		// Token: 0x02003897 RID: 14487
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetStringArray_FunctionParams
		{
			// Token: 0x040179BE RID: 96702
			[FieldOffset(0)]
			public byte InStringArray;
		}

		// Token: 0x02003898 RID: 14488
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetString_FunctionParams
		{
			// Token: 0x040179BF RID: 96703
			[FieldOffset(0)]
			public FString InString;
		}

		// Token: 0x02003899 RID: 14489
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetNameSet_FunctionParams
		{
			// Token: 0x040179C0 RID: 96704
			[FieldOffset(0)]
			public byte InNameSet;
		}

		// Token: 0x0200389A RID: 14490
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetNameMap_FunctionParams
		{
			// Token: 0x040179C1 RID: 96705
			[FieldOffset(0)]
			public byte InNameMap;
		}

		// Token: 0x0200389B RID: 14491
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetNameArray_FunctionParams
		{
			// Token: 0x040179C2 RID: 96706
			[FieldOffset(0)]
			public byte InNameArray;
		}

		// Token: 0x0200389C RID: 14492
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __SetName_FunctionParams
		{
			// Token: 0x040179C3 RID: 96707
			[FieldOffset(0)]
			public FName InName;
		}

		// Token: 0x0200389D RID: 14493
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutTextArray_FunctionParams
		{
			// Token: 0x040179C4 RID: 96708
			[FieldOffset(0)]
			public byte OutTextArray;
		}

		// Token: 0x0200389E RID: 14494
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __OutText_FunctionParams
		{
			// Token: 0x040179C5 RID: 96709
			[FieldOffset(0)]
			public byte OutText;
		}

		// Token: 0x0200389F RID: 14495
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutStringSet_FunctionParams
		{
			// Token: 0x040179C6 RID: 96710
			[FieldOffset(0)]
			public byte OutStringSet;
		}

		// Token: 0x020038A0 RID: 14496
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutStringMap_FunctionParams
		{
			// Token: 0x040179C7 RID: 96711
			[FieldOffset(0)]
			public byte OutStringMap;
		}

		// Token: 0x020038A1 RID: 14497
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutStringArray_FunctionParams
		{
			// Token: 0x040179C8 RID: 96712
			[FieldOffset(0)]
			public byte OutStringArray;
		}

		// Token: 0x020038A2 RID: 14498
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutString_FunctionParams
		{
			// Token: 0x040179C9 RID: 96713
			[FieldOffset(0)]
			public FString OutString;
		}

		// Token: 0x020038A3 RID: 14499
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutNameSet_FunctionParams
		{
			// Token: 0x040179CA RID: 96714
			[FieldOffset(0)]
			public byte OutNameSet;
		}

		// Token: 0x020038A4 RID: 14500
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutNameMap_FunctionParams
		{
			// Token: 0x040179CB RID: 96715
			[FieldOffset(0)]
			public byte OutNameMap;
		}

		// Token: 0x020038A5 RID: 14501
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutNameArray_FunctionParams
		{
			// Token: 0x040179CC RID: 96716
			[FieldOffset(0)]
			public byte OutNameArray;
		}

		// Token: 0x020038A6 RID: 14502
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __OutName_FunctionParams
		{
			// Token: 0x040179CD RID: 96717
			[FieldOffset(0)]
			public FName OutName;
		}

		// Token: 0x020038A7 RID: 14503
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InTextArray_FunctionParams
		{
			// Token: 0x040179CE RID: 96718
			[FieldOffset(0)]
			public byte InTextArray;
		}

		// Token: 0x020038A8 RID: 14504
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __InText_FunctionParams
		{
			// Token: 0x040179CF RID: 96719
			[FieldOffset(0)]
			public byte InText;
		}

		// Token: 0x020038A9 RID: 14505
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InStringSet_FunctionParams
		{
			// Token: 0x040179D0 RID: 96720
			[FieldOffset(0)]
			public byte InStringSet;
		}

		// Token: 0x020038AA RID: 14506
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InStringMap_FunctionParams
		{
			// Token: 0x040179D1 RID: 96721
			[FieldOffset(0)]
			public byte InStringMap;
		}

		// Token: 0x020038AB RID: 14507
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InStringArray_FunctionParams
		{
			// Token: 0x040179D2 RID: 96722
			[FieldOffset(0)]
			public byte InStringArray;
		}

		// Token: 0x020038AC RID: 14508
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InString_FunctionParams
		{
			// Token: 0x040179D3 RID: 96723
			[FieldOffset(0)]
			public FString InString;
		}

		// Token: 0x020038AD RID: 14509
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InNameSet_FunctionParams
		{
			// Token: 0x040179D4 RID: 96724
			[FieldOffset(0)]
			public byte InNameSet;
		}

		// Token: 0x020038AE RID: 14510
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InNameMap_FunctionParams
		{
			// Token: 0x040179D5 RID: 96725
			[FieldOffset(0)]
			public byte InNameMap;
		}

		// Token: 0x020038AF RID: 14511
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InNameArray_FunctionParams
		{
			// Token: 0x040179D6 RID: 96726
			[FieldOffset(0)]
			public byte InNameArray;
		}

		// Token: 0x020038B0 RID: 14512
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InName_FunctionParams
		{
			// Token: 0x040179D7 RID: 96727
			[FieldOffset(0)]
			public FName InName;
		}

		// Token: 0x020038B1 RID: 14513
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetTextArray_FunctionParams
		{
			// Token: 0x040179D8 RID: 96728
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020038B2 RID: 14514
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetText_FunctionParams
		{
			// Token: 0x040179D9 RID: 96729
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020038B3 RID: 14515
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetStringSet_FunctionParams
		{
			// Token: 0x040179DA RID: 96730
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020038B4 RID: 14516
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetStringMap_FunctionParams
		{
			// Token: 0x040179DB RID: 96731
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020038B5 RID: 14517
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetStringArray_FunctionParams
		{
			// Token: 0x040179DC RID: 96732
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020038B6 RID: 14518
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetString_FunctionParams
		{
			// Token: 0x040179DD RID: 96733
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x020038B7 RID: 14519
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetNameSet_FunctionParams
		{
			// Token: 0x040179DE RID: 96734
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020038B8 RID: 14520
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetNameMap_FunctionParams
		{
			// Token: 0x040179DF RID: 96735
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020038B9 RID: 14521
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetNameArray_FunctionParams
		{
			// Token: 0x040179E0 RID: 96736
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020038BA RID: 14522
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetName_FunctionParams
		{
			// Token: 0x040179E1 RID: 96737
			[FieldOffset(0)]
			public FName __Result;
		}
	}
}
