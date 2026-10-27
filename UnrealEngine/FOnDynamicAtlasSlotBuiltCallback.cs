using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001806 RID: 6150
	public sealed class FOnDynamicAtlasSlotBuiltCallback : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06016C2D RID: 93229 RVA: 0x00213797 File Offset: 0x00211997
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnDynamicAtlasSlotBuiltCallback.StaticFunctionPtr();
		}

		// Token: 0x06016C2E RID: 93230 RVA: 0x002137A3 File Offset: 0x002119A3
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnDynamicAtlasSlotBuiltCallback._FunctionPtr == IntPtr.Zero)
			{
				FOnDynamicAtlasSlotBuiltCallback._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroDynamicAtlas.OnDynamicAtlasSlotBuiltCallback__DelegateSignature");
			}
			return FOnDynamicAtlasSlotBuiltCallback._FunctionPtr;
		}

		// Token: 0x06016C2F RID: 93231 RVA: 0x002137C6 File Offset: 0x002119C6
		public FOnDynamicAtlasSlotBuiltCallback()
		{
		}

		// Token: 0x06016C30 RID: 93232 RVA: 0x002137CE File Offset: 0x002119CE
		[NullableContext(2)]
		public FOnDynamicAtlasSlotBuiltCallback(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016C31 RID: 93233 RVA: 0x002137D8 File Offset: 0x002119D8
		public FOnDynamicAtlasSlotBuiltCallback(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016C32 RID: 93234 RVA: 0x002137E3 File Offset: 0x002119E3
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as FOnDynamicAtlasSlotBuiltCallback.FOnDynamicAtlasSlotBuiltCallback_ScriptDelegate) ?? ((FOnDynamicAtlasSlotBuiltCallback.FOnDynamicAtlasSlotBuiltCallback_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnDynamicAtlasSlotBuiltCallback.FOnDynamicAtlasSlotBuiltCallback_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x06016C33 RID: 93235 RVA: 0x00213815 File Offset: 0x00211A15
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(FOnDynamicAtlasSlotBuiltCallback.FOnDynamicAtlasSlotBuiltCallback_ScriptDelegate Callback)
		{
			if (FOnDynamicAtlasSlotBuiltCallback.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnDynamicAtlasSlotBuiltCallback.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnDynamicAtlasSlotBuiltCallback.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnDynamicAtlasSlotBuiltCallback.OnScriptCallback));
				}
				FOnDynamicAtlasSlotBuiltCallback.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnDynamicAtlasSlotBuiltCallback.RegisterId);
		}

		// Token: 0x06016C34 RID: 93236 RVA: 0x00213850 File Offset: 0x00211A50
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FDynamicAtlasSlotManagedHandle> ManagedHandle)
		{
			FOnDynamicAtlasSlotBuiltCallback.__FOnDynamicAtlasSlotBuiltCallback_DelegateParams* ptr = stackalloc FOnDynamicAtlasSlotBuiltCallback.__FOnDynamicAtlasSlotBuiltCallback_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnDynamicAtlasSlotBuiltCallback.__FOnDynamicAtlasSlotBuiltCallback_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnDynamicAtlasSlotBuiltCallback.StaticFunctionPtr(), (void*)ptr, 1);
			TArray<FDynamicAtlasSlotManagedHandle> tarray = ManagedHandle;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->ManagedHandle);
			}
			base.ExecuteInternal((void*)ptr);
			TArray<FDynamicAtlasSlotManagedHandle> tarray2 = ManagedHandle;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->ManagedHandle);
			}
			UnrealReflectionUtils.DestroyStruct(FOnDynamicAtlasSlotBuiltCallback._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06016C35 RID: 93237 RVA: 0x002138C0 File Offset: 0x00211AC0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FOnDynamicAtlasSlotBuiltCallback.FOnDynamicAtlasSlotBuiltCallback_ScriptDelegate fonDynamicAtlasSlotBuiltCallback_ScriptDelegate = target as FOnDynamicAtlasSlotBuiltCallback.FOnDynamicAtlasSlotBuiltCallback_ScriptDelegate;
			if (fonDynamicAtlasSlotBuiltCallback_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<FDynamicAtlasSlotManagedHandle> tarray = new TArray<FDynamicAtlasSlotManagedHandle>(&((FOnDynamicAtlasSlotBuiltCallback.__FOnDynamicAtlasSlotBuiltCallback_DelegateParams*)__Parameters)->ManagedHandle, true, true);
			fonDynamicAtlasSlotBuiltCallback_ScriptDelegate(tarray);
			if (tarray != null)
			{
				tarray.CopyTo(&((FOnDynamicAtlasSlotBuiltCallback.__FOnDynamicAtlasSlotBuiltCallback_DelegateParams*)__Parameters)->ManagedHandle, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x0400C5A5 RID: 50597
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400C5A6 RID: 50598
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroDynamicAtlas.OnDynamicAtlasSlotBuiltCallback__DelegateSignature";

		// Token: 0x0400C5A7 RID: 50599
		private static int RegisterId;

		// Token: 0x02002F51 RID: 12113
		// (Invoke) Token: 0x06028576 RID: 165238
		public delegate void FOnDynamicAtlasSlotBuiltCallback_ScriptDelegate([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FDynamicAtlasSlotManagedHandle> ManagedHandle);

		// Token: 0x02002F52 RID: 12114
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnDynamicAtlasSlotBuiltCallback_DelegateParams
		{
			// Token: 0x04016AF9 RID: 92921
			[FieldOffset(0)]
			public byte ManagedHandle;
		}

		// Token: 0x02002F53 RID: 12115
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016AFA RID: 92922
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
