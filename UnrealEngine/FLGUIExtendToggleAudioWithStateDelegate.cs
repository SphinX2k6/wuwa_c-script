using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002073 RID: 8307
	public sealed class FLGUIExtendToggleAudioWithStateDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F57A RID: 128378 RVA: 0x002E8BAA File Offset: 0x002E6DAA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIExtendToggleAudioWithStateDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F57B RID: 128379 RVA: 0x002E8BB6 File Offset: 0x002E6DB6
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIExtendToggleAudioWithStateDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIExtendToggleAudioWithStateDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIExtendToggleAudioWithStateDelegate__DelegateSignature");
			}
			return FLGUIExtendToggleAudioWithStateDelegate._FunctionPtr;
		}

		// Token: 0x0601F57C RID: 128380 RVA: 0x002E8BD9 File Offset: 0x002E6DD9
		public FLGUIExtendToggleAudioWithStateDelegate()
		{
		}

		// Token: 0x0601F57D RID: 128381 RVA: 0x002E8BE1 File Offset: 0x002E6DE1
		[NullableContext(2)]
		public FLGUIExtendToggleAudioWithStateDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F57E RID: 128382 RVA: 0x002E8BEB File Offset: 0x002E6DEB
		public FLGUIExtendToggleAudioWithStateDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F57F RID: 128383 RVA: 0x002E8BF6 File Offset: 0x002E6DF6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<EToggleAudioTransitionState, string>) ?? ((Action<EToggleAudioTransitionState, string>)Delegate.CreateDelegate(typeof(Action<EToggleAudioTransitionState, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F580 RID: 128384 RVA: 0x002E8C28 File Offset: 0x002E6E28
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601F581 RID: 128385 RVA: 0x002E8C64 File Offset: 0x002E6E64
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(EToggleAudioTransitionState State, string EventName)
		{
			FLGUIExtendToggleAudioWithStateDelegate.__FLGUIExtendToggleAudioWithStateDelegate_DelegateParams* ptr = stackalloc FLGUIExtendToggleAudioWithStateDelegate.__FLGUIExtendToggleAudioWithStateDelegate_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FLGUIExtendToggleAudioWithStateDelegate.__FLGUIExtendToggleAudioWithStateDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIExtendToggleAudioWithStateDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->State = State;
			FString.CopyFrom((void*)(&ptr->EventName), EventName);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FLGUIExtendToggleAudioWithStateDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F582 RID: 128386 RVA: 0x002E8CC0 File Offset: 0x002E6EC0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04010EFF RID: 69375
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010F00 RID: 69376
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIExtendToggleAudioWithStateDelegate__DelegateSignature";

		// Token: 0x04010F01 RID: 69377
		private static int RegisterId;

		// Token: 0x02003476 RID: 13430
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FLGUIExtendToggleAudioWithStateDelegate_DelegateParams
		{
			// Token: 0x0401745E RID: 95326
			[FieldOffset(0)]
			public EToggleAudioTransitionState State;

			// Token: 0x0401745F RID: 95327
			[FieldOffset(8)]
			public FString EventName;
		}

		// Token: 0x02003477 RID: 13431
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017460 RID: 95328
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
