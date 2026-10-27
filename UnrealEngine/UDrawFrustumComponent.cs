using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009D9 RID: 2521
	[UnrealObjectPath("/Script/Engine.DrawFrustumComponent")]
	[UnrealStructLayout(1600, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1600)]
	public class UDrawFrustumComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008E76 RID: 36470 RVA: 0x000CBBDD File Offset: 0x000C9DDD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDrawFrustumComponent._ClassPtr;
		}

		// Token: 0x06008E77 RID: 36471 RVA: 0x000CBBEC File Offset: 0x000C9DEC
		public UDrawFrustumComponent() : this(BuiltinUtils.AllocNativeUObject(UDrawFrustumComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008E78 RID: 36472 RVA: 0x000CBC14 File Offset: 0x000C9E14
		[NullableContext(1)]
		public UDrawFrustumComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDrawFrustumComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002192 RID: 8594
		// (get) Token: 0x06008E79 RID: 36473 RVA: 0x000CBC47 File Offset: 0x000C9E47
		// (set) Token: 0x06008E7A RID: 36474 RVA: 0x000CBC5B File Offset: 0x000C9E5B
		public unsafe FColor FrustumColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDrawFrustumComponent.__PropertyOffset_FrustumColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDrawFrustumComponent.__PropertyOffset_FrustumColor) = value;
			}
		}

		// Token: 0x17002193 RID: 8595
		// (get) Token: 0x06008E7B RID: 36475 RVA: 0x000CBC70 File Offset: 0x000C9E70
		// (set) Token: 0x06008E7C RID: 36476 RVA: 0x000CBC80 File Offset: 0x000C9E80
		public unsafe float FrustumAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDrawFrustumComponent.__PropertyOffset_FrustumAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDrawFrustumComponent.__PropertyOffset_FrustumAngle) = value;
			}
		}

		// Token: 0x17002194 RID: 8596
		// (get) Token: 0x06008E7D RID: 36477 RVA: 0x000CBC91 File Offset: 0x000C9E91
		// (set) Token: 0x06008E7E RID: 36478 RVA: 0x000CBCA1 File Offset: 0x000C9EA1
		public unsafe float FrustumAspectRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDrawFrustumComponent.__PropertyOffset_FrustumAspectRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDrawFrustumComponent.__PropertyOffset_FrustumAspectRatio) = value;
			}
		}

		// Token: 0x17002195 RID: 8597
		// (get) Token: 0x06008E7F RID: 36479 RVA: 0x000CBCB2 File Offset: 0x000C9EB2
		// (set) Token: 0x06008E80 RID: 36480 RVA: 0x000CBCC2 File Offset: 0x000C9EC2
		public unsafe float FrustumStartDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDrawFrustumComponent.__PropertyOffset_FrustumStartDist);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDrawFrustumComponent.__PropertyOffset_FrustumStartDist) = value;
			}
		}

		// Token: 0x17002196 RID: 8598
		// (get) Token: 0x06008E81 RID: 36481 RVA: 0x000CBCD3 File Offset: 0x000C9ED3
		// (set) Token: 0x06008E82 RID: 36482 RVA: 0x000CBCE3 File Offset: 0x000C9EE3
		public unsafe float FrustumEndDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDrawFrustumComponent.__PropertyOffset_FrustumEndDist);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDrawFrustumComponent.__PropertyOffset_FrustumEndDist) = value;
			}
		}

		// Token: 0x17002197 RID: 8599
		// (get) Token: 0x06008E83 RID: 36483 RVA: 0x000CBCF4 File Offset: 0x000C9EF4
		// (set) Token: 0x06008E84 RID: 36484 RVA: 0x000CBD08 File Offset: 0x000C9F08
		[Nullable(2)]
		public unsafe UTexture Texture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + UDrawFrustumComponent.__PropertyOffset_Texture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UDrawFrustumComponent.__PropertyOffset_Texture, value);
			}
		}

		// Token: 0x06008E85 RID: 36485 RVA: 0x000CBD1D File Offset: 0x000C9F1D
		static UDrawFrustumComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DrawFrustumComponent");
		}

		// Token: 0x06008E86 RID: 36486 RVA: 0x000CBD2B File Offset: 0x000C9F2B
		protected UDrawFrustumComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040043C4 RID: 17348
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DrawFrustumComponent";

		// Token: 0x040043C5 RID: 17349
		private static IntPtr _ClassPtr;

		// Token: 0x040043C6 RID: 17350
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040043C7 RID: 17351
		internal static int __PropertyOffset_FrustumColor;

		// Token: 0x040043C8 RID: 17352
		internal static int __PropertyOffset_FrustumAngle;

		// Token: 0x040043C9 RID: 17353
		internal static int __PropertyOffset_FrustumAspectRatio;

		// Token: 0x040043CA RID: 17354
		internal static int __PropertyOffset_FrustumStartDist;

		// Token: 0x040043CB RID: 17355
		internal static int __PropertyOffset_FrustumEndDist;

		// Token: 0x040043CC RID: 17356
		internal static int __PropertyOffset_Texture;
	}
}
