using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002134 RID: 8500
	public sealed class FUIComboBoxSelectDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06020011 RID: 131089 RVA: 0x002F9799 File Offset: 0x002F7999
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FUIComboBoxSelectDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x06020012 RID: 131090 RVA: 0x002F97A5 File Offset: 0x002F79A5
		private static IntPtr StaticFunctionPtr()
		{
			if (FUIComboBoxSelectDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FUIComboBoxSelectDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.UIComboBoxSelectDynamicDelegate__DelegateSignature");
			}
			return FUIComboBoxSelectDynamicDelegate._FunctionPtr;
		}

		// Token: 0x06020013 RID: 131091 RVA: 0x002F97C8 File Offset: 0x002F79C8
		public FUIComboBoxSelectDynamicDelegate()
		{
		}

		// Token: 0x06020014 RID: 131092 RVA: 0x002F97D0 File Offset: 0x002F79D0
		[NullableContext(2)]
		public FUIComboBoxSelectDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06020015 RID: 131093 RVA: 0x002F97DA File Offset: 0x002F79DA
		public FUIComboBoxSelectDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06020016 RID: 131094 RVA: 0x002F97E5 File Offset: 0x002F79E5
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, string>) ?? ((Action<int, string>)Delegate.CreateDelegate(typeof(Action<int, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06020017 RID: 131095 RVA: 0x002F9817 File Offset: 0x002F7A17
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<int, string> Callback)
		{
			if (FUIComboBoxSelectDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FUIComboBoxSelectDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FUIComboBoxSelectDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FUIComboBoxSelectDynamicDelegate.OnScriptCallback));
				}
				FUIComboBoxSelectDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FUIComboBoxSelectDynamicDelegate.RegisterId);
		}

		// Token: 0x06020018 RID: 131096 RVA: 0x002F9854 File Offset: 0x002F7A54
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int InSelectIndex, string InSelectItem)
		{
			FUIComboBoxSelectDynamicDelegate.__FUIComboBoxSelectDynamicDelegate_DelegateParams* ptr = stackalloc FUIComboBoxSelectDynamicDelegate.__FUIComboBoxSelectDynamicDelegate_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FUIComboBoxSelectDynamicDelegate.__FUIComboBoxSelectDynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FUIComboBoxSelectDynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->InSelectIndex = InSelectIndex;
			FString.CopyFrom((void*)(&ptr->InSelectItem), InSelectItem);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FUIComboBoxSelectDynamicDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06020019 RID: 131097 RVA: 0x002F98B0 File Offset: 0x002F7AB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, string> action = target as Action<int, string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FUIComboBoxSelectDynamicDelegate.__FUIComboBoxSelectDynamicDelegate_DelegateParams*)__Parameters)->InSelectItem));
			action(((FUIComboBoxSelectDynamicDelegate.__FUIComboBoxSelectDynamicDelegate_DelegateParams*)__Parameters)->InSelectIndex, arg);
		}

		// Token: 0x040113B3 RID: 70579
		internal static IntPtr _FunctionPtr;

		// Token: 0x040113B4 RID: 70580
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.UIComboBoxSelectDynamicDelegate__DelegateSignature";

		// Token: 0x040113B5 RID: 70581
		private static int RegisterId;

		// Token: 0x020034F1 RID: 13553
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FUIComboBoxSelectDynamicDelegate_DelegateParams
		{
			// Token: 0x04017514 RID: 95508
			[FieldOffset(0)]
			public int InSelectIndex;

			// Token: 0x04017515 RID: 95509
			[FieldOffset(8)]
			public FString InSelectItem;
		}

		// Token: 0x020034F2 RID: 13554
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017516 RID: 95510
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
