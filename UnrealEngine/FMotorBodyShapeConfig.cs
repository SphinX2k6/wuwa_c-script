using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000633 RID: 1587
	[UnrealObjectPath("/Script/KuroVehicle.MotorBodyShapeConfig")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FMotorBodyShapeConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008B62 RID: 35682 RVA: 0x000D1C83 File Offset: 0x000CFE83
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMotorBodyShapeConfig._ScriptStructPtr != 0) ? FMotorBodyShapeConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroVehicle.MotorBodyShapeConfig", ref FMotorBodyShapeConfig._ScriptStructPtr);
		}

		// Token: 0x17001A3B RID: 6715
		// (get) Token: 0x06008B63 RID: 35683 RVA: 0x000D1CA7 File Offset: 0x000CFEA7
		// (set) Token: 0x06008B64 RID: 35684 RVA: 0x000D1CBB File Offset: 0x000CFEBB
		public unsafe FTransform LocalTrans
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorBodyShapeConfig.__PropertyOffset_LocalTrans);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorBodyShapeConfig.__PropertyOffset_LocalTrans) = value;
			}
		}

		// Token: 0x17001A3C RID: 6716
		// (get) Token: 0x06008B65 RID: 35685 RVA: 0x000D1CD0 File Offset: 0x000CFED0
		// (set) Token: 0x06008B66 RID: 35686 RVA: 0x000D1CE0 File Offset: 0x000CFEE0
		public unsafe float HalfHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorBodyShapeConfig.__PropertyOffset_HalfHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorBodyShapeConfig.__PropertyOffset_HalfHeight) = value;
			}
		}

		// Token: 0x17001A3D RID: 6717
		// (get) Token: 0x06008B67 RID: 35687 RVA: 0x000D1CF1 File Offset: 0x000CFEF1
		// (set) Token: 0x06008B68 RID: 35688 RVA: 0x000D1D01 File Offset: 0x000CFF01
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorBodyShapeConfig.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorBodyShapeConfig.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x06008B69 RID: 35689 RVA: 0x000D1D12 File Offset: 0x000CFF12
		public FMotorBodyShapeConfig()
		{
		}

		// Token: 0x06008B6A RID: 35690 RVA: 0x000D1D1A File Offset: 0x000CFF1A
		protected override IntPtr GetUStructPtr()
		{
			return FMotorBodyShapeConfig.StaticStruct();
		}

		// Token: 0x06008B6B RID: 35691 RVA: 0x000D1D26 File Offset: 0x000CFF26
		[NullableContext(2)]
		public FMotorBodyShapeConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008B6C RID: 35692 RVA: 0x000D1D30 File Offset: 0x000CFF30
		public FMotorBodyShapeConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008B6D RID: 35693 RVA: 0x000D1D3B File Offset: 0x000CFF3B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMotorBodyShapeConfig(Pointer, false, true);
		}

		// Token: 0x06008B6E RID: 35694 RVA: 0x000D1D45 File Offset: 0x000CFF45
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMotorBodyShapeConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04003C8A RID: 15498
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroVehicle.MotorBodyShapeConfig";

		// Token: 0x04003C8B RID: 15499
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003C8C RID: 15500
		internal static int __PropertyOffset_LocalTrans;

		// Token: 0x04003C8D RID: 15501
		internal static int __PropertyOffset_HalfHeight;

		// Token: 0x04003C8E RID: 15502
		internal static int __PropertyOffset_Radius;
	}
}
