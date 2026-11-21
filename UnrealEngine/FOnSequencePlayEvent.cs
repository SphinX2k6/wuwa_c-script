using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006D3 RID: 1747
	public sealed class FOnSequencePlayEvent : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060094C9 RID: 38089 RVA: 0x000E06D1 File Offset: 0x000DE8D1
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnSequencePlayEvent.StaticFunctionPtr();
		}

		// Token: 0x060094CA RID: 38090 RVA: 0x000E06DD File Offset: 0x000DE8DD
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnSequencePlayEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnSequencePlayEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.OnSequencePlayEvent__DelegateSignature");
			}
			return FOnSequencePlayEvent._FunctionPtr;
		}

		// Token: 0x060094CB RID: 38091 RVA: 0x000E0700 File Offset: 0x000DE900
		public FOnSequencePlayEvent()
		{
		}

		// Token: 0x060094CC RID: 38092 RVA: 0x000E0708 File Offset: 0x000DE908
		[NullableContext(2)]
		public FOnSequencePlayEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060094CD RID: 38093 RVA: 0x000E0712 File Offset: 0x000DE912
		public FOnSequencePlayEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060094CE RID: 38094 RVA: 0x000E071D File Offset: 0x000DE91D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string, string>) ?? ((Action<string, string>)Delegate.CreateDelegate(typeof(Action<string, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060094CF RID: 38095 RVA: 0x000E074F File Offset: 0x000DE94F
		[NullableContext(1)]
		public void Bind(Action<string, string> Callback)
		{
			if (FOnSequencePlayEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnSequencePlayEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnSequencePlayEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnSequencePlayEvent.OnScriptCallback));
				}
				FOnSequencePlayEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnSequencePlayEvent.RegisterId);
		}

		// Token: 0x060094D0 RID: 38096 RVA: 0x000E078C File Offset: 0x000DE98C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Execute(string sequenceName, string eventName)
		{
			FOnSequencePlayEvent.__FOnSequencePlayEvent_DelegateParams* ptr = stackalloc FOnSequencePlayEvent.__FOnSequencePlayEvent_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FOnSequencePlayEvent.__FOnSequencePlayEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnSequencePlayEvent.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->sequenceName), sequenceName);
			FString.CopyFrom((void*)(&ptr->eventName), eventName);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FOnSequencePlayEvent._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060094D1 RID: 38097 RVA: 0x000E07F0 File Offset: 0x000DE9F0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string, string> action = target as Action<string, string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FOnSequencePlayEvent.__FOnSequencePlayEvent_DelegateParams*)__Parameters)->sequenceName));
			string arg2 = FString.ToString((void*)(&((FOnSequencePlayEvent.__FOnSequencePlayEvent_DelegateParams*)__Parameters)->eventName));
			action(arg, arg2);
		}

		// Token: 0x040040B7 RID: 16567
		internal static IntPtr _FunctionPtr;

		// Token: 0x040040B8 RID: 16568
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.OnSequencePlayEvent__DelegateSignature";

		// Token: 0x040040B9 RID: 16569
		private static int RegisterId;

		// Token: 0x02000F05 RID: 3845
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		private ref struct __FOnSequencePlayEvent_DelegateParams
		{
			// Token: 0x040062D1 RID: 25297
			[FieldOffset(0)]
			public FString sequenceName;

			// Token: 0x040062D2 RID: 25298
			[FieldOffset(16)]
			public FString eventName;
		}

		// Token: 0x02000F06 RID: 3846
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040062D3 RID: 25299
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
