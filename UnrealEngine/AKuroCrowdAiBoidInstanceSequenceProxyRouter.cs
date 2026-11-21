using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200035B RID: 859
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroCrowdAi.KuroCrowdAiBoidInstanceSequenceProxyRouter")]
	[UnrealStructLayout(1288, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1288)]
	public class AKuroCrowdAiBoidInstanceSequenceProxyRouter : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060057DA RID: 22490 RVA: 0x0007B98C File Offset: 0x00079B8C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroCrowdAiBoidInstanceSequenceProxyRouter._ClassPtr;
		}

		// Token: 0x060057DB RID: 22491 RVA: 0x0007B998 File Offset: 0x00079B98
		public AKuroCrowdAiBoidInstanceSequenceProxyRouter() : this(BuiltinUtils.AllocNativeUObject(AKuroCrowdAiBoidInstanceSequenceProxyRouter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060057DC RID: 22492 RVA: 0x0007B9C0 File Offset: 0x00079BC0
		public AKuroCrowdAiBoidInstanceSequenceProxyRouter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroCrowdAiBoidInstanceSequenceProxyRouter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001161 RID: 4449
		// (get) Token: 0x060057DD RID: 22493 RVA: 0x0007B9F4 File Offset: 0x00079BF4
		// (set) Token: 0x060057DE RID: 22494 RVA: 0x0007BA2D File Offset: 0x00079C2D
		public TMap<AKuroCrowdAiBoidInstanceSequenceProxy, int> ProxyActorToBoidId
		{
			get
			{
				base.FastCheckIsValid();
				TMap<AKuroCrowdAiBoidInstanceSequenceProxy, int> result;
				if ((result = this._ProxyActorToBoidId) == null)
				{
					result = (this._ProxyActorToBoidId = new TMap<AKuroCrowdAiBoidInstanceSequenceProxy, int>(base.NativePtr + (IntPtr)AKuroCrowdAiBoidInstanceSequenceProxyRouter.__PropertyOffset_ProxyActorToBoidId, this));
				}
				return result;
			}
			set
			{
				this.ProxyActorToBoidId.CopyAssign(value);
			}
		}

		// Token: 0x17001162 RID: 4450
		// (get) Token: 0x060057DF RID: 22495 RVA: 0x0007BA3C File Offset: 0x00079C3C
		// (set) Token: 0x060057E0 RID: 22496 RVA: 0x0007BA75 File Offset: 0x00079C75
		public TMap<int, AKuroCrowdAiBoidInstanceSequenceProxy> BoidIdToProxyActor
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, AKuroCrowdAiBoidInstanceSequenceProxy> result;
				if ((result = this._BoidIdToProxyActor) == null)
				{
					result = (this._BoidIdToProxyActor = new TMap<int, AKuroCrowdAiBoidInstanceSequenceProxy>(base.NativePtr + (IntPtr)AKuroCrowdAiBoidInstanceSequenceProxyRouter.__PropertyOffset_BoidIdToProxyActor, this));
				}
				return result;
			}
			set
			{
				this.BoidIdToProxyActor.CopyAssign(value);
			}
		}

		// Token: 0x17001163 RID: 4451
		// (get) Token: 0x060057E1 RID: 22497 RVA: 0x0007BA83 File Offset: 0x00079C83
		// (set) Token: 0x060057E2 RID: 22498 RVA: 0x0007BA97 File Offset: 0x00079C97
		[Nullable(2)]
		public unsafe UKuroCrowdAiSubsystem CrowdAiSubsystem
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroCrowdAiSubsystem>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCrowdAiBoidInstanceSequenceProxyRouter.__PropertyOffset_CrowdAiSubsystem);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCrowdAiBoidInstanceSequenceProxyRouter.__PropertyOffset_CrowdAiSubsystem, value);
			}
		}

		// Token: 0x17001164 RID: 4452
		// (get) Token: 0x060057E3 RID: 22499 RVA: 0x0007BAAC File Offset: 0x00079CAC
		// (set) Token: 0x060057E4 RID: 22500 RVA: 0x0007BAE5 File Offset: 0x00079CE5
		public TSet<AKuroCrowdAiBoidInstanceSequenceProxy> ProxyActorsBusyRouting
		{
			get
			{
				base.FastCheckIsValid();
				TSet<AKuroCrowdAiBoidInstanceSequenceProxy> result;
				if ((result = this._ProxyActorsBusyRouting) == null)
				{
					result = (this._ProxyActorsBusyRouting = new TSet<AKuroCrowdAiBoidInstanceSequenceProxy>(base.NativePtr + (IntPtr)AKuroCrowdAiBoidInstanceSequenceProxyRouter.__PropertyOffset_ProxyActorsBusyRouting, this));
				}
				return result;
			}
			set
			{
				this.ProxyActorsBusyRouting.CopyAssign(value);
			}
		}

		// Token: 0x060057E5 RID: 22501 RVA: 0x0007BAF3 File Offset: 0x00079CF3
		[NullableContext(2)]
		public bool RemoveRouteByProxyActor(AKuroCrowdAiBoidInstanceSequenceProxy ProxyActor)
		{
			return AKuroCrowdAiBoidInstanceSequenceProxyRouter.__RemoveRouteByProxyActor_Internal(base.NativePtr, (ProxyActor != null) ? ProxyActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060057E6 RID: 22502 RVA: 0x0007BB10 File Offset: 0x00079D10
		public bool RemoveRouteByBoidId(int BoidId)
		{
			return AKuroCrowdAiBoidInstanceSequenceProxyRouter.__RemoveRouteByBoidId_Internal(base.NativePtr, BoidId);
		}

		// Token: 0x060057E7 RID: 22503 RVA: 0x0007BB1E File Offset: 0x00079D1E
		[NullableContext(2)]
		public int GetRouteTarget(AKuroCrowdAiBoidInstanceSequenceProxy ProxyActor)
		{
			return AKuroCrowdAiBoidInstanceSequenceProxyRouter.__GetRouteTarget_Internal(base.NativePtr, (ProxyActor != null) ? ProxyActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060057E8 RID: 22504 RVA: 0x0007BB3B File Offset: 0x00079D3B
		[NullableContext(2)]
		public AKuroCrowdAiBoidInstanceSequenceProxy GetRouteSource(int BoidId)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AKuroCrowdAiBoidInstanceSequenceProxy>(AKuroCrowdAiBoidInstanceSequenceProxyRouter.__GetRouteSource_Internal(base.NativePtr, BoidId));
		}

		// Token: 0x060057E9 RID: 22505 RVA: 0x0007BB4E File Offset: 0x00079D4E
		public void ClearRoute()
		{
			AKuroCrowdAiBoidInstanceSequenceProxyRouter.__ClearRoute_Internal(base.NativePtr);
		}

		// Token: 0x060057EA RID: 22506 RVA: 0x0007BB5B File Offset: 0x00079D5B
		[NullableContext(2)]
		public bool AddRoute(AKuroCrowdAiBoidInstanceSequenceProxy ProxyActor, int InstanceId)
		{
			return AKuroCrowdAiBoidInstanceSequenceProxyRouter.__AddRoute_Internal(base.NativePtr, (ProxyActor != null) ? ProxyActor.NativePtr : IntPtr.Zero, InstanceId);
		}

		// Token: 0x060057EB RID: 22507
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveRouteByProxyActor_Internal(IntPtr @this, IntPtr ProxyActor);

		// Token: 0x060057EC RID: 22508
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveRouteByBoidId_Internal(IntPtr @this, int BoidId);

		// Token: 0x060057ED RID: 22509
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetRouteTarget_Internal(IntPtr @this, IntPtr ProxyActor);

		// Token: 0x060057EE RID: 22510
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRouteSource_Internal(IntPtr @this, int BoidId);

		// Token: 0x060057EF RID: 22511
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearRoute_Internal(IntPtr @this);

		// Token: 0x060057F0 RID: 22512
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __AddRoute_Internal(IntPtr @this, IntPtr ProxyActor, int InstanceId);

		// Token: 0x060057F1 RID: 22513 RVA: 0x0007BB79 File Offset: 0x00079D79
		static AKuroCrowdAiBoidInstanceSequenceProxyRouter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroCrowdAi.KuroCrowdAiBoidInstanceSequenceProxyRouter");
		}

		// Token: 0x060057F2 RID: 22514 RVA: 0x0007BB87 File Offset: 0x00079D87
		protected AKuroCrowdAiBoidInstanceSequenceProxyRouter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002439 RID: 9273
		public new const string __ObjectPath = "/Script/KuroCrowdAi.KuroCrowdAiBoidInstanceSequenceProxyRouter";

		// Token: 0x0400243A RID: 9274
		private static IntPtr _ClassPtr;

		// Token: 0x0400243B RID: 9275
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400243C RID: 9276
		internal static int __PropertyOffset_ProxyActorToBoidId;

		// Token: 0x0400243D RID: 9277
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<AKuroCrowdAiBoidInstanceSequenceProxy, int> _ProxyActorToBoidId;

		// Token: 0x0400243E RID: 9278
		internal static int __PropertyOffset_BoidIdToProxyActor;

		// Token: 0x0400243F RID: 9279
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, AKuroCrowdAiBoidInstanceSequenceProxy> _BoidIdToProxyActor;

		// Token: 0x04002440 RID: 9280
		internal static int __PropertyOffset_CrowdAiSubsystem;

		// Token: 0x04002441 RID: 9281
		internal static int __PropertyOffset_ProxyActorsBusyRouting;

		// Token: 0x04002442 RID: 9282
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<AKuroCrowdAiBoidInstanceSequenceProxy> _ProxyActorsBusyRouting;
	}
}
