using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000218 RID: 536
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.GameViewportClient")]
	[UnrealStructLayout(968, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 968)]
	public class UGameViewportClient : UScriptViewportClient, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600243B RID: 9275 RVA: 0x000344FB File Offset: 0x000326FB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameViewportClient._ClassPtr;
		}

		// Token: 0x0600243C RID: 9276 RVA: 0x00034508 File Offset: 0x00032708
		public UGameViewportClient() : this(BuiltinUtils.AllocNativeUObject(UGameViewportClient.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600243D RID: 9277 RVA: 0x00034530 File Offset: 0x00032730
		[NullableContext(1)]
		public UGameViewportClient(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGameViewportClient.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x0600243E RID: 9278 RVA: 0x00034563 File Offset: 0x00032763
		// (set) Token: 0x0600243F RID: 9279 RVA: 0x00034573 File Offset: 0x00032773
		public unsafe int MaxSplitscreenPlayers
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameViewportClient.__PropertyOffset_MaxSplitscreenPlayers);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameViewportClient.__PropertyOffset_MaxSplitscreenPlayers) = value;
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06002440 RID: 9280 RVA: 0x00034584 File Offset: 0x00032784
		// (set) Token: 0x06002441 RID: 9281 RVA: 0x00034598 File Offset: 0x00032798
		public unsafe UWorld World
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UWorld>(base.NativePtr / (IntPtr)sizeof(void*) + UGameViewportClient.__PropertyOffset_World);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UGameViewportClient.__PropertyOffset_World, value);
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06002442 RID: 9282 RVA: 0x000345AD File Offset: 0x000327AD
		// (set) Token: 0x06002443 RID: 9283 RVA: 0x000345C1 File Offset: 0x000327C1
		public unsafe UGameInstance GameInstance
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGameInstance>(base.NativePtr / (IntPtr)sizeof(void*) + UGameViewportClient.__PropertyOffset_GameInstance);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UGameViewportClient.__PropertyOffset_GameInstance, value);
			}
		}

		// Token: 0x06002444 RID: 9284 RVA: 0x000345D6 File Offset: 0x000327D6
		public void SSSwapControllers()
		{
			UGameViewportClient.__SSSwapControllers_Internal(base.NativePtr);
		}

		// Token: 0x06002445 RID: 9285 RVA: 0x000345E3 File Offset: 0x000327E3
		public void ShowTitleSafeArea()
		{
			UGameViewportClient.__ShowTitleSafeArea_Internal(base.NativePtr);
		}

		// Token: 0x06002446 RID: 9286 RVA: 0x000345F0 File Offset: 0x000327F0
		public void SetConsoleTarget(int PlayerIndex)
		{
			UGameViewportClient.__SetConsoleTarget_Internal(base.NativePtr, PlayerIndex);
		}

		// Token: 0x06002447 RID: 9287
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SSSwapControllers_Internal(IntPtr @this);

		// Token: 0x06002448 RID: 9288
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ShowTitleSafeArea_Internal(IntPtr @this);

		// Token: 0x06002449 RID: 9289
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetConsoleTarget_Internal(IntPtr @this, int PlayerIndex);

		// Token: 0x0600244A RID: 9290 RVA: 0x000345FE File Offset: 0x000327FE
		static UGameViewportClient()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.GameViewportClient");
		}

		// Token: 0x0600244B RID: 9291 RVA: 0x0003460C File Offset: 0x0003280C
		protected UGameViewportClient(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000D96 RID: 3478
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.GameViewportClient";

		// Token: 0x04000D97 RID: 3479
		private static IntPtr _ClassPtr;

		// Token: 0x04000D98 RID: 3480
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000D99 RID: 3481
		internal static int __PropertyOffset_MaxSplitscreenPlayers;

		// Token: 0x04000D9A RID: 3482
		internal static int __PropertyOffset_World;

		// Token: 0x04000D9B RID: 3483
		internal static int __PropertyOffset_GameInstance;
	}
}
