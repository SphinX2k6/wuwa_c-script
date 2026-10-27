using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002997 RID: 10647
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnCheckBoxComponentStateChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06027673 RID: 161395 RVA: 0x003C1392 File Offset: 0x003BF592
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnCheckBoxComponentStateChanged.StaticFunctionPtr();
		}

		// Token: 0x06027674 RID: 161396 RVA: 0x003C139E File Offset: 0x003BF59E
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnCheckBoxComponentStateChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnCheckBoxComponentStateChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.OnCheckBoxComponentStateChanged__DelegateSignature");
			}
			return FOnCheckBoxComponentStateChanged._FunctionPtr;
		}

		// Token: 0x06027675 RID: 161397 RVA: 0x003C13C1 File Offset: 0x003BF5C1
		public FOnCheckBoxComponentStateChanged()
		{
		}

		// Token: 0x06027676 RID: 161398 RVA: 0x003C13C9 File Offset: 0x003BF5C9
		[NullableContext(2)]
		public FOnCheckBoxComponentStateChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027677 RID: 161399 RVA: 0x003C13D3 File Offset: 0x003BF5D3
		public FOnCheckBoxComponentStateChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027678 RID: 161400 RVA: 0x003C13DE File Offset: 0x003BF5DE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06027679 RID: 161401 RVA: 0x003C1410 File Offset: 0x003BF610
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<bool> Callback)
		{
			if (FOnCheckBoxComponentStateChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnCheckBoxComponentStateChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnCheckBoxComponentStateChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnCheckBoxComponentStateChanged.OnScriptCallback));
				}
				FOnCheckBoxComponentStateChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnCheckBoxComponentStateChanged.RegisterId);
		}

		// Token: 0x0602767A RID: 161402 RVA: 0x003C144A File Offset: 0x003BF64A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0602767B RID: 161403 RVA: 0x003C1454 File Offset: 0x003BF654
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(bool bIsChecked)
		{
			FOnCheckBoxComponentStateChanged.__FOnCheckBoxComponentStateChanged_DelegateParams* ptr = stackalloc FOnCheckBoxComponentStateChanged.__FOnCheckBoxComponentStateChanged_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FOnCheckBoxComponentStateChanged.__FOnCheckBoxComponentStateChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnCheckBoxComponentStateChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bIsChecked = bIsChecked;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0602767C RID: 161404 RVA: 0x003C1490 File Offset: 0x003BF690
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnCheckBoxComponentStateChanged.__FOnCheckBoxComponentStateChanged_DelegateParams*)__Parameters)->bIsChecked);
		}

		// Token: 0x04015A2A RID: 88618
		internal static IntPtr _FunctionPtr;

		// Token: 0x04015A2B RID: 88619
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.OnCheckBoxComponentStateChanged__DelegateSignature";

		// Token: 0x04015A2C RID: 88620
		private static int RegisterId;

		// Token: 0x02003B89 RID: 15241
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FOnCheckBoxComponentStateChanged_DelegateParams
		{
			// Token: 0x04017D63 RID: 97635
			[FieldOffset(0)]
			public bool bIsChecked;
		}

		// Token: 0x02003B8A RID: 15242
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D64 RID: 97636
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
