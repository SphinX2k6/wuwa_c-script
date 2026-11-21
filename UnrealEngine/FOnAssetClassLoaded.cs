using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200024E RID: 590
	public sealed class FOnAssetClassLoaded : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060032C5 RID: 12997 RVA: 0x0004875A File Offset: 0x0004695A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnAssetClassLoaded.StaticFunctionPtr();
		}

		// Token: 0x060032C6 RID: 12998 RVA: 0x00048766 File Offset: 0x00046966
		private static IntPtr StaticFunctionPtr()
		{
			if (UKismetSystemLibrary.__OnAssetClassLoaded__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UKismetSystemLibrary.__OnAssetClassLoaded__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.KismetSystemLibrary:OnAssetClassLoaded__DelegateSignature");
			}
			return UKismetSystemLibrary.__OnAssetClassLoaded__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x060032C7 RID: 12999 RVA: 0x00048789 File Offset: 0x00046989
		public FOnAssetClassLoaded()
		{
		}

		// Token: 0x060032C8 RID: 13000 RVA: 0x00048791 File Offset: 0x00046991
		[NullableContext(2)]
		public FOnAssetClassLoaded(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060032C9 RID: 13001 RVA: 0x0004879B File Offset: 0x0004699B
		public FOnAssetClassLoaded(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060032CA RID: 13002 RVA: 0x000487A6 File Offset: 0x000469A6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as FOnAssetClassLoaded.FOnAssetClassLoaded_ScriptDelegate) ?? ((FOnAssetClassLoaded.FOnAssetClassLoaded_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnAssetClassLoaded.FOnAssetClassLoaded_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x060032CB RID: 13003 RVA: 0x000487D8 File Offset: 0x000469D8
		[NullableContext(1)]
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

		// Token: 0x060032CC RID: 13004 RVA: 0x00048814 File Offset: 0x00046A14
		[SkipLocalsInit]
		public unsafe void Execute(UClassStackOnlyPtr Loaded)
		{
			FOnAssetClassLoaded.__FOnAssetClassLoaded_DelegateParams* ptr = stackalloc FOnAssetClassLoaded.__FOnAssetClassLoaded_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnAssetClassLoaded.__FOnAssetClassLoaded_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnAssetClassLoaded.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Loaded = Loaded;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060032CD RID: 13005 RVA: 0x00048854 File Offset: 0x00046A54
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FOnAssetClassLoaded.FOnAssetClassLoaded_ScriptDelegate fonAssetClassLoaded_ScriptDelegate = target as FOnAssetClassLoaded.FOnAssetClassLoaded_ScriptDelegate;
			if (fonAssetClassLoaded_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			fonAssetClassLoaded_ScriptDelegate(((FOnAssetClassLoaded.__FOnAssetClassLoaded_DelegateParams*)__Parameters)->Loaded);
		}

		// Token: 0x040011B8 RID: 4536
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.KismetSystemLibrary:OnAssetClassLoaded__DelegateSignature";

		// Token: 0x040011B9 RID: 4537
		private static int RegisterId;

		// Token: 0x020009C6 RID: 2502
		// (Invoke) Token: 0x0600BEE3 RID: 48867
		public delegate void FOnAssetClassLoaded_ScriptDelegate(UClassStackOnlyPtr Loaded);

		// Token: 0x020009C7 RID: 2503
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FOnAssetClassLoaded_DelegateParams
		{
			// Token: 0x04005953 RID: 22867
			[FieldOffset(0)]
			public UClassStackOnlyPtr Loaded;
		}

		// Token: 0x020009C8 RID: 2504
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005954 RID: 22868
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
