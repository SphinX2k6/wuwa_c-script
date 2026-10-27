using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200274A RID: 10058
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SharpherealTest.TestClass_UFunction_Direct_Interface")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UTestClass_UFunction_Direct_Interface : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602572A RID: 153386 RVA: 0x00381ECD File Offset: 0x003800CD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTestClass_UFunction_Direct_Interface._ClassPtr;
		}

		// Token: 0x0602572B RID: 153387 RVA: 0x00381EDC File Offset: 0x003800DC
		public UTestClass_UFunction_Direct_Interface() : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_Direct_Interface.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602572C RID: 153388 RVA: 0x00381F04 File Offset: 0x00380104
		[NullableContext(1)]
		public UTestClass_UFunction_Direct_Interface(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_Direct_Interface.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009084 RID: 36996
		// (get) Token: 0x0602572D RID: 153389 RVA: 0x00381F37 File Offset: 0x00380137
		// (set) Token: 0x0602572E RID: 153390 RVA: 0x00381F4B File Offset: 0x0038014B
		public unsafe USharpherealTestSimpleClass Object
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USharpherealTestSimpleClass>(base.NativePtr / (IntPtr)sizeof(void*) + UTestClass_UFunction_Direct_Interface.__PropertyOffset_Object);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTestClass_UFunction_Direct_Interface.__PropertyOffset_Object, value);
			}
		}

		// Token: 0x17009085 RID: 36997
		// (get) Token: 0x0602572F RID: 153391 RVA: 0x00381F60 File Offset: 0x00380160
		// (set) Token: 0x06025730 RID: 153392 RVA: 0x00381F74 File Offset: 0x00380174
		public unsafe USharpherealTestSimpleClass ObjectCmp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USharpherealTestSimpleClass>(base.NativePtr / (IntPtr)sizeof(void*) + UTestClass_UFunction_Direct_Interface.__PropertyOffset_ObjectCmp);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTestClass_UFunction_Direct_Interface.__PropertyOffset_ObjectCmp, value);
			}
		}

		// Token: 0x17009086 RID: 36998
		// (get) Token: 0x06025731 RID: 153393 RVA: 0x00381F89 File Offset: 0x00380189
		// (set) Token: 0x06025732 RID: 153394 RVA: 0x00381FA3 File Offset: 0x003801A3
		public unsafe ISharpherealTestInterface Interface
		{
			get
			{
				return (ISharpherealTestInterface)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Interface.__PropertyOffset_Interface));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Interface.__PropertyOffset_Interface) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x17009087 RID: 36999
		// (get) Token: 0x06025733 RID: 153395 RVA: 0x00381FCC File Offset: 0x003801CC
		// (set) Token: 0x06025734 RID: 153396 RVA: 0x00382005 File Offset: 0x00380205
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
					result = (this._InterfaceArray = new TArray<ISharpherealTestInterface>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Interface.__PropertyOffset_InterfaceArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.InterfaceArray.CopyAssign(value);
			}
		}

		// Token: 0x17009088 RID: 37000
		// (get) Token: 0x06025735 RID: 153397 RVA: 0x00382013 File Offset: 0x00380213
		// (set) Token: 0x06025736 RID: 153398 RVA: 0x0038202D File Offset: 0x0038022D
		public unsafe ISharpherealTestInterface2 Interface2
		{
			get
			{
				return (ISharpherealTestInterface2)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Interface.__PropertyOffset_Interface2));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Interface.__PropertyOffset_Interface2) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x17009089 RID: 37001
		// (get) Token: 0x06025737 RID: 153399 RVA: 0x00382054 File Offset: 0x00380254
		// (set) Token: 0x06025738 RID: 153400 RVA: 0x0038208D File Offset: 0x0038028D
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
					result = (this._Interface2Array = new TArray<ISharpherealTestInterface2>(base.NativePtr + (IntPtr)UTestClass_UFunction_Direct_Interface.__PropertyOffset_Interface2Array, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Interface2Array.CopyAssign(value);
			}
		}

		// Token: 0x06025739 RID: 153401 RVA: 0x0038209C File Offset: 0x0038029C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetInterfaceArray([Nullable(new byte[]
		{
			2,
			1
		})] TArray<ISharpherealTestInterface> InInterfaceArray)
		{
			UTestClass_UFunction_Direct_Interface.__SetInterfaceArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Interface.__SetInterfaceArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Interface.__SetInterfaceArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Interface.__SetInterfaceArray_NativeFunctionPtr, (void*)ptr, 1);
			if (InInterfaceArray != null)
			{
				InInterfaceArray.CopyTo(&ptr->InInterfaceArray, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Interface.__SetInterfaceArray_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Interface.__SetInterfaceArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602573A RID: 153402 RVA: 0x00382108 File Offset: 0x00380308
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetInterface2Array([Nullable(new byte[]
		{
			2,
			1
		})] TArray<ISharpherealTestInterface2> InInterface2Array)
		{
			UTestClass_UFunction_Direct_Interface.__SetInterface2Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Interface.__SetInterface2Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Interface.__SetInterface2Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Interface.__SetInterface2Array_NativeFunctionPtr, (void*)ptr, 1);
			if (InInterface2Array != null)
			{
				InInterface2Array.CopyTo(&ptr->InInterface2Array, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Interface.__SetInterface2Array_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Interface.__SetInterface2Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602573B RID: 153403 RVA: 0x00382174 File Offset: 0x00380374
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetInterface2(ISharpherealTestInterface2 InInterface2)
		{
			UTestClass_UFunction_Direct_Interface.__SetInterface2_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Interface.__SetInterface2_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Interface.__SetInterface2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Interface.__SetInterface2_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InInterface2 = new FScriptInterface(InInterface2, (InInterface2 != null) ? InInterface2.InterfaceOffset() : 0);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Interface.__SetInterface2_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602573C RID: 153404 RVA: 0x003821CC File Offset: 0x003803CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetInterface(ISharpherealTestInterface InInterface)
		{
			UTestClass_UFunction_Direct_Interface.__SetInterface_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Interface.__SetInterface_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Interface.__SetInterface_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Interface.__SetInterface_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InInterface = new FScriptInterface(InInterface, (InInterface != null) ? InInterface.InterfaceOffset() : 0);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Interface.__SetInterface_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602573D RID: 153405 RVA: 0x00382224 File Offset: 0x00380424
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutInterfaceArray([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<ISharpherealTestInterface> OutInterfaceArray)
		{
			UTestClass_UFunction_Direct_Interface.__OutInterfaceArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Interface.__OutInterfaceArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Interface.__OutInterfaceArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Interface.__OutInterfaceArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<ISharpherealTestInterface> tarray = OutInterfaceArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutInterfaceArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Interface.__OutInterfaceArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<ISharpherealTestInterface> tarray2 = OutInterfaceArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutInterfaceArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Interface.__OutInterfaceArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602573E RID: 153406 RVA: 0x003822A0 File Offset: 0x003804A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutInterface2Array([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<ISharpherealTestInterface2> OutInterface2Array)
		{
			UTestClass_UFunction_Direct_Interface.__OutInterface2Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Interface.__OutInterface2Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Interface.__OutInterface2Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Interface.__OutInterface2Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<ISharpherealTestInterface2> tarray = OutInterface2Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutInterface2Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Interface.__OutInterface2Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<ISharpherealTestInterface2> tarray2 = OutInterface2Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutInterface2Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Interface.__OutInterface2Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602573F RID: 153407 RVA: 0x0038231C File Offset: 0x0038051C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutInterface2(ref ISharpherealTestInterface2 OutInterface2)
		{
			UTestClass_UFunction_Direct_Interface.__OutInterface2_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Interface.__OutInterface2_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Interface.__OutInterface2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Interface.__OutInterface2_NativeFunctionPtr, (void*)ptr, 1);
			ref UTestClass_UFunction_Direct_Interface.__OutInterface2_FunctionParams ptr2 = ref *ptr;
			IUnrealNativeInterface @object = OutInterface2;
			ISharpherealTestInterface2 sharpherealTestInterface = OutInterface2;
			ptr2.OutInterface2 = new FScriptInterface(@object, (sharpherealTestInterface != null) ? sharpherealTestInterface.InterfaceOffset() : 0);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Interface.__OutInterface2_NativeFunctionPtr, (void*)ptr, 0);
			OutInterface2 = (BuiltinUtils.GetOrCreateUObjectByNativePointer(ptr->OutInterface2.ObjectPointer) as ISharpherealTestInterface2);
		}

		// Token: 0x06025740 RID: 153408 RVA: 0x00382390 File Offset: 0x00380590
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OutInterface(ref ISharpherealTestInterface OutInterface)
		{
			UTestClass_UFunction_Direct_Interface.__OutInterface_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Interface.__OutInterface_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Interface.__OutInterface_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Interface.__OutInterface_NativeFunctionPtr, (void*)ptr, 1);
			ref UTestClass_UFunction_Direct_Interface.__OutInterface_FunctionParams ptr2 = ref *ptr;
			IUnrealNativeInterface @object = OutInterface;
			ISharpherealTestInterface sharpherealTestInterface = OutInterface;
			ptr2.OutInterface = new FScriptInterface(@object, (sharpherealTestInterface != null) ? sharpherealTestInterface.InterfaceOffset() : 0);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Interface.__OutInterface_NativeFunctionPtr, (void*)ptr, 0);
			OutInterface = (BuiltinUtils.GetOrCreateUObjectByNativePointer(ptr->OutInterface.ObjectPointer) as ISharpherealTestInterface);
		}

		// Token: 0x06025741 RID: 153409 RVA: 0x00382404 File Offset: 0x00380604
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InInterfaceArray([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<ISharpherealTestInterface> InInterfaceArray)
		{
			UTestClass_UFunction_Direct_Interface.__InInterfaceArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Interface.__InInterfaceArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Interface.__InInterfaceArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Interface.__InInterfaceArray_NativeFunctionPtr, (void*)ptr, 1);
			TArray<ISharpherealTestInterface> tarray = InInterfaceArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InInterfaceArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Interface.__InInterfaceArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<ISharpherealTestInterface> tarray2 = InInterfaceArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InInterfaceArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Interface.__InInterfaceArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025742 RID: 153410 RVA: 0x00382480 File Offset: 0x00380680
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InInterface2Array([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<ISharpherealTestInterface2> InInterface2Array)
		{
			UTestClass_UFunction_Direct_Interface.__InInterface2Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Interface.__InInterface2Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Interface.__InInterface2Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Interface.__InInterface2Array_NativeFunctionPtr, (void*)ptr, 1);
			TArray<ISharpherealTestInterface2> tarray = InInterface2Array;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InInterface2Array);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Interface.__InInterface2Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<ISharpherealTestInterface2> tarray2 = InInterface2Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InInterface2Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Interface.__InInterface2Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025743 RID: 153411 RVA: 0x003824FC File Offset: 0x003806FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InInterface2(in ISharpherealTestInterface2 InInterface2)
		{
			UTestClass_UFunction_Direct_Interface.__InInterface2_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Interface.__InInterface2_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Interface.__InInterface2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Interface.__InInterface2_NativeFunctionPtr, (void*)ptr, 1);
			ref UTestClass_UFunction_Direct_Interface.__InInterface2_FunctionParams ptr2 = ref *ptr;
			IUnrealNativeInterface @object = InInterface2;
			ISharpherealTestInterface2 sharpherealTestInterface = InInterface2;
			ptr2.InInterface2 = new FScriptInterface(@object, (sharpherealTestInterface != null) ? sharpherealTestInterface.InterfaceOffset() : 0);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Interface.__InInterface2_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025744 RID: 153412 RVA: 0x00382558 File Offset: 0x00380758
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void InInterface(in ISharpherealTestInterface InInterface)
		{
			UTestClass_UFunction_Direct_Interface.__InInterface_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Interface.__InInterface_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Interface.__InInterface_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Interface.__InInterface_NativeFunctionPtr, (void*)ptr, 1);
			ref UTestClass_UFunction_Direct_Interface.__InInterface_FunctionParams ptr2 = ref *ptr;
			IUnrealNativeInterface @object = InInterface;
			ISharpherealTestInterface sharpherealTestInterface = InInterface;
			ptr2.InInterface = new FScriptInterface(@object, (sharpherealTestInterface != null) ? sharpherealTestInterface.InterfaceOffset() : 0);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Interface.__InInterface_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025745 RID: 153413 RVA: 0x003825B4 File Offset: 0x003807B4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<ISharpherealTestInterface> GetInterfaceArray()
		{
			UTestClass_UFunction_Direct_Interface.__GetInterfaceArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Interface.__GetInterfaceArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Interface.__GetInterfaceArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Interface.__GetInterfaceArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Interface.__GetInterfaceArray_NativeFunctionPtr, (void*)ptr, 0);
			TArray<ISharpherealTestInterface> result = new TArray<ISharpherealTestInterface>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Interface.__GetInterfaceArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025746 RID: 153414 RVA: 0x00382614 File Offset: 0x00380814
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<ISharpherealTestInterface2> GetInterface2Array()
		{
			UTestClass_UFunction_Direct_Interface.__GetInterface2Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Interface.__GetInterface2Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Interface.__GetInterface2Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Interface.__GetInterface2Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Interface.__GetInterface2Array_NativeFunctionPtr, (void*)ptr, 0);
			TArray<ISharpherealTestInterface2> result = new TArray<ISharpherealTestInterface2>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Interface.__GetInterface2Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06025747 RID: 153415 RVA: 0x00382674 File Offset: 0x00380874
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe ISharpherealTestInterface2 GetInterface2()
		{
			UTestClass_UFunction_Direct_Interface.__GetInterface2_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Interface.__GetInterface2_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Interface.__GetInterface2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Interface.__GetInterface2_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Interface.__GetInterface2_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer(ptr->__Result.ObjectPointer) as ISharpherealTestInterface2;
		}

		// Token: 0x06025748 RID: 153416 RVA: 0x003826CC File Offset: 0x003808CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe ISharpherealTestInterface GetInterface()
		{
			UTestClass_UFunction_Direct_Interface.__GetInterface_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Interface.__GetInterface_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Interface.__GetInterface_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Interface.__GetInterface_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Interface.__GetInterface_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer(ptr->__Result.ObjectPointer) as ISharpherealTestInterface;
		}

		// Token: 0x06025749 RID: 153417 RVA: 0x00382721 File Offset: 0x00380921
		static UTestClass_UFunction_Direct_Interface()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SharpherealTest.TestClass_UFunction_Direct_Interface");
		}

		// Token: 0x0602574A RID: 153418 RVA: 0x0038272F File Offset: 0x0038092F
		protected UTestClass_UFunction_Direct_Interface(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401446A RID: 83050
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SharpherealTest.TestClass_UFunction_Direct_Interface";

		// Token: 0x0401446B RID: 83051
		private static IntPtr _ClassPtr;

		// Token: 0x0401446C RID: 83052
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401446D RID: 83053
		internal static int __PropertyOffset_Object;

		// Token: 0x0401446E RID: 83054
		internal static int __PropertyOffset_ObjectCmp;

		// Token: 0x0401446F RID: 83055
		internal static int __PropertyOffset_Interface;

		// Token: 0x04014470 RID: 83056
		internal static int __PropertyOffset_InterfaceArray;

		// Token: 0x04014471 RID: 83057
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ISharpherealTestInterface> _InterfaceArray;

		// Token: 0x04014472 RID: 83058
		internal static int __PropertyOffset_Interface2;

		// Token: 0x04014473 RID: 83059
		internal static int __PropertyOffset_Interface2Array;

		// Token: 0x04014474 RID: 83060
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ISharpherealTestInterface2> _Interface2Array;

		// Token: 0x04014475 RID: 83061
		private static IntPtr __SetInterfaceArray_NativeFunctionPtr;

		// Token: 0x04014476 RID: 83062
		private static IntPtr __SetInterface2Array_NativeFunctionPtr;

		// Token: 0x04014477 RID: 83063
		private static IntPtr __SetInterface2_NativeFunctionPtr;

		// Token: 0x04014478 RID: 83064
		private static IntPtr __SetInterface_NativeFunctionPtr;

		// Token: 0x04014479 RID: 83065
		private static IntPtr __OutInterfaceArray_NativeFunctionPtr;

		// Token: 0x0401447A RID: 83066
		private static IntPtr __OutInterface2Array_NativeFunctionPtr;

		// Token: 0x0401447B RID: 83067
		private static IntPtr __OutInterface2_NativeFunctionPtr;

		// Token: 0x0401447C RID: 83068
		private static IntPtr __OutInterface_NativeFunctionPtr;

		// Token: 0x0401447D RID: 83069
		private static IntPtr __InInterfaceArray_NativeFunctionPtr;

		// Token: 0x0401447E RID: 83070
		private static IntPtr __InInterface2Array_NativeFunctionPtr;

		// Token: 0x0401447F RID: 83071
		private static IntPtr __InInterface2_NativeFunctionPtr;

		// Token: 0x04014480 RID: 83072
		private static IntPtr __InInterface_NativeFunctionPtr;

		// Token: 0x04014481 RID: 83073
		private static IntPtr __GetInterfaceArray_NativeFunctionPtr;

		// Token: 0x04014482 RID: 83074
		private static IntPtr __GetInterface2Array_NativeFunctionPtr;

		// Token: 0x04014483 RID: 83075
		private static IntPtr __GetInterface2_NativeFunctionPtr;

		// Token: 0x04014484 RID: 83076
		private static IntPtr __GetInterface_NativeFunctionPtr;

		// Token: 0x02003883 RID: 14467
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetInterfaceArray_FunctionParams
		{
			// Token: 0x040179AA RID: 96682
			[FieldOffset(0)]
			public byte InInterfaceArray;
		}

		// Token: 0x02003884 RID: 14468
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetInterface2Array_FunctionParams
		{
			// Token: 0x040179AB RID: 96683
			[FieldOffset(0)]
			public byte InInterface2Array;
		}

		// Token: 0x02003885 RID: 14469
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetInterface2_FunctionParams
		{
			// Token: 0x040179AC RID: 96684
			[FieldOffset(0)]
			public FScriptInterface InInterface2;
		}

		// Token: 0x02003886 RID: 14470
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetInterface_FunctionParams
		{
			// Token: 0x040179AD RID: 96685
			[FieldOffset(0)]
			public FScriptInterface InInterface;
		}

		// Token: 0x02003887 RID: 14471
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutInterfaceArray_FunctionParams
		{
			// Token: 0x040179AE RID: 96686
			[FieldOffset(0)]
			public byte OutInterfaceArray;
		}

		// Token: 0x02003888 RID: 14472
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutInterface2Array_FunctionParams
		{
			// Token: 0x040179AF RID: 96687
			[FieldOffset(0)]
			public byte OutInterface2Array;
		}

		// Token: 0x02003889 RID: 14473
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutInterface2_FunctionParams
		{
			// Token: 0x040179B0 RID: 96688
			[FieldOffset(0)]
			public FScriptInterface OutInterface2;
		}

		// Token: 0x0200388A RID: 14474
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutInterface_FunctionParams
		{
			// Token: 0x040179B1 RID: 96689
			[FieldOffset(0)]
			public FScriptInterface OutInterface;
		}

		// Token: 0x0200388B RID: 14475
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InInterfaceArray_FunctionParams
		{
			// Token: 0x040179B2 RID: 96690
			[FieldOffset(0)]
			public byte InInterfaceArray;
		}

		// Token: 0x0200388C RID: 14476
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InInterface2Array_FunctionParams
		{
			// Token: 0x040179B3 RID: 96691
			[FieldOffset(0)]
			public byte InInterface2Array;
		}

		// Token: 0x0200388D RID: 14477
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InInterface2_FunctionParams
		{
			// Token: 0x040179B4 RID: 96692
			[FieldOffset(0)]
			public FScriptInterface InInterface2;
		}

		// Token: 0x0200388E RID: 14478
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InInterface_FunctionParams
		{
			// Token: 0x040179B5 RID: 96693
			[FieldOffset(0)]
			public FScriptInterface InInterface;
		}

		// Token: 0x0200388F RID: 14479
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetInterfaceArray_FunctionParams
		{
			// Token: 0x040179B6 RID: 96694
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003890 RID: 14480
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetInterface2Array_FunctionParams
		{
			// Token: 0x040179B7 RID: 96695
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003891 RID: 14481
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetInterface2_FunctionParams
		{
			// Token: 0x040179B8 RID: 96696
			[FieldOffset(0)]
			public FScriptInterface __Result;
		}

		// Token: 0x02003892 RID: 14482
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetInterface_FunctionParams
		{
			// Token: 0x040179B9 RID: 96697
			[FieldOffset(0)]
			public FScriptInterface __Result;
		}
	}
}
