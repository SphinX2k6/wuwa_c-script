using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007FC RID: 2044
	[UnrealObjectPath("/Script/SharpherealTest.TestClass_UFunction_Direct_Enum")]
	[UnrealStructLayout(416, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 416)]
	public class UTestClass_UFunction_Direct_Enum : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B185 RID: 45445 RVA: 0x0010EF98 File Offset: 0x0010D198
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTestClass_UFunction_Direct_Enum._ClassPtr;
		}

		// Token: 0x0600B186 RID: 45446 RVA: 0x0010EFA4 File Offset: 0x0010D1A4
		public UTestClass_UFunction_Direct_Enum() : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_Direct_Enum.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B187 RID: 45447 RVA: 0x0010EFCC File Offset: 0x0010D1CC
		[NullableContext(1)]
		public UTestClass_UFunction_Direct_Enum(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_Direct_Enum.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002158 RID: 8536
		// (get) Token: 0x0600B188 RID: 45448 RVA: 0x0010EFFF File Offset: 0x0010D1FF
		// (set) Token: 0x0600B189 RID: 45449 RVA: 0x0010F013 File Offset: 0x0010D213
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

		// Token: 0x17002159 RID: 8537
		// (get) Token: 0x0600B18A RID: 45450 RVA: 0x0010F028 File Offset: 0x0010D228
		// (set) Token: 0x0600B18B RID: 45451 RVA: 0x0010F061 File Offset: 0x0010D261
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

		// Token: 0x1700215A RID: 8538
		// (get) Token: 0x0600B18C RID: 45452 RVA: 0x0010F070 File Offset: 0x0010D270
		// (set) Token: 0x0600B18D RID: 45453 RVA: 0x0010F0A9 File Offset: 0x0010D2A9
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

		// Token: 0x1700215B RID: 8539
		// (get) Token: 0x0600B18E RID: 45454 RVA: 0x0010F0B8 File Offset: 0x0010D2B8
		// (set) Token: 0x0600B18F RID: 45455 RVA: 0x0010F0F1 File Offset: 0x0010D2F1
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

		// Token: 0x1700215C RID: 8540
		// (get) Token: 0x0600B190 RID: 45456 RVA: 0x0010F0FF File Offset: 0x0010D2FF
		// (set) Token: 0x0600B191 RID: 45457 RVA: 0x0010F10F File Offset: 0x0010D30F
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

		// Token: 0x1700215D RID: 8541
		// (get) Token: 0x0600B192 RID: 45458 RVA: 0x0010F120 File Offset: 0x0010D320
		// (set) Token: 0x0600B193 RID: 45459 RVA: 0x0010F159 File Offset: 0x0010D359
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

		// Token: 0x1700215E RID: 8542
		// (get) Token: 0x0600B194 RID: 45460 RVA: 0x0010F168 File Offset: 0x0010D368
		// (set) Token: 0x0600B195 RID: 45461 RVA: 0x0010F1A1 File Offset: 0x0010D3A1
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

		// Token: 0x1700215F RID: 8543
		// (get) Token: 0x0600B196 RID: 45462 RVA: 0x0010F1B0 File Offset: 0x0010D3B0
		// (set) Token: 0x0600B197 RID: 45463 RVA: 0x0010F1E9 File Offset: 0x0010D3E9
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

		// Token: 0x0600B198 RID: 45464 RVA: 0x0010F1F8 File Offset: 0x0010D3F8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetEnumSet(TSet<FSharpherealTestEnum> InEnumSet)
		{
			UTestClass_UFunction_Direct_Enum.__SetEnumSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__SetEnumSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__SetEnumSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__SetEnumSet_NativeFunctionPtr, (void*)ptr, 1);
			if (InEnumSet != null)
			{
				InEnumSet.CopyTo(&ptr->InEnumSet, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__SetEnumSet_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__SetEnumSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B199 RID: 45465 RVA: 0x0010F264 File Offset: 0x0010D464
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetEnumMap(TMap<FSharpherealTestEnum, int> InEnumMap)
		{
			UTestClass_UFunction_Direct_Enum.__SetEnumMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__SetEnumMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__SetEnumMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__SetEnumMap_NativeFunctionPtr, (void*)ptr, 1);
			if (InEnumMap != null)
			{
				InEnumMap.CopyTo(&ptr->InEnumMap, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__SetEnumMap_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__SetEnumMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B19A RID: 45466 RVA: 0x0010F2D0 File Offset: 0x0010D4D0
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__SetEnumAsByteSet_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__SetEnumAsByteSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B19B RID: 45467 RVA: 0x0010F33C File Offset: 0x0010D53C
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__SetEnumAsByteMap_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__SetEnumAsByteMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B19C RID: 45468 RVA: 0x0010F3A8 File Offset: 0x0010D5A8
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__SetEnumAsByteArray_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__SetEnumAsByteArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B19D RID: 45469 RVA: 0x0010F414 File Offset: 0x0010D614
		[SkipLocalsInit]
		public unsafe void SetEnumAsByte(FSharpherealTestCEnum InEnumAsByte)
		{
			UTestClass_UFunction_Direct_Enum.__SetEnumAsByte_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__SetEnumAsByte_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__SetEnumAsByte_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__SetEnumAsByte_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InEnumAsByte = InEnumAsByte;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__SetEnumAsByte_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B19E RID: 45470 RVA: 0x0010F460 File Offset: 0x0010D660
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetEnumArray(TArray<FSharpherealTestEnum> InEnumArray)
		{
			UTestClass_UFunction_Direct_Enum.__SetEnumArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__SetEnumArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__SetEnumArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__SetEnumArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InEnumArray != null)
			{
				InEnumArray.CopyTo(&ptr->InEnumArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__SetEnumArray_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__SetEnumArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B19F RID: 45471 RVA: 0x0010F4CC File Offset: 0x0010D6CC
		[SkipLocalsInit]
		public unsafe void SetEnum(FSharpherealTestEnum InEnum)
		{
			UTestClass_UFunction_Direct_Enum.__SetEnum_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__SetEnum_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__SetEnum_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__SetEnum_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InEnum = InEnum;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__SetEnum_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B1A0 RID: 45472 RVA: 0x0010F514 File Offset: 0x0010D714
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutEnumSet(ref TSet<FSharpherealTestEnum> OutEnumSet)
		{
			UTestClass_UFunction_Direct_Enum.__OutEnumSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__OutEnumSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__OutEnumSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__OutEnumSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<FSharpherealTestEnum> tset = OutEnumSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutEnumSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__OutEnumSet_NativeFunctionPtr, (void*)ptr);
			TSet<FSharpherealTestEnum> tset2 = OutEnumSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutEnumSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__OutEnumSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B1A1 RID: 45473 RVA: 0x0010F58C File Offset: 0x0010D78C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutEnumMap(ref TMap<FSharpherealTestEnum, int> OutEnumMap)
		{
			UTestClass_UFunction_Direct_Enum.__OutEnumMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__OutEnumMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__OutEnumMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__OutEnumMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FSharpherealTestEnum, int> tmap = OutEnumMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutEnumMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__OutEnumMap_NativeFunctionPtr, (void*)ptr);
			TMap<FSharpherealTestEnum, int> tmap2 = OutEnumMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutEnumMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__OutEnumMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B1A2 RID: 45474 RVA: 0x0010F604 File Offset: 0x0010D804
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__OutEnumAsByteSet_NativeFunctionPtr, (void*)ptr);
			TSet<TEnumAsByte<FSharpherealTestCEnum>> tset2 = OutEnumAsByteSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutEnumAsByteSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__OutEnumAsByteSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B1A3 RID: 45475 RVA: 0x0010F67C File Offset: 0x0010D87C
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__OutEnumAsByteMap_NativeFunctionPtr, (void*)ptr);
			TMap<TEnumAsByte<FSharpherealTestCEnum>, int> tmap2 = OutEnumAsByteMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutEnumAsByteMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__OutEnumAsByteMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B1A4 RID: 45476 RVA: 0x0010F6F4 File Offset: 0x0010D8F4
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__OutEnumAsByteArray_NativeFunctionPtr, (void*)ptr);
			TArray<TEnumAsByte<FSharpherealTestCEnum>> tarray2 = OutEnumAsByteArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutEnumAsByteArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__OutEnumAsByteArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B1A5 RID: 45477 RVA: 0x0010F76C File Offset: 0x0010D96C
		[SkipLocalsInit]
		public unsafe void OutEnumAsByte(ref FSharpherealTestCEnum OutEnumAsByte)
		{
			UTestClass_UFunction_Direct_Enum.__OutEnumAsByte_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__OutEnumAsByte_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__OutEnumAsByte_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__OutEnumAsByte_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutEnumAsByte = OutEnumAsByte;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__OutEnumAsByte_NativeFunctionPtr, (void*)ptr);
			OutEnumAsByte = ptr->OutEnumAsByte;
		}

		// Token: 0x0600B1A6 RID: 45478 RVA: 0x0010F7C8 File Offset: 0x0010D9C8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutEnumArray(ref TArray<FSharpherealTestEnum> OutEnumArray)
		{
			UTestClass_UFunction_Direct_Enum.__OutEnumArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__OutEnumArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__OutEnumArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__OutEnumArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FSharpherealTestEnum> tarray = OutEnumArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutEnumArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__OutEnumArray_NativeFunctionPtr, (void*)ptr);
			TArray<FSharpherealTestEnum> tarray2 = OutEnumArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutEnumArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__OutEnumArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B1A7 RID: 45479 RVA: 0x0010F840 File Offset: 0x0010DA40
		[SkipLocalsInit]
		public unsafe void OutEnum(ref FSharpherealTestEnum OutEnum)
		{
			UTestClass_UFunction_Direct_Enum.__OutEnum_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__OutEnum_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__OutEnum_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__OutEnum_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutEnum = OutEnum;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__OutEnum_NativeFunctionPtr, (void*)ptr);
			OutEnum = ptr->OutEnum;
		}

		// Token: 0x0600B1A8 RID: 45480 RVA: 0x0010F890 File Offset: 0x0010DA90
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InEnumSet(in TSet<FSharpherealTestEnum> InEnumSet)
		{
			UTestClass_UFunction_Direct_Enum.__InEnumSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__InEnumSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__InEnumSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__InEnumSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<FSharpherealTestEnum> tset = InEnumSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InEnumSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__InEnumSet_NativeFunctionPtr, (void*)ptr);
			TSet<FSharpherealTestEnum> tset2 = InEnumSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InEnumSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__InEnumSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B1A9 RID: 45481 RVA: 0x0010F908 File Offset: 0x0010DB08
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InEnumMap(in TMap<FSharpherealTestEnum, int> InEnumMap)
		{
			UTestClass_UFunction_Direct_Enum.__InEnumMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__InEnumMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__InEnumMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__InEnumMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FSharpherealTestEnum, int> tmap = InEnumMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InEnumMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__InEnumMap_NativeFunctionPtr, (void*)ptr);
			TMap<FSharpherealTestEnum, int> tmap2 = InEnumMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InEnumMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__InEnumMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B1AA RID: 45482 RVA: 0x0010F980 File Offset: 0x0010DB80
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__InEnumAsByteSet_NativeFunctionPtr, (void*)ptr);
			TSet<TEnumAsByte<FSharpherealTestCEnum>> tset2 = InEnumAsByteSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InEnumAsByteSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__InEnumAsByteSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B1AB RID: 45483 RVA: 0x0010F9F8 File Offset: 0x0010DBF8
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__InEnumAsByteMap_NativeFunctionPtr, (void*)ptr);
			TMap<TEnumAsByte<FSharpherealTestCEnum>, int> tmap2 = InEnumAsByteMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InEnumAsByteMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__InEnumAsByteMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B1AC RID: 45484 RVA: 0x0010FA70 File Offset: 0x0010DC70
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__InEnumAsByteArray_NativeFunctionPtr, (void*)ptr);
			TArray<TEnumAsByte<FSharpherealTestCEnum>> tarray2 = InEnumAsByteArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InEnumAsByteArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__InEnumAsByteArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B1AD RID: 45485 RVA: 0x0010FAE8 File Offset: 0x0010DCE8
		[SkipLocalsInit]
		public unsafe void InEnumAsByte(in FSharpherealTestCEnum InEnumAsByte)
		{
			UTestClass_UFunction_Direct_Enum.__InEnumAsByte_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__InEnumAsByte_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__InEnumAsByte_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__InEnumAsByte_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InEnumAsByte = InEnumAsByte;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__InEnumAsByte_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B1AE RID: 45486 RVA: 0x0010FB34 File Offset: 0x0010DD34
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InEnumArray(in TArray<FSharpherealTestEnum> InEnumArray)
		{
			UTestClass_UFunction_Direct_Enum.__InEnumArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__InEnumArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__InEnumArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__InEnumArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FSharpherealTestEnum> tarray = InEnumArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InEnumArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__InEnumArray_NativeFunctionPtr, (void*)ptr);
			TArray<FSharpherealTestEnum> tarray2 = InEnumArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InEnumArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__InEnumArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B1AF RID: 45487 RVA: 0x0010FBAC File Offset: 0x0010DDAC
		[SkipLocalsInit]
		public unsafe void InEnum(in FSharpherealTestEnum InEnum)
		{
			UTestClass_UFunction_Direct_Enum.__InEnum_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__InEnum_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__InEnum_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__InEnum_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InEnum = InEnum;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__InEnum_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B1B0 RID: 45488 RVA: 0x0010FBF4 File Offset: 0x0010DDF4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSet<FSharpherealTestEnum> GetEnumSet()
		{
			UTestClass_UFunction_Direct_Enum.__GetEnumSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__GetEnumSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__GetEnumSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__GetEnumSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__GetEnumSet_NativeFunctionPtr, (void*)ptr);
			TSet<FSharpherealTestEnum> result = new TSet<FSharpherealTestEnum>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__GetEnumSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B1B1 RID: 45489 RVA: 0x0010FC54 File Offset: 0x0010DE54
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TMap<FSharpherealTestEnum, int> GetEnumMap()
		{
			UTestClass_UFunction_Direct_Enum.__GetEnumMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__GetEnumMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__GetEnumMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__GetEnumMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__GetEnumMap_NativeFunctionPtr, (void*)ptr);
			TMap<FSharpherealTestEnum, int> result = new TMap<FSharpherealTestEnum, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__GetEnumMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B1B2 RID: 45490 RVA: 0x0010FCB4 File Offset: 0x0010DEB4
		[SkipLocalsInit]
		[return: Nullable(new byte[]
		{
			1,
			0
		})]
		public unsafe TSet<TEnumAsByte<FSharpherealTestCEnum>> GetEnumAsByteSet()
		{
			UTestClass_UFunction_Direct_Enum.__GetEnumAsByteSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__GetEnumAsByteSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__GetEnumAsByteSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__GetEnumAsByteSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__GetEnumAsByteSet_NativeFunctionPtr, (void*)ptr);
			TSet<TEnumAsByte<FSharpherealTestCEnum>> result = new TSet<TEnumAsByte<FSharpherealTestCEnum>>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__GetEnumAsByteSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B1B3 RID: 45491 RVA: 0x0010FD14 File Offset: 0x0010DF14
		[SkipLocalsInit]
		[return: Nullable(new byte[]
		{
			1,
			0
		})]
		public unsafe TMap<TEnumAsByte<FSharpherealTestCEnum>, int> GetEnumAsByteMap()
		{
			UTestClass_UFunction_Direct_Enum.__GetEnumAsByteMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__GetEnumAsByteMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__GetEnumAsByteMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__GetEnumAsByteMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__GetEnumAsByteMap_NativeFunctionPtr, (void*)ptr);
			TMap<TEnumAsByte<FSharpherealTestCEnum>, int> result = new TMap<TEnumAsByte<FSharpherealTestCEnum>, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__GetEnumAsByteMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B1B4 RID: 45492 RVA: 0x0010FD74 File Offset: 0x0010DF74
		[SkipLocalsInit]
		[return: Nullable(new byte[]
		{
			1,
			0
		})]
		public unsafe TArray<TEnumAsByte<FSharpherealTestCEnum>> GetEnumAsByteArray()
		{
			UTestClass_UFunction_Direct_Enum.__GetEnumAsByteArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__GetEnumAsByteArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__GetEnumAsByteArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__GetEnumAsByteArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__GetEnumAsByteArray_NativeFunctionPtr, (void*)ptr);
			TArray<TEnumAsByte<FSharpherealTestCEnum>> result = new TArray<TEnumAsByte<FSharpherealTestCEnum>>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__GetEnumAsByteArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B1B5 RID: 45493 RVA: 0x0010FDD4 File Offset: 0x0010DFD4
		[SkipLocalsInit]
		public unsafe TEnumAsByte<FSharpherealTestCEnum> GetEnumAsByte()
		{
			UTestClass_UFunction_Direct_Enum.__GetEnumAsByte_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__GetEnumAsByte_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__GetEnumAsByte_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__GetEnumAsByte_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__GetEnumAsByte_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B1B6 RID: 45494 RVA: 0x0010FE1C File Offset: 0x0010E01C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<FSharpherealTestEnum> GetEnumArray()
		{
			UTestClass_UFunction_Direct_Enum.__GetEnumArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__GetEnumArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__GetEnumArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__GetEnumArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__GetEnumArray_NativeFunctionPtr, (void*)ptr);
			TArray<FSharpherealTestEnum> result = new TArray<FSharpherealTestEnum>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Enum.__GetEnumArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B1B7 RID: 45495 RVA: 0x0010FE7C File Offset: 0x0010E07C
		[SkipLocalsInit]
		public unsafe FSharpherealTestEnum GetEnum()
		{
			UTestClass_UFunction_Direct_Enum.__GetEnum_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Enum.__GetEnum_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Enum.__GetEnum_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Enum.__GetEnum_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Enum.__GetEnum_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B1B8 RID: 45496 RVA: 0x0010FEC1 File Offset: 0x0010E0C1
		static UTestClass_UFunction_Direct_Enum()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SharpherealTest.TestClass_UFunction_Direct_Enum");
		}

		// Token: 0x0600B1B9 RID: 45497 RVA: 0x0010FECF File Offset: 0x0010E0CF
		protected UTestClass_UFunction_Direct_Enum(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004E50 RID: 20048
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SharpherealTest.TestClass_UFunction_Direct_Enum";

		// Token: 0x04004E51 RID: 20049
		private static IntPtr _ClassPtr;

		// Token: 0x04004E52 RID: 20050
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004E53 RID: 20051
		internal static int __PropertyOffset_EnumAsByte;

		// Token: 0x04004E54 RID: 20052
		internal static int __PropertyOffset_EnumAsByteArray;

		// Token: 0x04004E55 RID: 20053
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<FSharpherealTestCEnum>> _EnumAsByteArray;

		// Token: 0x04004E56 RID: 20054
		internal static int __PropertyOffset_EnumAsByteSet;

		// Token: 0x04004E57 RID: 20055
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TSet<TEnumAsByte<FSharpherealTestCEnum>> _EnumAsByteSet;

		// Token: 0x04004E58 RID: 20056
		internal static int __PropertyOffset_EnumAsByteMap;

		// Token: 0x04004E59 RID: 20057
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<FSharpherealTestCEnum>, int> _EnumAsByteMap;

		// Token: 0x04004E5A RID: 20058
		internal static int __PropertyOffset_Enum;

		// Token: 0x04004E5B RID: 20059
		internal static int __PropertyOffset_EnumArray;

		// Token: 0x04004E5C RID: 20060
		[Nullable(2)]
		private TArray<FSharpherealTestEnum> _EnumArray;

		// Token: 0x04004E5D RID: 20061
		internal static int __PropertyOffset_EnumSet;

		// Token: 0x04004E5E RID: 20062
		[Nullable(2)]
		private TSet<FSharpherealTestEnum> _EnumSet;

		// Token: 0x04004E5F RID: 20063
		internal static int __PropertyOffset_EnumMap;

		// Token: 0x04004E60 RID: 20064
		[Nullable(2)]
		private TMap<FSharpherealTestEnum, int> _EnumMap;

		// Token: 0x04004E61 RID: 20065
		private static IntPtr __SetEnumSet_NativeFunctionPtr;

		// Token: 0x04004E62 RID: 20066
		private static IntPtr __SetEnumMap_NativeFunctionPtr;

		// Token: 0x04004E63 RID: 20067
		private static IntPtr __SetEnumAsByteSet_NativeFunctionPtr;

		// Token: 0x04004E64 RID: 20068
		private static IntPtr __SetEnumAsByteMap_NativeFunctionPtr;

		// Token: 0x04004E65 RID: 20069
		private static IntPtr __SetEnumAsByteArray_NativeFunctionPtr;

		// Token: 0x04004E66 RID: 20070
		private static IntPtr __SetEnumAsByte_NativeFunctionPtr;

		// Token: 0x04004E67 RID: 20071
		private static IntPtr __SetEnumArray_NativeFunctionPtr;

		// Token: 0x04004E68 RID: 20072
		private static IntPtr __SetEnum_NativeFunctionPtr;

		// Token: 0x04004E69 RID: 20073
		private static IntPtr __OutEnumSet_NativeFunctionPtr;

		// Token: 0x04004E6A RID: 20074
		private static IntPtr __OutEnumMap_NativeFunctionPtr;

		// Token: 0x04004E6B RID: 20075
		private static IntPtr __OutEnumAsByteSet_NativeFunctionPtr;

		// Token: 0x04004E6C RID: 20076
		private static IntPtr __OutEnumAsByteMap_NativeFunctionPtr;

		// Token: 0x04004E6D RID: 20077
		private static IntPtr __OutEnumAsByteArray_NativeFunctionPtr;

		// Token: 0x04004E6E RID: 20078
		private static IntPtr __OutEnumAsByte_NativeFunctionPtr;

		// Token: 0x04004E6F RID: 20079
		private static IntPtr __OutEnumArray_NativeFunctionPtr;

		// Token: 0x04004E70 RID: 20080
		private static IntPtr __OutEnum_NativeFunctionPtr;

		// Token: 0x04004E71 RID: 20081
		private static IntPtr __InEnumSet_NativeFunctionPtr;

		// Token: 0x04004E72 RID: 20082
		private static IntPtr __InEnumMap_NativeFunctionPtr;

		// Token: 0x04004E73 RID: 20083
		private static IntPtr __InEnumAsByteSet_NativeFunctionPtr;

		// Token: 0x04004E74 RID: 20084
		private static IntPtr __InEnumAsByteMap_NativeFunctionPtr;

		// Token: 0x04004E75 RID: 20085
		private static IntPtr __InEnumAsByteArray_NativeFunctionPtr;

		// Token: 0x04004E76 RID: 20086
		private static IntPtr __InEnumAsByte_NativeFunctionPtr;

		// Token: 0x04004E77 RID: 20087
		private static IntPtr __InEnumArray_NativeFunctionPtr;

		// Token: 0x04004E78 RID: 20088
		private static IntPtr __InEnum_NativeFunctionPtr;

		// Token: 0x04004E79 RID: 20089
		private static IntPtr __GetEnumSet_NativeFunctionPtr;

		// Token: 0x04004E7A RID: 20090
		private static IntPtr __GetEnumMap_NativeFunctionPtr;

		// Token: 0x04004E7B RID: 20091
		private static IntPtr __GetEnumAsByteSet_NativeFunctionPtr;

		// Token: 0x04004E7C RID: 20092
		private static IntPtr __GetEnumAsByteMap_NativeFunctionPtr;

		// Token: 0x04004E7D RID: 20093
		private static IntPtr __GetEnumAsByteArray_NativeFunctionPtr;

		// Token: 0x04004E7E RID: 20094
		private static IntPtr __GetEnumAsByte_NativeFunctionPtr;

		// Token: 0x04004E7F RID: 20095
		private static IntPtr __GetEnumArray_NativeFunctionPtr;

		// Token: 0x04004E80 RID: 20096
		private static IntPtr __GetEnum_NativeFunctionPtr;

		// Token: 0x02001105 RID: 4357
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetEnumSet_FunctionParams
		{
			// Token: 0x0400650D RID: 25869
			[FieldOffset(0)]
			public byte InEnumSet;
		}

		// Token: 0x02001106 RID: 4358
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetEnumMap_FunctionParams
		{
			// Token: 0x0400650E RID: 25870
			[FieldOffset(0)]
			public byte InEnumMap;
		}

		// Token: 0x02001107 RID: 4359
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetEnumAsByteSet_FunctionParams
		{
			// Token: 0x0400650F RID: 25871
			[FieldOffset(0)]
			public byte InEnumAsByteSet;
		}

		// Token: 0x02001108 RID: 4360
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetEnumAsByteMap_FunctionParams
		{
			// Token: 0x04006510 RID: 25872
			[FieldOffset(0)]
			public byte InEnumAsByteMap;
		}

		// Token: 0x02001109 RID: 4361
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetEnumAsByteArray_FunctionParams
		{
			// Token: 0x04006511 RID: 25873
			[FieldOffset(0)]
			public byte InEnumAsByteArray;
		}

		// Token: 0x0200110A RID: 4362
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetEnumAsByte_FunctionParams
		{
			// Token: 0x04006512 RID: 25874
			[FieldOffset(0)]
			public TEnumAsByte<FSharpherealTestCEnum> InEnumAsByte;
		}

		// Token: 0x0200110B RID: 4363
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetEnumArray_FunctionParams
		{
			// Token: 0x04006513 RID: 25875
			[FieldOffset(0)]
			public byte InEnumArray;
		}

		// Token: 0x0200110C RID: 4364
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetEnum_FunctionParams
		{
			// Token: 0x04006514 RID: 25876
			[FieldOffset(0)]
			public FSharpherealTestEnum InEnum;
		}

		// Token: 0x0200110D RID: 4365
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutEnumSet_FunctionParams
		{
			// Token: 0x04006515 RID: 25877
			[FieldOffset(0)]
			public byte OutEnumSet;
		}

		// Token: 0x0200110E RID: 4366
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutEnumMap_FunctionParams
		{
			// Token: 0x04006516 RID: 25878
			[FieldOffset(0)]
			public byte OutEnumMap;
		}

		// Token: 0x0200110F RID: 4367
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutEnumAsByteSet_FunctionParams
		{
			// Token: 0x04006517 RID: 25879
			[FieldOffset(0)]
			public byte OutEnumAsByteSet;
		}

		// Token: 0x02001110 RID: 4368
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutEnumAsByteMap_FunctionParams
		{
			// Token: 0x04006518 RID: 25880
			[FieldOffset(0)]
			public byte OutEnumAsByteMap;
		}

		// Token: 0x02001111 RID: 4369
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutEnumAsByteArray_FunctionParams
		{
			// Token: 0x04006519 RID: 25881
			[FieldOffset(0)]
			public byte OutEnumAsByteArray;
		}

		// Token: 0x02001112 RID: 4370
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OutEnumAsByte_FunctionParams
		{
			// Token: 0x0400651A RID: 25882
			[FieldOffset(0)]
			public TEnumAsByte<FSharpherealTestCEnum> OutEnumAsByte;
		}

		// Token: 0x02001113 RID: 4371
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutEnumArray_FunctionParams
		{
			// Token: 0x0400651B RID: 25883
			[FieldOffset(0)]
			public byte OutEnumArray;
		}

		// Token: 0x02001114 RID: 4372
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OutEnum_FunctionParams
		{
			// Token: 0x0400651C RID: 25884
			[FieldOffset(0)]
			public FSharpherealTestEnum OutEnum;
		}

		// Token: 0x02001115 RID: 4373
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InEnumSet_FunctionParams
		{
			// Token: 0x0400651D RID: 25885
			[FieldOffset(0)]
			public byte InEnumSet;
		}

		// Token: 0x02001116 RID: 4374
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InEnumMap_FunctionParams
		{
			// Token: 0x0400651E RID: 25886
			[FieldOffset(0)]
			public byte InEnumMap;
		}

		// Token: 0x02001117 RID: 4375
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InEnumAsByteSet_FunctionParams
		{
			// Token: 0x0400651F RID: 25887
			[FieldOffset(0)]
			public byte InEnumAsByteSet;
		}

		// Token: 0x02001118 RID: 4376
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InEnumAsByteMap_FunctionParams
		{
			// Token: 0x04006520 RID: 25888
			[FieldOffset(0)]
			public byte InEnumAsByteMap;
		}

		// Token: 0x02001119 RID: 4377
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InEnumAsByteArray_FunctionParams
		{
			// Token: 0x04006521 RID: 25889
			[FieldOffset(0)]
			public byte InEnumAsByteArray;
		}

		// Token: 0x0200111A RID: 4378
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __InEnumAsByte_FunctionParams
		{
			// Token: 0x04006522 RID: 25890
			[FieldOffset(0)]
			public TEnumAsByte<FSharpherealTestCEnum> InEnumAsByte;
		}

		// Token: 0x0200111B RID: 4379
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InEnumArray_FunctionParams
		{
			// Token: 0x04006523 RID: 25891
			[FieldOffset(0)]
			public byte InEnumArray;
		}

		// Token: 0x0200111C RID: 4380
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __InEnum_FunctionParams
		{
			// Token: 0x04006524 RID: 25892
			[FieldOffset(0)]
			public FSharpherealTestEnum InEnum;
		}

		// Token: 0x0200111D RID: 4381
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetEnumSet_FunctionParams
		{
			// Token: 0x04006525 RID: 25893
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200111E RID: 4382
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetEnumMap_FunctionParams
		{
			// Token: 0x04006526 RID: 25894
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200111F RID: 4383
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetEnumAsByteSet_FunctionParams
		{
			// Token: 0x04006527 RID: 25895
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001120 RID: 4384
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetEnumAsByteMap_FunctionParams
		{
			// Token: 0x04006528 RID: 25896
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001121 RID: 4385
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetEnumAsByteArray_FunctionParams
		{
			// Token: 0x04006529 RID: 25897
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001122 RID: 4386
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetEnumAsByte_FunctionParams
		{
			// Token: 0x0400652A RID: 25898
			[FieldOffset(0)]
			public TEnumAsByte<FSharpherealTestCEnum> __Result;
		}

		// Token: 0x02001123 RID: 4387
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetEnumArray_FunctionParams
		{
			// Token: 0x0400652B RID: 25899
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001124 RID: 4388
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetEnum_FunctionParams
		{
			// Token: 0x0400652C RID: 25900
			[FieldOffset(0)]
			public FSharpherealTestEnum __Result;
		}
	}
}
