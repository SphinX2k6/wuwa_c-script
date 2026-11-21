using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004C7 RID: 1223
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroEffectMakerANS")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UKuroEffectMakerANS : UKuroAnimNotifyState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060070D7 RID: 28887 RVA: 0x000A67F8 File Offset: 0x000A49F8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroEffectMakerANS._ClassPtr;
		}

		// Token: 0x060070D8 RID: 28888 RVA: 0x000A6804 File Offset: 0x000A4A04
		public UKuroEffectMakerANS() : this(BuiltinUtils.AllocNativeUObject(UKuroEffectMakerANS.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060070D9 RID: 28889 RVA: 0x000A682C File Offset: 0x000A4A2C
		[NullableContext(1)]
		public UKuroEffectMakerANS(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroEffectMakerANS.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001611 RID: 5649
		// (get) Token: 0x060070DA RID: 28890 RVA: 0x000A685F File Offset: 0x000A4A5F
		// (set) Token: 0x060070DB RID: 28891 RVA: 0x000A6873 File Offset: 0x000A4A73
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroEffectMakerANS.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroEffectMakerANS.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x17001612 RID: 5650
		// (get) Token: 0x060070DC RID: 28892 RVA: 0x000A6888 File Offset: 0x000A4A88
		// (set) Token: 0x060070DD RID: 28893 RVA: 0x000A689C File Offset: 0x000A4A9C
		public unsafe FRotator Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroEffectMakerANS.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroEffectMakerANS.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x17001613 RID: 5651
		// (get) Token: 0x060070DE RID: 28894 RVA: 0x000A68B1 File Offset: 0x000A4AB1
		// (set) Token: 0x060070DF RID: 28895 RVA: 0x000A68C5 File Offset: 0x000A4AC5
		public unsafe FVector Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroEffectMakerANS.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroEffectMakerANS.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x17001614 RID: 5652
		// (get) Token: 0x060070E0 RID: 28896 RVA: 0x000A68DA File Offset: 0x000A4ADA
		// (set) Token: 0x060070E1 RID: 28897 RVA: 0x000A68EA File Offset: 0x000A4AEA
		public unsafe bool Attached
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroEffectMakerANS.__PropertyOffset_Attached) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroEffectMakerANS.__PropertyOffset_Attached) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001615 RID: 5653
		// (get) Token: 0x060070E2 RID: 28898 RVA: 0x000A68FB File Offset: 0x000A4AFB
		// (set) Token: 0x060070E3 RID: 28899 RVA: 0x000A690B File Offset: 0x000A4B0B
		public unsafe bool AttachLocationOnly
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroEffectMakerANS.__PropertyOffset_AttachLocationOnly) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroEffectMakerANS.__PropertyOffset_AttachLocationOnly) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001616 RID: 5654
		// (get) Token: 0x060070E4 RID: 28900 RVA: 0x000A691C File Offset: 0x000A4B1C
		// (set) Token: 0x060070E5 RID: 28901 RVA: 0x000A6930 File Offset: 0x000A4B30
		public unsafe FName SocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroEffectMakerANS.__PropertyOffset_SocketName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroEffectMakerANS.__PropertyOffset_SocketName) = value;
			}
		}

		// Token: 0x17001617 RID: 5655
		// (get) Token: 0x060070E6 RID: 28902 RVA: 0x000A6945 File Offset: 0x000A4B45
		// (set) Token: 0x060070E7 RID: 28903 RVA: 0x000A6955 File Offset: 0x000A4B55
		public unsafe float AttachLocationTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroEffectMakerANS.__PropertyOffset_AttachLocationTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroEffectMakerANS.__PropertyOffset_AttachLocationTime) = value;
			}
		}

		// Token: 0x17001618 RID: 5656
		// (get) Token: 0x060070E8 RID: 28904 RVA: 0x000A6966 File Offset: 0x000A4B66
		// (set) Token: 0x060070E9 RID: 28905 RVA: 0x000A6976 File Offset: 0x000A4B76
		public unsafe float AttachRotationTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroEffectMakerANS.__PropertyOffset_AttachRotationTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroEffectMakerANS.__PropertyOffset_AttachRotationTime) = value;
			}
		}

		// Token: 0x060070EA RID: 28906 RVA: 0x000A6987 File Offset: 0x000A4B87
		static UKuroEffectMakerANS()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroEffectMakerANS");
		}

		// Token: 0x060070EB RID: 28907 RVA: 0x000A6995 File Offset: 0x000A4B95
		protected UKuroEffectMakerANS(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040030B6 RID: 12470
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroEffectMakerANS";

		// Token: 0x040030B7 RID: 12471
		private static IntPtr _ClassPtr;

		// Token: 0x040030B8 RID: 12472
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040030B9 RID: 12473
		internal static int __PropertyOffset_Location;

		// Token: 0x040030BA RID: 12474
		internal static int __PropertyOffset_Rotation;

		// Token: 0x040030BB RID: 12475
		internal static int __PropertyOffset_Scale;

		// Token: 0x040030BC RID: 12476
		internal static int __PropertyOffset_Attached;

		// Token: 0x040030BD RID: 12477
		internal static int __PropertyOffset_AttachLocationOnly;

		// Token: 0x040030BE RID: 12478
		internal static int __PropertyOffset_SocketName;

		// Token: 0x040030BF RID: 12479
		internal static int __PropertyOffset_AttachLocationTime;

		// Token: 0x040030C0 RID: 12480
		internal static int __PropertyOffset_AttachRotationTime;
	}
}
