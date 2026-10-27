using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002701 RID: 9985
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnDialogueEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06025075 RID: 151669 RVA: 0x0036C832 File Offset: 0x0036AA32
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnDialogueEvent.StaticFunctionPtr();
		}

		// Token: 0x06025076 RID: 151670 RVA: 0x0036C83E File Offset: 0x0036AA3E
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnDialogueEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnDialogueEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SequenceDialogue.OnDialogueEvent__DelegateSignature");
			}
			return FOnDialogueEvent._FunctionPtr;
		}

		// Token: 0x06025077 RID: 151671 RVA: 0x0036C861 File Offset: 0x0036AA61
		public FOnDialogueEvent()
		{
		}

		// Token: 0x06025078 RID: 151672 RVA: 0x0036C869 File Offset: 0x0036AA69
		[NullableContext(2)]
		public FOnDialogueEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025079 RID: 151673 RVA: 0x0036C873 File Offset: 0x0036AA73
		public FOnDialogueEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602507A RID: 151674 RVA: 0x0036C87E File Offset: 0x0036AA7E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool, FText, int, int, int, ELanguageAudio, int>) ?? ((Action<bool, FText, int, int, int, ELanguageAudio, int>)Delegate.CreateDelegate(typeof(Action<bool, FText, int, int, int, ELanguageAudio, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0602507B RID: 151675 RVA: 0x0036C8B0 File Offset: 0x0036AAB0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602507C RID: 151676 RVA: 0x0036C8EA File Offset: 0x0036AAEA
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<bool, FText, int, int, int, ELanguageAudio, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0602507D RID: 151677 RVA: 0x0036C8F4 File Offset: 0x0036AAF4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602507E RID: 151678 RVA: 0x0036C97C File Offset: 0x0036AB7C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04013F3B RID: 81723
		internal static IntPtr _FunctionPtr;

		// Token: 0x04013F3C RID: 81724
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SequenceDialogue.OnDialogueEvent__DelegateSignature";

		// Token: 0x04013F3D RID: 81725
		private static int RegisterId;

		// Token: 0x0200369C RID: 13980
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __FOnDialogueEvent_DelegateParams
		{
			// Token: 0x0401779D RID: 96157
			[FieldOffset(0)]
			public bool bShow;

			// Token: 0x0401779E RID: 96158
			[FieldOffset(8)]
			public byte DialogueID;

			// Token: 0x0401779F RID: 96159
			[FieldOffset(32)]
			public int GuardTime;

			// Token: 0x040177A0 RID: 96160
			[FieldOffset(36)]
			public int AudioDelay;

			// Token: 0x040177A1 RID: 96161
			[FieldOffset(40)]
			public int AudioTransitionDuration;

			// Token: 0x040177A2 RID: 96162
			[FieldOffset(44)]
			public ELanguageAudio LanguageType;

			// Token: 0x040177A3 RID: 96163
			[FieldOffset(48)]
			public int AutoPlayDelay;
		}

		// Token: 0x0200369D RID: 13981
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040177A4 RID: 96164
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
