using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029A2 RID: 10658
	public sealed class FOnGetItemChildrenDynamic : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060276E0 RID: 161504 RVA: 0x003C2206 File Offset: 0x003C0406
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnGetItemChildrenDynamic.StaticFunctionPtr();
		}

		// Token: 0x060276E1 RID: 161505 RVA: 0x003C2212 File Offset: 0x003C0412
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnGetItemChildrenDynamic._FunctionPtr == IntPtr.Zero)
			{
				FOnGetItemChildrenDynamic._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.OnGetItemChildrenDynamic__DelegateSignature");
			}
			return FOnGetItemChildrenDynamic._FunctionPtr;
		}

		// Token: 0x060276E2 RID: 161506 RVA: 0x003C2235 File Offset: 0x003C0435
		public FOnGetItemChildrenDynamic()
		{
		}

		// Token: 0x060276E3 RID: 161507 RVA: 0x003C223D File Offset: 0x003C043D
		[NullableContext(2)]
		public FOnGetItemChildrenDynamic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060276E4 RID: 161508 RVA: 0x003C2247 File Offset: 0x003C0447
		public FOnGetItemChildrenDynamic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060276E5 RID: 161509 RVA: 0x003C2252 File Offset: 0x003C0452
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as FOnGetItemChildrenDynamic.FOnGetItemChildrenDynamic_ScriptDelegate) ?? ((FOnGetItemChildrenDynamic.FOnGetItemChildrenDynamic_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnGetItemChildrenDynamic.FOnGetItemChildrenDynamic_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x060276E6 RID: 161510 RVA: 0x003C2284 File Offset: 0x003C0484
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(FOnGetItemChildrenDynamic.FOnGetItemChildrenDynamic_ScriptDelegate Callback)
		{
			if (FOnGetItemChildrenDynamic.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnGetItemChildrenDynamic.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnGetItemChildrenDynamic.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnGetItemChildrenDynamic.OnScriptCallback));
				}
				FOnGetItemChildrenDynamic.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnGetItemChildrenDynamic.RegisterId);
		}

		// Token: 0x060276E7 RID: 161511 RVA: 0x003C22C0 File Offset: 0x003C04C0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(UObject Item, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UObject> Children)
		{
			FOnGetItemChildrenDynamic.__FOnGetItemChildrenDynamic_DelegateParams* ptr = stackalloc FOnGetItemChildrenDynamic.__FOnGetItemChildrenDynamic_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FOnGetItemChildrenDynamic.__FOnGetItemChildrenDynamic_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnGetItemChildrenDynamic.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Item = ((Item != null) ? Item.NativePtr : IntPtr.Zero);
			TArray<UObject> tarray = Children;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Children);
			}
			base.ExecuteInternal((void*)ptr);
			TArray<UObject> tarray2 = Children;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Children);
			}
			UnrealReflectionUtils.DestroyStruct(FOnGetItemChildrenDynamic._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060276E8 RID: 161512 RVA: 0x003C2348 File Offset: 0x003C0548
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FOnGetItemChildrenDynamic.FOnGetItemChildrenDynamic_ScriptDelegate fonGetItemChildrenDynamic_ScriptDelegate = target as FOnGetItemChildrenDynamic.FOnGetItemChildrenDynamic_ScriptDelegate;
			if (fonGetItemChildrenDynamic_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(((FOnGetItemChildrenDynamic.__FOnGetItemChildrenDynamic_DelegateParams*)__Parameters)->Item);
			TArray<UObject> tarray = new TArray<UObject>(&((FOnGetItemChildrenDynamic.__FOnGetItemChildrenDynamic_DelegateParams*)__Parameters)->Children, true, true);
			fonGetItemChildrenDynamic_ScriptDelegate(orCreateUObjectByNativePointer, ref tarray);
			if (tarray != null)
			{
				tarray.CopyTo(&((FOnGetItemChildrenDynamic.__FOnGetItemChildrenDynamic_DelegateParams*)__Parameters)->Children, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x04015A46 RID: 88646
		internal static IntPtr _FunctionPtr;

		// Token: 0x04015A47 RID: 88647
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.OnGetItemChildrenDynamic__DelegateSignature";

		// Token: 0x04015A48 RID: 88648
		private static int RegisterId;

		// Token: 0x02003B9C RID: 15260
		// (Invoke) Token: 0x060285D6 RID: 165334
		public delegate void FOnGetItemChildrenDynamic_ScriptDelegate(UObject Item, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UObject> Children);

		// Token: 0x02003B9D RID: 15261
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FOnGetItemChildrenDynamic_DelegateParams
		{
			// Token: 0x04017D79 RID: 97657
			[FieldOffset(0)]
			public IntPtr Item;

			// Token: 0x04017D7A RID: 97658
			[FieldOffset(8)]
			public byte Children;
		}

		// Token: 0x02003B9E RID: 15262
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D7B RID: 97659
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
