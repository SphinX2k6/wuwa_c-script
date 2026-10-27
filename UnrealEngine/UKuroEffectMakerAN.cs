using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AEE RID: 6894
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroEffectMakerAN")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UKuroEffectMakerAN : UKuroAnimNotify, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019BAD RID: 105389 RVA: 0x0026032C File Offset: 0x0025E52C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroEffectMakerAN._ClassPtr;
		}

		// Token: 0x06019BAE RID: 105390 RVA: 0x00260338 File Offset: 0x0025E538
		public UKuroEffectMakerAN() : this(BuiltinUtils.AllocNativeUObject(UKuroEffectMakerAN.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019BAF RID: 105391 RVA: 0x00260360 File Offset: 0x0025E560
		[NullableContext(1)]
		public UKuroEffectMakerAN(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroEffectMakerAN.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170066D0 RID: 26320
		// (get) Token: 0x06019BB0 RID: 105392 RVA: 0x00260393 File Offset: 0x0025E593
		// (set) Token: 0x06019BB1 RID: 105393 RVA: 0x002603A7 File Offset: 0x0025E5A7
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

		// Token: 0x170066D1 RID: 26321
		// (get) Token: 0x06019BB2 RID: 105394 RVA: 0x002603BC File Offset: 0x0025E5BC
		// (set) Token: 0x06019BB3 RID: 105395 RVA: 0x002603D0 File Offset: 0x0025E5D0
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

		// Token: 0x170066D2 RID: 26322
		// (get) Token: 0x06019BB4 RID: 105396 RVA: 0x002603E5 File Offset: 0x0025E5E5
		// (set) Token: 0x06019BB5 RID: 105397 RVA: 0x002603F9 File Offset: 0x0025E5F9
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

		// Token: 0x170066D3 RID: 26323
		// (get) Token: 0x06019BB6 RID: 105398 RVA: 0x0026040E File Offset: 0x0025E60E
		// (set) Token: 0x06019BB7 RID: 105399 RVA: 0x0026041E File Offset: 0x0025E61E
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

		// Token: 0x170066D4 RID: 26324
		// (get) Token: 0x06019BB8 RID: 105400 RVA: 0x0026042F File Offset: 0x0025E62F
		// (set) Token: 0x06019BB9 RID: 105401 RVA: 0x0026043F File Offset: 0x0025E63F
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

		// Token: 0x170066D5 RID: 26325
		// (get) Token: 0x06019BBA RID: 105402 RVA: 0x00260450 File Offset: 0x0025E650
		// (set) Token: 0x06019BBB RID: 105403 RVA: 0x00260464 File Offset: 0x0025E664
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

		// Token: 0x06019BBC RID: 105404 RVA: 0x00260479 File Offset: 0x0025E679
		static UKuroEffectMakerAN()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroEffectMakerAN");
		}

		// Token: 0x06019BBD RID: 105405 RVA: 0x00260487 File Offset: 0x0025E687
		protected UKuroEffectMakerAN(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DFE2 RID: 57314
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroEffectMakerAN";

		// Token: 0x0400DFE3 RID: 57315
		private static IntPtr _ClassPtr;

		// Token: 0x0400DFE4 RID: 57316
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400DFE5 RID: 57317
		internal static int __PropertyOffset_Location;

		// Token: 0x0400DFE6 RID: 57318
		internal static int __PropertyOffset_Rotation;

		// Token: 0x0400DFE7 RID: 57319
		internal static int __PropertyOffset_Scale;

		// Token: 0x0400DFE8 RID: 57320
		internal static int __PropertyOffset_Attached;

		// Token: 0x0400DFE9 RID: 57321
		internal static int __PropertyOffset_AttachLocationOnly;

		// Token: 0x0400DFEA RID: 57322
		internal static int __PropertyOffset_SocketName;
	}
}
