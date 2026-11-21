using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000375 RID: 885
	public sealed class FHttpResponseRuntimeHandler : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060059CB RID: 22987 RVA: 0x0007EBEE File Offset: 0x0007CDEE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FHttpResponseRuntimeHandler.StaticFunctionPtr();
		}

		// Token: 0x060059CC RID: 22988 RVA: 0x0007EBFA File Offset: 0x0007CDFA
		private static IntPtr StaticFunctionPtr()
		{
			if (FHttpResponseRuntimeHandler._FunctionPtr == IntPtr.Zero)
			{
				FHttpResponseRuntimeHandler._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroEditorRuntime.HttpResponseRuntimeHandler__DelegateSignature");
			}
			return FHttpResponseRuntimeHandler._FunctionPtr;
		}

		// Token: 0x060059CD RID: 22989 RVA: 0x0007EC1D File Offset: 0x0007CE1D
		public FHttpResponseRuntimeHandler()
		{
		}

		// Token: 0x060059CE RID: 22990 RVA: 0x0007EC25 File Offset: 0x0007CE25
		[NullableContext(2)]
		public FHttpResponseRuntimeHandler(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060059CF RID: 22991 RVA: 0x0007EC2F File Offset: 0x0007CE2F
		public FHttpResponseRuntimeHandler(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060059D0 RID: 22992 RVA: 0x0007EC3A File Offset: 0x0007CE3A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool, int, string>) ?? ((Action<bool, int, string>)Delegate.CreateDelegate(typeof(Action<bool, int, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060059D1 RID: 22993 RVA: 0x0007EC6C File Offset: 0x0007CE6C
		[NullableContext(1)]
		public void Bind(Action<bool, int, string> Callback)
		{
			if (FHttpResponseRuntimeHandler.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FHttpResponseRuntimeHandler.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FHttpResponseRuntimeHandler.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FHttpResponseRuntimeHandler.OnScriptCallback));
				}
				FHttpResponseRuntimeHandler.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FHttpResponseRuntimeHandler.RegisterId);
		}

		// Token: 0x060059D2 RID: 22994 RVA: 0x0007ECA8 File Offset: 0x0007CEA8
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Execute(bool Success, int Code, string Data)
		{
			FHttpResponseRuntimeHandler.__FHttpResponseRuntimeHandler_DelegateParams* ptr = stackalloc FHttpResponseRuntimeHandler.__FHttpResponseRuntimeHandler_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FHttpResponseRuntimeHandler.__FHttpResponseRuntimeHandler_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FHttpResponseRuntimeHandler.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Success = Success;
			ptr->Code = Code;
			FString.CopyFrom((void*)(&ptr->Data), Data);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FHttpResponseRuntimeHandler._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060059D3 RID: 22995 RVA: 0x0007ED0C File Offset: 0x0007CF0C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool, int, string> action = target as Action<bool, int, string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FHttpResponseRuntimeHandler.__FHttpResponseRuntimeHandler_DelegateParams*)__Parameters)->Data));
			action(((FHttpResponseRuntimeHandler.__FHttpResponseRuntimeHandler_DelegateParams*)__Parameters)->Success, ((FHttpResponseRuntimeHandler.__FHttpResponseRuntimeHandler_DelegateParams*)__Parameters)->Code, arg);
		}

		// Token: 0x04002541 RID: 9537
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002542 RID: 9538
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroEditorRuntime.HttpResponseRuntimeHandler__DelegateSignature";

		// Token: 0x04002543 RID: 9539
		private static int RegisterId;

		// Token: 0x02000A86 RID: 2694
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FHttpResponseRuntimeHandler_DelegateParams
		{
			// Token: 0x04005AD3 RID: 23251
			[FieldOffset(0)]
			public bool Success;

			// Token: 0x04005AD4 RID: 23252
			[FieldOffset(4)]
			public int Code;

			// Token: 0x04005AD5 RID: 23253
			[FieldOffset(8)]
			public FString Data;
		}

		// Token: 0x02000A87 RID: 2695
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005AD6 RID: 23254
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
