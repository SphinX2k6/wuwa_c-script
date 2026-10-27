using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003D2 RID: 978
	[UnrealObjectPath("/Script/AugmentedReality.ARTrackedGeometry")]
	[UnrealStructLayout(256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UARTrackedGeometry : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060036CF RID: 14031 RVA: 0x000534FD File Offset: 0x000516FD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UARTrackedGeometry._ClassPtr;
		}

		// Token: 0x060036D0 RID: 14032 RVA: 0x0005350C File Offset: 0x0005170C
		public UARTrackedGeometry() : this(BuiltinUtils.AllocNativeUObject(UARTrackedGeometry.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060036D1 RID: 14033 RVA: 0x00053534 File Offset: 0x00051734
		[NullableContext(1)]
		public UARTrackedGeometry(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UARTrackedGeometry.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x060036D2 RID: 14034 RVA: 0x00053567 File Offset: 0x00051767
		// (set) Token: 0x060036D3 RID: 14035 RVA: 0x0005357B File Offset: 0x0005177B
		public unsafe FGuid UniqueId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARTrackedGeometry.__PropertyOffset_UniqueId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARTrackedGeometry.__PropertyOffset_UniqueId) = value;
			}
		}

		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x060036D4 RID: 14036 RVA: 0x00053590 File Offset: 0x00051790
		// (set) Token: 0x060036D5 RID: 14037 RVA: 0x000535A4 File Offset: 0x000517A4
		public unsafe FTransform LocalToTrackingTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARTrackedGeometry.__PropertyOffset_LocalToTrackingTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARTrackedGeometry.__PropertyOffset_LocalToTrackingTransform) = value;
			}
		}

		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x060036D6 RID: 14038 RVA: 0x000535B9 File Offset: 0x000517B9
		// (set) Token: 0x060036D7 RID: 14039 RVA: 0x000535CD File Offset: 0x000517CD
		public unsafe FTransform LocalToAlignedTrackingTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARTrackedGeometry.__PropertyOffset_LocalToAlignedTrackingTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARTrackedGeometry.__PropertyOffset_LocalToAlignedTrackingTransform) = value;
			}
		}

		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x060036D8 RID: 14040 RVA: 0x000535E2 File Offset: 0x000517E2
		// (set) Token: 0x060036D9 RID: 14041 RVA: 0x000535F2 File Offset: 0x000517F2
		public unsafe EARTrackingState TrackingState
		{
			get
			{
				return (EARTrackingState)(*(base.NativePtr + (IntPtr)UARTrackedGeometry.__PropertyOffset_TrackingState));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARTrackedGeometry.__PropertyOffset_TrackingState) = (byte)value;
			}
		}

		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x060036DA RID: 14042 RVA: 0x00053603 File Offset: 0x00051803
		// (set) Token: 0x060036DB RID: 14043 RVA: 0x00053617 File Offset: 0x00051817
		[Nullable(2)]
		public unsafe UMRMeshComponent UnderlyingMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMRMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UARTrackedGeometry.__PropertyOffset_UnderlyingMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UARTrackedGeometry.__PropertyOffset_UnderlyingMesh, value);
			}
		}

		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x060036DC RID: 14044 RVA: 0x0005362C File Offset: 0x0005182C
		// (set) Token: 0x060036DD RID: 14045 RVA: 0x0005363C File Offset: 0x0005183C
		public unsafe EARObjectClassification ObjectClassification
		{
			get
			{
				return (EARObjectClassification)(*(base.NativePtr + (IntPtr)UARTrackedGeometry.__PropertyOffset_ObjectClassification));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARTrackedGeometry.__PropertyOffset_ObjectClassification) = (byte)value;
			}
		}

		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x060036DE RID: 14046 RVA: 0x0005364D File Offset: 0x0005184D
		// (set) Token: 0x060036DF RID: 14047 RVA: 0x0005365D File Offset: 0x0005185D
		public unsafe int LastUpdateFrameNumber
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARTrackedGeometry.__PropertyOffset_LastUpdateFrameNumber);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARTrackedGeometry.__PropertyOffset_LastUpdateFrameNumber) = value;
			}
		}

		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x060036E0 RID: 14048 RVA: 0x0005366E File Offset: 0x0005186E
		// (set) Token: 0x060036E1 RID: 14049 RVA: 0x00053682 File Offset: 0x00051882
		public unsafe FName DebugName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARTrackedGeometry.__PropertyOffset_DebugName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARTrackedGeometry.__PropertyOffset_DebugName) = value;
			}
		}

		// Token: 0x060036E2 RID: 14050 RVA: 0x00053697 File Offset: 0x00051897
		public bool IsTracked()
		{
			return UARTrackedGeometry.__IsTracked_Internal(base.NativePtr);
		}

		// Token: 0x060036E3 RID: 14051 RVA: 0x000536A4 File Offset: 0x000518A4
		[NullableContext(2)]
		public UMRMeshComponent GetUnderlyingMesh()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMRMeshComponent>(UARTrackedGeometry.__GetUnderlyingMesh_Internal(base.NativePtr));
		}

		// Token: 0x060036E4 RID: 14052 RVA: 0x000536B6 File Offset: 0x000518B6
		public EARTrackingState GetTrackingState()
		{
			return UARTrackedGeometry.__GetTrackingState_Internal(base.NativePtr);
		}

		// Token: 0x060036E5 RID: 14053 RVA: 0x000536C3 File Offset: 0x000518C3
		public EARObjectClassification GetObjectClassification()
		{
			return UARTrackedGeometry.__GetObjectClassification_Internal(base.NativePtr);
		}

		// Token: 0x060036E6 RID: 14054 RVA: 0x000536D0 File Offset: 0x000518D0
		[NullableContext(1)]
		public new string GetName()
		{
			return FString.ToStringAndDeleteNativePtr(UARTrackedGeometry.__GetName_Internal(base.NativePtr));
		}

		// Token: 0x060036E7 RID: 14055 RVA: 0x000536E2 File Offset: 0x000518E2
		public FTransform GetLocalToWorldTransform()
		{
			return UARTrackedGeometry.__GetLocalToWorldTransform_Internal(base.NativePtr);
		}

		// Token: 0x060036E8 RID: 14056 RVA: 0x000536EF File Offset: 0x000518EF
		public FTransform GetLocalToTrackingTransform()
		{
			return UARTrackedGeometry.__GetLocalToTrackingTransform_Internal(base.NativePtr);
		}

		// Token: 0x060036E9 RID: 14057 RVA: 0x000536FC File Offset: 0x000518FC
		public float GetLastUpdateTimestamp()
		{
			return UARTrackedGeometry.__GetLastUpdateTimestamp_Internal(base.NativePtr);
		}

		// Token: 0x060036EA RID: 14058 RVA: 0x00053709 File Offset: 0x00051909
		public int GetLastUpdateFrameNumber()
		{
			return UARTrackedGeometry.__GetLastUpdateFrameNumber_Internal(base.NativePtr);
		}

		// Token: 0x060036EB RID: 14059 RVA: 0x00053716 File Offset: 0x00051916
		public FName GetDebugName()
		{
			return UARTrackedGeometry.__GetDebugName_Internal(base.NativePtr);
		}

		// Token: 0x060036EC RID: 14060
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsTracked_Internal(IntPtr @this);

		// Token: 0x060036ED RID: 14061
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetUnderlyingMesh_Internal(IntPtr @this);

		// Token: 0x060036EE RID: 14062
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EARTrackingState __GetTrackingState_Internal(IntPtr @this);

		// Token: 0x060036EF RID: 14063
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EARObjectClassification __GetObjectClassification_Internal(IntPtr @this);

		// Token: 0x060036F0 RID: 14064
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetName_Internal(IntPtr @this);

		// Token: 0x060036F1 RID: 14065
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetLocalToWorldTransform_Internal(IntPtr @this);

		// Token: 0x060036F2 RID: 14066
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetLocalToTrackingTransform_Internal(IntPtr @this);

		// Token: 0x060036F3 RID: 14067
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetLastUpdateTimestamp_Internal(IntPtr @this);

		// Token: 0x060036F4 RID: 14068
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetLastUpdateFrameNumber_Internal(IntPtr @this);

		// Token: 0x060036F5 RID: 14069
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetDebugName_Internal(IntPtr @this);

		// Token: 0x060036F6 RID: 14070 RVA: 0x00053723 File Offset: 0x00051923
		static UARTrackedGeometry()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARTrackedGeometry");
		}

		// Token: 0x060036F7 RID: 14071 RVA: 0x00053731 File Offset: 0x00051931
		protected UARTrackedGeometry(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040017CA RID: 6090
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AugmentedReality.ARTrackedGeometry";

		// Token: 0x040017CB RID: 6091
		private static IntPtr _ClassPtr;

		// Token: 0x040017CC RID: 6092
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040017CD RID: 6093
		internal static int __PropertyOffset_UniqueId;

		// Token: 0x040017CE RID: 6094
		internal static int __PropertyOffset_LocalToTrackingTransform;

		// Token: 0x040017CF RID: 6095
		internal static int __PropertyOffset_LocalToAlignedTrackingTransform;

		// Token: 0x040017D0 RID: 6096
		internal static int __PropertyOffset_TrackingState;

		// Token: 0x040017D1 RID: 6097
		internal static int __PropertyOffset_UnderlyingMesh;

		// Token: 0x040017D2 RID: 6098
		internal static int __PropertyOffset_ObjectClassification;

		// Token: 0x040017D3 RID: 6099
		internal static int __PropertyOffset_LastUpdateFrameNumber;

		// Token: 0x040017D4 RID: 6100
		internal static int __PropertyOffset_DebugName;
	}
}
