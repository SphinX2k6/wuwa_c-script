using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200050A RID: 1290
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnGameEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600790E RID: 30990 RVA: 0x000B1786 File Offset: 0x000AF986
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnGameEvent.StaticFunctionPtr();
		}

		// Token: 0x0600790F RID: 30991 RVA: 0x000B1792 File Offset: 0x000AF992
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnGameEvent._FunctionPtr == IntPtr.Zero)
			{
				FOnGameEvent._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRhythmGame.OnGameEvent__DelegateSignature");
			}
			return FOnGameEvent._FunctionPtr;
		}

		// Token: 0x06007910 RID: 30992 RVA: 0x000B17B5 File Offset: 0x000AF9B5
		public FOnGameEvent()
		{
		}

		// Token: 0x06007911 RID: 30993 RVA: 0x000B17BD File Offset: 0x000AF9BD
		[NullableContext(2)]
		public FOnGameEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007912 RID: 30994 RVA: 0x000B17C7 File Offset: 0x000AF9C7
		public FOnGameEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007913 RID: 30995 RVA: 0x000B17D2 File Offset: 0x000AF9D2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<EKuroRhythmChartEventType>) ?? ((Action<EKuroRhythmChartEventType>)Delegate.CreateDelegate(typeof(Action<EKuroRhythmChartEventType>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007914 RID: 30996 RVA: 0x000B1804 File Offset: 0x000AFA04
		[NullableContext(1)]
		public void Add(Action<EKuroRhythmChartEventType> Callback)
		{
			if (FOnGameEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnGameEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnGameEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnGameEvent.OnScriptCallback));
				}
				FOnGameEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnGameEvent.RegisterId);
		}

		// Token: 0x06007915 RID: 30997 RVA: 0x000B183E File Offset: 0x000AFA3E
		[NullableContext(1)]
		public void Remove(Action<EKuroRhythmChartEventType> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06007916 RID: 30998 RVA: 0x000B1848 File Offset: 0x000AFA48
		[SkipLocalsInit]
		public unsafe void Broadcast(EKuroRhythmChartEventType EventType)
		{
			FOnGameEvent.__FOnGameEvent_DelegateParams* ptr = stackalloc FOnGameEvent.__FOnGameEvent_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FOnGameEvent.__FOnGameEvent_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnGameEvent.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EventType = EventType;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06007917 RID: 30999 RVA: 0x000B1884 File Offset: 0x000AFA84
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<EKuroRhythmChartEventType> action = target as Action<EKuroRhythmChartEventType>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnGameEvent.__FOnGameEvent_DelegateParams*)__Parameters)->EventType);
		}

		// Token: 0x0400337B RID: 13179
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400337C RID: 13180
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRhythmGame.OnGameEvent__DelegateSignature";

		// Token: 0x0400337D RID: 13181
		private static int RegisterId;

		// Token: 0x02000C6D RID: 3181
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		private ref struct __FOnGameEvent_DelegateParams
		{
			// Token: 0x04005EC7 RID: 24263
			[FieldOffset(0)]
			public EKuroRhythmChartEventType EventType;
		}

		// Token: 0x02000C6E RID: 3182
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005EC8 RID: 24264
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
