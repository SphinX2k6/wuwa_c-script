using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001CF RID: 463
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.NavLinkProxy")]
	[UnrealStructLayout(1136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1136)]
	public class ANavLinkProxy : AActor, IUnrealUObject, IUnrealObject, INavLinkHostInterface, IUnrealNativeInterface, IUnrealInterface, INavRelevantInterface
	{
		// Token: 0x06001B46 RID: 6982 RVA: 0x00028B92 File Offset: 0x00026D92
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ANavLinkProxy._ClassPtr;
		}

		// Token: 0x06001B47 RID: 6983 RVA: 0x00028B9E File Offset: 0x00026D9E
		int INavLinkHostInterface.InterfaceOffset()
		{
			return ANavLinkProxy.__InterfaceOffset_INavLinkHostInterface;
		}

		// Token: 0x06001B48 RID: 6984 RVA: 0x00028BA5 File Offset: 0x00026DA5
		int INavRelevantInterface.InterfaceOffset()
		{
			return ANavLinkProxy.__InterfaceOffset_INavRelevantInterface;
		}

		// Token: 0x06001B49 RID: 6985 RVA: 0x00028BAC File Offset: 0x00026DAC
		public ANavLinkProxy() : this(BuiltinUtils.AllocNativeUObject(ANavLinkProxy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001B4A RID: 6986 RVA: 0x00028BD4 File Offset: 0x00026DD4
		public ANavLinkProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ANavLinkProxy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06001B4B RID: 6987 RVA: 0x00028C08 File Offset: 0x00026E08
		// (set) Token: 0x06001B4C RID: 6988 RVA: 0x00028C41 File Offset: 0x00026E41
		public TArray<FNavigationLink> PointLinks
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNavigationLink> result;
				if ((result = this._PointLinks) == null)
				{
					result = (this._PointLinks = new TArray<FNavigationLink>(base.NativePtr + (IntPtr)ANavLinkProxy.__PropertyOffset_PointLinks, this));
				}
				return result;
			}
			set
			{
				this.PointLinks.CopyAssign(value);
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06001B4D RID: 6989 RVA: 0x00028C50 File Offset: 0x00026E50
		// (set) Token: 0x06001B4E RID: 6990 RVA: 0x00028C89 File Offset: 0x00026E89
		public TArray<FNavigationSegmentLink> SegmentLinks
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNavigationSegmentLink> result;
				if ((result = this._SegmentLinks) == null)
				{
					result = (this._SegmentLinks = new TArray<FNavigationSegmentLink>(base.NativePtr + (IntPtr)ANavLinkProxy.__PropertyOffset_SegmentLinks, this));
				}
				return result;
			}
			set
			{
				this.SegmentLinks.CopyAssign(value);
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06001B4F RID: 6991 RVA: 0x00028C97 File Offset: 0x00026E97
		// (set) Token: 0x06001B50 RID: 6992 RVA: 0x00028CAB File Offset: 0x00026EAB
		[Nullable(2)]
		public unsafe UNavLinkCustomComponent SmartLinkComp
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNavLinkCustomComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ANavLinkProxy.__PropertyOffset_SmartLinkComp);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ANavLinkProxy.__PropertyOffset_SmartLinkComp, value);
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06001B51 RID: 6993 RVA: 0x00028CC0 File Offset: 0x00026EC0
		// (set) Token: 0x06001B52 RID: 6994 RVA: 0x00028CD0 File Offset: 0x00026ED0
		public unsafe bool bSmartLinkIsRelevant
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ANavLinkProxy.__PropertyOffset_bSmartLinkIsRelevant) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ANavLinkProxy.__PropertyOffset_bSmartLinkIsRelevant) = (value ? 1 : 0);
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06001B53 RID: 6995 RVA: 0x00028CE4 File Offset: 0x00026EE4
		// (set) Token: 0x06001B54 RID: 6996 RVA: 0x00028D1D File Offset: 0x00026F1D
		public FSmartLinkReachedSignature OnSmartLinkReached
		{
			get
			{
				base.FastCheckIsValid();
				FSmartLinkReachedSignature result;
				if ((result = this._OnSmartLinkReached) == null)
				{
					result = (this._OnSmartLinkReached = new FSmartLinkReachedSignature(base.NativePtr + (IntPtr)ANavLinkProxy.__PropertyOffset_OnSmartLinkReached, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)ANavLinkProxy.__PropertyOffset_OnSmartLinkReached, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x00028D3E File Offset: 0x00026F3E
		public void SetSmartLinkEnabled(bool bEnabled)
		{
			ANavLinkProxy.__SetSmartLinkEnabled_Internal(base.NativePtr, bEnabled);
		}

		// Token: 0x06001B56 RID: 6998 RVA: 0x00028D4C File Offset: 0x00026F4C
		[NullableContext(2)]
		public void ResumePathFollowing(AActor Agent)
		{
			ANavLinkProxy.__ResumePathFollowing_Internal(base.NativePtr, (Agent != null) ? Agent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001B57 RID: 6999 RVA: 0x00028D69 File Offset: 0x00026F69
		[NullableContext(2)]
		public virtual void ReceiveSmartLinkReached(AActor Agent, in FVector Destination)
		{
			ANavLinkProxy.__ReceiveSmartLinkReached_Internal(base.NativePtr, (Agent != null) ? Agent.NativePtr : IntPtr.Zero, Destination);
		}

		// Token: 0x06001B58 RID: 7000 RVA: 0x00028D87 File Offset: 0x00026F87
		public bool IsSmartLinkEnabled()
		{
			return ANavLinkProxy.__IsSmartLinkEnabled_Internal(base.NativePtr);
		}

		// Token: 0x06001B59 RID: 7001 RVA: 0x00028D94 File Offset: 0x00026F94
		public bool HasMovingAgents()
		{
			return ANavLinkProxy.__HasMovingAgents_Internal(base.NativePtr);
		}

		// Token: 0x06001B5A RID: 7002
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSmartLinkEnabled_Internal(IntPtr @this, bool bEnabled);

		// Token: 0x06001B5B RID: 7003
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResumePathFollowing_Internal(IntPtr @this, IntPtr Agent);

		// Token: 0x06001B5C RID: 7004
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveSmartLinkReached_Internal(IntPtr @this, IntPtr Agent, in FVector Destination);

		// Token: 0x06001B5D RID: 7005
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsSmartLinkEnabled_Internal(IntPtr @this);

		// Token: 0x06001B5E RID: 7006
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasMovingAgents_Internal(IntPtr @this);

		// Token: 0x06001B5F RID: 7007 RVA: 0x00028DA1 File Offset: 0x00026FA1
		static ANavLinkProxy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.NavLinkProxy");
		}

		// Token: 0x06001B60 RID: 7008 RVA: 0x00028DAF File Offset: 0x00026FAF
		protected ANavLinkProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040008BB RID: 2235
		internal static int __InterfaceOffset_INavLinkHostInterface;

		// Token: 0x040008BC RID: 2236
		internal static int __InterfaceOffset_INavRelevantInterface;

		// Token: 0x040008BD RID: 2237
		public new const string __ObjectPath = "/Script/AIModule.NavLinkProxy";

		// Token: 0x040008BE RID: 2238
		private static IntPtr _ClassPtr;

		// Token: 0x040008BF RID: 2239
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040008C0 RID: 2240
		internal static int __PropertyOffset_PointLinks;

		// Token: 0x040008C1 RID: 2241
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNavigationLink> _PointLinks;

		// Token: 0x040008C2 RID: 2242
		internal static int __PropertyOffset_SegmentLinks;

		// Token: 0x040008C3 RID: 2243
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNavigationSegmentLink> _SegmentLinks;

		// Token: 0x040008C4 RID: 2244
		internal static int __PropertyOffset_SmartLinkComp;

		// Token: 0x040008C5 RID: 2245
		internal static int __PropertyOffset_bSmartLinkIsRelevant;

		// Token: 0x040008C6 RID: 2246
		internal static int __PropertyOffset_OnSmartLinkReached;

		// Token: 0x040008C7 RID: 2247
		[Nullable(2)]
		private FSmartLinkReachedSignature _OnSmartLinkReached;

		// Token: 0x02002B6E RID: 11118
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __ReceiveSmartLinkReached_FunctionParams
		{
			// Token: 0x040163F6 RID: 91126
			[FieldOffset(0)]
			public IntPtr Agent;

			// Token: 0x040163F7 RID: 91127
			[FieldOffset(8)]
			public FVector Destination;
		}
	}
}
