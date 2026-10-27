using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017FC RID: 6140
	[UnrealObjectPath("/Script/KuroData.TraceCapsuleElement")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UTraceCapsuleElement : UTraceBaseElement, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016BC2 RID: 93122 RVA: 0x00212D60 File Offset: 0x00210F60
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTraceCapsuleElement._ClassPtr;
		}

		// Token: 0x06016BC3 RID: 93123 RVA: 0x00212D6C File Offset: 0x00210F6C
		public UTraceCapsuleElement() : this(BuiltinUtils.AllocNativeUObject(UTraceCapsuleElement.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016BC4 RID: 93124 RVA: 0x00212D94 File Offset: 0x00210F94
		[NullableContext(1)]
		public UTraceCapsuleElement(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTraceCapsuleElement.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005BEC RID: 23532
		// (get) Token: 0x06016BC5 RID: 93125 RVA: 0x00212DC7 File Offset: 0x00210FC7
		// (set) Token: 0x06016BC6 RID: 93126 RVA: 0x00212DD7 File Offset: 0x00210FD7
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTraceCapsuleElement.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTraceCapsuleElement.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x17005BED RID: 23533
		// (get) Token: 0x06016BC7 RID: 93127 RVA: 0x00212DE8 File Offset: 0x00210FE8
		// (set) Token: 0x06016BC8 RID: 93128 RVA: 0x00212DF8 File Offset: 0x00210FF8
		public unsafe float HalfHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTraceCapsuleElement.__PropertyOffset_HalfHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTraceCapsuleElement.__PropertyOffset_HalfHeight) = value;
			}
		}

		// Token: 0x17005BEE RID: 23534
		// (get) Token: 0x06016BC9 RID: 93129 RVA: 0x00212E09 File Offset: 0x00211009
		// (set) Token: 0x06016BCA RID: 93130 RVA: 0x00212E19 File Offset: 0x00211019
		public unsafe float OrientationPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTraceCapsuleElement.__PropertyOffset_OrientationPitch);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTraceCapsuleElement.__PropertyOffset_OrientationPitch) = value;
			}
		}

		// Token: 0x17005BEF RID: 23535
		// (get) Token: 0x06016BCB RID: 93131 RVA: 0x00212E2A File Offset: 0x0021102A
		// (set) Token: 0x06016BCC RID: 93132 RVA: 0x00212E3A File Offset: 0x0021103A
		public unsafe float OrientationYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTraceCapsuleElement.__PropertyOffset_OrientationYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTraceCapsuleElement.__PropertyOffset_OrientationYaw) = value;
			}
		}

		// Token: 0x17005BF0 RID: 23536
		// (get) Token: 0x06016BCD RID: 93133 RVA: 0x00212E4B File Offset: 0x0021104B
		// (set) Token: 0x06016BCE RID: 93134 RVA: 0x00212E5B File Offset: 0x0021105B
		public unsafe float OrientationRoll
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTraceCapsuleElement.__PropertyOffset_OrientationRoll);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTraceCapsuleElement.__PropertyOffset_OrientationRoll) = value;
			}
		}

		// Token: 0x06016BCF RID: 93135 RVA: 0x00212E6C File Offset: 0x0021106C
		public void SetCapsuleOrientation(float Pitch, float Yaw, float Roll)
		{
			UTraceCapsuleElement.__SetCapsuleOrientation_Internal(base.NativePtr, Pitch, Yaw, Roll);
		}

		// Token: 0x06016BD0 RID: 93136
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCapsuleOrientation_Internal(IntPtr @this, float Pitch, float Yaw, float Roll);

		// Token: 0x06016BD1 RID: 93137 RVA: 0x00212E7C File Offset: 0x0021107C
		static UTraceCapsuleElement()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroData.TraceCapsuleElement");
		}

		// Token: 0x06016BD2 RID: 93138 RVA: 0x00212E8A File Offset: 0x0021108A
		protected UTraceCapsuleElement(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C571 RID: 50545
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroData.TraceCapsuleElement";

		// Token: 0x0400C572 RID: 50546
		private static IntPtr _ClassPtr;

		// Token: 0x0400C573 RID: 50547
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C574 RID: 50548
		internal static int __PropertyOffset_Radius;

		// Token: 0x0400C575 RID: 50549
		internal static int __PropertyOffset_HalfHeight;

		// Token: 0x0400C576 RID: 50550
		internal static int __PropertyOffset_OrientationPitch;

		// Token: 0x0400C577 RID: 50551
		internal static int __PropertyOffset_OrientationYaw;

		// Token: 0x0400C578 RID: 50552
		internal static int __PropertyOffset_OrientationRoll;
	}
}
