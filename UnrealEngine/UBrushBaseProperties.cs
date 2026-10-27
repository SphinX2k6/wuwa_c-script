using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200153A RID: 5434
	[UnrealObjectPath("/Script/InteractiveToolsFramework.BrushBaseProperties")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UBrushBaseProperties : UInteractiveToolPropertySet, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013BAE RID: 80814 RVA: 0x001CF9AC File Offset: 0x001CDBAC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBrushBaseProperties._ClassPtr;
		}

		// Token: 0x06013BAF RID: 80815 RVA: 0x001CF9B8 File Offset: 0x001CDBB8
		public UBrushBaseProperties() : this(BuiltinUtils.AllocNativeUObject(UBrushBaseProperties.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013BB0 RID: 80816 RVA: 0x001CF9E0 File Offset: 0x001CDBE0
		[NullableContext(1)]
		public UBrushBaseProperties(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBrushBaseProperties.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004D45 RID: 19781
		// (get) Token: 0x06013BB1 RID: 80817 RVA: 0x001CFA13 File Offset: 0x001CDC13
		// (set) Token: 0x06013BB2 RID: 80818 RVA: 0x001CFA23 File Offset: 0x001CDC23
		public unsafe float BrushSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBrushBaseProperties.__PropertyOffset_BrushSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBrushBaseProperties.__PropertyOffset_BrushSize) = value;
			}
		}

		// Token: 0x17004D46 RID: 19782
		// (get) Token: 0x06013BB3 RID: 80819 RVA: 0x001CFA34 File Offset: 0x001CDC34
		// (set) Token: 0x06013BB4 RID: 80820 RVA: 0x001CFA44 File Offset: 0x001CDC44
		public unsafe bool bSpecifyRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBrushBaseProperties.__PropertyOffset_bSpecifyRadius) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBrushBaseProperties.__PropertyOffset_bSpecifyRadius) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004D47 RID: 19783
		// (get) Token: 0x06013BB5 RID: 80821 RVA: 0x001CFA55 File Offset: 0x001CDC55
		// (set) Token: 0x06013BB6 RID: 80822 RVA: 0x001CFA65 File Offset: 0x001CDC65
		public unsafe float BrushRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBrushBaseProperties.__PropertyOffset_BrushRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBrushBaseProperties.__PropertyOffset_BrushRadius) = value;
			}
		}

		// Token: 0x17004D48 RID: 19784
		// (get) Token: 0x06013BB7 RID: 80823 RVA: 0x001CFA76 File Offset: 0x001CDC76
		// (set) Token: 0x06013BB8 RID: 80824 RVA: 0x001CFA86 File Offset: 0x001CDC86
		public unsafe float BrushStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBrushBaseProperties.__PropertyOffset_BrushStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBrushBaseProperties.__PropertyOffset_BrushStrength) = value;
			}
		}

		// Token: 0x17004D49 RID: 19785
		// (get) Token: 0x06013BB9 RID: 80825 RVA: 0x001CFA97 File Offset: 0x001CDC97
		// (set) Token: 0x06013BBA RID: 80826 RVA: 0x001CFAA7 File Offset: 0x001CDCA7
		public unsafe float BrushFalloffAmount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBrushBaseProperties.__PropertyOffset_BrushFalloffAmount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBrushBaseProperties.__PropertyOffset_BrushFalloffAmount) = value;
			}
		}

		// Token: 0x17004D4A RID: 19786
		// (get) Token: 0x06013BBB RID: 80827 RVA: 0x001CFAB8 File Offset: 0x001CDCB8
		// (set) Token: 0x06013BBC RID: 80828 RVA: 0x001CFAC8 File Offset: 0x001CDCC8
		public unsafe bool bShowStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBrushBaseProperties.__PropertyOffset_bShowStrength) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBrushBaseProperties.__PropertyOffset_bShowStrength) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004D4B RID: 19787
		// (get) Token: 0x06013BBD RID: 80829 RVA: 0x001CFAD9 File Offset: 0x001CDCD9
		// (set) Token: 0x06013BBE RID: 80830 RVA: 0x001CFAE9 File Offset: 0x001CDCE9
		public unsafe bool bShowFalloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBrushBaseProperties.__PropertyOffset_bShowFalloff) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBrushBaseProperties.__PropertyOffset_bShowFalloff) = (value ? 1 : 0);
			}
		}

		// Token: 0x06013BBF RID: 80831 RVA: 0x001CFAFA File Offset: 0x001CDCFA
		static UBrushBaseProperties()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.BrushBaseProperties");
		}

		// Token: 0x06013BC0 RID: 80832 RVA: 0x001CFB08 File Offset: 0x001CDD08
		protected UBrushBaseProperties(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AAC2 RID: 43714
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.BrushBaseProperties";

		// Token: 0x0400AAC3 RID: 43715
		private static IntPtr _ClassPtr;

		// Token: 0x0400AAC4 RID: 43716
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AAC5 RID: 43717
		internal static int __PropertyOffset_BrushSize;

		// Token: 0x0400AAC6 RID: 43718
		internal static int __PropertyOffset_bSpecifyRadius;

		// Token: 0x0400AAC7 RID: 43719
		internal static int __PropertyOffset_BrushRadius;

		// Token: 0x0400AAC8 RID: 43720
		internal static int __PropertyOffset_BrushStrength;

		// Token: 0x0400AAC9 RID: 43721
		internal static int __PropertyOffset_BrushFalloffAmount;

		// Token: 0x0400AACA RID: 43722
		internal static int __PropertyOffset_bShowStrength;

		// Token: 0x0400AACB RID: 43723
		internal static int __PropertyOffset_bShowFalloff;
	}
}
