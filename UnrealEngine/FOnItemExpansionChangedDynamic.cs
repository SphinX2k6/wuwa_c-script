using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029A6 RID: 10662
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnItemExpansionChangedDynamic : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06027706 RID: 161542 RVA: 0x003C2762 File Offset: 0x003C0962
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnItemExpansionChangedDynamic.StaticFunctionPtr();
		}

		// Token: 0x06027707 RID: 161543 RVA: 0x003C276E File Offset: 0x003C096E
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnItemExpansionChangedDynamic._FunctionPtr == IntPtr.Zero)
			{
				FOnItemExpansionChangedDynamic._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.OnItemExpansionChangedDynamic__DelegateSignature");
			}
			return FOnItemExpansionChangedDynamic._FunctionPtr;
		}

		// Token: 0x06027708 RID: 161544 RVA: 0x003C2791 File Offset: 0x003C0991
		public FOnItemExpansionChangedDynamic()
		{
		}

		// Token: 0x06027709 RID: 161545 RVA: 0x003C2799 File Offset: 0x003C0999
		[NullableContext(2)]
		public FOnItemExpansionChangedDynamic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602770A RID: 161546 RVA: 0x003C27A3 File Offset: 0x003C09A3
		public FOnItemExpansionChangedDynamic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602770B RID: 161547 RVA: 0x003C27AE File Offset: 0x003C09AE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UObject, bool>) ?? ((Action<UObject, bool>)Delegate.CreateDelegate(typeof(Action<UObject, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0602770C RID: 161548 RVA: 0x003C27E0 File Offset: 0x003C09E0
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UObject, bool> Callback)
		{
			if (FOnItemExpansionChangedDynamic.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnItemExpansionChangedDynamic.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnItemExpansionChangedDynamic.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnItemExpansionChangedDynamic.OnScriptCallback));
				}
				FOnItemExpansionChangedDynamic.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnItemExpansionChangedDynamic.RegisterId);
		}

		// Token: 0x0602770D RID: 161549 RVA: 0x003C281A File Offset: 0x003C0A1A
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UObject, bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0602770E RID: 161550 RVA: 0x003C2824 File Offset: 0x003C0A24
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UObject Item, bool bIsExpanded)
		{
			FOnItemExpansionChangedDynamic.__FOnItemExpansionChangedDynamic_DelegateParams* ptr = stackalloc FOnItemExpansionChangedDynamic.__FOnItemExpansionChangedDynamic_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnItemExpansionChangedDynamic.__FOnItemExpansionChangedDynamic_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnItemExpansionChangedDynamic.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Item = ((Item != null) ? Item.NativePtr : IntPtr.Zero);
			ptr->bIsExpanded = bIsExpanded;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0602770F RID: 161551 RVA: 0x003C2878 File Offset: 0x003C0A78
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
			UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(((FOnItemExpansionChangedDynamic.__FOnItemExpansionChangedDynamic_DelegateParams*)__Parameters)->Item);
			action(orCreateUObjectByNativePointer, ((FOnItemExpansionChangedDynamic.__FOnItemExpansionChangedDynamic_DelegateParams*)__Parameters)->bIsExpanded);
		}

		// Token: 0x04015A51 RID: 88657
		internal static IntPtr _FunctionPtr;

		// Token: 0x04015A52 RID: 88658
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.OnItemExpansionChangedDynamic__DelegateSignature";

		// Token: 0x04015A53 RID: 88659
		private static int RegisterId;

		// Token: 0x02003BA3 RID: 15267
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnItemExpansionChangedDynamic_DelegateParams
		{
			// Token: 0x04017D81 RID: 97665
			[FieldOffset(0)]
			public IntPtr Item;

			// Token: 0x04017D82 RID: 97666
			[FieldOffset(8)]
			public bool bIsExpanded;
		}

		// Token: 0x02003BA4 RID: 15268
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D83 RID: 97667
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
