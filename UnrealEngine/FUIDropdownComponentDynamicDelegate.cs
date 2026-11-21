using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006F2 RID: 1778
	public sealed class FUIDropdownComponentDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06009731 RID: 38705 RVA: 0x000E414A File Offset: 0x000E234A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FUIDropdownComponentDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x06009732 RID: 38706 RVA: 0x000E4156 File Offset: 0x000E2356
		private static IntPtr StaticFunctionPtr()
		{
			if (FUIDropdownComponentDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FUIDropdownComponentDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.UIDropdownComponentDynamicDelegate__DelegateSignature");
			}
			return FUIDropdownComponentDynamicDelegate._FunctionPtr;
		}

		// Token: 0x06009733 RID: 38707 RVA: 0x000E4179 File Offset: 0x000E2379
		public FUIDropdownComponentDynamicDelegate()
		{
		}

		// Token: 0x06009734 RID: 38708 RVA: 0x000E4181 File Offset: 0x000E2381
		[NullableContext(2)]
		public FUIDropdownComponentDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009735 RID: 38709 RVA: 0x000E418B File Offset: 0x000E238B
		public FUIDropdownComponentDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009736 RID: 38710 RVA: 0x000E4196 File Offset: 0x000E2396
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06009737 RID: 38711 RVA: 0x000E41C8 File Offset: 0x000E23C8
		[NullableContext(1)]
		public void Bind(Action<int> Callback)
		{
			if (FUIDropdownComponentDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FUIDropdownComponentDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FUIDropdownComponentDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FUIDropdownComponentDynamicDelegate.OnScriptCallback));
				}
				FUIDropdownComponentDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FUIDropdownComponentDynamicDelegate.RegisterId);
		}

		// Token: 0x06009738 RID: 38712 RVA: 0x000E4204 File Offset: 0x000E2404
		[SkipLocalsInit]
		public unsafe void Execute(int InSelectIndex)
		{
			FUIDropdownComponentDynamicDelegate.__FUIDropdownComponentDynamicDelegate_DelegateParams* ptr = stackalloc FUIDropdownComponentDynamicDelegate.__FUIDropdownComponentDynamicDelegate_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FUIDropdownComponentDynamicDelegate.__FUIDropdownComponentDynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FUIDropdownComponentDynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->InSelectIndex = InSelectIndex;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06009739 RID: 38713 RVA: 0x000E4244 File Offset: 0x000E2444
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FUIDropdownComponentDynamicDelegate.__FUIDropdownComponentDynamicDelegate_DelegateParams*)__Parameters)->InSelectIndex);
		}

		// Token: 0x040041CA RID: 16842
		internal static IntPtr _FunctionPtr;

		// Token: 0x040041CB RID: 16843
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.UIDropdownComponentDynamicDelegate__DelegateSignature";

		// Token: 0x040041CC RID: 16844
		private static int RegisterId;

		// Token: 0x02000F16 RID: 3862
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FUIDropdownComponentDynamicDelegate_DelegateParams
		{
			// Token: 0x040062E5 RID: 25317
			[FieldOffset(0)]
			public int InSelectIndex;
		}

		// Token: 0x02000F17 RID: 3863
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040062E6 RID: 25318
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
