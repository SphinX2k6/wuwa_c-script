using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029AA RID: 10666
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnListEntryInitializedDynamic : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602772E RID: 161582 RVA: 0x003C2D19 File Offset: 0x003C0F19
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnListEntryInitializedDynamic.StaticFunctionPtr();
		}

		// Token: 0x0602772F RID: 161583 RVA: 0x003C2D25 File Offset: 0x003C0F25
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnListEntryInitializedDynamic._FunctionPtr == IntPtr.Zero)
			{
				FOnListEntryInitializedDynamic._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.OnListEntryInitializedDynamic__DelegateSignature");
			}
			return FOnListEntryInitializedDynamic._FunctionPtr;
		}

		// Token: 0x06027730 RID: 161584 RVA: 0x003C2D48 File Offset: 0x003C0F48
		public FOnListEntryInitializedDynamic()
		{
		}

		// Token: 0x06027731 RID: 161585 RVA: 0x003C2D50 File Offset: 0x003C0F50
		[NullableContext(2)]
		public FOnListEntryInitializedDynamic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027732 RID: 161586 RVA: 0x003C2D5A File Offset: 0x003C0F5A
		public FOnListEntryInitializedDynamic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027733 RID: 161587 RVA: 0x003C2D65 File Offset: 0x003C0F65
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UObject, UUserWidget>) ?? ((Action<UObject, UUserWidget>)Delegate.CreateDelegate(typeof(Action<UObject, UUserWidget>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06027734 RID: 161588 RVA: 0x003C2D97 File Offset: 0x003C0F97
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Action<UObject, UUserWidget> Callback)
		{
			if (FOnListEntryInitializedDynamic.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnListEntryInitializedDynamic.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnListEntryInitializedDynamic.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnListEntryInitializedDynamic.OnScriptCallback));
				}
				FOnListEntryInitializedDynamic.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnListEntryInitializedDynamic.RegisterId);
		}

		// Token: 0x06027735 RID: 161589 RVA: 0x003C2DD1 File Offset: 0x003C0FD1
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

		// Token: 0x06027736 RID: 161590 RVA: 0x003C2DDC File Offset: 0x003C0FDC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UObject Item, UUserWidget Widget)
		{
			FOnListEntryInitializedDynamic.__FOnListEntryInitializedDynamic_DelegateParams* ptr = stackalloc FOnListEntryInitializedDynamic.__FOnListEntryInitializedDynamic_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnListEntryInitializedDynamic.__FOnListEntryInitializedDynamic_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnListEntryInitializedDynamic.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Item = ((Item != null) ? Item.NativePtr : IntPtr.Zero);
			ptr->Widget = ((Widget != null) ? Widget.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06027737 RID: 161591 RVA: 0x003C2E40 File Offset: 0x003C1040
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
			UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(((FOnListEntryInitializedDynamic.__FOnListEntryInitializedDynamic_DelegateParams*)__Parameters)->Item);
			UUserWidget orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UUserWidget>(((FOnListEntryInitializedDynamic.__FOnListEntryInitializedDynamic_DelegateParams*)__Parameters)->Widget);
			action(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
		}

		// Token: 0x04015A5C RID: 88668
		internal static IntPtr _FunctionPtr;

		// Token: 0x04015A5D RID: 88669
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.OnListEntryInitializedDynamic__DelegateSignature";

		// Token: 0x04015A5E RID: 88670
		private static int RegisterId;

		// Token: 0x02003BAB RID: 15275
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnListEntryInitializedDynamic_DelegateParams
		{
			// Token: 0x04017D8B RID: 97675
			[FieldOffset(0)]
			public IntPtr Item;

			// Token: 0x04017D8C RID: 97676
			[FieldOffset(8)]
			public IntPtr Widget;
		}

		// Token: 0x02003BAC RID: 15276
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D8D RID: 97677
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
