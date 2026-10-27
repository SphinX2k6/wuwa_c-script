using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C34 RID: 7220
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FUnRegisterLevelSequence : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601BFA2 RID: 114594 RVA: 0x00292A3F File Offset: 0x00290C3F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FUnRegisterLevelSequence.StaticFunctionPtr();
		}

		// Token: 0x0601BFA3 RID: 114595 RVA: 0x00292A4B File Offset: 0x00290C4B
		private static IntPtr StaticFunctionPtr()
		{
			if (FUnRegisterLevelSequence._FunctionPtr == IntPtr.Zero)
			{
				FUnRegisterLevelSequence._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRenderingRuntimeBPPlugin.UnRegisterLevelSequence__DelegateSignature");
			}
			return FUnRegisterLevelSequence._FunctionPtr;
		}

		// Token: 0x0601BFA4 RID: 114596 RVA: 0x00292A6E File Offset: 0x00290C6E
		public FUnRegisterLevelSequence()
		{
		}

		// Token: 0x0601BFA5 RID: 114597 RVA: 0x00292A76 File Offset: 0x00290C76
		[NullableContext(2)]
		public FUnRegisterLevelSequence(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601BFA6 RID: 114598 RVA: 0x00292A80 File Offset: 0x00290C80
		public FUnRegisterLevelSequence(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601BFA7 RID: 114599 RVA: 0x00292A8B File Offset: 0x00290C8B
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AKuroLevelSequenceActor>) ?? ((Action<AKuroLevelSequenceActor>)Delegate.CreateDelegate(typeof(Action<AKuroLevelSequenceActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601BFA8 RID: 114600 RVA: 0x00292ABD File Offset: 0x00290CBD
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<AKuroLevelSequenceActor> Callback)
		{
			if (FUnRegisterLevelSequence.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FUnRegisterLevelSequence.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FUnRegisterLevelSequence.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FUnRegisterLevelSequence.OnScriptCallback));
				}
				FUnRegisterLevelSequence.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FUnRegisterLevelSequence.RegisterId);
		}

		// Token: 0x0601BFA9 RID: 114601 RVA: 0x00292AF7 File Offset: 0x00290CF7
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<AKuroLevelSequenceActor> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601BFAA RID: 114602 RVA: 0x00292B00 File Offset: 0x00290D00
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(AKuroLevelSequenceActor SequenceActor)
		{
			FUnRegisterLevelSequence.__FUnRegisterLevelSequence_DelegateParams* ptr = stackalloc FUnRegisterLevelSequence.__FUnRegisterLevelSequence_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FUnRegisterLevelSequence.__FUnRegisterLevelSequence_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FUnRegisterLevelSequence.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->SequenceActor = ((SequenceActor != null) ? SequenceActor.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601BFAB RID: 114603 RVA: 0x00292B4C File Offset: 0x00290D4C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<AKuroLevelSequenceActor> action = target as Action<AKuroLevelSequenceActor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AKuroLevelSequenceActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AKuroLevelSequenceActor>(((FUnRegisterLevelSequence.__FUnRegisterLevelSequence_DelegateParams*)__Parameters)->SequenceActor);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0400F060 RID: 61536
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400F061 RID: 61537
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.UnRegisterLevelSequence__DelegateSignature";

		// Token: 0x0400F062 RID: 61538
		private static int RegisterId;

		// Token: 0x020031AC RID: 12716
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FUnRegisterLevelSequence_DelegateParams
		{
			// Token: 0x04016FF0 RID: 94192
			[FieldOffset(0)]
			public IntPtr SequenceActor;
		}

		// Token: 0x020031AD RID: 12717
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016FF1 RID: 94193
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
