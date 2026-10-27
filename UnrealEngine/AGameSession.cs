using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C01 RID: 3073
	[UnrealObjectPath("/Script/Engine.GameSession")]
	[UnrealStructLayout(1080, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1080)]
	public class AGameSession : AInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060099B7 RID: 39351 RVA: 0x000DB250 File Offset: 0x000D9450
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AGameSession._ClassPtr;
		}

		// Token: 0x060099B8 RID: 39352 RVA: 0x000DB25C File Offset: 0x000D945C
		public AGameSession() : this(BuiltinUtils.AllocNativeUObject(AGameSession.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060099B9 RID: 39353 RVA: 0x000DB284 File Offset: 0x000D9484
		[NullableContext(1)]
		public AGameSession(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AGameSession.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002494 RID: 9364
		// (get) Token: 0x060099BA RID: 39354 RVA: 0x000DB2B7 File Offset: 0x000D94B7
		// (set) Token: 0x060099BB RID: 39355 RVA: 0x000DB2C7 File Offset: 0x000D94C7
		public unsafe int MaxSpectators
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameSession.__PropertyOffset_MaxSpectators);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameSession.__PropertyOffset_MaxSpectators) = value;
			}
		}

		// Token: 0x17002495 RID: 9365
		// (get) Token: 0x060099BC RID: 39356 RVA: 0x000DB2D8 File Offset: 0x000D94D8
		// (set) Token: 0x060099BD RID: 39357 RVA: 0x000DB2E8 File Offset: 0x000D94E8
		public unsafe int MaxPlayers
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameSession.__PropertyOffset_MaxPlayers);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameSession.__PropertyOffset_MaxPlayers) = value;
			}
		}

		// Token: 0x17002496 RID: 9366
		// (get) Token: 0x060099BE RID: 39358 RVA: 0x000DB2F9 File Offset: 0x000D94F9
		// (set) Token: 0x060099BF RID: 39359 RVA: 0x000DB309 File Offset: 0x000D9509
		public unsafe int MaxPartySize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameSession.__PropertyOffset_MaxPartySize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameSession.__PropertyOffset_MaxPartySize) = value;
			}
		}

		// Token: 0x17002497 RID: 9367
		// (get) Token: 0x060099C0 RID: 39360 RVA: 0x000DB31A File Offset: 0x000D951A
		// (set) Token: 0x060099C1 RID: 39361 RVA: 0x000DB32A File Offset: 0x000D952A
		public unsafe byte MaxSplitscreensPerConnection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameSession.__PropertyOffset_MaxSplitscreensPerConnection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameSession.__PropertyOffset_MaxSplitscreensPerConnection) = value;
			}
		}

		// Token: 0x17002498 RID: 9368
		// (get) Token: 0x060099C2 RID: 39362 RVA: 0x000DB33B File Offset: 0x000D953B
		// (set) Token: 0x060099C3 RID: 39363 RVA: 0x000DB34B File Offset: 0x000D954B
		public unsafe bool bRequiresPushToTalk
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameSession.__PropertyOffset_bRequiresPushToTalk) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameSession.__PropertyOffset_bRequiresPushToTalk) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002499 RID: 9369
		// (get) Token: 0x060099C4 RID: 39364 RVA: 0x000DB35C File Offset: 0x000D955C
		// (set) Token: 0x060099C5 RID: 39365 RVA: 0x000DB370 File Offset: 0x000D9570
		public unsafe FName SessionName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameSession.__PropertyOffset_SessionName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameSession.__PropertyOffset_SessionName) = value;
			}
		}

		// Token: 0x060099C6 RID: 39366 RVA: 0x000DB385 File Offset: 0x000D9585
		static AGameSession()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.GameSession");
		}

		// Token: 0x060099C7 RID: 39367 RVA: 0x000DB393 File Offset: 0x000D9593
		protected AGameSession(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005538 RID: 21816
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.GameSession";

		// Token: 0x04005539 RID: 21817
		private static IntPtr _ClassPtr;

		// Token: 0x0400553A RID: 21818
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400553B RID: 21819
		internal static int __PropertyOffset_MaxSpectators;

		// Token: 0x0400553C RID: 21820
		internal static int __PropertyOffset_MaxPlayers;

		// Token: 0x0400553D RID: 21821
		internal static int __PropertyOffset_MaxPartySize;

		// Token: 0x0400553E RID: 21822
		internal static int __PropertyOffset_MaxSplitscreensPerConnection;

		// Token: 0x0400553F RID: 21823
		internal static int __PropertyOffset_bRequiresPushToTalk;

		// Token: 0x04005540 RID: 21824
		internal static int __PropertyOffset_SessionName;
	}
}
