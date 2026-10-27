using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019D4 RID: 6612
	public sealed class FTriggerMechanismEventDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060188DB RID: 100571 RVA: 0x0024287D File Offset: 0x00240A7D
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FTriggerMechanismEventDelegate.StaticFunctionPtr();
		}

		// Token: 0x060188DC RID: 100572 RVA: 0x00242889 File Offset: 0x00240A89
		private static IntPtr StaticFunctionPtr()
		{
			if (FTriggerMechanismEventDelegate._FunctionPtr == IntPtr.Zero)
			{
				FTriggerMechanismEventDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroMechanismSequenceRuntime.TriggerMechanismEventDelegate__DelegateSignature");
			}
			return FTriggerMechanismEventDelegate._FunctionPtr;
		}

		// Token: 0x060188DD RID: 100573 RVA: 0x002428AC File Offset: 0x00240AAC
		public FTriggerMechanismEventDelegate()
		{
		}

		// Token: 0x060188DE RID: 100574 RVA: 0x002428B4 File Offset: 0x00240AB4
		[NullableContext(2)]
		public FTriggerMechanismEventDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060188DF RID: 100575 RVA: 0x002428BE File Offset: 0x00240ABE
		public FTriggerMechanismEventDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060188E0 RID: 100576 RVA: 0x002428C9 File Offset: 0x00240AC9
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FName, FName, EMechanismEventExecuteType, UMovieSceneSequencePlayer, uint>) ?? ((Action<FName, FName, EMechanismEventExecuteType, UMovieSceneSequencePlayer, uint>)Delegate.CreateDelegate(typeof(Action<FName, FName, EMechanismEventExecuteType, UMovieSceneSequencePlayer, uint>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060188E1 RID: 100577 RVA: 0x002428FB File Offset: 0x00240AFB
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<FName, FName, EMechanismEventExecuteType, UMovieSceneSequencePlayer, uint> Callback)
		{
			if (FTriggerMechanismEventDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FTriggerMechanismEventDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FTriggerMechanismEventDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FTriggerMechanismEventDelegate.OnScriptCallback));
				}
				FTriggerMechanismEventDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FTriggerMechanismEventDelegate.RegisterId);
		}

		// Token: 0x060188E2 RID: 100578 RVA: 0x00242938 File Offset: 0x00240B38
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(in FName EventType, in FName EventName, EMechanismEventExecuteType ExecuteType, UMovieSceneSequencePlayer Sequence, uint SectionId)
		{
			FTriggerMechanismEventDelegate.__FTriggerMechanismEventDelegate_DelegateParams* ptr = stackalloc FTriggerMechanismEventDelegate.__FTriggerMechanismEventDelegate_DelegateParams[(UIntPtr)63] + 15L / (long)sizeof(FTriggerMechanismEventDelegate.__FTriggerMechanismEventDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FTriggerMechanismEventDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EventType = EventType;
			ptr->EventName = EventName;
			ptr->ExecuteType = ExecuteType;
			ptr->Sequence = ((Sequence != null) ? Sequence.NativePtr : IntPtr.Zero);
			ptr->SectionId = SectionId;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060188E3 RID: 100579 RVA: 0x002429B0 File Offset: 0x00240BB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FName, FName, EMechanismEventExecuteType, UMovieSceneSequencePlayer, uint> action = target as Action<FName, FName, EMechanismEventExecuteType, UMovieSceneSequencePlayer, uint>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UMovieSceneSequencePlayer orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMovieSceneSequencePlayer>(((FTriggerMechanismEventDelegate.__FTriggerMechanismEventDelegate_DelegateParams*)__Parameters)->Sequence);
			action(((FTriggerMechanismEventDelegate.__FTriggerMechanismEventDelegate_DelegateParams*)__Parameters)->EventType, ((FTriggerMechanismEventDelegate.__FTriggerMechanismEventDelegate_DelegateParams*)__Parameters)->EventName, ((FTriggerMechanismEventDelegate.__FTriggerMechanismEventDelegate_DelegateParams*)__Parameters)->ExecuteType, orCreateUObjectByNativePointer, ((FTriggerMechanismEventDelegate.__FTriggerMechanismEventDelegate_DelegateParams*)__Parameters)->SectionId);
		}

		// Token: 0x0400D443 RID: 54339
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D444 RID: 54340
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroMechanismSequenceRuntime.TriggerMechanismEventDelegate__DelegateSignature";

		// Token: 0x0400D445 RID: 54341
		private static int RegisterId;

		// Token: 0x0200308A RID: 12426
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __FTriggerMechanismEventDelegate_DelegateParams
		{
			// Token: 0x04016D71 RID: 93553
			[FieldOffset(0)]
			public FName EventType;

			// Token: 0x04016D72 RID: 93554
			[FieldOffset(12)]
			public FName EventName;

			// Token: 0x04016D73 RID: 93555
			[FieldOffset(24)]
			public EMechanismEventExecuteType ExecuteType;

			// Token: 0x04016D74 RID: 93556
			[FieldOffset(32)]
			public IntPtr Sequence;

			// Token: 0x04016D75 RID: 93557
			[FieldOffset(40)]
			public uint SectionId;
		}

		// Token: 0x0200308B RID: 12427
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016D76 RID: 93558
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
