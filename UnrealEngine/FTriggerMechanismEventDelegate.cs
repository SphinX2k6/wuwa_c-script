using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000465 RID: 1125
	public sealed class FTriggerMechanismEventDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006B89 RID: 27529 RVA: 0x0009C8F1 File Offset: 0x0009AAF1
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FTriggerMechanismEventDelegate.StaticFunctionPtr();
		}

		// Token: 0x06006B8A RID: 27530 RVA: 0x0009C8FD File Offset: 0x0009AAFD
		private static IntPtr StaticFunctionPtr()
		{
			if (FTriggerMechanismEventDelegate._FunctionPtr == IntPtr.Zero)
			{
				FTriggerMechanismEventDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroMechanismSequenceRuntime.TriggerMechanismEventDelegate__DelegateSignature");
			}
			return FTriggerMechanismEventDelegate._FunctionPtr;
		}

		// Token: 0x06006B8B RID: 27531 RVA: 0x0009C920 File Offset: 0x0009AB20
		public FTriggerMechanismEventDelegate()
		{
		}

		// Token: 0x06006B8C RID: 27532 RVA: 0x0009C928 File Offset: 0x0009AB28
		[NullableContext(2)]
		public FTriggerMechanismEventDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006B8D RID: 27533 RVA: 0x0009C932 File Offset: 0x0009AB32
		public FTriggerMechanismEventDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006B8E RID: 27534 RVA: 0x0009C93D File Offset: 0x0009AB3D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FName, FName, EMechanismEventExecuteType, UMovieSceneSequencePlayer, uint>) ?? ((Action<FName, FName, EMechanismEventExecuteType, UMovieSceneSequencePlayer, uint>)Delegate.CreateDelegate(typeof(Action<FName, FName, EMechanismEventExecuteType, UMovieSceneSequencePlayer, uint>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006B8F RID: 27535 RVA: 0x0009C96F File Offset: 0x0009AB6F
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

		// Token: 0x06006B90 RID: 27536 RVA: 0x0009C9AC File Offset: 0x0009ABAC
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x06006B91 RID: 27537 RVA: 0x0009CA24 File Offset: 0x0009AC24
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04002DCB RID: 11723
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002DCC RID: 11724
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroMechanismSequenceRuntime.TriggerMechanismEventDelegate__DelegateSignature";

		// Token: 0x04002DCD RID: 11725
		private static int RegisterId;

		// Token: 0x02000B6E RID: 2926
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		private ref struct __FTriggerMechanismEventDelegate_DelegateParams
		{
			// Token: 0x04005C8F RID: 23695
			[FieldOffset(0)]
			public FName EventType;

			// Token: 0x04005C90 RID: 23696
			[FieldOffset(12)]
			public FName EventName;

			// Token: 0x04005C91 RID: 23697
			[FieldOffset(24)]
			public EMechanismEventExecuteType ExecuteType;

			// Token: 0x04005C92 RID: 23698
			[FieldOffset(32)]
			public IntPtr Sequence;

			// Token: 0x04005C93 RID: 23699
			[FieldOffset(40)]
			public uint SectionId;
		}

		// Token: 0x02000B6F RID: 2927
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005C94 RID: 23700
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
