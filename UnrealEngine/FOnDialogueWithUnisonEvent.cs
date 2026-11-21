using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007D9 RID: 2009
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnDialogueWithUnisonEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600ACF8 RID: 44280 RVA: 0x000FF933 File Offset: 0x000FDB33
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnDialogueWithUnisonEvent.StaticFunctionPtr();
		}

		// Token: 0x0600ACF9 RID: 44281 RVA: 0x000FF93F File Offset: 0x000FDB3F
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnDialogueWithUnisonEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnDialogueWithUnisonEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SequenceDialogue.OnDialogueWithUnisonEvent__DelegateSignature");
			}
			return FOnDialogueWithUnisonEvent._FunctionPtr;
		}

		// Token: 0x0600ACFA RID: 44282 RVA: 0x000FF962 File Offset: 0x000FDB62
		public FOnDialogueWithUnisonEvent()
		{
		}

		// Token: 0x0600ACFB RID: 44283 RVA: 0x000FF96A File Offset: 0x000FDB6A
		[NullableContext(2)]
		public FOnDialogueWithUnisonEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600ACFC RID: 44284 RVA: 0x000FF974 File Offset: 0x000FDB74
		public FOnDialogueWithUnisonEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600ACFD RID: 44285 RVA: 0x000FF97F File Offset: 0x000FDB7F
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as FOnDialogueWithUnisonEvent.FOnDialogueWithUnisonEvent_ScriptDelegate) ?? ((FOnDialogueWithUnisonEvent.FOnDialogueWithUnisonEvent_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnDialogueWithUnisonEvent.FOnDialogueWithUnisonEvent_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600ACFE RID: 44286 RVA: 0x000FF9B1 File Offset: 0x000FDBB1
		[NullableContext(1)]
		public void Add(FOnDialogueWithUnisonEvent.FOnDialogueWithUnisonEvent_ScriptDelegate Callback)
		{
			if (FOnDialogueWithUnisonEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnDialogueWithUnisonEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnDialogueWithUnisonEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnDialogueWithUnisonEvent.OnScriptCallback));
				}
				FOnDialogueWithUnisonEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnDialogueWithUnisonEvent.RegisterId);
		}

		// Token: 0x0600ACFF RID: 44287 RVA: 0x000FF9EB File Offset: 0x000FDBEB
		[NullableContext(1)]
		public void Remove(FOnDialogueWithUnisonEvent.FOnDialogueWithUnisonEvent_ScriptDelegate Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600AD00 RID: 44288 RVA: 0x000FF9F4 File Offset: 0x000FDBF4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Broadcast(bool bShow, in FText DialogueID, int GuardTime, int AudioDelay, int AudioTransitionDuration, ELanguageAudio LanguageType, int AutoPlayDelay, [Nullable(2)] in TArray<int> UnisonIdList)
		{
			FOnDialogueWithUnisonEvent.__FOnDialogueWithUnisonEvent_DelegateParams* ptr = stackalloc FOnDialogueWithUnisonEvent.__FOnDialogueWithUnisonEvent_DelegateParams[(UIntPtr)87] + 15L / (long)sizeof(FOnDialogueWithUnisonEvent.__FOnDialogueWithUnisonEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnDialogueWithUnisonEvent.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bShow = bShow;
			FText.NativeMove((void*)(&ptr->DialogueID), DialogueID.NativePtr);
			ptr->GuardTime = GuardTime;
			ptr->AudioDelay = AudioDelay;
			ptr->AudioTransitionDuration = AudioTransitionDuration;
			ptr->LanguageType = LanguageType;
			ptr->AutoPlayDelay = AutoPlayDelay;
			TArray<int> tarray = UnisonIdList;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->UnisonIdList);
			}
			base.BroadcastInternal((void*)ptr);
			TArray<int> tarray2 = UnisonIdList;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->UnisonIdList);
			}
			UnrealReflectionUtils.DestroyStruct(FOnDialogueWithUnisonEvent._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AD01 RID: 44289 RVA: 0x000FFAA8 File Offset: 0x000FDCA8
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FOnDialogueWithUnisonEvent.FOnDialogueWithUnisonEvent_ScriptDelegate fonDialogueWithUnisonEvent_ScriptDelegate = target as FOnDialogueWithUnisonEvent.FOnDialogueWithUnisonEvent_ScriptDelegate;
			if (fonDialogueWithUnisonEvent_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FText ftext = new FText(&((FOnDialogueWithUnisonEvent.__FOnDialogueWithUnisonEvent_DelegateParams*)__Parameters)->DialogueID, true, true);
			TArray<int> tarray = new TArray<int>(&((FOnDialogueWithUnisonEvent.__FOnDialogueWithUnisonEvent_DelegateParams*)__Parameters)->UnisonIdList, true, true);
			fonDialogueWithUnisonEvent_ScriptDelegate(((FOnDialogueWithUnisonEvent.__FOnDialogueWithUnisonEvent_DelegateParams*)__Parameters)->bShow, ftext, ((FOnDialogueWithUnisonEvent.__FOnDialogueWithUnisonEvent_DelegateParams*)__Parameters)->GuardTime, ((FOnDialogueWithUnisonEvent.__FOnDialogueWithUnisonEvent_DelegateParams*)__Parameters)->AudioDelay, ((FOnDialogueWithUnisonEvent.__FOnDialogueWithUnisonEvent_DelegateParams*)__Parameters)->AudioTransitionDuration, ((FOnDialogueWithUnisonEvent.__FOnDialogueWithUnisonEvent_DelegateParams*)__Parameters)->LanguageType, ((FOnDialogueWithUnisonEvent.__FOnDialogueWithUnisonEvent_DelegateParams*)__Parameters)->AutoPlayDelay, tarray);
			FText.NativeCopy((void*)(&((FOnDialogueWithUnisonEvent.__FOnDialogueWithUnisonEvent_DelegateParams*)__Parameters)->DialogueID), ftext.NativePtr, 1);
			if (tarray != null)
			{
				tarray.CopyTo(&((FOnDialogueWithUnisonEvent.__FOnDialogueWithUnisonEvent_DelegateParams*)__Parameters)->UnisonIdList, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x04004A94 RID: 19092
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004A95 RID: 19093
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SequenceDialogue.OnDialogueWithUnisonEvent__DelegateSignature";

		// Token: 0x04004A96 RID: 19094
		private static int RegisterId;

		// Token: 0x02000F7E RID: 3966
		// (Invoke) Token: 0x0600BF2F RID: 48943
		public delegate void FOnDialogueWithUnisonEvent_ScriptDelegate(bool bShow, in FText DialogueID, int GuardTime, int AudioDelay, int AudioTransitionDuration, ELanguageAudio LanguageType, int AutoPlayDelay, [Nullable(2)] in TArray<int> UnisonIdList);

		// Token: 0x02000F7F RID: 3967
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		private ref struct __FOnDialogueWithUnisonEvent_DelegateParams
		{
			// Token: 0x04006372 RID: 25458
			[FieldOffset(0)]
			public bool bShow;

			// Token: 0x04006373 RID: 25459
			[FieldOffset(8)]
			public byte DialogueID;

			// Token: 0x04006374 RID: 25460
			[FieldOffset(32)]
			public int GuardTime;

			// Token: 0x04006375 RID: 25461
			[FieldOffset(36)]
			public int AudioDelay;

			// Token: 0x04006376 RID: 25462
			[FieldOffset(40)]
			public int AudioTransitionDuration;

			// Token: 0x04006377 RID: 25463
			[FieldOffset(44)]
			public ELanguageAudio LanguageType;

			// Token: 0x04006378 RID: 25464
			[FieldOffset(48)]
			public int AutoPlayDelay;

			// Token: 0x04006379 RID: 25465
			[FieldOffset(56)]
			public byte UnisonIdList;
		}

		// Token: 0x02000F80 RID: 3968
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400637A RID: 25466
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
