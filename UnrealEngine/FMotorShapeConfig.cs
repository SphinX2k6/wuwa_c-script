using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F37 RID: 7991
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroVehicle.MotorShapeConfig")]
	[UnrealStructLayout(208, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 208)]
	public class FMotorShapeConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E69B RID: 124571 RVA: 0x002D355C File Offset: 0x002D175C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMotorShapeConfig._ScriptStructPtr != 0) ? FMotorShapeConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroVehicle.MotorShapeConfig", ref FMotorShapeConfig._ScriptStructPtr);
		}

		// Token: 0x170078FA RID: 30970
		// (get) Token: 0x0601E69C RID: 124572 RVA: 0x002D3580 File Offset: 0x002D1780
		// (set) Token: 0x0601E69D RID: 124573 RVA: 0x002D35C3 File Offset: 0x002D17C3
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

		// Token: 0x170078FB RID: 30971
		// (get) Token: 0x0601E69E RID: 124574 RVA: 0x002D35E4 File Offset: 0x002D17E4
		// (set) Token: 0x0601E69F RID: 124575 RVA: 0x002D3627 File Offset: 0x002D1827
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

		// Token: 0x170078FC RID: 30972
		// (get) Token: 0x0601E6A0 RID: 124576 RVA: 0x002D3638 File Offset: 0x002D1838
		// (set) Token: 0x0601E6A1 RID: 124577 RVA: 0x002D367B File Offset: 0x002D187B
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

		// Token: 0x170078FD RID: 30973
		// (get) Token: 0x0601E6A2 RID: 124578 RVA: 0x002D369C File Offset: 0x002D189C
		// (set) Token: 0x0601E6A3 RID: 124579 RVA: 0x002D36DF File Offset: 0x002D18DF
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

		// Token: 0x0601E6A4 RID: 124580 RVA: 0x002D3700 File Offset: 0x002D1900
		public FMotorShapeConfig()
		{
		}

		// Token: 0x0601E6A5 RID: 124581 RVA: 0x002D3708 File Offset: 0x002D1908
		public FMotorShapeConfig(FMotorBodyShapeConfig BodyShape, TArray<FMotorBodyShapeConfig> BodyOtherShapes, FMotorWheelShapeConfig FrontWheelShape, FMotorWheelShapeConfig BackWheelShape)
		{
			this.BodyShape = BodyShape;
			this.BodyOtherShapes = BodyOtherShapes;
			this.FrontWheelShape = FrontWheelShape;
			this.BackWheelShape = BackWheelShape;
		}

		// Token: 0x0601E6A6 RID: 124582 RVA: 0x002D372D File Offset: 0x002D192D
		protected override IntPtr GetUStructPtr()
		{
			return FMotorShapeConfig.StaticStruct();
		}

		// Token: 0x0601E6A7 RID: 124583 RVA: 0x002D3739 File Offset: 0x002D1939
		[NullableContext(2)]
		public FMotorShapeConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E6A8 RID: 124584 RVA: 0x002D3743 File Offset: 0x002D1943
		public FMotorShapeConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E6A9 RID: 124585 RVA: 0x002D374E File Offset: 0x002D194E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMotorShapeConfig(Pointer, false, true);
		}

		// Token: 0x0601E6AA RID: 124586 RVA: 0x002D3758 File Offset: 0x002D1958
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMotorShapeConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0401067D RID: 67197
		public const string __ObjectPath = "/Script/KuroVehicle.MotorShapeConfig";

		// Token: 0x0401067E RID: 67198
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401067F RID: 67199
		internal static int __PropertyOffset_BodyShape;

		// Token: 0x04010680 RID: 67200
		[Nullable(2)]
		private FMotorBodyShapeConfig _BodyShape;

		// Token: 0x04010681 RID: 67201
		internal static int __PropertyOffset_BodyOtherShapes;

		// Token: 0x04010682 RID: 67202
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMotorBodyShapeConfig> _BodyOtherShapes;

		// Token: 0x04010683 RID: 67203
		internal static int __PropertyOffset_FrontWheelShape;

		// Token: 0x04010684 RID: 67204
		[Nullable(2)]
		private FMotorWheelShapeConfig _FrontWheelShape;

		// Token: 0x04010685 RID: 67205
		internal static int __PropertyOffset_BackWheelShape;

		// Token: 0x04010686 RID: 67206
		[Nullable(2)]
		private FMotorWheelShapeConfig _BackWheelShape;
	}
}
