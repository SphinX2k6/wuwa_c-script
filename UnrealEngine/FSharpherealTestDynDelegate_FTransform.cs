using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007E8 RID: 2024
	public sealed class FSharpherealTestDynDelegate_FTransform : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600AD86 RID: 44422 RVA: 0x00100B34 File Offset: 0x000FED34
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSharpherealTestDynDelegate_FTransform.StaticFunctionPtr();
		}

		// Token: 0x0600AD87 RID: 44423 RVA: 0x00100B40 File Offset: 0x000FED40
		private static IntPtr StaticFunctionPtr()
		{
			if (FSharpherealTestDynDelegate_FTransform._FunctionPtr == IntPtr.Zero)
			{
				FSharpherealTestDynDelegate_FTransform._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SharpherealTest.SharpherealTestDynDelegate_FTransform__DelegateSignature");
			}
			return FSharpherealTestDynDelegate_FTransform._FunctionPtr;
		}

		// Token: 0x0600AD88 RID: 44424 RVA: 0x00100B63 File Offset: 0x000FED63
		public FSharpherealTestDynDelegate_FTransform()
		{
		}

		// Token: 0x0600AD89 RID: 44425 RVA: 0x00100B6B File Offset: 0x000FED6B
		[NullableContext(2)]
		public FSharpherealTestDynDelegate_FTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AD8A RID: 44426 RVA: 0x00100B75 File Offset: 0x000FED75
		public FSharpherealTestDynDelegate_FTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AD8B RID: 44427 RVA: 0x00100B80 File Offset: 0x000FED80
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<FTransform, FTransform, FTransform>) ?? ((Func<FTransform, FTransform, FTransform>)Delegate.CreateDelegate(typeof(Func<FTransform, FTransform, FTransform>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600AD8C RID: 44428 RVA: 0x00100BB2 File Offset: 0x000FEDB2
		[NullableContext(1)]
		public void Bind(Func<FTransform, FTransform, FTransform> Callback)
		{
			if (FSharpherealTestDynDelegate_FTransform.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSharpherealTestDynDelegate_FTransform.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSharpherealTestDynDelegate_FTransform.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSharpherealTestDynDelegate_FTransform.OnScriptCallback));
				}
				FSharpherealTestDynDelegate_FTransform.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FSharpherealTestDynDelegate_FTransform.RegisterId);
		}

		// Token: 0x0600AD8D RID: 44429 RVA: 0x00100BEC File Offset: 0x000FEDEC
		[SkipLocalsInit]
		public unsafe FTransform Execute(in FTransform A, in FTransform B)
		{
			FSharpherealTestDynDelegate_FTransform.__FSharpherealTestDynDelegate_FTransform_DelegateParams* ptr = stackalloc FSharpherealTestDynDelegate_FTransform.__FSharpherealTestDynDelegate_FTransform_DelegateParams[(UIntPtr)159] + 15L / (long)sizeof(FSharpherealTestDynDelegate_FTransform.__FSharpherealTestDynDelegate_FTransform_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSharpherealTestDynDelegate_FTransform.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->A = A;
			ptr->B = B;
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600AD8E RID: 44430 RVA: 0x00100C44 File Offset: 0x000FEE44
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<FTransform, FTransform, FTransform> func = target as Func<FTransform, FTransform, FTransform>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FTransform _Result = func(((FSharpherealTestDynDelegate_FTransform.__FSharpherealTestDynDelegate_FTransform_DelegateParams*)__Parameters)->A, ((FSharpherealTestDynDelegate_FTransform.__FSharpherealTestDynDelegate_FTransform_DelegateParams*)__Parameters)->B);
			((FSharpherealTestDynDelegate_FTransform.__FSharpherealTestDynDelegate_FTransform_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x04004AE0 RID: 19168
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004AE1 RID: 19169
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestDynDelegate_FTransform__DelegateSignature";

		// Token: 0x04004AE2 RID: 19170
		private static int RegisterId;

		// Token: 0x02000F91 RID: 3985
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 144)]
		private ref struct __FSharpherealTestDynDelegate_FTransform_DelegateParams
		{
			// Token: 0x0400638F RID: 25487
			[FieldOffset(0)]
			public FTransform A;

			// Token: 0x04006390 RID: 25488
			[FieldOffset(48)]
			public FTransform B;

			// Token: 0x04006391 RID: 25489
			[FieldOffset(96)]
			public FTransform __Result;
		}

		// Token: 0x02000F92 RID: 3986
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006392 RID: 25490
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
