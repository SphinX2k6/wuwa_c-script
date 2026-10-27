using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200274F RID: 10063
	[UnrealObjectPath("/Script/SharpherealTest.TestClass_UFunction_FStruct")]
	[UnrealStructLayout(544, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 544)]
	public class UTestClass_UFunction_FStruct : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060258A1 RID: 153761 RVA: 0x00388DED File Offset: 0x00386FED
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTestClass_UFunction_FStruct._ClassPtr;
		}

		// Token: 0x060258A2 RID: 153762 RVA: 0x00388DFC File Offset: 0x00386FFC
		public UTestClass_UFunction_FStruct() : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_FStruct.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060258A3 RID: 153763 RVA: 0x00388E24 File Offset: 0x00387024
		[NullableContext(1)]
		public UTestClass_UFunction_FStruct(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_FStruct.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170090C6 RID: 37062
		// (get) Token: 0x060258A4 RID: 153764 RVA: 0x00388E57 File Offset: 0x00387057
		// (set) Token: 0x060258A5 RID: 153765 RVA: 0x00388E6B File Offset: 0x0038706B
		public unsafe FVector Vector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_FStruct.__PropertyOffset_Vector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_FStruct.__PropertyOffset_Vector) = value;
			}
		}

		// Token: 0x170090C7 RID: 37063
		// (get) Token: 0x060258A6 RID: 153766 RVA: 0x00388E80 File Offset: 0x00387080
		// (set) Token: 0x060258A7 RID: 153767 RVA: 0x00388EB9 File Offset: 0x003870B9
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
					result = (this._VectorArray = new TArray<FVector>(base.NativePtr + (IntPtr)UTestClass_UFunction_FStruct.__PropertyOffset_VectorArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.VectorArray.CopyAssign(value);
			}
		}

		// Token: 0x170090C8 RID: 37064
		// (get) Token: 0x060258A8 RID: 153768 RVA: 0x00388EC8 File Offset: 0x003870C8
		// (set) Token: 0x060258A9 RID: 153769 RVA: 0x00388F01 File Offset: 0x00387101
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
					result = (this._VectorSet = new TSet<FVector>(base.NativePtr + (IntPtr)UTestClass_UFunction_FStruct.__PropertyOffset_VectorSet, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.VectorSet.CopyAssign(value);
			}
		}

		// Token: 0x170090C9 RID: 37065
		// (get) Token: 0x060258AA RID: 153770 RVA: 0x00388F10 File Offset: 0x00387110
		// (set) Token: 0x060258AB RID: 153771 RVA: 0x00388F49 File Offset: 0x00387149
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
					result = (this._VectorMap = new TMap<FVector, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_FStruct.__PropertyOffset_VectorMap, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.VectorMap.CopyAssign(value);
			}
		}

		// Token: 0x170090CA RID: 37066
		// (get) Token: 0x060258AC RID: 153772 RVA: 0x00388F57 File Offset: 0x00387157
		// (set) Token: 0x060258AD RID: 153773 RVA: 0x00388F6B File Offset: 0x0038716B
		public unsafe FQuat Quat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_FStruct.__PropertyOffset_Quat);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_FStruct.__PropertyOffset_Quat) = value;
			}
		}

		// Token: 0x170090CB RID: 37067
		// (get) Token: 0x060258AE RID: 153774 RVA: 0x00388F80 File Offset: 0x00387180
		// (set) Token: 0x060258AF RID: 153775 RVA: 0x00388FB9 File Offset: 0x003871B9
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
					result = (this._QuatArray = new TArray<FQuat>(base.NativePtr + (IntPtr)UTestClass_UFunction_FStruct.__PropertyOffset_QuatArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.QuatArray.CopyAssign(value);
			}
		}

		// Token: 0x170090CC RID: 37068
		// (get) Token: 0x060258B0 RID: 153776 RVA: 0x00388FC7 File Offset: 0x003871C7
		// (set) Token: 0x060258B1 RID: 153777 RVA: 0x00388FDB File Offset: 0x003871DB
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTestClass_UFunction_FStruct.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_FStruct.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x170090CD RID: 37069
		// (get) Token: 0x060258B2 RID: 153778 RVA: 0x00388FF0 File Offset: 0x003871F0
		// (set) Token: 0x060258B3 RID: 153779 RVA: 0x00389029 File Offset: 0x00387229
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
					result = (this._TransformArray = new TArray<FTransform>(base.NativePtr + (IntPtr)UTestClass_UFunction_FStruct.__PropertyOffset_TransformArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.TransformArray.CopyAssign(value);
			}
		}

		// Token: 0x170090CE RID: 37070
		// (get) Token: 0x060258B4 RID: 153780 RVA: 0x00389038 File Offset: 0x00387238
		// (set) Token: 0x060258B5 RID: 153781 RVA: 0x00389071 File Offset: 0x00387271
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
					result = (this._SimpleStruct = new FSharpherealTestSimpleStruct(base.NativePtr + (IntPtr)UTestClass_UFunction_FStruct.__PropertyOffset_SimpleStruct, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSharpherealTestSimpleStruct.StaticStruct(), base.NativePtr + (IntPtr)UTestClass_UFunction_FStruct.__PropertyOffset_SimpleStruct, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170090CF RID: 37071
		// (get) Token: 0x060258B6 RID: 153782 RVA: 0x00389094 File Offset: 0x00387294
		// (set) Token: 0x060258B7 RID: 153783 RVA: 0x003890CD File Offset: 0x003872CD
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
					result = (this._SimpleStructArray = new TArray<FSharpherealTestSimpleStruct>(base.NativePtr + (IntPtr)UTestClass_UFunction_FStruct.__PropertyOffset_SimpleStructArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SimpleStructArray.CopyAssign(value);
			}
		}

		// Token: 0x170090D0 RID: 37072
		// (get) Token: 0x060258B8 RID: 153784 RVA: 0x003890DC File Offset: 0x003872DC
		// (set) Token: 0x060258B9 RID: 153785 RVA: 0x00389115 File Offset: 0x00387315
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
					result = (this._SimpleStructSet = new TSet<FSharpherealTestSimpleStruct>(base.NativePtr + (IntPtr)UTestClass_UFunction_FStruct.__PropertyOffset_SimpleStructSet, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SimpleStructSet.CopyAssign(value);
			}
		}

		// Token: 0x170090D1 RID: 37073
		// (get) Token: 0x060258BA RID: 153786 RVA: 0x00389124 File Offset: 0x00387324
		// (set) Token: 0x060258BB RID: 153787 RVA: 0x0038915D File Offset: 0x0038735D
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
					result = (this._SimpleStructMap = new TMap<FSharpherealTestSimpleStruct, int>(base.NativePtr + (IntPtr)UTestClass_UFunction_FStruct.__PropertyOffset_SimpleStructMap, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SimpleStructMap.CopyAssign(value);
			}
		}

		// Token: 0x060258BC RID: 153788 RVA: 0x0038916C File Offset: 0x0038736C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetVectorSet(TSet<FVector> InVectorSet)
		{
			UTestClass_UFunction_FStruct.__SetVectorSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__SetVectorSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__SetVectorSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__SetVectorSet_NativeFunctionPtr, (void*)ptr, 1);
			if (InVectorSet != null)
			{
				InVectorSet.CopyTo(&ptr->InVectorSet, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__SetVectorSet_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__SetVectorSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060258BD RID: 153789 RVA: 0x003891D8 File Offset: 0x003873D8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetVectorMap(TMap<FVector, int> InVectorMap)
		{
			UTestClass_UFunction_FStruct.__SetVectorMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__SetVectorMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__SetVectorMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__SetVectorMap_NativeFunctionPtr, (void*)ptr, 1);
			if (InVectorMap != null)
			{
				InVectorMap.CopyTo(&ptr->InVectorMap, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__SetVectorMap_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__SetVectorMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060258BE RID: 153790 RVA: 0x00389244 File Offset: 0x00387444
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetVectorArray(TArray<FVector> InVectorArray)
		{
			UTestClass_UFunction_FStruct.__SetVectorArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__SetVectorArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__SetVectorArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__SetVectorArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InVectorArray != null)
			{
				InVectorArray.CopyTo(&ptr->InVectorArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__SetVectorArray_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__SetVectorArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060258BF RID: 153791 RVA: 0x003892B0 File Offset: 0x003874B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetVector(FVector InVector)
		{
			UTestClass_UFunction_FStruct.__SetVector_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__SetVector_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__SetVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__SetVector_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InVector = InVector;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__SetVector_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060258C0 RID: 153792 RVA: 0x003892F8 File Offset: 0x003874F8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetTransformArray(TArray<FTransform> InTransformArray)
		{
			UTestClass_UFunction_FStruct.__SetTransformArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__SetTransformArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__SetTransformArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__SetTransformArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InTransformArray != null)
			{
				InTransformArray.CopyTo(&ptr->InTransformArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__SetTransformArray_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__SetTransformArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060258C1 RID: 153793 RVA: 0x00389364 File Offset: 0x00387564
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetTransform(FTransform InTransform)
		{
			UTestClass_UFunction_FStruct.__SetTransform_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__SetTransform_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__SetTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__SetTransform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InTransform = InTransform;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__SetTransform_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060258C2 RID: 153794 RVA: 0x003893AC File Offset: 0x003875AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetSimpleStructSet([Nullable(new byte[]
		{
			2,
			1
		})] TSet<FSharpherealTestSimpleStruct> InSimpleStructSet)
		{
			UTestClass_UFunction_FStruct.__SetSimpleStructSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__SetSimpleStructSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__SetSimpleStructSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__SetSimpleStructSet_NativeFunctionPtr, (void*)ptr, 1);
			if (InSimpleStructSet != null)
			{
				InSimpleStructSet.CopyTo(&ptr->InSimpleStructSet, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__SetSimpleStructSet_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__SetSimpleStructSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060258C3 RID: 153795 RVA: 0x00389418 File Offset: 0x00387618
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetSimpleStructMap([Nullable(new byte[]
		{
			2,
			1
		})] TMap<FSharpherealTestSimpleStruct, int> InSimpleStructMap)
		{
			UTestClass_UFunction_FStruct.__SetSimpleStructMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__SetSimpleStructMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__SetSimpleStructMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__SetSimpleStructMap_NativeFunctionPtr, (void*)ptr, 1);
			if (InSimpleStructMap != null)
			{
				InSimpleStructMap.CopyTo(&ptr->InSimpleStructMap, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__SetSimpleStructMap_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__SetSimpleStructMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060258C4 RID: 153796 RVA: 0x00389484 File Offset: 0x00387684
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetSimpleStructArray([Nullable(new byte[]
		{
			2,
			1
		})] TArray<FSharpherealTestSimpleStruct> InSimpleStructArray)
		{
			UTestClass_UFunction_FStruct.__SetSimpleStructArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__SetSimpleStructArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__SetSimpleStructArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__SetSimpleStructArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InSimpleStructArray != null)
			{
				InSimpleStructArray.CopyTo(&ptr->InSimpleStructArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__SetSimpleStructArray_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__SetSimpleStructArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060258C5 RID: 153797 RVA: 0x003894F0 File Offset: 0x003876F0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetSimpleStruct(FSharpherealTestSimpleStruct InSimpleStruct)
		{
			UTestClass_UFunction_FStruct.__SetSimpleStruct_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__SetSimpleStruct_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__SetSimpleStruct_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__SetSimpleStruct_NativeFunctionPtr, (void*)ptr, 1);
			if (InSimpleStruct != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSharpherealTestSimpleStruct.StaticStruct(), &ptr->InSimpleStruct, InSimpleStruct.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__SetSimpleStruct_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__SetSimpleStruct_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060258C6 RID: 153798 RVA: 0x00389564 File Offset: 0x00387764
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetQuatArray(TArray<FQuat> InQuatArray)
		{
			UTestClass_UFunction_FStruct.__SetQuatArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__SetQuatArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__SetQuatArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__SetQuatArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InQuatArray != null)
			{
				InQuatArray.CopyTo(&ptr->InQuatArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__SetQuatArray_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__SetQuatArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060258C7 RID: 153799 RVA: 0x003895D0 File Offset: 0x003877D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetQuat(FQuat InQuat)
		{
			UTestClass_UFunction_FStruct.__SetQuat_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__SetQuat_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__SetQuat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__SetQuat_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InQuat = InQuat;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__SetQuat_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060258C8 RID: 153800 RVA: 0x00389618 File Offset: 0x00387818
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutVectorSet(ref TSet<FVector> OutVectorSet)
		{
			UTestClass_UFunction_FStruct.__OutVectorSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__OutVectorSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__OutVectorSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__OutVectorSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<FVector> tset = OutVectorSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutVectorSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__OutVectorSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<FVector> tset2 = OutVectorSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutVectorSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__OutVectorSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060258C9 RID: 153801 RVA: 0x00389694 File Offset: 0x00387894
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutVectorMap(ref TMap<FVector, int> OutVectorMap)
		{
			UTestClass_UFunction_FStruct.__OutVectorMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__OutVectorMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__OutVectorMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__OutVectorMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FVector, int> tmap = OutVectorMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutVectorMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__OutVectorMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FVector, int> tmap2 = OutVectorMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutVectorMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__OutVectorMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060258CA RID: 153802 RVA: 0x00389710 File Offset: 0x00387910
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutVectorArray(ref TArray<FVector> OutVectorArray)
		{
			UTestClass_UFunction_FStruct.__OutVectorArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__OutVectorArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__OutVectorArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__OutVectorArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FVector> tarray = OutVectorArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutVectorArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__OutVectorArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FVector> tarray2 = OutVectorArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutVectorArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__OutVectorArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060258CB RID: 153803 RVA: 0x0038978C File Offset: 0x0038798C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutVector(ref FVector OutVector)
		{
			UTestClass_UFunction_FStruct.__OutVector_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__OutVector_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__OutVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__OutVector_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutVector = OutVector;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__OutVector_NativeFunctionPtr, (void*)ptr, 0);
			OutVector = ptr->OutVector;
		}

		// Token: 0x060258CC RID: 153804 RVA: 0x003897E4 File Offset: 0x003879E4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutTransformArray(ref TArray<FTransform> OutTransformArray)
		{
			UTestClass_UFunction_FStruct.__OutTransformArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__OutTransformArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__OutTransformArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__OutTransformArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FTransform> tarray = OutTransformArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutTransformArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__OutTransformArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FTransform> tarray2 = OutTransformArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutTransformArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__OutTransformArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060258CD RID: 153805 RVA: 0x00389860 File Offset: 0x00387A60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutTransform(ref FTransform OutTransform)
		{
			UTestClass_UFunction_FStruct.__OutTransform_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__OutTransform_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__OutTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__OutTransform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutTransform = OutTransform;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__OutTransform_NativeFunctionPtr, (void*)ptr, 0);
			OutTransform = ptr->OutTransform;
		}

		// Token: 0x060258CE RID: 153806 RVA: 0x003898B8 File Offset: 0x00387AB8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutSimpleStructSet([Nullable(new byte[]
		{
			2,
			1
		})] ref TSet<FSharpherealTestSimpleStruct> OutSimpleStructSet)
		{
			UTestClass_UFunction_FStruct.__OutSimpleStructSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__OutSimpleStructSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__OutSimpleStructSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__OutSimpleStructSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<FSharpherealTestSimpleStruct> tset = OutSimpleStructSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutSimpleStructSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__OutSimpleStructSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<FSharpherealTestSimpleStruct> tset2 = OutSimpleStructSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutSimpleStructSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__OutSimpleStructSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060258CF RID: 153807 RVA: 0x00389934 File Offset: 0x00387B34
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutSimpleStructMap([Nullable(new byte[]
		{
			2,
			1
		})] ref TMap<FSharpherealTestSimpleStruct, int> OutSimpleStructMap)
		{
			UTestClass_UFunction_FStruct.__OutSimpleStructMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__OutSimpleStructMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__OutSimpleStructMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__OutSimpleStructMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FSharpherealTestSimpleStruct, int> tmap = OutSimpleStructMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutSimpleStructMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__OutSimpleStructMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FSharpherealTestSimpleStruct, int> tmap2 = OutSimpleStructMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutSimpleStructMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__OutSimpleStructMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060258D0 RID: 153808 RVA: 0x003899B0 File Offset: 0x00387BB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutSimpleStructArray([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FSharpherealTestSimpleStruct> OutSimpleStructArray)
		{
			UTestClass_UFunction_FStruct.__OutSimpleStructArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__OutSimpleStructArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__OutSimpleStructArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__OutSimpleStructArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FSharpherealTestSimpleStruct> tarray = OutSimpleStructArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutSimpleStructArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__OutSimpleStructArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FSharpherealTestSimpleStruct> tarray2 = OutSimpleStructArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutSimpleStructArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__OutSimpleStructArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060258D1 RID: 153809 RVA: 0x00389A2C File Offset: 0x00387C2C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutSimpleStruct(ref FSharpherealTestSimpleStruct OutSimpleStruct)
		{
			UTestClass_UFunction_FStruct.__OutSimpleStruct_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__OutSimpleStruct_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__OutSimpleStruct_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__OutSimpleStruct_NativeFunctionPtr, (void*)ptr, 1);
			if (OutSimpleStruct != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSharpherealTestSimpleStruct.StaticStruct(), &ptr->OutSimpleStruct, OutSimpleStruct.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__OutSimpleStruct_NativeFunctionPtr, (void*)ptr, 0);
			if (OutSimpleStruct != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSharpherealTestSimpleStruct.StaticStruct(), OutSimpleStruct.NativePtr, &ptr->OutSimpleStruct, 1, false);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__OutSimpleStruct_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060258D2 RID: 153810 RVA: 0x00389AC8 File Offset: 0x00387CC8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutQuatArray(ref TArray<FQuat> OutQuatArray)
		{
			UTestClass_UFunction_FStruct.__OutQuatArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__OutQuatArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__OutQuatArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__OutQuatArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FQuat> tarray = OutQuatArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutQuatArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__OutQuatArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FQuat> tarray2 = OutQuatArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutQuatArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__OutQuatArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060258D3 RID: 153811 RVA: 0x00389B44 File Offset: 0x00387D44
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutQuat(ref FQuat OutQuat)
		{
			UTestClass_UFunction_FStruct.__OutQuat_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__OutQuat_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__OutQuat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__OutQuat_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutQuat = OutQuat;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__OutQuat_NativeFunctionPtr, (void*)ptr, 0);
			OutQuat = ptr->OutQuat;
		}

		// Token: 0x060258D4 RID: 153812 RVA: 0x00389B9C File Offset: 0x00387D9C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InVectorSet(in TSet<FVector> InVectorSet)
		{
			UTestClass_UFunction_FStruct.__InVectorSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__InVectorSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__InVectorSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__InVectorSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<FVector> tset = InVectorSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InVectorSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__InVectorSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<FVector> tset2 = InVectorSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InVectorSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__InVectorSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060258D5 RID: 153813 RVA: 0x00389C18 File Offset: 0x00387E18
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InVectorMap(in TMap<FVector, int> InVectorMap)
		{
			UTestClass_UFunction_FStruct.__InVectorMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__InVectorMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__InVectorMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__InVectorMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FVector, int> tmap = InVectorMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InVectorMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__InVectorMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FVector, int> tmap2 = InVectorMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InVectorMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__InVectorMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060258D6 RID: 153814 RVA: 0x00389C94 File Offset: 0x00387E94
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InVectorArray(in TArray<FVector> InVectorArray)
		{
			UTestClass_UFunction_FStruct.__InVectorArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__InVectorArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__InVectorArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__InVectorArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FVector> tarray = InVectorArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InVectorArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__InVectorArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FVector> tarray2 = InVectorArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InVectorArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__InVectorArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060258D7 RID: 153815 RVA: 0x00389D10 File Offset: 0x00387F10
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InVector(in FVector InVector)
		{
			UTestClass_UFunction_FStruct.__InVector_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__InVector_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__InVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__InVector_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InVector = InVector;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__InVector_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060258D8 RID: 153816 RVA: 0x00389D5C File Offset: 0x00387F5C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InTransformArray(in TArray<FTransform> InTransformArray)
		{
			UTestClass_UFunction_FStruct.__InTransformArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__InTransformArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__InTransformArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__InTransformArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FTransform> tarray = InTransformArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InTransformArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__InTransformArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FTransform> tarray2 = InTransformArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InTransformArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__InTransformArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060258D9 RID: 153817 RVA: 0x00389DD8 File Offset: 0x00387FD8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InTransform(in FTransform InTransform)
		{
			UTestClass_UFunction_FStruct.__InTransform_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__InTransform_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__InTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__InTransform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InTransform = InTransform;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__InTransform_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060258DA RID: 153818 RVA: 0x00389E24 File Offset: 0x00388024
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InSimpleStructSet([Nullable(new byte[]
		{
			2,
			1
		})] in TSet<FSharpherealTestSimpleStruct> InSimpleStructSet)
		{
			UTestClass_UFunction_FStruct.__InSimpleStructSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__InSimpleStructSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__InSimpleStructSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__InSimpleStructSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<FSharpherealTestSimpleStruct> tset = InSimpleStructSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InSimpleStructSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__InSimpleStructSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<FSharpherealTestSimpleStruct> tset2 = InSimpleStructSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InSimpleStructSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__InSimpleStructSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060258DB RID: 153819 RVA: 0x00389EA0 File Offset: 0x003880A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InSimpleStructMap([Nullable(new byte[]
		{
			2,
			1
		})] in TMap<FSharpherealTestSimpleStruct, int> InSimpleStructMap)
		{
			UTestClass_UFunction_FStruct.__InSimpleStructMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__InSimpleStructMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__InSimpleStructMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__InSimpleStructMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FSharpherealTestSimpleStruct, int> tmap = InSimpleStructMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InSimpleStructMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__InSimpleStructMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FSharpherealTestSimpleStruct, int> tmap2 = InSimpleStructMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InSimpleStructMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__InSimpleStructMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060258DC RID: 153820 RVA: 0x00389F1C File Offset: 0x0038811C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InSimpleStructArray([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FSharpherealTestSimpleStruct> InSimpleStructArray)
		{
			UTestClass_UFunction_FStruct.__InSimpleStructArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__InSimpleStructArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__InSimpleStructArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__InSimpleStructArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FSharpherealTestSimpleStruct> tarray = InSimpleStructArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InSimpleStructArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__InSimpleStructArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FSharpherealTestSimpleStruct> tarray2 = InSimpleStructArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InSimpleStructArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__InSimpleStructArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060258DD RID: 153821 RVA: 0x00389F98 File Offset: 0x00388198
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InSimpleStruct(in FSharpherealTestSimpleStruct InSimpleStruct)
		{
			UTestClass_UFunction_FStruct.__InSimpleStruct_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__InSimpleStruct_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__InSimpleStruct_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__InSimpleStruct_NativeFunctionPtr, (void*)ptr, 1);
			if (InSimpleStruct != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSharpherealTestSimpleStruct.StaticStruct(), &ptr->InSimpleStruct, InSimpleStruct.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__InSimpleStruct_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__InSimpleStruct_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060258DE RID: 153822 RVA: 0x0038A010 File Offset: 0x00388210
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InQuatArray(in TArray<FQuat> InQuatArray)
		{
			UTestClass_UFunction_FStruct.__InQuatArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__InQuatArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__InQuatArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__InQuatArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FQuat> tarray = InQuatArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InQuatArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__InQuatArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FQuat> tarray2 = InQuatArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InQuatArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__InQuatArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060258DF RID: 153823 RVA: 0x0038A08C File Offset: 0x0038828C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InQuat(in FQuat InQuat)
		{
			UTestClass_UFunction_FStruct.__InQuat_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__InQuat_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__InQuat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__InQuat_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InQuat = InQuat;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__InQuat_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060258E0 RID: 153824 RVA: 0x0038A0D8 File Offset: 0x003882D8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<FVector> GetVectorSet()
		{
			UTestClass_UFunction_FStruct.__GetVectorSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__GetVectorSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__GetVectorSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__GetVectorSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__GetVectorSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<FVector> result = new TSet<FVector>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__GetVectorSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060258E1 RID: 153825 RVA: 0x0038A138 File Offset: 0x00388338
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<FVector, int> GetVectorMap()
		{
			UTestClass_UFunction_FStruct.__GetVectorMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__GetVectorMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__GetVectorMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__GetVectorMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__GetVectorMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FVector, int> result = new TMap<FVector, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__GetVectorMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060258E2 RID: 153826 RVA: 0x0038A198 File Offset: 0x00388398
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<FVector> GetVectorArray()
		{
			UTestClass_UFunction_FStruct.__GetVectorArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__GetVectorArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__GetVectorArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__GetVectorArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__GetVectorArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FVector> result = new TArray<FVector>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__GetVectorArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060258E3 RID: 153827 RVA: 0x0038A1F8 File Offset: 0x003883F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FVector GetVector()
		{
			UTestClass_UFunction_FStruct.__GetVector_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__GetVector_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__GetVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__GetVector_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__GetVector_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060258E4 RID: 153828 RVA: 0x0038A240 File Offset: 0x00388440
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<FTransform> GetTransformArray()
		{
			UTestClass_UFunction_FStruct.__GetTransformArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__GetTransformArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__GetTransformArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__GetTransformArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__GetTransformArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FTransform> result = new TArray<FTransform>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__GetTransformArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060258E5 RID: 153829 RVA: 0x0038A2A0 File Offset: 0x003884A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FTransform GetTransform()
		{
			UTestClass_UFunction_FStruct.__GetTransform_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__GetTransform_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__GetTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__GetTransform_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__GetTransform_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060258E6 RID: 153830 RVA: 0x0038A2E8 File Offset: 0x003884E8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TSet<FSharpherealTestSimpleStruct> GetSimpleStructSet()
		{
			UTestClass_UFunction_FStruct.__GetSimpleStructSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__GetSimpleStructSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__GetSimpleStructSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__GetSimpleStructSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__GetSimpleStructSet_NativeFunctionPtr, (void*)ptr, 0);
			TSet<FSharpherealTestSimpleStruct> result = new TSet<FSharpherealTestSimpleStruct>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__GetSimpleStructSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060258E7 RID: 153831 RVA: 0x0038A348 File Offset: 0x00388548
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TMap<FSharpherealTestSimpleStruct, int> GetSimpleStructMap()
		{
			UTestClass_UFunction_FStruct.__GetSimpleStructMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__GetSimpleStructMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__GetSimpleStructMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__GetSimpleStructMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__GetSimpleStructMap_NativeFunctionPtr, (void*)ptr, 0);
			TMap<FSharpherealTestSimpleStruct, int> result = new TMap<FSharpherealTestSimpleStruct, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__GetSimpleStructMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060258E8 RID: 153832 RVA: 0x0038A3A8 File Offset: 0x003885A8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<FSharpherealTestSimpleStruct> GetSimpleStructArray()
		{
			UTestClass_UFunction_FStruct.__GetSimpleStructArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__GetSimpleStructArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__GetSimpleStructArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__GetSimpleStructArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__GetSimpleStructArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FSharpherealTestSimpleStruct> result = new TArray<FSharpherealTestSimpleStruct>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__GetSimpleStructArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060258E9 RID: 153833 RVA: 0x0038A408 File Offset: 0x00388608
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FSharpherealTestSimpleStruct GetSimpleStruct()
		{
			UTestClass_UFunction_FStruct.__GetSimpleStruct_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__GetSimpleStruct_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__GetSimpleStruct_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__GetSimpleStruct_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__GetSimpleStruct_NativeFunctionPtr, (void*)ptr, 0);
			FSharpherealTestSimpleStruct result = new FSharpherealTestSimpleStruct(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__GetSimpleStruct_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060258EA RID: 153834 RVA: 0x0038A468 File Offset: 0x00388668
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<FQuat> GetQuatArray()
		{
			UTestClass_UFunction_FStruct.__GetQuatArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__GetQuatArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__GetQuatArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__GetQuatArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__GetQuatArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FQuat> result = new TArray<FQuat>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__GetQuatArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060258EB RID: 153835 RVA: 0x0038A4C8 File Offset: 0x003886C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FQuat GetQuat()
		{
			UTestClass_UFunction_FStruct.__GetQuat_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__GetQuat_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__GetQuat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__GetQuat_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__GetQuat_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060258EC RID: 153836 RVA: 0x0038A50E File Offset: 0x0038870E
		static UTestClass_UFunction_FStruct()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SharpherealTest.TestClass_UFunction_FStruct");
		}

		// Token: 0x060258ED RID: 153837 RVA: 0x0038A51C File Offset: 0x0038871C
		protected UTestClass_UFunction_FStruct(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040145BF RID: 83391
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SharpherealTest.TestClass_UFunction_FStruct";

		// Token: 0x040145C0 RID: 83392
		private static IntPtr _ClassPtr;

		// Token: 0x040145C1 RID: 83393
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040145C2 RID: 83394
		internal static int __PropertyOffset_Vector;

		// Token: 0x040145C3 RID: 83395
		internal static int __PropertyOffset_VectorArray;

		// Token: 0x040145C4 RID: 83396
		[Nullable(2)]
		private TArray<FVector> _VectorArray;

		// Token: 0x040145C5 RID: 83397
		internal static int __PropertyOffset_VectorSet;

		// Token: 0x040145C6 RID: 83398
		[Nullable(2)]
		private TSet<FVector> _VectorSet;

		// Token: 0x040145C7 RID: 83399
		internal static int __PropertyOffset_VectorMap;

		// Token: 0x040145C8 RID: 83400
		[Nullable(2)]
		private TMap<FVector, int> _VectorMap;

		// Token: 0x040145C9 RID: 83401
		internal static int __PropertyOffset_Quat;

		// Token: 0x040145CA RID: 83402
		internal static int __PropertyOffset_QuatArray;

		// Token: 0x040145CB RID: 83403
		[Nullable(2)]
		private TArray<FQuat> _QuatArray;

		// Token: 0x040145CC RID: 83404
		internal static int __PropertyOffset_Transform;

		// Token: 0x040145CD RID: 83405
		internal static int __PropertyOffset_TransformArray;

		// Token: 0x040145CE RID: 83406
		[Nullable(2)]
		private TArray<FTransform> _TransformArray;

		// Token: 0x040145CF RID: 83407
		internal static int __PropertyOffset_SimpleStruct;

		// Token: 0x040145D0 RID: 83408
		[Nullable(2)]
		private FSharpherealTestSimpleStruct _SimpleStruct;

		// Token: 0x040145D1 RID: 83409
		internal static int __PropertyOffset_SimpleStructArray;

		// Token: 0x040145D2 RID: 83410
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSharpherealTestSimpleStruct> _SimpleStructArray;

		// Token: 0x040145D3 RID: 83411
		internal static int __PropertyOffset_SimpleStructSet;

		// Token: 0x040145D4 RID: 83412
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<FSharpherealTestSimpleStruct> _SimpleStructSet;

		// Token: 0x040145D5 RID: 83413
		internal static int __PropertyOffset_SimpleStructMap;

		// Token: 0x040145D6 RID: 83414
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FSharpherealTestSimpleStruct, int> _SimpleStructMap;

		// Token: 0x040145D7 RID: 83415
		private static IntPtr __SetVectorSet_NativeFunctionPtr;

		// Token: 0x040145D8 RID: 83416
		private static IntPtr __SetVectorMap_NativeFunctionPtr;

		// Token: 0x040145D9 RID: 83417
		private static IntPtr __SetVectorArray_NativeFunctionPtr;

		// Token: 0x040145DA RID: 83418
		private static IntPtr __SetVector_NativeFunctionPtr;

		// Token: 0x040145DB RID: 83419
		private static IntPtr __SetTransformArray_NativeFunctionPtr;

		// Token: 0x040145DC RID: 83420
		private static IntPtr __SetTransform_NativeFunctionPtr;

		// Token: 0x040145DD RID: 83421
		private static IntPtr __SetSimpleStructSet_NativeFunctionPtr;

		// Token: 0x040145DE RID: 83422
		private static IntPtr __SetSimpleStructMap_NativeFunctionPtr;

		// Token: 0x040145DF RID: 83423
		private static IntPtr __SetSimpleStructArray_NativeFunctionPtr;

		// Token: 0x040145E0 RID: 83424
		private static IntPtr __SetSimpleStruct_NativeFunctionPtr;

		// Token: 0x040145E1 RID: 83425
		private static IntPtr __SetQuatArray_NativeFunctionPtr;

		// Token: 0x040145E2 RID: 83426
		private static IntPtr __SetQuat_NativeFunctionPtr;

		// Token: 0x040145E3 RID: 83427
		private static IntPtr __OutVectorSet_NativeFunctionPtr;

		// Token: 0x040145E4 RID: 83428
		private static IntPtr __OutVectorMap_NativeFunctionPtr;

		// Token: 0x040145E5 RID: 83429
		private static IntPtr __OutVectorArray_NativeFunctionPtr;

		// Token: 0x040145E6 RID: 83430
		private static IntPtr __OutVector_NativeFunctionPtr;

		// Token: 0x040145E7 RID: 83431
		private static IntPtr __OutTransformArray_NativeFunctionPtr;

		// Token: 0x040145E8 RID: 83432
		private static IntPtr __OutTransform_NativeFunctionPtr;

		// Token: 0x040145E9 RID: 83433
		private static IntPtr __OutSimpleStructSet_NativeFunctionPtr;

		// Token: 0x040145EA RID: 83434
		private static IntPtr __OutSimpleStructMap_NativeFunctionPtr;

		// Token: 0x040145EB RID: 83435
		private static IntPtr __OutSimpleStructArray_NativeFunctionPtr;

		// Token: 0x040145EC RID: 83436
		private static IntPtr __OutSimpleStruct_NativeFunctionPtr;

		// Token: 0x040145ED RID: 83437
		private static IntPtr __OutQuatArray_NativeFunctionPtr;

		// Token: 0x040145EE RID: 83438
		private static IntPtr __OutQuat_NativeFunctionPtr;

		// Token: 0x040145EF RID: 83439
		private static IntPtr __InVectorSet_NativeFunctionPtr;

		// Token: 0x040145F0 RID: 83440
		private static IntPtr __InVectorMap_NativeFunctionPtr;

		// Token: 0x040145F1 RID: 83441
		private static IntPtr __InVectorArray_NativeFunctionPtr;

		// Token: 0x040145F2 RID: 83442
		private static IntPtr __InVector_NativeFunctionPtr;

		// Token: 0x040145F3 RID: 83443
		private static IntPtr __InTransformArray_NativeFunctionPtr;

		// Token: 0x040145F4 RID: 83444
		private static IntPtr __InTransform_NativeFunctionPtr;

		// Token: 0x040145F5 RID: 83445
		private static IntPtr __InSimpleStructSet_NativeFunctionPtr;

		// Token: 0x040145F6 RID: 83446
		private static IntPtr __InSimpleStructMap_NativeFunctionPtr;

		// Token: 0x040145F7 RID: 83447
		private static IntPtr __InSimpleStructArray_NativeFunctionPtr;

		// Token: 0x040145F8 RID: 83448
		private static IntPtr __InSimpleStruct_NativeFunctionPtr;

		// Token: 0x040145F9 RID: 83449
		private static IntPtr __InQuatArray_NativeFunctionPtr;

		// Token: 0x040145FA RID: 83450
		private static IntPtr __InQuat_NativeFunctionPtr;

		// Token: 0x040145FB RID: 83451
		private static IntPtr __GetVectorSet_NativeFunctionPtr;

		// Token: 0x040145FC RID: 83452
		private static IntPtr __GetVectorMap_NativeFunctionPtr;

		// Token: 0x040145FD RID: 83453
		private static IntPtr __GetVectorArray_NativeFunctionPtr;

		// Token: 0x040145FE RID: 83454
		private static IntPtr __GetVector_NativeFunctionPtr;

		// Token: 0x040145FF RID: 83455
		private static IntPtr __GetTransformArray_NativeFunctionPtr;

		// Token: 0x04014600 RID: 83456
		private static IntPtr __GetTransform_NativeFunctionPtr;

		// Token: 0x04014601 RID: 83457
		private static IntPtr __GetSimpleStructSet_NativeFunctionPtr;

		// Token: 0x04014602 RID: 83458
		private static IntPtr __GetSimpleStructMap_NativeFunctionPtr;

		// Token: 0x04014603 RID: 83459
		private static IntPtr __GetSimpleStructArray_NativeFunctionPtr;

		// Token: 0x04014604 RID: 83460
		private static IntPtr __GetSimpleStruct_NativeFunctionPtr;

		// Token: 0x04014605 RID: 83461
		private static IntPtr __GetQuatArray_NativeFunctionPtr;

		// Token: 0x04014606 RID: 83462
		private static IntPtr __GetQuat_NativeFunctionPtr;

		// Token: 0x0200395D RID: 14685
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetVectorSet_FunctionParams
		{
			// Token: 0x04017A86 RID: 96902
			[FieldOffset(0)]
			public byte InVectorSet;
		}

		// Token: 0x0200395E RID: 14686
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetVectorMap_FunctionParams
		{
			// Token: 0x04017A87 RID: 96903
			[FieldOffset(0)]
			public byte InVectorMap;
		}

		// Token: 0x0200395F RID: 14687
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetVectorArray_FunctionParams
		{
			// Token: 0x04017A88 RID: 96904
			[FieldOffset(0)]
			public byte InVectorArray;
		}

		// Token: 0x02003960 RID: 14688
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __SetVector_FunctionParams
		{
			// Token: 0x04017A89 RID: 96905
			[FieldOffset(0)]
			public FVector InVector;
		}

		// Token: 0x02003961 RID: 14689
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetTransformArray_FunctionParams
		{
			// Token: 0x04017A8A RID: 96906
			[FieldOffset(0)]
			public byte InTransformArray;
		}

		// Token: 0x02003962 RID: 14690
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __SetTransform_FunctionParams
		{
			// Token: 0x04017A8B RID: 96907
			[FieldOffset(0)]
			public FTransform InTransform;
		}

		// Token: 0x02003963 RID: 14691
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetSimpleStructSet_FunctionParams
		{
			// Token: 0x04017A8C RID: 96908
			[FieldOffset(0)]
			public byte InSimpleStructSet;
		}

		// Token: 0x02003964 RID: 14692
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetSimpleStructMap_FunctionParams
		{
			// Token: 0x04017A8D RID: 96909
			[FieldOffset(0)]
			public byte InSimpleStructMap;
		}

		// Token: 0x02003965 RID: 14693
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetSimpleStructArray_FunctionParams
		{
			// Token: 0x04017A8E RID: 96910
			[FieldOffset(0)]
			public byte InSimpleStructArray;
		}

		// Token: 0x02003966 RID: 14694
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetSimpleStruct_FunctionParams
		{
			// Token: 0x04017A8F RID: 96911
			[FieldOffset(0)]
			public byte InSimpleStruct;
		}

		// Token: 0x02003967 RID: 14695
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetQuatArray_FunctionParams
		{
			// Token: 0x04017A90 RID: 96912
			[FieldOffset(0)]
			public byte InQuatArray;
		}

		// Token: 0x02003968 RID: 14696
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetQuat_FunctionParams
		{
			// Token: 0x04017A91 RID: 96913
			[FieldOffset(0)]
			public FQuat InQuat;
		}

		// Token: 0x02003969 RID: 14697
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutVectorSet_FunctionParams
		{
			// Token: 0x04017A92 RID: 96914
			[FieldOffset(0)]
			public byte OutVectorSet;
		}

		// Token: 0x0200396A RID: 14698
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutVectorMap_FunctionParams
		{
			// Token: 0x04017A93 RID: 96915
			[FieldOffset(0)]
			public byte OutVectorMap;
		}

		// Token: 0x0200396B RID: 14699
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutVectorArray_FunctionParams
		{
			// Token: 0x04017A94 RID: 96916
			[FieldOffset(0)]
			public byte OutVectorArray;
		}

		// Token: 0x0200396C RID: 14700
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __OutVector_FunctionParams
		{
			// Token: 0x04017A95 RID: 96917
			[FieldOffset(0)]
			public FVector OutVector;
		}

		// Token: 0x0200396D RID: 14701
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutTransformArray_FunctionParams
		{
			// Token: 0x04017A96 RID: 96918
			[FieldOffset(0)]
			public byte OutTransformArray;
		}

		// Token: 0x0200396E RID: 14702
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __OutTransform_FunctionParams
		{
			// Token: 0x04017A97 RID: 96919
			[FieldOffset(0)]
			public FTransform OutTransform;
		}

		// Token: 0x0200396F RID: 14703
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutSimpleStructSet_FunctionParams
		{
			// Token: 0x04017A98 RID: 96920
			[FieldOffset(0)]
			public byte OutSimpleStructSet;
		}

		// Token: 0x02003970 RID: 14704
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutSimpleStructMap_FunctionParams
		{
			// Token: 0x04017A99 RID: 96921
			[FieldOffset(0)]
			public byte OutSimpleStructMap;
		}

		// Token: 0x02003971 RID: 14705
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutSimpleStructArray_FunctionParams
		{
			// Token: 0x04017A9A RID: 96922
			[FieldOffset(0)]
			public byte OutSimpleStructArray;
		}

		// Token: 0x02003972 RID: 14706
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __OutSimpleStruct_FunctionParams
		{
			// Token: 0x04017A9B RID: 96923
			[FieldOffset(0)]
			public byte OutSimpleStruct;
		}

		// Token: 0x02003973 RID: 14707
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutQuatArray_FunctionParams
		{
			// Token: 0x04017A9C RID: 96924
			[FieldOffset(0)]
			public byte OutQuatArray;
		}

		// Token: 0x02003974 RID: 14708
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutQuat_FunctionParams
		{
			// Token: 0x04017A9D RID: 96925
			[FieldOffset(0)]
			public FQuat OutQuat;
		}

		// Token: 0x02003975 RID: 14709
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InVectorSet_FunctionParams
		{
			// Token: 0x04017A9E RID: 96926
			[FieldOffset(0)]
			public byte InVectorSet;
		}

		// Token: 0x02003976 RID: 14710
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InVectorMap_FunctionParams
		{
			// Token: 0x04017A9F RID: 96927
			[FieldOffset(0)]
			public byte InVectorMap;
		}

		// Token: 0x02003977 RID: 14711
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InVectorArray_FunctionParams
		{
			// Token: 0x04017AA0 RID: 96928
			[FieldOffset(0)]
			public byte InVectorArray;
		}

		// Token: 0x02003978 RID: 14712
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InVector_FunctionParams
		{
			// Token: 0x04017AA1 RID: 96929
			[FieldOffset(0)]
			public FVector InVector;
		}

		// Token: 0x02003979 RID: 14713
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InTransformArray_FunctionParams
		{
			// Token: 0x04017AA2 RID: 96930
			[FieldOffset(0)]
			public byte InTransformArray;
		}

		// Token: 0x0200397A RID: 14714
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __InTransform_FunctionParams
		{
			// Token: 0x04017AA3 RID: 96931
			[FieldOffset(0)]
			public FTransform InTransform;
		}

		// Token: 0x0200397B RID: 14715
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InSimpleStructSet_FunctionParams
		{
			// Token: 0x04017AA4 RID: 96932
			[FieldOffset(0)]
			public byte InSimpleStructSet;
		}

		// Token: 0x0200397C RID: 14716
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InSimpleStructMap_FunctionParams
		{
			// Token: 0x04017AA5 RID: 96933
			[FieldOffset(0)]
			public byte InSimpleStructMap;
		}

		// Token: 0x0200397D RID: 14717
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InSimpleStructArray_FunctionParams
		{
			// Token: 0x04017AA6 RID: 96934
			[FieldOffset(0)]
			public byte InSimpleStructArray;
		}

		// Token: 0x0200397E RID: 14718
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InSimpleStruct_FunctionParams
		{
			// Token: 0x04017AA7 RID: 96935
			[FieldOffset(0)]
			public byte InSimpleStruct;
		}

		// Token: 0x0200397F RID: 14719
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InQuatArray_FunctionParams
		{
			// Token: 0x04017AA8 RID: 96936
			[FieldOffset(0)]
			public byte InQuatArray;
		}

		// Token: 0x02003980 RID: 14720
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InQuat_FunctionParams
		{
			// Token: 0x04017AA9 RID: 96937
			[FieldOffset(0)]
			public FQuat InQuat;
		}

		// Token: 0x02003981 RID: 14721
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetVectorSet_FunctionParams
		{
			// Token: 0x04017AAA RID: 96938
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003982 RID: 14722
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetVectorMap_FunctionParams
		{
			// Token: 0x04017AAB RID: 96939
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003983 RID: 14723
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetVectorArray_FunctionParams
		{
			// Token: 0x04017AAC RID: 96940
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003984 RID: 14724
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetVector_FunctionParams
		{
			// Token: 0x04017AAD RID: 96941
			[FieldOffset(0)]
			public FVector __Result;
		}

		// Token: 0x02003985 RID: 14725
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetTransformArray_FunctionParams
		{
			// Token: 0x04017AAE RID: 96942
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003986 RID: 14726
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __GetTransform_FunctionParams
		{
			// Token: 0x04017AAF RID: 96943
			[FieldOffset(0)]
			public FTransform __Result;
		}

		// Token: 0x02003987 RID: 14727
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetSimpleStructSet_FunctionParams
		{
			// Token: 0x04017AB0 RID: 96944
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003988 RID: 14728
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetSimpleStructMap_FunctionParams
		{
			// Token: 0x04017AB1 RID: 96945
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003989 RID: 14729
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSimpleStructArray_FunctionParams
		{
			// Token: 0x04017AB2 RID: 96946
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200398A RID: 14730
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetSimpleStruct_FunctionParams
		{
			// Token: 0x04017AB3 RID: 96947
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200398B RID: 14731
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetQuatArray_FunctionParams
		{
			// Token: 0x04017AB4 RID: 96948
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200398C RID: 14732
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetQuat_FunctionParams
		{
			// Token: 0x04017AB5 RID: 96949
			[FieldOffset(0)]
			public FQuat __Result;
		}
	}
}
