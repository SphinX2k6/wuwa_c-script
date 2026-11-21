using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003E0 RID: 992
	public sealed class FKuroEffectBeforeInitCallback : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600615F RID: 24927 RVA: 0x0008B33D File Offset: 0x0008953D
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroEffectBeforeInitCallback.StaticFunctionPtr();
		}

		// Token: 0x06006160 RID: 24928 RVA: 0x0008B349 File Offset: 0x00089549
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroEffectBeforeInitCallback._FunctionPtr == IntPtr.Zero)
			{
				FKuroEffectBeforeInitCallback._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.KuroEffectBeforeInitCallback__DelegateSignature");
			}
			return FKuroEffectBeforeInitCallback._FunctionPtr;
		}

		// Token: 0x06006161 RID: 24929 RVA: 0x0008B36C File Offset: 0x0008956C
		public FKuroEffectBeforeInitCallback()
		{
		}

		// Token: 0x06006162 RID: 24930 RVA: 0x0008B374 File Offset: 0x00089574
		[NullableContext(2)]
		public FKuroEffectBeforeInitCallback(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006163 RID: 24931 RVA: 0x0008B37E File Offset: 0x0008957E
		public FKuroEffectBeforeInitCallback(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006164 RID: 24932 RVA: 0x0008B389 File Offset: 0x00089589
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006165 RID: 24933 RVA: 0x0008B3BB File Offset: 0x000895BB
		[NullableContext(1)]
		public void Bind(Action<int> Callback)
		{
			if (FKuroEffectBeforeInitCallback.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroEffectBeforeInitCallback.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroEffectBeforeInitCallback.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroEffectBeforeInitCallback.OnScriptCallback));
				}
				FKuroEffectBeforeInitCallback.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FKuroEffectBeforeInitCallback.RegisterId);
		}

		// Token: 0x06006166 RID: 24934 RVA: 0x0008B3F8 File Offset: 0x000895F8
		[SkipLocalsInit]
		public unsafe void Execute(int Handle)
		{
			FKuroEffectBeforeInitCallback.__FKuroEffectBeforeInitCallback_DelegateParams* ptr = stackalloc FKuroEffectBeforeInitCallback.__FKuroEffectBeforeInitCallback_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FKuroEffectBeforeInitCallback.__FKuroEffectBeforeInitCallback_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroEffectBeforeInitCallback.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Handle = Handle;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06006167 RID: 24935 RVA: 0x0008B438 File Offset: 0x00089638
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FKuroEffectBeforeInitCallback.__FKuroEffectBeforeInitCallback_DelegateParams*)__Parameters)->Handle);
		}

		// Token: 0x04002987 RID: 10631
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002988 RID: 10632
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.KuroEffectBeforeInitCallback__DelegateSignature";

		// Token: 0x04002989 RID: 10633
		private static int RegisterId;

		// Token: 0x02000AD3 RID: 2771
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FKuroEffectBeforeInitCallback_DelegateParams
		{
			// Token: 0x04005B50 RID: 23376
			[FieldOffset(0)]
			public int Handle;
		}

		// Token: 0x02000AD4 RID: 2772
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005B51 RID: 23377
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
