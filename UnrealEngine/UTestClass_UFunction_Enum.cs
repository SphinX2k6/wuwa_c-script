using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000802 RID: 2050
	[UnrealObjectPath("/Script/SharpherealTest.TestClass_UFunction_Enum")]
	[UnrealStructLayout(416, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 416)]
	public class UTestClass_UFunction_Enum : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B349 RID: 45897 RVA: 0x00117421 File Offset: 0x00115621
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTestClass_UFunction_Enum._ClassPtr;
		}

		// Token: 0x0600B34A RID: 45898 RVA: 0x00117430 File Offset: 0x00115630
		public UTestClass_UFunction_Enum() : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_Enum.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B34B RID: 45899 RVA: 0x00117458 File Offset: 0x00115658
		[NullableContext(1)]
		public UTestClass_UFunction_Enum(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_Enum.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170021A6 RID: 8614
		// (get) Token: 0x0600B34C RID: 45900 RVA: 0x0011748B File Offset: 0x0011568B
		// (set) Token: 0x0600B34D RID: 45901 RVA: 0x0011749F File Offset: 0x0011569F
		public unsafe TEnumAsByte<FSharpherealTestCEnum> EnumAsByte
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_Enum.__PropertyOffset_EnumAsByte);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_Enum.__PropertyOffset_EnumAsByte) = value;
			}
		}

		// Token: 0x170021A7 RID: 8615
		// (get) Token: 0x0600B34E RID: 45902 RVA: 0x001174B4 File Offset: 0x001156B4
		// (set) Token: 0x0600B34F RID: 45903 RVA: 0x001174ED File Offset: 0x001156ED
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<FSharpherealTestCEnum>> EnumAsByteArray
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<FSharpherealTestCEnum>> result;
				if ((result = this._EnumAsByteArray) == null)
				{
					result = (this._EnumAsByteArray = new TArray<TEnumAsByte<FSharpherealTestCEnum>>(base.NativePtr + (IntPtr)UTestClass_UFunction_Enum.__PropertyOffset_EnumAsByteArray, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.EnumAsByteArray.CopyAssign(value);
			}
		}

		// Token: 0x170021A8 RID: 8616
		// (get) Token: 0x0600B350 RID: 45904 RVA: 0x001174FC File Offset: 0x001156FC
		// (set) Token: 0x0600B351 RID: 45905 RVA: 0x00117535 File Offset: 0x00115735
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TSet<TEnumAsByte<FSharpherealTestCEnum>> EnumAsByteSet
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TSet<TEnumAsByte<FSharpherealTestCEnum>> result;
				if ((result = this._EnumAsByteSet) == null)
				{
					result = (this._EnumAsByteSet = new TSet<TEnumAsByte<FSharpherealTestCEnum>>(base.NativePtr + (IntPtr)UTestClass_UFunction_Enum.__PropertyOffset_EnumAsByteSet, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.EnumAsByteSet.CopyAssign(value);
			}
		}

		// Token: 0x170021A9 RID: 8617
		// (get) Token: 0x0600B352 RID: 45906 RVA: 0x00117544 File Offset: 0x00115744
		// (set) Token: 0x0600B353 RID: 45907 RVA: 0x0011757D File Offset: 0x0011577D
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TMap<TEnumAsByte<FSharpherealTestCEnum>, int> EnumAsByteMap
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<FSharpherealTestCEnum>, int> result;
				if ((result = this._EnumAsByteMap) == null)
				{
					result = (this._EnumAsByteMap = new TMap<TEnumAsByte<FSharpherealTestCEnum>, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_Enum.__PropertyOffset_EnumAsByteMap, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.EnumAsByteMap.CopyAssign(value);
			}
		}

		// Token: 0x170021AA RID: 8618
		// (get) Token: 0x0600B354 RID: 45908 RVA: 0x0011758B File Offset: 0x0011578B
		// (set) Token: 0x0600B355 RID: 45909 RVA: 0x0011759B File Offset: 0x0011579B
		public unsafe FSharpherealTestEnum Enum
		{
			get
			{
				return (FSharpherealTestEnum)(*(base.NativePtr + (IntPtr)UTestClass_UFunction_Enum.__PropertyOffset_Enum));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_Enum.__PropertyOffset_Enum) = (byte)value;
			}
		}

		// Token: 0x170021AB RID: 8619
		// (get) Token: 0x0600B356 RID: 45910 RVA: 0x001175AC File Offset: 0x001157AC
		// (set) Token: 0x0600B357 RID: 45911 RVA: 0x001175E5 File Offset: 0x001157E5
		[Nullable(1)]
		public TArray<FSharpherealTestEnum> EnumArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FSharpherealTestEnum> result;
				if ((result = this._EnumArray) == null)
				{
					result = (this._EnumArray = new TArray<FSharpherealTestEnum>(base.NativePtr + (IntPtr)UTestClass_UFunction_Enum.__PropertyOffset_EnumArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.EnumArray.CopyAssign(value);
			}
		}

		// Token: 0x170021AC RID: 8620
		// (get) Token: 0x0600B358 RID: 45912 RVA: 0x001175F4 File Offset: 0x001157F4
		// (set) Token: 0x0600B359 RID: 45913 RVA: 0x0011762D File Offset: 0x0011582D
		[Nullable(1)]
		public TSet<FSharpherealTestEnum> EnumSet
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TSet<FSharpherealTestEnum> result;
				if ((result = this._EnumSet) == null)
				{
					result = (this._EnumSet = new TSet<FSharpherealTestEnum>(base.NativePtr + (IntPtr)UTestClass_UFunction_Enum.__PropertyOffset_EnumSet, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.EnumSet.CopyAssign(value);
			}
		}

		// Token: 0x170021AD RID: 8621
		// (get) Token: 0x0600B35A RID: 45914 RVA: 0x0011763C File Offset: 0x0011583C
		// (set) Token: 0x0600B35B RID: 45915 RVA: 0x00117675 File Offset: 0x00115875
		[Nullable(1)]
		public TMap<FSharpherealTestEnum, int> EnumMap
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FSharpherealTestEnum, int> result;
				if ((result = this._EnumMap) == null)
				{
					result = (this._EnumMap = new TMap<FSharpherealTestEnum, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_Enum.__PropertyOffset_EnumMap, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.EnumMap.CopyAssign(value);
			}
		}

		// Token: 0x0600B35C RID: 45916 RVA: 0x00117684 File Offset: 0x00115884
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetEnumSet(TSet<FSharpherealTestEnum> InEnumSet)
		{
			UTestClass_UFunction_Enum.__SetEnumSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__SetEnumSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__SetEnumSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__SetEnumSet_NativeFunctionPtr, (void*)ptr, 1);
			if (InEnumSet != null)
			{
				InEnumSet.CopyTo(&ptr->InEnumSet, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__SetEnumSet_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__SetEnumSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B35D RID: 45917 RVA: 0x001176F0 File Offset: 0x001158F0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetEnumMap(TMap<FSharpherealTestEnum, int> InEnumMap)
		{
			UTestClass_UFunction_Enum.__SetEnumMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__SetEnumMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__SetEnumMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__SetEnumMap_NativeFunctionPtr, (void*)ptr, 1);
			if (InEnumMap != null)
			{
				InEnumMap.CopyTo(&ptr->InEnumMap, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__SetEnumMap_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__SetEnumMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B35E RID: 45918 RVA: 0x0011775C File Offset: 0x0011595C
		[SkipLocalsInit]
		public unsafe void SetEnumAsByteSet([Nullable(new byte[]
		{
			2,
			0
		})] TSet<TEnumAsByte<FSharpherealTestCEnum>> InEnumAsByteSet)
		{
			UTestClass_UFunction_Enum.__SetEnumAsByteSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__SetEnumAsByteSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__SetEnumAsByteSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__SetEnumAsByteSet_NativeFunctionPtr, (void*)ptr, 1);
			if (InEnumAsByteSet != null)
			{
				InEnumAsByteSet.CopyTo(&ptr->InEnumAsByteSet, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__SetEnumAsByteSet_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__SetEnumAsByteSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B35F RID: 45919 RVA: 0x001177C8 File Offset: 0x001159C8
		[SkipLocalsInit]
		public unsafe void SetEnumAsByteMap([Nullable(new byte[]
		{
			2,
			0
		})] TMap<TEnumAsByte<FSharpherealTestCEnum>, int> InEnumAsByteMap)
		{
			UTestClass_UFunction_Enum.__SetEnumAsByteMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__SetEnumAsByteMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__SetEnumAsByteMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__SetEnumAsByteMap_NativeFunctionPtr, (void*)ptr, 1);
			if (InEnumAsByteMap != null)
			{
				InEnumAsByteMap.CopyTo(&ptr->InEnumAsByteMap, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__SetEnumAsByteMap_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__SetEnumAsByteMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B360 RID: 45920 RVA: 0x00117834 File Offset: 0x00115A34
		[SkipLocalsInit]
		public unsafe void SetEnumAsByteArray([Nullable(new byte[]
		{
			2,
			0
		})] TArray<TEnumAsByte<FSharpherealTestCEnum>> InEnumAsByteArray)
		{
			UTestClass_UFunction_Enum.__SetEnumAsByteArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__SetEnumAsByteArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__SetEnumAsByteArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__SetEnumAsByteArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InEnumAsByteArray != null)
			{
				InEnumAsByteArray.CopyTo(&ptr->InEnumAsByteArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__SetEnumAsByteArray_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__SetEnumAsByteArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B361 RID: 45921 RVA: 0x001178A0 File Offset: 0x00115AA0
		[SkipLocalsInit]
		public unsafe void SetEnumAsByte(FSharpherealTestCEnum InEnumAsByte)
		{
			UTestClass_UFunction_Enum.__SetEnumAsByte_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__SetEnumAsByte_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__SetEnumAsByte_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__SetEnumAsByte_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InEnumAsByte = InEnumAsByte;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__SetEnumAsByte_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B362 RID: 45922 RVA: 0x001178EC File Offset: 0x00115AEC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetEnumArray(TArray<FSharpherealTestEnum> InEnumArray)
		{
			UTestClass_UFunction_Enum.__SetEnumArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__SetEnumArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__SetEnumArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__SetEnumArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InEnumArray != null)
			{
				InEnumArray.CopyTo(&ptr->InEnumArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__SetEnumArray_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__SetEnumArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B363 RID: 45923 RVA: 0x00117958 File Offset: 0x00115B58
		[SkipLocalsInit]
		public unsafe void SetEnum(FSharpherealTestEnum InEnum)
		{
			UTestClass_UFunction_Enum.__SetEnum_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__SetEnum_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__SetEnum_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__SetEnum_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InEnum = InEnum;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__SetEnum_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B364 RID: 45924 RVA: 0x001179A0 File Offset: 0x00115BA0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutEnumSet(ref TSet<FSharpherealTestEnum> OutEnumSet)
		{
			UTestClass_UFunction_Enum.__OutEnumSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__OutEnumSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__OutEnumSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__OutEnumSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<FSharpherealTestEnum> tset = OutEnumSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutEnumSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__OutEnumSet_NativeFunctionPtr, (void*)ptr);
			TSet<FSharpherealTestEnum> tset2 = OutEnumSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutEnumSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__OutEnumSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B365 RID: 45925 RVA: 0x00117A18 File Offset: 0x00115C18
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutEnumMap(ref TMap<FSharpherealTestEnum, int> OutEnumMap)
		{
			UTestClass_UFunction_Enum.__OutEnumMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__OutEnumMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__OutEnumMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__OutEnumMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FSharpherealTestEnum, int> tmap = OutEnumMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutEnumMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__OutEnumMap_NativeFunctionPtr, (void*)ptr);
			TMap<FSharpherealTestEnum, int> tmap2 = OutEnumMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutEnumMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__OutEnumMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B366 RID: 45926 RVA: 0x00117A90 File Offset: 0x00115C90
		[SkipLocalsInit]
		public unsafe void OutEnumAsByteSet([Nullable(new byte[]
		{
			2,
			0
		})] ref TSet<TEnumAsByte<FSharpherealTestCEnum>> OutEnumAsByteSet)
		{
			UTestClass_UFunction_Enum.__OutEnumAsByteSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__OutEnumAsByteSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__OutEnumAsByteSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__OutEnumAsByteSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<TEnumAsByte<FSharpherealTestCEnum>> tset = OutEnumAsByteSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutEnumAsByteSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__OutEnumAsByteSet_NativeFunctionPtr, (void*)ptr);
			TSet<TEnumAsByte<FSharpherealTestCEnum>> tset2 = OutEnumAsByteSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutEnumAsByteSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__OutEnumAsByteSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B367 RID: 45927 RVA: 0x00117B08 File Offset: 0x00115D08
		[SkipLocalsInit]
		public unsafe void OutEnumAsByteMap([Nullable(new byte[]
		{
			2,
			0
		})] ref TMap<TEnumAsByte<FSharpherealTestCEnum>, int> OutEnumAsByteMap)
		{
			UTestClass_UFunction_Enum.__OutEnumAsByteMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__OutEnumAsByteMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__OutEnumAsByteMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__OutEnumAsByteMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<TEnumAsByte<FSharpherealTestCEnum>, int> tmap = OutEnumAsByteMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutEnumAsByteMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__OutEnumAsByteMap_NativeFunctionPtr, (void*)ptr);
			TMap<TEnumAsByte<FSharpherealTestCEnum>, int> tmap2 = OutEnumAsByteMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutEnumAsByteMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__OutEnumAsByteMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B368 RID: 45928 RVA: 0x00117B80 File Offset: 0x00115D80
		[SkipLocalsInit]
		public unsafe void OutEnumAsByteArray([Nullable(new byte[]
		{
			2,
			0
		})] ref TArray<TEnumAsByte<FSharpherealTestCEnum>> OutEnumAsByteArray)
		{
			UTestClass_UFunction_Enum.__OutEnumAsByteArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__OutEnumAsByteArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__OutEnumAsByteArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__OutEnumAsByteArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<TEnumAsByte<FSharpherealTestCEnum>> tarray = OutEnumAsByteArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutEnumAsByteArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__OutEnumAsByteArray_NativeFunctionPtr, (void*)ptr);
			TArray<TEnumAsByte<FSharpherealTestCEnum>> tarray2 = OutEnumAsByteArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutEnumAsByteArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__OutEnumAsByteArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B369 RID: 45929 RVA: 0x00117BF8 File Offset: 0x00115DF8
		[SkipLocalsInit]
		public unsafe void OutEnumAsByte(ref FSharpherealTestCEnum OutEnumAsByte)
		{
			UTestClass_UFunction_Enum.__OutEnumAsByte_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__OutEnumAsByte_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__OutEnumAsByte_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__OutEnumAsByte_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutEnumAsByte = OutEnumAsByte;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__OutEnumAsByte_NativeFunctionPtr, (void*)ptr);
			OutEnumAsByte = ptr->OutEnumAsByte;
		}

		// Token: 0x0600B36A RID: 45930 RVA: 0x00117C54 File Offset: 0x00115E54
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutEnumArray(ref TArray<FSharpherealTestEnum> OutEnumArray)
		{
			UTestClass_UFunction_Enum.__OutEnumArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__OutEnumArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__OutEnumArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__OutEnumArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FSharpherealTestEnum> tarray = OutEnumArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutEnumArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__OutEnumArray_NativeFunctionPtr, (void*)ptr);
			TArray<FSharpherealTestEnum> tarray2 = OutEnumArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutEnumArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__OutEnumArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B36B RID: 45931 RVA: 0x00117CCC File Offset: 0x00115ECC
		[SkipLocalsInit]
		public unsafe void OutEnum(ref FSharpherealTestEnum OutEnum)
		{
			UTestClass_UFunction_Enum.__OutEnum_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__OutEnum_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__OutEnum_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__OutEnum_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutEnum = OutEnum;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__OutEnum_NativeFunctionPtr, (void*)ptr);
			OutEnum = ptr->OutEnum;
		}

		// Token: 0x0600B36C RID: 45932 RVA: 0x00117D1C File Offset: 0x00115F1C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InEnumSet(in TSet<FSharpherealTestEnum> InEnumSet)
		{
			UTestClass_UFunction_Enum.__InEnumSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__InEnumSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__InEnumSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__InEnumSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<FSharpherealTestEnum> tset = InEnumSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InEnumSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__InEnumSet_NativeFunctionPtr, (void*)ptr);
			TSet<FSharpherealTestEnum> tset2 = InEnumSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InEnumSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__InEnumSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B36D RID: 45933 RVA: 0x00117D94 File Offset: 0x00115F94
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InEnumMap(in TMap<FSharpherealTestEnum, int> InEnumMap)
		{
			UTestClass_UFunction_Enum.__InEnumMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__InEnumMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__InEnumMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__InEnumMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FSharpherealTestEnum, int> tmap = InEnumMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InEnumMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__InEnumMap_NativeFunctionPtr, (void*)ptr);
			TMap<FSharpherealTestEnum, int> tmap2 = InEnumMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InEnumMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__InEnumMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B36E RID: 45934 RVA: 0x00117E0C File Offset: 0x0011600C
		[SkipLocalsInit]
		public unsafe void InEnumAsByteSet([Nullable(new byte[]
		{
			2,
			0
		})] in TSet<TEnumAsByte<FSharpherealTestCEnum>> InEnumAsByteSet)
		{
			UTestClass_UFunction_Enum.__InEnumAsByteSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__InEnumAsByteSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__InEnumAsByteSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__InEnumAsByteSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<TEnumAsByte<FSharpherealTestCEnum>> tset = InEnumAsByteSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InEnumAsByteSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__InEnumAsByteSet_NativeFunctionPtr, (void*)ptr);
			TSet<TEnumAsByte<FSharpherealTestCEnum>> tset2 = InEnumAsByteSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InEnumAsByteSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__InEnumAsByteSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B36F RID: 45935 RVA: 0x00117E84 File Offset: 0x00116084
		[SkipLocalsInit]
		public unsafe void InEnumAsByteMap([Nullable(new byte[]
		{
			2,
			0
		})] in TMap<TEnumAsByte<FSharpherealTestCEnum>, int> InEnumAsByteMap)
		{
			UTestClass_UFunction_Enum.__InEnumAsByteMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__InEnumAsByteMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__InEnumAsByteMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__InEnumAsByteMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<TEnumAsByte<FSharpherealTestCEnum>, int> tmap = InEnumAsByteMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InEnumAsByteMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__InEnumAsByteMap_NativeFunctionPtr, (void*)ptr);
			TMap<TEnumAsByte<FSharpherealTestCEnum>, int> tmap2 = InEnumAsByteMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InEnumAsByteMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__InEnumAsByteMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B370 RID: 45936 RVA: 0x00117EFC File Offset: 0x001160FC
		[SkipLocalsInit]
		public unsafe void InEnumAsByteArray([Nullable(new byte[]
		{
			2,
			0
		})] in TArray<TEnumAsByte<FSharpherealTestCEnum>> InEnumAsByteArray)
		{
			UTestClass_UFunction_Enum.__InEnumAsByteArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__InEnumAsByteArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__InEnumAsByteArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__InEnumAsByteArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<TEnumAsByte<FSharpherealTestCEnum>> tarray = InEnumAsByteArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InEnumAsByteArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__InEnumAsByteArray_NativeFunctionPtr, (void*)ptr);
			TArray<TEnumAsByte<FSharpherealTestCEnum>> tarray2 = InEnumAsByteArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InEnumAsByteArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__InEnumAsByteArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B371 RID: 45937 RVA: 0x00117F74 File Offset: 0x00116174
		[SkipLocalsInit]
		public unsafe void InEnumAsByte(in FSharpherealTestCEnum InEnumAsByte)
		{
			UTestClass_UFunction_Enum.__InEnumAsByte_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__InEnumAsByte_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__InEnumAsByte_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__InEnumAsByte_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InEnumAsByte = InEnumAsByte;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__InEnumAsByte_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B372 RID: 45938 RVA: 0x00117FC0 File Offset: 0x001161C0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InEnumArray(in TArray<FSharpherealTestEnum> InEnumArray)
		{
			UTestClass_UFunction_Enum.__InEnumArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__InEnumArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__InEnumArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__InEnumArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FSharpherealTestEnum> tarray = InEnumArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InEnumArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__InEnumArray_NativeFunctionPtr, (void*)ptr);
			TArray<FSharpherealTestEnum> tarray2 = InEnumArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InEnumArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__InEnumArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B373 RID: 45939 RVA: 0x00118038 File Offset: 0x00116238
		[SkipLocalsInit]
		public unsafe void InEnum(in FSharpherealTestEnum InEnum)
		{
			UTestClass_UFunction_Enum.__InEnum_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__InEnum_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__InEnum_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__InEnum_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InEnum = InEnum;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__InEnum_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B374 RID: 45940 RVA: 0x00118080 File Offset: 0x00116280
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSet<FSharpherealTestEnum> GetEnumSet()
		{
			UTestClass_UFunction_Enum.__GetEnumSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__GetEnumSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__GetEnumSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__GetEnumSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__GetEnumSet_NativeFunctionPtr, (void*)ptr);
			TSet<FSharpherealTestEnum> result = new TSet<FSharpherealTestEnum>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__GetEnumSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B375 RID: 45941 RVA: 0x001180E0 File Offset: 0x001162E0
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TMap<FSharpherealTestEnum, int> GetEnumMap()
		{
			UTestClass_UFunction_Enum.__GetEnumMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__GetEnumMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__GetEnumMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__GetEnumMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__GetEnumMap_NativeFunctionPtr, (void*)ptr);
			TMap<FSharpherealTestEnum, int> result = new TMap<FSharpherealTestEnum, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__GetEnumMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B376 RID: 45942 RVA: 0x00118140 File Offset: 0x00116340
		[SkipLocalsInit]
		[return: Nullable(new byte[]
		{
			1,
			0
		})]
		public unsafe TSet<TEnumAsByte<FSharpherealTestCEnum>> GetEnumAsByteSet()
		{
			UTestClass_UFunction_Enum.__GetEnumAsByteSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__GetEnumAsByteSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__GetEnumAsByteSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__GetEnumAsByteSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__GetEnumAsByteSet_NativeFunctionPtr, (void*)ptr);
			TSet<TEnumAsByte<FSharpherealTestCEnum>> result = new TSet<TEnumAsByte<FSharpherealTestCEnum>>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__GetEnumAsByteSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B377 RID: 45943 RVA: 0x001181A0 File Offset: 0x001163A0
		[SkipLocalsInit]
		[return: Nullable(new byte[]
		{
			1,
			0
		})]
		public unsafe TMap<TEnumAsByte<FSharpherealTestCEnum>, int> GetEnumAsByteMap()
		{
			UTestClass_UFunction_Enum.__GetEnumAsByteMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__GetEnumAsByteMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__GetEnumAsByteMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__GetEnumAsByteMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__GetEnumAsByteMap_NativeFunctionPtr, (void*)ptr);
			TMap<TEnumAsByte<FSharpherealTestCEnum>, int> result = new TMap<TEnumAsByte<FSharpherealTestCEnum>, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__GetEnumAsByteMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B378 RID: 45944 RVA: 0x00118200 File Offset: 0x00116400
		[SkipLocalsInit]
		[return: Nullable(new byte[]
		{
			1,
			0
		})]
		public unsafe TArray<TEnumAsByte<FSharpherealTestCEnum>> GetEnumAsByteArray()
		{
			UTestClass_UFunction_Enum.__GetEnumAsByteArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__GetEnumAsByteArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__GetEnumAsByteArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__GetEnumAsByteArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__GetEnumAsByteArray_NativeFunctionPtr, (void*)ptr);
			TArray<TEnumAsByte<FSharpherealTestCEnum>> result = new TArray<TEnumAsByte<FSharpherealTestCEnum>>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__GetEnumAsByteArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B379 RID: 45945 RVA: 0x00118260 File Offset: 0x00116460
		[SkipLocalsInit]
		public unsafe TEnumAsByte<FSharpherealTestCEnum> GetEnumAsByte()
		{
			UTestClass_UFunction_Enum.__GetEnumAsByte_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__GetEnumAsByte_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__GetEnumAsByte_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__GetEnumAsByte_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__GetEnumAsByte_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B37A RID: 45946 RVA: 0x001182A8 File Offset: 0x001164A8
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<FSharpherealTestEnum> GetEnumArray()
		{
			UTestClass_UFunction_Enum.__GetEnumArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__GetEnumArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__GetEnumArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__GetEnumArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__GetEnumArray_NativeFunctionPtr, (void*)ptr);
			TArray<FSharpherealTestEnum> result = new TArray<FSharpherealTestEnum>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__GetEnumArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B37B RID: 45947 RVA: 0x00118308 File Offset: 0x00116508
		[SkipLocalsInit]
		public unsafe FSharpherealTestEnum GetEnum()
		{
			UTestClass_UFunction_Enum.__GetEnum_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__GetEnum_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__GetEnum_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__GetEnum_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__GetEnum_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B37C RID: 45948 RVA: 0x0011834D File Offset: 0x0011654D
		static UTestClass_UFunction_Enum()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SharpherealTest.TestClass_UFunction_Enum");
		}

		// Token: 0x0600B37D RID: 45949 RVA: 0x0011835B File Offset: 0x0011655B
		protected UTestClass_UFunction_Enum(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004FED RID: 20461
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SharpherealTest.TestClass_UFunction_Enum";

		// Token: 0x04004FEE RID: 20462
		private static IntPtr _ClassPtr;

		// Token: 0x04004FEF RID: 20463
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004FF0 RID: 20464
		internal static int __PropertyOffset_EnumAsByte;

		// Token: 0x04004FF1 RID: 20465
		internal static int __PropertyOffset_EnumAsByteArray;

		// Token: 0x04004FF2 RID: 20466
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<FSharpherealTestCEnum>> _EnumAsByteArray;

		// Token: 0x04004FF3 RID: 20467
		internal static int __PropertyOffset_EnumAsByteSet;

		// Token: 0x04004FF4 RID: 20468
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TSet<TEnumAsByte<FSharpherealTestCEnum>> _EnumAsByteSet;

		// Token: 0x04004FF5 RID: 20469
		internal static int __PropertyOffset_EnumAsByteMap;

		// Token: 0x04004FF6 RID: 20470
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<FSharpherealTestCEnum>, int> _EnumAsByteMap;

		// Token: 0x04004FF7 RID: 20471
		internal static int __PropertyOffset_Enum;

		// Token: 0x04004FF8 RID: 20472
		internal static int __PropertyOffset_EnumArray;

		// Token: 0x04004FF9 RID: 20473
		[Nullable(2)]
		private TArray<FSharpherealTestEnum> _EnumArray;

		// Token: 0x04004FFA RID: 20474
		internal static int __PropertyOffset_EnumSet;

		// Token: 0x04004FFB RID: 20475
		[Nullable(2)]
		private TSet<FSharpherealTestEnum> _EnumSet;

		// Token: 0x04004FFC RID: 20476
		internal static int __PropertyOffset_EnumMap;

		// Token: 0x04004FFD RID: 20477
		[Nullable(2)]
		private TMap<FSharpherealTestEnum, int> _EnumMap;

		// Token: 0x04004FFE RID: 20478
		private static IntPtr __SetEnumSet_NativeFunctionPtr;

		// Token: 0x04004FFF RID: 20479
		private static IntPtr __SetEnumMap_NativeFunctionPtr;

		// Token: 0x04005000 RID: 20480
		private static IntPtr __SetEnumAsByteSet_NativeFunctionPtr;

		// Token: 0x04005001 RID: 20481
		private static IntPtr __SetEnumAsByteMap_NativeFunctionPtr;

		// Token: 0x04005002 RID: 20482
		private static IntPtr __SetEnumAsByteArray_NativeFunctionPtr;

		// Token: 0x04005003 RID: 20483
		private static IntPtr __SetEnumAsByte_NativeFunctionPtr;

		// Token: 0x04005004 RID: 20484
		private static IntPtr __SetEnumArray_NativeFunctionPtr;

		// Token: 0x04005005 RID: 20485
		private static IntPtr __SetEnum_NativeFunctionPtr;

		// Token: 0x04005006 RID: 20486
		private static IntPtr __OutEnumSet_NativeFunctionPtr;

		// Token: 0x04005007 RID: 20487
		private static IntPtr __OutEnumMap_NativeFunctionPtr;

		// Token: 0x04005008 RID: 20488
		private static IntPtr __OutEnumAsByteSet_NativeFunctionPtr;

		// Token: 0x04005009 RID: 20489
		private static IntPtr __OutEnumAsByteMap_NativeFunctionPtr;

		// Token: 0x0400500A RID: 20490
		private static IntPtr __OutEnumAsByteArray_NativeFunctionPtr;

		// Token: 0x0400500B RID: 20491
		private static IntPtr __OutEnumAsByte_NativeFunctionPtr;

		// Token: 0x0400500C RID: 20492
		private static IntPtr __OutEnumArray_NativeFunctionPtr;

		// Token: 0x0400500D RID: 20493
		private static IntPtr __OutEnum_NativeFunctionPtr;

		// Token: 0x0400500E RID: 20494
		private static IntPtr __InEnumSet_NativeFunctionPtr;

		// Token: 0x0400500F RID: 20495
		private static IntPtr __InEnumMap_NativeFunctionPtr;

		// Token: 0x04005010 RID: 20496
		private static IntPtr __InEnumAsByteSet_NativeFunctionPtr;

		// Token: 0x04005011 RID: 20497
		private static IntPtr __InEnumAsByteMap_NativeFunctionPtr;

		// Token: 0x04005012 RID: 20498
		private static IntPtr __InEnumAsByteArray_NativeFunctionPtr;

		// Token: 0x04005013 RID: 20499
		private static IntPtr __InEnumAsByte_NativeFunctionPtr;

		// Token: 0x04005014 RID: 20500
		private static IntPtr __InEnumArray_NativeFunctionPtr;

		// Token: 0x04005015 RID: 20501
		private static IntPtr __InEnum_NativeFunctionPtr;

		// Token: 0x04005016 RID: 20502
		private static IntPtr __GetEnumSet_NativeFunctionPtr;

		// Token: 0x04005017 RID: 20503
		private static IntPtr __GetEnumMap_NativeFunctionPtr;

		// Token: 0x04005018 RID: 20504
		private static IntPtr __GetEnumAsByteSet_NativeFunctionPtr;

		// Token: 0x04005019 RID: 20505
		private static IntPtr __GetEnumAsByteMap_NativeFunctionPtr;

		// Token: 0x0400501A RID: 20506
		private static IntPtr __GetEnumAsByteArray_NativeFunctionPtr;

		// Token: 0x0400501B RID: 20507
		private static IntPtr __GetEnumAsByte_NativeFunctionPtr;

		// Token: 0x0400501C RID: 20508
		private static IntPtr __GetEnumArray_NativeFunctionPtr;

		// Token: 0x0400501D RID: 20509
		private static IntPtr __GetEnum_NativeFunctionPtr;

		// Token: 0x0200120F RID: 4623
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetEnumSet_FunctionParams
		{
			// Token: 0x04006619 RID: 26137
			[FieldOffset(0)]
			public byte InEnumSet;
		}

		// Token: 0x02001210 RID: 4624
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetEnumMap_FunctionParams
		{
			// Token: 0x0400661A RID: 26138
			[FieldOffset(0)]
			public byte InEnumMap;
		}

		// Token: 0x02001211 RID: 4625
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetEnumAsByteSet_FunctionParams
		{
			// Token: 0x0400661B RID: 26139
			[FieldOffset(0)]
			public byte InEnumAsByteSet;
		}

		// Token: 0x02001212 RID: 4626
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetEnumAsByteMap_FunctionParams
		{
			// Token: 0x0400661C RID: 26140
			[FieldOffset(0)]
			public byte InEnumAsByteMap;
		}

		// Token: 0x02001213 RID: 4627
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetEnumAsByteArray_FunctionParams
		{
			// Token: 0x0400661D RID: 26141
			[FieldOffset(0)]
			public byte InEnumAsByteArray;
		}

		// Token: 0x02001214 RID: 4628
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetEnumAsByte_FunctionParams
		{
			// Token: 0x0400661E RID: 26142
			[FieldOffset(0)]
			public TEnumAsByte<FSharpherealTestCEnum> InEnumAsByte;
		}

		// Token: 0x02001215 RID: 4629
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetEnumArray_FunctionParams
		{
			// Token: 0x0400661F RID: 26143
			[FieldOffset(0)]
			public byte InEnumArray;
		}

		// Token: 0x02001216 RID: 4630
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetEnum_FunctionParams
		{
			// Token: 0x04006620 RID: 26144
			[FieldOffset(0)]
			public FSharpherealTestEnum InEnum;
		}

		// Token: 0x02001217 RID: 4631
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutEnumSet_FunctionParams
		{
			// Token: 0x04006621 RID: 26145
			[FieldOffset(0)]
			public byte OutEnumSet;
		}

		// Token: 0x02001218 RID: 4632
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutEnumMap_FunctionParams
		{
			// Token: 0x04006622 RID: 26146
			[FieldOffset(0)]
			public byte OutEnumMap;
		}

		// Token: 0x02001219 RID: 4633
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutEnumAsByteSet_FunctionParams
		{
			// Token: 0x04006623 RID: 26147
			[FieldOffset(0)]
			public byte OutEnumAsByteSet;
		}

		// Token: 0x0200121A RID: 4634
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutEnumAsByteMap_FunctionParams
		{
			// Token: 0x04006624 RID: 26148
			[FieldOffset(0)]
			public byte OutEnumAsByteMap;
		}

		// Token: 0x0200121B RID: 4635
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutEnumAsByteArray_FunctionParams
		{
			// Token: 0x04006625 RID: 26149
			[FieldOffset(0)]
			public byte OutEnumAsByteArray;
		}

		// Token: 0x0200121C RID: 4636
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OutEnumAsByte_FunctionParams
		{
			// Token: 0x04006626 RID: 26150
			[FieldOffset(0)]
			public TEnumAsByte<FSharpherealTestCEnum> OutEnumAsByte;
		}

		// Token: 0x0200121D RID: 4637
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutEnumArray_FunctionParams
		{
			// Token: 0x04006627 RID: 26151
			[FieldOffset(0)]
			public byte OutEnumArray;
		}

		// Token: 0x0200121E RID: 4638
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OutEnum_FunctionParams
		{
			// Token: 0x04006628 RID: 26152
			[FieldOffset(0)]
			public FSharpherealTestEnum OutEnum;
		}

		// Token: 0x0200121F RID: 4639
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InEnumSet_FunctionParams
		{
			// Token: 0x04006629 RID: 26153
			[FieldOffset(0)]
			public byte InEnumSet;
		}

		// Token: 0x02001220 RID: 4640
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InEnumMap_FunctionParams
		{
			// Token: 0x0400662A RID: 26154
			[FieldOffset(0)]
			public byte InEnumMap;
		}

		// Token: 0x02001221 RID: 4641
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InEnumAsByteSet_FunctionParams
		{
			// Token: 0x0400662B RID: 26155
			[FieldOffset(0)]
			public byte InEnumAsByteSet;
		}

		// Token: 0x02001222 RID: 4642
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InEnumAsByteMap_FunctionParams
		{
			// Token: 0x0400662C RID: 26156
			[FieldOffset(0)]
			public byte InEnumAsByteMap;
		}

		// Token: 0x02001223 RID: 4643
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InEnumAsByteArray_FunctionParams
		{
			// Token: 0x0400662D RID: 26157
			[FieldOffset(0)]
			public byte InEnumAsByteArray;
		}

		// Token: 0x02001224 RID: 4644
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __InEnumAsByte_FunctionParams
		{
			// Token: 0x0400662E RID: 26158
			[FieldOffset(0)]
			public TEnumAsByte<FSharpherealTestCEnum> InEnumAsByte;
		}

		// Token: 0x02001225 RID: 4645
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InEnumArray_FunctionParams
		{
			// Token: 0x0400662F RID: 26159
			[FieldOffset(0)]
			public byte InEnumArray;
		}

		// Token: 0x02001226 RID: 4646
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __InEnum_FunctionParams
		{
			// Token: 0x04006630 RID: 26160
			[FieldOffset(0)]
			public FSharpherealTestEnum InEnum;
		}

		// Token: 0x02001227 RID: 4647
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetEnumSet_FunctionParams
		{
			// Token: 0x04006631 RID: 26161
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001228 RID: 4648
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetEnumMap_FunctionParams
		{
			// Token: 0x04006632 RID: 26162
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001229 RID: 4649
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetEnumAsByteSet_FunctionParams
		{
			// Token: 0x04006633 RID: 26163
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200122A RID: 4650
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetEnumAsByteMap_FunctionParams
		{
			// Token: 0x04006634 RID: 26164
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200122B RID: 4651
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetEnumAsByteArray_FunctionParams
		{
			// Token: 0x04006635 RID: 26165
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200122C RID: 4652
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetEnumAsByte_FunctionParams
		{
			// Token: 0x04006636 RID: 26166
			[FieldOffset(0)]
			public TEnumAsByte<FSharpherealTestCEnum> __Result;
		}

		// Token: 0x0200122D RID: 4653
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetEnumArray_FunctionParams
		{
			// Token: 0x04006637 RID: 26167
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200122E RID: 4654
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetEnum_FunctionParams
		{
			// Token: 0x04006638 RID: 26168
			[FieldOffset(0)]
			public FSharpherealTestEnum __Result;
		}
	}
}
