using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002748 RID: 10056
	[UnrealObjectPath("/Script/SharpherealTest.TestClass_UFunction_Direct_Enum")]
	[UnrealStructLayout(416, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 416)]
	public class UTestClass_UFunction_Direct_Enum : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060256A8 RID: 153256 RVA: 0x0037F81D File Offset: 0x0037DA1D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTestClass_UFunction_Direct_Enum._ClassPtr;
		}

		// Token: 0x060256A9 RID: 153257 RVA: 0x0037F82C File Offset: 0x0037DA2C
		public UTestClass_UFunction_Direct_Enum() : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_Direct_Enum.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060256AA RID: 153258 RVA: 0x0037F854 File Offset: 0x0037DA54
		[NullableContext(1)]
		public UTestClass_UFunction_Direct_Enum(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_Direct_Enum.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009070 RID: 36976
		// (get) Token: 0x060256AB RID: 153259 RVA: 0x0037F887 File Offset: 0x0037DA87
		// (set) Token: 0x060256AC RID: 153260 RVA: 0x0037F89B File Offset: 0x0037DA9B
		public unsafe TEnumAsByte<FSharpherealTestCEnum> EnumAsByte
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Enum.__PropertyOffset_EnumAsByte);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Enum.__PropertyOffset_EnumAsByte) = value;
			}
		}

		// Token: 0x17009071 RID: 36977
		// (get) Token: 0x060256AD RID: 153261 RVA: 0x0037F8B0 File Offset: 0x0037DAB0
		// (set) Token: 0x060256AE RID: 153262 RVA: 0x0037F8E9 File Offset: 0x0037DAE9
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
					result = (this._EnumAsByteArray = new TArray<TEnumAsByte<FSharpherealTestCEnum>>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Enum.__PropertyOffset_EnumAsByteArray, this));
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

		// Token: 0x17009072 RID: 36978
		// (get) Token: 0x060256AF RID: 153263 RVA: 0x0037F8F8 File Offset: 0x0037DAF8
		// (set) Token: 0x060256B0 RID: 153264 RVA: 0x0037F931 File Offset: 0x0037DB31
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
					result = (this._EnumAsByteSet = new TSet<TEnumAsByte<FSharpherealTestCEnum>>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Enum.__PropertyOffset_EnumAsByteSet, this));
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

		// Token: 0x17009073 RID: 36979
		// (get) Token: 0x060256B1 RID: 153265 RVA: 0x0037F940 File Offset: 0x0037DB40
		// (set) Token: 0x060256B2 RID: 153266 RVA: 0x0037F979 File Offset: 0x0037DB79
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
					result = (this._EnumAsByteMap = new TMap<TEnumAsByte<FSharpherealTestCEnum>, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Enum.__PropertyOffset_EnumAsByteMap, this));
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

		// Token: 0x17009074 RID: 36980
		// (get) Token: 0x060256B3 RID: 153267 RVA: 0x0037F987 File Offset: 0x0037DB87
		// (set) Token: 0x060256B4 RID: 153268 RVA: 0x0037F997 File Offset: 0x0037DB97
		public unsafe FSharpherealTestEnum Enum
		{
			get
			{
				return (FSharpherealTestEnum)(*(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Enum.__PropertyOffset_Enum));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Enum.__PropertyOffset_Enum) = (byte)value;
			}
		}

		// Token: 0x17009075 RID: 36981
		// (get) Token: 0x060256B5 RID: 153269 RVA: 0x0037F9A8 File Offset: 0x0037DBA8
		// (set) Token: 0x060256B6 RID: 153270 RVA: 0x0037F9E1 File Offset: 0x0037DBE1
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
					result = (this._EnumArray = new TArray<FSharpherealTestEnum>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Enum.__PropertyOffset_EnumArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.EnumArray.CopyAssign(value);
			}
		}

		// Token: 0x17009076 RID: 36982
		// (get) Token: 0x060256B7 RID: 153271 RVA: 0x0037F9F0 File Offset: 0x0037DBF0
		// (set) Token: 0x060256B8 RID: 153272 RVA: 0x0037FA29 File Offset: 0x0037DC29
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
					result = (this._EnumSet = new TSet<FSharpherealTestEnum>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Enum.__PropertyOffset_EnumSet, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.EnumSet.CopyAssign(value);
			}
		}

		// Token: 0x17009077 RID: 36983
		// (get) Token: 0x060256B9 RID: 153273 RVA: 0x0037FA38 File Offset: 0x0037DC38
		// (set) Token: 0x060256BA RID: 153274 RVA: 0x0037FA71 File Offset: 0x0037DC71
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
					result = (this._EnumMap = new TMap<FSharpherealTestEnum, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Enum.__PropertyOffset_EnumMap, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.EnumMap.CopyAssign(value);
			}
		}

		// Token: 0x060256BB RID: 153275 RVA: 0x0037FA80 File Offset: 0x0037DC80
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetEnumSet(TSet<FSharpherealTestEnum> InEnumSet)
		{
			UTestClass_UFunction_Direct_Enum.__SetEnumSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__SetEnumSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__SetEnumSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__SetEnumSet_NativeFunctionPtr, (void*)ptr, 1);
			if (InEnumSet != null)
			{
				InEnumSet.CopyTo(&ptr->InEnumSet, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__SetEnumSet_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__SetEnumSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060256BC RID: 153276 RVA: 0x0037FAEC File Offset: 0x0037DCEC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetEnumMap(TMap<FSharpherealTestEnum, int> InEnumMap)
		{
			UTestClass_UFunction_Direct_Enum.__SetEnumMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__SetEnumMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__SetEnumMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__SetEnumMap_NativeFunctionPtr, (void*)ptr, 1);
			if (InEnumMap != null)
			{
				InEnumMap.CopyTo(&ptr->InEnumMap, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__SetEnumMap_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__SetEnumMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060256BD RID: 153277 RVA: 0x0037FB58 File Offset: 0x0037DD58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetEnumAsByteSet([Nullable(new byte[]
		{
			2,
			0
		})] TSet<TEnumAsByte<FSharpherealTestCEnum>> InEnumAsByteSet)
		{
			UTestClass_UFunction_Direct_Enum.__SetEnumAsByteSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__SetEnumAsByteSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__SetEnumAsByteSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__SetEnumAsByteSet_NativeFunctionPtr, (void*)ptr, 1);
			if (InEnumAsByteSet != null)
			{
				InEnumAsByteSet.CopyTo(&ptr->InEnumAsByteSet, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__SetEnumAsByteSet_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__SetEnumAsByteSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060256BE RID: 153278 RVA: 0x0037FBC4 File Offset: 0x0037DDC4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetEnumAsByteMap([Nullable(new byte[]
		{
			2,
			0
		})] TMap<TEnumAsByte<FSharpherealTestCEnum>, int> InEnumAsByteMap)
		{
			UTestClass_UFunction_Direct_Enum.__SetEnumAsByteMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__SetEnumAsByteMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__SetEnumAsByteMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__SetEnumAsByteMap_NativeFunctionPtr, (void*)ptr, 1);
			if (InEnumAsByteMap != null)
			{
				InEnumAsByteMap.CopyTo(&ptr->InEnumAsByteMap, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__SetEnumAsByteMap_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__SetEnumAsByteMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060256BF RID: 153279 RVA: 0x0037FC30 File Offset: 0x0037DE30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetEnumAsByteArray([Nullable(new byte[]
		{
			2,
			0
		})] TArray<TEnumAsByte<FSharpherealTestCEnum>> InEnumAsByteArray)
		{
			UTestClass_UFunction_Direct_Enum.__SetEnumAsByteArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__SetEnumAsByteArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__SetEnumAsByteArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__SetEnumAsByteArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InEnumAsByteArray != null)
			{
				InEnumAsByteArray.CopyTo(&ptr->InEnumAsByteArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__SetEnumAsByteArray_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__SetEnumAsByteArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060256C0 RID: 153280 RVA: 0x0037FC9C File Offset: 0x0037DE9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetEnumAsByte(FSharpherealTestCEnum InEnumAsByte)
		{
			UTestClass_UFunction_Direct_Enum.__SetEnumAsByte_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__SetEnumAsByte_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__SetEnumAsByte_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__SetEnumAsByte_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InEnumAsByte = InEnumAsByte;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__SetEnumAsByte_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060256C1 RID: 153281 RVA: 0x0037FCE8 File Offset: 0x0037DEE8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetEnumArray(TArray<FSharpherealTestEnum> InEnumArray)
		{
			UTestClass_UFunction_Direct_Enum.__SetEnumArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__SetEnumArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__SetEnumArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__SetEnumArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InEnumArray != null)
			{
				InEnumArray.CopyTo(&ptr->InEnumArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__SetEnumArray_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__SetEnumArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060256C2 RID: 153282 RVA: 0x0037FD54 File Offset: 0x0037DF54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetEnum(FSharpherealTestEnum InEnum)
		{
			UTestClass_UFunction_Direct_Enum.__SetEnum_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__SetEnum_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__SetEnum_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__SetEnum_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InEnum = InEnum;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__SetEnum_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060256C3 RID: 153283 RVA: 0x0037FD9C File Offset: 0x0037DF9C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutEnumSet(ref TSet<FSharpherealTestEnum> OutEnumSet)
		{
			UTestClass_UFunction_Direct_Enum.__OutEnumSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__OutEnumSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__OutEnumSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__OutEnumSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<FSharpherealTestEnum> tset = OutEnumSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutEnumSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__OutEnumSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<FSharpherealTestEnum> tset2 = OutEnumSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutEnumSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__OutEnumSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060256C4 RID: 153284 RVA: 0x0037FE18 File Offset: 0x0037E018
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutEnumMap(ref TMap<FSharpherealTestEnum, int> OutEnumMap)
		{
			UTestClass_UFunction_Direct_Enum.__OutEnumMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__OutEnumMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__OutEnumMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__OutEnumMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FSharpherealTestEnum, int> tmap = OutEnumMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutEnumMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__OutEnumMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FSharpherealTestEnum, int> tmap2 = OutEnumMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutEnumMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__OutEnumMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060256C5 RID: 153285 RVA: 0x0037FE94 File Offset: 0x0037E094
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutEnumAsByteSet([Nullable(new byte[]
		{
			2,
			0
		})] ref TSet<TEnumAsByte<FSharpherealTestCEnum>> OutEnumAsByteSet)
		{
			UTestClass_UFunction_Direct_Enum.__OutEnumAsByteSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__OutEnumAsByteSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__OutEnumAsByteSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__OutEnumAsByteSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<TEnumAsByte<FSharpherealTestCEnum>> tset = OutEnumAsByteSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutEnumAsByteSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__OutEnumAsByteSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<TEnumAsByte<FSharpherealTestCEnum>> tset2 = OutEnumAsByteSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutEnumAsByteSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__OutEnumAsByteSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060256C6 RID: 153286 RVA: 0x0037FF10 File Offset: 0x0037E110
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutEnumAsByteMap([Nullable(new byte[]
		{
			2,
			0
		})] ref TMap<TEnumAsByte<FSharpherealTestCEnum>, int> OutEnumAsByteMap)
		{
			UTestClass_UFunction_Direct_Enum.__OutEnumAsByteMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__OutEnumAsByteMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__OutEnumAsByteMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__OutEnumAsByteMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<TEnumAsByte<FSharpherealTestCEnum>, int> tmap = OutEnumAsByteMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutEnumAsByteMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__OutEnumAsByteMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<TEnumAsByte<FSharpherealTestCEnum>, int> tmap2 = OutEnumAsByteMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutEnumAsByteMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__OutEnumAsByteMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060256C7 RID: 153287 RVA: 0x0037FF8C File Offset: 0x0037E18C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutEnumAsByteArray([Nullable(new byte[]
		{
			2,
			0
		})] ref TArray<TEnumAsByte<FSharpherealTestCEnum>> OutEnumAsByteArray)
		{
			UTestClass_UFunction_Direct_Enum.__OutEnumAsByteArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__OutEnumAsByteArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__OutEnumAsByteArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__OutEnumAsByteArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<TEnumAsByte<FSharpherealTestCEnum>> tarray = OutEnumAsByteArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutEnumAsByteArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__OutEnumAsByteArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<TEnumAsByte<FSharpherealTestCEnum>> tarray2 = OutEnumAsByteArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutEnumAsByteArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__OutEnumAsByteArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060256C8 RID: 153288 RVA: 0x00380008 File Offset: 0x0037E208
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutEnumAsByte(ref FSharpherealTestCEnum OutEnumAsByte)
		{
			UTestClass_UFunction_Direct_Enum.__OutEnumAsByte_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__OutEnumAsByte_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__OutEnumAsByte_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__OutEnumAsByte_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutEnumAsByte = OutEnumAsByte;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__OutEnumAsByte_NativeFunctionPtr, (void*)ptr, 0);
			OutEnumAsByte = ptr->OutEnumAsByte;
		}

		// Token: 0x060256C9 RID: 153289 RVA: 0x00380064 File Offset: 0x0037E264
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutEnumArray(ref TArray<FSharpherealTestEnum> OutEnumArray)
		{
			UTestClass_UFunction_Direct_Enum.__OutEnumArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__OutEnumArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__OutEnumArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__OutEnumArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FSharpherealTestEnum> tarray = OutEnumArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutEnumArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__OutEnumArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FSharpherealTestEnum> tarray2 = OutEnumArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutEnumArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__OutEnumArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060256CA RID: 153290 RVA: 0x003800E0 File Offset: 0x0037E2E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutEnum(ref FSharpherealTestEnum OutEnum)
		{
			UTestClass_UFunction_Direct_Enum.__OutEnum_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__OutEnum_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__OutEnum_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__OutEnum_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutEnum = OutEnum;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__OutEnum_NativeFunctionPtr, (void*)ptr, 0);
			OutEnum = ptr->OutEnum;
		}

		// Token: 0x060256CB RID: 153291 RVA: 0x00380130 File Offset: 0x0037E330
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InEnumSet(in TSet<FSharpherealTestEnum> InEnumSet)
		{
			UTestClass_UFunction_Direct_Enum.__InEnumSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__InEnumSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__InEnumSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__InEnumSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<FSharpherealTestEnum> tset = InEnumSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InEnumSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__InEnumSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<FSharpherealTestEnum> tset2 = InEnumSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InEnumSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__InEnumSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060256CC RID: 153292 RVA: 0x003801AC File Offset: 0x0037E3AC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InEnumMap(in TMap<FSharpherealTestEnum, int> InEnumMap)
		{
			UTestClass_UFunction_Direct_Enum.__InEnumMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__InEnumMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__InEnumMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__InEnumMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FSharpherealTestEnum, int> tmap = InEnumMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InEnumMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__InEnumMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FSharpherealTestEnum, int> tmap2 = InEnumMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InEnumMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__InEnumMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060256CD RID: 153293 RVA: 0x00380228 File Offset: 0x0037E428
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InEnumAsByteSet([Nullable(new byte[]
		{
			2,
			0
		})] in TSet<TEnumAsByte<FSharpherealTestCEnum>> InEnumAsByteSet)
		{
			UTestClass_UFunction_Direct_Enum.__InEnumAsByteSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__InEnumAsByteSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__InEnumAsByteSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__InEnumAsByteSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<TEnumAsByte<FSharpherealTestCEnum>> tset = InEnumAsByteSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InEnumAsByteSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__InEnumAsByteSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<TEnumAsByte<FSharpherealTestCEnum>> tset2 = InEnumAsByteSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InEnumAsByteSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__InEnumAsByteSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060256CE RID: 153294 RVA: 0x003802A4 File Offset: 0x0037E4A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InEnumAsByteMap([Nullable(new byte[]
		{
			2,
			0
		})] in TMap<TEnumAsByte<FSharpherealTestCEnum>, int> InEnumAsByteMap)
		{
			UTestClass_UFunction_Direct_Enum.__InEnumAsByteMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__InEnumAsByteMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__InEnumAsByteMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__InEnumAsByteMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<TEnumAsByte<FSharpherealTestCEnum>, int> tmap = InEnumAsByteMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InEnumAsByteMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__InEnumAsByteMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<TEnumAsByte<FSharpherealTestCEnum>, int> tmap2 = InEnumAsByteMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InEnumAsByteMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__InEnumAsByteMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060256CF RID: 153295 RVA: 0x00380320 File Offset: 0x0037E520
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InEnumAsByteArray([Nullable(new byte[]
		{
			2,
			0
		})] in TArray<TEnumAsByte<FSharpherealTestCEnum>> InEnumAsByteArray)
		{
			UTestClass_UFunction_Direct_Enum.__InEnumAsByteArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__InEnumAsByteArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__InEnumAsByteArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__InEnumAsByteArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<TEnumAsByte<FSharpherealTestCEnum>> tarray = InEnumAsByteArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InEnumAsByteArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__InEnumAsByteArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<TEnumAsByte<FSharpherealTestCEnum>> tarray2 = InEnumAsByteArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InEnumAsByteArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__InEnumAsByteArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060256D0 RID: 153296 RVA: 0x0038039C File Offset: 0x0037E59C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InEnumAsByte(in FSharpherealTestCEnum InEnumAsByte)
		{
			UTestClass_UFunction_Direct_Enum.__InEnumAsByte_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__InEnumAsByte_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__InEnumAsByte_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__InEnumAsByte_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InEnumAsByte = InEnumAsByte;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__InEnumAsByte_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060256D1 RID: 153297 RVA: 0x003803EC File Offset: 0x0037E5EC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InEnumArray(in TArray<FSharpherealTestEnum> InEnumArray)
		{
			UTestClass_UFunction_Direct_Enum.__InEnumArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__InEnumArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__InEnumArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__InEnumArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FSharpherealTestEnum> tarray = InEnumArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InEnumArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__InEnumArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FSharpherealTestEnum> tarray2 = InEnumArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InEnumArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__InEnumArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060256D2 RID: 153298 RVA: 0x00380468 File Offset: 0x0037E668
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InEnum(in FSharpherealTestEnum InEnum)
		{
			UTestClass_UFunction_Direct_Enum.__InEnum_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__InEnum_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__InEnum_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__InEnum_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InEnum = InEnum;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__InEnum_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060256D3 RID: 153299 RVA: 0x003804B0 File Offset: 0x0037E6B0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<FSharpherealTestEnum> GetEnumSet()
		{
			UTestClass_UFunction_Direct_Enum.__GetEnumSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__GetEnumSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__GetEnumSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__GetEnumSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__GetEnumSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<FSharpherealTestEnum> result = new TSet<FSharpherealTestEnum>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__GetEnumSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060256D4 RID: 153300 RVA: 0x00380510 File Offset: 0x0037E710
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<FSharpherealTestEnum, int> GetEnumMap()
		{
			UTestClass_UFunction_Direct_Enum.__GetEnumMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__GetEnumMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__GetEnumMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__GetEnumMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__GetEnumMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FSharpherealTestEnum, int> result = new TMap<FSharpherealTestEnum, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__GetEnumMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060256D5 RID: 153301 RVA: 0x00380570 File Offset: 0x0037E770
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		[return: Nullable(new byte[]
		{
			1,
			0
		})]
		public unsafe TSet<TEnumAsByte<FSharpherealTestCEnum>> GetEnumAsByteSet()
		{
			UTestClass_UFunction_Direct_Enum.__GetEnumAsByteSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__GetEnumAsByteSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__GetEnumAsByteSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__GetEnumAsByteSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__GetEnumAsByteSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<TEnumAsByte<FSharpherealTestCEnum>> result = new TSet<TEnumAsByte<FSharpherealTestCEnum>>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__GetEnumAsByteSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060256D6 RID: 153302 RVA: 0x003805D0 File Offset: 0x0037E7D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		[return: Nullable(new byte[]
		{
			1,
			0
		})]
		public unsafe TMap<TEnumAsByte<FSharpherealTestCEnum>, int> GetEnumAsByteMap()
		{
			UTestClass_UFunction_Direct_Enum.__GetEnumAsByteMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__GetEnumAsByteMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__GetEnumAsByteMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__GetEnumAsByteMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__GetEnumAsByteMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<TEnumAsByte<FSharpherealTestCEnum>, int> result = new TMap<TEnumAsByte<FSharpherealTestCEnum>, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__GetEnumAsByteMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060256D7 RID: 153303 RVA: 0x00380630 File Offset: 0x0037E830
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		[return: Nullable(new byte[]
		{
			1,
			0
		})]
		public unsafe TArray<TEnumAsByte<FSharpherealTestCEnum>> GetEnumAsByteArray()
		{
			UTestClass_UFunction_Direct_Enum.__GetEnumAsByteArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__GetEnumAsByteArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__GetEnumAsByteArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__GetEnumAsByteArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__GetEnumAsByteArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<TEnumAsByte<FSharpherealTestCEnum>> result = new TArray<TEnumAsByte<FSharpherealTestCEnum>>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__GetEnumAsByteArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060256D8 RID: 153304 RVA: 0x00380690 File Offset: 0x0037E890
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TEnumAsByte<FSharpherealTestCEnum> GetEnumAsByte()
		{
			UTestClass_UFunction_Direct_Enum.__GetEnumAsByte_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__GetEnumAsByte_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__GetEnumAsByte_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__GetEnumAsByte_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__GetEnumAsByte_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060256D9 RID: 153305 RVA: 0x003806D8 File Offset: 0x0037E8D8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<FSharpherealTestEnum> GetEnumArray()
		{
			UTestClass_UFunction_Direct_Enum.__GetEnumArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__GetEnumArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__GetEnumArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__GetEnumArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__GetEnumArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FSharpherealTestEnum> result = new TArray<FSharpherealTestEnum>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__GetEnumArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060256DA RID: 153306 RVA: 0x00380738 File Offset: 0x0037E938
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FSharpherealTestEnum GetEnum()
		{
			UTestClass_UFunction_Direct_Enum.__GetEnum_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__GetEnum_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__GetEnum_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__GetEnum_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__GetEnum_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060256DB RID: 153307 RVA: 0x0038077E File Offset: 0x0037E97E
		static UTestClass_UFunction_Direct_Enum()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SharpherealTest.TestClass_UFunction_Direct_Enum");
		}

		// Token: 0x060256DC RID: 153308 RVA: 0x0038078C File Offset: 0x0037E98C
		protected UTestClass_UFunction_Direct_Enum(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040143F1 RID: 82929
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SharpherealTest.TestClass_UFunction_Direct_Enum";

		// Token: 0x040143F2 RID: 82930
		private static IntPtr _ClassPtr;

		// Token: 0x040143F3 RID: 82931
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040143F4 RID: 82932
		internal static int __PropertyOffset_EnumAsByte;

		// Token: 0x040143F5 RID: 82933
		internal static int __PropertyOffset_EnumAsByteArray;

		// Token: 0x040143F6 RID: 82934
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<FSharpherealTestCEnum>> _EnumAsByteArray;

		// Token: 0x040143F7 RID: 82935
		internal static int __PropertyOffset_EnumAsByteSet;

		// Token: 0x040143F8 RID: 82936
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TSet<TEnumAsByte<FSharpherealTestCEnum>> _EnumAsByteSet;

		// Token: 0x040143F9 RID: 82937
		internal static int __PropertyOffset_EnumAsByteMap;

		// Token: 0x040143FA RID: 82938
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<FSharpherealTestCEnum>, int> _EnumAsByteMap;

		// Token: 0x040143FB RID: 82939
		internal static int __PropertyOffset_Enum;

		// Token: 0x040143FC RID: 82940
		internal static int __PropertyOffset_EnumArray;

		// Token: 0x040143FD RID: 82941
		[Nullable(2)]
		private TArray<FSharpherealTestEnum> _EnumArray;

		// Token: 0x040143FE RID: 82942
		internal static int __PropertyOffset_EnumSet;

		// Token: 0x040143FF RID: 82943
		[Nullable(2)]
		private TSet<FSharpherealTestEnum> _EnumSet;

		// Token: 0x04014400 RID: 82944
		internal static int __PropertyOffset_EnumMap;

		// Token: 0x04014401 RID: 82945
		[Nullable(2)]
		private TMap<FSharpherealTestEnum, int> _EnumMap;

		// Token: 0x04014402 RID: 82946
		private static IntPtr __SetEnumSet_NativeFunctionPtr;

		// Token: 0x04014403 RID: 82947
		private static IntPtr __SetEnumMap_NativeFunctionPtr;

		// Token: 0x04014404 RID: 82948
		private static IntPtr __SetEnumAsByteSet_NativeFunctionPtr;

		// Token: 0x04014405 RID: 82949
		private static IntPtr __SetEnumAsByteMap_NativeFunctionPtr;

		// Token: 0x04014406 RID: 82950
		private static IntPtr __SetEnumAsByteArray_NativeFunctionPtr;

		// Token: 0x04014407 RID: 82951
		private static IntPtr __SetEnumAsByte_NativeFunctionPtr;

		// Token: 0x04014408 RID: 82952
		private static IntPtr __SetEnumArray_NativeFunctionPtr;

		// Token: 0x04014409 RID: 82953
		private static IntPtr __SetEnum_NativeFunctionPtr;

		// Token: 0x0401440A RID: 82954
		private static IntPtr __OutEnumSet_NativeFunctionPtr;

		// Token: 0x0401440B RID: 82955
		private static IntPtr __OutEnumMap_NativeFunctionPtr;

		// Token: 0x0401440C RID: 82956
		private static IntPtr __OutEnumAsByteSet_NativeFunctionPtr;

		// Token: 0x0401440D RID: 82957
		private static IntPtr __OutEnumAsByteMap_NativeFunctionPtr;

		// Token: 0x0401440E RID: 82958
		private static IntPtr __OutEnumAsByteArray_NativeFunctionPtr;

		// Token: 0x0401440F RID: 82959
		private static IntPtr __OutEnumAsByte_NativeFunctionPtr;

		// Token: 0x04014410 RID: 82960
		private static IntPtr __OutEnumArray_NativeFunctionPtr;

		// Token: 0x04014411 RID: 82961
		private static IntPtr __OutEnum_NativeFunctionPtr;

		// Token: 0x04014412 RID: 82962
		private static IntPtr __InEnumSet_NativeFunctionPtr;

		// Token: 0x04014413 RID: 82963
		private static IntPtr __InEnumMap_NativeFunctionPtr;

		// Token: 0x04014414 RID: 82964
		private static IntPtr __InEnumAsByteSet_NativeFunctionPtr;

		// Token: 0x04014415 RID: 82965
		private static IntPtr __InEnumAsByteMap_NativeFunctionPtr;

		// Token: 0x04014416 RID: 82966
		private static IntPtr __InEnumAsByteArray_NativeFunctionPtr;

		// Token: 0x04014417 RID: 82967
		private static IntPtr __InEnumAsByte_NativeFunctionPtr;

		// Token: 0x04014418 RID: 82968
		private static IntPtr __InEnumArray_NativeFunctionPtr;

		// Token: 0x04014419 RID: 82969
		private static IntPtr __InEnum_NativeFunctionPtr;

		// Token: 0x0401441A RID: 82970
		private static IntPtr __GetEnumSet_NativeFunctionPtr;

		// Token: 0x0401441B RID: 82971
		private static IntPtr __GetEnumMap_NativeFunctionPtr;

		// Token: 0x0401441C RID: 82972
		private static IntPtr __GetEnumAsByteSet_NativeFunctionPtr;

		// Token: 0x0401441D RID: 82973
		private static IntPtr __GetEnumAsByteMap_NativeFunctionPtr;

		// Token: 0x0401441E RID: 82974
		private static IntPtr __GetEnumAsByteArray_NativeFunctionPtr;

		// Token: 0x0401441F RID: 82975
		private static IntPtr __GetEnumAsByte_NativeFunctionPtr;

		// Token: 0x04014420 RID: 82976
		private static IntPtr __GetEnumArray_NativeFunctionPtr;

		// Token: 0x04014421 RID: 82977
		private static IntPtr __GetEnum_NativeFunctionPtr;

		// Token: 0x02003833 RID: 14387
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetEnumSet_FunctionParams
		{
			// Token: 0x0401795A RID: 96602
			[FieldOffset(0)]
			public byte InEnumSet;
		}

		// Token: 0x02003834 RID: 14388
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetEnumMap_FunctionParams
		{
			// Token: 0x0401795B RID: 96603
			[FieldOffset(0)]
			public byte InEnumMap;
		}

		// Token: 0x02003835 RID: 14389
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetEnumAsByteSet_FunctionParams
		{
			// Token: 0x0401795C RID: 96604
			[FieldOffset(0)]
			public byte InEnumAsByteSet;
		}

		// Token: 0x02003836 RID: 14390
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetEnumAsByteMap_FunctionParams
		{
			// Token: 0x0401795D RID: 96605
			[FieldOffset(0)]
			public byte InEnumAsByteMap;
		}

		// Token: 0x02003837 RID: 14391
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetEnumAsByteArray_FunctionParams
		{
			// Token: 0x0401795E RID: 96606
			[FieldOffset(0)]
			public byte InEnumAsByteArray;
		}

		// Token: 0x02003838 RID: 14392
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetEnumAsByte_FunctionParams
		{
			// Token: 0x0401795F RID: 96607
			[FieldOffset(0)]
			public TEnumAsByte<FSharpherealTestCEnum> InEnumAsByte;
		}

		// Token: 0x02003839 RID: 14393
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetEnumArray_FunctionParams
		{
			// Token: 0x04017960 RID: 96608
			[FieldOffset(0)]
			public byte InEnumArray;
		}

		// Token: 0x0200383A RID: 14394
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetEnum_FunctionParams
		{
			// Token: 0x04017961 RID: 96609
			[FieldOffset(0)]
			public FSharpherealTestEnum InEnum;
		}

		// Token: 0x0200383B RID: 14395
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutEnumSet_FunctionParams
		{
			// Token: 0x04017962 RID: 96610
			[FieldOffset(0)]
			public byte OutEnumSet;
		}

		// Token: 0x0200383C RID: 14396
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutEnumMap_FunctionParams
		{
			// Token: 0x04017963 RID: 96611
			[FieldOffset(0)]
			public byte OutEnumMap;
		}

		// Token: 0x0200383D RID: 14397
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutEnumAsByteSet_FunctionParams
		{
			// Token: 0x04017964 RID: 96612
			[FieldOffset(0)]
			public byte OutEnumAsByteSet;
		}

		// Token: 0x0200383E RID: 14398
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutEnumAsByteMap_FunctionParams
		{
			// Token: 0x04017965 RID: 96613
			[FieldOffset(0)]
			public byte OutEnumAsByteMap;
		}

		// Token: 0x0200383F RID: 14399
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutEnumAsByteArray_FunctionParams
		{
			// Token: 0x04017966 RID: 96614
			[FieldOffset(0)]
			public byte OutEnumAsByteArray;
		}

		// Token: 0x02003840 RID: 14400
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OutEnumAsByte_FunctionParams
		{
			// Token: 0x04017967 RID: 96615
			[FieldOffset(0)]
			public TEnumAsByte<FSharpherealTestCEnum> OutEnumAsByte;
		}

		// Token: 0x02003841 RID: 14401
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutEnumArray_FunctionParams
		{
			// Token: 0x04017968 RID: 96616
			[FieldOffset(0)]
			public byte OutEnumArray;
		}

		// Token: 0x02003842 RID: 14402
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OutEnum_FunctionParams
		{
			// Token: 0x04017969 RID: 96617
			[FieldOffset(0)]
			public FSharpherealTestEnum OutEnum;
		}

		// Token: 0x02003843 RID: 14403
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InEnumSet_FunctionParams
		{
			// Token: 0x0401796A RID: 96618
			[FieldOffset(0)]
			public byte InEnumSet;
		}

		// Token: 0x02003844 RID: 14404
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InEnumMap_FunctionParams
		{
			// Token: 0x0401796B RID: 96619
			[FieldOffset(0)]
			public byte InEnumMap;
		}

		// Token: 0x02003845 RID: 14405
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InEnumAsByteSet_FunctionParams
		{
			// Token: 0x0401796C RID: 96620
			[FieldOffset(0)]
			public byte InEnumAsByteSet;
		}

		// Token: 0x02003846 RID: 14406
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InEnumAsByteMap_FunctionParams
		{
			// Token: 0x0401796D RID: 96621
			[FieldOffset(0)]
			public byte InEnumAsByteMap;
		}

		// Token: 0x02003847 RID: 14407
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InEnumAsByteArray_FunctionParams
		{
			// Token: 0x0401796E RID: 96622
			[FieldOffset(0)]
			public byte InEnumAsByteArray;
		}

		// Token: 0x02003848 RID: 14408
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __InEnumAsByte_FunctionParams
		{
			// Token: 0x0401796F RID: 96623
			[FieldOffset(0)]
			public TEnumAsByte<FSharpherealTestCEnum> InEnumAsByte;
		}

		// Token: 0x02003849 RID: 14409
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InEnumArray_FunctionParams
		{
			// Token: 0x04017970 RID: 96624
			[FieldOffset(0)]
			public byte InEnumArray;
		}

		// Token: 0x0200384A RID: 14410
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __InEnum_FunctionParams
		{
			// Token: 0x04017971 RID: 96625
			[FieldOffset(0)]
			public FSharpherealTestEnum InEnum;
		}

		// Token: 0x0200384B RID: 14411
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetEnumSet_FunctionParams
		{
			// Token: 0x04017972 RID: 96626
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200384C RID: 14412
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetEnumMap_FunctionParams
		{
			// Token: 0x04017973 RID: 96627
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200384D RID: 14413
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetEnumAsByteSet_FunctionParams
		{
			// Token: 0x04017974 RID: 96628
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200384E RID: 14414
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetEnumAsByteMap_FunctionParams
		{
			// Token: 0x04017975 RID: 96629
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200384F RID: 14415
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetEnumAsByteArray_FunctionParams
		{
			// Token: 0x04017976 RID: 96630
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003850 RID: 14416
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetEnumAsByte_FunctionParams
		{
			// Token: 0x04017977 RID: 96631
			[FieldOffset(0)]
			public TEnumAsByte<FSharpherealTestCEnum> __Result;
		}

		// Token: 0x02003851 RID: 14417
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetEnumArray_FunctionParams
		{
			// Token: 0x04017978 RID: 96632
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003852 RID: 14418
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetEnum_FunctionParams
		{
			// Token: 0x04017979 RID: 96633
			[FieldOffset(0)]
			public FSharpherealTestEnum __Result;
		}
	}
}
