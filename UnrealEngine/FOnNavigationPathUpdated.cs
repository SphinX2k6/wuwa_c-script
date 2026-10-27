using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020024AB RID: 9387
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnNavigationPathUpdated : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060231EE RID: 143854 RVA: 0x0033F065 File Offset: 0x0033D265
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnNavigationPathUpdated.StaticFunctionPtr();
		}

		// Token: 0x060231EF RID: 143855 RVA: 0x0033F071 File Offset: 0x0033D271
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnNavigationPathUpdated._FunctionPtr == IntPtr.Zero)
			{
				FOnNavigationPathUpdated._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/NavigationSystem.OnNavigationPathUpdated__DelegateSignature");
			}
			return FOnNavigationPathUpdated._FunctionPtr;
		}

		// Token: 0x060231F0 RID: 143856 RVA: 0x0033F094 File Offset: 0x0033D294
		public FOnNavigationPathUpdated()
		{
		}

		// Token: 0x060231F1 RID: 143857 RVA: 0x0033F09C File Offset: 0x0033D29C
		[NullableContext(2)]
		public FOnNavigationPathUpdated(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060231F2 RID: 143858 RVA: 0x0033F0A6 File Offset: 0x0033D2A6
		public FOnNavigationPathUpdated(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060231F3 RID: 143859 RVA: 0x0033F0B1 File Offset: 0x0033D2B1
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UNavigationPath, TEnumAsByte<ENavPathEvent>>) ?? ((Action<UNavigationPath, TEnumAsByte<ENavPathEvent>>)Delegate.CreateDelegate(typeof(Action<UNavigationPath, TEnumAsByte<ENavPathEvent>>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060231F4 RID: 143860 RVA: 0x0033F0E3 File Offset: 0x0033D2E3
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			0
		})] Action<UNavigationPath, TEnumAsByte<ENavPathEvent>> Callback)
		{
			if (FOnNavigationPathUpdated.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnNavigationPathUpdated.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnNavigationPathUpdated.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnNavigationPathUpdated.OnScriptCallback));
				}
				FOnNavigationPathUpdated.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnNavigationPathUpdated.RegisterId);
		}

		// Token: 0x060231F5 RID: 143861 RVA: 0x0033F11D File Offset: 0x0033D31D
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			0
		})] Action<UNavigationPath, TEnumAsByte<ENavPathEvent>> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060231F6 RID: 143862 RVA: 0x0033F128 File Offset: 0x0033D328
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UNavigationPath AffectedPath, ENavPathEvent PathEvent)
		{
			FOnNavigationPathUpdated.__FOnNavigationPathUpdated_DelegateParams* ptr = stackalloc FOnNavigationPathUpdated.__FOnNavigationPathUpdated_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnNavigationPathUpdated.__FOnNavigationPathUpdated_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnNavigationPathUpdated.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->AffectedPath = ((AffectedPath != null) ? AffectedPath.NativePtr : IntPtr.Zero);
			ptr->PathEvent = PathEvent;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060231F7 RID: 143863 RVA: 0x0033F180 File Offset: 0x0033D380
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UNavigationPath, TEnumAsByte<ENavPathEvent>> action = target as Action<UNavigationPath, TEnumAsByte<ENavPathEvent>>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UNavigationPath orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UNavigationPath>(((FOnNavigationPathUpdated.__FOnNavigationPathUpdated_DelegateParams*)__Parameters)->AffectedPath);
			action(orCreateUObjectByNativePointer, ((FOnNavigationPathUpdated.__FOnNavigationPathUpdated_DelegateParams*)__Parameters)->PathEvent);
		}

		// Token: 0x04012BFA RID: 76794
		internal static IntPtr _FunctionPtr;

		// Token: 0x04012BFB RID: 76795
		[Nullable(1)]
		public const string __ObjectPath = "/Script/NavigationSystem.OnNavigationPathUpdated__DelegateSignature";

		// Token: 0x04012BFC RID: 76796
		private static int RegisterId;

		// Token: 0x0200366A RID: 13930
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnNavigationPathUpdated_DelegateParams
		{
			// Token: 0x0401773B RID: 96059
			[FieldOffset(0)]
			public IntPtr AffectedPath;

			// Token: 0x0401773C RID: 96060
			[FieldOffset(8)]
			public TEnumAsByte<ENavPathEvent> PathEvent;
		}

		// Token: 0x0200366B RID: 13931
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401773D RID: 96061
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
