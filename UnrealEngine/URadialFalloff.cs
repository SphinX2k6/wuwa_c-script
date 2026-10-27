using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012B9 RID: 4793
	[UnrealObjectPath("/Script/FieldSystemEngine.RadialFalloff")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class URadialFalloff : UFieldNodeFloat, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060118D4 RID: 71892 RVA: 0x0019C05E File Offset: 0x0019A25E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URadialFalloff._ClassPtr;
		}

		// Token: 0x060118D5 RID: 71893 RVA: 0x0019C06C File Offset: 0x0019A26C
		public URadialFalloff() : this(BuiltinUtils.AllocNativeUObject(URadialFalloff.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060118D6 RID: 71894 RVA: 0x0019C094 File Offset: 0x0019A294
		[NullableContext(1)]
		public URadialFalloff(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URadialFalloff.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700447D RID: 17533
		// (get) Token: 0x060118D7 RID: 71895 RVA: 0x0019C0C7 File Offset: 0x0019A2C7
		// (set) Token: 0x060118D8 RID: 71896 RVA: 0x0019C0D7 File Offset: 0x0019A2D7
		public unsafe float Magnitude
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URadialFalloff.__PropertyOffset_Magnitude);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URadialFalloff.__PropertyOffset_Magnitude) = value;
			}
		}

		// Token: 0x1700447E RID: 17534
		// (get) Token: 0x060118D9 RID: 71897 RVA: 0x0019C0E8 File Offset: 0x0019A2E8
		// (set) Token: 0x060118DA RID: 71898 RVA: 0x0019C0F8 File Offset: 0x0019A2F8
		public unsafe float MinRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URadialFalloff.__PropertyOffset_MinRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URadialFalloff.__PropertyOffset_MinRange) = value;
			}
		}

		// Token: 0x1700447F RID: 17535
		// (get) Token: 0x060118DB RID: 71899 RVA: 0x0019C109 File Offset: 0x0019A309
		// (set) Token: 0x060118DC RID: 71900 RVA: 0x0019C119 File Offset: 0x0019A319
		public unsafe float MaxRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URadialFalloff.__PropertyOffset_MaxRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URadialFalloff.__PropertyOffset_MaxRange) = value;
			}
		}

		// Token: 0x17004480 RID: 17536
		// (get) Token: 0x060118DD RID: 71901 RVA: 0x0019C12A File Offset: 0x0019A32A
		// (set) Token: 0x060118DE RID: 71902 RVA: 0x0019C13A File Offset: 0x0019A33A
		public unsafe float Default
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URadialFalloff.__PropertyOffset_Default);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URadialFalloff.__PropertyOffset_Default) = value;
			}
		}

		// Token: 0x17004481 RID: 17537
		// (get) Token: 0x060118DF RID: 71903 RVA: 0x0019C14B File Offset: 0x0019A34B
		// (set) Token: 0x060118E0 RID: 71904 RVA: 0x0019C15B File Offset: 0x0019A35B
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URadialFalloff.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URadialFalloff.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x17004482 RID: 17538
		// (get) Token: 0x060118E1 RID: 71905 RVA: 0x0019C16C File Offset: 0x0019A36C
		// (set) Token: 0x060118E2 RID: 71906 RVA: 0x0019C180 File Offset: 0x0019A380
		public unsafe FVector Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URadialFalloff.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URadialFalloff.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x17004483 RID: 17539
		// (get) Token: 0x060118E3 RID: 71907 RVA: 0x0019C195 File Offset: 0x0019A395
		// (set) Token: 0x060118E4 RID: 71908 RVA: 0x0019C1A9 File Offset: 0x0019A3A9
		public unsafe TEnumAsByte<EFieldFalloffType> Falloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URadialFalloff.__PropertyOffset_Falloff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URadialFalloff.__PropertyOffset_Falloff) = value;
			}
		}

		// Token: 0x060118E5 RID: 71909 RVA: 0x0019C1BE File Offset: 0x0019A3BE
		[NullableContext(2)]
		public URadialFalloff SetRadialFalloff(float Magnitude, float MinRange, float MaxRange, float Default, float Radius, FVector Position, EFieldFalloffType Falloff)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<URadialFalloff>(URadialFalloff.__SetRadialFalloff_Internal(base.NativePtr, Magnitude, MinRange, MaxRange, Default, Radius, Position, Falloff));
		}

		// Token: 0x060118E6 RID: 71910
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetRadialFalloff_Internal(IntPtr @this, float Magnitude, float MinRange, float MaxRange, float Default, float Radius, FVector Position, TEnumAsByte<EFieldFalloffType> Falloff);

		// Token: 0x060118E7 RID: 71911 RVA: 0x0019C1E0 File Offset: 0x0019A3E0
		static URadialFalloff()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/FieldSystemEngine.RadialFalloff");
		}

		// Token: 0x060118E8 RID: 71912 RVA: 0x0019C1EE File Offset: 0x0019A3EE
		protected URadialFalloff(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400966E RID: 38510
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/FieldSystemEngine.RadialFalloff";

		// Token: 0x0400966F RID: 38511
		private static IntPtr _ClassPtr;

		// Token: 0x04009670 RID: 38512
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009671 RID: 38513
		internal static int __PropertyOffset_Magnitude;

		// Token: 0x04009672 RID: 38514
		internal static int __PropertyOffset_MinRange;

		// Token: 0x04009673 RID: 38515
		internal static int __PropertyOffset_MaxRange;

		// Token: 0x04009674 RID: 38516
		internal static int __PropertyOffset_Default;

		// Token: 0x04009675 RID: 38517
		internal static int __PropertyOffset_Radius;

		// Token: 0x04009676 RID: 38518
		internal static int __PropertyOffset_Position;

		// Token: 0x04009677 RID: 38519
		internal static int __PropertyOffset_Falloff;
	}
}
