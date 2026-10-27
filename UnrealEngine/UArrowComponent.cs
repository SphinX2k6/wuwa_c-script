using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000850 RID: 2128
	[UnrealObjectPath("/Script/Engine.ArrowComponent")]
	[UnrealStructLayout(1664, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1664)]
	public class UArrowComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060072BE RID: 29374 RVA: 0x000A471F File Offset: 0x000A291F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UArrowComponent._ClassPtr;
		}

		// Token: 0x060072BF RID: 29375 RVA: 0x000A472C File Offset: 0x000A292C
		public UArrowComponent() : this(BuiltinUtils.AllocNativeUObject(UArrowComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060072C0 RID: 29376 RVA: 0x000A4754 File Offset: 0x000A2954
		[NullableContext(1)]
		public UArrowComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UArrowComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001B04 RID: 6916
		// (get) Token: 0x060072C1 RID: 29377 RVA: 0x000A4787 File Offset: 0x000A2987
		// (set) Token: 0x060072C2 RID: 29378 RVA: 0x000A479B File Offset: 0x000A299B
		public unsafe FColor ArrowColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UArrowComponent.__PropertyOffset_ArrowColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UArrowComponent.__PropertyOffset_ArrowColor) = value;
			}
		}

		// Token: 0x17001B05 RID: 6917
		// (get) Token: 0x060072C3 RID: 29379 RVA: 0x000A47B0 File Offset: 0x000A29B0
		// (set) Token: 0x060072C4 RID: 29380 RVA: 0x000A47C0 File Offset: 0x000A29C0
		public unsafe float ArrowSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UArrowComponent.__PropertyOffset_ArrowSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UArrowComponent.__PropertyOffset_ArrowSize) = value;
			}
		}

		// Token: 0x17001B06 RID: 6918
		// (get) Token: 0x060072C5 RID: 29381 RVA: 0x000A47D1 File Offset: 0x000A29D1
		// (set) Token: 0x060072C6 RID: 29382 RVA: 0x000A47E1 File Offset: 0x000A29E1
		public unsafe float ArrowLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UArrowComponent.__PropertyOffset_ArrowLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UArrowComponent.__PropertyOffset_ArrowLength) = value;
			}
		}

		// Token: 0x17001B07 RID: 6919
		// (get) Token: 0x060072C7 RID: 29383 RVA: 0x000A47F2 File Offset: 0x000A29F2
		// (set) Token: 0x060072C8 RID: 29384 RVA: 0x000A4802 File Offset: 0x000A2A02
		public unsafe float ScreenSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UArrowComponent.__PropertyOffset_ScreenSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UArrowComponent.__PropertyOffset_ScreenSize) = value;
			}
		}

		// Token: 0x17001B08 RID: 6920
		// (get) Token: 0x060072C9 RID: 29385 RVA: 0x000A4813 File Offset: 0x000A2A13
		// (set) Token: 0x060072CA RID: 29386 RVA: 0x000A482C File Offset: 0x000A2A2C
		public unsafe bool bIsScreenSizeScaled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UArrowComponent.__PropertyOffset_bIsScreenSizeScaled) & UArrowComponent.__PropertyMask_bIsScreenSizeScaled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UArrowComponent.__PropertyOffset_bIsScreenSizeScaled) = ((*(base.NativePtr + (IntPtr)UArrowComponent.__PropertyOffset_bIsScreenSizeScaled) & ~UArrowComponent.__PropertyMask_bIsScreenSizeScaled) | (value ? UArrowComponent.__PropertyMask_bIsScreenSizeScaled : 0));
			}
		}

		// Token: 0x17001B09 RID: 6921
		// (get) Token: 0x060072CB RID: 29387 RVA: 0x000A485C File Offset: 0x000A2A5C
		// (set) Token: 0x060072CC RID: 29388 RVA: 0x000A4875 File Offset: 0x000A2A75
		public unsafe bool bTreatAsASprite
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UArrowComponent.__PropertyOffset_bTreatAsASprite) & UArrowComponent.__PropertyMask_bTreatAsASprite) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UArrowComponent.__PropertyOffset_bTreatAsASprite) = ((*(base.NativePtr + (IntPtr)UArrowComponent.__PropertyOffset_bTreatAsASprite) & ~UArrowComponent.__PropertyMask_bTreatAsASprite) | (value ? UArrowComponent.__PropertyMask_bTreatAsASprite : 0));
			}
		}

		// Token: 0x060072CD RID: 29389 RVA: 0x000A48A5 File Offset: 0x000A2AA5
		public void SetArrowColor(FLinearColor NewColor)
		{
			UArrowComponent.__SetArrowColor_Internal(base.NativePtr, NewColor);
		}

		// Token: 0x060072CE RID: 29390
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetArrowColor_Internal(IntPtr @this, FLinearColor NewColor);

		// Token: 0x060072CF RID: 29391 RVA: 0x000A48B3 File Offset: 0x000A2AB3
		static UArrowComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ArrowComponent");
		}

		// Token: 0x060072D0 RID: 29392 RVA: 0x000A48C1 File Offset: 0x000A2AC1
		protected UArrowComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003724 RID: 14116
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ArrowComponent";

		// Token: 0x04003725 RID: 14117
		private static IntPtr _ClassPtr;

		// Token: 0x04003726 RID: 14118
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003727 RID: 14119
		internal static int __PropertyOffset_ArrowColor;

		// Token: 0x04003728 RID: 14120
		internal static int __PropertyOffset_ArrowSize;

		// Token: 0x04003729 RID: 14121
		internal static int __PropertyOffset_ArrowLength;

		// Token: 0x0400372A RID: 14122
		internal static int __PropertyOffset_ScreenSize;

		// Token: 0x0400372B RID: 14123
		internal static int __PropertyOffset_bIsScreenSizeScaled;

		// Token: 0x0400372C RID: 14124
		internal static byte __PropertyMask_bIsScreenSizeScaled;

		// Token: 0x0400372D RID: 14125
		internal static int __PropertyOffset_bTreatAsASprite;

		// Token: 0x0400372E RID: 14126
		internal static byte __PropertyMask_bTreatAsASprite;
	}
}
