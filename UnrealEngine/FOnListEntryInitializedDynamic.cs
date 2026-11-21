using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000867 RID: 2151
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnListEntryInitializedDynamic : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600BAFC RID: 47868 RVA: 0x0012B5DD File Offset: 0x001297DD
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnListEntryInitializedDynamic.StaticFunctionPtr();
		}

		// Token: 0x0600BAFD RID: 47869 RVA: 0x0012B5E9 File Offset: 0x001297E9
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnListEntryInitializedDynamic._FunctionPtr == IntPtr.Zero)
			{
				FOnListEntryInitializedDynamic._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.OnListEntryInitializedDynamic__DelegateSignature");
			}
			return FOnListEntryInitializedDynamic._FunctionPtr;
		}

		// Token: 0x0600BAFE RID: 47870 RVA: 0x0012B60C File Offset: 0x0012980C
		public FOnListEntryInitializedDynamic()
		{
		}

		// Token: 0x0600BAFF RID: 47871 RVA: 0x0012B614 File Offset: 0x00129814
		[NullableContext(2)]
		public FOnListEntryInitializedDynamic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600BB00 RID: 47872 RVA: 0x0012B61E File Offset: 0x0012981E
		public FOnListEntryInitializedDynamic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600BB01 RID: 47873 RVA: 0x0012B629 File Offset: 0x00129829
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UObject, UUserWidget>) ?? ((Action<UObject, UUserWidget>)Delegate.CreateDelegate(typeof(Action<UObject, UUserWidget>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600BB02 RID: 47874 RVA: 0x0012B65B File Offset: 0x0012985B
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

		// Token: 0x0600BB03 RID: 47875 RVA: 0x0012B695 File Offset: 0x00129895
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Action<UObject, UUserWidget> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600BB04 RID: 47876 RVA: 0x0012B6A0 File Offset: 0x001298A0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(UObject Item, UUserWidget Widget)
		{
			FOnListEntryInitializedDynamic.__FOnListEntryInitializedDynamic_DelegateParams* ptr = stackalloc FOnListEntryInitializedDynamic.__FOnListEntryInitializedDynamic_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnListEntryInitializedDynamic.__FOnListEntryInitializedDynamic_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnListEntryInitializedDynamic.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Item = ((Item != null) ? Item.NativePtr : IntPtr.Zero);
			ptr->Widget = ((Widget != null) ? Widget.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600BB05 RID: 47877 RVA: 0x0012B704 File Offset: 0x00129904
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x040054BF RID: 21695
		internal static IntPtr _FunctionPtr;

		// Token: 0x040054C0 RID: 21696
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.OnListEntryInitializedDynamic__DelegateSignature";

		// Token: 0x040054C1 RID: 21697
		private static int RegisterId;

		// Token: 0x02001403 RID: 5123
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FOnListEntryInitializedDynamic_DelegateParams
		{
			// Token: 0x040068AE RID: 26798
			[FieldOffset(0)]
			public IntPtr Item;

			// Token: 0x040068AF RID: 26799
			[FieldOffset(8)]
			public IntPtr Widget;
		}

		// Token: 0x02001404 RID: 5124
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040068B0 RID: 26800
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
