using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200048F RID: 1167
	public sealed class FTestUdpResultDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006D91 RID: 28049 RVA: 0x000A05EA File Offset: 0x0009E7EA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FTestUdpResultDelegate.StaticFunctionPtr();
		}

		// Token: 0x06006D92 RID: 28050 RVA: 0x000A05F6 File Offset: 0x0009E7F6
		private static IntPtr StaticFunctionPtr()
		{
			if (FTestUdpResultDelegate._FunctionPtr == IntPtr.Zero)
			{
				FTestUdpResultDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroNetwork.TestUdpResultDelegate__DelegateSignature");
			}
			return FTestUdpResultDelegate._FunctionPtr;
		}

		// Token: 0x06006D93 RID: 28051 RVA: 0x000A0619 File Offset: 0x0009E819
		public FTestUdpResultDelegate()
		{
		}

		// Token: 0x06006D94 RID: 28052 RVA: 0x000A0621 File Offset: 0x0009E821
		[NullableContext(2)]
		public FTestUdpResultDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006D95 RID: 28053 RVA: 0x000A062B File Offset: 0x0009E82B
		public FTestUdpResultDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006D96 RID: 28054 RVA: 0x000A0636 File Offset: 0x0009E836
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, int>) ?? ((Action<int, int>)Delegate.CreateDelegate(typeof(Action<int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006D97 RID: 28055 RVA: 0x000A0668 File Offset: 0x0009E868
		[NullableContext(1)]
		public void Bind(Action<int, int> Callback)
		{
			if (FTestUdpResultDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FTestUdpResultDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FTestUdpResultDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FTestUdpResultDelegate.OnScriptCallback));
				}
				FTestUdpResultDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FTestUdpResultDelegate.RegisterId);
		}

		// Token: 0x06006D98 RID: 28056 RVA: 0x000A06A4 File Offset: 0x0009E8A4
		[SkipLocalsInit]
		public unsafe void Execute(int SuccessCount, int ErrorCode)
		{
			FTestUdpResultDelegate.__FTestUdpResultDelegate_DelegateParams* ptr = stackalloc FTestUdpResultDelegate.__FTestUdpResultDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FTestUdpResultDelegate.__FTestUdpResultDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FTestUdpResultDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->SuccessCount = SuccessCount;
			ptr->ErrorCode = ErrorCode;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06006D99 RID: 28057 RVA: 0x000A06E8 File Offset: 0x0009E8E8
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, int> action = target as Action<int, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FTestUdpResultDelegate.__FTestUdpResultDelegate_DelegateParams*)__Parameters)->SuccessCount, ((FTestUdpResultDelegate.__FTestUdpResultDelegate_DelegateParams*)__Parameters)->ErrorCode);
		}

		// Token: 0x04002EBE RID: 11966
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002EBF RID: 11967
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroNetwork.TestUdpResultDelegate__DelegateSignature";

		// Token: 0x04002EC0 RID: 11968
		private static int RegisterId;

		// Token: 0x02000BA0 RID: 2976
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FTestUdpResultDelegate_DelegateParams
		{
			// Token: 0x04005D25 RID: 23845
			[FieldOffset(0)]
			public int SuccessCount;

			// Token: 0x04005D26 RID: 23846
			[FieldOffset(4)]
			public int ErrorCode;
		}

		// Token: 0x02000BA1 RID: 2977
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005D27 RID: 23847
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
