using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001992 RID: 6546
	[UnrealObjectPath("/Script/KuroInput.BasePlayerController")]
	[UnrealStructLayout(2128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2128)]
	public class ABasePlayerController : APlayerController, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018517 RID: 99607 RVA: 0x0023DDAA File Offset: 0x0023BFAA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ABasePlayerController._ClassPtr;
		}

		// Token: 0x06018518 RID: 99608 RVA: 0x0023DDB8 File Offset: 0x0023BFB8
		public ABasePlayerController() : this(BuiltinUtils.AllocNativeUObject(ABasePlayerController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018519 RID: 99609 RVA: 0x0023DDE0 File Offset: 0x0023BFE0
		[NullableContext(1)]
		public ABasePlayerController(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABasePlayerController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601851A RID: 99610 RVA: 0x0023DE13 File Offset: 0x0023C013
		[NullableContext(2)]
		public void StopKuroForceFeedback(UKuroForceFeedbackEffect ForceFeedbackEffect, FName Tag)
		{
			ABasePlayerController.__StopKuroForceFeedback_Internal(base.NativePtr, (ForceFeedbackEffect != null) ? ForceFeedbackEffect.NativePtr : IntPtr.Zero, Tag);
		}

		// Token: 0x0601851B RID: 99611
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetUseSonyGamepadState(bool value);

		// Token: 0x0601851C RID: 99612
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetUseGamepadState(bool value);

		// Token: 0x0601851D RID: 99613
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetKuroForceFeedbackConfig(EGlobalKuroForceFeedbackType FeedbackConfig, int GlobalFeedbackCoef);

		// Token: 0x0601851E RID: 99614 RVA: 0x0023DE31 File Offset: 0x0023C031
		public virtual void ReceiveSetupInputComponent()
		{
			ABasePlayerController.__ReceiveSetupInputComponent_Internal(base.NativePtr);
		}

		// Token: 0x0601851F RID: 99615 RVA: 0x0023DE3E File Offset: 0x0023C03E
		public virtual void ReceivePreProcessInput(float DeltaTime, bool bGamePaused)
		{
			ABasePlayerController.__ReceivePreProcessInput_Internal(base.NativePtr, DeltaTime, bGamePaused);
		}

		// Token: 0x06018520 RID: 99616 RVA: 0x0023DE4D File Offset: 0x0023C04D
		public virtual void ReceivePostProcessInput(float DeltaTime, bool bGamePaused)
		{
			ABasePlayerController.__ReceivePostProcessInput_Internal(base.NativePtr, DeltaTime, bGamePaused);
		}

		// Token: 0x06018521 RID: 99617 RVA: 0x0023DE5C File Offset: 0x0023C05C
		public virtual void ReceiveOnDeviceChanged()
		{
			ABasePlayerController.__ReceiveOnDeviceChanged_Internal(base.NativePtr);
		}

		// Token: 0x06018522 RID: 99618 RVA: 0x0023DE69 File Offset: 0x0023C069
		[NullableContext(2)]
		public void PlayKuroForceFeedback(UKuroForceFeedbackEffect ForceFeedbackEffect, FName Tag, bool bLooping, bool bIgnoreTimeDilation, bool bPlayWhilePaused)
		{
			ABasePlayerController.__PlayKuroForceFeedback_Internal(base.NativePtr, (ForceFeedbackEffect != null) ? ForceFeedbackEffect.NativePtr : IntPtr.Zero, Tag, bLooping, bIgnoreTimeDilation, bPlayWhilePaused);
		}

		// Token: 0x06018523 RID: 99619 RVA: 0x0023DE8C File Offset: 0x0023C08C
		public virtual void OnReceivedPlayer()
		{
			ABasePlayerController.__OnReceivedPlayer_Internal(base.NativePtr);
		}

		// Token: 0x06018524 RID: 99620 RVA: 0x0023DE99 File Offset: 0x0023C099
		public void FlushPressedKeys()
		{
			ABasePlayerController.__FlushPressedKeys_Internal(base.NativePtr);
		}

		// Token: 0x06018525 RID: 99621 RVA: 0x0023DEA6 File Offset: 0x0023C0A6
		public void ClearTouchBindings()
		{
			ABasePlayerController.__ClearTouchBindings_Internal(base.NativePtr);
		}

		// Token: 0x06018526 RID: 99622 RVA: 0x0023DEB3 File Offset: 0x0023C0B3
		public void ClearKeyBindings()
		{
			ABasePlayerController.__ClearKeyBindings_Internal(base.NativePtr);
		}

		// Token: 0x06018527 RID: 99623 RVA: 0x0023DEC0 File Offset: 0x0023C0C0
		public void ClearAxisBindings()
		{
			ABasePlayerController.__ClearAxisBindings_Internal(base.NativePtr);
		}

		// Token: 0x06018528 RID: 99624 RVA: 0x0023DECD File Offset: 0x0023C0CD
		public void ClearActionBindings()
		{
			ABasePlayerController.__ClearActionBindings_Internal(base.NativePtr);
		}

		// Token: 0x06018529 RID: 99625 RVA: 0x0023DEDC File Offset: 0x0023C0DC
		[NullableContext(2)]
		public unsafe void AddTouchBinding(EInputEvent KeyEvent, UObject Object, in FName FuncName)
		{
			fixed (FName* ptr = &FuncName)
			{
				void* ptr2 = (void*)ptr;
				ABasePlayerController.__AddTouchBinding_Internal(base.NativePtr, KeyEvent, (Object != null) ? Object.NativePtr : IntPtr.Zero, FuncName);
			}
		}

		// Token: 0x0601852A RID: 99626 RVA: 0x0023DF14 File Offset: 0x0023C114
		[NullableContext(2)]
		public unsafe void AddKeyBinding(in FInputChord Chord, EInputEvent KeyEvent, UObject Object, in FName FuncName)
		{
			fixed (FName* ptr = &FuncName)
			{
				void* ptr2 = (void*)ptr;
				ABasePlayerController.__AddKeyBinding_Internal(base.NativePtr, (Chord ?? new FInputChord()).NativePtr, KeyEvent, (Object != null) ? Object.NativePtr : IntPtr.Zero, FuncName);
			}
		}

		// Token: 0x0601852B RID: 99627 RVA: 0x0023DF60 File Offset: 0x0023C160
		[NullableContext(2)]
		public unsafe void AddAxisBinding(in FName AxisName, UObject Object, in FName FuncName)
		{
			fixed (FName* ptr = &AxisName)
			{
				void* ptr2 = (void*)ptr;
				fixed (FName* ptr3 = &FuncName)
				{
					void* ptr4 = (void*)ptr3;
					ABasePlayerController.__AddAxisBinding_Internal(base.NativePtr, AxisName, (Object != null) ? Object.NativePtr : IntPtr.Zero, FuncName);
					ptr = null;
				}
			}
		}

		// Token: 0x0601852C RID: 99628 RVA: 0x0023DF9C File Offset: 0x0023C19C
		[NullableContext(2)]
		public unsafe void AddActionBinding(in FName ActionName, EInputEvent KeyEvent, UObject Object, in FName FuncName)
		{
			fixed (FName* ptr = &ActionName)
			{
				void* ptr2 = (void*)ptr;
				fixed (FName* ptr3 = &FuncName)
				{
					void* ptr4 = (void*)ptr3;
					ABasePlayerController.__AddActionBinding_Internal(base.NativePtr, ActionName, KeyEvent, (Object != null) ? Object.NativePtr : IntPtr.Zero, FuncName);
					ptr = null;
				}
			}
		}

		// Token: 0x0601852D RID: 99629
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopKuroForceFeedback_Internal(IntPtr @this, IntPtr ForceFeedbackEffect, FName Tag);

		// Token: 0x0601852E RID: 99630
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveSetupInputComponent_Internal(IntPtr @this);

		// Token: 0x0601852F RID: 99631
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceivePreProcessInput_Internal(IntPtr @this, float DeltaTime, bool bGamePaused);

		// Token: 0x06018530 RID: 99632
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceivePostProcessInput_Internal(IntPtr @this, float DeltaTime, bool bGamePaused);

		// Token: 0x06018531 RID: 99633
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveOnDeviceChanged_Internal(IntPtr @this);

		// Token: 0x06018532 RID: 99634
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayKuroForceFeedback_Internal(IntPtr @this, IntPtr ForceFeedbackEffect, FName Tag, bool bLooping, bool bIgnoreTimeDilation, bool bPlayWhilePaused);

		// Token: 0x06018533 RID: 99635
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnReceivedPlayer_Internal(IntPtr @this);

		// Token: 0x06018534 RID: 99636
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FlushPressedKeys_Internal(IntPtr @this);

		// Token: 0x06018535 RID: 99637
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearTouchBindings_Internal(IntPtr @this);

		// Token: 0x06018536 RID: 99638
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearKeyBindings_Internal(IntPtr @this);

		// Token: 0x06018537 RID: 99639
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearAxisBindings_Internal(IntPtr @this);

		// Token: 0x06018538 RID: 99640
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearActionBindings_Internal(IntPtr @this);

		// Token: 0x06018539 RID: 99641
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddTouchBinding_Internal(IntPtr @this, TEnumAsByte<EInputEvent> KeyEvent, IntPtr Object, in FName FuncName);

		// Token: 0x0601853A RID: 99642
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddKeyBinding_Internal(IntPtr @this, IntPtr Chord, TEnumAsByte<EInputEvent> KeyEvent, IntPtr Object, in FName FuncName);

		// Token: 0x0601853B RID: 99643
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddAxisBinding_Internal(IntPtr @this, in FName AxisName, IntPtr Object, in FName FuncName);

		// Token: 0x0601853C RID: 99644
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddActionBinding_Internal(IntPtr @this, in FName ActionName, TEnumAsByte<EInputEvent> KeyEvent, IntPtr Object, in FName FuncName);

		// Token: 0x0601853D RID: 99645 RVA: 0x0023DFDE File Offset: 0x0023C1DE
		static ABasePlayerController()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroInput.BasePlayerController");
		}

		// Token: 0x0601853E RID: 99646 RVA: 0x0023DFEC File Offset: 0x0023C1EC
		protected ABasePlayerController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D27D RID: 53885
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroInput.BasePlayerController";

		// Token: 0x0400D27E RID: 53886
		private static IntPtr _ClassPtr;

		// Token: 0x0400D27F RID: 53887
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x02003086 RID: 12422
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ReceivePreProcessInput_FunctionParams
		{
			// Token: 0x04016D68 RID: 93544
			[FieldOffset(0)]
			public float DeltaTime;

			// Token: 0x04016D69 RID: 93545
			[FieldOffset(4)]
			public bool bGamePaused;
		}

		// Token: 0x02003087 RID: 12423
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ReceivePostProcessInput_FunctionParams
		{
			// Token: 0x04016D6A RID: 93546
			[FieldOffset(0)]
			public float DeltaTime;

			// Token: 0x04016D6B RID: 93547
			[FieldOffset(4)]
			public bool bGamePaused;
		}
	}
}
