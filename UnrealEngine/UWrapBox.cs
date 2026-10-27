using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002A0B RID: 10763
	[UnrealObjectPath("/Script/UMG.WrapBox")]
	[UnrealStructLayout(720, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 720)]
	public class UWrapBox : UPanelWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028049 RID: 163913 RVA: 0x003CEA81 File Offset: 0x003CCC81
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWrapBox._ClassPtr;
		}

		// Token: 0x0602804A RID: 163914 RVA: 0x003CEA90 File Offset: 0x003CCC90
		public UWrapBox() : this(BuiltinUtils.AllocNativeUObject(UWrapBox.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602804B RID: 163915 RVA: 0x003CEAB8 File Offset: 0x003CCCB8
		[NullableContext(1)]
		public UWrapBox(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWrapBox.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170098D9 RID: 39129
		// (get) Token: 0x0602804C RID: 163916 RVA: 0x003CEAEB File Offset: 0x003CCCEB
		// (set) Token: 0x0602804D RID: 163917 RVA: 0x003CEAFF File Offset: 0x003CCCFF
		public unsafe FVector2D InnerSlotPadding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWrapBox.__PropertyOffset_InnerSlotPadding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWrapBox.__PropertyOffset_InnerSlotPadding) = value;
			}
		}

		// Token: 0x170098DA RID: 39130
		// (get) Token: 0x0602804E RID: 163918 RVA: 0x003CEB14 File Offset: 0x003CCD14
		// (set) Token: 0x0602804F RID: 163919 RVA: 0x003CEB24 File Offset: 0x003CCD24
		public unsafe float WrapWidth_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWrapBox.__PropertyOffset_WrapWidth_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWrapBox.__PropertyOffset_WrapWidth_DEPRECATED) = value;
			}
		}

		// Token: 0x170098DB RID: 39131
		// (get) Token: 0x06028050 RID: 163920 RVA: 0x003CEB35 File Offset: 0x003CCD35
		// (set) Token: 0x06028051 RID: 163921 RVA: 0x003CEB45 File Offset: 0x003CCD45
		public unsafe float WrapSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWrapBox.__PropertyOffset_WrapSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWrapBox.__PropertyOffset_WrapSize) = value;
			}
		}

		// Token: 0x170098DC RID: 39132
		// (get) Token: 0x06028052 RID: 163922 RVA: 0x003CEB56 File Offset: 0x003CCD56
		// (set) Token: 0x06028053 RID: 163923 RVA: 0x003CEB66 File Offset: 0x003CCD66
		public unsafe bool bExplicitWrapWidth_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWrapBox.__PropertyOffset_bExplicitWrapWidth_DEPRECATED) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWrapBox.__PropertyOffset_bExplicitWrapWidth_DEPRECATED) = (value ? 1 : 0);
			}
		}

		// Token: 0x170098DD RID: 39133
		// (get) Token: 0x06028054 RID: 163924 RVA: 0x003CEB77 File Offset: 0x003CCD77
		// (set) Token: 0x06028055 RID: 163925 RVA: 0x003CEB87 File Offset: 0x003CCD87
		public unsafe bool bExplicitWrapSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWrapBox.__PropertyOffset_bExplicitWrapSize) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWrapBox.__PropertyOffset_bExplicitWrapSize) = (value ? 1 : 0);
			}
		}

		// Token: 0x170098DE RID: 39134
		// (get) Token: 0x06028056 RID: 163926 RVA: 0x003CEB98 File Offset: 0x003CCD98
		// (set) Token: 0x06028057 RID: 163927 RVA: 0x003CEBAC File Offset: 0x003CCDAC
		public unsafe TEnumAsByte<EOrientation> Orientation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWrapBox.__PropertyOffset_Orientation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWrapBox.__PropertyOffset_Orientation) = value;
			}
		}

		// Token: 0x06028058 RID: 163928 RVA: 0x003CEBC1 File Offset: 0x003CCDC1
		public void SetInnerSlotPadding(FVector2D InPadding)
		{
			UWrapBox.__SetInnerSlotPadding_Internal(base.NativePtr, InPadding);
		}

		// Token: 0x06028059 RID: 163929 RVA: 0x003CEBCF File Offset: 0x003CCDCF
		[NullableContext(2)]
		public UWrapBoxSlot AddChildToWrapBox(UWidget Content)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UWrapBoxSlot>(UWrapBox.__AddChildToWrapBox_Internal(base.NativePtr, (Content != null) ? Content.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0602805A RID: 163930
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInnerSlotPadding_Internal(IntPtr @this, FVector2D InPadding);

		// Token: 0x0602805B RID: 163931
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddChildToWrapBox_Internal(IntPtr @this, IntPtr Content);

		// Token: 0x0602805C RID: 163932 RVA: 0x003CEBF1 File Offset: 0x003CCDF1
		static UWrapBox()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.WrapBox");
		}

		// Token: 0x0602805D RID: 163933 RVA: 0x003CEBFF File Offset: 0x003CCDFF
		protected UWrapBox(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015D63 RID: 89443
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.WrapBox";

		// Token: 0x04015D64 RID: 89444
		private static IntPtr _ClassPtr;

		// Token: 0x04015D65 RID: 89445
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015D66 RID: 89446
		internal static int __PropertyOffset_InnerSlotPadding;

		// Token: 0x04015D67 RID: 89447
		internal static int __PropertyOffset_WrapWidth_DEPRECATED;

		// Token: 0x04015D68 RID: 89448
		internal static int __PropertyOffset_WrapSize;

		// Token: 0x04015D69 RID: 89449
		internal static int __PropertyOffset_bExplicitWrapWidth_DEPRECATED;

		// Token: 0x04015D6A RID: 89450
		internal static int __PropertyOffset_bExplicitWrapSize;

		// Token: 0x04015D6B RID: 89451
		internal static int __PropertyOffset_Orientation;
	}
}
