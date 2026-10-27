using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001075 RID: 4213
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.RectLightComponent")]
	[UnrealStructLayout(1216, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1216)]
	public class URectLightComponent : ULocalLightComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600EFAE RID: 61358 RVA: 0x001636AF File Offset: 0x001618AF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URectLightComponent._ClassPtr;
		}

		// Token: 0x0600EFAF RID: 61359 RVA: 0x001636BC File Offset: 0x001618BC
		public URectLightComponent() : this(BuiltinUtils.AllocNativeUObject(URectLightComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600EFB0 RID: 61360 RVA: 0x001636E4 File Offset: 0x001618E4
		[NullableContext(1)]
		public URectLightComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URectLightComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003A02 RID: 14850
		// (get) Token: 0x0600EFB1 RID: 61361 RVA: 0x00163717 File Offset: 0x00161917
		// (set) Token: 0x0600EFB2 RID: 61362 RVA: 0x00163727 File Offset: 0x00161927
		public unsafe float RectLightShadowDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URectLightComponent.__PropertyOffset_RectLightShadowDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URectLightComponent.__PropertyOffset_RectLightShadowDistance) = value;
			}
		}

		// Token: 0x17003A03 RID: 14851
		// (get) Token: 0x0600EFB3 RID: 61363 RVA: 0x00163738 File Offset: 0x00161938
		// (set) Token: 0x0600EFB4 RID: 61364 RVA: 0x00163748 File Offset: 0x00161948
		public unsafe float RectShadowFadeDistancePercent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URectLightComponent.__PropertyOffset_RectShadowFadeDistancePercent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URectLightComponent.__PropertyOffset_RectShadowFadeDistancePercent) = value;
			}
		}

		// Token: 0x17003A04 RID: 14852
		// (get) Token: 0x0600EFB5 RID: 61365 RVA: 0x00163759 File Offset: 0x00161959
		// (set) Token: 0x0600EFB6 RID: 61366 RVA: 0x00163769 File Offset: 0x00161969
		public unsafe float SourceWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URectLightComponent.__PropertyOffset_SourceWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URectLightComponent.__PropertyOffset_SourceWidth) = value;
			}
		}

		// Token: 0x17003A05 RID: 14853
		// (get) Token: 0x0600EFB7 RID: 61367 RVA: 0x0016377A File Offset: 0x0016197A
		// (set) Token: 0x0600EFB8 RID: 61368 RVA: 0x0016378A File Offset: 0x0016198A
		public unsafe float SourceHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URectLightComponent.__PropertyOffset_SourceHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URectLightComponent.__PropertyOffset_SourceHeight) = value;
			}
		}

		// Token: 0x17003A06 RID: 14854
		// (get) Token: 0x0600EFB9 RID: 61369 RVA: 0x0016379B File Offset: 0x0016199B
		// (set) Token: 0x0600EFBA RID: 61370 RVA: 0x001637AB File Offset: 0x001619AB
		public unsafe float BarnDoorAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URectLightComponent.__PropertyOffset_BarnDoorAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URectLightComponent.__PropertyOffset_BarnDoorAngle) = value;
			}
		}

		// Token: 0x17003A07 RID: 14855
		// (get) Token: 0x0600EFBB RID: 61371 RVA: 0x001637BC File Offset: 0x001619BC
		// (set) Token: 0x0600EFBC RID: 61372 RVA: 0x001637CC File Offset: 0x001619CC
		public unsafe float BarnDoorLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URectLightComponent.__PropertyOffset_BarnDoorLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URectLightComponent.__PropertyOffset_BarnDoorLength) = value;
			}
		}

		// Token: 0x17003A08 RID: 14856
		// (get) Token: 0x0600EFBD RID: 61373 RVA: 0x001637DD File Offset: 0x001619DD
		// (set) Token: 0x0600EFBE RID: 61374 RVA: 0x001637ED File Offset: 0x001619ED
		public unsafe bool bExcludeFromTODLightManager
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URectLightComponent.__PropertyOffset_bExcludeFromTODLightManager) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URectLightComponent.__PropertyOffset_bExcludeFromTODLightManager) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003A09 RID: 14857
		// (get) Token: 0x0600EFBF RID: 61375 RVA: 0x001637FE File Offset: 0x001619FE
		// (set) Token: 0x0600EFC0 RID: 61376 RVA: 0x00163812 File Offset: 0x00161A12
		public unsafe UTexture SourceTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + URectLightComponent.__PropertyOffset_SourceTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + URectLightComponent.__PropertyOffset_SourceTexture, value);
			}
		}

		// Token: 0x0600EFC1 RID: 61377 RVA: 0x00163827 File Offset: 0x00161A27
		public void SetSourceWidth(float bNewValue)
		{
			URectLightComponent.__SetSourceWidth_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x0600EFC2 RID: 61378 RVA: 0x00163835 File Offset: 0x00161A35
		public void SetSourceTexture(UTexture bNewValue)
		{
			URectLightComponent.__SetSourceTexture_Internal(base.NativePtr, (bNewValue != null) ? bNewValue.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600EFC3 RID: 61379 RVA: 0x00163852 File Offset: 0x00161A52
		public void SetSourceHeight(float NewValue)
		{
			URectLightComponent.__SetSourceHeight_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600EFC4 RID: 61380 RVA: 0x00163860 File Offset: 0x00161A60
		public void SetBarnDoorLength(float NewValue)
		{
			URectLightComponent.__SetBarnDoorLength_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600EFC5 RID: 61381 RVA: 0x0016386E File Offset: 0x00161A6E
		public void SetBarnDoorAngle(float NewValue)
		{
			URectLightComponent.__SetBarnDoorAngle_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600EFC6 RID: 61382
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSourceWidth_Internal(IntPtr @this, float bNewValue);

		// Token: 0x0600EFC7 RID: 61383
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSourceTexture_Internal(IntPtr @this, IntPtr bNewValue);

		// Token: 0x0600EFC8 RID: 61384
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSourceHeight_Internal(IntPtr @this, float NewValue);

		// Token: 0x0600EFC9 RID: 61385
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBarnDoorLength_Internal(IntPtr @this, float NewValue);

		// Token: 0x0600EFCA RID: 61386
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBarnDoorAngle_Internal(IntPtr @this, float NewValue);

		// Token: 0x0600EFCB RID: 61387 RVA: 0x0016387C File Offset: 0x00161A7C
		static URectLightComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.RectLightComponent");
		}

		// Token: 0x0600EFCC RID: 61388 RVA: 0x0016388A File Offset: 0x00161A8A
		protected URectLightComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040081AC RID: 33196
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.RectLightComponent";

		// Token: 0x040081AD RID: 33197
		private static IntPtr _ClassPtr;

		// Token: 0x040081AE RID: 33198
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040081AF RID: 33199
		internal static int __PropertyOffset_RectLightShadowDistance;

		// Token: 0x040081B0 RID: 33200
		internal static int __PropertyOffset_RectShadowFadeDistancePercent;

		// Token: 0x040081B1 RID: 33201
		internal static int __PropertyOffset_SourceWidth;

		// Token: 0x040081B2 RID: 33202
		internal static int __PropertyOffset_SourceHeight;

		// Token: 0x040081B3 RID: 33203
		internal static int __PropertyOffset_BarnDoorAngle;

		// Token: 0x040081B4 RID: 33204
		internal static int __PropertyOffset_BarnDoorLength;

		// Token: 0x040081B5 RID: 33205
		internal static int __PropertyOffset_bExcludeFromTODLightManager;

		// Token: 0x040081B6 RID: 33206
		internal static int __PropertyOffset_SourceTexture;
	}
}
