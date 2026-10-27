using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002749 RID: 10057
	[UnrealObjectPath("/Script/SharpherealTest.TestClass_UFunction_Direct_FStruct")]
	[UnrealStructLayout(544, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 544)]
	public class UTestClass_UFunction_Direct_FStruct : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060256DD RID: 153309 RVA: 0x00380795 File Offset: 0x0037E995
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTestClass_UFunction_Direct_FStruct._ClassPtr;
		}

		// Token: 0x060256DE RID: 153310 RVA: 0x003807A4 File Offset: 0x0037E9A4
		public UTestClass_UFunction_Direct_FStruct() : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_Direct_FStruct.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060256DF RID: 153311 RVA: 0x003807CC File Offset: 0x0037E9CC
		[NullableContext(1)]
		public UTestClass_UFunction_Direct_FStruct(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_Direct_FStruct.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009078 RID: 36984
		// (get) Token: 0x060256E0 RID: 153312 RVA: 0x003807FF File Offset: 0x0037E9FF
		// (set) Token: 0x060256E1 RID: 153313 RVA: 0x00380813 File Offset: 0x0037EA13
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

		// Token: 0x17009079 RID: 36985
		// (get) Token: 0x060256E2 RID: 153314 RVA: 0x00380828 File Offset: 0x0037EA28
		// (set) Token: 0x060256E3 RID: 153315 RVA: 0x00380861 File Offset: 0x0037EA61
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

		// Token: 0x1700907A RID: 36986
		// (get) Token: 0x060256E4 RID: 153316 RVA: 0x00380870 File Offset: 0x0037EA70
		// (set) Token: 0x060256E5 RID: 153317 RVA: 0x003808A9 File Offset: 0x0037EAA9
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

		// Token: 0x1700907B RID: 36987
		// (get) Token: 0x060256E6 RID: 153318 RVA: 0x003808B8 File Offset: 0x0037EAB8
		// (set) Token: 0x060256E7 RID: 153319 RVA: 0x003808F1 File Offset: 0x0037EAF1
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

		// Token: 0x1700907C RID: 36988
		// (get) Token: 0x060256E8 RID: 153320 RVA: 0x003808FF File Offset: 0x0037EAFF
		// (set) Token: 0x060256E9 RID: 153321 RVA: 0x00380913 File Offset: 0x0037EB13
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

		// Token: 0x1700907D RID: 36989
		// (get) Token: 0x060256EA RID: 153322 RVA: 0x00380928 File Offset: 0x0037EB28
		// (set) Token: 0x060256EB RID: 153323 RVA: 0x00380961 File Offset: 0x0037EB61
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

		// Token: 0x1700907E RID: 36990
		// (get) Token: 0x060256EC RID: 153324 RVA: 0x0038096F File Offset: 0x0037EB6F
		// (set) Token: 0x060256ED RID: 153325 RVA: 0x00380983 File Offset: 0x0037EB83
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

		// Token: 0x1700907F RID: 36991
		// (get) Token: 0x060256EE RID: 153326 RVA: 0x00380998 File Offset: 0x0037EB98
		// (set) Token: 0x060256EF RID: 153327 RVA: 0x003809D1 File Offset: 0x0037EBD1
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

		// Token: 0x17009080 RID: 36992
		// (get) Token: 0x060256F0 RID: 153328 RVA: 0x003809E0 File Offset: 0x0037EBE0
		// (set) Token: 0x060256F1 RID: 153329 RVA: 0x00380A19 File Offset: 0x0037EC19
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

		// Token: 0x17009081 RID: 36993
		// (get) Token: 0x060256F2 RID: 153330 RVA: 0x00380A3C File Offset: 0x0037EC3C
		// (set) Token: 0x060256F3 RID: 153331 RVA: 0x00380A75 File Offset: 0x0037EC75
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

		// Token: 0x17009082 RID: 36994
		// (get) Token: 0x060256F4 RID: 153332 RVA: 0x00380A84 File Offset: 0x0037EC84
		// (set) Token: 0x060256F5 RID: 153333 RVA: 0x00380ABD File Offset: 0x0037ECBD
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

		// Token: 0x17009083 RID: 36995
		// (get) Token: 0x060256F6 RID: 153334 RVA: 0x00380ACC File Offset: 0x0037ECCC
		// (set) Token: 0x060256F7 RID: 153335 RVA: 0x00380B05 File Offset: 0x0037ED05
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

		// Token: 0x060256F8 RID: 153336 RVA: 0x00380B14 File Offset: 0x0037ED14
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetVectorSet(TSet<FVector> InVectorSet)
		{
			UTestClass_UFunction_Direct_FStruct.__SetVectorSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__SetVectorSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__SetVectorSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__SetVectorSet_NativeFunctionPtr, (void*)ptr, 1);
			if (InVectorSet != null)
			{
				InVectorSet.CopyTo(&ptr->InVectorSet, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__SetVectorSet_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__SetVectorSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060256F9 RID: 153337 RVA: 0x00380B80 File Offset: 0x0037ED80
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetVectorMap(TMap<FVector, int> InVectorMap)
		{
			UTestClass_UFunction_Direct_FStruct.__SetVectorMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__SetVectorMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__SetVectorMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__SetVectorMap_NativeFunctionPtr, (void*)ptr, 1);
			if (InVectorMap != null)
			{
				InVectorMap.CopyTo(&ptr->InVectorMap, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__SetVectorMap_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__SetVectorMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060256FA RID: 153338 RVA: 0x00380BEC File Offset: 0x0037EDEC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetVectorArray(TArray<FVector> InVectorArray)
		{
			UTestClass_UFunction_Direct_FStruct.__SetVectorArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__SetVectorArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__SetVectorArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__SetVectorArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InVectorArray != null)
			{
				InVectorArray.CopyTo(&ptr->InVectorArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__SetVectorArray_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__SetVectorArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060256FB RID: 153339 RVA: 0x00380C58 File Offset: 0x0037EE58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetVector(FVector InVector)
		{
			UTestClass_UFunction_Direct_FStruct.__SetVector_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__SetVector_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__SetVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__SetVector_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InVector = InVector;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__SetVector_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060256FC RID: 153340 RVA: 0x00380CA0 File Offset: 0x0037EEA0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetTransformArray(TArray<FTransform> InTransformArray)
		{
			UTestClass_UFunction_Direct_FStruct.__SetTransformArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__SetTransformArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__SetTransformArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__SetTransformArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InTransformArray != null)
			{
				InTransformArray.CopyTo(&ptr->InTransformArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__SetTransformArray_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__SetTransformArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060256FD RID: 153341 RVA: 0x00380D0C File Offset: 0x0037EF0C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetTransform(FTransform InTransform)
		{
			UTestClass_UFunction_Direct_FStruct.__SetTransform_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__SetTransform_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__SetTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__SetTransform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InTransform = InTransform;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__SetTransform_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060256FE RID: 153342 RVA: 0x00380D54 File Offset: 0x0037EF54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__SetSimpleStructSet_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__SetSimpleStructSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060256FF RID: 153343 RVA: 0x00380DC0 File Offset: 0x0037EFC0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__SetSimpleStructMap_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__SetSimpleStructMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025700 RID: 153344 RVA: 0x00380E2C File Offset: 0x0037F02C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__SetSimpleStructArray_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__SetSimpleStructArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025701 RID: 153345 RVA: 0x00380E98 File Offset: 0x0037F098
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetSimpleStruct(FSharpherealTestSimpleStruct InSimpleStruct)
		{
			UTestClass_UFunction_Direct_FStruct.__SetSimpleStruct_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__SetSimpleStruct_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__SetSimpleStruct_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__SetSimpleStruct_NativeFunctionPtr, (void*)ptr, 1);
			if (InSimpleStruct != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSharpherealTestSimpleStruct.StaticStruct(), &ptr->InSimpleStruct, InSimpleStruct.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__SetSimpleStruct_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__SetSimpleStruct_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025702 RID: 153346 RVA: 0x00380F0C File Offset: 0x0037F10C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetQuatArray(TArray<FQuat> InQuatArray)
		{
			UTestClass_UFunction_Direct_FStruct.__SetQuatArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__SetQuatArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__SetQuatArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__SetQuatArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InQuatArray != null)
			{
				InQuatArray.CopyTo(&ptr->InQuatArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__SetQuatArray_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__SetQuatArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025703 RID: 153347 RVA: 0x00380F78 File Offset: 0x0037F178
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetQuat(FQuat InQuat)
		{
			UTestClass_UFunction_Direct_FStruct.__SetQuat_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__SetQuat_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__SetQuat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__SetQuat_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InQuat = InQuat;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__SetQuat_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025704 RID: 153348 RVA: 0x00380FC0 File Offset: 0x0037F1C0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutVectorSet(ref TSet<FVector> OutVectorSet)
		{
			UTestClass_UFunction_Direct_FStruct.__OutVectorSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__OutVectorSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__OutVectorSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__OutVectorSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<FVector> tset = OutVectorSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutVectorSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__OutVectorSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<FVector> tset2 = OutVectorSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutVectorSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__OutVectorSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025705 RID: 153349 RVA: 0x0038103C File Offset: 0x0037F23C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutVectorMap(ref TMap<FVector, int> OutVectorMap)
		{
			UTestClass_UFunction_Direct_FStruct.__OutVectorMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__OutVectorMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__OutVectorMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__OutVectorMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FVector, int> tmap = OutVectorMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutVectorMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__OutVectorMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FVector, int> tmap2 = OutVectorMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutVectorMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__OutVectorMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025706 RID: 153350 RVA: 0x003810B8 File Offset: 0x0037F2B8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutVectorArray(ref TArray<FVector> OutVectorArray)
		{
			UTestClass_UFunction_Direct_FStruct.__OutVectorArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__OutVectorArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__OutVectorArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__OutVectorArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FVector> tarray = OutVectorArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutVectorArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__OutVectorArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FVector> tarray2 = OutVectorArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutVectorArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__OutVectorArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025707 RID: 153351 RVA: 0x00381134 File Offset: 0x0037F334
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutVector(ref FVector OutVector)
		{
			UTestClass_UFunction_Direct_FStruct.__OutVector_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__OutVector_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__OutVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__OutVector_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutVector = OutVector;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__OutVector_NativeFunctionPtr, (void*)ptr, 0);
			OutVector = ptr->OutVector;
		}

		// Token: 0x06025708 RID: 153352 RVA: 0x0038118C File Offset: 0x0037F38C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutTransformArray(ref TArray<FTransform> OutTransformArray)
		{
			UTestClass_UFunction_Direct_FStruct.__OutTransformArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__OutTransformArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__OutTransformArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__OutTransformArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FTransform> tarray = OutTransformArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutTransformArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__OutTransformArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FTransform> tarray2 = OutTransformArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutTransformArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__OutTransformArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025709 RID: 153353 RVA: 0x00381208 File Offset: 0x0037F408
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutTransform(ref FTransform OutTransform)
		{
			UTestClass_UFunction_Direct_FStruct.__OutTransform_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__OutTransform_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__OutTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__OutTransform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutTransform = OutTransform;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__OutTransform_NativeFunctionPtr, (void*)ptr, 0);
			OutTransform = ptr->OutTransform;
		}

		// Token: 0x0602570A RID: 153354 RVA: 0x00381260 File Offset: 0x0037F460
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__OutSimpleStructSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<FSharpherealTestSimpleStruct> tset2 = OutSimpleStructSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutSimpleStructSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__OutSimpleStructSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602570B RID: 153355 RVA: 0x003812DC File Offset: 0x0037F4DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__OutSimpleStructMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FSharpherealTestSimpleStruct, int> tmap2 = OutSimpleStructMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutSimpleStructMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__OutSimpleStructMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602570C RID: 153356 RVA: 0x00381358 File Offset: 0x0037F558
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__OutSimpleStructArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FSharpherealTestSimpleStruct> tarray2 = OutSimpleStructArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutSimpleStructArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__OutSimpleStructArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602570D RID: 153357 RVA: 0x003813D4 File Offset: 0x0037F5D4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutSimpleStruct(ref FSharpherealTestSimpleStruct OutSimpleStruct)
		{
			UTestClass_UFunction_Direct_FStruct.__OutSimpleStruct_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__OutSimpleStruct_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__OutSimpleStruct_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__OutSimpleStruct_NativeFunctionPtr, (void*)ptr, 1);
			if (OutSimpleStruct != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSharpherealTestSimpleStruct.StaticStruct(), &ptr->OutSimpleStruct, OutSimpleStruct.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__OutSimpleStruct_NativeFunctionPtr, (void*)ptr, 0);
			if (OutSimpleStruct != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSharpherealTestSimpleStruct.StaticStruct(), OutSimpleStruct.NativePtr, &ptr->OutSimpleStruct, 1, false);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__OutSimpleStruct_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602570E RID: 153358 RVA: 0x00381470 File Offset: 0x0037F670
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutQuatArray(ref TArray<FQuat> OutQuatArray)
		{
			UTestClass_UFunction_Direct_FStruct.__OutQuatArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__OutQuatArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__OutQuatArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__OutQuatArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FQuat> tarray = OutQuatArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutQuatArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__OutQuatArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FQuat> tarray2 = OutQuatArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutQuatArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__OutQuatArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602570F RID: 153359 RVA: 0x003814EC File Offset: 0x0037F6EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutQuat(ref FQuat OutQuat)
		{
			UTestClass_UFunction_Direct_FStruct.__OutQuat_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__OutQuat_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__OutQuat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__OutQuat_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutQuat = OutQuat;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__OutQuat_NativeFunctionPtr, (void*)ptr, 0);
			OutQuat = ptr->OutQuat;
		}

		// Token: 0x06025710 RID: 153360 RVA: 0x00381544 File Offset: 0x0037F744
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InVectorSet(in TSet<FVector> InVectorSet)
		{
			UTestClass_UFunction_Direct_FStruct.__InVectorSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__InVectorSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__InVectorSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__InVectorSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<FVector> tset = InVectorSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InVectorSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__InVectorSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<FVector> tset2 = InVectorSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InVectorSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__InVectorSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025711 RID: 153361 RVA: 0x003815C0 File Offset: 0x0037F7C0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InVectorMap(in TMap<FVector, int> InVectorMap)
		{
			UTestClass_UFunction_Direct_FStruct.__InVectorMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__InVectorMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__InVectorMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__InVectorMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FVector, int> tmap = InVectorMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InVectorMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__InVectorMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FVector, int> tmap2 = InVectorMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InVectorMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__InVectorMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025712 RID: 153362 RVA: 0x0038163C File Offset: 0x0037F83C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InVectorArray(in TArray<FVector> InVectorArray)
		{
			UTestClass_UFunction_Direct_FStruct.__InVectorArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__InVectorArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__InVectorArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__InVectorArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FVector> tarray = InVectorArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InVectorArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__InVectorArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FVector> tarray2 = InVectorArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InVectorArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__InVectorArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025713 RID: 153363 RVA: 0x003816B8 File Offset: 0x0037F8B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InVector(in FVector InVector)
		{
			UTestClass_UFunction_Direct_FStruct.__InVector_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__InVector_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__InVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__InVector_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InVector = InVector;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__InVector_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025714 RID: 153364 RVA: 0x00381704 File Offset: 0x0037F904
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InTransformArray(in TArray<FTransform> InTransformArray)
		{
			UTestClass_UFunction_Direct_FStruct.__InTransformArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__InTransformArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__InTransformArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__InTransformArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FTransform> tarray = InTransformArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InTransformArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__InTransformArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FTransform> tarray2 = InTransformArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InTransformArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__InTransformArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025715 RID: 153365 RVA: 0x00381780 File Offset: 0x0037F980
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InTransform(in FTransform InTransform)
		{
			UTestClass_UFunction_Direct_FStruct.__InTransform_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__InTransform_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__InTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__InTransform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InTransform = InTransform;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__InTransform_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025716 RID: 153366 RVA: 0x003817CC File Offset: 0x0037F9CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__InSimpleStructSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<FSharpherealTestSimpleStruct> tset2 = InSimpleStructSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InSimpleStructSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__InSimpleStructSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025717 RID: 153367 RVA: 0x00381848 File Offset: 0x0037FA48
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__InSimpleStructMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FSharpherealTestSimpleStruct, int> tmap2 = InSimpleStructMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InSimpleStructMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__InSimpleStructMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025718 RID: 153368 RVA: 0x003818C4 File Offset: 0x0037FAC4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__InSimpleStructArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FSharpherealTestSimpleStruct> tarray2 = InSimpleStructArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InSimpleStructArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__InSimpleStructArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025719 RID: 153369 RVA: 0x00381940 File Offset: 0x0037FB40
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InSimpleStruct(in FSharpherealTestSimpleStruct InSimpleStruct)
		{
			UTestClass_UFunction_Direct_FStruct.__InSimpleStruct_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__InSimpleStruct_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__InSimpleStruct_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__InSimpleStruct_NativeFunctionPtr, (void*)ptr, 1);
			if (InSimpleStruct != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSharpherealTestSimpleStruct.StaticStruct(), &ptr->InSimpleStruct, InSimpleStruct.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__InSimpleStruct_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__InSimpleStruct_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602571A RID: 153370 RVA: 0x003819B8 File Offset: 0x0037FBB8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InQuatArray(in TArray<FQuat> InQuatArray)
		{
			UTestClass_UFunction_Direct_FStruct.__InQuatArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__InQuatArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__InQuatArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__InQuatArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FQuat> tarray = InQuatArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InQuatArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__InQuatArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FQuat> tarray2 = InQuatArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InQuatArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__InQuatArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602571B RID: 153371 RVA: 0x00381A34 File Offset: 0x0037FC34
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InQuat(in FQuat InQuat)
		{
			UTestClass_UFunction_Direct_FStruct.__InQuat_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__InQuat_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__InQuat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__InQuat_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InQuat = InQuat;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__InQuat_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602571C RID: 153372 RVA: 0x00381A80 File Offset: 0x0037FC80
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<FVector> GetVectorSet()
		{
			UTestClass_UFunction_Direct_FStruct.__GetVectorSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__GetVectorSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__GetVectorSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__GetVectorSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__GetVectorSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<FVector> result = new TSet<FVector>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__GetVectorSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602571D RID: 153373 RVA: 0x00381AE0 File Offset: 0x0037FCE0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<FVector, int> GetVectorMap()
		{
			UTestClass_UFunction_Direct_FStruct.__GetVectorMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__GetVectorMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__GetVectorMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__GetVectorMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__GetVectorMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FVector, int> result = new TMap<FVector, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__GetVectorMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602571E RID: 153374 RVA: 0x00381B40 File Offset: 0x0037FD40
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<FVector> GetVectorArray()
		{
			UTestClass_UFunction_Direct_FStruct.__GetVectorArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__GetVectorArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__GetVectorArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__GetVectorArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__GetVectorArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FVector> result = new TArray<FVector>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__GetVectorArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602571F RID: 153375 RVA: 0x00381BA0 File Offset: 0x0037FDA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FVector GetVector()
		{
			UTestClass_UFunction_Direct_FStruct.__GetVector_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__GetVector_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__GetVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__GetVector_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__GetVector_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06025720 RID: 153376 RVA: 0x00381BE8 File Offset: 0x0037FDE8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<FTransform> GetTransformArray()
		{
			UTestClass_UFunction_Direct_FStruct.__GetTransformArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__GetTransformArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__GetTransformArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__GetTransformArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__GetTransformArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FTransform> result = new TArray<FTransform>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__GetTransformArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025721 RID: 153377 RVA: 0x00381C48 File Offset: 0x0037FE48
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FTransform GetTransform()
		{
			UTestClass_UFunction_Direct_FStruct.__GetTransform_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__GetTransform_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__GetTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__GetTransform_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__GetTransform_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06025722 RID: 153378 RVA: 0x00381C90 File Offset: 0x0037FE90
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<FSharpherealTestSimpleStruct> GetSimpleStructSet()
		{
			UTestClass_UFunction_Direct_FStruct.__GetSimpleStructSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__GetSimpleStructSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__GetSimpleStructSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__GetSimpleStructSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__GetSimpleStructSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<FSharpherealTestSimpleStruct> result = new TSet<FSharpherealTestSimpleStruct>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__GetSimpleStructSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025723 RID: 153379 RVA: 0x00381CF0 File Offset: 0x0037FEF0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<FSharpherealTestSimpleStruct, int> GetSimpleStructMap()
		{
			UTestClass_UFunction_Direct_FStruct.__GetSimpleStructMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__GetSimpleStructMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__GetSimpleStructMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__GetSimpleStructMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__GetSimpleStructMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FSharpherealTestSimpleStruct, int> result = new TMap<FSharpherealTestSimpleStruct, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__GetSimpleStructMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025724 RID: 153380 RVA: 0x00381D50 File Offset: 0x0037FF50
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<FSharpherealTestSimpleStruct> GetSimpleStructArray()
		{
			UTestClass_UFunction_Direct_FStruct.__GetSimpleStructArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__GetSimpleStructArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__GetSimpleStructArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__GetSimpleStructArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__GetSimpleStructArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FSharpherealTestSimpleStruct> result = new TArray<FSharpherealTestSimpleStruct>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__GetSimpleStructArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025725 RID: 153381 RVA: 0x00381DB0 File Offset: 0x0037FFB0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FSharpherealTestSimpleStruct GetSimpleStruct()
		{
			UTestClass_UFunction_Direct_FStruct.__GetSimpleStruct_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__GetSimpleStruct_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__GetSimpleStruct_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__GetSimpleStruct_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__GetSimpleStruct_NativeFunctionPtr, (void*)ptr, 0);
			FSharpherealTestSimpleStruct result = new FSharpherealTestSimpleStruct(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__GetSimpleStruct_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025726 RID: 153382 RVA: 0x00381E10 File Offset: 0x00380010
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<FQuat> GetQuatArray()
		{
			UTestClass_UFunction_Direct_FStruct.__GetQuatArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__GetQuatArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__GetQuatArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__GetQuatArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__GetQuatArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FQuat> result = new TArray<FQuat>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_FStruct.__GetQuatArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025727 RID: 153383 RVA: 0x00381E70 File Offset: 0x00380070
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FQuat GetQuat()
		{
			UTestClass_UFunction_Direct_FStruct.__GetQuat_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_FStruct.__GetQuat_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_FStruct.__GetQuat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_FStruct.__GetQuat_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_FStruct.__GetQuat_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06025728 RID: 153384 RVA: 0x00381EB6 File Offset: 0x003800B6
		static UTestClass_UFunction_Direct_FStruct()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SharpherealTest.TestClass_UFunction_Direct_FStruct");
		}

		// Token: 0x06025729 RID: 153385 RVA: 0x00381EC4 File Offset: 0x003800C4
		protected UTestClass_UFunction_Direct_FStruct(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014422 RID: 82978
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SharpherealTest.TestClass_UFunction_Direct_FStruct";

		// Token: 0x04014423 RID: 82979
		private static IntPtr _ClassPtr;

		// Token: 0x04014424 RID: 82980
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014425 RID: 82981
		internal static int __PropertyOffset_Vector;

		// Token: 0x04014426 RID: 82982
		internal static int __PropertyOffset_VectorArray;

		// Token: 0x04014427 RID: 82983
		[Nullable(2)]
		private TArray<FVector> _VectorArray;

		// Token: 0x04014428 RID: 82984
		internal static int __PropertyOffset_VectorSet;

		// Token: 0x04014429 RID: 82985
		[Nullable(2)]
		private TSet<FVector> _VectorSet;

		// Token: 0x0401442A RID: 82986
		internal static int __PropertyOffset_VectorMap;

		// Token: 0x0401442B RID: 82987
		[Nullable(2)]
		private TMap<FVector, int> _VectorMap;

		// Token: 0x0401442C RID: 82988
		internal static int __PropertyOffset_Quat;

		// Token: 0x0401442D RID: 82989
		internal static int __PropertyOffset_QuatArray;

		// Token: 0x0401442E RID: 82990
		[Nullable(2)]
		private TArray<FQuat> _QuatArray;

		// Token: 0x0401442F RID: 82991
		internal static int __PropertyOffset_Transform;

		// Token: 0x04014430 RID: 82992
		internal static int __PropertyOffset_TransformArray;

		// Token: 0x04014431 RID: 82993
		[Nullable(2)]
		private TArray<FTransform> _TransformArray;

		// Token: 0x04014432 RID: 82994
		internal static int __PropertyOffset_SimpleStruct;

		// Token: 0x04014433 RID: 82995
		[Nullable(2)]
		private FSharpherealTestSimpleStruct _SimpleStruct;

		// Token: 0x04014434 RID: 82996
		internal static int __PropertyOffset_SimpleStructArray;

		// Token: 0x04014435 RID: 82997
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSharpherealTestSimpleStruct> _SimpleStructArray;

		// Token: 0x04014436 RID: 82998
		internal static int __PropertyOffset_SimpleStructSet;

		// Token: 0x04014437 RID: 82999
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<FSharpherealTestSimpleStruct> _SimpleStructSet;

		// Token: 0x04014438 RID: 83000
		internal static int __PropertyOffset_SimpleStructMap;

		// Token: 0x04014439 RID: 83001
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FSharpherealTestSimpleStruct, int> _SimpleStructMap;

		// Token: 0x0401443A RID: 83002
		private static IntPtr __SetVectorSet_NativeFunctionPtr;

		// Token: 0x0401443B RID: 83003
		private static IntPtr __SetVectorMap_NativeFunctionPtr;

		// Token: 0x0401443C RID: 83004
		private static IntPtr __SetVectorArray_NativeFunctionPtr;

		// Token: 0x0401443D RID: 83005
		private static IntPtr __SetVector_NativeFunctionPtr;

		// Token: 0x0401443E RID: 83006
		private static IntPtr __SetTransformArray_NativeFunctionPtr;

		// Token: 0x0401443F RID: 83007
		private static IntPtr __SetTransform_NativeFunctionPtr;

		// Token: 0x04014440 RID: 83008
		private static IntPtr __SetSimpleStructSet_NativeFunctionPtr;

		// Token: 0x04014441 RID: 83009
		private static IntPtr __SetSimpleStructMap_NativeFunctionPtr;

		// Token: 0x04014442 RID: 83010
		private static IntPtr __SetSimpleStructArray_NativeFunctionPtr;

		// Token: 0x04014443 RID: 83011
		private static IntPtr __SetSimpleStruct_NativeFunctionPtr;

		// Token: 0x04014444 RID: 83012
		private static IntPtr __SetQuatArray_NativeFunctionPtr;

		// Token: 0x04014445 RID: 83013
		private static IntPtr __SetQuat_NativeFunctionPtr;

		// Token: 0x04014446 RID: 83014
		private static IntPtr __OutVectorSet_NativeFunctionPtr;

		// Token: 0x04014447 RID: 83015
		private static IntPtr __OutVectorMap_NativeFunctionPtr;

		// Token: 0x04014448 RID: 83016
		private static IntPtr __OutVectorArray_NativeFunctionPtr;

		// Token: 0x04014449 RID: 83017
		private static IntPtr __OutVector_NativeFunctionPtr;

		// Token: 0x0401444A RID: 83018
		private static IntPtr __OutTransformArray_NativeFunctionPtr;

		// Token: 0x0401444B RID: 83019
		private static IntPtr __OutTransform_NativeFunctionPtr;

		// Token: 0x0401444C RID: 83020
		private static IntPtr __OutSimpleStructSet_NativeFunctionPtr;

		// Token: 0x0401444D RID: 83021
		private static IntPtr __OutSimpleStructMap_NativeFunctionPtr;

		// Token: 0x0401444E RID: 83022
		private static IntPtr __OutSimpleStructArray_NativeFunctionPtr;

		// Token: 0x0401444F RID: 83023
		private static IntPtr __OutSimpleStruct_NativeFunctionPtr;

		// Token: 0x04014450 RID: 83024
		private static IntPtr __OutQuatArray_NativeFunctionPtr;

		// Token: 0x04014451 RID: 83025
		private static IntPtr __OutQuat_NativeFunctionPtr;

		// Token: 0x04014452 RID: 83026
		private static IntPtr __InVectorSet_NativeFunctionPtr;

		// Token: 0x04014453 RID: 83027
		private static IntPtr __InVectorMap_NativeFunctionPtr;

		// Token: 0x04014454 RID: 83028
		private static IntPtr __InVectorArray_NativeFunctionPtr;

		// Token: 0x04014455 RID: 83029
		private static IntPtr __InVector_NativeFunctionPtr;

		// Token: 0x04014456 RID: 83030
		private static IntPtr __InTransformArray_NativeFunctionPtr;

		// Token: 0x04014457 RID: 83031
		private static IntPtr __InTransform_NativeFunctionPtr;

		// Token: 0x04014458 RID: 83032
		private static IntPtr __InSimpleStructSet_NativeFunctionPtr;

		// Token: 0x04014459 RID: 83033
		private static IntPtr __InSimpleStructMap_NativeFunctionPtr;

		// Token: 0x0401445A RID: 83034
		private static IntPtr __InSimpleStructArray_NativeFunctionPtr;

		// Token: 0x0401445B RID: 83035
		private static IntPtr __InSimpleStruct_NativeFunctionPtr;

		// Token: 0x0401445C RID: 83036
		private static IntPtr __InQuatArray_NativeFunctionPtr;

		// Token: 0x0401445D RID: 83037
		private static IntPtr __InQuat_NativeFunctionPtr;

		// Token: 0x0401445E RID: 83038
		private static IntPtr __GetVectorSet_NativeFunctionPtr;

		// Token: 0x0401445F RID: 83039
		private static IntPtr __GetVectorMap_NativeFunctionPtr;

		// Token: 0x04014460 RID: 83040
		private static IntPtr __GetVectorArray_NativeFunctionPtr;

		// Token: 0x04014461 RID: 83041
		private static IntPtr __GetVector_NativeFunctionPtr;

		// Token: 0x04014462 RID: 83042
		private static IntPtr __GetTransformArray_NativeFunctionPtr;

		// Token: 0x04014463 RID: 83043
		private static IntPtr __GetTransform_NativeFunctionPtr;

		// Token: 0x04014464 RID: 83044
		private static IntPtr __GetSimpleStructSet_NativeFunctionPtr;

		// Token: 0x04014465 RID: 83045
		private static IntPtr __GetSimpleStructMap_NativeFunctionPtr;

		// Token: 0x04014466 RID: 83046
		private static IntPtr __GetSimpleStructArray_NativeFunctionPtr;

		// Token: 0x04014467 RID: 83047
		private static IntPtr __GetSimpleStruct_NativeFunctionPtr;

		// Token: 0x04014468 RID: 83048
		private static IntPtr __GetQuatArray_NativeFunctionPtr;

		// Token: 0x04014469 RID: 83049
		private static IntPtr __GetQuat_NativeFunctionPtr;

		// Token: 0x02003853 RID: 14419
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetVectorSet_FunctionParams
		{
			// Token: 0x0401797A RID: 96634
			[FieldOffset(0)]
			public byte InVectorSet;
		}

		// Token: 0x02003854 RID: 14420
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetVectorMap_FunctionParams
		{
			// Token: 0x0401797B RID: 96635
			[FieldOffset(0)]
			public byte InVectorMap;
		}

		// Token: 0x02003855 RID: 14421
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetVectorArray_FunctionParams
		{
			// Token: 0x0401797C RID: 96636
			[FieldOffset(0)]
			public byte InVectorArray;
		}

		// Token: 0x02003856 RID: 14422
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __SetVector_FunctionParams
		{
			// Token: 0x0401797D RID: 96637
			[FieldOffset(0)]
			public FVector InVector;
		}

		// Token: 0x02003857 RID: 14423
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetTransformArray_FunctionParams
		{
			// Token: 0x0401797E RID: 96638
			[FieldOffset(0)]
			public byte InTransformArray;
		}

		// Token: 0x02003858 RID: 14424
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __SetTransform_FunctionParams
		{
			// Token: 0x0401797F RID: 96639
			[FieldOffset(0)]
			public FTransform InTransform;
		}

		// Token: 0x02003859 RID: 14425
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetSimpleStructSet_FunctionParams
		{
			// Token: 0x04017980 RID: 96640
			[FieldOffset(0)]
			public byte InSimpleStructSet;
		}

		// Token: 0x0200385A RID: 14426
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetSimpleStructMap_FunctionParams
		{
			// Token: 0x04017981 RID: 96641
			[FieldOffset(0)]
			public byte InSimpleStructMap;
		}

		// Token: 0x0200385B RID: 14427
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetSimpleStructArray_FunctionParams
		{
			// Token: 0x04017982 RID: 96642
			[FieldOffset(0)]
			public byte InSimpleStructArray;
		}

		// Token: 0x0200385C RID: 14428
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetSimpleStruct_FunctionParams
		{
			// Token: 0x04017983 RID: 96643
			[FieldOffset(0)]
			public byte InSimpleStruct;
		}

		// Token: 0x0200385D RID: 14429
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetQuatArray_FunctionParams
		{
			// Token: 0x04017984 RID: 96644
			[FieldOffset(0)]
			public byte InQuatArray;
		}

		// Token: 0x0200385E RID: 14430
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetQuat_FunctionParams
		{
			// Token: 0x04017985 RID: 96645
			[FieldOffset(0)]
			public FQuat InQuat;
		}

		// Token: 0x0200385F RID: 14431
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutVectorSet_FunctionParams
		{
			// Token: 0x04017986 RID: 96646
			[FieldOffset(0)]
			public byte OutVectorSet;
		}

		// Token: 0x02003860 RID: 14432
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutVectorMap_FunctionParams
		{
			// Token: 0x04017987 RID: 96647
			[FieldOffset(0)]
			public byte OutVectorMap;
		}

		// Token: 0x02003861 RID: 14433
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutVectorArray_FunctionParams
		{
			// Token: 0x04017988 RID: 96648
			[FieldOffset(0)]
			public byte OutVectorArray;
		}

		// Token: 0x02003862 RID: 14434
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __OutVector_FunctionParams
		{
			// Token: 0x04017989 RID: 96649
			[FieldOffset(0)]
			public FVector OutVector;
		}

		// Token: 0x02003863 RID: 14435
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutTransformArray_FunctionParams
		{
			// Token: 0x0401798A RID: 96650
			[FieldOffset(0)]
			public byte OutTransformArray;
		}

		// Token: 0x02003864 RID: 14436
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __OutTransform_FunctionParams
		{
			// Token: 0x0401798B RID: 96651
			[FieldOffset(0)]
			public FTransform OutTransform;
		}

		// Token: 0x02003865 RID: 14437
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutSimpleStructSet_FunctionParams
		{
			// Token: 0x0401798C RID: 96652
			[FieldOffset(0)]
			public byte OutSimpleStructSet;
		}

		// Token: 0x02003866 RID: 14438
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutSimpleStructMap_FunctionParams
		{
			// Token: 0x0401798D RID: 96653
			[FieldOffset(0)]
			public byte OutSimpleStructMap;
		}

		// Token: 0x02003867 RID: 14439
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutSimpleStructArray_FunctionParams
		{
			// Token: 0x0401798E RID: 96654
			[FieldOffset(0)]
			public byte OutSimpleStructArray;
		}

		// Token: 0x02003868 RID: 14440
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __OutSimpleStruct_FunctionParams
		{
			// Token: 0x0401798F RID: 96655
			[FieldOffset(0)]
			public byte OutSimpleStruct;
		}

		// Token: 0x02003869 RID: 14441
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutQuatArray_FunctionParams
		{
			// Token: 0x04017990 RID: 96656
			[FieldOffset(0)]
			public byte OutQuatArray;
		}

		// Token: 0x0200386A RID: 14442
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutQuat_FunctionParams
		{
			// Token: 0x04017991 RID: 96657
			[FieldOffset(0)]
			public FQuat OutQuat;
		}

		// Token: 0x0200386B RID: 14443
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InVectorSet_FunctionParams
		{
			// Token: 0x04017992 RID: 96658
			[FieldOffset(0)]
			public byte InVectorSet;
		}

		// Token: 0x0200386C RID: 14444
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InVectorMap_FunctionParams
		{
			// Token: 0x04017993 RID: 96659
			[FieldOffset(0)]
			public byte InVectorMap;
		}

		// Token: 0x0200386D RID: 14445
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InVectorArray_FunctionParams
		{
			// Token: 0x04017994 RID: 96660
			[FieldOffset(0)]
			public byte InVectorArray;
		}

		// Token: 0x0200386E RID: 14446
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InVector_FunctionParams
		{
			// Token: 0x04017995 RID: 96661
			[FieldOffset(0)]
			public FVector InVector;
		}

		// Token: 0x0200386F RID: 14447
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InTransformArray_FunctionParams
		{
			// Token: 0x04017996 RID: 96662
			[FieldOffset(0)]
			public byte InTransformArray;
		}

		// Token: 0x02003870 RID: 14448
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __InTransform_FunctionParams
		{
			// Token: 0x04017997 RID: 96663
			[FieldOffset(0)]
			public FTransform InTransform;
		}

		// Token: 0x02003871 RID: 14449
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InSimpleStructSet_FunctionParams
		{
			// Token: 0x04017998 RID: 96664
			[FieldOffset(0)]
			public byte InSimpleStructSet;
		}

		// Token: 0x02003872 RID: 14450
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InSimpleStructMap_FunctionParams
		{
			// Token: 0x04017999 RID: 96665
			[FieldOffset(0)]
			public byte InSimpleStructMap;
		}

		// Token: 0x02003873 RID: 14451
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InSimpleStructArray_FunctionParams
		{
			// Token: 0x0401799A RID: 96666
			[FieldOffset(0)]
			public byte InSimpleStructArray;
		}

		// Token: 0x02003874 RID: 14452
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InSimpleStruct_FunctionParams
		{
			// Token: 0x0401799B RID: 96667
			[FieldOffset(0)]
			public byte InSimpleStruct;
		}

		// Token: 0x02003875 RID: 14453
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InQuatArray_FunctionParams
		{
			// Token: 0x0401799C RID: 96668
			[FieldOffset(0)]
			public byte InQuatArray;
		}

		// Token: 0x02003876 RID: 14454
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InQuat_FunctionParams
		{
			// Token: 0x0401799D RID: 96669
			[FieldOffset(0)]
			public FQuat InQuat;
		}

		// Token: 0x02003877 RID: 14455
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetVectorSet_FunctionParams
		{
			// Token: 0x0401799E RID: 96670
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003878 RID: 14456
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetVectorMap_FunctionParams
		{
			// Token: 0x0401799F RID: 96671
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003879 RID: 14457
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetVectorArray_FunctionParams
		{
			// Token: 0x040179A0 RID: 96672
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200387A RID: 14458
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetVector_FunctionParams
		{
			// Token: 0x040179A1 RID: 96673
			[FieldOffset(0)]
			public FVector __Result;
		}

		// Token: 0x0200387B RID: 14459
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetTransformArray_FunctionParams
		{
			// Token: 0x040179A2 RID: 96674
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200387C RID: 14460
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __GetTransform_FunctionParams
		{
			// Token: 0x040179A3 RID: 96675
			[FieldOffset(0)]
			public FTransform __Result;
		}

		// Token: 0x0200387D RID: 14461
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetSimpleStructSet_FunctionParams
		{
			// Token: 0x040179A4 RID: 96676
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200387E RID: 14462
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetSimpleStructMap_FunctionParams
		{
			// Token: 0x040179A5 RID: 96677
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200387F RID: 14463
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSimpleStructArray_FunctionParams
		{
			// Token: 0x040179A6 RID: 96678
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003880 RID: 14464
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetSimpleStruct_FunctionParams
		{
			// Token: 0x040179A7 RID: 96679
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003881 RID: 14465
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetQuatArray_FunctionParams
		{
			// Token: 0x040179A8 RID: 96680
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003882 RID: 14466
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetQuat_FunctionParams
		{
			// Token: 0x040179A9 RID: 96681
			[FieldOffset(0)]
			public FQuat __Result;
		}
	}
}
