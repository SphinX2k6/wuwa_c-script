using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001ADD RID: 6877
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroDebugDrawComponent")]
	[UnrealStructLayout(640, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 640)]
	public class UKuroDebugDrawComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060199F0 RID: 104944 RVA: 0x0025DDBC File Offset: 0x0025BFBC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroDebugDrawComponent._ClassPtr;
		}

		// Token: 0x060199F1 RID: 104945 RVA: 0x0025DDC8 File Offset: 0x0025BFC8
		public UKuroDebugDrawComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroDebugDrawComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060199F2 RID: 104946 RVA: 0x0025DDF0 File Offset: 0x0025BFF0
		[NullableContext(1)]
		public UKuroDebugDrawComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroDebugDrawComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006652 RID: 26194
		// (get) Token: 0x060199F3 RID: 104947 RVA: 0x0025DE23 File Offset: 0x0025C023
		// (set) Token: 0x060199F4 RID: 104948 RVA: 0x0025DE33 File Offset: 0x0025C033
		public unsafe EKuroDebugDrawComponentType Type
		{
			get
			{
				return (EKuroDebugDrawComponentType)(*(base.NativePtr + (IntPtr)UKuroDebugDrawComponent.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDebugDrawComponent.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x17006653 RID: 26195
		// (get) Token: 0x060199F5 RID: 104949 RVA: 0x0025DE44 File Offset: 0x0025C044
		// (set) Token: 0x060199F6 RID: 104950 RVA: 0x0025DE58 File Offset: 0x0025C058
		public unsafe FVector Center
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDebugDrawComponent.__PropertyOffset_Center);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDebugDrawComponent.__PropertyOffset_Center) = value;
			}
		}

		// Token: 0x17006654 RID: 26196
		// (get) Token: 0x060199F7 RID: 104951 RVA: 0x0025DE6D File Offset: 0x0025C06D
		// (set) Token: 0x060199F8 RID: 104952 RVA: 0x0025DE81 File Offset: 0x0025C081
		public unsafe FVector Extent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDebugDrawComponent.__PropertyOffset_Extent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDebugDrawComponent.__PropertyOffset_Extent) = value;
			}
		}

		// Token: 0x17006655 RID: 26197
		// (get) Token: 0x060199F9 RID: 104953 RVA: 0x0025DE96 File Offset: 0x0025C096
		// (set) Token: 0x060199FA RID: 104954 RVA: 0x0025DEA6 File Offset: 0x0025C0A6
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDebugDrawComponent.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDebugDrawComponent.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x17006656 RID: 26198
		// (get) Token: 0x060199FB RID: 104955 RVA: 0x0025DEB7 File Offset: 0x0025C0B7
		// (set) Token: 0x060199FC RID: 104956 RVA: 0x0025DEC7 File Offset: 0x0025C0C7
		public unsafe float Angle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDebugDrawComponent.__PropertyOffset_Angle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDebugDrawComponent.__PropertyOffset_Angle) = value;
			}
		}

		// Token: 0x17006657 RID: 26199
		// (get) Token: 0x060199FD RID: 104957 RVA: 0x0025DED8 File Offset: 0x0025C0D8
		// (set) Token: 0x060199FE RID: 104958 RVA: 0x0025DEEC File Offset: 0x0025C0EC
		public unsafe FName VisibleGroup
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDebugDrawComponent.__PropertyOffset_VisibleGroup);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDebugDrawComponent.__PropertyOffset_VisibleGroup) = value;
			}
		}

		// Token: 0x17006658 RID: 26200
		// (get) Token: 0x060199FF RID: 104959 RVA: 0x0025DF01 File Offset: 0x0025C101
		// (set) Token: 0x06019A00 RID: 104960 RVA: 0x0025DF15 File Offset: 0x0025C115
		public unsafe FLinearColor DebugDrawColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDebugDrawComponent.__PropertyOffset_DebugDrawColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDebugDrawComponent.__PropertyOffset_DebugDrawColor) = value;
			}
		}

		// Token: 0x06019A01 RID: 104961 RVA: 0x0025DF2A File Offset: 0x0025C12A
		static UKuroDebugDrawComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroDebugDrawComponent");
		}

		// Token: 0x06019A02 RID: 104962 RVA: 0x0025DF38 File Offset: 0x0025C138
		protected UKuroDebugDrawComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DF12 RID: 57106
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroDebugDrawComponent";

		// Token: 0x0400DF13 RID: 57107
		private static IntPtr _ClassPtr;

		// Token: 0x0400DF14 RID: 57108
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400DF15 RID: 57109
		internal static int __PropertyOffset_Type;

		// Token: 0x0400DF16 RID: 57110
		internal static int __PropertyOffset_Center;

		// Token: 0x0400DF17 RID: 57111
		internal static int __PropertyOffset_Extent;

		// Token: 0x0400DF18 RID: 57112
		internal static int __PropertyOffset_Radius;

		// Token: 0x0400DF19 RID: 57113
		internal static int __PropertyOffset_Angle;

		// Token: 0x0400DF1A RID: 57114
		internal static int __PropertyOffset_VisibleGroup;

		// Token: 0x0400DF1B RID: 57115
		internal static int __PropertyOffset_DebugDrawColor;
	}
}
