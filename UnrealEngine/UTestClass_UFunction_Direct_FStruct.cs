using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007FD RID: 2045
	[UnrealObjectPath("/Script/SharpherealTest.TestClass_UFunction_Direct_FStruct")]
	[UnrealStructLayout(544, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 544)]
	public class UTestClass_UFunction_Direct_FStruct : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B1BA RID: 45498 RVA: 0x0010FED8 File Offset: 0x0010E0D8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTestClass_UFunction_Direct_FStruct._ClassPtr;
		}

		// Token: 0x0600B1BB RID: 45499 RVA: 0x0010FEE4 File Offset: 0x0010E0E4
		public UTestClass_UFunction_Direct_FStruct() : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_Direct_FStruct.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B1BC RID: 45500 RVA: 0x0010FF0C File Offset: 0x0010E10C
		[NullableContext(1)]
		public UTestClass_UFunction_Direct_FStruct(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_Direct_FStruct.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002160 RID: 8544
		// (get) Token: 0x0600B1BD RID: 45501 RVA: 0x0010FF3F File Offset: 0x0010E13F
		// (set) Token: 0x0600B1BE RID: 45502 RVA: 0x0010FF53 File Offset: 0x0010E153
		public unsafe FVector Vector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_FStruct.__PropertyOffset_Vector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_FStruct.__PropertyOffset_Vector) = value;
			}
		}

		// Token: 0x17002161 RID: 8545
		// (get) Token: 0x0600B1BF RID: 45503 RVA: 0x0010FF68 File Offset: 0x0010E168
		// (set) Token: 0x0600B1C0 RID: 45504 RVA: 0x0010FFA1 File Offset: 0x0010E1A1
		[Nullable(1)]
		public TArray<FVector> VectorArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._VectorArray) == null)
				{
					result = (this._VectorArray = new TArray<FVector>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_FStruct.__PropertyOffset_VectorArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.VectorArray.CopyAssign(value);
			}
		}

		// Token: 0x17002162 RID: 8546
		// (get) Token: 0x0600B1C1 RID: 45505 RVA: 0x0010FFB0 File Offset: 0x0010E1B0
		// (set) Token: 0x0600B1C2 RID: 45506 RVA: 0x0010FFE9 File Offset: 0x0010E1E9
		[Nullable(1)]
		public TSet<FVector> VectorSet
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TSet<FVector> result;
				if ((result = this._VectorSet) == null)
				{
					result = (this._VectorSet = new TSet<FVector>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_FStruct.__PropertyOffset_VectorSet, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.VectorSet.CopyAssign(value);
			}
		}

		// Token: 0x17002163 RID: 8547
		// (get) Token: 0x0600B1C3 RID: 45507 RVA: 0x0010FFF8 File Offset: 0x0010E1F8
		// (set) Token: 0x0600B1C4 RID: 45508 RVA: 0x00110031 File Offset: 0x0010E231
		[Nullable(1)]
		public TMap<FVector, int> VectorMap
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FVector, int> result;
				if ((result = this._VectorMap) == null)
				{
					result = (this._VectorMap = new TMap<FVector, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_FStruct.__PropertyOffset_VectorMap, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.VectorMap.CopyAssign(value);
			}
		}

		// Token: 0x17002164 RID: 8548
		// (get) Token: 0x0600B1C5 RID: 45509 RVA: 0x0011003F File Offset: 0x0010E23F
		// (set) Token: 0x0600B1C6 RID: 45510 RVA: 0x00110053 File Offset: 0x0010E253
		public unsafe FQuat Quat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_FStruct.__PropertyOffset_Quat);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_FStruct.__PropertyOffset_Quat) = value;
			}
		}

		// Token: 0x17002165 RID: 8549
		// (get) Token: 0x0600B1C7 RID: 45511 RVA: 0x00110068 File Offset: 0x0010E268
		// (set) Token: 0x0600B1C8 RID: 45512 RVA: 0x001100A1 File Offset: 0x0010E2A1
		[Nullable(1)]
		public TArray<FQuat> QuatArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FQuat> result;
				if ((result = this._QuatArray) == null)
				{
					result = (this._QuatArray = new TArray<FQuat>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_FStruct.__PropertyOffset_QuatArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.QuatArray.CopyAssign(value);
			}
		}

		// Token: 0x17002166 RID: 8550
		// (get) Token: 0x0600B1C9 RID: 45513 RVA: 0x001100AF File Offset: 0x0010E2AF
		// (set) Token: 0x0600B1CA RID: 45514 RVA: 0x001100C3 File Offset: 0x0010E2C3
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_FStruct.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_FStruct.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x17002167 RID: 8551
		// (get) Token: 0x0600B1CB RID: 45515 RVA: 0x001100D8 File Offset: 0x0010E2D8
		// (set) Token: 0x0600B1CC RID: 45516 RVA: 0x00110111 File Offset: 0x0010E311
		[Nullable(1)]
		public TArray<FTransform> TransformArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._TransformArray) == null)
				{
					result = (this._TransformArray = new TArray<FTransform>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_FStruct.__PropertyOffset_TransformArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.TransformArray.CopyAssign(value);
			}
		}

		// Token: 0x17002168 RID: 8552
		// (get) Token: 0x0600B1CD RID: 45517 RVA: 0x00110120 File Offset: 0x0010E320
		// (set) Token: 0x0600B1CE RID: 45518 RVA: 0x00110159 File Offset: 0x0010E359
		[Nullable(1)]
		public FSharpherealTestSimpleStruct SimpleStruct
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FSharpherealTestSimpleStruct result;
				if ((result = this._SimpleStruct) == null)
				{
					result = (this._SimpleStruct = new FSharpherealTestSimpleStruct(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_FStruct.__PropertyOffset_SimpleStruct, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSharpherealTestSimpleStruct.StaticStruct(), base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_FStruct.__PropertyOffset_SimpleStruct, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002169 RID: 8553
		// (get) Token: 0x0600B1CF RID: 45519 RVA: 0x0011017C File Offset: 0x0010E37C
		// (set) Token: 0x0600B1D0 RID: 45520 RVA: 0x001101B5 File Offset: 0x0010E3B5
		[Nullable(1)]
		public TArray<FSharpherealTestSimpleStruct> SimpleStructArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FSharpherealTestSimpleStruct> result;
				if ((result = this._SimpleStructArray) == null)
				{
					result = (this._SimpleStructArray = new TArray<FSharpherealTestSimpleStruct>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_FStruct.__PropertyOffset_SimpleStructArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SimpleStructArray.CopyAssign(value);
			}
		}

		// Token: 0x1700216A RID: 8554
		// (get) Token: 0x0600B1D1 RID: 45521 RVA: 0x001101C4 File Offset: 0x0010E3C4
		// (set) Token: 0x0600B1D2 RID: 45522 RVA: 0x001101FD File Offset: 0x0010E3FD
		[Nullable(1)]
		public TSet<FSharpherealTestSimpleStruct> SimpleStructSet
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TSet<FSharpherealTestSimpleStruct> result;
				if ((result = this._SimpleStructSet) == null)
				{
					result = (this._SimpleStructSet = new TSet<FSharpherealTestSimpleStruct>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_FStruct.__PropertyOffset_SimpleStructSet, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SimpleStructSet.CopyAssign(value);
			}
		}

		// Token: 0x1700216B RID: 8555
		// (get) Token: 0x0600B1D3 RID: 45523 RVA: 0x0011020C File Offset: 0x0010E40C
		// (set) Token: 0x0600B1D4 RID: 45524 RVA: 0x00110245 File Offset: 0x0010E445
		[Nullable(1)]
		public TMap<FSharpherealTestSimpleStruct, int> SimpleStructMap
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FSharpherealTestSimpleStruct, int> result;
				if ((result = this._SimpleStructMap) == null)
				{
					result = (this._SimpleStructMap = new TMap<FSharpherealTestSimpleStruct, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_FStruct.__PropertyOffset_SimpleStructMap, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SimpleStructMap.CopyAssign(value);
			}
		}

		// Token: 0x0600B1D5 RID: 45525 RVA: 0x00110254 File Offset: 0x0010E454
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetVectorSet(TSet<FVector> InVectorSet)
		{
			UTestClass_UFunction_Direct_FStruct.__SetVectorSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__SetVectorSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__SetVectorSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__SetVectorSet_NativeFunctionPtr, (void*)ptr, 1);
			if (InVectorSet != null)
			{
				InVectorSet.CopyTo(&ptr->InVectorSet, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__SetVectorSet_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__SetVectorSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B1D6 RID: 45526 RVA: 0x001102C0 File Offset: 0x0010E4C0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetVectorMap(TMap<FVector, int> InVectorMap)
		{
			UTestClass_UFunction_Direct_FStruct.__SetVectorMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__SetVectorMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__SetVectorMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__SetVectorMap_NativeFunctionPtr, (void*)ptr, 1);
			if (InVectorMap != null)
			{
				InVectorMap.CopyTo(&ptr->InVectorMap, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__SetVectorMap_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__SetVectorMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B1D7 RID: 45527 RVA: 0x0011032C File Offset: 0x0010E52C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetVectorArray(TArray<FVector> InVectorArray)
		{
			UTestClass_UFunction_Direct_FStruct.__SetVectorArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__SetVectorArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__SetVectorArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__SetVectorArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InVectorArray != null)
			{
				InVectorArray.CopyTo(&ptr->InVectorArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__SetVectorArray_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__SetVectorArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B1D8 RID: 45528 RVA: 0x00110398 File Offset: 0x0010E598
		[SkipLocalsInit]
		public unsafe void SetVector(FVector InVector)
		{
			UTestClass_UFunction_Direct_FStruct.__SetVector_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__SetVector_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__SetVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__SetVector_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InVector = InVector;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__SetVector_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B1D9 RID: 45529 RVA: 0x001103E0 File Offset: 0x0010E5E0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetTransformArray(TArray<FTransform> InTransformArray)
		{
			UTestClass_UFunction_Direct_FStruct.__SetTransformArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__SetTransformArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__SetTransformArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__SetTransformArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InTransformArray != null)
			{
				InTransformArray.CopyTo(&ptr->InTransformArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__SetTransformArray_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__SetTransformArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B1DA RID: 45530 RVA: 0x0011044C File Offset: 0x0010E64C
		[SkipLocalsInit]
		public unsafe void SetTransform(FTransform InTransform)
		{
			UTestClass_UFunction_Direct_FStruct.__SetTransform_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__SetTransform_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__SetTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__SetTransform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InTransform = InTransform;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__SetTransform_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B1DB RID: 45531 RVA: 0x00110494 File Offset: 0x0010E694
		[SkipLocalsInit]
		public unsafe void SetSimpleStructSet([Nullable(new byte[]
		{
			2,
			1
		})] TSet<FSharpherealTestSimpleStruct> InSimpleStructSet)
		{
			UTestClass_UFunction_Direct_FStruct.__SetSimpleStructSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__SetSimpleStructSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__SetSimpleStructSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__SetSimpleStructSet_NativeFunctionPtr, (void*)ptr, 1);
			if (InSimpleStructSet != null)
			{
				InSimpleStructSet.CopyTo(&ptr->InSimpleStructSet, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__SetSimpleStructSet_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__SetSimpleStructSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B1DC RID: 45532 RVA: 0x00110500 File Offset: 0x0010E700
		[SkipLocalsInit]
		public unsafe void SetSimpleStructMap([Nullable(new byte[]
		{
			2,
			1
		})] TMap<FSharpherealTestSimpleStruct, int> InSimpleStructMap)
		{
			UTestClass_UFunction_Direct_FStruct.__SetSimpleStructMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__SetSimpleStructMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__SetSimpleStructMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__SetSimpleStructMap_NativeFunctionPtr, (void*)ptr, 1);
			if (InSimpleStructMap != null)
			{
				InSimpleStructMap.CopyTo(&ptr->InSimpleStructMap, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__SetSimpleStructMap_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__SetSimpleStructMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B1DD RID: 45533 RVA: 0x0011056C File Offset: 0x0010E76C
		[SkipLocalsInit]
		public unsafe void SetSimpleStructArray([Nullable(new byte[]
		{
			2,
			1
		})] TArray<FSharpherealTestSimpleStruct> InSimpleStructArray)
		{
			UTestClass_UFunction_Direct_FStruct.__SetSimpleStructArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__SetSimpleStructArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__SetSimpleStructArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__SetSimpleStructArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InSimpleStructArray != null)
			{
				InSimpleStructArray.CopyTo(&ptr->InSimpleStructArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__SetSimpleStructArray_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__SetSimpleStructArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B1DE RID: 45534 RVA: 0x001105D8 File Offset: 0x0010E7D8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetSimpleStruct(FSharpherealTestSimpleStruct InSimpleStruct)
		{
			UTestClass_UFunction_Direct_FStruct.__SetSimpleStruct_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__SetSimpleStruct_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__SetSimpleStruct_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__SetSimpleStruct_NativeFunctionPtr, (void*)ptr, 1);
			if (InSimpleStruct != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSharpherealTestSimpleStruct.StaticStruct(), &ptr->InSimpleStruct, InSimpleStruct.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__SetSimpleStruct_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__SetSimpleStruct_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B1DF RID: 45535 RVA: 0x0011064C File Offset: 0x0010E84C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetQuatArray(TArray<FQuat> InQuatArray)
		{
			UTestClass_UFunction_Direct_FStruct.__SetQuatArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__SetQuatArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__SetQuatArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__SetQuatArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InQuatArray != null)
			{
				InQuatArray.CopyTo(&ptr->InQuatArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__SetQuatArray_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__SetQuatArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B1E0 RID: 45536 RVA: 0x001106B8 File Offset: 0x0010E8B8
		[SkipLocalsInit]
		public unsafe void SetQuat(FQuat InQuat)
		{
			UTestClass_UFunction_Direct_FStruct.__SetQuat_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__SetQuat_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__SetQuat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__SetQuat_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InQuat = InQuat;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__SetQuat_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B1E1 RID: 45537 RVA: 0x00110700 File Offset: 0x0010E900
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutVectorSet(ref TSet<FVector> OutVectorSet)
		{
			UTestClass_UFunction_Direct_FStruct.__OutVectorSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__OutVectorSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__OutVectorSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__OutVectorSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<FVector> tset = OutVectorSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutVectorSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__OutVectorSet_NativeFunctionPtr, (void*)ptr);
			TSet<FVector> tset2 = OutVectorSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutVectorSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__OutVectorSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B1E2 RID: 45538 RVA: 0x00110778 File Offset: 0x0010E978
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutVectorMap(ref TMap<FVector, int> OutVectorMap)
		{
			UTestClass_UFunction_Direct_FStruct.__OutVectorMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__OutVectorMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__OutVectorMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__OutVectorMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FVector, int> tmap = OutVectorMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutVectorMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__OutVectorMap_NativeFunctionPtr, (void*)ptr);
			TMap<FVector, int> tmap2 = OutVectorMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutVectorMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__OutVectorMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B1E3 RID: 45539 RVA: 0x001107F0 File Offset: 0x0010E9F0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutVectorArray(ref TArray<FVector> OutVectorArray)
		{
			UTestClass_UFunction_Direct_FStruct.__OutVectorArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__OutVectorArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__OutVectorArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__OutVectorArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FVector> tarray = OutVectorArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutVectorArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__OutVectorArray_NativeFunctionPtr, (void*)ptr);
			TArray<FVector> tarray2 = OutVectorArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutVectorArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__OutVectorArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B1E4 RID: 45540 RVA: 0x00110868 File Offset: 0x0010EA68
		[SkipLocalsInit]
		public unsafe void OutVector(ref FVector OutVector)
		{
			UTestClass_UFunction_Direct_FStruct.__OutVector_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__OutVector_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__OutVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__OutVector_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutVector = OutVector;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__OutVector_NativeFunctionPtr, (void*)ptr);
			OutVector = ptr->OutVector;
		}

		// Token: 0x0600B1E5 RID: 45541 RVA: 0x001108C0 File Offset: 0x0010EAC0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutTransformArray(ref TArray<FTransform> OutTransformArray)
		{
			UTestClass_UFunction_Direct_FStruct.__OutTransformArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__OutTransformArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__OutTransformArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__OutTransformArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FTransform> tarray = OutTransformArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutTransformArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__OutTransformArray_NativeFunctionPtr, (void*)ptr);
			TArray<FTransform> tarray2 = OutTransformArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutTransformArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__OutTransformArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B1E6 RID: 45542 RVA: 0x00110938 File Offset: 0x0010EB38
		[SkipLocalsInit]
		public unsafe void OutTransform(ref FTransform OutTransform)
		{
			UTestClass_UFunction_Direct_FStruct.__OutTransform_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__OutTransform_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__OutTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__OutTransform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutTransform = OutTransform;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__OutTransform_NativeFunctionPtr, (void*)ptr);
			OutTransform = ptr->OutTransform;
		}

		// Token: 0x0600B1E7 RID: 45543 RVA: 0x00110990 File Offset: 0x0010EB90
		[SkipLocalsInit]
		public unsafe void OutSimpleStructSet([Nullable(new byte[]
		{
			2,
			1
		})] ref TSet<FSharpherealTestSimpleStruct> OutSimpleStructSet)
		{
			UTestClass_UFunction_Direct_FStruct.__OutSimpleStructSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__OutSimpleStructSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__OutSimpleStructSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__OutSimpleStructSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<FSharpherealTestSimpleStruct> tset = OutSimpleStructSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutSimpleStructSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__OutSimpleStructSet_NativeFunctionPtr, (void*)ptr);
			TSet<FSharpherealTestSimpleStruct> tset2 = OutSimpleStructSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutSimpleStructSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__OutSimpleStructSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B1E8 RID: 45544 RVA: 0x00110A08 File Offset: 0x0010EC08
		[SkipLocalsInit]
		public unsafe void OutSimpleStructMap([Nullable(new byte[]
		{
			2,
			1
		})] ref TMap<FSharpherealTestSimpleStruct, int> OutSimpleStructMap)
		{
			UTestClass_UFunction_Direct_FStruct.__OutSimpleStructMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__OutSimpleStructMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__OutSimpleStructMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__OutSimpleStructMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FSharpherealTestSimpleStruct, int> tmap = OutSimpleStructMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutSimpleStructMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__OutSimpleStructMap_NativeFunctionPtr, (void*)ptr);
			TMap<FSharpherealTestSimpleStruct, int> tmap2 = OutSimpleStructMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutSimpleStructMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__OutSimpleStructMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B1E9 RID: 45545 RVA: 0x00110A80 File Offset: 0x0010EC80
		[SkipLocalsInit]
		public unsafe void OutSimpleStructArray([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FSharpherealTestSimpleStruct> OutSimpleStructArray)
		{
			UTestClass_UFunction_Direct_FStruct.__OutSimpleStructArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__OutSimpleStructArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__OutSimpleStructArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__OutSimpleStructArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FSharpherealTestSimpleStruct> tarray = OutSimpleStructArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutSimpleStructArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__OutSimpleStructArray_NativeFunctionPtr, (void*)ptr);
			TArray<FSharpherealTestSimpleStruct> tarray2 = OutSimpleStructArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutSimpleStructArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__OutSimpleStructArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B1EA RID: 45546 RVA: 0x00110AF8 File Offset: 0x0010ECF8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutSimpleStruct(ref FSharpherealTestSimpleStruct OutSimpleStruct)
		{
			UTestClass_UFunction_Direct_FStruct.__OutSimpleStruct_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__OutSimpleStruct_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__OutSimpleStruct_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__OutSimpleStruct_NativeFunctionPtr, (void*)ptr, 1);
			if (OutSimpleStruct != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSharpherealTestSimpleStruct.StaticStruct(), &ptr->OutSimpleStruct, OutSimpleStruct.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__OutSimpleStruct_NativeFunctionPtr, (void*)ptr);
			if (OutSimpleStruct != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSharpherealTestSimpleStruct.StaticStruct(), OutSimpleStruct.NativePtr, &ptr->OutSimpleStruct, 1, false);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__OutSimpleStruct_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B1EB RID: 45547 RVA: 0x00110B90 File Offset: 0x0010ED90
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutQuatArray(ref TArray<FQuat> OutQuatArray)
		{
			UTestClass_UFunction_Direct_FStruct.__OutQuatArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__OutQuatArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__OutQuatArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__OutQuatArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FQuat> tarray = OutQuatArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutQuatArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__OutQuatArray_NativeFunctionPtr, (void*)ptr);
			TArray<FQuat> tarray2 = OutQuatArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutQuatArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__OutQuatArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B1EC RID: 45548 RVA: 0x00110C08 File Offset: 0x0010EE08
		[SkipLocalsInit]
		public unsafe void OutQuat(ref FQuat OutQuat)
		{
			UTestClass_UFunction_Direct_FStruct.__OutQuat_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__OutQuat_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__OutQuat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__OutQuat_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutQuat = OutQuat;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__OutQuat_NativeFunctionPtr, (void*)ptr);
			OutQuat = ptr->OutQuat;
		}

		// Token: 0x0600B1ED RID: 45549 RVA: 0x00110C60 File Offset: 0x0010EE60
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InVectorSet(in TSet<FVector> InVectorSet)
		{
			UTestClass_UFunction_Direct_FStruct.__InVectorSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__InVectorSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__InVectorSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__InVectorSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<FVector> tset = InVectorSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InVectorSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__InVectorSet_NativeFunctionPtr, (void*)ptr);
			TSet<FVector> tset2 = InVectorSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InVectorSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__InVectorSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B1EE RID: 45550 RVA: 0x00110CD8 File Offset: 0x0010EED8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InVectorMap(in TMap<FVector, int> InVectorMap)
		{
			UTestClass_UFunction_Direct_FStruct.__InVectorMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__InVectorMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__InVectorMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__InVectorMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FVector, int> tmap = InVectorMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InVectorMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__InVectorMap_NativeFunctionPtr, (void*)ptr);
			TMap<FVector, int> tmap2 = InVectorMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InVectorMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__InVectorMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B1EF RID: 45551 RVA: 0x00110D50 File Offset: 0x0010EF50
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InVectorArray(in TArray<FVector> InVectorArray)
		{
			UTestClass_UFunction_Direct_FStruct.__InVectorArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__InVectorArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__InVectorArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__InVectorArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FVector> tarray = InVectorArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InVectorArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__InVectorArray_NativeFunctionPtr, (void*)ptr);
			TArray<FVector> tarray2 = InVectorArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InVectorArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__InVectorArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B1F0 RID: 45552 RVA: 0x00110DC8 File Offset: 0x0010EFC8
		[SkipLocalsInit]
		public unsafe void InVector(in FVector InVector)
		{
			UTestClass_UFunction_Direct_FStruct.__InVector_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__InVector_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__InVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__InVector_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InVector = InVector;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__InVector_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B1F1 RID: 45553 RVA: 0x00110E14 File Offset: 0x0010F014
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InTransformArray(in TArray<FTransform> InTransformArray)
		{
			UTestClass_UFunction_Direct_FStruct.__InTransformArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__InTransformArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__InTransformArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__InTransformArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FTransform> tarray = InTransformArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InTransformArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__InTransformArray_NativeFunctionPtr, (void*)ptr);
			TArray<FTransform> tarray2 = InTransformArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InTransformArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__InTransformArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B1F2 RID: 45554 RVA: 0x00110E8C File Offset: 0x0010F08C
		[SkipLocalsInit]
		public unsafe void InTransform(in FTransform InTransform)
		{
			UTestClass_UFunction_Direct_FStruct.__InTransform_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__InTransform_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__InTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__InTransform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InTransform = InTransform;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__InTransform_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B1F3 RID: 45555 RVA: 0x00110ED8 File Offset: 0x0010F0D8
		[SkipLocalsInit]
		public unsafe void InSimpleStructSet([Nullable(new byte[]
		{
			2,
			1
		})] in TSet<FSharpherealTestSimpleStruct> InSimpleStructSet)
		{
			UTestClass_UFunction_Direct_FStruct.__InSimpleStructSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__InSimpleStructSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__InSimpleStructSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__InSimpleStructSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<FSharpherealTestSimpleStruct> tset = InSimpleStructSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InSimpleStructSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__InSimpleStructSet_NativeFunctionPtr, (void*)ptr);
			TSet<FSharpherealTestSimpleStruct> tset2 = InSimpleStructSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InSimpleStructSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__InSimpleStructSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B1F4 RID: 45556 RVA: 0x00110F50 File Offset: 0x0010F150
		[SkipLocalsInit]
		public unsafe void InSimpleStructMap([Nullable(new byte[]
		{
			2,
			1
		})] in TMap<FSharpherealTestSimpleStruct, int> InSimpleStructMap)
		{
			UTestClass_UFunction_Direct_FStruct.__InSimpleStructMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__InSimpleStructMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__InSimpleStructMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__InSimpleStructMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FSharpherealTestSimpleStruct, int> tmap = InSimpleStructMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InSimpleStructMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__InSimpleStructMap_NativeFunctionPtr, (void*)ptr);
			TMap<FSharpherealTestSimpleStruct, int> tmap2 = InSimpleStructMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InSimpleStructMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__InSimpleStructMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B1F5 RID: 45557 RVA: 0x00110FC8 File Offset: 0x0010F1C8
		[SkipLocalsInit]
		public unsafe void InSimpleStructArray([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FSharpherealTestSimpleStruct> InSimpleStructArray)
		{
			UTestClass_UFunction_Direct_FStruct.__InSimpleStructArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__InSimpleStructArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__InSimpleStructArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__InSimpleStructArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FSharpherealTestSimpleStruct> tarray = InSimpleStructArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InSimpleStructArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__InSimpleStructArray_NativeFunctionPtr, (void*)ptr);
			TArray<FSharpherealTestSimpleStruct> tarray2 = InSimpleStructArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InSimpleStructArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__InSimpleStructArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B1F6 RID: 45558 RVA: 0x00111040 File Offset: 0x0010F240
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InSimpleStruct(in FSharpherealTestSimpleStruct InSimpleStruct)
		{
			UTestClass_UFunction_Direct_FStruct.__InSimpleStruct_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__InSimpleStruct_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__InSimpleStruct_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__InSimpleStruct_NativeFunctionPtr, (void*)ptr, 1);
			if (InSimpleStruct != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSharpherealTestSimpleStruct.StaticStruct(), &ptr->InSimpleStruct, InSimpleStruct.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__InSimpleStruct_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__InSimpleStruct_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B1F7 RID: 45559 RVA: 0x001110B4 File Offset: 0x0010F2B4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InQuatArray(in TArray<FQuat> InQuatArray)
		{
			UTestClass_UFunction_Direct_FStruct.__InQuatArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__InQuatArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__InQuatArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__InQuatArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FQuat> tarray = InQuatArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InQuatArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__InQuatArray_NativeFunctionPtr, (void*)ptr);
			TArray<FQuat> tarray2 = InQuatArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InQuatArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__InQuatArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B1F8 RID: 45560 RVA: 0x0011112C File Offset: 0x0010F32C
		[SkipLocalsInit]
		public unsafe void InQuat(in FQuat InQuat)
		{
			UTestClass_UFunction_Direct_FStruct.__InQuat_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__InQuat_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__InQuat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__InQuat_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InQuat = InQuat;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__InQuat_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B1F9 RID: 45561 RVA: 0x00111178 File Offset: 0x0010F378
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSet<FVector> GetVectorSet()
		{
			UTestClass_UFunction_Direct_FStruct.__GetVectorSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__GetVectorSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__GetVectorSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__GetVectorSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__GetVectorSet_NativeFunctionPtr, (void*)ptr);
			TSet<FVector> result = new TSet<FVector>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__GetVectorSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B1FA RID: 45562 RVA: 0x001111D8 File Offset: 0x0010F3D8
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TMap<FVector, int> GetVectorMap()
		{
			UTestClass_UFunction_Direct_FStruct.__GetVectorMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__GetVectorMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__GetVectorMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__GetVectorMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__GetVectorMap_NativeFunctionPtr, (void*)ptr);
			TMap<FVector, int> result = new TMap<FVector, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__GetVectorMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B1FB RID: 45563 RVA: 0x00111238 File Offset: 0x0010F438
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<FVector> GetVectorArray()
		{
			UTestClass_UFunction_Direct_FStruct.__GetVectorArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__GetVectorArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__GetVectorArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__GetVectorArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__GetVectorArray_NativeFunctionPtr, (void*)ptr);
			TArray<FVector> result = new TArray<FVector>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__GetVectorArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B1FC RID: 45564 RVA: 0x00111298 File Offset: 0x0010F498
		[SkipLocalsInit]
		public unsafe FVector GetVector()
		{
			UTestClass_UFunction_Direct_FStruct.__GetVector_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__GetVector_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__GetVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__GetVector_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__GetVector_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B1FD RID: 45565 RVA: 0x001112E0 File Offset: 0x0010F4E0
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<FTransform> GetTransformArray()
		{
			UTestClass_UFunction_Direct_FStruct.__GetTransformArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__GetTransformArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__GetTransformArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__GetTransformArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__GetTransformArray_NativeFunctionPtr, (void*)ptr);
			TArray<FTransform> result = new TArray<FTransform>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__GetTransformArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B1FE RID: 45566 RVA: 0x00111340 File Offset: 0x0010F540
		[SkipLocalsInit]
		public unsafe FTransform GetTransform()
		{
			UTestClass_UFunction_Direct_FStruct.__GetTransform_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__GetTransform_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__GetTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__GetTransform_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__GetTransform_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B1FF RID: 45567 RVA: 0x00111388 File Offset: 0x0010F588
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSet<FSharpherealTestSimpleStruct> GetSimpleStructSet()
		{
			UTestClass_UFunction_Direct_FStruct.__GetSimpleStructSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__GetSimpleStructSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__GetSimpleStructSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__GetSimpleStructSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__GetSimpleStructSet_NativeFunctionPtr, (void*)ptr);
			TSet<FSharpherealTestSimpleStruct> result = new TSet<FSharpherealTestSimpleStruct>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__GetSimpleStructSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B200 RID: 45568 RVA: 0x001113E8 File Offset: 0x0010F5E8
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TMap<FSharpherealTestSimpleStruct, int> GetSimpleStructMap()
		{
			UTestClass_UFunction_Direct_FStruct.__GetSimpleStructMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__GetSimpleStructMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__GetSimpleStructMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__GetSimpleStructMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__GetSimpleStructMap_NativeFunctionPtr, (void*)ptr);
			TMap<FSharpherealTestSimpleStruct, int> result = new TMap<FSharpherealTestSimpleStruct, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__GetSimpleStructMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B201 RID: 45569 RVA: 0x00111448 File Offset: 0x0010F648
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<FSharpherealTestSimpleStruct> GetSimpleStructArray()
		{
			UTestClass_UFunction_Direct_FStruct.__GetSimpleStructArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__GetSimpleStructArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__GetSimpleStructArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__GetSimpleStructArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__GetSimpleStructArray_NativeFunctionPtr, (void*)ptr);
			TArray<FSharpherealTestSimpleStruct> result = new TArray<FSharpherealTestSimpleStruct>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__GetSimpleStructArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B202 RID: 45570 RVA: 0x001114A8 File Offset: 0x0010F6A8
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe FSharpherealTestSimpleStruct GetSimpleStruct()
		{
			UTestClass_UFunction_Direct_FStruct.__GetSimpleStruct_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__GetSimpleStruct_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__GetSimpleStruct_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__GetSimpleStruct_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__GetSimpleStruct_NativeFunctionPtr, (void*)ptr);
			FSharpherealTestSimpleStruct result = new FSharpherealTestSimpleStruct(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__GetSimpleStruct_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B203 RID: 45571 RVA: 0x00111508 File Offset: 0x0010F708
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<FQuat> GetQuatArray()
		{
			UTestClass_UFunction_Direct_FStruct.__GetQuatArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__GetQuatArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__GetQuatArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__GetQuatArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__GetQuatArray_NativeFunctionPtr, (void*)ptr);
			TArray<FQuat> result = new TArray<FQuat>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__GetQuatArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B204 RID: 45572 RVA: 0x00111568 File Offset: 0x0010F768
		[SkipLocalsInit]
		public unsafe FQuat GetQuat()
		{
			UTestClass_UFunction_Direct_FStruct.__GetQuat_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__GetQuat_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__GetQuat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__GetQuat_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__GetQuat_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B205 RID: 45573 RVA: 0x001115AD File Offset: 0x0010F7AD
		static UTestClass_UFunction_Direct_FStruct()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SharpherealTest.TestClass_UFunction_Direct_FStruct");
		}

		// Token: 0x0600B206 RID: 45574 RVA: 0x001115BB File Offset: 0x0010F7BB
		protected UTestClass_UFunction_Direct_FStruct(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004E81 RID: 20097
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SharpherealTest.TestClass_UFunction_Direct_FStruct";

		// Token: 0x04004E82 RID: 20098
		private static IntPtr _ClassPtr;

		// Token: 0x04004E83 RID: 20099
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004E84 RID: 20100
		internal static int __PropertyOffset_Vector;

		// Token: 0x04004E85 RID: 20101
		internal static int __PropertyOffset_VectorArray;

		// Token: 0x04004E86 RID: 20102
		[Nullable(2)]
		private TArray<FVector> _VectorArray;

		// Token: 0x04004E87 RID: 20103
		internal static int __PropertyOffset_VectorSet;

		// Token: 0x04004E88 RID: 20104
		[Nullable(2)]
		private TSet<FVector> _VectorSet;

		// Token: 0x04004E89 RID: 20105
		internal static int __PropertyOffset_VectorMap;

		// Token: 0x04004E8A RID: 20106
		[Nullable(2)]
		private TMap<FVector, int> _VectorMap;

		// Token: 0x04004E8B RID: 20107
		internal static int __PropertyOffset_Quat;

		// Token: 0x04004E8C RID: 20108
		internal static int __PropertyOffset_QuatArray;

		// Token: 0x04004E8D RID: 20109
		[Nullable(2)]
		private TArray<FQuat> _QuatArray;

		// Token: 0x04004E8E RID: 20110
		internal static int __PropertyOffset_Transform;

		// Token: 0x04004E8F RID: 20111
		internal static int __PropertyOffset_TransformArray;

		// Token: 0x04004E90 RID: 20112
		[Nullable(2)]
		private TArray<FTransform> _TransformArray;

		// Token: 0x04004E91 RID: 20113
		internal static int __PropertyOffset_SimpleStruct;

		// Token: 0x04004E92 RID: 20114
		[Nullable(2)]
		private FSharpherealTestSimpleStruct _SimpleStruct;

		// Token: 0x04004E93 RID: 20115
		internal static int __PropertyOffset_SimpleStructArray;

		// Token: 0x04004E94 RID: 20116
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSharpherealTestSimpleStruct> _SimpleStructArray;

		// Token: 0x04004E95 RID: 20117
		internal static int __PropertyOffset_SimpleStructSet;

		// Token: 0x04004E96 RID: 20118
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<FSharpherealTestSimpleStruct> _SimpleStructSet;

		// Token: 0x04004E97 RID: 20119
		internal static int __PropertyOffset_SimpleStructMap;

		// Token: 0x04004E98 RID: 20120
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FSharpherealTestSimpleStruct, int> _SimpleStructMap;

		// Token: 0x04004E99 RID: 20121
		private static IntPtr __SetVectorSet_NativeFunctionPtr;

		// Token: 0x04004E9A RID: 20122
		private static IntPtr __SetVectorMap_NativeFunctionPtr;

		// Token: 0x04004E9B RID: 20123
		private static IntPtr __SetVectorArray_NativeFunctionPtr;

		// Token: 0x04004E9C RID: 20124
		private static IntPtr __SetVector_NativeFunctionPtr;

		// Token: 0x04004E9D RID: 20125
		private static IntPtr __SetTransformArray_NativeFunctionPtr;

		// Token: 0x04004E9E RID: 20126
		private static IntPtr __SetTransform_NativeFunctionPtr;

		// Token: 0x04004E9F RID: 20127
		private static IntPtr __SetSimpleStructSet_NativeFunctionPtr;

		// Token: 0x04004EA0 RID: 20128
		private static IntPtr __SetSimpleStructMap_NativeFunctionPtr;

		// Token: 0x04004EA1 RID: 20129
		private static IntPtr __SetSimpleStructArray_NativeFunctionPtr;

		// Token: 0x04004EA2 RID: 20130
		private static IntPtr __SetSimpleStruct_NativeFunctionPtr;

		// Token: 0x04004EA3 RID: 20131
		private static IntPtr __SetQuatArray_NativeFunctionPtr;

		// Token: 0x04004EA4 RID: 20132
		private static IntPtr __SetQuat_NativeFunctionPtr;

		// Token: 0x04004EA5 RID: 20133
		private static IntPtr __OutVectorSet_NativeFunctionPtr;

		// Token: 0x04004EA6 RID: 20134
		private static IntPtr __OutVectorMap_NativeFunctionPtr;

		// Token: 0x04004EA7 RID: 20135
		private static IntPtr __OutVectorArray_NativeFunctionPtr;

		// Token: 0x04004EA8 RID: 20136
		private static IntPtr __OutVector_NativeFunctionPtr;

		// Token: 0x04004EA9 RID: 20137
		private static IntPtr __OutTransformArray_NativeFunctionPtr;

		// Token: 0x04004EAA RID: 20138
		private static IntPtr __OutTransform_NativeFunctionPtr;

		// Token: 0x04004EAB RID: 20139
		private static IntPtr __OutSimpleStructSet_NativeFunctionPtr;

		// Token: 0x04004EAC RID: 20140
		private static IntPtr __OutSimpleStructMap_NativeFunctionPtr;

		// Token: 0x04004EAD RID: 20141
		private static IntPtr __OutSimpleStructArray_NativeFunctionPtr;

		// Token: 0x04004EAE RID: 20142
		private static IntPtr __OutSimpleStruct_NativeFunctionPtr;

		// Token: 0x04004EAF RID: 20143
		private static IntPtr __OutQuatArray_NativeFunctionPtr;

		// Token: 0x04004EB0 RID: 20144
		private static IntPtr __OutQuat_NativeFunctionPtr;

		// Token: 0x04004EB1 RID: 20145
		private static IntPtr __InVectorSet_NativeFunctionPtr;

		// Token: 0x04004EB2 RID: 20146
		private static IntPtr __InVectorMap_NativeFunctionPtr;

		// Token: 0x04004EB3 RID: 20147
		private static IntPtr __InVectorArray_NativeFunctionPtr;

		// Token: 0x04004EB4 RID: 20148
		private static IntPtr __InVector_NativeFunctionPtr;

		// Token: 0x04004EB5 RID: 20149
		private static IntPtr __InTransformArray_NativeFunctionPtr;

		// Token: 0x04004EB6 RID: 20150
		private static IntPtr __InTransform_NativeFunctionPtr;

		// Token: 0x04004EB7 RID: 20151
		private static IntPtr __InSimpleStructSet_NativeFunctionPtr;

		// Token: 0x04004EB8 RID: 20152
		private static IntPtr __InSimpleStructMap_NativeFunctionPtr;

		// Token: 0x04004EB9 RID: 20153
		private static IntPtr __InSimpleStructArray_NativeFunctionPtr;

		// Token: 0x04004EBA RID: 20154
		private static IntPtr __InSimpleStruct_NativeFunctionPtr;

		// Token: 0x04004EBB RID: 20155
		private static IntPtr __InQuatArray_NativeFunctionPtr;

		// Token: 0x04004EBC RID: 20156
		private static IntPtr __InQuat_NativeFunctionPtr;

		// Token: 0x04004EBD RID: 20157
		private static IntPtr __GetVectorSet_NativeFunctionPtr;

		// Token: 0x04004EBE RID: 20158
		private static IntPtr __GetVectorMap_NativeFunctionPtr;

		// Token: 0x04004EBF RID: 20159
		private static IntPtr __GetVectorArray_NativeFunctionPtr;

		// Token: 0x04004EC0 RID: 20160
		private static IntPtr __GetVector_NativeFunctionPtr;

		// Token: 0x04004EC1 RID: 20161
		private static IntPtr __GetTransformArray_NativeFunctionPtr;

		// Token: 0x04004EC2 RID: 20162
		private static IntPtr __GetTransform_NativeFunctionPtr;

		// Token: 0x04004EC3 RID: 20163
		private static IntPtr __GetSimpleStructSet_NativeFunctionPtr;

		// Token: 0x04004EC4 RID: 20164
		private static IntPtr __GetSimpleStructMap_NativeFunctionPtr;

		// Token: 0x04004EC5 RID: 20165
		private static IntPtr __GetSimpleStructArray_NativeFunctionPtr;

		// Token: 0x04004EC6 RID: 20166
		private static IntPtr __GetSimpleStruct_NativeFunctionPtr;

		// Token: 0x04004EC7 RID: 20167
		private static IntPtr __GetQuatArray_NativeFunctionPtr;

		// Token: 0x04004EC8 RID: 20168
		private static IntPtr __GetQuat_NativeFunctionPtr;

		// Token: 0x02001125 RID: 4389
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetVectorSet_FunctionParams
		{
			// Token: 0x0400652D RID: 25901
			[FieldOffset(0)]
			public byte InVectorSet;
		}

		// Token: 0x02001126 RID: 4390
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetVectorMap_FunctionParams
		{
			// Token: 0x0400652E RID: 25902
			[FieldOffset(0)]
			public byte InVectorMap;
		}

		// Token: 0x02001127 RID: 4391
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetVectorArray_FunctionParams
		{
			// Token: 0x0400652F RID: 25903
			[FieldOffset(0)]
			public byte InVectorArray;
		}

		// Token: 0x02001128 RID: 4392
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __SetVector_FunctionParams
		{
			// Token: 0x04006530 RID: 25904
			[FieldOffset(0)]
			public FVector InVector;
		}

		// Token: 0x02001129 RID: 4393
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetTransformArray_FunctionParams
		{
			// Token: 0x04006531 RID: 25905
			[FieldOffset(0)]
			public byte InTransformArray;
		}

		// Token: 0x0200112A RID: 4394
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __SetTransform_FunctionParams
		{
			// Token: 0x04006532 RID: 25906
			[FieldOffset(0)]
			public FTransform InTransform;
		}

		// Token: 0x0200112B RID: 4395
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetSimpleStructSet_FunctionParams
		{
			// Token: 0x04006533 RID: 25907
			[FieldOffset(0)]
			public byte InSimpleStructSet;
		}

		// Token: 0x0200112C RID: 4396
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetSimpleStructMap_FunctionParams
		{
			// Token: 0x04006534 RID: 25908
			[FieldOffset(0)]
			public byte InSimpleStructMap;
		}

		// Token: 0x0200112D RID: 4397
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetSimpleStructArray_FunctionParams
		{
			// Token: 0x04006535 RID: 25909
			[FieldOffset(0)]
			public byte InSimpleStructArray;
		}

		// Token: 0x0200112E RID: 4398
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetSimpleStruct_FunctionParams
		{
			// Token: 0x04006536 RID: 25910
			[FieldOffset(0)]
			public byte InSimpleStruct;
		}

		// Token: 0x0200112F RID: 4399
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetQuatArray_FunctionParams
		{
			// Token: 0x04006537 RID: 25911
			[FieldOffset(0)]
			public byte InQuatArray;
		}

		// Token: 0x02001130 RID: 4400
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetQuat_FunctionParams
		{
			// Token: 0x04006538 RID: 25912
			[FieldOffset(0)]
			public FQuat InQuat;
		}

		// Token: 0x02001131 RID: 4401
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutVectorSet_FunctionParams
		{
			// Token: 0x04006539 RID: 25913
			[FieldOffset(0)]
			public byte OutVectorSet;
		}

		// Token: 0x02001132 RID: 4402
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutVectorMap_FunctionParams
		{
			// Token: 0x0400653A RID: 25914
			[FieldOffset(0)]
			public byte OutVectorMap;
		}

		// Token: 0x02001133 RID: 4403
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutVectorArray_FunctionParams
		{
			// Token: 0x0400653B RID: 25915
			[FieldOffset(0)]
			public byte OutVectorArray;
		}

		// Token: 0x02001134 RID: 4404
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __OutVector_FunctionParams
		{
			// Token: 0x0400653C RID: 25916
			[FieldOffset(0)]
			public FVector OutVector;
		}

		// Token: 0x02001135 RID: 4405
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutTransformArray_FunctionParams
		{
			// Token: 0x0400653D RID: 25917
			[FieldOffset(0)]
			public byte OutTransformArray;
		}

		// Token: 0x02001136 RID: 4406
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __OutTransform_FunctionParams
		{
			// Token: 0x0400653E RID: 25918
			[FieldOffset(0)]
			public FTransform OutTransform;
		}

		// Token: 0x02001137 RID: 4407
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutSimpleStructSet_FunctionParams
		{
			// Token: 0x0400653F RID: 25919
			[FieldOffset(0)]
			public byte OutSimpleStructSet;
		}

		// Token: 0x02001138 RID: 4408
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutSimpleStructMap_FunctionParams
		{
			// Token: 0x04006540 RID: 25920
			[FieldOffset(0)]
			public byte OutSimpleStructMap;
		}

		// Token: 0x02001139 RID: 4409
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutSimpleStructArray_FunctionParams
		{
			// Token: 0x04006541 RID: 25921
			[FieldOffset(0)]
			public byte OutSimpleStructArray;
		}

		// Token: 0x0200113A RID: 4410
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __OutSimpleStruct_FunctionParams
		{
			// Token: 0x04006542 RID: 25922
			[FieldOffset(0)]
			public byte OutSimpleStruct;
		}

		// Token: 0x0200113B RID: 4411
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutQuatArray_FunctionParams
		{
			// Token: 0x04006543 RID: 25923
			[FieldOffset(0)]
			public byte OutQuatArray;
		}

		// Token: 0x0200113C RID: 4412
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutQuat_FunctionParams
		{
			// Token: 0x04006544 RID: 25924
			[FieldOffset(0)]
			public FQuat OutQuat;
		}

		// Token: 0x0200113D RID: 4413
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InVectorSet_FunctionParams
		{
			// Token: 0x04006545 RID: 25925
			[FieldOffset(0)]
			public byte InVectorSet;
		}

		// Token: 0x0200113E RID: 4414
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InVectorMap_FunctionParams
		{
			// Token: 0x04006546 RID: 25926
			[FieldOffset(0)]
			public byte InVectorMap;
		}

		// Token: 0x0200113F RID: 4415
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InVectorArray_FunctionParams
		{
			// Token: 0x04006547 RID: 25927
			[FieldOffset(0)]
			public byte InVectorArray;
		}

		// Token: 0x02001140 RID: 4416
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InVector_FunctionParams
		{
			// Token: 0x04006548 RID: 25928
			[FieldOffset(0)]
			public FVector InVector;
		}

		// Token: 0x02001141 RID: 4417
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InTransformArray_FunctionParams
		{
			// Token: 0x04006549 RID: 25929
			[FieldOffset(0)]
			public byte InTransformArray;
		}

		// Token: 0x02001142 RID: 4418
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __InTransform_FunctionParams
		{
			// Token: 0x0400654A RID: 25930
			[FieldOffset(0)]
			public FTransform InTransform;
		}

		// Token: 0x02001143 RID: 4419
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InSimpleStructSet_FunctionParams
		{
			// Token: 0x0400654B RID: 25931
			[FieldOffset(0)]
			public byte InSimpleStructSet;
		}

		// Token: 0x02001144 RID: 4420
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InSimpleStructMap_FunctionParams
		{
			// Token: 0x0400654C RID: 25932
			[FieldOffset(0)]
			public byte InSimpleStructMap;
		}

		// Token: 0x02001145 RID: 4421
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InSimpleStructArray_FunctionParams
		{
			// Token: 0x0400654D RID: 25933
			[FieldOffset(0)]
			public byte InSimpleStructArray;
		}

		// Token: 0x02001146 RID: 4422
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InSimpleStruct_FunctionParams
		{
			// Token: 0x0400654E RID: 25934
			[FieldOffset(0)]
			public byte InSimpleStruct;
		}

		// Token: 0x02001147 RID: 4423
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InQuatArray_FunctionParams
		{
			// Token: 0x0400654F RID: 25935
			[FieldOffset(0)]
			public byte InQuatArray;
		}

		// Token: 0x02001148 RID: 4424
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InQuat_FunctionParams
		{
			// Token: 0x04006550 RID: 25936
			[FieldOffset(0)]
			public FQuat InQuat;
		}

		// Token: 0x02001149 RID: 4425
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetVectorSet_FunctionParams
		{
			// Token: 0x04006551 RID: 25937
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200114A RID: 4426
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetVectorMap_FunctionParams
		{
			// Token: 0x04006552 RID: 25938
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200114B RID: 4427
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetVectorArray_FunctionParams
		{
			// Token: 0x04006553 RID: 25939
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200114C RID: 4428
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetVector_FunctionParams
		{
			// Token: 0x04006554 RID: 25940
			[FieldOffset(0)]
			public FVector __Result;
		}

		// Token: 0x0200114D RID: 4429
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetTransformArray_FunctionParams
		{
			// Token: 0x04006555 RID: 25941
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200114E RID: 4430
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __GetTransform_FunctionParams
		{
			// Token: 0x04006556 RID: 25942
			[FieldOffset(0)]
			public FTransform __Result;
		}

		// Token: 0x0200114F RID: 4431
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetSimpleStructSet_FunctionParams
		{
			// Token: 0x04006557 RID: 25943
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001150 RID: 4432
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetSimpleStructMap_FunctionParams
		{
			// Token: 0x04006558 RID: 25944
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001151 RID: 4433
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSimpleStructArray_FunctionParams
		{
			// Token: 0x04006559 RID: 25945
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001152 RID: 4434
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetSimpleStruct_FunctionParams
		{
			// Token: 0x0400655A RID: 25946
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001153 RID: 4435
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetQuatArray_FunctionParams
		{
			// Token: 0x0400655B RID: 25947
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001154 RID: 4436
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetQuat_FunctionParams
		{
			// Token: 0x0400655C RID: 25948
			[FieldOffset(0)]
			public FQuat __Result;
		}
	}
}
