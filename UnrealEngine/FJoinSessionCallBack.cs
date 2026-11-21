using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005C8 RID: 1480
	public sealed class FJoinSessionCallBack : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060083A9 RID: 33705 RVA: 0x000C2F0F File Offset: 0x000C110F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FJoinSessionCallBack.StaticFunctionPtr();
		}

		// Token: 0x060083AA RID: 33706 RVA: 0x000C2F1B File Offset: 0x000C111B
		private static IntPtr StaticFunctionPtr()
		{
			if (FJoinSessionCallBack._FunctionPtr == IntPtr.Zero)
			{
				FJoinSessionCallBack._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.JoinSessionCallBack__DelegateSignature");
			}
			return FJoinSessionCallBack._FunctionPtr;
		}

		// Token: 0x060083AB RID: 33707 RVA: 0x000C2F3E File Offset: 0x000C113E
		public FJoinSessionCallBack()
		{
		}

		// Token: 0x060083AC RID: 33708 RVA: 0x000C2F46 File Offset: 0x000C1146
		[NullableContext(2)]
		public FJoinSessionCallBack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060083AD RID: 33709 RVA: 0x000C2F50 File Offset: 0x000C1150
		public FJoinSessionCallBack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060083AE RID: 33710 RVA: 0x000C2F5B File Offset: 0x000C115B
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string, string>) ?? ((Action<string, string>)Delegate.CreateDelegate(typeof(Action<string, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060083AF RID: 33711 RVA: 0x000C2F8D File Offset: 0x000C118D
		[NullableContext(1)]
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

		// Token: 0x060083B0 RID: 33712 RVA: 0x000C2FC8 File Offset: 0x000C11C8
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Execute(string userId, string playerSessionId)
		{
			FJoinSessionCallBack.__FJoinSessionCallBack_DelegateParams* ptr = stackalloc FJoinSessionCallBack.__FJoinSessionCallBack_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FJoinSessionCallBack.__FJoinSessionCallBack_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FJoinSessionCallBack.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->userId), userId);
			FString.CopyFrom((void*)(&ptr->playerSessionId), playerSessionId);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FJoinSessionCallBack._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060083B1 RID: 33713 RVA: 0x000C302C File Offset: 0x000C122C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04003979 RID: 14713
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400397A RID: 14714
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.JoinSessionCallBack__DelegateSignature";

		// Token: 0x0400397B RID: 14715
		private static int RegisterId;

		// Token: 0x02000D45 RID: 3397
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		private ref struct __FJoinSessionCallBack_DelegateParams
		{
			// Token: 0x04005FE2 RID: 24546
			[FieldOffset(0)]
			public FString userId;

			// Token: 0x04005FE3 RID: 24547
			[FieldOffset(16)]
			public FString playerSessionId;
		}

		// Token: 0x02000D46 RID: 3398
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005FE4 RID: 24548
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
