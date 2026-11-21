using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003E1 RID: 993
	public sealed class FKuroEffectBeforePlayCallback : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006168 RID: 24936 RVA: 0x0008B482 File Offset: 0x00089682
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FKuroEffectBeforePlayCallback.StaticFunctionPtr();
		}

		// Token: 0x06006169 RID: 24937 RVA: 0x0008B48E File Offset: 0x0008968E
		private static IntPtr StaticFunctionPtr()
		{
			if (FKuroEffectBeforePlayCallback._FunctionPtr == IntPtr.Zero)
			{
				FKuroEffectBeforePlayCallback._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.KuroEffectBeforePlayCallback__DelegateSignature");
			}
			return FKuroEffectBeforePlayCallback._FunctionPtr;
		}

		// Token: 0x0600616A RID: 24938 RVA: 0x0008B4B1 File Offset: 0x000896B1
		public FKuroEffectBeforePlayCallback()
		{
		}

		// Token: 0x0600616B RID: 24939 RVA: 0x0008B4B9 File Offset: 0x000896B9
		[NullableContext(2)]
		public FKuroEffectBeforePlayCallback(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600616C RID: 24940 RVA: 0x0008B4C3 File Offset: 0x000896C3
		public FKuroEffectBeforePlayCallback(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600616D RID: 24941 RVA: 0x0008B4CE File Offset: 0x000896CE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600616E RID: 24942 RVA: 0x0008B500 File Offset: 0x00089700
		[NullableContext(1)]
		public void Bind(Action<int> Callback)
		{
			if (FKuroEffectBeforePlayCallback.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FKuroEffectBeforePlayCallback.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FKuroEffectBeforePlayCallback.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FKuroEffectBeforePlayCallback.OnScriptCallback));
				}
				FKuroEffectBeforePlayCallback.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FKuroEffectBeforePlayCallback.RegisterId);
		}

		// Token: 0x0600616F RID: 24943 RVA: 0x0008B53C File Offset: 0x0008973C
		[SkipLocalsInit]
		public unsafe void Execute(int Handle)
		{
			FKuroEffectBeforePlayCallback.__FKuroEffectBeforePlayCallback_DelegateParams* ptr = stackalloc FKuroEffectBeforePlayCallback.__FKuroEffectBeforePlayCallback_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FKuroEffectBeforePlayCallback.__FKuroEffectBeforePlayCallback_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FKuroEffectBeforePlayCallback.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Handle = Handle;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06006170 RID: 24944 RVA: 0x0008B57C File Offset: 0x0008977C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FKuroEffectBeforePlayCallback.__FKuroEffectBeforePlayCallback_DelegateParams*)__Parameters)->Handle);
		}

		// Token: 0x0400298A RID: 10634
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400298B RID: 10635
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.KuroEffectBeforePlayCallback__DelegateSignature";

		// Token: 0x0400298C RID: 10636
		private static int RegisterId;

		// Token: 0x02000AD5 RID: 2773
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FKuroEffectBeforePlayCallback_DelegateParams
		{
			// Token: 0x04005B52 RID: 23378
			[FieldOffset(0)]
			public int Handle;
		}

		// Token: 0x02000AD6 RID: 2774
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005B53 RID: 23379
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
