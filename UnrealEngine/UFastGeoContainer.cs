using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001299 RID: 4761
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/FastGeoStreaming.FastGeoContainer")]
	[UnrealStructLayout(440, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 440)]
	public class UFastGeoContainer : UAssetUserData, IUnrealUObject, IUnrealObject, IInterface_ApplyWorldOffset, IUnrealNativeInterface, IUnrealInterface, IInterface_StreamingPrimitiveContainer
	{
		// Token: 0x06011782 RID: 71554 RVA: 0x0019A4D6 File Offset: 0x001986D6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFastGeoContainer._ClassPtr;
		}

		// Token: 0x06011783 RID: 71555 RVA: 0x0019A4E2 File Offset: 0x001986E2
		int IInterface_ApplyWorldOffset.InterfaceOffset()
		{
			return UFastGeoContainer.__InterfaceOffset_IInterface_ApplyWorldOffset;
		}

		// Token: 0x06011784 RID: 71556 RVA: 0x0019A4E9 File Offset: 0x001986E9
		int IInterface_StreamingPrimitiveContainer.InterfaceOffset()
		{
			return UFastGeoContainer.__InterfaceOffset_IInterface_StreamingPrimitiveContainer;
		}

		// Token: 0x06011785 RID: 71557 RVA: 0x0019A4F0 File Offset: 0x001986F0
		public UFastGeoContainer() : this(BuiltinUtils.AllocNativeUObject(UFastGeoContainer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011786 RID: 71558 RVA: 0x0019A518 File Offset: 0x00198718
		public UFastGeoContainer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UFastGeoContainer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004421 RID: 17441
		// (get) Token: 0x06011787 RID: 71559 RVA: 0x0019A54C File Offset: 0x0019874C
		// (set) Token: 0x06011788 RID: 71560 RVA: 0x0019A585 File Offset: 0x00198785
		public TArray<UObject> Assets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._Assets) == null)
				{
					result = (this._Assets = new TArray<UObject>(base.NativePtr + (IntPtr)UFastGeoContainer.__PropertyOffset_Assets, this));
				}
				return result;
			}
			set
			{
				this.Assets.CopyAssign(value);
			}
		}

		// Token: 0x17004422 RID: 17442
		// (get) Token: 0x06011789 RID: 71561 RVA: 0x0019A594 File Offset: 0x00198794
		// (set) Token: 0x0601178A RID: 71562 RVA: 0x0019A5CD File Offset: 0x001987CD
		public TArray<FGuid> StreamingTextureGuids
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGuid> result;
				if ((result = this._StreamingTextureGuids) == null)
				{
					result = (this._StreamingTextureGuids = new TArray<FGuid>(base.NativePtr + (IntPtr)UFastGeoContainer.__PropertyOffset_StreamingTextureGuids, this));
				}
				return result;
			}
			set
			{
				this.StreamingTextureGuids.CopyAssign(value);
			}
		}

		// Token: 0x17004423 RID: 17443
		// (get) Token: 0x0601178B RID: 71563 RVA: 0x0019A5DB File Offset: 0x001987DB
		// (set) Token: 0x0601178C RID: 71564 RVA: 0x0019A5F4 File Offset: 0x001987F4
		public unsafe bool bTextureStreamingRotationChanged
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UFastGeoContainer.__PropertyOffset_bTextureStreamingRotationChanged) & UFastGeoContainer.__PropertyMask_bTextureStreamingRotationChanged) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UFastGeoContainer.__PropertyOffset_bTextureStreamingRotationChanged) = ((*(base.NativePtr + (IntPtr)UFastGeoContainer.__PropertyOffset_bTextureStreamingRotationChanged) & ~UFastGeoContainer.__PropertyMask_bTextureStreamingRotationChanged) | (value ? UFastGeoContainer.__PropertyMask_bTextureStreamingRotationChanged : 0));
			}
		}

		// Token: 0x0601178D RID: 71565 RVA: 0x0019A624 File Offset: 0x00198824
		static UFastGeoContainer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/FastGeoStreaming.FastGeoContainer");
		}

		// Token: 0x0601178E RID: 71566 RVA: 0x0019A632 File Offset: 0x00198832
		protected UFastGeoContainer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009599 RID: 38297
		internal static int __InterfaceOffset_IInterface_ApplyWorldOffset;

		// Token: 0x0400959A RID: 38298
		internal static int __InterfaceOffset_IInterface_StreamingPrimitiveContainer;

		// Token: 0x0400959B RID: 38299
		public new const string __ObjectPath = "/Script/FastGeoStreaming.FastGeoContainer";

		// Token: 0x0400959C RID: 38300
		private static IntPtr _ClassPtr;

		// Token: 0x0400959D RID: 38301
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400959E RID: 38302
		internal static int __PropertyOffset_Assets;

		// Token: 0x0400959F RID: 38303
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _Assets;

		// Token: 0x040095A0 RID: 38304
		internal static int __PropertyOffset_StreamingTextureGuids;

		// Token: 0x040095A1 RID: 38305
		[Nullable(2)]
		private TArray<FGuid> _StreamingTextureGuids;

		// Token: 0x040095A2 RID: 38306
		internal static int __PropertyOffset_bTextureStreamingRotationChanged;

		// Token: 0x040095A3 RID: 38307
		internal static byte __PropertyMask_bTextureStreamingRotationChanged;
	}
}
