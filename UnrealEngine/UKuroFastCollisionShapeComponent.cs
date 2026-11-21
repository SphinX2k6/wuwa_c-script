using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000381 RID: 897
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroFastCollision.KuroFastCollisionShapeComponent")]
	[UnrealStructLayout(400, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 400)]
	public class UKuroFastCollisionShapeComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005A1E RID: 23070 RVA: 0x0007F6B9 File Offset: 0x0007D8B9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroFastCollisionShapeComponent._ClassPtr;
		}

		// Token: 0x06005A1F RID: 23071 RVA: 0x0007F6C8 File Offset: 0x0007D8C8
		public UKuroFastCollisionShapeComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroFastCollisionShapeComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005A20 RID: 23072 RVA: 0x0007F6F0 File Offset: 0x0007D8F0
		public UKuroFastCollisionShapeComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroFastCollisionShapeComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170011C9 RID: 4553
		// (get) Token: 0x06005A21 RID: 23073 RVA: 0x0007F723 File Offset: 0x0007D923
		// (set) Token: 0x06005A22 RID: 23074 RVA: 0x0007F733 File Offset: 0x0007D933
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

		// Token: 0x170011CA RID: 4554
		// (get) Token: 0x06005A23 RID: 23075 RVA: 0x0007F744 File Offset: 0x0007D944
		// (set) Token: 0x06005A24 RID: 23076 RVA: 0x0007F758 File Offset: 0x0007D958
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

		// Token: 0x170011CB RID: 4555
		// (get) Token: 0x06005A25 RID: 23077 RVA: 0x0007F76D File Offset: 0x0007D96D
		// (set) Token: 0x06005A26 RID: 23078 RVA: 0x0007F77D File Offset: 0x0007D97D
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

		// Token: 0x170011CC RID: 4556
		// (get) Token: 0x06005A27 RID: 23079 RVA: 0x0007F78E File Offset: 0x0007D98E
		// (set) Token: 0x06005A28 RID: 23080 RVA: 0x0007F7A2 File Offset: 0x0007D9A2
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

		// Token: 0x170011CD RID: 4557
		// (get) Token: 0x06005A29 RID: 23081 RVA: 0x0007F7B7 File Offset: 0x0007D9B7
		// (set) Token: 0x06005A2A RID: 23082 RVA: 0x0007F7CB File Offset: 0x0007D9CB
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

		// Token: 0x170011CE RID: 4558
		// (get) Token: 0x06005A2B RID: 23083 RVA: 0x0007F7E0 File Offset: 0x0007D9E0
		// (set) Token: 0x06005A2C RID: 23084 RVA: 0x0007F7F0 File Offset: 0x0007D9F0
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

		// Token: 0x170011CF RID: 4559
		// (get) Token: 0x06005A2D RID: 23085 RVA: 0x0007F801 File Offset: 0x0007DA01
		// (set) Token: 0x06005A2E RID: 23086 RVA: 0x0007F815 File Offset: 0x0007DA15
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

		// Token: 0x170011D0 RID: 4560
		// (get) Token: 0x06005A2F RID: 23087 RVA: 0x0007F82A File Offset: 0x0007DA2A
		// (set) Token: 0x06005A30 RID: 23088 RVA: 0x0007F83A File Offset: 0x0007DA3A
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

		// Token: 0x170011D1 RID: 4561
		// (get) Token: 0x06005A31 RID: 23089 RVA: 0x0007F84B File Offset: 0x0007DA4B
		// (set) Token: 0x06005A32 RID: 23090 RVA: 0x0007F85F File Offset: 0x0007DA5F
		[Nullable(0)]
		public unsafe TEnumAsByte<ECollisionChannel> Channel
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_Channel);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_Channel) = value;
			}
		}

		// Token: 0x170011D2 RID: 4562
		// (get) Token: 0x06005A33 RID: 23091 RVA: 0x0007F874 File Offset: 0x0007DA74
		// (set) Token: 0x06005A34 RID: 23092 RVA: 0x0007F884 File Offset: 0x0007DA84
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

		// Token: 0x170011D3 RID: 4563
		// (get) Token: 0x06005A35 RID: 23093 RVA: 0x0007F895 File Offset: 0x0007DA95
		// (set) Token: 0x06005A36 RID: 23094 RVA: 0x0007F8A5 File Offset: 0x0007DAA5
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

		// Token: 0x170011D4 RID: 4564
		// (get) Token: 0x06005A37 RID: 23095 RVA: 0x0007F8B6 File Offset: 0x0007DAB6
		// (set) Token: 0x06005A38 RID: 23096 RVA: 0x0007F8CA File Offset: 0x0007DACA
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

		// Token: 0x170011D5 RID: 4565
		// (get) Token: 0x06005A39 RID: 23097 RVA: 0x0007F8DF File Offset: 0x0007DADF
		// (set) Token: 0x06005A3A RID: 23098 RVA: 0x0007F8F3 File Offset: 0x0007DAF3
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

		// Token: 0x170011D6 RID: 4566
		// (get) Token: 0x06005A3B RID: 23099 RVA: 0x0007F908 File Offset: 0x0007DB08
		// (set) Token: 0x06005A3C RID: 23100 RVA: 0x0007F91C File Offset: 0x0007DB1C
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

		// Token: 0x170011D7 RID: 4567
		// (get) Token: 0x06005A3D RID: 23101 RVA: 0x0007F931 File Offset: 0x0007DB31
		// (set) Token: 0x06005A3E RID: 23102 RVA: 0x0007F941 File Offset: 0x0007DB41
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

		// Token: 0x170011D8 RID: 4568
		// (get) Token: 0x06005A3F RID: 23103 RVA: 0x0007F952 File Offset: 0x0007DB52
		// (set) Token: 0x06005A40 RID: 23104 RVA: 0x0007F966 File Offset: 0x0007DB66
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

		// Token: 0x170011D9 RID: 4569
		// (get) Token: 0x06005A41 RID: 23105 RVA: 0x0007F97B File Offset: 0x0007DB7B
		// (set) Token: 0x06005A42 RID: 23106 RVA: 0x0007F98B File Offset: 0x0007DB8B
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

		// Token: 0x170011DA RID: 4570
		// (get) Token: 0x06005A43 RID: 23107 RVA: 0x0007F99C File Offset: 0x0007DB9C
		// (set) Token: 0x06005A44 RID: 23108 RVA: 0x0007F9AC File Offset: 0x0007DBAC
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

		// Token: 0x170011DB RID: 4571
		// (get) Token: 0x06005A45 RID: 23109 RVA: 0x0007F9C0 File Offset: 0x0007DBC0
		// (set) Token: 0x06005A46 RID: 23110 RVA: 0x0007F9F9 File Offset: 0x0007DBF9
		public FKuroFastCollisionOverlapSignature OnKFCBeginOverlap
		{
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
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_OnKFCBeginOverlap, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170011DC RID: 4572
		// (get) Token: 0x06005A47 RID: 23111 RVA: 0x0007FA1C File Offset: 0x0007DC1C
		// (set) Token: 0x06005A48 RID: 23112 RVA: 0x0007FA55 File Offset: 0x0007DC55
		public FKuroFastCollisionOverlapSignature OnKFCEndOverlap
		{
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
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroFastCollisionShapeComponent.__PropertyOffset_OnKFCEndOverlap, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06005A49 RID: 23113 RVA: 0x0007FA76 File Offset: 0x0007DC76
		static UKuroFastCollisionShapeComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroFastCollision.KuroFastCollisionShapeComponent");
		}

		// Token: 0x06005A4A RID: 23114 RVA: 0x0007FA84 File Offset: 0x0007DC84
		protected UKuroFastCollisionShapeComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400256C RID: 9580
		public new const string __ObjectPath = "/Script/KuroFastCollision.KuroFastCollisionShapeComponent";

		// Token: 0x0400256D RID: 9581
		private static IntPtr _ClassPtr;

		// Token: 0x0400256E RID: 9582
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400256F RID: 9583
		internal static int __PropertyOffset_CenterSource;

		// Token: 0x04002570 RID: 9584
		internal static int __PropertyOffset_SceneComponent;

		// Token: 0x04002571 RID: 9585
		internal static int __PropertyOffset_RotationSource;

		// Token: 0x04002572 RID: 9586
		internal static int __PropertyOffset_RelativeLocation;

		// Token: 0x04002573 RID: 9587
		internal static int __PropertyOffset_RelativeRotation;

		// Token: 0x04002574 RID: 9588
		internal static int __PropertyOffset_Kind;

		// Token: 0x04002575 RID: 9589
		internal static int __PropertyOffset_Center_Manual;

		// Token: 0x04002576 RID: 9590
		internal static int __PropertyOffset_bEnableCCD;

		// Token: 0x04002577 RID: 9591
		internal static int __PropertyOffset_Channel;

		// Token: 0x04002578 RID: 9592
		internal static int __PropertyOffset_QueryMask;

		// Token: 0x04002579 RID: 9593
		internal static int __PropertyOffset_Radius;

		// Token: 0x0400257A RID: 9594
		internal static int __PropertyOffset_HalfExtent;

		// Token: 0x0400257B RID: 9595
		internal static int __PropertyOffset_BoxRot;

		// Token: 0x0400257C RID: 9596
		internal static int __PropertyOffset_Axis;

		// Token: 0x0400257D RID: 9597
		internal static int __PropertyOffset_HalfLength;

		// Token: 0x0400257E RID: 9598
		internal static int __PropertyOffset_ConeAxis;

		// Token: 0x0400257F RID: 9599
		internal static int __PropertyOffset_ConeHalfAngle;

		// Token: 0x04002580 RID: 9600
		internal static int __PropertyOffset_ConeHeight;

		// Token: 0x04002581 RID: 9601
		internal static int __PropertyOffset_OnKFCBeginOverlap;

		// Token: 0x04002582 RID: 9602
		[Nullable(2)]
		private FKuroFastCollisionOverlapSignature _OnKFCBeginOverlap;

		// Token: 0x04002583 RID: 9603
		internal static int __PropertyOffset_OnKFCEndOverlap;

		// Token: 0x04002584 RID: 9604
		[Nullable(2)]
		private FKuroFastCollisionOverlapSignature _OnKFCEndOverlap;
	}
}
