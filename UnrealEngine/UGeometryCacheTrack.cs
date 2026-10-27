using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001414 RID: 5140
	[UnrealObjectPath("/Script/GeometryCache.GeometryCacheTrack")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UGeometryCacheTrack : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012C31 RID: 76849 RVA: 0x001B9B99 File Offset: 0x001B7D99
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGeometryCacheTrack._ClassPtr;
		}

		// Token: 0x06012C32 RID: 76850 RVA: 0x001B9BA8 File Offset: 0x001B7DA8
		public UGeometryCacheTrack() : this(BuiltinUtils.AllocNativeUObject(UGeometryCacheTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012C33 RID: 76851 RVA: 0x001B9BD0 File Offset: 0x001B7DD0
		[NullableContext(1)]
		public UGeometryCacheTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGeometryCacheTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170048AF RID: 18607
		// (get) Token: 0x06012C34 RID: 76852 RVA: 0x001B9C03 File Offset: 0x001B7E03
		// (set) Token: 0x06012C35 RID: 76853 RVA: 0x001B9C13 File Offset: 0x001B7E13
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCacheTrack.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCacheTrack.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x170048B0 RID: 18608
		// (get) Token: 0x06012C36 RID: 76854 RVA: 0x001B9C24 File Offset: 0x001B7E24
		// (set) Token: 0x06012C37 RID: 76855 RVA: 0x001B9C34 File Offset: 0x001B7E34
		public unsafe int MaxNumVertices
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCacheTrack.__PropertyOffset_MaxNumVertices);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCacheTrack.__PropertyOffset_MaxNumVertices) = value;
			}
		}

		// Token: 0x170048B1 RID: 18609
		// (get) Token: 0x06012C38 RID: 76856 RVA: 0x001B9C45 File Offset: 0x001B7E45
		// (set) Token: 0x06012C39 RID: 76857 RVA: 0x001B9C59 File Offset: 0x001B7E59
		public unsafe FVector2D LimitPosX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCacheTrack.__PropertyOffset_LimitPosX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCacheTrack.__PropertyOffset_LimitPosX) = value;
			}
		}

		// Token: 0x170048B2 RID: 18610
		// (get) Token: 0x06012C3A RID: 76858 RVA: 0x001B9C6E File Offset: 0x001B7E6E
		// (set) Token: 0x06012C3B RID: 76859 RVA: 0x001B9C82 File Offset: 0x001B7E82
		public unsafe FVector2D LimitPosY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCacheTrack.__PropertyOffset_LimitPosY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCacheTrack.__PropertyOffset_LimitPosY) = value;
			}
		}

		// Token: 0x170048B3 RID: 18611
		// (get) Token: 0x06012C3C RID: 76860 RVA: 0x001B9C97 File Offset: 0x001B7E97
		// (set) Token: 0x06012C3D RID: 76861 RVA: 0x001B9CAB File Offset: 0x001B7EAB
		public unsafe FVector2D LimitPosZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCacheTrack.__PropertyOffset_LimitPosZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCacheTrack.__PropertyOffset_LimitPosZ) = value;
			}
		}

		// Token: 0x06012C3E RID: 76862 RVA: 0x001B9CC0 File Offset: 0x001B7EC0
		static UGeometryCacheTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GeometryCache.GeometryCacheTrack");
		}

		// Token: 0x06012C3F RID: 76863 RVA: 0x001B9CCE File Offset: 0x001B7ECE
		protected UGeometryCacheTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A06A RID: 41066
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GeometryCache.GeometryCacheTrack";

		// Token: 0x0400A06B RID: 41067
		private static IntPtr _ClassPtr;

		// Token: 0x0400A06C RID: 41068
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A06D RID: 41069
		internal static int __PropertyOffset_Duration;

		// Token: 0x0400A06E RID: 41070
		internal static int __PropertyOffset_MaxNumVertices;

		// Token: 0x0400A06F RID: 41071
		internal static int __PropertyOffset_LimitPosX;

		// Token: 0x0400A070 RID: 41072
		internal static int __PropertyOffset_LimitPosY;

		// Token: 0x0400A071 RID: 41073
		internal static int __PropertyOffset_LimitPosZ;
	}
}
