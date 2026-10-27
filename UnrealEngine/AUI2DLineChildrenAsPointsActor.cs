using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200211B RID: 8475
	[UnrealObjectPath("/Script/LGUI.UI2DLineChildrenAsPointsActor")]
	[UnrealStructLayout(1672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1672)]
	public class AUI2DLineChildrenAsPointsActor : AUIBaseActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FE29 RID: 130601 RVA: 0x002F70D6 File Offset: 0x002F52D6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AUI2DLineChildrenAsPointsActor._ClassPtr;
		}

		// Token: 0x0601FE2A RID: 130602 RVA: 0x002F70E4 File Offset: 0x002F52E4
		public AUI2DLineChildrenAsPointsActor() : this(BuiltinUtils.AllocNativeUObject(AUI2DLineChildrenAsPointsActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FE2B RID: 130603 RVA: 0x002F710C File Offset: 0x002F530C
		[NullableContext(1)]
		public AUI2DLineChildrenAsPointsActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AUI2DLineChildrenAsPointsActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007D67 RID: 32103
		// (get) Token: 0x0601FE2C RID: 130604 RVA: 0x002F713F File Offset: 0x002F533F
		// (set) Token: 0x0601FE2D RID: 130605 RVA: 0x002F7153 File Offset: 0x002F5353
		[Nullable(2)]
		public unsafe UUI2DLineChildrenAsPoints UIElement
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUI2DLineChildrenAsPoints>(base.NativePtr / (IntPtr)sizeof(void*) + AUI2DLineChildrenAsPointsActor.__PropertyOffset_UIElement);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AUI2DLineChildrenAsPointsActor.__PropertyOffset_UIElement, value);
			}
		}

		// Token: 0x0601FE2E RID: 130606 RVA: 0x002F7168 File Offset: 0x002F5368
		static AUI2DLineChildrenAsPointsActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UI2DLineChildrenAsPointsActor");
		}

		// Token: 0x0601FE2F RID: 130607 RVA: 0x002F7176 File Offset: 0x002F5376
		protected AUI2DLineChildrenAsPointsActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040112E4 RID: 70372
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UI2DLineChildrenAsPointsActor";

		// Token: 0x040112E5 RID: 70373
		private static IntPtr _ClassPtr;

		// Token: 0x040112E6 RID: 70374
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040112E7 RID: 70375
		internal static int __PropertyOffset_UIElement;
	}
}
