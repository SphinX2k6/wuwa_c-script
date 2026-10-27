using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AEF RID: 6895
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroEffectMakerANS")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UKuroEffectMakerANS : UKuroAnimNotifyState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019BBE RID: 105406 RVA: 0x00260490 File Offset: 0x0025E690
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroEffectMakerANS._ClassPtr;
		}

		// Token: 0x06019BBF RID: 105407 RVA: 0x0026049C File Offset: 0x0025E69C
		public UKuroEffectMakerANS() : this(BuiltinUtils.AllocNativeUObject(UKuroEffectMakerANS.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019BC0 RID: 105408 RVA: 0x002604C4 File Offset: 0x0025E6C4
		[NullableContext(1)]
		public UKuroEffectMakerANS(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroEffectMakerANS.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170066D6 RID: 26326
		// (get) Token: 0x06019BC1 RID: 105409 RVA: 0x002604F7 File Offset: 0x0025E6F7
		// (set) Token: 0x06019BC2 RID: 105410 RVA: 0x0026050B File Offset: 0x0025E70B
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

		// Token: 0x170066D7 RID: 26327
		// (get) Token: 0x06019BC3 RID: 105411 RVA: 0x00260520 File Offset: 0x0025E720
		// (set) Token: 0x06019BC4 RID: 105412 RVA: 0x00260534 File Offset: 0x0025E734
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

		// Token: 0x170066D8 RID: 26328
		// (get) Token: 0x06019BC5 RID: 105413 RVA: 0x00260549 File Offset: 0x0025E749
		// (set) Token: 0x06019BC6 RID: 105414 RVA: 0x0026055D File Offset: 0x0025E75D
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

		// Token: 0x170066D9 RID: 26329
		// (get) Token: 0x06019BC7 RID: 105415 RVA: 0x00260572 File Offset: 0x0025E772
		// (set) Token: 0x06019BC8 RID: 105416 RVA: 0x00260582 File Offset: 0x0025E782
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

		// Token: 0x170066DA RID: 26330
		// (get) Token: 0x06019BC9 RID: 105417 RVA: 0x00260593 File Offset: 0x0025E793
		// (set) Token: 0x06019BCA RID: 105418 RVA: 0x002605A3 File Offset: 0x0025E7A3
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

		// Token: 0x170066DB RID: 26331
		// (get) Token: 0x06019BCB RID: 105419 RVA: 0x002605B4 File Offset: 0x0025E7B4
		// (set) Token: 0x06019BCC RID: 105420 RVA: 0x002605C8 File Offset: 0x0025E7C8
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

		// Token: 0x170066DC RID: 26332
		// (get) Token: 0x06019BCD RID: 105421 RVA: 0x002605DD File Offset: 0x0025E7DD
		// (set) Token: 0x06019BCE RID: 105422 RVA: 0x002605ED File Offset: 0x0025E7ED
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

		// Token: 0x170066DD RID: 26333
		// (get) Token: 0x06019BCF RID: 105423 RVA: 0x002605FE File Offset: 0x0025E7FE
		// (set) Token: 0x06019BD0 RID: 105424 RVA: 0x0026060E File Offset: 0x0025E80E
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

		// Token: 0x06019BD1 RID: 105425 RVA: 0x0026061F File Offset: 0x0025E81F
		static UKuroEffectMakerANS()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroEffectMakerANS");
		}

		// Token: 0x06019BD2 RID: 105426 RVA: 0x0026062D File Offset: 0x0025E82D
		protected UKuroEffectMakerANS(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DFEB RID: 57323
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroEffectMakerANS";

		// Token: 0x0400DFEC RID: 57324
		private static IntPtr _ClassPtr;

		// Token: 0x0400DFED RID: 57325
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400DFEE RID: 57326
		internal static int __PropertyOffset_Location;

		// Token: 0x0400DFEF RID: 57327
		internal static int __PropertyOffset_Rotation;

		// Token: 0x0400DFF0 RID: 57328
		internal static int __PropertyOffset_Scale;

		// Token: 0x0400DFF1 RID: 57329
		internal static int __PropertyOffset_Attached;

		// Token: 0x0400DFF2 RID: 57330
		internal static int __PropertyOffset_AttachLocationOnly;

		// Token: 0x0400DFF3 RID: 57331
		internal static int __PropertyOffset_SocketName;

		// Token: 0x0400DFF4 RID: 57332
		internal static int __PropertyOffset_AttachLocationTime;

		// Token: 0x0400DFF5 RID: 57333
		internal static int __PropertyOffset_AttachRotationTime;
	}
}
