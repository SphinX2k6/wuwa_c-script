using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200059C RID: 1436
	public sealed class FOnKSCLandFireSpawn : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06008202 RID: 33282 RVA: 0x000C012B File Offset: 0x000BE32B
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnKSCLandFireSpawn.StaticFunctionPtr();
		}

		// Token: 0x06008203 RID: 33283 RVA: 0x000C0137 File Offset: 0x000BE337
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnKSCLandFireSpawn._FunctionPtr == IntPtr.Zero)
			{
				FOnKSCLandFireSpawn._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroSimpleCombat.OnKSCLandFireSpawn__DelegateSignature");
			}
			return FOnKSCLandFireSpawn._FunctionPtr;
		}

		// Token: 0x06008204 RID: 33284 RVA: 0x000C015A File Offset: 0x000BE35A
		public FOnKSCLandFireSpawn()
		{
		}

		// Token: 0x06008205 RID: 33285 RVA: 0x000C0162 File Offset: 0x000BE362
		[NullableContext(2)]
		public FOnKSCLandFireSpawn(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008206 RID: 33286 RVA: 0x000C016C File Offset: 0x000BE36C
		public FOnKSCLandFireSpawn(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008207 RID: 33287 RVA: 0x000C0177 File Offset: 0x000BE377
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as FOnKSCLandFireSpawn.FOnKSCLandFireSpawn_ScriptDelegate) ?? ((FOnKSCLandFireSpawn.FOnKSCLandFireSpawn_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnKSCLandFireSpawn.FOnKSCLandFireSpawn_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x06008208 RID: 33288 RVA: 0x000C01A9 File Offset: 0x000BE3A9
		[NullableContext(1)]
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

		// Token: 0x06008209 RID: 33289 RVA: 0x000C01E4 File Offset: 0x000BE3E4
		[SkipLocalsInit]
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

		// Token: 0x0600820A RID: 33290 RVA: 0x000C0254 File Offset: 0x000BE454
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x040038B3 RID: 14515
		internal static IntPtr _FunctionPtr;

		// Token: 0x040038B4 RID: 14516
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.OnKSCLandFireSpawn__DelegateSignature";

		// Token: 0x040038B5 RID: 14517
		private static int RegisterId;

		// Token: 0x02000D1A RID: 3354
		// (Invoke) Token: 0x0600BF0F RID: 48911
		public delegate void FOnKSCLandFireSpawn_ScriptDelegate([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FKSC_LandFireContext> LandFireContext);

		// Token: 0x02000D1B RID: 3355
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FOnKSCLandFireSpawn_DelegateParams
		{
			// Token: 0x04005FAC RID: 24492
			[FieldOffset(0)]
			public byte LandFireContext;
		}

		// Token: 0x02000D1C RID: 3356
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005FAD RID: 24493
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
