using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001820 RID: 6176
	public sealed class FHttpResponseRuntimeHandler : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06016D05 RID: 93445 RVA: 0x00214C87 File Offset: 0x00212E87
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FHttpResponseRuntimeHandler.StaticFunctionPtr();
		}

		// Token: 0x06016D06 RID: 93446 RVA: 0x00214C93 File Offset: 0x00212E93
		private static IntPtr StaticFunctionPtr()
		{
			if (FHttpResponseRuntimeHandler._FunctionPtr == IntPtr.Zero)
			{
				FHttpResponseRuntimeHandler._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroEditorRuntime.HttpResponseRuntimeHandler__DelegateSignature");
			}
			return FHttpResponseRuntimeHandler._FunctionPtr;
		}

		// Token: 0x06016D07 RID: 93447 RVA: 0x00214CB6 File Offset: 0x00212EB6
		public FHttpResponseRuntimeHandler()
		{
		}

		// Token: 0x06016D08 RID: 93448 RVA: 0x00214CBE File Offset: 0x00212EBE
		[NullableContext(2)]
		public FHttpResponseRuntimeHandler(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016D09 RID: 93449 RVA: 0x00214CC8 File Offset: 0x00212EC8
		public FHttpResponseRuntimeHandler(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016D0A RID: 93450 RVA: 0x00214CD3 File Offset: 0x00212ED3
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool, int, string>) ?? ((Action<bool, int, string>)Delegate.CreateDelegate(typeof(Action<bool, int, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06016D0B RID: 93451 RVA: 0x00214D05 File Offset: 0x00212F05
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06016D0C RID: 93452 RVA: 0x00214D40 File Offset: 0x00212F40
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06016D0D RID: 93453 RVA: 0x00214DA4 File Offset: 0x00212FA4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400C64B RID: 50763
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400C64C RID: 50764
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroEditorRuntime.HttpResponseRuntimeHandler__DelegateSignature";

		// Token: 0x0400C64D RID: 50765
		private static int RegisterId;

		// Token: 0x02002F5D RID: 12125
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FHttpResponseRuntimeHandler_DelegateParams
		{
			// Token: 0x04016B11 RID: 92945
			[FieldOffset(0)]
			public bool Success;

			// Token: 0x04016B12 RID: 92946
			[FieldOffset(4)]
			public int Code;

			// Token: 0x04016B13 RID: 92947
			[FieldOffset(8)]
			public FString Data;
		}

		// Token: 0x02002F5E RID: 12126
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016B14 RID: 92948
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
