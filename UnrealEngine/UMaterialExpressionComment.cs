using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D9F RID: 3487
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionComment")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UMaterialExpressionComment : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BDEE RID: 48622 RVA: 0x0010FDED File Offset: 0x0010DFED
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionComment._ClassPtr;
		}

		// Token: 0x0600BDEF RID: 48623 RVA: 0x0010FDFC File Offset: 0x0010DFFC
		public UMaterialExpressionComment() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionComment.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BDF0 RID: 48624 RVA: 0x0010FE24 File Offset: 0x0010E024
		public UMaterialExpressionComment(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionComment.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C0B RID: 11275
		// (get) Token: 0x0600BDF1 RID: 48625 RVA: 0x0010FE57 File Offset: 0x0010E057
		// (set) Token: 0x0600BDF2 RID: 48626 RVA: 0x0010FE67 File Offset: 0x0010E067
		public unsafe int SizeX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionComment.__PropertyOffset_SizeX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionComment.__PropertyOffset_SizeX) = value;
			}
		}

		// Token: 0x17002C0C RID: 11276
		// (get) Token: 0x0600BDF3 RID: 48627 RVA: 0x0010FE78 File Offset: 0x0010E078
		// (set) Token: 0x0600BDF4 RID: 48628 RVA: 0x0010FE88 File Offset: 0x0010E088
		public unsafe int SizeY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionComment.__PropertyOffset_SizeY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionComment.__PropertyOffset_SizeY) = value;
			}
		}

		// Token: 0x17002C0D RID: 11277
		// (get) Token: 0x0600BDF5 RID: 48629 RVA: 0x0010FE99 File Offset: 0x0010E099
		// (set) Token: 0x0600BDF6 RID: 48630 RVA: 0x0010FEAD File Offset: 0x0010E0AD
		public unsafe string Text
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UMaterialExpressionComment.__PropertyOffset_Text)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UMaterialExpressionComment.__PropertyOffset_Text)), value);
			}
		}

		// Token: 0x17002C0E RID: 11278
		// (get) Token: 0x0600BDF7 RID: 48631 RVA: 0x0010FEC2 File Offset: 0x0010E0C2
		// (set) Token: 0x0600BDF8 RID: 48632 RVA: 0x0010FED6 File Offset: 0x0010E0D6
		public unsafe FLinearColor CommentColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionComment.__PropertyOffset_CommentColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionComment.__PropertyOffset_CommentColor) = value;
			}
		}

		// Token: 0x17002C0F RID: 11279
		// (get) Token: 0x0600BDF9 RID: 48633 RVA: 0x0010FEEB File Offset: 0x0010E0EB
		// (set) Token: 0x0600BDFA RID: 48634 RVA: 0x0010FEFB File Offset: 0x0010E0FB
		public unsafe int FontSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionComment.__PropertyOffset_FontSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionComment.__PropertyOffset_FontSize) = value;
			}
		}

		// Token: 0x0600BDFB RID: 48635 RVA: 0x0010FF0C File Offset: 0x0010E10C
		static UMaterialExpressionComment()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionComment");
		}

		// Token: 0x0600BDFC RID: 48636 RVA: 0x0010FF1A File Offset: 0x0010E11A
		protected UMaterialExpressionComment(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006453 RID: 25683
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionComment";

		// Token: 0x04006454 RID: 25684
		private static IntPtr _ClassPtr;

		// Token: 0x04006455 RID: 25685
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006456 RID: 25686
		internal static int __PropertyOffset_SizeX;

		// Token: 0x04006457 RID: 25687
		internal static int __PropertyOffset_SizeY;

		// Token: 0x04006458 RID: 25688
		internal static int __PropertyOffset_Text;

		// Token: 0x04006459 RID: 25689
		internal static int __PropertyOffset_CommentColor;

		// Token: 0x0400645A RID: 25690
		internal static int __PropertyOffset_FontSize;
	}
}
