using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C05 RID: 3077
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.GameViewportClient")]
	[UnrealStructLayout(968, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 968)]
	public class UGameViewportClient : UScriptViewportClient, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009AD6 RID: 39638 RVA: 0x000DC067 File Offset: 0x000DA267
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameViewportClient._ClassPtr;
		}

		// Token: 0x06009AD7 RID: 39639 RVA: 0x000DC074 File Offset: 0x000DA274
		public UGameViewportClient() : this(BuiltinUtils.AllocNativeUObject(UGameViewportClient.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009AD8 RID: 39640 RVA: 0x000DC09C File Offset: 0x000DA29C
		[NullableContext(1)]
		public UGameViewportClient(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGameViewportClient.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170024C5 RID: 9413
		// (get) Token: 0x06009AD9 RID: 39641 RVA: 0x000DC0CF File Offset: 0x000DA2CF
		// (set) Token: 0x06009ADA RID: 39642 RVA: 0x000DC0E3 File Offset: 0x000DA2E3
		public unsafe UConsole ViewportConsole
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UConsole>(base.NativePtr / (IntPtr)sizeof(void*) + UGameViewportClient.__PropertyOffset_ViewportConsole);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UGameViewportClient.__PropertyOffset_ViewportConsole, value);
			}
		}

		// Token: 0x170024C6 RID: 9414
		// (get) Token: 0x06009ADB RID: 39643 RVA: 0x000DC0F8 File Offset: 0x000DA2F8
		// (set) Token: 0x06009ADC RID: 39644 RVA: 0x000DC131 File Offset: 0x000DA331
		[Nullable(1)]
		public TArray<FDebugDisplayProperty> DebugProperties
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FDebugDisplayProperty> result;
				if ((result = this._DebugProperties) == null)
				{
					result = (this._DebugProperties = new TArray<FDebugDisplayProperty>(base.NativePtr + (IntPtr)UGameViewportClient.__PropertyOffset_DebugProperties, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.DebugProperties.CopyAssign(value);
			}
		}

		// Token: 0x170024C7 RID: 9415
		// (get) Token: 0x06009ADD RID: 39645 RVA: 0x000DC13F File Offset: 0x000DA33F
		// (set) Token: 0x06009ADE RID: 39646 RVA: 0x000DC14F File Offset: 0x000DA34F
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

		// Token: 0x170024C8 RID: 9416
		// (get) Token: 0x06009ADF RID: 39647 RVA: 0x000DC160 File Offset: 0x000DA360
		// (set) Token: 0x06009AE0 RID: 39648 RVA: 0x000DC174 File Offset: 0x000DA374
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

		// Token: 0x170024C9 RID: 9417
		// (get) Token: 0x06009AE1 RID: 39649 RVA: 0x000DC189 File Offset: 0x000DA389
		// (set) Token: 0x06009AE2 RID: 39650 RVA: 0x000DC19D File Offset: 0x000DA39D
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

		// Token: 0x06009AE3 RID: 39651 RVA: 0x000DC1B2 File Offset: 0x000DA3B2
		public void SSSwapControllers()
		{
			UGameViewportClient.__SSSwapControllers_Internal(base.NativePtr);
		}

		// Token: 0x06009AE4 RID: 39652 RVA: 0x000DC1BF File Offset: 0x000DA3BF
		public void ShowTitleSafeArea()
		{
			UGameViewportClient.__ShowTitleSafeArea_Internal(base.NativePtr);
		}

		// Token: 0x06009AE5 RID: 39653 RVA: 0x000DC1CC File Offset: 0x000DA3CC
		public void SetConsoleTarget(int PlayerIndex)
		{
			UGameViewportClient.__SetConsoleTarget_Internal(base.NativePtr, PlayerIndex);
		}

		// Token: 0x06009AE6 RID: 39654
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SSSwapControllers_Internal(IntPtr @this);

		// Token: 0x06009AE7 RID: 39655
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ShowTitleSafeArea_Internal(IntPtr @this);

		// Token: 0x06009AE8 RID: 39656
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetConsoleTarget_Internal(IntPtr @this, int PlayerIndex);

		// Token: 0x06009AE9 RID: 39657 RVA: 0x000DC1DA File Offset: 0x000DA3DA
		static UGameViewportClient()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.GameViewportClient");
		}

		// Token: 0x06009AEA RID: 39658 RVA: 0x000DC1E8 File Offset: 0x000DA3E8
		protected UGameViewportClient(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005579 RID: 21881
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.GameViewportClient";

		// Token: 0x0400557A RID: 21882
		private static IntPtr _ClassPtr;

		// Token: 0x0400557B RID: 21883
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400557C RID: 21884
		internal static int __PropertyOffset_ViewportConsole;

		// Token: 0x0400557D RID: 21885
		internal static int __PropertyOffset_DebugProperties;

		// Token: 0x0400557E RID: 21886
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FDebugDisplayProperty> _DebugProperties;

		// Token: 0x0400557F RID: 21887
		internal static int __PropertyOffset_MaxSplitscreenPlayers;

		// Token: 0x04005580 RID: 21888
		internal static int __PropertyOffset_World;

		// Token: 0x04005581 RID: 21889
		internal static int __PropertyOffset_GameInstance;
	}
}
