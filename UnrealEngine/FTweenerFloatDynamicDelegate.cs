using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200074E RID: 1870
	public sealed class FTweenerFloatDynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600A2F9 RID: 41721 RVA: 0x000F0E3A File Offset: 0x000EF03A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FTweenerFloatDynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600A2FA RID: 41722 RVA: 0x000F0E46 File Offset: 0x000EF046
		private static IntPtr StaticFunctionPtr()
		{
			if (FTweenerFloatDynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FTweenerFloatDynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LTween.TweenerFloatDynamicDelegate__DelegateSignature");
			}
			return FTweenerFloatDynamicDelegate._FunctionPtr;
		}

		// Token: 0x0600A2FB RID: 41723 RVA: 0x000F0E69 File Offset: 0x000EF069
		public FTweenerFloatDynamicDelegate()
		{
		}

		// Token: 0x0600A2FC RID: 41724 RVA: 0x000F0E71 File Offset: 0x000EF071
		[NullableContext(2)]
		public FTweenerFloatDynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A2FD RID: 41725 RVA: 0x000F0E7B File Offset: 0x000EF07B
		public FTweenerFloatDynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A2FE RID: 41726 RVA: 0x000F0E86 File Offset: 0x000EF086
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<float>) ?? ((Action<float>)Delegate.CreateDelegate(typeof(Action<float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600A2FF RID: 41727 RVA: 0x000F0EB8 File Offset: 0x000EF0B8
		[NullableContext(1)]
		public void Bind(Action<float> Callback)
		{
			if (FTweenerFloatDynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FTweenerFloatDynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FTweenerFloatDynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FTweenerFloatDynamicDelegate.OnScriptCallback));
				}
				FTweenerFloatDynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FTweenerFloatDynamicDelegate.RegisterId);
		}

		// Token: 0x0600A300 RID: 41728 RVA: 0x000F0EF4 File Offset: 0x000EF0F4
		[SkipLocalsInit]
		public unsafe void Execute(float InProgress)
		{
			FTweenerFloatDynamicDelegate.__FTweenerFloatDynamicDelegate_DelegateParams* ptr = stackalloc FTweenerFloatDynamicDelegate.__FTweenerFloatDynamicDelegate_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(FTweenerFloatDynamicDelegate.__FTweenerFloatDynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FTweenerFloatDynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->InProgress = InProgress;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600A301 RID: 41729 RVA: 0x000F0F34 File Offset: 0x000EF134
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<float> action = target as Action<float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FTweenerFloatDynamicDelegate.__FTweenerFloatDynamicDelegate_DelegateParams*)__Parameters)->InProgress);
		}

		// Token: 0x040045AF RID: 17839
		internal static IntPtr _FunctionPtr;

		// Token: 0x040045B0 RID: 17840
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LTween.TweenerFloatDynamicDelegate__DelegateSignature";

		// Token: 0x040045B1 RID: 17841
		private static int RegisterId;

		// Token: 0x02000F3C RID: 3900
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __FTweenerFloatDynamicDelegate_DelegateParams
		{
			// Token: 0x04006310 RID: 25360
			[FieldOffset(0)]
			public float InProgress;
		}

		// Token: 0x02000F3D RID: 3901
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006311 RID: 25361
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
