using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C24 RID: 7204
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FRegisterLevelSequence : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601BD53 RID: 114003 RVA: 0x0028F73F File Offset: 0x0028D93F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FRegisterLevelSequence.StaticFunctionPtr();
		}

		// Token: 0x0601BD54 RID: 114004 RVA: 0x0028F74B File Offset: 0x0028D94B
		private static IntPtr StaticFunctionPtr()
		{
			if (FRegisterLevelSequence._FunctionPtr == IntPtr.Zero)
			{
				FRegisterLevelSequence._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRenderingRuntimeBPPlugin.RegisterLevelSequence__DelegateSignature");
			}
			return FRegisterLevelSequence._FunctionPtr;
		}

		// Token: 0x0601BD55 RID: 114005 RVA: 0x0028F76E File Offset: 0x0028D96E
		public FRegisterLevelSequence()
		{
		}

		// Token: 0x0601BD56 RID: 114006 RVA: 0x0028F776 File Offset: 0x0028D976
		[NullableContext(2)]
		public FRegisterLevelSequence(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601BD57 RID: 114007 RVA: 0x0028F780 File Offset: 0x0028D980
		public FRegisterLevelSequence(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601BD58 RID: 114008 RVA: 0x0028F78B File Offset: 0x0028D98B
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AKuroLevelSequenceActor>) ?? ((Action<AKuroLevelSequenceActor>)Delegate.CreateDelegate(typeof(Action<AKuroLevelSequenceActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601BD59 RID: 114009 RVA: 0x0028F7BD File Offset: 0x0028D9BD
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<AKuroLevelSequenceActor> Callback)
		{
			if (FRegisterLevelSequence.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FRegisterLevelSequence.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FRegisterLevelSequence.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FRegisterLevelSequence.OnScriptCallback));
				}
				FRegisterLevelSequence.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FRegisterLevelSequence.RegisterId);
		}

		// Token: 0x0601BD5A RID: 114010 RVA: 0x0028F7F7 File Offset: 0x0028D9F7
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<AKuroLevelSequenceActor> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601BD5B RID: 114011 RVA: 0x0028F800 File Offset: 0x0028DA00
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(AKuroLevelSequenceActor SequenceActor)
		{
			FRegisterLevelSequence.__FRegisterLevelSequence_DelegateParams* ptr = stackalloc FRegisterLevelSequence.__FRegisterLevelSequence_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FRegisterLevelSequence.__FRegisterLevelSequence_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FRegisterLevelSequence.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->SequenceActor = ((SequenceActor != null) ? SequenceActor.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601BD5C RID: 114012 RVA: 0x0028F84C File Offset: 0x0028DA4C
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
			AKuroLevelSequenceActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AKuroLevelSequenceActor>(((FRegisterLevelSequence.__FRegisterLevelSequence_DelegateParams*)__Parameters)->SequenceActor);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0400EF53 RID: 61267
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400EF54 RID: 61268
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.RegisterLevelSequence__DelegateSignature";

		// Token: 0x0400EF55 RID: 61269
		private static int RegisterId;

		// Token: 0x020031A6 RID: 12710
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FRegisterLevelSequence_DelegateParams
		{
			// Token: 0x04016FE5 RID: 94181
			[FieldOffset(0)]
			public IntPtr SequenceActor;
		}

		// Token: 0x020031A7 RID: 12711
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016FE6 RID: 94182
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
