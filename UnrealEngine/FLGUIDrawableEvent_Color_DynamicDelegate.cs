using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002046 RID: 8262
	public sealed class FLGUIDrawableEvent_Color_DynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F3B7 RID: 127927 RVA: 0x002E6058 File Offset: 0x002E4258
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDrawableEvent_Color_DynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F3B8 RID: 127928 RVA: 0x002E6064 File Offset: 0x002E4264
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDrawableEvent_Color_DynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDrawableEvent_Color_DynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDrawableEvent_Color_DynamicDelegate__DelegateSignature");
			}
			return FLGUIDrawableEvent_Color_DynamicDelegate._FunctionPtr;
		}

		// Token: 0x0601F3B9 RID: 127929 RVA: 0x002E6087 File Offset: 0x002E4287
		public FLGUIDrawableEvent_Color_DynamicDelegate()
		{
		}

		// Token: 0x0601F3BA RID: 127930 RVA: 0x002E608F File Offset: 0x002E428F
		[NullableContext(2)]
		public FLGUIDrawableEvent_Color_DynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F3BB RID: 127931 RVA: 0x002E6099 File Offset: 0x002E4299
		public FLGUIDrawableEvent_Color_DynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F3BC RID: 127932 RVA: 0x002E60A4 File Offset: 0x002E42A4
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FColor>) ?? ((Action<FColor>)Delegate.CreateDelegate(typeof(Action<FColor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F3BD RID: 127933 RVA: 0x002E60D6 File Offset: 0x002E42D6
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601F3BE RID: 127934 RVA: 0x002E6110 File Offset: 0x002E4310
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(FColor value)
		{
			FLGUIDrawableEvent_Color_DynamicDelegate.__FLGUIDrawableEvent_Color_DynamicDelegate_DelegateParams* ptr = stackalloc FLGUIDrawableEvent_Color_DynamicDelegate.__FLGUIDrawableEvent_Color_DynamicDelegate_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FLGUIDrawableEvent_Color_DynamicDelegate.__FLGUIDrawableEvent_Color_DynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDrawableEvent_Color_DynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F3BF RID: 127935 RVA: 0x002E6150 File Offset: 0x002E4350
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FColor> action = target as Action<FColor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUIDrawableEvent_Color_DynamicDelegate.__FLGUIDrawableEvent_Color_DynamicDelegate_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x04010E76 RID: 69238
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010E77 RID: 69239
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Color_DynamicDelegate__DelegateSignature";

		// Token: 0x04010E78 RID: 69240
		private static int RegisterId;

		// Token: 0x0200344F RID: 13391
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __FLGUIDrawableEvent_Color_DynamicDelegate_DelegateParams
		{
			// Token: 0x04017432 RID: 95282
			[FieldOffset(0)]
			public FColor value;
		}

		// Token: 0x02003450 RID: 13392
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017433 RID: 95283
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
