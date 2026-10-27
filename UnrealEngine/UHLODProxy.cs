using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C39 RID: 3129
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.HLODProxy")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UHLODProxy : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009E9A RID: 40602 RVA: 0x000E168B File Offset: 0x000DF88B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHLODProxy._ClassPtr;
		}

		// Token: 0x06009E9B RID: 40603 RVA: 0x000E1698 File Offset: 0x000DF898
		public UHLODProxy() : this(BuiltinUtils.AllocNativeUObject(UHLODProxy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009E9C RID: 40604 RVA: 0x000E16C0 File Offset: 0x000DF8C0
		public UHLODProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHLODProxy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170025E4 RID: 9700
		// (get) Token: 0x06009E9D RID: 40605 RVA: 0x000E16F4 File Offset: 0x000DF8F4
		// (set) Token: 0x06009E9E RID: 40606 RVA: 0x000E172D File Offset: 0x000DF92D
		public TArray<FHLODProxyMesh> ProxyMeshes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FHLODProxyMesh> result;
				if ((result = this._ProxyMeshes) == null)
				{
					result = (this._ProxyMeshes = new TArray<FHLODProxyMesh>(base.NativePtr + (IntPtr)UHLODProxy.__PropertyOffset_ProxyMeshes, this));
				}
				return result;
			}
			set
			{
				this.ProxyMeshes.CopyAssign(value);
			}
		}

		// Token: 0x170025E5 RID: 9701
		// (get) Token: 0x06009E9F RID: 40607 RVA: 0x000E173C File Offset: 0x000DF93C
		// (set) Token: 0x06009EA0 RID: 40608 RVA: 0x000E1775 File Offset: 0x000DF975
		public TMap<UHLODProxyDesc, FHLODProxyMesh> HLODActors
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UHLODProxyDesc, FHLODProxyMesh> result;
				if ((result = this._HLODActors) == null)
				{
					result = (this._HLODActors = new TMap<UHLODProxyDesc, FHLODProxyMesh>(base.NativePtr + (IntPtr)UHLODProxy.__PropertyOffset_HLODActors, this));
				}
				return result;
			}
			set
			{
				this.HLODActors.CopyAssign(value);
			}
		}

		// Token: 0x06009EA1 RID: 40609 RVA: 0x000E1783 File Offset: 0x000DF983
		static UHLODProxy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.HLODProxy");
		}

		// Token: 0x06009EA2 RID: 40610 RVA: 0x000E1791 File Offset: 0x000DF991
		protected UHLODProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400576C RID: 22380
		public new const string __ObjectPath = "/Script/Engine.HLODProxy";

		// Token: 0x0400576D RID: 22381
		private static IntPtr _ClassPtr;

		// Token: 0x0400576E RID: 22382
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400576F RID: 22383
		internal static int __PropertyOffset_ProxyMeshes;

		// Token: 0x04005770 RID: 22384
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FHLODProxyMesh> _ProxyMeshes;

		// Token: 0x04005771 RID: 22385
		internal static int __PropertyOffset_HLODActors;

		// Token: 0x04005772 RID: 22386
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<UHLODProxyDesc, FHLODProxyMesh> _HLODActors;
	}
}
