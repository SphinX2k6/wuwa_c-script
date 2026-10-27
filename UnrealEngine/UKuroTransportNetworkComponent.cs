using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001918 RID: 6424
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroTransportNetworkComponent")]
	[UnrealStructLayout(424, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 424)]
	public class UKuroTransportNetworkComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017D62 RID: 97634 RVA: 0x0022E891 File Offset: 0x0022CA91
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroTransportNetworkComponent._ClassPtr;
		}

		// Token: 0x06017D63 RID: 97635 RVA: 0x0022E8A0 File Offset: 0x0022CAA0
		public UKuroTransportNetworkComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroTransportNetworkComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017D64 RID: 97636 RVA: 0x0022E8C8 File Offset: 0x0022CAC8
		public UKuroTransportNetworkComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroTransportNetworkComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005FD1 RID: 24529
		// (get) Token: 0x06017D65 RID: 97637 RVA: 0x0022E8FC File Offset: 0x0022CAFC
		// (set) Token: 0x06017D66 RID: 97638 RVA: 0x0022E935 File Offset: 0x0022CB35
		public TArray<UAutopilotRoute> AutopilotRoute
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UAutopilotRoute> result;
				if ((result = this._AutopilotRoute) == null)
				{
					result = (this._AutopilotRoute = new TArray<UAutopilotRoute>(base.NativePtr + (IntPtr)UKuroTransportNetworkComponent.__PropertyOffset_AutopilotRoute, this));
				}
				return result;
			}
			set
			{
				this.AutopilotRoute.CopyAssign(value);
			}
		}

		// Token: 0x17005FD2 RID: 24530
		// (get) Token: 0x06017D67 RID: 97639 RVA: 0x0022E944 File Offset: 0x0022CB44
		// (set) Token: 0x06017D68 RID: 97640 RVA: 0x0022E97D File Offset: 0x0022CB7D
		public TMap<int, UKuroRoadway> RoadNet
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, UKuroRoadway> result;
				if ((result = this._RoadNet) == null)
				{
					result = (this._RoadNet = new TMap<int, UKuroRoadway>(base.NativePtr + (IntPtr)UKuroTransportNetworkComponent.__PropertyOffset_RoadNet, this));
				}
				return result;
			}
			set
			{
				this.RoadNet.CopyAssign(value);
			}
		}

		// Token: 0x06017D69 RID: 97641 RVA: 0x0022E98B File Offset: 0x0022CB8B
		static UKuroTransportNetworkComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroTransportNetworkComponent");
		}

		// Token: 0x06017D6A RID: 97642 RVA: 0x0022E999 File Offset: 0x0022CB99
		protected UKuroTransportNetworkComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CEB2 RID: 52914
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroTransportNetworkComponent";

		// Token: 0x0400CEB3 RID: 52915
		private static IntPtr _ClassPtr;

		// Token: 0x0400CEB4 RID: 52916
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CEB5 RID: 52917
		internal static int __PropertyOffset_AutopilotRoute;

		// Token: 0x0400CEB6 RID: 52918
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAutopilotRoute> _AutopilotRoute;

		// Token: 0x0400CEB7 RID: 52919
		internal static int __PropertyOffset_RoadNet;

		// Token: 0x0400CEB8 RID: 52920
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, UKuroRoadway> _RoadNet;
	}
}
