using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000185 RID: 389
	[UnrealObjectPath("/Script/Engine.ArrowComponent")]
	[UnrealStructLayout(1664, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1664)]
	public class UArrowComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600190F RID: 6415 RVA: 0x00025FCB File Offset: 0x000241CB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UArrowComponent._ClassPtr;
		}

		// Token: 0x06001910 RID: 6416 RVA: 0x00025FD8 File Offset: 0x000241D8
		public UArrowComponent() : this(BuiltinUtils.AllocNativeUObject(UArrowComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001911 RID: 6417 RVA: 0x00026000 File Offset: 0x00024200
		[NullableContext(1)]
		public UArrowComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UArrowComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06001912 RID: 6418 RVA: 0x00026033 File Offset: 0x00024233
		// (set) Token: 0x06001913 RID: 6419 RVA: 0x00026047 File Offset: 0x00024247
		public unsafe FColor ArrowColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UArrowComponent.__PropertyOffset_ArrowColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UArrowComponent.__PropertyOffset_ArrowColor) = value;
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06001914 RID: 6420 RVA: 0x0002605C File Offset: 0x0002425C
		// (set) Token: 0x06001915 RID: 6421 RVA: 0x0002606C File Offset: 0x0002426C
		public unsafe float ArrowSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UArrowComponent.__PropertyOffset_ArrowSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UArrowComponent.__PropertyOffset_ArrowSize) = value;
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06001916 RID: 6422 RVA: 0x0002607D File Offset: 0x0002427D
		// (set) Token: 0x06001917 RID: 6423 RVA: 0x0002608D File Offset: 0x0002428D
		public unsafe float ArrowLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UArrowComponent.__PropertyOffset_ArrowLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UArrowComponent.__PropertyOffset_ArrowLength) = value;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06001918 RID: 6424 RVA: 0x0002609E File Offset: 0x0002429E
		// (set) Token: 0x06001919 RID: 6425 RVA: 0x000260AE File Offset: 0x000242AE
		public unsafe float ScreenSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UArrowComponent.__PropertyOffset_ScreenSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UArrowComponent.__PropertyOffset_ScreenSize) = value;
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x0600191A RID: 6426 RVA: 0x000260BF File Offset: 0x000242BF
		// (set) Token: 0x0600191B RID: 6427 RVA: 0x000260D8 File Offset: 0x000242D8
		public unsafe bool bIsScreenSizeScaled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UArrowComponent.__PropertyOffset_bIsScreenSizeScaled) & UArrowComponent.__PropertyMask_bIsScreenSizeScaled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UArrowComponent.__PropertyOffset_bIsScreenSizeScaled) = ((*(base.NativePtr + (IntPtr)UArrowComponent.__PropertyOffset_bIsScreenSizeScaled) & ~UArrowComponent.__PropertyMask_bIsScreenSizeScaled) | (value ? UArrowComponent.__PropertyMask_bIsScreenSizeScaled : 0));
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x0600191C RID: 6428 RVA: 0x00026108 File Offset: 0x00024308
		// (set) Token: 0x0600191D RID: 6429 RVA: 0x00026121 File Offset: 0x00024321
		public unsafe bool bTreatAsASprite
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UArrowComponent.__PropertyOffset_bTreatAsASprite) & UArrowComponent.__PropertyMask_bTreatAsASprite) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UArrowComponent.__PropertyOffset_bTreatAsASprite) = ((*(base.NativePtr + (IntPtr)UArrowComponent.__PropertyOffset_bTreatAsASprite) & ~UArrowComponent.__PropertyMask_bTreatAsASprite) | (value ? UArrowComponent.__PropertyMask_bTreatAsASprite : 0));
			}
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x00026151 File Offset: 0x00024351
		public void SetArrowColor(FLinearColor NewColor)
		{
			UArrowComponent.__SetArrowColor_Internal(base.NativePtr, NewColor);
		}

		// Token: 0x0600191F RID: 6431
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetArrowColor_Internal(IntPtr @this, FLinearColor NewColor);

		// Token: 0x06001920 RID: 6432 RVA: 0x0002615F File Offset: 0x0002435F
		static UArrowComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ArrowComponent");
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x0002616D File Offset: 0x0002436D
		protected UArrowComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000807 RID: 2055
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ArrowComponent";

		// Token: 0x04000808 RID: 2056
		private static IntPtr _ClassPtr;

		// Token: 0x04000809 RID: 2057
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400080A RID: 2058
		internal static int __PropertyOffset_ArrowColor;

		// Token: 0x0400080B RID: 2059
		internal static int __PropertyOffset_ArrowSize;

		// Token: 0x0400080C RID: 2060
		internal static int __PropertyOffset_ArrowLength;

		// Token: 0x0400080D RID: 2061
		internal static int __PropertyOffset_ScreenSize;

		// Token: 0x0400080E RID: 2062
		internal static int __PropertyOffset_bIsScreenSizeScaled;

		// Token: 0x0400080F RID: 2063
		internal static byte __PropertyMask_bIsScreenSizeScaled;

		// Token: 0x04000810 RID: 2064
		internal static int __PropertyOffset_bTreatAsASprite;

		// Token: 0x04000811 RID: 2065
		internal static byte __PropertyMask_bTreatAsASprite;
	}
}
