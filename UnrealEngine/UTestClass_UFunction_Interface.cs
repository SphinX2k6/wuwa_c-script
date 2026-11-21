using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000804 RID: 2052
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SharpherealTest.TestClass_UFunction_Interface")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UTestClass_UFunction_Interface : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B3CB RID: 46027 RVA: 0x00119A50 File Offset: 0x00117C50
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTestClass_UFunction_Interface._ClassPtr;
		}

		// Token: 0x0600B3CC RID: 46028 RVA: 0x00119A5C File Offset: 0x00117C5C
		public UTestClass_UFunction_Interface() : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_Interface.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B3CD RID: 46029 RVA: 0x00119A84 File Offset: 0x00117C84
		[NullableContext(1)]
		public UTestClass_UFunction_Interface(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTestClass_UFunction_Interface.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170021BA RID: 8634
		// (get) Token: 0x0600B3CE RID: 46030 RVA: 0x00119AB7 File Offset: 0x00117CB7
		// (set) Token: 0x0600B3CF RID: 46031 RVA: 0x00119ACB File Offset: 0x00117CCB
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

		// Token: 0x170021BB RID: 8635
		// (get) Token: 0x0600B3D0 RID: 46032 RVA: 0x00119AE0 File Offset: 0x00117CE0
		// (set) Token: 0x0600B3D1 RID: 46033 RVA: 0x00119AF4 File Offset: 0x00117CF4
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

		// Token: 0x170021BC RID: 8636
		// (get) Token: 0x0600B3D2 RID: 46034 RVA: 0x00119B09 File Offset: 0x00117D09
		// (set) Token: 0x0600B3D3 RID: 46035 RVA: 0x00119B23 File Offset: 0x00117D23
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

		// Token: 0x170021BD RID: 8637
		// (get) Token: 0x0600B3D4 RID: 46036 RVA: 0x00119B4C File Offset: 0x00117D4C
		// (set) Token: 0x0600B3D5 RID: 46037 RVA: 0x00119B85 File Offset: 0x00117D85
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

		// Token: 0x170021BE RID: 8638
		// (get) Token: 0x0600B3D6 RID: 46038 RVA: 0x00119B93 File Offset: 0x00117D93
		// (set) Token: 0x0600B3D7 RID: 46039 RVA: 0x00119BAD File Offset: 0x00117DAD
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

		// Token: 0x170021BF RID: 8639
		// (get) Token: 0x0600B3D8 RID: 46040 RVA: 0x00119BD4 File Offset: 0x00117DD4
		// (set) Token: 0x0600B3D9 RID: 46041 RVA: 0x00119C0D File Offset: 0x00117E0D
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

		// Token: 0x0600B3DA RID: 46042 RVA: 0x00119C1C File Offset: 0x00117E1C
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Interface.__SetInterfaceArray_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Interface.__SetInterfaceArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B3DB RID: 46043 RVA: 0x00119C88 File Offset: 0x00117E88
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Interface.__SetInterface2Array_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Interface.__SetInterface2Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B3DC RID: 46044 RVA: 0x00119CF4 File Offset: 0x00117EF4
		[SkipLocalsInit]
		public unsafe void SetInterface2(ISharpherealTestInterface2 InInterface2)
		{
			UTestClass_UFunction_Interface.__SetInterface2_FunctionParams* ptr = stackalloc UTestClass_UFunction_Interface.__SetInterface2_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Interface.__SetInterface2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Interface.__SetInterface2_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InInterface2 = new FScriptInterface(InInterface2, (InInterface2 != null) ? InInterface2.InterfaceOffset() : 0);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Interface.__SetInterface2_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B3DD RID: 46045 RVA: 0x00119D4C File Offset: 0x00117F4C
		[SkipLocalsInit]
		public unsafe void SetInterface(ISharpherealTestInterface InInterface)
		{
			UTestClass_UFunction_Interface.__SetInterface_FunctionParams* ptr = stackalloc UTestClass_UFunction_Interface.__SetInterface_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Interface.__SetInterface_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Interface.__SetInterface_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InInterface = new FScriptInterface(InInterface, (InInterface != null) ? InInterface.InterfaceOffset() : 0);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Interface.__SetInterface_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B3DE RID: 46046 RVA: 0x00119DA4 File Offset: 0x00117FA4
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Interface.__OutInterfaceArray_NativeFunctionPtr, (void*)ptr);
			TArray<ISharpherealTestInterface> tarray2 = OutInterfaceArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutInterfaceArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Interface.__OutInterfaceArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B3DF RID: 46047 RVA: 0x00119E1C File Offset: 0x0011801C
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Interface.__OutInterface2Array_NativeFunctionPtr, (void*)ptr);
			TArray<ISharpherealTestInterface2> tarray2 = OutInterface2Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutInterface2Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Interface.__OutInterface2Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B3E0 RID: 46048 RVA: 0x00119E94 File Offset: 0x00118094
		[SkipLocalsInit]
		public unsafe void OutInterface2(ref ISharpherealTestInterface2 OutInterface2)
		{
			UTestClass_UFunction_Interface.__OutInterface2_FunctionParams* ptr = stackalloc UTestClass_UFunction_Interface.__OutInterface2_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Interface.__OutInterface2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Interface.__OutInterface2_NativeFunctionPtr, (void*)ptr, 1);
			ref UTestClass_UFunction_Interface.__OutInterface2_FunctionParams ptr2 = ref *ptr;
			IUnrealNativeInterface @object = OutInterface2;
			ISharpherealTestInterface2 sharpherealTestInterface = OutInterface2;
			ptr2.OutInterface2 = new FScriptInterface(@object, (sharpherealTestInterface != null) ? sharpherealTestInterface.InterfaceOffset() : 0);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Interface.__OutInterface2_NativeFunctionPtr, (void*)ptr);
			OutInterface2 = (BuiltinUtils.GetOrCreateUObjectByNativePointer(ptr->OutInterface2.ObjectPointer) as ISharpherealTestInterface2);
		}

		// Token: 0x0600B3E1 RID: 46049 RVA: 0x00119F08 File Offset: 0x00118108
		[SkipLocalsInit]
		public unsafe void OutInterface(ref ISharpherealTestInterface OutInterface)
		{
			UTestClass_UFunction_Interface.__OutInterface_FunctionParams* ptr = stackalloc UTestClass_UFunction_Interface.__OutInterface_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Interface.__OutInterface_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Interface.__OutInterface_NativeFunctionPtr, (void*)ptr, 1);
			ref UTestClass_UFunction_Interface.__OutInterface_FunctionParams ptr2 = ref *ptr;
			IUnrealNativeInterface @object = OutInterface;
			ISharpherealTestInterface sharpherealTestInterface = OutInterface;
			ptr2.OutInterface = new FScriptInterface(@object, (sharpherealTestInterface != null) ? sharpherealTestInterface.InterfaceOffset() : 0);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Interface.__OutInterface_NativeFunctionPtr, (void*)ptr);
			OutInterface = (BuiltinUtils.GetOrCreateUObjectByNativePointer(ptr->OutInterface.ObjectPointer) as ISharpherealTestInterface);
		}

		// Token: 0x0600B3E2 RID: 46050 RVA: 0x00119F7C File Offset: 0x0011817C
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Interface.__InInterfaceArray_NativeFunctionPtr, (void*)ptr);
			TArray<ISharpherealTestInterface> tarray2 = InInterfaceArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InInterfaceArray);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Interface.__InInterfaceArray_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B3E3 RID: 46051 RVA: 0x00119FF4 File Offset: 0x001181F4
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Interface.__InInterface2Array_NativeFunctionPtr, (void*)ptr);
			TArray<ISharpherealTestInterface2> tarray2 = InInterface2Array;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InInterface2Array);
			}
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Interface.__InInterface2Array_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B3E4 RID: 46052 RVA: 0x0011A06C File Offset: 0x0011826C
		[SkipLocalsInit]
		public unsafe void InInterface2(in ISharpherealTestInterface2 InInterface2)
		{
			UTestClass_UFunction_Interface.__InInterface2_FunctionParams* ptr = stackalloc UTestClass_UFunction_Interface.__InInterface2_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Interface.__InInterface2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Interface.__InInterface2_NativeFunctionPtr, (void*)ptr, 1);
			ref UTestClass_UFunction_Interface.__InInterface2_FunctionParams ptr2 = ref *ptr;
			IUnrealNativeInterface @object = InInterface2;
			ISharpherealTestInterface2 sharpherealTestInterface = InInterface2;
			ptr2.InInterface2 = new FScriptInterface(@object, (sharpherealTestInterface != null) ? sharpherealTestInterface.InterfaceOffset() : 0);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Interface.__InInterface2_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B3E5 RID: 46053 RVA: 0x0011A0C8 File Offset: 0x001182C8
		[SkipLocalsInit]
		public unsafe void InInterface(in ISharpherealTestInterface InInterface)
		{
			UTestClass_UFunction_Interface.__InInterface_FunctionParams* ptr = stackalloc UTestClass_UFunction_Interface.__InInterface_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Interface.__InInterface_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Interface.__InInterface_NativeFunctionPtr, (void*)ptr, 1);
			ref UTestClass_UFunction_Interface.__InInterface_FunctionParams ptr2 = ref *ptr;
			IUnrealNativeInterface @object = InInterface;
			ISharpherealTestInterface sharpherealTestInterface = InInterface;
			ptr2.InInterface = new FScriptInterface(@object, (sharpherealTestInterface != null) ? sharpherealTestInterface.InterfaceOffset() : 0);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Interface.__InInterface_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B3E6 RID: 46054 RVA: 0x0011A124 File Offset: 0x00118324
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<ISharpherealTestInterface> GetInterfaceArray()
		{
			UTestClass_UFunction_Interface.__GetInterfaceArray_FunctionParams* ptr = stackalloc UTestClass_UFunction_Interface.__GetInterfaceArray_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Interface.__GetInterfaceArray_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Interface.__GetInterfaceArray_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Interface.__GetInterfaceArray_NativeFunctionPtr, (void*)ptr);
			TArray<ISharpherealTestInterface> result = new TArray<ISharpherealTestInterface>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Interface.__GetInterfaceArray_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B3E7 RID: 46055 RVA: 0x0011A184 File Offset: 0x00118384
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe TArray<ISharpherealTestInterface2> GetInterface2Array()
		{
			UTestClass_UFunction_Interface.__GetInterface2Array_FunctionParams* ptr = stackalloc UTestClass_UFunction_Interface.__GetInterface2Array_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Interface.__GetInterface2Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Interface.__GetInterface2Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Interface.__GetInterface2Array_NativeFunctionPtr, (void*)ptr);
			TArray<ISharpherealTestInterface2> result = new TArray<ISharpherealTestInterface2>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UTestClass_UFunction_Interface.__GetInterface2Array_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600B3E8 RID: 46056 RVA: 0x0011A1E4 File Offset: 0x001183E4
		[SkipLocalsInit]
		public unsafe ISharpherealTestInterface2 GetInterface2()
		{
			UTestClass_UFunction_Interface.__GetInterface2_FunctionParams* ptr = stackalloc UTestClass_UFunction_Interface.__GetInterface2_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Interface.__GetInterface2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Interface.__GetInterface2_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Interface.__GetInterface2_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer(ptr->__Result.ObjectPointer) as ISharpherealTestInterface2;
		}

		// Token: 0x0600B3E9 RID: 46057 RVA: 0x0011A238 File Offset: 0x00118438
		[SkipLocalsInit]
		public unsafe ISharpherealTestInterface GetInterface()
		{
			UTestClass_UFunction_Interface.__GetInterface_FunctionParams* ptr = stackalloc UTestClass_UFunction_Interface.__GetInterface_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTestClass_UFunction_Interface.__GetInterface_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTestClass_UFunction_Interface.__GetInterface_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UTestClass_UFunction_Interface.__GetInterface_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer(ptr->__Result.ObjectPointer) as ISharpherealTestInterface;
		}

		// Token: 0x0600B3EA RID: 46058 RVA: 0x0011A28C File Offset: 0x0011848C
		static UTestClass_UFunction_Interface()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SharpherealTest.TestClass_UFunction_Interface");
		}

		// Token: 0x0600B3EB RID: 46059 RVA: 0x0011A29A File Offset: 0x0011849A
		protected UTestClass_UFunction_Interface(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005066 RID: 20582
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SharpherealTest.TestClass_UFunction_Interface";

		// Token: 0x04005067 RID: 20583
		private static IntPtr _ClassPtr;

		// Token: 0x04005068 RID: 20584
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005069 RID: 20585
		internal static int __PropertyOffset_Object;

		// Token: 0x0400506A RID: 20586
		internal static int __PropertyOffset_ObjectCmp;

		// Token: 0x0400506B RID: 20587
		internal static int __PropertyOffset_Interface;

		// Token: 0x0400506C RID: 20588
		internal static int __PropertyOffset_InterfaceArray;

		// Token: 0x0400506D RID: 20589
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ISharpherealTestInterface> _InterfaceArray;

		// Token: 0x0400506E RID: 20590
		internal static int __PropertyOffset_Interface2;

		// Token: 0x0400506F RID: 20591
		internal static int __PropertyOffset_Interface2Array;

		// Token: 0x04005070 RID: 20592
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ISharpherealTestInterface2> _Interface2Array;

		// Token: 0x04005071 RID: 20593
		private static IntPtr __SetInterfaceArray_NativeFunctionPtr;

		// Token: 0x04005072 RID: 20594
		private static IntPtr __SetInterface2Array_NativeFunctionPtr;

		// Token: 0x04005073 RID: 20595
		private static IntPtr __SetInterface2_NativeFunctionPtr;

		// Token: 0x04005074 RID: 20596
		private static IntPtr __SetInterface_NativeFunctionPtr;

		// Token: 0x04005075 RID: 20597
		private static IntPtr __OutInterfaceArray_NativeFunctionPtr;

		// Token: 0x04005076 RID: 20598
		private static IntPtr __OutInterface2Array_NativeFunctionPtr;

		// Token: 0x04005077 RID: 20599
		private static IntPtr __OutInterface2_NativeFunctionPtr;

		// Token: 0x04005078 RID: 20600
		private static IntPtr __OutInterface_NativeFunctionPtr;

		// Token: 0x04005079 RID: 20601
		private static IntPtr __InInterfaceArray_NativeFunctionPtr;

		// Token: 0x0400507A RID: 20602
		private static IntPtr __InInterface2Array_NativeFunctionPtr;

		// Token: 0x0400507B RID: 20603
		private static IntPtr __InInterface2_NativeFunctionPtr;

		// Token: 0x0400507C RID: 20604
		private static IntPtr __InInterface_NativeFunctionPtr;

		// Token: 0x0400507D RID: 20605
		private static IntPtr __GetInterfaceArray_NativeFunctionPtr;

		// Token: 0x0400507E RID: 20606
		private static IntPtr __GetInterface2Array_NativeFunctionPtr;

		// Token: 0x0400507F RID: 20607
		private static IntPtr __GetInterface2_NativeFunctionPtr;

		// Token: 0x04005080 RID: 20608
		private static IntPtr __GetInterface_NativeFunctionPtr;

		// Token: 0x0200125F RID: 4703
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetInterfaceArray_FunctionParams
		{
			// Token: 0x04006669 RID: 26217
			[FieldOffset(0)]
			public byte InInterfaceArray;
		}

		// Token: 0x02001260 RID: 4704
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetInterface2Array_FunctionParams
		{
			// Token: 0x0400666A RID: 26218
			[FieldOffset(0)]
			public byte InInterface2Array;
		}

		// Token: 0x02001261 RID: 4705
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetInterface2_FunctionParams
		{
			// Token: 0x0400666B RID: 26219
			[FieldOffset(0)]
			public FScriptInterface InInterface2;
		}

		// Token: 0x02001262 RID: 4706
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetInterface_FunctionParams
		{
			// Token: 0x0400666C RID: 26220
			[FieldOffset(0)]
			public FScriptInterface InInterface;
		}

		// Token: 0x02001263 RID: 4707
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutInterfaceArray_FunctionParams
		{
			// Token: 0x0400666D RID: 26221
			[FieldOffset(0)]
			public byte OutInterfaceArray;
		}

		// Token: 0x02001264 RID: 4708
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutInterface2Array_FunctionParams
		{
			// Token: 0x0400666E RID: 26222
			[FieldOffset(0)]
			public byte OutInterface2Array;
		}

		// Token: 0x02001265 RID: 4709
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutInterface2_FunctionParams
		{
			// Token: 0x0400666F RID: 26223
			[FieldOffset(0)]
			public FScriptInterface OutInterface2;
		}

		// Token: 0x02001266 RID: 4710
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OutInterface_FunctionParams
		{
			// Token: 0x04006670 RID: 26224
			[FieldOffset(0)]
			public FScriptInterface OutInterface;
		}

		// Token: 0x02001267 RID: 4711
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InInterfaceArray_FunctionParams
		{
			// Token: 0x04006671 RID: 26225
			[FieldOffset(0)]
			public byte InInterfaceArray;
		}

		// Token: 0x02001268 RID: 4712
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InInterface2Array_FunctionParams
		{
			// Token: 0x04006672 RID: 26226
			[FieldOffset(0)]
			public byte InInterface2Array;
		}

		// Token: 0x02001269 RID: 4713
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InInterface2_FunctionParams
		{
			// Token: 0x04006673 RID: 26227
			[FieldOffset(0)]
			public FScriptInterface InInterface2;
		}

		// Token: 0x0200126A RID: 4714
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __InInterface_FunctionParams
		{
			// Token: 0x04006674 RID: 26228
			[FieldOffset(0)]
			public FScriptInterface InInterface;
		}

		// Token: 0x0200126B RID: 4715
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetInterfaceArray_FunctionParams
		{
			// Token: 0x04006675 RID: 26229
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200126C RID: 4716
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetInterface2Array_FunctionParams
		{
			// Token: 0x04006676 RID: 26230
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200126D RID: 4717
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetInterface2_FunctionParams
		{
			// Token: 0x04006677 RID: 26231
			[FieldOffset(0)]
			public FScriptInterface __Result;
		}

		// Token: 0x0200126E RID: 4718
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetInterface_FunctionParams
		{
			// Token: 0x04006678 RID: 26232
			[FieldOffset(0)]
			public FScriptInterface __Result;
		}
	}
}
