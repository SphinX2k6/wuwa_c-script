using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007D8 RID: 2008
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnDialogueMouthWithUnisonEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600ACEE RID: 44270 RVA: 0x000FF701 File Offset: 0x000FD901
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnDialogueMouthWithUnisonEvent.StaticFunctionPtr();
		}

		// Token: 0x0600ACEF RID: 44271 RVA: 0x000FF70D File Offset: 0x000FD90D
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnDialogueMouthWithUnisonEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnDialogueMouthWithUnisonEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SequenceDialogue.OnDialogueMouthWithUnisonEvent__DelegateSignature");
			}
			return FOnDialogueMouthWithUnisonEvent._FunctionPtr;
		}

		// Token: 0x0600ACF0 RID: 44272 RVA: 0x000FF730 File Offset: 0x000FD930
		public FOnDialogueMouthWithUnisonEvent()
		{
		}

		// Token: 0x0600ACF1 RID: 44273 RVA: 0x000FF738 File Offset: 0x000FD938
		[NullableContext(2)]
		public FOnDialogueMouthWithUnisonEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600ACF2 RID: 44274 RVA: 0x000FF742 File Offset: 0x000FD942
		public FOnDialogueMouthWithUnisonEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600ACF3 RID: 44275 RVA: 0x000FF74D File Offset: 0x000FD94D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as FOnDialogueMouthWithUnisonEvent.FOnDialogueMouthWithUnisonEvent_ScriptDelegate) ?? ((FOnDialogueMouthWithUnisonEvent.FOnDialogueMouthWithUnisonEvent_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnDialogueMouthWithUnisonEvent.FOnDialogueMouthWithUnisonEvent_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600ACF4 RID: 44276 RVA: 0x000FF77F File Offset: 0x000FD97F
		[NullableContext(1)]
		public void Add(FOnDialogueMouthWithUnisonEvent.FOnDialogueMouthWithUnisonEvent_ScriptDelegate Callback)
		{
			if (FOnDialogueMouthWithUnisonEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnDialogueMouthWithUnisonEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnDialogueMouthWithUnisonEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnDialogueMouthWithUnisonEvent.OnScriptCallback));
				}
				FOnDialogueMouthWithUnisonEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnDialogueMouthWithUnisonEvent.RegisterId);
		}

		// Token: 0x0600ACF5 RID: 44277 RVA: 0x000FF7B9 File Offset: 0x000FD9B9
		[NullableContext(1)]
		public void Remove(FOnDialogueMouthWithUnisonEvent.FOnDialogueMouthWithUnisonEvent_ScriptDelegate Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600ACF6 RID: 44278 RVA: 0x000FF7C4 File Offset: 0x000FD9C4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Broadcast(bool bShow, in FText SpeakerName, in FText DialogueKey, in int SpeakerId, [Nullable(2)] in TArray<int> UnisonIdList)
		{
			FOnDialogueMouthWithUnisonEvent.__FOnDialogueMouthWithUnisonEvent_DelegateParams* ptr = stackalloc FOnDialogueMouthWithUnisonEvent.__FOnDialogueMouthWithUnisonEvent_DelegateParams[(UIntPtr)95] + 15L / (long)sizeof(FOnDialogueMouthWithUnisonEvent.__FOnDialogueMouthWithUnisonEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnDialogueMouthWithUnisonEvent.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bShow = bShow;
			FText.NativeMove((void*)(&ptr->SpeakerName), SpeakerName.NativePtr);
			FText.NativeMove((void*)(&ptr->DialogueKey), DialogueKey.NativePtr);
			ptr->SpeakerId = SpeakerId;
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
			UnrealReflectionUtils.DestroyStruct(FOnDialogueMouthWithUnisonEvent._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600ACF7 RID: 44279 RVA: 0x000FF86C File Offset: 0x000FDA6C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FOnDialogueMouthWithUnisonEvent.FOnDialogueMouthWithUnisonEvent_ScriptDelegate fonDialogueMouthWithUnisonEvent_ScriptDelegate = target as FOnDialogueMouthWithUnisonEvent.FOnDialogueMouthWithUnisonEvent_ScriptDelegate;
			if (fonDialogueMouthWithUnisonEvent_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FText ftext = new FText(&((FOnDialogueMouthWithUnisonEvent.__FOnDialogueMouthWithUnisonEvent_DelegateParams*)__Parameters)->SpeakerName, true, true);
			FText ftext2 = new FText(&((FOnDialogueMouthWithUnisonEvent.__FOnDialogueMouthWithUnisonEvent_DelegateParams*)__Parameters)->DialogueKey, true, true);
			TArray<int> tarray = new TArray<int>(&((FOnDialogueMouthWithUnisonEvent.__FOnDialogueMouthWithUnisonEvent_DelegateParams*)__Parameters)->UnisonIdList, true, true);
			fonDialogueMouthWithUnisonEvent_ScriptDelegate(((FOnDialogueMouthWithUnisonEvent.__FOnDialogueMouthWithUnisonEvent_DelegateParams*)__Parameters)->bShow, ftext, ftext2, ((FOnDialogueMouthWithUnisonEvent.__FOnDialogueMouthWithUnisonEvent_DelegateParams*)__Parameters)->SpeakerId, tarray);
			FText.NativeCopy((void*)(&((FOnDialogueMouthWithUnisonEvent.__FOnDialogueMouthWithUnisonEvent_DelegateParams*)__Parameters)->SpeakerName), ftext.NativePtr, 1);
			FText.NativeCopy((void*)(&((FOnDialogueMouthWithUnisonEvent.__FOnDialogueMouthWithUnisonEvent_DelegateParams*)__Parameters)->DialogueKey), ftext2.NativePtr, 1);
			if (tarray != null)
			{
				tarray.CopyTo(&((FOnDialogueMouthWithUnisonEvent.__FOnDialogueMouthWithUnisonEvent_DelegateParams*)__Parameters)->UnisonIdList, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x04004A91 RID: 19089
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004A92 RID: 19090
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SequenceDialogue.OnDialogueMouthWithUnisonEvent__DelegateSignature";

		// Token: 0x04004A93 RID: 19091
		private static int RegisterId;

		// Token: 0x02000F7B RID: 3963
		// (Invoke) Token: 0x0600BF2B RID: 48939
		public delegate void FOnDialogueMouthWithUnisonEvent_ScriptDelegate(bool bShow, in FText SpeakerName, in FText DialogueKey, in int SpeakerId, [Nullable(2)] in TArray<int> UnisonIdList);

		// Token: 0x02000F7C RID: 3964
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		private ref struct __FOnDialogueMouthWithUnisonEvent_DelegateParams
		{
			// Token: 0x0400636C RID: 25452
			[FieldOffset(0)]
			public bool bShow;

			// Token: 0x0400636D RID: 25453
			[FieldOffset(8)]
			public byte SpeakerName;

			// Token: 0x0400636E RID: 25454
			[FieldOffset(32)]
			public byte DialogueKey;

			// Token: 0x0400636F RID: 25455
			[FieldOffset(56)]
			public int SpeakerId;

			// Token: 0x04006370 RID: 25456
			[FieldOffset(64)]
			public byte UnisonIdList;
		}

		// Token: 0x02000F7D RID: 3965
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006371 RID: 25457
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
