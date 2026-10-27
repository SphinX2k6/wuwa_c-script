using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018B9 RID: 6329
	public sealed class FKeyBindingDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601765B RID: 95835 RVA: 0x002235AF File Offset: 0x002217AF
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKeyBindingDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601765C RID: 95836 RVA: 0x002235BB File Offset: 0x002217BB
		private static IntPtr StaticFunctionPtr()
		{
			if (FKeyBindingDelegate._FunctionPtr == IntPtr.Zero)
			{
				FKeyBindingDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.KeyBindingDelegate__DelegateSignature");
			}
			return FKeyBindingDelegate._FunctionPtr;
		}

		// Token: 0x0601765D RID: 95837 RVA: 0x002235DE File Offset: 0x002217DE
		public FKeyBindingDelegate()
		{
		}

		// Token: 0x0601765E RID: 95838 RVA: 0x002235E6 File Offset: 0x002217E6
		[NullableContext(2)]
		public FKeyBindingDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601765F RID: 95839 RVA: 0x002235F0 File Offset: 0x002217F0
		public FKeyBindingDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017660 RID: 95840 RVA: 0x002235FB File Offset: 0x002217FB
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FKey>) ?? ((Action<FKey>)Delegate.CreateDelegate(typeof(Action<FKey>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06017661 RID: 95841 RVA: 0x0022362D File Offset: 0x0022182D
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<FKey> Callback)
		{
			if (FKeyBindingDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKeyBindingDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKeyBindingDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKeyBindingDelegate.OnScriptCallback));
				}
				FKeyBindingDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FKeyBindingDelegate.RegisterId);
		}

		// Token: 0x06017662 RID: 95842 RVA: 0x00223668 File Offset: 0x00221868
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(FKey Key)
		{
			FKeyBindingDelegate.__FKeyBindingDelegate_DelegateParams* ptr = stackalloc FKeyBindingDelegate.__FKeyBindingDelegate_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FKeyBindingDelegate.__FKeyBindingDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKeyBindingDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FKeyBindingDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06017663 RID: 95843 RVA: 0x002236D4 File Offset: 0x002218D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FKey> action = target as Action<FKey>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FKey obj = new FKey(&((FKeyBindingDelegate.__FKeyBindingDelegate_DelegateParams*)__Parameters)->Key, true, true);
			action(obj);
		}

		// Token: 0x0400CBA6 RID: 52134
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400CBA7 RID: 52135
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.KeyBindingDelegate__DelegateSignature";

		// Token: 0x0400CBA8 RID: 52136
		private static int RegisterId;

		// Token: 0x02002FAD RID: 12205
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FKeyBindingDelegate_DelegateParams
		{
			// Token: 0x04016B90 RID: 93072
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02002FAE RID: 12206
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016B91 RID: 93073
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
