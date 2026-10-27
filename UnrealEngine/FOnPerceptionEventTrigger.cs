using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EE8 RID: 7912
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnPerceptionEventTrigger : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E130 RID: 123184 RVA: 0x002CA556 File Offset: 0x002C8756
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnPerceptionEventTrigger.StaticFunctionPtr();
		}

		// Token: 0x0601E131 RID: 123185 RVA: 0x002CA562 File Offset: 0x002C8762
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnPerceptionEventTrigger._FunctionPtr == IntPtr.Zero)
			{
				FOnPerceptionEventTrigger._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroUtility.OnPerceptionEventTrigger__DelegateSignature");
			}
			return FOnPerceptionEventTrigger._FunctionPtr;
		}

		// Token: 0x0601E132 RID: 123186 RVA: 0x002CA585 File Offset: 0x002C8785
		public FOnPerceptionEventTrigger()
		{
		}

		// Token: 0x0601E133 RID: 123187 RVA: 0x002CA58D File Offset: 0x002C878D
		[NullableContext(2)]
		public FOnPerceptionEventTrigger(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E134 RID: 123188 RVA: 0x002CA597 File Offset: 0x002C8797
		public FOnPerceptionEventTrigger(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E135 RID: 123189 RVA: 0x002CA5A2 File Offset: 0x002C87A2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as FOnPerceptionEventTrigger.FOnPerceptionEventTrigger_ScriptDelegate) ?? ((FOnPerceptionEventTrigger.FOnPerceptionEventTrigger_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnPerceptionEventTrigger.FOnPerceptionEventTrigger_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E136 RID: 123190 RVA: 0x002CA5D4 File Offset: 0x002C87D4
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601E137 RID: 123191 RVA: 0x002CA60E File Offset: 0x002C880E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(FOnPerceptionEventTrigger.FOnPerceptionEventTrigger_ScriptDelegate Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601E138 RID: 123192 RVA: 0x002CA618 File Offset: 0x002C8818
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601E139 RID: 123193 RVA: 0x002CA6E0 File Offset: 0x002C88E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04010412 RID: 66578
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010413 RID: 66579
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroUtility.OnPerceptionEventTrigger__DelegateSignature";

		// Token: 0x04010414 RID: 66580
		private static int RegisterId;

		// Token: 0x020033B8 RID: 13240
		// (Invoke) Token: 0x060285AA RID: 165290
		public delegate void FOnPerceptionEventTrigger_ScriptDelegate([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> AddActor, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> RemoveActor, in TArray<int> RemoveActorIds, int Num);

		// Token: 0x020033B9 RID: 13241
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __FOnPerceptionEventTrigger_DelegateParams
		{
			// Token: 0x0401736C RID: 95084
			[FieldOffset(0)]
			public byte AddActor;

			// Token: 0x0401736D RID: 95085
			[FieldOffset(16)]
			public byte RemoveActor;

			// Token: 0x0401736E RID: 95086
			[FieldOffset(32)]
			public byte RemoveActorIds;

			// Token: 0x0401736F RID: 95087
			[FieldOffset(48)]
			public int Num;
		}

		// Token: 0x020033BA RID: 13242
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017370 RID: 95088
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
