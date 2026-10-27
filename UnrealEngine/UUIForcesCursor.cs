using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002171 RID: 8561
	[UnrealObjectPath("/Script/LGUI.UIForcesCursor")]
	[UnrealStructLayout(816, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 816)]
	public class UUIForcesCursor : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020500 RID: 132352 RVA: 0x002FFDDC File Offset: 0x002FDFDC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIForcesCursor._ClassPtr;
		}

		// Token: 0x06020501 RID: 132353 RVA: 0x002FFDE8 File Offset: 0x002FDFE8
		public UUIForcesCursor() : this(BuiltinUtils.AllocNativeUObject(UUIForcesCursor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020502 RID: 132354 RVA: 0x002FFE10 File Offset: 0x002FE010
		[NullableContext(1)]
		public UUIForcesCursor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIForcesCursor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007EA4 RID: 32420
		// (get) Token: 0x06020503 RID: 132355 RVA: 0x002FFE43 File Offset: 0x002FE043
		// (set) Token: 0x06020504 RID: 132356 RVA: 0x002FFE53 File Offset: 0x002FE053
		public unsafe bool IsOrthographic
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIForcesCursor.__PropertyOffset_IsOrthographic) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIForcesCursor.__PropertyOffset_IsOrthographic) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007EA5 RID: 32421
		// (get) Token: 0x06020505 RID: 132357 RVA: 0x002FFE64 File Offset: 0x002FE064
		// (set) Token: 0x06020506 RID: 132358 RVA: 0x002FFE74 File Offset: 0x002FE074
		public unsafe int ScreenSizeX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIForcesCursor.__PropertyOffset_ScreenSizeX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIForcesCursor.__PropertyOffset_ScreenSizeX) = value;
			}
		}

		// Token: 0x17007EA6 RID: 32422
		// (get) Token: 0x06020507 RID: 132359 RVA: 0x002FFE85 File Offset: 0x002FE085
		// (set) Token: 0x06020508 RID: 132360 RVA: 0x002FFE95 File Offset: 0x002FE095
		public unsafe int ScreenSizeY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIForcesCursor.__PropertyOffset_ScreenSizeY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIForcesCursor.__PropertyOffset_ScreenSizeY) = value;
			}
		}

		// Token: 0x17007EA7 RID: 32423
		// (get) Token: 0x06020509 RID: 132361 RVA: 0x002FFEA6 File Offset: 0x002FE0A6
		// (set) Token: 0x0602050A RID: 132362 RVA: 0x002FFEBA File Offset: 0x002FE0BA
		public unsafe FRotator RotatorInfo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIForcesCursor.__PropertyOffset_RotatorInfo);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIForcesCursor.__PropertyOffset_RotatorInfo) = value;
			}
		}

		// Token: 0x17007EA8 RID: 32424
		// (get) Token: 0x0602050B RID: 132363 RVA: 0x002FFECF File Offset: 0x002FE0CF
		// (set) Token: 0x0602050C RID: 132364 RVA: 0x002FFEE3 File Offset: 0x002FE0E3
		public unsafe FVector MoveVector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIForcesCursor.__PropertyOffset_MoveVector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIForcesCursor.__PropertyOffset_MoveVector) = value;
			}
		}

		// Token: 0x17007EA9 RID: 32425
		// (get) Token: 0x0602050D RID: 132365 RVA: 0x002FFEF8 File Offset: 0x002FE0F8
		// (set) Token: 0x0602050E RID: 132366 RVA: 0x002FFF0C File Offset: 0x002FE10C
		public unsafe FVector OriginPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIForcesCursor.__PropertyOffset_OriginPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIForcesCursor.__PropertyOffset_OriginPos) = value;
			}
		}

		// Token: 0x17007EAA RID: 32426
		// (get) Token: 0x0602050F RID: 132367 RVA: 0x002FFF21 File Offset: 0x002FE121
		// (set) Token: 0x06020510 RID: 132368 RVA: 0x002FFF31 File Offset: 0x002FE131
		public unsafe float FrameStepping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIForcesCursor.__PropertyOffset_FrameStepping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIForcesCursor.__PropertyOffset_FrameStepping) = value;
			}
		}

		// Token: 0x17007EAB RID: 32427
		// (get) Token: 0x06020511 RID: 132369 RVA: 0x002FFF42 File Offset: 0x002FE142
		// (set) Token: 0x06020512 RID: 132370 RVA: 0x002FFF52 File Offset: 0x002FE152
		public unsafe float MaxAngleX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIForcesCursor.__PropertyOffset_MaxAngleX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIForcesCursor.__PropertyOffset_MaxAngleX) = value;
			}
		}

		// Token: 0x17007EAC RID: 32428
		// (get) Token: 0x06020513 RID: 132371 RVA: 0x002FFF63 File Offset: 0x002FE163
		// (set) Token: 0x06020514 RID: 132372 RVA: 0x002FFF73 File Offset: 0x002FE173
		public unsafe float MaxAngleY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIForcesCursor.__PropertyOffset_MaxAngleY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIForcesCursor.__PropertyOffset_MaxAngleY) = value;
			}
		}

		// Token: 0x17007EAD RID: 32429
		// (get) Token: 0x06020515 RID: 132373 RVA: 0x002FFF84 File Offset: 0x002FE184
		// (set) Token: 0x06020516 RID: 132374 RVA: 0x002FFF94 File Offset: 0x002FE194
		public unsafe float MouseX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIForcesCursor.__PropertyOffset_MouseX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIForcesCursor.__PropertyOffset_MouseX) = value;
			}
		}

		// Token: 0x17007EAE RID: 32430
		// (get) Token: 0x06020517 RID: 132375 RVA: 0x002FFFA5 File Offset: 0x002FE1A5
		// (set) Token: 0x06020518 RID: 132376 RVA: 0x002FFFB5 File Offset: 0x002FE1B5
		public unsafe float MouseY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIForcesCursor.__PropertyOffset_MouseY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIForcesCursor.__PropertyOffset_MouseY) = value;
			}
		}

		// Token: 0x17007EAF RID: 32431
		// (get) Token: 0x06020519 RID: 132377 RVA: 0x002FFFC6 File Offset: 0x002FE1C6
		// (set) Token: 0x0602051A RID: 132378 RVA: 0x002FFFDA File Offset: 0x002FE1DA
		public unsafe FVector OffsetVector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIForcesCursor.__PropertyOffset_OffsetVector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIForcesCursor.__PropertyOffset_OffsetVector) = value;
			}
		}

		// Token: 0x17007EB0 RID: 32432
		// (get) Token: 0x0602051B RID: 132379 RVA: 0x002FFFEF File Offset: 0x002FE1EF
		// (set) Token: 0x0602051C RID: 132380 RVA: 0x00300003 File Offset: 0x002FE203
		public unsafe FVector AroundPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIForcesCursor.__PropertyOffset_AroundPoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIForcesCursor.__PropertyOffset_AroundPoint) = value;
			}
		}

		// Token: 0x17007EB1 RID: 32433
		// (get) Token: 0x0602051D RID: 132381 RVA: 0x00300018 File Offset: 0x002FE218
		// (set) Token: 0x0602051E RID: 132382 RVA: 0x00300028 File Offset: 0x002FE228
		public unsafe float GamepadRightX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIForcesCursor.__PropertyOffset_GamepadRightX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIForcesCursor.__PropertyOffset_GamepadRightX) = value;
			}
		}

		// Token: 0x17007EB2 RID: 32434
		// (get) Token: 0x0602051F RID: 132383 RVA: 0x00300039 File Offset: 0x002FE239
		// (set) Token: 0x06020520 RID: 132384 RVA: 0x00300049 File Offset: 0x002FE249
		public unsafe float GamepadRightY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIForcesCursor.__PropertyOffset_GamepadRightY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIForcesCursor.__PropertyOffset_GamepadRightY) = value;
			}
		}

		// Token: 0x17007EB3 RID: 32435
		// (get) Token: 0x06020521 RID: 132385 RVA: 0x0030005A File Offset: 0x002FE25A
		// (set) Token: 0x06020522 RID: 132386 RVA: 0x0030006E File Offset: 0x002FE26E
		public unsafe FVector Tilt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIForcesCursor.__PropertyOffset_Tilt);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIForcesCursor.__PropertyOffset_Tilt) = value;
			}
		}

		// Token: 0x17007EB4 RID: 32436
		// (get) Token: 0x06020523 RID: 132387 RVA: 0x00300083 File Offset: 0x002FE283
		// (set) Token: 0x06020524 RID: 132388 RVA: 0x00300097 File Offset: 0x002FE297
		public unsafe FVector Gravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIForcesCursor.__PropertyOffset_Gravity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIForcesCursor.__PropertyOffset_Gravity) = value;
			}
		}

		// Token: 0x17007EB5 RID: 32437
		// (get) Token: 0x06020525 RID: 132389 RVA: 0x003000AC File Offset: 0x002FE2AC
		// (set) Token: 0x06020526 RID: 132390 RVA: 0x003000C0 File Offset: 0x002FE2C0
		public unsafe FVector RotationRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIForcesCursor.__PropertyOffset_RotationRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIForcesCursor.__PropertyOffset_RotationRate) = value;
			}
		}

		// Token: 0x17007EB6 RID: 32438
		// (get) Token: 0x06020527 RID: 132391 RVA: 0x003000D5 File Offset: 0x002FE2D5
		// (set) Token: 0x06020528 RID: 132392 RVA: 0x003000E9 File Offset: 0x002FE2E9
		public unsafe FVector Acceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIForcesCursor.__PropertyOffset_Acceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIForcesCursor.__PropertyOffset_Acceleration) = value;
			}
		}

		// Token: 0x06020529 RID: 132393 RVA: 0x003000FE File Offset: 0x002FE2FE
		static UUIForcesCursor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIForcesCursor");
		}

		// Token: 0x0602052A RID: 132394 RVA: 0x0030010C File Offset: 0x002FE30C
		protected UUIForcesCursor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040115C6 RID: 71110
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIForcesCursor";

		// Token: 0x040115C7 RID: 71111
		private static IntPtr _ClassPtr;

		// Token: 0x040115C8 RID: 71112
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040115C9 RID: 71113
		internal static int __PropertyOffset_IsOrthographic;

		// Token: 0x040115CA RID: 71114
		internal static int __PropertyOffset_ScreenSizeX;

		// Token: 0x040115CB RID: 71115
		internal static int __PropertyOffset_ScreenSizeY;

		// Token: 0x040115CC RID: 71116
		internal static int __PropertyOffset_RotatorInfo;

		// Token: 0x040115CD RID: 71117
		internal static int __PropertyOffset_MoveVector;

		// Token: 0x040115CE RID: 71118
		internal static int __PropertyOffset_OriginPos;

		// Token: 0x040115CF RID: 71119
		internal static int __PropertyOffset_FrameStepping;

		// Token: 0x040115D0 RID: 71120
		internal static int __PropertyOffset_MaxAngleX;

		// Token: 0x040115D1 RID: 71121
		internal static int __PropertyOffset_MaxAngleY;

		// Token: 0x040115D2 RID: 71122
		internal static int __PropertyOffset_MouseX;

		// Token: 0x040115D3 RID: 71123
		internal static int __PropertyOffset_MouseY;

		// Token: 0x040115D4 RID: 71124
		internal static int __PropertyOffset_OffsetVector;

		// Token: 0x040115D5 RID: 71125
		internal static int __PropertyOffset_AroundPoint;

		// Token: 0x040115D6 RID: 71126
		internal static int __PropertyOffset_GamepadRightX;

		// Token: 0x040115D7 RID: 71127
		internal static int __PropertyOffset_GamepadRightY;

		// Token: 0x040115D8 RID: 71128
		internal static int __PropertyOffset_Tilt;

		// Token: 0x040115D9 RID: 71129
		internal static int __PropertyOffset_Gravity;

		// Token: 0x040115DA RID: 71130
		internal static int __PropertyOffset_RotationRate;

		// Token: 0x040115DB RID: 71131
		internal static int __PropertyOffset_Acceleration;
	}
}
