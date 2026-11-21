using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200067F RID: 1663
	public sealed class FLGUIDrawableEvent_Color_DynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06009065 RID: 36965 RVA: 0x000D8C7E File Offset: 0x000D6E7E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDrawableEvent_Color_DynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x06009066 RID: 36966 RVA: 0x000D8C8A File Offset: 0x000D6E8A
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDrawableEvent_Color_DynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDrawableEvent_Color_DynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDrawableEvent_Color_DynamicDelegate__DelegateSignature");
			}
			return FLGUIDrawableEvent_Color_DynamicDelegate._FunctionPtr;
		}

		// Token: 0x06009067 RID: 36967 RVA: 0x000D8CAD File Offset: 0x000D6EAD
		public FLGUIDrawableEvent_Color_DynamicDelegate()
		{
		}

		// Token: 0x06009068 RID: 36968 RVA: 0x000D8CB5 File Offset: 0x000D6EB5
		[NullableContext(2)]
		public FLGUIDrawableEvent_Color_DynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009069 RID: 36969 RVA: 0x000D8CBF File Offset: 0x000D6EBF
		public FLGUIDrawableEvent_Color_DynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600906A RID: 36970 RVA: 0x000D8CCA File Offset: 0x000D6ECA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FColor>) ?? ((Action<FColor>)Delegate.CreateDelegate(typeof(Action<FColor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600906B RID: 36971 RVA: 0x000D8CFC File Offset: 0x000D6EFC
		[NullableContext(1)]
		public void Bind(Action<FColor> Callback)
		{
			if (FLGUIDrawableEvent_Color_DynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIDrawableEvent_Color_DynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIDrawableEvent_Color_DynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIDrawableEvent_Color_DynamicDelegate.OnScriptCallback));
				}
				FLGUIDrawableEvent_Color_DynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIDrawableEvent_Color_DynamicDelegate.RegisterId);
		}

		// Token: 0x0600906C RID: 36972 RVA: 0x000D8D38 File Offset: 0x000D6F38
		[SkipLocalsInit]
		public unsafe void Execute(FColor value)
		{
			FLGUIDrawableEvent_Color_DynamicDelegate.__FLGUIDrawableEvent_Color_DynamicDelegate_DelegateParams* ptr = stackalloc FLGUIDrawableEvent_Color_DynamicDelegate.__FLGUIDrawableEvent_Color_DynamicDelegate_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FLGUIDrawableEvent_Color_DynamicDelegate.__FLGUIDrawableEvent_Color_DynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDrawableEvent_Color_DynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600906D RID: 36973 RVA: 0x000D8D78 File Offset: 0x000D6F78
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FColor> action = target as Action<FColor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUIDrawableEvent_Color_DynamicDelegate.__FLGUIDrawableEvent_Color_DynamicDelegate_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x04003F16 RID: 16150
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003F17 RID: 16151
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Color_DynamicDelegate__DelegateSignature";

		// Token: 0x04003F18 RID: 16152
		private static int RegisterId;

		// Token: 0x02000E92 RID: 3730
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FLGUIDrawableEvent_Color_DynamicDelegate_DelegateParams
		{
			// Token: 0x04006241 RID: 25153
			[FieldOffset(0)]
			public FColor value;
		}

		// Token: 0x02000E93 RID: 3731
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006242 RID: 25154
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
