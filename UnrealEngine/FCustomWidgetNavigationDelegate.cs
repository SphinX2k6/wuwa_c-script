using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200294B RID: 10571
	public sealed class FCustomWidgetNavigationDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06027240 RID: 160320 RVA: 0x003BAC85 File Offset: 0x003B8E85
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FCustomWidgetNavigationDelegate.StaticFunctionPtr();
		}

		// Token: 0x06027241 RID: 160321 RVA: 0x003BAC91 File Offset: 0x003B8E91
		private static IntPtr StaticFunctionPtr()
		{
			if (FCustomWidgetNavigationDelegate._FunctionPtr == IntPtr.Zero)
			{
				FCustomWidgetNavigationDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.CustomWidgetNavigationDelegate__DelegateSignature");
			}
			return FCustomWidgetNavigationDelegate._FunctionPtr;
		}

		// Token: 0x06027242 RID: 160322 RVA: 0x003BACB4 File Offset: 0x003B8EB4
		public FCustomWidgetNavigationDelegate()
		{
		}

		// Token: 0x06027243 RID: 160323 RVA: 0x003BACBC File Offset: 0x003B8EBC
		[NullableContext(2)]
		public FCustomWidgetNavigationDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027244 RID: 160324 RVA: 0x003BACC6 File Offset: 0x003B8EC6
		public FCustomWidgetNavigationDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027245 RID: 160325 RVA: 0x003BACD1 File Offset: 0x003B8ED1
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<EUINavigation, UWidget>) ?? ((Func<EUINavigation, UWidget>)Delegate.CreateDelegate(typeof(Func<EUINavigation, UWidget>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06027246 RID: 160326 RVA: 0x003BAD03 File Offset: 0x003B8F03
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06027247 RID: 160327 RVA: 0x003BAD40 File Offset: 0x003B8F40
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe UWidget Execute(EUINavigation Navigation)
		{
			FCustomWidgetNavigationDelegate.__FCustomWidgetNavigationDelegate_DelegateParams* ptr = stackalloc FCustomWidgetNavigationDelegate.__FCustomWidgetNavigationDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FCustomWidgetNavigationDelegate.__FCustomWidgetNavigationDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FCustomWidgetNavigationDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Navigation = Navigation;
			base.ExecuteInternal((void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UWidget>(ptr->__Result);
		}

		// Token: 0x06027248 RID: 160328 RVA: 0x003BAD88 File Offset: 0x003B8F88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x040157E7 RID: 88039
		internal static IntPtr _FunctionPtr;

		// Token: 0x040157E8 RID: 88040
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.CustomWidgetNavigationDelegate__DelegateSignature";

		// Token: 0x040157E9 RID: 88041
		private static int RegisterId;

		// Token: 0x02003B66 RID: 15206
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FCustomWidgetNavigationDelegate_DelegateParams
		{
			// Token: 0x04017D3D RID: 97597
			[FieldOffset(0)]
			public EUINavigation Navigation;

			// Token: 0x04017D3E RID: 97598
			[FieldOffset(8)]
			public IntPtr __Result;
		}

		// Token: 0x02003B67 RID: 15207
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D3F RID: 97599
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
