using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007D6 RID: 2006
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnDialogueEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600ACDA RID: 44250 RVA: 0x000FF38E File Offset: 0x000FD58E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnDialogueEvent.StaticFunctionPtr();
		}

		// Token: 0x0600ACDB RID: 44251 RVA: 0x000FF39A File Offset: 0x000FD59A
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnDialogueEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnDialogueEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SequenceDialogue.OnDialogueEvent__DelegateSignature");
			}
			return FOnDialogueEvent._FunctionPtr;
		}

		// Token: 0x0600ACDC RID: 44252 RVA: 0x000FF3BD File Offset: 0x000FD5BD
		public FOnDialogueEvent()
		{
		}

		// Token: 0x0600ACDD RID: 44253 RVA: 0x000FF3C5 File Offset: 0x000FD5C5
		[NullableContext(2)]
		public FOnDialogueEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600ACDE RID: 44254 RVA: 0x000FF3CF File Offset: 0x000FD5CF
		public FOnDialogueEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600ACDF RID: 44255 RVA: 0x000FF3DA File Offset: 0x000FD5DA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool, FText, int, int, int, ELanguageAudio, int>) ?? ((Action<bool, FText, int, int, int, ELanguageAudio, int>)Delegate.CreateDelegate(typeof(Action<bool, FText, int, int, int, ELanguageAudio, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600ACE0 RID: 44256 RVA: 0x000FF40C File Offset: 0x000FD60C
		[NullableContext(1)]
		public void Add(Action<bool, FText, int, int, int, ELanguageAudio, int> Callback)
		{
			if (FOnDialogueEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnDialogueEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnDialogueEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnDialogueEvent.OnScriptCallback));
				}
				FOnDialogueEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnDialogueEvent.RegisterId);
		}

		// Token: 0x0600ACE1 RID: 44257 RVA: 0x000FF446 File Offset: 0x000FD646
		[NullableContext(1)]
		public void Remove(Action<bool, FText, int, int, int, ELanguageAudio, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600ACE2 RID: 44258 RVA: 0x000FF450 File Offset: 0x000FD650
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Broadcast(bool bShow, in FText DialogueID, int GuardTime, int AudioDelay, int AudioTransitionDuration, ELanguageAudio LanguageType, int AutoPlayDelay)
		{
			FOnDialogueEvent.__FOnDialogueEvent_DelegateParams* ptr = stackalloc FOnDialogueEvent.__FOnDialogueEvent_DelegateParams[(UIntPtr)71] + 15L / (long)sizeof(FOnDialogueEvent.__FOnDialogueEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnDialogueEvent.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bShow = bShow;
			FText.NativeMove((void*)(&ptr->DialogueID), DialogueID.NativePtr);
			ptr->GuardTime = GuardTime;
			ptr->AudioDelay = AudioDelay;
			ptr->AudioTransitionDuration = AudioTransitionDuration;
			ptr->LanguageType = LanguageType;
			ptr->AutoPlayDelay = AutoPlayDelay;
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FOnDialogueEvent._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600ACE3 RID: 44259 RVA: 0x000FF4D8 File Offset: 0x000FD6D8
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool, FText, int, int, int, ELanguageAudio, int> action = target as Action<bool, FText, int, int, int, ELanguageAudio, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FText arg = new FText(&((FOnDialogueEvent.__FOnDialogueEvent_DelegateParams*)__Parameters)->DialogueID, true, true);
			action(((FOnDialogueEvent.__FOnDialogueEvent_DelegateParams*)__Parameters)->bShow, arg, ((FOnDialogueEvent.__FOnDialogueEvent_DelegateParams*)__Parameters)->GuardTime, ((FOnDialogueEvent.__FOnDialogueEvent_DelegateParams*)__Parameters)->AudioDelay, ((FOnDialogueEvent.__FOnDialogueEvent_DelegateParams*)__Parameters)->AudioTransitionDuration, ((FOnDialogueEvent.__FOnDialogueEvent_DelegateParams*)__Parameters)->LanguageType, ((FOnDialogueEvent.__FOnDialogueEvent_DelegateParams*)__Parameters)->AutoPlayDelay);
		}

		// Token: 0x04004A8B RID: 19083
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004A8C RID: 19084
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SequenceDialogue.OnDialogueEvent__DelegateSignature";

		// Token: 0x04004A8D RID: 19085
		private static int RegisterId;

		// Token: 0x02000F77 RID: 3959
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		private ref struct __FOnDialogueEvent_DelegateParams
		{
			// Token: 0x0400635F RID: 25439
			[FieldOffset(0)]
			public bool bShow;

			// Token: 0x04006360 RID: 25440
			[FieldOffset(8)]
			public byte DialogueID;

			// Token: 0x04006361 RID: 25441
			[FieldOffset(32)]
			public int GuardTime;

			// Token: 0x04006362 RID: 25442
			[FieldOffset(36)]
			public int AudioDelay;

			// Token: 0x04006363 RID: 25443
			[FieldOffset(40)]
			public int AudioTransitionDuration;

			// Token: 0x04006364 RID: 25444
			[FieldOffset(44)]
			public ELanguageAudio LanguageType;

			// Token: 0x04006365 RID: 25445
			[FieldOffset(48)]
			public int AutoPlayDelay;
		}

		// Token: 0x02000F78 RID: 3960
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006366 RID: 25446
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
