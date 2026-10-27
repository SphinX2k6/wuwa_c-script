using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002104 RID: 8452
	public sealed class FSequenceLoadedEvent : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601FCCE RID: 130254 RVA: 0x002F4A4D File Offset: 0x002F2C4D
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FSequenceLoadedEvent.StaticFunctionPtr();
		}

		// Token: 0x0601FCCF RID: 130255 RVA: 0x002F4A59 File Offset: 0x002F2C59
		private static IntPtr StaticFunctionPtr()
		{
			if (FSequenceLoadedEvent._FunctionPtr == IntPtr.Zero)
			{
				FSequenceLoadedEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.SequenceLoadedEvent__DelegateSignature");
			}
			return FSequenceLoadedEvent._FunctionPtr;
		}

		// Token: 0x0601FCD0 RID: 130256 RVA: 0x002F4A7C File Offset: 0x002F2C7C
		public FSequenceLoadedEvent()
		{
		}

		// Token: 0x0601FCD1 RID: 130257 RVA: 0x002F4A84 File Offset: 0x002F2C84
		[NullableContext(2)]
		public FSequenceLoadedEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FCD2 RID: 130258 RVA: 0x002F4A8E File Offset: 0x002F2C8E
		public FSequenceLoadedEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FCD3 RID: 130259 RVA: 0x002F4A99 File Offset: 0x002F2C99
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<ULevelSequence>) ?? ((Action<ULevelSequence>)Delegate.CreateDelegate(typeof(Action<ULevelSequence>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601FCD4 RID: 130260 RVA: 0x002F4ACB File Offset: 0x002F2CCB
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601FCD5 RID: 130261 RVA: 0x002F4B08 File Offset: 0x002F2D08
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(ULevelSequence Sequence)
		{
			FSequenceLoadedEvent.__FSequenceLoadedEvent_DelegateParams* ptr = stackalloc FSequenceLoadedEvent.__FSequenceLoadedEvent_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FSequenceLoadedEvent.__FSequenceLoadedEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FSequenceLoadedEvent.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Sequence = ((Sequence != null) ? Sequence.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601FCD6 RID: 130262 RVA: 0x002F4B54 File Offset: 0x002F2D54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04011234 RID: 70196
		internal static IntPtr _FunctionPtr;

		// Token: 0x04011235 RID: 70197
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.SequenceLoadedEvent__DelegateSignature";

		// Token: 0x04011236 RID: 70198
		private static int RegisterId;

		// Token: 0x020034E3 RID: 13539
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FSequenceLoadedEvent_DelegateParams
		{
			// Token: 0x040174F7 RID: 95479
			[FieldOffset(0)]
			public IntPtr Sequence;
		}

		// Token: 0x020034E4 RID: 13540
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040174F8 RID: 95480
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
