using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001221 RID: 4641
	[UnrealObjectPath("/Script/Engine.VectorFieldAnimated")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UVectorFieldAnimated : UVectorField, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601114A RID: 69962 RVA: 0x00191108 File Offset: 0x0018F308
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UVectorFieldAnimated._ClassPtr;
		}

		// Token: 0x0601114B RID: 69963 RVA: 0x00191114 File Offset: 0x0018F314
		public UVectorFieldAnimated() : this(BuiltinUtils.AllocNativeUObject(UVectorFieldAnimated.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601114C RID: 69964 RVA: 0x0019113C File Offset: 0x0018F33C
		[NullableContext(1)]
		public UVectorFieldAnimated(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UVectorFieldAnimated.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170042AE RID: 17070
		// (get) Token: 0x0601114D RID: 69965 RVA: 0x0019116F File Offset: 0x0018F36F
		// (set) Token: 0x0601114E RID: 69966 RVA: 0x00191183 File Offset: 0x0018F383
		[Nullable(2)]
		public unsafe UTexture2D Texture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UVectorFieldAnimated.__PropertyOffset_Texture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UVectorFieldAnimated.__PropertyOffset_Texture, value);
			}
		}

		// Token: 0x170042AF RID: 17071
		// (get) Token: 0x0601114F RID: 69967 RVA: 0x00191198 File Offset: 0x0018F398
		// (set) Token: 0x06011150 RID: 69968 RVA: 0x001911AC File Offset: 0x0018F3AC
		public unsafe TEnumAsByte<EVectorFieldConstructionOp> ConstructionOp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UVectorFieldAnimated.__PropertyOffset_ConstructionOp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UVectorFieldAnimated.__PropertyOffset_ConstructionOp) = value;
			}
		}

		// Token: 0x170042B0 RID: 17072
		// (get) Token: 0x06011151 RID: 69969 RVA: 0x001911C1 File Offset: 0x0018F3C1
		// (set) Token: 0x06011152 RID: 69970 RVA: 0x001911D1 File Offset: 0x0018F3D1
		public unsafe int VolumeSizeX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UVectorFieldAnimated.__PropertyOffset_VolumeSizeX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UVectorFieldAnimated.__PropertyOffset_VolumeSizeX) = value;
			}
		}

		// Token: 0x170042B1 RID: 17073
		// (get) Token: 0x06011153 RID: 69971 RVA: 0x001911E2 File Offset: 0x0018F3E2
		// (set) Token: 0x06011154 RID: 69972 RVA: 0x001911F2 File Offset: 0x0018F3F2
		public unsafe int VolumeSizeY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UVectorFieldAnimated.__PropertyOffset_VolumeSizeY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UVectorFieldAnimated.__PropertyOffset_VolumeSizeY) = value;
			}
		}

		// Token: 0x170042B2 RID: 17074
		// (get) Token: 0x06011155 RID: 69973 RVA: 0x00191203 File Offset: 0x0018F403
		// (set) Token: 0x06011156 RID: 69974 RVA: 0x00191213 File Offset: 0x0018F413
		public unsafe int VolumeSizeZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UVectorFieldAnimated.__PropertyOffset_VolumeSizeZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UVectorFieldAnimated.__PropertyOffset_VolumeSizeZ) = value;
			}
		}

		// Token: 0x170042B3 RID: 17075
		// (get) Token: 0x06011157 RID: 69975 RVA: 0x00191224 File Offset: 0x0018F424
		// (set) Token: 0x06011158 RID: 69976 RVA: 0x00191234 File Offset: 0x0018F434
		public unsafe int SubImagesX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UVectorFieldAnimated.__PropertyOffset_SubImagesX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UVectorFieldAnimated.__PropertyOffset_SubImagesX) = value;
			}
		}

		// Token: 0x170042B4 RID: 17076
		// (get) Token: 0x06011159 RID: 69977 RVA: 0x00191245 File Offset: 0x0018F445
		// (set) Token: 0x0601115A RID: 69978 RVA: 0x00191255 File Offset: 0x0018F455
		public unsafe int SubImagesY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UVectorFieldAnimated.__PropertyOffset_SubImagesY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UVectorFieldAnimated.__PropertyOffset_SubImagesY) = value;
			}
		}

		// Token: 0x170042B5 RID: 17077
		// (get) Token: 0x0601115B RID: 69979 RVA: 0x00191266 File Offset: 0x0018F466
		// (set) Token: 0x0601115C RID: 69980 RVA: 0x00191276 File Offset: 0x0018F476
		public unsafe int FrameCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UVectorFieldAnimated.__PropertyOffset_FrameCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UVectorFieldAnimated.__PropertyOffset_FrameCount) = value;
			}
		}

		// Token: 0x170042B6 RID: 17078
		// (get) Token: 0x0601115D RID: 69981 RVA: 0x00191287 File Offset: 0x0018F487
		// (set) Token: 0x0601115E RID: 69982 RVA: 0x00191297 File Offset: 0x0018F497
		public unsafe float FramesPerSecond
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UVectorFieldAnimated.__PropertyOffset_FramesPerSecond);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UVectorFieldAnimated.__PropertyOffset_FramesPerSecond) = value;
			}
		}

		// Token: 0x170042B7 RID: 17079
		// (get) Token: 0x0601115F RID: 69983 RVA: 0x001912A8 File Offset: 0x0018F4A8
		// (set) Token: 0x06011160 RID: 69984 RVA: 0x001912C1 File Offset: 0x0018F4C1
		public unsafe bool bLoop
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UVectorFieldAnimated.__PropertyOffset_bLoop) & UVectorFieldAnimated.__PropertyMask_bLoop) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UVectorFieldAnimated.__PropertyOffset_bLoop) = ((*(base.NativePtr + (IntPtr)UVectorFieldAnimated.__PropertyOffset_bLoop) & ~UVectorFieldAnimated.__PropertyMask_bLoop) | (value ? UVectorFieldAnimated.__PropertyMask_bLoop : 0));
			}
		}

		// Token: 0x170042B8 RID: 17080
		// (get) Token: 0x06011161 RID: 69985 RVA: 0x001912F1 File Offset: 0x0018F4F1
		// (set) Token: 0x06011162 RID: 69986 RVA: 0x00191305 File Offset: 0x0018F505
		[Nullable(2)]
		public unsafe UVectorFieldStatic NoiseField
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UVectorFieldStatic>(base.NativePtr / (IntPtr)sizeof(void*) + UVectorFieldAnimated.__PropertyOffset_NoiseField);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UVectorFieldAnimated.__PropertyOffset_NoiseField, value);
			}
		}

		// Token: 0x170042B9 RID: 17081
		// (get) Token: 0x06011163 RID: 69987 RVA: 0x0019131A File Offset: 0x0018F51A
		// (set) Token: 0x06011164 RID: 69988 RVA: 0x0019132A File Offset: 0x0018F52A
		public unsafe float NoiseScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UVectorFieldAnimated.__PropertyOffset_NoiseScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UVectorFieldAnimated.__PropertyOffset_NoiseScale) = value;
			}
		}

		// Token: 0x170042BA RID: 17082
		// (get) Token: 0x06011165 RID: 69989 RVA: 0x0019133B File Offset: 0x0018F53B
		// (set) Token: 0x06011166 RID: 69990 RVA: 0x0019134B File Offset: 0x0018F54B
		public unsafe float NoiseMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UVectorFieldAnimated.__PropertyOffset_NoiseMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UVectorFieldAnimated.__PropertyOffset_NoiseMax) = value;
			}
		}

		// Token: 0x06011167 RID: 69991 RVA: 0x0019135C File Offset: 0x0018F55C
		static UVectorFieldAnimated()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.VectorFieldAnimated");
		}

		// Token: 0x06011168 RID: 69992 RVA: 0x0019136A File Offset: 0x0018F56A
		protected UVectorFieldAnimated(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400924E RID: 37454
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.VectorFieldAnimated";

		// Token: 0x0400924F RID: 37455
		private static IntPtr _ClassPtr;

		// Token: 0x04009250 RID: 37456
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009251 RID: 37457
		internal static int __PropertyOffset_Texture;

		// Token: 0x04009252 RID: 37458
		internal static int __PropertyOffset_ConstructionOp;

		// Token: 0x04009253 RID: 37459
		internal static int __PropertyOffset_VolumeSizeX;

		// Token: 0x04009254 RID: 37460
		internal static int __PropertyOffset_VolumeSizeY;

		// Token: 0x04009255 RID: 37461
		internal static int __PropertyOffset_VolumeSizeZ;

		// Token: 0x04009256 RID: 37462
		internal static int __PropertyOffset_SubImagesX;

		// Token: 0x04009257 RID: 37463
		internal static int __PropertyOffset_SubImagesY;

		// Token: 0x04009258 RID: 37464
		internal static int __PropertyOffset_FrameCount;

		// Token: 0x04009259 RID: 37465
		internal static int __PropertyOffset_FramesPerSecond;

		// Token: 0x0400925A RID: 37466
		internal static int __PropertyOffset_bLoop;

		// Token: 0x0400925B RID: 37467
		internal static byte __PropertyMask_bLoop;

		// Token: 0x0400925C RID: 37468
		internal static int __PropertyOffset_NoiseField;

		// Token: 0x0400925D RID: 37469
		internal static int __PropertyOffset_NoiseScale;

		// Token: 0x0400925E RID: 37470
		internal static int __PropertyOffset_NoiseMax;
	}
}
