using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D62 RID: 3426
	[UnrealObjectPath("/Script/Engine.LocalPlayer")]
	[UnrealStructLayout(616, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 616)]
	public class ULocalPlayer : UPlayer, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B91C RID: 47388 RVA: 0x00107661 File Offset: 0x00105861
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULocalPlayer._ClassPtr;
		}

		// Token: 0x0600B91D RID: 47389 RVA: 0x00107670 File Offset: 0x00105870
		public ULocalPlayer() : this(BuiltinUtils.AllocNativeUObject(ULocalPlayer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B91E RID: 47390 RVA: 0x00107698 File Offset: 0x00105898
		[NullableContext(1)]
		public ULocalPlayer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULocalPlayer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002A68 RID: 10856
		// (get) Token: 0x0600B91F RID: 47391 RVA: 0x001076CB File Offset: 0x001058CB
		// (set) Token: 0x0600B920 RID: 47392 RVA: 0x001076DF File Offset: 0x001058DF
		[Nullable(2)]
		public unsafe UGameViewportClient ViewportClient
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGameViewportClient>(base.NativePtr / (IntPtr)sizeof(void*) + ULocalPlayer.__PropertyOffset_ViewportClient);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULocalPlayer.__PropertyOffset_ViewportClient, value);
			}
		}

		// Token: 0x17002A69 RID: 10857
		// (get) Token: 0x0600B921 RID: 47393 RVA: 0x001076F4 File Offset: 0x001058F4
		// (set) Token: 0x0600B922 RID: 47394 RVA: 0x00107708 File Offset: 0x00105908
		public unsafe TEnumAsByte<EAspectRatioAxisConstraint> AspectRatioAxisConstraint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULocalPlayer.__PropertyOffset_AspectRatioAxisConstraint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULocalPlayer.__PropertyOffset_AspectRatioAxisConstraint) = value;
			}
		}

		// Token: 0x17002A6A RID: 10858
		// (get) Token: 0x0600B923 RID: 47395 RVA: 0x0010771D File Offset: 0x0010591D
		// (set) Token: 0x0600B924 RID: 47396 RVA: 0x00107731 File Offset: 0x00105931
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<APlayerController> PendingLevelPlayerControllerClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)ULocalPlayer.__PropertyOffset_PendingLevelPlayerControllerClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)ULocalPlayer.__PropertyOffset_PendingLevelPlayerControllerClass) = value;
			}
		}

		// Token: 0x17002A6B RID: 10859
		// (get) Token: 0x0600B925 RID: 47397 RVA: 0x00107746 File Offset: 0x00105946
		// (set) Token: 0x0600B926 RID: 47398 RVA: 0x0010775F File Offset: 0x0010595F
		public unsafe bool bSentSplitJoin
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULocalPlayer.__PropertyOffset_bSentSplitJoin) & ULocalPlayer.__PropertyMask_bSentSplitJoin) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULocalPlayer.__PropertyOffset_bSentSplitJoin) = ((*(base.NativePtr + (IntPtr)ULocalPlayer.__PropertyOffset_bSentSplitJoin) & ~ULocalPlayer.__PropertyMask_bSentSplitJoin) | (value ? ULocalPlayer.__PropertyMask_bSentSplitJoin : 0));
			}
		}

		// Token: 0x17002A6C RID: 10860
		// (get) Token: 0x0600B927 RID: 47399 RVA: 0x0010778F File Offset: 0x0010598F
		// (set) Token: 0x0600B928 RID: 47400 RVA: 0x0010779F File Offset: 0x0010599F
		public unsafe int ControllerId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULocalPlayer.__PropertyOffset_ControllerId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULocalPlayer.__PropertyOffset_ControllerId) = value;
			}
		}

		// Token: 0x0600B929 RID: 47401 RVA: 0x001077B0 File Offset: 0x001059B0
		static ULocalPlayer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LocalPlayer");
		}

		// Token: 0x0600B92A RID: 47402 RVA: 0x001077BE File Offset: 0x001059BE
		protected ULocalPlayer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040060FC RID: 24828
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.LocalPlayer";

		// Token: 0x040060FD RID: 24829
		private static IntPtr _ClassPtr;

		// Token: 0x040060FE RID: 24830
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040060FF RID: 24831
		internal static int __PropertyOffset_ViewportClient;

		// Token: 0x04006100 RID: 24832
		internal static int __PropertyOffset_AspectRatioAxisConstraint;

		// Token: 0x04006101 RID: 24833
		internal static int __PropertyOffset_PendingLevelPlayerControllerClass;

		// Token: 0x04006102 RID: 24834
		internal static int __PropertyOffset_bSentSplitJoin;

		// Token: 0x04006103 RID: 24835
		internal static byte __PropertyMask_bSentSplitJoin;

		// Token: 0x04006104 RID: 24836
		internal static int __PropertyOffset_ControllerId;
	}
}
