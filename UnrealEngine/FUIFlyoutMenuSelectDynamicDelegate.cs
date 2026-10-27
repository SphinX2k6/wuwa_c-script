using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002170 RID: 8560
	public sealed class FUIFlyoutMenuSelectDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060204F7 RID: 132343 RVA: 0x002FFC6D File Offset: 0x002FDE6D
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FUIFlyoutMenuSelectDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x060204F8 RID: 132344 RVA: 0x002FFC79 File Offset: 0x002FDE79
		private static IntPtr StaticFunctionPtr()
		{
			if (FUIFlyoutMenuSelectDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FUIFlyoutMenuSelectDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.UIFlyoutMenuSelectDynamicDelegate__DelegateSignature");
			}
			return FUIFlyoutMenuSelectDynamicDelegate._FunctionPtr;
		}

		// Token: 0x060204F9 RID: 132345 RVA: 0x002FFC9C File Offset: 0x002FDE9C
		public FUIFlyoutMenuSelectDynamicDelegate()
		{
		}

		// Token: 0x060204FA RID: 132346 RVA: 0x002FFCA4 File Offset: 0x002FDEA4
		[NullableContext(2)]
		public FUIFlyoutMenuSelectDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060204FB RID: 132347 RVA: 0x002FFCAE File Offset: 0x002FDEAE
		public FUIFlyoutMenuSelectDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060204FC RID: 132348 RVA: 0x002FFCB9 File Offset: 0x002FDEB9
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, string>) ?? ((Action<int, string>)Delegate.CreateDelegate(typeof(Action<int, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060204FD RID: 132349 RVA: 0x002FFCEB File Offset: 0x002FDEEB
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<int, string> Callback)
		{
			if (FUIFlyoutMenuSelectDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FUIFlyoutMenuSelectDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FUIFlyoutMenuSelectDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FUIFlyoutMenuSelectDynamicDelegate.OnScriptCallback));
				}
				FUIFlyoutMenuSelectDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FUIFlyoutMenuSelectDynamicDelegate.RegisterId);
		}

		// Token: 0x060204FE RID: 132350 RVA: 0x002FFD28 File Offset: 0x002FDF28
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int InSelectIndex, string InSelectItem)
		{
			FUIFlyoutMenuSelectDynamicDelegate.__FUIFlyoutMenuSelectDynamicDelegate_DelegateParams* ptr = stackalloc FUIFlyoutMenuSelectDynamicDelegate.__FUIFlyoutMenuSelectDynamicDelegate_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FUIFlyoutMenuSelectDynamicDelegate.__FUIFlyoutMenuSelectDynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FUIFlyoutMenuSelectDynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->InSelectIndex = InSelectIndex;
			FString.CopyFrom((void*)(&ptr->InSelectItem), InSelectItem);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FUIFlyoutMenuSelectDynamicDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060204FF RID: 132351 RVA: 0x002FFD84 File Offset: 0x002FDF84
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, string> action = target as Action<int, string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FUIFlyoutMenuSelectDynamicDelegate.__FUIFlyoutMenuSelectDynamicDelegate_DelegateParams*)__Parameters)->InSelectItem));
			action(((FUIFlyoutMenuSelectDynamicDelegate.__FUIFlyoutMenuSelectDynamicDelegate_DelegateParams*)__Parameters)->InSelectIndex, arg);
		}

		// Token: 0x040115C3 RID: 71107
		internal static IntPtr _FunctionPtr;

		// Token: 0x040115C4 RID: 71108
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.UIFlyoutMenuSelectDynamicDelegate__DelegateSignature";

		// Token: 0x040115C5 RID: 71109
		private static int RegisterId;

		// Token: 0x020034FA RID: 13562
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FUIFlyoutMenuSelectDynamicDelegate_DelegateParams
		{
			// Token: 0x0401751F RID: 95519
			[FieldOffset(0)]
			public int InSelectIndex;

			// Token: 0x04017520 RID: 95520
			[FieldOffset(8)]
			public FString InSelectItem;
		}

		// Token: 0x020034FB RID: 13563
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017521 RID: 95521
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
