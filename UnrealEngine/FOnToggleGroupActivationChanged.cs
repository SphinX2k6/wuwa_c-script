using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020F5 RID: 8437
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnToggleGroupActivationChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601FC27 RID: 130087 RVA: 0x002F3A41 File Offset: 0x002F1C41
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnToggleGroupActivationChanged.StaticFunctionPtr();
		}

		// Token: 0x0601FC28 RID: 130088 RVA: 0x002F3A4D File Offset: 0x002F1C4D
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnToggleGroupActivationChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnToggleGroupActivationChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.OnToggleGroupActivationChanged__DelegateSignature");
			}
			return FOnToggleGroupActivationChanged._FunctionPtr;
		}

		// Token: 0x0601FC29 RID: 130089 RVA: 0x002F3A70 File Offset: 0x002F1C70
		public FOnToggleGroupActivationChanged()
		{
		}

		// Token: 0x0601FC2A RID: 130090 RVA: 0x002F3A78 File Offset: 0x002F1C78
		[NullableContext(2)]
		public FOnToggleGroupActivationChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FC2B RID: 130091 RVA: 0x002F3A82 File Offset: 0x002F1C82
		public FOnToggleGroupActivationChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FC2C RID: 130092 RVA: 0x002F3A8D File Offset: 0x002F1C8D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UUIExtendToggle>) ?? ((Action<UUIExtendToggle>)Delegate.CreateDelegate(typeof(Action<UUIExtendToggle>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601FC2D RID: 130093 RVA: 0x002F3ABF File Offset: 0x002F1CBF
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UUIExtendToggle> Callback)
		{
			if (FOnToggleGroupActivationChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnToggleGroupActivationChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnToggleGroupActivationChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnToggleGroupActivationChanged.OnScriptCallback));
				}
				FOnToggleGroupActivationChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnToggleGroupActivationChanged.RegisterId);
		}

		// Token: 0x0601FC2E RID: 130094 RVA: 0x002F3AF9 File Offset: 0x002F1CF9
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UUIExtendToggle> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601FC2F RID: 130095 RVA: 0x002F3B04 File Offset: 0x002F1D04
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UUIExtendToggle Toggle)
		{
			FOnToggleGroupActivationChanged.__FOnToggleGroupActivationChanged_DelegateParams* ptr = stackalloc FOnToggleGroupActivationChanged.__FOnToggleGroupActivationChanged_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnToggleGroupActivationChanged.__FOnToggleGroupActivationChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnToggleGroupActivationChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Toggle = ((Toggle != null) ? Toggle.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601FC30 RID: 130096 RVA: 0x002F3B50 File Offset: 0x002F1D50
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UUIExtendToggle> action = target as Action<UUIExtendToggle>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UUIExtendToggle orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIExtendToggle>(((FOnToggleGroupActivationChanged.__FOnToggleGroupActivationChanged_DelegateParams*)__Parameters)->Toggle);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x040111EC RID: 70124
		internal static IntPtr _FunctionPtr;

		// Token: 0x040111ED RID: 70125
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.OnToggleGroupActivationChanged__DelegateSignature";

		// Token: 0x040111EE RID: 70126
		private static int RegisterId;

		// Token: 0x020034DB RID: 13531
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnToggleGroupActivationChanged_DelegateParams
		{
			// Token: 0x040174EF RID: 95471
			[FieldOffset(0)]
			public IntPtr Toggle;
		}

		// Token: 0x020034DC RID: 13532
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040174F0 RID: 95472
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
