using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007E6 RID: 2022
	public sealed class FSharpherealTestDynDelegate1 : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600AD74 RID: 44404 RVA: 0x0010088C File Offset: 0x000FEA8C
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSharpherealTestDynDelegate1.StaticFunctionPtr();
		}

		// Token: 0x0600AD75 RID: 44405 RVA: 0x00100898 File Offset: 0x000FEA98
		private static IntPtr StaticFunctionPtr()
		{
			if (FSharpherealTestDynDelegate1._FunctionPtr == IntPtr.Zero)
			{
				FSharpherealTestDynDelegate1._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SharpherealTest.SharpherealTestDynDelegate1__DelegateSignature");
			}
			return FSharpherealTestDynDelegate1._FunctionPtr;
		}

		// Token: 0x0600AD76 RID: 44406 RVA: 0x001008BB File Offset: 0x000FEABB
		public FSharpherealTestDynDelegate1()
		{
		}

		// Token: 0x0600AD77 RID: 44407 RVA: 0x001008C3 File Offset: 0x000FEAC3
		[NullableContext(2)]
		public FSharpherealTestDynDelegate1(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AD78 RID: 44408 RVA: 0x001008CD File Offset: 0x000FEACD
		public FSharpherealTestDynDelegate1(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AD79 RID: 44409 RVA: 0x001008D8 File Offset: 0x000FEAD8
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600AD7A RID: 44410 RVA: 0x0010090A File Offset: 0x000FEB0A
		[NullableContext(1)]
		public void Bind(Action<int> Callback)
		{
			if (FSharpherealTestDynDelegate1.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSharpherealTestDynDelegate1.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSharpherealTestDynDelegate1.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSharpherealTestDynDelegate1.OnScriptCallback));
				}
				FSharpherealTestDynDelegate1.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FSharpherealTestDynDelegate1.RegisterId);
		}

		// Token: 0x0600AD7B RID: 44411 RVA: 0x00100944 File Offset: 0x000FEB44
		[SkipLocalsInit]
		public unsafe void Execute(int Val)
		{
			FSharpherealTestDynDelegate1.__FSharpherealTestDynDelegate1_DelegateParams* ptr = stackalloc FSharpherealTestDynDelegate1.__FSharpherealTestDynDelegate1_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FSharpherealTestDynDelegate1.__FSharpherealTestDynDelegate1_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSharpherealTestDynDelegate1.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Val = Val;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600AD7C RID: 44412 RVA: 0x00100984 File Offset: 0x000FEB84
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FSharpherealTestDynDelegate1.__FSharpherealTestDynDelegate1_DelegateParams*)__Parameters)->Val);
		}

		// Token: 0x04004ADA RID: 19162
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004ADB RID: 19163
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestDynDelegate1__DelegateSignature";

		// Token: 0x04004ADC RID: 19164
		private static int RegisterId;

		// Token: 0x02000F8D RID: 3981
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FSharpherealTestDynDelegate1_DelegateParams
		{
			// Token: 0x04006389 RID: 25481
			[FieldOffset(0)]
			public int Val;
		}

		// Token: 0x02000F8E RID: 3982
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400638A RID: 25482
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
