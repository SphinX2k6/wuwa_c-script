using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006DA RID: 1754
	public sealed class FSequenceLoadedEvent : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06009513 RID: 38163 RVA: 0x000E0FE4 File Offset: 0x000DF1E4
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSequenceLoadedEvent.StaticFunctionPtr();
		}

		// Token: 0x06009514 RID: 38164 RVA: 0x000E0FF0 File Offset: 0x000DF1F0
		private static IntPtr StaticFunctionPtr()
		{
			if (FSequenceLoadedEvent._FunctionPtr == IntPtr.Zero)
			{
				FSequenceLoadedEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.SequenceLoadedEvent__DelegateSignature");
			}
			return FSequenceLoadedEvent._FunctionPtr;
		}

		// Token: 0x06009515 RID: 38165 RVA: 0x000E1013 File Offset: 0x000DF213
		public FSequenceLoadedEvent()
		{
		}

		// Token: 0x06009516 RID: 38166 RVA: 0x000E101B File Offset: 0x000DF21B
		[NullableContext(2)]
		public FSequenceLoadedEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009517 RID: 38167 RVA: 0x000E1025 File Offset: 0x000DF225
		public FSequenceLoadedEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009518 RID: 38168 RVA: 0x000E1030 File Offset: 0x000DF230
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<ULevelSequence>) ?? ((Action<ULevelSequence>)Delegate.CreateDelegate(typeof(Action<ULevelSequence>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06009519 RID: 38169 RVA: 0x000E1062 File Offset: 0x000DF262
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<ULevelSequence> Callback)
		{
			if (FSequenceLoadedEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FSequenceLoadedEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FSequenceLoadedEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FSequenceLoadedEvent.OnScriptCallback));
				}
				FSequenceLoadedEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FSequenceLoadedEvent.RegisterId);
		}

		// Token: 0x0600951A RID: 38170 RVA: 0x000E109C File Offset: 0x000DF29C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute(ULevelSequence Sequence)
		{
			FSequenceLoadedEvent.__FSequenceLoadedEvent_DelegateParams* ptr = stackalloc FSequenceLoadedEvent.__FSequenceLoadedEvent_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FSequenceLoadedEvent.__FSequenceLoadedEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSequenceLoadedEvent.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Sequence = ((Sequence != null) ? Sequence.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600951B RID: 38171 RVA: 0x000E10E8 File Offset: 0x000DF2E8
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<ULevelSequence> action = target as Action<ULevelSequence>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			ULevelSequence orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelSequence>(((FSequenceLoadedEvent.__FSequenceLoadedEvent_DelegateParams*)__Parameters)->Sequence);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x040040D2 RID: 16594
		internal static IntPtr _FunctionPtr;

		// Token: 0x040040D3 RID: 16595
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.SequenceLoadedEvent__DelegateSignature";

		// Token: 0x040040D4 RID: 16596
		private static int RegisterId;

		// Token: 0x02000F0F RID: 3855
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FSequenceLoadedEvent_DelegateParams
		{
			// Token: 0x040062DC RID: 25308
			[FieldOffset(0)]
			public IntPtr Sequence;
		}

		// Token: 0x02000F10 RID: 3856
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040062DD RID: 25309
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
