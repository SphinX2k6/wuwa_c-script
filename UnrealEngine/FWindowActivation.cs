using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F12 RID: 7954
	public sealed class FWindowActivation : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E2EF RID: 123631 RVA: 0x002CE0CC File Offset: 0x002CC2CC
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FWindowActivation.StaticFunctionPtr();
		}

		// Token: 0x0601E2F0 RID: 123632 RVA: 0x002CE0D8 File Offset: 0x002CC2D8
		private static IntPtr StaticFunctionPtr()
		{
			if (FWindowActivation._FunctionPtr == IntPtr.Zero)
			{
				FWindowActivation._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.WindowActivation__DelegateSignature");
			}
			return FWindowActivation._FunctionPtr;
		}

		// Token: 0x0601E2F1 RID: 123633 RVA: 0x002CE0FB File Offset: 0x002CC2FB
		public FWindowActivation()
		{
		}

		// Token: 0x0601E2F2 RID: 123634 RVA: 0x002CE103 File Offset: 0x002CC303
		[NullableContext(2)]
		public FWindowActivation(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E2F3 RID: 123635 RVA: 0x002CE10D File Offset: 0x002CC30D
		public FWindowActivation(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E2F4 RID: 123636 RVA: 0x002CE118 File Offset: 0x002CC318
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E2F5 RID: 123637 RVA: 0x002CE14A File Offset: 0x002CC34A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<bool> Callback)
		{
			if (FWindowActivation.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FWindowActivation.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FWindowActivation.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FWindowActivation.OnScriptCallback));
				}
				FWindowActivation.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FWindowActivation.RegisterId);
		}

		// Token: 0x0601E2F6 RID: 123638 RVA: 0x002CE184 File Offset: 0x002CC384
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(bool Activated)
		{
			FWindowActivation.__FWindowActivation_DelegateParams* ptr = stackalloc FWindowActivation.__FWindowActivation_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FWindowActivation.__FWindowActivation_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FWindowActivation.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Activated = Activated;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601E2F7 RID: 123639 RVA: 0x002CE1C4 File Offset: 0x002CC3C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FWindowActivation.__FWindowActivation_DelegateParams*)__Parameters)->Activated);
		}

		// Token: 0x040104B6 RID: 66742
		internal static IntPtr _FunctionPtr;

		// Token: 0x040104B7 RID: 66743
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.WindowActivation__DelegateSignature";

		// Token: 0x040104B8 RID: 66744
		private static int RegisterId;

		// Token: 0x02003401 RID: 13313
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FWindowActivation_DelegateParams
		{
			// Token: 0x040173BC RID: 95164
			[FieldOffset(0)]
			public bool Activated;
		}

		// Token: 0x02003402 RID: 13314
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040173BD RID: 95165
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
