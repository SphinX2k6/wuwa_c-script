using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B13 RID: 6931
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroGodRaySetting")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FKuroGodRaySetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A120 RID: 106784 RVA: 0x00267AF4 File Offset: 0x00265CF4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroGodRaySetting._ScriptStructPtr != 0) ? FKuroGodRaySetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroGodRaySetting", ref FKuroGodRaySetting._ScriptStructPtr);
		}

		// Token: 0x170068A3 RID: 26787
		// (get) Token: 0x0601A121 RID: 106785 RVA: 0x00267B18 File Offset: 0x00265D18
		// (set) Token: 0x0601A122 RID: 106786 RVA: 0x00267B31 File Offset: 0x00265D31
		public unsafe bool bOverride_GodRayStrength
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroGodRaySetting.__PropertyOffset_bOverride_GodRayStrength) & FKuroGodRaySetting.__PropertyMask_bOverride_GodRayStrength) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroGodRaySetting.__PropertyOffset_bOverride_GodRayStrength) = ((*(base.NativePtr + (IntPtr)FKuroGodRaySetting.__PropertyOffset_bOverride_GodRayStrength) & ~FKuroGodRaySetting.__PropertyMask_bOverride_GodRayStrength) | (value ? FKuroGodRaySetting.__PropertyMask_bOverride_GodRayStrength : 0));
			}
		}

		// Token: 0x170068A4 RID: 26788
		// (get) Token: 0x0601A123 RID: 106787 RVA: 0x00267B61 File Offset: 0x00265D61
		// (set) Token: 0x0601A124 RID: 106788 RVA: 0x00267B7A File Offset: 0x00265D7A
		public unsafe bool bOverride_ExtraFOV
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroGodRaySetting.__PropertyOffset_bOverride_ExtraFOV) & FKuroGodRaySetting.__PropertyMask_bOverride_ExtraFOV) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroGodRaySetting.__PropertyOffset_bOverride_ExtraFOV) = ((*(base.NativePtr + (IntPtr)FKuroGodRaySetting.__PropertyOffset_bOverride_ExtraFOV) & ~FKuroGodRaySetting.__PropertyMask_bOverride_ExtraFOV) | (value ? FKuroGodRaySetting.__PropertyMask_bOverride_ExtraFOV : 0));
			}
		}

		// Token: 0x170068A5 RID: 26789
		// (get) Token: 0x0601A125 RID: 106789 RVA: 0x00267BAA File Offset: 0x00265DAA
		// (set) Token: 0x0601A126 RID: 106790 RVA: 0x00267BC3 File Offset: 0x00265DC3
		public unsafe bool bOverride_GodRayRT
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroGodRaySetting.__PropertyOffset_bOverride_GodRayRT) & FKuroGodRaySetting.__PropertyMask_bOverride_GodRayRT) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroGodRaySetting.__PropertyOffset_bOverride_GodRayRT) = ((*(base.NativePtr + (IntPtr)FKuroGodRaySetting.__PropertyOffset_bOverride_GodRayRT) & ~FKuroGodRaySetting.__PropertyMask_bOverride_GodRayRT) | (value ? FKuroGodRaySetting.__PropertyMask_bOverride_GodRayRT : 0));
			}
		}

		// Token: 0x170068A6 RID: 26790
		// (get) Token: 0x0601A127 RID: 106791 RVA: 0x00267BF3 File Offset: 0x00265DF3
		// (set) Token: 0x0601A128 RID: 106792 RVA: 0x00267C0C File Offset: 0x00265E0C
		public unsafe bool bOverride_GodRayMaterial
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroGodRaySetting.__PropertyOffset_bOverride_GodRayMaterial) & FKuroGodRaySetting.__PropertyMask_bOverride_GodRayMaterial) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroGodRaySetting.__PropertyOffset_bOverride_GodRayMaterial) = ((*(base.NativePtr + (IntPtr)FKuroGodRaySetting.__PropertyOffset_bOverride_GodRayMaterial) & ~FKuroGodRaySetting.__PropertyMask_bOverride_GodRayMaterial) | (value ? FKuroGodRaySetting.__PropertyMask_bOverride_GodRayMaterial : 0));
			}
		}

		// Token: 0x170068A7 RID: 26791
		// (get) Token: 0x0601A129 RID: 106793 RVA: 0x00267C3C File Offset: 0x00265E3C
		// (set) Token: 0x0601A12A RID: 106794 RVA: 0x00267C4C File Offset: 0x00265E4C
		public unsafe float GodRayStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroGodRaySetting.__PropertyOffset_GodRayStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroGodRaySetting.__PropertyOffset_GodRayStrength) = value;
			}
		}

		// Token: 0x170068A8 RID: 26792
		// (get) Token: 0x0601A12B RID: 106795 RVA: 0x00267C5D File Offset: 0x00265E5D
		// (set) Token: 0x0601A12C RID: 106796 RVA: 0x00267C6D File Offset: 0x00265E6D
		public unsafe float ExtraFOV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroGodRaySetting.__PropertyOffset_ExtraFOV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroGodRaySetting.__PropertyOffset_ExtraFOV) = value;
			}
		}

		// Token: 0x170068A9 RID: 26793
		// (get) Token: 0x0601A12D RID: 106797 RVA: 0x00267C7E File Offset: 0x00265E7E
		// (set) Token: 0x0601A12E RID: 106798 RVA: 0x00267C92 File Offset: 0x00265E92
		public unsafe UTextureRenderTarget2D GodRayRT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroGodRaySetting.__PropertyOffset_GodRayRT);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroGodRaySetting.__PropertyOffset_GodRayRT, value);
			}
		}

		// Token: 0x170068AA RID: 26794
		// (get) Token: 0x0601A12F RID: 106799 RVA: 0x00267CA7 File Offset: 0x00265EA7
		// (set) Token: 0x0601A130 RID: 106800 RVA: 0x00267CBB File Offset: 0x00265EBB
		public unsafe UMaterialInterface GodRayMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroGodRaySetting.__PropertyOffset_GodRayMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroGodRaySetting.__PropertyOffset_GodRayMaterial, value);
			}
		}

		// Token: 0x0601A131 RID: 106801 RVA: 0x00267CD0 File Offset: 0x00265ED0
		public FKuroGodRaySetting()
		{
		}

		// Token: 0x0601A132 RID: 106802 RVA: 0x00267CD8 File Offset: 0x00265ED8
		[NullableContext(1)]
		public FKuroGodRaySetting(bool bOverride_GodRayStrength, bool bOverride_ExtraFOV, bool bOverride_GodRayRT, bool bOverride_GodRayMaterial, float GodRayStrength, float ExtraFOV, UTextureRenderTarget2D GodRayRT, UMaterialInterface GodRayMaterial)
		{
			this.bOverride_GodRayStrength = bOverride_GodRayStrength;
			this.bOverride_ExtraFOV = bOverride_ExtraFOV;
			this.bOverride_GodRayRT = bOverride_GodRayRT;
			this.bOverride_GodRayMaterial = bOverride_GodRayMaterial;
			this.GodRayStrength = GodRayStrength;
			this.ExtraFOV = ExtraFOV;
			this.GodRayRT = GodRayRT;
			this.GodRayMaterial = GodRayMaterial;
		}

		// Token: 0x0601A133 RID: 106803 RVA: 0x00267D28 File Offset: 0x00265F28
		protected override IntPtr GetUStructPtr()
		{
			return FKuroGodRaySetting.StaticStruct();
		}

		// Token: 0x0601A134 RID: 106804 RVA: 0x00267D34 File Offset: 0x00265F34
		public FKuroGodRaySetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A135 RID: 106805 RVA: 0x00267D3E File Offset: 0x00265F3E
		public FKuroGodRaySetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A136 RID: 106806 RVA: 0x00267D49 File Offset: 0x00265F49
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroGodRaySetting(Pointer, false, true);
		}

		// Token: 0x0601A137 RID: 106807 RVA: 0x00267D53 File Offset: 0x00265F53
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroGodRaySetting(Pointer, MemoryOwner);
		}

		// Token: 0x0400E282 RID: 57986
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroGodRaySetting";

		// Token: 0x0400E283 RID: 57987
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E284 RID: 57988
		internal static int __PropertyOffset_bOverride_GodRayStrength;

		// Token: 0x0400E285 RID: 57989
		internal static byte __PropertyMask_bOverride_GodRayStrength;

		// Token: 0x0400E286 RID: 57990
		internal static int __PropertyOffset_bOverride_ExtraFOV;

		// Token: 0x0400E287 RID: 57991
		internal static byte __PropertyMask_bOverride_ExtraFOV;

		// Token: 0x0400E288 RID: 57992
		internal static int __PropertyOffset_bOverride_GodRayRT;

		// Token: 0x0400E289 RID: 57993
		internal static byte __PropertyMask_bOverride_GodRayRT;

		// Token: 0x0400E28A RID: 57994
		internal static int __PropertyOffset_bOverride_GodRayMaterial;

		// Token: 0x0400E28B RID: 57995
		internal static byte __PropertyMask_bOverride_GodRayMaterial;

		// Token: 0x0400E28C RID: 57996
		internal static int __PropertyOffset_GodRayStrength;

		// Token: 0x0400E28D RID: 57997
		internal static int __PropertyOffset_ExtraFOV;

		// Token: 0x0400E28E RID: 57998
		internal static int __PropertyOffset_GodRayRT;

		// Token: 0x0400E28F RID: 57999
		internal static int __PropertyOffset_GodRayMaterial;
	}
}
