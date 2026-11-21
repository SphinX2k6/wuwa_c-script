using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200024F RID: 591
	public sealed class FOnAssetLoaded : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060032CE RID: 13006 RVA: 0x0004889E File Offset: 0x00046A9E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnAssetLoaded.StaticFunctionPtr();
		}

		// Token: 0x060032CF RID: 13007 RVA: 0x000488AA File Offset: 0x00046AAA
		private static IntPtr StaticFunctionPtr()
		{
			if (UKismetSystemLibrary.__OnAssetLoaded__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UKismetSystemLibrary.__OnAssetLoaded__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.KismetSystemLibrary:OnAssetLoaded__DelegateSignature");
			}
			return UKismetSystemLibrary.__OnAssetLoaded__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x060032D0 RID: 13008 RVA: 0x000488CD File Offset: 0x00046ACD
		public FOnAssetLoaded()
		{
		}

		// Token: 0x060032D1 RID: 13009 RVA: 0x000488D5 File Offset: 0x00046AD5
		[NullableContext(2)]
		public FOnAssetLoaded(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060032D2 RID: 13010 RVA: 0x000488DF File Offset: 0x00046ADF
		public FOnAssetLoaded(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060032D3 RID: 13011 RVA: 0x000488EA File Offset: 0x00046AEA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<UObject>) ?? ((Action<UObject>)Delegate.CreateDelegate(typeof(Action<UObject>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060032D4 RID: 13012 RVA: 0x0004891C File Offset: 0x00046B1C
		public void Bind([Nullable(new byte[]
		{
			1,
			2
		})] Action<UObject> Callback)
		{
			if (FOnAssetLoaded.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnAssetLoaded.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnAssetLoaded.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnAssetLoaded.OnScriptCallback));
				}
				FOnAssetLoaded.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnAssetLoaded.RegisterId);
		}

		// Token: 0x060032D5 RID: 13013 RVA: 0x00048958 File Offset: 0x00046B58
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Execute(UObject Loaded)
		{
			FOnAssetLoaded.__FOnAssetLoaded_DelegateParams* ptr = stackalloc FOnAssetLoaded.__FOnAssetLoaded_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnAssetLoaded.__FOnAssetLoaded_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnAssetLoaded.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Loaded = ((Loaded != null) ? Loaded.NativePtr : IntPtr.Zero);
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x060032D6 RID: 13014 RVA: 0x000489A4 File Offset: 0x00046BA4
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UObject> action = target as Action<UObject>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(((FOnAssetLoaded.__FOnAssetLoaded_DelegateParams*)__Parameters)->Loaded);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x040011BA RID: 4538
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.KismetSystemLibrary:OnAssetLoaded__DelegateSignature";

		// Token: 0x040011BB RID: 4539
		private static int RegisterId;

		// Token: 0x020009C9 RID: 2505
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FOnAssetLoaded_DelegateParams
		{
			// Token: 0x04005955 RID: 22869
			[FieldOffset(0)]
			public IntPtr Loaded;
		}

		// Token: 0x020009CA RID: 2506
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005956 RID: 22870
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
