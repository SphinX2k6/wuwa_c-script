using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007D7 RID: 2007
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnDialogueMouthEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600ACE4 RID: 44260 RVA: 0x000FF550 File Offset: 0x000FD750
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnDialogueMouthEvent.StaticFunctionPtr();
		}

		// Token: 0x0600ACE5 RID: 44261 RVA: 0x000FF55C File Offset: 0x000FD75C
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnDialogueMouthEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnDialogueMouthEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SequenceDialogue.OnDialogueMouthEvent__DelegateSignature");
			}
			return FOnDialogueMouthEvent._FunctionPtr;
		}

		// Token: 0x0600ACE6 RID: 44262 RVA: 0x000FF57F File Offset: 0x000FD77F
		public FOnDialogueMouthEvent()
		{
		}

		// Token: 0x0600ACE7 RID: 44263 RVA: 0x000FF587 File Offset: 0x000FD787
		[NullableContext(2)]
		public FOnDialogueMouthEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600ACE8 RID: 44264 RVA: 0x000FF591 File Offset: 0x000FD791
		public FOnDialogueMouthEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600ACE9 RID: 44265 RVA: 0x000FF59C File Offset: 0x000FD79C
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool, FText, FText, int>) ?? ((Action<bool, FText, FText, int>)Delegate.CreateDelegate(typeof(Action<bool, FText, FText, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600ACEA RID: 44266 RVA: 0x000FF5CE File Offset: 0x000FD7CE
		[NullableContext(1)]
		public void Add(Action<bool, FText, FText, int> Callback)
		{
			if (FOnDialogueMouthEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnDialogueMouthEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnDialogueMouthEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnDialogueMouthEvent.OnScriptCallback));
				}
				FOnDialogueMouthEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnDialogueMouthEvent.RegisterId);
		}

		// Token: 0x0600ACEB RID: 44267 RVA: 0x000FF608 File Offset: 0x000FD808
		[NullableContext(1)]
		public void Remove(Action<bool, FText, FText, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600ACEC RID: 44268 RVA: 0x000FF614 File Offset: 0x000FD814
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Broadcast(bool bShow, in FText SpeakerName, in FText DialogueKey, in int SpeakerId)
		{
			FOnDialogueMouthEvent.__FOnDialogueMouthEvent_DelegateParams* ptr = stackalloc FOnDialogueMouthEvent.__FOnDialogueMouthEvent_DelegateParams[(UIntPtr)79] + 15L / (long)sizeof(FOnDialogueMouthEvent.__FOnDialogueMouthEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnDialogueMouthEvent.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bShow = bShow;
			FText.NativeMove((void*)(&ptr->SpeakerName), SpeakerName.NativePtr);
			FText.NativeMove((void*)(&ptr->DialogueKey), DialogueKey.NativePtr);
			ptr->SpeakerId = SpeakerId;
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FOnDialogueMouthEvent._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600ACED RID: 44269 RVA: 0x000FF690 File Offset: 0x000FD890
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool, FText, FText, int> action = target as Action<bool, FText, FText, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FText arg = new FText(&((FOnDialogueMouthEvent.__FOnDialogueMouthEvent_DelegateParams*)__Parameters)->SpeakerName, true, true);
			FText arg2 = new FText(&((FOnDialogueMouthEvent.__FOnDialogueMouthEvent_DelegateParams*)__Parameters)->DialogueKey, true, true);
			action(((FOnDialogueMouthEvent.__FOnDialogueMouthEvent_DelegateParams*)__Parameters)->bShow, arg, arg2, ((FOnDialogueMouthEvent.__FOnDialogueMouthEvent_DelegateParams*)__Parameters)->SpeakerId);
		}

		// Token: 0x04004A8E RID: 19086
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004A8F RID: 19087
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SequenceDialogue.OnDialogueMouthEvent__DelegateSignature";

		// Token: 0x04004A90 RID: 19088
		private static int RegisterId;

		// Token: 0x02000F79 RID: 3961
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		private ref struct __FOnDialogueMouthEvent_DelegateParams
		{
			// Token: 0x04006367 RID: 25447
			[FieldOffset(0)]
			public bool bShow;

			// Token: 0x04006368 RID: 25448
			[FieldOffset(8)]
			public byte SpeakerName;

			// Token: 0x04006369 RID: 25449
			[FieldOffset(32)]
			public byte DialogueKey;

			// Token: 0x0400636A RID: 25450
			[FieldOffset(56)]
			public int SpeakerId;
		}

		// Token: 0x02000F7A RID: 3962
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400636B RID: 25451
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
