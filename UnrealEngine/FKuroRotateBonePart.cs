using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001674 RID: 5748
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.KuroRotateBonePart")]
	[UnrealStructLayout(44, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 44)]
	public class FKuroRotateBonePart : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014DA8 RID: 85416 RVA: 0x001EA95C File Offset: 0x001E8B5C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroRotateBonePart._ScriptStructPtr != 0) ? FKuroRotateBonePart._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.KuroRotateBonePart", ref FKuroRotateBonePart._ScriptStructPtr);
		}

		// Token: 0x1700529B RID: 21147
		// (get) Token: 0x06014DA9 RID: 85417 RVA: 0x001EA980 File Offset: 0x001E8B80
		// (set) Token: 0x06014DAA RID: 85418 RVA: 0x001EA9C3 File Offset: 0x001E8BC3
		public FBoneReference IKBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._IKBone) == null)
				{
					result = (this._IKBone = new FBoneReference(base.NativePtr + (IntPtr)FKuroRotateBonePart.__PropertyOffset_IKBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FKuroRotateBonePart.__PropertyOffset_IKBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700529C RID: 21148
		// (get) Token: 0x06014DAB RID: 85419 RVA: 0x001EA9E4 File Offset: 0x001E8BE4
		// (set) Token: 0x06014DAC RID: 85420 RVA: 0x001EA9F8 File Offset: 0x001E8BF8
		[Nullable(0)]
		public unsafe TEnumAsByte<EKuroRotateBonePartLimitType> LimitType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRotateBonePart.__PropertyOffset_LimitType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRotateBonePart.__PropertyOffset_LimitType) = value;
			}
		}

		// Token: 0x1700529D RID: 21149
		// (get) Token: 0x06014DAD RID: 85421 RVA: 0x001EAA0D File Offset: 0x001E8C0D
		// (set) Token: 0x06014DAE RID: 85422 RVA: 0x001EAA1D File Offset: 0x001E8C1D
		public unsafe float LimitAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRotateBonePart.__PropertyOffset_LimitAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRotateBonePart.__PropertyOffset_LimitAngle) = value;
			}
		}

		// Token: 0x1700529E RID: 21150
		// (get) Token: 0x06014DAF RID: 85423 RVA: 0x001EAA30 File Offset: 0x001E8C30
		// (set) Token: 0x06014DB0 RID: 85424 RVA: 0x001EAA74 File Offset: 0x001E8C74
		public TFixedArray<float> LimitPitch
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<float> result;
				if ((result = this._LimitPitch) == null)
				{
					result = (this._LimitPitch = new TFixedArray<float>(base.NativePtr + (IntPtr)FKuroRotateBonePart.__PropertyOffset_LimitPitch, 2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LimitPitch.CopyAssign(value);
			}
		}

		// Token: 0x1700529F RID: 21151
		// (get) Token: 0x06014DB1 RID: 85425 RVA: 0x001EAA84 File Offset: 0x001E8C84
		// (set) Token: 0x06014DB2 RID: 85426 RVA: 0x001EAAC8 File Offset: 0x001E8CC8
		public TFixedArray<float> LimitYaw
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<float> result;
				if ((result = this._LimitYaw) == null)
				{
					result = (this._LimitYaw = new TFixedArray<float>(base.NativePtr + (IntPtr)FKuroRotateBonePart.__PropertyOffset_LimitYaw, 2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LimitYaw.CopyAssign(value);
			}
		}

		// Token: 0x06014DB3 RID: 85427 RVA: 0x001EAAD6 File Offset: 0x001E8CD6
		public FKuroRotateBonePart()
		{
		}

		// Token: 0x06014DB4 RID: 85428 RVA: 0x001EAADE File Offset: 0x001E8CDE
		public FKuroRotateBonePart(FBoneReference IKBone, [Nullable(0)] TEnumAsByte<EKuroRotateBonePartLimitType> LimitType, float LimitAngle, TFixedArray<float> LimitPitch, TFixedArray<float> LimitYaw)
		{
			this.IKBone = IKBone;
			this.LimitType = LimitType;
			this.LimitAngle = LimitAngle;
			this.LimitPitch = LimitPitch;
			this.LimitYaw = LimitYaw;
		}

		// Token: 0x06014DB5 RID: 85429 RVA: 0x001EAB0B File Offset: 0x001E8D0B
		protected override IntPtr GetUStructPtr()
		{
			return FKuroRotateBonePart.StaticStruct();
		}

		// Token: 0x06014DB6 RID: 85430 RVA: 0x001EAB17 File Offset: 0x001E8D17
		[NullableContext(2)]
		public FKuroRotateBonePart(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014DB7 RID: 85431 RVA: 0x001EAB21 File Offset: 0x001E8D21
		public FKuroRotateBonePart(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014DB8 RID: 85432 RVA: 0x001EAB2C File Offset: 0x001E8D2C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroRotateBonePart(Pointer, false, true);
		}

		// Token: 0x06014DB9 RID: 85433 RVA: 0x001EAB36 File Offset: 0x001E8D36
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroRotateBonePart(Pointer, MemoryOwner);
		}

		// Token: 0x0400B5D7 RID: 46551
		public const string __ObjectPath = "/Script/KuroAnim.KuroRotateBonePart";

		// Token: 0x0400B5D8 RID: 46552
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B5D9 RID: 46553
		internal static int __PropertyOffset_IKBone;

		// Token: 0x0400B5DA RID: 46554
		[Nullable(2)]
		private FBoneReference _IKBone;

		// Token: 0x0400B5DB RID: 46555
		internal static int __PropertyOffset_LimitType;

		// Token: 0x0400B5DC RID: 46556
		internal static int __PropertyOffset_LimitAngle;

		// Token: 0x0400B5DD RID: 46557
		internal static int __PropertyOffset_LimitPitch;

		// Token: 0x0400B5DE RID: 46558
		[Nullable(2)]
		private TFixedArray<float> _LimitPitch;

		// Token: 0x0400B5DF RID: 46559
		internal static int __PropertyOffset_LimitYaw;

		// Token: 0x0400B5E0 RID: 46560
		[Nullable(2)]
		private TFixedArray<float> _LimitYaw;
	}
}
