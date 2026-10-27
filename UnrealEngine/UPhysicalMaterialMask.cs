using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FDD RID: 4061
	[UnrealObjectPath("/Script/Engine.PhysicalMaterialMask")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UPhysicalMaterialMask : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600DB5F RID: 56159 RVA: 0x00143376 File Offset: 0x00141576
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPhysicalMaterialMask._ClassPtr;
		}

		// Token: 0x0600DB60 RID: 56160 RVA: 0x00143384 File Offset: 0x00141584
		public UPhysicalMaterialMask() : this(BuiltinUtils.AllocNativeUObject(UPhysicalMaterialMask.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600DB61 RID: 56161 RVA: 0x001433AC File Offset: 0x001415AC
		[NullableContext(1)]
		public UPhysicalMaterialMask(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPhysicalMaterialMask.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170033B7 RID: 13239
		// (get) Token: 0x0600DB62 RID: 56162 RVA: 0x001433DF File Offset: 0x001415DF
		// (set) Token: 0x0600DB63 RID: 56163 RVA: 0x001433EF File Offset: 0x001415EF
		public unsafe int UVChannelIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicalMaterialMask.__PropertyOffset_UVChannelIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicalMaterialMask.__PropertyOffset_UVChannelIndex) = value;
			}
		}

		// Token: 0x170033B8 RID: 13240
		// (get) Token: 0x0600DB64 RID: 56164 RVA: 0x00143400 File Offset: 0x00141600
		// (set) Token: 0x0600DB65 RID: 56165 RVA: 0x00143414 File Offset: 0x00141614
		public unsafe TEnumAsByte<TextureAddress> AddressX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicalMaterialMask.__PropertyOffset_AddressX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicalMaterialMask.__PropertyOffset_AddressX) = value;
			}
		}

		// Token: 0x170033B9 RID: 13241
		// (get) Token: 0x0600DB66 RID: 56166 RVA: 0x00143429 File Offset: 0x00141629
		// (set) Token: 0x0600DB67 RID: 56167 RVA: 0x0014343D File Offset: 0x0014163D
		public unsafe TEnumAsByte<TextureAddress> AddressY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicalMaterialMask.__PropertyOffset_AddressY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicalMaterialMask.__PropertyOffset_AddressY) = value;
			}
		}

		// Token: 0x0600DB68 RID: 56168 RVA: 0x00143452 File Offset: 0x00141652
		static UPhysicalMaterialMask()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PhysicalMaterialMask");
		}

		// Token: 0x0600DB69 RID: 56169 RVA: 0x00143460 File Offset: 0x00141660
		protected UPhysicalMaterialMask(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040076AE RID: 30382
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PhysicalMaterialMask";

		// Token: 0x040076AF RID: 30383
		private static IntPtr _ClassPtr;

		// Token: 0x040076B0 RID: 30384
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040076B1 RID: 30385
		internal static int __PropertyOffset_UVChannelIndex;

		// Token: 0x040076B2 RID: 30386
		internal static int __PropertyOffset_AddressX;

		// Token: 0x040076B3 RID: 30387
		internal static int __PropertyOffset_AddressY;
	}
}
