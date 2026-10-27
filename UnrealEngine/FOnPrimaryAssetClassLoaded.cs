using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F22 RID: 3874
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnPrimaryAssetClassLoaded : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D135 RID: 53557 RVA: 0x00132107 File Offset: 0x00130307
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnPrimaryAssetClassLoaded.StaticFunctionPtr();
		}

		// Token: 0x0600D136 RID: 53558 RVA: 0x00132113 File Offset: 0x00130313
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnPrimaryAssetClassLoaded._FunctionPtr == IntPtr.Zero)
			{
				FOnPrimaryAssetClassLoaded._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnPrimaryAssetClassLoaded__DelegateSignature");
			}
			return FOnPrimaryAssetClassLoaded._FunctionPtr;
		}

		// Token: 0x0600D137 RID: 53559 RVA: 0x00132136 File Offset: 0x00130336
		public FOnPrimaryAssetClassLoaded()
		{
		}

		// Token: 0x0600D138 RID: 53560 RVA: 0x0013213E File Offset: 0x0013033E
		[NullableContext(2)]
		public FOnPrimaryAssetClassLoaded(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D139 RID: 53561 RVA: 0x00132148 File Offset: 0x00130348
		public FOnPrimaryAssetClassLoaded(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D13A RID: 53562 RVA: 0x00132153 File Offset: 0x00130353
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as FOnPrimaryAssetClassLoaded.FOnPrimaryAssetClassLoaded_ScriptDelegate) ?? ((FOnPrimaryAssetClassLoaded.FOnPrimaryAssetClassLoaded_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnPrimaryAssetClassLoaded.FOnPrimaryAssetClassLoaded_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D13B RID: 53563 RVA: 0x00132185 File Offset: 0x00130385
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(FOnPrimaryAssetClassLoaded.FOnPrimaryAssetClassLoaded_ScriptDelegate Callback)
		{
			if (FOnPrimaryAssetClassLoaded.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnPrimaryAssetClassLoaded.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnPrimaryAssetClassLoaded.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnPrimaryAssetClassLoaded.OnScriptCallback));
				}
				FOnPrimaryAssetClassLoaded.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnPrimaryAssetClassLoaded.RegisterId);
		}

		// Token: 0x0600D13C RID: 53564 RVA: 0x001321BF File Offset: 0x001303BF
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(FOnPrimaryAssetClassLoaded.FOnPrimaryAssetClassLoaded_ScriptDelegate Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600D13D RID: 53565 RVA: 0x001321C8 File Offset: 0x001303C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UClassStackOnlyPtr Loaded)
		{
			FOnPrimaryAssetClassLoaded.__FOnPrimaryAssetClassLoaded_DelegateParams* ptr = stackalloc FOnPrimaryAssetClassLoaded.__FOnPrimaryAssetClassLoaded_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnPrimaryAssetClassLoaded.__FOnPrimaryAssetClassLoaded_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnPrimaryAssetClassLoaded.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Loaded = Loaded;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600D13E RID: 53566 RVA: 0x00132204 File Offset: 0x00130404
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FOnPrimaryAssetClassLoaded.FOnPrimaryAssetClassLoaded_ScriptDelegate fonPrimaryAssetClassLoaded_ScriptDelegate = target as FOnPrimaryAssetClassLoaded.FOnPrimaryAssetClassLoaded_ScriptDelegate;
			if (fonPrimaryAssetClassLoaded_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			fonPrimaryAssetClassLoaded_ScriptDelegate(((FOnPrimaryAssetClassLoaded.__FOnPrimaryAssetClassLoaded_DelegateParams*)__Parameters)->Loaded);
		}

		// Token: 0x04007074 RID: 28788
		internal static IntPtr _FunctionPtr;

		// Token: 0x04007075 RID: 28789
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnPrimaryAssetClassLoaded__DelegateSignature";

		// Token: 0x04007076 RID: 28790
		private static int RegisterId;

		// Token: 0x02002D8C RID: 11660
		// (Invoke) Token: 0x06028542 RID: 165186
		public delegate void FOnPrimaryAssetClassLoaded_ScriptDelegate(UClassStackOnlyPtr Loaded);

		// Token: 0x02002D8D RID: 11661
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnPrimaryAssetClassLoaded_DelegateParams
		{
			// Token: 0x040167AF RID: 92079
			[FieldOffset(0)]
			public UClassStackOnlyPtr Loaded;
		}

		// Token: 0x02002D8E RID: 11662
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040167B0 RID: 92080
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
