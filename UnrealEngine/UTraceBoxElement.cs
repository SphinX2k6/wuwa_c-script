using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017FB RID: 6139
	[UnrealObjectPath("/Script/KuroData.TraceBoxElement")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UTraceBoxElement : UTraceBaseElement, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016BAD RID: 93101 RVA: 0x00212BFA File Offset: 0x00210DFA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTraceBoxElement._ClassPtr;
		}

		// Token: 0x06016BAE RID: 93102 RVA: 0x00212C08 File Offset: 0x00210E08
		public UTraceBoxElement() : this(BuiltinUtils.AllocNativeUObject(UTraceBoxElement.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016BAF RID: 93103 RVA: 0x00212C30 File Offset: 0x00210E30
		[NullableContext(1)]
		public UTraceBoxElement(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTraceBoxElement.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005BE6 RID: 23526
		// (get) Token: 0x06016BB0 RID: 93104 RVA: 0x00212C63 File Offset: 0x00210E63
		// (set) Token: 0x06016BB1 RID: 93105 RVA: 0x00212C73 File Offset: 0x00210E73
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

		// Token: 0x17005BE7 RID: 23527
		// (get) Token: 0x06016BB2 RID: 93106 RVA: 0x00212C84 File Offset: 0x00210E84
		// (set) Token: 0x06016BB3 RID: 93107 RVA: 0x00212C94 File Offset: 0x00210E94
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

		// Token: 0x17005BE8 RID: 23528
		// (get) Token: 0x06016BB4 RID: 93108 RVA: 0x00212CA5 File Offset: 0x00210EA5
		// (set) Token: 0x06016BB5 RID: 93109 RVA: 0x00212CB5 File Offset: 0x00210EB5
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

		// Token: 0x17005BE9 RID: 23529
		// (get) Token: 0x06016BB6 RID: 93110 RVA: 0x00212CC6 File Offset: 0x00210EC6
		// (set) Token: 0x06016BB7 RID: 93111 RVA: 0x00212CD6 File Offset: 0x00210ED6
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

		// Token: 0x17005BEA RID: 23530
		// (get) Token: 0x06016BB8 RID: 93112 RVA: 0x00212CE7 File Offset: 0x00210EE7
		// (set) Token: 0x06016BB9 RID: 93113 RVA: 0x00212CF7 File Offset: 0x00210EF7
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

		// Token: 0x17005BEB RID: 23531
		// (get) Token: 0x06016BBA RID: 93114 RVA: 0x00212D08 File Offset: 0x00210F08
		// (set) Token: 0x06016BBB RID: 93115 RVA: 0x00212D18 File Offset: 0x00210F18
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

		// Token: 0x06016BBC RID: 93116 RVA: 0x00212D29 File Offset: 0x00210F29
		public void SetBoxOrientation(float Pitch, float Yaw, float Roll)
		{
			UTraceBoxElement.__SetBoxOrientation_Internal(base.NativePtr, Pitch, Yaw, Roll);
		}

		// Token: 0x06016BBD RID: 93117 RVA: 0x00212D39 File Offset: 0x00210F39
		public void SetBoxHalfSize(float X, float Y, float Z)
		{
			UTraceBoxElement.__SetBoxHalfSize_Internal(base.NativePtr, X, Y, Z);
		}

		// Token: 0x06016BBE RID: 93118
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBoxOrientation_Internal(IntPtr @this, float Pitch, float Yaw, float Roll);

		// Token: 0x06016BBF RID: 93119
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBoxHalfSize_Internal(IntPtr @this, float X, float Y, float Z);

		// Token: 0x06016BC0 RID: 93120 RVA: 0x00212D49 File Offset: 0x00210F49
		static UTraceBoxElement()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroData.TraceBoxElement");
		}

		// Token: 0x06016BC1 RID: 93121 RVA: 0x00212D57 File Offset: 0x00210F57
		protected UTraceBoxElement(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C568 RID: 50536
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroData.TraceBoxElement";

		// Token: 0x0400C569 RID: 50537
		private static IntPtr _ClassPtr;

		// Token: 0x0400C56A RID: 50538
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C56B RID: 50539
		internal static int __PropertyOffset_HalfSizeX;

		// Token: 0x0400C56C RID: 50540
		internal static int __PropertyOffset_HalfSizeY;

		// Token: 0x0400C56D RID: 50541
		internal static int __PropertyOffset_HalfSizeZ;

		// Token: 0x0400C56E RID: 50542
		internal static int __PropertyOffset_OrientationPitch;

		// Token: 0x0400C56F RID: 50543
		internal static int __PropertyOffset_OrientationYaw;

		// Token: 0x0400C570 RID: 50544
		internal static int __PropertyOffset_OrientationRoll;
	}
}
