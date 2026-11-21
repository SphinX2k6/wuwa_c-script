using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000638 RID: 1592
	[UnrealObjectPath("/Script/KuroVehicle.MotorWheelShapeConfig")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FMotorWheelShapeConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008BB5 RID: 35765 RVA: 0x000D244C File Offset: 0x000D064C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMotorWheelShapeConfig._ScriptStructPtr != 0) ? FMotorWheelShapeConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroVehicle.MotorWheelShapeConfig", ref FMotorWheelShapeConfig._ScriptStructPtr);
		}

		// Token: 0x17001A54 RID: 6740
		// (get) Token: 0x06008BB6 RID: 35766 RVA: 0x000D2470 File Offset: 0x000D0670
		// (set) Token: 0x06008BB7 RID: 35767 RVA: 0x000D2484 File Offset: 0x000D0684
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

		// Token: 0x17001A55 RID: 6741
		// (get) Token: 0x06008BB8 RID: 35768 RVA: 0x000D2499 File Offset: 0x000D0699
		// (set) Token: 0x06008BB9 RID: 35769 RVA: 0x000D24A9 File Offset: 0x000D06A9
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

		// Token: 0x17001A56 RID: 6742
		// (get) Token: 0x06008BBA RID: 35770 RVA: 0x000D24BA File Offset: 0x000D06BA
		// (set) Token: 0x06008BBB RID: 35771 RVA: 0x000D24CA File Offset: 0x000D06CA
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

		// Token: 0x17001A57 RID: 6743
		// (get) Token: 0x06008BBC RID: 35772 RVA: 0x000D24DB File Offset: 0x000D06DB
		// (set) Token: 0x06008BBD RID: 35773 RVA: 0x000D24EB File Offset: 0x000D06EB
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

		// Token: 0x17001A58 RID: 6744
		// (get) Token: 0x06008BBE RID: 35774 RVA: 0x000D24FC File Offset: 0x000D06FC
		// (set) Token: 0x06008BBF RID: 35775 RVA: 0x000D250C File Offset: 0x000D070C
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

		// Token: 0x06008BC0 RID: 35776 RVA: 0x000D251D File Offset: 0x000D071D
		public FMotorWheelShapeConfig()
		{
		}

		// Token: 0x06008BC1 RID: 35777 RVA: 0x000D2525 File Offset: 0x000D0725
		protected override IntPtr GetUStructPtr()
		{
			return FMotorWheelShapeConfig.StaticStruct();
		}

		// Token: 0x06008BC2 RID: 35778 RVA: 0x000D2531 File Offset: 0x000D0731
		[NullableContext(2)]
		public FMotorWheelShapeConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008BC3 RID: 35779 RVA: 0x000D253B File Offset: 0x000D073B
		public FMotorWheelShapeConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008BC4 RID: 35780 RVA: 0x000D2546 File Offset: 0x000D0746
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMotorWheelShapeConfig(Pointer, false, true);
		}

		// Token: 0x06008BC5 RID: 35781 RVA: 0x000D2550 File Offset: 0x000D0750
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMotorWheelShapeConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04003CB8 RID: 15544
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroVehicle.MotorWheelShapeConfig";

		// Token: 0x04003CB9 RID: 15545
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003CBA RID: 15546
		internal static int __PropertyOffset_LocalTrans;

		// Token: 0x04003CBB RID: 15547
		internal static int __PropertyOffset_Radius;

		// Token: 0x04003CBC RID: 15548
		internal static int __PropertyOffset_Width;

		// Token: 0x04003CBD RID: 15549
		internal static int __PropertyOffset_AccurateCheckCount;

		// Token: 0x04003CBE RID: 15550
		internal static int __PropertyOffset_BowShapeWheelWidthScale;
	}
}
