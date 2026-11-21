using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004C6 RID: 1222
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroEffectMakerAN")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UKuroEffectMakerAN : UKuroAnimNotify, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060070C6 RID: 28870 RVA: 0x000A6692 File Offset: 0x000A4892
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroEffectMakerAN._ClassPtr;
		}

		// Token: 0x060070C7 RID: 28871 RVA: 0x000A66A0 File Offset: 0x000A48A0
		public UKuroEffectMakerAN() : this(BuiltinUtils.AllocNativeUObject(UKuroEffectMakerAN.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060070C8 RID: 28872 RVA: 0x000A66C8 File Offset: 0x000A48C8
		[NullableContext(1)]
		public UKuroEffectMakerAN(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroEffectMakerAN.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700160B RID: 5643
		// (get) Token: 0x060070C9 RID: 28873 RVA: 0x000A66FB File Offset: 0x000A48FB
		// (set) Token: 0x060070CA RID: 28874 RVA: 0x000A670F File Offset: 0x000A490F
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroEffectMakerAN.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroEffectMakerAN.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x1700160C RID: 5644
		// (get) Token: 0x060070CB RID: 28875 RVA: 0x000A6724 File Offset: 0x000A4924
		// (set) Token: 0x060070CC RID: 28876 RVA: 0x000A6738 File Offset: 0x000A4938
		public unsafe FRotator Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroEffectMakerAN.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroEffectMakerAN.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x1700160D RID: 5645
		// (get) Token: 0x060070CD RID: 28877 RVA: 0x000A674D File Offset: 0x000A494D
		// (set) Token: 0x060070CE RID: 28878 RVA: 0x000A6761 File Offset: 0x000A4961
		public unsafe FVector Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroEffectMakerAN.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroEffectMakerAN.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x1700160E RID: 5646
		// (get) Token: 0x060070CF RID: 28879 RVA: 0x000A6776 File Offset: 0x000A4976
		// (set) Token: 0x060070D0 RID: 28880 RVA: 0x000A6786 File Offset: 0x000A4986
		public unsafe bool Attached
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroEffectMakerAN.__PropertyOffset_Attached) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroEffectMakerAN.__PropertyOffset_Attached) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700160F RID: 5647
		// (get) Token: 0x060070D1 RID: 28881 RVA: 0x000A6797 File Offset: 0x000A4997
		// (set) Token: 0x060070D2 RID: 28882 RVA: 0x000A67A7 File Offset: 0x000A49A7
		public unsafe bool AttachLocationOnly
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroEffectMakerAN.__PropertyOffset_AttachLocationOnly) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroEffectMakerAN.__PropertyOffset_AttachLocationOnly) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001610 RID: 5648
		// (get) Token: 0x060070D3 RID: 28883 RVA: 0x000A67B8 File Offset: 0x000A49B8
		// (set) Token: 0x060070D4 RID: 28884 RVA: 0x000A67CC File Offset: 0x000A49CC
		public unsafe FName SocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroEffectMakerAN.__PropertyOffset_SocketName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroEffectMakerAN.__PropertyOffset_SocketName) = value;
			}
		}

		// Token: 0x060070D5 RID: 28885 RVA: 0x000A67E1 File Offset: 0x000A49E1
		static UKuroEffectMakerAN()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroEffectMakerAN");
		}

		// Token: 0x060070D6 RID: 28886 RVA: 0x000A67EF File Offset: 0x000A49EF
		protected UKuroEffectMakerAN(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040030AD RID: 12461
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroEffectMakerAN";

		// Token: 0x040030AE RID: 12462
		private static IntPtr _ClassPtr;

		// Token: 0x040030AF RID: 12463
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040030B0 RID: 12464
		internal static int __PropertyOffset_Location;

		// Token: 0x040030B1 RID: 12465
		internal static int __PropertyOffset_Rotation;

		// Token: 0x040030B2 RID: 12466
		internal static int __PropertyOffset_Scale;

		// Token: 0x040030B3 RID: 12467
		internal static int __PropertyOffset_Attached;

		// Token: 0x040030B4 RID: 12468
		internal static int __PropertyOffset_AttachLocationOnly;

		// Token: 0x040030B5 RID: 12469
		internal static int __PropertyOffset_SocketName;
	}
}
