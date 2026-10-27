using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F84 RID: 8068
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Landscape.LandscapeMeshProxyComponent")]
	[UnrealStructLayout(2064, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2064)]
	public class ULandscapeMeshProxyComponent : UStaticMeshComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E99C RID: 125340 RVA: 0x002D7A0B File Offset: 0x002D5C0B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULandscapeMeshProxyComponent._ClassPtr;
		}

		// Token: 0x0601E99D RID: 125341 RVA: 0x002D7A18 File Offset: 0x002D5C18
		public ULandscapeMeshProxyComponent() : this(BuiltinUtils.AllocNativeUObject(ULandscapeMeshProxyComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E99E RID: 125342 RVA: 0x002D7A40 File Offset: 0x002D5C40
		public ULandscapeMeshProxyComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULandscapeMeshProxyComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170079BE RID: 31166
		// (get) Token: 0x0601E99F RID: 125343 RVA: 0x002D7A73 File Offset: 0x002D5C73
		// (set) Token: 0x0601E9A0 RID: 125344 RVA: 0x002D7A87 File Offset: 0x002D5C87
		public unsafe FGuid LandscapeGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeMeshProxyComponent.__PropertyOffset_LandscapeGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeMeshProxyComponent.__PropertyOffset_LandscapeGuid) = value;
			}
		}

		// Token: 0x170079BF RID: 31167
		// (get) Token: 0x0601E9A1 RID: 125345 RVA: 0x002D7A9C File Offset: 0x002D5C9C
		// (set) Token: 0x0601E9A2 RID: 125346 RVA: 0x002D7AD5 File Offset: 0x002D5CD5
		public TArray<FIntPoint> ProxyComponentBases
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FIntPoint> result;
				if ((result = this._ProxyComponentBases) == null)
				{
					result = (this._ProxyComponentBases = new TArray<FIntPoint>(base.NativePtr + (IntPtr)ULandscapeMeshProxyComponent.__PropertyOffset_ProxyComponentBases, this));
				}
				return result;
			}
			set
			{
				this.ProxyComponentBases.CopyAssign(value);
			}
		}

		// Token: 0x170079C0 RID: 31168
		// (get) Token: 0x0601E9A3 RID: 125347 RVA: 0x002D7AE3 File Offset: 0x002D5CE3
		// (set) Token: 0x0601E9A4 RID: 125348 RVA: 0x002D7AF3 File Offset: 0x002D5CF3
		public unsafe sbyte ProxyLOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeMeshProxyComponent.__PropertyOffset_ProxyLOD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeMeshProxyComponent.__PropertyOffset_ProxyLOD) = (byte)value;
			}
		}

		// Token: 0x0601E9A5 RID: 125349 RVA: 0x002D7B04 File Offset: 0x002D5D04
		static ULandscapeMeshProxyComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Landscape.LandscapeMeshProxyComponent");
		}

		// Token: 0x0601E9A6 RID: 125350 RVA: 0x002D7B12 File Offset: 0x002D5D12
		protected ULandscapeMeshProxyComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010895 RID: 67733
		public new const string __ObjectPath = "/Script/Landscape.LandscapeMeshProxyComponent";

		// Token: 0x04010896 RID: 67734
		private static IntPtr _ClassPtr;

		// Token: 0x04010897 RID: 67735
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010898 RID: 67736
		internal static int __PropertyOffset_LandscapeGuid;

		// Token: 0x04010899 RID: 67737
		internal static int __PropertyOffset_ProxyComponentBases;

		// Token: 0x0401089A RID: 67738
		[Nullable(2)]
		private TArray<FIntPoint> _ProxyComponentBases;

		// Token: 0x0401089B RID: 67739
		internal static int __PropertyOffset_ProxyLOD;
	}
}
