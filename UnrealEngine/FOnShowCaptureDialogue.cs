using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002708 RID: 9992
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnShowCaptureDialogue : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060250BB RID: 151739 RVA: 0x0036D418 File Offset: 0x0036B618
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnShowCaptureDialogue.StaticFunctionPtr();
		}

		// Token: 0x060250BC RID: 151740 RVA: 0x0036D424 File Offset: 0x0036B624
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnShowCaptureDialogue._FunctionPtr == IntPtr.Zero)
			{
				FOnShowCaptureDialogue._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SequenceDialogue.OnShowCaptureDialogue__DelegateSignature");
			}
			return FOnShowCaptureDialogue._FunctionPtr;
		}

		// Token: 0x060250BD RID: 151741 RVA: 0x0036D447 File Offset: 0x0036B647
		public FOnShowCaptureDialogue()
		{
		}

		// Token: 0x060250BE RID: 151742 RVA: 0x0036D44F File Offset: 0x0036B64F
		[NullableContext(2)]
		public FOnShowCaptureDialogue(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060250BF RID: 151743 RVA: 0x0036D459 File Offset: 0x0036B659
		public FOnShowCaptureDialogue(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060250C0 RID: 151744 RVA: 0x0036D464 File Offset: 0x0036B664
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool, FText, FText>) ?? ((Action<bool, FText, FText>)Delegate.CreateDelegate(typeof(Action<bool, FText, FText>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060250C1 RID: 151745 RVA: 0x0036D496 File Offset: 0x0036B696
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<bool, FText, FText> Callback)
		{
			if (FOnShowCaptureDialogue.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnShowCaptureDialogue.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnShowCaptureDialogue.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnShowCaptureDialogue.OnScriptCallback));
				}
				FOnShowCaptureDialogue.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnShowCaptureDialogue.RegisterId);
		}

		// Token: 0x060250C2 RID: 151746 RVA: 0x0036D4D0 File Offset: 0x0036B6D0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<bool, FText, FText> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060250C3 RID: 151747 RVA: 0x0036D4DC File Offset: 0x0036B6DC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(bool bShow, in FText SpeakerName, in FText DialogueKey)
		{
			FOnShowCaptureDialogue.__FOnShowCaptureDialogue_DelegateParams* ptr = stackalloc FOnShowCaptureDialogue.__FOnShowCaptureDialogue_DelegateParams[(UIntPtr)71] + 15L / (long)sizeof(FOnShowCaptureDialogue.__FOnShowCaptureDialogue_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnShowCaptureDialogue.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bShow = bShow;
			FText.NativeMove((void*)(&ptr->SpeakerName), SpeakerName.NativePtr);
			FText.NativeMove((void*)(&ptr->DialogueKey), DialogueKey.NativePtr);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FOnShowCaptureDialogue._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060250C4 RID: 151748 RVA: 0x0036D550 File Offset: 0x0036B750
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool, FText, FText> action = target as Action<bool, FText, FText>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FText arg = new FText(&((FOnShowCaptureDialogue.__FOnShowCaptureDialogue_DelegateParams*)__Parameters)->SpeakerName, true, true);
			FText arg2 = new FText(&((FOnShowCaptureDialogue.__FOnShowCaptureDialogue_DelegateParams*)__Parameters)->DialogueKey, true, true);
			action(((FOnShowCaptureDialogue.__FOnShowCaptureDialogue_DelegateParams*)__Parameters)->bShow, arg, arg2);
		}

		// Token: 0x04013F50 RID: 81744
		internal static IntPtr _FunctionPtr;

		// Token: 0x04013F51 RID: 81745
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SequenceDialogue.OnShowCaptureDialogue__DelegateSignature";

		// Token: 0x04013F52 RID: 81746
		private static int RegisterId;

		// Token: 0x020036AC RID: 13996
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __FOnShowCaptureDialogue_DelegateParams
		{
			// Token: 0x040177BF RID: 96191
			[FieldOffset(0)]
			public bool bShow;

			// Token: 0x040177C0 RID: 96192
			[FieldOffset(8)]
			public byte SpeakerName;

			// Token: 0x040177C1 RID: 96193
			[FieldOffset(32)]
			public byte DialogueKey;
		}

		// Token: 0x020036AD RID: 13997
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040177C2 RID: 96194
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
