using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007FF RID: 2047
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SharpherealTest.TestClass_UFunction_Direct_String")]
	[UnrealStructLayout(472, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class UTestClass_UFunction_Direct_String : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B228 RID: 45608 RVA: 0x00111E17 File Offset: 0x00110017
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTestClass_UFunction_Direct_String._ClassPtr;
		}

		// Token: 0x0600B229 RID: 45609 RVA: 0x00111E24 File Offset: 0x00110024
		public UTestClass_UFunction_Direct_String() : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_Direct_String.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B22A RID: 45610 RVA: 0x00111E4C File Offset: 0x0011004C
		public UTestClass_UFunction_Direct_String(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_Direct_String.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002172 RID: 8562
		// (get) Token: 0x0600B22B RID: 45611 RVA: 0x00111E7F File Offset: 0x0011007F
		// (set) Token: 0x0600B22C RID: 45612 RVA: 0x00111E93 File Offset: 0x00110093
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

		// Token: 0x17002173 RID: 8563
		// (get) Token: 0x0600B22D RID: 45613 RVA: 0x00111EA8 File Offset: 0x001100A8
		// (set) Token: 0x0600B22E RID: 45614 RVA: 0x00111EE1 File Offset: 0x001100E1
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

		// Token: 0x17002174 RID: 8564
		// (get) Token: 0x0600B22F RID: 45615 RVA: 0x00111EF0 File Offset: 0x001100F0
		// (set) Token: 0x0600B230 RID: 45616 RVA: 0x00111F29 File Offset: 0x00110129
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

		// Token: 0x17002175 RID: 8565
		// (get) Token: 0x0600B231 RID: 45617 RVA: 0x00111F38 File Offset: 0x00110138
		// (set) Token: 0x0600B232 RID: 45618 RVA: 0x00111F71 File Offset: 0x00110171
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

		// Token: 0x17002176 RID: 8566
		// (get) Token: 0x0600B233 RID: 45619 RVA: 0x00111F7F File Offset: 0x0011017F
		// (set) Token: 0x0600B234 RID: 45620 RVA: 0x00111F93 File Offset: 0x00110193
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

		// Token: 0x17002177 RID: 8567
		// (get) Token: 0x0600B235 RID: 45621 RVA: 0x00111FA8 File Offset: 0x001101A8
		// (set) Token: 0x0600B236 RID: 45622 RVA: 0x00111FE1 File Offset: 0x001101E1
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

		// Token: 0x17002178 RID: 8568
		// (get) Token: 0x0600B237 RID: 45623 RVA: 0x00111FF0 File Offset: 0x001101F0
		// (set) Token: 0x0600B238 RID: 45624 RVA: 0x00112029 File Offset: 0x00110229
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

		// Token: 0x17002179 RID: 8569
		// (get) Token: 0x0600B239 RID: 45625 RVA: 0x00112038 File Offset: 0x00110238
		// (set) Token: 0x0600B23A RID: 45626 RVA: 0x00112071 File Offset: 0x00110271
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

		// Token: 0x1700217A RID: 8570
		// (get) Token: 0x0600B23B RID: 45627 RVA: 0x00112080 File Offset: 0x00110280
		// (set) Token: 0x0600B23C RID: 45628 RVA: 0x001120B9 File Offset: 0x001102B9
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

		// Token: 0x1700217B RID: 8571
		// (get) Token: 0x0600B23D RID: 45629 RVA: 0x001120D4 File Offset: 0x001102D4
		// (set) Token: 0x0600B23E RID: 45630 RVA: 0x0011210D File Offset: 0x0011030D
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

		// Token: 0x0600B23F RID: 45631 RVA: 0x0011211C File Offset: 0x0011031C
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__SetTextArray_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__SetTextArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B240 RID: 45632 RVA: 0x00112188 File Offset: 0x00110388
		[SkipLocalsInit]
		public unsafe void SetText(FText InText)
		{
			UTestClass_UFunction_Direct_String.__SetText_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__SetText_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__SetText_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__SetText_NativeFunctionPtr, (void*)ptr, 1);
			FText.NativeCopy((void*)(&ptr->InText), InText.NativePtr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__SetText_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__SetText_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B241 RID: 45633 RVA: 0x001121EC File Offset: 0x001103EC
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__SetStringSet_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__SetStringSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B242 RID: 45634 RVA: 0x00112258 File Offset: 0x00110458
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__SetStringMap_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__SetStringMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B243 RID: 45635 RVA: 0x001122C4 File Offset: 0x001104C4
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__SetStringArray_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__SetStringArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B244 RID: 45636 RVA: 0x00112330 File Offset: 0x00110530
		[SkipLocalsInit]
		public unsafe void SetString(string InString)
		{
			UTestClass_UFunction_Direct_String.__SetString_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__SetString_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__SetString_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__SetString_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->InString), InString);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__SetString_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__SetString_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B245 RID: 45637 RVA: 0x00112390 File Offset: 0x00110590
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetNameSet(TSet<FName> InNameSet)
		{
			UTestClass_UFunction_Direct_String.__SetNameSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__SetNameSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__SetNameSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__SetNameSet_NativeFunctionPtr, (void*)ptr, 1);
			if (InNameSet != null)
			{
				InNameSet.CopyTo(&ptr->InNameSet, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__SetNameSet_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__SetNameSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B246 RID: 45638 RVA: 0x001123FC File Offset: 0x001105FC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetNameMap(TMap<FName, int> InNameMap)
		{
			UTestClass_UFunction_Direct_String.__SetNameMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__SetNameMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__SetNameMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__SetNameMap_NativeFunctionPtr, (void*)ptr, 1);
			if (InNameMap != null)
			{
				InNameMap.CopyTo(&ptr->InNameMap, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__SetNameMap_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__SetNameMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B247 RID: 45639 RVA: 0x00112468 File Offset: 0x00110668
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetNameArray(TArray<FName> InNameArray)
		{
			UTestClass_UFunction_Direct_String.__SetNameArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__SetNameArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__SetNameArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__SetNameArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InNameArray != null)
			{
				InNameArray.CopyTo(&ptr->InNameArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__SetNameArray_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__SetNameArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B248 RID: 45640 RVA: 0x001124D4 File Offset: 0x001106D4
		[SkipLocalsInit]
		public unsafe void SetName(FName InName)
		{
			UTestClass_UFunction_Direct_String.__SetName_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__SetName_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__SetName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__SetName_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InName = InName;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__SetName_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B249 RID: 45641 RVA: 0x0011251C File Offset: 0x0011071C
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__OutTextArray_NativeFunctionPtr, (void*)ptr);
			TArray<FText> tarray2 = OutTextArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutTextArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__OutTextArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B24A RID: 45642 RVA: 0x00112594 File Offset: 0x00110794
		[SkipLocalsInit]
		public unsafe void OutText(ref FText OutText)
		{
			UTestClass_UFunction_Direct_String.__OutText_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__OutText_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__OutText_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__OutText_NativeFunctionPtr, (void*)ptr, 1);
			FText.NativeMove((void*)(&ptr->OutText), OutText.NativePtr);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__OutText_NativeFunctionPtr, (void*)ptr);
			FText.NativeMove(OutText.NativePtr, (void*)(&ptr->OutText));
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__OutText_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B24B RID: 45643 RVA: 0x0011260C File Offset: 0x0011080C
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__OutStringSet_NativeFunctionPtr, (void*)ptr);
			TSet<string> tset2 = OutStringSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutStringSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__OutStringSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B24C RID: 45644 RVA: 0x00112684 File Offset: 0x00110884
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__OutStringMap_NativeFunctionPtr, (void*)ptr);
			TMap<string, int> tmap2 = OutStringMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutStringMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__OutStringMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B24D RID: 45645 RVA: 0x001126FC File Offset: 0x001108FC
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__OutStringArray_NativeFunctionPtr, (void*)ptr);
			TArray<string> tarray2 = OutStringArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutStringArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__OutStringArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B24E RID: 45646 RVA: 0x00112774 File Offset: 0x00110974
		[SkipLocalsInit]
		public unsafe void OutString(ref string OutString)
		{
			UTestClass_UFunction_Direct_String.__OutString_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__OutString_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__OutString_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__OutString_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->OutString), OutString);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__OutString_NativeFunctionPtr, (void*)ptr);
			OutString = FString.ToString((void*)(&ptr->OutString));
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__OutString_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B24F RID: 45647 RVA: 0x001127E0 File Offset: 0x001109E0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutNameSet(ref TSet<FName> OutNameSet)
		{
			UTestClass_UFunction_Direct_String.__OutNameSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__OutNameSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__OutNameSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__OutNameSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<FName> tset = OutNameSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutNameSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__OutNameSet_NativeFunctionPtr, (void*)ptr);
			TSet<FName> tset2 = OutNameSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutNameSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__OutNameSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B250 RID: 45648 RVA: 0x00112858 File Offset: 0x00110A58
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutNameMap(ref TMap<FName, int> OutNameMap)
		{
			UTestClass_UFunction_Direct_String.__OutNameMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__OutNameMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__OutNameMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__OutNameMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, int> tmap = OutNameMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutNameMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__OutNameMap_NativeFunctionPtr, (void*)ptr);
			TMap<FName, int> tmap2 = OutNameMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutNameMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__OutNameMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B251 RID: 45649 RVA: 0x001128D0 File Offset: 0x00110AD0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutNameArray(ref TArray<FName> OutNameArray)
		{
			UTestClass_UFunction_Direct_String.__OutNameArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__OutNameArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__OutNameArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__OutNameArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FName> tarray = OutNameArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutNameArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__OutNameArray_NativeFunctionPtr, (void*)ptr);
			TArray<FName> tarray2 = OutNameArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutNameArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__OutNameArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B252 RID: 45650 RVA: 0x00112948 File Offset: 0x00110B48
		[SkipLocalsInit]
		public unsafe void OutName(ref FName OutName)
		{
			UTestClass_UFunction_Direct_String.__OutName_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__OutName_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__OutName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__OutName_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutName = OutName;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__OutName_NativeFunctionPtr, (void*)ptr);
			OutName = ptr->OutName;
		}

		// Token: 0x0600B253 RID: 45651 RVA: 0x001129A0 File Offset: 0x00110BA0
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__InTextArray_NativeFunctionPtr, (void*)ptr);
			TArray<FText> tarray2 = InTextArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InTextArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__InTextArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B254 RID: 45652 RVA: 0x00112A18 File Offset: 0x00110C18
		[SkipLocalsInit]
		public unsafe void InText(in FText InText)
		{
			UTestClass_UFunction_Direct_String.__InText_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__InText_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__InText_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__InText_NativeFunctionPtr, (void*)ptr, 1);
			FText.NativeMove((void*)(&ptr->InText), InText.NativePtr);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__InText_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__InText_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B255 RID: 45653 RVA: 0x00112A7C File Offset: 0x00110C7C
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__InStringSet_NativeFunctionPtr, (void*)ptr);
			TSet<string> tset2 = InStringSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InStringSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__InStringSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B256 RID: 45654 RVA: 0x00112AF4 File Offset: 0x00110CF4
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__InStringMap_NativeFunctionPtr, (void*)ptr);
			TMap<string, int> tmap2 = InStringMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InStringMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__InStringMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B257 RID: 45655 RVA: 0x00112B6C File Offset: 0x00110D6C
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__InStringArray_NativeFunctionPtr, (void*)ptr);
			TArray<string> tarray2 = InStringArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InStringArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__InStringArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B258 RID: 45656 RVA: 0x00112BE4 File Offset: 0x00110DE4
		[SkipLocalsInit]
		public unsafe void InString(in string InString)
		{
			UTestClass_UFunction_Direct_String.__InString_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__InString_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__InString_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__InString_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->InString), InString);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__InString_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__InString_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B259 RID: 45657 RVA: 0x00112C44 File Offset: 0x00110E44
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InNameSet(in TSet<FName> InNameSet)
		{
			UTestClass_UFunction_Direct_String.__InNameSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__InNameSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__InNameSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__InNameSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<FName> tset = InNameSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InNameSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__InNameSet_NativeFunctionPtr, (void*)ptr);
			TSet<FName> tset2 = InNameSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InNameSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__InNameSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B25A RID: 45658 RVA: 0x00112CBC File Offset: 0x00110EBC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InNameMap(in TMap<FName, int> InNameMap)
		{
			UTestClass_UFunction_Direct_String.__InNameMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__InNameMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__InNameMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__InNameMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, int> tmap = InNameMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InNameMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__InNameMap_NativeFunctionPtr, (void*)ptr);
			TMap<FName, int> tmap2 = InNameMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InNameMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__InNameMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B25B RID: 45659 RVA: 0x00112D34 File Offset: 0x00110F34
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InNameArray(in TArray<FName> InNameArray)
		{
			UTestClass_UFunction_Direct_String.__InNameArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__InNameArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__InNameArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__InNameArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FName> tarray = InNameArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InNameArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__InNameArray_NativeFunctionPtr, (void*)ptr);
			TArray<FName> tarray2 = InNameArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InNameArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__InNameArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B25C RID: 45660 RVA: 0x00112DAC File Offset: 0x00110FAC
		[SkipLocalsInit]
		public unsafe void InName(in FName InName)
		{
			UTestClass_UFunction_Direct_String.__InName_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__InName_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__InName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__InName_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InName = InName;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__InName_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B25D RID: 45661 RVA: 0x00112DF8 File Offset: 0x00110FF8
		[SkipLocalsInit]
		public unsafe TArray<FText> GetTextArray()
		{
			UTestClass_UFunction_Direct_String.__GetTextArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__GetTextArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__GetTextArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__GetTextArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__GetTextArray_NativeFunctionPtr, (void*)ptr);
			TArray<FText> result = new TArray<FText>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__GetTextArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B25E RID: 45662 RVA: 0x00112E58 File Offset: 0x00111058
		[SkipLocalsInit]
		public unsafe FText GetText()
		{
			UTestClass_UFunction_Direct_String.__GetText_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__GetText_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__GetText_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__GetText_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__GetText_NativeFunctionPtr, (void*)ptr);
			FText result = new FText(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__GetText_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B25F RID: 45663 RVA: 0x00112EB8 File Offset: 0x001110B8
		[SkipLocalsInit]
		public unsafe TSet<string> GetStringSet()
		{
			UTestClass_UFunction_Direct_String.__GetStringSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__GetStringSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__GetStringSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__GetStringSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__GetStringSet_NativeFunctionPtr, (void*)ptr);
			TSet<string> result = new TSet<string>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__GetStringSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B260 RID: 45664 RVA: 0x00112F18 File Offset: 0x00111118
		[SkipLocalsInit]
		public unsafe TMap<string, int> GetStringMap()
		{
			UTestClass_UFunction_Direct_String.__GetStringMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__GetStringMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__GetStringMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__GetStringMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__GetStringMap_NativeFunctionPtr, (void*)ptr);
			TMap<string, int> result = new TMap<string, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__GetStringMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B261 RID: 45665 RVA: 0x00112F78 File Offset: 0x00111178
		[SkipLocalsInit]
		public unsafe TArray<string> GetStringArray()
		{
			UTestClass_UFunction_Direct_String.__GetStringArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__GetStringArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__GetStringArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__GetStringArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__GetStringArray_NativeFunctionPtr, (void*)ptr);
			TArray<string> result = new TArray<string>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__GetStringArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B262 RID: 45666 RVA: 0x00112FD8 File Offset: 0x001111D8
		[SkipLocalsInit]
		public unsafe string GetString()
		{
			UTestClass_UFunction_Direct_String.__GetString_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__GetString_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__GetString_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__GetString_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__GetString_NativeFunctionPtr, (void*)ptr);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__GetString_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B263 RID: 45667 RVA: 0x00113034 File Offset: 0x00111234
		[SkipLocalsInit]
		public unsafe TSet<FName> GetNameSet()
		{
			UTestClass_UFunction_Direct_String.__GetNameSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__GetNameSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__GetNameSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__GetNameSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__GetNameSet_NativeFunctionPtr, (void*)ptr);
			TSet<FName> result = new TSet<FName>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__GetNameSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B264 RID: 45668 RVA: 0x00113094 File Offset: 0x00111294
		[SkipLocalsInit]
		public unsafe TMap<FName, int> GetNameMap()
		{
			UTestClass_UFunction_Direct_String.__GetNameMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__GetNameMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__GetNameMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__GetNameMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__GetNameMap_NativeFunctionPtr, (void*)ptr);
			TMap<FName, int> result = new TMap<FName, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__GetNameMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B265 RID: 45669 RVA: 0x001130F4 File Offset: 0x001112F4
		[SkipLocalsInit]
		public unsafe TArray<FName> GetNameArray()
		{
			UTestClass_UFunction_Direct_String.__GetNameArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__GetNameArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__GetNameArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__GetNameArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__GetNameArray_NativeFunctionPtr, (void*)ptr);
			TArray<FName> result = new TArray<FName>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_String.__GetNameArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B266 RID: 45670 RVA: 0x00113154 File Offset: 0x00111354
		[SkipLocalsInit]
		public new unsafe FName GetName()
		{
			UTestClass_UFunction_Direct_String.__GetName_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_String.__GetName_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UTestClass_UFunction_Direct_String.__GetName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_String.__GetName_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_String.__GetName_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B267 RID: 45671 RVA: 0x00113199 File Offset: 0x00111399
		static UTestClass_UFunction_Direct_String()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SharpherealTest.TestClass_UFunction_Direct_String");
		}

		// Token: 0x0600B268 RID: 45672 RVA: 0x001131A7 File Offset: 0x001113A7
		protected UTestClass_UFunction_Direct_String(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004EE4 RID: 20196
		public new const string __ObjectPath = "/Script/SharpherealTest.TestClass_UFunction_Direct_String";

		// Token: 0x04004EE5 RID: 20197
		private static IntPtr _ClassPtr;

		// Token: 0x04004EE6 RID: 20198
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004EE7 RID: 20199
		internal static int __PropertyOffset_String;

		// Token: 0x04004EE8 RID: 20200
		internal static int __PropertyOffset_StringArray;

		// Token: 0x04004EE9 RID: 20201
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _StringArray;

		// Token: 0x04004EEA RID: 20202
		internal static int __PropertyOffset_StringSet;

		// Token: 0x04004EEB RID: 20203
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<string> _StringSet;

		// Token: 0x04004EEC RID: 20204
		internal static int __PropertyOffset_StringMap;

		// Token: 0x04004EED RID: 20205
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, int> _StringMap;

		// Token: 0x04004EEE RID: 20206
		internal static int __PropertyOffset_Name;

		// Token: 0x04004EEF RID: 20207
		internal static int __PropertyOffset_NameArray;

		// Token: 0x04004EF0 RID: 20208
		[Nullable(2)]
		private TArray<FName> _NameArray;

		// Token: 0x04004EF1 RID: 20209
		internal static int __PropertyOffset_NameSet;

		// Token: 0x04004EF2 RID: 20210
		[Nullable(2)]
		private TSet<FName> _NameSet;

		// Token: 0x04004EF3 RID: 20211
		internal static int __PropertyOffset_NameMap;

		// Token: 0x04004EF4 RID: 20212
		[Nullable(2)]
		private TMap<FName, int> _NameMap;

		// Token: 0x04004EF5 RID: 20213
		internal static int __PropertyOffset_Text;

		// Token: 0x04004EF6 RID: 20214
		[Nullable(2)]
		private FText _Text;

		// Token: 0x04004EF7 RID: 20215
		internal static int __PropertyOffset_TextArray;

		// Token: 0x04004EF8 RID: 20216
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FText> _TextArray;

		// Token: 0x04004EF9 RID: 20217
		private static IntPtr __SetTextArray_NativeFunctionPtr;

		// Token: 0x04004EFA RID: 20218
		private static IntPtr __SetText_NativeFunctionPtr;

		// Token: 0x04004EFB RID: 20219
		private static IntPtr __SetStringSet_NativeFunctionPtr;

		// Token: 0x04004EFC RID: 20220
		private static IntPtr __SetStringMap_NativeFunctionPtr;

		// Token: 0x04004EFD RID: 20221
		private static IntPtr __SetStringArray_NativeFunctionPtr;

		// Token: 0x04004EFE RID: 20222
		private static IntPtr __SetString_NativeFunctionPtr;

		// Token: 0x04004EFF RID: 20223
		private static IntPtr __SetNameSet_NativeFunctionPtr;

		// Token: 0x04004F00 RID: 20224
		private static IntPtr __SetNameMap_NativeFunctionPtr;

		// Token: 0x04004F01 RID: 20225
		private static IntPtr __SetNameArray_NativeFunctionPtr;

		// Token: 0x04004F02 RID: 20226
		private static IntPtr __SetName_NativeFunctionPtr;

		// Token: 0x04004F03 RID: 20227
		private static IntPtr __OutTextArray_NativeFunctionPtr;

		// Token: 0x04004F04 RID: 20228
		private static IntPtr __OutText_NativeFunctionPtr;

		// Token: 0x04004F05 RID: 20229
		private static IntPtr __OutStringSet_NativeFunctionPtr;

		// Token: 0x04004F06 RID: 20230
		private static IntPtr __OutStringMap_NativeFunctionPtr;

		// Token: 0x04004F07 RID: 20231
		private static IntPtr __OutStringArray_NativeFunctionPtr;

		// Token: 0x04004F08 RID: 20232
		private static IntPtr __OutString_NativeFunctionPtr;

		// Token: 0x04004F09 RID: 20233
		private static IntPtr __OutNameSet_NativeFunctionPtr;

		// Token: 0x04004F0A RID: 20234
		private static IntPtr __OutNameMap_NativeFunctionPtr;

		// Token: 0x04004F0B RID: 20235
		private static IntPtr __OutNameArray_NativeFunctionPtr;

		// Token: 0x04004F0C RID: 20236
		private static IntPtr __OutName_NativeFunctionPtr;

		// Token: 0x04004F0D RID: 20237
		private static IntPtr __InTextArray_NativeFunctionPtr;

		// Token: 0x04004F0E RID: 20238
		private static IntPtr __InText_NativeFunctionPtr;

		// Token: 0x04004F0F RID: 20239
		private static IntPtr __InStringSet_NativeFunctionPtr;

		// Token: 0x04004F10 RID: 20240
		private static IntPtr __InStringMap_NativeFunctionPtr;

		// Token: 0x04004F11 RID: 20241
		private static IntPtr __InStringArray_NativeFunctionPtr;

		// Token: 0x04004F12 RID: 20242
		private static IntPtr __InString_NativeFunctionPtr;

		// Token: 0x04004F13 RID: 20243
		private static IntPtr __InNameSet_NativeFunctionPtr;

		// Token: 0x04004F14 RID: 20244
		private static IntPtr __InNameMap_NativeFunctionPtr;

		// Token: 0x04004F15 RID: 20245
		private static IntPtr __InNameArray_NativeFunctionPtr;

		// Token: 0x04004F16 RID: 20246
		private static IntPtr __InName_NativeFunctionPtr;

		// Token: 0x04004F17 RID: 20247
		private static IntPtr __GetTextArray_NativeFunctionPtr;

		// Token: 0x04004F18 RID: 20248
		private static IntPtr __GetText_NativeFunctionPtr;

		// Token: 0x04004F19 RID: 20249
		private static IntPtr __GetStringSet_NativeFunctionPtr;

		// Token: 0x04004F1A RID: 20250
		private static IntPtr __GetStringMap_NativeFunctionPtr;

		// Token: 0x04004F1B RID: 20251
		private static IntPtr __GetStringArray_NativeFunctionPtr;

		// Token: 0x04004F1C RID: 20252
		private static IntPtr __GetString_NativeFunctionPtr;

		// Token: 0x04004F1D RID: 20253
		private static IntPtr __GetNameSet_NativeFunctionPtr;

		// Token: 0x04004F1E RID: 20254
		private static IntPtr __GetNameMap_NativeFunctionPtr;

		// Token: 0x04004F1F RID: 20255
		private static IntPtr __GetNameArray_NativeFunctionPtr;

		// Token: 0x04004F20 RID: 20256
		private static IntPtr __GetName_NativeFunctionPtr;

		// Token: 0x02001165 RID: 4453
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetTextArray_FunctionParams
		{
			// Token: 0x0400656D RID: 25965
			[FieldOffset(0)]
			public byte InTextArray;
		}

		// Token: 0x02001166 RID: 4454
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SetText_FunctionParams
		{
			// Token: 0x0400656E RID: 25966
			[FieldOffset(0)]
			public byte InText;
		}

		// Token: 0x02001167 RID: 4455
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetStringSet_FunctionParams
		{
			// Token: 0x0400656F RID: 25967
			[FieldOffset(0)]
			public byte InStringSet;
		}

		// Token: 0x02001168 RID: 4456
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetStringMap_FunctionParams
		{
			// Token: 0x04006570 RID: 25968
			[FieldOffset(0)]
			public byte InStringMap;
		}

		// Token: 0x02001169 RID: 4457
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetStringArray_FunctionParams
		{
			// Token: 0x04006571 RID: 25969
			[FieldOffset(0)]
			public byte InStringArray;
		}

		// Token: 0x0200116A RID: 4458
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetString_FunctionParams
		{
			// Token: 0x04006572 RID: 25970
			[FieldOffset(0)]
			public FString InString;
		}

		// Token: 0x0200116B RID: 4459
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetNameSet_FunctionParams
		{
			// Token: 0x04006573 RID: 25971
			[FieldOffset(0)]
			public byte InNameSet;
		}

		// Token: 0x0200116C RID: 4460
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetNameMap_FunctionParams
		{
			// Token: 0x04006574 RID: 25972
			[FieldOffset(0)]
			public byte InNameMap;
		}

		// Token: 0x0200116D RID: 4461
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetNameArray_FunctionParams
		{
			// Token: 0x04006575 RID: 25973
			[FieldOffset(0)]
			public byte InNameArray;
		}

		// Token: 0x0200116E RID: 4462
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __SetName_FunctionParams
		{
			// Token: 0x04006576 RID: 25974
			[FieldOffset(0)]
			public FName InName;
		}

		// Token: 0x0200116F RID: 4463
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutTextArray_FunctionParams
		{
			// Token: 0x04006577 RID: 25975
			[FieldOffset(0)]
			public byte OutTextArray;
		}

		// Token: 0x02001170 RID: 4464
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __OutText_FunctionParams
		{
			// Token: 0x04006578 RID: 25976
			[FieldOffset(0)]
			public byte OutText;
		}

		// Token: 0x02001171 RID: 4465
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutStringSet_FunctionParams
		{
			// Token: 0x04006579 RID: 25977
			[FieldOffset(0)]
			public byte OutStringSet;
		}

		// Token: 0x02001172 RID: 4466
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutStringMap_FunctionParams
		{
			// Token: 0x0400657A RID: 25978
			[FieldOffset(0)]
			public byte OutStringMap;
		}

		// Token: 0x02001173 RID: 4467
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutStringArray_FunctionParams
		{
			// Token: 0x0400657B RID: 25979
			[FieldOffset(0)]
			public byte OutStringArray;
		}

		// Token: 0x02001174 RID: 4468
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutString_FunctionParams
		{
			// Token: 0x0400657C RID: 25980
			[FieldOffset(0)]
			public FString OutString;
		}

		// Token: 0x02001175 RID: 4469
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutNameSet_FunctionParams
		{
			// Token: 0x0400657D RID: 25981
			[FieldOffset(0)]
			public byte OutNameSet;
		}

		// Token: 0x02001176 RID: 4470
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutNameMap_FunctionParams
		{
			// Token: 0x0400657E RID: 25982
			[FieldOffset(0)]
			public byte OutNameMap;
		}

		// Token: 0x02001177 RID: 4471
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutNameArray_FunctionParams
		{
			// Token: 0x0400657F RID: 25983
			[FieldOffset(0)]
			public byte OutNameArray;
		}

		// Token: 0x02001178 RID: 4472
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __OutName_FunctionParams
		{
			// Token: 0x04006580 RID: 25984
			[FieldOffset(0)]
			public FName OutName;
		}

		// Token: 0x02001179 RID: 4473
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InTextArray_FunctionParams
		{
			// Token: 0x04006581 RID: 25985
			[FieldOffset(0)]
			public byte InTextArray;
		}

		// Token: 0x0200117A RID: 4474
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __InText_FunctionParams
		{
			// Token: 0x04006582 RID: 25986
			[FieldOffset(0)]
			public byte InText;
		}

		// Token: 0x0200117B RID: 4475
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InStringSet_FunctionParams
		{
			// Token: 0x04006583 RID: 25987
			[FieldOffset(0)]
			public byte InStringSet;
		}

		// Token: 0x0200117C RID: 4476
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InStringMap_FunctionParams
		{
			// Token: 0x04006584 RID: 25988
			[FieldOffset(0)]
			public byte InStringMap;
		}

		// Token: 0x0200117D RID: 4477
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InStringArray_FunctionParams
		{
			// Token: 0x04006585 RID: 25989
			[FieldOffset(0)]
			public byte InStringArray;
		}

		// Token: 0x0200117E RID: 4478
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InString_FunctionParams
		{
			// Token: 0x04006586 RID: 25990
			[FieldOffset(0)]
			public FString InString;
		}

		// Token: 0x0200117F RID: 4479
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InNameSet_FunctionParams
		{
			// Token: 0x04006587 RID: 25991
			[FieldOffset(0)]
			public byte InNameSet;
		}

		// Token: 0x02001180 RID: 4480
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InNameMap_FunctionParams
		{
			// Token: 0x04006588 RID: 25992
			[FieldOffset(0)]
			public byte InNameMap;
		}

		// Token: 0x02001181 RID: 4481
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InNameArray_FunctionParams
		{
			// Token: 0x04006589 RID: 25993
			[FieldOffset(0)]
			public byte InNameArray;
		}

		// Token: 0x02001182 RID: 4482
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InName_FunctionParams
		{
			// Token: 0x0400658A RID: 25994
			[FieldOffset(0)]
			public FName InName;
		}

		// Token: 0x02001183 RID: 4483
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetTextArray_FunctionParams
		{
			// Token: 0x0400658B RID: 25995
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001184 RID: 4484
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetText_FunctionParams
		{
			// Token: 0x0400658C RID: 25996
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001185 RID: 4485
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetStringSet_FunctionParams
		{
			// Token: 0x0400658D RID: 25997
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001186 RID: 4486
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetStringMap_FunctionParams
		{
			// Token: 0x0400658E RID: 25998
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001187 RID: 4487
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetStringArray_FunctionParams
		{
			// Token: 0x0400658F RID: 25999
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001188 RID: 4488
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetString_FunctionParams
		{
			// Token: 0x04006590 RID: 26000
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02001189 RID: 4489
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetNameSet_FunctionParams
		{
			// Token: 0x04006591 RID: 26001
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200118A RID: 4490
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetNameMap_FunctionParams
		{
			// Token: 0x04006592 RID: 26002
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200118B RID: 4491
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetNameArray_FunctionParams
		{
			// Token: 0x04006593 RID: 26003
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200118C RID: 4492
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetName_FunctionParams
		{
			// Token: 0x04006594 RID: 26004
			[FieldOffset(0)]
			public FName __Result;
		}
	}
}
