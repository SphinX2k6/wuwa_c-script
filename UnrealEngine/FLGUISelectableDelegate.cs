using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006BA RID: 1722
	public sealed class FLGUISelectableDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060093B0 RID: 37808 RVA: 0x000DE74E File Offset: 0x000DC94E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUISelectableDelegate.StaticFunctionPtr();
		}

		// Token: 0x060093B1 RID: 37809 RVA: 0x000DE75A File Offset: 0x000DC95A
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUISelectableDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUISelectableDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUISelectableDelegate__DelegateSignature");
			}
			return FLGUISelectableDelegate._FunctionPtr;
		}

		// Token: 0x060093B2 RID: 37810 RVA: 0x000DE77D File Offset: 0x000DC97D
		public FLGUISelectableDelegate()
		{
		}

		// Token: 0x060093B3 RID: 37811 RVA: 0x000DE785 File Offset: 0x000DC985
		[NullableContext(2)]
		public FLGUISelectableDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060093B4 RID: 37812 RVA: 0x000DE78F File Offset: 0x000DC98F
		public FLGUISelectableDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060093B5 RID: 37813 RVA: 0x000DE79A File Offset: 0x000DC99A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<UUISelectableComponent, bool>) ?? ((Action<UUISelectableComponent, bool>)Delegate.CreateDelegate(typeof(Action<UUISelectableComponent, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060093B6 RID: 37814 RVA: 0x000DE7CC File Offset: 0x000DC9CC
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<UUISelectableComponent, bool> Callback)
		{
			if (FLGUISelectableDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUISelectableDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUISelectableDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUISelectableDelegate.OnScriptCallback));
				}
				FLGUISelectableDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUISelectableDelegate.RegisterId);
		}

		// Token: 0x060093B7 RID: 37815 RVA: 0x000DE808 File Offset: 0x000DCA08
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute(UUISelectableComponent SelectableComponent, bool bCreate)
		{
			FLGUISelectableDelegate.__FLGUISelectableDelegate_DelegateParams* ptr = stackalloc FLGUISelectableDelegate.__FLGUISelectableDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLGUISelectableDelegate.__FLGUISelectableDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUISelectableDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->SelectableComponent = ((SelectableComponent != null) ? SelectableComponent.NativePtr : IntPtr.Zero);
			ptr->bCreate = bCreate;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060093B8 RID: 37816 RVA: 0x000DE85C File Offset: 0x000DCA5C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UUISelectableComponent, bool> action = target as Action<UUISelectableComponent, bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UUISelectableComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UUISelectableComponent>(((FLGUISelectableDelegate.__FLGUISelectableDelegate_DelegateParams*)__Parameters)->SelectableComponent);
			action(orCreateUObjectByNativePointer, ((FLGUISelectableDelegate.__FLGUISelectableDelegate_DelegateParams*)__Parameters)->bCreate);
		}

		// Token: 0x04004063 RID: 16483
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004064 RID: 16484
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUISelectableDelegate__DelegateSignature";

		// Token: 0x04004065 RID: 16485
		private static int RegisterId;

		// Token: 0x02000EE4 RID: 3812
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FLGUISelectableDelegate_DelegateParams
		{
			// Token: 0x040062A5 RID: 25253
			[FieldOffset(0)]
			public IntPtr SelectableComponent;

			// Token: 0x040062A6 RID: 25254
			[FieldOffset(8)]
			public bool bCreate;
		}

		// Token: 0x02000EE5 RID: 3813
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040062A7 RID: 25255
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
