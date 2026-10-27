using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029AC RID: 10668
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnListItemScrolledIntoViewDynamic : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06027742 RID: 161602 RVA: 0x003C2FFD File Offset: 0x003C11FD
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnListItemScrolledIntoViewDynamic.StaticFunctionPtr();
		}

		// Token: 0x06027743 RID: 161603 RVA: 0x003C3009 File Offset: 0x003C1209
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnListItemScrolledIntoViewDynamic._FunctionPtr == IntPtr.Zero)
			{
				FOnListItemScrolledIntoViewDynamic._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.OnListItemScrolledIntoViewDynamic__DelegateSignature");
			}
			return FOnListItemScrolledIntoViewDynamic._FunctionPtr;
		}

		// Token: 0x06027744 RID: 161604 RVA: 0x003C302C File Offset: 0x003C122C
		public FOnListItemScrolledIntoViewDynamic()
		{
		}

		// Token: 0x06027745 RID: 161605 RVA: 0x003C3034 File Offset: 0x003C1234
		[NullableContext(2)]
		public FOnListItemScrolledIntoViewDynamic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027746 RID: 161606 RVA: 0x003C303E File Offset: 0x003C123E
		public FOnListItemScrolledIntoViewDynamic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027747 RID: 161607 RVA: 0x003C3049 File Offset: 0x003C1249
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UObject, UUserWidget>) ?? ((Action<UObject, UUserWidget>)Delegate.CreateDelegate(typeof(Action<UObject, UUserWidget>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06027748 RID: 161608 RVA: 0x003C307B File Offset: 0x003C127B
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Action<UObject, UUserWidget> Callback)
		{
			if (FOnListItemScrolledIntoViewDynamic.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnListItemScrolledIntoViewDynamic.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnListItemScrolledIntoViewDynamic.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnListItemScrolledIntoViewDynamic.OnScriptCallback));
				}
				FOnListItemScrolledIntoViewDynamic.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnListItemScrolledIntoViewDynamic.RegisterId);
		}

		// Token: 0x06027749 RID: 161609 RVA: 0x003C30B5 File Offset: 0x003C12B5
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Action<UObject, UUserWidget> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0602774A RID: 161610 RVA: 0x003C30C0 File Offset: 0x003C12C0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UObject Item, UUserWidget Widget)
		{
			FOnListItemScrolledIntoViewDynamic.__FOnListItemScrolledIntoViewDynamic_DelegateParams* ptr = stackalloc FOnListItemScrolledIntoViewDynamic.__FOnListItemScrolledIntoViewDynamic_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnListItemScrolledIntoViewDynamic.__FOnListItemScrolledIntoViewDynamic_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnListItemScrolledIntoViewDynamic.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Item = ((Item != null) ? Item.NativePtr : IntPtr.Zero);
			ptr->Widget = ((Widget != null) ? Widget.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0602774B RID: 161611 RVA: 0x003C3124 File Offset: 0x003C1324
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UObject, UUserWidget> action = target as Action<UObject, UUserWidget>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(((FOnListItemScrolledIntoViewDynamic.__FOnListItemScrolledIntoViewDynamic_DelegateParams*)__Parameters)->Item);
			UUserWidget orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UUserWidget>(((FOnListItemScrolledIntoViewDynamic.__FOnListItemScrolledIntoViewDynamic_DelegateParams*)__Parameters)->Widget);
			action(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
		}

		// Token: 0x04015A62 RID: 88674
		internal static IntPtr _FunctionPtr;

		// Token: 0x04015A63 RID: 88675
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.OnListItemScrolledIntoViewDynamic__DelegateSignature";

		// Token: 0x04015A64 RID: 88676
		private static int RegisterId;

		// Token: 0x02003BAF RID: 15279
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnListItemScrolledIntoViewDynamic_DelegateParams
		{
			// Token: 0x04017D90 RID: 97680
			[FieldOffset(0)]
			public IntPtr Item;

			// Token: 0x04017D91 RID: 97681
			[FieldOffset(8)]
			public IntPtr Widget;
		}

		// Token: 0x02003BB0 RID: 15280
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D92 RID: 97682
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
