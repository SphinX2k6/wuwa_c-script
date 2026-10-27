using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001415 RID: 5141
	[UnrealObjectPath("/Script/GeometryCache.GeometryCacheTrackStreamable")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UGeometryCacheTrackStreamable : UGeometryCacheTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012C40 RID: 76864 RVA: 0x001B9CD7 File Offset: 0x001B7ED7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGeometryCacheTrackStreamable._ClassPtr;
		}

		// Token: 0x06012C41 RID: 76865 RVA: 0x001B9CE4 File Offset: 0x001B7EE4
		public UGeometryCacheTrackStreamable() : this(BuiltinUtils.AllocNativeUObject(UGeometryCacheTrackStreamable.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012C42 RID: 76866 RVA: 0x001B9D0C File Offset: 0x001B7F0C
		[NullableContext(1)]
		public UGeometryCacheTrackStreamable(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGeometryCacheTrackStreamable.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170048B4 RID: 18612
		// (get) Token: 0x06012C43 RID: 76867 RVA: 0x001B9D3F File Offset: 0x001B7F3F
		// (set) Token: 0x06012C44 RID: 76868 RVA: 0x001B9D53 File Offset: 0x001B7F53
		[Nullable(2)]
		public unsafe UGeometryCacheCodecBase Codec
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGeometryCacheCodecBase>(base.NativePtr / (IntPtr)sizeof(void*) + UGeometryCacheTrackStreamable.__PropertyOffset_Codec);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UGeometryCacheTrackStreamable.__PropertyOffset_Codec, value);
			}
		}

		// Token: 0x170048B5 RID: 18613
		// (get) Token: 0x06012C45 RID: 76869 RVA: 0x001B9D68 File Offset: 0x001B7F68
		// (set) Token: 0x06012C46 RID: 76870 RVA: 0x001B9D78 File Offset: 0x001B7F78
		public unsafe float StartSampleTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCacheTrackStreamable.__PropertyOffset_StartSampleTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCacheTrackStreamable.__PropertyOffset_StartSampleTime) = value;
			}
		}

		// Token: 0x06012C47 RID: 76871 RVA: 0x001B9D89 File Offset: 0x001B7F89
		static UGeometryCacheTrackStreamable()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GeometryCache.GeometryCacheTrackStreamable");
		}

		// Token: 0x06012C48 RID: 76872 RVA: 0x001B9D97 File Offset: 0x001B7F97
		protected UGeometryCacheTrackStreamable(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A072 RID: 41074
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GeometryCache.GeometryCacheTrackStreamable";

		// Token: 0x0400A073 RID: 41075
		private static IntPtr _ClassPtr;

		// Token: 0x0400A074 RID: 41076
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A075 RID: 41077
		internal static int __PropertyOffset_Codec;

		// Token: 0x0400A076 RID: 41078
		internal static int __PropertyOffset_StartSampleTime;
	}
}
