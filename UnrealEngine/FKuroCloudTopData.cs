using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001AD2 RID: 6866
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroCloudTopData")]
	[UnrealStructLayout(64, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FKuroCloudTopData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601991D RID: 104733 RVA: 0x0025CD86 File Offset: 0x0025AF86
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCloudTopData._ScriptStructPtr != 0) ? FKuroCloudTopData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroCloudTopData", ref FKuroCloudTopData._ScriptStructPtr);
		}

		// Token: 0x17006621 RID: 26145
		// (get) Token: 0x0601991E RID: 104734 RVA: 0x0025CDAA File Offset: 0x0025AFAA
		// (set) Token: 0x0601991F RID: 104735 RVA: 0x0025CDBE File Offset: 0x0025AFBE
		public unsafe FVector Rotator
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudTopData.__PropertyOffset_Rotator);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudTopData.__PropertyOffset_Rotator) = value;
			}
		}

		// Token: 0x17006622 RID: 26146
		// (get) Token: 0x06019920 RID: 104736 RVA: 0x0025CDD3 File Offset: 0x0025AFD3
		// (set) Token: 0x06019921 RID: 104737 RVA: 0x0025CDE7 File Offset: 0x0025AFE7
		public unsafe FVector Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudTopData.__PropertyOffset_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudTopData.__PropertyOffset_Offset) = value;
			}
		}

		// Token: 0x17006623 RID: 26147
		// (get) Token: 0x06019922 RID: 104738 RVA: 0x0025CDFC File Offset: 0x0025AFFC
		// (set) Token: 0x06019923 RID: 104739 RVA: 0x0025CE0C File Offset: 0x0025B00C
		public unsafe int TextureIdx
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudTopData.__PropertyOffset_TextureIdx);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudTopData.__PropertyOffset_TextureIdx) = value;
			}
		}

		// Token: 0x17006624 RID: 26148
		// (get) Token: 0x06019924 RID: 104740 RVA: 0x0025CE1D File Offset: 0x0025B01D
		// (set) Token: 0x06019925 RID: 104741 RVA: 0x0025CE2D File Offset: 0x0025B02D
		public unsafe float Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudTopData.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudTopData.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x17006625 RID: 26149
		// (get) Token: 0x06019926 RID: 104742 RVA: 0x0025CE3E File Offset: 0x0025B03E
		// (set) Token: 0x06019927 RID: 104743 RVA: 0x0025CE4E File Offset: 0x0025B04E
		public unsafe float AlphaControl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudTopData.__PropertyOffset_AlphaControl);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudTopData.__PropertyOffset_AlphaControl) = value;
			}
		}

		// Token: 0x17006626 RID: 26150
		// (get) Token: 0x06019928 RID: 104744 RVA: 0x0025CE5F File Offset: 0x0025B05F
		// (set) Token: 0x06019929 RID: 104745 RVA: 0x0025CE6F File Offset: 0x0025B06F
		public unsafe float AlphaMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudTopData.__PropertyOffset_AlphaMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudTopData.__PropertyOffset_AlphaMax) = value;
			}
		}

		// Token: 0x17006627 RID: 26151
		// (get) Token: 0x0601992A RID: 104746 RVA: 0x0025CE80 File Offset: 0x0025B080
		// (set) Token: 0x0601992B RID: 104747 RVA: 0x0025CE90 File Offset: 0x0025B090
		public unsafe float AlphaMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudTopData.__PropertyOffset_AlphaMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudTopData.__PropertyOffset_AlphaMin) = value;
			}
		}

		// Token: 0x17006628 RID: 26152
		// (get) Token: 0x0601992C RID: 104748 RVA: 0x0025CEA1 File Offset: 0x0025B0A1
		// (set) Token: 0x0601992D RID: 104749 RVA: 0x0025CEB1 File Offset: 0x0025B0B1
		public unsafe float Brightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudTopData.__PropertyOffset_Brightness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudTopData.__PropertyOffset_Brightness) = value;
			}
		}

		// Token: 0x17006629 RID: 26153
		// (get) Token: 0x0601992E RID: 104750 RVA: 0x0025CEC2 File Offset: 0x0025B0C2
		// (set) Token: 0x0601992F RID: 104751 RVA: 0x0025CED2 File Offset: 0x0025B0D2
		public unsafe float FadeOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudTopData.__PropertyOffset_FadeOutTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudTopData.__PropertyOffset_FadeOutTime) = value;
			}
		}

		// Token: 0x1700662A RID: 26154
		// (get) Token: 0x06019930 RID: 104752 RVA: 0x0025CEE3 File Offset: 0x0025B0E3
		// (set) Token: 0x06019931 RID: 104753 RVA: 0x0025CEF3 File Offset: 0x0025B0F3
		public unsafe float FadeInTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudTopData.__PropertyOffset_FadeInTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudTopData.__PropertyOffset_FadeInTime) = value;
			}
		}

		// Token: 0x1700662B RID: 26155
		// (get) Token: 0x06019932 RID: 104754 RVA: 0x0025CF04 File Offset: 0x0025B104
		// (set) Token: 0x06019933 RID: 104755 RVA: 0x0025CF14 File Offset: 0x0025B114
		public unsafe float FullStayTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudTopData.__PropertyOffset_FullStayTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudTopData.__PropertyOffset_FullStayTime) = value;
			}
		}

		// Token: 0x1700662C RID: 26156
		// (get) Token: 0x06019934 RID: 104756 RVA: 0x0025CF25 File Offset: 0x0025B125
		// (set) Token: 0x06019935 RID: 104757 RVA: 0x0025CF35 File Offset: 0x0025B135
		public unsafe float DisappearTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudTopData.__PropertyOffset_DisappearTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudTopData.__PropertyOffset_DisappearTime) = value;
			}
		}

		// Token: 0x06019936 RID: 104758 RVA: 0x0025CF46 File Offset: 0x0025B146
		public FKuroCloudTopData()
		{
		}

		// Token: 0x06019937 RID: 104759 RVA: 0x0025CF50 File Offset: 0x0025B150
		public FKuroCloudTopData(FVector Rotator, FVector Offset, int TextureIdx, float Scale, float AlphaControl, float AlphaMax, float AlphaMin, float Brightness, float FadeOutTime, float FadeInTime, float FullStayTime, float DisappearTime)
		{
			this.Rotator = Rotator;
			this.Offset = Offset;
			this.TextureIdx = TextureIdx;
			this.Scale = Scale;
			this.AlphaControl = AlphaControl;
			this.AlphaMax = AlphaMax;
			this.AlphaMin = AlphaMin;
			this.Brightness = Brightness;
			this.FadeOutTime = FadeOutTime;
			this.FadeInTime = FadeInTime;
			this.FullStayTime = FullStayTime;
			this.DisappearTime = DisappearTime;
		}

		// Token: 0x06019938 RID: 104760 RVA: 0x0025CFC0 File Offset: 0x0025B1C0
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCloudTopData.StaticStruct();
		}

		// Token: 0x06019939 RID: 104761 RVA: 0x0025CFCC File Offset: 0x0025B1CC
		[NullableContext(2)]
		public FKuroCloudTopData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601993A RID: 104762 RVA: 0x0025CFD6 File Offset: 0x0025B1D6
		public FKuroCloudTopData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601993B RID: 104763 RVA: 0x0025CFE1 File Offset: 0x0025B1E1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCloudTopData(Pointer, false, true);
		}

		// Token: 0x0601993C RID: 104764 RVA: 0x0025CFEB File Offset: 0x0025B1EB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCloudTopData(Pointer, MemoryOwner);
		}

		// Token: 0x0400DEBF RID: 57023
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroCloudTopData";

		// Token: 0x0400DEC0 RID: 57024
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400DEC1 RID: 57025
		internal static int __PropertyOffset_Rotator;

		// Token: 0x0400DEC2 RID: 57026
		internal static int __PropertyOffset_Offset;

		// Token: 0x0400DEC3 RID: 57027
		internal static int __PropertyOffset_TextureIdx;

		// Token: 0x0400DEC4 RID: 57028
		internal static int __PropertyOffset_Scale;

		// Token: 0x0400DEC5 RID: 57029
		internal static int __PropertyOffset_AlphaControl;

		// Token: 0x0400DEC6 RID: 57030
		internal static int __PropertyOffset_AlphaMax;

		// Token: 0x0400DEC7 RID: 57031
		internal static int __PropertyOffset_AlphaMin;

		// Token: 0x0400DEC8 RID: 57032
		internal static int __PropertyOffset_Brightness;

		// Token: 0x0400DEC9 RID: 57033
		internal static int __PropertyOffset_FadeOutTime;

		// Token: 0x0400DECA RID: 57034
		internal static int __PropertyOffset_FadeInTime;

		// Token: 0x0400DECB RID: 57035
		internal static int __PropertyOffset_FullStayTime;

		// Token: 0x0400DECC RID: 57036
		internal static int __PropertyOffset_DisappearTime;
	}
}
