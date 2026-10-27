using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001835 RID: 6197
	[UnrealObjectPath("/Script/KuroFastCollision.KuroFastCollisionShapeComponent")]
	[UnrealStructLayout(400, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 400)]
	public class UKuroFastCollisionShapeComponent : UActorComponent, IUnrealUObject, IUnrealObject, IKuroFastCollisionInterface_Shape, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06016D70 RID: 93552 RVA: 0x00215909 File Offset: 0x00213B09
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroFastCollisionShapeComponent._ClassPtr;
		}

		// Token: 0x06016D71 RID: 93553 RVA: 0x00215915 File Offset: 0x00213B15
		int IKuroFastCollisionInterface_Shape.InterfaceOffset()
		{
			return UKuroFastCollisionShapeComponent.__InterfaceOffset_IKuroFastCollisionInterface_Shape;
		}

		// Token: 0x06016D72 RID: 93554 RVA: 0x0021591C File Offset: 0x00213B1C
		public UKuroFastCollisionShapeComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroFastCollisionShapeComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016D73 RID: 93555 RVA: 0x00215944 File Offset: 0x00213B44
		[NullableContext(1)]
		public UKuroFastCollisionShapeComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroFastCollisionShapeComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005C20 RID: 23584
		// (get) Token: 0x06016D74 RID: 93556 RVA: 0x00215977 File Offset: 0x00213B77
		// (set) Token: 0x06016D75 RID: 93557 RVA: 0x00215987 File Offset: 0x00213B87
		public unsafe EKuroFastCollisionCenterSource CenterSource
		{
			get
			{
				return (EKuroFastCollisionCenterSource)(*(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_CenterSource));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_CenterSource) = (byte)value;
			}
		}

		// Token: 0x17005C21 RID: 23585
		// (get) Token: 0x06016D76 RID: 93558 RVA: 0x00215998 File Offset: 0x00213B98
		// (set) Token: 0x06016D77 RID: 93559 RVA: 0x002159AC File Offset: 0x00213BAC
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<USceneComponent> SceneComponent
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_SceneComponent);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_SceneComponent) = value;
			}
		}

		// Token: 0x17005C22 RID: 23586
		// (get) Token: 0x06016D78 RID: 93560 RVA: 0x002159C1 File Offset: 0x00213BC1
		// (set) Token: 0x06016D79 RID: 93561 RVA: 0x002159D1 File Offset: 0x00213BD1
		public unsafe EKuroFastCollisionRotationSource RotationSource
		{
			get
			{
				return (EKuroFastCollisionRotationSource)(*(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_RotationSource));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_RotationSource) = (byte)value;
			}
		}

		// Token: 0x17005C23 RID: 23587
		// (get) Token: 0x06016D7A RID: 93562 RVA: 0x002159E2 File Offset: 0x00213BE2
		// (set) Token: 0x06016D7B RID: 93563 RVA: 0x002159F6 File Offset: 0x00213BF6
		public unsafe FVector RelativeLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_RelativeLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_RelativeLocation) = value;
			}
		}

		// Token: 0x17005C24 RID: 23588
		// (get) Token: 0x06016D7C RID: 93564 RVA: 0x00215A0B File Offset: 0x00213C0B
		// (set) Token: 0x06016D7D RID: 93565 RVA: 0x00215A1F File Offset: 0x00213C1F
		public unsafe FRotator RelativeRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_RelativeRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_RelativeRotation) = value;
			}
		}

		// Token: 0x17005C25 RID: 23589
		// (get) Token: 0x06016D7E RID: 93566 RVA: 0x00215A34 File Offset: 0x00213C34
		// (set) Token: 0x06016D7F RID: 93567 RVA: 0x00215A44 File Offset: 0x00213C44
		public unsafe ECollisionShapeKind Kind
		{
			get
			{
				return (ECollisionShapeKind)(*(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_Kind));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_Kind) = (byte)value;
			}
		}

		// Token: 0x17005C26 RID: 23590
		// (get) Token: 0x06016D80 RID: 93568 RVA: 0x00215A55 File Offset: 0x00213C55
		// (set) Token: 0x06016D81 RID: 93569 RVA: 0x00215A69 File Offset: 0x00213C69
		public unsafe FVector Center_Manual
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_Center_Manual);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_Center_Manual) = value;
			}
		}

		// Token: 0x17005C27 RID: 23591
		// (get) Token: 0x06016D82 RID: 93570 RVA: 0x00215A7E File Offset: 0x00213C7E
		// (set) Token: 0x06016D83 RID: 93571 RVA: 0x00215A8E File Offset: 0x00213C8E
		public unsafe bool bEnableCCD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_bEnableCCD) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_bEnableCCD) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005C28 RID: 23592
		// (get) Token: 0x06016D84 RID: 93572 RVA: 0x00215A9F File Offset: 0x00213C9F
		// (set) Token: 0x06016D85 RID: 93573 RVA: 0x00215AB3 File Offset: 0x00213CB3
		public unsafe TEnumAsByte<ECollisionChannel> Channel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_Channel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_Channel) = value;
			}
		}

		// Token: 0x17005C29 RID: 23593
		// (get) Token: 0x06016D86 RID: 93574 RVA: 0x00215AC8 File Offset: 0x00213CC8
		// (set) Token: 0x06016D87 RID: 93575 RVA: 0x00215AD8 File Offset: 0x00213CD8
		public unsafe int QueryMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_QueryMask);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_QueryMask) = value;
			}
		}

		// Token: 0x17005C2A RID: 23594
		// (get) Token: 0x06016D88 RID: 93576 RVA: 0x00215AE9 File Offset: 0x00213CE9
		// (set) Token: 0x06016D89 RID: 93577 RVA: 0x00215AF9 File Offset: 0x00213CF9
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x17005C2B RID: 23595
		// (get) Token: 0x06016D8A RID: 93578 RVA: 0x00215B0A File Offset: 0x00213D0A
		// (set) Token: 0x06016D8B RID: 93579 RVA: 0x00215B1E File Offset: 0x00213D1E
		public unsafe FVector HalfExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_HalfExtent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_HalfExtent) = value;
			}
		}

		// Token: 0x17005C2C RID: 23596
		// (get) Token: 0x06016D8C RID: 93580 RVA: 0x00215B33 File Offset: 0x00213D33
		// (set) Token: 0x06016D8D RID: 93581 RVA: 0x00215B47 File Offset: 0x00213D47
		public unsafe FQuat BoxRot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_BoxRot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_BoxRot) = value;
			}
		}

		// Token: 0x17005C2D RID: 23597
		// (get) Token: 0x06016D8E RID: 93582 RVA: 0x00215B5C File Offset: 0x00213D5C
		// (set) Token: 0x06016D8F RID: 93583 RVA: 0x00215B70 File Offset: 0x00213D70
		public unsafe FVector Axis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_Axis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_Axis) = value;
			}
		}

		// Token: 0x17005C2E RID: 23598
		// (get) Token: 0x06016D90 RID: 93584 RVA: 0x00215B85 File Offset: 0x00213D85
		// (set) Token: 0x06016D91 RID: 93585 RVA: 0x00215B95 File Offset: 0x00213D95
		public unsafe float HalfLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_HalfLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_HalfLength) = value;
			}
		}

		// Token: 0x17005C2F RID: 23599
		// (get) Token: 0x06016D92 RID: 93586 RVA: 0x00215BA6 File Offset: 0x00213DA6
		// (set) Token: 0x06016D93 RID: 93587 RVA: 0x00215BBA File Offset: 0x00213DBA
		public unsafe FVector ConeAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_ConeAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_ConeAxis) = value;
			}
		}

		// Token: 0x17005C30 RID: 23600
		// (get) Token: 0x06016D94 RID: 93588 RVA: 0x00215BCF File Offset: 0x00213DCF
		// (set) Token: 0x06016D95 RID: 93589 RVA: 0x00215BDF File Offset: 0x00213DDF
		public unsafe float ConeHalfAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_ConeHalfAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_ConeHalfAngle) = value;
			}
		}

		// Token: 0x17005C31 RID: 23601
		// (get) Token: 0x06016D96 RID: 93590 RVA: 0x00215BF0 File Offset: 0x00213DF0
		// (set) Token: 0x06016D97 RID: 93591 RVA: 0x00215C00 File Offset: 0x00213E00
		public unsafe float ConeHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_ConeHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_ConeHeight) = value;
			}
		}

		// Token: 0x17005C32 RID: 23602
		// (get) Token: 0x06016D98 RID: 93592 RVA: 0x00215C14 File Offset: 0x00213E14
		// (set) Token: 0x06016D99 RID: 93593 RVA: 0x00215C4D File Offset: 0x00213E4D
		[Nullable(1)]
		public FKuroFastCollisionOverlapSignature OnKFCBeginOverlap
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroFastCollisionOverlapSignature result;
				if ((result = this._OnKFCBeginOverlap) == null)
				{
					result = (this._OnKFCBeginOverlap = new FKuroFastCollisionOverlapSignature(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_OnKFCBeginOverlap, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_OnKFCBeginOverlap, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17005C33 RID: 23603
		// (get) Token: 0x06016D9A RID: 93594 RVA: 0x00215C70 File Offset: 0x00213E70
		// (set) Token: 0x06016D9B RID: 93595 RVA: 0x00215CA9 File Offset: 0x00213EA9
		[Nullable(1)]
		public FKuroFastCollisionOverlapSignature OnKFCEndOverlap
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroFastCollisionOverlapSignature result;
				if ((result = this._OnKFCEndOverlap) == null)
				{
					result = (this._OnKFCEndOverlap = new FKuroFastCollisionOverlapSignature(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_OnKFCEndOverlap, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_OnKFCEndOverlap, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06016D9C RID: 93596 RVA: 0x00215CCA File Offset: 0x00213ECA
		static UKuroFastCollisionShapeComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroFastCollision.KuroFastCollisionShapeComponent");
		}

		// Token: 0x06016D9D RID: 93597 RVA: 0x00215CD8 File Offset: 0x00213ED8
		protected UKuroFastCollisionShapeComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C6A9 RID: 50857
		internal static int __InterfaceOffset_IKuroFastCollisionInterface_Shape;

		// Token: 0x0400C6AA RID: 50858
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroFastCollision.KuroFastCollisionShapeComponent";

		// Token: 0x0400C6AB RID: 50859
		private static IntPtr _ClassPtr;

		// Token: 0x0400C6AC RID: 50860
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C6AD RID: 50861
		internal static int __PropertyOffset_CenterSource;

		// Token: 0x0400C6AE RID: 50862
		internal static int __PropertyOffset_SceneComponent;

		// Token: 0x0400C6AF RID: 50863
		internal static int __PropertyOffset_RotationSource;

		// Token: 0x0400C6B0 RID: 50864
		internal static int __PropertyOffset_RelativeLocation;

		// Token: 0x0400C6B1 RID: 50865
		internal static int __PropertyOffset_RelativeRotation;

		// Token: 0x0400C6B2 RID: 50866
		internal static int __PropertyOffset_Kind;

		// Token: 0x0400C6B3 RID: 50867
		internal static int __PropertyOffset_Center_Manual;

		// Token: 0x0400C6B4 RID: 50868
		internal static int __PropertyOffset_bEnableCCD;

		// Token: 0x0400C6B5 RID: 50869
		internal static int __PropertyOffset_Channel;

		// Token: 0x0400C6B6 RID: 50870
		internal static int __PropertyOffset_QueryMask;

		// Token: 0x0400C6B7 RID: 50871
		internal static int __PropertyOffset_Radius;

		// Token: 0x0400C6B8 RID: 50872
		internal static int __PropertyOffset_HalfExtent;

		// Token: 0x0400C6B9 RID: 50873
		internal static int __PropertyOffset_BoxRot;

		// Token: 0x0400C6BA RID: 50874
		internal static int __PropertyOffset_Axis;

		// Token: 0x0400C6BB RID: 50875
		internal static int __PropertyOffset_HalfLength;

		// Token: 0x0400C6BC RID: 50876
		internal static int __PropertyOffset_ConeAxis;

		// Token: 0x0400C6BD RID: 50877
		internal static int __PropertyOffset_ConeHalfAngle;

		// Token: 0x0400C6BE RID: 50878
		internal static int __PropertyOffset_ConeHeight;

		// Token: 0x0400C6BF RID: 50879
		internal static int __PropertyOffset_OnKFCBeginOverlap;

		// Token: 0x0400C6C0 RID: 50880
		[Nullable(2)]
		private FKuroFastCollisionOverlapSignature _OnKFCBeginOverlap;

		// Token: 0x0400C6C1 RID: 50881
		internal static int __PropertyOffset_OnKFCEndOverlap;

		// Token: 0x0400C6C2 RID: 50882
		[Nullable(2)]
		private FKuroFastCollisionOverlapSignature _OnKFCEndOverlap;
	}
}
