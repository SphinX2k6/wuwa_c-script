using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F2C RID: 3884
	public sealed class FOnSubmixSpectralAnalysisBP : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D195 RID: 53653 RVA: 0x00132FA5 File Offset: 0x001311A5
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnSubmixSpectralAnalysisBP.StaticFunctionPtr();
		}

		// Token: 0x0600D196 RID: 53654 RVA: 0x00132FB1 File Offset: 0x001311B1
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnSubmixSpectralAnalysisBP._FunctionPtr == IntPtr.Zero)
			{
				FOnSubmixSpectralAnalysisBP._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnSubmixSpectralAnalysisBP__DelegateSignature");
			}
			return FOnSubmixSpectralAnalysisBP._FunctionPtr;
		}

		// Token: 0x0600D197 RID: 53655 RVA: 0x00132FD4 File Offset: 0x001311D4
		public FOnSubmixSpectralAnalysisBP()
		{
		}

		// Token: 0x0600D198 RID: 53656 RVA: 0x00132FDC File Offset: 0x001311DC
		[NullableContext(2)]
		public FOnSubmixSpectralAnalysisBP(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D199 RID: 53657 RVA: 0x00132FE6 File Offset: 0x001311E6
		public FOnSubmixSpectralAnalysisBP(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D19A RID: 53658 RVA: 0x00132FF1 File Offset: 0x001311F1
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as FOnSubmixSpectralAnalysisBP.FOnSubmixSpectralAnalysisBP_ScriptDelegate) ?? ((FOnSubmixSpectralAnalysisBP.FOnSubmixSpectralAnalysisBP_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnSubmixSpectralAnalysisBP.FOnSubmixSpectralAnalysisBP_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D19B RID: 53659 RVA: 0x00133023 File Offset: 0x00131223
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(FOnSubmixSpectralAnalysisBP.FOnSubmixSpectralAnalysisBP_ScriptDelegate Callback)
		{
			if (FOnSubmixSpectralAnalysisBP.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnSubmixSpectralAnalysisBP.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnSubmixSpectralAnalysisBP.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnSubmixSpectralAnalysisBP.OnScriptCallback));
				}
				FOnSubmixSpectralAnalysisBP.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnSubmixSpectralAnalysisBP.RegisterId);
		}

		// Token: 0x0600D19C RID: 53660 RVA: 0x00133060 File Offset: 0x00131260
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(in TArray<float> Magnitude)
		{
			FOnSubmixSpectralAnalysisBP.__FOnSubmixSpectralAnalysisBP_DelegateParams* ptr = stackalloc FOnSubmixSpectralAnalysisBP.__FOnSubmixSpectralAnalysisBP_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnSubmixSpectralAnalysisBP.__FOnSubmixSpectralAnalysisBP_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnSubmixSpectralAnalysisBP.StaticFunctionPtr(), (void*)ptr, 1);
			TArray<float> tarray = Magnitude;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Magnitude);
			}
			base.ExecuteInternal((void*)ptr);
			TArray<float> tarray2 = Magnitude;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Magnitude);
			}
			UnrealReflectionUtils.DestroyStruct(FOnSubmixSpectralAnalysisBP._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600D19D RID: 53661 RVA: 0x001330D0 File Offset: 0x001312D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FOnSubmixSpectralAnalysisBP.FOnSubmixSpectralAnalysisBP_ScriptDelegate fonSubmixSpectralAnalysisBP_ScriptDelegate = target as FOnSubmixSpectralAnalysisBP.FOnSubmixSpectralAnalysisBP_ScriptDelegate;
			if (fonSubmixSpectralAnalysisBP_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<float> tarray = new TArray<float>(&((FOnSubmixSpectralAnalysisBP.__FOnSubmixSpectralAnalysisBP_DelegateParams*)__Parameters)->Magnitude, true, true);
			fonSubmixSpectralAnalysisBP_ScriptDelegate(tarray);
			if (tarray != null)
			{
				tarray.CopyTo(&((FOnSubmixSpectralAnalysisBP.__FOnSubmixSpectralAnalysisBP_DelegateParams*)__Parameters)->Magnitude, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x04007090 RID: 28816
		internal static IntPtr _FunctionPtr;

		// Token: 0x04007091 RID: 28817
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnSubmixSpectralAnalysisBP__DelegateSignature";

		// Token: 0x04007092 RID: 28818
		private static int RegisterId;

		// Token: 0x02002DA4 RID: 11684
		// (Invoke) Token: 0x06028552 RID: 165202
		public delegate void FOnSubmixSpectralAnalysisBP_ScriptDelegate(in TArray<float> Magnitude);

		// Token: 0x02002DA5 RID: 11685
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnSubmixSpectralAnalysisBP_DelegateParams
		{
			// Token: 0x040167CA RID: 92106
			[FieldOffset(0)]
			public byte Magnitude;
		}

		// Token: 0x02002DA6 RID: 11686
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040167CB RID: 92107
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
