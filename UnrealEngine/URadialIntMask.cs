using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012BA RID: 4794
	[UnrealObjectPath("/Script/FieldSystemEngine.RadialIntMask")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public class URadialIntMask : UFieldNodeInt, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060118E9 RID: 71913 RVA: 0x0019C1F7 File Offset: 0x0019A3F7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URadialIntMask._ClassPtr;
		}

		// Token: 0x060118EA RID: 71914 RVA: 0x0019C204 File Offset: 0x0019A404
		public URadialIntMask() : this(BuiltinUtils.AllocNativeUObject(URadialIntMask.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060118EB RID: 71915 RVA: 0x0019C22C File Offset: 0x0019A42C
		[NullableContext(1)]
		public URadialIntMask(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URadialIntMask.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004484 RID: 17540
		// (get) Token: 0x060118EC RID: 71916 RVA: 0x0019C25F File Offset: 0x0019A45F
		// (set) Token: 0x060118ED RID: 71917 RVA: 0x0019C26F File Offset: 0x0019A46F
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URadialIntMask.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URadialIntMask.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x17004485 RID: 17541
		// (get) Token: 0x060118EE RID: 71918 RVA: 0x0019C280 File Offset: 0x0019A480
		// (set) Token: 0x060118EF RID: 71919 RVA: 0x0019C294 File Offset: 0x0019A494
		public unsafe FVector Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URadialIntMask.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URadialIntMask.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x17004486 RID: 17542
		// (get) Token: 0x060118F0 RID: 71920 RVA: 0x0019C2A9 File Offset: 0x0019A4A9
		// (set) Token: 0x060118F1 RID: 71921 RVA: 0x0019C2B9 File Offset: 0x0019A4B9
		public unsafe int InteriorValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URadialIntMask.__PropertyOffset_InteriorValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URadialIntMask.__PropertyOffset_InteriorValue) = value;
			}
		}

		// Token: 0x17004487 RID: 17543
		// (get) Token: 0x060118F2 RID: 71922 RVA: 0x0019C2CA File Offset: 0x0019A4CA
		// (set) Token: 0x060118F3 RID: 71923 RVA: 0x0019C2DA File Offset: 0x0019A4DA
		public unsafe int ExteriorValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URadialIntMask.__PropertyOffset_ExteriorValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URadialIntMask.__PropertyOffset_ExteriorValue) = value;
			}
		}

		// Token: 0x17004488 RID: 17544
		// (get) Token: 0x060118F4 RID: 71924 RVA: 0x0019C2EB File Offset: 0x0019A4EB
		// (set) Token: 0x060118F5 RID: 71925 RVA: 0x0019C2FF File Offset: 0x0019A4FF
		public unsafe TEnumAsByte<ESetMaskConditionType> SetMaskCondition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URadialIntMask.__PropertyOffset_SetMaskCondition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URadialIntMask.__PropertyOffset_SetMaskCondition) = value;
			}
		}

		// Token: 0x060118F6 RID: 71926 RVA: 0x0019C314 File Offset: 0x0019A514
		[NullableContext(2)]
		public URadialIntMask SetRadialIntMask(float Radius, FVector Position, int InteriorValue, int ExteriorValue, ESetMaskConditionType SetMaskConditionIn)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<URadialIntMask>(URadialIntMask.__SetRadialIntMask_Internal(base.NativePtr, Radius, Position, InteriorValue, ExteriorValue, SetMaskConditionIn));
		}

		// Token: 0x060118F7 RID: 71927
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetRadialIntMask_Internal(IntPtr @this, float Radius, FVector Position, int InteriorValue, int ExteriorValue, TEnumAsByte<ESetMaskConditionType> SetMaskConditionIn);

		// Token: 0x060118F8 RID: 71928 RVA: 0x0019C332 File Offset: 0x0019A532
		static URadialIntMask()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/FieldSystemEngine.RadialIntMask");
		}

		// Token: 0x060118F9 RID: 71929 RVA: 0x0019C340 File Offset: 0x0019A540
		protected URadialIntMask(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009678 RID: 38520
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/FieldSystemEngine.RadialIntMask";

		// Token: 0x04009679 RID: 38521
		private static IntPtr _ClassPtr;

		// Token: 0x0400967A RID: 38522
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400967B RID: 38523
		internal static int __PropertyOffset_Radius;

		// Token: 0x0400967C RID: 38524
		internal static int __PropertyOffset_Position;

		// Token: 0x0400967D RID: 38525
		internal static int __PropertyOffset_InteriorValue;

		// Token: 0x0400967E RID: 38526
		internal static int __PropertyOffset_ExteriorValue;

		// Token: 0x0400967F RID: 38527
		internal static int __PropertyOffset_SetMaskCondition;
	}
}
