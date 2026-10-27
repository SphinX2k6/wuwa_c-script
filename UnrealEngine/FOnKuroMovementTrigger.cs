using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019E7 RID: 6631
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnKuroMovementTrigger : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060189A1 RID: 100769 RVA: 0x00243F91 File Offset: 0x00242191
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnKuroMovementTrigger.StaticFunctionPtr();
		}

		// Token: 0x060189A2 RID: 100770 RVA: 0x00243F9D File Offset: 0x0024219D
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnKuroMovementTrigger._FunctionPtr == IntPtr.Zero)
			{
				FOnKuroMovementTrigger._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroMovement.OnKuroMovementTrigger__DelegateSignature");
			}
			return FOnKuroMovementTrigger._FunctionPtr;
		}

		// Token: 0x060189A3 RID: 100771 RVA: 0x00243FC0 File Offset: 0x002421C0
		public FOnKuroMovementTrigger()
		{
		}

		// Token: 0x060189A4 RID: 100772 RVA: 0x00243FC8 File Offset: 0x002421C8
		[NullableContext(2)]
		public FOnKuroMovementTrigger(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060189A5 RID: 100773 RVA: 0x00243FD2 File Offset: 0x002421D2
		public FOnKuroMovementTrigger(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060189A6 RID: 100774 RVA: 0x00243FDD File Offset: 0x002421DD
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as FOnKuroMovementTrigger.FOnKuroMovementTrigger_ScriptDelegate) ?? ((FOnKuroMovementTrigger.FOnKuroMovementTrigger_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnKuroMovementTrigger.FOnKuroMovementTrigger_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x060189A7 RID: 100775 RVA: 0x0024400F File Offset: 0x0024220F
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(FOnKuroMovementTrigger.FOnKuroMovementTrigger_ScriptDelegate Callback)
		{
			if (FOnKuroMovementTrigger.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnKuroMovementTrigger.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnKuroMovementTrigger.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnKuroMovementTrigger.OnScriptCallback));
				}
				FOnKuroMovementTrigger.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnKuroMovementTrigger.RegisterId);
		}

		// Token: 0x060189A8 RID: 100776 RVA: 0x00244049 File Offset: 0x00242249
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(FOnKuroMovementTrigger.FOnKuroMovementTrigger_ScriptDelegate Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060189A9 RID: 100777 RVA: 0x00244054 File Offset: 0x00242254
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FOverlapActorRecord> Records)
		{
			FOnKuroMovementTrigger.__FOnKuroMovementTrigger_DelegateParams* ptr = stackalloc FOnKuroMovementTrigger.__FOnKuroMovementTrigger_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnKuroMovementTrigger.__FOnKuroMovementTrigger_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnKuroMovementTrigger.StaticFunctionPtr(), (void*)ptr, 1);
			TArray<FOverlapActorRecord> tarray = Records;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Records);
			}
			base.BroadcastInternal((void*)ptr);
			TArray<FOverlapActorRecord> tarray2 = Records;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Records);
			}
			UnrealReflectionUtils.DestroyStruct(FOnKuroMovementTrigger._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060189AA RID: 100778 RVA: 0x002440C4 File Offset: 0x002422C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FOnKuroMovementTrigger.FOnKuroMovementTrigger_ScriptDelegate fonKuroMovementTrigger_ScriptDelegate = target as FOnKuroMovementTrigger.FOnKuroMovementTrigger_ScriptDelegate;
			if (fonKuroMovementTrigger_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<FOverlapActorRecord> tarray = new TArray<FOverlapActorRecord>(&((FOnKuroMovementTrigger.__FOnKuroMovementTrigger_DelegateParams*)__Parameters)->Records, true, true);
			fonKuroMovementTrigger_ScriptDelegate(tarray);
			if (tarray != null)
			{
				tarray.CopyTo(&((FOnKuroMovementTrigger.__FOnKuroMovementTrigger_DelegateParams*)__Parameters)->Records, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x0400D4C7 RID: 54471
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D4C8 RID: 54472
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroMovement.OnKuroMovementTrigger__DelegateSignature";

		// Token: 0x0400D4C9 RID: 54473
		private static int RegisterId;

		// Token: 0x02003096 RID: 12438
		// (Invoke) Token: 0x0602858E RID: 165262
		public delegate void FOnKuroMovementTrigger_ScriptDelegate([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FOverlapActorRecord> Records);

		// Token: 0x02003097 RID: 12439
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnKuroMovementTrigger_DelegateParams
		{
			// Token: 0x04016DBC RID: 93628
			[FieldOffset(0)]
			public byte Records;
		}

		// Token: 0x02003098 RID: 12440
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016DBD RID: 93629
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
