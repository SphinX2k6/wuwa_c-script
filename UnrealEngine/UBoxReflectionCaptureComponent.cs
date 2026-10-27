using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008E9 RID: 2281
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BoxReflectionCaptureComponent")]
	[UnrealStructLayout(800, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 800)]
	public class UBoxReflectionCaptureComponent : UReflectionCaptureComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007D20 RID: 32032 RVA: 0x000B35D2 File Offset: 0x000B17D2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBoxReflectionCaptureComponent._ClassPtr;
		}

		// Token: 0x06007D21 RID: 32033 RVA: 0x000B35E0 File Offset: 0x000B17E0
		public UBoxReflectionCaptureComponent() : this(BuiltinUtils.AllocNativeUObject(UBoxReflectionCaptureComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007D22 RID: 32034 RVA: 0x000B3608 File Offset: 0x000B1808
		[NullableContext(1)]
		public UBoxReflectionCaptureComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBoxReflectionCaptureComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001D61 RID: 7521
		// (get) Token: 0x06007D23 RID: 32035 RVA: 0x000B363B File Offset: 0x000B183B
		// (set) Token: 0x06007D24 RID: 32036 RVA: 0x000B364B File Offset: 0x000B184B
		public unsafe float BoxTransitionDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBoxReflectionCaptureComponent.__PropertyOffset_BoxTransitionDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBoxReflectionCaptureComponent.__PropertyOffset_BoxTransitionDistance) = value;
			}
		}

		// Token: 0x17001D62 RID: 7522
		// (get) Token: 0x06007D25 RID: 32037 RVA: 0x000B365C File Offset: 0x000B185C
		// (set) Token: 0x06007D26 RID: 32038 RVA: 0x000B3670 File Offset: 0x000B1870
		public unsafe UBoxComponent PreviewInfluenceBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UBoxReflectionCaptureComponent.__PropertyOffset_PreviewInfluenceBox);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBoxReflectionCaptureComponent.__PropertyOffset_PreviewInfluenceBox, value);
			}
		}

		// Token: 0x17001D63 RID: 7523
		// (get) Token: 0x06007D27 RID: 32039 RVA: 0x000B3685 File Offset: 0x000B1885
		// (set) Token: 0x06007D28 RID: 32040 RVA: 0x000B3699 File Offset: 0x000B1899
		public unsafe UBoxComponent PreviewCaptureBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UBoxReflectionCaptureComponent.__PropertyOffset_PreviewCaptureBox);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBoxReflectionCaptureComponent.__PropertyOffset_PreviewCaptureBox, value);
			}
		}

		// Token: 0x06007D29 RID: 32041 RVA: 0x000B36AE File Offset: 0x000B18AE
		static UBoxReflectionCaptureComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BoxReflectionCaptureComponent");
		}

		// Token: 0x06007D2A RID: 32042 RVA: 0x000B36BC File Offset: 0x000B18BC
		protected UBoxReflectionCaptureComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003BF7 RID: 15351
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.BoxReflectionCaptureComponent";

		// Token: 0x04003BF8 RID: 15352
		private static IntPtr _ClassPtr;

		// Token: 0x04003BF9 RID: 15353
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003BFA RID: 15354
		internal static int __PropertyOffset_BoxTransitionDistance;

		// Token: 0x04003BFB RID: 15355
		internal static int __PropertyOffset_PreviewInfluenceBox;

		// Token: 0x04003BFC RID: 15356
		internal static int __PropertyOffset_PreviewCaptureBox;
	}
}
