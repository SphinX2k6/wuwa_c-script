using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005F1 RID: 1521
	public sealed class FOnApplicationLifeTime : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008755 RID: 34645 RVA: 0x000CB043 File Offset: 0x000C9243
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnApplicationLifeTime.StaticFunctionPtr();
		}

		// Token: 0x06008756 RID: 34646 RVA: 0x000CB04F File Offset: 0x000C924F
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnApplicationLifeTime._FunctionPtr == IntPtr.Zero)
			{
				FOnApplicationLifeTime._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OnApplicationLifeTime__DelegateSignature");
			}
			return FOnApplicationLifeTime._FunctionPtr;
		}

		// Token: 0x06008757 RID: 34647 RVA: 0x000CB072 File Offset: 0x000C9272
		public FOnApplicationLifeTime()
		{
		}

		// Token: 0x06008758 RID: 34648 RVA: 0x000CB07A File Offset: 0x000C927A
		[NullableContext(2)]
		public FOnApplicationLifeTime(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008759 RID: 34649 RVA: 0x000CB084 File Offset: 0x000C9284
		public FOnApplicationLifeTime(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600875A RID: 34650 RVA: 0x000CB08F File Offset: 0x000C928F
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600875B RID: 34651 RVA: 0x000CB0C1 File Offset: 0x000C92C1
		[NullableContext(1)]
		public void Bind(Action<int> Callback)
		{
			if (FOnApplicationLifeTime.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnApplicationLifeTime.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnApplicationLifeTime.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnApplicationLifeTime.OnScriptCallback));
				}
				FOnApplicationLifeTime.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnApplicationLifeTime.RegisterId);
		}

		// Token: 0x0600875C RID: 34652 RVA: 0x000CB0FC File Offset: 0x000C92FC
		[SkipLocalsInit]
		public unsafe void Execute(int Type)
		{
			FOnApplicationLifeTime.__FOnApplicationLifeTime_DelegateParams* ptr = stackalloc FOnApplicationLifeTime.__FOnApplicationLifeTime_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FOnApplicationLifeTime.__FOnApplicationLifeTime_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnApplicationLifeTime.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Type = Type;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600875D RID: 34653 RVA: 0x000CB13C File Offset: 0x000C933C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnApplicationLifeTime.__FOnApplicationLifeTime_DelegateParams*)__Parameters)->Type);
		}

		// Token: 0x04003ADE RID: 15070
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003ADF RID: 15071
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OnApplicationLifeTime__DelegateSignature";

		// Token: 0x04003AE0 RID: 15072
		private static int RegisterId;

		// Token: 0x02000DFD RID: 3581
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FOnApplicationLifeTime_DelegateParams
		{
			// Token: 0x04006191 RID: 24977
			[FieldOffset(0)]
			public int Type;
		}

		// Token: 0x02000DFE RID: 3582
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006192 RID: 24978
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
