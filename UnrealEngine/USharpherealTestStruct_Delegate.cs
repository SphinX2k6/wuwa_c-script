using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200273E RID: 10046
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SharpherealTest.SharpherealTestStruct_Delegate")]
	[UnrealStructLayout(480, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 480)]
	public class USharpherealTestStruct_Delegate : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025360 RID: 152416 RVA: 0x00372735 File Offset: 0x00370935
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USharpherealTestStruct_Delegate._ClassPtr;
		}

		// Token: 0x06025361 RID: 152417 RVA: 0x00372744 File Offset: 0x00370944
		public USharpherealTestStruct_Delegate() : this(BuiltinUtils.AllocNativeUObject(USharpherealTestStruct_Delegate.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025362 RID: 152418 RVA: 0x0037276C File Offset: 0x0037096C
		public USharpherealTestStruct_Delegate(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USharpherealTestStruct_Delegate.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008FA5 RID: 36773
		// (get) Token: 0x06025363 RID: 152419 RVA: 0x0037279F File Offset: 0x0037099F
		// (set) Token: 0x06025364 RID: 152420 RVA: 0x003727AF File Offset: 0x003709AF
		public unsafe int Key
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USharpherealTestStruct_Delegate.__PropertyOffset_Key);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USharpherealTestStruct_Delegate.__PropertyOffset_Key) = value;
			}
		}

		// Token: 0x17008FA6 RID: 36774
		// (get) Token: 0x06025365 RID: 152421 RVA: 0x003727C0 File Offset: 0x003709C0
		// (set) Token: 0x06025366 RID: 152422 RVA: 0x003727F9 File Offset: 0x003709F9
		public FSharpherealTestDynDelegate0 Dyn0
		{
			get
			{
				base.FastCheckIsValid();
				FSharpherealTestDynDelegate0 result;
				if ((result = this._Dyn0) == null)
				{
					result = (this._Dyn0 = new FSharpherealTestDynDelegate0(base.NativePtr + (IntPtr)USharpherealTestStruct_Delegate.__PropertyOffset_Dyn0, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USharpherealTestStruct_Delegate.__PropertyOffset_Dyn0, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17008FA7 RID: 36775
		// (get) Token: 0x06025367 RID: 152423 RVA: 0x0037281C File Offset: 0x00370A1C
		// (set) Token: 0x06025368 RID: 152424 RVA: 0x00372855 File Offset: 0x00370A55
		public TArray<FSharpherealTestDynDelegate0> Dyn0Array
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSharpherealTestDynDelegate0> result;
				if ((result = this._Dyn0Array) == null)
				{
					result = (this._Dyn0Array = new TArray<FSharpherealTestDynDelegate0>(base.NativePtr + (IntPtr)USharpherealTestStruct_Delegate.__PropertyOffset_Dyn0Array, this));
				}
				return result;
			}
			set
			{
				this.Dyn0Array.CopyAssign(value);
			}
		}

		// Token: 0x17008FA8 RID: 36776
		// (get) Token: 0x06025369 RID: 152425 RVA: 0x00372864 File Offset: 0x00370A64
		// (set) Token: 0x0602536A RID: 152426 RVA: 0x0037289D File Offset: 0x00370A9D
		public FSharpherealTestDynDelegate1 Dyn1
		{
			get
			{
				base.FastCheckIsValid();
				FSharpherealTestDynDelegate1 result;
				if ((result = this._Dyn1) == null)
				{
					result = (this._Dyn1 = new FSharpherealTestDynDelegate1(base.NativePtr + (IntPtr)USharpherealTestStruct_Delegate.__PropertyOffset_Dyn1, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USharpherealTestStruct_Delegate.__PropertyOffset_Dyn1, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17008FA9 RID: 36777
		// (get) Token: 0x0602536B RID: 152427 RVA: 0x003728C0 File Offset: 0x00370AC0
		// (set) Token: 0x0602536C RID: 152428 RVA: 0x003728F9 File Offset: 0x00370AF9
		public TArray<FSharpherealTestDynDelegate1> Dyn1Array
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSharpherealTestDynDelegate1> result;
				if ((result = this._Dyn1Array) == null)
				{
					result = (this._Dyn1Array = new TArray<FSharpherealTestDynDelegate1>(base.NativePtr + (IntPtr)USharpherealTestStruct_Delegate.__PropertyOffset_Dyn1Array, this));
				}
				return result;
			}
			set
			{
				this.Dyn1Array.CopyAssign(value);
			}
		}

		// Token: 0x17008FAA RID: 36778
		// (get) Token: 0x0602536D RID: 152429 RVA: 0x00372908 File Offset: 0x00370B08
		// (set) Token: 0x0602536E RID: 152430 RVA: 0x00372941 File Offset: 0x00370B41
		public FSharpherealTestDynMultiDelegate0 DynMulti0
		{
			get
			{
				base.FastCheckIsValid();
				FSharpherealTestDynMultiDelegate0 result;
				if ((result = this._DynMulti0) == null)
				{
					result = (this._DynMulti0 = new FSharpherealTestDynMultiDelegate0(base.NativePtr + (IntPtr)USharpherealTestStruct_Delegate.__PropertyOffset_DynMulti0, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USharpherealTestStruct_Delegate.__PropertyOffset_DynMulti0, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17008FAB RID: 36779
		// (get) Token: 0x0602536F RID: 152431 RVA: 0x00372964 File Offset: 0x00370B64
		// (set) Token: 0x06025370 RID: 152432 RVA: 0x0037299D File Offset: 0x00370B9D
		public TArray<FSharpherealTestDynMultiDelegate0> DynMulti0Array
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSharpherealTestDynMultiDelegate0> result;
				if ((result = this._DynMulti0Array) == null)
				{
					result = (this._DynMulti0Array = new TArray<FSharpherealTestDynMultiDelegate0>(base.NativePtr + (IntPtr)USharpherealTestStruct_Delegate.__PropertyOffset_DynMulti0Array, this));
				}
				return result;
			}
			set
			{
				this.DynMulti0Array.CopyAssign(value);
			}
		}

		// Token: 0x17008FAC RID: 36780
		// (get) Token: 0x06025371 RID: 152433 RVA: 0x003729AC File Offset: 0x00370BAC
		// (set) Token: 0x06025372 RID: 152434 RVA: 0x003729E5 File Offset: 0x00370BE5
		public FSharpherealTestDynMultiDelegate1 DynMulti1
		{
			get
			{
				base.FastCheckIsValid();
				FSharpherealTestDynMultiDelegate1 result;
				if ((result = this._DynMulti1) == null)
				{
					result = (this._DynMulti1 = new FSharpherealTestDynMultiDelegate1(base.NativePtr + (IntPtr)USharpherealTestStruct_Delegate.__PropertyOffset_DynMulti1, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USharpherealTestStruct_Delegate.__PropertyOffset_DynMulti1, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17008FAD RID: 36781
		// (get) Token: 0x06025373 RID: 152435 RVA: 0x00372A08 File Offset: 0x00370C08
		// (set) Token: 0x06025374 RID: 152436 RVA: 0x00372A41 File Offset: 0x00370C41
		public TArray<FSharpherealTestDynMultiDelegate1> DynMulti1Array
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSharpherealTestDynMultiDelegate1> result;
				if ((result = this._DynMulti1Array) == null)
				{
					result = (this._DynMulti1Array = new TArray<FSharpherealTestDynMultiDelegate1>(base.NativePtr + (IntPtr)USharpherealTestStruct_Delegate.__PropertyOffset_DynMulti1Array, this));
				}
				return result;
			}
			set
			{
				this.DynMulti1Array.CopyAssign(value);
			}
		}

		// Token: 0x17008FAE RID: 36782
		// (get) Token: 0x06025375 RID: 152437 RVA: 0x00372A50 File Offset: 0x00370C50
		// (set) Token: 0x06025376 RID: 152438 RVA: 0x00372A89 File Offset: 0x00370C89
		public FSharpherealTestSparseMultiDelegate1 SparseMulti1
		{
			get
			{
				base.FastCheckIsValid();
				FSharpherealTestSparseMultiDelegate1 result;
				if ((result = this._SparseMulti1) == null)
				{
					result = (this._SparseMulti1 = new FSharpherealTestSparseMultiDelegate1(base.NativePtr + (IntPtr)USharpherealTestStruct_Delegate.__PropertyOffset_SparseMulti1, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USharpherealTestStruct_Delegate.__PropertyOffset_SparseMulti1, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17008FAF RID: 36783
		// (get) Token: 0x06025377 RID: 152439 RVA: 0x00372AAC File Offset: 0x00370CAC
		// (set) Token: 0x06025378 RID: 152440 RVA: 0x00372AE5 File Offset: 0x00370CE5
		public TArray<FSharpherealTestSparseMultiDelegate1> SparseMulti1Array
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSharpherealTestSparseMultiDelegate1> result;
				if ((result = this._SparseMulti1Array) == null)
				{
					result = (this._SparseMulti1Array = new TArray<FSharpherealTestSparseMultiDelegate1>(base.NativePtr + (IntPtr)USharpherealTestStruct_Delegate.__PropertyOffset_SparseMulti1Array, this));
				}
				return result;
			}
			set
			{
				this.SparseMulti1Array.CopyAssign(value);
			}
		}

		// Token: 0x17008FB0 RID: 36784
		// (get) Token: 0x06025379 RID: 152441 RVA: 0x00372AF4 File Offset: 0x00370CF4
		// (set) Token: 0x0602537A RID: 152442 RVA: 0x00372B2D File Offset: 0x00370D2D
		public FSharpherealTestDynDelegate_FQuat DynDelegate_FQuat
		{
			get
			{
				base.FastCheckIsValid();
				FSharpherealTestDynDelegate_FQuat result;
				if ((result = this._DynDelegate_FQuat) == null)
				{
					result = (this._DynDelegate_FQuat = new FSharpherealTestDynDelegate_FQuat(base.NativePtr + (IntPtr)USharpherealTestStruct_Delegate.__PropertyOffset_DynDelegate_FQuat, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USharpherealTestStruct_Delegate.__PropertyOffset_DynDelegate_FQuat, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17008FB1 RID: 36785
		// (get) Token: 0x0602537B RID: 152443 RVA: 0x00372B50 File Offset: 0x00370D50
		// (set) Token: 0x0602537C RID: 152444 RVA: 0x00372B89 File Offset: 0x00370D89
		public FSharpherealTestDynDelegate_FTransform DynDelegate_FTransform
		{
			get
			{
				base.FastCheckIsValid();
				FSharpherealTestDynDelegate_FTransform result;
				if ((result = this._DynDelegate_FTransform) == null)
				{
					result = (this._DynDelegate_FTransform = new FSharpherealTestDynDelegate_FTransform(base.NativePtr + (IntPtr)USharpherealTestStruct_Delegate.__PropertyOffset_DynDelegate_FTransform, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USharpherealTestStruct_Delegate.__PropertyOffset_DynDelegate_FTransform, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0602537D RID: 152445 RVA: 0x00372BAA File Offset: 0x00370DAA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void IncKey()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USharpherealTestStruct_Delegate.__IncKey_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602537E RID: 152446 RVA: 0x00372BC0 File Offset: 0x00370DC0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetKey()
		{
			USharpherealTestStruct_Delegate.__GetKey_FunctionParams* ptr = stackalloc USharpherealTestStruct_Delegate.__GetKey_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USharpherealTestStruct_Delegate.__GetKey_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USharpherealTestStruct_Delegate.__GetKey_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USharpherealTestStruct_Delegate.__GetKey_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0602537F RID: 152447 RVA: 0x00372C08 File Offset: 0x00370E08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void ExecuteDynMulti1Array(int Val)
		{
			USharpherealTestStruct_Delegate.__ExecuteDynMulti1Array_FunctionParams* ptr = stackalloc USharpherealTestStruct_Delegate.__ExecuteDynMulti1Array_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USharpherealTestStruct_Delegate.__ExecuteDynMulti1Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USharpherealTestStruct_Delegate.__ExecuteDynMulti1Array_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Val = Val;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USharpherealTestStruct_Delegate.__ExecuteDynMulti1Array_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025380 RID: 152448 RVA: 0x00372C4F File Offset: 0x00370E4F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void ExecuteDynMulti0Array()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USharpherealTestStruct_Delegate.__ExecuteDynMulti0Array_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025381 RID: 152449 RVA: 0x00372C64 File Offset: 0x00370E64
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void ExecuteDyn1Array(int Val)
		{
			USharpherealTestStruct_Delegate.__ExecuteDyn1Array_FunctionParams* ptr = stackalloc USharpherealTestStruct_Delegate.__ExecuteDyn1Array_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USharpherealTestStruct_Delegate.__ExecuteDyn1Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USharpherealTestStruct_Delegate.__ExecuteDyn1Array_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Val = Val;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USharpherealTestStruct_Delegate.__ExecuteDyn1Array_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025382 RID: 152450 RVA: 0x00372CAC File Offset: 0x00370EAC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int ExecuteDyn0Array()
		{
			USharpherealTestStruct_Delegate.__ExecuteDyn0Array_FunctionParams* ptr = stackalloc USharpherealTestStruct_Delegate.__ExecuteDyn0Array_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USharpherealTestStruct_Delegate.__ExecuteDyn0Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USharpherealTestStruct_Delegate.__ExecuteDyn0Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USharpherealTestStruct_Delegate.__ExecuteDyn0Array_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06025383 RID: 152451 RVA: 0x00372CF4 File Offset: 0x00370EF4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void CopyMultiDelegate(in FSharpherealTestDynMultiDelegate1 NewDyn1)
		{
			USharpherealTestStruct_Delegate.__CopyMultiDelegate_FunctionParams* ptr = stackalloc USharpherealTestStruct_Delegate.__CopyMultiDelegate_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USharpherealTestStruct_Delegate.__CopyMultiDelegate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USharpherealTestStruct_Delegate.__CopyMultiDelegate_NativeFunctionPtr, (void*)ptr, 1);
			IntPtr dest = &ptr->NewDyn1;
			FSharpherealTestDynMultiDelegate1 fsharpherealTestDynMultiDelegate = NewDyn1;
			FMulticastScriptDelegate.NativeMove(dest, (fsharpherealTestDynMultiDelegate != null) ? fsharpherealTestDynMultiDelegate.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USharpherealTestStruct_Delegate.__CopyMultiDelegate_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(USharpherealTestStruct_Delegate.__CopyMultiDelegate_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025384 RID: 152452 RVA: 0x00372D60 File Offset: 0x00370F60
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void CopyDelegate(in FSharpherealTestDynDelegate0 NewDyn0)
		{
			USharpherealTestStruct_Delegate.__CopyDelegate_FunctionParams* ptr = stackalloc USharpherealTestStruct_Delegate.__CopyDelegate_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(USharpherealTestStruct_Delegate.__CopyDelegate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USharpherealTestStruct_Delegate.__CopyDelegate_NativeFunctionPtr, (void*)ptr, 1);
			IntPtr dest = &ptr->NewDyn0;
			FSharpherealTestDynDelegate0 fsharpherealTestDynDelegate = NewDyn0;
			FScriptDelegate.NativeCopy(dest, (fsharpherealTestDynDelegate != null) ? fsharpherealTestDynDelegate.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USharpherealTestStruct_Delegate.__CopyDelegate_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(USharpherealTestStruct_Delegate.__CopyDelegate_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025385 RID: 152453 RVA: 0x00372DCC File Offset: 0x00370FCC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void AddKey(int Val)
		{
			USharpherealTestStruct_Delegate.__AddKey_FunctionParams* ptr = stackalloc USharpherealTestStruct_Delegate.__AddKey_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USharpherealTestStruct_Delegate.__AddKey_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USharpherealTestStruct_Delegate.__AddKey_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Val = Val;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USharpherealTestStruct_Delegate.__AddKey_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025386 RID: 152454 RVA: 0x00372E14 File Offset: 0x00371014
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FTransform AddFTransform(in FTransform A, in FTransform B)
		{
			USharpherealTestStruct_Delegate.__AddFTransform_FunctionParams* ptr = stackalloc USharpherealTestStruct_Delegate.__AddFTransform_FunctionParams[(UIntPtr)159] + 15L / (long)sizeof(USharpherealTestStruct_Delegate.__AddFTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USharpherealTestStruct_Delegate.__AddFTransform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->A = A;
			ptr->B = B;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USharpherealTestStruct_Delegate.__AddFTransform_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06025387 RID: 152455 RVA: 0x00372E78 File Offset: 0x00371078
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FQuat AddFQuat(in FQuat A, in FQuat B)
		{
			USharpherealTestStruct_Delegate.__AddFQuat_FunctionParams* ptr = stackalloc USharpherealTestStruct_Delegate.__AddFQuat_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(USharpherealTestStruct_Delegate.__AddFQuat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USharpherealTestStruct_Delegate.__AddFQuat_NativeFunctionPtr, (void*)ptr, 1);
			ptr->A = A;
			ptr->B = B;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USharpherealTestStruct_Delegate.__AddFQuat_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06025388 RID: 152456 RVA: 0x00372ED6 File Offset: 0x003710D6
		static USharpherealTestStruct_Delegate()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SharpherealTest.SharpherealTestStruct_Delegate");
		}

		// Token: 0x06025389 RID: 152457 RVA: 0x00372EE4 File Offset: 0x003710E4
		protected USharpherealTestStruct_Delegate(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014104 RID: 82180
		public new const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestStruct_Delegate";

		// Token: 0x04014105 RID: 82181
		private static IntPtr _ClassPtr;

		// Token: 0x04014106 RID: 82182
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014107 RID: 82183
		internal static int __PropertyOffset_Key;

		// Token: 0x04014108 RID: 82184
		internal static int __PropertyOffset_Dyn0;

		// Token: 0x04014109 RID: 82185
		[Nullable(2)]
		private FSharpherealTestDynDelegate0 _Dyn0;

		// Token: 0x0401410A RID: 82186
		internal static int __PropertyOffset_Dyn0Array;

		// Token: 0x0401410B RID: 82187
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSharpherealTestDynDelegate0> _Dyn0Array;

		// Token: 0x0401410C RID: 82188
		internal static int __PropertyOffset_Dyn1;

		// Token: 0x0401410D RID: 82189
		[Nullable(2)]
		private FSharpherealTestDynDelegate1 _Dyn1;

		// Token: 0x0401410E RID: 82190
		internal static int __PropertyOffset_Dyn1Array;

		// Token: 0x0401410F RID: 82191
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSharpherealTestDynDelegate1> _Dyn1Array;

		// Token: 0x04014110 RID: 82192
		internal static int __PropertyOffset_DynMulti0;

		// Token: 0x04014111 RID: 82193
		[Nullable(2)]
		private FSharpherealTestDynMultiDelegate0 _DynMulti0;

		// Token: 0x04014112 RID: 82194
		internal static int __PropertyOffset_DynMulti0Array;

		// Token: 0x04014113 RID: 82195
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSharpherealTestDynMultiDelegate0> _DynMulti0Array;

		// Token: 0x04014114 RID: 82196
		internal static int __PropertyOffset_DynMulti1;

		// Token: 0x04014115 RID: 82197
		[Nullable(2)]
		private FSharpherealTestDynMultiDelegate1 _DynMulti1;

		// Token: 0x04014116 RID: 82198
		internal static int __PropertyOffset_DynMulti1Array;

		// Token: 0x04014117 RID: 82199
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSharpherealTestDynMultiDelegate1> _DynMulti1Array;

		// Token: 0x04014118 RID: 82200
		internal static int __PropertyOffset_SparseMulti1;

		// Token: 0x04014119 RID: 82201
		[Nullable(2)]
		private FSharpherealTestSparseMultiDelegate1 _SparseMulti1;

		// Token: 0x0401411A RID: 82202
		internal static int __PropertyOffset_SparseMulti1Array;

		// Token: 0x0401411B RID: 82203
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSharpherealTestSparseMultiDelegate1> _SparseMulti1Array;

		// Token: 0x0401411C RID: 82204
		internal static int __PropertyOffset_DynDelegate_FQuat;

		// Token: 0x0401411D RID: 82205
		[Nullable(2)]
		private FSharpherealTestDynDelegate_FQuat _DynDelegate_FQuat;

		// Token: 0x0401411E RID: 82206
		internal static int __PropertyOffset_DynDelegate_FTransform;

		// Token: 0x0401411F RID: 82207
		[Nullable(2)]
		private FSharpherealTestDynDelegate_FTransform _DynDelegate_FTransform;

		// Token: 0x04014120 RID: 82208
		private static IntPtr __IncKey_NativeFunctionPtr;

		// Token: 0x04014121 RID: 82209
		private static IntPtr __GetKey_NativeFunctionPtr;

		// Token: 0x04014122 RID: 82210
		private static IntPtr __ExecuteDynMulti1Array_NativeFunctionPtr;

		// Token: 0x04014123 RID: 82211
		private static IntPtr __ExecuteDynMulti0Array_NativeFunctionPtr;

		// Token: 0x04014124 RID: 82212
		private static IntPtr __ExecuteDyn1Array_NativeFunctionPtr;

		// Token: 0x04014125 RID: 82213
		private static IntPtr __ExecuteDyn0Array_NativeFunctionPtr;

		// Token: 0x04014126 RID: 82214
		private static IntPtr __CopyMultiDelegate_NativeFunctionPtr;

		// Token: 0x04014127 RID: 82215
		private static IntPtr __CopyDelegate_NativeFunctionPtr;

		// Token: 0x04014128 RID: 82216
		private static IntPtr __AddKey_NativeFunctionPtr;

		// Token: 0x04014129 RID: 82217
		private static IntPtr __AddFTransform_NativeFunctionPtr;

		// Token: 0x0401412A RID: 82218
		private static IntPtr __AddFQuat_NativeFunctionPtr;

		// Token: 0x020036CA RID: 14026
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetKey_FunctionParams
		{
			// Token: 0x040177ED RID: 96237
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020036CB RID: 14027
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ExecuteDynMulti1Array_FunctionParams
		{
			// Token: 0x040177EE RID: 96238
			[FieldOffset(0)]
			public int Val;
		}

		// Token: 0x020036CC RID: 14028
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ExecuteDyn1Array_FunctionParams
		{
			// Token: 0x040177EF RID: 96239
			[FieldOffset(0)]
			public int Val;
		}

		// Token: 0x020036CD RID: 14029
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ExecuteDyn0Array_FunctionParams
		{
			// Token: 0x040177F0 RID: 96240
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020036CE RID: 14030
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __CopyMultiDelegate_FunctionParams
		{
			// Token: 0x040177F1 RID: 96241
			[FieldOffset(0)]
			public byte NewDyn1;
		}

		// Token: 0x020036CF RID: 14031
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __CopyDelegate_FunctionParams
		{
			// Token: 0x040177F2 RID: 96242
			[FieldOffset(0)]
			public byte NewDyn0;
		}

		// Token: 0x020036D0 RID: 14032
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __AddKey_FunctionParams
		{
			// Token: 0x040177F3 RID: 96243
			[FieldOffset(0)]
			public int Val;
		}

		// Token: 0x020036D1 RID: 14033
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 144)]
		protected ref struct __AddFTransform_FunctionParams
		{
			// Token: 0x040177F4 RID: 96244
			[FieldOffset(0)]
			public FTransform A;

			// Token: 0x040177F5 RID: 96245
			[FieldOffset(48)]
			public FTransform B;

			// Token: 0x040177F6 RID: 96246
			[FieldOffset(96)]
			public FTransform __Result;
		}

		// Token: 0x020036D2 RID: 14034
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __AddFQuat_FunctionParams
		{
			// Token: 0x040177F7 RID: 96247
			[FieldOffset(0)]
			public FQuat A;

			// Token: 0x040177F8 RID: 96248
			[FieldOffset(16)]
			public FQuat B;

			// Token: 0x040177F9 RID: 96249
			[FieldOffset(32)]
			public FQuat __Result;
		}
	}
}
