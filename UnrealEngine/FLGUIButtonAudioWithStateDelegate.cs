using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200202A RID: 8234
	public sealed class FLGUIButtonAudioWithStateDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F186 RID: 127366 RVA: 0x002E3476 File Offset: 0x002E1676
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIButtonAudioWithStateDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F187 RID: 127367 RVA: 0x002E3482 File Offset: 0x002E1682
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIButtonAudioWithStateDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIButtonAudioWithStateDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIButtonAudioWithStateDelegate__DelegateSignature");
			}
			return FLGUIButtonAudioWithStateDelegate._FunctionPtr;
		}

		// Token: 0x0601F188 RID: 127368 RVA: 0x002E34A5 File Offset: 0x002E16A5
		public FLGUIButtonAudioWithStateDelegate()
		{
		}

		// Token: 0x0601F189 RID: 127369 RVA: 0x002E34AD File Offset: 0x002E16AD
		[NullableContext(2)]
		public FLGUIButtonAudioWithStateDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F18A RID: 127370 RVA: 0x002E34B7 File Offset: 0x002E16B7
		public FLGUIButtonAudioWithStateDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F18B RID: 127371 RVA: 0x002E34C2 File Offset: 0x002E16C2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<EButtonAudioStateTransferType, string>) ?? ((Action<EButtonAudioStateTransferType, string>)Delegate.CreateDelegate(typeof(Action<EButtonAudioStateTransferType, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F18C RID: 127372 RVA: 0x002E34F4 File Offset: 0x002E16F4
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601F18D RID: 127373 RVA: 0x002E3530 File Offset: 0x002E1730
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(EButtonAudioStateTransferType StateTransfer, string EventName)
		{
			FLGUIButtonAudioWithStateDelegate.__FLGUIButtonAudioWithStateDelegate_DelegateParams* ptr = stackalloc FLGUIButtonAudioWithStateDelegate.__FLGUIButtonAudioWithStateDelegate_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FLGUIButtonAudioWithStateDelegate.__FLGUIButtonAudioWithStateDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIButtonAudioWithStateDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->StateTransfer = StateTransfer;
			FString.CopyFrom((void*)(&ptr->EventName), EventName);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FLGUIButtonAudioWithStateDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F18E RID: 127374 RVA: 0x002E358C File Offset: 0x002E178C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04010DAB RID: 69035
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010DAC RID: 69036
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIButtonAudioWithStateDelegate__DelegateSignature";

		// Token: 0x04010DAD RID: 69037
		private static int RegisterId;

		// Token: 0x02003437 RID: 13367
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FLGUIButtonAudioWithStateDelegate_DelegateParams
		{
			// Token: 0x04017416 RID: 95254
			[FieldOffset(0)]
			public EButtonAudioStateTransferType StateTransfer;

			// Token: 0x04017417 RID: 95255
			[FieldOffset(8)]
			public FString EventName;
		}

		// Token: 0x02003438 RID: 13368
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017418 RID: 95256
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
