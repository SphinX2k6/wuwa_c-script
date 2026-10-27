using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200123D RID: 4669
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.VOIPTalker")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UVOIPTalker : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011275 RID: 70261 RVA: 0x00192E8A File Offset: 0x0019108A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UVOIPTalker._ClassPtr;
		}

		// Token: 0x06011276 RID: 70262 RVA: 0x00192E98 File Offset: 0x00191098
		public UVOIPTalker() : this(BuiltinUtils.AllocNativeUObject(UVOIPTalker.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011277 RID: 70263 RVA: 0x00192EC0 File Offset: 0x001910C0
		public UVOIPTalker(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UVOIPTalker.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170042E6 RID: 17126
		// (get) Token: 0x06011278 RID: 70264 RVA: 0x00192EF4 File Offset: 0x001910F4
		// (set) Token: 0x06011279 RID: 70265 RVA: 0x00192F2D File Offset: 0x0019112D
		public FVoiceSettings Settings
		{
			get
			{
				base.FastCheckIsValid();
				FVoiceSettings result;
				if ((result = this._Settings) == null)
				{
					result = (this._Settings = new FVoiceSettings(base.NativePtr + (IntPtr)UVOIPTalker.__PropertyOffset_Settings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FVoiceSettings.StaticStruct(), base.NativePtr + (IntPtr)UVOIPTalker.__PropertyOffset_Settings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601127A RID: 70266 RVA: 0x00192F4E File Offset: 0x0019114E
		[NullableContext(2)]
		public void RegisterWithPlayerState(APlayerState OwningState)
		{
			UVOIPTalker.__RegisterWithPlayerState_Internal(base.NativePtr, (OwningState != null) ? OwningState.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601127B RID: 70267 RVA: 0x00192F6B File Offset: 0x0019116B
		public float GetVoiceLevel()
		{
			return UVOIPTalker.__GetVoiceLevel_Internal(base.NativePtr);
		}

		// Token: 0x0601127C RID: 70268 RVA: 0x00192F78 File Offset: 0x00191178
		[NullableContext(2)]
		public static UVOIPTalker CreateTalkerForPlayer(APlayerState OwningState)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UVOIPTalker>(UVOIPTalker.__CreateTalkerForPlayer_Internal((OwningState != null) ? OwningState.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0601127D RID: 70269 RVA: 0x00192F94 File Offset: 0x00191194
		public virtual void BPOnTalkingEnd()
		{
			UVOIPTalker.__BPOnTalkingEnd_Internal(base.NativePtr);
		}

		// Token: 0x0601127E RID: 70270 RVA: 0x00192FA1 File Offset: 0x001911A1
		protected virtual void BPOnTalkingEnd_Implementation()
		{
			UVOIPTalker.__BPOnTalkingEnd_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x0601127F RID: 70271 RVA: 0x00192FAE File Offset: 0x001911AE
		[NullableContext(2)]
		public virtual void BPOnTalkingBegin(UAudioComponent AudioComponent)
		{
			UVOIPTalker.__BPOnTalkingBegin_Internal(base.NativePtr, (AudioComponent != null) ? AudioComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06011280 RID: 70272 RVA: 0x00192FCB File Offset: 0x001911CB
		[NullableContext(2)]
		protected virtual void BPOnTalkingBegin_Implementation(UAudioComponent AudioComponent)
		{
			UVOIPTalker.__BPOnTalkingBegin_Implementation_Internal(base.NativePtr, (AudioComponent != null) ? AudioComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06011281 RID: 70273
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterWithPlayerState_Internal(IntPtr @this, IntPtr OwningState);

		// Token: 0x06011282 RID: 70274
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetVoiceLevel_Internal(IntPtr @this);

		// Token: 0x06011283 RID: 70275
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateTalkerForPlayer_Internal(IntPtr OwningState);

		// Token: 0x06011284 RID: 70276
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BPOnTalkingEnd_Internal(IntPtr @this);

		// Token: 0x06011285 RID: 70277
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BPOnTalkingEnd_Implementation_Internal(IntPtr @this);

		// Token: 0x06011286 RID: 70278
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BPOnTalkingBegin_Internal(IntPtr @this, IntPtr AudioComponent);

		// Token: 0x06011287 RID: 70279
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BPOnTalkingBegin_Implementation_Internal(IntPtr @this, IntPtr AudioComponent);

		// Token: 0x06011288 RID: 70280 RVA: 0x00192FE8 File Offset: 0x001911E8
		static UVOIPTalker()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.VOIPTalker");
		}

		// Token: 0x06011289 RID: 70281 RVA: 0x00192FF6 File Offset: 0x001911F6
		protected UVOIPTalker(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040092E0 RID: 37600
		public new const string __ObjectPath = "/Script/Engine.VOIPTalker";

		// Token: 0x040092E1 RID: 37601
		private static IntPtr _ClassPtr;

		// Token: 0x040092E2 RID: 37602
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040092E3 RID: 37603
		internal static int __PropertyOffset_Settings;

		// Token: 0x040092E4 RID: 37604
		[Nullable(2)]
		private FVoiceSettings _Settings;

		// Token: 0x02002E0C RID: 11788
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __BPOnTalkingBegin_FunctionParams
		{
			// Token: 0x0401688C RID: 92300
			[FieldOffset(0)]
			public IntPtr AudioComponent;
		}
	}
}
