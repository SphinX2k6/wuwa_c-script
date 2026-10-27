using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000658 RID: 1624
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathTransformFromSRT")]
	[UnrealStructLayout(144, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FRigUnit_MathTransformFromSRT : FRigUnit_MathTransformBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005696 RID: 22166 RVA: 0x0007D64F File Offset: 0x0007B84F
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathTransformFromSRT._ScriptStructPtr != 0) ? FRigUnit_MathTransformFromSRT._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathTransformFromSRT", ref FRigUnit_MathTransformFromSRT._ScriptStructPtr);
		}

		// Token: 0x170014C7 RID: 5319
		// (get) Token: 0x06005697 RID: 22167 RVA: 0x0007D673 File Offset: 0x0007B873
		// (set) Token: 0x06005698 RID: 22168 RVA: 0x0007D687 File Offset: 0x0007B887
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathTransformFromSRT.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathTransformFromSRT.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x170014C8 RID: 5320
		// (get) Token: 0x06005699 RID: 22169 RVA: 0x0007D69C File Offset: 0x0007B89C
		// (set) Token: 0x0600569A RID: 22170 RVA: 0x0007D6B0 File Offset: 0x0007B8B0
		public unsafe FVector Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathTransformFromSRT.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathTransformFromSRT.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x170014C9 RID: 5321
		// (get) Token: 0x0600569B RID: 22171 RVA: 0x0007D6C5 File Offset: 0x0007B8C5
		// (set) Token: 0x0600569C RID: 22172 RVA: 0x0007D6D5 File Offset: 0x0007B8D5
		public unsafe EControlRigRotationOrder RotationOrder
		{
			get
			{
				return (EControlRigRotationOrder)(*(base.NativePtr + (IntPtr)FRigUnit_MathTransformFromSRT.__PropertyOffset_RotationOrder));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathTransformFromSRT.__PropertyOffset_RotationOrder) = (byte)value;
			}
		}

		// Token: 0x170014CA RID: 5322
		// (get) Token: 0x0600569D RID: 22173 RVA: 0x0007D6E6 File Offset: 0x0007B8E6
		// (set) Token: 0x0600569E RID: 22174 RVA: 0x0007D6FA File Offset: 0x0007B8FA
		public unsafe FVector Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathTransformFromSRT.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathTransformFromSRT.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x170014CB RID: 5323
		// (get) Token: 0x0600569F RID: 22175 RVA: 0x0007D70F File Offset: 0x0007B90F
		// (set) Token: 0x060056A0 RID: 22176 RVA: 0x0007D723 File Offset: 0x0007B923
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathTransformFromSRT.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathTransformFromSRT.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x170014CC RID: 5324
		// (get) Token: 0x060056A1 RID: 22177 RVA: 0x0007D738 File Offset: 0x0007B938
		// (set) Token: 0x060056A2 RID: 22178 RVA: 0x0007D77B File Offset: 0x0007B97B
		public FEulerTransform EulerTransform
		{
			get
			{
				base.FastCheckIsValid();
				FEulerTransform result;
				if ((result = this._EulerTransform) == null)
				{
					result = (this._EulerTransform = new FEulerTransform(base.NativePtr + (IntPtr)FRigUnit_MathTransformFromSRT.__PropertyOffset_EulerTransform, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEulerTransform.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_MathTransformFromSRT.__PropertyOffset_EulerTransform, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060056A3 RID: 22179 RVA: 0x0007D79C File Offset: 0x0007B99C
		public FRigUnit_MathTransformFromSRT()
		{
		}

		// Token: 0x060056A4 RID: 22180 RVA: 0x0007D7A4 File Offset: 0x0007B9A4
		public FRigUnit_MathTransformFromSRT(FVector Location, FVector Rotation, EControlRigRotationOrder RotationOrder, FVector Scale, FTransform Transform, FEulerTransform EulerTransform)
		{
			this.Location = Location;
			this.Rotation = Rotation;
			this.RotationOrder = RotationOrder;
			this.Scale = Scale;
			this.Transform = Transform;
			this.EulerTransform = EulerTransform;
		}

		// Token: 0x060056A5 RID: 22181 RVA: 0x0007D7D9 File Offset: 0x0007B9D9
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathTransformFromSRT.StaticStruct();
		}

		// Token: 0x060056A6 RID: 22182 RVA: 0x0007D7E5 File Offset: 0x0007B9E5
		[NullableContext(2)]
		public FRigUnit_MathTransformFromSRT(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060056A7 RID: 22183 RVA: 0x0007D7EF File Offset: 0x0007B9EF
		public FRigUnit_MathTransformFromSRT(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060056A8 RID: 22184 RVA: 0x0007D7FA File Offset: 0x0007B9FA
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathTransformFromSRT(Pointer, false, true);
		}

		// Token: 0x060056A9 RID: 22185 RVA: 0x0007D804 File Offset: 0x0007BA04
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathTransformFromSRT(Pointer, MemoryOwner);
		}

		// Token: 0x040028EC RID: 10476
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathTransformFromSRT";

		// Token: 0x040028ED RID: 10477
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040028EE RID: 10478
		internal static int __PropertyOffset_Location;

		// Token: 0x040028EF RID: 10479
		internal static int __PropertyOffset_Rotation;

		// Token: 0x040028F0 RID: 10480
		internal static int __PropertyOffset_RotationOrder;

		// Token: 0x040028F1 RID: 10481
		internal static int __PropertyOffset_Scale;

		// Token: 0x040028F2 RID: 10482
		internal static int __PropertyOffset_Transform;

		// Token: 0x040028F3 RID: 10483
		internal static int __PropertyOffset_EulerTransform;

		// Token: 0x040028F4 RID: 10484
		[Nullable(2)]
		private FEulerTransform _EulerTransform;
	}
}
