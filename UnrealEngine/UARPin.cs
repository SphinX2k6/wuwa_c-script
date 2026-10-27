using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003B4 RID: 948
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AugmentedReality.ARPin")]
	[UnrealStructLayout(240, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UARPin : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003475 RID: 13429 RVA: 0x000502C2 File Offset: 0x0004E4C2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UARPin._ClassPtr;
		}

		// Token: 0x06003476 RID: 13430 RVA: 0x000502D0 File Offset: 0x0004E4D0
		public UARPin() : this(BuiltinUtils.AllocNativeUObject(UARPin.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003477 RID: 13431 RVA: 0x000502F8 File Offset: 0x0004E4F8
		[NullableContext(1)]
		public UARPin(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UARPin.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x06003478 RID: 13432 RVA: 0x0005032B File Offset: 0x0004E52B
		// (set) Token: 0x06003479 RID: 13433 RVA: 0x0005033F File Offset: 0x0004E53F
		public unsafe UARTrackedGeometry TrackedGeometry
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UARTrackedGeometry>(base.NativePtr / (IntPtr)sizeof(void*) + UARPin.__PropertyOffset_TrackedGeometry);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UARPin.__PropertyOffset_TrackedGeometry, value);
			}
		}

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x0600347A RID: 13434 RVA: 0x00050354 File Offset: 0x0004E554
		// (set) Token: 0x0600347B RID: 13435 RVA: 0x00050368 File Offset: 0x0004E568
		public unsafe USceneComponent PinnedComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UARPin.__PropertyOffset_PinnedComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UARPin.__PropertyOffset_PinnedComponent, value);
			}
		}

		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x0600347C RID: 13436 RVA: 0x0005037D File Offset: 0x0004E57D
		// (set) Token: 0x0600347D RID: 13437 RVA: 0x00050391 File Offset: 0x0004E591
		public unsafe FTransform LocalToTrackingTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARPin.__PropertyOffset_LocalToTrackingTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARPin.__PropertyOffset_LocalToTrackingTransform) = value;
			}
		}

		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x0600347E RID: 13438 RVA: 0x000503A6 File Offset: 0x0004E5A6
		// (set) Token: 0x0600347F RID: 13439 RVA: 0x000503BA File Offset: 0x0004E5BA
		public unsafe FTransform LocalToAlignedTrackingTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARPin.__PropertyOffset_LocalToAlignedTrackingTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARPin.__PropertyOffset_LocalToAlignedTrackingTransform) = value;
			}
		}

		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x06003480 RID: 13440 RVA: 0x000503CF File Offset: 0x0004E5CF
		// (set) Token: 0x06003481 RID: 13441 RVA: 0x000503DF File Offset: 0x0004E5DF
		public unsafe EARTrackingState TrackingState
		{
			get
			{
				return (EARTrackingState)(*(base.NativePtr + (IntPtr)UARPin.__PropertyOffset_TrackingState));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARPin.__PropertyOffset_TrackingState) = (byte)value;
			}
		}

		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x06003482 RID: 13442 RVA: 0x000503F0 File Offset: 0x0004E5F0
		// (set) Token: 0x06003483 RID: 13443 RVA: 0x00050429 File Offset: 0x0004E629
		[Nullable(1)]
		public FOnARTrackingStateChanged OnARTrackingStateChanged
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnARTrackingStateChanged result;
				if ((result = this._OnARTrackingStateChanged) == null)
				{
					result = (this._OnARTrackingStateChanged = new FOnARTrackingStateChanged(base.NativePtr + (IntPtr)UARPin.__PropertyOffset_OnARTrackingStateChanged, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UARPin.__PropertyOffset_OnARTrackingStateChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x06003484 RID: 13444 RVA: 0x0005044C File Offset: 0x0004E64C
		// (set) Token: 0x06003485 RID: 13445 RVA: 0x00050485 File Offset: 0x0004E685
		[Nullable(1)]
		public FOnARTransformUpdated OnARTransformUpdated
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnARTransformUpdated result;
				if ((result = this._OnARTransformUpdated) == null)
				{
					result = (this._OnARTransformUpdated = new FOnARTransformUpdated(base.NativePtr + (IntPtr)UARPin.__PropertyOffset_OnARTransformUpdated, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UARPin.__PropertyOffset_OnARTransformUpdated, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06003486 RID: 13446 RVA: 0x000504A6 File Offset: 0x0004E6A6
		public EARTrackingState GetTrackingState()
		{
			return UARPin.__GetTrackingState_Internal(base.NativePtr);
		}

		// Token: 0x06003487 RID: 13447 RVA: 0x000504B3 File Offset: 0x0004E6B3
		public UARTrackedGeometry GetTrackedGeometry()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UARTrackedGeometry>(UARPin.__GetTrackedGeometry_Internal(base.NativePtr));
		}

		// Token: 0x06003488 RID: 13448 RVA: 0x000504C5 File Offset: 0x0004E6C5
		public USceneComponent GetPinnedComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USceneComponent>(UARPin.__GetPinnedComponent_Internal(base.NativePtr));
		}

		// Token: 0x06003489 RID: 13449 RVA: 0x000504D7 File Offset: 0x0004E6D7
		public FTransform GetLocalToWorldTransform()
		{
			return UARPin.__GetLocalToWorldTransform_Internal(base.NativePtr);
		}

		// Token: 0x0600348A RID: 13450 RVA: 0x000504E4 File Offset: 0x0004E6E4
		public FTransform GetLocalToTrackingTransform()
		{
			return UARPin.__GetLocalToTrackingTransform_Internal(base.NativePtr);
		}

		// Token: 0x0600348B RID: 13451 RVA: 0x000504F1 File Offset: 0x0004E6F1
		public FName GetDebugName()
		{
			return UARPin.__GetDebugName_Internal(base.NativePtr);
		}

		// Token: 0x0600348C RID: 13452 RVA: 0x000504FE File Offset: 0x0004E6FE
		public void DebugDraw(UWorld World, in FLinearColor Color, float Scale, float PersistForSeconds)
		{
			UARPin.__DebugDraw_Internal(base.NativePtr, (World != null) ? World.NativePtr : IntPtr.Zero, Color, Scale, PersistForSeconds);
		}

		// Token: 0x0600348D RID: 13453
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EARTrackingState __GetTrackingState_Internal(IntPtr @this);

		// Token: 0x0600348E RID: 13454
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTrackedGeometry_Internal(IntPtr @this);

		// Token: 0x0600348F RID: 13455
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPinnedComponent_Internal(IntPtr @this);

		// Token: 0x06003490 RID: 13456
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetLocalToWorldTransform_Internal(IntPtr @this);

		// Token: 0x06003491 RID: 13457
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetLocalToTrackingTransform_Internal(IntPtr @this);

		// Token: 0x06003492 RID: 13458
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetDebugName_Internal(IntPtr @this);

		// Token: 0x06003493 RID: 13459
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DebugDraw_Internal(IntPtr @this, IntPtr World, in FLinearColor Color, float Scale, float PersistForSeconds);

		// Token: 0x06003494 RID: 13460 RVA: 0x0005051F File Offset: 0x0004E71F
		static UARPin()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARPin");
		}

		// Token: 0x06003495 RID: 13461 RVA: 0x0005052D File Offset: 0x0004E72D
		protected UARPin(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040016C4 RID: 5828
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AugmentedReality.ARPin";

		// Token: 0x040016C5 RID: 5829
		private static IntPtr _ClassPtr;

		// Token: 0x040016C6 RID: 5830
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040016C7 RID: 5831
		internal static int __PropertyOffset_TrackedGeometry;

		// Token: 0x040016C8 RID: 5832
		internal static int __PropertyOffset_PinnedComponent;

		// Token: 0x040016C9 RID: 5833
		internal static int __PropertyOffset_LocalToTrackingTransform;

		// Token: 0x040016CA RID: 5834
		internal static int __PropertyOffset_LocalToAlignedTrackingTransform;

		// Token: 0x040016CB RID: 5835
		internal static int __PropertyOffset_TrackingState;

		// Token: 0x040016CC RID: 5836
		internal static int __PropertyOffset_OnARTrackingStateChanged;

		// Token: 0x040016CD RID: 5837
		private FOnARTrackingStateChanged _OnARTrackingStateChanged;

		// Token: 0x040016CE RID: 5838
		internal static int __PropertyOffset_OnARTransformUpdated;

		// Token: 0x040016CF RID: 5839
		private FOnARTransformUpdated _OnARTransformUpdated;
	}
}
