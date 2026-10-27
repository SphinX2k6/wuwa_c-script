using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EA5 RID: 7845
	public sealed class FJoinSessionCallBack : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DCA8 RID: 122024 RVA: 0x002C0743 File Offset: 0x002BE943
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FJoinSessionCallBack.StaticFunctionPtr();
		}

		// Token: 0x0601DCA9 RID: 122025 RVA: 0x002C074F File Offset: 0x002BE94F
		private static IntPtr StaticFunctionPtr()
		{
			if (FJoinSessionCallBack._FunctionPtr == IntPtr.Zero)
			{
				FJoinSessionCallBack._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.JoinSessionCallBack__DelegateSignature");
			}
			return FJoinSessionCallBack._FunctionPtr;
		}

		// Token: 0x0601DCAA RID: 122026 RVA: 0x002C0772 File Offset: 0x002BE972
		public FJoinSessionCallBack()
		{
		}

		// Token: 0x0601DCAB RID: 122027 RVA: 0x002C077A File Offset: 0x002BE97A
		[NullableContext(2)]
		public FJoinSessionCallBack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DCAC RID: 122028 RVA: 0x002C0784 File Offset: 0x002BE984
		public FJoinSessionCallBack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DCAD RID: 122029 RVA: 0x002C078F File Offset: 0x002BE98F
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string, string>) ?? ((Action<string, string>)Delegate.CreateDelegate(typeof(Action<string, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DCAE RID: 122030 RVA: 0x002C07C1 File Offset: 0x002BE9C1
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<string, string> Callback)
		{
			if (FJoinSessionCallBack.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FJoinSessionCallBack.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FJoinSessionCallBack.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FJoinSessionCallBack.OnScriptCallback));
				}
				FJoinSessionCallBack.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FJoinSessionCallBack.RegisterId);
		}

		// Token: 0x0601DCAF RID: 122031 RVA: 0x002C07FC File Offset: 0x002BE9FC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(string userId, string playerSessionId)
		{
			FJoinSessionCallBack.__FJoinSessionCallBack_DelegateParams* ptr = stackalloc FJoinSessionCallBack.__FJoinSessionCallBack_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FJoinSessionCallBack.__FJoinSessionCallBack_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FJoinSessionCallBack.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->userId), userId);
			FString.CopyFrom((void*)(&ptr->playerSessionId), playerSessionId);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FJoinSessionCallBack._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DCB0 RID: 122032 RVA: 0x002C0860 File Offset: 0x002BEA60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string, string> action = target as Action<string, string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FJoinSessionCallBack.__FJoinSessionCallBack_DelegateParams*)__Parameters)->userId));
			string arg2 = FString.ToString((void*)(&((FJoinSessionCallBack.__FJoinSessionCallBack_DelegateParams*)__Parameters)->playerSessionId));
			action(arg, arg2);
		}

		// Token: 0x04010242 RID: 66114
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010243 RID: 66115
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.JoinSessionCallBack__DelegateSignature";

		// Token: 0x04010244 RID: 66116
		private static int RegisterId;

		// Token: 0x020032EB RID: 13035
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FJoinSessionCallBack_DelegateParams
		{
			// Token: 0x0401719B RID: 94619
			[FieldOffset(0)]
			public FString userId;

			// Token: 0x0401719C RID: 94620
			[FieldOffset(16)]
			public FString playerSessionId;
		}

		// Token: 0x020032EC RID: 13036
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401719D RID: 94621
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
