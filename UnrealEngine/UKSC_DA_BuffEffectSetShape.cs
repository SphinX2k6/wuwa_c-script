using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D4F RID: 7503
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_BuffEffectSetShape")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UKSC_DA_BuffEffectSetShape : UKSC_DA_BuffEffectBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CBC8 RID: 117704 RVA: 0x002A7A3F File Offset: 0x002A5C3F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_BuffEffectSetShape._ClassPtr;
		}

		// Token: 0x0601CBC9 RID: 117705 RVA: 0x002A7A4C File Offset: 0x002A5C4C
		public UKSC_DA_BuffEffectSetShape() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_BuffEffectSetShape.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CBCA RID: 117706 RVA: 0x002A7A74 File Offset: 0x002A5C74
		[NullableContext(1)]
		public UKSC_DA_BuffEffectSetShape(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_BuffEffectSetShape.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170073A2 RID: 29602
		// (get) Token: 0x0601CBCB RID: 117707 RVA: 0x002A7AA7 File Offset: 0x002A5CA7
		// (set) Token: 0x0601CBCC RID: 117708 RVA: 0x002A7AB7 File Offset: 0x002A5CB7
		public unsafe EKSC_SetShapeType SetType
		{
			get
			{
				return (EKSC_SetShapeType)(*(base.NativePtr + (IntPtr)UKSC_DA_BuffEffectSetShape.__PropertyOffset_SetType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_BuffEffectSetShape.__PropertyOffset_SetType) = (byte)value;
			}
		}

		// Token: 0x170073A3 RID: 29603
		// (get) Token: 0x0601CBCD RID: 117709 RVA: 0x002A7AC8 File Offset: 0x002A5CC8
		// (set) Token: 0x0601CBCE RID: 117710 RVA: 0x002A7ADC File Offset: 0x002A5CDC
		public unsafe FVector2D Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_BuffEffectSetShape.__PropertyOffset_Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_BuffEffectSetShape.__PropertyOffset_Size) = value;
			}
		}

		// Token: 0x170073A4 RID: 29604
		// (get) Token: 0x0601CBCF RID: 117711 RVA: 0x002A7AF1 File Offset: 0x002A5CF1
		// (set) Token: 0x0601CBD0 RID: 117712 RVA: 0x002A7B01 File Offset: 0x002A5D01
		public unsafe float Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_BuffEffectSetShape.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_BuffEffectSetShape.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x170073A5 RID: 29605
		// (get) Token: 0x0601CBD1 RID: 117713 RVA: 0x002A7B12 File Offset: 0x002A5D12
		// (set) Token: 0x0601CBD2 RID: 117714 RVA: 0x002A7B22 File Offset: 0x002A5D22
		public unsafe bool Revert
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_BuffEffectSetShape.__PropertyOffset_Revert) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_BuffEffectSetShape.__PropertyOffset_Revert) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601CBD3 RID: 117715 RVA: 0x002A7B33 File Offset: 0x002A5D33
		static UKSC_DA_BuffEffectSetShape()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_BuffEffectSetShape");
		}

		// Token: 0x0601CBD4 RID: 117716 RVA: 0x002A7B41 File Offset: 0x002A5D41
		protected UKSC_DA_BuffEffectSetShape(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F94D RID: 63821
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_BuffEffectSetShape";

		// Token: 0x0400F94E RID: 63822
		private static IntPtr _ClassPtr;

		// Token: 0x0400F94F RID: 63823
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F950 RID: 63824
		internal static int __PropertyOffset_SetType;

		// Token: 0x0400F951 RID: 63825
		internal static int __PropertyOffset_Size;

		// Token: 0x0400F952 RID: 63826
		internal static int __PropertyOffset_Scale;

		// Token: 0x0400F953 RID: 63827
		internal static int __PropertyOffset_Revert;
	}
}
