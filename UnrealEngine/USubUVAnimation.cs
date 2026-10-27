using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011BC RID: 4540
	[UnrealObjectPath("/Script/Engine.SubUVAnimation")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class USubUVAnimation : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010BD4 RID: 68564 RVA: 0x00189290 File Offset: 0x00187490
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USubUVAnimation._ClassPtr;
		}

		// Token: 0x06010BD5 RID: 68565 RVA: 0x0018929C File Offset: 0x0018749C
		public USubUVAnimation() : this(BuiltinUtils.AllocNativeUObject(USubUVAnimation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010BD6 RID: 68566 RVA: 0x001892C4 File Offset: 0x001874C4
		[NullableContext(1)]
		public USubUVAnimation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USubUVAnimation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700415F RID: 16735
		// (get) Token: 0x06010BD7 RID: 68567 RVA: 0x001892F7 File Offset: 0x001874F7
		// (set) Token: 0x06010BD8 RID: 68568 RVA: 0x0018930B File Offset: 0x0018750B
		[Nullable(2)]
		public unsafe UTexture2D SubUVTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + USubUVAnimation.__PropertyOffset_SubUVTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USubUVAnimation.__PropertyOffset_SubUVTexture, value);
			}
		}

		// Token: 0x17004160 RID: 16736
		// (get) Token: 0x06010BD9 RID: 68569 RVA: 0x00189320 File Offset: 0x00187520
		// (set) Token: 0x06010BDA RID: 68570 RVA: 0x00189330 File Offset: 0x00187530
		public unsafe int SubImages_Horizontal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USubUVAnimation.__PropertyOffset_SubImages_Horizontal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USubUVAnimation.__PropertyOffset_SubImages_Horizontal) = value;
			}
		}

		// Token: 0x17004161 RID: 16737
		// (get) Token: 0x06010BDB RID: 68571 RVA: 0x00189341 File Offset: 0x00187541
		// (set) Token: 0x06010BDC RID: 68572 RVA: 0x00189351 File Offset: 0x00187551
		public unsafe int SubImages_Vertical
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USubUVAnimation.__PropertyOffset_SubImages_Vertical);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USubUVAnimation.__PropertyOffset_SubImages_Vertical) = value;
			}
		}

		// Token: 0x17004162 RID: 16738
		// (get) Token: 0x06010BDD RID: 68573 RVA: 0x00189362 File Offset: 0x00187562
		// (set) Token: 0x06010BDE RID: 68574 RVA: 0x00189376 File Offset: 0x00187576
		public unsafe TEnumAsByte<ESubUVBoundingVertexCount> BoundingMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USubUVAnimation.__PropertyOffset_BoundingMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USubUVAnimation.__PropertyOffset_BoundingMode) = value;
			}
		}

		// Token: 0x17004163 RID: 16739
		// (get) Token: 0x06010BDF RID: 68575 RVA: 0x0018938B File Offset: 0x0018758B
		// (set) Token: 0x06010BE0 RID: 68576 RVA: 0x0018939F File Offset: 0x0018759F
		public unsafe TEnumAsByte<EOpacitySourceMode> OpacitySourceMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USubUVAnimation.__PropertyOffset_OpacitySourceMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USubUVAnimation.__PropertyOffset_OpacitySourceMode) = value;
			}
		}

		// Token: 0x17004164 RID: 16740
		// (get) Token: 0x06010BE1 RID: 68577 RVA: 0x001893B4 File Offset: 0x001875B4
		// (set) Token: 0x06010BE2 RID: 68578 RVA: 0x001893C4 File Offset: 0x001875C4
		public unsafe float AlphaThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USubUVAnimation.__PropertyOffset_AlphaThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USubUVAnimation.__PropertyOffset_AlphaThreshold) = value;
			}
		}

		// Token: 0x06010BE3 RID: 68579 RVA: 0x001893D5 File Offset: 0x001875D5
		static USubUVAnimation()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SubUVAnimation");
		}

		// Token: 0x06010BE4 RID: 68580 RVA: 0x001893E3 File Offset: 0x001875E3
		protected USubUVAnimation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008F29 RID: 36649
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SubUVAnimation";

		// Token: 0x04008F2A RID: 36650
		private static IntPtr _ClassPtr;

		// Token: 0x04008F2B RID: 36651
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008F2C RID: 36652
		internal static int __PropertyOffset_SubUVTexture;

		// Token: 0x04008F2D RID: 36653
		internal static int __PropertyOffset_SubImages_Horizontal;

		// Token: 0x04008F2E RID: 36654
		internal static int __PropertyOffset_SubImages_Vertical;

		// Token: 0x04008F2F RID: 36655
		internal static int __PropertyOffset_BoundingMode;

		// Token: 0x04008F30 RID: 36656
		internal static int __PropertyOffset_OpacitySourceMode;

		// Token: 0x04008F31 RID: 36657
		internal static int __PropertyOffset_AlphaThreshold;
	}
}
