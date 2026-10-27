using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002750 RID: 10064
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SharpherealTest.TestClass_UFunction_Interface")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UTestClass_UFunction_Interface : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060258EE RID: 153838 RVA: 0x0038A525 File Offset: 0x00388725
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTestClass_UFunction_Interface._ClassPtr;
		}

		// Token: 0x060258EF RID: 153839 RVA: 0x0038A534 File Offset: 0x00388734
		public UTestClass_UFunction_Interface() : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_Interface.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060258F0 RID: 153840 RVA: 0x0038A55C File Offset: 0x0038875C
		[NullableContext(1)]
		public UTestClass_UFunction_Interface(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_Interface.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170090D2 RID: 37074
		// (get) Token: 0x060258F1 RID: 153841 RVA: 0x0038A58F File Offset: 0x0038878F
		// (set) Token: 0x060258F2 RID: 153842 RVA: 0x0038A5A3 File Offset: 0x003887A3
		public unsafe USharpherealTestSimpleClass Object
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USharpherealTestSimpleClass>(base.NativePtr / (IntPtr)sizeof(void*) + UTestClass_UFunction_Interface.__PropertyOffset_Object);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTestClass_UFunction_Interface.__PropertyOffset_Object, value);
			}
		}

		// Token: 0x170090D3 RID: 37075
		// (get) Token: 0x060258F3 RID: 153843 RVA: 0x0038A5B8 File Offset: 0x003887B8
		// (set) Token: 0x060258F4 RID: 153844 RVA: 0x0038A5CC File Offset: 0x003887CC
		public unsafe USharpherealTestSimpleClass ObjectCmp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USharpherealTestSimpleClass>(base.NativePtr / (IntPtr)sizeof(void*) + UTestClass_UFunction_Interface.__PropertyOffset_ObjectCmp);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTestClass_UFunction_Interface.__PropertyOffset_ObjectCmp, value);
			}
		}

		// Token: 0x170090D4 RID: 37076
		// (get) Token: 0x060258F5 RID: 153845 RVA: 0x0038A5E1 File Offset: 0x003887E1
		// (set) Token: 0x060258F6 RID: 153846 RVA: 0x0038A5FB File Offset: 0x003887FB
		public unsafe ISharpherealTestInterface Interface
		{
			get
			{
				return (ISharpherealTestInterface)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)UTestClass_UFunction_Interface.__PropertyOffset_Interface));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_Interface.__PropertyOffset_Interface) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x170090D5 RID: 37077
		// (get) Token: 0x060258F7 RID: 153847 RVA: 0x0038A624 File Offset: 0x00388824
		// (set) Token: 0x060258F8 RID: 153848 RVA: 0x0038A65D File Offset: 0x0038885D
		[Nullable(1)]
		public TArray<ISharpherealTestInterface> InterfaceArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<ISharpherealTestInterface> result;
				if ((result = this._InterfaceArray) == null)
				{
					result = (this._InterfaceArray = new TArray<ISharpherealTestInterface>(base.NativePtr + (IntPtr)UTestClass_UFunction_Interface.__PropertyOffset_InterfaceArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.InterfaceArray.CopyAssign(value);
			}
		}

		// Token: 0x170090D6 RID: 37078
		// (get) Token: 0x060258F9 RID: 153849 RVA: 0x0038A66B File Offset: 0x0038886B
		// (set) Token: 0x060258FA RID: 153850 RVA: 0x0038A685 File Offset: 0x00388885
		public unsafe ISharpherealTestInterface2 Interface2
		{
			get
			{
				return (ISharpherealTestInterface2)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)UTestClass_UFunction_Interface.__PropertyOffset_Interface2));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_Interface.__PropertyOffset_Interface2) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x170090D7 RID: 37079
		// (get) Token: 0x060258FB RID: 153851 RVA: 0x0038A6AC File Offset: 0x003888AC
		// (set) Token: 0x060258FC RID: 153852 RVA: 0x0038A6E5 File Offset: 0x003888E5
		[Nullable(1)]
		public TArray<ISharpherealTestInterface2> Interface2Array
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<ISharpherealTestInterface2> result;
				if ((result = this._Interface2Array) == null)
				{
					result = (this._Interface2Array = new TArray<ISharpherealTestInterface2>(base.NativePtr + (IntPtr)UTestClass_UFunction_Interface.__PropertyOffset_Interface2Array, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Interface2Array.CopyAssign(value);
			}
		}

		// Token: 0x060258FD RID: 153853 RVA: 0x0038A6F4 File Offset: 0x003888F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetInterfaceArray([Nullable(new byte[]
		{
			2,
			1
		})] TArray<ISharpherealTestInterface> InInterfaceArray)
		{
			UTestClass_UFunction_Interface.__SetInterfaceArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Interface.__SetInterfaceArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Interface.__SetInterfaceArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Interface.__SetInterfaceArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InInterfaceArray != null)
			{
				InInterfaceArray.CopyTo(&ptr->InInterfaceArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Interface.__SetInterfaceArray_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Interface.__SetInterfaceArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060258FE RID: 153854 RVA: 0x0038A760 File Offset: 0x00388960
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetInterface2Array([Nullable(new byte[]
		{
			2,
			1
		})] TArray<ISharpherealTestInterface2> InInterface2Array)
		{
			UTestClass_UFunction_Interface.__SetInterface2Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Interface.__SetInterface2Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Interface.__SetInterface2Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Interface.__SetInterface2Array_NativeFunctionPtr, (void*)ptr, 1);
			if (InInterface2Array != null)
			{
				InInterface2Array.CopyTo(&ptr->InInterface2Array, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Interface.__SetInterface2Array_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Interface.__SetInterface2Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060258FF RID: 153855 RVA: 0x0038A7CC File Offset: 0x003889CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetInterface2(ISharpherealTestInterface2 InInterface2)
		{
			UTestClass_UFunction_Interface.__SetInterface2_FunctionParams* ptr = stackalloc UTestClass_UFunction_Interface.__SetInterface2_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Interface.__SetInterface2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Interface.__SetInterface2_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InInterface2 = new FScriptInterface(InInterface2, (InInterface2 != null) ? InInterface2.InterfaceOffset() : 0);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Interface.__SetInterface2_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025900 RID: 153856 RVA: 0x0038A824 File Offset: 0x00388A24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetInterface(ISharpherealTestInterface InInterface)
		{
			UTestClass_UFunction_Interface.__SetInterface_FunctionParams* ptr = stackalloc UTestClass_UFunction_Interface.__SetInterface_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Interface.__SetInterface_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Interface.__SetInterface_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InInterface = new FScriptInterface(InInterface, (InInterface != null) ? InInterface.InterfaceOffset() : 0);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Interface.__SetInterface_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025901 RID: 153857 RVA: 0x0038A87C File Offset: 0x00388A7C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutInterfaceArray([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<ISharpherealTestInterface> OutInterfaceArray)
		{
			UTestClass_UFunction_Interface.__OutInterfaceArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Interface.__OutInterfaceArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Interface.__OutInterfaceArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Interface.__OutInterfaceArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<ISharpherealTestInterface> tarray = OutInterfaceArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutInterfaceArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Interface.__OutInterfaceArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<ISharpherealTestInterface> tarray2 = OutInterfaceArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutInterfaceArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Interface.__OutInterfaceArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025902 RID: 153858 RVA: 0x0038A8F8 File Offset: 0x00388AF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutInterface2Array([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<ISharpherealTestInterface2> OutInterface2Array)
		{
			UTestClass_UFunction_Interface.__OutInterface2Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Interface.__OutInterface2Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Interface.__OutInterface2Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Interface.__OutInterface2Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<ISharpherealTestInterface2> tarray = OutInterface2Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutInterface2Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Interface.__OutInterface2Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<ISharpherealTestInterface2> tarray2 = OutInterface2Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutInterface2Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Interface.__OutInterface2Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025903 RID: 153859 RVA: 0x0038A974 File Offset: 0x00388B74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutInterface2(ref ISharpherealTestInterface2 OutInterface2)
		{
			UTestClass_UFunction_Interface.__OutInterface2_FunctionParams* ptr = stackalloc UTestClass_UFunction_Interface.__OutInterface2_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Interface.__OutInterface2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Interface.__OutInterface2_NativeFunctionPtr, (void*)ptr, 1);
			ref UTestClass_UFunction_Interface.__OutInterface2_FunctionParams ptr2 = ref *ptr;
			IUnrealNativeInterface @object = OutInterface2;
			ISharpherealTestInterface2 sharpherealTestInterface = OutInterface2;
			ptr2.OutInterface2 = new FScriptInterface(@object, (sharpherealTestInterface != null) ? sharpherealTestInterface.InterfaceOffset() : 0);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Interface.__OutInterface2_NativeFunctionPtr, (void*)ptr, 0);
			OutInterface2 = (BuiltinUtils.GetOrCreateUObjectByNativePointer(ptr->OutInterface2.ObjectPointer) as ISharpherealTestInterface2);
		}

		// Token: 0x06025904 RID: 153860 RVA: 0x0038A9E8 File Offset: 0x00388BE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutInterface(ref ISharpherealTestInterface OutInterface)
		{
			UTestClass_UFunction_Interface.__OutInterface_FunctionParams* ptr = stackalloc UTestClass_UFunction_Interface.__OutInterface_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Interface.__OutInterface_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Interface.__OutInterface_NativeFunctionPtr, (void*)ptr, 1);
			ref UTestClass_UFunction_Interface.__OutInterface_FunctionParams ptr2 = ref *ptr;
			IUnrealNativeInterface @object = OutInterface;
			ISharpherealTestInterface sharpherealTestInterface = OutInterface;
			ptr2.OutInterface = new FScriptInterface(@object, (sharpherealTestInterface != null) ? sharpherealTestInterface.InterfaceOffset() : 0);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Interface.__OutInterface_NativeFunctionPtr, (void*)ptr, 0);
			OutInterface = (BuiltinUtils.GetOrCreateUObjectByNativePointer(ptr->OutInterface.ObjectPointer) as ISharpherealTestInterface);
		}

		// Token: 0x06025905 RID: 153861 RVA: 0x0038AA5C File Offset: 0x00388C5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InInterfaceArray([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<ISharpherealTestInterface> InInterfaceArray)
		{
			UTestClass_UFunction_Interface.__InInterfaceArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Interface.__InInterfaceArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Interface.__InInterfaceArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Interface.__InInterfaceArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<ISharpherealTestInterface> tarray = InInterfaceArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InInterfaceArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Interface.__InInterfaceArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<ISharpherealTestInterface> tarray2 = InInterfaceArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InInterfaceArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Interface.__InInterfaceArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025906 RID: 153862 RVA: 0x0038AAD8 File Offset: 0x00388CD8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InInterface2Array([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<ISharpherealTestInterface2> InInterface2Array)
		{
			UTestClass_UFunction_Interface.__InInterface2Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Interface.__InInterface2Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Interface.__InInterface2Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Interface.__InInterface2Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<ISharpherealTestInterface2> tarray = InInterface2Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InInterface2Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Interface.__InInterface2Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<ISharpherealTestInterface2> tarray2 = InInterface2Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InInterface2Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Interface.__InInterface2Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025907 RID: 153863 RVA: 0x0038AB54 File Offset: 0x00388D54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InInterface2(in ISharpherealTestInterface2 InInterface2)
		{
			UTestClass_UFunction_Interface.__InInterface2_FunctionParams* ptr = stackalloc UTestClass_UFunction_Interface.__InInterface2_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Interface.__InInterface2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Interface.__InInterface2_NativeFunctionPtr, (void*)ptr, 1);
			ref UTestClass_UFunction_Interface.__InInterface2_FunctionParams ptr2 = ref *ptr;
			IUnrealNativeInterface @object = InInterface2;
			ISharpherealTestInterface2 sharpherealTestInterface = InInterface2;
			ptr2.InInterface2 = new FScriptInterface(@object, (sharpherealTestInterface != null) ? sharpherealTestInterface.InterfaceOffset() : 0);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Interface.__InInterface2_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025908 RID: 153864 RVA: 0x0038ABB0 File Offset: 0x00388DB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InInterface(in ISharpherealTestInterface InInterface)
		{
			UTestClass_UFunction_Interface.__InInterface_FunctionParams* ptr = stackalloc UTestClass_UFunction_Interface.__InInterface_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Interface.__InInterface_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Interface.__InInterface_NativeFunctionPtr, (void*)ptr, 1);
			ref UTestClass_UFunction_Interface.__InInterface_FunctionParams ptr2 = ref *ptr;
			IUnrealNativeInterface @object = InInterface;
			ISharpherealTestInterface sharpherealTestInterface = InInterface;
			ptr2.InInterface = new FScriptInterface(@object, (sharpherealTestInterface != null) ? sharpherealTestInterface.InterfaceOffset() : 0);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Interface.__InInterface_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025909 RID: 153865 RVA: 0x0038AC0C File Offset: 0x00388E0C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<ISharpherealTestInterface> GetInterfaceArray()
		{
			UTestClass_UFunction_Interface.__GetInterfaceArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Interface.__GetInterfaceArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Interface.__GetInterfaceArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Interface.__GetInterfaceArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Interface.__GetInterfaceArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<ISharpherealTestInterface> result = new TArray<ISharpherealTestInterface>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Interface.__GetInterfaceArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602590A RID: 153866 RVA: 0x0038AC6C File Offset: 0x00388E6C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<ISharpherealTestInterface2> GetInterface2Array()
		{
			UTestClass_UFunction_Interface.__GetInterface2Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Interface.__GetInterface2Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Interface.__GetInterface2Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Interface.__GetInterface2Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Interface.__GetInterface2Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<ISharpherealTestInterface2> result = new TArray<ISharpherealTestInterface2>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Interface.__GetInterface2Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602590B RID: 153867 RVA: 0x0038ACCC File Offset: 0x00388ECC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe ISharpherealTestInterface2 GetInterface2()
		{
			UTestClass_UFunction_Interface.__GetInterface2_FunctionParams* ptr = stackalloc UTestClass_UFunction_Interface.__GetInterface2_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Interface.__GetInterface2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Interface.__GetInterface2_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Interface.__GetInterface2_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer(ptr->__Result.ObjectPointer) as ISharpherealTestInterface2;
		}

		// Token: 0x0602590C RID: 153868 RVA: 0x0038AD24 File Offset: 0x00388F24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe ISharpherealTestInterface GetInterface()
		{
			UTestClass_UFunction_Interface.__GetInterface_FunctionParams* ptr = stackalloc UTestClass_UFunction_Interface.__GetInterface_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Interface.__GetInterface_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Interface.__GetInterface_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Interface.__GetInterface_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer(ptr->__Result.ObjectPointer) as ISharpherealTestInterface;
		}

		// Token: 0x0602590D RID: 153869 RVA: 0x0038AD79 File Offset: 0x00388F79
		static UTestClass_UFunction_Interface()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SharpherealTest.TestClass_UFunction_Interface");
		}

		// Token: 0x0602590E RID: 153870 RVA: 0x0038AD87 File Offset: 0x00388F87
		protected UTestClass_UFunction_Interface(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014607 RID: 83463
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SharpherealTest.TestClass_UFunction_Interface";

		// Token: 0x04014608 RID: 83464
		private static IntPtr _ClassPtr;

		// Token: 0x04014609 RID: 83465
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401460A RID: 83466
		internal static int __PropertyOffset_Object;

		// Token: 0x0401460B RID: 83467
		internal static int __PropertyOffset_ObjectCmp;

		// Token: 0x0401460C RID: 83468
		internal static int __PropertyOffset_Interface;

		// Token: 0x0401460D RID: 83469
		internal static int __PropertyOffset_InterfaceArray;

		// Token: 0x0401460E RID: 83470
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ISharpherealTestInterface> _InterfaceArray;

		// Token: 0x0401460F RID: 83471
		internal static int __PropertyOffset_Interface2;

		// Token: 0x04014610 RID: 83472
		internal static int __PropertyOffset_Interface2Array;

		// Token: 0x04014611 RID: 83473
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ISharpherealTestInterface2> _Interface2Array;

		// Token: 0x04014612 RID: 83474
		private static IntPtr __SetInterfaceArray_NativeFunctionPtr;

		// Token: 0x04014613 RID: 83475
		private static IntPtr __SetInterface2Array_NativeFunctionPtr;

		// Token: 0x04014614 RID: 83476
		private static IntPtr __SetInterface2_NativeFunctionPtr;

		// Token: 0x04014615 RID: 83477
		private static IntPtr __SetInterface_NativeFunctionPtr;

		// Token: 0x04014616 RID: 83478
		private static IntPtr __OutInterfaceArray_NativeFunctionPtr;

		// Token: 0x04014617 RID: 83479
		private static IntPtr __OutInterface2Array_NativeFunctionPtr;

		// Token: 0x04014618 RID: 83480
		private static IntPtr __OutInterface2_NativeFunctionPtr;

		// Token: 0x04014619 RID: 83481
		private static IntPtr __OutInterface_NativeFunctionPtr;

		// Token: 0x0401461A RID: 83482
		private static IntPtr __InInterfaceArray_NativeFunctionPtr;

		// Token: 0x0401461B RID: 83483
		private static IntPtr __InInterface2Array_NativeFunctionPtr;

		// Token: 0x0401461C RID: 83484
		private static IntPtr __InInterface2_NativeFunctionPtr;

		// Token: 0x0401461D RID: 83485
		private static IntPtr __InInterface_NativeFunctionPtr;

		// Token: 0x0401461E RID: 83486
		private static IntPtr __GetInterfaceArray_NativeFunctionPtr;

		// Token: 0x0401461F RID: 83487
		private static IntPtr __GetInterface2Array_NativeFunctionPtr;

		// Token: 0x04014620 RID: 83488
		private static IntPtr __GetInterface2_NativeFunctionPtr;

		// Token: 0x04014621 RID: 83489
		private static IntPtr __GetInterface_NativeFunctionPtr;

		// Token: 0x0200398D RID: 14733
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetInterfaceArray_FunctionParams
		{
			// Token: 0x04017AB6 RID: 96950
			[FieldOffset(0)]
			public byte InInterfaceArray;
		}

		// Token: 0x0200398E RID: 14734
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetInterface2Array_FunctionParams
		{
			// Token: 0x04017AB7 RID: 96951
			[FieldOffset(0)]
			public byte InInterface2Array;
		}

		// Token: 0x0200398F RID: 14735
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetInterface2_FunctionParams
		{
			// Token: 0x04017AB8 RID: 96952
			[FieldOffset(0)]
			public FScriptInterface InInterface2;
		}

		// Token: 0x02003990 RID: 14736
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetInterface_FunctionParams
		{
			// Token: 0x04017AB9 RID: 96953
			[FieldOffset(0)]
			public FScriptInterface InInterface;
		}

		// Token: 0x02003991 RID: 14737
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutInterfaceArray_FunctionParams
		{
			// Token: 0x04017ABA RID: 96954
			[FieldOffset(0)]
			public byte OutInterfaceArray;
		}

		// Token: 0x02003992 RID: 14738
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutInterface2Array_FunctionParams
		{
			// Token: 0x04017ABB RID: 96955
			[FieldOffset(0)]
			public byte OutInterface2Array;
		}

		// Token: 0x02003993 RID: 14739
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutInterface2_FunctionParams
		{
			// Token: 0x04017ABC RID: 96956
			[FieldOffset(0)]
			public FScriptInterface OutInterface2;
		}

		// Token: 0x02003994 RID: 14740
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutInterface_FunctionParams
		{
			// Token: 0x04017ABD RID: 96957
			[FieldOffset(0)]
			public FScriptInterface OutInterface;
		}

		// Token: 0x02003995 RID: 14741
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InInterfaceArray_FunctionParams
		{
			// Token: 0x04017ABE RID: 96958
			[FieldOffset(0)]
			public byte InInterfaceArray;
		}

		// Token: 0x02003996 RID: 14742
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InInterface2Array_FunctionParams
		{
			// Token: 0x04017ABF RID: 96959
			[FieldOffset(0)]
			public byte InInterface2Array;
		}

		// Token: 0x02003997 RID: 14743
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InInterface2_FunctionParams
		{
			// Token: 0x04017AC0 RID: 96960
			[FieldOffset(0)]
			public FScriptInterface InInterface2;
		}

		// Token: 0x02003998 RID: 14744
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InInterface_FunctionParams
		{
			// Token: 0x04017AC1 RID: 96961
			[FieldOffset(0)]
			public FScriptInterface InInterface;
		}

		// Token: 0x02003999 RID: 14745
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetInterfaceArray_FunctionParams
		{
			// Token: 0x04017AC2 RID: 96962
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200399A RID: 14746
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetInterface2Array_FunctionParams
		{
			// Token: 0x04017AC3 RID: 96963
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200399B RID: 14747
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetInterface2_FunctionParams
		{
			// Token: 0x04017AC4 RID: 96964
			[FieldOffset(0)]
			public FScriptInterface __Result;
		}

		// Token: 0x0200399C RID: 14748
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetInterface_FunctionParams
		{
			// Token: 0x04017AC5 RID: 96965
			[FieldOffset(0)]
			public FScriptInterface __Result;
		}
	}
}
