using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020003D9 RID: 985
	[UnrealObjectPath("/Script/AugmentedReality.ARVideoFormat")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FARVideoFormat : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600372A RID: 14122 RVA: 0x00053B9A File Offset: 0x00051D9A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FARVideoFormat._ScriptStructPtr != 0) ? FARVideoFormat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AugmentedReality.ARVideoFormat", ref FARVideoFormat._ScriptStructPtr);
		}

		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x0600372B RID: 14123 RVA: 0x00053BBE File Offset: 0x00051DBE
		// (set) Token: 0x0600372C RID: 14124 RVA: 0x00053BCE File Offset: 0x00051DCE
		public unsafe int FPS
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FARVideoFormat.__PropertyOffset_FPS);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FARVideoFormat.__PropertyOffset_FPS) = value;
			}
		}

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x0600372D RID: 14125 RVA: 0x00053BDF File Offset: 0x00051DDF
		// (set) Token: 0x0600372E RID: 14126 RVA: 0x00053BEF File Offset: 0x00051DEF
		public unsafe int Width
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FARVideoFormat.__PropertyOffset_Width);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FARVideoFormat.__PropertyOffset_Width) = value;
			}
		}

		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x0600372F RID: 14127 RVA: 0x00053C00 File Offset: 0x00051E00
		// (set) Token: 0x06003730 RID: 14128 RVA: 0x00053C10 File Offset: 0x00051E10
		public unsafe int Height
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FARVideoFormat.__PropertyOffset_Height);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FARVideoFormat.__PropertyOffset_Height) = value;
			}
		}

		// Token: 0x06003731 RID: 14129 RVA: 0x00053C21 File Offset: 0x00051E21
		public FARVideoFormat()
		{
		}

		// Token: 0x06003732 RID: 14130 RVA: 0x00053C29 File Offset: 0x00051E29
		public FARVideoFormat(int FPS, int Width, int Height)
		{
			this.FPS = FPS;
			this.Width = Width;
			this.Height = Height;
		}

		// Token: 0x06003733 RID: 14131 RVA: 0x00053C46 File Offset: 0x00051E46
		protected override IntPtr GetUStructPtr()
		{
			return FARVideoFormat.StaticStruct();
		}

		// Token: 0x06003734 RID: 14132 RVA: 0x00053C52 File Offset: 0x00051E52
		[NullableContext(2)]
		public FARVideoFormat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003735 RID: 14133 RVA: 0x00053C5C File Offset: 0x00051E5C
		public FARVideoFormat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003736 RID: 14134 RVA: 0x00053C67 File Offset: 0x00051E67
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FARVideoFormat(Pointer, false, true);
		}

		// Token: 0x06003737 RID: 14135 RVA: 0x00053C71 File Offset: 0x00051E71
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FARVideoFormat(Pointer, MemoryOwner);
		}

		// Token: 0x040017EE RID: 6126
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AugmentedReality.ARVideoFormat";

		// Token: 0x040017EF RID: 6127
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040017F0 RID: 6128
		internal static int __PropertyOffset_FPS;

		// Token: 0x040017F1 RID: 6129
		internal static int __PropertyOffset_Width;

		// Token: 0x040017F2 RID: 6130
		internal static int __PropertyOffset_Height;
	}
}
