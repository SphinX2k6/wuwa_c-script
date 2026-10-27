using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000936 RID: 2358
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ClientEntityStreamingCell")]
	[UnrealStructLayout(384, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 384)]
	public class UClientEntityStreamingCell : UWorldPartitionRuntimeAssetStreamingCell, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600853C RID: 34108 RVA: 0x000BE02F File Offset: 0x000BC22F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UClientEntityStreamingCell._ClassPtr;
		}

		// Token: 0x0600853D RID: 34109 RVA: 0x000BE03C File Offset: 0x000BC23C
		public UClientEntityStreamingCell() : this(BuiltinUtils.AllocNativeUObject(UClientEntityStreamingCell.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600853E RID: 34110 RVA: 0x000BE064 File Offset: 0x000BC264
		public UClientEntityStreamingCell(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UClientEntityStreamingCell.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001F6E RID: 8046
		// (get) Token: 0x0600853F RID: 34111 RVA: 0x000BE097 File Offset: 0x000BC297
		// (set) Token: 0x06008540 RID: 34112 RVA: 0x000BE0AC File Offset: 0x000BC2AC
		public TSoftObjectPtr<UClientEntityAsset> ClientEntityAssetPtr
		{
			get
			{
				return new TSoftObjectPtr<UClientEntityAsset>(base.NativePtr + (IntPtr)UClientEntityStreamingCell.__PropertyOffset_ClientEntityAssetPtr, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UClientEntityStreamingCell.__PropertyOffset_ClientEntityAssetPtr, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x06008541 RID: 34113 RVA: 0x000BE0D1 File Offset: 0x000BC2D1
		static UClientEntityStreamingCell()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ClientEntityStreamingCell");
		}

		// Token: 0x06008542 RID: 34114 RVA: 0x000BE0DF File Offset: 0x000BC2DF
		protected UClientEntityStreamingCell(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003F67 RID: 16231
		public new const string __ObjectPath = "/Script/Engine.ClientEntityStreamingCell";

		// Token: 0x04003F68 RID: 16232
		private static IntPtr _ClassPtr;

		// Token: 0x04003F69 RID: 16233
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003F6A RID: 16234
		internal static int __PropertyOffset_ClientEntityAssetPtr;
	}
}
