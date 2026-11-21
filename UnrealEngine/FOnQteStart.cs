using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007DD RID: 2013
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnQteStart : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600AD20 RID: 44320 RVA: 0x000FFF3A File Offset: 0x000FE13A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnQteStart.StaticFunctionPtr();
		}

		// Token: 0x0600AD21 RID: 44321 RVA: 0x000FFF46 File Offset: 0x000FE146
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnQteStart._FunctionPtr == IntPtr.Zero)
			{
				FOnQteStart._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SequenceDialogue.OnQteStart__DelegateSignature");
			}
			return FOnQteStart._FunctionPtr;
		}

		// Token: 0x0600AD22 RID: 44322 RVA: 0x000FFF69 File Offset: 0x000FE169
		public FOnQteStart()
		{
		}

		// Token: 0x0600AD23 RID: 44323 RVA: 0x000FFF71 File Offset: 0x000FE171
		[NullableContext(2)]
		public FOnQteStart(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AD24 RID: 44324 RVA: 0x000FFF7B File Offset: 0x000FE17B
		public FOnQteStart(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AD25 RID: 44325 RVA: 0x000FFF86 File Offset: 0x000FE186
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FMovieSceneQteEventParam>) ?? ((Action<FMovieSceneQteEventParam>)Delegate.CreateDelegate(typeof(Action<FMovieSceneQteEventParam>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600AD26 RID: 44326 RVA: 0x000FFFB8 File Offset: 0x000FE1B8
		[NullableContext(1)]
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

		// Token: 0x0600AD27 RID: 44327 RVA: 0x000FFFF2 File Offset: 0x000FE1F2
		[NullableContext(1)]
		public void Remove(Action<FMovieSceneQteEventParam> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600AD28 RID: 44328 RVA: 0x000FFFFC File Offset: 0x000FE1FC
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x0600AD29 RID: 44329 RVA: 0x00100068 File Offset: 0x000FE268
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04004AA0 RID: 19104
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004AA1 RID: 19105
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SequenceDialogue.OnQteStart__DelegateSignature";

		// Token: 0x04004AA2 RID: 19106
		private static int RegisterId;

		// Token: 0x02000F87 RID: 3975
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		private ref struct __FOnQteStart_DelegateParams
		{
			// Token: 0x04006381 RID: 25473
			[FieldOffset(0)]
			public byte Param;
		}

		// Token: 0x02000F88 RID: 3976
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006382 RID: 25474
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
