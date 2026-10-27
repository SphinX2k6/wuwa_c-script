using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200205D RID: 8285
	public sealed class FLGUIDrawableEvent_String_DynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F479 RID: 128121 RVA: 0x002E72DC File Offset: 0x002E54DC
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDrawableEvent_String_DynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F47A RID: 128122 RVA: 0x002E72E8 File Offset: 0x002E54E8
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDrawableEvent_String_DynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDrawableEvent_String_DynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDrawableEvent_String_DynamicDelegate__DelegateSignature");
			}
			return FLGUIDrawableEvent_String_DynamicDelegate._FunctionPtr;
		}

		// Token: 0x0601F47B RID: 128123 RVA: 0x002E730B File Offset: 0x002E550B
		public FLGUIDrawableEvent_String_DynamicDelegate()
		{
		}

		// Token: 0x0601F47C RID: 128124 RVA: 0x002E7313 File Offset: 0x002E5513
		[NullableContext(2)]
		public FLGUIDrawableEvent_String_DynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F47D RID: 128125 RVA: 0x002E731D File Offset: 0x002E551D
		public FLGUIDrawableEvent_String_DynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F47E RID: 128126 RVA: 0x002E7328 File Offset: 0x002E5528
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F47F RID: 128127 RVA: 0x002E735A File Offset: 0x002E555A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<string> Callback)
		{
			if (FLGUIDrawableEvent_String_DynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIDrawableEvent_String_DynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIDrawableEvent_String_DynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIDrawableEvent_String_DynamicDelegate.OnScriptCallback));
				}
				FLGUIDrawableEvent_String_DynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIDrawableEvent_String_DynamicDelegate.RegisterId);
		}

		// Token: 0x0601F480 RID: 128128 RVA: 0x002E7394 File Offset: 0x002E5594
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(string value)
		{
			FLGUIDrawableEvent_String_DynamicDelegate.__FLGUIDrawableEvent_String_DynamicDelegate_DelegateParams* ptr = stackalloc FLGUIDrawableEvent_String_DynamicDelegate.__FLGUIDrawableEvent_String_DynamicDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLGUIDrawableEvent_String_DynamicDelegate.__FLGUIDrawableEvent_String_DynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDrawableEvent_String_DynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->value), value);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FLGUIDrawableEvent_String_DynamicDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F481 RID: 128129 RVA: 0x002E73E8 File Offset: 0x002E55E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string> action = target as Action<string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string obj = FString.ToString((void*)(&((FLGUIDrawableEvent_String_DynamicDelegate.__FLGUIDrawableEvent_String_DynamicDelegate_DelegateParams*)__Parameters)->value));
			action(obj);
		}

		// Token: 0x04010EAE RID: 69294
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010EAF RID: 69295
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_String_DynamicDelegate__DelegateSignature";

		// Token: 0x04010EB0 RID: 69296
		private static int RegisterId;

		// Token: 0x02003462 RID: 13410
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FLGUIDrawableEvent_String_DynamicDelegate_DelegateParams
		{
			// Token: 0x04017445 RID: 95301
			[FieldOffset(0)]
			public FString value;
		}

		// Token: 0x02003463 RID: 13411
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017446 RID: 95302
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
