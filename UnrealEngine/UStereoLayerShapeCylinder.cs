using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011A3 RID: 4515
	[UnrealObjectPath("/Script/Engine.StereoLayerShapeCylinder")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UStereoLayerShapeCylinder : UStereoLayerShape, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010A28 RID: 68136 RVA: 0x00186CBE File Offset: 0x00184EBE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UStereoLayerShapeCylinder._ClassPtr;
		}

		// Token: 0x06010A29 RID: 68137 RVA: 0x00186CCC File Offset: 0x00184ECC
		public UStereoLayerShapeCylinder() : this(BuiltinUtils.AllocNativeUObject(UStereoLayerShapeCylinder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010A2A RID: 68138 RVA: 0x00186CF4 File Offset: 0x00184EF4
		[NullableContext(1)]
		public UStereoLayerShapeCylinder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UStereoLayerShapeCylinder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170040EA RID: 16618
		// (get) Token: 0x06010A2B RID: 68139 RVA: 0x00186D27 File Offset: 0x00184F27
		// (set) Token: 0x06010A2C RID: 68140 RVA: 0x00186D37 File Offset: 0x00184F37
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStereoLayerShapeCylinder.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStereoLayerShapeCylinder.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x170040EB RID: 16619
		// (get) Token: 0x06010A2D RID: 68141 RVA: 0x00186D48 File Offset: 0x00184F48
		// (set) Token: 0x06010A2E RID: 68142 RVA: 0x00186D58 File Offset: 0x00184F58
		public unsafe float OverlayArc
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStereoLayerShapeCylinder.__PropertyOffset_OverlayArc);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStereoLayerShapeCylinder.__PropertyOffset_OverlayArc) = value;
			}
		}

		// Token: 0x170040EC RID: 16620
		// (get) Token: 0x06010A2F RID: 68143 RVA: 0x00186D69 File Offset: 0x00184F69
		// (set) Token: 0x06010A30 RID: 68144 RVA: 0x00186D79 File Offset: 0x00184F79
		public unsafe int Height
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStereoLayerShapeCylinder.__PropertyOffset_Height);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStereoLayerShapeCylinder.__PropertyOffset_Height) = value;
			}
		}

		// Token: 0x06010A31 RID: 68145 RVA: 0x00186D8A File Offset: 0x00184F8A
		public void SetRadius(float InRadius)
		{
			UStereoLayerShapeCylinder.__SetRadius_Internal(base.NativePtr, InRadius);
		}

		// Token: 0x06010A32 RID: 68146 RVA: 0x00186D98 File Offset: 0x00184F98
		public void SetOverlayArc(float InOverlayArc)
		{
			UStereoLayerShapeCylinder.__SetOverlayArc_Internal(base.NativePtr, InOverlayArc);
		}

		// Token: 0x06010A33 RID: 68147 RVA: 0x00186DA6 File Offset: 0x00184FA6
		public void SetHeight(int InHeight)
		{
			UStereoLayerShapeCylinder.__SetHeight_Internal(base.NativePtr, InHeight);
		}

		// Token: 0x06010A34 RID: 68148
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRadius_Internal(IntPtr @this, float InRadius);

		// Token: 0x06010A35 RID: 68149
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOverlayArc_Internal(IntPtr @this, float InOverlayArc);

		// Token: 0x06010A36 RID: 68150
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHeight_Internal(IntPtr @this, int InHeight);

		// Token: 0x06010A37 RID: 68151 RVA: 0x00186DB4 File Offset: 0x00184FB4
		static UStereoLayerShapeCylinder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.StereoLayerShapeCylinder");
		}

		// Token: 0x06010A38 RID: 68152 RVA: 0x00186DC2 File Offset: 0x00184FC2
		protected UStereoLayerShapeCylinder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008E51 RID: 36433
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.StereoLayerShapeCylinder";

		// Token: 0x04008E52 RID: 36434
		private static IntPtr _ClassPtr;

		// Token: 0x04008E53 RID: 36435
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008E54 RID: 36436
		internal static int __PropertyOffset_Radius;

		// Token: 0x04008E55 RID: 36437
		internal static int __PropertyOffset_OverlayArc;

		// Token: 0x04008E56 RID: 36438
		internal static int __PropertyOffset_Height;
	}
}
