using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000869 RID: 2153
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnListItemScrolledIntoViewDynamic : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600BB10 RID: 47888 RVA: 0x0012B8C1 File Offset: 0x00129AC1
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnListItemScrolledIntoViewDynamic.StaticFunctionPtr();
		}

		// Token: 0x0600BB11 RID: 47889 RVA: 0x0012B8CD File Offset: 0x00129ACD
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnListItemScrolledIntoViewDynamic._FunctionPtr == IntPtr.Zero)
			{
				FOnListItemScrolledIntoViewDynamic._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.OnListItemScrolledIntoViewDynamic__DelegateSignature");
			}
			return FOnListItemScrolledIntoViewDynamic._FunctionPtr;
		}

		// Token: 0x0600BB12 RID: 47890 RVA: 0x0012B8F0 File Offset: 0x00129AF0
		public FOnListItemScrolledIntoViewDynamic()
		{
		}

		// Token: 0x0600BB13 RID: 47891 RVA: 0x0012B8F8 File Offset: 0x00129AF8
		[NullableContext(2)]
		public FOnListItemScrolledIntoViewDynamic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600BB14 RID: 47892 RVA: 0x0012B902 File Offset: 0x00129B02
		public FOnListItemScrolledIntoViewDynamic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600BB15 RID: 47893 RVA: 0x0012B90D File Offset: 0x00129B0D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UObject, UUserWidget>) ?? ((Action<UObject, UUserWidget>)Delegate.CreateDelegate(typeof(Action<UObject, UUserWidget>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600BB16 RID: 47894 RVA: 0x0012B93F File Offset: 0x00129B3F
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

		// Token: 0x0600BB17 RID: 47895 RVA: 0x0012B979 File Offset: 0x00129B79
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Action<UObject, UUserWidget> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600BB18 RID: 47896 RVA: 0x0012B984 File Offset: 0x00129B84
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(UObject Item, UUserWidget Widget)
		{
			FOnListItemScrolledIntoViewDynamic.__FOnListItemScrolledIntoViewDynamic_DelegateParams* ptr = stackalloc FOnListItemScrolledIntoViewDynamic.__FOnListItemScrolledIntoViewDynamic_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnListItemScrolledIntoViewDynamic.__FOnListItemScrolledIntoViewDynamic_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnListItemScrolledIntoViewDynamic.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Item = ((Item != null) ? Item.NativePtr : IntPtr.Zero);
			ptr->Widget = ((Widget != null) ? Widget.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600BB19 RID: 47897 RVA: 0x0012B9E8 File Offset: 0x00129BE8
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x040054C5 RID: 21701
		internal static IntPtr _FunctionPtr;

		// Token: 0x040054C6 RID: 21702
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.OnListItemScrolledIntoViewDynamic__DelegateSignature";

		// Token: 0x040054C7 RID: 21703
		private static int RegisterId;

		// Token: 0x02001407 RID: 5127
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FOnListItemScrolledIntoViewDynamic_DelegateParams
		{
			// Token: 0x040068B3 RID: 26803
			[FieldOffset(0)]
			public IntPtr Item;

			// Token: 0x040068B4 RID: 26804
			[FieldOffset(8)]
			public IntPtr Widget;
		}

		// Token: 0x02001408 RID: 5128
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040068B5 RID: 26805
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
