using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002021 RID: 8225
	public sealed class FLGUIBaseEventDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601EFC9 RID: 126921 RVA: 0x002E140A File Offset: 0x002DF60A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIBaseEventDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601EFCA RID: 126922 RVA: 0x002E1416 File Offset: 0x002DF616
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIBaseEventDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIBaseEventDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIBaseEventDynamicDelegate__DelegateSignature");
			}
			return FLGUIBaseEventDynamicDelegate._FunctionPtr;
		}

		// Token: 0x0601EFCB RID: 126923 RVA: 0x002E1439 File Offset: 0x002DF639
		public FLGUIBaseEventDynamicDelegate()
		{
		}

		// Token: 0x0601EFCC RID: 126924 RVA: 0x002E1441 File Offset: 0x002DF641
		[NullableContext(2)]
		public FLGUIBaseEventDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EFCD RID: 126925 RVA: 0x002E144B File Offset: 0x002DF64B
		public FLGUIBaseEventDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EFCE RID: 126926 RVA: 0x002E1456 File Offset: 0x002DF656
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<ULGUIBaseEventData>) ?? ((Action<ULGUIBaseEventData>)Delegate.CreateDelegate(typeof(Action<ULGUIBaseEventData>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601EFCF RID: 126927 RVA: 0x002E1488 File Offset: 0x002DF688
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<ULGUIBaseEventData> Callback)
		{
			if (FLGUIBaseEventDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIBaseEventDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIBaseEventDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIBaseEventDynamicDelegate.OnScriptCallback));
				}
				FLGUIBaseEventDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIBaseEventDynamicDelegate.RegisterId);
		}

		// Token: 0x0601EFD0 RID: 126928 RVA: 0x002E14C4 File Offset: 0x002DF6C4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(ULGUIBaseEventData eventData)
		{
			FLGUIBaseEventDynamicDelegate.__FLGUIBaseEventDynamicDelegate_DelegateParams* ptr = stackalloc FLGUIBaseEventDynamicDelegate.__FLGUIBaseEventDynamicDelegate_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FLGUIBaseEventDynamicDelegate.__FLGUIBaseEventDynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIBaseEventDynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->eventData = ((eventData != null) ? eventData.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601EFD1 RID: 126929 RVA: 0x002E1510 File Offset: 0x002DF710
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<ULGUIBaseEventData> action = target as Action<ULGUIBaseEventData>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			ULGUIBaseEventData orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIBaseEventData>(((FLGUIBaseEventDynamicDelegate.__FLGUIBaseEventDynamicDelegate_DelegateParams*)__Parameters)->eventData);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04010D83 RID: 68995
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010D84 RID: 68996
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIBaseEventDynamicDelegate__DelegateSignature";

		// Token: 0x04010D85 RID: 68997
		private static int RegisterId;

		// Token: 0x02003429 RID: 13353
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FLGUIBaseEventDynamicDelegate_DelegateParams
		{
			// Token: 0x04017405 RID: 95237
			[FieldOffset(0)]
			public IntPtr eventData;
		}

		// Token: 0x0200342A RID: 13354
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017406 RID: 95238
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
