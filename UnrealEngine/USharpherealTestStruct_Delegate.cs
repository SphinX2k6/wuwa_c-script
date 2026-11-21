using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007F2 RID: 2034
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SharpherealTest.SharpherealTestStruct_Delegate")]
	[UnrealStructLayout(480, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 480)]
	public class USharpherealTestStruct_Delegate : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600AE44 RID: 44612 RVA: 0x00102471 File Offset: 0x00100671
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USharpherealTestStruct_Delegate._ClassPtr;
		}

		// Token: 0x0600AE45 RID: 44613 RVA: 0x00102480 File Offset: 0x00100680
		public USharpherealTestStruct_Delegate() : this(BuiltinUtils.AllocNativeUObject(USharpherealTestStruct_Delegate.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600AE46 RID: 44614 RVA: 0x001024A8 File Offset: 0x001006A8
		public USharpherealTestStruct_Delegate(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USharpherealTestStruct_Delegate.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700208D RID: 8333
		// (get) Token: 0x0600AE47 RID: 44615 RVA: 0x001024DB File Offset: 0x001006DB
		// (set) Token: 0x0600AE48 RID: 44616 RVA: 0x001024EB File Offset: 0x001006EB
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

		// Token: 0x1700208E RID: 8334
		// (get) Token: 0x0600AE49 RID: 44617 RVA: 0x001024FC File Offset: 0x001006FC
		// (set) Token: 0x0600AE4A RID: 44618 RVA: 0x00102535 File Offset: 0x00100735
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

		// Token: 0x1700208F RID: 8335
		// (get) Token: 0x0600AE4B RID: 44619 RVA: 0x00102558 File Offset: 0x00100758
		// (set) Token: 0x0600AE4C RID: 44620 RVA: 0x00102591 File Offset: 0x00100791
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

		// Token: 0x17002090 RID: 8336
		// (get) Token: 0x0600AE4D RID: 44621 RVA: 0x001025A0 File Offset: 0x001007A0
		// (set) Token: 0x0600AE4E RID: 44622 RVA: 0x001025D9 File Offset: 0x001007D9
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

		// Token: 0x17002091 RID: 8337
		// (get) Token: 0x0600AE4F RID: 44623 RVA: 0x001025FC File Offset: 0x001007FC
		// (set) Token: 0x0600AE50 RID: 44624 RVA: 0x00102635 File Offset: 0x00100835
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

		// Token: 0x17002092 RID: 8338
		// (get) Token: 0x0600AE51 RID: 44625 RVA: 0x00102644 File Offset: 0x00100844
		// (set) Token: 0x0600AE52 RID: 44626 RVA: 0x0010267D File Offset: 0x0010087D
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

		// Token: 0x17002093 RID: 8339
		// (get) Token: 0x0600AE53 RID: 44627 RVA: 0x001026A0 File Offset: 0x001008A0
		// (set) Token: 0x0600AE54 RID: 44628 RVA: 0x001026D9 File Offset: 0x001008D9
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

		// Token: 0x17002094 RID: 8340
		// (get) Token: 0x0600AE55 RID: 44629 RVA: 0x001026E8 File Offset: 0x001008E8
		// (set) Token: 0x0600AE56 RID: 44630 RVA: 0x00102721 File Offset: 0x00100921
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

		// Token: 0x17002095 RID: 8341
		// (get) Token: 0x0600AE57 RID: 44631 RVA: 0x00102744 File Offset: 0x00100944
		// (set) Token: 0x0600AE58 RID: 44632 RVA: 0x0010277D File Offset: 0x0010097D
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

		// Token: 0x17002096 RID: 8342
		// (get) Token: 0x0600AE59 RID: 44633 RVA: 0x0010278C File Offset: 0x0010098C
		// (set) Token: 0x0600AE5A RID: 44634 RVA: 0x001027C5 File Offset: 0x001009C5
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

		// Token: 0x17002097 RID: 8343
		// (get) Token: 0x0600AE5B RID: 44635 RVA: 0x001027E8 File Offset: 0x001009E8
		// (set) Token: 0x0600AE5C RID: 44636 RVA: 0x00102821 File Offset: 0x00100A21
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

		// Token: 0x17002098 RID: 8344
		// (get) Token: 0x0600AE5D RID: 44637 RVA: 0x00102830 File Offset: 0x00100A30
		// (set) Token: 0x0600AE5E RID: 44638 RVA: 0x00102869 File Offset: 0x00100A69
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

		// Token: 0x17002099 RID: 8345
		// (get) Token: 0x0600AE5F RID: 44639 RVA: 0x0010288C File Offset: 0x00100A8C
		// (set) Token: 0x0600AE60 RID: 44640 RVA: 0x001028C5 File Offset: 0x00100AC5
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

		// Token: 0x0600AE61 RID: 44641 RVA: 0x001028E6 File Offset: 0x00100AE6
		[SkipLocalsInit]
		public void IncKey()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USharpherealTestStruct_Delegate.__IncKey_NativeFunctionPtr, null);
		}

		// Token: 0x0600AE62 RID: 44642 RVA: 0x001028FC File Offset: 0x00100AFC
		[SkipLocalsInit]
		public unsafe int GetKey()
		{
			USharpherealTestStruct_Delegate.__GetKey_FunctionParams* ptr = stackalloc USharpherealTestStruct_Delegate.__GetKey_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USharpherealTestStruct_Delegate.__GetKey_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USharpherealTestStruct_Delegate.__GetKey_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USharpherealTestStruct_Delegate.__GetKey_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600AE63 RID: 44643 RVA: 0x00102944 File Offset: 0x00100B44
		[SkipLocalsInit]
		public unsafe void ExecuteDynMulti1Array(int Val)
		{
			USharpherealTestStruct_Delegate.__ExecuteDynMulti1Array_FunctionParams* ptr = stackalloc USharpherealTestStruct_Delegate.__ExecuteDynMulti1Array_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USharpherealTestStruct_Delegate.__ExecuteDynMulti1Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USharpherealTestStruct_Delegate.__ExecuteDynMulti1Array_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Val = Val;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USharpherealTestStruct_Delegate.__ExecuteDynMulti1Array_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600AE64 RID: 44644 RVA: 0x0010298A File Offset: 0x00100B8A
		[SkipLocalsInit]
		public void ExecuteDynMulti0Array()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USharpherealTestStruct_Delegate.__ExecuteDynMulti0Array_NativeFunctionPtr, null);
		}

		// Token: 0x0600AE65 RID: 44645 RVA: 0x001029A0 File Offset: 0x00100BA0
		[SkipLocalsInit]
		public unsafe void ExecuteDyn1Array(int Val)
		{
			USharpherealTestStruct_Delegate.__ExecuteDyn1Array_FunctionParams* ptr = stackalloc USharpherealTestStruct_Delegate.__ExecuteDyn1Array_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USharpherealTestStruct_Delegate.__ExecuteDyn1Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USharpherealTestStruct_Delegate.__ExecuteDyn1Array_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Val = Val;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USharpherealTestStruct_Delegate.__ExecuteDyn1Array_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600AE66 RID: 44646 RVA: 0x001029E8 File Offset: 0x00100BE8
		[SkipLocalsInit]
		public unsafe int ExecuteDyn0Array()
		{
			USharpherealTestStruct_Delegate.__ExecuteDyn0Array_FunctionParams* ptr = stackalloc USharpherealTestStruct_Delegate.__ExecuteDyn0Array_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USharpherealTestStruct_Delegate.__ExecuteDyn0Array_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USharpherealTestStruct_Delegate.__ExecuteDyn0Array_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USharpherealTestStruct_Delegate.__ExecuteDyn0Array_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600AE67 RID: 44647 RVA: 0x00102A30 File Offset: 0x00100C30
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void CopyMultiDelegate(in FSharpherealTestDynMultiDelegate1 NewDyn1)
		{
			USharpherealTestStruct_Delegate.__CopyMultiDelegate_FunctionParams* ptr = stackalloc USharpherealTestStruct_Delegate.__CopyMultiDelegate_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USharpherealTestStruct_Delegate.__CopyMultiDelegate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USharpherealTestStruct_Delegate.__CopyMultiDelegate_NativeFunctionPtr, (void*)ptr, 1);
			IntPtr dest = &ptr->NewDyn1;
			FSharpherealTestDynMultiDelegate1 fsharpherealTestDynMultiDelegate = NewDyn1;
			FMulticastScriptDelegate.NativeMove(dest, (fsharpherealTestDynMultiDelegate != null) ? fsharpherealTestDynMultiDelegate.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USharpherealTestStruct_Delegate.__CopyMultiDelegate_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(USharpherealTestStruct_Delegate.__CopyMultiDelegate_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AE68 RID: 44648 RVA: 0x00102A9C File Offset: 0x00100C9C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void CopyDelegate(in FSharpherealTestDynDelegate0 NewDyn0)
		{
			USharpherealTestStruct_Delegate.__CopyDelegate_FunctionParams* ptr = stackalloc USharpherealTestStruct_Delegate.__CopyDelegate_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(USharpherealTestStruct_Delegate.__CopyDelegate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USharpherealTestStruct_Delegate.__CopyDelegate_NativeFunctionPtr, (void*)ptr, 1);
			IntPtr dest = &ptr->NewDyn0;
			FSharpherealTestDynDelegate0 fsharpherealTestDynDelegate = NewDyn0;
			FScriptDelegate.NativeCopy(dest, (fsharpherealTestDynDelegate != null) ? fsharpherealTestDynDelegate.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USharpherealTestStruct_Delegate.__CopyDelegate_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(USharpherealTestStruct_Delegate.__CopyDelegate_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AE69 RID: 44649 RVA: 0x00102B08 File Offset: 0x00100D08
		[SkipLocalsInit]
		public unsafe void AddKey(int Val)
		{
			USharpherealTestStruct_Delegate.__AddKey_FunctionParams* ptr = stackalloc USharpherealTestStruct_Delegate.__AddKey_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(USharpherealTestStruct_Delegate.__AddKey_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USharpherealTestStruct_Delegate.__AddKey_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Val = Val;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USharpherealTestStruct_Delegate.__AddKey_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600AE6A RID: 44650 RVA: 0x00102B50 File Offset: 0x00100D50
		[SkipLocalsInit]
		public unsafe FTransform AddFTransform(in FTransform A, in FTransform B)
		{
			USharpherealTestStruct_Delegate.__AddFTransform_FunctionParams* ptr = stackalloc USharpherealTestStruct_Delegate.__AddFTransform_FunctionParams[(UIntPtr)159] + 15L / (long)sizeof(USharpherealTestStruct_Delegate.__AddFTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USharpherealTestStruct_Delegate.__AddFTransform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->A = A;
			ptr->B = B;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USharpherealTestStruct_Delegate.__AddFTransform_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600AE6B RID: 44651 RVA: 0x00102BB0 File Offset: 0x00100DB0
		[SkipLocalsInit]
		public unsafe FQuat AddFQuat(in FQuat A, in FQuat B)
		{
			USharpherealTestStruct_Delegate.__AddFQuat_FunctionParams* ptr = stackalloc USharpherealTestStruct_Delegate.__AddFQuat_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(USharpherealTestStruct_Delegate.__AddFQuat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USharpherealTestStruct_Delegate.__AddFQuat_NativeFunctionPtr, (void*)ptr, 1);
			ptr->A = A;
			ptr->B = B;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, USharpherealTestStruct_Delegate.__AddFQuat_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600AE6C RID: 44652 RVA: 0x00102C0D File Offset: 0x00100E0D
		static USharpherealTestStruct_Delegate()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SharpherealTest.SharpherealTestStruct_Delegate");
		}

		// Token: 0x0600AE6D RID: 44653 RVA: 0x00102C1B File Offset: 0x00100E1B
		protected USharpherealTestStruct_Delegate(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004B63 RID: 19299
		public new const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestStruct_Delegate";

		// Token: 0x04004B64 RID: 19300
		private static IntPtr _ClassPtr;

		// Token: 0x04004B65 RID: 19301
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004B66 RID: 19302
		internal static int __PropertyOffset_Key;

		// Token: 0x04004B67 RID: 19303
		internal static int __PropertyOffset_Dyn0;

		// Token: 0x04004B68 RID: 19304
		[Nullable(2)]
		private FSharpherealTestDynDelegate0 _Dyn0;

		// Token: 0x04004B69 RID: 19305
		internal static int __PropertyOffset_Dyn0Array;

		// Token: 0x04004B6A RID: 19306
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSharpherealTestDynDelegate0> _Dyn0Array;

		// Token: 0x04004B6B RID: 19307
		internal static int __PropertyOffset_Dyn1;

		// Token: 0x04004B6C RID: 19308
		[Nullable(2)]
		private FSharpherealTestDynDelegate1 _Dyn1;

		// Token: 0x04004B6D RID: 19309
		internal static int __PropertyOffset_Dyn1Array;

		// Token: 0x04004B6E RID: 19310
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSharpherealTestDynDelegate1> _Dyn1Array;

		// Token: 0x04004B6F RID: 19311
		internal static int __PropertyOffset_DynMulti0;

		// Token: 0x04004B70 RID: 19312
		[Nullable(2)]
		private FSharpherealTestDynMultiDelegate0 _DynMulti0;

		// Token: 0x04004B71 RID: 19313
		internal static int __PropertyOffset_DynMulti0Array;

		// Token: 0x04004B72 RID: 19314
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSharpherealTestDynMultiDelegate0> _DynMulti0Array;

		// Token: 0x04004B73 RID: 19315
		internal static int __PropertyOffset_DynMulti1;

		// Token: 0x04004B74 RID: 19316
		[Nullable(2)]
		private FSharpherealTestDynMultiDelegate1 _DynMulti1;

		// Token: 0x04004B75 RID: 19317
		internal static int __PropertyOffset_DynMulti1Array;

		// Token: 0x04004B76 RID: 19318
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSharpherealTestDynMultiDelegate1> _DynMulti1Array;

		// Token: 0x04004B77 RID: 19319
		internal static int __PropertyOffset_SparseMulti1;

		// Token: 0x04004B78 RID: 19320
		[Nullable(2)]
		private FSharpherealTestSparseMultiDelegate1 _SparseMulti1;

		// Token: 0x04004B79 RID: 19321
		internal static int __PropertyOffset_SparseMulti1Array;

		// Token: 0x04004B7A RID: 19322
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSharpherealTestSparseMultiDelegate1> _SparseMulti1Array;

		// Token: 0x04004B7B RID: 19323
		internal static int __PropertyOffset_DynDelegate_FQuat;

		// Token: 0x04004B7C RID: 19324
		[Nullable(2)]
		private FSharpherealTestDynDelegate_FQuat _DynDelegate_FQuat;

		// Token: 0x04004B7D RID: 19325
		internal static int __PropertyOffset_DynDelegate_FTransform;

		// Token: 0x04004B7E RID: 19326
		[Nullable(2)]
		private FSharpherealTestDynDelegate_FTransform _DynDelegate_FTransform;

		// Token: 0x04004B7F RID: 19327
		private static IntPtr __IncKey_NativeFunctionPtr;

		// Token: 0x04004B80 RID: 19328
		private static IntPtr __GetKey_NativeFunctionPtr;

		// Token: 0x04004B81 RID: 19329
		private static IntPtr __ExecuteDynMulti1Array_NativeFunctionPtr;

		// Token: 0x04004B82 RID: 19330
		private static IntPtr __ExecuteDynMulti0Array_NativeFunctionPtr;

		// Token: 0x04004B83 RID: 19331
		private static IntPtr __ExecuteDyn1Array_NativeFunctionPtr;

		// Token: 0x04004B84 RID: 19332
		private static IntPtr __ExecuteDyn0Array_NativeFunctionPtr;

		// Token: 0x04004B85 RID: 19333
		private static IntPtr __CopyMultiDelegate_NativeFunctionPtr;

		// Token: 0x04004B86 RID: 19334
		private static IntPtr __CopyDelegate_NativeFunctionPtr;

		// Token: 0x04004B87 RID: 19335
		private static IntPtr __AddKey_NativeFunctionPtr;

		// Token: 0x04004B88 RID: 19336
		private static IntPtr __AddFTransform_NativeFunctionPtr;

		// Token: 0x04004B89 RID: 19337
		private static IntPtr __AddFQuat_NativeFunctionPtr;

		// Token: 0x02000F9C RID: 3996
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetKey_FunctionParams
		{
			// Token: 0x040063A0 RID: 25504
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02000F9D RID: 3997
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ExecuteDynMulti1Array_FunctionParams
		{
			// Token: 0x040063A1 RID: 25505
			[FieldOffset(0)]
			public int Val;
		}

		// Token: 0x02000F9E RID: 3998
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ExecuteDyn1Array_FunctionParams
		{
			// Token: 0x040063A2 RID: 25506
			[FieldOffset(0)]
			public int Val;
		}

		// Token: 0x02000F9F RID: 3999
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ExecuteDyn0Array_FunctionParams
		{
			// Token: 0x040063A3 RID: 25507
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02000FA0 RID: 4000
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __CopyMultiDelegate_FunctionParams
		{
			// Token: 0x040063A4 RID: 25508
			[FieldOffset(0)]
			public byte NewDyn1;
		}

		// Token: 0x02000FA1 RID: 4001
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __CopyDelegate_FunctionParams
		{
			// Token: 0x040063A5 RID: 25509
			[FieldOffset(0)]
			public byte NewDyn0;
		}

		// Token: 0x02000FA2 RID: 4002
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __AddKey_FunctionParams
		{
			// Token: 0x040063A6 RID: 25510
			[FieldOffset(0)]
			public int Val;
		}

		// Token: 0x02000FA3 RID: 4003
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 144)]
		protected ref struct __AddFTransform_FunctionParams
		{
			// Token: 0x040063A7 RID: 25511
			[FieldOffset(0)]
			public FTransform A;

			// Token: 0x040063A8 RID: 25512
			[FieldOffset(48)]
			public FTransform B;

			// Token: 0x040063A9 RID: 25513
			[FieldOffset(96)]
			public FTransform __Result;
		}

		// Token: 0x02000FA4 RID: 4004
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __AddFQuat_FunctionParams
		{
			// Token: 0x040063AA RID: 25514
			[FieldOffset(0)]
			public FQuat A;

			// Token: 0x040063AB RID: 25515
			[FieldOffset(16)]
			public FQuat B;

			// Token: 0x040063AC RID: 25516
			[FieldOffset(32)]
			public FQuat __Result;
		}
	}
}
