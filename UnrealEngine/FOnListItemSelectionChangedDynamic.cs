using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200086A RID: 2154
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnListItemSelectionChangedDynamic : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600BB1A RID: 47898 RVA: 0x0012BA47 File Offset: 0x00129C47
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnListItemSelectionChangedDynamic.StaticFunctionPtr();
		}

		// Token: 0x0600BB1B RID: 47899 RVA: 0x0012BA53 File Offset: 0x00129C53
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnListItemSelectionChangedDynamic._FunctionPtr == IntPtr.Zero)
			{
				FOnListItemSelectionChangedDynamic._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.OnListItemSelectionChangedDynamic__DelegateSignature");
			}
			return FOnListItemSelectionChangedDynamic._FunctionPtr;
		}

		// Token: 0x0600BB1C RID: 47900 RVA: 0x0012BA76 File Offset: 0x00129C76
		public FOnListItemSelectionChangedDynamic()
		{
		}

		// Token: 0x0600BB1D RID: 47901 RVA: 0x0012BA7E File Offset: 0x00129C7E
		[NullableContext(2)]
		public FOnListItemSelectionChangedDynamic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600BB1E RID: 47902 RVA: 0x0012BA88 File Offset: 0x00129C88
		public FOnListItemSelectionChangedDynamic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600BB1F RID: 47903 RVA: 0x0012BA93 File Offset: 0x00129C93
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UObject, bool>) ?? ((Action<UObject, bool>)Delegate.CreateDelegate(typeof(Action<UObject, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600BB20 RID: 47904 RVA: 0x0012BAC5 File Offset: 0x00129CC5
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

		// Token: 0x0600BB21 RID: 47905 RVA: 0x0012BAFF File Offset: 0x00129CFF
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UObject, bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600BB22 RID: 47906 RVA: 0x0012BB08 File Offset: 0x00129D08
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(UObject Item, bool bIsSelected)
		{
			FOnListItemSelectionChangedDynamic.__FOnListItemSelectionChangedDynamic_DelegateParams* ptr = stackalloc FOnListItemSelectionChangedDynamic.__FOnListItemSelectionChangedDynamic_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnListItemSelectionChangedDynamic.__FOnListItemSelectionChangedDynamic_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnListItemSelectionChangedDynamic.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Item = ((Item != null) ? Item.NativePtr : IntPtr.Zero);
			ptr->bIsSelected = bIsSelected;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600BB23 RID: 47907 RVA: 0x0012BB5C File Offset: 0x00129D5C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x040054C8 RID: 21704
		internal static IntPtr _FunctionPtr;

		// Token: 0x040054C9 RID: 21705
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.OnListItemSelectionChangedDynamic__DelegateSignature";

		// Token: 0x040054CA RID: 21706
		private static int RegisterId;

		// Token: 0x02001409 RID: 5129
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FOnListItemSelectionChangedDynamic_DelegateParams
		{
			// Token: 0x040068B6 RID: 26806
			[FieldOffset(0)]
			public IntPtr Item;

			// Token: 0x040068B7 RID: 26807
			[FieldOffset(8)]
			public bool bIsSelected;
		}

		// Token: 0x0200140A RID: 5130
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040068B8 RID: 26808
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
