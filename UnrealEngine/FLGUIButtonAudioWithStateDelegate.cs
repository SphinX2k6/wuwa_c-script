using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200066E RID: 1646
	public sealed class FLGUIButtonAudioWithStateDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008EE8 RID: 36584 RVA: 0x000D6D62 File Offset: 0x000D4F62
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIButtonAudioWithStateDelegate.StaticFunctionPtr();
		}

		// Token: 0x06008EE9 RID: 36585 RVA: 0x000D6D6E File Offset: 0x000D4F6E
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIButtonAudioWithStateDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIButtonAudioWithStateDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIButtonAudioWithStateDelegate__DelegateSignature");
			}
			return FLGUIButtonAudioWithStateDelegate._FunctionPtr;
		}

		// Token: 0x06008EEA RID: 36586 RVA: 0x000D6D91 File Offset: 0x000D4F91
		public FLGUIButtonAudioWithStateDelegate()
		{
		}

		// Token: 0x06008EEB RID: 36587 RVA: 0x000D6D99 File Offset: 0x000D4F99
		[NullableContext(2)]
		public FLGUIButtonAudioWithStateDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008EEC RID: 36588 RVA: 0x000D6DA3 File Offset: 0x000D4FA3
		public FLGUIButtonAudioWithStateDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008EED RID: 36589 RVA: 0x000D6DAE File Offset: 0x000D4FAE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<EButtonAudioStateTransferType, string>) ?? ((Action<EButtonAudioStateTransferType, string>)Delegate.CreateDelegate(typeof(Action<EButtonAudioStateTransferType, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008EEE RID: 36590 RVA: 0x000D6DE0 File Offset: 0x000D4FE0
		[NullableContext(1)]
		public void Bind(Action<EButtonAudioStateTransferType, string> Callback)
		{
			if (FLGUIButtonAudioWithStateDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIButtonAudioWithStateDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIButtonAudioWithStateDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIButtonAudioWithStateDelegate.OnScriptCallback));
				}
				FLGUIButtonAudioWithStateDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIButtonAudioWithStateDelegate.RegisterId);
		}

		// Token: 0x06008EEF RID: 36591 RVA: 0x000D6E1C File Offset: 0x000D501C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Execute(EButtonAudioStateTransferType StateTransfer, string EventName)
		{
			FLGUIButtonAudioWithStateDelegate.__FLGUIButtonAudioWithStateDelegate_DelegateParams* ptr = stackalloc FLGUIButtonAudioWithStateDelegate.__FLGUIButtonAudioWithStateDelegate_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FLGUIButtonAudioWithStateDelegate.__FLGUIButtonAudioWithStateDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIButtonAudioWithStateDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->StateTransfer = StateTransfer;
			FString.CopyFrom((void*)(&ptr->EventName), EventName);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FLGUIButtonAudioWithStateDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06008EF0 RID: 36592 RVA: 0x000D6E78 File Offset: 0x000D5078
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<EButtonAudioStateTransferType, string> action = target as Action<EButtonAudioStateTransferType, string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FLGUIButtonAudioWithStateDelegate.__FLGUIButtonAudioWithStateDelegate_DelegateParams*)__Parameters)->EventName));
			action(((FLGUIButtonAudioWithStateDelegate.__FLGUIButtonAudioWithStateDelegate_DelegateParams*)__Parameters)->StateTransfer, arg);
		}

		// Token: 0x04003EA8 RID: 16040
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003EA9 RID: 16041
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIButtonAudioWithStateDelegate__DelegateSignature";

		// Token: 0x04003EAA RID: 16042
		private static int RegisterId;

		// Token: 0x02000E7A RID: 3706
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FLGUIButtonAudioWithStateDelegate_DelegateParams
		{
			// Token: 0x04006225 RID: 25125
			[FieldOffset(0)]
			public EButtonAudioStateTransferType StateTransfer;

			// Token: 0x04006226 RID: 25126
			[FieldOffset(8)]
			public FString EventName;
		}

		// Token: 0x02000E7B RID: 3707
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006227 RID: 25127
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
