using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001668 RID: 5736
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.KuroMotorWheelIkParams")]
	[UnrealStructLayout(92, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 92)]
	public class FKuroMotorWheelIkParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014C68 RID: 85096 RVA: 0x001E8D7E File Offset: 0x001E6F7E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMotorWheelIkParams._ScriptStructPtr != 0) ? FKuroMotorWheelIkParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.KuroMotorWheelIkParams", ref FKuroMotorWheelIkParams._ScriptStructPtr);
		}

		// Token: 0x1700522B RID: 21035
		// (get) Token: 0x06014C69 RID: 85097 RVA: 0x001E8DA4 File Offset: 0x001E6FA4
		// (set) Token: 0x06014C6A RID: 85098 RVA: 0x001E8DE7 File Offset: 0x001E6FE7
		public FBoneReference IkBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._IkBone) == null)
				{
					result = (this._IkBone = new FBoneReference(base.NativePtr + (IntPtr)FKuroMotorWheelIkParams.__PropertyOffset_IkBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FKuroMotorWheelIkParams.__PropertyOffset_IkBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700522C RID: 21036
		// (get) Token: 0x06014C6B RID: 85099 RVA: 0x001E8E08 File Offset: 0x001E7008
		// (set) Token: 0x06014C6C RID: 85100 RVA: 0x001E8E1C File Offset: 0x001E701C
		public unsafe FVector RotateAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMotorWheelIkParams.__PropertyOffset_RotateAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMotorWheelIkParams.__PropertyOffset_RotateAxis) = value;
			}
		}

		// Token: 0x1700522D RID: 21037
		// (get) Token: 0x06014C6D RID: 85101 RVA: 0x001E8E31 File Offset: 0x001E7031
		// (set) Token: 0x06014C6E RID: 85102 RVA: 0x001E8E41 File Offset: 0x001E7041
		public unsafe float MinTurnAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMotorWheelIkParams.__PropertyOffset_MinTurnAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMotorWheelIkParams.__PropertyOffset_MinTurnAngle) = value;
			}
		}

		// Token: 0x1700522E RID: 21038
		// (get) Token: 0x06014C6F RID: 85103 RVA: 0x001E8E52 File Offset: 0x001E7052
		// (set) Token: 0x06014C70 RID: 85104 RVA: 0x001E8E62 File Offset: 0x001E7062
		public unsafe float MaxTurnAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMotorWheelIkParams.__PropertyOffset_MaxTurnAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMotorWheelIkParams.__PropertyOffset_MaxTurnAngle) = value;
			}
		}

		// Token: 0x1700522F RID: 21039
		// (get) Token: 0x06014C71 RID: 85105 RVA: 0x001E8E73 File Offset: 0x001E7073
		// (set) Token: 0x06014C72 RID: 85106 RVA: 0x001E8E83 File Offset: 0x001E7083
		public unsafe float MaxTurnSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMotorWheelIkParams.__PropertyOffset_MaxTurnSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMotorWheelIkParams.__PropertyOffset_MaxTurnSpeed) = value;
			}
		}

		// Token: 0x17005230 RID: 21040
		// (get) Token: 0x06014C73 RID: 85107 RVA: 0x001E8E94 File Offset: 0x001E7094
		// (set) Token: 0x06014C74 RID: 85108 RVA: 0x001E8ED7 File Offset: 0x001E70D7
		public FBoneReference IkWheelBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._IkWheelBone) == null)
				{
					result = (this._IkWheelBone = new FBoneReference(base.NativePtr + (IntPtr)FKuroMotorWheelIkParams.__PropertyOffset_IkWheelBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FKuroMotorWheelIkParams.__PropertyOffset_IkWheelBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005231 RID: 21041
		// (get) Token: 0x06014C75 RID: 85109 RVA: 0x001E8EF8 File Offset: 0x001E70F8
		// (set) Token: 0x06014C76 RID: 85110 RVA: 0x001E8F0C File Offset: 0x001E710C
		public unsafe FVector WheelRotateAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMotorWheelIkParams.__PropertyOffset_WheelRotateAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMotorWheelIkParams.__PropertyOffset_WheelRotateAxis) = value;
			}
		}

		// Token: 0x17005232 RID: 21042
		// (get) Token: 0x06014C77 RID: 85111 RVA: 0x001E8F21 File Offset: 0x001E7121
		// (set) Token: 0x06014C78 RID: 85112 RVA: 0x001E8F31 File Offset: 0x001E7131
		public unsafe float HangRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMotorWheelIkParams.__PropertyOffset_HangRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMotorWheelIkParams.__PropertyOffset_HangRadius) = value;
			}
		}

		// Token: 0x17005233 RID: 21043
		// (get) Token: 0x06014C79 RID: 85113 RVA: 0x001E8F42 File Offset: 0x001E7142
		// (set) Token: 0x06014C7A RID: 85114 RVA: 0x001E8F52 File Offset: 0x001E7152
		public unsafe float WheelRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMotorWheelIkParams.__PropertyOffset_WheelRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMotorWheelIkParams.__PropertyOffset_WheelRadius) = value;
			}
		}

		// Token: 0x17005234 RID: 21044
		// (get) Token: 0x06014C7B RID: 85115 RVA: 0x001E8F63 File Offset: 0x001E7163
		// (set) Token: 0x06014C7C RID: 85116 RVA: 0x001E8F73 File Offset: 0x001E7173
		public unsafe float HalfWheelWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMotorWheelIkParams.__PropertyOffset_HalfWheelWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMotorWheelIkParams.__PropertyOffset_HalfWheelWidth) = value;
			}
		}

		// Token: 0x17005235 RID: 21045
		// (get) Token: 0x06014C7D RID: 85117 RVA: 0x001E8F84 File Offset: 0x001E7184
		// (set) Token: 0x06014C7E RID: 85118 RVA: 0x001E8F94 File Offset: 0x001E7194
		public unsafe int AccurateCheckCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMotorWheelIkParams.__PropertyOffset_AccurateCheckCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMotorWheelIkParams.__PropertyOffset_AccurateCheckCount) = value;
			}
		}

		// Token: 0x06014C7F RID: 85119 RVA: 0x001E8FA5 File Offset: 0x001E71A5
		public FKuroMotorWheelIkParams()
		{
		}

		// Token: 0x06014C80 RID: 85120 RVA: 0x001E8FB0 File Offset: 0x001E71B0
		public FKuroMotorWheelIkParams(FBoneReference IkBone, FVector RotateAxis, float MinTurnAngle, float MaxTurnAngle, float MaxTurnSpeed, FBoneReference IkWheelBone, FVector WheelRotateAxis, float HangRadius, float WheelRadius, float HalfWheelWidth, int AccurateCheckCount)
		{
			this.IkBone = IkBone;
			this.RotateAxis = RotateAxis;
			this.MinTurnAngle = MinTurnAngle;
			this.MaxTurnAngle = MaxTurnAngle;
			this.MaxTurnSpeed = MaxTurnSpeed;
			this.IkWheelBone = IkWheelBone;
			this.WheelRotateAxis = WheelRotateAxis;
			this.HangRadius = HangRadius;
			this.WheelRadius = WheelRadius;
			this.HalfWheelWidth = HalfWheelWidth;
			this.AccurateCheckCount = AccurateCheckCount;
		}

		// Token: 0x06014C81 RID: 85121 RVA: 0x001E9018 File Offset: 0x001E7218
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMotorWheelIkParams.StaticStruct();
		}

		// Token: 0x06014C82 RID: 85122 RVA: 0x001E9024 File Offset: 0x001E7224
		[NullableContext(2)]
		public FKuroMotorWheelIkParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014C83 RID: 85123 RVA: 0x001E902E File Offset: 0x001E722E
		public FKuroMotorWheelIkParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014C84 RID: 85124 RVA: 0x001E9039 File Offset: 0x001E7239
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMotorWheelIkParams(Pointer, false, true);
		}

		// Token: 0x06014C85 RID: 85125 RVA: 0x001E9043 File Offset: 0x001E7243
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMotorWheelIkParams(Pointer, MemoryOwner);
		}

		// Token: 0x0400B53B RID: 46395
		public const string __ObjectPath = "/Script/KuroAnim.KuroMotorWheelIkParams";

		// Token: 0x0400B53C RID: 46396
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B53D RID: 46397
		internal static int __PropertyOffset_IkBone;

		// Token: 0x0400B53E RID: 46398
		[Nullable(2)]
		private FBoneReference _IkBone;

		// Token: 0x0400B53F RID: 46399
		internal static int __PropertyOffset_RotateAxis;

		// Token: 0x0400B540 RID: 46400
		internal static int __PropertyOffset_MinTurnAngle;

		// Token: 0x0400B541 RID: 46401
		internal static int __PropertyOffset_MaxTurnAngle;

		// Token: 0x0400B542 RID: 46402
		internal static int __PropertyOffset_MaxTurnSpeed;

		// Token: 0x0400B543 RID: 46403
		internal static int __PropertyOffset_IkWheelBone;

		// Token: 0x0400B544 RID: 46404
		[Nullable(2)]
		private FBoneReference _IkWheelBone;

		// Token: 0x0400B545 RID: 46405
		internal static int __PropertyOffset_WheelRotateAxis;

		// Token: 0x0400B546 RID: 46406
		internal static int __PropertyOffset_HangRadius;

		// Token: 0x0400B547 RID: 46407
		internal static int __PropertyOffset_WheelRadius;

		// Token: 0x0400B548 RID: 46408
		internal static int __PropertyOffset_HalfWheelWidth;

		// Token: 0x0400B549 RID: 46409
		internal static int __PropertyOffset_AccurateCheckCount;
	}
}
