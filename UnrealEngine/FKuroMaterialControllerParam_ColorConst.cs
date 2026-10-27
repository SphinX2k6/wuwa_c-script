using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001B3E RID: 6974
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_ColorConst")]
	[UnrealStructLayout(44, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 44)]
	public class FKuroMaterialControllerParam_ColorConst : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A67B RID: 108155 RVA: 0x0026EE23 File Offset: 0x0026D023
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialControllerParam_ColorConst._ScriptStructPtr != 0) ? FKuroMaterialControllerParam_ColorConst._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_ColorConst", ref FKuroMaterialControllerParam_ColorConst._ScriptStructPtr);
		}

		// Token: 0x17006A29 RID: 27177
		// (get) Token: 0x0601A67C RID: 108156 RVA: 0x0026EE47 File Offset: 0x0026D047
		// (set) Token: 0x0601A67D RID: 108157 RVA: 0x0026EE5B File Offset: 0x0026D05B
		public unsafe FLinearColor BaseColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_ColorConst.__PropertyOffset_BaseColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_ColorConst.__PropertyOffset_BaseColor) = value;
			}
		}

		// Token: 0x17006A2A RID: 27178
		// (get) Token: 0x0601A67E RID: 108158 RVA: 0x0026EE70 File Offset: 0x0026D070
		// (set) Token: 0x0601A67F RID: 108159 RVA: 0x0026EE80 File Offset: 0x0026D080
		public unsafe float BaseIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_ColorConst.__PropertyOffset_BaseIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_ColorConst.__PropertyOffset_BaseIntensity) = value;
			}
		}

		// Token: 0x17006A2B RID: 27179
		// (get) Token: 0x0601A680 RID: 108160 RVA: 0x0026EE91 File Offset: 0x0026D091
		// (set) Token: 0x0601A681 RID: 108161 RVA: 0x0026EEA5 File Offset: 0x0026D0A5
		public unsafe FLinearColor EmissionColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_ColorConst.__PropertyOffset_EmissionColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_ColorConst.__PropertyOffset_EmissionColor) = value;
			}
		}

		// Token: 0x17006A2C RID: 27180
		// (get) Token: 0x0601A682 RID: 108162 RVA: 0x0026EEBA File Offset: 0x0026D0BA
		// (set) Token: 0x0601A683 RID: 108163 RVA: 0x0026EECA File Offset: 0x0026D0CA
		public unsafe float EmissionIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_ColorConst.__PropertyOffset_EmissionIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_ColorConst.__PropertyOffset_EmissionIntensity) = value;
			}
		}

		// Token: 0x17006A2D RID: 27181
		// (get) Token: 0x0601A684 RID: 108164 RVA: 0x0026EEDB File Offset: 0x0026D0DB
		// (set) Token: 0x0601A685 RID: 108165 RVA: 0x0026EEEB File Offset: 0x0026D0EB
		public unsafe bool bBaseUseTex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_ColorConst.__PropertyOffset_bBaseUseTex) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_ColorConst.__PropertyOffset_bBaseUseTex) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006A2E RID: 27182
		// (get) Token: 0x0601A686 RID: 108166 RVA: 0x0026EEFC File Offset: 0x0026D0FC
		// (set) Token: 0x0601A687 RID: 108167 RVA: 0x0026EF0C File Offset: 0x0026D10C
		public unsafe bool bEmissionUseTex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_ColorConst.__PropertyOffset_bEmissionUseTex) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_ColorConst.__PropertyOffset_bEmissionUseTex) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601A688 RID: 108168 RVA: 0x0026EF1D File Offset: 0x0026D11D
		public FKuroMaterialControllerParam_ColorConst()
		{
		}

		// Token: 0x0601A689 RID: 108169 RVA: 0x0026EF25 File Offset: 0x0026D125
		public FKuroMaterialControllerParam_ColorConst(FLinearColor BaseColor, float BaseIntensity, FLinearColor EmissionColor, float EmissionIntensity, bool bBaseUseTex, bool bEmissionUseTex)
		{
			this.BaseColor = BaseColor;
			this.BaseIntensity = BaseIntensity;
			this.EmissionColor = EmissionColor;
			this.EmissionIntensity = EmissionIntensity;
			this.bBaseUseTex = bBaseUseTex;
			this.bEmissionUseTex = bEmissionUseTex;
		}

		// Token: 0x0601A68A RID: 108170 RVA: 0x0026EF5A File Offset: 0x0026D15A
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialControllerParam_ColorConst.StaticStruct();
		}

		// Token: 0x0601A68B RID: 108171 RVA: 0x0026EF66 File Offset: 0x0026D166
		[NullableContext(2)]
		public FKuroMaterialControllerParam_ColorConst(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A68C RID: 108172 RVA: 0x0026EF70 File Offset: 0x0026D170
		public FKuroMaterialControllerParam_ColorConst(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A68D RID: 108173 RVA: 0x0026EF7B File Offset: 0x0026D17B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialControllerParam_ColorConst(Pointer, false, true);
		}

		// Token: 0x0601A68E RID: 108174 RVA: 0x0026EF85 File Offset: 0x0026D185
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialControllerParam_ColorConst(Pointer, MemoryOwner);
		}

		// Token: 0x0400E4F0 RID: 58608
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_ColorConst";

		// Token: 0x0400E4F1 RID: 58609
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E4F2 RID: 58610
		internal static int __PropertyOffset_BaseColor;

		// Token: 0x0400E4F3 RID: 58611
		internal static int __PropertyOffset_BaseIntensity;

		// Token: 0x0400E4F4 RID: 58612
		internal static int __PropertyOffset_EmissionColor;

		// Token: 0x0400E4F5 RID: 58613
		internal static int __PropertyOffset_EmissionIntensity;

		// Token: 0x0400E4F6 RID: 58614
		internal static int __PropertyOffset_bBaseUseTex;

		// Token: 0x0400E4F7 RID: 58615
		internal static int __PropertyOffset_bEmissionUseTex;
	}
}
