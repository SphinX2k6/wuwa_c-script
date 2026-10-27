using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200091A RID: 2330
	[UnrealObjectPath("/Script/Engine.CanvasIcon")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FCanvasIcon : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008057 RID: 32855 RVA: 0x000B823E File Offset: 0x000B643E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCanvasIcon._ScriptStructPtr != 0) ? FCanvasIcon._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CanvasIcon", ref FCanvasIcon._ScriptStructPtr);
		}

		// Token: 0x17001E28 RID: 7720
		// (get) Token: 0x06008058 RID: 32856 RVA: 0x000B8262 File Offset: 0x000B6462
		// (set) Token: 0x06008059 RID: 32857 RVA: 0x000B8276 File Offset: 0x000B6476
		[Nullable(2)]
		public unsafe UTexture Texture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + FCanvasIcon.__PropertyOffset_Texture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FCanvasIcon.__PropertyOffset_Texture, value);
			}
		}

		// Token: 0x17001E29 RID: 7721
		// (get) Token: 0x0600805A RID: 32858 RVA: 0x000B828B File Offset: 0x000B648B
		// (set) Token: 0x0600805B RID: 32859 RVA: 0x000B829B File Offset: 0x000B649B
		public unsafe float U
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCanvasIcon.__PropertyOffset_U);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCanvasIcon.__PropertyOffset_U) = value;
			}
		}

		// Token: 0x17001E2A RID: 7722
		// (get) Token: 0x0600805C RID: 32860 RVA: 0x000B82AC File Offset: 0x000B64AC
		// (set) Token: 0x0600805D RID: 32861 RVA: 0x000B82BC File Offset: 0x000B64BC
		public unsafe float V
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCanvasIcon.__PropertyOffset_V);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCanvasIcon.__PropertyOffset_V) = value;
			}
		}

		// Token: 0x17001E2B RID: 7723
		// (get) Token: 0x0600805E RID: 32862 RVA: 0x000B82CD File Offset: 0x000B64CD
		// (set) Token: 0x0600805F RID: 32863 RVA: 0x000B82DD File Offset: 0x000B64DD
		public unsafe float UL
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCanvasIcon.__PropertyOffset_UL);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCanvasIcon.__PropertyOffset_UL) = value;
			}
		}

		// Token: 0x17001E2C RID: 7724
		// (get) Token: 0x06008060 RID: 32864 RVA: 0x000B82EE File Offset: 0x000B64EE
		// (set) Token: 0x06008061 RID: 32865 RVA: 0x000B82FE File Offset: 0x000B64FE
		public unsafe float VL
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCanvasIcon.__PropertyOffset_VL);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCanvasIcon.__PropertyOffset_VL) = value;
			}
		}

		// Token: 0x06008062 RID: 32866 RVA: 0x000B830F File Offset: 0x000B650F
		public FCanvasIcon()
		{
		}

		// Token: 0x06008063 RID: 32867 RVA: 0x000B8317 File Offset: 0x000B6517
		[NullableContext(1)]
		public FCanvasIcon(UTexture Texture, float U, float V, float UL, float VL)
		{
			this.Texture = Texture;
			this.U = U;
			this.V = V;
			this.UL = UL;
			this.VL = VL;
		}

		// Token: 0x06008064 RID: 32868 RVA: 0x000B8344 File Offset: 0x000B6544
		protected override IntPtr GetUStructPtr()
		{
			return FCanvasIcon.StaticStruct();
		}

		// Token: 0x06008065 RID: 32869 RVA: 0x000B8350 File Offset: 0x000B6550
		[NullableContext(2)]
		public FCanvasIcon(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008066 RID: 32870 RVA: 0x000B835A File Offset: 0x000B655A
		public FCanvasIcon(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008067 RID: 32871 RVA: 0x000B8365 File Offset: 0x000B6565
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCanvasIcon(Pointer, false, true);
		}

		// Token: 0x06008068 RID: 32872 RVA: 0x000B836F File Offset: 0x000B656F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCanvasIcon(Pointer, MemoryOwner);
		}

		// Token: 0x04003D76 RID: 15734
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.CanvasIcon";

		// Token: 0x04003D77 RID: 15735
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003D78 RID: 15736
		internal static int __PropertyOffset_Texture;

		// Token: 0x04003D79 RID: 15737
		internal static int __PropertyOffset_U;

		// Token: 0x04003D7A RID: 15738
		internal static int __PropertyOffset_V;

		// Token: 0x04003D7B RID: 15739
		internal static int __PropertyOffset_UL;

		// Token: 0x04003D7C RID: 15740
		internal static int __PropertyOffset_VL;
	}
}
