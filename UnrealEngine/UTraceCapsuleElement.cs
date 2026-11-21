using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200036E RID: 878
	[UnrealObjectPath("/Script/KuroData.TraceCapsuleElement")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UTraceCapsuleElement : UTraceBaseElement, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005998 RID: 22936 RVA: 0x0007E480 File Offset: 0x0007C680
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTraceCapsuleElement._ClassPtr;
		}

		// Token: 0x06005999 RID: 22937 RVA: 0x0007E48C File Offset: 0x0007C68C
		public UTraceCapsuleElement() : this(BuiltinUtils.AllocNativeUObject(UTraceCapsuleElement.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600599A RID: 22938 RVA: 0x0007E4B4 File Offset: 0x0007C6B4
		[NullableContext(1)]
		public UTraceCapsuleElement(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTraceCapsuleElement.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170011C0 RID: 4544
		// (get) Token: 0x0600599B RID: 22939 RVA: 0x0007E4E7 File Offset: 0x0007C6E7
		// (set) Token: 0x0600599C RID: 22940 RVA: 0x0007E4F7 File Offset: 0x0007C6F7
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

		// Token: 0x170011C1 RID: 4545
		// (get) Token: 0x0600599D RID: 22941 RVA: 0x0007E508 File Offset: 0x0007C708
		// (set) Token: 0x0600599E RID: 22942 RVA: 0x0007E518 File Offset: 0x0007C718
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

		// Token: 0x170011C2 RID: 4546
		// (get) Token: 0x0600599F RID: 22943 RVA: 0x0007E529 File Offset: 0x0007C729
		// (set) Token: 0x060059A0 RID: 22944 RVA: 0x0007E539 File Offset: 0x0007C739
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

		// Token: 0x170011C3 RID: 4547
		// (get) Token: 0x060059A1 RID: 22945 RVA: 0x0007E54A File Offset: 0x0007C74A
		// (set) Token: 0x060059A2 RID: 22946 RVA: 0x0007E55A File Offset: 0x0007C75A
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

		// Token: 0x170011C4 RID: 4548
		// (get) Token: 0x060059A3 RID: 22947 RVA: 0x0007E56B File Offset: 0x0007C76B
		// (set) Token: 0x060059A4 RID: 22948 RVA: 0x0007E57B File Offset: 0x0007C77B
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

		// Token: 0x060059A5 RID: 22949 RVA: 0x0007E58C File Offset: 0x0007C78C
		public void SetCapsuleOrientation(float Pitch, float Yaw, float Roll)
		{
			UTraceCapsuleElement.__SetCapsuleOrientation_Internal(base.NativePtr, Pitch, Yaw, Roll);
		}

		// Token: 0x060059A6 RID: 22950
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCapsuleOrientation_Internal(IntPtr @this, float Pitch, float Yaw, float Roll);

		// Token: 0x060059A7 RID: 22951 RVA: 0x0007E59C File Offset: 0x0007C79C
		static UTraceCapsuleElement()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroData.TraceCapsuleElement");
		}

		// Token: 0x060059A8 RID: 22952 RVA: 0x0007E5AA File Offset: 0x0007C7AA
		protected UTraceCapsuleElement(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002509 RID: 9481
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroData.TraceCapsuleElement";

		// Token: 0x0400250A RID: 9482
		private static IntPtr _ClassPtr;

		// Token: 0x0400250B RID: 9483
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400250C RID: 9484
		internal static int __PropertyOffset_Radius;

		// Token: 0x0400250D RID: 9485
		internal static int __PropertyOffset_HalfHeight;

		// Token: 0x0400250E RID: 9486
		internal static int __PropertyOffset_OrientationPitch;

		// Token: 0x0400250F RID: 9487
		internal static int __PropertyOffset_OrientationYaw;

		// Token: 0x04002510 RID: 9488
		internal static int __PropertyOffset_OrientationRoll;
	}
}
