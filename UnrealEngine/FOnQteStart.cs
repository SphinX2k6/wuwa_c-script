using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002707 RID: 9991
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnQteStart : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060250B1 RID: 151729 RVA: 0x0036D296 File Offset: 0x0036B496
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnQteStart.StaticFunctionPtr();
		}

		// Token: 0x060250B2 RID: 151730 RVA: 0x0036D2A2 File Offset: 0x0036B4A2
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnQteStart._FunctionPtr == IntPtr.Zero)
			{
				FOnQteStart._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SequenceDialogue.OnQteStart__DelegateSignature");
			}
			return FOnQteStart._FunctionPtr;
		}

		// Token: 0x060250B3 RID: 151731 RVA: 0x0036D2C5 File Offset: 0x0036B4C5
		public FOnQteStart()
		{
		}

		// Token: 0x060250B4 RID: 151732 RVA: 0x0036D2CD File Offset: 0x0036B4CD
		[NullableContext(2)]
		public FOnQteStart(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060250B5 RID: 151733 RVA: 0x0036D2D7 File Offset: 0x0036B4D7
		public FOnQteStart(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060250B6 RID: 151734 RVA: 0x0036D2E2 File Offset: 0x0036B4E2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FMovieSceneQteEventParam>) ?? ((Action<FMovieSceneQteEventParam>)Delegate.CreateDelegate(typeof(Action<FMovieSceneQteEventParam>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060250B7 RID: 151735 RVA: 0x0036D314 File Offset: 0x0036B514
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FMovieSceneQteEventParam> Callback)
		{
			if (FOnQteStart.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnQteStart.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnQteStart.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnQteStart.OnScriptCallback));
				}
				FOnQteStart.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnQteStart.RegisterId);
		}

		// Token: 0x060250B8 RID: 151736 RVA: 0x0036D34E File Offset: 0x0036B54E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FMovieSceneQteEventParam> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060250B9 RID: 151737 RVA: 0x0036D358 File Offset: 0x0036B558
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(FMovieSceneQteEventParam Param)
		{
			FOnQteStart.__FOnQteStart_DelegateParams* ptr = stackalloc FOnQteStart.__FOnQteStart_DelegateParams[(UIntPtr)199] + 15L / (long)sizeof(FOnQteStart.__FOnQteStart_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnQteStart.StaticFunctionPtr(), (void*)ptr, 1);
			if (Param != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneQteEventParam.StaticStruct(), &ptr->Param, Param.NativePtr, 1, false);
			}
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FOnQteStart._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060250BA RID: 151738 RVA: 0x0036D3C4 File Offset: 0x0036B5C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FMovieSceneQteEventParam> action = target as Action<FMovieSceneQteEventParam>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FMovieSceneQteEventParam obj = new FMovieSceneQteEventParam(&((FOnQteStart.__FOnQteStart_DelegateParams*)__Parameters)->Param, true, true);
			action(obj);
		}

		// Token: 0x04013F4D RID: 81741
		internal static IntPtr _FunctionPtr;

		// Token: 0x04013F4E RID: 81742
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SequenceDialogue.OnQteStart__DelegateSignature";

		// Token: 0x04013F4F RID: 81743
		private static int RegisterId;

		// Token: 0x020036AA RID: 13994
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __FOnQteStart_DelegateParams
		{
			// Token: 0x040177BD RID: 96189
			[FieldOffset(0)]
			public byte Param;
		}

		// Token: 0x020036AB RID: 13995
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040177BE RID: 96190
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
