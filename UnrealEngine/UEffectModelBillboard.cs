using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200189D RID: 6301
	[UnrealObjectPath("/Script/KuroGameplay.EffectModelBillboard")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UEffectModelBillboard : UEffectModelBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601733F RID: 95039 RVA: 0x0021D757 File Offset: 0x0021B957
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEffectModelBillboard._ClassPtr;
		}

		// Token: 0x06017340 RID: 95040 RVA: 0x0021D764 File Offset: 0x0021B964
		public UEffectModelBillboard() : this(BuiltinUtils.AllocNativeUObject(UEffectModelBillboard.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017341 RID: 95041 RVA: 0x0021D78C File Offset: 0x0021B98C
		[NullableContext(1)]
		public UEffectModelBillboard(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEffectModelBillboard.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005D47 RID: 23879
		// (get) Token: 0x06017342 RID: 95042 RVA: 0x0021D7BF File Offset: 0x0021B9BF
		// (set) Token: 0x06017343 RID: 95043 RVA: 0x0021D7CF File Offset: 0x0021B9CF
		public unsafe bool IsUpdateEveryFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelBillboard.__PropertyOffset_IsUpdateEveryFrame) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelBillboard.__PropertyOffset_IsUpdateEveryFrame) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005D48 RID: 23880
		// (get) Token: 0x06017344 RID: 95044 RVA: 0x0021D7E0 File Offset: 0x0021B9E0
		// (set) Token: 0x06017345 RID: 95045 RVA: 0x0021D7F0 File Offset: 0x0021B9F0
		public unsafe EBillboardMode OrientAxis
		{
			get
			{
				return (EBillboardMode)(*(base.NativePtr + (IntPtr)UEffectModelBillboard.__PropertyOffset_OrientAxis));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelBillboard.__PropertyOffset_OrientAxis) = (byte)value;
			}
		}

		// Token: 0x17005D49 RID: 23881
		// (get) Token: 0x06017346 RID: 95046 RVA: 0x0021D801 File Offset: 0x0021BA01
		// (set) Token: 0x06017347 RID: 95047 RVA: 0x0021D811 File Offset: 0x0021BA11
		public unsafe bool IsFixSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelBillboard.__PropertyOffset_IsFixSize) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelBillboard.__PropertyOffset_IsFixSize) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005D4A RID: 23882
		// (get) Token: 0x06017348 RID: 95048 RVA: 0x0021D822 File Offset: 0x0021BA22
		// (set) Token: 0x06017349 RID: 95049 RVA: 0x0021D832 File Offset: 0x0021BA32
		public unsafe float ScaleSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelBillboard.__PropertyOffset_ScaleSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelBillboard.__PropertyOffset_ScaleSize) = value;
			}
		}

		// Token: 0x17005D4B RID: 23883
		// (get) Token: 0x0601734A RID: 95050 RVA: 0x0021D843 File Offset: 0x0021BA43
		// (set) Token: 0x0601734B RID: 95051 RVA: 0x0021D853 File Offset: 0x0021BA53
		public unsafe float MaxDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelBillboard.__PropertyOffset_MaxDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelBillboard.__PropertyOffset_MaxDistance) = value;
			}
		}

		// Token: 0x17005D4C RID: 23884
		// (get) Token: 0x0601734C RID: 95052 RVA: 0x0021D864 File Offset: 0x0021BA64
		// (set) Token: 0x0601734D RID: 95053 RVA: 0x0021D874 File Offset: 0x0021BA74
		public unsafe float MinSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelBillboard.__PropertyOffset_MinSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelBillboard.__PropertyOffset_MinSize) = value;
			}
		}

		// Token: 0x0601734E RID: 95054 RVA: 0x0021D885 File Offset: 0x0021BA85
		static UEffectModelBillboard()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.EffectModelBillboard");
		}

		// Token: 0x0601734F RID: 95055 RVA: 0x0021D893 File Offset: 0x0021BA93
		protected UEffectModelBillboard(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C95A RID: 51546
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.EffectModelBillboard";

		// Token: 0x0400C95B RID: 51547
		private static IntPtr _ClassPtr;

		// Token: 0x0400C95C RID: 51548
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C95D RID: 51549
		internal static int __PropertyOffset_IsUpdateEveryFrame;

		// Token: 0x0400C95E RID: 51550
		internal static int __PropertyOffset_OrientAxis;

		// Token: 0x0400C95F RID: 51551
		internal static int __PropertyOffset_IsFixSize;

		// Token: 0x0400C960 RID: 51552
		internal static int __PropertyOffset_ScaleSize;

		// Token: 0x0400C961 RID: 51553
		internal static int __PropertyOffset_MaxDistance;

		// Token: 0x0400C962 RID: 51554
		internal static int __PropertyOffset_MinSize;
	}
}
