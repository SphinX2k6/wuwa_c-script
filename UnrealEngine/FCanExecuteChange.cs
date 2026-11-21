using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000646 RID: 1606
	public sealed class FCanExecuteChange : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008D48 RID: 36168 RVA: 0x000D48F5 File Offset: 0x000D2AF5
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FCanExecuteChange.StaticFunctionPtr();
		}

		// Token: 0x06008D49 RID: 36169 RVA: 0x000D4901 File Offset: 0x000D2B01
		private static IntPtr StaticFunctionPtr()
		{
			if (FCanExecuteChange._FunctionPtr == IntPtr.Zero)
			{
				FCanExecuteChange._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.CanExecuteChange__DelegateSignature");
			}
			return FCanExecuteChange._FunctionPtr;
		}

		// Token: 0x06008D4A RID: 36170 RVA: 0x000D4924 File Offset: 0x000D2B24
		public FCanExecuteChange()
		{
		}

		// Token: 0x06008D4B RID: 36171 RVA: 0x000D492C File Offset: 0x000D2B2C
		[NullableContext(2)]
		public FCanExecuteChange(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008D4C RID: 36172 RVA: 0x000D4936 File Offset: 0x000D2B36
		public FCanExecuteChange(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008D4D RID: 36173 RVA: 0x000D4941 File Offset: 0x000D2B41
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<bool>) ?? ((Func<bool>)Delegate.CreateDelegate(typeof(Func<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008D4E RID: 36174 RVA: 0x000D4973 File Offset: 0x000D2B73
		[NullableContext(1)]
		public void Bind(Func<bool> Callback)
		{
			if (FCanExecuteChange.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FCanExecuteChange.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FCanExecuteChange.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FCanExecuteChange.OnScriptCallback));
				}
				FCanExecuteChange.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FCanExecuteChange.RegisterId);
		}

		// Token: 0x06008D4F RID: 36175 RVA: 0x000D49B0 File Offset: 0x000D2BB0
		[SkipLocalsInit]
		public unsafe bool Execute()
		{
			FCanExecuteChange.__FCanExecuteChange_DelegateParams* ptr = stackalloc FCanExecuteChange.__FCanExecuteChange_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FCanExecuteChange.__FCanExecuteChange_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FCanExecuteChange.StaticFunctionPtr(), (void*)ptr, 1);
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06008D50 RID: 36176 RVA: 0x000D49EC File Offset: 0x000D2BEC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<bool> func = target as Func<bool>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			bool _Result = func();
			((FCanExecuteChange.__FCanExecuteChange_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x04003D7D RID: 15741
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003D7E RID: 15742
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.CanExecuteChange__DelegateSignature";

		// Token: 0x04003D7F RID: 15743
		private static int RegisterId;

		// Token: 0x02000E66 RID: 3686
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		private ref struct __FCanExecuteChange_DelegateParams
		{
			// Token: 0x0400620D RID: 25101
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000E67 RID: 3687
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400620E RID: 25102
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
