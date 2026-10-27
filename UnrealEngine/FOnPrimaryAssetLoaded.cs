using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F24 RID: 3876
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnPrimaryAssetLoaded : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D149 RID: 53577 RVA: 0x001323EF File Offset: 0x001305EF
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnPrimaryAssetLoaded.StaticFunctionPtr();
		}

		// Token: 0x0600D14A RID: 53578 RVA: 0x001323FB File Offset: 0x001305FB
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnPrimaryAssetLoaded._FunctionPtr == IntPtr.Zero)
			{
				FOnPrimaryAssetLoaded._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnPrimaryAssetLoaded__DelegateSignature");
			}
			return FOnPrimaryAssetLoaded._FunctionPtr;
		}

		// Token: 0x0600D14B RID: 53579 RVA: 0x0013241E File Offset: 0x0013061E
		public FOnPrimaryAssetLoaded()
		{
		}

		// Token: 0x0600D14C RID: 53580 RVA: 0x00132426 File Offset: 0x00130626
		[NullableContext(2)]
		public FOnPrimaryAssetLoaded(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D14D RID: 53581 RVA: 0x00132430 File Offset: 0x00130630
		public FOnPrimaryAssetLoaded(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D14E RID: 53582 RVA: 0x0013243B File Offset: 0x0013063B
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UObject>) ?? ((Action<UObject>)Delegate.CreateDelegate(typeof(Action<UObject>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D14F RID: 53583 RVA: 0x0013246D File Offset: 0x0013066D
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UObject> Callback)
		{
			if (FOnPrimaryAssetLoaded.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnPrimaryAssetLoaded.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnPrimaryAssetLoaded.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnPrimaryAssetLoaded.OnScriptCallback));
				}
				FOnPrimaryAssetLoaded.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnPrimaryAssetLoaded.RegisterId);
		}

		// Token: 0x0600D150 RID: 53584 RVA: 0x001324A7 File Offset: 0x001306A7
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UObject> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600D151 RID: 53585 RVA: 0x001324B0 File Offset: 0x001306B0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UObject Loaded)
		{
			FOnPrimaryAssetLoaded.__FOnPrimaryAssetLoaded_DelegateParams* ptr = stackalloc FOnPrimaryAssetLoaded.__FOnPrimaryAssetLoaded_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnPrimaryAssetLoaded.__FOnPrimaryAssetLoaded_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnPrimaryAssetLoaded.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Loaded = ((Loaded != null) ? Loaded.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600D152 RID: 53586 RVA: 0x001324FC File Offset: 0x001306FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UObject> action = target as Action<UObject>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(((FOnPrimaryAssetLoaded.__FOnPrimaryAssetLoaded_DelegateParams*)__Parameters)->Loaded);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0400707A RID: 28794
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400707B RID: 28795
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnPrimaryAssetLoaded__DelegateSignature";

		// Token: 0x0400707C RID: 28796
		private static int RegisterId;

		// Token: 0x02002D92 RID: 11666
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnPrimaryAssetLoaded_DelegateParams
		{
			// Token: 0x040167B3 RID: 92083
			[FieldOffset(0)]
			public IntPtr Loaded;
		}

		// Token: 0x02002D93 RID: 11667
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040167B4 RID: 92084
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
