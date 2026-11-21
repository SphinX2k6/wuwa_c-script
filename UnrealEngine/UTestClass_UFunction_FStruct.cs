using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000803 RID: 2051
	[UnrealObjectPath("/Script/SharpherealTest.TestClass_UFunction_FStruct")]
	[UnrealStructLayout(544, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 544)]
	public class UTestClass_UFunction_FStruct : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B37E RID: 45950 RVA: 0x00118364 File Offset: 0x00116564
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTestClass_UFunction_FStruct._ClassPtr;
		}

		// Token: 0x0600B37F RID: 45951 RVA: 0x00118370 File Offset: 0x00116570
		public UTestClass_UFunction_FStruct() : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_FStruct.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B380 RID: 45952 RVA: 0x00118398 File Offset: 0x00116598
		[NullableContext(1)]
		public UTestClass_UFunction_FStruct(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_FStruct.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170021AE RID: 8622
		// (get) Token: 0x0600B381 RID: 45953 RVA: 0x001183CB File Offset: 0x001165CB
		// (set) Token: 0x0600B382 RID: 45954 RVA: 0x001183DF File Offset: 0x001165DF
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

		// Token: 0x170021AF RID: 8623
		// (get) Token: 0x0600B383 RID: 45955 RVA: 0x001183F4 File Offset: 0x001165F4
		// (set) Token: 0x0600B384 RID: 45956 RVA: 0x0011842D File Offset: 0x0011662D
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

		// Token: 0x170021B0 RID: 8624
		// (get) Token: 0x0600B385 RID: 45957 RVA: 0x0011843C File Offset: 0x0011663C
		// (set) Token: 0x0600B386 RID: 45958 RVA: 0x00118475 File Offset: 0x00116675
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

		// Token: 0x170021B1 RID: 8625
		// (get) Token: 0x0600B387 RID: 45959 RVA: 0x00118484 File Offset: 0x00116684
		// (set) Token: 0x0600B388 RID: 45960 RVA: 0x001184BD File Offset: 0x001166BD
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

		// Token: 0x170021B2 RID: 8626
		// (get) Token: 0x0600B389 RID: 45961 RVA: 0x001184CB File Offset: 0x001166CB
		// (set) Token: 0x0600B38A RID: 45962 RVA: 0x001184DF File Offset: 0x001166DF
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

		// Token: 0x170021B3 RID: 8627
		// (get) Token: 0x0600B38B RID: 45963 RVA: 0x001184F4 File Offset: 0x001166F4
		// (set) Token: 0x0600B38C RID: 45964 RVA: 0x0011852D File Offset: 0x0011672D
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

		// Token: 0x170021B4 RID: 8628
		// (get) Token: 0x0600B38D RID: 45965 RVA: 0x0011853B File Offset: 0x0011673B
		// (set) Token: 0x0600B38E RID: 45966 RVA: 0x0011854F File Offset: 0x0011674F
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

		// Token: 0x170021B5 RID: 8629
		// (get) Token: 0x0600B38F RID: 45967 RVA: 0x00118564 File Offset: 0x00116764
		// (set) Token: 0x0600B390 RID: 45968 RVA: 0x0011859D File Offset: 0x0011679D
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

		// Token: 0x170021B6 RID: 8630
		// (get) Token: 0x0600B391 RID: 45969 RVA: 0x001185AC File Offset: 0x001167AC
		// (set) Token: 0x0600B392 RID: 45970 RVA: 0x001185E5 File Offset: 0x001167E5
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

		// Token: 0x170021B7 RID: 8631
		// (get) Token: 0x0600B393 RID: 45971 RVA: 0x00118608 File Offset: 0x00116808
		// (set) Token: 0x0600B394 RID: 45972 RVA: 0x00118641 File Offset: 0x00116841
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

		// Token: 0x170021B8 RID: 8632
		// (get) Token: 0x0600B395 RID: 45973 RVA: 0x00118650 File Offset: 0x00116850
		// (set) Token: 0x0600B396 RID: 45974 RVA: 0x00118689 File Offset: 0x00116889
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

		// Token: 0x170021B9 RID: 8633
		// (get) Token: 0x0600B397 RID: 45975 RVA: 0x00118698 File Offset: 0x00116898
		// (set) Token: 0x0600B398 RID: 45976 RVA: 0x001186D1 File Offset: 0x001168D1
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

		// Token: 0x0600B399 RID: 45977 RVA: 0x001186E0 File Offset: 0x001168E0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetVectorSet(TSet<FVector> InVectorSet)
		{
			UTestClass_UFunction_FStruct.__SetVectorSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__SetVectorSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__SetVectorSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__SetVectorSet_NativeFunctionPtr, (void*)ptr, 1);
			if (InVectorSet != null)
			{
				InVectorSet.CopyTo(&ptr->InVectorSet, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__SetVectorSet_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__SetVectorSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B39A RID: 45978 RVA: 0x0011874C File Offset: 0x0011694C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetVectorMap(TMap<FVector, int> InVectorMap)
		{
			UTestClass_UFunction_FStruct.__SetVectorMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__SetVectorMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__SetVectorMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__SetVectorMap_NativeFunctionPtr, (void*)ptr, 1);
			if (InVectorMap != null)
			{
				InVectorMap.CopyTo(&ptr->InVectorMap, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__SetVectorMap_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__SetVectorMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B39B RID: 45979 RVA: 0x001187B8 File Offset: 0x001169B8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetVectorArray(TArray<FVector> InVectorArray)
		{
			UTestClass_UFunction_FStruct.__SetVectorArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__SetVectorArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__SetVectorArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__SetVectorArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InVectorArray != null)
			{
				InVectorArray.CopyTo(&ptr->InVectorArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__SetVectorArray_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__SetVectorArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B39C RID: 45980 RVA: 0x00118824 File Offset: 0x00116A24
		[SkipLocalsInit]
		public unsafe void SetVector(FVector InVector)
		{
			UTestClass_UFunction_FStruct.__SetVector_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__SetVector_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__SetVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__SetVector_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InVector = InVector;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__SetVector_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B39D RID: 45981 RVA: 0x0011886C File Offset: 0x00116A6C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetTransformArray(TArray<FTransform> InTransformArray)
		{
			UTestClass_UFunction_FStruct.__SetTransformArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__SetTransformArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__SetTransformArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__SetTransformArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InTransformArray != null)
			{
				InTransformArray.CopyTo(&ptr->InTransformArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__SetTransformArray_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__SetTransformArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B39E RID: 45982 RVA: 0x001188D8 File Offset: 0x00116AD8
		[SkipLocalsInit]
		public unsafe void SetTransform(FTransform InTransform)
		{
			UTestClass_UFunction_FStruct.__SetTransform_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__SetTransform_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__SetTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__SetTransform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InTransform = InTransform;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__SetTransform_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B39F RID: 45983 RVA: 0x00118920 File Offset: 0x00116B20
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__SetSimpleStructSet_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__SetSimpleStructSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B3A0 RID: 45984 RVA: 0x0011898C File Offset: 0x00116B8C
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__SetSimpleStructMap_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__SetSimpleStructMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B3A1 RID: 45985 RVA: 0x001189F8 File Offset: 0x00116BF8
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__SetSimpleStructArray_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__SetSimpleStructArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B3A2 RID: 45986 RVA: 0x00118A64 File Offset: 0x00116C64
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetSimpleStruct(FSharpherealTestSimpleStruct InSimpleStruct)
		{
			UTestClass_UFunction_FStruct.__SetSimpleStruct_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__SetSimpleStruct_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__SetSimpleStruct_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__SetSimpleStruct_NativeFunctionPtr, (void*)ptr, 1);
			if (InSimpleStruct != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSharpherealTestSimpleStruct.StaticStruct(), &ptr->InSimpleStruct, InSimpleStruct.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__SetSimpleStruct_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__SetSimpleStruct_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B3A3 RID: 45987 RVA: 0x00118AD8 File Offset: 0x00116CD8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SetQuatArray(TArray<FQuat> InQuatArray)
		{
			UTestClass_UFunction_FStruct.__SetQuatArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__SetQuatArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__SetQuatArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__SetQuatArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InQuatArray != null)
			{
				InQuatArray.CopyTo(&ptr->InQuatArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__SetQuatArray_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__SetQuatArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B3A4 RID: 45988 RVA: 0x00118B44 File Offset: 0x00116D44
		[SkipLocalsInit]
		public unsafe void SetQuat(FQuat InQuat)
		{
			UTestClass_UFunction_FStruct.__SetQuat_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__SetQuat_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__SetQuat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__SetQuat_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InQuat = InQuat;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__SetQuat_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B3A5 RID: 45989 RVA: 0x00118B8C File Offset: 0x00116D8C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutVectorSet(ref TSet<FVector> OutVectorSet)
		{
			UTestClass_UFunction_FStruct.__OutVectorSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__OutVectorSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__OutVectorSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__OutVectorSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<FVector> tset = OutVectorSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->OutVectorSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__OutVectorSet_NativeFunctionPtr, (void*)ptr);
			TSet<FVector> tset2 = OutVectorSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutVectorSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__OutVectorSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B3A6 RID: 45990 RVA: 0x00118C04 File Offset: 0x00116E04
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutVectorMap(ref TMap<FVector, int> OutVectorMap)
		{
			UTestClass_UFunction_FStruct.__OutVectorMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__OutVectorMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__OutVectorMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__OutVectorMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FVector, int> tmap = OutVectorMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutVectorMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__OutVectorMap_NativeFunctionPtr, (void*)ptr);
			TMap<FVector, int> tmap2 = OutVectorMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutVectorMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__OutVectorMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B3A7 RID: 45991 RVA: 0x00118C7C File Offset: 0x00116E7C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutVectorArray(ref TArray<FVector> OutVectorArray)
		{
			UTestClass_UFunction_FStruct.__OutVectorArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__OutVectorArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__OutVectorArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__OutVectorArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FVector> tarray = OutVectorArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutVectorArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__OutVectorArray_NativeFunctionPtr, (void*)ptr);
			TArray<FVector> tarray2 = OutVectorArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutVectorArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__OutVectorArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B3A8 RID: 45992 RVA: 0x00118CF4 File Offset: 0x00116EF4
		[SkipLocalsInit]
		public unsafe void OutVector(ref FVector OutVector)
		{
			UTestClass_UFunction_FStruct.__OutVector_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__OutVector_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__OutVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__OutVector_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutVector = OutVector;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__OutVector_NativeFunctionPtr, (void*)ptr);
			OutVector = ptr->OutVector;
		}

		// Token: 0x0600B3A9 RID: 45993 RVA: 0x00118D4C File Offset: 0x00116F4C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutTransformArray(ref TArray<FTransform> OutTransformArray)
		{
			UTestClass_UFunction_FStruct.__OutTransformArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__OutTransformArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__OutTransformArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__OutTransformArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FTransform> tarray = OutTransformArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutTransformArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__OutTransformArray_NativeFunctionPtr, (void*)ptr);
			TArray<FTransform> tarray2 = OutTransformArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutTransformArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__OutTransformArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B3AA RID: 45994 RVA: 0x00118DC4 File Offset: 0x00116FC4
		[SkipLocalsInit]
		public unsafe void OutTransform(ref FTransform OutTransform)
		{
			UTestClass_UFunction_FStruct.__OutTransform_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__OutTransform_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__OutTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__OutTransform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutTransform = OutTransform;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__OutTransform_NativeFunctionPtr, (void*)ptr);
			OutTransform = ptr->OutTransform;
		}

		// Token: 0x0600B3AB RID: 45995 RVA: 0x00118E1C File Offset: 0x0011701C
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__OutSimpleStructSet_NativeFunctionPtr, (void*)ptr);
			TSet<FSharpherealTestSimpleStruct> tset2 = OutSimpleStructSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->OutSimpleStructSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__OutSimpleStructSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B3AC RID: 45996 RVA: 0x00118E94 File Offset: 0x00117094
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__OutSimpleStructMap_NativeFunctionPtr, (void*)ptr);
			TMap<FSharpherealTestSimpleStruct, int> tmap2 = OutSimpleStructMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutSimpleStructMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__OutSimpleStructMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B3AD RID: 45997 RVA: 0x00118F0C File Offset: 0x0011710C
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__OutSimpleStructArray_NativeFunctionPtr, (void*)ptr);
			TArray<FSharpherealTestSimpleStruct> tarray2 = OutSimpleStructArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutSimpleStructArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__OutSimpleStructArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B3AE RID: 45998 RVA: 0x00118F84 File Offset: 0x00117184
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutSimpleStruct(ref FSharpherealTestSimpleStruct OutSimpleStruct)
		{
			UTestClass_UFunction_FStruct.__OutSimpleStruct_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__OutSimpleStruct_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__OutSimpleStruct_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__OutSimpleStruct_NativeFunctionPtr, (void*)ptr, 1);
			if (OutSimpleStruct != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSharpherealTestSimpleStruct.StaticStruct(), &ptr->OutSimpleStruct, OutSimpleStruct.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__OutSimpleStruct_NativeFunctionPtr, (void*)ptr);
			if (OutSimpleStruct != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSharpherealTestSimpleStruct.StaticStruct(), OutSimpleStruct.NativePtr, &ptr->OutSimpleStruct, 1, false);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__OutSimpleStruct_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B3AF RID: 45999 RVA: 0x0011901C File Offset: 0x0011721C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void OutQuatArray(ref TArray<FQuat> OutQuatArray)
		{
			UTestClass_UFunction_FStruct.__OutQuatArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__OutQuatArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__OutQuatArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__OutQuatArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FQuat> tarray = OutQuatArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutQuatArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__OutQuatArray_NativeFunctionPtr, (void*)ptr);
			TArray<FQuat> tarray2 = OutQuatArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutQuatArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__OutQuatArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B3B0 RID: 46000 RVA: 0x00119094 File Offset: 0x00117294
		[SkipLocalsInit]
		public unsafe void OutQuat(ref FQuat OutQuat)
		{
			UTestClass_UFunction_FStruct.__OutQuat_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__OutQuat_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__OutQuat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__OutQuat_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutQuat = OutQuat;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__OutQuat_NativeFunctionPtr, (void*)ptr);
			OutQuat = ptr->OutQuat;
		}

		// Token: 0x0600B3B1 RID: 46001 RVA: 0x001190EC File Offset: 0x001172EC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InVectorSet(in TSet<FVector> InVectorSet)
		{
			UTestClass_UFunction_FStruct.__InVectorSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__InVectorSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__InVectorSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__InVectorSet_NativeFunctionPtr, (void*)ptr, 1);
			TSet<FVector> tset = InVectorSet;
			if (tset != null)
			{
				tset.MoveTo(&ptr->InVectorSet);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__InVectorSet_NativeFunctionPtr, (void*)ptr);
			TSet<FVector> tset2 = InVectorSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InVectorSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__InVectorSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B3B2 RID: 46002 RVA: 0x00119164 File Offset: 0x00117364
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InVectorMap(in TMap<FVector, int> InVectorMap)
		{
			UTestClass_UFunction_FStruct.__InVectorMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__InVectorMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__InVectorMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__InVectorMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FVector, int> tmap = InVectorMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InVectorMap);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__InVectorMap_NativeFunctionPtr, (void*)ptr);
			TMap<FVector, int> tmap2 = InVectorMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InVectorMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__InVectorMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B3B3 RID: 46003 RVA: 0x001191DC File Offset: 0x001173DC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InVectorArray(in TArray<FVector> InVectorArray)
		{
			UTestClass_UFunction_FStruct.__InVectorArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__InVectorArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__InVectorArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__InVectorArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FVector> tarray = InVectorArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InVectorArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__InVectorArray_NativeFunctionPtr, (void*)ptr);
			TArray<FVector> tarray2 = InVectorArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InVectorArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__InVectorArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B3B4 RID: 46004 RVA: 0x00119254 File Offset: 0x00117454
		[SkipLocalsInit]
		public unsafe void InVector(in FVector InVector)
		{
			UTestClass_UFunction_FStruct.__InVector_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__InVector_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__InVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__InVector_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InVector = InVector;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__InVector_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B3B5 RID: 46005 RVA: 0x001192A0 File Offset: 0x001174A0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InTransformArray(in TArray<FTransform> InTransformArray)
		{
			UTestClass_UFunction_FStruct.__InTransformArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__InTransformArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__InTransformArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__InTransformArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FTransform> tarray = InTransformArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InTransformArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__InTransformArray_NativeFunctionPtr, (void*)ptr);
			TArray<FTransform> tarray2 = InTransformArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InTransformArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__InTransformArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B3B6 RID: 46006 RVA: 0x00119318 File Offset: 0x00117518
		[SkipLocalsInit]
		public unsafe void InTransform(in FTransform InTransform)
		{
			UTestClass_UFunction_FStruct.__InTransform_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__InTransform_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__InTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__InTransform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InTransform = InTransform;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__InTransform_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B3B7 RID: 46007 RVA: 0x00119364 File Offset: 0x00117564
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__InSimpleStructSet_NativeFunctionPtr, (void*)ptr);
			TSet<FSharpherealTestSimpleStruct> tset2 = InSimpleStructSet;
			if (tset2 != null)
			{
				tset2.MoveAssign(&ptr->InSimpleStructSet);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__InSimpleStructSet_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B3B8 RID: 46008 RVA: 0x001193DC File Offset: 0x001175DC
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__InSimpleStructMap_NativeFunctionPtr, (void*)ptr);
			TMap<FSharpherealTestSimpleStruct, int> tmap2 = InSimpleStructMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InSimpleStructMap);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__InSimpleStructMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B3B9 RID: 46009 RVA: 0x00119454 File Offset: 0x00117654
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__InSimpleStructArray_NativeFunctionPtr, (void*)ptr);
			TArray<FSharpherealTestSimpleStruct> tarray2 = InSimpleStructArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InSimpleStructArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__InSimpleStructArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B3BA RID: 46010 RVA: 0x001194CC File Offset: 0x001176CC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InSimpleStruct(in FSharpherealTestSimpleStruct InSimpleStruct)
		{
			UTestClass_UFunction_FStruct.__InSimpleStruct_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__InSimpleStruct_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__InSimpleStruct_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__InSimpleStruct_NativeFunctionPtr, (void*)ptr, 1);
			if (InSimpleStruct != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSharpherealTestSimpleStruct.StaticStruct(), &ptr->InSimpleStruct, InSimpleStruct.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__InSimpleStruct_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__InSimpleStruct_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B3BB RID: 46011 RVA: 0x00119540 File Offset: 0x00117740
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void InQuatArray(in TArray<FQuat> InQuatArray)
		{
			UTestClass_UFunction_FStruct.__InQuatArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__InQuatArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__InQuatArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__InQuatArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FQuat> tarray = InQuatArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InQuatArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__InQuatArray_NativeFunctionPtr, (void*)ptr);
			TArray<FQuat> tarray2 = InQuatArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InQuatArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__InQuatArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B3BC RID: 46012 RVA: 0x001195B8 File Offset: 0x001177B8
		[SkipLocalsInit]
		public unsafe void InQuat(in FQuat InQuat)
		{
			UTestClass_UFunction_FStruct.__InQuat_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__InQuat_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__InQuat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__InQuat_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InQuat = InQuat;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__InQuat_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B3BD RID: 46013 RVA: 0x00119604 File Offset: 0x00117804
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSet<FVector> GetVectorSet()
		{
			UTestClass_UFunction_FStruct.__GetVectorSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__GetVectorSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__GetVectorSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__GetVectorSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__GetVectorSet_NativeFunctionPtr, (void*)ptr);
			TSet<FVector> result = new TSet<FVector>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__GetVectorSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B3BE RID: 46014 RVA: 0x00119664 File Offset: 0x00117864
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TMap<FVector, int> GetVectorMap()
		{
			UTestClass_UFunction_FStruct.__GetVectorMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__GetVectorMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__GetVectorMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__GetVectorMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__GetVectorMap_NativeFunctionPtr, (void*)ptr);
			TMap<FVector, int> result = new TMap<FVector, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__GetVectorMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B3BF RID: 46015 RVA: 0x001196C4 File Offset: 0x001178C4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<FVector> GetVectorArray()
		{
			UTestClass_UFunction_FStruct.__GetVectorArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__GetVectorArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__GetVectorArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__GetVectorArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__GetVectorArray_NativeFunctionPtr, (void*)ptr);
			TArray<FVector> result = new TArray<FVector>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__GetVectorArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B3C0 RID: 46016 RVA: 0x00119724 File Offset: 0x00117924
		[SkipLocalsInit]
		public unsafe FVector GetVector()
		{
			UTestClass_UFunction_FStruct.__GetVector_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__GetVector_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__GetVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__GetVector_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__GetVector_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B3C1 RID: 46017 RVA: 0x0011976C File Offset: 0x0011796C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<FTransform> GetTransformArray()
		{
			UTestClass_UFunction_FStruct.__GetTransformArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__GetTransformArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__GetTransformArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__GetTransformArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__GetTransformArray_NativeFunctionPtr, (void*)ptr);
			TArray<FTransform> result = new TArray<FTransform>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__GetTransformArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B3C2 RID: 46018 RVA: 0x001197CC File Offset: 0x001179CC
		[SkipLocalsInit]
		public unsafe FTransform GetTransform()
		{
			UTestClass_UFunction_FStruct.__GetTransform_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__GetTransform_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__GetTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__GetTransform_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__GetTransform_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B3C3 RID: 46019 RVA: 0x00119814 File Offset: 0x00117A14
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TSet<FSharpherealTestSimpleStruct> GetSimpleStructSet()
		{
			UTestClass_UFunction_FStruct.__GetSimpleStructSet_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__GetSimpleStructSet_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__GetSimpleStructSet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__GetSimpleStructSet_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__GetSimpleStructSet_NativeFunctionPtr, (void*)ptr);
			TSet<FSharpherealTestSimpleStruct> result = new TSet<FSharpherealTestSimpleStruct>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__GetSimpleStructSet_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B3C4 RID: 46020 RVA: 0x00119874 File Offset: 0x00117A74
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TMap<FSharpherealTestSimpleStruct, int> GetSimpleStructMap()
		{
			UTestClass_UFunction_FStruct.__GetSimpleStructMap_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__GetSimpleStructMap_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__GetSimpleStructMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__GetSimpleStructMap_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__GetSimpleStructMap_NativeFunctionPtr, (void*)ptr);
			TMap<FSharpherealTestSimpleStruct, int> result = new TMap<FSharpherealTestSimpleStruct, int>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__GetSimpleStructMap_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B3C5 RID: 46021 RVA: 0x001198D4 File Offset: 0x00117AD4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<FSharpherealTestSimpleStruct> GetSimpleStructArray()
		{
			UTestClass_UFunction_FStruct.__GetSimpleStructArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__GetSimpleStructArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__GetSimpleStructArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__GetSimpleStructArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__GetSimpleStructArray_NativeFunctionPtr, (void*)ptr);
			TArray<FSharpherealTestSimpleStruct> result = new TArray<FSharpherealTestSimpleStruct>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__GetSimpleStructArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B3C6 RID: 46022 RVA: 0x00119934 File Offset: 0x00117B34
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe FSharpherealTestSimpleStruct GetSimpleStruct()
		{
			UTestClass_UFunction_FStruct.__GetSimpleStruct_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__GetSimpleStruct_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__GetSimpleStruct_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__GetSimpleStruct_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__GetSimpleStruct_NativeFunctionPtr, (void*)ptr);
			FSharpherealTestSimpleStruct result = new FSharpherealTestSimpleStruct(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__GetSimpleStruct_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B3C7 RID: 46023 RVA: 0x00119994 File Offset: 0x00117B94
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<FQuat> GetQuatArray()
		{
			UTestClass_UFunction_FStruct.__GetQuatArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__GetQuatArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__GetQuatArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__GetQuatArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__GetQuatArray_NativeFunctionPtr, (void*)ptr);
			TArray<FQuat> result = new TArray<FQuat>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_FStruct.__GetQuatArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B3C8 RID: 46024 RVA: 0x001199F4 File Offset: 0x00117BF4
		[SkipLocalsInit]
		public unsafe FQuat GetQuat()
		{
			UTestClass_UFunction_FStruct.__GetQuat_FunctionParams* ptr = stackalloc UTestClass_UFunction_FStruct.__GetQuat_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_FStruct.__GetQuat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_FStruct.__GetQuat_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_FStruct.__GetQuat_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B3C9 RID: 46025 RVA: 0x00119A39 File Offset: 0x00117C39
		static UTestClass_UFunction_FStruct()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SharpherealTest.TestClass_UFunction_FStruct");
		}

		// Token: 0x0600B3CA RID: 46026 RVA: 0x00119A47 File Offset: 0x00117C47
		protected UTestClass_UFunction_FStruct(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400501E RID: 20510
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SharpherealTest.TestClass_UFunction_FStruct";

		// Token: 0x0400501F RID: 20511
		private static IntPtr _ClassPtr;

		// Token: 0x04005020 RID: 20512
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005021 RID: 20513
		internal static int __PropertyOffset_Vector;

		// Token: 0x04005022 RID: 20514
		internal static int __PropertyOffset_VectorArray;

		// Token: 0x04005023 RID: 20515
		[Nullable(2)]
		private TArray<FVector> _VectorArray;

		// Token: 0x04005024 RID: 20516
		internal static int __PropertyOffset_VectorSet;

		// Token: 0x04005025 RID: 20517
		[Nullable(2)]
		private TSet<FVector> _VectorSet;

		// Token: 0x04005026 RID: 20518
		internal static int __PropertyOffset_VectorMap;

		// Token: 0x04005027 RID: 20519
		[Nullable(2)]
		private TMap<FVector, int> _VectorMap;

		// Token: 0x04005028 RID: 20520
		internal static int __PropertyOffset_Quat;

		// Token: 0x04005029 RID: 20521
		internal static int __PropertyOffset_QuatArray;

		// Token: 0x0400502A RID: 20522
		[Nullable(2)]
		private TArray<FQuat> _QuatArray;

		// Token: 0x0400502B RID: 20523
		internal static int __PropertyOffset_Transform;

		// Token: 0x0400502C RID: 20524
		internal static int __PropertyOffset_TransformArray;

		// Token: 0x0400502D RID: 20525
		[Nullable(2)]
		private TArray<FTransform> _TransformArray;

		// Token: 0x0400502E RID: 20526
		internal static int __PropertyOffset_SimpleStruct;

		// Token: 0x0400502F RID: 20527
		[Nullable(2)]
		private FSharpherealTestSimpleStruct _SimpleStruct;

		// Token: 0x04005030 RID: 20528
		internal static int __PropertyOffset_SimpleStructArray;

		// Token: 0x04005031 RID: 20529
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSharpherealTestSimpleStruct> _SimpleStructArray;

		// Token: 0x04005032 RID: 20530
		internal static int __PropertyOffset_SimpleStructSet;

		// Token: 0x04005033 RID: 20531
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<FSharpherealTestSimpleStruct> _SimpleStructSet;

		// Token: 0x04005034 RID: 20532
		internal static int __PropertyOffset_SimpleStructMap;

		// Token: 0x04005035 RID: 20533
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FSharpherealTestSimpleStruct, int> _SimpleStructMap;

		// Token: 0x04005036 RID: 20534
		private static IntPtr __SetVectorSet_NativeFunctionPtr;

		// Token: 0x04005037 RID: 20535
		private static IntPtr __SetVectorMap_NativeFunctionPtr;

		// Token: 0x04005038 RID: 20536
		private static IntPtr __SetVectorArray_NativeFunctionPtr;

		// Token: 0x04005039 RID: 20537
		private static IntPtr __SetVector_NativeFunctionPtr;

		// Token: 0x0400503A RID: 20538
		private static IntPtr __SetTransformArray_NativeFunctionPtr;

		// Token: 0x0400503B RID: 20539
		private static IntPtr __SetTransform_NativeFunctionPtr;

		// Token: 0x0400503C RID: 20540
		private static IntPtr __SetSimpleStructSet_NativeFunctionPtr;

		// Token: 0x0400503D RID: 20541
		private static IntPtr __SetSimpleStructMap_NativeFunctionPtr;

		// Token: 0x0400503E RID: 20542
		private static IntPtr __SetSimpleStructArray_NativeFunctionPtr;

		// Token: 0x0400503F RID: 20543
		private static IntPtr __SetSimpleStruct_NativeFunctionPtr;

		// Token: 0x04005040 RID: 20544
		private static IntPtr __SetQuatArray_NativeFunctionPtr;

		// Token: 0x04005041 RID: 20545
		private static IntPtr __SetQuat_NativeFunctionPtr;

		// Token: 0x04005042 RID: 20546
		private static IntPtr __OutVectorSet_NativeFunctionPtr;

		// Token: 0x04005043 RID: 20547
		private static IntPtr __OutVectorMap_NativeFunctionPtr;

		// Token: 0x04005044 RID: 20548
		private static IntPtr __OutVectorArray_NativeFunctionPtr;

		// Token: 0x04005045 RID: 20549
		private static IntPtr __OutVector_NativeFunctionPtr;

		// Token: 0x04005046 RID: 20550
		private static IntPtr __OutTransformArray_NativeFunctionPtr;

		// Token: 0x04005047 RID: 20551
		private static IntPtr __OutTransform_NativeFunctionPtr;

		// Token: 0x04005048 RID: 20552
		private static IntPtr __OutSimpleStructSet_NativeFunctionPtr;

		// Token: 0x04005049 RID: 20553
		private static IntPtr __OutSimpleStructMap_NativeFunctionPtr;

		// Token: 0x0400504A RID: 20554
		private static IntPtr __OutSimpleStructArray_NativeFunctionPtr;

		// Token: 0x0400504B RID: 20555
		private static IntPtr __OutSimpleStruct_NativeFunctionPtr;

		// Token: 0x0400504C RID: 20556
		private static IntPtr __OutQuatArray_NativeFunctionPtr;

		// Token: 0x0400504D RID: 20557
		private static IntPtr __OutQuat_NativeFunctionPtr;

		// Token: 0x0400504E RID: 20558
		private static IntPtr __InVectorSet_NativeFunctionPtr;

		// Token: 0x0400504F RID: 20559
		private static IntPtr __InVectorMap_NativeFunctionPtr;

		// Token: 0x04005050 RID: 20560
		private static IntPtr __InVectorArray_NativeFunctionPtr;

		// Token: 0x04005051 RID: 20561
		private static IntPtr __InVector_NativeFunctionPtr;

		// Token: 0x04005052 RID: 20562
		private static IntPtr __InTransformArray_NativeFunctionPtr;

		// Token: 0x04005053 RID: 20563
		private static IntPtr __InTransform_NativeFunctionPtr;

		// Token: 0x04005054 RID: 20564
		private static IntPtr __InSimpleStructSet_NativeFunctionPtr;

		// Token: 0x04005055 RID: 20565
		private static IntPtr __InSimpleStructMap_NativeFunctionPtr;

		// Token: 0x04005056 RID: 20566
		private static IntPtr __InSimpleStructArray_NativeFunctionPtr;

		// Token: 0x04005057 RID: 20567
		private static IntPtr __InSimpleStruct_NativeFunctionPtr;

		// Token: 0x04005058 RID: 20568
		private static IntPtr __InQuatArray_NativeFunctionPtr;

		// Token: 0x04005059 RID: 20569
		private static IntPtr __InQuat_NativeFunctionPtr;

		// Token: 0x0400505A RID: 20570
		private static IntPtr __GetVectorSet_NativeFunctionPtr;

		// Token: 0x0400505B RID: 20571
		private static IntPtr __GetVectorMap_NativeFunctionPtr;

		// Token: 0x0400505C RID: 20572
		private static IntPtr __GetVectorArray_NativeFunctionPtr;

		// Token: 0x0400505D RID: 20573
		private static IntPtr __GetVector_NativeFunctionPtr;

		// Token: 0x0400505E RID: 20574
		private static IntPtr __GetTransformArray_NativeFunctionPtr;

		// Token: 0x0400505F RID: 20575
		private static IntPtr __GetTransform_NativeFunctionPtr;

		// Token: 0x04005060 RID: 20576
		private static IntPtr __GetSimpleStructSet_NativeFunctionPtr;

		// Token: 0x04005061 RID: 20577
		private static IntPtr __GetSimpleStructMap_NativeFunctionPtr;

		// Token: 0x04005062 RID: 20578
		private static IntPtr __GetSimpleStructArray_NativeFunctionPtr;

		// Token: 0x04005063 RID: 20579
		private static IntPtr __GetSimpleStruct_NativeFunctionPtr;

		// Token: 0x04005064 RID: 20580
		private static IntPtr __GetQuatArray_NativeFunctionPtr;

		// Token: 0x04005065 RID: 20581
		private static IntPtr __GetQuat_NativeFunctionPtr;

		// Token: 0x0200122F RID: 4655
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetVectorSet_FunctionParams
		{
			// Token: 0x04006639 RID: 26169
			[FieldOffset(0)]
			public byte InVectorSet;
		}

		// Token: 0x02001230 RID: 4656
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetVectorMap_FunctionParams
		{
			// Token: 0x0400663A RID: 26170
			[FieldOffset(0)]
			public byte InVectorMap;
		}

		// Token: 0x02001231 RID: 4657
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetVectorArray_FunctionParams
		{
			// Token: 0x0400663B RID: 26171
			[FieldOffset(0)]
			public byte InVectorArray;
		}

		// Token: 0x02001232 RID: 4658
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __SetVector_FunctionParams
		{
			// Token: 0x0400663C RID: 26172
			[FieldOffset(0)]
			public FVector InVector;
		}

		// Token: 0x02001233 RID: 4659
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetTransformArray_FunctionParams
		{
			// Token: 0x0400663D RID: 26173
			[FieldOffset(0)]
			public byte InTransformArray;
		}

		// Token: 0x02001234 RID: 4660
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __SetTransform_FunctionParams
		{
			// Token: 0x0400663E RID: 26174
			[FieldOffset(0)]
			public FTransform InTransform;
		}

		// Token: 0x02001235 RID: 4661
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetSimpleStructSet_FunctionParams
		{
			// Token: 0x0400663F RID: 26175
			[FieldOffset(0)]
			public byte InSimpleStructSet;
		}

		// Token: 0x02001236 RID: 4662
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetSimpleStructMap_FunctionParams
		{
			// Token: 0x04006640 RID: 26176
			[FieldOffset(0)]
			public byte InSimpleStructMap;
		}

		// Token: 0x02001237 RID: 4663
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetSimpleStructArray_FunctionParams
		{
			// Token: 0x04006641 RID: 26177
			[FieldOffset(0)]
			public byte InSimpleStructArray;
		}

		// Token: 0x02001238 RID: 4664
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetSimpleStruct_FunctionParams
		{
			// Token: 0x04006642 RID: 26178
			[FieldOffset(0)]
			public byte InSimpleStruct;
		}

		// Token: 0x02001239 RID: 4665
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetQuatArray_FunctionParams
		{
			// Token: 0x04006643 RID: 26179
			[FieldOffset(0)]
			public byte InQuatArray;
		}

		// Token: 0x0200123A RID: 4666
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetQuat_FunctionParams
		{
			// Token: 0x04006644 RID: 26180
			[FieldOffset(0)]
			public FQuat InQuat;
		}

		// Token: 0x0200123B RID: 4667
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutVectorSet_FunctionParams
		{
			// Token: 0x04006645 RID: 26181
			[FieldOffset(0)]
			public byte OutVectorSet;
		}

		// Token: 0x0200123C RID: 4668
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutVectorMap_FunctionParams
		{
			// Token: 0x04006646 RID: 26182
			[FieldOffset(0)]
			public byte OutVectorMap;
		}

		// Token: 0x0200123D RID: 4669
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutVectorArray_FunctionParams
		{
			// Token: 0x04006647 RID: 26183
			[FieldOffset(0)]
			public byte OutVectorArray;
		}

		// Token: 0x0200123E RID: 4670
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __OutVector_FunctionParams
		{
			// Token: 0x04006648 RID: 26184
			[FieldOffset(0)]
			public FVector OutVector;
		}

		// Token: 0x0200123F RID: 4671
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutTransformArray_FunctionParams
		{
			// Token: 0x04006649 RID: 26185
			[FieldOffset(0)]
			public byte OutTransformArray;
		}

		// Token: 0x02001240 RID: 4672
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __OutTransform_FunctionParams
		{
			// Token: 0x0400664A RID: 26186
			[FieldOffset(0)]
			public FTransform OutTransform;
		}

		// Token: 0x02001241 RID: 4673
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutSimpleStructSet_FunctionParams
		{
			// Token: 0x0400664B RID: 26187
			[FieldOffset(0)]
			public byte OutSimpleStructSet;
		}

		// Token: 0x02001242 RID: 4674
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __OutSimpleStructMap_FunctionParams
		{
			// Token: 0x0400664C RID: 26188
			[FieldOffset(0)]
			public byte OutSimpleStructMap;
		}

		// Token: 0x02001243 RID: 4675
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutSimpleStructArray_FunctionParams
		{
			// Token: 0x0400664D RID: 26189
			[FieldOffset(0)]
			public byte OutSimpleStructArray;
		}

		// Token: 0x02001244 RID: 4676
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __OutSimpleStruct_FunctionParams
		{
			// Token: 0x0400664E RID: 26190
			[FieldOffset(0)]
			public byte OutSimpleStruct;
		}

		// Token: 0x02001245 RID: 4677
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutQuatArray_FunctionParams
		{
			// Token: 0x0400664F RID: 26191
			[FieldOffset(0)]
			public byte OutQuatArray;
		}

		// Token: 0x02001246 RID: 4678
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutQuat_FunctionParams
		{
			// Token: 0x04006650 RID: 26192
			[FieldOffset(0)]
			public FQuat OutQuat;
		}

		// Token: 0x02001247 RID: 4679
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InVectorSet_FunctionParams
		{
			// Token: 0x04006651 RID: 26193
			[FieldOffset(0)]
			public byte InVectorSet;
		}

		// Token: 0x02001248 RID: 4680
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InVectorMap_FunctionParams
		{
			// Token: 0x04006652 RID: 26194
			[FieldOffset(0)]
			public byte InVectorMap;
		}

		// Token: 0x02001249 RID: 4681
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InVectorArray_FunctionParams
		{
			// Token: 0x04006653 RID: 26195
			[FieldOffset(0)]
			public byte InVectorArray;
		}

		// Token: 0x0200124A RID: 4682
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __InVector_FunctionParams
		{
			// Token: 0x04006654 RID: 26196
			[FieldOffset(0)]
			public FVector InVector;
		}

		// Token: 0x0200124B RID: 4683
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InTransformArray_FunctionParams
		{
			// Token: 0x04006655 RID: 26197
			[FieldOffset(0)]
			public byte InTransformArray;
		}

		// Token: 0x0200124C RID: 4684
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __InTransform_FunctionParams
		{
			// Token: 0x04006656 RID: 26198
			[FieldOffset(0)]
			public FTransform InTransform;
		}

		// Token: 0x0200124D RID: 4685
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InSimpleStructSet_FunctionParams
		{
			// Token: 0x04006657 RID: 26199
			[FieldOffset(0)]
			public byte InSimpleStructSet;
		}

		// Token: 0x0200124E RID: 4686
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __InSimpleStructMap_FunctionParams
		{
			// Token: 0x04006658 RID: 26200
			[FieldOffset(0)]
			public byte InSimpleStructMap;
		}

		// Token: 0x0200124F RID: 4687
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InSimpleStructArray_FunctionParams
		{
			// Token: 0x04006659 RID: 26201
			[FieldOffset(0)]
			public byte InSimpleStructArray;
		}

		// Token: 0x02001250 RID: 4688
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InSimpleStruct_FunctionParams
		{
			// Token: 0x0400665A RID: 26202
			[FieldOffset(0)]
			public byte InSimpleStruct;
		}

		// Token: 0x02001251 RID: 4689
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InQuatArray_FunctionParams
		{
			// Token: 0x0400665B RID: 26203
			[FieldOffset(0)]
			public byte InQuatArray;
		}

		// Token: 0x02001252 RID: 4690
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InQuat_FunctionParams
		{
			// Token: 0x0400665C RID: 26204
			[FieldOffset(0)]
			public FQuat InQuat;
		}

		// Token: 0x02001253 RID: 4691
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetVectorSet_FunctionParams
		{
			// Token: 0x0400665D RID: 26205
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001254 RID: 4692
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetVectorMap_FunctionParams
		{
			// Token: 0x0400665E RID: 26206
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001255 RID: 4693
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetVectorArray_FunctionParams
		{
			// Token: 0x0400665F RID: 26207
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001256 RID: 4694
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetVector_FunctionParams
		{
			// Token: 0x04006660 RID: 26208
			[FieldOffset(0)]
			public FVector __Result;
		}

		// Token: 0x02001257 RID: 4695
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetTransformArray_FunctionParams
		{
			// Token: 0x04006661 RID: 26209
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001258 RID: 4696
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __GetTransform_FunctionParams
		{
			// Token: 0x04006662 RID: 26210
			[FieldOffset(0)]
			public FTransform __Result;
		}

		// Token: 0x02001259 RID: 4697
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetSimpleStructSet_FunctionParams
		{
			// Token: 0x04006663 RID: 26211
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200125A RID: 4698
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetSimpleStructMap_FunctionParams
		{
			// Token: 0x04006664 RID: 26212
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200125B RID: 4699
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSimpleStructArray_FunctionParams
		{
			// Token: 0x04006665 RID: 26213
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200125C RID: 4700
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetSimpleStruct_FunctionParams
		{
			// Token: 0x04006666 RID: 26214
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200125D RID: 4701
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetQuatArray_FunctionParams
		{
			// Token: 0x04006667 RID: 26215
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200125E RID: 4702
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetQuat_FunctionParams
		{
			// Token: 0x04006668 RID: 26216
			[FieldOffset(0)]
			public FQuat __Result;
		}
	}
}
