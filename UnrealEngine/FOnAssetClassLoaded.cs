using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F01 RID: 3841
	public sealed class FOnAssetClassLoaded : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600CFFC RID: 53244 RVA: 0x0012F662 File Offset: 0x0012D862
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnAssetClassLoaded.StaticFunctionPtr();
		}

		// Token: 0x0600CFFD RID: 53245 RVA: 0x0012F66E File Offset: 0x0012D86E
		private static IntPtr StaticFunctionPtr()
		{
			if (UKismetSystemLibrary.__OnAssetClassLoaded__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UKismetSystemLibrary.__OnAssetClassLoaded__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.KismetSystemLibrary:OnAssetClassLoaded__DelegateSignature");
			}
			return UKismetSystemLibrary.__OnAssetClassLoaded__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0600CFFE RID: 53246 RVA: 0x0012F691 File Offset: 0x0012D891
		public FOnAssetClassLoaded()
		{
		}

		// Token: 0x0600CFFF RID: 53247 RVA: 0x0012F699 File Offset: 0x0012D899
		[NullableContext(2)]
		public FOnAssetClassLoaded(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D000 RID: 53248 RVA: 0x0012F6A3 File Offset: 0x0012D8A3
		public FOnAssetClassLoaded(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D001 RID: 53249 RVA: 0x0012F6AE File Offset: 0x0012D8AE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as FOnAssetClassLoaded.FOnAssetClassLoaded_ScriptDelegate) ?? ((FOnAssetClassLoaded.FOnAssetClassLoaded_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnAssetClassLoaded.FOnAssetClassLoaded_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D002 RID: 53250 RVA: 0x0012F6E0 File Offset: 0x0012D8E0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(FOnAssetClassLoaded.FOnAssetClassLoaded_ScriptDelegate Callback)
		{
			if (FOnAssetClassLoaded.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnAssetClassLoaded.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnAssetClassLoaded.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnAssetClassLoaded.OnScriptCallback));
				}
				FOnAssetClassLoaded.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnAssetClassLoaded.RegisterId);
		}

		// Token: 0x0600D003 RID: 53251 RVA: 0x0012F71C File Offset: 0x0012D91C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(UClassStackOnlyPtr Loaded)
		{
			FOnAssetClassLoaded.__FOnAssetClassLoaded_DelegateParams* ptr = stackalloc FOnAssetClassLoaded.__FOnAssetClassLoaded_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnAssetClassLoaded.__FOnAssetClassLoaded_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnAssetClassLoaded.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Loaded = Loaded;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0600D004 RID: 53252 RVA: 0x0012F75C File Offset: 0x0012D95C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FOnAssetClassLoaded.FOnAssetClassLoaded_ScriptDelegate fonAssetClassLoaded_ScriptDelegate = target as FOnAssetClassLoaded.FOnAssetClassLoaded_ScriptDelegate;
			if (fonAssetClassLoaded_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			fonAssetClassLoaded_ScriptDelegate(((FOnAssetClassLoaded.__FOnAssetClassLoaded_DelegateParams*)__Parameters)->Loaded);
		}

		// Token: 0x0400701A RID: 28698
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.KismetSystemLibrary:OnAssetClassLoaded__DelegateSignature";

		// Token: 0x0400701B RID: 28699
		private static int RegisterId;

		// Token: 0x02002D51 RID: 11601
		// (Invoke) Token: 0x06028536 RID: 165174
		public delegate void FOnAssetClassLoaded_ScriptDelegate(UClassStackOnlyPtr Loaded);

		// Token: 0x02002D52 RID: 11602
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnAssetClassLoaded_DelegateParams
		{
			// Token: 0x04016764 RID: 92004
			[FieldOffset(0)]
			public UClassStackOnlyPtr Loaded;
		}

		// Token: 0x02002D53 RID: 11603
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016765 RID: 92005
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
