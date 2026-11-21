using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000448 RID: 1096
	[UnrealObjectPath("/Script/KuroInput.BasePlayerController")]
	[UnrealStructLayout(2168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2168)]
	public class ABasePlayerController : APlayerController, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060069CE RID: 27086 RVA: 0x0009A735 File Offset: 0x00098935
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ABasePlayerController._ClassPtr;
		}

		// Token: 0x060069CF RID: 27087 RVA: 0x0009A744 File Offset: 0x00098944
		public ABasePlayerController() : this(BuiltinUtils.AllocNativeUObject(ABasePlayerController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060069D0 RID: 27088 RVA: 0x0009A76C File Offset: 0x0009896C
		[NullableContext(1)]
		public ABasePlayerController(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABasePlayerController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060069D1 RID: 27089 RVA: 0x0009A79F File Offset: 0x0009899F
		[NullableContext(2)]
		public void StopKuroForceFeedback(UKuroForceFeedbackEffect ForceFeedbackEffect, FName Tag)
		{
			ABasePlayerController.__StopKuroForceFeedback_Internal(base.NativePtr, (ForceFeedbackEffect != null) ? ForceFeedbackEffect.NativePtr : IntPtr.Zero, Tag);
		}

		// Token: 0x060069D2 RID: 27090
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetUseSonyGamepadState(bool value);

		// Token: 0x060069D3 RID: 27091
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetUseGamepadState(bool value);

		// Token: 0x060069D4 RID: 27092
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetKuroForceFeedbackConfig(EGlobalKuroForceFeedbackType FeedbackConfig, int GlobalFeedbackCoef);

		// Token: 0x060069D5 RID: 27093 RVA: 0x0009A7BD File Offset: 0x000989BD
		public virtual void ReceiveSetupInputComponent()
		{
			ABasePlayerController.__ReceiveSetupInputComponent_Internal(base.NativePtr);
		}

		// Token: 0x060069D6 RID: 27094 RVA: 0x0009A7CA File Offset: 0x000989CA
		public virtual void ReceivePreProcessInput(float DeltaTime, bool bGamePaused)
		{
			ABasePlayerController.__ReceivePreProcessInput_Internal(base.NativePtr, DeltaTime, bGamePaused);
		}

		// Token: 0x060069D7 RID: 27095 RVA: 0x0009A7D9 File Offset: 0x000989D9
		public virtual void ReceivePostProcessInput(float DeltaTime, bool bGamePaused)
		{
			ABasePlayerController.__ReceivePostProcessInput_Internal(base.NativePtr, DeltaTime, bGamePaused);
		}

		// Token: 0x060069D8 RID: 27096 RVA: 0x0009A7E8 File Offset: 0x000989E8
		public virtual void ReceiveOnDeviceChanged()
		{
			ABasePlayerController.__ReceiveOnDeviceChanged_Internal(base.NativePtr);
		}

		// Token: 0x060069D9 RID: 27097 RVA: 0x0009A7F5 File Offset: 0x000989F5
		[NullableContext(2)]
		public void PlayKuroForceFeedback(UKuroForceFeedbackEffect ForceFeedbackEffect, FName Tag, bool bLooping, bool bIgnoreTimeDilation, bool bPlayWhilePaused)
		{
			ABasePlayerController.__PlayKuroForceFeedback_Internal(base.NativePtr, (ForceFeedbackEffect != null) ? ForceFeedbackEffect.NativePtr : IntPtr.Zero, Tag, bLooping, bIgnoreTimeDilation, bPlayWhilePaused);
		}

		// Token: 0x060069DA RID: 27098 RVA: 0x0009A818 File Offset: 0x00098A18
		public virtual void OnReceivedPlayer()
		{
			ABasePlayerController.__OnReceivedPlayer_Internal(base.NativePtr);
		}

		// Token: 0x060069DB RID: 27099 RVA: 0x0009A825 File Offset: 0x00098A25
		public void FlushPressedKeys()
		{
			ABasePlayerController.__FlushPressedKeys_Internal(base.NativePtr);
		}

		// Token: 0x060069DC RID: 27100 RVA: 0x0009A832 File Offset: 0x00098A32
		public void ClearTouchBindings()
		{
			ABasePlayerController.__ClearTouchBindings_Internal(base.NativePtr);
		}

		// Token: 0x060069DD RID: 27101 RVA: 0x0009A83F File Offset: 0x00098A3F
		public void ClearKeyBindings()
		{
			ABasePlayerController.__ClearKeyBindings_Internal(base.NativePtr);
		}

		// Token: 0x060069DE RID: 27102 RVA: 0x0009A84C File Offset: 0x00098A4C
		public void ClearAxisBindings()
		{
			ABasePlayerController.__ClearAxisBindings_Internal(base.NativePtr);
		}

		// Token: 0x060069DF RID: 27103 RVA: 0x0009A859 File Offset: 0x00098A59
		public void ClearActionBindings()
		{
			ABasePlayerController.__ClearActionBindings_Internal(base.NativePtr);
		}

		// Token: 0x060069E0 RID: 27104 RVA: 0x0009A868 File Offset: 0x00098A68
		[NullableContext(2)]
		public unsafe void AddTouchBinding(EInputEvent KeyEvent, UObject Object, in FName FuncName)
		{
			fixed (FName* ptr = &FuncName)
			{
				void* ptr2 = (void*)ptr;
				ABasePlayerController.__AddTouchBinding_Internal(base.NativePtr, KeyEvent, (Object != null) ? Object.NativePtr : IntPtr.Zero, FuncName);
			}
		}

		// Token: 0x060069E1 RID: 27105 RVA: 0x0009A8A0 File Offset: 0x00098AA0
		[NullableContext(2)]
		public unsafe void AddKeyBinding(in FInputChord Chord, EInputEvent KeyEvent, UObject Object, in FName FuncName)
		{
			fixed (FName* ptr = &FuncName)
			{
				void* ptr2 = (void*)ptr;
				ABasePlayerController.__AddKeyBinding_Internal(base.NativePtr, (Chord ?? new FInputChord()).NativePtr, KeyEvent, (Object != null) ? Object.NativePtr : IntPtr.Zero, FuncName);
			}
		}

		// Token: 0x060069E2 RID: 27106 RVA: 0x0009A8EC File Offset: 0x00098AEC
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

		// Token: 0x060069E3 RID: 27107 RVA: 0x0009A928 File Offset: 0x00098B28
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

		// Token: 0x060069E4 RID: 27108
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopKuroForceFeedback_Internal(IntPtr @this, IntPtr ForceFeedbackEffect, FName Tag);

		// Token: 0x060069E5 RID: 27109
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveSetupInputComponent_Internal(IntPtr @this);

		// Token: 0x060069E6 RID: 27110
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceivePreProcessInput_Internal(IntPtr @this, float DeltaTime, bool bGamePaused);

		// Token: 0x060069E7 RID: 27111
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceivePostProcessInput_Internal(IntPtr @this, float DeltaTime, bool bGamePaused);

		// Token: 0x060069E8 RID: 27112
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveOnDeviceChanged_Internal(IntPtr @this);

		// Token: 0x060069E9 RID: 27113
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayKuroForceFeedback_Internal(IntPtr @this, IntPtr ForceFeedbackEffect, FName Tag, bool bLooping, bool bIgnoreTimeDilation, bool bPlayWhilePaused);

		// Token: 0x060069EA RID: 27114
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnReceivedPlayer_Internal(IntPtr @this);

		// Token: 0x060069EB RID: 27115
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FlushPressedKeys_Internal(IntPtr @this);

		// Token: 0x060069EC RID: 27116
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearTouchBindings_Internal(IntPtr @this);

		// Token: 0x060069ED RID: 27117
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearKeyBindings_Internal(IntPtr @this);

		// Token: 0x060069EE RID: 27118
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearAxisBindings_Internal(IntPtr @this);

		// Token: 0x060069EF RID: 27119
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearActionBindings_Internal(IntPtr @this);

		// Token: 0x060069F0 RID: 27120
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddTouchBinding_Internal(IntPtr @this, TEnumAsByte<EInputEvent> KeyEvent, IntPtr Object, in FName FuncName);

		// Token: 0x060069F1 RID: 27121
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddKeyBinding_Internal(IntPtr @this, IntPtr Chord, TEnumAsByte<EInputEvent> KeyEvent, IntPtr Object, in FName FuncName);

		// Token: 0x060069F2 RID: 27122
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddAxisBinding_Internal(IntPtr @this, in FName AxisName, IntPtr Object, in FName FuncName);

		// Token: 0x060069F3 RID: 27123
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddActionBinding_Internal(IntPtr @this, in FName ActionName, TEnumAsByte<EInputEvent> KeyEvent, IntPtr Object, in FName FuncName);

		// Token: 0x060069F4 RID: 27124 RVA: 0x0009A96A File Offset: 0x00098B6A
		static ABasePlayerController()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroInput.BasePlayerController");
		}

		// Token: 0x060069F5 RID: 27125 RVA: 0x0009A978 File Offset: 0x00098B78
		protected ABasePlayerController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002CF3 RID: 11507
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroInput.BasePlayerController";

		// Token: 0x04002CF4 RID: 11508
		private static IntPtr _ClassPtr;

		// Token: 0x04002CF5 RID: 11509
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x02000B6A RID: 2922
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ReceivePreProcessInput_FunctionParams
		{
			// Token: 0x04005C86 RID: 23686
			[FieldOffset(0)]
			public float DeltaTime;

			// Token: 0x04005C87 RID: 23687
			[FieldOffset(4)]
			public bool bGamePaused;
		}

		// Token: 0x02000B6B RID: 2923
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ReceivePostProcessInput_FunctionParams
		{
			// Token: 0x04005C88 RID: 23688
			[FieldOffset(0)]
			public float DeltaTime;

			// Token: 0x04005C89 RID: 23689
			[FieldOffset(4)]
			public bool bGamePaused;
		}
	}
}
