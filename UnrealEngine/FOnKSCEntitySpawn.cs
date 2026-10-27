using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E67 RID: 7783
	public sealed class FOnKSCEntitySpawn : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DA86 RID: 121478 RVA: 0x002BCAF3 File Offset: 0x002BACF3
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnKSCEntitySpawn.StaticFunctionPtr();
		}

		// Token: 0x0601DA87 RID: 121479 RVA: 0x002BCAFF File Offset: 0x002BACFF
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnKSCEntitySpawn._FunctionPtr == IntPtr.Zero)
			{
				FOnKSCEntitySpawn._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSimpleCombat.OnKSCEntitySpawn__DelegateSignature");
			}
			return FOnKSCEntitySpawn._FunctionPtr;
		}

		// Token: 0x0601DA88 RID: 121480 RVA: 0x002BCB22 File Offset: 0x002BAD22
		public FOnKSCEntitySpawn()
		{
		}

		// Token: 0x0601DA89 RID: 121481 RVA: 0x002BCB2A File Offset: 0x002BAD2A
		[NullableContext(2)]
		public FOnKSCEntitySpawn(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DA8A RID: 121482 RVA: 0x002BCB34 File Offset: 0x002BAD34
		public FOnKSCEntitySpawn(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DA8B RID: 121483 RVA: 0x002BCB3F File Offset: 0x002BAD3F
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as FOnKSCEntitySpawn.FOnKSCEntitySpawn_ScriptDelegate) ?? ((FOnKSCEntitySpawn.FOnKSCEntitySpawn_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnKSCEntitySpawn.FOnKSCEntitySpawn_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DA8C RID: 121484 RVA: 0x002BCB71 File Offset: 0x002BAD71
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(FOnKSCEntitySpawn.FOnKSCEntitySpawn_ScriptDelegate Callback)
		{
			if (FOnKSCEntitySpawn.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnKSCEntitySpawn.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnKSCEntitySpawn.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnKSCEntitySpawn.OnScriptCallback));
				}
				FOnKSCEntitySpawn.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnKSCEntitySpawn.RegisterId);
		}

		// Token: 0x0601DA8D RID: 121485 RVA: 0x002BCBAC File Offset: 0x002BADAC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(FTransformDouble OwnerTransform, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FKSC_SpawnEntity> SpawnEntities)
		{
			FOnKSCEntitySpawn.__FOnKSCEntitySpawn_DelegateParams* ptr = stackalloc FOnKSCEntitySpawn.__FOnKSCEntitySpawn_DelegateParams[(UIntPtr)95] + 15L / (long)sizeof(FOnKSCEntitySpawn.__FOnKSCEntitySpawn_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnKSCEntitySpawn.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->OwnerTransform = OwnerTransform;
			TArray<FKSC_SpawnEntity> tarray = SpawnEntities;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->SpawnEntities);
			}
			base.ExecuteInternal((void*)ptr);
			TArray<FKSC_SpawnEntity> tarray2 = SpawnEntities;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->SpawnEntities);
			}
			UnrealReflectionUtils.DestroyStruct(FOnKSCEntitySpawn._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DA8E RID: 121486 RVA: 0x002BCC24 File Offset: 0x002BAE24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FOnKSCEntitySpawn.FOnKSCEntitySpawn_ScriptDelegate fonKSCEntitySpawn_ScriptDelegate = target as FOnKSCEntitySpawn.FOnKSCEntitySpawn_ScriptDelegate;
			if (fonKSCEntitySpawn_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<FKSC_SpawnEntity> tarray = new TArray<FKSC_SpawnEntity>(&((FOnKSCEntitySpawn.__FOnKSCEntitySpawn_DelegateParams*)__Parameters)->SpawnEntities, true, true);
			fonKSCEntitySpawn_ScriptDelegate(((FOnKSCEntitySpawn.__FOnKSCEntitySpawn_DelegateParams*)__Parameters)->OwnerTransform, tarray);
			if (tarray != null)
			{
				tarray.CopyTo(&((FOnKSCEntitySpawn.__FOnKSCEntitySpawn_DelegateParams*)__Parameters)->SpawnEntities, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x04010118 RID: 65816
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010119 RID: 65817
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.OnKSCEntitySpawn__DelegateSignature";

		// Token: 0x0401011A RID: 65818
		private static int RegisterId;

		// Token: 0x020032B5 RID: 12981
		// (Invoke) Token: 0x06028596 RID: 165270
		public delegate void FOnKSCEntitySpawn_ScriptDelegate(FTransformDouble OwnerTransform, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FKSC_SpawnEntity> SpawnEntities);

		// Token: 0x020032B6 RID: 12982
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __FOnKSCEntitySpawn_DelegateParams
		{
			// Token: 0x04017159 RID: 94553
			[FieldOffset(0)]
			public FTransformDouble OwnerTransform;

			// Token: 0x0401715A RID: 94554
			[FieldOffset(64)]
			public byte SpawnEntities;
		}

		// Token: 0x020032B7 RID: 12983
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401715B RID: 94555
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
