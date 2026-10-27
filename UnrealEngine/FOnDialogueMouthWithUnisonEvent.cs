using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002703 RID: 9987
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnDialogueMouthWithUnisonEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06025089 RID: 151689 RVA: 0x0036CBA5 File Offset: 0x0036ADA5
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnDialogueMouthWithUnisonEvent.StaticFunctionPtr();
		}

		// Token: 0x0602508A RID: 151690 RVA: 0x0036CBB1 File Offset: 0x0036ADB1
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnDialogueMouthWithUnisonEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnDialogueMouthWithUnisonEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SequenceDialogue.OnDialogueMouthWithUnisonEvent__DelegateSignature");
			}
			return FOnDialogueMouthWithUnisonEvent._FunctionPtr;
		}

		// Token: 0x0602508B RID: 151691 RVA: 0x0036CBD4 File Offset: 0x0036ADD4
		public FOnDialogueMouthWithUnisonEvent()
		{
		}

		// Token: 0x0602508C RID: 151692 RVA: 0x0036CBDC File Offset: 0x0036ADDC
		[NullableContext(2)]
		public FOnDialogueMouthWithUnisonEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602508D RID: 151693 RVA: 0x0036CBE6 File Offset: 0x0036ADE6
		public FOnDialogueMouthWithUnisonEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602508E RID: 151694 RVA: 0x0036CBF1 File Offset: 0x0036ADF1
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as FOnDialogueMouthWithUnisonEvent.FOnDialogueMouthWithUnisonEvent_ScriptDelegate) ?? ((FOnDialogueMouthWithUnisonEvent.FOnDialogueMouthWithUnisonEvent_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnDialogueMouthWithUnisonEvent.FOnDialogueMouthWithUnisonEvent_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x0602508F RID: 151695 RVA: 0x0036CC23 File Offset: 0x0036AE23
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06025090 RID: 151696 RVA: 0x0036CC5D File Offset: 0x0036AE5D
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(FOnDialogueMouthWithUnisonEvent.FOnDialogueMouthWithUnisonEvent_ScriptDelegate Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06025091 RID: 151697 RVA: 0x0036CC68 File Offset: 0x0036AE68
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06025092 RID: 151698 RVA: 0x0036CD10 File Offset: 0x0036AF10
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04013F41 RID: 81729
		internal static IntPtr _FunctionPtr;

		// Token: 0x04013F42 RID: 81730
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SequenceDialogue.OnDialogueMouthWithUnisonEvent__DelegateSignature";

		// Token: 0x04013F43 RID: 81731
		private static int RegisterId;

		// Token: 0x020036A0 RID: 13984
		// (Invoke) Token: 0x060285C6 RID: 165318
		public delegate void FOnDialogueMouthWithUnisonEvent_ScriptDelegate(bool bShow, in FText SpeakerName, in FText DialogueKey, in int SpeakerId, [Nullable(2)] in TArray<int> UnisonIdList);

		// Token: 0x020036A1 RID: 13985
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __FOnDialogueMouthWithUnisonEvent_DelegateParams
		{
			// Token: 0x040177AA RID: 96170
			[FieldOffset(0)]
			public bool bShow;

			// Token: 0x040177AB RID: 96171
			[FieldOffset(8)]
			public byte SpeakerName;

			// Token: 0x040177AC RID: 96172
			[FieldOffset(32)]
			public byte DialogueKey;

			// Token: 0x040177AD RID: 96173
			[FieldOffset(56)]
			public int SpeakerId;

			// Token: 0x040177AE RID: 96174
			[FieldOffset(64)]
			public byte UnisonIdList;
		}

		// Token: 0x020036A2 RID: 13986
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040177AF RID: 96175
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
