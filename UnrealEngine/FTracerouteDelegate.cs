using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000490 RID: 1168
	public sealed class FTracerouteDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006D9A RID: 28058 RVA: 0x000A0738 File Offset: 0x0009E938
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FTracerouteDelegate.StaticFunctionPtr();
		}

		// Token: 0x06006D9B RID: 28059 RVA: 0x000A0744 File Offset: 0x0009E944
		private static IntPtr StaticFunctionPtr()
		{
			if (FTracerouteDelegate._FunctionPtr == IntPtr.Zero)
			{
				FTracerouteDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroNetwork.TracerouteDelegate__DelegateSignature");
			}
			return FTracerouteDelegate._FunctionPtr;
		}

		// Token: 0x06006D9C RID: 28060 RVA: 0x000A0767 File Offset: 0x0009E967
		public FTracerouteDelegate()
		{
		}

		// Token: 0x06006D9D RID: 28061 RVA: 0x000A076F File Offset: 0x0009E96F
		[NullableContext(2)]
		public FTracerouteDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006D9E RID: 28062 RVA: 0x000A0779 File Offset: 0x0009E979
		public FTracerouteDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006D9F RID: 28063 RVA: 0x000A0784 File Offset: 0x0009E984
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006DA0 RID: 28064 RVA: 0x000A07B6 File Offset: 0x0009E9B6
		[NullableContext(1)]
		public void Bind(Action<bool> Callback)
		{
			if (FTracerouteDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FTracerouteDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FTracerouteDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FTracerouteDelegate.OnScriptCallback));
				}
				FTracerouteDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FTracerouteDelegate.RegisterId);
		}

		// Token: 0x06006DA1 RID: 28065 RVA: 0x000A07F0 File Offset: 0x0009E9F0
		[SkipLocalsInit]
		public unsafe void Execute(bool IsReached)
		{
			FTracerouteDelegate.__FTracerouteDelegate_DelegateParams* ptr = stackalloc FTracerouteDelegate.__FTracerouteDelegate_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FTracerouteDelegate.__FTracerouteDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FTracerouteDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->IsReached = IsReached;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06006DA2 RID: 28066 RVA: 0x000A0830 File Offset: 0x0009EA30
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FTracerouteDelegate.__FTracerouteDelegate_DelegateParams*)__Parameters)->IsReached);
		}

		// Token: 0x04002EC1 RID: 11969
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002EC2 RID: 11970
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroNetwork.TracerouteDelegate__DelegateSignature";

		// Token: 0x04002EC3 RID: 11971
		private static int RegisterId;

		// Token: 0x02000BA2 RID: 2978
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		private ref struct __FTracerouteDelegate_DelegateParams
		{
			// Token: 0x04005D28 RID: 23848
			[FieldOffset(0)]
			public bool IsReached;
		}

		// Token: 0x02000BA3 RID: 2979
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005D29 RID: 23849
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
