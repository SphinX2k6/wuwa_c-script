using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F39 RID: 7993
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroVehicle.MotorTurnConfig")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FMotorTurnConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E6D7 RID: 124631 RVA: 0x002D3D24 File Offset: 0x002D1F24
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMotorTurnConfig._ScriptStructPtr != 0) ? FMotorTurnConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroVehicle.MotorTurnConfig", ref FMotorTurnConfig._ScriptStructPtr);
		}

		// Token: 0x17007910 RID: 30992
		// (get) Token: 0x0601E6D8 RID: 124632 RVA: 0x002D3D48 File Offset: 0x002D1F48
		// (set) Token: 0x0601E6D9 RID: 124633 RVA: 0x002D3D5C File Offset: 0x002D1F5C
		public unsafe FVector FrontWheelTurnAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorTurnConfig.__PropertyOffset_FrontWheelTurnAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorTurnConfig.__PropertyOffset_FrontWheelTurnAxis) = value;
			}
		}

		// Token: 0x17007911 RID: 30993
		// (get) Token: 0x0601E6DA RID: 124634 RVA: 0x002D3D74 File Offset: 0x002D1F74
		// (set) Token: 0x0601E6DB RID: 124635 RVA: 0x002D3DB7 File Offset: 0x002D1FB7
		public FMotorFloatRange FrontWheelTurnAngle
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._FrontWheelTurnAngle) == null)
				{
					result = (this._FrontWheelTurnAngle = new FMotorFloatRange(base.NativePtr + (IntPtr)FMotorTurnConfig.__PropertyOffset_FrontWheelTurnAngle, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorTurnConfig.__PropertyOffset_FrontWheelTurnAngle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007912 RID: 30994
		// (get) Token: 0x0601E6DC RID: 124636 RVA: 0x002D3DD8 File Offset: 0x002D1FD8
		// (set) Token: 0x0601E6DD RID: 124637 RVA: 0x002D3DE8 File Offset: 0x002D1FE8
		public unsafe float FrontWheelTurnRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorTurnConfig.__PropertyOffset_FrontWheelTurnRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorTurnConfig.__PropertyOffset_FrontWheelTurnRate) = value;
			}
		}

		// Token: 0x0601E6DE RID: 124638 RVA: 0x002D3DF9 File Offset: 0x002D1FF9
		public FMotorTurnConfig()
		{
		}

		// Token: 0x0601E6DF RID: 124639 RVA: 0x002D3E01 File Offset: 0x002D2001
		public FMotorTurnConfig(FVector FrontWheelTurnAxis, FMotorFloatRange FrontWheelTurnAngle, float FrontWheelTurnRate)
		{
			this.FrontWheelTurnAxis = FrontWheelTurnAxis;
			this.FrontWheelTurnAngle = FrontWheelTurnAngle;
			this.FrontWheelTurnRate = FrontWheelTurnRate;
		}

		// Token: 0x0601E6E0 RID: 124640 RVA: 0x002D3E1E File Offset: 0x002D201E
		protected override IntPtr GetUStructPtr()
		{
			return FMotorTurnConfig.StaticStruct();
		}

		// Token: 0x0601E6E1 RID: 124641 RVA: 0x002D3E2A File Offset: 0x002D202A
		[NullableContext(2)]
		public FMotorTurnConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E6E2 RID: 124642 RVA: 0x002D3E34 File Offset: 0x002D2034
		public FMotorTurnConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E6E3 RID: 124643 RVA: 0x002D3E3F File Offset: 0x002D203F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMotorTurnConfig(Pointer, false, true);
		}

		// Token: 0x0601E6E4 RID: 124644 RVA: 0x002D3E49 File Offset: 0x002D2049
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMotorTurnConfig(Pointer, MemoryOwner);
		}

		// Token: 0x040106A4 RID: 67236
		public const string __ObjectPath = "/Script/KuroVehicle.MotorTurnConfig";

		// Token: 0x040106A5 RID: 67237
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040106A6 RID: 67238
		internal static int __PropertyOffset_FrontWheelTurnAxis;

		// Token: 0x040106A7 RID: 67239
		internal static int __PropertyOffset_FrontWheelTurnAngle;

		// Token: 0x040106A8 RID: 67240
		[Nullable(2)]
		private FMotorFloatRange _FrontWheelTurnAngle;

		// Token: 0x040106A9 RID: 67241
		internal static int __PropertyOffset_FrontWheelTurnRate;
	}
}
