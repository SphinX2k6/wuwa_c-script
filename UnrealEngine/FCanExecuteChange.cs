using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001FCF RID: 8143
	public sealed class FCanExecuteChange : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601EE48 RID: 126536 RVA: 0x002DE879 File Offset: 0x002DCA79
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FCanExecuteChange.StaticFunctionPtr();
		}

		// Token: 0x0601EE49 RID: 126537 RVA: 0x002DE885 File Offset: 0x002DCA85
		private static IntPtr StaticFunctionPtr()
		{
			if (FCanExecuteChange._FunctionPtr == IntPtr.Zero)
			{
				FCanExecuteChange._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.CanExecuteChange__DelegateSignature");
			}
			return FCanExecuteChange._FunctionPtr;
		}

		// Token: 0x0601EE4A RID: 126538 RVA: 0x002DE8A8 File Offset: 0x002DCAA8
		public FCanExecuteChange()
		{
		}

		// Token: 0x0601EE4B RID: 126539 RVA: 0x002DE8B0 File Offset: 0x002DCAB0
		[NullableContext(2)]
		public FCanExecuteChange(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EE4C RID: 126540 RVA: 0x002DE8BA File Offset: 0x002DCABA
		public FCanExecuteChange(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EE4D RID: 126541 RVA: 0x002DE8C5 File Offset: 0x002DCAC5
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<bool>) ?? ((Func<bool>)Delegate.CreateDelegate(typeof(Func<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601EE4E RID: 126542 RVA: 0x002DE8F7 File Offset: 0x002DCAF7
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601EE4F RID: 126543 RVA: 0x002DE934 File Offset: 0x002DCB34
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool Execute()
		{
			FCanExecuteChange.__FCanExecuteChange_DelegateParams* ptr = stackalloc FCanExecuteChange.__FCanExecuteChange_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FCanExecuteChange.__FCanExecuteChange_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FCanExecuteChange.StaticFunctionPtr(), (void*)ptr, 1);
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601EE50 RID: 126544 RVA: 0x002DE970 File Offset: 0x002DCB70
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04010B01 RID: 68353
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010B02 RID: 68354
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.CanExecuteChange__DelegateSignature";

		// Token: 0x04010B03 RID: 68355
		private static int RegisterId;

		// Token: 0x02003423 RID: 13347
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FCanExecuteChange_DelegateParams
		{
			// Token: 0x040173FE RID: 95230
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003424 RID: 13348
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040173FF RID: 95231
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
