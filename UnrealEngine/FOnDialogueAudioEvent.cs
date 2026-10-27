using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002700 RID: 9984
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnDialogueAudioEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602506B RID: 151659 RVA: 0x0036C6AE File Offset: 0x0036A8AE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnDialogueAudioEvent.StaticFunctionPtr();
		}

		// Token: 0x0602506C RID: 151660 RVA: 0x0036C6BA File Offset: 0x0036A8BA
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnDialogueAudioEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnDialogueAudioEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SequenceDialogue.OnDialogueAudioEvent__DelegateSignature");
			}
			return FOnDialogueAudioEvent._FunctionPtr;
		}

		// Token: 0x0602506D RID: 151661 RVA: 0x0036C6DD File Offset: 0x0036A8DD
		public FOnDialogueAudioEvent()
		{
		}

		// Token: 0x0602506E RID: 151662 RVA: 0x0036C6E5 File Offset: 0x0036A8E5
		[NullableContext(2)]
		public FOnDialogueAudioEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602506F RID: 151663 RVA: 0x0036C6EF File Offset: 0x0036A8EF
		public FOnDialogueAudioEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025070 RID: 151664 RVA: 0x0036C6FA File Offset: 0x0036A8FA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool, string, int>) ?? ((Action<bool, string, int>)Delegate.CreateDelegate(typeof(Action<bool, string, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06025071 RID: 151665 RVA: 0x0036C72C File Offset: 0x0036A92C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06025072 RID: 151666 RVA: 0x0036C766 File Offset: 0x0036A966
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<bool, string, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06025073 RID: 151667 RVA: 0x0036C770 File Offset: 0x0036A970
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06025074 RID: 151668 RVA: 0x0036C7D4 File Offset: 0x0036A9D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04013F38 RID: 81720
		internal static IntPtr _FunctionPtr;

		// Token: 0x04013F39 RID: 81721
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SequenceDialogue.OnDialogueAudioEvent__DelegateSignature";

		// Token: 0x04013F3A RID: 81722
		private static int RegisterId;

		// Token: 0x0200369A RID: 13978
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __FOnDialogueAudioEvent_DelegateParams
		{
			// Token: 0x04017799 RID: 96153
			[FieldOffset(0)]
			public bool bShow;

			// Token: 0x0401779A RID: 96154
			[FieldOffset(8)]
			public FString AudioKey;

			// Token: 0x0401779B RID: 96155
			[FieldOffset(24)]
			public int AudioTransitionDuration;
		}

		// Token: 0x0200369B RID: 13979
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401779C RID: 96156
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
