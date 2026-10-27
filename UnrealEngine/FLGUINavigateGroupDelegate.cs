using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200208F RID: 8335
	public sealed class FLGUINavigateGroupDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F703 RID: 128771 RVA: 0x002EB423 File Offset: 0x002E9623
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUINavigateGroupDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F704 RID: 128772 RVA: 0x002EB42F File Offset: 0x002E962F
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUINavigateGroupDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUINavigateGroupDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUINavigateGroupDelegate__DelegateSignature");
			}
			return FLGUINavigateGroupDelegate._FunctionPtr;
		}

		// Token: 0x0601F705 RID: 128773 RVA: 0x002EB452 File Offset: 0x002E9652
		public FLGUINavigateGroupDelegate()
		{
		}

		// Token: 0x0601F706 RID: 128774 RVA: 0x002EB45A File Offset: 0x002E965A
		[NullableContext(2)]
		public FLGUINavigateGroupDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F707 RID: 128775 RVA: 0x002EB464 File Offset: 0x002E9664
		public FLGUINavigateGroupDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F708 RID: 128776 RVA: 0x002EB46F File Offset: 0x002E966F
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<UUINavigationGroupComponent, UINavigationGroupMode>) ?? ((Action<UUINavigationGroupComponent, UINavigationGroupMode>)Delegate.CreateDelegate(typeof(Action<UUINavigationGroupComponent, UINavigationGroupMode>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F709 RID: 128777 RVA: 0x002EB4A1 File Offset: 0x002E96A1
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<UUINavigationGroupComponent, UINavigationGroupMode> Callback)
		{
			if (FLGUINavigateGroupDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUINavigateGroupDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUINavigateGroupDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUINavigateGroupDelegate.OnScriptCallback));
				}
				FLGUINavigateGroupDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUINavigateGroupDelegate.RegisterId);
		}

		// Token: 0x0601F70A RID: 128778 RVA: 0x002EB4DC File Offset: 0x002E96DC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(UUINavigationGroupComponent NavigationGroupComponent, UINavigationGroupMode mode)
		{
			FLGUINavigateGroupDelegate.__FLGUINavigateGroupDelegate_DelegateParams* ptr = stackalloc FLGUINavigateGroupDelegate.__FLGUINavigateGroupDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLGUINavigateGroupDelegate.__FLGUINavigateGroupDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUINavigateGroupDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->NavigationGroupComponent = ((NavigationGroupComponent != null) ? NavigationGroupComponent.NativePtr : IntPtr.Zero);
			ptr->mode = mode;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F70B RID: 128779 RVA: 0x002EB530 File Offset: 0x002E9730
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UUINavigationGroupComponent, UINavigationGroupMode> action = target as Action<UUINavigationGroupComponent, UINavigationGroupMode>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UUINavigationGroupComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UUINavigationGroupComponent>(((FLGUINavigateGroupDelegate.__FLGUINavigateGroupDelegate_DelegateParams*)__Parameters)->NavigationGroupComponent);
			action(orCreateUObjectByNativePointer, ((FLGUINavigateGroupDelegate.__FLGUINavigateGroupDelegate_DelegateParams*)__Parameters)->mode);
		}

		// Token: 0x04010FA9 RID: 69545
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010FAA RID: 69546
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUINavigateGroupDelegate__DelegateSignature";

		// Token: 0x04010FAB RID: 69547
		private static int RegisterId;

		// Token: 0x02003492 RID: 13458
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FLGUINavigateGroupDelegate_DelegateParams
		{
			// Token: 0x04017486 RID: 95366
			[FieldOffset(0)]
			public IntPtr NavigationGroupComponent;

			// Token: 0x04017487 RID: 95367
			[FieldOffset(8)]
			public UINavigationGroupMode mode;
		}

		// Token: 0x02003493 RID: 13459
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017488 RID: 95368
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
