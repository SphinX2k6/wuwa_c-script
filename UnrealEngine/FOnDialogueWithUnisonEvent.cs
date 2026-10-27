using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002704 RID: 9988
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnDialogueWithUnisonEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06025093 RID: 151699 RVA: 0x0036CDD7 File Offset: 0x0036AFD7
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnDialogueWithUnisonEvent.StaticFunctionPtr();
		}

		// Token: 0x06025094 RID: 151700 RVA: 0x0036CDE3 File Offset: 0x0036AFE3
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnDialogueWithUnisonEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnDialogueWithUnisonEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SequenceDialogue.OnDialogueWithUnisonEvent__DelegateSignature");
			}
			return FOnDialogueWithUnisonEvent._FunctionPtr;
		}

		// Token: 0x06025095 RID: 151701 RVA: 0x0036CE06 File Offset: 0x0036B006
		public FOnDialogueWithUnisonEvent()
		{
		}

		// Token: 0x06025096 RID: 151702 RVA: 0x0036CE0E File Offset: 0x0036B00E
		[NullableContext(2)]
		public FOnDialogueWithUnisonEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025097 RID: 151703 RVA: 0x0036CE18 File Offset: 0x0036B018
		public FOnDialogueWithUnisonEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025098 RID: 151704 RVA: 0x0036CE23 File Offset: 0x0036B023
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as FOnDialogueWithUnisonEvent.FOnDialogueWithUnisonEvent_ScriptDelegate) ?? ((FOnDialogueWithUnisonEvent.FOnDialogueWithUnisonEvent_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnDialogueWithUnisonEvent.FOnDialogueWithUnisonEvent_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x06025099 RID: 151705 RVA: 0x0036CE55 File Offset: 0x0036B055
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602509A RID: 151706 RVA: 0x0036CE8F File Offset: 0x0036B08F
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(FOnDialogueWithUnisonEvent.FOnDialogueWithUnisonEvent_ScriptDelegate Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0602509B RID: 151707 RVA: 0x0036CE98 File Offset: 0x0036B098
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602509C RID: 151708 RVA: 0x0036CF4C File Offset: 0x0036B14C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04013F44 RID: 81732
		internal static IntPtr _FunctionPtr;

		// Token: 0x04013F45 RID: 81733
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SequenceDialogue.OnDialogueWithUnisonEvent__DelegateSignature";

		// Token: 0x04013F46 RID: 81734
		private static int RegisterId;

		// Token: 0x020036A3 RID: 13987
		// (Invoke) Token: 0x060285CA RID: 165322
		public delegate void FOnDialogueWithUnisonEvent_ScriptDelegate(bool bShow, in FText DialogueID, int GuardTime, int AudioDelay, int AudioTransitionDuration, ELanguageAudio LanguageType, int AutoPlayDelay, [Nullable(2)] in TArray<int> UnisonIdList);

		// Token: 0x020036A4 RID: 13988
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __FOnDialogueWithUnisonEvent_DelegateParams
		{
			// Token: 0x040177B0 RID: 96176
			[FieldOffset(0)]
			public bool bShow;

			// Token: 0x040177B1 RID: 96177
			[FieldOffset(8)]
			public byte DialogueID;

			// Token: 0x040177B2 RID: 96178
			[FieldOffset(32)]
			public int GuardTime;

			// Token: 0x040177B3 RID: 96179
			[FieldOffset(36)]
			public int AudioDelay;

			// Token: 0x040177B4 RID: 96180
			[FieldOffset(40)]
			public int AudioTransitionDuration;

			// Token: 0x040177B5 RID: 96181
			[FieldOffset(44)]
			public ELanguageAudio LanguageType;

			// Token: 0x040177B6 RID: 96182
			[FieldOffset(48)]
			public int AutoPlayDelay;

			// Token: 0x040177B7 RID: 96183
			[FieldOffset(56)]
			public byte UnisonIdList;
		}

		// Token: 0x020036A5 RID: 13989
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040177B8 RID: 96184
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
