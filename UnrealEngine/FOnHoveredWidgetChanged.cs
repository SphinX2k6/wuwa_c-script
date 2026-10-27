using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029A3 RID: 10659
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnHoveredWidgetChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060276E9 RID: 161513 RVA: 0x003C23C5 File Offset: 0x003C05C5
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnHoveredWidgetChanged.StaticFunctionPtr();
		}

		// Token: 0x060276EA RID: 161514 RVA: 0x003C23D1 File Offset: 0x003C05D1
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnHoveredWidgetChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnHoveredWidgetChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.OnHoveredWidgetChanged__DelegateSignature");
			}
			return FOnHoveredWidgetChanged._FunctionPtr;
		}

		// Token: 0x060276EB RID: 161515 RVA: 0x003C23F4 File Offset: 0x003C05F4
		public FOnHoveredWidgetChanged()
		{
		}

		// Token: 0x060276EC RID: 161516 RVA: 0x003C23FC File Offset: 0x003C05FC
		[NullableContext(2)]
		public FOnHoveredWidgetChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060276ED RID: 161517 RVA: 0x003C2406 File Offset: 0x003C0606
		public FOnHoveredWidgetChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060276EE RID: 161518 RVA: 0x003C2411 File Offset: 0x003C0611
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UWidgetComponent, UWidgetComponent>) ?? ((Action<UWidgetComponent, UWidgetComponent>)Delegate.CreateDelegate(typeof(Action<UWidgetComponent, UWidgetComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060276EF RID: 161519 RVA: 0x003C2443 File Offset: 0x003C0643
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Action<UWidgetComponent, UWidgetComponent> Callback)
		{
			if (FOnHoveredWidgetChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnHoveredWidgetChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnHoveredWidgetChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnHoveredWidgetChanged.OnScriptCallback));
				}
				FOnHoveredWidgetChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnHoveredWidgetChanged.RegisterId);
		}

		// Token: 0x060276F0 RID: 161520 RVA: 0x003C247D File Offset: 0x003C067D
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Action<UWidgetComponent, UWidgetComponent> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060276F1 RID: 161521 RVA: 0x003C2488 File Offset: 0x003C0688
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UWidgetComponent WidgetComponent, UWidgetComponent PreviousWidgetComponent)
		{
			FOnHoveredWidgetChanged.__FOnHoveredWidgetChanged_DelegateParams* ptr = stackalloc FOnHoveredWidgetChanged.__FOnHoveredWidgetChanged_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnHoveredWidgetChanged.__FOnHoveredWidgetChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnHoveredWidgetChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->WidgetComponent = ((WidgetComponent != null) ? WidgetComponent.NativePtr : IntPtr.Zero);
			ptr->PreviousWidgetComponent = ((PreviousWidgetComponent != null) ? PreviousWidgetComponent.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060276F2 RID: 161522 RVA: 0x003C24EC File Offset: 0x003C06EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UWidgetComponent, UWidgetComponent> action = target as Action<UWidgetComponent, UWidgetComponent>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UWidgetComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UWidgetComponent>(((FOnHoveredWidgetChanged.__FOnHoveredWidgetChanged_DelegateParams*)__Parameters)->WidgetComponent);
			UWidgetComponent orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UWidgetComponent>(((FOnHoveredWidgetChanged.__FOnHoveredWidgetChanged_DelegateParams*)__Parameters)->PreviousWidgetComponent);
			action(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
		}

		// Token: 0x04015A49 RID: 88649
		internal static IntPtr _FunctionPtr;

		// Token: 0x04015A4A RID: 88650
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.OnHoveredWidgetChanged__DelegateSignature";

		// Token: 0x04015A4B RID: 88651
		private static int RegisterId;

		// Token: 0x02003B9F RID: 15263
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnHoveredWidgetChanged_DelegateParams
		{
			// Token: 0x04017D7C RID: 97660
			[FieldOffset(0)]
			public IntPtr WidgetComponent;

			// Token: 0x04017D7D RID: 97661
			[FieldOffset(8)]
			public IntPtr PreviousWidgetComponent;
		}

		// Token: 0x02003BA0 RID: 15264
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D7E RID: 97662
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
