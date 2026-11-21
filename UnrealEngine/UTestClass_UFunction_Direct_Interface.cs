using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007FE RID: 2046
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SharpherealTest.TestClass_UFunction_Direct_Interface")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UTestClass_UFunction_Direct_Interface : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B207 RID: 45575 RVA: 0x001115C4 File Offset: 0x0010F7C4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTestClass_UFunction_Direct_Interface._ClassPtr;
		}

		// Token: 0x0600B208 RID: 45576 RVA: 0x001115D0 File Offset: 0x0010F7D0
		public UTestClass_UFunction_Direct_Interface() : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_Direct_Interface.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B209 RID: 45577 RVA: 0x001115F8 File Offset: 0x0010F7F8
		[NullableContext(1)]
		public UTestClass_UFunction_Direct_Interface(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_Direct_Interface.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700216C RID: 8556
		// (get) Token: 0x0600B20A RID: 45578 RVA: 0x0011162B File Offset: 0x0010F82B
		// (set) Token: 0x0600B20B RID: 45579 RVA: 0x0011163F File Offset: 0x0010F83F
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

		// Token: 0x1700216D RID: 8557
		// (get) Token: 0x0600B20C RID: 45580 RVA: 0x00111654 File Offset: 0x0010F854
		// (set) Token: 0x0600B20D RID: 45581 RVA: 0x00111668 File Offset: 0x0010F868
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

		// Token: 0x1700216E RID: 8558
		// (get) Token: 0x0600B20E RID: 45582 RVA: 0x0011167D File Offset: 0x0010F87D
		// (set) Token: 0x0600B20F RID: 45583 RVA: 0x00111697 File Offset: 0x0010F897
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

		// Token: 0x1700216F RID: 8559
		// (get) Token: 0x0600B210 RID: 45584 RVA: 0x001116C0 File Offset: 0x0010F8C0
		// (set) Token: 0x0600B211 RID: 45585 RVA: 0x001116F9 File Offset: 0x0010F8F9
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

		// Token: 0x17002170 RID: 8560
		// (get) Token: 0x0600B212 RID: 45586 RVA: 0x00111707 File Offset: 0x0010F907
		// (set) Token: 0x0600B213 RID: 45587 RVA: 0x00111721 File Offset: 0x0010F921
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

		// Token: 0x17002171 RID: 8561
		// (get) Token: 0x0600B214 RID: 45588 RVA: 0x00111748 File Offset: 0x0010F948
		// (set) Token: 0x0600B215 RID: 45589 RVA: 0x00111781 File Offset: 0x0010F981
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

		// Token: 0x0600B216 RID: 45590 RVA: 0x00111790 File Offset: 0x0010F990
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Interface.__SetInterfaceArray_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Interface.__SetInterfaceArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B217 RID: 45591 RVA: 0x001117FC File Offset: 0x0010F9FC
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Interface.__SetInterface2Array_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Interface.__SetInterface2Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B218 RID: 45592 RVA: 0x00111868 File Offset: 0x0010FA68
		[SkipLocalsInit]
		public unsafe void SetInterface2(ISharpherealTestInterface2 InInterface2)
		{
			UTestClass_UFunction_Direct_Interface.__SetInterface2_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Interface.__SetInterface2_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Interface.__SetInterface2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Interface.__SetInterface2_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InInterface2 = new FScriptInterface(InInterface2, (InInterface2 != null) ? InInterface2.InterfaceOffset() : 0);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Interface.__SetInterface2_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B219 RID: 45593 RVA: 0x001118C0 File Offset: 0x0010FAC0
		[SkipLocalsInit]
		public unsafe void SetInterface(ISharpherealTestInterface InInterface)
		{
			UTestClass_UFunction_Direct_Interface.__SetInterface_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Interface.__SetInterface_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Interface.__SetInterface_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Interface.__SetInterface_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InInterface = new FScriptInterface(InInterface, (InInterface != null) ? InInterface.InterfaceOffset() : 0);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Interface.__SetInterface_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B21A RID: 45594 RVA: 0x00111918 File Offset: 0x0010FB18
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Interface.__OutInterfaceArray_NativeFunctionPtr, (void*)ptr);
			TArray<ISharpherealTestInterface> tarray2 = OutInterfaceArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutInterfaceArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Interface.__OutInterfaceArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B21B RID: 45595 RVA: 0x00111990 File Offset: 0x0010FB90
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Interface.__OutInterface2Array_NativeFunctionPtr, (void*)ptr);
			TArray<ISharpherealTestInterface2> tarray2 = OutInterface2Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutInterface2Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Interface.__OutInterface2Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B21C RID: 45596 RVA: 0x00111A08 File Offset: 0x0010FC08
		[SkipLocalsInit]
		public unsafe void OutInterface2(ref ISharpherealTestInterface2 OutInterface2)
		{
			UTestClass_UFunction_Direct_Interface.__OutInterface2_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Interface.__OutInterface2_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Interface.__OutInterface2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Interface.__OutInterface2_NativeFunctionPtr, (void*)ptr, 1);
			ref UTestClass_UFunction_Direct_Interface.__OutInterface2_FunctionParams ptr2 = ref *ptr;
			IUnrealNativeInterface @object = OutInterface2;
			ISharpherealTestInterface2 sharpherealTestInterface = OutInterface2;
			ptr2.OutInterface2 = new FScriptInterface(@object, (sharpherealTestInterface != null) ? sharpherealTestInterface.InterfaceOffset() : 0);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Interface.__OutInterface2_NativeFunctionPtr, (void*)ptr);
			OutInterface2 = (BuiltinUtils.GetOrCreateUObjectByNativePointer(ptr->OutInterface2.ObjectPointer) as ISharpherealTestInterface2);
		}

		// Token: 0x0600B21D RID: 45597 RVA: 0x00111A7C File Offset: 0x0010FC7C
		[SkipLocalsInit]
		public unsafe void OutInterface(ref ISharpherealTestInterface OutInterface)
		{
			UTestClass_UFunction_Direct_Interface.__OutInterface_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Interface.__OutInterface_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Interface.__OutInterface_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Interface.__OutInterface_NativeFunctionPtr, (void*)ptr, 1);
			ref UTestClass_UFunction_Direct_Interface.__OutInterface_FunctionParams ptr2 = ref *ptr;
			IUnrealNativeInterface @object = OutInterface;
			ISharpherealTestInterface sharpherealTestInterface = OutInterface;
			ptr2.OutInterface = new FScriptInterface(@object, (sharpherealTestInterface != null) ? sharpherealTestInterface.InterfaceOffset() : 0);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Interface.__OutInterface_NativeFunctionPtr, (void*)ptr);
			OutInterface = (BuiltinUtils.GetOrCreateUObjectByNativePointer(ptr->OutInterface.ObjectPointer) as ISharpherealTestInterface);
		}

		// Token: 0x0600B21E RID: 45598 RVA: 0x00111AF0 File Offset: 0x0010FCF0
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Interface.__InInterfaceArray_NativeFunctionPtr, (void*)ptr);
			TArray<ISharpherealTestInterface> tarray2 = InInterfaceArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InInterfaceArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Interface.__InInterfaceArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B21F RID: 45599 RVA: 0x00111B68 File Offset: 0x0010FD68
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Interface.__InInterface2Array_NativeFunctionPtr, (void*)ptr);
			TArray<ISharpherealTestInterface2> tarray2 = InInterface2Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InInterface2Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Interface.__InInterface2Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B220 RID: 45600 RVA: 0x00111BE0 File Offset: 0x0010FDE0
		[SkipLocalsInit]
		public unsafe void InInterface2(in ISharpherealTestInterface2 InInterface2)
		{
			UTestClass_UFunction_Direct_Interface.__InInterface2_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Interface.__InInterface2_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Interface.__InInterface2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Interface.__InInterface2_NativeFunctionPtr, (void*)ptr, 1);
			ref UTestClass_UFunction_Direct_Interface.__InInterface2_FunctionParams ptr2 = ref *ptr;
			IUnrealNativeInterface @object = InInterface2;
			ISharpherealTestInterface2 sharpherealTestInterface = InInterface2;
			ptr2.InInterface2 = new FScriptInterface(@object, (sharpherealTestInterface != null) ? sharpherealTestInterface.InterfaceOffset() : 0);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Interface.__InInterface2_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B221 RID: 45601 RVA: 0x00111C3C File Offset: 0x0010FE3C
		[SkipLocalsInit]
		public unsafe void InInterface(in ISharpherealTestInterface InInterface)
		{
			UTestClass_UFunction_Direct_Interface.__InInterface_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Interface.__InInterface_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Interface.__InInterface_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Interface.__InInterface_NativeFunctionPtr, (void*)ptr, 1);
			ref UTestClass_UFunction_Direct_Interface.__InInterface_FunctionParams ptr2 = ref *ptr;
			IUnrealNativeInterface @object = InInterface;
			ISharpherealTestInterface sharpherealTestInterface = InInterface;
			ptr2.InInterface = new FScriptInterface(@object, (sharpherealTestInterface != null) ? sharpherealTestInterface.InterfaceOffset() : 0);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Interface.__InInterface_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B222 RID: 45602 RVA: 0x00111C98 File Offset: 0x0010FE98
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<ISharpherealTestInterface> GetInterfaceArray()
		{
			UTestClass_UFunction_Direct_Interface.__GetInterfaceArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Interface.__GetInterfaceArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Interface.__GetInterfaceArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Interface.__GetInterfaceArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Interface.__GetInterfaceArray_NativeFunctionPtr, (void*)ptr);
			TArray<ISharpherealTestInterface> result = new TArray<ISharpherealTestInterface>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Interface.__GetInterfaceArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B223 RID: 45603 RVA: 0x00111CF8 File Offset: 0x0010FEF8
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<ISharpherealTestInterface2> GetInterface2Array()
		{
			UTestClass_UFunction_Direct_Interface.__GetInterface2Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Interface.__GetInterface2Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Interface.__GetInterface2Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Interface.__GetInterface2Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Interface.__GetInterface2Array_NativeFunctionPtr, (void*)ptr);
			TArray<ISharpherealTestInterface2> result = new TArray<ISharpherealTestInterface2>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Direct_Interface.__GetInterface2Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B224 RID: 45604 RVA: 0x00111D58 File Offset: 0x0010FF58
		[SkipLocalsInit]
		public unsafe ISharpherealTestInterface2 GetInterface2()
		{
			UTestClass_UFunction_Direct_Interface.__GetInterface2_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Interface.__GetInterface2_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Interface.__GetInterface2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Interface.__GetInterface2_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Interface.__GetInterface2_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer(ptr->__Result.ObjectPointer) as ISharpherealTestInterface2;
		}

		// Token: 0x0600B225 RID: 45605 RVA: 0x00111DAC File Offset: 0x0010FFAC
		[SkipLocalsInit]
		public unsafe ISharpherealTestInterface GetInterface()
		{
			UTestClass_UFunction_Direct_Interface.__GetInterface_FunctionParams* ptr = stackalloc UTestClass_UFunction_Direct_Interface.__GetInterface_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Direct_Interface.__GetInterface_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Direct_Interface.__GetInterface_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Direct_Interface.__GetInterface_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer(ptr->__Result.ObjectPointer) as ISharpherealTestInterface;
		}

		// Token: 0x0600B226 RID: 45606 RVA: 0x00111E00 File Offset: 0x00110000
		static UTestClass_UFunction_Direct_Interface()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SharpherealTest.TestClass_UFunction_Direct_Interface");
		}

		// Token: 0x0600B227 RID: 45607 RVA: 0x00111E0E File Offset: 0x0011000E
		protected UTestClass_UFunction_Direct_Interface(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004EC9 RID: 20169
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SharpherealTest.TestClass_UFunction_Direct_Interface";

		// Token: 0x04004ECA RID: 20170
		private static IntPtr _ClassPtr;

		// Token: 0x04004ECB RID: 20171
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004ECC RID: 20172
		internal static int __PropertyOffset_Object;

		// Token: 0x04004ECD RID: 20173
		internal static int __PropertyOffset_ObjectCmp;

		// Token: 0x04004ECE RID: 20174
		internal static int __PropertyOffset_Interface;

		// Token: 0x04004ECF RID: 20175
		internal static int __PropertyOffset_InterfaceArray;

		// Token: 0x04004ED0 RID: 20176
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ISharpherealTestInterface> _InterfaceArray;

		// Token: 0x04004ED1 RID: 20177
		internal static int __PropertyOffset_Interface2;

		// Token: 0x04004ED2 RID: 20178
		internal static int __PropertyOffset_Interface2Array;

		// Token: 0x04004ED3 RID: 20179
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ISharpherealTestInterface2> _Interface2Array;

		// Token: 0x04004ED4 RID: 20180
		private static IntPtr __SetInterfaceArray_NativeFunctionPtr;

		// Token: 0x04004ED5 RID: 20181
		private static IntPtr __SetInterface2Array_NativeFunctionPtr;

		// Token: 0x04004ED6 RID: 20182
		private static IntPtr __SetInterface2_NativeFunctionPtr;

		// Token: 0x04004ED7 RID: 20183
		private static IntPtr __SetInterface_NativeFunctionPtr;

		// Token: 0x04004ED8 RID: 20184
		private static IntPtr __OutInterfaceArray_NativeFunctionPtr;

		// Token: 0x04004ED9 RID: 20185
		private static IntPtr __OutInterface2Array_NativeFunctionPtr;

		// Token: 0x04004EDA RID: 20186
		private static IntPtr __OutInterface2_NativeFunctionPtr;

		// Token: 0x04004EDB RID: 20187
		private static IntPtr __OutInterface_NativeFunctionPtr;

		// Token: 0x04004EDC RID: 20188
		private static IntPtr __InInterfaceArray_NativeFunctionPtr;

		// Token: 0x04004EDD RID: 20189
		private static IntPtr __InInterface2Array_NativeFunctionPtr;

		// Token: 0x04004EDE RID: 20190
		private static IntPtr __InInterface2_NativeFunctionPtr;

		// Token: 0x04004EDF RID: 20191
		private static IntPtr __InInterface_NativeFunctionPtr;

		// Token: 0x04004EE0 RID: 20192
		private static IntPtr __GetInterfaceArray_NativeFunctionPtr;

		// Token: 0x04004EE1 RID: 20193
		private static IntPtr __GetInterface2Array_NativeFunctionPtr;

		// Token: 0x04004EE2 RID: 20194
		private static IntPtr __GetInterface2_NativeFunctionPtr;

		// Token: 0x04004EE3 RID: 20195
		private static IntPtr __GetInterface_NativeFunctionPtr;

		// Token: 0x02001155 RID: 4437
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetInterfaceArray_FunctionParams
		{
			// Token: 0x0400655D RID: 25949
			[FieldOffset(0)]
			public byte InInterfaceArray;
		}

		// Token: 0x02001156 RID: 4438
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetInterface2Array_FunctionParams
		{
			// Token: 0x0400655E RID: 25950
			[FieldOffset(0)]
			public byte InInterface2Array;
		}

		// Token: 0x02001157 RID: 4439
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetInterface2_FunctionParams
		{
			// Token: 0x0400655F RID: 25951
			[FieldOffset(0)]
			public FScriptInterface InInterface2;
		}

		// Token: 0x02001158 RID: 4440
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetInterface_FunctionParams
		{
			// Token: 0x04006560 RID: 25952
			[FieldOffset(0)]
			public FScriptInterface InInterface;
		}

		// Token: 0x02001159 RID: 4441
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutInterfaceArray_FunctionParams
		{
			// Token: 0x04006561 RID: 25953
			[FieldOffset(0)]
			public byte OutInterfaceArray;
		}

		// Token: 0x0200115A RID: 4442
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutInterface2Array_FunctionParams
		{
			// Token: 0x04006562 RID: 25954
			[FieldOffset(0)]
			public byte OutInterface2Array;
		}

		// Token: 0x0200115B RID: 4443
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutInterface2_FunctionParams
		{
			// Token: 0x04006563 RID: 25955
			[FieldOffset(0)]
			public FScriptInterface OutInterface2;
		}

		// Token: 0x0200115C RID: 4444
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutInterface_FunctionParams
		{
			// Token: 0x04006564 RID: 25956
			[FieldOffset(0)]
			public FScriptInterface OutInterface;
		}

		// Token: 0x0200115D RID: 4445
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InInterfaceArray_FunctionParams
		{
			// Token: 0x04006565 RID: 25957
			[FieldOffset(0)]
			public byte InInterfaceArray;
		}

		// Token: 0x0200115E RID: 4446
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InInterface2Array_FunctionParams
		{
			// Token: 0x04006566 RID: 25958
			[FieldOffset(0)]
			public byte InInterface2Array;
		}

		// Token: 0x0200115F RID: 4447
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InInterface2_FunctionParams
		{
			// Token: 0x04006567 RID: 25959
			[FieldOffset(0)]
			public FScriptInterface InInterface2;
		}

		// Token: 0x02001160 RID: 4448
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InInterface_FunctionParams
		{
			// Token: 0x04006568 RID: 25960
			[FieldOffset(0)]
			public FScriptInterface InInterface;
		}

		// Token: 0x02001161 RID: 4449
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetInterfaceArray_FunctionParams
		{
			// Token: 0x04006569 RID: 25961
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001162 RID: 4450
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetInterface2Array_FunctionParams
		{
			// Token: 0x0400656A RID: 25962
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02001163 RID: 4451
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetInterface2_FunctionParams
		{
			// Token: 0x0400656B RID: 25963
			[FieldOffset(0)]
			public FScriptInterface __Result;
		}

		// Token: 0x02001164 RID: 4452
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetInterface_FunctionParams
		{
			// Token: 0x0400656C RID: 25964
			[FieldOffset(0)]
			public FScriptInterface __Result;
		}
	}
}
