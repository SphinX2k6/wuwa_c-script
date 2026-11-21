using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000637 RID: 1591
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroVehicle.MotorShapeConfig")]
	[UnrealStructLayout(208, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 208)]
	public class FMotorShapeConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008BA6 RID: 35750 RVA: 0x000D2269 File Offset: 0x000D0469
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMotorShapeConfig._ScriptStructPtr != 0) ? FMotorShapeConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroVehicle.MotorShapeConfig", ref FMotorShapeConfig._ScriptStructPtr);
		}

		// Token: 0x17001A50 RID: 6736
		// (get) Token: 0x06008BA7 RID: 35751 RVA: 0x000D2290 File Offset: 0x000D0490
		// (set) Token: 0x06008BA8 RID: 35752 RVA: 0x000D22D3 File Offset: 0x000D04D3
		public FMotorBodyShapeConfig BodyShape
		{
			get
			{
				base.FastCheckIsValid();
				FMotorBodyShapeConfig result;
				if ((result = this._BodyShape) == null)
				{
					result = (this._BodyShape = new FMotorBodyShapeConfig(base.NativePtr + (IntPtr)FMotorShapeConfig.__PropertyOffset_BodyShape, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorBodyShapeConfig.StaticStruct(), base.NativePtr + (IntPtr)FMotorShapeConfig.__PropertyOffset_BodyShape, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001A51 RID: 6737
		// (get) Token: 0x06008BA9 RID: 35753 RVA: 0x000D22F4 File Offset: 0x000D04F4
		// (set) Token: 0x06008BAA RID: 35754 RVA: 0x000D2337 File Offset: 0x000D0537
		public TArray<FMotorBodyShapeConfig> BodyOtherShapes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMotorBodyShapeConfig> result;
				if ((result = this._BodyOtherShapes) == null)
				{
					result = (this._BodyOtherShapes = new TArray<FMotorBodyShapeConfig>(base.NativePtr + (IntPtr)FMotorShapeConfig.__PropertyOffset_BodyOtherShapes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BodyOtherShapes.CopyAssign(value);
			}
		}

		// Token: 0x17001A52 RID: 6738
		// (get) Token: 0x06008BAB RID: 35755 RVA: 0x000D2348 File Offset: 0x000D0548
		// (set) Token: 0x06008BAC RID: 35756 RVA: 0x000D238B File Offset: 0x000D058B
		public FMotorWheelShapeConfig FrontWheelShape
		{
			get
			{
				base.FastCheckIsValid();
				FMotorWheelShapeConfig result;
				if ((result = this._FrontWheelShape) == null)
				{
					result = (this._FrontWheelShape = new FMotorWheelShapeConfig(base.NativePtr + (IntPtr)FMotorShapeConfig.__PropertyOffset_FrontWheelShape, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorWheelShapeConfig.StaticStruct(), base.NativePtr + (IntPtr)FMotorShapeConfig.__PropertyOffset_FrontWheelShape, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001A53 RID: 6739
		// (get) Token: 0x06008BAD RID: 35757 RVA: 0x000D23AC File Offset: 0x000D05AC
		// (set) Token: 0x06008BAE RID: 35758 RVA: 0x000D23EF File Offset: 0x000D05EF
		public FMotorWheelShapeConfig BackWheelShape
		{
			get
			{
				base.FastCheckIsValid();
				FMotorWheelShapeConfig result;
				if ((result = this._BackWheelShape) == null)
				{
					result = (this._BackWheelShape = new FMotorWheelShapeConfig(base.NativePtr + (IntPtr)FMotorShapeConfig.__PropertyOffset_BackWheelShape, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorWheelShapeConfig.StaticStruct(), base.NativePtr + (IntPtr)FMotorShapeConfig.__PropertyOffset_BackWheelShape, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06008BAF RID: 35759 RVA: 0x000D2410 File Offset: 0x000D0610
		public FMotorShapeConfig()
		{
		}

		// Token: 0x06008BB0 RID: 35760 RVA: 0x000D2418 File Offset: 0x000D0618
		protected override IntPtr GetUStructPtr()
		{
			return FMotorShapeConfig.StaticStruct();
		}

		// Token: 0x06008BB1 RID: 35761 RVA: 0x000D2424 File Offset: 0x000D0624
		[NullableContext(2)]
		public FMotorShapeConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008BB2 RID: 35762 RVA: 0x000D242E File Offset: 0x000D062E
		public FMotorShapeConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008BB3 RID: 35763 RVA: 0x000D2439 File Offset: 0x000D0639
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMotorShapeConfig(Pointer, false, true);
		}

		// Token: 0x06008BB4 RID: 35764 RVA: 0x000D2443 File Offset: 0x000D0643
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMotorShapeConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04003CAE RID: 15534
		public const string __ObjectPath = "/Script/KuroVehicle.MotorShapeConfig";

		// Token: 0x04003CAF RID: 15535
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003CB0 RID: 15536
		internal static int __PropertyOffset_BodyShape;

		// Token: 0x04003CB1 RID: 15537
		[Nullable(2)]
		private FMotorBodyShapeConfig _BodyShape;

		// Token: 0x04003CB2 RID: 15538
		internal static int __PropertyOffset_BodyOtherShapes;

		// Token: 0x04003CB3 RID: 15539
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMotorBodyShapeConfig> _BodyOtherShapes;

		// Token: 0x04003CB4 RID: 15540
		internal static int __PropertyOffset_FrontWheelShape;

		// Token: 0x04003CB5 RID: 15541
		[Nullable(2)]
		private FMotorWheelShapeConfig _FrontWheelShape;

		// Token: 0x04003CB6 RID: 15542
		internal static int __PropertyOffset_BackWheelShape;

		// Token: 0x04003CB7 RID: 15543
		[Nullable(2)]
		private FMotorWheelShapeConfig _BackWheelShape;
	}
}
