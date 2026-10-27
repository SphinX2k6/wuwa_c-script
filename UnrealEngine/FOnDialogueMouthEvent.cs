using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002702 RID: 9986
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnDialogueMouthEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602507F RID: 151679 RVA: 0x0036C9F4 File Offset: 0x0036ABF4
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnDialogueMouthEvent.StaticFunctionPtr();
		}

		// Token: 0x06025080 RID: 151680 RVA: 0x0036CA00 File Offset: 0x0036AC00
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnDialogueMouthEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnDialogueMouthEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SequenceDialogue.OnDialogueMouthEvent__DelegateSignature");
			}
			return FOnDialogueMouthEvent._FunctionPtr;
		}

		// Token: 0x06025081 RID: 151681 RVA: 0x0036CA23 File Offset: 0x0036AC23
		public FOnDialogueMouthEvent()
		{
		}

		// Token: 0x06025082 RID: 151682 RVA: 0x0036CA2B File Offset: 0x0036AC2B
		[NullableContext(2)]
		public FOnDialogueMouthEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025083 RID: 151683 RVA: 0x0036CA35 File Offset: 0x0036AC35
		public FOnDialogueMouthEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025084 RID: 151684 RVA: 0x0036CA40 File Offset: 0x0036AC40
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool, FText, FText, int>) ?? ((Action<bool, FText, FText, int>)Delegate.CreateDelegate(typeof(Action<bool, FText, FText, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06025085 RID: 151685 RVA: 0x0036CA72 File Offset: 0x0036AC72
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06025086 RID: 151686 RVA: 0x0036CAAC File Offset: 0x0036ACAC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<bool, FText, FText, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06025087 RID: 151687 RVA: 0x0036CAB8 File Offset: 0x0036ACB8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06025088 RID: 151688 RVA: 0x0036CB34 File Offset: 0x0036AD34
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04013F3E RID: 81726
		internal static IntPtr _FunctionPtr;

		// Token: 0x04013F3F RID: 81727
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SequenceDialogue.OnDialogueMouthEvent__DelegateSignature";

		// Token: 0x04013F40 RID: 81728
		private static int RegisterId;

		// Token: 0x0200369E RID: 13982
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __FOnDialogueMouthEvent_DelegateParams
		{
			// Token: 0x040177A5 RID: 96165
			[FieldOffset(0)]
			public bool bShow;

			// Token: 0x040177A6 RID: 96166
			[FieldOffset(8)]
			public byte SpeakerName;

			// Token: 0x040177A7 RID: 96167
			[FieldOffset(32)]
			public byte DialogueKey;

			// Token: 0x040177A8 RID: 96168
			[FieldOffset(56)]
			public int SpeakerId;
		}

		// Token: 0x0200369F RID: 13983
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040177A9 RID: 96169
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
