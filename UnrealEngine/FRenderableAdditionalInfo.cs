using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020020FE RID: 8446
	[UnrealObjectPath("/Script/LGUI.RenderableAdditionalInfo")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FRenderableAdditionalInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FC7E RID: 130174 RVA: 0x002F42E8 File Offset: 0x002F24E8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRenderableAdditionalInfo._ScriptStructPtr != 0) ? FRenderableAdditionalInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.RenderableAdditionalInfo", ref FRenderableAdditionalInfo._ScriptStructPtr);
		}

		// Token: 0x17007D08 RID: 32008
		// (get) Token: 0x0601FC7F RID: 130175 RVA: 0x002F430C File Offset: 0x002F250C
		// (set) Token: 0x0601FC80 RID: 130176 RVA: 0x002F4325 File Offset: 0x002F2525
		public unsafe bool bIsGray
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FRenderableAdditionalInfo.__PropertyOffset_bIsGray) & FRenderableAdditionalInfo.__PropertyMask_bIsGray) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FRenderableAdditionalInfo.__PropertyOffset_bIsGray) = ((*(base.NativePtr + (IntPtr)FRenderableAdditionalInfo.__PropertyOffset_bIsGray) & ~FRenderableAdditionalInfo.__PropertyMask_bIsGray) | (value ? FRenderableAdditionalInfo.__PropertyMask_bIsGray : 0));
			}
		}

		// Token: 0x17007D09 RID: 32009
		// (get) Token: 0x0601FC81 RID: 130177 RVA: 0x002F4355 File Offset: 0x002F2555
		// (set) Token: 0x0601FC82 RID: 130178 RVA: 0x002F436E File Offset: 0x002F256E
		public unsafe bool bIsColorRevert
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FRenderableAdditionalInfo.__PropertyOffset_bIsColorRevert) & FRenderableAdditionalInfo.__PropertyMask_bIsColorRevert) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FRenderableAdditionalInfo.__PropertyOffset_bIsColorRevert) = ((*(base.NativePtr + (IntPtr)FRenderableAdditionalInfo.__PropertyOffset_bIsColorRevert) & ~FRenderableAdditionalInfo.__PropertyMask_bIsColorRevert) | (value ? FRenderableAdditionalInfo.__PropertyMask_bIsColorRevert : 0));
			}
		}

		// Token: 0x17007D0A RID: 32010
		// (get) Token: 0x0601FC83 RID: 130179 RVA: 0x002F439E File Offset: 0x002F259E
		// (set) Token: 0x0601FC84 RID: 130180 RVA: 0x002F43B7 File Offset: 0x002F25B7
		public unsafe bool bUseChangeColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FRenderableAdditionalInfo.__PropertyOffset_bUseChangeColor) & FRenderableAdditionalInfo.__PropertyMask_bUseChangeColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FRenderableAdditionalInfo.__PropertyOffset_bUseChangeColor) = ((*(base.NativePtr + (IntPtr)FRenderableAdditionalInfo.__PropertyOffset_bUseChangeColor) & ~FRenderableAdditionalInfo.__PropertyMask_bUseChangeColor) | (value ? FRenderableAdditionalInfo.__PropertyMask_bUseChangeColor : 0));
			}
		}

		// Token: 0x17007D0B RID: 32011
		// (get) Token: 0x0601FC85 RID: 130181 RVA: 0x002F43E7 File Offset: 0x002F25E7
		// (set) Token: 0x0601FC86 RID: 130182 RVA: 0x002F43FB File Offset: 0x002F25FB
		public unsafe FColor ChangeColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRenderableAdditionalInfo.__PropertyOffset_ChangeColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRenderableAdditionalInfo.__PropertyOffset_ChangeColor) = value;
			}
		}

		// Token: 0x17007D0C RID: 32012
		// (get) Token: 0x0601FC87 RID: 130183 RVA: 0x002F4410 File Offset: 0x002F2610
		// (set) Token: 0x0601FC88 RID: 130184 RVA: 0x002F4420 File Offset: 0x002F2620
		public unsafe float SpriteRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRenderableAdditionalInfo.__PropertyOffset_SpriteRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRenderableAdditionalInfo.__PropertyOffset_SpriteRotation) = value;
			}
		}

		// Token: 0x0601FC89 RID: 130185 RVA: 0x002F4431 File Offset: 0x002F2631
		public FRenderableAdditionalInfo()
		{
		}

		// Token: 0x0601FC8A RID: 130186 RVA: 0x002F4439 File Offset: 0x002F2639
		public FRenderableAdditionalInfo(bool bIsGray, bool bIsColorRevert, bool bUseChangeColor, FColor ChangeColor, float SpriteRotation)
		{
			this.bIsGray = bIsGray;
			this.bIsColorRevert = bIsColorRevert;
			this.bUseChangeColor = bUseChangeColor;
			this.ChangeColor = ChangeColor;
			this.SpriteRotation = SpriteRotation;
		}

		// Token: 0x0601FC8B RID: 130187 RVA: 0x002F4466 File Offset: 0x002F2666
		protected override IntPtr GetUStructPtr()
		{
			return FRenderableAdditionalInfo.StaticStruct();
		}

		// Token: 0x0601FC8C RID: 130188 RVA: 0x002F4472 File Offset: 0x002F2672
		[NullableContext(2)]
		public FRenderableAdditionalInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FC8D RID: 130189 RVA: 0x002F447C File Offset: 0x002F267C
		public FRenderableAdditionalInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FC8E RID: 130190 RVA: 0x002F4487 File Offset: 0x002F2687
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRenderableAdditionalInfo(Pointer, false, true);
		}

		// Token: 0x0601FC8F RID: 130191 RVA: 0x002F4491 File Offset: 0x002F2691
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRenderableAdditionalInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0401120C RID: 70156
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.RenderableAdditionalInfo";

		// Token: 0x0401120D RID: 70157
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401120E RID: 70158
		internal static int __PropertyOffset_bIsGray;

		// Token: 0x0401120F RID: 70159
		internal static byte __PropertyMask_bIsGray;

		// Token: 0x04011210 RID: 70160
		internal static int __PropertyOffset_bIsColorRevert;

		// Token: 0x04011211 RID: 70161
		internal static byte __PropertyMask_bIsColorRevert;

		// Token: 0x04011212 RID: 70162
		internal static int __PropertyOffset_bUseChangeColor;

		// Token: 0x04011213 RID: 70163
		internal static byte __PropertyMask_bUseChangeColor;

		// Token: 0x04011214 RID: 70164
		internal static int __PropertyOffset_ChangeColor;

		// Token: 0x04011215 RID: 70165
		internal static int __PropertyOffset_SpriteRotation;
	}
}
