using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006D4 RID: 1748
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnToggleGroupActivationChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060094D2 RID: 38098 RVA: 0x000E0851 File Offset: 0x000DEA51
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnToggleGroupActivationChanged.StaticFunctionPtr();
		}

		// Token: 0x060094D3 RID: 38099 RVA: 0x000E085D File Offset: 0x000DEA5D
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnToggleGroupActivationChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnToggleGroupActivationChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.OnToggleGroupActivationChanged__DelegateSignature");
			}
			return FOnToggleGroupActivationChanged._FunctionPtr;
		}

		// Token: 0x060094D4 RID: 38100 RVA: 0x000E0880 File Offset: 0x000DEA80
		public FOnToggleGroupActivationChanged()
		{
		}

		// Token: 0x060094D5 RID: 38101 RVA: 0x000E0888 File Offset: 0x000DEA88
		[NullableContext(2)]
		public FOnToggleGroupActivationChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060094D6 RID: 38102 RVA: 0x000E0892 File Offset: 0x000DEA92
		public FOnToggleGroupActivationChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060094D7 RID: 38103 RVA: 0x000E089D File Offset: 0x000DEA9D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UUIExtendToggle>) ?? ((Action<UUIExtendToggle>)Delegate.CreateDelegate(typeof(Action<UUIExtendToggle>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060094D8 RID: 38104 RVA: 0x000E08CF File Offset: 0x000DEACF
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

		// Token: 0x060094D9 RID: 38105 RVA: 0x000E0909 File Offset: 0x000DEB09
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UUIExtendToggle> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060094DA RID: 38106 RVA: 0x000E0914 File Offset: 0x000DEB14
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(UUIExtendToggle Toggle)
		{
			FOnToggleGroupActivationChanged.__FOnToggleGroupActivationChanged_DelegateParams* ptr = stackalloc FOnToggleGroupActivationChanged.__FOnToggleGroupActivationChanged_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnToggleGroupActivationChanged.__FOnToggleGroupActivationChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnToggleGroupActivationChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Toggle = ((Toggle != null) ? Toggle.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060094DB RID: 38107 RVA: 0x000E0960 File Offset: 0x000DEB60
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x040040BA RID: 16570
		internal static IntPtr _FunctionPtr;

		// Token: 0x040040BB RID: 16571
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.OnToggleGroupActivationChanged__DelegateSignature";

		// Token: 0x040040BC RID: 16572
		private static int RegisterId;

		// Token: 0x02000F07 RID: 3847
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FOnToggleGroupActivationChanged_DelegateParams
		{
			// Token: 0x040062D4 RID: 25300
			[FieldOffset(0)]
			public IntPtr Toggle;
		}

		// Token: 0x02000F08 RID: 3848
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040062D5 RID: 25301
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
