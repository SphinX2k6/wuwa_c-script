using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E69 RID: 7785
	public sealed class FOnKSCLandFireSpawn : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DA98 RID: 121496 RVA: 0x002BCE4F File Offset: 0x002BB04F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnKSCLandFireSpawn.StaticFunctionPtr();
		}

		// Token: 0x0601DA99 RID: 121497 RVA: 0x002BCE5B File Offset: 0x002BB05B
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnKSCLandFireSpawn._FunctionPtr == IntPtr.Zero)
			{
				FOnKSCLandFireSpawn._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSimpleCombat.OnKSCLandFireSpawn__DelegateSignature");
			}
			return FOnKSCLandFireSpawn._FunctionPtr;
		}

		// Token: 0x0601DA9A RID: 121498 RVA: 0x002BCE7E File Offset: 0x002BB07E
		public FOnKSCLandFireSpawn()
		{
		}

		// Token: 0x0601DA9B RID: 121499 RVA: 0x002BCE86 File Offset: 0x002BB086
		[NullableContext(2)]
		public FOnKSCLandFireSpawn(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DA9C RID: 121500 RVA: 0x002BCE90 File Offset: 0x002BB090
		public FOnKSCLandFireSpawn(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DA9D RID: 121501 RVA: 0x002BCE9B File Offset: 0x002BB09B
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as FOnKSCLandFireSpawn.FOnKSCLandFireSpawn_ScriptDelegate) ?? ((FOnKSCLandFireSpawn.FOnKSCLandFireSpawn_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnKSCLandFireSpawn.FOnKSCLandFireSpawn_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DA9E RID: 121502 RVA: 0x002BCECD File Offset: 0x002BB0CD
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(FOnKSCLandFireSpawn.FOnKSCLandFireSpawn_ScriptDelegate Callback)
		{
			if (FOnKSCLandFireSpawn.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnKSCLandFireSpawn.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnKSCLandFireSpawn.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnKSCLandFireSpawn.OnScriptCallback));
				}
				FOnKSCLandFireSpawn.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnKSCLandFireSpawn.RegisterId);
		}

		// Token: 0x0601DA9F RID: 121503 RVA: 0x002BCF08 File Offset: 0x002BB108
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FKSC_LandFireContext> LandFireContext)
		{
			FOnKSCLandFireSpawn.__FOnKSCLandFireSpawn_DelegateParams* ptr = stackalloc FOnKSCLandFireSpawn.__FOnKSCLandFireSpawn_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnKSCLandFireSpawn.__FOnKSCLandFireSpawn_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnKSCLandFireSpawn.StaticFunctionPtr(), (void*)ptr, 1);
			TArray<FKSC_LandFireContext> tarray = LandFireContext;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->LandFireContext);
			}
			base.ExecuteInternal((void*)ptr);
			TArray<FKSC_LandFireContext> tarray2 = LandFireContext;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->LandFireContext);
			}
			UnrealReflectionUtils.DestroyStruct(FOnKSCLandFireSpawn._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DAA0 RID: 121504 RVA: 0x002BCF78 File Offset: 0x002BB178
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FOnKSCLandFireSpawn.FOnKSCLandFireSpawn_ScriptDelegate fonKSCLandFireSpawn_ScriptDelegate = target as FOnKSCLandFireSpawn.FOnKSCLandFireSpawn_ScriptDelegate;
			if (fonKSCLandFireSpawn_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<FKSC_LandFireContext> tarray = new TArray<FKSC_LandFireContext>(&((FOnKSCLandFireSpawn.__FOnKSCLandFireSpawn_DelegateParams*)__Parameters)->LandFireContext, true, true);
			fonKSCLandFireSpawn_ScriptDelegate(tarray);
			if (tarray != null)
			{
				tarray.CopyTo(&((FOnKSCLandFireSpawn.__FOnKSCLandFireSpawn_DelegateParams*)__Parameters)->LandFireContext, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x0401011E RID: 65822
		internal static IntPtr _FunctionPtr;

		// Token: 0x0401011F RID: 65823
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.OnKSCLandFireSpawn__DelegateSignature";

		// Token: 0x04010120 RID: 65824
		private static int RegisterId;

		// Token: 0x020032BB RID: 12987
		// (Invoke) Token: 0x0602859E RID: 165278
		public delegate void FOnKSCLandFireSpawn_ScriptDelegate([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FKSC_LandFireContext> LandFireContext);

		// Token: 0x020032BC RID: 12988
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnKSCLandFireSpawn_DelegateParams
		{
			// Token: 0x04017160 RID: 94560
			[FieldOffset(0)]
			public byte LandFireContext;
		}

		// Token: 0x020032BD RID: 12989
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017161 RID: 94561
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
