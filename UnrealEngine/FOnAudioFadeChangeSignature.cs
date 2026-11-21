using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000250 RID: 592
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnAudioFadeChangeSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060032D7 RID: 13015 RVA: 0x000489F5 File Offset: 0x00046BF5
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnAudioFadeChangeSignature.StaticFunctionPtr();
		}

		// Token: 0x060032D8 RID: 13016 RVA: 0x00048A01 File Offset: 0x00046C01
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnAudioFadeChangeSignature._FunctionPtr == IntPtr.Zero)
			{
				FOnAudioFadeChangeSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnAudioFadeChangeSignature__DelegateSignature");
			}
			return FOnAudioFadeChangeSignature._FunctionPtr;
		}

		// Token: 0x060032D9 RID: 13017 RVA: 0x00048A24 File Offset: 0x00046C24
		public FOnAudioFadeChangeSignature()
		{
		}

		// Token: 0x060032DA RID: 13018 RVA: 0x00048A2C File Offset: 0x00046C2C
		[NullableContext(2)]
		public FOnAudioFadeChangeSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060032DB RID: 13019 RVA: 0x00048A36 File Offset: 0x00046C36
		public FOnAudioFadeChangeSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060032DC RID: 13020 RVA: 0x00048A41 File Offset: 0x00046C41
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool, float>) ?? ((Action<bool, float>)Delegate.CreateDelegate(typeof(Action<bool, float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060032DD RID: 13021 RVA: 0x00048A73 File Offset: 0x00046C73
		[NullableContext(1)]
		public void Add(Action<bool, float> Callback)
		{
			if (FOnAudioFadeChangeSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnAudioFadeChangeSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnAudioFadeChangeSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnAudioFadeChangeSignature.OnScriptCallback));
				}
				FOnAudioFadeChangeSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnAudioFadeChangeSignature.RegisterId);
		}

		// Token: 0x060032DE RID: 13022 RVA: 0x00048AAD File Offset: 0x00046CAD
		[NullableContext(1)]
		public void Remove(Action<bool, float> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060032DF RID: 13023 RVA: 0x00048AB8 File Offset: 0x00046CB8
		[SkipLocalsInit]
		public unsafe void Broadcast(bool bFadeOut, float FadeTime)
		{
			FOnAudioFadeChangeSignature.__FOnAudioFadeChangeSignature_DelegateParams* ptr = stackalloc FOnAudioFadeChangeSignature.__FOnAudioFadeChangeSignature_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnAudioFadeChangeSignature.__FOnAudioFadeChangeSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnAudioFadeChangeSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bFadeOut = bFadeOut;
			ptr->FadeTime = FadeTime;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060032E0 RID: 13024 RVA: 0x00048AFC File Offset: 0x00046CFC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool, float> action = target as Action<bool, float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnAudioFadeChangeSignature.__FOnAudioFadeChangeSignature_DelegateParams*)__Parameters)->bFadeOut, ((FOnAudioFadeChangeSignature.__FOnAudioFadeChangeSignature_DelegateParams*)__Parameters)->FadeTime);
		}

		// Token: 0x040011BC RID: 4540
		internal static IntPtr _FunctionPtr;

		// Token: 0x040011BD RID: 4541
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnAudioFadeChangeSignature__DelegateSignature";

		// Token: 0x040011BE RID: 4542
		private static int RegisterId;

		// Token: 0x020009CB RID: 2507
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FOnAudioFadeChangeSignature_DelegateParams
		{
			// Token: 0x04005957 RID: 22871
			[FieldOffset(0)]
			public bool bFadeOut;

			// Token: 0x04005958 RID: 22872
			[FieldOffset(4)]
			public float FadeTime;
		}

		// Token: 0x020009CC RID: 2508
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005959 RID: 22873
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
