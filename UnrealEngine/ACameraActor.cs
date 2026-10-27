using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000906 RID: 2310
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CameraActor")]
	[UnrealStructLayout(3680, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3680)]
	public class ACameraActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007EBD RID: 32445 RVA: 0x000B5D20 File Offset: 0x000B3F20
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ACameraActor._ClassPtr;
		}

		// Token: 0x06007EBE RID: 32446 RVA: 0x000B5D2C File Offset: 0x000B3F2C
		public ACameraActor() : this(BuiltinUtils.AllocNativeUObject(ACameraActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007EBF RID: 32447 RVA: 0x000B5D54 File Offset: 0x000B3F54
		[NullableContext(1)]
		public ACameraActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ACameraActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001DC7 RID: 7623
		// (get) Token: 0x06007EC0 RID: 32448 RVA: 0x000B5D87 File Offset: 0x000B3F87
		// (set) Token: 0x06007EC1 RID: 32449 RVA: 0x000B5D9B File Offset: 0x000B3F9B
		[Nullable(0)]
		public unsafe TEnumAsByte<EAutoReceiveInput> AutoActivateForPlayer
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)ACameraActor.__PropertyOffset_AutoActivateForPlayer);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)ACameraActor.__PropertyOffset_AutoActivateForPlayer) = value;
			}
		}

		// Token: 0x17001DC8 RID: 7624
		// (get) Token: 0x06007EC2 RID: 32450 RVA: 0x000B5DB0 File Offset: 0x000B3FB0
		// (set) Token: 0x06007EC3 RID: 32451 RVA: 0x000B5DC4 File Offset: 0x000B3FC4
		public unsafe UCameraComponent CameraComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCameraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ACameraActor.__PropertyOffset_CameraComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ACameraActor.__PropertyOffset_CameraComponent, value);
			}
		}

		// Token: 0x17001DC9 RID: 7625
		// (get) Token: 0x06007EC4 RID: 32452 RVA: 0x000B5DD9 File Offset: 0x000B3FD9
		// (set) Token: 0x06007EC5 RID: 32453 RVA: 0x000B5DED File Offset: 0x000B3FED
		public unsafe USceneComponent SceneComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ACameraActor.__PropertyOffset_SceneComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ACameraActor.__PropertyOffset_SceneComponent, value);
			}
		}

		// Token: 0x17001DCA RID: 7626
		// (get) Token: 0x06007EC6 RID: 32454 RVA: 0x000B5E02 File Offset: 0x000B4002
		// (set) Token: 0x06007EC7 RID: 32455 RVA: 0x000B5E1B File Offset: 0x000B401B
		public unsafe bool bConstrainAspectRatio_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ACameraActor.__PropertyOffset_bConstrainAspectRatio_DEPRECATED) & ACameraActor.__PropertyMask_bConstrainAspectRatio_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ACameraActor.__PropertyOffset_bConstrainAspectRatio_DEPRECATED) = ((*(base.NativePtr + (IntPtr)ACameraActor.__PropertyOffset_bConstrainAspectRatio_DEPRECATED) & ~ACameraActor.__PropertyMask_bConstrainAspectRatio_DEPRECATED) | (value ? ACameraActor.__PropertyMask_bConstrainAspectRatio_DEPRECATED : 0));
			}
		}

		// Token: 0x17001DCB RID: 7627
		// (get) Token: 0x06007EC8 RID: 32456 RVA: 0x000B5E4B File Offset: 0x000B404B
		// (set) Token: 0x06007EC9 RID: 32457 RVA: 0x000B5E5B File Offset: 0x000B405B
		public unsafe float AspectRatio_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACameraActor.__PropertyOffset_AspectRatio_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACameraActor.__PropertyOffset_AspectRatio_DEPRECATED) = value;
			}
		}

		// Token: 0x17001DCC RID: 7628
		// (get) Token: 0x06007ECA RID: 32458 RVA: 0x000B5E6C File Offset: 0x000B406C
		// (set) Token: 0x06007ECB RID: 32459 RVA: 0x000B5E7C File Offset: 0x000B407C
		public unsafe float FOVAngle_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACameraActor.__PropertyOffset_FOVAngle_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACameraActor.__PropertyOffset_FOVAngle_DEPRECATED) = value;
			}
		}

		// Token: 0x17001DCD RID: 7629
		// (get) Token: 0x06007ECC RID: 32460 RVA: 0x000B5E8D File Offset: 0x000B408D
		// (set) Token: 0x06007ECD RID: 32461 RVA: 0x000B5E9D File Offset: 0x000B409D
		public unsafe float PostProcessBlendWeight_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACameraActor.__PropertyOffset_PostProcessBlendWeight_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACameraActor.__PropertyOffset_PostProcessBlendWeight_DEPRECATED) = value;
			}
		}

		// Token: 0x17001DCE RID: 7630
		// (get) Token: 0x06007ECE RID: 32462 RVA: 0x000B5EB0 File Offset: 0x000B40B0
		// (set) Token: 0x06007ECF RID: 32463 RVA: 0x000B5EE9 File Offset: 0x000B40E9
		[Nullable(1)]
		public FPostProcessSettings PostProcessSettings_DEPRECATED
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FPostProcessSettings result;
				if ((result = this._PostProcessSettings_DEPRECATED) == null)
				{
					result = (this._PostProcessSettings_DEPRECATED = new FPostProcessSettings(base.NativePtr + (IntPtr)ACameraActor.__PropertyOffset_PostProcessSettings_DEPRECATED, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPostProcessSettings.StaticStruct(), base.NativePtr + (IntPtr)ACameraActor.__PropertyOffset_PostProcessSettings_DEPRECATED, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06007ED0 RID: 32464 RVA: 0x000B5F0A File Offset: 0x000B410A
		public int GetAutoActivatePlayerIndex()
		{
			return ACameraActor.__GetAutoActivatePlayerIndex_Internal(base.NativePtr);
		}

		// Token: 0x06007ED1 RID: 32465
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetAutoActivatePlayerIndex_Internal(IntPtr @this);

		// Token: 0x06007ED2 RID: 32466 RVA: 0x000B5F17 File Offset: 0x000B4117
		static ACameraActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CameraActor");
		}

		// Token: 0x06007ED3 RID: 32467 RVA: 0x000B5F25 File Offset: 0x000B4125
		protected ACameraActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003CCC RID: 15564
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.CameraActor";

		// Token: 0x04003CCD RID: 15565
		private static IntPtr _ClassPtr;

		// Token: 0x04003CCE RID: 15566
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003CCF RID: 15567
		internal static int __PropertyOffset_AutoActivateForPlayer;

		// Token: 0x04003CD0 RID: 15568
		internal static int __PropertyOffset_CameraComponent;

		// Token: 0x04003CD1 RID: 15569
		internal static int __PropertyOffset_SceneComponent;

		// Token: 0x04003CD2 RID: 15570
		internal static int __PropertyOffset_bConstrainAspectRatio_DEPRECATED;

		// Token: 0x04003CD3 RID: 15571
		internal static byte __PropertyMask_bConstrainAspectRatio_DEPRECATED;

		// Token: 0x04003CD4 RID: 15572
		internal static int __PropertyOffset_AspectRatio_DEPRECATED;

		// Token: 0x04003CD5 RID: 15573
		internal static int __PropertyOffset_FOVAngle_DEPRECATED;

		// Token: 0x04003CD6 RID: 15574
		internal static int __PropertyOffset_PostProcessBlendWeight_DEPRECATED;

		// Token: 0x04003CD7 RID: 15575
		internal static int __PropertyOffset_PostProcessSettings_DEPRECATED;

		// Token: 0x04003CD8 RID: 15576
		private FPostProcessSettings _PostProcessSettings_DEPRECATED;
	}
}
