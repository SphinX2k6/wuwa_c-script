using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005F5 RID: 1525
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnPerceptionEventTrigger : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600877B RID: 34683 RVA: 0x000CB55A File Offset: 0x000C975A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnPerceptionEventTrigger.StaticFunctionPtr();
		}

		// Token: 0x0600877C RID: 34684 RVA: 0x000CB566 File Offset: 0x000C9766
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnPerceptionEventTrigger._FunctionPtr == IntPtr.Zero)
			{
				FOnPerceptionEventTrigger._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OnPerceptionEventTrigger__DelegateSignature");
			}
			return FOnPerceptionEventTrigger._FunctionPtr;
		}

		// Token: 0x0600877D RID: 34685 RVA: 0x000CB589 File Offset: 0x000C9789
		public FOnPerceptionEventTrigger()
		{
		}

		// Token: 0x0600877E RID: 34686 RVA: 0x000CB591 File Offset: 0x000C9791
		[NullableContext(2)]
		public FOnPerceptionEventTrigger(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600877F RID: 34687 RVA: 0x000CB59B File Offset: 0x000C979B
		public FOnPerceptionEventTrigger(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008780 RID: 34688 RVA: 0x000CB5A6 File Offset: 0x000C97A6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as FOnPerceptionEventTrigger.FOnPerceptionEventTrigger_ScriptDelegate) ?? ((FOnPerceptionEventTrigger.FOnPerceptionEventTrigger_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnPerceptionEventTrigger.FOnPerceptionEventTrigger_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008781 RID: 34689 RVA: 0x000CB5D8 File Offset: 0x000C97D8
		[NullableContext(1)]
		public void Add(FOnPerceptionEventTrigger.FOnPerceptionEventTrigger_ScriptDelegate Callback)
		{
			if (FOnPerceptionEventTrigger.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnPerceptionEventTrigger.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnPerceptionEventTrigger.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnPerceptionEventTrigger.OnScriptCallback));
				}
				FOnPerceptionEventTrigger.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnPerceptionEventTrigger.RegisterId);
		}

		// Token: 0x06008782 RID: 34690 RVA: 0x000CB612 File Offset: 0x000C9812
		[NullableContext(1)]
		public void Remove(FOnPerceptionEventTrigger.FOnPerceptionEventTrigger_ScriptDelegate Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06008783 RID: 34691 RVA: 0x000CB61C File Offset: 0x000C981C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> AddActor, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> RemoveActor, in TArray<int> RemoveActorIds, int Num)
		{
			FOnPerceptionEventTrigger.__FOnPerceptionEventTrigger_DelegateParams* ptr = stackalloc FOnPerceptionEventTrigger.__FOnPerceptionEventTrigger_DelegateParams[(UIntPtr)71] + 15L / (long)sizeof(FOnPerceptionEventTrigger.__FOnPerceptionEventTrigger_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnPerceptionEventTrigger.StaticFunctionPtr(), (void*)ptr, 1);
			TArray<AActor> tarray = AddActor;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->AddActor);
			}
			TArray<AActor> tarray2 = RemoveActor;
			if (tarray2 != null)
			{
				tarray2.MoveTo(&ptr->RemoveActor);
			}
			TArray<int> tarray3 = RemoveActorIds;
			if (tarray3 != null)
			{
				tarray3.MoveTo(&ptr->RemoveActorIds);
			}
			ptr->Num = Num;
			base.BroadcastInternal((void*)ptr);
			TArray<AActor> tarray4 = AddActor;
			if (tarray4 != null)
			{
				tarray4.MoveAssign(&ptr->AddActor);
			}
			TArray<AActor> tarray5 = RemoveActor;
			if (tarray5 != null)
			{
				tarray5.MoveAssign(&ptr->RemoveActor);
			}
			TArray<int> tarray6 = RemoveActorIds;
			if (tarray6 != null)
			{
				tarray6.MoveAssign(&ptr->RemoveActorIds);
			}
			UnrealReflectionUtils.DestroyStruct(FOnPerceptionEventTrigger._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06008784 RID: 34692 RVA: 0x000CB6E4 File Offset: 0x000C98E4
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FOnPerceptionEventTrigger.FOnPerceptionEventTrigger_ScriptDelegate fonPerceptionEventTrigger_ScriptDelegate = target as FOnPerceptionEventTrigger.FOnPerceptionEventTrigger_ScriptDelegate;
			if (fonPerceptionEventTrigger_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<AActor> tarray = new TArray<AActor>(&((FOnPerceptionEventTrigger.__FOnPerceptionEventTrigger_DelegateParams*)__Parameters)->AddActor, true, true);
			TArray<AActor> tarray2 = new TArray<AActor>(&((FOnPerceptionEventTrigger.__FOnPerceptionEventTrigger_DelegateParams*)__Parameters)->RemoveActor, true, true);
			TArray<int> tarray3 = new TArray<int>(&((FOnPerceptionEventTrigger.__FOnPerceptionEventTrigger_DelegateParams*)__Parameters)->RemoveActorIds, true, true);
			fonPerceptionEventTrigger_ScriptDelegate(tarray, tarray2, tarray3, ((FOnPerceptionEventTrigger.__FOnPerceptionEventTrigger_DelegateParams*)__Parameters)->Num);
			if (tarray != null)
			{
				tarray.CopyTo(&((FOnPerceptionEventTrigger.__FOnPerceptionEventTrigger_DelegateParams*)__Parameters)->AddActor, default(UScriptStructStackOnlyPtr));
			}
			if (tarray2 != null)
			{
				tarray2.CopyTo(&((FOnPerceptionEventTrigger.__FOnPerceptionEventTrigger_DelegateParams*)__Parameters)->RemoveActor, default(UScriptStructStackOnlyPtr));
			}
			if (tarray3 != null)
			{
				tarray3.CopyTo(&((FOnPerceptionEventTrigger.__FOnPerceptionEventTrigger_DelegateParams*)__Parameters)->RemoveActorIds, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x04003AEA RID: 15082
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003AEB RID: 15083
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OnPerceptionEventTrigger__DelegateSignature";

		// Token: 0x04003AEC RID: 15084
		private static int RegisterId;

		// Token: 0x02000E05 RID: 3589
		// (Invoke) Token: 0x0600BF13 RID: 48915
		public delegate void FOnPerceptionEventTrigger_ScriptDelegate([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> AddActor, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> RemoveActor, in TArray<int> RemoveActorIds, int Num);

		// Token: 0x02000E06 RID: 3590
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		private ref struct __FOnPerceptionEventTrigger_DelegateParams
		{
			// Token: 0x04006199 RID: 24985
			[FieldOffset(0)]
			public byte AddActor;

			// Token: 0x0400619A RID: 24986
			[FieldOffset(16)]
			public byte RemoveActor;

			// Token: 0x0400619B RID: 24987
			[FieldOffset(32)]
			public byte RemoveActorIds;

			// Token: 0x0400619C RID: 24988
			[FieldOffset(48)]
			public int Num;
		}

		// Token: 0x02000E07 RID: 3591
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400619D RID: 24989
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
