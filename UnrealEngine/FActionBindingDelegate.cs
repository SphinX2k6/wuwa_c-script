using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003AD RID: 941
	public sealed class FActionBindingDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06005D0D RID: 23821 RVA: 0x00082F27 File Offset: 0x00081127
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FActionBindingDelegate.StaticFunctionPtr();
		}

		// Token: 0x06005D0E RID: 23822 RVA: 0x00082F33 File Offset: 0x00081133
		private static IntPtr StaticFunctionPtr()
		{
			if (FActionBindingDelegate._FunctionPtr == IntPtr.Zero)
			{
				FActionBindingDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.ActionBindingDelegate__DelegateSignature");
			}
			return FActionBindingDelegate._FunctionPtr;
		}

		// Token: 0x06005D0F RID: 23823 RVA: 0x00082F56 File Offset: 0x00081156
		public FActionBindingDelegate()
		{
		}

		// Token: 0x06005D10 RID: 23824 RVA: 0x00082F5E File Offset: 0x0008115E
		[NullableContext(2)]
		public FActionBindingDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005D11 RID: 23825 RVA: 0x00082F68 File Offset: 0x00081168
		public FActionBindingDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005D12 RID: 23826 RVA: 0x00082F73 File Offset: 0x00081173
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FKey>) ?? ((Action<FKey>)Delegate.CreateDelegate(typeof(Action<FKey>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06005D13 RID: 23827 RVA: 0x00082FA5 File Offset: 0x000811A5
		[NullableContext(1)]
		public void Bind(Action<FKey> Callback)
		{
			if (FActionBindingDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FActionBindingDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FActionBindingDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FActionBindingDelegate.OnScriptCallback));
				}
				FActionBindingDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FActionBindingDelegate.RegisterId);
		}

		// Token: 0x06005D14 RID: 23828 RVA: 0x00082FE0 File Offset: 0x000811E0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute(FKey Key)
		{
			FActionBindingDelegate.__FActionBindingDelegate_DelegateParams* ptr = stackalloc FActionBindingDelegate.__FActionBindingDelegate_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FActionBindingDelegate.__FActionBindingDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FActionBindingDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FActionBindingDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06005D15 RID: 23829 RVA: 0x0008304C File Offset: 0x0008124C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FKey> action = target as Action<FKey>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FKey obj = new FKey(&((FActionBindingDelegate.__FActionBindingDelegate_DelegateParams*)__Parameters)->Key, true, true);
			action(obj);
		}

		// Token: 0x040026CC RID: 9932
		internal static IntPtr _FunctionPtr;

		// Token: 0x040026CD RID: 9933
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.ActionBindingDelegate__DelegateSignature";

		// Token: 0x040026CE RID: 9934
		private static int RegisterId;

		// Token: 0x02000AA5 RID: 2725
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		private ref struct __FActionBindingDelegate_DelegateParams
		{
			// Token: 0x04005AFF RID: 23295
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x02000AA6 RID: 2726
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005B00 RID: 23296
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
