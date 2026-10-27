using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002113 RID: 8467
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.TextureTransitionOfState")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FTextureTransitionOfState : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FDC1 RID: 130497 RVA: 0x002F657D File Offset: 0x002F477D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTextureTransitionOfState._ScriptStructPtr != 0) ? FTextureTransitionOfState._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.TextureTransitionOfState", ref FTextureTransitionOfState._ScriptStructPtr);
		}

		// Token: 0x17007D50 RID: 32080
		// (get) Token: 0x0601FDC2 RID: 130498 RVA: 0x002F65A1 File Offset: 0x002F47A1
		// (set) Token: 0x0601FDC3 RID: 130499 RVA: 0x002F65B5 File Offset: 0x002F47B5
		public unsafe FColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextureTransitionOfState.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextureTransitionOfState.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x17007D51 RID: 32081
		// (get) Token: 0x0601FDC4 RID: 130500 RVA: 0x002F65CA File Offset: 0x002F47CA
		// (set) Token: 0x0601FDC5 RID: 130501 RVA: 0x002F65DE File Offset: 0x002F47DE
		[Nullable(2)]
		public unsafe UTexture Texture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + FTextureTransitionOfState.__PropertyOffset_Texture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FTextureTransitionOfState.__PropertyOffset_Texture, value);
			}
		}

		// Token: 0x17007D52 RID: 32082
		// (get) Token: 0x0601FDC6 RID: 130502 RVA: 0x002F65F3 File Offset: 0x002F47F3
		// (set) Token: 0x0601FDC7 RID: 130503 RVA: 0x002F6603 File Offset: 0x002F4803
		public unsafe bool bSnapSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextureTransitionOfState.__PropertyOffset_bSnapSize) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextureTransitionOfState.__PropertyOffset_bSnapSize) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007D53 RID: 32083
		// (get) Token: 0x0601FDC8 RID: 130504 RVA: 0x002F6614 File Offset: 0x002F4814
		// (set) Token: 0x0601FDC9 RID: 130505 RVA: 0x002F662D File Offset: 0x002F482D
		public unsafe bool bGradualChange
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FTextureTransitionOfState.__PropertyOffset_bGradualChange) & FTextureTransitionOfState.__PropertyMask_bGradualChange) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FTextureTransitionOfState.__PropertyOffset_bGradualChange) = ((*(base.NativePtr + (IntPtr)FTextureTransitionOfState.__PropertyOffset_bGradualChange) & ~FTextureTransitionOfState.__PropertyMask_bGradualChange) | (value ? FTextureTransitionOfState.__PropertyMask_bGradualChange : 0));
			}
		}

		// Token: 0x17007D54 RID: 32084
		// (get) Token: 0x0601FDCA RID: 130506 RVA: 0x002F665D File Offset: 0x002F485D
		// (set) Token: 0x0601FDCB RID: 130507 RVA: 0x002F666D File Offset: 0x002F486D
		public unsafe float GradualDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextureTransitionOfState.__PropertyOffset_GradualDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextureTransitionOfState.__PropertyOffset_GradualDuration) = value;
			}
		}

		// Token: 0x17007D55 RID: 32085
		// (get) Token: 0x0601FDCC RID: 130508 RVA: 0x002F6680 File Offset: 0x002F4880
		// (set) Token: 0x0601FDCD RID: 130509 RVA: 0x002F66C3 File Offset: 0x002F48C3
		public FRenderableAdditionalInfo AdditionalInfo
		{
			get
			{
				base.FastCheckIsValid();
				FRenderableAdditionalInfo result;
				if ((result = this._AdditionalInfo) == null)
				{
					result = (this._AdditionalInfo = new FRenderableAdditionalInfo(base.NativePtr + (IntPtr)FTextureTransitionOfState.__PropertyOffset_AdditionalInfo, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRenderableAdditionalInfo.StaticStruct(), base.NativePtr + (IntPtr)FTextureTransitionOfState.__PropertyOffset_AdditionalInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601FDCE RID: 130510 RVA: 0x002F66E4 File Offset: 0x002F48E4
		public FTextureTransitionOfState()
		{
		}

		// Token: 0x0601FDCF RID: 130511 RVA: 0x002F66EC File Offset: 0x002F48EC
		public FTextureTransitionOfState(string PredefineColor, FColor Color, UTexture Texture, bool bSnapSize, bool bGradualChange, float GradualDuration, FRenderableAdditionalInfo AdditionalInfo)
		{
			this.Color = Color;
			this.Texture = Texture;
			this.bSnapSize = bSnapSize;
			this.bGradualChange = bGradualChange;
			this.GradualDuration = GradualDuration;
			this.AdditionalInfo = AdditionalInfo;
		}

		// Token: 0x0601FDD0 RID: 130512 RVA: 0x002F6722 File Offset: 0x002F4922
		protected override IntPtr GetUStructPtr()
		{
			return FTextureTransitionOfState.StaticStruct();
		}

		// Token: 0x0601FDD1 RID: 130513 RVA: 0x002F672E File Offset: 0x002F492E
		[NullableContext(2)]
		public FTextureTransitionOfState(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FDD2 RID: 130514 RVA: 0x002F6738 File Offset: 0x002F4938
		public FTextureTransitionOfState(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FDD3 RID: 130515 RVA: 0x002F6743 File Offset: 0x002F4943
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTextureTransitionOfState(Pointer, false, true);
		}

		// Token: 0x0601FDD4 RID: 130516 RVA: 0x002F674D File Offset: 0x002F494D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTextureTransitionOfState(Pointer, MemoryOwner);
		}

		// Token: 0x040112B5 RID: 70325
		public const string __ObjectPath = "/Script/LGUI.TextureTransitionOfState";

		// Token: 0x040112B6 RID: 70326
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040112B7 RID: 70327
		internal static int __PropertyOffset_Color;

		// Token: 0x040112B8 RID: 70328
		internal static int __PropertyOffset_Texture;

		// Token: 0x040112B9 RID: 70329
		internal static int __PropertyOffset_bSnapSize;

		// Token: 0x040112BA RID: 70330
		internal static int __PropertyOffset_bGradualChange;

		// Token: 0x040112BB RID: 70331
		internal static byte __PropertyMask_bGradualChange;

		// Token: 0x040112BC RID: 70332
		internal static int __PropertyOffset_GradualDuration;

		// Token: 0x040112BD RID: 70333
		internal static int __PropertyOffset_AdditionalInfo;

		// Token: 0x040112BE RID: 70334
		[Nullable(2)]
		private FRenderableAdditionalInfo _AdditionalInfo;
	}
}
