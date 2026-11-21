using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003D7 RID: 983
	public sealed class FKeyBindingDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060060EE RID: 24814 RVA: 0x0008A78F File Offset: 0x0008898F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKeyBindingDelegate.StaticFunctionPtr();
		}

		// Token: 0x060060EF RID: 24815 RVA: 0x0008A79B File Offset: 0x0008899B
		private static IntPtr StaticFunctionPtr()
		{
			if (FKeyBindingDelegate._FunctionPtr == IntPtr.Zero)
			{
				FKeyBindingDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.KeyBindingDelegate__DelegateSignature");
			}
			return FKeyBindingDelegate._FunctionPtr;
		}

		// Token: 0x060060F0 RID: 24816 RVA: 0x0008A7BE File Offset: 0x000889BE
		public FKeyBindingDelegate()
		{
		}

		// Token: 0x060060F1 RID: 24817 RVA: 0x0008A7C6 File Offset: 0x000889C6
		[NullableContext(2)]
		public FKeyBindingDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060060F2 RID: 24818 RVA: 0x0008A7D0 File Offset: 0x000889D0
		public FKeyBindingDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060060F3 RID: 24819 RVA: 0x0008A7DB File Offset: 0x000889DB
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FKey>) ?? ((Action<FKey>)Delegate.CreateDelegate(typeof(Action<FKey>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060060F4 RID: 24820 RVA: 0x0008A80D File Offset: 0x00088A0D
		[NullableContext(1)]
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

		// Token: 0x060060F5 RID: 24821 RVA: 0x0008A848 File Offset: 0x00088A48
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x060060F6 RID: 24822 RVA: 0x0008A8B4 File Offset: 0x00088AB4
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04002952 RID: 10578
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002953 RID: 10579
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.KeyBindingDelegate__DelegateSignature";

		// Token: 0x04002954 RID: 10580
		private static int RegisterId;

		// Token: 0x02000AD0 RID: 2768
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		private ref struct __FKeyBindingDelegate_DelegateParams
		{
			// Token: 0x04005B4D RID: 23373
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02000AD1 RID: 2769
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005B4E RID: 23374
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
