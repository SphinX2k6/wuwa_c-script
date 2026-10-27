using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F21 RID: 3873
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnPrimaryAssetClassListLoaded : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D12B RID: 53547 RVA: 0x00131F66 File Offset: 0x00130166
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnPrimaryAssetClassListLoaded.StaticFunctionPtr();
		}

		// Token: 0x0600D12C RID: 53548 RVA: 0x00131F72 File Offset: 0x00130172
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnPrimaryAssetClassListLoaded._FunctionPtr == IntPtr.Zero)
			{
				FOnPrimaryAssetClassListLoaded._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnPrimaryAssetClassListLoaded__DelegateSignature");
			}
			return FOnPrimaryAssetClassListLoaded._FunctionPtr;
		}

		// Token: 0x0600D12D RID: 53549 RVA: 0x00131F95 File Offset: 0x00130195
		public FOnPrimaryAssetClassListLoaded()
		{
		}

		// Token: 0x0600D12E RID: 53550 RVA: 0x00131F9D File Offset: 0x0013019D
		[NullableContext(2)]
		public FOnPrimaryAssetClassListLoaded(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D12F RID: 53551 RVA: 0x00131FA7 File Offset: 0x001301A7
		public FOnPrimaryAssetClassListLoaded(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D130 RID: 53552 RVA: 0x00131FB2 File Offset: 0x001301B2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as FOnPrimaryAssetClassListLoaded.FOnPrimaryAssetClassListLoaded_ScriptDelegate) ?? ((FOnPrimaryAssetClassListLoaded.FOnPrimaryAssetClassListLoaded_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnPrimaryAssetClassListLoaded.FOnPrimaryAssetClassListLoaded_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D131 RID: 53553 RVA: 0x00131FE4 File Offset: 0x001301E4
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(FOnPrimaryAssetClassListLoaded.FOnPrimaryAssetClassListLoaded_ScriptDelegate Callback)
		{
			if (FOnPrimaryAssetClassListLoaded.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnPrimaryAssetClassListLoaded.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnPrimaryAssetClassListLoaded.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnPrimaryAssetClassListLoaded.OnScriptCallback));
				}
				FOnPrimaryAssetClassListLoaded.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnPrimaryAssetClassListLoaded.RegisterId);
		}

		// Token: 0x0600D132 RID: 53554 RVA: 0x0013201E File Offset: 0x0013021E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(FOnPrimaryAssetClassListLoaded.FOnPrimaryAssetClassListLoaded_ScriptDelegate Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600D133 RID: 53555 RVA: 0x00132028 File Offset: 0x00130228
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<UClass> Loaded)
		{
			FOnPrimaryAssetClassListLoaded.__FOnPrimaryAssetClassListLoaded_DelegateParams* ptr = stackalloc FOnPrimaryAssetClassListLoaded.__FOnPrimaryAssetClassListLoaded_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnPrimaryAssetClassListLoaded.__FOnPrimaryAssetClassListLoaded_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnPrimaryAssetClassListLoaded.StaticFunctionPtr(), (void*)ptr, 1);
			TArray<UClass> tarray = Loaded;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Loaded);
			}
			base.BroadcastInternal((void*)ptr);
			TArray<UClass> tarray2 = Loaded;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Loaded);
			}
			UnrealReflectionUtils.DestroyStruct(FOnPrimaryAssetClassListLoaded._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600D134 RID: 53556 RVA: 0x00132098 File Offset: 0x00130298
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FOnPrimaryAssetClassListLoaded.FOnPrimaryAssetClassListLoaded_ScriptDelegate fonPrimaryAssetClassListLoaded_ScriptDelegate = target as FOnPrimaryAssetClassListLoaded.FOnPrimaryAssetClassListLoaded_ScriptDelegate;
			if (fonPrimaryAssetClassListLoaded_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<UClass> tarray = new TArray<UClass>(&((FOnPrimaryAssetClassListLoaded.__FOnPrimaryAssetClassListLoaded_DelegateParams*)__Parameters)->Loaded, true, true);
			fonPrimaryAssetClassListLoaded_ScriptDelegate(tarray);
			if (tarray != null)
			{
				tarray.CopyTo(&((FOnPrimaryAssetClassListLoaded.__FOnPrimaryAssetClassListLoaded_DelegateParams*)__Parameters)->Loaded, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x04007071 RID: 28785
		internal static IntPtr _FunctionPtr;

		// Token: 0x04007072 RID: 28786
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnPrimaryAssetClassListLoaded__DelegateSignature";

		// Token: 0x04007073 RID: 28787
		private static int RegisterId;

		// Token: 0x02002D89 RID: 11657
		// (Invoke) Token: 0x0602853E RID: 165182
		public delegate void FOnPrimaryAssetClassListLoaded_ScriptDelegate([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<UClass> Loaded);

		// Token: 0x02002D8A RID: 11658
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnPrimaryAssetClassListLoaded_DelegateParams
		{
			// Token: 0x040167AD RID: 92077
			[FieldOffset(0)]
			public byte Loaded;
		}

		// Token: 0x02002D8B RID: 11659
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040167AE RID: 92078
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
