using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017EE RID: 6126
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroCrowdAi.KuroCrowdAiBoidInstanceSequenceProxyRouter")]
	[UnrealStructLayout(1288, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1288)]
	public class AKuroCrowdAiBoidInstanceSequenceProxyRouter : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016A32 RID: 92722 RVA: 0x0021058C File Offset: 0x0020E78C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroCrowdAiBoidInstanceSequenceProxyRouter._ClassPtr;
		}

		// Token: 0x06016A33 RID: 92723 RVA: 0x00210598 File Offset: 0x0020E798
		public AKuroCrowdAiBoidInstanceSequenceProxyRouter() : this(BuiltinUtils.AllocNativeUObject(AKuroCrowdAiBoidInstanceSequenceProxyRouter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016A34 RID: 92724 RVA: 0x002105C0 File Offset: 0x0020E7C0
		public AKuroCrowdAiBoidInstanceSequenceProxyRouter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroCrowdAiBoidInstanceSequenceProxyRouter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005B89 RID: 23433
		// (get) Token: 0x06016A35 RID: 92725 RVA: 0x002105F4 File Offset: 0x0020E7F4
		// (set) Token: 0x06016A36 RID: 92726 RVA: 0x0021062D File Offset: 0x0020E82D
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

		// Token: 0x17005B8A RID: 23434
		// (get) Token: 0x06016A37 RID: 92727 RVA: 0x0021063C File Offset: 0x0020E83C
		// (set) Token: 0x06016A38 RID: 92728 RVA: 0x00210675 File Offset: 0x0020E875
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

		// Token: 0x17005B8B RID: 23435
		// (get) Token: 0x06016A39 RID: 92729 RVA: 0x00210683 File Offset: 0x0020E883
		// (set) Token: 0x06016A3A RID: 92730 RVA: 0x00210697 File Offset: 0x0020E897
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

		// Token: 0x17005B8C RID: 23436
		// (get) Token: 0x06016A3B RID: 92731 RVA: 0x002106AC File Offset: 0x0020E8AC
		// (set) Token: 0x06016A3C RID: 92732 RVA: 0x002106E5 File Offset: 0x0020E8E5
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

		// Token: 0x06016A3D RID: 92733 RVA: 0x002106F3 File Offset: 0x0020E8F3
		[NullableContext(2)]
		public bool RemoveRouteByProxyActor(AKuroCrowdAiBoidInstanceSequenceProxy ProxyActor)
		{
			return AKuroCrowdAiBoidInstanceSequenceProxyRouter.__RemoveRouteByProxyActor_Internal(base.NativePtr, (ProxyActor != null) ? ProxyActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06016A3E RID: 92734 RVA: 0x00210710 File Offset: 0x0020E910
		public bool RemoveRouteByBoidId(int BoidId)
		{
			return AKuroCrowdAiBoidInstanceSequenceProxyRouter.__RemoveRouteByBoidId_Internal(base.NativePtr, BoidId);
		}

		// Token: 0x06016A3F RID: 92735 RVA: 0x0021071E File Offset: 0x0020E91E
		[NullableContext(2)]
		public int GetRouteTarget(AKuroCrowdAiBoidInstanceSequenceProxy ProxyActor)
		{
			return AKuroCrowdAiBoidInstanceSequenceProxyRouter.__GetRouteTarget_Internal(base.NativePtr, (ProxyActor != null) ? ProxyActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06016A40 RID: 92736 RVA: 0x0021073B File Offset: 0x0020E93B
		[NullableContext(2)]
		public AKuroCrowdAiBoidInstanceSequenceProxy GetRouteSource(int BoidId)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AKuroCrowdAiBoidInstanceSequenceProxy>(AKuroCrowdAiBoidInstanceSequenceProxyRouter.__GetRouteSource_Internal(base.NativePtr, BoidId));
		}

		// Token: 0x06016A41 RID: 92737 RVA: 0x0021074E File Offset: 0x0020E94E
		public void ClearRoute()
		{
			AKuroCrowdAiBoidInstanceSequenceProxyRouter.__ClearRoute_Internal(base.NativePtr);
		}

		// Token: 0x06016A42 RID: 92738 RVA: 0x0021075B File Offset: 0x0020E95B
		[NullableContext(2)]
		public bool AddRoute(AKuroCrowdAiBoidInstanceSequenceProxy ProxyActor, int InstanceId)
		{
			return AKuroCrowdAiBoidInstanceSequenceProxyRouter.__AddRoute_Internal(base.NativePtr, (ProxyActor != null) ? ProxyActor.NativePtr : IntPtr.Zero, InstanceId);
		}

		// Token: 0x06016A43 RID: 92739
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveRouteByProxyActor_Internal(IntPtr @this, IntPtr ProxyActor);

		// Token: 0x06016A44 RID: 92740
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveRouteByBoidId_Internal(IntPtr @this, int BoidId);

		// Token: 0x06016A45 RID: 92741
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetRouteTarget_Internal(IntPtr @this, IntPtr ProxyActor);

		// Token: 0x06016A46 RID: 92742
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRouteSource_Internal(IntPtr @this, int BoidId);

		// Token: 0x06016A47 RID: 92743
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearRoute_Internal(IntPtr @this);

		// Token: 0x06016A48 RID: 92744
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __AddRoute_Internal(IntPtr @this, IntPtr ProxyActor, int InstanceId);

		// Token: 0x06016A49 RID: 92745 RVA: 0x00210779 File Offset: 0x0020E979
		static AKuroCrowdAiBoidInstanceSequenceProxyRouter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroCrowdAi.KuroCrowdAiBoidInstanceSequenceProxyRouter");
		}

		// Token: 0x06016A4A RID: 92746 RVA: 0x00210787 File Offset: 0x0020E987
		protected AKuroCrowdAiBoidInstanceSequenceProxyRouter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C4AC RID: 50348
		public new const string __ObjectPath = "/Script/KuroCrowdAi.KuroCrowdAiBoidInstanceSequenceProxyRouter";

		// Token: 0x0400C4AD RID: 50349
		private static IntPtr _ClassPtr;

		// Token: 0x0400C4AE RID: 50350
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C4AF RID: 50351
		internal static int __PropertyOffset_ProxyActorToBoidId;

		// Token: 0x0400C4B0 RID: 50352
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<AKuroCrowdAiBoidInstanceSequenceProxy, int> _ProxyActorToBoidId;

		// Token: 0x0400C4B1 RID: 50353
		internal static int __PropertyOffset_BoidIdToProxyActor;

		// Token: 0x0400C4B2 RID: 50354
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, AKuroCrowdAiBoidInstanceSequenceProxy> _BoidIdToProxyActor;

		// Token: 0x0400C4B3 RID: 50355
		internal static int __PropertyOffset_CrowdAiSubsystem;

		// Token: 0x0400C4B4 RID: 50356
		internal static int __PropertyOffset_ProxyActorsBusyRouting;

		// Token: 0x0400C4B5 RID: 50357
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<AKuroCrowdAiBoidInstanceSequenceProxy> _ProxyActorsBusyRouting;
	}
}
