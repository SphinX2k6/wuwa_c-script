using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007D5 RID: 2005
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnDialogueAudioEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600ACD0 RID: 44240 RVA: 0x000FF208 File Offset: 0x000FD408
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnDialogueAudioEvent.StaticFunctionPtr();
		}

		// Token: 0x0600ACD1 RID: 44241 RVA: 0x000FF214 File Offset: 0x000FD414
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnDialogueAudioEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnDialogueAudioEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SequenceDialogue.OnDialogueAudioEvent__DelegateSignature");
			}
			return FOnDialogueAudioEvent._FunctionPtr;
		}

		// Token: 0x0600ACD2 RID: 44242 RVA: 0x000FF237 File Offset: 0x000FD437
		public FOnDialogueAudioEvent()
		{
		}

		// Token: 0x0600ACD3 RID: 44243 RVA: 0x000FF23F File Offset: 0x000FD43F
		[NullableContext(2)]
		public FOnDialogueAudioEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600ACD4 RID: 44244 RVA: 0x000FF249 File Offset: 0x000FD449
		public FOnDialogueAudioEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600ACD5 RID: 44245 RVA: 0x000FF254 File Offset: 0x000FD454
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool, string, int>) ?? ((Action<bool, string, int>)Delegate.CreateDelegate(typeof(Action<bool, string, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600ACD6 RID: 44246 RVA: 0x000FF286 File Offset: 0x000FD486
		[NullableContext(1)]
		public void Add(Action<bool, string, int> Callback)
		{
			if (FOnDialogueAudioEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnDialogueAudioEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnDialogueAudioEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnDialogueAudioEvent.OnScriptCallback));
				}
				FOnDialogueAudioEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnDialogueAudioEvent.RegisterId);
		}

		// Token: 0x0600ACD7 RID: 44247 RVA: 0x000FF2C0 File Offset: 0x000FD4C0
		[NullableContext(1)]
		public void Remove(Action<bool, string, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600ACD8 RID: 44248 RVA: 0x000FF2CC File Offset: 0x000FD4CC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Broadcast(bool bShow, string AudioKey, int AudioTransitionDuration)
		{
			FOnDialogueAudioEvent.__FOnDialogueAudioEvent_DelegateParams* ptr = stackalloc FOnDialogueAudioEvent.__FOnDialogueAudioEvent_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FOnDialogueAudioEvent.__FOnDialogueAudioEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnDialogueAudioEvent.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bShow = bShow;
			FString.CopyFrom((void*)(&ptr->AudioKey), AudioKey);
			ptr->AudioTransitionDuration = AudioTransitionDuration;
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FOnDialogueAudioEvent._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600ACD9 RID: 44249 RVA: 0x000FF330 File Offset: 0x000FD530
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool, string, int> action = target as Action<bool, string, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FOnDialogueAudioEvent.__FOnDialogueAudioEvent_DelegateParams*)__Parameters)->AudioKey));
			action(((FOnDialogueAudioEvent.__FOnDialogueAudioEvent_DelegateParams*)__Parameters)->bShow, arg, ((FOnDialogueAudioEvent.__FOnDialogueAudioEvent_DelegateParams*)__Parameters)->AudioTransitionDuration);
		}

		// Token: 0x04004A88 RID: 19080
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004A89 RID: 19081
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SequenceDialogue.OnDialogueAudioEvent__DelegateSignature";

		// Token: 0x04004A8A RID: 19082
		private static int RegisterId;

		// Token: 0x02000F75 RID: 3957
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		private ref struct __FOnDialogueAudioEvent_DelegateParams
		{
			// Token: 0x0400635B RID: 25435
			[FieldOffset(0)]
			public bool bShow;

			// Token: 0x0400635C RID: 25436
			[FieldOffset(8)]
			public FString AudioKey;

			// Token: 0x0400635D RID: 25437
			[FieldOffset(24)]
			public int AudioTransitionDuration;
		}

		// Token: 0x02000F76 RID: 3958
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400635E RID: 25438
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
