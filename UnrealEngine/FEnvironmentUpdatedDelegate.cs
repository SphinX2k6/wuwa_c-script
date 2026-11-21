using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200030D RID: 781
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FEnvironmentUpdatedDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06005336 RID: 21302 RVA: 0x0007462E File Offset: 0x0007282E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FEnvironmentUpdatedDelegate.StaticFunctionPtr();
		}

		// Token: 0x06005337 RID: 21303 RVA: 0x0007463A File Offset: 0x0007283A
		private static IntPtr StaticFunctionPtr()
		{
			if (UKuroAudioEnvironmentSubsystem.__EnvironmentUpdatedDelegate__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UKuroAudioEnvironmentSubsystem.__EnvironmentUpdatedDelegate__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroAudio.KuroAudioEnvironmentSubsystem:EnvironmentUpdatedDelegate__DelegateSignature");
			}
			return UKuroAudioEnvironmentSubsystem.__EnvironmentUpdatedDelegate__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06005338 RID: 21304 RVA: 0x0007465D File Offset: 0x0007285D
		public FEnvironmentUpdatedDelegate()
		{
		}

		// Token: 0x06005339 RID: 21305 RVA: 0x00074665 File Offset: 0x00072865
		[NullableContext(2)]
		public FEnvironmentUpdatedDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600533A RID: 21306 RVA: 0x0007466F File Offset: 0x0007286F
		public FEnvironmentUpdatedDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600533B RID: 21307 RVA: 0x0007467A File Offset: 0x0007287A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600533C RID: 21308 RVA: 0x000746AC File Offset: 0x000728AC
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (FEnvironmentUpdatedDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FEnvironmentUpdatedDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FEnvironmentUpdatedDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FEnvironmentUpdatedDelegate.OnScriptCallback));
				}
				FEnvironmentUpdatedDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FEnvironmentUpdatedDelegate.RegisterId);
		}

		// Token: 0x0600533D RID: 21309 RVA: 0x000746E6 File Offset: 0x000728E6
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600533E RID: 21310 RVA: 0x000746EF File Offset: 0x000728EF
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0600533F RID: 21311 RVA: 0x000746FC File Offset: 0x000728FC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action action = target as Action;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action();
		}

		// Token: 0x0400220E RID: 8718
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroAudio.KuroAudioEnvironmentSubsystem:EnvironmentUpdatedDelegate__DelegateSignature";

		// Token: 0x0400220F RID: 8719
		private static int RegisterId;

		// Token: 0x02000A16 RID: 2582
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040059D6 RID: 22998
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
