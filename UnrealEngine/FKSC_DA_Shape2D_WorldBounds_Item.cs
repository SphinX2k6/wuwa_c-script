using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001DB8 RID: 7608
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Shape2D_WorldBounds_Item")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FKSC_DA_Shape2D_WorldBounds_Item : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601D151 RID: 119121 RVA: 0x002AF9C7 File Offset: 0x002ADBC7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_DA_Shape2D_WorldBounds_Item._ScriptStructPtr != 0) ? FKSC_DA_Shape2D_WorldBounds_Item._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSC_DA_Shape2D_WorldBounds_Item", ref FKSC_DA_Shape2D_WorldBounds_Item._ScriptStructPtr);
		}

		// Token: 0x17007562 RID: 30050
		// (get) Token: 0x0601D152 RID: 119122 RVA: 0x002AF9EB File Offset: 0x002ADBEB
		// (set) Token: 0x0601D153 RID: 119123 RVA: 0x002AF9FF File Offset: 0x002ADBFF
		public unsafe FVector2D StartPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_DA_Shape2D_WorldBounds_Item.__PropertyOffset_StartPoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_DA_Shape2D_WorldBounds_Item.__PropertyOffset_StartPoint) = value;
			}
		}

		// Token: 0x17007563 RID: 30051
		// (get) Token: 0x0601D154 RID: 119124 RVA: 0x002AFA14 File Offset: 0x002ADC14
		// (set) Token: 0x0601D155 RID: 119125 RVA: 0x002AFA28 File Offset: 0x002ADC28
		public unsafe FVector2D EndPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_DA_Shape2D_WorldBounds_Item.__PropertyOffset_EndPoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_DA_Shape2D_WorldBounds_Item.__PropertyOffset_EndPoint) = value;
			}
		}

		// Token: 0x17007564 RID: 30052
		// (get) Token: 0x0601D156 RID: 119126 RVA: 0x002AFA3D File Offset: 0x002ADC3D
		// (set) Token: 0x0601D157 RID: 119127 RVA: 0x002AFA4D File Offset: 0x002ADC4D
		public unsafe float Thickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_DA_Shape2D_WorldBounds_Item.__PropertyOffset_Thickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_DA_Shape2D_WorldBounds_Item.__PropertyOffset_Thickness) = value;
			}
		}

		// Token: 0x17007565 RID: 30053
		// (get) Token: 0x0601D158 RID: 119128 RVA: 0x002AFA5E File Offset: 0x002ADC5E
		// (set) Token: 0x0601D159 RID: 119129 RVA: 0x002AFA6E File Offset: 0x002ADC6E
		public unsafe float ExtraWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_DA_Shape2D_WorldBounds_Item.__PropertyOffset_ExtraWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_DA_Shape2D_WorldBounds_Item.__PropertyOffset_ExtraWidth) = value;
			}
		}

		// Token: 0x17007566 RID: 30054
		// (get) Token: 0x0601D15A RID: 119130 RVA: 0x002AFA7F File Offset: 0x002ADC7F
		// (set) Token: 0x0601D15B RID: 119131 RVA: 0x002AFA8F File Offset: 0x002ADC8F
		public unsafe int MaterialID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_DA_Shape2D_WorldBounds_Item.__PropertyOffset_MaterialID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_DA_Shape2D_WorldBounds_Item.__PropertyOffset_MaterialID) = value;
			}
		}

		// Token: 0x17007567 RID: 30055
		// (get) Token: 0x0601D15C RID: 119132 RVA: 0x002AFAA0 File Offset: 0x002ADCA0
		// (set) Token: 0x0601D15D RID: 119133 RVA: 0x002AFAB4 File Offset: 0x002ADCB4
		public unsafe string DebugText
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKSC_DA_Shape2D_WorldBounds_Item.__PropertyOffset_DebugText)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKSC_DA_Shape2D_WorldBounds_Item.__PropertyOffset_DebugText)), value);
			}
		}

		// Token: 0x0601D15E RID: 119134 RVA: 0x002AFAC9 File Offset: 0x002ADCC9
		public FKSC_DA_Shape2D_WorldBounds_Item()
		{
		}

		// Token: 0x0601D15F RID: 119135 RVA: 0x002AFAD1 File Offset: 0x002ADCD1
		public FKSC_DA_Shape2D_WorldBounds_Item(FVector2D StartPoint, FVector2D EndPoint, float Thickness, float ExtraWidth, int MaterialID, string DebugText)
		{
			this.StartPoint = StartPoint;
			this.EndPoint = EndPoint;
			this.Thickness = Thickness;
			this.ExtraWidth = ExtraWidth;
			this.MaterialID = MaterialID;
			this.DebugText = DebugText;
		}

		// Token: 0x0601D160 RID: 119136 RVA: 0x002AFB06 File Offset: 0x002ADD06
		protected override IntPtr GetUStructPtr()
		{
			return FKSC_DA_Shape2D_WorldBounds_Item.StaticStruct();
		}

		// Token: 0x0601D161 RID: 119137 RVA: 0x002AFB12 File Offset: 0x002ADD12
		[NullableContext(2)]
		public FKSC_DA_Shape2D_WorldBounds_Item(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D162 RID: 119138 RVA: 0x002AFB1C File Offset: 0x002ADD1C
		public FKSC_DA_Shape2D_WorldBounds_Item(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D163 RID: 119139 RVA: 0x002AFB27 File Offset: 0x002ADD27
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSC_DA_Shape2D_WorldBounds_Item(Pointer, false, true);
		}

		// Token: 0x0601D164 RID: 119140 RVA: 0x002AFB31 File Offset: 0x002ADD31
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSC_DA_Shape2D_WorldBounds_Item(Pointer, MemoryOwner);
		}

		// Token: 0x0400FC9B RID: 64667
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Shape2D_WorldBounds_Item";

		// Token: 0x0400FC9C RID: 64668
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FC9D RID: 64669
		internal static int __PropertyOffset_StartPoint;

		// Token: 0x0400FC9E RID: 64670
		internal static int __PropertyOffset_EndPoint;

		// Token: 0x0400FC9F RID: 64671
		internal static int __PropertyOffset_Thickness;

		// Token: 0x0400FCA0 RID: 64672
		internal static int __PropertyOffset_ExtraWidth;

		// Token: 0x0400FCA1 RID: 64673
		internal static int __PropertyOffset_MaterialID;

		// Token: 0x0400FCA2 RID: 64674
		internal static int __PropertyOffset_DebugText;
	}
}
