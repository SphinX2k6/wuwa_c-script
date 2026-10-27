using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001522 RID: 5410
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ImposterManager.ImposterSlicePair")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UImposterSlicePair : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013B0A RID: 80650 RVA: 0x001CEBBA File Offset: 0x001CCDBA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UImposterSlicePair._ClassPtr;
		}

		// Token: 0x06013B0B RID: 80651 RVA: 0x001CEBC8 File Offset: 0x001CCDC8
		public UImposterSlicePair() : this(BuiltinUtils.AllocNativeUObject(UImposterSlicePair.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013B0C RID: 80652 RVA: 0x001CEBF0 File Offset: 0x001CCDF0
		[NullableContext(1)]
		public UImposterSlicePair(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UImposterSlicePair.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004D17 RID: 19735
		// (get) Token: 0x06013B0D RID: 80653 RVA: 0x001CEC23 File Offset: 0x001CCE23
		// (set) Token: 0x06013B0E RID: 80654 RVA: 0x001CEC37 File Offset: 0x001CCE37
		public unsafe UTexture2D BaseColor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UImposterSlicePair.__PropertyOffset_BaseColor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UImposterSlicePair.__PropertyOffset_BaseColor, value);
			}
		}

		// Token: 0x17004D18 RID: 19736
		// (get) Token: 0x06013B0F RID: 80655 RVA: 0x001CEC4C File Offset: 0x001CCE4C
		// (set) Token: 0x06013B10 RID: 80656 RVA: 0x001CEC60 File Offset: 0x001CCE60
		public unsafe UTexture2D NormalDepth
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UImposterSlicePair.__PropertyOffset_NormalDepth);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UImposterSlicePair.__PropertyOffset_NormalDepth, value);
			}
		}

		// Token: 0x06013B11 RID: 80657 RVA: 0x001CEC75 File Offset: 0x001CCE75
		static UImposterSlicePair()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ImposterManager.ImposterSlicePair");
		}

		// Token: 0x06013B12 RID: 80658 RVA: 0x001CEC83 File Offset: 0x001CCE83
		protected UImposterSlicePair(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AA1E RID: 43550
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ImposterManager.ImposterSlicePair";

		// Token: 0x0400AA1F RID: 43551
		private static IntPtr _ClassPtr;

		// Token: 0x0400AA20 RID: 43552
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AA21 RID: 43553
		internal static int __PropertyOffset_BaseColor;

		// Token: 0x0400AA22 RID: 43554
		internal static int __PropertyOffset_NormalDepth;
	}
}
