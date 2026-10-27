using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003D3 RID: 979
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AugmentedReality.ARTrackedImage")]
	[UnrealStructLayout(272, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 272)]
	public class UARTrackedImage : UARTrackedGeometry, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060036F8 RID: 14072 RVA: 0x0005373A File Offset: 0x0005193A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UARTrackedImage._ClassPtr;
		}

		// Token: 0x060036F9 RID: 14073 RVA: 0x00053748 File Offset: 0x00051948
		public UARTrackedImage() : this(BuiltinUtils.AllocNativeUObject(UARTrackedImage.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060036FA RID: 14074 RVA: 0x00053770 File Offset: 0x00051970
		[NullableContext(1)]
		public UARTrackedImage(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UARTrackedImage.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x060036FB RID: 14075 RVA: 0x000537A3 File Offset: 0x000519A3
		// (set) Token: 0x060036FC RID: 14076 RVA: 0x000537B7 File Offset: 0x000519B7
		public unsafe UARCandidateImage DetectedImage
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UARCandidateImage>(base.NativePtr / (IntPtr)sizeof(void*) + UARTrackedImage.__PropertyOffset_DetectedImage);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UARTrackedImage.__PropertyOffset_DetectedImage, value);
			}
		}

		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x060036FD RID: 14077 RVA: 0x000537CC File Offset: 0x000519CC
		// (set) Token: 0x060036FE RID: 14078 RVA: 0x000537E0 File Offset: 0x000519E0
		public unsafe FVector2D EstimatedSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARTrackedImage.__PropertyOffset_EstimatedSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARTrackedImage.__PropertyOffset_EstimatedSize) = value;
			}
		}

		// Token: 0x060036FF RID: 14079 RVA: 0x000537F5 File Offset: 0x000519F5
		public FVector2D GetEstimateSize()
		{
			return UARTrackedImage.__GetEstimateSize_Internal(base.NativePtr);
		}

		// Token: 0x06003700 RID: 14080 RVA: 0x00053802 File Offset: 0x00051A02
		public UARCandidateImage GetDetectedImage()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UARCandidateImage>(UARTrackedImage.__GetDetectedImage_Internal(base.NativePtr));
		}

		// Token: 0x06003701 RID: 14081
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetEstimateSize_Internal(IntPtr @this);

		// Token: 0x06003702 RID: 14082
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDetectedImage_Internal(IntPtr @this);

		// Token: 0x06003703 RID: 14083 RVA: 0x00053814 File Offset: 0x00051A14
		static UARTrackedImage()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARTrackedImage");
		}

		// Token: 0x06003704 RID: 14084 RVA: 0x00053822 File Offset: 0x00051A22
		protected UARTrackedImage(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040017D5 RID: 6101
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AugmentedReality.ARTrackedImage";

		// Token: 0x040017D6 RID: 6102
		private static IntPtr _ClassPtr;

		// Token: 0x040017D7 RID: 6103
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040017D8 RID: 6104
		internal static int __PropertyOffset_DetectedImage;

		// Token: 0x040017D9 RID: 6105
		internal static int __PropertyOffset_EstimatedSize;
	}
}
