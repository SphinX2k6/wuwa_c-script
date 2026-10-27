using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001F3A RID: 7994
	[UnrealObjectPath("/Script/KuroVehicle.MotorWheelShapeConfig")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FMotorWheelShapeConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E6E5 RID: 124645 RVA: 0x002D3E52 File Offset: 0x002D2052
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMotorWheelShapeConfig._ScriptStructPtr != 0) ? FMotorWheelShapeConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroVehicle.MotorWheelShapeConfig", ref FMotorWheelShapeConfig._ScriptStructPtr);
		}

		// Token: 0x17007913 RID: 30995
		// (get) Token: 0x0601E6E6 RID: 124646 RVA: 0x002D3E76 File Offset: 0x002D2076
		// (set) Token: 0x0601E6E7 RID: 124647 RVA: 0x002D3E8A File Offset: 0x002D208A
		public unsafe FTransform LocalTrans
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorWheelShapeConfig.__PropertyOffset_LocalTrans);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorWheelShapeConfig.__PropertyOffset_LocalTrans) = value;
			}
		}

		// Token: 0x17007914 RID: 30996
		// (get) Token: 0x0601E6E8 RID: 124648 RVA: 0x002D3E9F File Offset: 0x002D209F
		// (set) Token: 0x0601E6E9 RID: 124649 RVA: 0x002D3EAF File Offset: 0x002D20AF
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorWheelShapeConfig.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorWheelShapeConfig.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x17007915 RID: 30997
		// (get) Token: 0x0601E6EA RID: 124650 RVA: 0x002D3EC0 File Offset: 0x002D20C0
		// (set) Token: 0x0601E6EB RID: 124651 RVA: 0x002D3ED0 File Offset: 0x002D20D0
		public unsafe float Width
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorWheelShapeConfig.__PropertyOffset_Width);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorWheelShapeConfig.__PropertyOffset_Width) = value;
			}
		}

		// Token: 0x17007916 RID: 30998
		// (get) Token: 0x0601E6EC RID: 124652 RVA: 0x002D3EE1 File Offset: 0x002D20E1
		// (set) Token: 0x0601E6ED RID: 124653 RVA: 0x002D3EF1 File Offset: 0x002D20F1
		public unsafe int AccurateCheckCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorWheelShapeConfig.__PropertyOffset_AccurateCheckCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorWheelShapeConfig.__PropertyOffset_AccurateCheckCount) = value;
			}
		}

		// Token: 0x17007917 RID: 30999
		// (get) Token: 0x0601E6EE RID: 124654 RVA: 0x002D3F02 File Offset: 0x002D2102
		// (set) Token: 0x0601E6EF RID: 124655 RVA: 0x002D3F12 File Offset: 0x002D2112
		public unsafe float BowShapeWheelWidthScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorWheelShapeConfig.__PropertyOffset_BowShapeWheelWidthScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorWheelShapeConfig.__PropertyOffset_BowShapeWheelWidthScale) = value;
			}
		}

		// Token: 0x0601E6F0 RID: 124656 RVA: 0x002D3F23 File Offset: 0x002D2123
		public FMotorWheelShapeConfig()
		{
		}

		// Token: 0x0601E6F1 RID: 124657 RVA: 0x002D3F2B File Offset: 0x002D212B
		public FMotorWheelShapeConfig(FTransform LocalTrans, float Radius, float Width, int AccurateCheckCount, float BowShapeWheelWidthScale)
		{
			this.LocalTrans = LocalTrans;
			this.Radius = Radius;
			this.Width = Width;
			this.AccurateCheckCount = AccurateCheckCount;
			this.BowShapeWheelWidthScale = BowShapeWheelWidthScale;
		}

		// Token: 0x0601E6F2 RID: 124658 RVA: 0x002D3F58 File Offset: 0x002D2158
		protected override IntPtr GetUStructPtr()
		{
			return FMotorWheelShapeConfig.StaticStruct();
		}

		// Token: 0x0601E6F3 RID: 124659 RVA: 0x002D3F64 File Offset: 0x002D2164
		[NullableContext(2)]
		public FMotorWheelShapeConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E6F4 RID: 124660 RVA: 0x002D3F6E File Offset: 0x002D216E
		public FMotorWheelShapeConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E6F5 RID: 124661 RVA: 0x002D3F79 File Offset: 0x002D2179
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMotorWheelShapeConfig(Pointer, false, true);
		}

		// Token: 0x0601E6F6 RID: 124662 RVA: 0x002D3F83 File Offset: 0x002D2183
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMotorWheelShapeConfig(Pointer, MemoryOwner);
		}

		// Token: 0x040106AA RID: 67242
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroVehicle.MotorWheelShapeConfig";

		// Token: 0x040106AB RID: 67243
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040106AC RID: 67244
		internal static int __PropertyOffset_LocalTrans;

		// Token: 0x040106AD RID: 67245
		internal static int __PropertyOffset_Radius;

		// Token: 0x040106AE RID: 67246
		internal static int __PropertyOffset_Width;

		// Token: 0x040106AF RID: 67247
		internal static int __PropertyOffset_AccurateCheckCount;

		// Token: 0x040106B0 RID: 67248
		internal static int __PropertyOffset_BowShapeWheelWidthScale;
	}
}
