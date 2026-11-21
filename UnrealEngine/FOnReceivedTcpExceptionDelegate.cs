using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200048C RID: 1164
	public sealed class FOnReceivedTcpExceptionDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006D76 RID: 28022 RVA: 0x000A01CC File Offset: 0x0009E3CC
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnReceivedTcpExceptionDelegate.StaticFunctionPtr();
		}

		// Token: 0x06006D77 RID: 28023 RVA: 0x000A01D8 File Offset: 0x0009E3D8
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnReceivedTcpExceptionDelegate._FunctionPtr == IntPtr.Zero)
			{
				FOnReceivedTcpExceptionDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroNetwork.OnReceivedTcpExceptionDelegate__DelegateSignature");
			}
			return FOnReceivedTcpExceptionDelegate._FunctionPtr;
		}

		// Token: 0x06006D78 RID: 28024 RVA: 0x000A01FB File Offset: 0x0009E3FB
		public FOnReceivedTcpExceptionDelegate()
		{
		}

		// Token: 0x06006D79 RID: 28025 RVA: 0x000A0203 File Offset: 0x0009E403
		[NullableContext(2)]
		public FOnReceivedTcpExceptionDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006D7A RID: 28026 RVA: 0x000A020D File Offset: 0x0009E40D
		public FOnReceivedTcpExceptionDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006D7B RID: 28027 RVA: 0x000A0218 File Offset: 0x0009E418
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<uint>) ?? ((Action<uint>)Delegate.CreateDelegate(typeof(Action<uint>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006D7C RID: 28028 RVA: 0x000A024A File Offset: 0x0009E44A
		[NullableContext(1)]
		public void Bind(Action<uint> Callback)
		{
			if (FOnReceivedTcpExceptionDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnReceivedTcpExceptionDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnReceivedTcpExceptionDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnReceivedTcpExceptionDelegate.OnScriptCallback));
				}
				FOnReceivedTcpExceptionDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnReceivedTcpExceptionDelegate.RegisterId);
		}

		// Token: 0x06006D7D RID: 28029 RVA: 0x000A0284 File Offset: 0x0009E484
		[SkipLocalsInit]
		public unsafe void Execute(uint ErrorCode)
		{
			FOnReceivedTcpExceptionDelegate.__FOnReceivedTcpExceptionDelegate_DelegateParams* ptr = stackalloc FOnReceivedTcpExceptionDelegate.__FOnReceivedTcpExceptionDelegate_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FOnReceivedTcpExceptionDelegate.__FOnReceivedTcpExceptionDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnReceivedTcpExceptionDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ErrorCode = ErrorCode;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06006D7E RID: 28030 RVA: 0x000A02C4 File Offset: 0x0009E4C4
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<uint> action = target as Action<uint>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnReceivedTcpExceptionDelegate.__FOnReceivedTcpExceptionDelegate_DelegateParams*)__Parameters)->ErrorCode);
		}

		// Token: 0x04002EB5 RID: 11957
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002EB6 RID: 11958
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroNetwork.OnReceivedTcpExceptionDelegate__DelegateSignature";

		// Token: 0x04002EB7 RID: 11959
		private static int RegisterId;

		// Token: 0x02000B9A RID: 2970
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FOnReceivedTcpExceptionDelegate_DelegateParams
		{
			// Token: 0x04005D1B RID: 23835
			[FieldOffset(0)]
			public uint ErrorCode;
		}

		// Token: 0x02000B9B RID: 2971
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005D1C RID: 23836
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
