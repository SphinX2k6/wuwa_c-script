using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002169 RID: 8553
	public sealed class FUIExtendToggleGroupActive : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060204A3 RID: 132259 RVA: 0x002FF381 File Offset: 0x002FD581
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FUIExtendToggleGroupActive.StaticFunctionPtr();
		}

		// Token: 0x060204A4 RID: 132260 RVA: 0x002FF38D File Offset: 0x002FD58D
		private static IntPtr StaticFunctionPtr()
		{
			if (FUIExtendToggleGroupActive._FunctionPtr == IntPtr.Zero)
			{
				FUIExtendToggleGroupActive._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.UIExtendToggleGroupActive__DelegateSignature");
			}
			return FUIExtendToggleGroupActive._FunctionPtr;
		}

		// Token: 0x060204A5 RID: 132261 RVA: 0x002FF3B0 File Offset: 0x002FD5B0
		public FUIExtendToggleGroupActive()
		{
		}

		// Token: 0x060204A6 RID: 132262 RVA: 0x002FF3B8 File Offset: 0x002FD5B8
		[NullableContext(2)]
		public FUIExtendToggleGroupActive(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060204A7 RID: 132263 RVA: 0x002FF3C2 File Offset: 0x002FD5C2
		public FUIExtendToggleGroupActive(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060204A8 RID: 132264 RVA: 0x002FF3CD File Offset: 0x002FD5CD
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<UUIExtendToggleGroup, bool>) ?? ((Action<UUIExtendToggleGroup, bool>)Delegate.CreateDelegate(typeof(Action<UUIExtendToggleGroup, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060204A9 RID: 132265 RVA: 0x002FF3FF File Offset: 0x002FD5FF
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<UUIExtendToggleGroup, bool> Callback)
		{
			if (FUIExtendToggleGroupActive.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FUIExtendToggleGroupActive.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FUIExtendToggleGroupActive.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FUIExtendToggleGroupActive.OnScriptCallback));
				}
				FUIExtendToggleGroupActive.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FUIExtendToggleGroupActive.RegisterId);
		}

		// Token: 0x060204AA RID: 132266 RVA: 0x002FF43C File Offset: 0x002FD63C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(UUIExtendToggleGroup ExtendToggleGroup, bool bCreate)
		{
			FUIExtendToggleGroupActive.__FUIExtendToggleGroupActive_DelegateParams* ptr = stackalloc FUIExtendToggleGroupActive.__FUIExtendToggleGroupActive_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FUIExtendToggleGroupActive.__FUIExtendToggleGroupActive_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FUIExtendToggleGroupActive.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ExtendToggleGroup = ((ExtendToggleGroup != null) ? ExtendToggleGroup.NativePtr : IntPtr.Zero);
			ptr->bCreate = bCreate;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060204AB RID: 132267 RVA: 0x002FF490 File Offset: 0x002FD690
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UUIExtendToggleGroup, bool> action = target as Action<UUIExtendToggleGroup, bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UUIExtendToggleGroup orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIExtendToggleGroup>(((FUIExtendToggleGroupActive.__FUIExtendToggleGroupActive_DelegateParams*)__Parameters)->ExtendToggleGroup);
			action(orCreateUObjectByNativePointer, ((FUIExtendToggleGroupActive.__FUIExtendToggleGroupActive_DelegateParams*)__Parameters)->bCreate);
		}

		// Token: 0x04011594 RID: 71060
		internal static IntPtr _FunctionPtr;

		// Token: 0x04011595 RID: 71061
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.UIExtendToggleGroupActive__DelegateSignature";

		// Token: 0x04011596 RID: 71062
		private static int RegisterId;

		// Token: 0x020034F8 RID: 13560
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FUIExtendToggleGroupActive_DelegateParams
		{
			// Token: 0x0401751C RID: 95516
			[FieldOffset(0)]
			public IntPtr ExtendToggleGroup;

			// Token: 0x0401751D RID: 95517
			[FieldOffset(8)]
			public bool bCreate;
		}

		// Token: 0x020034F9 RID: 13561
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401751E RID: 95518
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
