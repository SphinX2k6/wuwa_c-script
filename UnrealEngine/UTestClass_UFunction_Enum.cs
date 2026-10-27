using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200274E RID: 10062
	[UnrealObjectPath("/Script/SharpherealTest.TestClass_UFunction_Enum")]
	[UnrealStructLayout(416, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 416)]
	public class UTestClass_UFunction_Enum : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602586C RID: 153708 RVA: 0x00387E76 File Offset: 0x00386076
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTestClass_UFunction_Enum._ClassPtr;
		}

		// Token: 0x0602586D RID: 153709 RVA: 0x00387E84 File Offset: 0x00386084
		public UTestClass_UFunction_Enum() : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_Enum.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602586E RID: 153710 RVA: 0x00387EAC File Offset: 0x003860AC
		[NullableContext(1)]
		public UTestClass_UFunction_Enum(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_Enum.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170090BE RID: 37054
		// (get) Token: 0x0602586F RID: 153711 RVA: 0x00387EDF File Offset: 0x003860DF
		// (set) Token: 0x06025870 RID: 153712 RVA: 0x00387EF3 File Offset: 0x003860F3
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

		// Token: 0x170090BF RID: 37055
		// (get) Token: 0x06025871 RID: 153713 RVA: 0x00387F08 File Offset: 0x00386108
		// (set) Token: 0x06025872 RID: 153714 RVA: 0x00387F41 File Offset: 0x00386141
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

		// Token: 0x170090C0 RID: 37056
		// (get) Token: 0x06025873 RID: 153715 RVA: 0x00387F50 File Offset: 0x00386150
		// (set) Token: 0x06025874 RID: 153716 RVA: 0x00387F89 File Offset: 0x00386189
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

		// Token: 0x170090C1 RID: 37057
		// (get) Token: 0x06025875 RID: 153717 RVA: 0x00387F98 File Offset: 0x00386198
		// (set) Token: 0x06025876 RID: 153718 RVA: 0x00387FD1 File Offset: 0x003861D1
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

		// Token: 0x170090C2 RID: 37058
		// (get) Token: 0x06025877 RID: 153719 RVA: 0x00387FDF File Offset: 0x003861DF
		// (set) Token: 0x06025878 RID: 153720 RVA: 0x00387FEF File Offset: 0x003861EF
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

		// Token: 0x170090C3 RID: 37059
		// (get) Token: 0x06025879 RID: 153721 RVA: 0x00388000 File Offset: 0x00386200
		// (set) Token: 0x0602587A RID: 153722 RVA: 0x00388039 File Offset: 0x00386239
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

		// Token: 0x170090C4 RID: 37060
		// (get) Token: 0x0602587B RID: 153723 RVA: 0x00388048 File Offset: 0x00386248
		// (set) Token: 0x0602587C RID: 153724 RVA: 0x00388081 File Offset: 0x00386281
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

		// Token: 0x170090C5 RID: 37061
		// (get) Token: 0x0602587D RID: 153725 RVA: 0x00388090 File Offset: 0x00386290
		// (set) Token: 0x0602587E RID: 153726 RVA: 0x003880C9 File Offset: 0x003862C9
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

		// Token: 0x0602587F RID: 153727 RVA: 0x003880D8 File Offset: 0x003862D8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetEnumSet(TSet<FSharpherealTestEnum> InEnumSet)
		{
			UTestClass_UFunction_Enum.__SetEnumSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__SetEnumSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__SetEnumSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__SetEnumSet_NativeFunctionPtr, (void*)ptr, 1);
			if (InEnumSet != null)
			{
				InEnumSet.CopyTo(&ptr->InEnumSet, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__SetEnumSet_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__SetEnumSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025880 RID: 153728 RVA: 0x00388144 File Offset: 0x00386344
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetEnumMap(TMap<FSharpherealTestEnum, int> InEnumMap)
		{
			UTestClass_UFunction_Enum.__SetEnumMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__SetEnumMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__SetEnumMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__SetEnumMap_NativeFunctionPtr, (void*)ptr, 1);
			if (InEnumMap != null)
			{
				InEnumMap.CopyTo(&ptr->InEnumMap, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__SetEnumMap_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__SetEnumMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025881 RID: 153729 RVA: 0x003881B0 File Offset: 0x003863B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__SetEnumAsByteSet_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__SetEnumAsByteSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025882 RID: 153730 RVA: 0x0038821C File Offset: 0x0038641C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__SetEnumAsByteMap_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__SetEnumAsByteMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025883 RID: 153731 RVA: 0x00388288 File Offset: 0x00386488
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__SetEnumAsByteArray_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__SetEnumAsByteArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025884 RID: 153732 RVA: 0x003882F4 File Offset: 0x003864F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetEnumAsByte(FSharpherealTestCEnum InEnumAsByte)
		{
			UTestClass_UFunction_Enum.__SetEnumAsByte_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__SetEnumAsByte_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__SetEnumAsByte_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__SetEnumAsByte_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InEnumAsByte = InEnumAsByte;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__SetEnumAsByte_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025885 RID: 153733 RVA: 0x00388340 File Offset: 0x00386540
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetEnumArray(TArray<FSharpherealTestEnum> InEnumArray)
		{
			UTestClass_UFunction_Enum.__SetEnumArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__SetEnumArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__SetEnumArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__SetEnumArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InEnumArray != null)
			{
				InEnumArray.CopyTo(&ptr->InEnumArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__SetEnumArray_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__SetEnumArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025886 RID: 153734 RVA: 0x003883AC File Offset: 0x003865AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetEnum(FSharpherealTestEnum InEnum)
		{
			UTestClass_UFunction_Enum.__SetEnum_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__SetEnum_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__SetEnum_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__SetEnum_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InEnum = InEnum;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__SetEnum_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025887 RID: 153735 RVA: 0x003883F4 File Offset: 0x003865F4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutEnumSet(ref TSet<FSharpherealTestEnum> OutEnumSet)
		{
			UTestClass_UFunction_Enum.__OutEnumSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__OutEnumSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__OutEnumSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__OutEnumSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<FSharpherealTestEnum> tset = OutEnumSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutEnumSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__OutEnumSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<FSharpherealTestEnum> tset2 = OutEnumSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutEnumSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__OutEnumSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025888 RID: 153736 RVA: 0x00388470 File Offset: 0x00386670
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutEnumMap(ref TMap<FSharpherealTestEnum, int> OutEnumMap)
		{
			UTestClass_UFunction_Enum.__OutEnumMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__OutEnumMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__OutEnumMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__OutEnumMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FSharpherealTestEnum, int> tmap = OutEnumMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutEnumMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__OutEnumMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FSharpherealTestEnum, int> tmap2 = OutEnumMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutEnumMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__OutEnumMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025889 RID: 153737 RVA: 0x003884EC File Offset: 0x003866EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__OutEnumAsByteSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<TEnumAsByte<FSharpherealTestCEnum>> tset2 = OutEnumAsByteSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutEnumAsByteSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__OutEnumAsByteSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602588A RID: 153738 RVA: 0x00388568 File Offset: 0x00386768
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__OutEnumAsByteMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<TEnumAsByte<FSharpherealTestCEnum>, int> tmap2 = OutEnumAsByteMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutEnumAsByteMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__OutEnumAsByteMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602588B RID: 153739 RVA: 0x003885E4 File Offset: 0x003867E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__OutEnumAsByteArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<TEnumAsByte<FSharpherealTestCEnum>> tarray2 = OutEnumAsByteArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutEnumAsByteArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__OutEnumAsByteArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602588C RID: 153740 RVA: 0x00388660 File Offset: 0x00386860
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutEnumAsByte(ref FSharpherealTestCEnum OutEnumAsByte)
		{
			UTestClass_UFunction_Enum.__OutEnumAsByte_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__OutEnumAsByte_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__OutEnumAsByte_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__OutEnumAsByte_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutEnumAsByte = OutEnumAsByte;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__OutEnumAsByte_NativeFunctionPtr, (void*)ptr, 0);
			OutEnumAsByte = ptr->OutEnumAsByte;
		}

		// Token: 0x0602588D RID: 153741 RVA: 0x003886BC File Offset: 0x003868BC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutEnumArray(ref TArray<FSharpherealTestEnum> OutEnumArray)
		{
			UTestClass_UFunction_Enum.__OutEnumArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__OutEnumArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__OutEnumArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__OutEnumArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FSharpherealTestEnum> tarray = OutEnumArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutEnumArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__OutEnumArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FSharpherealTestEnum> tarray2 = OutEnumArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutEnumArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__OutEnumArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602588E RID: 153742 RVA: 0x00388738 File Offset: 0x00386938
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutEnum(ref FSharpherealTestEnum OutEnum)
		{
			UTestClass_UFunction_Enum.__OutEnum_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__OutEnum_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__OutEnum_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__OutEnum_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutEnum = OutEnum;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__OutEnum_NativeFunctionPtr, (void*)ptr, 0);
			OutEnum = ptr->OutEnum;
		}

		// Token: 0x0602588F RID: 153743 RVA: 0x00388788 File Offset: 0x00386988
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InEnumSet(in TSet<FSharpherealTestEnum> InEnumSet)
		{
			UTestClass_UFunction_Enum.__InEnumSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__InEnumSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__InEnumSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__InEnumSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<FSharpherealTestEnum> tset = InEnumSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InEnumSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__InEnumSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<FSharpherealTestEnum> tset2 = InEnumSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InEnumSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__InEnumSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025890 RID: 153744 RVA: 0x00388804 File Offset: 0x00386A04
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InEnumMap(in TMap<FSharpherealTestEnum, int> InEnumMap)
		{
			UTestClass_UFunction_Enum.__InEnumMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__InEnumMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__InEnumMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__InEnumMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FSharpherealTestEnum, int> tmap = InEnumMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InEnumMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__InEnumMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FSharpherealTestEnum, int> tmap2 = InEnumMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InEnumMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__InEnumMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025891 RID: 153745 RVA: 0x00388880 File Offset: 0x00386A80
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__InEnumAsByteSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<TEnumAsByte<FSharpherealTestCEnum>> tset2 = InEnumAsByteSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InEnumAsByteSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__InEnumAsByteSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025892 RID: 153746 RVA: 0x003888FC File Offset: 0x00386AFC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__InEnumAsByteMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<TEnumAsByte<FSharpherealTestCEnum>, int> tmap2 = InEnumAsByteMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InEnumAsByteMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__InEnumAsByteMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025893 RID: 153747 RVA: 0x00388978 File Offset: 0x00386B78
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__InEnumAsByteArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<TEnumAsByte<FSharpherealTestCEnum>> tarray2 = InEnumAsByteArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InEnumAsByteArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__InEnumAsByteArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025894 RID: 153748 RVA: 0x003889F4 File Offset: 0x00386BF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InEnumAsByte(in FSharpherealTestCEnum InEnumAsByte)
		{
			UTestClass_UFunction_Enum.__InEnumAsByte_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__InEnumAsByte_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__InEnumAsByte_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__InEnumAsByte_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InEnumAsByte = InEnumAsByte;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__InEnumAsByte_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025895 RID: 153749 RVA: 0x00388A44 File Offset: 0x00386C44
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InEnumArray(in TArray<FSharpherealTestEnum> InEnumArray)
		{
			UTestClass_UFunction_Enum.__InEnumArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__InEnumArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__InEnumArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__InEnumArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FSharpherealTestEnum> tarray = InEnumArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InEnumArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__InEnumArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FSharpherealTestEnum> tarray2 = InEnumArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InEnumArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__InEnumArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025896 RID: 153750 RVA: 0x00388AC0 File Offset: 0x00386CC0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InEnum(in FSharpherealTestEnum InEnum)
		{
			UTestClass_UFunction_Enum.__InEnum_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__InEnum_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__InEnum_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__InEnum_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InEnum = InEnum;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__InEnum_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025897 RID: 153751 RVA: 0x00388B08 File Offset: 0x00386D08
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<FSharpherealTestEnum> GetEnumSet()
		{
			UTestClass_UFunction_Enum.__GetEnumSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__GetEnumSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__GetEnumSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__GetEnumSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__GetEnumSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<FSharpherealTestEnum> result = new TSet<FSharpherealTestEnum>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__GetEnumSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025898 RID: 153752 RVA: 0x00388B68 File Offset: 0x00386D68
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<FSharpherealTestEnum, int> GetEnumMap()
		{
			UTestClass_UFunction_Enum.__GetEnumMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__GetEnumMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__GetEnumMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__GetEnumMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__GetEnumMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FSharpherealTestEnum, int> result = new TMap<FSharpherealTestEnum, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__GetEnumMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025899 RID: 153753 RVA: 0x00388BC8 File Offset: 0x00386DC8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		[return: Nullable(new byte[]
		{
			1,
			0
		})]
		public unsafe TSet<TEnumAsByte<FSharpherealTestCEnum>> GetEnumAsByteSet()
		{
			UTestClass_UFunction_Enum.__GetEnumAsByteSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__GetEnumAsByteSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__GetEnumAsByteSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__GetEnumAsByteSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__GetEnumAsByteSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<TEnumAsByte<FSharpherealTestCEnum>> result = new TSet<TEnumAsByte<FSharpherealTestCEnum>>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__GetEnumAsByteSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602589A RID: 153754 RVA: 0x00388C28 File Offset: 0x00386E28
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		[return: Nullable(new byte[]
		{
			1,
			0
		})]
		public unsafe TMap<TEnumAsByte<FSharpherealTestCEnum>, int> GetEnumAsByteMap()
		{
			UTestClass_UFunction_Enum.__GetEnumAsByteMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__GetEnumAsByteMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__GetEnumAsByteMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__GetEnumAsByteMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__GetEnumAsByteMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<TEnumAsByte<FSharpherealTestCEnum>, int> result = new TMap<TEnumAsByte<FSharpherealTestCEnum>, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__GetEnumAsByteMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602589B RID: 153755 RVA: 0x00388C88 File Offset: 0x00386E88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		[return: Nullable(new byte[]
		{
			1,
			0
		})]
		public unsafe TArray<TEnumAsByte<FSharpherealTestCEnum>> GetEnumAsByteArray()
		{
			UTestClass_UFunction_Enum.__GetEnumAsByteArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__GetEnumAsByteArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__GetEnumAsByteArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__GetEnumAsByteArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__GetEnumAsByteArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<TEnumAsByte<FSharpherealTestCEnum>> result = new TArray<TEnumAsByte<FSharpherealTestCEnum>>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__GetEnumAsByteArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602589C RID: 153756 RVA: 0x00388CE8 File Offset: 0x00386EE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TEnumAsByte<FSharpherealTestCEnum> GetEnumAsByte()
		{
			UTestClass_UFunction_Enum.__GetEnumAsByte_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__GetEnumAsByte_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__GetEnumAsByte_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__GetEnumAsByte_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__GetEnumAsByte_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602589D RID: 153757 RVA: 0x00388D30 File Offset: 0x00386F30
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<FSharpherealTestEnum> GetEnumArray()
		{
			UTestClass_UFunction_Enum.__GetEnumArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__GetEnumArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__GetEnumArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__GetEnumArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__GetEnumArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FSharpherealTestEnum> result = new TArray<FSharpherealTestEnum>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Enum.__GetEnumArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602589E RID: 153758 RVA: 0x00388D90 File Offset: 0x00386F90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FSharpherealTestEnum GetEnum()
		{
			UTestClass_UFunction_Enum.__GetEnum_FunctionParams* ptr = stackalloc UTestClass_UFunction_Enum.__GetEnum_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Enum.__GetEnum_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Enum.__GetEnum_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Enum.__GetEnum_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602589F RID: 153759 RVA: 0x00388DD6 File Offset: 0x00386FD6
		static UTestClass_UFunction_Enum()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SharpherealTest.TestClass_UFunction_Enum");
		}

		// Token: 0x060258A0 RID: 153760 RVA: 0x00388DE4 File Offset: 0x00386FE4
		protected UTestClass_UFunction_Enum(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401458E RID: 83342
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SharpherealTest.TestClass_UFunction_Enum";

		// Token: 0x0401458F RID: 83343
		private static IntPtr _ClassPtr;

		// Token: 0x04014590 RID: 83344
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014591 RID: 83345
		internal static int __PropertyOffset_EnumAsByte;

		// Token: 0x04014592 RID: 83346
		internal static int __PropertyOffset_EnumAsByteArray;

		// Token: 0x04014593 RID: 83347
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<FSharpherealTestCEnum>> _EnumAsByteArray;

		// Token: 0x04014594 RID: 83348
		internal static int __PropertyOffset_EnumAsByteSet;

		// Token: 0x04014595 RID: 83349
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TSet<TEnumAsByte<FSharpherealTestCEnum>> _EnumAsByteSet;

		// Token: 0x04014596 RID: 83350
		internal static int __PropertyOffset_EnumAsByteMap;

		// Token: 0x04014597 RID: 83351
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<FSharpherealTestCEnum>, int> _EnumAsByteMap;

		// Token: 0x04014598 RID: 83352
		internal static int __PropertyOffset_Enum;

		// Token: 0x04014599 RID: 83353
		internal static int __PropertyOffset_EnumArray;

		// Token: 0x0401459A RID: 83354
		[Nullable(2)]
		private TArray<FSharpherealTestEnum> _EnumArray;

		// Token: 0x0401459B RID: 83355
		internal static int __PropertyOffset_EnumSet;

		// Token: 0x0401459C RID: 83356
		[Nullable(2)]
		private TSet<FSharpherealTestEnum> _EnumSet;

		// Token: 0x0401459D RID: 83357
		internal static int __PropertyOffset_EnumMap;

		// Token: 0x0401459E RID: 83358
		[Nullable(2)]
		private TMap<FSharpherealTestEnum, int> _EnumMap;

		// Token: 0x0401459F RID: 83359
		private static IntPtr __SetEnumSet_NativeFunctionPtr;

		// Token: 0x040145A0 RID: 83360
		private static IntPtr __SetEnumMap_NativeFunctionPtr;

		// Token: 0x040145A1 RID: 83361
		private static IntPtr __SetEnumAsByteSet_NativeFunctionPtr;

		// Token: 0x040145A2 RID: 83362
		private static IntPtr __SetEnumAsByteMap_NativeFunctionPtr;

		// Token: 0x040145A3 RID: 83363
		private static IntPtr __SetEnumAsByteArray_NativeFunctionPtr;

		// Token: 0x040145A4 RID: 83364
		private static IntPtr __SetEnumAsByte_NativeFunctionPtr;

		// Token: 0x040145A5 RID: 83365
		private static IntPtr __SetEnumArray_NativeFunctionPtr;

		// Token: 0x040145A6 RID: 83366
		private static IntPtr __SetEnum_NativeFunctionPtr;

		// Token: 0x040145A7 RID: 83367
		private static IntPtr __OutEnumSet_NativeFunctionPtr;

		// Token: 0x040145A8 RID: 83368
		private static IntPtr __OutEnumMap_NativeFunctionPtr;

		// Token: 0x040145A9 RID: 83369
		private static IntPtr __OutEnumAsByteSet_NativeFunctionPtr;

		// Token: 0x040145AA RID: 83370
		private static IntPtr __OutEnumAsByteMap_NativeFunctionPtr;

		// Token: 0x040145AB RID: 83371
		private static IntPtr __OutEnumAsByteArray_NativeFunctionPtr;

		// Token: 0x040145AC RID: 83372
		private static IntPtr __OutEnumAsByte_NativeFunctionPtr;

		// Token: 0x040145AD RID: 83373
		private static IntPtr __OutEnumArray_NativeFunctionPtr;

		// Token: 0x040145AE RID: 83374
		private static IntPtr __OutEnum_NativeFunctionPtr;

		// Token: 0x040145AF RID: 83375
		private static IntPtr __InEnumSet_NativeFunctionPtr;

		// Token: 0x040145B0 RID: 83376
		private static IntPtr __InEnumMap_NativeFunctionPtr;

		// Token: 0x040145B1 RID: 83377
		private static IntPtr __InEnumAsByteSet_NativeFunctionPtr;

		// Token: 0x040145B2 RID: 83378
		private static IntPtr __InEnumAsByteMap_NativeFunctionPtr;

		// Token: 0x040145B3 RID: 83379
		private static IntPtr __InEnumAsByteArray_NativeFunctionPtr;

		// Token: 0x040145B4 RID: 83380
		private static IntPtr __InEnumAsByte_NativeFunctionPtr;

		// Token: 0x040145B5 RID: 83381
		private static IntPtr __InEnumArray_NativeFunctionPtr;

		// Token: 0x040145B6 RID: 83382
		private static IntPtr __InEnum_NativeFunctionPtr;

		// Token: 0x040145B7 RID: 83383
		private static IntPtr __GetEnumSet_NativeFunctionPtr;

		// Token: 0x040145B8 RID: 83384
		private static IntPtr __GetEnumMap_NativeFunctionPtr;

		// Token: 0x040145B9 RID: 83385
		private static IntPtr __GetEnumAsByteSet_NativeFunctionPtr;

		// Token: 0x040145BA RID: 83386
		private static IntPtr __GetEnumAsByteMap_NativeFunctionPtr;

		// Token: 0x040145BB RID: 83387
		private static IntPtr __GetEnumAsByteArray_NativeFunctionPtr;

		// Token: 0x040145BC RID: 83388
		private static IntPtr __GetEnumAsByte_NativeFunctionPtr;

		// Token: 0x040145BD RID: 83389
		private static IntPtr __GetEnumArray_NativeFunctionPtr;

		// Token: 0x040145BE RID: 83390
		private static IntPtr __GetEnum_NativeFunctionPtr;

		// Token: 0x0200393D RID: 14653
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetEnumSet_FunctionParams
		{
			// Token: 0x04017A66 RID: 96870
			[FieldOffset(0)]
			public byte InEnumSet;
		}

		// Token: 0x0200393E RID: 14654
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetEnumMap_FunctionParams
		{
			// Token: 0x04017A67 RID: 96871
			[FieldOffset(0)]
			public byte InEnumMap;
		}

		// Token: 0x0200393F RID: 14655
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetEnumAsByteSet_FunctionParams
		{
			// Token: 0x04017A68 RID: 96872
			[FieldOffset(0)]
			public byte InEnumAsByteSet;
		}

		// Token: 0x02003940 RID: 14656
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetEnumAsByteMap_FunctionParams
		{
			// Token: 0x04017A69 RID: 96873
			[FieldOffset(0)]
			public byte InEnumAsByteMap;
		}

		// Token: 0x02003941 RID: 14657
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetEnumAsByteArray_FunctionParams
		{
			// Token: 0x04017A6A RID: 96874
			[FieldOffset(0)]
			public byte InEnumAsByteArray;
		}

		// Token: 0x02003942 RID: 14658
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetEnumAsByte_FunctionParams
		{
			// Token: 0x04017A6B RID: 96875
			[FieldOffset(0)]
			public TEnumAsByte<FSharpherealTestCEnum> InEnumAsByte;
		}

		// Token: 0x02003943 RID: 14659
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetEnumArray_FunctionParams
		{
			// Token: 0x04017A6C RID: 96876
			[FieldOffset(0)]
			public byte InEnumArray;
		}

		// Token: 0x02003944 RID: 14660
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetEnum_FunctionParams
		{
			// Token: 0x04017A6D RID: 96877
			[FieldOffset(0)]
			public FSharpherealTestEnum InEnum;
		}

		// Token: 0x02003945 RID: 14661
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutEnumSet_FunctionParams
		{
			// Token: 0x04017A6E RID: 96878
			[FieldOffset(0)]
			public byte OutEnumSet;
		}

		// Token: 0x02003946 RID: 14662
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutEnumMap_FunctionParams
		{
			// Token: 0x04017A6F RID: 96879
			[FieldOffset(0)]
			public byte OutEnumMap;
		}

		// Token: 0x02003947 RID: 14663
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutEnumAsByteSet_FunctionParams
		{
			// Token: 0x04017A70 RID: 96880
			[FieldOffset(0)]
			public byte OutEnumAsByteSet;
		}

		// Token: 0x02003948 RID: 14664
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutEnumAsByteMap_FunctionParams
		{
			// Token: 0x04017A71 RID: 96881
			[FieldOffset(0)]
			public byte OutEnumAsByteMap;
		}

		// Token: 0x02003949 RID: 14665
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutEnumAsByteArray_FunctionParams
		{
			// Token: 0x04017A72 RID: 96882
			[FieldOffset(0)]
			public byte OutEnumAsByteArray;
		}

		// Token: 0x0200394A RID: 14666
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OutEnumAsByte_FunctionParams
		{
			// Token: 0x04017A73 RID: 96883
			[FieldOffset(0)]
			public TEnumAsByte<FSharpherealTestCEnum> OutEnumAsByte;
		}

		// Token: 0x0200394B RID: 14667
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutEnumArray_FunctionParams
		{
			// Token: 0x04017A74 RID: 96884
			[FieldOffset(0)]
			public byte OutEnumArray;
		}

		// Token: 0x0200394C RID: 14668
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OutEnum_FunctionParams
		{
			// Token: 0x04017A75 RID: 96885
			[FieldOffset(0)]
			public FSharpherealTestEnum OutEnum;
		}

		// Token: 0x0200394D RID: 14669
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InEnumSet_FunctionParams
		{
			// Token: 0x04017A76 RID: 96886
			[FieldOffset(0)]
			public byte InEnumSet;
		}

		// Token: 0x0200394E RID: 14670
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InEnumMap_FunctionParams
		{
			// Token: 0x04017A77 RID: 96887
			[FieldOffset(0)]
			public byte InEnumMap;
		}

		// Token: 0x0200394F RID: 14671
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InEnumAsByteSet_FunctionParams
		{
			// Token: 0x04017A78 RID: 96888
			[FieldOffset(0)]
			public byte InEnumAsByteSet;
		}

		// Token: 0x02003950 RID: 14672
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InEnumAsByteMap_FunctionParams
		{
			// Token: 0x04017A79 RID: 96889
			[FieldOffset(0)]
			public byte InEnumAsByteMap;
		}

		// Token: 0x02003951 RID: 14673
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InEnumAsByteArray_FunctionParams
		{
			// Token: 0x04017A7A RID: 96890
			[FieldOffset(0)]
			public byte InEnumAsByteArray;
		}

		// Token: 0x02003952 RID: 14674
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __InEnumAsByte_FunctionParams
		{
			// Token: 0x04017A7B RID: 96891
			[FieldOffset(0)]
			public TEnumAsByte<FSharpherealTestCEnum> InEnumAsByte;
		}

		// Token: 0x02003953 RID: 14675
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InEnumArray_FunctionParams
		{
			// Token: 0x04017A7C RID: 96892
			[FieldOffset(0)]
			public byte InEnumArray;
		}

		// Token: 0x02003954 RID: 14676
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __InEnum_FunctionParams
		{
			// Token: 0x04017A7D RID: 96893
			[FieldOffset(0)]
			public FSharpherealTestEnum InEnum;
		}

		// Token: 0x02003955 RID: 14677
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetEnumSet_FunctionParams
		{
			// Token: 0x04017A7E RID: 96894
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003956 RID: 14678
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetEnumMap_FunctionParams
		{
			// Token: 0x04017A7F RID: 96895
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003957 RID: 14679
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetEnumAsByteSet_FunctionParams
		{
			// Token: 0x04017A80 RID: 96896
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003958 RID: 14680
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetEnumAsByteMap_FunctionParams
		{
			// Token: 0x04017A81 RID: 96897
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003959 RID: 14681
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetEnumAsByteArray_FunctionParams
		{
			// Token: 0x04017A82 RID: 96898
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200395A RID: 14682
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetEnumAsByte_FunctionParams
		{
			// Token: 0x04017A83 RID: 96899
			[FieldOffset(0)]
			public TEnumAsByte<FSharpherealTestCEnum> __Result;
		}

		// Token: 0x0200395B RID: 14683
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetEnumArray_FunctionParams
		{
			// Token: 0x04017A84 RID: 96900
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200395C RID: 14684
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetEnum_FunctionParams
		{
			// Token: 0x04017A85 RID: 96901
			[FieldOffset(0)]
			public FSharpherealTestEnum __Result;
		}
	}
}
