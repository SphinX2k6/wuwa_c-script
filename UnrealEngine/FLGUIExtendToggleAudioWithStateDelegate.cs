using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000695 RID: 1685
	public sealed class FLGUIExtendToggleAudioWithStateDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06009177 RID: 37239 RVA: 0x000DACD2 File Offset: 0x000D8ED2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIExtendToggleAudioWithStateDelegate.StaticFunctionPtr();
		}

		// Token: 0x06009178 RID: 37240 RVA: 0x000DACDE File Offset: 0x000D8EDE
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIExtendToggleAudioWithStateDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIExtendToggleAudioWithStateDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIExtendToggleAudioWithStateDelegate__DelegateSignature");
			}
			return FLGUIExtendToggleAudioWithStateDelegate._FunctionPtr;
		}

		// Token: 0x06009179 RID: 37241 RVA: 0x000DAD01 File Offset: 0x000D8F01
		public FLGUIExtendToggleAudioWithStateDelegate()
		{
		}

		// Token: 0x0600917A RID: 37242 RVA: 0x000DAD09 File Offset: 0x000D8F09
		[NullableContext(2)]
		public FLGUIExtendToggleAudioWithStateDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600917B RID: 37243 RVA: 0x000DAD13 File Offset: 0x000D8F13
		public FLGUIExtendToggleAudioWithStateDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600917C RID: 37244 RVA: 0x000DAD1E File Offset: 0x000D8F1E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<EToggleAudioTransitionState, string>) ?? ((Action<EToggleAudioTransitionState, string>)Delegate.CreateDelegate(typeof(Action<EToggleAudioTransitionState, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600917D RID: 37245 RVA: 0x000DAD50 File Offset: 0x000D8F50
		[NullableContext(1)]
		public void Bind(Action<EToggleAudioTransitionState, string> Callback)
		{
			if (FLGUIExtendToggleAudioWithStateDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIExtendToggleAudioWithStateDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIExtendToggleAudioWithStateDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIExtendToggleAudioWithStateDelegate.OnScriptCallback));
				}
				FLGUIExtendToggleAudioWithStateDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIExtendToggleAudioWithStateDelegate.RegisterId);
		}

		// Token: 0x0600917E RID: 37246 RVA: 0x000DAD8C File Offset: 0x000D8F8C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Execute(EToggleAudioTransitionState State, string EventName)
		{
			FLGUIExtendToggleAudioWithStateDelegate.__FLGUIExtendToggleAudioWithStateDelegate_DelegateParams* ptr = stackalloc FLGUIExtendToggleAudioWithStateDelegate.__FLGUIExtendToggleAudioWithStateDelegate_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FLGUIExtendToggleAudioWithStateDelegate.__FLGUIExtendToggleAudioWithStateDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIExtendToggleAudioWithStateDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->State = State;
			FString.CopyFrom((void*)(&ptr->EventName), EventName);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FLGUIExtendToggleAudioWithStateDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600917F RID: 37247 RVA: 0x000DADE8 File Offset: 0x000D8FE8
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<EToggleAudioTransitionState, string> action = target as Action<EToggleAudioTransitionState, string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FLGUIExtendToggleAudioWithStateDelegate.__FLGUIExtendToggleAudioWithStateDelegate_DelegateParams*)__Parameters)->EventName));
			action(((FLGUIExtendToggleAudioWithStateDelegate.__FLGUIExtendToggleAudioWithStateDelegate_DelegateParams*)__Parameters)->State, arg);
		}

		// Token: 0x04003F6C RID: 16236
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003F6D RID: 16237
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIExtendToggleAudioWithStateDelegate__DelegateSignature";

		// Token: 0x04003F6E RID: 16238
		private static int RegisterId;

		// Token: 0x02000EB9 RID: 3769
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FLGUIExtendToggleAudioWithStateDelegate_DelegateParams
		{
			// Token: 0x0400626D RID: 25197
			[FieldOffset(0)]
			public EToggleAudioTransitionState State;

			// Token: 0x0400626E RID: 25198
			[FieldOffset(8)]
			public FString EventName;
		}

		// Token: 0x02000EBA RID: 3770
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400626F RID: 25199
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
