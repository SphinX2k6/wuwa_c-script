using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000857 RID: 2135
	public sealed class FCustomWidgetNavigationDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600BA06 RID: 47622 RVA: 0x00129CAD File Offset: 0x00127EAD
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FCustomWidgetNavigationDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600BA07 RID: 47623 RVA: 0x00129CB9 File Offset: 0x00127EB9
		private static IntPtr StaticFunctionPtr()
		{
			if (FCustomWidgetNavigationDelegate._FunctionPtr == IntPtr.Zero)
			{
				FCustomWidgetNavigationDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.CustomWidgetNavigationDelegate__DelegateSignature");
			}
			return FCustomWidgetNavigationDelegate._FunctionPtr;
		}

		// Token: 0x0600BA08 RID: 47624 RVA: 0x00129CDC File Offset: 0x00127EDC
		public FCustomWidgetNavigationDelegate()
		{
		}

		// Token: 0x0600BA09 RID: 47625 RVA: 0x00129CE4 File Offset: 0x00127EE4
		[NullableContext(2)]
		public FCustomWidgetNavigationDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600BA0A RID: 47626 RVA: 0x00129CEE File Offset: 0x00127EEE
		public FCustomWidgetNavigationDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600BA0B RID: 47627 RVA: 0x00129CF9 File Offset: 0x00127EF9
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<EUINavigation, UWidget>) ?? ((Func<EUINavigation, UWidget>)Delegate.CreateDelegate(typeof(Func<EUINavigation, UWidget>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600BA0C RID: 47628 RVA: 0x00129D2B File Offset: 0x00127F2B
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Func<EUINavigation, UWidget> Callback)
		{
			if (FCustomWidgetNavigationDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FCustomWidgetNavigationDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FCustomWidgetNavigationDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FCustomWidgetNavigationDelegate.OnScriptCallback));
				}
				FCustomWidgetNavigationDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FCustomWidgetNavigationDelegate.RegisterId);
		}

		// Token: 0x0600BA0D RID: 47629 RVA: 0x00129D68 File Offset: 0x00127F68
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe UWidget Execute(EUINavigation Navigation)
		{
			FCustomWidgetNavigationDelegate.__FCustomWidgetNavigationDelegate_DelegateParams* ptr = stackalloc FCustomWidgetNavigationDelegate.__FCustomWidgetNavigationDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FCustomWidgetNavigationDelegate.__FCustomWidgetNavigationDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FCustomWidgetNavigationDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Navigation = Navigation;
			base.ExecuteInternal((void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UWidget>(ptr->__Result);
		}

		// Token: 0x0600BA0E RID: 47630 RVA: 0x00129DB0 File Offset: 0x00127FB0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<EUINavigation, UWidget> func = target as Func<EUINavigation, UWidget>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UWidget uwidget = func(((FCustomWidgetNavigationDelegate.__FCustomWidgetNavigationDelegate_DelegateParams*)__Parameters)->Navigation);
			((FCustomWidgetNavigationDelegate.__FCustomWidgetNavigationDelegate_DelegateParams*)__Parameters)->__Result = ((uwidget != null) ? uwidget.NativePtr : IntPtr.Zero);
		}

		// Token: 0x04005474 RID: 21620
		internal static IntPtr _FunctionPtr;

		// Token: 0x04005475 RID: 21621
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.CustomWidgetNavigationDelegate__DelegateSignature";

		// Token: 0x04005476 RID: 21622
		private static int RegisterId;

		// Token: 0x020013ED RID: 5101
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FCustomWidgetNavigationDelegate_DelegateParams
		{
			// Token: 0x04006895 RID: 26773
			[FieldOffset(0)]
			public EUINavigation Navigation;

			// Token: 0x04006896 RID: 26774
			[FieldOffset(8)]
			public IntPtr __Result;
		}

		// Token: 0x020013EE RID: 5102
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006897 RID: 26775
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
