using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F93 RID: 8083
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Landscape.LandscapeWeightmapUsage")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class ULandscapeWeightmapUsage : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EB0E RID: 125710 RVA: 0x002D9F8E File Offset: 0x002D818E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULandscapeWeightmapUsage._ClassPtr;
		}

		// Token: 0x0601EB0F RID: 125711 RVA: 0x002D9F9C File Offset: 0x002D819C
		public ULandscapeWeightmapUsage() : this(BuiltinUtils.AllocNativeUObject(ULandscapeWeightmapUsage.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EB10 RID: 125712 RVA: 0x002D9FC4 File Offset: 0x002D81C4
		public ULandscapeWeightmapUsage(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULandscapeWeightmapUsage.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007A41 RID: 31297
		// (get) Token: 0x0601EB11 RID: 125713 RVA: 0x002D9FF8 File Offset: 0x002D81F8
		// (set) Token: 0x0601EB12 RID: 125714 RVA: 0x002DA032 File Offset: 0x002D8232
		public TFixedArray<ULandscapeComponent> ChannelUsage
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<ULandscapeComponent> result;
				if ((result = this._ChannelUsage) == null)
				{
					result = (this._ChannelUsage = new TFixedArray<ULandscapeComponent>(base.NativePtr + (IntPtr)ULandscapeWeightmapUsage.__PropertyOffset_ChannelUsage, 4, this));
				}
				return result;
			}
			set
			{
				this.ChannelUsage.CopyAssign(value);
			}
		}

		// Token: 0x17007A42 RID: 31298
		// (get) Token: 0x0601EB13 RID: 125715 RVA: 0x002DA040 File Offset: 0x002D8240
		// (set) Token: 0x0601EB14 RID: 125716 RVA: 0x002DA054 File Offset: 0x002D8254
		public unsafe FGuid LayerGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeWeightmapUsage.__PropertyOffset_LayerGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeWeightmapUsage.__PropertyOffset_LayerGuid) = value;
			}
		}

		// Token: 0x0601EB15 RID: 125717 RVA: 0x002DA069 File Offset: 0x002D8269
		static ULandscapeWeightmapUsage()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Landscape.LandscapeWeightmapUsage");
		}

		// Token: 0x0601EB16 RID: 125718 RVA: 0x002DA077 File Offset: 0x002D8277
		protected ULandscapeWeightmapUsage(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401097A RID: 67962
		public new const string __ObjectPath = "/Script/Landscape.LandscapeWeightmapUsage";

		// Token: 0x0401097B RID: 67963
		private static IntPtr _ClassPtr;

		// Token: 0x0401097C RID: 67964
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401097D RID: 67965
		internal static int __PropertyOffset_ChannelUsage;

		// Token: 0x0401097E RID: 67966
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<ULandscapeComponent> _ChannelUsage;

		// Token: 0x0401097F RID: 67967
		internal static int __PropertyOffset_LayerGuid;
	}
}
