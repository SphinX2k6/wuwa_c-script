using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200058B RID: 1419
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Shape2D_Entity_Bar")]
	[UnrealStructLayout(1552, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1552)]
	public class AKSC_Shape2D_Entity_Bar : AKSC_Shape2D_Entity, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008091 RID: 32913 RVA: 0x000BDEA8 File Offset: 0x000BC0A8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKSC_Shape2D_Entity_Bar._ClassPtr;
		}

		// Token: 0x06008092 RID: 32914 RVA: 0x000BDEB4 File Offset: 0x000BC0B4
		public AKSC_Shape2D_Entity_Bar() : this(BuiltinUtils.AllocNativeUObject(AKSC_Shape2D_Entity_Bar.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008093 RID: 32915 RVA: 0x000BDEDC File Offset: 0x000BC0DC
		[NullableContext(1)]
		public AKSC_Shape2D_Entity_Bar(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKSC_Shape2D_Entity_Bar.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700190D RID: 6413
		// (get) Token: 0x06008094 RID: 32916 RVA: 0x000BDF0F File Offset: 0x000BC10F
		// (set) Token: 0x06008095 RID: 32917 RVA: 0x000BDF1F File Offset: 0x000BC11F
		public unsafe EKSC_ShapeBarSide Side
		{
			get
			{
				return (EKSC_ShapeBarSide)(*(base.NativePtr + (IntPtr)AKSC_Shape2D_Entity_Bar.__PropertyOffset_Side));
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKSC_Shape2D_Entity_Bar.__PropertyOffset_Side) = (byte)value;
			}
		}

		// Token: 0x1700190E RID: 6414
		// (get) Token: 0x06008096 RID: 32918 RVA: 0x000BDF30 File Offset: 0x000BC130
		// (set) Token: 0x06008097 RID: 32919 RVA: 0x000BDF40 File Offset: 0x000BC140
		public unsafe bool IsShowLaunchDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKSC_Shape2D_Entity_Bar.__PropertyOffset_IsShowLaunchDirection) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKSC_Shape2D_Entity_Bar.__PropertyOffset_IsShowLaunchDirection) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700190F RID: 6415
		// (get) Token: 0x06008098 RID: 32920 RVA: 0x000BDF51 File Offset: 0x000BC151
		// (set) Token: 0x06008099 RID: 32921 RVA: 0x000BDF65 File Offset: 0x000BC165
		public unsafe FVector LaunchStartPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKSC_Shape2D_Entity_Bar.__PropertyOffset_LaunchStartPoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKSC_Shape2D_Entity_Bar.__PropertyOffset_LaunchStartPoint) = value;
			}
		}

		// Token: 0x17001910 RID: 6416
		// (get) Token: 0x0600809A RID: 32922 RVA: 0x000BDF7A File Offset: 0x000BC17A
		// (set) Token: 0x0600809B RID: 32923 RVA: 0x000BDF8A File Offset: 0x000BC18A
		public unsafe float LaunchRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKSC_Shape2D_Entity_Bar.__PropertyOffset_LaunchRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKSC_Shape2D_Entity_Bar.__PropertyOffset_LaunchRotation) = value;
			}
		}

		// Token: 0x17001911 RID: 6417
		// (get) Token: 0x0600809C RID: 32924 RVA: 0x000BDF9B File Offset: 0x000BC19B
		// (set) Token: 0x0600809D RID: 32925 RVA: 0x000BDFAF File Offset: 0x000BC1AF
		[Nullable(2)]
		public unsafe UCurveFloat DirectionCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Shape2D_Entity_Bar.__PropertyOffset_DirectionCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Shape2D_Entity_Bar.__PropertyOffset_DirectionCurve, value);
			}
		}

		// Token: 0x0600809E RID: 32926 RVA: 0x000BDFC4 File Offset: 0x000BC1C4
		public void TriggerBar()
		{
			AKSC_Shape2D_Entity_Bar.__TriggerBar_Internal(base.NativePtr);
		}

		// Token: 0x0600809F RID: 32927
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TriggerBar_Internal(IntPtr @this);

		// Token: 0x060080A0 RID: 32928 RVA: 0x000BDFD1 File Offset: 0x000BC1D1
		static AKSC_Shape2D_Entity_Bar()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Shape2D_Entity_Bar");
		}

		// Token: 0x060080A1 RID: 32929 RVA: 0x000BDFDF File Offset: 0x000BC1DF
		protected AKSC_Shape2D_Entity_Bar(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003824 RID: 14372
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Shape2D_Entity_Bar";

		// Token: 0x04003825 RID: 14373
		private static IntPtr _ClassPtr;

		// Token: 0x04003826 RID: 14374
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003827 RID: 14375
		internal static int __PropertyOffset_Side;

		// Token: 0x04003828 RID: 14376
		internal static int __PropertyOffset_IsShowLaunchDirection;

		// Token: 0x04003829 RID: 14377
		internal static int __PropertyOffset_LaunchStartPoint;

		// Token: 0x0400382A RID: 14378
		internal static int __PropertyOffset_LaunchRotation;

		// Token: 0x0400382B RID: 14379
		internal static int __PropertyOffset_DirectionCurve;
	}
}
