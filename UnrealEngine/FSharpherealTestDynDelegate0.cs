using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007E5 RID: 2021
	public sealed class FSharpherealTestDynDelegate0 : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600AD6B RID: 44395 RVA: 0x0010074B File Offset: 0x000FE94B
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSharpherealTestDynDelegate0.StaticFunctionPtr();
		}

		// Token: 0x0600AD6C RID: 44396 RVA: 0x00100757 File Offset: 0x000FE957
		private static IntPtr StaticFunctionPtr()
		{
			if (FSharpherealTestDynDelegate0._FunctionPtr == IntPtr.Zero)
			{
				FSharpherealTestDynDelegate0._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SharpherealTest.SharpherealTestDynDelegate0__DelegateSignature");
			}
			return FSharpherealTestDynDelegate0._FunctionPtr;
		}

		// Token: 0x0600AD6D RID: 44397 RVA: 0x0010077A File Offset: 0x000FE97A
		public FSharpherealTestDynDelegate0()
		{
		}

		// Token: 0x0600AD6E RID: 44398 RVA: 0x00100782 File Offset: 0x000FE982
		[NullableContext(2)]
		public FSharpherealTestDynDelegate0(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AD6F RID: 44399 RVA: 0x0010078C File Offset: 0x000FE98C
		public FSharpherealTestDynDelegate0(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AD70 RID: 44400 RVA: 0x00100797 File Offset: 0x000FE997
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<int>) ?? ((Func<int>)Delegate.CreateDelegate(typeof(Func<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600AD71 RID: 44401 RVA: 0x001007C9 File Offset: 0x000FE9C9
		[NullableContext(1)]
		public void Bind(Func<int> Callback)
		{
			if (FSharpherealTestDynDelegate0.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSharpherealTestDynDelegate0.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSharpherealTestDynDelegate0.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSharpherealTestDynDelegate0.OnScriptCallback));
				}
				FSharpherealTestDynDelegate0.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FSharpherealTestDynDelegate0.RegisterId);
		}

		// Token: 0x0600AD72 RID: 44402 RVA: 0x00100804 File Offset: 0x000FEA04
		[SkipLocalsInit]
		public unsafe int Execute()
		{
			FSharpherealTestDynDelegate0.__FSharpherealTestDynDelegate0_DelegateParams* ptr = stackalloc FSharpherealTestDynDelegate0.__FSharpherealTestDynDelegate0_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FSharpherealTestDynDelegate0.__FSharpherealTestDynDelegate0_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSharpherealTestDynDelegate0.StaticFunctionPtr(), (void*)ptr, 1);
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600AD73 RID: 44403 RVA: 0x00100840 File Offset: 0x000FEA40
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<int> func = target as Func<int>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			int _Result = func();
			((FSharpherealTestDynDelegate0.__FSharpherealTestDynDelegate0_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x04004AD7 RID: 19159
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004AD8 RID: 19160
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestDynDelegate0__DelegateSignature";

		// Token: 0x04004AD9 RID: 19161
		private static int RegisterId;

		// Token: 0x02000F8B RID: 3979
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FSharpherealTestDynDelegate0_DelegateParams
		{
			// Token: 0x04006387 RID: 25479
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02000F8C RID: 3980
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006388 RID: 25480
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
