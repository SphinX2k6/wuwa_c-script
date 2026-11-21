using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007DE RID: 2014
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnShowCaptureDialogue : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600AD2A RID: 44330 RVA: 0x001000BC File Offset: 0x000FE2BC
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnShowCaptureDialogue.StaticFunctionPtr();
		}

		// Token: 0x0600AD2B RID: 44331 RVA: 0x001000C8 File Offset: 0x000FE2C8
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnShowCaptureDialogue._FunctionPtr == IntPtr.Zero)
			{
				FOnShowCaptureDialogue._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SequenceDialogue.OnShowCaptureDialogue__DelegateSignature");
			}
			return FOnShowCaptureDialogue._FunctionPtr;
		}

		// Token: 0x0600AD2C RID: 44332 RVA: 0x001000EB File Offset: 0x000FE2EB
		public FOnShowCaptureDialogue()
		{
		}

		// Token: 0x0600AD2D RID: 44333 RVA: 0x001000F3 File Offset: 0x000FE2F3
		[NullableContext(2)]
		public FOnShowCaptureDialogue(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AD2E RID: 44334 RVA: 0x001000FD File Offset: 0x000FE2FD
		public FOnShowCaptureDialogue(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AD2F RID: 44335 RVA: 0x00100108 File Offset: 0x000FE308
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool, FText, FText>) ?? ((Action<bool, FText, FText>)Delegate.CreateDelegate(typeof(Action<bool, FText, FText>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600AD30 RID: 44336 RVA: 0x0010013A File Offset: 0x000FE33A
		[NullableContext(1)]
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

		// Token: 0x0600AD31 RID: 44337 RVA: 0x00100174 File Offset: 0x000FE374
		[NullableContext(1)]
		public void Remove(Action<bool, FText, FText> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600AD32 RID: 44338 RVA: 0x00100180 File Offset: 0x000FE380
		[NullableContext(1)]
		[SkipLocalsInit]
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

		// Token: 0x0600AD33 RID: 44339 RVA: 0x001001F4 File Offset: 0x000FE3F4
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04004AA3 RID: 19107
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004AA4 RID: 19108
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SequenceDialogue.OnShowCaptureDialogue__DelegateSignature";

		// Token: 0x04004AA5 RID: 19109
		private static int RegisterId;

		// Token: 0x02000F89 RID: 3977
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		private ref struct __FOnShowCaptureDialogue_DelegateParams
		{
			// Token: 0x04006383 RID: 25475
			[FieldOffset(0)]
			public bool bShow;

			// Token: 0x04006384 RID: 25476
			[FieldOffset(8)]
			public byte SpeakerName;

			// Token: 0x04006385 RID: 25477
			[FieldOffset(32)]
			public byte DialogueKey;
		}

		// Token: 0x02000F8A RID: 3978
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006386 RID: 25478
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
