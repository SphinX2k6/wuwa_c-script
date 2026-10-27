using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C94 RID: 7316
	public sealed class FPluginCallback : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601C6AD RID: 116397 RVA: 0x0029F739 File Offset: 0x0029D939
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FPluginCallback.StaticFunctionPtr();
		}

		// Token: 0x0601C6AE RID: 116398 RVA: 0x0029F745 File Offset: 0x0029D945
		private static IntPtr StaticFunctionPtr()
		{
			if (FPluginCallback._FunctionPtr == IntPtr.Zero)
			{
				FPluginCallback._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSDK.PluginCallback__DelegateSignature");
			}
			return FPluginCallback._FunctionPtr;
		}

		// Token: 0x0601C6AF RID: 116399 RVA: 0x0029F768 File Offset: 0x0029D968
		public FPluginCallback()
		{
		}

		// Token: 0x0601C6B0 RID: 116400 RVA: 0x0029F770 File Offset: 0x0029D970
		[NullableContext(2)]
		public FPluginCallback(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C6B1 RID: 116401 RVA: 0x0029F77A File Offset: 0x0029D97A
		public FPluginCallback(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C6B2 RID: 116402 RVA: 0x0029F785 File Offset: 0x0029D985
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601C6B3 RID: 116403 RVA: 0x0029F7B7 File Offset: 0x0029D9B7
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<string> Callback)
		{
			if (FPluginCallback.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FPluginCallback.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FPluginCallback.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FPluginCallback.OnScriptCallback));
				}
				FPluginCallback.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FPluginCallback.RegisterId);
		}

		// Token: 0x0601C6B4 RID: 116404 RVA: 0x0029F7F4 File Offset: 0x0029D9F4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(string Result)
		{
			FPluginCallback.__FPluginCallback_DelegateParams* ptr = stackalloc FPluginCallback.__FPluginCallback_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FPluginCallback.__FPluginCallback_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FPluginCallback.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Result), Result);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FPluginCallback._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C6B5 RID: 116405 RVA: 0x0029F848 File Offset: 0x0029DA48
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string> action = target as Action<string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string obj = FString.ToString((void*)(&((FPluginCallback.__FPluginCallback_DelegateParams*)__Parameters)->Result));
			action(obj);
		}

		// Token: 0x0400F49D RID: 62621
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F49E RID: 62622
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSDK.PluginCallback__DelegateSignature";

		// Token: 0x0400F49F RID: 62623
		private static int RegisterId;

		// Token: 0x0200325C RID: 12892
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FPluginCallback_DelegateParams
		{
			// Token: 0x040170DD RID: 94429
			[FieldOffset(0)]
			public FString Result;
		}

		// Token: 0x0200325D RID: 12893
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040170DE RID: 94430
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
