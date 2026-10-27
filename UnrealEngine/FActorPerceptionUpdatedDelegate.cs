using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000DE RID: 222
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FActorPerceptionUpdatedDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060011B4 RID: 4532 RVA: 0x0001A6CC File Offset: 0x000188CC
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FActorPerceptionUpdatedDelegate.StaticFunctionPtr();
		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x0001A6D8 File Offset: 0x000188D8
		private static IntPtr StaticFunctionPtr()
		{
			if (FActorPerceptionUpdatedDelegate._FunctionPtr == IntPtr.Zero)
			{
				FActorPerceptionUpdatedDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AIModule.ActorPerceptionUpdatedDelegate__DelegateSignature");
			}
			return FActorPerceptionUpdatedDelegate._FunctionPtr;
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x0001A6FB File Offset: 0x000188FB
		public FActorPerceptionUpdatedDelegate()
		{
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x0001A703 File Offset: 0x00018903
		[NullableContext(2)]
		public FActorPerceptionUpdatedDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x0001A70D File Offset: 0x0001890D
		public FActorPerceptionUpdatedDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x0001A718 File Offset: 0x00018918
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AActor, FAIStimulus>) ?? ((Action<AActor, FAIStimulus>)Delegate.CreateDelegate(typeof(Action<AActor, FAIStimulus>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x0001A74A File Offset: 0x0001894A
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Action<AActor, FAIStimulus> Callback)
		{
			if (FActorPerceptionUpdatedDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FActorPerceptionUpdatedDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FActorPerceptionUpdatedDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FActorPerceptionUpdatedDelegate.OnScriptCallback));
				}
				FActorPerceptionUpdatedDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FActorPerceptionUpdatedDelegate.RegisterId);
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x0001A784 File Offset: 0x00018984
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Action<AActor, FAIStimulus> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x0001A790 File Offset: 0x00018990
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(AActor Actor, FAIStimulus Stimulus)
		{
			FActorPerceptionUpdatedDelegate.__FActorPerceptionUpdatedDelegate_DelegateParams* ptr = stackalloc FActorPerceptionUpdatedDelegate.__FActorPerceptionUpdatedDelegate_DelegateParams[(UIntPtr)95] + 15L / (long)sizeof(FActorPerceptionUpdatedDelegate.__FActorPerceptionUpdatedDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FActorPerceptionUpdatedDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			if (Stimulus != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAIStimulus.StaticStruct(), &ptr->Stimulus, Stimulus.NativePtr, 1, false);
			}
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060011BD RID: 4541 RVA: 0x0001A800 File Offset: 0x00018A00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<AActor, FAIStimulus> action = target as Action<AActor, FAIStimulus>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FActorPerceptionUpdatedDelegate.__FActorPerceptionUpdatedDelegate_DelegateParams*)__Parameters)->Actor);
			FAIStimulus arg = new FAIStimulus(&((FActorPerceptionUpdatedDelegate.__FActorPerceptionUpdatedDelegate_DelegateParams*)__Parameters)->Stimulus, true, true);
			action(orCreateUObjectByNativePointer, arg);
		}

		// Token: 0x040002E7 RID: 743
		internal static IntPtr _FunctionPtr;

		// Token: 0x040002E8 RID: 744
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AIModule.ActorPerceptionUpdatedDelegate__DelegateSignature";

		// Token: 0x040002E9 RID: 745
		private static int RegisterId;

		// Token: 0x02002B3D RID: 11069
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __FActorPerceptionUpdatedDelegate_DelegateParams
		{
			// Token: 0x0401639A RID: 91034
			[FieldOffset(0)]
			public IntPtr Actor;

			// Token: 0x0401639B RID: 91035
			[FieldOffset(8)]
			public byte Stimulus;
		}

		// Token: 0x02002B3E RID: 11070
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401639C RID: 91036
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
