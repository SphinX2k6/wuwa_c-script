using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F29 RID: 3881
	public sealed class FOnQueueSubtitles : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D179 RID: 53625 RVA: 0x00132B06 File Offset: 0x00130D06
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnQueueSubtitles.StaticFunctionPtr();
		}

		// Token: 0x0600D17A RID: 53626 RVA: 0x00132B12 File Offset: 0x00130D12
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnQueueSubtitles._FunctionPtr == IntPtr.Zero)
			{
				FOnQueueSubtitles._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnQueueSubtitles__DelegateSignature");
			}
			return FOnQueueSubtitles._FunctionPtr;
		}

		// Token: 0x0600D17B RID: 53627 RVA: 0x00132B35 File Offset: 0x00130D35
		public FOnQueueSubtitles()
		{
		}

		// Token: 0x0600D17C RID: 53628 RVA: 0x00132B3D File Offset: 0x00130D3D
		[NullableContext(2)]
		public FOnQueueSubtitles(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D17D RID: 53629 RVA: 0x00132B47 File Offset: 0x00130D47
		public FOnQueueSubtitles(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D17E RID: 53630 RVA: 0x00132B52 File Offset: 0x00130D52
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as FOnQueueSubtitles.FOnQueueSubtitles_ScriptDelegate) ?? ((FOnQueueSubtitles.FOnQueueSubtitles_ScriptDelegate)Delegate.CreateDelegate(typeof(FOnQueueSubtitles.FOnQueueSubtitles_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D17F RID: 53631 RVA: 0x00132B84 File Offset: 0x00130D84
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(FOnQueueSubtitles.FOnQueueSubtitles_ScriptDelegate Callback)
		{
			if (FOnQueueSubtitles.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnQueueSubtitles.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnQueueSubtitles.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnQueueSubtitles.OnScriptCallback));
				}
				FOnQueueSubtitles.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnQueueSubtitles.RegisterId);
		}

		// Token: 0x0600D180 RID: 53632 RVA: 0x00132BC0 File Offset: 0x00130DC0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FSubtitleCue> Subtitles, float CueDuration)
		{
			FOnQueueSubtitles.__FOnQueueSubtitles_DelegateParams* ptr = stackalloc FOnQueueSubtitles.__FOnQueueSubtitles_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FOnQueueSubtitles.__FOnQueueSubtitles_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnQueueSubtitles.StaticFunctionPtr(), (void*)ptr, 1);
			TArray<FSubtitleCue> tarray = Subtitles;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Subtitles);
			}
			ptr->CueDuration = CueDuration;
			base.ExecuteInternal((void*)ptr);
			TArray<FSubtitleCue> tarray2 = Subtitles;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Subtitles);
			}
			UnrealReflectionUtils.DestroyStruct(FOnQueueSubtitles._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600D181 RID: 53633 RVA: 0x00132C38 File Offset: 0x00130E38
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			FOnQueueSubtitles.FOnQueueSubtitles_ScriptDelegate fonQueueSubtitles_ScriptDelegate = target as FOnQueueSubtitles.FOnQueueSubtitles_ScriptDelegate;
			if (fonQueueSubtitles_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<FSubtitleCue> tarray = new TArray<FSubtitleCue>(&((FOnQueueSubtitles.__FOnQueueSubtitles_DelegateParams*)__Parameters)->Subtitles, true, true);
			fonQueueSubtitles_ScriptDelegate(tarray, ((FOnQueueSubtitles.__FOnQueueSubtitles_DelegateParams*)__Parameters)->CueDuration);
			if (tarray != null)
			{
				tarray.CopyTo(&((FOnQueueSubtitles.__FOnQueueSubtitles_DelegateParams*)__Parameters)->Subtitles, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x04007087 RID: 28807
		internal static IntPtr _FunctionPtr;

		// Token: 0x04007088 RID: 28808
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnQueueSubtitles__DelegateSignature";

		// Token: 0x04007089 RID: 28809
		private static int RegisterId;

		// Token: 0x02002D9C RID: 11676
		// (Invoke) Token: 0x0602854A RID: 165194
		public delegate void FOnQueueSubtitles_ScriptDelegate([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FSubtitleCue> Subtitles, float CueDuration);

		// Token: 0x02002D9D RID: 11677
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FOnQueueSubtitles_DelegateParams
		{
			// Token: 0x040167C3 RID: 92099
			[FieldOffset(0)]
			public byte Subtitles;

			// Token: 0x040167C4 RID: 92100
			[FieldOffset(16)]
			public float CueDuration;
		}

		// Token: 0x02002D9E RID: 11678
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040167C5 RID: 92101
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
