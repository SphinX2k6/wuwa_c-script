using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F2A RID: 3882
	public sealed class FOnSubmixEnvelopeBP : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D182 RID: 53634 RVA: 0x00132CAD File Offset: 0x00130EAD
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnSubmixEnvelopeBP.StaticFunctionPtr();
		}

		// Token: 0x0600D183 RID: 53635 RVA: 0x00132CB9 File Offset: 0x00130EB9
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnSubmixEnvelopeBP._FunctionPtr == IntPtr.Zero)
			{
				FOnSubmixEnvelopeBP._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnSubmixEnvelopeBP__DelegateSignature");
			}
			return FOnSubmixEnvelopeBP._FunctionPtr;
		}

		// Token: 0x0600D184 RID: 53636 RVA: 0x00132CDC File Offset: 0x00130EDC
		public FOnSubmixEnvelopeBP()
		{
		}

		// Token: 0x0600D185 RID: 53637 RVA: 0x00132CE4 File Offset: 0x00130EE4
		[NullableContext(2)]
		public FOnSubmixEnvelopeBP(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D186 RID: 53638 RVA: 0x00132CEE File Offset: 0x00130EEE
		public FOnSubmixEnvelopeBP(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D187 RID: 53639 RVA: 0x00132CF9 File Offset: 0x00130EF9
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as FOnSubmixEnvelopeBP.FOnSubmixEnvelopeBP_ScriptDelegate) ?? ((FOnSubmixEnvelopeBP.FOnSubmixEnvelopeBP_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnSubmixEnvelopeBP.FOnSubmixEnvelopeBP_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D188 RID: 53640 RVA: 0x00132D2B File Offset: 0x00130F2B
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(FOnSubmixEnvelopeBP.FOnSubmixEnvelopeBP_ScriptDelegate Callback)
		{
			if (FOnSubmixEnvelopeBP.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnSubmixEnvelopeBP.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnSubmixEnvelopeBP.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnSubmixEnvelopeBP.OnScriptCallback));
				}
				FOnSubmixEnvelopeBP.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnSubmixEnvelopeBP.RegisterId);
		}

		// Token: 0x0600D189 RID: 53641 RVA: 0x00132D68 File Offset: 0x00130F68
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(in TArray<float> Envelope)
		{
			FOnSubmixEnvelopeBP.__FOnSubmixEnvelopeBP_DelegateParams* ptr = stackalloc FOnSubmixEnvelopeBP.__FOnSubmixEnvelopeBP_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnSubmixEnvelopeBP.__FOnSubmixEnvelopeBP_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnSubmixEnvelopeBP.StaticFunctionPtr(), (void*)ptr, 1);
			TArray<float> tarray = Envelope;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Envelope);
			}
			base.ExecuteInternal((void*)ptr);
			TArray<float> tarray2 = Envelope;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Envelope);
			}
			UnrealReflectionUtils.DestroyStruct(FOnSubmixEnvelopeBP._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600D18A RID: 53642 RVA: 0x00132DD8 File Offset: 0x00130FD8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FOnSubmixEnvelopeBP.FOnSubmixEnvelopeBP_ScriptDelegate fonSubmixEnvelopeBP_ScriptDelegate = target as FOnSubmixEnvelopeBP.FOnSubmixEnvelopeBP_ScriptDelegate;
			if (fonSubmixEnvelopeBP_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<float> tarray = new TArray<float>(&((FOnSubmixEnvelopeBP.__FOnSubmixEnvelopeBP_DelegateParams*)__Parameters)->Envelope, true, true);
			fonSubmixEnvelopeBP_ScriptDelegate(tarray);
			if (tarray != null)
			{
				tarray.CopyTo(&((FOnSubmixEnvelopeBP.__FOnSubmixEnvelopeBP_DelegateParams*)__Parameters)->Envelope, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x0400708A RID: 28810
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400708B RID: 28811
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnSubmixEnvelopeBP__DelegateSignature";

		// Token: 0x0400708C RID: 28812
		private static int RegisterId;

		// Token: 0x02002D9F RID: 11679
		// (Invoke) Token: 0x0602854E RID: 165198
		public delegate void FOnSubmixEnvelopeBP_ScriptDelegate(in TArray<float> Envelope);

		// Token: 0x02002DA0 RID: 11680
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnSubmixEnvelopeBP_DelegateParams
		{
			// Token: 0x040167C6 RID: 92102
			[FieldOffset(0)]
			public byte Envelope;
		}

		// Token: 0x02002DA1 RID: 11681
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040167C7 RID: 92103
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
