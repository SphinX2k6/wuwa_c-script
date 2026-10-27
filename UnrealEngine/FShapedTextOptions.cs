using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020029D4 RID: 10708
	[UnrealObjectPath("/Script/UMG.ShapedTextOptions")]
	[UnrealStructLayout(3, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 3)]
	public class FShapedTextOptions : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060279A8 RID: 162216 RVA: 0x003C6800 File Offset: 0x003C4A00
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FShapedTextOptions._ScriptStructPtr != 0) ? FShapedTextOptions._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/UMG.ShapedTextOptions", ref FShapedTextOptions._ScriptStructPtr);
		}

		// Token: 0x170097BF RID: 38847
		// (get) Token: 0x060279A9 RID: 162217 RVA: 0x003C6824 File Offset: 0x003C4A24
		// (set) Token: 0x060279AA RID: 162218 RVA: 0x003C683D File Offset: 0x003C4A3D
		public unsafe bool bOverride_TextShapingMethod
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FShapedTextOptions.__PropertyOffset_bOverride_TextShapingMethod) & FShapedTextOptions.__PropertyMask_bOverride_TextShapingMethod) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FShapedTextOptions.__PropertyOffset_bOverride_TextShapingMethod) = ((*(base.NativePtr + (IntPtr)FShapedTextOptions.__PropertyOffset_bOverride_TextShapingMethod) & ~FShapedTextOptions.__PropertyMask_bOverride_TextShapingMethod) | (value ? FShapedTextOptions.__PropertyMask_bOverride_TextShapingMethod : 0));
			}
		}

		// Token: 0x170097C0 RID: 38848
		// (get) Token: 0x060279AB RID: 162219 RVA: 0x003C686D File Offset: 0x003C4A6D
		// (set) Token: 0x060279AC RID: 162220 RVA: 0x003C6886 File Offset: 0x003C4A86
		public unsafe bool bOverride_TextFlowDirection
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FShapedTextOptions.__PropertyOffset_bOverride_TextFlowDirection) & FShapedTextOptions.__PropertyMask_bOverride_TextFlowDirection) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FShapedTextOptions.__PropertyOffset_bOverride_TextFlowDirection) = ((*(base.NativePtr + (IntPtr)FShapedTextOptions.__PropertyOffset_bOverride_TextFlowDirection) & ~FShapedTextOptions.__PropertyMask_bOverride_TextFlowDirection) | (value ? FShapedTextOptions.__PropertyMask_bOverride_TextFlowDirection : 0));
			}
		}

		// Token: 0x170097C1 RID: 38849
		// (get) Token: 0x060279AD RID: 162221 RVA: 0x003C68B6 File Offset: 0x003C4AB6
		// (set) Token: 0x060279AE RID: 162222 RVA: 0x003C68C6 File Offset: 0x003C4AC6
		public unsafe ETextShapingMethod TextShapingMethod
		{
			get
			{
				return (ETextShapingMethod)(*(base.NativePtr + (IntPtr)FShapedTextOptions.__PropertyOffset_TextShapingMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FShapedTextOptions.__PropertyOffset_TextShapingMethod) = (byte)value;
			}
		}

		// Token: 0x170097C2 RID: 38850
		// (get) Token: 0x060279AF RID: 162223 RVA: 0x003C68D7 File Offset: 0x003C4AD7
		// (set) Token: 0x060279B0 RID: 162224 RVA: 0x003C68E7 File Offset: 0x003C4AE7
		public unsafe ETextFlowDirection TextFlowDirection
		{
			get
			{
				return (ETextFlowDirection)(*(base.NativePtr + (IntPtr)FShapedTextOptions.__PropertyOffset_TextFlowDirection));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FShapedTextOptions.__PropertyOffset_TextFlowDirection) = (byte)value;
			}
		}

		// Token: 0x060279B1 RID: 162225 RVA: 0x003C68F8 File Offset: 0x003C4AF8
		public FShapedTextOptions()
		{
		}

		// Token: 0x060279B2 RID: 162226 RVA: 0x003C6900 File Offset: 0x003C4B00
		public FShapedTextOptions(bool bOverride_TextShapingMethod, bool bOverride_TextFlowDirection, ETextShapingMethod TextShapingMethod, ETextFlowDirection TextFlowDirection)
		{
			this.bOverride_TextShapingMethod = bOverride_TextShapingMethod;
			this.bOverride_TextFlowDirection = bOverride_TextFlowDirection;
			this.TextShapingMethod = TextShapingMethod;
			this.TextFlowDirection = TextFlowDirection;
		}

		// Token: 0x060279B3 RID: 162227 RVA: 0x003C6925 File Offset: 0x003C4B25
		protected override IntPtr GetUStructPtr()
		{
			return FShapedTextOptions.StaticStruct();
		}

		// Token: 0x060279B4 RID: 162228 RVA: 0x003C6931 File Offset: 0x003C4B31
		[NullableContext(2)]
		public FShapedTextOptions(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060279B5 RID: 162229 RVA: 0x003C693B File Offset: 0x003C4B3B
		public FShapedTextOptions(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060279B6 RID: 162230 RVA: 0x003C6946 File Offset: 0x003C4B46
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FShapedTextOptions(Pointer, false, true);
		}

		// Token: 0x060279B7 RID: 162231 RVA: 0x003C6950 File Offset: 0x003C4B50
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FShapedTextOptions(Pointer, MemoryOwner);
		}

		// Token: 0x04015B35 RID: 88885
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.ShapedTextOptions";

		// Token: 0x04015B36 RID: 88886
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015B37 RID: 88887
		internal static int __PropertyOffset_bOverride_TextShapingMethod;

		// Token: 0x04015B38 RID: 88888
		internal static byte __PropertyMask_bOverride_TextShapingMethod;

		// Token: 0x04015B39 RID: 88889
		internal static int __PropertyOffset_bOverride_TextFlowDirection;

		// Token: 0x04015B3A RID: 88890
		internal static byte __PropertyMask_bOverride_TextFlowDirection;

		// Token: 0x04015B3B RID: 88891
		internal static int __PropertyOffset_TextShapingMethod;

		// Token: 0x04015B3C RID: 88892
		internal static int __PropertyOffset_TextFlowDirection;
	}
}
