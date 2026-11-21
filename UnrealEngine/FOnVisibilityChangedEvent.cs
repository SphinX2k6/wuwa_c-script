using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200086C RID: 2156
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnVisibilityChangedEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600BB2E RID: 47918 RVA: 0x0012BCC2 File Offset: 0x00129EC2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnVisibilityChangedEvent.StaticFunctionPtr();
		}

		// Token: 0x0600BB2F RID: 47919 RVA: 0x0012BCCE File Offset: 0x00129ECE
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnVisibilityChangedEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnVisibilityChangedEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.OnVisibilityChangedEvent__DelegateSignature");
			}
			return FOnVisibilityChangedEvent._FunctionPtr;
		}

		// Token: 0x0600BB30 RID: 47920 RVA: 0x0012BCF1 File Offset: 0x00129EF1
		public FOnVisibilityChangedEvent()
		{
		}

		// Token: 0x0600BB31 RID: 47921 RVA: 0x0012BCF9 File Offset: 0x00129EF9
		[NullableContext(2)]
		public FOnVisibilityChangedEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600BB32 RID: 47922 RVA: 0x0012BD03 File Offset: 0x00129F03
		public FOnVisibilityChangedEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600BB33 RID: 47923 RVA: 0x0012BD0E File Offset: 0x00129F0E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<ESlateVisibility>) ?? ((Action<ESlateVisibility>)Delegate.CreateDelegate(typeof(Action<ESlateVisibility>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600BB34 RID: 47924 RVA: 0x0012BD40 File Offset: 0x00129F40
		[NullableContext(1)]
		public void Add(Action<ESlateVisibility> Callback)
		{
			if (FOnVisibilityChangedEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnVisibilityChangedEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnVisibilityChangedEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnVisibilityChangedEvent.OnScriptCallback));
				}
				FOnVisibilityChangedEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnVisibilityChangedEvent.RegisterId);
		}

		// Token: 0x0600BB35 RID: 47925 RVA: 0x0012BD7A File Offset: 0x00129F7A
		[NullableContext(1)]
		public void Remove(Action<ESlateVisibility> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600BB36 RID: 47926 RVA: 0x0012BD84 File Offset: 0x00129F84
		[SkipLocalsInit]
		public unsafe void Broadcast(ESlateVisibility InVisibility)
		{
			FOnVisibilityChangedEvent.__FOnVisibilityChangedEvent_DelegateParams* ptr = stackalloc FOnVisibilityChangedEvent.__FOnVisibilityChangedEvent_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FOnVisibilityChangedEvent.__FOnVisibilityChangedEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnVisibilityChangedEvent.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->InVisibility = InVisibility;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600BB37 RID: 47927 RVA: 0x0012BDC0 File Offset: 0x00129FC0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<ESlateVisibility> action = target as Action<ESlateVisibility>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnVisibilityChangedEvent.__FOnVisibilityChangedEvent_DelegateParams*)__Parameters)->InVisibility);
		}

		// Token: 0x040054CD RID: 21709
		internal static IntPtr _FunctionPtr;

		// Token: 0x040054CE RID: 21710
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.OnVisibilityChangedEvent__DelegateSignature";

		// Token: 0x040054CF RID: 21711
		private static int RegisterId;

		// Token: 0x0200140C RID: 5132
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		private ref struct __FOnVisibilityChangedEvent_DelegateParams
		{
			// Token: 0x040068BA RID: 26810
			[FieldOffset(0)]
			public ESlateVisibility InVisibility;
		}

		// Token: 0x0200140D RID: 5133
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040068BB RID: 26811
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
