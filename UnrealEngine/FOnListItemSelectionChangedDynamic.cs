using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029AD RID: 10669
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnListItemSelectionChangedDynamic : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602774C RID: 161612 RVA: 0x003C3183 File Offset: 0x003C1383
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnListItemSelectionChangedDynamic.StaticFunctionPtr();
		}

		// Token: 0x0602774D RID: 161613 RVA: 0x003C318F File Offset: 0x003C138F
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnListItemSelectionChangedDynamic._FunctionPtr == IntPtr.Zero)
			{
				FOnListItemSelectionChangedDynamic._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.OnListItemSelectionChangedDynamic__DelegateSignature");
			}
			return FOnListItemSelectionChangedDynamic._FunctionPtr;
		}

		// Token: 0x0602774E RID: 161614 RVA: 0x003C31B2 File Offset: 0x003C13B2
		public FOnListItemSelectionChangedDynamic()
		{
		}

		// Token: 0x0602774F RID: 161615 RVA: 0x003C31BA File Offset: 0x003C13BA
		[NullableContext(2)]
		public FOnListItemSelectionChangedDynamic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027750 RID: 161616 RVA: 0x003C31C4 File Offset: 0x003C13C4
		public FOnListItemSelectionChangedDynamic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027751 RID: 161617 RVA: 0x003C31CF File Offset: 0x003C13CF
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UObject, bool>) ?? ((Action<UObject, bool>)Delegate.CreateDelegate(typeof(Action<UObject, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06027752 RID: 161618 RVA: 0x003C3201 File Offset: 0x003C1401
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UObject, bool> Callback)
		{
			if (FOnListItemSelectionChangedDynamic.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnListItemSelectionChangedDynamic.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnListItemSelectionChangedDynamic.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnListItemSelectionChangedDynamic.OnScriptCallback));
				}
				FOnListItemSelectionChangedDynamic.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnListItemSelectionChangedDynamic.RegisterId);
		}

		// Token: 0x06027753 RID: 161619 RVA: 0x003C323B File Offset: 0x003C143B
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UObject, bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06027754 RID: 161620 RVA: 0x003C3244 File Offset: 0x003C1444
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UObject Item, bool bIsSelected)
		{
			FOnListItemSelectionChangedDynamic.__FOnListItemSelectionChangedDynamic_DelegateParams* ptr = stackalloc FOnListItemSelectionChangedDynamic.__FOnListItemSelectionChangedDynamic_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnListItemSelectionChangedDynamic.__FOnListItemSelectionChangedDynamic_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnListItemSelectionChangedDynamic.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Item = ((Item != null) ? Item.NativePtr : IntPtr.Zero);
			ptr->bIsSelected = bIsSelected;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06027755 RID: 161621 RVA: 0x003C3298 File Offset: 0x003C1498
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UObject, bool> action = target as Action<UObject, bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(((FOnListItemSelectionChangedDynamic.__FOnListItemSelectionChangedDynamic_DelegateParams*)__Parameters)->Item);
			action(orCreateUObjectByNativePointer, ((FOnListItemSelectionChangedDynamic.__FOnListItemSelectionChangedDynamic_DelegateParams*)__Parameters)->bIsSelected);
		}

		// Token: 0x04015A65 RID: 88677
		internal static IntPtr _FunctionPtr;

		// Token: 0x04015A66 RID: 88678
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.OnListItemSelectionChangedDynamic__DelegateSignature";

		// Token: 0x04015A67 RID: 88679
		private static int RegisterId;

		// Token: 0x02003BB1 RID: 15281
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnListItemSelectionChangedDynamic_DelegateParams
		{
			// Token: 0x04017D93 RID: 97683
			[FieldOffset(0)]
			public IntPtr Item;

			// Token: 0x04017D94 RID: 97684
			[FieldOffset(8)]
			public bool bIsSelected;
		}

		// Token: 0x02003BB2 RID: 15282
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D95 RID: 97685
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
