using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000399 RID: 921
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AugmentedReality.ARCandidateImage")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UARCandidateImage : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060032ED RID: 13037 RVA: 0x0004E2FD File Offset: 0x0004C4FD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UARCandidateImage._ClassPtr;
		}

		// Token: 0x060032EE RID: 13038 RVA: 0x0004E30C File Offset: 0x0004C50C
		public UARCandidateImage() : this(BuiltinUtils.AllocNativeUObject(UARCandidateImage.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060032EF RID: 13039 RVA: 0x0004E334 File Offset: 0x0004C534
		public UARCandidateImage(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UARCandidateImage.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x060032F0 RID: 13040 RVA: 0x0004E367 File Offset: 0x0004C567
		// (set) Token: 0x060032F1 RID: 13041 RVA: 0x0004E37B File Offset: 0x0004C57B
		[Nullable(2)]
		public unsafe UTexture2D CandidateTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UARCandidateImage.__PropertyOffset_CandidateTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UARCandidateImage.__PropertyOffset_CandidateTexture, value);
			}
		}

		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x060032F2 RID: 13042 RVA: 0x0004E390 File Offset: 0x0004C590
		// (set) Token: 0x060032F3 RID: 13043 RVA: 0x0004E3A4 File Offset: 0x0004C5A4
		public unsafe string FriendlyName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UARCandidateImage.__PropertyOffset_FriendlyName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UARCandidateImage.__PropertyOffset_FriendlyName)), value);
			}
		}

		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x060032F4 RID: 13044 RVA: 0x0004E3B9 File Offset: 0x0004C5B9
		// (set) Token: 0x060032F5 RID: 13045 RVA: 0x0004E3C9 File Offset: 0x0004C5C9
		public unsafe float Width
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARCandidateImage.__PropertyOffset_Width);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARCandidateImage.__PropertyOffset_Width) = value;
			}
		}

		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x060032F6 RID: 13046 RVA: 0x0004E3DA File Offset: 0x0004C5DA
		// (set) Token: 0x060032F7 RID: 13047 RVA: 0x0004E3EA File Offset: 0x0004C5EA
		public unsafe float Height
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARCandidateImage.__PropertyOffset_Height);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARCandidateImage.__PropertyOffset_Height) = value;
			}
		}

		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x060032F8 RID: 13048 RVA: 0x0004E3FB File Offset: 0x0004C5FB
		// (set) Token: 0x060032F9 RID: 13049 RVA: 0x0004E40B File Offset: 0x0004C60B
		public unsafe EARCandidateImageOrientation Orientation
		{
			get
			{
				return (EARCandidateImageOrientation)(*(base.NativePtr + (IntPtr)UARCandidateImage.__PropertyOffset_Orientation));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARCandidateImage.__PropertyOffset_Orientation) = (byte)value;
			}
		}

		// Token: 0x060032FA RID: 13050 RVA: 0x0004E41C File Offset: 0x0004C61C
		public float GetPhysicalWidth()
		{
			return UARCandidateImage.__GetPhysicalWidth_Internal(base.NativePtr);
		}

		// Token: 0x060032FB RID: 13051 RVA: 0x0004E429 File Offset: 0x0004C629
		public float GetPhysicalHeight()
		{
			return UARCandidateImage.__GetPhysicalHeight_Internal(base.NativePtr);
		}

		// Token: 0x060032FC RID: 13052 RVA: 0x0004E436 File Offset: 0x0004C636
		public EARCandidateImageOrientation GetOrientation()
		{
			return UARCandidateImage.__GetOrientation_Internal(base.NativePtr);
		}

		// Token: 0x060032FD RID: 13053 RVA: 0x0004E443 File Offset: 0x0004C643
		public string GetFriendlyName()
		{
			return FString.ToStringAndDeleteNativePtr(UARCandidateImage.__GetFriendlyName_Internal(base.NativePtr));
		}

		// Token: 0x060032FE RID: 13054 RVA: 0x0004E455 File Offset: 0x0004C655
		[NullableContext(2)]
		public UTexture2D GetCandidateTexture()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture2D>(UARCandidateImage.__GetCandidateTexture_Internal(base.NativePtr));
		}

		// Token: 0x060032FF RID: 13055
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetPhysicalWidth_Internal(IntPtr @this);

		// Token: 0x06003300 RID: 13056
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetPhysicalHeight_Internal(IntPtr @this);

		// Token: 0x06003301 RID: 13057
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EARCandidateImageOrientation __GetOrientation_Internal(IntPtr @this);

		// Token: 0x06003302 RID: 13058
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetFriendlyName_Internal(IntPtr @this);

		// Token: 0x06003303 RID: 13059
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCandidateTexture_Internal(IntPtr @this);

		// Token: 0x06003304 RID: 13060 RVA: 0x0004E467 File Offset: 0x0004C667
		static UARCandidateImage()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARCandidateImage");
		}

		// Token: 0x06003305 RID: 13061 RVA: 0x0004E475 File Offset: 0x0004C675
		protected UARCandidateImage(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400162C RID: 5676
		public new const string __ObjectPath = "/Script/AugmentedReality.ARCandidateImage";

		// Token: 0x0400162D RID: 5677
		private static IntPtr _ClassPtr;

		// Token: 0x0400162E RID: 5678
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400162F RID: 5679
		internal static int __PropertyOffset_CandidateTexture;

		// Token: 0x04001630 RID: 5680
		internal static int __PropertyOffset_FriendlyName;

		// Token: 0x04001631 RID: 5681
		internal static int __PropertyOffset_Width;

		// Token: 0x04001632 RID: 5682
		internal static int __PropertyOffset_Height;

		// Token: 0x04001633 RID: 5683
		internal static int __PropertyOffset_Orientation;
	}
}
