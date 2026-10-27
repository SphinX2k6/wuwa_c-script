using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A13 RID: 6675
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroPakKey.KuroPakKeySetting")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UKuroPakKeySetting : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018B8C RID: 101260 RVA: 0x00247B4F File Offset: 0x00245D4F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPakKeySetting._ClassPtr;
		}

		// Token: 0x06018B8D RID: 101261 RVA: 0x00247B5C File Offset: 0x00245D5C
		public UKuroPakKeySetting() : this(BuiltinUtils.AllocNativeUObject(UKuroPakKeySetting.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018B8E RID: 101262 RVA: 0x00247B84 File Offset: 0x00245D84
		public UKuroPakKeySetting(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPakKeySetting.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006218 RID: 25112
		// (get) Token: 0x06018B8F RID: 101263 RVA: 0x00247BB7 File Offset: 0x00245DB7
		// (set) Token: 0x06018B90 RID: 101264 RVA: 0x00247BC7 File Offset: 0x00245DC7
		public unsafe bool bNeedExternalKeys
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroPakKeySetting.__PropertyOffset_bNeedExternalKeys) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroPakKeySetting.__PropertyOffset_bNeedExternalKeys) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006219 RID: 25113
		// (get) Token: 0x06018B91 RID: 101265 RVA: 0x00247BD8 File Offset: 0x00245DD8
		// (set) Token: 0x06018B92 RID: 101266 RVA: 0x00247BE8 File Offset: 0x00245DE8
		public unsafe int UpdateCheckInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroPakKeySetting.__PropertyOffset_UpdateCheckInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroPakKeySetting.__PropertyOffset_UpdateCheckInterval) = value;
			}
		}

		// Token: 0x1700621A RID: 25114
		// (get) Token: 0x06018B93 RID: 101267 RVA: 0x00247BFC File Offset: 0x00245DFC
		// (set) Token: 0x06018B94 RID: 101268 RVA: 0x00247C35 File Offset: 0x00245E35
		public TArray<int> PakMountedEvents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._PakMountedEvents) == null)
				{
					result = (this._PakMountedEvents = new TArray<int>(base.NativePtr + (IntPtr)UKuroPakKeySetting.__PropertyOffset_PakMountedEvents, this));
				}
				return result;
			}
			set
			{
				this.PakMountedEvents.CopyAssign(value);
			}
		}

		// Token: 0x06018B95 RID: 101269 RVA: 0x00247C43 File Offset: 0x00245E43
		static UKuroPakKeySetting()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroPakKey.KuroPakKeySetting");
		}

		// Token: 0x06018B96 RID: 101270 RVA: 0x00247C51 File Offset: 0x00245E51
		protected UKuroPakKeySetting(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D590 RID: 54672
		public new const string __ObjectPath = "/Script/KuroPakKey.KuroPakKeySetting";

		// Token: 0x0400D591 RID: 54673
		private static IntPtr _ClassPtr;

		// Token: 0x0400D592 RID: 54674
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D593 RID: 54675
		internal static int __PropertyOffset_bNeedExternalKeys;

		// Token: 0x0400D594 RID: 54676
		internal static int __PropertyOffset_UpdateCheckInterval;

		// Token: 0x0400D595 RID: 54677
		internal static int __PropertyOffset_PakMountedEvents;

		// Token: 0x0400D596 RID: 54678
		[Nullable(2)]
		private TArray<int> _PakMountedEvents;
	}
}
