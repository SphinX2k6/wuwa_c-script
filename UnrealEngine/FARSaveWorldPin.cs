using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003C1 RID: 961
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FARSaveWorldPin : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06003547 RID: 13639 RVA: 0x00051513 File Offset: 0x0004F713
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FARSaveWorldPin.StaticFunctionPtr();
		}

		// Token: 0x06003548 RID: 13640 RVA: 0x0005151F File Offset: 0x0004F71F
		private static IntPtr StaticFunctionPtr()
		{
			if (FARSaveWorldPin._FunctionPtr == IntPtr.Zero)
			{
				FARSaveWorldPin._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AugmentedReality.ARSaveWorldPin__DelegateSignature");
			}
			return FARSaveWorldPin._FunctionPtr;
		}

		// Token: 0x06003549 RID: 13641 RVA: 0x00051542 File Offset: 0x0004F742
		public FARSaveWorldPin()
		{
		}

		// Token: 0x0600354A RID: 13642 RVA: 0x0005154A File Offset: 0x0004F74A
		[NullableContext(2)]
		public FARSaveWorldPin(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600354B RID: 13643 RVA: 0x00051554 File Offset: 0x0004F754
		public FARSaveWorldPin(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600354C RID: 13644 RVA: 0x0005155F File Offset: 0x0004F75F
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as FARSaveWorldPin.FARSaveWorldPin_ScriptDelegate) ?? ((FARSaveWorldPin.FARSaveWorldPin_ScriptDelegate)Delegate.CreateDelegate(typeof(FARSaveWorldPin.FARSaveWorldPin_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600354D RID: 13645 RVA: 0x00051591 File Offset: 0x0004F791
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(FARSaveWorldPin.FARSaveWorldPin_ScriptDelegate Callback)
		{
			if (FARSaveWorldPin.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FARSaveWorldPin.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FARSaveWorldPin.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FARSaveWorldPin.OnScriptCallback));
				}
				FARSaveWorldPin.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FARSaveWorldPin.RegisterId);
		}

		// Token: 0x0600354E RID: 13646 RVA: 0x000515CB File Offset: 0x0004F7CB
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(FARSaveWorldPin.FARSaveWorldPin_ScriptDelegate Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600354F RID: 13647 RVA: 0x000515D4 File Offset: 0x0004F7D4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(in TArray<byte> SavedWorld)
		{
			FARSaveWorldPin.__FARSaveWorldPin_DelegateParams* ptr = stackalloc FARSaveWorldPin.__FARSaveWorldPin_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FARSaveWorldPin.__FARSaveWorldPin_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FARSaveWorldPin.StaticFunctionPtr(), (void*)ptr, 1);
			TArray<byte> tarray = SavedWorld;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->SavedWorld);
			}
			base.BroadcastInternal((void*)ptr);
			TArray<byte> tarray2 = SavedWorld;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->SavedWorld);
			}
			UnrealReflectionUtils.DestroyStruct(FARSaveWorldPin._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06003550 RID: 13648 RVA: 0x00051644 File Offset: 0x0004F844
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FARSaveWorldPin.FARSaveWorldPin_ScriptDelegate farsaveWorldPin_ScriptDelegate = target as FARSaveWorldPin.FARSaveWorldPin_ScriptDelegate;
			if (farsaveWorldPin_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<byte> tarray = new TArray<byte>(&((FARSaveWorldPin.__FARSaveWorldPin_DelegateParams*)__Parameters)->SavedWorld, true, true);
			farsaveWorldPin_ScriptDelegate(tarray);
			if (tarray != null)
			{
				tarray.CopyTo(&((FARSaveWorldPin.__FARSaveWorldPin_DelegateParams*)__Parameters)->SavedWorld, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x0400171D RID: 5917
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400171E RID: 5918
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AugmentedReality.ARSaveWorldPin__DelegateSignature";

		// Token: 0x0400171F RID: 5919
		private static int RegisterId;

		// Token: 0x02002C1B RID: 11291
		// (Invoke) Token: 0x0602852A RID: 165162
		public delegate void FARSaveWorldPin_ScriptDelegate(in TArray<byte> SavedWorld);

		// Token: 0x02002C1C RID: 11292
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FARSaveWorldPin_DelegateParams
		{
			// Token: 0x04016520 RID: 91424
			[FieldOffset(0)]
			public byte SavedWorld;
		}

		// Token: 0x02002C1D RID: 11293
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016521 RID: 91425
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
