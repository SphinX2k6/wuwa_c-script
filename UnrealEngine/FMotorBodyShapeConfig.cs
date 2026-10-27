using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001F2D RID: 7981
	[UnrealObjectPath("/Script/KuroVehicle.MotorBodyShapeConfig")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FMotorBodyShapeConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E5C0 RID: 124352 RVA: 0x002D1F5C File Offset: 0x002D015C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMotorBodyShapeConfig._ScriptStructPtr != 0) ? FMotorBodyShapeConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroVehicle.MotorBodyShapeConfig", ref FMotorBodyShapeConfig._ScriptStructPtr);
		}

		// Token: 0x170078B3 RID: 30899
		// (get) Token: 0x0601E5C1 RID: 124353 RVA: 0x002D1F80 File Offset: 0x002D0180
		// (set) Token: 0x0601E5C2 RID: 124354 RVA: 0x002D1F94 File Offset: 0x002D0194
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

		// Token: 0x170078B4 RID: 30900
		// (get) Token: 0x0601E5C3 RID: 124355 RVA: 0x002D1FA9 File Offset: 0x002D01A9
		// (set) Token: 0x0601E5C4 RID: 124356 RVA: 0x002D1FB9 File Offset: 0x002D01B9
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

		// Token: 0x170078B5 RID: 30901
		// (get) Token: 0x0601E5C5 RID: 124357 RVA: 0x002D1FCA File Offset: 0x002D01CA
		// (set) Token: 0x0601E5C6 RID: 124358 RVA: 0x002D1FDA File Offset: 0x002D01DA
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

		// Token: 0x0601E5C7 RID: 124359 RVA: 0x002D1FEB File Offset: 0x002D01EB
		public FMotorBodyShapeConfig()
		{
		}

		// Token: 0x0601E5C8 RID: 124360 RVA: 0x002D1FF3 File Offset: 0x002D01F3
		public FMotorBodyShapeConfig(FTransform LocalTrans, float HalfHeight, float Radius)
		{
			this.LocalTrans = LocalTrans;
			this.HalfHeight = HalfHeight;
			this.Radius = Radius;
		}

		// Token: 0x0601E5C9 RID: 124361 RVA: 0x002D2010 File Offset: 0x002D0210
		protected override IntPtr GetUStructPtr()
		{
			return FMotorBodyShapeConfig.StaticStruct();
		}

		// Token: 0x0601E5CA RID: 124362 RVA: 0x002D201C File Offset: 0x002D021C
		[NullableContext(2)]
		public FMotorBodyShapeConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E5CB RID: 124363 RVA: 0x002D2026 File Offset: 0x002D0226
		public FMotorBodyShapeConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E5CC RID: 124364 RVA: 0x002D2031 File Offset: 0x002D0231
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMotorBodyShapeConfig(Pointer, false, true);
		}

		// Token: 0x0601E5CD RID: 124365 RVA: 0x002D203B File Offset: 0x002D023B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMotorBodyShapeConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04010606 RID: 67078
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroVehicle.MotorBodyShapeConfig";

		// Token: 0x04010607 RID: 67079
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010608 RID: 67080
		internal static int __PropertyOffset_LocalTrans;

		// Token: 0x04010609 RID: 67081
		internal static int __PropertyOffset_HalfHeight;

		// Token: 0x0401060A RID: 67082
		internal static int __PropertyOffset_Radius;
	}
}
