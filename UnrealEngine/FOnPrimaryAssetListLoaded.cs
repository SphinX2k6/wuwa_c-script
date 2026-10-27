using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F23 RID: 3875
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnPrimaryAssetListLoaded : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D13F RID: 53567 RVA: 0x0013224E File Offset: 0x0013044E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnPrimaryAssetListLoaded.StaticFunctionPtr();
		}

		// Token: 0x0600D140 RID: 53568 RVA: 0x0013225A File Offset: 0x0013045A
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnPrimaryAssetListLoaded._FunctionPtr == IntPtr.Zero)
			{
				FOnPrimaryAssetListLoaded._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnPrimaryAssetListLoaded__DelegateSignature");
			}
			return FOnPrimaryAssetListLoaded._FunctionPtr;
		}

		// Token: 0x0600D141 RID: 53569 RVA: 0x0013227D File Offset: 0x0013047D
		public FOnPrimaryAssetListLoaded()
		{
		}

		// Token: 0x0600D142 RID: 53570 RVA: 0x00132285 File Offset: 0x00130485
		[NullableContext(2)]
		public FOnPrimaryAssetListLoaded(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D143 RID: 53571 RVA: 0x0013228F File Offset: 0x0013048F
		public FOnPrimaryAssetListLoaded(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D144 RID: 53572 RVA: 0x0013229A File Offset: 0x0013049A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as FOnPrimaryAssetListLoaded.FOnPrimaryAssetListLoaded_ScriptDelegate) ?? ((FOnPrimaryAssetListLoaded.FOnPrimaryAssetListLoaded_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnPrimaryAssetListLoaded.FOnPrimaryAssetListLoaded_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D145 RID: 53573 RVA: 0x001322CC File Offset: 0x001304CC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(FOnPrimaryAssetListLoaded.FOnPrimaryAssetListLoaded_ScriptDelegate Callback)
		{
			if (FOnPrimaryAssetListLoaded.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnPrimaryAssetListLoaded.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnPrimaryAssetListLoaded.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnPrimaryAssetListLoaded.OnScriptCallback));
				}
				FOnPrimaryAssetListLoaded.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnPrimaryAssetListLoaded.RegisterId);
		}

		// Token: 0x0600D146 RID: 53574 RVA: 0x00132306 File Offset: 0x00130506
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(FOnPrimaryAssetListLoaded.FOnPrimaryAssetListLoaded_ScriptDelegate Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600D147 RID: 53575 RVA: 0x00132310 File Offset: 0x00130510
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<UObject> Loaded)
		{
			FOnPrimaryAssetListLoaded.__FOnPrimaryAssetListLoaded_DelegateParams* ptr = stackalloc FOnPrimaryAssetListLoaded.__FOnPrimaryAssetListLoaded_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnPrimaryAssetListLoaded.__FOnPrimaryAssetListLoaded_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnPrimaryAssetListLoaded.StaticFunctionPtr(), (void*)ptr, 1);
			TArray<UObject> tarray = Loaded;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Loaded);
			}
			base.BroadcastInternal((void*)ptr);
			TArray<UObject> tarray2 = Loaded;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Loaded);
			}
			UnrealReflectionUtils.DestroyStruct(FOnPrimaryAssetListLoaded._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600D148 RID: 53576 RVA: 0x00132380 File Offset: 0x00130580
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FOnPrimaryAssetListLoaded.FOnPrimaryAssetListLoaded_ScriptDelegate fonPrimaryAssetListLoaded_ScriptDelegate = target as FOnPrimaryAssetListLoaded.FOnPrimaryAssetListLoaded_ScriptDelegate;
			if (fonPrimaryAssetListLoaded_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<UObject> tarray = new TArray<UObject>(&((FOnPrimaryAssetListLoaded.__FOnPrimaryAssetListLoaded_DelegateParams*)__Parameters)->Loaded, true, true);
			fonPrimaryAssetListLoaded_ScriptDelegate(tarray);
			if (tarray != null)
			{
				tarray.CopyTo(&((FOnPrimaryAssetListLoaded.__FOnPrimaryAssetListLoaded_DelegateParams*)__Parameters)->Loaded, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x04007077 RID: 28791
		internal static IntPtr _FunctionPtr;

		// Token: 0x04007078 RID: 28792
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnPrimaryAssetListLoaded__DelegateSignature";

		// Token: 0x04007079 RID: 28793
		private static int RegisterId;

		// Token: 0x02002D8F RID: 11663
		// (Invoke) Token: 0x06028546 RID: 165190
		public delegate void FOnPrimaryAssetListLoaded_ScriptDelegate([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<UObject> Loaded);

		// Token: 0x02002D90 RID: 11664
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnPrimaryAssetListLoaded_DelegateParams
		{
			// Token: 0x040167B1 RID: 92081
			[FieldOffset(0)]
			public byte Loaded;
		}

		// Token: 0x02002D91 RID: 11665
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040167B2 RID: 92082
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
