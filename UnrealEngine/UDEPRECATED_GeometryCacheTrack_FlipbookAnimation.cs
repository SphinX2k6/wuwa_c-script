using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001416 RID: 5142
	[UnrealObjectPath("/Script/GeometryCache.GeometryCacheTrack_FlipbookAnimation")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UDEPRECATED_GeometryCacheTrack_FlipbookAnimation : UGeometryCacheTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012C49 RID: 76873 RVA: 0x001B9DA0 File Offset: 0x001B7FA0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDEPRECATED_GeometryCacheTrack_FlipbookAnimation._ClassPtr;
		}

		// Token: 0x06012C4A RID: 76874 RVA: 0x001B9DAC File Offset: 0x001B7FAC
		public UDEPRECATED_GeometryCacheTrack_FlipbookAnimation() : this(BuiltinUtils.AllocNativeUObject(UDEPRECATED_GeometryCacheTrack_FlipbookAnimation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012C4B RID: 76875 RVA: 0x001B9DD4 File Offset: 0x001B7FD4
		[NullableContext(1)]
		public UDEPRECATED_GeometryCacheTrack_FlipbookAnimation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDEPRECATED_GeometryCacheTrack_FlipbookAnimation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170048B6 RID: 18614
		// (get) Token: 0x06012C4C RID: 76876 RVA: 0x001B9E07 File Offset: 0x001B8007
		// (set) Token: 0x06012C4D RID: 76877 RVA: 0x001B9E17 File Offset: 0x001B8017
		public unsafe uint NumMeshSamples
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDEPRECATED_GeometryCacheTrack_FlipbookAnimation.__PropertyOffset_NumMeshSamples);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDEPRECATED_GeometryCacheTrack_FlipbookAnimation.__PropertyOffset_NumMeshSamples) = (int)value;
			}
		}

		// Token: 0x06012C4E RID: 76878 RVA: 0x001B9E28 File Offset: 0x001B8028
		[NullableContext(2)]
		public void AddMeshSample(in FGeometryCacheMeshData MeshData, float SampleTime)
		{
			UDEPRECATED_GeometryCacheTrack_FlipbookAnimation.__AddMeshSample_Internal(base.NativePtr, (MeshData ?? new FGeometryCacheMeshData()).NativePtr, SampleTime);
		}

		// Token: 0x06012C4F RID: 76879
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddMeshSample_Internal(IntPtr @this, IntPtr MeshData, float SampleTime);

		// Token: 0x06012C50 RID: 76880 RVA: 0x001B9E46 File Offset: 0x001B8046
		static UDEPRECATED_GeometryCacheTrack_FlipbookAnimation()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GeometryCache.GeometryCacheTrack_FlipbookAnimation");
		}

		// Token: 0x06012C51 RID: 76881 RVA: 0x001B9E54 File Offset: 0x001B8054
		protected UDEPRECATED_GeometryCacheTrack_FlipbookAnimation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A077 RID: 41079
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GeometryCache.GeometryCacheTrack_FlipbookAnimation";

		// Token: 0x0400A078 RID: 41080
		private static IntPtr _ClassPtr;

		// Token: 0x0400A079 RID: 41081
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A07A RID: 41082
		internal static int __PropertyOffset_NumMeshSamples;
	}
}
