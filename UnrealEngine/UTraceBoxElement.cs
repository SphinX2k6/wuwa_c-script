using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200036D RID: 877
	[UnrealObjectPath("/Script/KuroData.TraceBoxElement")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UTraceBoxElement : UTraceBaseElement, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005983 RID: 22915 RVA: 0x0007E31A File Offset: 0x0007C51A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTraceBoxElement._ClassPtr;
		}

		// Token: 0x06005984 RID: 22916 RVA: 0x0007E328 File Offset: 0x0007C528
		public UTraceBoxElement() : this(BuiltinUtils.AllocNativeUObject(UTraceBoxElement.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005985 RID: 22917 RVA: 0x0007E350 File Offset: 0x0007C550
		[NullableContext(1)]
		public UTraceBoxElement(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTraceBoxElement.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170011BA RID: 4538
		// (get) Token: 0x06005986 RID: 22918 RVA: 0x0007E383 File Offset: 0x0007C583
		// (set) Token: 0x06005987 RID: 22919 RVA: 0x0007E393 File Offset: 0x0007C593
		public unsafe float HalfSizeX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTraceBoxElement.__PropertyOffset_HalfSizeX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTraceBoxElement.__PropertyOffset_HalfSizeX) = value;
			}
		}

		// Token: 0x170011BB RID: 4539
		// (get) Token: 0x06005988 RID: 22920 RVA: 0x0007E3A4 File Offset: 0x0007C5A4
		// (set) Token: 0x06005989 RID: 22921 RVA: 0x0007E3B4 File Offset: 0x0007C5B4
		public unsafe float HalfSizeY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTraceBoxElement.__PropertyOffset_HalfSizeY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTraceBoxElement.__PropertyOffset_HalfSizeY) = value;
			}
		}

		// Token: 0x170011BC RID: 4540
		// (get) Token: 0x0600598A RID: 22922 RVA: 0x0007E3C5 File Offset: 0x0007C5C5
		// (set) Token: 0x0600598B RID: 22923 RVA: 0x0007E3D5 File Offset: 0x0007C5D5
		public unsafe float HalfSizeZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTraceBoxElement.__PropertyOffset_HalfSizeZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTraceBoxElement.__PropertyOffset_HalfSizeZ) = value;
			}
		}

		// Token: 0x170011BD RID: 4541
		// (get) Token: 0x0600598C RID: 22924 RVA: 0x0007E3E6 File Offset: 0x0007C5E6
		// (set) Token: 0x0600598D RID: 22925 RVA: 0x0007E3F6 File Offset: 0x0007C5F6
		public unsafe float OrientationPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTraceBoxElement.__PropertyOffset_OrientationPitch);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTraceBoxElement.__PropertyOffset_OrientationPitch) = value;
			}
		}

		// Token: 0x170011BE RID: 4542
		// (get) Token: 0x0600598E RID: 22926 RVA: 0x0007E407 File Offset: 0x0007C607
		// (set) Token: 0x0600598F RID: 22927 RVA: 0x0007E417 File Offset: 0x0007C617
		public unsafe float OrientationYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTraceBoxElement.__PropertyOffset_OrientationYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTraceBoxElement.__PropertyOffset_OrientationYaw) = value;
			}
		}

		// Token: 0x170011BF RID: 4543
		// (get) Token: 0x06005990 RID: 22928 RVA: 0x0007E428 File Offset: 0x0007C628
		// (set) Token: 0x06005991 RID: 22929 RVA: 0x0007E438 File Offset: 0x0007C638
		public unsafe float OrientationRoll
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTraceBoxElement.__PropertyOffset_OrientationRoll);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTraceBoxElement.__PropertyOffset_OrientationRoll) = value;
			}
		}

		// Token: 0x06005992 RID: 22930 RVA: 0x0007E449 File Offset: 0x0007C649
		public void SetBoxOrientation(float Pitch, float Yaw, float Roll)
		{
			UTraceBoxElement.__SetBoxOrientation_Internal(base.NativePtr, Pitch, Yaw, Roll);
		}

		// Token: 0x06005993 RID: 22931 RVA: 0x0007E459 File Offset: 0x0007C659
		public void SetBoxHalfSize(float X, float Y, float Z)
		{
			UTraceBoxElement.__SetBoxHalfSize_Internal(base.NativePtr, X, Y, Z);
		}

		// Token: 0x06005994 RID: 22932
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBoxOrientation_Internal(IntPtr @this, float Pitch, float Yaw, float Roll);

		// Token: 0x06005995 RID: 22933
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBoxHalfSize_Internal(IntPtr @this, float X, float Y, float Z);

		// Token: 0x06005996 RID: 22934 RVA: 0x0007E469 File Offset: 0x0007C669
		static UTraceBoxElement()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroData.TraceBoxElement");
		}

		// Token: 0x06005997 RID: 22935 RVA: 0x0007E477 File Offset: 0x0007C677
		protected UTraceBoxElement(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002500 RID: 9472
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroData.TraceBoxElement";

		// Token: 0x04002501 RID: 9473
		private static IntPtr _ClassPtr;

		// Token: 0x04002502 RID: 9474
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002503 RID: 9475
		internal static int __PropertyOffset_HalfSizeX;

		// Token: 0x04002504 RID: 9476
		internal static int __PropertyOffset_HalfSizeY;

		// Token: 0x04002505 RID: 9477
		internal static int __PropertyOffset_HalfSizeZ;

		// Token: 0x04002506 RID: 9478
		internal static int __PropertyOffset_OrientationPitch;

		// Token: 0x04002507 RID: 9479
		internal static int __PropertyOffset_OrientationYaw;

		// Token: 0x04002508 RID: 9480
		internal static int __PropertyOffset_OrientationRoll;
	}
}
