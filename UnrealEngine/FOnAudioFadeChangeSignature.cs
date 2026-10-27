using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F04 RID: 3844
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnAudioFadeChangeSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D018 RID: 53272 RVA: 0x0012FA6B File Offset: 0x0012DC6B
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnAudioFadeChangeSignature.StaticFunctionPtr();
		}

		// Token: 0x0600D019 RID: 53273 RVA: 0x0012FA77 File Offset: 0x0012DC77
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnAudioFadeChangeSignature._FunctionPtr == IntPtr.Zero)
			{
				FOnAudioFadeChangeSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnAudioFadeChangeSignature__DelegateSignature");
			}
			return FOnAudioFadeChangeSignature._FunctionPtr;
		}

		// Token: 0x0600D01A RID: 53274 RVA: 0x0012FA9A File Offset: 0x0012DC9A
		public FOnAudioFadeChangeSignature()
		{
		}

		// Token: 0x0600D01B RID: 53275 RVA: 0x0012FAA2 File Offset: 0x0012DCA2
		[NullableContext(2)]
		public FOnAudioFadeChangeSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D01C RID: 53276 RVA: 0x0012FAAC File Offset: 0x0012DCAC
		public FOnAudioFadeChangeSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D01D RID: 53277 RVA: 0x0012FAB7 File Offset: 0x0012DCB7
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool, float>) ?? ((Action<bool, float>)Delegate.CreateDelegate(typeof(Action<bool, float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D01E RID: 53278 RVA: 0x0012FAE9 File Offset: 0x0012DCE9
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0600D01F RID: 53279 RVA: 0x0012FB23 File Offset: 0x0012DD23
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<bool, float> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600D020 RID: 53280 RVA: 0x0012FB2C File Offset: 0x0012DD2C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(bool bFadeOut, float FadeTime)
		{
			FOnAudioFadeChangeSignature.__FOnAudioFadeChangeSignature_DelegateParams* ptr = stackalloc FOnAudioFadeChangeSignature.__FOnAudioFadeChangeSignature_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnAudioFadeChangeSignature.__FOnAudioFadeChangeSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnAudioFadeChangeSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bFadeOut = bFadeOut;
			ptr->FadeTime = FadeTime;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600D021 RID: 53281 RVA: 0x0012FB70 File Offset: 0x0012DD70
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool, float> action = target as Action<bool, float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnAudioFadeChangeSignature.__FOnAudioFadeChangeSignature_DelegateParams*)__Parameters)->bFadeOut, ((FOnAudioFadeChangeSignature.__FOnAudioFadeChangeSignature_DelegateParams*)__Parameters)->FadeTime);
		}

		// Token: 0x04007021 RID: 28705
		internal static IntPtr _FunctionPtr;

		// Token: 0x04007022 RID: 28706
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnAudioFadeChangeSignature__DelegateSignature";

		// Token: 0x04007023 RID: 28707
		private static int RegisterId;

		// Token: 0x02002D58 RID: 11608
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnAudioFadeChangeSignature_DelegateParams
		{
			// Token: 0x0401676B RID: 92011
			[FieldOffset(0)]
			public bool bFadeOut;

			// Token: 0x0401676C RID: 92012
			[FieldOffset(4)]
			public float FadeTime;
		}

		// Token: 0x02002D59 RID: 11609
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401676D RID: 92013
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
